FROM mcr.microsoft.com/dotnet/sdk:8.0
RUN apt update -y
RUN apt install -y vim screen ca-certificates procps net-tools
WORKDIR /opt/asdf
COPY asdf.csproj .
RUN dotnet restore
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
COPY Program.cs .
ENTRYPOINT /entrypoint.sh
