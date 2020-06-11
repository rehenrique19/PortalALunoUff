import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AngularMaterialModule } from '../angularMaterial.module';
import { NavMenuComponent } from './nav-menu.component';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    NavMenuComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    FormsModule,
    AngularMaterialModule,
    HttpClientModule,
  ],
  exports: [
    NavMenuComponent
  ]
})
export class NavMenuModule { }
