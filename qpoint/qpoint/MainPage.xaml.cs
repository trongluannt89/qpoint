using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using qpoint.Services;
using qpoint.Models;
using Newtonsoft.Json;


namespace qpoint
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Language> languages;

        public MainPage()
        {
            InitializeComponent();
            GetJsonData();
            //Test pull 02.07 123
            //Luan 02072020: Test Git
            //Tung 02072020: Test
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            languages = await App.restManager.GetTasksAsync();
            pckLanguage.ItemsSource = languages;
        }

        void GetJsonData()
        {
            string jsonFileName = "UserData.json";
            var objUserData = new UserData();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list    
                objUserData = JsonConvert.DeserializeObject<UserData>(jsonString);
                lblDeviceID.Text = objUserData.DeviceId;
                lblLanguageID.Text = objUserData.LanguageId;
            }            
        }
    }
}
