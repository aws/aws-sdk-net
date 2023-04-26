### 3.7.452.0 (2022-12-30 19:19 UTC)
* CloudFront (3.7.103.0)
	* Extend response headers policy to support removing headers from viewer responses
* IoTFleetWise (3.7.102.7)
	* Update documentation - correct the epoch constant value of default value for expiryTime field in CreateCampaign request.
* Core 3.7.103.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.451.0 (2022-12-29 19:21 UTC)
* APIGateway (3.7.100.45)
	* Documentation updates for Amazon API Gateway
* ConnectWisdomService (3.7.101.0)
	* This release extends Wisdom CreateContent and StartContentUpload APIs to support PDF and MicrosoftWord docx document uploading.
* ElasticMapReduce (3.7.101.0)
	* Added GetClusterSessionCredentials API to allow Amazon SageMaker Studio to connect to EMR on EC2 clusters with runtime roles and AWS Lake Formation-based access control for Apache Spark, Apache Hive, and Presto queries.
* SecretsManager (3.7.101.0)
	* Added owning service filter, include planned deletion flag, and next rotation date response parameter in ListSecrets.
* Core 3.7.103.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.450.0 (2022-12-28 19:20 UTC)
* ElastiCache (3.7.103.0)
	* This release allows you to modify the encryption in transit setting, for existing Redis clusters. You can now change the TLS configuration of your Redis clusters without the need to re-build or re-provision the clusters or impact application availability.
* NetworkFirewall (3.7.101.0)
	* AWS Network Firewall now provides status messages for firewalls to help you troubleshoot when your endpoint fails.
* RDS (3.7.112.0)
	* This release adds support for Custom Engine Version (CEV) on RDS Custom SQL Server.
* Route53RecoveryControlConfig (3.7.101.0)
	* Added support for Python paginators in the route53-recovery-control-config List* APIs.

### 3.7.449.0 (2022-12-27 19:20 UTC)
* MemoryDB (3.7.102.0)
	* This release adds support for MemoryDB Reserved nodes which provides a significant discount compared to on-demand node pricing. Reserved nodes are not physical nodes, but rather a billing discount applied to the use of on-demand nodes in your account.
* Transfer (3.7.104.0)
	* Add additional operations to throw ThrottlingExceptions

### 3.7.448.0 (2022-12-23 19:26 UTC)
* Connect (3.7.110.0)
	* Support for Routing Profile filter, SortCriteria, and grouping by Routing Profiles for GetCurrentMetricData API. Support for RoutingProfiles, UserHierarchyGroups, and Agents as filters, NextStatus and AgentStatusName for GetCurrentUserData. Adds ApproximateTotalCount to both APIs.
* ConnectParticipant (3.7.102.0)
	* Amazon Connect Chat introduces the Message Receipts feature. This feature allows agents and customers to receive message delivered and read receipts after they send a chat message.
* Detective (3.7.101.0)
	* This release adds a missed AccessDeniedException type to several endpoints.
* FSx (3.7.102.0)
	* Fix a bug where a recent release might break certain existing SDKs.
* Inspector2 (3.7.102.0)
	* Amazon Inspector adds support for scanning NodeJS 18.x and Go 1.x AWS Lambda function runtimes.
* Core 3.7.103.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.447.0 (2022-12-22 19:24 UTC)
* ComputeOptimizer (3.7.102.0)
	* This release enables AWS Compute Optimizer to analyze and generate optimization recommendations for ecs services running on Fargate.
* Connect (3.7.109.0)
	* Amazon Connect Chat introduces the Idle Participant/Autodisconnect feature, which allows users to set timeouts relating to the activity of chat participants, using the new UpdateParticipantRoleConfig API.
* IoTDeviceAdvisor (3.7.101.0)
	* This release adds the following new features: 1) Documentation updates for IoT Device Advisor APIs. 2) Updated required request parameters for IoT Device Advisor APIs. 3) Added new service feature: ability to provide the test endpoint when customer executing the StartSuiteRun API.
* KinesisVideoWebRTCStorage (3.7.101.0)
	* Amazon Kinesis Video Streams offers capabilities to stream video and audio in real-time via WebRTC to the cloud for storage, playback, and analytical processing. Customers can use our enhanced WebRTC SDK and cloud APIs to enable real-time streaming, as well as media ingestion to the cloud.
* RDS (3.7.111.0)
	* Add support for managing master user password in AWS Secrets Manager for the DBInstance and DBCluster.
* SecretsManager (3.7.100.43)
	* Documentation updates for Secrets Manager
* Core 3.7.103.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.446.0 (2022-12-21 20:19 UTC)
* AWSSupport (3.7.100.42)
	* Documentation updates for the AWS Support API
* Connect (3.7.108.0)
	* Amazon Connect Chat now allows for JSON (application/json) message types to be sent as part of the initial message in the StartChatContact API.
* ConnectParticipant (3.7.101.0)
	* Amazon Connect Chat now allows for JSON (application/json) message types to be sent in the SendMessage API.
* LicenseManagerLinuxSubscriptions (3.7.100.0)
	* AWS License Manager now offers cross-region, cross-account tracking of commercial Linux subscriptions on AWS. This includes subscriptions purchased as part of EC2 subscription-included AMIs, on the AWS Marketplace, or brought to AWS via Red Hat Cloud Access Program.
* Macie2 (3.7.102.0)
	* This release adds support for analyzing Amazon S3 objects that use the S3 Glacier Instant Retrieval (Glacier_IR) storage class.
* SageMaker (3.7.113.0)
	* This release enables adding RStudio Workbench support to an existing Amazon SageMaker Studio domain. It allows setting your RStudio on SageMaker environment configuration parameters and also updating the RStudioConnectUrl and RStudioPackageManagerUrl parameters for existing domains
* Scheduler (3.7.101.0)
	* Updated the ListSchedules and ListScheduleGroups APIs to allow the NamePrefix field to start with a number. Updated the validation for executionRole field to support any role name.
* SimpleSystemsManagement (3.7.102.23)
	* Doc-only updates for December 2022.
* Transfer (3.7.103.0)
	* This release adds support for Decrypt as a workflow step type.
* Core 3.7.103.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.445.0 (2022-12-20 19:30 UTC)
* Batch (3.7.102.0)
	* Adds isCancelled and isTerminated to DescribeJobs response.
* EC2 (3.7.114.0)
	* Adds support for pagination in the EC2 DescribeImages API.
* LookoutEquipment (3.7.101.0)
	* This release adds support for listing inference schedulers by status.
* MediaLive (3.7.103.0)
	* This release adds support for two new features to AWS Elemental MediaLive. First, you can now burn-in timecodes to your MediaLive outputs. Second, we now now support the ability to decode Dolby E audio when it comes in on an input.
* NimbleStudio (3.7.101.0)
	* Amazon Nimble Studio now supports configuring session storage volumes and persistence, as well as backup and restore sessions through launch profiles.
* ResourceExplorer2 (3.7.101.0)
	* Documentation updates for AWS Resource Explorer.
* Route53Domains (3.7.101.0)
	* Use Route 53 domain APIs to change owner, create/delete DS record, modify IPS tag, resend authorization. New: AssociateDelegationSignerToDomain, DisassociateDelegationSignerFromDomain, PushDomain, ResendOperationAuthorization. Updated: UpdateDomainContact, ListOperations, CheckDomainTransferability.
* SageMaker (3.7.112.0)
	* Amazon SageMaker Autopilot adds support for new objective metrics in CreateAutoMLJob API.
* TranscribeService (3.7.103.0)
	* Enable our batch transcription jobs for Swedish and Vietnamese.
* Core 3.7.103.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.444.0 (2022-12-19 19:26 UTC)
* Athena (3.7.103.0)
	* Add missed InvalidRequestException in GetCalculationExecutionCode,StopCalculationExecution APIs. Correct required parameters (Payload and Type) in UpdateNotebook API. Change Notebook size from 15 Mb to 10 Mb.
* ECS (3.7.104.0)
	* This release adds support for alarm-based rollbacks in ECS, a new feature that allows customers to add automated safeguards for Amazon ECS service rolling updates.
* KinesisVideo (3.7.102.0)
	* Amazon Kinesis Video Streams offers capabilities to stream video and audio in real-time via WebRTC to the cloud for storage, playback, and analytical processing. Customers can use our enhanced WebRTC SDK and cloud APIs to enable real-time streaming, as well as media ingestion to the cloud.
* KinesisVideoWebRTCStorage (3.7.100.0)
	* Amazon Kinesis Video Streams offers capabilities to stream video and audio in real-time via WebRTC to the cloud for storage, playback, and analytical processing. Customers can use our enhanced WebRTC SDK and cloud APIs to enable real-time streaming, as well as media ingestion to the cloud.
* RDS (3.7.110.0)
	* Add support for --enable-customer-owned-ip to RDS create-db-instance-read-replica API for RDS on Outposts.
* SageMaker (3.7.111.0)
	* AWS Sagemaker - Sagemaker Images now supports Aliases as secondary identifiers for ImageVersions. SageMaker Images now supports additional metadata for ImageVersions for better images management.
* Core 3.7.103.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.443.0 (2022-12-16 19:25 UTC)
* Appflow (3.7.104.0)
	* This release updates the ListConnectorEntities API action so that it returns paginated responses that customers can retrieve with next tokens.
* CloudFront (3.7.102.8)
	* Updated documentation for CloudFront
* DataSync (3.7.102.0)
	* AWS DataSync now supports the use of tags with task executions. With this new feature, you can apply tags each time you execute a task, giving you greater control and management over your task executions.
* ElasticFileSystem (3.7.101.16)
	* General documentation updates for EFS.
* GuardDuty (3.7.100.39)
	* This release provides the valid characters for the Description and Name field.
* IoTFleetWise (3.7.102.0)
	* Updated error handling for empty resource names in "UpdateSignalCatalog" and "GetModelManifest" operations.
* SageMaker (3.7.110.0)
	* AWS sagemaker - Features: This release adds support for random seed, it's an integer value used to initialize a pseudo-random number generator. Setting a random seed will allow the hyperparameter tuning search strategies to produce more consistent configurations for the same tuning job.
* Core 3.7.103.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.442.0 (2022-12-16 00:44 UTC)
* Core 3.7.103.0
	* Bug fix: fix access denied exception when reading read-only cached SSO token files located in .aws directory; Feat: Add support for AWS_SHARED_CREDENTIALS_FILE environment variable.
	* All services packages updated to require new Core

### 3.7.441.0 (2022-12-15 19:32 UTC)
* BackupGateway (3.7.101.0)
	* This release adds support for VMware vSphere tags, enabling customer to protect VMware virtual machines using tag-based policies for AWS tags mapped from vSphere tags. This release also adds support for customer-accessible gateway-hypervisor interaction log and upload bandwidth rate limit schedule.
* Connect (3.7.107.0)
	* Added support for "English - New Zealand" and "English - South African" to be used with Amazon Connect Custom Vocabulary APIs.
* ECS (3.7.103.0)
	* This release adds support for container port ranges in ECS, a new capability that allows customers to provide container port ranges to simplify use cases where multiple ports are in use in a container. This release updates TaskDefinition mutation APIs and the Task description APIs.
* EKS (3.7.104.0)
	* Add support for Windows managed nodes groups.
* Glue (3.7.105.0)
	* This release adds support for AWS Glue Crawler with native DeltaLake tables, allowing Crawlers to classify Delta Lake format tables and catalog them for query engines to query against.
* Kinesis (3.7.101.0)
	* Added StreamARN parameter for Kinesis Data Streams APIs. Added a new opaque pagination token for ListStreams. SDKs will auto-generate Account Endpoint when accessing Kinesis Data Streams.
* LocationService (3.7.100.37)
	* This release adds support for a new style, "VectorOpenDataStandardLight" which can be used with the new data source, "Open Data Maps (Preview)".
* MainframeModernization (3.7.101.0)
	* Adds an optional create-only `KmsKeyId` property to Environment and Application resources.
* SageMaker (3.7.109.0)
	* SageMaker Inference Recommender now allows customers to load tests their models on various instance types using private VPC.
* SecurityHub (3.7.103.0)
	* Added new resource details objects to ASFF, including resources for AwsEc2LaunchTemplate, AwsSageMakerNotebookInstance, AwsWafv2WebAcl and AwsWafv2RuleGroup.
* Translate (3.7.101.0)
	* Raised the input byte size limit of the Text field in the TranslateText API to 10000 bytes.
* Core 3.7.102.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.440.0 (2022-12-14 19:29 UTC)
* CloudWatch (3.7.102.0)
	* Adding support for Metrics Insights Alarms
* CostExplorer (3.7.103.0)
	* This release supports percentage-based thresholds on Cost Anomaly Detection alert subscriptions.
* NetworkManager (3.7.101.0)
	* Appliance Mode support for AWS Cloud WAN.
* RedshiftDataAPIService (3.7.101.0)
	* This release adds a new --client-token field to ExecuteStatement and BatchExecuteStatement operations. Customers can now run queries with the additional client token parameter to ensures idempotency.
* SageMakerMetrics (3.7.100.2)
	* Update SageMaker Metrics documentation.
* Core 3.7.102.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.439.0 (2022-12-13 19:28 UTC)
* CloudTrail (3.7.102.0)
	* Merging mainline branch for service model into mainline release branch. There are no new APIs.
* RDS (3.7.109.0)
	* This deployment adds ClientPasswordAuthType field to the Auth structure of the DBProxy.
* Core 3.7.102.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.438.0 (2022-12-12 19:30 UTC)
* CustomerProfiles (3.7.102.0)
	* This release allows custom strings in PartyType and Gender through 2 new attributes in the CreateProfile and UpdateProfile APIs: PartyTypeString and GenderString.
* EC2 (3.7.113.0)
	* This release updates DescribeFpgaImages to show supported instance types of AFIs in its response.
* KinesisVideo (3.7.101.0)
	* This release adds support for public preview of Kinesis Video Stream at Edge enabling customers to provide configuration for the Kinesis Video Stream EdgeAgent running on an on-premise IoT device. Customers can now locally record from cameras and stream videos to the cloud on configured schedule.
* LookoutforVision (3.7.100.34)
	* This documentation update adds kms:GenerateDataKey as a required permission to StartModelPackagingJob.
* MigrationHubRefactorSpaces (3.7.101.0)
	* This release adds support for Lambda alias service endpoints. Lambda alias ARNs can now be passed into CreateService.
* RDS (3.7.108.0)
	* Update the RDS API model to support copying option groups during the CopyDBSnapshot operation
* Rekognition (3.7.102.0)
	* Adds support for "aliases" and "categories", inclusion and exclusion filters for labels and label categories, and aggregating labels by video segment timestamps for Stored Video Label Detection APIs.
* SageMakerMetrics (3.7.100.0)
	* This release introduces support SageMaker Metrics APIs.
* WAFV2 (3.7.101.30)
	* Documents the naming requirement for logging destinations that you use with web ACLs.
* Core 3.7.102.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.437.0 (2022-12-09 19:21 UTC)
* CloudWatchLogs (3.7.102.11)
	* Doc-only update for CloudWatch Logs, for Tagging Permissions clarifications
* IoTFleetWise (3.7.101.0)
	* Deprecated assignedValue property for actuators and attributes.  Added a message to invalid nodes and invalid decoder manifest exceptions.
* MediaLive (3.7.102.0)
	* Link devices now support buffer size (latency) configuration. A higher latency value means a longer delay in transmitting from the device to MediaLive, but improved resiliency. A lower latency value means a shorter delay, but less resiliency.
* MediaPackageVod (3.7.102.0)
	* This release provides the approximate number of assets in a packaging group.

### 3.7.436.0 (2022-12-08 19:21 UTC)
* AutoScaling (3.7.102.0)
	* Adds support for metric math for target tracking scaling policies, saving you the cost and effort of publishing a custom metric to CloudWatch. Also adds support for VPC Lattice by adding the Attach/Detach/DescribeTrafficSources APIs and a new health check type to the CreateAutoScalingGroup API.
* IoTTwinMaker (3.7.102.0)
	* This release adds the following new features: 1) New APIs for managing a continuous sync of assets and asset models from AWS IoT SiteWise. 2) Support user friendly names for component types (ComponentTypeName) and properties (DisplayName).
* MigrationHubStrategyRecommendations (3.7.101.0)
	* This release adds known application filtering, server selection for assessments, support for potential recommendations, and indications for configuration and assessment status. For more information, see the AWS Migration Hub documentation at https://docs.aws.amazon.com/migrationhub/index.html
* Core 3.7.102.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.435.0 (2022-12-08 00:46 UTC)
* GameLift (3.7.102.0)
	* Add service customization to generate IsSet property for GameLift (PlayerLatencyPolicies and Destinations).
* Core 3.7.102.0
	* Fixed issue with infinite recursion when using the same profile name and sso-session name in the credentials file; Improved support for bearer tokens in net45, netstandard targets.
	* All services packages updated to require new Core

### 3.7.434.0 (2022-12-07 19:48 UTC)
* CloudFront (3.7.102.0)
	* Introducing UpdateDistributionWithStagingConfig that can be used to promote the staging configuration to the production.
* CostExplorer (3.7.102.0)
	* This release adds the LinkedAccountName field to the GetAnomalies API response under RootCause
* EKS (3.7.103.0)
	* Adds support for EKS add-ons configurationValues fields and DescribeAddonConfiguration function
* KeyManagementService (3.7.101.6)
	* Updated examples and exceptions for External Key Store (XKS).
* Core 3.7.101.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.433.0 (2022-12-06 20:39 UTC)
* BillingConductor (3.7.103.0)
	* This release adds the Tiering Pricing Rule feature.
* Connect (3.7.106.0)
	* This release provides APIs that enable you to programmatically manage rules for Contact Lens conversational analytics and third party applications. For more information, see   https://docs.aws.amazon.com/connect/latest/APIReference/rules-api.html
* DynamoDBv2 (3.7.101.0)
	* Endpoint Ruleset update: Use http instead of https for the "local" region.
* RDS (3.7.107.0)
	* This release adds the BlueGreenDeploymentNotFoundFault to the AddTagsToResource, ListTagsForResource, and RemoveTagsFromResource operations.
* SageMakerFeatureStoreRuntime (3.7.101.0)
	* For online + offline Feature Groups, added ability to target PutRecord and DeleteRecord actions to only online store, or only offline store. If target store parameter is not specified, actions will apply to both stores.
* Core 3.7.101.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.432.0 (2022-12-05 19:24 UTC)
* CostExplorer (3.7.101.0)
	* This release introduces two new APIs that offer a 1-click experience to refresh Savings Plans recommendations. The two APIs are StartSavingsPlansPurchaseRecommendationGeneration and ListSavingsPlansPurchaseRecommendationGeneration.
* EC2 (3.7.112.0)
	* Documentation updates for EC2.
* Ivschat (3.7.102.0)
	* Adds PendingVerification error type to messaging APIs to block the resource usage for accounts identified as being fraudulent.
* RDS (3.7.106.0)
	* This release adds the InvalidDBInstanceStateFault to the RestoreDBClusterFromSnapshot operation.
* TranscribeService (3.7.102.0)
	* Amazon Transcribe now supports creating custom language models in the following languages: Japanese (ja-JP) and German (de-DE).
* Core 3.7.101.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.431.0 (2022-12-02 19:25 UTC)
* AppSync (3.7.102.0)
	* Fixes the URI for the evaluatecode endpoint to include the /v1 prefix (ie. "/v1/dataplane-evaluatecode").
* ECS (3.7.102.6)
	* Documentation updates for Amazon ECS
* FMS (3.7.103.0)
	* AWS Firewall Manager now supports Fortigate Cloud Native Firewall as a Service as a third-party policy type.
* MediaConvert (3.7.102.0)
	* The AWS Elemental MediaConvert SDK has added support for configurable ID3 eMSG box attributes and the ability to signal them with InbandEventStream tags in DASH and CMAF outputs.
* MediaLive (3.7.101.0)
	* Updates to Event Signaling and Management (ESAM) API and documentation.
* Polly (3.7.103.0)
	* Add language code for Finnish (fi-FI)
* Proton (3.7.103.0)
	* CreateEnvironmentAccountConnection RoleArn input is now optional
* RedshiftServerless (3.7.101.0)
	* Add Table Level Restore operations for Amazon Redshift Serverless. Add multi-port support for Amazon Redshift Serverless endpoints. Add Tagging support to Snapshots and Recovery Points in Amazon Redshift Serverless.
* SimpleNotificationService (3.7.100.29)
	* This release adds the message payload-filtering feature to the SNS Subscribe, SetSubscriptionAttributes, and GetSubscriptionAttributes API actions

### 3.7.430.0 (2022-12-02 14:36 UTC)
* CodeDeploy (3.7.100.28)
	* Added service customization to generate public IsAutoScalingGroupsSet property for CodeDeploy UpdateDeploymentGroupRequest.
* Core 3.7.101.0
	* Add aws-query-compatible trait support to parse and return query compatible error codes from response header for services migrating from Query to AWSJSON; Updated Arn.IsArn to use Ordinal string comparison
	* All services packages updated to require new Core

### 3.7.429.0 (2022-12-01 19:22 UTC)
* CodeCatalyst (3.7.100.0)
	* This release adds operations that support customers using the AWS Toolkits and Amazon CodeCatalyst, a unified software development service that helps developers develop, deploy, and maintain applications in the cloud. For more information, see the documentation.
* Comprehend (3.7.101.0)
	* Comprehend now supports semi-structured documents (such as PDF files or image files) as inputs for custom analysis using the synchronous APIs (ClassifyDocument and DetectEntities).
* GameLift (3.7.101.0)
	* GameLift introduces a new feature, GameLift Anywhere. GameLift Anywhere allows you to integrate your own compute resources with GameLift. You can also use GameLift Anywhere to iteratively test your game servers without uploading the build to GameLift for every iteration.
* Pipes (3.7.100.0)
	* AWS introduces new Amazon EventBridge Pipes which allow you to connect sources (SQS, Kinesis, DDB, Kafka, MQ) to Targets (14+ EventBridge Targets) without any code, with filtering, batching, input transformation, and an optional Enrichment stage (Lambda, StepFunctions, ApiGateway, ApiDestinations)
* StepFunctions (3.7.102.0)
	* This release adds support for the AWS Step Functions Map state in Distributed mode. The changes include a new MapRun resource and several new and modified APIs.
* Core 3.7.100.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.428.0 (2022-11-30 19:26 UTC)
* AccessAnalyzer (3.7.102.0)
	* This release adds support for S3 cross account access points. IAM Access Analyzer will now produce public or cross account findings when it detects bucket delegation to external account access points.
* Athena (3.7.102.0)
	* This release includes support for using Apache Spark in Amazon Athena.
* DataExchange (3.7.101.0)
	* This release enables data providers to license direct access to data in their Amazon S3 buckets or AWS Lake Formation data lakes through AWS Data Exchange. Subscribers get read-only access to the data and can use it in downstream AWS services, like Amazon Athena, without creating or managing copies.
* DocDBElastic (3.7.100.0)
	* Launched Amazon DocumentDB Elastic Clusters. You can now use the SDK to create, list, update and delete Amazon DocumentDB Elastic Cluster resources
* Glue (3.7.104.0)
	* This release adds support for AWS Glue Data Quality, which helps you evaluate and monitor the quality of your data and includes the API for creating, deleting, or updating data quality rulesets, runs and evaluations.
* S3Control (3.7.104.0)
	* Amazon S3 now supports cross-account access points. S3 bucket owners can now allow trusted AWS accounts to create access points associated with their bucket.
* SageMaker (3.7.108.0)
	* Added Models as part of the Search API. Added Model shadow deployments in realtime inference, and shadow testing in managed inference. Added support for shared spaces, geospatial APIs, Model Cards, AutoMLJobStep in pipelines, Git repositories on user profiles and domains, Model sharing in Jumpstart.
* SageMakerGeospatial (3.7.100.0)
	* This release provides Amazon SageMaker geospatial APIs to build, train, deploy and visualize geospatial models.
* Core 3.7.100.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.427.0 (2022-11-29 19:23 UTC)
* EC2 (3.7.111.0)
	* This release adds support for AWS Verified Access and the Hpc6id Amazon EC2 compute optimized instance type, which features 3rd generation Intel Xeon Scalable processors.
* KeyManagementService (3.7.101.0)
	* AWS KMS introduces the External Key Store (XKS), a new feature for customers who want to protect their data with encryption keys stored in an external key management system under their control.
* KinesisFirehose (3.7.101.0)
	* Allow support for the Serverless offering for Amazon OpenSearch Service as a Kinesis Data Firehose delivery destination.
* Omics (3.7.100.0)
	* Amazon Omics is a new, purpose-built service that can be used by healthcare and life science organizations to store, query, and analyze omics data. The insights from that data can be used to accelerate scientific discoveries and improve healthcare.
* OpenSearchServerless (3.7.100.0)
	* Publish SDK for Amazon OpenSearch Serverless
* SecurityLake (3.7.100.0)
	* Amazon Security Lake automatically centralizes security data from cloud, on-premises, and custom sources into a purpose-built data lake stored in your account. Security Lake makes it easier to analyze security data, so you can improve the protection of your workloads, applications, and data
* SimSpaceWeaver (3.7.100.0)
	* AWS SimSpace Weaver is a new service that helps customers build spatial simulations at new levels of scale - resulting in virtual worlds with millions of dynamic entities. See the AWS SimSpace Weaver developer guide for more details on how to get started. https://docs.aws.amazon.com/simspaceweaver
* Core 3.7.100.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.426.0 (2022-11-29 06:03 UTC)
* ARCZonalShift (3.7.100.0)
	* Amazon Route 53 Application Recovery Controller Zonal Shift is a new service that makes it easy to shift traffic away from an Availability Zone in a Region. See the developer guide for more information: https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route53-recovery.html
* ComputeOptimizer (3.7.101.0)
	* Adds support for a new recommendation preference that makes it possible for customers to optimize their EC2 recommendations by utilizing an external metrics ingestion service to provide metrics.
* ConfigService (3.7.101.0)
	* With this release, you can use AWS Config to evaluate your resources for compliance with Config rules before they are created or updated. Using Config rules in proactive mode enables you to test and build compliant resource templates or check resource configurations at the time they are provisioned.
* EC2 (3.7.110.0)
	* Introduces ENA Express, which uses AWS SRD and dynamic routing to increase throughput and minimize latency, adds support for trust relationships between Reachability Analyzer and AWS Organizations to enable cross-account analysis, and adds support for Infrastructure Performance metric subscriptions.
* EKS (3.7.102.0)
	* Adds support for additional EKS add-ons metadata and filtering fields
* FSx (3.7.101.0)
	* This release adds support for 4GB/s / 160K PIOPS FSx for ONTAP file systems and 10GB/s / 350K PIOPS FSx for OpenZFS file systems (Single_AZ_2). For FSx for ONTAP, this also adds support for DP volumes, snapshot policy, copy tags to backups, and Multi-AZ route table updates.
* Glue (3.7.103.0)
	* This release allows the creation of Custom Visual Transforms (Dynamic Transforms) to be created via AWS Glue CLI/SDK.
* Inspector2 (3.7.101.0)
	* This release adds support for Inspector to scan AWS Lambda.
* Lambda (3.7.102.0)
	* Adds support for Lambda SnapStart, which helps improve the startup performance of functions. Customers can now manage SnapStart based functions via CreateFunction and UpdateFunctionConfiguration APIs
* LicenseManagerUserSubscriptions (3.7.101.0)
	* AWS now offers fully-compliant, Amazon-provided licenses for Microsoft Office Professional Plus 2021 Amazon Machine Images (AMIs) on Amazon EC2. These AMIs are now available on the Amazon EC2 console and on AWS Marketplace to launch instances on-demand without any long-term licensing commitments.
* Macie2 (3.7.101.0)
	* Added support for configuring Macie to continually sample objects from S3 buckets and inspect them for sensitive data. Results appear in statistics, findings, and other data that Macie provides.
* QuickSight (3.7.102.0)
	* This release adds new Describe APIs and updates Create and Update APIs to support the data model for Dashboards, Analyses, and Templates.
* S3Control (3.7.103.0)
	* Added two new APIs to support Amazon S3 Multi-Region Access Point failover controls: GetMultiRegionAccessPointRoutes and SubmitMultiRegionAccessPointRoutes. The failover control APIs are supported in the following Regions: us-east-1, us-west-2, eu-west-1, ap-southeast-2, and ap-northeast-1.
* SecurityHub (3.7.102.0)
	* Adding StandardsManagedBy field to DescribeStandards API response
* Core 3.7.100.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.425.0 (2022-11-28 03:22 UTC)
* Backup (3.7.101.0)
	* AWS Backup introduces support for legal hold and application stack backups. AWS Backup Audit Manager introduces support for cross-Region, cross-account reports.
* CloudWatch (3.7.101.0)
	* Adds cross-account support to the GetMetricData API. Adds cross-account support to the ListMetrics API through the usage of the IncludeLinkedAccounts flag and the new OwningAccounts field.
* CloudWatchLogs (3.7.102.0)
	* Updates to support CloudWatch Logs data protection and CloudWatch cross-account observability
* Drs (3.7.101.0)
	* Non breaking changes to existing APIs, and additional APIs added to support in-AWS failing back using AWS Elastic Disaster Recovery.
* ECS (3.7.102.0)
	* This release adds support for ECS Service Connect, a new capability that simplifies writing and operating resilient distributed applications. This release updates the TaskDefinition, Cluster, Service mutation APIs with Service connect constructs and also adds a new ListServicesByNamespace API.
* ElasticFileSystem (3.7.101.0)
	* This release adds elastic as a new ThroughputMode value for EFS file systems and adds AFTER_1_DAY as a value for TransitionToIARules.
* IoT (3.7.103.0)
	* Job scheduling enables the scheduled rollout of a Job with start and end times and a customizable end behavior when end time is reached. This is available for continuous and snapshot jobs. Added support for MQTT5 properties to AWS IoT TopicRule Republish Action.
* IotData (3.7.101.0)
	* This release adds support for MQTT5 properties to AWS IoT HTTP Publish API.
* IoTWireless (3.7.101.0)
	* This release includes a new feature for customers to calculate the position of their devices by adding three new APIs: UpdateResourcePosition, GetResourcePosition, and GetPositionEstimate.
* Kendra (3.7.101.0)
	* Amazon Kendra now supports preview of table information from HTML tables in the search results. The most relevant cells with their corresponding rows, columns are displayed as a preview in the search result. The most relevant table cell or cells are also highlighted in table preview.
* Mgn (3.7.101.0)
	* This release adds support for Application and Wave management. We also now support custom post-launch actions.
* OAM (3.7.100.0)
	* Amazon CloudWatch Observability Access Manager is a new service that allows configuration of the CloudWatch cross-account observability feature.
* Organizations (3.7.101.0)
	* This release introduces delegated administrator for AWS Organizations, a new feature to help you delegate the management of your Organizations policies, enabling you to govern your AWS organization in a decentralized way. You can now allow member accounts to manage Organizations policies.
* RDS (3.7.105.0)
	* This release enables new Aurora and RDS feature called Blue/Green Deployments that makes updates to databases safer, simpler and faster.
* Textract (3.7.104.0)
	* This release adds support for classifying and splitting lending documents by type, and extracting information by using the Analyze Lending APIs. This release also includes support for summarized information of the processed lending document package, in addition to per document results.
* TranscribeService (3.7.101.0)
	* This release adds support for 'inputType' for post-call and real-time (streaming) Call Analytics within Amazon Transcribe.
* Core 3.7.100.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.424.0 (2022-11-23 19:31 UTC)
* ManagedGrafana (3.7.101.0)
	* This release includes support for configuring a Grafana workspace to connect to a datasource within a VPC as well as new APIs for configuring Grafana settings.
* RecycleBin (3.7.101.0)
	* This release adds support for Rule Lock for Recycle Bin, which allows you to lock retention rules so that they can no longer be modified or deleted.

### 3.7.423.0 (2022-11-22 19:24 UTC)
* Appflow (3.7.103.0)
	* Adding support for Amazon AppFlow to transfer the data to Amazon Redshift databases through Amazon Redshift Data API service. This feature will support the Redshift destination connector on both public and private accessible Amazon Redshift Clusters and Amazon Redshift Serverless.
* KinesisAnalyticsV2 (3.7.101.0)
	* Support for Apache Flink 1.15 in Kinesis Data Analytics.
* Core 3.7.100.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.422.0 (2022-11-21 23:23 UTC)
* Route53 (3.7.103.0)
	* Amazon Route 53 now supports the Asia Pacific (Hyderabad) Region (ap-south-2) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.

### 3.7.421.0 (2022-11-18 20:43 UTC)
* Appflow (3.7.102.0)
	* AppFlow provides a new API called UpdateConnectorRegistration to update a custom connector that customers have previously registered. With this API, customers no longer need to unregister and then register a connector to make an update.
* AuditManager (3.7.101.0)
	* This release introduces a new feature for Audit Manager: Evidence finder. You can now use evidence finder to quickly query your evidence, and add the matching evidence results to an assessment report.
* ChimeSDKVoice (3.7.100.0)
	* Amazon Chime Voice Connector, Voice Connector Group and PSTN Audio Service APIs are now available in the Amazon Chime SDK Voice namespace. See https://docs.aws.amazon.com/chime-sdk/latest/dg/sdk-available-regions.html for more details.
* CloudFront (3.7.101.0)
	* CloudFront API support for staging distributions and associated traffic management policies.
* Connect (3.7.105.0)
	* Added AllowedAccessControlTags and TagRestrictedResource for Tag Based Access Control on Amazon Connect Webpage
* DynamoDBv2 (3.7.100.21)
	* Updated minor fixes for DynamoDB documentation.
* EC2 (3.7.109.0)
	* This release adds support for copying an Amazon Machine Image's tags when copying an AMI.
* Glue (3.7.102.0)
	* AWSGlue Crawler - Adding support for Table and Column level Comments with database level datatypes for JDBC based crawler.
* IoTRoboRunner (3.7.100.0)
	* AWS IoT RoboRunner is a new service that makes it easy to build applications that help multi-vendor robots work together seamlessly. See the IoT RoboRunner developer guide for more details on getting started. https://docs.aws.amazon.com/iotroborunner/latest/dev/iotroborunner-welcome.html
* QuickSight (3.7.101.0)
	* This release adds the following: 1) Asset management for centralized assets governance 2) QuickSight Q now supports public embedding 3) New Termination protection flag to mitigate accidental deletes 4) Athena data sources now accept a custom IAM role 5) QuickSight supports connectivity to Databricks
* SageMaker (3.7.107.0)
	* Added DisableProfiler flag as a new field in ProfilerConfig
* ServiceCatalog (3.7.101.0)
	* This release 1. adds support for Principal Name Sharing with Service Catalog portfolio sharing. 2. Introduces repo sourced products which are created and managed with existing SC APIs. These products are synced to external repos and auto create new product versions based on changes in the repo.
* SsmSap (3.7.100.4)
	* AWS Systems Manager for SAP provides simplified operations and management of SAP applications such as SAP HANA. With this release, SAP customers and partners can automate and simplify their SAP system administration tasks such as backup/restore of SAP HANA.
* StepFunctions (3.7.101.0)
	* This release adds support for using Step Functions service integrations to invoke any cross-account AWS resource, even if that service doesn't support resource-based policies or cross-account calls. See https://docs.aws.amazon.com/step-functions/latest/dg/concepts-access-cross-acct-resources.html
* Transfer (3.7.102.0)
	* Adds a NONE encryption algorithm type to AS2 connectors, providing support for skipping encryption of the AS2 message body when a HTTPS URL is also specified.
* Core 3.7.100.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.420.0 (2022-11-17 19:36 UTC)
* Amplify (3.7.101.0)
	* Adds a new value (WEB_COMPUTE) to the Platform enum that allows customers to create Amplify Apps with Server-Side Rendering support.
* Appflow (3.7.101.0)
	* AppFlow simplifies the preparation and cataloging of SaaS data into the AWS Glue Data Catalog where your data can be discovered and accessed by AWS analytics and ML services. AppFlow now also supports data field partitioning and file size optimization to improve query performance and reduce cost.
* AppRegistry (3.7.101.0)
	* This release adds support for tagged resource associations, which allows you to associate a group of resources with a defined resource tag key and value to the application.
* AppSync (3.7.101.0)
	* This release introduces the APPSYNC_JS runtime, and adds support for JavaScript in AppSync functions and AppSync pipeline resolvers.
* CloudWatchRUM (3.7.101.0)
	* CloudWatch RUM now supports custom events. To use custom events, create an app monitor or update an app monitor with CustomEvent Status as ENABLED.
* DatabaseMigrationService (3.7.101.0)
	* Adds support for Internet Protocol Version 6 (IPv6) on DMS Replication Instances
* EC2 (3.7.108.0)
	* This release adds a new optional parameter "privateIpAddress" for the CreateNatGateway API. PrivateIPAddress will allow customers to select a custom Private IPv4 address instead of having it be auto-assigned.
* ElasticLoadBalancingV2 (3.7.100.20)
	* Provides new target group attributes to turn on/off cross zone load balancing and configure target group health for Network Load Balancers and Application Load Balancers. Provides improvements to health check configuration for Network Load Balancers.
* EMRServerless (3.7.101.0)
	* Adds support for AWS Graviton2 based applications. You can now select CPU architecture when creating new applications or updating existing ones.
* Ivschat (3.7.101.0)
	* Adds LoggingConfiguration APIs for IVS Chat - a feature that allows customers to store and record sent messages in a chat room to S3 buckets, CloudWatch logs, or Kinesis firehose.
* Lambda (3.7.101.0)
	* Add Node 18 (nodejs18.x) support to AWS Lambda.
* Personalize (3.7.101.0)
	* This release provides support for creation and use of metric attributions in AWS Personalize
* Polly (3.7.102.0)
	* Add two new neural voices - Ola (pl-PL) and Hala (ar-AE).
* S3Control (3.7.102.0)
	* Added 34 new S3 Storage Lens metrics to support additional customer use cases.
* SecretsManager (3.7.100.20)
	* Documentation updates for Secrets Manager.
* SecurityHub (3.7.101.0)
	* Added SourceLayerArn and SourceLayerHash field for security findings.  Updated AwsLambdaFunction Resource detail
* SecurityToken (3.7.100.20)
	* Documentation updates for AWS Security Token Service.
* Textract (3.7.103.0)
	* This release adds support for specifying and extracting information from documents using the Signatures feature within Analyze Document API
* WorkSpaces (3.7.104.0)
	* The release introduces CreateStandbyWorkspaces, an API that allows you to create standby WorkSpaces associated with a primary WorkSpace in another Region. DescribeWorkspaces now includes related WorkSpaces properties. DescribeWorkspaceBundles and CreateWorkspaceBundle now return more bundle details.
* Core 3.7.100.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.419.0 (2022-11-16 19:36 UTC)
* Batch (3.7.101.18)
	* Documentation updates related to Batch on EKS
* BillingConductor (3.7.102.0)
	* This release adds a new feature BillingEntity pricing rule.
* CloudFormation (3.7.102.0)
	* Added UnsupportedTarget HandlerErrorCode for use with CFN Resource Hooks
* ComprehendMedical (3.7.101.0)
	* This release supports new set of entities and traits. It also adds new category (BEHAVIORAL_ENVIRONMENTAL_SOCIAL).
* Connect (3.7.104.0)
	* This release adds a new MonitorContact API for initiating monitoring of ongoing Voice and Chat contacts.
* EKS (3.7.101.0)
	* Adds support for customer-provided placement groups for Kubernetes control plane instances when creating local EKS clusters on Outposts
* ElastiCache (3.7.102.0)
	* for Redis now supports AWS Identity and Access Management authentication access to Redis clusters starting with redis-engine version 7.0
* IoTTwinMaker (3.7.101.0)
	* This release adds the following: 1) ExecuteQuery API allows users to query their AWS IoT TwinMaker Knowledge Graph 2) Pricing plan APIs allow users to configure and manage their pricing mode 3) Support for property groups and tabular property values in existing AWS IoT TwinMaker APIs.
* PersonalizeEvents (3.7.101.0)
	* This release provides support for creation and use of metric attributions in AWS Personalize
* Proton (3.7.102.0)
	* Add support for sorting and filtering in ListServiceInstances
* RDS (3.7.104.0)
	* This release adds support for container databases (CDBs) to Amazon RDS Custom for Oracle. A CDB contains one PDB at creation. You can add more PDBs using Oracle SQL. You can also customize your database installation by setting the Oracle base, Oracle home, and the OS user name and group.
* SimpleSystemsManagement (3.7.102.0)
	* This release adds support for cross account access in CreateOpsItem, UpdateOpsItem and GetOpsItem. It introduces new APIs to setup resource policies for SSM resources: PutResourcePolicy, GetResourcePolicies and DeleteResourcePolicy.
* SSMIncidents (3.7.103.0)
	* Add support for PagerDuty integrations on ResponsePlan, IncidentRecord, and RelatedItem APIs
* Transfer (3.7.101.0)
	* Allow additional operations to throw ThrottlingException
* XRay (3.7.102.0)
	* This release adds new APIs - PutResourcePolicy, DeleteResourcePolicy, ListResourcePolicies for supporting resource based policies for AWS X-Ray.
* Core 3.7.100.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.418.1 (2022-11-16 14:30 UTC)
* Core 3.7.100.18
	* Restore pre-3.7.100 behavior by not allowing UseHttp to manipulate an explicit ServiceURL
	* All services packages updated to require new Core

### 3.7.418.0 (2022-11-15 19:25 UTC)
* Connect (3.7.103.0)
	* This release updates the APIs: UpdateInstanceAttribute, DescribeInstanceAttribute, and ListInstanceAttributes. You can use it to programmatically enable/disable enhanced contact monitoring using attribute type ENHANCED_CONTACT_MONITORING on the specified Amazon Connect instance.
* GreengrassV2 (3.7.101.0)
	* Adds new parent target ARN paramater to CreateDeployment, GetDeployment, and ListDeployments APIs for the new subdeployments feature.
* Route53 (3.7.102.0)
	* Amazon Route 53 now supports the Europe (Spain) Region (eu-south-2) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* WorkSpaces (3.7.103.0)
	* This release introduces ModifyCertificateBasedAuthProperties, a new API that allows control of certificate-based auth properties associated with a WorkSpaces directory. The DescribeWorkspaceDirectories API will now additionally return certificate-based auth properties in its responses.
* Core 3.7.100.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.417.0 (2022-11-14 19:25 UTC)
* CustomerProfiles (3.7.101.0)
	* This release enhances the SearchProfiles API by providing functionality to search for profiles using multiple keys and logical operators.
* LakeFormation (3.7.101.0)
	* This release adds a new parameter "Parameters" in the DataLakeSettings.
* ManagedBlockchain (3.7.100.17)
	* Updating the API docs data type: NetworkEthereumAttributes, and the operations DeleteNode, and CreateNode to also include the supported Goerli network.
* Proton (3.7.101.0)
	* Add support for CodeBuild Provisioning
* RDS (3.7.103.0)
	* This release adds support for restoring an RDS Multi-AZ DB cluster snapshot to a Single-AZ deployment or a Multi-AZ DB instance deployment.
* WorkDocs (3.7.101.0)
	* Added 2 new document related operations, DeleteDocumentVersion and RestoreDocumentVersions.
* XRay (3.7.101.0)
	* This release enhances GetServiceGraph API to support new type of edge to represent links between SQS and Lambda in event-driven applications.

### 3.7.416.0 (2022-11-11 20:09 UTC)
* Glue (3.7.101.12)
	* Added links related to enabling job bookmarks.
* IoT (3.7.102.0)
	* This release add new api listRelatedResourcesForAuditFinding and new member type IssuerCertificates for Iot device device defender Audit.
* LicenseManager (3.7.101.0)
	* AWS License Manager now supports onboarded Management Accounts or Delegated Admins to view granted licenses aggregated from all accounts in the organization.
* MarketplaceCatalog (3.7.101.0)
	* Added three new APIs to support tagging and tag-based authorization: TagResource, UntagResource, and ListTagsForResource. Added optional parameters to the StartChangeSet API to support tagging a resource while making a request to create it.
* Rekognition (3.7.101.0)
	* Adding support for ImageProperties feature to detect dominant colors and image brightness, sharpness, and contrast, inclusion and exclusion filters for labels and label categories, new fields to the API response, "aliases" and "categories"
* SecurityHub (3.7.100.16)
	* Documentation updates for Security Hub
* SSMIncidents (3.7.102.0)
	* RelatedItems now have an ID field which can be used for referencing them else where. Introducing event references in TimelineEvent API and increasing maximum length of "eventData" to 12K characters.
* Core 3.7.100.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.415.0 (2022-11-10 19:22 UTC)
* AutoScaling (3.7.101.5)
	* This release adds a new price capacity optimized allocation strategy for Spot Instances to help customers optimize provisioning of Spot Instances via EC2 Auto Scaling, EC2 Fleet, and Spot Fleet. It allocates Spot Instances based on both spare capacity availability and Spot Instance price.
* EC2 (3.7.107.0)
	* This release adds a new price capacity optimized allocation strategy for Spot Instances to help customers optimize provisioning of Spot Instances via EC2 Auto Scaling, EC2 Fleet, and Spot Fleet. It allocates Spot Instances based on both spare capacity availability and Spot Instance price.
* ECS (3.7.101.0)
	* This release adds support for task scale-in protection with updateTaskProtection and getTaskProtection APIs. UpdateTaskProtection API can be used to protect a service managed task from being terminated by scale-in events and getTaskProtection API to get the scale-in protection status of a task.
* Elasticsearch (3.7.101.0)
	* Amazon OpenSearch Service now offers managed VPC endpoints to connect to your Amazon OpenSearch Service VPC-enabled domain in a Virtual Private Cloud (VPC). This feature allows you to privately access OpenSearch Service domain without using public IPs or requiring traffic to traverse the Internet.
* ResourceExplorer2 (3.7.100.4)
	* Text only updates to some Resource Explorer descriptions.
* Scheduler (3.7.100.0)
	* AWS introduces the new Amazon EventBridge Scheduler. EventBridge Scheduler is a serverless scheduler that allows you to create, run, and manage tasks from one central, managed service.
* Core 3.7.100.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.414.0 (2022-11-09 19:38 UTC)
* Connect (3.7.102.0)
	* This release adds new fields SignInUrl, UserArn, and UserId to GetFederationToken response payload.
* ConnectCases (3.7.101.0)
	* This release adds the ability to disable templates through the UpdateTemplate API. Disabling templates prevents customers from creating cases using the template. For more information see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* EC2 (3.7.106.0)
	* Amazon EC2 Trn1 instances, powered by AWS Trainium chips, are purpose built for high-performance deep learning training. u-24tb1.112xlarge and u-18tb1.112xlarge High Memory instances are purpose-built to run large in-memory databases.
* GroundStation (3.7.101.0)
	* This release adds the preview of customer-provided ephemeris support for AWS Ground Station, allowing space vehicle owners to provide their own position and trajectory information for a satellite.
* MediaPackageVod (3.7.101.0)
	* This release adds "IncludeIframeOnlyStream" for Dash endpoints.

### 3.7.413.3 (2022-11-09 08:17 UTC)
* Core 3.7.100.14
	* Added fix for pre-signed url generation
	* All services packages updated to require new Core

### 3.7.413.1 (2022-11-09 00:31 UTC)
* Core 3.7.100.12
	* WebSocket protocol enabled for ServiceUrl overrides
	* All services packages updated to require new Core

### 3.7.413.0 (2022-11-08 19:26 UTC)
* BillingConductor (3.7.101.0)
	* This release adds the Recurring Custom Line Item feature along with a new API ListCustomLineItemVersions.
* CertificateManager (3.7.101.0)
	* Support added for requesting elliptic curve certificate key algorithm types P-256 (EC_prime256v1) and P-384 (EC_secp384r1).
* EC2 (3.7.105.0)
	* This release enables sharing of EC2 Placement Groups across accounts and within AWS Organizations using Resource Access Manager
* FMS (3.7.102.0)
	* AWS Firewall Manager now supports importing existing AWS Network Firewall firewalls into Firewall Manager policies.
* Lightsail (3.7.101.0)
	* This release adds support for Amazon Lightsail to automate the delegation of domains registered through Amazon Route 53 to Lightsail DNS management and to automate record creation for DNS validation of Lightsail SSL/TLS certificates.
* OpenSearchService (3.7.101.0)
	* Amazon OpenSearch Service now offers managed VPC endpoints to connect to your Amazon OpenSearch Service VPC-enabled domain in a Virtual Private Cloud (VPC). This feature allows you to privately access OpenSearch Service domain without using public IPs or requiring traffic to traverse the Internet.
* Polly (3.7.101.0)
	* Amazon Polly adds new voices: Elin (sv-SE), Ida (nb-NO), Laura (nl-NL) and Suvi (fi-FI). They are available as neural voices only.
* ResourceExplorer2 (3.7.100.0)
	* This is the initial SDK release for AWS Resource Explorer. AWS Resource Explorer lets your users search for and discover your AWS resources across the AWS Regions in your account.
* Route53 (3.7.101.0)
	* Amazon Route 53 now supports the Europe (Zurich) Region (eu-central-2) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Core 3.7.100.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.412.0 (2022-11-07 19:34 UTC)
* Athena (3.7.101.0)
	* Adds support for using Query Result Reuse
* AutoScaling (3.7.101.0)
	* This release adds support for two new attributes for attribute-based instance type selection - NetworkBandwidthGbps and AllowedInstanceTypes.
* CloudTrail (3.7.101.0)
	* This release includes support for configuring a delegated administrator to manage an AWS Organizations organization CloudTrail trails and event data stores, and AWS Key Management Service encryption of CloudTrail Lake event data stores.
* EC2 (3.7.104.0)
	* This release adds support for two new attributes for attribute-based instance type selection - NetworkBandwidthGbps and AllowedInstanceTypes.
* ElastiCache (3.7.101.0)
	* Added support for IPv6 and dual stack for Memcached and Redis clusters. Customers can now launch new Redis and Memcached clusters with IPv6 and dual stack networking support.
* LexModelsV2 (3.7.101.0)
	* Amazon Lex now supports new APIs for viewing and editing Custom Vocabulary in bots.
* MediaConvert (3.7.101.0)
	* The AWS Elemental MediaConvert SDK has added support for setting the SDR reference white point for HDR conversions and conversion of HDR10 to DolbyVision without mastering metadata.
* SimpleSystemsManagement (3.7.101.0)
	* This release includes support for applying a CloudWatch alarm to multi account multi region Systems Manager Automation
* WAFV2 (3.7.101.6)
	* The geo match statement now adds labels for country and region. You can match requests at the region level by combining a geo match statement with label match statements.
* WellArchitected (3.7.101.0)
	* This release adds support for integrations with AWS Trusted Advisor and AWS Service Catalog AppRegistry to improve workload discovery and speed up your workload reviews.
* WorkSpaces (3.7.102.0)
	* This release adds protocols attribute to workspaces properties data type. This enables customers to migrate workspaces from PC over IP (PCoIP) to WorkSpaces Streaming Protocol (WSP) using create and modify workspaces public APIs.
* Core 3.7.100.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.411.0 (2022-11-04 19:30 UTC)
* CloudWatchLogs (3.7.101.2)
	* Doc-only update for bug fixes and support of export to buckets encrypted with SSE-KMS
* EC2 (3.7.103.0)
	* This release adds API support for the recipient of an AMI account share to remove shared AMI launch permissions.
* EMRContainers (3.7.101.0)
	* Adding support for Job templates. Job templates allow you to create and store templates to configure Spark applications parameters. This helps you ensure consistent settings across applications by reusing and enforcing configuration overrides in data pipelines.
* Core 3.7.100.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.410.0 (2022-11-03 18:20 UTC)
* MemoryDB (3.7.101.0)
	* Adding support for r6gd instances for MemoryDB Redis with data tiering. In a cluster with data tiering enabled, when available memory capacity is exhausted, the least recently used data is automatically tiered to solid state drives for cost-effective capacity scaling with minimal performance impact.
* SageMaker (3.7.106.0)
	* Amazon SageMaker now supports running training jobs on ml.trn1 instance types.

### 3.7.409.0 (2022-11-02 18:50 UTC)
* IoTSiteWise (3.7.101.0)
	* This release adds the ListAssetModelProperties and ListAssetProperties APIs. You can list all properties that belong to a single asset model or asset using these two new APIs.
* S3Control (3.7.101.0)
	* S3 on Outposts launches support for Lifecycle configuration for Outposts buckets. With S3 Lifecycle configuration, you can mange objects so they are stored cost effectively. You can manage objects using size-based rules and specify how many noncurrent versions bucket will retain.
* SageMaker (3.7.105.0)
	* This release updates Framework model regex for ModelPackage to support new Framework version xgboost, sklearn.
* SSMIncidents (3.7.101.0)
	* Adds support for tagging replication-set on creation.
* Core 3.7.100.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.408.0 (2022-11-01 18:25 UTC)
* RDS (3.7.102.0)
	* Relational Database Service - This release adds support for configuring Storage Throughput on RDS database instances.
* Textract (3.7.102.0)
	* Add ocr results in AnalyzeIDResponse as blocks

### 3.7.407.0 (2022-10-31 18:30 UTC)
* AppRunner (3.7.102.0)
	* This release adds support for private App Runner services. Services may now be configured to be made private and only accessible from a VPC. The changes include a new VpcIngressConnection resource and several new and modified APIs.
* CloudWatchLogs (3.7.101.0)
	* SDK release to support tagging for destinations and log groups with TagResource. Also supports tag on create with PutDestination.
* Connect (3.7.101.0)
	* Amazon connect now support a new API DismissUserContact to dismiss or remove terminated contacts in Agent CCP
* EC2 (3.7.102.0)
	* Elastic IP transfer is a new Amazon VPC feature that allows you to transfer your Elastic IP addresses from one AWS Account to another.
* IoT (3.7.101.0)
	* This release adds the Amazon Location action to IoT Rules Engine.
* SimpleEmailV2 (3.7.101.0)
	* This release includes support for interacting with the Virtual Deliverability Manager, allowing you to opt in/out of the feature and to retrieve recommendations and metric data.
* Textract (3.7.101.0)
	* This release introduces additional support for 30+ normalized fields such as vendor address and currency. It also includes OCR output in the response and accuracy improvements for the already supported fields in previous version
* Core 3.7.100.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.406.1 (2022-10-28 23:06 UTC)
* Core 3.7.100.6
	* Update SigV4 and SigV4a signers to improve compatibility with versions of AWSSDK.S3 before 3.7.100.0, when internal logic for constructing API endpoints was updated.
	* All services packages updated to require new Core

### 3.7.406.0 (2022-10-28 18:27 UTC)
* AppRunner (3.7.101.0)
	* AWS App Runner adds .NET 6, Go 1, PHP 8.1 and Ruby 3.1 runtimes.
* AppStream (3.7.101.0)
	* This release includes CertificateBasedAuthProperties in CreateDirectoryConfig and UpdateDirectoryConfig.
* Cloud9 (3.7.100.5)
	* Update to the documentation section of the Cloud9 API Reference guide.
* CloudFormation (3.7.101.0)
	* This release adds more fields to improves visibility of AWS CloudFormation StackSets information in following APIs: ListStackInstances, DescribeStackInstance, ListStackSetOperationResults, ListStackSetOperations, DescribeStackSetOperation.
* GameSparks (3.7.101.0)
	* Add LATEST as a possible GameSDK Version on snapshot
* MediaTailor (3.7.102.0)
	* This release introduces support for SCTE-35 segmentation descriptor messages which can be sent within time signal messages.
* Private5G (3.7.101.0)
	* Fix incorrect endpoint-prefix in endpoint ruleset.
* SupportApp (3.7.101.0)
	* Fix incorrect endpoint-prefix in endpoint ruleset.
* Core 3.7.100.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.405.0 (2022-10-27 19:28 UTC)
* EC2 (3.7.101.0)
	* Feature supports the replacement of instance root volume using an updated AMI without requiring customers to stop their instance.
* FMS (3.7.101.0)
	* Add support NetworkFirewall Managed Rule Group Override flag in GetViolationDetails API
* Glue (3.7.101.0)
	* Added support for custom datatypes when using custom csv classifier.
* Redshift (3.7.100.4)
	* This release clarifies use for the ElasticIp parameter of the CreateCluster and RestoreFromClusterSnapshot APIs.
* SageMaker (3.7.104.0)
	* This change allows customers to provide a custom entrypoint script for the docker container to be run while executing training jobs, and provide custom arguments to the entrypoint script.
* WAFV2 (3.7.101.0)
	* This release adds the following: Challenge rule action, to silently verify client browsers; rule group rule action override to any valid rule action, not just Count; token sharing between protected applications for challenge/CAPTCHA token; targeted rules option for Bot Control managed rule group.
* Core 3.7.100.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.404.0 (2022-10-26 18:22 UTC)
* IdentityManagement (3.7.100.4)
	* Doc only update that corrects instances of CLI not using an entity.
* Kafka (3.7.101.0)
	* This release adds support for Tiered Storage. UpdateStorage allows you to control the Storage Mode for supported storage tiers.
* Neptune (3.7.101.0)
	* Added a new cluster-level attribute to set the capacity range for Neptune Serverless instances.
* SageMaker (3.7.103.0)
	* Amazon SageMaker Automatic Model Tuning now supports specifying Grid Search strategy for tuning jobs, which evaluates all hyperparameter combinations exhaustively based on the categorical hyperparameters provided.

### 3.7.403.1 (2022-10-26 14:00 UTC)
* S3 (3.7.101.3)
	* fix: change incorrect docs for MinSizeBeforePartUpload property in S3; Corrected the root element emitted by S3 SelectObjectContentRequestMarshaller to conform to S3 API.
* Core 3.7.100.3
	* Retain custom uri port when UseHttp is enforced.
	* All services packages updated to require new Core

### 3.7.403.0 (2022-10-25 18:22 UTC)
* AccessAnalyzer (3.7.101.0)
	* This release adds support for six new resource types in IAM Access Analyzer to help you easily identify public and cross-account access to your AWS resources. Updated service API, documentation, and paginators.
* LocationService (3.7.100.2)
	* Added new map styles with satellite imagery for map resources using HERE as a data provider.
* MediaTailor (3.7.101.0)
	* This release is a documentation update
* RDS (3.7.101.0)
	* Relational Database Service - This release adds support for exporting DB cluster data to Amazon S3.
* WorkSpaces (3.7.101.0)
	* This release adds new enums for supporting Workspaces Core features, including creating Manual running mode workspaces, importing regular Workspaces Core images and importing g4dn Workspaces Core images.
* Core 3.7.100.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.402.0 (2022-10-24 19:07 UTC)
* ACMPCA (3.7.101.0)
	* AWS Private Certificate Authority (AWS Private CA) now offers usage modes which are combination of features to address specific use cases.
* Batch (3.7.101.0)
	* This release adds support for AWS Batch on Amazon EKS.
* DataSync (3.7.101.0)
	* Added support for self-signed certificates when using object storage locations; added BytesCompressed to the TaskExecution response.
* SageMaker (3.7.102.0)
	* SageMaker Inference Recommender now supports a new API ListInferenceRecommendationJobSteps to return the details of all the benchmark we create for an inference recommendation job.
* Core 3.7.100.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.401.0 (2022-10-21 20:42 UTC)
* CognitoIdentityProvider (3.7.101.0)
	* This release adds a new "DeletionProtection" field to the UserPool in Cognito. Application admins can configure this value with either ACTIVE or INACTIVE value. Setting this field to ACTIVE will prevent a user pool from accidental deletion.
* S3 (3.7.101.0)
	* S3 on Outposts launches support for automatic bucket-style alias. You can use the automatic access point alias instead of an access point ARN for any object-level operation in an Outposts bucket.
* SageMaker (3.7.101.0)
	* CreateInferenceRecommenderjob API now supports passing endpoint details directly, that will help customers to identify the max invocation and max latency they can achieve for their model and the associated endpoint along with getting recommendations on other instances.

### 3.7.400.0 (2022-10-21 01:00 UTC)
* All (Core and Services) updated to version 3.7.100.0
    * Updates internal logic for constructing API endpoints.
    * We have added rule-based endpoint providers. Additionally there are new interfaces for endpoint providers and parameters at the service client level.

### 3.7.378.0 (2022-10-20 18:57 UTC)
* CloudWatchRUM (3.7.1.0)
	* CloudWatch RUM now supports Extended CloudWatch Metrics with Additional Dimensions
* DevOpsGuru (3.7.12.0)
	* This release adds information about the resources DevOps Guru is analyzing.
* GlobalAccelerator (3.7.2.0)
	* Global Accelerator now supports AddEndpoints and RemoveEndpoints operations for standard endpoint groups.
* ResilienceHub (3.7.2.0)
	* In this release, we are introducing support for regional optimization for AWS Resilience Hub applications. It also includes a few documentation updates to improve clarity.
* Core 3.7.13.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.377.0 (2022-10-19 18:25 UTC)
* ChimeSDKMessaging (3.7.5.32)
	* Documentation updates for Chime Messaging SDK
* CloudTrail (3.7.7.0)
	* This release includes support for exporting CloudTrail Lake query results to an Amazon S3 bucket.
* ConfigService (3.7.14.0)
	* This release adds resourceType enums for AppConfig, AppSync, DataSync, EC2, EKS, Glue, GuardDuty, SageMaker, ServiceDiscovery, SES, Route53 types.
* Connect (3.7.27.0)
	* This release adds API support for managing phone numbers that can be used across multiple AWS regions through telephony traffic distribution.
* EventBridge (3.7.6.0)
	* Updates internal logic for constructing API endpoints. We have added rule-based endpoints and internal model parameters.
* ManagedBlockchain (3.7.2.0)
	* Adding new Accessor APIs for Amazon Managed Blockchain
* S3 (3.7.10.0)
	* Updates internal logic for constructing API endpoints. We have added rule-based endpoints and internal model parameters.
* S3Control (3.7.9.0)
	* Updates internal logic for constructing API endpoints. We have added rule-based endpoints and internal model parameters.
* SupportApp (3.7.1.0)
	* This release adds the RegisterSlackWorkspaceForOrganization API. You can use the API to register a Slack workspace for an AWS account that is part of an organization.
* WorkSpacesWeb (3.7.2.0)
	* WorkSpaces Web now supports user access logging for recording session start, stop, and URL navigation.
* Core 3.7.13.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.376.1 (2022-10-19 13:49 UTC)
* DynamoDBv2 (3.7.5.18)
	* Fixed NullReferenceException bug caused by empty strings in DynamoDB Lists. This bug used to occur when flag isEmptyStringValueEnabled was set to false.
* S3 (3.7.9.71)
	* Fixed S3 request marshallers to include xmlns attribute in root XML element to make it consistent with S3 API.

### 3.7.376.0 (2022-10-18 18:23 UTC)
* FraudDetector (3.7.7.40)
	* Documentation Updates for Amazon Fraud Detector
* SageMaker (3.7.54.0)
	* This change allows customers to enable data capturing while running a batch transform job, and configure monitoring schedule to monitoring the captured data.
* ServiceDiscovery (3.7.4.0)
	* Updated the ListNamespaces API to support the NAME and HTTP_NAME filters, and the BEGINS_WITH filter condition.
* SimpleEmailV2 (3.7.2.0)
	* This release allows subscribers to enable Dedicated IPs (managed) to send email via a fully managed dedicated IP experience. It also adds identities' VerificationStatus in the response of GetEmailIdentity and ListEmailIdentities APIs, and ImportJobs counts in the response of ListImportJobs API.
* Core 3.7.13.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.375.0 (2022-10-17 18:18 UTC)
* Greengrass (3.7.1.0)
	* This change allows customers to specify FunctionRuntimeOverride in FunctionDefinitionVersion. This configuration can be used if the runtime on the device is different from the AWS Lambda runtime specified for that function.
* SageMaker (3.7.53.0)
	* This release adds support for C7g, C6g, C6gd, C6gn, M6g, M6gd, R6g, and R6gn Graviton instance types in Amazon SageMaker Inference.

### 3.7.374.0 (2022-10-14 18:18 UTC)
* MediaConvert (3.7.18.0)
	* MediaConvert now supports specifying the minimum percentage of the HRD buffer available at the end of each encoded video segment.
* Core 3.7.13.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.373.0 (2022-10-13 18:34 UTC)
* AmplifyUIBuilder (3.7.4.0)
	* We are releasing the ability for fields to be configured as arrays.
* Appflow (3.7.10.0)
	* With this update, you can choose which Salesforce API is used by Amazon AppFlow to transfer data to or from your Salesforce account. You can choose the Salesforce REST API or Bulk API 2.0. You can also choose for Amazon AppFlow to pick the API automatically.
* Connect (3.7.26.0)
	* This release adds support for a secondary email and a mobile number for Amazon Connect instance users.
* ConnectWisdomService (3.7.3.0)
	* This release updates the GetRecommendations API to include a trigger event list for classifying and grouping recommendations.
* DirectoryService (3.7.3.0)
	* This release adds support for describing and updating AWS Managed Microsoft AD set up.
* ECS (3.7.5.93)
	* Documentation update to address tickets.
* GuardDuty (3.7.5.0)
	* Add UnprocessedDataSources to CreateDetectorResponse which specifies the data sources that couldn't be enabled during the CreateDetector request. In addition, update documentations.
* IdentityManagement (3.7.2.202)
	* Documentation updates for the AWS Identity and Access Management API Reference.
* IoTFleetWise (3.7.0.9)
	* Documentation update for AWS IoT FleetWise
* MediaLive (3.7.13.0)
	* AWS Elemental MediaLive now supports forwarding SCTE-35 messages through the Event Signaling and Management (ESAM) API, and can read those SCTE-35 messages from an inactive source.
* MediaPackageVod (3.7.6.0)
	* This release adds SPEKE v2 support for MediaPackage VOD. Speke v2 is an upgrade to the existing SPEKE API to support multiple encryption keys, based on an encryption contract selected by the customer.
* Panorama (3.7.4.0)
	* Pause and resume camera stream processing with SignalApplicationInstanceNodeInstances. Reboot an appliance with CreateJobForDevices. More application state information in DescribeApplicationInstance response.
* RDSDataService (3.7.1.72)
	* Doc update to reflect no support for schema parameter on BatchExecuteStatement API
* SimpleSystemsManagement (3.7.21.0)
	* Support of AmazonLinux2022 by Patch Manager
* SSMIncidents (3.7.7.0)
	* Update RelatedItem enum to support Tasks
* Transfer (3.7.15.0)
	* This release adds an option for customers to configure workflows that are triggered when files are only partially received from a client due to premature session disconnect.
* Translate (3.7.6.6)
	* This release enables customers to specify multiple target languages in asynchronous batch translation requests.
* Core 3.7.13.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.372.0 (2022-10-07 18:23 UTC)
* CodeGuruReviewer (3.7.6.70)
	* Documentation update to replace broken link.
* ElasticLoadBalancingV2 (3.7.3.139)
	* Gateway Load Balancer adds a new feature (target_failover) for customers to rebalance existing flows to a healthy target after marked unhealthy or deregistered. This allows graceful patching/upgrades of target appliances during maintenance windows, and helps reduce unhealthy target failover time.
* GreengrassV2 (3.7.7.0)
	* This release adds error status details for deployments and components that failed on a device and adds features to improve visibility into component installation.
* QuickSight (3.7.14.0)
	* Amazon QuickSight now supports SecretsManager Secret ARN in place of CredentialPair for DataSource creation and update. This release also has some minor documentation updates and removes CountryCode as a required parameter in GeoSpatialColumnGroup
* Core 3.7.13.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.371.1 (2022-10-06 18:33 UTC)
* ResilienceHub (3.7.1.61)
	* Documentation change for AWS Resilience Hub. Doc-only update to fix Documentation layout
* Core 3.7.13.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.371.0 (2022-10-05 18:21 UTC)
* Glue (3.7.25.0)
	* This SDK release adds support to sync glue jobs with source control provider. Additionally, a new parameter called SourceControlDetails will be added to Job model.
* NetworkFirewall (3.7.6.0)
	* StreamExceptionPolicy configures how AWS Network Firewall processes traffic when a network connection breaks midstream
* Outposts (3.7.12.0)
	* This release adds the Asset state information to the ListAssets response. The ListAssets request supports filtering on Asset state.

### 3.7.370.0 (2022-10-04 18:23 UTC)
* Connect (3.7.25.0)
	* Updated the CreateIntegrationAssociation API to support the CASES_DOMAIN IntegrationType.
* ConnectCases (3.7.0.0)
	* This release adds APIs for Amazon Connect Cases. Cases allows your agents to quickly track and manage customer issues that require multiple interactions, follow-up tasks, and teams in your contact center.  For more information, see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* EC2 (3.7.95.0)
	* Added EnableNetworkAddressUsageMetrics flag for ModifyVpcAttribute, DescribeVpcAttribute APIs.
* ECS (3.7.5.90)
	* Documentation updates to address various Amazon ECS tickets.
* S3Control (3.7.8.0)
	* S3 Object Lambda adds support to allow customers to intercept HeadObject and ListObjects requests and introduce their own compute. These requests were previously proxied to S3.
* WorkMail (3.7.7.0)
	* This release adds support for impersonation roles in Amazon WorkMail.
* Core 3.7.13.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.369.0 (2022-10-03 18:20 UTC)
* AccessAnalyzer (3.7.3.0)
	* AWS IAM Access Analyzer policy validation introduces new checks for role trust policies. As customers author a policy, IAM Access Analyzer policy validation evaluates the policy for any issues to make it easier for customers to author secure policies.
* EC2 (3.7.94.0)
	* Adding an imdsSupport attribute to EC2 AMIs
* Snowball (3.7.5.0)
	* Adds support for V3_5C. This is a refreshed AWS Snowball Edge Compute Optimized device type with 28TB SSD, 104 vCPU and 416GB memory (customer usable).
* Core 3.7.13.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.368.0 (2022-09-30 18:22 UTC)
* CodeDeploy (3.7.1.0)
	* This release allows you to override the alarm configurations when creating a deployment.
* DevOpsGuru (3.7.11.0)
	* This release adds filter feature on AddNotificationChannel API, enable customer to configure the SNS notification messages by Severity or MessageTypes
* DLM (3.7.3.0)
	* This release adds support for archival of single-volume snapshots created by Amazon Data Lifecycle Manager policies
* SageMaker (3.7.52.0)
	* A new parameter called ExplainerConfig is added to CreateEndpointConfig API to enable SageMaker Clarify online explainability feature.
* SageMakerRuntime (3.7.3.0)
	* A new parameter called EnableExplanations is added to InvokeEndpoint API to enable on-demand SageMaker Clarify online explainability requests.
* SSOOIDC (3.7.1.20)
	* Documentation updates for the IAM Identity Center OIDC CLI Reference.
* Core 3.7.13.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.367.0 (2022-09-29 18:26 UTC)
* CertificateManager (3.7.2.0)
	* This update returns additional certificate details such as certificate SANs and allows sorting in the ListCertificates API.
* EC2 (3.7.93.0)
	* u-3tb1 instances are powered by Intel Xeon Platinum 8176M (Skylake) processors and are purpose-built to run large in-memory databases.
* EMRServerless (3.7.1.0)
	* This release adds API support to debug Amazon EMR Serverless jobs in real-time with live application UIs
* FSx (3.7.14.0)
	* This release adds support for Amazon File Cache.
* MigrationHubOrchestrator (3.7.0.0)
	* Introducing AWS MigrationHubOrchestrator. This is the first public release of AWS MigrationHubOrchestrator.
* Polly (3.7.8.0)
	* Added support for the new Cantonese voice - Hiujin. Hiujin is available as a Neural voice only.
* Proton (3.7.5.0)
	* This release adds an option to delete pipeline provisioning repositories using the UpdateAccountSettings API
* SageMaker (3.7.51.0)
	* SageMaker Training Managed Warm Pools let you retain provisioned infrastructure to reduce latency for repetitive training workloads.
* SecretsManager (3.7.2.100)
	* Documentation updates for Secrets Manager
* Translate (3.7.6.0)
	* This release enables customers to access control rights on Translate resources like Parallel Data and Custom Terminology using Tag Based Authorization.
* WorkSpaces (3.7.11.0)
	* This release includes diagnostic log uploading feature. If it is enabled, the log files of WorkSpaces Windows client will be sent to Amazon WorkSpaces automatically for troubleshooting. You can use modifyClientProperty api to enable/disable this feature.
* Core 3.7.13.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.366.0 (2022-09-27 18:23 UTC)
* CostExplorer (3.7.7.0)
	* This release is to support retroactive Cost Categories. The new field will enable you to retroactively apply new and existing cost category rules to previous months.
* Kendra (3.7.27.0)
	* My AWS Service (placeholder) - Amazon Kendra now provides a data source connector for DropBox. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-dropbox.html
* LocationService (3.7.12.0)
	* This release adds place IDs, which are unique identifiers of places, along with a new GetPlace operation, which can be used with place IDs to find a place again later. UnitNumber and UnitType are also added as new properties of places.
* Core 3.7.13.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.365.1 (2022-09-26 23:08 UTC)
* S3 (3.7.9.60)
	* Fix unmarshalling of empty SSES3 shape in ListBucketInventoryConfigurations
* Core 3.7.13.11
	* Add support for Collections of Documents and fix concurrency issue when setting up region endpoints
	* All services packages updated to require new Core

### 3.7.365.0 (2022-09-26 18:19 UTC)
* CostAndUsageReport (3.7.1.0)
	* This release adds two new support regions(me-central-1/eu-south-2) for OSG.
* IoTFleetWise (3.7.0.0)
	* General availability (GA) for AWS IoT Fleetwise. It adds AWS IoT Fleetwise to AWS SDK. For more information, see https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/Welcome.html.
* SimpleSystemsManagement (3.7.20.0)
	* This release includes support for applying a CloudWatch alarm to Systems Manager capabilities like Automation, Run Command, State Manager, and Maintenance Windows.
* Core 3.7.13.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.364.0 (2022-09-23 18:20 UTC)
* AppRunner (3.7.5.0)
	* AWS App Runner adds a Node.js 16 runtime.
* EC2 (3.7.92.0)
	* Letting external AWS customers provide ImageId as a Launch Template override in FleetLaunchTemplateOverridesRequest
* LexModelsV2 (3.7.17.0)
	* This release introduces additional optional parameters promptAttemptsSpecification to PromptSpecification, which enables the users to configure interrupt setting and Audio, DTMF and Text input configuration for the initial and retry prompt played by the Bot
* Lightsail (3.7.10.0)
	* This release adds Instance Metadata Service (IMDS) support for Lightsail instances.
* NimbleStudio (3.7.6.0)
	* Amazon Nimble Studio adds support for on-demand Amazon Elastic Compute Cloud (EC2) G3 and G5 instances, allowing customers to utilize additional GPU instance types for their creative projects.
* SimpleSystemsManagement (3.7.19.0)
	* This release adds new SSM document types ConformancePackTemplate and CloudFormation
* WAFV2 (3.7.13.23)
	* Add the default specification for ResourceType in ListResourcesForWebACL.
* Core 3.7.13.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.363.0 (2022-09-22 18:21 UTC)
* BackupGateway (3.7.2.0)
	* Changes include: new GetVirtualMachineApi to fetch a single user's VM, improving ListVirtualMachines to fetch filtered VMs as well as all VMs, and improving GetGatewayApi to now also return the gateway's MaintenanceStartTime.
* DeviceFarm (3.7.2.0)
	* This release adds the support for VPC-ENI based connectivity for private devices on AWS Device Farm.
* EC2 (3.7.91.0)
	* Documentation updates for Amazon EC2.
* Glue (3.7.24.0)
	* Added support for S3 Event Notifications for Catalog Target Crawlers.
* IdentityStore (3.7.1.13)
	* Documentation updates for the Identity Store CLI Reference.
* Core 3.7.13.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.362.0 (2022-09-21 18:28 UTC)
* Comprehend (3.7.8.0)
	* Amazon Comprehend now supports synchronous mode for targeted sentiment API operations.
* S3Control (3.7.7.0)
	* S3 on Outposts launches support for object versioning for Outposts buckets. With S3 Versioning, you can preserve, retrieve, and restore every version of every object stored in your buckets. You can recover from both unintended user actions and application failures.
* SageMaker (3.7.50.0)
	* SageMaker now allows customization on Canvas Application settings, including enabling/disabling time-series forecasting and specifying an Amazon Forecast execution role at both the Domain and UserProfile levels.
* Core 3.7.13.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.361.0 (2022-09-20 18:20 UTC)
* EC2 (3.7.90.0)
	* This release adds support for blocked paths to Amazon VPC Reachability Analyzer.
* Core 3.7.13.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.360.0 (2022-09-19 18:21 UTC)
* CloudTrail (3.7.6.0)
	* This release includes support for importing existing trails into CloudTrail Lake.
* EC2 (3.7.89.0)
	* This release adds CapacityAllocations field to DescribeCapacityReservations
* MediaConnect (3.7.6.0)
	* This change allows the customer to use the SRT Caller protocol as part of their flows
* RDS (3.7.18.0)
	* This release adds support for Amazon RDS Proxy with SQL Server compatibility.
* Core 3.7.13.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.359.0 (2022-09-16 18:19 UTC)
* CodeStarNotifications (3.7.1.0)
	* This release adds tag based access control for the UntagResource API.
* ECS (3.7.5.78)
	* This release supports new task definition sizes.

### 3.7.358.0 (2022-09-15 18:24 UTC)
* DynamoDBv2 (3.7.5.0)
	* Increased DynamoDB transaction limit from 25 to 100.
* EC2 (3.7.88.0)
	* This feature allows customers to create tags for vpc-endpoint-connections and vpc-endpoint-service-permissions.
* SageMaker (3.7.49.0)
	* Amazon SageMaker Automatic Model Tuning now supports specifying Hyperband strategy for tuning jobs, which uses a multi-fidelity based tuning strategy to stop underperforming hyperparameter configurations early.
* Core 3.7.13.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.357.0 (2022-09-14 18:22 UTC)
* AmplifyUIBuilder (3.7.3.0)
	* Amplify Studio UIBuilder is introducing forms functionality. Forms can be configured from Data Store models, JSON, or from scratch. These forms can then be generated in your project and used like any other React components.
* EC2 (3.7.87.0)
	* This update introduces API operations to manage and create local gateway route tables, CoIP pools, and VIF group associations.
* Core 3.7.13.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.356.0 (2022-09-13 18:25 UTC)
* CloudWatchEvidently (3.7.4.0)
	* This release adds support for the client-side evaluation - powered by AWS AppConfig feature.
* CustomerProfiles (3.7.8.0)
	* Added isUnstructured in response for Customer Profiles Integration APIs
* Drs (3.7.4.0)
	* Fixed the data type of lagDuration that is returned in Describe Source Server API
* EC2 (3.7.86.0)
	* Two new features for local gateway route tables: support for static routes targeting Elastic Network Interfaces and direct VPC routing.
* Kendra (3.7.26.0)
	* This release enables our customer to choose the option of Sharepoint 2019 for the on-premise Sharepoint connector.
* Transfer (3.7.14.0)
	* This release introduces the ability to have multiple server host keys for any of your Transfer Family servers that use the SFTP protocol.
* Core 3.7.13.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.355.0 (2022-09-12 18:17 UTC)
* EKS (3.7.16.0)
	* Adding support for local Amazon EKS clusters on Outposts

### 3.7.354.0 (2022-09-09 18:25 UTC)
* CloudTrail (3.7.5.0)
	* This release adds CloudTrail getChannel and listChannels APIs to allow customer to view the ServiceLinkedChannel configurations.
* LexModelsV2 (3.7.16.0)
	* This release is for supporting Composite Slot Type feature in AWS Lex V2. Composite Slot Type will help developer to logically group coherent slots and maintain their inter-relationships in runtime conversation.
* LexRuntimeV2 (3.7.5.0)
	* This release is for supporting Composite Slot Type feature in AWS Lex V2. Composite Slot Type will help developer to logically group coherent slots and maintain their inter-relationships in runtime conversation.
* PI (3.7.3.0)
	* Increases the maximum values of two RDS Performance Insights APIs. The maximum value of the Limit parameter of DimensionGroup is 25. The MaxResult maximum is now 25 for the following APIs: DescribeDimensionKeys, GetResourceMetrics, ListAvailableResourceDimensions, and ListAvailableResourceMetrics.
* Redshift (3.7.17.25)
	* This release updates documentation for AQUA features and other description updates.
* Core 3.7.13.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.353.0 (2022-09-09 00:27 UTC)
* Drs (3.7.3.0)
	* Added public IsReplicationConfigurationTemplateIDsSet property for DescribeReplicationConfigurationTemplatesRequest.
* DynamoDBv2 (3.7.4.9)
	* Add ability to mock AsyncSearch (PR 2089). Make convert methods in DataModel abstraction public.
* Core 3.7.13.0
	* Add support for Bearer Token authentication; Added property setters in AssumeRoleWithWebIdentityCredentialsOptions class.
	* All services packages updated to require new Core

### 3.7.352.0 (2022-09-08 18:57 UTC)
* EC2 (3.7.85.0)
	* This release adds support to send VPC Flow Logs to kinesis-data-firehose as new destination type
* EMRContainers (3.7.3.0)
	* EMR on EKS now allows running Spark SQL using the newly introduced Spark SQL Job Driver in the Start Job Run API
* LookoutMetrics (3.7.14.0)
	* Release dimension value filtering feature to allow customers to define dimension filters for including only a subset of their dataset to be used by LookoutMetrics.
* MediaLive (3.7.12.0)
	* This change exposes API settings which allow Dolby Atmos and Dolby Vision to be used when running a channel using Elemental Media Live
* Route53 (3.7.4.0)
	* Amazon Route 53 now supports the Middle East (UAE) Region (me-central-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SageMaker (3.7.48.0)
	* This release adds Mode to AutoMLJobConfig.
* SimpleSystemsManagement (3.7.18.0)
	* This release adds support for Systems Manager State Manager Association tagging.
* Core 3.7.12.30
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.351.0 (2022-09-07 18:24 UTC)
* DataExchange (3.7.5.0)
	* Documentation updates for AWS Data Exchange.
* EC2 (3.7.84.0)
	* Documentation updates for Amazon EC2.
* EKS (3.7.15.0)
	* Adds support for EKS Addons ResolveConflicts "preserve" flag. Also adds new update failed status for EKS Addons.
* FSx (3.7.13.38)
	* Documentation update for Amazon FSx.
* Inspector2 (3.7.2.0)
	* This release adds new fields like fixAvailable, fixedInVersion and remediation to the finding model. The requirement to have vulnerablePackages in the finding model has also been removed. The documentation has been updated to reflect these changes.
* IoTSiteWise (3.7.14.0)
	* Allow specifying units in Asset Properties
* SageMaker (3.7.47.0)
	* SageMaker Hosting now allows customization on ML instance storage volume size, model data download timeout and inference container startup ping health check timeout for each ProductionVariant in CreateEndpointConfig API.
* SimpleNotificationService (3.7.4.0)
	* Amazon SNS introduces the Data Protection Policy APIs, which enable customers to attach a data protection policy to an SNS topic. This allows topic owners to enable the new message data protection feature to audit and block sensitive data that is exchanged through their topics.

### 3.7.350.0 (2022-09-06 20:11 UTC)
* IdentityStore (3.7.1.3)
	* Documentation updates for the Identity Store CLI Reference.
* SageMaker (3.7.46.0)
	* This release adds HyperParameterTuningJob type in Search API.

### 3.7.349.0 (2022-09-02 18:22 UTC)
* CognitoIdentityProvider (3.7.6.0)
	* This release adds a new "AuthSessionValidity" field to the UserPoolClient in Cognito. Application admins can configure this value for their users' authentication duration, which is currently fixed at 3 minutes, up to 15 minutes. Setting this field will also apply to the SMS MFA authentication flow.
* Connect (3.7.24.0)
	* This release adds search APIs for Routing Profiles and Queues, which can be used to search for those resources within a Connect Instance.
* MediaPackage (3.7.9.0)
	* Added support for AES_CTR encryption to CMAF origin endpoints
* SageMaker (3.7.45.0)
	* This release enables administrators to attribute user activity and API calls from Studio notebooks, Data Wrangler and Canvas to specific users even when users share the same execution IAM role.  ExecutionRoleIdentityConfig at Sagemaker domain level enables this feature.
* Core 3.7.12.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.348.0 (2022-09-01 18:24 UTC)
* CodeGuruReviewer (3.7.6.49)
	* Documentation updates to fix formatting issues in CLI and SDK documentation.
* ControlTower (3.7.0.0)
	* This release contains the first SDK for AWS Control Tower. It introduces  a new set of APIs: EnableControl, DisableControl, GetControlOperation, and ListEnabledControls.
* Route53 (3.7.3.32)
	* Documentation updates for Amazon Route 53.
* Core 3.7.12.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.347.0 (2022-08-31 18:30 UTC)
* CloudFront (3.7.8.4)
	* Update API documentation for CloudFront origin access control (OAC)
* IdentityStore (3.7.1.0)
	* Expand IdentityStore API to support Create, Read, Update, Delete and Get operations for User, Group and GroupMembership resources.
* IoTThingsGraph (3.7.1.0)
	* This release deprecates all APIs of the ThingsGraph service
* IVS (3.7.6.0)
	* IVS Merge Fragmented Streams. This release adds support for recordingReconnectWindow field in IVS recordingConfigurations. For more information see https://docs.aws.amazon.com/ivs/latest/APIReference/Welcome.html
* RDSDataService (3.7.1.49)
	* Documentation updates for RDS Data API
* SageMaker (3.7.44.0)
	* SageMaker Inference Recommender now accepts Inference Recommender fields: Domain, Task, Framework, SamplePayloadUrl, SupportedContentTypes, SupportedInstanceTypes, directly in our CreateInferenceRecommendationsJob API through ContainerConfig

### 3.7.346.0 (2022-08-30 20:32 UTC)
* GreengrassV2 (3.7.6.0)
	* Adds topologyFilter to ListInstalledComponentsRequest which allows filtration of components by ROOT or ALL (including root and dependency components). Adds lastStatusChangeTimestamp to ListInstalledComponents response to show the last time a component changed state on a device.
* IdentityStore (3.7.0.200)
	* Documentation updates for the Identity Store CLI Reference.
* LookoutEquipment (3.7.4.0)
	* This release adds new apis for providing labels.
* Macie2 (3.7.10.0)
	* This release of the Amazon Macie API adds support for using allow lists to define specific text and text patterns to ignore when inspecting data sources for sensitive data.
* SSO (3.7.0.199)
	* Documentation updates for the AWS IAM Identity Center Portal CLI Reference.
* SSOAdmin (3.7.1.17)
	* Documentation updates for the AWS IAM Identity Center CLI Reference.
* Core 3.7.12.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.345.0 (2022-08-29 19:18 UTC)
* FSx (3.7.13.34)
	* Documentation updates for Amazon FSx for NetApp ONTAP.
* VoiceID (3.7.3.0)
	* Amazon Connect Voice ID now detects voice spoofing.  When a prospective fraudster tries to spoof caller audio using audio playback or synthesized speech, Voice ID will return a risk score and outcome to indicate the how likely it is that the voice is spoofed.
* Core 3.7.12.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.344.0 (2022-08-26 18:21 UTC)
* MediaPackage (3.7.8.0)
	* This release adds Ads AdTriggers and AdsOnDeliveryRestrictions to describe calls for CMAF endpoints on MediaPackage.
* RDS (3.7.17.2)
	* Removes support for RDS Custom from DBInstanceClass in ModifyDBInstance

### 3.7.343.0 (2022-08-25 18:36 UTC)
* ElasticLoadBalancingV2 (3.7.3.115)
	* Documentation updates for ELBv2.  Gateway Load Balancer now supports Configurable Flow Stickiness, enabling you to configure the hashing used to maintain stickiness of flows to a specific target appliance.
* GameLift (3.7.2.0)
	* This release adds support for eight EC2 local zones as fleet locations; Atlanta, Chicago, Dallas, Denver, Houston, Kansas City (us-east-1-mci-1a), Los Angeles, and Phoenix. It also adds support for C5d, C6a, C6i, and R5d EC2 instance families.
* IoTWireless (3.7.13.0)
	* This release includes a new feature for the customers to enable the LoRa gateways to send out beacons for Class B devices and an option to select one or more gateways for Class C devices when sending the LoRaWAN downlink messages.
* Ivschat (3.7.0.47)
	* Documentation change for IVS Chat API Reference. Doc-only update to add a paragraph on ARNs to the Welcome section.
* Panorama (3.7.3.0)
	* Support sorting and filtering in ListDevices API, and add more fields to device listings and single device detail
* SSOOIDC (3.7.1.0)
	* Updated required request parameters on IAM Identity Center's OIDC CreateToken action.
* Core 3.7.12.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.342.0 (2022-08-24 18:25 UTC)
* CloudFront (3.7.8.0)
	* Adds support for CloudFront origin access control (OAC), making it possible to restrict public access to S3 bucket origins in all AWS Regions, those with SSE-KMS, and more.
* ConfigService (3.7.13.0)
	* AWS Config now supports ConformancePackTemplate documents in SSM Docs for the deployment and update of conformance packs.
* IdentityManagement (3.7.2.176)
	* Documentation updates for AWS Identity and Access Management (IAM).
* IVS (3.7.5.4)
	* Documentation Change for IVS API Reference - Doc-only update to type field description for CreateChannel and UpdateChannel actions and for Channel data type. Also added Amazon Resource Names (ARNs) paragraph to Welcome section.
* QuickSight (3.7.13.0)
	* Added a new optional property DashboardVisual under ExperienceConfiguration parameter of GenerateEmbedUrlForAnonymousUser and GenerateEmbedUrlForRegisteredUser API operations. This supports embedding of specific visuals in QuickSight dashboards.
* Transfer (3.7.13.12)
	* Documentation updates for AWS Transfer Family

### 3.7.341.0 (2022-08-23 18:44 UTC)
* RDS (3.7.17.0)
	* RDS for Oracle supports Oracle Data Guard switchover and read replica backups.
* SSOAdmin (3.7.1.14)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)

### 3.7.340.1 (2022-08-23 13:37 UTC)
* SimpleNotificationService (3.7.3.96)
	* Added SHA256 message validation support.

### 3.7.340.0 (2022-08-22 18:29 UTC)
* DocDB (3.7.4.12)
	* Update document for volume clone
* EC2 (3.7.83.0)
	* R6a instances are powered by 3rd generation AMD EPYC (Milan) processors delivering all-core turbo frequency of 3.6 GHz. C6id, M6id, and R6id instances are powered by 3rd generation Intel Xeon Scalable processor (Ice Lake) delivering all-core turbo frequency of 3.5 GHz.
* ForecastQueryService (3.7.1.0)
	* releasing What-If Analysis APIs
* ForecastService (3.7.11.0)
	* releasing What-If Analysis APIs and update ARN regex pattern to be more strict in accordance with security recommendation
* IoTSiteWise (3.7.13.0)
	* Enable non-unique asset names under different hierarchies
* LexModelsV2 (3.7.15.0)
	* This release introduces a new feature to stop a running BotRecommendation Job for Automated Chatbot Designer.
* SecurityHub (3.7.13.0)
	* Added new resource details objects to ASFF, including resources for AwsBackupBackupVault, AwsBackupBackupPlan and AwsBackupRecoveryPoint. Added FixAvailable, FixedInVersion and Remediation  to Vulnerability.
* SupportApp (3.7.0.0)
	* This is the initial SDK release for the AWS Support App in Slack.
* Core 3.7.12.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.339.0 (2022-08-19 18:21 UTC)
* Connect (3.7.23.0)
	* This release adds SearchSecurityProfiles API which can be used to search for Security Profile resources within a Connect Instance.
* Ivschat (3.7.0.45)
	* Documentation Change for IVS Chat API Reference - Doc-only update to change text/description for tags field.
* Kendra (3.7.25.0)
	* This release adds support for a new authentication type - Personal Access Token (PAT) for confluence server.
* LookoutMetrics (3.7.13.0)
	* This release is to make GetDataQualityMetrics API publicly available.
* Core 3.7.12.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.338.0 (2022-08-18 18:20 UTC)
* ChimeSDKMediaPipelines (3.7.1.0)
	* The Amazon Chime SDK now supports live streaming of real-time video from the Amazon Chime SDK sessions to streaming platforms such as Amazon IVS and Amazon Elemental MediaLive. We have also added support for concatenation to create a single media capture file.
* CloudWatch (3.7.7.0)
	* Add support for managed Contributor Insights Rules
* CognitoIdentityProvider (3.7.5.6)
	* This change is being made simply to fix the public documentation based on the models. We have included the PasswordChange and ResendCode events, along with the Pass, Fail and InProgress status. We have removed the Success and Failure status which are never returned by our APIs.
* DynamoDBv2 (3.7.4.0)
	* This release adds support for importing data from S3 into a new DynamoDB table
* EC2 (3.7.82.0)
	* This release adds support for VPN log options , a new feature allowing S2S VPN connections to send IKE activity logs to CloudWatch Logs
* NetworkManager (3.7.5.0)
	* Add TransitGatewayPeeringAttachmentId property to TransitGatewayPeering Model

### 3.7.337.0 (2022-08-17 18:25 UTC)
* AppMesh (3.7.3.0)
	* AWS App Mesh release to support Multiple Listener and Access Log Format feature
* ConnectCampaignService (3.7.1.0)
	* Updated exceptions for Amazon Connect Outbound Campaign api's.
* Kendra (3.7.24.0)
	* This release adds Zendesk connector (which allows you to specify Zendesk SAAS platform as data source), Proxy Support for Sharepoint and Confluence Server (which allows you to specify the proxy configuration if proxy is required to connect to your Sharepoint/Confluence Server as data source).
* LakeFormation (3.7.6.0)
	* This release adds a new API support "AssumeDecoratedRoleWithSAML" and also release updates the corresponding documentation.
* Lambda (3.7.14.0)
	* Added support for customization of Consumer Group ID for MSK and Kafka Event Source Mappings.
* LexModelsV2 (3.7.14.0)
	* This release introduces support for enhanced conversation design with the ability to define custom conversation flows with conditional branching and new bot responses.
* RDS (3.7.16.0)
	* Adds support for Internet Protocol Version 6 (IPv6) for RDS Aurora database clusters.
* SecretsManager (3.7.2.78)
	* Documentation updates for Secrets Manager.

### 3.7.336.0 (2022-08-16 18:17 UTC)
* Rekognition (3.7.10.0)
	* This release adds APIs which support copying an Amazon Rekognition Custom Labels model and managing project policies across AWS account.
* ServiceCatalog (3.7.2.51)
	* Documentation updates for Service Catalog
* Core 3.7.12.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.335.0 (2022-08-15 18:44 UTC)
* CloudFront (3.7.7.0)
	* Adds Http 3 support to distributions
* ConnectWisdomService (3.7.2.0)
	* This release introduces a new API PutFeedback that allows submitting feedback to Wisdom on content relevance.
* IdentityStore (3.7.0.194)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)
* SSO (3.7.0.193)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)

### 3.7.334.0 (2022-08-12 18:40 UTC)
* ChimeSDKMessaging (3.7.5.0)
	* The Amazon Chime SDK now supports channels with up to one million participants with elastic channels.
* IVS (3.7.5.0)
	* Updates various list api MaxResults ranges
* PersonalizeRuntime (3.7.2.0)
	* This release provides support for promotions in AWS Personalize runtime.
* PrometheusService (3.7.3.0)
	* This release adds log APIs that allow customers to manage logging for their Amazon Managed Service for Prometheus workspaces.
* RDS (3.7.15.9)
	* Adds support for RDS Custom to DBInstanceClass in ModifyDBInstance
* Core 3.7.12.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.333.0 (2022-08-11 18:35 UTC)
* BackupStorage (3.7.0.0)
	* This is the first public release of AWS Backup Storage. We are exposing some previously-internal APIs for use by external services. These APIs are not meant to be used directly by customers.
* Glue (3.7.23.0)
	* Add support for Python 3.9 AWS Glue Python Shell jobs
* Private5G (3.7.0.0)
	* This is the initial SDK release for AWS Private 5G. AWS Private 5G is a managed service that makes it easy to deploy, operate, and scale your own private mobile network at your on-premises location.
* Core 3.7.12.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.332.0 (2022-08-10 18:32 UTC)
* DLM (3.7.2.0)
	* This release adds support for excluding specific data (non-boot) volumes from multi-volume snapshot sets created by snapshot lifecycle policies
* EC2 (3.7.81.0)
	* This release adds support for excluding specific data (non-root) volumes from multi-volume snapshot sets created from instances.

### 3.7.331.0 (2022-08-09 18:19 UTC)
* AugmentedAIRuntime (3.7.1.0)
	* Fix bug with parsing ISO-8601 CreationTime in Java SDK in DescribeHumanLoop
* CloudWatch (3.7.6.0)
	* Various quota increases related to dimensions and custom metrics
* LocationService (3.7.11.0)
	* Amazon Location Service now allows circular geofences in BatchPutGeofence, PutGeofence, and GetGeofence  APIs.
* SageMaker (3.7.43.0)
	* Amazon SageMaker Automatic Model Tuning now supports specifying multiple alternate EC2 instance types to make tuning jobs more robust when the preferred instance type is not available due to insufficient capacity.

### 3.7.330.0 (2022-08-08 18:19 UTC)
* Glue (3.7.22.0)
	* Add an option to run non-urgent or non-time sensitive Glue Jobs on spare capacity
* IdentityStore (3.7.0.191)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)
* IoTWireless (3.7.12.0)
	* AWS IoT Wireless release support for sidewalk data reliability.
* Pinpoint (3.7.7.0)
	* Adds support for Advance Quiet Time in Journeys. Adds RefreshOnSegmentUpdate and WaitForQuietTime to JourneyResponse.
* QuickSight (3.7.12.13)
	* A series of documentation updates to the QuickSight API reference.
* SSO (3.7.0.190)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)
* SSOAdmin (3.7.1.8)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)
* SSOOIDC (3.7.0.190)
	* Documentation updates to reflect service rename - AWS IAM Identity Center (successor to AWS Single Sign-On)
* Core 3.7.12.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.329.0 (2022-08-04 18:14 UTC)
* ChimeSDKMeetings (3.7.10.0)
	* Adds support for Tags on Amazon Chime SDK WebRTC sessions
* ConfigService (3.7.12.0)
	* Add resourceType enums for Athena, GlobalAccelerator, Detective and EC2 types
* DatabaseMigrationService (3.7.9.13)
	* Documentation updates for Database Migration Service (DMS).
* IoT (3.7.17.0)
	* The release is to support attach a provisioning template to CACert for JITP function,  Customer now doesn't have to hardcode a roleArn and templateBody during register a CACert to enable JITP.
* Core 3.7.12.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.328.0 (2022-08-03 18:12 UTC)
* CognitoIdentityProvider (3.7.5.0)
	* Add a new exception type, ForbiddenException, that is returned when request is not allowed
* WAFV2 (3.7.13.0)
	* You can now associate an AWS WAF web ACL with an Amazon Cognito user pool.

### 3.7.327.0 (2022-08-02 18:13 UTC)
* LicenseManagerUserSubscriptions (3.7.0.0)
	* This release supports user based subscription for Microsoft Visual Studio Professional and Enterprise on EC2.
* Personalize (3.7.11.0)
	* This release adds support for incremental bulk ingestion for the Personalize CreateDatasetImportJob API.
* Core 3.7.12.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.326.0 (2022-08-01 18:15 UTC)
* ConfigService (3.7.11.3)
	* Documentation update for PutConfigRule and PutOrganizationConfigRule
* WorkSpaces (3.7.10.0)
	* This release introduces ModifySamlProperties, a new API that allows control of SAML properties associated with a WorkSpaces directory. The DescribeWorkspaceDirectories API will now additionally return SAML properties in its responses.

### 3.7.325.0 (2022-07-29 18:17 UTC)
* EC2 (3.7.80.0)
	* Documentation updates for Amazon EC2.
* FSx (3.7.13.24)
	* Documentation updates for Amazon FSx
* Shield (3.7.3.0)
	* AWS Shield Advanced now supports filtering for ListProtections and ListProtectionGroups.
* Core 3.7.12.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.324.0 (2022-07-28 18:17 UTC)
* EC2 (3.7.79.2)
	* Documentation updates for VM Import/Export.
* Elasticsearch (3.7.6.0)
	* This release adds support for gp3 EBS (Elastic Block Store) storage.
* LookoutforVision (3.7.4.0)
	* This release introduces support for image segmentation models and updates CPU accelerator options for models hosted on edge devices.
* OpenSearchService (3.7.5.0)
	* This release adds support for gp3 EBS (Elastic Block Store) storage.
* Core 3.7.12.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.323.0 (2022-07-27 18:59 UTC)
* AuditManager (3.7.11.0)
	* This release adds an exceeded quota exception to several APIs. We added a ServiceQuotaExceededException for the following operations: CreateAssessment, CreateControl, CreateAssessmentFramework, and UpdateAssessmentStatus.
* Chime (3.7.16.0)
	* Chime VoiceConnector will now support ValidateE911Address which will allow customers to prevalidate their addresses included in their SIP invites for emergency calling
* ConfigService (3.7.11.0)
	* This release adds ListConformancePackComplianceScores API to support the new compliance score feature, which provides a percentage of the number of compliant rule-resource combinations in a conformance pack compared to the number of total possible rule-resource combinations in the conformance pack.
* GlobalAccelerator (3.7.1.0)
	* Global Accelerator now supports dual-stack accelerators, enabling support for IPv4 and IPv6 traffic.
* MarketplaceCatalog (3.7.2.0)
	* The SDK for the StartChangeSet API will now automatically set and use an idempotency token in the ClientRequestToken request parameter if the customer does not provide it.
* Polly (3.7.7.0)
	* Amazon Polly adds new English and Hindi voice - Kajal. Kajal is available as Neural voice only.
* SimpleSystemsManagement (3.7.17.31)
	* Adding doc updates for OpsCenter support in Service Setting actions.
* WorkSpaces (3.7.9.0)
	* Added CreateWorkspaceImage API to create a new WorkSpace image from an existing WorkSpace.
* Core 3.7.12.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.322.1 (2022-07-26 22:51 UTC)
* S3 (3.7.9.31)
	* fix: ensure downloaded file path is always in target directory when using S3.IO.

### 3.7.322.0 (2022-07-26 18:19 UTC)
* AppSync (3.7.5.0)
	* Adds support for a new API to evaluate mapping templates with mock data, allowing you to remotely unit test your AppSync resolvers and functions.
* Detective (3.7.4.0)
	* Added the ability to get data source package information for the behavior graph. Graph administrators can now start (or stop) optional datasources on the behavior graph.
* GuardDuty (3.7.4.0)
	* Amazon GuardDuty introduces a new Malware Protection feature that triggers malware scan on selected EC2 instance resources, after the service detects a potentially malicious activity.
* LookoutforVision (3.7.3.0)
	* This release introduces support for the automatic scaling of inference units used by Amazon Lookout for Vision models.
* Macie2 (3.7.9.0)
	* This release adds support for retrieving (revealing) sample occurrences of sensitive data that Amazon Macie detects and reports in findings.
* RDS (3.7.15.1)
	* Adds support for using RDS Proxies with RDS for MariaDB databases.
* Rekognition (3.7.9.0)
	* This release introduces support for the automatic scaling of inference units used by Amazon Rekognition Custom Labels models.
* SecurityHub (3.7.12.12)
	* Documentation updates for AWS Security Hub
* Transfer (3.7.13.0)
	* AWS Transfer Family now supports Applicability Statement 2 (AS2), a network protocol used for the secure and reliable transfer of critical Business-to-Business (B2B) data over the public internet using HTTP/HTTPS as the transport mechanism.

### 3.7.321.2 (2022-07-25 18:17 UTC)
* AutoScaling (3.7.10.36)
	* Documentation update for Amazon EC2 Auto Scaling.

### 3.7.321.1 (2022-07-22 23:07 UTC)
* S3 (3.7.9.30)
	* Updated to use new Core, version 3.7.12.13
	* fix: ensure downloaded file path is always in target directory when using TransferUtility.
* Core 3.7.12.13
	* fix: ensure downloaded file path is always in target directory when using TransferUtility.

### 3.7.321.0 (2022-07-22 18:22 UTC)
* Account (3.7.1.0)
	* This release enables customers to manage the primary contact information for their AWS accounts. For more information, see https://docs.aws.amazon.com/accounts/latest/reference/API_Operations.html
* EC2 (3.7.79.0)
	* Added support for EC2 M1 Mac instances. For more information, please visit aws.amazon.com/mac.
* IoTDeviceAdvisor (3.7.3.0)
	* Added new service feature (Early access only) - Long Duration Test, where customers can test the IoT device to observe how it behaves when the device is in operation for longer period.
* MediaLive (3.7.11.0)
	* Link devices now support remote rebooting. Link devices now support maintenance windows. Maintenance windows allow a Link device to install software updates without stopping the MediaLive channel. The channel will experience a brief loss of input from the device while updates are installed.
* RDS (3.7.15.0)
	* This release adds the "ModifyActivityStream" API with support for audit policy state locking and unlocking.
* TranscribeService (3.7.14.0)
	* Remove unsupported language codes for StartTranscriptionJob and update VocabularyFileUri for UpdateMedicalVocabulary
* Core 3.7.12.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.320.0 (2022-07-21 18:20 UTC)
* Athena (3.7.9.0)
	* This feature allows customers to retrieve runtime statistics for completed queries
* CloudWatch (3.7.5.0)
	* Adding support for the suppression of Composite Alarm actions
* DatabaseMigrationService (3.7.9.7)
	* Documentation updates for Database Migration Service (DMS).
* DocDB (3.7.4.0)
	* Enable copy-on-write restore type
* EC2InstanceConnect (3.7.3.0)
	* This release includes a new exception type "EC2InstanceUnavailableException" for SendSSHPublicKey and SendSerialConsoleSSHPublicKey APIs.
* FraudDetector (3.7.7.0)
	* The release introduces Account Takeover Insights (ATI) model. The ATI model detects fraud relating to account takeover. This release also adds support for new variable types: ARE_CREDENTIALS_VALID and SESSION_ID and adds new structures to Model Version APIs.
* IoTSiteWise (3.7.12.0)
	* Added asynchronous API to ingest bulk historical and current data into IoT SiteWise.
* Kendra (3.7.23.0)
	* Amazon Kendra now provides Oauth2 support for SharePoint Online. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-sharepoint.html
* NetworkFirewall (3.7.5.0)
	* Network Firewall now supports referencing dynamic IP sets from stateful rule groups, for IP sets stored in Amazon VPC prefix lists.
* RDS (3.7.14.7)
	* Adds support for creating an RDS Proxy for an RDS for MariaDB database.

### 3.7.319.0 (2022-07-20 18:15 UTC)
* ACMPCA (3.7.4.46)
	* AWS Certificate Manager (ACM) Private Certificate Authority (PCA) documentation updates
* IoT (3.7.16.0)
	* GA release the ability to enable/disable IoT Fleet Indexing for Device Defender and Named Shadow information, and search them through IoT Fleet Indexing APIs. This includes Named Shadow Selection as a part of the UpdateIndexingConfiguration API.
* Core 3.7.12.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.318.0 (2022-07-19 18:13 UTC)
* DevOpsGuru (3.7.10.0)
	* Added new APIs for log anomaly detection feature.
* Glue (3.7.21.3)
	* Documentation updates for AWS Glue Job Timeout and Autoscaling
* SageMaker (3.7.42.0)
	* Fixed an issue with cross account QueryLineage
* SagemakerEdgeManager (3.7.1.0)
	* Amazon SageMaker Edge Manager provides lightweight model deployment feature to deploy machine learning models on requested devices.
* WorkSpaces (3.7.8.0)
	* Increased the character limit of the login message from 850 to 2000 characters.

### 3.7.317.1 (2022-07-19 14:27 UTC)
* S3 (3.7.9.27)
	* Added flag DisableSlashCorrection in TransferUtilityDownloadDirectoryRequest to determine if TransferUtility should ensure the S3Directory property has a trailing / for a virtual S3 directory.

### 3.7.317.0 (2022-07-18 18:22 UTC)
* ApplicationDiscoveryService (3.7.2.0)
	* Add AWS Agentless Collector details to the GetDiscoverySummary API response
* EC2 (3.7.78.2)
	* Documentation updates for Amazon EC2.
* ElastiCache (3.7.7.0)
	* Adding AutoMinorVersionUpgrade in the DescribeReplicationGroups API
* KeyManagementService (3.7.4.0)
	* Added support for the SM2 KeySpec in China Partition Regions
* MediaPackage (3.7.7.0)
	* This release adds "IncludeIframeOnlyStream" for Dash endpoints and increases the number of supported video and audio encryption presets for Speke v2
* SageMaker (3.7.41.0)
	* Amazon SageMaker Edge Manager provides lightweight model deployment feature to deploy machine learning models on requested devices.
* SSOAdmin (3.7.1.0)
	* AWS SSO now supports attaching customer managed policies and a permissions boundary to your permission sets. This release adds new API operations to manage and view the customer managed policies and the permissions boundary for a given permission set.
* Core 3.7.12.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.316.0 (2022-07-15 18:15 UTC)
* CloudWatchEvidently (3.7.3.0)
	* This release adds support for the new segmentation feature.
* DataSync (3.7.8.6)
	* Documentation updates for AWS DataSync regarding configuring Amazon FSx for ONTAP location security groups and SMB user permissions.
* Drs (3.7.2.0)
	* Changed existing APIs to allow choosing a dynamic volume type for replicating volumes, to reduce costs for customers.
* WAFV2 (3.7.12.0)
	* This SDK release provide customers ability to add sensitivity level for WAF SQLI Match Statements.
* Core 3.7.12.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.315.0 (2022-07-14 18:27 UTC)
* Athena (3.7.8.0)
	* This release updates data types that contain either QueryExecutionId, NamedQueryId or ExpectedBucketOwner. Ids must be between 1 and 128 characters and contain only non-whitespace characters. ExpectedBucketOwner must be 12-digit string.
* CodeArtifact (3.7.1.0)
	* This release introduces Package Origin Controls, a mechanism used to counteract Dependency Confusion attacks. Adds two new APIs, PutPackageOriginConfiguration and DescribePackage, and updates the ListPackage, DescribePackageVersion and ListPackageVersion APIs in support of the feature.
* ConfigService (3.7.10.0)
	* Update ResourceType enum with values for Route53Resolver, Batch, DMS, Workspaces, Stepfunctions, SageMaker, ElasticLoadBalancingV2, MSK types
* EC2 (3.7.78.0)
	* This release adds flow logs for Transit Gateway to  allow customers to gain deeper visibility and insights into network traffic through their Transit Gateways.
* FMS (3.7.7.0)
	* Adds support for strict ordering in stateful rule groups in Network Firewall policies.
* Glue (3.7.21.0)
	* This release adds an additional worker type for Glue Streaming jobs.
* Inspector2 (3.7.1.0)
	* This release adds support for Inspector V2 scan configurations through the get and update configuration APIs. Currently this allows configuring ECR automated re-scan duration to lifetime or 180 days or 30 days.
* Kendra (3.7.22.0)
	* This release adds AccessControlConfigurations which allow you to redefine your document level access control without the need for content re-indexing.
* NimbleStudio (3.7.5.0)
	* Amazon Nimble Studio adds support for IAM-based access to AWS resources for Nimble Studio components and custom studio components. Studio Component scripts use these roles on Nimble Studio workstation to mount filesystems, access S3 buckets, or other configured resources in the Studio's AWS account
* Outposts (3.7.11.0)
	* This release adds the ShipmentInformation and AssetInformationList fields to the GetOrder API response.
* SageMaker (3.7.40.0)
	* This release adds support for G5, P4d, and C6i instance types in Amazon SageMaker Inference and increases the number of hyperparameters that can be searched from 20 to 30 in Amazon SageMaker Automatic Model Tuning
* Core 3.7.12.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.314.0 (2022-07-13 19:12 UTC)
* AppConfig (3.7.2.0)
	* Adding Create, Get, Update, Delete, and List APIs for new two new resources: Extensions and ExtensionAssociations.

### 3.7.313.0 (2022-07-12 18:42 UTC)
* NetworkManager (3.7.4.0)
	* This release adds general availability API support for AWS Cloud WAN.
* Core 3.7.12.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.312.0 (2022-07-11 18:18 UTC)
* EC2 (3.7.77.0)
	* Build, manage, and monitor a unified global network that connects resources running across your cloud and on-premises environments using the AWS Cloud WAN APIs.
* Redshift (3.7.17.0)
	* This release adds a new --snapshot-arn field for describe-cluster-snapshots, describe-node-configuration-options, restore-from-cluster-snapshot, authorize-snapshot-acsess, and revoke-snapshot-acsess APIs. It allows customers to give a Redshift snapshot ARN or a Redshift Serverless ARN as input.
* RedshiftServerless (3.7.0.2)
	* Removed prerelease language for GA launch.
* Core 3.7.12.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.311.0 (2022-07-08 18:12 UTC)
* Backup (3.7.8.0)
	* This release adds support for authentication using IAM user identity instead of passed IAM role, identified by excluding the IamRoleArn field in the StartRestoreJob API. This feature applies to only resource clients with a destructive restore nature (e.g. SAP HANA).

### 3.7.310.0 (2022-07-07 18:16 UTC)
* ChimeSDKMeetings (3.7.9.0)
	* Adds support for AppKeys and TenantIds in Amazon Chime SDK WebRTC sessions
* DatabaseMigrationService (3.7.9.0)
	* New api to migrate event subscriptions to event bridge rules
* IoT (3.7.15.0)
	* This release adds support to register a CA certificate without having to provide a verification certificate. This also allows multiple AWS accounts to register the same CA in the same region.
* IoTWireless (3.7.11.0)
	* Adds 5 APIs: PutPositionConfiguration, GetPositionConfiguration, ListPositionConfigurations, UpdatePosition, GetPosition for the new Positioning Service feature which enables customers to configure solvers to calculate position of LoRaWAN devices, or specify position of LoRaWAN devices & gateways.
* SageMaker (3.7.39.0)
	* Heterogeneous clusters: the ability to launch training jobs with multiple instance types. This enables running component of the training job on the instance type that is most suitable for it. e.g. doing data processing and augmentation on CPU instances and neural network training on GPU instances

### 3.7.309.0 (2022-07-06 18:11 UTC)
* CloudFormation (3.7.11.0)
	* My AWS Service (placeholder) - Add a new feature Account-level Targeting for StackSet operation
* Synthetics (3.7.6.0)
	* This release introduces Group feature, which enables users to group cross-region canaries.

### 3.7.308.0 (2022-07-05 18:21 UTC)
* ConfigService (3.7.9.33)
	* Updating documentation service limits
* IAMRolesAnywhere (3.7.0.0)
	* IAM Roles Anywhere allows your workloads such as servers, containers, and applications to obtain temporary AWS credentials and use the same IAM roles and policies that you have configured for your AWS workloads to access AWS resources.
* LexModelsV2 (3.7.13.0)
	* This release introduces additional optional parameters "messageSelectionStrategy" to PromptSpecification, which enables the users to configure the bot to play messages in orderly manner.
* QuickSight (3.7.12.0)
	* This release allows customers to programmatically create QuickSight accounts with Enterprise and Enterprise + Q editions. It also releases allowlisting domains for embedding QuickSight dashboards at runtime through the embedding APIs.
* RDS (3.7.14.0)
	* Adds waiters support for DBCluster.
* SSMIncidents (3.7.6.0)
	* Adds support for tagging incident-record on creation by providing incident tags in the template within a response-plan.
* Core 3.7.12.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.307.0 (2022-07-01 18:12 UTC)
* DatabaseMigrationService (3.7.8.0)
	* Added new features for AWS DMS version 3.4.7 that includes new endpoint settings for S3, OpenSearch, Postgres, SQLServer and Oracle.
* RDS (3.7.13.27)
	* Adds support for additional retention periods to Performance Insights.

### 3.7.306.0 (2022-06-30 18:19 UTC)
* Athena (3.7.7.0)
	* This feature introduces the API support for Athena's parameterized query and BatchGetPreparedStatement API.
* CustomerProfiles (3.7.7.0)
	* This release adds the optional MinAllowedConfidenceScoreForMerging parameter to the CreateDomain, UpdateDomain, and GetAutoMergingPreview APIs in Customer Profiles. This parameter is used as a threshold to influence the profile auto-merging step of the Identity Resolution process.
* ElasticMapReduce (3.7.7.0)
	* This release adds support for the ExecutionRoleArn parameter in the AddJobFlowSteps and DescribeStep APIs. Customers can use ExecutionRoleArn to specify the IAM role used for each job they submit using the AddJobFlowSteps API.
* Glue (3.7.20.0)
	* This release adds tag as an input of CreateDatabase
* Kendra (3.7.21.0)
	* Amazon Kendra now provides a data source connector for alfresco
* MWAA (3.7.3.0)
	* Documentation updates for Amazon Managed Workflows for Apache Airflow.
* Pricing (3.7.3.0)
	* Documentation update for GetProducts Response.
* WellArchitected (3.7.4.0)
	* Added support for UpdateGlobalSettings API. Added status filter to ListWorkloadShares and ListLensShares.
* WorkMail (3.7.6.0)
	* This release adds support for managing user availability configurations in Amazon WorkMail.

### 3.7.305.0 (2022-06-29 18:20 UTC)
* AppStream (3.7.6.0)
	* Includes support for StreamingExperienceSettings in CreateStack and UpdateStack APIs
* ElasticLoadBalancingV2 (3.7.3.95)
	* This release adds two attributes for ALB. One, helps to preserve the host header and the other helps to modify, preserve, or remove the X-Forwarded-For header in the HTTP request.
* ElasticMapReduce (3.7.6.0)
	* This release introduces additional optional parameter "Throughput" to VolumeSpecification to enable user to configure throughput for gp3 ebs volumes.
* MediaLive (3.7.10.0)
	* This release adds support for automatic renewal of MediaLive reservations at the end of each reservation term. Automatic renewal is optional. This release also adds support for labelling accessibility-focused audio and caption tracks in HLS outputs.
* RedshiftServerless (3.7.0.0)
	* Add new API operations for Amazon Redshift Serverless, a new way of using Amazon Redshift without needing to manually manage provisioned clusters. The new operations let you interact with Redshift Serverless resources, such as create snapshots, list VPC endpoints, delete resource policies, and more.
* SageMaker (3.7.38.0)
	* This release adds: UpdateFeatureGroup, UpdateFeatureMetadata, DescribeFeatureMetadata APIs; FeatureMetadata type in Search API; LastModifiedTime, LastUpdateStatus, OnlineStoreTotalSizeBytes in DescribeFeatureGroup API.
* Translate (3.7.5.0)
	* Added ListLanguages API which can be used to list the languages supported by Translate.
* Core 3.7.12.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.304.0 (2022-06-28 18:14 UTC)
* DataSync (3.7.8.0)
	* AWS DataSync now supports Amazon FSx for NetApp ONTAP locations.
* EC2 (3.7.76.0)
	* This release adds a new spread placement group to EC2 Placement Groups: host level spread, which spread instances between physical hosts, available to Outpost customers only. CreatePlacementGroup and DescribePlacementGroups APIs were updated with a new parameter: SpreadLevel to support this feature.
* FinSpaceData (3.7.5.0)
	* Release new API GetExternalDataViewAccessDetails
* Polly (3.7.6.0)
	* Add 4 new neural voices - Pedro (es-US), Liam (fr-CA), Daniel (de-DE) and Arthur (en-GB).

### 3.7.303.0 (2022-06-27 18:12 UTC)
* IoT (3.7.14.0)
	* This release ease the restriction for the input of tag value to align with AWS standard, now instead of min length 1, we change it to min length 0.

### 3.7.302.0 (2022-06-24 18:18 UTC)
* Glue (3.7.19.0)
	* This release enables the new ListCrawls API for viewing the AWS Glue Crawler run history.
* RDSDataService (3.7.1.25)
	* Documentation updates for RDS Data API
* Core 3.7.12.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.301.0 (2022-06-23 18:18 UTC)
* LookoutEquipment (3.7.3.0)
	* This release adds visualizations to the scheduled inference results. Users will be able to see interference results, including diagnostic results from their running inference schedulers.
* MediaConvert (3.7.17.3)
	* AWS Elemental MediaConvert SDK has released support for automatic DolbyVision metadata generation when converting HDR10 to DolbyVision.
* Mgn (3.7.5.0)
	* New and modified APIs for the Post-Migration Framework
* MigrationHubRefactorSpaces (3.7.1.0)
	* This release adds the new API UpdateRoute that allows route to be updated to ACTIVE/INACTIVE state. In addition, CreateRoute API will now allow users to create route in ACTIVE/INACTIVE state.
* SageMaker (3.7.37.0)
	* SageMaker Ground Truth now supports Virtual Private Cloud. Customers can launch labeling jobs and access to their private workforce in VPC mode.

### 3.7.300.0 (2022-06-22 18:12 UTC)
* APIGateway (3.7.3.30)
	* Documentation updates for Amazon API Gateway
* Pricing (3.7.2.0)
	* This release introduces 1 update to the GetProducts API. The serviceCode attribute is now required when you use the GetProductsRequest.
* Transfer (3.7.12.0)
	* Until today, the service supported only RSA host keys and user keys. Now with this launch, Transfer Family has expanded the support for ECDSA and ED25519 host keys and user keys, enabling customers to support a broader set of clients by choosing RSA, ECDSA, and ED25519 host and user keys.

### 3.7.299.0 (2022-06-21 18:12 UTC)
* EC2 (3.7.75.0)
	* This release adds support for Private IP VPNs, a new feature allowing S2S VPN connections to use private ip addresses as the tunnel outside ip address over Direct Connect as transport.
* ECS (3.7.5.45)
	* Amazon ECS UpdateService now supports the following parameters: PlacementStrategies, PlacementConstraints and CapacityProviderStrategy.
* WellArchitected (3.7.3.0)
	* Adds support for lens tagging, Adds support for multiple helpful-resource urls and multiple improvement-plan urls.

### 3.7.298.0 (2022-06-20 18:12 UTC)
* DirectoryService (3.7.2.0)
	* This release adds support for describing and updating AWS Managed Microsoft AD settings
* Kafka (3.7.6.57)
	* Documentation updates to use Az Id during cluster creation.
* Outposts (3.7.10.0)
	* This release adds the AssetLocation structure to the ListAssets response. AssetLocation includes the RackElevation for an Asset.

### 3.7.297.0 (2022-06-17 19:15 UTC)
* Connect (3.7.22.0)
	* This release updates these APIs: UpdateInstanceAttribute, DescribeInstanceAttribute and ListInstanceAttributes. You can use it to programmatically enable/disable High volume outbound communications using attribute type HIGH_VOLUME_OUTBOUND on the specified Amazon Connect instance.
* ConnectCampaignService (3.7.0.0)
	* Added Amazon Connect high volume outbound communications SDK.
* DynamoDBv2 (3.7.3.50)
	* Doc only update for DynamoDB service
* Core 3.7.12.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.296.0 (2022-06-16 18:14 UTC)
* RedshiftDataAPIService (3.7.6.0)
	* This release adds a new --workgroup-name field to operations that connect to an endpoint. Customers can now execute queries against their serverless workgroups.
* SecretsManager (3.7.2.57)
	* Documentation updates for Secrets Manager
* SecurityHub (3.7.12.0)
	* Added Threats field for security findings. Added new resource details for ECS Container, ECS Task, RDS SecurityGroup, Kinesis Stream, EC2 TransitGateway, EFS AccessPoint, CloudFormation Stack, CloudWatch Alarm, VPC Peering Connection and WAF Rules
* Core 3.7.12.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.295.0 (2022-06-15 19:36 UTC)
* AppRegistry (3.7.3.0)
	* This release adds a new API ListAttributeGroupsForApplication that returns associated attribute groups of an application. In addition, the UpdateApplication and UpdateAttributeGroup APIs will not allow users to update the 'Name' attribute.
* FinSpaceData (3.7.4.0)
	* This release adds a new set of APIs, GetPermissionGroup, DisassociateUserFromPermissionGroup, AssociateUserToPermissionGroup, ListPermissionGroupsByUser, ListUsersByPermissionGroup.
* GuardDuty (3.7.3.0)
	* Adds finding fields available from GuardDuty Console. Adds FreeTrial related operations. Deprecates the use of various APIs related to Master Accounts and Replace them with Administrator Accounts.
* WorkSpaces (3.7.7.0)
	* Added new field "reason" to OperationNotSupportedException. Receiving this exception in the DeregisterWorkspaceDirectory API will now return a reason giving more context on the failure.

### 3.7.294.0 (2022-06-14 18:30 UTC)
* Budgets (3.7.3.0)
	* Add a budgets ThrottlingException. Update the CostFilters value pattern.
* LookoutMetrics (3.7.12.0)
	* Adding filters to Alert and adding new UpdateAlert API.
* MediaConvert (3.7.17.0)
	* AWS Elemental MediaConvert SDK has added support for rules that constrain Automatic-ABR rendition selection when generating ABR package ladders.

### 3.7.293.0 (2022-06-14 14:03 UTC)
* DynamoDBv2 (3.7.3.48)
	* DynamoDB Streams doc update
* Core 3.7.12.0
	* Added support for recursion detection.
	* All services packages updated to require new Core

### 3.7.292.0 (2022-06-13 18:52 UTC)
* Outposts (3.7.9.0)
	* This release adds API operations AWS uses to install Outpost servers.

### 3.7.291.1 (2022-06-10 18:42 UTC)
* FraudDetector (3.7.6.53)
	* Documentation updates for Amazon Fraud Detector (AWSHawksNest)
* Core 3.7.11.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.291.0 (2022-06-09 20:22 UTC)
* ChimeSDKMeetings (3.7.8.0)
	* Adds support for live transcription in AWS GovCloud (US) Regions.

### 3.7.290.0 (2022-06-08 19:55 UTC)
* DatabaseMigrationService (3.7.7.0)
	* This release adds DMS Fleet Advisor APIs and exposes functionality for DMS Fleet Advisor. It adds functionality to create and modify fleet advisor instances, and to collect and analyze information about the local data infrastructure.
* IdentityManagement (3.7.2.150)
	* Documentation updates for AWS Identity and Access Management (IAM).
* MainframeModernization (3.7.0.0)
	* AWS Mainframe Modernization service is a managed mainframe service and set of tools for planning, migrating, modernizing, and running mainframe workloads on AWS
* Neptune (3.7.3.0)
	* This release adds support for Neptune to be configured as a global database, with a primary DB cluster in one region, and up to five secondary DB clusters in other regions.
* Redshift (3.7.16.0)
	* Adds new API GetClusterCredentialsWithIAM to return temporary credentials.
* Core 3.7.11.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.289.0 (2022-06-07 18:13 UTC)
* AuditManager (3.7.10.0)
	* This release introduces 2 updates to the Audit Manager API. The roleType and roleArn attributes are now required when you use the CreateAssessment or UpdateAssessment operation. We also added a throttling exception to the RegisterAccount API operation.
* CostExplorer (3.7.6.0)
	* Added two new APIs to support cost allocation tags operations: ListCostAllocationTags, UpdateCostAllocationTagsStatus.
* Core 3.7.11.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.288.0 (2022-06-06 18:53 UTC)
* ChimeSDKMessaging (3.7.4.0)
	* This release adds support for searching channels by members via the SearchChannels API, removes required restrictions for Name and Mode in UpdateChannel API and enhances CreateChannel API by exposing member and moderator list as well as channel id as optional parameters.
* Connect (3.7.21.0)
	* This release adds a new API, GetCurrentUserData, which returns real-time details about users' current activity.
* Core 3.7.11.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.287.0 (2022-06-02 18:23 UTC)
* ApplicationInsights (3.7.3.0)
	* Provide Account Level onboarding support through CFN/CLI
* CodeArtifact (3.7.0.168)
	* Documentation updates for CodeArtifact
* Connect (3.7.20.0)
	* This release adds the following features: 1) New APIs to manage (create, list, update) task template resources, 2) Updates to startTaskContact API to support task templates, and 3) new TransferContact API to programmatically transfer in-progress tasks via a contact flow.
* Kendra (3.7.20.0)
	* Amazon Kendra now provides a data source connector for GitHub. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-github.html
* Proton (3.7.4.0)
	* Add new "Components" API to enable users to Create, Delete and Update AWS Proton components.
* VoiceID (3.7.2.0)
	* Added a new attribute ServerSideEncryptionUpdateDetails to Domain and DomainSummary.

### 3.7.286.0 (2022-06-01 19:16 UTC)
* BackupGateway (3.7.1.0)
	* Adds GetGateway and UpdateGatewaySoftwareNow API and adds hypervisor name to UpdateHypervisor API
* ChimeSDKMeetings (3.7.7.0)
	* Adds support for centrally controlling each participant's ability to send and receive audio, video and screen share within a WebRTC session.  Attendee capabilities can be specified when the attendee is created and updated during the session with the new BatchUpdateAttendeeCapabilitiesExcept API.
* ForecastService (3.7.10.0)
	* Added Format field to Import and Export APIs in Amazon Forecast. Added TimeSeriesSelector to Create Forecast API.
* Route53 (3.7.3.0)
	* Add new APIs to support Route 53 IP Based Routing

### 3.7.285.0 (2022-05-31 18:47 UTC)
* CognitoIdentityProvider (3.7.4.0)
	* Amazon Cognito now supports IP Address propagation for all unauthenticated APIs (e.g. SignUp, ForgotPassword).
* Drs (3.7.1.0)
	* Changed existing APIs and added new APIs to accommodate using multiple AWS accounts with AWS Elastic Disaster Recovery.
* IoTSiteWise (3.7.11.0)
	* This release adds the following new optional field to the IoT SiteWise asset resource: assetDescription.
* LookoutMetrics (3.7.11.0)
	* Adding backtest mode to detectors using the Cloudwatch data source.
* SageMaker (3.7.36.0)
	* Amazon SageMaker Notebook Instances now support Jupyter Lab 3.
* TranscribeService (3.7.13.0)
	* Amazon Transcribe now supports automatic language identification for multi-lingual audio in batch mode.
* Core 3.7.11.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.284.0 (2022-05-27 18:15 UTC)
* Appflow (3.7.9.0)
	* Adding the following features/changes: Parquet output that preserves typing from the source connector, Failed executions threshold before deactivation for scheduled flows, increasing max size of access and refresh token from 2048 to 4096
* DataSync (3.7.7.0)
	* AWS DataSync now supports TLS encryption in transit, file system policies and access points for EFS locations.
* EMRServerless (3.7.0.0)
	* This release adds support for Amazon EMR Serverless, a serverless runtime environment that simplifies running analytics applications using the latest open source frameworks such as Apache Spark and Apache Hive.
* SageMaker (3.7.35.0)
	* Amazon SageMaker Notebook Instances now allows configuration of Instance Metadata Service version and Amazon SageMaker Studio now supports G5 instance types.
* Core 3.7.11.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.283.0 (2022-05-26 18:15 UTC)
* EC2 (3.7.74.0)
	* C7g instances, powered by the latest generation AWS Graviton3 processors, provide the best price performance in Amazon EC2 for compute-intensive workloads.
* ForecastService (3.7.9.0)
	* Introduced a new field in Auto Predictor as Time Alignment Boundary. It helps in aligning the timestamps generated during Forecast exports
* Lightsail (3.7.9.0)
	* Amazon Lightsail now supports the ability to configure a Lightsail Container Service to pull images from Amazon ECR private repositories in your account.
* Core 3.7.11.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.282.1 (2022-05-26 14:17 UTC)
* S3 (3.7.9.8)
	* Added support for S3 schemed URI in AmazonS3Uri class.
* Core 3.7.11.8
	* Correct fallback logic for STS region when using AssumeRoleWithWebIdentityCredentials; Change IMDS credential refresh window to 5-10 minutes. Adjust refresh strategy to immediately refresh the first time expired IMDS credentials are encountered.
	* All services packages updated to require new Core

### 3.7.282.0 (2022-05-25 18:20 UTC)
* APIGateway (3.7.3.18)
	* Documentation updates for Amazon API Gateway
* AppRunner (3.7.4.17)
	* Documentation-only update added for CodeConfiguration.
* CloudFormation (3.7.10.0)
	* Add a new parameter statusReason to DescribeStackSetOperation output for additional details
* FSx (3.7.13.0)
	* This release adds root squash support to FSx for Lustre to restrict root level access from clients by mapping root users to a less-privileged user/group with limited permissions.
* LookoutMetrics (3.7.10.0)
	* Adding AthenaSourceConfig for MetricSet APIs to support Athena as a data source.
* SageMaker (3.7.34.0)
	* Amazon SageMaker Autopilot adds support for manually selecting features from the input dataset using the CreateAutoMLJob API.
* SecretsManager (3.7.2.47)
	* Documentation updates for Secrets Manager
* VoiceID (3.7.1.0)
	* VoiceID will now automatically expire Speakers if they haven't been accessed for Enrollment, Re-enrollment or Successful Auth for three years. The Speaker APIs now return a "LastAccessedAt" time for Speakers, and the EvaluateSession API returns "SPEAKER_EXPIRED" Auth Decision for EXPIRED Speakers.
* Core 3.7.11.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.281.0 (2022-05-24 18:15 UTC)
* CognitoIdentityProvider (3.7.3.0)
	* Amazon Cognito now supports requiring attribute verification (ex. email and phone number) before update.
* EC2 (3.7.73.0)
	* Stop Protection feature enables customers to protect their instances from accidental stop actions.
* Ivschat (3.7.0.13)
	* Doc-only update. For MessageReviewHandler structure, added timeout period in the description of the fallbackResult field
* MediaConvert (3.7.16.0)
	* AWS Elemental MediaConvert SDK has added support for rules that constrain Automatic-ABR rendition selection when generating ABR package ladders.
* NetworkManager (3.7.3.0)
	* This release adds Multi Account API support for a TGW Global Network, to enable and disable AWSServiceAccess with AwsOrganizations for Network Manager service and dependency CloudFormation StackSets service.
* Core 3.7.11.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.280.0 (2022-05-23 18:15 UTC)
* ElastiCache (3.7.6.0)
	* Added support for encryption in transit for Memcached clusters. Customers can now launch Memcached cluster with encryption in transit enabled when using Memcached version 1.6.12 or later.
* ForecastService (3.7.8.0)
	* New APIs for Monitor that help you understand how your predictors perform over time.
* Personalize (3.7.10.0)
	* Adding modelMetrics as part of DescribeRecommender API response for Personalize.
* Core 3.7.11.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.279.0 (2022-05-20 18:22 UTC)
* CloudWatchLogs (3.7.2.55)
	* Doc-only update to publish the new valid values for log retention
* Comprehend (3.7.7.0)
	* Comprehend releases 14 new entity types for DetectPiiEntities and ContainsPiiEntities APIs.

### 3.7.278.0 (2022-05-19 18:27 UTC)
* GameSparks (3.7.1.0)
	* This release adds an optional DeploymentResult field in the responses of GetStageDeploymentIntegrationTests and ListStageDeploymentIntegrationTests APIs.
* LookoutMetrics (3.7.9.0)
	* In this release we added SnsFormat to SNSConfiguration to support human readable alert.
* Core 3.7.11.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.277.0 (2022-05-18 18:15 UTC)
* AppMesh (3.7.2.0)
	* This release updates the existing Create and Update APIs for meshes and virtual nodes by adding a new IP preference field. This new IP preference field can be used to control the IP versions being used with the mesh and allows for IPv6 support within App Mesh.
* Batch (3.7.5.11)
	* Documentation updates for AWS Batch.
* GreengrassV2 (3.7.5.0)
	* This release adds the new DeleteDeployment API operation that you can use to delete deployment resources. This release also adds support for discontinued AWS-provided components, so AWS can communicate when a component has any issues that you should consider before you deploy it.
* IoTEventsData (3.7.2.0)
	* Introducing new API for deleting detectors: BatchDeleteDetector.
* QuickSight (3.7.11.0)
	* API UpdatePublicSharingSettings enables IAM admins to enable/disable account level setting for public access of dashboards. When enabled, owners/co-owners for dashboards can enable public access on their dashboards. These dashboards can only be accessed through share link or embedding.
* Transfer (3.7.11.0)
	* AWS Transfer Family now supports SetStat server configuration option, which provides the ability to ignore SetStat command issued by file transfer clients, enabling customers to upload files without any errors.
* Core 3.7.11.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.276.0 (2022-05-17 18:11 UTC)
* Glue (3.7.18.0)
	* This release adds a new optional parameter called codeGenNodeConfiguration to CRUD job APIs that allows users to manage visual jobs via APIs. The updated CreateJob and UpdateJob will create jobs that can be viewed in Glue Studio as a visual graph. GetJob can be used to get codeGenNodeConfiguration.
* KeyManagementService (3.7.3.10)
	* Add HMAC best practice tip, annual rotation of AWS managed keys.

### 3.7.275.0 (2022-05-16 18:15 UTC)
* ApplicationDiscoveryService (3.7.1.0)
	* Add Migration Evaluator Collector details to the GetDiscoverySummary API response
* CloudFront (3.7.6.0)
	* Introduced a new error (TooLongCSPInResponseHeadersPolicy) that is returned when the value of the Content-Security-Policy header in a response headers policy exceeds the maximum allowed length.
* Rekognition (3.7.8.9)
	* Documentation updates for Amazon Rekognition.
* ResilienceHub (3.7.1.0)
	* In this release, we are introducing support for Amazon Elastic Container Service, Amazon Route 53, AWS Elastic Disaster Recovery, AWS Backup in addition to the existing supported Services.  This release also supports Terraform file input from S3 and scheduling daily assessments
* SecurityToken (3.7.1.151)
	* Documentation updates for AWS Security Token Service.
* ServiceCatalog (3.7.2.16)
	* Updated the descriptions for the ListAcceptedPortfolioShares API description and the PortfolioShareType parameters.
* WorkSpacesWeb (3.7.1.0)
	* Amazon WorkSpaces Web now supports Administrator timeout control

### 3.7.274.0 (2022-05-13 18:13 UTC)
* ManagedGrafana (3.7.2.0)
	* This release adds APIs for creating and deleting API keys in an Amazon Managed Grafana workspace.

### 3.7.273.0 (2022-05-12 18:22 UTC)
* EC2 (3.7.72.0)
	* This release introduces a target type Gateway Load Balancer Endpoint for mirrored traffic. Customers can now specify GatewayLoadBalancerEndpoint option during the creation of a traffic mirror target.
* FinSpaceData (3.7.3.29)
	* We've now deprecated CreateSnapshot permission for creating a data view, instead use CreateDataView permission.
* IoT (3.7.13.4)
	* Documentation update for China region ListMetricValues for IoT
* Ivschat (3.7.0.9)
	* Documentation-only updates for IVS Chat API Reference.
* Kendra (3.7.19.0)
	* Amazon Kendra now provides a data source connector for Jira. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-jira.html
* Lambda (3.7.13.0)
	* Lambda releases NodeJs 16 managed runtime to be available in all commercial regions.
* Lightsail (3.7.8.0)
	* This release adds support to include inactive database bundles in the response of the GetRelationalDatabaseBundles request.
* Outposts (3.7.8.8)
	* Documentation updates for AWS Outposts.
* SSMIncidents (3.7.5.0)
	* Adding support for dynamic SSM Runbook parameter values. Updating validation pattern for engagements. Adding ConflictException to UpdateReplicationSet API contract.
* Transfer (3.7.10.24)
	* AWS Transfer Family now accepts ECDSA keys for server host keys
* WorkSpaces (3.7.6.0)
	* Increased the character limit of the login message from 600 to 850 characters.

### 3.7.272.0 (2022-05-11 18:13 UTC)
* EC2 (3.7.71.0)
	* This release updates AWS PrivateLink APIs to support IPv6 for PrivateLink Services and Endpoints of type 'Interface'.
* SecretsManager (3.7.2.42)
	* Doc only update for Secrets Manager that fixes several customer-reported issues.

### 3.7.271.0 (2022-05-10 18:14 UTC)
* ComputeOptimizer (3.7.5.46)
	* Documentation updates for Compute Optimizer
* EC2 (3.7.70.0)
	* Added support for using NitroTPM and UEFI Secure Boot on EC2 instances.
* EKS (3.7.14.0)
	* Adds BOTTLEROCKET_ARM_64_NVIDIA and BOTTLEROCKET_x86_64_NVIDIA AMI types to EKS managed nodegroups
* ElasticMapReduce (3.7.5.0)
	* This release updates the Amazon EMR ModifyInstanceGroups API to support "MERGE" type cluster reconfiguration. Also, added the ability to specify a particular Amazon Linux release for all nodes in a cluster launch request.
* MigrationHubRefactorSpaces (3.7.0.57)
	* AWS Migration Hub Refactor Spaces documentation only update to fix a formatting issue.

### 3.7.270.0 (2022-05-09 18:14 UTC)
* CloudControlApi (3.7.2.0)
	* SDK release for Cloud Control API to include paginators for Python SDK.
* CloudWatchEvidently (3.7.2.0)
	* Add detail message inside GetExperimentResults API response to indicate experiment result availability
* SSMContacts (3.7.2.111)
	* Fixed an error in the DescribeEngagement example for AWS Incident Manager.
* Core 3.7.11.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.269.0 (2022-05-06 18:16 UTC)
* EC2 (3.7.69.0)
	* Add new state values for IPAMs, IPAM Scopes, and IPAM Pools.
* LocationService (3.7.10.0)
	* Amazon Location Service now includes a MaxResults parameter for ListGeofences requests.
* MediaPackage (3.7.6.0)
	* This release adds Dvb Dash 2014 as an available profile option for Dash Origin Endpoints.
* RDS (3.7.13.7)
	* Various documentation improvements.
* Redshift (3.7.15.0)
	* Introduces new field 'LoadSampleData' in CreateCluster operation. Customers can now specify 'LoadSampleData' option during creation of a cluster, which results in loading of sample data in the cluster that is created.
* SecurityHub (3.7.11.7)
	* Documentation updates for Security Hub API reference
* Core 3.7.11.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.268.0 (2022-05-06 13:31 UTC)
* S3 (3.7.9.0)
	* Added ability in TransferUtility to specify ObjectLock settings for upload requests; Add SSE-C properties to TransferUtilityUploadDirectoryRequest
* Core 3.7.11.0
	* Update unmarshallers to use XmlTextReader
	* All services packages updated to require new Core

### 3.7.267.0 (2022-05-05 18:41 UTC)
* DataSync (3.7.6.0)
	* AWS DataSync now supports a new ObjectTags Task API option that can be used to control whether Object Tags are transferred.
* EC2 (3.7.68.0)
	* Amazon EC2 I4i instances are powered by 3rd generation Intel Xeon Scalable processors and feature up to 30 TB of local AWS Nitro SSD storage
* IoT (3.7.13.0)
	* AWS IoT Jobs now allows you to create up to 100,000 active continuous and snapshot jobs by using concurrency control.
* Kendra (3.7.18.0)
	* AWS Kendra now supports hierarchical facets for a query. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/filtering.html
* Core 3.7.10.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.266.0 (2022-05-04 18:17 UTC)
* Backup (3.7.7.0)
	* Adds support to 2 new filters about job complete time for 3 list jobs APIs in AWS Backup
* IoTSecureTunneling (3.7.1.0)
	* This release introduces a new API RotateTunnelAccessToken that allow revoking the existing tokens and generate new tokens
* Lightsail (3.7.7.4)
	* Documentation updates for Lightsail
* SimpleSystemsManagement (3.7.17.0)
	* This release adds the TargetMaps parameter in SSM State Manager API.
* Core 3.7.10.15
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.265.0 (2022-05-03 21:11 UTC)
* EC2 (3.7.67.0)
	* Adds support for allocating Dedicated Hosts on AWS  Outposts. The AllocateHosts API now accepts an OutpostArn request  parameter, and the DescribeHosts API now includes an OutpostArn response parameter.
* KinesisVideo (3.7.1.0)
	* Add support for multiple image feature related APIs for configuring image generation and notification of a video stream. Add "GET_IMAGES" to the list of supported API names for the GetDataEndpoint API.
* KinesisVideoArchivedMedia (3.7.1.0)
	* Add support for GetImages API  for retrieving images from a video stream
* S3 (3.7.8.26)
	* Documentation only update for doc bug fixes for the S3 API docs.
* SageMaker (3.7.33.0)
	* SageMaker Autopilot adds new metrics for all candidate models generated by Autopilot experiments; RStudio on SageMaker now allows users to bring your own development environment in a custom image.
* Core 3.7.10.14
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.264.1 (2022-05-03 00:01 UTC)
* Core 3.7.10.13
	* Fix issue with Service URL property adding trailing slash on URL with resource paths causing signature mismatch errors.
	* All services packages updated to require new Core

### 3.7.264.0 (2022-05-02 18:14 UTC)
* Organizations (3.7.2.0)
	* This release adds the INVALID_PAYMENT_INSTRUMENT as a fail reason and an error message.
* Outposts (3.7.8.0)
	* This release adds a new API called ListAssets to the Outposts SDK, which lists the hardware assets in an Outpost.
* Synthetics (3.7.5.0)
	* CloudWatch Synthetics has introduced a new feature to provide customers with an option to delete the underlying resources that Synthetics canary creates when the user chooses to delete the canary.
* Core 3.7.10.12
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.263.0 (2022-04-29 18:13 UTC)
* CodeGuruReviewer (3.7.6.0)
	* Amazon CodeGuru Reviewer now supports suppressing recommendations from being generated on specific files and directories.
* MediaConvert (3.7.15.0)
	* AWS Elemental MediaConvert SDK nows supports creation of Dolby Vision profile 8.1, the ability to generate black frames of video, and introduces audio-only DASH and CMAF support.
* RDS (3.7.13.0)
	* Feature - Adds support for Internet Protocol Version 6 (IPv6) on RDS database instances.
* SimpleSystemsManagement (3.7.16.0)
	* Update the StartChangeRequestExecution, adding TargetMaps to the Runbook parameter
* WAFV2 (3.7.11.0)
	* You can now inspect all request headers and all cookies. You can now specify how to handle oversize body contents in your rules that inspect the body.

### 3.7.262.0 (2022-04-28 18:17 UTC)
* AuditManager (3.7.9.12)
	* This release adds documentation updates for Audit Manager. We provided examples of how to use the Custom_ prefix for the keywordValue attribute. We also provided more details about the DeleteAssessmentReport operation.
* Braket (3.7.3.0)
	* This release enables Braket Hybrid Jobs with Embedded Simulators to have multiple instances.
* Connect (3.7.19.0)
	* This release introduces an API for changing the current agent status of a user in Connect.
* EC2 (3.7.66.0)
	* This release adds support to query the public key and creation date of EC2 Key Pairs. Additionally, the format (pem or ppk) of a key pair can be specified when creating a new key pair.
* GuardDuty (3.7.2.33)
	* Documentation update for API description.
* NetworkFirewall (3.7.4.0)
	* AWS Network Firewall adds support for stateful threat signature AWS managed rule groups.

### 3.7.261.0 (2022-04-27 18:19 UTC)
* Amplify (3.7.1.21)
	* Documentation only update to support the Amplify GitHub App feature launch
* ChimeSDKMediaPipelines (3.7.0.0)
	* For Amazon Chime SDK meetings, the Amazon Chime Media Pipelines SDK allows builders to capture audio, video, and content share streams. You can also capture meeting events, live transcripts, and data messages. The pipelines save the artifacts to an Amazon S3 bucket that you designate.
* CloudTrail (3.7.4.0)
	* Increases the retention period maximum to 2557 days. Deprecates unused fields of the ListEventDataStores API response. Updates documentation.
* IoTWireless (3.7.10.0)
	* Add list support for event configurations, allow to get and update event configurations by resource type, support LoRaWAN events; Make NetworkAnalyzerConfiguration as a resource, add List, Create, Delete API support; Add FCntStart attribute support for ABP WirelessDevice.
* LookoutEquipment (3.7.2.0)
	* This release adds the following new features: 1) Introduces an option for automatic schema creation 2) Now allows for Ingestion of data containing most common errors and allows automatic data cleaning 3) Introduces new API ListSensorStatistics that gives further information about the ingested data
* Rekognition (3.7.8.0)
	* This release adds support to configure stream-processor resources for label detections on streaming-videos. UpateStreamProcessor API is also launched with this release, which could be used to update an existing stream-processor.
* SageMaker (3.7.32.0)
	* Amazon SageMaker Autopilot adds support for custom validation dataset and validation ratio through the CreateAutoMLJob and DescribeAutoMLJob APIs.

### 3.7.260.0 (2022-04-26 18:20 UTC)
* CloudFront (3.7.5.0)
	* CloudFront now supports the Server-Timing header in HTTP responses sent from CloudFront. You can use this header to view metrics that help you gain insights about the behavior and performance of CloudFront. To use this header, enable it in a response headers policy.
* Glue (3.7.17.1)
	* This release adds documentation for the APIs to create, read, delete, list, and batch read of AWS Glue custom patterns, and for Lake Formation configuration settings in the AWS Glue crawler.
* Ivschat (3.7.0.0)
	* Adds new APIs for IVS Chat, a feature for building interactive chat experiences alongside an IVS broadcast.
* Lightsail (3.7.7.0)
	* This release adds support for Lightsail load balancer HTTP to HTTPS redirect and TLS policy configuration.
* NetworkFirewall (3.7.3.0)
	* AWS Network Firewall now enables customers to use a customer managed AWS KMS key for the encryption of their firewall resources.
* Pricing (3.7.1.147)
	* Documentation updates for Price List API
* SageMaker (3.7.31.0)
	* SageMaker Inference Recommender now accepts customer KMS key ID for encryption of endpoints and compilation outputs created during inference recommendation.

### 3.7.259.0 (2022-04-25 18:15 UTC)
* Connect (3.7.18.0)
	* This release adds SearchUsers API which can be used to search for users with a Connect Instance
* GameLift (3.7.1.66)
	* Documentation updates for Amazon GameLift.
* MQ (3.7.2.0)
	* This release adds the CRITICAL_ACTION_REQUIRED broker state and the ActionRequired API property. CRITICAL_ACTION_REQUIRED informs you when your broker is degraded. ActionRequired provides you with a code which you can use to find instructions in the Developer Guide on how to resolve the issue.
* RDSDataService (3.7.1.0)
	* Support to receive SQL query results in the form of a simplified JSON string. This enables developers using the new JSON string format to more easily convert it to an object using popular JSON string parsing libraries.
* SecurityHub (3.7.11.0)
	* Security Hub now lets you opt-out of auto-enabling the defaults standards (CIS and FSBP) in accounts that are auto-enabled with Security Hub via Security Hub's integration with AWS Organizations.

### 3.7.258.0 (2022-04-22 18:17 UTC)
* ChimeSDKMeetings (3.7.6.0)
	* Include additional exceptions types.
* EC2 (3.7.65.0)
	* Adds support for waiters that automatically poll for a deleted NAT Gateway until it reaches the deleted state.

### 3.7.257.0 (2022-04-21 18:19 UTC)
* ConnectWisdomService (3.7.1.0)
	* This release updates the GetRecommendations API to include a trigger event list for classifying and grouping recommendations.
* ElastiCache (3.7.5.37)
	* Doc only update for ElastiCache
* Glue (3.7.17.0)
	* This release adds APIs to create, read, delete, list, and batch read of Glue custom entity types
* IoTSiteWise (3.7.10.0)
	* This release adds 3 new batch data query APIs : BatchGetAssetPropertyValue, BatchGetAssetPropertyValueHistory and BatchGetAssetPropertyAggregates
* IoTTwinMaker (3.7.2.0)
	* General availability (GA) for AWS IoT TwinMaker. For more information, see https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/Welcome.html
* LookoutMetrics (3.7.8.0)
	* Added DetectMetricSetConfig API for detecting configuration required for creating metric set from provided S3 data source.
* MediaTailor (3.7.9.0)
	* This release introduces tiered channels and adds support for live sources. Customers using a STANDARD channel can now create programs using live sources.
* SecretsManager (3.7.2.33)
	* Documentation updates for Secrets Manager
* StorageGateway (3.7.5.0)
	* This release adds support for minimum of 5 character length virtual tape barcodes.

### 3.7.256.0 (2022-04-20 18:16 UTC)
* Connect (3.7.17.0)
	* This release adds APIs to search, claim, release, list, update, and describe phone numbers. You can also use them to associate and disassociate contact flows to phone numbers.
* Macie2 (3.7.8.0)
	* Sensitive data findings in Amazon Macie now indicate how Macie found the sensitive data that produced a finding (originType).
* Mgn (3.7.4.0)
	* Removed required annotation from input fields in Describe operations requests. Added quotaValue to ServiceQuotaExceededException
* RDS (3.7.12.0)
	* Added a new cluster-level attribute to set the capacity range for Aurora Serverless v2 instances.
* Core 3.7.10.11
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.255.0 (2022-04-19 18:21 UTC)
* AutoScaling (3.7.10.0)
	* EC2 Auto Scaling now adds default instance warm-up times for all scaling activities, health check replacements, and other replacement events in the Auto Scaling instance lifecycle.
* Kendra (3.7.17.0)
	* Amazon Kendra now provides a data source connector for Quip. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-quip.html
* KeyManagementService (3.7.3.0)
	* Adds support for KMS keys and APIs that generate and verify HMAC codes
* Personalize (3.7.9.0)
	* Adding StartRecommender and StopRecommender APIs for Personalize.
* Polly (3.7.5.0)
	* Amazon Polly adds new Austrian German voice - Hannah. Hannah is available as Neural voice only.
* Redshift (3.7.14.0)
	* Introduces new fields for LogDestinationType and LogExports on EnableLogging requests and Enable/Disable/DescribeLogging responses. Customers can now select CloudWatch Logs as a destination for their Audit Logs.
* SimpleSystemsManagement (3.7.15.0)
	* Added offset support for specifying the number of days to wait after the date and time specified by a CRON expression when creating SSM association.
* Textract (3.7.5.0)
	* This release adds support for specifying and extracting information from documents using the Queries feature within Analyze Document API
* Transfer (3.7.10.14)
	* This release contains corrected HomeDirectoryMappings examples for several API functions: CreateAccess, UpdateAccess, CreateUser, and UpdateUser,.
* WorkLink (3.7.1.0)
	* Amazon WorkLink is no longer supported. This will be removed in a future version of the SDK.
* Core 3.7.10.10
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.254.1 (2022-04-19 14:08 UTC)
* DynamoDBv2 (3.7.3.24)
	* Fixed an issue in DynamoDBv2 to allow lists and maps to be mapped even if null is set to false.
* Kinesis (3.7.1.45)
	* Update service-specific solution file with full integration test dependencies
* S3 (3.7.8.21)
	* Update service-specific solution file with full integration test dependencies
* Core 3.7.10.9
	* Fixed signature mismatch error by ensuring service url returned from client config has trailing slash.

### 3.7.254.0 (2022-04-15 18:16 UTC)
* Athena (3.7.6.0)
	* This release adds subfields, ErrorMessage, Retryable, to the AthenaError response object in the GetQueryExecution API when a query fails.
* Lightsail (3.7.6.0)
	* This release adds support to describe the synchronization status of the account-level block public access feature for your Amazon Lightsail buckets.
* RDS (3.7.11.0)
	* Removes Amazon RDS on VMware with the deletion of APIs related to Custom Availability Zones and Media installation

### 3.7.253.0 (2022-04-14 18:17 UTC)
* Appflow (3.7.8.0)
	* Enables users to pass custom token URL parameters for Oauth2 authentication during create connector profile
* AppStream (3.7.5.0)
	* Includes updates for create and update fleet APIs to manage the session scripts locations for Elastic fleets.
* Batch (3.7.5.0)
	* Enables configuration updates for compute environments with BEST_FIT_PROGRESSIVE and SPOT_CAPACITY_OPTIMIZED allocation strategies.
* CloudWatch (3.7.4.1)
	* Updates documentation for additional statistics in CloudWatch Metric Streams.
* EC2 (3.7.64.1)
	* Documentation updates for Amazon EC2.
* Glue (3.7.16.0)
	* Auto Scaling for Glue version 3.0 and later jobs to dynamically scale compute resources. This SDK change provides customers with the auto-scaled DPU usage
* Core 3.7.10.8
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.252.0 (2022-04-13 18:11 UTC)
* CloudWatch (3.7.4.0)
	* Adds support for additional statistics in CloudWatch Metric Streams.
* FSx (3.7.12.0)
	* This release adds support for deploying FSx for ONTAP file systems in a single Availability Zone.

### 3.7.251.0 (2022-04-12 19:03 UTC)
* DevOpsGuru (3.7.9.0)
	* This release adds new APIs DeleteInsight to deletes the insight along with the associated anomalies, events and recommendations.
* EC2 (3.7.64.0)
	* X2idn and X2iedn instances are powered by 3rd generation Intel Xeon Scalable processors with an all-core turbo frequency up to 3.5 GHzAmazon EC2. C6a instances are powered by 3rd generation AMD EPYC processors.
* ElasticFileSystem (3.7.5.0)
	* Amazon EFS adds support for a ThrottlingException when using the CreateAccessPoint API if the account is nearing the AccessPoint limit(120).
* IoTTwinMaker (3.7.1.0)
	* This release adds the following new features: 1) ListEntities API now supports search using ExternalId. 2) BatchPutPropertyValue and GetPropertyValueHistory API now allows users to represent time in sub-second level precisions.
* Core 3.7.10.7
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.250.0 (2022-04-11 18:14 UTC)
* AmplifyUIBuilder (3.7.2.0)
	* In this release, we have added the ability to bind events to component level actions.
* AppRunner (3.7.4.0)
	* This release adds tracing for App Runner services with X-Ray using AWS Distro for OpenTelemetry. New APIs: CreateObservabilityConfiguration, DescribeObservabilityConfiguration, ListObservabilityConfigurations, and DeleteObservabilityConfiguration. Updated APIs: CreateService and UpdateService.
* WorkSpaces (3.7.5.0)
	* Added API support that allows customers to create GPU-enabled WorkSpaces using EC2 G4dn instances.
* Core 3.7.10.6
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.249.0 (2022-04-08 18:15 UTC)
* MediaConvert (3.7.14.0)
	* AWS Elemental MediaConvert SDK has added support for the pass-through of WebVTT styling to WebVTT outputs, pass-through of KLV metadata to supported formats, and improved filter support for processing 444/RGB content.
* MediaPackageVod (3.7.5.0)
	* This release adds ScteMarkersSource as an available field for Dash Packaging Configurations. When set to MANIFEST, MediaPackage will source the SCTE-35 markers from the manifest. When set to SEGMENTS, MediaPackage will source the SCTE-35 markers from the segments.
* WAFV2 (3.7.10.0)
	* Add a new CurrentDefaultVersion field to ListAvailableManagedRuleGroupVersions API response; add a new VersioningSupported boolean to each ManagedRuleGroup returned from ListAvailableManagedRuleGroups API response.

### 3.7.248.0 (2022-04-07 21:45 UTC)
* APIGateway (3.7.3.0)
	* ApiGateway CLI command get-usage now includes usagePlanId, startDate, and endDate fields in the output to match documentation.
* DocDB (3.7.3.0)
	* Added support to enable/disable performance insights when creating or modifying db instances
* EventBridge (3.7.5.0)
	* Updated to use new Core, version 3.7.10.5
	* Adds new EventBridge Endpoint resources for disaster recovery, multi-region failover, and cross-region replication capabilities to help you build resilient event-driven applications.
* Personalize (3.7.8.0)
	* This release provides tagging support in AWS Personalize.
* PI (3.7.2.31)
	* Adds support for DocumentDB to the Performance Insights API.
* SageMaker (3.7.30.0)
	* Amazon Sagemaker Notebook Instances now supports G5 instance types
* Core 3.7.10.5
	* Changes to support EventBridge feature
	* All services packages updated to require new Core

### 3.7.247.0 (2022-04-06 18:18 UTC)
* ConfigService (3.7.9.0)
	* Add resourceType enums for AWS::EMR::SecurityConfiguration and AWS::SageMaker::CodeRepository
* Kendra (3.7.16.0)
	* Amazon Kendra now provides a data source connector for Box. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-box.html
* Lambda (3.7.12.0)
	* This release adds new APIs for creating and managing Lambda Function URLs and adds a new FunctionUrlAuthType parameter to the AddPermission API. Customers can use Function URLs to create built-in HTTPS endpoints on their functions.
* Panorama (3.7.2.0)
	* Added Brand field to device listings.
* Core 3.7.10.4
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.246.0 (2022-04-05 18:13 UTC)
* DataSync (3.7.5.0)
	* AWS DataSync now supports Amazon FSx for OpenZFS locations.
* FSx (3.7.11.0)
	* Provide customers more visibility into file system status by adding new "Misconfigured Unavailable" status for Amazon FSx for Windows File Server.
* S3Control (3.7.6.16)
	* Documentation-only update for doc bug fixes for the S3 Control API docs.
* SecurityHub (3.7.10.0)
	* Added additional ASFF details for RdsSecurityGroup AutoScalingGroup, ElbLoadBalancer, CodeBuildProject and RedshiftCluster.

### 3.7.245.0 (2022-04-04 18:17 UTC)
* IoT (3.7.12.0)
	* AWS IoT - AWS IoT Device Defender adds support to list metric datapoints collected for IoT devices through the ListMetricValues API
* Proton (3.7.3.0)
	* SDK release to support tagging for AWS Proton Repository resource
* ServerMigrationService (3.7.0.145)
	* Revised product update notice for SMS console deprecation.
* ServiceCatalog (3.7.2.0)
	* This release adds ProvisioningArtifictOutputKeys to DescribeProvisioningParameters to reference the outputs of a Provisioned Product and deprecates ProvisioningArtifactOutputs.

### 3.7.244.0 (2022-04-01 18:13 UTC)
* Connect (3.7.16.0)
	* This release updates these APIs: UpdateInstanceAttribute, DescribeInstanceAttribute and ListInstanceAttributes. You can use it to programmatically enable/disable multi-party conferencing using attribute type MULTI_PARTY_CONFERENCING on the specified Amazon Connect instance.
* Core 3.7.10.3
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.243.0 (2022-03-31 18:24 UTC)
* AuditManager (3.7.9.3)
	* This release adds documentation updates for Audit Manager. The updates provide data deletion guidance when a customer deregisters Audit Manager or deregisters a delegated administrator.
* CloudControlApi (3.7.1.0)
	* SDK release for Cloud Control API in Amazon Web Services China (Beijing) Region, operated by Sinnet, and Amazon Web Services China (Ningxia) Region, operated by NWCD
* GlueDataBrew (3.7.8.0)
	* This AWS Glue Databrew release adds feature to support ORC as an input format.
* ManagedGrafana (3.7.1.0)
	* This release adds tagging support to the Managed Grafana service. New APIs: TagResource, UntagResource and ListTagsForResource. Updates: add optional field tags to support tagging while calling CreateWorkspace.
* PinpointSMSVoiceV2 (3.7.0.0)
	* Amazon Pinpoint now offers a version 2.0 suite of SMS and voice APIs, providing increased control over sending and configuration. This release is a new SDK for sending SMS and voice messages called PinpointSMSVoiceV2.
* Route53RecoveryCluster (3.7.2.0)
	* This release adds a new API "ListRoutingControls" to list routing control states using the highly reliable Route 53 ARC data plane endpoints.
* WorkSpaces (3.7.4.0)
	* Added APIs that allow you to customize the logo, login message, and help links in the WorkSpaces client login page. To learn more, visit https://docs.aws.amazon.com/workspaces/latest/adminguide/customize-branding.html
* Core 3.7.10.2
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.242.0 (2022-03-30 22:07 UTC)
* EC2 (3.7.63.0)
	* This release simplifies the auto-recovery configuration process enabling customers to set the recovery behavior to disabled or default
* FMS (3.7.6.0)
	* AWS Firewall Manager now supports the configuration of third-party policies that can use either the centralized or distributed deployment models.
* FSx (3.7.10.0)
	* This release adds support for modifying throughput capacity for FSx for ONTAP file systems.
* IoT (3.7.11.23)
	* Doc only update for IoT that fixes customer-reported issues.
* IotData (3.7.2.0)
	* Update the default AWS IoT Core Data Plane endpoint from VeriSign signed to ATS signed. If you have firewalls with strict egress rules, configure the rules to grant you access to data-ats.iot.[region].amazonaws.com or data-ats.iot.[region].amazonaws.com.cn.

### 3.7.241.0 (2022-03-29 18:27 UTC)
* Organizations (3.7.1.0)
	* This release provides the new CloseAccount API that enables principals in the management account to close any member account within an organization.

### 3.7.240.0 (2022-03-28 19:56 UTC)
* ACMPCA (3.7.4.4)
	* Updating service name entities
* MediaLive (3.7.9.0)
	* This release adds support for selecting a maintenance window.
* Core 3.7.10.1
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.239.0 (2022-03-28 15:10 UTC)
* Core 3.7.10.0
	* Consolidate Profile resolution code and fixed bug where searching for profile did not honor AWSConfigs.AWSProfileName

### 3.7.238.0 (2022-03-25 18:16 UTC)
* Batch (3.7.4.0)
	* Bug Fix: Fixed a bug where shapes were marked as unboxed and were not serialized and sent over the wire, causing an API error from the service.
* EC2 (3.7.62.0)
	* This is release adds support for Amazon VPC Reachability Analyzer to analyze path through a Transit Gateway.
* SimpleSystemsManagement (3.7.14.0)
	* This Patch Manager release supports creating, updating, and deleting Patch Baselines for Rocky Linux OS.

### 3.7.237.0 (2022-03-24 18:16 UTC)
* ConfigService (3.7.8.0)
	* Added new APIs GetCustomRulePolicy and GetOrganizationCustomRulePolicy, and updated existing APIs PutConfigRule, DescribeConfigRule, DescribeConfigRuleEvaluationStatus, PutOrganizationConfigRule, DescribeConfigRule to support a new feature for building AWS Config rules with AWS CloudFormation Guard
* Lambda (3.7.11.0)
	* Adds support for increased ephemeral storage (/tmp) up to 10GB for Lambda functions. Customers can now provision up to 10 GB of ephemeral storage per function instance, a 20x increase over the previous limit of 512 MB.
* TranscribeService (3.7.12.0)
	* This release adds an additional parameter for subtitling with Amazon Transcribe batch jobs: outputStartIndex.
* Core 3.7.9.2
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.236.0 (2022-03-23 20:03 UTC)
* AuditManager (3.7.9.0)
	* This release updates 1 API parameter, the SnsArn attribute. The character length and regex pattern for the SnsArn attribute have been updated, which enables you to deselect an SNS topic when using the UpdateSettings operation.
* EBS (3.7.1.0)
	* Increased the maximum supported value for the Timeout parameter of the StartSnapshot API from 60 minutes to 4320 minutes.  Changed the HTTP error code for ConflictException from 503 to 409.
* ElastiCache (3.7.5.25)
	* Doc only update for ElastiCache
* GameSparks (3.7.0.0)
	* Released the preview of Amazon GameSparks, a fully managed AWS service that provides a multi-service backend for game developers.
* Redshift (3.7.13.0)
	* This release adds a new [--encrypted | --no-encrypted] field in restore-from-cluster-snapshot API. Customers can now restore an unencrypted snapshot to a cluster encrypted with AWS Managed Key or their own KMS key.
* SimpleSystemsManagement (3.7.13.0)
	* Update AddTagsToResource, ListTagsForResource, and RemoveTagsFromResource APIs to reflect the support for tagging Automation resources. Includes other minor documentation updates.
* Transfer (3.7.10.4)
	* Documentation updates for AWS Transfer Family to describe how to remove an associated workflow from a server.
* Core 3.7.9.1
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.235.0 (2022-03-22 20:43 UTC)
* CostExplorer (3.7.5.0)
	* Added three new APIs to support tagging and resource-level authorization on Cost Explorer resources: TagResource, UntagResource, ListTagsForResource.  Added optional parameters to CreateCostCategoryDefinition, CreateAnomalySubscription and CreateAnomalyMonitor APIs to support Tag On Create.
* ECS (3.7.5.8)
	* Documentation only update to address tickets
* LakeFormation (3.7.5.0)
	* The release fixes the incorrect permissions called out in the documentation - DESCRIBE_TAG, ASSOCIATE_TAG, DELETE_TAG, ALTER_TAG. This trebuchet release fixes the corresponding SDK and documentation.
* LocationService (3.7.9.0)
	* Amazon Location Service now includes a MaxResults parameter for GetDevicePositionHistory requests.
* Polly (3.7.4.0)
	* Amazon Polly adds new Catalan voice - Arlet. Arlet is available as Neural voice only.

### 3.7.234.0 (2022-03-21 20:15 UTC)
* ChimeSDKMeetings (3.7.5.0)
	* Add support for media replication to link multiple WebRTC media sessions together to reach larger and global audiences. Participants connected to a replica session can be granted access to join the primary session and can switch sessions with their existing WebRTC connection
* ECR (3.7.4.0)
	* This release includes a fix in the DescribeImageScanFindings paginated output.
* MediaConnect (3.7.5.0)
	* This release adds support for selecting a maintenance window.
* QuickSight (3.7.10.0)
	* AWS QuickSight Service Features - Expand public API support for group management.
* RAM (3.7.3.23)
	* Document improvements to the RAM API operations and parameter descriptions.

### 3.7.233.0 (2022-03-18 18:12 UTC)
* Glue (3.7.15.0)
	* Added 9 new APIs for AWS Glue Interactive Sessions: ListSessions, StopSession, CreateSession, GetSession, DeleteSession, RunStatement, GetStatement, ListStatements, CancelStatement

### 3.7.232.0 (2022-03-17 13:37 UTC)
* Lambda (3.7.10.3)
	* Add IsSet<property-name> methods for list properties on the UpdateFunctionConfiguration operation. This allows users to tell the SDK when they want clear out the values of collection properties like SubnetIds.
* Core 3.7.9.0
	* BREAKING CHANGE: Revert Amazon.Util.Internal.ICryptoUtil back to Amazon.Util.ICryptoUtil. This fixes an earlier breaking change for some older service clients when used alongside v3.7.8+ of AWSSDK.Core, but causes a new breaking change for some service clients released between v3.7.8 and this fix in future versions of AWSSDK.Core.
	* All services packages updated to require new Core

### 3.7.231.0 (2022-03-16 21:00 UTC)
* ACMPCA (3.7.4.0)
	* AWS Certificate Manager (ACM) Private Certificate Authority (CA) now supports customizable certificate subject names and extensions.
* AmplifyBackend (3.7.5.0)
	* Adding the ability to customize Cognito verification messages for email and SMS in CreateBackendAuth and UpdateBackendAuth. Adding deprecation documentation for ForgotPassword in CreateBackendAuth and UpdateBackendAuth
* BillingConductor (3.7.0.0)
	* This is the initial SDK release for AWS Billing Conductor. The AWS Billing Conductor is a customizable billing service, allowing you to customize your billing data to match your desired business structure.
* S3Outposts (3.7.2.0)
	* S3 on Outposts is releasing a new API, ListSharedEndpoints, that lists all endpoints associated with S3 on Outpost, that has been shared by Resource Access Manager (RAM).
* SSMIncidents (3.7.4.0)
	* Removed incorrect validation pattern for IncidentRecordSource.invokedBy
* Core 3.7.8.11
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.230.0 (2022-03-15 20:31 UTC)
* CognitoIdentityProvider (3.7.2.0)
	* Updated EmailConfigurationType and SmsConfigurationType to reflect that you can now choose Amazon SES and Amazon SNS resources in the same Region.
* DataExchange (3.7.4.0)
	* This feature enables data providers to use the RevokeRevision operation to revoke subscriber access to a given revision. Subscribers are unable to interact with assets within a revoked revision.
* EC2 (3.7.61.0)
	* Adds the Cascade parameter to the DeleteIpam API. Customers can use this parameter to automatically delete their IPAM, including non-default scopes, pools, cidrs, and allocations. There mustn't be any pools provisioned in the default public scope to use this parameter.
* ECS (3.7.5.5)
	* Documentation only update to address tickets
* Keyspaces (3.7.0.6)
	* Fixing formatting issues in CLI and SDK documentation
* LocationService (3.7.8.20)
	* New HERE style "VectorHereExplore" and "VectorHereExploreTruck".
* RDS (3.7.10.14)
	* Various documentation improvements
* RoboMaker (3.7.7.0)
	* This release deprecates ROS, Ubuntu and Gazbeo from RoboMaker Simulation Service Software Suites in favor of user-supplied containers and Relaxed Software Suites.
* Bump versions for CRT dependencies
	* Read more https://github.com/awslabs/aws-lc/releases/tag/v1.0.2

### 3.7.229.0 (2022-03-14 20:23 UTC)
* ConfigService (3.7.7.0)
	* Add resourceType enums for AWS::ECR::PublicRepository and AWS::EC2::LaunchTemplate
* ElastiCache (3.7.5.22)
	* Doc only update for ElastiCache
* Kendra (3.7.15.0)
	* Amazon Kendra now provides a data source connector for Slack. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-slack.html
* TimestreamQuery (3.7.2.0)
	* Amazon Timestream Scheduled Queries now support Timestamp datatype in a multi-measure record.
* Core 3.7.8.10
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.228.0 (2022-03-11 19:14 UTC)
* Chime (3.7.15.0)
	* Chime VoiceConnector Logging APIs will now support MediaMetricLogs. Also CreateMeetingDialOut now returns AccessDeniedException.
* Connect (3.7.15.0)
	* This release adds support for enabling Rich Messaging when starting a new chat session via the StartChatContact API. Rich Messaging enables the following formatting options: bold, italics, hyperlinks, bulleted lists, and numbered lists.
* Lambda (3.7.10.0)
	* Adds PrincipalOrgID support to AddPermission API. Customers can use it to manage permissions to lambda functions at AWS Organizations level.
* Outposts (3.7.7.0)
	* This release adds address filters for listSites
* SecretsManager (3.7.2.17)
	* Documentation updates for Secrets Manager.

### 3.7.227.0 (2022-03-10 19:15 UTC)
* LexModelsV2 (3.7.12.0)
	* This release makes slotTypeId an optional parameter in CreateSlot and UpdateSlot APIs in Amazon Lex V2 for model building. Customers can create and update slots without specifying a slot type id.
* TranscribeService (3.7.11.0)
	* Documentation fix for API `StartMedicalTranscriptionJobRequest`, now showing min sample rate as 16khz
* Transfer (3.7.10.0)
	* Adding more descriptive error types for managed workflows
* Core 3.7.8.9
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.226.0 (2022-03-09 21:29 UTC)
* Comprehend (3.7.6.0)
	* Amazon Comprehend now supports extracting the sentiment associated with entities such as brands, products and services from text documents.
* Core 3.7.8.8
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.225.0 (2022-03-08 19:18 UTC)
* EKS (3.7.13.0)
	* Introducing a new enum for NodeGroup error code: Ec2SubnetMissingIpv6Assignment
* Keyspaces (3.7.0.2)
	* Adding link to CloudTrail section in Amazon Keyspaces Developer Guide
* MediaConvert (3.7.13.0)
	* AWS Elemental MediaConvert SDK has added support for reading timecode from AVCHD sources and now provides the ability to segment WebVTT at the same interval as the video and audio in HLS packages.
* Core 3.7.8.7
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.224.0 (2022-03-07 19:47 UTC)
* ChimeSDKMeetings (3.7.4.0)
	* Adds support for Transcribe language identification feature to the StartMeetingTranscription API.
* ECS (3.7.5.0)
	* Amazon ECS UpdateService API now supports additional parameters: loadBalancers, propagateTags, enableECSManagedTags, and serviceRegistries
* MigrationHubRefactorSpaces (3.7.0.30)
	* AWS Migration Hub Refactor Spaces documentation update.

### 3.7.223.0 (2022-03-04 19:28 UTC)
* Connect (3.7.14.0)
	* This release updates the *InstanceStorageConfig APIs so they support a new ResourceType: REAL_TIME_CONTACT_ANALYSIS_SEGMENTS. Use this resource type to enable streaming for real-time contact analysis and to associate the Kinesis stream where real-time contact analysis segments will be published.
* DevOpsGuru (3.7.8.0)
	* Amazon DevOps Guru now integrates with Amazon CodeGuru Profiler. You can view CodeGuru Profiler recommendations for your AWS Lambda function in DevOps Guru. This feature is enabled by default for new customers as of 3/4/2022. Existing customers can enable this feature with UpdateEventSourcesConfig.
* EC2 (3.7.60.3)
	* Documentation updates for Amazon EC2.
* Macie (3.7.0.133)
	* Amazon Macie Classic (macie) has been discontinued and is no longer available. A new Amazon Macie (macie2) is now available with significant design improvements and additional features.
* SecurityToken (3.7.1.124)
	* Documentation updates for AWS Security Token Service.
* Synthetics (3.7.4.0)
	* Allow custom handler function.
* Transfer (3.7.9.0)
	* Add waiters for server online and offline.

### 3.7.222.0 (2022-03-03 19:21 UTC)
* Appflow (3.7.7.0)
	* Launching Amazon AppFlow Marketo as a destination connector SDK.
* FSx (3.7.9.0)
	* This release adds support for data repository associations to use root ("/") as the file system path
* GreengrassV2 (3.7.4.22)
	* Doc only update that clarifies Create Deployment section.
* Kendra (3.7.14.0)
	* Amazon Kendra now suggests spell corrections for a query. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/query-spell-check.html
* TimestreamQuery (3.7.1.29)
	* Documentation only update for SDK and CLI
* Core 3.7.8.6
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.221.0 (2022-03-02 19:28 UTC)
* Athena (3.7.5.0)
	* This release adds support for S3 Object Ownership by allowing the S3 bucket owner full control canned ACL to be set when Athena writes query results to S3 buckets.
* CloudTrail (3.7.3.0)
	* Add bytesScanned field into responses of DescribeQuery and GetQueryResults.
* ECR (3.7.3.0)
	* This release adds support for tracking images lastRecordedPullTime.
* GameLift (3.7.1.46)
	* Minor updates to address errors.
* Keyspaces (3.7.0.0)
	* This release adds support for data definition language (DDL) operations

### 3.7.220.0 (2022-03-01 19:17 UTC)
* KafkaConnect (3.7.1.0)
	* Adds operation for custom plugin deletion (DeleteCustomPlugin) and adds new StateDescription field to DescribeCustomPlugin and DescribeConnector responses to return errors from asynchronous resource creation.
* MediaPackage (3.7.5.0)
	* This release adds Hybridcast as an available profile option for Dash Origin Endpoints.
* Mgn (3.7.3.0)
	* Add support for GP3 and IO2 volume types. Add bootMode to LaunchConfiguration object (and as a parameter to UpdateLaunchConfigurationRequest).
* RDS (3.7.10.8)
	* Documentation updates for Multi-AZ DB clusters.
* Core 3.7.8.5
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.219.0 (2022-02-28 19:18 UTC)
* Amplify (3.7.1.0)
	* Add repositoryCloneMethod field for hosting an Amplify app. This field shows what authorization method is used to clone the repo: SSH, TOKEN, or SIGV4.
* AmplifyUIBuilder (3.7.1.0)
	* We are adding the ability to configure workflows and actions for components.
* AppRegistry (3.7.2.0)
	* AppRegistry is deprecating Application and Attribute-Group Name update feature. In this release, we are marking the name attributes for Update APIs as deprecated to give a heads up to our customers.
* Athena (3.7.4.0)
	* This release adds support for updating an existing named query.
* EC2 (3.7.60.0)
	* This release adds support for new AMI property 'lastLaunchedTime'
* FinSpaceData (3.7.3.0)
	* Add new APIs for managing Users and Permission Groups.
* FIS (3.7.3.0)
	* This release adds logging support for AWS Fault Injection Simulator experiments. Experiment templates can now be configured to send experiment activity logs to Amazon CloudWatch Logs or to an S3 bucket.
* FSx (3.7.8.0)
	* This release adds support for the following FSx for OpenZFS features: snapshot lifecycle transition messages, force flag for deleting file systems with child resources, LZ4 data compression, custom record sizes, and unsetting volume quotas and reservations.
* Route53RecoveryCluster (3.7.1.0)
	* This release adds a new API option to enable overriding safety rules to allow routing control state updates.
* Core 3.7.8.4
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.218.0 (2022-02-25 23:09 UTC)
* ElastiCache (3.7.5.15)
	* Doc only update for ElastiCache
* Panorama (3.7.1.0)
	* Added NTP server configuration parameter to ProvisionDevice operation. Added alternate software fields to DescribeDevice response
* Core 3.7.8.3
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.217.0 (2022-02-24 19:20 UTC)
* AutoScaling (3.7.9.0)
	* You can now hibernate instances in a warm pool to stop instances without deleting their RAM contents. You can now also return instances to the warm pool on scale in, instead of always terminating capacity that you will need later.
* FMS (3.7.5.0)
	* AWS Firewall Manager now supports the configuration of AWS Network Firewall policies with either centralized or distributed deployment models. This release also adds support for custom endpoint configuration, where you can choose which Availability Zones to create firewall endpoints in.
* GlueDataBrew (3.7.7.0)
	* This AWS Glue Databrew release adds feature to merge job outputs into a max number of files for S3 File output type.
* Lightsail (3.7.5.0)
	* This release adds support to delete and create Lightsail default key pairs that you can use with Lightsail instances.
* Route53 (3.7.2.24)
	* SDK doc update for Route 53 to update some parameters with new information.
* S3 (3.7.8.0)
	* This release adds support for new integrity checking capabilities in Amazon S3. You can choose from four supported checksum algorithms for data integrity checking on your upload and download requests. In addition, AWS SDK can automatically calculate a checksum as it streams data into S3
* S3Control (3.7.6.0)
	* Amazon S3 Batch Operations adds support for new integrity checking capabilities in Amazon S3.
* Transfer (3.7.8.0)
	* Support automatic pagination when listing AWS Transfer Family resources.

### 3.7.216.0 (2022-02-23 19:14 UTC)
* Lambda (3.7.9.0)
	* Lambda releases .NET 6 managed runtime to be available in all commercial regions.
* Textract (3.7.4.0)
	* Added support for merged cells and column header for table response.
* Transfer (3.7.7.0)
	* The file input selection feature provides the ability to use either the originally uploaded file or the output file from the previous workflow step, enabling customers to make multiple copies of the original file while keeping the source file intact for file archival.
* Core 3.7.8.2
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.215.0 (2022-02-22 19:14 UTC)
* AppRunner (3.7.3.0)
	* AWS App Runner adds a Java platform (Corretto 8, Corretto 11 runtimes) and a Node.js 14 runtime.
* Translate (3.7.4.0)
	* This release enables customers to use translation settings for formality customization in their synchronous translation output.
* WAFV2 (3.7.9.5)
	* Updated descriptions for logging configuration.
* Core 3.7.8.1
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.214.0 (2022-02-22 14:38 UTC)
* DynamoDBv2 (3.7.3.1)
	* Add Dynamo S3Link implementation to .NET Standard
* S3Control (3.7.5.5)
	* Refactor MD5 handling to support flexible checkums for validating end-to-end data integrity
* Core 3.7.8.0
	* Add support for flexible checkums for validating end-to-end data integrity on supported service operations
	* All services packages updated to require new Core

### 3.7.213.0 (2022-02-21 19:15 UTC)
* CustomerProfiles (3.7.6.0)
	* This release introduces apis CreateIntegrationWorkflow, DeleteWorkflow, ListWorkflows, GetWorkflow and GetWorkflowSteps. These apis are used to manage and view integration workflows.
* DynamoDBv2 (3.7.3.0)
	* DynamoDB ExecuteStatement API now supports Limit as a request parameter to specify the maximum number of items to evaluate. If specified, the service will process up to the Limit and the results will include a LastEvaluatedKey value to continue the read in a subsequent operation.
* Imagebuilder (3.7.6.0)
	* This release adds support to enable faster launching for Windows AMIs created by EC2 Image Builder.
* Core 3.7.7.2
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.212.0 (2022-02-18 19:17 UTC)
* Budgets (3.7.2.0)
	* This change introduces DescribeBudgetNotificationsForAccount API which returns budget notifications for the specified account
* GameLift (3.7.1.38)
	* Increase string list limit from 10 to 100.
* Transfer (3.7.6.0)
	* Properties for Transfer Family used with SFTP, FTP, and FTPS protocols. Display Banners are bodies of text that can be displayed before and/or after a user authenticates onto a server using one of the previously mentioned protocols.

### 3.7.211.0 (2022-02-17 19:16 UTC)
* Backup (3.7.6.0)
	* AWS Backup add new S3_BACKUP_OBJECT_FAILED and S3_RESTORE_OBJECT_FAILED event types in BackupVaultNotifications events list.
* CloudWatchEvidently (3.7.1.0)
	* Add support for filtering list of experiments and launches by status
* IdentityManagement (3.7.2.104)
	* Documentation updates for AWS Identity and Access Management (IAM).
* Redshift (3.7.12.0)
	* SDK release for Cross region datasharing and cost-control for cross region datasharing
* Core 3.7.7.1
	* Updating endpoints.json file.

	* All services packages updated to require new Core

### 3.7.210.0 (2022-02-16 19:18 UTC)
* Budgets (3.7.1.0)
	* Adds support for auto-adjusting budgets, a new budget method alongside fixed and planned. Auto-adjusting budgets introduces new metadata to configure a budget limit baseline using a historical lookback average or current period forecast.
* CostExplorer (3.7.4.0)
	* AWS Cost Anomaly Detection now supports SNS FIFO topic subscribers.
* EC2 (3.7.59.4)
	* Documentation updates for EC2.
* Glue (3.7.14.0)
	* Support for optimistic locking in UpdateTable
* SimpleSystemsManagement (3.7.12.10)
	* Assorted ticket fixes and updates for AWS Systems Manager.

### 3.7.209.0 (2022-02-14 21:44 UTC)
* Appflow (3.7.6.0)
	* Launching Amazon AppFlow SAP as a destination connector SDK.
* Athena (3.7.3.0)
	* This release adds a subfield, ErrorType, to the AthenaError response object in the GetQueryExecution API when a query fails.
* RDS (3.7.10.0)
	* Adds support for determining which Aurora PostgreSQL versions support Babelfish.

### 3.7.208.1 (2022-02-11 19:11 UTC)
* SimpleSystemsManagement (3.7.12.9)
	* Documentation updates for AWS Systems Manager.

### 3.7.208.0 (2022-02-11 04:47 UTC)
* Core 3.7.7.0
	* Attempting credential expiration extension due to a credential service availability issue.  A refresh of these credentials will be attempted again in 5-15 minutes. Added support for using bidi characters in resource path for .NET Core 3.1 and newer platforms.
	* All services packages updated to require new Core

### 3.7.207.0 (2022-02-10 19:14 UTC)
* CloudFormation (3.7.9.0)
	* This SDK release adds AWS CloudFormation Hooks HandlerErrorCodes
* LookoutforVision (3.7.2.0)
	* This release makes CompilerOptions in Lookout for Vision's StartModelPackagingJob's Configuration object optional.
* Pinpoint (3.7.6.0)
	* This SDK release adds a new paramater creation date for GetApp and GetApps Api call
* SimpleNotificationService (3.7.3.22)
	* Customer requested typo fix in API documentation.
* WAFV2 (3.7.9.0)
	* Adds support for AWS WAF Fraud Control account takeover prevention (ATP), with configuration options for the new managed rule group AWSManagedRulesATPRuleSet and support for application integration SDKs for Android and iOS mobile apps.
* Core 3.7.6.5
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.206.0 (2022-02-09 19:13 UTC)
* CloudFormation (3.7.8.0)
	* This SDK release is for the feature launch of AWS CloudFormation Hooks.

### 3.7.205.0 (2022-02-08 19:13 UTC)
* AppRunner (3.7.2.0)
	* This release adds support for App Runner to route outbound network traffic of a service through an Amazon VPC. New API: CreateVpcConnector, DescribeVpcConnector, ListVpcConnectors, and DeleteVpcConnector. Updated API: CreateService, DescribeService, and UpdateService.
* Kendra (3.7.13.0)
	* Amazon Kendra now provides a data source connector for Amazon FSx. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-fsx.html
* S3Control (3.7.5.0)
	* This release adds support for S3 Batch Replication. Batch Replication lets you replicate existing objects, already replicated objects to new destinations, and objects that previously failed to replicate. Customers will receive object-level visibility of progress and a detailed completion report.
* SageMaker (3.7.29.0)
	* Autopilot now generates an additional report with information on the performance of the best model, such as a Confusion matrix and  Area under the receiver operating characteristic (AUC-ROC). The path to the report can be found in CandidateArtifactLocations.

### 3.7.204.0 (2022-02-07 19:16 UTC)
* AuditManager (3.7.8.0)
	* This release updates 3 API parameters. UpdateAssessmentFrameworkControlSet now requires the controls attribute, and CreateAssessmentFrameworkControl requires the id attribute. Additionally, UpdateAssessmentFramework now has a minimum length constraint for the controlSets attribute.
* EventBridge (3.7.4.67)
	* Documentation updates for EventBridge
* SSMIncidents (3.7.3.0)
	* Update RelatedItem enum to support SSM Automation
* Synthetics (3.7.3.0)
	* Adding names parameters to the Describe APIs.

### 3.7.203.0 (2022-02-04 19:55 UTC)
* Athena (3.7.2.0)
	* You can now optionally specify the account ID that you expect to be the owner of your query results output location bucket in Athena. If the account ID of the query results bucket owner does not match the specified account ID, attempts to output to the bucket will fail with an S3 permissions error.
* LakeFormation (3.7.4.0)
	* Add support for calling Update Table Objects without a TransactionId.
* RDS (3.7.9.7)
	* updates for RDS Custom for Oracle 12.1 support
* Core 3.7.6.4
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.202.0 (2022-02-03 21:14 UTC)
* AWSMarketplaceMetering (3.7.1.0)
	* Add CustomerAWSAccountId to ResolveCustomer API response and increase UsageAllocation limit to 2500.
* EC2 (3.7.59.0)
	* adds support for AMIs in Recycle Bin
* RecycleBin (3.7.1.0)
	* Add EC2 Image recycle bin support.
* RoboMaker (3.7.6.0)
	* The release deprecates the use various APIs of RoboMaker Deployment Service in favor of AWS IoT GreenGrass v2.0.
* Core 3.7.6.3
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.201.0 (2022-02-02 19:22 UTC)
* Appflow (3.7.5.0)
	* Launching Amazon AppFlow Custom Connector SDK.
* Comprehend (3.7.5.0)
	* Amazon Comprehend now supports sharing and importing custom trained models from one AWS account to another within the same region.
* CostExplorer (3.7.3.68)
	* Doc-only update for Cost Explorer API that adds INVOICING_ENTITY dimensions
* DynamoDBv2 (3.7.2.15)
	* Documentation update for DynamoDB Java SDK.
* ElastiCache (3.7.5.5)
	* Documentation update for AWS ElastiCache
* ElasticMapReduce (3.7.4.57)
	* Documentation updates for Amazon EMR.
* Elasticsearch (3.7.5.0)
	* Allows customers to get progress updates for blue/green deployments
* FIS (3.7.2.0)
	* Added GetTargetResourceType and ListTargetResourceTypesAPI actions. These actions return additional details about resource types and parameters that can be targeted by FIS actions. Added a parameters field for the targets that can be specified in experiment templates.
* Glue (3.7.13.0)
	* Launch Protobuf support for AWS Glue Schema Registry
* IoT (3.7.11.0)
	* This release adds support for configuring AWS IoT logging level per client ID, source IP, or principal ID.
* Personalize (3.7.7.0)
	* Adding minRecommendationRequestsPerSecond attribute to recommender APIs.

### 3.7.200.0 (2022-01-28 19:16 UTC)
* AppConfig (3.7.1.19)
	* Documentation updates for AWS AppConfig
* AppConfigData (3.7.0.19)
	* Documentation updates for AWS AppConfig Data.
* Athena (3.7.1.0)
	* This release adds a field, AthenaError, to the GetQueryExecution response object when a query fails.
* CognitoIdentityProvider (3.7.1.91)
	* Doc updates for Cognito user pools API Reference.
* SageMaker (3.7.28.0)
	* This release added a new NNA accelerator compilation support for Sagemaker Neo.
* SecretsManager (3.7.2.0)
	* Feature are ready to release on Jan 28th
* Core 3.7.6.2
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.199.0 (2022-01-27 21:44 UTC)
* Amplify (3.7.0.119)
	* Doc only update to the description of basicauthcredentials to describe the required encoding and format.
* Connect (3.7.13.0)
	* This release adds support for configuring a custom chat duration when starting a new chat session via the StartChatContact API. The default value for chat duration is 25 hours, minimum configurable value is 1 hour (60 minutes) and maximum configurable value is 7 days (10,080 minutes).
* EC2 (3.7.58.0)
	* X2ezn instances are powered by Intel Cascade Lake CPUs that deliver turbo all core frequency of up to 4.5 GHz and up to 100 Gbps of networking bandwidth
* Kafka (3.7.6.0)
	* Amazon MSK has updated the CreateCluster and UpdateBrokerStorage API that allows you to specify volume throughput during cluster creation and broker volume updates.
* OpenSearchService (3.7.4.0)
	* Allows customers to get progress updates for blue/green deployments

### 3.7.198.0 (2022-01-26 19:13 UTC)
* CodeGuruReviewer (3.7.5.0)
	* Added failure state and adjusted timeout in waiter
* EBS (3.7.0.121)
	* Documentation updates for Amazon EBS Direct APIs.
* FraudDetector (3.7.6.0)
	* Added new APIs for viewing past predictions and obtaining prediction metadata including prediction explanations: ListEventPredictions and GetEventPredictionMetadata
* SageMaker (3.7.27.0)
	* API changes relating to Fail steps in model building pipeline and add PipelineExecutionFailureReason in PipelineExecutionSummary.
* SecurityHub (3.7.9.0)
	* Adding top level Sample boolean field

### 3.7.197.0 (2022-01-25 19:17 UTC)
* Connect (3.7.12.0)
	* This release adds support for custom vocabularies to be used with Contact Lens. Custom vocabularies improve transcription accuracy for one or more specific words.
* ElasticFileSystem (3.7.4.0)
	* Use Amazon EFS Replication to replicate your Amazon EFS file system in the AWS Region of your preference.
* FSx (3.7.7.0)
	* This release adds support for growing SSD storage capacity and growing/shrinking SSD IOPS for FSx for ONTAP file systems.
* GuardDuty (3.7.2.0)
	* Amazon GuardDuty expands threat detection coverage to protect Amazon Elastic Kubernetes Service (EKS) workloads.
* Core 3.7.6.1
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.196.2 (2022-01-24 19:12 UTC)
* Route53RecoveryReadiness (3.7.0.73)
	* Updated documentation for Route53 Recovery Readiness APIs.

### 3.7.196.1 (2022-01-21 22:42 UTC)
* S3 (3.7.7.15)
	* Fixed handling of Outposts ARNs causing incorrect append to endpoint. Fixed an issue where TransferProgressArgs.PercentDone was throwing DivideByZeroException for zero length downloads.

### 3.7.196.0 (2022-01-21 19:16 UTC)
* MediaConvert (3.7.12.0)
	* AWS Elemental MediaConvert SDK has added support for 4K AV1 output resolutions & 10-bit AV1 color, the ability to ingest sidecar Dolby Vision XML metadata files, and the ability to flag WebVTT and IMSC tracks for accessibility in HLS.
* TranscribeService (3.7.10.0)
	* Add support for granular PIIEntityTypes when using Batch ContentRedaction.

### 3.7.195.0 (2022-01-20 19:17 UTC)
* Connect (3.7.11.0)
	* This release adds tagging support for UserHierarchyGroups resource.
* EC2 (3.7.57.0)
	* C6i, M6i and R6i instances are powered by a third-generation Intel Xeon Scalable processor (Ice Lake) delivering all-core turbo frequency of 3.5 GHz
* FIS (3.7.1.0)
	* Added action startTime and action endTime timestamp fields to the ExperimentAction object
* GuardDuty (3.7.1.0)
	* Amazon GuardDuty findings now include remoteAccountDetails under AwsApiCallAction section if instance credential is exfiltrated.
* MediaTailor (3.7.8.0)
	* This release adds support for multiple Segment Delivery Configurations. Users can provide a list of names and URLs when creating or editing a source location. When retrieving content, users can send a header to choose which URL should be used to serve content.

### 3.7.194.0 (2022-01-19 19:16 UTC)
* EC2InstanceConnect (3.7.2.0)
	* Adds support for ED25519 keys. PushSSHPublicKey Availability Zone parameter is now optional. Adds EC2InstanceStateInvalidException for instances that are not running. This was previously a service exception, so this may require updating your code to handle this new exception.
* Macie2 (3.7.7.0)
	* This release of the Amazon Macie API introduces stricter validation of requests to create custom data identifiers.

### 3.7.193.0 (2022-01-18 19:15 UTC)
* CloudTrail (3.7.2.7)
	* This release fixes a documentation bug in the description for the readOnly field selector in advanced event selectors. The description now clarifies that users omit the readOnly field selector to select both Read and Write management events.
* EC2 (3.7.56.0)
	* Add support for AWS Client VPN client login banner and session timeout.
* IVS (3.7.4.0)
	* This release adds support for the new Thumbnail Configuration property for Recording Configurations. For more information see https://docs.aws.amazon.com/ivs/latest/userguide/record-to-s3.html
* LocationService (3.7.8.0)
	* This release adds the CalculateRouteMatrix API which calculates routes for the provided departure and destination positions. The release also deprecates the use of pricing plan across all verticals.
* StorageGateway (3.7.4.14)
	* Documentation update for adding bandwidth throttling support for S3 File Gateways.

### 3.7.192.0 (2022-01-15 10:19 UTC)
* Core 3.7.6.0
	* Add support for Default Configuration Modes.
	* All services packages updated to require new Core

### 3.7.191.0 (2022-01-14 19:31 UTC)
* ApplicationInsights (3.7.2.14)
	* Application Insights support for Active Directory and SharePoint
* ConfigService (3.7.6.0)
	* Update ResourceType enum with values for CodeDeploy, EC2 and Kinesis resources
* Honeycode (3.7.2.0)
	* Added read and write api support for multi-select picklist. And added errorcode field to DescribeTableDataImportJob API output, when import job fails.
* LookoutMetrics (3.7.7.0)
	* This release adds a new DeactivateAnomalyDetector API operation.
* RAM (3.7.3.0)
	* This release adds the ListPermissionVersions API which lists the versions for a given permission.
* Core 3.7.5.15
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.190.0 (2022-01-13 19:24 UTC)
* ElastiCache (3.7.5.0)
	* AWS ElastiCache for Redis has added a new Engine Log LogType in LogDelivery feature. You can now publish the Engine Log from your Amazon ElastiCache for Redis clusters to Amazon CloudWatch Logs and Amazon Kinesis Data Firehose.
* Glue (3.7.12.0)
	* This SDK release adds support to pass run properties when starting a workflow run
* LexRuntimeV2 (3.7.4.0)
	* This release adds support for sending hints to Amazon Lex V2 runtime APIs. Bot developers can provide runtime hints to help improve the recognition of slot values.
* NimbleStudio (3.7.4.0)
	* Amazon Nimble Studio now supports validation for Launch Profiles. Launch Profiles now report static validation results after create/update to detect errors in network or active directory configuration.
* Pinpoint (3.7.5.0)
	* Adds JourneyChannelSettings to WriteJourneyRequest
* SimpleSystemsManagement (3.7.12.0)
	* AWS Systems Manager adds category support for DescribeDocument API
* Core 3.7.5.14
	* Updating endpoints.json file.


	* All services packages updated to require new Core

### 3.7.189.0 (2022-01-12 19:15 UTC)
* EC2 (3.7.55.0)
	* Hpc6a instances are powered by a third-generation AMD EPYC processors (Milan) delivering all-core turbo frequency of 3.4 GHz
* ElastiCache (3.7.4.13)
	* Doc only update for ElastiCache
* FMS (3.7.4.0)
	* Shield Advanced policies for Amazon CloudFront resources now support automatic application layer DDoS mitigation. The max length for SecurityServicePolicyData ManagedServiceData is now 8192 characters, instead of 4096.
* Honeycode (3.7.1.0)
	* Honeycode is releasing new APIs to allow user to create, delete and list tags on resources.
* LexModelsV2 (3.7.11.0)
	* This release adds support for Custom vocabulary in Amazon Lex V2 APIs for model building. Customers can give Amazon Lex V2 more information about how to process audio conversations with a bot by creating a custom vocabulary in a specific language.
* PI (3.7.2.0)
	* This release adds three Performance Insights APIs. Use ListAvailableResourceMetrics to get available metrics, GetResourceMetadata to get feature metadata, and ListAvailableResourceDimensions to list available dimensions. The AdditionalMetrics field in DescribeDimensionKeys retrieves per-SQL metrics.

### 3.7.188.0 (2022-01-11 19:45 UTC)
* CostExplorer (3.7.3.62)
	* Doc only update for Cost Explorer API that fixes missing clarifications for MatchOptions definitions
* EC2 (3.7.54.0)
	* EC2 Capacity Reservations now supports RHEL instance platforms (RHEL with SQL Server Standard, RHEL with SQL Server Enterprise, RHEL with SQL Server Web, RHEL with HA, RHEL with HA and SQL Server Standard, RHEL with HA and SQL Server Enterprise)
* FinSpaceData (3.7.2.6)
	* Documentation updates for FinSpace.
* IoTEventsData (3.7.1.86)
	* This release provides documentation updates for Timer.timestamp in the IoT Events API Reference Guide.
* Kendra (3.7.12.0)
	* Amazon Kendra now supports advanced query language and query-less search.
* RDS (3.7.9.0)
	* This release adds the db-proxy event type to support subscribing to RDS Proxy events.
* WorkSpaces (3.7.3.0)
	* Introducing new APIs for Workspaces audio optimization with Amazon Connect: CreateConnectClientAddIn, DescribeConnectClientAddIns, UpdateConnectClientAddIn and DeleteConnectClientAddIn.
* Core 3.7.5.13
	* Updating sdk-default-configuration.json file.


	* All services packages updated to require new Core

### 3.7.187.0 (2022-01-10 19:15 UTC)
* ComputeOptimizer (3.7.5.0)
	* Adds support for new Compute Optimizer capability that makes it easier for customers to optimize their EC2 instances by leveraging multiple CPU architectures.
* EC2 (3.7.53.0)
	* New feature: Updated EC2 API to support faster launching for Windows images. Optimized images are pre-provisioned, using snapshots to launch instances up to 65% faster.
* GlueDataBrew (3.7.6.0)
	* This SDK release adds support for specifying a Bucket Owner for an S3 location.
* LookoutMetrics (3.7.6.0)
	* This release adds FailureType in the response of DescribeAnomalyDetector.
* TranscribeService (3.7.9.26)
	* Documentation updates for Amazon Transcribe.

### 3.7.186.0 (2022-01-07 19:12 UTC)
* MediaLive (3.7.8.0)
	* This release adds support for selecting the Program Date Time (PDT) Clock source algorithm for HLS outputs.
* Core 3.7.5.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.185.0 (2022-01-06 19:15 UTC)
* AppSync (3.7.4.0)
	* AppSync: AWS AppSync now supports configurable batching sizes for AWS Lambda resolvers, Direct AWS Lambda resolvers and pipeline functions
* EC2 (3.7.52.0)
	* This release introduces On-Demand Capacity Reservation support for Cluster Placement Groups, adds Tags on instance Metadata, and includes documentation updates for Amazon EC2.
* Elasticsearch (3.7.4.0)
	* Amazon OpenSearch Service adds support for Fine Grained Access Control for existing domains running Elasticsearch version 6.7 and above
* IoTWireless (3.7.9.0)
	* Downlink Queue Management feature provides APIs for customers to manage the queued messages destined to device inside AWS IoT Core for LoRaWAN. Customer can view, delete or purge the queued message(s). It allows customer to preempt the queued messages and let more urgent messages go through.
* MediaTailor (3.7.7.0)
	* This release adds support for filler slate when updating MediaTailor channels that use the linear playback mode.
* MWAA (3.7.2.0)
	* This release adds a "Source" field that provides the initiator of an update, such as due to an automated patch from AWS or due to modification via Console or API.
* OpenSearchService (3.7.3.0)
	* Amazon OpenSearch Service adds support for Fine Grained Access Control for existing domains running Elasticsearch version 6.7 and above
* Core 3.7.5.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.184.0 (2022-01-05 19:26 UTC)
* AppStream (3.7.4.0)
	* Includes APIs for App Entitlement management regarding entitlement and entitled application association.
* CloudTrail (3.7.2.0)
	* This release adds support for CloudTrail Lake, a new feature that lets you run SQL-based queries on events that you have aggregated into event data stores. New APIs have been added for creating and managing event data stores, and creating, running, and managing queries in CloudTrail Lake.
* EC2 (3.7.51.0)
	* This release adds a new API called ModifyVpcEndpointServicePayerResponsibility which allows VPC endpoint service owners to take payer responsibility of their VPC Endpoint connections.
* ECS (3.7.4.18)
	* Documentation update for ticket fixes.
* EKS (3.7.12.0)
	* Amazon EKS now supports running applications using IPv6 address space
* Glue (3.7.11.0)
	* Add Delta Lake target support for Glue Crawler and 3rd Party Support for Lake Formation
* IoT (3.7.10.0)
	* This release adds an automatic retry mechanism for AWS IoT Jobs. You can now define a maximum number of retries for each Job rollout, along with the criteria to trigger the retry for FAILED/TIMED_OUT/ALL(both FAILED an TIMED_OUT) job.
* LakeFormation (3.7.3.0)
	* Add new APIs for 3rd Party Support for Lake Formation
* QuickSight (3.7.9.8)
	* Multiple Doc-only updates for Amazon QuickSight.
* SageMaker (3.7.26.0)
	* Amazon SageMaker now supports running training jobs on ml.g5 instance types.
* Snowball (3.7.4.0)
	* Updating validation rules for interfaces used in the Snowball API to tighten security of service.
* Core 3.7.5.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.183.0 (2022-01-04 19:14 UTC)
* Rekognition (3.7.7.0)
	* This release introduces a new field IndexFacesModelVersion, which is the version of the face detect and storage model that was used when indexing the face vector.
* S3 (3.7.7.7)
	* Minor doc-based updates based on feedback bugs received.
* S3Control (3.7.4.8)
	* Documentation updates for the renaming of Glacier to Glacier Flexible Retrieval.

### 3.7.182.0 (2022-01-03 19:22 UTC)
* Detective (3.7.3.0)
	* Added and updated API operations to support the Detective integration with AWS Organizations. New actions are used to manage the delegated administrator account and the integration configuration.
* GreengrassV2 (3.7.4.0)
	* This release adds the API operations to manage the Greengrass role associated with your account and to manage the core device connectivity information. Greengrass V2 customers can now depend solely on Greengrass V2 SDK for all the API operations needed to manage their fleets.
* MediaConvert (3.7.11.0)
	* AWS Elemental MediaConvert SDK has added strength levels to the Sharpness Filter and now permits OGG files to be specified as sidecar audio inputs.
* RDS (3.7.8.7)
	* Multiple doc-only updates for Relational Database Service (RDS)
* SageMaker (3.7.25.0)
	* The release allows users to pass pipeline definitions as Amazon S3 locations and control the pipeline execution concurrency using ParallelismConfiguration. It also adds support of EMR jobs as pipeline steps.
* Core 3.7.5.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

