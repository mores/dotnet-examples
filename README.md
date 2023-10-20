# dotnet-examples

On ubuntu - sudo snap install dotnet-sdk

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

### 002 - add logging

dotnet add  002-multiApp/Lib1/ package Serilog

dotnet add  002-multiApp/App2/ package Serilog.Sinks.Console

dotnet add  002-multiApp/App2/ package Serilog.Sinks.File

dotnet list 002-multiApp package


### 004
dotnet new classlib --output 004-calculate

dotnet build 004-calculate
