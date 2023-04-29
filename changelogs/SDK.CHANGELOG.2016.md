### 3.3.36.0 (2016-12-29 23:59 UTC)
* CodeDeploy (3.3.2.0)
	* Add support for IAM Session ARNs in addition to IAM User ARNs for on-premise host authentication.
* ECS (3.3.2.0)
	* Add the ability to customize the placement of tasks on container instances.

### 3.3.35.2 (2016-12-28 21:01 UTC)
* DynamoDBv2 (3.3.1.4)
	* Updated to use new Core, version 3.3.7.1
	* Pick up Core change to SDK cache
* Core 3.3.7.1
	* Fixed thread-unsafe access to dictionary

### 3.3.35.1 (2016-12-27 23:11 UTC)
* AppStream (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* AWSMarketplaceCommerceAnalytics (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Batch (3.3.0.1)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudFormation (3.3.3.5)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudFront (3.3.2.2)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudWatchLogs (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* CodeBuild (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* CodePipeline (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* CognitoIdentity (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* ConfigService (3.3.3.3)
	* Documentation update to include cross-reference links to service REST api docs.
* DatabaseMigrationService (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* DirectoryService (3.3.1.5)
	* Documentation update to include cross-reference links to service REST api docs.
* EC2 (3.3.4.4)
	* Documentation update to include cross-reference links to service REST api docs.
* ECR (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* ElasticBeanstalk (3.3.3.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Health (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* IdentityManagement (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Inspector (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* KeyManagementService (3.3.1.8)
	* Documentation update to include cross-reference links to service REST api docs.
* KinesisFirehose (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Lambda (3.3.2.4)
	* Documentation update to include cross-reference links to service REST api docs.
* Lightsail (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* Polly (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* RDS (3.3.4.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Route53 (3.3.3.1)
	* Documentation update to include cross-reference links to service REST api docs.
* SecurityToken (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* Shield (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* SimpleSystemsManagement (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Snowball (3.3.1.4)
	* Documentation update to include cross-reference links to service REST api docs.
* SQS (3.3.1.6)
	* Documentation update to include cross-reference links to service REST api docs.
* StepFunctions (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* StorageGateway (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* WAFRegional (3.3.0.2)
	* Documentation update to include cross-reference links to service REST api docs.

### 3.3.35.0 (2016-12-22 23:22 UTC)
* APIGateway (3.3.4.0)
	* Amazon API Gateway is adding support for generating SDKs in more languages. This update introduces two new operations used to dynamically discover these SDK types and what configuration each type accepts.
* DirectoryService (3.3.1.4)
	* Documentation update.
* ElasticBeanstalk (3.3.3.0)
	* adding a new feature for managing ApplicationVersion Lifecycle. To support this feature we have added one new API and modified two existing API.
* IdentityManagement (3.3.1.0)
	* Adds service-specific credentials to IAM service to make it easier to onboard CodeCommit customers. These are username/password credentials that work with a single service.
* KeyManagementService (3.3.1.7)
	* Documentation update.

### 3.3.34.0 (2016-12-21 23:44 UTC)
* ECR (3.3.2.0)
	* API Update for ECR : Amazon ECR now implements Docker Image Manifest V2, Schema 2 providing the ability to use multiple tags per image, support for storing Windows container images, and compatibility with the Open Container Initiative (OCI) image format. With this update, customers can also add tags to an image via PutImage and delete tags using BatchDeleteImage.
* RDS (3.3.4.0)
	* API Update for RDS : added support for cross region encrypted snapshot copying (CopyDBSnapshot)

### 3.3.33.0 (2016-12-21 06:01 UTC)
* KinesisFirehose (3.3.1.0)
	* API Update for KinesisFirehose:  Processing feature enables users to process and modify records before Amazon Firehose delivers them to destinations.
* Route53 (3.3.3.0)
	* API Update for Route53 : enum updates for eu-west-2 and ca-central-1
* StorageGateway (3.3.1.0)
	* API Update for StorageGateway: File gateway is a new mode in the AWS Storage Gateway that support a file interface into S3, alongside the current block-based volume and VTL storage. File gateway combines a service and virtual software appliance, enabling you to store and retrieve objects in Amazon S3 using industry standard file protocols such as NFS. The software appliance, or gateway, is deployed into your on-premises environment as a virtual machine (VM) running on VMware ESXi. The gateway provides access to objects in S3 as files on a Network File System (NFS) mount point.

### 3.3.32.0 (2016-12-20 00:59 UTC)
* ApplicationDiscoveryService (3.3.1.0)
	* API Update for ApplicationDiscoveryService : Adds new APIs to group discovered servers into Applications with get summary and neighbors. Includes additional filters for ListConfigurations and DescribeAgents API.
* CloudFormation (3.3.3.4)
	* Doc update for Cloudformation
* CognitoIdentity (3.3.1.0)
	* Added Groups to Cognito user pools. Developers can perform CRUD operations on groups, add and remove users from groups, list users in groups, etc; Added fine-grained role-based access control for Cognito identity pools. Developers can configure an identity pool to get the IAM role from an authenticated user's token, or they can configure rules that will map a user to a different role.
* Inspector (3.3.0.7)
	* Doc update for Inspector
* SQS (3.3.1.5)
	* Doc update for SQS

### 3.3.31.0 (2016-12-15 23:20 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.1.0)
	* Add new enum to DataSetType: sales_compensation_billed_revenue
* Batch (3.3.0.0)
	* AWS Batch is a batch computing service that lets customers define queues and compute environments and then submit work as batch jobs.
* CloudWatchLogs (3.3.2.0)
	* Add support for associating LogGroups with AWSTagris tags.
* DatabaseMigrationService (3.3.1.0)
	* Adds support for SSL enabled Oracle endpoints and task modification.
* ElasticBeanstalk (3.3.2.3)
	* Doc-only Update for Elastic Beanstalk: CodeBuild.
* Polly (3.3.0.3)
	* Fix to send X-Amz-Security-Token header in the casing currently expected by the service.
* RDS (3.3.3.1)
	* Doc-only Update for RDS: New versions available in CreateDBInstance
* S3 (3.3.5.2)
	* Fixed presigned url helper to switch to non-AWS Signature v4, if region allows, if requested expiry date is greater than the maximum permitted range for the signature algorithm.
* SecurityToken (3.3.0.7)
	* Documentation update.
* SimpleSystemsManagement (3.3.2.0)
	* Added support for the new Patch Baseline and Patch Compliance APIs.
* Core 3.3.7.0
	* Added region endpoint constants for new EU West (London) region.
Added new region endpoints for Amazon Cognito.
Omit x-amzn-trace-id during signing.
	* all services packages updated to require new core

### 3.3.30.1 (2016-12-13 03:39 UTC)
* IotData (3.3.0.6)
	* Updated to use new Core, version 3.3.6.1
	* Fix issue handling $ character in topics.
* Core 3.3.6.1
	* Fix issue with $ being encoded in requests.

### 3.3.30.0 (2016-12-09 00:42 UTC)
* CloudFront (3.3.2.0)
	* API Update for CloudFront : add lambda function associations to cache behaviors
* CodePipeline (3.3.0.6)
	* Doc update for CodePipeline
* RDS (3.3.3.0)
	* API Upate for RDS : add cluster create time to DBCluster APIs
* WAFRegional (3.3.0.0)
	* New Service WAFRegional : With this new feature, customers can use AWS WAF directly on Application Load Balancers in a VPC within available regions to protect their websites and web services from malicious attacks such as SQL injection, Cross Site Scripting, bad bots, etc.
* Core 3.3.6.0
	* New region launch ca-central-1
	* all services packages updated to require new core

### 3.3.29.0 (2016-12-08 01:18 UTC)
* ConfigService (3.3.3.0)
	* API Update for ConfigService : AWS Config supporting Redshift Cluster, ClusterParameterGroup, ClusterSecurityGroup, ClusterSnapshot, ClusterSubnetGroup, and EventSubscription resource types for all customers
* S3 (3.3.5.0)
	* S3 now defaults to Sigv4 on BCL; fixed versionId not being marshalled correctly in tagging operations
* SQS (3.3.1.2)
	* Doc update for SQS

### 3.3.28.1 (2016-12-07 10:12 UTC)
* Core 3.3.5.1
	* Fixed issue getting environment info running under Lambda
	* all services packages updated to require new core

### 3.3.28.0 (2016-12-06 21:33 UTC)
* ConfigService (3.3.2.0)
	* API Update for ConfigService : AWS Config is increasing the number of configrules for all accounts from 25 to 50
* EC2 (3.3.4.0)
	* API Update for EC2 :  addedT2.xlarge, T2.2xlarge, and R4 instance type.
* SecurityToken (3.3.0.4)
	* Doc update for SecurityTokenService.

### 3.3.27.0 (2016-12-01 23:03 UTC)
* APIGateway (3.3.3.0)
	* You can now publish your APIs on Amazon API Gateway as products on the AWS Marketplace. Use the SDK to associate your APIs on API Gateway with Marketplace Product Codes. API Gateway will then send metering data to the Marketplace Metering Service on your behalf. Also, API Gateway now supports documenting your API.
* AppStream (3.3.0.0)
	* AppStream is a fully managed desktop application streaming service that provides users instant access to their apps from a web browser.
* CodeBuild (3.3.0.0)
	* AWS CodeBuild is a fully-managed build service in the cloud. CodeBuild compiles source code, runs tests, and produces packages that are ready to deploy. CodeBuild eliminates the need to provision, manage, and scale your own build servers. CodeBuild scales continuously and processes multiple builds concurrently, so your builds are never waiting in a queue. You can get started quickly with CodeBuild’s prepackaged build environments, or you can use custom build environments to use your own build tools. With CodeBuild, you only pay by the minute.
* DirectConnect (3.3.2.0)
	* IPv6 support
* EC2 (3.3.3.0)
	* IPv6 Support for EC2 and new F1 Instance types.
* ElasticBeanstalk (3.3.2.0)
	* Integrate AWS codebuild into the service by introducing a new API parameter BuildConfiguration
* Health (3.3.0.0)
	* When your business is counting on the performance of your cloud solutions, having relevant and timely insights into events impacting your AWS resources is essential. The AWS Health API serves as the primary source for you to receive personalized information related to your AWS infrastructure, guiding your through scheduled changes, and accelerating the troubleshooting of issues impacting your AWS resources and accounts. At launch, the APIs will be available to Business and Enterprise Support customers.
* Lambda (3.3.2.0)
	* New GetAccountSettings API, dotnetcore 1.0 runtime support, new DeadLetterConfig API, and event source mappings with Kinesis streams
* OpsWorksCM (3.3.0.0)
	* AWS OpsWorks Managed Chef gives customers a single tenant Chef Automate server. The Chef Automate server is fully managed by AWS and supports automatic backup, restore and upgrade operations.
* Pinpoint (3.3.0.0)
	* Amazon Pinpoint makes it easy to run targeted campaigns to improve user engagement. Pinpoint helps you understand your users behavior, define who to target, what messages to send, when to deliver them, and tracks the results of the campaign.
* Shield (3.3.0.0)
	* AWS Shield is a managed Distributed Denial of Service (DDoS) protection for web applications running on AWS.
* SimpleSystemsManagement (3.3.1.0)
	* Amazon EC2 Systems Manager is a flexible and easy to use management service that enables enterprises to securely manage and administer their workloads running on-premises or in the AWS cloud, using a single unified experience. These tasks include collecting system inventory, maintaining consistent state, ad hoc remote execution, automating imaging creation, applying OS patches, and managing configuration parameters.
* StepFunctions (3.3.0.0)
	* AWS StepFunctions allows developers to build cloud applications with breakthrough reliability using state machines.
* XRay (3.3.0.0)
	* AWS X-Ray helps developers analyze and debug distributed applications. With X-Ray, you can understand how your application and its underlying services are performing to identify and troubleshoot the root cause of performance issues and errors.

### 3.3.26.0 (2016-11-30 19:09 UTC)
* Lightsail (3.3.0.0)
	* New service Lightsail : a simplified VM creation and management service.
* Polly (3.3.0.0)
	* New service Polly : Amazon Polly service turns text into lifelike speech, making it easy to develop applications that use high-quality speech to increase engagement and accessibility
* Rekognition (3.3.0.0)
	* New service Rekognition : Rekognition is a deep-learning based service to search, verify and organize images. With Rekognition, you can detect objects, scenes, and faces in images. You can also search and compare faces.
* Snowball (3.3.1.0)
	* API Update for Snowball : this release of AWS Snowball introduces a new job type, new APIs, and the new AWS Snowball Edge device to support local compute and storage use cases.

### 3.3.25.0 (2016-11-29 17:47 UTC)
* S3 (3.3.4.0)
	* API Update for S3 : new operations for object tagging, new API for configuring Storage Insights, and new Filter Rule to LifeCycleConfiguration

### 3.3.24.0 (2016-11-23 02:51 UTC)
* CloudFormation (3.3.3.0)
	* API Update for CloudFormation : new API ListImports
* Glacier (3.3.1.0)
	* API Update for Glacier : allow customers to retrieve their data with different tiers
* Route53 (3.3.2.1)
	* Doc updates for Route53
* S3 (3.3.3.0)
	* API Update for S3 : Enable customers to specify different restore tiers when accessing their data.

### 3.3.23.0 (2016-11-22 03:06 UTC)
* CloudTrail (3.3.1.0)
	* API Update for CloudTrail : supports configuring your trail with event selector
* ECS (3.3.1.0)
	* APIUpdate for ECS : the new API will include a new field named "version" in API responses relating to tasks and container instances.
* S3 (3.3.2.0)
	* API Update for S3 : Get-Partnumber and Request-Payer support

### 3.3.22.0 (2016-11-19 00:10 UTC)
* ApplicationAutoScaling (3.3.1.0)
	* API Update for ApplicationAutoScaling : support for a new target resource (EMR Instance Groups) as a scalable target
* DynamoDBv2 (3.3.1.0)
	* DynamoDB Util's Document.FromJson() should supported unsigned types.
* ElasticMapReduce (3.3.2.0)
	* API Update for ElasticMapReduce : automatic Scaling of EMR clusters based on metrics
* ElasticTranscoder (3.3.1.0)
	* API Update for ElasticTranscoder : support for multiple media input files that can be stitched together.
* GameLift (3.3.2.0)
	* API Update for GameLift : provide the ability to remote access into GameLift managed servers.
* Lambda (3.3.1.0)
	* API Update for Lambda : adds support for Environment variables.

### 3.3.21.0 (2016-11-17 23:34 UTC)
* APIGateway (3.3.2.0)
	* API Update for APIGateway : adding custom encoding feature.
* AWSMarketplaceMetering (3.3.1.0)
	* API Update for AWSMarketplaceMetering : allow third parties to send metering records.
* CloudWatch (3.3.1.0)
	* API Update for Cloudwatch: add support for percentile statistic (pN) to metrics and alarms
* SQS (3.3.1.0)
	* API Update for SQS : new FIFO message queue.

### 3.3.20.0 (2016-11-17 00:29 UTC)
* Route53 (3.3.2.0)
	* Adds support for cross account VPC association.
* ServiceCatalog (3.3.2.0)
	* This release enables Service Catalog users to perform administrator operations via API.

### 3.3.19.0 (2016-11-16 00:25 UTC)
* DirectoryService (3.3.1.0)
	* API Update for DirectoryService :  Adding SchemaExtensions  
* ElastiCache (3.3.2.0)
	* API Update for ElastiCache : Additional parameter to 2 create apis to provide an auth Token for Redis
* Kinesis (3.3.1.0)
	* API Update for Kinesis: Describe shard limit, open shard count and stream creation timestamp

### 3.3.18.0 (2016-11-15 03:37 UTC)
* CognitoIdentityProvider (3.3.2.0)
	* CognitoIdentityProvider: Adds schema attributes to CreateUserPool. 
* Core 3.3.5.0
	* Fixed nuspec files to correctly load binaries on Xamarin platforms; EndpointProvider now handles non-standard regions.
	* all services packages updated to require new core

### 3.3.17.0 (2016-11-11 00:13 UTC)
* CloudFormation (3.3.2.2)
	* Doc update.
* CloudWatchLogs (3.3.1.0)
	* Amazon CloudWatch Metrics to Logs is a capability that helps pivot from your logs-extracted metrics directly to the corresponding logs.
* EC2 (3.3.2.2)
	* Updated to use new Core, version 3.3.4.1
	* generated changes from idempotency trait support
* ServiceCatalog (3.3.1.2)
	* Updated to use new Core, version 3.3.4.1
	* generated changes from idempotency trait support
* Core 3.3.4.1
	* updated generator to handle idempotency trait

### 3.3.16.0 (2016-11-04 01:26 UTC)
* DirectConnect (3.3.1.0)
	* Updated to use new Core, version 3.3.4.0
	*  AWS Direct Connect provides three new APIs to support basic tagging on Direct Connect resources.
* SimpleEmail (3.3.1.0)
	* Updated to use new Core, version 3.3.4.0
	* API Update for SES: Amazon Simple Email Service (Amazon SES) now enables you to track your bounce, complaint, delivery, sent, and rejected email metrics with fine-grained granularity.
* Core 3.3.4.0
	* RetryThrottling feature
	* Added WebProxy support for PCL
	* Added Support for environmental credentials
	* all services packages updated to require new core

### 3.3.15.0 (2016-11-03 04:41 UTC)
* CloudFormation (3.3.2.0)
	*  Adding ResourcesToSkip parameter to ContinueUpdateRollback API, adding support for ListExports, new ChangeSet types and Transforms

### 3.3.14.1 (2016-10-25 23:25 UTC)
* AutoScaling (3.3.0.2)
	* Doc Update for Autoscaling and ELB
* ElasticLoadBalancingV2 (3.3.0.2)
	* Doc Update for  ELB

### 3.3.14.0 (2016-10-25 03:31 UTC)
* ECS (3.3.0.2)
	* Doc only update
* ServerMigrationService (3.3.0.0)
	*  AWS Server Migration Service (SMS) is an agentless service which makes it easier and faster for you to migrate thousands of on-premises workloads to AWS.

### 3.3.13.0 (2016-10-21 04:40 UTC)
* Budgets (3.3.0.0)
	* Updated to use new Core, version 3.3.3.0
	* Release of AWS Budgets
* WAF (3.3.1.2)
	* doc update
* Core 3.3.3.0
	* decimal type support for aws budgets

### 3.3.12.0 (2016-10-20 00:47 UTC)
* EC2 (3.3.2.0)
	* Added support for retrieving the new Windows Server 2016 images in ImageUtilities helper class.

### 3.3.11.0 (2016-10-18 22:51 UTC)
* CloudFront (3.3.1.0)
	* Added ability to use Amazon CloudFront to deliver your content both via IPv6 and IPv4 using HTTP/HTTPS
* ConfigService (3.3.1.0)
	* enum updates to support S3 bucket resource type
* IoT (3.3.1.0)
	* added DynamoActionV2 action to IoT Rules Engine
* KinesisAnalytics (3.3.0.2)
	* Model update to add rawInputRecords member in UnableToDetectSchemaException
* RDS (3.3.2.0)
	* Amazon Aurora integrates with other AWS services to allow you to extend your Aurora DB cluster to utilize other capabilities in the AWS cloud. Permission to access other AWS services is granted by creating an IAM role with the necessary permissions, and then associating the role with your DB cluster.
* S3 (3.3.1.0)
	* Support for simultaneous use of dualstack and accelerate feaftures.
* Core 3.3.2.1
	* Fix bug with persistence manager not correctly overwriting the file on persistence; Fixed incorrect types being used when constructing JsonData

### 3.3.10.0 (2016-10-17 20:12 UTC)
* Route53 (3.3.1.0)
	* Updated to use new Core, version 3.3.2.0
	* New enum to support new regions and doc updates.
* S3 (3.3.0.4)
	* Updated to use new Core, version 3.3.2.0
	* Enum changes to support new region
* Core 3.3.2.0
	* Core changes to support new us-east-2 region; fixed a bug where LitJson raises overflow/underflow exception on valid input.

### 3.3.9.0 (2016-10-13 19:57 UTC)
* CertificateManager (3.3.1.0)
	*  This change allows users to import third-party SSL/TLS certificates into ACM
* ElasticBeanstalk (3.3.1.0)
	* Support Pagination for DescribeApplicationVersions API
* GameLift (3.3.1.0)
	* New APIs to protect game developer resource (builds, alias, fleets, instances, game sessions and player sessions) against abuse.
* S3 (3.3.0.3)
	* Updated to use new Core, version 3.3.1.1
	* Requires latest Core to pick up LruCache bug fix.
* ServiceCatalog (3.3.1.0)
	* Updated to use new Core, version 3.3.1.1
	* New regions
* Core 3.3.1.1
	* Several bug fixes to LruCache including https://github.com/aws/aws-sdk-net/pull/467; Doc updates; and endpoints.json update to support new Service Catalog regions.

### 3.3.8.0 (2016-10-12 17:43 UTC)
* ECR (3.3.1.0)
	* DescribeImages is a new api used to expose image metadata which today includes image size and image creation timestamp
* ElastiCache (3.3.1.0)
	* Elasticache is launching a new major engine release of Redis, 3.2 (providing stability updates and new command sets over 2.8), as well as ElasticSupport for enabling Redis Cluster in 3.2, which provides support for multiple node groups to horizontally scale data, as well as superior engine failover capabilities.

### 3.3.7.0 (2016-10-12 08:32 UTC)
* CognitoSync (3.3.1.0)
	* Update SQLite dependencies for support of Android N
* MobileAnalytics (3.3.1.0)
	* Update SQLite dependencies for support of Android N

### 3.3.6.0 (2016-10-11 19:26 UTC)
* Core 3.3.1.0
	* Close HttpWebRequest's response stream on WebExceptions (https://github.com/aws/aws-sdk-net/pull/449).
	* Updated generation of .nuspec files to enable Nuget packages to support the "uap" targetFramework.
	* Added support for configuring bypass lists and bypass-on-local mode for web proxies in the BCL and Unity platforms.
	* Fixed issue in RegionEndpointProviderV3 preventing use of regions unknown at the time of compilation.
	* Fixed LitJson not serializig signed types correctly.
	* all services packages updated to require new core

### 3.3.5.0 (2016-10-07 03:45 UTC)
* CognitoIdentityProvider (3.3.1.0)
	* Added new operation "AdminCreateUser" that creates a new user in the specified user pool and sends a welcome message via email or phone (SMS).
* DeviceFarm (3.3.0.1)
	* general doc update
* KeyManagementService (3.3.1.0)
	* support for InvalidMarkerException in ListKeys API
* OpsWorks (3.3.0.1)
	* general doc update
* WAF (3.3.1.0)
	*  In WAF model, the enum for IPSetDescriptorType, we add IPV6 in addition to IPV4. This change will add a new option when customers call some APIs, and also the API will no longer assume the IPSetDescriptorType is in IPV4
* Core 3.3.0.3
	* endpoints.json file update

### 3.3.4.0 (2016-09-29 23:30 UTC)
* EC2 (3.3.1.0)
	* Support for new EC2 instance type: m4.16xlarge Support for new EC2 P2 and X1 instances. Adding support for EC2 Convertible RIs and the EC2 RI regional benefit.
* Core 3.3.0.2
	* Add back the ap-south1 region constant

### 3.3.3.0 (2016-09-28 02:53 UTC)
* CloudFormation (3.3.1.0)
	* Added RoleARN parameter to mutating APIs
* CodePipeline (3.3.0.1)
	* Service documentation update.
* ElasticFileSystem (3.3.0.1)
	* Service documentation update.
* KeyManagementService (3.3.0.1)
	* Update documentation to clarify the inputs to KMS Generate APIs
* Core 3.3.0.1
	* Added missing RoleArn property to URIBasedRefreshingCredentialHelper's SecurityCredentials class.

### 3.3.2.0 (2016-09-22 20:34 UTC)
* APIGateway (3.3.1.0)
	* Simple Proxy support includes three new features: new greedy path formats (no API change), new pseudo-HTTP method (ANY), and two new integration types (AWS_PROXY, HTTP_PROXY).
* AWSSDK.Extensions.NETCore.Setup (3.3.0.1)
	* Pull request 456, fix issue with setting RegionEndpoint property overriding a previous set ServiceURL

### 3.3.1.0 (2016-09-21 21:17 UTC)
* CodeDeploy (3.3.1.0)
	* AWS CodeDeploy now integrates with Amazon CloudWatch alarms, making it possible to stop a deployment if there is a change in the state of a specified alarm for a number of consecutive periods, as specified in the alarm threshold. AWS CodeDeploy also now supports automatically rolling back a deployment if certain conditions are met, such as a deployment failure or an activated alarm.
* ElasticMapReduce (3.3.1.0)
	* Added support for Security Configurations which can be used to enable encryption at-rest and in-transit for certain applications on Amazon EMR.
* RDS (3.3.1.0)
	* Provide local time zone support for AWS RDS SqlServer database instances.
* Redshift (3.3.1.0)
	* This release of Amazon Redshift introduces Enhanced VPC Routing. When you use Amazon Redshift Enhanced VPC Routing, Amazon Redshift forces all COPY and UNLOAD traffic between your cluster and your data repositories through your Amazon VPC.
* S3 (3.3.0.1)
	* Fix null reference exception when validation error occurrs in STS.

### 3.3.0.0 (2016-09-19 17:15 UTC)
* [GA release](http://blogs.aws.amazon.com/net/post/Tx3O6TT4NKFM0FU/General-Availability-for-NET-Core-Support-in-the-AWS-SDK-for-NET) of support for .NET Core in the AWS SDK for .NET 

### 3.1.101.0 (2016-09-16 00:49 UTC)
* IoT (3.1.9.0)
	* Changes in RegisterCertificate API & Adding a new field "cannedAcl" in S3 action
* RDS (3.1.19.0)
	* Aurora cluster reader end-point. Customers have requested we provide them an endpoint that gives access to their cluster readers. We are adding a single field to the output of the DescribeDbCluster operation, namely "ReaderEndpoint" to serve this purpose.

### 3.1.100.0 (2016-09-13 22:23 UTC)
* EC2 (3.1.20.2)
	* Minor documentation update.
* S3 (3.1.10.0)
	* Updated the Amazon.S3.Model.S3Object type to contain a new property, BucketName. This is the name of the bucket containing the object.
* ServiceCatalog (3.1.1.0)
	* Adding an optional parameter to 2 existing APIs.

### 3.1.99.0 (2016-09-08 21:56 UTC)
* AWSSupport (3.1.0.10)
	* Documentation update.
* CloudFront (3.1.7.0)
	* Adds HTTP2 support for Amazon CloudFront distributions.This includes a new API version, 2016-09-07.
* SimpleNotificationService (3.1.2.1)
	* Documentation update.

### 3.1.98.0 (2016-09-06 21:59 UTC)
* CodePipeline (3.1.5.0)
	* Incorporated API updates to correct naming of members in types used in the recently published view changes APIs. Please note these are breaking changes in the model shapes.
* EC2 (3.1.20.1)
	* Documentation updates.
* ECR (3.1.2.1)
	* Documentation updates.
* ECS (3.1.8.1)
	* Documentation updates.
* RDS (3.1.18.0)
	* New API for RDS: DescribeSourceRegions. The DescribeSourceRegions API provides a list of all the source region names and endpoints for any region. Source regions are the regions where current region can get a replica or copy a snapshot from.
* SimpleNotificationService (3.1.2.0)
	* Declaring AuthorizationErrorException on the 5 new SNS-SMS APIs.

### 3.1.97.0 (2016-09-02 00:53 UTC)
* ApplicationAutoScaling (3.1.1.0)
	* ApplicationAutoScaling adds support for automatically scaling an Amazon EC2 Spot fleet in order to manage application availability and costs during changes in demand based on conditions you define.
* CognitoIdentityProvider (3.1.2.0)
	* Added support for bulk import of users.
* ConfigService (3.1.7.0)
	* ResourceType Enum Update for AWS Config: Supporting a application loadbalancer resource type in AWS Config 
* GameLift (3.1.3.0)
	* Customers can use Linux in addition to Windows EC2 instances.
* RDS (3.1.17.0)
	* We currently allow customers to add options to a rds option group that are mutually exclusive. We want to avoid that while validating the request to add an option to the option group. As part of this effort we are modifying the describe-option-group-options api response to include information about options that conflict with each other.

### 3.1.96.0 (2016-08-30 21:02 UTC)
* AutoScaling (3.1.4.1)
	* Documentation update.
* CloudFront (3.1.6.0)
	* CloudFront is adding a Querystring Whitelist Option. Customers will be able to choose to forward certain querystring keys instead of a.) all of them or b.) none of them.
* CodePipeline (3.1.4.0)
	* CodePiepline has introduced a new feature to return pipeline execution details. Execution details consists of source revisions that are running in the pipeline. Customers will be able to tell what source revisions that are running through the stages in pipeline by fetching execution details of each stage.
* Route53 (3.1.6.0)
	* With this release, Route 53 will support the following new features: support for the NAPTR DNS record type, a new TestDNSAnswer API which enables customers to send a test query against a specific name server using spoofed delegation nameserver, resolver, and ECS IPs, and support metric-based health check in ap-south-1 region.
* SimpleSystemsManagement (3.1.4.2)
	* Documentation update.
* Core 3.1.11.0
	* Fixed issue with UnityWebRequest for Unity 5.4.
Deprecated ClientConfig.ReadEntireResponse property.



### 3.1.95.0 (2016-08-24 00:11 UTC)
* OpsWorks (3.1.3.5)
	* Documentation updates for expanded region support.
* RDS (3.1.16.0)
	* Addition of resource ARNs to Describe APIs.

### 3.1.94.0 (2016-08-19 02:24 UTC)
* EC2 (3.1.20.0)
	* Schema Update for Dedicated Host Reservations and API Update for EC2-SpotFleet: Adding new parameters to DescribeSpotFleerRequest API
* IdentityManagement (3.1.4.9)
	* Doc only update
* KeyManagementService (3.1.3.1)
	* Updating the version numbers
* WorkSpaces (3.1.3.0)
	* New APIs to support the launch and management of WorkSpaces that are paid for and used by the hour.

### 3.1.93.0 (2016-08-17 01:52 UTC)
* APIGateway (3.1.7.0)
	* Amazon API Gateway now supports API usage plans. You can now easily define plans for 3rd party developers by associating them with individual API keys. This allows you to configure which APIs the caller can access as well as define throttling and request quota limits. You can also extract utilization data on a per-API key basis to analyze API usage and generate billing documents. Usage plans allows you to easily manage and monetize your APIs for your API-based business.
* CognitoSync (3.1.2.0)
	* Merged GitHub PR 409: Improve DataConflictException handling in case of partial local modification (https://github.com/aws/aws-sdk-net/pull/409)
* ECS (3.1.8.0)
	* Regenerating from latest service model ecs-2014-11-13.normal.json

### 3.1.92.0 (2016-08-11 07:53 UTC)
* AutoScaling (3.1.4.0)
	* New API for AutoScaling - ELB L7 integration.
* ECS (3.1.7.0)
	* Amazon EC2 Container services support Application Load Balancer target groups to enable dynamic ports and path-based routing.
* ElasticLoadBalancing (3.1.1.0)
	* Documentation and other minor changes to the classic Elastic Load Balancing model to support the launch of Elastic Load Balancing V2 API which can be found in the Amazon.ElasticLoadBalancingV2 namespace.
* ElasticLoadBalancingV2 (3.1.0.0)
	* Application load balancers are a new load balancer that is now supported by the Elastic Load Balancing service. Application load balancers support HTTP/2, WebSockets, routing based on URL path, and routing to multiple ports on a single instance.
* KeyManagementService (3.1.3.0)
	* New import key feature lets you import keys from your own key management infrastructure to KMS for greater control over generation and storage of keys and meeting compliance requirements of sensitive workloads.
* KinesisAnalytics (3.1.0.0)
	* Added support for Amazon Kinesis Analytics, a fully managed service for continuously querying streaming data using standard SQL. With Kinesis Analytics, you can write standard SQL queries on streaming data and gain actionable insights in real-time, without having to learn any new programming skills. The service allows you to build applications that continuously read data from streaming data sources, process that data using standard SQL, and send the processed data to up to four destinations of your choice. Kinesis Analytics enables you to generate time-series analytics, feed a real-time dashboard, create real-time alarms and notifications, and much more.
* S3 (3.1.9.0)
	* Updated to use new Core, version 3.1.10.0
	* Added support for requesting dualstack (ipv6) endpoints using a new UseDualstackEndpoint property on the service configuration class. Note that not all regions currently support dualstack endpoints - you should consult S3 documentation to verify a dualstack endpoint is available for the region you intend to use before setting this switch.
* Snowball (3.1.0.0)
	* Added support for the Snowball job management API.
* Core 3.1.10.0
	* Added a new flag, UseDualstackEndpoint, to the base configuration class for all services. Currently this flag is for use with Amazon S3 only. Other services will add dualstack (ipv6) endpoints in the future.

### 3.1.91.0 (2016-08-10 00:12 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.3.0)
	* In this release, we added a new API, StartSupportDataExport, to the AWS Marketplace Commerce Analytics Service. StartSupportDataExport returns static test data only at this time. The AWS Marketplace Commerce Analytics Service allows AWS Marketplace Sellers to programmatically access product and customer data on AWS Marketplace. For more information, contact aws-marketplace-seller-ops@amazon.com.
* CloudFront (3.1.5.0)
	* Amazon CloudFront now supports tagging for Web and Streaming distributions. Tags make it easier for you to allocate costs and optimize spending by categorizing and grouping AWS resources.
* ECR (3.1.2.0)
	* Adds filtering of ListImages requests based on whether an image is tagged or untagged
* S3 (3.1.8.3)
	* Minor update to PutBucket operation

### 3.1.90.1 (2016-08-09 00:44 UTC)
* Core 3.1.9.2
	* Fix issue with LitJSON not properly deserializing dictionaries
	* all services packages updated to require new core

### 3.1.90.0 (2016-08-04 23:43 UTC)
* CognitoIdentityProvider (3.1.1.0)
	* Adding Auth Support for Cognito User Pools 
* GameLift (3.1.2.0)
	* Added support for GameSession Search API
* Lambda (3.1.4.6)
	* Doc only update
* RDS (3.1.15.0)
	* S3 Snapshot Ingestion and MoveToVpc feature added

### 3.1.89.0 (2016-08-02 21:00 UTC)
* ApplicationAutoScaling (3.1.0.5)
	* Documentation update reflecting scalable target limit increase.
* AWSMarketplaceMetering (3.1.0.5)
	* Add path shortening for new discovery service
* CloudWatch (3.1.0.10)
	* Documentation update for MetricDatum.
* CloudWatchLogs (3.1.3.0)
	* Documentation update. Adding an optional parameter, DefaultValue, to PutMetricFilterRequest.
* DirectoryService (3.1.5.1)
	* Documentation update.
* ElasticMapReduce (3.1.6.0)
	* API Update for EMR: Enhanced Debugging
* IoT (3.1.8.0)
	* Regenerating from latest service model iot-2015-05-28.normal.json
* MachineLearning (3.1.3.0)
	* Added the timestamps StartedAt, FinishedAt, and ComputeTime to the following API responses:DescribeBatchPredictionsOutput DescribeDataSourcesOutput DescribeEvaluationsOutput DescribeMLModelsOutput GetBatchPredictionsOutput GetDataSourcesOutput GetEvaluationsOutput GetMLModelsOutput. Added TotalRecordCount and InvalidRecordCount to the following API responses: DescribeBatchPredictionsOutput GetBatchPredictionsOutput.
* RDS (3.1.14.0)
	* Support for License model and versioning of option groups.
* Route53Domains (3.1.2.0)
	*  Adds new APIs to renew domains for a specified duration, get domain suggestions, and view billing.

### 3.1.88.0 (2016-07-29 02:27 UTC)
* APIGateway (3.1.6.0)
	* Added support for Cognito User Pools Auth 
* DirectoryService (3.1.5.0)
	* New APIs for Microsoft AD to manage routing 
* EC2 (3.1.19.0)
	* Updated for DNS for VPC Peering 
* Elasticsearch (3.1.1.0)
	* Amazon Elasticsearch Service now supports elasticsearch version 2.3. Version 2.3 offers improved performance, memory management, and security. It also offers several new features including: pipeline aggregations to perform advanced analytics like moving averages and derivatives, and enhancements to geospatial queries
* SecurityToken (3.1.4.4)
	* Doc only update
* SimpleEmail (3.1.4.3)
	* Doc update

### 3.1.87.0 (2016-07-26 23:19 UTC)
* CognitoSync (3.1.1.6)
	* Github pull request 400 fixing an issue when deleting a merged dataset after the deletion is complete.
* IoT (3.1.7.0)
	* This update adds support for thing types. Thing types are entities that store a description of common features of Things that are of the same logical type.
* MobileAnalytics (3.1.1.11)
	*     Github pull request 417 making the event parsing more robust.

### 3.1.86.0 (2016-07-21 23:04 UTC)
* CertificateManager (3.1.4.0)
	* Add reason for failure when describing certificates.
* CloudFormation (3.1.6.0)
	* Added support for specifying IAM capabilities for stacks.
* ConfigService (3.1.6.0)
	* Adding support for ACM and RDS resource types.
Two new features (Hybrid Rules & Forced Evaluation).
* ECS (3.1.6.1)
	* Documentation update.
* ElasticTranscoder (3.1.0.10)
	* Updated documentation for WAV file output format support.
* Lambda (3.1.4.5)
	* Minor documentation update.
* Core 3.1.9.1
	* Fixed issue where hyphens were automatically stripped from access policies during unmarshall.

### 3.1.85.0 (2016-07-19 21:11 UTC)
* DeviceFarm (3.1.7.0)
	* Add support for managing remote access sessions.
* SimpleSystemsManagement (3.1.4.0)
	* Added notification support,allowing customers to be notified when a command reaches a terminated status.

### 3.1.84.0 (2016-07-13 22:00 UTC)
* DatabaseMigrationService (3.1.2.0)
	* API updates to enable SSL-enabled endpoints.
* ECS (3.1.6.0)
	* Added support for specifying an IAM role ARN for tasks.
* RDS (3.1.13.0)
	* API Update for RDS Aurora: new parameter TargetDBInstanceIdentifier of FailoverDBCluster API. 
API Update for RDS Aurora: New method CopyDBClusterParameterGroup.
* Core 3.1.9.0
	* Updated to support ECS container credentials.
	* all services packages updated to require new core

### 3.1.83.0 (2016-07-07 23:26 UTC)
* ConfigService (3.1.5.0)
	* API Update for AWS Config: DeleteConfigurationRecorder API.
* DirectoryService (3.1.4.0)
	* API Update for AWS Directory Service: Tagging APIs (Add, Remove and List).
* OpsWorks (3.1.3.2)
	* Documentation update.
* ServiceCatalog (3.1.0.0)
	* Added support for AWS Service Catalog. This service allows organizations to create and manage catalogs of IT services that are approved for use on AWS.

### 3.1.82.0 (2016-07-05 19:32 UTC)
* CodePipeline (3.1.3.0)
	* Updates CodePipeline API to support manual approvals.
* ElasticFileSystem (3.1.2.1)
	* Documentation update.
* IdentityManagement (3.1.4.6)
	* Documentation update.

### 3.1.81.0 (2016-06-30 20:27 UTC)
* DatabaseMigrationService (3.1.1.0)
	* Allow the ability to specify VpcSecurityGroupId for the replication instance
* SimpleSystemsManagement (3.1.3.0)
	* Amazon EC2 Run Command now works with any instance or virtual machine outside of AWS, including your own data centers or other clouds.
* Core 3.1.8.1
	* Pull request 412, overload to optionally strip hyphen from the ID in the Principal object

### 3.1.80.0 (2016-06-28 22:44 UTC)
* CloudWatchEvents (3.1.2.0)
	* Update for new BOM region
* EC2 (3.1.18.0)
	* Enable ENA supported instances
* ElasticFileSystem (3.1.2.0)
	* Added support for PerformanceMode property
* GameLift (3.1.1.0)
	* Support for Multi-Process Support
* IoT (3.1.6.0)
	* Added support for Operation property in DynamoDBAction
* Route53 (3.1.5.0)
	* Update for new BOM region
* SimpleNotificationService (3.1.1.0)
	* Updated support for SMS

### 3.1.79.0 (2016-06-28 01:36 UTC)
* S3 (3.1.8.0)
	* Updated to use new Core, version 3.1.8.0
	* Added support for BOM region.
* Core 3.1.8.0
	* Added support for BOM region.
	* all services packages updated to require new core

### 3.1.78.0 (2016-06-23 21:11 UTC)
* CognitoIdentity (3.1.1.0)
	* API update for role customization
* DirectConnect (3.1.2.0)
	* API update for DescribeConnectionLoa and DescribeInterconnectLoa operations
* EC2 (3.1.17.0)
	* API update for IdentityId Format
* IdentityManagement (3.1.4.4)
	* Doc update
* RDS (3.1.12.1)
	* Doc update

### 3.1.77.0 (2016-06-21 23:39 UTC)
* CodePipeline (3.1.2.0)
	* The feature Retry Failed Actions allows you to retry a failed pipeline execution from a given stage in the pipeline. Mainly, this can be done by the new API RetryStageExecution with the use of a field from the existing (updated) API GetPielineState's response.
* OpsWorks (3.1.3.0)
	* Minor documentation update.

### 3.1.76.0 (2016-06-14 22:42 UTC)
* CertificateManager (3.1.3.3)
	* Regenerating from latest service model acm-2015-12-08.normal.json
* CloudTrail (3.1.5.0)
	* Regenerating from latest service model cloudtrail-2013-11-01.normal.json
* RDS (3.1.12.0)
	* Regenerating from latest service model rds-2014-10-31.normal.json
* S3 (3.1.7.2)
	* Minor documentation update.
* SimpleEmail (3.1.4.0)
	* Regenerating from latest service model email-2010-12-01.normal.json

### 3.1.75.1 (2016-06-13 22:41 UTC)
* S3 (3.1.7.1)
	* Pull request 379, prevent v4 auth from being forced on GET when using non s3 endpoint.
* SQS (3.1.0.10)
	* Pull request 380, updating SQSConstants

### 3.1.75.0 (2016-06-07 20:08 UTC)
* DynamoDBv2 (3.1.5.0)
	* API Update for DynamoDB Streams to support ApproximationCreationDateTime
* IoT (3.1.5.0)
	* Adds new API, ListPolicyPrincipals. ListPolicyPrincipals allows you to list all your principals (certificate or other credential, such as Amazon Cognito ID) attached to a given policy. Also adds an encode function to the SQL syntax function list, and a couple of improvements to Amazon DynamoDB Actions: Range key (primary partition key) is now optional as it is in DynamoDB. "NUMBER" is being introduced as a supported hash key and range key type.
* MachineLearning (3.1.2.0)
	* You can now assign tags, which are commonly used for cost allocation, to Amazon Machine Learning datasources, models, evaluations, and batch predictions.

### 3.1.74.0 (2016-06-03 21:43 UTC)
* ApplicationAutoScaling (3.1.0.2)
	* Updated incorrect documentation links.
* EC2 (3.1.16.0)
	* The new 'type' parameter in the RequestSpotFleet API indicates whether a Spot fleet will only 'request' the target capacity or also attempt to 'maintain' it. When you want to 'maintain' a certain target capacity, Spot fleet will place the required bids to meet this target capacity, and enable you to automatically replenish any interrupted instances. When you simply 'request' a certain target capacity, Spot fleet will only place the required bids but will not attempt to replenish Spot instances if capacity is diminished, nor will it submit bids in alternative Spot pools if capacity is not available. By default, this parameter is set to 'maintain'. - The DescribeSpotFleetRequests API now returns two new parameters: the 'fulfilledCapacity' of a Spot fleet to indicate the capacity that has been successfully launched, and the 'type' parameter to indicate whether the fleet is meant to 'request' or 'maintain' capacity.
* IdentityManagement (3.1.4.3)
	* Updated to use new Core, version 3.1.7.0
	* Fix potential performance issue in service config constructor related to attempting to access EC2 instance metadata when not running on EC2.
* S3 (3.1.7.0)
	* Updated to use new Core, version 3.1.7.0
	* Fix issue with ListObjectsV2, where StartAfter is associated with the wrong header.
* SecurityToken (3.1.4.1)
	* Updated to use new Core, version 3.1.7.0
	* Fix potential performance issue in service config constructor related to attempting to access EC2 instance metadata when not running on EC2.
* Core 3.1.7.0
	* Dispose of the CancellationTokenRegistration instance we get back from CancellationToken.Register, fix for https://github.com/aws/aws-sdk-net/issues/361
	* all services packages updated to require new core

### 3.1.73.0 (2016-05-26 21:25 UTC)
* CloudTrail (3.1.4.0)
	* Regenerated from correct service model. Previous releases contained an exception type, KmsKeyInvalidStateException, which is not currently used and should not have been present (this removal may be a breaking change for some users).
* ElastiCache (3.1.3.0)
	* This release of Amazon ElastiCache adds support for exporting a Redis snapshot to an Amazon S3 bucket. After the export is completed, you can access the exported snapshot from your Amazon S3 console or API.
* SecurityToken (3.1.4.0)
	* Refactoring changes corresponding to enhancements to enable the use of SAML role credential profiles in the SDK core assembly.
* Core 3.1.6.0
	* Updated credential profile support to enable use of SAML role profiles with SDK-based applications.
Added support for auto-detect of region from instance metadata when running on EC2 instances.
Added support for reading AWS credentials from environment variables shared with other AWS SDKs.
Added support for generating serializable exceptions.
	* all services packages updated to require new core

### 3.1.72.0 (2016-05-24 17:32 UTC)
* EC2 (3.1.15.0)
	* Added support for instance console screenshot
* RDS (3.1.11.0)
	* Cross account snapshot sharing

### 3.1.71.1 (2016-05-24 00:13 UTC)
* CognitoSync (3.1.1.1)
	* Fix KeyNotFoundException exception

### 3.1.71.0 (2016-05-19 21:39 UTC)
* Application Discovery Service (3.1.1.0)
	* API updates from revised service model. An incorrect model was used in the previous release.
* EC2 (3.1.14.0)
	* Added instance type enumeration members for new X1 types.
* ECS (3.1.5.0)
	* Add status to ListTaskDefinitionFamilies. Filter option lets customers view active, inactive, or all task definition families.
* KinesisFirehose (3.1.2.0)
	* Added support for Configurable Retry Window for Loading Data into Amazon Redshift.

### 3.1.70.0 (2016-05-18 19:21 UTC)
* Application Auto Scaling (3.1.0.0)
	* Added support for Application Auto Scaling. This service is a general purpose Auto Scaling service for supported elastic AWS resources. With Application Auto Scaling, you can automatically scale your AWS resources, with an experience similar to that of Auto Scaling.

### 3.1.69.0 (2016-05-18 06:08 UTC)
* DynamoDBv2 (3.1.4.0)
	* Documentation update.
* WorkSpaces (3.1.2.0)
	* Add tagging support.

### 3.1.68.0 (2016-05-12 22:06 UTC)
* Application Discovery Service (3.1.0.0)
	* Added support for the AWS Application Discovery Service. This service helps Systems Integrators quickly and reliably plan application migration projects by automatically identifying applications running in your data center, their associated dependencies, and their performance profile.
* CloudFormation (3.1.5.0)
	* Added ExecutionStatus to ChangeSets so that customers can see which ChangeSets are available to be executed; which one was executed in the past, and which can no longer be executed due to being obsolete.
* EC2 (3.1.13.0)
	* Added support for identifying stale security groups.
* SimpleSystemsManagement (3.1.2.0)
	* EC2 Run Command has been updated to allow customers to create and share documents. Documents can be shared privately with other AWS accounts, or publically to all accounts.

### 3.1.67.0 (2016-05-10 21:03 UTC)
* DirectConnect (3.1.1.1)
	* Documentation update.
* ElasticMapReduce (3.1.5.0)
	* ListInstances can now filter results based on InstanceState(s).
* IdentityManagement (3.1.4.1)
	* Documentation update.
* S3 (3.1.6.1)
	* Added retry for HTTP 502 and 504. Updated list of requests that should not be directed to S3 accelerate endpoint.
* SQS (3.1.0.7)
	* Documentation update.
* StorageGateway (3.1.4.0)
	* Updates to the ListGateways and ListVolumes APIs. Added support for the ListTapes API.

### 3.1.66.0 (2016-05-05 19:42 UTC)
* APIGateway (3.1.5.0)
	* Added support to Integration for controlling passthrough behavior.
* CloudTrail (3.1.3.0)
	* Updates to return topic ARN in addition to the topic name.
* ECS (3.1.4.0)
	* Added support for specifying log drivers available from Docker in task definitions.
* KeyManagementService (3.1.2.0)
	* Updated for the latest service API updates.
* S3 (3.1.6.0)
	* Added support for ListObjectsV2 operation.
* SecurityToken (3.1.3.3)
	* Documenation update for the AssumeRole API.

### 3.1.65.0 (2016-05-03 21:40 UTC)
* CodePipeline (3.1.1.5)
	* Documentation and samples update.
* CognitoIdentityProvider (3.1.0.0)
	* Added support for the Amazon Cognito Identity Provider service.
* ElasticBeanstalk (3.1.5.0)
	* Added support for TooManyBucketsException to several operations.
* Inspector (3.1.2.1)
	* Documentation update.

### 3.1.64.0 (2016-04-28 17:03 UTC)
* OpsWorks (3.1.2.0)
	* Adds support for default tenancy selection.
* Route53Domains (3.1.1.0)
	* Add support for new operations ResendContactReachabilityEmail and GetContactReachabilityStatus.

### 3.1.63.0 (2016-04-26 21:22 UTC)
* EC2 (3.1.12.0)
	* API Update for VPC Peering with Classiclink.
* ECR (3.1.1.0)
	* Added the repository URI to the output of DescribeRepositories.
* SecurityToken (3.1.3.2)
	* Service documentation update.

### 3.1.62.0 (2016-04-21 18:09 UTC)
* CertificateManager (3.1.3.0)
	* Add tagging support
* CloudHSM (3.1.2.0)
	* Documentation update
* ElasticMapReduce (3.1.4.0)
	* Add support for Smart Targeted Resize feature
* Inspector (3.1.2.0)
	* Documentation update
* IoT (3.1.4.0)
	* Added support for specifying the SQL rules engine to be used
* KeyManagementService (3.1.1.3)
	* Use correct error codes.

### 3.1.61.0 (2016-04-19 06:13 UTC)
* EC2 (3.1.11.0)
	* Add two new low-cost, high-throughput HDD volume types: Throughput Optimized HDD (st1) and Cold HDD (sc1).
* ElasticBeanstalk (3.1.4.0)
	* Add support for automatic platform version upgrades with managed updates.
* Kinesis (3.1.3.0)
	* Added support for enhanced monitoring.
* KinesisFirehose (3.1.1.0)
	* Add support for Elastic Search and Cloudwatch Logs.
* S3 (3.1.5.0)
	* Updated to use new Core, version 3.1.5.3
	* Add support for S3 Accelerate.
* Core 3.1.5.3
	* Updates to Core to support S3 Accelerate

### 3.1.60.2 (2016-04-18 18:20 UTC)
* SecurityToken (3.1.3.1)
	* Updated to use new Core, version 3.1.5.2
	* Patch for properly reaching USGovCloudWest1.
* Core 3.1.5.2
	* Fix issue with using STS with USGovCloudWest1 RegionEndpoint.

### 3.1.60.1 (2016-04-12 20:29 UTC)
* ElasticTranscoder (3.1.0.5)
	* Update CreatePipeline to support null notifications - https://github.com/aws/aws-sdk-net/issues/322

### 3.1.60.0 (2016-04-12 00:31 UTC)
* IoT (3.1.3.0)
	* Add support to “Bring your own Certificate”.

### 3.1.59.0 (2016-04-07 22:40 UTC)
* DirectoryService (3.1.3.0)
	* Add support for conditional forwarder
* ElasticBeanstalk (3.1.3.0)
	* Updates to health check
* Lambda (3.1.4.0)
	* Add ability to set runtime in the UpdateFunctionConfiguration operation

### 3.1.58.0 (2016-04-06 03:57 UTC)
* APIGateway (3.1.4.0)
	* Add support for ImportRestApi and PutRestApi.
* Inspector (3.1.1.0)
	* Large service update.
* Route53 (3.1.4.0)
	* Add support for CloudWatch metric-based health checks.
* SecurityToken (3.1.3.0)
	* Add support for GetCallerIdentity, a new API which returns details about the credentials used to make the API call.

### 3.1.57.0 (2016-03-29 22:38 UTC)
* AWS Database Migration Service (3.1.0.1)
	* Documentation update.
* CertificateManager (3.1.2.1)
	* Documentation update.
* CloudFormation (3.1.4.0)
	* Added support for ChangeSets. ChangeSets give users detailed information into what CloudFormation intends to perform when changes are executed to a stack, giving users the ability to preview and change the results before actually applying them. 
* CodeDeploy (3.1.2.1)
	* Documentation update.
* ElastiCache (3.1.2.0)
	* Regenerated from correct service model
* Redshift (3.1.2.0)
	* Added support for Cluster IAM Roles. Clusters can now assume an IAM Role to perform operations like COPY/UNLOAD as well as cryptographic operations involving KMS keys. 
* WAF (3.1.2.0)
	* Added support for XSS (Cross-site scripting) protection in WAF. 

### 3.1.56.0 (2016-03-24 21:00 UTC)
* ElastiCache (3.1.1.0)
	* Added support for changes to allow vertically scaling from one instance type to another.
* RDS (3.1.10.0)
	* Added support for Windows Authentication for RDS SQL Server.
* StorageGateway (3.1.3.0)
	* Added support for the new SetLocalConsolePassword API.

### 3.1.55.0 (2016-03-22 20:12 UTC)
* DeviceFarm (3.1.6.0)
	* Added support for purchasing and managing unmetered devices in a self service manner, and to stop runs which are currently executing. 
* ElasticBeanstalk (3.1.2.3)
	* Updated documentation.
* RDS (3.1.9.0)
	* Added support for customer specifiable fail-over order for read replicas in Amazon Aurora.

### 3.1.54.0 (2016-03-17 23:34 UTC)
* AWSMarketplaceMetering (3.1.0.0)
	* Add support for AWS Marketplace Metering Service.
* CloudHSM (3.1.1.0)
	* Add tagging support.
* IoT (3.1.2.0)
	* Add support for sending IoT data to Amazon Elasticsearch Service.
* S3 (3.1.4.0)
	* Add lifecycle configuration options.

### 3.1.53.0 (2016-03-15 22:23 UTC)
* AWS Database Migration Service (3.1.0.0)
	* Add support for the new AWS Database Migration Service.
* CodeDeploy (3.1.2.0)
	* Add support for the new BatchGetDeploymentGroups API.
* SimpleEmail (3.1.3.0)
	* Add support for custom MAIL FROM domains. For more information see the service release notes at http://aws.amazon.com/releasenotes/Amazon-SES/8381987420423821.

### 3.1.52.0 (2016-03-11 00:40 UTC)
* IdentityManagement (3.1.4.0)
	* Add stable, unique identifying string identifiers to each entity returned from IAM:ListEntitiesForPolicy.
* Redshift (3.1.1.0)
	* Updated with the ability to restore a table from a cluster snapshot to a new table in an active cluster. For more information, see <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html#working-with-snapshot-restore-table-from-snapshot">Restoring a Table from a Snapshot</a>.
* Core 3.1.5.1
	* Fix thread safety issue related to KeyedHashAlgorithm creation on Unity iOS with il2cpp.

### 3.1.51.0 (2016-03-08 22:37 UTC)
* CertificateManager (3.1.2.0)
	* Doc update
* CloudWatchEvents (3.1.1.0)
	* Doc update
* CodeCommit (3.1.1.0)
	* Add support for customizing your development workflow with repository triggers.
* ConfigService (3.1.4.0)
	* Doc update
* DeviceFarm (3.1.5.0)
	* Add support for XCUI - an updated version of Apple's iOS automation suite.
* DirectConnect (3.1.1.0)
	* Doc update

### 3.1.50.0 (2016-03-03 23:11 UTC)
* DirectoryService (3.1.2.0)
	* Added support for SNS notifications on directories.
* DynamoDBv2 (3.1.3.0)
	* Documentation update for the new DescribeLimits API.
* EC2 (3.1.10.0)
	* Added support for referencing security groups in peered Virtual Private Clouds (VPCs). For more information see the service announcement at https://aws.amazon.com/about-aws/whats-new/2016/03/announcing-support-for-security-group-references-in-a-peered-vpc/.

### 3.1.49.0 (2016-03-01 22:20 UTC)
* APIGateway (3.1.3.0)
	* Added new suppression
* CloudSearchDomain (3.1.1.0)
	* Regenerating from latest service model cloudsearchdomain-2013-01-01.normal.json
* DynamoDBv2 (3.1.2.0)
	* Added support for the new DescribeLimits API, enabling users to query provisioning limits for their account.

### 3.1.48.0 (2016-02-25 21:46 UTC)
* AutoScaling (3.1.3.0)
	* Updates to the CompleteLifecycleAction and RecordLifecycleActionHeartbeat operations
* CloudFormation (3.1.3.0)
	* Updated to allow resources not to be deleted and tag support of UpdateStack
* CloudWatchLogs (3.1.2.4)
	* Doc update
* SimpleEmail (3.1.2.0)
	* Added "Encoding" property to the SNSAction

### 3.1.47.1 (2016-02-24 21:12 UTC)
* S3 (3.1.3.13)
	* Add missing enumerations to S3Region.

### 3.1.47.0 (2016-02-23 19:54 UTC)
* Route53 (3.1.3.0)
	* Added support for SNI health check.

### 3.1.46.0 (2016-02-19 23:28 UTC)
* CognitoIdentity (3.1.0.7)
	* Added Support for Unity
* CognitoSync (3.1.1.0)
	* Added Support for Unity, Moved SyncManager and CognitoSync service client into a single assembly
* DynamoDBv2 (3.1.1.5)
	* Added support for Unity, Add ability to use streams with the S3Link object 
* IdentityManagement (3.1.3.3)
	* Add Support for Unity
* Kinesis (3.1.2.3)
	* Added Support for Unity
* KinesisFirehose (3.1.0.3)
	* Added Support for Unity
* Lambda (3.1.3.1)
	* Added Support for Unity
* MobileAnalytics (3.1.1.6)
	* Added Support for Unity
* S3 (3.1.3.12)
	* Added Support for Unity
* SecurityToken (3.1.2.2)
	* Added Support for Unity
* SimpleEmail (3.1.1.4)
	* Added Support for Unity
* SimpleNotificationService (3.1.0.5)
	* Added Support for Unity
* SQS (3.1.0.6)
	* Added Support for Unity
* Core 3.1.5.0
	* Added Support for Unity

### 3.1.45.0 (2016-02-18 22:18 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.2.0)
	* Added support for a new data set disbursed_amount_by_product_with_uncollected_funds .
* CloudWatch (3.1.0.5)
	* Documentation update.
* CodeDeploy (3.1.1.0)
	* Added support for setting up triggers for a deployment group.
* StorageGateway (3.1.2.0)
	* Added support for CreateTapeWithBarcode  API.

### 3.1.44.1 (2016-02-18 00:52 UTC)
* Core 3.1.4.5
	* Fix issue with ConstantClass thread-safety

### 3.1.44.0 (2016-02-17 00:03 UTC)
* ElasticMapReduce (3.1.3.0)
	* Added support for adding EBS storage to an EMR instance.
* RDS (3.1.8.0)
	* Added support for Cross-account Encrypted (KMS) snapshot sharing and removed unused model classes.

### 3.1.43.0 (2016-02-11 22:26 UTC)
* APIGateway (3.1.2.0)
	* Added support for custom request authorizers. With custom request authorizers, developers can authorize their APIs using bearer token authorization strategies, such as OAuth using an AWS Lambda function.
* AWS Certificate Manager (3.1.1.0)
	* Breaking change: the exception type AccessDeniedException has been removed as it is not thrown by the service. The exception type was included in previous releases in error.
* Lambda (3.1.3.0)
	* Added support for configuring a Lambda function to access resources in your VPC. These resources could be AWS service resources (for example, Amazon Redshift data warehouses, Amazon ElastiCache clusters, or Amazon RDS instances), or they could be your own services running on your own EC2 instances. For more information see http://docs.aws.amazon.com/lambda/latest/dg/vpc.html.

### 3.1.42.0 (2016-02-09 21:58 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.1.0)
	* Updated documentation. Extended the GenerateDateSet operation to include a new CustomerDefinedValues parameter. This parameter allows customers to submit arbitrary key/value pair strings which will be returned, as provided, in the asynchronous response, enabling the user of customer-provided identifiers to correlate responses with their internal systems.
* CloudFront (3.1.4.1)
	* Added a new field ACMCertificateARN to ViewerCertificate. This field replaces the CertificateSource and Certificate fields that were recently added.
* ConfigService (3.1.3.2)
	* Documentation update.
* EC2 (3.1.9.1)
	* Updated ImageUtilities class to enable use when a proxy is required.
* Gamelift (3.1.0.0)
	* Added support for Amazon Gamelift, a managed service that allows game developers the ability to deploy and configure their multiplayer games.

### 3.1.41.3 (2016-02-05 17:57 UTC)
* Core 3.1.4.4
	* Updated INI credentials parsing logic to handle '=' character in values.

### 3.1.41.2 (2016-02-03 18:24 UTC)
* S3 (3.1.3.11)
	* Adding ITransferUtility interface for the TransferUtility class.

### 3.1.41.1 (2016-01-29 19:46 UTC)
* Glacier (3.1.0.6)
	* Bug fix for ArchiveTransferManager not creating unique topics and queues

### 3.1.41.0 (2016-01-29 00:12 UTC)
* SimpleSystemsManagement (3.1.1.3)
	* Documentation update for the new 63-bit id formats.
* WAF (3.1.1.0)
	* You can now configure AWS WAF to block, allow, or monitor (count) requests based on the content in HTTP request bodies. This is the part of a request that contains any additional data that you want to send to your web server as the HTTP request body, such as data from an HTML form.

### 3.1.40.0 (2016-01-21 18:45 UTC)
* AWS Certificate Manager (3.1.0.0)
	* AWS Certificate Manager (ACM) is an AWS service that makes it easier for you to deploy secure SSL based websites and applications on the AWS platform. SSL is the standard protocol for encrypting communications and establishing the identity of a website over the Internet. ACM takes care of all of the complexity of obtaining, deploying, and renewing the digital certificates used with SSLCertificate Manager certs with CloudFront distributions.
* DeviceFarm (3.1.4.1)
	* Minor documentation update.
* IoT (3.1.1.0)
	* IoT api update to support enabling and disabling topic rules, and return arns in some structures.
* SecurityToken (3.1.2.1)
	* Minor documentation update.

### 3.1.39.0 (2016-01-19 20:54 UTC)
* DeviceFarm (3.1.4.0)
	* Api update with new enumeration values for uploads.
* OpsWorks (3.1.1.5)
	* Minor documentation update.
* SecurityToken (3.1.2.0)
	* Add support for RegionDisabledException.

### 3.1.38.0 (2016-01-14 21:41 UTC)
* CloudFront (3.1.3.0)
	* Enforce HTTPS-only connection between CloudFront and your origin webserver, support for TLSv1.1 and TLSv1.2 between CloudFront and your origin webserver, add or modify request headers forwarded from CloudFront to your origin webserver.
* CloudWatchEvents (3.1.0.0)
	* Added support for the new CloudWatch Events service. CloudWatch Events allows you to Monitor and rapidly react to changes in your AWS resources.
* EC2 (3.1.9.0)
	* Scheduled instances is a new EC2 service offering which allows customers to purchase reserved capacity for specific slots of time on a one-time or recurring basis.

### 3.1.37.0 (2016-01-12 20:08 UTC)
* EC2 (3.1.8.0)
	* Added support for DNS over classiclink.

### 3.1.36.1 (2016-01-06 20:50 UTC)
* EC2 (3.1.7.1)
	* Fixed incorrect request class and marshaling code for the DescribeNetworkInterfaceAttribute api. The class should have contained a single 'Attribute' member, not multiple members corresponding to the allows values for 'Attribute'.
* S3 (3.1.3.10)
	* Updated to use new Core, version 3.1.4.3
	* Add more defensive code while processing xml error responses
* Core 3.1.4.3
	* Add more defensive code while processing xml error responses. 
Fixed issue with callbacks being invoked multiple times when unhandled exception occurs in .NET 3.5 async code.
Updated RegionEndpoint constants for new Asia Pacific (Seoul) (ap-northeast-2) region.
	* all services packages updated to require new core

