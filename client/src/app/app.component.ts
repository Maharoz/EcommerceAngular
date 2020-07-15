import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {IProduct} from './shared/models/product';
import {IPagination} from './shared/models/pagination';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'Ecommerce';
  products:IProduct[];

  constructor(private http:HttpClient){

  }

  ngOnInit(): void {
    this.http.get('https://localhost:44358/api/products?pageSize=50')
    .subscribe((response:IPagination)=>{
     // console.log(response);
      this.products= response.data;
    },error=>{
      console.log(error);
    })
  }
  
  
}
