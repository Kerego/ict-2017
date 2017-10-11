import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PresentationGridComponent } from './presentation-grid.component';

describe('PresentationGridComponent', () => {
  let component: PresentationGridComponent;
  let fixture: ComponentFixture<PresentationGridComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PresentationGridComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PresentationGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
