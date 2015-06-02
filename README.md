## Obsolete Branch ##

This branch is obsolete since all changes have been pushed to [master][github-master].

# AWS SDK for .NET (Modularization)

The **AWS SDK for .NET** enables .NET developers to easily work with [Amazon Web Services][aws] and build scalable solutions with Amazon S3, Amazon DynamoDB, Amazon Glacier, and more.

* [API Docs][docs-api]
* [AWS .NET Developer Blog][dotnet-blog]
* [SDK Homepage][sdk-website]
* [Forum][sdk-forum]
* [GitHub Issues][sdk-issues]

## Modularization

This branch is a preview of our work to modularize the SDK. Separate projects are created for each service as well as a core project. To use this branch compile the solution in the **sdk** folder that matches the desired platform and then include the assemblies for the services needed as well as the core assembly.

## Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK_DotNet.IntegrationTests** project. These test assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK_DotNet.UnitTests** project.

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
[github-master]: https://github.com/aws/aws-sdk-net/tree/master
