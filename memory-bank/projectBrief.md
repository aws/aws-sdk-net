# Project Brief

## Introduction

AWS SDK for .NET is a collection of .NET assemblies most commonly acquired via NuGet packages to access AWS services from .NET applications. For users that don't have access to NuGet.org, the SDK assemblies are also available as zip files that can be downloaded from S3. The AWSSDK.Core .NET assembly contains all of the common logic like signers, credential providers, and request pipeline that controls the flow of requests being sent to AWS services. For each AWS service, there is a separate .NET assembly using the naming pattern AWSSDK.<service-name> that contains a service client that is used to access all of the APIs of a service.

## Platforms

SDK is built for the following target frameworks:

* .NET Framework 4.7.2
* .NET Standard 2.0
* .NET Core 3.1
* .NET 8

.NET Framework 4.7.2 and .NET Core 3.1 target framework can be used for newer versions of .NET Framework and .NET Core. For example, if a user is using .NET 6, the .NET Core 3.1 build of the SDK will be used.

.NET Standard 2.0 is a specification for .NET runtimes means this assembly can run on any platform that supports .NET Standard 2.0. For most use cases this target is skipped in favor of the .NET Core 3.1 target. This target is useful for uncommon platforms like Unity and Xamarin which use the older open source .NET runtime Mono. The Mono runtime is .NET Standard 2.0 compliant so Unity and Xamarin users can access AWS using the .NET Standard 2.0 target.

## Version History

The .NET SDK is currently on major version 4 (released on April 28th, 2025). Previous major versions include:

* Version 3 (released in 2015) - Modularized the SDK from a single .NET assembly into separate service-specific assemblies
* Version 2 - Unified AWS SDK experience
* Version 1 - Initial release

V4 represents the first major version update in 10 years and focuses on modernization, technical debt resolution, and performance improvements while maintaining the same programming model. The SDK strives to make as few breaking changes as possible between major versions, requiring little to no code changes when upgrading from V3 to V4.

## Release Status

V4 was released as GA on April 28th, 2025 after a year of development and 13 preview releases. It now follows the same release cadence as other GA AWS SDKs. V3 will continue to be supported with AWS service updates until AWS Tools for PowerShell V4 reaches GA, after which a 6-month support window begins. After this window, V3 will enter maintenance mode where only critical bugs and security issues will be addressed.

## Key Features

* Service clients for all AWS services
* Credential management and provider chain
* Request/response pipeline with customizable handlers
* Error handling and retry logic
* Asynchronous programming model
* High-level libraries for services like DynamoDB and S3
* OpenTelemetry integration for observability
* Native AOT support
* Bi-directional streaming over HTTP/2 (.NET 8+)
* Interface-based designs for testability
* Performance optimizations

## Design Philosophy

* Maintain backward compatibility where possible
* Provide consistent patterns across services
* Focus on performance and resource efficiency
* Enable testability and mockability
* Support modern .NET features and platforms
* Minimize external dependencies
* Provide both low-level and high-level APIs

## Migration Considerations

* Cannot mix V3 and V4 packages within an application
* All AWSSDK.* packages must be updated to 4.0.0 or greater
* Collection properties now default to null instead of empty collections
* Amazon.AWSConfigs.InitializeCollections property can be set to true for V3-like behavior
* Most applications require minimal changes after recompiling