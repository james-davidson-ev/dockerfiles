#!/bin/bash -e
export PATH=$PATH:~/.dotnet/tools
#dotnet restore
#cljr -P
export DOTNET_SYSTEM_NET_DISABLEIPV6=1
cljr
