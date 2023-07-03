using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MargeTest
{
<<<<<<< HEAD
    // {    2023. 07. 03.   Modified class position / alpha
=======
    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

>>>>>>> a7f4fea7ce62cc1ae5890eebad6dee4568bf11a1
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
    // }    2023. 07. 03.   Modified class position / alpha

    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

}
