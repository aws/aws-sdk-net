### 3.7.797.0 (2024-04-25 18:20 UTC)
* AppSync (3.7.305.0)
	* UpdateGraphQLAPI documentation update and datasource introspection secret arn update
* DynamoDBv2 (3.7.302.23)
	* Add IsSet properties for AttributeValue's SS, BS and NS properties.
* FMS (3.7.301.0)
	* AWS Firewall Manager adds support for network ACL policies to manage Amazon Virtual Private Cloud (VPC) network access control lists (ACLs) for accounts in your organization.
* IVS (3.7.304.0)
	* Bug Fix: IVS does not support arns with the `svs` prefix
* IVSRealTime (3.7.303.0)
	* Bug Fix: IVS Real Time does not support ARNs using the `svs` prefix.
* RDS (3.7.311.10)
	* Updates Amazon RDS documentation for setting local time zones for RDS for Db2 DB instances.
* StepFunctions (3.7.303.0)
	* Add new ValidateStateMachineDefinition operation, which performs syntax checking on the definition of a Amazon States Language (ASL) state machine.
* Core 3.7.303.22
	* Update the `DefaultConfigurationModeResolver` to correctly detect when running on a mobile platform (requires applications using the SDK to target .NET 8 or later)
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.796.0 (2024-04-24 18:21 UTC)
* DataSync (3.7.302.0)
	* This change allows users to disable and enable the schedules associated with their tasks.
* DynamoDBv2 (3.7.302.22)
	* Improve startup by removing assembly scanning from DynamoDBEntryConversion
	* Added missing RequiresUnreferencedCode for DynamoDB high level library converters
	* Removed CLSCompliant(false) attributes
	* Added public documentation
* EC2 (3.7.325.0)
	* Launching capability for customers to enable or disable automatic assignment of public IPv4 addresses to their network interface
* EMRContainers (3.7.303.0)
	* EMRonEKS Service support for SecurityConfiguration enforcement for Spark Jobs.
* EntityResolution (3.7.302.0)
	* Support Batch Unique IDs Deletion.
* GameLift (3.7.302.0)
	* Amazon GameLift releases container fleets support for public preview. Deploy Linux-based containerized game server software for hosting on Amazon GameLift.
* S3 (3.7.307.22)
	* Added missing public documentation
* SimpleSystemsManagement (3.7.304.0)
	* Add SSM DescribeInstanceProperties API to public AWS SDK.
* Core 3.7.303.21
	* Added EnumeratorCancellation attribute for IAsyncEnumerable paginator methods
	* Added missing public docs
	* Removed generated properties that were attempting to override non virtual properties from the base type. The generated properties were the same implementation as the base.
	* Removed the ` = default` from the signature in methods being implemented using explicit interface implementation. The `default` is inherited from the interface and triggers a warning when specified in the implementation.
	* Removed the Obsolete attribute for CorrectedUtcNow. This method is needed when the corrected time without a service endpoint is used.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.795.0 (2024-04-23 18:30 UTC)
* Bedrock (3.7.302.0)
	* This release introduces Model Evaluation and Guardrails for Amazon Bedrock.
* BedrockAgent (3.7.306.0)
	* Introducing the ability to create multiple data sources per knowledge base, specify S3 buckets as data sources from external accounts, and exposing levers to define the deletion behavior of the underlying vector store data.
* BedrockAgentRuntime (3.7.305.0)
	* This release introduces zero-setup file upload support for the RetrieveAndGenerate API. This allows you to chat with your data without setting up a Knowledge Base.
* BedrockRuntime (3.7.302.0)
	* This release introduces Guardrails for Amazon Bedrock.
* CostExplorer (3.7.303.0)
	* Added additional metadata that might be applicable to your reservation recommendations.
* EC2 (3.7.324.0)
	* This release introduces EC2 AMI Deregistration Protection, a new AMI property that can be enabled by customers to protect an AMI against an unintended deregistration. This release also enables the AMI owners to view the AMI 'LastLaunchedTime' in DescribeImages API.
* PI (3.7.300.80)
	* Clarifies how aggregation works for GetResourceMetrics in the Performance Insights API.
* RDS (3.7.311.8)
	* Fix the example ARN for ModifyActivityStreamRequest
* WorkSpacesWeb (3.7.301.0)
	* Added InstanceType and MaxConcurrentSessions parameters on CreatePortal and UpdatePortal Operations as well as the ability to read Customer Managed Key & Additional Encryption Context parameters on supported resources (Portal, BrowserSettings, UserSettings, IPAccessSettings)
* Core 3.7.303.20
	* Added support for Protocol Tests. This includes a new Protocol Test Generator and adjustments to the existing code generator to ensure the protocol tests are passing successfully.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.794.0 (2024-04-22 18:21 UTC)
* BedrockAgent (3.7.305.0)
	* Releasing the support for simplified configuration and return of control
* BedrockAgentRuntime (3.7.304.0)
	* Releasing the support for simplified configuration and return of control
* PaymentCryptography (3.7.303.0)
	* Adding support to TR-31/TR-34 exports for optional headers, allowing customers to add additional metadata (such as key version and KSN) when exporting keys from the service.
* RedshiftServerless (3.7.302.67)
	* Updates description of schedule field for scheduled actions.
* Route53Profiles (3.7.300.0)
	* Route 53 Profiles allows you to apply a central DNS configuration across many VPCs regardless of account.
* SageMaker (3.7.319.0)
	* This release adds support for Real-Time Collaboration and Shared Space for JupyterLab App on SageMaker Studio.
* ServiceDiscovery (3.7.300.79)
	* This release adds examples to several Cloud Map actions.
* Transfer (3.7.306.0)
	* Adding new API to support remote directory listing using SFTP connector
* Core 3.7.303.19
	* Updating sdk-default-configuration.json file.
	* All services packages updated to require new Core

### 3.7.793.0 (2024-04-19 18:21 UTC)
* Glue (3.7.310.0)
	* Adding RowFilter in the response for GetUnfilteredTableMetadata API
* InternetMonitor (3.7.304.0)
	* This update introduces the GetInternetEvent and ListInternetEvents APIs, which provide access to internet events displayed on the Amazon CloudWatch Internet Weather Map.
* Personalize (3.7.302.0)
	* This releases auto training capability while creating a solution and automatically syncing latest solution versions when creating/updating a campaign
* Core 3.7.303.18
	* Updating sdk-default-configuration.json file.
	* All services packages updated to require new Core

### 3.7.792.0 (2024-04-18 18:25 UTC)
* Drs (3.7.304.0)
	* Outpost ARN added to Source Server and Recovery Instance
* EMRServerless (3.7.302.0)
	* This release adds the capability to publish detailed Spark engine metrics to Amazon Managed Service for Prometheus (AMP) for  enhanced monitoring for Spark jobs.
* GuardDuty (3.7.306.0)
	* Added IPv6Address fields for local and remote IP addresses
* IAMRolesAnywhere (3.7.303.0)
	* This release introduces the PutAttributeMapping and DeleteAttributeMapping APIs. IAM Roles Anywhere now provides the capability to define a set of mapping rules, allowing customers to specify which data is extracted from their X.509 end-entity certificates.
* QuickSight (3.7.309.0)
	* This release adds support for the Cross Sheet Filter and Control features, and support for warnings in asset imports for any permitted errors encountered during execution
* SageMaker (3.7.318.0)
	* Removed deprecated enum values and updated API documentation.
* WorkSpaces (3.7.303.0)
	* Adds new APIs for managing and sharing WorkSpaces BYOL configuration across accounts.
* Core 3.7.303.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.791.0 (2024-04-17 18:34 UTC)
* EC2 (3.7.323.0)
	* Documentation updates for Elastic Compute Cloud (EC2).
* QBusiness (3.7.302.0)
	* This release adds support for IAM Identity Center (IDC) as the identity gateway for Q Business. It also allows users to provide an explicit intent for Q Business to identify how the Chat request should be handled.
* Core 3.7.303.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.790.0 (2024-04-16 18:29 UTC)
* BedrockAgent (3.7.304.0)
	* For Create Agent API, the agentResourceRoleArn parameter is no longer required.
* EMRServerless (3.7.301.0)
	* This release adds support for shuffle optimized disks that allow larger disk sizes and higher IOPS to efficiently run shuffle heavy workloads.
* EntityResolution (3.7.301.0)
	* Cross Account Resource Support .
* IoTWireless (3.7.302.0)
	* Add PublicGateways in the GetWirelessStatistics call response, indicating the LoRaWAN public network accessed by the device.
* LakeFormation (3.7.303.0)
	* This release adds Lake Formation managed RAM support for the 4 APIs - "DescribeLakeFormationIdentityCenterConfiguration", "CreateLakeFormationIdentityCenterConfiguration", "DescribeLakeFormationIdentityCenterConfiguration", and "DeleteLakeFormationIdentityCenterConfiguration"
* MainframeModernization (3.7.301.0)
	* Adding new ListBatchJobRestartPoints API and support for restart batch job.
* MediaPackageV2 (3.7.302.0)
	* Dash v2 is a MediaPackage V2 feature to support egressing on DASH manifest format.
* Outposts (3.7.303.0)
	* This release adds new APIs to allow customers to configure their Outpost capacity at order-time.
* WellArchitected (3.7.301.0)
	* AWS Well-Architected now has a Connector for Jira to allow customers to efficiently track workload risks and improvement efforts and create closed-loop mechanisms.
* Core 3.7.303.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.789.0 (2024-04-12 18:23 UTC)
* CloudFormation (3.7.307.0)
	* Adding support for the new parameter "IncludePropertyValues" in the CloudFormation DescribeChangeSet API. When this parameter is included, the DescribeChangeSet response will include more detailed information such as before and after values for the resource properties that will change.
* ConfigService (3.7.302.46)
	* Updates documentation for AWS Config
* Glue (3.7.309.0)
	* Modifying request for GetUnfilteredTableMetadata for view-related fields.
* HealthLake (3.7.302.0)
	* Added new CREATE_FAILED status for data stores. Added new errorCause to DescribeFHIRDatastore API and ListFHIRDatastores API response for additional insights into data store creation and deletion workflows.
* IoTFleetHub (3.7.300.75)
	* Documentation updates for AWS IoT Fleet Hub to clarify that Fleet Hub supports organization instance of IAM Identity Center.
* KeyManagementService (3.7.302.0)
	* This feature supports the ability to specify a custom rotation period for automatic key rotations, the ability to perform on-demand key rotations, and visibility into your key material rotations.
* MediaTailor (3.7.305.0)
	* Added InsertionMode to PlaybackConfigurations. This setting controls whether players can use stitched or guided ad insertion. The default for players that do not specify an insertion mode is stitched.
* NeptuneGraph (3.7.305.10)
	* Update to API documentation to resolve customer reported issues.
* Outposts (3.7.302.0)
	* This release adds EXPEDITORS as a valid shipment carrier.
* Redshift (3.7.305.0)
	* Adds support for Amazon Redshift DescribeClusterSnapshots API to include Snapshot ARN response field.
* Transfer (3.7.305.0)
	* This change releases support for importing self signed certificates to the Transfer Family for sending outbound file transfers over TLS/HTTPS.

### 3.7.788.0 (2024-04-11 18:22 UTC)
* Batch (3.7.305.0)
	* This release adds the task properties field to attempt details and the name field on EKS container detail.
* CloudFront (3.7.302.0)
	* CloudFront origin access control extends support to AWS Lambda function URLs and AWS Elemental MediaPackage v2 origins.
* CloudWatch (3.7.304.0)
	* This release adds support for Metric Characteristics for CloudWatch Anomaly Detection. Anomaly Detector now takes Metric Characteristics object with Periodic Spikes boolean field that tells Anomaly Detection that spikes that repeat at the same time every week are part of the expected pattern.
* CodeBuild (3.7.306.2)
	* Support access tokens for Bitbucket sources
* IdentityManagement (3.7.301.0)
	* For CreateOpenIDConnectProvider API, the ThumbprintList parameter is no longer required.
* MediaLive (3.7.307.0)
	* AWS Elemental MediaLive introduces workflow monitor, a new feature that enables the visualization and monitoring of your media workflows. Create signal maps of your existing workflows and monitor them by creating notification and monitoring template groups.
* Omics (3.7.301.0)
	* This release adds support for retrieval of S3 direct access metadata on sequence stores and read sets, and adds support for SHA256up and SHA512up HealthOmics ETags.
* Pipes (3.7.303.0)
	* LogConfiguration ARN validation fixes
* RDS (3.7.311.2)
	* Updates Amazon RDS documentation for Standard Edition 2 support in RDS Custom for Oracle.
* S3Control (3.7.305.39)
	* Documentation updates for Amazon S3-control.
* WAFV2 (3.7.304.0)
	* Adds an updated version of smoke tests, including smithy trait, for SDK testing.
* Core 3.7.303.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.787.0 (2024-04-10 18:19 UTC)
* CleanRooms (3.7.304.0)
	* AWS Clean Rooms Differential Privacy is now fully available. Differential privacy protects against user-identification attempts.
* Connect (3.7.316.0)
	* This release adds new Submit Auto Evaluation Action for Amazon Connect Rules.
* NetworkMonitor (3.7.301.2)
	* Examples were added to CloudWatch Network Monitor commands.
* QConnect (3.7.304.0)
	* This release adds a new QiC public API updateSession and updates an existing QiC public API createSession
* Rekognition (3.7.302.0)
	* Added support for ContentType to content moderation detections.
* SupplyChain (3.7.301.0)
	* This release includes API SendDataIntegrationEvent for AWS Supply Chain
* WorkSpacesThinClient (3.7.302.0)
	* Adding tags field to SoftwareSet. Removing tags fields from Summary objects. Changing the list of exceptions in tagging APIs. Fixing an issue where the SDK returns empty tags in Get APIs.
* Core 3.7.303.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.786.0 (2024-04-09 18:17 UTC)
* CodeBuild (3.7.306.0)
	* Add new webhook filter types for GitHub webhooks
* MediaConvert (3.7.304.0)
	* This release includes support for bringing your own fonts to use for burn-in or DVB-Sub captioning workflows.
* Pinpoint (3.7.301.0)
	* The OrchestrationSendingRoleArn has been added to the email channel and is used to send emails from campaigns or journeys.
* RDS (3.7.311.0)
	* This release adds support for specifying the CA certificate to use for the new db instance when restoring from db snapshot, restoring from s3, restoring to point in time, and creating a db instance read replica.
* Core 3.7.303.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.785.0 (2024-04-08 18:13 UTC)
* ControlCatalog (3.7.300.0)
	* This is the initial SDK release for AWS Control Catalog, a central catalog for AWS managed controls. This release includes 3 new APIs - ListDomains, ListObjectives, and ListCommonControls - that vend high-level data to categorize controls across the AWS platform.
* Mgn (3.7.302.0)
	* Added USE_SOURCE as default option to LaunchConfigurationTemplate bootMode parameter.
* NetworkMonitor (3.7.301.0)
	* Updated the allowed monitorName length for CloudWatch Network Monitor.
* S3 (3.7.307.12)
	* Update the GetObject and GetObjectMetadata operations to handle invalid timestamp formats in the expires header; a new property ExpiresString will contain the unparsed value returned from S3 (regardless if parsing succeeds or not) and should be used instead of Expires (which has been deprecated).
* Core 3.7.303.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.784.0 (2024-04-05 18:14 UTC)
* QuickSight (3.7.308.0)
	* Adding IAMIdentityCenterInstanceArn parameter to CreateAccountSubscription
* ResourceGroups (3.7.301.0)
	* Added a new QueryErrorCode RESOURCE_TYPE_NOT_SUPPORTED that is returned by the ListGroupResources operation if the group query contains unsupported resource types.
* VerifiedPermissions (3.7.305.0)
	* Adding BatchIsAuthorizedWithToken API which supports multiple authorization requests against a PolicyStore given a bearer token.
* Core 3.7.303.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.783.0 (2024-04-04 18:24 UTC)
* B2bi (3.7.303.0)
	* Adding support for X12 5010 HIPAA EDI version and associated transaction sets.
* CleanRooms (3.7.303.0)
	* Feature: New schemaStatusDetails field to the existing Schema object that displays a status on Schema API responses to show whether a schema is queryable or not. New BatchGetSchemaAnalysisRule API to retrieve multiple schemaAnalysisRules using a single API call.
* EC2 (3.7.322.0)
	* Amazon EC2 G6 instances powered by NVIDIA L4 Tensor Core GPUs can be used for a wide range of graphics-intensive and machine learning use cases. Gr6 instances also feature NVIDIA L4 GPUs and can be used for graphics workloads with higher memory requirements.
* EMRContainers (3.7.302.0)
	* This release adds support for integration with EKS AccessEntry APIs to enable automatic Cluster Access for EMR on EKS.
* IVS (3.7.303.0)
	* API update to include an SRT ingest endpoint and passphrase for all channels.
* VerifiedPermissions (3.7.304.0)
	* Adds GroupConfiguration field to Identity Source API's
* Core 3.7.303.9
	* Address obsolete warnings in marshallers
	* Address warnings in STS and SNS
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.782.0 (2024-04-03 18:24 UTC)
* CleanRoomsML (3.7.302.0)
	* The release includes a public SDK for AWS Clean Rooms ML APIs, making them globally available to developers worldwide.
* CloudFormation (3.7.306.0)
	* This release would return a new field - PolicyAction in cloudformation's existed DescribeChangeSetResponse, showing actions we are going to apply on the physical resource (e.g., Delete, Retain) according to the user's template
* DataZone (3.7.303.0)
	* This release supports the feature of dataQuality to enrich asset with dataQualityResult in Amazon DataZone.
* DocDB (3.7.303.0)
	* This release adds Global Cluster Switchover capability which enables you to change your global cluster's primary AWS Region, the region that serves writes, while preserving the replication between all regions in the global cluster.
* GroundStation (3.7.301.0)
	* This release adds visibilityStartTime and visibilityEndTime to DescribeContact and ListContacts responses.
* Lambda (3.7.305.0)
	* Add Ruby 3.3 (ruby3.3) support to AWS Lambda
* MediaLive (3.7.306.0)
	* Cmaf Ingest outputs are now supported in Media Live
* MedicalImaging (3.7.301.0)
	* SearchImageSets API now supports following enhancements - Additional support for searching on UpdatedAt and SeriesInstanceUID - Support for searching existing filters between dates/times - Support for sorting the search result by Ascending/Descending - Additional parameters returned in the response
* Transfer (3.7.304.0)
	* Add ability to specify Security Policies for SFTP Connectors
* Core 3.7.303.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.781.0 (2024-04-02 18:21 UTC)
* ECS (3.7.305.29)
	* Documentation only update for Amazon ECS.
* Glue (3.7.308.0)
	* Adding View related fields to responses of read-only Table APIs.
* IAMRolesAnywhere (3.7.302.0)
	* This release increases the limit on the roleArns request parameter for the *Profile APIs that support it. This parameter can now take up to 250 role ARNs.
* Ivschat (3.7.301.62)
	* Doc-only update. Changed "Resources" to "Key Concepts" in docs and updated text.
* SecurityHub (3.7.304.7)
	* Documentation updates for AWS Security Hub
* Core 3.7.303.7
	* Enable treat warnings as errors for Core
	* Remove CLS complaint warnings when building the SDK
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.780.0 (2024-04-01 18:59 UTC)
* CloudWatch (3.7.303.0)
	* This release adds support for CloudWatch Anomaly Detection on cross-account metrics. SingleMetricAnomalyDetector and MetricDataQuery inputs to Anomaly Detection APIs now take an optional AccountId field.
* DataZone (3.7.302.0)
	* This release supports the feature of AI recommendations for descriptions to enrich the business data catalog in Amazon DataZone.
* Deadline (3.7.300.0)
	* AWS Deadline Cloud is a new fully managed service that helps customers set up, deploy, and scale rendering projects in minutes, so they can improve the efficiency of their rendering pipelines and take on more projects.
* ElasticMapReduce (3.7.304.14)
	* This release fixes a broken link in the documentation.
* Lightsail (3.7.304.0)
	* This release adds support to upgrade the TLS version of the distribution.
* Core 3.7.303.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.779.0 (2024-03-29 18:21 UTC)
* B2bi (3.7.302.0)
	* Supporting new EDI X12 transaction sets for X12 versions 4010, 4030, and 5010.
* CodeBuild (3.7.305.0)
	* Add new fleet status code for Reserved Capacity.
* CodeConnections (3.7.300.0)
	* Duplicating the CodeStar Connections service into the new, rebranded AWS CodeConnections service.
* InternetMonitor (3.7.303.0)
	* This release adds support to allow customers to track cross account monitors through ListMonitor, GetMonitor, ListHealthEvents, GetHealthEvent, StartQuery APIs.
* IoTWireless (3.7.301.0)
	* Add support for retrieving key historical and live metrics for LoRaWAN devices and gateways
* MarketplaceCatalog (3.7.304.0)
	* This release enhances the ListEntities API to support ResaleAuthorizationId filter and sort for OfferEntity in the request and the addition of a ResaleAuthorizationId field in the response of OfferSummary.
* NeptuneGraph (3.7.305.0)
	* Add the new API Start-Import-Task for Amazon Neptune Analytics.
* S3 (3.7.307.6)
	* Fix: Update CopyObjectRequestMarshaller to throw ArgumentException for missing properties
* SageMaker (3.7.317.0)
	* This release adds support for custom images for the CodeEditor App on SageMaker Studio
* Core 3.7.303.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.778.0 (2024-03-28 18:27 UTC)
* CodeCatalyst (3.7.303.0)
	* This release adds support for understanding pending changes to subscriptions by including two new response parameters for the GetSubscription API for Amazon CodeCatalyst.
* ComputeOptimizer (3.7.302.0)
	* This release enables AWS Compute Optimizer to analyze and generate recommendations with a new customization preference, Memory Utilization.
* EC2 (3.7.321.0)
	* Amazon EC2 C7gd, M7gd and R7gd metal instances with up to 3.8 TB of local NVMe-based SSD block-level storage have up to 45% improved real-time NVMe storage performance than comparable Graviton2-based instances.
* EKS (3.7.305.0)
	* Add multiple customer error code to handle customer caused failure when managing EKS node groups
* GuardDuty (3.7.305.0)
	* Add EC2 support for GuardDuty Runtime Monitoring auto management.
* NeptuneGraph (3.7.304.0)
	* Update ImportTaskCancelled waiter to evaluate task state correctly and minor documentation changes.
* OAM (3.7.301.0)
	* This release adds support for sharing AWS::InternetMonitor::Monitor resources.
* QuickSight (3.7.307.0)
	* Amazon QuickSight: Adds support for setting up VPC Endpoint restrictions for accessing QuickSight Website.
* Core 3.7.303.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.777.0 (2024-03-27 18:35 UTC)
* Batch (3.7.304.0)
	* This feature allows AWS Batch to support configuration of imagePullSecrets and allowPrivilegeEscalation for jobs running on EKS
* BedrockAgent (3.7.303.0)
	* This changes introduces metadata documents statistics and also updates the documentation for bedrock agent.
* BedrockAgentRuntime (3.7.303.0)
	* This release introduces filtering support on Retrieve and RetrieveAndGenerate APIs.
* ElastiCache (3.7.302.0)
	* Added minimum capacity to  Amazon ElastiCache Serverless. This feature allows customer to ensure minimum capacity even without current load
* SecretsManager (3.7.302.38)
	* Documentation updates for Secrets Manager
* Core 3.7.303.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.776.0 (2024-03-26 18:25 UTC)
* BedrockAgentRuntime (3.7.302.0)
	* This release adds support to customize prompts sent through the RetrieveAndGenerate API in Agents for Amazon Bedrock.
* CostExplorer (3.7.302.0)
	* Adds support for backfill of cost allocation tags, with new StartCostAllocationTagBackfill and ListCostAllocationTagBackfillHistory API.
* EC2 (3.7.320.0)
	* Documentation updates for Elastic Compute Cloud (EC2).
* ECS (3.7.305.24)
	* This is a documentation update for Amazon ECS.
* Finspace (3.7.306.0)
	* Add new operation delete-kx-cluster-node and add status parameter to list-kx-cluster-node operation.
* Core 3.7.303.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.775.0 (2024-03-25 18:28 UTC)
* CodeBuild (3.7.304.0)
	* Supporting GitLab and GitLab Self Managed as source types in AWS CodeBuild.
* EC2 (3.7.319.0)
	* Added support for ModifyInstanceMetadataDefaults and GetInstanceMetadataDefaults to set Instance Metadata Service account defaults
* ECS (3.7.305.23)
	* Documentation only update for Amazon ECS.
* EMRContainers (3.7.301.0)
	* This release increases the number of supported job template parameters from 20 to 100.
* GlobalAccelerator (3.7.301.0)
	* AWS Global Accelerator now supports cross-account sharing for bring your own IP addresses.
* MediaLive (3.7.305.0)
	* Exposing TileMedia H265 options
* SageMaker (3.7.316.0)
	* Introduced support for the following new instance types on SageMaker Studio for JupyterLab and CodeEditor applications: m6i, m6id, m7i, c6i, c6id, c7i, r6i, r6id, r7i, and p5
* Core 3.7.303.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.774.0 (2024-03-22 18:19 UTC)
* IAMRolesAnywhere (3.7.301.0)
	* This release relaxes constraints on the durationSeconds request parameter for the *Profile APIs that support it. This parameter can now take on values that go up to 43200.
* Kendra (3.7.301.0)
	* Documentation update, March 2024. Corrects some docs for Amazon Kendra.
* KinesisFirehose (3.7.304.8)
	* Updates Amazon Firehose documentation for message regarding Enforcing Tags IAM Policy.
* Pricing (3.7.302.0)
	* Add ResourceNotFoundException to ListPriceLists and GetPriceListFileUrl APIs
* SecurityHub (3.7.304.0)
	* Added new resource detail object to ASFF, including resource for LastKnownExploitAt
* Core 3.7.303.0
	* Add InitializeCollections property to AWSConfigs. If true types used for request and responses for service calls initializes collection properties to empty collection. If false the collections will be initialized to null. The default value is true.
	* Fixed issue overriding OS configured proxy for .NET Framework targets.
	* All services packages updated to require new Core

### 3.7.773.0 (2024-03-21 18:14 UTC)
* CodeArtifact (3.7.301.0)
	* This release adds Package groups to CodeArtifact so you can more conveniently configure package origin controls for multiple packages.

### 3.7.772.0 (2024-03-20 18:28 UTC)
* AccessAnalyzer (3.7.303.0)
	* This release adds support for policy validation and external access findings for DynamoDB tables and streams. IAM Access Analyzer helps you author functional and secure resource-based policies and identify cross-account access. Updated service API, documentation, and paginators.
* CodeBuild (3.7.303.2)
	* This release adds support for new webhook events (RELEASED and PRERELEASED) and filter types (TAG_NAME and RELEASE_NAME).
* Connect (3.7.315.0)
	* This release updates the *InstanceStorageConfig APIs to support a new ResourceType: REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS. Use this resource type to enable streaming for real-time analysis of chat contacts and to associate a Kinesis stream where real-time analysis chat segments will be published.
* DynamoDBv2 (3.7.302.0)
	* This release introduces 3 new APIs ('GetResourcePolicy', 'PutResourcePolicy' and 'DeleteResourcePolicy') and modifies the existing 'CreateTable' API for the resource-based policy support. It also modifies several APIs to accept a 'TableArn' for the 'TableName' parameter.
* ManagedBlockchainQuery (3.7.304.0)
	* AMB Query: update GetTransaction to include transactionId as input
* SavingsPlans (3.7.301.0)
	* Introducing the Savings Plans Return feature enabling customers to return their Savings Plans within 7 days of purchase.

### 3.7.771.0 (2024-03-19 18:16 UTC)
* CloudFormation (3.7.305.1)
	* Documentation update, March 2024. Corrects some formatting.
* CloudWatchLogs (3.7.305.0)
	* Update LogSamples field in Anomaly model to be a list of LogEvent
* EC2 (3.7.318.0)
	* This release adds the new DescribeMacHosts API operation for getting information about EC2 Mac Dedicated Hosts. Users can now see the latest macOS versions that their underlying Apple Mac can support without needing to be updated.
* Finspace (3.7.305.0)
	* Adding new attributes readWrite and onDemand to dataview models for Database Maintenance operations.
* ManagedBlockchainQuery (3.7.303.0)
	* Introduces a new API for Amazon Managed Blockchain Query: ListFilteredTransactionEvents.

### 3.7.770.0 (2024-03-18 18:42 UTC)
* CloudFormation (3.7.305.0)
	* This release supports for a new API ListStackSetAutoDeploymentTargets, which provider auto-deployment configuration as a describable resource. Customers can now view the specific combinations of regions and OUs that are being auto-deployed.
* KeyManagementService (3.7.301.0)
	* Adds the ability to use the default policy name by omitting the policyName parameter in calls to PutKeyPolicy and GetKeyPolicy
* MediaTailor (3.7.304.0)
	* This release adds support to allow customers to show different content within a channel depending on metadata associated with the viewer.
* RDS (3.7.310.0)
	* This release launches the ModifyIntegration API and support for data filtering for zero-ETL Integrations.
* S3 (3.7.307.0)
	* Fix two issues with response root node names.
* TimestreamQuery (3.7.300.59)
	* Documentation updates, March 2024
* Core 3.7.302.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.769.0 (2024-03-15 18:28 UTC)
* Backup (3.7.304.0)
	* This release introduces a boolean attribute ManagedByAWSBackupOnly as part of ListRecoveryPointsByResource api to filter the recovery points based on ownership. This attribute can be used to filter out the recovery points protected by AWSBackup.
* CodeBuild (3.7.303.0)
	* AWS CodeBuild now supports overflow behavior on Reserved Capacity.
* Connect (3.7.314.0)
	* This release adds Hierarchy based Access Control fields to Security Profile public APIs and adds support for UserAttributeFilter to SearchUsers API.
* EC2 (3.7.317.0)
	* Add media accelerator and neuron device information on the describe instance types API.
* KinesisAnalyticsV2 (3.7.302.0)
	* Support for Flink 1.18 in Managed Service for Apache Flink
* S3 (3.7.306.2)
	* Documentation updates for Amazon S3.
* SageMaker (3.7.315.0)
	* Adds m6i, m6id, m7i, c6i, c6id, c7i, r6i r6id, r7i, p5 instance type support to Sagemaker Notebook Instances and miscellaneous wording fixes for previous Sagemaker documentation.
* WorkSpacesThinClient (3.7.301.0)
	* Removed unused parameter kmsKeyArn from UpdateDeviceRequest
* Core 3.7.302.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.768.0 (2024-03-14 18:25 UTC)
* Amplify (3.7.301.5)
	* Documentation updates for Amplify. Identifies the APIs available only to apps created using Amplify Gen 1.
* EC2InstanceConnect (3.7.301.0)
	* This release includes a new exception type "SerialConsoleSessionUnsupportedException" for SendSerialConsoleSSHPublicKey API.
* ElasticLoadBalancingV2 (3.7.302.13)
	* This release allows you to configure HTTP client keep-alive duration for communication between clients and Application Load Balancers.
* FIS (3.7.302.0)
	* This release adds support for previewing target resources before running a FIS experiment. It also adds resource ARNs for actions, experiments, and experiment templates to API responses.
* IoTRoboRunner (Removed)
	* AWS IoT RoboRunner has been removed from the SDK because it has been discontinued.
* RDS (3.7.309.4)
	* Updates Amazon RDS documentation for EBCDIC collation for RDS for Db2.
* SecretsManager (3.7.302.32)
	* Doc only update for Secrets Manager
* TimestreamInfluxDB (3.7.300.0)
	* This is the initial SDK release for Amazon Timestream for InfluxDB. Amazon Timestream for InfluxDB is a new time-series database engine that makes it easy for application developers and DevOps teams to run InfluxDB databases on AWS for near real-time time-series applications using open source APIs.
* Core 3.7.302.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.767.0 (2024-03-13 18:17 UTC)
* IVSRealTime (3.7.302.0)
	* adds support for multiple new composition layout configuration options (grid, pip)
* KinesisAnalyticsV2 (3.7.301.0)
	* Support new RuntimeEnvironmentUpdate parameter within UpdateApplication API allowing callers to change the Flink version upon which their application runs.
* S3 (3.7.306.0)
	* This release makes the default option for S3 on Outposts request signing to use the SigV4A algorithm when using AWS Common Runtime (CRT).
	* Add mime code mapping for .csv file extension.
* Core 3.7.302.17
	* Update endpoint resolver to handle scenarios where both SigV4 and SigV4A authentication schemes are defined for the same service
	* All services packages updated to require new Core

### 3.7.766.0 (2024-03-12 18:17 UTC)
* CloudFormation (3.7.304.2)
	* CloudFormation documentation update for March, 2024
* Connect (3.7.313.0)
	* This release increases MaxResults limit to 500 in request for SearchUsers, SearchQueues and SearchRoutingProfiles APIs of Amazon Connect.
* EC2 (3.7.316.2)
	* Documentation updates for Amazon EC2.
* Kafka (3.7.302.0)
	* Added support for specifying the starting position of topic replication in MSK-Replicator.
* SimpleSystemsManagement (3.7.303.4)
	* March 2024 doc-only updates for Systems Manager.

### 3.7.765.0 (2024-03-11 18:46 UTC)
* CodeStarconnections (3.7.305.0)
	* Added a sync configuration enum to disable publishing of deployment status to source providers (PublishDeploymentStatus). Added a sync configuration enum (TriggerStackUpdateOn) to only trigger changes.
* ElastiCache (3.7.301.46)
	* Revisions to API text that are now to be carried over to SDK text, changing usages of "SFO" in code examples to "us-west-1", and some other typos.
* MediaPackageV2 (3.7.301.0)
	* This release enables customers to safely update their MediaPackage v2 channel groups, channels and origin endpoints using entity tags.

### 3.7.764.0 (2024-03-08 19:19 UTC)
* Batch (3.7.303.0)
	* This release adds JobStateTimeLimitActions setting to the Job Queue API. It allows you to configure an action Batch can take for a blocking job in front of the queue after the defined period of time. The new parameter applies for ECS, EKS, and FARGATE Job Queues.
* BedrockAgentRuntime (3.7.301.2)
	* Documentation update for Bedrock Runtime Agent
* CloudTrail (3.7.304.0)
	* Added exceptions to CreateTrail, DescribeTrails, and ListImportFailures APIs.
* CodeBuild (3.7.302.16)
	* This release adds support for a new webhook event: PULL_REQUEST_CLOSED.
* CognitoIdentityProvider (3.7.303.0)
	* Add ConcurrentModificationException to SetUserPoolMfaConfig
* GuardDuty (3.7.304.0)
	* Add RDS Provisioned and Serverless Usage types
* Transfer (3.7.303.0)
	* Added DES_EDE3_CBC to the list of supported encryption algorithms for messages sent with an AS2 connector.
* Core 3.7.302.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.763.0 (2024-03-07 19:29 UTC)
* AppConfig (3.7.301.0)
	* AWS AppConfig now supports dynamic parameters, which enhance the functionality of AppConfig Extensions by allowing you to provide parameter values to your Extensions at the time you deploy your configuration.
* EC2 (3.7.316.0)
	* This release adds an optional parameter to RegisterImage and CopyImage APIs to support tagging AMIs at the time of creation.
* Lambda (3.7.304.3)
	* Documentation updates for AWS Lambda
* ManagedGrafana (3.7.301.0)
	* Adds support for the new GrafanaToken as part of the Amazon Managed Grafana Enterprise plugins upgrade to associate your AWS account with a Grafana Labs account.
* PaymentCryptographyData (3.7.301.0)
	* AWS Payment Cryptography EMV Decrypt Feature  Release
* RDS (3.7.309.1)
	* Updates Amazon RDS documentation for io2 storage for Multi-AZ DB clusters
* Snowball (3.7.300.55)
	* Doc-only update for change to EKS-Anywhere ordering.
* WAFV2 (3.7.303.0)
	* You can increase the max request body inspection size for some regional resources. The size setting is in the web ACL association config. Also, the AWSManagedRulesBotControlRuleSet EnableMachineLearning setting now takes a Boolean instead of a primitive boolean type, for languages like Java.
* WorkSpaces (3.7.302.8)
	* Added note for user decoupling

### 3.7.762.0 (2024-03-06 19:53 UTC)
* DynamoDBv2 (3.7.301.18)
	* Doc only updates for DynamoDB documentation
* Imagebuilder (3.7.303.0)
	* Add PENDING status to Lifecycle Execution resource status. Add StartTime and EndTime to ListLifecycleExecutionResource API response.
* MWAA (3.7.303.13)
	* Amazon MWAA adds support for Apache Airflow v2.8.1.
* RDS (3.7.309.0)
	* Updated the input of CreateDBCluster and ModifyDBCluster to support setting CA certificates. Updated the output of DescribeDBCluster to show current CA certificate setting value.
* Redshift (3.7.304.8)
	* Update for documentation only. Covers port ranges, definition updates for data sharing, and definition updates to cluster-snapshot documentation.
* VerifiedPermissions (3.7.303.0)
	* Deprecating details in favor of configuration for GetIdentitySource and ListIdentitySources APIs.

### 3.7.761.0 (2024-03-05 19:17 UTC)
* APIGateway (3.7.300.56)
	* Documentation updates for Amazon API Gateway
* Chatbot (3.7.300.3)
	* Minor update to documentation.
* Organizations (3.7.302.0)
	* This release contains an endpoint addition
* SimpleEmailV2 (3.7.301.0)
	* Adds support for providing custom headers within SendEmail and SendBulkEmail for SESv2.

### 3.7.760.0 (2024-03-04 19:15 UTC)
* CloudFormation (3.7.304.0)
	* Add DetailedStatus field to DescribeStackEvents and DescribeStacks APIs
* FSx (3.7.304.0)
	* Added support for creating FSx for NetApp ONTAP file systems with up to 12 HA pairs, delivering up to 72 GB/s of read throughput and 12 GB/s of write throughput.
* Organizations (3.7.301.0)
	* Documentation update for AWS Organizations

### 3.7.759.1 (2024-03-01 19:13 UTC)
* AccessAnalyzer (3.7.302.44)
	* Fixed a typo in description field.
* AutoScaling (3.7.302.13)
	* With this release, Amazon EC2 Auto Scaling groups, EC2 Fleet, and Spot Fleet improve the default price protection behavior of attribute-based instance type selection of Spot Instances, to consistently select from a wide range of instance types.
* EC2 (3.7.315.2)
	* With this release, Amazon EC2 Auto Scaling groups, EC2 Fleet, and Spot Fleet improve the default price protection behavior of attribute-based instance type selection of Spot Instances, to consistently select from a wide range of instance types.

### 3.7.759.0 (2024-02-29 19:18 UTC)
* DocDBElastic (3.7.301.0)
	* Launched Elastic Clusters Readable Secondaries, Start/Stop, Configurable Shard Instance count, Automatic Backups and Snapshot Copying
* EKS (3.7.304.0)
	* Added support for new AL2023 AMIs to the supported AMITypes.
* LexModelsV2 (3.7.303.0)
	* This release makes AMAZON.QnAIntent generally available in Amazon Lex. This generative AI feature leverages large language models available through Amazon Bedrock to automate frequently asked questions (FAQ) experience for end-users.
* MigrationHubOrchestrator (3.7.301.0)
	* Adds new CreateTemplate, UpdateTemplate and DeleteTemplate APIs.
* QuickSight (3.7.306.0)
	* TooltipTarget for Combo chart visuals; ColumnConfiguration limit increase to 2000; Documentation Update
* SageMaker (3.7.314.0)
	* Adds support for ModelDataSource in Model Packages to support unzipped models. Adds support to specify SourceUri for models which allows registration of models without mandating a container for hosting. Using SourceUri, customers can decouple the model from hosting information during registration.
* SecurityLake (3.7.301.0)
	* Add capability to update the Data Lake's MetaStoreManager Role in order to perform required data lake updates to use Iceberg table format in their data lake or update the role for any other reason.
* Core 3.7.302.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.758.0 (2024-02-28 19:18 UTC)
* Batch (3.7.302.0)
	* This release adds Batch support for configuration of multicontainer jobs in ECS, Fargate, and EKS. This support is available for all types of jobs, including both array jobs and multi-node parallel jobs.
* BedrockAgentRuntime (3.7.301.0)
	* This release adds support to override search strategy performed by the Retrieve and RetrieveAndGenerate APIs for Amazon Bedrock Agents
* CostExplorer (3.7.301.0)
	* This release introduces the new API 'GetApproximateUsageRecords', which retrieves estimated usage records for hourly granularity or resource-level data at daily granularity.
* DynamoDBv2 (3.7.301.16)
	* Expose PaginationToken property in AsyncSearch.
* EC2 (3.7.315.0)
	* This release increases the range of MaxResults for GetNetworkInsightsAccessScopeAnalysisFindings to 1,000.
* IoT (3.7.307.0)
	* This release reduces the maximum results returned per query invocation from 500 to 100 for the SearchIndex API. This change has no implications as long as the API is invoked until the nextToken is NULL.
* WAFV2 (3.7.302.0)
	* AWS WAF now supports configurable time windows for request aggregation with rate-based rules. Customers can now select time windows of 1 minute, 2 minutes or 10 minutes, in addition to the previously supported 5 minutes.

### 3.7.757.0 (2024-02-27 19:13 UTC)
* AmplifyUIBuilder (3.7.301.0)
	* We have added the ability to tag resources after they are created
* Core 3.7.302.14
	* Add support for no_proxy environment variable for .NET Framework targets.
	* All services packages updated to require new Core

### 3.7.756.0 (2024-02-26 19:20 UTC)
* APIGateway (3.7.300.53)
	* Documentation updates for Amazon API Gateway.
* Drs (3.7.303.0)
	* Added volume status to DescribeSourceServer replicated volumes.
* KafkaConnect (3.7.301.0)
	* Adds support for tagging, with new TagResource, UntagResource and ListTagsForResource APIs to manage tags and updates to existing APIs to allow tag on create. This release also adds support for the new DeleteWorkerConfiguration API.
* RDS (3.7.308.0)
	* This release adds support for gp3 data volumes for Multi-AZ DB Clusters.

### 3.7.755.0 (2024-02-23 19:20 UTC)
* AppSync (3.7.304.5)
	* Documentation only updates for AppSync
* CloudWatchRUM (3.7.300.53)
	* Doc-only update for new RUM metrics that were added
* QLDB (3.7.300.53)
	* Clarify possible values for KmsKeyArn and EncryptionDescription.
* RDS (3.7.307.0)
	* Add pattern and length based validations for DBShardGroupIdentifier
* Core 3.7.302.13
	* Use sso_registration_scopes when retrieving SSO token with SSOAWSCredentials

### 3.7.754.0 (2024-02-22 19:29 UTC)
* InternetMonitor (3.7.302.0)
	* This release adds IPv4 prefixes to health events
* KinesisVideo (3.7.301.0)
	* Increasing NextToken parameter length restriction for List APIs from 512 to 1024.

### 3.7.753.0 (2024-02-21 19:17 UTC)
* IoTEvents (3.7.301.0)
	* Increase the maximum length of descriptions for Inputs, Detector Models, and Alarm Models
* LookoutEquipment (3.7.302.0)
	* This release adds a field exposing model quality to read APIs for models. It also adds a model quality field to the API response when creating an inference scheduler.
* MediaLive (3.7.304.0)
	* MediaLive now supports the ability to restart pipelines in a running channel.
* SimpleSystemsManagement (3.7.303.0)
	* This release adds support for sharing Systems Manager parameters with other AWS accounts.

### 3.7.752.0 (2024-02-20 19:14 UTC)
* CloudFront (3.7.301.47)
	* Update `AmazonCloudFrontCookieSigner` to handle paths with leading slashes
* DynamoDBv2 (3.7.301.14)
	* Publishing quick fix for doc only update.
* KinesisFirehose (3.7.304.0)
	* This release updates a few Firehose related APIs.
* Lambda (3.7.304.0)
	* Add .NET 8 (dotnet8) Runtime support to AWS Lambda.

### 3.7.751.0 (2024-02-19 19:20 UTC)
* Amplify (3.7.301.0)
	* This release contains API changes that enable users to configure their Amplify domains with their own custom SSL/TLS certificate.
* Chatbot (3.7.300.0)
	* This release adds support for AWS Chatbot. You can now monitor, operate, and troubleshoot your AWS resources with interactive ChatOps using the AWS SDK.
* ConfigService (3.7.302.23)
	* Documentation updates for the AWS Config CLI
* IVS (3.7.302.8)
	* Changed description for latencyMode in Create/UpdateChannel and Channel/ChannelSummary.
* Keyspaces (3.7.301.16)
	* Documentation updates for Amazon Keyspaces
* MediaTailor (3.7.303.0)
	* MediaTailor: marking #AdBreak.OffsetMillis as required.

### 3.7.750.0 (2024-02-16 19:21 UTC)
* ConnectParticipant (3.7.301.17)
	* Doc only update to GetTranscript API reference guide to inform users about presence of events in the chat transcript.
* ElasticMapReduce (3.7.304.0)
	* adds fine grained control over Unhealthy Node Replacement to Amazon ElasticMapReduce
* KinesisFirehose (3.7.303.0)
	* This release adds support for Data Message Extraction for decompressed CloudWatch logs, and to use a custom file extension or time zone for S3 destinations.
* Lambda (3.7.303.48)
	* Documentation-only updates for Lambda to clarify a number of existing actions and properties.
* RDS (3.7.306.10)
	* Doc only update for a valid option in DB parameter group
* SimpleNotificationService (3.7.301.0)
	* This release marks phone numbers as sensitive inputs.
* Core 3.7.302.12
	* Update `SSOTokenManager` to propagate cancellation token to `GetSsoTokenAsync` flow
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.749.0 (2024-02-15 19:22 UTC)
* Artifact (3.7.300.0)
	* This is the initial SDK release for AWS Artifact. AWS Artifact provides on-demand access to compliance and third-party compliance reports. This release includes access to List and Get reports, along with their metadata. This release also includes access to AWS Artifact notifications settings.
* CodePipeline (3.7.303.0)
	* Add ability to override timeout on action level.
* Detective (3.7.301.43)
	* Doc only updates for content enhancement
* GuardDuty (3.7.303.0)
	* Marked fields IpAddressV4, PrivateIpAddress, Email as Sensitive.
* HealthLake (3.7.301.0)
	* This release adds a new response parameter, JobProgressReport, to the DescribeFHIRImportJob and ListFHIRImportJobs API operation. JobProgressReport provides details on the progress of the import job on the server.
* OpenSearchService (3.7.305.0)
	* Adds additional supported instance types.
* Polly (3.7.302.0)
	* Amazon Polly adds 1 new voice - Burcu (tr-TR)
* SageMaker (3.7.313.0)
	* This release adds a new API UpdateClusterSoftware for SageMaker HyperPod. This API allows users to patch HyperPod clusters with latest platform softwares.
* SecretsManager (3.7.302.26)
	* Doc only update for Secrets Manager
* Core 3.7.302.11
	* Add configuration support to disable IMDSv1 fallback
	* Change Is<property-name>Set properties to not reset the value of the backing field.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.748.0 (2024-02-14 19:15 UTC)
* ControlTower (3.7.304.0)
	* Adds support for new Baseline and EnabledBaseline APIs for automating multi-account governance.
* LookoutEquipment (3.7.301.0)
	* This feature allows customers to see pointwise model diagnostics results for their models.
* QBusiness (3.7.301.0)
	* This release adds the metadata-boosting feature, which allows customers to easily fine-tune the underlying ranking of retrieved RAG passages in order to optimize Q&A answer relevance. It also adds new feedback reasons for the PutFeedback API.
* Core 3.7.302.10
	* Added SSO Logout to SSOTokenManager
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.747.0 (2024-02-13 19:20 UTC)
* Lightsail (3.7.303.0)
	* This release adds support to upgrade the major version of a database.
* MarketplaceCatalog (3.7.303.0)
	* AWS Marketplace Catalog API now supports setting intent on requests
* ResourceExplorer2 (3.7.302.0)
	* Resource Explorer now uses newly supported IPv4 'amazonaws.com' endpoints by default.
* SecurityLake (3.7.300.49)
	* Documentation updates for Security Lake
* Core 3.7.302.9
	* Fixed a regression for SigV2 signing for S3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.746.0 (2024-02-12 19:19 UTC)
* AppSync (3.7.304.0)
	* Adds support for new options on GraphqlAPIs, Resolvers and  Data Sources for emitting Amazon CloudWatch metrics for enhanced monitoring of AppSync APIs.
* CloudWatch (3.7.302.0)
	* This release enables PutMetricData API request payload compression by default.
* NeptuneGraph (3.7.303.0)
	* Adding a new option "parameters" for data plane api ExecuteQuery to support running parameterized query via SDK.
* Route53Domains (3.7.301.0)
	* This release adds bill contact support for RegisterDomain, TransferDomain, UpdateDomainContact and GetDomainDetail API.

### 3.7.745.0 (2024-02-09 19:19 UTC)
* Batch (3.7.301.0)
	* This feature allows Batch to support configuration of repository credentials for jobs running on ECS
* Braket (3.7.302.0)
	* Creating a job will result in DeviceOfflineException when using an offline device, and DeviceRetiredException when using a retired device.
* CostOptimizationHub (3.7.301.0)
	* Adding includeMemberAccounts field to the response of ListEnrollmentStatuses API.
* ECS (3.7.305.10)
	* Documentation only update for Amazon ECS.
* IoT (3.7.306.0)
	* This release allows AWS IoT Core users to enable Online Certificate Status Protocol (OCSP) Stapling for TLS X.509 Server Certificates when creating and updating AWS IoT Domain Configurations with Custom Domain.
* Pricing (3.7.301.0)
	* Add Throttling Exception to all APIs.
* PrometheusService (3.7.302.24)
	* Overall documentation updates.
* Core 3.7.302.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.744.0 (2024-02-08 19:13 UTC)
* CloudFront (3.7.301.41)
	* Remove duplicate `RSA.ImportParameters` call from AmazonCloudFrontUrlSigner (which caused a performance regression issue in OpenSSL 3.0)
* CodePipeline (3.7.302.0)
	* Add ability to execute pipelines with new parallel & queued execution modes and add support for triggers with filtering on branches and file paths.
* QuickSight (3.7.305.0)
	* General Interactions for Visuals; Waterfall Chart Color Configuration; Documentation Update
* WorkSpaces (3.7.302.0)
	* This release introduces User-Decoupling feature. This feature allows Workspaces Core customers to provision workspaces without providing users. CreateWorkspaces and DescribeWorkspaces APIs will now take a new optional parameter "WorkspaceName".

### 3.7.743.0 (2024-02-07 19:16 UTC)
* DataSync (3.7.301.0)
	* AWS DataSync now supports manifests for specifying files or objects to transfer.
* LexModelsV2 (3.7.302.0)
	* This release introduces a new bot replication feature as part of Lex Global Resiliency offering. This feature leverages a new set of APIs that allow customers to create bot replicas and replicate changes to bots across regions.
* Redshift (3.7.304.0)
	* LisRecommendations API to fetch Amazon Redshift Advisor recommendations.
* Core 3.7.302.7
	* Update SigV4A signer not to include headers that are not required for the request signature
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.742.0 (2024-02-06 19:18 UTC)
* AppSync (3.7.303.0)
	* Support for environment variables in AppSync GraphQL APIs
* CloudWatchLogs (3.7.304.0)
	* This release adds a new field, logGroupArn, to the response of the logs:DescribeLogGroups action.
* ECS (3.7.305.8)
	* This release is a documentation only update to address customer issues.
* Elasticsearch (3.7.302.0)
	* This release adds clear visibility to the customers on the changes that they make on the domain.
* OpenSearchService (3.7.304.0)
	* This release adds clear visibility to the customers on the changes that they make on the domain.
* WAFV2 (3.7.301.0)
	* You can now delete an API key that you've created for use with your CAPTCHA JavaScript integration API.

### 3.7.741.0 (2024-02-05 19:15 UTC)
* Glue (3.7.307.0)
	* Introduce Catalog Encryption Role within Glue Data Catalog Settings. Introduce SASL/PLAIN as an authentication method for Glue Kafka connections
* WorkSpaces (3.7.301.39)
	* Added definitions of various WorkSpace states

### 3.7.740.0 (2024-02-02 19:13 UTC)
* DynamoDBv2 (3.7.301.7)
	* Any number of users can execute up to 50 concurrent restores (any type of restore) in a given account.
* SageMaker (3.7.312.0)
	* Amazon SageMaker Canvas adds GenerativeAiSettings support for CanvasAppSettings.
* Core 3.7.302.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.739.0 (2024-02-01 19:18 UTC)
* CognitoIdentityProvider (3.7.302.0)
	* Added CreateIdentityProvider and UpdateIdentityProvider details for new SAML IdP features
* IVS (3.7.302.0)
	* This release introduces a new resource Playback Restriction Policy which can be used to geo-restrict or domain-restrict channel stream playback when associated with a channel.  New APIs to support this resource were introduced in the form of Create/Delete/Get/Update/List.
* ManagedBlockchainQuery (3.7.302.0)
	* This release adds support for transactions that have not reached finality. It also removes support for the status property from the response of the GetTransaction operation. You can use the confirmationStatus and executionStatus properties to determine the status of the transaction.
* MediaConvert (3.7.303.0)
	* This release includes support for broadcast-mixed audio description tracks.
* NeptuneGraph (3.7.302.0)
	* Adding new APIs in SDK for Amazon Neptune Analytics. These APIs include operations to execute, cancel, list queries and get the graph summary.
* Core 3.7.302.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.738.0 (2024-01-31 19:15 UTC)
* CloudFormation (3.7.303.0)
	* CloudFormation IaC generator allows you to scan existing resources in your account and select resources to generate a template for a new or existing CloudFormation stack.
* ElasticLoadBalancingV2 (3.7.302.0)
	* This release enables unhealthy target draining intervals for Network Load Balancers.
* Glue (3.7.306.0)
	* Update page size limits for GetJobRuns and GetTriggers APIs.
* SimpleSystemsManagement (3.7.302.0)
	* This release adds an optional Duration parameter to StateManager Associations. This allows customers to specify how long an apply-only-on-cron association execution should run. Once the specified Duration is out all the ongoing cancellable commands or automations are cancelled.
* Core 3.7.302.4
	* Performance optimization using source generated Regex for .NET 8 target.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.737.0 (2024-01-30 19:13 UTC)
* DataZone (3.7.301.0)
	* Add new skipDeletionCheck to DeleteDomain. Add new skipDeletionCheck to DeleteProject which also automatically deletes dependent objects
* Route53 (3.7.302.10)
	* Update the SDKs for text changes in the APIs.
* Core 3.7.302.3
	* Update request checksum not to add duplicate trailing header key on retries
	* All services packages updated to require new Core

### 3.7.736.0 (2024-01-29 19:24 UTC)
* AutoScaling (3.7.302.0)
	* EC2 Auto Scaling customers who use attribute based instance-type selection can now intuitively define their Spot instances price protection limit as a percentage of the lowest priced On-Demand instance type.
* Comprehend (3.7.300.42)
	* Comprehend PII analysis now supports Spanish input documents.
* EC2 (3.7.314.0)
	* EC2 Fleet customers who use attribute based instance-type selection can now intuitively define their Spot instances price protection limit as a percentage of the lowest priced On-Demand instance type.
* MWAA (3.7.303.0)
	* This release adds MAINTENANCE environment status for Amazon MWAA environments.
* RDS (3.7.306.0)
	* Introduced support for the InsufficientDBInstanceCapacityFault error in the RDS RestoreDBClusterFromSnapshot and RestoreDBClusterToPointInTime API methods. This provides enhanced error handling, ensuring a more robust experience.
* Snowball (3.7.300.42)
	* Modified description of createaddress to include direction to add path when providing a JSON file.
* Core 3.7.302.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.735.0 (2024-01-26 19:18 UTC)
* Connect (3.7.312.0)
	* Update list and string length limits for predefined attributes.
* Inspector2 (3.7.302.0)
	* This release adds ECR container image scanning based on their lastRecordedPullTime.
* SageMaker (3.7.311.0)
	* Amazon SageMaker Automatic Model Tuning now provides an API to programmatically delete tuning jobs.
* Core 3.7.302.1
	* Added support to set SupportsGettingNewToken when retrieving Credentials from SSOAWSCredentials

### 3.7.734.0 (2024-01-25 19:24 UTC)
* ACMPCA (3.7.301.0)
	* AWS Private CA now supports an option to omit the CDP extension from issued certificates, when CRL revocation is enabled.
* Lightsail (3.7.302.0)
	* This release adds support for IPv6-only instance plans.
* S3 (3.7.305.17)
	* Fix bug with S3 ConstantClass enumerations not working with implicit string conversion
* Core 3.7.302.0
	* Introduce a new general HTTP credentials provider, which supports retrieval of AWS credentials from an arbitrary HTTP(S) endpoint specified by the environment. It replaces the existing `ECSTaskCredentials` provider, and it's also used by EKS Pod Identities.
	* All services packages updated to require new Core

### 3.7.733.0 (2024-01-24 22:12 UTC)
* EC2 (3.7.313.0)
	* Introduced a new clientToken request parameter on CreateNetworkAcl and CreateRouteTable APIs. The clientToken parameter allows idempotent operations on the APIs.
* ECS (3.7.305.1)
	* Documentation updates for Amazon ECS.
* Outposts (3.7.301.0)
	* DeviceSerialNumber parameter is now optional in StartConnection API
* RDS (3.7.305.0)
	* This release adds support for Aurora Limitless Database.
* StorageGateway (3.7.301.0)
	* Add DeprecationDate and SoftwareVersion to response of ListGateways.
* Core 3.7.301.10
	* Skip content-type header for requests without a modeled body or payload
	* All services packages updated to require new Core

### 3.7.732.0 (2024-01-23 20:39 UTC)
* Inspector2 (3.7.301.0)
	* This release adds support for CIS scans on EC2 instances.
* S3 (3.7.305.15)
	* Add missing `SSE-C` properties in TransferUtilityDownloadDirectoryRequest

### 3.7.731.0 (2024-01-22 19:25 UTC)
* AppConfigData (3.7.301.0)
	* Fix FIPS Endpoints in aws-us-gov.
* Cloud9 (3.7.301.27)
	* Doc-only update around removing AL1 from list of available AMIs for Cloud9
* CloudFrontKeyValueStore (3.7.301.0)
	* This release improves upon the DescribeKeyValueStore API by returning two additional fields, Status of the KeyValueStore and the FailureReason in case of failures during creation of KeyValueStore.
* ConnectCases (3.7.302.0)
	* This release adds the ability to view audit history on a case and introduces a new parameter, performedBy, for CreateCase and UpdateCase API's.
* EC2 (3.7.312.6)
	* Documentation updates for Amazon EC2.
* ECS (3.7.305.0)
	* This release adds support for Transport Layer Security (TLS) and Configurable Timeout to ECS Service Connect. TLS facilitates privacy and data security for inter-service communications, while Configurable Timeout allows customized per-request timeout and idle timeout for Service Connect services.
* Finspace (3.7.304.0)
	* Allow customer to set zip default through command line arguments.
* Organizations (3.7.300.40)
	* Doc only update for quota increase change
* RDS (3.7.304.0)
	* Introduced support for the InsufficientDBInstanceCapacityFault error in the RDS CreateDBCluster API method. This provides enhanced error handling, ensuring a more robust experience when creating database clusters with insufficient instance capacity.

### 3.7.730.0 (2024-01-19 19:25 UTC)
* Athena (3.7.303.0)
	* Introducing new NotebookS3LocationUri parameter to Athena ImportNotebook API. Payload is no longer required and either Payload or NotebookS3LocationUri needs to be provided (not both) for a successful ImportNotebook API call. If both are provided, an InvalidRequestException will be thrown.
* CodeBuild (3.7.302.0)
	* Release CodeBuild Reserved Capacity feature
* DynamoDBv2 (3.7.301.0)
	* This release adds support for including ApproximateCreationDateTimePrecision configurations in EnableKinesisStreamingDestination API, adds the same as an optional field in the response of DescribeKinesisStreamingDestination, and adds support for a new UpdateKinesisStreamingDestination API.
* QConnect (3.7.303.0)
	* Increased Quick Response name max length to 100
* Core 3.7.301.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.729.0 (2024-01-18 19:19 UTC)
* B2bi (3.7.301.0)
	* Increasing TestMapping inputFileContent file size limit to 5MB and adding file size limit 250KB for TestParsing input file. This release also includes exposing InternalServerException for Tag APIs.
* CloudTrail (3.7.303.0)
	* This release adds a new API ListInsightsMetricData to retrieve metric data from CloudTrail Insights.
* Connect (3.7.311.0)
	* GetMetricDataV2 now supports 3 groupings
* Drs (3.7.302.0)
	* Removed invalid and unnecessary default values.
* KinesisFirehose (3.7.302.0)
	* Allow support for Snowflake as a Kinesis Data Firehose delivery destination.
* SageMakerFeatureStoreRuntime (3.7.301.0)
	* Increase BatchGetRecord limits from 10 items to 100 items
* Core 3.7.301.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.728.0 (2024-01-17 19:16 UTC)
* DynamoDBv2 (3.7.300.38)
	* Updating note for enabling streams for UpdateTable.
* Keyspaces (3.7.301.0)
	* This release adds support for Multi-Region Replication with provisioned tables, and Keyspaces auto scaling APIs

### 3.7.727.0 (2024-01-16 19:23 UTC)
* IoT (3.7.305.0)
	* Revert release of LogTargetTypes
* IoTFleetWise (3.7.303.0)
	* Updated APIs: SignalNodeType query parameter has been added to ListSignalCatalogNodesRequest and ListVehiclesResponse has been extended with attributes field.
* Macie2 (3.7.302.0)
	* This release adds support for analyzing Amazon S3 objects that are encrypted using dual-layer server-side encryption with AWS KMS keys (DSSE-KMS). It also adds support for reporting DSSE-KMS details in statistics and metadata about encryption settings for S3 buckets and objects.
* PaymentCryptography (3.7.302.0)
	* Provide an additional option for key exchange using RSA wrap/unwrap in addition to tr-34/tr-31 in ImportKey and ExportKey operations. Added new key usage (type) TR31_M1_ISO_9797_1_MAC_KEY, for use with Generate/VerifyMac dataplane operations  with ISO9797 Algorithm 1 MAC calculations.
* Personalize (3.7.301.29)
	* Documentation updates for Amazon Personalize.
* PersonalizeRuntime (3.7.301.29)
	* Documentation updates for Amazon Personalize
* Rekognition (3.7.301.0)
	* This release adds ContentType and TaxonomyLevel attributes to DetectModerationLabels and GetMediaAnalysisJob API responses.
* SecurityHub (3.7.303.21)
	* Documentation updates for AWS Security Hub
* Core 3.7.301.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.726.0 (2024-01-14 05:28 UTC)
* SageMaker (3.7.310.0)
	* This release will have ValidationException thrown if certain invalid app types are provided. The release will also throw ValidationException if more than 10 account ids are provided in VpcOnlyTrustedAccounts.
* Core 3.7.301.6
	* Update generators to use correct code tags in `<param>` XML elements
	* All services packages updated to require new Core

### 3.7.725.0 (2024-01-12 19:44 UTC)
* CloudFrontKeyValueStore (3.7.300.28)
	* Fixed CloudFrontKeyValueStore to use Sigv4a instead of Sigv4.
* Connect (3.7.310.0)
	* Supervisor Barge for Chat is now supported through the MonitorContact API.
* ConnectParticipant (3.7.301.0)
	* Introduce new Supervisor participant role
* LocationService (3.7.304.2)
	* Location SDK documentation update. Added missing fonts to the MapConfiguration data type. Updated note for the SubMunicipality property in the place data type.
* MWAA (3.7.302.0)
	* This Amazon MWAA feature release includes new fields in CreateWebLoginToken response model. The new fields IamIdentity and AirflowIdentity will let you match identifications, as the Airflow identity length is currently hashed to 64 characters.
* S3Control (3.7.305.0)
	* S3 On Outposts team adds dualstack endpoints support for S3Control and S3Outposts API calls.
* SupplyChain (3.7.300.0)
	* This release includes APIs CreateBillOfMaterialsImportJob and GetBillOfMaterialsImportJob.
* Transfer (3.7.302.0)
	* AWS Transfer Family now supports static IP addresses for SFTP & AS2 connectors and for async MDNs on AS2 servers.
* Core 3.7.301.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.724.0 (2024-01-11 19:16 UTC)
* EC2 (3.7.312.0)
	* This release adds support for adding an ElasticBlockStorage volume configurations in ECS RunTask/StartTask/CreateService/UpdateService APIs. The configuration allows for attaching EBS volumes to ECS Tasks.
* ECS (3.7.304.0)
	* This release adds support for adding an ElasticBlockStorage volume configurations in ECS RunTask/StartTask/CreateService/UpdateService APIs. The configuration allows for attaching EBS volumes to ECS Tasks.
* EventBridge (3.7.302.0)
	* Adding AppSync as an EventBridge Target
* IoT (3.7.304.0)
	* Add ConflictException to Update APIs of AWS IoT Software Package Catalog
* IoTFleetWise (3.7.302.0)
	* The following dataTypes have been removed: CUSTOMER_DECODED_INTERFACE in NetworkInterfaceType; CUSTOMER_DECODED_SIGNAL_INFO_IS_NULL in SignalDecoderFailureReason; CUSTOMER_DECODED_SIGNAL_NETWORK_INTERFACE_INFO_IS_NULL in NetworkInterfaceFailureReason; CUSTOMER_DECODED_SIGNAL in SignalDecoderType
* SecretsManager (3.7.302.9)
	* Doc only update for Secrets Manager
* WorkSpaces (3.7.301.26)
	* Added AWS Workspaces RebootWorkspaces API - Extended Reboot documentation update
* Core 3.7.301.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.723.0 (2024-01-10 19:21 UTC)
* CloudWatchLogs (3.7.303.0)
	* Add support for account level subscription filter policies to PutAccountPolicy, DescribeAccountPolicies, and DeleteAccountPolicy APIs. Additionally, PutAccountPolicy has been modified with new optional "selectionCriteria" parameter for resource selection.
* ConnectCampaignService (3.7.301.0)
	* Minor pattern updates for Campaign and Dial Request API fields.
* ConnectWisdomService (3.7.302.0)
	* QueryAssistant and GetRecommendations will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.
* LocationService (3.7.304.0)
	* This release adds API support for custom layers for the maps service APIs: CreateMap, UpdateMap, DescribeMap.
* QConnect (3.7.302.0)
	* QueryAssistant and GetRecommendations will be discontinued starting June 1, 2024. To receive generative responses after March 1, 2024 you will need to create a new Assistant in the Connect console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs) into your applications.
* RedshiftServerless (3.7.302.21)
	* Updates to ConfigParameter for RSS workgroup, removal of use_fips_ssl
* Route53 (3.7.302.0)
	* Route53 now supports geoproximity routing in AWS regions
* S3 (3.7.305.8)
	* Fixed a bug where uploading empty unseekable stream with TransferUtility creates 8MB file in S3.
* Core 3.7.301.3
	* Fix encoding issue where resource path components from the configured endpoint were being double encoded. Resource path components from configured endpoints will be single encoded and resource path components from the request will continue to be double encoded (except for S3).
	* Update documentation generators to use correct code tags
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.722.0 (2024-01-08 19:16 UTC)
* CodeBuild (3.7.301.0)
	* Aws CodeBuild now supports new compute type BUILD_GENERAL1_XLARGE
* EC2 (3.7.311.0)
	* Amazon EC2 R7iz bare metal instances are powered by custom 4th generation Intel Xeon Scalable processors.
* Route53Resolver (3.7.302.0)
	* This release adds support for query type configuration on firewall rules that enables customers for granular action (ALLOW, ALERT, BLOCK) by DNS query type.
* Core 3.7.301.2
	* Added SSO registration scopes to SSOAWSCredentialsOptions
	* All services packages updated to require new Core

### 3.7.721.0 (2024-01-05 19:22 UTC)
* Connect (3.7.309.0)
	* Minor trait updates for User APIs
* KeyManagementService (3.7.300.31)
	* Documentation updates for AWS Key Management Service (KMS).
* RedshiftServerless (3.7.302.19)
	* use_fips_ssl and require_ssl parameter support for Workgroup, UpdateWorkgroup, and CreateWorkgroup
* Core 3.7.301.1
	* Update generator to add line breaks in service client documentation
	* All services packages updated to require new Core

### 3.7.720.0 (2024-01-04 19:56 UTC)
* ConfigService (3.7.302.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config in November and December 2023.
* DocDB (3.7.302.0)
	* Adding PerformanceInsightsEnabled and PerformanceInsightsKMSKeyId fields to DescribeDBInstances Response.
* ECS (3.7.303.0)
	* This release adds support for managed instance draining which facilitates graceful termination of Amazon ECS instances.
* Elasticsearch (3.7.301.0)
	* This release adds support for new or existing Amazon OpenSearch domains to enable TLS 1.3 or TLS 1.2 with perfect forward secrecy cipher suites for domain endpoints.
* Lightsail (3.7.301.0)
	* This release adds support to set up an HTTPS endpoint on an instance.
* OpenSearchService (3.7.303.0)
	* This release adds support for new or existing Amazon OpenSearch domains to enable TLS 1.3 or TLS 1.2 with perfect forward secrecy cipher suites for domain endpoints.
* SageMaker (3.7.309.0)
	* Adding support for provisioned throughput mode for SageMaker Feature Groups
* ServiceCatalog (3.7.301.0)
	* Added Idempotency token support to Service Catalog  AssociateServiceActionWithProvisioningArtifact, DisassociateServiceActionFromProvisioningArtifact, DeleteServiceAction API
* Core 3.7.301.0
	* Add support for environment variables `http_proxy` and `https_proxy`; the .NET SDK now matches the behavior of the AWS CLI when using an [HTTP proxy](https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-proxy.html). Note that [HTTPS proxies](https://github.com/dotnet/runtime/issues/31113) are only supported in .NET 8 (and later).
	* All services packages updated to require new Core

### 3.7.719.0 (2024-01-03 19:21 UTC)
* Connect (3.7.308.0)
	* Amazon Connect, Contact Lens Evaluation API increase evaluation notes max length to 3072.
* MediaConvert (3.7.302.0)
	* This release includes video engine updates including HEVC improvements, support for ingesting VP9 encoded video in MP4 containers, and support for user-specified 3D LUTs.
* Core 3.7.300.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

