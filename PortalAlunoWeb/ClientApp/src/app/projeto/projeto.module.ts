import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ProjetoComponent } from './projeto.component';
import { AngularMaterialModule } from '../angularMaterial.module';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    ProjetoComponent
  ],
  imports: [
    FormsModule,
    AngularMaterialModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
  ],
  exports: [
    ProjetoComponent
  ]
})
export class ProjetoModule { }
