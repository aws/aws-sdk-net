### 4.0.0.0-preview (2024-08-15 14:46 UTC)

* AWSSDK.Extensions.NETCore.Setup (4.0.0.0)
    * `DefaultClientConfig` in `AWSSDK.Extensions.NETCore.Setup` no longer extends from service client config base class `ClientConfig`. The service client config properties have been replicated on `DefaultClientConfig` using nullable value types to allow detecting when a value has been set on `DefaultClientConfig` when copying the values to the service client config being created for the service client.
	* Package has been marked as trim safe for Native AOT compilation.
	* Intellisense supported added for editing appsettings.json file.
* DynamoDBv2 (4.0.0.0)
    * In DynamoDB's high-level programming model, initializing the `Table` with a mocked `IAmazonDynamoDB` now returns an `InvalidOperationException` instead of a `NullReferenceException` . Async `Table` methods should now work with a mocked client but you may still see exceptions when calling sync methods from .NET/Core/Standard. See [PR #3388](https://github.com/aws/aws-sdk-net/pull/3388), this mostly addresses #1589.
	* In DynamoDB's object persistence programming model, we've separated the shared `DynamoDBOperationConfig` into new operation-specific objects (`SaveConfig`, `LoadConfig`, `QueryConfig`, etc.). The shared config has grown overtime, and contains properties that don't apply to every operation which can lead to confusion. we've marked the methods that take `DynamoDBOperationConfig` as obsolete. We won't remove them from V4 yet, though may do so in a future version. See [PR #3421](https://github.com/aws/aws-sdk-net/pull/3421)
	* In DynamoDB's object persistence programming model, we've removed `MetadataCachingMode` and `DisableFetchingTableMetadata` from `DynamoDBOperationConfig`, and did not include these on the new operation-specific configs that were introduced above. These are table-level settings that should be specified on the global `AWSConfigsDynamoDB.Context` or on `DynamoDBContextConfig`. See [PR #3422](https://github.com/aws/aws-sdk-net/pull/3422)
	* In DynamoDB's object persistence programming model, `DynamoDBOperationConfig` no longer inherits from `DynamoDBContextConfig`. This prevents you from passing a `DynamoDBOperationConfig` in to the constructor for `DynamoDBContext`, where some properties on the operation-specific config (such as `OverrideTableName`) do not apply. See [PR #3422](https://github.com/aws/aws-sdk-net/pull/3422)
* S3 (4.0.0.0)
    * S3 service clients configured for `us-east-1` will no longer be able to access buckets in other regions. Buckets musts be accessed with S3 service clients configured for the region the bucket is in. This change avoids surprises in applications using the S3 service client when under the covers it makes multiple AWS requests to access buckets that are not in service clients configured `us-east-1` region.
	* The S3 encryption client has been removed from the `AWSSDK.S3` package. This client had been marked as obsolete with the encryption client moved to its separate package `Amazon.Extensions.S3.Encryption` package. The following migration guide to transition to the separate package. https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/s3-encryption-migration.html 
* Core 4.0.0.0
	* Remove .NET Framework target 3.5
	* Update .NET Framework 4.5 target to 4.7.2
	* Properties using value types on classes used for making requests and responses have been changed to use nullable value types. Essentially properties of type `bool` are changed to `bool?`.
	* Properties using collections on classes used for making requests and responses will now default to `null`. The V3 behavior of initializing collections can be restored by setting the `Amazon.AWSConfigs.InitializeCollections` to `true`. This property also exists in V3 for users that want to try this behavior change before upgrading to V4.
	* The IAM action identifiers have been removed from the `Amazon.Auth.AccessControlPolicy.ActionIdentifiers` namespace. These identifiers were previously marked as obsolete due to be being out of date with no mechanism to keep them up to date. Code using these `ActionIdentifiers` should be upgrade to use the string value of the IAM action name.
	* The `DetermineServiceURL` method on the `ClientConfig`, the base class of service client configs like `AmazonS3Config`, was removed. This had been marked obsolete and was tied to an internal endpoint resolution system that was removed in V4. Application code calling this method should switch to using the `DetermineServiceOperationEndpoint` method on the service client.
	* When using credential providers that rely on Amazon Security Token Service (STS) the calls will always use the regional endpoint. V3 by default used `us-east-1` regardless of the configured region when running in the public partition. As part of this change the `StsRegionalEndpointsValue` enum was removed. Any code using that enum should be removed.
	* On service client configs the `RetryMode` defaults to `Standard` instead of `Legacy`. The `Legacy` enum value was removed.
	* On service client configs the `DefaultConfigurationMode` defaults to `Standard` instead of `Legacy`. The `Legacy` enum value was removed.
	* The System.Buffers, System.Memory and System.Text.Json packages have been added as dependencies for the .NET Framework and .NET Standard targets.
	* The embedded `endpoints.json` file in AWSSDK.Core was removed. This was a 1 MB json file that was parsed at startup for the SDK to determine the service endpoint for a region. Endpoint resolution has been replaced with a new system that generates rules into each individual service assembly for determining the service endpoints.
	* Community [PR #3359](https://github.com/aws/aws-sdk-net/pull/3359) Optimize GetExtension execution time on .NET 8. Thanks [Steven Weerdenburg](https://github.com/stevenaw)
    * Community [PR #3293](https://github.com/aws/aws-sdk-net/pull/3293) improving `AWSSDK.ToHex` performance. Thanks [Steven Weerdenburg](https://github.com/stevenaw)
    * Community [PR #3292](https://github.com/aws/aws-sdk-net/pull/3292) improving `AWSSDK.CopyTo` performance. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * Community [PR #3324](https://github.com/aws/aws-sdk-net/pull/3324) optimizing the AWS SigV4 signer. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * Community [PR #3363](https://github.com/aws/aws-sdk-net/pull/3363) improving `AWSSDKUtils.ParameterAsString` performance. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * Community [PR #3365](https://github.com/aws/aws-sdk-net/pull/3365) improving `AWSSDKUtils.DetermineService` performance. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * Community [PR #3307](https://github.com/aws/aws-sdk-net/pull/3307) Optimizing `AWSSDKUtils.UrlEncode` performance. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * Community [PR #3425](https://github.com/aws/aws-sdk-net/pull/3425) Avoid allocating byte[] when converting MemoryStream to String. Thanks [Paulo Morgado](https://github.com/paulomorgado)

### 3.7.857.0 (2024-08-02 18:27 UTC)
* CloudWatch (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ECS (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Glue (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Kinesis (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ResilienceHub (3.7.401.0)
	* Customers are presented with the grouping recommendations and can determine if the recommendations are accurate and apply to their case. This feature simplifies onboarding by organizing resources into appropriate AppComponents.
* Route53 (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* SimpleSystemsManagement (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* WAFRegional (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.

### 3.7.856.0 (2024-08-01 18:28 UTC)
* AWSSupport (3.7.400.3)
	* Doc only updates to CaseDetails
* Bedrock (3.7.401.0)
	* API and Documentation for Bedrock Model Copy feature. This feature lets you share and copy a custom model from one region to another or one account to another.
* ControlCatalog (3.7.401.0)
	* AWS Control Tower provides two new public APIs controlcatalog:ListControls and controlcatalog:GetControl under controlcatalog service namespace, which enable customers to programmatically retrieve control metadata of available controls.
* ControlTower (3.7.400.3)
	* Updated Control Tower service documentation for controlcatalog control ARN support with existing Control Tower public APIs
* IdentityManagement (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* MemoryDB (3.7.400.3)
	* Doc only update for changes to deletion API.
* RDS (3.7.401.0)
	* This release adds support for specifying optional MinACU parameter in CreateDBShardGroup and ModifyDBShardGroup API. DBShardGroup response will contain MinACU if specified.
* SageMaker (3.7.401.0)
	* This release adds support for Amazon EMR Serverless applications in SageMaker Studio for running data processing jobs.
* SSMQuickSetup (3.7.400.0)
	* This release adds API support for the QuickSetup feature of AWS Systems Manager

### 3.7.855.0 (2024-07-30 18:28 UTC)
* AppStream (3.7.401.0)
	* Added support for Red Hat Enterprise Linux 8 on Amazon AppStream 2.0
* AutoScaling (3.7.401.0)
	* Increase the length limit for VPCZoneIdentifier from 2047 to 5000
* CloudWatchLogs (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CodePipeline (3.7.401.0)
	* AWS CodePipeline V2 type pipelines now support stage level conditions to enable development teams to safely release changes that meet quality and compliance requirements.
* ElastiCache (3.7.400.2)
	* Doc only update for changes to deletion API.
* ElasticLoadBalancing (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* EventBridge (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* IAMRolesAnywhere (3.7.401.0)
	* IAM RolesAnywhere now supports custom role session name on the CreateSession. This release adds the acceptRoleSessionName option to a profile to control whether a role session name will be accepted in a session request with a given profile.
* LexModelsV2 (3.7.401.0)
	* This release adds new capabilities to the AMAZON.QnAIntent: Custom prompting, Guardrails integration and ExactResponse support for Bedrock Knowledge Base.
* Tnb (3.7.401.0)
	* This release adds Network Service Update, through which customers will be able to update their instantiated networks to a new network package. See the documentation for limitations. The release also enhances the Get network operation API to return parameter overrides used during the operation.
* WorkSpaces (3.7.400.2)
	* Removing multi-session as it isn't supported for pools
* Core 3.7.400.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.854.1 (2024-07-29 18:14 UTC)
* ElastiCache (3.7.400.1)
	* Renaming full service name as it appears in developer documentation.
* MemoryDB (3.7.400.1)
	* Renaming full service name as it appears in developer documentation.
* Core 3.7.400.1
	* Fixes the loop logic in ErrorHandler.ProcessException() and ErrorHandler.ProcessExceptionAsync() in case the initial exception is of type System.Exception.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.854.0 (2024-07-25 19:48 UTC)
* ApplicationAutoScaling (3.7.401.0)
	* Application Auto Scaling is now more responsive to the changes in demand of your SageMaker Inference endpoints. To get started, create or update a Target Tracking policy based on High Resolution CloudWatch metrics.
* ApplicationSignals (3.7.401.0)
	* CloudWatch Application Signals now supports application logs correlation with traces and operational health metrics of applications running on EC2 instances. Users can view the most relevant telemetry to troubleshoot application health anomalies such as spikes in latency, errors, and availability.
* BedrockRuntime (3.7.401.0)
	* Provides ServiceUnavailableException error message
* CloudSearch (3.7.400.1)
	* Removed hand-written integration tests
* CodeCommit (3.7.401.0)
	* CreateRepository API now throws OperationNotAllowedException when the account has been restricted from creating a repository.
* DataZone (3.7.401.0)
	* Introduces GetEnvironmentCredentials operation to SDK
* EC2 (3.7.401.0)
	* EC2 Fleet now supports using custom identifiers to reference Amazon Machine Images (AMI) in launch requests that are configured to choose from a diversified list of instance types.
* ECR (3.7.401.0)
	* API and documentation updates for Amazon ECR, adding support for creating, updating, describing and deleting ECR Repository Creation Template.
* EKS (3.7.401.0)
	* This release adds support for EKS cluster to manage extended support.
* ElasticLoadBalancingV2 (3.7.401.0)
	* This release adds support for sharing trust stores across accounts and organizations through integration with AWS Resource Access Manager.
* NetworkFirewall (3.7.401.0)
	* You can now log events that are related to TLS inspection, in addition to the existing alert and flow logging.
* Outposts (3.7.401.0)
	* Adding default vCPU information to GetOutpostSupportedInstanceTypes and GetOutpostInstanceTypes responses
* StepFunctions (3.7.401.0)
	* This release adds support to customer managed KMS key encryption in AWS Step Functions.

### 3.7.853.0 (2024-07-24 18:33 UTC)
* CleanRooms (3.7.400.0)
	* Three enhancements to the AWS Clean Rooms: Disallowed Output Columns, Flexible Result Receivers, SQL as a Seed
* DynamoDBv2 (3.7.400.0)
	* DynamoDB doc only update for July
* IoTSiteWise (3.7.400.0)
	* Adds support for creating SiteWise Edge gateways that run on a Siemens Industrial Edge Device.
* MediaPackageV2 (3.7.400.0)
	* This release adds support for Irdeto DRM encryption in DASH manifests.
* MedicalImaging (3.7.400.0)
	* CopyImageSet API adds copying selected instances between image sets, and overriding inconsistent metadata with a force parameter. UpdateImageSetMetadata API enables reverting to prior versions; updates to Study, Series, and SOP Instance UIDs; and updates to private elements, with a force parameter.
* PinpointSMSVoiceV2 (3.7.400.0)
	* Update for rebrand to AWS End User Messaging SMS and Voice.
* Core 3.7.400.0
	* Implement observability features in the SDK including metrics and tracing.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.852.0 (2024-07-23 18:25 UTC)
* AppSync (3.7.306.0)
	* Adding support for paginators in AppSync list APIs
* CleanRooms (3.7.305.0)
	* This release adds AWS Entity Resolution integration to associate ID namespaces & ID mapping workflow resources as part of ID namespace association and  ID mapping table  in AWS Clean Rooms. It also introduces a new ID_MAPPING_TABLE analysis rule to manage the protection on ID mapping table.
* CleanRoomsML (3.7.303.0)
	* Adds SQL query as the source of seed audience for audience generation job.
* Connect (3.7.324.0)
	* Added PostContactSummary segment type on ListRealTimeContactAnalysisSegmentsV2 API
* ConnectContactLens (3.7.301.0)
	* Added PostContactSummary segment type on ListRealTimeContactAnalysisSegments API
* DataZone (3.7.308.0)
	* This release removes the deprecated dataProductItem field from Search API output.
* EntityResolution (3.7.303.0)
	* Support First Party ID Mapping

### 3.7.851.0 (2024-07-22 20:09 UTC)
* DataZone (3.7.307.0)
	* This release adds 1/ support of register S3 locations of assets in AWS Lake Formation hybrid access mode for DefaultDataLake blueprint. 2/ support of CRUD operations for Asset Filters.
* IVS (3.7.305.0)
	* Documentation update for IVS Low Latency API Reference.
* Mobile (Removed)
	* AWS Mobile has been removed from the SDK because it has been discontinued.
* NeptuneGraph (3.7.306.0)
	* Amazon Neptune Analytics provides new options for customers to start with smaller graphs at a lower cost. CreateGraph, CreaateGraphImportTask, UpdateGraph and StartImportTask APIs will now allow 32 and 64 for `provisioned-memory`
* RedshiftServerless (3.7.304.0)
	* Adds dualstack support for Redshift Serverless workgroup.
* Core 3.7.304.31
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.850.0 (2024-07-18 19:42 UTC)
* ACMPCA (3.7.305.0)
	* Fix broken waiters for the acm-pca client.  Waiters broke in version 1.13.144 of the Boto3 SDK.
* Connect (3.7.323.0)
	* Amazon Connect expands search API coverage for additional resources.  Search for hierarchy groups by name, ID, tag, or other criteria (new endpoint). Search for agent statuses by name, ID, tag, or other criteria (new endpoint). Search for users by their assigned proficiencies (enhanced endpoint)
* EC2 (3.7.335.0)
	* Amazon VPC IP Address Manager (IPAM) now supports Bring-Your-Own-IP (BYOIP) for IP addresses registered with any Internet Registry. This feature uses DNS TXT records to validate ownership of a public IP address range.
* Ivschat (3.7.301.114)
	* Documentation update for IVS Chat API Reference.
* KinesisFirehose (3.7.307.0)
	* This release 1) Add configurable buffering hints for Snowflake as destination. 2) Add ReadFromTimestamp for MSK As Source. Firehose will start reading data from MSK Cluster using offset associated with this timestamp. 3) Gated public beta release to add Apache Iceberg tables as destination.
* MediaLive (3.7.309.0)
	* AWS Elemental MediaLive now supports the SRT protocol via the new SRT Caller input type.
* RDS (3.7.314.1)
	* Updates Amazon RDS documentation to specify an eventual consistency model for DescribePendingMaintenanceActions.
* SageMaker (3.7.332.0)
	* SageMaker Training supports R5, T3 and R5D instances family. And SageMaker Processing supports G5 and R5D instances family.
* SecretsManager (3.7.304.15)
	* Doc only update for Secrets Manager
* TaxSettings (3.7.301.0)
	* Set default endpoint for aws partition. Requests from all regions in aws partition will be forward to us-east-1 endpoint.
* TimestreamQuery (3.7.301.35)
	* Doc-only update for TimestreamQuery. Added guidance about the accepted valid value for the QueryPricingModel parameter.
* WorkSpacesThinClient (3.7.303.10)
	* Documentation update for WorkSpaces Thin Client.
* Core 3.7.304.30
	* Updated the generator to namespace RequestContext and DefaultRequest in clients to prevent naming collisions.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.849.0 (2024-07-12 18:57 UTC)
* ACMPCA (3.7.304.0)
	* Minor refactoring of C2J model for AWS Private CA
* ARCZonalShift (3.7.302.0)
	* Adds the option to subscribe to get notifications when a zonal autoshift occurs in a region.
* AutoScaling (3.7.304.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CodeBuild (3.7.311.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* DynamoDBv2 (3.7.305.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* GlobalAccelerator (3.7.303.0)
	* This feature adds exceptions to the Customer API to avoid throwing Internal Service errors
* Pinpoint (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* QuickSight (3.7.313.0)
	* Vega ally control options and Support for Reviewed Answers in Topics
* RDS (3.7.314.0)
	* Update path for CreateDBCluster resource identifier, and Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* SimpleNotificationService (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Core 3.7.304.29
	* If missing, prepend 'http://' to the value retreived from the HTTP_PROXY and HTTPS_PROXY environment variables for .NET Framework.
	* Update event stream apis use non blocking async io.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.848.0 (2024-07-10 18:59 UTC)
* Batch (3.7.308.0)
	* This feature allows AWS Batch Jobs with EKS container orchestration type to be run as Multi-Node Parallel Jobs.
* Bedrock (3.7.303.0)
	* Add support for contextual grounding check for Guardrails for Amazon Bedrock.
* BedrockAgent (3.7.311.0)
	* Introduces new data sources and chunking strategies for Knowledge bases, advanced parsing logic using FMs, session summary generation, and code interpretation (preview) for Claude V3 Sonnet and Haiku models. Also introduces Prompt Flows (preview) to link prompts, foundational models, and resources.
* BedrockAgentRuntime (3.7.309.0)
	* Introduces query decomposition, enhanced Agents integration with Knowledge bases, session summary generation, and code interpretation (preview) for Claude V3 Sonnet and Haiku models. Also introduces Prompt Flows (preview) to link prompts, foundational models, and resources for end-to-end solutions.
* BedrockRuntime (3.7.307.0)
	* Add support for contextual grounding check and ApplyGuardrail API for Guardrails for Amazon Bedrock.
* EC2 (3.7.334.0)
	* Add parameters to enable provisioning IPAM BYOIPv4 space at a Local Zone Network Border Group level
* Glue (3.7.319.0)
	* Add recipe step support for recipe node
* GroundStation (3.7.301.49)
	* Documentation update specifying OEM ephemeris units of measurement
* LicenseManagerLinuxSubscriptions (3.7.301.0)
	* Add support for third party subscription providers, starting with RHEL subscriptions through Red Hat Subscription Manager (RHSM). Additionally, add support for tagging subscription provider resources, and detect when an instance has more than one Linux subscription and notify the customer.
* MediaConnect (3.7.302.0)
	* AWS Elemental MediaConnect introduces the ability to disable outputs. Disabling an output allows you to keep the output attached to the flow, but stop streaming to the output destination. A disabled output does not incur data transfer costs.
* Core 3.7.304.28
	* Always retry on a clock skew error code even if the diff falls under the clockskew max threshold to eliminate race conditions in multi-threaded environments. 
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.847.0 (2024-07-09 18:20 UTC)
* DataZone (3.7.306.0)
	* This release deprecates dataProductItem field from SearchInventoryResultItem, along with some unused DataProduct shapes
* FSx (3.7.306.0)
	* Adds support for FSx for NetApp ONTAP 2nd Generation file systems, and FSx for OpenZFS Single AZ HA file systems.
* OpenSearchService (3.7.311.0)
	* This release adds support for enabling or disabling Natural Language Query Processing feature for Amazon OpenSearch Service domains, and provides visibility into the current state of the setup or tear-down.
* SageMaker (3.7.331.0)
	* This release 1/ enables optimization jobs that allows customers to perform Ahead-of-time compilation and quantization. 2/ allows customers to control access to Amazon Q integration in SageMaker Studio. 3/ enables AdditionalModelDataSources for CreateModel action.
* Core 3.7.304.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.846.0 (2024-07-08 18:36 UTC)
* CodeDeploy (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* DatabaseMigrationService (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* DeviceFarm (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ElasticBeanstalk (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Elasticsearch (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* GameLift (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* KinesisFirehose (3.7.306.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* QApps (3.7.300.0)
	* This is a general availability (GA) release of Amazon Q Apps, a capability of Amazon Q Business. Q Apps leverages data sources your company has provided to enable users to build, share, and customize apps within your organization.
* Route53Resolver (3.7.304.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* SimpleEmail (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Core 3.7.304.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.845.0 (2024-07-05 18:18 UTC)
* CertificateManager (3.7.301.16)
	* Documentation updates, including fixes for xml formatting, broken links, and ListCertificates description.
* ECR (3.7.303.0)
	* This release for Amazon ECR makes change to bring the SDK into sync with the API.
* PaymentCryptographyData (3.7.303.0)
	* Added further restrictions on logging of potentially sensitive inputs and outputs.
* QBusiness (3.7.305.0)
	* Add personalization to Q Applications. Customers can enable or disable personalization when creating or updating a Q application with the personalization configuration.
* Core 3.7.304.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.844.0 (2024-07-03 18:24 UTC)
* ApplicationAutoScaling (3.7.303.3)
	* Doc only update for Application Auto Scaling that fixes resource name.
* DirectConnect (3.7.301.6)
	* This update includes documentation for support of new native 400 GBps ports for Direct Connect.
* Organizations (3.7.303.0)
	* Added a new reason under ConstraintViolationException in RegisterDelegatedAdministrator API to prevent registering suspended accounts as delegated administrator of a service.
* Rekognition (3.7.304.0)
	* This release adds support for tagging projects and datasets with the CreateProject and CreateDataset APIs.
* WorkSpaces (3.7.306.0)
	* Fix create workspace bundle RootStorage/UserStorage to accept non null values
* Core 3.7.304.24
	* Update the SDK not to perform dynamic endpoint discovery when a service URL is explicitly configured
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.843.0 (2024-07-02 18:19 UTC)
* EC2 (3.7.333.0)
	* Documentation updates for Elastic Compute Cloud (EC2).
* FMS (3.7.303.0)
	* Increases Customer API's ManagedServiceData length
* S3 (3.7.310.0)
	* Added response overrides to Head Object requests.

### 3.7.842.0 (2024-07-01 19:49 UTC)
* APIGateway (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CognitoIdentity (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Connect (3.7.322.0)
	* Authentication profiles are Amazon Connect resources (in gated preview) that allow you to configure authentication settings for users in your contact center. This release adds support for new ListAuthenticationProfiles, DescribeAuthenticationProfile and UpdateAuthenticationProfile APIs.
* DocDB (3.7.304.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* EKS (3.7.309.0)
	* Updates EKS managed node groups to support EC2 Capacity Blocks for ML
* PaymentCryptography (3.7.304.0)
	* Added further restrictions on logging of potentially sensitive inputs and outputs.
* PaymentCryptographyData (3.7.302.0)
	* Adding support for dynamic keys for encrypt, decrypt, re-encrypt and translate pin functions.  With this change, customers can use one-time TR-31 keys directly in dataplane operations without the need to first import them into the service.
* SimpleWorkflow (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* StepFunctions (3.7.304.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* WAFV2 (3.7.305.18)
	* JSON body inspection: Update documentation to clarify that JSON parsing doesn't include full validation.
* Core 3.7.304.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.841.0 (2024-06-28 19:23 UTC)
* ACMPCA (3.7.303.0)
	* Added CCPC_LEVEL_1_OR_HIGHER KeyStorageSecurityStandard and SM2 KeyAlgorithm and SM3WITHSM2 SigningAlgorithm for China regions.
* CloudHSMV2 (3.7.302.0)
	* Added 3 new APIs to support backup sharing: GetResourcePolicy, PutResourcePolicy, and DeleteResourcePolicy. Added BackupArn to the output of the DescribeBackups API. Added support for BackupArn in the CreateCluster API.
* Connect (3.7.321.0)
	* This release supports showing PreferredAgentRouting step via DescribeContact API.
* DynamoDBv2 (3.7.304.1)
	* Fixed an issue where RetrieveDateTimeInUtc is ignored when using nullable DateTime
* ElasticMapReduce (3.7.305.0)
	* This release provides the support for new allocation strategies i.e. CAPACITY_OPTIMIZED_PRIORITIZED for Spot and PRIORITIZED for On-Demand by taking input of priority value for each instance type for instance fleet clusters.
* Glue (3.7.318.0)
	* Added AttributesToGet parameter to Glue GetDatabases, allowing caller to limit output to include only the database name.
* KinesisAnalyticsV2 (3.7.304.0)
	* Support for Flink 1.19 in Managed Service for Apache Flink
* OpenSearchService (3.7.310.0)
	* This release removes support for enabling or disabling Natural Language Query Processing feature for Amazon OpenSearch Service domains.
* PI (3.7.301.18)
	* Noting that the filter db.sql.db_id isn't available for RDS for SQL Server DB instances.
* WorkSpaces (3.7.305.0)
	* Added support for Red Hat Enterprise Linux 8 on Amazon WorkSpaces Personal.
* Core 3.7.304.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.840.0 (2024-06-27 18:21 UTC)
* ApplicationAutoScaling (3.7.303.0)
	* Amazon WorkSpaces customers can now use Application Auto Scaling to automatically scale the number of virtual desktops in a WorkSpaces pool.
* ChimeSDKMediaPipelines (3.7.301.0)
	* Added Amazon Transcribe multi language identification to Chime SDK call analytics. Enabling customers sending single stream audio to generate call recordings using Chime SDK call analytics
* CloudFront (3.7.303.17)
	* Doc only update for CloudFront that fixes customer-reported issue
* DataZone (3.7.305.0)
	* This release supports the data lineage feature of business data catalog in Amazon DataZone.
* DynamoDBv2 (3.7.304.0)
	* Add support for update and condition expressions to DynamoDB transactional writes that are created using the document model or the object-persistence model.
* ElastiCache (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* MQ (3.7.301.0)
	* This release makes the EngineVersion field optional for both broker and configuration and uses the latest available version by default. The AutoMinorVersionUpgrade field is also now optional for broker creation and defaults to 'true'.
* QConnect (3.7.305.0)
	* Adds CreateContentAssociation, ListContentAssociations, GetContentAssociation, and DeleteContentAssociation APIs.
* QuickSight (3.7.312.0)
	* Adding support for Repeating Sections, Nested Filters
* RDS (3.7.313.18)
	* Updates Amazon RDS documentation for TAZ export to S3.
* SageMaker (3.7.330.0)
	* Add capability for Admins to customize Studio experience for the user by showing or hiding Apps and MLTools.
* WorkSpaces (3.7.304.0)
	* Added support for WorkSpaces Pools.
* Core 3.7.304.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.839.0 (2024-06-26 18:19 UTC)
* ControlTower (3.7.306.0)
	* Added ListLandingZoneOperations API.
* EKS (3.7.308.0)
	* Added support for disabling unmanaged addons during cluster creation.
* IVSRealTime (3.7.305.0)
	* IVS Real-Time now offers customers the ability to upload public keys for customer vended participant tokens.
* KinesisAnalyticsV2 (3.7.303.0)
	* This release adds support for new ListApplicationOperations and DescribeApplicationOperation APIs. It adds a new configuration to enable system rollbacks, adds field ApplicationVersionCreateTimestamp for clarity and improves support for pagination for APIs.
* OpenSearchService (3.7.309.0)
	* This release adds support for enabling or disabling Natural Language Query Processing feature for Amazon OpenSearch Service domains, and provides visibility into the current state of the setup or tear-down.

### 3.7.838.0 (2024-06-25 18:24 UTC)
* AutoScaling (3.7.303.0)
	* Doc only update for Auto Scaling's TargetTrackingMetricDataQuery
* EC2 (3.7.332.0)
	* This release is for the launch of the new u7ib-12tb.224xlarge, R8g, c7gn.metal and mac2-m1ultra.metal instance types
* NetworkManager (3.7.302.0)
	* This is model changes & documentation update for the Asynchronous Error Reporting feature for AWS Cloud WAN. This feature allows customers to view errors that occur while their resources are being provisioned, enabling customers to fix their resources without needing external support.
* S3 (3.7.309.9)
	* Add additional requests types to be retried for requests that return a 200 status code and an error in the body.
* WorkSpacesThinClient (3.7.303.0)
	* This release adds the deviceCreationTags field to CreateEnvironment API input, UpdateEnvironment API input and GetEnvironment API output.

### 3.7.837.0 (2024-06-24 21:16 UTC)
* BedrockRuntime (3.7.306.0)
	* Increases Converse API's document name length
* CustomerProfiles (3.7.302.0)
	* This release includes changes to ProfileObjectType APIs, adds functionality top set and get capacity for profile object types.
* EC2 (3.7.331.0)
	* Fix EC2 multi-protocol info in models.
* QBusiness (3.7.304.0)
	* Allow enable/disable Q Apps when creating/updating a Q application; Return the Q Apps enablement information when getting a Q application.
* SimpleSystemsManagement (3.7.305.0)
	* Add sensitive trait to SSM IPAddress property for CloudTrail redaction
* WorkSpacesWeb (3.7.302.0)
	* Added ability to enable DeepLinking functionality on a Portal via UserSettings as well as added support for IdentityProvider resource tagging.
* Core 3.7.304.20
	* Add implicit global region to internal partition metadata
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.836.0 (2024-06-20 18:27 UTC)
* BedrockRuntime (3.7.305.0)
	* This release adds document support to Converse and ConverseStream APIs
* CodeArtifact (3.7.303.0)
	* Add support for the Cargo package format.
* ComputeOptimizer (3.7.303.0)
	* This release enables AWS Compute Optimizer to analyze and generate optimization recommendations for Amazon RDS MySQL and RDS PostgreSQL.
* CostOptimizationHub (3.7.302.0)
	* This release enables AWS Cost Optimization Hub to show cost optimization recommendations for Amazon RDS MySQL and RDS PostgreSQL.
* DynamoDBv2 (3.7.303.25)
	* Doc-only update for DynamoDB. Fixed Important note in 6 Global table APIs - CreateGlobalTable, DescribeGlobalTable, DescribeGlobalTableSettings, ListGlobalTables, UpdateGlobalTable, and UpdateGlobalTableSettings.
	* Fixed an issue causing DynamoDB context save to fail if the model object inherits a base class that contains members with the same name
* Glue (3.7.317.0)
	* Fix Glue paginators for Jobs, JobRuns, Triggers, Blueprints and Workflows.
* IVSRealTime (3.7.304.0)
	* IVS Real-Time now offers customers the ability to record individual stage participants to S3.
* SageMaker (3.7.329.0)
	* Adds support for model references in Hub service, and adds support for cross-account access of Hubs
* SecurityHub (3.7.306.11)
	* Documentation updates for Security Hub
* Core 3.7.304.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.835.0 (2024-06-19 18:25 UTC)
* Artifact (3.7.301.0)
	* This release adds an acceptanceType field to the ReportSummary structure (used in the ListReports API response).
* Athena (3.7.305.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CostAndUsageReport (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* DirectConnect (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ElasticTranscoder (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* OpenSearchService (3.7.308.0)
	* This release enables customers to use JSON Web Tokens (JWT) for authentication on their Amazon OpenSearch Service domains.
* Core 3.7.304.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.834.0 (2024-06-18 18:29 UTC)
* BedrockRuntime (3.7.304.0)
	* This release adds support for using Guardrails with the Converse and ConverseStream APIs.
* CloudTrail (3.7.306.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ConfigService (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* EKS (3.7.307.0)
	* This release adds support to surface async fargate customer errors from async path to customer through describe-fargate-profile API response.
* Lightsail (3.7.306.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Polly (3.7.304.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Rekognition (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* SageMaker (3.7.328.0)
	* Launched a new feature in SageMaker to provide managed MLflow Tracking Servers for customers to track ML experiments. This release also adds a new capability of attaching additional storage to SageMaker HyperPod cluster instances.
* SecurityToken (3.7.300.107)
	* Added support for Tags and TransitiveTagKeys in ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication() method.
* Shield (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Snowball (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Core 3.7.304.17
	* Added Tags and TransitiveTagKeys properties to AssumeRoleAWSCredentialsOptions class.
	* All services packages updated to require new Core

### 3.7.833.0 (2024-06-17 18:31 UTC)
* ACMPCA (3.7.302.14)
	* Doc-only update that adds name constraints as an allowed extension for ImportCertificateAuthorityCertificate.
* Batch (3.7.307.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CodeBuild (3.7.310.0)
	* AWS CodeBuild now supports global and organization GitHub webhooks
* CognitoIdentityProvider (3.7.306.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* DirectoryService (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* ElasticFileSystem (3.7.303.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Glue (3.7.316.0)
	* This release introduces a new feature, Usage profiles. Usage profiles allow the AWS Glue admin to create different profiles for various classes of users within the account, enforcing limits and defaults for jobs and sessions.
* KeyManagementService (3.7.304.1)
	* Updating SDK example for KMS DeriveSharedSecret API.
* MediaConvert (3.7.306.0)
	* This release includes support for creating I-frame only video segments for DASH trick play.
* SecretsManager (3.7.304.1)
	* Doc only update for Secrets Manager
* WAF (3.7.301.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.

### 3.7.832.0 (2024-06-14 18:24 UTC)
* DataZone (3.7.304.0)
	* This release introduces a new default service blueprint for custom environment creation.
* EC2 (3.7.330.1)
	* Documentation updates for Amazon EC2.
* Macie2 (3.7.303.0)
	* This release adds support for managing the status of automated sensitive data discovery for individual accounts in an organization, and determining whether individual S3 buckets are included in the scope of the analyses.
* MediaConvert (3.7.305.0)
	* This release adds the ability to search for historical job records within the management console using a search box and/or via the SDK/CLI with partial string matching search on input file name.
* Route53Domains (3.7.302.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.

### 3.7.831.0 (2024-06-13 18:19 UTC)
* CloudHSMV2 (3.7.301.0)
	* Added support for hsm type hsm2m.medium. Added supported for creating a cluster in FIPS or NON_FIPS mode.
* Glue (3.7.315.0)
	* This release adds support for configuration of evaluation method for composite rules in Glue Data Quality rulesets.
* IoTWireless (3.7.304.0)
	* Add RoamingDeviceSNR and RoamingDeviceRSSI to Customer Metrics.
* KeyManagementService (3.7.304.0)
	* This feature allows customers to use their keys stored in KMS to derive a shared secret which can then be used to establish a secured channel for communication, provide proof of possession, or establish trust with other parties.
* MediaPackageV2 (3.7.303.0)
	* This release adds support for CMAF ingest (DASH-IF live media ingest protocol interface 1)

### 3.7.830.0 (2024-06-12 18:24 UTC)
* AppTest (3.7.300.0)
	* AWS Mainframe Modernization Application Testing is an AWS Mainframe Modernization service feature that automates functional equivalence testing for mainframe application modernization and migration to AWS, and regression testing.
* EC2 (3.7.330.0)
	* Tagging support for Traffic Mirroring FilterRule resource
* BackupStorage (Removed)
	* AWS Backup Storage has been removed from the SDK.
* OSIS (3.7.303.0)
	* SDK changes for self-managed vpc endpoint to OpenSearch ingestion pipelines.
* Redshift (3.7.305.31)
	* Updates to remove DC1 and DS2 node types.
* SecretsManager (3.7.304.0)
	* Introducing RotationToken parameter for PutSecretValue API
* SecurityLake (3.7.302.0)
	* This release updates request validation regex to account for non-commercial aws partitions.
* SimpleEmailV2 (3.7.304.0)
	* This release adds support for Amazon EventBridge as an email sending events destination.
* Core 3.7.304.16
	* Omit the Content-Type header for requests without bodies
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.829.0 (2024-06-11 18:32 UTC)
* AccessAnalyzer (3.7.304.0)
	* IAM Access Analyzer now provides policy recommendations to help resolve unused permissions for IAM roles and users. Additionally, IAM Access Analyzer now extends its custom policy checks to detect when IAM policies grant public access or access to critical resources ahead of deployments.
* GuardDuty (3.7.307.0)
	* Added API support for GuardDuty Malware Protection for S3.
* NetworkManager (3.7.301.0)
	* This is model changes & documentation update for Service Insertion feature for AWS Cloud WAN. This feature allows insertion of AWS/3rd party security services on Cloud WAN. This allows to steer inter/intra segment traffic via security appliances and provide visibility to the route updates.
* PcaConnectorScep (3.7.300.0)
	* Connector for SCEP allows you to use a managed, cloud CA to enroll mobile devices and networking gear. SCEP is a widely-adopted protocol used by mobile device management (MDM) solutions for enrolling mobile devices. With the connector, you can use AWS Private CA with popular MDM solutions.
* SageMaker (3.7.327.0)
	* Introduced Scope and AuthenticationRequestExtraParams to SageMaker Workforce OIDC configuration; this allows customers to modify these options for their private Workforce IdP integration. Model Registry Cross-account model package groups are discoverable.
* Core 3.7.304.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.828.0 (2024-06-10 18:14 UTC)
* ApplicationSignals (3.7.300.0)
	* This is the initial SDK release for Amazon CloudWatch Application Signals. Amazon CloudWatch Application Signals provides curated application performance monitoring for developers to monitor and troubleshoot application health using pre-built dashboards and Service Level Objectives.
* ECS (3.7.306.0)
	* This release introduces a new cluster configuration to support the customer-managed keys for ECS managed storage encryption.
* Imagebuilder (3.7.304.0)
	* This release updates the regex pattern for Image Builder ARNs.
* Core 3.7.304.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.827.0 (2024-06-07 18:16 UTC)
* AuditManager (3.7.301.0)
	* New feature: common controls. When creating custom controls, you can now use pre-grouped AWS data sources based on common compliance themes. Also, the awsServices parameter is deprecated because we now manage services in scope for you. If used, the input is ignored and an empty list is returned.
* B2bi (3.7.304.0)
	* Added exceptions to B2Bi List operations and ConflictException to B2Bi StartTransformerJob operation. Also made capabilities field explicitly required when creating a Partnership.
* CodePipeline (3.7.305.0)
	* CodePipeline now supports overriding S3 Source Object Key during StartPipelineExecution, as part of Source Overrides.
* SageMaker (3.7.326.0)
	* This release introduces a new optional parameter: InferenceAmiVersion, in ProductionVariant.
* VerifiedPermissions (3.7.307.0)
	* This release adds OpenIdConnect (OIDC) configuration support for IdentitySources, allowing for external IDPs to be used in authorization requests.
* Core 3.7.304.13
	* Update NoProxy Filter for netframework to do suffix matching, to follow the same behavior as the AWS CLI.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.826.0 (2024-06-06 18:22 UTC)
* Account (3.7.301.0)
	* This release adds 3 new APIs (AcceptPrimaryEmailUpdate, GetPrimaryEmail, and StartPrimaryEmailUpdate) used to centrally manage the root user email address of member accounts within an AWS organization.
* FSx (3.7.305.0)
	* This release adds support to increase metadata performance on FSx for Lustre file systems beyond the default level provisioned when a file system is created. This can be done by specifying MetadataConfiguration during the creation of Persistent_2 file systems or by updating it on demand.
* Glue (3.7.314.0)
	* This release adds support for creating and updating Glue Data Catalog Views.
* IoTWireless (3.7.303.0)
	* Adds support for wireless device to be in Conflict FUOTA Device Status due to a FUOTA Task, so it couldn't be attached to a new one.
* KinesisFirehose (3.7.305.0)
	* Adds integration with Secrets Manager for Redshift, Splunk, HttpEndpoint, and Snowflake destinations
* LocationService (3.7.305.0)
	* Added two new APIs, VerifyDevicePosition and ForecastGeofenceEvents. Added support for putting larger geofences up to 100,000 vertices with Geobuf fields.
* SimpleNotificationService (3.7.301.50)
	* Doc-only update for SNS. These changes include customer-reported issues and TXC3 updates.
* SQS (3.7.301.15)
	* Doc only updates for SQS. These updates include customer-reported issues and TCX3 modifications.
* StorageGateway (3.7.303.0)
	* Adds SoftwareUpdatePreferences to DescribeMaintenanceStartTime and UpdateMaintenanceStartTime, a structure which contains AutomaticUpdatePolicy.

### 3.7.825.0 (2024-06-05 18:59 UTC)
* GlobalAccelerator (3.7.302.0)
	* This release contains a new optional ip-addresses input field for the update accelerator and update custom routing accelerator apis. This input enables consumers to replace IPv4 addresses on existing accelerators with addresses provided in the input.
* Glue (3.7.313.0)
	* AWS Glue now supports native SaaS connectivity: Salesforce connector available now
* S3 (3.7.309.0)
	* Added new params copySource and key to copyObject API for supporting S3 Access Grants plugin. These changes will not change any of the existing S3 API functionality.
* Core 3.7.304.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.824.0 (2024-06-04 18:15 UTC)
* EC2 (3.7.329.0)
	* U7i instances with up to 32 TiB of DDR5 memory and 896 vCPUs are now available. C7i-flex instances are launched and are lower-priced variants of the Amazon EC2 C7i instances that offer a baseline level of CPU performance with the ability to scale up to the full compute performance 95% of the time.
* Pipes (3.7.304.0)
	* This release adds Timestream for LiveAnalytics as a supported target in EventBridge Pipes
* SageMaker (3.7.325.0)
	* Extend DescribeClusterNode response with private DNS hostname and IP address, and placement information about availability zone and availability zone ID.
* TaxSettings (3.7.300.0)
	* Initial release of AWS Tax Settings API
* Core 3.7.304.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.823.0 (2024-06-03 18:20 UTC)
* Amplify (3.7.302.15)
	* This doc-only update identifies fields that are specific to Gen 1 and Gen 2 applications.
* Batch (3.7.306.0)
	* This release adds support for the AWS Batch GetJobQueueSnapshot API operation.
* DynamoDBv2 (3.7.303.16)
	* Improve handling of primary keys with property converters when using the object-persistence programming model with DisableFetchingTableMetadata set to true.
* EKS (3.7.306.0)
	* Adds support for EKS add-ons pod identity associations integration
* IoTTwinMaker (3.7.302.0)
	* Support RESET_VALUE UpdateType for PropertyUpdates to reset property value to default or null
* S3 (3.7.308.8)
	* Fixed issue with certain request parameters not being included as part of the request endpoint calculation.
* Core 3.7.304.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.822.0 (2024-05-31 18:27 UTC)
* CodeBuild (3.7.309.2)
	* AWS CodeBuild now supports Self-hosted GitHub Actions runners for Github Enterprise
* CodeGuruSecurity (3.7.301.0)
	* This release includes minor model updates and documentation updates.
* ElastiCache (3.7.302.36)
	* Update to attributes of TestFailover and minor revisions.
* LaunchWizard (3.7.301.0)
	* This release adds support for describing workload deployment specifications, deploying additional workload types, and managing tags for Launch Wizard resources with API operations.
* Core 3.7.304.9
	* Updated custom user agent header string to comply with User Agent 2.0 standards.

### 3.7.821.0 (2024-05-30 18:23 UTC)
* BedrockAgent (3.7.310.0)
	* With this release, Knowledge bases for Bedrock adds support for Titan Text Embedding v2.
* BedrockRuntime (3.7.303.0)
	* This release adds Converse and ConverseStream APIs to Bedrock Runtime
* CertificateManager (3.7.301.0)
	* add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CloudTrail (3.7.305.0)
	* CloudTrail Lake returns PartitionKeys in the GetEventDataStore API response. Events are grouped into partitions based on these keys for better query performance. For example, the calendarday key groups events by day, while combining the calendarday key with the hour key groups them by day and hour.
* Connect (3.7.320.0)
	* Adding associatedQueueIds as a SearchCriteria and response field to the SearchRoutingProfiles API
* EMRServerless (3.7.304.0)
	* The release adds support for spark structured streaming.
* RDS (3.7.313.6)
	* Updates Amazon RDS documentation for Aurora Postgres DBname.
* SageMaker (3.7.324.0)
	* Adds Model Card information as a new component to Model Package. Autopilot launches algorithm selection for TimeSeries modality to generate AutoML candidates per algorithm.
* Core 3.7.304.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.820.0 (2024-05-29 18:20 UTC)
* Athena (3.7.304.0)
	* Throwing validation errors on CreateNotebook with Name containing `/`,`:`,`\`
* CodeBuild (3.7.309.0)
	* AWS CodeBuild now supports manually creating GitHub webhooks
* Connect (3.7.319.0)
	* This release includes changes to DescribeContact API's response by including ConnectedToSystemTimestamp, RoutingCriteria, Customer, Campaign, AnsweringMachineDetectionStatus, CustomerVoiceActivity, QualityMetrics, DisconnectDetails, and SegmentAttributes information from a contact in Amazon Connect.
* Glue (3.7.312.0)
	* Add optional field JobMode to CreateJob and UpdateJob APIs.
* S3 (3.7.308.6)
	* Fixed a bug where a multipart upload was being done in the case where a stream was not seekable but had a known content length. If a stream is unseekable but has a content length, a simple upload will be performed unless the size is greater than config.minPartBeforePartUpload.
* SecurityHub (3.7.306.0)
	* Add ROOT type for TargetType model
* Core 3.7.304.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.819.0 (2024-05-28 18:16 UTC)
* DynamoDBv2 (3.7.303.13)
	* Doc-only update for DynamoDB. Specified the IAM actions needed to authorize a user to create a table with a resource-based policy.
* EC2 (3.7.328.0)
	* Providing support to accept BgpAsnExtended attribute
* Kafka (3.7.304.0)
	* Adds ControllerNodeInfo in ListNodes response to support Raft mode for MSK
* SimpleWorkflow (3.7.301.0)
	* This release adds new APIs for deleting activity type and workflow type resources.
* Core 3.7.304.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.818.0 (2024-05-24 18:38 UTC)
* DynamoDBv2 (3.7.303.12)
	* Documentation only updates for DynamoDB.
* IoTFleetWise (3.7.304.0)
	* AWS IoT FleetWise now supports listing vehicles with attributes filter, ListVehicles API is updated to support additional attributes filter.
* ManagedBlockchain (3.7.301.88)
	* This is a minor documentation update to address the impact of the shut down of the Goerli and Polygon networks.

### 3.7.817.0 (2024-05-23 18:14 UTC)
* EMRServerless (3.7.303.0)
	* This release adds the capability to run interactive workloads using Apache Livy Endpoint.
* OpsWorks (3.7.300.95)
	* Documentation-only update for OpsWorks Stacks.
* Core 3.7.304.5
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.816.0 (2024-05-22 18:18 UTC)
* Chatbot (3.7.301.0)
	* This change adds support for tagging Chatbot configurations.
* CloudFormation (3.7.308.0)
	* Added DeletionMode FORCE_DELETE_STACK for deleting a stack that is stuck in DELETE_FAILED state due to resource deletion failure.
* KeyManagementService (3.7.303.0)
	* This release includes feature to import customer's asymmetric (RSA, ECC and SM2) and HMAC keys into KMS in China.
* OpenSearchService (3.7.307.0)
	* This release adds support for enabling or disabling a data source configured as part of Zero-ETL integration with Amazon S3, by setting its status.
* WAFV2 (3.7.305.0)
	* You can now use Security Lake to collect web ACL traffic data.
* Core 3.7.304.4
	* Fix protocol tests
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.815.0 (2024-05-21 18:19 UTC)
* CloudFront (3.7.303.0)
	* Model update; no change to SDK functionality.
* Glue (3.7.311.0)
	* Add Maintenance window to CreateJob and UpdateJob APIs and JobRun response. Add a new Job Run State for EXPIRED.
* Lightsail (3.7.305.0)
	* This release adds support for Amazon Lightsail instances to switch between dual-stack or IPv4 only and IPv6-only public IP address types.
* MailManager (3.7.300.0)
	* This release includes a new Amazon SES feature called Mail Manager, which is a set of email gateway capabilities designed to help customers strengthen their organization's email infrastructure, simplify email workflow management, and streamline email compliance control.
* PI (3.7.301.0)
	* Performance Insights added a new input parameter called AuthorizedActions to support the fine-grained access feature. Performance Insights also restricted the acceptable input characters.
* RDS (3.7.313.1)
	* Updates Amazon RDS documentation for Db2 license through AWS Marketplace.
* StorageGateway (3.7.302.0)
	* Added new SMBSecurityStrategy enum named MandatoryEncryptionNoAes128, new mode enforces encryption and disables AES 128-bit algorithums.

### 3.7.814.0 (2024-05-20 18:27 UTC)
* BedrockAgent (3.7.309.0)
	* This release adds support for using Guardrails with Bedrock Agents.
* BedrockAgentRuntime (3.7.308.0)
	* This release adds support for using Guardrails with Bedrock Agents.
* ControlTower (3.7.305.0)
	* Added ListControlOperations API and filtering support for ListEnabledControls API. Updates also includes added metadata for enabled controls and control operations.
* DynamoDBv2 (3.7.303.9)
	* Improve documentation for IDynamoDBContext's Load and LoadAsync, highlighting that they always rely on the table's primary key and not an override index.
* OSIS (3.7.302.0)
	* Add support for creating an OpenSearch Ingestion pipeline that is attached to a provided VPC. Add information about the destinations of an OpenSearch Ingestion pipeline to the GetPipeline and ListPipelines APIs.
* RDS (3.7.313.0)
	* This release adds support for EngineLifecycleSupport on DBInstances, DBClusters, and GlobalClusters.
* SecretsManager (3.7.303.0)
	* add v2 smoke tests and smithy smokeTests trait for SDK testing

### 3.7.813.0 (2024-05-17 18:20 UTC)
* AlexaForBusiness (Removed)
	* Alexa for Business has been removed from the SDK because it has been discontinued.
* ApplicationAutoScaling (3.7.302.0)
	* add v2 smoke tests and smithy smokeTests trait for SDK testing.
* CodeBuild (3.7.308.0)
	* Aws CodeBuild now supports 36 hours build timeout
* ElasticLoadBalancingV2 (3.7.303.0)
	* This release adds dualstack-without-public-ipv4 IP address type for ALB.
* Honeycode (Removed)
	* AWS Honeycode has been removed from the SDK because it has been discontinued.
* LakeFormation (3.7.304.0)
	* Introduces a new API, GetDataLakePrincipal, that returns the identity of the invoking principal
* Transfer (3.7.307.0)
	* Enable use of CloudFormation traits in Smithy model to improve generated CloudFormation schema from the Smithy API model.
* Core 3.7.304.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.812.0 (2024-05-16 18:21 UTC)
* ACMPCA (3.7.302.0)
	* This release adds support for waiters to fail on AccessDeniedException when having insufficient permissions
* Connect (3.7.318.1)
	* Adding Contact Flow metrics to the GetMetricDataV2 API
* Kafka (3.7.303.0)
	* AWS MSK support for Broker Removal.
* MWAA (3.7.304.0)
	* Amazon MWAA now supports Airflow web server auto scaling to automatically handle increased demand from REST APIs, Command Line Interface (CLI), or more Airflow User Interface (UI) users. Customers can specify maximum and minimum web server instances during environment creation and update workflow.
* QuickSight (3.7.311.0)
	* This release adds DescribeKeyRegistration and UpdateKeyRegistration APIs to manage QuickSight Customer Managed Keys (CMK).
* SageMaker (3.7.323.0)
	* Introduced WorkerAccessConfiguration to SageMaker Workteam. This allows customers to configure resource access for workers in a workteam.
* SecretsManager (3.7.302.67)
	* Documentation updates for AWS Secrets Manager
* Core 3.7.304.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.811.0 (2024-05-15 18:18 UTC)
* BedrockAgentRuntime (3.7.307.0)
	* Updating Bedrock Knowledge Base Metadata & Filters feature with two new filters listContains and stringContains
* CodeBuild (3.7.307.0)
	* CodeBuild Reserved Capacity VPC Support
* DataSync (3.7.303.0)
	* Task executions now display a CANCELLING status when an execution is in the process of being cancelled.
* ManagedGrafana (3.7.302.0)
	* This release adds new ServiceAccount and ServiceAccountToken APIs.
* MedicalImaging (3.7.302.0)
	* Added support for importing medical imaging data from Amazon S3 buckets across accounts and regions.
* SecurityHub (3.7.305.7)
	* Documentation-only update for AWS Security Hub

### 3.7.810.0 (2024-05-14 18:15 UTC)
* Connect (3.7.318.0)
	* Amazon Connect provides enhanced search capabilities for flows & flow modules on the Connect admin website and programmatically using APIs. You can search for flows and flow modules by name, description, type, status, and tags, to filter and identify a specific flow in your Connect instances.
* S3 (3.7.308.0)
	* Updated a few x-id in the http uri traits
* Core 3.7.304.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.809.0 (2024-05-13 18:13 UTC)
* EventBridge (3.7.303.0)
	* Amazon EventBridge introduces KMS customer-managed key (CMK) encryption support for custom and partner events published on EventBridge Event Bus (including default bus) and UpdateEventBus API.
* VPCLattice (3.7.301.0)
	* This release adds TLS Passthrough support. It also increases max number of target group per rule to 10.
* Core 3.7.304.0
	* Update the `SSOTokenManager` to support the Authorization Code Flow with Proof Key for Code Exchange (PKCE) when interacting with IAM Identity Center
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.808.0 (2024-05-10 18:34 UTC)
* ApplicationDiscoveryService (3.7.301.0)
	* add v2 smoke tests and smithy smokeTests trait for SDK testing
* GreengrassV2 (3.7.301.0)
	* Mark ComponentVersion in ComponentDeploymentSpecification as required.
* SageMaker (3.7.322.0)
	* Introduced support for G6 instance types on Sagemaker Notebook Instances and on SageMaker Studio for JupyterLab and CodeEditor applications.
* SSOOIDC (3.7.302.0)
	* Updated request parameters for PKCE support.
* Core 3.7.303.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.807.0 (2024-05-09 20:41 UTC)
* BedrockAgentRuntime (3.7.306.0)
	* This release adds support to provide guardrail configuration and modify inference parameters that are then used in RetrieveAndGenerate API in Agents for Amazon Bedrock.
* Pinpoint (3.7.302.0)
	* This release adds support for specifying email message headers for Email Templates, Campaigns, Journeys and Send Messages.
* Route53Resolver (3.7.303.4)
	* Update the DNS Firewall settings to correct a spelling issue.
* SsmSap (3.7.302.0)
	* Added support for application-aware start/stop of SAP applications running on EC2 instances, with SSM for SAP
* VerifiedPermissions (3.7.306.0)
	* Adds policy effect and actions fields to Policy API's.
* Core 3.7.303.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.806.0 (2024-05-08 18:20 UTC)
* CognitoIdentityProvider (3.7.305.0)
	* Add EXTERNAL_PROVIDER enum value to UserStatusType.
* EC2 (3.7.327.0)
	* Adding Precision Hardware Clock (PHC) to public API DescribeInstanceTypes
* ECR (3.7.302.0)
	* This release adds pull through cache rules support for GitLab container registry in Amazon ECR.
* FMS (3.7.302.4)
	* The policy scope resource tag is always a string value, either a non-empty string or an empty string.
* Polly (3.7.303.0)
	* Add new engine - generative - that builds the most expressive conversational voices.
* SQS (3.7.301.0)
	* This release adds MessageSystemAttributeNames to ReceiveMessageRequest to replace AttributeNames.

### 3.7.805.0 (2024-05-07 18:24 UTC)
* B2bi (3.7.303.19)
	* Documentation update to clarify the MappingTemplate definition.
* Budgets (3.7.301.0)
	* This release adds tag support for budgets and budget actions.
* ResilienceHub (3.7.301.0)
	* AWS Resilience Hub has expanded its drift detection capabilities by introducing a new type of drift detection - application resource drift. This new enhancement detects changes, such as the addition or deletion of resources within the application's input sources.
* Route53Profiles (3.7.300.9)
	* Doc only update for Route 53 profiles that fixes some link  issues

### 3.7.804.0 (2024-05-06 18:20 UTC)
* MediaLive (3.7.308.0)
	* AWS Elemental MediaLive now supports configuring how SCTE 35 passthrough triggers segment breaks in HLS and MediaPackage output groups. Previously, messages triggered breaks in all these output groups. The new option is to trigger segment breaks only in groups that have SCTE 35 passthrough enabled.
* Core 3.7.303.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.803.0 (2024-05-03 18:24 UTC)
* BedrockAgent (3.7.308.0)
	* This release adds support for using Provisioned Throughput with Bedrock Agents.
* Connect (3.7.317.0)
	* This release adds 5 new APIs for managing attachments: StartAttachedFileUpload, CompleteAttachedFileUpload, GetAttachedFile, BatchGetAttachedFileMetadata, DeleteAttachedFile. These APIs can be used to programmatically upload and download attachments to Connect resources, like cases.
* ConnectCases (3.7.304.0)
	* This feature supports the release of Files related items
* DataSync (3.7.302.5)
	* Updated guidance on using private or self-signed certificate authorities (CAs) with AWS DataSync object storage locations.
* Inspector2 (3.7.304.0)
	* This release adds CSV format to GetCisScanReport for Inspector v2
* SageMaker (3.7.321.0)
	* Amazon SageMaker Inference now supports m6i, c6i, r6i, m7i, c7i, r7i and g5 instance types for Batch Transform Jobs
* SimpleEmailV2 (3.7.303.0)
	* Adds support for specifying replacement headers per BulkEmailEntry in SendBulkEmail in SESv2.
* Core 3.7.303.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.802.0 (2024-05-02 18:36 UTC)
* DynamoDBv2 (3.7.303.0)
	* This release adds support to specify an optional, maximum OnDemandThroughput for DynamoDB tables and global secondary indexes in the CreateTable or UpdateTable APIs. You can also override the OnDemandThroughput settings by calling the ImportTable, RestoreFromPointInTime, or RestoreFromBackup APIs.
* EC2 (3.7.326.0)
	* This release includes a new API for retrieving the public endorsement key of the EC2 instance's Nitro Trusted Platform Module (NitroTPM).
* Personalize (3.7.303.0)
	* This releases ability to delete users and their data, including their metadata and interactions data, from a dataset group.
* RedshiftServerless (3.7.303.0)
	* Update Redshift Serverless List Scheduled Actions Output Response to include Namespace Name.
* S3 (3.7.307.27)
	* Added support for RequestPayer property in TransferUtility BaseDownloadRequest class.

### 3.7.801.0 (2024-05-01 18:19 UTC)
* BedrockAgent (3.7.307.0)
	* This release adds support for using MongoDB Atlas as a vector store when creating a knowledge base.
* DynamoDBv2 (3.7.302.26)
	* PR [#3304](https://github.com/aws/aws-sdk-net/pull/3304): Properly handle a primary key that has a converter applied when DisableFetchingTableMetadata is set to true. Thanks [Oleksandr Liakhevych](https://github.com/Dreamescaper).
* EC2 (3.7.325.4)
	* Documentation updates for Amazon EC2.
* PersonalizeRuntime (3.7.302.0)
	* This release adds support for a Reason attribute for predicted items generated by User-Personalization-v2.
* SecurityHub (3.7.305.0)
	* Updated CreateMembers API request with limits.
* SimpleEmailV2 (3.7.302.0)
	* Fixes ListContacts and ListImportJobs APIs to use POST instead of GET.
* Core 3.7.303.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.800.0 (2024-04-30 18:25 UTC)
* ChimeSDKVoice (3.7.301.0)
	* Due to changes made by the Amazon Alexa service, GetSipMediaApplicationAlexaSkillConfiguration and PutSipMediaApplicationAlexaSkillConfiguration APIs are no longer available for use. For more information, refer to the Alexa Smart Properties page.
* CodeArtifact (3.7.302.0)
	* Add support for the Ruby package format.
* FMS (3.7.302.0)
	* AWS Firewall Manager now supports the network firewall service stream exception policy feature for accounts within your organization.
* Omics (3.7.302.0)
	* Add support for workflow sharing and dynamic run storage
* OpenSearchService (3.7.306.0)
	* This release enables customers to create Route53 A and AAAA alias record types to point custom endpoint domain to OpenSearch domain's dualstack search endpoint.
* PinpointSMSVoiceV2 (3.7.302.0)
	* Amazon Pinpoint has added two new features Multimedia services (MMS) and protect configurations. Use the three new MMS APIs to send media messages to a mobile phone which includes image, audio, text, or video files. Use the ten new protect configurations APIs to block messages to specific countries.
* QBusiness (3.7.303.0)
	* This is a general availability (GA) release of Amazon Q Business. Q Business enables employees in an enterprise to get comprehensive answers to complex questions and take actions through a unified, intuitive web-based chat experience - using an enterprise's existing content, data, and systems.
* QuickSight (3.7.310.0)
	* New Q embedding supporting Generative Q&A
* Route53Resolver (3.7.303.0)
	* Release of FirewallDomainRedirectionAction parameter on the Route 53 DNS Firewall Rule.  This allows customers to configure a DNS Firewall rule to inspect all the domains in the DNS redirection chain (default) , such as CNAME, ALIAS, DNAME, etc., or just the first domain and trust the rest.
* SageMaker (3.7.320.0)
	* Amazon SageMaker Training now supports the use of attribute-based access control (ABAC) roles for training job execution roles. Amazon SageMaker Inference now supports G6 instance types.
* Signer (3.7.300.85)
	* Documentation updates for AWS Signer. Adds cross-account signing constraint and definitions for cross-account actions.

### 3.7.799.0 (2024-04-29 18:21 UTC)
* Amplify (3.7.302.0)
	* Updating max results limit for listing any resources (Job, Artifacts, Branch, BackendResources, DomainAssociation) to 50 with the exception of list apps that where max results can be up to 100.
* ConnectCases (3.7.303.0)
	* This feature releases DeleteField, DeletedLayout, and DeleteTemplate API's
* Inspector2 (3.7.303.0)
	* Update Inspector2 to include new Agentless API parameters.
* TimestreamQuery (3.7.301.0)
	* This change allows users to update and describe account settings associated with their accounts.
* TranscribeService (3.7.303.0)
	* This update provides error messaging for generative call summarization in Transcribe Call Analytics
* TrustedAdvisor (3.7.301.0)
	* This release adds the BatchUpdateRecommendationResourceExclusion API to support batch updates of Recommendation Resource exclusion statuses and introduces a new exclusion status filter to the ListRecommendationResources and ListOrganizationRecommendationResources APIs.
* Core 3.7.303.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.798.0 (2024-04-26 18:21 UTC)
* AWSSupport (3.7.301.0)
	* Releasing minor endpoint updates.
* CloudWatchLogs (3.7.305.24)
	* Fixed a bug at GetLogEventsPaginator where it enters an infinite loop.
* CodePipeline (3.7.304.0)
	* Add ability to manually and automatically roll back a pipeline stage to a previously successful execution.
* CognitoIdentityProvider (3.7.304.0)
	* Add LimitExceededException to SignUp errors
* ConnectCampaignService (3.7.302.0)
	* This release adds support for specifying if Answering Machine should wait for prompt sound.
* MarketplaceEntitlementService (3.7.302.0)
	* Releasing minor endpoint updates.
* OAM (3.7.302.0)
	* This release introduces support for Source Accounts to define which Metrics and Logs to share with the Monitoring Account
* RDS (3.7.312.0)
	* SupportsLimitlessDatabase field added to describe-db-engine-versions to indicate whether the DB engine version supports Aurora Limitless Database.
* Core 3.7.303.23
	* Update `UserCrypto` not to load `Crypt32.dll` when running outside of Windows (requires applications using the SDK to target .NET 8 or later)
	* Update API documentation for the `ClientConfig.ClientAppId` property
	* Update InternalSDKUtils.DetermineFramework to return a standardized string and additional metadata if parsing version fails.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

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

