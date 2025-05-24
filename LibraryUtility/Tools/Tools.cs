using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;


namespace LibraryUtility.Tools
{
    public static class Tools
    {
        //تاریخ شمسی
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }

        // کلیک معادل دکمه اینتر
        //public static void BtnEnter(KeyEventArgs e, Button button)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        button.PerformClick();
        //        e.Handled = true;
        //    }
        //}
        //IP
        public static string GetLocalIP()
        {
            string localIP = "";
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork) // فقط IPv4
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //RtlMessageBox.Show("Error getting IP Address: " + ex.Message);
            }
            return localIP;
        }

        /// <summary>
        /// کد ملی را صحت سنجی میکند
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool IsNationalCodeValid(this string ex, out string message)
        {
            message = string.Empty;
            //بررسی طول کد ملی
            if (ex.Length != 10)
            {
                message = "طول کد ملی اشتباه است";
                return false;
            }
            //اگر رشته ای باشد یا دارای کاراکتر حرف باشد
            if (ex.ToCharArray().Any(r => !char.IsNumber(r)))
            {
                message = "کد ملی شامل حروف است";
                return false;
            }
            if (ex.ToCharArray().GroupBy(r => r).Count() <= 3)
            {
                message = "کد ملی نا معتبر است";
                return false;
            }

            //TODO: ده رقم است و حرف ندارد
            //صحت سنجی شود
            var controlDigit = long.Parse(ex.Substring(ex.Length - 1));
            var reversedArray = ex.Substring(0, ex.Length - 1).ToCharArray().Reverse().ToArray();
            long sumAmount = 0;
            for (int i = 0; i < reversedArray.Length; i++)
            {
                var charPosition = i + 2;
                var numericValueInPosition = long.Parse(reversedArray[i].ToString());
                sumAmount += (charPosition * numericValueInPosition);
            }

            var remainder = sumAmount % 11;
            if (remainder < 2)
            {
                if (remainder != controlDigit)
                {
                    message = "کد ملی صحت ندارد";
                    return false;
                }

                return true;
            }
            if (controlDigit != 11 - remainder)
            {
                message = "کد ملی صحت ندارد";
                return false;
            }


            return true;
        }

        // چک کردن پسورد قوی
        public static void CheckPasswordStrength(this string password)
        {
            if ((password.Length < 8) || (!Regex.IsMatch(password, @"[A-Z]")) ||

         (!Regex.IsMatch(password, @"[a-z]")) || (!Regex.IsMatch(password, @"[0-9]"))
            || (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':;{}|<>]")))
            {
                //RtlMessageBox.Show("رمز عبور صحیح را وارد کنید");
                throw new Exception("رمز عبور صحیح را وارد کنید");
            }
        }

        //این متد اعداد را در هر صورت، فارسی نمایش می دهد
        public static string GetPersianNumber(string englishNumber)
        {
            string persianNumber = "";
            foreach (char ch in englishNumber)
            {
                persianNumber += (char)(1776 + char.GetNumericValue(ch));

            }
            return persianNumber;
        }
        // بعد    txtNumber.Text = GetPersianNumber(textBox1.Text);
        //با کلیک روی سلول در دیتاگرید، همه سطر انتخاب می شود، متد استایل دیتاگرید در -31 UI
        //private static void DataGridViewRowEnter(object sender, DataGridViewCellEventArgs e, DataGridView dataGridView1)
        //{
        //    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //}
        public static void txtProvider_Leave(TextBox txtProvider, ErrorProvider errorProvider1)
        {
            if (string.IsNullOrEmpty(txtProvider.Text))
            {
                errorProvider1.SetError(txtProvider, "اجباری بودن متن");
            }
            else
            {
                errorProvider1.SetError(txtProvider, "");
            }
        }

        public static void TxtDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            //فقط عدد وارد شود. MaxLenght طول هم محدود شده
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void TxtPersian(this KeyPressEventArgs e)
        {
            // فقط فارسی وارد شود
            if (e.KeyChar >= 97 && e.KeyChar <= 122)
            {
                e.Handled = true;
            }
        }

        public static void ShowNotificationInfo(string title, string msg)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information; // Set an icon
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(2000, title, msg, ToolTipIcon.Info);
            // Dispose the NotifyIcon when it's no longer needed
            notifyIcon.Dispose();
        }


    //    public static void (Control control){
    //    this.Alert("Success", frmAlert.enmType.Success);
    //        this.Alert("Info", frmAlert.enmType.Info); 
    //}



}
}
