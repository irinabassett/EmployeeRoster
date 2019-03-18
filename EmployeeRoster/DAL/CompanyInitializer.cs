﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeRoster.Models;

namespace EmployeeRoster.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var employees = new List<Employee>
            {
            new Employee{FirstName="Deborah",MiddleInitial="A",LastName="Gilbert",HireDate=DateTime.Parse("2001-09-01")},
            new Employee{FirstName="Tracy",MiddleInitial="H",LastName="Bell",HireDate=DateTime.Parse("2003-11-21")},
            new Employee{FirstName="LaToya",MiddleInitial="M",LastName="Morrison",HireDate=DateTime.Parse("2009-10-01")},
            new Employee{FirstName="LaTasha",MiddleInitial="A",LastName="Hanson",HireDate=DateTime.Parse("2015-06-01")},
            new Employee{FirstName="Chris",MiddleInitial="S",LastName="Wilson",HireDate=DateTime.Parse("2016-04-18")},
            new Employee{FirstName="Stephanie",MiddleInitial="A",LastName="Payne",HireDate=DateTime.Parse("2010-07-15")},
            new Employee{FirstName="Donika",MiddleInitial="H",LastName="Thomas",HireDate=DateTime.Parse("2015-10-01")},
            new Employee{FirstName="Patty",MiddleInitial="L",LastName="Gattie",HireDate=DateTime.Parse("2018-04-15")},
            new Employee{FirstName="Lisa",MiddleInitial="D",LastName="Warren",HireDate=DateTime.Parse("2018-02-12")},
            new Employee{FirstName="Irina",MiddleInitial="",LastName="Bassett",HireDate=DateTime.Parse("2016-04-18")},
            new Employee{FirstName="Misty",MiddleInitial="M",LastName="Porter",HireDate=DateTime.Parse("2015-10-01")},
            new Employee{FirstName="Francine",MiddleInitial="L",LastName="Rickman",HireDate=DateTime.Parse("2015-10-01")},
            new Employee{FirstName="Shannon",MiddleInitial="A",LastName="Wilson",HireDate=DateTime.Parse("2015-06-15")},
            new Employee{FirstName="Amy",MiddleInitial="D",LastName="DeVary",HireDate=DateTime.Parse("2016-04-18")},
            new Employee{FirstName="Dawn",MiddleInitial="N",LastName="Hizer",HireDate=DateTime.Parse("2017-01-15")},
            new Employee{FirstName="Danisha",MiddleInitial="P",LastName="Doub",HireDate=DateTime.Parse("2015-10-01")},
            new Employee{FirstName="Theresa",MiddleInitial="D",LastName="Shelby",HireDate=DateTime.Parse("2014-04-11")},
            new Employee{FirstName="Erinne",MiddleInitial="M",LastName="Holt",HireDate=DateTime.Parse("2014-04-11")},
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var positions = new List<Position>
            {
            new Position{PositionID=1010,Title="Director",},
            new Position{PositionID=1015,Title="Assistant Director",},
            new Position{PositionID=1020,Title="Supervisor",},
            new Position{PositionID=1025,Title="Housing Specialist",},
            new Position{PositionID=1030,Title="Clerical",},
            new Position{PositionID=1035,Title="Ombundsman",},
            new Position{PositionID=1040,Title="Support",}
            };

            positions.ForEach(s => context.Positions.Add(s));
            context.SaveChanges();

            var employments = new List<Employment>
            {
            new Employment{EmployeeID=1,PositionID=1010,EvalScore=EvalScore.A},
            new Employment{EmployeeID=2,PositionID=1015,EvalScore=EvalScore.A},
            new Employment{EmployeeID=3,PositionID=1020,EvalScore=EvalScore.B},
            new Employment{EmployeeID=4,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=5,PositionID=1025,EvalScore=EvalScore.D},
            new Employment{EmployeeID=6,PositionID=1025,EvalScore=EvalScore.A},
            new Employment{EmployeeID=7,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=8,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=9,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=10,PositionID=1025,EvalScore=EvalScore.A},
            new Employment{EmployeeID=11,PositionID=1025,EvalScore=EvalScore.A},
            new Employment{EmployeeID=12,PositionID=1025,EvalScore=EvalScore.A},
            new Employment{EmployeeID=13,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=14,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=15,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=16,PositionID=1025,EvalScore=EvalScore.B},
            new Employment{EmployeeID=17,PositionID=1025,EvalScore=EvalScore.A},
            new Employment{EmployeeID=18,PositionID=1025,EvalScore=EvalScore.A},
            };

            employments.ForEach(s => context.Employments.Add(s));
            context.SaveChanges();
        }
    }
}




   
        
 