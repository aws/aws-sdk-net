# Protocol Test Generator

### Project Structure
The `ProtocolTestsGenerator` folder consists of 3 gradle projects. The `smithy-dotnet-codegen` project contains
the core logic for generating the protocol tests. At present, only protocol test generation via smithy test files is supported at this time.
Please note that this is not a full smithy code generator.

The `smithy-dotnet-codegen-test` project consists of several test smithy models that can be used to test the core
`smithy-dotnet-codegen` project. 

The `smithy-dotnet-protocol-test` project is where the protocol tests will be output under `build/smithyprojections/smithy-dotnet-protocol-test`

## Setup
This project makes use of `gradlew`, so no JDK dependency is needed to build the project using the `./gradlew` command.
Simply clone the repository and `cd` into the `ProtocolTestsGenerator` folder. The gradle wrapper will invoke a declared version
of gradle or download it beforehand if necessary.

## Running the Protocol Test Generator
1. Navigate to the `ProtocolTestsGenerator` directory
```
cd ProtocolTestsGenerator
```
2. Build the project
```
./gradlew :smithy-dotnet-protocol-test:build
```

## Running the Test Project
1. Navigate to the `ProtocolTestsGenerator` directory
```
cd ProtocolTestsGenerator
```
2. Build the project
```
./gradlew :smithy-dotnet-codegen-test:build
```
**Note:** Since the core smithy code generator is set up to generate protocol tests only, 
the `smithy-dotnet-codegen-test` project will not build. If you want to use the test project,
make sure to include a projection.