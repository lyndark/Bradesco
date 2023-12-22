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
  public partial class Form4 : Form
  {
    public Form4()
    {
      InitializeComponent();
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      List<int> numbers = new List<int> { -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 };

      List<string> convertedNumbers = convertNumbers(numbers);

      string resultString = string.Join(", ", convertedNumbers);
      MessageBox.Show(resultString);

      List<string> listResult = new List<string>(convertedNumbers);
    }

    private List<string> convertNumbers(List<int> numbers)
    {
      List<string> convertedNumbers = numbers.Select(num => num >= 0 ? "POSITIVO" : "NEGATIVO").ToList();

      return convertedNumbers;
    }
  }
}
