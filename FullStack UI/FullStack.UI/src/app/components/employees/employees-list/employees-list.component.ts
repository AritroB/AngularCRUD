import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit{

  employees: Employee[] = [
    {
      id: "123abc-13fg32-34fvr3",
      name: "John Doe",
      email: "johndoe@example.com",
      phone: 1234567890,
      salary: 5000,
      department: "IT"
    },
    {
      id: "456def-98ht76-21vbg7",
      name: "Jane Smith",
      email: "janesmith@example.com",
      phone: 9876543210,
      salary: 6000,
      department: "Finance"
    },
    {
      id: "789ghi-54ko98-76nbt4",
      name: "Alex Johnson",
      email: "alexjohnson@example.com",
      phone: 5555555555,
      salary: 4500,
      department: "Marketing"
    }
  ];
  constructor() { }

  ngOnInit(): void {
      this.employees.push();
  }
}
