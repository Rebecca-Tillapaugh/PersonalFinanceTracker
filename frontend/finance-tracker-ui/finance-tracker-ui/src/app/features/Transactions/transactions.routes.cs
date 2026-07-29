import { Routes } from '@angular/router';

export const transactionRoutes: Routes = [
  {
    path: '',
    loadComponent: () =>
      import('./pages/transaction-list-page/transaction-list-page.component')
        .then(m => m.TransactionListPageComponent)
  },
  {
    path: 'new',
    loadComponent: () =>
      import('./pages/create-transaction-page/create-transaction-page.component')
        .then(m => m.CreateTransactionPageComponent)
  },
  {
    path: ':id/edit',
    loadComponent: () =>
      import('./pages/edit-transaction-page/edit-transaction-page.component')
        .then(m => m.EditTransactionPageComponent)
  }
];