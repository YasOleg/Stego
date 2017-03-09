namespace Diplom1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tс = new System.Windows.Forms.TabControl();
            this.tpGraphics = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSearchText = new System.Windows.Forms.Button();
            this.btnDeShifrov = new System.Windows.Forms.Button();
            this.btnShifrov = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBoxIzobr = new System.Windows.Forms.PictureBox();
            this.tpText = new System.Windows.Forms.TabPage();
            this.btnDeshifrTxt = new System.Windows.Forms.Button();
            this.btnShifrTxt = new System.Windows.Forms.Button();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnSartTxt = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialogIso = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tс.SuspendLayout();
            this.tpGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzobr)).BeginInit();
            this.tpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tс
            // 
            this.tс.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tс.Controls.Add(this.tpGraphics);
            this.tс.Controls.Add(this.tpText);
            this.tс.Location = new System.Drawing.Point(12, 12);
            this.tс.Name = "tс";
            this.tс.SelectedIndex = 0;
            this.tс.Size = new System.Drawing.Size(1291, 566);
            this.tс.TabIndex = 0;
            // 
            // tpGraphics
            // 
            this.tpGraphics.BackColor = System.Drawing.Color.Gray;
            this.tpGraphics.Controls.Add(this.listBox2);
            this.tpGraphics.Controls.Add(this.btnSearchText);
            this.tpGraphics.Controls.Add(this.btnDeShifrov);
            this.tpGraphics.Controls.Add(this.btnShifrov);
            this.tpGraphics.Controls.Add(this.btnSearch);
            this.tpGraphics.Controls.Add(this.pictureBoxIzobr);
            this.tpGraphics.Location = new System.Drawing.Point(4, 22);
            this.tpGraphics.Name = "tpGraphics";
            this.tpGraphics.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraphics.Size = new System.Drawing.Size(1283, 540);
            this.tpGraphics.TabIndex = 0;
            this.tpGraphics.Text = "Графика";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(912, 85);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(294, 394);
            this.listBox2.TabIndex = 8;
            // 
            // btnSearchText
            // 
            this.btnSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchText.Location = new System.Drawing.Point(1084, 491);
            this.btnSearchText.Name = "btnSearchText";
            this.btnSearchText.Size = new System.Drawing.Size(122, 42);
            this.btnSearchText.TabIndex = 7;
            this.btnSearchText.Text = "Загрузить";
            this.btnSearchText.UseVisualStyleBackColor = true;
            this.btnSearchText.Click += new System.EventHandler(this.btnSearchText_Click);
            // 
            // btnDeShifrov
            // 
            this.btnDeShifrov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeShifrov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeShifrov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeShifrov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeShifrov.Location = new System.Drawing.Point(1084, 28);
            this.btnDeShifrov.Name = "btnDeShifrov";
            this.btnDeShifrov.Size = new System.Drawing.Size(122, 42);
            this.btnDeShifrov.TabIndex = 4;
            this.btnDeShifrov.Text = "Дешифрование";
            this.btnDeShifrov.UseVisualStyleBackColor = true;
            this.btnDeShifrov.Click += new System.EventHandler(this.btnDeShifrov_Click);
            // 
            // btnShifrov
            // 
            this.btnShifrov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShifrov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShifrov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShifrov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShifrov.Location = new System.Drawing.Point(912, 28);
            this.btnShifrov.Name = "btnShifrov";
            this.btnShifrov.Size = new System.Drawing.Size(122, 42);
            this.btnShifrov.TabIndex = 3;
            this.btnShifrov.Text = "Шифрование";
            this.btnShifrov.UseVisualStyleBackColor = true;
            this.btnShifrov.Click += new System.EventHandler(this.btnShifrov_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(706, 491);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 42);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Обзор";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBoxIzobr
            // 
            this.pictureBoxIzobr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxIzobr.BackColor = System.Drawing.Color.White;
            this.pictureBoxIzobr.Location = new System.Drawing.Point(23, 6);
            this.pictureBoxIzobr.Name = "pictureBoxIzobr";
            this.pictureBoxIzobr.Size = new System.Drawing.Size(805, 479);
            this.pictureBoxIzobr.TabIndex = 0;
            this.pictureBoxIzobr.TabStop = false;
            // 
            // tpText
            // 
            this.tpText.BackColor = System.Drawing.Color.Gray;
            this.tpText.Controls.Add(this.btnDeshifrTxt);
            this.tpText.Controls.Add(this.btnShifrTxt);
            this.tpText.Controls.Add(this.btnTxt);
            this.tpText.Controls.Add(this.btnSartTxt);
            this.tpText.Controls.Add(this.listBox3);
            this.tpText.Controls.Add(this.listBox1);
            this.tpText.Location = new System.Drawing.Point(4, 22);
            this.tpText.Name = "tpText";
            this.tpText.Padding = new System.Windows.Forms.Padding(3);
            this.tpText.Size = new System.Drawing.Size(1283, 540);
            this.tpText.TabIndex = 1;
            this.tpText.Text = "Tекст";
            this.tpText.Click += new System.EventHandler(this.tpText_Click);
            // 
            // btnDeshifrTxt
            // 
            this.btnDeshifrTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshifrTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeshifrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeshifrTxt.Location = new System.Drawing.Point(1070, 38);
            this.btnDeshifrTxt.Name = "btnDeshifrTxt";
            this.btnDeshifrTxt.Size = new System.Drawing.Size(120, 37);
            this.btnDeshifrTxt.TabIndex = 14;
            this.btnDeshifrTxt.Text = "Дешифрование";
            this.btnDeshifrTxt.UseVisualStyleBackColor = true;
            this.btnDeshifrTxt.Click += new System.EventHandler(this.btnDeshifrTxt_Click);
            // 
            // btnShifrTxt
            // 
            this.btnShifrTxt.BackColor = System.Drawing.Color.Gray;
            this.btnShifrTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShifrTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShifrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShifrTxt.Location = new System.Drawing.Point(896, 38);
            this.btnShifrTxt.Name = "btnShifrTxt";
            this.btnShifrTxt.Size = new System.Drawing.Size(120, 37);
            this.btnShifrTxt.TabIndex = 13;
            this.btnShifrTxt.Text = "Шифрование";
            this.btnShifrTxt.UseVisualStyleBackColor = false;
            this.btnShifrTxt.Click += new System.EventHandler(this.btnShifrTxt_Click);
            // 
            // btnTxt
            // 
            this.btnTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTxt.Location = new System.Drawing.Point(1070, 477);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(120, 37);
            this.btnTxt.TabIndex = 12;
            this.btnTxt.Text = "Обзор";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnSartTxt
            // 
            this.btnSartTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSartTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSartTxt.Location = new System.Drawing.Point(670, 477);
            this.btnSartTxt.Name = "btnSartTxt";
            this.btnSartTxt.Size = new System.Drawing.Size(120, 37);
            this.btnSartTxt.TabIndex = 11;
            this.btnSartTxt.Text = "Загрузить";
            this.btnSartTxt.UseVisualStyleBackColor = true;
            this.btnSartTxt.Click += new System.EventHandler(this.btnSartTxt_Click);
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(896, 90);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(294, 381);
            this.listBox3.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(725, 433);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialogIso
            // 
            this.openFileDialogIso.DefaultExt = "bmp";
            this.openFileDialogIso.FileName = "openFileDialog1";
            this.openFileDialogIso.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogIso_FileOk);
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 592);
            this.Controls.Add(this.tс);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SteganoGraff";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tс.ResumeLayout(false);
            this.tpGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIzobr)).EndInit();
            this.tpText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tс;
        private System.Windows.Forms.TabPage tpGraphics;
        private System.Windows.Forms.TabPage tpText;
        private System.Windows.Forms.Button btnSearchText;
        private System.Windows.Forms.Button btnDeShifrov;
        private System.Windows.Forms.Button btnShifrov;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBoxIzobr;
        private System.Windows.Forms.OpenFileDialog openFileDialogIso;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnDeshifrTxt;
        private System.Windows.Forms.Button btnShifrTxt;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnSartTxt;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

