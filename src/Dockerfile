#client stage
FROM node:alpine AS client
WORKDIR /clientSource

COPY Ict2017.Client/package.json .
RUN npm install 

COPY Ict2017.Client/ .
WORKDIR /clientSource/Ict2017.Client
RUN npm run build -- -op /dist/

#server stage
FROM microsoft/aspnetcore-build:2 AS server
WORKDIR /serverSource

COPY Ict2017.WebApi/*.csproj ./Ict2017.WebApi/$1
COPY Ict2017.Common/*.csproj ./Ict2017.Common/$1

RUN dotnet restore ./Ict2017.WebApi

COPY Ict2017.WebApi ./Ict2017.WebApi
COPY Ict2017.Common ./Ict2017.Common

RUN dotnet publish Ict2017.WebApi -o /app/ -c Release

#app stage
FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=client /dist .
COPY --from=server /app .
ENV ASPNETCORE_ENVIRONMENT=Docker
ENTRYPOINT [ "dotnet" , "Ict2017.WebApi.dll" ]