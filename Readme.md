# AsyncAwaitBenchmark

Este projeto tem como estudo analisar o que é jerado no IL para entender como a state machine do C# funciona 
Esse projeto é destinado a estudos de uso de Async/Await para entender como o state machine do C# funciona

Para isso, comparei:
  - Performance sem Task
  - Performance sem Await
  - Performance com Await

### Execução

Necessário .NET Core 3.1 
```sh
dotnet run -c Release --project .\src\BenchTest\BenchTest.csproj
```

Diretório de output dos dados
```sh
src\BenchTest\BenchmarkDotNet.Artifacts\
```

### Plugins

O pacote utilizado para esse projeto foi:

| Plugin | Versão |
| ------ | ------ |
| BenchmarkDotNet | 0.12.1 |