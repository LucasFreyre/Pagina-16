int nrProva = int.Parse(textBox1.Text);
int acertos = int.Parse(textBox2.Text);
int erros = nrProva - acertos;
int porcentagemAcertos = (acertos * 100) / nrProva;
int porcentagemErros = (erros * 100) / nrProva;
MessageBox.Show("Numero de erros foi: " + erros + "\nA porcentagem de acertos foi: " + porcentagemAcertos + "%" + "\nA porcentagem de erros foi: " + porcentagemErros + "%");
