using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebApiClient
{
	public partial class FormListe : Form
	{
		public FormListe()
		{
			InitializeComponent();
		}

		#region" Tanımlamalar "
		private HttpClient client = new HttpClient();
		private string apiListAdress = "http://localhost/WapiNW/api/gu/";
			//"http://localhost/WapiNW/api/Products/GetUrunListesi";

		#endregion

		#region" Load "

		private void FormListe_Load(object sender, EventArgs e)
		{

		}
		private void FormListe_Shown(object sender, EventArgs e)
		{

			client.BaseAddress = new Uri(apiListAdress);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

		}

		#endregion


		#region" Olaylar "



		#endregion


		#region" Buttons "
		private async void buttonListele_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			var product = await GetProductAsync(apiListAdress);
			try
			{
			//..............................
				this.dataGridView1.DataSource = product; 
			//..............................
			}
			catch (Exception ex)
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show(ex.Message);
				return;
			}
			this.Cursor = Cursors.Default;
		}

		#endregion

		#region" Diger "

		//private JArray GetRESTData(string uri)
		//{
		//	var webRequest = (HttpWebRequest)WebRequest.Create(uri);
		//	var webResponse = (HttpWebResponse)webRequest.GetResponse();
		//	var reader = new StreamReader(webResponse.GetResponseStream());
		//	string s = reader.ReadToEnd();
		//	return JsonConvert.DeserializeObject<JArray>(s);
		//}


		private async Task<JArray> GetProductAsync(string path)
		{
			//....................................
			//client.DefaultRequestHeaders.Add("Api_Key", "key123X");
			//....................................
			//............................
			HttpResponseMessage responseMSG = await client.GetAsync(path);
			//............................ 
			if (responseMSG.IsSuccessStatusCode)
			{
				var webR = (HttpWebRequest)WebRequest.Create(path);
				webR.Headers.Add("Api_Key", "key123X");
				var response = (HttpWebResponse)webR.GetResponse();

				var reader = new StreamReader(response.GetResponseStream());
				string s = reader.ReadToEnd();

				var product = JsonConvert.DeserializeObject<JArray>(s);

				return product;

			}

			return null;

		}






		#endregion

		
	}
}
