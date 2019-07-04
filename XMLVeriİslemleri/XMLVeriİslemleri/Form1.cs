using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Xml.XPath;
using System.Xml;

namespace XMLVeriİslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaYolu = Application.StartupPath + "\\CalisanListesi.xml";

        const string veritabani = @"Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
         //server=.;Database=Northwind;trusted_connection=true";
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(dosyaYolu);
        }


        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(dosyaYolu);
            dataGridView1.DataSource = ds.Tables[0];
            webBrowser1.Url = new Uri(dosyaYolu);

        }

        private void btnVeriBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[1];
            bool bulundu = false;
            foreach (XmlNode item in secilenNode)
            {
                if (item.ChildNodes[0].InnerText == "Can"||item.Attributes["TCNo"].Value == "12345678901")
                {
                    MessageBox.Show("Aranan kisi foreach yaparak bulundu:\n\n" +item.ChildNodes[0].InnerText+" " +item.ChildNodes[1].InnerText + "\n" +item.ChildNodes[2].InnerText + "\n" +"TCNo: " +item.Attributes["TCNo"].Value);
                    bulundu = true;
                    break;
                }

            }
            if (!bulundu)
            {
                MessageBox.Show("Aranan kişi 'Can' bulunamadı.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXPathileTagBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode =
            xmlDoc.SelectSingleNode("Calisanlar / Calisan[Adi = 'Melek']");
            xmlDoc.SelectSingleNode(" Calisanlar / Calisan[@TCNo = 12345678902] ");
            if (secilenNode != null)
            {
                MessageBox.Show(" Aranan kisi XPath ile kolayca bulundu:\n\n "
                +secilenNode.ChildNodes[0].InnerText + " "
                +secilenNode.ChildNodes[1].InnerText + "\n"
                +secilenNode.ChildNodes[2].InnerText + "\n"
                +"TCNo:" +secilenNode.Attributes["TCNo"].Value);
            }
            else
            {
                MessageBox.Show(" Aranan kisi 'Melek'; bulunamadi." , "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnXPathileVerileriBul_Click(object sender, EventArgs e)
        {
            XPathDocument xmlDoc = new XPathDocument(dosyaYolu);
            XPathNavigator xNav = xmlDoc.CreateNavigator();
            XPathNodeIterator secilenNode = xNav.Select("Calisanlar/Calisan/Adi");

            string metin = "";
            while (secilenNode.MoveNext())
            {
                if (secilenNode.Current.InnerXml.StartsWith("C"))
                    metin += secilenNode.Current.InnerXml + "\n";
            }
            if (metin != "")
                MessageBox.Show("Adi C ile baslayanlar:\n\n" + metin);
            else
                MessageBox.Show("Adi C ile baslayan bulunamadi");
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnVeriDegistir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            if (secilenNode != null)
            {
                secilenNode.ChildNodes[1].InnerText = " Polat";
                secilenNode.ChildNodes[1].InnerText += " Galipler";
                xmlDoc.Save(dosyaYolu);

                MessageBox.Show("Soyadına eklemek ekleme yapıldı: \n \n"
                    + secilenNode.ChildNodes[0].InnerText + ""
                    + secilenNode.ChildNodes[1].InnerText);
            }
            else
            {
                MessageBox.Show("Aranan kişi 'Melek' bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnXMLVeriSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            if (secilenNode != null)
            {
                xmlDoc.DocumentElement.RemoveChild(secilenNode);
                xmlDoc.Save(dosyaYolu);
                MessageBox.Show("Melek dosyadan silindi.");
            }
            else
            {
                MessageBox.Show("Aranan kişi 'Melek' bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);

        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
       
            xmlDoc.Load(dosyaYolu);

            XmlElement yeniEleman = xmlDoc.CreateElement("Calisan");

            XmlAttribute attrTCNo = xmlDoc.CreateAttribute("TCNo");
            attrTCNo.Value = "1234678904";
            yeniEleman.Attributes.Append(attrTCNo);

            XmlNode xAdi = xmlDoc.CreateElement("Adi");
            xAdi.InnerText = "Buse";
            yeniEleman.AppendChild(xAdi);

            XmlNode xSoyadi = xmlDoc.CreateElement("Soyadi");
            xSoyadi.InnerText = "Zengin";
            yeniEleman.AppendChild(xSoyadi);

            xmlDoc.DocumentElement.AppendChild(yeniEleman);
            xmlDoc.Save(dosyaYolu);
            MessageBox.Show("'Buse' eklendi");
            webBrowser1.Url = new Uri(dosyaYolu);


        }

        private void btnSQLtoXML_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(veritabani);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products", cnn);

            DataTable dt = new DataTable("Product");
            adp.Fill(dt);

            DataSet ds = new DataSet("Products");
            ds.Tables.Add(dt);

           // string dosya = Application.StartupPath + "\\SQLtoXML.xml";

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            string dosya = fd.SelectedPath + "\\SQLtoXML.xml";
            ds.WriteXml(dosya);
            MessageBox.Show("SQL'den gelen veriler XML dosyasına yazildi.\n" + dosya);
            webBrowser1.Url = new Uri(dosya);

        }

        private void btnXMLtoSQL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string dosya = fd.SelectedPath + "\\SQLtoXML.xml";
                if (File.Exists(dosya))
                {
                    SqlConnection cnn = new SqlConnection(veritabani);
                    SqlDataAdapter adp = new SqlDataAdapter("select * from ProductsX", cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(adp);
                    DataSet ds = new DataSet();

                    ds.ReadXml(dosya);
                    adp.Update(ds.Tables[0]);

                    MessageBox.Show("XML'den okunan veriler ProductsX tablosuna kaydedildi.");
                    webBrowser1.Url = new Uri(dosya);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı. \n" + dosya, "",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                
            }
        }

        private void btnSchemaOlustur_Click(object sender, EventArgs e)
        {

        }

        private void btnSQLdenSchema_Click(object sender, EventArgs e)
        {

        }

        private void btnXMLSchemaDogrula_Click(object sender, EventArgs e)
        {

        }


    }
}
