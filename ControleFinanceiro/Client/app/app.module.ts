import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaExemplo } from './ListaExemplo/listaExemplo.component';
import { dataServices } from './servicos/dataService';

@NgModule({
  declarations: [
    AppComponent,
    ListaExemplo
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ],
  providers: [dataServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
