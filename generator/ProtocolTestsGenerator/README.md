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
3. The protocol tests will be outputted to the `sdk/test/ProtocolTests/Generated/<ProtocolName>/dotnet-protocol-test-codegen` folder.

4. To run the tests you can open the AWSSDK.ProtocolTests.NetFramework.sln and run the tests in Visual Studio or run the following command in the `sdk/test/ProtocolTests` directory.
```
dotnet test AWSSDK.ProtocolTests.NetFramework.csproj
```

## Debugging Protocol Tests

1. If one of the protocol tests is broken, you can debug it by opening the `.sln` file under `sdk/test/ProtocolTests`, navigating to the test that is failing, placing a breakpoint and debugging as usual.