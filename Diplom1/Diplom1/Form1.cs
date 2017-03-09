using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region работа с графикой
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialogIso.ShowDialog() == DialogResult.OK)
            {
                pictureBoxIzobr.Image = Image.FromFile(openFileDialogIso.FileName);
            }
        }

        private void openFileDialogIso_FileOk(object sender, CancelEventArgs e)
        {

        }

        List<string> listStr = new List<string>();
        private void btnSearchText_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            
            if (openFileDialogText.ShowDialog() == DialogResult.OK) 
            {
                StreamReader file_text = new StreamReader(openFileDialogText.FileName);
                string str;

                do
                {
                    str = file_text.ReadLine();
                    if (str != null) listStr.Add(str);
                } while (str != null);
                file_text.Close();
              
                for (int i = 0; i < listStr.Count; i++)
                {
                   listBox2.Items.Add( listStr[i]);
                }
            }
        }

        private void btnShifrov_Click(object sender, EventArgs e)
        {
            try
            {
                ClassSteganoGraphia Stegan = new ClassSteganoGraphia();
                Stegan.SetStrartText(listStr);
                Stegan.ConvertTxt();
                Stegan.SetStartImg(pictureBoxIzobr);
                Stegan.SetTxtToImg();
            }
            catch { MessageBox.Show("Один из компонентов не заплнен, заполните все окна!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ShowRezDishifr(ref List<string> RezList) 
        {

            listBox2.Items.Clear();
            for (int i = 0; i < RezList.Count; i++)
            {
                listBox2.Items.Add(RezList[i]);
            }
        }


        private void btnDeShifrov_Click(object sender, EventArgs e)
        {
            try{
                ClassSteganoGraphia Stegan = new ClassSteganoGraphia();
                Stegan.SetStartImg(pictureBoxIzobr);
                List<string> RezList = Stegan.GetTxtFromImg();
                ShowRezDishifr(ref  RezList);
            }
            catch { MessageBox.Show("Один из компонентов не заплнен, заполните все окна!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
        }
        #endregion


        #region работа с текстом

        SteganoTxt StgTxt = new SteganoTxt();
        #region загрузка текста контейнера
        private void btnSartTxt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StgTxt.StartTxt.Clear();

            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                StreamReader file_text = new StreamReader(openFileDialogText.FileName);
                string str;

                do
                {
                    str = file_text.ReadLine();
                    if (str != null) { StgTxt.StartTxt.Add(str); listBox1.Items.Add(str); }
                } while (str != null);
                file_text.Close();
            
            }
        }
        #endregion

        private void btnTxt_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                StreamReader file_text = new StreamReader(openFileDialogText.FileName);
                string str;

                do
                {   str = file_text.ReadLine();
                    if (str != null) { StgTxt.ModWords.Add(str + " "); listBox3.Items.Add(str); }
                } while (str != null);
                file_text.Close();
                }
        }

        

        #endregion

        private void btnShifrTxt_Click(object sender, EventArgs e)
        {
            try
            {
                StgTxt.SteganoTxtByTxt();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                    for (int i = 0; i < StgTxt.RezultListTxt.Count; i++)
                    {
                        file.WriteLine(StgTxt.RezultListTxt.ElementAt(i));
                    }

                    file.Close();
                }
            }
            catch { MessageBox.Show("Один из компонентов не заплнен, заполните все окна!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void tpText_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshifrTxt_Click(object sender, EventArgs e)
        {
            try{
                List<string> listResult = StgTxt.SteganoTxtFromTxt();
                if (listResult.Count > 0)
                {
                    listBox3.Items.Clear();
                    foreach (string s in listResult)
                    {
                        listBox3.Items.Add(s);
                    }
                }
            }catch { MessageBox.Show("Один из компонентов не заплнен, заполните все окна!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
