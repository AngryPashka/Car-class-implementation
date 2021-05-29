using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РеализацияКлассаАвтомобиля
{
	public partial class Form1 : Form
	{
		readonly Автомобиль автомобиль = new Автомобиль();
		readonly Music music = new Music();
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			timer2.Start();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (автомобиль.ЗажатГаз || textBoxSpeed.Text != "0")
				music.ЗвукПедалиГаза();
			else
			{
				if (автомобиль.ЗажатоСцепление || автомобиль.ЗажатТормоз && автомобиль.ЗажатоСцепление)
					music.ЗвукРаботы();
				else
				{
					music.ЗвукГлушения();
					timer1.Stop();
					buttonStart.FlatAppearance.BorderColor = Color.Red;
				}
			}
			
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			автомобиль.ЗажатоСцепление = e.KeyCode != Keys.C && автомобиль.ЗажатоСцепление;
			автомобиль.ЗажатГаз = e.KeyCode != Keys.W && автомобиль.ЗажатГаз;
			автомобиль.ЗажатТормоз = e.KeyCode != Keys.S && автомобиль.ЗажатТормоз;
			button0.FlatAppearance.BorderColor = автомобиль.ЗажатоСцепление ? Color.Red : Color.White;
			button1.FlatAppearance.BorderColor = автомобиль.ЗажатТормоз ? Color.Red : Color.White;
			button2.FlatAppearance.BorderColor = автомобиль.ЗажатГаз ? Color.Red : Color.White;
			if (e.KeyCode == Keys.V)
				ButtonStart_Click(null, null);
			if (e.KeyCode == Keys.E)
				Button3_Click(null, null);
			if (e.KeyCode == Keys.Q)
				Button4_Click(null, null);
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			if(автомобиль.ЗажатГаз) progressBar1.Value += progressBar1.Value < 100 ? 5 : 0;
			if(автомобиль.ЗажатТормоз) progressBar1.Value -= progressBar1.Value > 10 ? 10 : progressBar1.Value;
			if (автомобиль.ЗажатТормоз && !автомобиль.ЗажатоСцепление) progressBar1.Value = 0;
			textBoxSpeed.Text = автомобиль.ТекущаяСкорость(double.Parse(textBoxSpeed.Text),  progressBar1.Value).ToString("0");
			label2.Text = progressBar1.Value.ToString();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			автомобиль.ЗажатоСцепление = автомобиль.ЗажатоСцепление || e.KeyCode == Keys.C;
			автомобиль.ЗажатГаз = автомобиль.ЗажатГаз || e.KeyCode == Keys.W;
			автомобиль.ЗажатТормоз = автомобиль.ЗажатТормоз || e.KeyCode == Keys.S;
			button0.FlatAppearance.BorderColor = автомобиль.ЗажатоСцепление ? Color.Red : Color.White;
			button1.FlatAppearance.BorderColor = автомобиль.ЗажатТормоз ? Color.Red : Color.White;
			button2.FlatAppearance.BorderColor = автомобиль.ЗажатГаз ? Color.Red : Color.White;
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			автомобиль.ЗапускДвигателя();
			if (автомобиль.ДвигательЗапущен)
			{
				timer1.Start();
				music.ЗвукЗапуска();
				buttonStart.FlatAppearance.BorderColor = Color.Green;
			}
			else
			{
				timer1.Stop();
				music.ЗвукГлушения();
				buttonStart.FlatAppearance.BorderColor = Color.Red;
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (автомобиль.ЗажатоСцепление)
			{
				progressBar1.Value -= progressBar1.Value > 30 && labelType.Text != "5" ? 30 : 0;
				labelType.Text = автомобиль.ПовыситьПередачу().ToString();
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (автомобиль.ЗажатоСцепление)
			{
				progressBar1.Value += progressBar1.Value < 70 && labelType.Text != "1" ? 30 : 0;
				textBoxSpeed.Text = (double.Parse(textBoxSpeed.Text) > 10 ?
					double.Parse(textBoxSpeed.Text) - 10 : 0).ToString("0");
				labelType.Text = автомобиль.ПонизитьПередачу().ToString();
			}
		}
	}
}
