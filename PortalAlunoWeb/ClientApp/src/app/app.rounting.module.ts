import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProjetoComponent } from './projeto/projeto.component';
@NgModule({
  imports: [
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'projetos', component: ProjetoComponent },
    ])
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
