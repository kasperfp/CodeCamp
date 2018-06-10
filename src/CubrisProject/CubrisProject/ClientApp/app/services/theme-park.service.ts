import { OnInit, Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class ThemeParkService {
    constructor(private http: Http) {}

    getAll() {
        return this.http.get('http://localhost:54241/api/ThemeParks/GetAll');
    }
}
