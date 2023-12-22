using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bradesco
{
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
    }

    private void btnFahrenheit_Click(object sender, EventArgs e)
    {
      string inputCelsius = string.Format(txtInput.Text);

      double celsiusTemperature = 0;

      if (double.TryParse(inputCelsius, out celsiusTemperature))
      {
        double temperatureFahrenheit = (celsiusTemperature * 9 / 5) + 32;

        MessageBox.Show($"Valor em Fahrenheit: {temperatureFahrenheit}");
      }
    }

    private void btnKelvin_Click(object sender, EventArgs e)
    {
      string inputCelsius = string.Format(txtInput.Text);

      double celsiusTemperature = 0;

      if (double.TryParse(inputCelsius, out celsiusTemperature))
      {
        double temperatureKelvin = celsiusTemperature + 273.15;

        MessageBox.Show($"Valor em Fahrenheit: {temperatureKelvin}");
      }
    }
  }
}
