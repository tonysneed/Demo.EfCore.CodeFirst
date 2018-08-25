# EF Core Code First Demo

## Prerequisites
1. Install the .NET Core SDK [v 2.1](https://www.microsoft.com/net/download/) or later
2. Update Visual Studio to [v 15.8](https://blogs.msdn.microsoft.com/visualstudio/2018/08/14/visual-studio-2017-version-15-8/) or later

> Note: If you get an error running `dotnet ef` commands, add the following to the Data project's csproj file.  See this [issue](https://github.com/aspnet/EntityFrameworkCore/issues/10298) for more info.

```xml
<PropertyGroup>
  <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
</PropertyGroup>
```

## Steps
1. Create an EF Core Class Library
2. Set the framework version to v2.1 or higher
3. Add NuGet package: Microsoft.EntityFrameworkCore.SqlServer
4. Add NuGet package: Microsoft.EntityFrameworkCore.Design
5. Add `Product` class

    ```csharp
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
    ```

6. Add `CodeFirstDemoContext` class that extends `DbContext`

    ```csharp
    public class CodeFirstDemoContext : DbContext
    {
        public CodeFirstDemoContext(DbContextOptions<CodeFirstDemoContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
    ```

7. Add `CodeFirstDemoContextFactory` class that implements `IDesignTimeDbContextFactory<CodeFirstDemoContext>`

    ```csharp
    public class CodeFirstDemoContextFactory : IDesignTimeDbContextFactory<CodeFirstDemoContext>
    {
        public CodeFirstDemoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CodeFirstDemoContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;initial catalog=CodeFirstDemo;Integrated Security=True; MultipleActiveResultSets=True");
            return new CodeFirstDemoContext(optionsBuilder.Options);
        }
    }
    ```

8. Add code to `CodeFirstDemoContext` to seed data the database

    ```csharp
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, ProductName = "Chai", UnitPrice = 1 },
            new Product { Id = 2, ProductName = "Chang", UnitPrice = 2},
            new Product { Id = 3, ProductName = "Cappuccino", UnitPrice = 3 }
        );
    }
    ```

9. Open command prompt at Data project directory and add an EF migration

    ```
    dotnet ef migrations add initial
    ```

10. Apply the EF migration to the database

    ```
    dotnet ef database update
    ```
