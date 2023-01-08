


using Author;
using System.Collections.Generic;

Authors author = new();
List<Authors> authors = new List<Authors>();



List<Authors> GetAll()
{
    List<Authors> authors = new List<Authors>();

    Authors author1 = new Authors()
    {   

        Name = "Aqshin",
        Surname = "Hummetov",
        Age = 27

    };

    Authors author2 = new Authors()
    {
        Name = "Shaiq",
        Surname = "Kazimov",
        Age = 45
    };

    Authors author3 = new Authors()
    {
        Name = "Cahandar",
        Surname = "Velibeyli",
        Age = 46
    };

    Authors author4 = new Authors()
    {
        Name = "Cavid",
        Surname = "Ismayilzade",
        Age = 22
    };

    Authors author5 = new Authors()
    {
        Name = "Elcan",
        Surname = "Qurbanov",
        Age = 19
    };



    authors.Add(author1);
    authors.Add(author2);
    authors.Add(author3);
    authors.Add(author4);
    authors.Add(author5);



    return authors;

}


List<Authors> GetCheckAuthorsAge()
{
    var authors = GetAll().FindAll(m => m.Age > 40);


    foreach (var item in authors)
    {
        Console.WriteLine(item.Name + " " + item.Surname);
    }

    return authors;
}

GetCheckAuthorsAge();






