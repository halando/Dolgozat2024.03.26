import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {


  constructor(private http: HttpClient) { }

  getCustomers(): Observable<any> {
  return this.http.get<any>('api/customers');
  }
 
  getRentals(customerId: number): Observable<any> {
  return this.http.get<any>(`api/customers/${customerId}/rentals`);
  }
 
}
