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
- RPCv2 CBOR protocol (for services that support it)

## Development Setup
- Visual Studio (primary IDE)
- .NET SDK
- AWS account for integration testing
- NuGet for package management
- Git for source control
- CI/CD pipeline for automated builds and testing

### Generator Tooling
- Java/Gradle for Protocol Test Generator (uses gradlew wrapper)
- T4 Text Templates for service code generation
- Coral-to-JSON (C2J) model files for service definitions
- Smithy models for protocol test generation
- Custom MSBuild tasks in buildtools/

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
- Optional consumer-supplied OpenTelemetry integration (for example, OpenTelemetry.Instrumentation.AWS) for tracing and metrics
- System.Buffers, System.Memory, System.Text.Json (for .NET Framework 4.7.2 and .NET Standard 2.0)
- BouncyCastle.Cryptography (for specific cryptographic operations)

### Build Dependencies
- Gradle wrapper for Protocol Test Generator
- T4 Text Template engine for code generation
- MSBuild for .NET compilation
- Custom build tools in buildtools/ directory

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

## Notable Extension Packages

- **Extensions.Bedrock.MEAI** (`AWSSDK.Extensions.Bedrock.MEAI`) — Microsoft.Extensions.AI (`IChatClient`) integration for Amazon Bedrock. Supports prompt caching, structured JSON responses via JSON Schema, and multi-modal tool returns.
- **Extensions.CborProtocol** — RPCv2 CBOR protocol support. Pulled in automatically by service packages that support the protocol.
- **Extensions.CrtIntegration** — AWS Common Runtime integration for SigV4a signing and CRC-32C checksums.
- **Extensions.CloudFront.Signers** — CloudFront URL and cookie signing. Supports RSA and ECDSA private keys.
- **Extensions.NETCore.Setup** — ASP.NET Core / `IServiceCollection` integration for SDK clients.

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
- `Amazon.AWSConfigs.InitializeCollections` — Controls whether collections are initialized by default (set to `true` to restore V3 behavior)
- `AWSConfigs.TelemetryProvider` — Registration point for custom telemetry providers
- `AWSConfigs.DisableLegacyPersistenceStore` — Instructs the SDK not to use the SDK Store in its default profile resolution search
- `ClientConfig.MaxStaleConnectionRetries` — Customize retries for stale connections; stale connection retries do not count against the standard retry budget
- Auth scheme preference — Configure authentication scheme priority (e.g., prioritize SigV4a over SigV4 when both are supported)
- appsettings.json with IntelliSense support
- Environment variables for credentials and region
- Shared credentials file (~/.aws/credentials)
- AWS profiles

# System Patterns

## Architecture
- Service client pattern for each AWS service
- Request/response model for all API calls
- Pipeline architecture for request processing
- Credential provider chain for authentication
- Configuration providers for settings management
- Telemetry providers for observability
- Builder patterns for complex object creation
- Interface-based designs for testability

## Key Technical Decisions
- Separate assembly per AWS service (modularized in V3)
- Common core functionality in AWSSDK.Core
- Platform-specific optimizations via target frameworks
- Asynchronous operations using Task-based APIs
- Strong typing for all service models
- Nullable value types for request/response properties in V4
- Collections null by default in V4
- OpenTelemetry integration for observability
- Interface-based designs for testability
- S3 us-east-1 as regional-only endpoint
- System.Text.Json for serialization
- Consistent DateTime handling using UTC
- EC2 IMDS v2 protocol only

## Design Patterns
- Factory pattern for client creation
- Builder pattern for request construction and complex objects
- Chain of responsibility for credential providers
- Strategy pattern for configuration
- Observer pattern for logging and metrics
- Provider pattern for telemetry implementations
- Interface-based design for mockability
- Polymorphism support for DynamoDB entries

## Component Relationships
```text
┌─────────────────┐     ┌──────────────────┐
│  Service Client │────▶│ Request Pipeline │
└─────────────────┘     └──────────────────┘
        │                        │
        ▼                        ▼
┌─────────────────┐     ┌──────────────────┐
│ Request Objects │     │   HTTP Handler   │
└─────────────────┘     └──────────────────┘
                                │
┌─────────────────┐             ▼
│    Response     │◀────┐──────────────────┐
│    Handlers     │     │   AWS Service    │
└─────────────────┘     └──────────────────┘
```

## Request Pipeline
The request pipeline breaks the request process into individual stages implemented as handlers:
1. MetricsHandler - Collects metrics about requests
2. Marshaller - Converts request objects to HTTP format
3. EndpointResolver - Determines service endpoint (optimized in V4)
4. RetryHandler - Manages retry logic for failed requests
5. CredentialsRetriever - Obtains AWS credentials
6. EndpointDiscoveryHandler - Handles endpoint discovery
7. Signer - Signs requests with AWS credentials
8. ErrorHandler - Processes service errors
9. Unmarshaller - Converts HTTP responses to response objects

## High-Level Libraries
- DynamoDB Object Persistence (Amazon.DynamoDBv2.DataModel)
  - Maps .NET types to DynamoDB items
  - Uses DynamoDBContextBuilder for initialization
  - Operation-specific configuration objects
  - Interface-based design for mockability
  - Polymorphism support for inheritance hierarchies
- DynamoDB Document Model (Amazon.DynamoDBv2.DocumentModel)
  - Interface-based design (ITable, IDocumentBatchWrite, IDocumentBatchGet)
  - Improved testability
  - System.Text.Json for Document serialization
- S3 Encryption (Amazon.Extensions.S3.Encryption)
  - Moved from AWSSDK.S3 to separate package
  - Full compatibility with removed S3 encryption client

## Bi-directional Streaming
- Support for HTTP/2 streaming in .NET 8+
- Enables real-time communication with AWS services
- Used by services like:
  - Amazon Transcribe Streaming
  - Amazon Bedrock (Nova Sonics speech-to-speech)
- Not available in .NET Framework due to HTTP/2 limitations

## Observability Architecture
- TelemetryProvider as central registration point
- TracerProvider interface for custom tracing implementations
- MeterProvider interface for custom metrics implementations
- OpenTelemetry integration via OpenTelemetry.Instrumentation.AWS
- Automatic instrumentation of AWS SDK operations
- Comprehensive metrics collection for performance monitoring
- Dedicated logging adaptor packages for different logging frameworks

## Critical Implementation Paths
1. Authentication and request signing
2. Serialization/deserialization of requests/responses
3. Retry handling and backoff strategies
4. Error handling and exception mapping
5. Credential management and rotation
6. Telemetry data collection and export
7. S3 regional endpoint resolution
8. DateTime handling and conversion

## Cross-cutting Concerns
- Logging (via adaptor packages)
- Metrics collection
- Tracing (AWS X-Ray, OpenTelemetry)
- Error handling
- Configuration management
- Performance optimization
- Observability
- Testability
- DateTime handling
