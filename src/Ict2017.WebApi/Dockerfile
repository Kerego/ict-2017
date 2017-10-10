FROM microsoft/aspnetcore-build
WORKDIR /app

COPY Ict2017.WebApi/*.csproj ./Ict2017.WebApi/$1
COPY Ict2017.Common/*.csproj ./Ict2017.Common/$1

RUN dotnet restore ./Ict2017.WebApi

COPY Ict2017.WebApi ./Ict2017.WebApi
COPY Ict2017.Common ./Ict2017.Common
WORKDIR /app/Ict2017.WebApi
ENTRYPOINT [ "dotnet", "run" ]

