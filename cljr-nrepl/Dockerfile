FROM mcr.microsoft.com/dotnet/sdk:8.0
USER root
RUN apt update -y
RUN apt install -y vim screen ca-certificates procps net-tools
RUN dotnet tool install --global Clojure.Main --version 1.12.0-alpha10
RUN dotnet tool install --global Clojure.Cljr --version 0.1.0-alpha5
ENV PATH="$PATH:/root/.dotnet/tools"
WORKDIR /opt/asdf
COPY asdf.csproj deps-clr.edn ./
RUN mkdir -p src/cljr
COPY asdf.cljr src/cljr
RUN dotnet restore
RUN cljr -P
COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh
ENTRYPOINT /entrypoint.sh
