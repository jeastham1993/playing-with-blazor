﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HRM.Shared;

namespace HRM.Server.Services
{
    public interface IEmployeeDataService
    {
	    Task<IEnumerable<Employee>> GetAllEmployees();

	    Task<Employee> GetEmployeeDetails(
		    int employeeId);

	    Task<Employee> AddEmployee(
		    Employee employee);

	    Task UpdateEmployee(
		    Employee employee);

	    Task DeleteEmployee(
		    int employeeID);
    }
}