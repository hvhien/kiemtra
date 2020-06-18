using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace de1_1
{
    class process
    {
        XmlDocument doc;
        XmlElement root;
        String filename;
        public process()
        {
            filename = "khachhang.xml";
            doc = new XmlDocument();
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void show(DataGridView grd)
        {
            grd.Rows.Clear();
            grd.ColumnCount = 5;
            XmlNodeList li = root.SelectNodes("khachhang");
            int index = 0;
            foreach(XmlNode item in li)
            {
                grd.Rows.Add();
                grd.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                grd.Rows[index].Cells[1].Value = item.Attributes[1].InnerText;
                grd.Rows[index].Cells[2].Value = item.SelectSingleNode("hoten").InnerText;
                grd.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                grd.Rows[index].Cells[4].Value = item.SelectSingleNode("sdt").InnerText;
                index++;
            }
        }
        public void add(khachhang kh)
        {
            XmlElement kh2 = doc.CreateElement("khachhang");
            kh2.SetAttribute("makh", kh.makh);
            kh2.SetAttribute("chinhanh", kh.chinhanh);
            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = kh.hoten;
            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = kh.diachi;
            XmlElement sdt = doc.CreateElement("sdt");
            sdt.InnerText = kh.sdt;

            kh2.AppendChild(hoten);
            kh2.AppendChild(diachi);
            kh2.AppendChild(sdt);

            root.AppendChild(kh2);
            doc.Save(filename);
        }
        public void change(khachhang kh)
        {
            XmlNode khachangcantim = root.SelectSingleNode("khachhang[@makh='" + kh.makh + "']");
            if (khachangcantim != null)
            {


                XmlElement kh2 = doc.CreateElement("khachhang");
                kh2.SetAttribute("makh", kh.makh);
                kh2.SetAttribute("chinhanh", kh.chinhanh);
                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = kh.hoten;
                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = kh.diachi;
                XmlElement sdt = doc.CreateElement("sdt");
                sdt.InnerText = kh.sdt;

                kh2.AppendChild(hoten);
                kh2.AppendChild(diachi);
                kh2.AppendChild(sdt);

                root.ReplaceChild(kh2, khachangcantim);
                doc.Save(filename);
            }
        }
        public void deletekh(khachhang kh)
        {
            XmlNode khachhangcantim = root.SelectSingleNode("khachhang[@makh='" + kh.makh + "']");
            if (khachhangcantim != null)
            {
                root.RemoveChild(khachhangcantim);
                doc.Save(filename);
            }
        }
    }
}
