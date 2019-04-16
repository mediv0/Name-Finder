using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static bool CheckName(string name)
        {
            string key = "seyyed";
            int keyLength = key.Length;
            int nameLength = name.Length;
            string convertedName;
            char[] namechar2 = new char[6];

            if (keyLength < nameLength)
            {
                // convert name to char array 
                char[] nameChar = name.ToCharArray();

                for (int i = 0; i < keyLength; i++)
                {
                    namechar2[i] = nameChar[i]; 

                    if(i == 5)
                    {
                        convertedName = new string(namechar2);
                        if (convertedName == key)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                        
                }
            }
            else
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string[] names = { "mahdi", "ali", "reza", "seyyed ali" };
            bool flag = false;
            int Numberflag = 0;


            // 1. length of key
            // 2. length of current name in array

            for(int i = 0; i < names.Length;i++)
            {
                flag = CheckName(names[i]);
                Numberflag = i;
            }
            if(flag == true)
            {
                Console.WriteLine("names{0} ( '{1}' ) start with seyyed", Numberflag + 1,names[Numberflag]);
            }
            Console.ReadKey();
        }
    }
}
