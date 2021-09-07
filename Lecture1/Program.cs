using System;

namespace Lecture1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
            int input = program.readInput();
            if (program.IsLeapYear(input) == true){
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("ney");
            }
        }
        public int readInput(){
            try{
                return int.Parse(Console.ReadLine());
            } catch{
                throw new Exception("Input is not an integer");
            }
        }

        public bool IsLeapYear(int year){
            if(year<1582){
                throw new Exception();  //Only check Leap years from 1583 and above. 
            }
            if(year%4 == 0){
                if(year%100 == 0){
                    if(year%400 ==0){  
                            return true;
                        } else {
                           
                            return false;
                        }
                }
                return true;
            }
            return false;
        }
    }
}
