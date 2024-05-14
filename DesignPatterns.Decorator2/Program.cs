using DesignPatterns.Decorator2.decorators;
using DesignPatterns.Decorator2.models;

var book = new Book("Il nome della rosa", "Umberto Eco", 100);

var readyToBeLoanedBook = new ExtensionLoanBookDecorator(book);

readyToBeLoanedBook.LoanCopy();
Console.WriteLine(readyToBeLoanedBook.Book.AvailableCopiesNo);
Console.WriteLine();

Console.WriteLine(readyToBeLoanedBook.LoanEndDate);
Console.WriteLine();

readyToBeLoanedBook.Action();
Console.WriteLine();

var readyToMail = new MailBookDecorator(readyToBeLoanedBook);
readyToMail.Action();
