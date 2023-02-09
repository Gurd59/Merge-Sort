using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge_Sort
{
    public partial class Form1 : Form
    {

        public int[] pole;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static void merge(int[] list, int[] left, int[] right)
        {
            int i = 0;
            int j = 0;

            while ((i< left.Length) && (j < right.Length))
            {
                if (left[i] < right[j])
                {
                    list[i + j] = left[i];
                    i++;
                }
                else
                {
                    list[i + j] = right[j];
                    j++;
                }
            }

            if (i < left.Length)
            {
                while (i < left.Length)
                {
                    list[i + j] = left[i];
                    i++;
                }
            }
            else
            {
                while (j < right.Length)
                {
                    list[i + j] = right[j];
                    j++;
                }
            }
        }

        public static void merge_sort(int[] list)
        {
            if (list.Length <= 1)
                return;
            int center = list.Length / 2;
            int[] left = new int[center];
            for (int i = 0; i < center; i++)
                left[i] = list[i];
            int[] right = new int[list.Length - center];
            for (int i = center; i < list.Length; i++)
                right[i - center] = list[i];
            merge_sort(left);
            merge_sort(right);
            merge(list, left, right);
        }
         


        private void Merge_Click(object sender, EventArgs e)
        {
            merge_sort(pole);
            txt_vystup.Text += Environment.NewLine + "Merge Sort: " + Environment.NewLine;
            for (int i = 0; i < pole.Length; i++)
            {
                txt_vystup.Text += Convert.ToString(pole[i]) + ", ";
            }
        }

        private void btn_generuj_Click(object sender, EventArgs e)
        {
            pole = new int[(int)nmr_random.Value];
            Random nc = new Random();

            txt_vystup.Text = "";
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = nc.Next(0, 30);
                txt_vystup.Text += Convert.ToString(pole[i]) + ", ";
            }

        }
    }
}
