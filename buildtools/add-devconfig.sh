#!/bin/bash

cd "$(dirname "$0")"

dotnet build ./DevConfigGenerator/DevConfigGenerator/DevConfigGenerator.csproj
dotnet exec ./DevConfigGenerator/DevConfigGenerator/bin/Debug/net8.0/DevConfigGenerator.dll