
namespace FinancialReportPro.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} | {Description,-30} | {Amount,10:C}";
        }
    }
}