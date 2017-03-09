using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom1
{
    public class SteganoTxt
    {


        public List<string> StartTxt = new List<string>(); //список строк исходного текста
        public List<int> NumberOFWords = new List<int>(); 
        public List<string> StartWords = new List<string>();  //список слов исход. текста
        public List<string> ModTxt = new List<string>();
        public List<string> ModWords = new List<string>();  //список слов текста, который будем кодировать
        public List<string> CodBits = new List<string>();  //список битов символов для кодировки
        public List<string> RezultList = new List<string>(); //результирующий список слов с дописанными пробелами
        public List<string> RezultListTxt = new List<string>(); //результирующий список предложений


        #region функция нормализации и разбора данных
        private void Normalization(ref List<string> x, ref List<string> y, bool start) 
        {
            for (int i = 0; i < x.Count; i++)
            {
                int k = 0;
                string[] value = x.ElementAt(i).Split(' ');
                for (int j = 0; j < value.Length; j++)
                {
                    if ((value[j] != null) && (value[j] != "")) { y.Add(value[j].Trim()); k++; }
                    
                }
                if (start) NumberOFWords.Add(k);
            }

        }

        #endregion

        private string ConvertChar(char ch)
        {
            string Rezult = "";
            int Code = (int)ch;
            Rezult = Convert.ToString(Code, 2);
            int n = Rezult.Length;
            for (int i = 0; i < 16 - n; i++)
            {
                Rezult = Rezult.Insert(0, "0");
            }
            return Rezult;
        }
        private void CreateBinaryList() 
        {
            for (int i = 0; i < ModWords.Count; i++)
			{
			 
                string temp = ModWords.ElementAt(i);
                for (int j = 0; j < temp.Length; j++)
			    {
                    CodBits.Add(ConvertChar(temp[j]));
			    }   
            }

        }

        #region функция закладки текста в контейнер

        private bool Proverka() //проверяет возможность закладки по размеру
        {
            bool rezult = false;
            if ((ModWords.Count * 16) < StartWords.Count) rezult = true;
            return rezult;
        }

        private void SetTxtByTxt()
        {
            if (!Proverka()) { MessageBox.Show("Закладка в контейнер не возможна", "Внимание!", MessageBoxButtons.OK);  return; }
            RezultList.Clear();
            RezultList = StartWords; 
            int k = 0;
            for (int i = 0; i < CodBits.Count; i++)
            {
                string BitElem = CodBits.ElementAt(i);
                for (int j = 0; j < BitElem.Length; j++)
                {
                   // string str = StartWords.ElementAt(k);
                    if (BitElem[j] == '1') { RezultList[k] += " "; }
                    k++;
                }
            }

            int index = 0;
            for (int l = 0; l < NumberOFWords.Count; l++)
            {
                index += NumberOFWords.ElementAt(l);
                RezultList[index-1] += "\n";
            }


            RezultListTxt.Clear();
                string temp = "";
            for (int i = 0; i < RezultList.Count; i++)
            {
                if (RezultList.ElementAt(i).IndexOf("\n") > 0) { temp += RezultList.ElementAt(i).Substring(0, RezultList.ElementAt(i).Length-1); RezultListTxt.Add(temp); temp = ""; }
                else { temp += RezultList.ElementAt(i)+" "; }
            }
           
        }



        #endregion



        public void SteganoTxtByTxt() 
        {
          
            
            Normalization(ref  StartTxt, ref  StartWords, true);



            Normalization(ref  ModTxt, ref  ModWords, false);
            CreateBinaryList();
               SetTxtByTxt();
        }

        #region изьятие текста из текста

        public List<string> SteganoTxtFromTxt()
        {
            string result = "";
            for (int i = 0; i < StartTxt.Count; i++)
            {
                string[] val = StartTxt.ElementAt(i).Split(' ' );
                for (int j = 0; j < val.Length; j++)
                {
                    if (val[j] != "") result += "0";
                    else { result = result.Substring(0, result.Length-1) + "1"; }
                }

               
            }
            int indexStart = 0;
            CodBits.Clear();
            for (int i = 0; i < result.Length-16; i++)
            {
                string t = result.Substring(indexStart,16);
                if (t == "0000000000000000") break;
                CodBits.Add(t);
                indexStart += 16;
            }

            List<string> z = ConvertBinaryListByText();
            return z;
        }

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
            return z;

        }


        List<string> ConvertBinaryListByText()
        {
            string rezult = "";
            List<string> RezList = new List<string>();
            for (int i = 0; i < CodBits.Count; i++)
            {
                char t = ConvertBinaryCodeByChar(CodBits[i]);
                if (t == '\0') break;
                if ((t == '\n')||(t == ' ')) { RezList.Add(rezult); rezult = ""; }
                else { rezult += t; }
            }

            return RezList;
        }

        #endregion


    }
}
