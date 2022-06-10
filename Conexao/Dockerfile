#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#(Funciona) ENV ConnectionString="server=host.docker.internal;port=52000;database=produto;user=root;password=mysql;"
ENV ConnectionString="server=172.17.0.1;port=52000;database=produto;user=root;password=mysql;"

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Conexao/Conexao.csproj", "Conexao/"]
RUN dotnet restore "Conexao/Conexao.csproj"
COPY . .
WORKDIR "/src/Conexao"
RUN dotnet build "Conexao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Conexao.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Conexao.dll"]