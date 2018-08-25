namespace Demo.EfCore.CodeFirst.Data
{
    public static class Constants
    {
        public static class ConnectionStrings
        {
            public const string LocalDbConnection = @"Data Source=(localdb)\MSSQLLocalDB;initial catalog=CodeFirstDemo;Integrated Security=True; MultipleActiveResultSets=True";
            public const string LinuxDockerConnection = "Server=localhost, 1401;Database=CodeFirstDemo;Trusted_Connection=False;MultipleActiveResultSets=true;user id=sa;password=Str0ngPassword!";
        }
    }
}