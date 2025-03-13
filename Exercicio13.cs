int prUnitario = int.Parse(textBox1.Text);
int qntProdutos = int.Parse(textBox2.Text);
int qntPagar = prUnitario * qntProdutos;
MessageBox.Show("Voce deverá pagar: " + qntPagar.ToString("C"));
