### 3.3.215.0 (2017-12-29 17:27 UTC)
* WorkSpaces (3.3.1.0)
	* Modify WorkSpaces have been updated with flexible storage and switching of hardware bundles feature. The following configurations have been added to ModifyWorkSpacesProperties: storage and compute. This update provides the capability to configure the storage of a WorkSpace. It also adds the capability of switching hardware bundle of a WorkSpace by specifying an eligible compute (Value, Standard, Performance, Power).

### 3.3.214.1 (2017-12-23 05:31 UTC)
* S3 (3.3.16.2)
	* Updated to use new Core, version 3.3.21.6
	* Handle S3 EventType ConstantClass discrepancy between the S3 service sending strings with the s3: prefix and lambda not sending the prefix.
* Core 3.3.21.6
	* Allow service assemblies to override how ConstantClass childs are compared

### 3.3.214.0 (2017-12-22 20:52 UTC)
* EC2 (3.3.42.0)
	* This release fixes an issue with tags not showing in DescribeAddresses responses.
* ECS (3.3.10.0)
	* Amazon ECS users can now set a health check initialization wait period of their ECS services, the services that are associated with an Elastic Load Balancer (ELB) will wait for a period of time before the ELB become healthy. You can now configure this in Create and Update Service.
* Inspector (3.3.3.0)
	* PreviewAgents API now returns additional fields within the AgentPreview data type. The API now shows the agent health and availability status for all instances included in the assessment target. This allows users to check the health status of Inspector Agents before running an assessment. In addition, it shows the instance ID, hostname, and IP address of the targeted instances.
* SageMaker (3.3.1.0)
	* SageMaker Models no longer support SupplementalContainers.  API's that have been affected are CreateModel and DescribeModel.

### 3.3.213.0 (2017-12-21 23:04 UTC)
* CodeBuild (3.3.7.0)
	* Adding support allowing AWS CodeBuild customers to select specific curated image versions.
* EC2 (3.3.41.0)
	* Elastic IP tagging enables you to add key and value metadata to your Elastic IPs so that you can search, filter, and organize them according to your organization's needs.
* KinesisAnalytics (3.3.4.0)
	* Kinesis Analytics now supports AWS Lambda functions as output.

### 3.3.212.0 (2017-12-20 22:31 UTC)
* ConfigService (3.3.12.0)
	* Update ResourceType enum with values for WAF, WAFRegional, and CloudFront resources
* IoT (3.3.8.0)
	* This release adds support for code signed Over-the-air update functionality for Amazon FreeRTOS. Users can now create and schedule Over-the-air updates to their Amazon FreeRTOS devices using these new APIs. 
* Core 3.3.21.5
	* Launch AWS CodeStar in the Asia Pacific (Tokyo) and Canada (Central) regions. 



### 3.3.211.0 (2017-12-19 22:04 UTC)
* APIGateway (3.3.16.0)
	* API Gateway now adds support for calling API with compressed payloads using one of the supported content codings, tagging an API stage for cost allocation, and returning API keys from a custom authorizer for use with a usage plan.
* MediaStoreData (3.3.0.1)
	* Documentation updates for mediastore
* Route53 (3.3.12.0)
	* Route 53 added support for a new China (Ningxia) region, cn-northwest-1. You can now specify cn-northwest-1 as the region for latency-based or geoproximity routing. Route 53 also added support for a new EU (Paris) region, eu-west-3. You can now associate VPCs in eu-west-3 with private hosted zones and create alias records that route traffic to resources in eu-west-3.

### 3.3.210.1 (2017-12-19 05:59 UTC)
* CloudWatch (3.3.5.1)
	* Documentation updates for monitoring
* S3 (3.3.16.1)
	* New region launch eu-west-3
* Core 3.3.21.4
	* New region launch eu-west-3 and pipeline customization change.

### 3.3.210.0 (2017-12-15 20:51 UTC)
* AppStream (3.3.8.0)
	* This API update is to enable customers to add tags to their Amazon AppStream 2.0 resources
* Core 3.3.21.3
	* expand the region support of Inspector to FRA (eu-central-1)



### 3.3.209.0 (2017-12-14 22:13 UTC)
* APIGateway (3.3.15.0)
	* Adds support for Cognito Authorizer scopes at the API method level.
* SimpleEmail (3.3.6.1)
	* Added information about the maximum number of transactions per second for the SendCustomVerificationEmail operation.
* Core 3.3.21.2
	* Updated endpoints.json to include cn-northwest-1

### 3.3.208.0 (2017-12-12 20:10 UTC)
* CodeDeploy (3.3.8.1)
	* Documentation updates for CodeDeploy.
* WorkMail (3.3.0.0)
	* Today, Amazon WorkMail released an administrative SDK and enabled AWS CloudTrail integration. With the administrative SDK, you can natively integrate WorkMail with your existing services. The SDK enables programmatic user, resource, and group management through API calls. This means your existing IT tools and workflows can now automate WorkMail management, and third party applications can streamline WorkMail migrations and account actions. 

### 3.3.207.0 (2017-12-11 22:23 UTC)
* CognitoIdentityProvider (3.3.8.0)
	* Exposing the hosted UI domain name for a user pool that has a domain configured.
* LexModelBuildingService (3.3.4.0)
	* The GetBotChannelAssociation API now returns the status and failure reason, if any, for a bot channel.
* S3 (3.3.16.0)
	* New region cn-northwest-1 support.
* Core 3.3.21.1
	* New region cn-northwest-1

### 3.3.206.0 (2017-12-08 22:48 UTC)
* AppStream (3.3.7.0)
	* This API update is to support the feature that allows customers to automatically consume the latest Amazon AppStream 2.0 agent as and when published by AWS.
* CloudWatch (3.3.5.0)
	* With this launch, you can now create a CloudWatch alarm that alerts you when M out of N datapoints of a metric are breaching your predefined threshold, such as three out of five times in any given five minutes interval or two out of six times in a thirty minutes interval. When M out of N datapoints are not breaching your threshold in an interval, the alarm will be in OK state. Please note that the M datapoints out of N datapoints in an interval can be of any order and does not need to be consecutive. Consequently, you can now get alerted even when the spikes in your metrics are intermittent over an interval.
* ECS (3.3.9.2)
	* Documentation updates for Windows containers.

### 3.3.205.0 (2017-12-07 17:40 UTC)
* Elasticsearch (3.3.4.0)
	* Added support for encryption of data at rest on Amazon Elasticsearch Service using AWS KMS
* SimpleEmail (3.3.6.0)
	* Customers can customize the emails that Amazon SES sends when verifying new identities. This feature is helpful for developers whose applications send email through Amazon SES on behalf of their customers.
* Core 3.3.21.0
	* Add WebExceptionStatus.Timeout to the default retry list.

### 3.3.204.0 (2017-12-06 21:05 UTC)
* CloudDirectory (3.3.6.0)
	* Amazon Cloud Directory makes it easier for you to apply schema changes across your directories with in-place schema upgrades. Your directories now remain available while backward-compatible schema changes are being applied, such as the addition of new fields. You also can view the history of your schema changes in Cloud Directory by using both major and minor version identifiers, which can help you track and audit schema versions across directories.
* ElasticBeanstalk (3.3.6.3)
	* Documentation updates for AWS Elastic Beanstalk.

### 3.3.203.0 (2017-12-05 22:48 UTC)
* IoT (3.3.7.0)
	* Add error action API for RulesEngine. 
* ServiceCatalog (3.3.6.0)
	* ServiceCatalog has two distinct personas for its use, an "admin" persona (who creates sets of products with different versions and prescribes who has access to them) and an "end-user" persona (who can launch cloud resources based on the configuration data their admins have given them access to).  This API update will allow admin users to deactivate/activate product versions, end-user will only be able to access and launch active product versions. 
* ServiceDiscovery (3.3.0.0)
	* Amazon Route 53 Auto Naming lets you configure public or private namespaces that your microservice applications run in. When instances of the service become available, you can call the Auto Naming API to register the instance, and Amazon Route 53 automatically creates up to five DNS records and an optional health check. Clients that submit DNS queries for the service receive an answer that contains up to eight healthy records.

### 3.3.202.0 (2017-12-04 20:28 UTC)
* Budgets (3.3.5.0)
	* Add additional costTypes to support finer control for different charges included in a cost budget.
* ECS (3.3.9.1)
	* Documentation updates for ecs

### 3.3.201.0 (2017-11-30 18:22 UTC)
* AlexaForBusiness (3.3.0.0)
	* Alexa for Business is now generally available for production use. Alexa for Business makes it easy for you to use Alexa in your organization. The Alexa for Business SDK gives you APIs to manage Alexa devices, enroll users, and assign skills at scale. For more information about Alexa for Business, go to https://aws.amazon.com/alexaforbusiness 
* APIGateway (3.3.14.0)
	* Added support Private Integration and VPC Link features in API Gateway. This allows to create an API with the API Gateway private integration, thus providing clients access to HTTP/HTTPS resources in an Amazon VPC from outside of the VPC through a VpcLink resource.
* Cloud9 (3.3.0.0)
	* Adds support for creating and managing AWS Cloud9 development environments. AWS Cloud9 is a cloud-based integrated development environment (IDE) that you use to write, run, and debug code.
* EC2 (3.3.40.0)
	* Adds the following updates: 1. Spread Placement ensures that instances are placed on distinct hardware in order to reduce correlated failures. 2. Inter-region VPC Peering allows customers to peer VPCs across different AWS regions without requiring additional gateways, VPN connections or physical hardware 
* Lambda (3.3.10.0)
	* AWS Lambda now supports the ability to set the concurrency limits for individual functions, and increasing memory to 3008 MB.
* ServerlessApplicationRepository (3.3.0.0)
	* First release of the AWS Serverless Application Repository SDK

### 3.3.200.0 (2017-11-30 03:52 UTC)
* AutoScaling (3.3.3.0)
	* You can now use Auto Scaling with EC2 Launch Templates via the CreateAutoScalingGroup and UpdateAutoScalingGroup APIs.
* EC2 (3.3.39.0)
	* Adds the following updates: 1. T2 Unlimited enables high CPU performance for any period of time whenever required 2. You are now able to create and launch EC2 m5 and h1 instances
* Lightsail (3.3.5.0)
	* This release adds support for load balancer and TLS/SSL certificate management. This set of APIs allows customers to create, manage, and scale secure load balanced applications on Lightsail infrastructure. To provide support for customers who manage their DNS on Lightsail, we've added the ability create an Alias A type record which can point to a load balancer DNS name via the CreateDomainEntry API http://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateDomainEntry.html.
* ResourceGroups (3.3.0.0)
	* AWS Resource Groups lets you search and group AWS resources from multiple services based on their tags.
* SimpleSystemsManagement (3.3.15.0)
	* This release updates AWS Systems Manager APIs to enable executing automations at controlled rate, target resources in a resource groups and execute entire automation at once or single step at a time. It is now also possible to use YAML, in addition to JSON, when creating Systems Manager documents.
* WAF (3.3.4.0)
	* This release adds support for rule group and managed rule group. Rule group is a container of rules that customers can create, put rules in it and associate the rule group to a WebACL. All rules in a rule group will function identically as they would if each rule was individually associated to the WebACL. Managed rule group is a pre-configured rule group composed by our security partners and made available via the AWS Marketplace. Customers can subscribe to these managed rule groups, associate the managed rule group to their WebACL and start using them immediately to protect their resources.
* WAFRegional (3.3.3.0)
	* This release adds support for rule group and managed rule group. Rule group is a container of rules that customers can create, put rules in it and associate the rule group to a WebACL. All rules in a rule group will function identically as they would if each rule was individually associated to the WebACL. Managed rule group is a pre-configured rule group composed by our security partners and made available via the AWS Marketplace. Customers can subscribe to these managed rule groups, associate the managed rule group to their WebACL and start using them immediately to protect their resources.

### 3.3.199.0 (2017-11-29 20:33 UTC)
* Comprehend (3.3.0.0)
	* Amazon Comprehend is an AWS service for gaining insight into the content of text and documents . It develops insights by recognizing the entities, key phrases, language, sentiments, and other common elements in a document. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.
* DynamoDBv2 (3.3.5.0)
	* Amazon DynamoDB now supports the following features: Global Table and On-Demand Backup. Global Table is a fully-managed, multi-region, multi-master database. DynamoDB customers can now write anywhere and read anywhere with single-digit millisecond latency by performing database operations closest to where end users reside. Global Table also enables customers to disaster-proof their applications, keeping them running and data accessible even in the face of natural disasters or region disruptions. Customers can set up Global Table with just a few clicks in the AWS Management Console-no application rewrites required. On-Demand Backup capability is to protect data from loss due to application errors, and meet customers' archival needs for compliance and regulatory reasons. Customers can backup and restore their DynamoDB table data anytime, with a single-click in the AWS management console or a single API call. Backup and restore actions execute with zero impact on table performance or availability. For more information, see the Amazon DynamoDB Developer Guide.
* ECS (3.3.9.0)
	* Amazon Elastic Container Service (Amazon ECS) released a new launch type for running containers on a serverless infrastructure. The Fargate launch type allows you to run your containerized applications without the need to provision and manage the backend infrastructure. Just register your task definition and Fargate launches the container for you. 
* Glacier (3.3.2.0)
	* This release includes support for Glacier Select, a new feature that allows you to filter and analyze your Glacier archives and store the results in a user-specified S3 location.
* Greengrass (3.3.2.0)
	* Greengrass OTA feature allows updating Greengrass Core and Greengrass OTA Agent. Local Resource Access feature allows Greengrass Lambdas to access local resources such as peripheral devices and volumes.
* IoT (3.3.6.0)
	* This release adds support for a number of new IoT features, including AWS IoT Device Management (Jobs, Fleet Index and Thing Registration), Thing Groups, Policies on Thing Groups, Registry & Job Events, JSON Logs, Fine-Grained Logging Controls, Custom Authorization and AWS Service Authentication Using X.509 Certificates.
* IoTJobsDataPlane (3.3.0.0)
	* This release adds support for new the service called Iot Jobs. This client is built for the device SDK to use Iot Jobs Device specific APIs.
* KinesisVideo (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* KinesisVideoArchivedMedia (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* KinesisVideoMedia (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* Rekognition (3.3.8.0)
	* This release introduces Amazon Rekognition support for video analysis.
* S3 (3.3.15.0)
	* This release includes support for Glacier Select, a new feature that allows you to filter and analyze  your Glacier storage class objects and store the results in a user-specified S3 location.
* SageMaker (3.3.0.0)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* SageMakerRuntime (3.3.0.0)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* Translate (3.3.0.0)
	* Public preview release of Amazon Translate and the Amazon Translate Developer Guide. For more information, see the Amazon Translate Developer Guide.

### 3.3.198.0 (2017-11-29 06:01 UTC)
* APIGateway (3.3.13.0)
	* Changes related to CanaryReleaseDeployment feature. Enables API developer to create a deployment as canary deployment and test API changes with percentage of customers before promoting changes to all customers.
* AppSync (3.3.0.0)
	* AWS AppSync is an enterprise-level, fully managed GraphQL service with real-time data synchronization and offline programming features.
* Batch (3.3.4.0)
	* Add support for Array Jobs which allow users to easily submit many copies of a job with a single API call.  This change also enhances the job dependency model to support N_TO_N and sequential dependency chains. The ListJobs and DescribeJobs APIs now have the ability to list or describe the status of entire Array Jobs or individual elements within the array.
* CodeDeploy (3.3.8.0)
	* Support for AWS Lambda function deployment - AWS CodeDeploy now supports the deployment of AWS Lambda functions. A Lambda deployment uses a Lambda function alias to shift traffic to a new version. You select a deployment configuration that specifies exactly how traffic shifts to your new version. Success of a deployment can be validated using Lambda functions that are referenced by the deployment. This provides the opportunity to rollback if necessary.
* CognitoIdentityProvider (3.3.7.0)
	* AWS Cognito SDK has been updated to support new Cognito user-pool objects and operations for advanced security
* EC2 (3.3.38.0)
	* Adds the following updates: 1. You are now able to host a service powered by AWS PrivateLink to provide private connectivity to other VPCs. You are now also able to create endpoints to other services powered by PrivateLink including AWS services, Marketplace Seller services or custom services created by yourself or other AWS VPC customers. 2. You are now able to save launch parameters in a single template that can be used with Auto Scaling, Spot Fleet, Spot, and On Demand instances. 3. You are now able to launch Spot instances via the RunInstances API, using a single additional parameter. RunInstances will response synchronously with an instance ID should capacity be available for your Spot request. 4. A simplified Spot pricing model which delivers low, predictable prices that adjust gradually, based on long-term trends in supply and demand. 5. Amazon EC2 Spot can now hibernate Amazon EBS-backed instances in the event of an interruption, so your workloads pick up from where they left off. Spot can fulfill your request by resuming instances from a hibernated state when capacity is available.
* GuardDuty (3.3.0.0)
	* Enable Amazon GuardDuty to continuously monitor and process AWS data sources to identify threats to your AWS accounts and workloads.  You can add customization by uploading additional threat intelligence lists and IP safe lists. You can list security findings, suspend, and disable the service. 
* Lambda (3.3.9.0)
	* Lambda aliases can now shift traffic between two function versions, based on preassigned weights.
* MQ (3.3.0.0)
	* This is the initial SDK release for Amazon MQ. Amazon MQ is a managed message broker service for Apache ActiveMQ that makes it easy to set up and operate message brokers in the cloud. 

### 3.3.197.0 (2017-11-27 09:02 UTC)
* MediaConvert (3.3.0.0)
	* AWS Elemental MediaConvert is a file-based video conversion service that transforms media into formats required for traditional broadcast and for internet streaming to multi-screen devices.
* MediaLive (3.3.0.0)
	* AWS Elemental MediaLive is a video service that lets you easily create live outputs for broadcast and streaming delivery.
* MediaPackage (3.3.0.0)
	* AWS Elemental MediaPackage is a just-in-time video packaging and origination service that lets you format highly secure and reliable live outputs for a variety of devices.
* MediaStore (3.3.0.0)
	* AWS Elemental MediaStore is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore acts as the origin store in your video workflow.
* MediaStoreData (3.3.0.0)
	* AWS Elemental MediaStore is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore acts as the origin store in your video workflow.
* Core 3.3.20.0
	* Added generator changes for Elemental Data Plane.

### 3.3.196.0 (2017-11-22 23:16 UTC)
* CertificateManager (3.3.3.0)
	* AWS Certificate Manager now supports the ability to import domainless certs and additional Key Types as well as an additional validation method for DNS.
* Core 3.3.19.1
	* Amazon Lex is now available in the EU (Ireland) region.
Amazon Lex is now available in the EU (Ireland) region.



### 3.3.195.0 (2017-11-22 02:27 UTC)
* APIGateway (3.3.12.0)
	* Add support for Access logs and customizable integration timeouts
* CloudFormation (3.3.9.0)
	* 1) Instance-level parameter overrides (CloudFormation-StackSet feature): This feature will allow the customers to override the template parameters on specific stackInstances. Customers will also have ability to update their existing instances with/without parameter-overrides using a new API "UpdateStackInstances"                                                                                                                                                                                                                                                         2) Add support for SSM parameters in CloudFormation - This feature will allow the customers to use Systems Manager parameters in CloudFormation templates. They will be able to see values for these parameters in Describe APIs.
* CodeBuild (3.3.6.0)
	* Adding support for accessing Amazon VPC resources from AWS CodeBuild, dependency caching and build badges.
* ElasticMapReduce (3.3.5.0)
	* Enable Kerberos on Amazon EMR. 
* Rekognition (3.3.7.0)
	* This release includes updates to Amazon Rekognition for the following APIs. The new DetectText API allows you to recognize and extract textual content from images. Face Model Versioning has been added to operations that deal with face detection.
* Shield (3.3.1.0)
	* The AWS Shield SDK has been updated in order to support Elastic IP address protections, the addition of AttackProperties objects in DescribeAttack responses, and a new GetSubscriptionState operation.
* StorageGateway (3.3.6.0)
	* AWS Storage Gateway now enables you to get notification when all your files written to your NFS file share have been uploaded to Amazon S3. Storage Gateway also enables guessing of the MIME type for uploaded objects based on file extensions.

### 3.3.194.0 (2017-11-20 23:33 UTC)
* APIGateway (3.3.11.1)
	* Documentation updates for Apigateway
* CodeCommit (3.3.3.0)
	* AWS CodeCommit now supports pull requests. You can use pull requests to collaboratively review code changes for minor changes or fixes, major feature additions, or new versions of your released software.
* CostExplorer (3.3.0.0)
	* The AWS Cost Explorer API gives customers programmatic access to AWS cost and usage information, allowing them to perform adhoc queries and build interactive cost management applications that leverage this dataset.
* Kinesis (3.3.4.0)
	* Customers can now obtain the important characteristics of their stream with DescribeStreamSummary. The response will not include the shard list for the stream but will have the number of open shards, and all the other fields included in the DescribeStream response.
* KinesisFirehose (3.3.3.0)
	* This release includes a new Kinesis Firehose feature that supports Splunk as Kinesis Firehose delivery destination. You can now use Kinesis Firehose to ingest real-time data to Splunk in a serverless, reliable, and salable manner. This release also includes a new feature that allows you to configure Lambda buffer size in Kinesis Firehose data transformation feature. You can now customize the data buffer size before invoking Lambda function in Kinesis Firehose for data transformation. This feature allows you to flexibly trade-off processing and delivery latency with cost and efficiency based on your specific use cases and requirements. 
* WorkDocs (3.3.4.0)
	* DescribeGroups API and miscellaneous enhancements

### 3.3.193.0 (2017-11-18 00:19 UTC)
* ApplicationAutoScaling (3.3.7.0)
	* This SDK update contains support for Target Tracking scaling for EC2 Spot Fleet. It allows you to scale an EC2 Spot Fleet using a Target Tracking scaling policy.
* DatabaseMigrationService (3.3.5.0)
	* Support for migration task assessment. Support for data validation after the migration.
* ElasticLoadBalancingV2 (3.3.7.2)
	* This release adds Proxy Protocol v2 support for Network Load Balancer. Proxy protocol provides a convenient way to transport connection information (such as a client's source IP address/port and destination IP address/port) for a TCP connection across multiple layers of NAT or TCP proxies.
* RDS (3.3.18.0)
	* Amazon RDS now supports importing MySQL databases by using backup files from Amazon S3.
* S3 (3.3.14.0)
	* Added ORC to the supported S3 Inventory formats.

### 3.3.192.0 (2017-11-16 23:30 UTC)
* ApplicationAutoScaling (3.3.6.0)
	* Application Auto Scaling now supports automatic scaling of Amazon Aurora replicas
* EC2 (3.3.37.0)
	* You are now able to create and launch EC2 x1e smaller instance sizes
* Glue (3.3.2.0)
	* API update for AWS Glue. New crawler configuration attribute enables customers to specify crawler behavior. New XML classifier enables classification of XML data.
* OpsWorksCM (3.3.4.3)
	* Documentation updates for OpsWorks-cm: a new feature, OpsWorks for Puppet Enterprise, that allows users to create and manage OpsWorks-hosted Puppet Enterprise servers.
* Organizations (3.3.7.0)
	* This release adds APIs that you can use to enable and disable integration with AWS services designed to work with AWS Organizations. This integration allows the AWS service to perform operations on your behalf on all of the accounts in your organization. Although you can use these APIs yourself, we recommend that you instead use the commands provided in the other AWS service to enable integration with AWS Organizations.
* Route53 (3.3.11.0)
	* You can use Route 53's GetAccountLimit/GetHostedZoneLimit/GetReusableDelegationSetLimit APIs to view your current limits (including custom set limits) on Route 53 resources such as hosted zones and health checks. These APIs also return the number of each resource you're currently using to enable comparison against your current limits.

### 3.3.191.0 (2017-11-15 19:03 UTC)
* APIGateway (3.3.11.0)
	* 1. Extended GetDocumentationParts operation to support retrieving documentation parts resources without contents.  2. Added hosted zone ID in the custom domain response.
* Polly (3.3.4.0)
	* Amazon Polly adds Korean language support with new female voice - "Seoyeon" and new Indian English female voice - "Aditi"
* SimpleEmail (3.3.5.0)
	* SES launches Configuration Set Reputation Metrics and Email Pausing Today, two features that build upon the capabilities of the reputation dashboard. The first is the ability to export reputation metrics for individual configuration sets. The second is the ability to temporarily pause email sending, either at the configuration set level, or across your entire Amazon SES account.
* StepFunctions (3.3.2.0)
	* You can now use the UpdateStateMachine API to update your state machine definition and role ARN. Existing executions will continue to use the previous definition and role ARN. You can use the DescribeStateMachineForExecution API to determine which state machine definition and role ARN is associated with an execution

### 3.3.190.0 (2017-11-15 00:20 UTC)
* ECS (3.3.8.0)
	* Added new mode for Task Networking in ECS, called awsvpc mode. Mode configuration parameters to be passed in via awsvpcConfiguration. Updated APIs now use/show this new mode - RegisterTaskDefinition, CreateService, UpdateService, RunTask, StartTask.
* Lightsail (3.3.4.0)
	* Lightsail now supports attached block storage, which allows you to scale your applications and protect application data with additional SSD-backed storage disks. This feature allows Lightsail customers to attach secure storage disks to their Lightsail instances and manage their attached disks, including creating and deleting disks, attaching and detaching disks from instances, and backing up disks via snapshot.
* Route53 (3.3.10.0)
	* When a Route 53 health check or hosted zone is created by a linked AWS service, the object now includes information about the service that created it. Hosted zones or health checks that are created by a linked service can't be updated or deleted using Route 53.
* S3 (3.3.13.0)
	* Fix for issue where a key is used as both a header and a parameter.
* SimpleSystemsManagement (3.3.14.0)
	* EC2 Systems Manager GetInventory API adds support for aggregation.

### 3.3.189.0 (2017-11-11 06:50 UTC)
* S3 (3.3.12.1)
	* Support RequestPayer parameter in AmazonS3Client::GeneratePreSignedURL
* Core 3.3.19.0
	* Add hook for other AWS packages to customize globally how request are made
    * Fixed issue with putting objects with streams that are not seekable.
	* All services packages updated to require new Core

### 3.3.188.0 (2017-11-09 21:38 UTC)
* EC2 (3.3.36.0)
	* Introduces the following features: 1. Create a default subnet in an Availability Zone if no default subnet exists. 2. Spot Fleet integrates with Elastic Load Balancing to enable you to attach one or more load balancers to a Spot Fleet request. When you attach the load balancer, it automatically registers the instance in the Spot Fleet to the load balancers which distributes incoming traffic across the instances. 

### 3.3.187.0 (2017-11-08 21:51 UTC)
* ApplicationAutoScaling (3.3.5.0)
	* Application Auto Scaling customers are now able to schedule adjustments to their MinCapacity and MaxCapacity, which makes it possible to pre-provision adequate capacity for anticipated demand and then reduce the provisioned capacity as demand lulls.
* Batch (3.3.3.4)
	* Documentation updates for AWS Batch.
* EC2 (3.3.35.0)
	* AWS PrivateLink for Amazon Services - Customers can now privately access Amazon services from their Amazon Virtual Private Cloud (VPC), without using public IPs, and without requiring the traffic to traverse across the Internet.
* ElastiCache (3.3.5.0)
	* This release adds online resharding for ElastiCache for Redis offering, providing the ability to add and remove shards from a running cluster. Developers can now dynamically scale-out or scale-in their Redis cluster workloads to adapt to changes in demand. ElastiCache will resize the cluster by adding or removing shards and redistribute hash slots uniformly across the new shard configuration, all while the cluster continues to stay online and serves requests.
* Core 3.3.18.4
	* Updates several S3 endpoints.



### 3.3.186.1 (2017-11-08 01:16 UTC)
* WorkDocs (3.3.3.1)
	* WorkDocs content manager bug fix: remove encryption header from shared http client once it is used

### 3.3.186.0 (2017-11-07 22:48 UTC)
* ElasticLoadBalancingV2 (3.3.7.0)
	* Added a new limit related to Network Load Balancers on the number of targets per load balancer per AZ.
* RDS (3.3.17.0)
	* DescribeOrderableDBInstanceOptions now returns the minimum and maximum allowed values for storage size, total provisioned IOPS, and provisioned IOPS per GiB for a DB instance.
* S3 (3.3.12.0)
	* This releases adds support for 4 features: 1. Default encryption for S3 Bucket, 2. Encryption status in inventory and Encryption support for inventory.  3. Cross region replication of KMS-encrypted objects, and 4. ownership overwrite for CRR. 
* Core 3.3.18.3
	* Region launch expansion for SCS in new region AP-SOUTH-1 BOM
Region launch expansion of Service Catalog Service for new region US-WEST-1
Region launch expansion of SCS for new region SA-EAST-1
Core update to support for empty service partition entry on endpoints.json file.



### 3.3.185.0 (2017-11-07 01:38 UTC)
* EC2 (3.3.34.0)
	* You are now able to create and launch EC2 C5 instances, the next generation of EC2's compute-optimized instances, in us-east-1, us-west-2 and eu-west-1. C5 instances offer up to 72 vCPUs, 144 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes to deliver improved performance for compute-intensive workloads.
* KeyManagementService (3.3.4.0)
	* Documentation updates for AWS KMS. 
* Organizations (3.3.6.2)
	* This release updates permission statements for several API operations, and corrects some other minor errors.
* Pricing (3.3.0.0)
	* This is the initial release of AWS Price List Service.
* StepFunctions (3.3.1.0)
	* Documentation update.

### 3.3.184.0 (2017-11-03 20:48 UTC)
* ECS (3.3.7.0)
	* Amazon ECS users can now add devices to their containers and enable init process in containers through the use of docker's 'devices' and 'init' features. These fields can be specified under linuxParameters in ContainerDefinition in the Task Definition Template. 

### 3.3.183.0 (2017-11-02 23:55 UTC)
* APIGateway (3.3.10.0)
	* This release supports creating and managing Regional and Edge-Optimized API endpoints.

### 3.3.182.0 (2017-11-01 16:59 UTC)
* CertificateManager (3.3.2.17)
	* Documentation updates for ACM
* CloudHSMV2 (3.3.0.3)
	* Minor documentation update for AWS CloudHSM (cloudhsmv2).
* DirectConnect (3.3.5.0)
	* AWS DirectConnect now provides support for Global Access for Virtual Private Cloud (VPC) via a new feature called Direct Connect Gateway. A Direct Connect Gateway will allow you to group multiple Direct Connect Private Virtual Interfaces (DX-VIF) and Private Virtual Gateways (VGW) from different AWS regions (but belonging to the same AWS Account) and pass traffic from any DX-VIF to any VPC in the grouping.

### 3.3.181.0 (2017-10-30 23:54 UTC)
* WorkDocs (3.3.3.0)
	* Added WorkDocs ContentManager

### 3.3.180.0 (2017-10-27 00:36 UTC)
* CloudFront (3.3.6.0)
	* You can now specify additional options for MinimumProtocolVersion, which controls the SSL/TLS protocol that CloudFront uses to communicate with viewers. The minimum protocol version that you choose also determines the ciphers that CloudFront uses to encrypt the content that it returns to viewers.
* EC2 (3.3.33.0)
	* You are now able to create and launch EC2 P3 instance, next generation GPU instances, optimized for machine learning and high performance computing applications. With up to eight NVIDIA Tesla V100 GPUs, P3 instances provide up to one petaflop of mixed-precision, 125 teraflops of single-precision, and 62 teraflops of double-precision floating point performance, as well as a 300 GB/s second-generation NVLink interconnect that enables high-speed, low-latency GPU-to-GPU communication. P3 instances also feature up to 64 vCPUs based on custom Intel Xeon E5 (Broadwell) processors, 488 GB of DRAM, and 25 Gbps of dedicated aggregate network bandwidth using the Elastic Network Adapter (ENA).

### 3.3.179.0 (2017-10-24 18:01 UTC)
* ConfigService (3.3.11.0)
	* AWS Config support for CodeBuild Project resource type
* ElastiCache (3.3.4.0)
	* Amazon ElastiCache for Redis today announced support for data encryption both for data in-transit and data at-rest. The new encryption in-transit functionality enables ElastiCache for Redis customers to encrypt data for all communication between clients and Redis engine, and all intra-cluster Redis communication. The encryption at-rest functionality allows customers to encrypt their S3 based backups. Customers can begin using the new functionality by simply enabling this functionality via AWS console, and a small configuration change in their Redis clients. The ElastiCache for Redis service automatically manages life cycle of the certificates required for encryption, including the issuance, renewal and expiration of certificates. Additionally, as part of this launch, customers will gain the ability to start using the Redis AUTH command that provides an added level of authentication.
* Glue (3.3.1.0)
	* AWS Glue: Adding a new API, BatchStopJobRun, to stop one or more job runs for a specified Job. 
* Pinpoint (3.3.5.0)
	* Added support for APNs VoIP messages. Added support for collapsible IDs, message priority, and TTL for APNs and FCM/GCM.
* S3 (3.3.11.4)
	* PR 769, fix issue with mocking TransferUtility

### 3.3.178.1 (2017-10-24 00:07 UTC)
* Core 3.3.18.2
	* Restored missing UAP binaries in service nuget packages.
	* All services packages updated to require new Core

### 3.3.178.0 (2017-10-23 20:39 UTC)
* Organizations (3.3.6.0)
	* This release supports integrating other AWS services with AWS Organizations through the use of an IAM service-linked role called AWSServiceRoleForOrganizations. Certain operations automatically create that role if it does not already exist.

### 3.3.177.0 (2017-10-20 19:09 UTC)
* EC2 (3.3.32.0)
	* Adding pagination support for DescribeSecurityGroups for EC2 Classic and VPC Security Groups

### 3.3.176.0 (2017-10-19 21:02 UTC)
* SimpleSystemsManagement (3.3.13.0)
	* EC2 Systems Manager versioning support for Parameter Store. Also support for referencing parameter versions in SSM Documents.
* SQS (3.3.3.0)
	* Added support for tracking cost allocation by adding, updating, removing, and listing the metadata tags of Amazon SQS queues.

### 3.3.175.0 (2017-10-18 20:10 UTC)
* Lightsail (3.3.3.0)
	* This release adds support for Windows Server-based Lightsail instances. The GetInstanceAccessDetails API now returns the password of your Windows Server-based instance when using the default key pair. GetInstanceAccessDetails also returns a PasswordData object for Windows Server instances containing the ciphertext and keyPairName. The Blueprint data type now includes a list of platform values (LINUX_UNIX or WINDOWS). The Bundle data type now includes a list of SupportedPlatforms values (LINUX_UNIX or WINDOWS).

### 3.3.174.0 (2017-10-17 20:37 UTC)
* Elasticsearch (3.3.3.0)
	* This release adds support for VPC access to Amazon Elasticsearch Service.
* Core 3.3.18.1
	* Service Region Launch.



### 3.3.173.0 (2017-10-16 20:49 UTC)
* CloudHSM (3.3.0.23)
	* Documentation updates for AWS CloudHSM Classic.
* EC2 (3.3.31.0)
	* You can now change the tenancy of your VPC from dedicated to default with a single API operation. For more details refer to the documentation for changing VPC tenancy.
* Elasticsearch (3.3.2.0)
	* AWS Elasticsearch adds support for enabling slow log publishing. Using slow log publishing options customers can configure and enable index/query slow log publishing of their domain to preferred AWS Cloudwatch log group.
* RDS (3.3.16.0)
	* Adds waiters for DBSnapshotAvailable and DBSnapshotDeleted.
* S3 (3.3.11.2)
	* Fixed typo in exception messages.
* WAF (3.3.3.0)
	* This release adds support for regular expressions as match conditions in rules, and support for geographical location by country of request IP address as a match condition in rules.
* WAFRegional (3.3.2.0)
	* This release adds support for regular expressions as match conditions in rules, and support for geographical location by country of request IP address as a match condition in rules.

### 3.3.172.0 (2017-10-12 18:48 UTC)
* CodeCommit (3.3.2.0)
	* This release includes the DeleteBranch API and a change to the contents of a Commit object.
* DatabaseMigrationService (3.3.4.0)
	* This change includes addition of new optional parameter to an existing API
* ElasticBeanstalk (3.3.6.0)
	* Added the ability to add, delete or update Tags
* Polly (3.3.3.0)
	* Amazon Polly exposes two new voices: "Matthew" (US English) and "Takumi" (Japanese)
* RDS (3.3.15.0)
	* You can now call DescribeValidDBInstanceModifications to learn what modifications you can make to your DB instance. You can use this information when you call ModifyDBInstance.

### 3.3.171.0 (2017-10-11 19:11 UTC)
* ECR (3.3.3.0)
	* Adds support for new API set used to manage Amazon ECR repository lifecycle policies. Amazon ECR lifecycle policies enable you to specify the lifecycle management of images in a repository. The configuration is a set of one or more rules, where each rule defines an action for Amazon ECR to apply to an image. This allows the automation of cleaning up unused images, for example expiring images based on age or status. A lifecycle policy preview API is provided as well, which allows you to see the impact of a lifecycle policy on an image repository before you execute it
* SimpleEmail (3.3.4.0)
	* Added content related to email template management and templated email sending operations.

### 3.3.170.0 (2017-10-10 18:57 UTC)
* EC2 (3.3.30.0)
	* This release includes updates to AWS Virtual Private Gateway.
* ElasticLoadBalancingV2 (3.3.6.0)
	* Server Name Indication (SNI) is an extension to the TLS protocol by which a client indicates the hostname to connect to at the start of the TLS handshake. The load balancer can present multiple certificates through the same secure listener, which enables it to support multiple secure websites using a single secure listener. Application Load Balancers also support a smart certificate selection algorithm with SNI. If the hostname indicated by a client matches multiple certificates, the load balancer determines the best certificate to use based on multiple factors including the capabilities of the client.
* OpsWorksCM (3.3.4.0)
	* Provide engine specific information for node associations.

### 3.3.169.0 (2017-10-09 01:26 UTC)
* Core 3.3.18.0
	* Added a new **HttpClientCacheSize** property to the service config object to control the number of HttpClient objects cached for the .NET Core version of the SDK.
	* Updated all service client operations to be virtual
	* All services packages updated to require new Core

### 3.3.168.1 (2017-10-06 22:28 UTC)
* SQS (3.3.2.8)
	* Documentation updates regarding availability of FIFO queues and miscellaneous corrections.

### 3.3.168.0 (2017-10-05 19:28 UTC)
* Redshift (3.3.3.0)
	* DescribeEventSubscriptions API supports tag keys and tag values as request parameters. 

### 3.3.167.0 (2017-10-04 21:44 UTC)
* KinesisAnalytics (3.3.3.0)
	* Kinesis Analytics now supports schema discovery on objects in S3.  Additionally, Kinesis Analytics now supports input data preprocessing through Lambda.
* Route53Domains (3.3.1.0)
	* Added a new API that checks whether a domain name can be transferred to Amazon Route 53.

### 3.3.166.0 (2017-10-03 17:20 UTC)
* EC2 (3.3.29.0)
	* This release includes service updates to AWS VPN.
* SimpleSystemsManagement (3.3.12.0)
	* EC2 Systems Manager support for tagging SSM Documents. Also support for tag-based permissions to restrict access to SSM Documents based on these tags.

### 3.3.165.1 (2017-10-02 19:28 UTC)
* CloudHSM (3.3.0.21)
	* Documentation updates for CloudHSM

### 3.3.165.0 (2017-09-29 20:03 UTC)
* AppStream (3.3.6.0)
	* Includes APIs for managing and accessing image builders, and deleting images.
* CodeBuild (3.3.5.0)
	* Adding support for Building GitHub Pull Requests in AWS CodeBuild
* MTurk (3.3.1.0)
	* Today, Amazon Mechanical Turk (MTurk) supports SQS Notifications being delivered to Customers' SQS queues when different stages of the MTurk workflow are complete.  We are going to create new functionality so that Customers can leverage SNS topics as a destination for notification messages when various stages of the MTurk workflow are complete. 
* Organizations (3.3.5.0)
	* This release flags the HandshakeParty structure's Type and Id fields as 'required'. They effectively were required in the past, as you received an error if you did not include them. This is now reflected at the API definition level. 
* Route53 (3.3.9.0)
	* This change allows customers to reset elements of health check.

### 3.3.164.0 (2017-09-27 22:03 UTC)
* Pinpoint (3.3.4.0)
	* Added two new push notification channels: Amazon Device Messaging (ADM) and, for push notification support in China, Baidu Cloud Push. Added support for APNs auth via .p8 key file. Added operation for direct message deliveries to user IDs, enabling you to message an individual user on multiple endpoints.

### 3.3.163.0 (2017-09-26 18:20 UTC)
* CloudFormation (3.3.8.0)
	* You can now prevent a stack from being accidentally deleted by enabling termination protection on the stack. If you attempt to delete a stack with termination protection enabled, the deletion fails and the stack, including its status, remains unchanged. You can enable termination protection on a stack when you create it. Termination protection on stacks is disabled by default. After creation, you can set termination protection on a stack whose status is CREATE_COMPLETE, UPDATE_COMPLETE, or UPDATE_ROLLBACK_COMPLETE.

### 3.3.162.0 (2017-09-22 19:56 UTC)
* ConfigService (3.3.10.0)
	* AWS Config support for DynamoDB tables and Auto Scaling resource types
* ECS (3.3.6.0)
	* Amazon ECS users can now add and drop Linux capabilities to their containers through the use of docker's cap-add and cap-drop features. Customers can specify the capabilities they wish to add or drop for each container in their task definition. 
* RDS (3.3.14.1)
	* Documentation updates for rds

### 3.3.161.0 (2017-09-21 19:40 UTC)
* Budgets (3.3.4.0)
	* Including "DuplicateRecordException" in UpdateNotification and UpdateSubscriber. 
* CloudWatchLogs (3.3.4.0)
	* Adds support for associating LogGroups with KMS Keys.
* EC2 (3.3.28.0)
	* Add EC2 APIs to copy Amazon FPGA Images (AFIs) within the same region and across multiple regions, delete AFIs, and modify AFI attributes. AFI attributes include name, description and granting/denying other AWS accounts to load the AFI.

### 3.3.160.0 (2017-09-20 22:48 UTC)
* AppStream (3.3.5.0)
	* API updates for supporting On-Demand fleets.
* CodePipeline (3.3.2.0)
	* This change includes a PipelineMetadata object that is part of the output from the GetPipeline API that includes the Pipeline ARN, created, and updated timestamp.
* EC2 (3.3.27.0)
	* Descriptions for Security Group Rules enables customers to be able to define a description for ingress and egress security group rules . The Descriptions for Security Group Rules feature supports one description field per Security Group rule for both ingress and egress rules . Descriptions for Security Group Rules provides a simple way to describe the purpose or function of a Security Group Rule allowing for easier customer identification of configuration elements .      Prior to the release of Descriptions for Security Group Rules , customers had to maintain a separate system outside of AWS if they wanted to track Security Group Rule mapping and their purpose for being implemented. If a security group rule has already been created and you would like to update or change your description for that security group rule you can use the UpdateSecurityGroupRuleDescription API. The IpRanges property on IpPermission has been deprecated in favor of a new property, Ipv4Ranges
* Greengrass (3.3.1.0)
	* Reset Deployments feature allows you to clean-up the cloud resource so you can delete the group. It also cleans up the core so that it goes back to the pre-deployment state.
* Lex (3.3.2.0)
	* Request attributes can be used to pass client specific information from the client to Amazon Lex as part of each request.
* RDS (3.3.14.0)
	* Introduces the --option-group-name parameter to the ModifyDBSnapshot CLI command. You can specify this parameter when you upgrade an Oracle DB snapshot. The same option group considerations apply when upgrading a DB snapshot as when upgrading a DB instance.  For more information, see http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Oracle.html#USER_UpgradeDBInstance.Oracle.OGPG.OG
* Core 3.3.17.10
	* AWS Greengrass is now available in the Asia Pacific (Tokyo) region, ap-northeast-1.



### 3.3.159.0 (2017-09-18 23:14 UTC)
* EC2 (3.3.26.0)
	* Amazon EC2 now lets you opt for Spot instances to be stopped in the event of an interruption instead of being terminated.  Your Spot request can be fulfilled again by restarting instances from a previously stopped state, subject to availability of capacity at or below your preferred price.  When you submit a persistent Spot request, you can choose from \"terminate\" or \"stop\" as the instance interruption behavior.  Choosing \"stop\" will shutdown your Spot instances so you can continue from this stopped state later on.  This feature is only available for instances with Amazon EBS volume as their root device.
* IdentityManagement (3.3.5.0)
	* A new API, DeleteServiceLinkedRole, submits a service-linked role deletion request and returns a DeletionTaskId, which you can use to check the status of the deletion.
* SimpleEmail (3.3.3.0)
	* Amazon Simple Email Service (Amazon SES) now lets you customize the domains used for tracking open and click events. Previously, open and click tracking links referred to destinations hosted on domains operated by Amazon SES. With this feature, you can use your own branded domains for capturing open and click events.

### 3.3.158.0 (2017-09-15 19:46 UTC)
* APIGateway (3.3.9.0)
	* Add a new enum "REQUEST" to '--type <value>' field in the current create-authorizer API, and make "identitySource" optional.

### 3.3.157.0 (2017-09-14 21:13 UTC)
* CodeBuild (3.3.4.0)
	* Supporting Parameter Store in environment variables for AWS CodeBuild
* Organizations (3.3.4.1)
	* Documentation updates for AWS Organizations
* ServiceCatalog (3.3.5.0)
	* This release of Service Catalog adds API support to copy products.

### 3.3.156.0 (2017-09-13 20:33 UTC)
* AutoScaling (3.3.2.0)
	* Customers can create Life Cycle Hooks at the time of creating Auto Scaling Groups through the CreateAutoScalingGroup API
* Batch (3.3.3.1)
	* Documentation updates for batch
* CloudWatchEvents (3.3.3.0)
	* Exposes ConcurrentModificationException as one of the valid exceptions for PutPermission and RemovePermission operation.
* EC2 (3.3.25.0)
	* You are now able to create and launch EC2 x1e.32xlarge instance, a new EC2 instance in the X1 family, in us-east-1, us-west-2, eu-west-1, and ap-northeast-1. x1e.32xlarge offers 128 vCPUs, 3,904 GiB of DDR4 instance memory, high memory bandwidth, large L3 caches, and leading reliability capabilities to boost the performance and reliability of in-memory applications.

### 3.3.155.0 (2017-09-12 22:22 UTC)
* KeyManagementService (3.3.3.1)
	* Updated to use new Core, version 3.3.17.9
	* Support changes to allow use of KMS master keys with AmazonS3EncryptionClient.
* S3 (3.3.11.0)
	* Updated to use new Core, version 3.3.17.9
	* Allow use of KMS master keys with AmazonS3EncryptionClient.
* Core 3.3.17.9
	* Support changes to allow use of KMS master keys with AmazonS3EncryptionClient.

### 3.3.154.0 (2017-09-12 17:08 UTC)
* EC2 (3.3.24.0)
	* Fixed bug in EC2 clients preventing HostOfferingSet from being set

### 3.3.153.0 (2017-09-11 21:03 UTC)
* DeviceFarm (3.3.3.0)
	* DeviceFarm has added support for two features - RemoteDebugging and Customer Artifacts. Customers  can now do remote Debugging on their Private Devices and can now retrieve custom files generated by their tests on the device and the device host (execution environment) on both public and private devices. 

### 3.3.152.1 (2017-09-09 04:44 UTC)
* CognitoSync (3.3.1.23)
	* Updated to use new Core, version 3.3.17.8
	* Fixed a race condition in SQLiteLocalStorage.ConditionallyPutRecords() PR https://github.com/aws/aws-sdk-net/pull/446
    * Make the local merge dataset sync count match the remote sync count PR https://github.com/aws/aws-sdk-net/pull/414
    * Handle Cognito Sync Count Exception PR https://github.com/aws/aws-sdk-net/pull/532
* Core 3.3.17.8
	* Update UnityWebRequestWrapper to work in Unity 2017.1 PR https://github.com/aws/aws-sdk-net/pull/709

### 3.3.152.0 (2017-09-08 19:39 UTC)
* CloudWatchLogs (3.3.3.0)
	* Adds support for the PutResourcePolicy, DescribeResourcePolicy and DeleteResourcePolicy APIs.

### 3.3.151.0 (2017-09-07 22:49 UTC)
* ApplicationAutoScaling (3.3.4.1)
	* Documentation updates for application-autoscaling
* EC2 (3.3.23.0)
	* With Tagging support, you can add Key and Value metadata to search, filter and organize your NAT Gateways according to your organization's needs.
* ElasticLoadBalancingV2 (3.3.5.0)
	* The feature enables the new Network Load Balancer that is optimized to handle volatile traffic patterns while using a single static IP address per Availability Zone. Network Load Balancer operates at the connection level (Layer 4), routing connections to Amazon EC2 instances and containers, within Amazon Virtual Private Cloud (Amazon VPC) based on IP protocol data.
* LexModelBuildingService (3.3.3.0)
	* Amazon Lex provides the ability to export your Amazon Lex chatbot definition as a JSON file that can be added to the target platform. The JSON configuration file contains the structure of your Amazon Lex chatbot, including the intent schema with utterances, slots, prompts and slot-types.
* Route53 (3.3.8.0)
	* You can configure Amazon Route 53 to log information about the DNS queries that Amazon Route 53 receives for your domains and subdomains. When you configure query logging, Amazon Route 53 starts to send logs to CloudWatch Logs. You can use various tools, including the AWS console, to access the query logs.

### 3.3.150.1 (2017-09-07 06:06 UTC)
* CognitoSync (3.3.1.22)
	* Added try catch block around GetIdentityId during sync. PR https://github.com/aws/aws-sdk-net/pull/408
* S3 (3.3.10.4)
	* Fixed bug with S3 Util method PostUpload that wasn't disposing the HttpWebResponse.
    * Extend S3 signed URLs to allow for custom parameters that cannot be altered PR https://github.com/aws/aws-sdk-net/pull/698
* Core 3.3.17.7
	* Improve AsyncRunner utility method to reduce thread usage PR https://github.com/aws/aws-sdk-net/pull/731
    * Don't allocate memory in UnmarshallerContext.TestExpression. PR https://github.com/aws/aws-sdk-net/pull/716
    * Fixed unhandled exception in UnityWebResponseData.CopyHeaderValues. PR https://github.com/aws/aws-sdk-net/pull/743



### 3.3.150.0 (2017-09-06 18:04 UTC)
* Budgets (3.3.3.0)
	* Add an optional "thresholdType" to notifications to support percentage or absolute value thresholds.
* S3 (3.3.10.3)
	* Remove unused model type TagQuery

### 3.3.149.0 (2017-09-05 16:41 UTC)
* CodeStar (3.3.1.0)
	* Added support to tag CodeStar projects. Tags can be used to organize and find CodeStar projects on key-value pairs that you can choose. For example, you could add a tag with a key of "Release" and a value of "Beta" to projects your organization is working on for an upcoming beta release.

### 3.3.148.0 (2017-09-01 19:02 UTC)
* GameLift (3.3.9.0)
	* GameLift VPC resources can be peered with any other AWS VPC. R4 memory-optimized instances now available to deploy.
* Mobile (3.3.0.0)
	* AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.
* SimpleSystemsManagement (3.3.11.0)
	* Adding KMS encryption support to SSM Inventory Resource Data Sync. Exposes the ClientToken parameter on SSM StartAutomationExecution to provide idempotent execution requests.

### 3.3.147.0 (2017-08-31 21:35 UTC)
* CodeBuild (3.3.3.0)
	* The AWS CodeBuild HTTP API now provides the BatchDeleteBuilds operation, which enables you to delete existing builds.
* ElasticLoadBalancingV2 (3.3.4.0)
	* This change now allows Application Load Balancers to distribute traffic to AWS resources using their IP addresses as targets in addition to the instance IDs. You can also load balance to resources outside the VPC hosting the load balancer using their IP addresses as targets. This includes resources in peered VPCs, EC2-Classic, and on-premises locations reachable over AWS Direct Connect or a VPN connection.
* LexModelBuildingService (3.3.2.0)
	* Amazon Lex now supports synonyms for slot type values. If the user inputs a synonym, it will be resolved to the corresponding slot value.
* Core 3.3.17.6
	* Look at AWS_PROFILE environment variable in FallbackCredentialsFactory and FallbackRegionFactory.

### 3.3.146.0 (2017-08-30 16:16 UTC)
* ApplicationAutoScaling (3.3.4.0)
	* Application Auto Scaling now supports the DisableScaleIn option for Target Tracking Scaling Policies. This allows customers to create scaling policies that will only add capacity to the target.
* Organizations (3.3.4.0)
	* The exception ConstraintViolationException now contains a new reason subcode MASTERACCOUNT_MISSING_CONTACT_INFO to make it easier to understand why attempting to remove an account from an Organization can fail. We also improved several other of the text descriptions and examples.

### 3.3.145.0 (2017-08-29 18:35 UTC)
* ConfigService (3.3.9.0)
	* Increased the internal size limit of resourceId
* EC2 (3.3.22.0)
	* Provides capability to add secondary CIDR blocks to a VPC.

### 3.3.144.0 (2017-08-25 21:01 UTC)
* CloudFormation (3.3.7.0)
	* Rollback triggers enable you to have AWS CloudFormation monitor the state of your application during stack creation and updating, and to roll back that operation if the application breaches the threshold of any of the alarms you've specified.
* GameLift (3.3.8.0)
	* Update spelling of MatchmakingTicket status values for internal consistency.
* RDS (3.3.13.0)
	* Option group options now contain additional properties that identify requirements for certain options. Check these properties to determine if your DB instance must be in a VPC or have auto minor upgrade turned on before you can use an option. Check to see if you can downgrade the version of an option after you have installed it.

### 3.3.143.1 (2017-08-24 22:23 UTC)
* S3 (3.3.10.2)
	* Added ability to specify content type for all files when uploading a folder. Note that this overrides the default behavior which inspects the file extensions to set content type, and applies the specified content type to all files uploaded from the folder hierarchy.

### 3.3.143.0 (2017-08-24 18:16 UTC)
* Rekognition (3.3.6.0)
	* Update the enum value of LandmarkType and GenderType to be consistent with service response

### 3.3.142.1 (2017-08-23 19:38 UTC)
* AppStream (3.3.4.1)
	* Documentation updates for appstream

### 3.3.142.0 (2017-08-22 18:31 UTC)
* SimpleSystemsManagement (3.3.10.0)
	* Changes to associations in Systems Manager State Manager can now be recorded. Previously, when you edited associations, you could not go back and review older association settings. Now, associations are versioned, and can be named using human-readable strings, allowing you to see a trail of association changes. You can also perform rate-based scheduling, which allows you to schedule associations more granularly.

### 3.3.141.0 (2017-08-22 00:16 UTC)
* KinesisFirehose (3.3.2.0)
	* This change will allow customers to attach a Firehose delivery stream to an existing Kinesis stream directly. You no longer need a forwarder to move data from a Kinesis stream to a Firehose delivery stream. You can now run your streaming applications on your Kinesis stream and easily attach a Firehose delivery stream to it for data delivery to S3, Redshift, or Elasticsearch concurrently.
* Route53 (3.3.7.0)
	* Amazon Route 53 now supports CAA resource record type. A CAA record controls which certificate authorities are allowed to issue certificates for the domain or subdomain.

### 3.3.140.1 (2017-08-16 22:00 UTC)
* EC2 (3.3.21.1)
	* Use HTTPS endpoint to retrieve stockamis.json
* AWSSDK.Extensions.CognitoAuthentication (0.9.0)
	* Developer preview release of an extension library to assist in the Amazon Cognito User Pools authentication process.

### 3.3.140.0 (2017-08-16 19:34 UTC)
* GameLift (3.3.7.0)
	* The Matchmaking Grouping Service is a new feature that groups player match requests for a given game together into game sessions based on developer configured rules.

### 3.3.139.1 (2017-08-16 7:30 UTC)
* CognitoIdentity (3.3.2.14)
	* Fix NotImplementedException exception when using the CognitoAWSCredentials in .NET Core
* S3 (3.3.10.1)
	* Fix doc typo

### 3.3.139.0 (2017-08-15 21:32 UTC)
* EC2 (3.3.21.0)
	* Fixed bug in EC2 clients preventing HostReservation from being set

### 3.3.138.0 (2017-08-14 23:27 UTC)
* S3 (3.3.10.0)
	* Added tagging support for TransferUtility's upload directory command.

### 3.3.137.0 (2017-08-14 16:41 UTC)
* Batch (3.3.3.0)
	* This release enhances the DescribeJobs API to include the CloudWatch logStreamName attribute in ContainerDetail and ContainerDetailAttempt
* CloudHSMV2 (3.3.0.0)
	* CloudHSM provides hardware security modules for protecting sensitive data and cryptographic keys within an EC2 VPC, and enable the customer to maintain control over key access and use. This is a second-generation of the service that will improve security, lower cost and provide better customer usability.
* ElasticFileSystem (3.3.1.0)
	* Customers can create encrypted EFS file systems and specify a KMS master key to encrypt it with.
* Glue (3.3.0.0)
	* AWS Glue is a fully managed extract, transform, and load (ETL) service that makes it easy for customers to prepare and load their data for analytics. You can create and run an ETL job with a few clicks in the AWS Management Console. You simply point AWS Glue to your data stored on AWS, and AWS Glue discovers your data and stores the associated metadata (e.g. table definition and schema) in the AWS Glue Data Catalog. Once cataloged, your data is immediately searchable, queryable, and available for ETL. AWS Glue generates the code to execute your data transformations and data loading processes. AWS Glue generates Python code that is entirely customizable, reusable, and portable. Once your ETL job is ready, you can schedule it to run on AWS Glue's fully managed, scale-out Spark environment. AWS Glue provides a flexible scheduler with dependency resolution, job monitoring, and alerting. AWS Glue is serverless, so there is no infrastructure to buy, set up, or manage. It automatically provisions the environment needed to complete the job, and customers pay only for the compute resources consumed while running ETL jobs. With AWS Glue, data can be available for analytics in minutes.
* MigrationHub (3.3.0.0)
	* AWS Migration Hub provides a single location to track migrations across multiple AWS and partner solutions. Using Migration Hub allows you to choose the AWS and partner migration tools that best fit your needs, while providing visibility into the status of your entire migration portfolio. Migration Hub also provides key metrics and progress for individual applications, regardless of which tools are being used to migrate them. For example, you might use AWS Database Migration Service, AWS Server Migration Service, and partner migration tools to migrate an application comprised of a database, virtualized web servers, and a bare metal server. Using Migration Hub will provide you with a single screen that shows the migration progress of all the resources in the application. This allows you to quickly get progress updates across all of your migrations, easily identify and troubleshoot any issues, and reduce the overall time and effort spent on your migration projects. Migration Hub is available to all AWS customers at no additional charge. You only pay for the cost of the migration tools you use, and any resources being consumed on AWS. 
* SimpleSystemsManagement (3.3.9.0)
	* Systems Manager Maintenance Windows include the following changes or enhancements: New task options using Systems Manager Automation, AWS Lambda, and AWS Step Functions; enhanced ability to edit the targets of a Maintenance Window, including specifying a target name and description, and ability to edit the owner field; enhanced ability to edits tasks; enhanced support for Run Command parameters; and you can now use a --safe flag when attempting to deregister a target. If this flag is enabled when you attempt to deregister a target, the system returns an error if the target is referenced by any task. Also, Systems Manager now includes Configuration Compliance to scan your fleet of managed instances for patch compliance and configuration inconsistencies. You can collect and aggregate data from multiple AWS accounts and Regions, and then drill down into specific resources that aren't compliant.
* StorageGateway (3.3.5.0)
	* Add optional field ForceDelete to DeleteFileShare api.

### 3.3.136.0 (2017-08-11 21:30 UTC)
* CodeDeploy (3.3.7.0)
	* Adds support for specifying Application Load Balancers in deployment groups, for both in-place and blue/green deployments.
* CognitoIdentityProvider (3.3.6.0)
	* We have added support for features for Amazon Cognito User Pools that enable application developers to easily add and customize a sign-up and sign-in user experience, use OAuth 2.0, and integrate with Facebook, Google, Login with Amazon, and SAML-based identity providers.
* EC2 (3.3.20.0)
	* Provides customers an opportunity to recover an EIP that was released

### 3.3.135.0 (2017-08-10 20:29 UTC)
* CloudDirectory (3.3.5.0)
	* Enable BatchDetachPolicy
* CodeBuild (3.3.2.0)
	* Supporting Bitbucket as source type in AWS CodeBuild.

### 3.3.134.1 (2017-08-09 18:18 UTC)
* RDS (3.3.12.4)
	* Documentation updates for RDS.

### 3.3.134.0 (2017-08-09 02:27 UTC)
* ElasticBeanstalk (3.3.5.0)
	* Add support for paginating the result of DescribeEnvironments     Include the ARN of described environments in DescribeEnvironments output

### 3.3.133.0 (2017-08-01 23:14 UTC)
* CodeDeploy (3.3.6.0)
	* AWS CodeDeploy now supports the use of multiple tag groups in a single deployment group (an intersection of tags) to identify the instances for a deployment. When you create or update a deployment group, use the new ec2TagSet and onPremisesTagSet structures to specify up to three groups of tags. Only instances that are identified by at least one tag in each of the tag groups are included in the deployment group.
* ConfigService (3.3.8.0)
	* Added new API, GetDiscoveredResourceCounts, which returns the resource types, the number of each resource type, and the total number of resources that AWS Config is recording in the given region for your AWS account.
* Pinpoint (3.3.3.0)
	* This release of the Pinpoint SDK enables App management - create, delete, update operations, Raw Content delivery for APNs and GCM campaign messages and From Address override.
* SimpleEmail (3.3.2.0)
	* This update adds information about publishing email open and click events. This update also adds information about publishing email events to Amazon Simple Notification Service (Amazon SNS).

### 3.3.132.0 (2017-07-31 23:25 UTC)
* Inspector (3.3.2.0)
	* Inspector's StopAssessmentRun API has been updated with a new input option - stopAction. This request parameter can be set to either START_EVALUATION or SKIP_EVALUATION. START_EVALUATION (the default value, and the previous behavior) stops the AWS agent data collection and begins the results evaluation for findings generation based on the data collected so far. SKIP_EVALUATION cancels the assessment run immediately, after which no findings are generated.
* SimpleSystemsManagement (3.3.8.0)
	* Adds a SendAutomationSignal API to SSM Service. This API is used to send a signal to an automation execution to change the current behavior or status of the execution.
* Core 3.3.17.5
	*  AWS CodeStar is now available in the following regions: Asia Pacific (Singapore), Asia Pacific (Sydney), EU (Frankfurt)



### 3.3.131.0 (2017-07-30 19:34 UTC)
* S3 (3.3.9.0)
	* Fix TransferUtility reporting 0 files transferred when performing directory download

### 3.3.130.0 (2017-07-27 19:59 UTC)
* EC2 (3.3.19.0)
	* The CreateDefaultVPC API enables you to create a new default VPC . You no longer need to contact AWS support, if your default VPC has been deleted.
* KinesisAnalytics (3.3.2.0)
	* Added additional exception types and clarified documentation.
* SecurityToken (3.3.3.0)
	* Removed use of new credential cache when authenticating using SAML, causing issues with the default Kereberos mode. Setting UseDefaultCredentials fixed issue and also worked with NTLM mode, for both domain joined and non-joined usage scenarios.

### 3.3.129.0 (2017-07-26 22:18 UTC)
* CloudFront (3.3.5.0)
	* Fixed CloudFrontCookierSigner incorrectly constructing resource path
* CloudWatch (3.3.4.0)
	* This release adds high resolution features to CloudWatch, with support for Custom Metrics down to 1 second and Alarms down to 10 seconds.
* DynamoDBv2 (3.3.4.17)
	* Corrected a typo.
* EC2 (3.3.18.0)
	* Amazon EC2 Elastic GPUs allow you to easily attach low-cost graphics acceleration to current generation EC2 instances. With Amazon EC2 Elastic GPUs, you can configure the right amount of graphics acceleration to your particular workload without being constrained by fixed hardware configurations and limited GPU selection.

### 3.3.128.0 (2017-07-25 23:11 UTC)
* CloudDirectory (3.3.4.0)
	* Cloud Directory adds support for additional batch operations.
* CloudFormation (3.3.6.0)
	* AWS CloudFormation StackSets enables you to manage stacks across multiple accounts and regions.

### 3.3.127.0 (2017-07-24 20:34 UTC)
* AppStream (3.3.4.0)
	* Amazon AppStream 2.0 image builders and fleets can now access applications and network resources that rely on Microsoft Active Directory (AD) for authentication and permissions. This new feature allows you to join your streaming instances to your AD, so you can use your existing AD user management tools. 
* EC2 (3.3.17.0)
	* Spot Fleet tagging capability allows customers to automatically tag instances launched by Spot Fleet. You can use this feature to label or distinguish instances created by distinct Spot Fleets. Tagging your EC2 instances also enables you to see instance cost allocation by tag in your AWS bill.
* Core 3.3.17.4
	* Made the ‘profile’ keyword, which can be added to the profile name parameter in the shared credentials file, optional.

### 3.3.126.1 (2017-07-24 15:26 UTC)
* SimpleNotificationService (3.3.0.21)
	* Updated to use new Core, version 3.3.17.3
	* Add IsMessageSignatureValid method to .NET Core SDK.
https://github.com/aws/aws-sdk-net/issues/702
* Core 3.3.17.3
	* Stop wrapping exceptions in AsyncHelpers with AggregateException.

### 3.3.126.0 (2017-07-20 22:09 UTC)
* ElasticMapReduce (3.3.4.0)
	* Amazon EMR now includes the ability to use a custom Amazon Linux AMI and adjustable root volume size when launching a cluster.

### 3.3.125.0 (2017-07-19 17:49 UTC)
* Budgets (3.3.2.0)
	* Update budget Management API's to list/create/update RI_UTILIZATION type budget. Update budget Management API's to support DAILY timeUnit for RI_UTILIZATION type budget.

### 3.3.124.0 (2017-07-17 21:14 UTC)
* CognitoIdentityProvider (3.3.5.0)
	* Allows developers to configure user pools for email/phone based signup and sign-in.
* Lambda (3.3.8.0)
	* Lambda@Edge lets you run code closer to your end users without provisioning or managing servers. With Lambda@Edge, your code runs in AWS edge locations, allowing you to respond to your end users at the lowest latency. Your code is triggered by Amazon CloudFront events, such as requests to and from origin servers and viewers, and it is ready to execute at every AWS edge location whenever a request for content is received. You just upload your Node.js code to AWS Lambda and Lambda takes care of everything required to run and scale your code with high availability. You only pay for the compute time you consume - there is no charge when your code is not running.

### 3.3.123.0 (2017-07-14 23:04 UTC)
* ApplicationDiscoveryService (3.3.3.0)
	* Adding feature to the Export API for Discovery Service to allow filters for the export task to allow export based on per agent id.
* AWSMarketplaceCommerceAnalytics (3.3.3.12)
	* Update to Documentation Model For New Report Cadence / Reformat of Docs
* EC2 (3.3.16.0)
	* New EC2 GPU Graphics instance

### 3.3.122.0 (2017-07-13 17:35 UTC)
* APIGateway (3.3.8.0)
	* Adds support for management of gateway responses.
* EC2 (3.3.15.0)
	* X-ENI (or Cross-Account ENI) is a new feature that allows the attachment or association of Elastic Network Interfaces (ENI) between VPCs in different AWS accounts located in the same availability zone. With this new capability, service providers and partners can deliver managed solutions in a variety of new architectural patterns where the provider and consumer of the service are in different AWS accounts.
* LexModelBuildingService (3.3.1.5)
	* Fixed broken links to reference and conceptual content.

### 3.3.121.0 (2017-07-12 18:00 UTC)
* AutoScaling (3.3.1.0)
	* Auto Scaling now supports a new type of scaling policy called target tracking scaling policies that you can use to set up dynamic scaling for your application.
* SimpleWorkflow (3.3.0.21)
	* Added support for attaching control data to Lambda tasks. Control data lets you attach arbitrary strings to your decisions and history events.

### 3.3.120.1 (2017-07-10 22:33 UTC)
* Core 3.3.17.2
	* Fix AWSCredentials.GetCredentialsAsync to use Task.FromResult instead of Task.Run.

### 3.3.120.0 (2017-07-07 19:52 UTC)
* DirectoryService (3.3.2.0)
	* You can now improve the resilience and performance of your Microsoft AD directory by deploying additional domain controllers. Added UpdateNumberofDomainControllers API that allows you to update the number of domain controllers you want for your directory, and DescribeDomainControllers API that allows you to describe the detailed information of each domain controller of your directory. Also added the 'DesiredNumberOfDomainControllers' field to the DescribeDirectories API output for Microsoft AD.
* KeyManagementService (3.3.3.0)
	* This release of AWS Key Management Service introduces the ability to determine whether a key is AWS managed or customer managed.
* Kinesis (3.3.3.0)
	* You can now encrypt your data at rest within an Amazon Kinesis Stream using server-side encryption. Server-side encryption via AWS KMS makes it easy for customers to meet strict data management requirements by encrypting their data at rest within the Amazon Kinesis Streams, a fully managed real-time data processing service.
* SimpleSystemsManagement (3.3.7.0)
	* Amazon EC2 Systems Manager now expands Patching support to Amazon Linux, Red Hat and Ubuntu in addition to the already supported Windows Server.
* Core 3.3.17.1
	* ECS/ECR now available in BJS



### 3.3.119.0 (2017-07-07 01:29 UTC)
* Core 3.3.17.0
	* Fix dependency issues introduced by VS2017 migration
	* All services packages updated to require new Core

### 3.3.118.0 (2017-07-05 17:15 UTC)
* CloudWatch (3.3.3.0)
	* We are excited to announce the availability of APIs and CloudFormation support for CloudWatch Dashboards. You can use the new dashboard APIs or CloudFormation templates to dynamically build and maintain dashboards to monitor your infrastructure and applications. There are four new dashboard APIs - PutDashboard, GetDashboard, DeleteDashboards, and ListDashboards APIs. PutDashboard is used to create a new dashboard or modify an existing one whereas GetDashboard is the API to get the details of a specific dashboard. ListDashboards and DeleteDashboards are used to get the names or delete multiple dashboards respectively. Getting started with dashboard APIs is similar to any other AWS APIs. The APIs can be accessed through AWS SDK or through CLI tools.
* Core 3.3.16.0
	* AWSSDK.Core package's dependency update
	* All services packages updated to require new Core
* AWSSDK.Extensions.NETCore.Setup (3.3.3)
	* Updated package dependencies: more accurate version range of AWSSDK.Core and latest Microsoft.Extensions packages.

### 3.3.117.0 (2017-06-30 19:03 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.3.9)
	* Documentation updates for AWS Marketplace Commerce Analytics.
* S3 (3.3.8.0)
	* API Update for S3: Adding Object Tagging Header to MultipartUpload Initialization

### 3.3.116.0 (2017-06-29 23:45 UTC)
* CloudWatchEvents (3.3.2.0)
	* CloudWatch Events now allows different AWS accounts to share events with each other through a new resource called event bus. Event buses accept events from AWS services, other AWS accounts and PutEvents API calls. Currently all AWS accounts have one default event bus. To send events to another account, customers simply write rules to match the events of interest and attach an event bus in the receiving account as the target to the rule. The PutTargets API has been updated to allow adding cross account event buses as targets. In addition, we have released two new APIs - PutPermission and RemovePermission - that enables customers to add/remove permissions to their default event bus.
* GameLift (3.3.6.0)
	* Allow developers to download GameLift fleet creation logs to assist with debugging.
* SimpleSystemsManagement (3.3.6.0)
	* Adding Resource Data Sync support to SSM Inventory.  New APIs:  * CreateResourceDataSync - creates a new resource data sync configuration,  * ListResourceDataSync - lists existing resource data sync configurations,  * DeleteResourceDataSync - deletes an existing resource data sync configuration. 

### 3.3.115.0 (2017-06-28 21:52 UTC)
* ServiceCatalog (3.3.4.0)
	* Proper tagging of resources is critical to post-launch operations such as billing, cost allocation, and resource management. By using Service Catalog's TagOption Library, administrators can define a library of re-usable TagOptions that conform to company standards, and associate these with Service Catalog portfolios and products. Learn how to move your current tags to the new library, create new TagOptions, and view and associate your library items with portfolios and products. Understand how to ensure that the right tags are created on products launched through Service Catalog and how to provide users with defined selectable tags.
* Core 3.3.15.0
	* Allow session credentials to be used as the source for assume role profiles. AWS Greengrass is now available in new regions.
	* All services packages updated to require new Core

### 3.3.114.0 (2017-06-23 19:10 UTC)
* Lambda (3.3.7.0)
	* The Lambda Invoke API will now throw new exception InvalidRuntimeException (status code 502) for invokes with deprecated runtimes.

### 3.3.113.0 (2017-06-22 23:13 UTC)
* AWSMarketplaceMetering (3.3.1.15)
	* Documentation update.
* CodePipeline (3.3.1.0)
	* A new API, ListPipelineExecutions, enables you to retrieve summary information about the most recent executions in a pipeline, including pipeline execution ID, status, start time, and last updated time. You can request information for a maximum of 100 executions. Pipeline execution data is available for the most recent 12 months of activity.
* DatabaseMigrationService (3.3.3.0)
	* Added tagging for DMS certificates.
* ImportExport (3.3.0.18)
	* Documentation update.
* Lightsail (3.3.2.0)
	* This release adds a new nextPageToken property to the result of the GetOperationsForResource API. Developers can now get the next set of items in a list by making subsequent calls to GetOperationsForResource API with the token from the previous call. This release also deprecates the nextPageCount property, which previously returned null (use the nextPageToken property instead). This release also deprecates the customImageName property on the CreateInstancesRequest class, which was previously ignored by the API.
* Route53 (3.3.6.0)
	* Amazon Route 53 now supports multivalue answers in response to DNS queries, which lets you route traffic approximately randomly to multiple resources, such as web servers. Create one multivalue answer record for each resource and, optionally, associate an Amazon Route 53 health check with each record, and Amazon Route 53 responds to DNS queries with up to eight healthy records.
* Core 3.3.14.2
	* Lambda is now available in the Canada (Central) region.



### 3.3.112.0 (2017-06-21 21:55 UTC)
* DAX (3.3.0.0)
	* Amazon DynamoDB Accelerator (DAX) is a fully managed, highly available, in-memory cache for DynamoDB that delivers up to a 10x performance improvement - from milliseconds to microseconds - even at millions of requests per second. DAX does all the heavy lifting required to add in-memory acceleration to your DynamoDB tables, without requiring developers to manage cache invalidation, data population, or cluster management.
* SimpleSystemsManagement (3.3.5.0)
	* Adding hierarchy support to the SSM Parameter Store API. Added support tor tagging. New APIs: GetParameter - retrieves one parameter, DeleteParameters - deletes multiple parameters (max number 10), GetParametersByPath - retrieves parameters located in the hierarchy. Updated APIs: PutParameter - added ability to enforce parameter value by applying regex (AllowedPattern), DescribeParameters - modified to support Tag filtering.
* WAF (3.3.2.0)
	* You can now create, edit, update, and delete a new type of WAF rule with a rate tracking component.
* WAFRegional (3.3.1.0)
	* You can now create, edit, update, and delete a new type of WAF rule with a rate tracking component.

### 3.3.111.0 (2017-06-20 19:13 UTC)
* WorkDocs (3.3.2.0)
	* This release provides a new API to retrieve the activities performed by WorkDocs users.

### 3.3.110.0 (2017-06-19 18:22 UTC)
* Organizations (3.3.3.0)
	* Improvements to Exception Modeling

### 3.3.109.0 (2017-06-16 17:00 UTC)
* XRay (3.3.1.0)
	* Add a response time histogram to the services in response of GetServiceGraph API.

### 3.3.108.0 (2017-06-15 20:42 UTC)
* EC2 (3.3.14.0)
	* Adds API to describe Amazon FPGA Images (AFIs) available to customers, which includes public AFIs, private AFIs that you own, and AFIs owned by other AWS accounts for which you have load permissions.
* ECS (3.3.5.0)
	* Added support for cpu, memory, and memory reservation container overrides on the RunTask and StartTask APIs.
* IoT (3.3.5.0)
	* Revert the last release: remove CertificatePem from DescribeCertificate API.
* ServiceCatalog (3.3.3.0)
	* Added ProvisioningArtifactSummaries to DescribeProductAsAdmin's output to show the provisioning artifacts belong to the product. Allow filtering by SourceProductId in SearchProductsAsAdmin for AWS Marketplace products. Added a verbose option to DescribeProvisioningArtifact to display the CloudFormation template used to create the provisioning artifact.Added DescribeProvisionedProduct API. Changed the type of ProvisionedProduct's Status to be distinct from Record's Status. New ProvisionedProduct's Status are AVAILABLE, UNDER_CHANGE, TAINTED, ERROR. Changed Record's Status set of values to CREATED, IN_PROGRESS, IN_PROGRESS_IN_ERROR, SUCCEEDED, FAILED.

### 3.3.107.0 (2017-06-14 20:31 UTC)
* ApplicationAutoScaling (3.3.3.0)
	* Application Auto Scaling now supports automatic scaling of read and write throughput capacity for DynamoDB tables and global secondary indexes.
* CloudDirectory (3.3.3.1)
	* Documentation update for Cloud Directory

### 3.3.106.0 (2017-06-13 19:03 UTC)
* ConfigService (3.3.7.0)
	* With this release AWS Config supports the Amazon CloudWatch alarm resource type.

### 3.3.105.0 (2017-06-13 00:46 UTC)
* RDS (3.3.12.0)
	* API Update for RDS: this update enables copy-on-write, a new Aurora MySQL Compatible Edition feature that allows users to restore their database, and support copy of TDE enabled snapshot cross region.
* S3 (3.3.7.0)
	* URL encode tagging keys and values in requests to S3 PutObject.

### 3.3.104.0 (2017-06-09 16:57 UTC)
* OpsWorks (3.3.2.0)
	* Tagging Support for AWS OpsWorks Stacks

### 3.3.103.0 (2017-06-08 20:33 UTC)
* IoT (3.3.4.0)
	* In addition to using certificate ID, AWS IoT customers can now obtain the description of a certificate with the certificate PEM.
* Pinpoint (3.3.2.0)
	* Starting today Amazon Pinpoint adds SMS Text and Email Messaging support in addition to Mobile Push Notifications, providing developers, product managers and marketers with multi-channel messaging capabilities to drive user engagement in their applications. Pinpoint also enables backend services and applications to message users directly and provides advanced user and app analytics to understand user behavior and messaging performance.
* Rekognition (3.3.5.0)
	* API Update for AmazonRekognition: Adding RecognizeCelebrities API
* S3 (3.3.6.3)
	* Updated ListVersions to populate S3ObjectVersion.Bucket property.

### 3.3.102.0 (2017-06-07 17:50 UTC)
* CodeBuild (3.3.1.0)
	* Add support to APIs for privileged containers. This change would allow performing privileged operations like starting the Docker daemon inside builds possible in custom docker images.
* Greengrass (3.3.0.0)
	* AWS Greengrass is software that lets you run local compute, messaging, and device state synchronization for connected devices in a secure way. With AWS Greengrass, connected devices can run AWS Lambda functions, keep device data in sync, and communicate with other devices securely even when not connected to the Internet. Using AWS Lambda, Greengrass ensures your IoT devices can respond quickly to local events, operate with intermittent connections, and minimize the cost of transmitting IoT data to the cloud.

### 3.3.101.0 (2017-06-06 23:10 UTC)
* CertificateManager (3.3.2.11)
	* Documentation update for AWS Certificate Manager.
* CloudFront (3.3.4.1)
	* Doc update to fix incorrect prefix in S3OriginConfig
* IoT (3.3.3.0)
	* Update client side validation for SalesForce action.
* SQS (3.3.2.4)
	* Update SQS constants for FIFO-related attributes.

### 3.3.100.0 (2017-06-05 21:17 UTC)
* AppStream (3.3.3.0)
	* AppStream 2.0 Custom Security Groups allows you to easily control what network resources your streaming instances and images have access to. You can assign up to 5 security groups per Fleet to control the inbound and outbound network access to your streaming instances to specific IP ranges, network protocols, or ports.
* IoT (3.3.2.0)
	*  Added Salesforce action to IoT Rules Engine.

### 3.3.99.0 (2017-06-02 19:32 UTC)
* KinesisAnalytics (3.3.1.0)
	* Kinesis Analytics publishes error messages CloudWatch logs in case of application misconfigurations
* S3 (3.3.6.2)
	* Updated to use new Core, version 3.3.14.1
	* Allow users to force SigV2 using S3 client config and default S3 client config to use SigV4.
* WorkDocs (3.3.1.0)
	* This release includes new APIs to manage tags and custom metadata on resources and also new APIs to add and retrieve comments at the document level.
* Core 3.3.14.1
	* Fix issue when reading profiles with duplicate keys from shared credentials file. Updated the endpoints file.

### 3.3.98.0 (2017-06-01 19:41 UTC)
* CodeDeploy (3.3.5.0)
	* AWS CodeDeploy has improved how it manages connections to GitHub accounts and repositories. You can now create and store up to 25 connections to GitHub accounts in order to associate AWS CodeDeploy applications with GitHub repositories. Each connection can support multiple repositories. You can create connections to up to 25 different GitHub accounts, or create more than one connection to a single account. The ListGitHubAccountTokenNames command has been introduced to retrieve the names of stored connections to GitHub accounts that you have created. The name of the connection to GitHub used for an AWS CodeDeploy application is also included in the ApplicationInfo structure.  Two new fields, lastAttemptedDeployment and lastSuccessfulDeployment, have been added to DeploymentGroupInfo to improve the handling of deployment group information in the AWS CodeDeploy console. Information about these latest deployments can also be retrieved using the GetDeploymentGroup and BatchGetDeployment group requests. Also includes a region update  (us-gov-west-1).
* CognitoIdentityProvider (3.3.4.0)
	* Added support within Amazon Cognito User Pools for 1) a customizable hosted UI for user sign up and sign in and 2) integration of external identity providers.
* ElasticLoadBalancingV2 (3.3.3.0)
	* Update the existing DescribeRules API to support pagination.
* LexModelBuildingService (3.3.1.1)
	* Updated documentation and added examples for Amazon Lex Runtime Service.

### 3.3.97.0 (2017-05-31 19:29 UTC)
* RDS (3.3.11.0)
	* Amazon RDS customers can now easily and quickly stop and start their DB instances.

### 3.3.96.0 (2017-05-31 00:28 UTC)
* CloudDirectory (3.3.3.0)
	* Cloud Directory has launched support for Typed Links, enabling customers to create object-to-object relationships that are not hierarchical in nature. Typed Links enable customers to quickly query for data along these relationships. Customers can also enforce referential integrity using Typed Links, ensuring data in use is not inadvertently deleted.

### 3.3.95.1 (2017-05-28 00:08 UTC)
* ApplicationDiscoveryService (3.3.2.8)
	* Doc update
* Rekognition (3.3.4.1)
	* Doc update

### 3.3.95.0 (2017-05-25 22:08 UTC)
* AppStream (3.3.2.0)
	* Support added for persistent user storage, backed by S3.
* Rekognition (3.3.4.0)
	* Updated the CompareFaces API response to include orientation information, unmatched faces, landmarks, pose, and quality of the compared faces.

### 3.3.94.0 (2017-05-24 23:55 UTC)
* DynamoDBv2 (3.3.4.13)
	* Add missing Batch operations to IDynamoDBContext
* IdentityManagement (3.3.4.0)
	* The unique ID and access key lengths were extended from 32 to 128
* SecurityToken (3.3.2.0)
	* The unique ID and access key lengths were extended from 32 to 128.
* StorageGateway (3.3.4.0)
	* Two Storage Gateway data types, Tape and TapeArchive, each have a new response element, TapeUsedInBytes. This element helps you manage your virtual tapes. By using TapeUsedInBytes, you can see the amount of data written to each virtual tape.

### 3.3.93.0 (2017-05-24 00:31 UTC)
* DatabaseMigrationService (3.3.2.0)
	* This release adds support for using Amazon S3 and Amazon DynamoDB as targets for database migration, and using MongoDB as a source for database migration. For more information, see the AWS Database Migration Service documentation.

### 3.3.92.0 (2017-05-22 23:22 UTC)
* ResourceGroupsTaggingAPI (3.3.1.0)
	* You can now specify the number of resources returned per page in GetResources operation, as an optional parameter, to easily manage the list of resources returned by your queries.

### 3.3.91.0 (2017-05-19 22:45 UTC)
* CloudFront (3.3.4.0)
	* Security update to CloudFront Cookie Signer in the SDK. The fix contains a
change to the AmazonCloudFrontCookieSigner.Protocols enum's
underlying values (a breaking change) and requires a recompilation of the
consuming application. The assembly version for AWSSDK.CloudFront.dll has been
updated for this fix. There are no other breaking API changes in this version.

### 3.3.90.0 (2017-05-18 20:37 UTC)
* Athena (3.3.0.0)
	* This release adds support for Amazon Athena. Amazon Athena is an interactive query service that makes it easy to analyze data in Amazon S3 using standard SQL. Athena is serverless, so there is no infrastructure to manage, and you pay only for the queries that you run.
* Lightsail (3.3.1.0)
	* This release adds new APIs that make it easier to set network port configurations on Lightsail instances. Developers can now make a single request to both open and close public ports on an instance using the PutInstancePublicPorts operation.

### 3.3.89.0 (2017-05-17 22:31 UTC)
* AutoScaling (3.3.0.19)
	* Various Auto Scaling documentation updates
* CloudWatchEvents (3.3.1.10)
	* Various CloudWatch Events documentation updates.
* CloudWatchLogs (3.3.2.13)
	* Various CloudWatch Logs documentation updates.
* Polly (3.3.2.0)
	* Amazon Polly adds new German voice "Vicki"

### 3.3.88.0 (2017-05-16 20:46 UTC)
* CodeDeploy (3.3.4.0)
	* This release introduces the previousRevision field in the responses to the GetDeployment and BatchGetDeployments actions. previousRevision provides information about the application revision that was deployed to the deployment group before the most recent successful deployment.  Also, the fileExistsBehavior parameter has been added for CreateDeployment action requests. In the past, if the AWS CodeDeploy agent detected files in a target location that weren't part of the application revision from the most recent successful deployment, it would fail the current deployment by default. This new parameter provides options for how the agent handles these files: fail the deployment, retain the content, or overwrite the content.
* GameLift (3.3.5.0)
	* Allow developers to specify how metrics are grouped in CloudWatch for their GameLift fleets. Developers can also specify how many concurrent game sessions activate on a per-instance basis.
* Inspector (3.3.1.0)
	* Adds ability to produce an assessment report that includes detailed and comprehensive results of a specified assessment run.
* KeyManagementService (3.3.2.12)
	* Update documentation for KMS.

### 3.3.87.0 (2017-05-15 20:48 UTC)
* SimpleSystemsManagement (3.3.4.0)
	* UpdateAssociation API now supports updating document name and targets of an association. GetAutomationExecution API can return FailureDetails as an optional field to the StepExecution Object, which contains failure type, failure stage as well as other failure related information for a failed step.

### 3.3.86.0 (2017-05-11 21:05 UTC)
* ElasticLoadBalancing (3.3.1.0)
	* Add a new API to allow customers to describe their account limits, such as load balancer limit, target group limit etc.
* ElasticLoadBalancingV2 (3.3.2.0)
	* Add a new API to allow customers to describe their account limits, such as load balancer limit, target group limit etc.
* LexModelBuildingService (3.3.1.0)
	* Releasing new DeleteBotVersion, DeleteIntentVersion and DeleteSlotTypeVersion APIs.
* Organizations (3.3.2.0)
	* AWS Organizations APIs that return an Account object now include the email address associated with the account’s root user.
* Core 3.3.14.0
	* Added AWSConfigs.ManualClockCorrection property to manually configure SDK's clock correction.
	* All services packages updated to require new Core

### 3.3.85.0 (2017-05-10 00:17 UTC)
* CognitoIdentityProvider (3.3.3.0)
	* API Update for CognitoUserPools: Group support
* CognitoSync (3.3.1.17)
	* Added developer guide references to CognitoSyncManager docs
* EC2 (3.3.13.5)
	* Added comments to EC2Metadata clarifying that the properties on this class will return null when accessed outside of EC2. Updated properties that current throw exceptions to return null instead.
* S3 (3.3.6.0)
	* Provide GetPresignedURL() function in S3 Unity

### 3.3.84.2 (2017-05-09 17:49 UTC)
* CodeStar (3.3.0.5)
	* Updated documentation for AWS CodeStar.
* WorkSpaces (3.3.0.17)
	* Doc-only Update for WorkSpaces

### 3.3.84.1 (2017-05-08 20:59 UTC)
* Core 3.3.13.4
	* Re-compute region endpoint when ClientConfig.RegionEndpoint is set to null.
Added .Net Core connection error case to the list of retry able exceptions.
Fixed IAMSecurityCredentials, BlockDeviceMapping, and NetworkInterfaces properties of EC2InstanceMetadata to return null instead of throwing NullReferenceException when accessed in non-EC2 environments.
Make HttpClientHandler.MaxConnectionsPerServer configurable for .NET Core via IClientConfig.

	* All services packages updated to require new Core

### 3.3.84.0 (2017-05-04 23:45 UTC)
* ECS (3.3.4.0)
	* Exposes container instance registration time in ECS:DescribeContainerInstances.
* Lambda (3.3.6.0)
	* Support for UpdateFunctionCode DryRun option
* MarketplaceEntitlementService (3.3.0.0)
	* AWS Marketplace Entitlement Service enables AWS Marketplace sellers to determine the capacity purchased by their customers.
* RDS (3.3.10.1)
	* Fix PreSignedUrl generation for RDS CopyDBSnapshot operation.
* Core 3.3.13.3
	* Added retries for WebExceptionStatus.SendFailure.
	* All services packages updated to require new Core
* AWSSDK.Extensions.NETCore.Setup (3.3.1)
	* Use new CredentialManagement namespace classes in AWSSDK.Extensions.NETCore.Setup.

### 3.3.83.0 (2017-04-28 21:28 UTC)
* CloudFormation (3.3.5.0)
	* API update for CloudFormation: New optional parameter ClientRequestToken which can be used as an idempotency token to safely retry certain operations as well as tagging StackEvents.
* RDS (3.3.10.0)
	* The DescribeDBClusterSnapshots API now returns a SourceDBClusterSnapshotArn field which identifies the source DB cluster snapshot of a copied snapshot.
* Rekognition (3.3.3.0)
	* Fix for missing file type check
* Snowball (3.3.2.0)
	* The Snowball API has a new exception that can be thrown for list operation requests.
* SQS (3.3.2.0)
	* Adding server-side encryption (SSE) support to SQS by integrating with AWS KMS; adding new queue attributes to SQS CreateQueue, SetQueueAttributes and GetQueueAttributes APIs to support SSE.

### 3.3.82.1 (2017-04-27 23:30 UTC)
* MobileAnalytics (3.3.1.14)
	* Log ThreadAbortException in Unity
* Core 3.3.13.2
	* Fixed a bug where loading Core assembly will result in failed endpoint file path resolution.
	* All services packages updated to require new Core

### 3.3.82.0 (2017-04-26 17:29 UTC)
* RDS (3.3.9.0)
	* With Amazon Relational Database Service (Amazon RDS) running MySQL or Amazon Aurora, you can now authenticate to your DB instance using IAM database authentication.

### 3.3.81.1 (2017-04-26 14:09 UTC)
* DynamoDBv2 (3.3.4.8)
	* Fixed xml doc errors
* S3 (3.3.5.14)
	* Fixed xml doc errors, made all unmarshallers public
* Core 3.3.13.1
	* Fixed xml doc errors

### 3.3.81.0 (2017-04-21 20:15 UTC)
* AppStream (3.3.1.0)
	* The new feature named "Default Internet Access" will enable Internet access from AppStream 2.0 instances - image builders and fleet instances. Admins will check a flag either through AWS management console for AppStream 2.0 or through API while creating an image builder or while creating/updating a fleet.
* Kinesis (3.3.2.0)
	* Adds a new waiter, StreamNotExists, to Kinesis.

### 3.3.80.0 (2017-04-21 18:02 UTC)
* CloudFront (3.3.3.2)
	* Updated to use new Core, version 3.3.13.0
	* Fix AmazonCloudFrontUrlSigner bug in Linux/Mac.
* MobileAnalytics (3.3.1.13)
	* Fix BackgroundRunner to allow smooth application shutdown, and manual abort.
* Core 3.3.13.0
	* Implement support for x-amzn-error-message header. Fix issue with S3 chunk encoding and Content-Encoding header.
	* all services packages updated to require new core

### 3.3.79.0 (2017-04-20 21:36 UTC)
* DeviceFarm (3.3.2.0)
	* API Update for AWS Device Farm: Support for Deals and Promotions 
* DirectConnect (3.3.4.3)
	* Documentation updates for AWS Direct Connect.
* KeyManagementService (3.3.2.6)
	* Doc-only update for Key Management Service (KMS): Update docs for GrantConstraints and GenerateRandom
* Route53 (3.3.5.6)
	* Release notes: SDK documentation now includes examples for ChangeResourceRecordSets for all types of resource record set, such as weighted, alias, and failover.

* Route53Domains (3.3.0.13)
	* Adding examples and other documentation updates.

### 3.3.78.0 (2017-04-19 23:02 UTC)
* APIGateway (3.3.7.0)
	* Updated to use new Core, version 3.3.12.0
	* Add support for "embed" property.
* CodeStar (3.3.0.0)
	* AWS CodeStar is a cloud-based service for creating, managing, and working with software development projects on AWS. An AWS CodeStar project creates and integrates AWS services for your project development toolchain. AWS CodeStar also manages the permissions required for project users.
* EC2 (3.3.13.0)
	* Adds support for creating an Amazon FPGA Image (AFI) from a specified design checkpoint (DCP).
* IdentityManagement (3.3.3.0)
	* This changes introduces a new IAM role type, Service Linked Role, which works like a normal role but must be managed via services' control. 
* Lambda (3.3.5.0)
	* Lambda integration with CloudDebugger service to enable customers to enable tracing for the Lambda functions and send trace information to the CloudDebugger service.
* LexModelBuildingService (3.3.0.0)
	* Amazon Lex is a service for building conversational interfaces into any application using voice and text.
* Polly (3.3.1.0)
	* Updated to use new Core, version 3.3.12.0
	* API Update for Amazon Polly: Add support for speech marks
* Rekognition (3.3.2.0)
	* Given an image, the API detects explicit or suggestive adult content in the image and returns a list of corresponding labels with confidence scores, as well as a taxonomy (parent-child relation) for each label.

### 3.3.77.0 (2017-04-19 00:42 UTC)
* Lambda (3.3.4.0)
	* You can use tags to group and filter your Lambda functions, making it easier to analyze them for billing allocation purposes. For more information, see Tagging Lambda Functions.  You can now write or upgrade your Lambda functions using Python version 3.6. For more information, see Programming Model for Authoring Lambda Functions in Python. Note: Features will be rolled out in the US regions on 4/19.
* Core 3.3.12.0
	* Added support for a list of strings in query.
	* all services packages updated to require new core

### 3.3.76.0 (2017-04-11 21:24 UTC)
* APIGateway (3.3.6.0)
	* API Gateway request validators
* Batch (3.3.2.0)
	* API Update for AWS Batch: Customer provided AMI for MANAGED Compute Environment 
* DynamoDBv2 (3.3.4.5)
	* Documentation update.
* GameLift (3.3.4.0)
	* Allows developers to utilize an improved workflow when calling our Queues API and introduces a new feature that allows developers to specify a maximum allowable latency per Queue.
* OpsWorks (3.3.1.0)
	* Cloudwatch Logs agent configuration can now be attached to OpsWorks Layers using CreateLayer and UpdateLayer. OpsWorks will then automatically install and manage the CloudWatch Logs agent on the instances part of the OpsWorks Layer.
* Core 3.3.11.0
	* Fix issue with user agent header when calling S3 CopyObject API.

### 3.3.75.0 (2017-04-07 22:20 UTC)
* Redshift (3.3.2.0)
	* This update adds the GetClusterCredentials API which is used to get temporary login credentials to the cluster. AccountWithRestoreAccess now has a new member AccountAlias, this is the identifier of the AWS support account authorized to restore the specified snapshot. This is added to support the feature where the customer can share their snapshot with the Amazon Redshift Support Account without having to manually specify the AWS Redshift Service account ID on the AWS Console/API.
* Core 3.3.10.6
	* Support side-loading endpoints.json file and fix timeout issue with AWSSDKUtils.DownloadStringContent

### 3.3.74.1 (2017-04-06 17:12 UTC)
* ElasticLoadBalancingV2 (3.3.1.5)
	* Adds supports a new condition for host-header conditions to CreateRule and ModifyRule

### 3.3.74.0 (2017-04-05 23:27 UTC)
* ElastiCache (3.3.3.0)
	* ElastiCache added support for testing the Elasticache Multi-AZ feature with Automatic Failover.
* Core 3.3.10.5
	* Documentation update for ClientConfig timeout properties.

### 3.3.73.0 (2017-04-04 17:08 UTC)
* CloudWatch (3.3.2.0)
	* Amazon Web Services announced the immediate availability of two additional alarm configuration rules for Amazon CloudWatch Alarms. The first rule is for configuring missing data treatment. Customers have the options to treat missing data as alarm threshold breached, alarm threshold not breached, maintain alarm state and the current default treatment. The second rule is for alarms based on percentiles metrics that can trigger unnecassarily if the percentile is calculated from a small number of samples. The new rule can treat percentiles with low sample counts as same as missing data. If the first rule is enabled, the same treatment will be applied when an alarm encounters a percentile with low sample counts.

### 3.3.72.0 (2017-04-03 22:03 UTC)
* Lex (3.3.1.0)
	* Updated to use new Core, version 3.3.10.4
	* Adds support to PostContent for speech input
* Core 3.3.10.4
	* Update to support Lex PostContent operation.

### 3.3.71.0 (2017-03-31 18:43 UTC)
* CloudDirectory (3.3.2.0)
	* ListObjectAttributes now supports filtering by facet.

### 3.3.70.0 (2017-03-31 04:55 UTC)
* CloudFormation (3.3.4.0)
	* Adding paginators for ListExports and ListImports
* CloudFront (3.3.3.0)
	* Amazon CloudFront now supports user configurable HTTP Read and Keep-Alive Idle Timeouts for your Custom Origin Servers
* ConfigService (3.3.6.5)
	* .
* ResourceGroupsTaggingAPI (3.3.0.0)
	* Resource Groups Tagging APIs can help you organize your resources and enable you to simplify resource management, access management, and cost allocation.
* StorageGateway (3.3.3.0)
	* File gateway mode in AWS Storage gateway provides access to objects in S3 as files on a Network File System (NFS) mount point. Once a file share is created, any changes made externally to the S3 bucket will not be reflected by the gateway. Using the cache refresh feature in this update, the customer can trigger an on-demand scan of the keys in their S3 bucket and refresh the file namespace cached on the gateway. It takes as an input the fileShare ARN and refreshes the cache for only that file share. Additionally there is new functionality on file gateway that allows you configure what squash options they would like on their file share, this allows a customer to configure their gateway to not squash root permissions. This can be done by setting options in NfsOptions for CreateNfsFileShare and UpdateNfsFileShare APIs.

### 3.3.69.1 (2017-03-30 22:31 UTC)
* Core 3.3.10.3
	* Fix issue with CredentialsFactory on non-Windows environments.
	* all services packages updated to require new core

### 3.3.69.0 (2017-03-28 21:45 UTC)
* Batch (3.3.1.0)
	* Customers can now provide a retryStrategy as part of the RegisterJobDefinition and SubmitJob API calls. The retryStrategy object has a number value for attempts. This is the number of non successful executions before a job is considered FAILED. In addition, the JobDetail object now has an attempts field and shows all execution attempts.
* EC2 (3.3.12.0)
	* Customers can now tag their Amazon EC2 Instances and Amazon EBS Volumes at the time of their creation. You can do this from the EC2 Instance launch wizard or through the RunInstances or CreateVolume APIs. By tagging resources at the time of creation, you can eliminate the need to run custom tagging scripts after resource creation. In addition, you can now set resource-level permissions on the CreateVolume, CreateTags, DeleteTags, and the RunInstances APIs. This allows you to implement stronger security policies by giving you more granular control over which users and groups have access to these APIs. You can also enforce the use of tagging and control what tag keys and values are set on your resources. When you combine tag usage and resource-level IAM policies together, you can ensure your instances and volumes are properly secured upon creation and achieve more accurate cost allocation reporting. These new features are provided at no additional cost. 

### 3.3.68.0 (2017-03-28 00:01 UTC)
* SimpleSystemsManagement (3.3.3.0)
	* Updated validation rules for SendCommand and RegisterTaskWithMaintenanceWindow APIs.

### 3.3.67.0 (2017-03-23 18:14 UTC)
* ApplicationAutoScaling (3.3.2.0)
	* Application AutoScaling is launching support for a new target resource (AppStream 2.0 Fleets) as a scalable target.
* CloudTrail (3.3.1.9)
	* Doc-only Update for CloudTrail: Add required parameters for GetEventSelectors and PutEventSelectors

### 3.3.66.0 (2017-03-22 21:50 UTC)
* ApplicationDiscoveryService (3.3.2.0)
	* Adds export configuration options to the AWS Discovery Service API.
* Lambda (3.3.3.0)
	* Adds support for new runtime Node.js v6.10 for AWS Lambda service

### 3.3.65.0 (2017-03-21 22:36 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.3.0)
	* This update adds a new data set, us_sales_and_use_tax_records, which enables AWS Marketplace sellers to programmatically access to their U.S. Sales and Use Tax report data.
* CodeBuild (3.3.0.10)
	* Documentation update for AWS CodeBuild
* DirectConnect (3.3.4.0)
	* Deprecated DescribeConnectionLoa, DescribeInterconnectLoa, AllocateConnectionOnInterconnect and DescribeConnectionsOnInterconnect operations in favor of DescribeLoa, DescribeLoa, AllocateHostedConnection and DescribeHostedConnections respectively.
* Pinpoint (3.3.1.0)
	* Amazon Pinpoint User Segmentation * Added ability to segment endpoints by user attributes in addition to endpoint attributes. Amazon Pinpoint Event Stream Preview * Added functionality to publish raw app analytics and campaign events data as events streams to Kinesis and Kinesis Firehose * The feature provides developers with increased flexibility of exporting raw events to S3, Redshift, Elasticsearch using a Kinesis Firehose stream or enable real time event processing use cases using a Kinesis stream
* Rekognition (3.3.1.4)
	* Doc only reference update for Rekognition 

### 3.3.64.2 (2017-03-16 23:15 UTC)
* Core 3.3.10.2
	* Fix issue when copying or renaming a credential profile to a profile with the same name.

### 3.3.64.1 (2017-03-15 21:58 UTC)
* Core 3.3.10.1
	* Fixed role authentication failure on ECS reported at https://github.com/aws/aws-sdk-net/issues/588.
	* all services packages updated to require new core

### 3.3.64.0 (2017-03-14 18:49 UTC)
* Core 3.3.10.0
	* Fix FallbackCredentialsFactory and FallbackRegionFactory on platforms without Windows crypto.
	* all services packages updated to require new core

### 3.3.63.0 (2017-03-14 05:25 UTC)
* CloudWatchEvents (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* This update extends Target Data Type for configuring Target behavior during invocation.
* DeviceFarm (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* Network shaping allows users to simulate network connections and conditions while testing their Android, iOS, and web apps with AWS Device Farm.
* SecurityToken (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* Changes to STS to support new assume role credentials features.
* Core 3.3.9.0
	* Support writing of AWS shared credentials file. Support assume role profiles in .NET credentials file and shared credentials file.
	* all services packages updated to require new core

### 3.3.62.0 (2017-03-10 22:50 UTC)
* ElasticMapReduce (3.3.3.0)
	* This release includes support for instance fleets.

### 3.3.61.0 (2017-03-09 22:22 UTC)
* APIGateway (3.3.5.0)
	* API Gateway has added support for ACM certificates on custom domain names. Both Amazon-issued certificates and uploaded third-part certificates are supported.
* CloudDirectory (3.3.1.0)
	* Introduces a new Cloud Directory API that enables you to retrieve all available parent paths for any type of object (a node, leaf node, policy node, and index node) in a hierarchy.

### 3.3.60.0 (2017-03-09 01:36 UTC)
* DynamoDBv2 (3.3.4.0)
	* Adding Time-to-Live support to higher-level APIs.
* Organizations (3.3.1.0)
	* Picked up the latest model updates. Note that this includes breaking changes to the service interface, client, and model shapes.
* WorkDocs (3.3.0.0)
	* Amazon WorkDocs SDK provides full administrator level access to WorkDocs site resources, allowing developers to integrate their applications to manage WorkDocs users, content and permissions programmatically.

### 3.3.59.0 (2017-03-08 01:33 UTC)
* RDS (3.3.8.0)
	* Add support to using encrypted clusters as cross-region replication masters. Update CopyDBClusterSnapshot API to support encrypted cross region copy of Aurora cluster snapshots.

### 3.3.58.0 (2017-03-07 02:39 UTC)
* Budgets (3.3.1.0)
	* API Update for Budgets: When creating or editing a budget via the AWS Budgets API you can define notifications that are sent to subscribers when the actual or forecasted value for cost or usage exceeds the notificationThreshold associated with the budget notification object. Starting today, the maximum allowed value for the notificationThreshold was raised from 100 to 300. This change was made to give you more flexibility when setting budget notifications.
* CloudTrail (3.3.1.5)
	* Doc update for CloudTrail
* EC2 (3.3.11.0)
	* Adds keys to obtain the latest Windows 2016 Core and Windows 2012R2 Core images to the Amazon.EC2.Util.ImageUtilities helper class.
* OpsWorksCM (3.3.3.0)
	* API Update for OpsWorksCM: OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.

### 3.3.57.0 (2017-02-28 04:05 UTC)
* DynamoDBv2 (3.3.3.0)
	* Time to Live (TTL) is a feature that allows you to define when items in a table expire and can be purged from the database, so that you don't have to track expired data and delete it manually. With TTL enabled on a DynamoDB table, you can set a timestamp for deletion on a per-item basis, allowing you to limit storage usage to only those records that are relevant.
* Elasticsearch (3.3.1.0)
	* Adding API's to expose limits imposed by Elasticsearch.
* IdentityManagement (3.3.2.0)
	* This release adds support for AWS Organizations service control policies (SCPs) to SimulatePrincipalPolicy operation. If there are SCPs associated with the simulated user's account, their effect on the result is captured in the OrganizationDecisionDetail element in the EvaluationResult
* MTurk (3.3.0.0)
	* Amazon Mechanical Turk is a web service that provides an on-demand, scalable, human workforce to complete jobs that humans can do better than computers, for example, recognizing objects in photos.
* Organizations (3.3.0.0)
	* AWS Organizations is a web service that enables you to consolidate your multiple AWS accounts into an organization and centrally manage your accounts and their resources.
* WAF (3.3.1.9)
	* Doc update for WAF

### 3.3.56.1 (2017-02-24 02:15 UTC)
* S3 (3.3.5.7)
	* Updated to use new Core, version 3.3.8.2
	* Pick up Core changes for decompression fix.
* Core 3.3.8.2
	* Disable .NET Core version of SDK automatically decompressing streams.

### 3.3.56.0 (2017-02-23 20:54 UTC)
* CognitoSync (3.3.1.7)
	* Fixed dependencies for UWP target framework, https://github.com/aws/aws-sdk-net/issues/550 .
* EC2 (3.3.10.0)
	* New EC2 I3 instance type.
* MobileAnalytics (3.3.1.7)
	* Fixed dependencies for UWP target framework, https://github.com/aws/aws-sdk-net/issues/550 .

### 3.3.55.0 (2017-02-22 21:16 UTC)
* CloudDirectory (3.3.0.2)
	* ListObjectAttributes documentation updated based on forum feedback
* ElasticBeanstalk (3.3.4.0)
	* Elastic Beanstalk adds support for creating and managing custom platform.
* GameLift (3.3.3.0)
	* Allow developers to configure global queues for creating GameSessions. Allow PlayerData on PlayerSessions to store player-specific data.
* Route53 (3.3.5.0)
	* Added support for operations CreateVPCAssociationAuthorization and DeleteVPCAssociationAuthorization to throw a ConcurrentModification error when a conflicting modification occurs in parallel to the authorizations in place for a given hosted zone.

### 3.3.54.0 (2017-02-21 23:35 UTC)
* EC2 (3.3.9.0)
	* Added the BillingProduct parameter to the RegisterImage API.
* S3 (3.3.5.6)
	* Fixed issue with TransferUtility directory operations while using AmazonS3EncryptionClient.

### 3.3.53.0 (2017-02-17 19:48 UTC)
* DirectConnect (3.3.3.0)
	* This update will introduce the ability for Direct Connect customers to take advantage of Link Aggregation (LAG). This allows you to bundle many individual physical interfaces into a single logical interface, referred to as a LAG. This makes administration much simpler as the majority of configuration is done on the LAG while you are free to add or remove physical interfaces from the bundle as bandwidth demand increases or decreases. A concrete example of the simplification added by LAG is that customers need only a single BGP session as opposed to one session per physical connection.

### 3.3.52.0 (2017-02-17 02:26 UTC)
* CognitoIdentity (3.3.2.0)
	* Allow createIdentityPool and updateIdentityPool API to set server side token check value on identity pool
* ConfigService (3.3.6.0)
	* AWS Config now supports a new test mode for the PutEvaluations API. Set the TestMode parameter to true in your custom rule to verify whether your AWS Lambda function will deliver evaluation results to AWS Config. No updates occur to your existing evaluations, and evaluation results are not sent to AWS Config.
* S3 (3.3.5.5)
	* Fixed bug in TransferUtility.UploadDirectory

### 3.3.51.0 (2017-02-15 17:28 UTC)
* KeyManagementService (3.3.2.0)
	* Added tagging support

### 3.3.50.0 (2017-02-14 22:45 UTC)
* EC2 (3.3.8.0)
	* Adds support for the new Modify Volumes apis
* AWSSDK.Extensions.NETCore.Setup (3.3.0.3)
	* Added ability to explicit set AWSCredentials object on the AWSOptions

### 3.3.49.0 (2017-02-10 18:21 UTC)
* StorageGateway (3.3.2.0)
	* File gateway mode in AWS Storage gateway provides access to objects in S3 as files on a Network File System (NFS) mount point. This is done by creating Nfs file shares using existing APIs CreateNfsFileShare. Using the feature in this update, the customer can restrict the clients that have read/write access to the gateway by specifying the list of clients as a list of IP addresses or CIDR blocks. This list can be specified using the API CreateNfsFileShare while creating new file shares, or UpdateNfsFileShare while update existing file shares. To find out the list of clients that have access, the existing API DescribeNfsFileShare will now output the list of clients that have access.

### 3.3.48.0 (2017-02-10 04:29 UTC)
* OpsWorksCM (3.3.2.0)
	* Revert: OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.

### 3.3.47.0 (2017-02-09 07:39 UTC)
* EC2 (3.3.7.0)
	* This feature allows customers to associate an IAM profile to running instances that do not have any.
* OpsWorksCM (3.3.1.0)
	* OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.
* Rekognition (3.3.1.0)
	* DetectFaces and IndexFaces operations now return an estimate of the age of the face as an age range.

### 3.3.46.0 (2017-02-08 01:11 UTC)
* Lex (3.3.0.0)
	* Amazon Lex is a service for building conversational interactions into any application using voice or text.

### 3.3.45.1 (2017-02-06 22:49 UTC)
* CloudDirectory (3.3.0.1)
	* Updated to use new Core, version 3.3.8.1
	* Fix unmarshalling issue.
* Lightsail (3.3.0.6)
	* Updated to use new Core, version 3.3.8.1
	* Fixed issue with incorrect exceptions being thrown for Lightsail errors.
* S3 (3.3.5.4)
	* Fix issue with V4ClientSection not having a zero-parameter constructor, https://github.com/aws/aws-sdk-net/issues/538
* Core 3.3.8.1
	* Extension to saml role profile to allow a region override, to determine STS endpoint setting, to be stored and loaded from the profile and used when constructing the STS client in regions where a specific regional endpoint must be used. Fix issue unmarshalling null MemoryStream from JSON response. Fix issue with V4ClientSection not having a zero-parameter constructor, https://github.com/aws/aws-sdk-net/issues/538

### 3.3.45.0 (2017-01-26 23:49 UTC)
* CloudDirectory (3.3.0.0)
	* New service CloudDirectory: Amazon Cloud Directory is a highly scalable, high performance, multi-tenant directory service in the cloud. Its web-based directories make it easy for you to organize and manage application resources such as users, groups, locations, devices, policies, and the rich relationships between them.
* CodeDeploy (3.3.3.0)
	* API Update for CodeDeploy: This release of AWS CodeDeploy introduces support for blue/green deployments. In a blue/green deployment, the current set of instances in a deployment group is replaced by new instances that have the latest application revision installed on them. After traffic is rerouted behind a load balancer to the replacement instances, the original instances can be terminated automatically or kept running for other uses.
* EC2 (3.3.6.0)
	* API Update for EC2: Adds instance health check functionality to replace unhealthy EC2 Spot fleet instances with fresh ones.
* RDS (3.3.7.0)
	* API Update for RDS: Snapshot Engine Version Upgrade

### 3.3.44.0 (2017-01-25 23:00 UTC)
* ElasticLoadBalancingV2 (3.3.1.0)
	* Application Load Balancers now support native Internet Protocol version 6 (IPv6) in an Amazon Virtual Private Cloud (VPC). With this ability, clients can now connect to the Application Load Balancer in a dual-stack mode via either IPv4 or IPv6.
* RDS (3.3.6.0)
	* API Update for RDS : cross Region Read Replica Copying via CreateDBInstanceReadReplica operation

### 3.3.43.0 (2017-01-24 22:15 UTC)
* CodeBuild (3.3.0.6)
	* Doc update.
* CodeCommit (3.3.1.0)
	* AWS CodeCommit now includes the option to view the differences between a commit and its parent commit from within the console. You can view the differences inline (Unified view) or side by side (Split view). To view information about the differences between a commit and something other than its parent, you can use the AWS CLI and the get-differences and get-blob commands, or you can use the GetDifferences and GetBlob APIs.
* ECS (3.3.3.0)
	* Amazon ECS now supports a state for container instances that can be used to drain a container instance in preparation for maintenance or cluster scale down.

### 3.3.42.0 (2017-01-20 18:18 UTC)
* AWSHealth (3.3.0.5)
	* Update for AWS Health: Pick up updated documentation
* CertificateManager (3.3.2.0)
	* Update for AWS Certificate Manager: Updated response elements for DescribeCertificate API in support of managed renewal
* Core 3.3.8.0
	* fixed uap packages incorrectly referencing binaries in the pcl directories instead of windows8
	* all services packages updated to require new core

### 3.3.41.0 (2017-01-19 19:23 UTC)
* EC2 (3.3.5.0)
	* Amazon EC2 Spot instances now support dedicated tenancy, providing the ability to run Spot instances single-tenant manner on physically isolated hardware within a VPC to satisfy security, privacy, or other compliance requirements. Dedicated Spot instances can be requested using RequestSpotInstances and RequestSpotFleet.

### 3.3.40.0 (2017-01-18 20:32 UTC)
* RDS (3.3.5.0)
	* We are releasing Mysql to Aurora replication feature, in rds-describe-db-instances output field, we will need to add a new field called ReadReplicaDBClusterIdentifiers.

### 3.3.39.0 (2017-01-18 02:15 UTC)
* DynamoDBv2 (3.3.2.0)
	* Tagging Support for Amazon DynamoDB Tables and Indexes
* Glacier (3.3.1.4)
	* Doc-only Update for Glacier: Added code snippets
* Polly (3.3.0.5)
	* Doc-only update for Amazon Polly -- added snippets
* Rekognition (3.3.0.5)
	* Added code samples to Rekognition reference topics.
* Route53 (3.3.4.0)
	* Add ca-central-1 and eu-west-2 enum values to CloudWatchRegion enum

### 3.3.38.0 (2017-01-17 05:37 UTC)
* ConfigService (3.3.5.0)
	* Recently we added next token implementation to some of our APIs mentioned in the title. As part of that launch we added InvalidNextTokenException to those APIs but forgot to update the model for the APIs. This item is to update the models to include InvalidNextTokenException in API response.
* CostAndUsageReport (3.3.0.0)
	* The AWS Cost and Usage Report Service API allows you to enable and disable the Cost & Usage report, as well as modify the report name, the data granularity, and the delivery preferences.
* DynamoDBv2 (3.3.1.6)
	* Snippets for the DynamoDB API.
* ElastiCache (3.3.2.4)
	* Adds new code examples.

### 3.3.37.1 (2017-01-12 23:02 UTC)
* EC2 (3.3.4.5)
	* Extended EC2 image utilities class with keys to obtain Windows Server 2012R2 images with SQL Server 2016 variants (web/express/standard).

### 3.3.37.0 (2017-01-04 23:41 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.2.0)
	* Added support for data set disbursed_amount_by_instance_hours, with historical data available starting 2012-09-04. New data is published to this data set every 30 days.
* ConfigService (3.3.4.0)
	* Added support for OversizedConfigurationItemChangeNotification message type in putConfigRule. Customers can use/write rules based on OversizedConfigurationItemChangeNotification mesage type.
* DynamoDBv2 (3.3.1.5)
	* Documentation update
* ElasticFileSystem (3.3.0.8)
	* Documentation update.
* IdentityManagement (3.3.1.2)
	* Documentation update
* Lambda (3.3.2.5)
	* Documentation update
* RDS (3.3.4.2)
	* Documentation update
* Rekognition (3.3.0.4)
	* Documentation update

