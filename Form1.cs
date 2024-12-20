using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Lab2_Wizhener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя ";
        private void KeyPress_CryptTextBox(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 1040 && e.KeyChar <= 1103) && e.KeyChar != 8 && e.KeyChar != 32 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void Encode(object sender, EventArgs e)
        {
            int keyindex = 0;
            if (textBox_DecryptText.Text.Length != 0 && textBox_Key.Text.Length != 0)
                foreach (char symbol in textBox_DecryptText.Text)
                {
                    textBox_EncryptText.Text += alphabet[(alphabet.IndexOf(symbol) + alphabet.IndexOf(textBox_Key.Text[keyindex])) % alphabet.Length];
                    keyindex = (keyindex + 1) % textBox_Key.Text.Length;
                }
            else MessageBox.Show("Ошибка!",null,MessageBoxButtons.OK);
        }
        private void Decode(object sender, EventArgs e)
        {
            int keyindex = 0;
            if (textBox_EncryptText.Text.Length != 0 && textBox_Key.Text.Length != 0)
                foreach (char symbol in textBox_EncryptText.Text)
                {
                    textBox_DecryptText.Text += alphabet[(alphabet.IndexOf(symbol) +alphabet.Length- alphabet.IndexOf(textBox_Key.Text[keyindex])) % alphabet.Length];
                    keyindex = (keyindex + 1) % textBox_Key.Text.Length;
                }
            else MessageBox.Show("Ошибка!", null, MessageBoxButtons.OK);
        }
        void Open()
        {
            string x = textBox_EncryptText.Text; 
            int maxKeyLength = 10;
            double [] indexOfCoincidence = new double[maxKeyLength];
            // Вычисляем индексы совпадения для разных длин ключа
            for (int k = 0; k < maxKeyLength; k++)
            {
                indexOfCoincidence[k] = CalculateIndexOfCoincidenceForKeyLength(x, k+1);
                Console.WriteLine($"Длина ключа {k+1}: Индекс совпадения = {indexOfCoincidence[k]:F4}");
            }
        

            double CalculateIndexOfCoincidenceForKeyLength(string text, int keyLength)
            {
                // Группы для символов (по остатку от деления на длину ключа)
                List<string> groups = new List<string>();

                // Инициализируем группы
                for (int i = 0; i < keyLength; i++)
                {
                    groups.Add("");
                }

                // Разбиваем строку на группы
                for (int i = 0; i < text.Length; i++)
                {
                    groups[i % keyLength] += text[i];
                }

                // Вычисляем средний индекс совпадения по всем группам
                double totalIndexOfCoincidence = 0;

                foreach (var group in groups)
                {
                     totalIndexOfCoincidence += CalculateIndexOfCoincidence(group);
                }

                 return totalIndexOfCoincidence / keyLength;
            }

            double CalculateIndexOfCoincidence(string text)
            {
                int n = text.Length;
                if (n < 2) return 0;

                // Подсчет частот символов
                Dictionary<char, int> frequency = new Dictionary<char, int>();
                foreach (var c in text)
                {
                    if (frequency.ContainsKey(c))
                        frequency[c]++;
                    else
                        frequency[c] = 1;
                }

                // Вычисляем индекс совпадения
                double index = 0;
                foreach (var freq in frequency.Values)
                {
                    index += freq * (freq - 1);
                }

                return index / (n * (n - 1));
            }
            int keylenght = Array.IndexOf(indexOfCoincidence, indexOfCoincidence.Max());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open();
        }

    }   
}


   
