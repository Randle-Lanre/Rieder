import { TestBed } from '@angular/core/testing';

import { RiederServiceService } from './rieder-service.service';

describe('RiederServiceService', () => {
  let service: RiederServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RiederServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
