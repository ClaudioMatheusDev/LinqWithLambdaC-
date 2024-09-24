using LinqWithLambda.Entities;
using System.Collections.Generic;
using System.Linq;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach(T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}//Função para imprimir todo resultado

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 3};

List<Product> products = new List<Product>()
{
    new Product() { Id = 1,Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() { Id = 2,Name = "Hammer", Price = 90, Category = c1 },
    new Product() { Id = 3,Name = "TV", Price = 1700.0, Category = c3 },
    new Product() { Id = 4,Name = "Saw", Price = 100.0, Category = c2 },
    new Product() { Id = 5,Name = "Tablet", Price = 700.0, Category = c1 },
    new Product() { Id = 6,Name = "Camera", Price = 600.0, Category = c2 },
    new Product() { Id = 7,Name = "Printer", Price = 300.0, Category = c3 },
    new Product() { Id = 8,Name = "MacBook", Price = 1800.0, Category = c3 },
    new Product() { Id = 9,Name = "Sound Bar", Price = 700.0, Category = c2 },
    new Product() { Id = 10,Name = "Level", Price = 10.0, Category = c1 }
};
var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00); //Adicionando um LINQ para achar todos os produtos que tem o valor menor que 900.00

Print("Tier 1 AND PRICE < 900: ", r1);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);//Procurando todos os produtos que são TOOLS
Print("NAME OF PRODCUTS FROM TOOLS", r2);

var r3 = products.Where(p => p.Category.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //Usando o .Select para selecionar apenas o nome,
Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);                                                                                                                       //preço e categoria, na categoria estamos renomeando a mesma com CategoyName =


