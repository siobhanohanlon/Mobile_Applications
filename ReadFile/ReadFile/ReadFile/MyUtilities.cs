using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//This is used to create file handling methods and call as needed
//This way dont need to do in eventhandler

namespace ReadFile
{
    class MyUtilities
    {
        //Making Methods static so dont have to create an instance of class can just call
        //Instead of 
        //MyUtilities myUtilsRead = new MyUtilities();
        //readText = myUtilsRead.ReadFromFile(path, fullFileName);
        //
        //Can do
        //readText = MyUtilities.ReadFromFile(path, fullFileName);

        //Method to Write to File
                                //Param to hold the full path
        public static void WriteToFile(string fullFileName, string WriteToString) //Public as needed in main class
        {
            //Access it using Stream Writer
            //When using files- closed asap and keep closed if not needed
            //File Access can fail- Permissions, Already open, Not there
            //FileName, Encoding
            using (var writer = new StreamWriter(fullFileName, false))
            {
                //Give it what you want to write
                writer.WriteLine(WriteToString);


            }
        }//End Write to file

        //Method to Read File
        public static string ReadFromFile(string path, string fullFileName)
        {
            //Declare Variable for String
            string readText = "";

            //Use a try..catch structure to prevent a crash if file doesnt exist
            //Type try and then double tab and it adds whats needed
            //Try to do all below
            try
            {
                //Read File
                using (var reader = new StreamReader(fullFileName))
                {
                    readText = reader.ReadToEnd(); //Reads fulll file
                }
            }

            //If it fails
            catch
            {
                //Change text so itll display to user
                readText = "Couldn't read the file!!! Check if file exists";

                //throw; dont use this if possible- as it crashing code
            }

            return readText;
        }

    }
}
