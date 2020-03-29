using System;

namespace project7
{
    class Program
    {
        static void Main(string[] args)
        {
           ///////////////////////////////N-1.1;
         Console.WriteLine("                  Задания Первое: Пункт 1");
         /////////////////////////////////
         int A,B;
         Console.WriteLine("Введите одну Целое число");
         A=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите одну Целое число которое сторого больше первого числа");
         B=Convert.ToInt32(Console.ReadLine());
         int Suma=0;
         for(int i=A+1;i<B;i++)
         {
            Suma=Suma+i;
         }
         Console.WriteLine($"Сумма от A до B не включительно равно {Suma}");
         Console.WriteLine("Для Запуска следуюших Программ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ ");
         Console.ReadKey();  
         ///////////////////////////////////N-1.2
         
         Console.WriteLine("                  Первое  задания Пункт: 2");

         ////////////////////////////////////
         int A1,B1,k;
         Console.WriteLine("Введите одну Целое число");
         A1=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите одну Целое число которое сторого больше первого числа");
         B1=Convert.ToInt32(Console.ReadLine());
         Console.Write("\n");
         Console.WriteLine("На этом списке все нечетные числа От A до B не влючительно");
          for( k=A1+1;k<B1;k++)
          {
              if(k%2!=0)
              {
                Console.Write(k+" ");
              }
          }
          Console.Write("\n");
          Console.WriteLine(" Для Запуска следуюших Программ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ ");
          Console.ReadKey();
          Console.Write("\n");
         ////////////////////////////////////
         Console.WriteLine("                  Задания Второе");
            Console.WriteLine("Четырехугольник");
            /////////////////////////////////////////////////N-2
            
            String S="";
            String f="*",S1="";
            for(int i=1;i<=25;i++)
            {
              S1=S1+"*"+" ";
            }
            Console.Write(S1);
            for(int i=1;i<=47;i++)
            { 
              S = S + " ";
            }
            
            for(int i=1;i<=10;i++)
            {
            Console.Write("\n");
            Console.Write(f+S+f);
            }
            Console.Write("\n");
            Console.Write(S1);
            
            Console.Write("\n");
            /////////////////////////////////////
             
            Console.WriteLine("Прямоугольный треугольник");

            ////////////////////////////////////////
            String S2="",S3="",S4="              ";
            {
              Console.Write(S4+"*");
                 
             for(int i=1;i<=15;i++)
             {
                Console.Write("\n");
                Console.Write(S4+"*");
                 
                S2 = S2 + " ";
                Console.Write(S2+"*");
             }  
              Console.Write("\n");
             for(int i=1; i<=10; i++)
             {
               S3=S3+"*"+" ";
             }
             Console.Write(S4+S3);
             
            }
            //////////////////////////////
            Console.Write("\n");
            Console.WriteLine("Равносторонный Треугольник");
            /////////////////////////////////
            String S5="          ",S6="";
            int n=20;
            
            Console.Write("                                 " + "*");
            Console.Write("\n");
            for(int i=1; i<=10;i++)
            {
              for(int j=1;j<=n;j++)
              {
                S5=S5+" ";
              }
                S6=S6+"  ";
                //n=n-2;
                Console.Write(S5+"*"+S6+" "+S6+"*");
                Console.Write("\n");
                n=n-2;
                S5="          ";
                
                
            }
            
            for(int i=1; i<=16;i++)
            {
             S5=S5+"*"+"  ";
            }
             Console.Write(S5);
        //////////////////////////////////////////////
        /// 
        /// 
        /// 
        /// 
        Console.Write("\n");

        Console.Write("РОМБ");

        Console.Write("\n");
        Console.Write("\n");
        String S51="          ",S61="";
            int n1=20;
            
            Console.Write("                                 " + "*");
            Console.Write("\n");
            for(int i=1; i<=10;i++)
            {
              for(int j=1;j<=n1;j++)
              {
                S51=S51+" ";
              }
                S61=S61+"  ";
                //n=n-2;
                Console.Write(S51+"*"+S61+" "+S61+"*");
                Console.Write("\n");
                n1=n1-2;
                S51="          ";
                
                
            }
            ///////////////////////////////////////
            String S52=" ",S62="          ";
            int n2=20;
            
            Console.Write("          " + "*"+"                                             "+"*");
            Console.Write("\n");
            for(int i=1; i<=10;i++)
            {
              for(int j=2;j<=n2;j++)
              {
                S52=S52+" ";
              }
              n2=n2-2;
              S62=S62+"  ";
              //Console.Write("\n");
              Console.Write(S62+"*"+S52+" "+S52+"*");
              Console.Write("\n");
              S52=" ";
                
            }
            Console.Write("                                 "+"*");
            Console.Write("\n");
            Console.WriteLine("Для Запуска следуюших Программ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ ");
            Console.ReadKey();
            
        ////////////////////////////////////////////////////////
        Console.WriteLine("Задания 3");
        //////////////////
        double Summ=1000,SM;
        int t=0;
        double Procent;
        Console.WriteLine("Введите на сколько процент увеличивается от имеющихся  ваша сумма каждый месяц");
        Procent=Double.Parse(Console.ReadLine());
        while(Summ<=1100)
        {
            SM=Summ+Summ*(Procent)/100;
            Summ=SM;
            t++;
           // Console.WriteLine(Summ);
        }
        Console.WriteLine($"через {t} месяца Перевесит 1100 руб");
        

      
        
       

    
           
       
       
     
            
        }
    }
}
  