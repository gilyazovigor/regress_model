using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace regress_model
{
    public partial class Form1 : Form
    {
        string path = "";
        //const int YEARS = 10;
        const int TERRITORIES = 77;
        const int MANAGED_FACTORS = 17;
        //const int MANAGER_FACTORS = 1;

        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        //X - управляющие факторы (managed_parameters)
        double[,] X = new double[TERRITORIES + 1, MANAGED_FACTORS + 1];

        //Y - управляемый фактор (manager_parameter)
        double[] Y = new double[TERRITORIES + 1];

        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_xlsx_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите excel-файл";
            ofd.Filter = "Excel Files|*.xls;*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;

                try
                {
                    pictureBox_load.Visible = true;
                    wb = excel.Workbooks.Open(path);
                    ws = wb.Worksheets[1];

                    //управляемые факторы
                    for (int i = 0; i < TERRITORIES; i++)
                        for (int j = 0; j < MANAGED_FACTORS; j++) 
                        {
                            X[i, j] = ws.Cells[i + 2, j + 3].Value2;
                        }

                    //управляющий фактор
                    for (int i = 0; i < TERRITORIES; i++)
                    {
                        //20 - номер столбца, содержащий управляющий фактор
                        Y[i] = ws.Cells[i + 2, 20].Value2;
                    }

                    //текст в листБоксы
                    for (int i = 0; i < MANAGED_FACTORS; i++)
                    {
                        listBox_all_parameters.Items.Insert(i, ws.Cells[1, i + 3].Value2);
                        //только в проге 3 курса, на 4 курсе это надо убрать и сделать по-нормальному
                        listBox_managed.Items.Insert(i, ws.Cells[1, i + 3].Value2);
                    }
                    //20 - номер столбца, содержащий управляющий фактор
                    listBox_managers.Items.Insert(0, ws.Cells[1, 20].Value2);
                    
                    wb.Close();

                    pictureBox_load.Visible = false;
                    MessageBox.Show("Данные загружены!");
                    //активация кнопки
                    //button_tab1_to_tab2.Enabled = true;

                }
                catch
                {
                    MessageBox.Show("Некорректные входные данные!");
                }
                
                
            }
            else return;

    
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Выберите excel-файл");
                return;
            }
            tabControl1.SelectedIndex = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_tab2_to_tab3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            //этап 1 - детальный анализ взаимосвязей всех управляющих факторов(Х)
            //с использованием коэффициента парных корреляций Пирсона
            //def l k
            double chislitel, znamenatel, znamenatel_sumJ, znamenatel_sumI;
            double Xi_;//среднее по строке в матрице у Первого из сравниваемых факторов
            double Xj_;//среднее по строке в матрице у Второго из сравниваемых факторов
            double[,] rX = new double[MANAGED_FACTORS, MANAGED_FACTORS];

            for (int i = 0; i < MANAGED_FACTORS; i++)
                for (int j = i; j < MANAGED_FACTORS; j++)
                {
                    chislitel = 0;
                    znamenatel = 0;
                    znamenatel_sumJ = 0;
                    znamenatel_sumI = 0;
                    Xi_ = 0;
                    Xj_ = 0;

                    for (int k = 0; k < MANAGED_FACTORS; k++)
                    {
                        Xi_ += X[i, k];
                        Xj_ += X[j, k];
                    }
                    Xi_ /= MANAGED_FACTORS;
                    Xj_ /= MANAGED_FACTORS;

                    //числитель
                    for (int k = 0; k < MANAGED_FACTORS; k++)
                        chislitel += (X[k, j] - Xj_) * (X[k, i] - Xi_);
                    //знаменатель
                    for (int k = 0; k < MANAGED_FACTORS; k++)
                    {
                        znamenatel_sumJ = (X[k, j] - Xj_) * (X[k, j] - Xj_);
                        znamenatel_sumI = (X[k, i] - Xi_) * (X[k, i] - Xi_);
                    }
                    znamenatel = Math.Sqrt(znamenatel_sumJ * znamenatel_sumI);


                    rX[i, j] = chislitel / znamenatel;
                    rX[j, i] = chislitel / znamenatel;

                }


            //этап 2


        }
    }
}
