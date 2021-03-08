using System;
using System.Collections.Generic;
using System.IO; // Lop LT Dung namespace: System.IO va ENTITIES
using System.Linq;
using System.Web;
using DEMO_KTLT_2021_01.ENTITIES; // Lop LT Dung namespace: System.IO va ENTITIES

namespace DEMO_KTLT_2021_01.DATA_ACCESS_LAYER
{
    public class LT_DIEM
    {
        public static DIEM [] DocDanhSachDiem()
        {
            StreamReader reader = new StreamReader("E:\\diem.txt");
            string s;
            s = reader.ReadLine(); // Dong dau tien file: 'diem.txt' ghi Tong so Diem
            int N = int.Parse(s);
            DIEM [] kq = new DIEM [N];
            for (int i = 0; i < N; i++)
            {
                s = reader.ReadLine(); // Đọc dòng thứ 2 => dòng cuối
                string [] M = s.Split(',');
                kq[i].X = int.Parse(M[0]);
                kq[i].Y  = int.Parse(M[1]);
            }
            reader.Close();

            return kq;
        }
        public static void LuuDiem(DIEM A)
        {
            StreamWriter writer = new StreamWriter(@"E:\\diem.txt");
            writer.Write($"{A.X},{A.Y}");

            writer.Close();
        }
    }
}