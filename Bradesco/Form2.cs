using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bradesco
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
      DateTime birthDate = dtpBirthDate.Value;


      if (birthDate.Year > 2015)
      {
        MessageBox.Show("Data de nascimento inválida. Insira uma data anterior a 2015.");
      }

      int currentAge = DateTime.Now.Year - birthDate.Year, ageResult = 0;


      if (DateTime.Now < birthDate.AddYears(DateTime.Now.Year - birthDate.Year))
      {
        ageResult = currentAge - 1;
      }
      else
      {
        ageResult = currentAge;
      }

      MessageBox.Show($"Idade exata: {ageResult} anos");
    }
  }
}
