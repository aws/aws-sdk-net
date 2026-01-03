# AWS SDK for .NET
The **AWS SDK for .NET** enables .NET developers to easily work with [Amazon Web Services](https://aws.amazon.com/) and build scalable solutions with Amazon S3, Amazon DynamoDB, Amazon Glacier, and more.

* [API Docs](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
* [AWS .NET Developer Blog](https://aws.amazon.com/blogs/developer/category/programing-language/dot-net/)
* [SDK Homepage](https://aws.amazon.com/sdk-for-net/)
* [SDK Developer Guide](https://docs.aws.amazon.com/sdk-for-net)
* [GitHub Issues](https://github.com/aws/aws-sdk-net/issues)
* [SDK Samples](https://github.com/awsdocs/aws-doc-sdk-examples/tree/main/dotnetv4)
* [NuGet Packages](https://www.nuget.org/profiles/awsdotnet)

## Getting Help

Please use these community resources for getting help. We use the [GitHub issues](https://github.com/aws/aws-sdk-net/issues) for tracking bugs and feature requests and have limited bandwidth to address them.
* Ask a question on [StackOverflow](http://stackoverflow.com/) and tag it with aws-sdk-net
* Open a support ticket with [AWS Support](https://console.aws.amazon.com/support/home)
* If it turns out that you may have found a bug, please open an [issue](https://github.com/aws/aws-sdk-net/issues)

### Opening Issues

If you encounter a bug with AWS SDK for .NET we would like to hear about it. Search the existing [issues](https://github.com/aws/aws-sdk-net/issues?q=is%3Aissue) and try to make sure your problem doesn’t already exist before opening a new issue. It’s helpful if you include the version of AWS SDK .NET and the OS you’re using. Please include a stack trace and reduced repro case when appropriate, too.

The [GitHub issues](https://github.com/aws/aws-sdk-net/issues) are intended for bug reports and feature requests. For help and questions with using AWS SDK for .NET please make use of the resources listed in the Getting Help section. There are limited resources available for handling issues and by keeping the list of open issues clean we can respond in a timely manner.

## SDK Change Log

The change log for the SDK can be found in the [SDK.CHANGELOG.ALL.md](https://github.com/aws/aws-sdk-net/blob/main/changelogs/SDK.CHANGELOG.ALL.md) file. Change logs divided up by year can be found in the [changelogs folder](https://github.com/aws/aws-sdk-net/tree/main/changelogs).

## Maintenance and support for SDK major versions

For information about maintenance and support for SDK major versions and their underlying dependencies, see the following in the AWS SDKs and Tools Shared Configuration and Credentials Reference Guide:

* [AWS SDKs and Tools Maintenance Policy](https://docs.aws.amazon.com/credref/latest/refdocs/maint-policy.html)
* [AWS SDKs and Tools Version Support Matrix](https://docs.aws.amazon.com/credref/latest/refdocs/version-support-matrix.html)

## Modularization

The AWS SDK for .NET the SDK is modularized. This means a separate NuGet package is created for each service as well as a core project. For example an application using Amazon S3 and Amazon SQS will use the AWSSDK.S3 and AWSSDK.SQS NuGet packages. Those packages will pull in the AWSSDK.Core dependency used by the service packages.

## Versioning

The AWS SDK for .NET uses a 4 part versioning scheme following the pattern of `w.x.y.z`. 

* **w** - Incremented for code breaking changes.
* **x** - Incremented for binary breaking changes. In particular this is used to identitfy what versions of AWSSDK.Core are binary compatible with the service packages. For example if AWSSDK.SQS version 3.3.1.0 came out today when the current version of AWSSDK.Core is 3.3.17.5 then AWSSDK.SQS 3.3.1.0 would be compatible with all versions of AWSSDK.Core starting from 3.3.17.5 up to but not including a future 3.4.0.0.
* **y** - Incremented for a new SDK feature, like new credential management, or an AWS service update.
* **z** - Incremented for a bug fix or for service packages to update to the latest AWSSDK.Core to pull in latest bug fixes.

The SDK assemblies are strongly named which requires consumers of the SDK to recompile every time the `AssemblyVersion` attribute is incremented. To avoid forced recompilations the `AssemblyVersion` only contains the `w.x` portion of the version. The full `w.x.y.z` version number is set in the `AssemblyFileVersion` attribute which is not part of the strong name.

### Internal Namespace

Classes and interfaces with `Internal` in the namespace name are logically internal to the SDK but are often marked with a `public` access modifier, generally to allow the service-specific packages to use shared functionality in the Core package. The [InternalsVisibleToAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.internalsvisibletoattribute) attribute is not used for this use case because that requires Core to know all possible services it will be used for at compile time. New service packages will be released needing access to the internal logic of core after a Core version has been released. 

Classes and interfaces in these namespaces are subject to modification or removal outside of versioning scheme described above. If you find yourself relying on `Internal` functionality directly, consider [opening a Feature Request](https://github.com/aws/aws-sdk-net/issues/new/choose) for your use case if one does not already exist.

## Code Analyzers

Each service package includes a code analyzer that's automatically included when installing from NuGet. These analyzers are created based on the rules from the service model, and will generate a warning if you use a property value that's not valid (for example, shorter than the minimum length expected by the service).

Starting with the 3.7.200 versions of the AWS SDK for .NET NuGet packages, the analyzers target [.NET Standard 2.0](https://learn.microsoft.com/en-us/dotnet/standard/net-standard) and support Visual Studio 2019 RTM and later (announcement: https://github.com/aws/aws-sdk-net/issues/2998).

Users on Visual Studio 2017 (or earlier) can still use new versions of the SDK, but there'll be a new warning (`CS8032`) about analyzers failing to run. If the build system is configured to treat warnings as errors, this new warning will need to be suppressed or ignored (using [WarningsNotAsErrors](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/errors-warnings#warningsaserrors-and-warningsnotaserrors)).

## Unity Support

Starting with version 3.5 of the AWS SDK for .NET, projects using Unity 2018.1 or later should target the .NET Standard 2.0 release of the SDK. You can find additional information in the developer guide: [Unity support](https://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/unity-special.html) and [Migrating your Unity application](https://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/net-dg-v35.html#net-dg-v35-changes-unity).

You can find the archive for _**legacy**_ Unity support at https://github.com/aws/aws-sdk-unity-net.

## Functionality requiring AWS Common Runtime (CRT)

This SDK has optional functionality that requires the [AWS Common Runtime (CRT)](https://docs.aws.amazon.com/sdkref/latest/guide/common-runtime.html)
bindings to be included as a dependency with your application. This functionality includes:
* [Amazon S3 Multi-Region Access Points](https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiRegionAccessPoints.html)
* [Amazon S3 Object Integrity](https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html)
* Amazon EventBridge Global Endpoints

If the required AWS Common Runtime components are not installed you will receive an error like `Attempting to make a request that requires an implementation of AWS Signature V4a. Add a reference to the AWSSDK.Extensions.CrtIntegration NuGet package to your project to include the AWS Signature V4a signer.`,
indicating that the required dependency is missing to use the associated functionality. To install this dependency follow
the provided [instructions](#installing-the-aws-common-runtime-crt-dependency).

### Installing the AWS Common Runtime (CRT) Dependency

Add a reference to the NuGet package [AWSSDK.Extensions.CrtIntegration](https://www.nuget.org/packages/AWSSDK.Extensions.CrtIntegration/) to your project.

## Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK.IntegrationTests** project. These test assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/creds-assign.html).

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK.UnitTests** project.

Protocol tests can be found in the `sdk/test/ProtocolTests` directory. Protocol tests ensure that each AWS protocol is working as expected. Each supported protocol is [listed here](https://smithy.io/2.0/aws/protocols/index.html). These tests are safe to run as they do not call real AWS services. You can run these tests by either opening the solution file and running the tests or via the `dotnet` cli by invoking `dotnet test AWSSDK.ProtocolTests.NetStandard.csproj`. The structure for the protocol test cases can be found [here in the smithy docs](https://smithy.io/2.0/additional-specs/http-protocol-compliance-tests.html).

## Code Generator

All low-level service clients are created using the code generator found in the **generator** folder. The code generator 
uses the service models defined in the **generator\ServiceModels** folder.
