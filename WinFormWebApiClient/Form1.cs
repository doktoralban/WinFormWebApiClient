using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebApiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region" Tanımlamalar "
        private HttpClient client = new HttpClient();
        private string apiAdress = "http://localhost/WapiNW/api/Products/";

        #endregion

        #region" Load "

        private void Form1_Load(object sender, EventArgs e)
        {
            Run();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            UrunBul("0");
        }
        #endregion

        #region" Olaylar "

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && this.textBox1.Text.Trim() != "")
            {
                this.button1.PerformClick();
            }
        }

        #endregion


        #region" Buttons "
        private void buttonListe_Click(object sender, EventArgs e)
        {
            FormListe frm = new FormListe();
            frm.ShowDialog(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UrunBul(this.textBox1.Text.Trim());
        }



        private async void buttonEKLE_Click(object sender, EventArgs e)
        {
            Products productYeni = new Products
            {
                ProductName = "testEKLE_" + System.DateTime.Now.ToString()
                ,
                UnitPrice = 100m
                ,
                CategoryID = 2
                ,
                QuantityPerUnit = "10 adet"
            ,
                SupplierID = 4
            ,
                Discontinued = false
            ,
                UnitsInStock = 100
            ,
                UnitsOnOrder = 5
            ,
                ReorderLevel = 40

            };
            try
            {
                var url = await CreateProductAsync(productYeni);
                //...........................................
                var st = url.ToString().Split('/');
                int xt = st.Count();
                var dt = url.ToString().Split('/')[xt - 1];

                this.textBox1.Text = dt;
                this.button1.PerformClick();
                //...........................................

                MessageBox.Show("Kayıt Eklendi : " + url.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private async void buttonDEGISTIR_Click(object sender, EventArgs e)
        {
            string spr = apiAdress + this.textBox1.Text;
            var product = await GetProductAsync(spr);
            product.UnitPrice = 99m;
            //...........................................

            MessageBox.Show("Birim Fiyatı = 99 olarak değiştirilecek....");
            var sonuc = await UpdateProductAsync(product);

            MessageBox.Show(sonuc.UnitPrice.ToString() + " - olarak değiştirildi");


            this.button1.PerformClick();
        }

        #endregion


        #region" Diger "
        private async void UrunBul(string sUrunID)
        {
            try
            {
                //.....................................
                this.Cursor = Cursors.WaitCursor;
                //.....................................
                string spr = apiAdress + sUrunID;// this.textBox1.Text;


                var product = await RunAsyncBSON(spr);
                //.....................................
                this.Cursor = Cursors.Default;
                //.....................................
                ShowProduct(product);
                //.....................................
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                //MessageBox.Show(ex.Message);
                return;
            }
        }
        private void Run()
        {
            client.BaseAddress = new Uri(apiAdress);

            //client.DefaultRequestHeaders.Accept.Clear();

            //client.DefaultRequestHeaders.Accept.Add(new 
            //	MediaTypeWithQualityHeaderValue("application/json"));


            //client.DefaultRequestHeaders.Accept.Add(new
            //		MediaTypeWithQualityHeaderValue("application/bson"));

        }


        private async Task<Products> GetProductAsync(string path)
        {
            Products product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Products>();
            }
            return product;
        }


        static async Task<Products> RunAsyncBSON(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(path);

                // Set the Accept header for BSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/bson"));

                //....................................
                client.DefaultRequestHeaders.Add("Api_Key", "key123X");
                //....................................

                // Send GET request.
                var result = await client.GetAsync(path);
                result.EnsureSuccessStatusCode();

                // Use BSON formatter to deserialize the result.
                MediaTypeFormatter[] formatters = new MediaTypeFormatter[] {
                        new BsonMediaTypeFormatter()

						//MediaTypeFormatter[] formatters = new MediaTypeFormatter[] {
						//new JsonMediaTypeFormatter()

				};

                var product = await result.Content.ReadAsAsync<Products>(formatters);

                return product;

            }
        }

        private void ShowProduct(Products product)
        {

            //.....................................
            this.Cursor = Cursors.WaitCursor;
            //.....................................
            try
            {
                if (product == null)
                {
                    //.....................................
                    this.Cursor = Cursors.Default;
                    //.....................................
                    MessageBox.Show("Kayıt Bulunamadı");
                    return;
                }
                //..........................................
                if (product.Picture != null && product.Picture.Length > 0)
                {
                    byte[] imgary = product.Picture;
                    ImageConverter converter = new ImageConverter();
                    pictureBox1.Image = (Image)converter.ConvertFrom(imgary);
                }
                else
                {
                    pictureBox1.Image = null;
                }
                //..........................................
                this.labelCategoryName.Text = product.CategoryName;
                this.labelProductName.Text = product.ProductName;
                this.labelBirimFiyati.Text = string.Format("{0:C2}", product.UnitPrice);
                //..........................................
            }
            catch (Exception ex)
            {
                //.....................................
                this.Cursor = Cursors.Default;
                //.....................................
                MessageBox.Show(ex.Message);
                return;
            }
            //.....................................
            this.Cursor = Cursors.Default;
            //.....................................

        }



        #endregion



        //****************** CRUD İŞLEMLERİ *****************************

        //TODO:EKLE
        private async Task<Uri> CreateProductAsync(Products product)
        {
            // çağrılması.....
            //Products productYeni = new Products { ProductName = "test_12", UnitPrice = 100, CategoryID = 2 ,QuantityPerUnit=1};
            //var url = await CreateProductAsync(productYeni);

            //...................................................
            HttpResponseMessage response = await client.PostAsJsonAsync(apiAdress, product);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        //TODO:DEĞİŞTİR
        private async Task<Products> UpdateProductAsync(Products product)
        {
            //çağrılması :önce değiştirilecek sonra şöyle çağrılacak .. 
            //await UpdateProductAsync(product);
            //...................................................
            try
            {
                string sd = apiAdress + product.ProductID;

                HttpResponseMessage response = await client.PutAsJsonAsync(sd, product);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return product;

        }

        //TODO:SİL
        private async Task<System.Net.HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/products/{id}");
            return response.StatusCode;
        }


    }
}
