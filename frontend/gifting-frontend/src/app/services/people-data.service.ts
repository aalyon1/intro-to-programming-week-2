import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs';
import { PersonCreate, PersonListItem } from '../models/people';
import { Injectable } from '@angular/core';

@Injectable()
export class PersonDataService {

    constructor(private client:HttpClient) {}


    getPeople() {
        return this.client.get<{data: PersonListItem[]}>('http://localhost:1337/people')
        .pipe(
            map(response => response.data)
        );
    }

    addPerson(person:PersonCreate){
        return this.client.post<PersonListItem>('http://localhost:1337/people', person);
    }
}