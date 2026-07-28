import { Component, OnInit } from '@angular/core';
import { HealthService } from './core/services/health.service';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  status = 'Connecting...';
  error = '';

  constructor(private healthService: HealthService) {}

  ngOnInit(): void {
    this.healthService.getHealth().subscribe({
      next: (response) => {
        this.status = response.status;
      },
      error: () => {
        this.error = 'Unable to reach the backend API.';
        this.status = 'Offline';
      }
    });
  }
}
