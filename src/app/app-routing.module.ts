import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LibaryComponent } from './libary/libary.component';
import { KolcsonzesekComponent } from './kolcsonzesek/kolcsonzesek.component';

const routes: Routes = [
  {path:'home', component:HomeComponent},
  {path:'kolcsonzok', component:KolcsonzesekComponent},
  {path:'kolcsonzesek', component:KolcsonzesekComponent},
  {path:'libary', component:LibaryComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
