import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import {Post} from './post';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  private postsUrl = 'api/post';  // URL to web api

  /** GET posts from the server */
  getPosts (): Observable<Post[]> {
    return this.http.get<Post[]>(this.postsUrl)
  }

  /** GET post by permalink. Will 404 if id not found */
  getPost(permalink: string): Observable<Post> {
    const url = `${this.postsUrl}/${permalink}`;
    return this.http.get<Post>(url);
  }

  constructor(private http: HttpClient) { }
}
