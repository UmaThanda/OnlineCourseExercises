using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {


           

            Human myStudent = new Student("Mark", "Beilfuss");

            //List<Worker> workers = new List<Worker>();
            List<Human> workers = new List<Human>();

            //Worker worker1 = new Worker("Andy", "Gates");
            Worker worker2 = new Worker("Mathew", "Yoder");
            Human worker3 = new Worker("Christopher", "Smith");
            Human worker4 = new Worker("Matthew", "Johnson");
            Human worker5 = new Worker("Jonathan", "Jones");
            Human worker6 = new Worker("Julie", "Smith");
            Human worker7 = new Worker("Victoria", "Daugherty");
            Human worker8 = new Worker("Elizabeth", "Whittum");
            Human worker9 = new Worker("Mantra", "Blake");
            Human worker10 = new Worker("Henry", "Smith");

           
          //  Console.WriteLine(worker1.FirstName + worker2.LastName);
            //why is the cw above not printing any name?

            workers.Add(new Worker("Andy", "Gates"));
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            workers.Add(worker5);
            workers.Add(worker6);
            workers.Add(worker7);
            workers.Add(worker8);
            workers.Add(worker9);
            workers.Add(worker10);

            

            int worker1Salary = ((Worker)workers[0]).CalculateHourlyWage(10, 100);
            // create an array and sort it
            //workers.sort();
            int worker2Salary = worker2.CalculateHourlyWage(11, 100);
            int worker1AndWorker2Comparison = worker1Salary.CompareTo(worker2Salary);
            Console.WriteLine(worker1.FirstName + " is lesser than "  + worker2.FirstName + " worker1AndWorker2Comparison");



            /*
             * should the worker be Human type? If no why and if yes why
             * how do i compare the salary if the worker is of human type - how do i call the method?
             * how do i sort all the workers salary?
             * is there a better way to code this instead of listing each and every worker?
             * why is the console printing human.worker instead of name though worker is initialized with name?"
             * 
             * */
            ArrayList salary = new ArrayList();
            salary.Add(worker1Salary);
            salary.Add(worker2Salary);
           
            // ?? salary.Sort(salary);

            Console.WriteLine();




        }
    }
}
