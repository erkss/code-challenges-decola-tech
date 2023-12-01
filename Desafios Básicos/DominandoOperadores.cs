string titulo = Console.ReadLine();
string descricao = Console.ReadLine();
string dataVencimento;

if(descricao.Length > 50)
{
    Console.WriteLine("Descricao ultrapassa limite de caracteres.");
} 
else 
{
    dataVencimento = Console.ReadLine();
    Console.WriteLine($"{descricao} ate {dataVencimento}");   
}