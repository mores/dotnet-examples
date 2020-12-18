# dotnet-examples

dotnet new gitignore

## 001

dotnet new console --output 001-helloWorld

dotnet run --project 001-helloWorld

## 002

dotnet new sln -o 002-multiApp

dotnet new classlib -o 002-multiApp/Lib1

dotnet new console -o 002-multiApp/App2

dotnet sln 002-multiApp/002-multiApp.sln add 002-multiApp/Lib1/Lib1.csproj 002-multiApp/App2/App2.csproj

dotnet add 002-multiApp/App2/App2.csproj reference 002-multiApp/Lib1/Lib1.csproj

dotnet run --project 002-multiApp/App2
