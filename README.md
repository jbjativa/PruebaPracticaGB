# PruebaPracticaGB
Prueba Practica para BG
Usando la base de Datos AdventureWorks2014 en SQLServerManagementStudio 18
Usando AspNetCore, MVC, EntityFrameWork y Visual Studio 2022


Comandos Utilizados:
Nugget Package Manager Console.
Scaffold-DbContext "Data Source=WINDOWS-R7F90FG;Initial Catalog=AdventureWorks;Integrated Security=True"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
update-database -Context ApplicationDbContext

dotnet aspnet-codegenerator controller -name EmployeesController -m Employee -dc AdventureWorksContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name EmployeePayHistoriesController -m EmployeePayHistory-dc AdventureWorksContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f