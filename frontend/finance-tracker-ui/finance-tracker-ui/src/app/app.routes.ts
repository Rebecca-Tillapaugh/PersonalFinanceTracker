import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./features/Dashboard/dashboard.routes')
        .then(m => m.dashboardRoutes)
  },
  {
    path: 'categories',
    loadChildren: () =>
      import('./features/Categories/categories.routes')
        .then(m => m.categoryRoutes)
  },
  {
    path: 'transactions',
    loadChildren: () =>
      import('./features/Transactions/transactions.routes')
        .then(m => m.transactionRoutes)
  },
  {
    path: 'budgets',
    loadChildren: () =>
      import('./features/Budgets/budgets.routes')
        .then(m => m.budgetRoutes)
  },
  {
    path: '**',
    redirectTo: ''
  }
];