FROM microsoft/aspnetcore-build:2
WORKDIR /app

COPY Ict2017.MVC/*.csproj ./Ict2017.MVC/$1
COPY Ict2017.Common/*.csproj ./Ict2017.Common/$1

RUN dotnet restore ./Ict2017.MVC

COPY Ict2017.MVC ./Ict2017.MVC
COPY Ict2017.Common ./Ict2017.Common

WORKDIR /app/Ict2017.MVC
ENTRYPOINT [ "dotnet", "run" ]

