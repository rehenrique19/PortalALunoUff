import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AngularMaterialModule } from './angularMaterial.module';
import { NavMenuModule } from './nav-menu/nav-menu.module';
import { AppServerModule } from './app.server.module';
import { AppRoutingModule } from './app.rounting.module';
import { ProjetoModule } from './projeto/projeto.module';
@NgModule({

  declarations: [
    AppComponent
  ],
  imports: [
    AppRoutingModule,
    NavMenuModule,
    ProjetoModule,
    AngularMaterialModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
