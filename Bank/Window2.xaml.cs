using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public double srokkredits;
        public double summavklada;
        public Window2(string n, string x, string j, double stabotvet, double stabotvet1, double stabotvet2, double srok, double t)
        {
            //передача дохода с первой формы
            InitializeComponent();
            tbl_stabilitydohod.Text = n;
            tbl_optimaldohod.Text = x;
            tbl_standartdohod.Text = j;
            srokkredits = srok;
            summavklada = t;

            tbl_stabilitysumma.Text = Convert.ToDecimal(stabotvet).ToString("#,##0 Руб.");
            tbl_optimalsumma.Text = Convert.ToDecimal(stabotvet1).ToString("#,##0 Руб.");
            tbl_standartsumma.Text = Convert.ToDecimal(stabotvet2).ToString("#,##0 Руб.");
        }

        private void bt_vkladfour_Click(object sender, RoutedEventArgs e)
        {
            UIElement element = gd_screen as UIElement;
            Uri path = new Uri(@"C:\Users\artem\Downloads\screenshot.png");
            CaptureScreen(element, path);
        }
        public void CaptureScreen(UIElement source, Uri destination)
        {
            try
            {
                double Height, renderHeight, Width, renderWidth;

                Height = renderHeight = source.RenderSize.Height;
                Width = renderWidth = source.RenderSize.Width;


                RenderTargetBitmap renderTarget = new RenderTargetBitmap((int)renderWidth, (int)renderHeight, 96, 96, PixelFormats.Pbgra32);

                VisualBrush visualBrush = new VisualBrush(source);

                DrawingVisual drawingVisual = new DrawingVisual();
                using (DrawingContext drawingContext = drawingVisual.RenderOpen())
                {

                    drawingContext.DrawRectangle(visualBrush, null, new Rect(new Point(0, 0), new Point(Width, Height)));
                }

                renderTarget.Render(drawingVisual);


                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(renderTarget));
                using (FileStream stream = new FileStream(destination.LocalPath, FileMode.Create, FileAccess.Write))
                {
                    encoder.Save(stream);
                }
                //Create a new PDF document.
                PdfDocument doc = new PdfDocument();
                //Add a page to the document.
                PdfPage page = doc.Pages.Add();
                //Create PDF graphics for the page
                PdfGraphics graphics = page.Graphics;
                //Load the image from the disk.
                //Draw the image
                //Save the document.
                doc.Save(@"C:\Users\artem\Downloads\screenshot1.pdf");
                //Close the document.
                doc.Close(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void bt_vkladthree_Click(object sender, RoutedEventArgs e)
        {
            var name = tbl_stability.Text;
            var dohod = tbl_stabilitydohod.Text;
            var stavka = tbl_stabilitystavka.Text;
            var summa = tbl_stabilitysumma.Text;

            Window3 form = new Window3(name, dohod, stavka, summa, srokkredits, summavklada);
            form.Show();
        }

        private void btn_vkladone_Click(object sender, RoutedEventArgs e)
        {
            var name = tbl_optimal.Text;
            var dohod = tbl_optimaldohod.Text;
            var stavka = tbl_optimalstavka.Text;
            var summa = tbl_optimalsumma.Text;

            Window3 form = new Window3(name, dohod, stavka, summa, srokkredits, summavklada);
            form.Show();
        }

        private void bt_vkladtwo_Click(object sender, RoutedEventArgs e)
        {
            var name = tbl_standart.Text;
            var dohod = tbl_standartdohod.Text;
            var stavka = tbl_standartstavka.Text;
            var summa = tbl_standartsumma.Text;


            Window3 form = new Window3(name, dohod, stavka, summa, srokkredits, summavklada);
            form.Show();
        }
    }
}
