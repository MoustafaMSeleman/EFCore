// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder().AddJsonFile("D:\\DotNet Core\\MyProjects\\EFCore\\EFCore\\appsettings.json").Build();
//Console.WriteLine(config.GetSection("DefaultConnection").Value);


