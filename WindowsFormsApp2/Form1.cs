using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		int ustN1, ustB10, ustBas11;

		int altN1, altBas10, altBas11;

		int ustS1, ustS2, ustS4, ustS3;

		int altS1, altS2, altS4, altS3;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = textBox1.Text;


			ustS1 = altS1 = Convert.ToInt32(input.Substring(0, 5));
			ustS2 = altS2 = Convert.ToInt32(input.Substring(5, 4));
			ustS3 = altS3 = Convert.ToInt32(input.Substring(9, 1));
			ustS4 = altS4 = Convert.ToInt32(input.Substring(10, 1));

			
			if ((ustS1 % 100) > 96 || (ustS2 % 100) < 1) 
			{
				 if ((ustS1 % 100) > 96)
				{
					      if (ustS4 < 6)
							{
								 ustBas11 = (ustS4 + 10) - 6;
							}
							else
							{
							ustBas11 = ustS4 - 6;
							}
				}
				else if ((ustS2 % 100) < 1)
				{
					if (ustS4 < 2)
					{
						ustBas11 = (ustS4 + 10) - 2;
					}
					else
					{
						ustBas11 = ustS4 - 2;
					}
				}
			}
			else
			{
				if (ustS4 < 4)
				{
					ustBas11 = (ustS4 + 10) - 4;
				}
				else
				{
					ustBas11 = ustS4 - 4;
				}
			}


			ustS1 += 3;
			ustS2 -= 1;

			string ustK1 = ustS1.ToString();
			string ustL2 = ustS2.ToString();

			int ustB1 = Convert.ToInt32(ustK1.Substring(0, 1));
			int ustB2 = Convert.ToInt32(ustK1.Substring(1, 1));
			int ustB3 = Convert.ToInt32(ustK1.Substring(2, 1));
			int ustB4 = Convert.ToInt32(ustK1.Substring(3, 1));
			int ustB5 = Convert.ToInt32(ustK1.Substring(4, 1));
			int ustB6 = Convert.ToInt32(ustL2.Substring(0, 1));
			int ustB7 = Convert.ToInt32(ustL2.Substring(1, 1));
			int ustB8 = Convert.ToInt32(ustL2.Substring(2, 1));
			int ustB9 = Convert.ToInt32(ustL2.Substring(3, 1));


			ustN1 = ustB1 + ustB2 + ustB3 + ustB4 + ustB5 + ustB6 + ustB7 + ustB8 + ustB9;
			ustN1 = ustN1 % 10;

	


			if (ustN1 == ustBas11)
			{
				ustB10 = 0;
			}
			else if (ustN1 < ustBas11)
			{
				ustB10 = ustBas11 - ustN1;
			}
			else
			{
				ustB10 = (ustBas11 + 10) - ustN1;
			}



			if ((altS1 % 100) < 3 || (altS2 % 100) == 99) 
			{
				if ((altS1 % 100) < 3)

				{
					altBas11 = altS4 += 6;

					if (altS4 >= 10)
					{
						altBas11 = altS4 % 10;
					}
				}
				else if ((altS2 % 100) == 99)
				{


					altBas11 = altS4 += 2;

					if (altS4 >= 10)
					{

						altBas11 = altS4 % 10;
					}
				}
			}
			else
			{


				altBas11 = altS4 += 4;


				if (altS4 >= 10)
				{
					altBas11 = altS4 % 10;
				}
			}


			

			altS1 -= 3;
			altS2 += 1;


			string K1 = altS1.ToString();
			string L2 = altS2.ToString();

			int altB1 = Convert.ToInt32(K1.Substring(0, 1));
			int altB2 = Convert.ToInt32(K1.Substring(1, 1));
			int altB3 = Convert.ToInt32(K1.Substring(2, 1));
			int altB4 = Convert.ToInt32(K1.Substring(3, 1));
			int altB5 = Convert.ToInt32(K1.Substring(4, 1));
			int altB6 = Convert.ToInt32(L2.Substring(0, 1));
			int altB7 = Convert.ToInt32(L2.Substring(1, 1));
			int altB8 = Convert.ToInt32(L2.Substring(2, 1));
			int altB9 = Convert.ToInt32(L2.Substring(3, 1));

			altN1 = altB1 + altB2 + altB3 + altB4 + altB5 + altB6 + altB7 + altB8 + altB9;

			altN1 = altN1 % 10;



			if (altN1 == altBas11)
			{
				altBas10 = 0;
			}
			else if (altN1 < altBas11)
			{
				altBas10 = altBas11 - altN1;
			}
			else
			{
				altBas10 = (altBas11 + 10) - altN1;
			}


			textBox2.Text = ustK1.ToString() + ustL2.ToString() + ustB10.ToString() + ustBas11.ToString();
			textBox3.Text = K1.ToString() + L2.ToString() + altBas10.ToString() + altBas11.ToString();
		}

	}

		}
	

