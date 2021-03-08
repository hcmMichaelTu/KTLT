using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEMO_KTLT_2021_01.DATA_ACCESS_LAYER;
using DEMO_KTLT_2021_01.ENTITIES;
using System.IO; // Cho cái LuuTamGiac

namespace DEMO_KTLT_2021_01.BusinessServices
{
    public class XL_TAMGIAC
    {
        public static double TinhChuVi(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_DIEM.TinhKhoanCach(tg.B, tg.C);
            b = XL_DIEM.TinhKhoanCach(tg.A, tg.C);
            c = XL_DIEM.TinhKhoanCach(tg.A, tg.C);
            return a + b + c;
        }

        public static TAMGIAC DocTamGiac()
        {
            return LT_TAMGIAC.DocTamGiac();
        }

        public static bool KiemTraHopLe(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_DIEM.TinhKhoanCach(tg.A, tg.B);
            b = XL_DIEM.TinhKhoanCach(tg.B, tg.C);
            c = XL_DIEM.TinhKhoanCach(tg.A, tg.C);


            return a < b + c && b < a + c && c < a + b;
        }

        public static bool LuuTamGiac(TAMGIAC tg)
        {
            if (KiemTraHopLe(tg))
            {
                LT_TAMGIAC.LuuTamGiac(tg);
                return true;
            }
            return false;
        }
    }
}