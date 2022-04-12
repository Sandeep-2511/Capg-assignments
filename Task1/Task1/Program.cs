using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1
{
    class Program
    {
        class student
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string smailid { get; set; }
            public string branch { get; set; }
            public double per { get; set; }
        }

        static void Main(string[] args)
        {
            List<student> slist = new List<student>()
            {
                new student(){firstname ="sammy", lastname="vishwa", branch= "comp", smailid = "sammy@gmail.com", per = 84 },
                new student(){firstname ="sandy", lastname="Potdhuke", branch= "comp", smailid = "sandy@gmail.com", per = 89},
                new student(){firstname ="paddy", lastname="mahur", branch= "elec", smailid = "paddy@gmail.com", per = 77},
                new student(){firstname ="shree", lastname="gillo", branch= "comp", smailid = "shree@gmail.com", per = 98},
                new student(){firstname ="anany", lastname="dubey", branch= "mech", smailid = "anany@gmail.com", per = 78},
                new student(){firstname ="zahra", lastname="darbar", branch= "civil", smailid = "zahra@gmail.com", per = 99},
                new student(){firstname ="yash", lastname="girhe", branch= "comp", smailid = "yash@gmail.com", per = 81},
                new student(){firstname ="jabba", lastname="abba", branch= "mech", smailid = "jabba@gmail.com", per = 95}

            };
            var query = from i in slist select i;
            //var query = Slist.Select(i => i);
            foreach (var i in query)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

 
            //2.Where
            Console.WriteLine("------------------where query------------------");
            //var query1 = from i in slist where i.firstname == "sandy" select i;
            var query1 = slist.Where(i => i.firstname == "sandy").Select(i => i);
            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }
            //3.Take
            Console.WriteLine("------------------Take query------------------");
            //var query2 = slist.Take(5);
            var query2 = (from i in slist select i).Take(5);
            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            //$.TakeWhile
            Console.WriteLine("------------------TakeWhile query------------------");
            var query3 = slist.TakeWhile(i => i.firstname == "Sammy");
            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            //5. Skip
            Console.WriteLine("------------------Skip query------------------");
            //var query4 = (from i in slist select i).Skip(6);
            var query4 = slist.Skip(6);
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }


            //6. SkipWhile
            Console.WriteLine("------------------Skipwhile query------------------");
            var query5 = slist.SkipWhile(i => i.branch == "comp");
            foreach (var i in query5)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            //OrderBy
            Console.WriteLine("------------------OrderBy ASC------------------");
            var query6 = from i in slist where i.per < 80 orderby i.per ascending select i;
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("------------------OrderBy DESC------------------");
            var query7 = from i in slist where i.per < 80 orderby i.per descending select i;
            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("------------------GroupBY------------------");
            var query8 = slist.GroupBy(i => i.branch);
            foreach (var i in query8)
            {
                Console.WriteLine(i.Key);
            }

            Console.WriteLine("------------------SELECTMANY------------------");
            //var query = from i in slist select i;
            List<List<int>> array = new List<List<int>>();
            List<int> array1 = new List<int> { 10, 20, 30 };
            array.Add(array1);
            var query9 = array.SelectMany(i => i);
            foreach (var i in query9)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------Aggregrate Functions------------------");
            double sum = (from i in slist select i.per).Sum();
            Console.WriteLine("Total sum of percentage is:" + sum);

            double max = (from i in slist select i.per).Max();
            Console.WriteLine("Maximum percentage is:" + max);

            double min = (from i in slist select i.per).Min();
            Console.WriteLine("Minimum percentage is:" + min);

            double avg = (from i in slist select i.per).Average();
            Console.WriteLine("Total average of percentage is:" + avg);

            var query10 = (from i in slist select i).Count();
            Console.WriteLine("Count of students is: " + query10);

            var query11 = (from i in slist select i.branch).Distinct();
            foreach (string i in query11)
            {
                Console.WriteLine("Branch: " + i);
            }

            Console.WriteLine("----------LET-----------");

            List<int> arr = new List<int>() { 50, 60, 70 };
            var query12 = from i in arr let res = i + 10 where res > 60 select res;
            foreach (int i in query12)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------Into-------------");
            var query13 = from i in slist where i.branch == "comp" select i into res where res.firstname.Contains("dy") select res;
            foreach (var i in query13)
            {
                Console.WriteLine(i.firstname + "," + i.branch);
            }

            Console.WriteLine("----------------OFF-Type-------------");

            object[] arr1 = new object[] { 4, "X", 3, "Y", 2, "Z", 1, "ABC" };
            var query14 = (from i in arr1 select i).OfType<string>();
            foreach (var i in query14)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------First and FirstOrDefault---------");

            var query15 = (from i in slist where i.branch == "comp" select i.per).First();
            var query16 = (from i in slist where i.branch == "x" select i.per).FirstOrDefault();
            Console.WriteLine(query15);
            Console.WriteLine(query16);

            Console.WriteLine("------------Last and LastOrDefault------------");

            var query17 = (from i in slist where i.branch == "comp" select i.per).Last();
            var query18 = (from i in slist where i.branch == "comp" select i.per).LastOrDefault();
            Console.WriteLine(query17);
            Console.WriteLine(query18);

            Console.WriteLine("------------Single and SingleOrDefault------------");
            var query19 = (from i in slist where i.per == 84 select i).Single();
            var query20 = (from i in slist where i.per == 100 select i).SingleOrDefault();
            Console.WriteLine(query19.firstname);
            Console.WriteLine(query20);

            Console.WriteLine("------------Elementat and ElementatOrDefault------------");
            var query21 = (from i in slist select i).ElementAt(1);
            var query22 = (from i in slist select i).ElementAtOrDefault(15);
            Console.WriteLine(query21.firstname);
            Console.WriteLine(query22);

            Console.WriteLine("------------Immediate action------------");
            var query23 = (from i in slist select i).Count();

            var query24 = (from i in slist select i);

            slist.Add(new student() { firstname = "deepu", lastname = "Potu", branch = "comp", smailid = "sandu@gmail.com", per = 88 });
            slist.Add(new student() { firstname = "sandeep", lastname = "Pote", branch = "mech", smailid = "sandeep@gmail.com", per = 87 });

            Console.WriteLine(query23);

            Console.WriteLine("------------Differed action------------");
            foreach (var i in query24)
            {
                Console.WriteLine(i.firstname + " " + i.per);
            }

            Console.WriteLine("------------Startswith------------");
            var query25 = (from i in slist where i.firstname.StartsWith('s') select i);
            foreach (var i in query25)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("------------Endsswith------------");
            var query26 = (from i in slist where i.firstname.EndsWith('y') select i);
            foreach (var i in query26)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("------------Contains------------");
            var query27 = (from i in slist where i.lastname.Contains('d') select i);
            foreach (var i in query27)
            {
                Console.WriteLine(i.lastname);
            }
            Console.WriteLine("--------------IQureyable--------------");

            IQueryable<student> query28 = (from i in slist select i).AsQueryable();

            foreach (var i in query28)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("-------------------IEnumarable-------------------");

            IEnumerable<string> query29 = slist.Select(i => i.firstname);
            foreach (var i in query29)
            {
                Console.WriteLine(i);
            }

        }
    }
}
