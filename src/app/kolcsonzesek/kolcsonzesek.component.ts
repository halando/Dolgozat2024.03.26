import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-kolcsonzesek',
  templateUrl: './kolcsonzesek.component.html',
  styleUrls: ['./kolcsonzesek.component.css']
})
export class KolcsonzesekComponent {
 rentals:any=[];

  constructor(private baseService: BaseService) { }
 
  showRentals(customerId: number): void {
  this.baseService.getRentals(customerId).subscribe(data => {
  this.rentals = data;
  });
  }
}
