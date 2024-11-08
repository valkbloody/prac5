using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class _Switcher : _NetWorkEquipment
    {
        //поля
        private int num_SFPports; // число SFP портов
        private string placement; // размещение
        //свойства
        public string Placement
        {
            get
            {
                return placement;
            }
            set
            {
                if (value == null) placement = "";
                else placement = value;
            }
        }
        public int Num_SFPports
        {
            get { return num_SFPports; }
            set
            {
                if (value < 0 || value > 9) num_SFPports = 0;
                else num_SFPports = value;
            }
        }
        //конструктор
        public _Switcher(string color = "", int price = 0, int num_SFPports = 0, string placement = "") : base(color, price)
        {
            Placement = placement;
            Num_SFPports = num_SFPports;
        }
        //метод print
        public override void Print_Info()
        {
            Console.WriteLine("Информация о коммутаторе:");
            base.Print_Info();
            Console.WriteLine($"Размещение: {placement}");
            Console.WriteLine($"Количество SFW портов(от 0 до 9): {num_SFPports}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}Размещение:{placement}\nКоличество SFW портов(от 0 до 9):{num_SFPports}\n";
        }
    }
}
