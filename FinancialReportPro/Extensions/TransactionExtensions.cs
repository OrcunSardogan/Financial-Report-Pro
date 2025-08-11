using FinancialReportPro.Models;

namespace FinancialReportPro.Extensions
{
    public static class TransactionExtensions
    {
        public static decimal TotalIncome(this List<Transaction> list) => list.Where(t => t.Amount > 0).Sum(t => t.Amount);

        public static decimal TotalExpense(this List<Transaction> list) => list.Where(t => t.Amount < 0).Sum(t => t.Amount);

        public static Transaction? HighestIncome(this List<Transaction> list) => list.Where(t => t.Amount > 0).OrderByDescending(t => t.Amount).FirstOrDefault();

        public static Transaction? HighestExpense(this List<Transaction> list) => list.Where(t => t.Amount < 0).OrderBy(t => t.Amount).FirstOrDefault();

        public static  Dictionary<string, decimal> MonthlySummary(this List<Transaction> list)
        {
            return list.GroupBy(t => t.Date.ToString("yyyy-mm"))
                                 .ToDictionary(
                                    g => g.Key,
                                    g => g.Sum(t => t.Amount)
                                 );
        }

        public static bool HasNegativeMonths(this List<Transaction> list)
        {
            return list.MonthlySummary().Any(m => m.Value < 0);
        }

        public static void PrintMonthlyReport(this List<Transaction> list)
        {
            var summary = list.MonthlySummary();

            foreach (var month in summary)
            {
                Console.WriteLine($"{month.Key}: {month.Value:C}");
            }
        }
    }
}