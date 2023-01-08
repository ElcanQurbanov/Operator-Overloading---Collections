

using Collection_practices.Models;
using System.Collections;

#region Operator Overloading

//Employee employe1 = new Employee();

//employe1.Name = "Pervin";
//employe1.Age = 25;
//employe1.Id = 1;


//Employee employe2 = new Employee();

//employe2.Name = "Cavid";
//employe2.Age = 22;
//employe2.Id = 2;

//var result = employe1 > employe2;

//Console.WriteLine(result);

#endregion


//Hashtable datas = new Hashtable();

//datas.Add(1, "Cavid");

//datas.Add(2, "Pervin");

//datas.Add(3, "Mirze");

//foreach (DictionaryEntry item in datas)
//{
//	//Console.WriteLine(item.Key + "-" + item.Value);
//	if ((int)item.Key == 1)
//	{
//		Console.WriteLine(item.Value);
//	}
//}


//SortedList datas = new SortedList();


//datas.Add(1, "Cavid");

//datas.Add(6, "Pervin");

//datas.Add(3, "Mirze");

//foreach (DictionaryEntry item in datas)
//{
//	Console.WriteLine(item.Key + " " + item.Value);	
//}



//ArrayList datas = new ArrayList();

//datas.Add("Salam");

//datas.Add(1);

//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}



//List<int> datas = new List<int>();

//datas.Add(10);

//datas.Add(40);

//datas.Add(30);

//datas.Add(20);

//datas.Sort();
//datas.Reverse();

//Console.WriteLine(datas[0]);

//datas.Remove(40);

//datas.RemoveAt(0);

//datas.Clear();

//datas.RemoveAll(m => m > 20);

//var res = datas.Contains(20);

//Console.WriteLine(res);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


List<string> names = new List<string>() { "Cavid", "Cavid", "Mirze", "Aqshin", "Elcan" };

//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//	if (item == "Cavid")
//	{
//		Console.WriteLine(item);
//	}
//}


//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}



//var result = names.Find(m => m == "Cavid");
//Console.WriteLine(result);


//var result = names.FindAll(m => m == "Cavid").Count();

//Console.WriteLine(result);


//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//List<int> numbers = new List<int>() { 1,2,3,4, };

//Console.WriteLine(numbers.Sum(m=>m));

//List<int> numbers = new List<int>() { 1, 2, 3, 4, };

//var sum = numbers.FindAll(m=>m%2==0).Sum(m => m);

//var res = numbers.FindAll(m => m % 2 == 0);


//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//List<int> numbers = new List<int>() { 1, 2, 3, 4, };

//var sum = numbers.FindAll(m => m % 2 == 0).Sum(m => m);

//Console.WriteLine(sum);

//var res = numbers.FindAll(m => m % 2 == 0);

//int sum1 = 0;

//foreach (var item in res)
//{
//    sum1 += item;
//}

//Console.WriteLine(sum1);




//List<Student> students1 = new();


//students.AddRange(students1);

//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}


//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ferid Abdullayev",
//    Age = 17,
//    Address = "Nesimi"
//};

//AddStudent(stu2);


//Console.WriteLine("Add full name");

//string fullname = Console.ReadLine();

//Console.WriteLine("Add address");

//string address = Console.ReadLine();

//Console.WriteLine("Add age");

//int age = Convert.ToInt32(Console.ReadLine());


//Student student = new Student()
//{
//    Id = 1,
//    FullName = fullname,
//    Address = address,
//    Age = age
//};

//AddStudent(student);



//static void AddStudent(Student student)
//{
//    List<Student> students = new();
//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName + "-" + item.Address);
//    }
//}

//Console.WriteLine(GetStudentsCount());


//static int GetStudentsCount()
//{
//    var students = GetAllStudents();
//    return students.Count;
//}

//Console.WriteLine(GetSameNameCount());

//static int GetSameNameCount()
//{
//    string text = "Konul";

//    var result = GetAllStudents();

//    return result.FindAll(m=>m.FullName.Contains(text)).Count();
//}


//static List<Student> GetAllStudents()
//{

//    List<Student> students = new();

//    Student stu1 = new Student
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 26,
//        Address = "Sumqayit"
//    };

//    Student stu2 = new Student
//    {
//        Id = 2,
//        FullName = "Ferid Abdullayev",
//        Age = 17,
//        Address = "Nesimi"
//    };

//    Student stu3 = new Student
//    {
//        Id = 3,
//        FullName = "Shaiq Kazimov",
//        Age = 25,
//        Address = "Sedmoy"
//    };

//    Student stu4 = new Student
//    {
//        Id = 4,
//        FullName = "Elcan Qurbanov",
//        Age = 19,
//        Address = "Ehmedli"
//    };

//    Student stu5 = new Student
//    {
//        Id = 5,
//        FullName = "Konul Ibrahimova",
//        Age = 26,
//        Address = "Neftciler"
//    };

//    Student stu6 = new Student
//    {
//        Id = 6,
//        FullName = "Konul Eliyeva",
//        Age = 26,
//        Address = "Neftciler"
//    };

//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    students.Add(stu5);
//    students.Add(stu6);

//    return students;
//}




//SortedList<int,string> datas = new SortedList<int,string>();

//datas.Add(2, "Cavid");

//datas.Add(1, "Pervin");

//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}


//HashSet<int> datas = new HashSet<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(1);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//} 



//Stack<string> stack = new Stack<string>();

//stack.Push("Salam");

//stack.Push("Sagol");

//stack.Push("XXX");  

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<string> queue = new Queue<string>();

//queue.Enqueue("SAlam");

//queue.Enqueue("Sagol");

//queue.Enqueue("XXX");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



//Dictionary<string, string> datas = new Dictionary<string, string>();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Hacker");
//datas.Add("SuperAdmin", "Anar");

//foreach (KeyValuePair<string,string> item in datas)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}

Dictionary<string, string> datas = new Dictionary<string, string>();

datas.Add("Admin", "Mirze");
datas.Add("Member", "Hacker");
datas.Add("SuperAdmin", "Anar");

foreach (KeyValuePair<string, string> item in datas)
{
	if (item.Key == "Admin")
	{
		Console.WriteLine(item.Value);
	}
}

