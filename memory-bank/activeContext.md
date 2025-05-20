# Active Context

## Current Focus
- AWS SDK for .NET V4 general availability (released April 28th, 2025)
- Supporting modern .NET platforms (.NET 8)
- Enhancing AWS Common Runtime (CRT) integration
- Improving performance and reducing memory usage
- Ensuring backward compatibility with previous versions
- Expanding observability capabilities with OpenTelemetry
- Updating extension libraries for V4 compatibility
- Improving testability and mockability
- Supporting bi-directional streaming over HTTP/2 for .NET 8+
- Assisting users with V3 to V4 migration

## Recent Changes
- Released V4 GA on April 28th, 2025 after 13 preview releases
- Added support for bi-directional streaming over HTTP/2 (.NET 8+)
- Upgraded minimum .NET Framework support to 4.7.2
- Removed legacy .NET Framework 3.5 support
- Reduced AWSSDK.Core assembly size from 2MB to 900KB
- Improved startup performance (12-15% faster Lambda cold starts)
- Reduced memory allocations (1.3MB vs 2.4MB in benchmark tests)
- Made AWSSDK.Extensions.NETCore.Setup Native AOT compatible
- Added intellisense support for configuration in appsettings.json
- Added OpenTelemetry support
- Introduced TelemetryProvider for custom observability implementations
- Moved DynamoDB Streams to its own package (AWSSDK.DynamoDBStreams)
- Enhanced DynamoDB Object Persistence library for better mockability
- Changed S3 us-east-1 behavior to regional-only endpoint
- Updated extension libraries for V4 compatibility and Native AOT support
- Switched to System.Text.Json for JSON serialization
- Implemented polymorphism support for DynamoDB entries
- Reworked logging system with dedicated adaptor packages

## Breaking Changes
- Changed value types to nullable value types in request/response classes
- Collections are now null by default instead of empty collections
- Moved DynamoDB Streams to separate package
- Changed S3 us-east-1 to regional-only endpoint
- Obsoleted DynamoDBContext constructors in favor of DynamoDBContextBuilder
- Replaced generic DynamoDBOperationConfig with operation-specific config objects
- Changed return types to interfaces for better mockability in DynamoDB libraries
- Removed obsolete S3 encryption client from AWSSDK.S3
- Removed IAM action identifiers from Amazon.Auth.AccessControlPolicy.ActionIdentifiers
- Changed DateTime handling to consistently use UTC
- Removed EC2 IMDS v1 protocol support (always using IMDS v2)
- Removed various obsolete classes and methods
- Changed RetryMode and DefaultConfigurationMode defaults to Standard
- Moved CloudFront signers and EC2 password decryption to separate packages

## Migration Guidance
- Cannot mix V3 and V4 packages within an application
- All AWSSDK.* packages must be updated to 4.0.0 or greater
- Add null checks before accessing collection properties
- Set Amazon.AWSConfigs.InitializeCollections to true for V3-like behavior
- Review the official migration guide for detailed instructions
- Recompile application code after updating packages

## V3 Support Timeline
- V3 will continue to receive AWS service updates for a limited time
- After AWS Tools for PowerShell V4 GA release, a 6-month support window begins
- After the 6-month window, V3 will enter maintenance mode
- In maintenance mode, only critical bugs and security issues will be addressed

## Active Decisions
- Maintaining same programming model while modernizing internals
- Balancing performance optimizations with backward compatibility
- Addressing technical debt through breaking changes where necessary
- Providing migration paths for breaking changes (e.g., InitializeCollections flag)
- Standardizing on OpenTelemetry for observability
- Supporting custom telemetry implementations via provider interfaces
- Improving testability through interface-based designs
- Treating S3 us-east-1 as regional-only endpoint for better performance
- Using System.Text.Json for serialization
- Consistent use of UTC for DateTime handling

## Important Patterns and Preferences
- Async-first approach for all I/O operations
- Consistent naming conventions across services
- Comprehensive XML documentation
- Defensive programming with appropriate validation
- Minimal external dependencies
- Thread-safe service clients
- Performance-focused design decisions
- Standardized observability metrics
- Interface-based designs for better testability
- Builder patterns for complex object creation
- Consistent DateTime handling using UTC