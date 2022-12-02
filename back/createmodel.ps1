$strconn = "Data Source=" + $args[0] + ";Initial Catalog=" + $args[1] + ";Integrated Security=True"
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.17
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.17
dotnet tool install --global dotnet-ef
dotnet ef dbcontext scaffold $strconn Microsoft.EntityFrameworkCore.SqlServer --force -o Model
