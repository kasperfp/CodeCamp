import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { ThemeParkService } from '../../services/theme-park.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit{

    themeParks: any;
    selectedThemeParkName: string = "";
    selectedLatitude: string = "";
    selectedLongitude: string = "";

    constructor(private http: Http, private themeParService: ThemeParkService) {}

    ngOnInit(): void {
        this.themeParService.getAll().subscribe(res => this.themeParks = res.json());
    }

    showThemePark(themePark: any) {
        this.selectedThemeParkName = themePark.themeParkName;
        this.selectedLatitude = themePark.latitude;
        this.selectedLongitude = themePark.longitude;
    }
}
