using System;
using System.Collections.Generic;
using System.Text;

namespace Model4_HomeWork_Classes
{
    public partial class Car
    {
        private string _model;//Модель
        private int _cPlaces; //Count Places/Количество мест
        private string _countryOfOrigin; //Страна Производитель
        private bool _hasHeatedSeats; //Есть Подогрев Сидений
        private bool _isSold; // Машина Продана?
        private bool _isFree; // Машина свободна для Тест-Драйва?
        private double _price; //Цена

        //Статические поля
        private static int _countCars;
        private static string _ClassName;

        //Конструкторы

        //Конструктор по умолчанию
        public Car()
        {
            _model = string.Empty;
            _cPlaces = 1;
            _price = new double();
            _hasHeatedSeats = false;
            _countryOfOrigin = string.Empty;
            _isSold = false;
            _isFree = true;

            _countCars++;
        }

        //Конструкторы с парпметрами
        public Car(string model, int cPlaces, string countryOfOrigin , bool hasHeatedSeats,double price) 
        {
            SetModel(model);
            SetCountPlaces(cPlaces);
            SetCountryOfOrigin(countryOfOrigin);
            SetHasHeatedSeats(hasHeatedSeats);
            SetPrice(price);

            SetIsSold(false);
            SetIsFree(true);

            _countCars++;
        }

        public Car(string model, int cPlaces, string countryOfOrigin, bool hasHeatedSeats)
        {
            SetModel(model);
            SetCountPlaces(cPlaces);
            SetCountryOfOrigin(countryOfOrigin);
            SetHasHeatedSeats(hasHeatedSeats);
            SetPrice(0);

            SetIsSold(false);
            SetIsFree(true);

            _countCars++;
        }

        //Статический конструктор
        static Car() 
        {
            _countCars = 0;
            _ClassName = "Car";
        }

        //Геттеры и Сеттеры

        //_Model
        public void SetModel(string model)
        {
            _model = model;
        }

        public string  GetModel() 
        {
            return _model;
        }

        //cPlaces
        public void SetCountPlaces(int cPlaces)
        {
            if (cPlaces > 0)
                _cPlaces = cPlaces;
            else
                _cPlaces = 1;
        }

        public int GetCountPlaces()
        {
            return _cPlaces;
        }

        //_Price
        public void SetPrice(double price)
        {
            if (price >= 0)
                _price = price;
            else
                _price = new int();
        }

        public double GetPrice()
        {
            return _price;
        }

        //_hasHeatedSeats
        public void SetHasHeatedSeats(bool hasHeatedSeats)
        {
            _hasHeatedSeats = hasHeatedSeats;
        }

        public bool GetHasHeatedSeats()
        {
            return _hasHeatedSeats;
        }

        //_countryOfOrigin
        public void SetCountryOfOrigin(string countryOfOrigin)
        {
            _countryOfOrigin = countryOfOrigin;
        }

        public string GetCountryOfOrigin()
        {
            return _countryOfOrigin;
        }

        //_isSold
        public void SetIsSold(bool isSold)
        {
            _isSold = isSold;
        }

        public bool GetIsSold()
        {
            return _isSold;
        }

        //_isFree
        public void SetIsFree(bool isFree)
        {
            _isFree = isFree;
        }

        public bool GetIsFree()
        {
            return _isFree;
        }

        //Методы для управление классом
        public void GetCarInfo()
        {
            Console.WriteLine("\n-----------INFO-----------");
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Country Of Origin: {_countryOfOrigin}");
            Console.WriteLine($"Count Places: {_cPlaces}");
            Console.WriteLine($"Heated Seats: {_hasHeatedSeats}");
            Console.WriteLine($"Available in stock: {!_isSold}");//Есть в наличии
            Console.WriteLine($"Price: {_price}$");
        }

        //Значение передается по ссылке
        public void BuyCar(ref double yourMoney)
        {
            if (_isSold == true)
                Console.WriteLine("The car is sold!!!");//Машина продана!!!
            else if (yourMoney >= _price)
            {
                Console.WriteLine("You bought a car!!!");//Вы купили машину
                SetIsSold(true);
            }
            else
                Console.WriteLine("You don't have enough money!!!");//У вас не достаточно денег!!!
        }

        public void SingUpForTestDrive()
        {
            if (_isFree == true)
            {
                Console.WriteLine("You're booked for a test drive");//Вы записанны на тест-драйв
                _isFree = false;
            }
            else
                Console.WriteLine("The car is already reserved");//Машина уже зарезервирована
        }


    }
}
