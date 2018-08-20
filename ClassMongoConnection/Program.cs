namespace ClassMongoConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var cnx = new Connect();
            cnx.Execute();
        }
    }
}
