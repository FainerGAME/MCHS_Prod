using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using MCHS.Server;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Spire.Doc;
using Spire.Doc.Documents;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using TextAlignment = System.Windows.TextAlignment;
using VerticalAlignment = System.Windows.VerticalAlignment;


namespace MCHS.User.Page
{
    public partial class ResponsePage : System.Windows.Controls.Page
    {
        public ResponsePage()
        {
            InitializeComponent();
            FillComboboxReport();
        }

        public void FillComboboxReport()
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Report", db.GetConnection());
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string NameSub = reader.GetString("Name");
                CB_File.Items.Add(NameSub);
            }
            db.closeConnection();
        }

        private void CB_File_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DB db = new DB();
            string query = $"SELECT * FROM Report WHERE Name = '{CB_File.SelectedItem}'";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string pathName = reader["Path"].ToString();
                string name = reader["Name"].ToString();

                TB_Path.Text = pathName;
                TB_Name.Text = name;
            }
            db.closeConnection();
        }

        private void Btn_Del_OnClick(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            string query = $"DELETE FROM Report WHERE Name = '{TB_Name.Text}' AND U_ID = '{global.userid}'";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Запись удалена");
        }

        private void Btn_Upd_OnClick(object sender, RoutedEventArgs e)
        {
            DB db = new DB();
            string query = $"UPDATE Report SET Name = '{TB_Name.Text}', Path='{TB_Path.Text}' WHERE Name = '{TB_Name.Text}' AND U_ID = '{global.userid}' ";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            db.openConnection();
            cmd.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Отчет обновлен");
        }

        private void Btn_Ret_OnClick(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader($"{TB_Path.Text}");
            string data = sr.ReadToEnd();
            TB_Write.Text = data;
            sr.Close();
        }

        private void Btn_Save_OnClick(object sender, RoutedEventArgs e)
        {
            Document document = new Document();
            Section section = document.AddSection();
            HeaderFooter header = section.HeadersFooters.Header;
            Paragraph headerParagraph = header.AddParagraph();
            Spire.Doc.Fields.TextRange headerText = headerParagraph.AppendText($"{TB_Header.Text}");
            headerText.CharacterFormat.FontName = "Times New Roman";
            headerText.CharacterFormat.FontSize = 14;
            headerText.CharacterFormat.Bold.ToString();
            
            Paragraph paragraph = section.AddParagraph();
            paragraph.AppendText($"{TB_Write.Text}");
            
            HeaderFooter footer = section.HeadersFooters.Footer;
            Paragraph footerParagraph = footer.AddParagraph();
            Spire.Doc.Fields.TextRange footerText = footerParagraph.AppendText($"{TB_Footer.Text}");
            footerParagraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            footerText.CharacterFormat.FontName = "Times New Roman";
            footerText.CharacterFormat.FontSize = 12;
            footerText.CharacterFormat.TextColor = Color.Gray;
            
            document.SaveToFile($"{TB_Path.Text}", FileFormat.Docx);
        }

        private void Btn_Path_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            TB_Path.Text = OFD.FileName;
        }

        private void Btn_Save_Server_OnClick(object sender, RoutedEventArgs e)
        {
            if (TB_Path.Text == " ")
            {
                MessageBox.Show("Не выбран файл");
            }
            else
            {
                DB db = new DB();
                string query = $"INSERT INTO Report (Name, Path, U_ID) VALUE ('{TB_Name.Text}','{TB_Path.Text.ToString().Replace("\\","\\\\")}','{global.userid.ToString()}')";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                db.openConnection();
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Отчет сохранен на сервере");
            }
        }
    }
}