using System;
namespace OOPS_Practice.ClassFiles
{
	public class Student
	{
		public string name { get; set; }
		public int age { get; set; }
		public string section { get; set; }
		public string emailID { get; set; }
		public static int  Count { get; set; }

		public Student()
		{
			Count++;
		}

		public Student(string Name)
		{
			Count++;
			this.name = Name;
		}


    }
}

