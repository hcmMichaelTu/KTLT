

using System.IO; // Lop LT Dung namespace: System.IO va ENTITIES

using DEMO_KTLT_2021_01.ENTITIES; // Lop LT Dung namespace: System.IO va ENTITIES

namespace DEMO_KTLT_2021_01.DATA_ACCESS_LAYER
{
    public class LT_TAMGIAC
    {
            public static TAMGIAC DocTamGiac()
        {
            StreamReader reader = new StreamReader("E:\\tamgiac.txt");
            
            TAMGIAC tg;
            string s = reader.ReadLine();
            tg.A = KhoiTaoDiem(s);

            s = reader.ReadLine();
            tg.B = KhoiTaoDiem(s);

            s = reader.ReadLine();
            tg.C = KhoiTaoDiem(s);



            reader.Close();

            return tg;
        }

        public static void LuuTamGiac(TAMGIAC tg)
        {
            StreamWriter writer = new StreamWriter("E:\\tamgiac.txt");
            writer.WriteLine($"{tg.A.X},{tg.A.Y}");
            writer.WriteLine($"{tg.B.X},{tg.B.Y}");
            writer.Write($"{tg.C.X},{tg.C.Y}");

            writer.Close();

        }
        public static DIEM KhoiTaoDiem(string s)
        {
            DIEM kq;
            string[] M = s.Split(',');
            kq.X = int.Parse(M[0]);
            kq.Y = int.Parse(M[1]);
            return kq;
        }
    }
}