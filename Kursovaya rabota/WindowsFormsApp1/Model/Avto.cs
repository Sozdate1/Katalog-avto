using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp1.Model
{
    class Avto
    {
        string mark; //марка автомобиля
        string kyzov; //тип кузова автомобиля
        string strana; //страна выпускающая автомобиль
        int year; //год выпуска автомобиля
        int stoimost; //стоимость автомобиля
        public Avto(string mark, string kyzov, string strana, int year, int stoimost)
        {
            this.mark = mark;
            this.kyzov = kyzov;
            this.strana = strana;
            this.year = year;
            this.stoimost = stoimost;
        }

        public string ShowAvto()//метод для вызова информации о автомобиле
        {
            string s = $"Марка: {mark}\n";
            s +=$"Тип кузова: {kyzov}\n";
            s +=$"Страна: {strana}\n";
            s +=$"Год выпуска: {year}\n";
            s +=$"Цена в мил. рублей: {stoimost}\n";
            s += "\n";
            return s;
        }
    }
}
