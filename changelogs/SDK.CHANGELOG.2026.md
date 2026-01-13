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

