using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MargeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // {    2023. 07. 03. Add user input / beta
            string userInput = string.Empty;
            Console.WriteLine(" This program covert Cm to Inch ");
            Console.WriteLine(" Input Cm Value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(10);
            // }    2023. 07. 03. Add user input / beta
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter* ONE_INCH; }
            private set {  Centimeter = (int) (value / ONE_INCH); }
        }

        public Ruler(int cmValue) { Centimeter=cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter} cm 는 {this.Inch} inch 입니다.");
        }
    }
}
