import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Presentation } from '../models/presentation';
import { Observable } from 'rxjs/Observable';
import { GalleryItem } from '../models/gallery-item';
import 'rxjs/add/operator/map';

@Injectable()
export class IctService {
  constructor(private http: HttpClient) {

  }

  getPresentations() {
    return this.http.get<Presentation[]>('api/presentations');
  }

  getGalleryItem(page: number) {
    return this.http.get<GalleryItem>(`api/gallery/${page}`);
  }

  clapPresentation(id: number) {
    return this.http.post('api/presentations', { id: id });
  }
}
