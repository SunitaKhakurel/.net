using System.Net;
using System.Security.Cryptography.X509Certificates;
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

		public IActionResult College() {
			List<Collegemodel> colleges = new List<Collegemodel>();
			//Collegemodel nist = new Collegemodel()
			//{
			//	CollegeName = "NIST", University = "TU", Address = "Banepa"
			//};
			//Collegemodel BMC = new Collegemodel()
			//{
			//	CollegeName = "BMC",
			//	University = "TU",
			//	Address = "Bhaktapur"

			//};
			//	colleges.Add(nist);
			//	colleges.Add (BMC);
			StreamReader sr = new StreamReader("wwwroot/college.txt");
			string line=sr.ReadLine();
			while (line != null)
			{
				String[] collegeData=line.Split(',');
				Collegemodel college = new Collegemodel();
				college.CollegeName = collegeData[0];
				college.University = collegeData[1];
				college.Address = collegeData[2];
				colleges.Add(college);
				line = sr.ReadLine();

			}
			sr.Close();
			return View(colleges); 
		}
        public IActionResult GetCollege(String CollegeName)
        {
            List<Collegemodel> colleges = new List<Collegemodel>();
            Collegemodel nist = new Collegemodel()
            {
                CollegeName = "NIST",
                University = "TU",
                Address = "Banepa"
            };
            Collegemodel BMC = new Collegemodel()
            {
                CollegeName = "BMC",
                University = "TU",
                Address = "Bhaktapur"

            };
            colleges.Add(nist);
            colleges.Add(BMC);
			Collegemodel college =colleges.Where(x=>x.CollegeName==CollegeName).FirstOrDefault();
            return View(college);
        }
		[HttpGet]
		public IActionResult AddCollege()
		{
			return View();
		}
		[HttpPost]
        public IActionResult AddCollege(Collegemodel college)
        {
           String dataToSave=college.CollegeName+","+college.University+","+college.Address;
			StreamWriter sw=new StreamWriter("wwwroot/college.txt",true);
			sw.WriteLine(dataToSave);
			
			sw.Close();
			return RedirectToAction("college");
        }
    }
}
