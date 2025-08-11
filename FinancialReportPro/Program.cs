using FinancialReportPro.Models;
using FinancialReportPro.Extensions;

class Program
{
    static void Main(string[] args)
    {
        string path = "Data/sample.csv";
        var transactions = LoadTransactions(path);

        Console.WriteLine("===== Finansal Özet =====");
        Console.WriteLine($"Toplam Gelir: {transactions.TotalIncome():C}");
        Console.WriteLine($"Toplam Gider: {transactions.TotalExpense():C}");

        Console.WriteLine($"\nEn Yüksek Gelir: {transactions.HighestIncome()}");
        Console.WriteLine($"En Yüksek Gider: {transactions.HighestExpense()}");

        Console.WriteLine("\nAylık Nakit Akışı");
        transactions.PrintMonthlyReport();

        if (transactions.HasNegativeMonths())
        {
            Console.WriteLine("\n Negatif Nakit Akışı Olan Ay(lar) Tespit Edildi!");
        }

    }

    static List<Transaction> LoadTransactions(string path)
    {
        var lines = File.ReadAllLines(path);
        var transactions = new List<Transaction>();

        foreach (var line in lines.Skip(1))
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            var parts = line.Split(',');

            try
            {
                transactions.Add(new Transaction
                {
                    Date = DateTime.Parse(parts[0].Trim()),
                    Description = parts[1].Trim(),
                    Amount = decimal.Parse(parts[2].Trim())
                });
            }
            catch (FormatException ex) {
                Console.WriteLine($"Hatalı satır: {line} \nHata: {ex.Message}");
                Console.WriteLine($"Satır atlandı (hatalı format): {line}");
            }
        }
        return transactions;
        
    }
}