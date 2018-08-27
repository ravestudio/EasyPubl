import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { PostService }  from '../post.service';
import {Post} from '../post'

@Component({
  selector: 'app-post-view',
  templateUrl: './post-view.component.html',
  styleUrls: ['./post-view.component.css']
})
export class PostViewComponent implements OnInit {
  post: Post;

  constructor(private route: ActivatedRoute, private postService: PostService) { }

  ngOnInit() {
    this.getPost();
  }

  getPost(): void {
    const permalink = this.route.snapshot.paramMap.get('permalink');
    this.postService.getPost(permalink)
      .subscribe(post => this.post = post);
  }

}
