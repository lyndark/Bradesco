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
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void btnExercise1_Click(object sender, EventArgs e)
    {
      new Form1().ShowDialog();
    }

    private void btnExercise2_Click(object sender, EventArgs e)
    {
      new Form2().ShowDialog();
    }

    private void btnExercise3_Click(object sender, EventArgs e)
    {
      new Form3().ShowDialog();
    }

    private void btnExercise4_Click(object sender, EventArgs e)
    {
      new Form4().ShowDialog();
    }
  }
}
