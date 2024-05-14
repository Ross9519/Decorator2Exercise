namespace DesignPatterns.Decorator2.models
{
    internal class Book(string title, string author, int availableCopiesNo)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public int AvailableCopiesNo { get; set; } = availableCopiesNo;

        public virtual void LoanCopy()
        {
            if (AvailableCopiesNo > 0)
                AvailableCopiesNo --;
        }
    }
}
