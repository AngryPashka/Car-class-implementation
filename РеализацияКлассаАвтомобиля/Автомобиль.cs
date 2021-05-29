using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace РеализацияКлассаАвтомобиля
{
	class Music
	{
		public Music() { }

		public void ЗвукПедалиГаза()
		{
			System.Media.SoundPlayer Cl = new System.Media.SoundPlayer(Properties.Resources.Газ);
			Cl.Load();
			Cl.Play();
		}
		public void ЗвукГлушения()
		{
			System.Media.SoundPlayer Cl = new System.Media.SoundPlayer(Properties.Resources.Глушение);
			Cl.Load();
			Cl.Play();
		}
		public void ЗвукЗапуска()
		{
			System.Media.SoundPlayer Cl = new System.Media.SoundPlayer(Properties.Resources.Звук_запуска);
			Cl.Load();
			Cl.Play();
		}
		public void ЗвукРаботы()
		{
			System.Media.SoundPlayer Cl = new System.Media.SoundPlayer(Properties.Resources.Работа_двигателя);
			Cl.Load();
			Cl.Play();
		}
	}
	class Автомобиль
	{
		public Автомобиль() 
		{
			ЗажатГаз = false;
			ЗажатоСцепление = false;
			ЗажатТормоз = false;
			ДвигательЗапущен = false;
			Передача = 1;
		}

		//Имитация салона автомобиля
		public bool ДвигательЗапущен { get; set; }
		public bool ЗажатоСцепление { get; set; }
		public bool ЗажатТормоз { get; set; }
		public bool ЗажатГаз { get; set; }

		private int Передача;


		//Имитация двигателя
		public double ТекущаяСкорость(double ТекущаяСкорость, double ТекущиеОбороты)
		{
			if (ЗажатТормоз && !ЗажатоСцепление) return 0;
			if (ЗажатТормоз && ЗажатоСцепление) return ТекущаяСкорость > 20 ? ТекущаяСкорость - 20 : 0;
			if (ЗажатоСцепление) return ТекущаяСкорость;
			if(ЗажатГаз)
					return ТекущаяСкорость + (ТекущиеОбороты < 100 ? ТекущиеОбороты * 0.06f 
					+ Передача / (Передача == 1 ? 100 : 50) : 0);
			return 0;
		}
		public void ЗапускДвигателя()
		{
			if (!ДвигательЗапущен)
				ДвигательЗапущен = ЗажатоСцепление;
			else
				ДвигательЗапущен = false;
		}

		public int ПовыситьПередачу()
		{
			Передача += Передача < 5 ? 1 : 0;
			return Передача;
		}

		public int ПонизитьПередачу()
		{
			Передача -= Передача > 1 ? 1 : 0;
			return Передача;
		}

	}
}
