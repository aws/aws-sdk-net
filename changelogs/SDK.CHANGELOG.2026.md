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

