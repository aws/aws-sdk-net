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

