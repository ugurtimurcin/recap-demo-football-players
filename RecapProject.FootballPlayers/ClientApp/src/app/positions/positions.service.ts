import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { from, Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Position } from "./position"

@Injectable({
  providedIn: 'root'
})
export class PositionsService {
  private apiUrl = "http://localhost:64057/api";

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  constructor(private httpClient: HttpClient) { }
  getPositions(): Observable<Position[]> {
    return this.httpClient.get<Position[]>(this.apiUrl + '/positions/getall')
      .pipe(
        catchError(this.errorHandler)
      )
  }

  getPosition(id): Observable<Position> {
    return this.httpClient.get<Position>(this.apiUrl + '/positions/getbyid?id=' + id)
      .pipe(
        catchError(this.errorHandler)
      );
  }

  createPosition(position): Observable<Position> {
    return this.httpClient.post<Position>(this.apiUrl + '/positions/add', JSON.stringify(position))
      .pipe(
        catchError(this.errorHandler)
      );
  }

  updatePosition(position) {
    return this.httpClient.put<Position>(this.apiUrl + 'positions/update', JSON.stringify(position))
      .pipe(
        catchError(this.errorHandler)
      );
  }

  errorHandler(error) {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
}
