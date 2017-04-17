namespace Hash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputString = new System.Windows.Forms.TextBox();
            this.labelTitleStringToHash = new System.Windows.Forms.Label();
            this.labelOutputHash = new System.Windows.Forms.Label();
            this.labelMD5 = new System.Windows.Forms.Label();
            this.labelSHA1 = new System.Windows.Forms.Label();
            this.labelSHA256 = new System.Windows.Forms.Label();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.textBoxSHA1 = new System.Windows.Forms.TextBox();
            this.textBoxSHA256 = new System.Windows.Forms.TextBox();
            this.buttonGenerateStringHashes = new System.Windows.Forms.Button();
            this.labelTitleCompareFileToHash = new System.Windows.Forms.Label();
            this.labelChooseFile = new System.Windows.Forms.Label();
            this.labelPasteGivenHash = new System.Windows.Forms.Label();
            this.labelTitleFileToHash = new System.Windows.Forms.Label();
            this.textBoxGivenHash = new System.Windows.Forms.TextBox();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUploadFile = new System.Windows.Forms.TextBox();
            this.buttonOpenFileHash = new System.Windows.Forms.Button();
            this.buttonGenerateFileHashes = new System.Windows.Forms.Button();
            this.buttonOpenFileCompare = new System.Windows.Forms.Button();
            this.buttonClearString = new System.Windows.Forms.Button();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.buttonClearCompFile = new System.Windows.Forms.Button();
            this.buttonClearCompHash = new System.Windows.Forms.Button();
            this.buttonSaveTextHashes = new System.Windows.Forms.Button();
            this.buttonSaveFileHashes = new System.Windows.Forms.Button();
            this.radioButtonlow = new System.Windows.Forms.RadioButton();
            this.radioButtonhigh = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSHA512 = new System.Windows.Forms.TextBox();
            this.comboBoxChooseMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputString
            // 
            this.textBoxInputString.Location = new System.Drawing.Point(13, 37);
            this.textBoxInputString.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInputString.Name = "textBoxInputString";
            this.textBoxInputString.Size = new System.Drawing.Size(485, 20);
            this.textBoxInputString.TabIndex = 0;
            this.textBoxInputString.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelTitleStringToHash
            // 
            this.labelTitleStringToHash.AutoSize = true;
            this.labelTitleStringToHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStringToHash.Location = new System.Drawing.Point(10, 13);
            this.labelTitleStringToHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleStringToHash.Name = "labelTitleStringToHash";
            this.labelTitleStringToHash.Size = new System.Drawing.Size(156, 22);
            this.labelTitleStringToHash.TabIndex = 1;
            this.labelTitleStringToHash.Text = "Enter text to hash:";
            this.labelTitleStringToHash.Click += new System.EventHandler(this.labelTitleStringToHash_Click);
            // 
            // labelOutputHash
            // 
            this.labelOutputHash.AutoSize = true;
            this.labelOutputHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputHash.Location = new System.Drawing.Point(10, 286);
            this.labelOutputHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutputHash.Name = "labelOutputHash";
            this.labelOutputHash.Size = new System.Drawing.Size(62, 20);
            this.labelOutputHash.TabIndex = 2;
            this.labelOutputHash.Text = "Output:";
            // 
            // labelMD5
            // 
            this.labelMD5.AutoSize = true;
            this.labelMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMD5.Location = new System.Drawing.Point(11, 314);
            this.labelMD5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMD5.Name = "labelMD5";
            this.labelMD5.Size = new System.Drawing.Size(34, 15);
            this.labelMD5.TabIndex = 3;
            this.labelMD5.Text = "MD5";
            // 
            // labelSHA1
            // 
            this.labelSHA1.AutoSize = true;
            this.labelSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSHA1.Location = new System.Drawing.Point(11, 366);
            this.labelSHA1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSHA1.Name = "labelSHA1";
            this.labelSHA1.Size = new System.Drawing.Size(38, 15);
            this.labelSHA1.TabIndex = 4;
            this.labelSHA1.Text = "SHA1";
            // 
            // labelSHA256
            // 
            this.labelSHA256.AutoSize = true;
            this.labelSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSHA256.Location = new System.Drawing.Point(11, 418);
            this.labelSHA256.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSHA256.Name = "labelSHA256";
            this.labelSHA256.Size = new System.Drawing.Size(52, 15);
            this.labelSHA256.TabIndex = 5;
            this.labelSHA256.Text = "SHA256";
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Location = new System.Drawing.Point(14, 332);
            this.textBoxMD5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.Size = new System.Drawing.Size(484, 20);
            this.textBoxMD5.TabIndex = 6;
            // 
            // textBoxSHA1
            // 
            this.textBoxSHA1.Location = new System.Drawing.Point(14, 382);
            this.textBoxSHA1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSHA1.Name = "textBoxSHA1";
            this.textBoxSHA1.Size = new System.Drawing.Size(484, 20);
            this.textBoxSHA1.TabIndex = 7;
            // 
            // textBoxSHA256
            // 
            this.textBoxSHA256.Location = new System.Drawing.Point(13, 435);
            this.textBoxSHA256.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSHA256.Name = "textBoxSHA256";
            this.textBoxSHA256.Size = new System.Drawing.Size(485, 20);
            this.textBoxSHA256.TabIndex = 8;
            this.textBoxSHA256.TextChanged += new System.EventHandler(this.textBoxSHA256_TextChanged);
            // 
            // buttonGenerateStringHashes
            // 
            this.buttonGenerateStringHashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateStringHashes.Location = new System.Drawing.Point(13, 229);
            this.buttonGenerateStringHashes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateStringHashes.Name = "buttonGenerateStringHashes";
            this.buttonGenerateStringHashes.Size = new System.Drawing.Size(230, 46);
            this.buttonGenerateStringHashes.TabIndex = 9;
            this.buttonGenerateStringHashes.Text = "Hash the text";
            this.buttonGenerateStringHashes.UseVisualStyleBackColor = true;
            this.buttonGenerateStringHashes.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitleCompareFileToHash
            // 
            this.labelTitleCompareFileToHash.AutoSize = true;
            this.labelTitleCompareFileToHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCompareFileToHash.Location = new System.Drawing.Point(10, 562);
            this.labelTitleCompareFileToHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleCompareFileToHash.Name = "labelTitleCompareFileToHash";
            this.labelTitleCompareFileToHash.Size = new System.Drawing.Size(223, 22);
            this.labelTitleCompareFileToHash.TabIndex = 10;
            this.labelTitleCompareFileToHash.Text = "Compare file to given hash";
            // 
            // labelChooseFile
            // 
            this.labelChooseFile.AutoSize = true;
            this.labelChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseFile.Location = new System.Drawing.Point(10, 591);
            this.labelChooseFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseFile.Name = "labelChooseFile";
            this.labelChooseFile.Size = new System.Drawing.Size(66, 15);
            this.labelChooseFile.TabIndex = 11;
            this.labelChooseFile.Text = "Upload file";
            this.labelChooseFile.Click += new System.EventHandler(this.labelUploadFile_Click);
            // 
            // labelPasteGivenHash
            // 
            this.labelPasteGivenHash.AutoSize = true;
            this.labelPasteGivenHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasteGivenHash.Location = new System.Drawing.Point(11, 658);
            this.labelPasteGivenHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasteGivenHash.Name = "labelPasteGivenHash";
            this.labelPasteGivenHash.Size = new System.Drawing.Size(100, 15);
            this.labelPasteGivenHash.TabIndex = 12;
            this.labelPasteGivenHash.Text = "Paste given hash";
            this.labelPasteGivenHash.Click += new System.EventHandler(this.labelGiveHash_Click);
            // 
            // labelTitleFileToHash
            // 
            this.labelTitleFileToHash.AutoSize = true;
            this.labelTitleFileToHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFileToHash.Location = new System.Drawing.Point(10, 119);
            this.labelTitleFileToHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitleFileToHash.Name = "labelTitleFileToHash";
            this.labelTitleFileToHash.Size = new System.Drawing.Size(164, 22);
            this.labelTitleFileToHash.TabIndex = 14;
            this.labelTitleFileToHash.Text = "Upload file to hash:";
            // 
            // textBoxGivenHash
            // 
            this.textBoxGivenHash.Location = new System.Drawing.Point(13, 675);
            this.textBoxGivenHash.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGivenHash.Name = "textBoxGivenHash";
            this.textBoxGivenHash.Size = new System.Drawing.Size(485, 20);
            this.textBoxGivenHash.TabIndex = 15;
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(13, 143);
            this.textBoxInputFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(401, 20);
            this.textBoxInputFile.TabIndex = 16;
            this.textBoxInputFile.TextChanged += new System.EventHandler(this.textBoxInputFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "OR";
            // 
            // textBoxUploadFile
            // 
            this.textBoxUploadFile.Location = new System.Drawing.Point(13, 608);
            this.textBoxUploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUploadFile.Name = "textBoxUploadFile";
            this.textBoxUploadFile.Size = new System.Drawing.Size(401, 20);
            this.textBoxUploadFile.TabIndex = 18;
            this.textBoxUploadFile.TextChanged += new System.EventHandler(this.textBoxUploadFile_TextChanged);
            // 
            // buttonOpenFileHash
            // 
            this.buttonOpenFileHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileHash.Location = new System.Drawing.Point(417, 138);
            this.buttonOpenFileHash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFileHash.Name = "buttonOpenFileHash";
            this.buttonOpenFileHash.Size = new System.Drawing.Size(80, 28);
            this.buttonOpenFileHash.TabIndex = 19;
            this.buttonOpenFileHash.Text = "Upload file";
            this.buttonOpenFileHash.UseVisualStyleBackColor = true;
            this.buttonOpenFileHash.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonGenerateFileHashes
            // 
            this.buttonGenerateFileHashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateFileHashes.Location = new System.Drawing.Point(260, 229);
            this.buttonGenerateFileHashes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateFileHashes.Name = "buttonGenerateFileHashes";
            this.buttonGenerateFileHashes.Size = new System.Drawing.Size(236, 46);
            this.buttonGenerateFileHashes.TabIndex = 20;
            this.buttonGenerateFileHashes.Text = "Hash the file";
            this.buttonGenerateFileHashes.UseVisualStyleBackColor = true;
            this.buttonGenerateFileHashes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonOpenFileCompare
            // 
            this.buttonOpenFileCompare.Location = new System.Drawing.Point(417, 603);
            this.buttonOpenFileCompare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFileCompare.Name = "buttonOpenFileCompare";
            this.buttonOpenFileCompare.Size = new System.Drawing.Size(80, 28);
            this.buttonOpenFileCompare.TabIndex = 21;
            this.buttonOpenFileCompare.Text = "Upload file";
            this.buttonOpenFileCompare.UseVisualStyleBackColor = true;
            this.buttonOpenFileCompare.Click += new System.EventHandler(this.buttonOpenFileCompare_Click);
            // 
            // buttonClearString
            // 
            this.buttonClearString.Location = new System.Drawing.Point(12, 63);
            this.buttonClearString.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearString.Name = "buttonClearString";
            this.buttonClearString.Size = new System.Drawing.Size(56, 19);
            this.buttonClearString.TabIndex = 22;
            this.buttonClearString.Text = "Clear";
            this.buttonClearString.UseVisualStyleBackColor = true;
            this.buttonClearString.Click += new System.EventHandler(this.buttonClearString_Click);
            // 
            // buttonClearFile
            // 
            this.buttonClearFile.Location = new System.Drawing.Point(12, 169);
            this.buttonClearFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(56, 19);
            this.buttonClearFile.TabIndex = 23;
            this.buttonClearFile.Text = "Clear";
            this.buttonClearFile.UseVisualStyleBackColor = true;
            this.buttonClearFile.Click += new System.EventHandler(this.buttonClearFile_Click);
            // 
            // buttonClearCompFile
            // 
            this.buttonClearCompFile.Location = new System.Drawing.Point(12, 634);
            this.buttonClearCompFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearCompFile.Name = "buttonClearCompFile";
            this.buttonClearCompFile.Size = new System.Drawing.Size(56, 19);
            this.buttonClearCompFile.TabIndex = 27;
            this.buttonClearCompFile.Text = "Clear";
            this.buttonClearCompFile.UseVisualStyleBackColor = true;
            this.buttonClearCompFile.Click += new System.EventHandler(this.buttonClearCompFile_Click);
            // 
            // buttonClearCompHash
            // 
            this.buttonClearCompHash.Location = new System.Drawing.Point(13, 701);
            this.buttonClearCompHash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearCompHash.Name = "buttonClearCompHash";
            this.buttonClearCompHash.Size = new System.Drawing.Size(56, 19);
            this.buttonClearCompHash.TabIndex = 28;
            this.buttonClearCompHash.Text = "Clear";
            this.buttonClearCompHash.UseVisualStyleBackColor = true;
            this.buttonClearCompHash.Click += new System.EventHandler(this.buttonClearCompHash_Click);
            // 
            // buttonSaveTextHashes
            // 
            this.buttonSaveTextHashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTextHashes.Location = new System.Drawing.Point(12, 524);
            this.buttonSaveTextHashes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveTextHashes.Name = "buttonSaveTextHashes";
            this.buttonSaveTextHashes.Size = new System.Drawing.Size(230, 31);
            this.buttonSaveTextHashes.TabIndex = 29;
            this.buttonSaveTextHashes.Text = "Save text hashes";
            this.buttonSaveTextHashes.UseVisualStyleBackColor = true;
            this.buttonSaveTextHashes.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // buttonSaveFileHashes
            // 
            this.buttonSaveFileHashes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFileHashes.Location = new System.Drawing.Point(260, 524);
            this.buttonSaveFileHashes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveFileHashes.Name = "buttonSaveFileHashes";
            this.buttonSaveFileHashes.Size = new System.Drawing.Size(236, 31);
            this.buttonSaveFileHashes.TabIndex = 30;
            this.buttonSaveFileHashes.Text = "Save file hashes";
            this.buttonSaveFileHashes.UseVisualStyleBackColor = true;
            this.buttonSaveFileHashes.Click += new System.EventHandler(this.buttonSaveFileHashes_Click);
            // 
            // radioButtonlow
            // 
            this.radioButtonlow.AutoSize = true;
            this.radioButtonlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonlow.Location = new System.Drawing.Point(174, 198);
            this.radioButtonlow.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonlow.Name = "radioButtonlow";
            this.radioButtonlow.Size = new System.Drawing.Size(145, 19);
            this.radioButtonlow.TabIndex = 32;
            this.radioButtonlow.Text = "Use lower case letters";
            this.radioButtonlow.UseVisualStyleBackColor = true;
            this.radioButtonlow.CheckedChanged += new System.EventHandler(this.radioButtonlow_CheckedChanged);
            // 
            // radioButtonhigh
            // 
            this.radioButtonhigh.AutoSize = true;
            this.radioButtonhigh.Checked = true;
            this.radioButtonhigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonhigh.Location = new System.Drawing.Point(12, 198);
            this.radioButtonhigh.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonhigh.Name = "radioButtonhigh";
            this.radioButtonhigh.Size = new System.Drawing.Size(147, 19);
            this.radioButtonhigh.TabIndex = 33;
            this.radioButtonhigh.TabStop = true;
            this.radioButtonhigh.Text = "Use upper case letters";
            this.radioButtonhigh.UseVisualStyleBackColor = true;
            this.radioButtonhigh.CheckedChanged += new System.EventHandler(this.radioButtonhigh_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "SHA512";
            // 
            // textBoxSHA512
            // 
            this.textBoxSHA512.Location = new System.Drawing.Point(13, 484);
            this.textBoxSHA512.Name = "textBoxSHA512";
            this.textBoxSHA512.Size = new System.Drawing.Size(484, 20);
            this.textBoxSHA512.TabIndex = 35;
            // 
            // comboBoxChooseMethod
            // 
            this.comboBoxChooseMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseMethod.FormattingEnabled = true;
            this.comboBoxChooseMethod.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.comboBoxChooseMethod.Location = new System.Drawing.Point(177, 732);
            this.comboBoxChooseMethod.Name = "comboBoxChooseMethod";
            this.comboBoxChooseMethod.Size = new System.Drawing.Size(123, 21);
            this.comboBoxChooseMethod.TabIndex = 37;
            this.comboBoxChooseMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseMethod_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 731);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Choose hash method:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(317, 722);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(181, 36);
            this.buttonCheck.TabIndex = 39;
            this.buttonCheck.Text = "Compare";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 769);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxChooseMethod);
            this.Controls.Add(this.textBoxSHA512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonhigh);
            this.Controls.Add(this.radioButtonlow);
            this.Controls.Add(this.buttonSaveFileHashes);
            this.Controls.Add(this.buttonSaveTextHashes);
            this.Controls.Add(this.buttonClearCompHash);
            this.Controls.Add(this.buttonClearCompFile);
            this.Controls.Add(this.buttonClearFile);
            this.Controls.Add(this.buttonClearString);
            this.Controls.Add(this.buttonOpenFileCompare);
            this.Controls.Add(this.buttonGenerateFileHashes);
            this.Controls.Add(this.buttonOpenFileHash);
            this.Controls.Add(this.textBoxUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.textBoxGivenHash);
            this.Controls.Add(this.labelTitleFileToHash);
            this.Controls.Add(this.labelPasteGivenHash);
            this.Controls.Add(this.labelChooseFile);
            this.Controls.Add(this.labelTitleCompareFileToHash);
            this.Controls.Add(this.buttonGenerateStringHashes);
            this.Controls.Add(this.textBoxSHA256);
            this.Controls.Add(this.textBoxSHA1);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.labelSHA256);
            this.Controls.Add(this.labelSHA1);
            this.Controls.Add(this.labelMD5);
            this.Controls.Add(this.labelOutputHash);
            this.Controls.Add(this.labelTitleStringToHash);
            this.Controls.Add(this.textBoxInputString);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Aleks\' hash tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputString;
        private System.Windows.Forms.Label labelTitleStringToHash;
        private System.Windows.Forms.Label labelOutputHash;
        private System.Windows.Forms.Label labelMD5;
        private System.Windows.Forms.Label labelSHA1;
        private System.Windows.Forms.Label labelSHA256;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.TextBox textBoxSHA1;
        private System.Windows.Forms.TextBox textBoxSHA256;
        private System.Windows.Forms.Button buttonGenerateStringHashes;
        private System.Windows.Forms.Label labelTitleCompareFileToHash;
        private System.Windows.Forms.Label labelChooseFile;
        private System.Windows.Forms.Label labelPasteGivenHash;
        private System.Windows.Forms.Label labelTitleFileToHash;
        private System.Windows.Forms.TextBox textBoxGivenHash;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUploadFile;
        private System.Windows.Forms.Button buttonOpenFileHash;
        private System.Windows.Forms.Button buttonGenerateFileHashes;
        private System.Windows.Forms.Button buttonOpenFileCompare;
        private System.Windows.Forms.Button buttonClearString;
        private System.Windows.Forms.Button buttonClearFile;
        private System.Windows.Forms.Button buttonClearCompFile;
        private System.Windows.Forms.Button buttonClearCompHash;
        private System.Windows.Forms.Button buttonSaveTextHashes;
        private System.Windows.Forms.Button buttonSaveFileHashes;
        private System.Windows.Forms.RadioButton radioButtonlow;
        private System.Windows.Forms.RadioButton radioButtonhigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSHA512;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCheck;
        protected System.Windows.Forms.ComboBox comboBoxChooseMethod;
    }
}

