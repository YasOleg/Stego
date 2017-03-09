using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom1
{
  public  class ClassSteganoGraphia
    {
         public List<string> StartText = new List<string>();
         public List<string> StopText = new List<string>(); // бинарный код каждого символа, приведенный к 16 битам
         public Image StartImg; // стартовый контейнер
         //public Image StopImg;

     #region общие функции класса
                 public void SetStartImg(  Control x) 
                 {
                     StartImg = ((PictureBox)x).Image;
                 }
         #endregion
       
     #region код закладки текста в картинку
         public void SetTxtToImg()
         {
             string str = "";
             for (int i = 0; i < StopText.Count; i++)
             {
                 str += StopText.ElementAt(i);
             }
             int MaxCount = StartImg.Width * StartImg.Height;
             if (MaxCount < str.Length) 
             {
                 MessageBox.Show("Выбранный контейнер мал для встраивания данного текста", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             Bitmap bm = new Bitmap(StartImg);
             int indexChar = 0; 
             for (int i = 0; i < bm.Width; i++)
             {
                 for (int j = 0; j < bm.Height; j++)
                 {
                     if (indexChar < str.Length - 1)
                     {
                         Color temp = bm.GetPixel(i, j);
                         if (str[indexChar] == '1'){ 
                             Color x = Color.FromArgb(254, temp.R, temp.G, temp.B);

                             bm.SetPixel(i, j, x);}
                         indexChar++;
                     }
                      
                     

                 }
             }

             SaveFileDialog sa = new SaveFileDialog();
             sa.DefaultExt = "bmp";
             if (sa.ShowDialog() == DialogResult.OK)
             {


                 bm.Save(sa.FileName);
             }



         }

         public void SetStrartText(List<string> _StartText) 
         {
             for (int i = 0; i < _StartText.Count; i++)
             {
                 StartText.Add(_StartText.ElementAt(i)+'\n');
             }
         }


         private string ConvertChar(char ch) 
         {
             string Rezult = "";
             int Code = (int)ch;
             Rezult = Convert.ToString(Code, 2);
             int n = Rezult.Length;
             for (int i = 0; i < 16 - n; i++)
			    {
			        Rezult  =  Rezult.Insert (0,"0");
			    }
             return Rezult;
         }
         private void ConvertString(string str) 
         {
             for (int i = 0; i < str.Length; i++)
             {
                 StopText.Add(ConvertChar(str[i]));
             }
         }

         public void ConvertTxt() 
         {
             for (int i = 0; i < StartText.Count; i++)
             {
                 ConvertString(StartText.ElementAt(i)); 
             }
         }
         # endregion

     #region код извлечения теста из картинки

         char ConvertBinaryCodeByChar(string Code)
         {
             int[] mas = { 0, 17384, 8192, 4096, 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
           //  int [] mas = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 17384, 0};
             int x = 0;

             for (int i = 0; i < Code.Length; i++)
             {
                 int temp = 0;
                 if (Code[i] == '1') temp = 1;
                 
                 x += mas[i] * temp; 
             }
             char z = (char)x;
             return z ;
         
         }


      List<string> ConvertBinaryListByText()
         {
             string rezult = "";
          List<string> RezList = new List<string>();
             for (int i = 0; i < StopText.Count; i++)
             {
                 char t = ConvertBinaryCodeByChar(StopText[i]);
                 if ( t == '\0') break;
                 if (t == '\n') {RezList.Add(rezult); rezult = "";}
                 else { rezult += t; }
             }

             return RezList;
         }



         public List <string> GetTxtFromImg() 
         {
             StartText.Clear();
             StopText.Clear();

             Bitmap bm = new Bitmap(StartImg);
             string tempstr = "";
             string tempchar = "";
           
             for (int i = 0; i < bm.Width; i++)
             {
                 for (int j = 0; j < bm.Height; j++)
                 {
                   
                     Color temp = bm.GetPixel(i, j);
                     if (temp.A == 254) tempchar = "1";
                     else tempchar = "0";
                     if (tempstr.Length < 16) 
                     {
                        tempstr += tempchar;
                     }
                     else
                     {
                        StopText.Add(tempstr);
                        tempstr = "";
                        tempstr += tempchar;
                     }

                    
                 }
             }
          List<string> z = ConvertBinaryListByText();
          return z;
        }
#endregion   
 }  
}
