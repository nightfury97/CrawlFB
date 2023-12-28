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
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using Newtonsoft.Json;

namespace TaiAnhNettruyen
{
    public partial class LayNguoiDungBaiViet : MetroForm
    {
        public LayNguoiDungBaiViet()
        {
            InitializeComponent();
        }
        IWebDriver driver = new FirefoxDriver();
        string TenFile = "";
        string TenFile2 = "";
        string rootPath = "";
        private void LayNguoiDungBaiViet_Load(object sender, EventArgs e)
        {
            rootPath = Application.StartupPath;
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

            try
            {
                action.MoveToElement(element);
            }
            catch
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0, " + (element.Location.Y - 150).ToString() + ")");
                action.MoveToElement(element);
            }
        }
        public static void Move(IWebDriver driver, int X, int Y)
        {
            Actions action = new Actions(driver);

            try
            {
                action.MoveByOffset(X, Y);
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");           
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
        public string GetDateAndTime(string DateTimeText)
        {
            //string Date;
            string TG;


            if (DateTimeText.Contains("phút"))
            {
                TG = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else if (DateTimeText.Contains("giờ"))
            {
                TG = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else if (DateTimeText.Contains("ngày"))
            {
                int subDate = Int16.Parse(DateTimeText.Split(' ')[0]);
                TG = DateTime.Now.AddDays(-subDate).ToString("dd/MM/yyyy");
            }
            else if (DateTimeText.Contains("Tháng"))
            {
                int Day = Int16.Parse(DateTimeText.Split(' ')[0]);
                int Month = Int16.Parse(DateTimeText.Split(' ')[2]);
                int Year = DateTime.Now.Year;
                TG = Day + "/" + Month + "/" + Year;
            }
            else
            {
                TG = "Chưa xử lý";
            }

            return TG;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile workbook = ExcelFile.Load(rootPath+"/MauDanhSachBaiDang.xlsx");
            ExcelWorksheet sheet = workbook.Worksheets[0];
            int count = (int)numberRow.Value;
            for (int x = 1; x < count / 3; x++)
            {
                ScrollToTheBottom();
                Sleep();
            }

            sheet.Cells["A2"].Value = "https://www.facebook.com/ho.lytien.1";
            var Facebook_Name = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[1]/div[2]/div/div/div/div[3]/div/div/div[1]/div/div/span/h1"));
            string TenDoiTuong = Facebook_Name.Text;
            for (int i = 1; i <= count; i++)
            {
                string LinkBaiViet = "";
                //var Facebook_link = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[1]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                try
                {
                    var Facebook_link = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                    Facebook_link.SendKeys("");
                    //Hover(driver, Facebook_link);
                    Thread.Sleep(1000);
                    LinkBaiViet = Facebook_link.GetAttribute("href").Split('?')[0];
                }
                catch { }
                try
                {
                    var Facebook_link = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                    Facebook_link.SendKeys("");
                    //Hover(driver, Facebook_link);
                    Thread.Sleep(1000);
                    LinkBaiViet = Facebook_link.GetAttribute("href").Split('?')[0];
                }
                catch { }


                string TGtemp = "";
                try
                {
                    var Facebook_Time = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[2]/div/div[2]/div/div[2]/span/span/span[2]/span/a"));
                    var Facebook_Time_Text = Facebook_Time.FindElements(By.XPath("./string()"));
                    TGtemp = Facebook_Time_Text.ToString();
                }
                catch
                {
                    TGtemp = "Không xác định";
                }


                string ThoiGian = GetDateAndTime(TGtemp);

                string NoiDung = "Không xác định";
                try
                {
                    var Facebook_Content = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[3]/div[1]/div/div/div/span/div"));
                    NoiDung = Facebook_Content.Text;
                }
                catch { }
                try
                {
                    var Facebook_Content = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[2]/div[2]/div[2]/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[3]/div[1]/div/div/div/span/div"));
                    NoiDung = Facebook_Content.Text;
                }
                catch { }


                //var Members = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div/div[1]/div[1]/div[2]/div/div/div/div/div/div[" + i.ToString() + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div/div/div[2]/span/span"));
                //string SoThanhVien = Members.Text;
                sheet.Cells["A" + (i + 4).ToString()].Value = i;
                sheet.Cells["B" + (i + 4).ToString()].Value = LinkBaiViet;
                sheet.Cells["C" + (i + 4).ToString()].Value = ThoiGian;
                sheet.Cells["D" + (i + 4).ToString()].Value = NoiDung;
                //sheet.Cells["C" + (i + 4).ToString()].Value = DuongDan;
                //sheet.Cells["E" + (i + 4).ToString()].Value = SoThanhVien.Split('·')[1].Trim();
                //sheet.Cells["F" + (i + 4).ToString()].Value = SoThanhVien;
            }
            TenFile = rootPath + "/BaoCaoATam/" + TenDoiTuong + DateTime.Now.Ticks.ToString() + ".xlsx";
            workbook.Save(TenFile);
            lbThongBao.Text = "Đã lưu danh sách bài đăng tại " + TenFile;
            lbDuongDan.Text = TenFile;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "D:\\Git\\CrawlFB\\LocHoiNhom\\BaoCaoATam/";
            //openFileDialog1.Filter = "Excel File (*.xls, *.xlsx)|*.xls;*.xlsx";
            //openFileDialog1.FilterIndex = 0;
            //openFileDialog1.RestoreDirectory = true;

            //if (openFileDialog1.ShowDialog() != DialogResult.OK)
            //{

            //    return;
            //}

            //lbDuongDan.Text = openFileDialog1.FileName;
            System.Diagnostics.Process.Start(lbDuongDan.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile workbook = ExcelFile.Load(lbDuongDan.Text);
            ExcelWorksheet sheet = workbook.Worksheets[0];

            ExcelFile Temp = ExcelFile.Load(rootPath + "/MauDanhSachBaiDang.xlsx");
            ExcelWorksheet TempSheet = Temp.Worksheets[0];

            int RowsCount = sheet.Rows.Count;
            int rowStep = 0;
            //int i = 1;
            for (int i = 1; i <= RowsCount - 4; i++)
            {

                string PostLink = sheet.Cells["B" + (i + 4).ToString()].Value.ToString();
                try
                {

                    driver.Navigate().GoToUrl(PostLink);
                }
                catch {
                    continue;
                }
                //"https://www.facebook.com/ho.lytien.1/posts/pfbid0ruzjmnqmRKmcZfAcyyoSDtW5StQVhWSrzrCrPtNgwyCQY5Q6hsBNfPxBkKgUPJ8xl";
                //if (PostLink == "") { continue; }
                TempSheet.Cells["A" + (i + 4 + rowStep).ToString()].Value = i.ToString();
                TempSheet.Cells["C" + (i + 4 + rowStep).ToString()].Value = sheet.Cells["D" + (i + 4).ToString()].Value.ToString();
                TempSheet.Cells["B" + (i + 4 + rowStep++).ToString()].Value = PostLink;
                
                Sleep();

                int y = 1;
                int flag = 0;
                int loop = 0;
                while (flag != 2)
                {
                    try
                    {
                        var SeeMore = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[4]/div/div/div[2]/div[4]/div[1]/div[2]"));
                        SeeMore.Click();
                        loop++;
                        if(loop > 50) { break; }
                    }
                    catch
                    {
                        break;
                    }

                }

                while (flag != 2)
                {
                    string Comment_User_links = "";
                    string Comment_User_Content = "";
                    try
                    {
                        flag = 1;
                        var Facebook_Comment = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[4]/div/div/div[2]/ul/li[" + y.ToString() + "]/div[1]/div/div[2]/div[1]/div[1]/div/div[1]/div/div/span[1]/a"));
                        Comment_User_links = Facebook_Comment.GetAttribute("href");

                        if (Comment_User_links.Contains("profile.php"))
                        {
                            Comment_User_links = Comment_User_links.Split('&')[0];
                        }
                        else
                        {
                            Comment_User_links = Comment_User_links.Split('?')[0];
                        }
                        var Facebook_Comment_Content = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[4]/div/div/div[2]/ul/li[" + y.ToString() + "]/div[1]/div/div[2]/div[1]/div[1]/div/div[1]/div/div/div/span/div"));
                        Comment_User_Content = Facebook_Comment_Content.Text;
                        
                    }
                    catch
                    {
                        flag = 0;

                    }
                    if (flag == 0)
                    {
                        try
                        {
                            var Facebook_Comment = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[4]/div/div/div[2]/ul/li[" + y.ToString() + "]/div[1]/div[2]/div[2]/div[1]/div[1]/div/div[1]/div/div/span/a"));
                            Comment_User_links = Facebook_Comment.GetAttribute("href");
                            
                            if (Comment_User_links.Contains("profile.php"))
                            {
                                Comment_User_links = Comment_User_links.Split('&')[0];
                            }
                            else
                            {
                                Comment_User_links = Comment_User_links.Split('?')[0];
                            }
                            var Facebook_Comment_Content = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div[8]/div/div/div[4]/div/div/div[2]/ul/li[" + y.ToString() + "]/div[1]/div/div[2]/div[1]/div[1]/div/div[1]/div/div/div/span/div"));
                            Comment_User_Content = Facebook_Comment_Content.Text;
                            
                        }
                        catch { flag = 2; }
                    }
                    TempSheet.Cells["B" + (i + 4 + rowStep).ToString()].Value = Comment_User_links;
                    TempSheet.Cells["C" + (i + 4 + rowStep++).ToString()].Value = Comment_User_Content;
                    y++;
                    //flag = 2;
                    Sleep();
                }
            }
            TenFile2 = rootPath + "/BaoCaoATam/" + "PHANTICH" + DateTime.Now.Ticks.ToString() + ".xlsx";
            Temp.Save(TenFile2);
            lbNguoiDung.Text = TenFile2;
            lbThongBao.Text = "Xong Bước 5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            ExcelFile workbook = ExcelFile.Load(TenFile2);
            ExcelWorksheet sheet = workbook.Worksheets[0];



            int RowsCount = sheet.Rows.Count;
            int rowStep = 0;
            //int i = 1;
            for (int i = 1; i <= RowsCount - 4; i++)
            {
                try
                {
                    string flag = (sheet.Cells["A" + (i + 4).ToString()].Value != null) ? sheet.Cells["A" + (i + 4).ToString()].Value.ToString() : "";
                    if (flag != "")
                    { continue; }
                    string UserLink = (sheet.Cells["B" + (i + 4).ToString()].Value != null) ? sheet.Cells["B" + (i + 4).ToString()].Value.ToString() : "";
                    //if (UserLink == "")
                    //{ continue; }
                    //driver.Navigate().GoToUrl(UserLink);
                    try
                    {

                        driver.Navigate().GoToUrl(UserLink);
                    }
                    catch
                    {
                        continue;
                    }
                    Sleep();
                    var FaceName = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[1]/div[2]/div/div/div/div[3]/div/div/div[1]/div/div/span/h1"));
                    string Name = FaceName.Text;
                    sheet.Cells["D" + (i + 4).ToString()].Value = Name;
                }
                catch { }
                try {
                    var FaceInfo = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div/div[4]/div[2]/div/div[1]/div[2]/div/div[1]/div/div/div/div/div[2]"));
                    string UserInfo = FaceInfo.Text;

                    if (UserInfo.ToUpper().Contains("ĐÀ NẴNG"))
                    {
                        sheet.Cells["A" + (i + 4).ToString()].Value = "Có yếu tố Đà Nẵng";
                        sheet.Rows[(i + 4).ToString()].Style.FillPattern.SetSolid(Color.Orange);
                    }
                    if (UserInfo.ToUpper().Contains("SỐNG TẠI ĐÀ NẴNG"))
                    {
                        sheet.Cells["F" + (i + 4).ToString()].Value = "Có";
                        sheet.Rows[(i + 4).ToString()].Style.FillPattern.SetSolid(Color.Orange);
                    }
                    if (UserInfo.ToUpper().Contains("LÀM VIỆC TẠI ĐÀ NẴNG"))
                    {
                        sheet.Cells["F" + (i + 4).ToString()].Value = "Có";
                        sheet.Rows[(i + 4).ToString()].Style.FillPattern.SetSolid(Color.Orange);
                    }
                    sheet.Cells["E" + (i + 4).ToString()].Value = UserInfo;
                    

                    Sleep();
                }
                catch { }
                
            }


            TenFile2 = rootPath + "/BaoCaoATam/" + "NGUOIDUNG" + DateTime.Now.Ticks.ToString() + ".xlsx";
            workbook.Save(TenFile2);
            lbKetQua.Text = TenFile2;
            lbThongBao.Text = "Xong Bước 6";
            //int RowsCount = sheet.Rows.Count;
            //for (int i = 1; i < RowsCount - 4; i++)
            //{
            //}
        }

        private void lbDuongDan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbDuongDan.Text);
        }

        private void lbNguoiDung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbNguoiDung.Text);
        }

        private void lbKetQua_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbKetQua.Text);
        }
        public void WriteCookiesToDisk(string file, string cookieJar)
        {
            using (Stream stream = File.Create(file))
            {
                try
                {
                    Console.Out.Write("Writing cookies to disk... ");
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, cookieJar);
                    Console.Out.WriteLine("Done.");
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Problem writing cookies to disk: " + e.GetType());
                }
            }
        }

        public static CookieContainer ReadCookiesFromDisk(string file)
        {

            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    Console.Out.Write("Reading cookies from disk... ");
                    BinaryFormatter formatter = new BinaryFormatter();
                    Console.Out.WriteLine("Done.");
                    return (CookieContainer)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Problem reading cookies from disk: " + e.GetType());
                return new CookieContainer();
            }
        }
        public static string GetCookiesAsString(IWebDriver driver)
        {
            var cookies = driver.Manage().Cookies.AllCookies;
            return System.Text.Json.JsonSerializer.Serialize(cookies, new JsonSerializerOptions { WriteIndented = true });
        }

        public void SetCookies(IWebDriver driver, string json)
        {
            var cookies = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var c in cookies)
            {
                string name = c.Name;
                string value = c.Value;
                string domain = c.Domain;
                string path = c.Path;
                DateTime? expiry = c.Expiry;
                bool secure = c.Secure;
                bool isHttpOnly = c.IsHttpOnly;
                string sameSite = c.SameSite;

                var cookie = new OpenQA.Selenium.Cookie(name, value, domain, path, expiry, secure, isHttpOnly, sameSite);

                driver.Manage().Cookies.AddCookie(cookie);
            }
        }
        private void SaveCookie_Click(object sender, EventArgs e)
        {
            string cookies = GetCookiesAsString(driver);
            string fileCookies = rootPath +"/Cookies/"+ DateTime.Now.Ticks.ToString() + ".txt";
            System.IO.File.WriteAllText(fileCookies, cookies);
            //WriteCookiesToDisk(fileCookies, cookies);
            lbThongBao.Text = "save cookies";
        }

        private void LoadCookie_Click(object sender, EventArgs e)
        {
            
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = rootPath + "/Cookies/";
            openFileDialog1.Filter = "Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {

                return;
            }
            var jsonText = File.ReadAllText(openFileDialog1.FileName);
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            SetCookies(driver, jsonText);
            lbThongBao.Text = "load cookies";

            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
    }
}
