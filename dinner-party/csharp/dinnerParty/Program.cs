using System;
using System.Collections.Generic;
using System.Linq;

namespace dinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<guest> Guests = getGuests();

               List<guest> Table1 = new List<guest>();
               List<guest> Table2= new List<guest>();

            foreach (guest OneGuest in Guests)
            {
              List<string> table1Occupations = new List<string>();
                foreach (guest person in Table1)
               {
                   table1Occupations.Add(person.Occupation);
               };
               if(table1Occupations.Contains(OneGuest.Occupation)){
                   Table2.Add(OneGuest);
               }
               else{
                   Table1.Add(OneGuest);
               }
           };
            Console.WriteLine("Table One");
           foreach (guest oneGuest in Table1)
           {
               Console.WriteLine($"{oneGuest.Name} (${oneGuest.Occupation}) ${oneGuest.Bio}");
           };
                Console.WriteLine();
               Console.WriteLine("Table Two");

            foreach (guest oneGuest in Table2)
           {
               Console.WriteLine($"{oneGuest.Name} (${oneGuest.Occupation}) ${oneGuest.Bio}");
           };

        }

        public static List<guest> getGuests(){

            List<guest> Guests = new List<guest> {
            new guest {
        Name= "Marilyn Monroe",
        Occupation= "entertainer",
        Bio= "(1926 - 1962) American actress, singer, model"
        },
        new guest {
        Name= "Abraham Lincoln",
        Occupation= "politician",
        Bio= "(1809 - 1865) US President during American civil war"
        },
        new guest {
        Name= "Martin Luther King",
        Occupation= "activist",
        Bio= "(1929 - 1968)  American civil rights campaigner"
        },
        new guest {
        Name= "Rosa Parks",
        Occupation= "activist",
        Bio= "(1913 - 2005)  American civil rights activist"
        },
        new guest {
        Name= "Peter Sellers",
        Occupation= "entertainer",
        Bio= "(1925 - 1980) British actor and comedian"
        },
        new guest {
        Name= "Alan Turing",
        Occupation= "computer scientist",
        Bio= "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new guest {
        Name= "Admiral Grace Hopper (1906–1992) – developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
        Occupation= "computer scientist",
        Bio= "(1906–1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new guest {
        Name= "Indira Gandhi",
        Occupation= "politician",
        Bio= "(1917 - 1984) Prime Minister of India 1966 - 1977",

            }
        };
        return Guests;
        }
      

    }
      public class guest
        {
        public string Name {get; set;}
        public string Occupation { get; set; }
        public string Bio { get; set; }
        }
        public class table
        {
            public string Name {get; set;}
            public List <guest> Seating { get; set; }
        }
}
