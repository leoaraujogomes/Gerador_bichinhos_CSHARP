using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

           
namespace ProjetoCatAPI
{
            
    public partial class FrmGerador : Form
    {
        public string url;
        public FrmGerador()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rdbGato.Checked == true){
                ConsomeAPIGato();
            }else if (rdbCachorro.Checked == true)
            {
                ConsomeAPICachorro();
            }
            
            GeraImagem();
        }

        private void ConsomeAPIGato()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.thecatapi.com/v1/images/search");
                request.Method = "GET";
                var response = request.GetResponse();
                var rsp = new StreamReader(response.GetResponseStream()).ReadToEnd();
                rsp = rsp.Replace("[", "").Replace("]", "");
                ResponseGato.Root myDeserializedClass = JsonConvert.DeserializeObject<ResponseGato.Root>(rsp);
                url = myDeserializedClass.url;
            }
            catch (WebException ex)
            {
                var erro = new StreamReader(ex.Response.GetResponseStream());
                MessageBox.Show(erro.ReadToEnd());
            }
        }

        private void ConsomeAPICachorro()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dog.ceo/api/breeds/image/random");
                request.Method = "GET";
                var response = request.GetResponse();
                var rsp = new StreamReader(response.GetResponseStream()).ReadToEnd();
                rsp = rsp.Replace("[", "").Replace("]", "");
                ResponseCachorro.Root myDeserializedClass = JsonConvert.DeserializeObject<ResponseCachorro.Root>(rsp);
                url = myDeserializedClass.message;
            }
            catch (WebException ex)
            {
                var erro = new StreamReader(ex.Response.GetResponseStream());
                MessageBox.Show(erro.ReadToEnd());
            }
            
        }

        private void GeraImagem()
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead(url);
            Image img = Image.FromStream(stream);
            pbGato.Image = img;
        }


    }
}
