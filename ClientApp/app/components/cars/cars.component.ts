import { CarService } from './../../services/car.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css'],
  providers: [CarService]
})
export class CarsComponent implements OnInit {
  cars: any = {};
  columns: any = [
    { title: 'Make'},
    { title: 'Year'},
    { title: 'Color'},
    { title: 'Price'},
    { }
  ];
  constructor(private carService: CarService) { }

  ngOnInit() {
    this.carService.getCars()
      .subscribe(result => this.cars = result);
  }

}
