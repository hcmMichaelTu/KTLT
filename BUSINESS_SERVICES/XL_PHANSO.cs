using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEMO_KTLT_2021_01.ENTITIES;
using DEMO_KTLT_2021_01.DATA_ACCESS_LAYER;

namespace DEMO_KTLT_2021_01.BusinessServices
{
    
    public class XL_PHANSO
    {
        public static PHANSO CongPS(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }

        public static PHANSO CongPS(PHANSO[] A)
        {
            PHANSO kq;
            kq.TuSo = 0;
            kq.MauSo = 1;
            for(int i=0; i < A.Length; i++)
            {
                kq = CongPS(kq, A[i]);
            }
            return kq;
        }

        public static PHANSO CongPS_TapTin()
        {
            PHANSO[] dsPhanSo = LT_PHANSO.DocDanhSachPhanSo();
            return CongPS(dsPhanSo);
            
        }
    }
}