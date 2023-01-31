# AWS SDK for .NET [![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/aws/aws-sdk-net?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
The **AWS SDK for .NET** enables .NET developers to easily work with [Amazon Web Services][aws] and build scalable solutions with Amazon S3, Amazon DynamoDB, Amazon Glacier, and more.

* [API Docs][docs-api]
* [AWS .NET Developer Blog][dotnet-blog]
* [SDK Homepage][sdk-website]
* [SDK Developer Guide](https://docs.aws.amazon.com/sdk-for-net)
* [Forum][sdk-forum]
* [GitHub Issues][sdk-issues]
* [SDK Samples](https://github.com/awsdocs/aws-doc-sdk-examples/tree/main/dotnetv3)

## Getting Help

Please use these community resources for getting help. We use the [GitHub issues][sdk-issues] for tracking bugs and feature requests and have limited bandwidth to address them.
* Ask a question on [StackOverflow](http://stackoverflow.com/) and tag it with aws-sdk-net
* Come join the AWS .NET community chat on [gitter](https://gitter.im/aws/aws-sdk-net)
* Open a support ticket with [AWS Support](https://console.aws.amazon.com/support/home)
* If it turns out that you may have found a bug, please open an [issue][sdk-issues]

### Opening Issues

If you encounter a bug with AWS SDK for .NET we would like to hear about it. Search the existing [issues](https://github.com/aws/aws-sdk-net/issues?q=is%3Aissue) and try to make sure your problem doesn’t already exist before opening a new issue. It’s helpful if you include the version of AWS SDK .NET and the OS you’re using. Please include a stack trace and reduced repro case when appropriate, too.

The [GitHub issues][sdk-issues] are intended for bug reports and feature requests. For help and questions with using AWS SDK for .NET please make use of the resources listed in the Getting Help section. There are limited resources available for handling issues and by keeping the list of open issues clean we can respond in a timely manner.

## SDK Change Log

The change log for the SDK can be found in the [SDK.CHANGELOG.md](https://github.com/aws/aws-sdk-net/blob/master/SDK.CHANGELOG.md) file.

## Maintenance and support for SDK major versions

For information about maintenance and support for SDK major versions and their underlying dependencies, see the following in the AWS SDKs and Tools Shared Configuration and Credentials Reference Guide:

* [AWS SDKs and Tools Maintenance Policy](https://docs.aws.amazon.com/credref/latest/refdocs/maint-policy.html)
* [AWS SDKs and Tools Version Support Matrix](https://docs.aws.amazon.com/credref/latest/refdocs/version-support-matrix.html)

## Looking for Version 2?

In anticipation of the GA release for version 3 we have merged it to master. We did this before GA to signify that version 3 is ready for production use and to help us with some of the final release and build automation tasks we are working on.

To find the current version 2 source checkout the [version 2 branch][github-aws-sdk-net-v2].

## Modularization

With version 3 of the AWS SDK for .NET the SDK has been modularized. This means a separate NuGet package is created for each service as well as a core project. To use this branch compile the solution in the **sdk** folder that matches the desired platform and then include the assemblies for the services needed as well as the core assembly.

## Versioning

The AWS SDK for .NET uses a 4 part versioning scheme following the pattern of `w.x.y.z`. 

* **w** - Incremented for code breaking changes.
* **x** - Incremented for binary breaking changes. In particular this is used to identitfy what versions of AWSSDK.Core are binary compatible with the service packages. For example if AWSSDK.SQS version 3.3.1.0 came out today when the current version of AWSSDK.Core is 3.3.17.5 then AWSSDK.SQS 3.3.1.0 would be compatible with all versions of AWSSDK.Core starting from 3.3.17.5 up to but not including a future 3.4.0.0.
* **y** - Incremented for a new SDK feature, like new credential management, or an AWS service update.
* **z** - Incremented for a bug fix or for service packages to update to the latest AWSSDK.Core to pull in latest bug fixes.

The SDK assemblies are strongly named which requires consumers of the SDK to recompile every time the `AssemblyVersion` attribute is incremented. To avoid forced recompilations the `AssemblyVersion` only contains the `w.x` portion of the version. The full `w.x.y.z` version number is set in the `AssemblyFileVersion` attribute which is not part of the strong name.

### Internal Namespace

Classes and interfaces with `Internal` in the namespace name are logically internal to the SDK but are often marked with a `public` access modifier, generally to allow the service-specific packages to use shared functionality in the Core package. Classes and interfaces in these namespaces are subject to modification or removal outside of versioning scheme described above. If you find yourself relying on `Internal` functionality directly, consider [opening a Feature Request](https://github.com/aws/aws-sdk-net/issues/new/choose) for your use case if one does not already exist.

## Portable Class Library

This release of the AWS SDK for .NET adds support for Portable Class Library projects, which allow you to target multiple platforms including Windows Store, Windows Phone, and Xamarin on iOS and Android. More information on this can be found [here](http://docs.aws.amazon.com/mobile/sdkforxamarin/developerguide/index.html).

## Unity Support

Starting with version 3.5 of the AWS SDK for .NET, projects using Unity 2018.1 or later should target the .NET Standard 2.0 release of the SDK. You can find additional information in the developer guide: [Unity support](https://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/unity-special.html) and [Migrating your Unity application](https://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/net-dg-v35.html#net-dg-v35-changes-unity).

You can find the archive for _**legacy**_ Unity support at https://github.com/aws/aws-sdk-unity-net.

### Silverlight support

Due to Silverlight HTTP Caching, AWS SDK for .NET is not fully supported on Silverlight-based platforms such as Windows Phone 8.0. Some HTTP GET calls (such as S3's ListBuckets or ListObjects) will return the same results when called multiple times.

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
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK.UnitTests** project.

### NuGet Packages

* [AWSSDK.AccessAnalyzer](https://www.nuget.org/packages/AWSSDK.AccessAnalyzer/)
	* Introducing AWS IAM Access Analyzer, an IAM feature that makes it easy for AWS customers to ensure that their resource-based policies provide only the intended access to resources outside their AWS accounts.
* [AWSSDK.Account](https://www.nuget.org/packages/AWSSDK.Account/)
	* This release of the Account Management API enables customers to manage the alternate contacts for their AWS accounts. For more information, see https://docs.aws.amazon.com/accounts/latest/reference/accounts-welcome.html
* [AWSSDK.ACMPCA](https://www.nuget.org/packages/AWSSDK.ACMPCA/)
	* AWS Certificate Manager (ACM) Private Certificate Authority (CA) is a managed private CA service that helps you easily and securely manage the lifecycle of your private certificates. ACM Private CA provides you a highly-available private CA service without the upfront investment and ongoing maintenance costs of operating your own private CA. ACM Private CA extends ACM's certificate management capabilities to private certificates, enabling you to manage public and private certificates centrally.
* [AWSSDK.AlexaForBusiness](https://www.nuget.org/packages/AWSSDK.AlexaForBusiness/)
	* Alexa for Business is now generally available for production use. Alexa for Business makes it easy for you to use Alexa in your organization. The Alexa for Business SDK gives you APIs to manage Alexa devices, enroll users, and assign skills at scale. For more information about Alexa for Business, go to https://aws.amazon.com/alexaforbusiness
* [AWSSDK.Amplify](https://www.nuget.org/packages/AWSSDK.Amplify/)
	* Amplify is a fully managed continuous deployment and hosting service for modern web apps.
* [AWSSDK.AmplifyBackend](https://www.nuget.org/packages/AWSSDK.AmplifyBackend/)
	* (New Service) The Amplify Admin UI offers an accessible way to develop app backends and manage app content. We recommend that you use the Amplify Admin UI to manage the backend of your Amplify app.
* [AWSSDK.AmplifyUIBuilder](https://www.nuget.org/packages/AWSSDK.AmplifyUIBuilder/)
	* This release introduces the actions and data types for the new Amplify UI Builder API. The Amplify UI Builder API provides a programmatic interface for creating and configuring user interface (UI) component libraries and themes for use in Amplify applications.
* [AWSSDK.APIGateway](https://www.nuget.org/packages/AWSSDK.APIGateway/)
	* Amazon API Gateway helps developers deliver robust, secure and scalable mobile and web application backends. Amazon API Gateway allows developers to securely connect mobile and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly addressable web services that are hosted outside of AWS.
* [AWSSDK.ApiGatewayManagementApi](https://www.nuget.org/packages/AWSSDK.ApiGatewayManagementApi/)
	* This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.
* [AWSSDK.ApiGatewayV2](https://www.nuget.org/packages/AWSSDK.ApiGatewayV2/)
	* This is the initial SDK release for the Amazon API Gateway v2 APIs. This SDK will allow you to manage and configure APIs in Amazon API Gateway; this first release provides the capabilities that allow you to programmatically setup and manage WebSocket APIs end to end.
* [AWSSDK.AppConfig](https://www.nuget.org/packages/AWSSDK.AppConfig/)
	* Introducing AWS AppConfig, a new service that enables customers to quickly deploy validated configurations to applications of any size in a controlled and monitored fashion.
* [AWSSDK.AppConfigData](https://www.nuget.org/packages/AWSSDK.AppConfigData/)
	* AWS AppConfig Data is a new service that allows you to retrieve configuration deployed by AWS AppConfig. See the AppConfig user guide for more details on getting started. https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html
* [AWSSDK.Appflow](https://www.nuget.org/packages/AWSSDK.Appflow/)
	* Amazon AppFlow is a fully managed integration service that securely transfers data between AWS services and SaaS applications. This update releases the first version of Amazon AppFlow APIs and SDK.
* [AWSSDK.AppIntegrationsService](https://www.nuget.org/packages/AWSSDK.AppIntegrationsService/)
	* The Amazon AppIntegrations service (in preview release) enables you to configure and reuse connections to external applications.
* [AWSSDK.ApplicationAutoScaling](https://www.nuget.org/packages/AWSSDK.ApplicationAutoScaling/)
	* Application Auto Scaling is a general purpose Auto Scaling service for supported elastic AWS resources. With Application Auto Scaling, you can automatically scale your AWS resources, with an experience similar to that of Amazon EC2 Auto Scaling.
* [AWSSDK.ApplicationCostProfiler](https://www.nuget.org/packages/AWSSDK.ApplicationCostProfiler/)
	* APIs for AWS Application Cost Profiler.
* [AWSSDK.ApplicationDiscoveryService](https://www.nuget.org/packages/AWSSDK.ApplicationDiscoveryService/)
	* AWS Application Discovery Service helps Systems Integrators quickly and reliably plan application migration projects by automatically identifying applications running in your data center, their associated dependencies, and their performance profile.
* [AWSSDK.ApplicationInsights](https://www.nuget.org/packages/AWSSDK.ApplicationInsights/)
	* CloudWatch Application Insights detects errors and exceptions from logs, including .NET custom application logs, SQL Server logs, IIS logs, and more, and uses a combination of built-in rules and machine learning, such as dynamic baselining, to identify common problems. You can then easily drill into specific issues with CloudWatch Automatic Dashboards that are dynamically generated. These dashboards contain the most recent alarms, a summary of relevant metrics, and log snippets to help you identify root cause.
* [AWSSDK.AppMesh](https://www.nuget.org/packages/AWSSDK.AppMesh/)
	* AWS App Mesh is a service mesh that makes it easy to monitor and control communications between microservices of an application. AWS App Mesh APIs are available for preview in eu-west-1, us-east-1, us-east-2, and us-west-2 regions.
* [AWSSDK.AppRegistry](https://www.nuget.org/packages/AWSSDK.AppRegistry/)
	* AWS Service Catalog AppRegistry provides a repository of your applications, their resources, and the application metadata that you use within your enterprise.
* [AWSSDK.AppRunner](https://www.nuget.org/packages/AWSSDK.AppRunner/)
	* AWS App Runner is a service that provides a fast, simple, and cost-effective way to deploy from source code or a container image directly to a scalable and secure web application in the AWS Cloud.
* [AWSSDK.AppStream](https://www.nuget.org/packages/AWSSDK.AppStream/)
	* Amazon AppStream is a fully managed, secure application streaming service that allows you to stream desktop applications from AWS to a web browser.
* [AWSSDK.AppSync](https://www.nuget.org/packages/AWSSDK.AppSync/)
	* AWS AppSync is an enterprise-level, fully managed GraphQL service with real-time data synchronization and offline programming features.
* [AWSSDK.ARCZonalShift](https://www.nuget.org/packages/AWSSDK.ARCZonalShift/)
	* Amazon Route 53 Application Recovery Controller Zonal Shift is a new service that makes it easy to shift traffic away from an Availability Zone in a Region. See the developer guide for more information: https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html
* [AWSSDK.Athena](https://www.nuget.org/packages/AWSSDK.Athena/)
	* This release adds support for Amazon Athena. Amazon Athena is an interactive query service that makes it easy to analyze data in Amazon S3 using standard SQL. Athena is serverless, so there is no infrastructure to manage, and you pay only for the queries that you run.
* [AWSSDK.AuditManager](https://www.nuget.org/packages/AWSSDK.AuditManager/)
	* AWS Audit Manager helps you continuously audit your AWS usage to simplify how you manage risk and compliance. This update releases the first version of the AWS Audit Manager APIs and SDK.
* [AWSSDK.AugmentedAIRuntime](https://www.nuget.org/packages/AWSSDK.AugmentedAIRuntime/)
	* This release adds support for Amazon Augmented AI, which makes it easy to build workflows for human review of machine learning predictions.
* [AWSSDK.AutoScaling](https://www.nuget.org/packages/AWSSDK.AutoScaling/)
	* Auto Scaling helps you maintain application availability and allows you to scale your capacity up or down automatically according to conditions you define.
* [AWSSDK.AutoScalingPlans](https://www.nuget.org/packages/AWSSDK.AutoScalingPlans/)
	* AWS Auto Scaling enables you to quickly discover all of the scalable resources underlying your application and set up application scaling in minutes using built-in scaling recommendations.
* [AWSSDK.AWSHealth](https://www.nuget.org/packages/AWSSDK.AWSHealth/)
	* The AWS Health API serves as the primary source for you to receive personalized information related to your AWS infrastructure, guiding your through scheduled changes, and accelerating the troubleshooting of issues impacting your AWS resources and accounts.
* [AWSSDK.AWSMarketplaceCommerceAnalytics](https://www.nuget.org/packages/AWSSDK.AWSMarketplaceCommerceAnalytics/)
	* The AWS Marketplace Commerce Analytics service allows marketplace partners to programmatically request business intelligence data from AWS Marketplace. This service provides the same data that was previously only available through the AWS Marketplace Management Portal, but offers the data in a fully-machine-readable format and available in fine-grained data sets rather than large reports.
* [AWSSDK.AWSMarketplaceMetering](https://www.nuget.org/packages/AWSSDK.AWSMarketplaceMetering/)
	* The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.
* [AWSSDK.AWSSupport](https://www.nuget.org/packages/AWSSDK.AWSSupport/)
	* The AWS Support API provides methods for creating and managing AWS Support cases and for retrieving the results of AWS Trusted Advisor checks.
* [AWSSDK.Backup](https://www.nuget.org/packages/AWSSDK.Backup/)
	* AWS Backup is a fully managed backup service that makes it easy to centralize and automate the back up of data across AWS services in the cloud as well as on-premises.
* [AWSSDK.BackupGateway](https://www.nuget.org/packages/AWSSDK.BackupGateway/)
	* Initial release of AWS Backup gateway which enables you to centralize and automate protection of on-premises VMware and VMware Cloud on AWS workloads using AWS Backup.
* [AWSSDK.BackupStorage](https://www.nuget.org/packages/AWSSDK.BackupStorage/)
	* This is the first public release of AWS Backup Storage. We are exposing some previously-internal APIs for use by external services. These APIs are not meant to be used directly by customers.
* [AWSSDK.Batch](https://www.nuget.org/packages/AWSSDK.Batch/)
	* AWS Batch enables developers, scientists, and engineers to easily and efficiently run hundreds of thousands of batch computing jobs on AWS. 
* [AWSSDK.BillingConductor](https://www.nuget.org/packages/AWSSDK.BillingConductor/)
	* This is the initial SDK release for AWS Billing Conductor. The AWS Billing Conductor is a customizable billing service, allowing you to customize your billing data to match your desired business structure.
* [AWSSDK.Braket](https://www.nuget.org/packages/AWSSDK.Braket/)
	* Amazon Braket general availability with Device and Quantum Task operations.
* [AWSSDK.Budgets](https://www.nuget.org/packages/AWSSDK.Budgets/)
	* AWS Budget service will provide create/get/list/update/delete budgets for cost management. 
* [AWSSDK.CertificateManager](https://www.nuget.org/packages/AWSSDK.CertificateManager/)
	* AWS Certificate Manager (ACM) is an AWS service that makes it easier for you to deploy secure SSL based websites and applications on the AWS platform.
* [AWSSDK.Chime](https://www.nuget.org/packages/AWSSDK.Chime/)
	* The Amazon Chime API (application programming interface) is designed for administrators to use to perform key tasks, such as creating and managing Amazon Chime accounts and users.
* [AWSSDK.ChimeSDKIdentity](https://www.nuget.org/packages/AWSSDK.ChimeSDKIdentity/)
	* The Amazon Chime SDK Identity APIs allow software developers to create and manage unique instances of their messaging applications.
* [AWSSDK.ChimeSDKMediaPipelines](https://www.nuget.org/packages/AWSSDK.ChimeSDKMediaPipelines/)
	* For Amazon Chime SDK meetings, the Amazon Chime Media Pipelines SDK allows builders to capture audio, video, and content share streams. You can also capture meeting events, live transcripts, and data messages. The pipelines save the artifacts to an Amazon S3 bucket that you designate.
* [AWSSDK.ChimeSDKMeetings](https://www.nuget.org/packages/AWSSDK.ChimeSDKMeetings/)
	* The Amazon Chime SDK Meetings APIs allow software developers to create meetings and attendees for interactive audio, video, screen and content sharing in custom meeting applications which use the Amazon Chime SDK.
* [AWSSDK.ChimeSDKMessaging](https://www.nuget.org/packages/AWSSDK.ChimeSDKMessaging/)
	* The Amazon Chime SDK Messaging APIs allow software developers to send and receive messages in custom messaging applications.
* [AWSSDK.ChimeSDKVoice](https://www.nuget.org/packages/AWSSDK.ChimeSDKVoice/)
	* Amazon Chime Voice Connector, Voice Connector Group and PSTN Audio Service APIs are now available in the Amazon Chime SDK Voice namespace. See https://docs.aws.amazon.com/chime-sdk/latest/dg/sdk-available-regions.html for more details.
* [AWSSDK.CleanRooms](https://www.nuget.org/packages/AWSSDK.CleanRooms/)
	* Initial release of AWS Clean Rooms
* [AWSSDK.Cloud9](https://www.nuget.org/packages/AWSSDK.Cloud9/)
	* Adds support for creating and managing AWS Cloud9 development environments. AWS Cloud9 is a cloud-based integrated development environment (IDE) that you use to write, run, and debug code.
* [AWSSDK.CloudControlApi](https://www.nuget.org/packages/AWSSDK.CloudControlApi/)
	* Initial release of the SDK for AWS Cloud Control API
* [AWSSDK.CloudDirectory](https://www.nuget.org/packages/AWSSDK.CloudDirectory/)
	* Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.
* [AWSSDK.CloudFormation](https://www.nuget.org/packages/AWSSDK.CloudFormation/)
	* AWS CloudFormation gives developers and systems administrators an easy way to create and manage a collection of related AWS resources, provisioning and updating them in an orderly and predictable fashion.
* [AWSSDK.CloudFront](https://www.nuget.org/packages/AWSSDK.CloudFront/)
	* Amazon CloudFront is a content delivery web service. It integrates with other Amazon Web Services products to give developers and businesses an easy way to distribute content to end users with low latency, high data transfer speeds, and no minimum usage commitments.
* [AWSSDK.CloudHSM](https://www.nuget.org/packages/AWSSDK.CloudHSM/)
	* The AWS CloudHSM service helps you meet corporate, contractual and regulatory compliance requirements for data security by using dedicated Hardware Security Module (HSM) appliances within the AWS cloud. With CloudHSM, you control the encryption keys and cryptographic operations performed by the HSM.
* [AWSSDK.CloudHSMV2](https://www.nuget.org/packages/AWSSDK.CloudHSMV2/)
	* CloudHSM provides hardware security modules for protecting sensitive data and cryptographic keys within an EC2 VPC, and enable the customer to maintain control over key access and use. This is a second-generation of the service that will improve security, lower cost and provide better customer usability.
* [AWSSDK.CloudSearch](https://www.nuget.org/packages/AWSSDK.CloudSearch/)
	* Amazon CloudSearch is a managed service in the AWS Cloud that makes it simple and cost-effective to set up, manage, and scale a search solution for your website or application.
* [AWSSDK.CloudSearchDomain](https://www.nuget.org/packages/AWSSDK.CloudSearchDomain/)
	* Amazon CloudSearch Domain encapsulates a collection of data you want to search, the search instances that process your search requests, and a configuration that controls how your data is indexed and searched.
* [AWSSDK.CloudTrail](https://www.nuget.org/packages/AWSSDK.CloudTrail/)
	* AWS CloudTrail is a web service that records AWS API calls for your account and delivers log files to you. The recorded information includes the identity of the API caller, the time of the API call, the source IP address of the API caller, the request parameters, and the response elements returned by the AWS service.
* [AWSSDK.CloudTrailData](https://www.nuget.org/packages/AWSSDK.CloudTrailData/)
	* Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.
* [AWSSDK.CloudWatch](https://www.nuget.org/packages/AWSSDK.CloudWatch/)
	* Amazon CloudWatch is a monitoring service for AWS cloud resources and the applications you run on AWS. You can use Amazon CloudWatch to collect and track metrics, collect and monitor log files, and set alarms.
* [AWSSDK.CloudWatchEvents](https://www.nuget.org/packages/AWSSDK.CloudWatchEvents/)
	* Amazon CloudWatch Events helps you to respond to state changes in your AWS resources. When your resources change state they automatically send events into an event stream. You can create rules that match selected events in the stream and route them to targets to take action. You can also use rules to take action on a pre-determined schedule.
* [AWSSDK.CloudWatchEvidently](https://www.nuget.org/packages/AWSSDK.CloudWatchEvidently/)
	* Introducing Amazon CloudWatch Evidently. This is the first public release of Amazon CloudWatch Evidently.
* [AWSSDK.CloudWatchLogs](https://www.nuget.org/packages/AWSSDK.CloudWatchLogs/)
	* Amazon CloudWatch is a monitoring service for AWS cloud resources and the applications you run on AWS. You can use Amazon CloudWatch to collect and track metrics, collect and monitor log files, and set alarms.
* [AWSSDK.CloudWatchRUM](https://www.nuget.org/packages/AWSSDK.CloudWatchRUM/)
	* This is the first public release of CloudWatch RUM
* [AWSSDK.CodeArtifact](https://www.nuget.org/packages/AWSSDK.CodeArtifact/)
	* Added support for AWS CodeArtifact.
* [AWSSDK.CodeBuild](https://www.nuget.org/packages/AWSSDK.CodeBuild/)
	* AWS CodeBuild is a fully-managed build service in the cloud. AWS CodeBuild compiles your source code, runs unit tests, and produces artifacts that are ready to deploy.
* [AWSSDK.CodeCatalyst](https://www.nuget.org/packages/AWSSDK.CodeCatalyst/)
	* This release adds operations that support customers using the AWS Toolkits and Amazon CodeCatalyst, a unified software development service that helps developers develop, deploy, and maintain applications in the cloud. For more information, see the documentation.
* [AWSSDK.CodeCommit](https://www.nuget.org/packages/AWSSDK.CodeCommit/)
	* AWS CodeCommit is a fully-managed source control service that makes it easy for companies to host secure and highly scalable private Git repositories.
* [AWSSDK.CodeDeploy](https://www.nuget.org/packages/AWSSDK.CodeDeploy/)
	* AWS CodeDeploy is a service that automates code deployments. AWS CodeDeploy makes it easier for you to rapidly release new features, helps you avoid downtime during deployment, and handles the complexity of updating your applications.
* [AWSSDK.CodeGuruProfiler](https://www.nuget.org/packages/AWSSDK.CodeGuruProfiler/)
	* (New Service) Amazon CodeGuru Profiler analyzes application CPU utilization and latency characteristics to show you where you are spending the most cycles in your application. This analysis is presented in an interactive flame graph that helps you easily understand which paths consume the most resources, verify that your application is performing as expected, and uncover areas that can be optimized further.
* [AWSSDK.CodeGuruReviewer](https://www.nuget.org/packages/AWSSDK.CodeGuruReviewer/)
	* This is the preview release of Amazon CodeGuru Reviewer.
* [AWSSDK.CodePipeline](https://www.nuget.org/packages/AWSSDK.CodePipeline/)
	* AWS CodePipeline is a continuous delivery service for fast and reliable application updates.
* [AWSSDK.CodeStar](https://www.nuget.org/packages/AWSSDK.CodeStar/)
	* AWS CodeStar is a cloud-based service for creating, managing, and working with software development projects on AWS. An AWS CodeStar project creates and integrates AWS services for your project development toolchain. AWS CodeStar also manages the permissions required for project users.
* [AWSSDK.CodeStarconnections](https://www.nuget.org/packages/AWSSDK.CodeStarconnections/)
	* Public beta for Bitbucket Cloud support in AWS CodePipeline through integration with AWS CodeStar connections.
* [AWSSDK.CodeStarNotifications](https://www.nuget.org/packages/AWSSDK.CodeStarNotifications/)
	* This release adds a notification manager for events in repositories, build projects, deployments, and pipelines. You can now configure rules and receive notifications about events that occur for resources. Each notification includes a status message as well as a link to the resource (repository, build project, deployment application, or pipeline) whose event generated the notification.
* [AWSSDK.CognitoIdentity](https://www.nuget.org/packages/AWSSDK.CognitoIdentity/)
	* Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.
* [AWSSDK.CognitoIdentityProvider](https://www.nuget.org/packages/AWSSDK.CognitoIdentityProvider/)
	* You can create a user pool in Amazon Cognito Identity to manage directories and users. You can authenticate a user to obtain tokens related to user identity and access policies. This API reference provides information about user pools in Amazon Cognito Identity, which is a new capability that is available as a beta.
* [AWSSDK.CognitoSync](https://www.nuget.org/packages/AWSSDK.CognitoSync/)
	* Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.
* [AWSSDK.Comprehend](https://www.nuget.org/packages/AWSSDK.Comprehend/)
	* Amazon Comprehend is an AWS service for gaining insight into the content of text and documents. It can be used to determine the topics contained in your documents, the topics they discuss, the  predominant sentiment expressed in them, the predominant language used, and more. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.
* [AWSSDK.ComprehendMedical](https://www.nuget.org/packages/AWSSDK.ComprehendMedical/)
	* The first release of Comprehend Medical includes two APIs, detectPHI and detectEntities. DetectPHI extracts PHI from your clinical text, and detectEntities extracts entities such as medication, medical conditions, or anatomy. DetectEntities also extracts attributes (e.g. dosage for medication) and identifies contextual traits (e.g. negation) for each entity.
* [AWSSDK.ComputeOptimizer](https://www.nuget.org/packages/AWSSDK.ComputeOptimizer/)
	* Initial release of AWS Compute Optimizer. AWS Compute Optimizer recommends optimal AWS Compute resources to reduce costs and improve performance for your workloads.
* [AWSSDK.ConfigService](https://www.nuget.org/packages/AWSSDK.ConfigService/)
	* AWS Config is a fully managed service that provides you with an AWS resource inventory, configuration history, and configuration change notifications to enable security and governance.
* [AWSSDK.Connect](https://www.nuget.org/packages/AWSSDK.Connect/)
	* Amazon Connect is a self-service, cloud-based contact center service that makes it easy for any business to deliver better customer service at lower cost.
* [AWSSDK.ConnectCampaignService](https://www.nuget.org/packages/AWSSDK.ConnectCampaignService/)
	* Added Amazon Connect high volume outbound communications SDK.
* [AWSSDK.ConnectCases](https://www.nuget.org/packages/AWSSDK.ConnectCases/)
	* This release adds APIs for Amazon Connect Cases. Cases allows your agents to quickly track and manage customer issues that require multiple interactions, follow-up tasks, and teams in your contact center.  For more information, see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* [AWSSDK.ConnectContactLens](https://www.nuget.org/packages/AWSSDK.ConnectContactLens/)
	* Contact Lens for Amazon Connect analyzes conversations, both real-time and post-call. The ListRealtimeContactAnalysisSegments API returns a list of analysis segments for a real-time analysis session.
* [AWSSDK.ConnectParticipant](https://www.nuget.org/packages/AWSSDK.ConnectParticipant/)
	* This release adds 5 new APIs: CreateParticipantConnection, DisconnectParticipant, GetTranscript, SendEvent, and SendMessage. For Amazon Connect chat, you can use them to programmatically perform participant actions on the configured Amazon Connect instance. Learn more here: https://docs.aws.amazon.com/connect-participant/latest/APIReference/Welcome.html
* [AWSSDK.ConnectWisdomService](https://www.nuget.org/packages/AWSSDK.ConnectWisdomService/)
	* Released Amazon Connect Wisdom, a feature of Amazon Connect, which provides real-time recommendations and search functionality in general availability (GA).  For more information, see https://docs.aws.amazon.com/wisdom/latest/APIReference/Welcome.html.
* [AWSSDK.ControlTower](https://www.nuget.org/packages/AWSSDK.ControlTower/)
	* This release contains the first SDK for AWS Control Tower. It introduces  a new set of APIs: EnableControl, DisableControl, GetControlOperation, and ListEnabledControls.
* [AWSSDK.CostAndUsageReport](https://www.nuget.org/packages/AWSSDK.CostAndUsageReport/)
	* The AWS Cost and Usage Report Service API allows you to enable and disable the Cost and Usage report, as well as modify the report name, the data granularity, and the delivery preferences.
* [AWSSDK.CostExplorer](https://www.nuget.org/packages/AWSSDK.CostExplorer/)
	* The AWS Cost Explorer API gives customers programmatic access to AWS cost and usage information, allowing them to perform adhoc queries and build interactive cost management applications that leverage this dataset.
* [AWSSDK.CustomerProfiles](https://www.nuget.org/packages/AWSSDK.CustomerProfiles/)
	* This is the first release of Amazon Connect Customer Profiles, a unified customer profile for your Amazon Connect contact center.
* [AWSSDK.DatabaseMigrationService](https://www.nuget.org/packages/AWSSDK.DatabaseMigrationService/)
	* AWS Database Migration Service (AWS DMS) can migrate your data to and from most widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft SQL Server, Amazon Aurora, MariaDB, and MySQL. The service supports homogeneous migrations such as Oracle to Oracle, and also heterogeneous migrations between different database platforms, such as Oracle to MySQL or MySQL to Amazon Aurora.
* [AWSSDK.DataExchange](https://www.nuget.org/packages/AWSSDK.DataExchange/)
	* Introducing AWS Data Exchange, a service that makes it easy for AWS customers to securely create, manage, access, and exchange data sets in the cloud.
* [AWSSDK.DataPipeline](https://www.nuget.org/packages/AWSSDK.DataPipeline/)
	* AWS Data Pipeline is a managed extract-transform-load (ETL) service that helps you reliably and cost-effectively move and process data across your on-premise data stores and AWS services.
* [AWSSDK.DataSync](https://www.nuget.org/packages/AWSSDK.DataSync/)
	* AWS DataSync simplifies, automates, and accelerates moving and replicating data between on-premises storage and AWS services over the network.
* [AWSSDK.DAX](https://www.nuget.org/packages/AWSSDK.DAX/)
	* Amazon DynamoDB Accelerator (DAX) is a fully managed, highly available, in-memory cache for DynamoDB that delivers up to a 10x performance improvement - from milliseconds to microseconds - even at millions of requests per second. DAX does all the heavy lifting required to add in-memory acceleration to your DynamoDB tables, without requiring developers to manage cache invalidation, data population, or cluster management.
* [AWSSDK.Detective](https://www.nuget.org/packages/AWSSDK.Detective/)
	* This is the initial release of Amazon Detective.
* [AWSSDK.DeviceFarm](https://www.nuget.org/packages/AWSSDK.DeviceFarm/)
	* AWS Device Farm is an app testing service that enables you to test your Android and Fire OS apps on real, physical phones and tablets that are hosted by AWS. The service allows you to upload your own tests or use built-in, script-free compatibility tests.
* [AWSSDK.DevOpsGuru](https://www.nuget.org/packages/AWSSDK.DevOpsGuru/)
	* (New Service) Amazon DevOps Guru is available in public preview. It's a fully managed service that uses machine learning to analyze your operational solutions to help you find and troubleshoot issues.
* [AWSSDK.DirectConnect](https://www.nuget.org/packages/AWSSDK.DirectConnect/)
	* AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to AWS. Using AWS Direct Connect, you can establish private connectivity between AWS and your datacenter, office, or colocation environment, which in many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than Internet-based connections.
* [AWSSDK.DirectoryService](https://www.nuget.org/packages/AWSSDK.DirectoryService/)
	* AWS Directory Service is a managed service that allows you to connect your AWS resources with an existing on-premises Microsoft Active Directory or to set up a new, stand-alone directory in the AWS Cloud.
* [AWSSDK.DLM](https://www.nuget.org/packages/AWSSDK.DLM/)
	* Amazon Data Lifecycle Manager manages lifecycle of your AWS resources.
* [AWSSDK.DocDB](https://www.nuget.org/packages/AWSSDK.DocDB/)
	* Amazon DocumentDB is a fast, reliable, and fully managed MongoDB compatible database service.
* [AWSSDK.DocDBElastic](https://www.nuget.org/packages/AWSSDK.DocDBElastic/)
	* Launched Amazon DocumentDB Elastic Clusters. You can now use the SDK to create, list, update and delete Amazon DocumentDB Elastic Cluster resources
* [AWSSDK.Drs](https://www.nuget.org/packages/AWSSDK.Drs/)
	* Introducing AWS Elastic Disaster Recovery (AWS DRS), a new service that minimizes downtime and data loss with fast, reliable recovery of on-premises and cloud-based applications using affordable storage, minimal compute, and point-in-time recovery.
* [AWSSDK.DynamoDBv2](https://www.nuget.org/packages/AWSSDK.DynamoDBv2/)
	* Amazon DynamoDB is a fast and flexible NoSQL database service for all applications that need consistent, single-digit millisecond latency at any scale.
* [AWSSDK.EBS](https://www.nuget.org/packages/AWSSDK.EBS/)
	* This release introduces the EBS direct APIs for Snapshots: 1. ListSnapshotBlocks, which lists the block indexes and block tokens for blocks in an Amazon EBS snapshot. 2. ListChangedBlocks, which lists the block indexes and block tokens for blocks that are different between two snapshots of the same volume/snapshot lineage. 3. GetSnapshotBlock, which returns the data in a block of an Amazon EBS snapshot.
* [AWSSDK.EC2](https://www.nuget.org/packages/AWSSDK.EC2/)
	* Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to make web-scale cloud computing easier for developers.
* [AWSSDK.EC2InstanceConnect](https://www.nuget.org/packages/AWSSDK.EC2InstanceConnect/)
	* Amazon EC2 Instance Connect is a simple and secure way to connect to your instances using Secure Shell (SSH). With EC2 Instance Connect, you can control SSH access to your instances using AWS Identity and Access Management (IAM) policies as well as audit connection requests with AWS CloudTrail events. In addition, you can leverage your existing SSH keys or further enhance your security posture by generating one-time use SSH keys each time an authorized user connects.
* [AWSSDK.ECR](https://www.nuget.org/packages/AWSSDK.ECR/)
	* Amazon EC2 Container Registry (Amazon ECR) is a managed AWS Docker registry service. Customers can use the familiar Docker CLI to push, pull, and manage images.
* [AWSSDK.ECRPublic](https://www.nuget.org/packages/AWSSDK.ECRPublic/)
	* Supports Amazon Elastic Container Registry (Amazon ECR) Public, a fully managed registry that makes it easy for a developer to publicly share container software worldwide for anyone to download.
* [AWSSDK.ECS](https://www.nuget.org/packages/AWSSDK.ECS/)
	* Amazon EC2 Container Service is a highly scalable, high performance container management service that supports Docker containers and allows you to easily run distributed applications on a managed cluster of Amazon EC2 instances.
* [AWSSDK.EKS](https://www.nuget.org/packages/AWSSDK.EKS/)
	* Amazon Elastic Container Service for Kubernetes (Amazon EKS) is a fully managed service that makes it easy to deploy, manage, and scale containerized applications using Kubernetes on AWS.Amazon EKS runs Kubernetes management infrastructure for you across multiple AWS availability zones to eliminate a single point of failure. Amazon EKS is certified Kubernetes conformant so you can use existing tooling and plugins from partners and the Kubernetes community. Applications running on any standard Kubernetes environment are fully compatible and can be easily migrated to Amazon EKS.
* [AWSSDK.ElastiCache](https://www.nuget.org/packages/AWSSDK.ElastiCache/)
	* ElastiCache is a web service that makes it easy to deploy, operate, and scale an in-memory cache in the cloud. The service improves the performance of web applications by allowing you to retrieve information from fast, managed, in-memory caches, instead of relying entirely on slower disk-based databases.
* [AWSSDK.ElasticBeanstalk](https://www.nuget.org/packages/AWSSDK.ElasticBeanstalk/)
	* AWS Elastic Beanstalk is an easy-to-use service for deploying and scaling web applications and services developed with Java, .NET, PHP, Node.js, Python, Ruby, Go, and Docker on familiar servers such as Apache, Nginx, Passenger, and IIS.
* [AWSSDK.ElasticFileSystem](https://www.nuget.org/packages/AWSSDK.ElasticFileSystem/)
	* Amazon Elastic File System (Amazon EFS) is a file storage service for Amazon Elastic Compute Cloud (Amazon EC2) instances.
* [AWSSDK.ElasticInference](https://www.nuget.org/packages/AWSSDK.ElasticInference/)
	* Amazon Elastic Inference allows customers to attach Elastic Inference Accelerators to Amazon EC2 and Amazon ECS tasks, thus providing low-cost GPU-powered acceleration and reducing the cost of running deep learning inference. This release allows customers to add or remove tags for their Elastic Inference Accelerators.
* [AWSSDK.ElasticLoadBalancing](https://www.nuget.org/packages/AWSSDK.ElasticLoadBalancing/)
	* Elastic Load Balancing automatically distributes incoming application traffic across multiple compute instances in the cloud.
* [AWSSDK.ElasticLoadBalancingV2](https://www.nuget.org/packages/AWSSDK.ElasticLoadBalancingV2/)
	* Elastic Load Balancing automatically distributes incoming application traffic across multiple compute instances in the cloud.
* [AWSSDK.ElasticMapReduce](https://www.nuget.org/packages/AWSSDK.ElasticMapReduce/)
	* Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to quickly and cost-effectively process vast amounts of data.
* [AWSSDK.Elasticsearch](https://www.nuget.org/packages/AWSSDK.Elasticsearch/)
	* Use the Amazon Elasticsearch configuration API to create, configure, and manage Elasticsearch domains.
* [AWSSDK.ElasticTranscoder](https://www.nuget.org/packages/AWSSDK.ElasticTranscoder/)
	* Amazon Elastic Transcoder is media transcoding in the cloud. It is designed to be a highly scalable, easy to use and a cost effective way for developers and businesses to convert (or 'transcode') media files from their source format into versions that will playback on devices like smartphones, tablets and PCs.
* [AWSSDK.EMRContainers](https://www.nuget.org/packages/AWSSDK.EMRContainers/)
	* This release adds support for Amazon EMR on EKS, a simple way to run Spark on Kubernetes.
* [AWSSDK.EMRServerless](https://www.nuget.org/packages/AWSSDK.EMRServerless/)
	* This release adds support for Amazon EMR Serverless, a serverless runtime environment that simplifies running analytics applications using the latest open source frameworks such as Apache Spark and Apache Hive.
* [AWSSDK.EventBridge](https://www.nuget.org/packages/AWSSDK.EventBridge/)
	* Amazon EventBridge is a serverless event bus service that makes it easy to connect your applications with data from a variety of sources, including AWS services, partner applications, and your own applications.
* [AWSSDK.Finspace](https://www.nuget.org/packages/AWSSDK.Finspace/)
	* This is the initial SDK release for the management APIs for Amazon FinSpace. Amazon FinSpace is a data management and analytics service for the financial services industry (FSI).
* [AWSSDK.FinSpaceData](https://www.nuget.org/packages/AWSSDK.FinSpaceData/)
	* This is the initial SDK release for the data APIs for Amazon FinSpace. Amazon FinSpace is a data management and analytics application for the financial services industry (FSI).
* [AWSSDK.FIS](https://www.nuget.org/packages/AWSSDK.FIS/)
	* Initial release of AWS Fault Injection Simulator, a managed service that enables you to perform fault injection experiments on your AWS workloads
* [AWSSDK.FMS](https://www.nuget.org/packages/AWSSDK.FMS/)
	* This release is the initial release version for AWS Firewall Manager, a new AWS service that makes it easy for customers to centrally configure WAF rules across all their resources (ALBs and CloudFront distributions) and across accounts.
* [AWSSDK.ForecastQueryService](https://www.nuget.org/packages/AWSSDK.ForecastQueryService/)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* [AWSSDK.ForecastService](https://www.nuget.org/packages/AWSSDK.ForecastService/)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* [AWSSDK.FraudDetector](https://www.nuget.org/packages/AWSSDK.FraudDetector/)
	* Amazon Fraud Detector is a fully managed service that makes it easy to identify potentially fraudulent online activities such as online payment fraud and the creation of fake accounts. Amazon Fraud Detector uses your data, machine learning (ML), and more than 20 years of fraud detection expertise from Amazon to automatically identify potentially fraudulent online activity so you can catch more fraud faster.
* [AWSSDK.FSx](https://www.nuget.org/packages/AWSSDK.FSx/)
	* Amazon FSx provides fully-managed third-party file systems optimized for a variety of enterprise and compute-intensive workloads.
* [AWSSDK.GameLift](https://www.nuget.org/packages/AWSSDK.GameLift/)
	* Amazon GameLift Service is a managed AWS service for developers who need a scalable, server-based solution for multiplayer games.
* [AWSSDK.GameSparks](https://www.nuget.org/packages/AWSSDK.GameSparks/)
	* Released the preview of Amazon GameSparks, a fully managed AWS service that provides a multi-service backend for game developers.
* [AWSSDK.Glacier](https://www.nuget.org/packages/AWSSDK.Glacier/)
	* Amazon Glacier is a secure, durable, and extremely low-cost storage service for data archiving and online backup.
* [AWSSDK.GlobalAccelerator](https://www.nuget.org/packages/AWSSDK.GlobalAccelerator/)
	* AWS Global Accelerator is a network layer service that helps you improve the availability and performance of the applications that you offer to your global customers. Global Accelerator uses the AWS global network to direct internet traffic from your users to your applications running in AWS Regions. Global Accelerator creates a fixed entry point for your applications through static anycast IP addresses, and routes user traffic to the optimal endpoint based on performance, application health and routing policies that you can configure. Global Accelerator supports the following features at launch: static anycast IP addresses, support for TCP and UDP, support for Network Load Balancers, Application Load Balancers and Elastic-IP address endpoints,  continuous health checking, instant regional failover, fault isolating Network Zones, granular traffic controls, and client affinity.
* [AWSSDK.Glue](https://www.nuget.org/packages/AWSSDK.Glue/)
	* AWS Glue is a fully managed extract, transform, and load (ETL) service that makes it easy for customers to prepare and load their data for analytics. You can create and run an ETL job with a few clicks in the AWS Management Console. You simply point AWS Glue to your data stored on AWS, and AWS Glue discovers your data and stores the associated metadata (e.g. table definition and schema) in the AWS Glue Data Catalog. Once cataloged, your data is immediately searchable, queryable, and available for ETL. AWS Glue generates the code to execute your data transformations and data loading processes. AWS Glue generates Python code that is entirely customizable, reusable, and portable. Once your ETL job is ready, you can schedule it to run on AWS Glue's fully managed, scale-out Spark environment. AWS Glue provides a flexible scheduler with dependency resolution, job monitoring, and alerting. AWS Glue is serverless, so there is no infrastructure to buy, set up, or manage. It automatically provisions the environment needed to complete the job, and customers pay only for the compute resources consumed while running ETL jobs. With AWS Glue, data can be available for analytics in minutes.
* [AWSSDK.GlueDataBrew](https://www.nuget.org/packages/AWSSDK.GlueDataBrew/)
	* This is the initial SDK release for AWS Glue DataBrew. DataBrew is a visual data preparation tool that enables users to clean and normalize data without writing any code.
* [AWSSDK.Greengrass](https://www.nuget.org/packages/AWSSDK.Greengrass/)
	* AWS Greengrass is software that lets you run local compute, messaging, and device state synchronization for connected devices in a secure way. With AWS Greengrass, connected devices can run AWS Lambda functions, keep device data in sync, and communicate with other devices securely even when not connected to the Internet. Using AWS Lambda, Greengrass ensures your IoT devices can respond quickly to local events, operate with intermittent connections, and minimize the cost of transmitting IoT data to the cloud.
* [AWSSDK.GreengrassV2](https://www.nuget.org/packages/AWSSDK.GreengrassV2/)
	* AWS IoT Greengrass V2 is a new major version of AWS IoT Greengrass. This release adds several updates such as modular components, continuous deployments, and improved ease of use.
* [AWSSDK.GroundStation](https://www.nuget.org/packages/AWSSDK.GroundStation/)
	* AWS Ground Station is a fully managed service that enables you to control satellite communications, downlink and process satellite data, and scale your satellite operations efficiently and cost-effectively without having to build or manage your own ground station infrastructure.
* [AWSSDK.GuardDuty](https://www.nuget.org/packages/AWSSDK.GuardDuty/)
	* Enable Amazon GuardDuty to continuously monitor and process AWS data sources to identify threats to your AWS accounts and workloads. You can add customization by uploading additional threat intelligence lists and IP safe lists. You can list security findings, suspend, and disable the service.
* [AWSSDK.HealthLake](https://www.nuget.org/packages/AWSSDK.HealthLake/)
	* This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.
* [AWSSDK.Honeycode](https://www.nuget.org/packages/AWSSDK.Honeycode/)
	* Introducing Amazon Honeycode - a fully managed service that allows you to quickly build mobile and web apps for teams without programming.
* [AWSSDK.IAMRolesAnywhere](https://www.nuget.org/packages/AWSSDK.IAMRolesAnywhere/)
	* IAM Roles Anywhere allows your workloads such as servers, containers, and applications to obtain temporary AWS credentials and use the same IAM roles and policies that you have configured for your AWS workloads to access AWS resources.
* [AWSSDK.IdentityManagement](https://www.nuget.org/packages/AWSSDK.IdentityManagement/)
	* AWS Identity and Access Management (IAM) enables you to securely control access to AWS services and resources for your users. Using IAM, you can create and manage AWS users and groups, and use permissions to allow and deny their access to AWS resources.
* [AWSSDK.IdentityStore](https://www.nuget.org/packages/AWSSDK.IdentityStore/)
	* AWS Single Sign-On (SSO) Identity Store service provides an interface to retrieve all of your users and groups. It enables entitlement management per user or group for AWS SSO and other IDPs.
* [AWSSDK.Imagebuilder](https://www.nuget.org/packages/AWSSDK.Imagebuilder/)
	* This is the first release of EC2 Image Builder, a service that provides a managed experience for automating the creation of EC2 AMIs.
* [AWSSDK.ImportExport](https://www.nuget.org/packages/AWSSDK.ImportExport/)
	* AWS Import/Export accelerates moving large amounts of data into and out of the AWS cloud using portable storage devices for transport.
* [AWSSDK.Inspector](https://www.nuget.org/packages/AWSSDK.Inspector/)
	* Amazon Inspector identifies security issues in your application deployments.
* [AWSSDK.Inspector2](https://www.nuget.org/packages/AWSSDK.Inspector2/)
	* This release adds support for the new Amazon Inspector API. The new Amazon Inspector can automatically discover and scan Amazon EC2 instances and Amazon ECR container images for software vulnerabilities and unintended network exposure, and report centralized findings across multiple AWS accounts.
* [AWSSDK.IoT](https://www.nuget.org/packages/AWSSDK.IoT/)
	* AWS IoT allows you to leverage AWS to build your Internet of Things.
* [AWSSDK.IoT1ClickDevicesService](https://www.nuget.org/packages/AWSSDK.IoT1ClickDevicesService/)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/
* [AWSSDK.IoT1ClickProjects](https://www.nuget.org/packages/AWSSDK.IoT1ClickProjects/)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/
* [AWSSDK.IoTAnalytics](https://www.nuget.org/packages/AWSSDK.IoTAnalytics/)
	* AWS IoT Analytics is a fully-managed service that makes it easy to run and operationalize sophisticated analytics on massive volumes of IoT data without having to worry about the cost and complexity typically required to build an IoT analytics platform.
* [AWSSDK.IotData](https://www.nuget.org/packages/AWSSDK.IotData/)
	* AWS IoT-Data enables secure, bi-directional communication between Internet-connected things (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud. It implements a broker for applications and things to publish messages over HTTP (Publish) and retrieve, update, and delete thing shadows. A thing shadow is a persistent representation of your things and their state in the AWS cloud.
* [AWSSDK.IoTDeviceAdvisor](https://www.nuget.org/packages/AWSSDK.IoTDeviceAdvisor/)
	* AWS IoT Core Device Advisor is fully managed test capability for IoT devices. Device manufacturers can use Device Advisor to test their IoT devices for reliable and secure connectivity with AWS IoT.
* [AWSSDK.IoTEvents](https://www.nuget.org/packages/AWSSDK.IoTEvents/)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* [AWSSDK.IoTEventsData](https://www.nuget.org/packages/AWSSDK.IoTEventsData/)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* [AWSSDK.IoTFleetHub](https://www.nuget.org/packages/AWSSDK.IoTFleetHub/)
	* AWS IoT Fleet Hub, a new feature of AWS IoT Device Management that provides a web application for monitoring and managing device fleets connected to AWS IoT at scale.
* [AWSSDK.IoTFleetWise](https://www.nuget.org/packages/AWSSDK.IoTFleetWise/)
	* General availability (GA) for AWS IoT Fleetwise. It adds AWS IoT Fleetwise to AWS SDK. For more information, see https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/Welcome.html.
* [AWSSDK.IoTJobsDataPlane](https://www.nuget.org/packages/AWSSDK.IoTJobsDataPlane/)
	* This release adds support for new the service called Iot Jobs. This client is built for the device SDK to use Iot Jobs Device specific APIs.
* [AWSSDK.IoTRoboRunner](https://www.nuget.org/packages/AWSSDK.IoTRoboRunner/)
	* AWS IoT RoboRunner is a new service that makes it easy to build applications that help multi-vendor robots work together seamlessly. See the IoT RoboRunner developer guide for more details on getting started. https://docs.aws.amazon.com/iotroborunner/latest/dev/iotroborunner-welcome.html
* [AWSSDK.IoTSecureTunneling](https://www.nuget.org/packages/AWSSDK.IoTSecureTunneling/)
	* This release adds support for IoT Secure Tunneling to remote access devices behind restricted firewalls.
* [AWSSDK.IoTSiteWise](https://www.nuget.org/packages/AWSSDK.IoTSiteWise/)
	* AWS IoT SiteWise is a managed service that makes it easy to collect, store, organize and monitor data from industrial equipment at scale. You can use AWS IoT SiteWise to model your physical assets, processes and facilities, quickly compute common industrial performance metrics, and create fully managed web applications to help analyze industrial equipment data, prevent costly equipment issues, and reduce production inefficiencies.
* [AWSSDK.IoTThingsGraph](https://www.nuget.org/packages/AWSSDK.IoTThingsGraph/)
	* Initial Release.
* [AWSSDK.IoTTwinMaker](https://www.nuget.org/packages/AWSSDK.IoTTwinMaker/)
	* AWS IoT TwinMaker makes it faster and easier to create, visualize and monitor digital twins of real-world systems like buildings, factories and industrial equipment to optimize operations. Learn more: https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/Welcome.html (New Service) (Preview)
* [AWSSDK.IoTWireless](https://www.nuget.org/packages/AWSSDK.IoTWireless/)
	* AWS IoT for LoRaWAN enables customers to setup a private LoRaWAN network by connecting their LoRaWAN devices and gateways to the AWS cloud without managing a LoRaWAN Network Server.
* [AWSSDK.IVS](https://www.nuget.org/packages/AWSSDK.IVS/)
	* Introducing Amazon Interactive Video Service - a managed live streaming solution that is quick and easy to set up, and ideal for creating interactive video experiences.
* [AWSSDK.Ivschat](https://www.nuget.org/packages/AWSSDK.Ivschat/)
	* Adds new APIs for IVS Chat, a feature for building interactive chat experiences alongside an IVS broadcast.
* [AWSSDK.Kafka](https://www.nuget.org/packages/AWSSDK.Kafka/)
	* Amazon Managed Streaming for Kafka (Amazon MSK). Amazon MSK is a service that you can use to easily build, monitor, and manage Apache Kafka clusters in the cloud.
* [AWSSDK.KafkaConnect](https://www.nuget.org/packages/AWSSDK.KafkaConnect/)
	* This is the initial SDK release for Amazon Managed Streaming for Apache Kafka Connect (MSK Connect).
* [AWSSDK.Kendra](https://www.nuget.org/packages/AWSSDK.Kendra/)
	* It is a preview launch of Amazon Kendra. Amazon Kendra is a managed, highly accurate and easy to use enterprise search service that is powered by machine learning.
* [AWSSDK.KendraRanking](https://www.nuget.org/packages/AWSSDK.KendraRanking/)
	* Introducing Amazon Kendra Intelligent Ranking, a new set of Kendra APIs that leverages Kendra semantic ranking capabilities to improve the quality of search results from other search services (i.e. OpenSearch, ElasticSearch, Solr).
* [AWSSDK.KeyManagementService](https://www.nuget.org/packages/AWSSDK.KeyManagementService/)
	* AWS Key Management Service (KMS) is a managed service that makes it easy for you to create and control the encryption keys used to encrypt your data, and uses Hardware Security Modules (HSMs) to protect the security of your keys.
* [AWSSDK.Keyspaces](https://www.nuget.org/packages/AWSSDK.Keyspaces/)
	* This release adds support for data definition language (DDL) operations
* [AWSSDK.Kinesis](https://www.nuget.org/packages/AWSSDK.Kinesis/)
	* Amazon Kinesis is a fully managed, cloud-based service for real-time processing of large, distributed data streams.
* [AWSSDK.KinesisAnalytics](https://www.nuget.org/packages/AWSSDK.KinesisAnalytics/)
	* Amazon Kinesis Analytics is a fully managed service for continuously querying streaming data using standard SQL.
* [AWSSDK.KinesisAnalyticsV2](https://www.nuget.org/packages/AWSSDK.KinesisAnalyticsV2/)
	* Amazon Kinesis Data Analytics now supports Java-based stream processing applications, in addition to the previously supported SQL. Now, you can use your own Java code in Amazon Kinesis Data Analytics to build and run stream processing applications. This new capability also comes with an update to the previous Amazon Kinesis Data Analytics APIs to enable support for different runtime environments and more.
* [AWSSDK.KinesisFirehose](https://www.nuget.org/packages/AWSSDK.KinesisFirehose/)
	* Amazon Kinesis Firehose is a fully managed service for ingesting data streams directly into AWS data services such as Amazon S3 and Amazon Redshift.
* [AWSSDK.KinesisVideo](https://www.nuget.org/packages/AWSSDK.KinesisVideo/)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* [AWSSDK.KinesisVideoArchivedMedia](https://www.nuget.org/packages/AWSSDK.KinesisVideoArchivedMedia/)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* [AWSSDK.KinesisVideoMedia](https://www.nuget.org/packages/AWSSDK.KinesisVideoMedia/)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* [AWSSDK.KinesisVideoSignalingChannels](https://www.nuget.org/packages/AWSSDK.KinesisVideoSignalingChannels/)
	* Announcing support for WebRTC in Kinesis Video Streams, as fully managed capability. You can now use simple APIs to enable your connected devices, web, and mobile apps with real-time two-way media streaming capabilities.
* [AWSSDK.KinesisVideoWebRTCStorage](https://www.nuget.org/packages/AWSSDK.KinesisVideoWebRTCStorage/)
	* Amazon Kinesis Video Streams offers capabilities to stream video and audio in real-time via WebRTC to the cloud for storage, playback, and analytical processing. Customers can use our enhanced WebRTC SDK and cloud APIs to enable real-time streaming, as well as media ingestion to the cloud.
* [AWSSDK.LakeFormation](https://www.nuget.org/packages/AWSSDK.LakeFormation/)
	* Lake Formation: (New Service) AWS Lake Formation is a fully managed service that makes it easier for customers to build, secure and manage data lakes.  AWS Lake Formation simplifies and automates many of the complex manual steps usually required to create data lakes including collecting, cleaning and cataloging data and securely making that data available for analytics and machine learning.
* [AWSSDK.Lambda](https://www.nuget.org/packages/AWSSDK.Lambda/)
	* AWS Lambda is a compute service that runs your code in response to events and automatically manages the compute resources for you, making it easy to build applications that respond quickly to new information.
* [AWSSDK.Lex](https://www.nuget.org/packages/AWSSDK.Lex/)
	* Amazon Lex is a service for building conversational interactions into any application using voice or text.
* [AWSSDK.LexModelBuildingService](https://www.nuget.org/packages/AWSSDK.LexModelBuildingService/)
	* Amazon Lex is a service for building conversational interfaces into any application using voice and text.
* [AWSSDK.LexModelsV2](https://www.nuget.org/packages/AWSSDK.LexModelsV2/)
	* This release adds support for Amazon Lex V2 APIs for model building.
* [AWSSDK.LexRuntimeV2](https://www.nuget.org/packages/AWSSDK.LexRuntimeV2/)
	* This release adds support for Amazon Lex V2 APIs for runtime, including Streaming APIs for conversation management.
* [AWSSDK.LicenseManager](https://www.nuget.org/packages/AWSSDK.LicenseManager/)
	* AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.
* [AWSSDK.LicenseManagerLinuxSubscriptions](https://www.nuget.org/packages/AWSSDK.LicenseManagerLinuxSubscriptions/)
	* AWS License Manager now offers cross-region, cross-account tracking of commercial Linux subscriptions on AWS. This includes subscriptions purchased as part of EC2 subscription-included AMIs, on the AWS Marketplace, or brought to AWS via Red Hat Cloud Access Program.
* [AWSSDK.LicenseManagerUserSubscriptions](https://www.nuget.org/packages/AWSSDK.LicenseManagerUserSubscriptions/)
	* This release supports user based subscription for Microsoft Visual Studio Professional and Enterprise on EC2.
* [AWSSDK.Lightsail](https://www.nuget.org/packages/AWSSDK.Lightsail/)
	* An extremely simplified VM creation and management service.
* [AWSSDK.LocationService](https://www.nuget.org/packages/AWSSDK.LocationService/)
	* Initial release of Amazon Location Service. A new geospatial service providing capabilities to render maps, geocode/reverse geocode, track device locations, and detect geofence entry/exit events.
* [AWSSDK.LookoutEquipment](https://www.nuget.org/packages/AWSSDK.LookoutEquipment/)
	* This release introduces support for Amazon Lookout for Equipment.
* [AWSSDK.LookoutforVision](https://www.nuget.org/packages/AWSSDK.LookoutforVision/)
	* This release introduces support for Amazon Lookout for Vision.
* [AWSSDK.LookoutMetrics](https://www.nuget.org/packages/AWSSDK.LookoutMetrics/)
	* Amazon Lookout for Metrics is now generally available. You can use Lookout for Metrics to monitor your data for anomalies. For more information, see the Amazon Lookout for Metrics Developer Guide.
* [AWSSDK.MachineLearning](https://www.nuget.org/packages/AWSSDK.MachineLearning/)
	* Amazon Machine Learning is a service that makes it easy for developers of all skill levels to use machine learning technology.
* [AWSSDK.Macie](https://www.nuget.org/packages/AWSSDK.Macie/)
	* Amazon Macie is a security service that uses machine learning to automatically discover, classify, and protect sensitive data in AWS. With this release, we are launching the following Macie HTTPS API operations: AssociateMemberAccount, AssociateS3Resources, DisassociateMemberAccount, DisassociateS3Resources, ListMemberAccounts, ListS3Resources, and UpdateS3Resources. With these API operations you can issue HTTPS requests directly to the service.
* [AWSSDK.Macie2](https://www.nuget.org/packages/AWSSDK.Macie2/)
	* This release introduces a new major version of the Amazon Macie API. You can use this version of the API to develop tools and applications that interact with the new Amazon Macie.
* [AWSSDK.MainframeModernization](https://www.nuget.org/packages/AWSSDK.MainframeModernization/)
	* AWS Mainframe Modernization service is a managed mainframe service and set of tools for planning, migrating, modernizing, and running mainframe workloads on AWS
* [AWSSDK.ManagedBlockchain](https://www.nuget.org/packages/AWSSDK.ManagedBlockchain/)
	* (New Service) Amazon Managed Blockchain is a fully managed service that makes it easy to create and manage scalable blockchain networks using popular open source frameworks.
* [AWSSDK.ManagedGrafana](https://www.nuget.org/packages/AWSSDK.ManagedGrafana/)
	* Initial release of the SDK for Amazon Managed Grafana API.
* [AWSSDK.MarketplaceCatalog](https://www.nuget.org/packages/AWSSDK.MarketplaceCatalog/)
	* This is the first release for the AWS Marketplace Catalog service which allows you to list, describe and manage change requests on your published entities on AWS Marketplace. 
* [AWSSDK.MarketplaceEntitlementService](https://www.nuget.org/packages/AWSSDK.MarketplaceEntitlementService/)
	* AWS Marketplace Entitlement Service enables AWS Marketplace sellers to determine the capacity purchased by their customers.
* [AWSSDK.MediaConnect](https://www.nuget.org/packages/AWSSDK.MediaConnect/)
	* This is the initial release for AWS Elemental MediaConnect, an ingest and transport service for live video. This new AWS service allows broadcasters and content owners to send high-value live content into the cloud, securely transmit it to partners for distribution, and replicate it to multiple destinations around the globe.
* [AWSSDK.MediaConvert](https://www.nuget.org/packages/AWSSDK.MediaConvert/)
	* AWS Elemental MediaConvert is a file-based video conversion service that transforms media into formats required for traditional broadcast and for internet streaming to multi-screen devices.
* [AWSSDK.MediaLive](https://www.nuget.org/packages/AWSSDK.MediaLive/)
	* AWS Elemental MediaLive is a video service that lets you easily create live outputs for broadcast and streaming delivery.
* [AWSSDK.MediaPackage](https://www.nuget.org/packages/AWSSDK.MediaPackage/)
	* AWS Elemental MediaPackage is a just-in-time video packaging and origination service that lets you format highly secure and reliable live outputs for a variety of devices.
* [AWSSDK.MediaPackageVod](https://www.nuget.org/packages/AWSSDK.MediaPackageVod/)
	* AWS Elemental MediaPackage now supports Video-on-Demand (VOD) workflows. These new features allow you to easily deliver a vast library of source video Assets stored in your own S3 buckets using a small set of simple to set up Packaging Configurations and Packaging Groups.
* [AWSSDK.MediaStore](https://www.nuget.org/packages/AWSSDK.MediaStore/)
	* AWS Elemental MediaStore is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore acts as the origin store in your video workflow.
* [AWSSDK.MediaStoreData](https://www.nuget.org/packages/AWSSDK.MediaStoreData/)
	* AWS Elemental MediaStore Data is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore Data acts as the origin store in your video workflow.
* [AWSSDK.MediaTailor](https://www.nuget.org/packages/AWSSDK.MediaTailor/)
	* AWS Elemental MediaTailor is a personalization and monetization service that allows scalable server-side ad insertion. The service enables you to serve targeted ads to viewers while maintaining broadcast quality in over-the-top (OTT) video applications. This SDK allows user access to the AWS Elemental MediaTailor configuration interface.
* [AWSSDK.MemoryDB](https://www.nuget.org/packages/AWSSDK.MemoryDB/)
	* AWS MemoryDB  SDK now supports all APIs for newly launched MemoryDB service.
* [AWSSDK.Mgn](https://www.nuget.org/packages/AWSSDK.Mgn/)
	* Add new service - Application Migration Service.
* [AWSSDK.MigrationHub](https://www.nuget.org/packages/AWSSDK.MigrationHub/)
	* AWS Migration Hub provides a single location to track migrations across multiple AWS and partner solutions. Using Migration Hub allows you to choose the AWS and partner migration tools that best fit your needs, while providing visibility into the status of your entire migration portfolio. Migration Hub also provides key metrics and progress for individual applications, regardless of which tools are being used to migrate them. For example, you might use AWS Database Migration Service, AWS Server Migration Service, and partner migration tools to migrate an application comprised of a database, virtualized web servers, and a bare metal server. Using Migration Hub will provide you with a single screen that shows the migration progress of all the resources in the application. This allows you to quickly get progress updates across all of your migrations, easily identify and troubleshoot any issues, and reduce the overall time and effort spent on your migration projects. Migration Hub is available to all AWS customers at no additional charge. You only pay for the cost of the migration tools you use, and any resources being consumed on AWS. 
* [AWSSDK.MigrationHubConfig](https://www.nuget.org/packages/AWSSDK.MigrationHubConfig/)
	* AWS Migration Hub Config Service allows you to get and set the Migration Hub home region for use with AWS Migration Hub and Application Discovery Service
* [AWSSDK.MigrationHubOrchestrator](https://www.nuget.org/packages/AWSSDK.MigrationHubOrchestrator/)
	* Introducing AWS MigrationHubOrchestrator. This is the first public release of AWS MigrationHubOrchestrator.
* [AWSSDK.MigrationHubRefactorSpaces](https://www.nuget.org/packages/AWSSDK.MigrationHubRefactorSpaces/)
	* This is the initial SDK release for AWS Migration Hub Refactor Spaces
* [AWSSDK.MigrationHubStrategyRecommendations](https://www.nuget.org/packages/AWSSDK.MigrationHubStrategyRecommendations/)
	* AWS SDK for Migration Hub Strategy Recommendations. It includes APIs to start the portfolio assessment, import portfolio data for assessment, and to retrieve recommendations. For more information, see the AWS Migration Hub documentation at https://docs.aws.amazon.com/migrationhub/index.html
* [AWSSDK.Mobile](https://www.nuget.org/packages/AWSSDK.Mobile/)
	* AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.
* [AWSSDK.MobileAnalytics](https://www.nuget.org/packages/AWSSDK.MobileAnalytics/)
	* Amazon Mobile Analytics is a service that lets you simply and cost effectively collect and analyze your application usage data. In addition to providing usage summary charts that are available for quick reference, Amazon Mobile Analytics enables you to set up automatic export of your data to Amazon S3 for use with other data analytics tools such as Amazon Redshift, Amazon Elastic MapReduce (EMR), Extract, Transform and Load (ETL) software, or your own data warehouse.
* [AWSSDK.MQ](https://www.nuget.org/packages/AWSSDK.MQ/)
	* This is the initial SDK release for Amazon MQ. Amazon MQ is a managed message broker service for Apache ActiveMQ that makes it easy to set up and operate message brokers in the cloud.
* [AWSSDK.MTurk](https://www.nuget.org/packages/AWSSDK.MTurk/)
	* Amazon MTurk is a web service that provides an on-demand, scalable, human workforce to complete jobs that humans can do better than computers, for example, recognizing objects in photos.
* [AWSSDK.MWAA](https://www.nuget.org/packages/AWSSDK.MWAA/)
	* (New Service) Amazon MWAA is a managed service for Apache Airflow that makes it easy for data engineers and data scientists to execute data processing workflows in the cloud.
* [AWSSDK.Neptune](https://www.nuget.org/packages/AWSSDK.Neptune/)
	* Amazon Neptune is a fast, reliable graph database service that makes it easy to build and run applications that work with highly connected datasets. Neptune supports popular graph models Property Graph and W3C's Resource Description Frame (RDF), and their respective query languages Apache TinkerPop Gremlin 3.3.2 and SPARQL 1.1. 
* [AWSSDK.NetworkFirewall](https://www.nuget.org/packages/AWSSDK.NetworkFirewall/)
	* (New Service) AWS Network Firewall is a managed network layer firewall service that makes it easy to secure your virtual private cloud (VPC) networks and block malicious traffic.
* [AWSSDK.NetworkManager](https://www.nuget.org/packages/AWSSDK.NetworkManager/)
	* This is the initial SDK release for AWS Network Manager.
* [AWSSDK.NimbleStudio](https://www.nuget.org/packages/AWSSDK.NimbleStudio/)
	* Amazon Nimble Studio is a virtual studio service that empowers visual effects, animation, and interactive content teams to create content securely within a scalable, private cloud service.
* [AWSSDK.OAM](https://www.nuget.org/packages/AWSSDK.OAM/)
	* Amazon CloudWatch Observability Access Manager is a new service that allows configuration of the CloudWatch cross-account observability feature.
* [AWSSDK.Omics](https://www.nuget.org/packages/AWSSDK.Omics/)
	* Amazon Omics is a new, purpose-built service that can be used by healthcare and life science organizations to store, query, and analyze omics data. The insights from that data can be used to accelerate scientific discoveries and improve healthcare.
* [AWSSDK.OpenSearchServerless](https://www.nuget.org/packages/AWSSDK.OpenSearchServerless/)
	* Publish SDK for Amazon OpenSearch Serverless
* [AWSSDK.OpenSearchService](https://www.nuget.org/packages/AWSSDK.OpenSearchService/)
	* Updated Configuration APIs for Amazon OpenSearch Service (successor to Amazon Elasticsearch Service)
* [AWSSDK.OpsWorks](https://www.nuget.org/packages/AWSSDK.OpsWorks/)
	* AWS OpsWorks is an application management service that makes it easy to deploy and operate applications of all shapes and sizes. You can define the application's architecture and the specification of each component including package installation, software configuration and resources such as storage.
* [AWSSDK.OpsWorksCM](https://www.nuget.org/packages/AWSSDK.OpsWorksCM/)
	* AWS OpsWorks for Chef Automate gives customers a single tenant Chef Automate server. The Chef Automate server is fully managed by AWS and supports automatic backup, restore and upgrade operations.
* [AWSSDK.Organizations](https://www.nuget.org/packages/AWSSDK.Organizations/)
	* AWS Organizations is a web service that enables you to consolidate your multiple AWS accounts into an organization and centrally manage your accounts and their resources.
* [AWSSDK.Outposts](https://www.nuget.org/packages/AWSSDK.Outposts/)
	* This is the initial release for AWS Outposts, a fully managed service that extends AWS infrastructure, services, APIs, and tools to customer sites. AWS Outposts enables you to launch and run EC2 instances and EBS volumes locally at your on-premises location. This release introduces new APIs for creating and viewing Outposts. 
* [AWSSDK.Panorama](https://www.nuget.org/packages/AWSSDK.Panorama/)
	* General availability for AWS Panorama. AWS SDK for Panorama includes APIs to manage your devices and nodes, and deploy computer vision applications to the edge. For more information, see the AWS Panorama documentation at http://docs.aws.amazon.com/panorama
* [AWSSDK.Personalize](https://www.nuget.org/packages/AWSSDK.Personalize/)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* [AWSSDK.PersonalizeEvents](https://www.nuget.org/packages/AWSSDK.PersonalizeEvents/)
	* Introducing Amazon Personalize  - a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* [AWSSDK.PersonalizeRuntime](https://www.nuget.org/packages/AWSSDK.PersonalizeRuntime/)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* [AWSSDK.PI](https://www.nuget.org/packages/AWSSDK.PI/)
	* Performance Insights is a feature of Amazon Relational Database Service (RDS) that helps you quickly assess the load on your database, and determine when and where to take action. You can use the SDK to retrieve Performance Insights data and integrate your monitoring solutions.
* [AWSSDK.Pinpoint](https://www.nuget.org/packages/AWSSDK.Pinpoint/)
	* Amazon Pinpoint makes it easy to run targeted campaigns to improve user engagement. Pinpoint helps you understand your users behavior, define who to target, what messages to send, when to deliver them, and tracks the results of the campaign.
* [AWSSDK.PinpointEmail](https://www.nuget.org/packages/AWSSDK.PinpointEmail/)
	* This is the first release of the Amazon Pinpoint Email API. You can use this API to configure and send transactional email from your Amazon Pinpoint account to specific email addresses. Unlike campaign-based email that you send from Amazon Pinpoint, you don't have to create segments and campaigns in order to send transactional email. 
* [AWSSDK.PinpointSMSVoice](https://www.nuget.org/packages/AWSSDK.PinpointSMSVoice/)
	* With Amazon Pinpoint Voice, you can use text-to-speech technology to deliver personalized voice messages to your customers. Amazon Pinpoint Voice is a way to deliver transactional messages -- such as one-time passwords and appointment confirmations to customers.
* [AWSSDK.PinpointSMSVoiceV2](https://www.nuget.org/packages/AWSSDK.PinpointSMSVoiceV2/)
	* Amazon Pinpoint now offers a version 2.0 suite of SMS and voice APIs, providing increased control over sending and configuration. This release is a new SDK for sending SMS and voice messages called PinpointSMSVoiceV2.
* [AWSSDK.Pipes](https://www.nuget.org/packages/AWSSDK.Pipes/)
	* AWS introduces new Amazon EventBridge Pipes which allow you to connect sources (SQS, Kinesis, DDB, Kafka, MQ) to Targets (14+ EventBridge Targets) without any code, with filtering, batching, input transformation, and an optional Enrichment stage (Lambda, StepFunctions, ApiGateway, ApiDestinations)
* [AWSSDK.Polly](https://www.nuget.org/packages/AWSSDK.Polly/)
	* Amazon Polly is a service that turns text into lifelike speech, making it easy to develop applications that use high-quality speech to increase engagement and accessibility.
* [AWSSDK.Pricing](https://www.nuget.org/packages/AWSSDK.Pricing/)
	* We launched new service, Price List Service.
* [AWSSDK.Private5G](https://www.nuget.org/packages/AWSSDK.Private5G/)
	* This is the initial SDK release for AWS Private 5G. AWS Private 5G is a managed service that makes it easy to deploy, operate, and scale your own private mobile network at your on-premises location.
* [AWSSDK.PrometheusService](https://www.nuget.org/packages/AWSSDK.PrometheusService/)
	* (New Service) Amazon Managed Service for Prometheus is a fully managed Prometheus-compatible monitoring service that makes it easy to monitor containerized applications securely and at scale.
* [AWSSDK.Proton](https://www.nuget.org/packages/AWSSDK.Proton/)
	* This is the initial SDK release for AWS Proton
* [AWSSDK.QLDB](https://www.nuget.org/packages/AWSSDK.QLDB/)
	* Introduces operations needed for managing Amazon QLDB ledgers. This includes the ability to create, delete, modify, and describe Amazon QLDB ledgers. This also includes the ability to cryptographically verify documents and export the journal in a ledger.
* [AWSSDK.QLDBSession](https://www.nuget.org/packages/AWSSDK.QLDBSession/)
	* Amazon QLDB introduces the SendCommand API to interact with data in Amazon QLDB ledgers.
* [AWSSDK.QuickSight](https://www.nuget.org/packages/AWSSDK.QuickSight/)
	* Amazon QuickSight is a fully managed, serverless, cloud business intelligence system that allows you to extend data and insights to every user in your organization. The first release of APIs for Amazon QuickSight introduces embedding and user/group management capabilities. The get-dashboard-embed-url API allows you to obtain an authenticated dashboard URL that can be embedded in application domains whitelisted for QuickSight dashboard embedding. User APIs allow you to programmatically expand and manage your QuickSight deployments while group APIs allow easier permissions management for resources within QuickSight.
* [AWSSDK.RAM](https://www.nuget.org/packages/AWSSDK.RAM/)
	* AWS Resource Access Manager (AWS RAM) enables you to share your resources with any AWS account or through AWS Organizations.
* [AWSSDK.RDS](https://www.nuget.org/packages/AWSSDK.RDS/)
	* Amazon Relational Database Service (Amazon RDS) is a web service that makes it easy to set up, operate, and scale a relational database in the cloud. It provides cost-efficient and resizable capacity while managing time-consuming database management tasks, freeing you up to focus on your applications and business.
* [AWSSDK.RDSDataService](https://www.nuget.org/packages/AWSSDK.RDSDataService/)
	* Amazon RDS Data Service API is an HTTP endpoint to run SQL statements on an Amazon Aurora Serverless DB cluster.
* [AWSSDK.RecycleBin](https://www.nuget.org/packages/AWSSDK.RecycleBin/)
	* This release adds support for Recycle Bin.
* [AWSSDK.Redshift](https://www.nuget.org/packages/AWSSDK.Redshift/)
	* Amazon Redshift is a fast, fully managed, petabyte-scale data warehouse solution that makes it simple and cost-effective to efficiently analyze all your data using your existing business intelligence tools.
* [AWSSDK.RedshiftDataAPIService](https://www.nuget.org/packages/AWSSDK.RedshiftDataAPIService/)
	* The Amazon Redshift Data API is generally available. This release enables querying Amazon Redshift data and listing various database objects.
* [AWSSDK.RedshiftServerless](https://www.nuget.org/packages/AWSSDK.RedshiftServerless/)
	* Add new API operations for Amazon Redshift Serverless, a new way of using Amazon Redshift without needing to manually manage provisioned clusters. The new operations let you interact with Redshift Serverless resources, such as create snapshots, list VPC endpoints, delete resource policies, and more.
* [AWSSDK.Rekognition](https://www.nuget.org/packages/AWSSDK.Rekognition/)
	* AWS Rekognition service does image processing and concept recognition, face detection and identification, face verification, similar face search and face clustering.
* [AWSSDK.ResilienceHub](https://www.nuget.org/packages/AWSSDK.ResilienceHub/)
	* Initial release of AWS Resilience Hub, a managed service that enables you to define, validate, and track the resilience of your applications on AWS
* [AWSSDK.ResourceExplorer2](https://www.nuget.org/packages/AWSSDK.ResourceExplorer2/)
	* This is the initial SDK release for AWS Resource Explorer. AWS Resource Explorer lets your users search for and discover your AWS resources across the AWS Regions in your account.
* [AWSSDK.ResourceGroups](https://www.nuget.org/packages/AWSSDK.ResourceGroups/)
	* AWS Resource Groups lets you search and group AWS resources from multiple services based on their tags.
* [AWSSDK.ResourceGroupsTaggingAPI](https://www.nuget.org/packages/AWSSDK.ResourceGroupsTaggingAPI/)
	* Resource Groups Tagging APIs can help you organize your resources and enable you to simplify resource management, access management, and cost allocation.
* [AWSSDK.RoboMaker](https://www.nuget.org/packages/AWSSDK.RoboMaker/)
	* (New Service) AWS RoboMaker is a service that makes it easy to develop, simulate, and deploy intelligent robotics applications at scale. 
* [AWSSDK.Route53](https://www.nuget.org/packages/AWSSDK.Route53/)
	* Amazon Route 53 is a highly available and scalable cloud Domain Name System (DNS) web service.
* [AWSSDK.Route53Domains](https://www.nuget.org/packages/AWSSDK.Route53Domains/)
	* Amazon Route 53 is a highly available and scalable cloud Domain Name System (DNS) web service.
* [AWSSDK.Route53RecoveryCluster](https://www.nuget.org/packages/AWSSDK.Route53RecoveryCluster/)
	* Amazon Route 53 Application Recovery Controller's routing control - Routing Control Data Plane APIs help you update the state (On/Off) of the routing controls to reroute traffic across application replicas in a 100% available manner.
* [AWSSDK.Route53RecoveryControlConfig](https://www.nuget.org/packages/AWSSDK.Route53RecoveryControlConfig/)
	* Amazon Route 53 Application Recovery Controller's routing control - Routing Control Configuration APIs help you create and delete clusters, control panels, routing controls and safety rules. State changes (On/Off) of routing controls are not part of configuration APIs.
* [AWSSDK.Route53RecoveryReadiness](https://www.nuget.org/packages/AWSSDK.Route53RecoveryReadiness/)
	* Amazon Route 53 Application Recovery Controller's readiness check capability continually monitors resource quotas, capacity, and network routing policies to ensure that the recovery environment is scaled and configured to take over when needed.
* [AWSSDK.Route53Resolver](https://www.nuget.org/packages/AWSSDK.Route53Resolver/)
	* This is the first release of the Amazon Route 53 Resolver API. Customers now have the ability to create and manage Amazon Route 53 Resolver endpoints and Amazon Route 53 Resolver rules.
* [AWSSDK.S3](https://www.nuget.org/packages/AWSSDK.S3/)
	* Amazon Simple Storage Service (Amazon S3), provides developers and IT teams with secure, durable, highly-scalable object storage.
* [AWSSDK.S3Control](https://www.nuget.org/packages/AWSSDK.S3Control/)
	* Add support for new S3 Block Public Access account-level APIs. The Block Public Access settings allow account owners to prevent public access to S3 data via bucket/object ACLs or bucket policies.
* [AWSSDK.S3Outposts](https://www.nuget.org/packages/AWSSDK.S3Outposts/)
	* Amazon S3 on Outposts expands object storage to on-premises AWS Outposts environments, enabling you to store and retrieve objects using S3 APIs and features.
* [AWSSDK.SageMaker](https://www.nuget.org/packages/AWSSDK.SageMaker/)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* [AWSSDK.SagemakerEdgeManager](https://www.nuget.org/packages/AWSSDK.SagemakerEdgeManager/)
	* Amazon SageMaker Edge Manager makes it easy to optimize, secure, monitor, and maintain  machine learning (ML) models across fleets of edge devices such as smart cameras, smart speakers, and robots.
* [AWSSDK.SageMakerFeatureStoreRuntime](https://www.nuget.org/packages/AWSSDK.SageMakerFeatureStoreRuntime/)
	* This release adds support for Amazon SageMaker Feature Store, which makes it easy for customers to create, version, share, and manage curated data for machine learning (ML) development.
* [AWSSDK.SageMakerGeospatial](https://www.nuget.org/packages/AWSSDK.SageMakerGeospatial/)
	* This release provides Amazon SageMaker geospatial APIs to build, train, deploy and visualize geospatial models.
* [AWSSDK.SageMakerMetrics](https://www.nuget.org/packages/AWSSDK.SageMakerMetrics/)
	* This release introduces support SageMaker Metrics APIs.
* [AWSSDK.SageMakerRuntime](https://www.nuget.org/packages/AWSSDK.SageMakerRuntime/)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* [AWSSDK.SavingsPlans](https://www.nuget.org/packages/AWSSDK.SavingsPlans/)
	* This is the first release of Savings Plans, a new flexible pricing model that offers low prices on Amazon EC2 and AWS Fargate usage.
* [AWSSDK.Scheduler](https://www.nuget.org/packages/AWSSDK.Scheduler/)
	* AWS introduces the new Amazon EventBridge Scheduler. EventBridge Scheduler is a serverless scheduler that allows you to create, run, and manage tasks from one central, managed service.
* [AWSSDK.Schemas](https://www.nuget.org/packages/AWSSDK.Schemas/)
	* This release introduces support for Amazon EventBridge schema registry, making it easy to discover and write code for events in EventBridge.
* [AWSSDK.SecretsManager](https://www.nuget.org/packages/AWSSDK.SecretsManager/)
	* AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps. Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials. You can automatically and frequently rotate your secrets without having to deploy updates to your apps. All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.
* [AWSSDK.SecurityHub](https://www.nuget.org/packages/AWSSDK.SecurityHub/)
	* AWS Security Hub provides you with a comprehensive view of your security state within AWS and your compliance with the security industry standards and best practices. Security Hub collects security data from across AWS accounts, services, and supported third-party partners and helps you analyze your security trends and identify the highest priority security issues.
* [AWSSDK.SecurityLake](https://www.nuget.org/packages/AWSSDK.SecurityLake/)
	* Amazon Security Lake automatically centralizes security data from cloud, on-premises, and custom sources into a purpose-built data lake stored in your account. Security Lake makes it easier to analyze security data, so you can improve the protection of your workloads, applications, and data
* [AWSSDK.SecurityToken](https://www.nuget.org/packages/AWSSDK.SecurityToken/)
	* The AWS Security Token Service (AWS STS) enables you to provide trusted users with temporary credentials that provide controlled access to your AWS resources.
* [AWSSDK.ServerlessApplicationRepository](https://www.nuget.org/packages/AWSSDK.ServerlessApplicationRepository/)
	* First release of the AWS Serverless Application Repository SDK.
* [AWSSDK.ServerMigrationService](https://www.nuget.org/packages/AWSSDK.ServerMigrationService/)
	* AWS Server Migration Service (SMS) is an agentless service which makes it easier and faster for you to migrate thousands of on-premises workloads to AWS.
* [AWSSDK.ServiceCatalog](https://www.nuget.org/packages/AWSSDK.ServiceCatalog/)
	* AWS Service Catalog allows organizations to create and manage catalogs of IT services that are approved for use on AWS.
* [AWSSDK.ServiceDiscovery](https://www.nuget.org/packages/AWSSDK.ServiceDiscovery/)
	* AWS Cloud Map lets you configure public DNS, private DNS, or HTTP namespaces that your microservice applications run in. When an instance of the service becomes available, you can call the AWS Cloud Map API to register the instance with AWS Cloud Map. For public or private DNS namespaces, AWS Cloud Map automatically creates DNS records and an optional health check. Clients that submit public or private DNS queries, or HTTP requests, for the service receive an answer that contains up to eight healthy records.
* [AWSSDK.ServiceQuotas](https://www.nuget.org/packages/AWSSDK.ServiceQuotas/)
	* Service Quotas enables you to view and manage your quotas for AWS services from a central location.
* [AWSSDK.Shield](https://www.nuget.org/packages/AWSSDK.Shield/)
	* AWS Shield protects web applications from large and sophisticated DDoS attacks at Layer 3, 4 and 7. In addition AWS Shield provides visibility in attacks, and access to 24X7 DDoS Response Team.
* [AWSSDK.Signer](https://www.nuget.org/packages/AWSSDK.Signer/)
	* With code signing for IoT, you can sign code that you create for any IoT device that is supported by Amazon Web Services (AWS). Code signing is available through Amazon FreeRTOS and AWS IoT Device Management, and integrated with AWS Certificate Manager (ACM).
* [AWSSDK.SimpleDB](https://www.nuget.org/packages/AWSSDK.SimpleDB/)
	* Amazon SimpleDB is a highly available, scalable, and flexible non-relational data store that enables you to store and query data items using web services requests.
* [AWSSDK.SimpleEmail](https://www.nuget.org/packages/AWSSDK.SimpleEmail/)
	* Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.
* [AWSSDK.SimpleEmailV2](https://www.nuget.org/packages/AWSSDK.SimpleEmailV2/)
	* This is the first release of version 2 of the Amazon SES API. You can use this API to configure your Amazon SES account, and to send email. This API extends the functionality that exists in the previous version of the Amazon SES API.
* [AWSSDK.SimpleNotificationService](https://www.nuget.org/packages/AWSSDK.SimpleNotificationService/)
	* Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.
* [AWSSDK.SimpleSystemsManagement](https://www.nuget.org/packages/AWSSDK.SimpleSystemsManagement/)
	* Amazon EC2 Simple Systems Manager (SSM) enables you to manage a number of administrative and configuration tasks on your instances.
* [AWSSDK.SimpleWorkflow](https://www.nuget.org/packages/AWSSDK.SimpleWorkflow/)
	* Amazon SWF helps developers build, run, and scale background jobs that have parallel or sequential steps. You can think of Amazon SWF as a fully-managed state tracker and task coordinator in the Cloud.
* [AWSSDK.SimSpaceWeaver](https://www.nuget.org/packages/AWSSDK.SimSpaceWeaver/)
	* AWS SimSpace Weaver is a new service that helps customers build spatial simulations at new levels of scale - resulting in virtual worlds with millions of dynamic entities. See the AWS SimSpace Weaver developer guide for more details on how to get started. https://docs.aws.amazon.com/simspaceweaver
* [AWSSDK.Snowball](https://www.nuget.org/packages/AWSSDK.Snowball/)
	* Amazon Snowball is a petabyte-scale data transport solution that uses secure appliances to transfer large amounts of data into and out of the AWS cloud
* [AWSSDK.SnowDeviceManagement](https://www.nuget.org/packages/AWSSDK.SnowDeviceManagement/)
	* AWS Snow Family customers can remotely monitor and operate their connected AWS Snowcone devices.
* [AWSSDK.SQS](https://www.nuget.org/packages/AWSSDK.SQS/)
	* Amazon Simple Queue Service (SQS) is a fast, reliable, scalable, fully managed message queuing service. SQS makes it simple and cost-effective to decouple the components of a cloud application.
* [AWSSDK.SSMContacts](https://www.nuget.org/packages/AWSSDK.SSMContacts/)
	* AWS Systems Manager Incident Manager enables faster resolution of critical application availability and performance issues, management of contacts and post incident analysis
* [AWSSDK.SSMIncidents](https://www.nuget.org/packages/AWSSDK.SSMIncidents/)
	* AWS Systems Manager Incident Manager enables faster resolution of critical application availability and performance issues, management of contacts and post-incident analysis
* [AWSSDK.SsmSap](https://www.nuget.org/packages/AWSSDK.SsmSap/)
	* AWS Systems Manager for SAP provides simplified operations and management of SAP applications such as SAP HANA. With this release, SAP customers and partners can automate and simplify their SAP system administration tasks such as backup/restore of SAP HANA.
* [AWSSDK.SSO](https://www.nuget.org/packages/AWSSDK.SSO/)
	* This is an initial release of AWS Single Sign-On (SSO) end-user access. This release adds support for accessing AWS accounts assigned in AWS SSO using short term credentials.
* [AWSSDK.SSOAdmin](https://www.nuget.org/packages/AWSSDK.SSOAdmin/)
	* This is an initial release of AWS Single Sign-On (SSO) Access Management APIs. This release adds support for SSO operations which could be used for managing access to AWS accounts.
* [AWSSDK.SSOOIDC](https://www.nuget.org/packages/AWSSDK.SSOOIDC/)
	* This is an initial release of AWS Single Sign-On OAuth device code authorization service.
* [AWSSDK.StepFunctions](https://www.nuget.org/packages/AWSSDK.StepFunctions/)
	* AWS Step Functions is a web service that enables you to coordinate a network of computing resources across distributed components using state machines.
* [AWSSDK.StorageGateway](https://www.nuget.org/packages/AWSSDK.StorageGateway/)
	* The AWS Storage Gateway is a service connecting an on-premises software appliance with cloud-based storage to provide seamless and secure integration between an organization's on-premises IT environment and AWS's storage infrastructure.
* [AWSSDK.SupportApp](https://www.nuget.org/packages/AWSSDK.SupportApp/)
	* This is the initial SDK release for the AWS Support App in Slack.
* [AWSSDK.Synthetics](https://www.nuget.org/packages/AWSSDK.Synthetics/)
	* Introducing CloudWatch Synthetics. This is the first public release of CloudWatch Synthetics.
* [AWSSDK.Textract](https://www.nuget.org/packages/AWSSDK.Textract/)
	* Amazon Textract enables you to add document text detection and analysis to your applications. You provide a document image to the Amazon Textract API, and the service detects the document text. Amazon Textract works with formatted text and can detect words and lines of words that are located close to each other. It can also analyze a document for items such as related text, tables, key-value pairs, and selection elements.
* [AWSSDK.TimestreamQuery](https://www.nuget.org/packages/AWSSDK.TimestreamQuery/)
	* (New Service) Amazon Timestream is a fast, scalable, fully managed, purpose-built time series database that makes it easy to store and analyze trillions of time series data points per day.
* [AWSSDK.TimestreamWrite](https://www.nuget.org/packages/AWSSDK.TimestreamWrite/)
	* (New Service) Amazon Timestream is a fast, scalable, fully managed, purpose-built time series database that makes it easy to store and analyze trillions of time series data points per day.
* [AWSSDK.TranscribeService](https://www.nuget.org/packages/AWSSDK.TranscribeService/)
	* Amazon Transcribe Public Preview Release
* [AWSSDK.Transfer](https://www.nuget.org/packages/AWSSDK.Transfer/)
	* AWS Transfer for SFTP is a fully managed service that enables transfer of secure data over the internet into and out of Amazon S3. SFTP is deeply embedded in data exchange workflows across different industries such as financial services, healthcare, advertising, and retail, among others.
* [AWSSDK.Translate](https://www.nuget.org/packages/AWSSDK.Translate/)
	* Public preview release of Amazon Translate and the Amazon Translate Developer Guide. For more information, see the Amazon Translate Developer Guide.
* [AWSSDK.VoiceID](https://www.nuget.org/packages/AWSSDK.VoiceID/)
	* Released the Amazon Voice ID SDK, for usage with the Amazon Connect Voice ID feature released for Amazon Connect.
* [AWSSDK.WAF](https://www.nuget.org/packages/AWSSDK.WAF/)
	* AWS WAF (Web Application Firewall) protects web applications from attack by allowing customers to block bad actors and provides filters against common web exploits like SQL injection.
* [AWSSDK.WAFRegional](https://www.nuget.org/packages/AWSSDK.WAFRegional/)
	* AWS WAF (Web Application Firewall) Regional protects web applications from attack via ALB load balancer and provides API to associate it with a WAF WebACL.
* [AWSSDK.WAFV2](https://www.nuget.org/packages/AWSSDK.WAFV2/)
	* This release introduces new set of APIs (wafv2) for AWS WAF. Major changes include single set of APIs for creating/updating resources in global and regional scope, and rules are configured directly into web ACL instead of being referenced. The previous APIs (waf and waf-regional) are now referred as AWS WAF Classic. For more information visit: https://docs.aws.amazon.com/waf/latest/APIReference/Welcome.html
* [AWSSDK.WellArchitected](https://www.nuget.org/packages/AWSSDK.WellArchitected/)
	* This is the first release of AWS Well-Architected Tool API support, use to review your workload and compare against the latest AWS architectural best practices.
* [AWSSDK.WorkDocs](https://www.nuget.org/packages/AWSSDK.WorkDocs/)
	* Amazon WorkDocs is a fully managed, secure enterprise storage and sharing service with strong administrative controls and feedback capabilities that improve user productivity.
* [AWSSDK.WorkLink](https://www.nuget.org/packages/AWSSDK.WorkLink/)
	* This is the initial SDK release for Amazon WorkLink. Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. With Amazon WorkLink, employees can access internal websites as seamlessly as they access any other website. IT administrators can manage users, devices, and domains by enforcing their own security and access policies via the AWS Console or the AWS SDK.
* [AWSSDK.WorkMail](https://www.nuget.org/packages/AWSSDK.WorkMail/)
	* Today, Amazon WorkMail released an administrative SDK and enabled AWS CloudTrail integration. With the administrative SDK, you can natively integrate WorkMail with your existing services. The SDK enables programmatic user, resource, and group management through API calls. This means your existing IT tools and workflows can now automate WorkMail management, and third party applications can streamline WorkMail migrations and account actions.
* [AWSSDK.WorkMailMessageFlow](https://www.nuget.org/packages/AWSSDK.WorkMailMessageFlow/)
	* This release allows customers to access email messages as they flow to and from Amazon WorkMail.
* [AWSSDK.WorkSpaces](https://www.nuget.org/packages/AWSSDK.WorkSpaces/)
	* Amazon WorkSpaces is a managed desktop computing service in the cloud.
* [AWSSDK.WorkSpacesWeb](https://www.nuget.org/packages/AWSSDK.WorkSpacesWeb/)
	* This is the initial SDK release for Amazon WorkSpaces Web. Amazon WorkSpaces Web is a low-cost, fully managed WorkSpace built to deliver secure web-based workloads and software-as-a-service (SaaS) application access to users within existing web browsers.
* [AWSSDK.XRay](https://www.nuget.org/packages/AWSSDK.XRay/)
	* AWS X-Ray helps developers analyze and debug distributed applications. With X-Ray, you can understand how your application and its underlying services are performing to identify and troubleshoot the root cause of performance issues and errors.

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
[docs-api]: http://docs.aws.amazon.com/sdkfornet/v3/apidocs/Index.html
[docs-signup]: http://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/net-dg-hosm.html
[docs-guide]: http://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/welcome.html
[credentials-management]: http://docs.aws.amazon.com/sdk-for-net/latest/developer-guide/net-dg-config-creds.html
[dotnet-blog]: http://blogs.aws.amazon.com/net/
[github-aws-sdk-net-v2]: https://github.com/aws/aws-sdk-net/tree/aws-sdk-net-v2


