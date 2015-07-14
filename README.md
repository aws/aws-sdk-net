# AWS SDK for .NET [![Build Status](https://travis-ci.org/aws/aws-sdk-net.png?branch=master)](https://travis-ci.org/aws/aws-sdk-net)

The **AWS SDK for .NET** enables .NET developers to easily work with [Amazon Web Services][aws] and build scalable solutions with Amazon S3, Amazon DynamoDB, Amazon Glacier, and more.

* [API Docs][docs-api]
* [AWS .NET Developer Blog][dotnet-blog]
* [SDK Homepage][sdk-website]
* [Forum][sdk-forum]
* [GitHub Issues][sdk-issues]
* [SDK Samples](https://github.com/awslabs/aws-sdk-net-samples)

## SDK Change Log

The change log for the SDK can be found in the [SDK.CHANGELOG.md](https://github.com/aws/aws-sdk-net/blob/master/SDK.CHANGELOG.md) file.

## Looking for Version 2?

In anticipation of the GA release for version 3 we have merged it to master. We did this before GA to signify that version 3 is ready for production use and to help us with some of the final release and build automation tasks we are working on.

To find the current version 2 source checkout the [version 2 branch][github-aws-sdk-net-v2].

## Modularization

With version 3 of the AWS SDK for .NET the SDK has been modularized. This means a separate NuGet package is created for each service as well as a core project. To use this branch compile the solution in the **sdk** folder that matches the desired platform and then include the assemblies for the services needed as well as the core assembly.

## Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK.IntegrationTests** project. These test assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK.UnitTests** project.

### Code Generator

All low-level service clients are created using the code generator found in the **generator** folder. The code generator 
uses the service models defined in the **generator\ServiceModels** folder.


[nuget-info]: https://nuget.org/
[aws]: http://aws.amazon.com/
[sdk-website]: http://aws.amazon.com/sdkfornet
[sdk-forum]: http://developer.amazonwebservices.com/connect/forum.jspa?forumID=61
[sdk-source]: https://github.com/aws/aws-sdk-net
[sdk-issues]: https://github.com/aws/aws-sdk-net/issues
[sdk-license]: http://aws.amazon.com/apache2.0/
[docs-api]: http://docs.aws.amazon.com/sdkfornet/latest/apidocs/Index.html
[docs-signup]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-roles.html
[docs-guide]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/welcome.html
[credentials-management]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-config-creds.html
[dotnet-blog]: http://blogs.aws.amazon.com/net/
[github-aws-sdk-net-v2]: https://github.com/aws/aws-sdk-net/tree/aws-sdk-net-v2
