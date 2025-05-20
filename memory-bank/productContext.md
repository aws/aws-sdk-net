# Product Context

## Purpose
AWS SDK for .NET enables .NET developers to seamlessly integrate AWS services into their applications. It abstracts the complexity of AWS API interactions, authentication, and request handling.

## Problems Solved
- Eliminates manual HTTP request construction to AWS services
- Handles authentication and signing of AWS requests
- Manages retry logic and error handling
- Provides strongly-typed interfaces for AWS services
- Enables offline development through NuGet packages or downloadable assemblies

## User Experience Goals
- Simple, intuitive API surface
- Consistent patterns across all AWS services
- Minimal configuration for common scenarios
- Flexible customization for advanced use cases
- Comprehensive documentation and examples
- Performance optimized for different .NET platforms

## Target Users
- .NET developers building applications on AWS
- Enterprise customers with .NET workloads
- Startups using .NET technology stack
- Systems integrators connecting .NET applications to AWS
- Developers in environments with limited internet access (offline package usage)

## Distribution Channels
- NuGet.org (primary)
- Downloadable zip archives from S3 (for air-gapped environments)