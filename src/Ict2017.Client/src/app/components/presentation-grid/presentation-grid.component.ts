import { Component, OnInit } from '@angular/core';
import { Presentation } from '../../models/presentation';
import { IctService } from '../../services/ict.service';

@Component({
  selector: 'app-presentation-grid',
  templateUrl: './presentation-grid.component.html',
  styleUrls: ['./presentation-grid.component.css']
})
export class PresentationGridComponent implements OnInit {
  presentations: Presentation[]

  constructor(private ictService: IctService) { }

  ngOnInit() {
    this.ictService
      .getPresentations()
      .subscribe(presentations => this.presentations = presentations)
  }

  clap(presentation: Presentation) {
    this.ictService
      .clapPresentation(presentation.id)
      .subscribe(success => {
        presentation.clapCount++;
        localStorage.setItem(`clap${presentation.id}`, '1');
      });
  }

  canClap(id: number) {
    return localStorage.getItem(`clap${id}`) == null;
  }
}
