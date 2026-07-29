import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateBudgetPageComponent } from './create-budget-page.component';

describe('CreateBudgetPageComponent', () => {
  let component: CreateBudgetPageComponent;
  let fixture: ComponentFixture<CreateBudgetPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateBudgetPageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateBudgetPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
