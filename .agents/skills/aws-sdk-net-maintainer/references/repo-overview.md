# Repository Overview

## What the SDK is

AWS SDK for .NET is a collection of .NET assemblies for accessing AWS services. `AWSSDK.Core` contains shared logic (signers, credential providers, request pipeline). Each service has its own assembly following the `AWSSDK.<ServiceName>` naming pattern.

## Target frameworks

- .NET Framework 4.7.2
- .NET Standard 2.0 (for Mono-based platforms like Unity and Xamarin)
- .NET Core 3.1
- .NET 8

.NET Framework 4.7.2 and .NET Core 3.1 target frameworks can be used for newer versions of .NET Framework and .NET Core. For example, if a user is using .NET 6, the .NET Core 3.1 build of the SDK will be used.

## Version history

- **V4** — GA on April 28, 2025. First major version update in 10 years. Focuses on modernization, performance, and technical debt while maintaining the same programming model. See [What's new in V4](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-v4.html) for the full list of changes.
- **V3** — Released 2015. Modularized the SDK into separate service assemblies. Entered maintenance mode on March 1, 2026 (critical bugs and security issues only). See [announcement](https://aws.amazon.com/blogs/developer/aws-sdk-for-net-v3-maintenance-mode-announcement/).
- **V2** — Unified AWS SDK experience.
- **V1** — Initial release.

## Critical constraint: V3 and V4 are not mixable

You cannot mix V3 and V4 packages in the same application. All `AWSSDK.*` packages must be on 4.0.0 or greater together. There is no partial upgrade path.

## Key V4 behavioral changes

- Collection properties default to `null` instead of empty collections (`Amazon.AWSConfigs.InitializeCollections = true` restores V3 behavior)
- Most applications require only a recompile after updating package versions
