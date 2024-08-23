using Demo.Classes;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDBContext context = new ITIDBContext();

            //FullTime fullTime = new FullTime()
            //{
            //    Name = "omar",
            //    Address= "giza",
            //    Age=27,
            //    Salary = 1000,
            //    StartDate = DateTime.Now,
            //};

            //Parttime parttime = new Parttime()
            //{
            //    Name = "magdy",
            //    Address="cairo",
            //    Age=25,
            //    HourRate=250,
            //    CountOfHours=10,
            //};
            //context.Add(parttime);
            //context.Add(fullTime);
            ////context.SaveChanges();

            //foreach (var item in context.Employees.OfType<FullTime>())
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //foreach (var item in context.Employees.OfType<Parttime>())
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //var emp = ( from e in context.Employees
            //          where e.Id==1
            //          select e).FirstOrDefault();
            //Console.WriteLine(emp.Name);

            //Department department = new Department()
            //{
            //    Name="Hr",
            //}; 
            //Department department1 = new Department()
            //{
            //    Name = "Salles",
            //};
            //context.Add(department1 );
            //context.Add(department);
            //context.SaveChanges();

            var emp =(from e in context.Employees
                     where e.Id ==1
                     select e).FirstOrDefault();

            //foreach (var item in emp)
            //{
                Console.WriteLine($"Name = {emp.Name} Department = {emp.Department.Name}");
            //}
        }
    }
}
