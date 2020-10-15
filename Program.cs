using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
           double Delta, x1, x2,a,b,c ;
           string sair;
          do
          {  
            Console.Clear();
            Console.WriteLine("  +--------------------+");
            Console.WriteLine("  |                    |");
            Console.WriteLine("  +--------------------+");
            print("Equação de 2º Grau",14,0,4,1);
            print("",0,0,0,4);

            Console.Write("entre com a : ");
            a = Convert.ToDouble(Console.ReadLine());
             Console.Write("entre com b : ");
            b = Convert.ToDouble(Console.ReadLine());
             Console.Write("entre com c : ");
            c = Convert.ToDouble(Console.ReadLine());

             if (a==0) {print("não é Uma equação de 2º grau",0,14,0,7);} 
             else 
                { Delta = ((b*b)-4*(a*c));   
                   if (Delta< 0)  
                   { print($"como delta é {Delta:N}, a equação não possui raízes reais!",0,14,0,7); }
                
                 else
                  {
                       x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                       x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                       print($"x' = {x1:N}  e  x'' = {x2:N}",0,14,0,7);
                  } 
                }
                print("",0,0,0,9);
                Console.Write("\n(S)air? ");
                sair=Console.ReadLine().ToUpper();
               }
               while (sair!="S");
        }// fecha Main
        static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
          {
           ConsoleColor CorC = (ConsoleColor)COR_Caracter;
           ConsoleColor CorF = (ConsoleColor)COR_Fundo;
           Console.ForegroundColor = CorC;
           Console.BackgroundColor = CorF;
            Console.SetCursorPosition(X, Y);
            Console.Write(S);
            Console.ResetColor();
          }//fecha print
    } 
}
