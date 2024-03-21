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
Once in the `ProtocolTestsGenerator` folder.
1. Navigate to `smithy-dotnet-protocol-test` directory
```
cd smithy-dotnet-protocol-test
```
2. Build the project
```
./gradlew :smithy-dotnet-protocol-test:build
```

## Running the Test Project
1. Navigate to `smithy-dotnet-codegen-test`
```
cd smithy-dotnet-codegen-test
```
2. Build the project
```
./gradlew :smithy-dotnet-codegen-test:build
```
**Note:** For the `smithy-dotnet-codegen-test` project you may need to tweak the `smithy-build.json` file to point to the right
smithy model.