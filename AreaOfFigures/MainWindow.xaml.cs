using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AreaOfFigures
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			TBA.Visibility = Visibility.Hidden;
			TBB.Visibility = Visibility.Hidden;
			TBC.Visibility = Visibility.Hidden;
			FormulaCB.IsEnabled = false;
		}

		List<string> listRect = new List<string>() { "по двум сторонам", "по диагоналям и синусу угла" };
		List<string> listPar = new List<string>() { "по стороне и высоте", "по двум сторонам и синусу угла",
			"по диагоналям и синусу угла" };
		List<string> listCircle = new List<string>() { "по радиусу", "по диаметру", "по длине окружности" +
			" и диаметру" };
		List<string> listTriangle = new List<string>() { "по стороне и высоте", "по двум сторонам и синусу угла",
		"по формуле Герона", "по стороне и синусам двух прилежащих углов"};
		List<string> listSquare = new List<string>() { "по стороне", "по диагоналям" };
		List<string> listRRect = new List<string>() { "по катетам", "по гипотенузе и синусу двойного угла"};
		List<string> listRhombus = new List<string>() { "по диагоналям", "по стороне и проведённой к ней высоте",
		"по стороне и сиинусу угла"};

		//прямоугольник
		string RectArea1(double a, double b)
		{
			return Convert.ToString(a * b);
		}

		string RectArea2(double d, double ang)
		{
			return Convert.ToString(0.5 * (d * d) * Math.Sin(ang));
		}

		//параллелограмм
		string ParArea1(double a, double h)
		{
			return Convert.ToString(a * h);
		}

		string ParArea2(double a, double b, double ang)
		{
			return Convert.ToString(a * b * Math.Sin(ang));
		}

		string ParArea3(double d1, double d2, double ang)
		{
			return Convert.ToString(0.5*(d1*d2)*Math.Sin(ang));
		}

		//круг
		string CircArea1(double r)
		{
			return Convert.ToString(Math.PI * Math.Pow(r, 2));
		}

		string CircArea2(double d)
		{
			return Convert.ToString(0.25*Math.PI*Math.Pow(d, 2));
		}

		string CircArea3(double c, double d)
		{
			return Convert.ToString(0.25*c*d);
		}

		//квадрат

		string SquareArea(double d)
		{
			return Convert.ToString((d * d) / 2);
		}

		//треугольник
		string TriangleArea1(double a, double h)
		{
			return Convert.ToString(0.5*a*h);
		}

		string TriangleArea2(double a, double b, double ang)
		{
			return Convert.ToString(0.5*a*b*Math.Sin(ang));
		}

		string HeronsFormula(double a, double b, double c)
		{
			double p = (a + b + c) / 2;
			return Convert.ToString(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
		}

		string TriangleArea4(double a, double ang1, double ang2)
		{
			return Convert.ToString(((a*a)/2)*((Math.Sin(ang1))/Math.Sin(180-(ang1+ang2))));
		}

		//прямоуг. треугольник
		string RTriangleArea1 (double a, double b)
		{
			return Convert.ToString(0.5 * a * b);
		}

		string RTriangleArea2 (double c, double ang)
		{
			return Convert.ToString((c*c*Math.Sin(2*ang))/4);
		}

		//ромб
		string RhombusArea1(double d1, double d2)
		{
			return Convert.ToString(0.5*d1*d2);
		}

		string RhombusArea2(double a, double ang)
		{
			return Convert.ToString(a*a*Math.Sin(ang));
		}

		//трапеция
		string TrapArea(double a, double b, double h)
		{
			return Convert.ToString(((a+b)/2)*h);
		}

		//эллипс
		string Ellipse(double a, double b)
		{
			return Convert.ToString(Math.PI * a * b);
		}

		private void FigureCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (FigureCB.SelectedIndex)
			{
				case 1:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listRect.Count; i++)
						FormulaCB.Items.Add(listRect[i]);

					
					
					break;

				case 2:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listCircle.Count; i++)
						FormulaCB.Items.Add(listCircle[i]);

					break;

				case 3:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listSquare.Count; i++)
						FormulaCB.Items.Add(listSquare[i]);

					break;

				case 4:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listRect.Count; i++)
						FormulaCB.Items.Add(listRect[i]);

					break;

				case 5:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listRRect.Count; i++)
						FormulaCB.Items.Add(listRRect[i]);

					break;

				case 6:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listPar.Count; i++)
						FormulaCB.Items.Add(listPar[i]);

					break;

				case 7:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					for (int i = 0; i < listRhombus.Count; i++)
						FormulaCB.Items.Add(listRhombus[i]);

					break;

				case 8:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					FormulaCB.Items.Add("по основаниям и высоте");

					break;

				case 9:
					L1.Content = "";
					L2.Content = "";
					L3.Content = "";
					TBA.Text = "";
					TBB.Text = "";
					TBC.Text = "";
					TBA.Visibility = Visibility.Hidden;
					TBB.Visibility = Visibility.Hidden;
					TBC.Visibility = Visibility.Hidden;

					FormulaCB.Items.Clear();
					FormulaCB.IsEnabled = true;
					FormulaCB.Items.Add("по полуосям");

					break;
			}
			

		}


		private void FormulaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (FigureCB.SelectedIndex)
			{
				case 1: //прямоугольник
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "d = ";
							L2.Content = "угол(°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 2: //круг
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "R = ";
							TBA.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "d = ";
							TBA.Visibility = Visibility.Visible;

							break;

						case 2:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "C = ";
							L2.Content = "d = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 3: //квадрат
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							TBA.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "d = ";
							TBA.Visibility = Visibility.Visible;

							break;

					}

					break;

				case 4: //треугольник
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "h = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							L3.Content = "угол(°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;

						case 2:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							L3.Content = "c = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;

						case 3:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "угол α(°) = ";
							L3.Content = "угол β(°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 5: //прямоуг. треугольник
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "c = ";
							L2.Content = "угол(°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 6: //параллелограмм
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "h = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							L3.Content = "угол (°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;

						case 2:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "d1 = ";
							L2.Content = "d2 = ";
							L3.Content = "угол (°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 7: //ромб
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "d1 = ";
							L2.Content = "d2 = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 1:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "h = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;

						case 2:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "угол (°) = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 8: //трапеция
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							L3.Content = "h = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;
							TBC.Visibility = Visibility.Visible;

							break;
					}

					break;

				case 9: //эллипс
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							L1.Content = "";
							L2.Content = "";
							L3.Content = "";
							TBA.Text = "";
							TBB.Text = "";
							TBC.Text = "";
							TBA.Visibility = Visibility.Hidden;
							TBB.Visibility = Visibility.Hidden;
							TBC.Visibility = Visibility.Hidden;
							L1.Content = "a = ";
							L2.Content = "b = ";
							TBA.Visibility = Visibility.Visible;
							TBB.Visibility = Visibility.Visible;

							break;
					}

					break;
			}
		}

		private void Butt_Click(object sender, RoutedEventArgs e)
		{
			switch (FigureCB.SelectedIndex)
			{
				case 1: //прямоугольник
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							LRes.Content = RectArea1(Convert.ToDouble(TBA.Text), Convert.ToDouble(TBB.Text));

							break;

						case 1:
							LRes.Content = RectArea2(Convert.ToDouble(TBA.Text), Convert.ToDouble(TBB.Text));

							break;
					}

					break;

				case 2: //круг
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							LRes.Content = CircArea1(Convert.ToDouble(TBA.Text));

							break;

						case 1:
							LRes.Content = CircArea2(Convert.ToDouble(TBA.Text));

							break;

						case 2:
							LRes.Content = CircArea3(Convert.ToDouble(TBA.Text), Convert.ToDouble(TBB.Text));

							break;				
					}

					break;

				case 3: //квадрат
					switch (FormulaCB.SelectedIndex)
					{
						case 0:
							LRes.Content = RectArea1(Convert.ToDouble(TBA.Text), Convert.ToDouble(TBA.Text));

							break;

						case 1:
							LRes.Content = SquareArea(Convert.ToDouble(TBA.Text));

							break;
					}

					break;

			
			}
		}

	}
}
