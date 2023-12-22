namespace Bradesco
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
      string input = string.Format(txtInput.Text);

      int value = 0;

      if (int.TryParse(input, out value))
      {
        if (value % 2 == 0)
        {
          MessageBox.Show($"O número {value} é PAR!");
        }
        else
        {
          MessageBox.Show($"O número {value} é IMPAR!");
        }
      }
    }
  }
}
