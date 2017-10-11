import { Component, OnInit } from '@angular/core';
import { IctService } from '../../services/ict.service';
import { GalleryItem } from '../../models/gallery-item';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {
  model: GalleryItem

  constructor(private ictService: IctService, private activatedRoute: ActivatedRoute) { }

  loadItem(page: number = 1) {
    this.ictService.getGalleryItem(page).subscribe(item => this.model = item)
  }

  ngOnInit() {
    this.activatedRoute.params.subscribe(params => {
      var page = +params['page'];
      this.loadItem(page);
    })
  }
}
