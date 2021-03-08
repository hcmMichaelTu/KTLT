using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEMO_KTLT_2021_01.ENTITIES;
using DEMO_KTLT_2021_01.DATA_ACCESS_LAYER;
using System.IO;

namespace DEMO_KTLT_2021_01.BusinessServices
{
    
    public class XL_DIEM
    {
        public static double TinhKhoanCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public static double TinhKhoanCach_TapTin()
        {
            DIEM [] dsDiem = LT_DIEM.DocDanhSachDiem();
            return TinhKhoanCach(dsDiem[0], dsDiem[1]);
        }

        public static bool LuuDiem(DIEM A)
        {
            LT_DIEM.LuuDiem(A);

            return true;
        }
    }
}