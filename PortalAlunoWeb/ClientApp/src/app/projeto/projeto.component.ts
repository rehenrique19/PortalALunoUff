import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-projeto',
  templateUrl: './projeto.component.html'
})
export class ProjetoComponent implements OnInit {
  displayedColumns: string[];
  test;
  dataSource;
  http;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
  }

  ngOnInit() {
    this.http.get('api/Pessoa/Obter').subscribe(result => {
      console.log(result);
      this.test = result;
      this.displayedColumns = ['nome', 'email', 'criadoPor'];
      this.dataSource = this.test;
      console.log(this.test);
      console.log(this.dataSource);
    }, error => console.error(error));
  }    
}
