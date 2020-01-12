using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            bool? res = ofd.ShowDialog();

            if (res != false)
            {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null)
                {
                    string file_name = ofd.FileName;
                    string file_text = File.ReadAllText(file_name);
                    textBox.Text = file_text;
                }
            }
        }

        private void CreateNewFile_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                SaveFile();
            }
            textBox.Text = "";
        }
        private void TimesNewRomanFont_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Times New Roman");
            VerdanaFont.IsChecked = false;
        }

        private void VerdanaFont_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontFamily = new FontFamily("Verdana");
            timesNewRomanFont.IsChecked = false;
        }

        private void RedBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedBackgroundsMenu();
            textBox.Background = Brushes.Red;
        }

        private void GreenBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedBackgroundsMenu();
            textBox.Background = Brushes.Green;
        }

        private void BlueBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedBackgroundsMenu();
            textBox.Background = Brushes.Blue;
        }

        private void WhiteBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedBackgroundsMenu();
            textBox.Background = Brushes.White;
        }

        private void UnCheckedBackgroundsMenu()
        {
            if (textBox.Background == Brushes.Red) redBackgroundColor.IsChecked = false;
            else if (textBox.Background == Brushes.Green) greenBackgroundColor.IsChecked = false;
            else if (textBox.Background == Brushes.Blue) blueBackgroundColor.IsChecked = false;
            else if (textBox.Background == Brushes.White) whiteBackgroundColor.IsChecked = false;
        }

        private void UnCheckedTextMenu()
        {
            if (textBox.Foreground == Brushes.Red) redTextColor.IsChecked = false;
            else if (textBox.Foreground == Brushes.Green) greenTextColor.IsChecked = false;
            else if (textBox.Foreground == Brushes.Blue) blueTextColor.IsChecked = false;
            else if (textBox.Foreground == Brushes.Black) blackTextColor.IsChecked = false;
        }

        private void RedTextColorr_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedTextMenu();
            textBox.Foreground = Brushes.Red;
        }

        private void GreenTextColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedTextMenu();
            textBox.Foreground = Brushes.Green;
        }

        private void BlueTextColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedTextMenu();
            textBox.Foreground = Brushes.Blue;
        }

        private void BlackTextColor_Click(object sender, RoutedEventArgs e)
        {
            UnCheckedTextMenu();
            textBox.Foreground = Brushes.Black;
        }

        private void SelectFrontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = selectFrontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);
            switch (fontSize)
            {
                case "10":
                    textBox.FontSize = 10;
                    break;
                case "12":
                    textBox.FontSize = 12;
                    break;
                case "14":
                    textBox.FontSize = 14;
                    break;
                case "16":
                    textBox.FontSize = 16;
                    break;
                case "18":
                    textBox.FontSize = 18;
                    break;
                case "24":
                    textBox.FontSize = 24;
                    break;
                case "32":
                    textBox.FontSize = 32;
                    break;
                case "40":
                    textBox.FontSize = 40;
                    break;
                case "48":
                    textBox.FontSize = 48;
                    break;
            }
        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res = sfd.ShowDialog();

            if (res != false)
            {
                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(textBox.Text);
                    }
                }
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection sql = new SqlConnection(connectionString);
            try
            {
                if (sql.State == System.Data.ConnectionState.Closed)
                    sql.Open();
                //Авторизация пользователя
                if (!AuthorizationUser(sql))
                {
                    SQL_Exec(sql, "INSERT INTO Users(login, password) VALUES (@login, @pass)");
                    MessageBox.Show("Вы добавлены в БД!");
                }
                else MessageBox.Show("Вы успешно авторизовались!");
                AuthPage authPage = new AuthPage();
                authPage.Show();
                //MainWindow mw = new MainWindow();
                //mw.Hide();
                //App.Current.MainWindow.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            //проверка на заполненные поля логина и пароля
            if (loginField.Text == "" || passField.Password == "") MessageBox.Show("Для удаления пользователя из БД, сначала заполните логин и пароль!");
            else
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                SqlConnection sql = new SqlConnection(connectionString);

                try
                {
                    if (sql.State == System.Data.ConnectionState.Closed)
                        sql.Open();
                    //поиск пользователя в БД
                    if (!AuthorizationUser(sql)) MessageBox.Show("Пользователь с введенными данными, не найден в БД.");
                    else
                    {
                        SQL_Exec(sql, "DELETE FROM Users WHERE login = @login and password = @pass");
                        MessageBox.Show("Пользователь успешно удален из БД!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }
            }
        }

        private void BtnDel_MouseMove(object sender, MouseEventArgs e)
        {
            btnDel.Background = Brushes.Red;
        }

        private void SQL_Exec(SqlConnection sql, string query)
        {
            SqlCommand comm = new SqlCommand(query, sql);
            comm.CommandType = System.Data.CommandType.Text;
            comm.Parameters.Add("@login", loginField.Text);
            comm.Parameters.Add("@pass", passField.Password);
            comm.ExecuteNonQuery();
        }
        private bool AuthorizationUser(SqlConnection sql)
        {
            string query = "SELECT count(1) FROM Users WHERE login = @login and password = @pass";
            SqlCommand sqlCom = new SqlCommand(query, sql);
            sqlCom.CommandType = System.Data.CommandType.Text;
            sqlCom.Parameters.Add("@login", loginField.Text);
            sqlCom.Parameters.Add("@pass", passField.Password);
            return Convert.ToInt32(sqlCom.ExecuteScalar()) == 1;
        }
    }
}
