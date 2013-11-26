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
'Install-Package AWSSDK -Pre'
``
1. **Using the SDK** - The best way to become familiar with how to use the SDK is to read the [Developer Guide][docs-guide].


[nuget-info]: https://nuget.org/
[sdk-zip]: https://aws-net-sdk.s3.amazonaws.com/preview/aws-sdk-for-dotnet-v2-preview.zip
[aws]: http://aws.amazon.com/
[sdk-website]: http://aws.amazon.com/sdkfornet
[sdk-forum]: http://developer.amazonwebservices.com/connect/forum.jspa?forumID=61
[sdk-issues]: https://github.com/aws/aws-sdk-net/issues
[sdk-license]: http://aws.amazon.com/apache2.0/
[docs-api]: http://aws-sdk-v2-preview-docs.s3-website-us-east-1.amazonaws.com/ 
[docs-signup]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-roles.html
[docs-guide]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-sdk-v2.html