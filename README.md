# AWS SDK for .NET - Preview for Resource APIs

This is the preview release of AWS Resource APIs for .NET. This branch contains the source for the AWS SDK for .NET (branched from version 2.3.13.1) along with the new resource APIs. This release contains resource APIs for AWS Identity and Access Management (IAM); support for other services will be added in the near future. The preview is intended to provide early access to the new APIs and to get feedback from the community. For more information about the resource APIs, check the [developer guide][docs-guide] and the introductory [blog post][blog-post].

**Important:** The resource APIs in the AWS SDK for .NET are currently provided as a preview. This means that these APIs may frequently change—including possible breaking changes—without advance notice. Until the resource APIs in the AWS SDK for .NET exit the preview stage, please be cautious about writing and distributing production-quality code that relies on these resource APIs.

**Sample code demonstrating the resource APIs**

```C#
	// Create a service object for IAM
	// Credentials are picked up from app.config
	var iam = new IdentityManagementService();           
	 
	// Get a group by its name
	var adminGroup = iam.GetGroupByName("admins");
	 
	// List all users in the admins group       
	// GetUsers method supports auto pagination
	foreach (var user in adminGroup.GetUsers())
	{
		Console.WriteLine(user.Name);
	}
	 
	// Create a new user and add the user to the admins group
	var userA= iam.CreateUser("Alice");
	adminGroup.AddUser(userA.Name);
```

* [API Docs][docs-api]
* [Developer Guide] [docs-guide]
 * [IAM Resource API examples][docs-iam-examples]
* [SDK Homepage][sdk-website]
* [Forum][sdk-forum]
* [GitHub Issues][sdk-issues]

## Features

* Brand new high level object oriented APIs to work with AWS based resources. Resource APIs for AWS Identity and Access Management (IAM) are available in this release; support for other services will be added in near future.
* Write less code - The new API has features like simplified method overloads and inferring identifier parameters, this allows you to write less code to achieve the same results as compared to the request-response style low level API.
* Auto pagination for operations that support paging - The resource APIs will make multiple service calls for APIs that support paging as you enumerate through the results. You do not have to write additional code to make multiple service calls and to capture/resend pagination tokens.

## Getting Started

1. **Sign up for AWS** - Before you begin, you need an AWS account. Please see the [AWS Account and Credentials][docs-signup] section of the developer guide for information about how to create an AWS account and retrieve your AWS credentials.
1. **Minimum requirements** - The resource APIs are supported on **Microsoft .NET Framework 3.5 and Microsoft .NET Framework 4.5**. 
1. **Download the binaries** - The easiest way to get started is to download the [binaries][sdk-binaries] and reference them in your .NET project. If your project already references AWSSDK.dll, you must remove the existing reference before adding the new one.
1. **Using the SDK** - The [developer guide][docs-guide] and this [blog post][blog-post] provide more information about the resource APIs.

## Source Layout

### Solutions

There are 2 main solutions used for the development of the SDK. **AWSSDK_DotNet.Core.sln** is used to develop the .NET 3.5 and .NET 4.5 
version of the SDK, the resource APIs are supported on these platforms. The **AWSSDK_DotNet.Mobile.sln** is used for Windows Store and Windows Phone versions of the SDK. 
Windows 8.1 or Windows Server 2012 R2 is required to build this solution.

### Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK_DotNet.IntegrationTests** project. These tests assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges incurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK_DotNet.UnitTests** project.

### Code Generator

All low-level service clients are created using the code generator found in the **ServiceClientGenerator** folder. The code generator 
uses the service models defined in the **ServiceModels** folder. The easiest way to run the code generator is to set the ServiceClientGenerator as
the startup project in the **AWSSDK_DotNet.Core.sln** solution.

[aws]: http://aws.amazon.com/
[sdk-binaries]: https://github.com/aws/aws-sdk-net/tree/resourceAPI-preview/binaries
[blog-post]: http://blogs.aws.amazon.com/net/post/Tx3TUYIZ1KAW7PI/Preview-release-of-AWS-Resource-APIs-for-NET
[sdk-website]: http://aws.amazon.com/sdkfornet
[sdk-forum]: http://developer.amazonwebservices.com/connect/forum.jspa?forumID=61
[sdk-source]: https://github.com/aws/aws-sdk-net/tree/resourceAPI-preview
[sdk-issues]: https://github.com/aws/aws-sdk-net/issues
[sdk-license]: http://aws.amazon.com/apache2.0/
[docs-api]: http://aws-net-resources-preview-docs.s3-website-us-east-1.amazonaws.com/Index.html?page=NIAM_Resources_NET4_5.html&tocid=Amazon_IdentityManagement_Resources
[docs-signup]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-roles.html
[docs-guide]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/resource-level-apis-intro.html
[docs-iam-examples]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/iam-resource-api-examples.html
[credentials-management]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-config-creds.html
