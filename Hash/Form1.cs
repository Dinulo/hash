using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string type = "X2"; //Sets the computed hash automatically to all upper case letters. Set to "x2" for lower case.

        OpenFileDialog ofd = new OpenFileDialog(); // Dialog for opening files
        SaveFileDialog sfd = new SaveFileDialog(); // Dialog for saving hashes

        // Start of MD5 string hash function
        public string CreateMD5hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputbytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputbytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString(type));
            }
            return sb.ToString();
        }
        // End of MD5 string hash function

        
        // Start of SHA1 string hash function
        public string CreateSHA1hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString(type));
                }

                return sb.ToString();
            }
        }
        // End of SHA1 string hash function

        
        // Start of SHA256 string hash function
        public string CreateSHA256hash(string input)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(input));

                foreach (Byte b in result)
                    Sb.Append(b.ToString(type));
            }

            return Sb.ToString();
        }
        //End of SHA256 string hash function

        //Start of SHA512 string hash funcion
        public static string CreateSHA512hash(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
        //End of SHA512 string hash function

        // Start of MD5 file hash function
        public string GetMD5HashFromFile(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }
        // End of MD5 file hash function


        // Start of SHA1 file hash function
        public static string GetSHA1HashFromFile(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA1Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }

        }
        // End of SHA1 file hash function

        
        // Start of SHA256 file hash function
        public static string GetSHA256HashFromFile(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
            
        }
        // End of SHA256 file hash function

        //Start of SHA512 file hash function
        public static string GetSHA512HashFromFile(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                var sha = new SHA512Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }
        //End of SHA512 file hash function

        // Declaring string variables for hashing and comparing
        string inputToMD5 = "";
        string inputToSHA1 = "";
        string inputToSHA256 = "";
        string inputToSHA512 = "";

        string fileToMD5 = "";
        string fileToSHA1 = "";
        string fileToSHA256 = "";
        string fileToSHA512 = "";

        string filepath = ""; // Filepath for hashing a file


        string filecompMD5 = "";
        string filecompSHA1 = "";
        string filecompSHA256 = "";
        string filecompSHA512 = "";

        string filepathcomp = ""; // Filepath for a file to hash and compare

        string filepathSaveFile = ""; // Filepath for saving hashes to .txt file

        private void comboBoxChooseMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Button for hashing the text
        {
            if (textBoxInputString.Text == "")
            {
                MessageBox.Show("Textbox is empty");
            }
            else
            {
                inputToMD5 = CreateMD5hash(textBoxInputString.Text);
                inputToSHA1 = CreateSHA1hash(textBoxInputString.Text);
                inputToSHA256 = CreateSHA256hash(textBoxInputString.Text);
                inputToSHA512 = CreateSHA512hash(textBoxInputString.Text);

                if (radioButtonlow.Checked)

                {
                    inputToMD5 = inputToMD5.ToLower();
                    inputToSHA1 = inputToSHA1.ToLower();
                    inputToSHA256 = inputToSHA256.ToLower();
                    inputToSHA512 = inputToSHA512.ToLower();

                    textBoxMD5.Text = inputToMD5;
                    textBoxSHA1.Text = inputToSHA1;
                    textBoxSHA256.Text = inputToSHA256;
                    textBoxSHA512.Text = inputToSHA512;
                }

                    textBoxMD5.Text = inputToMD5;
                    textBoxSHA1.Text = inputToSHA1;      
                    textBoxSHA256.Text = inputToSHA256;
                    textBoxSHA512.Text = inputToSHA512;
            }
        }                   
        
        private void labelTitleStringToHash_Click(object sender, EventArgs e)
        {
        
        }

        private void labelUploadFile_Click(object sender, EventArgs e)
        {

        }

        private void labelGiveHash_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSHA256_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCompareHashes_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInputFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e) // Button for opening file to hash
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textBoxInputFile.Text = ofd.FileName; // Writes the file's path into textBoxInputFile
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Button for hashing a file
        {
            filepath = textBoxInputFile.Text;
            if (textBoxInputFile.Text == "" || File.Exists(filepath) == false ) // Tests if a filepath is given / valid
            {
                MessageBox.Show("No file uploaded or file not found");
            }
            else
            { 
            

            fileToMD5 = GetMD5HashFromFile(filepath);
            fileToSHA1 = GetSHA1HashFromFile(filepath);
            fileToSHA256 = GetSHA256HashFromFile(filepath);
            fileToSHA512 = GetSHA512HashFromFile(filepath);

                if (radioButtonlow.Checked)
                {
                    fileToMD5 = fileToMD5.ToLower();
                    fileToSHA1 = fileToSHA1.ToLower();
                    fileToSHA256 = fileToSHA256.ToLower();
                    fileToSHA512 = fileToSHA512.ToLower();

                    textBoxMD5.Text = fileToMD5;
                    textBoxSHA1.Text = fileToSHA1;
                    textBoxSHA256.Text = fileToSHA256;
                    textBoxSHA512.Text = fileToSHA512;
                }
            else
                {
                    textBoxMD5.Text = fileToMD5;
                    textBoxSHA1.Text = fileToSHA1;
                    textBoxSHA256.Text = fileToSHA256;
                    textBoxSHA512.Text = fileToSHA512;
                }
            }
        }

        private void buttonOpenFileCompare_Click(object sender, EventArgs e) // Button for opening file to hash and compare
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxUploadFile.Text = ofd.FileName; // Writes the file's path into textBoxInputFile
            }
        }

        private void buttonClearString_Click(object sender, EventArgs e)
        {
            textBoxInputString.Text = "";
        }

        private void buttonClearFile_Click(object sender, EventArgs e)
        {
            textBoxInputFile.Text = "";
        }

        private void buttonClearCompFile_Click(object sender, EventArgs e)
        {
            textBoxUploadFile.Text = "";
        }

        private void buttonClearCompHash_Click(object sender, EventArgs e)
        {
            textBoxGivenHash.Text = "";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseMethod.SelectedIndex == 0) //MD5
            {
                filepathcomp = textBoxUploadFile.Text;
                if (textBoxUploadFile.Text == "" || File.Exists(filepathcomp) == false)
                {
                    MessageBox.Show("No file uploaded or file not found");
                }
                else
                {
                    if (textBoxGivenHash.Text == "")
                    {
                        MessageBox.Show("No hash given");
                    }
                    else
                    {
                        filecompMD5 = GetMD5HashFromFile(filepathcomp);
                        string filecompMD5low = filecompMD5.ToLower();
                        if (filecompMD5 == textBoxGivenHash.Text || filecompMD5low == textBoxGivenHash.Text)
                        {
                            MessageBox.Show("The MD5 hashes match.");
                        }
                        else
                        {
                            MessageBox.Show("The MD5 hashes don't match! Be careful!");
                        }
                    }
                }
            }

            else if (comboBoxChooseMethod.SelectedIndex == 1) //SHA1
            {
                filepathcomp = textBoxUploadFile.Text;
                if (textBoxUploadFile.Text == "" || File.Exists(filepathcomp) == false)
                {
                    MessageBox.Show("No file uploaded or file not found");
                }
                else
                {
                    if (textBoxGivenHash.Text == "")
                    {
                        MessageBox.Show("No hash given");
                    }
                    else
                    {
                        filecompSHA1 = GetSHA1HashFromFile(filepathcomp);
                        string filecompSHA1low = filecompSHA1.ToLower();
                        if (filecompSHA1 == textBoxGivenHash.Text || filecompSHA1low == textBoxGivenHash.Text)
                        {
                            MessageBox.Show("The SHA1 hashes match");
                        }
                        else
                        {
                            MessageBox.Show("The SHA1 hashes don't match! Be careful!");
                        }
                    }
                }
            }

            else if (comboBoxChooseMethod.SelectedIndex == 2) //SHA256

            {
                filepathcomp = textBoxUploadFile.Text;
                if (textBoxUploadFile.Text == "" || File.Exists(filepathcomp) == false)
                {
                    MessageBox.Show("No file uploaded or file not found");
                }
                else
                {
                    if (textBoxGivenHash.Text == "")
                    {
                        MessageBox.Show("No hash given");
                    }
                    else
                    {
                        filecompSHA256 = GetSHA256HashFromFile(filepathcomp);
                        string filecompSHA256low = filecompSHA256.ToLower();
                        if (filecompSHA256 == textBoxGivenHash.Text || filecompSHA256low == textBoxGivenHash.Text)
                        {
                            MessageBox.Show("The SHA256 hashes match");
                        }
                        else
                        {
                            MessageBox.Show("The SHA256 hashes don't match! Be careful!");
                        }
                    }
                }
            }

            else if (comboBoxChooseMethod.SelectedIndex == 3) //SHA512
            {
                filepathcomp = textBoxUploadFile.Text;
                if (textBoxUploadFile.Text == "" || File.Exists(filepathcomp) == false)
                {
                    MessageBox.Show("No file uploaded or file not found");
                }
                else
                {
                    if (textBoxGivenHash.Text == "")
                    {
                        MessageBox.Show("No hash given");
                    }
                    else
                    {
                        filecompSHA512 = GetSHA512HashFromFile(filepathcomp);
                        string filecompSHA512low = filecompSHA512.ToLower();
                        if (filecompSHA512 == textBoxGivenHash.Text || filecompSHA512low == textBoxGivenHash.Text)
                        {
                            MessageBox.Show("The SHA512 hashes match");
                        }
                        else
                        {
                            MessageBox.Show("The SHA512 hashes don't match! Be careful!");
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("No hash method chosen");
            }
        }
        


        private void textBoxUploadFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveOutput_Click(object sender, EventArgs e) // Save button for text hashes, saves the variable's value, example MD5: saves variable inputToMD5 and not textBoxMD5.Text
        {
            if (textBoxInputString.Text == "")
            {
                MessageBox.Show("Textbox is empty");
            }
            else
            {
                sfd.Filter = "Textdatei (*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filepathSaveFile = sfd.FileName;
                    string[] lines = { "Hashes of string " + "«" + textBoxInputString.Text + "»", "", "MD5:", inputToMD5, "", "SHA1:", inputToSHA1, "", "SHA256:", inputToSHA256, "", "SHA512:", inputToSHA512 };
                    System.IO.File.WriteAllLines(filepathSaveFile, lines); // filepathSaveFile = where the file is, lines = string what to write in
                    MessageBox.Show("The file was saved to " + filepathSaveFile); // Messagebox for saved file + path
                }
                else  
                {
                    MessageBox.Show("File saving was cancelled.");
                }
            }
        }

        private void buttonSaveFileHashes_Click(object sender, EventArgs e) // Save button for file hashes, saves the variable's value, example: MD5: saves variable fileToMD5 and not textBoxMD5.Text
        {
            if (textBoxInputFile.Text == "")
            {
                MessageBox.Show("No file uploaded");
            }
            else
            {
                sfd.Filter = "Textdatei (*.txt); | *.txt;";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filepathSaveFile = sfd.FileName;
                    string[] lines = { "Hashes of file " + "«" + textBoxInputFile.Text + "»", "", "MD5:", fileToMD5, "", "SHA1:", fileToSHA1, "", "SHA256:", fileToSHA256, "", "SHA512;", fileToSHA512 };
                    System.IO.File.WriteAllLines(filepathSaveFile, lines); // filepathSaveFile = where the file is, lines = string what to write in
                    MessageBox.Show("The file was saved to " + filepathSaveFile); // Messagebox for saved file + path
                }
                else
                {
                    MessageBox.Show("File saving was cancelled.");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        public void radioButtonlow_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButtonhigh_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}

// Useful links:
// MD5 hash file with progess bar https://www.youtube.com/watch?v=9MJAUL7G49w
//https://www.youtube.com/watch?v=SJ-IH7gOTU0
//https://www.youtube.com/watch?v=JyfgHxe7BL4
//http://hashgenerator.de/
//https://blogs.msdn.microsoft.com/csharpfaq/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string/
//https://stackoverflow.com/questions/16999361/obtain-sha-256-string-of-a-string
//https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
// open file dialog: https://www.youtube.com/watch?v=1oBHpE7H12A
// test