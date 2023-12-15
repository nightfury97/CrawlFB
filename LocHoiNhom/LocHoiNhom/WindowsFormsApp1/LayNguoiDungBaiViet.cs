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
using OpenQA.Selenium.Interactions;
using Org.BouncyCastle.Asn1.X509;

namespace TaiAnhNettruyen
{
    public partial class LayNguoiDungBaiViet : MetroForm
    {
        public LayNguoiDungBaiViet()
        {
            InitializeComponent();
        }
        IWebDriver driver = new FirefoxDriver();
        private void LayNguoiDungBaiViet_Load(object sender, EventArgs e)
        {

        }
        public int Sleep()
        {
            Random rnd = new Random();
            int num = rnd.Next(1000, 5000);
            Thread.Sleep(num);
            return num;
        }
        public static void Hover(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            
            try {
                action.MoveToElement(element);
            }
            catch
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, "+ (element.Location.Y-150).ToString() + ")" );
                action.MoveToElement(element);
            }   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbLinkTarget.Text.Length == 0)
            {
                lbThongBao.Text = "Chưa nhập thông tin tài khoản mục tiêu";
                return;
            }
            driver.Navigate().GoToUrl(tbLinkTarget.Text);
        }
        public void ScrollToTheBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        public void ScrollToPoint()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollTo({\r\n  top: 100,\r\n  left: 100,\r\n  behavior: \"smooth\",\r\n});");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = ExcelFile.Load("D:/Git/CrawlFB/LocHoiNhom/MauDanhSachBaiDang.xlsx");
            ExcelWorksheet sheet = workbook.Worksheets[0];
            int count = (int)numberRow.Value;
            for (int x = 1; x < count / 6; x++)
            {
                ScrollToTheBottom();
                Sleep();

            }

            sheet.Cells["A2"].Value = "https://web.facebook.com/ho.lytien.1";
            var Facebook_Name = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[1]/div[2]/div/div/div/div[3]/div/div/div[1]/div/div/span/h1"));
            string TenDoiTuong = Facebook_Name.Text;
            for (int i = 1; i < count; i++)
            {
                var Facebook_link = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                Hover(driver, Facebook_link);
                string LinkBaiViet = Facebook_link.GetAttribute("href");
                while(LinkBaiViet== (tbLinkTarget.Text+"#"))
                {

                    Hover(driver, Facebook_link);
                    Thread.Sleep(500);
                    var Facebook_link2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                    LinkBaiViet = Facebook_link2.GetAttribute("href");
                }    


                //var GroupName = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div/div/div[1]/span/div/a"));
                //string TenHoiNhom = GroupName.Text;
                //string DuongDan = GroupName.GetAttribute("href");

                //var Members = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div/div/div[2]/span/span"));
                //string SoThanhVien = Members.Text;
                sheet.Cells["A" + (i + 4).ToString()].Value = i;
                sheet.Cells["B" + (i + 4).ToString()].Value = LinkBaiViet;
                //sheet.Cells["C" + (i + 4).ToString()].Value = DuongDan;
                //sheet.Cells["E" + (i + 4).ToString()].Value = SoThanhVien.Split('·')[1].Trim();
                //sheet.Cells["F" + (i + 4).ToString()].Value = SoThanhVien;
            }
            workbook.Save("D:/Git/CrawlFB/LocHoiNhom/BaoCaoATam/" + TenDoiTuong + DateTime.Now.Ticks.ToString() + ".xlsx");
            lbThongBao.Text = "Xong thông tin hội nhóm";
        }
    }
}
