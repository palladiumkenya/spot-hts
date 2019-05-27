import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {FacilityStats} from './stats/facility-stats';

@Injectable({
  providedIn: 'root'
})
export class StatsService {

    private url = 'api/Stats';

    constructor(private http: HttpClient) {
    }

    getCount(): Observable<number> {
        return this.http.get<number>(`${this.url}/Count`);
    }

    getStats(): Observable<FacilityStats[]> {
        return this.http.get<FacilityStats[]>(this.url);
    }
}
