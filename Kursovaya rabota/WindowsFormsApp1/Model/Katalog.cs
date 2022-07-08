using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1.Model
{
    class Katalog
    {
        string name; //название каталога
        int kolichestvo; //количество автомобилей в каталоге
        Avto[] avto; //автомобили каталога
        internal static string path;
        public Katalog()
        {
            try //обработка исключения
            {
                // Создаем объект класса StreamReader для считываения данных с файла.
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                // Объявляем локальные переменные для временного хранения данных.
                string mark; string kyzov; string strana; int year; int stoimost;
                name = sr.ReadLine();
                //считываем с файла название каталога
                kolichestvo = int.Parse(sr.ReadLine()); //считываем с файла количество автомобилей в каталоге
                sr.ReadLine(); //перемещаем указатель в файле на строчку вниз
                avto = new Avto[kolichestvo]; //создаем массив объектов
                Console.WriteLine();
                for (int i = 0; i < kolichestvo; i++) //создаем автомобили
                {
                    //Считываем данные с файла.
                    mark = sr.ReadLine();
                    kyzov = sr.ReadLine();
                    strana = sr.ReadLine(); 
                    year = int.Parse(sr.ReadLine());
                    stoimost = int.Parse(sr.ReadLine());
                    //Создаем автомобиль.
                    avto[i] = new Avto(mark, kyzov, strana, year, stoimost); 
                    sr.ReadLine();
                }
            }
            catch(Exception e) //В случае исключения, выводим информацию об ошибке
            {
                Console.WriteLine(e.Message);
            }

        }
        public string ShowKatalog() //Метод для отображения автомобилей в каталоге
        {
            string s = $"Название каталога: {name}\n";
            s += "\n";
            for (int i = 0; i < avto.Length; i++)
            {
                s += avto[i].ShowAvto();
            }
            return s;

        }
    }
}
