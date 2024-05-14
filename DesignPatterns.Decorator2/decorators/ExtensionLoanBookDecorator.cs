using DesignPatterns.Decorator2.models;

namespace DesignPatterns.Decorator2.decorators
{
    internal class ExtensionLoanBookDecorator(Book book) : BookDecorator(book)
    {
        public override void Action()
        {
            LoanEndDate = LoanEndDate.AddDays(15);
            Console.WriteLine($"Nuova data di scadenza prestito: {LoanEndDate}");
        }
    }
}
