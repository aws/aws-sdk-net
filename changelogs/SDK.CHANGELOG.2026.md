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

