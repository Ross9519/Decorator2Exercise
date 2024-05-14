using DesignPatterns.Decorator2.models;

namespace DesignPatterns.Decorator2.decorators
{
    internal class MailBookDecorator(Book book) : BookDecorator(book)
    {
        public override void Action()
            => Console.WriteLine($"Ritardo nel ritorno del libro, ho mandato la mail.");
    }
}
