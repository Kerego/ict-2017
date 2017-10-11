import { TestBed, inject } from '@angular/core/testing';

import { IctService } from './ict.service';

describe('IctService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IctService]
    });
  });

  it('should be created', inject([IctService], (service: IctService) => {
    expect(service).toBeTruthy();
  }));
});
