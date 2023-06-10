### 3.3.434.0 (2018-12-21 22:22 UTC)
* ACMPCA (3.3.2.0)
	* This release marks the introduction of waiters in ACM PCA, which allow you to control the progression of your code based on the presence or state of certain resources. Waiters can be implemented in the DescribeCertificateAuthorityAuditReport, GetCertificate, and GetCertificateAuthorityCsr API operations.
* DynamoDBv2 (3.3.16.0)
	* Added provisionedThroughPut exception on the request level for transaction APIs.
* PinpointSMSVoice (3.3.1.0)
	* Configuration sets can now use Amazon SNS as an event destination.
* StepFunctions (3.3.4.0)
	* This release adds support for cost allocation tagging. You can now create, delete, and list tags for AWS Step Functions activity and state machine resources. For more information about tagging, see AWS Tagging Strategies.
* Core 3.3.30.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.433.1 (2018-12-21 09:12 UTC)
* Core 3.3.30.1
	* Fix Regex for matching profile names in the ~/.aws/config file. Fixes bug where partial profile name would match a profile in the ~/.aws/config file.


### 3.3.433.0 (2018-12-21 05:51 UTC)
* Core 3.3.30.0
	* Added support for endpoint discovery.
	* All services packages updated to require new Core

### 3.3.432.0 (2018-12-21 01:24 UTC)
* CognitoIdentityProvider (3.3.12.0)
	* Amazon Cognito now has API support for updating the Secure Sockets Layer (SSL) certificate for the custom domain for your user pool.
* Comprehend (3.3.6.0)
	* This SDK release adds functionality to stop training Custom Document Classifier or Custom Entity Recognizer in Amazon Comprehend.
* KinesisFirehose (3.3.8.0)
	* Support for specifying customized s3 keys and supplying a separate prefix for failed-records
* MediaLive (3.3.14.0)
	* This release provides support for ID3 tags and video quality setting for subgop_length.
* TranscribeService (3.3.7.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Italian (it-IT).

### 3.3.431.0 (2018-12-19 22:44 UTC)
* EC2 (3.3.78.0)
	* This release adds support for specifying partition as a strategy for EC2 Placement Groups. This new strategy allows one to launch instances into partitions that do not share certain underlying hardware between partitions, to assist with building and deploying highly available replicated applications. 
* SageMaker (3.3.18.0)
	* Batch Transform Jobs now supports TFRecord as a Split Type. ListCompilationJobs API action now supports SortOrder and SortBy inputs.
* WAF (3.3.7.0)
	* This release adds rule-level control for rule group. If a rule group contains a rule that blocks legitimate traffic, previously you had to override the entire rule group to COUNT in order to allow the traffic. You can now use the UpdateWebACL API to exclude specific rules within a rule group. Excluding rules changes the action for the individual rules to COUNT. Excluded rules will be recorded in the new "excludedRules" attribute of the WAF logs.
* WAFRegional (3.3.7.0)
	* This release adds rule-level control for rule group. If a rule group contains a rule that blocks legitimate traffic, previously you had to override the entire rule group to COUNT in order to allow the traffic. You can now use the UpdateWebACL API to exclude specific rules within a rule group. Excluding rules changes the action for the individual rules to COUNT. Excluded rules will be recorded in the new "excludedRules" attribute of the WAF logs.

### 3.3.430.0 (2018-12-18 23:00 UTC)
* ApiGatewayManagementApi (3.3.0.0)
	* This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.
* ApiGatewayV2 (3.3.0.0)
	* This is the initial SDK release for the Amazon API Gateway v2 APIs. This SDK will allow you to manage and configure APIs in Amazon API Gateway; this first release provides the capabilities that allow you to programmatically setup and manage WebSocket APIs end to end. 
* EC2 (3.3.77.0)
	* Client VPN, is a client-based VPN service. With Client VPN, you can securely access resources in AWS as well as access resources in on-premises from any location using OpenVPN based devices. With Client VPN, you can set network based firewall rules that can restrict access to networks based on Active Directory groups.
* ElasticBeanstalk (3.3.12.0)
	* This release adds a new resource that Elastic Beanstalk will soon support, EC2 launch template, to environment resource descriptions.
* GlobalAccelerator (3.3.0.5)
	* Documentation updates for Ubiquity

### 3.3.429.0 (2018-12-17 23:00 UTC)
* ECR (3.3.4.0)
	* This release adds support for ECR repository tagging.
* QuickSight (3.3.1.0)
	* Amazon QuickSight's RegisterUser API now generates a user invitation URL when registering a user with the QuickSight identity type. This URL can then be used by the registered QuickSight user to complete the user registration process. This release also corrects some HTTP return status codes.

### 3.3.428.0 (2018-12-14 22:51 UTC)
* AlexaForBusiness (3.3.8.0)
	* Released new APIs for managing private skill access to Enrolled Users.  These API's are the equivalent of the A4B console for Private Skills checkbox "Available for Users".
* CloudFormation (3.3.13.4)
	* Documentation updates for cloudformation
* Redshift (3.3.11.6)
	* Documentation updates for Amazon Redshift
* Core 3.3.29.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.427.0 (2018-12-13 22:22 UTC)
* Organizations (3.3.9.22)
	* Documentation updates for AWS Organizations
* PinpointEmail (3.3.1.0)
	* This release adds new operations for the Amazon Pinpoint Deliverability Dashboard. You can use the Deliverability Dashboard to view response and inbox placement metrics for the domains that you use to send email. You can also perform tests on individual email messages to determine how often your messages are delivered to the inbox on several major email providers.
* Core 3.3.29.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.426.0 (2018-12-12 22:38 UTC)
* EKS (3.3.3.0)
	* Added support for updating kubernetes version of Amazon EKS clusters.
* Glue (3.3.16.0)
	* API Update for Glue: this update enables encryption of password inside connection objects stored in AWS Glue Data Catalog using DataCatalogEncryptionSettings.  In addition, a new "HidePassword" flag is added to GetConnection and GetConnections to return connections without passwords.
* Route53 (3.3.18.0)
	* You can now specify a new region, eu-north-1 (in Stockholm, Sweden), as a region for latency-based or geoproximity routing.
* SageMaker (3.3.17.0)
	* Amazon SageMaker Automatic Model Tuning now supports early stopping of training jobs. With early stopping, training jobs that are unlikely to generate good models will be automatically stopped during a Hyperparameter Tuning Job.

### 3.3.425.0 (2018-12-11 23:12 UTC)
* Connect (3.3.4.0)
	* This update adds the GetContactAttributes operation to retrieve the attributes associated with a contact.
* ECS (3.3.21.2)
	* Documentation updates for Amazon ECS.
* MediaStore (3.3.2.0)
	* This release adds Delete Object Lifecycling to AWS MediaStore Containers.
* Core 3.3.29.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.424.0 (2018-12-07 19:57 UTC)
* AlexaForBusiness (3.3.7.0)
	* Alexa for Business now allows IT administrators to create ad-hoc or scheduled usage reports, which help customers understand how Alexa is used in their workplace. To learn how to create usage reports, see https://docs.aws.amazon.com/a4b/latest/ag/creating-reports.html
* EC2 (3.3.76.0)
	* You can now launch the larger-sized P3dn.24xlarge instance that features NVIDIA Tesla V100s with double the GPU memory, 100Gbps networking and local NVMe storage.
* IdentityManagement (3.3.9.0)
	* We are making it easier for you to manage your AWS Identity and Access Management (IAM) policy permissions by enabling you to retrieve the last timestamp when an IAM entity (e.g., user, role, or a group) accessed an AWS service. This feature also allows you to audit service access for your entities.
* ServiceCatalog (3.3.13.4)
	* Documentation updates for servicecatalog.

### 3.3.423.0 (2018-12-06 20:15 UTC)
* CodeBuild (3.3.19.0)
	* Support personal access tokens for GitHub source and app passwords for Bitbucket source
* ElasticLoadBalancingV2 (3.3.12.0)
	* This release allows Application Load Balancers to route traffic to Lambda functions, in addition to instances and IP addresses.
* MediaLive (3.3.13.0)
	* This release enables the AWS Elemental MediaConnect input type in AWS Elemental MediaLive. This can then be used to automatically create and manage AWS Elemental MediaConnect Flow Outputs when you create a channel using those inputs.
* RDS (3.3.37.2)
	* Documentation updates for Amazon RDS

### 3.3.422.0 (2018-12-05 21:23 UTC)
* CostExplorer (3.3.9.0)
	* Add normalized unit support for both GetReservationUtilization and GetReservationCoverage API.
* MediaTailor (3.3.3.0)
	* AWS Elemental MediaTailor SDK now includes a new parameter to control the Location tag of DASH manifests.
* MQ (3.3.3.0)
	* This release adds support for cost allocation tagging. You can now create, delete, and list tags for AmazonMQ resources. For more information about tagging, see AWS Tagging Strategies.

### 3.3.421.0 (2018-12-04 20:24 UTC)
* AWSHealth (3.3.2.0)
	* AWS Health API DescribeAffectedEntities operation now includes a field that returns the URL of the affected entity.
* S3 (3.3.31.0)
	* S3 Inventory reports can now be generated in Parquet format by setting the Destination Format to be 'Parquet'.

### 3.3.420.0 (2018-12-04 01:45 UTC)
* DeviceFarm (3.3.11.0)
	* Customers can now schedule runs without a need to create a Device Pool. They also get realtime information on public device availability.
* MediaConvert (3.3.10.1)
	* Documentation updates for mediaconvert
* ServiceCatalog (3.3.13.3)
	* Documentation updates for servicecatalog
* StorageGateway (3.3.12.0)
	* API list-local-disks returns a list of the gateway's local disks. This release adds a field DiskAttributeList to these disks.
* Core 3.3.29.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.419.0 (2018-11-29 18:35 UTC)
* CloudWatchEvents (3.3.8.0)
	* Support for Managed Rules (rules that are created and maintained by the AWS services in your account) is added.
* ElasticLoadBalancingV2 (3.3.11.0)
	* This release allows Application Load Balancers to route traffic to Lambda functions, in addition to instances and IP addresses.
* Kafka (3.3.0.0)
	* This is the initial SDK release for Amazon Managed Streaming for Kafka (Amazon MSK). Amazon MSK is a service that you can use to easily build, monitor, and manage Apache Kafka clusters in the cloud.
* Lambda (3.3.19.0)
	* AWS Lambda now supports Lambda Layers and Ruby as a runtime. Lambda Layers are a new type of artifact that contains arbitrary code and data, and may be referenced by zero, one, or more functions at the same time.  You can also now develop your AWS Lambda function code using the Ruby programming language.
* S3 (3.3.30.0)
	* Fixed issue with ObjectLockRetainUntilDate in S3 PutObject
* ServerlessApplicationRepository (3.3.4.0)
	* AWS Serverless Application Repository now supports nested applications. You can nest individual applications as components of a larger application to make it easy to assemble and deploy new serverless architectures. 
* StepFunctions (3.3.3.0)
	* AWS Step Functions is now integrated with eight additional AWS services: Amazon ECS, AWS Fargate, Amazon DynamoDB, Amazon SNS, Amazon SQS, AWS Batch, AWS Glue, and Amazon SageMaker. To learn more, please see https://docs.aws.amazon.com/step-functions/index.html
* XRay (3.3.5.0)
	* GetTraceSummaries - Now provides additional information regarding your application traces such as Availability Zone, Instance ID, Resource ARN details, Revision, Entry Point, Root Cause Exceptions and Root Causes for Fault, Error and Response Time.

### 3.3.418.0 (2018-11-29 01:09 UTC)
* AppMesh (3.3.0.0)
	* AWS App Mesh is a service mesh that makes it easy to monitor and control communications between microservices of an application. AWS App Mesh APIs are available for preview in eu-west-1, us-east-1, us-east-2, and us-west-2 regions.
* EC2 (3.3.75.0)
	* Adds the following updates: 1. You can now hibernate and resume Amazon-EBS backed instances using the StopInstances and StartInstances APIs. For more information about using this feature and supported instance types and operating systems, visit the user guide. 2. Amazon Elastic Inference accelerators are resources that you can attach to current generation EC2 instances to accelerate your deep learning inference workloads. With Amazon Elastic Inference, you can configure the right amount of inference acceleration to your deep learning application without being constrained by fixed hardware configurations and limited GPU selection. 3. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM.
* LicenseManager (3.3.0.0)
	* AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.
* Lightsail (3.3.8.0)
	* This update adds the following features: 1. Copy instance and disk snapshots within the same AWS Region or from one region to another in Amazon Lightsail. 2. Export Lightsail instance and disk snapshots to Amazon Elastic Compute Cloud (Amazon EC2). 3. Create an Amazon EC2 instance from an exported Lightsail instance snapshot using AWS CloudFormation stacks. 4. Apply tags to filter your Lightsail resources, or organize your costs, or control access.
* SageMaker (3.3.16.0)
	* Amazon SageMaker now has Algorithm and Model Package entities that can be used to create Training Jobs, Hyperparameter Tuning Jobs and hosted Models. Subscribed Marketplace products can be used on SageMaker to create Training Jobs, Hyperparameter Tuning Jobs and Models. Notebook Instances and Endpoints can leverage Elastic Inference accelerator types for on-demand GPU computing. Model optimizations can be performed with Compilation Jobs. Labeling Jobs can be created and supported by a Workforce. Models can now contain up to 5 containers allowing for inference pipelines within Endpoints. Code Repositories (such as Git) can be linked with SageMaker and loaded into Notebook Instances. Network isolation is now possible on Models, Training Jobs, and Hyperparameter Tuning Jobs, which restricts inbound/outbound network calls for the container. However, containers can talk to their peers in distributed training mode within the same security group. A Public Beta Search API was added that currently supports Training Jobs.
* ServiceDiscovery (3.3.3.0)
	* AWS Cloud Map lets you define friendly names for your cloud resources so that your applications can quickly and dynamically discover them. When a resource becomes available (for example, an Amazon EC2 instance running a web server), you can register a Cloud Map service instance. Then your application can discover service instances by submitting DNS queries or API calls.

### 3.3.417.0 (2018-11-28 19:06 UTC)
* DynamoDBv2 (3.3.15.0)
	* Amazon DynamoDB now supports the following features: DynamoDB on-demand and transactions. DynamoDB on-demand is a flexible new billing option for DynamoDB capable of serving thousands of requests per second without capacity planning. DynamoDB on-demand offers simple pay-per-request pricing for read and write requests so that you only pay for what you use, making it easy to balance costs and performance. Transactions simplify the developer experience of making coordinated, all-or-nothing changes to multiple items both within and across tables. The new transactional APIs provide atomicity, consistency, isolation, and durability (ACID) in DynamoDB, helping developers support sophisticated workflows and business logic that requires adding, updating, or deleting multiple items using native, server-side transactions. For more information, see the Amazon DynamoDB Developer Guide.
* FSx (3.3.0.0)
	* Amazon FSx provides fully-managed third-party file systems optimized for a variety of enterprise and compute-intensive workloads.
* RDS (3.3.37.0)
	* Amazon Aurora Global Database. This release introduces support for Global Database, a feature that allows a single Amazon Aurora database to span multiple AWS regions. Customers can use the feature to replicate data with no impact on database performance, enable fast local reads with low latency in each region, and improve disaster recovery from region-wide outages. You can create, modify and describe an Aurora Global Database, as well as add or remove regions from your Global Database.
* SecurityHub (3.3.0.0)
	* AWS Security Hub is a security and compliance center that correlates AWS security findings and performs automated compliance checks

### 3.3.416.0 (2018-11-28 00:42 UTC)
* AWSMarketplaceMetering (3.3.2.0)
	* RegisterUsage operation added to AWS Marketplace Metering Service, allowing sellers to meter and entitle Docker container software use with AWS Marketplace. For details on integrating Docker containers with RegisterUsage see: https://docs.aws.amazon.com/marketplace/latest/userguide/entitlement-and-metering-for-paid-products.html
* CloudWatchLogs (3.3.7.0)
	* Six new APIs added to support CloudWatch Logs Insights. The APIs are StartQuery, StopQuery, GetQueryResults, GetLogRecord, GetLogGroupFields, and DescribeQueries.
* CodeDeploy (3.3.12.0)
	* Support for Amazon ECS service deployment - AWS CodeDeploy now supports the deployment of Amazon ECS services. An Amazon ECS deployment uses an Elastic Load Balancer, two Amazon ECS target groups, and a listener to reroute production traffic from your Amazon ECS service's original task set to a new replacement task set. The original task set is terminated when the deployment is complete. Success of a deployment can be validated using Lambda functions that are referenced by the deployment. This provides the opportunity to rollback if necessary. You can use the new ECSService, ECSTarget, and ECSTaskSet data types in the updated SDK to create or retrieve an Amazon ECS deployment.
* ComprehendMedical (3.3.0.0)
	* The first release of Comprehend Medical includes two APIs, detectPHI and detectEntities. DetectPHI extracts PHI from your clinical text, and detectEntities extracts entities such as medication, medical conditions, or anatomy. DetectEntities also extracts attributes (e.g. dosage for medication) and identifies contextual traits (e.g. negation) for each entity.
* EC2 (3.3.74.0)
	* With VPC sharing, you can now allow multiple accounts in the same AWS Organization to launch their application resources, like EC2 instances, RDS databases, and Redshift clusters into shared, centrally managed VPCs.
* ECS (3.3.21.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for blue/green deployment feature. Customers can now update their ECS services in a blue/green deployment pattern via using AWS CodeDeploy.
* KinesisAnalytics (3.3.5.0)
	* Improvements to error messages, validations, and more to the Kinesis Data Analytics APIs.
* KinesisAnalyticsV2 (3.3.0.0)
	* Amazon Kinesis Data Analytics now supports Java-based stream processing applications, in addition to the previously supported SQL. Now, you can use your own Java code in Amazon Kinesis Data Analytics to build and run stream processing applications. This new capability also comes with an update to the previous Amazon Kinesis Data Analytics APIs to enable support for different runtime environments and more.
* MediaConnect (3.3.0.0)
	* This is the initial release for AWS Elemental MediaConnect, an ingest and transport service for live video. This new AWS service allows broadcasters and content owners to send high-value live content into the cloud, securely transmit it to partners for distribution, and replicate it to multiple destinations around the globe.
* Translate (3.3.2.0)
	* This release includes the new custom terminology feature. Using custom terminology with your translation requests enables you to make sure that your brand names, character names, model names, and other unique content is translated exactly the way you need it, regardless of its context and the Amazon Translate algorithm's decision. See the documentation for more information.

### 3.3.415.0 (2018-11-27 05:11 UTC)
* EC2 (3.3.73.0)
	* Adds the following updates: 1. Transit Gateway helps easily scale connectivity across thousands of Amazon VPCs, AWS accounts, and on-premises networks. 2. Amazon EC2 A1 instance is a new Arm architecture based general purpose instance. 3. You can now launch the new Amazon EC2 compute optimized C5n instances that can utilize up to 100 Gbps of network bandwidth.
* GlobalAccelerator (3.3.0.0)
	* AWS Global Accelerator is a network layer service that helps you improve the availability and performance of the applications that you offer to your global customers. Global Accelerator uses the AWS global network to direct internet traffic from your users to your applications running in AWS Regions. Global Accelerator creates a fixed entry point for your applications through static anycast IP addresses, and routes user traffic to the optimal endpoint based on performance, application health and routing policies that you can configure. Global Accelerator supports the following features at launch: static anycast IP addresses, support for TCP and UDP, support for Network Load Balancers, Application Load Balancers and Elastic-IP address endpoints,  continuous health checking, instant regional failover, fault isolating Network Zones, granular traffic controls, and client affinity.
* Greengrass (3.3.5.0)
	* Support Greengrass Connectors and allow Lambda functions to run without Greengrass containers.
* IoT (3.3.22.0)
	* As part of this release, we are extending capability of AWS IoT Rules Engine to support IoT Events rule action. The IoT Events rule action lets you send messages from IoT sensors and applications to IoT Events for pattern recognition and event detection.
* IoTAnalytics (3.3.6.0)
	* Added an optional list of dataset content delivery configuration for CreateDataset and UpdateDataset. DescribeDataset will now include the list of delivery configuration, and will be an empty array if none exist.
* KeyManagementService (3.3.7.0)
	* AWS Key Management Service (KMS) now enables customers to create and manage dedicated, single-tenant key stores in addition to the default KMS key store. These are known as custom key stores and are deployed using AWS CloudHSM clusters. Keys that are created in a KMS custom key store can be used like any other customer master key in KMS.
* S3 (3.3.29.0)
	* Four new Amazon S3 Glacier features help you reduce your storage costs by making it even easier to build archival applications using the Amazon S3 Glacier storage class. S3 Object Lock enables customers to apply Write Once Read Many (WORM) protection to objects in S3 in order to prevent object deletion for a customer-defined retention period. S3 Inventory now supports fields for reporting on S3 Object Lock. "ObjectLockRetainUntilDate", "ObjectLockMode", and "ObjectLockLegalHoldStatus" are now available as valid optional fields.
* ServerMigrationService (3.3.1.0)
	* In this release, AWS Server Migration Service (SMS) has added multi-server migration support to simplify the application migration process. Customers can migrate all their application-specific servers together as a single unit as opposed to moving individual server one at a time. The new functionality includes - 1. Ability to group on-premises servers into applications and application tiers. 2. Auto-generated CloudFormation Template and Stacks for launching migrated servers into EC2. 3. Ability to run post-launch configuration scripts to configure servers and applications in EC2. In order for SMS to launch servers into your AWS account using CloudFormation Templates, we have also updated the ServerMigrationServiceRole IAM policy to include appropriate permissions. Refer to Server Migration Service documentation for more details. 

### 3.3.414.0 (2018-11-26 08:55 UTC)
* Amplify (3.3.0.0)
	* Release of AWS Amplify: Everything you need to develop & deploy cloud-powered mobile and web apps.
* DataSync (3.3.0.0)
	* AWS DataSync simplifies, automates, and accelerates moving and replicating data between on-premises storage and AWS services over the network.
* RoboMaker (3.3.0.0)
	* (New Service) AWS RoboMaker is a service that makes it easy to develop, simulate, and deploy intelligent robotics applications at scale. 
* S3 (3.3.28.0)
	* The INTELLIGENT_TIERING storage class is designed to optimize storage costs by automatically moving data to the most cost effective storage access tier, without performance impact or operational overhead. This SDK release provides API support for this new storage class.
* Snowball (3.3.5.0)
	* AWS announces the availability of AWS Snowball Edge Compute Optimized to run compute-intensive applications is disconnected and physically harsh environments. It comes with 52 vCPUs, 208GB memory, 8TB NVMe SSD, and 42TB S3-compatible storage to accelerate local processing and is well suited for use cases such as full motion video processing, deep IoT analytics, and continuous machine learning in bandwidth-constrained locations. It features new instances types called SBE-C instances that are available in eight sizes and multiple instances can be run on the device at the same time. Optionally, developers can choose the compute optimized device to include a GPU and use SBE-G instances for accelerating their application performance. 
* Transfer (3.3.0.0)
	* AWS Transfer for SFTP is a fully managed service that enables transfer of secure data over the internet into and out of Amazon S3. SFTP is deeply embedded in data exchange workflows across different industries such as financial services, healthcare, advertising, and retail, among others.

### 3.3.413.0 (2018-11-21 19:23 UTC)
* Rekognition (3.3.13.0)
	* This release updates the DetectFaces and IndexFaces operation. When the Attributes input parameter is set to ALL, the face location landmarks includes 5 new landmarks: upperJawlineLeft, midJawlineLeft, chinBottom, midJawlineRight, upperJawlineRight.

### 3.3.412.0 (2018-11-20 22:08 UTC)
* AppSync (3.3.4.0)
	* AWS AppSync now supports: 1. Pipeline Resolvers - Enables execution of one or more operations against multiple data sources in order, on a single GraphQL field. This allows orchestration of actions by composing code into a single Resolver, or share code across Resolvers.  2. Aurora Serverless Data Source - Built-in resolver for executing GraphQL operations with the new Aurora Serverless Data API, including connection management functionality.
* AutoScalingPlans (3.3.2.0)
	* In this release, AWS Auto Scaling adds three features: 1) Predictive scaling for EC2 Auto Scaling, which analyzes your application workload history to forecast future capacity requirements, 2) an option to replace existing scaling policies that are associated with the resources in your scaling plan, and 3) an option that allows you to use predictive scaling with or without your plan's dynamic scaling feature.
* CloudFront (3.3.11.0)
	* With Origin Failover capability in CloudFront, you can setup two origins for your distributions - primary and secondary, such that your content is served from your secondary origin if CloudFront detects that your primary origin is unavailable. These origins can be any combination of AWS origins or non-AWS custom HTTP origins. For example, you can have two Amazon S3 buckets that serve as your origin that you independently upload your content to. If an object that CloudFront requests from your primary bucket is not present or if connection to your primary bucket times-out, CloudFront will request the object from your secondary bucket. So, you can configure CloudFront to trigger a failover in response to either HTTP 4xx or 5xx status codes.
* CloudWatch (3.3.10.0)
	* Amazon CloudWatch now supports alarms on metric math expressions.
* DeviceFarm (3.3.10.0)
	* Disabling device filters
* MediaLive (3.3.12.0)
	* You can now include the media playlist(s) from both pipelines in the HLS master manifest for seamless failover.
* QuickSight (3.3.0.0)
	* Amazon QuickSight is a fully managed, serverless, cloud business intelligence system that allows you to extend data and insights to every user in your organization. The first release of APIs for Amazon QuickSight introduces embedding and user/group management capabilities. The get-dashboard-embed-url API allows you to obtain an authenticated dashboard URL that can be embedded in application domains whitelisted for QuickSight dashboard embedding. User APIs allow you to programmatically expand and manage your QuickSight deployments while group APIs allow easier permissions management for resources within QuickSight.
* RDSDataService (3.3.0.0)
	* The RDS Data API Beta is available for the MySQL-compatible edition of Amazon Aurora Serverless in the US East (N. Virginia) Region. This API enables you to easily access Aurora Serverless with web services-based applications including AWS Lambda and AWS AppSync.
* Redshift (3.3.11.2)
	* Documentation updates for redshift
* SimpleSystemsManagement (3.3.37.0)
	* AWS Systems Manager Distributor helps you securely distribute and install software packages.
* XRay (3.3.4.0)
	* Groups build upon X-Ray filter expressions to allow for fine tuning trace summaries and service graph results. You can configure groups by using the AWS X-Ray console or by using the CreateGroup API. The addition of groups has extended the available request fields to the GetServiceGraph API. You can now specify a group name or group ARN to retrieve its service graph.

### 3.3.411.0 (2018-11-20 00:58 UTC)
* Batch (3.3.7.0)
	* Adding multinode parallel jobs, placement group support for compute environments.
* CloudFormation (3.3.13.0)
	* Use the CAPABILITY_AUTO_EXPAND capability to create or update a stack directly from a stack template that contains macros, without first reviewing the resulting changes in a change set first.
* CloudTrail (3.3.4.0)
	* This release supports creating a trail in CloudTrail that logs events for all AWS accounts in an organization in AWS Organizations. This helps enable you to define a uniform event logging strategy for your organization. An organization trail is applied automatically to each account in the organization and cannot be modified by member accounts. To learn more, please see the AWS CloudTrail User Guide https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html
* ConfigService (3.3.22.0)
	* In this release, AWS Config adds support for aggregating the configuration data of AWS resources into multi-account and multi-region aggregators. AWS Config adds four APIs to query and retrieve aggregated resource configurations. 1) BatchGetAggregateResourceConfig, returns the current configuration items for resources that are present in your AWS Config aggregator. 2) GetAggregateDiscoveredResourceCounts, returns the resource counts across accounts and regions that are present in your AWS Config aggregator. 3) GetAggregateResourceConfig, returns current configuration item that is aggregated for your specific resource in a specific source account and region. 4) ListAggregateDiscoveredResources, accepts a resource type and returns a list of resource identifiers that are aggregated for a specific resource type across accounts and regions.
* DeviceFarm (3.3.9.0)
	* Customers can now schedule runs without a need to create a Device Pool. They also get realtime information on public device availability.
* EC2 (3.3.72.0)
	* Adding AvailabilityZoneId to DescribeAvailabilityZones
* IoT (3.3.21.0)
	* IoT now supports resource tagging and tag based access control for Billing Groups, Thing Groups, Thing Types, Jobs, and Security Profiles. IoT Billing Groups help you group devices to categorize and track your costs. AWS IoT Device Management also introduces three new features: 1. Dynamic thing groups. 2. Jobs dynamic rollouts. 3. Device connectivity indexing. Dynamic thing groups lets you to create a group of devices using a Fleet Indexing query. The devices in your group will be automatically added or removed when they match your specified query criteria. Jobs dynamic rollout allows you to configure an exponentially increasing rate of deployment for device updates and define failure criteria to cancel your job. Device connectivity indexing allows you to index your devices' lifecycle events to discover whether devices are connected or disconnected to AWS IoT.
* Lambda (3.3.18.0)
	* AWS Lambda now supports python3.7 and  the Kinesis Data Streams (KDS) enhanced fan-out and HTTP/2 data retrieval features for Kinesis event sources.
* Lightsail (3.3.7.17)
	* Add Managed Database operations to OperationType enum.
* MediaConvert (3.3.10.0)
	* AWS Elemental MediaConvert SDK has added several features including support for: SPEKE full document encryption, up to 150 elements for input stitching, input and motion image insertion, AWS CLI path arguments in S3 links including special characters, AFD signaling, additional caption types, and client-side encrypted input files.
* RDS (3.3.36.0)
	* This release adds a new parameter to specify VPC security groups for restore from DB snapshot, restore to point int time and create read replica operations. For more information, see Amazon RDS Documentation.
* WorkDocs (3.3.7.0)
	* With this release, clients can now use the GetResources API to fetch files and folders from the user's SharedWithMe collection. And also through this release, the existing DescribeActivities API has been enhanced to support additional filters such as the ActivityType and the ResourceId.
* WorkSpaces (3.3.5.0)
	* Added new APIs to Modify and Describe WorkSpaces client properties for users in a directory. With the new APIs, you can enable/disable remember me option in WorkSpaces client for users in a directory.

### 3.3.410.0 (2018-11-16 21:18 UTC)
* Comprehend (3.3.5.0)
	* Amazon Comprehend Custom Entities automatically trains entity recognition models using your entities and noun-based phrases. 
* CostExplorer (3.3.8.0)
	* This release introduces a new operation called GetCostForecast operation, which allows you to programmatically access AWS Cost Explorer's forecasting engine and is now generally available.
* ECS (3.3.20.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for additional Docker flags as Task Definition parameters. Customers can now configure their ECS Tasks to use pidMode (pid) and ipcMode (ipc) Docker flags.
* SimpleSystemsManagement (3.3.36.0)
	* AWS Systems Manager Automation now allows you to execute and manage Automation workflows across multiple accounts and regions. 
* WorkSpaces (3.3.4.0)
	* Added new Bring Your Own License (BYOL) automation APIs. With the new APIs, you can list available management CIDR ranges for dedicated tenancy, enable your account for BYOL, describe BYOL status of your account, and import BYOL images. Added new APIs to also describe and delete WorkSpaces images. 

### 3.3.409.1 (2018-11-16 04:28 UTC)
* Core 3.3.29.12
	* Fix bug with calling CognitoIdentityProvider's SignUp operation with temporary credentials. Add support for endpoint hostPrefix. Add slash encoding support for identifier values within service resource paths.
	* All services packages updated to require new Core

### 3.3.409.0 (2018-11-16 00:41 UTC)
* CodeBuild (3.3.18.0)
	* Adding queue phase and configurable queue timeout to CodeBuild.
* Comprehend (3.3.4.0)
	* Amazon Comprehend Custom Classification automatically trains classification models using your text and custom labels.
* DatabaseMigrationService (3.3.12.0)
	* Settings structures have been added to our DMS endpoint APIs to support Kinesis and Elasticsearch as targets. We are introducing the ability to configure custom DNS name servers on a replication instance as a beta feature. 
* DirectConnect (3.3.9.0)
	* This release enables DirectConnect customers to have logical redundancy on virtual interfaces within supported DirectConnect locations.
* ECS (3.3.19.0)
	* In this release, Amazon ECS introduces multiple features. First, ECS now supports integration with Systems Manager Parameter Store for injecting runtime secrets. Second, ECS introduces support for resources tagging. Finally, ECS introduces a new ARN and ID Format for its resources, and provides new APIs for opt-in to the new formats. 
* IdentityManagement (3.3.8.0)
	* We are making it easier for you to manage your AWS Identity and Access Management (IAM) resources by enabling you to add tags to your IAM principals (users and roles). Adding tags on IAM principals will enable you to write fewer policies for permissions management and make policies easier to comprehend.  Additionally, tags will also make it easier for you to grant access to AWS resources.
* Pinpoint (3.3.11.0)
	* 1. With Amazon Pinpoint Voice, you can use text-to-speech technology to deliver personalized voice messages to your customers. Amazon Pinpoint Voice is a great way to deliver transactional messages -- such as one-time passwords and identity confirmations -- to customers. 2. Adding support for Campaign Event Triggers. With Campaign Event Triggers you can now schedule campaigns to execute based on incoming event data and target just the source of the event.
* PinpointSMSVoice (3.3.0.0)
	* With Amazon Pinpoint Voice, you can use text-to-speech technology to deliver personalized voice messages to your customers. Amazon Pinpoint Voice is a way to deliver transactional messages -- such as one-time passwords and appointment confirmations to customers.
* RAM (3.3.0.0)
	* This is the initial release of AWS Resource Access Manager (RAM) which provides you the ability to share your resources across AWS accounts or within your AWS Organization. You can now create resources centrally and use AWS RAM to share those resources with other accounts, eliminating the need to provision and manage resources in every account. When you share a resource with another account, that account is granted access. Any policies and permissions in that account apply to the shared resource. 
* RDS (3.3.35.0)
	* Introduces DB Instance Automated Backups for the MySQL, MariaDB, PostgreSQL, Oracle and Microsoft SQL Server database engines. You can now retain Amazon RDS automated backups (system snapshots and transaction logs) when you delete a database instance. This allows you to restore a deleted database instance to a specified point in time within the backup retention period even after it has been deleted, protecting you against accidental deletion of data. For more information, see Amazon RDS Documentation.
* Redshift (3.3.11.0)
	* With this release, Redshift is providing API's for better snapshot management by supporting user defined automated snapshot schedules, retention periods for manual snapshots, and aggregate snapshot actions including batch deleting user snapshots, viewing account level snapshot storage metrics, and better filtering and sorting on the describe-cluster-snapshots API. Automated snapshots can be scheduled to be taken at a custom interval and the schedule created can be reused across clusters. Manual snapshot retention periods can be set at the cluster, snapshot, and cross-region-copy level. The retention period set on a manual snapshot indicates how many days the snapshot will be retained before being automatically deleted.
* Route53Resolver (3.3.0.0)
	* This is the first release of the Amazon Route 53 Resolver API.  Customers now have the ability to create and manage Amazon Route 53 Resolver endpoints and Amazon Route 53 Resolver rules. 
* S3 (3.3.27.0)
	* Add support for new S3 Block Public Access bucket-level APIs. The new Block Public Access settings allow bucket owners to prevent public access to S3 data via bucket/object ACLs or bucket policies.
* S3Control (3.3.0.0)
	* Add support for new S3 Block Public Access account-level APIs. The Block Public Access settings allow account owners to prevent public access to S3 data via bucket/object ACLs or bucket policies.
* TranscribeService (3.3.6.0)
	* With this release, Amazon Transcribe now publicly supports transcriptions from audio sources in British English (en-GB), Australian English (en-AU), and Canadian French (fr-CA). Amazon Transcribe now also supports the following languages in Private beta: Germany German (de-DE), Brazil Portuguese (pt-BR), France French (fr-FR).
* Core 3.3.29.11
	* Updating endpoints.json file
Add support for S3Control


	* All services packages updated to require new Core

### 3.3.408.0 (2018-11-14 22:39 UTC)
* AutoScaling (3.3.8.0)
	* EC2 Auto Scaling now allows users to provision and automatically scale instances across purchase options (Spot, On-Demand, and RIs) and instance types in a single Auto Scaling group (ASG).
* EC2 (3.3.71.0)
	* Amazon EC2 Fleet now supports a new request type "Instant" that you can use to provision capacity synchronously across instance types & purchase models and CreateFleet will return the instances launched in the API response.
* MediaTailor (3.3.2.0)
	* AWS Elemental MediaTailor SDK now returns a manifest endpoint prefix for clients to initiate a DASH playback session.
* ResourceGroups (3.3.3.0)
	* The AWS Resource Groups service added support for AWS CloudFormation stack-based groups.
* SageMaker (3.3.15.0)
	* SageMaker now makes the final set of metrics published from training jobs available in the DescribeTrainingJob results.  Automatic Model Tuning now supports warm start of hyperparameter tuning jobs.  Notebook instances now support a larger number of instance types to include instances from the ml.t3, ml.m5, ml.c4, ml.c5 families.
* ServiceCatalog (3.3.13.0)
	* Adds support for Cloudformation StackSets in Service Catalog
* SimpleNotificationService (3.3.3.0)
	* Added an optional request parameter, named Attributes, to the Amazon SNS CreateTopic API action. For more information, see the Amazon SNS API Reference (https://docs.aws.amazon.com/sns/latest/api/API_CreateTopic.html).
* Core 3.3.29.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.407.0 (2018-11-13 21:59 UTC)
* Budgets (3.3.10.1)
	* Doc Update: 1. Available monthly-budgets maximal history data points from 12 to 13.  2. Added 'Amazon Elasticsearch' costfilters support.
* Chime (3.3.1.0)
	* This release adds support in ListUsers API to filter the list by an email address.
* Redshift (3.3.10.0)
	* Amazon Redshift provides the option to defer non-mandatory maintenance updates to a later date.
* Core 3.3.29.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.406.0 (2018-11-13 00:33 UTC)
* Batch (3.3.6.0)
	* Adding EC2 Launch Template support in AWS Batch Compute Environments.
* Budgets (3.3.10.0)
	* 1. Added budget performance history, enabling you to see how well your budgets matched your actual costs and usage.                                                                                             2. Added budget performance history, notification state, and last updated time, enabling you to see how well your budgets matched your actual costs and usage, how often your budget alerts triggered, and when your budget was last updated.
* CloudFormation (3.3.12.0)
	* The Drift Detection feature enables customers to detect whether a stack's actual configuration differs, or has drifted, from its expected configuration as defined within AWS CloudFormation.
* CodePipeline (3.3.6.0)
	* Add support for cross-region pipeline with accompanying definitions as needed in the AWS CodePipeline API Guide.
* KinesisFirehose (3.3.7.0)
	* With this release, Amazon Kinesis Data Firehose allows you to enable/disable server-side encryption(SSE) for your delivery streams ensuring encryption of data at rest. For technical documentation, look at https://docs.aws.amazon.com/firehose/latest/dev/encryption.html
* Polly (3.3.9.0)
	* Amazon Polly adds new female voices: Italian - Bianca, Castilian Spanish - Lucia and new language: Mexican Spanish with new female voice - Mia.
* RDS (3.3.34.0)
	* API Update for RDS: this update enables Custom Endpoints, a new feature compatible with Aurora Mysql, Aurora PostgreSQL and Neptune that allows users to configure a customizable endpoint that will provide access to their instances in a cluster. 

### 3.3.405.0 (2018-11-09 22:01 UTC)
* MediaPackage (3.3.5.0)
	* As a part of SPEKE DRM encryption, MediaPackage now supports encrypted content keys. You can enable this enhanced content protection in an OriginEndpoint's encryption settings. When this is enabled, MediaPackage indicates to the key server that it requires an encrypted response. To use this, your DRM key provider must support content key encryption. For details on this feature, see the AWS MediaPackage User Guide at https://docs.aws.amazon.com/mediapackage/latest/ug/what-is.html.
* Core 3.3.29.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.404.0 (2018-11-09 02:57 UTC)
* CloudWatchEvents (3.3.7.10)
	* Documentation updates for events
* DLM (3.3.1.0)
	* Amazon Data Lifecycle Manager adds support for copying EBS volume tags to EBS snapshots. AWS resource tags allow customers to add metadata and apply access policies to your Amazon Elastic Block Store (Amazon EBS) resources. Starting today, customers can use Amazon Data Lifecycle Manager (DLM) to copy tags on EBS volumes to EBS snapshots. This allows customers to easily set snapshot metadata, such as access policies, to match the parent volume. Customers can enable this functionality on new or existing lifecycle policies. They can also choose to disable it at a future date.  
* MediaLive (3.3.11.0)
	* You can now switch a live channel between preconfigured inputs. This means assigned inputs for a running channel can be changed according to a defined schedule. You can also use MP4 files as inputs.
* Core 3.3.29.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.403.0 (2018-11-07 21:35 UTC)
* CostExplorer (3.3.7.0)
	* Enable Payer Accounts to View Linked Account Recommendations. Payer Accounts can specify "LINKED" as scope in the request now. In the response, there is a new filed called AccountId in ReservationPurchaseRecommendationDetail for indicating which account is this recommendation detail belongs to.
* DatabaseMigrationService (3.3.11.0)
	* Update the DMS TestConnectionSucceeds waiter.
* EC2 (3.3.70.0)
	* VM Import/Export now supports generating encrypted EBS snapshots, as well as AMIs backed by encrypted EBS snapshots during the import process.
* Core 3.3.29.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.402.0 (2018-11-06 23:16 UTC)
* APIGateway (3.3.23.0)
	* AWS WAF integration with APIGW. Changes for adding webAclArn as a part of  Stage output. When the user calls a get-stage or get-stages, webAclArn will also be returned as a part of the output.
* CodeBuild (3.3.17.10)
	* Documentation updates for codebuild
* EC2 (3.3.69.0)
	* You can now launch the new Amazon EC2 memory optimized R5a and general purpose M5a instances families that feature AMD EPYC processors.
* Pinpoint (3.3.10.0)
	* This update adds the ability to send transactional email by using the SendMessage API. Transactional emails are emails that you send directly to specific email addresses. Unlike campaign-based email that you send from Amazon Pinpoint, you don't have to create segments and campaigns in order to send transactional email.
* PinpointEmail (3.3.0.0)
	* This is the first release of the Amazon Pinpoint Email API. You can use this API to configure and send transactional email from your Amazon Pinpoint account to specific email addresses. Unlike campaign-based email that you send from Amazon Pinpoint, you don't have to create segments and campaigns in order to send transactional email. 
* WAFRegional (3.3.6.0)
	* You can now use AWS WAF to configure protections for your Amazon API Gateway APIs.  This will enable you to block (or count) undesired traffic to your APIs based on the different AWS WAF rules and conditions you create. For more information about AWS WAF, see the AWS WAF Developer Guide.
* Core 3.3.29.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.401.1 (2018-11-06 17:46 UTC)
* Core 3.3.29.4
	* Make IClientConfig.HttpClientFactory available in .NET standard SDK
	* All services packages updated to require new Core

### 3.3.401.0 (2018-11-05 23:11 UTC)
* EKS (3.3.2.0)
	* Adds waiters for ClusterActive and ClusterDeleted
* ServerlessApplicationRepository (3.3.3.0)
	* New AWS Serverless Application Repository APIs that support creating and reading a broader set of AWS CloudFormation templates, as well as enhancements to our existing APIs.

### 3.3.400.0 (2018-11-02 20:06 UTC)
* CloudDirectory (3.3.10.0)
	* ListObjectParents API now supports a bool parameter IncludeAllLinksToEachParent, which if set to true, will return a ParentLinks list instead of a Parents map; BatchRead API now supports ListObjectParents operation.
* Rekognition (3.3.12.0)
	* This release updates the DetectLabels operation. Bounding boxes are now returned for certain objects, a hierarchical taxonomy is now available for labels, and you can now get the version of the detection model used for detection.

### 3.3.399.0 (2018-11-01 22:29 UTC)
* ServiceCatalog (3.3.12.0)
	* Service Catalog integration with AWS Organizations, enables customers to more easily create and manage a portfolio of IT services across an organization. Administrators can now take advantage of the AWS account structure and account groupings configured in AWS Organizations to share Service Catalog Portfolios increasing agility and reducing risk. With this integration the admin user will leverage the trust relationship that exists within the accounts of the Organization to share portfolios to the entire Organization, a specific Organizational Unit or a specific Account.

### 3.3.398.0 (2018-10-31 21:06 UTC)
* ConfigService (3.3.21.0)
	* With this release, AWS Config updated the ResourceType values. The updated list includes AWS Systems Manager AssociationCompliance and PatchCompliance, AWS Shield regional Protection, AWS Config ResourceCompliance, and AWS CodePipeline Pipeline.
* Greengrass (3.3.4.0)
	* Greengrass APIs now support bulk deployment operations, and APIs that list definition versions now support pagination.
* MediaStoreData (3.3.1.0)
	* The object size limit is increased from 10MB to 25MB and the content type is more permissive.
* SecretsManager (3.3.2.19)
	* Documentation updates for AWS Secrets Manager.

### 3.3.397.0 (2018-10-30 22:04 UTC)
* Chime (3.3.0.0)
	* This is the initial release for the Amazon Chime AWS SDK. In this release, Amazon Chime adds support for administrative actions on users and accounts. API Documentation is also updated on https://docs.aws.amazon.com/chime/index.html
* DatabaseMigrationService (3.3.10.0)
	* Add waiters for TestConnectionSucceeds, EndpointDeleted, ReplicationInstanceAvailable, ReplicationInstanceDeleted, ReplicationTaskReady, ReplicationTaskStopped, ReplicationTaskRunning and ReplicationTaskDeleted.
* RDS (3.3.33.0)
	* This release adds the listener connection endpoint for SQL Server Always On to the list of fields returned when performing a describe-db-instances operation.
* Core 3.3.29.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.396.2 (2018-10-29 20:45 UTC)
* Core 3.3.29.2
	* Allow PCL users to manually create HttpClients to be used by service clients in the SDK.
	* All services packages updated to require new Core

### 3.3.396.1 (2018-10-29 16:36 UTC)
* Core 3.3.29.1
	* Allow PCL users to manually create HttpClients to be used by service clients in the SDK.
	* All services packages updated to require new Core

### 3.3.396.0 (2018-10-26 20:02 UTC)
* AlexaForBusiness (3.3.6.2)
	* Documentation updates for AWS Alexa for Business
* SageMaker (3.3.14.0)
	* SageMaker notebook instances can now have a volume size configured.
* SimpleSystemsManagement (3.3.35.0)
	* Compliance Severity feature release for State Manager. Users now have the ability to select compliance severity to their association in state manager console or CLI.

### 3.3.395.0 (2018-10-26 17:53 UTC)
* Core 3.3.29.0
	* Code for future SDK instrumentation and telemetry.
	* All services packages updated to require new Core

### 3.3.394.0 (2018-10-25 18:59 UTC)
* EC2 (3.3.68.0)
	* As part of this release we are introducing EC2 On-Demand Capacity Reservations. With On-Demand Capacity Reservations, customers can reserve the exact EC2 capacity they need, and can keep it only for as long as they need it.

### 3.3.393.0 (2018-10-24 19:20 UTC)
* AlexaForBusiness (3.3.6.0)
	* We extended the functionality of the Alexa for Business SDK, including additional support for third-party Alexa built-in devices, managing private and public skills, and conferencing setup.
* CodeStar (3.3.3.0)
	* This release lets you create projects from source code and a toolchain definition that you provide.

### 3.3.392.0 (2018-10-23 20:09 UTC)
* EC2 (3.3.67.0)
	* Provides customers the ability to Bring Your Own IP (BYOIP) prefix.  You can bring part or all of your public IPv4 address range from your on-premises network to your AWS account. You continue to own the address range, but AWS advertises it on the internet.

### 3.3.391.0 (2018-10-22 21:38 UTC)
* Inspector (3.3.8.0)
	* Finding will be decorated with ec2 related metadata
* Shield (3.3.4.0)
	* AWS Shield Advanced API introduced a new service-specific AccessDeniedException which will be thrown when accessing individual attack information without sufficient permission.
* Core 3.3.28.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.390.0 (2018-10-22 16:20 UTC)
* AutoScaling (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* CloudWatch (3.3.9.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* EC2 (3.3.66.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* ElastiCache (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* ElasticBeanstalk (3.3.11.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoT (3.3.20.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoT1ClickDevicesService (3.3.1.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoTAnalytics (3.3.5.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* MobileAnalytics (3.3.2.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Neptune (3.3.4.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* RDS (3.3.32.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Redshift (3.3.9.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* S3 (3.3.26.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* SimpleEmail (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* SimpleNotificationService (3.3.2.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* WorkDocs (3.3.6.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Core 3.3.28.0
	* Update to support DateTime serialization fixes in service libraries.
	* All services packages updated to require new Core

### 3.3.389.0 (2018-10-19 20:49 UTC)
* SimpleSystemsManagement (3.3.34.0)
	* Rate Control feature release for State Manager. Users now have the ability to apply rate control parameters similar to run command to their association in state manager console or CLI.
* WorkSpaces (3.3.3.0)
	* Added support for PowerPro and GraphicsPro WorkSpaces bundles.

### 3.3.388.0 (2018-10-18 21:32 UTC)
* AppStream (3.3.19.0)
	* This API update adds support for creating, managing, and deleting users in the AppStream 2.0 user pool.
* MediaLive (3.3.10.0)
	* This release allows you to now turn on Quality-Defined Variable Bitrate (QVBR) encoding for your AWS Elemental MediaLive channels. You can now deliver a consistently high-quality video viewing experience while reducing overall distribution bitrates by using Quality-Defined Variable Bitrate (QVBR) encoding with AWS Elemental MediaLive. QVBR is a video compression technique that automatically adjusts output bitrates to the complexity of source content and only use the bits required to maintain a defined level of quality. This means using QVBR encoding, you can save on distribution cost, while maintaining, or increasing video quality for your viewers.
* Route53 (3.3.17.0)
	* This change allows customers to disable health checks.

### 3.3.387.0 (2018-10-17 20:41 UTC)
* APIGateway (3.3.22.3)
	* Documentation updates for API Gateway
* CloudWatchEvents (3.3.7.0)
	* AWS Events - AWS Organizations Support in Event-Bus Policies. This release introduces a new parameter in the PutPermission API named Condition. Using the Condition parameter, customers can allow one or more AWS Organizations to access their CloudWatch Events Event-Bus resource.

### 3.3.386.0 (2018-10-17 18:09 UTC)
* Lambda (3.3.17.0)
	* Enables TCP keepalive as default in Lambda.
* S3 (3.3.25.1)
	* Fixed incorrect marshalling of S3 tag.
* Core 3.3.27.3
	* Referencing the CredentialProfileStoreChain constructor that takes in the profile location on AWSConfigs. Make code more defensive looking for CSM configuration. 
	* All services packages updated to require new Core

### 3.3.385.0 (2018-10-17 00:57 UTC)
* Glue (3.3.15.0)
	* New Glue APIs for creating, updating, reading and deleting Data Catalog resource-based policies.
* Lightsail (3.3.7.0)
	* Adds support for Lightsail managed databases.
* ResourceGroups (3.3.2.0)
	* AWS Resource Groups service added a new feature to filter resource groups by resource-type when using the ListGroups operation.

### 3.3.384.0 (2018-10-15 21:19 UTC)
* Lambda (3.3.16.6)
	* Documentation updates for lambda
* RDS (3.3.31.0)
	* This release adds a new parameter to specify the DB instance or cluster parameter group for restore from DB snapshot and restore to point int time operations. For more information, see Amazon RDS Documentation.
* ServiceCatalog (3.3.11.0)
	* AWS Service Catalog enables you to reduce administrative maintenance and end-user training while adhering to compliance and security measures. With service actions, you as the administrator can enable end users to perform operational tasks, troubleshoot issues, run approved commands, or request permissions within Service Catalog. Service actions are defined using AWS Systems Manager documents, where you have access to pre-defined actions that implement AWS best practices, such asEC2 stop and reboot, as well as the ability to define custom actions.

### 3.3.383.0 (2018-10-12 21:46 UTC)
* CloudTrail (3.3.3.0)
	* The LookupEvents API now supports two new attribute keys: ReadOnly and AccessKeyId

### 3.3.382.0 (2018-10-12 17:01 UTC)
* MobileAnalytics (3.3.1.44)
	* Fixed bugs in handling attributes of CustomEvent.
Fixed NullReferenceException in DeliveryClient.AttemptDeliveryAsync()
* S3 (3.3.25.0)
	* Changed service client to throw an exception when operations are called without a required BucketName or Key parameter.
Changed service client to resign request on retries.
* Core 3.3.27.2
	* Changed the exception thrown by ClientContext constructor to be more descriptive.

### 3.3.381.0 (2018-10-11 22:56 UTC)
* Athena (3.3.1.0)
	* 1. GetQueryExecution API changes to return statementType of a submitted Athena query.  2. GetQueryResults API changes to return the number of rows added to a table when a CTAS query is executed.
* DirectConnect (3.3.8.0)
	* This release adds support for Jumbo Frames over AWS Direct Connect. You can now set MTU value when creating new virtual interfaces. This release also includes a new API to modify MTU value of existing virtual interfaces.
* EC2 (3.3.65.0)
	* You can now launch the smaller-sized G3 instance called g3s.xlarge. G3s.xlarge provides 4 vCPU, 30.5 GB RAM and a NVIDIA Tesla M60 GPU. It is ideal for remote workstations, engineering and architectural applications, and 3D visualizations and rendering for visual effects.
* TranscribeService (3.3.5.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in British English (en-UK), Australian English (en-AU), and Canadian French (fr-CA).

### 3.3.380.0 (2018-10-10 22:51 UTC)
* Comprehend (3.3.3.0)
	* This release adds French, Italian, German and Portuguese language support for all existing synchronous and asynchronous APIs
* Elasticsearch (3.3.10.0)
	* Amazon Elasticsearch Service now supports customer-scheduled service software updates. When new service software becomes available, you can request an update to your domain and benefit from new features more quickly. If you take no action, we update the service software automatically after a certain time frame.
* TranscribeService (3.3.4.0)
	* With this update Amazon Transcribe now supports deleting completed transcription jobs. 

### 3.3.379.1 (2018-10-10 02:29 UTC)
* S3 (3.3.24.4)
	* Updated to use new Core, version 3.3.27.1
	* Fixed bug parsing event stream used by S3's Select operation.
* Core 3.3.27.1
	* Fixed bug parsing event stream used by S3's Select operation.

### 3.3.379.0 (2018-10-09 20:36 UTC)
* SimpleSystemsManagement (3.3.33.0)
	* Adds StartDate, EndDate, and ScheduleTimezone to CreateMaintenanceWindow and UpdateMaintenanceWindow; Adds NextExecutionTime to GetMaintenanceWindow and DescribeMaintenanceWindows; Adds CancelMaintenanceWindowExecution, DescribeMaintenanceWindowSchedule and DescribeMaintenanceWindowsForTarget APIs.

### 3.3.378.0 (2018-10-08 20:08 UTC)
* IoT (3.3.19.0)
	* We are releasing job execution timeout functionalities to customers. Customer now can set job execution timeout on the job level when creating a job. 
* IoTJobsDataPlane (3.3.1.0)
	* We are releasing job execution timeout functionalities to customers. Device can now set and update their job execution timeout. 

### 3.3.377.0 (2018-10-06 01:28 UTC)
* Core 3.3.27.0
	* Fix to rectify breaking change that was introduced in v3.3.26 of AWSSDK.Core nuget package. Customer should update to this version of the AWSSDK.Core nuget package.
	* All services packages updated to require new Core

### 3.3.376.0 (2018-10-05 21:07 UTC)
* DirectoryService (3.3.8.0)
	* SDK changes to create a new type of trust for active directory

### 3.3.375.0 (2018-10-04 22:55 UTC)
* APIGateway (3.3.22.0)
	* Adding support for multi-value parameters in TestInvokeMethod and TestInvokeAuthorizer.
* CodeBuild (3.3.17.0)
	* Add resolved source version field in build output
* SimpleSystemsManagement (3.3.32.0)
	*  Adds RejectedPatchesAction to baseline to enable stricted validation of the rejected Patches List ; Add InstalledRejected and InstallOverrideList to compliance reporting
* StorageGateway (3.3.11.0)
	* AWS Storage Gateway now enables you to specify folders and subfolders when you update your file gateway's view of your S3 objects using the Refresh Cache API.

### 3.3.374.0 (2018-10-03 23:53 UTC)
* CloudFront (3.3.10.5)
	* Fixed client throwing NullReferenceException instead of AmazonCloudFrontException when requests are performed without specifying certain missing required properties.
* Core 3.3.26.0
	* Code for future SDK instrumentation and telemetry
Add credential_source parameter in the shared credentials file
Correct Metric.ProxyHost setup
	* All services packages updated to require new Core

### 3.3.373.0 (2018-10-02 21:12 UTC)
* SageMaker (3.3.13.0)
	* Waiter for SageMaker Batch Transform Jobs.
* SecretsManager (3.3.2.9)
	* Documentation updates for secretsmanager

### 3.3.372.0 (2018-10-01 22:10 UTC)
* GuardDuty (3.3.5.0)
	* Support optional FindingPublishingFrequency parameter in CreateDetector and UpdateDetector operations, and ClientToken on Create* operations
* Rekognition (3.3.11.2)
	* Documentation updates for Amazon Rekognition

### 3.3.371.0 (2018-09-28 18:48 UTC)
* CodeStar (3.3.2.0)
	* This release enables tagging CodeStar Projects at creation. The CreateProject API now includes optional tags parameter.
* EC2 (3.3.64.0)
	* You can now use EC2 High Memory instances with 6 TiB memory (u-6tb1.metal), 9 TiB memory (u-9tb1.metal), and 12 TiB memory (u-12tb1.metal), which are ideal for running large in-memory databases, including production deployments of SAP HANA. These instances offer 448 logical processors, where each logical processor is a hyperthread on 224 cores. These instance deliver high networking throughput and lower latency with up to 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking. These instances are EBS-Optimized by default, and support encrypted and unencrypted EBS volumes. This instance is only available in host-tenancy. You will need an EC2 Dedicated Host for this instance type to launch an instance.

### 3.3.370.0 (2018-09-27 19:54 UTC)
* APIGateway (3.3.21.0)
	* Adding support for OpenAPI 3.0 import and export.
* CodeCommit (3.3.6.0)
	* This release adds API support for getting the contents of a file, getting the contents of a folder, and for deleting a file in an AWS CodeCommit repository.
* MQ (3.3.2.0)
	* Amazon MQ supports ActiveMQ 5.15.6, in addition to 5.15.0. Automatic minor version upgrades can be toggled. Updated the documentation.

### 3.3.369.0 (2018-09-26 21:15 UTC)
* Glue (3.3.14.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.
* OpsWorksCM (3.3.6.0)
	* This release introduces a new API called ExportServerEngineAttribute to Opsworks-CM. You can use this API call to export engine specific attributes like the UserData script used for unattended bootstrapping of new nodes that connect to the server. 
* RDS (3.3.30.0)
	* This release includes Deletion Protection for RDS databases.
* SQS (3.3.3.20)
	* Documentation updates for Amazon SQS.
* Core 3.3.25.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.368.0 (2018-09-25 20:16 UTC)
* CloudFront (3.3.10.3)
	* Documentation updates for cloudfront
* DirectoryService (3.3.7.0)
	* API changes related to launch of cross account for Directory Service.
* EC2 (3.3.63.0)
	* Add pagination support for ec2.describe-route-tables API. 

### 3.3.367.0 (2018-09-24 21:20 UTC)
* Connect (3.3.3.0)
	* This update adds the Amazon Connect Metrics API, which lets you get current metric data and historical metric data within 24 hours for the queues in your Amazon Connect instance.
* RDS (3.3.29.0)
	*  Adds DB engine version requirements for option group option settings, and specifies if an option setting requires a value.

### 3.3.366.0 (2018-09-21 20:31 UTC)
* MediaConvert (3.3.9.0)
	* To offer lower prices for predictable, non-urgent workloads, we propose the concept of Reserved Transcode pricing. Reserved Transcode pricing Reserved Transcoding pricing would offer the customer access to a fixed parallel processing capacity for a fixed monthly rate. This capacity would be stated in terms of number of Reserved Transcode Slots (RTSs). One RTS would be able to process one job at a time for a fixed monthly fee.

### 3.3.365.0 (2018-09-20 21:23 UTC)
* DirectoryService (3.3.6.0)
	* Added CreateLogSubscription, DeleteLogSubscription, and ListLogSubscriptions APIs for Microsoft AD. Customers can now opt in to have Windows security event logs from the domain controllers forwarded to a log group in their account.
* EC2 (3.3.62.0)
	* You can now launch f1.4xlarge, a new instance size within the existing f1 family which provides two Xilinx Virtex Field Programmable Arrays (FPGAs) for acceleration. FPGA acceleration provide additional performance and time sensitivity for specialized accelerated workloads such as clinical genomics and real-time video processing. F1.4xlarge instances are available in the US East (N. Virginia), US West (Oregon), GovCloud (US), and EU West (Dublin) AWS Regions.
* RDS (3.3.28.0)
	* This launch enables RDS start-db-cluster and stop-db-cluster. Stopping and starting Amazon Aurora clusters helps you manage costs for development and test environments. You can temporarily stop all the DB instances in your cluster, instead of setting up and tearing down all the DB instances each time that you use the cluster.

### 3.3.364.0 (2018-09-19 18:33 UTC)
* CloudWatch (3.3.8.0)
	* Amazon CloudWatch adds the ability to request png image snapshots of metric widgets using the GetMetricWidgetImage API.
* Organizations (3.3.9.0)
	* Introducing a new exception - AccountOwnerNotVerifiedException which will be returned for InviteAccountToOrganization call for unverified accounts.
* S3 (3.3.24.0)
	* S3 Cross Region Replication now allows customers to use S3 object tags to filter the scope of replication. By using S3 object tags, customers can identify individual objects for replication across AWS Regions for compliance and data protection. Cross Region Replication for S3 enables automatic and asynchronous replication of objects to another AWS Region, and with this release customers can replicate at a bucket level, prefix level or by using object tags.

### 3.3.363.0 (2018-09-18 21:35 UTC)
* Elasticsearch (3.3.9.0)
	* Amazon Elasticsearch Service adds support for node-to-node encryption for new domains running Elasticsearch version 6.0 and above
* Rekognition (3.3.11.0)
	* This release updates the Amazon Rekognition IndexFaces API operation. It introduces a QualityFilter parameter that allows you to automatically filter out detected faces that are deemed to be of low quality by Amazon Rekognition. The quality bar is based on a variety of common use cases.  You can filter low-quality detected faces by setting QualityFilter to AUTO, which is also the default setting. To index all detected faces regardless of quality, you can specify NONE.  This release also provides a MaxFaces parameter that is useful when you want to only index the most prominent and largest faces in an image and don't want to index other faces detected in the image, such as smaller faces belonging to people standing in the background.

### 3.3.362.0 (2018-09-17 21:41 UTC)
* CloudWatch (3.3.7.0)
	* Amazon CloudWatch adds the ability to publish values and counts using PutMetricData
* CodeBuild (3.3.16.0)
	* Support build logs configuration.
* EC2 (3.3.61.0)
	* Added support for customers to tag EC2 Dedicated Hosts on creation.
* ECS (3.3.18.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for additional Docker flags as Task Definition parameters. Customers can now configure their ECS Tasks to use systemControls (sysctl), pseudoTerminal (tty), and interactive (i) Docker flags.
* ElastiCache (3.3.6.0)
	* ElastiCache for Redis added support for adding and removing read-replicas from any cluster with no cluster downtime, Shard naming: ElastiCache for Redis customers have the option of allowing ElastiCache to create names for their node groups (shards) or generating their own node group names. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_NodeGroupConfiguration.html, ShardsToRetain: When reducing the number of node groups (shards) in an ElastiCache for Redis (cluster mode enabled) you have the option of specifying which node groups to retain or which node groups to remove. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyReplicationGroupShardConfiguration.html, ReservationARN: ReservedNode includes an ARN, ReservationARN, member which identifies the reserved node. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ReservedCacheNode.html
* ElasticTranscoder (3.3.3.0)
	* Added support for MP2 container
* SecretsManager (3.3.2.7)
	* Documentation updates for secretsmanager

### 3.3.361.0 (2018-09-13 18:37 UTC)
* Polly (3.3.8.0)
	* Amazon Polly adds Mandarin Chinese language support with new female voice - "Zhiyu"

### 3.3.360.0 (2018-09-12 20:09 UTC)
* Connect (3.3.2.0)
	* This update adds the Amazon Connect Update Contact Attributes API, which lets you update contact attributes for contacts in your Amazon Connect instance.
* EC2 (3.3.60.0)
	* Pagination Support for DescribeNetworkInterfaces API
* FMS (3.3.1.0)
	* This update of Amazon Fire Wall Manager adds the ability to scope down the policy as well as to get all the member accounts belonging to a certain Fire Wall Manager admin account.
* SimpleEmail (3.3.6.20)
	* Documentation updates for Amazon Simple Email Service

### 3.3.359.0 (2018-09-11 18:10 UTC)
* OpsWorksCM (3.3.5.3)
	* Documentation updates for opsworkscm
* SimpleSystemsManagement (3.3.31.0)
	* Session Manager is a fully managed AWS Systems Manager capability that provides interactive one-click access to Amazon EC2 Linux and Windows instances.

### 3.3.358.0 (2018-09-10 21:55 UTC)
* CloudHSMV2 (3.3.3.0)
	* With this release, we are adding 2 new APIs. DeleteBackup deletes a specified AWS CloudHSM backup. A backup can be restored up to 7 days after the DeleteBackup request. During this 7-day period, the backup will be in state PENDING_DELETION. Backups can be restored using the RestoreBackup API, which will move the backup from state PENDING_DELETION back to ACTIVE.
* Redshift (3.3.8.0)
	* Adding support to Redshift to change the encryption type after cluster creation completes.
* Core 3.3.25.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.357.0 (2018-09-07 20:09 UTC)
* CloudWatchLogs (3.3.6.0)
	* * Adding a log prefix parameter for filter log events API and minor updates to the documentation
* ConfigService (3.3.20.0)
	* Adding a new field "createdBy" to the ConfigRule data model. The field is populated only if the rule is service linked i.e the rule is created by a service. The field is empty for normal rules created by customer.

### 3.3.356.0 (2018-09-07 00:42 UTC)
* APIGateway (3.3.20.0)
	* Add support for Active X-Ray with API Gateway
* CodeCommit (3.3.5.0)
	* This release adds additional optional fields to the pull request APIs.
* MediaConvert (3.3.8.0)
	* This release adds support for Cost Allocation through tagging and also enables adding, editing, and removal of tags from the MediaConvert console.
* Core 3.3.25.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.355.0 (2018-09-05 21:05 UTC)
* AppStream (3.3.18.0)
	* Added support for enabling persistent application settings for a stack. When these settings are enabled, changes that users make to applications and Windows settings are automatically saved after each session and applied to the next session.
* DynamoDBv2 (3.3.14.0)
	* New feature for Amazon DynamoDB.
* ElasticLoadBalancing (3.3.3.0)
	* Documentation update for DescribeAccountLimits API to include classic-registered-instances.
* RDS (3.3.27.6)
	* Fix broken links in the RDS CLI Reference to the Aurora User Guide
* S3 (3.3.23.0)
	* Parquet input format support added for the SelectObjectContent API

### 3.3.354.0 (2018-09-05 18:30 UTC)
* ApplicationDiscoveryService (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.
* AppStream (3.3.17.0)
	* Added Obsolete attribute for deprecated properties.
* AutoScaling (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* CloudFront (3.3.10.0)
	* Added Obsolete attribute for deprecated properties.
* CloudTrail (3.3.2.0)
	* Added Obsolete attribute for deprecated properties.
* CodeDeploy (3.3.11.0)
	* Added Obsolete attribute for deprecated properties.
* DatabaseMigrationService (3.3.9.0)
	* Added Obsolete attribute for deprecated properties.
* DirectConnect (3.3.7.0)
	* Added Obsolete attribute for deprecated properties.
* ElasticMapReduce (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* ElasticTranscoder (3.3.2.0)
	* Added Obsolete attribute for deprecated properties.
* IoT (3.3.18.0)
	* Added Obsolete attribute for deprecated properties.
* KinesisFirehose (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* Lambda (3.3.16.0)
	* Added Obsolete attribute for deprecated properties.
* Lightsail (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* MediaLive (3.3.9.0)
	* Added Obsolete attribute for deprecated properties.
* MediaPackage (3.3.4.0)
	* Added Obsolete attribute for deprecated properties.
* MTurk (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* Neptune (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* OpsWorksCM (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.
* Route53 (3.3.16.0)
	* Added Obsolete attribute for deprecated properties.
* Route53Domains (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* S3 (3.3.22.0)
	* Added Obsolete attribute for deprecated properties.
* Shield (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* WorkDocs (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.

### 3.3.353.0 (2018-09-04 21:04 UTC)
* RDS (3.3.27.5)
	* Updating cross references for the new Aurora User Guide.
* Rekognition (3.3.10.0)
	* This release introduces a new API called DescribeCollection to Amazon Rekognition. You can use DescribeCollection to get information about an existing face collection. Given the ID for a face collection, DescribeCollection returns the following information: the number of faces indexed into the collection, the version of the face detection model used by the collection, the Amazon Resource Name (ARN) of the collection and the creation date/time of the collection.

### 3.3.352.0 (2018-08-31 21:53 UTC)
* EKS (3.3.1.0)
	* Amazon EKS DescribeCluster API returns a platformVersion attribute which allows you to identify the features that are currently enabled for your clusters. The Amazon EKS platform version represents capabilities of the cluster control plane, such as which Kubernetes API server flags are enabled, as well as the current Kubernetes patch version. 
* WAF (3.3.6.0)
	* This change includes support for the WAF FullLogging feature through which Customers will have access to all the logs of requests that are inspected by a WAF WebACL. The new APIs allow Customers to manage association of a WebACL with one or more supported "LogDestination" and redact any request fields from the logs. 
* WAFRegional (3.3.5.0)
	* This change includes support for the WAF FullLogging feature through which Customers will have access to all the logs of requests that are inspected by a WAF WebACL. The new APIs allow Customers to manage association of a WebACL with one or more supported "LogDestination" and redact any request fields from the logs. 

### 3.3.351.0 (2018-08-30 19:17 UTC)
* CodeBuild (3.3.15.0)
	* Support multiple sources and artifacts for CodeBuild projects. 
* SageMaker (3.3.12.0)
	* VolumeKmsKeyId now available in Batch Transform Job 

### 3.3.350.0 (2018-08-29 20:08 UTC)
* Glue (3.3.13.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.
* MediaPackage (3.3.3.0)
	* MediaPackage now provides input redundancy. Channels have two ingest endpoints that can receive input from encoders. OriginEndpoints pick one of the inputs receiving content for playback and automatically switch to the other input if the active input stops receiving content. Refer to the User Guide (https://docs.aws.amazon.com/mediapackage/latest/ug/what-is.html) for more details on this feature.
* SageMakerRuntime (3.3.1.0)
	* SageMaker Runtime supports CustomAttributes header which allows customers provide additional information in a request for an inference submitted to a model or in the response about the inference returned by a model hosted at an Amazon SageMaker endpoint.

### 3.3.349.0 (2018-08-28 19:43 UTC)
* Glue (3.3.12.0)
	* New Glue APIs for creating, updating, reading and deleting Data Catalog resource-based policies.
* XRay (3.3.3.0)
	* Support for new APIs that enable management of sampling rules.

### 3.3.348.0 (2018-08-27 22:49 UTC)
* IoT (3.3.17.0)
	* This release adds support to create a Stream and Code signing for Amazon FreeRTOS job along with Over-the-air updates.
* IoTAnalytics (3.3.4.0)
	* Added new listDatasetContent API that shows you the list of dataset contents for the corresponding versions
* Redshift (3.3.7.1)
	* Documentation updates for redshift
* signer (3.3.0.0)
	* AWS Signer is a new feature that allows Amazon FreeRTOS (AFR) Over The Air (OTA) customers to cryptographically sign code using code-signing certificates managed by AWS Certificate Manager. 
* Core 3.3.25.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.347.0 (2018-08-25 00:50 UTC)
* Glue (3.3.11.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.

### 3.3.346.0 (2018-08-24 17:52 UTC)
* CloudWatchEvents (3.3.6.0)
	* Added Fargate and NetworkConfiguration support to EcsParameters.
* CognitoIdentityProvider (3.3.11.0)
	* Amazon Cognito now has API support for creating custom domains for our hosted UI for User Pools.

### 3.3.345.0 (2018-08-24 00:12 UTC)
* S3 (3.3.21.0)
	* Implement support for user-specified byte-ranged in S3's GetObject (https://github.com/aws/aws-sdk-net/pull/999)
* Core 3.3.25.0
	* Allow specifying a proxy for HTTP downloads which are not related to service interaction

### 3.3.344.0 (2018-08-23 20:55 UTC)
* IoT (3.3.16.0)
	* This release adds support for IoT Thing Group Indexing and Searching functionality.
* IoTAnalytics (3.3.3.0)
	* AWS IoT Analytics announces three new features:  (1) Bring Your Custom Container - import your custom authored code containers. (2) Automate Container Execution - lets you automate the execution of containers hosting custom authored analytical code or Jupyter Notebooks to perform continuous analysis. (3) Incremental Data Capture with Customizable Time Windows - enables users to perform analysis on new incremental data captured since the last analysis.
* LexModelBuildingService (3.3.7.0)
	* Amazon Lex builds bot in two stages. After the first it sets status to READY_BASIC_TESTING. In this state the bot will match user inputs that exactly match the utterances configured for the bot's intents and values in the slot types. 
* MediaLive (3.3.8.0)
	* Adds two APIs for working with Channel Schedules: BatchUpdateSchedule and DescribeSchedule. These APIs allow scheduling actions for SCTE-35 message insertion and for static image overlays.
* Rekognition (3.3.9.0)
	* This release introduces a new API called DescribeCollection to Amazon Rekognition.  You can use DescribeCollection to get information about an existing face collection. Given the ID for a face collection, DescribeCollection returns the following information: the number of faces indexed into the collection, the version of the face detection model used by the collection, the Amazon Resource Name (ARN) of the collection and the creation date/time of the collection.

### 3.3.343.0 (2018-08-22 20:29 UTC)
* Snowball (3.3.4.0)
	* Snowball job states allow customers to track the status of the Snowball job. We are launching a new Snowball job state "WithSortingFacility"!  When customer returns the Snowball to AWS, the device first goes to a sorting facility before it reaches an AWS data center.  Many customers have requested us to add a new state to reflect the presence of the device at the sorting facility for better tracking. Today when a customer returns  the Snowball, the state first changes from "InTransitToAWS" to "WithAWS". With the addition of new state, the device will move from "InTransitToAWS" to "WithAWSSortingFacility", and then to "WithAWS".  There are no other changes to the API at this time besides adding this new state.

### 3.3.342.0 (2018-08-21 20:28 UTC)
* DLM (3.3.0.7)
	* Documentation updates for Lifecycle
* EC2 (3.3.59.0)
	* Added support for T3 Instance type in EC2. To learn more about T3 instances, please see https://aws.amazon.com/ec2/instance-types/t3/
* ElasticBeanstalk (3.3.10.0)
	* Elastic Beanstalk adds the "Privileged" field to the "CPUUtilization" type, to support enhanced health reporting in Windows environments.

### 3.3.341.0 (2018-08-20 21:11 UTC)
* DynamoDBv2 (3.3.13.0)
	* Added SSESpecification block to update-table command which allows users to modify table Server-Side Encryption. Added two new fields (SSEType and KMSMasterKeyId) to SSESpecification block used by create-table and update-table commands. Added new SSEDescription Status value UPDATING.

### 3.3.340.0 (2018-08-17 20:47 UTC)
* SageMaker (3.3.11.0)
	* Added an optional boolean parameter, 'DisassociateLifecycleConfig', to the UpdateNotebookInstance operation. When set to true, the lifecycle configuration associated with the notebook instance will be removed, allowing a new one to be set via a new 'LifecycleConfigName' parameter.
* SecretsManager (3.3.2.3)
	* Documentation updates for Secrets Manager

### 3.3.339.0 (2018-08-17 00:35 UTC)
* ApplicationDiscoveryService (3.3.4.0)
	* The Application Discovery Service's Continuous Export APIs allow you to analyze your on-premises server inventory data, including system performance and network dependencies, in Amazon Athena.
* MediaConvert (3.3.7.0)
	* Added WriteSegmentTimelineInRepresentation option for Dash Outputs
* Redshift (3.3.7.0)
	* You can now resize your Amazon Redshift cluster quickly. With the new ResizeCluster action, your cluster is available for read and write operations within minutes
* SimpleSystemsManagement (3.3.30.0)
	* AWS Systems Manager Inventory now supports groups to quickly see a count of which managed instances are and arent configured to collect one or more Inventory types

### 3.3.338.0 (2018-08-15 23:06 UTC)
* DeviceFarm (3.3.8.0)
	* Support for running tests in a custom environment with live logs/video streaming, full test features parity and reduction in overall test execution time.
* Core 3.3.24.8
	* We are launching AWS IoT Core and AWS IoT Device Mgmt in GovCloud (us-gov-west-1) region.


	* All services packages updated to require new Core

### 3.3.337.0 (2018-08-14 22:15 UTC)
* AutoScaling (3.3.5.0)
	* Add batch operations for creating/updating and deleting scheduled scaling actions.
* CloudFront (3.3.9.0)
	* Lambda@Edge Now Provides You Access to the Request Body for HTTP POST/PUT Processing. With this feature, you can now offload more origin logic to the edge and improve end-user latency. Developers typically use Web/HTML forms or Web Beacons/Bugs as a mechanism to collect data from the end users and then process that data at their origins servers. For example, if you are collecting end user behavior data through a web beacon on your website, you can use this feature to access the user behavior data and directly log it to an Amazon Kinesis Firehose endpoint from the Lambda function, thereby simplifying your origin infrastructure.
* Elasticsearch (3.3.8.0)
	* Amazon Elasticsearch Service adds support for no downtime, in-place upgrade for Elasticsearch version 5.1 and above.
* Core 3.3.24.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.336.0 (2018-08-13 23:00 UTC)
* SageMaker (3.3.10.0)
	* SageMaker updated the default endpoint URL to support Private Link via the CLI/SDK.

### 3.3.335.0 (2018-08-10 20:30 UTC)
* MediaConvert (3.3.6.0)
	* This release adds support for a new rate control mode, Quality-Defined Variable Bitrate (QVBR) encoding, includes updates to optimize transcoding performance, and resolves previously reported bugs.
* RDS (3.3.27.1)
	* Documentation updates for rds

### 3.3.334.0 (2018-08-09 22:10 UTC)
* DAX (3.3.1.0)
	* Add the SSESpecification field to CreateCluster to allow creation of clusters with server-side encryption, and add the SSEDescription field to DescribeClusters to display the status of server-side encryption for a cluster. 
* ECS (3.3.17.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for Docker volumes and Docker volume drivers. Customers can now configure their ECS Tasks to use Docker volumes, enabling stateful and storage-intensive applications to be deployed on ECS.
* RDS (3.3.27.0)
	* Launch RDS Aurora Serverless

### 3.3.333.0 (2018-08-08 20:29 UTC)
* SecretsManager (3.3.2.0)
	* This release introduces a ForceDeleteWithoutRecovery parameter to the DeleteSecret API enabling customers to force the deletion of a secret without any recovery window
* SimpleSystemsManagement (3.3.29.0)
	* AWS Systems Manager Automation is launching two new features for Automation Execution Rate Control based on tags and customized parameter maps. With the first feature, customer can target their resources by specifying a Tag with Key/Value. With the second feature, Parameter maps rate control, customers can benefit from customization of input parameters.

### 3.3.332.0 (2018-08-07 23:53 UTC)
* CloudWatchLogs (3.3.5.0)
	* Documentation Update
* CodeBuild (3.3.14.0)
	* Release semantic versioning feature for CodeBuild
* EC2 (3.3.58.0)
	* Amazon VPC Flow Logs adds support for delivering flow logs directly to S3
* Pinpoint (3.3.9.0)
	* This release includes a new batch API call for Amazon Pinpoint which can be used to update endpoints and submit events. This call will accept events from clients such as mobile devices and AWS SDKs. This call will accept requests which has multiple endpoints and multiple events attached to those endpoints in a single call. This call will update the endpoints attached and will ingest events for those endpoints. The response from this call will be a multipart response per endpoint/per event submitted.
* SimpleSystemsManagement (3.3.28.0)
	* Two new filters ExecutionStage and DocumentName will be added to ListCommands so that customers will have more approaches to query their commands.

### 3.3.331.0 (2018-08-06 22:16 UTC)
* AWSHealth (3.3.1.0)
	* Updates the ARN structure vended by AWS Health API. All ARNs will now include the service and type code of the associated event, as vended by DescribeEventTypes.
* DynamoDBv2 (3.3.12.0)
	*  Amazon DynamoDB Point-in-time recovery (PITR) provides continuous backups of your table data. DynamoDB now supports the ability to self-restore a deleted PITR enabled table. Now, when a table with PITR enabled is deleted, a system backup is automatically created and retained for 35 days (at no additional cost). System backups allow you to restore the deleted PITR enabled table to the state it was just before the point of deletion. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.330.2 (2018-08-03 22:18 UTC)
* DynamoDBv2 (3.3.11.2)
	* Updated to use new Core, version 3.3.24.6
	* Addressed DynamoDB inheritance issue. https://github.com/aws/aws-sdk-net/issues/906
* Core 3.3.24.6
	* This update addresses lock contention issues in DefaultInstanceProfileAWSCredentials and introduces nullable int fields in unmarshallers.
	* All services packages updated to require new Core

### 3.3.330.1 (2018-08-03 18:10 UTC)
* AlexaForBusiness (3.3.5.4)
	* Documentation updates for AWS Alexa For Business

### 3.3.330.0 (2018-08-02 20:22 UTC)
* Kinesis (3.3.6.0)
	* This version adds the foundation for future support of HTTP2-based event stream operations for Kinesis. The following operations have been added: DeregisterStreamConsumer, DescribeStreamConsumer, ListStreamConsumers, and RegisterStreamConsumer. The SubscribeToShard operation is not included in this release.
* Polly (3.3.7.0)
	* Amazon Polly enables female voice Aditi to speak Hindi language
* ResourceGroups (3.3.1.0)
	* AWS Resource Groups service added a new feature to filter group resources by resource-type when using the ListGroupResources operation.
* SimpleSystemsManagement (3.3.27.0)
	* This release updates AWS Systems Manager APIs to let customers create and use service-linked roles to register and edit Maintenance Window tasks.
* Core 3.3.24.5
	* AWS Greengrass is now available in the Dublin, Ireland (Europe) region, eu-west-1.


	* All services packages updated to require new Core

### 3.3.329.0 (2018-08-01 20:43 UTC)
* StorageGateway (3.3.10.0)
	* AWS Storage Gateway now enables you to create stored volumes with AWS KMS support.
* TranscribeService (3.3.3.0)
	* With this update Amazon Transcribe now supports channel identification. It transcribes audio from separate channels and combines them into a single transcription. 

### 3.3.328.0 (2018-07-31 19:57 UTC)
* Connect (3.3.1.0)
	* This update includes the new User Management APIs and the Federation API used for SAML authentication. The User Management APIs let you create and manage users in your Amazon Connect instance programmatically. The Federation API enables authentication between AWS and your existing identity provider using tokens.
* Elasticsearch (3.3.7.0)
	* Amazon Elasticsearch Service adds support for enabling Elasticsearch error logs, providing you valuable information for troubleshooting your Elasticsearch domains quickly and easily. These logs are published to the Amazon CloudWatch Logs service and can be turned on or off at will.
* IoT (3.3.15.0)
	* As part of this release we are introducing a new IoT security service, AWS IoT Device Defender, and extending capability of AWS IoT to support Step Functions rule action. The AWS IoT Device Defender is a fully managed service that helps you secure your fleet of IoT devices. For more details on this new service, go to https://aws.amazon.com/iot-device-defender. The Step Functions rule action lets you start an execution of AWS Step Functions state machine from a rule.
* KeyManagementService (3.3.6.0)
	* Added a KeyID parameter to the ListAliases operation. This parameter allows users to list only the aliases that refer to a particular AWS KMS customer master key. All other functionality remains intact.
* MediaConvert (3.3.5.0)
	* Fixes an issue with modeled timestamps being labeled with the incorrect format.

### 3.3.327.0 (2018-07-30 20:43 UTC)
* CloudHSMV2 (3.3.2.0)
	* This update  to the AWS CloudHSM API adds copy-backup-to-region, which allows you to copy a backup of a cluster from one region to another. The copied backup can be used in the destination region to create a new AWS CloudHSM cluster as a clone of the original cluster. 
* DirectConnect (3.3.6.0)
	* 1. awsDeviceV2 field is introduced for Connection/Lag/Interconnect/VirtualInterface/Bgp Objects, while deprecating the awsDevice field for Connection/Lag/Interconnect Objects. 2. region field is introduced for VirtualInterface/Location objects 
* Glacier (3.3.2.13)
	* Documentation updates for glacier
* Glue (3.3.10.0)
	* Glue Development Endpoints now support association of multiple SSH public keys with a development endpoint.
* IoT (3.3.14.0)
	* get rid of documentParameters field from CreateJob API
* MQ (3.3.1.0)
	* Modified the CreateBroker, UpdateBroker, and DescribeBroker operations to support integration with Amazon CloudWatch Logs. Added a field to indicate the IP address(es) that correspond to wire-level endpoints of broker instances. While a single-instance broker has one IP address, an active/standby broker for high availability has 2 IP addresses. Added fields to indicate the time when resources were created. Updated documentation for Amazon MQ.
* SageMaker (3.3.9.0)
	* Added SecondaryStatusTransitions to DescribeTrainingJob to provide more visibility into SageMaker training job progress and lifecycle.

### 3.3.326.0 (2018-07-26 21:59 UTC)
* CodeBuild (3.3.13.0)
	* Add artifacts encryptionDisabled and build encryptionKey.
* EC2 (3.3.57.0)
	* This change provides the EC2/Spot customers with two new allocation strategies -- LowestN for Spot instances, and OD priority for on-demand instances.
* Greengrass (3.3.3.8)
	* Documentation updates for Greengrass Local Resource Access feature
* Inspector (3.3.7.0)
	* inspector will return ServiceTemporarilyUnavailableException when service is under stress
* Redshift (3.3.6.0)
	* When we make a new version of Amazon Redshift available, we update your cluster during its maintenance window. By selecting a maintenance track, you control whether we update your cluster with the most recent approved release, or with the previous release. The two values for maintenance track are current and trailing. If you choose the current track, your cluster is updated with the latest approved release. If you choose the trailing track, your cluster is updated with the release that was approved previously.The new API operation for managing maintenance tracks for a cluster is DescribeClusterTracks. In addition, the following API operations have new MaintenanceTrackName parameters:  Cluster,  PendingModifiedValues,  ModifyCluster,  RestoreFromClusterSnapshot,  CreateCluster,  Snapshot
* SimpleSystemsManagement (3.3.26.0)
	* This release updates AWS Systems Manager APIs to allow customers to attach labels to history parameter records and reference history parameter records via labels.  It also adds Parameter Store integration with AWS Secrets Manager to allow referencing and retrieving AWS Secrets Manager's secrets from Parameter Store.

### 3.3.325.0 (2018-07-25 21:26 UTC)
* EC2 (3.3.56.0)
	* R5 is the successor to R4 in EC2's memory-optimized instance family. R5d is a variant of R5 that has local NVMe SSD. Z1d instances deliver both high compute and high memory. Z1d instances use custom Intel Xeon Scalable Processors running at up to 4.0 GHz, powered by sustained all-core Turbo Boost. They are available in 6 sizes, with up to 48 vCPUs, 384 GiB of memory, and 1.8 TB of local NVMe storage.
* ECS (3.3.16.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for private registry authentication using AWS Secrets Manager. With private registry authentication, private Docker images can be used in a task definition.
* ElasticLoadBalancingV2 (3.3.10.0)
	* We are introducing two new actions in Application Load Balancer. Redirects and Fixed Response. These features will allow you to improve user experience and security posture. By using redirect actions in your Application Load Balancer, you can improve the security of your user requests and by using fixed-response, you can enhance the customer experience by displaying branded error pages during application maintenance or outages.

### 3.3.324.0 (2018-07-24 21:54 UTC)
* DynamoDBv2 (3.3.11.0)
	* With this SDK update, APIs UpdateGlobalTableSettings and DescribeGlobalTableSettings now allow consistently configuring AutoScaling settings for a DynamoDB global table. Previously, they would only allow consistently setting IOPS. Now new APIs are being released, existing APIs are being extended.

### 3.3.323.0 (2018-07-23 21:04 UTC)
* CognitoSync (3.3.1.36)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* DynamoDBv2 (3.3.10.4)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* IdentityManagement (3.3.7.1)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Kinesis (3.3.5.10)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* KinesisFirehose (3.3.5.5)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Lambda (3.3.15.1)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* MobileAnalytics (3.3.1.33)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* S3 (3.3.20.0)
	* Updated to use new Core, version 3.3.24.4
	* Amazon S3 Select is an Amazon S3 feature that makes it easy to retrieve specific data from the contents of an object using simple SQL expressions without having to retrieve the entire object. With this release of the Amazon S3 SDK, S3 Select API (SelectObjectContent) is now generally available in all public regions. This release supports retrieval of a subset of data using SQL clauses, like SELECT and WHERE, from delimited text files and JSON objects in Amazon S3 through the SelectObjectContent API available in AWS S3 SDK.
Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.
* SimpleEmail (3.3.6.12)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* SQS (3.3.3.12)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Core 3.3.24.4
	* Add AsyncRunner.cs back for users that upgraded AWSSDK.Core but haven't updated the corresponding service packages like AWSSDK.DynamoDBv2 which used AsyncRunner from Core in older versions of the package.
	* All services packages updated to require new Core

### 3.3.322.0 (2018-07-20 20:23 UTC)
* ConfigService (3.3.19.0)
	* Setting internal length limits on resourceId for APIs.  
* DLM (3.3.0.1)
	* Update documentation for Amazon Data Lifecycle Manager.

### 3.3.321.0 (2018-07-19 20:20 UTC)
* MediaPackage (3.3.2.0)
	* Adds support for DASH OriginEnpoints with multiple media presentation description periods triggered by presence of SCTE-35 ad markers in Channel input streams.

### 3.3.320.0 (2018-07-18 21:37 UTC)
* IoTAnalytics (3.3.2.0)
	* This change allows publishing of channel/datastore size as part of the describe-channel/describe-datastore APIs. We introduce an optional boolean parameter 'includeStatistics' in the Describe request. If the user sets this parameter to true, the describe response will return the resource size and timestamp at which the size was recorded. If the parameter is set to false, the size won't be computed or returned.

### 3.3.319.0 (2018-07-17 15:32 UTC)
* Comprehend (3.3.2.0)
	* This release gives customers the ability to tokenize (find word boundaries) text and for each word provide a label for the part of speech, using the DetectSyntax operation. This API is useful to analyze text for specific conditions like for example finding nouns and the correlating adjectives to understand customer feedback. 
* Polly (3.3.6.0)
	* Amazon Polly adds new API for asynchronous synthesis to S3
* SageMaker (3.3.8.0)
	* Amazon SageMaker has added the capability for customers to run fully-managed, high-throughput batch transform machine learning models with a simple API call. Batch Transform is ideal for high-throughput workloads and predictions in non-real-time scenarios where data is accumulated over a period of time for offline processing.
* Snowball (3.3.3.0)
	* AWS Snowball Edge announces the availability of Amazon EC2 compute instances that run on the device. AWS Snowball Edge is a 100-TB ruggedized device built to transfer data into and out of AWS with optional support for local Lambda-based compute functions. With this feature, developers and administrators can run their EC2-based applications on the device providing them with an end to end vertically integrated AWS experience. Designed for data pre-processing, compression, machine learning, and data collection applications, these new instances, called SBE1 instances, feature 1.8 GHz Intel Xeon D processors up to 16 vCPUs, and 32 GB of memory. The SBE1 instance type is available in four sizes and multiple instances can be run on the device at the same time. Customers can now run compute instances using the same Amazon Machine Images (AMIs) that are used in Amazon EC2.

### 3.3.318.0 (2018-07-13 21:47 UTC)
* AppStream (3.3.16.0)
	* This API update adds support for sharing AppStream images across AWS accounts within the same region.
* KinesisVideo (3.3.1.0)
	* Adds support for HLS video playback of Kinesis Video streams using the KinesisVideo client by including "GET_HLS_STREAMING_SESSION_URL" as an additional APIName parameter in the GetDataEndpoint input.
* KinesisVideoArchivedMedia (3.3.1.0)
	* Adds support for HLS video playback of Kinesis Video streams by providing the GetHLSStreamingSessionURL function in the KinesisVideoArchivedMedia client.

### 3.3.317.0 (2018-07-12 20:44 UTC)
* AppSync (3.3.3.0)
	* This release adds support for configuring HTTP  endpoints as data sources for your AWS AppSync GraphQL API.
* DLM (3.3.0.0)
	* Amazon Data Lifecycle Manager (DLM) for EBS Snapshots provides a simple, automated way to back up data stored on Amazon EBS volumes. You can define backup and retention schedules for EBS snapshots by creating lifecycle policies based on tags. With this feature, you no longer have to rely on custom scripts to create and manage your backups. This feature is now available in the US East (N. Virginia), US West (Oregon), and Europe (Ireland) AWS regions at no additional cost.
* ElasticFileSystem (3.3.2.0)
	* Amazon EFS now allows you to instantly provision the throughput required for your applications independent of the amount of data stored in your file system, allowing you to optimize throughput for your applications performance needs. Starting today, you can provision the throughput your applications require quickly with a few simple steps using AWS Console, AWS CLI or AWS API to achieve consistent performance.
* ElasticMapReduce (3.3.5.10)
	* Documentation updates for EMR.
* IdentityManagement (3.3.7.0)
	* SDK release to support IAM delegated administrator feature. The feature lets customers attach permissions boundary to IAM principals. The IAM principals cannot operate exceeding the permission specified in permissions boundary.

### 3.3.316.0 (2018-07-11 21:44 UTC)
* APIGateway (3.3.19.0)
	* Support for fine grain throttling for API gateway. 
* CostExplorer (3.3.6.0)
	* Starting today, you can access custom Reserved Instance (RI) purchase recommendations for your Amazon Redshift, Amazon ElastiCache, and Amazon Elasticsearch reservations via AWS Cost Explorer API, in addition to accessing RI purchase recommendations for your Amazon EC2 and Amazon RDS reservations.
* S3 (3.3.19.0)
	* S3 Select support for BZIP2 compressed input files
* SimpleSystemsManagement (3.3.25.0)
	* Support Conditional Branching OnFailure for SSM Automation

### 3.3.315.0 (2018-07-10 21:11 UTC)
* AppStream (3.3.15.0)
	* This API update adds pagination to the DescribeImages API to support future features and enhancements.
* CodeBuild (3.3.12.0)
	* API changes to CodeBuild service, support report build status for Github sources
* EC2 (3.3.55.0)
	* Support CpuOptions field in Launch Template data and allow Launch Template name to contain hyphen.
* Glue (3.3.9.0)
	* AWS Glue adds the ability to crawl DynamoDB tables.
* OpsWorks (3.3.3.10)
	* Documentation updates for AWS OpsWorks Stacks.

### 3.3.314.1 (2018-07-10 01:40 UTC)
* ApplicationAutoScaling (3.3.10.1)
	* Documentation updates for application-autoscaling

### 3.3.314.0 (2018-07-09 20:26 UTC)
* ApplicationAutoScaling (3.3.10.0)
	* The release adds support for custom resource auto scaling.
* CostExplorer (3.3.5.0)
	* AWS Cost Explorer provides you with Reserved Instance (RI) purchase recommendations based on your total cross-account Amazon EC2 and Amazon RDS usage. Starting today, linked accounts can also access custom RI purchase recommendations for specific linked accounts directly via AWS Cost Explorer API.
* DatabaseMigrationService (3.3.8.0)
	* Added support for DmsTransfer endpoint type and support for re-validate option in table reload API.
* Lambda (3.3.15.0)
	* Add support for .NET Core 2.1 to Lambda.
* TranscribeService (3.3.2.0)
	* You can now specify an Amazon S3 output bucket to store the transcription of your audio file when you call the StartTranscriptionJob operation. 

### 3.3.313.0 (2018-07-06 17:41 UTC)
* MediaConvert (3.3.4.0)
	* This release adds support for the following 1) users can specify tags to be attached to queues, presets, and templates during creation of those resources on MediaConvert. 2) users can now view the count of jobs in submitted state and in progressing state on a per queue basis.
* ServerlessApplicationRepository (3.3.2.0)
	* Added required fields and documentation updates for AWS Serverless Application Repository.

### 3.3.312.0 (2018-07-05 21:15 UTC)
* Pinpoint (3.3.8.0)
	* This release of the Amazon Pinpoint SDK adds the ability to create complex segments and validate phone numbers for SMS messages. It also adds the ability to get or delete endpoints based on user IDs, remove attributes from endpoints, and list the defined channels for an app.
* SageMaker (3.3.7.0)
	* Amazon SageMaker NotebookInstances supports 'Updating' as a NotebookInstanceStatus.  In addition, DescribeEndpointOutput now includes Docker repository digest of deployed Model images.

### 3.3.311.0 (2018-07-03 20:11 UTC)
* EC2 (3.3.54.0)
	* Added support for customers to tag EC2 Dedicated Hosts
* Redshift (3.3.5.0)
	* Feature 1 - On-demand cluster release version - When Amazon Redshift releases a new cluster version, you can choose to upgrade to that version immediately instead of waiting until your next maintenance window. You can also choose to roll back to a previous version. The two new APIs added for managing cluster release version are - ModifyClusterDbRevision, DescribeClusterDbRevisions. Feature 2 - Upgradeable reserved instance - You can now exchange one Reserved Instance for a new Reserved Instance with no changes to the terms of your existing Reserved Instance (term, payment type, or number of nodes). The two new APIs added for managing these upgrades are - AcceptReservedNodeExchange, GetReservedNodeExchangeOfferings. 
* Core 3.3.24.3
	* General availability of AWS Lambda in the China Northwest (cn-northwest-1) region. For more information, see the AWS Lambda developer guide.


	* All services packages updated to require new Core

### 3.3.310.0 (2018-07-02 20:51 UTC)
* SimpleSystemsManagement (3.3.24.0)
	* Execution History and StartAssociationOnce release for State Manager. Users now have the ability to view association execution history with DescribeAssociationExecutions and DescribeAssociationExecutionTargets. Users can also execute an association by calling StartAssociationOnce.

### 3.3.309.0 (2018-06-28 21:13 UTC)
* ElasticBeanstalk (3.3.9.0)
	* Elastic Beanstalk adds "Suspended" health status to the EnvironmentHealthStatus enum type and updates document.
* Lambda (3.3.14.0)
	* Support for SQS as an event source.
* StorageGateway (3.3.9.0)
	* AWS Storage Gateway now enables you to use Server Message Block (SMB) protocol  to store and access objects in Amazon Simple Storage Service (S3). 

### 3.3.308.0 (2018-06-27 22:08 UTC)
* CloudFront (3.3.8.0)
	* Unpublish delete-service-linked-role API.
* CodePipeline (3.3.5.0)
	* UpdatePipeline may now throw a LimitExceededException when adding or updating Source Actions that use periodic checks for change detection
* Comprehend (3.3.1.0)
	* This release gives customers the option to batch process a set of documents stored within an S3 bucket in addition to the existing synchronous nature of the current Comprehend API.
* SecretsManager (3.3.1.1)
	* Documentation updates for secretsmanager

### 3.3.307.0 (2018-06-26 22:24 UTC)
* Inspector (3.3.6.0)
	* Introduce four new APIs to view and preview Exclusions.  Exclusions show which intended security checks are excluded from an assessment, along with reasons and recommendations to fix.  The APIs are CreateExclusionsPreview, GetExclusionsPreview, ListExclusions, and DescribeExclusions.
* SecretsManager (3.3.1.0)
	* This release adds support for resource-based policies that attach directly to your secrets. These policies provide an additional way to control who can access your secrets and what they can do with them. For more information, see https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html in the Secrets Manager User Guide.

### 3.3.306.0 (2018-06-22 22:01 UTC)
* AlexaForBusiness (3.3.5.0)
	*  Introduce DeviceNotRegisteredException for AWSMoneypenny
* AppStream (3.3.14.0)
	* This API update enables customers to find their VPC private IP address and ENI ID associated with AppStream streaming sessions.
* Core 3.3.24.2
	* General availability release of Amazon Translate in the GovCloud West (us-gov-west-1) region. For more information, see the Amazon Translate developer guide.


	* All services packages updated to require new Core

### 3.3.305.0 (2018-06-21 23:29 UTC)
* CloudDirectory (3.3.9.0)
	* SDK release to support Flexible Schema initiative being carried out by Amazon Cloud Directory. This feature lets customers using new capabilities like: variant typed attributes, dynamic facets and AWS managed Cloud Directory schemas.

### 3.3.304.0 (2018-06-21 20:16 UTC)
* Macie (3.3.0.0)
	* Amazon Macie is a security service that uses machine learning to automatically discover, classify, and protect sensitive data in AWS. With this release, we are launching the following Macie HTTPS API operations: AssociateMemberAccount, AssociateS3Resources, DisassociateMemberAccount, DisassociateS3Resources, ListMemberAccounts, ListS3Resources, and UpdateS3Resources. With these API operations you can issue HTTPS requests directly to the service.
* Neptune (3.3.2.0)
	* Deprecates the PubliclyAccessible parameter that is not supported by Amazon Neptune.
* SimpleSystemsManagement (3.3.23.0)
	* Adds Amazon Linux 2 support to Patch Manager

### 3.3.303.0 (2018-06-20 20:09 UTC)
* ACMPCA (3.3.1.0)
	* CA Restore is a new feature within AWS Certificate Manager Private Certificate Authority (ACM PCA) that allows you to restore a private certificate authority that has been deleted. When you issue the DeleteCertificateAuthority call, you can now specify the number of days (7-30, with 30 being the default) in which the private certificate authority will remain in the DELETED state. During this time, the private certificate authority can be restored with the RestoreCertificateAuthority API call and then be returned to the PENDING_CERTIFICATE or DISABLED state, depending upon the state prior to deletion.  Summary of API Changes: 1). Added RestoreCertificateAuthority API call; 2). Added optional PermanentDeletionTimeInDays parameter to DeleteCertificateAuthority API call. If this parameter is not specified, the DeleteCertificateAuthority API call will use a 30 day restore period as default.
* MediaLive (3.3.7.0)
	* AWS Elemental MediaLive now makes Reserved Outputs and Inputs available through the AWS Management Console and API. You can reserve outputs and inputs with a 12 month commitment in exchange for discounted hourly rates. Pricing is available at https://aws.amazon.com/medialive/pricing/
* RDS (3.3.26.0)
	* This release adds a new parameter to specify the retention period for Performance Insights data for RDS instances. You can either choose 7 days (default) or 731 days. For more information, see Amazon RDS Documentation.

### 3.3.302.1 (2018-06-19 20:24 UTC)
* Rekognition (3.3.8.8)
	* Documentation updates for rekognition
* Core 3.3.24.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.302.0 (2018-06-19 02:26 UTC)
* Neptune (3.3.1.0)
	* Fixed Neptune with correct service model.

### 3.3.301.0 (2018-06-15 23:50 UTC)
* MediaConvert (3.3.3.0)
	* This release adds language code support according to the ISO-639-3 standard. Custom 3-character language codes are now supported on input and output for both audio and captions.

### 3.3.300.0 (2018-06-14 22:16 UTC)
* APIGateway (3.3.18.0)
	* Support for PRIVATE endpoint configuration type
* DynamoDBv2 (3.3.10.0)
	* Added two new fields SSEType and KMSMasterKeyArn to SSEDescription block in describe-table output.
* IoTAnalytics (3.3.1.0)
	* With this release, AWS IoT Analytics allows you to tag resources. Tags are metadata that you can create and use to manage your IoT Analytics resources. For more information about tagging, see AWS Tagging Strategies. For technical documentation, look for the tagging operations in the AWS IoT Analytics API reference or User Guide.

### 3.3.299.0 (2018-06-13 22:32 UTC)
* ServiceCatalog (3.3.10.0)
	* Introduced new length limitations for few of the product fields.
* SimpleSystemsManagement (3.3.22.0)
	* Added support for new parameter, CloudWatchOutputConfig, for SendCommand API. Users can now have RunCommand output sent to CloudWatchLogs.

### 3.3.298.0 (2018-06-12 21:29 UTC)
* DeviceFarm (3.3.7.0)
	* Adding VPCEndpoint support for Remote access. Allows customers to be able to access their private endpoints/services running in their VPC during remote access.
* ECS (3.3.15.0)
	* Introduces daemon scheduling capability to deploy one task per instance on selected instances in a cluster.  Adds a "force" flag to the DeleteService API to delete a service without requiring to scale down the number of tasks to zero.

### 3.3.297.0 (2018-06-11 21:08 UTC)
* CloudDirectory (3.3.8.0)
	* Amazon Cloud Directory now supports optional attributes on Typed Links, giving users the ability to associate and manage data on Typed Links. 
* RDS (3.3.25.1)
	* Changed lists of valid EngineVersion values to links to the RDS User Guide.
* StorageGateway (3.3.8.0)
	*  AWS Storage Gateway now enables you to create cached volumes and tapes with AWS KMS support.

### 3.3.296.0 (2018-06-09 01:01 UTC)
* DynamoDBv2 (3.3.9.0)
	* Updated to use new Core, version 3.3.24.0
	* Removed AsyncRunner usage for async paths in DynamoDB DataModel and DocumentModel APIs - PR https://github.com/aws/aws-sdk-net/pull/896
* Core 3.3.24.0
	* DotnetCLI fix for BaseIntermediateOutputPath.
	* Replace EC2 instance profile credentials resolver in the credentials fallback chain with a new singleton implementation.
* AWSSDK.Extensions.NETCore.Setup (3.3.6)
	* Support for TryAddAWSService - PR https://github.com/aws/aws-sdk-net/pull/935


### 3.3.295.0 (2018-06-08 17:41 UTC)
* MediaTailor (3.3.1.0)
	* Fixes a bug in the request URIs for MediaTailor PlaybackConfiguration operations.

### 3.3.294.0 (2018-06-07 22:10 UTC)
* MediaLive (3.3.6.0)
	* AWS Elemental MediaLive now makes channel log information available through Amazon CloudWatch Logs. You can set up each MediaLive channel with a logging level; when the channel is run, logs will automatically be published to your account on Amazon CloudWatch Logs

### 3.3.293.0 (2018-06-05 22:44 UTC)
* CostExplorer (3.3.4.0)
	* Cost Explorer API is providing programmatic access to RI saving metrics to enable customers to optimize their reservations.
* Polly (3.3.5.0)
	* Amazon Polly adds new French voice - "Lea"
* RDS (3.3.25.0)
	* This release adds customizable processor features for RDS instances.
* SecretsManager (3.3.0.10)
	* Documentation updates for secretsmanager
* Shield (3.3.2.0)
	* DDoS Response Team access management for AWS Shield

### 3.3.292.0 (2018-06-04 21:50 UTC)
* AppStream (3.3.13.0)
	* Amazon AppStream 2.0 adds support for Google Drive for G Suite. With this feature, customers will be able to connect their G Suite accounts with AppStream 2.0 and enable Google Drive access for an AppStream 2.0 stack. Users of the stack can then link their Google Drive using their G Suite login credentials and use their existing files stored in Drive with their AppStream 2.0 applications. File changes will be synced automatically to Google cloud. 
* EC2 (3.3.53.0)
	* You are now able to use instance storage (up to 3600 GB of NVMe based SSD) on M5 instances, the next generation of EC2's General Purpose instances in us-east-1, us-west-2, us-east-2, eu-west-1 and ca-central-1. M5 instances offer up to 96 vCPUs, 384 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes and provide a balance of compute, memory and network resources for many applications.
* EKS (3.3.0.0)
	* Amazon Elastic Container Service for Kubernetes (Amazon EKS) is a fully managed service that makes it easy to deploy, manage, and scale containerized applications using Kubernetes on AWS. Amazon EKS runs the Kubernetes control plane for you across multiple AWS availability zones to eliminate a single point of failure. Amazon EKS is certified Kubernetes conformant so you can use existing tooling and plugins from partners and the Kubernetes community. Applications running on any standard Kubernetes environment are fully compatible and can be easily migrated to Amazon EKS. 
* MediaConvert (3.3.2.0)
	* This release adds the support for Common Media Application Format (CMAF) fragmented outputs, RF64 WAV audio output format, and HEV1 or HEVC1 MP4 packaging types when using HEVC in DASH or CMAF outputs.
* MigrationHub (3.3.1.6)
	* Documentation updates for AWS Migration Hub
* SageMaker (3.3.6.0)
	* Amazon SageMaker has added the ability to run hyperparameter tuning jobs. A hyperparameter tuning job will create and evaluate multiple training jobs while tuning algorithm hyperparameters, to optimize a customer specified objective metric.

### 3.3.291.0 (2018-06-01 20:07 UTC)
* DirectoryService (3.3.5.0)
	* Added ResetUserPassword API. Customers can now reset their users' passwords without providing the old passwords in Simple AD and Microsoft AD.
* IoT (3.3.13.0)
	* We are releasing force CancelJob and CancelJobExecution functionalities to customers.
* MediaTailor (3.3.0.0)
	* AWS Elemental MediaTailor is a personalization and monetization service that allows scalable server-side ad insertion. The service enables you to serve targeted ads to viewers while maintaining broadcast quality in over-the-top (OTT) video applications. This SDK allows user access to the AWS Elemental MediaTailor configuration interface.
* Redshift (3.3.4.5)
	* Documentation updates for redshift
* SimpleNotificationService (3.3.1.0)
	* The SNS Subscribe API has been updated with two new optional parameters: Attributes and ReturnSubscriptionArn. Attributes is a map of subscription attributes which can be one or more of: FilterPolicy, DeliveryPolicy, and RawMessageDelivery. ReturnSubscriptionArn is a boolean parameter that overrides the default behavior of returning "pending confirmation" for subscriptions that require confirmation instead of returning the subscription ARN.
* Core 3.3.23.1
	* SageMaker has added support for the Asia Pacific (Tokyo) region.


	* All services packages updated to require new Core

### 3.3.290.0 (2018-05-31 01:19 UTC)
* ElasticLoadBalancingV2 (3.3.9.0)
	* This release of Elastic Load Balancing introduces user authentication on Application Load Balancer.
* Neptune (3.3.0.0)
	* Amazon Neptune is a fast, reliable graph database service that makes it easy to build and run applications that work with highly connected datasets. Neptune supports popular graph models Property Graph and W3C's Resource Description Frame (RDF), and their respective query languages Apache TinkerPop Gremlin 3.3.2 and SPARQL 1.1. 
* Core 3.3.23.0
	* Updated service.json with the canonical.

### 3.3.289.0 (2018-05-29 20:00 UTC)
* PI (3.3.0.0)
	* Performance Insights is a feature of Amazon Relational Database Service (RDS) that helps you quickly assess the load on your database, and determine when and where to take action. You can use the SDK to retrieve Performance Insights data and integrate your monitoring solutions.

### 3.3.288.0 (2018-05-25 21:36 UTC)
* AppStream (3.3.12.0)
	* This API update enables customers to control whether users can transfer data between their local devices and their streaming applications through file uploads and downloads, clipboard operations, or printing to local devices
* ConfigService (3.3.18.0)
	* AWS Config adds support for retention period, allowing you to specify a retention period for your AWS Config configuration items.
* Glue (3.3.8.0)
	* AWS Glue now sends a delay notification to Amazon CloudWatch Events when an ETL job runs longer than the specified delay notification threshold.
* IoT (3.3.12.0)
	* We are exposing DELETION_IN_PROGRESS as a new job status in regards to the release of DeleteJob API.

### 3.3.287.0 (2018-05-24 21:56 UTC)
* CodeBuild (3.3.11.0)
	* AWS CodeBuild Adds Support for Windows Builds.
* ElasticLoadBalancingV2 (3.3.8.7)
	* Updated elasticloadbalancingV2 documentation with slow start mode details.  The slow start mode can be used to gradually increase the number of requests forwarded by a load balancer to a newly added target in a target group. It provides a new target an opportunity to warm up before it can handle its fair share of requests received from the load balancer. Slow start mode is disabled by default and can be enabled on a per target group basis.
* RDS (3.3.24.0)
	* This release adds CloudWatch Logs integration capabilities to RDS Aurora MySQL clusters
* SecretsManager (3.3.0.8)
	* Documentation updates for secretsmanager

### 3.3.286.0 (2018-05-22 22:09 UTC)
* ECS (3.3.14.0)
	* Amazon Elastic Container Service (ECS) adds service discovery for services that use host or bridged network mode. ECS can now also register instance IPs for active tasks using bridged and host networking with Route 53, making them available via DNS.
* Inspector (3.3.5.0)
	* We are launching the ability to target all EC2 instances. With this launch, resourceGroupArn is now optional for CreateAssessmentTarget and UpdateAssessmentTarget. If resourceGroupArn is not specified, all EC2 instances in the account in the AWS region are included in the assessment target.

### 3.3.285.0 (2018-05-21 20:17 UTC)
* CloudFormation (3.3.11.0)
	* 1) Filtered Update for StackSet based on Accounts and Regions: This feature will allow flexibility for the customers to roll out updates on a StackSet based on specific Accounts and Regions.   2) Support for customized ExecutionRoleName: This feature will allow customers to attach ExecutionRoleName to the StackSet thus ensuring more security and controlling the behavior of any AWS resources in the target accounts.

### 3.3.284.0 (2018-05-18 20:27 UTC)
* IoT (3.3.11.0)
	* We are releasing DeleteJob and DeleteJobExecution APIs to allow customer to delete resources created using AWS IoT Jobs.
* SimpleEmail (3.3.6.7)
	* Fixed a broken link in the documentation for S3Action.

### 3.3.283.0 (2018-05-17 21:36 UTC)
* CodeDeploy (3.3.10.1)
	* Documentation updates for codedeploy
* CognitoIdentityProvider (3.3.10.0)
	* Amazon Cognito User Pools now supports federation for users to sign up and sign in with any identity provider following the OpenID Connect standard. Amazon Cognito User Pools now returns the User Pool's Amazon Resource Name (ARN) from the CreateUserPool, UpdateUserPool, and DescribeUserPool APIs.
* EC2 (3.3.52.0)
	* You are now able to use instance storage (up to 1800 GB of NVMe based SSD) on C5 instances, the next generation of EC2's compute optimized instances in us-east-1, us-west-2, us-east-2, eu-west-1 and ca-central-1. C5 instances offer up to 72 vCPUs, 144 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes to deliver improved performance for compute-intensive workloads.You can now run bare metal workloads on EC2 with i3.metal instances. As a new instance size belonging to the I3 instance family, i3.metal instances have the same characteristics as other instances in the family, including NVMe SSD-backed instance storage optimized for low latency, very high random I/O performance, and high sequential read throughput. I3.metal instances are powered by 2.3 GHz Intel Xeon processors, offering 36 hyper-threaded cores (72 logical processors), 512 GiB of memory, and 15.2 TB of NVMe SSD-backed instance storage. These instances deliver high networking throughput and lower latency with up to 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking.

### 3.3.282.0 (2018-05-16 18:29 UTC)
* SecretsManager (3.3.0.7)
	* Documentation updates for secretsmanager
* ServiceCatalog (3.3.9.0)
	* Users can now pass a new option to ListAcceptedPortfolioShares called portfolio-share-type with a value of AWS_SERVICECATALOG in order to access Getting Started Portfolios that contain selected products representing common customer use cases.

### 3.3.281.0 (2018-05-15 18:32 UTC)
* ConfigService (3.3.17.0)
	* Update ResourceType enum with values for XRay resource

### 3.3.280.0 (2018-05-14 22:26 UTC)
* CodeBuild (3.3.10.0)
	* Adding support for more override fields for StartBuild API, add support for idempotency token field  for StartBuild API in AWS CodeBuild.
* IoT1ClickDevicesService (3.3.0.0)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/
* IoT1ClickProjects (3.3.0.0)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/.
* Organizations (3.3.8.4)
	* Documentation updates for organizations

### 3.3.279.0 (2018-05-10 23:22 UTC)
* KinesisFirehose (3.3.5.0)
	* With this release, Amazon Kinesis Data Firehose can convert the format of your input data from JSON to Apache Parquet or Apache ORC before storing the data in Amazon S3. Parquet and ORC are columnar data formats that save space and enable faster queries compared to row-oriented formats like JSON.

### 3.3.278.0 (2018-05-10 19:29 UTC)
* GameLift (3.3.12.0)
	* AutoScaling Target Tracking scaling simplification along with StartFleetActions and StopFleetActions APIs to suspend and resume automatic scaling at will.

### 3.3.277.0 (2018-05-10 01:03 UTC)
* Budgets (3.3.9.0)
	* Updating the regex for the NumericValue fields.
* EC2 (3.3.51.0)
	* Enable support for latest flag with Get Console Output
* RDS (3.3.23.0)
	* Changes to support the Aurora MySQL Backtrack feature.
* Core 3.3.22.5
	* With this release, we're adding support for ap-south-1 AWS region.



### 3.3.276.0 (2018-05-08 17:27 UTC)
* EC2 (3.3.50.0)
	* Enable support for specifying CPU options during instance launch.
* RDS (3.3.22.3)
	* Correction to the documentation about copying unencrypted snapshots.
* Core 3.3.22.4
	* Lightsail is now available in regions eu-west-3, ap-northeast-2 and ca-central-1. 



### 3.3.275.0 (2018-05-07 21:40 UTC)
* AlexaForBusiness (3.3.4.0)
	* This release adds the new Device status "DEREGISTERED". This release also adds DEVICE_STATUS as the new DeviceEventType.
* Budgets (3.3.8.0)
	* "With this release, customers can use AWS Budgets to monitor how much of their Amazon EC2, Amazon RDS, Amazon Redshift, and Amazon ElastiCache instance usage is covered by reservations, and receive alerts when their coverage falls below the threshold they define."
* Elasticsearch (3.3.6.0)
	* This change brings support for Reserved Instances to AWS Elasticsearch.

### 3.3.274.0 (2018-05-04 20:08 UTC)
* GuardDuty (3.3.4.0)
	* Amazon GuardDuty is adding five new API operations for creating and managing filters. For each filter, you can specify a criteria and an action. The action you specify is applied to findings that match the specified criteria.

### 3.3.273.0 (2018-05-04 00:00 UTC)
* AppSync (3.3.2.0)
	* This release adds support for authorizing your AWS AppSync endpoint with an OpenID Connect compliant service and also to configure your AWS AppSync endpoint to log requests to Amazon CloudWatch Logs.
* ConfigService (3.3.16.0)
	* Update ResourceType enum with values for Lambda, ElasticBeanstalk, WAF and ElasticLoadBalancing resources
* SecretsManager (3.3.0.6)
	* Documentation updates for secretsmanager
* Core 3.3.22.3
	* Amazon WorkSpaces is now available in ca-central-1



### 3.3.272.0 (2018-05-02 23:23 UTC)
* CertificateManager (3.3.5.3)
	* Documentation updates for acm
* CodePipeline (3.3.4.0)
	* Added support for webhooks with accompanying definitions as needed in the AWS CodePipeline API Guide.
* EC2 (3.3.49.0)
	* Amazon EC2 Fleet is a new feature that simplifies the provisioning of Amazon EC2 capacity across different EC2 instance types, Availability Zones, and the On-Demand, Reserved Instance, and Spot Instance purchase models. With a single API call, you can now provision capacity to achieve desired scale, performance, and cost.
* SimpleSystemsManagement (3.3.21.0)
	* Added support for new parameter, DocumentVersion, for SendCommand API. Users can now specify version of SSM document to be executed on the target(s).

### 3.3.271.0 (2018-04-30 23:05 UTC)
* AlexaForBusiness (3.3.3.0)
	* Adds ListDeviceEvents API to get a paginated list of device events (such as ConnectionStatus). This release also adds ConnectionStatus field to GetDevice and SearchDevices API.
* DynamoDBv2 (3.3.8.0)
	* Adds two new APIs UpdateGlobalTableSettings and DescribeGlobalTableSettings. This update introduces new constraints in the CreateGlobalTable and UpdateGlobalTable APIs . Tables must have the same write capacity units. If Global Secondary Indexes exist then they must have the same write capacity units and key schema.
* GuardDuty (3.3.3.0)
	* You can disable the email notification when inviting GuardDuty members using the disableEmailNotification parameter in the InviteMembers operation.
* Route53Domains (3.3.2.0)
	* This release adds a SubmittedSince attribute to the ListOperations API, so you can list operations that were submitted after a specified date and time.
* SageMaker (3.3.5.0)
	* SageMaker has added support for VPC configuration for both Endpoints and Training Jobs. This allows you to connect from the instances running the Endpoint or Training Job to your VPC and any resources reachable in the VPC rather than being restricted to resources that were internet accessible.
* WorkSpaces (3.3.2.0)
	* Added new IP Access Control APIs, an API to change the state of a Workspace, and the ADMIN_MAINTENANCE WorkSpace state. With the new IP Access Control APIs, you can now create/delete IP Access Control Groups, add/delete/update rules for IP Access Control Groups, Associate/Disassociate IP Access Control Groups to/from a WorkSpaces Directory, and Describe IP Based Access Control Groups.

### 3.3.270.1 (2018-04-26 22:57 UTC)
* Glacier (3.3.2.7)
	* Documentation updates for Glacier to fix a broken link
* SecretsManager (3.3.0.5)
	* Documentation updates for secretsmanager
* Core 3.3.22.2
	* AWS CodeCommit is now available in an additional region, EU (Paris).



### 3.3.270.0 (2018-04-25 19:00 UTC)
* CodeDeploy (3.3.10.0)
	* AWS CodeDeploy has a new exception that indicates when a GitHub token is not valid.
* Rekognition (3.3.8.6)
	* Documentation updates for Amazon Rekognition.
* XRay (3.3.2.0)
	* Added PutEncryptionConfig and GetEncryptionConfig APIs for managing data encryption settings. Use PutEncryptionConfig to configure X-Ray to use an AWS Key Management Service customer master key to encrypt trace data at rest.

### 3.3.269.1 (2018-04-25 00:54 UTC)
* Core 3.3.22.1
	* Fix Exception unmarshalling for cases where the response body isn't valid JSON or XML. Fix throws of AmazonUnmarshallingException to include the StatusCode. This allows the RetryHandler to retry based on the StatusCode. 
Adding solutions for each AWS Service. The solution for each service contains the Net35, Net45, CoreCLR projects for Core, service projects, service tests and other dependencies.
	* All services packages updated to require new Core

### 3.3.269.0 (2018-04-24 18:36 UTC)
* ElasticBeanstalk (3.3.8.0)
	* Support tracking Elastic Beanstalk resources in AWS Config.
* SecretsManager (3.3.0.3)
	* Documentation updates for secretsmanager

### 3.3.268.0 (2018-04-23 20:36 UTC)
* AutoScalingPlans (3.3.1.0)
	* The release adds the operation UpdateScalingPlan for updating a scaling plan and the support for tag filters as an application source.
* IoT (3.3.10.0)
	* Add IotAnalyticsAction which sends message data to an AWS IoT Analytics channel
* IoTAnalytics (3.3.0.0)
	* Introducing AWS IoT Analytics SDK. AWS IoT Analytics provides advanced data analysis for AWS IoT. It allows you to collect large amounts of device data, process messages, store them, and then query the data and run sophisticated analytics to make accurate decisions in your IoT applications and machine learning use cases. AWS IoT Analytics enables advanced data exploration through integration with Jupyter Notebooks and data visualization through integration with Amazon QuickSight.

### 3.3.267.0 (2018-04-20 19:05 UTC)
* KinesisFirehose (3.3.4.0)
	* With this release, Amazon Kinesis Data Firehose allows you to tag your delivery streams. Tags are metadata that you can create and use to manage your delivery streams. For more information about tagging, see AWS Tagging Strategies. For technical documentation, look for the tagging operations in the Amazon Kinesis Firehose API reference.
* MediaLive (3.3.5.0)
	* With AWS Elemental MediaLive you can now output live channels as RTMP (Real-Time Messaging Protocol) and RTMPS as the encrypted version of the protocol (Secure, over SSL/TLS). RTMP is the preferred protocol for sending live streams to popular social platforms which  means you can send live channel content to social and sharing platforms in a secure and reliable way while continuing to stream to your own website, app or network.

### 3.3.266.0 (2018-04-20 04:18 UTC)
* Core 3.3.22.0
	* For the .NET Framework 3.5 and .NET Framework 4.5 environments AWS service clients will now add TLS 1.1 and TLS 1.2 to the chain of supported security protocols if the environment has been patched to support TLS 1.1 and TLS 1.2
	* All services packages updated to require new Core

### 3.3.265.0 (2018-04-20 00:33 UTC)
* CodePipeline (3.3.3.0)
	* Added new SourceRevision structure to Execution Summary with accompanying definitions as needed in the AWS CodePipeline API Guide.
* CostExplorer (3.3.3.0)
	* Starting today, you can identify opportunities for Amazon RDS cost savings using AWS Cost Explorer's API to access your Amazon RDS Reserved Instance Purchase Recommendations
* DeviceFarm (3.3.6.0)
	* Adding support for VPCEndpoint feature. Allows customers to be able to access their private endpoints/services running in their VPC during test automation.
* EC2 (3.3.48.0)
	* Added support for customers to see the time at which a Dedicated Host was allocated or released.
* RDS (3.3.22.0)
	* The ModifyDBCluster operation now includes an EngineVersion parameter. You can use this to upgrade the engine for a clustered database.
* SecretsManager (3.3.0.1)
	* Documentation updates
* SimpleSystemsManagement (3.3.20.0)
	* Added new APIs DeleteInventory and DescribeInventoryDeletions, for customers to delete their custom inventory data.
* Core 3.3.21.21
	* The new CloudHSM is now available in the AWS GovCloud (US).



### 3.3.264.0 (2018-04-10 23:42 UTC)
* DatabaseMigrationService (3.3.7.0)
	* Native Change Data Capture start point and task recovery support in Database Migration Service.  
* Glue (3.3.7.0)
	* "AWS Glue now supports timeout values for ETL jobs. With this release, all new ETL jobs have a default timeout value of 48 hours. AWS Glue also now supports the ability to start a schedule or job events trigger when it is created."
* MediaPackage (3.3.1.0)
	* Adds a new OriginEndpoint package type CmafPackage in MediaPackage. Origin endpoints can now be configured to use the Common Media Application Format (CMAF) media streaming format. This version of CmafPackage only supports HTTP Live Streaming (HLS) manifests with fragmented MP4.
* SimpleSystemsManagement (3.3.19.0)
	* Added TooManyUpdates exception for AddTagsToResource and RemoveTagsFromResource API
* WorkMail (3.3.1.0)
	* Amazon WorkMail adds the ability to grant users and groups with "Full Access", "Send As" and "Send on Behalf" permissions on a given mailbox.

### 3.3.263.0 (2018-04-10 00:37 UTC)
* CloudDirectory (3.3.7.0)
	* Cloud Directory customers can fetch attributes within a facet on an object with the new GetObjectAttributes API and can fetch attributes from multiple facets or objects with the BatchGetObjectAttributes operation.

### 3.3.262.0 (2018-04-06 19:43 UTC)
* Batch (3.3.5.0)
	* Support for Timeout in SubmitJob and RegisterJobDefinition

### 3.3.261.1 (2018-04-05 19:28 UTC)
* SimpleSystemsManagement (3.3.18.1)
	* Documentation updates for ec2

### 3.3.261.0 (2018-04-04 18:20 UTC)
* ACMPCA (3.3.0.0)
	* AWS Certificate Manager (ACM) Private Certificate Authority (CA) is a managed private CA service that helps you easily and securely manage the lifecycle of your private certificates. ACM Private CA provides you a highly-available private CA service without the upfront investment and ongoing maintenance costs of operating your own private CA. ACM Private CA extends ACM's certificate management capabilities to private certificates, enabling you to manage public and private certificates centrally.
* CertificateManager (3.3.5.0)
	* AWS Certificate Manager has added support for AWS Certificate Manager Private Certificate Authority (CA). Customers can now request private certificates with the RequestCertificate API, and also export private certificates with the ExportCertificate API.
* CloudWatch (3.3.6.0)
	* The new GetMetricData API enables you to collect batch amounts of metric data and optionally perform math expressions on the data. With one GetMetricData call you can retrieve as many as 100 different metrics and a total of 100,800 data points.
* ConfigService (3.3.15.0)
	* AWS Config introduces multi-account multi-region data aggregation features. Customers can create an aggregator (a new resource type) in AWS Config that collects AWS Config data from multiple source accounts and regions into an aggregator account. Customers can aggregate data from individual account(s) or an organization and multiple regions. In this release, AWS Config adds several API's for multi-account multi-region data aggregation.
* FMS (3.3.0.0)
	* This release is the initial release version for AWS Firewall Manager, a new AWS service that makes it easy for customers to centrally configure WAF rules across all their resources (ALBs and CloudFront distributions) and across accounts.
* S3 (3.3.18.0)
	* ONEZONE_IA storage class stores object data in only one Availability Zone at a lower price than STANDARD_IA. This SDK release provides API support for this new storage class.
* SageMaker (3.3.4.0)
	* SageMaker is now supporting many additional instance types in previously supported families for Notebooks, Training Jobs, and Endpoints. Training Jobs and Endpoints now support instances in the m5 family in addition to the previously supported instance families. For specific instance types supported please see the documentation for the SageMaker API.
* SecretsManager (3.3.0.0)
	* AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps.  Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials.  You can automatically and frequently rotate your secrets without having to deploy updates to your apps.  All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.
* TranscribeService (3.3.1.0)
	* Amazon Transcribe is an automatic speech recognition (ASR) service that makes it easy for developers to add speech to text capability to their applications. 

### 3.3.260.0 (2018-04-03 22:20 UTC)
* DeviceFarm (3.3.5.0)
	* Added Private Device Management feature. Customers can now manage their private devices efficiently - view their status, set labels and apply profiles on them. Customers can also schedule automated tests and remote access sessions on individual instances in their private device fleet.
* Lambda (3.3.13.0)
	* added nodejs8.10 as a valid runtime
* Translate (3.3.1.0)
	* This release increases the maximum size of input text to 5,000 bytes. Amazon Translate now supports automatic language detection of the input text. The translation models have been improved to increase accuracy. See the documentation for more information.

### 3.3.259.0 (2018-04-02 20:49 UTC)
* APIGateway (3.3.17.0)
	* Amazon API Gateway now supports resource policies for APIs making it easier to set access controls for invoking APIs.
* CloudFront (3.3.7.0)
	* You can now use a new Amazon CloudFront capability called Field-Level Encryption to further enhance the security of sensitive data, such as credit card numbers or personally identifiable information (PII) like social security numbers. CloudFront's field-level encryption further encrypts sensitive data in an HTTPS form using field-specific encryption keys (which you supply) before a POST request is forwarded to your origin. This ensures that sensitive data can only be decrypted and viewed by certain components or services in your application stack. Field-level encryption is easy to setup. Simply configure the fields that have to be further encrypted by CloudFront using the public keys you specify and you can reduce attack surface for your sensitive data.
* Elasticsearch (3.3.5.0)
	* This adds Amazon Cognito authentication support to Kibana.

### 3.3.258.0 (2018-03-30 20:23 UTC)
* CertificateManager (3.3.4.2)
	* Documentation updates for acm
* Connect (3.3.0.0)
	* Amazon Connect is a contact center as a service (CCaS) solution that offers easy, self-service configuration and enables dynamic, personal, and natural customer engagement at any scale. With this release of the Amazon Connect SDK, Outbound APIs (StartOutboundVoiceContact, StopContact) are now generally available. This release supports CTR generation for calls generated through the new APIs. Additionally IAM permissions are supported for the new APIs. 
* Core 3.3.21.20
	* Adding FIPS endpoint for CodeBuild service



### 3.3.257.0 (2018-03-30 00:18 UTC)
* AlexaForBusiness (3.3.2.0)
	* Adds operations for creating and managing address books of phone contacts for use in A4B managed shared devices.
* CloudFormation (3.3.10.0)
	* Enabling resource level permission control for StackSets APIs. Adding support for customers to use customized AdministrationRole to create security boundaries between different users.
* Greengrass (3.3.3.0)
	* Greengrass APIs now support creating Machine Learning resource types and configuring binary data as the input payload for Greengrass Lambda functions.
* SimpleSystemsManagement (3.3.18.0)
	* This Patch Manager release supports creating patch baselines for CentOS.

### 3.3.256.1 (2018-03-29 06:46 UTC)
* CloudFront (3.3.6.4)
	* Fixed issue with Url siginer not supporting IPv6
* RDS (3.3.21.5)
	* Fixed encoding issue when computing a presigned URL.
* S3 (3.3.17.3)	
	* Add configuration on PutObject and UploadPart to turn off chunk encoding.
* Core 3.3.21.19
	* Convert all request marshallers to singletons
	* Isolate usage of HttpClient to better handle different platforms the SDK runs on
	* Lower default chunked upload size to avoid creating LOH sized objects.
	* Remove an unnecessary await in DefaultRetryPolicy
	* Ensure service url has a trailing '/' to avoid issues when concatenating host and resource path.
	* All services packages updated to require new Core

### 3.3.256.0 (2018-03-28 23:32 UTC)
* IdentityManagement (3.3.6.0)
	* Add support for Longer Role Sessions. Four APIs manage max session duration: GetRole, ListRoles, CreateRole, and the new API UpdateRole. The max session duration integer attribute is measured in seconds.
* MTurk (3.3.2.0)
	* Added a new attribute "ActionsGuarded" to QualificationRequirement: This update allows MTurk Requester customers using the AWS SDK to control which Workers can see and preview their HITs. We now support hiding HITs from unqualified Workers' search results.
* SecurityToken (3.3.4.0)
	* Change utilizes the Max Session Duration attribute introduced for IAM Roles and allows STS customers to request session duration up to the Max Session Duration of 12 hours from AssumeRole based APIs.
* Core 3.3.21.18
	* Amazon GuardDuty API operations are now supported in the EU (Paris) region.
Amazon Workspaces is now available in ap-northeast-2



### 3.3.255.0 (2018-03-27 19:18 UTC)
* CertificateManager (3.3.4.0)
	* AWS Certificate Manager has added support for customers to disable Certificate Transparency logging on a per-certificate basis.

### 3.3.254.0 (2018-03-26 22:30 UTC)
* DynamoDBv2 (3.3.7.0)
	* Point-in-time recovery (PITR) provides continuous backups of your DynamoDB table data. With PITR, you do not have to worry about creating, maintaining, or scheduling backups. You enable PITR on your table and your backup is available for restore at any point in time from the moment you enable it, up to a maximum of the 35 preceding days. PITR provides continuous backups until you explicitly disable it. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.253.1 (2018-03-23 18:07 UTC)
* RDS (3.3.21.4)
	* Documentation updates for RDS

### 3.3.253.0 (2018-03-22 22:05 UTC)
* AppStream (3.3.11.0)
	* Feedback URL allows admins to provide a feedback link or a survey link for collecting user feedback while streaming sessions. When a feedback link is provided, streaming users will see a "Send Feedback" choice in their streaming session toolbar. On selecting this choice, user will be redirected to the link provided in a new browser tab. If a feedback link is not provided, users will not see the "Send Feedback" option. 
* CodeBuild (3.3.9.0)
	* Adding support for branch filtering when using webhooks with AWS CodeBuild. 
* ECS (3.3.13.0)
	* Amazon Elastic Container Service (ECS) now includes integrated Service Discovery using Route 53 Auto Naming. Customers can now specify a Route 53 Auto Naming service as part of an ECS service. ECS will register task IPs with Route 53, making them available via DNS in your VPC.

### 3.3.252.1 (2018-03-21 21:19 UTC)
* ServerlessApplicationRepository (3.3.1.3)
	* Documentation updates for Serverless Application Respository
* Core 3.3.21.17
	* Elemental MediaPackage is now available in the ICN and GRU regions.



### 3.3.252.0 (2018-03-20 21:17 UTC)
* CloudWatchEvents (3.3.5.0)
	* Added SQS FIFO queue target support
* ConfigService (3.3.14.0)
	* AWS Config adds support for BatchGetResourceConfig API, allowing you to batch-retrieve the current state of one or more of your resources.
* CostExplorer (3.3.2.0)
	* This launch will allow customers to access their Amazon EC2 Reserved Instance (RI) purchase recommendations programmatically via the AWS Cost Explorer API. 
* ECS (3.3.12.0)
	* Amazon ECS users can now mount a temporary volume in memory in containers and specify the shared memory that a container can use through the use of docker's 'tmpfs' and 'shm-size' features respectively. These fields can be specified under linuxParameters in ContainerDefinition in the Task Definition Template.
* ElasticBeanstalk (3.3.7.1)
	* Documentation updates for the new Elastic Beanstalk API DescribeAccountAttributes.
* Glue (3.3.6.0)
	* API Updates for DevEndpoint: PublicKey is now optional for CreateDevEndpoint. The new DevEndpoint field PrivateAddress will be populated for DevEndpoints associated with a VPC.
* MediaLive (3.3.4.0)
	* AWS Elemental MediaLive has added support for updating Inputs and Input Security Groups. You can update Input Security Groups at any time and it will update all channels using that Input Security Group. Inputs can be updated as long as they are not attached to a currently running channel.

### 3.3.251.0 (2018-03-16 20:40 UTC)
* ElasticBeanstalk (3.3.7.0)
	* AWS Elastic Beanstalk is launching a new public API named DescribeAccountAttributes which allows customers to access account level attributes. In this release, the API will support quotas for resources such as applications, application versions, and environments.

### 3.3.250.0 (2018-03-15 19:47 UTC)
* Organizations (3.3.8.0)
	* This release adds additional reason codes to improve clarity to exceptions that can occur.
* Pinpoint (3.3.7.0)
	* With this release, you can delete endpoints from your Amazon Pinpoint projects. Customers can now specify one of their leased dedicated long or short codes to send text messages.
* SageMaker (3.3.3.0)
	* This release provides support for ml.p3.xlarge instance types for notebook instances.  Lifecycle configuration is now available to customize your notebook instances on start; the configuration can be reused between multiple notebooks.  If a notebook instance is attached to a VPC you can now opt out of internet access that by default is provided by SageMaker.

### 3.3.249.2 (2018-03-14 22:38 UTC)
* Core 3.3.21.16
	* This change allows endpoint specific clock skew adjustment.
	* All services packages updated to require new Core

### 3.3.249.1 (2018-03-14 20:20 UTC)
* Lightsail (3.3.5.2)
	* Updates to existing Lightsail documentation

### 3.3.249.0 (2018-03-13 19:15 UTC)
* ServiceDiscovery (3.3.2.0)
	* This release adds support for custom health checks, which let you check the health of resources that aren't accessible over the internet. For example, you can use a custom health check when the instance is in an Amazon VPC.

### 3.3.248.0 (2018-03-12 22:42 UTC)
* ApplicationDiscoveryService (3.3.3.6)
	* Documentation updates for discovery
* CloudHSMV2 (3.3.1.0)
	* CreateCluster can now take both 8 and 17 character Subnet IDs. DeleteHsm can now take both 8 and 17 character ENI IDs.
* IoT (3.3.9.0)
	* We added new fields to the response of the following APIs. (1) describe-certificate: added new generationId, customerVersion fields (2) describe-ca-certificate: added new generationId, customerVersion and lastModifiedDate fields (3) get-policy: added generationId, creationDate and lastModifiedDate fields
* Redshift (3.3.4.0)
	* DescribeClusterSnapshotsMessage with ClusterExists flag returns snapshots of existing clusters. Else both existing and deleted cluster snapshots are returned

### 3.3.247.0 (2018-03-09 00:26 UTC)
* ECS (3.3.11.0)
	* Amazon Elastic Container Service (ECS) now supports container health checks. Customers can now specify a docker container health check command and parameters in their task definition. ECS will monitor, report and take scheduling action based on the health status.
* MigrationHub (3.3.1.0)
	* Unused key LABEL removed from ResourceAttrbute
* Pinpoint (3.3.6.0)
	* With this release, you can export endpoints from your Amazon Pinpoint projects. You can export a) all of the endpoints assigned to a project or b) the subset of endpoints assigned to a segment.
* RDS (3.3.21.2)
	* Documentation updates for RDS

### 3.3.246.0 (2018-03-08 00:42 UTC)
* MediaLive (3.3.3.0)
	* Updates API to model required traits and minimum/maximum constraints.

### 3.3.245.2 (2018-03-06 21:07 UTC)
* ECS (3.3.10.2)
	* Documentation updates for Amazon ECS

### 3.3.245.1 (2018-03-03 00:50 UTC)
* Core 3.3.21.15
	* URL encode resource path segments before canonicalization for all services except S3.
	* All services packages updated to require new Core

### 3.3.245.0 (2018-03-01 23:43 UTC)
* CloudWatchEvents (3.3.4.0)
	* Added BatchParameters to the PutTargets API
* EC2 (3.3.47.0)
	* Added support for modifying Placement Group association of instances via ModifyInstancePlacement API.
* ServiceCatalog (3.3.8.0)
	* This release of ServiceCatalog adds the DeleteTagOption API.
* SimpleSystemsManagement (3.3.17.0)
	* This Inventory release supports the status message details reported by the last sync for the resource data sync API.
* StorageGateway (3.3.7.0)
	* AWS Storage Gateway (File) support for two new file share attributes are added.           1. Users can specify the S3 Canned ACL to use for new objects created in the file share.         2. Users can create file shares for requester-pays buckets.

### 3.3.244.0 (2018-02-28 22:16 UTC)
* ApplicationAutoScaling (3.3.9.0)
	* Application Auto Scaling now supports automatic scaling of SageMaker Production Variants on an Endpoint.

### 3.3.243.1 (2018-02-28 02:38 UTC)
* ECR (3.3.3.3)
	* Documentation updates for Amazon ECR.

### 3.3.243.0 (2018-02-27 16:47 UTC)
* Route53 (3.3.15.0)
	* Added support for creating LBR rules using ap-northeast-3 region.
* SecurityToken (3.3.3.4)
	* Increased SAMLAssertion parameter size from 50000 to 100000 for AWS Security Token Service AssumeRoleWithSAML API to allow customers to pass bigger SAML assertions

### 3.3.242.0 (2018-02-24 01:00 UTC)
* EC2 (3.3.46.0)
	* Updated to use new Core, version 3.3.21.14
	* You can now use AWS_EC2_METADATA_DISABLED environment variable to control SDK access to EC2 IMDS service.
* Core 3.3.21.14
	* You can now use  AWS_EC2_METADATA_DISABLED environment variable to control SDK access to EC2 IMDS service.  This release also removes InstanceProfileAWSCredentials from PCL.

### 3.3.241.0 (2018-02-23 19:52 UTC)
* AppStream (3.3.10.0)
	* This API update is to enable customers to copy their Amazon AppStream 2.0 images within and between AWS Regions

### 3.3.240.0 (2018-02-22 19:30 UTC)
* CostExplorer (3.3.1.0)
	* Added GetReservationCoverage API for retrieving reservation coverage information.
* ElasticLoadBalancingV2 (3.3.8.1)
	* Added a new load balancer attribute related to Network Load Balancers that enables cross zone capabilities. This feature allows Network Load Balancers to distribute requests regardless of Availability Zone.

### 3.3.239.0 (2018-02-21 20:41 UTC)
* CodeCommit (3.3.4.0)
	* This release adds an API for adding a file directly to an AWS CodeCommit repository without requiring a Git client.
* EC2 (3.3.45.0)
	* Adds support for tagging an EBS snapshot as part of the API call that creates the EBS snapshot
* ServerlessApplicationRepository (3.3.1.0)
	* Added support for delete-application API and the ability for developers to set a homepage for their application. The homepage is a URL with more information about the application, for example the location of your GitHub repository for the application. 
* Core 3.3.21.13
	* Mediapackage expands their service to FRA and CDG regions.



### 3.3.238.0 (2018-02-20 22:50 UTC)
* AutoScaling (3.3.4.0)
	* Amazon EC2 Auto Scaling support for service-linked roles
* WAF (3.3.5.0)
	* The new PermissionPolicy APIs in AWS WAF Regional allow customers to attach resource-based policies to their entities.
* WAFRegional (3.3.4.0)
	* The new PermissionPolicy APIs in AWS WAF Regional allow customers to attach resource-based policies to their entities.

### 3.3.237.0 (2018-02-19 20:50 UTC)
* ConfigService (3.3.13.0)
	* With this release, AWS Config updated the ConfigurationItemStatus enum values. The values prior to this update did not represent appropriate values returned by GetResourceConfigHistory. You must update your code to enumerate the new enum values so this is a breaking change.  To map old properties to new properties, use the following descriptions: New discovered resource - Old property: Discovered, New property: ResourceDiscovered. Updated resource - Old property: Ok, New property: OK. Deleted resource - Old property: Deleted, New property: ResourceDeleted or ResourceDeletedNotRecorded. Not-recorded resource - Old property: N/A, New property: ResourceNotRecorded or ResourceDeletedNotRecorded.

### 3.3.236.0 (2018-02-16 20:53 UTC)
* RDS (3.3.21.0)
	* Updates RDS API to indicate whether a DBEngine supports read replicas.

### 3.3.235.0 (2018-02-15 22:56 UTC)
* GameLift (3.3.11.0)
	* Updates to allow Fleets to run on On-Demand or Spot instances.
* MediaConvert (3.3.1.0)
	* Nielsen ID3 tags can now be inserted into transport stream (TS) and HLS outputs. For more information on Nielsen configuration you can go to https://docs.aws.amazon.com/mediaconvert/latest/apireference/jobs.html#jobs-nielsenconfiguration
* Core 3.3.21.12
	* Launch AWS CodeStar in the Asia Pacific Northeast 2 (ICN) region.



### 3.3.234.0 (2018-02-14 23:24 UTC)
* AppSync (3.3.1.0)
	* AWS AppSync now supports for None Data Source, CreateApiKey now supports setting expiration on API keys, new API UpdateApiKey supports updating expiration on API keys. 
* LexModelBuildingService (3.3.6.0)
	* Amazon Lex now provides the ability to export and import your Amazon Lex chatbot definition as a JSON file.

### 3.3.233.0 (2018-02-13 22:15 UTC)
* Glacier (3.3.2.1)
	* Documentation updates for glacier
* Route53 (3.3.14.0)
	* Added support for creating Private Hosted Zones and metric-based healthchecks in the ap-northeast-3 region for whitelisted customers.

### 3.3.232.0 (2018-02-12 23:33 UTC)
* CognitoIdentityProvider (3.3.9.0)
	* Support for user migration using AWS Lambda trigger. Support to obtain signing certificate for user pools.
* EC2 (3.3.44.0)
	* Network interfaces now supply the following additional status of "associated" to better distinguish the current status.
* GuardDuty (3.3.2.0)
	* Added PortProbeAction information to the Action section of the port probe-type finding.
* KeyManagementService (3.3.5.0)
	* This release of AWS Key Management Service includes support for InvalidArnException in the RetireGrant API.
* RDS (3.3.20.1)
	* Aurora MySQL now supports MySQL 5.7.

### 3.3.231.0 (2018-02-09 22:53 UTC)
* EC2 (3.3.43.0)
	* Users can now better understand the longer ID opt-in status of their account using the two new APIs DescribeAggregateIdFormat and DescribePrincipalIdFormat
* Lex (3.3.3.0)
	* You can now define a response for your Amazon Lex chatbot directly from the AWS console. A response consists of messages dynamically selected from a group of pre-defined messages, populated by the developer.
* LexModelBuildingService (3.3.5.0)
	* You can now define a response for your Amazon Lex chatbot directly from the AWS console. A response consists of messages dynamically selected from a group of pre-defined messages, populated by the developer.

### 3.3.230.0 (2018-02-08 23:07 UTC)
* AppStream (3.3.9.0)
	* Adds support for allowing customers to provide a redirect URL for a stack. Users will be redirected to the link provided by the admin at the end of their streaming session. 
* Budgets (3.3.7.0)
	* Making budgetLimit and timePeriod optional, and updating budgets docs. 
* DatabaseMigrationService (3.3.6.0)
	* This release includes the addition of two new APIs: describe replication instance task logs and reboot instance. The first allows user to see how much storage each log for a task on a given instance is occupying. The second gives users the option to reboot the application software on the instance and force a fail over for MAZ instances to test robustness of their integration with our service. 
* DirectoryService (3.3.4.0)
	* Updated the regex of some input parameters to support longer EC2 identifiers.
* DynamoDBv2 (3.3.6.0)
	* Amazon DynamoDB now supports server-side encryption using a default service key (alias/aws/dynamodb) from the AWS Key Management Service (KMS). AWS KMS is a service that combines secure, highly available hardware and software to provide a key management system scaled for the cloud. AWS KMS is used via the AWS Management Console or APIs to centrally create encryption keys, define the policies that control how keys can be used, and audit key usage to prove they are being used correctly. For more information, see the Amazon DynamoDB Developer Guide.
* GameLift (3.3.10.0)
	* Amazon GameLift FlexMatch added the StartMatchBackfill API.  This API allows developers to add new players to an existing game session using the same matchmaking rules and player data that were used to initially create the session.
* MediaLive (3.3.2.0)
	* AWS Elemental MediaLive has added support for updating channel settings for idle channels. You can now update channel name, channel outputs and output destinations, encoder settings, user role ARN, and input specifications. Channel settings can be updated in the console or with API calls. Please note that running channels need to be stopped before they can be updated. We've also deprecated the 'Reserved' field.
* MediaStore (3.3.1.0)
	* AWS Elemental MediaStore now supports per-container CORS configuration.
* Core 3.3.21.11
	* We marked Inspector GA yesterday. 2/.5/18.



### 3.3.229.0 (2018-02-06 22:00 UTC)
* Glue (3.3.5.0)
	* This new feature will now allow customers to add a customized json classifier. They can specify a json path to indicate the object, array or field of the json documents they'd like crawlers to inspect when they crawl json files. 
* ServiceCatalog (3.3.7.0)
	* This release of Service Catalog adds SearchProvisionedProducts API and ProvisionedProductPlan APIs.
* ServiceDiscovery (3.3.1.0)
	* This release adds support for registering CNAME record types and creating Route 53 alias records that route traffic to Amazon Elastic Load Balancers using Amazon Route 53 Auto Naming APIs.
* SimpleSystemsManagement (3.3.16.0)
	* This Patch Manager release supports configuring Linux repos as part of patch baselines, controlling updates of non-OS security packages and also creating patch baselines for SUSE12

### 3.3.228.0 (2018-02-05 21:19 UTC)
* CertificateManager (3.3.3.1)
	* Documentation updates for acm
* Cloud9 (3.3.0.1)
	* API usage examples for AWS Cloud9.
* Kinesis (3.3.5.0)
	* Using ListShards a Kinesis Data Streams customer or client can get information about shards in a data stream (including meta-data for each shard) without obtaining data stream level information.
* OpsWorks (3.3.3.0)
	* AWS OpsWorks Stacks supports EBS encryption and HDD volume types. Also, a new DescribeOperatingSystems API is available, which lists all operating systems supported by OpsWorks Stacks.
* S3 (3.3.17.0)
	* Fix incorrect marshaller for S3 RestoreObject request.
* Core 3.3.21.10
	* Validate the role paramater when creating InstanceProfileAWSCredentials.


### 3.3.227.0 (2018-01-26 22:17 UTC)
* DeviceFarm (3.3.4.0)
	* Add InteractionMode in CreateRemoteAccessSession for DirectDeviceAccess feature.
* MediaLive (3.3.1.0)
	* Add InputSpecification to CreateChannel (specification of input attributes is used for channel sizing and affects pricing);  add NotFoundException to DeleteInputSecurityGroups.
* MTurk (3.3.1.4)
	* Documentation updates for mturk-requester

### 3.3.226.0 (2018-01-25 22:41 UTC)
* AlexaForBusiness (3.3.1.0)
	* Supports new field for DeviceStatusInfo which provides details about the DeviceStatus following a DeviceSync operation.
* CodeBuild (3.3.8.0)
	* Adding support for Shallow Clone and GitHub Enterprise in AWS CodeBuild.
* GuardDuty (3.3.1.0)
	* Added the missing AccessKeyDetails object to the resource shape.
* Lambda (3.3.12.0)
	* AWS Lambda now supports Revision ID on your function versions and aliases, to track and apply conditional updates when you are updating your function version or alias resources.
* Core 3.3.21.9
	* Added service signing name.
This API update is to support Amazon AppStream 2.0's launch into the Asia Pacific (Singapore) and Asia Pacific (Sydney) regions.



### 3.3.225.0 (2018-01-23 02:32 UTC)
* Budgets (3.3.6.0)
	* Add additional costTypes: IncludeDiscount, UseAmortized,  to support finer control for different charges included in a cost budget.

### 3.3.224.0 (2018-01-19 20:44 UTC)
* Glue (3.3.4.0)
	* New AWS Glue DataCatalog APIs to manage table versions and a new feature to skip archiving of the old table version when updating table.
* TranscribeService (3.3.0.0)
	* Amazon Transcribe Public Preview Release
* Core 3.3.21.8
	* Fix issue signing request with x-amzn-trace-id

### 3.3.223.0 (2018-01-18 01:05 UTC)
* SageMaker (3.3.2.0)
	* CreateTrainingJob and CreateEndpointConfig now supports KMS Key for volume encryption. 

### 3.3.222.1 (2018-01-17 19:52 UTC)
* AutoScalingPlans (3.3.0.1)
	* Documentation updates for autoscaling-plans
* EC2 (3.3.42.1)
	* Documentation updates for EC2

### 3.3.222.0 (2018-01-17 00:00 UTC)
* ApplicationAutoScaling (3.3.8.0)
	* Application Auto Scaling is adding support for Target Tracking Scaling for ECS services.
* AutoScalingPlans (3.3.0.0)
	* AWS Auto Scaling enables you to quickly discover all of the scalable resources underlying your application and set up application scaling in minutes using built-in scaling recommendations.
* RDS (3.3.20.0)
	* With this release you can now integrate RDS DB instances with CloudWatch Logs. We have added parameters to the operations for creating and modifying DB instances (for example CreateDBInstance) to allow you to take advantage of this capability through the CLI and API. Once you enable this feature, a stream of log events will publish to CloudWatch Logs for each log type you enable.
* Core 3.3.21.7
	* Amazon Workspaces is now available in sa-east-1



### 3.3.221.0 (2018-01-15 23:31 UTC)
* Lambda (3.3.11.0)
	* Support for creating Lambda Functions using 'dotnetcore2.0' and 'go1.x'. 

### 3.3.220.0 (2018-01-12 21:20 UTC)
* Glue (3.3.3.0)
	* Support is added to generate ETL scripts in Scala which can now be run by  AWS Glue ETL jobs. In addition, the trigger API now supports firing when any conditions are met (in addition to all conditions). Also, jobs can be triggered based on a "failed" or "stopped" job run (in addition to a "succeeded" job run). 

### 3.3.219.0 (2018-01-11 20:40 UTC)
* ElasticLoadBalancing (3.3.2.0)
	* Added OperationNotPermittedException to indicate that you cannot create a classic load balancer while deleting the Elastic Load Balancing service-linked role.
* ElasticLoadBalancingV2 (3.3.8.0)
	* Added OperationNotPermittedException to indicate that you cannot create a load balancer while deleting the Elastic Load Balancing service-linked role.
* RDS (3.3.19.0)
	* Read Replicas for Amazon RDS for MySQL, MariaDB, and PostgreSQL now support Multi-AZ deployments.Amazon RDS Read Replicas enable you to create one or more read-only copies of your database instance within the same AWS Region or in a different AWS Region. Updates made to the source database are asynchronously copied to the Read Replicas. In addition to providing scalability for read-heavy workloads, you can choose to promote a Read Replica to become standalone a DB instance when needed.Amazon RDS Multi-AZ Deployments provide enhanced availability for database instances within a single AWS Region. With Multi-AZ, your data is synchronously replicated to a standby in a different Availability Zone (AZ). In case of an infrastructure failure, Amazon RDS performs an automatic failover to the standby, minimizing disruption to your applications.You can now combine Read Replicas with Multi-AZ as part of a disaster recovery strategy for your production databases. A well-designed and tested plan is critical for maintaining business continuity after a disaster. Since Read Replicas can also be created in different regions than the source database, your Read Replica can be promoted to become the new production database in case of a regional disruption.You can also combine Read Replicas with Multi-AZ for your database engine upgrade process. You can create a Read Replica of your production database instance and upgrade it to a new database engine version. When the upgrade is complete, you can stop applications, promote the Read Replica to a standalone database instance and switch over your applications. Since the database instance is already a Multi-AZ deployment, no additional steps are needed.For more information, see the Amazon RDS User Guide.
* SimpleSystemsManagement (3.3.15.2)
	* Updates documentation for the HierarchyLevelLimitExceededException error.

### 3.3.218.1 (2018-01-09 21:59 UTC)
* KeyManagementService (3.3.4.2)
	* Documentation updates for AWS KMS

### 3.3.218.0 (2018-01-09 16:46 UTC)
* DirectoryService (3.3.3.0)
	* On October 24 we introduced AWS Directory Service for Microsoft Active Directory (Standard Edition), also known as AWS Microsoft AD (Standard Edition), which is a managed Microsoft Active Directory (AD) that is optimized for small and midsize businesses (SMBs). With this SDK release, you can now create an AWS Microsoft AD directory using API. This enables you to run typical SMB workloads using a cost-effective, highly available, and managed Microsoft AD in the AWS Cloud.

### 3.3.217.0 (2018-01-08 23:53 UTC)
* ApplicationDiscoveryService (3.3.3.4)
	* Documentation updates for AWS Application Discovery Service.
* CodeDeploy (3.3.9.0)
	* The AWS CodeDeploy API was updated to support DeleteGitHubAccountToken, a new method that deletes a GitHub account connection.
* Route53 (3.3.13.0)
	* This release adds an exception to the CreateTrafficPolicyVersion API operation.

### 3.3.216.0 (2018-01-05 21:41 UTC)
* Inspector (3.3.4.0)
	* Added 2 new attributes to the DescribeAssessmentTemplate response, indicating the total number of assessment runs and last assessment run ARN (if present.)
* SimpleSystemsManagement (3.3.15.1)
	* Documentation updates for ssm
* Snowball (3.3.2.10)
	* Documentation updates for snowball

### 3.3.215.1 (2018-01-02 21:36 UTC)
* RDS (3.3.18.1)
	* Documentation updates for rds

