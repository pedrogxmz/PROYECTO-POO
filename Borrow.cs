namespace MyLibrary
{
    class Borrow
    {
        public int UserId { get; }
        public int BookId { get; }

        public Borrow(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
        }
    }
}
