using System;

namespace Lecture1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Program program = new Program();
            Console.WriteLine(program.IsLeapYear(12));
            Console.WriteLine(program.IsLeapYear(1600));
            Console.WriteLine(program.IsLeapYear(1700));
        }

        public bool LeapYear2(int year){
            if(year%4 == 0){
                return true;
            } else{
                return false;
            }
        }

        public bool LeapYear3(int year){
            if(year%100 == 0){
                    if(year%400 ==0){  
                            return true;
                        } else {
                           
                            return false;
                        }
                }
                return true;
        }
        public bool IsLeapYear(int year){
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
