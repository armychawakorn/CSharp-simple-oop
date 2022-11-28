using System;

namespace OOP2_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Freind1 = new Human { Name = "พี", Weight = 110 };
            Human Freind2 = new Human { Name = "มายด์", Weight = 45 };
            Human Freind3 = new Human { Name = "แซ๊ก", Weight = 66 };
            Human Freind4 = new Human { Name = "เกอร์", Weight = 52 };
            Human Freind5 = new Human { Name = "ไอซ์", Weight = 50 };
            int Allweight = (Freind1.Weight + Freind2.Weight + Freind3.Weight + Freind4.Weight + Freind5.Weight) / 5;
            Console.WriteLine(string.Format("นำหนักเฉลี่ยของทุกคนคือ: {0} กิโลกรัม", Allweight));
            Console.WriteLine(string.Format("คนที่มีน้ำหนักมากที่สุดคือ: {0} หนักอยู่ที่ {1} กิโลกรัม", Freind1.Name, Freind1.Weight));
            Console.WriteLine(string.Format("คนที่มีน้ำหนักน้อยที่สุดคือ: {0} หนักอยู่ที่ {1} กิโลกรัม", Freind2.Name, Freind2.Weight));
            Console.WriteLine("ผู้พัฒนาโปรแกรม: นายชวกร เนืองภา รหัสนักศึกษา: 653450087-5");
            Console.ReadKey();
        }
    }
}
