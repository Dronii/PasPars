using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Collections.ObjectModel;
using System.Threading;

namespace pp_v._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { };
            char[] pass = new char[] { };
            Console.WriteLine("Выбери вариант \n1.Ввод по элементам \n2.Ввод по символам \n3 Выход");
            string selection = Console.ReadLine();
            switch(selection)
            {
                case "1":
                    InputSTR(arr);
                    Console.Read();
                    break;

                case "2":
                    InputCHA(pass);
                    Console.Read();
                    break;

                case "3":
                    break;                 
            }   
        }
        public static void InputSTR(string[] vs) //Метод для ввода поэлементно
        {
            Console.WriteLine("Сколько элементов будет в пароле? \n Введите число от 2 до 6");//Можно увеличивать case соответственно кол-во элементов 
            string selection = Console.ReadLine();
            switch(selection)
            {
                case "2":
                    Console.WriteLine("Введите 2 элементa пароля");
                    Console.WriteLine();
                    string[] arr = new string[2] ;
                    Console.WriteLine("Введите 1 элемент");
                    arr [0] = Console.ReadLine();
                    Console.WriteLine("Введите 2 элемент");
                    arr [1] = Console.ReadLine();
                    Console.WriteLine();
                    ShowAllCmbinations(arr);
                    break;
                case "3":
                    Console.WriteLine("Введите 3 элементa пароля");
                    Console.WriteLine();
                    string[] arr1 = new string[3];
                    Console.WriteLine("Введите 1 элемент");
                    arr1[0] =   Console.ReadLine() ;
                    Console.WriteLine("Введите 2 элемент");
                    arr1[1] =   Console.ReadLine() ;
                    Console.WriteLine("Введите 3 элемент");
                    arr1[2] =   Console.ReadLine() ;
                    Console.WriteLine();
                    ShowAllCmbinations(arr1);
                    break;
                case "4":
                    Console.WriteLine("Введите 4 элементa пароля");
                    Console.WriteLine();
                    string[] arr2 = new string[4];
                    Console.WriteLine("Введите 1 элемент");
                    arr2[0] = Console.ReadLine();
                    Console.WriteLine("Введите 2 элемент");
                    arr2[1] = Console.ReadLine();
                    Console.WriteLine("Введите 3 элемент");
                    arr2[2] = Console.ReadLine();
                    Console.WriteLine("Введите 4 элемент");
                    arr2[3] = Console.ReadLine();
                    Console.WriteLine();
                    ShowAllCmbinations(arr2);
                    break;
                case "5":
                    Console.WriteLine("Введите 5 элементов пароля");
                    Console.WriteLine();
                    string[] arr3 = new string[5];
                    Console.WriteLine("Введите 1 элемент");
                    arr3[0] = Console.ReadLine();
                    Console.WriteLine("Введите 2 элемент");
                    arr3[1] = Console.ReadLine();
                    Console.WriteLine("Введите 3 элемент");
                    arr3[2] = Console.ReadLine();
                    Console.WriteLine("Введите 4 элемент");
                    arr3[3] = Console.ReadLine();
                    Console.WriteLine("Введите 5 элемент");
                    arr3[4] = Console.ReadLine();
                    Console.WriteLine();
                    ShowAllCmbinations(arr3);
                    break;
                case "6":
                    Console.WriteLine("Введите 6 элементов пароля");
                    Console.WriteLine();
                    string[] arr4 = new string[6];
                    Console.WriteLine("Введите 1 элемент");
                    arr4[0] = Console.ReadLine();
                    Console.WriteLine("Введите 2 элемент");
                    arr4[1] = Console.ReadLine();
                    Console.WriteLine("Введите 3 элемент");
                    arr4[2] = Console.ReadLine();
                    Console.WriteLine("Введите 4 элемент");
                    arr4[3] = Console.ReadLine();
                    Console.WriteLine("Введите 5 элемент");
                    arr4[4] = Console.ReadLine();
                    Console.WriteLine("Введите 6 элемент");
                    arr4[5] = Console.ReadLine();
                    Console.WriteLine();
                    ShowAllCmbinations(arr4);
                    break;
            }
        }
        public static void InputCHA(char[] vs)        //метод для ввода посимвольно
        {
            
            Console.WriteLine("Введите символы пароля");
           
            Console.WriteLine();
            string pas = Console.ReadLine();
            char[] pass = pas.ToCharArray();
            ShowAllCmbinations(pass);
            Console.Read();
        }

        public static void ShowAllCmbinations<T>(IList<T> arr, string current = "")   //Метод генерирующий варианты
        {
            if (arr.Count == 0)
            {
                Console.WriteLine(current);
                return;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                List<T> lst = new List<T>(arr);
                lst.RemoveAt(i);
                ShowAllCmbinations(lst, current + arr[i].ToString());
            }
        }
    }
}
