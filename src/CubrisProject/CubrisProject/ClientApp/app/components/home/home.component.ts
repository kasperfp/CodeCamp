import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ThemeParkService } from '../../services/theme-park.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit{

    themeParks: any;

    constructor(private http: Http, private themeParService: ThemeParkService) { }

    ngOnInit(): void {
        this.themeParService.getAll().subscribe(res => {
            console.log("res: " + res.json());
            this.themeParks = res.json();
        }, err => { console.log("err: " + err); });
    }

    showThemePark(themePark: any) {
        console.log(themePark.themeParkId);
        console.log(themePark.latitude);
        console.log(themePark.longitude);
    }
}
