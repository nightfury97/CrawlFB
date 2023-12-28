using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using RestSharp;
using System.IO;
using RestSharp.Extensions;
using OpenQA.Selenium.Firefox;
using GemBox.Spreadsheet;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver = new FirefoxDriver();
        
        public static void SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
        {
            var stream = File.Create(filePath);
            stream.Write(data, 0, data.Length);
        }
        private void btnStart_ClickAsync(object sender, EventArgs e)
        {
          

        }

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
           
        }
        public int Sleep()
        {
            Random rnd = new Random();
            int num = rnd.Next(1000, 5000);
            Thread.Sleep(num);
            return num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Sleep();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var timkiem = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div/div/div/div/label/input"));
            //timkiem.SendKeys("Mua bán");
            //timkiem.SendKeys(OpenQA.Selenium.Keys.Enter);
            if(tbTuKhoa.Text.Length == 0)
            {
                lbThongBao.Text = "Chưa nhập từ khóa";
                return;
            }    
            driver.Navigate().GoToUrl("https://www.facebook.com/search/groups?q=" + tbTuKhoa.Text);
        }
        public void ScrollToTheBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = ExcelFile.Load("D:\\Git\\CrawlFB/LocHoiNhom/MauBaoCaoHoiNhom.xlsx");
            ExcelWorksheet sheet = workbook.Worksheets[0];
            int count = (int)numberRow.Value;
            for(int x = 1; x < count/6; x++)
            {
                ScrollToTheBottom();
                Sleep();
                
            }
            sheet.Cells["A2"].Value = tbTuKhoa.Text;
            for (int i = 1; i < count; i++)
            {
                var GroupName = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div/div/div[1]/span/div/a"));
                string TenHoiNhom = GroupName.Text;
                string DuongDan = GroupName.GetAttribute("href");

                var Members = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div/div/div[2]/span/span"));
                string SoThanhVien = Members.Text;
                sheet.Cells["A" + (i + 4).ToString()].Value = i;
                sheet.Cells["B" + (i + 4).ToString()].Value = TenHoiNhom;
                sheet.Cells["C" + (i + 4).ToString()].Value = DuongDan;
                sheet.Cells["E" + (i + 4).ToString()].Value = SoThanhVien.Split('·')[1].Trim();
                sheet.Cells["F" + (i + 4).ToString()].Value = SoThanhVien;            
            }           
            workbook.Save("D:\\Git\\CrawlFB/LocHoiNhom/BaoCao/" + tbTuKhoa.Text +DateTime.Now.Ticks.ToString() + ".xlsx");
            lbThongBao.Text = "Xong thông tin hội nhóm";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "D:/Git/CrawlFB/LocHoiNhom/BaoCao/";
            openFileDialog1.Filter = "Excel File (*.xls, *.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            lbDuongDan.Text = openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile workbook = ExcelFile.Load(lbDuongDan.Text);
            ExcelWorksheet sheet = workbook.Worksheets[0];


            ExcelFile Temp = ExcelFile.Load("D:\\Git\\CrawlFB/LocHoiNhom/MauBaoCaoHoiNhom.xlsx");
            ExcelWorksheet TempSheet = workbook.Worksheets[0];
            int count = (int)numberRow.Value;
            for (int i = 1; i < count; i++)
            {
                string flat = (sheet.Cells["D" + (i + 4).ToString()].Value != null) ? sheet.Cells["D" + (i + 4).ToString()].Value.ToString() : "";
                if(flat == "Yes")
                {
                    try
                    {
                    string GroupUrl = sheet.Cells["C" + (i + 4).ToString()].Value.ToString();
                    driver.Navigate().GoToUrl(GroupUrl + "members/admins");
                    var AdminCount = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[4]/div/div/div/div/div/div/div/div[2]/div/div/div[1]/div/div/div/div/div/h2/span/span/span/strong"));
                    string Count = AdminCount.Text.Split('·')[1].Trim();
                    int x = Int32.Parse(Count);
                    string data = "";
                    for(int y = 1; y <= x; y++)
                    {
                        
                            var AdminGroup = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[4]/div/div/div/div/div/div/div/div[2]/div/div/div[2]/div/div[" + y.ToString() + "]/div/div/div[2]/div[1]/div/div/div[1]/span/span[1]/span/a"));
                            string TenAdmin = AdminGroup.Text;
                            string DuongDan = AdminGroup.GetAttribute("href");
                            string uid = DuongDan.Split('/')[6];

                            data += TenAdmin + " (https://www.facebook.com/" + uid + ") \n";
                        
                        
                    }
                    sheet.Cells["G" + (i + 4).ToString()].Value = data;
                    Sleep();
                    }
                    catch { }
                }    
            }
            workbook.Save("D:\\Git\\CrawlFB/LocHoiNhom/BaoCao/Admin_" + tbTuKhoa.Text + DateTime.Now.Ticks.ToString() + ".xlsx");
            lbThongBao.Text = "Xong thông tin admin hội nhóm";
        }
    }
}
