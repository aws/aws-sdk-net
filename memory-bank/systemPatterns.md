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
```
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

## V4 Performance Optimizations
- Removed embedded JSON endpoint file from request pipeline
- Reduced memory allocations by making collections null by default
- Improved startup time by optimizing initial request processing
- Decreased assembly size by removing unnecessary components
- Enhanced Native AOT compatibility
- S3 us-east-1 treated as regional-only endpoint to avoid double requests
- DynamoDB Object Persistence optimized to avoid background DescribeTable calls
- System.Text.Json for serialization with buffer pooling
- Always using EC2 IMDS v2 protocol
- Consistent DateTime handling using UTC

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