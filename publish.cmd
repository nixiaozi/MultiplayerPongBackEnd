call SET SolutionDir="%cd%"
call SET RunProjectDir="%cd%\src\BoB.HelloWorldApi"
call dotnet publish  %cd%\src\BoB.HelloWorldApi\BoB.HelloWorldApi.csproj  --framework netcoreapp3.0