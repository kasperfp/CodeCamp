import { Injectable, OnInit } from '@angular/core';
import { Http } from '@angular/http';

export class UserService {
    constructor(private http: Http) {}

    getAll() {
        return this.http.get('http://localhost:54241/api/ThemeParks/GetAll');
    }
}
