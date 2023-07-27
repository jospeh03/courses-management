namespace IUST;
#nullable disable
public class Class1
{
    public static void Greeting()
    {
        Console.WriteLine("Hello");
    }
     List<Student>yos  = new List<Student>()
        {
            new Student{Id = 1, Name ="Maher",Facu=Faculty.FacultyOfEngnieeringAndTechnology,IsTeacher=true},
            new Student{Id = 2, Name ="Yousef",Facu=Faculty.FacultyOfDesign,IsTeacher=true},
            new Student{Id = 3, Name ="Wissam",Facu=Faculty.FacultyOfBussnies,IsTeacher=true},            
            new Student{Id = 4, Name ="Abd",Facu=Faculty.FacultyOfDentisty,IsTeacher=false},
            new Student{Id = 5, Name ="Bilal",Facu=Faculty.FacultyOfDentisty,IsTeacher=false},
            new Student{Id = 6, Name ="Samer",Facu=Faculty.FacultyOfParchmisity,IsTeacher=false}
        };
    
}
    
public class Student
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public Faculty Facu{get; set; }
    public Department Dept { get;set; }
    public bool IsTeacher { get; set; }

    public void SetInfo()
    {
        Console.WriteLine($"id = {Id}");
        Console.WriteLine($"Faculty = {Facu}");

        Console.WriteLine($"Name = {Name}");
        Console.WriteLine($"Dept = {Dept}");
        Console.WriteLine($"Is Teacher = {IsTeacher}");
    }
}
public static class Filter
{
        
    public static List<T> Filtering<T>(this List<T> records,Func<T,bool>  Condition)
    {
        List<T> arr = new List<T>();
        if (typeof(T) == typeof(int))
        {
            for (int i = 0; i < records.Count; i++)
            {
                records[i] = (T)(object)(int.Parse(records[i].ToString()) + 1);
                Console.WriteLine(records[i]);
                arr.Add(records[i]);
            }
        }
        if (typeof(T) == typeof(string))
        {
            foreach (T record in records)
            {
                Console.WriteLine($"Hello {record}");
                arr.Add(record);
            }
        }
        if (typeof(T) == typeof(Student))
        {
            
            foreach (T record in records)
            {
                if (Condition(record))
                {
                    arr.Add(record);
                }
            }                
        }
        return arr;

    }
    public static void Print<T>(this List<T> records)
    {
        if (typeof(T) == typeof(Student))
        {
            foreach( T record in records)
            {
                ((Student)(object)record).SetInfo();
                Console.WriteLine();
            }
        }
        else
        {
            foreach (T record in records)
            {
                Console.WriteLine(record);
            }
        }
    }
}
