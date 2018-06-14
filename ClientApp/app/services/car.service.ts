import { Http } from "@angular/http";
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/map'

@Injectable()
export class CarService {
  private readonly carsEndpoint = "/api/cars";

  constructor(private http: Http) {}
  getCars() {
    return this.http
      .get(this.carsEndpoint)
      .map(res => res.json());
  }
}
