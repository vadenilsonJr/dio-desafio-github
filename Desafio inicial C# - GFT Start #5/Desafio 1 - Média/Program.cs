using System;

class program {

  static void Main(string[] args) {
         
         
            double A, B, C;
            double soma;
            double media;
            
            A = double.Parse(Console.ReadLine());
            A = A * 2;
            B = double.Parse(Console.ReadLine());
            B = B * 3;
            C = double.Parse(Console.ReadLine());
            C = C * 5;
            
            soma = A+B+C;
            media = soma / 10;
            Console.WriteLine("MEDIA = " + media.ToString("F1"));

        }
}
