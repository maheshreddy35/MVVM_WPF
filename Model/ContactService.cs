using MVVMApp.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class ContactService:ViewModelbase
    {
        private List<Contlist> info = new List<Contlist>();
        public List<Contlist> Info
        {
            get { return info; }
            set { info = value; OnPropertyChanged("Info"); }
        }

        public ContactService()
        {
            
            try
            {
                HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:44365/api/Contacts");
                //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("https://localhost:44365/api/Contacts").Result;
                if (response.IsSuccessStatusCode)
                { 
                    var responseAsString = response.Content.ReadAsStringAsync().Result;
                    Info = JsonConvert.DeserializeObject<List<Contlist>>(responseAsString).ToList();
                }

            }
            catch (Exception ex)
            {
                
            }
        }
        public List<Contlist> Getcontacts()
        {
            return Info;
        }
    }
}
