# SDK Build System

## Build Tools and Processes

### Primary Build Commands
- `dotnet build` - Build the SDK or individual projects and solutions
- `dotnet test` - Run tests, but note the build system usually drives test execution through specific targets
- `NuGet.exe pack` - Create extension NuGet packages

### Key Build Projects
- `buildtools/build.proj` - Build project used for SDK build and test workflows
- `buildtools/` - Custom MSBuild tasks and utilities
- `generator/` - Code generation during build process

### Build Notes
- The SDK itself is built using the uber solutions, for example `sdk/AWSSDK.NetFramework.sln`.
- Service-specific builds should use the service solution, for example `sdk/src/Services/ACMPCA/ACMPCA.sln`.
- The build system usually runs tests through the `run-tests-mstest` and `run-tests-xunit` targets in `buildtools/build.proj`.
- Some SDK tests are not friendly to run directly without using the intended targets.
- Some targets in `buildtools/build.proj` are leftovers from the previous build system and are not used anymore.
- Changing how the SDK is built may also require changes in the internal build system, for example when adding target frameworks or when the build project needs to use a new MSBuild task defined in the InternalBuildTools package.

### Generator Components
- `generator/ServiceClientGenerator/` - Main SDK code generator executable
- `generator/ServiceClientGeneratorLib/` - Generator library with T4 templates
- `generator/ServiceClientGeneratorTests/` - Generator unit tests
- `generator/ProtocolTestsGenerator/` - Protocol test generator (Gradle-based)
- `generator/ServiceModels/` - Production service Coral-to-JSON (C2J) models
- `generator/TestServiceModels/` - Test service models

### Packaging Notes
- SDK packages are created with `create-nuget-packages.ps1`.
- Extension packages are created with `NuGet.exe pack`.
- Do not assume `dotnet pack` is used for packaging.

## Code Generation Integration

### Service Client Generation Process
1. Coral-to-JSON (C2J) models parsed from `generator/ServiceModels/`
2. T4 templates (*.tt files) in `ServiceClientGeneratorLib/` applied
3. Generated code placed in `sdk/src/Services/<serviceName>/Generated/`
4. Custom code in `Custom/` folders merged
5. Final compilation and packaging

### Protocol Test Generation Process
1. Navigate to `generator/ProtocolTestsGenerator/`
2. Run `./gradlew :smithy-dotnet-protocol-test:build`
3. Tests generated to `sdk/test/ProtocolTests/Generated/<ProtocolName>/`
4. Execute via `dotnet test AWSSDK.ProtocolTests.NetFramework.csproj`

### C2J Model Structure
- Format: `<servicePrefix>-YYYY-MM-DD.<type>.json`
- Generator uses `normal` type files only
- `metadata.json` contains service metadata
- Optional `<servicePrefix>.customizations.json` for generator customizations
- Production models updated during daily releases
- Test models updated manually

### T4 Template System
- *.tt files define code generation patterns
- Each *.tt has corresponding generated *.cs file
- Extensive customization via `Customizations.cs`
- Developers modify *.tt files for generator changes

### Generation Triggers
- Service model updates (daily for production)
- Template modifications (*.tt file changes)
- Build system changes
- Manual regeneration requests
- Protocol test model updates (from internal repository)

## Testing Framework

### Test Categories
- **Unit Tests** - Fast, isolated component tests
- **Integration Tests** - Real AWS service interactions
- **Protocol Tests** - Service protocol compliance (generated from Smithy models)
- **Performance Tests** - Benchmarking and profiling
- **Generator Tests** - Code generator validation

### Test Organization
```text
sdk/test/
├── UnitTests/           # AWSSDK.UnitTests
├── IntegrationTests/    # AWSSDK.IntegrationTests
├── ProtocolTests/       # Protocol compliance tests
└── Services/           # Service-specific tests
```

### Test Execution
- Requires AWS credentials for integration tests
- Use test-specific AWS accounts (not production)
- Automated via CI/CD pipelines
- Manual execution for development

## CI/CD Pipeline

### Build Stages
1. **Code Generation** - Update generated code
2. **Compilation** - Build all assemblies
3. **Unit Testing** - Fast test execution
4. **Integration Testing** - AWS service validation
5. **Package Creation** - NuGet package generation
6. **Deployment** - Release to distribution channels
