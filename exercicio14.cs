int prUnitario = int.Parse(textBox1.Text);
int qntProdutos = int.Parse(textBox2.Text);
int qntPagar = prUnitario * qntProdutos;
int desconto = qntPagar * 15 / 100;
if (qntPagar > 200)
{
    MessageBox.Show("Voce deverá pagar: " + (qntPagar - desconto).ToString("C"));
}
else
{
    MessageBox.Show("Voce deverá pagar: " + qntPagar.ToString("C"));
}
