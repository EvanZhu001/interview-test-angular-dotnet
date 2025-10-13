import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

interface Cow {
  id: number;
  birthDate: Date;
  breed: string;
  matureBodyWeight: number;
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  public cows: Cow[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Cow[]>(baseUrl + 'cows').subscribe({
      next: (result) => {
        this.cows = result;
      },
      error: (error) => {
        console.error(error);
      },
    });
  }

  ngOnInit() {}
}
