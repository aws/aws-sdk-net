# SDK Code Structure

## Repository Organization

### Core Directories
- `sdk/src/Core/` - AWSSDK.Core assembly containing shared functionality
- `sdk/src/Services/` - Individual service assemblies (AWSSDK.S3, AWSSDK.DynamoDBv2, etc.)
- `extensions/` - Extension libraries and high-level abstractions
- `generator/` - Code generation tools and service models
- `buildtools/` - Build utilities and custom MSBuild tasks

### Generator Directory Structure
- `generator/ProtocolTestsGenerator/` - Protocol test generator using Gradle/Smithy
- `generator/ServiceClientGenerator/` - Main SDK code generator program
- `generator/ServiceClientGeneratorTests/` - Unit tests for SDK code generator
- `generator/ServiceClientGeneratorLib/` - Generator source files and T4 templates
- `generator/ServiceModels/` - C2J model files for shipped services
- `generator/TestServiceModels/` - Test service models (not shipped)

### Service Structure Pattern
```
sdk/src/Services/<serviceName>/
├── AWSSDK.<serviceName>.csproj
├── Generated/
│   ├── Model/           # Request/response classes
│   ├── ServiceEnumerations.cs
│   └── Amazon<serviceName>Client.cs
├── Custom/              # Hand-written customizations
└── Properties/
    └── AssemblyInfo.cs
```

### Core Structure
```
sdk/src/Core/
├── Amazon.Runtime/      # Request pipeline, credentials, configuration
├── Amazon.Util/         # Utility classes and helpers
├── Amazon.Auth/         # Authentication and signing
├── ThirdParty/         # Embedded third-party code
└── Properties/
```

## Code Generation

### Protocol Test Generator (`generator/ProtocolTestsGenerator/`)
- 3 Gradle projects for protocol test generation
- `smithy-dotnet-codegen` - Core protocol test generation logic
- `smithy-dotnet-codegen-test` - Test smithy models for validation
- `smithy-dotnet-protocol-test` - Output location for generated tests
- Uses Gradle wrapper (`./gradlew`) - no JDK dependency required
- Outputs to `sdk/test/ProtocolTests/Generated/<ProtocolName>/`
- Tests run via `AWSSDK.ProtocolTests.Net45.sln`

### Service Client Generator (`generator/ServiceClientGenerator/`)
- Main SDK code generator program
- Generates all service clients and model code
- Uses C2J model files and T4 templates
- Tested via `generator/ServiceClientGeneratorTests/`

### Generator Library (`generator/ServiceClientGeneratorLib/`)
- Helper *.cs files for Coral-to-JSON (C2J) model processing
- T4 templates (*.tt files) defining code generation patterns
- Each *.tt file has corresponding generated *.cs file
- Extensive customization engine via `Customizations.cs`
- Developers modify *.tt files and associated *.cs files for changes

### Service Models (`generator/ServiceModels/`)
- Coral-to-JSON (C2J) model files: `<servicePrefix>-YYYY-MM-DD.<type>.json`
- Generator uses `normal` type files (not `api` or `docs`)
- `metadata.json` per service contains service metadata
- Optional `<servicePrefix>.customizations.json` for generator customizations
- Updated during daily releases for shipped services

### Test Service Models (`generator/TestServiceModels/`)
- Test service models (never shipped)
- Generate like normal services for testing
- Models ending with `-client` used for Protocol Tests
- Updated manually (not via daily releases)
- Protocol test models downloaded from internal repository
- Located in `generator/TestServiceModels/<servicePrefix>/`

### Generated vs Custom Code
- **Generated**: Model classes, basic client operations, enumerations
- **Custom**: Complex logic, convenience methods, specialized handling
- Custom code in `Custom/` folders to avoid generation conflicts

## Key Patterns

### Service Client Pattern
```csharp
public partial class AmazonServiceNameClient : AmazonServiceClient, IAmazonServiceName
{
    // Generated methods for each service operation
    // Custom methods in Custom/ folder
}
```

### Request/Response Pattern
```csharp
public class OperationNameRequest : AmazonWebServiceRequest
{
    // Properties for operation parameters
}

public class OperationNameResponse : AmazonWebServiceResponse
{
    // Properties for operation results
}
```

### Pipeline Handler Pattern
```csharp
public class CustomHandler : PipelineHandler
{
    public override void InvokeSync(IExecutionContext executionContext)
    {
        // Custom logic
        base.InvokeSync(executionContext);
    }
}
```