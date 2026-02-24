### 4.0.198.0 (2026-02-24 19:17 UTC)
* CloudWatch (4.0.8.0)
	* This release adds the APIs (PutAlarmMuteRule, ListAlarmMuteRules, GetAlarmMuteRule and DeleteAlarmMuteRule) to manage a new Cloudwatch resource, AlarmMuteRules. AlarmMuteRules allow customers to temporarily mute alarm notifications during expected downtime periods.
* EC2 (4.0.77.0)
	* Adds httpTokensEnforced property to ModifyInstanceMetadataDefaults API. Set per account or manage organization-wide using declarative policies to prevent IMDSv1-enabled instance launch and block attempts to enable IMDSv1 on existing IMDSv2-only instances.
* Elasticsearch (4.0.3.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* ElementalInference (4.0.0.0)
	* Initial GA launch for AWS Elemental Inference including capabilities of Smart Crop and Live Event Clipping
* MediaLive (4.0.17.0)
	* AWS Elemental MediaLive - Added support for Elemental Inference for Smart Cropping and Clipping features for MediaLive.
* ObservabilityAdmin (4.0.6.0)
	* Adding a new field in the CreateCentralizationRuleForOrganization, UpdateCentralizationRuleForOrganization API and updating the GetCentralizationRuleForOrganization API response to include the new field
* OpenSearchService (4.0.10.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* PartnerCentralSelling (4.0.9.0)
	* Added support for filtering opportunities by target close date in the ListOpportunities API. You can now filter results to return opportunities with a target close date before or after a specified date, enabling more precise opportunity searches based on expected closure timelines.

### 4.0.197.0 (2026-02-23 19:15 UTC)
* Bedrock (4.0.20.0)
	* Automated Reasoning checks in Amazon Bedrock Guardrails now support fidelity report generation. The new workflow type assesses policy coverage and accuracy against customer documents. The GetAutomatedReasoningPolicyBuildWorkflowResultAssets API adds support for the three new asset types.
* ConnectCases (4.0.10.0)
	* SearchCases API can now accept 25 fields in the request and response as opposed to the previous limit of 10. DeleteField's hard limit of 100 fields per domain has been lifted.
* ControlCatalog (4.0.4.11)
	* Updated ExemptedPrincipalArns parameter documentation for improved accuracy
* DataZone (4.0.21.0)
	* Add workflow properties support to connections APIs
* DynamoDBv2 (4.0.15.0)
	* This change supports the creation of multi-account global tables. It adds one new arguments to UpdateTable, GlobalTableSettingsReplicationMode.
* MediaTailor (4.0.6.0)
	* Updated endpoint rule set for dualstack endpoints. Added a new opt-in option to log raw ad decision server requests for Playback Configurations.
* QuickSight (4.0.15.0)
	* Adds support for SEMISTRUCT to InputColumn Type
* Wickr (4.0.1.0)
	* AWS Wickr now provides APIs to manage your Wickr OpenTDF integration. These APIs enable you to test and save your OpenTDF configuration allowing you to manage rooms based on Trusted Data Format attributes.
* Core 4.0.3.15
	* Optimize MemoryStream Base64 serialization in JSON marshallers (Fix: https://github.com/aws/aws-sdk-net/issues/1922).
	* All service and extension packages updated to require new Core

### 4.0.196.0 (2026-02-20 20:48 UTC)
* AppStream (4.0.6.0)
	* Adding new attribute to disable IMDS v1 APIs for fleet, Image Builder and AppBlockBuilder instances.
* DynamoDBv2 (4.0.14.1)
	* Fix regression in V4 where `Scan` operation could not be invoked with a `FilterExpression` (https://github.com/aws/aws-sdk-net/issues/4324)
* ECS (4.0.13.0)
	* Migrated to Smithy. No functional changes
* SageMakerRuntime (4.0.2.0)
	* Added support for S3OutputPathExtension and Filename parameters to the InvokeEndpointAsync API to allow users to customize the S3 output path and file name for async inference response payloads.
* SignerData (4.0.0.0)
	* This release introduces AWS Signer Data Plane SDK client supporting GetRevocationStatus API. The new client enables AWS PrivateLink connectivity with both private DNS and VPC endpoint URLs.
* SimpleSystemsManagement (4.0.7.0)
	* Add support for AssociationDispatchAssumeRole in AWS SSM State Manager.
* TrustedAdvisor (4.0.3.0)
	* Adding a new enum attribute(statusReason) to TrustedAdvisorAPI response. This attribute explains reasoning behind check status for certain specific scenarios.

### 4.0.195.0 (2026-02-19 19:31 UTC)
* BCMDashboards (4.0.2.0)
	* The Billing and Cost Management GetDashboard API now returns identifier for each widget, enabling users to uniquely identify widgets within their dashboards.
* ECR (4.0.10.0)
	* Adds multiple artifact types filter support in ListImageReferrers API.
* PcaConnectorScep (4.0.3.0)
	* AWS Private CA Connector for SCEP now supports AWS PrivateLink, allowing your clients to request certificates from within your Amazon Virtual Private Cloud (VPC) without traversing the public internet. With this launch, you can create VPC endpoints to connect to your SCEP connector privately.

### 4.0.194.0 (2026-02-18 19:27 UTC)
* CleanRooms (4.0.15.0)
	* This release adds support for federated catalogs in Athena-sourced configured tables.
* CloudWatchEvidently (Removed)
	* Amazon CloudWatch Evidently has been removed from the SDK because it has been discontinued.
* Connect (4.0.33.1)
	* Correcting in-app notifications API documentation.
* IoTAnalytics (Removed)
	* Amazon IoT Analytics has been removed from the SDK because it has been discontinued.

### 4.0.193.0 (2026-02-17 19:55 UTC)
* EC2 (4.0.76.0)
	* Add Operator field to CreatePlacementGroup and DescribePlacementGroup APIs.
* ManagedGrafana (4.0.3.0)
	* This release updates Amazon Managed Grafana's APIs to support customer managed KMS keys.
* RDS (4.0.18.0)
	* Adds support for the StorageEncryptionType field to specify encryption type for DB clusters, DB instances, snapshots, automated backups, and global clusters.
* WorkSpacesWeb (4.0.8.0)
	* Adds support for branding customization without requiring a custom wallpaper.

### 4.0.192.0 (2026-02-16 19:35 UTC)
* ARCRegionswitch (4.0.4.1)
	* Clarify documentation on ARC Region Switch start-plan-execution operation
* EC2 (4.0.75.1)
	* Documentation updates for EC2 Secondary Networks
* ECR (4.0.9.6)
	* Adds support for enabling blob mounting, and removes support for Clair based image scanning
* Kafka (4.0.6.0)
	* Amazon MSK now supports dual-stack connectivity (IPv4 and IPv6) for existing MSK clusters. You can enable dual-stack on existing clusters by specifying the NetworkType parameter in updateConnectivity API.
* KeyManagementService (4.0.9.0)
	* Added support for Decrypt and ReEncrypt API's to use dry run feature without ciphertext for authorization validation
* QConnect (4.0.8.0)
	* Update MessageType enum to include missing types.

### 4.0.191.0 (2026-02-13 19:18 UTC)
* CloudWatch (4.0.7.0)
	* Adding new evaluation states that provides information about the alarm evaluation process. Evaluation error Indicates configuration errors in alarm setup that require review and correction. Evaluation failure Indicates temporary CloudWatch issues.
* Connect (4.0.33.0)
	* API release for headerr notifications in the admin website. APIs allow customers to publish brief messages (including URLs) to a specified audience, and a new header icon will indicate when unread messages are available.
* EC2 (4.0.75.0)
	* This release adds geography information to EC2 region and availability zone APIs. DescribeRegions now includes a Geography field, while DescribeAvailabilityZones includes both Geography and SubGeography fields, enabling better geographic classification for AWS regions and zones.
* Inspector2 (4.0.9.0)
	* Added .Net 10 (dotnet10) and Node 24.x (node24.x) runtime support for lambda package scanning
* S3 (4.0.18.6)
	* Fix AmazonS3Uri class to correctly handle UTF-8 encoded characters
* SageMaker (4.0.43.0)
	* Enable g7e instance type support for SageMaker Processing, and enable single file configuration provisioning for HyperPod Slurm, where customers have the option to use HyperPod API to provide the provisioning parameters.

### 4.0.190.0 (2026-02-12 19:17 UTC)
* EC2 (4.0.74.0)
	* Launching nested virtualization. This feature allows you to run nested VMs inside virtual (non-bare metal) EC2 instances.

### 4.0.189.0 (2026-02-11 19:38 UTC)
* Batch (4.0.5.0)
	* Add support for listing jobs by share identifier and getting snapshots of active capacity utilization by job queue and share.
* EC2 (4.0.73.0)
	* R8i instances powered by custom Intel Xeon 6 processors available only on AWS with sustained all-core 3.9 GHz turbo frequency
* EKS (4.0.13.0)
	* This release adds support for Windows Server 2025 in Amazon EKS Managed Node Groups.
* KafkaConnect (4.0.5.0)
	* Support configurable upper limits on task count during autoscaling operations via maxAutoscalingTaskCount parameter.
* S3 (4.0.18.5)
	* Fix MPU in transfer utility for objects larger than 80GB
* S3Tables (4.0.9.0)
	* S3 Tables now supports setting partition specifications and sort orders on tables. Partition specs allow users to define how data is organized using transform functions. Sort order configurations enable users to specify sort directions and null ordering preferences for optimized data layout.
* Core 4.0.3.14
	* Update documentation for `MaxErrorRetry` to call out different default value for `DynamoDB`

### 4.0.188.0 (2026-02-10 19:23 UTC)
* BedrockAgentCore (4.0.11.0)
	* Added AgentCore browser proxy configuration support, allowing routing of browser traffic through HTTP and HTTPS proxy servers with authentication and bypass rules.
* Connect (4.0.32.0)
	* Amazon Connect now supports per-channel auto-accept and After Contact Work (ACW) timeouts. Configure agents with auto-accept and ACW timeout settings for chat, tasks, emails, and callbacks. Use the new UpdateUserConfig API to manage these settings.
* EKS (4.0.12.0)
	* Introducing an optional policy field, an IAM policy applied to pod identity associations in addition to IAM role policies. When specified, pod permissions are the intersection of IAM role policies and the policy field, ensuring the principle of least privilege.
* Kafka (4.0.5.0)
	* Amazon MSK adds three new APIs, CreateTopic, UpdateTopic, and DeleteTopic for managing Kafka topics in your MSK clusters.
* RDS (4.0.17.0)
	* This release adds backup configuration for RDS and Aurora restores, letting customers set backup retention period and preferred backup window during restore. It also enables viewing backup settings when describing snapshots or automated backups for instances and clusters.
* S3 (4.0.18.4)
	* Cleanup S3 code generation infrastructure after completing the S3 generation.
* Core 4.0.3.13
	* Add internal attribute to mark interfaces in `Core` that can be updated without backwards incompatibility issues

### 4.0.187.0 (2026-02-09 20:25 UTC)
* ConnectCampaignsV2 (4.0.6.0)
	* Add the missing event type for WhatsApp
* EC2 (4.0.72.0)
	* Amazon Secondary Networks is a networking feature that provides high-performance, low-latency connectivity for specialized workloads.
* EKS (4.0.11.0)
	* Amazon EKS adds a new DescribeUpdate update type, VendedLogsUpdate, to support an integration between EKS Auto Mode and Amazon CloudWatch Vended Logs.
* Imagebuilder (4.0.7.0)
	* EC2 Image Builder now supports wildcard patterns in lifecycle policies with recipes and enhances the experience of tag-scoped policies.
* LakeFormation (4.0.4.3)
	* Allow cross account v5 in put data lake settings
* Neptunedata (4.0.4.0)
	* Added edgeOnlyLoad boolean parameter to Neptune bulk load request. When TRUE, files are loaded in order without scanning. When FALSE (default), the loader scans files first, then loads vertex files before edge files automatically.
* PCS (4.0.12.0)
	* Introduces RESUMING state for clusters, compute node groups, and queues.
* Transfer (4.0.6.1)
	* This release adds a documentation update for MdnResponse of type "ASYNC"

### 4.0.186.0 (2026-02-06 19:18 UTC)
* BedrockDataAutomationRuntime (4.0.5.0)
	* Add OutputConfiguration to InvokeDataAutomation input and output to support S3 output
* Deadline (4.0.13.0)
	* Adds support for tagging jobs during job creation
* IoTManagedIntegrations (4.0.6.0)
	* Adding support for Custom(General) Authorization in managed integrations for AWS IoT Device Management cloud connectors.
* PartnerCentralSelling (4.0.8.0)
	* Releasing AWS Opportunity Snapshots for SDK release.
* S3 (4.0.18.3)
	* Generate S3 Enumerations.
* SageMaker (4.0.42.0)
	* Adding g7e instance support in Sagemaker Training

### 4.0.185.0 (2026-02-05 19:17 UTC)
* ARCRegionswitch (4.0.4.0)
	* Updates documentation for ARC Region switch and provides stronger validation for Amazon Aurora Global Database execution block parameters.
* Athena (4.0.4.0)
	* Reduces the minimum TargetDpus to create or update capacity reservations from 24 to 4.
* BedrockAgentCore (4.0.10.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* BedrockAgentCoreControl (4.0.16.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* Glue (4.0.25.0)
	* This release adds the capability to easily create custom AWS Glue connections to data sources with REST APIs.
* MediaLive (4.0.16.0)
	* Outputs using the AV1 codec in CMAF Ingest output groups in MediaLive now have the ability to specify a target bit depth of 8 or 10.
* NeptuneGraph (4.0.2.14)
	* Minor neptune-graph documentation changes
* RAM (4.0.3.0)
	* Added ListSourceAssociations API. Allows RAM resource share owners to list source associations that determine which sources can access resources through service principal associations. Supports filtering by resource share ARN, source ID, source type, or status, with pagination.
* Transfer (4.0.6.0)
	* Adds support for the customer to send custom HTTP headers and configure an AS2 Connector to receive Asynchronous MDNs from their trading partner
* WorkSpaces (4.0.9.0)
	* Added support for 12 new graphics-optimized compute types - Graphics.g6 (xlarge, 2xlarge, 4xlarge, 8xlarge, 16xlarge), Graphics.gr6 (4xlarge, 8xlarge), Graphics.g6f (large, xlarge, 2xlarge, 4xlarge), and Graphics.gr6f (4xlarge).

### 4.0.184.0 (2026-02-04 19:16 UTC)
* BedrockRuntime (4.0.16.0)
	* Added support for structured outputs to Converse and ConverseStream APIs.
* ConnectCases (4.0.9.0)
	* Amazon Connect Cases now supports larger, multi-line text fields with up to 4,100 characters. Administrators can use the Admin UI to select the appropriate configuration (single-line or multi-line) on a per-field basis, improving case documentation capabilities.
* EKS (4.0.10.4)
	* Update delete cluster description
* MediaLive (4.0.15.0)
	* AWS Elemental MediaLive now supports SRT listener mode for inputs and outputs, in addition to the existing SRT caller mode.
* Redshift (4.0.6.4)
	* We have increased the maximum duration for a deferred maintenance window from 45 days to 60 days for Amazon Redshift provisioned clusters. This enhancement provides customers with greater flexibility in scheduling patching and maintenance activities while also maintaining security compliance.
* WorkSpacesWeb (4.0.7.0)
	* Support for configuring and managing custom domain names for WorkSpaces Secure Browser portals.

### 4.0.183.0 (2026-02-03 19:25 UTC)
* Batch (4.0.4.0)
	* AWS Batch Array Job Visibility feature support. Includes new statusSummaryLastUpdatedAt for array job parent DescribeJobs responses for the last time the statusSummary was updated. Includes both statusSummary and statusSummaryLastUpdatedAt in ListJobs responses for array job parents.
* DynamoDBv2 (4.0.14.0)
	* This change supports the creation of multi-account global tables. It adds two new arguments to CreateTable, GlobalTableSourceArn and GlobalTableSettingsReplicationMode. DescribeTable is also updated to include information about GlobalTableSettingsReplicationMode.
* GeoMaps (4.0.4.0)
	* Added support for optional style parameters in maps, including 3D terrain and 3D Buildings
* Kinesis (4.0.8.0)
	* Adds StreamId parameter to AWS Kinesis Data Streams APIs that is reserved for future use.
* MarketplaceCatalog (4.0.5.0)
	* Adds support for Catalog API us-east-1 dualstack endpoint catalog-marketplace.us-east-1.api.aws
* Organizations (4.0.10.7)
	* Updated the CloseAccount description.
* S3 (4.0.18.2)
	* Generate PutBucketVersioning, GetBucketVersioning, and UpdateBucketMetadataInventoryTableConfiguration
* SSOAdmin (4.0.5.0)
	* Added new Region management APIs to support multi-Region replication in IAM Identity Center.

### 4.0.182.0 (2026-02-02 19:17 UTC)
* BedrockAgentCoreControl (4.0.15.0)
	* Adds tagging support for AgentCore Evaluations (evaluator and online evaluation config)
* CloudFront (4.0.12.0)
	* Add OriginMTLS support to CloudFront Distribution APIs
* MPA (4.0.3.0)
	* Updates to multi-party approval (MPA) service to add support for multi-factor authentication (MFA) for voting operations.

### 4.0.181.0 (2026-01-30 19:23 UTC)
* Connect (4.0.31.0)
	* This release adds Estimated Wait Time support to the GetContactMetrics API for Amazon Connect.
* DynamoDBv2 (4.0.13.0)
	* Add support for DynamoDbUpdateBehavior for operations.
* QuickSight (4.0.14.0)
	* Improve SessionTag usage guidelines in the GenerateEmbedURLForAnonymousUser API documentation. Update the GetIdentityContext document with the region support context.

### 4.0.180.0 (2026-01-29 19:38 UTC)
* EC2 (4.0.71.0)
	* G7e instances feature up to 8 NVIDIA RTX PRO 6000 Blackwell Server Edition GPUs with 768 GB of memory and 5th generation Intel Xeon Scalable processors. Supporting up to 192 vCPUs, 1600 Gbps networking bandwidth with EFA, up to 2 TiB of system memory, and up to 15.2 TB of local NVMe SSD storage.
* GameLift (4.0.6.0)
	* Amazon GameLift Servers now supports automatic scaling to and from zero instances based on game session activity. Fleets scale down to zero following a defined period of no game session activity and scale up from zero when game sessions are requested, providing an option for cost optimization.
* S3 (4.0.18.1)
	* Generate PutObject, GetObject, UploadPart, WriteGetObjectResponse, GetObjectTorrent.
	* [Breaking Change] WriteOffsetBytes on PutObjectRequest changed from int to int? to be consistent with the nullability changes in V4.
	* [Breaking Change] TagCount on GetObjectResponse changed from int to int? to be consistent with the nullability changes in V4.
	* SSEKMSKeyId, SSECustomerAlgorithm, SSECustomerKeyMD5 properties were added to UploadPartResponse.
	* Expires was added to both PutObjectRequest and InitiateMultipartUploadRequest.
* Core 4.0.3.12
	* Update `AssumeRoleAWSCredentials` and `AssumeRoleWithWebIdentityCredentials` to dynamically use a 5-minute preempt expiry if the requested role session duration is less than 20 minutes (to prevent the SDK from refreshing credentials unnecessarily) - https://github.com/aws/aws-sdk-net/issues/4313
	* All service and extension packages updated to require new Core

### 4.0.179.0 (2026-01-28 19:27 UTC)
* CognitoIdentityProvider (4.0.5.0)
	* This release adds support for a new lambda trigger to transform federated user attributes during the authentication with external identity providers on Cognito Managed Login.
* Connect (4.0.30.0)
	* Adds support for filtering search results based on tags assigned to contacts.
* DynamoDBv2 (4.0.12.0)
	* Add Request Object Pattern and Expression-Based for DynamoDB Document Model.
* EC2 (4.0.70.0)
	* SearchTransitGatewayRoutes API response now includes a NextToken field, enabling pagination when retrieving large sets of transit gateway routes. Pass the returned NextToken value in subsequent requests to retrieve the next page of results.
* Lambda (4.0.13.0)
	* We are launching ESM Metrics and logging for Kafka ESM to allow customers to monitor Kafka event processing using CloudWatch Metrics and Logs.
* MediaConnect (4.0.6.0)
	* This release adds support for NDI flow sources in AWS Elemental MediaConnect. You can now send content to your MediaConnect transport streams directly from your NDI environment using the new NDI source type. Also adds support for LARGE 4X flow size, which can be used when creating CDI JPEG-XS flows.
* MediaConvert (4.0.13.0)
	* This release adds a follow source mode for audio output channel count, an AES audio frame wrapping option for MXF outputs, and an option to signal DolbyVision compatibility using the SUPPLEMENTAL-CODECS tag in HLS manifests.
* S3 (4.0.18.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.
* S3Control (4.0.9.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.

### 4.0.178.0 (2026-01-27 19:24 UTC)
* Connect (4.0.29.0)
	* Added support for task attachments. The StartTaskContact API now accepts file attachments, enabling customers to include files (.csv, .doc, .docx, .heic, .jfif, .jpeg, .jpg, .mov, .mp4, .pdf, .png, .ppt, .pptx, .rtf, .txt, etc.) when creating Task contacts. Supports up to 5 attachments per task.
* Deadline (4.0.12.0)
	* AWS Deadline Cloud now supports editing job names and descriptions after submission.
* EC2 (4.0.69.0)
	* Releasing new EC2 instances. C8gb and M8gb with highest EBS performance, M8gn with 600 Gbps network bandwidth, X8aedz and M8azn with 5GHz AMD processors, X8i with Intel Xeon 6 processors and up to 6TB memory, and Mac-m4max with Apple M4 Max chip for 25 percent faster builds.
* MediaLive (4.0.14.0)
	* AWS Elemental MediaLive released two new features that allows customers 1) to set Output Timecode for AV1 encoder, 2) to set a Custom Epoch for CMAF Ingest and MediaPackage V2 output groups when using Pipeline Locking or Disabled Locking modes.
* SageMaker (4.0.41.0)
	* Idle resource sharing enables teams to borrow unused compute resources in your SageMaker HyperPod cluster. This capability maximizes resource utilization by allowing teams to borrow idle compute capacity beyond their allocated compute quotas.
* Extensions.Bedrock.MEAI (4.0.5.6)
	* Fixed AOT compilation issue where Dictionary<string, object?> type was not registered in BedrockJsonContext, causing GetTypeInfo lookups to fail at runtime.

### 4.0.177.0 (2026-01-26 19:40 UTC)
* CloudWatchEvidently (4.0.3.0)
	* Deprecate all Evidently API for AWS CloudWatch Evidently deprecation
* ConnectCases (4.0.8.0)
	* Amazon Connect now enables you to use tag-based access controls to define who can access specific cases. You can associate tags with case templates and configure security profiles to determine which users can access cases with those tags.
* EC2 (4.0.68.0)
	* DescribeInstanceTypes API response now includes an additionalFlexibleNetworkInterfaces field, the number of interfaces attachable to an instance when using flexible Elastic Network Adapter (ENA) queues in addition to the base number specified by maximumNetworkInterfaces.
* GroundStation (4.0.3.0)
	* Adds support for AWS Ground Station Telemetry.
* Core 4.0.3.11
	* Remove `InternalsVisibleTo` reference to renamed project in `AssemblyInfo` file

### 4.0.176.0 (2026-01-23 19:25 UTC)
* Connect (4.0.28.0)
	* Amazon Connect now offers public APIs to programmatically configure and run automated tests for contact center experiences. Integrate testing into CICD pipelines, run multiple tests at scale, and retrieve results via API to automate validation of voice interactions and workflows.
* DataZone (4.0.20.0)
	* Added api for deleting data export configuration for a domain
* QConnect (4.0.7.0)
	* Fixes incorrect types in the UpdateAssistantAIAgent API request, adds MESSAGE to TargetType enum, and other minor changes.

### 4.0.175.0 (2026-01-22 19:21 UTC)
* AutoScaling (4.0.8.0)
	* This release adds support for Amazon EC2 Auto Scaling group deletion protection
* AWSHealth (4.0.4.0)
	* Updates the lower range for the maxResults request property for DescribeAffectedEntities, DescribeAffectedEntitiesForOrganization, DescribeEvents, and DescribeEventsForOrganization API request properties.
* AWSMarketplaceMetering (4.0.3.8)
	* Customer Identifier parameter deprecation date has been removed. For new implementations, we recommend using the CustomerAWSAccountID. Your current integration will continue to work. When updating your implementation, consider migrating to CustomerAWSAccountID for improved integration.
* Budgets (4.0.9.0)
	* Add Budget FilterExpression and Metrics fields to DescribeBudgetPerformanceHistory to support more granular filtering options.
* DynamoDBv2 (4.0.11.0)
	* Adds additional waiters to Amazon DynamoDB.
* EC2 (4.0.67.0)
	* Add better support for fractional GPU instances in DescribeInstanceTypes API. The new fields, logicalGpuCount, gpuPartitionSize, and workload array enable better GPU resource selection and filtering for both full and fractional GPU instance types.
* GameLift (4.0.5.0)
	* Amazon GameLift Servers Realtime now supports Node.js 24.x runtime on the Amazon Linux 2023 operating system.
* GuardDuty (4.0.16.0)
	* Adding new enum value for ScanStatusReason
* VerifiedPermissions (4.0.6.1)
	* Adding documentation to user guide and API documentation for how customers can create new encrypted policy stores by passing in their customer managed key during policy store creation.

### 4.0.174.0 (2026-01-21 19:19 UTC)
* BedrockAgentCore (4.0.9.0)
	* Supports custom browser extensions for AgentCore Browser and increased message payloads up to 100KB per message in an Event for AgentCore Memory
* ConfigService (4.0.6.0)
	* AWS Config Conformance Packs now support tag-on-create through PutConformancePack API.
* EC2 (4.0.66.0)
	* Added support of multiple EBS cards. New EbsCardIndex parameter enables attaching volumes to specific EBS cards on supported instance types for improved storage performance.
* QuickSight (4.0.13.0)
	* Added documentation and model for sheet layout groups - allows sheet elements to be grouped, Added documentation and the feature enables admins to have granular control over connectors under actions, Updated API documentation for PDF Export in Snapshot Export APIs

### 4.0.173.0 (2026-01-20 19:53 UTC)
* AutoScaling (4.0.7.0)
	* This release adds support for three new filters when describing scaling activities, StartTimeLowerBound, StartTimeUpperBound, and Status.
* BedrockRuntime (4.0.15.0)
	* Added support for extended prompt caching with one hour TTL.
* Keyspaces (4.0.3.0)
	* Adds support for managing table pre-warming in Amazon Keyspaces (for Apache Cassandra)
* Odb (4.0.4.0)
	* Adds support for associating and disassociating IAM roles with Autonomous VM cluster resources through the AssociateIamRoleToResource and DisassociateIamRoleFromResource APIs. The GetCloudAutonomousVmCluster and ListCloudAutonomousVmClusters API responses now include the iamRoles field.
* VerifiedPermissions (4.0.6.0)
	* Amazon Verified Permissions now supports encryption of resources by a customer managed KMS key. Customers can now create new encrypted policy stores by passing in their customer managed key during policy store creation.
* WorkspacesInstances (4.0.3.0)
	* Added billing configuration support for WorkSpaces Instances with monthly and hourly billing modes, including new filtering capabilities for instance type searches.
* Core 4.0.3.10
	* Add MaxStaleConnectionRetries to Amazon.Runtime.ClientConfig to allow users to customize the amount of retries available for stale connections.
	* Update the retry behavior of the SDK to automatically retry on stale connections (e.g Broken pipe), which do not count against the standard retry amount.
	* All service and extension packages updated to require new Core

### 4.0.172.0 (2026-01-16 19:27 UTC)
* Connect (4.0.27.0)
	* Adds support to allow customers to create form with Dispute configuration
* DataZone (4.0.19.0)
	* This release adds support for numeric filtering and complex free-text searches cases for the Search and SearchListings APIs.
* Glacier (4.0.3.4)
	* Documentation updates for Amazon Glacier's maintenance mode
* LaunchWizard (4.0.3.0)
	* Added UpdateDeployment, ListDeploymentPatternVersions and GetDeploymentPatternVersion APIs for Launch Wizard
* ResourceExplorer2 (4.0.3.0)
	* Added ViewName to View-related responses and ServiceViewName to GetServiceView response.
* SageMaker (4.0.40.2)
	* Adding security consideration comments for lcc accessing execution role under root access

### 4.0.171.0 (2026-01-15 19:19 UTC)
* CleanRooms (4.0.14.0)
	* This release adds support for parameters in PySpark analysis templates.
* Deadline (4.0.11.0)
	* AWS Deadline Cloud now supports tagging Budget resources with ABAC for permissions management and selecting up to 16 filter values in the monitor and Search API.
* EC2 (4.0.65.3)
	* This release includes documentation updates to support up to four Elastic Volume modifications per Amazon EBS volume within a rolling 24-hour period.
* ECS (4.0.12.0)
	* Adds support for configuring FIPS in AWS GovCloud (US) Regions via a new ECS Capacity Provider field fipsEnabled. When enabled, instances launched by the capacity provider will use a FIPS-140 enabled AMI. Instances will use FIPS-140 compliant cryptographic modules and AWS FIPS endpoints.
* Evs (4.0.5.0)
	* A new GetVersions API has been added to retrieve VCF, ESX versions, and EC2 instances provided by Amazon EVS. The CreateEnvironment API now allows you to select a VCF version and the CreateEnvironmentHost API introduces a optional esxVersion parameter.
* LakeFormation (4.0.4.0)
	* API Changes for GTCForLocation feature. Includes a new API, GetTemporaryDataLocationCredentials and updates to the APIs RegisterResource and UpdateResource
* OpenSearchServerless (4.0.6.0)
	* Collection groups in Amazon OpenSearch Serverless enables to organize multiple collections and enable compute resource sharing across collections with different KMS keys. This shared compute model reduces costs by eliminating the need for separate OpenSearch Compute Units (OCUs) for each KMS key.
* QConnect (4.0.6.0)
	* Fix inference configuration shapes for the CreateAIPrompt and UpdateAIPrompt APIs, Modify Text Length Limit for SendMessage API
* S3 (4.0.17.2)
	* Generate paginators for S3
* Core 4.0.3.9
	* Add default constructors for all generated service exceptions
	* For .NET 8+ targets use ExceptionDispatchInfo.Throw when rethrowing inner HTTP exceptions to preserve original exception context
	* Updating partitions.json file.
	* All service and extension packages updated to require new Core

### 4.0.170.0 (2026-01-14 19:21 UTC)
* Connect (4.0.26.0)
	* Amazon Connect makes it easier to manage contact center operating hours by enabling automated scheduling for recurring events like holidays and maintenance windows. Set up recurring patterns (weekly, monthly, etc.) or link to another hours of operation to inherit overrides.
* CostExplorer (4.0.11.2)
	* Cost Categories added support to BillingView data filter expressions through the new costCategories parameter, enabling users to filter billing views by AWS Cost Categories for more granular cost management and allocation.
* EKS (4.0.10.0)
	* Added support for BOTTLEROCKET NVIDIA FIPS AMIs to AMI types in US regions.
* RDS (4.0.16.0)
	* no feature changes. model migrated to Smithy
* Redshift (4.0.6.0)
	* Adds support for enabling extra compute resources for automatic optimization during create and modify operations in Amazon Redshift clusters.
* RedshiftServerless (4.0.4.0)
	* Adds support for enabling extra compute resources for automatic optimization during create and update operations in Amazon Redshift Serverless workgroups.
* SocialMessaging (4.0.4.0)
	* This release clarifies WhatsApp template operations as a resource-authenticated operation via the parent WhatsApp Business Account. It also introduces new parameters for parameter format, CTA URL link tracking, and template body examples, and increases the phone number ID length.

### 4.0.169.0 (2026-01-13 19:20 UTC)
* Bedrock (4.0.19.0)
	* This change will increase TestCase guardContent input size from 1024 to 2028 characters and PolicyBuildDocumentDescription from 2000 to 4000 characters
* DataZone (4.0.18.0)
	* Adds support for IAM role subscriptions to Glue table listings via CreateSubscriptionRequest API. Also adds owningIamPrincipalArn filter to List APIs and subscriptionGrantCreationMode parameter to subscription target APIs for controlling grant creation behavior.

### 4.0.168.0 (2026-01-12 19:24 UTC)
* Billing (4.0.6.0)
	* Cost Categories filtering support to BillingView data filter expressions through the new costCategories parameter, enabling users to filter billing views by AWS Cost Categories for more granular cost management and allocation.
* IoTManagedIntegrations (4.0.5.0)
	* This release introduces WiFi Simple Setup (WSS) enabling device provisioning via barcode scanning with automated network discovery, authentication, and credential provisioning. Additionally, it introduces 2P Device Capability Rediscovery for updating hub-managed device capabilities post-onboarding.
* S3 (4.0.17.1)
	* Generate GetBucketWebsite, PutBucketWebsite, and DeleteBucketWebsite
* SageMaker (4.0.40.0)
	* Added ultraServerType to the UltraServerInfo structure to support server type identification for SageMaker HyperPod

### 4.0.167.0 (2026-01-09 19:18 UTC)
* BedrockAgentCoreControl (4.0.14.0)
	* Adds optional field "view" to GetMemory API input to give customers control over whether CMK encrypted data such as strategy decryption or override prompts is returned or not.
* CloudFront (4.0.11.0)
	* Added EntityLimitExceeded exception handling to the following API operations AssociateDistributionWebACL, AssociateDistributionTenantWebACL, UpdateDistributionWithStagingConfig
* Glue (4.0.24.0)
	* Adding MaterializedViews task run APIs
* MediaLive (4.0.13.0)
	* MediaPackage v2 output groups in MediaLive can now accept one additional destination for single pipeline channels and up to two additional destinations for standard channels. MediaPackage v2 destinations now support sending to cross region MediaPackage channels.
* S3 (4.0.17.0)
	* Added MaxInMemoryParts property to the Amazon.S3.Transfer.TransferUtilityOpenStreamRequest class for controlling memory usage during multipart downloads
	* Added PartSize property to the Amazon.S3.Transfer.BaseDownloadRequest class for configuring multipart download part sizes
	* Added MultipartDownloadType enum and property to the Amazon.S3.Transfer.BaseDownloadRequest class for selecting download strategy
	* Fix signature calculation error when using the Content-Language header in S3 requests (e.g., PutObjectRequest)
	* Added UploadInitiatedEvent, UploadCompletedEvent, and UploadFailedEvent events to the Amazon.S3.Transfer.TransferUtility.Upload operation for non-multipart uploads.
	* Added UploadInitiatedEvent, UploadCompletedEvent, and UploadFailedEvent events to the Amazon.S3.Transfer.TransferUtility.Upload operation for multipart uploads.
	* Generate PutBucketLogging and GetBucketLogging.
	* Added DownloadDirectoryWithResponse methods to the Amazon.S3.Transfer.ITransferUtility interface. The new operations support downloading directories using multipart download for files and return response metadata.
	* Added UploadWithResponse and UploadWithResponseAsync methods to the Amazon.S3.Transfer.ITransferUtility interface that return response metadata information.
	* Added DownloadDirectoryInitiatedEvent, DownloadDirectoryCompletedEvent, and DownloadDirectoryFailedEvent events to the Amazon.S3.Transfer.ITransferUtility.DownloadDirectory operation.
	* BREAKING CHANGE: A security fix has been applied to the Transfer Utility Download Directory command which now checks if the directory is case-sensitive before proceeding with the download. This prevents potential overwriting of files in case-insensitive file systems. If you would like to revert to the previous behavior, you can set the 'SkipDirectoryCaseSensitivityCheck' property on the 'TransferUtilityConfig' to true.
	* Added OpenStreamWithResponse method to the Amazon.S3.Transfer.ITransferUtility interface. The new operation supports downloading in parallel parts of the S3 object in the background while reading from the stream for improved performance.
	* Added DownloadWithResponse method to the Amazon.S3.Transfer.ITransferUtility interface. The new operation supports downloading in parallel parts of the S3 object to a file for improved performance.
	* Added UploadDirectoryWithResponse method to the Amazon.S3.Transfer.ITransferUtility interface.
	* Added DownloadInitiatedEvent, DownloadCompletedEvent, and DownloadFailedEvent events to the Amazon.S3.Transfer.TransferUtility.Download operation.
	* Added UploadDirectoryInitiatedEvent, UploadDirectoryCompletedEvent, and UploadDirectoryFailedEvent events to the Amazon.S3.Transfer.ITransferUtility.UploadDirectory operation.
	* Fixed recursive property definition in the Amazon.S3.Transfer.TransferUtility internal Logger implementation
	* Added ContentLanguage property to the header collection of the Amazon.S3.Model.GetObjectResponse class.
	* Added FailurePolicy property to the Amazon.S3.Transfer.TransferUtilityDownloadDirectoryRequest class to allow configuration of failure handling behavior during directory downloads. The default behavior is set to abort on failure. Users can now choose to either abort the entire operation or continue downloading remaining files when a failure occurs.
	* Added ObjectDownloadFailedEvent event to the Amazon.S3.Transfer.TransferUtility.DownloadDirectory operation to notify users when an individual file download fails during a directory download operation. This event provides details about the failed download, including the original request, the specific file request and the exception encountered.
	* Added FailurePolicy property to the Amazon.S3.Transfer.TransferUtilityUploadDirectoryRequest class to allow configuration of failure handling behavior during directory uploads. The default behavior is set to abort on failure. Users can now choose to either abort the entire operation or continue uploading remaining files when a failure occurs.
	* Added ObjectUploadFailedEvent event to the Amazon.S3.Transfer.TransferUtility.UploadDirectory operation to notify users when an individual file upload fails during a directory upload operation. This event provides details about the failed upload, including the original request, the specific file request and the exception encountered.
* TranscribeService (4.0.5.0)
	* Adds waiters to Amazon Transcribe.

### 4.0.166.0 (2026-01-07 19:16 UTC)
* WorkSpaces (4.0.8.0)
	* Add StateMessage and ProgressPercentage fields to DescribeCustomWorkspaceImageImport API response.
* Core 4.0.3.8
	* Revert [Added ServiceFullName to IServiceMetadata](https://github.com/aws/aws-sdk-net/pull/4266/changes/00ec2fca1e84da1a42bc815f0a1de0b4c912b323) as it caused other service packages to throw an exception.
	* All service and extension packages updated to require new Core

### 4.0.165.0 (2026-01-06 19:15 UTC)
* CostExplorer (4.0.11.0)
	* This release updates existing reservation recommendations API to support deployment model.
* EMRServerless (4.0.8.0)
	* Added support for enabling disk encryption using customer managed AWS KMS keys to CreateApplication, UpdateApplication and StartJobRun APIs.

### 4.0.164.0 (2026-01-05 19:15 UTC)
* CleanRoomsML (4.0.8.0)
	* AWS Clean Rooms ML now supports advanced Spark configurations to optimize SQL performance when creating an MLInputChannel or an audience generation job.
* Core 4.0.3.7
	* Added ServiceFullName to IServiceMetadata
	* All service and extension packages updated to require new Core

### 4.0.163.0 (2026-01-02 19:19 UTC)
* CleanRooms (4.0.13.0)
	* Added support for publishing detailed metrics to CloudWatch for operational monitoring of collaborations, including query performance and resource utilization.
* DSQL (4.0.8.5)
	* Add missing overloads to the async versions of the `GenerateDbConnect` and `GenerateDbConnectAdmin` methods (https://github.com/aws/aws-sdk-net/issues/3123)
* IdentityStore (4.0.5.0)
	* This change introduces "Roles" attribute for User entities supported by AWS Identity Store SDK.
* RDS (4.0.15.3)
	* Add missing overloads to the async versions of the `GenerateAuthToken` method (https://github.com/aws/aws-sdk-net/issues/3123)
* S3 (4.0.16.2)
	* Generate DeleteObjects, DeleteObject and DeleteObjectTagging operations
	* [Breaking Change] IfMatchSize in Amazon.S3.Model.DeleteObjectRequest has been changed to nullable to be consistent with the nullability changes in V4.
* SimpleNotificationService (4.0.2.11)
	* Update `Amazon.SimpleNotificationService.Util.Message.ParseMessage` method not to throw an exception when handling FIFO topics (https://github.com/aws/aws-sdk-net/issues/3000)

