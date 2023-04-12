﻿using System.Net;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult StudentDetails() {
		 StudentModel sunita = new StudentModel();
			sunita.Rollno = 34;
			sunita.Name = "Sunita Khakurel";
			sunita.Address = "Banepa";
			sunita.College = "NIST";
			sunita.Phonenumber = 98699344;
			return View(sunita);
		}
        public IActionResult StudentEdit()
        {
            StudentModel sunita = new StudentModel();
            sunita.Rollno = 34;
            sunita.Name = "Sunita Khakurel";
            sunita.Address = "Banepa";
            sunita.College = "NIST";
            sunita.Phonenumber = 98699344;
            return View(sunita);
        }
		public IActionResult StudentList() {
			List<StudentModel> students = new List<StudentModel>();
			StudentModel sunita = new StudentModel()
			{
				Rollno = 1, Name = "sunita", Address = "Banepa",
				College = "NIST",
				Phonenumber = 986088763,




			};
			StudentModel suman = new StudentModel()
			{
				Rollno = 2,
				Name = "suman",
				Address = "Banepa",
				College = "NIST",
				Phonenumber = 986088666,



			};
			StudentModel prayeshna = new StudentModel()
			{
				Rollno = 3,
				Name = "Prayeshna",
				Address = "Banepa",
				College = "Nist",
				Phonenumber = 986088763,



			};
			StudentModel Amy = new StudentModel()
			{
				Rollno = 4,
			Name = "Amy",
			Address = "Panauti",
			College = "NIST",
			Phonenumber = 986088663,



		};
			students.Add(sunita);
			students.Add(suman);
			students.Add(prayeshna);
			students.Add(Amy);
			return View(students);

		}
    }
}
