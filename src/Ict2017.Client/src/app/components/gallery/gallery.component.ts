import { Component, OnInit } from '@angular/core';
import { IctService } from '../../services/ict.service';
import { GalleryItem } from '../../models/gallery-item';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnInit {
  galleryItem: GalleryItem

  constructor(private ictService: IctService) { }

  loadItem(page: number = 1) {
    this.ictService.getGalleryItem(page).subscribe(item => this.galleryItem = item)
  }

  ngOnInit() {
    this.loadItem()
  }

  prevItem() {
    this.loadItem(this.galleryItem.id - 1)
  }

  nextItem() {
    this.loadItem(this.galleryItem.id + 1)
  }

}
