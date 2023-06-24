### 3.3.656.1 (2019-12-25 00:21 UTC)
* Core 3.3.104.11
	* Fix support of the role_session_name property in the shared credentials file
	* All services packages updated to require new Core

### 3.3.656.0 (2019-12-23 19:12 UTC)
* AWSHealth (3.3.102.0)
	* With this release, you can now centrally aggregate AWS Health events from all accounts in your AWS organization. Visit AWS Health documentation to learn more about enabling and using this feature: https://docs.aws.amazon.com/health/latest/ug/organizational-view-health.html. 
* Detective (3.3.100.6)
	* Updated the documentation for Amazon Detective.
* FSx (3.3.103.0)
	* This release adds a new family of APIs (create-data-repository-task, describe-data-repository-task, and cancel-data-repository-task) that allow users to perform operations between their file system and its linked data repository.
* Core 3.3.104.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.655.0 (2019-12-20 19:20 UTC)
* DeviceFarm (3.3.102.0)
	* Introduced browser testing support through AWS Device Farm
* EC2 (3.3.147.0)
	* This release introduces the ability to tag key pairs, placement groups, export tasks, import image tasks, import snapshot tasks and export image tasks. You can use tags to organize and identify your resources for cost allocation. 
* EKS (3.3.106.0)
	* Amazon EKS now supports restricting access to the API server public endpoint by applying CIDR blocks
* Pinpoint (3.3.105.0)
	* This release of the Amazon Pinpoint API introduces versioning support for message templates.
* RDS (3.3.115.0)
	* This release adds an operation that enables users to specify whether a database is restarted when its SSL/TLS certificate is rotated. Only customers who do not use SSL/TLS should use this operation.
* Redshift (3.3.105.12)
	* Documentation updates for Amazon Redshift RA3 node types.
* SecurityHub (3.3.105.0)
	* Additional resource types are now fully supported in the AWS Security Finding Format (ASFF). These resources include AwsElbv2LoadBalancer, AwsKmsKey, AwsIamRole, AwsSqsQueue, AwsLambdaFunction, AwsSnsTopic, and AwsCloudFrontDistribution. Each of these resource types includes an accompanying resource details object with fields for security finding providers to populate. Updates were made to the AwsIamAccessKey resource details object to include information on principal ID and name. To learn more, visit our documentation on the ASFF.
* SimpleSystemsManagement (3.3.117.0)
	* This release updates the attachments support to include AttachmentReference source for Automation documents.
* TranscribeService (3.3.113.0)
	* AWS Transcribe now supports vocabulary filtering that allows customers to input words to the service that they don't want to see in the output transcript.
* Core 3.3.104.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.654.1 (2019-12-19 22:06 UTC)
* S3 (3.3.110.4)
	* Adding configuration of S3 timeouts to MaxTimeout for .NET Standard

### 3.3.654.0 (2019-12-19 19:42 UTC)
* CodeStarconnections (3.3.100.0)
	* Public beta for Bitbucket Cloud support in AWS CodePipeline through integration with AWS CodeStar connections.
* DLM (3.3.105.0)
	* You can now copy snapshots across regions using Data Lifecycle Manager (DLM). You can enable policies which, along with create, can now also copy snapshots to one or more AWS region(s). Copies can be scheduled for up to three regions from a single policy and retention periods are set for each region separately. 
* EC2 (3.3.146.0)
	* We are updating the supportedRootDevices field to supportedRootDeviceTypes for DescribeInstanceTypes API to ensure that the actual value is returned, correcting a previous error in the model.
* GameLift (3.3.105.0)
	* Amazon GameLift now supports ARNs for all key GameLift resources, tagging for GameLift resource authorization management, and updated documentation that articulates GameLift's resource authorization strategy.
* LexModelBuildingService (3.3.102.0)
	* Amazon Lex now supports conversation logs and slot obfuscation.
* PersonalizeRuntime (3.3.102.0)
	* Add context map to get-recommendations and get-personalized-ranking request objects to provide contextual metadata at inference time
* SimpleSystemsManagement (3.3.116.0)
	* This release allows customers to add tags to Automation execution, enabling them to sort and filter executions in different ways, such as by resource, purpose, owner, or environment.
* TranscribeService (3.3.112.0)
	* Amazon Transcribe supports job queuing for the StartTranscriptionJob API.

### 3.3.653.0 (2019-12-18 19:46 UTC)
* CloudFront (3.3.101.82)
	* Documentation updates for CloudFront
* EC2 (3.3.145.0)
	* This release introduces the ability to tag Elastic Graphics accelerators. You can use tags to organize and identify your accelerators for cost allocation.
* OpsWorksCM (3.3.103.0)
	* AWS OpsWorks CM now supports tagging, and tag-based access control, of servers and backups.
* ResourceGroupsTaggingAPI (3.3.103.10)
	* Documentation updates for resourcegroupstaggingapi
* S3 (3.3.110.3)
	* Updates Amazon S3 endpoints allowing you to configure your client to opt-in to using S3 with the us-east-1 regional endpoint, instead of global.
* Core 3.3.104.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.652.1 (2019-12-17 23:29 UTC)
* SecurityToken (3.3.104.11)
	* Updated to use new Core, version 3.3.104.7
	* Adds extension methods, tests, and custom retry logic for creating AssumeRoleImmutableCredentials using the AssumeRoleWithWebIdentity operation.  More information on the use of these credentials can be found in the Core project.
* Core 3.3.104.7
	* Adds a means to use web identity tokens, such as OIDC tokens, to assume roles using the Security Token Service as part of the regular credential chain.  Users may specify a WebIdentityTokenFile, RoleArn, and optionally a RoleSessionName to create these refreshing credentials.
	* All services packages updated to require new Core

### 3.3.652.0 (2019-12-17 19:48 UTC)
* EC2 (3.3.144.1)
	* Documentation updates for Amazon EC2
* ECS (3.3.112.7)
	* Documentation updates for Amazon ECS.
* IoT (3.3.106.0)
	* Added a new Over-the-Air (OTA) Update feature that allows you to use different, or multiple, protocols to transfer an image from the AWS cloud to IoT devices.
* KinesisAnalyticsV2 (3.3.103.0)
	* Kinesis Data Analytics service now supports running Java applications using Flink 1.8.
* MediaLive (3.3.107.0)
	* AWS Elemental MediaLive now supports HLS ID3 segment tagging, HLS redundant manifests for CDNs that support different publishing/viewing endpoints, fragmented MP4 (fMP4), and frame capture intervals specified in milliseconds.
* SimpleSystemsManagement (3.3.115.0)
	* Added support for Cloud Watch Output and Document Version to the Run Command tasks in Maintenance Windows.

### 3.3.651.0 (2019-12-16 19:11 UTC)
* ComprehendMedical (3.3.102.0)
	* New Ontology linking APIs will provides medication concepts normalization and Diagnoses codes from input text. In this release we will provide two APIs -  RxNorm and ICD10-CM. 
* EC2 (3.3.144.0)
	* You can now configure your EC2 Fleet to preferentially use EC2 Capacity Reservations for launching On-Demand instances, enabling you to fully utilize the available (and unused) Capacity Reservations before launching On-Demand instances on net new capacity.
* MQ (3.3.105.0)
	* Amazon MQ now supports throughput-optimized message brokers, backed by Amazon EBS.
* Core 3.3.104.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.650.0 (2019-12-13 21:43 UTC)
* S3 (3.3.110.0)
	* Updated to use new Core, version 3.3.104.5
	* The S3 client now supports a regional endpoint property for us-east-1
* Core 3.3.104.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.649.0 (2019-12-13 19:49 UTC)
* CodeBuild (3.3.107.0)
	* CodeBuild adds support for cross account
* Detective (3.3.100.0)
	* This is the initial release of Amazon Detective.
* SimpleEmailV2 (3.3.102.0)
	* Added the ability to use your own public-private key pair to configure DKIM authentication for a domain identity.

### 3.3.648.0 (2019-12-12 19:14 UTC)
* AccessAnalyzer (3.3.101.0)
	* This release includes improvements and fixes bugs for the IAM Access Analyzer feature.
* Core 3.3.104.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.647.1 (2019-12-12 00:11 UTC)
* S3 (3.3.109.3)
	* Updated to use new Core, version 3.3.104.3
	* Fixes to prevent TransferUtility commands from partially succeeding
* Core 3.3.104.3
	* Changes to handle and retry OperationCanceledException exceptions in Net Standard versions of the SDK when thrown by HttpClient where it isn't a user issued cancellation.
	* All services packages updated to require new Core

### 3.3.647.0 (2019-12-11 19:13 UTC)
* EC2 (3.3.143.0)
	* This release allows customers to attach multiple Elastic Inference Accelerators to a single EC2 instance. It adds support for a Count parameter for each Elastic Inference Accelerator type you specify on the RunInstances and LaunchTemplate APIs.
* Core 3.3.104.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.646.0 (2019-12-10 20:29 UTC)
* Kendra (3.3.101.0)
	* 1. Adding DocumentTitleFieldName as an optional configuration for SharePoint. 2. updating s3 object pattern to  support all s3 keys.

### 3.3.645.0 (2019-12-09 20:24 UTC)
* Kafka (3.3.105.0)
	* AWS MSK has added support for Open Monitoring with Prometheus.
* KeyManagementService (3.3.103.0)
	* The Verify operation now returns KMSInvalidSignatureException on invalid signatures. The Sign and Verify operations now return KMSInvalidStateException when a request is made against a CMK pending deletion.
* QuickSight (3.3.102.7)
	* Documentation updates for QuickSight
* SimpleSystemsManagement (3.3.114.0)
	* Adds the SSM GetCalendarState API and ChangeCalendar SSM Document type. These features enable the forthcoming Systems Manager Change Calendar feature, which will allow you to schedule events during which actions should (or should not) be performed.
* Core 3.3.104.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.644.0 (2019-12-05 01:33 UTC)
* ApiGatewayV2 (3.3.104.0)
	* Amazon API Gateway now supports HTTP APIs (beta), enabling customers to quickly build high performance RESTful APIs that are up to 71% cheaper than REST APIs also available from API Gateway. HTTP APIs are optimized for building APIs that proxy to AWS Lambda functions or HTTP backends, making them ideal for serverless workloads. Using HTTP APIs, you can secure your APIs using OIDC and OAuth 2 out of box, quickly build web applications using a simple CORS experience, and get started immediately with automatic deployment and simple create workflows.
* KinesisVideo (3.3.102.0)
	* Introduces management of signaling channels for Kinesis Video Streams.
* KinesisVideoSignalingChannels (3.3.100.0)
	* Announcing support for WebRTC in Kinesis Video Streams, as fully managed capability. You can now use simple APIs to enable your connected devices, web, and mobile apps with real-time two-way media streaming capabilities.

### 3.3.643.0 (2019-12-04 01:41 UTC)
* ApplicationAutoScaling (3.3.104.0)
	* This release supports auto scaling of provisioned concurrency for AWS Lambda.
* EBS (3.3.100.0)
	* This release introduces the EBS direct APIs for Snapshots: 1. ListSnapshotBlocks, which lists the block indexes and block tokens for blocks in an Amazon EBS snapshot. 2. ListChangedBlocks, which lists the block indexes and block tokens for blocks that are different between two snapshots of the same volume/snapshot lineage. 3. GetSnapshotBlock, which returns the data in a block of an Amazon EBS snapshot.
* Lambda (3.3.106.0)
	* - Added the ProvisionedConcurrency type and operations. Allocate provisioned concurrency to enable your function to scale up without fluctuations in latency. Use PutProvisionedConcurrencyConfig to configure provisioned concurrency on a version of a function, or on an alias.
* RDS (3.3.114.0)
	* This release adds support for the Amazon RDS Proxy
* Rekognition (3.3.103.0)
	* This SDK Release introduces APIs for Amazon Rekognition Custom Labels feature (CreateProjects, CreateProjectVersion,DescribeProjects, DescribeProjectVersions, StartProjectVersion, StopProjectVersion and DetectCustomLabels).  Also new is  AugmentedAI (Human In The Loop) Support for DetectModerationLabels in Amazon Rekognition.
* SageMaker (3.3.108.0)
	* You can now use SageMaker Autopilot for automatically training and tuning candidate models using a combination of various feature engineering, ML algorithms, and hyperparameters determined from the user's input data. SageMaker Automatic Model Tuning now supports tuning across multiple algorithms. With Amazon SageMaker Experiments users can create Experiments, ExperimentTrials, and ExperimentTrialComponents to track, organize, and evaluate their ML training jobs. With Amazon SageMaker Debugger, users can easily debug training jobs using a number of pre-built rules provided by Amazon SageMaker, or build custom rules. With Amazon SageMaker Processing, users can run on-demand, distributed, and fully managed jobs for data pre- or post- processing or model evaluation. With Amazon SageMaker Model Monitor, a user can create MonitoringSchedules to automatically monitor endpoints to detect data drift and other issues and get alerted on them. This release also includes the preview version of Amazon SageMaker Studio with Domains, UserProfiles, and Apps. This release also includes the preview version of Amazon Augmented AI to easily implement human review of machine learning predictions by creating FlowDefinitions, HumanTaskUis, and HumanLoops.
* StepFunctions (3.3.103.0)
	* This release of the AWS Step Functions SDK introduces support for Express Workflows.

### 3.3.642.0 (2019-12-03 19:17 UTC)
* AugmentedAIRuntime (3.3.100.0)
	* This release adds support for Amazon Augmented AI, which makes it easy to build workflows for human review of machine learning predictions.
* CodeGuruProfiler (3.3.100.0)
	* (New Service) Amazon CodeGuru Profiler analyzes application CPU utilization and latency characteristics to show you where you are spending the most cycles in your application. This analysis is presented in an interactive flame graph that helps you easily understand which paths consume the most resources, verify that your application is performing as expected, and uncover areas that can be optimized further.
* CodeGuruReviewer (3.3.100.0)
	* This is the preview release of Amazon CodeGuru Reviewer.
* ComputeOptimizer (3.3.100.0)
	* Initial release of AWS Compute Optimizer. AWS Compute Optimizer recommends optimal AWS Compute resources to reduce costs and improve performance for your workloads.
* EC2 (3.3.142.0)
	* This release adds support for the following features: 1. An option to enable acceleration for Site-to-Site VPN connections, to improve connection performance by leveraging AWS Global Accelerator; 2. Inf1 instances featuring up to 16 AWS Inferentia chips, custom-built for ML inference applications to deliver low latency and high throughput performance. Use Inf1 instances to run high scale ML inference applications such as image recognition, speech recognition, natural language processing, personalization, and fraud detection at the lowest cost in the cloud. Inf1 instances will soon be available for use with Amazon SageMaker, Amazon EKS and Amazon ECS. To get started, see https://aws.amazon.com/ec2/instance-types/Inf1; 3. The ability to associate route tables with internet gateways and virtual private gateways, and define routes to insert network and security virtual appliances in the path of inbound and outbound traffic. For more information on Amazon VPC Ingress Routing, see https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html#gateway-route-table; 4. AWS Local Zones that place compute, storage, database, and other select services closer to you for applications that require very low latency to your end-users. AWS Local Zones also allow you to seamlessly connect to the full range of services in the AWS Region through the same APIs and tool sets; 5. Launching and viewing EC2 instances and EBS volumes running locally in Outposts. This release also introduces a new local gateway (LGW) with Outposts to enable connectivity between Outposts and local on-premises networks as well as the internet; 6. Peering Transit Gateways between regions simplifying creation of secure and private global networks on AWS; 7. Transit Gateway Multicast, enabling multicast routing within and between VPCs using Transit Gateway as a multicast router.
* ECS (3.3.112.0)
	* This release supports ECS Capacity Providers, Fargate Spot, and ECS Cluster Auto Scaling.  These features enable new ways for ECS to manage compute capacity used by tasks.
* EKS (3.3.105.0)
	* Introducing Amazon EKS with Fargate. Customers can now use Amazon EKS to launch pods directly onto AWS Fargate, the serverless compute engine built for containers on AWS. 
* Elasticsearch (3.3.103.0)
	* UltraWarm storage provides a cost-effective way to store large amounts of read-only data on Amazon Elasticsearch Service. Rather than attached storage, UltraWarm nodes use Amazon S3 and a sophisticated caching solution to improve performance. For indices that you are not actively writing to and query less frequently, UltraWarm storage offers significantly lower costs per GiB. In Elasticsearch, these warm indices behave just like any other index. You can query them using the same APIs or use them to create dashboards in Kibana.
* FraudDetector (3.3.100.0)
	* Amazon Fraud Detector is a fully managed service that makes it easy to identify potentially fraudulent online activities such as online payment fraud and the creation of fake accounts. Amazon Fraud Detector uses your data, machine learning (ML), and more than 20 years of fraud detection expertise from Amazon to automatically identify potentially fraudulent online activity so you can catch more fraud faster.
* Kendra (3.3.100.0)
	* It is a preview launch of Amazon Kendra. Amazon Kendra is a managed, highly accurate and easy to use enterprise search service that is powered by machine learning.
* NetworkManager (3.3.100.0)
	* This is the initial SDK release for AWS Network Manager.
* Outposts (3.3.100.0)
	* This is the initial release for AWS Outposts, a fully managed service that extends AWS infrastructure, services, APIs, and tools to customer sites. AWS Outposts enables you to launch and run EC2 instances and EBS volumes locally at your on-premises location. This release introduces new APIs for creating and viewing Outposts. 
* S3 (3.3.109.0)
	* Updated to use new Core, version 3.3.104.0
	* Amazon S3 Access Points is a new S3 feature that simplifies managing data access at scale for shared data sets on Amazon S3. Access Points provide a customizable way to access the objects in a bucket, with a unique hostname and access policy that enforces the specific permissions and network controls for any request made through the access point. This represents a new way of provisioning access to shared data sets.
* S3Control (3.3.102.0)
	* Amazon S3 Access Points is a new S3 feature that simplifies managing data access at scale for shared data sets on Amazon S3. Access Points provide a customizable way to access the objects in a bucket, with a unique hostname and access policy that enforces the specific permissions and network controls for any request made through the access point. This represents a new way of provisioning access to shared data sets.
* Textract (3.3.102.0)
	* This SDK Release introduces Amazon Augmented AI support for Amazon Textract AnalyzeDocument API. Image byte payloads for synchronous operations have increased from 5 MB to 10 MB.
* Core 3.3.104.0
	* Changes to support Amazon S3 Access Points
Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.641.0 (2019-12-02 23:52 UTC)
* AccessAnalyzer (3.3.100.0)
	* Introducing AWS IAM Access Analyzer, an IAM feature that makes it easy for AWS customers to ensure that their resource-based policies provide only the intended access to resources outside their AWS accounts.

### 3.3.640.0 (2019-12-02 09:31 UTC)
* EC2 (3.3.141.0)
	* AWS now provides a new BYOL experience for software licenses, such as Windows and SQL Server, that require a dedicated physical server. You can now enjoy the flexibility and cost effectiveness of using your own licenses on Amazon EC2 Dedicated Hosts, but with the simplicity, resiliency, and elasticity of AWS. You can specify your Dedicated Host management preferences, such as host allocation, host capacity utilization, and instance placement in AWS License Manager.  Once set up, AWS takes care of these administrative tasks on your behalf, so that you can seamlessly launch virtual machines (instances) on Dedicated Hosts just like you would launch an EC2 instance with AWS provided licenses.
* Imagebuilder (3.3.100.0)
	* This is the first release of EC2 Image Builder, a service that provides a managed experience for automating the creation of EC2 AMIs.
* LicenseManager (3.3.101.0)
	* AWS License Manager now automates discovery of bring-your-own-license usage across the customers organization. With few simple settings, customers can add bring your own license product information along with licensing rules, which would enable License Manager to automatically track the instances that have the specified products installed. If License Manager detects any violation of licensing rules, it would notify the customers designated license administrator to take corrective action.
* Schemas (3.3.100.0)
	* This release introduces support for Amazon EventBridge schema registry, making it easy to discover and write code for events in EventBridge.
* Core 3.3.103.71
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.639.0 (2019-11-26 19:12 UTC)
* CognitoIdentityProvider (3.3.107.0)
	* This release adds a new setting for a user pool to configure which recovery methods a user can use to recover their account via the forgot password operation.
* DirectoryService (3.3.101.0)
	* This release will introduce optional encryption over LDAP network traffic using SSL certificates between customer's self-managed AD and AWS Directory Services instances. The release also provides APIs for Certificate management.
* DynamoDBv2 (3.3.104.0)
	* 1) Amazon Contributor Insights for Amazon DynamoDB is a diagnostic tool for identifying frequently accessed keys and understanding database traffic trends. 2) Support for displaying new fields when a table's encryption state is Inaccessible or the table have been Archived.
* ElasticInference (3.3.100.0)
	* Amazon Elastic Inference allows customers to attach Elastic Inference Accelerators to Amazon EC2 and Amazon ECS tasks, thus providing low-cost GPU-powered acceleration and reducing the cost of running deep learning inference. This release allows customers to add or remove tags for their Elastic Inference Accelerators.
* MediaTailor (3.3.102.0)
	* AWS Elemental MediaTailor SDK now allows configuration of the Live Pre-Roll feature for HLS and DASH streams.
* Organizations (3.3.104.0)
	* Introduces the DescribeEffectivePolicy action, which returns the contents of the policy that's in effect for the account.
* QuickSight (3.3.102.4)
	* Documentation updates for QuickSight
* RDSDataService (3.3.103.0)
	* Type hints to improve handling of some specific parameter types (date/time, decimal etc) for ExecuteStatement and BatchExecuteStatement APIs
* ResourceGroupsTaggingAPI (3.3.103.0)
	* You can use tag policies to help standardize on tags across your organization's resources.
* ServerlessApplicationRepository (3.3.101.0)
	* AWS Serverless Application Repository now supports verified authors. Verified means that AWS has made a good faith review, as a reasonable and prudent service provider, of the information provided by the requester and has confirmed that the requester's identity is as claimed.
* WorkSpaces (3.3.107.0)
	* For the WorkspaceBundle API, added the image identifier and the time of the last update.
* Core 3.3.103.70
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.638.0 (2019-11-25 21:21 UTC)
* AlexaForBusiness (3.3.107.0)
	* API update for Alexa for Business: This update enables the use of meeting room configuration that can be applied to a room profile. These settings help improve and measure utilization on Alexa for Business enabled rooms. New features include end meeting reminders, intelligent room release and room utilization analytics report.
* AppConfig (3.3.100.0)
	* Introducing AWS AppConfig, a new service that enables customers to quickly deploy validated configurations to applications of any size in a controlled and monitored fashion.
* ApplicationAutoScaling (3.3.103.0)
	* This release supports auto scaling of document classifier endpoints for Comprehend; and supports target tracking based on the average capacity utilization metric for AppStream 2.0 fleets. 
* ApplicationInsights (3.3.102.0)
	* CloudWatch Application Insights for .NET and SQL Server includes the follwing features: -Tagging Create and manage tags for your applications.-Custom log pattern matching. Define custom log patterns to be detected and monitored.-Resource-level permissions. Specify applications users can access.
* Athena (3.3.103.0)
	* This release adds additional query lifecycle metrics to the QueryExecutionStatistics object in GetQueryExecution response.
* CloudWatch (3.3.104.0)
	* This release adds a new feature called "Contributor Insights". "Contributor Insights" supports the following 6 new APIs (PutInsightRule, DeleteInsightRules, EnableInsightRules, DisableInsightRules, DescribeInsightRules and GetInsightRuleReport). 
* CodeBuild (3.3.106.0)
	* CodeBuild adds support for test reporting
* CognitoIdentityProvider (3.3.106.0)
	* Amazon Cognito Userpools now supports Sign in with Apple as an Identity Provider.
* Comprehend (3.3.107.0)
	* Amazon Comprehend now supports real-time analysis with Custom Classification
* CostExplorer (3.3.106.0)
	* This launch provides customers with access to Cost Category Public Beta APIs.
* DLM (3.3.104.0)
	* You can now set time based retention policies on Data Lifecycle Manager. With this launch, DLM allows you to set snapshot retention period in the following interval units: days, weeks, months and years.
* EC2 (3.3.140.0)
	* This release adds two new APIs: 1. ModifyDefaultCreditSpecification, which allows you to set default credit specification at the account level per AWS Region, per burstable performance instance family, so that all new burstable performance instances in the account launch using the new default credit specification. 2. GetDefaultCreditSpecification, which allows you to get current default credit specification per AWS Region, per burstable performance instance family. This release also adds new client exceptions for StartInstances and StopInstances.
* ElasticLoadBalancingV2 (3.3.104.0)
	* This release of Elastic Load Balancing V2 adds new subnet features for Network Load Balancers and a new routing algorithm for Application Load Balancers. 
* Greengrass (3.3.105.0)
	* IoT Greengrass supports machine learning resources in 'No container' mode.
* IoT (3.3.105.0)
	* This release adds: 1) APIs for fleet provisioning claim and template, 2) endpoint configuration and custom domains, 3) support for enhanced custom authentication, d) support for 4 additional audit checks: Device and CA certificate key quality checks, IoT role alias over-permissive check and IoT role alias access to unused services check, 5) extended capability of AWS IoT Rules Engine to support IoT SiteWise rule action. The IoT SiteWise rule action lets you send messages from IoT sensors and applications to IoT SiteWise asset properties
* IoTSecureTunneling (3.3.100.0)
	* This release adds support for IoT Secure Tunneling to remote access devices behind restricted firewalls.
* KeyManagementService (3.3.102.0)
	* AWS Key Management Service (KMS) now enables creation and use of asymmetric Customer Master Keys (CMKs) and the generation of asymmetric data key pairs.
* KinesisAnalyticsV2 (3.3.102.0)
	* Kinesis Data Analytics service adds support to configure Java applications to access resources in a VPC. Also releasing support to configure Java applications to set allowNonRestoreState flag through the service APIs.
* Lambda (3.3.105.0)
	* Added the function state and update status to the output of GetFunctionConfiguration and other actions. Check the state information to ensure that a function is ready before you perform operations on it. Functions take time to become ready when you connect them to a VPC.Added the EventInvokeConfig type and operations to configure error handling options for asynchronous invocation. Use PutFunctionEventInvokeConfig to configure the number of retries and the maximum age of events when you invoke the function asynchronously.Added on-failure and on-success destination settings for asynchronous invocation. Configure destinations to send an invocation record to an SNS topic, an SQS queue, an EventBridge event bus, or a Lambda function.Added error handling options to event source mappings. This enables you to configure the number of retries, configure the maximum age of records, or retry with smaller batches when an error occurs when a function processes a Kinesis or DynamoDB stream.Added the on-failure destination setting to event source mappings. This enables you to send discarded events to an SNS topic or SQS queue when all retries fail or when the maximum record age is exceeded when a function processes a Kinesis or DynamoDB stream.Added the ParallelizationFactor option to event source mappings to increase concurrency per shard when a function processes a Kinesis or DynamoDB stream.
* Lex (3.3.104.0)
	* Amazon Lex adds "sessionId" attribute to the PostText and PostContent response.
* MediaConvert (3.3.111.0)
	* AWS Elemental MediaConvert SDK has added support for 8K outputs and support for QuickTime Animation Codec (RLE) inputs.
* MediaLive (3.3.106.0)
	* AWS Elemental MediaLive now supports the ability to create a multiple program transport stream (MPTS).
* MediaPackageVod (3.3.103.0)
	* Adds a domain name to PackagingGroups, representing the fully qualified domain name for Assets created in the group.
* RAM (3.3.102.0)
	* AWS RAM provides new APIs to view the permissions granted to principals in a resource share. This release also creates corresponding resource shares for supported services that use resource policies, as well as an API to promote them to standard shares that can be managed in RAM.
* RDS (3.3.113.0)
	* Cluster Endpoints can now be tagged by using --tags in the create-db-cluster-endpoint API
* Redshift (3.3.105.0)
	* This release contains changes for 1. Redshift Scheduler 2. Update to the DescribeNodeConfigurationOptions to include a new action type recommend-node-config
* SageMakerRuntime (3.3.101.0)
	* Amazon SageMaker Runtime now supports a new TargetModel header to invoke a specific model hosted on multi model endpoints.
* SimpleEmailV2 (3.3.101.0)
	* This release includes support for automatically suppressing email addresses that result in hard bounce or complaint events at the account level, and for managing addresses on this account-level suppression list.
* SimpleSystemsManagement (3.3.113.0)
	* AWS Systems Manager Documents now supports more Document Types: ApplicationConfiguration, ApplicationConfigurationSchema and DeploymentStrategy. This release also extends Document Permissions capabilities and introduces a new Force flag for DeleteDocument API.
* WAFV2 (3.3.100.0)
	* This release introduces new set of APIs (wafv2) for AWS WAF. Major changes include single set of APIs for creating/updating resources in global and regional scope, and rules are configured directly into web ACL instead of being referenced. The previous APIs (waf and waf-regional) are now referred as AWS WAF Classic. For more information visit: https://docs.aws.amazon.com/waf/latest/APIReference/Welcome.html
* Core 3.3.103.69
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.637.0 (2019-11-22 20:14 UTC)
* ApplicationAutoScaling (3.3.102.0)
	* Update default endpoint for Application Auto Scaling.
* AutoScalingPlans (3.3.101.0)
	* Update default endpoint for AWS Auto Scaling.
* CertificateManager (3.3.101.0)
	* This release adds support for Tag-Based IAM for AWS Certificate Manager and adding tags to certificates upon creation.
* CodeBuild (3.3.105.0)
	* Add Canonical ARN to LogsLocation.
* EC2 (3.3.139.0)
	* This release adds two new APIs (DescribeInstanceTypes and DescribeInstanceTypeOfferings) that give customers access to instance type attributes and regional and zonal offerings.
* ElasticMapReduce (3.3.104.0)
	* Amazon EMR adds support for concurrent step execution and cancelling running steps. Amazon EMR has added a new Outpost ARN field in the ListCluster and DescribeCluster API responses that is populated for clusters launched in an AWS Outpost subnet.
* ForecastService (3.3.101.0)
	* This release adds two key updates to existing APIs. 1. Amazon Forecast can now generate forecasts in any quantile using the optional parameter forecastTypes in the CreateForecast API and 2. You can get additional details (metrics and relevant error messages) on your AutoML runs using the DescribePredictor and GetAccuracyMetrics APIs.
* MediaPackageVod (3.3.102.0)
	* Includes the submission time of Asset ingestion request in the API response for Create/List/Describe Assets.
* Rekognition (3.3.102.0)
	* This release adds enhanced face filtering support to the IndexFaces API operation, and introduces face filtering for CompareFaces and SearchFacesByImage API operations.
* SecurityToken (3.3.104.0)
	* Support tagging for STS sessions and tag based access control for the STS APIs
* SimpleNotificationService (3.3.101.92)
	* Added documentation for the dead-letter queue feature.
* SimpleSystemsManagement (3.3.112.0)
	* Add RebootOption and LastNoRebootInstallOperationTime for DescribeInstancePatchStates and DescribeInstancePatchStatesForPatchGroup API
* Core 3.3.103.68
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.636.0 (2019-11-21 22:52 UTC)
* Amplify (3.3.104.0)
	* This release of AWS Amplify Console introduces support for backend environments. Backend environments are containers for AWS deployments. Each environment is a collection of AWS resources.
* AppSync (3.3.103.0)
	* AppSync: AWS AppSync now supports the ability to add, configure, and maintain caching for your AWS AppSync GraphQL API.
* AWSMarketplaceMetering (3.3.101.3)
	* Documentation updates for the AWS Marketplace Metering Service.
* ConfigService (3.3.106.0)
	* AWS Config launches Custom Configuration Items. A new feature which allows customers to publish resource configuration for third-party resources, custom, or on-premises servers.
* Connect (3.3.103.0)
	* This release adds a new API: StartChatContact. You can use it to programmatically start a chat on the specified Amazon Connect instance. Learn more here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html 
* ConnectParticipant (3.3.100.0)
	* This release adds 5 new APIs: CreateParticipantConnection, DisconnectParticipant, GetTranscript, SendEvent, and SendMessage. For Amazon Connect chat, you can use them to programmatically perform participant actions on the configured Amazon Connect instance. Learn more here: https://docs.aws.amazon.com/connect-participant/latest/APIReference/Welcome.html
* DynamoDBv2 (3.3.103.0)
	* With this release, you can convert an existing Amazon DynamoDB table to a global table by adding replicas in other AWS Regions.
* EC2 (3.3.138.0)
	* This release adds support for attaching AWS License Manager Configurations to Amazon Machine Image (AMI) using ImportImage API; and adds support for running different instance sizes on EC2 Dedicated Hosts
* Glue (3.3.112.0)
	* This release adds support for Glue 1.0 compatible ML Transforms.
* Lex (3.3.103.0)
	* Amazon Lex now supports Sentiment Analysis
* LexModelBuildingService (3.3.101.0)
	* Amazon Lex now supports Sentiment Analysis
* SimpleSystemsManagement (3.3.111.0)
	* The release contains new API and API changes for AWS Systems Manager Explorer product.
* TranscribeService (3.3.111.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Hebrew (he-IL), Swiss German (de-CH), Japanese (ja-JP), Turkish (tr-TR), Arabic-Gulf (ar-AE), Malay (ms-MY), Telugu (te-IN)
* Core 3.3.103.67
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.635.0 (2019-11-20 19:24 UTC)
* ApplicationDiscoveryService (3.3.102.0)
	* New exception type for use with Migration Hub home region
* Chime (3.3.105.0)
	* Adds APIs to create and manage meeting session resources for the Amazon Chime SDK
* CloudTrail (3.3.102.0)
	*  1. This release adds two new APIs, GetInsightSelectors and PutInsightSelectors, which let you configure CloudTrail Insights event delivery on a trail. An Insights event is a new type of event that is generated when CloudTrail detects unusual activity in your AWS account. In this release, only "ApiCallRateInsight" is a supported Insights event type. 2. This release also adds the new "ExcludeManagementEventSource" option to the existing PutEventSelectors API. This field currently supports only AWS Key Management Services.
* CodeCommit (3.3.106.0)
	* This release adds support for creating pull request approval rules and pull request approval rule templates in AWS CodeCommit. This allows developers to block merges of pull requests, contingent on the approval rules being satisfiied.
* DataSync (3.3.107.0)
	* Update to configure task to run periodically on a schedule
* DLM (3.3.103.0)
	* DLM now supports Fast Snapshot Restore. You can enable Fast Restore on snapshots created by DLM, provide the AZs and the number of snapshots to be enabled with this capability.
* EC2 (3.3.137.0)
	* This release of Amazon Elastic Compute Cloud (Amazon EC2) introduces support for Amazon Elastic Block Store (Amazon EBS) fast snapshot restores.
* ECS (3.3.111.0)
	* Added support for CPU and memory task-level overrides on the RunTask and StartTask APIs.  Added location information to Tasks.
* FSx (3.3.102.0)
	* Announcing a Multi-AZ deployment type for Amazon FSx for Windows File Server, providing fully-managed Windows file storage with high availability and redundancy across multiple AWS Availability Zones.
* KinesisFirehose (3.3.103.0)
	* With this release, Amazon Kinesis Data Firehose allows server side encryption with customer managed CMKs. Customer managed CMKs ( "Customer Master Keys") are AWS Key Management Service (KMS) keys that are fully managed by the customer. With customer managed CMKs, customers can establish and maintain their key policies, IAM policies, rotating policies and add tags. For more information about AWS KMS and CMKs, please refer to:  https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html. Please refer to the following link to create CMKs: https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-create-cmk.html
* MediaStore (3.3.102.0)
	* This release fixes a broken link in the SDK documentation.
* MigrationHub (3.3.101.0)
	* New exception type for use with Migration Hub home region
* MigrationHubConfig (3.3.100.0)
	* AWS Migration Hub Config Service allows you to get and set the Migration Hub home region for use with AWS Migration Hub and Application Discovery Service
* QuickSight (3.3.102.0)
	* Amazon QuickSight now supports programmatic creation and management of data sources, data sets, dashboards and templates with new APIs. Templates hold dashboard metadata, and can be used to create copies connected to the same or different dataset as required. Also included in this release are APIs for SPICE ingestions, fine-grained access control over AWS resources using AWS Identity and Access Management (IAM) policies, as well AWS tagging. APIs are supported for both Standard and Enterprise Edition, with edition-specific support for specific functionality.
* S3 (3.3.108.0)
	* This release introduces support for Amazon S3 Replication Time Control, a new feature of S3 Replication that provides a predictable replication time backed by a Service Level Agreement. S3 Replication Time Control helps customers meet compliance or business requirements for data replication, and provides visibility into the replication process with new Amazon CloudWatch Metrics.
* StorageGateway (3.3.110.0)
	* The new DescribeAvailabilityMonitorTest API provides the results of the most recent High Availability monitoring test. The new StartAvailabilityMonitorTest API verifies the storage gateway is configured for High Availability monitoring. The new ActiveDirectoryStatus response element has been added to the DescribeSMBSettings and JoinDomain APIs to indicate the status of the gateway after the most recent JoinDomain operation. The new TimeoutInSeconds parameter of the JoinDomain API allows for the configuration of the timeout in which the JoinDomain operation must complete.
* TranscribeService (3.3.110.0)
	* With this release Amazon Transcribe enables alternative transcriptions so that you can see different interpretations of transcribed audio.

### 3.3.634.1 (2019-11-19 22:36 UTC)
* EC2 (3.3.136.1)
	* Updated to use new Core, version 3.3.103.66
	* Updates obsolete IMDS methods to obtain a metadata token that is used with subsequent metadata calls. A potential breaking change exists where exceptions other than WebException may no longer be thrown. Instead null will be returned for consistency between targets.
* Lambda (3.3.104.1)
	* Allow clearing of Lambda Environment variables via UpdateLambdaConfiguration.
* Core 3.3.103.66
	* Fix unmarshalling of JSON arrays that contain forward slashes in names; Updates IMDS to obtain a metadata token that is used with subsequent metadata calls. This also updates IMDS based instance profile credentials to use metadata tokens as part of IMDS calls. A potential breaking change exists where exceptions other than WebException may no longer be thrown. Instead null will be returned for consistency between targets.
	* All services packages updated to require new Core

### 3.3.634.0 (2019-11-19 21:03 UTC)
* AutoScaling (3.3.101.0)
	* Amazon EC2 Auto Scaling now supports Instance Weighting and Max Instance Lifetime. Instance Weighting allows specifying the capacity units for each instance type included in the MixedInstancesPolicy and how they would contribute to your application's performance. Max Instance Lifetime allows specifying the maximum length of time that an instance can be in service. If any instances are approaching this limit, Amazon EC2 Auto Scaling gradually replaces them.
* CloudFormation (3.3.103.0)
	* This release of AWS CloudFormation StackSets enables users to detect drift on a stack set and the stack instances that belong to that stack set.
* CodeBuild (3.3.104.0)
	* Add support for ARM and GPU-enhanced build environments and a new SSD-backed Linux compute type with additional CPU and memory in CodeBuild
* ConfigService (3.3.105.0)
	* AWSConfig launches support for conformance packs. A conformance pack is a new resource type that allows you to package a collection of Config rules and remediation actions into a single entity. You can create and deploy conformance packs into your account or across all accounts in your organization
* EC2 (3.3.136.0)
	* This release adds support for RunInstances to specify the metadata options for new instances; adds a new API, ModifyInstanceMetadataOptions, which lets you modify the metadata options for a running or stopped instance; and adds support for CreateCustomerGateway to specify a device name.
* ElasticLoadBalancingV2 (3.3.103.0)
	* This release allows forward actions on Application Load Balancers to route requests to multiple target groups, based on the weight you specify for each target group.
* IdentityManagement (3.3.104.0)
	* IAM reports the timestamp when a role's credentials were last used to make an AWS request. This helps you identify unused roles and remove them confidently from your AWS accounts.
* IoT (3.3.104.0)
	* As part of this release, we are extending the capability of AWS IoT Rules Engine to send messages directly to customer's own web services/applications. Customers can now create topic rules with HTTP actions to route messages from IoT Core directly to URL's that they own. Ownership is proved by creating and confirming topic rule destinations.
* Lambda (3.3.104.0)
	* This release provides three new runtimes to support Node.js 12 (initially 12.13.0), Python 3.8 and Java 11.  
* Core 3.3.103.65
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.633.0 (2019-11-18 19:17 UTC)
* CloudFormation (3.3.102.0)
	* This release introduces APIs for the CloudFormation Registry, a new service to submit and discover resource providers with which you can manage third-party resources natively in CloudFormation.
* CostExplorer (3.3.105.0)
	* add EstimatedOnDemandCostWithCurrentCommitment to GetSavingsPlansPurchaseRecommendationRequest API
* Pinpoint (3.3.104.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing message templates for messages that are sent through the voice channel. It also introduces support for specifying default values for message variables in message templates. 
* RDS (3.3.112.14)
	* Documentation updates for rds
* S3 (3.3.107.0)
	* Added support for S3 Replication for existing objects. This release allows customers who have requested and been granted access to replicate existing S3 objects across buckets.
* SageMaker (3.3.107.0)
	* Amazon SageMaker now supports multi-model endpoints to host multiple models on an endpoint using a single inference container.
* SimpleSystemsManagement (3.3.110.0)
	* The release contains new API and API changes for AWS Systems Manager Explorer product.

### 3.3.632.0 (2019-11-15 19:38 UTC)
* Chime (3.3.104.0)
	* This release adds support for Chime Room Management APIs
* CloudWatchLogs (3.3.101.48)
	* Documentation updates for logs
* CognitoIdentityProvider (3.3.105.0)
	* This release adds a new option in the User Pool to allow specifying sender's name in the emails sent by Amazon Cognito. This release also adds support to add SES Configuration Set to the emails sent by Amazon Cognito.
* EC2 (3.3.135.0)
	* You can now add tags while copying snapshots. Previously, a user had to first copy the snapshot and then add tags to the copied snapshot manually. Moving forward, you can specify the list of tags you wish to be applied to the copied snapshot as a parameter on the Copy Snapshot API. 
* EKS (3.3.104.0)
	* Introducing Amazon EKS managed node groups, a new feature that lets you easily provision worker nodes for Amazon EKS clusters and keep them up to date using the Amazon EKS management console, CLI, and APIs.
* ElasticLoadBalancingV2 (3.3.102.64)
	* Documentation-only change to the default value of the routing.http.drop_invalid_header_fields.enabled attribute.
* ElasticMapReduce (3.3.103.0)
	* Access to the cluster ARN makes it easier for you to author resource-level permissions policies in AWS Identity and Access Management. To simplify the process of obtaining the cluster ARN, Amazon EMR has added a new field containing the cluster ARN to all API responses that include the cluster ID.
* GuardDuty (3.3.104.0)
	* This release includes new operations related to findings export, including: CreatePublishingDestination, UpdatePublishingDestination, DescribePublishingDestination, DeletePublishingDestination and ListPublishingDestinations.
* MediaConvert (3.3.110.0)
	* AWS Elemental MediaConvert SDK has added support for DolbyVision encoding, and SCTE35 & ESAM insertion to DASH ISO EMSG.
* SimpleSystemsManagement (3.3.109.1)
	* This release updates AWS Systems Manager Parameter Store documentation for the enhanced search capability.
* WorkSpaces (3.3.106.0)
	* Added APIs to register your directories with Amazon WorkSpaces and to modify directory details. 

### 3.3.631.0 (2019-11-14 19:28 UTC)
* AWSMarketplaceMetering (3.3.101.0)
	* Added CustomerNotEntitledException in MeterUsage API for Container use case.
* CognitoIdentityProvider (3.3.104.0)
	* This release adds a new setting at user pool client to prevent user existence related errors during authentication, confirmation, and password recovery related operations. This release also adds support to enable or disable specific authentication flows for a user pool client.
* Connect (3.3.102.0)
	* This release enhances the existing user management APIs and adds 3 new APIs - TagResource, UntagResource, and ListTagsForResource to support tagging Amazon Connect users, which facilitates more granular access controls for Amazon Connect users within an Amazon Connect instance. You can learn more about the new APIs here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html.
* Personalize (3.3.103.0)
	* Amazon Personalize: Adds ability to get batch recommendations by creating a batch inference job.
* SimpleSystemsManagement (3.3.109.0)
	* Updates support for adding attachments to Systems Manager Automation documents
* Core 3.3.103.64
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.630.0 (2019-11-13 21:29 UTC)
* CloudSearch (3.3.101.0)
	* Amazon CloudSearch domains let you require that all traffic to the domain arrive over HTTPS. This security feature helps you block clients that send unencrypted requests to the domain.
* DataExchange (3.3.100.0)
	* Introducing AWS Data Exchange, a service that makes it easy for AWS customers to securely create, manage, access, and exchange data sets in the cloud.
* DLM (3.3.102.0)
	* You can now add tags to a lifecycle policy in Data Lifecycle Manager (DLM). Tags allow you to categorize your policies in different ways, such as by department, purpose or owner. You can also enable resource level permissions based on tags to set access control on ability to modify or delete a tagged policy.
* IoT (3.3.103.0)
	* This release adds the custom fields definition support in the index definition for AWS IoT Fleet Indexing Service. Custom fields can be used as an aggregation field to run aggregations with both existing GetStatistics API and newly added GetCardinality, GetPercentiles APIs. GetStatistics will return all statistics (min/max/sum/avg/count...) with this release. For more information, please refer to our latest documentation: https://docs.aws.amazon.com/iot/latest/developerguide/iot-indexing.html
* SimpleEmailV2 (3.3.100.0)
	* This is the first release of version 2 of the Amazon SES API. You can use this API to configure your Amazon SES account, and to send email. This API extends the functionality that exists in the previous version of the Amazon SES API.
* Core 3.3.103.63
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.629.0 (2019-11-12 21:03 UTC)
* CodePipeline (3.3.104.0)
	* AWS CodePipeline now supports the use of variables in action configuration.
* DynamoDBv2 (3.3.102.0)
	* Amazon DynamoDB enables you to restore your data to a new DynamoDB table using a point-in-time or on-demand backup. You now can modify the settings on the new restored table. Specifically, you can exclude some or all of the local and global secondary indexes from being created with the restored table. In addition, you can change the billing mode and provisioned capacity settings.
* ElasticLoadBalancingV2 (3.3.102.61)
	* You can configure your Application Load Balancer to either drop invalid header fields or forward them to targets.
* MarketplaceCatalog (3.3.100.0)
	* This is the first release for the AWS Marketplace Catalog service which allows you to list, describe and manage change requests on your published entities on AWS Marketplace. 
* TranscribeService (3.3.109.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Welsh English (en-WL), Scottish English(en-AB), Irish English(en-IE), Farsi(fa-IR), Tamil(ta-IN), Indonesian(id-ID), Portuguese (pt-PT), Dutch(nl-NL).

### 3.3.628.0 (2019-11-11 20:27 UTC)
* CloudFormation (3.3.101.0)
	* The Resource Import feature enables customers to import existing AWS resources into new or existing CloudFormation Stacks.
* CostExplorer (3.3.104.0)
	* This launch provides customers with access to GetCostAndUsageWithResources API.

### 3.3.627.0 (2019-11-08 20:24 UTC)
* CognitoIdentity (3.3.101.0)
	* This release adds support for disabling classic flow.
* ECR (3.3.102.7)
	* This release contains ticket fixes for Amazon ECR.
* Core 3.3.103.62
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.626.0 (2019-11-07 20:37 UTC)
* Comprehend (3.3.106.0)
	* This release adds new languages (ar, hi, ko, ja, zh, zh-TW) for Amazon Comprehend's DetectSentiment, DetectEntities, DetectKeyPhrases, BatchDetectSentiment, BatchDetectEntities and BatchDetectKeyPhrases APIs
* SimpleSystemsManagement (3.3.108.0)
	* AWS Systems Manager Session Manager target length increased to 400.
* SSO (3.3.100.0)
	* This is an initial release of AWS Single Sign-On (SSO) end-user access. This release adds support for accessing AWS accounts assigned in AWS SSO using short term credentials.
* SSOOIDC (3.3.100.0)
	* This is an initial release of AWS Single Sign-On OAuth device code authorization service.
* Core 3.3.103.61
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.625.0 (2019-11-06 23:19 UTC)
* SavingsPlans (3.3.101.0)
	* This is the first release of Savings Plans, a new flexible pricing model that offers low prices on Amazon EC2 and AWS Fargate usage.
* Core 3.3.103.60
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.624.0 (2019-11-06 19:59 UTC)
* Budgets (3.3.101.72)
	* Documentation updates for budgets to track Savings Plans utilization and coverage
* CodeBuild (3.3.103.0)
	* Add support for Build Number, Secrets Manager and Exported Environment Variables.
* CostExplorer (3.3.103.0)
	* This launch provides customers with access to Savings Plans management APIs.
* ElasticFileSystem (3.3.103.0)
	* EFS customers can select a lifecycle policy that automatically moves files that have not been accessed for 7 days into the EFS Infrequent Access (EFS IA) storage class. EFS IA provides price/performance that is cost-optimized for files that are not accessed every day.
* SavingsPlans (3.3.100.0)
	* This is the first release of Savings Plans, a new flexible pricing model that offers low prices on Amazon EC2 and AWS Fargate usage.
* Signer (3.3.101.0)
	* This release adds support for tagging code-signing profiles in AWS Signer.

### 3.3.623.0 (2019-11-05 19:14 UTC)
* CodeStarNotifications (3.3.100.0)
	* This release adds a notification manager for events in repositories, build projects, deployments, and pipelines. You can now configure rules and receive notifications about events that occur for resources. Each notification includes a status message as well as a link to the resource (repository, build project, deployment application, or pipeline) whose event generated the notification.
* RDS (3.3.112.8)
	* Documentation updates for Amazon RDS
* Core 3.3.103.59
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.622.0 (2019-11-04 20:38 UTC)
* DAX (3.3.100.94)
	* Documentation updates for dax
* EC2 (3.3.134.5)
	* Documentation updates for ec2
* RoboMaker (3.3.108.0)
	* RoboMaker Fleet Management launch a feature to verify your robot is ready to download and install the new robot application using a download condition file, which is a script run on the robot prior to downloading the new deployment. 

### 3.3.621.0 (2019-11-02 00:12 UTC)
* CloudTrail (3.3.101.0)
	* This release adds two new APIs, GetTrail and ListTrails, and support for adding tags when you create a trail by using a new TagsList parameter on CreateTrail operations.
* DatabaseMigrationService (3.3.103.0)
	* This release contains task timeline attributes in replication task statistics. This release also adds a note to the documentation for the CdcStartPosition task request parameter. This note describes how to enable the use of native CDC start points for a PostgreSQL source by setting the new slotName extra connection attribute on the source endpoint to the name of an existing logical replication slot.
* Pinpoint (3.3.103.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing journeys, and querying analytics data for journeys.

### 3.3.620.0 (2019-10-31 18:12 UTC)
* Amplify (3.3.103.0)
	* This release of AWS Amplify Console introduces support for Web Previews. This feature allows user to create ephemeral branch deployments from pull request submissions made to a connected repository.  A pull-request preview deploys every pull request made to your Git repository to a unique preview URL.
* AWSSupport (3.3.100.93)
	* The status descriptions for TrustedAdvisorCheckRefreshStatus have been updated
* S3 (3.3.106.0)
	* S3 Inventory now supports a new field 'IntelligentTieringAccessTier' that reports the access tier (frequent or infrequent) of objects stored in Intelligent-Tiering storage class.
* Core 3.3.103.58
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.619.0 (2019-10-30 18:38 UTC)
* ElastiCache (3.3.107.0)
	* Amazon ElastiCache for Redis 5.0.5 now allows you to modify authentication tokens by setting and rotating new tokens. You can now modify active tokens while in use, or add brand-new tokens to existing encryption-in-transit enabled clusters that were previously setup without authentication tokens. This is a two-step process that allows you to set and rotate the token without interrupting client requests.
* Core 3.3.103.57
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.618.0 (2019-10-29 19:13 UTC)
* AppStream (3.3.105.0)
	* Adds support for providing domain names that can embed streaming sessions
* Cloud9 (3.3.101.0)
	* Added CREATING and CREATE_FAILED environment lifecycle statuses.  

### 3.3.617.0 (2019-10-28 21:24 UTC)
* S3 (3.3.105.0)
	* Adding support in SelectObjectContent for scanning a portion of an object specified by a scan range.
* Core 3.3.103.56
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.616.0 (2019-10-28 19:23 UTC)
* ECR (3.3.102.0)
	* This release of Amazon Elastic Container Registry Service (Amazon ECR) introduces support for image scanning. This identifies the software vulnerabilities in the container image based on the Common Vulnerabilities and Exposures (CVE) database.
* ElastiCache (3.3.106.0)
	* Amazon ElastiCache adds support for migrating Redis workloads hosted on Amazon EC2 into ElastiCache by syncing the data between the source Redis cluster and target ElastiCache for Redis cluster in real time. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/migrate-to-elasticache.html.
* Transfer (3.3.104.0)
	* This release adds logical directories support to your AWS SFTP server endpoint, so you can now create logical directory structures mapped to Amazon Simple Storage Service (Amazon S3) bucket paths for users created and stored within the service. Amazon S3 bucket names and paths can now be hidden from AWS SFTP users, providing an additional level of privacy to meet security requirements. You can lock down your SFTP users' access to designated folders (commonly referred to as 'chroot'), and simplify complex folder structures for data distribution through SFTP without replicating files across multiple users.
* Core 3.3.103.55
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.615.0 (2019-10-24 18:16 UTC)
* AppMesh (3.3.106.0)
	* This release adds support for the gRPC and HTTP/2 protocols.
* Chime (3.3.103.0)
	* * This release introduces Voice Connector PDX region and defaults previously created Voice Connectors to IAD. You can create Voice Connector Groups and add region specific Voice Connectors to direct telephony traffic across AWS regions in case of regional failures. With this release you can add phone numbers to Voice Connector Groups and can bulk move phone numbers between Voice Connectors, between Voice Connector and Voice Connector Groups and between Voice Connector Groups. Voice Connector now supports additional settings to enable SIP Log capture. This is in addition to the launch of Voice Connector Cloud Watch metrics in this release. This release also supports assigning outbound calling name (CNAM) to AWS account and individual phone numbers assigned to Voice Connectors. * Voice Connector now supports a setting to enable real time audio streaming delivered via Kinesis Audio streams. Please note that recording Amazon Chime Voice Connector calls with this feature maybe be subject to laws or regulations regarding the recording of telephone calls and other electronic communications. AWS Customer and their end users' have the responsibility to comply with all applicable laws regarding the recording, including properly notifying all participants in a recorded session or to a recorded communication that the session or communication is being recorded and obtain their consent.
* EC2 (3.3.134.0)
	* This release updates CreateFpgaImage to support tagging FPGA images on creation
* GameLift (3.3.104.0)
	* Amazon GameLift offers expanded hardware options for game hosting: Custom game builds can use the Amazon Linux 2 operating system, and fleets for both custom builds and Realtime servers can now use C5, M5, and R5 instance types.
* SageMaker (3.3.106.0)
	* Adds support for the new family of Elastic Inference Accelerators (eia2) for SageMaker Hosting and Notebook Services

### 3.3.614.0 (2019-10-23 23:18 UTC)
* Connect (3.3.101.0)
	* This release adds 4 new APIs ListQueues, ListPhoneNumbers, ListContactFlows, and ListHoursOfOperations, which can be used to programmatically list Queues, PhoneNumbers, ContactFlows, and HoursOfOperations configured for an Amazon Connect instance respectively. You can learn more about the new APIs here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html.
* Polly (3.3.103.0)
	* Amazon Polly adds new female voices: US Spanish - Lupe and Brazilian Portuguese - Camila; both voices are available in Standard and Neural engine.
* SecurityToken (3.3.103.3)
	* AWS Security Token Service (STS) now supports a regional configuration flag to make the client respect the region without the need for the endpoint parameter. 
* Core 3.3.103.54
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.613.0 (2019-10-22 19:23 UTC)
* IoTEvents (3.3.102.0)
	* Add support for new serial evaluation method for events in a detector model.
* OpsWorksCM (3.3.102.0)
	* AWS OpsWorks for Chef Automate (OWCA) now allows customers to use a custom domain and respective certificate, for their AWS OpsWorks For Chef Automate servers. Customers can now provide a CustomDomain, CustomCertificate and CustomPrivateKey in CreateServer API to configure their Chef Automate servers with a custom domain and certificate.
* Core 3.3.103.53
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.612.0 (2019-10-18 19:14 UTC)
* CloudWatch (3.3.103.0)
	* New Period parameter added to MetricDataQuery structure.
* Core 3.3.103.52
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.611.0 (2019-10-17 22:55 UTC)
* S3 (3.3.104.39)
	* Fixed headers for SelectObjectContentRequest; Enabling UploadFilesConcurrently for TransferUtilityUploadDirectoryRequest in NetStandard. Removing unnecessary fields from CopyPartRequest.


* SecurityToken (3.3.103.0)
	* Updated to use new Core, version 3.3.103.51
	* Check for STS Regional Flag within environment variable, shared credentials file, and client config for all STS customers
* Core 3.3.103.51
	* Adding me-south-1 region constant.

### 3.3.610.0 (2019-10-17 19:17 UTC)
* Batch (3.3.103.0)
	* Adding support for Compute Environment Allocation Strategies 
* RDS (3.3.112.0)
	* Amazon RDS now supports Amazon RDS on VMware with the introduction of APIs related to Custom Availability Zones and Media installation.
* Core 3.3.103.50
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.609.0 (2019-10-16 18:14 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.102.0)
	* add 2 more values for the supporting sections - age of past due funds + uncollected funds breakdown
* Kafka (3.3.104.0)
	* AWS MSK has added support for adding brokers to a cluster.
* RoboMaker (3.3.107.0)
	* This release adds support for ROS2 Dashing as a beta feature
* Core 3.3.103.49
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.608.0 (2019-10-15 19:46 UTC)
* KinesisVideoArchivedMedia (3.3.102.0)
	* Add ON_DISCONTINUITY mode to the GetHLSStreamingSessionURL API

### 3.3.607.0 (2019-10-14 18:10 UTC)
* Personalize (3.3.102.0)
	* AWS Personalize: Adds ability to create a solution version using FULL or UPDATE training mode
* WorkSpaces (3.3.105.7)
	* Documentation updates for WorkSpaces

### 3.3.606.0 (2019-10-11 19:26 UTC)
* Greengrass (3.3.104.0)
	* Greengrass OTA service supports Raspbian/Armv6l platforms.
* Core 3.3.103.48
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.605.0 (2019-10-10 19:23 UTC)
* EC2 (3.3.133.0)
	* New EC2 M5n, M5dn, R5n, R5dn instances with 100 Gbps network performance and Elastic Fabric Adapter (EFA) for ultra low latency; New A1.metal bare metal instance powered by AWS Graviton Processors
* FMS (3.3.102.0)
	* Firewall Manager now supports Amazon VPC security groups, making it easier to configure and manage security groups across multiple accounts from a single place.
* IoTAnalytics (3.3.104.0)
	* Add `completionTime` to API call ListDatasetContents.
* Lex (3.3.102.0)
	* Amazon Lex now supports Session API checkpoints
* Core 3.3.103.47
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.604.0 (2019-10-09 18:14 UTC)
* ElastiCache (3.3.105.0)
	* Amazon ElastiCache now allows you to apply available service updates on demand to your Memcached and Redis Cache Clusters. Features included: (1) Access to the list of applicable service updates and their priorities. (2) Service update monitoring and regular status updates. (3) Recommended apply-by-dates for scheduling the service updates. (4) Ability to stop and later re-apply updates. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/mem-ug/Self-Service-Updates.html and https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Self-Service-Updates.html
* Kafka (3.3.103.56)
	* Updated documentation for Amazon Managed Streaming for Kafka service.
* MediaConvert (3.3.109.0)
	* AWS Elemental MediaConvert SDK has added support for Dolby Atmos encoding, up to 36 outputs, accelerated transcoding with frame capture and preferred acceleration feature.

### 3.3.603.0 (2019-10-08 19:34 UTC)
* DataSync (3.3.106.0)
	* Add Sync options to enable/disable TaskQueueing
* EventBridge (3.3.100.36)
	* Documentation updates for Amazon EventBridge.
* KinesisFirehose (3.3.102.0)
	* With this release, you can use Amazon Kinesis Firehose delivery streams to deliver streaming data to Amazon Elasticsearch Service version 7.x clusters. For technical documentation, look for CreateDeliveryStream operation in Amazon Kinesis Firehose API reference.
* Organizations (3.3.103.40)
	* Documentation updates for organizations
* Core 3.3.103.46
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.602.0 (2019-10-07 19:39 UTC)
* DirectConnect (3.3.104.0)
	* This release adds a service provider field for physical connection creation and provides a list of available partner providers for each Direct Connect location.
* Glue (3.3.111.0)
	* AWS Glue now provides ability to use custom certificates for JDBC Connections.
* KinesisFirehose (3.3.101.0)
	* Amazon Kinesis Data Firehose now allows delivering data to Elasticsearch clusters set up in a different AWS account than the Firehose AWS account. For technical documentation, look for ElasticsearchDestinationConfiguration in the Amazon Kinesis Firehose API reference.
* Pinpoint (3.3.102.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing message templates.
* PinpointEmail (3.3.104.0)
	* This release of the Amazon Pinpoint Email API introduces support for using and managing message templates.
* Snowball (3.3.101.0)
	* AWS Snowball Edge now allows you to perform an offline update to the software of your Snowball Edge device when your device is not connected to the internet. Previously, updating your Snowball Edge's software required that the device be connected to the internet or be sent back to AWS. Now, you can keep your Snowball Edge software up to date even if your device(s) cannot connect to the internet, or are required to run in an air-gapped environment. To complete offline updates, download the software update from a client machine with connection to the internet using the AWS Command Line Interface (CLI). Then, have the Snowball Edge device download and install the software update using the Snowball Edge device API. For more information about offline updates, visit the Snowball Edge documentation page.

### 3.3.601.0 (2019-10-04 19:22 UTC)
* CognitoIdentityProvider (3.3.103.0)
	* This release adds ClientMetadata input parameter to multiple Cognito User Pools operations, making this parameter available to the customer configured lambda triggers as applicable. 
* MediaPackage (3.3.103.0)
	* New Harvest Job APIs to export segment-accurate content windows from MediaPackage Origin Endpoints to S3. See https://docs.aws.amazon.com/mediapackage/latest/ug/harvest-jobs.html for more info
* SimpleSystemsManagement (3.3.107.2)
	* Documentation updates for Systems Manager / StartSession.

### 3.3.600.0 (2019-10-03 19:11 UTC)
* ApplicationAutoScaling (3.3.101.14)
	* Documentation updates for Application Auto Scaling
* DeviceFarm (3.3.101.60)
	* Documentation updates for devicefarm
* EC2 (3.3.132.0)
	* This release allows customers to purchase regional EC2 RIs on a future date.
* Elasticsearch (3.3.102.0)
	* Amazon Elasticsearch Service now supports configuring additional options for domain endpoint, such as whether to require HTTPS for all traffic.

### 3.3.599.0 (2019-10-02 19:59 UTC)
* Lightsail (3.3.101.0)
	* This release adds support for the automatic snapshots add-on for instances and block storage disks.

### 3.3.598.0 (2019-10-01 18:09 UTC)
* DocDB (3.3.102.0)
	* This release provides support for describe and modify CA certificates.

### 3.3.597.0 (2019-09-30 19:19 UTC)
* MQ (3.3.104.0)
	* Amazon MQ now includes the ability to scale your brokers by changing the host instance type. See the hostInstanceType property of UpdateBrokerInput (https://docs.aws.amazon.com/amazon-mq/latest/api-reference/brokers-broker-id.html#brokers-broker-id-model-updatebrokerinput), and pendingHostInstanceType property of DescribeBrokerOutput (https://docs.aws.amazon.com/amazon-mq/latest/api-reference/brokers-broker-id.html#brokers-broker-id-model-describebrokeroutput).
* RDS (3.3.111.0)
	* This release adds support for creating a Read Replica with Active Directory domain information. This release updates RDS API to indicate whether an OrderableDBInstanceOption supports Kerberos Authentication.
* WAF (3.3.102.0)
	* Lowering the threshold for Rate Based rule from 2000 to 100.
* Core 3.3.103.45
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.596.0 (2019-09-27 19:11 UTC)
* Amplify (3.3.102.0)
	* This release adds access logs APIs and artifact APIs for AWS Amplify Console.
* ECS (3.3.110.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) removes FirelensConfiguration from the DescribeTask output during the FireLens public preview.

### 3.3.595.0 (2019-09-26 18:13 UTC)
* CodePipeline (3.3.103.12)
	* Documentation updates for CodePipeline
* SimpleSystemsManagement (3.3.107.0)
	* This release updates the AWS Systems Manager Parameter Store PutParameter and LabelParameterVersion APIs to return the "Tier" of parameter created/updated and the "parameter version" labeled respectively. 
* Core 3.3.103.44
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.594.0 (2019-09-25 18:23 UTC)
* DatabaseMigrationService (3.3.102.0)
	* This release adds a new DeleteConnection API to delete the connection between a replication instance and an endpoint. It also adds an optional S3 setting to specify the precision of any TIMESTAMP column values written to an S3 object file in .parquet format.
* GlobalAccelerator (3.3.102.0)
	* API Update for AWS Global Accelerator to support for DNS aliasing.
* SageMaker (3.3.105.0)
	* Enable G4D and R5 instances in SageMaker Hosting Services

### 3.3.593.0 (2019-09-24 18:14 UTC)
* ComprehendMedical (3.3.101.0)
	* Use Amazon Comprehend Medical to analyze medical text stored in the specified Amazon S3 bucket. Use the console to create and manage batch analysis jobs, or use the batch APIs to detect both medical entities and protected health information (PHI). The batch APIs start, stop, list, and retrieve information about batch analysis jobs. This release also includes DetectEntitiesV2 operation which returns the Acuity and Direction entities as attributes instead of types.
* DataSync (3.3.105.0)
	* Added S3StorageClass, OverwriteMode sync option, and ONLY_FILES_TRANSFERRED setting for the VerifyMode sync option.
* TranscribeService (3.3.108.0)
	* With this update Amazon Transcribe enables you to provide an AWS KMS key to encrypt your transcription output.

### 3.3.592.0 (2019-09-23 19:08 UTC)
* RDSDataService (3.3.102.0)
	* RDS Data API now supports Amazon Aurora Serverless PostgreSQL databases.
* Redshift (3.3.104.0)
	* Adds API operation DescribeNodeConfigurationOptions and associated data structures.
* Core 3.3.103.43
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.591.0 (2019-09-20 23:11 UTC)
* EC2 (3.3.131.0)
	* G4 instances are Amazon EC2 instances based on NVIDIA T4 GPUs and are designed to provide cost-effective machine learning inference for applications, like image classification, object detection, recommender systems, automated speech recognition, and language translation. G4 instances are also a cost-effective platform for building and running graphics-intensive applications, such as remote graphics workstations, video transcoding, photo-realistic design, and game streaming in the cloud. To get started with G4 instances visit https://aws.amazon.com/ec2/instance-types/g4.
* Greengrass (3.3.103.0)
	* Greengrass OTA service now returns the updated software version in the PlatformSoftwareVersion parameter of a CreateSoftwareUpdateJob response
* RDS (3.3.110.0)
	* Add a new LeaseID output field to DescribeReservedDBInstances, which shows the unique identifier for the lease associated with the reserved DB instance. AWS Support might request the lease ID for an issue related to a reserved DB instance.
* WorkSpaces (3.3.105.0)
	* Adds the WorkSpaces restore feature
* Core 3.3.103.42
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.590.0 (2019-09-19 21:40 UTC)
* ECS (3.3.109.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for container image manifest digests. This enables you to identify all tasks launched using a container image pulled from ECR in order to correlate what was built with where it is running.
* Glue (3.3.110.0)
	* AWS Glue DevEndpoints now supports GlueVersion, enabling you to choose Apache Spark 2.4.3 (in addition to Apache Spark 2.2.1). In addition to supporting the latest version of Spark, you will also have the ability to choose between Python 2 and Python 3.
* MediaConnect (3.3.105.0)
	* When you grant an entitlement, you can now specify the percentage of the entitlement data transfer that you want the subscriber to be responsible for.
* Core 3.3.103.41
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.589.0 (2019-09-18 20:39 UTC)
* APIGateway (3.3.103.0)
	* Amazon API Gateway simplifies accessing PRIVATE APIs by allowing you to associate one or more Amazon Virtual Private Cloud (VPC) Endpoints to a private API. API Gateway will create and manage DNS alias records necessary for easily invoking the private APIs. With this feature, you can leverage private APIs in web applications hosted within your VPCs.
* RAM (3.3.101.0)
	* AWS RAM provides a new ListPendingInvitationResources API action that lists the resources in a resource share that is shared with you but that the invitation is still pending for
* WAFRegional (3.3.102.0)
	* Lowering the threshold for Rate Based rule from 2000 to 100.
* Core 3.3.103.40
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.588.0 (2019-09-17 18:07 UTC)
* Athena (3.3.102.0)
	* This release adds DataManifestLocation field indicating the location and file name of the data manifest file. Users can get a list of files that the Athena query wrote or intended to write from the manifest file.
* IdentityManagement (3.3.103.28)
	* Documentation updates for iam
* Personalize (3.3.101.0)
	* [Personalize] Adds trainingHours to solutionVersion properties.
* Core 3.3.103.39
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.587.0 (2019-09-16 18:10 UTC)
* EKS (3.3.103.0)
	* This release lets customers add tags to an Amazon EKS cluster. These tags can be used to control access to the EKS API for managing the cluster using IAM. The Amazon EKS TagResource API allows customers to associate tags with their cluster. Customers can list tags for a cluster using the ListTagsForResource API and remove tags from a cluster with the UntagResource API. Note: tags are specific to the EKS cluster resource, they do not propagate to other AWS resources used by the cluster.
* MediaConvert (3.3.108.0)
	* AWS Elemental MediaConvert SDK has added support for multi-DRM SPEKE with CMAF outputs, MP3 ingest, and options for improved video quality.
* Core 3.3.103.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.586.0 (2019-09-12 19:16 UTC)
* EC2 (3.3.130.0)
	* Fix for FleetActivityStatus and FleetStateCode enum
* ElasticLoadBalancingV2 (3.3.102.36)
	* Documentation updates for elasticloadbalancingv2: This release adds support for TLS SNI on Network Load Balancers 
* MediaLive (3.3.105.0)
	* AWS Elemental MediaLive now supports High Efficiency Video Coding (HEVC) for standard-definition (SD), high-definition (HD), and ultra-high-definition (UHD) encoding with HDR support.Encoding with HEVC offers a number of advantages. While UHD video requires an advanced codec beyond H.264 (AVC), high frame rate (HFR) or High Dynamic Range (HDR) content in HD also benefit from HEVC's advancements. In addition, benefits can be achieved with HD and SD content even if HDR and HFR are not needed.
* WorkMailMessageFlow (3.3.100.0)
	* This release allows customers to access email messages as they flow to and from Amazon WorkMail.
* Core 3.3.103.37
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.585.0 (2019-09-11 19:29 UTC)
* ConfigService (3.3.104.0)
	* Adding input validation for the OrganizationConfigRuleName string.
* EC2 (3.3.129.0)
	* This release adds support for new data fields and log format in VPC flow logs.
* MediaConnect (3.3.104.0)
	* This release adds support for the RIST protocol on sources and outputs.
* RDS (3.3.109.0)
	* This release allows customers to specify a custom parameter group when creating a Read Replica, for DB engines which support this feature.
* SimpleEmail (3.3.101.43)
	* Updated API documentation to correct broken links, and to update content based on customer feedback.
* StepFunctions (3.3.102.0)
	* Fixing letter case in Map history event details to be small case

### 3.3.584.0 (2019-09-10 18:12 UTC)
* StorageGateway (3.3.109.0)
	* The CloudWatchLogGroupARN parameter of the UpdateGatewayInformation API allows for configuring the gateway to use a CloudWatch log-group where Storage Gateway health events will be logged. 

### 3.3.583.0 (2019-09-09 21:38 UTC)
* AppMesh (3.3.105.0)
	* This release adds support for http retry policies.
* AppStream (3.3.104.0)
	* IamRoleArn support in CreateFleet, UpdateFleet, CreateImageBuilder APIs
* AWSMarketplaceCommerceAnalytics (3.3.101.0)
	* Add FDP+FPS (monthly_revenue_field_demonstration_usage + monthly_revenue_flexible_payment_schedule)  to Marketplace Commerce Analytics Service
* EC2 (3.3.128.0)
	* This release expands Site-to-Site VPN tunnel options to allow customers to restrict security algorithms and configure timer settings for VPN connections. Customers can specify these new options while creating new VPN connections, or they can modify the tunnel options on existing connections using a new API.
* QLDB (3.3.100.0)
	* (New Service) Amazon QLDB is a fully managed ledger database that provides a transparent, immutable, and cryptographically verifiable transaction log owned by a central trusted authority. Amazon QLDB is a new class of serverless database that eliminates the need to engage in the complex development effort of building your own ledger-like applications and it automatically scales to support the demands of your application. Introduces Amazon QLDB API operations needed for managing Amazon QLDB ledgers. This includes the ability to manage Amazon QLDB ledgers, cryptographically verify documents, and export the journal in a ledger.
* QLDBSession (3.3.100.0)
	* (New Service) Amazon QLDB is a fully managed ledger database that provides a transparent, immutable, and cryptographically verifiable transaction log owned by a central trusted authority. Amazon QLDB is a new class of serverless database that eliminates the need to engage in the complex development effort of building your own ledger-like applications and it automatically scales to support the demands of your application. Introduces Amazon QLDB API operations needed for interacting with data in Amazon QLDB ledgers.
* RoboMaker (3.3.106.0)
	* Support for Connectivity to Simulation. When you need to interact with the applications in your simulation job, you can connect to your robot application or simulation application with port forwarding. When you configure port forwarding, traffic will be forwarded from the simulation job port to the application port. Port forwarding makes it easy to connect with tools such as ROS Bridge and other tools. This can be useful when you want to debug or run custom tools to interact with your applications. 
* Core 3.3.103.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.582.1 (2019-09-06 18:21 UTC)
* KinesisAnalytics (3.3.101.54)
	* Documentation updates for kinesisanalytics
* Core 3.3.103.35
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.582.0 (2019-09-05 18:11 UTC)
* ConfigService (3.3.103.0)
	* AWS Config now includes the option for marking RemediationConfigurations as automatic, removing the need to call the StartRemediationExecution API. Manual control over resource execution rate is also included, and RemediationConfigurations are now ARN addressable. Exceptions to exclude account resources from being remediated can be configured with the new PutRemediationExceptions, DescribeRemediationExceptions, and DeleteRemediationExceptions APIs.
* Core 3.3.103.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.581.0 (2019-09-04 18:17 UTC)
* EKS (3.3.102.0)
	* Amazon EKS DescribeCluster API returns a new OIDC issuer field that can be used to create OIDC identity provider for IAM for Service Accounts feature.
* StepFunctions (3.3.101.0)
	* Added support for new history events
* TranscribeService (3.3.107.0)
	* MediaFormat is now optional for StartTranscriptionJob API.
* Core 3.3.103.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.580.0 (2019-09-03 19:34 UTC)
* ECS (3.3.108.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for attaching Amazon Elastic Inference accelerators to your containers. This enables you to run deep learning inference workloads with hardware acceleration in a more efficient way.
* GameLift (3.3.103.0)
	* You can now make use of PKI resources to provide more secure connections between your game clients and servers.  To learn more, please refer to the public Amazon GameLift documentation.
* ResourceGroupsTaggingAPI (3.3.102.32)
	* Documentation updates for resourcegroupstaggingapi

### 3.3.579.0 (2019-08-30 18:08 UTC)
* ApiGatewayManagementApi (3.3.101.0)
	* You can use getConnection to return information about the connection (when it is connected, IP address, etc) and deleteConnection to disconnect the given connection
* ECS (3.3.107.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for modifying the cluster settings for existing clusters, which enables you to toggle whether Container Insights is enabled or not. Support is also introduced for custom log routing using the ECS FireLens integration.
* MQ (3.3.103.0)
	* Adds support for updating security groups selection of an Amazon MQ broker.

### 3.3.578.0 (2019-08-29 19:29 UTC)
* ApplicationAutoScaling (3.3.101.0)
	* With the current release, you can suspend and later resume any of the following scaling actions in Application Auto Scaling: scheduled scaling actions, dynamic scaling in actions, dynamic scaling out actions.
* CodePipeline (3.3.103.0)
	* Introducing pipeline execution trigger details in ListPipelineExecutions API.
* ECS (3.3.106.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for including Docker container IDs in the API response when describing and stopping tasks. This enables customers to easily map containers to the tasks they are associated with.
* ElastiCache (3.3.104.0)
	* Amazon ElastiCache for Redis now supports encryption at rest using customer managed customer master keys (CMKs) in AWS Key Management Service (KMS). Amazon ElastiCache now supports cluster names upto 40 characters for replicationGoups and upto 50 characters for cacheClusters.
* Lambda (3.3.103.0)
	* Adds a "MaximumBatchingWindowInSeconds" parameter to event source mapping api's. Usable by Dynamodb and Kinesis event sources.

### 3.3.577.0 (2019-08-28 18:33 UTC)
* GlobalAccelerator (3.3.101.0)
	* API Update for AWS Global Accelerator Client IP Preservation
* MediaConvert (3.3.107.0)
	* This release adds the ability to send a job to an on-demand queue while simulating the performance of a job sent to a reserved queue. Use this setting to estimate the number of reserved transcoding slots (RTS) you need for a reserved queue.
* SQS (3.3.102.0)
	* Added support for message system attributes, which currently lets you send AWS X-Ray trace IDs through Amazon SQS.

### 3.3.576.1 (2019-08-27 18:10 UTC)
* Organizations (3.3.103.26)
	* Documentation updates for organizations
* Core 3.3.103.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.576.0 (2019-08-26 18:09 UTC)
* SecurityHub (3.3.104.0)
	* This release resolves an issue with the DescribeHub action, changes the MasterId and InvitationId parameters for AcceptInvitation to Required, and changes the AccountIds parameter for DeleteInvitations and DeclineInvitations to Required.
* SimpleSystemsManagement (3.3.106.0)
	* This feature adds "default tier" to the AWS Systems Manager Parameter Store for parameter creation and update. AWS customers can now set the "default tier" to one of the following values: Standard (default), Advanced or Intelligent-Tiering.  This allows customers to create advanced parameters or parameters in corresponding tiers with one setting rather than code change to specify parameter tiers.

### 3.3.575.0 (2019-08-23 18:12 UTC)
* EC2 (3.3.127.0)
	* This release of EC2 VM Import Export adds support for exporting Amazon Machine Image(AMI)s to a VM file
* MediaPackageVod (3.3.101.0)
	* Adds optional Constant Initialization Vector (IV) to HLS Encryption for MediaPackage VOD.
* TranscribeService (3.3.106.0)
	* Amazon Transcribe - support transcriptions from audio sources in Russian (ru-RU) and Chinese (zh-CN).
* Core 3.3.103.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.574.0 (2019-08-22 18:31 UTC)
* DataSync (3.3.104.0)
	* This release adds support for SMB location type.
* RDS (3.3.108.0)
	* This release allows users to enable RDS Data API while creating Aurora Serverless databases. 
* Core 3.3.103.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.573.0 (2019-08-21 18:23 UTC)
* ElastiCache (3.3.103.0)
	* ElastiCache extends support for Scale down for Redis Cluster-mode enabled and disabled replication groups 
* ForecastQueryService (3.3.100.0)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* ForecastService (3.3.100.0)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* PersonalizeRuntime (3.3.101.0)
	* Increased limits on number of items recommended and reranked: The maximum number of results returned from getRecommendations API has been increased to 200. The maximum number of items which can be reranked via getPersonalizedRanking API has been increased to 200.
* Rekognition (3.3.101.5)
	* Documentation updates for Amazon Rekognition.
* SageMaker (3.3.104.0)
	* Amazon SageMaker now supports Amazon EFS and Amazon FSx for Lustre file systems as data sources for training machine learning models. Amazon SageMaker now supports running training jobs on ml.p3dn.24xlarge instance type. This instance type is offered as a limited private preview for certain SageMaker customers. If you are interested in joining the private preview, please reach out to the SageMaker Product Management team via AWS Support."
* SQS (3.3.101.0)
	* This release provides a way to add metadata tags to a queue when it is created. You can use tags to organize and identify your Amazon SQS queues for cost allocation.

### 3.3.572.0 (2019-08-20 18:42 UTC)
* AlexaForBusiness (3.3.106.0)
	* Adding support for optional locale input in CreateProfile and UpdateProfile APIs
* AppStream (3.3.103.0)
	* Includes API updates to support streaming through VPC endpoints for image builders and stacks.
* SageMaker (3.3.103.0)
	* Amazon SageMaker introduces Managed Spot Training. Increases the maximum number of metric definitions to 40 for SageMaker Training and Hyperparameter Tuning Jobs. SageMaker Neo adds support for Acer aiSage and Qualcomm QCS605 and QCS603. 
* Transfer (3.3.103.0)
	* New field in response of TestIdentityProvider

### 3.3.571.0 (2019-08-19 18:08 UTC)
* AppMesh (3.3.104.0)
	* Fix for HttpMethod enum
* CostAndUsageReport (3.3.101.0)
	* New IAM permission required for editing AWS Cost and Usage Reports - Starting today, you can allow or deny IAM users permission to edit Cost & Usage Reports through the API and the Billing and Cost Management console. To allow users to edit Cost & Usage Reports, ensure that they have 'cur: ModifyReportDefinition' permission. Refer to the technical documentation (https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_cur_ModifyReportDefinition.html) for additional details.

### 3.3.570.0 (2019-08-16 19:18 UTC)
* ECS (3.3.105.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for controlling the usage of swap space on a per-container basis for Linux containers.
* ElasticMapReduce (3.3.102.0)
	* Amazon EMR  has introduced an account level configuration called Block Public Access that allows you to block clusters with ports open to traffic from public IP sources (i.e. 0.0.0.0/0 for IPv4 and ::/0 for IPv6) from launching.  Individual ports or port ranges can be added as exceptions to allow public access.
* RoboMaker (3.3.105.0)
	* Two feature release: 1. AWS RoboMaker introduces log-based simulation. Log-based simulation allows you to play back pre-recorded log data such as sensor streams for testing robotic functions like localization, mapping, and object detection. Use the AWS RoboMaker SDK to test your robotic applications.  2.  AWS RoboMaker allow customer to setup a robot deployment timeout when CreateDeploymentJob.
* Core 3.3.103.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.569.1 (2019-08-15 21:36 UTC)
* CognitoIdentity (3.3.100.64)
	* Fix call hanging issue in CognitoAWSCredentials
* S3 (3.3.104.16)
	* PR [#1298](https://github.com/aws/aws-sdk-net/pull/1298) Add missing ContentRange property to GetObjectMetadataResponse. Thanks [eangelov](https://github.com/eangelov)
* Core 3.3.103.28
	* PR [#1276](https://github.com/aws/aws-sdk-net/pull/1276) Fixed issue in .NET Framework async calls not handling timeout correctly. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * PR [#1370](https://github.com/aws/aws-sdk-net/pull/1370) Better error handling when no EC2 instance metadata found. Thanks [Martin Costello](https://github.com/martincostello)
    * PR [#1366](https://github.com/aws/aws-sdk-net/pull/1366) Fixed issue looking for "default" profile in ~/.aws/config file. Thanks [Jesse Mandel](https://github.com/supergibbs)
    * Updated generator to not mark idempotency tokens as required. 
    * Fix call hanging issue in RefreshAWSCredentials impacting CognitoAWSCredentials
	* All services packages updated to require new Core

### 3.3.569.0 (2019-08-15 19:06 UTC)
* AppMesh (3.3.103.0)
	* This release adds support for http header based routing and route prioritization.
* Athena (3.3.101.0)
	* This release adds support for querying S3 Requester Pays buckets. Users can enable this feature through their Workgroup settings.
* CodeCommit (3.3.105.0)
	* This release adds an API, BatchGetCommits, that allows retrieval of metadata for multiple commits in an AWS CodeCommit repository.
* EC2 (3.3.126.0)
	* This release adds an option to use private certificates from AWS Certificate Manager (ACM) to authenticate a Site-to-Site VPN connection's tunnel endpoints and customer gateway device. 
* Glue (3.3.109.0)
	* GetJobBookmarks API is withdrawn.
* StorageGateway (3.3.108.0)
	* CreateSnapshotFromVolumeRecoveryPoint API supports new parameter: Tags (to be attached to the created resource)

### 3.3.568.0 (2019-08-14 18:15 UTC)
* EC2 (3.3.125.0)
	* This release adds a new API called SendDiagnosticInterrupt, which allows you to send diagnostic interrupts to your EC2 instance.
* Core 3.3.103.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.567.0 (2019-08-13 19:35 UTC)
* AppSync (3.3.102.0)
	* Adds a configuration option for AppSync GraphQL APIs
* Core 3.3.103.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.566.0 (2019-08-12 18:14 UTC)
* ApplicationAutoScaling (3.3.100.61)
	* Documentation updates for Application Auto Scaling
* AutoScaling (3.3.100.62)
	* Amazon EC2 Auto Scaling now supports a new Spot allocation strategy "capacity-optimized" that fulfills your request using Spot Instance pools that are optimally chosen based on the available Spot capacity.
* CloudWatch (3.3.102.16)
	* Documentation updates for monitoring
* Rekognition (3.3.101.0)
	* Adding new Emotion, Fear
* Core 3.3.103.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.565.0 (2019-08-09 18:16 UTC)
* GuardDuty (3.3.103.0)
	* New "evidence" field in the finding model to provide evidence information explaining why the finding has been triggered. Currently only threat-intelligence findings have this field. Some documentation updates.
* IoT (3.3.102.0)
	* This release adds Quality of Service (QoS) support for AWS IoT rules engine republish action.
* Lex (3.3.101.0)
	* Manage Amazon Lex session state using APIs on the client
* MediaConvert (3.3.106.0)
	* AWS Elemental MediaConvert has added support for multi-DRM SPEKE with CMAF outputs, MP3 ingest, and options for improved video quality. 
* Redshift (3.3.103.0)
	* Add expectedNextSnapshotScheduleTime and expectedNextSnapshotScheduleTimeStatus to redshift cluster object.
* Core 3.3.103.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.564.0 (2019-08-08 19:48 UTC)
* CodeBuild (3.3.102.0)
	* CodeBuild adds CloudFormation support for SourceCredential
* Glue (3.3.108.0)
	* You can now use AWS Glue to find matching records across dataset even without identifiers to join on by using the new FindMatches ML Transform. Find related products, places, suppliers, customers, and more by teaching a custom machine learning transformation that you can use to identify matching matching records as part of your analysis, data cleaning, or master data management project by adding the FindMatches transformation to your Glue ETL Jobs. If your problem is more along the lines of deduplication, you can use the FindMatches in much the same way to identify customers who have signed up more than ones, products that have accidentally been added to your product catalog more than once, and so forth. Using the FindMatches MLTransform, you can teach a Transform your definition of a duplicate through examples, and it will use machine learning to identify other potential duplicates in your dataset. As with data integration, you can then use your new Transform in your deduplication projects by adding the FindMatches transformation to your Glue ETL Jobs. This release also contains additional APIs that support AWS Lake Formation.
* LakeFormation (3.3.100.0)
	* Lake Formation: (New Service) AWS Lake Formation is a fully managed service that makes it easier for customers to build, secure and manage data lakes.  AWS Lake Formation simplifies and automates many of the complex manual steps usually required to create data lakes including collecting, cleaning and cataloging data and securely making that data available for analytics and machine learning.
* OpsWorksCM (3.3.101.0)
	* This release adds support for Chef Automate 2 specific engine attributes.
* Core 3.3.103.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.563.1 (2019-08-07 21:49 UTC)
* S3 (3.3.104.10)
	* Updated to use new Core, version 3.3.103.22
	* Fixes issues with encoding of slashes and %2F within resource paths.
* Core 3.3.103.22
	* Fixes issues with encoding of slashes and %2F within resource paths.
	* All services packages updated to require new Core

### 3.3.563.0 (2019-08-07 19:29 UTC)
* ApplicationInsights (3.3.101.0)
	* CloudWatch Application Insights for .NET and SQL Server now provides integration with AWS Systems Manager OpsCenter. This integration allows you to view and resolve problems and operational issues detected for selected applications.
* Core 3.3.103.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.562.1 (2019-08-06 18:08 UTC)
* Batch (3.3.102.5)
	* Documentation updates for AWS Batch

### 3.3.562.0 (2019-08-05 18:08 UTC)
* DataSync (3.3.103.0)
	* Support VPC endpoints.
* EC2 (3.3.124.0)
	* Amazon EC2 now supports a new Spot allocation strategy "Capacity-optimized" that fulfills your request using Spot Instance pools that are optimally chosen based on the available Spot capacity.
* IoT (3.3.101.0)
	* In this release, AWS IoT Device Defender introduces audit mitigation actions that can be applied to audit findings to help mitigate security issues.

### 3.3.561.2 (2019-08-02 18:51 UTC)
* SecurityToken (3.3.102.5)
	* Documentation updates for sts
* Core 3.3.103.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.561.1 (2019-08-01 21:25 UTC)
* Core 3.3.103.19
	* Allow "Assume Role" profiles to reference other "Assume Role" profiles as their source
	* All services packages updated to require new Core

### 3.3.561.0 (2019-07-30 18:10 UTC)
* MediaConvert (3.3.105.0)
	* MediaConvert adds support for specifying priority (-50 to 50) on jobs submitted to on demand or reserved queues
* Polly (3.3.102.0)
	* Amazon Polly adds support for Neural text-to-speech engine.
* Route53 (3.3.102.0)
	* Amazon Route 53 now supports the Middle East (Bahrain) Region (me-south-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Core 3.3.103.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.560.0 (2019-07-29 18:12 UTC)
* CodeCommit (3.3.104.0)
	* This release supports better exception handling for merges.
* Core 3.3.103.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.559.0 (2019-07-26 18:23 UTC)
* Batch (3.3.102.0)
	* AWS Batch now supports SDK auto-pagination and Job-level docker devices.
* CloudWatchLogs (3.3.101.0)
	* Allow for specifying multiple log groups in an Insights query, and deprecate storedByte field for LogStreams and interleaved field for FilterLogEventsRequest.
* CostExplorer (3.3.102.0)
	* Adds support for resource optimization recommendations.
* EC2 (3.3.123.0)
	* You can now create EC2 Capacity Reservations using Availability Zone ID or Availability Zone name. You can view usage of Amazon EC2 Capacity Reservations per AWS account.
* Glue (3.3.107.0)
	* This release provides GetJobBookmark and GetJobBookmarks APIs. These APIs enable users to look at specific versions or all versions of the JobBookmark for a specific job. This release also enables resetting the job bookmark to a specific run via an enhancement of the ResetJobBookmark API.
* Greengrass (3.3.102.0)
	* Greengrass OTA service supports openwrt/aarch64 and openwrt/armv7l platforms.
* MediaConnect (3.3.103.0)
	* This release adds support for the Zixi pull protocol on outputs.

### 3.3.558.0 (2019-07-25 18:10 UTC)
* ECR (3.3.101.0)
	* This release adds support for immutable image tags.
* MediaConvert (3.3.104.0)
	* AWS Elemental MediaConvert has added several features including support for: audio normalization using ITU BS.1770-3, 1770-4 algorithms, extension of job progress indicators, input cropping rectangle & output position rectangle filters per input, and dual SCC caption mapping to additional codecs and containers. 
* MediaLive (3.3.104.0)
	* AWS Elemental MediaLive is adding Input Clipping, Immediate Mode Input Switching, and Dynamic Inputs.
* Core 3.3.103.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.557.0 (2019-07-24 18:19 UTC)
* EC2 (3.3.122.0)
	* This release introduces support for split tunnel with AWS Client VPN, and also adds support for opt-in Regions in DescribeRegions API. In addition, customers can now also tag Launch Templates on creation.
* Glue (3.3.106.0)
	* This release provides GlueVersion option for Job APIs and WorkerType option for DevEndpoint APIs. Job APIs enable users to pick specific GlueVersion for a specific job and pin the job to a specific runtime environment. DevEndpoint APIs enable users to pick different WorkerType for memory intensive workload.
* Pinpoint (3.3.101.0)
	* This release adds support for programmatic access to many of the same campaign metrics that are displayed on the Amazon Pinpoint console. You can now use the Amazon Pinpoint API to monitor and assess performance data for campaigns, and integrate metrics data with other reporting tools. We update the metrics data continuously, resulting in a data latency timeframe that is limited to approximately two hours.
* SecurityToken (3.3.102.0)
	* New STS GetAccessKeyInfo API operation that returns the account identifier for the specified access key ID.
* Core 3.3.103.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.556.0 (2019-07-23 19:44 UTC)
* SecretsManager (3.3.101.0)
	* This release increases the maximum allowed size of SecretString or SecretBinary from 7KB to 10KB in the CreateSecret, UpdateSecret, PutSecretValue and GetSecretValue APIs. This release also increases the maximum allowed size of ResourcePolicy from 4KB to 20KB in the GetResourcePolicy and PutResourcePolicy APIs.
* SimpleSystemsManagement (3.3.105.0)
	* You can now use Maintenance Windows to select a resource group as the target. By selecting a resource group as the target of a Maintenance Window, customers can perform routine tasks across different resources such as Amazon Elastic Compute Cloud (AmazonEC2) instances, Amazon Elastic Block Store (Amazon EBS) volumes, and Amazon Simple Storage Service(Amazon S3) buckets within the same recurring time window.

### 3.3.555.0 (2019-07-22 19:41 UTC)
* MQ (3.3.102.0)
	* Adds support for AWS Key Management Service (KMS) to offer server-side encryption. You can now select your own customer managed CMK, or use an AWS managed CMK in your KMS  account.
* Shield (3.3.101.0)
	* Adding new VectorType (HTTP_Reflection) and related top contributor types to describe WordPress Pingback DDoS attacks.
* Core 3.3.103.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.554.0 (2019-07-19 19:12 UTC)
* IoTEvents (3.3.101.0)
	* Adds support for IoT Events, Lambda, SQS and Kinesis Firehose actions.
* SQS (3.3.100.49)
	* This release updates the information about the availability of FIFO queues and includes miscellaneous fixes.
* Core 3.3.103.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.553.0 (2019-07-19 01:05 UTC)
* EC2 (3.3.121.5)
	* Fixing serialization of the Ipv6Addresses and PrivateIpAddresses fields in RequestSpotFleetRequest, RequestSpotInstancesRequest and RunInstancesRequestMarshaller
* S3 (3.3.104.0)
	* Updated to use new Core, version 3.3.103.12
	* Adding an HTTPS-capable variant of DoesS3BucketExist; Preventing overflow exception when using S3 SelectObjectContent on PCL platforms
* Core 3.3.103.12
	* Fix for concurrency errors in region endpoints indicating that a duplicate key has been added; Adding a utility method allowing to check if value-type properties are set; Added region ap-east-1 Asia Pacific (Hong Kong)
	* All services packages updated to require new Core

### 3.3.552.0 (2019-07-18 20:29 UTC)
* CodeDeploy (3.3.101.24)
	* Documentation updates for codedeploy
* Comprehend (3.3.105.0)
	* Amazon Comprehend now supports multiple entities for custom entity recognition
* ECS (3.3.104.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for cluster settings. Cluster settings specify whether CloudWatch Container Insights is enabled or disabled for the cluster.
* ElastiCache (3.3.102.16)
	* Updates for Elasticache

### 3.3.551.0 (2019-07-17 19:17 UTC)
* AutoScaling (3.3.100.48)
	* Documentation updates for autoscaling
* ConfigService (3.3.102.0)
	* This release adds more granularity to the status of an OrganizationConfigRule by adding a new status. It also adds an exception when organization access is denied.
* DatabaseMigrationService (3.3.101.0)
	* S3 endpoint settings update: 1) Option to append operation column to full-load files. 2) Option to add a commit timestamp column to full-load and cdc files. Updated DescribeAccountAttributes to include UniqueAccountIdentifier.

### 3.3.550.0 (2019-07-12 18:07 UTC)
* ApiGatewayV2 (3.3.103.0)
	* Bug fix (Add tags field to Update Stage , Api and DomainName Responses )
* Elasticsearch (3.3.101.0)
	* Amazon Elasticsearch Service now supports M5, C5, and R5 instance types.
* IdentityManagement (3.3.103.0)
	* Removed exception that was indicated but never thrown for IAM GetAccessKeyLastUsed API
* RoboMaker (3.3.104.0)
	* Added Melodic as a supported Robot Software Suite Version
* Core 3.3.103.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.549.0 (2019-07-11 15:06 UTC)
* CloudWatchEvents (3.3.101.0)
	* Adds APIs for partner event sources, partner event buses, and custom event buses. These new features are managed in the EventBridge service.
* EventBridge (3.3.100.0)
	* Amazon EventBridge is a serverless event bus service that makes it easy to connect your applications with data from a variety of sources, including AWS services, partner applications, and your own applications.

### 3.3.548.0 (2019-07-10 18:29 UTC)
* Glacier (3.3.100.46)
	* Documentation updates for glacier
* QuickSight (3.3.101.0)
	* Amazon QuickSight now supports embedding dashboards for all non-federated QuickSight users. This includes IAM users, AD users and users from the QuickSight user pool. The get-dashboard-embed-url API accepts QUICKSIGHT as identity type with a user ARN to authenticate the embeddable dashboard viewer as a non-federated user.
* ServiceCatalog (3.3.108.0)
	* This release adds support for Parameters in ExecuteProvisionedProductServiceAction and adds functionality to get the default parameter values for a Self-Service Action execution against a Provisioned Product via DescribeServiceActionExecutionParameters
* Core 3.3.103.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.547.0 (2019-07-09 18:24 UTC)
* Amplify (3.3.101.0)
	* This release adds webhook APIs and manual deployment APIs for AWS Amplify Console.
* CloudWatch (3.3.102.0)
	* This release adds three new APIs (PutAnomalyDetector, DeleteAnomalyDetector, and DescribeAnomalyDetectors) to support the new feature, CloudWatch Anomaly Detection. In addition, PutMetricAlarm and DescribeAlarms APIs are updated to support management of Anomaly Detection based alarms.
* ConfigService (3.3.101.0)
	* AWS Config now supports a new set of APIs to manage AWS Config rules across your organization in AWS Organizations. Using this capability, you can centrally create, update, and delete AWS Config rules across all accounts in your organization. This capability is particularly useful if you have a need to deploy a common set of AWS Config rules across all accounts. You can also specify accounts where AWS Config rules should not be created. In addition, you can use these APIs from the master account in AWS Organizations to enforce governance by ensuring that the underlying AWS Config rules are not modifiable by your organization member accounts.These APIs work for both managed and custom AWS Config rules. For more information, see Enabling AWS Config Rules Across all Accounts in Your Organization in the AWS Config Developer Guide.The new APIs are available in all commercial AWS Regions where AWS Config and AWS Organizations are supported. For the full list of supported Regions, see AWS Regions and Endpoints in the AWS General Reference. To learn more about AWS Config, visit the AWS Config webpage. To learn more about AWS Organizations, visit the AWS Organizations webpage.
* ElasticFileSystem (3.3.102.0)
	* EFS customers can now enable Lifecycle Management for all file systems. You can also now select from one of four Lifecycle Management policies (14, 30, 60 and 90 days), to automatically move files that have not been accessed for the period of time defined by the policy, from the EFS Standard storage class to the EFS Infrequent Access (IA) storage class. EFS IA provides price/performance that is cost-optimized for files that are not accessed every day.
* GameLift (3.3.102.0)
	* GameLift FlexMatch now supports matchmaking of up to 200 players per game session, and FlexMatch can now automatically backfill your game sessions whenever there is an open slot.
* KinesisVideo (3.3.101.0)
	* Add "GET_DASH_STREAMING_SESSION_URL" as an API name to the GetDataEndpoint API.
* KinesisVideoArchivedMedia (3.3.101.0)
	* Adds support for the GetDASHStreamingSessionURL API. Also adds support for the Live Replay playback mode of the GetHLSStreamingSessionURL API.
* WAF (3.3.101.0)
	* Updated SDK APIs to add tags to WAF Resources: WebACL, Rule, Rulegroup and RateBasedRule. Tags can also be added during creation of these resources.
* WAFRegional (3.3.101.0)
	* Updated SDK APIs to add tags to WAF Resources: WebACL, Rule, Rulegroup and RateBasedRule. Tags can also be added during creation of these resources.
* Core 3.3.103.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.546.0 (2019-07-08 19:22 UTC)
* CostExplorer (3.3.101.0)
	* This release introduces a new operation called GetUsageForecast, which allows you to programmatically access AWS Cost Explorer's forecasting engine on usage data (running hours, data transfer, etc).
* Core 3.3.103.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.545.0 (2019-07-03 19:47 UTC)
* EC2 (3.3.121.0)
	* AssignPrivateIpAddresses response includes two new fields: AssignedPrivateIpAddresses, NetworkInterfaceId
* RDS (3.3.107.0)
	* This release supports Cross-Account Cloning for Amazon Aurora clusters.
* S3 (3.3.103.0)
	* Add S3 x-amz-server-side-encryption-context support.
* SimpleWorkflow (3.3.101.0)
	* This release adds APIs that allow adding and removing tags to a SWF domain, and viewing tags for a domain. It also enables adding tags when creating a domain.

### 3.3.544.0 (2019-07-02 19:33 UTC)
* AppStream (3.3.102.10)
	* Adding ImageBuilderName in Fleet API and Documentation updates for AppStream. 
* MediaStore (3.3.101.0)
	* This release adds support for tagging, untagging, and listing tags for AWS Elemental MediaStore containers.
* Core 3.3.103.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.543.0 (2019-07-01 18:27 UTC)
* DocDB (3.3.101.0)
	* This release provides support for cluster delete protection and the ability to stop and start clusters.
* EC2 (3.3.120.0)
	* This release adds support for specifying a maximum hourly price for all On-Demand and Spot instances in both Spot Fleet and EC2 Fleet.
* Organizations (3.3.103.0)
	* Specifying the tag key and tag value is required for tagging requests.
* RDS (3.3.106.0)
	* This release adds support for RDS DB Cluster major version upgrade 
* Core 3.3.103.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.542.0 (2019-06-28 18:43 UTC)
* AlexaForBusiness (3.3.105.0)
	* This release allows developers and customers to add SIP addresses and international phone numbers to contacts.
* EC2 (3.3.119.0)
	* You can now launch 8xlarge and 16xlarge instance sizes on the general purpose M5 and memory optimized R5 instance types.
* Redshift (3.3.102.0)
	* ClusterAvailabilityStatus: The availability status of the cluster for queries. Possible values are the following: Available, Unavailable, Maintenance, Modifying, Failed.
* WorkSpaces (3.3.104.0)
	* Minor API fixes for WorkSpaces.
* Core 3.3.103.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.541.0 (2019-06-27 18:14 UTC)
* DirectConnect (3.3.103.0)
	* Tags will now be included in the API responses of all supported resources (Virtual interfaces, Connections, Interconnects and LAGs). You can also add tags while creating these resources.
* EC2InstanceConnect (3.3.100.0)
	* Amazon EC2 Instance Connect is a simple and secure way to connect to your instances using Secure Shell (SSH). With EC2 Instance Connect, you can control SSH access to your instances using AWS Identity and Access Management (IAM) policies as well as audit connection requests with AWS CloudTrail events. In addition, you can leverage your existing SSH keys or further enhance your security posture by generating one-time use SSH keys each time an authorized user connects.
* Pinpoint (3.3.100.40)
	* This release includes editorial updates for the Amazon Pinpoint API documentation.
* WorkSpaces (3.3.103.0)
	* Added support for the WorkSpaces restore feature and copying WorkSpaces Images across AWS Regions.
* Core 3.3.103.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.540.1 (2019-06-27 00:22 UTC)
* DynamoDBv2 (3.3.101.30)
	* Documentation updates for dynamodb
* Core 3.3.103.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.540.0 (2019-06-26 19:13 UTC)
* ApiGatewayV2 (3.3.102.0)
	* You can now perform tag operations on ApiGatewayV2 Resources (typically associated with WebSocket APIs)
* CodeCommit (3.3.103.0)
	* This release supports better exception handling for merges.
* Core 3.3.103.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.539.0 (2019-06-25 18:51 UTC)
* EC2 (3.3.118.0)
	* Starting today, you can use Traffic Mirroring  to copy network traffic from an elastic network interface of Amazon EC2 instances and then send it to out-of-band security and monitoring appliances for content inspection, threat monitoring, and troubleshooting. These appliances can be deployed as individual instances, or as a fleet of instances behind a Network Load Balancer with a User Datagram Protocol (UDP) listener. Traffic Mirroring supports filters and packet truncation, so that you only extract the traffic of interest to monitor by using monitoring tools of your choice.
* EKS (3.3.101.35)
	* Changing Amazon EKS full service name to Amazon Elastic Kubernetes Service.

### 3.3.538.0 (2019-06-24 18:18 UTC)
* APIGateway (3.3.102.0)
	* Customers can pick different security policies (TLS version + cipher suite) for custom domains in API Gateway
* ApiGatewayV2 (3.3.101.0)
	* Customers can get information about security policies set on custom domain resources in API Gateway
* ApplicationInsights (3.3.100.0)
	* CloudWatch Application Insights detects errors and exceptions from logs, including .NET custom application logs, SQL Server logs, IIS logs, and more, and uses a combination of built-in rules and machine learning, such as dynamic baselining, to identify common problems. You can then easily drill into specific issues with CloudWatch Automatic Dashboards that are dynamically generated. These dashboards contain the most recent alarms, a summary of relevant metrics, and log snippets to help you identify root cause.
* ElasticLoadBalancingV2 (3.3.102.0)
	* This release adds support for UDP on Network Load Balancers
* FSx (3.3.101.0)
	* Starting today, you can join your Amazon FSx for Windows File Server file systems to your organization's self-managed Microsoft Active Directory while creating the file system. You can also perform in-place updates of file systems to keep your Active Directory configuration up to date.
* ResourceGroupsTaggingAPI (3.3.102.0)
	* Updated service APIs and documentation.
* SecurityHub (3.3.103.0)
	* This release includes a new Tags parameter for the EnableSecurityHub operation, and the following new operations: DescribeHub, CreateActionTarget, DeleteActionTarget, DescribeActionTargets, UpdateActionTarget, TagResource, UntagResource, and ListTagsforResource. It removes the operation ListProductSubscribers, and makes Title and Description required attributes of AwsSecurityFinding.
* ServiceQuotas (3.3.100.0)
	* Service Quotas enables you to view and manage your quotas for AWS services from a central location.
* SimpleSystemsManagement (3.3.104.0)
	* AWS Systems Manager now supports deleting a specific version of a SSM Document.
* Core 3.3.103.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.537.0 (2019-06-21 19:40 UTC)
* DeviceFarm (3.3.101.14)
	* This release includes updated documentation about the default timeout value for test runs and remote access sessions. This release also includes miscellaneous bug fixes for the documentation.
* IdentityManagement (3.3.102.0)
	* We are making it easier for you to manage your permission guardrails i.e. service control policies by enabling you to retrieve the last timestamp when an AWS service was accessed within an account or AWS Organizations entity.
* KinesisVideoMedia (3.3.100.37)
	* Documentation updates for Amazon Kinesis Video Streams.
* MediaPackage (3.3.102.0)
	* Added two new origin endpoint fields for configuring which SCTE-35 messages are treated as advertisements.

### 3.3.536.0 (2019-06-20 22:29 UTC)
* Core 3.3.103.0
	* Added support for the credential_process credential provider; Added host name support for Client Side Metrics.
	* All services packages updated to require new Core

### 3.3.535.0 (2019-06-20 18:11 UTC)
* ACMPCA (3.3.101.0)
	* ACM Private CA is launching Root CAs and hierarchy management, a new feature that expands the scope of ACM Private CA from supporting only subordinate issuing CAs, to now include a full CA hierarchy that includes root CAs - the cryptographic root of trust for an organization.
* AWSHealth (3.3.101.0)
	* API improvements for the AWS Health service.
* Glue (3.3.105.0)
	* Starting today, you can now use workflows in AWS Glue to author directed acyclic graphs (DAGs) of Glue triggers, crawlers and jobs. Workflows enable orchestration of your ETL workloads by building dependencies between Glue entities (triggers, crawlers and jobs).  You can visually track status of the different nodes in the workflows on the console making it easier to monitor progress and troubleshoot issues. Also, you can share parameters across entities in the workflow.
* IoTEventsData (3.3.101.0)
	* "The colon character ':' is now permitted in Detector Model 'key' parameter values.
* OpsWorks (3.3.100.35)
	* Documentation updates for OpsWorks Stacks.
* RDS (3.3.105.0)
	* This release adds support for RDS storage autoscaling
* Core 3.3.102.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.534.1 (2019-06-19 20:40 UTC)
* EKS (3.3.101.31)
	* Changing Amazon EKS full service name to Amazon Elastic Kubernetes Service.

### 3.3.534.0 (2019-06-18 18:12 UTC)
* EC2 (3.3.117.0)
	* You can now launch new 12xlarge, 24xlarge, and metal instance sizes on the Amazon EC2 compute optimized C5 instance types featuring 2nd Gen Intel Xeon Scalable Processors.
* ResourceGroupsTaggingAPI (3.3.101.0)
	* You can use tag policies to help standardize on tags across your organization's resources.

### 3.3.533.0 (2019-06-17 19:09 UTC)
* Neptune (3.3.101.0)
	* This release adds a feature to configure Amazon Neptune to publish audit logs to Amazon CloudWatch Logs.
* RoboMaker (3.3.103.0)
	* Add the ServiceUnavailableException (503) into CreateSimulationJob API.
* ServiceCatalog (3.3.107.0)
	* Restrict concurrent calls by a single customer account for CreatePortfolioShare and DeletePortfolioShare when sharing/unsharing to an Organization.
* Core 3.3.102.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.532.0 (2019-06-14 18:12 UTC)
* AppStream (3.3.102.0)
	* Added 2 new values(WINDOWS_SERVER_2016, WINDOWS_SERVER_2019) for PlatformType enum.
* CloudFront (3.3.101.0)
	* A new datatype in the CloudFront API, AliasICPRecordal, provides the ICP recordal status for CNAMEs associated with distributions. AWS services in China customers must file for an Internet Content Provider (ICP) recordal if they want to serve content publicly on an alternate domain name, also known as a CNAME, that they have added to CloudFront. The status value is returned in the CloudFront response; you cannot configure it yourself. The status is set to APPROVED for all CNAMEs (aliases) in regions outside of China.
* EC2 (3.3.116.0)
	* Correction to enumerations in EC2 client.
* Personalize (3.3.100.2)
	* Documentation updates for Amazon Personalize.
* Core 3.3.102.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.531.0 (2019-06-13 19:22 UTC)
* AppMesh (3.3.102.0)
	* This release adds support for AWS Cloud Map as a service discovery method for virtual nodes.
* EC2 (3.3.115.0)
	* G4 instances are Amazon EC2 instances based on NVIDIA T4 GPUs and are designed to provide cost-effective machine learning inference for applications, like image classification, object detection, recommender systems, automated speech recognition, and language translation. G4 instances are also a cost-effective platform for building and running graphics-intensive applications, such as remote graphics workstations, video transcoding, photo-realistic design, and game streaming in the cloud. To get started with G4 instances visit https://aws.amazon.com/ec2/instance-types/g4.
* ElastiCache (3.3.102.0)
	* This release is to add support for reader endpoint for cluster-mode disabled Amazon ElastiCache for Redis clusters.
* GuardDuty (3.3.102.0)
	* Support for tagging functionality in Create and Get operations for Detector, IP Set, Threat Intel Set, and Finding Filter resources and 3 new tagging APIs: ListTagsForResource, TagResource, and UntagResource.

### 3.3.530.1 (2019-06-12 23:23 UTC)
* Core 3.3.102.4
	* Fixed issue with AssumeRoleAWSCredentials not refreshing credentials before they expire.
	* All services packages updated to require new Core

### 3.3.530.0 (2019-06-12 18:09 UTC)
* ServiceCatalog (3.3.106.0)
	* This release adds a new field named Guidance to update provisioning artifact, this field can be set by the administrator to provide guidance to end users about which provisioning artifacts to use.

### 3.3.529.0 (2019-06-11 18:32 UTC)
* SageMaker (3.3.102.0)
	* The default TaskTimeLimitInSeconds of labeling job is increased to 8 hours. Batch Transform introduces a new DataProcessing field which supports input and output filtering and data joining. Training job increases the max allowed input channels from 8 to 20.

### 3.3.528.0 (2019-06-10 18:10 UTC)
* CodeBuild (3.3.101.0)
	* AWS CodeBuild adds support for source version on project level.
* CodeCommit (3.3.102.0)
	* This release adds two merge strategies for merging pull requests: squash and three-way. It also adds functionality for resolving merge conflicts, testing merge outcomes, and for merging branches using one of the three supported merge strategies.
* Personalize (3.3.100.0)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* PersonalizeEvents (3.3.100.0)
	* Introducing Amazon Personalize  - a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* PersonalizeRuntime (3.3.100.0)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.

### 3.3.527.0 (2019-06-07 18:09 UTC)
* EC2 (3.3.114.0)
	* Adds DNS entries and NLB ARNs to describe-vpc-endpoint-connections API response. Adds owner ID to describe-vpc-endpoints and create-vpc-endpoint API responses.
* Core 3.3.102.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.526.0 (2019-06-06 18:47 UTC)
* CloudWatchLogs (3.3.100.31)
	* Documentation updates for logs
* DynamoDBv2 (3.3.101.21)
	* Documentation updates for dynamodb
* ECS (3.3.103.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for launching container instances using supported Amazon EC2 instance types that have increased elastic network interface density. Using these instance types and opting in to the awsvpcTrunking account setting provides increased elastic network interface (ENI) density on newly launched container instances which allows you to place more tasks on each container instance.
* GuardDuty (3.3.101.0)
	* Improve FindingCriteria Condition field names, support long-typed conditions and deprecate old Condition field names.
* MediaConnect (3.3.102.0)
	* This release adds support for encrypting entitlements using Secure Packager and Encoder Key Exchange (SPEKE).
* Organizations (3.3.102.0)
	* You can tag and untag accounts in your organization and view tags on an account in your organization.
* SimpleEmail (3.3.101.0)
	* You can now specify whether the Amazon Simple Email Service must deliver email over a connection that is encrypted using Transport Layer Security (TLS).
* SimpleSystemsManagement (3.3.103.0)
	* OpsCenter is a new Systems Manager capability that allows you to view, diagnose, and remediate, operational issues, aka OpsItems, related to various AWS resources by bringing together contextually relevant investigation information. New APIs to create, update, describe, and get OpsItems as well as OpsItems summary API. 

### 3.3.525.0 (2019-06-05 19:17 UTC)
* Glue (3.3.104.0)
	* Support specifying python version for Python shell jobs. A new parameter PythonVersion is added to the JobCommand data type.

### 3.3.524.0 (2019-06-04 18:09 UTC)
* EC2 (3.3.113.0)
	* This release adds support for Host Recovery feature which automatically restarts instances on to a new replacement host if failures are detected on Dedicated Host.
* ElastiCache (3.3.101.0)
	* Amazon ElastiCache now allows you to apply available service updates on demand. Features included: (1) Access to the list of applicable service updates and their priorities. (2) Service update monitoring and regular status updates. (3) Recommended apply-by-dates for scheduling the service updates, which is critical if your cluster is in ElastiCache-supported compliance programs. (4) Ability to stop and later re-apply updates. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Self-Service-Updates.html
* IdentityManagement (3.3.101.20)
	* This release adds validation for policy path field. This field is now restricted to be max 512 characters.
* S3 (3.3.102.11)
	* Documentation updates for s3
* StorageGateway (3.3.107.0)
	* AWS Storage Gateway now supports AWS PrivateLink, enabling you to administer and use gateways without needing to use public IP addresses or a NAT/Internet Gateway, while avoiding traffic from going over the internet.
* Core 3.3.102.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.523.0 (2019-06-03 18:17 UTC)
* EC2 (3.3.112.0)
	* Amazon EC2 I3en instances are the new storage-optimized instances offering up to 60 TB NVMe SSD instance storage and up to 100 Gbps of network bandwidth.
* RDS (3.3.104.2)
	* Amazon RDS Data API is generally available. Removing beta notes in the documentation.
* Core 3.3.102.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.522.0 (2019-05-30 23:05 UTC)
* Core 3.3.102.0
	* Closing response object during SAML authentication in .NET Framework 3.5.
Updating the documentation for the async operations.
Handling anonymous credentials in endpoint discovery handler.
Added support for unbounded streams when using services that support chunked transfer encoding.
	* All services packages updated to require new Core

### 3.3.521.0 (2019-05-30 20:01 UTC)
* CodeCommit (3.3.101.0)
	* This release adds APIs that allow adding and removing tags to a repository, and viewing tags for a repository. It also enables adding tags when creating a repository.
* IoTAnalytics (3.3.103.0)
	* IoT Analytics adds the option to use your own S3 bucket to store channel and data store resources. Previously, only service-managed storage was used.
* IoTEvents (3.3.100.0)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* IoTEventsData (3.3.100.0)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* Kafka (3.3.103.0)
	* Updated APIs for Amazon MSK to enable new features such as encryption in transit, client authentication, and scaling storage.
* PinpointEmail (3.3.103.0)
	* You can now specify whether the Amazon Pinpoint Email service must deliver email over a connection that is encrypted using Transport Layer Security (TLS).
* RDS (3.3.104.0)
	* This release adds support for Activity Streams for database clusters.
* RDSDataService (3.3.101.0)
	* The RDS Data API is generally available for the MySQL-compatible edition of Amazon Aurora Serverless in the US East (N. Virginia and Ohio), US West (Oregon), EU (Ireland), and Asia Pacific (Tokyo) regions. This service enables you to easily access Aurora Serverless clusters with web services-based applications including AWS Lambda and AWS AppSync. The new APIs included in this SDK release are ExecuteStatement, BatchExecuteStatement, BeginTransaction, CommitTransaction, and RollbackTransaction. The ExecuteSql API is deprecated; instead use ExecuteStatement which provides additional functionality including transaction support.
* ServiceCatalog (3.3.105.0)
	* Service Catalog ListStackInstancesForProvisionedProduct API enables customers to get details of a provisioned product with type "CFN_STACKSET". By passing the provisioned product id, the API will list account, region and status of each stack instances that are associated with this provisioned product.
* Core 3.3.101.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.520.0 (2019-05-29 18:16 UTC)
* DLM (3.3.101.0)
	* Customers can now simultaneously take snapshots of multiple EBS volumes attached to an EC2 instance. With this new capability, snapshots guarantee crash-consistency across multiple volumes by preserving the order of IO operations. This new feature is fully integrated with Amazon Data Lifecycle Manager (DLM) allowing customers to automatically manage snapshots by creating lifecycle policies. 
* EC2 (3.3.111.0)
	* Customers can now simultaneously take snapshots of multiple EBS volumes attached to an EC2 instance. With this new capability, snapshots guarantee crash-consistency across multiple volumes by preserving the order of IO operations. This new feature is fully integrated with Amazon Data Lifecycle Manager (DLM) allowing customers to automatically manage snapshots by creating lifecycle policies. 
* IoTThingsGraph (3.3.100.0)
	* Initial release.
* RDS (3.3.103.1)
	* Documentation updates for rds
* SecurityHub (3.3.102.0)
	* This update adds the ListProductSubscribers API, DescribeProducts API, removes CONTAINS as a comparison value for the StringFilter, and only allows use of EQUALS instead of CONTAINS in MapFilter.  
* SimpleSystemsManagement (3.3.102.10)
	* Systems Manager - Documentation updates
* Core 3.3.101.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.519.0 (2019-05-28 20:04 UTC)
* Chime (3.3.102.0)
	* This release adds the ability to search and order toll free phone numbers for Voice Connectors.
* GroundStation (3.3.100.0)
	* AWS Ground Station is a fully managed service that enables you to control satellite communications, downlink and process satellite data, and scale your satellite operations efficiently and cost-effectively without having to build or manage your own ground station infrastructure.
* PinpointEmail (3.3.102.0)
	* This release adds support for programmatic access to Deliverability dashboard subscriptions and the deliverability data provided by the Deliverability dashboard for domains and IP addresses. The data includes placement metrics for campaigns that use subscribed domains to send email.
* RDS (3.3.103.0)
	* Add a new output field Status to DBEngineVersion which shows the status of the engine version (either available or deprecated). Add a new parameter IncludeAll to DescribeDBEngineVersions to make it possible to return both available and deprecated engine versions. These changes enable a user to create a Read Replica of an DB instance on a deprecated engine version.
* RoboMaker (3.3.102.0)
	* Added support for an additional robot software suite (Gazebo 9) and for cancelling deployment jobs.
* SecurityToken (3.3.101.7)
	* Documentation updates for iam
* StorageGateway (3.3.106.0)
	* Introduce AssignTapePool operation to allow customers to migrate tapes between pools.
* TranscribeService (3.3.105.0)
	* Amazon Transcribe - support transcriptions from audio sources in Modern Standard Arabic (ar-SA).
* WAF (3.3.100.25)
	* Documentation updates for waf
* Core 3.3.101.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.518.0 (2019-05-24 19:13 UTC)
* CodeDeploy (3.3.101.0)
	* AWS CodeDeploy now supports tagging for the application and deployment group resources.
* MediaStoreData (3.3.101.0)
	* MediaStore - This release adds support for chunked transfer of objects, which reduces latency by making an object available for downloading while it is still being uploaded.
* OpsWorksCM (3.3.100.25)
	* Documentation updates for OpsWorks for Chef Automate; attribute values updated for Chef Automate 2.0 release.

### 3.3.517.0 (2019-05-23 18:07 UTC)
* EC2 (3.3.110.0)
	* New APIs to enable EBS encryption by default feature. Once EBS encryption by default is enabled in a region within the account, all new EBS volumes and snapshot copies are always encrypted
* WAFRegional (3.3.100.24)
	* Documentation updates for waf-regional
* Core 3.3.101.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.516.0 (2019-05-22 19:20 UTC)
* APIGateway (3.3.101.0)
	* This release adds support for tagging of Amazon API Gateway resources.
* Budgets (3.3.101.0)
	* Added new datatype PlannedBudgetLimits to Budget model, and updated examples for AWS Budgets API for UpdateBudget, CreateBudget, DescribeBudget, and DescribeBudgets
* DeviceFarm (3.3.101.0)
	* This release introduces support for tagging, tag-based access control, and resource-based access control.
* EC2 (3.3.109.0)
	* This release adds idempotency support for associate, create route and authorization APIs for AWS Client VPN Endpoints.
* ElasticFileSystem (3.3.101.0)
	* AWS EFS documentation updated to reflect the minimum required value for ProvisionedThroughputInMibps is 1 from the previously documented 0. The service has always required a minimum value of 1, therefor service behavior is not changed. 
* RDS (3.3.102.15)
	* Documentation updates for rds
* ServiceCatalog (3.3.104.0)
	* Service Catalog UpdateProvisionedProductProperties API enables customers to manage provisioned product ownership. Administrators can now update the user associated to a provisioned product to another user within the same account allowing the new user to describe, update, terminate and execute service actions in that Service Catalog resource. New owner will also be able to list and describe all past records executed for that provisioned product.
* WorkLink (3.3.102.0)
	* Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. This release introduces new APIs to associate and manage website authorization providers with Amazon WorkLink fleets.
* Core 3.3.101.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.515.0 (2019-05-21 18:30 UTC)
* AlexaForBusiness (3.3.104.0)
	* This release contains API changes to allow customers to create and manage Network Profiles for their Shared devices
* DataSync (3.3.102.0)
	* Documentation update and refine pagination token on Datasync List API's
* Core 3.3.101.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.514.0 (2019-05-20 18:14 UTC)
* AWSMarketplaceMetering (3.3.100.21)
	* Documentation updates for meteringmarketplace
* Kafka (3.3.102.0)
	* Updated APIs for the Managed Streaming for Kafka service that let customers create clusters with custom Kafka configuration. 
* MediaPackageVod (3.3.100.0)
	* AWS Elemental MediaPackage now supports Video-on-Demand (VOD) workflows.  These new features allow you to easily deliver a vast library of source video Assets stored in your own S3 buckets using a small set of simple to set up Packaging Configurations and Packaging Groups.
* Core 3.3.101.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.513.0 (2019-05-17 18:26 UTC)
* AppStream (3.3.101.0)
	* Includes APIs for managing subscriptions to AppStream 2.0 usage reports and configuring idle disconnect timeouts on AppStream 2.0 fleets.
* Core 3.3.101.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.512.0 (2019-05-16 18:42 UTC)
* S3 (3.3.102.0)
	* This release updates the Amazon S3 PUT Bucket replication API to include a new optional field named token, which allows you to add a replication configuration to an S3 bucket that has Object Lock enabled.

### 3.3.511.0 (2019-05-15 18:09 UTC)
* CodePipeline (3.3.102.0)
	* This feature includes new APIs to add, edit, remove and view tags for pipeline, custom action type and webhook resources. You can also add tags while creating these resources.
* EC2 (3.3.108.0)
	* Adding tagging support for VPC Endpoints and VPC Endpoint Services.
* MediaPackage (3.3.101.0)
	* Adds optional configuration for DASH SegmentTemplateFormat to refer to segments by Number with Duration, rather than Number or Time with SegmentTimeline.
* RDS (3.3.102.11)
	* In the RDS API and CLI documentation, corrections to the descriptions for Boolean parameters to avoid references to TRUE and FALSE. The RDS CLI does not allow TRUE and FALSE values values for Boolean parameters.
* TranscribeService (3.3.104.0)
	* Amazon Transcribe - support transcriptions from audio sources in Indian English (en-IN) and Hindi (hi-IN).
* Core 3.3.101.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.510.0 (2019-05-14 18:18 UTC)
* Chime (3.3.101.0)
	* Amazon Chime private bots GA release.
* Comprehend (3.3.104.0)
	* With this release AWS Comprehend now supports Virtual Private Cloud for Asynchronous Batch Processing jobs
* EC2 (3.3.107.0)
	* Pagination support for ec2.DescribeSubnets, ec2.DescribeDhcpOptions 
* StorageGateway (3.3.105.0)
	* Add Tags parameter to CreateSnapshot and UpdateSnapshotSchedule APIs, used for creating tags on create for one off snapshots and scheduled snapshots.

### 3.3.509.0 (2019-05-13 18:28 UTC)
* DataSync (3.3.101.0)
	* AWS DataSync now enables exclude and include filters to control what files and directories will be copied as part of a task execution.
* IoTAnalytics (3.3.102.0)
	* ContentDeliveryRule to support sending dataset to S3 and glue
* Lambda (3.3.102.0)
	* AWS Lambda now supports Node.js v10

### 3.3.508.0 (2019-05-10 19:45 UTC)
* Glue (3.3.103.0)
	* AWS Glue now supports specifying existing catalog tables for a crawler to examine as a data source. A new parameter CatalogTargets is added to the CrawlerTargets data type. 
* SecurityToken (3.3.101.0)
	* AWS Security Token Service (STS) now supports passing IAM Managed Policy ARNs as session policies when you programmatically create temporary sessions for a role or federated user. The Managed Policy ARNs can be passed via the PolicyArns parameter, which is now available in the AssumeRole, AssumeRoleWithWebIdentity, AssumeRoleWithSAML, and GetFederationToken APIs. The session policies referenced by the PolicyArn parameter will only further restrict the existing permissions of an IAM User or Role for individual sessions.
* Core 3.3.101.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.507.0 (2019-05-08 18:12 UTC)
* EKS (3.3.101.13)
	* Documentation update for Amazon EKS to clarify allowed parameters in update-cluster-config.
* KinesisAnalytics (3.3.101.0)
	* Kinesis Data Analytics APIs now support tagging on applications.
* KinesisAnalyticsV2 (3.3.101.0)
	* Kinesis Data Analytics APIs now support tagging on applications.
* SageMaker (3.3.101.0)
	* Workteams now supports notification configurations. Neo now supports Jetson Nano as a target device and NumberOfHumanWorkersPerDataObject is now included in the ListLabelingJobsForWorkteam response.
* ServiceCatalog (3.3.103.0)
	* Adds "Parameters" field in UpdateConstraint API, which will allow Admin user to update "Parameters" in created Constraints.
* Core 3.3.101.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.506.0 (2019-05-07 18:30 UTC)
* AlexaForBusiness (3.3.103.0)
	* This release adds an API allowing authorized users to delete a shared device's history of voice recordings and associated response data.
* AppSync (3.3.101.0)
	* AWS AppSync now supports the ability to add additional authentication providers to your AWS AppSync GraphQL API as well as the ability to retrieve directives configured against fields or object type definitions during schema introspection.
* SimpleSystemsManagement (3.3.102.0)
	* Patch Manager adds support for Microsoft Application Patching.
* StorageGateway (3.3.104.0)
	* Add optional field AdminUserList to CreateSMBFileShare and UpdateSMBFileShare APIs.
* Core 3.3.101.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.505.1 (2019-05-06 19:13 UTC)
* CodePipeline (3.3.101.3)
	* Documentation updates for codepipeline
* ConfigService (3.3.100.16)
	* AWS Config now supports tagging on PutConfigRule, PutConfigurationAggregator and PutAggregationAuthorization APIs.
* IdentityManagement (3.3.101.5)
	* Documentation updates for iam
* SecurityToken (3.3.100.16)
	* Documentation updates for sts

### 3.3.505.0 (2019-05-03 18:07 UTC)
* CognitoIdentityProvider (3.3.102.0)
	* This release of Amazon Cognito User Pools introduces the new AdminSetUserPassword API that allows administrators of a user pool to change a user's password. The new password can be temporary or permanent.
* MediaConvert (3.3.103.0)
	* DASH output groups using DRM encryption can now enable a playback device compatibility mode to correct problems with playback on older devices. 
* MediaLive (3.3.103.0)
	* You can now switch the channel mode of your channels from standard to single pipeline and from single pipeline to standard. In order to switch a channel from single pipeline to standard all inputs attached to the channel must support two encoder pipelines.
* WorkMail (3.3.101.0)
	* Amazon WorkMail is releasing two new actions: 'GetMailboxDetails' and 'UpdateMailboxQuota'. They add insight into how much space is used by a given mailbox (size) and what its limit is (quota). A mailbox quota can be updated, but lowering the value will not influence WorkMail per user charges. For a closer look at the actions please visit https://docs.aws.amazon.com/workmail/latest/APIReference/API_Operations.html
* Core 3.3.101.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.504.0 (2019-05-02 19:45 UTC)
* AlexaForBusiness (3.3.102.0)
	* This release allows developers and customers to send text and audio announcements to rooms.
* KeyManagementService (3.3.101.0)
	* AWS Key Management Service (KMS) can return an INTERNAL_ERROR connection error code if it cannot connect a custom key store to its AWS CloudHSM cluster. INTERNAL_ERROR is one of several connection error codes that help you to diagnose and fix a problem with your custom key store.
* Core 3.3.101.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.503.0 (2019-05-01 18:10 UTC)
* EC2 (3.3.106.0)
	* This release adds an API for the modification of a VPN Connection, enabling migration from a Virtual Private Gateway (VGW) to a Transit Gateway (TGW), while preserving the VPN endpoint IP addresses on the AWS side as well as the tunnel options.
* ECS (3.3.102.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces additional task definition parameters that enable you to define secret options for Docker log configuration, a per-container list contains secrets stored in AWS Systems Manager Parameter Store or AWS Secrets Manager.
* XRay (3.3.101.0)
	* AWS X-Ray now includes Analytics, an interactive approach to analyzing user request paths (i.e., traces). Analytics will allow you to easily understand how your application and its underlying services are performing. With X-Ray Analytics, you can quickly detect application issues, pinpoint the root cause of the issue, determine the severity of the issues, and identify which end users were impacted. With AWS X-Ray Analytics you can explore, analyze, and visualize traces, allowing you to find increases in response time to user requests or increases in error rates. Metadata around peak periods, including frequency and actual times of occurrence, can be investigated by applying filters with a few clicks. You can then drill down on specific errors, faults, and response time root causes and view the associated traces. 

### 3.3.502.0 (2019-04-30 18:24 UTC)
* CodePipeline (3.3.101.0)
	* This release contains an update to the PipelineContext object that includes the Pipeline ARN, and the Pipeline Execution Id. The ActionContext object is also updated to include the Action Execution Id.
* DirectConnect (3.3.102.0)
	* This release adds support for AWS Direct Connect customers to use AWS Transit Gateway with AWS Direct Connect gateway to route traffic between on-premise networks and their VPCs.
* ManagedBlockchain (3.3.100.0)
	* (New Service) Amazon Managed Blockchain is a fully managed service that makes it easy to create and manage scalable blockchain networks using popular open source frameworks.
* Neptune (3.3.100.13)
	* Adds a feature to allow customers to specify a custom parameter group when restoring a database cluster.
* S3Control (3.3.101.0)
	* Add support for Amazon S3 Batch Operations.
* ServiceCatalog (3.3.102.0)
	* Admin users can now associate/disassociate aws budgets with a portfolio or product in Service Catalog. End users can see the association by listing it or as part of the describe portfolio/product output. A new optional boolean parameter, "DisableTemplateValidation", is added to ProvisioningArtifactProperties data type. The purpose of the parameter is to enable or disable the CloudFormation template validtion when creating a product or a provisioning artifact.
* Core 3.3.101.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.501.0 (2019-04-29 18:09 UTC)
* EC2 (3.3.105.0)
	* Adds support for Elastic Fabric Adapter (EFA) ENIs. 
* Transfer (3.3.102.0)
	* This release adds support for per-server host-key management. You can now specify the SSH RSA private key used by your SFTP server.
* Core 3.3.101.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.500.0 (2019-04-26 19:02 UTC)
* IdentityManagement (3.3.101.0)
	* AWS Security Token Service (STS) enables you to request session tokens from the global STS endpoint that work in all AWS Regions. You can configure the global STS endpoint to vend session tokens that are compatible with all AWS Regions using the new IAM SetSecurityTokenServicePreferences API. 
* SimpleNotificationService (3.3.101.0)
	* With this release AWS SNS adds tagging support for Topics.
* Core 3.3.101.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.499.0 (2019-04-25 20:21 UTC)
* Batch (3.3.101.6)
	* Documentation updates for AWS Batch.
* DynamoDBv2 (3.3.101.0)
	* This update allows you to tag Amazon DynamoDB tables when you create them. Tags are labels you can attach to AWS resources to make them easier to manage, search, and filter. 
* GameLift (3.3.101.0)
	* This release introduces the new Realtime Servers feature, giving game developers a lightweight yet flexible solution that eliminates the need to build a fully custom game server. The AWS SDK updates provide support for scripts, which are used to configure and customize Realtime Servers.
* Inspector (3.3.101.0)
	* AWS Inspector - Improve the ListFindings API response time and decreases the maximum number of agentIDs from 500 to 99.
* Lambda (3.3.101.0)
	* AWS Lambda now supports the GetLayerVersionByArn API.
* WorkSpaces (3.3.102.3)
	* Documentation updates for workspaces
* Core 3.3.101.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.498.0 (2019-04-24 23:22 UTC)
* Core 3.3.101.0
	* Added SAML authentication support in the .NET Standard 2.0 flavor of the SDK; Fix for expired token while using federated AWS credentials; Reverting updates to endpoints.json file from Core 3.3.100.8
	* All services packages updated to require new Core

### 3.3.497.0 (2019-04-24 18:09 UTC)
* AlexaForBusiness (3.3.101.0)
	* This release adds support for the Alexa for Business gateway and gateway group APIs.
* CloudFormation (3.3.100.8)
	* Documentation updates for cloudformation
* EC2 (3.3.104.0)
	* You can now launch the new Amazon EC2 general purpose burstable instance types T3a that feature AMD EPYC processors.
* MediaConnect (3.3.101.0)
	* Adds support for ListEntitlements pagination.
* MediaTailor (3.3.101.0)
	* AWS Elemental MediaTailor SDK now includes a new parameter to support origin servers that produce single-period DASH manifests.
* RDS (3.3.102.0)
	* A new parameter "feature-name" is added to the add-role and remove-role db cluster APIs. The value for the parameter is optional for Aurora MySQL compatible database clusters, but mandatory for Aurora PostgresQL. You can find the valid list of values using describe db engine versions API.
* Route53 (3.3.101.0)
	* Amazon Route 53 now supports the Asia Pacific (Hong Kong) Region (ap-east-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SimpleSystemsManagement (3.3.101.0)
	* This release updates AWS Systems Manager APIs to allow customers to configure parameters to use either the standard-parameter tier (the default tier) or the advanced-parameter tier. It allows customers to create parameters with larger values and attach parameter policies to an Advanced Parameter. 
* StorageGateway (3.3.103.0)
	* AWS Storage Gateway now supports Access Control Lists (ACLs) on File Gateway SMB shares, enabling you to apply fine grained access controls for Active Directory users and groups.
* Textract (3.3.101.0)
	* This release adds support for checkbox also known as SELECTION_ELEMENT in Amazon Textract.
* Core 3.3.100.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.496.0 (2019-04-19 18:09 UTC)
* ResourceGroups (3.3.101.0)
	* The AWS Resource Groups service increased the query size limit to 4096 bytes.
* TranscribeService (3.3.103.0)
	* Amazon Transcribe - support transcriptions from audio sources in Spanish Spanish (es-ES).
* WorkSpaces (3.3.102.0)
	* Added a new reserved field.

### 3.3.495.0 (2019-04-18 21:07 UTC)
* ApplicationDiscoveryService (3.3.101.0)
	* The Application Discovery Service's DescribeImportTasks and BatchDeleteImportData APIs now return additional statuses for error reporting.
* CognitoIdentityProvider (3.3.101.1)
	* Document updates for Amazon Cognito Identity Provider.
* Kafka (3.3.101.0)
	* Amazon Kafka - Added tagging APIs
* Organizations (3.3.101.0)
	* AWS Organizations is now available in the AWS GovCloud (US) Regions, and we added a new API action for creating accounts in those Regions. For more information, see CreateGovCloudAccount in the AWS Organizations API Reference. 
* RDS (3.3.101.0)
	* This release adds the TimeoutAction parameter to the ScalingConfiguration of an Aurora Serverless DB cluster. You can now configure the behavior when an auto-scaling capacity change can't find a scaling point.
* WorkLink (3.3.101.0)
	* Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. This release introduces new APIs to link and manage internal websites and web apps with Amazon WorkLink fleets. 
* WorkSpaces (3.3.101.5)
	* Documentation updates for workspaces
* Core 3.3.100.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.494.0 (2019-04-17 18:14 UTC)
* EC2 (3.3.103.0)
	* This release adds support for requester-managed Interface VPC Endpoints (powered by AWS PrivateLink). The feature prevents VPC endpoint owners from accidentally deleting or otherwise mismanaging the VPC endpoints of some AWS VPC endpoint services.
* Polly (3.3.101.0)
	* Amazon Polly adds Arabic language support with new female voice - "Zeina"

### 3.3.493.0 (2019-04-16 18:22 UTC)
* CloudWatch (3.3.101.3)
	* Documentation updates for monitoring
* CognitoIdentityProvider (3.3.101.0)
	* This release adds support for the new email configuration in Amazon Cognito User Pools. You can now specify whether Amazon Cognito emails your users by using its built-in email functionality or your Amazon SES email configuration.
* MQ (3.3.101.0)
	* This release adds the ability to retrieve information about broker engines and broker instance options. See Broker Engine Types and Broker Instance Options in the Amazon MQ REST API Reference.
* Organizations (3.3.100.6)
	* Documentation updates for organizations
* Redshift (3.3.101.0)
	* DescribeResize can now return percent of data transferred from source cluster to target cluster for a classic resize.
* StorageGateway (3.3.102.0)
	* This change allows you to select either a weekly or monthly maintenance window for your volume or tape gateway. It also allows you to tag your tape and volume resources on creation by adding a Tag value on calls to the respective api endpoints.
* Core 3.3.100.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.492.0 (2019-04-05 18:07 UTC)
* Comprehend (3.3.103.0)
	* With this release AWS Comprehend provides confusion matrix for custom document classifier.
* Glue (3.3.102.0)
	* AWS Glue now supports workerType choices in the CreateJob, UpdateJob, and StartJobRun APIs, to be used for memory-intensive jobs.
* IoT1ClickDevicesService (3.3.101.5)
	* Documentation updates for 1-Click: improved descriptions of resource tagging APIs.
* MediaConvert (3.3.102.0)
	* Rectify incorrect modelling of DisassociateCertificate method
* MediaLive (3.3.102.0)
	* Today AWS Elemental MediaLive (https://aws.amazon.com/medialive/) adds the option to create "Single Pipeline" channels, which offers a lower-cost option compared to Standard channels. MediaLive Single Pipeline channels have a single encoding pipeline rather than the redundant dual Availability Zone (AZ) pipelines that MediaLive provides with a "Standard" channel.

### 3.3.491.1 (2019-04-04 21:40 UTC)
* Core 3.3.100.5
	* Retry Support for RequestThrottledException
	* All services packages updated to require new Core

### 3.3.491.0 (2019-04-04 18:43 UTC)
* EKS (3.3.101.0)
	* Added support to enable or disable publishing Kubernetes cluster logs in AWS CloudWatch
* IdentityManagement (3.3.100.5)
	* Documentation updates for iam

### 3.3.490.0 (2019-04-03 18:38 UTC)
* Batch (3.3.101.0)
	* Support for GPU resource requirement in RegisterJobDefinition and SubmitJob
* Comprehend (3.3.102.0)
	* With this release AWS Comprehend  adds tagging support for document-classifiers and entity-recognizers.
* Core 3.3.100.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.489.0 (2019-04-02 18:11 UTC)
* CertificateManager (3.3.100.4)
	* Documentation updates for acm
* EC2 (3.3.102.0)
	* Add paginators.
* SecurityHub (3.3.101.0)
	* This update includes 3 additional error codes: AccessDeniedException, InvalidAccessException, and ResourceConflictException. This update also removes the error code ResourceNotFoundException from the GetFindings, GetInvitationsCount, ListInvitations, and ListMembers operations. 

### 3.3.488.0 (2019-04-01 18:17 UTC)
* ElasticMapReduce (3.3.101.0)
	* Amazon EMR adds the ability to modify instance group configurations on a running cluster through the new "configurations" field in the ModifyInstanceGroups API.
* SimpleSystemsManagement (3.3.100.4)
	* March 2019 documentation updates for Systems Manager.

### 3.3.487.0 (2019-03-29 18:48 UTC)
* CloudWatch (3.3.101.0)
	* Added 3 new APIs, and one additional parameter to PutMetricAlarm API, to support tagging of CloudWatch Alarms.
* Comprehend (3.3.101.0)
	* With this release AWS Comprehend supports encryption of output results of analysis jobs and volume data on the storage volume attached to the compute instance that processes the analysis job.
* Greengrass (3.3.101.0)
	* Greengrass APIs now support tagging operations on resources
* Core 3.3.100.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.486.0 (2019-03-28 19:15 UTC)
* MediaLive (3.3.101.0)
	* This release adds a new output locking mode synchronized to the Unix epoch.
* PinpointEmail (3.3.101.0)
	* This release adds support for using the Amazon Pinpoint Email API to tag the following types of Amazon Pinpoint resources: configuration sets; dedicated IP pools; deliverability dashboard reports; and, email identities. A tag is a label that you optionally define and associate with these types of resources. Tags can help you categorize and manage these resources in different ways, such as by purpose, owner, environment, or other criteria. A resource can have as many as 50 tags. For more information, see the Amazon Pinpoint Email API Reference.
* ServiceCatalog (3.3.101.0)
	* Adds "Tags" field in UpdateProvisionedProduct API. The product should have a new RESOURCE_UPDATE Constraint with TagUpdateOnProvisionedProduct field set to ALLOWED for it to work. See API docs for CreateConstraint for more information
* WorkSpaces (3.3.101.0)
	* Amazon WorkSpaces adds tagging support for WorkSpaces Images, WorkSpaces directories, WorkSpaces bundles and IP Access control groups.

### 3.3.485.0 (2019-03-27 20:34 UTC)
* AppMesh (3.3.101.0)
	* This release includes AWS Tagging integration for App Mesh, VirtualNode access logging, TCP routing, and Mesh-wide external traffic egress control. See https://docs.aws.amazon.com/app-mesh/latest/APIReference/Welcome.html for more details.
* EC2 (3.3.101.0)
	* You can now launch the new Amazon EC2 R5ad and M5ad instances that feature local NVMe attached SSD instance storage (up to 3600 GB). M5ad and R5ad feature AMD EPYC processors that offer a 10% cost savings over the M5d and R5d EC2 instances.
* ECS (3.3.101.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for external deployment controllers for ECS services with the launch of task set management APIs. Task sets are a new primitive for controlled management of application deployments within a single ECS service.
* ElasticLoadBalancingV2 (3.3.101.0)
	* This release adds support for routing based on HTTP headers, methods, query string or query parameters and source IP addresses in Application Load Balancer.
* S3 (3.3.101.0)
	* S3 Glacier Deep Archive provides secure, durable object storage class for long term data archival. This SDK release provides API support for this new storage class.
* StorageGateway (3.3.101.0)
	* This change allows you to select a pool for archiving virtual tapes. Pools are associated with S3 storage classes. You can now choose to archive virtual tapes in either S3 Glacier or S3 Glacier Deep Archive storage class. CreateTapes API now takes a new PoolId parameter which can either be GLACIER or DEEP_ARCHIVE. Tapes created with this parameter will be archived in the corresponding storage class.
* Transfer (3.3.101.0)
	*  This release adds PrivateLink support to your AWS SFTP server endpoint, enabling the customer to access their SFTP server within a VPC, without having to traverse the internet. Customers can now can create a server and specify an option whether they want the endpoint to be hosted as public or in their VPC, and with the in VPC option, SFTP clients and users can access the server only from the customer's VPC or from their on-premises environments using DX or VPN. This release also relaxes the SFTP user name requirements to allow underscores and hyphens.

### 3.3.484.0 (2019-03-26 19:47 UTC)
* Glue (3.3.101.0)
	* This new feature will now allow customers to add a customized csv classifier with classifier API. They can specify a custom delimiter, quote symbol and control other behavior they'd like crawlers to have while recognizing csv files
* WorkMail (3.3.100.2)
	* Documentation updates for Amazon WorkMail.
* Core 3.3.100.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.483.0 (2019-03-25 18:24 UTC)
* DirectConnect (3.3.101.0)
	* Direct Connect gateway enables you to establish connectivity between your on-premise networks and Amazon Virtual Private Clouds (VPCs) in any commercial AWS Region (except in China) using AWS Direct Connect connections at any AWS Direct Connect location. This release enables multi-account support for Direct Connect gateway, with multi-account support for Direct Connect gateway, you can associate up to ten VPCs from any AWS account with a Direct Connect gateway. The AWS accounts owning VPCs and the Direct Connect gateway must belong to the same AWS payer account ID. This release also enables Direct Connect Gateway owners to allocate allowed prefixes from each associated VPCs.
* FMS (3.3.101.0)
	* AWS Firewall Manager now allows customer to centrally enable AWS Shield Advanced DDoS protection for their entire AWS infrastructure, across accounts and applications.
* IoT1ClickDevicesService (3.3.101.0)
	* This release adds tagging support for AWS IoT 1-Click Device resources. Use these APIs to add, remove, or list tags on Devices, and leverage the tags for various authorization and billing scenarios. This release also adds the ARN property for DescribeDevice response object.
* IoTAnalytics (3.3.101.0)
	* This change allows you to specify the number of versions of IoT Analytics data set content to be retained. Previously, the number of versions was managed implicitly via the setting of the data set's retention period.
* MediaConvert (3.3.101.0)
	* This release adds support for detailed job progress status and S3 server-side output encryption. In addition, the anti-alias filter will now be automatically applied to all outputs
* RoboMaker (3.3.101.0)
	* Added additional progress metadata fields for robot deployments
* TranscribeService (3.3.102.0)
	* Amazon Transcribe - With this release Amazon Transcribe enhances the custom vocabulary feature to improve accuracy by providing customization on pronunciations and output formatting. 

### 3.3.482.0 (2019-03-22 20:57 UTC)
* IoT1ClickProjects (3.3.101.0)
	* This release adds tagging support for AWS IoT 1-Click Project resources. Use these APIs to add, remove, or list tags on Projects, and leverage the tags for various authorization and billing scenarios. This release also adds the ARN property to projects for DescribeProject and ListProject responses.
* TranscribeService (3.3.101.0)
	* Amazon Transcribe - support transcriptions from audio sources in German (de-DE) and Korean (ko-KR).
* Core 3.3.100.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.481.0 (2019-03-21 21:55 UTC)
* Core 3.3.100.0
	* Added .NET Standard 2.0 support. All services packages starting with 3.3.100 will also include .NET Standard 2.0 support.
	* All services packages updated to require new Core

### 3.3.480.0 (2019-03-21 18:07 UTC)
* AutoScaling (3.3.9.5)
	* Documentation updates for Amazon EC2 Auto Scaling
* CloudWatchEvents (3.3.9.0)
	* Added 3 new APIs, and one additional parameter to the PutRule API, to support tagging of CloudWatch Events rules.
* CognitoIdentityProvider (3.3.13.0)
	* This release adds tags and tag-based access control support to Amazon Cognito User Pools.
* IoT (3.3.27.0)
	* This release adds the GetStatistics API for the AWS IoT Fleet Indexing Service, which allows customers to query for statistics about registered devices that match a search query. This release only supports the count statistics. For more information about this API, see https://docs.aws.amazon.com/iot/latest/apireference/API_GetStatistics.html
* Lightsail (3.3.10.0)
	* This release adds the DeleteKnownHostKeys API, which enables Lightsail's browser-based SSH or RDP clients to connect to the instance after a host key mismatch.

### 3.3.479.0 (2019-03-20 18:09 UTC)
* AWSMarketplaceMetering (3.3.3.0)
	* This release increases AWS Marketplace Metering Service maximum usage quantity to 2147483647 and makes parameters usage quantity and dryrun optional.
* CodePipeline (3.3.7.0)
	* Add support for viewing details of each action execution belonging to past and latest pipeline executions that have occurred in customer's pipeline. The details include start/updated times, action execution results, input/output artifacts information, etc. Customers also have the option to add pipelineExecutionId in the input to filter the results down to a single pipeline execution.
* CognitoIdentity (3.3.3.0)
	* This release adds tags and tag-based access control support to Amazon Cognito Identity Pools (Federated Identities). 

### 3.3.478.0 (2019-03-19 18:29 UTC)
* ConfigService (3.3.25.0)
	* AWS Config adds a new API called SelectResourceConfig to run advanced queries based on resource configuration properties.
* EKS (3.3.4.0)
	* Added support to control private/public access to the Kubernetes API-server endpoint

### 3.3.477.0 (2019-03-18 18:07 UTC)
* Chime (3.3.2.0)
	* This release adds support for the Amazon Chime Business Calling and Voice Connector features.
* DatabaseMigrationService (3.3.14.0)
	* S3 Endpoint Settings added support for 1) Migrating to Amazon S3 as a target in Parquet format 2) Encrypting S3 objects after migration with custom KMS Server-Side encryption. Redshift Endpoint Settings added support for encrypting intermediate S3 objects during migration with custom KMS Server-Side encryption. 
* EC2 (3.3.87.0)
	* DescribeFpgaImages API now returns a new DataRetentionSupport attribute to indicate if the AFI meets the requirements to support DRAM data retention. DataRetentionSupport is a read-only attribute.

### 3.3.476.0 (2019-03-14 18:31 UTC)
* ACMPCA (3.3.4.0)
	* AWS Certificate Manager (ACM) Private CA allows customers to manage permissions on their CAs. Customers can grant or deny AWS Certificate Manager permission to renew exported private certificates.
* CertificateManager (3.3.6.0)
	* AWS Certificate Manager has added a new API action, RenewCertificate. RenewCertificate causes ACM to force the renewal of any private certificate which has been exported.
* CloudWatch (3.3.11.0)
	* New Messages parameter for the output of GetMetricData, to support new metric search functionality.
* ConfigService (3.3.24.0)
	* AWS Config - add ability to tag, untag and list tags for ConfigRule, ConfigurationAggregator and AggregationAuthorization resource types. Tags can be used for various scenarios including tag based authorization.
* EC2 (3.3.86.0)
	* This release adds tagging support for Dedicated Host Reservations.
* IoT (3.3.26.0)
	* In this release, AWS IoT introduces support for tagging OTA Update and Stream resources. For more information about tagging, see the AWS IoT Developer Guide.
* SageMaker (3.3.21.0)
	* Amazon SageMaker Automatic Model Tuning now supports random search and hyperparameter scaling.

### 3.3.475.0 (2019-03-13 18:06 UTC)
* CloudWatchLogs (3.3.7.25)
	* Documentation updates for logs
* ConfigService (3.3.23.0)
	* Config released Remediation APIs allowing Remediation of Config Rules

### 3.3.474.0 (2019-03-12 18:09 UTC)
* ServerlessApplicationRepository (3.3.5.0)
	* The AWS Serverless Application Repository now supports associating a ZIP source code archive with versions of an application.

### 3.3.473.0 (2019-03-11 18:07 UTC)
* CostExplorer (3.3.11.0)
	* The only change in this release is to make TimePeriod a required parameter in GetCostAndUsageRequest.
* ElasticBeanstalk (3.3.13.0)
	* Elastic Beanstalk added support for tagging, and tag-based access control, of all Elastic Beanstalk resources.
* Glue (3.3.19.0)
	* CreateDevEndpoint and UpdateDevEndpoint now support Arguments to configure the DevEndpoint. 
* IoT (3.3.25.5)
	* Documentation updates for iot
* QuickSight (3.3.2.0)
	* Amazon QuickSight user and group operation results now include group principal IDs and user principal IDs. This release also adds "DeleteUserByPrincipalId", which deletes users given their principal ID. The update also improves role session name validation.
* Rekognition (3.3.15.6)
	* Documentation updates for Amazon Rekognition
* Core 3.3.32.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.472.0 (2019-03-08 21:11 UTC)
* CodeBuild (3.3.23.0)
	* CodeBuild also now supports Git Submodules.  CodeBuild now supports opting out of Encryption for S3 Build Logs.  By default these logs are encrypted.
* S3 (3.3.31.23)
	* Documentation updates for s3
* SageMaker (3.3.20.0)
	* SageMaker notebook instances now support enabling or disabling root access for notebook users. SageMaker Neo now supports rk3399 and rk3288 as compilation target devices.

### 3.3.471.0 (2019-03-07 19:31 UTC)
* AppMesh (3.3.1.0)
	* This release includes a new version of the AWS App Mesh APIs. You can read more about the new APIs here: https://docs.aws.amazon.com/app-mesh/latest/APIReference/Welcome.html.
* AutoScaling (3.3.9.3)
	* Documentation updates for autoscaling
* ECS (3.3.24.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces additional task definition parameters that enable you to define dependencies for container startup and shutdown, a per-container start and stop timeout value, as well as an AWS App Mesh proxy configuration which eases the integration between Amazon ECS and AWS App Mesh.
* GameLift (3.3.14.0)
	* Amazon GameLift-hosted instances can now securely access resources on other AWS services using IAM roles. See more details at https://aws.amazon.com/releasenotes/amazon-gamelift/.
* Greengrass (3.3.6.0)
	* Greengrass group UID and GID settings can now be configured to use a provided default via FunctionDefaultConfig. If configured, all Lambda processes in your deployed Greengrass group will by default start with the provided UID and/or GID, rather than by default starting with UID "ggc_user" and GID "ggc_group" as they would if not configured. Individual Lambdas can also be configured to override the defaults if desired via each object in the Functions list of your FunctionDefinitionVersion.
* MediaLive (3.3.19.0)
	* This release adds a MediaPackage output group, simplifying configuration of outputs to AWS Elemental MediaPackage.
* RDS (3.3.39.0)
	* You can configure your Aurora database cluster to automatically copy tags on the cluster to any automated or manual database cluster snapshots that are created from the cluster. This allows you to easily set metadata on your snapshots to match the parent cluster, including access policies. You may enable or disable this functionality while creating a new cluster, or by modifying an existing database cluster.
* Core 3.3.32.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.470.0 (2019-03-06 22:12 UTC)
* Core 3.3.32.0
	* Upgrades for XML service generation of maps and idempotency tokens; Implement the Standard IMDS Request Header; Bypass using capacity for clock skew errors; Fix to find resource when running from service project; Switch rest-json based service's content-type to application/json; Use wildcard for test project references
	* All services packages updated to require new Core

### 3.3.469.0 (2019-03-06 20:13 UTC)
* DirectConnect (3.3.11.0)
	* Exposed a new available port speeds field in the DescribeLocation api call.
* EC2 (3.3.85.0)
	* This release adds pagination support for ec2.DescribeVpcs, ec2.DescribeInternetGateways and ec2.DescribeNetworkAcls APIs
* ElasticFileSystem (3.3.4.3)
	* Documentation updates for elasticfilesystem adding new examples for EFS Lifecycle Management feature.

### 3.3.468.0 (2019-03-05 21:51 UTC)
* CodeDeploy (3.3.12.22)
	* Documentation updates for codedeploy
* MediaLive (3.3.18.0)
	* This release adds support for pausing and unpausing one or both pipelines at scheduled times.
* StorageGateway (3.3.14.0)
	* ActivateGateway, CreateNFSFileShare and CreateSMBFileShare APIs support a new parameter: Tags (to be attached to the created resource). Output for DescribeNFSFileShare, DescribeSMBFileShare and DescribeGatewayInformation APIs now also list the Tags associated with the resource. Minimum length of a KMSKey is now 7 characters.
* Textract (3.3.0.0)
	* This release is intended ONLY for customers that are officially part of the Amazon Textract Preview program.  If you are not officially part of the Amazon Textract program THIS WILL NOT WORK.  Our two main regions for Amazon Textract Preview are N. Virginia and Dublin.  Also some members have been added to Oregon and Ohio.  If you are outside of any of these AWS regions, Amazon Textract Preview definitely will not work. If you would like to be part of the Amazon Textract program, you can officially request sign up here - https://pages.awscloud.com/textract-preview.html. To set expectations appropriately, we are aiming to admit new preview participants once a week until General Availability.

### 3.3.467.0 (2019-03-04 19:17 UTC)
* MediaPackage (3.3.7.0)
	* This release adds support for user-defined tagging of MediaPackage resources. Users may now call operations to list, add and remove tags from channels and origin-endpoints. Users can also specify tags to be attached to these resources during their creation. Describe and list operations on these resources will now additionally return any tags associated with them.
* SimpleSystemsManagement (3.3.41.0)
	* This release updates AWS Systems Manager APIs to support service settings for AWS customers.  A service setting is a key-value pair that defines how a user interacts with or uses an AWS service, and is typically created and consumed by the AWS service team. AWS customers can read a service setting via GetServiceSetting API and update the setting via UpdateServiceSetting API or ResetServiceSetting API, which are introduced in this release. For example, if an AWS service charges money to the account based on a feature or service usage, then the AWS service team might create a setting with the default value of "false".   This means the user can't use this feature unless they update the setting to "true" and  intentionally opt in for a paid feature.

### 3.3.466.0 (2019-03-01 19:41 UTC)
* AutoScalingPlans (3.3.2.22)
	* Documentation updates for autoscaling-plans
* EC2 (3.3.84.0)
	* This release adds support for modifying instance event start time which allows users to reschedule EC2 events.

### 3.3.465.0 (2019-02-28 20:48 UTC)
* AlexaForBusiness (3.3.9.0)
	* This release adds the PutInvitationConfiguration API to configure the user invitation email template with custom attributes, and the GetInvitationConfiguration API to retrieve the configured values.
* ApiGatewayV2 (3.3.1.0)
	* Marking certain properties as explicitly required and fixing an issue with the GetApiMappings operation for ApiMapping resources.
* ApplicationAutoScaling (3.3.11.3)
	* Documentation updates for application-autoscaling
* SimpleSystemsManagement (3.3.40.0)
	* AWS Systems Manager State Manager now supports associations using documents shared by other AWS accounts.

### 3.3.464.1 (2019-02-27 19:08 UTC)
* WAF (3.3.7.18)
	* Documentation updates for waf
* WAFRegional (3.3.7.18)
	* Documentation updates for waf-regional

### 3.3.464.0 (2019-02-26 19:09 UTC)
* ApplicationDiscoveryService (3.3.6.10)
	* Documentation updates for discovery
* CostAndUsageReport (3.3.1.0)
	* Adding support for Athena and new report preferences to the Cost and Usage Report API.
* MediaConvert (3.3.12.0)
	* AWS Elemental MediaConvert SDK has added several features including support for: auto-rotation or user-specified rotation of 0, 90, 180, or 270 degrees; multiple output groups with DRM; ESAM XML documents to specify ad insertion points; Offline Apple HLS FairPlay content protection. 
* OpsWorksCM (3.3.6.40)
	* Documentation updates for opsworkscm
* Organizations (3.3.9.41)
	* Documentation updates for AWS Organizations
* Pinpoint (3.3.13.0)
	* This release adds support for the Amazon Resource Groups Tagging API to Amazon Pinpoint, which means that you can now add and manage tags for Amazon Pinpoint projects (apps), campaigns, and segments. A tag is a label that you optionally define and associate with Amazon Pinpoint resource. Tags can help you categorize and manage these types of resources in different ways, such as by purpose, owner, environment, or other criteria. For example, you can use tags to apply policies or automation, or to identify resources that are subject to certain compliance requirements. A project, campaign, or segment can have as many as 50 tags. For more information about using and managing tags in Amazon Pinpoint, see the Amazon Pinpoint Developer Guide at https://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html. For more information about the Amazon Resource Group Tagging API, see the Amazon Resource Group Tagging API Reference at https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html.
* ResourceGroups (3.3.3.23)
	* Documentation updates for Resource Groups API; updating description of Tag API.
* Core 3.3.31.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.463.0 (2019-02-25 19:10 UTC)
* AutoScaling (3.3.9.0)
	* Added support for passing an empty SpotMaxPrice parameter to remove a value previously set when updating an Amazon EC2 Auto Scaling group.
* CostExplorer (3.3.10.0)
	* Added metrics to normalized units.
* ElasticLoadBalancingV2 (3.3.14.0)
	* This release enables you to use the existing client secret when modifying a rule with an action of type authenticate-oidc.
* MediaStore (3.3.3.0)
	* This release adds support for access logging, which provides detailed records for the requests that are made to objects in a container.

### 3.3.462.0 (2019-02-22 19:10 UTC)
* Athena (3.3.3.0)
	* This release adds tagging support for Workgroups to Amazon Athena. Use these APIs to add, remove, or list tags on Workgroups, and leverage the tags for various authorization and billing scenarios.
* Cloud9 (3.3.1.0)
	* Adding EnvironmentLifecycle to the Environment data type.
* Glue (3.3.18.0)
	* AWS Glue adds support for assigning AWS resource tags to jobs, triggers, development endpoints, and crawlers. Each tag consists of a key and an optional value, both of which you define. With this capacity, customers can use tags in AWS Glue to easily organize and identify your resources, create cost allocation reports, and control access to resources. 
* StepFunctions (3.3.5.0)
	* This release adds support for tag-on-create. You can now add tags when you create AWS Step Functions activity and state machine resources. For more information about tagging, see AWS Tagging Strategies.

### 3.3.461.0 (2019-02-21 19:19 UTC)
* CloudWatch (3.3.10.21)
	* Documentation updates for monitoring
* CodeBuild (3.3.22.0)
	* Add support for CodeBuild local caching feature
* KinesisVideo (3.3.2.3)
	* Documentation updates for Kinesis Video Streams
* KinesisVideoArchivedMedia (3.3.2.0)
	* In this release, HLS playback of KVS streams can be configured to output MPEG TS fragments using the ContainerFormat parameter. HLS playback of KVS streams can also be configured to include the EXT-X-PROGRAM-DATE-TIME field using the DisplayFragmentTimestamp parameter.
* KinesisVideoMedia (3.3.0.57)
	* Documentation updates for Kinesis Video Streams
* Organizations (3.3.9.40)
	* Documentation updates for organizations
* Transfer (3.3.1.0)
	* Bug fix: increased the max length allowed for request parameter NextToken when paginating List operations
* WorkDocs (3.3.7.21)
	* Documentation updates for workdocs

### 3.3.460.0 (2019-02-20 19:09 UTC)
* CodeCommit (3.3.9.0)
	* This release adds an API for adding / updating / deleting / copying / moving / setting file modes for one or more files directly to an AWS CodeCommit repository without requiring a Git client.
* DirectConnect (3.3.10.0)
	* Documentation updates for AWS Direct Connect
* MediaLive (3.3.17.0)
	* This release adds support for VPC inputs, allowing you to push content from your Amazon VPC directly to MediaLive.
* Core 3.3.31.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.459.0 (2019-02-19 19:08 UTC)
* DirectoryService (3.3.9.0)
	* This release adds support for tags during directory creation (CreateDirectory, CreateMicrosoftAd, ConnectDirectory).
* ElasticFileSystem (3.3.4.0)
	* Amazon EFS now supports adding tags to file system resources as part of the CreateFileSystem API . Using this capability, customers can now more easily enforce tag-based authorization for EFS file system resources.
* IoT (3.3.25.0)
	* AWS IoT - AWS IoT Device Defender adds support for configuring behaviors in a security profile with statistical thresholds. Device Defender also adds support for configuring multiple data-point evaluations before a violation is either created or cleared.
* SimpleSystemsManagement (3.3.39.0)
	* AWS Systems Manager now supports adding tags when creating Activations, Patch Baselines, Documents, Parameters, and Maintenance Windows

### 3.3.458.0 (2019-02-18 19:04 UTC)
* Athena (3.3.2.0)
	* This release adds support for Workgroups to Amazon Athena. Use Workgroups to isolate users, teams, applications or workloads in the same account, control costs by setting up query limits and creating Amazon SNS alarms, and publish query-related metrics to Amazon CloudWatch. 
* SecretsManager (3.3.3.0)
	* This release increases the maximum allowed size of SecretString or SecretBinary from 4KB to 7KB in the CreateSecret, UpdateSecret, PutSecretValue and GetSecretValue APIs.

### 3.3.457.0 (2019-02-15 19:19 UTC)
* ApplicationAutoScaling (3.3.11.0)
	* Documentation updates for Application Auto Scaling
* Chime (3.3.1.23)
	* Documentation updates for Amazon Chime
* IoT (3.3.24.0)
	* In this release, IoT Device Defender introduces support for tagging Scheduled Audit resources.
* Core 3.3.31.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.456.1 (2019-02-15 03:41 UTC)
* Chime (3.3.1.22)
	* Package description update.
* Connect (3.3.4.17)
	* Package description update.
* DLM (3.3.2.3)
	* Package description update.
* DocDB (3.3.0.9)
	* Package description update.
* IoT1ClickProjects (3.3.0.50)
	* Package description update.
* IoTAnalytics (3.3.7.12)
	* Package description update.
* RAM (3.3.0.20)
	* Package description update.
* S3Control (3.3.0.20)
	* Package description update.
* ServiceDiscovery (3.3.3.19)
	* Package description update.
* Signer (3.3.0.41)
	* Package description update.

### 3.3.456.0 (2019-02-14 19:14 UTC)
* EC2 (3.3.83.0)
	* This release adds tagging and ARN support for AWS Client VPN Endpoints.You can now run bare metal workloads on EC2 M5 and M5d instances. m5.metal and m5d.metal instances are powered by custom Intel Xeon Scalable Processors with a sustained all core frequency of up to 3.1 GHz. m5.metal and m5d.metal offer 96 vCPUs and 384 GiB of memory. With m5d.metal, you also have access to 3.6 TB of NVMe SSD-backed instance storage. m5.metal and m5d.metal instances deliver 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking, as well as 14 Gbps of bandwidth to EBS.You can now run bare metal workloads on EC2 z1d instances. z1d.metal instances are powered by custom Intel Xeon Scalable Processors with a sustained all core frequency of up to 4.0 GHz. z1d.metal offers 48 vCPUs, 384 GiB of memory, and 1.8 TB of NVMe SSD-backed instance storage. z1d.metal instances deliver 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking, as well as 14 Gbps of bandwidth to EBS.
* KinesisVideo (3.3.2.0)
	* Adds support for Tag-On-Create for Kinesis Video Streams. A list of tags associated with the stream can be created at the same time as the stream creation.

### 3.3.455.0 (2019-02-13 23:09 UTC)
* ElasticFileSystem (3.3.3.0)
	* Customers can now use the EFS Infrequent Access (IA) storage class to more cost-effectively store larger amounts of data in their file systems. EFS IA is cost-optimized storage for files that are not accessed every day. You can create a new file system and enable Lifecycle Management to automatically move files that have not been accessed for 30 days from the Standard storage class to the IA storage class.
* MediaTailor (3.3.4.0)
	* This release adds support for tagging AWS Elemental MediaTailor resources.
* Rekognition (3.3.15.0)
	* GetContentModeration now returns the version of the moderation detection model used to detect unsafe content.
* Core 3.3.31.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.454.1 (2019-02-12 23:14 UTC)
* Lambda (3.3.19.17)
	* Documentation updates for AWS Lambda
* Core 3.3.31.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.454.0 (2019-02-11 23:08 UTC)
* AppStream (3.3.21.0)
	* This update enables customers to find the start time, max expiration time, and connection status associated with AppStream streaming session.
* CodeBuild (3.3.21.0)
	* Add customized webhook filter support
* MediaPackage (3.3.6.0)
	* Adds optional configuration for DASH to compact the manifest by combining duplicate SegmentTemplate tags. Adds optional configuration for DASH SegmentTemplate format to refer to segments by "Number" (default) or by "Time".

### 3.3.453.0 (2019-02-08 22:10 UTC)
* ApplicationDiscoveryService (3.3.6.5)
	* Documentation updates for the AWS Application Discovery Service.
* DLM (3.3.2.0)
	* This release is to correct the timestamp format to ISO8601 for the DateCreated and DateModified files in the GetLifecyclePolicy response object.
* ECS (3.3.23.0)
	* Amazon ECS introduces the PutAccountSettingDefault API, an API that allows a user to set the default ARN/ID format opt-in status for all the roles and users in the account. Previously, setting the account's default opt-in status required the use of the root user with the PutAccountSetting API.

### 3.3.452.0 (2019-02-07 21:38 UTC)
* Elasticsearch (3.3.11.0)
	* Feature: Support for three Availability Zone deployments
* GameLift (3.3.13.0)
	* This release delivers a new API action for deleting unused matchmaking rule sets. More details are available at https://aws.amazon.com/releasenotes/?tag=releasenotes%23keywords%23amazon-gamelift.
* MediaLive (3.3.16.0)
	* This release adds tagging of channels, inputs, and input security groups.
* RoboMaker (3.3.1.0)
	* Added support for tagging and tag-based access control for AWS RoboMaker resources. Also, DescribeSimulationJob now includes a new failureReason field to help debug simulation job failures

### 3.3.451.0 (2019-02-06 23:18 UTC)
* EC2 (3.3.82.0)
	* Add Linux with SQL Server Standard, Linux with SQL Server Web, and Linux with SQL Server Enterprise to the list of allowed instance platforms for On-Demand Capacity Reservations.
* FSx (3.3.1.0)
	* New optional ExportPath parameter added to the CreateFileSystemLustreConfiguration object for user-defined export paths. Used with the CreateFileSystem action when creating an Amazon FSx for Lustre file system.

### 3.3.450.0 (2019-02-05 22:07 UTC)
* EC2 (3.3.81.0)
	* ec2.DescribeVpcPeeringConnections pagination support
* ServiceCatalog (3.3.13.20)
	* Service Catalog Documentation Update for ProvisionedProductDetail
* Shield (3.3.5.0)
	* The DescribeProtection request now accepts resource ARN as valid parameter.

### 3.3.449.0 (2019-02-04 22:36 UTC)
* ApplicationAutoScaling (3.3.10.45)
	* Documentation updates for application-autoscaling
* CodeCommit (3.3.8.0)
	* This release supports a more graceful handling of the error case when a repository is not associated with a pull request ID in a merge request in AWS CodeCommit.
* ECS (3.3.22.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for GPU workloads by enabling you to create clusters with GPU-enabled container instances.
* WorkSpaces (3.3.6.0)
	* This release sets ClientProperties as a required parameter.

### 3.3.448.1 (2019-02-04 17:02 UTC)
* S3 (3.3.31.15)
	* Update region constants.
* SecurityToken (3.3.4.50)
	* Fix to support documented role,saml-provider format.
* SimpleNotificationService (3.3.3.18)
	* Parse SNS subscription message correctly.
* Core 3.3.31.7
	* Fix clock skew caching when the ClientConfig endpoint is different from the request endpoint.
Update region constants.
	* All services packages updated to require new Core

### 3.3.448.0 (2019-01-25 22:30 UTC)
* CodeCommit (3.3.7.0)
	* The PutFile API will now throw new exception FilePathConflictsWithSubmodulePathException when a submodule exists at the input file path; PutFile API will also throw FolderContentSizeLimitExceededException when the total size of any folder on the path exceeds the limit as a result of the operation.
* DeviceFarm (3.3.13.0)
	* Introduces a new rule in Device Pools - "Availability". Customers can now ensure they pick devices that are available (i.e., not being used by other customers).
* MediaConnect (3.3.1.0)
	* This release adds support for tagging, untagging, and listing tags for existing AWS Elemental MediaConnect resources.
* MediaLive (3.3.15.0)
	* This release adds support for Frame Capture output groups and for I-frame only manifests (playlists) in HLS output groups.
* Core 3.3.31.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.447.0 (2019-01-24 23:03 UTC)
* CloudWatchLogs (3.3.7.14)
	* Documentation updates for CloudWatch Logs
* CodeBuild (3.3.20.0)
	* This release adds support for cross-account ECR images and private registry authentication. 
* ECR (3.3.5.0)
	* Amazon ECR updated the default endpoint URL to support AWS Private Link.
* ElasticLoadBalancingV2 (3.3.13.0)
	* Elastic Load Balancing now supports TLS termination on Network Load Balancers. With this launch, you can offload the decryption/encryption of TLS traffic from your application servers to the Network Load Balancer. This enables you to run your backend servers optimally and keep your workloads secure. Additionally, Network Load Balancers preserve the source IP of the clients to the back-end applications, while terminating TLS on the load balancer.  When TLS is enabled on an NLB, Access Logs can be enabled for the load balancer, and log entries will be emitted for all TLS connections.
* PinpointSMSVoice (3.3.2.0)
	* Added the ListConfigurationSets operation, which returns a list of the configuration sets that are associated with your account.
* RDS (3.3.38.0)
	* The Amazon RDS API allows you to add or remove Identity and Access Management (IAM) role associated with a specific feature name with an RDS database instance. This helps with capabilities such as invoking Lambda functions from within a trigger in the database, load data from Amazon S3 and so on
* Core 3.3.31.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.446.0 (2019-01-23 23:45 UTC)
* ACMPCA (3.3.3.0)
	* Added TagOnCreate parameter to the CreateCertificateAuthority operation, updated the Tag regex pattern to align with AWS tagging APIs, and added RevokeCertificate limit.
* ApiGatewayManagementApi (3.3.1.0)
	* Fixes a typo in the 'max' constraint.
* WorkLink (3.3.0.0)
	* This is the initial SDK release for Amazon WorkLink. Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. With Amazon WorkLink, employees can access internal websites as seamlessly as they access any other website. IT administrators can manage users, devices, and domains by enforcing their own security and access policies via the AWS Console or the AWS SDK.
* Core 3.3.31.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.445.0 (2019-01-21 22:53 UTC)
* ApplicationDiscoveryService (3.3.6.0)
	* The Application Discovery Service's import APIs allow you to import information about your on-premises servers and applications into ADS so that you can track the status of your migrations through the Migration Hub console.
* AppStream (3.3.20.0)
	* This API update includes support for tagging Stack, Fleet, and ImageBuilder resources at creation time.
* DatabaseMigrationService (3.3.13.0)
	* Update for DMS TestConnectionSucceeds waiter
* FMS (3.3.2.0)
	* This release provides support for cleaning up web ACLs during Firewall Management policy deletion. You can now enable the DeleteAllPolicyResources flag and it will delete all system-generated web ACLs.
* SimpleSystemsManagement (3.3.38.0)
	* AWS Systems Manager State Manager now supports configuration management of all AWS resources through integration with Automation. 

### 3.3.444.0 (2019-01-18 21:13 UTC)
* EC2 (3.3.80.0)
	* Adjust EC2's available instance types.
* Glue (3.3.17.0)
	* AllocatedCapacity field is being deprecated and replaced with MaxCapacity field

### 3.3.443.1 (2019-01-18 01:29 UTC)
* Signer (3.3.0.34)
	* Updated to use new Core, version 3.3.31.3
	* Updating package to use latest Core.

### 3.3.443.0 (2019-01-17 23:11 UTC)
* Lambda (3.3.19.12)
	* Documentation updates for AWS Lambda
* Lightsail (3.3.9.0)
	* This release adds functionality to the CreateDiskSnapshot API that allows users to snapshot instance root volumes. It also adds various documentation updates.
* Pinpoint (3.3.12.0)
	* This release updates the PutEvents operation. AppPackageName, AppTitle, AppVersionCode, SdkName fields will now be accepted as a part of the event when submitting events.
* Rekognition (3.3.14.0)
	* GetLabelDetection now returns bounding box information for common objects and a hierarchical taxonomy of detected labels. The version of the model used for video label detection is also returned. DetectModerationLabels now returns the version of the model used for detecting unsafe content.
* Core 3.3.31.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.442.0 (2019-01-16 18:53 UTC)
* Backup (3.3.0.0)
	* AWS Backup is a unified backup service designed to protect AWS services and their associated data. AWS Backup simplifies the creation, migration, restoration, and deletion of backups, while also providing reporting and auditing
* CostExplorer (3.3.9.11)
	* Removed Tags from the list of GroupBy dimensions available for GetReservationCoverage.
* DynamoDBv2 (3.3.17.0)
	* Amazon DynamoDB now integrates with AWS Backup, a centralized backup service that makes it easy for customers to configure and audit the AWS resources they want to backup, automate backup scheduling, set retention policies, and monitor all recent backup and restore activity. AWS Backup provides a fully managed, policy-based backup solution, simplifying your backup management, and helping you meet your business and regulatory backup compliance requirements. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.441.0 (2019-01-14 23:08 UTC)
* MediaConvert (3.3.11.0)
	* IMF decode from a Composition Playlist for IMF specializations App #2 and App #2e; up to 99 input clippings; caption channel selection for MXF; and updated rate control for CBR jobs. Added support for acceleration in preview
* StorageGateway (3.3.13.0)
	* JoinDomain API supports two more  parameters: organizational unit(OU) and domain controllers.  Two new APIs are introduced: DetachVolume and AttachVolume.

### 3.3.440.0 (2019-01-11 19:21 UTC)
* ElasticMapReduce (3.3.6.33)
	* Documentation updates for Amazon EMR
* RDSDataService (3.3.1.0)
	* Documentation updates for RDS Data API.

### 3.3.439.0 (2019-01-10 22:50 UTC)
* CodeDeploy (3.3.12.11)
	* Documentation updates for codedeploy
* EC2 (3.3.79.0)
	* EC2 Spot: a) CreateFleet support for Single AvailabilityZone requests and b) support for paginated DescribeSpotInstanceRequests.
* IoT (3.3.23.0)
	* This release adds tagging support for rules of AWS IoT Rules Engine. Tags enable you to categorize your rules in different ways, for example, by purpose, owner, or environment. For more information about tagging, see AWS Tagging Strategies (https://aws.amazon.com/answers/account-management/aws-tagging-strategies/). For technical documentation, look for the tagging operations in the AWS IoT Core API reference or User Guide (https://docs.aws.amazon.com/iot/latest/developerguide/tagging-iot.html).
* SageMaker (3.3.19.0)
	* SageMaker Training Jobs now support Inter-Container traffic encryption.
* Core 3.3.31.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.438.0 (2019-01-09 22:23 UTC)
* DocDB (3.3.0.0)
	* Amazon DocumentDB (with MongoDB compatibility) is a fast, reliable, and fully-managed database service. Amazon DocumentDB makes it easy for developers to set up, run, and scale MongoDB-compatible databases in the cloud.
* Redshift (3.3.12.0)
	* DescribeSnapshotSchedules returns a list of snapshot schedules. With this release, this API will have a list of clusters and number of clusters associated with the schedule.
* Core 3.3.31.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.437.0 (2019-01-08 02:56 UTC)
* S3 (3.3.31.8)
	* Added missing header for S3 CopyPart request.
Updated event notification object to include the sequencer and glacier event data.
* Core 3.3.31.0
	* Code for future SDK instrumentation and telemetry.
Add support for us-gov-east-1 region.
Fix for endpoint discovery handler async exception handling logic that could cause a .NET 3.5 async call to hang.
	* All services packages updated to require new Core

### 3.3.436.1 (2019-01-07 22:00 UTC)
* AppMesh (3.3.0.8)
	* AWS App Mesh now supports active health checks. You can specify TCP or HTTP health checks with custom thresholds and intervals on your VirtualNode definitions. See the AWS App Mesh HealthCheckPolicy documentation for more information.
* Core 3.3.30.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.436.0 (2019-01-04 23:00 UTC)
* DeviceFarm (3.3.12.0)
	* "This release provides support for running Appium Node.js and Appium Ruby tests on AWS Device Farm.
* ECS (3.3.21.8)
	* Documentation updates for Amazon ECS tagging feature.

### 3.3.435.0 (2019-01-03 22:55 UTC)
* IoTAnalytics (3.3.7.0)
	* ListDatasetContents now has a filter to limit results by date scheduled.
* Core 3.3.30.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.434.1 (2019-01-03 03:19 UTC)
* OpsWorksCM (3.3.6.25)
	* Documentation updates for opsworkscm

