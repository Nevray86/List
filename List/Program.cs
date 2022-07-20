using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace List
{
    public class piople
    {
        public string Name;
        public string Date;
        public bool In_Out;
        public string InOut; 
        public int Num ;
        public void new_pipl(string a, int c)
        {
          
            Name = a;
          
            if (c != 0)
            {

                In_Out = true;
                
            }
            else
            {
                In_Out = false;
               
            }
        }   
        public void print()
        {
            Console.WriteLine(Name);
            
            if (In_Out == true)
            {
                InOut = "Внутри";
                Console.WriteLine(InOut);
                
            }
            else
            {
                InOut = "Вышел";
                Console.WriteLine(InOut);
                
            }
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            piople Pipl = new piople();

           

            List<string> List = new List<string>();
           
            List<int> List3 = new List<int>();

            List.Add(Console.ReadLine());
          
            List3.Add(Convert.ToInt32(Console.ReadLine()));



           Pipl.new_pipl(List[0], List3[0]);
           Pipl.print();
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
            dirInfo.CreateSubdirectory(@"учет поситителей");

            

            File.AppendAllText(@"C:\учет поситителей\in_out.txt",Pipl.Name  + " "
                + Pipl.InOut + " " + DateTime.Now + "\n");


            
        }
        
    }
}
