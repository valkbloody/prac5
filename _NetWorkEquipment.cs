using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class _NetWorkEquipment
    {
        // поля
        private string color;
        private int price;
        // свойства
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == null) color = "";
                else color = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 999999) price = 0;
                else price = value;
            }
        }
        // конструктор
        public _NetWorkEquipment(string color = "", int price = 0)
        {
            Color = color;
            Price = price;
        }
        // метод Print
        public virtual void Print_Info()
        {
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Цена (Руб.): {Price}");
        }
        public override string ToString()
        {
            return $"Цвет:{color}\nЦена (Руб.):{price}\n";
        }
    }
}
