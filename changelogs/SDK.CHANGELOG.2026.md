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

