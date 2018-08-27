import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PostsComponent} from './posts/posts.component';
import { PostViewComponent} from './post-view/post-view.component';

const routes: Routes = [
  //{ path: '', redirectTo: '/posts', pathMatch: 'full' },
  { path: '', component: PostsComponent },
  { path: ':permalink', component: PostViewComponent },
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
