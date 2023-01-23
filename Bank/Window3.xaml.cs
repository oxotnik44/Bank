using Bank.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;
namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private string name;
        private string dohod;
        private string stavka;
        private string summa;
        private string srokkredita;
        private string summavkladas;
        public Window3(string names, string dohods, string stavkas, string summas, double srokkredits, double summavklada)
        {
            InitializeComponent();
            name = names;
            summa = summas;
            srokkredita = Convert.ToString(srokkredits);
            summavkladas = Convert.ToDecimal(summavklada).ToString("#,##0 Руб.");
        }

        private readonly string TemplateFileName = @"C:\Users\artem\Downloads\Word.docx";//таков путь

        private void btn_voity_Click(object sender, RoutedEventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Password;
            Entities m = new Entities();
            var authorization = m.User;
            var contract = m.Contract;
            var bank = m.BankAccount;

            var idcontract = contract.OrderByDescending(x => x.IDContract).First().IDContract;
            var contractid = Convert.ToString(idcontract + 1);

            var bankaccount = bank.OrderByDescending(x => x.NumberAccount).First().NumberAccount;
            var accountbank = Convert.ToString(bankaccount + 1);


            var user = authorization.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            if (user != null)
            {
                string surname = user.Surname;
                string nameuser = user.Name;
                string patronymic = user.Patronymic;
                string seriespasport = user.Series;
                string numberpassport = user.Number;
                string passportotdel = user.Issued;
                string address = user.Adress;
                string birth = Convert.ToString(user.DateOfBirth);
                string email = user.E_Mail;
                string mapbirth = user.PlaceOfBirth;
                string date = DateTime.Now.ToString("dd");
                string month = DateTime.Now.ToString("MM");
                string year = DateTime.Now.ToString("yyyy");

                DateTime d1 = DateTime.Now;
                int diff = Convert.ToInt32(srokkredita);
                DateTime result = d1.AddDays(diff);
                string formatted = result.ToString("dd-MM-yyyy");


                MessageBox.Show("Авторизация выполнена успешно");

                var wordApp = new Word.Application();//переменная для word
                wordApp.Visible = false;//word скрыт
                try
                {
                    var wordDocument = wordApp.Documents.Open(TemplateFileName);//переменная для хранения нашего документа

                    //Вставка вмето специальных выражений в нашем файле
                    ReplaceWordsStub("<DATE>", date, wordDocument);
                    ReplaceWordsStub("<MONTH>", month, wordDocument);
                    ReplaceWordsStub("<YEAR>", year, wordDocument);

                    ReplaceWordsStub("<CONTRACTID>", contractid, wordDocument);

                    ReplaceWordsStub("<NUMBERACC>", accountbank, wordDocument);

                    ReplaceWordsStub("<DATEENDVKLAD>", formatted, wordDocument);

                    ReplaceWordsStub("<DATEBIRTH>", birth, wordDocument);

                    ReplaceWordsStub("<TIMEVKLD>", srokkredita, wordDocument);

                    ReplaceWordsStub("<ISSUE>", passportotdel, wordDocument);

                    ReplaceWordsStub("<SURNAME>", surname, wordDocument);

                    ReplaceWordsStub("<NAMEUSER>", nameuser, wordDocument);

                    ReplaceWordsStub("<PATRONYMIC>", patronymic, wordDocument);

                    ReplaceWordsStub("<SERIES>", seriespasport, wordDocument);

                    ReplaceWordsStub("<NM>", numberpassport, wordDocument);

                    ReplaceWordsStub("<ADDRESS>", address, wordDocument);

                    ReplaceWordsStub("<EMAIL>", email, wordDocument);

                    ReplaceWordsStub("<PLACEBIRTH>", mapbirth, wordDocument);

                    ReplaceWordsStub("<SUMVKLAD>", summavkladas, wordDocument);

                    ReplaceWordsStub("<SURNAME>", surname, wordDocument);

                    ReplaceWordsStub("<NAMEUSER>", nameuser, wordDocument);

                    ReplaceWordsStub("<PATRONYMIC>", patronymic, wordDocument);


                    wordDocument.SaveAs2(@"C:\Users\artem\Downloads\Word1.docx");//сохроняем наш документ
                    wordDocument.Close();//закрываем документ
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка!!!");//окно ошибки
                }
                finally
                {
                    wordApp.Quit();//закрываем word
                }
            }
            else
            {
                MessageBox.Show("Кооректно введите логин и пароль");
            }

        }
        /// <summary>
        /// Метод замены ключевых слов на данные
        /// </summary>
        /// <param name="stubToReplace">Ключевые слова</param>
        /// <param name="text">Текст, который заменяет ключевые слова</param>
        /// <param name="wordDocument">Наш документ</param>
        private void ReplaceWordsStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;//перменная для хранения данных документа
            range.Find.ClearFormatting();//метод сброса всех натстроек текста
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);//находим ключевые слова и заменяем их
        }
    }
}
