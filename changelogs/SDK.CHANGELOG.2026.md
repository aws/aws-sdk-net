### 3.7.1233.0 (2026-02-27 19:16 UTC)
* ARCRegionswitch (3.7.505.0)
	* Post-Recovery Workflows enable customers to maintain comprehensive disaster recovery automation. This allows customer SREs and leadership to have complete recovery orchestration from failover through post-recovery preparation, ensuring Regions remain ready for subsequent recovery events.
* AWSHealth (3.7.505.0)
	* Updates the regex for validating availabilityZone strings used in the describe events filters.
* Batch (3.7.504.0)
	* This feature allows customers to specify the minimum time (in minutes) that AWS Batch keeps instances running in a compute environment after all jobs on the instance complete
* Bedrock (3.7.513.0)
	* Added four new model lifecycle date fields, startOfLifeTime, endOfLifeTime, legacyTime, and publicExtendedAccessTime. Adds support for using the Converse API with Bedrock Batch inference jobs.
* CognitoIdentityProvider (3.7.505.0)
	* Cognito is introducing a two-secret rotation model for app clients, enabling seamless credential rotation without downtime. Dedicated APIs support passing in a custom secret. Custom secrets need to be at least 24 characters. This eliminates reconfiguration needs and reduces security risks.
* Connect (3.7.530.0)
	* Deprecate EvaluationReviewMetadata's CreatedBy and CreatedTime, add EvaluationReviewMetadata's RequestedBy and RequestedTime
* CustomerProfiles (3.7.505.0)
	* This release introduces an optional SourcePriority parameter to the ProfileObjectType APIs, allowing you to control the precedence of object types when ingesting data from multiple sources. Additionally, WebAnalytics and Device have been added as new StandardIdentifier values.
* KeyspacesStreams (3.7.503.0)
	* Added support for Change Data Capture (CDC) streams with Duration DataType.
* Odb (3.7.505.0)
	* ODB Networking Route Management is a feature improvement which allows for implicit creation and deletion of EC2 Routes in the Peer Network Route Table designated by the customer via new optional input. This feature release is combined with Multiple App-VPC functionality for ODB Network Peering(s).
* RAM (3.7.504.0)
	* Resource owners can now specify ResourceShareConfiguration request parameter for CreateResourceShare API including RetainSharingOnAccountLeaveOrganization boolean parameter

### 3.7.1232.0 (2026-02-26 19:16 UTC)
* AWSMarketplaceMetering (3.7.504.0)
	* Added LicenseArn to ResolveCustomer response and BatchMeterUsage usage records. BatchMeterUsage now accepts LicenseArn in each UsageRecord to report usage at the license level. Added InvalidLicenseException error response for invalid license parameters.
* BackupGateway (3.7.503.0)
	* This release updates GetGateway API to include deprecationDate and softwareVersion in the response, enabling customers to track gateway software versions and upcoming deprecation dates.
* EC2 (3.7.553.0)
	* Add c8id, m8id and hpc8a instance types.
* ECS (3.7.510.0)
	* Adding support for Capacity Reservations for ECS Managed Instances by introducing a new "capacityOptionType" value of "RESERVED" and new field "capacityReservations" for CreateCapacityProvider and UpdateCapacityProvider APIs.
* MarketplaceEntitlementService (3.7.504.0)
	* Added License Arn as a new optional filter for GetEntitlements and LicenseArn field in each entitlement in the response.
* SecurityHub (3.7.507.0)
	* Security Hub added EXTENDED PLAN integration type to DescribeProductsV2 and added metadata.product.vendor name GroupBy support to GetFindingStatisticsV2

### 3.7.1231.0 (2026-02-25 19:16 UTC)
* Batch (3.7.503.6)
	* AWS Batch documentation update for service job capacity units.
* CloudFront (3.7.510.8)
	* Fixed JSON injection vulnerability in CloudFront signed URL/cookie policy generation.
* EC2 (3.7.552.0)
	* Add support for EC2 Capacity Blocks in Local Zones.
* ECR (3.7.508.0)
	* Update repository name regex to comply with OCI Distribution Specification
* Neptune (3.7.504.0)
	* Neptune global clusters now supports tags
* WAFV2 (3.7.505.0)
	* AWS WAF now supports GetTopPathStatisticsByTraffic that provides aggregated statistics on the top URI paths accessed by bot traffic. Use this operation to see which paths receive the most bot traffic, identify the specific bots accessing them, and filter by category, organization, or bot name.
* Core 3.7.500.85
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1230.0 (2026-02-24 19:19 UTC)
* CloudWatch (3.7.507.0)
	* This release adds the APIs (PutAlarmMuteRule, ListAlarmMuteRules, GetAlarmMuteRule and DeleteAlarmMuteRule) to manage a new Cloudwatch resource, AlarmMuteRules. AlarmMuteRules allow customers to temporarily mute alarm notifications during expected downtime periods.
* EC2 (3.7.551.0)
	* Adds httpTokensEnforced property to ModifyInstanceMetadataDefaults API. Set per account or manage organization-wide using declarative policies to prevent IMDSv1-enabled instance launch and block attempts to enable IMDSv1 on existing IMDSv2-only instances.
* Elasticsearch (3.7.503.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* ElementalInference (3.7.500.0)
	* Initial GA launch for AWS Elemental Inference including capabilities of Smart Crop and Live Event Clipping
* MediaLive (3.7.515.0)
	* AWS Elemental MediaLive - Added support for Elemental Inference for Smart Cropping and Clipping features for MediaLive.
* ObservabilityAdmin (3.7.506.0)
	* Adding a new field in the CreateCentralizationRuleForOrganization, UpdateCentralizationRuleForOrganization API and updating the GetCentralizationRuleForOrganization API response to include the new field
* OpenSearchService (3.7.508.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* PartnerCentralSelling (3.7.508.0)
	* Added support for filtering opportunities by target close date in the ListOpportunities API. You can now filter results to return opportunities with a target close date before or after a specified date, enabling more precise opportunity searches based on expected closure timelines.

### 3.7.1229.0 (2026-02-23 19:15 UTC)
* Bedrock (3.7.512.0)
	* Automated Reasoning checks in Amazon Bedrock Guardrails now support fidelity report generation. The new workflow type assesses policy coverage and accuracy against customer documents. The GetAutomatedReasoningPolicyBuildWorkflowResultAssets API adds support for the three new asset types.
* ConnectCases (3.7.508.0)
	* SearchCases API can now accept 25 fields in the request and response as opposed to the previous limit of 10. DeleteField's hard limit of 100 fields per domain has been lifted.
* ControlCatalog (3.7.503.39)
	* Updated ExemptedPrincipalArns parameter documentation for improved accuracy
* DataZone (3.7.517.0)
	* Add workflow properties support to connections APIs
* DynamoDBv2 (3.7.512.0)
	* This change supports the creation of multi-account global tables. It adds one new arguments to UpdateTable, GlobalTableSettingsReplicationMode.
* MediaTailor (3.7.505.0)
	* Updated endpoint rule set for dualstack endpoints. Added a new opt-in option to log raw ad decision server requests for Playback Configurations.
* QuickSight (3.7.512.0)
	* Adds support for SEMISTRUCT to InputColumn Type
* Wickr (3.7.501.0)
	* AWS Wickr now provides APIs to manage your Wickr OpenTDF integration. These APIs enable you to test and save your OpenTDF configuration allowing you to manage rooms based on Trusted Data Format attributes.
* Core 3.7.500.84
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1228.0 (2026-02-20 19:30 UTC)
* AppStream (3.7.506.0)
	* Adding new attribute to disable IMDS v1 APIs for fleet, Image Builder and AppBlockBuilder instances.
* ECS (3.7.509.0)
	* Migrated to Smithy. No functional changes
* SageMakerRuntime (3.7.502.0)
	* Added support for S3OutputPathExtension and Filename parameters to the InvokeEndpointAsync API to allow users to customize the S3 output path and file name for async inference response payloads.
* SignerData (3.7.500.0)
	* This release introduces AWS Signer Data Plane SDK client supporting GetRevocationStatus API. The new client enables AWS PrivateLink connectivity with both private DNS and VPC endpoint URLs.
* SimpleSystemsManagement (3.7.505.0)
	* Add support for AssociationDispatchAssumeRole in AWS SSM State Manager.
* TrustedAdvisor (3.7.503.0)
	* Adding a new enum attribute(statusReason) to TrustedAdvisorAPI response. This attribute explains reasoning behind check status for certain specific scenarios.
* Core 3.7.500.83
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1227.0 (2026-02-19 19:32 UTC)
* BCMDashboards (3.7.502.0)
	* The Billing and Cost Management GetDashboard API now returns identifier for each widget, enabling users to uniquely identify widgets within their dashboards.
* ECR (3.7.507.0)
	* Adds multiple artifact types filter support in ListImageReferrers API.
* PcaConnectorScep (3.7.503.0)
	* AWS Private CA Connector for SCEP now supports AWS PrivateLink, allowing your clients to request certificates from within your Amazon Virtual Private Cloud (VPC) without traversing the public internet. With this launch, you can create VPC endpoints to connect to your SCEP connector privately.

### 3.7.1226.0 (2026-02-18 19:27 UTC)
* CleanRooms (3.7.513.0)
	* This release adds support for federated catalogs in Athena-sourced configured tables.
* CloudWatchEvidently (Removed)
	* Amazon CloudWatch Evidently has been removed from the SDK because it has been discontinued.
* Connect (3.7.529.3)
	* Correcting in-app notifications API documentation.
* IoTAnalytics (Removed)
	* AWS IoT Analytics has been removed from the SDK because it has been discontinued.
* Core 3.7.500.82
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1225.0 (2026-02-17 19:55 UTC)
* EC2 (3.7.550.0)
	* Add Operator field to CreatePlacementGroup and DescribePlacementGroup APIs.
* ManagedGrafana (3.7.503.0)
	* This release updates Amazon Managed Grafana's APIs to support customer managed KMS keys.
* RDS (3.7.514.0)
	* Adds support for the StorageEncryptionType field to specify encryption type for DB clusters, DB instances, snapshots, automated backups, and global clusters.
* WorkSpacesWeb (3.7.507.0)
	* Adds support for branding customization without requiring a custom wallpaper.
* Core 3.7.500.81
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1224.0 (2026-02-16 19:36 UTC)
* ARCRegionswitch (3.7.504.2)
	* Clarify documentation on ARC Region Switch start-plan-execution operation
* EC2 (3.7.549.1)
	* Documentation updates for EC2 Secondary Networks
* ECR (3.7.506.21)
	* Adds support for enabling blob mounting, and removes support for Clair based image scanning
* Kafka (3.7.506.0)
	* Amazon MSK now supports dual-stack connectivity (IPv4 and IPv6) for existing MSK clusters. You can enable dual-stack on existing clusters by specifying the NetworkType parameter in updateConnectivity API.
* KeyManagementService (3.7.506.0)
	* Added support for Decrypt and ReEncrypt API's to use dry run feature without ciphertext for authorization validation
* QConnect (3.7.507.0)
	* Update MessageType enum to include missing types.
* Core 3.7.500.80
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1223.0 (2026-02-13 19:18 UTC)
* CloudWatch (3.7.506.0)
	* Adding new evaluation states that provides information about the alarm evaluation process. Evaluation error Indicates configuration errors in alarm setup that require review and correction. Evaluation failure Indicates temporary CloudWatch issues.
* Connect (3.7.529.0)
	* API release for headerr notifications in the admin website. APIs allow customers to publish brief messages (including URLs) to a specified audience, and a new header icon will indicate when unread messages are available.
* EC2 (3.7.549.0)
	* This release adds geography information to EC2 region and availability zone APIs. DescribeRegions now includes a Geography field, while DescribeAvailabilityZones includes both Geography and SubGeography fields, enabling better geographic classification for AWS regions and zones.
* Inspector2 (3.7.506.0)
	* Added .Net 10 (dotnet10) and Node 24.x (node24.x) runtime support for lambda package scanning
* SageMaker (3.7.529.0)
	* Enable g7e instance type support for SageMaker Processing, and enable single file configuration provisioning for HyperPod Slurm, where customers have the option to use HyperPod API to provide the provisioning parameters.

### 3.7.1222.0 (2026-02-12 19:16 UTC)
* EC2 (3.7.548.0)
	* Launching nested virtualization. This feature allows you to run nested VMs inside virtual (non-bare metal) EC2 instances.

### 3.7.1221.0 (2026-02-11 19:40 UTC)
* Batch (3.7.503.0)
	* Add support for listing jobs by share identifier and getting snapshots of active capacity utilization by job queue and share.
* EC2 (3.7.547.0)
	* R8i instances powered by custom Intel Xeon 6 processors available only on AWS with sustained all-core 3.9 GHz turbo frequency
* EKS (3.7.511.0)
	* This release adds support for Windows Server 2025 in Amazon EKS Managed Node Groups.
* KafkaConnect (3.7.505.0)
	* Support configurable upper limits on task count during autoscaling operations via maxAutoscalingTaskCount parameter.
* S3Tables (3.7.506.0)
	* S3 Tables now supports setting partition specifications and sort orders on tables. Partition specs allow users to define how data is organized using transform functions. Sort order configurations enable users to specify sort directions and null ordering preferences for optimized data layout.
* Core 3.7.500.79
	* Update documentation for `MaxErrorRetry` to call out different default value for `DynamoDB`

### 3.7.1220.0 (2026-02-10 19:24 UTC)
* BedrockAgentCore (3.7.511.0)
	* Added AgentCore browser proxy configuration support, allowing routing of browser traffic through HTTP and HTTPS proxy servers with authentication and bypass rules.
* Connect (3.7.528.0)
	* Amazon Connect now supports per-channel auto-accept and After Contact Work (ACW) timeouts. Configure agents with auto-accept and ACW timeout settings for chat, tasks, emails, and callbacks. Use the new UpdateUserConfig API to manage these settings.
* EKS (3.7.510.0)
	* Introducing an optional policy field, an IAM policy applied to pod identity associations in addition to IAM role policies. When specified, pod permissions are the intersection of IAM role policies and the policy field, ensuring the principle of least privilege.
* Kafka (3.7.505.0)
	* Amazon MSK adds three new APIs, CreateTopic, UpdateTopic, and DeleteTopic for managing Kafka topics in your MSK clusters.
* RDS (3.7.513.0)
	* This release adds backup configuration for RDS and Aurora restores, letting customers set backup retention period and preferred backup window during restore. It also enables viewing backup settings when describing snapshots or automated backups for instances and clusters.
* Core 3.7.500.78
	* Add internal attribute to mark interfaces in `Core` that can be updated without backwards incompatibility issues

### 3.7.1219.0 (2026-02-09 20:22 UTC)
* ConnectCampaignsV2 (3.7.505.0)
	* Add the missing event type for WhatsApp
* EC2 (3.7.546.0)
	* Amazon Secondary Networks is a networking feature that provides high-performance, low-latency connectivity for specialized workloads.
* EKS (3.7.509.0)
	* Amazon EKS adds a new DescribeUpdate update type, VendedLogsUpdate, to support an integration between EKS Auto Mode and Amazon CloudWatch Vended Logs.
* Imagebuilder (3.7.507.0)
	* EC2 Image Builder now supports wildcard patterns in lifecycle policies with recipes and enhances the experience of tag-scoped policies.
* LakeFormation (3.7.504.10)
	* Allow cross account v5 in put data lake settings
* Neptunedata (3.7.503.0)
	* Added edgeOnlyLoad boolean parameter to Neptune bulk load request. When TRUE, files are loaded in order without scanning. When FALSE (default), the loader scans files first, then loads vertex files before edge files automatically.
* PCS (3.7.508.0)
	* Introduces RESUMING state for clusters, compute node groups, and queues.
* Transfer (3.7.505.1)
	* This release adds a documentation update for MdnResponse of type "ASYNC"
* Core 3.7.500.77
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1218.0 (2026-02-06 19:19 UTC)
* BedrockDataAutomationRuntime (3.7.504.0)
	* Add OutputConfiguration to InvokeDataAutomation input and output to support S3 output
* Deadline (3.7.506.0)
	* Adds support for tagging jobs during job creation
* IoTManagedIntegrations (3.7.505.0)
	* Adding support for Custom(General) Authorization in managed integrations for AWS IoT Device Management cloud connectors.
* PartnerCentralSelling (3.7.507.0)
	* Releasing AWS Opportunity Snapshots for SDK release.
* SageMaker (3.7.528.0)
	* Adding g7e instance support in Sagemaker Training

### 3.7.1217.0 (2026-02-05 19:18 UTC)
* ARCRegionswitch (3.7.504.0)
	* Updates documentation for ARC Region switch and provides stronger validation for Amazon Aurora Global Database execution block parameters.
* Athena (3.7.503.0)
	* Reduces the minimum TargetDpus to create or update capacity reservations from 24 to 4.
* BedrockAgentCore (3.7.510.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* BedrockAgentCoreControl (3.7.516.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* Glue (3.7.514.0)
	* This release adds the capability to easily create custom AWS Glue connections to data sources with REST APIs.
* MediaLive (3.7.514.0)
	* Outputs using the AV1 codec in CMAF Ingest output groups in MediaLive now have the ability to specify a target bit depth of 8 or 10.
* NeptuneGraph (3.7.502.38)
	* Minor neptune-graph documentation changes
* RAM (3.7.503.0)
	* Added ListSourceAssociations API. Allows RAM resource share owners to list source associations that determine which sources can access resources through service principal associations. Supports filtering by resource share ARN, source ID, source type, or status, with pagination.
* Transfer (3.7.505.0)
	* Adds support for the customer to send custom HTTP headers and configure an AS2 Connector to receive Asynchronous MDNs from their trading partner
* WorkSpaces (3.7.506.0)
	* Added support for 12 new graphics-optimized compute types - Graphics.g6 (xlarge, 2xlarge, 4xlarge, 8xlarge, 16xlarge), Graphics.gr6 (4xlarge, 8xlarge), Graphics.g6f (large, xlarge, 2xlarge, 4xlarge), and Graphics.gr6f (4xlarge).
* Core 3.7.500.76
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1216.0 (2026-02-04 19:18 UTC)
* BedrockRuntime (3.7.514.0)
	* Added support for structured outputs to Converse and ConverseStream APIs.
* ConnectCases (3.7.507.0)
	* Amazon Connect Cases now supports larger, multi-line text fields with up to 4,100 characters. Administrators can use the Admin UI to select the appropriate configuration (single-line or multi-line) on a per-field basis, improving case documentation capabilities.
* EKS (3.7.508.10)
	* Update delete cluster description
* MediaLive (3.7.513.0)
	* AWS Elemental MediaLive now supports SRT listener mode for inputs and outputs, in addition to the existing SRT caller mode.
* Redshift (3.7.506.10)
	* We have increased the maximum duration for a deferred maintenance window from 45 days to 60 days for Amazon Redshift provisioned clusters. This enhancement provides customers with greater flexibility in scheduling patching and maintenance activities while also maintaining security compliance.
* WorkSpacesWeb (3.7.506.0)
	* Support for configuring and managing custom domain names for WorkSpaces Secure Browser portals.

### 3.7.1215.0 (2026-02-03 19:27 UTC)
* Batch (3.7.502.0)
	* AWS Batch Array Job Visibility feature support. Includes new statusSummaryLastUpdatedAt for array job parent DescribeJobs responses for the last time the statusSummary was updated. Includes both statusSummary and statusSummaryLastUpdatedAt in ListJobs responses for array job parents.
* DynamoDBv2 (3.7.511.0)
	* This change supports the creation of multi-account global tables. It adds two new arguments to CreateTable, GlobalTableSourceArn and GlobalTableSettingsReplicationMode. DescribeTable is also updated to include information about GlobalTableSettingsReplicationMode.
* GeoMaps (3.7.504.0)
	* Added support for optional style parameters in maps, including 3D terrain and 3D Buildings
* Kinesis (3.7.506.0)
	* Adds StreamId parameter to AWS Kinesis Data Streams APIs that is reserved for future use.
* MarketplaceCatalog (3.7.504.0)
	* Adds support for Catalog API us-east-1 dualstack endpoint catalog-marketplace.us-east-1.api.aws
* Organizations (3.7.509.23)
	* Updated the CloseAccount description.
* SSOAdmin (3.7.504.0)
	* Added new Region management APIs to support multi-Region replication in IAM Identity Center.

### 3.7.1214.0 (2026-02-02 19:16 UTC)
* BedrockAgentCoreControl (3.7.515.0)
	* Adds tagging support for AgentCore Evaluations (evaluator and online evaluation config)
* CloudFront (3.7.510.0)
	* Add OriginMTLS support to CloudFront Distribution APIs
* MPA (3.7.503.0)
	* Updates to multi-party approval (MPA) service to add support for multi-factor authentication (MFA) for voting operations.
* Core 3.7.500.75
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1213.0 (2026-01-30 19:26 UTC)
* Connect (3.7.527.0)
	* This release adds Estimated Wait Time support to the GetContactMetrics API for Amazon Connect.
* QuickSight (3.7.511.0)
	* Improve SessionTag usage guidelines in the GenerateEmbedURLForAnonymousUser API documentation. Update the GetIdentityContext document with the region support context.
* Core 3.7.500.74
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1212.0 (2026-01-29 19:41 UTC)
* EC2 (3.7.545.0)
	* G7e instances feature up to 8 NVIDIA RTX PRO 6000 Blackwell Server Edition GPUs with 768 GB of memory and 5th generation Intel Xeon Scalable processors. Supporting up to 192 vCPUs, 1600 Gbps networking bandwidth with EFA, up to 2 TiB of system memory, and up to 15.2 TB of local NVMe SSD storage.
* GameLift (3.7.505.0)
	* Amazon GameLift Servers now supports automatic scaling to and from zero instances based on game session activity. Fleets scale down to zero following a defined period of no game session activity and scale up from zero when game sessions are requested, providing an option for cost optimization.
* Core 3.7.500.73
	* Update `AssumeRoleAWSCredentials` and `AssumeRoleWithWebIdentityCredentials` to dynamically use a 5-minute preempt expiry if the requested role session duration is less than 20 minutes (to prevent the SDK from refreshing credentials unnecessarily) - https://github.com/aws/aws-sdk-net/issues/4313
	* All services packages updated to require new Core

### 3.7.1211.0 (2026-01-28 19:28 UTC)
* CognitoIdentityProvider (3.7.504.0)
	* This release adds support for a new lambda trigger to transform federated user attributes during the authentication with external identity providers on Cognito Managed Login.
* Connect (3.7.526.0)
	* Adds support for filtering search results based on tags assigned to contacts.
* EC2 (3.7.544.0)
	* SearchTransitGatewayRoutes API response now includes a NextToken field, enabling pagination when retrieving large sets of transit gateway routes. Pass the returned NextToken value in subsequent requests to retrieve the next page of results.
* Lambda (3.7.511.0)
	* We are launching ESM Metrics and logging for Kafka ESM to allow customers to monitor Kafka event processing using CloudWatch Metrics and Logs.
* MediaConnect (3.7.505.0)
	* This release adds support for NDI flow sources in AWS Elemental MediaConnect. You can now send content to your MediaConnect transport streams directly from your NDI environment using the new NDI source type. Also adds support for LARGE 4X flow size, which can be used when creating CDI JPEG-XS flows.
* MediaConvert (3.7.507.0)
	* This release adds a follow source mode for audio output channel count, an AES audio frame wrapping option for MXF outputs, and an option to signal DolbyVision compatibility using the SUPPLEMENTAL-CODECS tag in HLS manifests.
* S3 (3.7.510.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.
* S3Control (3.7.505.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.

### 3.7.1210.0 (2026-01-27 19:25 UTC)
* Connect (3.7.525.0)
	* Added support for task attachments. The StartTaskContact API now accepts file attachments, enabling customers to include files (.csv, .doc, .docx, .heic, .jfif, .jpeg, .jpg, .mov, .mp4, .pdf, .png, .ppt, .pptx, .rtf, .txt, etc.) when creating Task contacts. Supports up to 5 attachments per task.
* Deadline (3.7.505.0)
	* AWS Deadline Cloud now supports editing job names and descriptions after submission.
* EC2 (3.7.543.0)
	* Releasing new EC2 instances. C8gb and M8gb with highest EBS performance, M8gn with 600 Gbps network bandwidth, X8aedz and M8azn with 5GHz AMD processors, X8i with Intel Xeon 6 processors and up to 6TB memory, and Mac-m4max with Apple M4 Max chip for 25 percent faster builds.
* MediaLive (3.7.512.0)
	* AWS Elemental MediaLive released two new features that allows customers 1) to set Output Timecode for AV1 encoder, 2) to set a Custom Epoch for CMAF Ingest and MediaPackage V2 output groups when using Pipeline Locking or Disabled Locking modes.
* SageMaker (3.7.527.0)
	* Idle resource sharing enables teams to borrow unused compute resources in your SageMaker HyperPod cluster. This capability maximizes resource utilization by allowing teams to borrow idle compute capacity beyond their allocated compute quotas.
* Core 3.7.500.72
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1209.0 (2026-01-26 19:24 UTC)
* CloudWatchEvidently (3.7.503.0)
	* Deprecate all Evidently API for AWS CloudWatch Evidently deprecation
* ConnectCases (3.7.506.0)
	* Amazon Connect now enables you to use tag-based access controls to define who can access specific cases. You can associate tags with case templates and configure security profiles to determine which users can access cases with those tags.
* EC2 (3.7.542.0)
	* DescribeInstanceTypes API response now includes an additionalFlexibleNetworkInterfaces field, the number of interfaces attachable to an instance when using flexible Elastic Network Adapter (ENA) queues in addition to the base number specified by maximumNetworkInterfaces.
* GroundStation (3.7.503.0)
	* Adds support for AWS Ground Station Telemetry.

### 3.7.1208.0 (2026-01-23 19:16 UTC)
* Connect (3.7.524.0)
	* Amazon Connect now offers public APIs to programmatically configure and run automated tests for contact center experiences. Integrate testing into CICD pipelines, run multiple tests at scale, and retrieve results via API to automate validation of voice interactions and workflows.
* DataZone (3.7.516.0)
	* Added api for deleting data export configuration for a domain
* QConnect (3.7.506.0)
	* Fixes incorrect types in the UpdateAssistantAIAgent API request, adds MESSAGE to TargetType enum, and other minor changes.

### 3.7.1207.0 (2026-01-22 19:28 UTC)
* AutoScaling (3.7.506.0)
	* This release adds support for Amazon EC2 Auto Scaling group deletion protection
* AWSHealth (3.7.504.0)
	* Updates the lower range for the maxResults request property for DescribeAffectedEntities, DescribeAffectedEntitiesForOrganization, DescribeEvents, and DescribeEventsForOrganization API request properties.
* AWSMarketplaceMetering (3.7.503.23)
	* Customer Identifier parameter deprecation date has been removed. For new implementations, we recommend using the CustomerAWSAccountID. Your current integration will continue to work. When updating your implementation, consider migrating to CustomerAWSAccountID for improved integration.
* Budgets (3.7.508.0)
	* Add Budget FilterExpression and Metrics fields to DescribeBudgetPerformanceHistory to support more granular filtering options.
* DynamoDBv2 (3.7.510.0)
	* Adds additional waiters to Amazon DynamoDB.
* EC2 (3.7.541.0)
	* Add better support for fractional GPU instances in DescribeInstanceTypes API. The new fields, logicalGpuCount, gpuPartitionSize, and workload array enable better GPU resource selection and filtering for both full and fractional GPU instance types.
* GameLift (3.7.504.0)
	* Amazon GameLift Servers Realtime now supports Node.js 24.x runtime on the Amazon Linux 2023 operating system.
* GuardDuty (3.7.513.0)
	* Adding new enum value for ScanStatusReason
* VerifiedPermissions (3.7.505.2)
	* Adding documentation to user guide and API documentation for how customers can create new encrypted policy stores by passing in their customer managed key during policy store creation.
* Core 3.7.500.71
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1206.0 (2026-01-21 19:19 UTC)
* BedrockAgentCore (3.7.509.0)
	* Supports custom browser extensions for AgentCore Browser and increased message payloads up to 100KB per message in an Event for AgentCore Memory
* ConfigService (3.7.505.0)
	* AWS Config Conformance Packs now support tag-on-create through PutConformancePack API.
* EC2 (3.7.540.0)
	* Added support of multiple EBS cards. New EbsCardIndex parameter enables attaching volumes to specific EBS cards on supported instance types for improved storage performance.
* QuickSight (3.7.510.0)
	* Added documentation and model for sheet layout groups - allows sheet elements to be grouped, Added documentation and the feature enables admins to have granular control over connectors under actions, Updated API documentation for PDF Export in Snapshot Export APIs
* Core 3.7.500.70
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1205.0 (2026-01-20 19:54 UTC)
* AutoScaling (3.7.505.0)
	* This release adds support for three new filters when describing scaling activities, StartTimeLowerBound, StartTimeUpperBound, and Status.
* BedrockRuntime (3.7.513.0)
	* Added support for extended prompt caching with one hour TTL.
* Keyspaces (3.7.502.0)
	* Adds support for managing table pre-warming in Amazon Keyspaces (for Apache Cassandra)
* Odb (3.7.504.0)
	* Adds support for associating and disassociating IAM roles with Autonomous VM cluster resources through the AssociateIamRoleToResource and DisassociateIamRoleFromResource APIs. The GetCloudAutonomousVmCluster and ListCloudAutonomousVmClusters API responses now include the iamRoles field.
* VerifiedPermissions (3.7.505.0)
	* Amazon Verified Permissions now supports encryption of resources by a customer managed KMS key. Customers can now create new encrypted policy stores by passing in their customer managed key during policy store creation.
* WorkspacesInstances (3.7.503.0)
	* Added billing configuration support for WorkSpaces Instances with monthly and hourly billing modes, including new filtering capabilities for instance type searches.
* Core 3.7.500.69
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1204.0 (2026-01-16 19:28 UTC)
* Connect (3.7.523.0)
	* Adds support to allow customers to create form with Dispute configuration
* DataZone (3.7.515.0)
	* This release adds support for numeric filtering and complex free-text searches cases for the Search and SearchListings APIs.
* Glacier (3.7.503.14)
	* Documentation updates for Amazon Glacier's maintenance mode
* LaunchWizard (3.7.503.0)
	* Added UpdateDeployment, ListDeploymentPatternVersions and GetDeploymentPatternVersion APIs for Launch Wizard
* ResourceExplorer2 (3.7.503.0)
	* Added ViewName to View-related responses and ServiceViewName to GetServiceView response.
* SageMaker (3.7.526.3)
	* Adding security consideration comments for lcc accessing execution role under root access
* Core 3.7.500.68
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1203.0 (2026-01-15 19:21 UTC)
* CleanRooms (3.7.512.0)
	* This release adds support for parameters in PySpark analysis templates.
* Deadline (3.7.504.0)
	* AWS Deadline Cloud now supports tagging Budget resources with ABAC for permissions management and selecting up to 16 filter values in the monitor and Search API.
* EC2 (3.7.539.9)
	* This release includes documentation updates to support up to four Elastic Volume modifications per Amazon EBS volume within a rolling 24-hour period.
* ECS (3.7.508.0)
	* Adds support for configuring FIPS in AWS GovCloud (US) Regions via a new ECS Capacity Provider field fipsEnabled. When enabled, instances launched by the capacity provider will use a FIPS-140 enabled AMI. Instances will use FIPS-140 compliant cryptographic modules and AWS FIPS endpoints.
* Evs (3.7.505.0)
	* A new GetVersions API has been added to retrieve VCF, ESX versions, and EC2 instances provided by Amazon EVS. The CreateEnvironment API now allows you to select a VCF version and the CreateEnvironmentHost API introduces a optional esxVersion parameter.
* LakeFormation (3.7.504.0)
	* API Changes for GTCForLocation feature. Includes a new API, GetTemporaryDataLocationCredentials and updates to the APIs RegisterResource and UpdateResource
* OpenSearchServerless (3.7.505.0)
	* Collection groups in Amazon OpenSearch Serverless enables to organize multiple collections and enable compute resource sharing across collections with different KMS keys. This shared compute model reduces costs by eliminating the need for separate OpenSearch Compute Units (OCUs) for each KMS key.
* QConnect (3.7.505.0)
	* Fix inference configuration shapes for the CreateAIPrompt and UpdateAIPrompt APIs, Modify Text Length Limit for SendMessage API
* Core 3.7.500.67
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1202.0 (2026-01-14 19:22 UTC)
* Connect (3.7.522.0)
	* Amazon Connect makes it easier to manage contact center operating hours by enabling automated scheduling for recurring events like holidays and maintenance windows. Set up recurring patterns (weekly, monthly, etc.) or link to another hours of operation to inherit overrides.
* CostExplorer (3.7.509.4)
	* Cost Categories added support to BillingView data filter expressions through the new costCategories parameter, enabling users to filter billing views by AWS Cost Categories for more granular cost management and allocation.
* EKS (3.7.508.0)
	* Added support for BOTTLEROCKET NVIDIA FIPS AMIs to AMI types in US regions.
* RDS (3.7.512.0)
	* no feature changes. model migrated to Smithy
* Redshift (3.7.506.0)
	* Adds support for enabling extra compute resources for automatic optimization during create and modify operations in Amazon Redshift clusters.
* RedshiftServerless (3.7.504.0)
	* Adds support for enabling extra compute resources for automatic optimization during create and update operations in Amazon Redshift Serverless workgroups.
* SocialMessaging (3.7.503.0)
	* This release clarifies WhatsApp template operations as a resource-authenticated operation via the parent WhatsApp Business Account. It also introduces new parameters for parameter format, CTA URL link tracking, and template body examples, and increases the phone number ID length.
* Core 3.7.500.66
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1201.0 (2026-01-13 19:22 UTC)
* Bedrock (3.7.511.0)
	* This change will increase TestCase guardContent input size from 1024 to 2028 characters and PolicyBuildDocumentDescription from 2000 to 4000 characters
* DataZone (3.7.514.0)
	* Adds support for IAM role subscriptions to Glue table listings via CreateSubscriptionRequest API. Also adds owningIamPrincipalArn filter to List APIs and subscriptionGrantCreationMode parameter to subscription target APIs for controlling grant creation behavior.

### 3.7.1200.0 (2026-01-12 19:22 UTC)
* Billing (3.7.506.0)
	* Cost Categories filtering support to BillingView data filter expressions through the new costCategories parameter, enabling users to filter billing views by AWS Cost Categories for more granular cost management and allocation.
* IoTManagedIntegrations (3.7.504.0)
	* This release introduces WiFi Simple Setup (WSS) enabling device provisioning via barcode scanning with automated network discovery, authentication, and credential provisioning. Additionally, it introduces 2P Device Capability Rediscovery for updating hub-managed device capabilities post-onboarding.
* SageMaker (3.7.526.0)
	* Added ultraServerType to the UltraServerInfo structure to support server type identification for SageMaker HyperPod
* Core 3.7.500.65
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1199.0 (2026-01-09 19:20 UTC)
* BedrockAgentCoreControl (3.7.514.0)
	* Adds optional field "view" to GetMemory API input to give customers control over whether CMK encrypted data such as strategy decryption or override prompts is returned or not.
* CloudFront (3.7.509.0)
	* Added EntityLimitExceeded exception handling to the following API operations AssociateDistributionWebACL, AssociateDistributionTenantWebACL, UpdateDistributionWithStagingConfig
* Glue (3.7.513.0)
	* Adding MaterializedViews task run APIs
* MediaLive (3.7.511.0)
	* MediaPackage v2 output groups in MediaLive can now accept one additional destination for single pipeline channels and up to two additional destinations for standard channels. MediaPackage v2 destinations now support sending to cross region MediaPackage channels.
* TranscribeService (3.7.503.0)
	* Adds waiters to Amazon Transcribe.
* Core 3.7.500.64
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1198.0 (2026-01-07 19:16 UTC)
* WorkSpaces (3.7.505.0)
	* Add StateMessage and ProgressPercentage fields to DescribeCustomWorkspaceImageImport API response.
* Core 3.7.500.63
	* Revert [Added ServiceFullName to IServiceMetadata](https://github.com/aws/aws-sdk-net/pull/4267/changes/65fce5311313e9bcd9e1d9d7f7d3f2d4d82c95ed) as it caused other service packages to throw an exception.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1197.0 (2026-01-06 19:17 UTC)
* CostExplorer (3.7.509.0)
	* This release updates existing reservation recommendations API to support deployment model.
* EMRServerless (3.7.504.0)
	* Added support for enabling disk encryption using customer managed AWS KMS keys to CreateApplication, UpdateApplication and StartJobRun APIs.

### 3.7.1196.0 (2026-01-05 19:16 UTC)
* CleanRoomsML (3.7.506.0)
	* AWS Clean Rooms ML now supports advanced Spark configurations to optimize SQL performance when creating an MLInputChannel or an audience generation job.
* Core 3.7.500.62
	* Added ServiceFullName to IServiceMetadata
	* All services packages updated to require new Core

### 3.7.1195.0 (2026-01-02 19:27 UTC)
* CleanRooms (3.7.511.0)
	* Added support for publishing detailed metrics to CloudWatch for operational monitoring of collaborations, including query performance and resource utilization.
* IdentityStore (3.7.505.0)
	* This change introduces "Roles" attribute for User entities supported by AWS Identity Store SDK.

