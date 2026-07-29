import { Routes } from '@angular/router';

export const budgetRoutes: Routes = [
  {
    path: '',
    loadComponent: () =>
      import('./pages/budget-list-page/budget-list-page.component')
        .then(m => m.BudgetListPageComponent)
  },
  {
    path: 'new',
    loadComponent: () =>
      import('./pages/create-budget-page/create-budget-page.component')
        .then(m => m.CreateBudgetPageComponent)
  },
  {
    path: ':id/edit',
    loadComponent: () =>
      import('./pages/edit-budget-page/edit-budget-page.component')
        .then(m => m.EditBudgetPageComponent)
  }
];