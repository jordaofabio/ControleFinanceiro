import { Component } from "@angular/core";
import { dataServices } from '../servicos/dataService'

@Component({
selector: "lista-exemplo",
templateUrl: "./listaExemplo.component.html",
styleUrls: ["./listaExemplo.component.scss"]
})

export class ListaExemplo {

  constructor(private data: dataServices){
    this.lista = data.produtos;
  }

  public lista = [];
}
