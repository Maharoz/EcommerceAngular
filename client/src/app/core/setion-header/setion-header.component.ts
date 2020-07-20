import { Component, OnInit } from '@angular/core';
import { BreadcrumbService } from 'xng-breadcrumb';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-setion-header',
  templateUrl: './setion-header.component.html',
  styleUrls: ['./setion-header.component.scss']
})
export class SetionHeaderComponent implements OnInit {

  breadCrumb$:Observable<any[]>;

  constructor(private bcService:BreadcrumbService) { }

  ngOnInit(): void {
  this.breadCrumb$ =  this.bcService.breadcrumbs$;
  
  }

}
