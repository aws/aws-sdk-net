# Technical Context

## Technologies Used
- C# programming language
- .NET Framework 4.7.2
- .NET Standard 2.0
- .NET Core 3.1
- .NET 8
- NuGet package management
- MSBuild build system
- AWS service APIs
- Native AOT support
- OpenTelemetry for observability
- HTTP/2 for bi-directional streaming (.NET 8+)
- System.Text.Json for serialization

## Development Setup
- Visual Studio (primary IDE)
- .NET SDK
- AWS account for integration testing
- NuGet for package management
- Git for source control
- CI/CD pipeline for automated builds and testing

## Technical Constraints
- Backward compatibility requirements
- Cross-platform support
- Performance considerations for resource-constrained environments
- Security requirements for handling credentials
- Compliance with AWS service specifications
- Minimal external dependencies to avoid version conflicts

## Dependencies
- AWSSDK.Core (required by all service packages)
- Service-specific model dependencies
- AWS Common Runtime (CRT) for specific features:
  - SigV4a signing for S3 and EventBridge Multi-Region Access Points
  - CRC-32C checksums for S3 objects
- OpenTelemetry.Instrumentation.AWS for tracing and metrics
- System.Buffers, System.Memory, System.Text.Json (for .NET Framework 4.7.2 and .NET Standard 2.0)
- BouncyCastle.Cryptography (for specific cryptographic operations)

## Performance Optimizations in V4
- Reduced AWSSDK.Core assembly size (900KB vs 2MB in V3)
- Removed embedded JSON endpoint file
- Decreased memory allocations (1.3MB vs 2.4MB in benchmark tests)
- Improved startup performance (12-15% faster Lambda cold starts)
- Collections null by default to avoid unnecessary allocations
- Native AOT compatibility for AWSSDK.Extensions.NETCore.Setup
- S3 us-east-1 treated as regional-only endpoint for better performance
- DynamoDB Object Persistence library optimized to avoid background DescribeTable calls
- System.Text.Json for serialization with buffer pooling
- Generated endpoint resolution rules instead of parsing JSON file
- Always using EC2 IMDS v2 protocol for better security and performance

## Observability Features
- OpenTelemetry support
- Comprehensive tracing and metrics capabilities
- TelemetryProvider for custom implementations
- Reworked logging system with dedicated adaptor packages:
  - AWSSDK.Extensions.Logging.Log4NetAdaptor
  - AWSSDK.Extensions.Logging.ILoggerAdaptor
- Supported metrics for detailed performance monitoring

## Package Structure Changes in V4
- DynamoDB Streams moved to separate AWSSDK.DynamoDBStreams package
- Obsolete S3 encryption client removed from AWSSDK.S3
- Amazon.Extensions.S3.Encryption package as replacement for S3 encryption
- CloudFront signers moved to AWSSDK.Extensions.CloudFront.Signers
- EC2 password decryption moved to AWSSDK.Extensions.EC2.DecryptPassword
- Extension libraries updated for V4 compatibility and Native AOT support

## API Design Improvements in V4
- DynamoDBContext constructors obsoleted in favor of DynamoDBContextBuilder
- Generic DynamoDBOperationConfig replaced with operation-specific config objects
- Return types changed to interfaces for better mockability
- Builder patterns for complex object creation
- Interface-based designs for improved testability
- Consistent DateTime handling using UTC
- Polymorphism support for DynamoDB entries
- Bi-directional streaming support for services like Transcribe and Bedrock

## Versioning Strategy
- 4-part version scheme (W.X.Y.Z)
- W.X components kept in sync across all packages
- Y component for new features or service updates
- Z component for bug fixes
- AssemblyVersion matches AssemblyFileVersion in .NET Standard 2.0, .NET Core 3.1, and .NET 8
- AssemblyVersion locked to first 2 parts of AssemblyFileVersion in .NET Framework 4.7.2

## Configuration Options
- Amazon.AWSConfigs.InitializeCollections - Controls whether collections are initialized by default
- AWSConfigs.TelemetryProvider - Registration point for custom telemetry providers
- appsettings.json with intellisense support
- Environment variables for credentials and region
- Shared credentials file (~/.aws/credentials)
- AWS profiles