### 3.7.718.0 (2023-12-29 19:14 UTC)
* AppRunner (3.7.301.0)
	* AWS App Runner adds Python 3.11 and Node.js 18 runtimes.
* LocationService (3.7.303.0)
	* This release introduces a new parameter to bypasses an API key's expiry conditions and delete the key.
* QuickSight (3.7.304.0)
	* Add LinkEntityArn support for different partitions; Add UnsupportedUserEditionException in UpdateDashboardLinks API; Add support for New Reader Experience Topics

### 3.7.717.0 (2023-12-28 19:41 UTC)
* CodeStarconnections (3.7.304.0)
	* New integration with the GitLab self-managed provider type.
* KinesisVideoArchivedMedia (3.7.301.0)
	* NoDataRetentionException thrown when GetImages requested for a Stream that does not retain data (that is, has a DataRetentionInHours of 0).
* SageMaker (3.7.308.0)
	* Amazon SageMaker Studio now supports Docker access from within app container
* Core 3.7.300.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.716.0 (2023-12-27 19:15 UTC)
* ElasticMapReduce (3.7.303.0)
	* Add support for customers to modify cluster attribute auto-terminate post cluster launch
* Core 3.7.300.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.715.1 (2023-12-26 19:15 UTC)
* IdentityManagement (3.7.300.26)
	* Documentation updates for AWS Identity and Access Management (IAM).
* Core 3.7.300.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.715.0 (2023-12-22 19:22 UTC)
* BedrockAgent (3.7.302.0)
	* Adding Claude 2.1 support to Bedrock Agents
* Glue (3.7.305.0)
	* This release adds additional configurations for Query Session Context on the following APIs: GetUnfilteredTableMetadata, GetUnfilteredPartitionMetadata, GetUnfilteredPartitionsMetadata.
* LakeFormation (3.7.302.0)
	* This release adds additional configurations on GetTemporaryGlueTableCredentials for Query Session Context.
* MediaConnect (3.7.301.0)
	* This release adds the DescribeSourceMetadata API. This API can be used to view the stream information of the flow's source.
* NetworkMonitor (3.7.300.0)
	* CloudWatch Network Monitor is a new service within CloudWatch that will help network administrators and operators continuously monitor network performance metrics such as round-trip-time and packet loss between their AWS-hosted applications and their on-premises locations.
* Omics (3.7.300.25)
	* Provides minor corrections and an updated description of APIs.
* S3 (3.7.305.0)
	* Added additional examples for some operations.
* SecretsManager (3.7.302.0)
	* Update endpoint rules and examples.
* Core 3.7.300.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.714.0 (2023-12-21 19:22 UTC)
* AppIntegrationsService (3.7.301.0)
	* The Amazon AppIntegrations service adds DeleteApplication API for deleting applications, and updates APIs to support third party applications reacting to workspace events and make data requests to Amazon Connect for agent and contact events.
* BedrockAgent (3.7.301.0)
	* This release introduces Amazon Aurora as a vector store on Knowledge Bases for Amazon Bedrock
* CodeCommit (3.7.301.0)
	* AWS CodeCommit now supports customer managed keys from AWS Key Management Service. UpdateRepositoryEncryptionKey is added for updating the key configuration. CreateRepository, GetRepository, BatchGetRepositories are updated with new input or output parameters.
* Connect (3.7.307.0)
	* Adds APIs to manage User Proficiencies and Predefined Attributes. Enhances StartOutboundVoiceContact API input. Introduces SearchContacts API. Enhances DescribeContact API. Adds an API to update Routing Attributes in QueuePriority and QueueTimeAdjustmentSeconds.
* MediaLive (3.7.303.0)
	* MediaLive now supports the ability to configure the audio that an AWS Elemental Link UHD device produces, when the device is configured as the source for a flow in AWS Elemental MediaConnect.
* NeptuneGraph (3.7.301.0)
	* Adds Waiters for successful creation and deletion of Graph, Graph Snapshot, Import Task and Private Endpoints for Neptune Analytics
* PrometheusService (3.7.302.0)
	* This release updates Amazon Managed Service for Prometheus APIs to support customer managed KMS keys.
* RDS (3.7.303.0)
	* This release adds support for using RDS Data API with Aurora PostgreSQL Serverless v2 and provisioned DB clusters.
* RDSDataService (3.7.301.0)
	* This release adds support for using RDS Data API with Aurora PostgreSQL Serverless v2 and provisioned DB clusters.
* S3 (3.7.304.13)
	* Fixed a bug where the part size specified on the request was being ignored for uploading non seekable streams via the transfer utility
* SageMaker (3.7.307.0)
	* Amazon SageMaker Training now provides model training container access for debugging purposes. Amazon SageMaker Search now provides the ability to use visibility conditions to limit resource access to a single domain or multiple domains.
* Core 3.7.300.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.713.0 (2023-12-20 19:33 UTC)
* AppStream (3.7.302.0)
	* This release introduces configurable clipboard, allowing admins to specify the maximum length of text that can be copied by the users from their device to the remote session and vice-versa.
* EKS (3.7.303.0)
	* Add support for cluster insights, new EKS capability that surfaces potentially upgrade impacting issues.
* GuardDuty (3.7.302.0)
	* This release 1) introduces a new API: GetOrganizationStatistics , and 2) adds a new UsageStatisticType TOP_ACCOUNTS_BY_FEATURE for GetUsageStatistics API
* ManagedBlockchainQuery (3.7.301.0)
	* Adding Confirmation Status and Execution Status to GetTransaction Response.
* MediaTailor (3.7.302.0)
	* Adds the ability to configure time shifting on MediaTailor channels using the TimeShiftConfiguration field
* Route53 (3.7.301.0)
	* Amazon Route 53 now supports the Canada West (Calgary) Region (ca-west-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Core 3.7.300.23
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.712.0 (2023-12-19 19:18 UTC)
* AppSync (3.7.302.0)
	* This release adds additional configurations on GraphQL APIs for limits on query depth, resolver count, and introspection
* ChimeSDKMeetings (3.7.301.0)
	* Add meeting features to specify a maximum camera resolution, a maximum content sharing resolution, and a maximum number of attendees for a given meeting.
* EC2 (3.7.310.0)
	* Provision BYOIPv4 address ranges and advertise them by specifying the network border groups option in Los Angeles, Phoenix and Dallas AWS Local Zones.
* FSx (3.7.303.0)
	* Added support for FSx for OpenZFS on-demand data replication across AWS accounts and/or regions.Added the IncludeShared attribute for DescribeSnapshots.Added the CopyStrategy attribute for OpenZFSVolumeConfiguration.
* MarketplaceCatalog (3.7.302.0)
	* AWS Marketplace now supports a new API, BatchDescribeEntities, which returns metadata and content for multiple entities.
* RDS (3.7.302.0)
	* RDS - The release adds two new APIs: DescribeDBRecommendations and ModifyDBRecommendation
* Core 3.7.300.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.711.0 (2023-12-18 19:20 UTC)
* CognitoIdentityProvider (3.7.301.0)
	* Amazon Cognito now supports trigger versions that define the fields in the request sent to pre token generation Lambda triggers.
* EKS (3.7.302.0)
	* Add support for EKS Cluster Access Management.
* QuickSight (3.7.303.2)
	* A docs-only release to add missing entities to the API reference.
* Route53Resolver (3.7.301.0)
	* Add DOH protocols in resolver endpoints.
* Core 3.7.300.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.710.0 (2023-12-15 19:37 UTC)
* Cloud9 (3.7.301.7)
	* Updated Cloud9 API documentation for AL2023 release
* Connect (3.7.306.0)
	* Adds relatedContactId field to StartOutboundVoiceContact API input. Introduces PauseContact API and ResumeContact API for Task contacts. Adds pause duration, number of pauses, timestamps for last paused and resumed events to DescribeContact API response. Adds new Rule type and new Rule action.
* ConnectCases (3.7.301.0)
	* Increase number of fields that can be included in CaseEventIncludedData from 50 to 200
* KeyManagementService (3.7.300.20)
	* Documentation updates for AWS Key Management Service
* RDS (3.7.301.15)
	* Updates Amazon RDS documentation by adding code examples
* SageMaker (3.7.306.0)
	* This release 1) introduces a new API: DeleteCompilationJob , and 2) adds InfraCheckConfig for Create/Describe training job API
* Core 3.7.300.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.709.0 (2023-12-14 19:31 UTC)
* AppStream (3.7.301.0)
	* This release includes support for images of Windows Server 2022 platform.
* B2bi (3.7.300.10)
	* Documentation updates for AWS B2B Data Interchange
* BillingConductor (3.7.302.0)
	* Billing Conductor is releasing a new API, GetBillingGroupCostReport, which provides the ability to retrieve/view the Billing Group Cost Report broken down by attributes for a specific billing group.
* Connect (3.7.305.0)
	* This release adds support for more granular billing using tags (key:value pairs)
* ControlTower (3.7.303.10)
	* Documentation updates for AWS Control Tower.
* GameLift (3.7.301.0)
	* Amazon GameLift adds the ability to add and update the game properties of active game sessions.
* IoT (3.7.303.0)
	* This release adds the ability to self-manage certificate signing in AWS IoT Core fleet provisioning using the new certificate provider resource.
* KinesisFirehose (3.7.301.0)
	* This release, 1) adds configurable buffering hints for the Splunk destination, and 2) reduces the minimum configurable buffering interval for supported destinations
* NeptuneGraph (3.7.300.0)
	* This is the initial SDK release for Amazon Neptune Analytics
* OpenSearchService (3.7.302.0)
	* Updating documentation for Amazon OpenSearch Service support for new zero-ETL integration with Amazon S3.
* QuickSight (3.7.303.0)
	* Update Dashboard Links support; SingleAxisOptions support; Scatterplot Query limit support.
* WorkSpaces (3.7.301.11)
	* Updated note to ensure customers understand running modes.
* Core 3.7.300.19
	* Update endpoint resolution logic in all services to allow the combination of the ServiceURL and AuthenticationRegion on the client config to drive the SDK's internal endpoint selection logic. This is necessary when working with Amazon S3 buckets on Snowball Edge devices.
	* Update format of user agent string to be consistent with other AWS SDKs
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.708.0 (2023-12-13 19:47 UTC)
* Drs (3.7.301.0)
	* Adding AgentVersion to SourceServer and RecoveryInstance structures
* Core 3.7.300.18
	* Addressed performance degradation in Amazon.Runtime.ClientConfig (Configuration files were being read unnecessarily)
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.707.0 (2023-12-12 19:17 UTC)
* CloudWatchLogs (3.7.302.0)
	* This release introduces the StartLiveTail API to tail ingested logs in near real time.
* Imagebuilder (3.7.302.0)
	* This release adds the Image Workflows feature to give more flexibility and control over the image building and testing process.
* LocationService (3.7.302.0)
	* This release 1)  adds sub-municipality field in Places API for searching and getting places information, and 2) allows optimizing route calculation based on expected arrival time.
* Core 3.7.300.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.706.0 (2023-12-11 19:24 UTC)
* Neptune (3.7.301.0)
	* This release adds a new parameter configuration setting to the Neptune cluster related APIs that can be leveraged to switch between the underlying supported storage modes.
* Pinpoint (3.7.300.17)
	* This release includes Amazon Pinpoint API documentation updates pertaining to campaign message sending rate limits.
* SecurityHub (3.7.303.0)
	* Added new resource detail objects to ASFF, including resources for AwsDynamoDbTable, AwsEc2ClientVpnEndpoint, AwsMskCluster, AwsS3AccessPoint, AwsS3Bucket

### 3.7.705.0 (2023-12-08 19:17 UTC)
* CloudWatch (3.7.301.0)
	* Adds support for the OpenTelemetry 1.0 output format in CloudWatch Metric Streams.
* EC2 (3.7.309.0)
	* M2 Mac instances are built on Apple M2 Mac mini computers. I4i instances are powered by 3rd generation Intel Xeon Scalable processors. C7i compute optimized, M7i general purpose and R7i memory optimized instances are powered by custom 4th Generation Intel Xeon Scalable processors.
* Finspace (3.7.303.0)
	* Releasing Scaling Group, Dataview, and Volume APIs

### 3.7.704.0 (2023-12-07 19:36 UTC)
* CodeDeploy (3.7.301.0)
	* This release adds support for two new CodeDeploy features: 1) zonal deployments for Amazon EC2 in-place deployments, 2) deployments triggered by Auto Scaling group termination lifecycle hook events.
* Core 3.7.300.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.703.0 (2023-12-06 19:17 UTC)
* Backup (3.7.303.0)
	* AWS Backup - Features: Add VaultType to the output of DescribeRecoveryPoint, ListRecoveryPointByBackupVault API and add ResourceType to the input of ListRestoreJobs API
* Comprehend (3.7.300.15)
	* Documentation updates for Trust and Safety features.
* Connect (3.7.304.0)
	* Releasing Tagging Support for Instance Management APIS
* EC2 (3.7.308.0)
	* Releasing the new cpuManufacturer attribute within the DescribeInstanceTypes API response which notifies our customers with information on who the Manufacturer is for the processor attached to the instance, for example: Intel.
* PaymentCryptography (3.7.301.0)
	* AWS Payment Cryptography IPEK feature release
* S3 (3.7.304.4)
	* Reuse S3ExpressCredentialProvider when checking if the request should be retried
	* Fix AmazonS3Uri.EndpointRegexMatch to use non-capturing groups for S3 and S3Express values
* Core 3.7.300.15
	* Fix: Generate correct unmarshallers for exceptions that are not attached to an operation. Currently this only applies to event stream operations.
	* All services packages updated to require new Core

### 3.7.702.0 (2023-12-05 19:18 UTC)
* Athena (3.7.302.0)
	* Adding IdentityCenter enabled request for interactive query
* CleanRoomsML (3.7.301.0)
	* Updated service title from cleanroomsml to CleanRoomsML.
* CloudFormation (3.7.302.1)
	* Documentation update, December 2023
* EC2 (3.7.307.0)
	* Adds A10G, T4G, and H100 as accelerator name options and Habana as an accelerator manufacturer option for attribute based selection
* Core 3.7.300.14
	* Fix: Add intitial-response and initial-request event types and event handlers. Update generator so all exceptions inherit their base exceptions, even if not modeled as part of the operation's error list.
	* All services packages updated to require new Core

### 3.7.701.0 (2023-12-04 19:22 UTC)
* AppRegistry (3.7.301.12)
	* Documentation-only updates for Dawn
* BillingConductor (3.7.301.0)
	* This release adds the ability to specify a linked account of the billing group for the custom line item resource.
* Braket (3.7.301.0)
	* This release enhances service support to create quantum tasks and hybrid jobs associated with Braket Direct Reservations.
* Cloud9 (3.7.301.0)
	* This release adds the requirement to include the imageId parameter in the CreateEnvironmentEC2 API call.
* CloudFormation (3.7.302.0)
	* Including UPDATE_* states as a success status for CreateStack waiter.
* Finspace (3.7.302.0)
	* Release General Purpose type clusters
* Macie Classic (Removed)
	* Amazon Macie Classic has been removed from the SDK because it has been discontinued. Use the new Amazon Macie instead.
* MediaLive (3.7.302.0)
	* Adds support for custom color correction on channels using 3D LUT files.
* Core 3.7.300.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.700.0 (2023-12-01 19:15 UTC)
* QConnect (3.7.301.0)
	* This release adds the PutFeedback API and allows providing feedback against the specified assistant for the specified target.
* RecycleBin (3.7.301.0)
	* Added resource identifier in the output and updated error handling.
* VerifiedPermissions (3.7.302.0)
	* Adds description field to PolicyStore API's and namespaces field to GetSchema.

### 3.7.699.0 (2023-11-30 19:05 UTC)
* ARCZonalShift (3.7.301.0)
	* This release adds a new capability, zonal autoshift. You can configure zonal autoshift so that AWS shifts traffic for a resource away from an Availability Zone, on your behalf, when AWS determines that there is an issue that could potentially affect customers in the Availability Zone.
* Glue (3.7.304.0)
	* Adds observation and analyzer support to the GetDataQualityResult and BatchGetDataQualityResult APIs.
* SageMaker (3.7.305.0)
	* This release adds support for 1/ Code Editor, based on Code-OSS, Visual Studio Code Open Source, a new fully managed IDE option in SageMaker Studio  2/ JupyterLab, a new fully managed JupyterLab IDE experience in SageMaker Studio

### 3.7.698.0 (2023-11-30 01:20 UTC)
* MarketplaceAgreement (3.7.300.0)
	* The AWS Marketplace Agreement Service provides an API interface that helps AWS Marketplace sellers manage their agreements, including listing, filtering, and viewing details about their agreements.
* MarketplaceCatalog (3.7.301.0)
	* This release enhances the ListEntities API to support new entity type-specific strongly typed filters in the request and entity type-specific strongly typed summaries in the response.
* MarketplaceDeployment (3.7.300.0)
	* AWS Marketplace Deployment is a new service that provides essential features that facilitate the deployment of software, data, and services procured through AWS Marketplace.
* RedshiftServerless (3.7.302.0)
	* This release adds the following support for Amazon Redshift Serverless: 1) cross-account cross-VPCs, 2) copying snapshots across Regions, 3) scheduling snapshot creation, and 4) restoring tables from a recovery point.
* Core 3.7.300.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.697.0 (2023-11-29 19:00 UTC)
* ApplicationAutoScaling (3.7.301.0)
	* Amazon SageMaker customers can now use Application Auto Scaling to automatically scale the number of Inference Component copies across an endpoint to meet the varying demand of their workloads.
* CleanRooms (3.7.302.0)
	* AWS Clean Rooms now provides differential privacy to protect against user-identification attempts and machine learning modeling to allow two parties to identify similar users in their data.
* CleanRoomsML (3.7.300.0)
	* Public Preview SDK release of AWS Clean Rooms ML APIs
* OpenSearchServerless (3.7.301.0)
	* Amazon OpenSearch Serverless collections support an additional attribute called standby-replicas. This allows to specify whether a collection should have redundancy enabled.
* OpenSearchService (3.7.301.0)
	* Launching Amazon OpenSearch Service support for new zero-ETL integration with Amazon S3. Customers can now manage their direct query data sources to Amazon S3 programatically
* SageMaker (3.7.304.0)
	* This release adds following support 1/ Improved SDK tooling for model deployment. 2/ New Inference Component based features to lower inference costs and latency 3/ SageMaker HyperPod management. 4/ Additional parameters for FM Fine Tuning in Autopilot
* SageMakerRuntime (3.7.301.0)
	* This release adds InferenceComponentName to InvokeEndpoint and InvokeEndpointWithResponseStream APIs to get inferences from the deployed InferenceComponents.
* SecurityToken (3.7.300.12)
	* Documentation updates for AWS Security Token Service.

### 3.7.696.0 (2023-11-28 19:14 UTC)
* AccessAnalyzer (3.7.302.0)
	* This release adds support for external access findings for S3 directory buckets to help you easily identify cross-account access. Updated service API, documentation, and paginators.
* Bedrock (3.7.301.0)
	* This release adds support for customization types, model life cycle status and minor versions/aliases for model identifiers.
* BedrockAgent (3.7.300.0)
	* This release introduces Agents for Amazon Bedrock
* BedrockAgentRuntime (3.7.300.0)
	* This release introduces Agents for Amazon Bedrock Runtime
* BedrockRuntime (3.7.301.0)
	* This release adds support for minor versions/aliases for invoke model identifier.
* Connect (3.7.303.0)
	* Added support for following capabilities: Amazon Connect's in-app, web, and video calling. Two-way SMS integrations. Contact Lens real-time chat analytics feature. Amazon Connect Analytics Datalake capability. Capability to configure real time chat rules.
* CustomerProfiles (3.7.301.0)
	* This release introduces DetectProfileObjectType API to auto generate object type mapping.
* QBusiness (3.7.300.0)
	* Amazon Q - a generative AI powered application that your employees can use to ask questions and get answers from knowledge spread across disparate content repositories, summarize reports, write articles, take actions, and much more - all within their company's connected content repositories.
* QConnect (3.7.300.0)
	* Amazon Q in Connect, an LLM-enhanced evolution of Amazon Connect Wisdom. This release adds generative AI support to Amazon Q Connect QueryAssistant and GetRecommendations APIs.
* S3 (3.7.304.0)
	* Adds support for S3 Express One Zone.
	* Update DefaultS3ExpressCredentialProvider to gracefully handle deleted buckets
* S3Control (3.7.304.0)
	* Adds support for S3 Express One Zone, and InvocationSchemaVersion 2.0 for S3 Batch Operations.
* Core 3.7.300.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.695.0 (2023-11-28 05:39 UTC)
* BedrockRuntime (3.7.300.10)
	* Remove custom code for PayloadPart and add integration tests for event stream apis.
* ElastiCache (3.7.301.0)
	* Launching Amazon ElastiCache Serverless that enables you to create a cache in under a minute without any capacity management. ElastiCache Serverless monitors the cache's memory, CPU, and network usage and scales both vertically and horizontally to support your application's requirements.
* Lambda (3.7.303.6)
	* Deprecate constructors that take in IEventStreamMessage for InvokeWithResponseStreamCompleteEvent and InvokeWithResponseStreamUpdate. This was used internally in the SDK and there is no customer impact.
* SageMakerRuntime (3.7.300.10)
	* Deprecate constructor for PayloadPart that takes in IEventStreamMessage. This was used internally in the SDK and there is no customer impact.
* Core 3.7.300.10
	* Update code generation for event streams to work with non-blob/string payloads and add support for streaming exceptions from event stream responses
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.694.0 (2023-11-27 20:15 UTC)
* AppSync (3.7.301.0)
	* This update enables introspection of Aurora cluster databases using the RDS Data API
* B2bi (3.7.300.0)
	* This is the initial SDK release for AWS B2B Data Interchange.
* Backup (3.7.302.0)
	* AWS Backup now supports restore testing, a new feature that allows customers to automate restore testing and validating their backups. Additionally, this release adds support for EBS Snapshots Archive tier.
* ControlTower (3.7.303.0)
	* This release adds the following support: 1. The EnableControl API can configure controls that are configurable.  2. The GetEnabledControl API shows the configured parameters on an enabled control. 3. The new UpdateEnabledControl API can change parameters on an enabled control.
* ElasticFileSystem (3.7.302.0)
	* Adding support for EFS Replication to existing file system.
* FIS (3.7.301.0)
	* AWS FIS adds support for multi-account experiments & empty target resolution. This release also introduces the CreateTargetAccountConfiguration API that allows experiments across multiple AWS accounts, and the ListExperimentResolvedTargets API to list target details.
* Glue (3.7.303.0)
	* add observations support to DQ CodeGen config model + update document for connectiontypes supported by ConnectorData entities
* RDS (3.7.301.4)
	* Updates Amazon RDS documentation for support for RDS for Db2.
* SecurityHub (3.7.302.0)
	* Adds and updates APIs to support central configuration. This feature allows the Security Hub delegated administrator to configure Security Hub for their entire AWS Org across multiple regions from a home Region. With this release, findings also include account name and application metadata.
* TranscribeService (3.7.302.0)
	* This release adds support for AWS HealthScribe APIs within Amazon Transcribe
* Core 3.7.300.9
	* Fix `RegionEndpointProviderV3` not to throw an exception when application is deployed to the root folder
	* All services packages updated to require new Core

### 3.7.693.0 (2023-11-27 04:24 UTC)
* AccessAnalyzer (3.7.301.0)
	* IAM Access Analyzer now continuously monitors IAM roles and users in your AWS account or organization to generate findings for unused access. Additionally, IAM Access Analyzer now provides custom policy checks to validate that IAM policies adhere to your security standards ahead of deployments.
* BCMDataExports (3.7.300.0)
	* Users can create, read, update, delete Exports of billing and cost management data.  Users can get details of Export Executions and details of Tables for exporting.  Tagging support is provided for Exports
* CloudTrail (3.7.302.0)
	* CloudTrail Lake now supports federating event data stores. giving users the ability to run queries against their event data using Amazon Athena.
* CloudWatchLogs (3.7.301.0)
	* Added APIs to Create, Update, Get, List and Delete LogAnomalyDetectors and List and Update Anomalies in Detector. Added LogGroupClass attribute for LogGroups to classify loggroup as Standard loggroup with all capabilities or InfrequentAccess loggroup with limited capabilities.
* CodeStarconnections (3.7.303.0)
	* This release adds support for the CloudFormation Git sync feature. Git sync enables updating a CloudFormation stack from a template stored in a Git repository.
* ComputeOptimizer (3.7.301.0)
	* This release enables AWS Compute Optimizer to analyze and generate recommendations with customization and discounts preferences.
* ConfigService (3.7.301.0)
	* Support Periodic Recording for Configuration Recorder
* ControlTower (3.7.302.0)
	* Add APIs to create and manage a landing zone.
* CostOptimizationHub (3.7.300.0)
	* This release launches Cost Optimization Hub, a new AWS Billing and Cost Management feature that helps you consolidate and prioritize cost optimization recommendations across your AWS Organizations member accounts and AWS Regions, so that you can get the most out of your AWS spend.
* Detective (3.7.301.0)
	* Added new APIs in Detective to support resource investigations
* ECS (3.7.302.0)
	* Adds a new 'type' property to the Setting structure. Adds a new AccountSetting - guardDutyActivate for ECS.
* EKS (3.7.301.0)
	* This release adds support for EKS Pod Identity feature. EKS Pod Identity makes it easy for customers to obtain IAM permissions for the applications running in their EKS clusters.
* EKSAuth (3.7.300.0)
	* This release adds support for EKS Pod Identity feature. EKS Pod Identity makes it easy for customers to obtain IAM permissions for their applications running in the EKS clusters.
* ElasticFileSystem (3.7.301.0)
	* Adding support for EFS Archive lifecycle configuration.
* ElasticLoadBalancingV2 (3.7.301.0)
	* This release enables both mutual authentication (mTLS), and Automatic Target Weights (ATW) for Application Load Balancers.
* FreeTier (3.7.300.0)
	* This is the initial SDK release for the AWS Free Tier GetFreeTierUsage API
* FSx (3.7.302.0)
	* Added support for FSx for ONTAP scale-out file systems and FlexGroup volumes. Added the HAPairs field and ThroughputCapacityPerHAPair for filesystem. Added AggregateConfiguration (containing Aggregates and ConstituentsPerAggregate) and SizeInBytes for volume.
* GuardDuty (3.7.301.0)
	* Add support for Runtime Monitoring for ECS and ECS-EC2.
* IoTFleetWise (3.7.301.0)
	* AWS IoT FleetWise introduces new APIs for vision system data, such as data collected from cameras, radars, and lidars. You can now model and decode complex data types.
* LakeFormation (3.7.301.0)
	* This release adds four new APIs "DescribeLakeFormationIdentityCenterConfiguration", "CreateLakeFormationIdentityCenterConfiguration", "DescribeLakeFormationIdentityCenterConfiguration", and "DeleteLakeFormationIdentityCenterConfiguration", and also updates the corresponding documentation.
* LexModelsV2 (3.7.301.0)
	* This release introduces new generative AI features in AWS Lex: Assisted Slot Resolution, Descriptive Bot Building, and Sample Utterance Generation. These features leverage large language models available through Amazon Bedrock to improve the bot builder and customer experiences.
* LexRuntimeV2 (3.7.301.0)
	* This release introduces support for interpretationSource in the runtime service response.
* ManagedBlockchain (3.7.301.0)
	* Add optional NetworkType property to Accessor APIs
* Personalize (3.7.301.0)
	* Enables metadata in recommendations, recommendations with themes, and next best action recommendations
* PersonalizeEvents (3.7.301.0)
	* This release enables PutActions and PutActionInteractions
* PersonalizeRuntime (3.7.301.0)
	* Enables metadata in recommendations and next best action recommendations
* PrometheusService (3.7.301.0)
	* This release adds support for the Amazon Managed Service for Prometheus collector, a fully managed, agentless Prometheus metrics scraping capability.
* QuickSight (3.7.302.0)
	* This release launches new APIs for trusted identity propagation setup and supports creating datasources using trusted identity propagation as authentication method for QuickSight accounts configured with IAM Identity Center.
* Redshift (3.7.303.0)
	* This release adds support for multi-data warehouse writes through data sharing.
* Repostspace (3.7.300.0)
	* Initial release of AWS re:Post Private
* S3 (3.7.303.0)
	* Adding new params - Key and Prefix, to S3 API operations for supporting S3 Access Grants. Note - These updates will not change any of the existing S3 API functionality.
* S3Control (3.7.303.0)
	* Introduce Amazon S3 Access Grants, a new S3 access control feature that maps identities in directories such as Active Directory, or AWS Identity and Access Management (IAM) Principals, to datasets in S3.
* SecretsManager (3.7.301.0)
	* AWS Secrets Manager has released the BatchGetSecretValue API, which allows customers to fetch up to 20 Secrets with a single request using a list of secret names or filters.
* SecurityHub (3.7.301.0)
	* Adds and updates APIs to support customizable security controls. This feature allows Security Hub customers to provide custom parameters for security controls. With this release, findings for controls that support custom parameters will include the parameters used to generate the findings.
* StepFunctions (3.7.302.0)
	* Adds new TestState operation which accepts the definition of a single state and executes it. You can test a state without creating a state machine or updating an existing state machine.
* TranscribeService (3.7.301.0)
	* This release adds support for transcriptions from audio sources in 64 new languages and introduces generative call summarization in Transcribe Call Analytics (Post call)
* WorkSpaces (3.7.301.0)
	* The release introduces Multi-Region Resilience one-way data replication that allows you to replicate data from your primary WorkSpace to a standby WorkSpace in another AWS Region. DescribeWorkspaces now returns the status of data replication.
* WorkSpacesThinClient (3.7.300.0)
	* Initial release of Amazon WorkSpaces Thin Client
* Core 3.7.300.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.692.0 (2023-11-22 19:43 UTC)
* Kinesis (3.7.301.0)
	* This release adds support for resource based policies on streams and consumers.
* S3Control (3.7.302.0)
	* Amazon S3 Batch Operations now manages buckets or prefixes in a single step.
* SageMaker (3.7.303.0)
	* This feature adds the end user license agreement status as a model access configuration parameter.

### 3.7.691.0 (2023-11-21 20:04 UTC)
* CloudFront (3.7.301.0)
	* This release adds support for CloudFront KeyValueStore, a globally managed key value datastore associated with CloudFront Functions.
* CloudFrontKeyValueStore (3.7.300.0)
	* This release adds support for CloudFront KeyValueStore, a globally managed key value datastore associated with CloudFront Functions.
* EC2 (3.7.306.1)
	* Documentation updates for Amazon EC2.
* InspectorScan (3.7.300.0)
	* This release adds support for the new Amazon Inspector Scan API. The new Inspector Scan API can synchronously scan SBOMs adhering to the CycloneDX v1.5 format.
* IoTSiteWise (3.7.301.0)
	* Adds 1/ user-defined unique identifier for asset and model metadata, 2/ asset model components, and 3/ query API for asset metadata and telemetry data. Supports 4/ multi variate anomaly detection using Amazon Lookout for Equipment, 5/ warm storage tier, and 6/ buffered ingestion of time series data.
* IoTTwinMaker (3.7.301.0)
	* This release adds following support. 1. New APIs for metadata bulk operations. 2. Modify the component type API to support composite component types - nesting component types within one another. 3. New list APIs for components and properties. 4. Support the larger scope digital twin modeling.
* S3 (3.7.302.0)
	* Add support for automatic date based partitioning in S3 Server Access Logs.
* Core 3.7.300.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.690.0 (2023-11-20 20:21 UTC)
* CodeStarconnections (3.7.302.0)
	* This release updates a few CodeStar Connections related APIs.
* DocDB (3.7.301.0)
	* Amazon DocumentDB updates for new cluster storage configuration: Amazon DocumentDB I/O-Optimized.
* EC2 (3.7.306.0)
	* This release adds support for Security group referencing over Transit gateways, enabling you to simplify Security group management and control of instance-to-instance traffic across VPCs that are connected by Transit gateway.
* Core 3.7.300.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.689.0 (2023-11-17 20:36 UTC)
* AppMesh (3.7.301.0)
	* Change the default value of these fields from 0 to null: MaxConnections, MaxPendingRequests, MaxRequests, HealthCheckThreshold, PortNumber, and HealthCheckPolicy -> port. Users are not expected to perceive the change, except that badRequestException is thrown when required fields missing configured.
* Athena (3.7.301.0)
	* Adding SerivicePreProcessing time metric
* Cloud9 (3.7.300.5)
	* A minor doc only update related to changing the date of an API change.
* CloudFormation (3.7.301.0)
	* This release adds a new flag ImportExistingResources to CreateChangeSet. Specify this parameter on a CREATE- or UPDATE-type change set to import existing resources with custom names instead of recreating them.
* CodePipeline (3.7.301.0)
	* CodePipeline now supports overriding source revisions to achieve manual re-deploy of a past revision
* CodeStarconnections (3.7.301.0)
	* This release adds support for the CloudFormation Git sync feature. Git sync enables updating a CloudFormation stack from a template stored in a Git repository.
* Connect (3.7.302.0)
	* This release adds WISDOM_QUICK_RESPONSES as new IntegrationType of Connect IntegrationAssociation resource and bug fixes.
* ConnectWisdomService (3.7.301.0)
	* This release adds QuickResponse as a new Wisdom resource and Wisdom APIs for import, create, read, search, update and delete QuickResponse resources.
* DLM (3.7.301.1)
	* Added support for SAP HANA in Amazon Data Lifecycle Manager EBS snapshot lifecycle policies with pre and post scripts.
* EC2 (3.7.305.0)
	* This release adds new features for Amazon VPC IP Address Manager (IPAM) Allowing a choice between Free and Advanced Tiers, viewing public IP address insights across regions and in Amazon Cloudwatch, use IPAM to plan your subnet IPs within a VPC and bring your own autonomous system number to IPAM.
* ECR (3.7.301.0)
	* Documentation and operational updates for Amazon ECR, adding support for pull through cache rules for upstream registries that require authentication.
* ElasticMapReduce (3.7.302.0)
	* Launch support for IAM Identity Center Trusted Identity Propagation and workspace storage encryption using AWS KMS in EMR Studio
* EventBridge (3.7.301.0)
	* Introduces a new rule state ENABLED_WITH_ALL_CLOUDTRAIL_MANAGEMENT_EVENTS for matching with Get, List and Describe AWS API call events from CloudTrail.
* InternetMonitor (3.7.301.0)
	* Adds new querying capabilities for running data queries on a monitor
* IVS (3.7.301.0)
	* type & defaulting refinement to various range properties
* Ivschat (3.7.301.0)
	* type & defaulting refinement to various range properties
* KinesisVideo (3.7.300.5)
	* Docs only build to bring up-to-date with public docs.
* LocationService (3.7.301.0)
	* Remove default value and allow nullable for request parameters having minimum value larger than zero.
* MediaLive (3.7.301.0)
	* MediaLive has now added support for per-output static image overlay.
* Mgn (3.7.301.0)
	* Removed invalid and unnecessary default values.
* OSIS (3.7.301.0)
	* Add support for enabling a persistent buffer when creating or updating an OpenSearch Ingestion pipeline. Add tags to Pipeline and PipelineSummary response models.
* Pipes (3.7.302.0)
	* TargetParameters now properly supports BatchJobParameters.ArrayProperties.Size and BatchJobParameters.RetryStrategy.Attempts being optional, and EcsTaskParameters.Overrides.EphemeralStorage.SizeInGiB now properly required when setting EphemeralStorage
* RDS (3.7.301.0)
	* This release adds support for option groups and replica enhancements to Amazon RDS Custom.
* Redshift (3.7.302.0)
	* Updated SDK for Amazon Redshift, which you can use to configure a connection with IAM Identity Center to manage access to databases. With these, you can create a connection through a managed application. You can also change a managed application, delete it, or get information about an existing one.
* RedshiftServerless (3.7.301.0)
	* Updated SDK for Amazon Redshift Serverless, which provides the ability to configure a connection with IAM Identity Center to manage user and group access to databases.
* S3 (3.7.301.0)
	* Removes all default 0 values for numbers and false values for booleans
* SecurityToken (3.7.300.5)
	* API updates for the AWS Security Token Service
* SSOAdmin (3.7.302.0)
	* Improves support for configuring RefreshToken and TokenExchange grants on applications.
* SSOOIDC (3.7.301.0)
	* Adding support for `sso-oauth:CreateTokenWithIAM`.
* TrustedAdvisor (3.7.300.0)
	* AWS Trusted Advisor introduces new APIs to enable you to programmatically access Trusted Advisor best practice checks, recommendations, and prioritized recommendations. Trusted Advisor APIs enable you to integrate Trusted Advisor with your operational tools to automate your workloads.
* VerifiedPermissions (3.7.301.0)
	* Adding BatchIsAuthorized API which supports multiple authorization requests against a PolicyStore
* Core 3.7.300.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.688.0 (2023-11-16 19:33 UTC)
* CodeCatalyst (3.7.302.0)
	* This release includes updates to the Dev Environment APIs to include an optional vpcConnectionName parameter that supports using Dev Environments with Amazon VPC.
* DLM (3.7.301.0)
	* This release adds support for Amazon Data Lifecycle Manager default policies for EBS snapshots and EBS-backed AMIs.
* DynamoDBv2 (3.7.300.4)
	* Add support for retrieving DateTime attributes in UTC timezone from a DynamoDB table.
	* Fix regression in 3.7.300 where the DataModel stop mapping to non public properties.
* EC2 (3.7.304.0)
	* Enable use of tenant-specific PublicSigningKeyUrl from device trust providers and onboard jumpcloud as a new device trust provider.
* FSx (3.7.301.0)
	* Enables customers to update their PerUnitStorageThroughput on their Lustre file systems.
* Glue (3.7.302.0)
	* Introduces new column statistics APIs to support statistics generation for tables within the Glue Data Catalog.
* Imagebuilder (3.7.301.0)
	* This release adds the Image Lifecycle Management feature to automate the process of deprecating, disabling and deleting outdated images and their associated resources.
* IoT (3.7.302.0)
	* GA release the ability to index and search devices based on their GeoLocation data. With GeoQueries you can narrow your search to retrieve devices located in the desired geographic boundary.
* IVSRealTime (3.7.301.0)
	* This release introduces server side composition and recording for stages.
* Kafka (3.7.301.0)
	* Added a new API response field which determines if there is an action required from the customer regarding their cluster.
* Lambda (3.7.303.0)
	* Adds support for logging configuration in Lambda Functions. Customers will have more control how their function logs are captured and to which cloud watch log group they are delivered also.
* Macie2 (3.7.301.0)
	* This release adds support for configuring Macie to assume an IAM role when retrieving sample occurrences of sensitive data reported by findings.
* MediaPackage (3.7.301.0)
	* DRM_TOP_LEVEL_COMPACT allows placing content protection elements at the MPD level and referenced at the AdaptationSet level
* PinpointSMSVoiceV2 (3.7.301.0)
	* Amazon Pinpoint now offers additional operations as part of version 2 of the SMS and voice APIs. This release includes 26 new APIs to create and manage phone number registrations, add verified destination numbers, and request sender IDs.
* Polly (3.7.301.0)
	* Add new engine - long-form - dedicated for longer content, such as news articles, training materials, or marketing videos.
* QuickSight (3.7.301.0)
	* Custom permission support for QuickSight roles; Three new datasources STARBURST, TRINO, BIGQUERY; Lenient mode changes the default behavior to allow for exporting and importing with certain UI allowed errors, Support for permissions and tags export and import.
* SageMaker (3.7.302.0)
	* Amazon SageMaker Studio now supports Trainium instance types - trn1.2xlarge, trn1.32xlarge, trn1n.32xlarge.
* SimpleSystemsManagement (3.7.301.0)
	* This release introduces the ability to filter automation execution steps which have parent steps. In addition, runbook variable information is returned by GetAutomationExecution and parent step information is returned by the DescribeAutomationStepExecutions API.
* SSMIncidents (3.7.301.0)
	* Introduces new APIs ListIncidentFindings and BatchGetIncidentFindings to use findings related to an incident.
* SSOAdmin (3.7.301.0)
	* Instances bound to a single AWS account, API operations for managing instances and applications, and assignments to applications are now supported. Trusted identity propagation is also supported, with new API operations for managing trusted token issuers and application grants and scopes.
* Transfer (3.7.301.0)
	* Introduced S3StorageOptions for servers to enable directory listing optimizations and added Type fields to logical directory mappings.
* Core 3.7.300.4
	* Add public setters to ChecksumData properties
	* Add support for retrieving DateTime attributes in UTC timezone from a DynamoDB table.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.687.0 (2023-11-15 19:30 UTC)
* AutoScaling (3.7.301.0)
	* This release introduces Instance Maintenance Policy, a new EC2 Auto Scaling capability that allows customers to define whether instances are launched before or after existing instances are terminated during instance replacement operations.
* CloudTrail (3.7.301.0)
	* The Lake Repricing feature lets customers configure a BillingMode for an event data store. The BillingMode determines the cost for ingesting and storing events and the default and maximum retention period for the event data store.
* CodeCatalyst (3.7.301.0)
	* This release adds functionality for retrieving information about workflows and workflow runs and starting workflow runs in Amazon CodeCatalyst.
* EC2 (3.7.303.0)
	* AWS EBS now supports Snapshot Lock, giving users the ability to lock an EBS Snapshot to prohibit deletion of the snapshot. This release introduces the LockSnapshot, UnlockSnapshot & DescribeLockedSnapshots APIs to manage lock configuration for snapshots. The release also includes the dl2q_24xlarge.
* Finspace (3.7.301.0)
	* Adding deprecated trait on Dataset Browser Environment APIs
* FinSpaceData (3.7.301.0)
	* Adding deprecated trait to APIs in this name space.
* Lambda (3.7.302.0)
	* Add Java 21 (java21) support to AWS Lambda
* MWAA (3.7.301.0)
	* This Amazon MWAA release adds support for customer-managed VPC endpoints. This lets you choose whether to create, and manage your environment's VPC endpoints, or to have Amazon MWAA create, and manage them for you.
* RDS (3.7.300.4)
	* Updates Amazon RDS documentation for support for upgrading RDS for MySQL snapshots from version 5.7 to version 8.0.
* Redshift (3.7.301.0)
	* The custom domain name SDK for Amazon Redshift provisioned clusters is updated with additional required parameters for modify and delete operations. Additionally, users can provide domain names with longer top-level domains.
* S3Control (3.7.301.0)
	* Add 5 APIs to create, update, get, list, delete S3 Storage Lens group(eg. CreateStorageLensGroup), 3 APIs for tagging(TagResource,UntagResource,ListTagsForResource), and update to StorageLensConfiguration to allow metrics to be aggregated on Storage Lens groups.
* SsmSap (3.7.301.0)
	* Update the default value of MaxResult to 50.
* Core 3.7.300.3
	* Update .NET 8 targeted versions of AWSSDK.Extensions.CrtIntegration and AWSSDK.Extensions.NETCore.Setup to have a dependency on AWSSDK.Core version 3.7.300.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.686.0 (2023-11-14 19:25 UTC)
* Backup (3.7.301.0)
	* AWS Backup - Features: Provide Job Summary for your backup activity.
* CleanRooms (3.7.301.0)
	* This feature provides the ability for the collaboration creator to configure either the member who can run queries or a different member in the collaboration to be billed for query compute costs.
* Connect (3.7.301.0)
	* Introducing SegmentAttributes parameter for StartChatContact API
* DynamoDBv2 (3.7.300.2)
	* Expose IsLimitSet and IsSegmentSet properties for Scan and Query operations.
* Glue (3.7.301.0)
	* Introduces new storage optimization APIs to support automatic compaction of Apache Iceberg tables.
* IoT (3.7.301.0)
	* This release introduces new attributes in API CreateSecurityProfile, UpdateSecurityProfile and DescribeSecurityProfile to support management of Metrics Export for AWS IoT Device Defender Detect.
* Lambda (3.7.301.0)
	* Add Python 3.12 (python3.12) support to AWS Lambda
* MediaTailor (3.7.301.0)
	* Removed unnecessary default values.
* Pipes (3.7.301.0)
	* Added support (via new LogConfiguration field in CreatePipe and UpdatePipe APIs) for logging to Amazon CloudWatch Logs, Amazon Simple Storage Service (Amazon S3), and Amazon Kinesis Data Firehose
* ResourceExplorer2 (3.7.301.0)
	* Resource Explorer supports multi-account search. You can now use Resource Explorer to search and discover resources across AWS accounts within your organization or organizational unit.
* SageMaker (3.7.301.0)
	* This release makes Model Registry Inference Specification fields as not required.
* Signer (3.7.300.2)
	* Documentation updates for AWS Signer
* StepFunctions (3.7.301.0)
	* This release adds support to redrive executions in AWS Step Functions with a new RedriveExecution operation.
* Core 3.7.300.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.685.0 (2023-11-13 19:52 UTC)
* AppRegistry (3.7.301.0)
	* When the customer associates a resource collection to their application with this new feature, then a new application tag will be applied to all supported resources that are part of that collection. This allows customers to more easily find the application that is associated with those resources.
* DatabaseMigrationService (3.7.301.0)
	* Added new Db2 LUW Target endpoint with related endpoint settings. New executeTimeout endpoint setting for mysql endpoint. New ReplicationDeprovisionTime field for serverless describe-replications.
* DataExchange (3.7.301.0)
	* Removed Required trait for DataSet.OriginDetails.ProductId.
* EC2 (3.7.302.0)
	* Adds the new EC2 DescribeInstanceTopology API, which you can use to retrieve the network topology of your running instances on select platform types to determine their relative proximity to each other.
* ECS (3.7.301.0)
	* Adds a Client Token parameter to the ECS RunTask API. The Client Token parameter allows for idempotent RunTask requests.
* ElasticMapReduce (3.7.301.0)
	* Updated GetClusterSessionCredentials API  to allow Amazon SageMaker Studio to connect to EMR on EC2 clusters to support IdentityCenter/PEZ integration.
* Core 3.7.300.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.684.0 (2023-11-10 19:38 UTC)
* ControlTower (3.7.301.0)
	* AWS Control Tower supports tagging for enabled controls. This release introduces TagResource, UntagResource and ListTagsForResource APIs to manage tags in existing enabled controls. It updates EnabledControl API to tag resources at creation time.
* CostAndUsageReport (3.7.301.0)
	* This release adds support for tagging and customers can now tag report definitions. Additionally, ReportStatus is now added to report definition to show when the last delivered time stamp and if it succeeded or not.
* EC2 (3.7.301.0)
	* EC2 adds API updates to enable ENA Express at instance launch time.
* FMS (3.7.300.1)
	* Adds optimizeUnassociatedWebACL flag to ManagedServiceData, updates third-party firewall examples, and other minor documentation updates.
* MarketplaceEntitlementService (3.7.301.0)
	* Add paginators to GetEntitlements.
* MediaConvert (3.7.301.0)
	* This release includes the ability to specify any input source as the primary input for corresponding follow modes, and allows users to specify fit and fill behaviors without resizing content.
* RDS (3.7.300.1)
	* Updates Amazon RDS documentation for zero-ETL integrations.

### 3.7.683.0 (2023-11-10 02:08 UTC)
* Core 3.7.300.0
	* Add .NET 8 framework target for core and service projects.
	* For .NET 8 mark all SDK assemblies as trimmable and address all trim warnings.
	* For .NET 8 prevent the System.Uri class from canonicalizing the resource path. This broke scenarios with S3 object keys like `foo/../bar.txt`.
	* For .NET 8 the System.Net.Http.HttpClient's synchronous `Send` method is used when the internal synchronous service request methods are invoked. This replaces the SDK blocking on the SendAsync method.

### 3.7.682.0 (2023-11-09 19:22 UTC)
* CloudFormation (3.7.205.0)
	* Added new ConcurrencyMode feature for AWS CloudFormation StackSets for faster deployments to target accounts.
* CloudTrail (3.7.202.0)
	* The Insights in Lake feature lets customers enable CloudTrail Insights on a source CloudTrail Lake event data store and create a destination event data store to collect Insights events based on unusual management event activity in the source event data store.
* CloudWatchLogs (3.7.202.0)
	* Update to support new APIs for delivery of logs from AWS services.
* Comprehend (3.7.201.0)
	* This release adds support for toxicity detection and prompt safety classification.
* Connect (3.7.215.0)
	* This release adds the ability to integrate customer lambda functions with Connect attachments for scanning and updates the ListIntegrationAssociations API to support filtering on IntegrationArn.
* EC2 (3.7.225.0)
	* AWS EBS now supports Block Public Access for EBS Snapshots. This release introduces the EnableSnapshotBlockPublicAccess, DisableSnapshotBlockPublicAccess and GetSnapshotBlockPublicAccessState APIs to manage account-level public access settings for EBS Snapshots in an AWS Region.
* EKS (3.7.203.0)
	* Adding EKS Anywhere subscription related operations.
* Lambda (3.7.204.0)
	* Add Custom runtime on Amazon Linux 2023 (provided.al2023) support to AWS Lambda.
* Omics (3.7.208.0)
	* Support UBAM filetype for Omics Storage and make referenceArn optional

### 3.7.681.0 (2023-11-09 01:25 UTC)
* SQS (3.7.202.0)
	* This release enables customers to call SQS using AWS JSON-1.0 protocol and bug fix.

### 3.7.680.0 (2023-11-08 19:25 UTC)
* Connect (3.7.214.0)
	* This release clarifies in our public documentation that InstanceId is a requirement for SearchUsers API requests.
* ConnectCases (3.7.203.0)
	* This release adds the ability to add/view comment authors through CreateRelatedItem and SearchRelatedItems API. For more information see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* DataSync (3.7.205.0)
	* This change allows for 0 length access keys and secret keys for object storage locations. Users can now pass in empty string credentials.
* GuardDuty (3.7.205.0)
	* Added API support for new GuardDuty EKS Audit Log finding types.
* Lambda (3.7.203.0)
	* Add Node 20 (nodejs20.x) support to AWS Lambda.
* LexModelsV2 (3.7.204.0)
	* AWS Lex now supports selective log capture in conversation logs. When you enable this option within the conversation log settings, only the utterances that trigger intents and slots specified in session attributes will be logged.
* Omics (3.7.207.0)
	* Adding Run UUID and Run Output URI: GetRun and StartRun API response has two new fields "uuid" and "runOutputUri".
* RDS (3.7.214.1)
	* This Amazon RDS release adds support for patching the OS of an RDS Custom for Oracle DB instance. You can now upgrade the database or operating system using the modify-db-instance command.
* RedshiftServerless (3.7.204.0)
	* Added a new parameter in the workgroup that helps you control your cost for compute resources. This feature provides a ceiling for RPUs that Amazon Redshift Serverless can scale up to. When automatic compute scaling is required, having a higher value for MaxRPU can enhance query throughput.
* ResilienceHub (3.7.203.0)
	* AWS Resilience Hub enhances Resiliency Score, providing actionable recommendations to improve application resilience. Amazon Elastic Kubernetes Service (EKS) operational recommendations have been added to help improve the resilience posture of your applications.
* SQS (3.7.201.0)
	* This release enables customers to call SQS using AWS JSON-1.0 protocol.
* Core 3.7.204.15
	* Bulk sync endpoint rules and tests
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.679.0 (2023-11-07 19:45 UTC)
* DataExchange (3.7.202.0)
	* Updated SendDataSetNotificationRequest Comment to be maximum length 4096.
* DLM (3.7.201.0)
	* Added support for pre and post scripts in Amazon Data Lifecycle Manager EBS snapshot lifecycle policies.
* RDS (3.7.214.0)
	* This Amazon RDS release adds support for the multi-tenant configuration. In this configuration, an RDS DB instance can contain multiple tenant databases. In RDS for Oracle, a tenant database is a pluggable database (PDB).
* S3 (3.7.205.24)
	* Fixed an issue where TransferUtility UploadAsync() is not sending metadata or headers with non-seekable stream.
* Core 3.7.204.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.678.0 (2023-11-06 19:22 UTC)
* CodeBuild (3.7.201.0)
	* AWS CodeBuild now supports AWS Lambda compute.
* Connect (3.7.213.0)
	* Added new API that allows Amazon Connect Outbound Campaigns to create contacts in Amazon Connect when ingesting your dial requests.
* CostExplorer (3.7.203.0)
	* This release extends the GetReservationPurchaseRecommendation API to support recommendations for Amazon MemoryDB reservations.
* DocDB (3.7.201.0)
	* Update the input of CreateDBInstance and ModifyDBInstance to support setting CA Certificates. Update the output of DescribeDBInstance and DescribeDBEngineVersions to show current and supported CA certificates.
* IdentityManagement (3.7.203.0)
	* Add partitional endpoint for iso-e.
* MWAA (3.7.201.0)
	* This release adds support for Apache Airflow version 2.7.2. This version release includes support for deferrable operators and triggers.
* Polly (3.7.204.0)
	* Amazon Polly adds new US English voices - Danielle and Gregory. Danielle and Gregory are available as Neural voices only.
* Route53 (3.7.203.0)
	* Add partitional endpoints for iso-e and iso-f.
* Core 3.7.204.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.677.0 (2023-11-03 19:11 UTC)
* ConfigService (3.7.203.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in October 2023.
* Connect (3.7.212.0)
	* Amazon Connect Chat introduces Create Persistent Contact Association API, allowing customers to choose when to resume previous conversations from previous chats, eliminating the need to repeat themselves and allowing agents to provide personalized service with access to entire conversation history.
* IoTWireless (3.7.201.0)
	* Added LoRaWAN version 1.0.4 support
* LaunchWizard (3.7.200.0)
	* AWS Launch Wizard is a service that helps reduce the time it takes to deploy applications to the cloud while providing a guided deployment experience.

### 3.7.676.0 (2023-11-02 18:24 UTC)
* AppRunner (3.7.204.0)
	* AWS App Runner now supports using dual-stack address type for the public endpoint of your incoming traffic.
* Connect (3.7.211.0)
	* GetMetricDataV2 API: Update to include new metrics PERCENT_NON_TALK_TIME, PERCENT_TALK_TIME, PERCENT_TALK_TIME_AGENT, PERCENT_TALK_TIME_CUSTOMER
* GameLift (3.7.202.0)
	* Amazon GameLift adds support for shared credentials, which allows applications that are deployed on managed EC2 fleets to interact with other AWS resources.
* Glue (3.7.208.0)
	* This release introduces Google BigQuery Source and Target in AWS Glue CodeGenConfigurationNode.
* NetworkFirewall (3.7.203.0)
	* This release introduces the stateless rule analyzer, which enables you to analyze your stateless rules for asymmetric routing.
* QuickSight (3.7.208.0)
	* This release introduces Float Decimal Type as SubType in QuickSight SPICE datasets and Custom week start and Custom timezone options in Analysis and Dashboard
* S3 (3.7.205.22)
	* Added support for DisablePayloadSigning for TransferUtility's upload directory feature.
	* Added RequestPayer property in CopyPartRequest class.
	* Add `DisableTrimmingLeadingSlash` flag to CopyObject and CopyPart requests, used to determine if the service client should remove leading slashes from object keys
* SSOOIDC (3.7.201.21)
	* Add RegistrationExpiresAt field to GetSsoTokenResponse.
* Core 3.7.204.12
	* Update SSO Token Manager to generate a new token if the token's client registration has expired.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.675.0 (2023-11-01 18:20 UTC)
* APIGateway (3.7.201.40)
	* Marshaller changes from the generator changes supporting maps of lists.
* Connect (3.7.210.0)
	* Adds the BatchGetFlowAssociation API which returns flow associations (flow-resource) corresponding to the list of resourceArns supplied in the request. This release also adds IsDefault, LastModifiedRegion and LastModifiedTime fields to the responses of several Describe and List APIs.
* DataExchange (3.7.201.1)
	* Marshaller changes from the generator changes supporting maps of lists.
* GlobalAccelerator (3.7.202.0)
	* Global Accelerator now support accelerators with cross account endpoints.
* RDS (3.7.213.0)
	* This release adds support for customized networking resources to Amazon RDS Custom.
* Redshift (3.7.204.0)
	* Added support for Multi-AZ deployments for Provisioned RA3 clusters that provide 99.99% SLA availability.
* SageMaker (3.7.220.0)
	* Support for batch transform input in Model dashboard
* Core 3.7.204.11
	* Added generator support for maps of lists and associated protocol tests.

### 3.7.674.1 (2023-10-31 23:32 UTC)
* S3 (3.7.205.21)
	* Revert 'BREAKING CHANGE: Update CopyObject and CopyPart requests not to remove leading slash from object keys'

### 3.7.674.0 (2023-10-31 18:33 UTC)
* Amplify (3.7.201.0)
	* Add backend field to CreateBranch and UpdateBranch requests. Add pagination support for ListApps, ListDomainAssociations, ListBranches, and ListJobs
* ApplicationInsights (3.7.202.0)
	* Automate attaching managed policies
* EC2 (3.7.224.0)
	* Capacity Blocks for ML are a new EC2 purchasing option for reserving GPU instances on a future date to support short duration machine learning (ML) workloads. Capacity Blocks automatically place instances close together inside Amazon EC2 UltraClusters for low-latency, high-throughput networking.
* MainframeModernization (3.7.202.0)
	* Added name filter ability for ListDataSets API, added ForceUpdate for Updating environment and BatchJob submission using S3BatchJobIdentifier
* Neptunedata (3.7.202.0)
	* Minor change to not retry CancelledByUserException
* S3 (3.7.205.20)
	* BREAKING CHANGE: Update CopyObject and CopyPart requests not to remove leading slash from object keys
* Translate (3.7.201.0)
	* Added support for Brevity translation settings feature.

### 3.7.673.0 (2023-10-30 18:22 UTC)
* Connect (3.7.209.0)
	* This release adds InstanceId field for phone number APIs.
* ConnectWisdomService (3.7.202.7)
	* This release added necessary API documents on creating a Wisdom knowledge base to integrate with S3.
* DataExchange (3.7.201.0)
	* We added a new API action: SendDataSetNotification.
* DataSync (3.7.204.0)
	* Platform version changes to support AL1 deprecation initiative.
* Finspace (3.7.202.0)
	* Introducing new API UpdateKxClusterCodeConfiguration, introducing new cache types for clusters and introducing new deployment modes for updating clusters.
* MediaPackageV2 (3.7.202.0)
	* This feature allows customers to create a combination of manifest filtering, startover and time delay configuration that applies to all egress requests by default.
* RDS (3.7.212.0)
	* This release launches the CreateIntegration, DeleteIntegration, and DescribeIntegrations APIs to manage zero-ETL Integrations.
* RedshiftServerless (3.7.203.0)
	* Added support for custom domain names for Amazon Redshift Serverless workgroups. This feature enables customers to create a custom domain name and use ACM to generate fully secure connections to it.
* ResilienceHub (3.7.202.0)
	* Introduced the ability to filter applications by their last assessment date and time and have included metrics for the application's estimated workload Recovery Time Objective (RTO) and estimated workload Recovery Point Objective (RPO).
* S3Outposts (3.7.201.0)
	* Updated ListOutpostsWithS3 API response to include S3OutpostArn for use with AWS RAM.

### 3.7.672.0 (2023-10-27 18:14 UTC)
* ElasticMapReduce (3.7.201.0)
	* Updated CreateCluster API request and DescribeCluster API responses to include EbsRootVolumeIops, and EbsRootVolumeThroughput attributes that specify the user configured root volume IOPS and throughput for Amazon EBS root device volume. This feature will be available from Amazon EMR releases 6.15.0
* Neptune (3.7.201.0)
	* Update TdeCredentialPassword type to SensitiveString
* Pinpoint (3.7.201.58)
	* Updated documentation to describe the case insensitivity for EndpointIds.
* Redshift (3.7.203.0)
	* added support to create a dual stack cluster
* WAFV2 (3.7.203.18)
	* Updates the descriptions for the calls that manage web ACL associations, to provide information for customer-managed IAM policies.
* Core 3.7.204.10
	* Deprecate AWSSDKUtils.ResolveResourcePath and AWSSDKUtils.JoinResourcePathSegments in favor of V2 version to fix encoding issue with special characters. Add protocol tests for http labels for greedy and non-greedy labels that include special characters.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.671.0 (2023-10-26 18:26 UTC)
* AppStream (3.7.203.0)
	* This release introduces multi-session fleets, allowing customers to provision more than one user session on a single fleet instance.
* EC2 (3.7.223.0)
	* Launching GetSecurityGroupsForVpc API. This API gets security groups that can be associated by the AWS account making the request with network interfaces in the specified VPC.
* NetworkFirewall (3.7.202.0)
	* Network Firewall now supports inspection of outbound SSL/TLS traffic.
* OpenSearchService (3.7.203.0)
	* You can specify ipv4 or dualstack IPAddressType for cluster endpoints. If you specify IPAddressType as dualstack, the new endpoint will be visible under the 'EndpointV2' parameter and will support IPv4 and IPv6 requests. Whereas, the 'Endpoint' will continue to serve IPv4 requests.
* Redshift (3.7.202.0)
	* Add Redshift APIs GetResourcePolicy, DeleteResourcePolicy, PutResourcePolicy and DescribeInboundIntegrations for the new Amazon Redshift Zero-ETL integration feature, which can be used to control data ingress into Redshift namespace, and view inbound integrations.
* SageMaker (3.7.219.0)
	* Amazon Sagemaker Autopilot now supports Text Generation jobs.
* SimpleNotificationService (3.7.201.0)
	* Message Archiving and Replay is now supported in Amazon SNS for FIFO topics.
* SsmSap (3.7.202.0)
	* AWS Systems Manager for SAP added support for registration and discovery of SAP ABAP applications
* Transfer (3.7.203.0)
	* No API changes from previous release. This release migrated the model to Smithy keeping all features unchanged.
* Core 3.7.204.9
	* Update SDK generator to handle hostPrefix labels (https://smithy.io/2.0/spec/endpoint-traits.html#endpoint-trait)
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.670.0 (2023-10-25 20:16 UTC)
* ConnectCases (3.7.202.0)
	* Increase maximum length of CommentBody to 3000, and increase maximum length of StringValue to 1500
* GroundStation (3.7.201.0)
	* This release will allow KMS alias names to be used when creating Mission Profiles
* IdentityManagement (3.7.202.0)
	* Updates to GetAccessKeyLastUsed action to replace NoSuchEntity error with AccessDeniedException error.

### 3.7.669.0 (2023-10-24 18:19 UTC)
* CodePipeline (3.7.202.0)
	* Add ability to trigger pipelines from git tags, define variables at pipeline level and new pipeline type V2.
* EC2 (3.7.222.0)
	* This release updates the documentation for InstanceInterruptionBehavior and HibernationOptionsRequest to more accurately describe the behavior of these two parameters when using Spot hibernation.
* EKS (3.7.202.0)
	* Added support for Cluster Subnet and Security Group mutability.
* IdentityManagement (3.7.201.0)
	* Add the partitional endpoint for IAM in iso-f.
* MigrationHubConfig (3.7.201.0)
	* This release introduces DeleteHomeRegionControl API that customers can use to delete the Migration Hub Home Region configuration
* MigrationHubStrategyRecommendations (3.7.201.0)
	* This release introduces multi-data-source feature in Migration Hub Strategy Recommendations. This feature now supports vCenter as a data source to fetch inventory in addition to ADS and Import from file workflow that is currently supported with MHSR collector.
* OpenSearchServerless (3.7.202.0)
	* This release includes the following new APIs: CreateLifecyclePolicy, UpdateLifecyclePolicy, BatchGetLifecyclePolicy, DeleteLifecyclePolicy, ListLifecyclePolicies and BatchGetEffectiveLifecyclePolicy to support the data lifecycle management feature.
* Core 3.7.204.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.668.0 (2023-10-23 18:17 UTC)
* AWSMarketplaceCommerceAnalytics (3.7.201.0)
	* The StartSupportDataExport operation has been deprecated as part of the Product Support Connection deprecation. As of December 2022, Product Support Connection is no longer supported.
* NetworkManager (3.7.201.0)
	* This release adds API support for Tunnel-less Connect (NoEncap Protocol) for AWS Cloud WAN
* RedshiftServerless (3.7.202.0)
	* This release adds support for customers to see the patch version and workgroup version in Amazon Redshift Serverless.
* Rekognition (3.7.202.0)
	* Amazon Rekognition introduces StartMediaAnalysisJob, GetMediaAnalysisJob, and ListMediaAnalysisJobs operations to run a bulk analysis of images with a Detect Moderation model.
* Core 3.7.204.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.667.0 (2023-10-20 20:15 UTC)
* AppConfig (3.7.203.0)
	* Update KmsKeyIdentifier constraints to support AWS KMS multi-Region keys.
* AppIntegrationsService (3.7.202.0)
	* Updated ScheduleConfig to be an optional input to CreateDataIntegration to support event driven downloading of files from sources such as Amazon s3 using Amazon Connect AppIntegrations.
* ApplicationDiscoveryService (3.7.203.0)
	* This release introduces three new APIs: StartBatchDeleteConfigurationTask, DescribeBatchDeleteConfigurationTask, and BatchDeleteAgents.
* Connect (3.7.208.0)
	* This release adds support for updating phone number metadata, such as phone number description.
* MedicalImaging (3.7.200.58)
	* Updates on documentation links
* SimpleSystemsManagement (3.7.202.0)
	* This release introduces a new API: DeleteOpsItem. This allows deletion of an OpsItem.
* Core 3.7.204.6
	* Improve documentation for InstanceProfileAWSCredentials constructors
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.666.0 (2023-10-19 19:41 UTC)
* EC2 (3.7.221.0)
	* Amazon EC2 C7a instances, powered by 4th generation AMD EPYC processors, are ideal for high performance, compute-intensive workloads such as high performance computing. Amazon EC2 R7i instances are next-generation memory optimized and powered by custom 4th Generation Intel Xeon Scalable processors.
* GameSparks (Removed)
	* Amazon GameSparks has been removed from the SDK because the preview is not being continued.
* ManagedBlockchainQuery (3.7.202.0)
	* This release adds support for Ethereum Sepolia network
* Neptunedata (3.7.201.23)
	* Doc changes to add IAM action mappings for the data actions.
* Omics (3.7.206.0)
	* This change enables customers to retrieve failure reasons with detailed status messages for their failed runs
* OpenSearchService (3.7.202.0)
	* Added Cluster Administrative options for node restart, opensearch process restart and opensearch dashboard restart for Multi-AZ without standby domains
* QuickSight (3.7.207.0)
	* This release adds the following: 1) Trino and Starburst Database Connectors 2) Custom total for tables and pivot tables 3) Enable restricted folders 4) Add rolling dates for time equality filters 5) Refine DataPathValue and introduce DataPathType 6) Add SeriesType to ReferenceLineDataConfiguration
* SecretsManager (3.7.201.43)
	* Documentation updates for Secrets Manager
* ServiceCatalog (3.7.202.0)
	* Introduce support for EXTERNAL product and provisioning artifact type in CreateProduct and CreateProvisioningArtifact APIs.
* VerifiedPermissions (3.7.202.0)
	* Improving Amazon Verified Permissions Create experience
* WorkSpaces (3.7.202.6)
	* Documentation updates for WorkSpaces
* Core 3.7.204.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.665.0 (2023-10-18 18:18 UTC)
* Cloud9 (3.7.200.58)
	* Update to imageId parameter behavior and dates updated.
* ConnectWisdomService (3.7.202.0)
	* This release adds an max limit of 25 recommendation ids for NotifyRecommendationsReceived API.
* DynamoDBv2 (3.7.203.5)
	* Updating descriptions for several APIs.
* Kendra (3.7.202.0)
	* Changes for a new feature in Amazon Kendra's Query API to Collapse/Expand query results
* RDS (3.7.211.0)
	* This release adds support for upgrading the storage file system configuration on the DB instance using a blue/green deployment or a read replica.
* Core 3.7.204.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.664.0 (2023-10-17 18:25 UTC)
* ApplicationDiscoveryService (3.7.202.0)
	* This release introduces three new APIs: StartBatchDeleteConfigurationTask, DescribeBatchDeleteConfigurationTask, and BatchDeleteAgents.
* CodePipeline (3.7.201.0)
	* Add retryMode ALL_ACTIONS to RetryStageExecution API that retries a failed stage starting from first action in the stage
* ECS (3.7.201.26)
	* Documentation only updates to address Amazon ECS tickets.
* GlobalAccelerator (3.7.201.0)
	* Fixed error where ListCustomRoutingEndpointGroups did not have a paginator
* GuardDuty (3.7.204.0)
	* Add domainWithSuffix finding field to dnsRequestAction
* Kafka (3.7.202.0)
	* AWS Managed Streaming for Kafka is launching MSK Replicator, a new feature that enables customers to reliably replicate data across Amazon MSK clusters in same or different AWS regions. You can now use SDK to create, list, describe, delete, update, and manage tags of MSK Replicators.
* Route53RecoveryCluster (3.7.201.0)
	* Adds Owner field to ListRoutingControls API.
* Route53RecoveryControlConfig (3.7.201.0)
	* Adds permissions for GetResourcePolicy to support returning details about AWS Resource Access Manager resource policies for shared resources.
* Core 3.7.204.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.663.0 (2023-10-16 18:23 UTC)
* CloudFormation (3.7.204.0)
	* SDK and documentation updates for UpdateReplacePolicy
* Drs (3.7.203.0)
	* Updated exsiting API to allow AWS Elastic Disaster Recovery support of launching recovery into existing EC2 instances.
* EntityResolution (3.7.202.0)
	* This launch expands our matching techniques to include provider-based matching to help customer match, link, and enhance records with minimal data movement. With data service providers, we have removed the need for customers to build bespoke integrations,.
* ManagedBlockchainQuery (3.7.201.0)
	* This release introduces two new APIs: GetAssetContract and ListAssetContracts. This release also adds support for Bitcoin Testnet.
* MediaPackageV2 (3.7.201.0)
	* This release allows customers to manage MediaPackage v2 resource using CloudFormation.
* OpenSearchService (3.7.201.0)
	* This release allows customers to list and associate optional plugin packages with compatible Amazon OpenSearch Service clusters for enhanced functionality.
* Redshift (3.7.201.0)
	* Added support for managing credentials of provisioned cluster admin using AWS Secrets Manager.
* RedshiftServerless (3.7.201.0)
	* Added support for managing credentials of serverless namespace admin using AWS Secrets Manager.
* SimpleEmailV2 (3.7.202.0)
	* This release provides enhanced visibility into your SES identity verification status. This will offer you more actionable insights, enabling you to promptly address any verification-related issues.
* Transfer (3.7.202.3)
	* Documentation updates for AWS Transfer Family
* XRay (3.7.202.0)
	* This releases enhances GetTraceSummaries API to support new TimeRangeType Service to query trace summaries by segment end time.
* Core 3.7.204.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.662.0 (2023-10-12 18:36 UTC)
* AuditManager (3.7.202.0)
	* This release introduces a new limit to the awsAccounts parameter. When you create or update an assessment, there is now a limit of 200 AWS accounts that can be specified in the assessment scope.
* AutoScaling (3.7.203.0)
	* Update the NotificationMetadata field to only allow visible ascii characters. Add paginators to DescribeInstanceRefreshes, DescribeLoadBalancers, and DescribeLoadBalancerTargetGroups
* ConfigService (3.7.202.0)
	* Add enums for resource types supported by Config
* ControlTower (3.7.201.0)
	* Added new EnabledControl resource details to ListEnabledControls API and added new GetEnabledControl API.
* CustomerProfiles (3.7.203.0)
	* Adds sensitive trait to various shapes in Customer Profiles Calculated Attribute API model.
* EC2 (3.7.220.0)
	* This release adds Ubuntu Pro as a supported platform for On-Demand Capacity Reservations and adds support for setting an Amazon Machine Image (AMI) to disabled state. Disabling the AMI makes it private if it was previously shared, and prevents new EC2 instance launches from it.
* ElasticLoadBalancingV2 (3.7.201.39)
	* This release enables routing policies with Availability Zone affinity for Network Load Balancers.
* Glue (3.7.207.0)
	* Extending version control support to GitLab and Bitbucket from AWSGlue
* Inspector2 (3.7.202.0)
	* Add MacOs ec2 platform support
* IVSRealTime (3.7.202.0)
	* Update GetParticipant to return additional metadata.
* Lambda (3.7.202.0)
	* Adds support for Lambda functions to access Dual-Stack subnets over IPv6, via an opt-in flag in CreateFunction and UpdateFunctionConfiguration APIs
* LocationService (3.7.202.0)
	* This release adds endpoint updates for all AWS Location resource operations.
* MachineLearning (3.7.201.0)
	* This release marks Password field as sensitive
* Pricing (3.7.200.54)
	* Documentation updates for Price List
* RDS (3.7.210.0)
	* This release adds support for adding a dedicated log volume to open-source RDS instances.
* Rekognition (3.7.201.0)
	* Amazon Rekognition introduces support for Custom Moderation. This allows the enhancement of accuracy for detect moderation labels operations by creating custom adapters tuned on customer data.
* SageMaker (3.7.218.0)
	* Amazon SageMaker Canvas adds KendraSettings and DirectDeploySettings support for CanvasAppSettings
* Textract (3.7.202.0)
	* This release adds 9 new APIs for adapter and adapter version management, 3 new APIs for tagging, and updates AnalyzeDocument and StartDocumentAnalysis API parameters for using adapters.
* TranscribeService (3.7.202.0)
	* This release is to enable m4a format to customers
* WorkSpaces (3.7.202.2)
	* Updated the CreateWorkspaces action documentation to clarify that the PCoIP protocol is only available for Windows bundles.
* Core 3.7.204.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.661.0 (2023-10-07 04:59 UTC)
* Core 3.7.204.0
	* Add ContextAttributes property to IRequestContext to store request state in custom pipeline handlers.
	* Update SDK components for CI build system migration.
	* All services packages updated to require new Core

### 3.7.660.0 (2023-10-06 18:25 UTC)
* EC2 (3.7.219.0)
	* Documentation updates for Elastic Compute Cloud (EC2).
* FSx (3.7.202.0)
	* After performing steps to repair the Active Directory configuration of a file system, use this action to initiate the process of attempting to recover to the file system.
* MarketplaceCatalog (3.7.201.0)
	* This release adds support for Document type as an alternative for stringified JSON for StartChangeSet, DescribeChangeSet and DescribeEntity APIs
* QuickSight (3.7.206.0)
	* NullOption in FilterListConfiguration; Dataset schema/table max length increased; Support total placement for pivot table visual; Lenient mode relaxes the validation to create resources with definition; Data sources can be added to folders; Redshift data sources support IAM Role-based authentication
* Transfer (3.7.202.0)
	* This release updates the max character limit of PreAuthenticationLoginBanner and PostAuthenticationLoginBanner to 4096 characters

### 3.7.659.0 (2023-10-06 00:09 UTC)
* DynamoDBv2 (3.7.203.0)
	* Add TableBuilder and DisableFetchingTableMetadata, which can be used to provide table metadata for both the document and object mapper programming models. This can avoid throttling, improve cold-start latency, and avoid threadpool starvation.
* S3 (3.7.205.8)
	* Fixed documentation for EtagToNotMatch property in GetObjectRequest and GetObjectMetadataRequest classes; Fixed an issue where CompleteMultipartUploadRequest.AddPartETags() does not include checksums from CopyPartResponse.
* Core 3.7.203.0
	* Add SSO registration scopes from the shared config file to CredentialProfileOptions.

### 3.7.658.0 (2023-10-05 18:25 UTC)
* Omics (3.7.205.0)
	* Add Etag Support for Omics Storage in ListReadSets and GetReadSetMetadata API
* RDS (3.7.209.3)
	* Updates Amazon RDS documentation for corrections and minor improvements.
* Route53 (3.7.202.0)
	* Add hostedzonetype filter to ListHostedZones API.
* SecurityHub (3.7.203.0)
	* Added new resource detail objects to ASFF, including resources for AwsEventsEventbus, AwsEventsEndpoint, AwsDmsEndpoint, AwsDmsReplicationTask, AwsDmsReplicationInstance, AwsRoute53HostedZone, and AwsMskCluster
* StorageGateway (3.7.201.0)
	* Add SoftwareVersion to response of DescribeGatewayInformation.
* WorkSpaces (3.7.202.0)
	* This release introduces Manage applications. This feature allows users to manage their WorkSpaces applications by associating or disassociating their WorkSpaces with applications. The DescribeWorkspaces API will now additionally return OperatingSystemName in its responses.
* Core 3.7.202.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.657.0 (2023-10-04 18:27 UTC)
* AppConfig (3.7.202.0)
	* AWS AppConfig introduces KMS customer-managed key (CMK) encryption support for data saved to AppConfig's hosted configuration store.
* DataZone (3.7.200.0)
	* Initial release of Amazon DataZone
* MediaTailor (3.7.202.0)
	* Updates DescribeVodSource to include a list of ad break opportunities in the response
* Mgn (3.7.201.0)
	* This release includes the following new APIs: ListConnectors, CreateConnector,  UpdateConnector, DeleteConnector and UpdateSourceServer to support the source action framework feature.
* SageMaker (3.7.217.0)
	* Adding support for AdditionalS3DataSource, a data source used for training or inference that is in addition to the input dataset or model data.
* Core 3.7.202.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.656.0 (2023-10-03 18:28 UTC)
* Connect (3.7.207.0)
	* GetMetricDataV2 API: Update to include new metrics CONTACTS_RESOLVED_IN_X , AVG_HOLD_TIME_ALL_CONTACTS , AVG_RESOLUTION_TIME , ABANDONMENT_RATE , AGENT_NON_RESPONSE_WITHOUT_CUSTOMER_ABANDONS with added features: Interval Period, TimeZone, Negate MetricFilters, Extended date time range.
* LocationService (3.7.201.0)
	* Amazon Location Service adds support for bounding polygon queries. Additionally, the GeofenceCount field has been added to the DescribeGeofenceCollection API response.
* MediaConvert (3.7.204.0)
	* This release adds the ability to replace video frames without modifying the audio essence.
* OAM (3.7.201.0)
	* This release adds support for sharing AWS::ApplicationInsights::Application resources.
* SageMaker (3.7.216.0)
	* This release allows users to run Selective Execution in SageMaker Pipelines without SourcePipelineExecutionArn if selected steps do not have any dependent steps.
* WellArchitected (3.7.201.0)
	* AWS Well-Architected now supports Review Templates that allows you to create templates with pre-filled answers for Well-Architected and Custom Lens best practices.
* Core 3.7.202.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.655.0 (2023-10-02 18:29 UTC)
* Bedrock (3.7.201.0)
	* Provisioned throughput feature with Amazon and third-party base models, and update validators for model identifier and taggable resource ARNs.
* BedrockRuntime (3.7.201.0)
	* Add model timeout exception for InvokeModelWithResponseStream API and update validator for invoke model identifier.
* EC2 (3.7.218.0)
	* Introducing Amazon EC2 R7iz instances with 3.9 GHz sustained all-core turbo frequency and deliver up to 20% better performance than previous generation z1d instances.
* ManagedBlockchain (3.7.200.49)
	* Remove Rinkeby as option from Ethereum APIs
* RDS (3.7.209.0)
	* Adds DefaultCertificateForNewLaunches field in the DescribeCertificates API response.
* SecurityToken (3.7.202.0)
	* STS API updates for assumeRole
* SSO (3.7.201.0)
	* Fix FIPS Endpoints in aws-us-gov.
* Transfer (3.7.201.45)
	* Documentation updates for AWS Transfer Family
* Core 3.7.202.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.654.0 (2023-09-28 19:03 UTC)
* Bedrock (3.7.200.0)
	* Model Invocation logging added to enable or disable logs in customer account. Model listing and description support added. Provisioned Throughput feature added. Custom model support added for creating custom models. Also includes list, and delete functions for custom model.
* BedrockRuntime (3.7.200.0)
	* Run Inference: Added support to run the inference on models.  Includes set of APIs for running inference in streaming and non-streaming mode.
* Budgets (3.7.202.0)
	* Update DescribeBudgets and DescribeBudgetNotificationsForAccount MaxResults limit to 1000.
* EC2 (3.7.217.0)
	* Adds support for Customer Managed Key encryption for Amazon Verified Access resources
* IoTFleetWise (3.7.201.0)
	* AWS IoT FleetWise now supports encryption through a customer managed AWS KMS key. The PutEncryptionConfiguration and GetEncryptionConfiguration APIs were added.
* SageMaker (3.7.215.0)
	* Online store feature groups supports Standard and InMemory tier storage types for low latency storage for real-time data retrieval. The InMemory tier supports collection types List, Set, and Vector.
* SageMakerFeatureStoreRuntime (3.7.202.0)
	* Feature Store supports read/write of records with collection type features.
* WAFV2 (3.7.203.3)
	* Correct and improve the documentation for the FieldToMatch option JA3 fingerprint.
* Core 3.7.202.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.653.1 (2023-09-28 02:14 UTC)
* Core 3.7.202.16
	* Ensure MemoryStreams used as request payloads are at the beginning position before sending request.
Optimize memory allocations for HMAC signing.
Removed temporary strings when converting bytes to their ASCII hex representation.
Fix the typo with 'insufficient' across the repo.
Fixes for processing events from eventstream APIs.
	* All services packages updated to require new Core

### 3.7.653.0 (2023-09-27 18:25 UTC)
* CognitoIdentityProvider (3.7.203.0)
	* The UserPoolType Status field is no longer used.
* IoT (3.7.201.0)
	* Added support for IoT Rules Engine Kafka Action Headers
* KinesisFirehose (3.7.202.0)
	* Features : Adding support for new data ingestion source to Kinesis Firehose - AWS Managed Services Kafka.
* Textract (3.7.201.0)
	* This release adds new feature - Layout to Analyze Document API which can automatically extract layout elements such as titles, paragraphs, headers, section headers, lists, page numbers, footers, table areas, key-value areas and figure areas and order the elements as a human would read.
* Core 3.7.202.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.652.0 (2023-09-26 18:37 UTC)
* AppIntegrationsService (3.7.201.0)
	* The Amazon AppIntegrations service adds a set of APIs (in preview) to manage third party applications to be used in Amazon Connect agent workspace.
* AppRunner (3.7.203.0)
	* This release allows an App Runner customer to specify a custom source directory to run the build & start command. This change allows App Runner to support monorepo based repositories
* CodeDeploy (3.7.200.46)
	* CodeDeploy now supports In-place and Blue/Green EC2 deployments with multiple Classic Load Balancers and multiple Target Groups.
* Connect (3.7.206.0)
	* This release updates a set of Amazon Connect APIs that provides the ability to integrate third party applications in the Amazon Connect agent workspace.
* DynamoDBv2 (3.7.202.0)
	* Amazon DynamoDB now supports Incremental Export as an enhancement to the existing Export Table
* EC2 (3.7.216.0)
	* The release includes AWS verified access to support FIPs compliance in North America regions
* LakeFormation (3.7.201.0)
	* This release adds three new API support "CreateLakeFormationOptIn", "DeleteLakeFormationOptIn" and "ListLakeFormationOptIns", and also updates the corresponding documentation.
* Pinpoint (3.7.201.40)
	* Update documentation for RemoveAttributes to more accurately reflect its behavior when attributes are deleted.
* S3 (3.7.205.0)
	* This release adds a new field COMPLETED to the ReplicationStatus Enum. You can now use this field to validate the replication status of S3 objects using the AWS SDK.

### 3.7.651.0 (2023-09-25 18:28 UTC)
* AmplifyUIBuilder (3.7.202.0)
	* Support for generating code that is compatible with future versions of amplify project dependencies.
* ChimeSDKMediaPipelines (3.7.204.0)
	* Adds support for sending WebRTC audio to Amazon Kineses Video Streams.
* EMRServerless (3.7.202.0)
	* This release adds support for application-wide default job configurations.
* FinSpaceData (3.7.201.0)
	* Adding sensitive trait to attributes. Change max SessionDuration from 720 to 60. Correct "ApiAccess" attribute to "apiAccess" to maintain consistency between APIs.
* QuickSight (3.7.205.0)
	* Added ability to tag users upon creation.
* SimpleSystemsManagement (3.7.201.0)
	* This release updates the enum values for ResourceType in SSM DescribeInstanceInformation input and ConnectionStatus in GetConnectionStatus output.
* WAFV2 (3.7.203.0)
	* You can now perform an exact match against the web request's JA3 fingerprint.
* Core 3.7.202.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.650.0 (2023-09-22 18:32 UTC)
* Braket (3.7.201.0)
	* This release adds support to view the device queue depth (the number of queued quantum tasks and hybrid jobs on a device) and queue position for a quantum task and hybrid job.
* CloudWatchEvents (3.7.202.0)
	* Adds sensitive trait to various shapes in Jetstream Connections API model.
* DatabaseMigrationService (3.7.203.0)
	* new vendors for DMS CSF: MongoDB, MariaDB, DocumentDb and Redshift
* EC2 (3.7.215.0)
	* EC2 M2 Pro Mac instances are powered by Apple M2 Pro Mac Mini computers featuring 12 core CPU, 19 core GPU, 32 GiB of memory, and 16 core Apple Neural Engine and uniquely enabled by the AWS Nitro System through high-speed Thunderbolt connections.
* ElasticFileSystem (3.7.200.44)
	* Documentation updates for Elastic File System
* GuardDuty (3.7.203.0)
	* Add `EKS_CLUSTER_NAME` to filter and sort key.
* MediaConvert (3.7.203.0)
	* This release supports the creation of of audio-only tracks in CMAF output groups.
* Core 3.7.202.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.649.0 (2023-09-20 19:36 UTC)
* AppConfig (3.7.201.0)
	* Enabling boto3 paginators for list APIs and adding documentation around ServiceQuotaExceededException errors
* AppRunner (3.7.202.0)
	* This release adds improvements for managing App Runner auto scaling configuration resources. New APIs: UpdateDefaultAutoScalingConfiguration and ListServicesForAutoScalingConfiguration. Updated API: DeleteAutoScalingConfiguration.
* CloudWatchLogs (3.7.201.0)
	* Add ClientToken to QueryDefinition CFN Handler in CWL
* CodeArtifact (3.7.201.0)
	* Add support for the Swift package format.
* KinesisVideo (3.7.201.32)
	* Updated DescribeMediaStorageConfiguration, StartEdgeConfigurationUpdate, ImageGenerationConfiguration$SamplingInterval, and UpdateMediaStorageConfiguration to match AWS Docs.
* S3 (3.7.204.0)
	* Fix an issue where the SDK can fail to unmarshall response due to NumberFormatException
* ServiceDiscovery (3.7.201.0)
	* Adds a new DiscoverInstancesRevision API and also adds InstanceRevision field to the DiscoverInstances API response.
* SSOOIDC (3.7.201.0)
	* Update FIPS endpoints in aws-us-gov.
* Core 3.7.202.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.648.0 (2023-09-19 18:50 UTC)
* EC2 (3.7.214.0)
	* This release adds support for C7i, and R7a instance types.
* Outposts (3.7.201.0)
	* This release adds the InstanceFamilies field to the ListAssets response.
* SageMaker (3.7.214.0)
	* This release adds support for one-time model monitoring schedules that are executed immediately without delay, explicit data analysis windows for model monitoring schedules and exclude features attributes to remove features from model monitor analysis.
* Core 3.7.202.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.647.0 (2023-09-18 18:25 UTC)
* ApplicationDiscoveryService (3.7.201.0)
	* Add sensitive protection for customer information
* Macie2 (3.7.200.42)
	* This release changes the default managedDataIdentifierSelector setting for new classification jobs to RECOMMENDED. By default, new classification jobs now use the recommended set of managed data identifiers.
* WorkMail (3.7.201.0)
	* This release includes four new APIs UpdateUser, UpdateGroup, ListGroupsForEntity and DescribeEntity, along with RemoteUsers and some enhancements to existing APIs.

### 3.7.646.0 (2023-09-15 18:51 UTC)
* AppStream (3.7.202.0)
	* This release introduces app block builder, allowing customers to provision a resource to package applications into an app block
* Connect (3.7.205.0)
	* New rule type (OnMetricDataUpdate) has been added
* DataSync (3.7.203.13)
	* Documentation-only updates for AWS DataSync.
* SageMaker (3.7.213.0)
	* This release introduces Skip Model Validation for Model Packages
* Core 3.7.202.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.645.0 (2023-09-14 23:24 UTC)
* AppStream (3.7.201.0)
	* This release introduces multi-session fleets, allowing customers to provision more than one user session on a single fleet instance.
* CloudFormation (3.7.203.34)
	* Documentation updates for AWS CloudFormation
* EntityResolution (3.7.201.0)
	* Changed "ResolutionTechniques" and "MappedInputFields" in workflow and schema mapping operations to be required fields.
* LookoutEquipment (3.7.202.0)
	* This release adds APIs for the new scheduled retraining feature.
* Core 3.7.202.9
	* All services packages updated to require new Core

### 3.7.644.1 (2023-09-14 13:38 UTC)
* Core 3.7.202.8
	* Update CleanupDocumentation to replace tags that might contain additional attributes. Add public IsAddressesSet method for WAFv2 UpdateIPSetRequest to handle empty list.
	* All services packages updated to require new Core

### 3.7.644.0 (2023-09-13 18:26 UTC)
* Cloud9 (3.7.200.39)
	* Update to include information on Ubuntu 18 deprecation.
* Drs (3.7.202.0)
	* Updated existing APIs and added new ones to support using AWS Elastic Disaster Recovery post-launch actions. Added support for new regions.
* GuardDuty (3.7.202.0)
	* Add `managementType` field to ListCoverage API response.
* InternetMonitor (3.7.202.0)
	* This release updates the Amazon CloudWatch Internet Monitor API domain name.
* IVSRealTime (3.7.201.27)
	* Doc only update that changes description for ParticipantToken.
* KinesisFirehose (3.7.201.0)
	* DocumentIdOptions has been added for the Amazon OpenSearch destination.
* SimSpaceWeaver (3.7.201.3)
	* Edited the introductory text for the API reference.
* XRay (3.7.201.0)
	* Add StartTime field in GetTraceSummaries API response for each TraceSummary.
* Core 3.7.202.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.643.0 (2023-09-12 18:30 UTC)
* EC2 (3.7.213.0)
	* This release adds support for restricting public sharing of AMIs through AMI Block Public Access
* EventBridge (3.7.202.0)
	* Adds sensitive trait to various shapes in Jetstream Connections API model.
* Kendra (3.7.201.0)
	* Amazon Kendra now supports confidence score buckets for retrieved passage results using the Retrieve API.
* Core 3.7.202.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.642.0 (2023-09-11 18:23 UTC)
* ECR (3.7.201.0)
	* This release will have ValidationException be thrown from ECR LifecyclePolicy APIs in regions LifecyclePolicy is not supported, this includes existing Amazon Dedicated Cloud (ADC) regions. This release will also change Tag: TagValue and Tag: TagKey to required.
* MediaLive (3.7.204.0)
	* AWS Elemental Link now supports attaching a Link UHD device to a MediaConnect flow.
* QuickSight (3.7.204.0)
	* This release launches new updates to QuickSight KPI visuals - support for sparklines, new templated layout and new targets for conditional formatting rules.

### 3.7.641.0 (2023-09-08 18:22 UTC)
* FSx (3.7.201.23)
	* Amazon FSx documentation fixes
* SageMaker (3.7.212.0)
	* Autopilot APIs will now support holiday featurization for Timeseries models. The models will now hold holiday metadata and should be able to accommodate holiday effect during inference.
* SSOAdmin (3.7.201.0)
	* Content updates to IAM Identity Center API for China Regions.
* WorkSpaces (3.7.201.0)
	* A new field "ErrorDetails" will be added to the output of "DescribeWorkspaceImages" API call. This field provides in-depth details about the error occurred during image import process. These details include the possible causes of the errors and troubleshooting information.
* Core 3.7.202.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.640.0 (2023-09-07 21:57 UTC)
* Neptunedata (3.7.201.0)
	* Minor changes to send unsigned requests to Neptune clusters
* SecurityHub (3.7.202.14)
	* Documentation updates for AWS Security Hub
* SimSpaceWeaver (3.7.201.0)
	* BucketName and ObjectKey are now required for the S3Location data type. BucketName is now required for the S3Destination data type.
* Core 3.7.202.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.639.0 (2023-09-06 18:25 UTC)
* Appflow (3.7.202.0)
	* Adding OAuth2.0 support for servicenow connector.
* EC2 (3.7.212.0)
	* This release adds 'outpost' location type to the DescribeInstanceTypeOfferings API, allowing customers that have been allowlisted for outpost to query their offerings in the API.
* ElasticLoadBalancingV2 (3.7.201.19)
	* This release enables default UDP connection termination and disabling unhealthy target connection termination for Network Load Balancers.
* MediaLive (3.7.203.0)
	* Adds advanced Output Locking options for Epoch Locking: Custom Epoch and Jam Sync Time
* WAFV2 (3.7.202.0)
	* The targeted protection level of the Bot Control managed rule group now provides optional, machine-learning analysis of traffic statistics to detect some bot-related activity. You can enable or disable the machine learning functionality through the API.
* Core 3.7.202.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.638.0 (2023-09-05 18:28 UTC)
* BillingConductor (3.7.202.0)
	* This release adds support for line item filtering in for the custom line item resource.
* Cloud9 (3.7.200.34)
	* Added support for Ubuntu 22.04 that was not picked up in a previous Trebuchet request. Doc-only update.
* ComputeOptimizer (3.7.202.0)
	* This release adds support to provide recommendations for G4dn and P3 instances that use NVIDIA GPUs.
* EC2 (3.7.211.0)
	* Introducing Amazon EC2 C7gd, M7gd, and R7gd Instances with up to 3.8 TB of local NVMe-based SSD block-level storage. These instances are powered by AWS Graviton3 processors, delivering up to 25% better performance over Graviton2-based instances.
* ECS (3.7.201.3)
	* Documentation only update for Amazon ECS.
* EventBridge (3.7.201.0)
	* Improve Endpoint Ruleset test coverage.
* RDS (3.7.208.0)
	* Add support for feature integration with AWS Backup.
* SageMaker (3.7.211.0)
	* SageMaker Neo now supports data input shape derivation for Pytorch 2.0  and XGBoost compilation job for cloud instance targets. You can skip DataInputConfig field during compilation job creation. You can also access derived information from model in DescribeCompilationJob response.
* VPCLattice (3.7.201.0)
	* This release adds Lambda event structure version config support for LAMBDA target groups. It also adds newline support for auth policies.
* Core 3.7.202.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.637.0 (2023-09-01 18:23 UTC)
* ChimeSDKMediaPipelines (3.7.203.0)
	* This release adds support for the Voice Analytics feature for customer-owned KVS streams as part of the Amazon Chime SDK call analytics.
* Connect (3.7.204.0)
	* Amazon Connect adds the ability to read, create, update, delete, and list view resources, and adds the ability to read, create, delete, and list view versions.
* IdentityStore (3.7.201.0)
	* New Identity Store content for China Region launch
* Neptunedata (3.7.200.4)
	* Removed the descriptive text in the introduction.
* Core 3.7.202.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.636.0 (2023-09-01 01:49 UTC)
* S3 (3.7.203.6)
	* Updated to use new Core, version 3.7.202.0
	* Refactor checksum handling for potential interaction with the new RequestCompression trait.
* S3Control (3.7.201.6)
	* Updated to use new Core, version 3.7.202.0
	* Refactor checksum handling for potential interaction with the new RequestCompression trait.
* Core 3.7.202.0
	* Add support for the RequestCompression trait, which allows services to model that they support receiving compressed requests.
	* All services packages updated to require new Core

### 3.7.635.0 (2023-08-31 19:18 UTC)
* AWSHealth (3.7.201.0)
	* Adds new API DescribeEntityAggregatesForOrganization that retrieves entity aggregates across your organization. Also adds support for resource status filtering in DescribeAffectedEntitiesForOrganization, resource status aggregates in the DescribeEntityAggregates response, and new resource statuses.
* ChimeSDKMediaPipelines (3.7.202.0)
	* This release adds support for feature Voice Enhancement for Call Recording as part of Amazon Chime SDK call analytics.
* CloudHSM (3.7.201.0)
	* Deprecating CloudHSM Classic API Service.
* CloudWatchEvents (3.7.201.0)
	* Documentation updates for CloudWatch Events.
* ConnectCampaignService (3.7.201.0)
	* Amazon Connect outbound campaigns has launched agentless dialing mode which enables customers to make automated outbound calls without agent engagement. This release updates three of the campaign management API's to support the new agentless dialing mode and the new dialing capacity field.
* ConnectParticipant (3.7.201.0)
	* Amazon Connect Participant Service adds the ability to get a view resource using a view token, which is provided in a participant message, with the release of the DescribeView API.
* CustomerProfiles (3.7.202.0)
	* Adds sensitive trait to various shapes in Customer Profiles API model.
* ECS (3.7.201.0)
	* This release adds support for an account-level setting that you can use to configure the number of days for AWS Fargate task retirement.
* IVS (3.7.201.0)
	* Updated "type" description for CreateChannel, UpdateChannel, Channel, and ChannelSummary.
* KafkaConnect (3.7.201.0)
	* Minor model changes for Kafka Connect as well as endpoint updates.
* ManagedGrafana (3.7.202.0)
	* Marking SAML RoleValues attribute as sensitive and updating VpcConfiguration attributes to match documentation.
* PaymentCryptographyData (3.7.201.0)
	* Make KeyCheckValue field optional when using asymmetric keys as Key Check Values typically only apply to symmetric keys
* SageMakerRuntime (3.7.201.0)
	* This release adds a new InvokeEndpointWithResponseStream API to support streaming of model responses.
* Core 3.7.201.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.634.0 (2023-08-31 00:54 UTC)
* DynamoDBv2 (3.7.201.0)
	* Add the MetadataCachingMode option to the document and object-mapper DynamoDB APIs. This can be used to reduce the amount of internal DescribeTable calls the SDK makes to fill its cache in some contexts. 
Fix malformed documentation for DynamoDB's CreateBatchWrite.
* GlobalAccelerator (3.7.200.29)
	* Add service customization to generate IsSet property for Global Accelerator (EndpointConfigurations and PortOverrides)
* S3 (3.7.203.4)
	* Fixed a bug where TransferUtility upload request SSE-C customer algorithm was not being set for CompleteMultipartUpload.
* Core 3.7.201.9
	* Add thread safety to FallbackCredentialsFactory
	* All services packages updated to require new Core

### 3.7.633.0 (2023-08-30 18:40 UTC)
* Appflow (3.7.201.0)
	* Add SAP source connector parallel and pagination feature
* AppRunner (3.7.201.0)
	* App Runner adds support for Bitbucket. You can now create App Runner connection that connects to your Bitbucket repositories and deploy App Runner service with the source code stored in a Bitbucket repository.
* AuditManager (3.7.201.0)
	* This release marks some assessment metadata as sensitive. We added a sensitive trait to the following attributes: assessmentName, emailAddress, scope, createdBy, lastUpdatedBy, and userName.
* CleanRooms (3.7.202.0)
	* This release decouples member abilities in a collaboration. With this change, the member who can run queries no longer needs to be the same as the member who can receive results.
* DataSync (3.7.203.0)
	* AWS DataSync introduces Task Reports, a new feature that provides detailed reports of data transfer operations for each task execution.
* Neptunedata (3.7.200.0)
	* Allows customers to execute data plane actions like bulk loading graphs, issuing graph queries using Gremlin and openCypher directly from the SDK.
* NetworkFirewall (3.7.201.0)
	* Network Firewall increasing pagination token string length
* PcaConnectorAd (3.7.200.0)
	* The Connector for AD allows you to use a fully-managed AWS Private CA as a drop-in replacement for your self-managed enterprise CAs without local agents or proxy servers. Enterprises that use AD to manage Windows environments can reduce their private certificate authority (CA) costs and complexity.
* SageMaker (3.7.210.0)
	* Amazon SageMaker Canvas adds IdentityProviderOAuthSettings support for CanvasAppSettings
* Core 3.7.201.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.632.0 (2023-08-29 18:23 UTC)
* CognitoIdentityProvider (3.7.202.0)
	* Added API example requests and responses for several operations. Fixed the validation regex for user pools Identity Provider name.
* FSx (3.7.201.14)
	* Documentation updates for project quotas.
* Omics (3.7.204.0)
	* Add RetentionMode support for Runs.
* SimpleEmailV2 (3.7.201.0)
	* Adds support for the new Export and Message Insights features: create, get, list and cancel export jobs; get message insights.

### 3.7.631.0 (2023-08-28 18:34 UTC)
* Backup (3.7.202.0)
	* Add support for customizing time zone for backup window in backup plan rules.
* ComputeOptimizer (3.7.201.0)
	* This release enables AWS Compute Optimizer to analyze and generate licensing optimization recommendations for sql server running on EC2 instances.
* Organizations (3.7.200.27)
	* Documentation updates for permissions and links.
* SecurityLake (3.7.202.0)
	* Remove incorrect regex enforcement on pagination tokens.
* ServiceQuotas (3.7.201.0)
	* Service Quotas now supports viewing the applied quota value and requesting a quota increase for a specific resource in an AWS account.
* WorkSpacesWeb (3.7.201.0)
	* WorkSpaces Web now enables Admins to configure which cookies are synchronized from an end-user's local browser to the in-session browser. In conjunction with a browser extension, this feature enables enhanced Single-Sign On capability by reducing the number of times an end-user has to authenticate.
* Core 3.7.201.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.630.0 (2023-08-25 18:24 UTC)
* CloudTrail (3.7.201.0)
	* Add ThrottlingException with error code 429 to handle CloudTrail Delegated Admin request rate exceeded on organization resources.
* CloudWatch (3.7.200.27)
	* Doc-only update to get doc bug fixes into the SDK docs
* Detective (3.7.202.0)
	* Added protections to interacting with fields containing customer information.
* Core 3.7.201.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.629.0 (2023-08-24 18:29 UTC)
* EC2 (3.7.210.0)
	* Amazon EC2 M7a instances, powered by 4th generation AMD EPYC processors, deliver up to 50% higher performance compared to M6a instances. Amazon EC2 Hpc7a instances, powered by 4th Gen AMD EPYC processors, deliver up to 2.5x better performance compared to Amazon EC2 Hpc6a instances.
* Glue (3.7.206.0)
	* Added API attributes that help in the monitoring of sessions.
* MediaConvert (3.7.202.0)
	* This release includes additional audio channel tags in Quicktime outputs, support for film grain synthesis for AV1 outputs, ability to create audio-only FLAC outputs, and ability to specify Amazon S3 destination storage class.
* MediaLive (3.7.202.0)
	* MediaLive now supports passthrough of KLV data to a HLS output group with a TS container. MediaLive now supports setting an attenuation mode for AC3 audio when the coding mode is 3/2 LFE. MediaLive now supports specifying whether to include filler NAL units in RTMP output group settings.
* MediaTailor (3.7.201.0)
	* Adds new source location AUTODETECT_SIGV4 access type.
* QuickSight (3.7.203.0)
	* Excel support in Snapshot Export APIs. Removed Required trait for some insight Computations. Namespace-shared Folders support. Global Filters support. Table pin Column support.
* RDS (3.7.207.0)
	* This release updates the supported versions for Percona XtraBackup in Aurora MySQL.
* S3 (3.7.203.0)
	* Updates to endpoint ruleset tests to address Smithy validation issues.
* S3Control (3.7.201.0)
	* Updates to endpoint ruleset tests to address Smithy validation issues and standardize the capitalization of DualStack.
* VerifiedPermissions (3.7.201.2)
	* Documentation updates for Amazon Verified Permissions.
* Core 3.7.201.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.628.0 (2023-08-23 18:50 UTC)
* APIGateway (3.7.201.0)
	* This release adds RootResourceId to GetRestApi response.
* EC2 (3.7.209.0)
	* Marking fields as sensitive on BundleTask and GetPasswordData
* Polly (3.7.203.0)
	* Amazon Polly adds 1 new voice - Zayd (ar-AE)
* Core 3.7.201.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.627.0 (2023-08-22 19:56 UTC)
* CostExplorer (3.7.202.0)
	* This release adds the LastUpdatedDate and LastUsedDate timestamps to help you manage your cost allocation tags.
* GlobalAccelerator (3.7.200.23)
	* Global Accelerator now supports Client Ip Preservation for Network Load Balancer endpoints.
* RDS (3.7.206.0)
	* Adding parameters to CreateCustomDbEngineVersion reserved for future use.
* VerifiedPermissions (3.7.201.0)
	* Documentation updates for Amazon Verified Permissions. Increases max results per page for ListPolicyStores, ListPolicies, and ListPolicyTemplates APIs from 20 to 50.
* Core 3.7.201.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.626.0 (2023-08-21 18:22 UTC)
* Cloud9 (3.7.200.23)
	* Doc only update to add Ubuntu 22.04 as an Image ID option for Cloud9
* EC2 (3.7.208.0)
	* The DeleteKeyPair API has been updated to return the keyPairId when an existing key pair is deleted.
* Finspace (3.7.201.0)
	* Allow customers to manage outbound traffic from their Kx Environment when attaching a transit gateway by providing network acl entries. Allow the customer to choose how they want to update the databases on a cluster allowing updates to possibly be faster than usual.
* RDS (3.7.205.0)
	* Adding support for RDS Aurora Global Database Unplanned Failover
* Route53Domains (3.7.201.4)
	* Fixed typos in description fields
* Core 3.7.201.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.625.0 (2023-08-18 18:25 UTC)
* CodeCommit (3.7.201.0)
	* Add new ListFileCommitHistory operation to retrieve commits which introduced changes to a specific file.
* SecurityHub (3.7.202.0)
	* Added Inspector Lambda code Vulnerability section to ASFF, including GeneratorDetails, EpssScore, ExploitAvailable, and CodeVulnerabilities.
* Core 3.7.201.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.624.0 (2023-08-18 13:44 UTC)
* S3 (3.7.202.0)
	* This is a new feature for Transfer Utility, where UploadAsync and Upload now supports uploading unseekable streams or unknown length streams. Note: TransferUtility will buffer the stream in memory, refer to the docs for details. Update S3ErrorResponseUnmarshaller to allow character sets
* Core 3.7.201.0
	* Add DetermineServiceOperationEndpoint method to the serviceClients. All credential providers PreemptExpiry time has been increased to 15 minutes to align with the 15 minute expiration of presignedUrls to guarantee valid credentials during the lifetime of a presigned URL. Fixed an issue where generated PresignedUrl didn't contain URL encoded querystring parameter name/values.
	* All services packages updated to require new Core

### 3.7.623.0 (2023-08-17 18:29 UTC)
* EC2 (3.7.207.0)
	* Adds support for SubnetConfigurations to allow users to select their own IPv4 and IPv6 addresses for Interface VPC endpoints
* GameLift (3.7.201.0)
	* Amazon GameLift updates its instance types support.
* Core 3.7.200.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.622.0 (2023-08-16 18:33 UTC)
* CloudWatch (3.7.200.19)
	* Doc-only update to incorporate several doc bug fixes
* LexModelsV2 (3.7.203.0)
	* This release updates the Custom Vocabulary Weight field to support a value of 0.

### 3.7.621.0 (2023-08-15 18:26 UTC)
* ChimeSDKMeetings (3.7.201.0)
	* Updated API documentation to include additional exceptions.
* EC2 (3.7.206.0)
	* Documentation updates for Elastic Compute Cloud (EC2).
* Glue (3.7.205.0)
	* AWS Glue Crawlers can now accept SerDe overrides from a custom csv classifier. The two SerDe options are LazySimpleSerDe and OpenCSVSerDe. In case, the user wants crawler to do the selection, "None" can be selected for this purpose.
* PI (3.7.201.0)
	* AWS Performance Insights for Amazon RDS is launching Performance Analysis On Demand, a new feature that allows you to analyze database performance metrics and find out the performance issues. You can now use SDK to create, list, get, delete, and manage tags of performance analysis reports.
* Route53Domains (3.7.201.0)
	* Provide explanation if CheckDomainTransferability return false. Provide requestId if a request is already submitted.  Add sensitive protection for customer information
* SageMaker (3.7.209.0)
	* SageMaker Inference Recommender now provides SupportedResponseMIMETypes from DescribeInferenceRecommendationsJob response
* Core 3.7.200.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.620.0 (2023-08-14 18:25 UTC)
* MediaPackage (3.7.201.0)
	* Fix SDK logging of certain fields.
* Omics (3.7.203.0)
	* This release provides support for annotation store versioning and cross account sharing for Omics Analytics
* Transfer (3.7.201.13)
	* Documentation updates for AWS Transfer Family
* Core 3.7.200.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.619.0 (2023-08-11 18:26 UTC)
* AmplifyBackend (3.7.201.0)
	* Adds sensitive trait to required input shapes.
* ConfigService (3.7.201.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in July 2023.
* EC2 (3.7.205.0)
	* Amazon EC2 P5 instances, powered by the latest NVIDIA H100 Tensor Core GPUs, deliver the highest performance in EC2 for deep learning (DL) and HPC applications. M7i-flex and M7i instances are next-generation general purpose instances powered by custom 4th Generation Intel Xeon Scalable processors.
* QuickSight (3.7.202.0)
	* New Authentication method for Account subscription - IAM Identity Center. Hierarchy layout support, default column width support and related style properties for pivot table visuals. Non-additive topic field aggregations for Topic API
* SimpleEmail (3.7.200.16)
	* Doc only updates to include: 1) Clarified which part of an email address where it's okay to have Punycode when it contains non-ASCII characters for the SendRawEmail action and other actions where this is applicable. 2) Updated S3Action description with new MB max bucket size from 30 to 40.
* SimpleWorkflow (3.7.201.0)
	* This release adds new API parameters to override workflow task list for workflow executions.
* Core 3.7.200.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.618.0 (2023-08-10 18:33 UTC)
* CloudTrail (3.7.200.15)
	* Documentation updates for CloudTrail.
* Connect (3.7.203.0)
	* This release adds APIs to provision agents that are global / available in multiple AWS regions and distribute them across these regions by percentage.
* ElasticLoadBalancingV2 (3.7.201.0)
	* This release enables configuring security groups for Network Load Balancers
* Omics (3.7.202.0)
	* This release adds instanceType to GetRunTask & ListRunTasks responses.
* SecretsManager (3.7.201.0)
	* Add additional InvalidRequestException to list of possible exceptions for ListSecret.
* Transfer (3.7.201.11)
	* Documentation updates for AW Transfer Family
* Core 3.7.200.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.617.0 (2023-08-09 18:26 UTC)
* ChimeSDKVoice (3.7.201.0)
	* Updating CreatePhoneNumberOrder, UpdatePhoneNumber and BatchUpdatePhoneNumbers APIs, adding phone number name
* FSx (3.7.201.0)
	* For FSx for Lustre, add new data repository task type, RELEASE_DATA_FROM_FILESYSTEM, to release files that have been archived to S3. For FSx for Windows, enable support for configuring and updating SSD IOPS, and for updating storage type. For FSx for OpenZFS, add new deployment type, MULTI_AZ_1.
* GlobalAccelerator (3.7.200.14)
	* Documentation update for dualstack EC2 endpoint support
* GuardDuty (3.7.201.0)
	* Added autoEnable ALL to UpdateOrganizationConfiguration and DescribeOrganizationConfiguration APIs.
* SageMaker (3.7.208.0)
	* This release adds support for cross account access for SageMaker Model Cards through AWS RAM.
* Core 3.7.200.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.616.0 (2023-08-08 18:27 UTC)
* Backup (3.7.201.0)
	* This release introduces a new logically air-gapped vault (Preview) in AWS Backup that stores immutable backup copies, which are locked by default and isolated with encryption using AWS owned keys. Logically air-gapped vault (Preview) allows secure recovery of application data across accounts.
* ElastiCache (3.7.201.0)
	* Added support for cluster mode in online migration and test migration API
* ServiceCatalog (3.7.201.0)
	* Introduce support for HashiCorp Terraform Cloud in Service Catalog by addying TERRAFORM_CLOUD product type in CreateProduct and CreateProvisioningArtifact API.
* Core 3.7.200.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.615.1 (2023-08-08 14:12 UTC)
* Core 3.7.200.12
	* The update involves adding EndpointAttributes to the internal request, updating all service's csproj to sign assemblies locally and increasing credentials lock timeout for Default Instance Profile Credentials.
	* All services packages updated to require new Core

### 3.7.615.0 (2023-08-07 18:34 UTC)
* Detective (3.7.201.0)
	* Updated the email validation regex to be in line with the TLD name specifications.
* IVSRealTime (3.7.201.0)
	* Add QUOTA_EXCEEDED and PUBLISHER_NOT_FOUND to EventErrorCode for stage health events.
* KinesisVideo (3.7.201.0)
	* This release enables minimum of Images SamplingInterval to be as low as 200 milliseconds in Kinesis Video Stream Image feature.
* KinesisVideoArchivedMedia (3.7.201.0)
	* This release enables minimum of Images SamplingInterval to be as low as 200 milliseconds in Kinesis Video Stream Image feature.
* Rekognition (3.7.200.11)
	* This release adds code snippets for Amazon Rekognition Custom Labels.
* Core 3.7.200.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.614.0 (2023-08-04 18:34 UTC)
* ACMPCA (3.7.200.10)
	* Documentation correction for AWS Private CA
* Connect (3.7.202.0)
	* Added a new API UpdateRoutingProfileAgentAvailabilityTimer to update agent availability timer of a routing profile.
* DataSync (3.7.202.0)
	* Display cloud storage used capacity at a cluster level.
* ECS (3.7.200.10)
	* This is a documentation update to address various tickets.
* SageMaker (3.7.207.0)
	* Including DataCaptureConfig key in the Amazon Sagemaker Search's transform job object
* Core 3.7.200.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.613.0 (2023-08-03 18:26 UTC)
* AutoScaling (3.7.202.3)
	* Documentation changes related to Amazon EC2 Auto Scaling APIs.
* Cloud9 (3.7.200.10)
	* Updated the deprecation date for Amazon Linux. Doc only update.
* DatabaseMigrationService (3.7.202.0)
	* The release makes public API for DMS Schema Conversion feature.
* EC2 (3.7.204.0)
	* This release adds new parameter isPrimaryIPv6 to  allow assigning an IPv6 address as a primary IPv6 address to a network interface which cannot be changed to give equivalent functionality available for network interfaces with primary IPv4 address.
* SageMaker (3.7.206.0)
	* Amazon SageMaker now supports running training jobs on p5.48xlarge instance types.

### 3.7.612.0 (2023-08-02 18:23 UTC)
* Budgets (3.7.201.0)
	* As part of CAE tagging integration we need to update our budget names regex filter to prevent customers from using "/action/" in their budget names.
* CognitoIdentityProvider (3.7.201.0)
	* New feature that logs Cognito user pool error messages to CloudWatch logs.
* Glue (3.7.204.0)
	* This release includes additional Glue Streaming KAKFA SASL property types.
* ResilienceHub (3.7.201.0)
	* Drift Detection capability added when applications policy has moved from a meet to breach state. Customers will be able to exclude operational recommendations and receive credit in their resilience score. Customers can now add ARH permissions to an existing or new role.
* SageMaker (3.7.205.0)
	* SageMaker Inference Recommender introduces a new API GetScalingConfigurationRecommendation to recommend auto scaling policies based on completed Inference Recommender jobs.
* Core 3.7.200.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.611.0 (2023-08-01 18:27 UTC)
* Batch (3.7.201.0)
	* This release adds support for price capacity optimized allocation strategy for Spot Instances.
* DatabaseMigrationService (3.7.201.0)
	* Adding new API describe-engine-versions which provides information about the lifecycle of a replication instance's version.
* InternetMonitor (3.7.201.0)
	* This release adds a new feature for Amazon CloudWatch Internet Monitor that enables customers to set custom thresholds, for performance and availability drops, for impact limited to a single city-network to trigger creation of a health event.
* MediaLive (3.7.201.0)
	* AWS Elemental Link devices now report their Availability Zone. Link devices now support the ability to change their Availability Zone.
* Polly (3.7.202.0)
	* Amazon Polly adds new French Belgian voice - Isabelle. Isabelle is available as Neural voice only.
* RDS (3.7.204.0)
	* Added support for deleted clusters PiTR.
* SageMaker (3.7.204.0)
	* Add Stairs TrafficPattern and FlatInvocations to RecommendationJobStoppingConditions
* Core 3.7.200.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.610.0 (2023-07-31 18:31 UTC)
* AmplifyUIBuilder (3.7.201.0)
	* Amplify Studio releases GraphQL support for codegen job action.
* AutoScaling (3.7.202.0)
	* You can now configure an instance refresh to set its status to 'failed' when it detects that a specified CloudWatch alarm has gone into the ALARM state. You can also choose to roll back the instance refresh automatically when the alarm threshold is met.
* CleanRooms (3.7.201.0)
	* This release introduces custom SQL queries - an expanded set of SQL you can run. This release adds analysis templates, a new resource for storing pre-defined custom SQL queries ahead of time. This release also adds the Custom analysis rule, which lets you approve analysis templates for querying.
* CodeStarconnections (3.7.201.0)
	* New integration with the Gitlab provider type.
* Drs (3.7.201.0)
	* Add support for in-aws right sizing
* Inspector2 (3.7.201.0)
	* This release adds 1 new API: BatchGetFindingDetails to retrieve enhanced vulnerability intelligence details for findings.
* LookoutEquipment (3.7.201.0)
	* This release includes new import resource, model versioning and resource policy features.
* Omics (3.7.201.0)
	* Add CreationType filter for ListReadSets
* RDS (3.7.203.0)
	* This release adds support for Aurora MySQL local write forwarding, which allows for forwarding of write operations from reader DB instances to the writer DB instance.
* Route53 (3.7.201.0)
	* Amazon Route 53 now supports the Israel (Tel Aviv) Region (il-central-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Scheduler (3.7.201.0)
	* This release introduces automatic deletion of schedules in EventBridge Scheduler. If configured, EventBridge Scheduler automatically deletes a schedule after the schedule has completed its last invocation.
* Core 3.7.200.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.609.0 (2023-07-28 18:28 UTC)
* ApplicationInsights (3.7.201.0)
	* This release enable customer to add/remove/update more than one workload for a component
* CloudFormation (3.7.203.0)
	* This SDK release is for the feature launch of AWS CloudFormation RetainExceptOnCreate. It adds a new parameter retainExceptOnCreate in the following APIs: CreateStack, UpdateStack, RollbackStack, ExecuteChangeSet.
* CloudFront (3.7.201.0)
	* Add a new JavaScript runtime version for CloudFront Functions.
* Connect (3.7.201.0)
	* This release adds support for new number types.
* Kafka (3.7.201.0)
	* Amazon MSK has introduced new versions of ListClusterOperations and DescribeClusterOperation APIs. These v2 APIs provide information and insights into the ongoing operations of both MSK Provisioned and MSK Serverless clusters.
* Pinpoint (3.7.201.0)
	* Added support for sending push notifications using the FCM v1 API with json credentials. Amazon Pinpoint customers can now deliver messages to Android devices using both FCM v1 API and the legacy FCM/GCM API
* Core 3.7.200.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.608.1 (2023-07-28 00:33 UTC)
* SQS (3.7.200.6)
	* Documentation changes related to SQS APIs.

### 3.7.608.0 (2023-07-27 18:26 UTC)
* AutoScaling (3.7.201.0)
	* This release updates validation for instance types used in the AllowedInstanceTypes and ExcludedInstanceTypes parameters of the InstanceRequirements property of a MixedInstancesPolicy.
* EBS (3.7.201.0)
	* SDK and documentation updates for Amazon Elastic Block Store API
* EC2 (3.7.203.0)
	* SDK and documentation updates for Amazon Elastic Block Store APIs
* EKS (3.7.201.0)
	* Add multiple customer error code to handle customer caused failure when managing EKS node groups
* SageMaker (3.7.203.0)
	* Expose ProfilerConfig attribute in SageMaker Search API response.

### 3.7.607.0 (2023-07-26 18:45 UTC)
* CloudControlApi (3.7.200.5)
	* Updates the documentation for CreateResource.
* EntityResolution (3.7.200.0)
	* AWS Entity Resolution can effectively match a source record from a customer relationship management (CRM) system with a source record from a marketing system containing campaign information.
* Glue (3.7.203.0)
	* Release Glue Studio Snowflake Connector Node for SDK/CLI
* HealthLake (3.7.200.5)
	* Updating the HealthLake service documentation.
* ManagedBlockchainQuery (3.7.200.0)
	* Amazon Managed Blockchain (AMB) Query provides serverless access to standardized, multi-blockchain datasets with developer-friendly APIs.
* MediaConvert (3.7.201.2)
	* This release includes general updates to user documentation.
* Omics (3.7.200.5)
	* The service is renaming as a part of AWS Health.
* OpenSearchServerless (3.7.201.0)
	* This release adds new collection type VectorSearch.
* Polly (3.7.201.0)
	* Amazon Polly adds 1 new voice - Lisa (nl-BE)
* Route53 (3.7.200.5)
	* Update that corrects the documents for received feedback.
* Core 3.7.200.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.606.0 (2023-07-25 19:02 UTC)
* BillingConductor (3.7.201.0)
	* Added support for Auto-Assocate Billing Groups for CreateBillingGroup, UpdateBillingGroup, and ListBillingGroups.
* ConnectWisdomService (3.7.201.0)
	* This release added two new data types: AssistantIntegrationConfiguration, and SessionIntegrationConfiguration to support Wisdom integration with Amazon Connect Chat
* CustomerProfiles (3.7.201.0)
	* Amazon Connect Customer Profiles now supports rule-based resolution to match and merge similar profiles into unified profiles, helping companies deliver faster and more personalized customer service by providing access to relevant customer information for agents and automated experiences.
* DataSync (3.7.201.0)
	* AWS DataSync now supports Microsoft Azure Blob Storage locations.
* DynamoDBv2 (3.7.200.5)
	* Documentation updates for DynamoDB
* EC2 (3.7.202.0)
	* This release adds an instance's peak and baseline network bandwidth as well as the memory sizes of an instance's inference accelerators to DescribeInstanceTypes.
* EMRServerless (3.7.201.0)
	* This release adds support for publishing application logs to CloudWatch.
* Lambda (3.7.201.0)
	* Add Python 3.11 (python3.11) support to AWS Lambda
* RDS (3.7.202.0)
	* This release adds support for monitoring storage optimization progress on the DescribeDBInstances API.
* SageMaker (3.7.202.0)
	* Mark ContentColumn and TargetLabelColumn as required Targets in TextClassificationJobConfig in CreateAutoMLJobV2API
* SecurityHub (3.7.201.0)
	* Add support for CONTAINS and NOT_CONTAINS comparison operators for Automation Rules string filters and map filters
* SecurityToken (3.7.201.0)
	* API updates for the AWS Security Token Service
* Transfer (3.7.201.0)
	* This release adds support for SFTP Connectors.

### 3.7.605.0 (2023-07-24 18:35 UTC)
* ApiGatewayV2 (3.7.200.4)
	* Documentation updates for Amazon API Gateway.
* ChimeSDKMediaPipelines (3.7.201.0)
	* AWS Media Pipeline compositing enhancement and Media Insights Pipeline auto language identification.
* CloudFormation (3.7.202.0)
	* This release supports filtering by DRIFT_STATUS for existing API ListStackInstances and adds support for a new API ListStackInstanceResourceDrifts. Customers can now view resource drift information from their StackSet management accounts.
* CostExplorer (3.7.201.0)
	* This release introduces the new API 'GetSavingsPlanPurchaseRecommendationDetails', which retrieves the details for a Savings Plan recommendation. It also updates the existing API 'GetSavingsPlansPurchaseRecommendation' to include the recommendation detail ID.
* EC2 (3.7.201.0)
	* Add "disabled" enum value to SpotInstanceState.
* Glue (3.7.202.0)
	* Added support for Data Preparation Recipe node in Glue Studio jobs
* QuickSight (3.7.201.0)
	* This release launches new Snapshot APIs for CSV and PDF exports, adds support for info icon for filters and parameters in Exploration APIs, adds modeled exception to the DeleteAccountCustomization API, and introduces AttributeAggregationFunction's ability to add UNIQUE_VALUE aggregation in tooltips.
* Core 3.7.200.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.604.0 (2023-07-21 18:47 UTC)
* Glue (3.7.201.0)
	* This release adds support for AWS Glue Crawler with Apache Hudi Tables, allowing Crawlers to discover Hudi Tables in S3 and register them in Glue Data Catalog for query engines to query against.
* MediaConvert (3.7.201.0)
	* This release includes improvements to Preserve 444 handling, compatibility of HEVC sources without frame rates, and general improvements to MP4 outputs.
* RDS (3.7.201.0)
	* Adds support for the DBSystemID parameter of CreateDBInstance to RDS Custom for Oracle.
* WorkSpaces (3.7.200.3)
	* Fixed VolumeEncryptionKey descriptions
* Core 3.7.200.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.603.0 (2023-07-20 19:07 UTC)
* CodeCatalyst (3.7.201.0)
	* This release adds support for updating and deleting spaces and projects in Amazon CodeCatalyst. It also adds support for creating, getting, and deleting source repositories in CodeCatalyst projects.
* ConnectCases (3.7.201.0)
	* This release adds the ability to assign a case to a queue or user.
* LexModelsV2 (3.7.202.0)
	* This release updates type for Channel field in SessionSpecification and UtteranceSpecification
* Route53Resolver (3.7.201.0)
	* This release adds support for Route 53 On Outposts, a new feature that allows customers to run Route 53 Resolver and Resolver endpoints locally on their Outposts.
* S3 (3.7.201.0)
	* Improve performance of S3 clients by simplifying and optimizing endpoint resolution.
* SageMaker (3.7.201.0)
	* Cross account support for SageMaker Feature Store
* SageMakerFeatureStoreRuntime (3.7.201.0)
	* Cross account support for SageMaker Feature Store
* SecurityLake (3.7.201.0)
	* Adding support for Tags on Create and Resource Tagging API.
* TranscribeService (3.7.201.0)
	* Added API argument --toxicity-detection to startTranscriptionJob API, which allows users to view toxicity scores of submitted audio.

### 3.7.602.1 (2023-07-20 03:53 UTC)
* SavingsPlans (3.7.200.2)
	* Savings Plans endpoints update
* Core 3.7.200.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.602.0 (2023-07-19 18:25 UTC)
* CloudFormation (3.7.201.0)
	* SDK and documentation updates for GetTemplateSummary API (unrecognized resources)
* EC2 (3.7.200.2)
	* Amazon EC2 documentation updates.
* ManagedGrafana (3.7.201.0)
	* Amazon Managed Grafana now supports grafanaVersion update for existing workspaces with UpdateWorkspaceConfiguration API. DescribeWorkspaceConfiguration API additionally returns grafanaVersion. A new ListVersions API lists available versions or, if given a workspaceId, the versions it can upgrade to.
* MedicalImaging (3.7.200.0)
	* General Availability (GA) release of AWS Health Imaging, enabling customers to store, transform, and analyze medical imaging data at petabyte-scale.
* RAM (3.7.201.0)
	* This release adds support for securely sharing with AWS service principals.
* SsmSap (3.7.201.0)
	* Added support for SAP Hana High Availability discovery (primary and secondary nodes) and Backint agent installation with SSM for SAP.
* WAFV2 (3.7.201.0)
	* Added the URI path to the custom aggregation keys that you can specify for a rate-based rule.

### 3.7.601.0 (2023-07-18 18:24 UTC)
* CodeGuruSecurity (3.7.200.1)
	* Documentation updates for CodeGuru Security.
* Connect (3.7.200.1)
	* GetMetricDataV2 API: Update to include Contact Lens Conversational Analytics Metrics
* Elasticsearch (3.7.201.0)
	* Regex Validation on the ElasticSearch Engine Version attribute
* LexModelsV2 (3.7.201.0)
	* This release adds support for Lex Developers to view analytics for their bots.
* MainframeModernization (3.7.201.0)
	* Allows UpdateEnvironment to update the environment to 0 host capacity. New GetSignedBluinsightsUrl API
* Snowball (3.7.201.0)
	* Adds support for RACK_5U_C. This is the first AWS Snow Family device designed to meet U.S. Military Ruggedization Standards (MIL-STD-810H) with 208 vCPU device in a portable, compact 5U, half-rack width form-factor.
* Translate (3.7.200.1)
	* Added DOCX word document support to TranslateDocument API
* Core 3.7.200.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.600.0 (2023-18-07 00:00 UTC)
* All (Core and Services) updated to version 3.7.200.0
	* Updated code analyzers to target `netstandard2.0` (from `net45`). With this update, there'll be impact if you're using Visual Studio 2017 (or earlier) _and_ configured your project to treat warnings as errors (the `Microsoft.CodeAnalysis` dependency was upgraded to `3.0.0` - which only supports Visual Studio 2019 and later). If using a newer version of compiler tooling is not an option, see https://github.com/aws/aws-sdk-net/issues/2998 for alternatives.

### 3.7.589.0 (2023-07-17 18:36 UTC)
* CodeArtifact (3.7.104.56)
	* Doc only update for AWS CodeArtifact
* DocDB (3.7.102.0)
	* Added major version upgrade option in ModifyDBCluster API
* EC2 (3.7.142.0)
	* Add Nitro TPM support on DescribeInstanceTypes
* Glue (3.7.121.0)
	* Adding new supported permission type flags to get-unfiltered endpoints that callers may pass to indicate support for enforcing Lake Formation fine-grained access control on nested column attributes.
* IVS (3.7.106.0)
	* This release provides the flexibility to configure what renditions or thumbnail qualities to record when creating recording configuration.
* LakeFormation (3.7.105.0)
	* Adds supports for ReadOnlyAdmins and AllowFullTableExternalDataAccess. Adds NESTED_PERMISSION and NESTED_CELL_PERMISSION to SUPPORTED_PERMISSION_TYPES enum. Adds CREATE_LF_TAG on catalog resource and ALTER, DROP, and GRANT_WITH_LF_TAG_EXPRESSION on LF Tag resource.
* Core 3.7.108.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.588.0 (2023-07-13 18:30 UTC)
* CognitoIdentityProvider (3.7.103.0)
	* API model updated in Amazon Cognito
* Connect (3.7.130.0)
	* Add support for deleting Queues and Routing Profiles.
* DatabaseMigrationService (3.7.105.0)
	* Enhanced PostgreSQL target endpoint settings for providing Babelfish support.
* DataSync (3.7.106.0)
	* Added LunCount to the response object of DescribeStorageSystemResourcesResponse, LunCount represents the number of LUNs on a storage system resource.
* EC2 (3.7.141.0)
	* This release adds support for the C7gn and Hpc7g instances. C7gn instances are powered by AWS Graviton3 processors and the fifth-generation AWS Nitro Cards. Hpc7g instances are powered by AWS Graviton 3E processors and provide up to 200 Gbps network bandwidth.
* FSx (3.7.104.0)
	* Amazon FSx for NetApp ONTAP now supports SnapLock, an ONTAP feature that enables you to protect your files in a volume by transitioning them to a write once, read many (WORM) state.
* IdentityManagement (3.7.102.6)
	* Documentation updates for AWS Identity and Access Management (IAM).
* MediaTailor (3.7.107.0)
	* Adds categories to MediaTailor channel assembly alerts
* Personalize (3.7.103.0)
	* This release provides ability to customers to change schema associated with their datasets in Amazon Personalize
* Proton (3.7.106.0)
	* This release adds support for deployment history for Proton provisioned resources
* S3 (3.7.108.0)
	* S3 Inventory now supports Object Access Control List and Object Owner as available object metadata fields in inventory reports.
* SageMaker (3.7.143.0)
	* Amazon SageMaker Canvas adds WorkspeceSettings support for CanvasAppSettings
* SecretsManager (3.7.102.65)
	* Documentation updates for Secrets Manager
* Core 3.7.108.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.587.0 (2023-07-11 04:43 UTC)
* CognitoIdentityProvider (3.7.102.0)
	* API model updated in Amazon Cognito

### 3.7.586.0 (2023-07-07 18:21 UTC)
* CloudWatchLogs (3.7.106.0)
	* Add CMK encryption support for CloudWatch Logs Insights query result data
* DatabaseMigrationService (3.7.104.0)
	* Releasing DMS Serverless. Adding support for PostgreSQL 15.x as source and target endpoint. Adding support for DocDB Elastic Clusters with sharded collections, PostgreSQL datatype mapping customization and disabling hostname validation of the certificate authority in Kafka endpoint settings
* Glue (3.7.120.0)
	* This release enables customers to create new Apache Iceberg tables and associated metadata in Amazon S3 by using native AWS Glue CreateTable operation.
* MediaLive (3.7.107.0)
	* This release enables the use of Thumbnails in AWS Elemental MediaLive.
* MediaTailor (3.7.106.0)
	* The AWS Elemental MediaTailor SDK for Channel Assembly has added support for EXT-X-CUE-OUT and EXT-X-CUE-IN tags to specify ad breaks in HLS outputs, including support for EXT-OATCLS, EXT-X-ASSET, and EXT-X-CUE-OUT-CONT accessory tags.
* Core 3.7.108.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.585.0 (2023-07-07 14:09 UTC)
* Core 3.7.108.0
	* Feat: Add support for service specific and global custom endpoints, which can be set via the configuration file or environment variables. Add a Profile object which can reroute the SDK to use the correct Profile when set on the ClientConfig and passed in to a service client constructor. ServiceClients that accept a Config object now call the overloaded GetAWSCredentialsMethod which checks for the Profile object
	* All services packages updated to require new Core

### 3.7.584.0 (2023-07-06 18:25 UTC)
* EC2 (3.7.140.0)
	* Add Nitro Enclaves support on DescribeInstanceTypes
* LocationService (3.7.105.0)
	* This release adds support for authenticating with Amazon Location Service's Places & Routes APIs with an API Key. Also, with this release developers can publish tracked device position updates to Amazon EventBridge.
* Outposts (3.7.105.0)
	* Added paginator support to several APIs. Added the ISOLATED enum value to AssetState.
* QuickSight (3.7.111.0)
	* This release includes below three changes: small multiples axes improvement, field based coloring, removed required trait from Aggregation function for TopBottomFilter.
* RDS (3.7.120.3)
	* Updates Amazon RDS documentation for creating DB instances and creating Aurora global clusters.
* Core 3.7.107.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.583.0 (2023-07-05 18:22 UTC)
* ComprehendMedical (3.7.102.7)
	* Update to Amazon Comprehend Medical documentation.
* Connect (3.7.129.3)
	* GetMetricDataV2 API: Channels filters do not count towards overall limitation of 100 filter values.
* KeyManagementService (3.7.104.0)
	* Added Dry Run Feature to cryptographic and cross-account mutating KMS APIs (14 in all). This feature allows users to test their permissions and parameters before making the actual API call.
* Mgn (3.7.103.0)
	* This release introduces the Global view feature and new Replication state APIs.
* SecurityHub (3.7.109.5)
	* Documentation updates for AWS Security Hub

### 3.7.582.1 (2023-07-05 14:18 UTC)
* Core 3.7.107.11
	* fix: Revert update to analyzer projects (previous update unintentionally removed support for tooling such as VS2017)
	* All services packages updated to require new Core

### 3.7.582.0 (2023-07-03 18:28 UTC)
* Batch (3.7.105.0)
	* This feature allows customers to use AWS Batch with Linux with ARM64 CPU Architecture and X86_64 CPU Architecture with Windows OS on Fargate Platform.
* SageMaker (3.7.142.0)
	* SageMaker Inference Recommender now accepts new fields SupportedEndpointType and ServerlessConfiguration to support serverless endpoints.
* Core 3.7.107.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.581.0 (2023-06-30 18:26 UTC)
* ECS (3.7.109.0)
	* Added new field  "credentialspecs" to the ecs task definition to support gMSA of windows/linux in both domainless and domain-joined mode
* IVS (3.7.105.0)
	* Corrects the HTTP response code in the generated docs for PutMetadata and DeleteRecordingConfiguration APIs.
* MediaConvert (3.7.112.1)
	* This release includes improved color handling of overlays and general updates to user documentation.
* PrometheusService (3.7.101.0)
	* AWS SDK service model  generation tool version upgrade.
* SageMaker (3.7.141.0)
	* This release adds support for rolling deployment in SageMaker Inference.
* Transfer (3.7.107.0)
	* Add outbound Basic authentication support to AS2 connectors
* VerifiedPermissions (3.7.100.5)
	* This release corrects several broken links in the documentation.

### 3.7.580.0 (2023-06-29 19:25 UTC)
* AppStream (3.7.103.0)
	* This release introduces app block builder, allowing customers to provision a resource to package applications into an app block
* Chime (3.7.102.0)
	* The Amazon Chime SDK APIs in the Chime namespace are no longer supported.  Customers should use APIs in the dedicated Amazon Chime SDK namespaces: ChimeSDKIdentity, ChimeSDKMediaPipelines, ChimeSDKMeetings, ChimeSDKMessaging, and ChimeSDKVoice.
* CleanRooms (3.7.102.0)
	* This release adds support for the OR operator in RSQL join match conditions and the ability to control which operators (AND, OR) are allowed in a join match condition.
* DynamoDBv2 (3.7.105.0)
	* This release adds ReturnValuesOnConditionCheckFailure parameter to PutItem, UpdateItem, DeleteItem, ExecuteStatement, BatchExecuteStatement and ExecuteTransaction APIs. When set to ALL_OLD,  API returns a copy of the item as it was when a conditional write failed
* GameLift (3.7.105.0)
	* Amazon GameLift now supports game builds that use the Amazon Linux 2023 (AL2023) operating system.
* Glue (3.7.119.0)
	* This release adds support for AWS Glue Crawler with Iceberg Tables, allowing Crawlers to discover Iceberg Tables in S3 and register them in Glue Data Catalog for query engines to query against.
* SageMaker (3.7.140.0)
	* Adding support for timeseries forecasting in the CreateAutoMLJobV2 API.

### 3.7.579.0 (2023-06-28 18:25 UTC)
* InternetMonitor (3.7.103.0)
	* This release adds a new feature for Amazon CloudWatch Internet Monitor that enables customers to set custom thresholds, for performance and availability drops, for triggering when to create a health event.
* KinesisAnalyticsV2 (3.7.102.0)
	* Support for new runtime environment in Kinesis Data Analytics Studio: Zeppelin-0.10, Apache Flink-1.15
* Lambda (3.7.113.0)
	* Surface ResourceConflictException in DeleteEventSourceMapping
* Omics (3.7.104.0)
	* Add Common Workflow Language (CWL) as a supported language for Omics workflows
* RDS (3.7.120.0)
	* Amazon Relational Database Service (RDS) now supports joining a RDS for SQL Server instance to a self-managed Active Directory.
* S3 (3.7.107.0)
	* The S3 LISTObjects, ListObjectsV2 and ListObjectVersions API now supports a new optional header x-amz-optional-object-attributes. If header contains RestoreStatus as the value, then S3 will include Glacier restore status i.e. isRestoreInProgress and RestoreExpiryDate in List response.
* SageMaker (3.7.139.0)
	* This release adds support for Model Cards Model Registry integration.

### 3.7.578.0 (2023-06-27 18:38 UTC)
* AppFabric (3.7.100.0)
	* Initial release of AWS AppFabric for connecting SaaS applications for better productivity and security.
* Appflow (3.7.113.0)
	* This release adds support to bypass SSO with the SAPOData connector when connecting to an SAP instance.
* EMRServerless (3.7.105.0)
	* This release adds support to update the release label of an EMR Serverless application to upgrade it to a different version of Amazon EMR via UpdateApplication API.
* IVS (3.7.104.0)
	* IVS customers can now revoke the viewer session associated with an auth token, to prevent and stop playback using that token.
* KinesisVideo (3.7.103.0)
	* General Availability (GA) release of Kinesis Video Streams at Edge, enabling customers to provide a configuration for the Kinesis Video Streams EdgeAgent running on an on-premise IoT device. Customers can now locally record from cameras and stream videos to the cloud on a configured schedule.
* Macie2 (3.7.104.0)
	* This release adds support for configuring new classification jobs to use the set of managed data identifiers that we recommend for jobs. For the managed data identifier selection type (managedDataIdentifierSelector), specify RECOMMENDED.
* Private5G (3.7.103.0)
	* This release allows Private5G customers to choose different commitment plans (60-days, 1-year, 3-years) when placing new orders, enables automatic renewal option for 1-year and 3-years commitments. It also allows customers to update the commitment plan of an existing radio unit.
* SageMaker (3.7.138.0)
	* Introducing TTL for online store records in feature groups.
* SageMakerFeatureStoreRuntime (3.7.103.0)
	* Introducing TTL for online store records for feature groups.
* SimpleSystemsManagement (3.7.104.51)
	* Systems Manager doc-only update for June 2023.
* VerifiedPermissions (3.7.100.4)
	* This update fixes several broken links to the Cedar documentation.

### 3.7.577.0 (2023-06-26 18:23 UTC)
* Connect (3.7.129.0)
	* This release provides a way to search for existing tags within an instance. Before tagging a resource, ensure consistency by searching for pre-existing key:value pairs.
* Glue (3.7.118.0)
	* Timestamp Starting Position For Kinesis and Kafka Data Sources in a Glue Streaming Job
* GuardDuty (3.7.107.0)
	* Add support for user.extra.sessionName in Kubernetes Audit Logs Findings.
* IdentityManagement (3.7.102.0)
	* Support for a new API "GetMFADevice" to present MFA device metadata such as device certifications
* Pinpoint (3.7.102.0)
	* Added time zone estimation support for journeys

### 3.7.576.0 (2023-06-23 18:21 UTC)
* DevOpsGuru (3.7.103.0)
	* This release adds support for encryption via customer managed keys.
* FSx (3.7.103.4)
	* Update to Amazon FSx documentation.
* RDS (3.7.119.12)
	* Documentation improvements for create, describe, and modify DB clusters and DB instances.
* VerifiedPermissions (3.7.100.3)
	* Added improved descriptions and new code samples to SDK documentation.

### 3.7.575.0 (2023-06-22 18:21 UTC)
* ChimeSDKIdentity (3.7.102.0)
	* AppInstanceBots can be configured to be invoked or not using the Target or the CHIME.mentions attribute for ChannelMessages
* ChimeSDKMessaging (3.7.104.0)
	* ChannelMessages can be made visible to sender and intended recipient rather than all channel members with the target attribute. For example, a user can send messages to a bot and receive messages back in a group channel without other members seeing them.
* Kendra (3.7.105.0)
	* Introducing Amazon Kendra Retrieve API that can be used to retrieve relevant passages or text excerpts given an input query.
* StepFunctions (3.7.103.0)
	* Adds support for Versions and Aliases. Adds 8 operations: PublishStateMachineVersion, DeleteStateMachineVersion, ListStateMachineVersions, CreateStateMachineAlias, DescribeStateMachineAlias, UpdateStateMachineAlias, DeleteStateMachineAlias, ListStateMachineAliases

### 3.7.574.0 (2023-06-21 18:23 UTC)
* DynamoDBv2 (3.7.104.1)
	* Documentation updates for DynamoDB
* ElasticMapReduce (3.7.106.0)
	* This release introduces a new Amazon EMR EPI called ListSupportedInstanceTypes that returns a list of all instance types supported by a given EMR release.
* Inspector2 (3.7.106.0)
	* This release adds support for Software Bill of Materials (SBOM) export and the general availability of code scanning for AWS Lambda functions.
* MediaConvert (3.7.112.0)
	* This release introduces the bandwidth reduction filter for the HEVC encoder, increases the limits of outputs per job, and updates support for the Nagra SDK to version 1.14.7.
* MQ (3.7.101.0)
	* The Cross Region Disaster Recovery feature allows to replicate a brokers state from one region to another in order to provide customers with multi-region resiliency in the event of a regional outage.
* SageMaker (3.7.137.0)
	* This release provides support in SageMaker for output files in training jobs to be uploaded without compression and enable customer to deploy uncompressed model from S3 to real-time inference Endpoints. In addition, ml.trn1n.32xlarge is added to supported instance type list in training job.
* Transfer (3.7.106.0)
	* This release adds a new parameter StructuredLogDestinations to CreateServer, UpdateServer APIs.

### 3.7.573.0 (2023-06-20 23:51 UTC)
* DynamoDBv2 (3.7.104.0)
	* Updated documentation for DynamoDB Streams. Add non-generic batchwrite methods on DynamoDBContext.
* RDS (3.7.119.11)
	* Add async version of RDSAuthTokenGenerator GenerateAuthToken.
* Core 3.7.107.9
	* Reduce empty array allocations by using Array.Empty<T>.

### 3.7.572.0 (2023-06-20 19:58 UTC)
* Appflow (3.7.112.0)
	* This release adds new API to reset connector metadata cache
* ConfigService (3.7.106.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in May 2023.
* EC2 (3.7.139.0)
	* Adds support for targeting Dedicated Host allocations by assetIds in AWS Outposts
* Lambda (3.7.112.0)
	* This release adds RecursiveInvocationException to the Invoke API and InvokeWithResponseStream API.
* Redshift (3.7.102.0)
	* Added support for custom domain names for Redshift Provisioned clusters. This feature enables customers to create a custom domain name and use ACM to generate fully secure connections to it.
* Core 3.7.107.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.571.0 (2023-06-19 18:23 UTC)
* CloudFormation (3.7.108.0)
	* Specify desired CloudFormation behavior in the event of ChangeSet execution failure using the CreateChangeSet OnStackFailure parameter
* EC2 (3.7.138.0)
	* API changes to AWS Verified Access to include data from trust providers in logs
* ECS (3.7.108.22)
	* Documentation only update to address various tickets.
* Glue (3.7.117.0)
	* This release adds support for creating cross region table/database resource links
* Pricing (3.7.102.0)
	* This release updates the PriceListArn regex pattern.
* Route53Domains (3.7.102.0)
	* Update MaxItems upper bound to 1000 for ListPricesRequest
* SageMaker (3.7.136.0)
	* Amazon Sagemaker Autopilot releases CreateAutoMLJobV2 and DescribeAutoMLJobV2 for Autopilot customers with ImageClassification, TextClassification and Tabular problem type config support.

### 3.7.570.0 (2023-06-16 18:56 UTC)
* Account (3.7.103.0)
	* Improve pagination support for ListRegions
* ApplicationDiscoveryService (3.7.102.0)
	* Add Amazon EC2 instance recommendations export
* Connect (3.7.128.0)
	* Updates the *InstanceStorageConfig APIs to support a new ResourceType: SCREEN_RECORDINGS to enable screen recording and specify the storage configurations for publishing the recordings. Also updates DescribeInstance and ListInstances APIs to include InstanceAccessUrl attribute in the API response.
* IdentityManagement (3.7.101.5)
	* Documentation updates for AWS Identity and Access Management (IAM).
* S3 (3.7.106.0)
	* This release adds SDK support for request-payer request header and request-charged response header in the "GetBucketAccelerateConfiguration", "ListMultipartUploads", "ListObjects", "ListObjectsV2" and "ListObjectVersions" S3 APIs.

### 3.7.569.0 (2023-06-15 18:25 UTC)
* AuditManager (3.7.104.0)
	* This release introduces 2 Audit Manager features: CSV exports and new manual evidence options. You can now export your evidence finder results in CSV format. In addition, you can now add manual evidence to a control by entering free-form text or uploading a file from your browser.
* ElasticFileSystem (3.7.102.24)
	* Documentation updates for EFS.
* GuardDuty (3.7.106.20)
	* Updated descriptions for some APIs.
* LocationService (3.7.104.0)
	* Amazon Location Service adds categories to places, including filtering on those categories in searches. Also, you can now add metadata properties to your geofences.
* Core 3.7.107.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.568.0 (2023-06-13 20:44 UTC)
* CloudTrail (3.7.107.0)
	* This feature allows users to view dashboards for CloudTrail Lake event data stores.
* CodeGuruSecurity (3.7.100.0)
	* Initial release of Amazon CodeGuru Security APIs
* Drs (3.7.105.0)
	* Added APIs to support network replication and recovery using AWS Elastic Disaster Recovery.
* EC2 (3.7.137.0)
	* This release introduces a new feature, EC2 Instance Connect Endpoint, that enables you to connect to a resource over TCP, without requiring the resource to have a public IPv4 address.
* Imagebuilder (3.7.103.43)
	* Change the Image Builder ImagePipeline dateNextRun field to more accurately describe the data.
* Lightsail (3.7.103.0)
	* This release adds pagination for the Get Certificates API operation.
* S3 (3.7.105.0)
	* Integrate double encryption feature to SDKs.
* SecurityHub (3.7.109.0)
	* Add support for Security Hub Automation Rules
* SimSpaceWeaver (3.7.102.0)
	* This release fixes using aws-us-gov ARNs in API calls and adds documentation for snapshot APIs.
* VerifiedPermissions (3.7.100.0)
	* GA release of Amazon Verified Permissions.
* WAFV2 (3.7.112.0)
	* You can now detect and block fraudulent account creation attempts with the new AWS WAF Fraud Control account creation fraud prevention (ACFP) managed rule group AWSManagedRulesACFPRuleSet.
* WellArchitected (3.7.104.0)
	* AWS Well-Architected now supports Profiles that help customers prioritize which questions to focus on first by providing a list of prioritized questions that are better aligned with their business goals and outcomes.
* Core 3.7.107.6
	* All services packages updated to require new Core

### 3.7.567.0 (2023-06-12 19:23 UTC)
* AmplifyUIBuilder (3.7.102.0)
	* AWS Amplify UIBuilder is launching Codegen UI, a new feature that enables you to generate your amplify uibuilder components and forms.
* DynamoDBv2 (3.7.103.20)
	* Documentation updates for DynamoDB
* FSx (3.7.103.0)
	* Amazon FSx for NetApp ONTAP now supports joining a storage virtual machine (SVM) to Active Directory after the SVM has been created.
* OpenSearchService (3.7.108.0)
	* This release adds support for SkipUnavailable connection property for cross cluster search
* Rekognition (3.7.108.0)
	* This release adds support for improved accuracy with user vector in Amazon Rekognition Face Search. Adds new APIs: AssociateFaces, CreateUser, DeleteUser, DisassociateFaces, ListUsers, SearchUsers, SearchUsersByImage. Also adds new face metadata that can be stored: user vector.
* SageMaker (3.7.135.0)
	* Sagemaker Neo now supports compilation for inferentia2 (ML_INF2) and Trainium1 (ML_TRN1) as available targets. With these devices, you can run your workloads at highest performance with lowest cost. inferentia2 (ML_INF2) is available in CMH and Trainium1 (ML_TRN1) is available in IAD currently
* Core 3.7.107.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.566.0 (2023-06-09 18:22 UTC)
* ACMPCA (3.7.102.94)
	* Document-only update to refresh CLI  documentation for AWS Private CA. No change to the service.
* Connect (3.7.127.0)
	* This release adds search APIs for Prompts, Quick Connects and Hours of Operations, which can be used to search for those resources within a Connect Instance.

### 3.7.565.0 (2023-06-08 18:24 UTC)
* Athena (3.7.111.0)
	* You can now define custom spark properties at start of the session for use cases like cluster encryption, table formats, and general Spark tuning.
* ComprehendMedical (3.7.102.0)
	* This release supports a new set of entities and traits.
* PaymentCryptography (3.7.100.0)
	* Initial release of AWS Payment Cryptography Control Plane service for creating and managing cryptographic keys used during card payment processing.
* PaymentCryptographyData (3.7.100.0)
	* Initial release of AWS Payment Cryptography DataPlane Plane service for performing cryptographic operations typically used during card payment processing.
* ServiceCatalog (3.7.104.0)
	* New parameter added in ServiceCatalog DescribeProvisioningArtifact api - IncludeProvisioningArtifactParameters. This parameter can be used to return information about the parameters used to provision the product
* TimestreamWrite (3.7.102.0)
	* This release adds the capability for customers to define how their data should be partitioned, optimizing for certain access patterns. This definition will take place as a part of the table creation.
* Core 3.7.107.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.564.0 (2023-06-07 18:24 UTC)
* CloudFormation (3.7.107.0)
	* AWS CloudFormation StackSets is updating the deployment experience for all stackset operations to skip suspended AWS accounts during deployments. StackSets will skip target AWS accounts that are suspended and set the Detailed Status of the corresponding stack instances as SKIPPED_SUSPENDED_ACCOUNT
* CloudWatchLogs (3.7.105.0)
	* This change adds support for account level data protection policies using 3 new APIs, PutAccountPolicy, DeleteAccountPolicy and DescribeAccountPolicy. DescribeLogGroup API has been modified to indicate if account level policy is applied to the LogGroup via "inheritedProperties" list in the response.
* CustomerProfiles (3.7.105.0)
	* This release introduces event stream related APIs.
* DirectConnect (3.7.100.143)
	* This update corrects the jumbo frames mtu values from 9100 to 8500 for transit virtual interfaces.
* EMRContainers (3.7.104.0)
	* EMR on EKS adds support for log rotation of Spark container logs with EMR-6.11.0 onwards, to the StartJobRun API.
* IoTDeviceAdvisor (3.7.103.0)
	* AWS IoT Core Device Advisor now supports new Qualification Suite test case list. With this update, customers can more easily create new qualification test suite with an empty rootGroup input.

### 3.7.563.0 (2023-06-06 18:28 UTC)
* Connect (3.7.126.6)
	* GetMetricDataV2 API is now available in AWS GovCloud(US) region.
* ElasticMapReduce (3.7.105.0)
	* This release provides customers the ability to specify an allocation strategies amongst PRICE_CAPACITY_OPTIMIZED, CAPACITY_OPTIMIZED, LOWEST_PRICE, DIVERSIFIED for Spot instances in Instance Feet cluster. This enables customers to choose an allocation strategy best suited for their workload.
* IdentityManagement (3.7.101.0)
	* This release updates the AccountAlias regex pattern with the same length restrictions enforced by the length constraint.
* Inspector2 (3.7.105.0)
	* Adds new response properties and request parameters for 'last scanned at' on the ListCoverage operation. This feature allows you to search and view the date of which your resources were last scanned by Inspector.
* IoT (3.7.109.0)
	* Adding IoT Device Management Software Package Catalog APIs to register, store, and report system software packages, along with their versions and metadata in a centralized location.
* IotData (3.7.104.0)
	* Update thing shadow name regex to allow '$' character
* LexModelsV2 (3.7.103.0)
	* This release adds support for Lex Developers to create test sets and to execute those test-sets against their bots.
* QuickSight (3.7.110.0)
	* QuickSight support for pivot table field collapse state, radar chart range scale and multiple scope options in conditional formatting.
* Signer (3.7.101.0)
	* AWS Signer is launching Container Image Signing, a new feature that enables you to sign and verify container images. This feature enables you to validate that only container images you approve are used in your enterprise.
* SQS (3.7.103.0)
	* Amazon SQS adds three new APIs - StartMessageMoveTask, CancelMessageMoveTask, and ListMessageMoveTasks to automate redriving messages from dead-letter queues to source queues or a custom destination.
* Core 3.7.107.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.562.0 (2023-06-05 18:28 UTC)
* CloudFormation (3.7.106.0)
	* AWS CloudFormation StackSets provides customers with three new APIs to activate, deactivate, and describe AWS Organizations trusted access which is needed to get started with service-managed StackSets.
* EC2 (3.7.136.0)
	* Making InstanceTagAttribute as the required parameter for the DeregisterInstanceEventNotificationAttributes and RegisterInstanceEventNotificationAttributes APIs.
* Finspace (3.7.101.0)
	* Releasing new Managed kdb Insights APIs
* FraudDetector (3.7.104.0)
	* Added new variable types, new DateTime data type, and new rules engine functions for interacting and working with DateTime data types.
* KeyManagementService (3.7.103.0)
	* This release includes feature to import customer's asymmetric (RSA and ECC) and HMAC keys into KMS.  It also includes feature to allow customers to specify number of days to schedule a KMS key deletion as a policy condition key.
* Keyspaces (3.7.103.0)
	* This release adds support for MRR GA launch, and includes multiregion support in create-keyspace, get-keyspace, and list-keyspace.
* Lambda (3.7.111.0)
	* Add Ruby 3.2 (ruby3.2) Runtime support to AWS Lambda.
* MWAA (3.7.102.0)
	* This release adds ROLLING_BACK and CREATING_SNAPSHOT environment statuses for Amazon MWAA environments.
* Core 3.7.107.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.561.0 (2023-06-02 18:22 UTC)
* Athena (3.7.110.0)
	* This release introduces the DeleteCapacityReservation API and the ability to manage capacity reservations using CloudFormation
* CloudTrail (3.7.106.0)
	* This feature allows users to start and stop event ingestion on a CloudTrail Lake event data store.
* SageMaker (3.7.134.0)
	* This release adds Selective Execution feature that allows SageMaker Pipelines users to run selected steps in a pipeline.
* WAFV2 (3.7.111.0)
	* Added APIs to describe managed products. The APIs retrieve information about rule groups that are managed by AWS and by AWS Marketplace sellers.
* Core 3.7.107.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.560.0 (2023-06-02 13:59 UTC)
* Core 3.7.107.0
	* Move UpdateSecurityProtocol from HttpWebRequestFactory to AmazonServiceClient. Small performance tweaks using the HttpClient with .NET Core. Updated UriEncode to match the specification to encode all characters except unreserved characters per RFC 3986
	* All services packages updated to require new Core

### 3.7.559.0 (2023-06-01 18:29 UTC)
* AlexaForBusiness (3.7.100.138)
	* Alexa for Business has been deprecated and is no longer supported.
* Appflow (3.7.111.0)
	* Added ability to select DataTransferApiType for DescribeConnector and CreateFlow requests when using Async supported connectors. Added supportedDataTransferType to DescribeConnector/DescribeConnectors/ListConnector response.
* CustomerProfiles (3.7.104.0)
	* This release introduces calculated attribute related APIs.
* IVS (3.7.103.0)
	* API Update for IVS Advanced Channel type
* SageMaker (3.7.133.2)
	* Amazon Sagemaker Autopilot adds support for Parquet file input to NLP text classification jobs.
* WAFV2 (3.7.110.1)
	* Corrected the information for the header order FieldToMatch setting
* Core 3.7.106.45
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.558.0 (2023-05-31 18:29 UTC)
* ConfigService (3.7.105.0)
	* Resource Types Exclusion feature launch by AWS Config
* FraudDetector (3.7.103.0)
	* This release enables publishing event predictions from Amazon Fraud Detector (AFD) to Amazon EventBridge. For example, after getting predictions from AFD, Amazon EventBridge rules can be configured to trigger notification through an SNS topic, send a message with SES, or trigger Lambda workflows.
* HealthLake (3.7.101.0)
	* This release adds a new request parameter to the CreateFHIRDatastore API operation. IdentityProviderConfiguration specifies how you want to authenticate incoming requests to your Healthlake Data Store.
* MainframeModernization (3.7.103.0)
	* Adds an optional create-only 'roleArn' property to Application resources.  Enables PS and PO data set org types.
* RDS (3.7.119.0)
	* This release adds support for changing the engine for Oracle using the ModifyDbInstance API
* ServiceCatalog (3.7.103.33)
	* Documentation updates for ServiceCatalog.
* WorkSpacesWeb (3.7.102.0)
	* WorkSpaces Web now allows you to control which IP addresses your WorkSpaces Web portal may be accessed from.

### 3.7.557.0 (2023-05-30 18:30 UTC)
* ChimeSDKVoice (3.7.105.0)
	* Added optional CallLeg field to StartSpeakerSearchTask API request
* Glue (3.7.116.0)
	* Added Runtime parameter to allow selection of Ray Runtime
* GroundStation (3.7.104.26)
	* Updating description of GetMinuteUsage to be clearer.
* IoTFleetWise (3.7.104.0)
	* Campaigns now support selecting Timestream or S3 as the data destination, Signal catalogs now support "Deprecation" keyword released in VSS v2.1 and "Comment" keyword released in VSS v3.0
* LocationService (3.7.103.0)
	* This release adds API support for political views for the maps service APIs: CreateMap, UpdateMap, DescribeMap.
* MemoryDB (3.7.103.0)
	* Amazon MemoryDB for Redis now supports AWS Identity and Access Management authentication access to Redis clusters starting with redis-engine version 7.0
* Personalize (3.7.102.0)
	* This release provides support for the exclusion of certain columns for training when creating a solution and creating or updating a recommender with Amazon Personalize.
* Polly (3.7.107.0)
	* Amazon Polly adds 2 new voices - Sofie (da-DK) and Niamh (en-IE)
* SecurityHub (3.7.108.0)
	* Added new resource detail objects to ASFF, including resources for AwsGuardDutyDetector, AwsAmazonMqBroker, AwsEventSchemasRegistry, AwsAppSyncGraphQlApi and AwsStepFunctionStateMachine.
* SecurityLake (3.7.103.0)
	* Log sources are now versioned. AWS log sources and custom sources will now come with a version identifier that enables producers to vend multiple schema versions to subscribers. Security Lake API have been refactored to more closely align with AWS API conventions.
* WAFV2 (3.7.110.0)
	* This SDK release provides customers the ability to use Header Order as a field to match.
* Core 3.7.106.44
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.556.0 (2023-05-26 18:22 UTC)
* Connect (3.7.126.0)
	* Documentation update for a new Initiation Method value in DescribeContact API
* IoTWireless (3.7.105.0)
	* Add Multicast Group support in Network Analyzer Configuration.
* SageMaker (3.7.133.0)
	* Added ml.p4d and ml.inf1 as supported instance type families for SageMaker Notebook Instances.
* Core 3.7.106.43
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.555.0 (2023-05-25 18:28 UTC)
* ApplicationAutoScaling (3.7.106.0)
	* With this release, ElastiCache customers will be able to use predefined metricType "ElastiCacheDatabaseCapacityUsageCountedForEvictPercentage" for their ElastiCache instances.
* CodePipeline (3.7.101.0)
	* Add PollingDisabledAt time information in PipelineMetadata object of GetPipeline API.
* GameLift (3.7.104.0)
	* GameLift FleetIQ users can now filter game server claim requests to exclude servers on instances that are draining.
* Glue (3.7.115.0)
	* Added ability to create data quality rulesets for shared, cross-account Glue Data Catalog tables. Added support for dataset comparison rules through a new parameter called AdditionalDataSources. Enhanced the data quality results with a map containing profiled metric values.
* MigrationHubRefactorSpaces (3.7.103.0)
	* This SDK update allows for path parameter syntax to be passed to the CreateRoute API. Path parameter syntax require parameters to be enclosed in {} characters. This update also includes a new AppendSourcePath field which lets users forward the source path to the Service URL endpoint.
* SageMaker (3.7.132.0)
	* Amazon SageMaker Automatic Model Tuning now supports enabling Autotune for tuning jobs which can choose tuning job configurations.
* Core 3.7.106.42
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.554.0 (2023-05-24 18:22 UTC)
* AppSync (3.7.105.0)
	* This release introduces AppSync Merged APIs, which provide the ability to compose multiple source APIs into a single federated/merged API.
* Connect (3.7.125.0)
	* Amazon Connect Evaluation Capabilities: validation improvements
* CostAndUsageReport (3.7.101.0)
	* Add support for split cost allocation data on a report.
* SageMaker (3.7.131.0)
	* SageMaker now provides an instantaneous deployment recommendation through the DescribeModel API
* Core 3.7.106.41
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.553.0 (2023-05-23 18:38 UTC)
* FMS (3.7.105.0)
	* Fixes issue that could cause calls to GetAdminScope and ListAdminAccountsForOrganization to return a 500 Internal Server error.
* SageMaker (3.7.130.0)
	* Added ModelNameEquals, ModelPackageVersionArnEquals in request and ModelName, SamplePayloadUrl, ModelPackageVersionArn in response of ListInferenceRecommendationsJobs API. Added Invocation timestamps in response of DescribeInferenceRecommendationsJob API & ListInferenceRecommendationsJobSteps API.
* Translate (3.7.102.0)
	* Added support for calling TranslateDocument API.
* Core 3.7.106.40
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.552.0 (2023-05-22 18:24 UTC)
* Backup (3.7.104.0)
	* Added support for tags on restore.
* Pinpoint (3.7.101.14)
	* Amazon Pinpoint is deprecating the tags parameter in the UpdateSegment, UpdateCampaign, UpdateEmailTemplate, UpdateSmsTemplate, UpdatePushTemplate, UpdateInAppTemplate and UpdateVoiceTemplate. Amazon Pinpoint will end support tags parameter by May 22, 2023.
* QuickSight (3.7.109.0)
	* Add support for Asset Bundle, Geospatial Heatmaps.

### 3.7.551.0 (2023-05-19 18:24 UTC)
* Backup (3.7.103.0)
	* Add  ResourceArn, ResourceType, and BackupVaultName to ListRecoveryPointsByLegalHold API response.
* ConnectCases (3.7.103.0)
	* This release adds the ability to create fields with type Url through the CreateField API. For more information see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* MediaPackageV2 (3.7.100.0)
	* Adds support for the MediaPackage Live v2 API
* SimpleEmailV2 (3.7.103.0)
	* This release allows customers to update scaling mode property of dedicated IP pools with PutDedicatedIpPoolScalingAttributes call.
* Core 3.7.106.39
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.550.0 (2023-05-19 13:57 UTC)
* DynamoDBv2 (3.7.103.7)
	* Update DynamoDBVersion to consider AttributeName.
* Lambda (3.7.110.0)
	* Added support for InvokeWithResponseStream, which allows users to stream responses back from Lambda. Added generator support for event streams.
* S3 (3.7.104.18)
	* Fixed an issue where GetObjectAttributes(Async) was not returning the correct LastModified date for an S3 object.

### 3.7.549.0 (2023-05-18 18:28 UTC)
* Athena (3.7.109.0)
	* Removing SparkProperties from EngineConfiguration object for StartSession API call
* CloudTrail (3.7.105.0)
	* Add ConflictException to PutEventSelectors, add (Channel/EDS)ARNInvalidException to Tag APIs. These exceptions provide customers with more specific error messages instead of internal errors.
* ComputeOptimizer (3.7.106.0)
	* In this launch, we add support for showing integration status with external metric providers such as Instana, Datadog ...etc in GetEC2InstanceRecommendations and ExportEC2InstanceRecommendations apis
* Connect (3.7.124.0)
	* You can programmatically create and manage prompts using APIs, for example, to extract prompts stored within Amazon Connect and add them to your Amazon S3 bucket. AWS CloudTrail, AWS CloudFormation and tagging are supported.
* EC2 (3.7.135.0)
	* Add support for i4g.large, i4g.xlarge, i4g.2xlarge, i4g.4xlarge, i4g.8xlarge and i4g.16xlarge instances powered by AWS Graviton2 processors that deliver up to 15% better compute performance than our other storage-optimized instances.
* ECS (3.7.108.6)
	* Documentation only release to address various tickets.
* MediaConvert (3.7.111.0)
	* This release introduces a new MXF Profile for XDCAM which is strictly compliant with the SMPTE RDD 9 standard and improved handling of output name modifiers.
* RDS (3.7.118.4)
	* RDS documentation update for the EngineVersion parameter of ModifyDBSnapshot
* SageMakerGeospatial (3.7.102.0)
	* This release makes ExecutionRoleArn a required field in the StartEarthObservationJob API.
* SecurityToken (3.7.103.0)
	* API updates for the AWS Security Token Service
* Core 3.7.106.38
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.548.0 (2023-05-16 18:28 UTC)
* Detective (3.7.102.0)
	* Added and updated API operations in Detective to support the integration of ASFF Security Hub findings.
* DirectConnect (3.7.100.130)
	* This release includes an update to the mtu value for CreateTransitVirtualInterface from 9001 mtu to 8500 mtu.
* Glue (3.7.114.0)
	* Add Support for Tags for Custom Entity Types
* SecretsManager (3.7.102.42)
	* Documentation updates for Secrets Manager
* WAFV2 (3.7.109.0)
	* My AWS Service (placeholder) - You can now rate limit web requests based on aggregation keys other than IP addresses, and you can aggregate using combinations of keys. You can also rate limit all requests that match a scope-down statement, without further aggregation.
* Core 3.7.106.37
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.547.0 (2023-05-15 18:30 UTC)
* Athena (3.7.108.0)
	* You can now define custom spark properties at start of the session for use cases like cluster encryption, table formats, and general Spark tuning.
* CodeCatalyst (3.7.102.0)
	* With this release, the users can list the active sessions connected to their Dev Environment on AWS CodeCatalyst
* IAMRolesAnywhere (3.7.101.0)
	* Adds support for custom notification settings in a trust anchor. Introduces PutNotificationSettings and ResetNotificationSettings API's. Updates DurationSeconds max value to 3600.
* Kafka (3.7.104.0)
	* Added a fix to make clusterarn a required field in ListClientVpcConnections and RejectClientVpcConnection APIs
* Rekognition (3.7.107.0)
	* This release adds a new EyeDirection attribute in Amazon Rekognition DetectFaces and IndexFaces APIs which predicts the yaw and pitch angles of a person's eye gaze direction for each face detected in the image.
* Transfer (3.7.105.0)
	* This release introduces the ability to require both password and SSH key when users authenticate to your Transfer Family servers that use the SFTP protocol.
* Core 3.7.106.36
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.546.0 (2023-05-11 18:25 UTC)
* AWSHealth (3.7.101.0)
	* Add support for regional endpoints
* AWSSupport (3.7.102.0)
	* This release adds 2 new Support APIs, DescribeCreateCaseOptions and DescribeSupportedLanguages. You can use these new APIs to get available support languages.
* Connect (3.7.123.4)
	* This release updates GetMetricDataV2 API, to support metric data up-to last 35 days
* ElastiCache (3.7.104.0)
	* Added support to modify the cluster mode configuration for the existing ElastiCache ReplicationGroups. Customers can now modify the configuration from cluster mode disabled to cluster mode enabled.
* Elasticsearch (3.7.102.0)
	* This release fixes DescribePackages API error with null filter value parameter.
* IVSRealTime (3.7.102.0)
	* Add methods for inspecting and debugging stages: ListStageSessions, GetStageSession, ListParticipants, GetParticipant, and ListParticipantEvents.
* Omics (3.7.103.0)
	* This release provides support for Ready2Run and GPU workflows, an improved read set filter, the direct upload of read sets into Omics Storage, and annotation parsing for analytics stores.
* OpenSearchService (3.7.107.0)
	* This release fixes DescribePackages API error with null filter value parameter.
* Route53Resolver (3.7.102.0)
	* Update FIPS endpoints for GovCloud (US) regions in SDK.
* Core 3.7.106.35
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.545.0 (2023-05-10 18:21 UTC)
* ElasticMapReduce (3.7.104.0)
	* EMR Studio now supports programmatically executing a Notebooks on an EMR on EKS cluster.  In addition, notebooks can now be executed by specifying its location in S3.
* RDS (3.7.118.0)
	* Amazon Relational Database Service (RDS) updates for the new Aurora I/O-Optimized storage type for Amazon Aurora DB clusters
* SimpleWorkflow (3.7.102.0)
	* This release adds a new API parameter to exclude old history events from decision tasks.

### 3.7.544.0 (2023-05-09 18:21 UTC)
* ApplicationAutoScaling (3.7.105.0)
	* With this release, Amazon SageMaker Serverless Inference customers can use Application Auto Scaling to auto scale the provisioned concurrency of their serverless endpoints.
* Glue (3.7.113.0)
	* This release adds AmazonRedshift Source and Target nodes in addition to DynamicTransform OutputSchemas
* SageMaker (3.7.129.0)
	* This release includes support for (1) Provisioned Concurrency for Amazon SageMaker Serverless Inference and (2) UpdateEndpointWeightsAndCapacities API for Serverless endpoints.
* Core 3.7.106.34
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.543.0 (2023-05-08 18:50 UTC)
* Glue (3.7.112.0)
	* Support large worker types G.4x and G.8x for Glue Spark
* GuardDuty (3.7.106.0)
	* Add AccessDeniedException 403 Error message code to support 3 Tagging related APIs
* IoTSiteWise (3.7.103.0)
	* Provide support for 20,000 max results for GetAssetPropertyValueHistory/BatchGetAssetPropertyValueHistory and 15 minute aggregate resolution for GetAssetPropertyAggregates/BatchGetAssetPropertyAggregates
* SecurityToken (3.7.102.0)
	* Documentation updates for AWS Security Token Service.
* Core 3.7.106.33
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.542.0 (2023-05-05 19:50 UTC)
* EC2 (3.7.134.0)
	* This release adds support the inf2 and trn1n instances. inf2 instances are purpose built for deep learning inference while trn1n instances are powered by AWS Trainium accelerators and they build on the capabilities of Trainium-powered trn1 instances.
* Inspector2 (3.7.104.0)
	* Amazon Inspector now allows customers to search its vulnerability intelligence database if any of the Inspector scanning types are activated.
* MediaTailor (3.7.105.0)
	* This release adds support for AFTER_LIVE_EDGE mode configuration for avail suppression, and adding a fill-policy setting that sets the avail suppression to PARTIAL_AVAIL or FULL_AVAIL_ONLY when AFTER_LIVE_EDGE is enabled.
* SQS (3.7.102.0)
	* Revert previous SQS protocol change.

### 3.7.541.0 (2023-05-05 13:37 UTC)
* CloudWatchLogs (3.7.104.69)
	* Set FlexibleTimeWindow.MaximumWindowInMinutes as nullable type
* DynamoDBv2 (3.7.103.0)
	* Recognize inherited DynamoDBAttributes on properties. Add support for transactional operations in DynamoDB high level libraries.
* S3 (3.7.104.11)
	* Fixed an issue where GetObjectAttributes(Async) was not returning parts even when explicit ChecksumAlgorithm was provided during object upload.
* Scheduler (3.7.101.84)
	* Set FlexibleTimeWindow.MaximumWindowInMinutes as nullable type

### 3.7.540.0 (2023-05-04 20:23 UTC)
* CloudWatch (3.7.104.0)
	* Adds support for filtering by metric names in CloudWatch Metric Streams.
* ConfigService (3.7.104.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in April 2023.
* Connect (3.7.123.1)
	* Remove unused InvalidParameterException from CreateParticipant API
* ECS (3.7.108.0)
	* Documentation update for new error type NamespaceNotFoundException for CreateCluster and UpdateCluster
* NetworkFirewall (3.7.107.0)
	* This release adds support for the Suricata REJECT option in midstream exception configurations.
* OpenSearchService (3.7.106.0)
	* DescribeDomainNodes: A new API that provides configuration information for nodes part of the domain
* QuickSight (3.7.108.0)
	* Add support for Topic, Dataset parameters and VPC
* Rekognition (3.7.106.0)
	* This release adds a new attribute FaceOccluded. Additionally, you can now select attributes individually (e.g. ["DEFAULT", "FACE_OCCLUDED", "AGE_RANGE"] instead of ["ALL"]), which can reduce response time.
* S3 (3.7.104.10)
	* Documentation updates for Amazon S3
* SageMaker (3.7.128.0)
	* We added support for ml.inf2 and ml.trn1 family of instances on Amazon SageMaker for deploying machine learning (ML) models for Real-time and Asynchronous inference. You can use these instances to achieve high performance at a low cost for generative artificial intelligence (AI) models.
* SecurityHub (3.7.107.0)
	* Add support for Finding History.
* SQS (3.7.101.0)
	* This release enables customers to call SQS using AWS JSON-1.0 protocol.
* Core 3.7.106.32
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.539.0 (2023-05-03 18:30 UTC)
* AppSync (3.7.104.0)
	* Private API support for AWS AppSync. With Private APIs, you can now create GraphQL APIs that can only be accessed from your Amazon Virtual Private Cloud ("VPC").
* EC2 (3.7.133.0)
	* Adds an SDK paginator for GetNetworkInsightsAccessScopeAnalysisFindings
* Inspector2 (3.7.103.0)
	* This feature provides deep inspection for linux based instance
* IoTTwinMaker (3.7.104.0)
	* This release adds a field for GetScene API to return error code and message from dependency services.
* NetworkFirewall (3.7.106.0)
	* AWS Network Firewall now supports policy level HOME_NET variable overrides.
* OpenSearchService (3.7.105.0)
	* Amazon OpenSearch Service adds the option to deploy a domain across multiple Availability Zones, with each AZ containing a complete copy of data and with nodes in one AZ acting as a standby. This option provides 99.99% availability and consistent performance in the event of infrastructure failure.
* WellArchitected (3.7.103.0)
	* This release deepens integration with AWS Service Catalog AppRegistry to improve workload resource discovery.

### 3.7.538.0 (2023-05-02 18:24 UTC)
* Appflow (3.7.110.0)
	* This release adds new API to cancel flow executions.
* Connect (3.7.123.0)
	* Amazon Connect Service Rules API update: Added OnContactEvaluationSubmit event source to support user configuring evaluation form rules.
* ECS (3.7.107.9)
	* Documentation only update to address Amazon ECS tickets.
* Kendra (3.7.104.0)
	* AWS Kendra now supports configuring document fields/attributes via the GetQuerySuggestions API. You can now base query suggestions on the contents of document fields.
* ResilienceHub (3.7.103.0)
	* This release will improve resource level transparency in applications by discovering previously hidden resources.
* SageMaker (3.7.127.0)
	* Amazon Sagemaker Autopilot supports training models with sample weights and additional objective metrics.
* Core 3.7.106.31
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.537.0 (2023-05-01 18:22 UTC)
* ComputeOptimizer (3.7.105.0)
	* support for tag filtering within compute optimizer. ability to filter recommendation results by tag and tag key value pairs. ability to filter by inferred workload type added.
* KeyManagementService (3.7.102.0)
	* This release makes the NitroEnclave request parameter Recipient and the response field for CiphertextForRecipient available in AWS SDKs. It also adds the regex pattern for CloudHsmClusterId validation.
* Core 3.7.106.30
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.536.0 (2023-04-28 21:17 UTC)
* Appflow (3.7.109.0)
	* Adds Jwt Support for Salesforce Credentials.
* Athena (3.7.107.0)
	* You can now use capacity reservations on Amazon Athena to run SQL queries on fully-managed compute capacity.
* DirectConnect (3.7.100.122)
	* This release corrects the jumbo frames MTU from 9100 to 8500.
* ElasticFileSystem (3.7.102.0)
	* This release adds PAUSED and PAUSING state as a returned value for DescribeReplicationConfigurations response.
* IoT (3.7.108.0)
	* This release allows AWS IoT Core users to specify a TLS security policy when creating and updating AWS IoT Domain Configurations.
* ManagedGrafana (3.7.103.0)
	* This release adds support for the grafanaVersion parameter in CreateWorkspace.
* Rekognition (3.7.105.0)
	* Added support for aggregating moderation labels by video segment timestamps for Stored Video Content Moderation APIs and added additional information about the job to all Stored Video Get API responses.
* SimSpaceWeaver (3.7.101.0)
	* Added a new CreateSnapshot API. For the StartSimulation API, SchemaS3Location is now optional, added a new SnapshotS3Location parameter. For the DescribeSimulation API, added SNAPSHOT_IN_PROGRESS simulation state, deprecated SchemaError, added new fields: StartError and SnapshotS3Location.
* WAFV2 (3.7.108.0)
	* You can now associate a web ACL with a Verified Access instance.
* WorkSpaces (3.7.104.102)
	* Added Windows 11 to support Microsoft_Office_2019
* Core 3.7.106.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.535.0 (2023-04-27 18:29 UTC)
* EC2 (3.7.132.0)
	* This release adds support for AMD SEV-SNP on EC2 instances.
* EMRContainers (3.7.103.0)
	* This release adds GetManagedEndpointSessionCredentials, a new API that allows customers to generate an auth token to connect to a managed endpoint, enabling features such as self-hosted Jupyter notebooks for EMR on EKS.
* GuardDuty (3.7.105.0)
	* Added API support to initiate on-demand malware scan on specific resources.
* IoTDeviceAdvisor (3.7.102.0)
	* AWS IoT Core Device Advisor now supports MQTT over WebSocket. With this update, customers can run all three test suites of AWS IoT Core Device Advisor - qualification, custom, and long duration tests - using Signature Version 4 for MQTT over WebSocket.
* Kafka (3.7.103.0)
	* Amazon MSK has added new APIs that allows multi-VPC private connectivity and cluster policy support for Amazon MSK clusters that simplify connectivity and access between your Apache Kafka clients hosted in different VPCs and AWS accounts and your Amazon MSK clusters.
* Lambda (3.7.109.0)
	* Add Java 17 (java17) support to AWS Lambda
* MarketplaceCatalog (3.7.103.0)
	* Enabled Pagination for List Entities and List Change Sets operations
* OSIS (3.7.100.1)
	* Documentation updates for OpenSearch Ingestion
* QLDB (3.7.100.121)
	* Documentation updates for Amazon QLDB
* SageMaker (3.7.126.0)
	* Added ml.p4d.24xlarge and ml.p4de.24xlarge as supported instances for SageMaker Studio
* XRay (3.7.102.102)
	* Updated X-Ray documentation with Resource Policy API descriptions.
* Core 3.7.106.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.534.0 (2023-04-26 18:21 UTC)
* OSIS (3.7.100.0)
	* Initial release for OpenSearch Ingestion
* Core 3.7.106.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.533.0 (2023-04-25 18:23 UTC)
* ChimeSDKMessaging (3.7.103.0)
	* Remove non actionable field from UpdateChannelReadMarker and DeleteChannelRequest.  Add precise exceptions to DeleteChannel and DeleteStreamingConfigurations error cases.
* Connect (3.7.122.0)
	* Amazon Connect, Contact Lens Evaluation API release including ability to manage forms and to submit contact evaluations.
* DataSync (3.7.105.0)
	* This release adds 13 new APIs to support AWS DataSync Discovery GA.
* DirectoryService (3.7.101.0)
	* New field added in AWS Managed Microsoft AD DescribeSettings response and regex pattern update for UpdateSettings value.  Added length validation to RemoteDomainName.
* Pinpoint (3.7.101.0)
	* Adds support for journey runs and querying journey execution metrics based on journey runs. Adds execution metrics to campaign activities. Updates docs for Advanced Quiet Time.
* Core 3.7.106.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.532.0 (2023-04-25 06:03 UTC)
* Appflow (3.7.108.0)
	* Increased the max length for RefreshToken and AuthCode from 2048 to 4096.
* CodeCatalyst (3.7.101.36)
	* Documentation updates for Amazon CodeCatalyst.
* EC2 (3.7.131.0)
	* API changes to AWS Verified Access related to identity providers' information.
* MediaConvert (3.7.110.0)
	* This release introduces a noise reduction pre-filter, linear interpolation deinterlace mode, video pass-through, updated default job settings, and expanded LC-AAC Stereo audio bitrate ranges.
* Rekognition (3.7.104.0)
	* Added new status result to Liveness session status.
* Core 3.7.106.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.531.0 (2023-04-21 19:21 UTC)
* Connect (3.7.121.0)
	* This release adds a new API CreateParticipant. For Amazon Connect Chat, you can use this new API to customize chat flow experiences.
* ECS (3.7.107.2)
	* Documentation update to address various Amazon ECS tickets.
* FMS (3.7.104.0)
	* AWS Firewall Manager adds support for multiple administrators. You can now delegate more than one administrator per organization.
* Core 3.7.106.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.530.0 (2023-04-21 00:01 UTC)
* Chime (3.7.101.0)
	* Adds support for Hindi and Thai languages and additional Amazon Transcribe parameters to the StartMeetingTranscription API.
* ChimeSDKMediaPipelines (3.7.102.0)
	* This release adds support for specifying the recording file format in an S3 recording sink configuration.
* ChimeSDKMeetings (3.7.101.0)
	* Adds support for Hindi and Thai languages and additional Amazon Transcribe parameters to the StartMeetingTranscription API.
* GameLift (3.7.103.0)
	* Amazon GameLift supports creating Builds for Windows 2016 operating system.
* GuardDuty (3.7.104.0)
	* This release adds support for the new Lambda Protection feature.
* IoT (3.7.107.0)
	* Support additional OTA states in GetOTAUpdate API
* SageMaker (3.7.125.0)
	* Amazon SageMaker Canvas adds ModelRegisterSettings support for CanvasAppSettings.
* Snowball (3.7.102.0)
	* Adds support for Amazon S3 compatible storage. AWS Snow Family customers can now use Amazon S3 compatible storage on Snowball Edge devices. Also adds support for V3_5S. This is a refreshed AWS Snowball Edge Storage Optimized device type with 210TB SSD (customer usable).
* WAFV2 (3.7.107.0)
	* You can now create encrypted API keys to use in a client application integration of the JavaScript CAPTCHA API . You can also retrieve a list of your API keys and the JavaScript application integration URL.
* Core 3.7.106.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.529.0 (2023-04-19 18:27 UTC)
* Comprehend (3.7.104.0)
	* This release supports native document models for custom classification, in addition to plain-text models. You train native document models using documents (PDF, Word, images) in their native format.
* ECS (3.7.107.0)
	* This release supports the Account Setting "TagResourceAuthorization" that allows for enhanced Tagging security controls.
* RAM (3.7.102.0)
	* This release adds support for customer managed permissions. Customer managed permissions enable customers to author and manage tailored permissions for resources shared using RAM.
* RDS (3.7.117.2)
	* Adds support for the ImageId parameter of CreateCustomDBEngineVersion to RDS Custom for Oracle
* S3 (3.7.104.0)
	* Provides support for "Snow" Storage class.
* S3Control (3.7.109.0)
	* Provides support for overriding endpoint when region is "snow". This will enable bucket APIs for Amazon S3 Compatible storage on Snow Family devices.
* SecretsManager (3.7.102.27)
	* Documentation updates for Secrets Manager
* SecurityHub (3.7.106.16)
	* Update that adds SDK code examples for Security Hub
* Core 3.7.106.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.528.0 (2023-04-17 18:26 UTC)
* Appflow (3.7.107.0)
	* This release adds a Client Token parameter to the following AppFlow APIs: Create/Update Connector Profile, Create/Update Flow, Start Flow, Register Connector, Update Connector Registration. The Client Token parameter allows idempotent operations for these APIs.
* Drs (3.7.104.0)
	* Changed existing APIs and added new APIs to support using an account-level launch configuration template with AWS Elastic Disaster Recovery.
* DynamoDBv2 (3.7.102.28)
	* Documentation updates for DynamoDB API
* EMRServerless (3.7.104.0)
	* The GetJobRun API has been updated to include the job's billed resource utilization. This utilization shows the aggregate vCPU, memory and storage that AWS has billed for the job run. The billed resources include a 1-minute minimum usage for workers, plus additional storage over 20 GB per worker.
* InternetMonitor (3.7.102.0)
	* This release includes a new configurable value, TrafficPercentageToMonitor, which allows users to adjust the amount of traffic monitored by percentage
* IoTWireless (3.7.104.0)
	* Supports the new feature of LoRaWAN roaming, allows to configure MaxEirp for LoRaWAN gateway, and allows to configure PingSlotPeriod for LoRaWAN multicast group
* Lambda (3.7.108.0)
	* Add Python 3.10 (python3.10) support to AWS Lambda
* Core 3.7.106.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.527.0 (2023-04-14 18:23 UTC)
* ECS (3.7.106.4)
	* This release supports  ephemeral storage for AWS Fargate Windows containers.
* Lambda (3.7.107.0)
	* This release adds SnapStart related exceptions to InvokeWithResponseStream API. IAM access related documentation is also added for this API.
* MigrationHubRefactorSpaces (3.7.102.42)
	* Doc only update for Refactor Spaces environments without network bridge feature.
* RDS (3.7.117.0)
	* This release adds support of modifying the engine mode of database clusters.
* Core 3.7.106.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.526.0 (2023-04-13 18:21 UTC)
* ChimeSDKVoice (3.7.104.0)
	* This release adds tagging support for Voice Connectors and SIP Media Applications
* MediaConnect (3.7.101.0)
	* Gateway is a new feature of AWS Elemental MediaConnect. Gateway allows the deployment of on-premises resources for the purpose of transporting live video to and from the AWS Cloud.
* Core 3.7.106.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.525.0 (2023-04-12 18:22 UTC)
* GroundStation (3.7.104.0)
	* AWS Ground Station Wideband DigIF GA Release
* ManagedBlockchain (3.7.101.30)
	* Removal of the Ropsten network. The Ethereum foundation ceased support of Ropsten on December 31st, 2022..
* Core 3.7.106.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.524.0 (2023-04-11 19:30 UTC)
* ECRPublic (3.7.102.0)
	* This release will allow using registry alias as registryId in BatchDeleteImage request.
* EMRServerless (3.7.103.0)
	* This release extends GetJobRun API to return job run timeout (executionTimeoutMinutes) specified during StartJobRun call (or default timeout of 720 minutes if none was specified).
* EventBridge (3.7.102.0)
	* EventBridge PutTarget support for multiple SQL arguments on RedshiftDataParameters
* IoT (3.7.106.0)
	* Re-release to remove unexpected API changes
* IotData (3.7.103.0)
	* This release adds support for MQTT5 user properties when calling the AWS IoT GetRetainedMessage API
* WAFV2 (3.7.106.0)
	* For web ACLs that protect CloudFront protections, the default request body inspection size is now 16 KB, and you can use the new association configuration to increase the inspection size further, up to 64 KB. Sizes over 16 KB can incur additional costs.
* Core 3.7.106.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.523.0 (2023-04-10 18:25 UTC)
* Connect (3.7.120.0)
	* This release adds the ability to configure an agent's routing profile to receive contacts from multiple channels at the same time via extending the UpdateRoutingProfileConcurrency, CreateRoutingProfile and DescribeRoutingProfile APIs.
* ECS (3.7.106.0)
	* This release adds support for enabling FIPS compliance on Amazon ECS Fargate tasks
* MarketplaceCatalog (3.7.102.0)
	* Added three new APIs to support resource sharing: GetResourcePolicy, PutResourcePolicy, and DeleteResourcePolicy. Added new OwnershipType field to ListEntities request to let users filter on entities that are shared with them. Increased max page size of ListEntities response from 20 to 50 results.
* MediaConvert (3.7.109.0)
	* AWS Elemental MediaConvert SDK now supports conversion of 608 paint-on captions to pop-on captions for SCC sources.
* Omics (3.7.102.0)
	* Remove unexpected API changes.
* Rekognition (3.7.103.0)
	* This release adds support for Face Liveness APIs in Amazon Rekognition. Updates UpdateStreamProcessor to return ResourceInUseException Exception. Minor updates to API documentation.
* Core 3.7.106.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.522.0 (2023-04-07 18:26 UTC)
* DLM (3.7.102.0)
	* Updated timestamp format for GetLifecyclePolicy API
* DocDB (3.7.101.0)
	* This release adds a new parameter 'DBClusterParameterGroupName' to 'RestoreDBClusterFromSnapshot' API to associate the name of the DB cluster parameter group while performing restore.
* FSx (3.7.102.65)
	* Amazon FSx for Lustre now supports creating data repository associations on Persistent_1 and Scratch_2 file systems.
* Lambda (3.7.106.0)
	* This release adds a new Lambda InvokeWithResponseStream API to support streaming Lambda function responses. The release also adds a new InvokeMode parameter to Function Url APIs to control whether the response will be streamed or buffered.
* QuickSight (3.7.107.0)
	* This release has two changes: adding the OR condition to tag-based RLS rules in CreateDataSet and UpdateDataSet; adding RefreshSchedule and Incremental RefreshProperties operations for users to programmatically configure SPICE dataset ingestions.
* RedshiftDataAPIService (3.7.102.22)
	* Update documentation of API descriptions as needed in support of temporary credentials with IAM identity.
* ServiceCatalog (3.7.103.3)
	* Updates description for property

### 3.7.521.1 (2023-04-07 14:00 UTC)
* Core 3.7.106.15
	* Fixed issue with .NET Core 3.1 not using the same HttpClient cache across OS platforms.
	* All services packages updated to require new Core

### 3.7.521.0 (2023-04-06 18:24 UTC)
* CloudFormation (3.7.105.0)
	* Including UPDATE_COMPLETE as a failed status for DeleteStack waiter.
* GreengrassV2 (3.7.103.0)
	* Add support for SUCCEEDED value in coreDeviceExecutionStatus field. Documentation updates for Greengrass V2.
* Proton (3.7.105.0)
	* This release adds support for the AWS Proton service sync feature. Service sync enables managing an AWS Proton service (creating and updating instances) and all of it's corresponding service instances from a Git repository.
* RDS (3.7.116.6)
	* Adds and updates the SDK examples
* Core 3.7.106.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.520.0 (2023-04-05 18:25 UTC)
* AppRunner (3.7.105.0)
	* App Runner adds support for seven new vCPU and memory configurations.
* ConfigService (3.7.103.0)
	* This release adds resourceType enums for types released in March 2023.
* ECS (3.7.105.27)
	* This is a document only updated to add information about Amazon Elastic Inference (EI).
* IdentityStore (3.7.100.106)
	* Documentation updates for Identity Store CLI command reference.
* IVSRealTime (3.7.101.0)
	* Fix ParticipantToken ExpirationTime format
* NetworkFirewall (3.7.105.0)
	* AWS Network Firewall now supports IPv6-only subnets.
* ServiceCatalog (3.7.103.0)
	* removed incorrect product type value
* VPCLattice (3.7.100.4)
	* This release removes the entities in the API doc model package for auth policies.
* Core 3.7.106.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.519.0 (2023-04-04 18:27 UTC)
* AmplifyUIBuilder (3.7.101.0)
	* Support StorageField and custom displays for data-bound options in form builder. Support non-string operands for predicates in collections. Support choosing client to get token from.
* AutoScaling (3.7.104.3)
	* Documentation updates for Amazon EC2 Auto Scaling
* DataExchange (3.7.103.0)
	* This release updates the value of MaxResults.
* EC2 (3.7.130.0)
	* C6in, M6in, M6idn, R6in and R6idn bare metal instances are powered by 3rd Generation Intel Xeon Scalable processors and offer up to 200 Gbps of network bandwidth.
* ElasticInference (3.7.101.0)
	* Updated public documentation for the Describe and Tagging APIs.
* SageMaker (3.7.124.0)
	* Amazon SageMaker Asynchronous Inference now allows customer's to receive failure model responses in S3 and receive success/failure model responses in SNS notifications.
* SageMakerRuntime (3.7.102.0)
	* Amazon SageMaker Asynchronous Inference now provides customers a FailureLocation as a response parameter in InvokeEndpointAsync API to capture the model failure responses.
* WAFV2 (3.7.105.0)
	* This release rolls back association config feature for webACLs that protect CloudFront protections.
* Core 3.7.106.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.518.0 (2023-04-03 18:22 UTC)
* Glue (3.7.111.0)
	* Add support for database-level federation
* LakeFormation (3.7.104.0)
	* Add support for database-level federation
* LicenseManager (3.7.102.0)
	* This release adds grant override options to the CreateGrantVersion API. These options can be used to specify grant replacement behavior during grant activation.
* MWAA (3.7.101.0)
	* This Amazon MWAA release adds the ability to customize the Apache Airflow environment by launching a shell script at startup. This shell script is hosted in your environment's Amazon S3 bucket. Amazon MWAA runs the script before installing requirements and initializing the Apache Airflow process.
* ServiceCatalog (3.7.102.0)
	* This release introduces Service Catalog support for Terraform open source. It enables 1. The notify* APIs to Service Catalog. These APIs are used by the terraform engine to notify the result of the provisioning engine execution. 2. Adds a new TERRAFORM_OPEN_SOURCE product type in CreateProduct API.
* WAFV2 (3.7.104.0)
	* For web ACLs that protect CloudFront protections, the default request body inspection size is now 16 KB, and you can use the new association configuration to increase the inspection size further, up to 64 KB. Sizes over 16 KB can incur additional costs.
* Core 3.7.106.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.517.0 (2023-03-31 18:25 UTC)
* EC2 (3.7.129.1)
	* Documentation updates for EC2 On Demand Capacity Reservations
* InternetMonitor (3.7.101.0)
	* This release adds a new feature for Amazon CloudWatch Internet Monitor that enables customers to deliver internet measurements to Amazon S3 buckets as well as CloudWatch Logs.
* ResilienceHub (3.7.102.6)
	* Adding EKS related documentation for appTemplateBody
* S3 (3.7.103.40)
	* Documentation updates for Amazon S3
* SageMakerFeatureStoreRuntime (3.7.102.0)
	* In this release, you can now chose between soft delete and hard delete when calling the DeleteRecord API, so you have more flexibility when it comes to managing online store data.
* ServerMigrationService (3.7.101.0)
	* Deprecating AWS Server Migration Service.
* Core 3.7.106.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.516.0 (2023-03-30 18:33 UTC)
* Athena (3.7.106.0)
	* Make DefaultExecutorDpuSize and CoordinatorDpuSize  fields optional  in StartSession
* AutoScaling (3.7.104.0)
	* Amazon EC2 Auto Scaling now supports Elastic Load Balancing traffic sources with the AttachTrafficSources, DetachTrafficSources, and DescribeTrafficSources APIs. This release also introduces a new activity status, "WaitingForConnectionDraining", for VPC Lattice to the DescribeScalingActivities API.
* Batch (3.7.104.0)
	* This feature allows Batch on EKS to support configuration of Pod Labels through Metadata for Batch on EKS Jobs.
* ComputeOptimizer (3.7.104.0)
	* This release adds support for HDD EBS volume types and io2 Block Express. We are also adding support for 61 new instance types and instances that have non consecutive runtime.
* Drs (3.7.103.0)
	* Adding a field to the replication configuration APIs to support the auto replicate new disks feature. We also deprecated RetryDataReplication.
* EC2 (3.7.129.0)
	* This release adds support for Tunnel Endpoint Lifecycle control, a new feature that provides Site-to-Site VPN customers with better visibility and control of their VPN tunnel maintenance updates.
* ElasticMapReduce (3.7.103.0)
	* Updated DescribeCluster and ListClusters API responses to include ErrorDetail that specifies error code, programmatically accessible error data,and an error message. ErrorDetail provides the underlying reason for cluster failure and recommends actions to simplify troubleshooting of EMR clusters.
* Glue (3.7.110.0)
	* This release adds support for AWS Glue Data Quality, which helps you evaluate and monitor the quality of your data and includes the API for creating, deleting, or updating data quality rulesets, runs and evaluations.
* GuardDuty (3.7.103.0)
	* Added EKS Runtime Monitoring feature support to existing detector, finding APIs and introducing new Coverage APIs
* Imagebuilder (3.7.103.0)
	* Adds support for new image workflow details and image vulnerability detection.
* IVS (3.7.102.0)
	* Amazon Interactive Video Service (IVS) now offers customers the ability to configure IVS channels to allow insecure RTMP ingest.
* Kendra (3.7.103.0)
	* AWS Kendra now supports featured results for a query.
* NetworkFirewall (3.7.104.0)
	* AWS Network Firewall added TLS inspection configurations to allow TLS traffic inspection.
* SageMakerGeospatial (3.7.101.0)
	* Amazon SageMaker geospatial capabilities now supports server-side encryption with customer managed KMS key and SageMaker notebooks with a SageMaker geospatial image in a Amazon SageMaker Domain with VPC only mode.
* VPCLattice (3.7.100.0)
	* General Availability (GA) release of Amazon VPC Lattice
* WellArchitected (3.7.102.0)
	* AWS Well-Architected SDK now supports getting consolidated report metrics and generating a consolidated report PDF.
* Core 3.7.106.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.515.0 (2023-03-29 18:21 UTC)
* OpenSearchServerless (3.7.101.0)
	* This release includes two new exception types "ServiceQuotaExceededException" and "OcuLimitExceededException".
* RDS (3.7.116.0)
	* Add support for creating a read replica DB instance from a Multi-AZ DB cluster.
* Core 3.7.106.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.514.0 (2023-03-28 18:20 UTC)
* IotData (3.7.102.0)
	* Add endpoint ruleset support for cn-north-1.
* SSMContacts (3.7.101.0)
	* This release adds 12 new APIs as part of Oncall Schedule feature release, adds support for a new contact type: ONCALL_SCHEDULE. Check public documentation for AWS ssm-contacts for more information
* SSMIncidents (3.7.104.0)
	* Increased maximum length of "TriggerDetails.rawData" to 10K characters and "IncidentSummary" to 8K characters.
* Core 3.7.106.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.513.0 (2023-03-27 18:28 UTC)
* AppRegistry (3.7.102.0)
	* In this release, we started supporting ARN in applicationSpecifier and attributeGroupSpecifier. GetAttributeGroup, ListAttributeGroups and ListAttributeGroupsForApplication APIs will now have CreatedBy field in the response.
* Athena (3.7.105.0)
	* Enforces a minimal level of encryption for the workgroup for query and calculation results that are written to Amazon S3. When enabled, workgroup users can set encryption only to the minimum level set by the administrator or higher when they submit queries.
* ChimeSDKVoice (3.7.103.0)
	* Documentation updates for Amazon Chime SDK Voice.
* Connect (3.7.119.0)
	* This release introduces support for RelatedContactId in the StartChatContact API. Interactive message and interactive message response have been added to the list of supported message content types for this API as well.
* ConnectParticipant (3.7.104.37)
	* This release provides an update to the SendMessage API to handle interactive message response content-types.
* IoTWireless (3.7.103.0)
	* Introducing new APIs that enable Sidewalk devices to communicate with AWS IoT Core through Sidewalk gateways. This will empower AWS customers to connect Sidewalk devices with other AWS IoT Services, creating  possibilities for seamless integration and advanced device management.
* MediaLive (3.7.106.0)
	* AWS Elemental MediaLive now supports ID3 tag insertion for audio only HLS output groups. AWS Elemental Link devices now support tagging.
* SageMaker (3.7.123.2)
	* Fixed some improperly rendered links in SDK documentation.
* SecurityHub (3.7.106.0)
	* Added new resource detail objects to ASFF, including resources for AwsEksCluster, AWSS3Bucket, AwsEc2RouteTable and AwsEC2Instance.
* VoiceID (3.7.101.0)
	* Amazon Connect Voice ID now supports multiple fraudster watchlists. Every domain has a default watchlist where all existing fraudsters are placed by default. Custom watchlists may now be created, managed, and evaluated against for known fraudster detection.

### 3.7.512.0 (2023-03-24 18:21 UTC)
* CloudWatch (3.7.103.43)
	* Doc-only update to correct alarm actions list
* Comprehend (3.7.103.0)
	* This release adds a new field (FlywheelArn) to the EntitiesDetectionJobProperties object. The FlywheelArn field is returned in the DescribeEntitiesDetectionJob and ListEntitiesDetectionJobs responses when the EntitiesDetection job is started with a FlywheelArn instead of an EntityRecognizerArn .
* RDS (3.7.115.0)
	* Added error code CreateCustomDBEngineVersionFault for when the create custom engine version for Custom engines fails.
* Core 3.7.106.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.511.0 (2023-03-23 18:27 UTC)
* Batch (3.7.103.0)
	* This feature allows Batch to support configuration of ephemeral storage size for jobs running on FARGATE
* ChimeSDKIdentity (3.7.101.0)
	* AppInstanceBots can be used to add a bot powered by Amazon Lex to chat channels.  ExpirationSettings provides automatic resource deletion for AppInstanceUsers.
* ChimeSDKMediaPipelines (3.7.101.0)
	* This release adds Amazon Chime SDK call analytics. Call analytics include voice analytics, which provides speaker search and voice tone analysis. These capabilities can be used with Amazon Transcribe and Transcribe Call Analytics to generate machine-learning-powered insights from real-time audio.
* ChimeSDKMessaging (3.7.102.0)
	* ExpirationSettings provides automatic resource deletion for Channels.
* ChimeSDKVoice (3.7.102.0)
	* This release adds Amazon Chime SDK call analytics. Call analytics include voice analytics, which provides speaker search and voice tone analysis. These capabilities can be used with Amazon Transcribe and Transcribe Call Analytics to generate machine-learning-powered insights from real-time audio.
* CodeArtifact (3.7.104.0)
	* Repository CreationTime is added to the CreateRepository and ListRepositories API responses.
* GuardDuty (3.7.102.0)
	* Adds AutoEnableOrganizationMembers attribute to DescribeOrganizationConfiguration and UpdateOrganizationConfiguration APIs.
* IVSRealTime (3.7.100.0)
	* Initial release of the Amazon Interactive Video Service RealTime API.
* MediaConvert (3.7.108.0)
	* AWS Elemental MediaConvert SDK now supports passthrough of ID3v2 tags for audio inputs to audio-only HLS outputs.
* SageMaker (3.7.123.0)
	* Amazon SageMaker Autopilot adds two new APIs - CreateAutoMLJobV2 and DescribeAutoMLJobV2. Amazon SageMaker Notebook Instances now supports the ml.geospatial.interactive instance type.
* ServiceDiscovery (3.7.102.0)
	* Reverted the throttling exception RequestLimitExceeded for AWS Cloud Map APIs introduced in SDK version 1.12.424 2023-03-09 to previous exception specified in the ErrorCode.
* Textract (3.7.105.0)
	* The AnalyzeDocument - Tables feature adds support for new elements in the API: table titles, footers, section titles, summary cells/tables, and table type.
* Core 3.7.106.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.510.0 (2023-03-22 18:24 UTC)
* IdentityManagement (3.7.100.98)
	* Documentation updates for AWS Identity and Access Management (IAM).
* IoTTwinMaker (3.7.103.0)
	* This release adds support of adding metadata when creating a new scene or updating an existing scene.
* NetworkManager (3.7.101.61)
	* This release includes an update to create-transit-gateway-route-table-attachment, showing example usage for TransitGatewayRouteTableArn.
* Pipes (3.7.102.0)
	* This release improves validation on the ARNs in the API model
* ResilienceHub (3.7.102.0)
	* This release provides customers with the ability to import resources from within an EKS cluster and assess the resiliency of EKS cluster workloads.
* SimpleSystemsManagement (3.7.104.0)
	* This Patch Manager release supports creating, updating, and deleting Patch Baselines for AmazonLinux2023, AlmaLinux.
* Core 3.7.106.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.509.0 (2023-03-21 18:24 UTC)
* ChimeSDKMessaging (3.7.101.0)
	* Amazon Chime SDK messaging customers can now manage streaming configuration for messaging data for archival and analysis.
* CleanRooms (3.7.101.0)
	* GA Release of AWS Clean Rooms, Added Tagging Functionality
* EC2 (3.7.128.0)
	* This release adds support for AWS Network Firewall, AWS PrivateLink, and Gateway Load Balancers to Amazon VPC Reachability Analyzer, and it makes the path destination optional as long as a destination address in the filter at source is provided.
* IoTSiteWise (3.7.102.0)
	* Provide support for tagging of data streams and enabling tag based authorization for property alias
* Mgn (3.7.102.0)
	* This release introduces the Import and export feature and expansion of the post-launch actions
* Core 3.7.106.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.508.0 (2023-03-20 18:22 UTC)
* ApplicationAutoScaling (3.7.104.0)
	* With this release customers can now tag their Application Auto Scaling registered targets with key-value pairs and manage IAM permissions for all the tagged resources centrally.
* Neptune (3.7.102.0)
	* This release makes following few changes. db-cluster-identifier is now a required parameter of create-db-instance. describe-db-cluster will now return PendingModifiedValues and GlobalClusterIdentifier fields in the response.
* S3Outposts (3.7.102.0)
	* S3 On Outposts added support for endpoint status, and a failed endpoint reason, if any
* WorkDocs (3.7.102.0)
	* This release adds a new API, SearchResources, which enable users to search through metadata and content of folders, documents, document versions and comments in a WorkDocs site.
* Core 3.7.106.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.507.0 (2023-03-17 18:22 UTC)
* BillingConductor (3.7.105.0)
	* This release adds a new filter to ListAccountAssociations API and a new filter to ListBillingGroups API.
* ConfigService (3.7.102.0)
	* This release adds resourceType enums for types released from October 2022 through February 2023.
* DatabaseMigrationService (3.7.103.0)
	* S3 setting to create AWS Glue Data Catalog. Oracle setting to control conversion of timestamp column. Support for Kafka SASL Plain authentication. Setting to map boolean from PostgreSQL to Redshift. SQL Server settings to force lob lookup on inline LOBs and to control access of database logs.
* Core 3.7.106.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.506.0 (2023-03-17 13:51 UTC)
* Core 3.7.106.0
	* Align the default of HttpClientCacheSize to 1 across all the platforms; Configure ECSTaskCredentials to refresh 5 minutes before expiration time
	* All services packages updated to require new Core

### 3.7.505.0 (2023-03-16 18:22 UTC)
* GuardDuty (3.7.101.0)
	* Updated 9 APIs for feature enablement to reflect expansion of GuardDuty to features. Added new APIs and updated existing APIs to support RDS Protection GA.
* ResourceExplorer2 (3.7.101.51)
	* Documentation updates for APIs.
* SageMakerRuntime (3.7.101.30)
	* Documentation updates for SageMaker Runtime
* Core 3.7.105.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.504.0 (2023-03-15 18:21 UTC)
* MigrationHubStrategyRecommendations (3.7.103.0)
	* This release adds the binary analysis that analyzes IIS application DLLs on Windows and Java applications on Linux to provide anti-pattern report without configuring access to the source code.
* S3Control (3.7.108.0)
	* Added support for S3 Object Lambda aliases.
* SecurityLake (3.7.102.0)
	* Make Create/Get/ListSubscribers APIs return resource share ARN and name so they can be used to validate the RAM resource share to accept. GetDatalake can be used to track status of UpdateDatalake and DeleteDatalake requests.
* Core 3.7.105.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.503.0 (2023-03-14 18:29 UTC)
* ApplicationAutoScaling (3.7.103.0)
	* Application Auto Scaling customers can now use mathematical functions to customize the metric used with Target Tracking policies within the policy configuration itself, saving the cost and effort of publishing the customizations as a separate metric.
* DataExchange (3.7.102.0)
	* This release enables data providers to license direct access to S3 objects encrypted with Customer Managed Keys (CMK) in AWS KMS through AWS Data Exchange. Subscribers can use these keys to decrypt, then use the encrypted S3 objects shared with them, without creating or managing copies.
* DirectConnect (3.7.100.90)
	* describe-direct-connect-gateway-associations includes a new status, updating, indicating that the association is currently in-process of updating.
* EC2 (3.7.127.0)
	* This release adds a new DnsOptions key (PrivateDnsOnlyForInboundResolverEndpoint) to CreateVpcEndpoint and ModifyVpcEndpoint APIs.
* IdentityManagement (3.7.100.91)
	* Documentation only updates to correct customer-reported issues
* Keyspaces (3.7.102.0)
	* Adding support for client-side timestamps
* Core 3.7.105.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.502.0 (2023-03-13 18:23 UTC)
* AppIntegrationsService (3.7.101.0)
	* Adds FileConfiguration to Amazon AppIntegrations CreateDataIntegration supporting scheduled downloading of third party files into Amazon Connect from sources such as Microsoft SharePoint.
* ConnectWisdomService (3.7.102.0)
	* This release extends Wisdom CreateKnowledgeBase API to support SharePoint connector type by removing the @required trait for objectField
* LakeFormation (3.7.103.3)
	* This release updates the documentation regarding Get/Update DataCellsFilter
* S3Control (3.7.107.0)
	* Added support for cross-account Multi-Region Access Points. Added support for S3 Replication for S3 on Outposts.
* Tnb (3.7.101.0)
	* This release adds tagging support to the following Network Instance APIs : Instantiate, Update, Terminate.
* Core 3.7.105.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.501.0 (2023-03-10 19:26 UTC)
* Ivschat (3.7.104.0)
	* This release adds a new exception returned when calling AWS IVS chat UpdateLoggingConfiguration. Now UpdateLoggingConfiguration can return ConflictException when invalid updates are made in sequence to Logging Configurations.
* SecretsManager (3.7.102.0)
	* The type definitions of SecretString and SecretBinary now have a minimum length of 1 in the model to match the exception thrown when you pass in empty values.
* Core 3.7.105.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.500.0 (2023-03-09 19:28 UTC)
* CloudWatchEvidently (3.7.102.0)
	* Updated entity override documentation
* CodeArtifact (3.7.103.0)
	* This release introduces the generic package format, a mechanism for storing arbitrary binary assets. It also adds a new API, PublishPackageVersion, to allow for publishing generic packages.
* Connect (3.7.118.0)
	* This release adds a new API, GetMetricDataV2, which returns metric data for Amazon Connect.
* NetworkManager (3.7.101.51)
	* This update provides example usage for TransitGatewayRouteTableArn.
* QuickSight (3.7.106.0)
	* This release has two changes: add state persistence feature for embedded dashboard and console in GenerateEmbedUrlForRegisteredUser API; add properties for hidden collapsed row dimensions in PivotTableOptions.
* RedshiftDataAPIService (3.7.102.0)
	* Added support for Redshift Serverless workgroup-arn wherever the WorkgroupName parameter is available.
* SageMaker (3.7.122.0)
	* Amazon SageMaker Inference now allows SSM access to customer's model container by setting the "EnableSSMAccess" parameter for a ProductionVariant in CreateEndpointConfig API.
* ServiceDiscovery (3.7.101.0)
	* Updated all AWS Cloud Map APIs to provide consistent throttling exception (RequestLimitExceeded)
* SimpleEmailV2 (3.7.102.0)
	* This release introduces a new recommendation in Virtual Deliverability Manager Advisor, which detects missing or misconfigured Brand Indicator for Message Identification (BIMI) DNS records for customer sending identities.
* Core 3.7.105.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.499.0 (2023-03-08 19:27 UTC)
* Athena (3.7.104.0)
	* A new field SubstatementType is added to GetQueryExecution API, so customers have an error free way to detect the query type and interpret the result.
* DynamoDBv2 (3.7.102.0)
	* Adds deletion protection support to DynamoDB tables. Tables with deletion protection enabled cannot be deleted. Deletion protection is disabled by default, can be enabled via the CreateTable or UpdateTable APIs, and is visible in TableDescription. This setting is not replicated for Global Tables.
* EC2 (3.7.126.0)
	* Introducing Amazon EC2 C7g, M7g and R7g instances, powered by the latest generation AWS Graviton3 processors and deliver up to 25% better performance over Graviton2-based instances.
* LakeFormation (3.7.103.0)
	* This release adds two new API support "GetDataCellsFiler" and "UpdateDataCellsFilter", and also updates the corresponding documentation.
* MediaPackage (3.7.101.0)
	* This release provides the date and time live resources were created.
* MediaPackageVod (3.7.103.0)
	* This release provides the date and time VOD resources were created.
* Route53Resolver (3.7.101.0)
	* Add dual-stack and IPv6 support for Route 53 Resolver Endpoint,Add IPv6 target IP in Route 53 Resolver Forwarding Rule
* SageMaker (3.7.121.0)
	* There needs to be a user identity to specify the SageMaker user who perform each action regarding the entity. However, these is a not a unified concept of user identity across SageMaker service that could be used today.
* Core 3.7.105.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.498.0 (2023-03-07 19:21 UTC)
* DatabaseMigrationService (3.7.102.0)
	* This release adds DMS Fleet Advisor Target Recommendation APIs and exposes functionality for DMS Fleet Advisor. It adds functionality to start Target Recommendation calculation.
* LocationService (3.7.102.6)
	* Documentation update for the release of 3 additional map styles for use with Open Data Maps: Open Data Standard Dark, Open Data Visualization Light & Open Data Visualization Dark.
* Core 3.7.105.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.497.0 (2023-03-06 19:17 UTC)
* Account (3.7.102.0)
	* AWS Account alternate contact email addresses can now have a length of 254 characters and contain the character "|".
* IVS (3.7.101.27)
	* Updated text description in DeleteChannel, Stream, and StreamSummary.

### 3.7.496.0 (2023-03-03 19:25 UTC)
* DynamoDBv2 (3.7.101.55)
	* Documentation updates for DynamoDB.
* EC2 (3.7.125.0)
	* This release adds support for a new boot mode for EC2 instances called 'UEFI Preferred'.
* Macie2 (3.7.103.5)
	* Documentation updates for Amazon Macie
* MediaConvert (3.7.107.0)
	* The AWS Elemental MediaConvert SDK has improved handling for different input and output color space combinations.
* MediaLive (3.7.105.0)
	* AWS Elemental MediaLive adds support for Nielsen watermark timezones.
* TranscribeService (3.7.104.0)
	* Amazon Transcribe now supports role access for these API operations: CreateVocabulary, UpdateVocabulary, CreateVocabularyFilter, and UpdateVocabularyFilter.
* Core 3.7.105.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.495.0 (2023-03-02 19:22 UTC)
* IoT (3.7.105.0)
	* A recurring maintenance window is an optional configuration used for rolling out the job document to all devices in the target group observing a predetermined start time, duration, and frequency that the maintenance window occurs.
* MigrationHubStrategyRecommendations (3.7.102.0)
	* This release updates the File Import API to allow importing servers already discovered by customers with reduced pre-requisites.
* Organizations (3.7.102.0)
	* This release introduces a new reason code, ACCOUNT_CREATION_NOT_COMPLETE, to ConstraintViolationException in CreateOrganization API.
* PI (3.7.101.0)
	* This release adds a new field PeriodAlignment to allow the customer specifying the returned timestamp of time periods to be either the start or end time.
* Pipes (3.7.101.0)
	* This release fixes some input parameter range and patterns.
* SageMaker (3.7.120.0)
	* Add a new field "EndpointMetrics" in SageMaker Inference Recommender "ListInferenceRecommendationsJobSteps" API response.
* Core 3.7.105.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.494.1 (2023-03-02 01:40 UTC)
* S3 (3.7.103.19)
	* Fix for S3 UploadPartCopyRequest/CopyPart endpoint resolution

### 3.7.494.0 (2023-03-01 19:22 UTC)
* CodeCatalyst (3.7.101.0)
	* Published Dev Environments StopDevEnvironmentSession API
* Pricing (3.7.101.0)
	* This release adds 2 new APIs - ListPriceLists which returns a list of applicable price lists, and GetPriceListFileUrl which outputs a URL to retrieve your price lists from the generated file from ListPriceLists
* S3Outposts (3.7.101.0)
	* S3 on Outposts introduces a new API ListOutpostsWithS3, with this API you can list all your Outposts with S3 capacity.
* Core 3.7.105.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.493.0 (2023-02-28 19:23 UTC)
* Comprehend (3.7.102.0)
	* Amazon Comprehend now supports flywheels to help you train and manage new model versions for custom models.
* EC2 (3.7.124.0)
	* This release allows IMDS support to be set to v2-only on an existing AMI, so that all future instances launched from that AMI will use IMDSv2 by default.
* KeyManagementService (3.7.101.56)
	* AWS KMS is deprecating the RSAES_PKCS1_V1_5 wrapping algorithm option in the GetParametersForImport API that is used in the AWS KMS Import Key Material feature. AWS KMS will end support for this wrapping algorithm by October 1, 2023.
* Lightsail (3.7.102.0)
	* This release adds Lightsail for Research feature support, such as GUI session access, cost estimates, stop instance on idle, and disk auto mount.
* ManagedBlockchain (3.7.101.0)
	* This release adds support for tagging to the accessor resource in Amazon Managed Blockchain
* Omics (3.7.101.0)
	* Minor model changes to accomodate batch imports feature
* Core 3.7.105.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.492.0 (2023-02-27 19:23 UTC)
* DevOpsGuru (3.7.102.0)
	* This release adds the description field on ListAnomaliesForInsight and DescribeAnomaly API responses for proactive anomalies.
* Drs (3.7.102.0)
	* New fields were added to reflect availability zone data in source server and recovery instance description commands responses, as well as source server launch status.
* InternetMonitor (3.7.100.0)
	* CloudWatch Internet Monitor is a a new service within CloudWatch that will help application developers and network engineers continuously monitor internet performance metrics such as availability and performance between their AWS-hosted applications and end-users of these applications
* Lambda (3.7.105.0)
	* This release adds the ability to create ESMs with Document DB change streams as event source. For more information see  https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html.
* MediaConvert (3.7.106.0)
	* The AWS Elemental MediaConvert SDK has added support for HDR10 to SDR tone mapping, and animated GIF video input sources.
* TimestreamWrite (3.7.101.0)
	* This release adds the ability to ingest batched historical data or migrate data in bulk from S3 into Timestream using CSV files.
* Core 3.7.105.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.491.0 (2023-02-24 19:26 UTC)
* Connect (3.7.117.0)
	* StartTaskContact API now supports linked task creation with a new optional RelatedContactId parameter
* ConnectCases (3.7.102.0)
	* This release adds the ability to delete domains through the DeleteDomain API. For more information see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* Redshift (3.7.101.14)
	* Documentation updates for Redshift API bringing it in line with IAM best practices.
* SecurityHub (3.7.105.0)
	* New Security Hub APIs and updates to existing APIs that help you consolidate control findings and enable and disable controls across all supported standards
* ServiceCatalog (3.7.101.59)
	* Documentation updates for Service Catalog

### 3.7.490.0 (2023-02-23 19:38 UTC)
* Appflow (3.7.106.0)
	* This release enables the customers to choose whether to use Private Link for Metadata and Authorization call when using a private Salesforce connections
* ECS (3.7.105.0)
	* This release supports deleting Amazon ECS task definitions that are in the INACTIVE state.
* GuardDuty (3.7.100.79)
	* Updated API and data types descriptions for CreateFilter, UpdateFilter, and TriggerDetails.
* IoTWireless (3.7.102.0)
	* In this release, we add additional capabilities for the FUOTA which allows user to configure the fragment size, the sending interval and the redundancy ratio of the FUOTA tasks
* LocationService (3.7.102.0)
	* This release adds support for using Maps APIs with an API Key in addition to AWS Cognito. This includes support for adding, listing, updating and deleting API Keys.
* Macie2 (3.7.103.0)
	* This release adds support for a new finding type, Policy:IAMUser/S3BucketSharedWithCloudFront, and S3 bucket metadata that indicates if a bucket is shared with an Amazon CloudFront OAI or OAC.
* ManagedGrafana (3.7.102.4)
	* Doc-only update. Updated information on attached role policies for customer provided roles
* WAFV2 (3.7.103.0)
	* You can now associate an AWS WAF v2 web ACL with an AWS App Runner service.
* Core 3.7.105.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.489.0 (2023-02-22 19:26 UTC)
* ChimeSDKVoice (3.7.101.0)
	* This release introduces support for Voice Connector media metrics in the Amazon Chime SDK Voice namespace
* CloudFront (3.7.105.0)
	* CloudFront now supports block lists in origin request policies so that you can forward all headers, cookies, or query string from viewer requests to the origin *except* for those specified in the block list.
* CloudWatchRUM (3.7.102.0)
	* CloudWatch RUM now supports CloudWatch Custom Metrics
* DataSync (3.7.104.0)
	* AWS DataSync has relaxed the minimum length constraint of AccessKey for Object Storage locations to 1.
* OpenSearchService (3.7.104.0)
	* This release lets customers configure Off-peak window and software update related properties for a new/existing domain. It enhances the capabilities of StartServiceSoftwareUpdate API; adds 2 new APIs - ListScheduledActions & UpdateScheduledAction; and allows Auto-tune to make use of Off-peak window.
* SimpleSystemsManagement (3.7.103.31)
	* Document only update for Feb 2023

### 3.7.488.0 (2023-02-21 20:25 UTC)
* QuickSight (3.7.105.0)
	* S3 data sources now accept a custom IAM role.
* ResilienceHub (3.7.101.0)
	* In this release we improved resilience hub application creation and maintenance by introducing new resource and app component crud APIs, improving visibility and maintenance of application input sources and added support for additional information attributes to be provided by customers.
* SecurityHub (3.7.104.15)
	* Documentation updates for AWS Security Hub
* Tnb (3.7.100.0)
	* This is the initial SDK release for AWS Telco Network Builder (TNB). AWS Telco Network Builder is a network automation service that helps you deploy and manage telecom networks.
* Core 3.7.105.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.487.0 (2023-02-20 19:19 UTC)
* AuditManager (3.7.103.0)
	* This release introduces a ServiceQuotaExceededException to the UpdateAssessmentFrameworkShare API operation.
* Connect (3.7.116.0)
	* Reasons for failed diff has been approved by SDK Reviewer

### 3.7.486.1 (2023-02-18 00:42 UTC)
* DynamoDBv2 (3.7.101.48)
	* Fix: Fix DynamoDBContext.FromDocument conversion for DateTime string without milliseconds with unit tests
* Core 3.7.105.6
	* Fix: Generate new SSO token if refresh token and access token are expired and options.GenerateNewToken is true. Override AuthenticationRegion from ClientConfig if specified.
	* All services packages updated to require new Core

### 3.7.486.0 (2023-02-17 19:20 UTC)
* AppRunner (3.7.104.0)
	* This release supports removing MaxSize limit for AutoScalingConfiguration.
* Glue (3.7.109.0)
	* Release of Delta Lake Data Lake Format for Glue Studio Service
* Core 3.7.105.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.485.0 (2023-02-16 20:41 UTC)
* ElasticMapReduce (3.7.102.0)
	* This release provides customers the ability to define a timeout period for procuring capacity during a resize operation for Instance Fleet clusters. Customers can specify this timeout using the ResizeSpecifications parameter supported by RunJobFlow, ModifyInstanceFleet and AddInstanceFleet APIs.
* IVS (3.7.101.17)
	* Doc-only update. Updated text description in DeleteChannel, Stream, and StreamSummary.
* ManagedGrafana (3.7.102.0)
	* With this release Amazon Managed Grafana now supports inbound Network Access Control that helps you to restrict user access to your Grafana workspaces
* WAFV2 (3.7.102.1)
	* Added a notice for account takeover prevention (ATP). The interface incorrectly lets you to configure ATP response inspection in regional web ACLs in Region US East (N. Virginia), without returning an error. ATP response inspection is only available in web ACLs that protect CloudFront distributions.
* Core 3.7.105.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.484.0 (2023-02-15 20:11 UTC)
* CloudTrail (3.7.104.0)
	* This release adds an InsufficientEncryptionPolicyException type to the StartImport endpoint
* ElasticFileSystem (3.7.101.51)
	* Documentation update for EFS to support IAM best practices.
* FraudDetector (3.7.102.0)
	* This release introduces Lists feature which allows customers to reference a set of values in Fraud Detector's rules. With Lists, customers can dynamically manage these attributes in real time. Lists can be created/deleted and its contents can be modified using the Fraud Detector API.
* Glue (3.7.108.0)
	* Fix DirectJDBCSource not showing up in CLI code gen
* Private5G (3.7.102.0)
	* This release introduces a new StartNetworkResourceUpdate API, which enables return/replacement of hardware from a NetworkSite.
* RDS (3.7.114.22)
	* Database Activity Stream support for RDS for SQL Server.
* WAFV2 (3.7.102.0)
	* For protected CloudFront distributions, you can now use the AWS WAF Fraud Control account takeover prevention (ATP) managed rule group to block new login attempts from clients that have recently submitted too many failed login attempts.
* Core 3.7.105.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.483.0 (2023-02-14 21:28 UTC)
* AppConfig (3.7.102.0)
	* AWS AppConfig now offers the option to set a version label on hosted configuration versions. Version labels allow you to identify specific hosted configuration versions based on an alternate versioning scheme that you define.
* DataSync (3.7.103.0)
	* With this launch, we are giving customers the ability to use older SMB protocol versions, enabling them to use DataSync to copy data to and from their legacy storage arrays.
* EC2 (3.7.123.0)
	* With this release customers can turn host maintenance on or off when allocating or modifying a supported dedicated host. Host maintenance is turned on by default for supported hosts.

### 3.7.482.0 (2023-02-13 19:19 UTC)
* Account (3.7.101.0)
	* This release of the Account Management API enables customers to view and manage whether AWS Opt-In Regions are enabled or disabled for their Account. For more information, see https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html
* AppConfigData (3.7.101.0)
	* AWS AppConfig now offers the option to set a version label on hosted configuration versions. If a labeled hosted configuration version is deployed, its version label is available in the GetLatestConfiguration response.
* Snowball (3.7.101.0)
	* Adds support for EKS Anywhere on Snowball. AWS Snow Family customers can now install EKS Anywhere service on Snowball Edge Compute Optimized devices.
* Core 3.7.105.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.481.0 (2023-02-10 19:22 UTC)
* AutoScaling (3.7.103.0)
	* You can now either terminate/replace, ignore, or wait for EC2 Auto Scaling instances on standby or protected from scale in. Also, you can also roll back changes from a failed instance refresh.
* Connect (3.7.115.0)
	* This update provides the Wisdom session ARN for contacts enabled for Wisdom in the chat channel.
* EC2 (3.7.122.0)
	* Adds support for waiters that automatically poll for an imported snapshot until it reaches the completed state.
* Polly (3.7.106.0)
	* Amazon Polly adds two new neural Japanese voices - Kazuha, Tomoko
* SageMaker (3.7.119.0)
	* Amazon SageMaker Autopilot adds support for selecting algorithms in CreateAutoMLJob API.
* SimpleNotificationService (3.7.101.8)
	* This release adds support for SNS X-Ray active tracing as well as other updates.
* Core 3.7.105.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.480.0 (2023-02-10 01:18 UTC)
* S3 (3.7.103.7)
	* Fixed an issue where ListBucketMetricsConfigurations was not returning any result for existing bucket metrics configurations. Fix issue making S3 metadata be case insensitive.
* Core 3.7.105.0
	* Add support for AWS_CONFIG_FILE. Perform case-insensitive comparison for policy action names. Add missing obsolete message for DoesS3BucketExistAsync. Fix issue with updating credential profiles that are partial configured in both config and credentials file.

### 3.7.479.0 (2023-02-09 19:28 UTC)
* ChimeSDKMeetings (3.7.100.71)
	* Documentation updates for Chime Meetings SDK
* CloudWatchEvidently (3.7.101.0)
	* Updated entity overrides parameter to accept up to 2500 overrides or a total of 40KB.
* EMRContainers (3.7.102.0)
	* EMR on EKS allows configuring retry policies for job runs through the StartJobRun API. Using retry policies, a job cause a driver pod to be restarted automatically if it fails or is deleted. The job's status can be seen in the DescribeJobRun and ListJobRun APIs and monitored using CloudWatch events.
* LexModelsV2 (3.7.102.0)
	* AWS Lex now supports Network of Bots.
* LexRuntimeV2 (3.7.101.0)
	* AWS Lex now supports Network of Bots.
* Lightsail (3.7.101.60)
	* Documentation updates for Lightsail
* MigrationHubRefactorSpaces (3.7.102.0)
	* This release adds support for creating environments with a network fabric type of NONE
* WorkDocs (3.7.101.55)
	* Doc only update for the WorkDocs APIs.
* WorkSpaces (3.7.104.51)
	* Removed Windows Server 2016 BYOL and made changes based on IAM campaign.
* Core 3.7.104.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.478.0 (2023-02-08 19:21 UTC)
* Backup (3.7.102.0)
	* This release added one attribute (resource name) in the output model of our 9 existing APIs in AWS backup so that customers will see the resource name at the output. No input required from Customers.
* CloudFront (3.7.104.0)
	* CloudFront Origin Access Control extends support to AWS Elemental MediaStore origins.
* Glue (3.7.107.0)
	* DirectJDBCSource + Glue 4.0 streaming options
* LakeFormation (3.7.102.0)
	* This release removes the LFTagpolicyResource expression limits.
* Core 3.7.104.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.477.1 (2023-02-07 19:19 UTC)
* Transfer (3.7.104.25)
	* Updated the documentation for the ImportCertificate API call, and added examples.
* Core 3.7.104.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.477.0 (2023-02-06 19:29 UTC)
* ComputeOptimizer (3.7.103.0)
	* AWS Compute optimizer can now infer if Kafka is running on an instance.
* CustomerProfiles (3.7.103.0)
	* This release deprecates the PartyType and Gender enum data types from the Profile model and replaces them with new PartyTypeString and GenderString attributes, which accept any string of length up to 255.
* FraudDetector (3.7.101.0)
	* My AWS Service (Amazon Fraud Detector) - This release introduces Cold Start Model Training which optimizes training for small datasets and adds intelligent methods for treating unlabeled data. You can now train Online Fraud Insights or Transaction Fraud Insights models with minimal historical-data.
* MediaConvert (3.7.105.0)
	* The AWS Elemental MediaConvert SDK has added improved scene change detection capabilities and a bandwidth reduction filter, along with video quality enhancements, to the AVC encoder.
* Outposts (3.7.104.0)
	* Adds OrderType to Order structure. Adds PreviousOrderId and PreviousLineItemId to LineItem structure. Adds new line item status REPLACED. Increases maximum length of pagination token.
* Core 3.7.104.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.476.0 (2023-02-03 19:25 UTC)
* Proton (3.7.104.0)
	* Add new GetResourcesSummary API
* Redshift (3.7.101.1)
	* Corrects descriptions of the parameters for the API operations RestoreFromClusterSnapshot, RestoreTableFromClusterSnapshot, and CreateCluster.
* Core 3.7.104.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.475.0 (2023-02-02 19:44 UTC)
* AppConfig (3.7.101.0)
	* AWS AppConfig introduces KMS customer-managed key (CMK) encryption of configuration data, along with AWS Secrets Manager as a new configuration data source. S3 objects using SSE-KMS encryption and SSM Parameter Store SecureStrings are also now supported.
* Connect (3.7.114.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.121.0)
	* Documentation updates for EC2.
* ElasticLoadBalancingV2 (3.7.100.66)
	* The GWLB Flex Health Check project updates the default values of healthy-threshold-count from 3 to 5 and unhealthy-threshold-count from 3 to 2
* Keyspaces (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* QuickSight (3.7.104.0)
	* QuickSight support for Radar Chart and Dashboard Publish Options
* Redshift (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* SSOAdmin (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Core 3.7.104.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.474.0 (2023-02-02 14:49 UTC)
* S3 (3.7.103.0)
	* Performance optimization for endpoint resolvers for S3.
* S3Control (3.7.106.0)
	* Performance optimization for endpoint resolvers for S3Control.
* SecurityToken (3.7.101.0)
	* Performance optimization for endpoint resolvers for STS.
* Core 3.7.104.0
	* Add Sensitive property to AWSPropertyAttribute and use it to mark sensitive data.
	* All services packages updated to require new Core

### 3.7.473.0 (2023-02-01 19:22 UTC)
* DevOpsGuru (3.7.101.0)
	* This release adds filter support ListAnomalyForInsight API.
* ForecastService (3.7.101.0)
	* This release will enable customer select INCREMENTAL as ImportModel in Forecast's CreateDatasetImportJob API. Verified latest SDK containing required attribute, following https://w.amazon.com/bin/view/AWS-Seer/Launch/Trebuchet/
* IdentityManagement (3.7.100.65)
	* Documentation updates for AWS Identity and Access Management (IAM).
* MediaTailor (3.7.104.0)
	* The AWS Elemental MediaTailor SDK for Channel Assembly has added support for program updates, and the ability to clip the end of VOD sources in programs.
* SimpleNotificationService (3.7.101.0)
	* Additional attributes added for set-topic-attributes.
* Core 3.7.103.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.472.0 (2023-01-31 19:45 UTC)
* AccessAnalyzer (3.7.103.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* AppSync (3.7.103.0)
	* This release introduces the feature to support EventBridge as AppSync data source.
* AWSSupport (3.7.101.0)
	* This fixes incorrect endpoint construction when a customer is explicitly setting a region.
* CloudTrail (3.7.103.0)
	* Add new "Channel" APIs to enable users to manage channels used for CloudTrail Lake integrations, and "Resource Policy" APIs to enable users to manage the resource-based permissions policy attached to a channel.
* CloudTrailData (3.7.100.0)
	* Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.
* CodeArtifact (3.7.102.0)
	* This release introduces a new DeletePackage API, which enables deletion of a package and all of its versions from a repository.
* ConnectParticipant (3.7.104.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.120.0)
	* This launch allows customers to associate up to 8 IP addresses to their NAT Gateways to increase the limit on concurrent connections to a single destination by eight times from 55K to 440K.
* GroundStation (3.7.103.0)
	* DigIF Expansion changes to the Customer APIs.
* IoT (3.7.104.0)
	* Added support for IoT Rules Engine Cloudwatch Logs action batch mode.
* Kinesis (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* OpenSearchService (3.7.103.0)
	* Amazon OpenSearch Service adds the option for a VPC endpoint connection between two domains when the local domain uses OpenSearch version 1.3 or 2.3. You can now use remote reindex to copy indices from one VPC domain to another without a reverse proxy.
* Outposts (3.7.103.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Polly (3.7.105.0)
	* Amazon Polly adds two new neural American English voices - Ruth, Stephen
* SageMaker (3.7.118.0)
	* Amazon SageMaker Automatic Model Tuning now supports more completion criteria for Hyperparameter Optimization.
* SecurityHub (3.7.104.0)
	* New fields have been added to the AWS Security Finding Format. Compliance.SecurityControlId is a unique identifier for a security control across standards. Compliance.AssociatedStandards contains all enabled standards in which a security control is enabled.
* Core 3.7.103.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.471.0 (2023-01-30 19:49 UTC)
* ApplicationDiscoveryService (3.7.101.0)
	* Update ImportName validation to 255 from the current length of 100
* CloudDirectory (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* CloudFormation (3.7.104.0)
	* This feature provides a method of obtaining which regions a stackset has stack instances deployed in.
* DLM (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.119.0)
	* We add Prefix Lists as a new route destination option for LocalGatewayRoutes. This will allow customers to create routes to Prefix Lists. Prefix List routes will allow customers to group individual CIDR routes with the same target into a single route.
* Imagebuilder (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Kafka (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* MediaConvert (3.7.104.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* SimpleWorkflow (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.

### 3.7.470.0 (2023-01-27 19:30 UTC)
* ApplicationAutoScaling (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* AppStream (3.7.102.0)
	* Fixing the issue where Appstream waiters hang for fleet_started and fleet_stopped.
* ElasticBeanstalk (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* FIS (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Glacier (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Greengrass (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* GreengrassV2 (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) in SDK.
* MediaTailor (3.7.103.0)
	* This release introduces the As Run logging type, along with API and documentation updates.
* Outposts (3.7.102.0)
	* Adding support for payment term in GetOrder, CreateOrder responses.
* SageMaker (3.7.117.0)
	* This release supports running SageMaker Training jobs with container images that are in a private Docker registry.
* SageMakerRuntime (3.7.101.0)
	* Amazon SageMaker Runtime which supports InvokeEndpointAsync asynchronously can now invoke endpoints with custom timeout values. Asynchronous invocations support longer processing times.
* ServerlessApplicationRepository (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.

### 3.7.469.0 (2023-01-26 19:21 UTC)
* EventBridge (3.7.101.0)
	* Minor comments for Redshift Serverless workgroup target support.
* IoTFleetWise (3.7.103.0)
	* Add model validation to BatchCreateVehicle and BatchUpdateVehicle operations that invalidate requests with an empty vehicles list.
* S3 (3.7.102.0)
	* Allow FIPS to be used with path-style URLs.
* Core 3.7.103.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.468.0 (2023-01-25 19:38 UTC)
* CloudFormation (3.7.103.0)
	* Enabled FIPS aws-us-gov endpoints in SDK.
* EC2 (3.7.118.0)
	* This release adds new functionality that allows customers to provision IPv6 CIDR blocks through Amazon VPC IP Address Manager (IPAM) as well as allowing customers to utilize IPAM Resource Discovery APIs.
* MainframeModernization (3.7.102.0)
	* Add returnCode, batchJobIdentifier in GetBatchJobExecution response, for user to view the batch job execution result & unique identifier from engine. Also removed unused headers from REST APIs
* Polly (3.7.104.0)
	* Add 5 new neural voices - Sergio (es-ES), Andres (es-MX), Remi (fr-FR), Adriano (it-IT) and Thiago (pt-BR).
* RedshiftServerless (3.7.101.33)
	* Added query monitoring rules as possible parameters for create and update workgroup operations.
* S3Control (3.7.105.0)
	* Add additional endpoint tests for S3 Control. Fix missing endpoint parameters for PutBucketVersioning and GetBucketVersioning. Prior to this fix, those operations may have resulted in an invalid endpoint being resolved.
* SageMaker (3.7.116.0)
	* SageMaker Inference Recommender now decouples from Model Registry and could accept Model Name to invoke inference recommendations job; Inference Recommender now provides CPU/Memory Utilization metrics data in recommendation output.
* SecurityToken (3.7.100.61)
	* Doc only change to update wording in a key topic
* Core 3.7.103.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.467.0 (2023-01-24 19:23 UTC)
* GlueDataBrew (3.7.101.0)
	* Enabled FIPS us-gov-west-1 endpoints in SDK.
* Route53 (3.7.104.0)
	* Amazon Route 53 now supports the Asia Pacific (Melbourne) Region (ap-southeast-4) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SsmSap (3.7.101.0)
	* This release provides updates to documentation and support for listing operations performed by AWS Systems Manager for SAP.
* Core 3.7.103.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.466.0 (2023-01-23 19:28 UTC)
* Lambda (3.7.104.0)
	* Release Lambda RuntimeManagementConfig, enabling customers to better manage runtime updates to their Lambda functions. This release adds two new APIs, GetRuntimeManagementConfig and PutRuntimeManagementConfig, as well as support on existing Create/Get/Update function APIs.
* SageMaker (3.7.115.0)
	* Amazon SageMaker Inference now supports P4de instance types.
* Core 3.7.103.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.465.0 (2023-01-20 19:33 UTC)
* EC2 (3.7.117.0)
	* C6in, M6in, M6idn, R6in and R6idn instances are powered by 3rd Generation Intel Xeon Scalable processors (code named Ice Lake) with an all-core turbo frequency of 3.5 GHz.
* IVS (3.7.101.0)
	* API and Doc update. Update to arns field in BatchGetStreamKey. Also updates to operations and structures.
* QuickSight (3.7.103.0)
	* This release adds support for data bars in QuickSight table and increases pivot table field well limit.
* Core 3.7.103.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.464.0 (2023-01-20 00:03 UTC)
* Appflow (3.7.105.0)
	* Adding support for Salesforce Pardot connector in Amazon AppFlow.
* CloudWatchLogs (3.7.104.0)
	* Bug fix - Removed the regex pattern validation from CoralModel to avoid potential security issue.
* CodeArtifact (3.7.101.0)
	* Documentation updates for CodeArtifact
* Connect (3.7.113.0)
	* Amazon Connect Chat introduces Persistent Chat, allowing customers to resume previous conversations with context and transcripts carried over from previous chats, eliminating the need to repeat themselves and allowing agents to provide personalized service with access to entire conversation history.
* ConnectParticipant (3.7.103.0)
	* This release updates Amazon Connect Participant's GetTranscript api to provide transcripts of past chats on a persistent chat session.
* EC2 (3.7.116.0)
	* Adds SSM Parameter Resource Aliasing support to EC2 Launch Templates. Launch Templates can now store parameter aliases in place of AMI Resource IDs. CreateLaunchTemplateVersion and DescribeLaunchTemplateVersions now support a convenience flag, ResolveAlias, to return the resolved parameter value.
* Glue (3.7.106.0)
	* Release Glue Studio Hudi Data Lake Format for SDK/CLI
* GroundStation (3.7.102.0)
	* Add configurable prepass and postpass times for DataflowEndpointGroup. Add Waiter to allow customers to wait for a contact that was reserved through ReserveContact
* MediaLive (3.7.104.0)
	* AWS Elemental MediaLive adds support for SCTE 35 preRollMilliSeconds.
* OpenSearchService (3.7.102.0)
	* This release adds the enhanced dry run option, that checks for validation errors that might occur when deploying configuration changes and provides a summary of these errors, if any. The feature will also indicate whether a blue/green deployment will be required to apply a change.
* Panorama (3.7.101.0)
	* Added AllowMajorVersionUpdate option to OTAJobConfig to make appliance software major version updates opt-in.
* SageMaker (3.7.114.0)
	* HyperParameterTuningJobs now allow passing environment variables into the corresponding TrainingJobs
* Core 3.7.103.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.463.0 (2023-01-18 19:22 UTC)
* CloudWatch (3.7.103.0)
	* Enable cross-account streams in CloudWatch Metric Streams via Observability Access Manager.
* ElasticFileSystem (3.7.101.33)
	* Documentation updates for EFS access points limit increase
* Ivschat (3.7.103.0)
	* Updates the range for a Chat Room's maximumMessageRatePerSecond field.
* WAFV2 (3.7.101.52)
	* Improved the visibility of the guidance for updating AWS WAF resources, such as web ACLs and rule groups.
* Core 3.7.103.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.462.0 (2023-01-17 19:19 UTC)
* BillingConductor (3.7.104.0)
	* This release adds support for SKU Scope for pricing plans.
* Cloud9 (3.7.101.0)
	* Added minimum value to AutomaticStopTimeMinutes parameter.
* Imagebuilder (3.7.101.0)
	* Add support for AWS Marketplace product IDs as input during CreateImageRecipe for the parent-image parameter. Add support for listing third-party components.
* NetworkFirewall (3.7.103.0)
	* Network Firewall now allows creation of dual stack endpoints, enabling inspection of IPv6 traffic.
* Core 3.7.103.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.461.1 (2023-01-17 15:00 UTC)
* DynamoDBv2 (3.7.101.25)
	* Fix DynamoDB attribute mapping crash due to empty map and FromDocument crash when document contains nulls

### 3.7.461.0 (2023-01-13 19:28 UTC)
* Connect (3.7.112.0)
	* This release updates the responses of UpdateContactFlowContent, UpdateContactFlowMetadata, UpdateContactFlowName and DeleteContactFlow API with empty responses.
* EC2 (3.7.115.0)
	* Documentation updates for EC2.
* Outposts (3.7.101.0)
	* This release adds POWER_30_KVA as an option for PowerDrawKva. PowerDrawKva is part of the RackPhysicalProperties structure in the CreateSite request.
* ResourceGroups (3.7.101.0)
	* AWS Resource Groups customers can now turn on Group Lifecycle Events in their AWS account. When you turn this on, Resource Groups monitors your groups for changes to group state or membership. Those changes are sent to Amazon EventBridge as events that you can respond to using rules you create.
* Core 3.7.103.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.460.0 (2023-01-12 19:24 UTC)
* CleanRooms (3.7.100.0)
	* Initial release of AWS Clean Rooms
* CloudWatchLogs (3.7.103.0)
	* Bug fix: logGroupName is now not a required field in GetLogEvents, FilterLogEvents, GetLogGroupFields, and DescribeLogStreams APIs as logGroupIdentifier can be provided instead
* Lambda (3.7.103.0)
	* Add support for MaximumConcurrency parameter for SQS event source. Customers can now limit the maximum concurrent invocations for their SQS Event Source Mapping.
* MediaConvert (3.7.103.0)
	* The AWS Elemental MediaConvert SDK has added support for compact DASH manifest generation, audio normalization using TruePeak measurements, and the ability to clip the sample range in the color corrector.
* SecretsManager (3.7.101.8)
	* Update documentation for new ListSecrets and DescribeSecret parameters
* Core 3.7.103.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.459.0 (2023-01-11 19:17 UTC)
* Kendra (3.7.102.0)
	* This release adds support to new document types - RTF, XML, XSLT, MS_EXCEL, CSV, JSON, MD

### 3.7.458.0 (2023-01-10 19:19 UTC)
* LocationService (3.7.101.0)
	* This release adds support for two new route travel models, Bicycle and Motorcycle which can be used with Grab data source.
* RDS (3.7.114.0)
	* This release adds support for configuring allocated storage on the CreateDBInstanceReadReplica, RestoreDBInstanceFromDBSnapshot, and RestoreDBInstanceToPointInTime APIs.
* Core 3.7.103.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.457.0 (2023-01-09 19:54 UTC)
* ECRPublic (3.7.101.0)
	* This release for Amazon ECR Public makes several change to bring the SDK into sync with the API.
* KendraRanking (3.7.100.0)
	* Introducing Amazon Kendra Intelligent Ranking, a new set of Kendra APIs that leverages Kendra semantic ranking capabilities to improve the quality of search results from other search services (i.e. OpenSearch, ElasticSearch, Solr).
* NetworkFirewall (3.7.102.0)
	* Network Firewall now supports the Suricata rule action reject, in addition to the actions pass, drop, and alert.
* RAM (3.7.101.0)
	* Enabled FIPS aws-us-gov endpoints in SDK.
* WorkSpacesWeb (3.7.101.0)
	* This release adds support for a new portal authentication type: AWS IAM Identity Center (successor to AWS Single Sign-On).
* Core 3.7.103.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.456.0 (2023-01-06 19:20 UTC)
* ACMPCA (3.7.102.0)
	* Added revocation parameter validation: bucket names must match S3 bucket naming rules and CNAMEs conform to RFC2396 restrictions on the use of special characters in URIs.
* AuditManager (3.7.102.0)
	* This release introduces a new data retention option in your Audit Manager settings. You can now use the DeregistrationPolicy parameter to specify if you want to delete your data when you deregister Audit Manager.
* Core 3.7.103.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.455.0 (2023-01-05 19:23 UTC)
* AmplifyBackend (3.7.101.0)
	* Updated GetBackendAPIModels response to include ModelIntrospectionSchema json string
* AppRunner (3.7.103.0)
	* This release adds support of securely referencing secrets and configuration data that are stored in Secrets Manager and SSM Parameter Store by adding them as environment secrets in your App Runner service.
* Connect (3.7.111.0)
	* Documentation update for a new Initiation Method value in DescribeContact API
* EMRServerless (3.7.102.0)
	* Adds support for customized images. You can now provide runtime images when creating or updating EMR Serverless Applications.
* Lightsail (3.7.101.38)
	* Documentation updates for Amazon Lightsail.
* MWAA (3.7.100.49)
	* MWAA supports Apache Airflow version 2.4.3.
* RDS (3.7.113.0)
	* This release adds support for specifying which certificate authority (CA) to use for a DB instance's server certificate during DB instance creation, as well as other CA enhancements.
* Core 3.7.103.11
	* All services packages updated to require new Core

### 3.7.454.0 (2023-01-04 19:21 UTC)
* ApplicationAutoScaling (3.7.101.0)
	* Customers can now use the existing DescribeScalingActivities API to also see the detailed and machine-readable reasons for Application Auto Scaling not scaling their resources and, if needed, take the necessary corrective actions.
* CloudWatchLogs (3.7.102.27)
	* Update to remove sequenceToken as a required field in PutLogEvents calls.
* SimpleSystemsManagement (3.7.103.0)
	* Adding support for QuickSetup Document Type in Systems Manager

### 3.7.453.1 (2023-01-04 00:34 UTC)
* Core 3.7.103.10
	* Fix profile resolution when using AWS SSO by updating credentials factory to consider sso-session if present.
	* All services packages updated to require new Core

### 3.7.453.0 (2023-01-03 19:20 UTC)
* SecurityLake (3.7.101.0)
	* Allow CreateSubscriber API to take string input that allows setting more descriptive SubscriberDescription field. Make souceTypes field required in model level for UpdateSubscriberRequest as it is required for every API call on the backend. Allow ListSubscribers take any String as nextToken param.
* Core 3.7.103.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

