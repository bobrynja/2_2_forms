using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                try
                {
                    int m = Convert.ToInt32(textBox1.Text);
                    if (m < 0) MessageBox.Show("Кол-во месяцев не может быть отрицательным");
                    else
                    {
                        int localDate = Convert.ToInt32(DateTime.Now.ToString("MM"));
                        while (m >= 12)
                        {
                            m -= 12;
                        }
                        int date = localDate - m;
                        switch (date)
                        {
                            case 1:
                                textBox2.Text="Январь";
                                break;
                            case 2:
                                textBox2.Text="Февраль";
                                break;
                            case 3:
                                textBox2.Text="Март";
                                break;
                            case 4:
                                textBox2.Text="Апрель";
                                break;
                            case 5:
                                textBox2.Text="Май";
                                break;
                            case 6:
                                textBox2.Text="Июнь";
                                break;
                            case 7:
                                textBox2.Text="Июль";
                                break;
                            case 8:
                                textBox2.Text="Август";
                                break;
                            case 9:
                                textBox2.Text="Сентябрь";
                                break;
                            case 10:
                                textBox2.Text="Октябрь";
                                break;
                            case 11:
                                textBox2.Text="Ноябрь";
                                break;
                            case 12:
                                textBox2.Text="Декабрь";
                                break;
                        }
                    }
                }
                catch { MessageBox.Show("Некорректный ввод данных"); }




            }
        }
    }
