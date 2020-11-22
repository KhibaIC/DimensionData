using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{

    public class EmployeeController
    {

        // info (personal)
        [Key]
        public int employeeNumber { get; set; }
        public string employeeName { get; set; }
        public int age { get; set; }
        public bool ove18 { get; set; }
        public string education { get; set; }
        public string educationField { get; set; }
        public string gender { get; set; }
        public int distanceFromHome { get; set; }
        public int workLifeBalace { get; set; }
        public string maritalStatus { get; set; }
        public bool overTime { get; set; }
        public string businessTravel { get; set; }
        public int numCompaniesWorked { get; set; }

        // manage info
        public bool attrition { get; set; }
        public string department { get; set; }
        public int dailyRate { get; set; }
        public int empCount { get; set; }
        public int hourlyRate { get; set; }
        public int standardHours { get; set; }
        public int jobInvolvement { get; set; }
        public int jobLevel { get; set; }
        public string jobRole { get; set; }
        public int monthlyIncome { get; set; }
        public int monthlyRate { get; set; }
        public int percentageSalaryHike { get; set; }
        public int performanceRating { get; set; }

        //(extra information)
        public int environmentSatisfaction { get; set; }
        public string stockOptionlevel { get; set; }
        public string relationshipSatisfaction { get; set; }
        public int totalWorkingYears { get; set; }
        public int traningTimesLastYear { get; set; }
        public string traningAtCompany { get; set; }
        public int yearsInCurrentRole { get; set; }
        public int yearsSinceLastpromotion { get; set; }
        public int yearsWithCurrentManager { get; set; }








    }

}
