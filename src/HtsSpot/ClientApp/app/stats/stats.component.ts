import {Component, OnInit} from '@angular/core';
import {MenuItem, Message} from 'primeng/primeng';
import {StatsService} from '../stats.service';
import {FacilityStats} from './facility-stats';

@Component({
    selector: 'app-stats',
    templateUrl: './stats.component.html',
    styleUrls: ['./stats.component.scss']
})
export class StatsComponent implements OnInit {

    public bcItems: MenuItem[];
    public bcHome: MenuItem;
    public title: string;
    public facilities: FacilityStats[];
    public errorMessage: Message[];
    public loading: boolean;
    public recordCount: number;
    public viewCount: number;
    public cols: any[];

    constructor(private statsService: StatsService) {
    }

    ngOnInit() {
        this.cols = [
            // {field: 'id', header: 'id'},
            {field: 'siteCode', header: 'MFL'},
            {field: 'name', header: 'Facility'},
            {field: 'county', header: 'County'},
            /*{field: 'partner', header: 'Partner'},*/
            {field: 'emr', header: 'EMR'},
            {field: 'clientCount', header: 'Clients'},
            // {field: 'dateCreated', header: 'dateCreated'},
            {field: 'lastUpdate', header: 'Last Update'},
            {field: 'timeAgo', header: ''}
        ];
        this.loading = true;
        this.title = 'Site Uploads';
        this.bcItems = [
            {label: 'Dashboard'}
        ];

        this.bcHome = {icon: 'fa fa-home', url: '/'};

        this.statsService.getCount()
            .subscribe(
                p => {
                    this.recordCount = p;

                },
                e => {
                    this.errorMessage = [];
                    this.errorMessage.push({severity: 'error', summary: 'Error Loading Summary', detail: <any> e});
                },
                () => {
                    console.log(this.recordCount);
                }
            );

        this.statsService.getStats()
            .subscribe(
                p => {
                    this.facilities = p;
                },
                e => {
                    this.errorMessage = [];
                    this.errorMessage.push({severity: 'error', summary: 'Error Loading Summary', detail: <any> e});
                },
                () => {
                    this.loading = false;
                }
            );
    }

}
