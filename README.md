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

## Portable Class Library

This release of the AWS SDK for .NET adds support for Portable Class Library projects, which allow you to target multiple platforms including Windows Store, Windows Phone, and Xamarin on iOS and Android. More information on this can be found [here](http://docs.aws.amazon.com/mobile/sdkforxamarin/developerguide/index.html).

## Unity Support

This release of AWS SDK for .NET adds support for generating Assemblies for Unity. More information can be found [here](Unity.README.md)

### Silverlight support

Due to Silverlight HTTP Caching, AWS SDK for .NET is not fully supported on Silverlight-based platforms such as Windows Phone 8.0. Some HTTP GET calls (such as S3's ListBuckets or ListObjects) will return the same results when called multiple times.

## Tests

**Important:** Do not run the integration tests on a production account.

Integration tests can be found in the **AWSSDK.IntegrationTests** project. These test assume that a default profile has been 
configured for credentials. For information about setting up a default profile read the [Developer Guide][credentials-management].

The tests are designed to create and delete the resources needed for testing but it is important to keep your data safe. Do not run
these tests on accounts that contain production data or resources. Since AWS resources are created and deleted during the running 
of these tests, charges can occur. To reduce charges occurred by running the tests the test focus on AWS resources that have minimal cost.

Unit tests can be found in the **AWSSDK.UnitTests** project.

### NuGet Packages

* [AWSSDK.APIGateway](https://www.nuget.org/packages/AWSSDK.APIGateway/)
	* Amazon API Gateway helps developers deliver robust, secure and scalable mobile and web application backends. Amazon API Gateway allows developers to securely connect mobile and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly addressable web services that are hosted outside of AWS.
* [AWSSDK.ApplicationAutoScaling](https://www.nuget.org/packages/AWSSDK.ApplicationAutoScaling/)
	* Application Auto Scaling is a general purpose Auto Scaling service for supported elastic AWS resources. With Application Auto Scaling, you can automatically scale your AWS resources, with an experience similar to that of Amazon EC2 Auto Scaling.
* [AWSSDK.ApplicationDiscoveryService](https://www.nuget.org/packages/AWSSDK.ApplicationDiscoveryService/)
	* AWS Application Discovery Service helps Systems Integrators quickly and reliably plan application migration projects by automatically identifying applications running in your data center, their associated dependencies, and their performance profile.
* [AWSSDK.AutoScaling](https://www.nuget.org/packages/AWSSDK.AutoScaling/)
	* Auto Scaling helps you maintain application availability and allows you to scale your capacity up or down automatically according to conditions you define.
* [AWSSDK.AWSMarketplaceCommerceAnalytics](https://www.nuget.org/packages/AWSSDK.AWSMarketplaceCommerceAnalytics/)
	* The AWS Marketplace Commerce Analytics service allows marketplace partners to programmatically request business intelligence data from AWS Marketplace. This service provides the same data that was previously only available through the AWS Marketplace Management Portal, but offers the data in a fully-machine-readable format and available in fine-grained data sets rather than large reports.
* [AWSSDK.AWSMarketplaceMetering](https://www.nuget.org/packages/AWSSDK.AWSMarketplaceMetering/)
	* The AWS Marketplace Metering Service enables sellers to price their products along new pricing dimensions. After a integrating their product with the AWS Marketplace Metering Service, that product will emit an hourly record capturing the usage of any single pricing dimension. Buyers can easily subscribe to software priced by this new dimension on the AWS Marketplace website and only pay for what they use.
* [AWSSDK.AWSSupport](https://www.nuget.org/packages/AWSSDK.AWSSupport/)
	* The AWS Support API provides methods for creating and managing AWS Support cases and for retrieving the results of AWS Trusted Advisor checks.
* [AWSSDK.CertificateManager](https://www.nuget.org/packages/AWSSDK.CertificateManager/)
	* AWS Certificate Manager (ACM) is an AWS service that makes it easier for you to deploy secure SSL based websites and applications on the AWS platform.
* [AWSSDK.CloudFormation](https://www.nuget.org/packages/AWSSDK.CloudFormation/)
	* AWS CloudFormation gives developers and systems administrators an easy way to create and manage a collection of related AWS resources, provisioning and updating them in an orderly and predictable fashion.
* [AWSSDK.CloudFront](https://www.nuget.org/packages/AWSSDK.CloudFront/)
	* Amazon CloudFront is a content delivery web service. It integrates with other Amazon Web Services products to give developers and businesses an easy way to distribute content to end users with low latency, high data transfer speeds, and no minimum usage commitments.
* [AWSSDK.CloudHSM](https://www.nuget.org/packages/AWSSDK.CloudHSM/)
	* The AWS CloudHSM service helps you meet corporate, contractual and regulatory compliance requirements for data security by using dedicated Hardware Security Module (HSM) appliances within the AWS cloud. With CloudHSM, you control the encryption keys and cryptographic operations performed by the HSM.
* [AWSSDK.CloudSearch](https://www.nuget.org/packages/AWSSDK.CloudSearch/)
	* Amazon CloudSearch is a managed service in the AWS Cloud that makes it simple and cost-effective to set up, manage, and scale a search solution for your website or application.
* [AWSSDK.CloudSearchDomain](https://www.nuget.org/packages/AWSSDK.CloudSearchDomain/)
	* Amazon CloudSearch is a managed service in the AWS Cloud that makes it simple and cost-effective to set up, manage, and scale a search solution for your website or application.
* [AWSSDK.CloudTrail](https://www.nuget.org/packages/AWSSDK.CloudTrail/)
	* AWS CloudTrail is a web service that records AWS API calls for your account and delivers log files to you. The recorded information includes the identity of the API caller, the time of the API call, the source IP address of the API caller, the request parameters, and the response elements returned by the AWS service.
* [AWSSDK.CloudWatch](https://www.nuget.org/packages/AWSSDK.CloudWatch/)
	* Amazon CloudWatch is a monitoring service for AWS cloud resources and the applications you run on AWS. You can use Amazon CloudWatch to collect and track metrics, collect and monitor log files, and set alarms.
* [AWSSDK.CloudWatchEvents](https://www.nuget.org/packages/AWSSDK.CloudWatchEvents/)
	* Amazon CloudWatch Events helps you to respond to state changes in your AWS resources. When your resources change state they automatically send events into an event stream. You can create rules that match selected events in the stream and route them to targets to take action. You can also use rules to take action on a pre-determined schedule.
* [AWSSDK.CloudWatchLogs](https://www.nuget.org/packages/AWSSDK.CloudWatchLogs/)
	* Amazon CloudWatch is a monitoring service for AWS cloud resources and the applications you run on AWS. You can use Amazon CloudWatch to collect and track metrics, collect and monitor log files, and set alarms.
* [AWSSDK.CodeCommit](https://www.nuget.org/packages/AWSSDK.CodeCommit/)
	* AWS CodeCommit is a fully-managed source control service that makes it easy for companies to host secure and highly scalable private Git repositories.
* [AWSSDK.CodeDeploy](https://www.nuget.org/packages/AWSSDK.CodeDeploy/)
	* AWS CodeDeploy is a service that automates code deployments. AWS CodeDeploy makes it easier for you to rapidly release new features, helps you avoid downtime during deployment, and handles the complexity of updating your applications.
* [AWSSDK.CodePipeline](https://www.nuget.org/packages/AWSSDK.CodePipeline/)
	* AWS CodePipeline is a continuous delivery service for fast and reliable application updates.
* [AWSSDK.CognitoIdentity](https://www.nuget.org/packages/AWSSDK.CognitoIdentity/)
	* Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.
* [AWSSDK.CognitoIdentityProvider](https://www.nuget.org/packages/AWSSDK.CognitoIdentityProvider/)
	* You can create a user pool in Amazon Cognito Identity to manage directories and users. You can authenticate a user to obtain tokens related to user identity and access policies. This API reference provides information about user pools in Amazon Cognito Identity, which is a new capability that is available as a beta.
* [AWSSDK.CognitoSync](https://www.nuget.org/packages/AWSSDK.CognitoSync/)
	* Amazon Cognito is a service that makes it easy to save user data, such as app preferences or game state, in the AWS Cloud without writing any backend code or managing any infrastructure. With Amazon Cognito, you can focus on creating great app experiences instead of having to worry about building and managing a backend solution to handle identity management, network state, storage, and sync.
* [AWSSDK.ConfigService](https://www.nuget.org/packages/AWSSDK.ConfigService/)
	* AWS Config is a fully managed service that provides you with an AWS resource inventory, configuration history, and configuration change notifications to enable security and governance.
* [AWSSDK.DatabaseMigrationService](https://www.nuget.org/packages/AWSSDK.DatabaseMigrationService/)
	* AWS Database Migration Service (AWS DMS) can migrate your data to and from most widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft SQL Server, Amazon Aurora, MariaDB, and MySQL. The service supports homogeneous migrations such as Oracle to Oracle, and also heterogeneous migrations between different database platforms, such as Oracle to MySQL or MySQL to Amazon Aurora.
* [AWSSDK.DataPipeline](https://www.nuget.org/packages/AWSSDK.DataPipeline/)
	* AWS Data Pipeline is a managed extract-transform-load (ETL) service that helps you reliably and cost-effectively move and process data across your on-premise data stores and AWS services.
* [AWSSDK.DeviceFarm](https://www.nuget.org/packages/AWSSDK.DeviceFarm/)
	* AWS Device Farm is an app testing service that enables you to test your Android and Fire OS apps on real, physical phones and tablets that are hosted by AWS. The service allows you to upload your own tests or use built-in, script-free compatibility tests.
* [AWSSDK.DirectConnect](https://www.nuget.org/packages/AWSSDK.DirectConnect/)
	* AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to AWS. Using AWS Direct Connect, you can establish private connectivity between AWS and your datacenter, office, or colocation environment, which in many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than Internet-based connections.
* [AWSSDK.DirectoryService](https://www.nuget.org/packages/AWSSDK.DirectoryService/)
	* AWS Directory Service is a managed service that allows you to connect your AWS resources with an existing on-premises Microsoft Active Directory or to set up a new, stand-alone directory in the AWS Cloud.
* [AWSSDK.DynamoDBv2](https://www.nuget.org/packages/AWSSDK.DynamoDBv2/)
	* Amazon DynamoDB is a fast and flexible NoSQL database service for all applications that need consistent, single-digit millisecond latency at any scale.
* [AWSSDK.EC2](https://www.nuget.org/packages/AWSSDK.EC2/)
	* Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to make web-scale cloud computing easier for developers.
* [AWSSDK.ECR](https://www.nuget.org/packages/AWSSDK.ECR/)
	* Amazon EC2 Container Registry (Amazon ECR) is a managed AWS Docker registry service. Customers can use the familiar Docker CLI to push, pull, and manage images.
* [AWSSDK.ECS](https://www.nuget.org/packages/AWSSDK.ECS/)
	* Amazon EC2 Container Service is a highly scalable, high performance container management service that supports Docker containers and allows you to easily run distributed applications on a managed cluster of Amazon EC2 instances.
* [AWSSDK.ElastiCache](https://www.nuget.org/packages/AWSSDK.ElastiCache/)
	* ElastiCache is a web service that makes it easy to deploy, operate, and scale an in-memory cache in the cloud. The service improves the performance of web applications by allowing you to retrieve information from fast, managed, in-memory caches, instead of relying entirely on slower disk-based databases.
* [AWSSDK.ElasticBeanstalk](https://www.nuget.org/packages/AWSSDK.ElasticBeanstalk/)
	* AWS Elastic Beanstalk is an easy-to-use service for deploying and scaling web applications and services developed with Java, .NET, PHP, Node.js, Python, Ruby, Go, and Docker on familiar servers such as Apache, Nginx, Passenger, and IIS.
* [AWSSDK.ElasticFileSystem](https://www.nuget.org/packages/AWSSDK.ElasticFileSystem/)
	* Amazon Elastic File System (Amazon EFS) is a file storage service for Amazon Elastic Compute Cloud (Amazon EC2) instances.
* [AWSSDK.ElasticLoadBalancing](https://www.nuget.org/packages/AWSSDK.ElasticLoadBalancing/)
	* Elastic Load Balancing automatically distributes incoming application traffic across multiple compute instances in the cloud.
* [AWSSDK.ElasticMapReduce](https://www.nuget.org/packages/AWSSDK.ElasticMapReduce/)
	* Amazon Elastic MapReduce (Amazon EMR) is a web service that makes it easy to quickly and cost-effectively process vast amounts of data.
* [AWSSDK.Elasticsearch](https://www.nuget.org/packages/AWSSDK.Elasticsearch/)
	* Use the Amazon Elasticsearch configuration API to create, configure, and manage Elasticsearch domains.
* [AWSSDK.ElasticTranscoder](https://www.nuget.org/packages/AWSSDK.ElasticTranscoder/)
	* Amazon Elastic Transcoder is media transcoding in the cloud. It is designed to be a highly scalable, easy to use and a cost effective way for developers and businesses to convert (or 'transcode') media files from their source format into versions that will playback on devices like smartphones, tablets and PCs.
* [AWSSDK.GameLift](https://www.nuget.org/packages/AWSSDK.GameLift/)
	* Amazon GameLift Service is a managed AWS service for developers who need a scalable, server-based solution for multiplayer games.
* [AWSSDK.Glacier](https://www.nuget.org/packages/AWSSDK.Glacier/)
	* Amazon Glacier is a secure, durable, and extremely low-cost storage service for data archiving and online backup.
* [AWSSDK.IdentityManagement](https://www.nuget.org/packages/AWSSDK.IdentityManagement/)
	* AWS Identity and Access Management (IAM) enables you to securely control access to AWS services and resources for your users. Using IAM, you can create and manage AWS users and groups, and use permissions to allow and deny their access to AWS resources.
* [AWSSDK.ImportExport](https://www.nuget.org/packages/AWSSDK.ImportExport/)
	* AWS Import/Export accelerates moving large amounts of data into and out of the AWS cloud using portable storage devices for transport.
* [AWSSDK.Inspector](https://www.nuget.org/packages/AWSSDK.Inspector/)
	* Amazon Inspector identifies security issues in your application deployments.
* [AWSSDK.IoT](https://www.nuget.org/packages/AWSSDK.IoT/)
	* AWS IoT allows you to leverage AWS to build your Internet of Things.
* [AWSSDK.IotData](https://www.nuget.org/packages/AWSSDK.IotData/)
	* AWS IoT-Data enables secure, bi-directional communication between Internet-connected things (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud. It implements a broker for applications and things to publish messages over HTTP (Publish) and retrieve, update, and delete thing shadows. A thing shadow is a persistent representation of your things and their state in the AWS cloud.
* [AWSSDK.KeyManagementService](https://www.nuget.org/packages/AWSSDK.KeyManagementService/)
	* AWS Key Management Service (KMS) is a managed service that makes it easy for you to create and control the encryption keys used to encrypt your data, and uses Hardware Security Modules (HSMs) to protect the security of your keys.
* [AWSSDK.Kinesis](https://www.nuget.org/packages/AWSSDK.Kinesis/)
	* Amazon Kinesis is a fully managed, cloud-based service for real-time processing of large, distributed data streams.
* [AWSSDK.KinesisFirehose](https://www.nuget.org/packages/AWSSDK.KinesisFirehose/)
	* Amazon Kinesis Firehose is a fully managed service for ingesting data streams directly into AWS data services such as Amazon S3 and Amazon Redshift.
* [AWSSDK.Lambda](https://www.nuget.org/packages/AWSSDK.Lambda/)
	* AWS Lambda is a compute service that runs your code in response to events and automatically manages the compute resources for you, making it easy to build applications that respond quickly to new information.
* [AWSSDK.MachineLearning](https://www.nuget.org/packages/AWSSDK.MachineLearning/)
	* Amazon Machine Learning is a service that makes it easy for developers of all skill levels to use machine learning technology.
* [AWSSDK.MobileAnalytics](https://www.nuget.org/packages/AWSSDK.MobileAnalytics/)
	* Amazon Mobile Analytics is a service that lets you simply and cost effectively collect and analyze your application usage data. In addition to providing usage summary charts that are available for quick reference, Amazon Mobile Analytics enables you to set up automatic export of your data to Amazon S3 for use with other data analytics tools such as Amazon Redshift, Amazon Elastic MapReduce (EMR), Extract, Transform and Load (ETL) software, or your own data warehouse.
* [AWSSDK.OpsWorks](https://www.nuget.org/packages/AWSSDK.OpsWorks/)
	* AWS OpsWorks is an application management service that makes it easy to deploy and operate applications of all shapes and sizes. You can define the application's architecture and the specification of each component including package installation, software configuration and resources such as storage.
* [AWSSDK.RDS](https://www.nuget.org/packages/AWSSDK.RDS/)
	* Amazon Relational Database Service (Amazon RDS) is a web service that makes it easy to set up, operate, and scale a relational database in the cloud. It provides cost-efficient and resizable capacity while managing time-consuming database management tasks, freeing you up to focus on your applications and business.
* [AWSSDK.Redshift](https://www.nuget.org/packages/AWSSDK.Redshift/)
	* Amazon Redshift is a fast, fully managed, petabyte-scale data warehouse solution that makes it simple and cost-effective to efficiently analyze all your data using your existing business intelligence tools.
* [AWSSDK.Route53](https://www.nuget.org/packages/AWSSDK.Route53/)
	* Amazon Route 53 is a highly available and scalable cloud Domain Name System (DNS) web service.
* [AWSSDK.Route53Domains](https://www.nuget.org/packages/AWSSDK.Route53Domains/)
	* Amazon Route 53 is a highly available and scalable cloud Domain Name System (DNS) web service.
* [AWSSDK.S3](https://www.nuget.org/packages/AWSSDK.S3/)
	* Amazon Simple Storage Service (Amazon S3), provides developers and IT teams with secure, durable, highly-scalable object storage.
* [AWSSDK.SecurityToken](https://www.nuget.org/packages/AWSSDK.SecurityToken/)
	* The AWS Security Token Service (AWS STS) enables you to provide trusted users with temporary credentials that provide controlled access to your AWS resources.
* [AWSSDK.SimpleDB](https://www.nuget.org/packages/AWSSDK.SimpleDB/)
	* Amazon SimpleDB is a highly available, scalable, and flexible non-relational data store that enables you to store and query data items using web services requests.
* [AWSSDK.SimpleEmail](https://www.nuget.org/packages/AWSSDK.SimpleEmail/)
	* Amazon SES is an outbound-only email-sending service that provides an easy, cost-effective way for you to send email.
* [AWSSDK.SimpleNotificationService](https://www.nuget.org/packages/AWSSDK.SimpleNotificationService/)
	* Amazon Simple Notification Service (Amazon SNS) is a fast, flexible, fully managed push messaging service. Amazon SNS makes it simple and cost-effective to push notifications to Apple, Google, Fire OS, and Windows devices, as well as Android devices in China with Baidu Cloud Push.  You can also use SNS to push notifications to internet connected smart devices, as well as other distributed services.
* [AWSSDK.SimpleSystemsManagement](https://www.nuget.org/packages/AWSSDK.SimpleSystemsManagement/)
	* Amazon EC2 Simple Systems Manager (SSM) enables you to manage a number of administrative and configuration tasks on your instances.
* [AWSSDK.SimpleWorkflow](https://www.nuget.org/packages/AWSSDK.SimpleWorkflow/)
	* Amazon SWF helps developers build, run, and scale background jobs that have parallel or sequential steps. You can think of Amazon SWF as a fully-managed state tracker and task coordinator in the Cloud.
* [AWSSDK.SQS](https://www.nuget.org/packages/AWSSDK.SQS/)
	* Amazon Simple Queue Service (SQS) is a fast, reliable, scalable, fully managed message queuing service. SQS makes it simple and cost-effective to decouple the components of a cloud application.
* [AWSSDK.StorageGateway](https://www.nuget.org/packages/AWSSDK.StorageGateway/)
	* The AWS Storage Gateway is a service connecting an on-premises software appliance with cloud-based storage to provide seamless and secure integration between an organization's on-premises IT environment and AWS's storage infrastructure.
* [AWSSDK.WAF](https://www.nuget.org/packages/AWSSDK.WAF/)
	* AWS WAF (Web Application Firewall) protects web applications from attack by allowing customers to block bad actors and provides filters against common web exploits like SQL injection.
* [AWSSDK.WorkSpaces](https://www.nuget.org/packages/AWSSDK.WorkSpaces/)
	* Amazon WorkSpaces is a managed desktop computing service in the cloud.

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
[docs-signup]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-setup.html
[aws-iam-credentials]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-roles.html
[docs-guide]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/welcome.html
[credentials-management]: http://docs.aws.amazon.com/AWSSdkDocsNET/latest/DeveloperGuide/net-dg-config-creds.html
[dotnet-blog]: http://blogs.aws.amazon.com/net/
[github-aws-sdk-net-v2]: https://github.com/aws/aws-sdk-net/tree/aws-sdk-net-v2


