import { Http } from "@angular/http";
import { Injectable } from "@angular/core";
import "rxjs/add/operator/map";

@Injectable()
export class CarService {
  private readonly carsEndpoint = "/api/cars";

  constructor(private http: Http) {}
  getCars(options: any) {
    return this.http
      .get(this.carsEndpoint + "?" + this.toQueryString(options))
      .map(res => res.json());
  }

  getColors() {
    return this.http.get("/api/colors").map(res => res.json());
  }
  toQueryString(obj: any) {
    var parts = [];
    for (var property in obj) {
      var value = obj[property];
      if (value != null && value != undefined)
        parts.push(
          encodeURIComponent(property) + "=" + encodeURIComponent(value)
        );
    }
    return parts.join("&");
  }
}
