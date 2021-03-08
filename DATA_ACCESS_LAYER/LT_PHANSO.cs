using System;
using System.Collections.Generic;
using System.IO; // Lop LT Dung namespace: System.IO va ENTITIES
using System.Linq;
using System.Web;
using DEMO_KTLT_2021_01.ENTITIES; // Lop LT Dung namespace: System.IO va ENTITIES

namespace DEMO_KTLT_2021_01.DATA_ACCESS_LAYER
{
    public class LT_PHANSO
    {
        public static PHANSO[] DocDanhSachPhanSo()
        {
            StreamReader reader = new StreamReader("E:\\phanso.txt");
            string s;
            s = reader.ReadLine(); // Đọc số đầu tiên là Tổng số Phân Số 
            int N = int.Parse(s);
            PHANSO[] kq = new PHANSO[N];
            for(int i=0; i < N; i++)
            {
                s = reader.ReadLine();
                string[] M = s.Split('/');
                kq[i].TuSo = int.Parse(M[0]);
                kq[i].MauSo = int.Parse(M[1]);
            }
            reader.Close();

            return kq;
        }
    }
}