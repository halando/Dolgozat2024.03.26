import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-kolcsonzok',
  templateUrl: './kolcsonzok.component.html',
  styleUrls: ['./kolcsonzok.component.css']
})
export class KolcsonzokComponent {
kolcsonzok: any;
showRentals(arg0: any) {
throw new Error('Method not implemented.');
}
  customers:any=[];

  constructor(private baseService: BaseService) { }
 
  ngOnInit(): void {
  this.baseService.getCustomers().subscribe(data => {
  this.customers = data;
  });
  }
}
