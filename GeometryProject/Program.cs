using System;

namespace GeometryProject {
    class Program {
        static void Main(string[] args) {
            
            var quad1 = new Quadrillateral(1, 2, 3, 4);
            quad1.Perimeter();

            var rect1 = new Rectangle(2, 4);
            rect1.Perimeter();
            rect1.Area();

            var square1 = new Square(2);
            square1.Perimeter();
            square1.Area();


        }
    }
}
