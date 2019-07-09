using Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
 
namespace Example
{
    class Program
    {
        //Вывести на экран все положительные числа, отсортировав их в порядке возрастания
        static void LINQ1(List<double> number)
        {
            var lowNums = from n in number
                          where n >= 0
                          orderby n
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //Вывести на экран все отрицательные числа, отсортировав их в порядке убывания.
        static void LINQ2(List<double> number)
        {
            var lowNums = from n in number
                          where n < 0
                          orderby n descending
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //Вывести на экран все числа, попадающий в отрезок[a, b], отсортировав их в порядке
        //возрастания
        static void LINQ3(List<double> number)
        {
            Console.WriteLine("A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B=");
            int B = Convert.ToInt32(Console.ReadLine());
            var lowNums = from n in number
                          where (n >= A) && (n <= B)
                          orderby n
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //Вывести на экран все числа, лежащие вне отрезка[a, b], отсортировав их в порядке
        //убывания.
        static void LINQ4(List<double> number)
        {
            Console.WriteLine("A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B=");
            int B = Convert.ToInt32(Console.ReadLine());
            var lowNums = from n in number
                          where (n < A) || (n > B)
                          orderby n descending
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //Вывести на экран все четные положительные числа, отсортировав их в порядке
        //возрастания.
        static void LINQ5(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 0) && (n % 2 == 0)
                          orderby n descending
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //Вывести на экран все нечетные отрицательные числа, отсортировав их в порядке
        //убывания.
        static void LINQ6(List<double> number)
        {
            var lowNums = from n in number
                          where (n < 0) && (n % 2 != 0)
                          orderby n descending
                          select n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //  Вывести на экран все элементы, меньшие заданного числа, увеличив их в два раза.
        static void LINQ7(List<double> number)
        {
            Console.WriteLine("Введите число:");
            int X = Convert.ToInt32(Console.ReadLine());
            var lowNums = from n in number
                          where (n < X)
                          orderby n
                          select n * 2;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран все элементы, большие заданного числа, уменьшив их в два раза.
        static void LINQ8(List<double> number)
        {
            Console.WriteLine("Введите число:");
            int X = Convert.ToInt32(Console.ReadLine());
            var lowNums = from n in number
                          where (n > X)
                          orderby n
                          select n / 2;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран все двухзначные числа, увеличив их на 5.
        static void LINQ9(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 9 && n < 100) || (n < -9 && n > -100)
                          orderby n
                          select n + 5;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран все трехзначные числа, уменьшив их на 100.
        static void LINQ10(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 99 && n < 1000) || (n < -99 && n > -1000)
                          orderby n
                          select n - 100;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран все положительные двухзначные числа, заменив их на
        // противоположное значение
        static void LINQ11(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 9) && (n < 100)
                          orderby n
                          select -n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран все отрицательные трехзначные числа, заменив их на противоположное
        // значение
        static void LINQ12(List<double> number)
        {
            var lowNums = from n in number
                          where (n < -99 && n > -1000)
                          orderby n
                          select -n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран в порядке возрастания все элементы, меньшие заданного числа,
        //  увеличив их в три раза.
        static void LINQ13(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 9) && (n < 100)
                          orderby n
                          select n + 5;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // Вывести на экран в порядке убывания все элементы, большие заданного числа, уменьшив
        // их в три раза.
        static void LINQ14(List<double> number)
        {
            Console.WriteLine("Введите число:");
            int X = Convert.ToInt32(Console.ReadLine());
            var lowNums = from n in number
                          where (n > X)
                          orderby n descending
                          select n / 3;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //  15.Вывести на экран в порядке возрастания все двухзначные числа, увеличив их на 1.
        static void LINQ15(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 9 && n < 100) || (n < -9 && n > -1000)
                          orderby n
                          select n + 1;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        // 16.Вывести на экран в порядке убывания все трехзначные числа, уменьшив их на 1.
        static void LINQ16(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 99 && n < 1000) || (n < -99 && n > -1000)
                          orderby n descending
                          select n + 1;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //17.Вывести на экран в порядке возрастания все положительные двухзначные числа, заменив
        //их на противоположное значение.
        static void LINQ17(List<double> number)
        {
            var lowNums = from n in number
                          where (n > 9 && n < 100)
                          orderby n
                          select -n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //18.Вывести на экран в порядке убывания все отрицательные трехзначные числа, заменив
        //них на противоположное значение.
        static void LINQ18(List<double> number)
        {
            var lowNums = from n in number
                          where (n < -99 && n > -1000)
                          orderby n descending
                          select -n;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //19.Вывести на экран в порядке возрастания все четные числа, уменьшив их в два раза.
        static void LINQ19(List<double> number)
        {
            var lowNums = from n in number
                          where (n % 2 == 0)
                          orderby n
                          select n / 2;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
        //20.Вывести на экран в порядке убывания все нечетные числа, увеличив их в два раза.
        static void LINQ20(List<double> number)
        {
            var lowNums = from n in number
                          where (n % 2 != 0)
                          orderby n descending
                          select n * 2;
            foreach (var x in lowNums)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
        }
 
        static void Main()
        {

            //List<double> number = new List<double> { -100, 2, 3, -450, 5, -67, -7, 8, 99, 0 };
            //Console.WriteLine("Вывести на экран все положительные числа, отсортировав их в порядке возрастания");
            //LINQ1(number);
            //Console.WriteLine("Вывести на экран все отрицательные числа, отсортировав их в порядке убывания");
            //LINQ2(number);
            //Console.WriteLine("Вывести на экран все числа, попадающий в отрезок[a, b], отсортировав их в порядке возрастания");
            //LINQ3(number);
            //Console.WriteLine("Вывести на экран все числа, лежащие вне отрезка[a, b], отсортировав их в порядке убывания.");
            //LINQ4(number);
            //Console.WriteLine("Вывести на экран все четные положительные числа, отсортировав их в порядке возрастания.");
            //LINQ5(number);
            //Console.WriteLine("Вывести на экран все нечетные отрицательные числа, отсортировав их в порядке убывания");
            //LINQ6(number);
            //Console.WriteLine("Вывести на экран все элементы, меньшие заданного числа, увеличив их в два раза");
            //LINQ7(number);
            //Console.WriteLine("Вывести на экран все элементы, большие заданного числа, уменьшив их в два раза");
            //LINQ8(number);
            //Console.WriteLine("Вывести на экран все двухзначные числа, увеличив их на 5");
            //LINQ9(number);
            //Console.WriteLine("Вывести на экран все трехзначные числа, уменьшив их на 100");
            //LINQ10(number);
            //Console.WriteLine("Вывести на экран все положительные двухзначные числа, заменив их на противоположное значение");
            //LINQ11(number);
            //Console.WriteLine("Вывести на экран все отрицательные трехзначные числа, заменив их на противоположное  значение");
            //LINQ12(number);
            //Console.WriteLine("Вывести на экран в порядке возрастания все элементы, меньшие заданного числа, увеличив их в три раза");
            //LINQ13(number);
            //Console.WriteLine("Вывести на экран в порядке убывания все элементы, большие заданного числа, уменьшив их в три раза.");
            //LINQ14(number);
            //Console.WriteLine("Ввести на экран в порядке возрастания все двухзначные числа, увеличив их на 1.");
            //LINQ15(number);
            //Console.WriteLine("Вывести на экран в порядке убывания все трехзначные числа, уменьшив их на 1");
            //LINQ16(number);
            //Console.WriteLine("Вывести на экран в порядке возрастания все положительные двухзначные числа, заменив их на противоположное значение.");
            //LINQ17(number);
            //Console.WriteLine("Вывести на экран в порядке убывания все отрицательные трехзначные числа, заменив них на противоположное значение.");
            //LINQ18(number);
            //Console.WriteLine("Вывести на экран в порядке возрастания все четные числа, уменьшив их в два раза");
            //LINQ19(number);
            //Console.WriteLine("Вывести на экран в порядке убывания все нечетные числа, увеличив их в два раза");
            //LINQ20(number);

            #region Conditions
            /* Во всех задачах данного раздела подразумевается, что исходная информация хранится в
             текстовом файле input.txt, каждая строка которого содержит полную информацию о некотором
             объекте; результирующая информация должна быть записана в файл output.txt.
             Для хранения данных внутри программы организовать одномерный массив структур или
             коллекцию структур.
 
             Задание 1.На основе данных входного файла составить список студентов группы,
             включив следующие данные: ФИО, год рождения, домашний адрес, какую школу окончил.
             Вывести в новый файл информацию о студентах, окончивших заданную школу,
             отсортировав их по году рождения.
             Задание 2.На основе данных входного файла составить список студентов группы,
             включив следующие данные: ФИО, год рождения, домашний адрес, какую школу окончил.
             Вывести в новый файл информацию о студентах, сгруппировав данные по номеру школы,
             которую они окончили.

            Задание 3. На основе данных входного файла составить багажную ведомость камеры
            хранения, включив следующие данные: ФИО пассажира, количество вещей, общий вес
            вещей. Вывести в новый файл информацию о тех пассажирах, средний вес багажа которых
            превышает заданный, отсортировав их по количеству вещей, сданных в камеру хранения.
          
            Задание 4. На основе данных входного файла составить багажную ведомость камеры
            хранения, включив следующие данные: ФИО пассажира, количество вещей, общий вес
            вещей. Вывести в новый файл информацию о тех пассажирах, средний вес багажа которых
            превышает заданный, отсортировав их по ФИО.
           */
            #endregion

            //Рус.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
 
            Console.WriteLine("Начальные значения:");

            string[] allLines = File.ReadAllLines("input3-4.txt");
            // Переменная для записи строки в файл и вывода на экран
            string output;

            //#region 1-2
            //// Читаем из файла

            //// Преобразуем в массив студентов
            //Student[] students = new Student[allLines.Length];
            //for (int index = 0; index < allLines.Length; index++)
            //{
            //    string line = allLines[index];
            //    string[] fields = line.Split(';');
            //    // Trim() убирает начальные и конечные пробелы в строке
            //    Student student = new Student(fields[0].Trim(), Convert.ToInt32(fields[1]), fields[2].Trim(), Convert.ToInt32(fields[3]));
            //    students[index] = student;
            //}
            //int i = 0;
            //foreach (Student student in students)
            //{
            //    i++; Console.Write(i + ") ");
            //    Console.WriteLine(student);
 
            //}
 
            //Console.WriteLine("Задание 1. Вывести в новый файл информацию о студентах, окончивших заданную школу, отсортировав их по году рождения.");
            //Console.Write("Значение заданой школы =");
            //int val = Convert.ToInt32(Console.ReadLine());
            //var lowNums = from student in students
            //              where (student.School == val) 
            //              orderby student.YearOfBirth
            //              select student;
            //// Выводим данные
            //output = string.Join(Environment.NewLine, lowNums);
            //File.WriteAllText("output1.txt", output, Encoding.Unicode); // Вывести в файл
            //Console.WriteLine(output); // Вывести на экран
 
            //Console.WriteLine("Задание 2.Вывести в новый файл информацию о студентах, сгруппировав данные по номеру школы, которую они окончили");
            //var groups = from student in students
            //            group student by student.School into g
            //            from st in g
            //            select st;
            //// Выводим данные
            //output = string.Join(Environment.NewLine, groups);
            //File.WriteAllText("output2.txt", output, Encoding.Unicode); // Вывести в файл
            //Console.WriteLine(output); // Вывести на экран
            //#endregion

            #region 3-4
            // Читаем из файла
            allLines = File.ReadAllLines("input3-4.txt");
            // Преобразуем в массив студентов
            Passenger[] passengers = new Passenger[allLines.Length];
            for (int index = 0; index < allLines.Length; index++)
            {
                string line = allLines[index];
                string[] fields = line.Split(';');
                // Trim() убирает начальные и конечные пробелы в строке
                Passenger passenger = new Passenger(fields[0].Trim(), Convert.ToInt32(fields[1]), Convert.ToInt32(fields[3]));
                passengers[index] = passenger;
            }
            int i = 0;
            foreach (Passenger passenger in passengers)
            {
                i++; Console.Write(i + ") ");
                Console.WriteLine(passenger);

            }

            Console.WriteLine("Задание 3. Вывести в новый файл информацию о тех пассажирах, средний вес багажа которых превышает заданный, отсортировав их по количеству вещей, сданных в камеру хранения..");
            Console.Write("Максимальный вес багажа =");
            int MaxW = Convert.ToInt32(Console.ReadLine());
            var Task3 = from passenger in passengers
                        where (passenger.Weight > MaxW)  
                          orderby passenger.Count
                          select passenger;
            // Выводим данные
            output = string.Join(Environment.NewLine, Task3);
            File.WriteAllText("output3.txt", output, Encoding.Unicode); // Вывести в файл
            Console.WriteLine(output); // Вывести на экран

            Console.WriteLine("Задание 4.Вывести в новый файл информацию о тех пассажирах, средний вес багажа которых превышает заданный, отсортировав их по ФИО.");
            var Task4 = from passenger in passengers
                        where (passenger.Weight > MaxW)
                        orderby passenger.Count
                        select passenger;

            // Выводим данные
            output = string.Join(Environment.NewLine, Task4);
            File.WriteAllText("output4.txt", output, Encoding.Unicode); // Вывести в файл
            Console.WriteLine(output); // Вывести на экран
            #endregion
        }
    }
}
           


