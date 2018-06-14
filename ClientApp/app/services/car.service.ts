import { Http } from '@angular/http';
import { Injectable } from '@angular/core';

@Injectable()
export class CarService {
    private readonly carsEndpoint = '/api/cars';

constructor(private http: Http) { }

}
