using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    public class _Wifi_Router : _NetWorkEquipment
    {
        //поля
        private string VPN_func; // функция VPN
        private int trans_speed; // скорость передачи
        //свойства
        public string VPN_Func
        {
            get
            {
                return VPN_func;
            }
            set
            {
                if (value == null) VPN_func = "No name";
                else VPN_func = value;
            }
        }
        public int Trans_speed
        {
            get { return trans_speed; }
            set
            {
                if (value < 0 || value > 100000) trans_speed = 0;
                else trans_speed = value;
            }
        }
        //конструктор
        public _Wifi_Router(string color = "", int price = 0, int trans_speed = 0, string VPN_func = "") : base(color, price)
        {
            VPN_Func = VPN_func;
            Trans_speed = trans_speed;
        }
        //Метод print
        public override void Print_Info()
        {
            Console.WriteLine("Информация о Wi-fi роутере:");
            base.Print_Info();
            Console.WriteLine($"Функция VPN: {VPN_func}");
            Console.WriteLine($"Скорость передачи(Мбит/С): {trans_speed}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}Скорость передачи(Мбит/С):{trans_speed}\nФункция VPN:{VPN_func}\n";
        }
    }
}