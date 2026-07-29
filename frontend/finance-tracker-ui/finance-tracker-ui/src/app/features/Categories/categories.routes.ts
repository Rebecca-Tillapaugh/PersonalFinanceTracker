import { Routes } from '@angular/router';

export const categoryRoutes: Routes = [
  {
    path: '',
    loadComponent: () =>
      import('./pages/category-list-page/category-list-page.component')
        .then(m => m.CategoryListPageComponent)
  },
  {
    path: 'new',
    loadComponent: () =>
      import('./pages/create-category-page/create-category-page.component')
        .then(m => m.CreateCategoryPageComponent)
  },
  {
    path: ':id/edit',
    loadComponent: () =>
      import('./pages/edit-category-page/edit-category-page.component')
        .then(m => m.EditCategoryPageComponent)
  }
];