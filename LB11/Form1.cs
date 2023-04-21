using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = comboBox1.Text;
            if (val == "")
            {
                label4.Text = "";
            }
            else if (val == "123")
            {
                label4.Text = "y = F1(F2(F3(x)))";
            }
            else if (val == "132")
            {
                label4.Text = "y = F1(F3(F2(x)))";
            }
            else if (val == "213")
            {
                label4.Text = "y = F2(F1(F3(x)))";
            }
            else if (val == "231")
            {
                label4.Text = "y = F2(F3(F1(x)))";
            }
            else if (val == "312")
            {
                label4.Text = "y = F3(F1(F2(x)))";
            }
            else if (val == "321")
            {
                label4.Text = "y = F3(F2(F1(x)))";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string val = comboBox1.Text;
            string x = textBox1.Text;
            if (val == "" || x == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                if (val == "123")
                {
                    double y1 = Math.Pow(Math.E, Double.Parse(x));
                    double y2 = 1 / y1;
                    double y3 = Math.Sqrt(y2);
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= Math.Sqrt(1/Exp(x))\r\nOn Error Go To E_Catch\r\n  F = Math.Sqrt(1/Exp(x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
                else if (val == "132")
                {
                    double y1 = 1 / Double.Parse(x);
                    double y2 = Math.Pow(Math.E, y1);
                    double y3 = Math.Sqrt(y2);
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= Math.Sqrt(Exp(1/x))\r\nOn Error Go To E_Catch\r\n  F = Math.Sqrt(Exp(1/x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
                else if (val == "213")
                {
                    double y1 = Math.Pow(Math.E, Double.Parse(x));
                    double y2 = Math.Sqrt(y1);
                    double y3 = 1 / y2;
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= 1/(Math.Sqrt(Exp(x))\r\nOn Error Go To E_Catch\r\n  F = 1/(Math.Sqrt(Exp(x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
                else if (val == "231")
                {
                    double y1 = Math.Sqrt(Double.Parse(x));
                    double y2 = Math.Pow(Math.E, y1);
                    double y3 = 1 / y2;
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= 1/(Exp(Math.Sqrt(x))\r\nOn Error Go To E_Catch\r\n  F = 1/(Exp(Math.Sqrt(x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
                else if (val == "312")
                {
                    double y1 = 1 / Double.Parse(x);
                    double y2 = Math.Sqrt(y1);
                    double y3 = Math.Pow(Math.E, y2);
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= Exp(Math.Sqrt(1/x))\r\nOn Error Go To E_Catch\r\n  F = Exp(Math.Sqrt(1/x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
                else if (val == "321")
                {
                    double y1 = Math.Sqrt(Double.Parse(x));
                    double y2 = 1 / y1;
                    double y3 = Math.Pow(Math.E, y2);
                    if (y3.ToString() == "∞" || Double.IsNaN(y3) == true)
                    {
                        MessageBox.Show("Вне области определения");
                    }
                    else
                    {
                        label6.Text = y3.ToString();
                    }
                    richTextBox1.Text = "Function F(x As Double)  '= Exp(1/Math.Sqrt(x))\r\nOn Error Go To E_Catch\r\n  F = Exp(1/Math.Sqrt(x))\r\n  Exit Function\r\nE_Catch:\r\n  Select Case Err.Number\r\n  Case 11\r\n    Call MsgBox(\"Division by 0\",, \"Error)\r\n  Case 5\r\n    Call MsgBox(\"Square root of negative number\",, \"Error\")\r\n  Case Else\r\n    Call MsgBox(\"Error: \" & Err.Number & \"\" & Err.Description)\r\n  End Select\r\n  Err.Raise Err.Number\r\nEnd Function\r\n\r\nSub TestF()\r\nDim x As Double\r\nx = Application.InputBox()\r\nDebug.Print(F(x))\r\nEnd Sub";
                }
            }
        }
    }
}
