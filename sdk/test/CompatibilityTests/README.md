# AWS SDK .NET Compatibility Tests

This project tests compatibility between newer versions of AWSSDK.Core and older service package DLLs to catch issues like missing methods (e.g., `get_ServiceFullName`) that occur when mixing package versions.

## Problem

When users mix an older service package with a newer version of Core, they can receive exceptions like:

```
System.TypeLoadException: Method 'get_ServiceFullName' in type 
'Amazon.SimpleSystemsManagement.Internal.AmazonSimpleSystemsManagementMetadata' 
from assembly 'AWSSDK.SimpleSystemsManagement, Version=4.0.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604' 
does not have an implementation.
```

See: https://github.com/aws/aws-sdk-net/issues/4276

## Solution

This test project addresses the issue by:

1. **Pre-build DLL Download**: A PowerShell script (`DownloadDlls.ps1`) automatically downloads older AWS SDK DLLs from the official distribution before building
2. **Reference new core**: The csproj directly references the downloaded DLLs and the newer core.
3. **Direct Type Instantiation**: Tests directly instantiate service clients (e.g., `new AmazonS3Client()`), forcing the CLR to verify all required methods exist at load time

## How It Works

### 1. Pre-build Download

The `CompatibilityTests.csproj` includes a pre-build target that runs before compilation:

```xml
<Target Name="DownloadAwsSdkDlls" BeforeTargets="BeforeBuild">
  <Exec Command="powershell -ExecutionPolicy Bypass -File &quot;$(MSBuildProjectDirectory)\DownloadDlls.ps1&quot;" 
        Condition="!Exists('$(DownloadedDllsPath)\AWSSDK.S3.dll')" />
</Target>
```

### 2. DLL References

The project references the downloaded DLLs directly:

```xml
<Reference Include="AWSSDK.S3" Condition="Exists('$(DownloadedDllsPath)\AWSSDK.S3.dll')">
  <HintPath>$(DownloadedDllsPath)\AWSSDK.S3.dll</HintPath>
  <Private>false</Private>
</Reference>
```

### 3. Direct Instantiation

Tests directly create service clients, triggering CLR type checking:

```csharp
var ssmClient = new AmazonSimpleSystemsManagementClient();
```

If the old service DLL is missing required methods from the newer Core, the CLR throws `TypeLoadException` at instantiation time.

## Running the Tests

```bash
# Build (will auto-download DLLs if needed)
dotnet build

# Run tests
dotnet test
```

## Cleaning Up

To re-download the DLLs:

```bash
# Delete the downloaded DLLs folder
Remove-Item -Recurse -Force DownloadedDlls

# Rebuild (will trigger download)
dotnet build
```

## Services Tested

- S3
- DynamoDB
- SQS  
- Bedrock Runtime
- Simple Systems Management (SSM) - The service from the original issue

## Adding More Services

To test additional services:

1. Add a DLL reference in `CompatibilityTests.csproj`
2. Add the using statement in `CompatibilityTests.cs`
3. Create a test method that instantiates the client

Example:

```xml
<Reference Include="AWSSDK.Lambda" Condition="Exists('$(DownloadedDllsPath)\AWSSDK.Lambda.dll')">
  <HintPath>$(DownloadedDllsPath)\AWSSDK.Lambda.dll</HintPath>
  <Private>false</Private>
</Reference>
```

```csharp
using Amazon.Lambda;

[Fact]
public void TestLambdaClientCreation()
{
    var exception = Record.Exception(() =>
    {
        var lambdaClient = new AmazonLambdaClient();
        Assert.NotNull(lambdaClient);
    });

    if (exception != null)
    {
        throw exception;
    }
}