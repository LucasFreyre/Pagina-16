int dinheiro = int.Parse(textBox1.Text);
int n200 = 0;
int n100 = 0;
int n50 = 0;
int n20 = 0;
int n10 = 0;
int n5 = 0;
int n2 = 0;

while (dinheiro >= 200)
{
    if (dinheiro >= 200)
    {
        n200++;
        dinheiro -= 200;
    };
};
while (dinheiro >= 100)
{
    if (dinheiro >= 100)
    {
        n100++;
        dinheiro -= 100;
    };
} while (dinheiro >= 50)
{
    if (dinheiro >= 50)
    {
        n50++;
        dinheiro -= 50;
    };
} while (dinheiro >= 20)
{
    if (dinheiro >= 20)
    {
        n20++;
        dinheiro -= 20;
    };
} while (dinheiro >= 10)
{
    if (dinheiro >= 10)
    {
        n10++;
        dinheiro -= 10;
    };
} while (dinheiro >= 5)
{
    if (dinheiro >= 5)
    {
        n5++;
        dinheiro -= 5;
    };
} while (dinheiro >= 2)
{
    if (dinheiro >= 2)
    {
        n2++;
        dinheiro -= 2;
    };
}
MessageBox.Show(
        n200 + "nota de R$200,00\n" +
        n100 + "nota de R$100,00\n" +
        n50 + "nota de R$50,00\n" +
        n20 + "nota de R$20,00\n" +
        n10 + "nota de R$10,00\n" +
        n5 + "nota de R$5,00\n" +
        n2 + "nota de R$2,00\n"
        );
