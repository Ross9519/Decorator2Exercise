using DesignPatterns.Decorator2.models;

namespace DesignPatterns.Decorator2.decorators
{
    internal abstract class BookDecorator(Book book) : Book(book.Title, book.Author, book.AvailableCopiesNo)
    {
        public Book Book { get; set; } = book;
        public DateOnly LoanEndDate { get; set; }

        public override void LoanCopy()
        {
            Book.LoanCopy();
            LoanEndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(1));
        }

        public abstract void Action();
    }
}
