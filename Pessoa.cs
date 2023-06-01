public class Pessoa
{
    private string nome;
    private string cpf;
    private string sexo;
    private double peso;
    private double altura;
    private int idade;
    public CalculoIMC(string nome, string cpf, string sexo, double peso, double altura, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
        this.idade = idade;
    }

    public (double, string, string) CalcIMC()
    {
        double calc = peso / (Math.Pow(altura, 2));
        if (calc < 18.5)
        {
            return (calc, "Magreza", "0");
        }
        else if (calc >= 18.5 && calc <= 24.9)
        {
            return (calc, "Normal", "0");
        }
        else if (calc >= 25 && calc <= 25.9)
        {
            return (calc, "Sobrepeso", "1");
        }
        else if(calc >= 30 && calc <= 39.9)
        {
            return (calc, "Obesidade", "2");
        }
        else
        {
            return (calc, "Obesidade Grave", "3");
        }
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }
    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }
    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }
    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }
}