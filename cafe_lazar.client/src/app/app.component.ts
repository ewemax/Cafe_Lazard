import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Drink {
  totalPrice: number;
  name: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})


export class AppComponent implements OnInit {
  public Drinks: Drink[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getDrinks();
  }

  

  getDrinks() {
    this.http.get<Drink[]>('https://localhost:7287/Drink').subscribe(
      (result) => {
        this.Drinks = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  alert(args: number) {
    window.alert('La boisson coute' + args / 100 + '€');
  }

  title = 'cafe_lazard.client';
}
