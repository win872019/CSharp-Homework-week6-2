using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace week_6_檔案處理_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var 的使用

            //var a = "shajs";                       
            //Console.WriteLine(a.GetType());
            //Console.ReadKey();



            //Equals 用法
            //string[] a = { "abc", "def", "ghi" };
            //Console.WriteLine(a.Length.Equals(3));
            //Console.WriteLine(a[1].Equals("def"));


            // Random Class

            //Random rand = new Random();

            // Random.Next  - Method
            //Console.WriteLine(rand.Next(11));        // 0 ~ 10
            //Console.WriteLine(rand.Next(50,101));    // 50 ~ 100


            // Random.NextDouble  - Method
            /*Console.WriteLine(rand.NextDouble());  */       // 0.0 ~ 1.0

            // 字串格式化 - fn - 取至小數點第 n 位，
            // 四捨五入 (n 好像不可以 = 0)
            //var a = rand.NextDouble() * 5;
            //Console.WriteLine("{0}", a);
            //Console.WriteLine("{0:f2}", a);


            // Random.NextBytes - Method
            //byte[] bytes = new byte[5];            // byte 資料型別
            //rand.NextBytes(bytes);
            //foreach (var item in bytes)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.GetType());
            //}
            //Console.WriteLine(rand.GetType());




            //DateTime Struct
            //繼承 Object → ValueType → DateTime


            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.GetType());
            //Console.WriteLine("{0}", DateTime.Now);
            //Console.WriteLine("{0:y}", DateTime.Now);
            //Console.WriteLine("{0:m}", DateTime.Now);
            //Console.WriteLine("{0:d}", DateTime.Now);
            //Console.WriteLine("{0:t}", DateTime.Now);



            // DateTime - by Doc

            ////Invoke constructors 叫用建構函式
            //var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            //Console.WriteLine(date1);


            ////Assign a computed value 指派計算值
            //DateTime date1 = DateTime.Now;
            //DateTime date2 = DateTime.UtcNow;   //現在的 國際標準時間 (UTC)
            //DateTime date3 = DateTime.Today;

            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);



            ////Parse、ParseExact


            //var dateString = "5/1/2008 8:30:52 AM";
            //DateTime date1 = DateTime.Parse(dateString,
            //                          System.Globalization.CultureInfo.InvariantCulture);
            //var iso8601String = "20080501T08:30:52Z";
            //DateTime dateISO8602 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ",
            //                                System.Globalization.CultureInfo.InvariantCulture);

            //Console.WriteLine(date1);
            //Console.WriteLine(iso8601String);


            //var dateStr = "1/31/2023 9:20:56 PM";
            //DateTime dat2 = DateTime.Parse(dateStr);
            //Console.WriteLine(dat2);



            ////Method - DateTime.ToString()
            //var date1 = new DateTime(2023, 9, 11, 12, 50,36);
            //Console.WriteLine(date1);            
            //Console.WriteLine((date1).GetType());

            //Console.WriteLine(date1.ToString());
            //Console.WriteLine((date1.ToString()).GetType());




            ////存取 DateTime 屬性
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.GetType());

            //int year = now.Year;   // 等於 int year = DateTime.Now.Year;
            //int month = now.Month;
            //int day = now.Day;
            //int hour = now.Hour;
            //int minute = now.Minute;
            //int second = now.Second;
            //int microsecond = now.Millisecond;

            //Console.WriteLine($"year= {year}, month={month}, day={day}, hour={hour}, " +
            //    $"minute={minute}, second={second}, microsecond={microsecond}");





            ////格式化 DateTime
            //DateTime now = DateTime.Now;
            //string dtStr = now.ToString("yyyy-MM-dd HH:mm:ss");
            //string dtStr2 = now.ToString("yy-MMMM-d-dddd-ddd h-m-ss");
            //string dtD = now.ToString("D");
            //string dtd = now.ToString("d");

            //Console.WriteLine(dtStr);
            //Console.WriteLine(dtStr2);
            //Console.WriteLine(dtD);
            //Console.WriteLine(dtd);


            // 字串 轉 DateTime

            //DateTime.Parse(string)
            //string dateInput = "Feb 12, 2021";
            //DateTime parsedDate = DateTime.Parse(dateInput);
            //Console.WriteLine(parsedDate);

            //string dateInput2 = "2023 3 30";
            //var parsedDate2 = DateTime.Parse(dateInput2);
            //Console.WriteLine(parsedDate2);






            ////時間的計算
            ////TimeSpan Struct 
            ////繼承 Object → ValueType → TimeSpan

            //DateTime dateTime1 = new DateTime(2023, 9, 10, 13, 24, 23);
            //DateTime dateTime2 = new DateTime(2023, 9, 11, 23, 16, 36);

            //TimeSpan interval = dateTime1 - dateTime2;

            //Console.WriteLine(interval);
            //Console.WriteLine(interval.GetType());
            //Console.WriteLine(interval.ToString());
            //Console.WriteLine(interval.ToString().GetType());


            //// Display individual properties of the resulting TimeSpan object.
            //Console.WriteLine(interval.Days);
            //Console.WriteLine(interval.Hours);
            //Console.WriteLine(interval.Minutes);
            //Console.WriteLine(interval.Seconds);
            //Console.WriteLine(interval.Milliseconds);

            //Console.WriteLine(interval.TotalDays);
            //Console.WriteLine(interval.TotalHours);
            //Console.WriteLine(interval.TotalMinutes);
            //Console.WriteLine(interval.TotalSeconds);
            //Console.WriteLine(interval.Milliseconds);

            //Console.WriteLine(interval.Days.GetType());     // Int32



            ////e.g.
            //DateTime dat1 = DateTime.Now;
            //TimeSpan dat2 = DateTime.Now - dat1;
            //Console.WriteLine($"此兩行code運行時間為{ dat2}");

            //DateTime tomorrow = dat1.AddDays(1);
            //Console.WriteLine($"明天日期時間為 {tomorrow}");

            //DateTime after2months = dat1.AddMonths(2);
            //TimeSpan intervalOf2M = after2months - dat1;
            //Console.WriteLine($"兩個月後，會經過 {intervalOf2M.Days} 天");






            // PPT - hw

            // 顯示現在日期與時間
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            //Console.ReadKey();

            // 顯示再過30天為哪一天。
            //DateTime now = DateTime.Now;
            //string after30days = now.AddDays(30).ToString("D");            
            //Console.WriteLine(after30days);
            //Console.ReadKey();

            // 顯示24小時前的年月日時分秒
            //DateTime now = DateTime.Now;
            //DateTime before24hours = now.AddHours(-24);
            //Console.WriteLine($"現在日期時間為 {now}");
            //Console.WriteLine($"24小時前的年月日時分秒為 {before24hours}");
            //Console.ReadKey();


            //取得目前是幾月
            //DateTime now = DateTime.Now;
            //string month = now.ToString("MMM");
            //Console.WriteLine($"當前月份為{ month}");
            //Console.ReadKey();


            //取得明年是否為閏年
            //int nextYear = DateTime.Now.Year + 1;
            //Console.WriteLine($"今年是{DateTime.Now.Year}");
            //Console.WriteLine($"明年是{nextYear}");
            //bool isLeapYear = DateTime.IsLeapYear(nextYear);
            //Console.WriteLine($"明年是閏年? Ans: {isLeapYear}");
            //Console.ReadKey();



            //取得離2023年1月1日還有幾天
            //DateTime now = DateTime.Now;
            //DateTime dat1 = new DateTime(2023, 1, 1);
            //TimeSpan dat2 = dat1 - now;
            //Console.WriteLine($"現在日期為{now.ToString("D")}");
            //Console.WriteLine($"離{dat1.ToString("D")} 有 { dat2.Days}天");
            //Console.ReadKey();







            //p.32 一星期的猴子 - version switch  **

            //DayOfWeek dayOfWeek = DayOfWeek.Sunday;
            //Console.WriteLine((int)dayOfWeek);   //   DayOfWeek DayOfWeek.Sunday 轉 int 值為 0

            ////switch
            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            //string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            //int today = (int)dayOfWeek;
            //Console.WriteLine($"今天是{Day[today]}");

            //switch (today)
            //{
            //    case 1:
            //        Console.WriteLine("猴子穿新衣");
            //        break;

            //    case 2:
            //        Console.WriteLine("猴子肚子餓");
            //        break;

            //    case 3:
            //        Console.WriteLine("猴子去爬山");
            //        break;

            //    case 4:
            //        Console.WriteLine("猴子看電視");
            //        break;

            //    case 5:
            //        Console.WriteLine("猴子去跳舞");
            //        break;

            //    case 6:
            //        Console.WriteLine("猴子去斗六");
            //        break;

            //    default:
            //        Console.WriteLine("猴子過生日");
            //        break;

            //}

            //Console.ReadKey();



            //p.32 一星期的猴子
            //DateTime now = DateTime.Now;
            //string dayOfWeek = now.ToString("dddd");
            //Console.WriteLine($"今天是{dayOfWeek}");

            //if (dayOfWeek =="星期一")
            //{
            //    Console.WriteLine("猴子穿新衣");
            //}else if (dayOfWeek == "星期二")
            //{
            //    Console.WriteLine("猴子肚子餓");
            //}
            //else if (dayOfWeek == "星期三")
            //{
            //    Console.WriteLine("猴子去爬山");
            //}
            //else if (dayOfWeek == "星期四")
            //{
            //    Console.WriteLine("猴子看電視");
            //}
            //else if (dayOfWeek == "星期五")
            //{
            //    Console.WriteLine("猴子去跳舞");
            //}
            //else if (dayOfWeek == "星期六")
            //{
            //    Console.WriteLine("猴子去斗六");
            //}
            //else if (dayOfWeek == "星期日")
            //{
            //    Console.WriteLine("猴子過生日");
            //}
            //Console.ReadKey();











            //輸入 兩個日期，輸出兩個日期相差幾天
            //Console.Write("輸入第一個日期 (格式範例: 2023/02/21)： ");
            //DateTime Input1 = DateTime.Parse(Console.ReadLine());
            //Console.Write("輸入第二個日期： ");
            //DateTime Input2 = DateTime.Parse(Console.ReadLine());

            //TimeSpan interval=Input1 - Input2;

            //Console.WriteLine($"兩個日期相差 { Math.Abs(interval.Days)} 天");
            //Console.ReadKey();



            // 兩光大師占卜**

            //Random random = new Random();
            //int thisYear = DateTime.Now.Year;
            //int month = random.Next(1, 13);
            //int day = random.Next(1, DateTime.DaysInMonth(thisYear, month) + 1);
            //DateTime randomDate = new DateTime(thisYear, month, day);

            ////Console.WriteLine($"隨機產生的今年日期為 {randomDate.ToString("yyyy/MM/dd")}");
            //Console.WriteLine($"隨機產生的今年日期為 {thisYear}/{month}/{day}");

            //int s = (month * 2 + day) % 3;
            //switch (s)
            //{
            //    case 0:
            //        Console.WriteLine("運勢：普通");
            //        break;

            //    case 1:
            //        Console.WriteLine("運勢：吉");
            //        break;

            //    default:
            //        Console.WriteLine("運勢：大吉");
            //        break;
            //}

            //Console.ReadKey();


            //DateTime.DaysInMonth(nowYear, month)
            //int nowYear = 2024;
            //Random random = new Random();

            //int month =2;
            ////Console.WriteLine(month);
            //Console.WriteLine(DateTime.DaysInMonth(nowYear, month));





            // 兩光大師占卜 - Origin
            //Random rand= new Random();
            //int thisYear = DateTime.Now.Year;
            //int randomMonth = rand.Next(1, 13);
            //int randomDay=0;
            //bool isLeapYear=DateTime.IsLeapYear(thisYear);

            //int s = 0;

            //if (randomMonth == 1 || randomMonth == 3 || randomMonth == 5
            //    || randomMonth == 7 || randomMonth == 8 || randomMonth == 10 || randomMonth == 12)
            //{
            //    randomDay = rand.Next(1, 32);
            //}
            //else if (randomMonth == 4 || randomMonth == 6 || randomMonth == 9 || randomMonth == 11)
            //{
            //    randomDay = rand.Next(1, 31);
            //}
            //else if (randomMonth == 2 && isLeapYear == true)
            //{
            //    randomDay = rand.Next(1, 30);
            //}
            //else if (randomMonth == 2 && isLeapYear == false)
            //{
            //    randomDay = rand.Next(1, 29);
            //}

            //DateTime randomDate = new DateTime(thisYear, randomMonth,randomDay);
            //Console.WriteLine($"隨機產生一個今年的日期{ randomDate.ToString(" yyyy年 MMMM d日")}");

            //s = (randomMonth * 2 + randomDay) % 3;

            //if (s == 0)
            //{
            //    Console.WriteLine("\n~ 運勢：普通 ~");
            //}else if (s == 1)
            //{
            //    Console.WriteLine("\n~ 運勢：吉 ~");
            //}else if(s == 2)
            //{
            //    Console.WriteLine("\n~ 運勢：大吉 ~");
            //}

            //Console.ReadKey();










        }
    }
}