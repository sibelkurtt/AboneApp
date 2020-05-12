/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AboneComponent } from './abone.component';

describe('AboneComponent', () => {
  let component: AboneComponent;
  let fixture: ComponentFixture<AboneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AboneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AboneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
