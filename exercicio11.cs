// celsius para fahrenheit
float celsius = float.Parse(txtC.Text);
double formulaF = (celsius * 9) / 5 + 32;
MessageBox.Show("" + formulaF);

//celsius para Kelvin
float celsius = float.Parse(txtC.Text);
double formulaK = celsius + 273;
MessageBox.Show("" + formulaK);
