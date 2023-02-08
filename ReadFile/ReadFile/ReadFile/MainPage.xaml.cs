using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadFile
{
    public partial class MainPage : ContentPage
    {
        //Declare Constant Variabls
        public const string TEST_STRING = "Test Information";

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCreateFile_Clicked(object sender, EventArgs e)
        {
            //Create the file in local Application Data Folder
            //Declare Variables
            string fullFileName; //Includes path to file
            string path; //just path

            //Assign Variables
            path = Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData);
            //In System.IO
            fullFileName = Path.Combine(path, EntryFileName.Text + ".txt");

            //To See for yourself
            //C Drive/Users/*user being used*/AppData/Local/Packages/*check package.appxmanifest and packaging and use package name
            //*continued*/LocalState/FileName

            //Access using Utilities Class
            MyUtilities.ReadFromFile(fullFileName, TEST_STRING);
        }

        //Read File
        private void BtnReadFile_Clicked(object sender, EventArgs e)
        {
            //Declare Variables
            string readText; //Buffer for my data
            string path, fullFileName;

            //Assign path
            path = Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData);

            //Assign Filename
            fullFileName = Path.Combine(path, EntryFileName.Text + ".txt");


            //Access using Utilities Class
            readText = MyUtilities.ReadFromFile(path, fullFileName);

            //Display to Screen
            LblFileText.Text = readText;
        }
    }
}
