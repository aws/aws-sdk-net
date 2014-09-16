# AWS SDK for .NET [![Build Status](https://travis-ci.org/aws/aws-sdk-net.png?branch=master)](https://travis-ci.org/aws/aws-sdk-net)

The **AWS SDK for .NET** enables .NET developers to easily work with [Amazon Web Services][aws] and build scalable solutions with Amazon S3, Amazon DynamoDB, Amazon Glacier, and more. You can get started in minutes using [NuGet][nuget-info] or by downloading the [AWS SDK for .NET preview zip file][sdk-zip].

* [API Docs][docs-api]
* [SDK Homepage][sdk-website]
* [Forum][sdk-forum]
* [GitHub Issues][sdk-issues]

## Features

* Provides easy-to-use HTTP clients for all supported AWS services, regions, and authentication protocols.
* Amazon DynamoDB Object Persistence Framework - Uses Plain Old C# Objects (POCOs) to store and retrieve Amazon DynamoDB data.
* Amazon S3 Transfer Utility - With a simple API, achieves enhanced throughput, performance, and reliability by using multi-threaded Amazon S3 multi-part calls.
* Amazon Glacier ArchiveTransferManager - Eases transferring data to and from Amazon Glacier by automatically dividing large files into parts and by computing check sums.
* Automatically uses [IAM Instance Profile Credentials][aws-iam-credentials] on configured Amazon EC2 instances.
* Support for Windows Store and Windows Phone apps.
* And more!

## Getting Started

1. **Sign up for AWS** - Before you begin, you need an AWS account. Please see the [AWS Account and Credentials][docs-signup] section of the developer guide for information about how to create an AWS account and retrieve your AWS credentials.
1. **Minimum requirements** - To run the SDK you need the **Microsoft .NET Framework 3.5 or later**. For more information about the requirements and optimum settings for the SDK, please see the [.NET Development Environment][docs-signup] section of the developer guide.
1. **Install the SDK** - Using [NuGet][nuget-info] is the easiest way to add the AWS SDK for .NET to a Visual Studio project.  Simply type the following in the Package Manager Console: 
`` 
'Install-Package AWSSDK'
``
1. **Using the SDK** - The best way to become familiar with how to use the SDK is to read the [Developer Guide][docs-guide].

## Source Layout

### Solutions

There are 2 main solutions used for the development of the SDK. **AWSSDK_DotNet.Core.sln** is used to develop the .NET 3.5 and .NET 4.5 
version of the SDK. The **AWSSDK_DotNet.Mobile.sln** is used for windows store and windows phone versions of the SDK. 
Windows 8.1 or Windows Server 2012 R2 is required to build this solution.

### Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK_DotNet.IntegrationTests** project. These test assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK_DotNet.UnitTests** project.

### Code Generator

All low-level service clients are created using the code generator found in the **ServiceClientGenerator** folder. The code generator 
uses the service models defined in the **ServiceModels** folder. The easiest way to run the code generator is to set the ServiceClientGenerator as
the startup project in the **AWSSDK_DotNet.Core.sln** solution.


[nuget-info]: https://nuget.org/
[aws]: http://aws.amazon.com/
[sdk-website]: http://aws.amazon.com/sdkfornet
[sdk-forum]: http://developer.amazonwebservices.com/connect/forum.jspa?forumID=61
[sdk-issues]: https://github.com/aws/aws-sdk-net/issues
[sdk-license]: http://aws.amazon.com/apache2.0/
[docs-api]: http://docs.aws.amazon.com/sdkfornet/latest/apidocs/Index.html
[docs-signup]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-roles.html
[docs-guide]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/welcome.html
[credentials-management]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-config-creds.html
