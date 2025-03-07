### 4.0.0.0-preview.10 (2025-03-07 14:25 UTC)
* CloudFront (4.0.0.0)
	* Removed the AmazonCloudFrontUtil utility code that was no longer being used.
* DynamoDBv2 (4.0.0.0)
	* Removed the DynamoDBContextTableNamePrefix property. Users should call AWSConfigsDynamoDB.Context.TableNamePrefix instead of AWSConfigsDynamoDB.Context.DynamoDBContextTableNamePrefix.
	* Add Support for DateOnly and TimeOnly in DynamoDB high level libraries. This support is available in .NET 8 and above.
* EC2 (4.0.0.0)
	* Removed the VPC utilizes code. It was terribly out of date even referring to EC2 instance type that has been deprecated for years.
	* Removed the image utilities used for looking up EC2 amis for Windows OS.
	* [Breaking Change] Remove obsolete IPRanges behavior from EC2. IPV4Ranges or IPV6Ranges should be used instead.
* IoT (4.0.0.0)
	* Removed a legacy customization for NextToken override to refer to the actual modeled pagination token.
* Lambda (4.0.0.0)
	* Removed obsolete InvokeAsync service client operation to avoid confusion with the Async suffix added for async .NET methods.
* S3 (4.0.0.0)
	* Remove obsolete DisableMD5Stream property. Code should be updated to use DisableDefaultChecksumValidation property.
	* Remove obsolete ServerSideEncryptionMethod and ServerSideEncryptionKeyManagementServiceKeyId from CopyPart. This should be set in the InitiateMultipartUpload method.
	* Remove obsolete Expires property from GetObjectResponse. Code should be updated to use ExpiresString. Since the string may not be in a valid timestamp format code shoud use TryParse when converting to DateTime.
	* Remove obsolete region identifiers from S3Region enumeration
	* Remove obsolete Prefix property from LifecycleConfiguration. Code should be updated to use Filter property.
	* Remove obsolete Transition and NoncurrentVersionTransition from LifecycleRule. Could should be updated to use the collection versions Transitions and NoncurrentVersionTransitions.
	* Remove obsolete Event property from TopicConfiguration. Code should be updated to use the collection property Events.
	* Remove obsolete CalculateContentMD5Header property. This property no longer needed to be set because the SDK will compute a checksum by default.
	* Remove obsolete Bucket property from SelectObjectContentRequest. Code should be updated to use BucketName.
	* Remove obsolete NumberOfUploadThreads property from TransferUtilityConfig. Code should be updated to use ConcurrentServiceRequests.
	* Remove obsolete DoesS3BucketExist method. Code should be updated to use DoesS3BucketExistV2
* SageMakerRuntime (4.0.0.0)
	* Removed obsolete constructors for PayloadPart.
* SecurityToken (4.0.0.0)
	* Removed the deprecated STS assume role credential provider since users should be using the one in core.
* Core 4.0.0.0
	* Remove obsolete endpoint logic code
	* Remove obsolete global `ClockSkew` property
	* Remove the obsolete `ReadWriteTimeout` property from `ClientConfig` all targets except .NET Framework 4.7.2.
	* Update SDK signers to handle scenarios where anonymous credentials are provided.
	* All services packages updated to require new Core

### 4.0.0.0-preview.9 (2025-03-04 14:29 UTC)
* DynamoDBv2 (4.0.0.0)
	* Implement DynamoDBDerivedTypeAttribute to enable polymorphism support for nested items on save and load data.
* S3 (4.0.0.0)
	* Manual sweep of S3 for protocol test compliance.
* Core 4.0.0.0
	* [Breaking Change] Rework how SDK logs can be outputted. The AWSSDK.Extensions.Logging.ILoggerAdaptor and AWSSDK.Extensions.Logging.Log4NetAdaptor adaptor packages were added to support outputting the SDK logs to Microsoft.Extensions.Logging or log4net.
	* Do not send null values, but do send empty strings and empty lists over the wire in headers for restxml and restjson protocols
	* Improved error message when searching for AWS credentials and no credentials were found.
	* The `CredentialsRetriever` pipeline handler has been removed and each signer now retrieves credentials from the `Identity` property directly instead.
	* The `FallbackCredentialsFactory` has been marked as deprecated, and the `DefaultAWSCredentialsIdentityResolver` class should be used instead. This new class follows the credential resolution order as the other AWS SDKs and will re-evaluate credentials when environment variables (such as `AWS_PROFILE`) change - which can happen in interactive PowerShell sessions.
	* The `ImmutableCredentials` property of the `RequestContext` has been removed - as it's only applicable to AWS credentials. A new property named `Identity` is available instead (it'll be used for anonymous and token credentials as well).
	* The AWS SDK for .NET has been updated to resolve credentials at request time, instead of resolving them when a client is instantiated (note: credentials are still cached between executions, the SDK won't attempt to retrieve them again - e.g. by calling `AssumeRole` - if they're valid from a previous call).
	* The signature for the signer classes (such as `AWS4Signer`) has been changed as they now implement a new interface.
	* All services packages updated to require new Core

### 4.0.0.0-preview.8 (2025-02-25 13:38 UTC)
* DataExchange (4.0.0.0)
	* Updated `SendApiAsset` operation to set correct `Content-Type` header
* DynamoDBv2 (4.0.0.0)
	* Improved error message in DataModel when in Native AOT mode and nested types have been trimmed.
* EC2 (4.0.0.0)
	* [Breaking Change] Obsoleted DryRun method from service client. To perform a dry run use the DryRun property on the request object for individual EC2 operations.
* Core 4.0.0.0
	* [Breaking Change] Remove `LitJson` source from SDK and clean up all references.
	* [Breaking Change] Remove support for deprecated IMDS v1.
	* [Breaking Change] Updated EventStreams Byte to SByte to be inline with the spec where Byte was intended to be signed.
	* Fixed `JsonRPCRequestMarshaller` to properly handle enum payloads by setting content headers to plain text instead of JSON object
	* Updated `Microsoft.Extensions.AI` to `9.3.0-preview.1.25114.11` in the `AWSSDK.Extensions.Bedrock.MEAI` package
	* Updated `restJson1` protocol services to use `text/plain` as `Content-Type` (instead of `application/json`) for string payloads
	* Updated `XmlDictionary` and `KeyValueUnmarshallers` to be able to handle any key and value XML element names
	* All services packages updated to require new Core

### 4.0.0.0-preview.7 (2025-02-17 16:10 UTC)
* EC2 (4.0.0.0)
	* [Breaking Change] Removed EC2: DiskImageImporter, ImportCleanup, EC2Metadata, and S3UploadPolicy classes which are obsolete.
* S3 (4.0.0.0)
	* Removed GlobalSuppressions for removed EC2 classes.
* Core 4.0.0.0
	* [Breaking Change] Removal of AWSConfigsS3.UseSignatureVersion4 and AWSConfigsS3.UseSigV4SetExplicitly to always use SigV4.
	* [Breaking Change] Removal of ClientConfig.SignatureVersion only used by S3 for backward compatibility.
	* [Breaking Change] Removal of Endpoint.SignatureVersionOverride from the obsolete Endpoint class used to handle overriding signature versions for S3.
	* [Breaking Change] Removal of the obsolete EventBridgeSigner class.
	* [Breaking Change] Updated AmazonS3Util.PostUpload and S3PostUploadSignedPolicy.GetSignedPolicy to use SigV4. S3PostUploadSignedPolicy.GetSignedPolicyV4 removed and overwrote to S3PostUploadSignedPolicy.GetSignedPolicy.
	* Fixed issue where `System.Text.Json` dependencies were not being copied to the AWS SDK for .NET ZIP artifacts
	* Refactor `Core` to remove `LitJson` references and use `System.Text.Json` instead
	* Refactor tests and services to use `System.Text.Json` instead of `LitJson`
	* Updated S3 GetPreSignedURL to always use SigV4 unless the expiration date is greater than seven days and it is a region which supports SigV2.
	* All services packages updated to require new Core

### 4.0.0.0-preview.6 (2025-02-06 21:43 UTC)
* DynamoDBv2 (4.0.0.0)
	* Add NativeAOT support for the DataModel namespace also known as the Object Persistence high level library.
* Core 4.0.0.0
	* Adjustments to fix failing DateTimes asserts in tests due to local/UTC inconsistencies.
	* Backport the .NET trimming attributes like DynamicallyAccessedMembersAttribute into ThirdParty.RuntimeBackports namespace for Target Frameworks before .NET 8. This simplifies the SDK's codebase by removing compilation conditional checks when using the attributes.
	* Disable signing the payload when the operation is modeled as having an `UnsignedPayload` set to true.
	* Updates serialization for JSON-based services to use `System.Text.Json` instead of `LitJson` for improved performance and smaller memory allocations.
	* All services packages updated to require new Core

### 4.0.0.0-preview.5 (2025-01-03 14:07 UTC)
* DynamoDBv2 (4.0.0.0)
	* Switch Document.FromJson and ToJson to use System.Text.Json instead of LitJson. This supports additional precision for decimal values.
	* Address Native AOT issues for the DynamoDB Document Model high level library
* S3 (4.0.0.0)
	* Update `AWS_S3_USE_ARN_REGION` environment variable to take precedence over `s3_use_arn_region` option in the config file.
	* Remove the `DisableTrimmingLeadingSlash` flag for CopyObject and CopyPart operations. The SDK will no longer trim leading slashes.
* Core 4.0.0.0
	* AWSSDK.Extensions.NETCore.Setup: Add possibility to add AWS services to DI with a key (https://github.com/aws/aws-sdk-net/pull/3570)
	* DateTime handling (Breaking Change): ConvertFromUnixEpochSeconds/ConvertFromUnixEpochMilliseconds incorrectly returning the Unix Epoch time as local time instead of a UTC time by definition. This changes the behavior where these methods were used.
	* DateTime handling (Breaking Change): DynamoDB RetrieveDateTimeInUtc has been switched to true as the default.
	* DateTime handling (Breaking Change): Fixed the DateTimeUnmarshaller which was parsing datetime strings into and returning them as local time which in some cases were still getting converted back to UTC on a prior bug fix but not always. DateTime strings unmarshalled are assumed to be UTC time and will be specified and unmarshalled as UTC.
	* DateTime handling (Breaking Change): Removed obsolete properties such EndTime then changed EndTimeUtc to EndTime. This could lead to offset times for developers still using the marked obsolete original EndTime for example. A compile time error will occur for anyone using any of the removed *Utc properties such as EndTimeUtc.
	* DateTime handling (Breaking Change): Response unmarshallers for TimeStamps and list TimeStamps for formats TimestampFormat.ISO8601 || TimestampFormat.RFC822 datetimes were being parsed into local times. Adjusted DateTime parsing to return UTC times.
	* DateTime handling (Bug fix): AWSPublicIpAddressRanges mixing UTC and local time.
	* DateTime handling (Bug fix): Console logger outputs timestamps as a UTC date incase output is sent off the local machine and for easier comparison with other UTC dates.
	* DateTime handling (Bug fix): Ensured DateTime.Max and DateTime.Min are marked with a DateTime.Kind DateTimeKind.Utc for proper calculations.
	* DateTime handling (Bug fix): Fixed internal Epoch dates to UTC per definition where the epoch date was created in local time. 
	* DateTime handling (Bug fix): GetFormattedTimestampISO8601 incorrectly creating a DateTime object as local time even though it is passed in as UTC. Then formatting it as a UTC string.
	* DateTime handling (Bug fix): Instead of assuming SAML credentials are local time then converting to UTC and assume that the time given is UTC to work properly with credential expiration being in UTC time for other credential providers.
	* DateTime handling (Bug fix): RetryPolicies return UTC server time instead of a UTC time converted to local time.
	* DateTime handling (Bug fix): Stopped using expiry times in credentials internally as local time. Changed to UTC.
	* Fix [#2464](https://github.com/aws/aws-sdk-net/issues/2464): Perform background refresh of credentials during preempt expiry period (https://github.com/aws/aws-sdk-net/pull/3541)
	* Fix [#3497](https://github.com/aws/aws-sdk-net/issues/3497): Make InternalSDKUtils aot compatible in V4
	* Implement Microsoft.Extensions.AI's IChatClient / IEmbeddingGenerator via the new `AWSSDK.Extensions.Bedrock.MEAI` package (https://github.com/aws/aws-sdk-net/pull/3545)
	* Updated DateTime handling to use UTC instead of local times.
	* All services packages updated to require new Core

### 3.7.993.0 (2025-02-28 19:30 UTC)
* BedrockAgent (3.7.420.0)
	* This release lets Amazon Bedrock Flows support newer models by increasing the maximum length of output in a prompt configuration. This release also increases the maximum number of prompt variables to 20 and the maximum number of node inputs to 20.
* BedrockDataAutomation (3.7.401.0)
	* Renamed and added new StandardConfiguration enums. Added support to update EncryptionConfiguration in UpdateBlueprint and UpdateDataAutomation APIs. Changed HttpStatus code for DeleteBlueprint and DeleteDataAutomationProject APIs to 200 from 204. Added APIs to support tagging.
* BedrockDataAutomationRuntime (3.7.401.0)
	* Added a mandatory parameter DataAutomationProfileArn to support for cross region inference for InvokeDataAutomationAsync API. Renamed DataAutomationArn to DataAutomationProjectArn. Added APIs to support tagging.
* DatabaseMigrationService (3.7.408.0)
	* Add skipped status to the Result Statistics of an Assessment Run
* EKS (3.7.411.0)
	* Adding licenses to EKS Anywhere Subscription operations response.
* MediaConvert (3.7.409.0)
	* The AWS MediaConvert Probe API allows you to analyze media files and retrieve detailed metadata about their content, format, and structure.
* Pricing (3.7.401.0)
	* Update GetProducts and DescribeServices API request input validations.
* SimpleSystemsManagement (3.7.403.49)
	* Systems Manager doc-only updates for Feb. 2025.
* Core 3.7.402.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.992.0 (2025-02-27 19:26 UTC)
* BedrockAgentRuntime (3.7.421.0)
	* Introduces Sessions (preview) to enable stateful conversations in GenAI applications.
* ElasticMapReduce (3.7.403.46)
	* Definition update for EbsConfiguration.
* QBusiness (3.7.410.0)
	* This release supports deleting attachments from conversations.
* RedshiftServerless (3.7.403.0)
	* Add track support for Redshift Serverless workgroup.
* S3 (3.7.415.8)
	* Updated SDK not to throw an error when parsing response headers modeled as `string` into different data types.
* SageMaker (3.7.427.0)
	* SageMaker HubService is introducing support for creating Training Jobs in Curated Hub (Private Hub). Additionally, it is introducing two new APIs: UpdateHubContent and UpdateHubContentReference.
* StorageGateway (3.7.403.0)
	* This release adds support to invoke a process that cleans the specified file share's cache of file entries that are failing upload to Amazon S3.
* Core 3.7.402.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.991.0 (2025-02-26 19:46 UTC)
* ApplicationSignals (3.7.404.0)
	* This release adds API support for reading Service Level Objectives and Services from monitoring accounts, from SLO and Service-scoped operations, including ListServices and ListServiceLevelObjectives.
* Batch (3.7.405.0)
	* AWS Batch: Resource Aware Scheduling feature support
* Chime (3.7.401.0)
	* Removes the Amazon Chime SDK APIs from the "chime" namespace.  Amazon Chime SDK APIs continue to be available in the AWS SDK via the dedicated Amazon Chime SDK namespaces: chime-sdk-identity, chime-sdk-mediapipelines, chime-sdk-meetings, chime-sdk-messaging, and chime-sdk-voice.
* CloudFront (3.7.404.37)
	* Documentation update for VPC origin config.
* EC2 (3.7.432.0)
	* Amazon EC2 Fleet customers can now override the Block Device Mapping specified in the Launch Template when creating a new Fleet request, saving the effort of creating and associating new Launch Templates to customize the Block Device Mapping.
* IoTFleetWise (3.7.404.0)
	* This release adds an optional listResponseScope request parameter in certain list API requests to limit the response to metadata only.
* OAM (3.7.401.0)
	* This release adds support for sharing AWS::ApplicationSignals::Service and AWS::ApplicationSignals::ServiceLevelObjective resources.
* SageMaker (3.7.426.0)
	* AWS SageMaker InferenceComponents now support rolling update deployments for Inference Components.
* Core 3.7.402.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.990.0 (2025-02-25 19:27 UTC)
* CodeBuild (3.7.412.0)
	* Adding "reportArns" field in output of BatchGetBuildBatches API. "reportArns" is an array that contains the ARNs of reports created by merging reports from builds associated with the batch build.
* DeviceFarm (3.7.402.0)
	* Add an optional configuration to the ScheduleRun and CreateRemoteAccessSession API to set a device level http/s proxy.
* EC2 (3.7.431.0)
	* Adds support for time-based EBS-backed AMI copy operations. Time-based copy ensures that EBS-backed AMIs are copied within and across Regions in a specified timeframe.
* IoT (3.7.407.0)
	* AWS IoT - AWS IoT Device Defender adds support for a new Device Defender Audit Check that monitors device certificate age and custom threshold configurations for both the new device certificate age check and existing device certificate expiry check.
* TaxSettings (3.7.403.0)
	* PutTaxRegistration API changes for Egypt, Greece, Vietnam countries
* Core 3.7.402.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.989.0 (2025-02-24 20:41 UTC)
* BedrockAgent (3.7.419.0)
	* This release improves support for newer models in Amazon Bedrock Flows.
* BedrockAgentRuntime (3.7.420.0)
	* Adding support for ReasoningContent fields in Pre-Processing, Post-Processing and Orchestration Trace outputs.
* BedrockRuntime (3.7.413.0)
	* This release adds Reasoning Content support to Converse and ConverseStream APIs
* ElastiCache (3.7.402.44)
	* Documentation update, adding clarity and rephrasing.
* ElasticInference (Removed)
	* Amazon Elastic Inference has been removed from the SDK because it has been discontinued.
* Core 3.7.402.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.988.0 (2025-02-21 19:24 UTC)
* AppStream (3.7.406.0)
	* Added support for Certificate-Based Authentication on AppStream 2.0 multi-session fleets.
* BedrockAgent (3.7.418.0)
	* Introduce a new parameter which represents the user-agent header value used by the Bedrock Knowledge Base Web Connector.
* Core 3.7.402.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.987.0 (2025-02-20 19:27 UTC)
* CodeBuild (3.7.411.0)
	* Add webhook status and status message to AWS CodeBuild webhooks
* GuardDuty (3.7.406.0)
	* Reduce the minimum number of required attack sequence signals from 2 to 1
* LicenseManagerUserSubscriptions (3.7.401.47)
	* Updates entity to include Microsoft RDS SAL as a valid type of user subscription.
* RDS (3.7.410.36)
	* CloudWatch Database Insights now supports Amazon RDS.
* SageMaker (3.7.425.0)
	* Added new capability in the UpdateCluster operation to remove instance groups from your SageMaker HyperPod cluster.
* WorkSpacesWeb (3.7.403.0)
	* Add support for toolbar configuration under user settings.
* Core 3.7.402.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.986.0 (2025-02-19 19:26 UTC)
* CodePipeline (3.7.407.0)
	* Add environment variables to codepipeline action declaration.
* ECS (3.7.408.33)
	* This is a documentation only release for Amazon ECS that supports the CPU task limit increase.
* Lightsail (3.7.400.98)
	* Documentation updates for Amazon Lightsail.
* LocationService (3.7.401.0)
	* Adds support for larger property maps for tracking and geofence positions changes. It increases the maximum number of items from 3 to 4, and the maximum value length from 40 to 150.
* MailManager (3.7.405.0)
	* This release adds additional metadata fields in Mail Manager archive searches to show email source and details about emails that were archived when being sent with SES.
* NetworkFirewall (3.7.403.0)
	* This release introduces Network Firewall's Automated Domain List feature. New APIs include UpdateFirewallAnalysisSettings, StartAnalysisReport, GetAnalysisReportResults, and ListAnalysisReports. These allow customers to enable analysis on firewalls to identify and report frequently accessed domain.
* SageMaker (3.7.424.0)
	* Adds r8g instance type support to SageMaker Realtime Endpoints
* SimpleEmailV2 (3.7.408.0)
	* This release adds the ability for outbound email sent with SES to preserve emails to a Mail Manager archive.

### 3.7.985.0 (2025-02-18 19:25 UTC)
* Batch (3.7.404.32)
	* This documentation-only update corrects some typos.
* EMRContainers (3.7.402.0)
	* EMR on EKS StartJobRun Api will be supporting the configuration of log storage in AWS by using "managedLogs" under "MonitoringConfiguration".
* MediaLive (3.7.411.0)
	* Adds support for creating CloudWatchAlarmTemplates for AWS Elemental MediaTailor Playback Configuration resources.
* Core 3.7.402.3
	* Temporarily disable calculating `CRC64-NVME` checksums for responses, as it may cause issues when reading objects from S3 using the [Read-S3Object Cmdlet](https://docs.aws.amazon.com/powershell/latest/reference/items/Read-S3Object.html)
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.984.0 (2025-02-17 19:18 UTC)
* Amplify (3.7.404.0)
	* Add ComputeRoleArn to CreateApp, UpdateApp, CreateBranch, and UpdateBranch, allowing caller to specify a role to be assumed by Amplify Hosting for server-side rendered applications.
* DatabaseMigrationService (3.7.407.0)
	* Support replicationConfigArn in DMS DescribeApplicableIndividualAssessments API.
* TimestreamInfluxDB (3.7.406.0)
	* This release introduces APIs to manage DbClusters and adds support for read replicas
* Core 3.7.402.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.983.0 (2025-02-14 19:27 UTC)
* CodeBuild (3.7.410.0)
	* Added test suite names to test case metadata
* Connect (3.7.418.0)
	* Release Notes: 1) Analytics API enhancements: Added new ListAnalyticsDataLakeDataSets API. 2)  Onboarding API Idempotency: Adds ClientToken to instance creation and management APIs to support idempotency.
* DatabaseMigrationService (3.7.406.0)
	* Introduces premigration assessment feature to DMS Serverless API for start-replication and describe-replications
* RDSDataService (3.7.402.0)
	* Add support for Stop DB feature.
* S3 (3.7.415.0)
	* Added support for Content-Range header in HeadObject response.
* WAFV2 (3.7.403.0)
	* The WAFv2 API now supports configuring data protection in webACLs.
* WorkSpacesThinClient (3.7.402.0)
	* Update Environment and Device name field definitions

### 3.7.982.0 (2025-02-13 19:21 UTC)
* AccessAnalyzer (3.7.403.0)
	* This release introduces the getFindingsStatistics API, enabling users to retrieve aggregated finding statistics for IAM Access Analyzer's external access and unused access analysis features. Updated service API and documentation.
* ACMPCA (3.7.401.2)
	* Private Certificate Authority (PCA) documentation updates
* ECS (3.7.408.30)
	* This is a documentation only release to support migrating Amazon ECS service ARNs to the long ARN format.
* FIS (3.7.404.0)
	* Adds auto-pagination for the following operations: ListActions, ListExperimentTemplates, ListTargetAccountConfigurations, ListExperiments, ListExperimentResolvedTargets, ListTargetResourceTypes. Reduces length constraints of prefixes for logConfiguration and experimentReportConfiguration.
* SageMaker (3.7.423.0)
	* Adds additional values to the InferenceAmiVersion parameter in the ProductionVariant data type.
* StorageGateway (3.7.402.0)
	* This release adds support for generating cache reports on S3 File Gateways for files that fail to upload.
* Core 3.7.402.1
	* Add debug logging for EC2InstanceMetadata
	* All services packages updated to require new Core

### 3.7.981.0 (2025-02-12 19:25 UTC)
* B2bi (3.7.404.0)
	* Allow spaces in the following fields in the Partnership resource: ISA 06 - Sender ID, ISA 08 - Receiver ID, GS 02 - Application Sender Code, GS 03 - Application Receiver Code
* BedrockAgent (3.7.417.0)
	* This releases adds the additionalModelRequestFields field to the CreateAgent and UpdateAgent operations. Use additionalModelRequestFields to specify  additional inference parameters for a model beyond the base inference parameters.
* BedrockAgentRuntime (3.7.419.0)
	* This releases adds the additionalModelRequestFields field to the InvokeInlineAgent operation. Use additionalModelRequestFields to specify  additional inference parameters for a model beyond the base inference parameters.
* CodeBuild (3.7.409.8)
	* Add note for the RUNNER_BUILDKITE_BUILD buildType.
* FSx (3.7.403.0)
	* Support for in-place Lustre version upgrades
* MediaLive (3.7.410.0)
	* Adds a RequestId parameter to all MediaLive Workflow Monitor create operations.  The RequestId parameter allows idempotent operations.
* OpenSearchServerless (3.7.403.0)
	* Custom OpenSearchServerless Entity ID for SAML Config.
* Polly (3.7.402.0)
	* Added support for the new voice - Jasmine (en-SG). Jasmine is available as a Neural voice only.
* Core 3.7.402.0
	* Add support for calculating `CRC64-NVME` checksums when the AWS Common Runtime (CRT) is available as a dependency
	* Added check following double-checked locking optimization to validate _awsSigV4AProvider is not initialized after acquiring initial lock in AWS4aSignerCRTWrapper constructor.
	* All services packages updated to require new Core

### 3.7.980.0 (2025-02-11 19:58 UTC)
* ACMPCA (3.7.401.0)
	* Private Certificate Authority service now supports Partitioned CRL as a revocation configuration option.
* AppSync (3.7.406.0)
	* Add support for operation level caching
* EC2 (3.7.430.0)
	* Adding support for the new fullSnapshotSizeInBytes field in the response of the EC2 EBS DescribeSnapshots API. This field represents the size of all the blocks that were written to the source volume at the time the snapshot was created.
* PI (3.7.401.2)
	* Documentation only update for RDS Performance Insights dimensions for execution plans and locking analysis.
* Core 3.7.401.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.979.0 (2025-02-10 19:36 UTC)
* ApiGatewayV2 (3.7.401.0)
	* Documentation updates for Amazon API Gateway
* CloudFront (3.7.404.27)
	* Doc-only update that adds defaults for CloudFront VpcOriginEndpointConfig values.
* Connect (3.7.417.9)
	* Updated the CreateContact API documentation to indicate that it only applies to EMAIL contacts.
* DatabaseMigrationService (3.7.405.0)
	* New vendors for DMS Data Providers: DB2 LUW and DB2 for z/OS
* Core 3.7.401.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.978.0 (2025-02-07 19:19 UTC)
* ECR (3.7.409.0)
	* Adds support to handle the new basic scanning daily quota.
* EKS (3.7.410.0)
	* Introduce versionStatus field to take place of status field in EKS DescribeClusterVersions API
* MediaConvert (3.7.408.0)
	* This release adds support for Animated GIF output, forced chroma sample positioning metadata, and Extensible Wave Container format
* PI (3.7.401.0)
	* Adds documentation for dimension groups and dimensions to analyze locks for Database Insights.
* TranscribeService (3.7.402.0)
	* This release adds support for the Clinical Note Template Customization feature for the AWS HealthScribe APIs within Amazon Transcribe.
* Core 3.7.401.11
	* Update data integrity component to handle older versions of the `AWSSDK.S3` package when operations require a `Content-MD5` header
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.977.0 (2025-02-06 19:17 UTC)
* CloudFormation (3.7.402.0)
	* We added 5 new stack refactoring APIs: CreateStackRefactor, ExecuteStackRefactor, ListStackRefactors, DescribeStackRefactor, ListStackRefactorActions.
* ConnectCases (3.7.401.0)
	* This release adds the ability to conditionally require fields on a template. Check public documentation for more information.
* CostOptimizationHub (3.7.403.0)
	* This release enables AWS Cost Optimization Hub to show cost optimization recommendations for Amazon Auto Scaling Groups, including those with single and mixed instance types.
* S3 (3.7.414.0)
	* Updated list of the valid AWS Region values for the LocationConstraint parameter for general purpose buckets.
* Core 3.7.401.10
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.976.1 (2025-02-05 19:15 UTC)
* RDS (3.7.410.27)
	* Documentation updates to clarify the description for the parameter AllocatedStorage for the DB cluster data type, the description for the parameter DeleteAutomatedBackups for the DeleteDBCluster API operation, and removing an outdated note for the CreateDBParameterGroup API operation.
* Core 3.7.401.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.976.0 (2025-02-04 21:29 UTC)
* DatabaseMigrationService (3.7.404.0)
	* Introduces TargetDataSettings with the TablePreparationMode option available for data migrations.
* DataSync (3.7.403.3)
	* Doc-only update to provide more information on using Kerberos authentication with SMB locations.
* IdentityManagement (3.7.404.0)
	* This release adds support for accepting encrypted SAML assertions. Customers can now configure their identity provider to encrypt the SAML assertions it sends to IAM.
* NeptuneGraph (3.7.404.0)
	* Added argument to `list-export` to filter by graph ID
* QBusiness (3.7.409.0)
	* Adds functionality to enable/disable a new Q Business Chat orchestration feature. If enabled, Q Business can orchestrate over datasources and plugins without the need for customers to select specific chat modes.
* SageMaker (3.7.422.2)
	* IPv6 support for Hyperpod clusters
* Core 3.7.401.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.975.0 (2025-02-03 19:13 UTC)
* MediaTailor (3.7.402.0)
	* Add support for CloudWatch Vended Logs which allows for delivery of customer logs to CloudWatch Logs, S3, or Firehose.
* Core 3.7.401.7
	* Update `HttpRequestMessageFactory` to correctly set the `Content-Length` header for .NET Standard / .NET 8
	* All services packages updated to require new Core

### 3.7.974.0 (2025-01-31 19:21 UTC)
* BedrockAgentRuntime (3.7.418.0)
	* This change is to deprecate the existing citation field under RetrieveAndGenerateStream API response in lieu of GeneratedResponsePart and RetrievedReferences
* CodeBuild (3.7.409.0)
	* Added support for CodeBuild self-hosted Buildkite runner builds
* GeoRoutes (3.7.401.0)
	* The OptimizeWaypoints API now supports 50 waypoints per request (20 with constraints like AccessHours or AppointmentTime). It adds waypoint clustering via Clustering and ClusteringIndex for better optimization. Also, total distance validation is removed for greater flexibility.
* PrometheusService (3.7.402.0)
	* Add support for sending metrics to cross account and CMCK AMP workspaces through RoleConfiguration on Create/Update Scraper.
* RDS (3.7.410.24)
	* Updates to Aurora MySQL and Aurora PostgreSQL API pages with instance log type in the create and modify DB Cluster.
* SageMaker (3.7.422.0)
	* This release introduces a new valid value in InstanceType parameter: p5en.48xlarge, in ProductionVariant.

### 3.7.973.0 (2025-01-30 19:38 UTC)
* AppStream (3.7.405.0)
	* Add support for managing admin consent requirement on selected domains for OneDrive Storage Connectors in AppStream2.0.
* BedrockAgentRuntime (3.7.417.0)
	* Add a 'reason' field to InternalServerException
* ECR (3.7.408.0)
	* Temporarily updating dualstack endpoint support
* ECRPublic (3.7.404.0)
	* Temporarily updating dualstack endpoint support
* MediaTailor (3.7.401.0)
	* Adds options for configuring how MediaTailor conditions ads before inserting them into the content stream. Based on the new settings, MediaTailor will either transcode ads to match the content stream as it has in the past, or it will insert ads without first transcoding them.
* QBusiness (3.7.408.0)
	* Added APIs to manage QBusiness user subscriptions
* S3Tables (3.7.401.0)
	* You can now use the CreateTable API operation to create tables with schemas by adding an optional metadata argument.
* VerifiedPermissions (3.7.402.0)
	* Adds Cedar JSON format support for entities and context data in authorization requests
* Core 3.7.401.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.972.0 (2025-01-29 19:54 UTC)
* BCMPricingCalculator (3.7.403.0)
	* Added ConflictException error type in DeleteBillScenario, BatchDeleteBillScenarioCommitmentModification, BatchDeleteBillScenarioUsageModification, BatchUpdateBillScenarioUsageModification, and BatchUpdateBillScenarioCommitmentModification API operations.
* ECR (3.7.407.0)
	* Add support for Dualstack and Dualstack-with-FIPS Endpoints
* ECRPublic (3.7.403.0)
	* Add support for Dualstack Endpoints
* MailManager (3.7.404.0)
	* This release includes a new feature for Amazon SES Mail Manager which allows customers to specify known addresses and domains and make use of those in traffic policies and rules actions to distinguish between known and unknown entries.
* S3 (3.7.413.0)
	* Change the type of MpuObjectSize in CompleteMultipartUploadRequest from int to long.

### 3.7.971.0 (2025-01-28 19:20 UTC)
* AppSync (3.7.405.0)
	* Add stash and outErrors to EvaluateCode/EvaluateMappingTemplate response
* DataSync (3.7.403.0)
	* AWS DataSync now supports the Kerberos authentication protocol for SMB locations.
* Deadline (3.7.404.0)
	* feature: Deadline: Add support for limiting the concurrent usage of external resources, like floating licenses, using limits and the ability to constrain the maximum number of workers that work on a job
* DynamoDBv2 (3.7.405.12)
	* Fixed issue with TransactWrite in the DataModel where it wasn't correctly handling cases where only keys were being saved.
* EC2 (3.7.429.0)
	* This release changes the CreateFleet CLI and SDK's such that if you do not specify a client token, a randomly generated token is used for the request to ensure idempotency.
* KinesisFirehose (3.7.402.0)
	* For AppendOnly streams, Firehose will automatically scale to match your throughput.
* TimestreamInfluxDB (3.7.405.0)
	* Adds 'allocatedStorage' parameter to UpdateDbInstance API that allows increasing the database instance storage size and 'dbStorageType' parameter to UpdateDbInstance API that allows changing the storage type of the database instance

### 3.7.970.0 (2025-01-27 19:41 UTC)
* BedrockAgent (3.7.416.0)
	* Add support for the prompt caching feature for Bedrock Prompt Management
* IoT (3.7.406.0)
	* Raised the documentParameters size limit to 30 KB for AWS IoT Device Management - Jobs.
* MediaConvert (3.7.407.0)
	* This release adds support for dynamic audio configuration and the ability to disable the deblocking filter for h265 encodes.
* S3Control (3.7.405.0)
	* Minor fix to ARN validation for Lambda functions passed to S3 Batch Operations
* Core 3.7.401.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.969.0 (2025-01-24 19:24 UTC)
* CloudTrail (3.7.403.0)
	* This release introduces the SearchSampleQueries API that allows users to search for CloudTrail Lake sample queries.
* EKS (3.7.409.0)
	* Adds support for UpdateStrategies in EKS Managed Node Groups.
* HealthLake (3.7.401.0)
	* Added new authorization strategy value 'SMART_ON_FHIR' for CreateFHIRDatastore API to support Smart App 2.0
* SimpleSystemsManagement (3.7.403.29)
	* Systems Manager doc-only update for January, 2025.
* SSOOIDC (3.7.400.85)
	* Fixed typos in the descriptions.
* Transfer (3.7.404.0)
	* Added CustomDirectories as a new directory option for storing inbound AS2 messages, MDN files and Status files.

### 3.7.968.0 (2025-01-23 19:16 UTC)
* EC2 (3.7.428.0)
	* Added "future" allocation type for future dated capacity reservation
	* fix: Fixed an issue where custom AmazonEC2Client.DryRun() method was not working for non-BCL targets. Also included this method in IAmazonEC2 interface.

### 3.7.967.0 (2025-01-22 19:29 UTC)
* BedrockAgentRuntime (3.7.416.0)
	* Adds multi-turn input support for an Agent node in an Amazon Bedrock Flow
* Glue (3.7.413.15)
	* Docs Update for timeout changes
* MediaLive (3.7.409.0)
	* AWS Elemental MediaLive adds a new feature, ID3 segment tagging, in CMAF Ingest output groups. It allows customers to insert ID3 tags into every output segment, controlled by a newly added channel schedule action Id3SegmentTagging.
* WorkSpacesThinClient (3.7.401.4)
	* Rename WorkSpaces Web to WorkSpaces Secure Browser
* Core 3.7.401.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.966.0 (2025-01-21 20:07 UTC)
* Batch (3.7.404.18)
	* Documentation-only update: clarified the description of the shareDecaySeconds parameter of the FairsharePolicy data type, clarified the description of the priority parameter of the JobQueueDetail data type.
* CloudWatchLogs (3.7.409.19)
	* Documentation-only update to address doc errors
* CognitoIdentityProvider (3.7.406.0)
	* corrects the dual-stack endpoint configuration for cognitoidp
* Connect (3.7.417.0)
	* Added DeleteContactFlowVersion API and the CAMPAIGN flow type
* EMRServerless (3.7.403.0)
	* Increasing entryPoint in SparkSubmit to accept longer script paths. New limit is 4kb.
* IoTSiteWise (3.7.403.0)
	* AWS IoT SiteWise now supports ingestion and querying of Null (all data types) and NaN (double type) values of bad or uncertain data quality. New partial error handling prevents data loss during ingestion. Enabled by default for new customers; existing customers can opt-in.
* QuickSight (3.7.413.0)
	* Added `DigitGroupingStyle` in ThousandsSeparator to allow grouping by `LAKH`( Indian Grouping system ) currency. Support LAKH and `CRORE` currency types in Column Formatting.
* SimpleNotificationService (3.7.400.83)
	* This release adds support for the topic attribute FifoThroughputScope for SNS FIFO topics. For details, see the documentation history in the Amazon Simple Notification Service Developer Guide.
* Core 3.7.401.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.965.0 (2025-01-17 19:23 UTC)
* BedrockRuntime (3.7.412.0)
	* Allow hyphens in tool name for Converse and ConverseStream APIs
* Detective (3.7.400.82)
	* Doc only update for Detective documentation.
* EC2 (3.7.427.0)
	* Release u7i-6tb.112xlarge, u7i-8tb.112xlarge, u7inh-32tb.480xlarge, p5e.48xlarge, p5en.48xlarge, f2.12xlarge, f2.48xlarge, trn2.48xlarge instance types.
* Notifications (3.7.401.0)
	* Added support for Managed Notifications, integration with AWS Organization and added aggregation summaries for Aggregate Notifications
* SageMaker (3.7.421.1)
	* Correction of docs for  "Added support for ml.trn1.32xlarge instance type in Reserved Capacity Offering"
* Core 3.7.401.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.964.0 (2025-01-16 19:23 UTC)
* ECS (3.7.408.16)
	* The release addresses Amazon ECS documentation tickets.
* SageMaker (3.7.421.0)
	* Added support for ml.trn1.32xlarge instance type in Reserved Capacity Offering
* Core 3.7.401.1
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.963.0 (2025-01-15 20:19 UTC)
* APIGateway (3.7.401.24)
	* Documentation updates for Amazon API Gateway
* BedrockAgentRuntime (3.7.415.0)
	* Now supports streaming for inline agents.
* CognitoIdentity (3.7.402.0)
	* corrects the dual-stack endpoint configuration
* PartnerCentralSelling (3.7.403.0)
	* Add Tagging support for ResourceSnapshotJob resources
* S3 (3.7.412.0)
	* This change enhances integrity protections for new SDK requests to S3. S3 SDKs now support the CRC64NVME checksum algorithm, full object checksums for multipart S3 objects, and new default integrity protections for S3 requests.
	* In order to improve [data integrity](https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html), the AWS SDKs, including the AWS SDK for .NET, now automatically calculate checksums for all requests and responses that support it (using the `CRC32` algorithm by default). Although not recommended, you may disable the checksum validation by either: setting the `RequestChecksumCalculation` / `ResponseChecksumValidation` options of the `AmazonS3Config` to `WHEN_REQUIRED` (this will instruct the SDK to only calculate checksums when the service requires one) or setting the `DisableDefaultChecksumValidation` flag of the `PutObject` / `UploadPart` / `TransferUtilityUpload` operations to `false` (this will bypass the checksum calculations - meaning data integrity will rely only on SIGV4 payload signing and HTTPS).
	* BREAKING CHANGE: The `CompleteMultipartUploadRequest.AddPartETags` method now only includes ETags returned by `CopyObject` and `UploadPart` operations. This only impacts use cases where multi-part uploads were performed using the low-level APIs and a checksum algorithm was explicitly specified in the `InitiateMultipartUploadRequest`; to include additional checksums (such as `ChecksumCRC32` or `ChecksumSHA256`), use the new `AddPartETagsAndChecksums` method instead.
* SecurityIR (3.7.401.0)
	* Increase minimum length of Threat Actor IP 'userAgent' to 1.
* SimpleEmailV2 (3.7.407.0)
	* This release introduces a new recommendation in Virtual Deliverability Manager Advisor, which detects elevated complaint rates for customer sending identities.
* WorkSpaces (3.7.408.0)
	* Added GeneralPurpose.4xlarge & GeneralPurpose.8xlarge ComputeTypes.
* WorkSpacesThinClient (3.7.401.0)
	* Mark type in MaintenanceWindow as required.
* Core 3.7.401.0
	* Add `CRC32` implementation compatible with `HashAlgorithm` without requiring a CRT dependency
	* Add RequestChecksumCalculation and ResponseChecksumValidation configuration options
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.962.0 (2025-01-14 19:13 UTC)
* GameLift (3.7.404.0)
	* Amazon GameLift releases a new game session placement feature: PriorityConfigurationOverride. You can now override how a game session queue prioritizes placement locations for a single StartGameSessionPlacement request.
* Route53 (3.7.405.0)
	* Amazon Route 53 now supports the Mexico (Central) Region (mx-central-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region
* Core 3.7.400.79
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.961.0 (2025-01-13 19:18 UTC)
* Artifact (3.7.402.0)
	* Support resolving regional API calls to partition's leader region endpoint.
* Bedrock (3.7.413.0)
	* With this release, Bedrock Evaluation will now support latency-optimized inference for foundation models.
* EC2 (3.7.426.0)
	* Add support for DisconnectOnSessionTimeout flag in CreateClientVpnEndpoint and ModifyClientVpnEndpoint requests and DescribeClientVpnEndpoints responses
* KafkaConnect (3.7.401.0)
	* Support updating connector configuration via UpdateConnector API. Release Operations API to monitor the status of the connector operation.
* TranscribeService (3.7.401.0)
	* This update provides tagging support for Transcribe's Call Analytics Jobs and Call Analytics Categories.
* Core 3.7.400.78
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.960.1 (2025-01-10 21:22 UTC)
* Redshift (3.7.405.18)
	* Additions to the PubliclyAccessible and Encrypted parameters clarifying what the defaults are.
* SecurityLake (3.7.401.43)
	* Doc only update for ServiceName that fixes several customer-reported issues
* SecurityToken (3.7.401.26)
	* Fixed typos in the descriptions.
* Core 3.7.400.77
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.960.0 (2025-01-09 19:19 UTC)
* CodeBuild (3.7.408.0)
	* AWS CodeBuild Now Supports BuildBatch in Reserved Capacity and Lambda
* ComputeOptimizer (3.7.402.0)
	* This release expands AWS Compute Optimizer rightsizing recommendation support for Amazon EC2 Auto Scaling groups to include those with scaling policies and multiple instance types.
* FMS (3.7.402.0)
	* AWS Firewall Manager now lets you combine multiple resource tags using the logical AND operator or the logical OR operator.
* IoT1ClickDevicesService (Removed)
	* AWS IoT 1-Click Devices service has been removed from the SDK because it has been discontinued.
* IoT1ClickProjects (Removed)
	* AWS IoT 1-Click Projects service has been removed from the SDK because it has been discontinued.
* Core 3.7.400.76
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.959.0 (2025-01-08 19:18 UTC)
* RDS (3.7.410.12)
	* Updates Amazon RDS documentation to clarify the RestoreDBClusterToPointInTime description.
* Route53 (3.7.404.0)
	* Amazon Route 53 now supports the Asia Pacific (Thailand) Region (ap-southeast-7) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region
* SageMaker (3.7.420.0)
	* Adds support for IPv6 for SageMaker HyperPod cluster nodes.
* Core 3.7.400.75
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.958.0 (2025-01-07 19:16 UTC)
* CloudHSMV2 (3.7.402.0)
	* Adds support to ModifyCluster for modifying a Cluster's Hsm Type.
* DynamoDBv2 (3.7.405.0)
	* This release makes Amazon DynamoDB point-in-time-recovery (PITR) to be configurable. You can set PITR recovery period for each table individually to between 1 and 35 days.
* Imagebuilder (3.7.403.0)
	* This release adds support for importing images from ISO disk files. Added new ImportDiskImage API operation.
* Core 3.7.400.74
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.957.0 (2025-01-06 19:15 UTC)
* IoTSecureTunneling (3.7.401.0)
	* Adds dualstack endpoint support for IoT Secure Tunneling
* S3 (3.7.411.1)
	* Adjustments to S3 RequestsWith200Error request list generation.
* SupplyChain (3.7.404.0)
	* Allow vanity DNS domain when creating a new ASC instance
* Core 3.7.400.73
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.956.0 (2025-01-03 19:18 UTC)
* ECS (3.7.408.7)
	* Adding SDK reference examples for Amazon ECS operations.
* Route53Domains (3.7.401.9)
	* Doc only update for Route 53 Domains that fixes several customer-reported issues
* S3 (3.7.411.0)
	* This change is only for updating the model regexp of CopySource which is not for validation but only for documentation and user guide change.
* Core 3.7.400.72
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.955.0 (2025-01-02 19:23 UTC)
* AppSync (3.7.404.0)
	* Modify UpdateGraphQLAPI operation and flag authenticationType as required.
* GameLift (3.7.403.0)
	* Amazon GameLift releases a new game session shutdown feature. Use the Amazon GameLift console or AWS CLI to terminate an in-progress game session that's entered a bad state or is no longer needed.
* MediaConnect (3.7.403.0)
	* AWS Elemental MediaConnect now supports Content Quality Analysis for enhanced source stream monitoring. This enables you to track specific audio and video metrics in transport stream source flows, ensuring your content meets quality standards.
* MediaConvert (3.7.406.0)
	* This release adds support for the AVC3 codec and fixes an alignment issue with Japanese vertical captions.
* Organizations (3.7.405.0)
	* Added ALL_FEATURES_MIGRATION_ORGANIZATION_SIZE_LIMIT_EXCEEDED to ConstraintViolationException for the EnableAllFeatures operation.
* SageMaker (3.7.419.0)
	* Adding ETag information with Model Artifacts for Model Registry
* SQS (3.7.400.71)
	* In-flight message typo fix from 20k to 120k.
* Core 3.7.400.71
	* Updating endpoints.json file.
	* All services packages updated to require new Core

