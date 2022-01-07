#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Safra.csproj", "."]
RUN dotnet restore "./Safra.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Safra.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Safra.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m alinepinheiro30
USER alinepinheiro30
# Padr�o de container ASP.NET
# ENTRYPOINT ["dotnet", "Safra.dll"]
# Op��o utilizada pelo Heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Safra.dll

 
