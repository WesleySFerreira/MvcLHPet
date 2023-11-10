using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.095-21", "arthur.antunes@es.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William H. Gates III", "039.527.588-97", "bill@microsoft.com", "Boss");
        Cliente cliente3 = new Cliente(03, "Elisabeth Santos", "547.632.128-52", "elisa.s@ada.language.com", "Fofucha");
        Cliente cliente4 = new Cliente(04, "João Roda", "412.986.328-21", "jroda@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Clarice Neiva", "552.478.203-02", "clarice.neiva@cobol.com", "Lobo");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet S/A", "15.254.985/0001-23", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "C++ Dogs", "01.754.668/0001-10", "cplus@plus.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Json Pets", "11.656.272/0001-22", "json.pets@insomnia.uk");
        Fornecedor fornecedor4 = new Fornecedor(04, "Html Petshop", "20.444.230/0001-55", "shop.html@pet.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Dotnet Cats", "51.488.200/0001-54", "dotnet@cats.cn");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
