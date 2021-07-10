using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvokation
{
   
   public class Program
    {
       
        static double Calculate(int x, double y) { return x + y; }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        void Delete(string key) { Console.WriteLine(key); }
        public static void Function1() { }
        
        public static void Function2(string data) { }
        
        public  int Function3(int data) { return data; }
        public Boolean Function4(string x, string y) { return true; }
        
        static void FunctionsAsAnArguments(Func<int, double, double> calculateObj, Action<int> updateObj, Action<string> deleteObj, Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4)
            
        {

            //Invoke Delegate objects
            double calculationResult = calculateObj.Invoke(5, 5.2);
            obj2.Invoke("abc");
            obj3.Invoke(123);
            obj4.Invoke("ab","xy");
            updateObj.Invoke(1);
            deleteObj.Invoke("data");
            Console.WriteLine(calculationResult);
            



        }
        static void Main(string[] args)
        {
            Program _program = new Program();
            Action obj = new Action(Program.Function1);
            Action<string> obj2 = new Action<string>(Program.Function2);
            Func<int, int> obj3 = new Func<int, int>(_program.Function3);
            Func<string, string, bool> obj4 = new Func<string, string, bool>(_program.Function4);
            Func<int, double, double> calculateObj = new Func<int, double, double>(Program.Calculate);
            Action<int> updateObj = new Action<int>(_program.Update);
            Action<string> deleteObj = new Action<string>(_program.Delete);
            FunctionsAsAnArguments(calculateObj,updateObj,deleteObj,obj,obj2,obj3,obj4);






           



        }
    }
    
}
