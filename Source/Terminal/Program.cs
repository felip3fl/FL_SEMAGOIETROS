﻿using Files;
using OfficeFile;
using System.Text;


System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

string choice = "S";
const string filePath = "C:\\Users\\Felipe\\Source\\Semag\\Source\\Semag\\My game list.xlsx";
var verification = File.Exists(filePath);
if (verification == true) {

    while (choice == "S" || choice == "s") {

        Console.WriteLine("Game sorteado:");

        Csv csv = new Csv();
        ExcelFile excelFile = new ExcelFile();

        //var result = csv.OpenCsv(@"C:\Users\felip\OneDrive\Documents\My games\My game list.csv");
        var result = excelFile.Open(@"C:\Users\Felipe\Source\Semag\Material\My game list.xlsx");


        //print a radom number, the max number is result count
        var game = result[new Random().Next(0, result.Count)];
        Console.WriteLine("Name: " + game[0]);
        Console.WriteLine("Store: " + game[4]);
        Console.WriteLine("Player: " + game[1]);
        Console.WriteLine("Only Local: " + game[2]);
        Console.WriteLine("Better together: " + game[3]);

        Console.WriteLine("\nDeseja continuar? [S/N]: ");
        choice = Console.ReadLine();

    }

} else {
    Console.WriteLine("Erro");

    Console.ReadKey();
}