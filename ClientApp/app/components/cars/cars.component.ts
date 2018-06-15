import { CarService } from "./../../services/car.service";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cars",
  templateUrl: "./cars.component.html",
  styleUrls: ["./cars.component.css"],
  providers: [CarService]
})
export class CarsComponent implements OnInit {
  cars: any = {};
  colors: any = [];
  options: any = { };
  columns: any = [
    { title: "Make" },
    { title: "Year" },
    { title: "Color" },
    { title: "Price" },
    {}
  ];
  constructor(private carService: CarService) {}

  ngOnInit() {
    this.populateColors();
    this.populateCars();
  }

  private populateCars() {
    this.carService.getCars(this.options)
      .subscribe(result => this.cars = result);
  }
  private populateColors() {
    this.carService.getColors()
      .subscribe(result => this.colors = result);
  }
  onFilterChange() {
    this.populateCars();
  }
  resetFilter() {
    this.options = {};
  }
}
