# dotnet-pipeline-poc

This is a sample WebAPI to be used for testing how to integrate a modern .NET Core WebAPI into an Azure DevOps pipeline.

# Starting

```
cd src
cd Pipeline.Poc.WebApi
dotnet run
```

The WebAPI will now be available, try it out for yourself.

```
> curl https://localhost:5001/weatherforecast

[{"date":"2020-08-14T22:16:13.844276+02:00","temperatureC":-14,"temperatureF":7,"summary":"Mild"},{"date":"2020-08-15T22:16:13.8443619+02:00","temperatureC":-1,"temperatureF":31,"summary":"Sweltering"},{"date":"2020-08-16T22:16:13.8444141+02:00","temperatureC":45,"temperatureF":112,"summary":"Balmy"},{"date":"2020-08-17T22:16:13.844464+02:00","temperatureC":49,"temperatureF":120,"summary":"Bracing"},{"date":"2020-08-18T22:16:13.844514+02:00","temperatureC":37,"temperatureF":98,"summary":"Sweltering"}]
```

# Testing

Make sure the WebAPI is up and running (as described above), and execute the following commands.

```
cd test
cd Pipeline.Poc.AcceptanceTests
dotnet test
```
