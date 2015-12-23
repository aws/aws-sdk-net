### 3.1.36.0 (2015-12-21 22:04 UTC)
* ECR (3.1.0.0)
	* Add SDK support for the Amazon EC2 Container Registry, a secure, fully-managed Docker image registry that makes it easy for developers to store and retrieve Docker container images.
* ECS (3.1.3.0)
	* Add support for deployment configuration.
* ElasticMapReduce (3.1.2.0)
	* Update RunJobFlow to accept the ServiceSecurityGroup parameter.
* SecurityToken (3.1.1.1)
	* Fix a bug in SAML assertion parsing where there are duplicate role names.

### 3.1.35.1 (2015-12-18 22:31 UTC)
* IoT (3.1.0.4)
	* Documentation update
* IotData (3.1.0.2)
	* Documentation update

### 3.1.35.0 (2015-12-17 22:20 UTC)
* CloudFront (3.1.2.0)
	* For web distributions, you can now configure CloudFront to automatically compress files of certain types for both Amazon S3 and custom origins, so downloads are faster and your web pages render faster. Compression also reduces your CloudFront data transfer cost because you pay for the total amount of data served.
* CloudTrail (3.1.2.0)
	* This release supports trails that apply across all regions, and support for multiple trails per region.
* ConfigService (3.1.3.0)
	* Update to add support for AWS Config rules. These rules enable users to evaluate whether their AWS resources comply with desired configuration settings.

Added support for Identity and Access Management (IAM) resource types.
* DynamoDBv2 (3.1.1.3)
	* Fix issue where a high retry count causes integer overflow - https://github.com/aws/aws-sdk-net/issues/286
* EC2 (3.1.7.0)
	* Added support for managed NAT, a highly available and scalable Network Address Translation (NAT) solution that enables Internet connectivity for instances in private subnets of a customer’s VPC
* RDS (3.1.7.0)
	* Add support for enhanced monitoring in RDS instances.
* Core 3.1.4.2
	* Fix issue where a high retry count causes integer overflow - https://github.com/aws/aws-sdk-net/issues/286.

Fix issue causing "Path cannot be the empty string or all whitespace" error when running under a user account that has no profile or home directory - https://github.com/aws/aws-sdk-net/issues/287.

 

### 3.1.34.0 (2015-12-15 19:02 UTC)
* EC2 (3.1.6.0)
	* Added new parameters to CopyImage API that allows a customer to create an AMI copy where all the associated EBS snapshots are encrypted.

### 3.1.33.0 (2015-12-08 20:22 UTC)
* AutoScaling (3.1.2.0)
	* Add support for SetInstanceProtection operation
* RDS (3.1.6.0)
	* Add RDS support for encrypting your databases using keys you manage through AWS Key Management Service (KMS).

### 3.1.32.1 (2015-12-08 00:15 UTC)
* Core 3.1.4.1
	* Improve exception handling in AsyncRunner https://github.com/aws/aws-sdk-net/issues/281

### 3.1.32.0 (2015-12-03 23:01 UTC)
* DirectoryService (3.1.1.0)
	* Support for managed directories
* RDS (3.1.5.0)
	* Added support for modifying DB port number via ModifyDbInstance.
* Route53 (3.1.2.0)
	* Added traffic policy support

### 3.1.31.0 (2015-12-01 23:16 UTC)
* CognitoIdentity (3.1.0.5)
	* Add api to clone logins dictionary
* ConfigService (3.1.2.1)
	* Support for new resource type - dedicated host.
* DynamoDBv2 (3.1.1.2)
	* Add PaginationToken support to DocumentModel Query and Scan operations.
	* Fix issue where ignored properties in DataModel were not being properly ignored.
* SecurityToken (3.1.1.0)
	* Implement support for SAML-based identity federation to vend temporary AWS credentials.
* Core 3.1.4.0
	* * Added new role credential and endpoint profile types to support SAML identity federation.
* Added Roslyn code analyzers to all NuGet service packages.
	* all services packages updated to require new core
* Throwing exceptions if constructing a request with bidirectional control characters
	* Fix for https://github.com/aws/aws-sdk-net/issues/212

### 3.1.30.0 (2015-11-23 23:14 UTC)
* EC2 (3.1.5.0)
	* This release includes support for EC2 Dedicated Hosts. This feature enables the use of your own per-socket and per-core OS licenses in EC2. This release also supports two new APIs, ModifyIdFormat and DescribeIdFormat, that will be used to manage the transition to longer EC2 and EBS resource IDs. These APIs are reserved for future use.
* ECS (3.1.2.0)
	* Add support for Amazon ECS task stopped reasons and task start and stop times. You can now see if a task was stopped by a user or stopped due to other reasons such as a failing Elastic Load Balancing health check, as well as the time the task was started and stopped. Service scheduler error messages have additional information that describe why tasks cannot be placed in the cluster.
* ElasticBeanstalk (3.1.2.0)
	* Add support for AWS Elastic Beanstalk for composable web applications. Customers whose applications consists of several linked modules (micro services architecture) can now deploy, manage, and scale their applications using EB.
* S3 (3.1.3.8)
	* Added missing canned ACL.

### 3.1.29.1 (2015-11-20 21:46 UTC)
* CloudSearchDomain (3.1.0.4)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* EC2 (3.1.4.3)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* S3 (3.1.3.7)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* SQS (3.1.0.3)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* Core 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274 , response handler logic being called instead of skipped for .NET 3.5 async, when an exception is thrown in the pipeline.


### 3.1.29.0 (2015-11-19 18:42 UTC)
* DeviceFarm (3.1.3.0)
	* Added support for new test and upload types.

### 3.1.28.1 (2015-11-18 00:02 UTC)
* Inspector (3.1.0.1)
	* Documentation update.
* S3 (3.1.3.6)
	* Updated to use new Core, version 3.1.3.7
	* Increment version to pick up latest core patch for dealing with key edge cases.
* Core 3.1.3.7
	* Fix issue with AWS4Signer.

### 3.1.28.0 (2015-11-12 21:05 UTC)
* CognitoIdentity (3.1.0.4)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* CognitoSync (3.1.0.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* EC2 (3.1.4.2)
	* Documentation update
* Lambda (3.1.2.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* MobileAnalytics (3.1.1.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* RDS (3.1.4.0)
	* Added support for modifying DB instance visibility.
Updated documentation to note support for M4 types for DB instance class.

* Core 3.1.3.6
	* Minor fixes to ClientContext.

### 3.1.27.0 (2015-11-10 20:21 UTC)
* APIGateway (3.1.1.0)
	* Added support for stage variables.

### 3.1.26.1 (2015-11-07 01:22 UTC)
* IoT (3.1.0.2)
	* Updated to use new Core, version 3.1.3.5
	* Incremented Core package dependency to fix signature errors when a PUT or POST requests contains only query params (e.g. IOT AcceptCertificateTransfer, CreateKeysAndCertificate).
* Core 3.1.3.5
	* Fix for signature errors when a PUT or POST requests contains only query params (e.g. IOT AcceptCertificateTransfer, CreateKeysAndCertificate).

### 3.1.26.0 (2015-11-06 21:05 UTC)
* RDS (3.1.3.0)
	* Add support for sharing manual DB snapshots

### 3.1.25.0 (2015-11-03 21:41 UTC)
* DeviceFarm (3.1.2.0)
	* Added support for AWS Device Farm APIs to manage projects, device pools, runs, and uploads.
* S3 (3.1.3.5)
	* Add validation for S3 get object calls to make sure the object key is set. If it's not set, that makes the request the same as ListObject call to S3 giving unexpected results to the caller.
* Core 3.1.3.4
	* Fix for disposed instance of web request being used to get header values.

### 3.1.24.0 (2015-11-02 18:47 UTC)
* IdentityManagement (3.1.3.0)
	* Update IAM policy simulator to help test, verify, and understand resource-level permissions.

### 3.1.23.3 (2015-10-29 20:24 UTC)
* S3 (3.1.3.4)
	* Updated to use new Core, version 3.1.3.3
	* Fixed the minimum version of Core dependency.
* Core 3.1.3.3
	* Added AmazonDateTimeUnmarshallingException type.

### 3.1.23.2 (2015-10-28 20:27 UTC)
* APIGateway (3.1.0.1)
	* Update API Gateway model to fix PutIntegration calls.

### 3.1.23.1 (2015-10-27 04:42 UTC)
* S3 (3.1.3.3)
	* Fix issue with byte range for CopyPart operation

### 3.1.23.0 (2015-10-26 22:44 UTC)
* APIGateway (3.1.0.0)
	* Amazon API Gateway is a fully managed service that makes it easy for developers to create, publish, maintain, monitor, and secure APIs at any scale.
* S3 (3.1.3.2)
	* Fix to handle responses with invalid values in the expires header for S3 GetObject and GetObjectMetatdata APIs.

### 3.1.22.0 (2015-10-26 17:54 UTC)
* SimpleSystemsManagement (3.1.1.0)
	* EC2 Run Command
- A new EC2 feature that enables you to securely and remotely manage the configuration of your Amazon EC2 Windows instances. Run Command provides a simple way of automating common administrative tasks like executing scripts, running PowerShell commands, installing software or patches and more.

### 3.1.21.0 (2015-10-22 21:40 UTC)
* AutoScaling (3.1.1.0)
	* Adding support for EBS encryption in block device mappings.
* IdentityManagement (3.1.2.0)
	* Enable Policy Simulator API to do simulation with resource-based policies.
* Lambda (3.1.2.2)
	* Fix issue with invoking Lambda GetPolicy operation.

### 3.1.20.1 (2015-10-20 21:01 UTC)
* IoT (3.1.0.1)
	* Updated to use new Core, version 3.1.3.2
	* Rev version to pick up latest core patch for sending both a query string and a body.
* Lambda (3.1.2.1)
	* Updated to use new Core, version 3.1.3.2
	* Rev version to pick up latest core patch for sending both a query string and a body.
* Core 3.1.3.2
	* Fixed issue with operations that contain both a query string and a body.

### 3.1.20.0 (2015-10-15 19:24 UTC)
* KeyManagementService (3.1.1.0)
	* Add support for deleting Customer Master Keys, including two new APIs for scheduling and canceling key deletion.

### 3.1.19.1 (2015-10-14 21:43 UTC)
* Core 3.1.3.1
	* Fix issue with LitJson handling of null values in some cases.

### 3.1.19.0 (2015-10-07 23:16 UTC)
* ECS (3.1.1.0)
	* Task definitions now support more Docker options
* IoT (3.1.0.0)
	* AWS IoT offering enables our users to leverage the AWS Cloud for their Internet of things use-cases.
* IotData (3.1.0.0)
	* AWS IoT-Data enables secure, bi-directional communication between Internet-connected things (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud.
* Lambda (3.1.2.0)
	* Lambda now supports function versioning.

### 3.1.18.0 (2015-10-07 09:15 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.0.0)
	* Updated to use new Core, version 3.1.3.0
	* The AWS Marketplace Commerce Analytics service allows marketplace partners to programmatically request business intelligence data from AWS Marketplace. This service provides the same data that was previously only available through the AWS Marketplace Management Portal, but offers the data in a fully-machine-readable format and available in fine-grained data sets rather than large reports.
* ConfigService (3.1.2.0)
	* Added support for Config Rule and Evaluations.
* Inspector (3.1.0.0)
	* Amazon Inspector is a new service from AWS that identifies security issues in your application deployments. Use Inspector with your applications to assess your security posture and identify areas that can be improved. Inspector works with your EC2 Instances to monitor activity in the applications and system.
* Kinesis (3.1.2.0)
	* Added two new Amazon Kinesis APIs that allow customers to choose how long their data records are stored in their Amazon Kinesis streams.
* KinesisFirehose (3.1.0.0)
	* Amazon Kinesis Firehose is a fully managed service for ingesting data streams directly into AWS data services such as Amazon S3 and Amazon Redshift.
* Core 3.1.3.0
	* Updated the set of error codes that are automatically retried.

### 3.1.17.1 (2015-10-07 00:48 UTC)
* Core 3.1.2.1
	* Fixed issue where NullReferenceException could be thrown for certain SDK calls (https://github.com/aws/aws-sdk-net/issues/252).
	* all services packages updated to require new core

### 3.1.17.0 (2015-10-06 21:20 UTC)
* CloudFront (3.1.1.0)
	* Added support for integrating CloudFront with AWS WAF.
* EC2 (3.1.4.0)
	* Added new property BlockDurationMinutes to RequestSpotInstancesRequest. This specifies the duration for which the instance is required.
* WAF (3.1.0.0)
	* Updated to use new Core, version 3.1.2.0
	* Added support for AWS WAF (Web Application Firewall). AWS WAF protects web applications from attack by allowing customers to block bad actors and provides filters against common web exploits like SQL injection.
* Core 3.1.2.0
	* Added support for WAF.

### 3.1.16.0 (2015-10-01 21:11 UTC)
* CloudTrail (3.1.1.0)
	* Added new APIs for AWS CloudTrail: AddTags, ListTags, RemoveTags, and ListPublicKeys. This release of CloudTrail includes support for log file integrity validation, log encryption with AWS KMS–Managed Keys (SSE-KMS), and trail tagging.
* Elasticsearch (3.0.0.0)
	* Added support for the new Amazon Elasticsearch Service.
* RDS (3.1.2.0)
	* Added support for t2.large DB instance, support for copying tags to snapshot, and other minor updates.
* WorkSpaces (3.1.1.0)
	* Added support for user volume encryption.

### 3.1.15.0 (2015-09-29 23:12 UTC)
* CloudFormation (3.1.1.0)
	* Added new DescribeAccountLimits API and optional ResourceTypes parameter for CreateStack and UpdateStack APIs.
* EC2 (3.1.3.0)
	* Added support for the new ModifySpotFleetRequest API.
* SimpleEmail (3.1.1.0)
	* Amazon Simple Email Service can now accept incoming emails. You can configure Amazon SES to deliver messages to an Amazon S3 bucket, call an AWS Lambda function, publish notifications to Amazon SNS, drop messages, or bounce messages. Added new cmdlets to support this feature.

### 3.1.14.1 (2015-09-24 22:17 UTC)
* CognitoIdentity (3.1.0.2)
	* Documentation update.

### 3.1.14.0 (2015-09-17 19:21 UTC)
* CloudWatchLogs (3.1.2.0)
	* Added support for exporting log data from Log Groups to Amazon S3 Buckets.

### 3.1.13.0 (2015-09-16 19:35 UTC)
* S3 (3.1.3.0)
	* Added support for the new STANDARD_IA storage class and for multiple lifecycle transitions.

### 3.1.12.0 (2015-09-15 20:11 UTC)
* EC2 (3.1.2.0)
	* Added DataEncryptionKeyId and StateMessage properties to the Amazon.EC2.Model.Snapshot class, this data is returned by the DescribeSnapshots operation. Added AllocationStrategy property to the Amazon.EC2.Model.SpotFleetRequestConfigData class, this data is used by the RequestSpotFleet operation.
* ElasticFileSystem (3.1.1.0)
	* Added MountTargetId to Amazon.ElasticFileSystem.Model.DescribeMountTargetsRequest.
* MobileAnalytics (3.1.1.1)
	* Fixed FxCop violations, and minor refactoring.
* Route53 (3.1.1.0)
	* Added support for calculated and latency health checks.

### 3.1.11.0 (2015-09-10 17:43 UTC)
* ElasticMapReduce (3.1.1.0)
	* Deprecated DescribeJobFlows API.
* IdentityManagement (3.1.1.0)
	* Add support for IAM policy simulator.
* ImportExport (3.1.1.0)
	* Documentation update for ImportExport client.
* Kinesis (3.1.1.0)
	* Add timestamp field to Amazon.Kinesis.Model.Record type.
* Lambda (3.1.1.0)
	* Deprecated InvokeAsync API
* MachineLearning (3.1.1.0)
	* Documentation update for Amazon Machine Learning client.

### 3.1.10.1 (2015-09-04 20:30 UTC)
* Core 3.1.1.1
	* Included pull request https://github.com/aws/aws-sdk-net/pull/242 to fix signing issues for endpoints with a path component.

### 3.1.10.0 (2015-09-03 20:56 UTC)
* DynamoDBv2 (3.1.1.0)
	* Added enum support for DynamoDB DataModel.
* StorageGateway (3.1.1.0)
	* Add support for tagging StorageGateway resources.

### 3.1.9.0 (2015-08-31 21:22 UTC)
* EC2 (3.1.1.0)
	* Add support for spot fleet instance weights.

### 3.1.8.0 (2015-08-27 23:50 UTC)
* ConfigService (3.1.1.0)
	* Added support for ListDiscoveredResources.

### 3.1.7.0 (2015-08-27 00:39 UTC)
* MobileAnalytics (3.1.1.0)
	* Added MobileAnalyticsErrorEvent to Amazon Mobile Analytics and minor improvements.
* Core 3.1.1.0
	* Service packages updated to require new core, which includes FileLogger for PCL.

### 3.1.6.0 (2015-08-25 18:01 UTC)
* CodePipeline (3.1.1.0)
	* Add support for KMS encryption keys on S3 artifact stores.

### 3.1.5.0 (2015-08-12 20:11 UTC)
* ElasticBeanstalk (3.1.1.0)
	* Add Elastic Beanstalk client support for environment health.
* MobileAnalytics (3.1.0.2)
	* Updated to need new core version 3.1.0.2
	* Updated documentation
* S3 (3.1.2.0)
	* Updated S3 TransferUtility to retry a failed download without discarding the bytes that were already downloaded
* Core 3.1.0.2

### 3.1.4.0 (2015-08-06 15:55 UTC)
* SimpleWorkflow (3.1.1.0)
	* Update SWF client for Lambda support

### 3.1.3.0 (2015-08-04 21:59 UTC)
* DeviceFarm (3.1.1.0)
	* Update DeviceFarm client with latest model, adding support for iOS and retrieving account settings.

### 3.1.2.1 (2015-08-04 00:50 UTC)
* CloudSearchDomain (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Glacier (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Lambda (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* S3 (3.1.1.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Core 3.1.0.1
	* Fix PCL SigV4 signing issue where SHA256 hash is not always calculated correctly.

### 3.1.2.0 (2015-07-31 00:36 UTC)
* OpsWorks (3.1.1.0)
	* Add support for ECS clusters.
* RDS (3.1.1.0)
	* Add support for Amazon Aurora.

### 3.1.1.0 (2015-07-28 23:37 UTC)
* CloudWatchLogs (3.1.1.0)
	* Adding 4 new APIs: PutDestination, PutDestinationPolicy, DescribeDestinations and DeleteDestination
* S3 (3.1.1.0)
	* Support for new storage class headers on GET/HEAD requests.
	* Enhancements to S3 event notifications
		* Support for Deletes.
		* Support for Bucket Change events like policy changes and lifecycle changes
		* Support for filtering on object names including prefixes and suffixes.

### 3.1.0.0 (2015-07-28 20:30 UTC)
* The Version 3 of AWS SDK for .NET is out of preview and promoted to general availability.
* All service SDKs and Core assemblies are set to version 3.1.0.0 for this release.
* Xamarin support added to Portable Class Library (PCL) version of the SDK. The Xamarin and PCL versions of the SDK are available as public preview.
* Additional Changes
	* Pull request [222](https://github.com/aws/aws-sdk-net/pull/222) - Fix to code that resolves location of .aws\credentials file.
	* Fixed issue with setting ServiceURL for DynamoDB Streams client.

### 3.0.6.0 (2015-07-10 00:22 UTC)
* AutoScaling (3.0.2.0)
	* Step scaling policies allow customers to scale their Auto Scaling groups based on the magnitude of the alarm breach.
* CloudFront (3.0.2.0)
	* Amazon CloudFront now lets you configure a maximum time-to-live (TTL) and a default TTL to specify how long CloudFront caches your objects in edge locations.
* CodeCommit (3.0.0.0)
	* AWS CodeCommit is a secure, highly scalable, managed source control service that hosts private Git repositories.
* CodePipeline (3.0.0.0)
	* AWS CodePipeline is a continuous delivery service that enables you to model, visualize, and automate the steps required to release your software.
* CognitoIdentity (3.0.1.1)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* CognitoSync (3.0.0.3)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* ConfigService (3.0.1.0)
	* You can now set up AWS Config to record changes for specific resource types.
* EC2 (3.0.5.0)
	* You can now optionally enable encryption using AWS KMS keys when copying an unencrypted EBS snapshot.
* ECS (3.0.3.0)
	* You can now use the UDP protocol with containers on Amazon EC2 Container Service (ECS).
* Glacier (3.0.2.0)
	* Glacier vaults now support tagging.
* IdentityManagement (3.0.1.0)
	* You can upload SSH public keys to IAM and use those keys for	authentication with AWS CodeCommit. 
* Lambda (3.0.2.0)
	* You can now develop your AWS Lambda function code using Java.
* OpsWorks (3.0.2.0)
	* You can now manage updates of the agent software running on instances managed by AWS OpsWorks. 
* Redshift (3.0.1.0)
	* Redshift supports automatic cross-region backups for your KMS encrypted clusters for disaster recover.
* SimpleEmail (3.0.1.0)
	* Amazon Simple Email Service (Amazon SES) adds support for cross-account sending.
* Core 3.0.0.4

### 3.0.5.0 (2015-06-20 06:52 UTC)
* ECS (3.0.2.0)
	* You can now choose the sort order for task definitions, deregister task definitions, and override task definition environment variables when running a task.

### 3.0.4.0 (2015-06-19 22:54 UTC)
* AutoScaling (3.0.1.0)
* EC2 (3.0.4.0)
	* Regen EC2 for latest API changes. The update contains the new VPC Flow Logs feature.
* ECS (3.0.1.0)
	* Regen ECS with latest service API updates.
