# Repository Overview

## What the SDK is

AWS SDK for .NET is a collection of .NET assemblies for accessing AWS services. `AWSSDK.Core` contains shared logic (signers, credential providers, request pipeline). Each service has its own assembly following the `AWSSDK.<ServiceName>` naming pattern.

## Target frameworks

Defined in `sdk/Directory.Build.props` (`SdkNetFrameworkTargets`, `SdkNetTargets`). .NET Standard 2.0 covers Mono-based platforms (Unity, Xamarin). The .NET Framework 4.7.2 and .NET Core 3.1 builds are used on newer runtimes too — e.g. a .NET 6 app uses the .NET Core 3.1 (netcoreapp3.1) build.

## Version history

- **V4** — current. See [What's new in V4](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-v4.html) for the full list of changes.
- **V3** — end of life. See [end-of-support announcement](https://aws.amazon.com/blogs/developer/aws-sdk-for-net-v3-end-of-support-announcement/).
- **V2** — Unified AWS SDK experience.
- **V1** — Initial release.

## Critical constraint: V3 and V4 are not mixable

You cannot mix V3 and V4 packages in the same application. All `AWSSDK.*` packages must be on 4.0.0 or greater together. There is no partial upgrade path.

## Key V4 behavioral change

- Collection properties default to `null` instead of empty collections (`Amazon.AWSConfigs.InitializeCollections = true` restores V3 behavior). See `technical-context.md` for the full list of V4 behavior changes.
