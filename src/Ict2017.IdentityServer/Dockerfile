FROM microsoft/aspnetcore-build
WORKDIR /app

COPY Ict2017.IdentityServer/*.csproj ./Ict2017.IdentityServer/$1
COPY Ict2017.Common/*.csproj ./Ict2017.Common/$1

RUN dotnet restore ./Ict2017.IdentityServer

COPY Ict2017.IdentityServer ./Ict2017.IdentityServer
COPY Ict2017.Common ./Ict2017.Common

WORKDIR /app/Ict2017.IdentityServer
ENTRYPOINT [ "dotnet", "run" ]

