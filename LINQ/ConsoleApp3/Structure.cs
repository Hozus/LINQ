using System;
using System.Collections.Generic;
 
namespace Structure
{
    public struct Student : IComparable<Student> 
    {

        //Имя, год рождения, номер школы (Задание 1-2)
        public Student(string name, int yearOfBirth, string adress, int school)
            : this()
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            School = school;
            Adress = adress;
        }
        //ФИО, номер группы, результаты сдачи трех экзаменов. (Задание 3-4)
        public Student(string name, int number, int[] results)
           : this()
        {
            Name = name;
            Number = number;
            Results = results;
        }
 
 
        // ФИО
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public int YearOfBirth { get; private set; }
        public int School { get; private set; }
        public int Number { get; private set; }
        public int[] Results { get; private set; }
 
        #region IComparable<Student> Members
        // Стандартный метод сортировки интерфейса IComparable<Student> 
        // Допустим, у студентов уникальные имена
        public int CompareTo(Student other)
        {
            return Comparer<string>.Default.Compare(Name, other.Name);
        }
 
        #endregion
        /// <summary>
        /// ФИО, год рождения, домашний адрес, какую школу окончил.
        /// </summary>
        /// <returns></returns>
        public override string ToString() // БЫЛА ОШИБКА!
        {
            return $"{Name}; {YearOfBirth}; {Adress}; {School}";
        }
 
    }
 
    public struct Passenger : IComparable
    {
 
        //ФИО пассажира, количество вещей, общий вес вещей.(Задание 5-6)
        public Passenger(string name, int count, int weight)
           : this()
        {
            Name = name;
            Count = count;
            Weight = weight;
        }
 
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Count { get; private set; }
 
 
        #region IComparable Members
        //стандартный метод сортировки интерфейса IComparable 
        public int CompareTo(object obj)
        {
            return Count.CompareTo(((Student)obj).YearOfBirth);
        }
        #endregion
 
        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}",
                                 Name, Count, Weight);
        }
    }
 
    public struct Car : IComparable //(Задание 7-8)
    {
 
        //марка автомобиля, номер автомобиля, фамилия его владельца, год приобретения, пробег
        public Car(string brand, int count, string name, int year, int run)
           : this()
        {
            Brand = brand;
            Count = count;
            Name = name;
            Year = year;
            Run = run;
 
 
        }
 
        //марка автомобиля, номер автомобиля, фамилия его владельца, год приобретения, пробег
        public string Brand { get; private set; }
        public int Count { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Run { get; private set; }
 
 
        #region IComparable Members
        public int CompareTo(object obj)
        {
            return Count.CompareTo(((Student)obj).YearOfBirth);
        }
        #endregion
 
        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}; {4}",
                                  Brand, Count, Name, Year, Run);
        }
    }
 
}