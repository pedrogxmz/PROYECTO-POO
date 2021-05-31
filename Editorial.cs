namespace MyLibrary
{
    class Editorial
    {
        public int Id { get; }
        public string Description { get; }

        public Editorial(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
