using System.IO;

string raiz = Directory.GetParent(Directory.GetCurrentDirectory())!.FullName;

string projeto = Path.Combine(raiz, "LearningCSharp");


var estrutura = new Dictionary<string, string[]>
{
    {
        "01-Fundamentos",
        new[]
        {
            "01-Introducao",
            "02-Variaveis",
            "03-TiposDeDados",
            "04-Operadores",
            "05-EntradaESaida",
            "06-EstruturasCondicionais",
            "07-LacosDeRepeticao",
            "08-Metodos",
            "09-ProjetoFinal"
        }
    },

    {
        "02-POO",
        new[]
        {
            "01-Classes",
            "02-Objetos",
            "03-Encapsulamento",
            "04-Heranca",
            "05-Polimorfismo",
            "06-Interfaces",
            "07-ProjetoFinal"
        }
    },

    {
        "03-Colecoes",
        new[]
        {
            "01-Arrays",
            "02-List",
            "03-Dictionary",
            "04-HashSet"
        }
    },

    {
        "04-LINQ",
        new[]
        {
            "01-Consultas",
            "02-Ordenacao",
            "03-Filtros",
            "04-Projecoes"
        }
    },

    {
        "05-BancoDeDados",
        new[]
        {
            "01-SQLServer",
            "02-EntityFrameworkCore",
            "03-CRUD"
        }
    },

    {
        "06-Desktop",
        new[]
        {
            "01-WPF",
            "02-MVVM",
            "03-ProjetoDesktop"
        }
    }
};


// cria pasta principal

Directory.CreateDirectory(projeto);


// cria README principal

File.WriteAllText(
    Path.Combine(projeto, "README.md"),
    "# Learning CSharp\n\nRoadmap de estudos C#/.NET"
);


// cria módulos

foreach (var modulo in estrutura)
{
    string caminhoModulo = Path.Combine(
        projeto,
        modulo.Key
    );

    Directory.CreateDirectory(caminhoModulo);


    File.WriteAllText(
        Path.Combine(caminhoModulo, "README.md"),
        $"# {modulo.Key}"
    );


    foreach (var assunto in modulo.Value)
    {
        string caminhoAssunto = Path.Combine(
            caminhoModulo,
            assunto
        );


        Directory.CreateDirectory(caminhoAssunto);


        File.WriteAllText(
            Path.Combine(caminhoAssunto, "README.md"),
            $"# {assunto}"
        );


        File.WriteAllText(
            Path.Combine(caminhoAssunto, "Exercicios.md"),
            "# Exercícios"
        );


        File.WriteAllText(
            Path.Combine(caminhoAssunto, "Desafio.md"),
            "# Desafio"
        );


        Directory.CreateDirectory(
            Path.Combine(caminhoAssunto, "imagens")
        );
    }
}


Console.WriteLine("Estrutura criada com sucesso!");