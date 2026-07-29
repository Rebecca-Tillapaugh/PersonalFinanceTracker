import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BudgetListPageComponent } from './budget-list-page.component';

describe('BudgetListPageComponent', () => {
  let component: BudgetListPageComponent;
  let fixture: ComponentFixture<BudgetListPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BudgetListPageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BudgetListPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
