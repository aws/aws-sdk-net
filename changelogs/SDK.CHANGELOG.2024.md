### 4.0.0.0-preview.4 (2024-10-11 12:30 UTC)
* Core 4.0.0.0
	* Re-populate request property when instantiating `WebServiceRequestEventArgs`
	* Update `System.Text.Json` dependency to version `8.0.5`
	* All services packages updated to require new Core

### 4.0.0.0-preview.3 (2024-10-01 12:51 UTC)
* DynamoDBStreams (4.0.0.0)
	* Move DynamoDBStreams to its own package.
* DynamoDBv2 (4.0.0.0)
	* Removed DynamoDBStreams from DynamoDB package.
	* Allow `TableNamePrefix` to be removed on operation level
* S3 (4.0.0.0)
	* Fix #3125. Expose TaggingDirective, which controls x-amz-tagging-directive as a property on CopyObjectRequest.
* Core 4.0.0.0
	* `EC2_METADATA_SVC`, `EC2_METADATA_ROOT`, `EC2_USERDATA_ROOT`, `EC2_DYNAMICDATA_ROOT`, `EC2_APITOKEN_URL` in `EC2InstanceMetadata` are removed. The fields were marked as obsolete in v3.
	* `public static Condition NewCondition(DateComparisonType type, DateTime date)` in `Amazon.Auth/AccessControlPolicy/ConditionFactory` is removed. Please use `NewConditionUtc` instead.
	* Add code analysis rule when using collection initializers without an object initializer for collection based modeled properties.
	* Address protocol tests that are breaking changes.
	* Apply missing documentation to some classes in Amazon.Runtime
	* If a payload of a response has no data, instead of returning an empty memory stream as the payload we will return null as the payload.
	* In the `ClientConfig` class, the obsolete `DetermineDnsSuffix` has been removed. Use the service specific `client.DetermineServiceOperationEndpoint` method instead. The `ReadEntireResponse` property has been removed, use the `AWSConfigs.LoggingConfig.LogResponses` or `ClientConfig.LogResponse` instead.
	* Other non-breaking changes include: We will now not send empty lists over the wire in headers only, since the service rejects these anyways.
	* The following methods in `AWSSDKUtils` are removed `ResolveResourcePath`, `ProtectEncodedSlashUrlEncode`, `ConvertToUnixEpochMilliSeconds`
	* The following obsolete properties on `AWSConfigs` are removed: `Logging`, `ResponseLogging`, and `LogMetrics`. Use `LoggingConfig` instead.
	* The obsolete `DoesS3BucketExistAsync`(string bucketName) in ICoreAmazonS3 is removed because it always uses HTTP. Please use `Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async` instead.
	* The obsolete `ECSTaskCredentials` class is removed. Please use the `GenericContainerCredentials` provider which also supports EKS Pod Identities.
	* The obsolete `EndpointDiscoveryEnabled` class is removed. Please use the `EnvironmentVariableAWSConfiguration` instead.
	* The obsolete `EnvironmentAWSCredentials` is removed. Please use `AppConfigAWSCredentials` instead.
	* The obsolete `HasCachedAccessTokenAvailable` method on the SSOAWSCredentials class is removed.
	* The obsolete `Parameters` dictionary in `WebServiceRequestEventArgs` is obsolete. `ParameteCollection` will be used instead.
	* The obsolete `ProfileManager` class in Amazon.Util is removed. Please use the SharedCredentialsFile or the NetSDKCredentialsFile instead.
	* The obsolete `StoredProfileAWSCredentials` and `StoredProfileCredentials` is removed. Please use the `NetSDKCredentialsFile` or the `SharedCredentialsFile`.
	* The obsolete `StoredProfileFederatedCredentials` is removed. Please use `FederatedAWSCredentials` instead.
	* The obsolete `StoredProfileSAMLCredentials` class in SecurityTokenService is removed. Please use `FederatedAWSCredentials` instead.
	* The obsolete `TryGetSection` methods in `ProfileIniFile` that don't take in nested properties is removed. Please use the `TryGetSection` method in `ProfileIniFile` that accounts for nested properties.
	* The obsolete `UseSigV4` property on the `AmazonWebServiceRequest` class is removed. `SignatureVersion` will be used directly instead.
	* Unmarshalling an attribute with @xsi as part of the localName was not working, since xsi is a prefix. We will now successfully unmarshall an attribute with a prefix.
	* Update XML handling to be able to unmarshall self closing XML elements.
	* Xml Responses that returned pure whitespace in the body of an xml element will now return all the whitespace instead of an empty element.
	* All services packages updated to require new Core

### 4.0.0.0-preview.2 (2024-08-28 14:45 UTC)
* DynamoDBv2 (4.0.0.0)
	* Add the ability to mock DynamoDB operations which now implement interfaces.
* S3 (4.0.0.0)
	* Split GetACL into GetBucketAcl and GetObjectAcl
	* Split PutACL into PutObjectACL and PutBucketACL.
	* Obsolete PutACL and GetACL. These operations are being split into separate operations, because context parameters that could be used for endpoint resolution were not being copied over due to the two operations being merged into one. These context parameters were not being used currently so there is no effect as of now.
* Core 4.0.0.0
	* 4.0.0.0 Preview 2 Release
	* Add new extension packages for CloudFront Signers and EC2 Decrypt Password to take a dependency on BouncyCastle.Cryptography
	* All services packages updated to require new Core

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

### 3.7.954.0 (2024-12-28 04:26 UTC)
* ECR (3.7.406.0)
	* Restoring custom endpoint functionality for ECR
* ECRPublic (3.7.402.0)
	* Restoring custom endpoint functionality for ECR Public

### 3.7.953.1 (2024-12-27 19:16 UTC)
* RDS (3.7.410.7)
	* Updates Amazon RDS documentation to correct various descriptions.

### 3.7.953.0 (2024-12-26 19:25 UTC)
* BCMPricingCalculator (3.7.402.0)
	* Added ConflictException to DeleteBillEstimate.
* ECR (3.7.405.0)
	* Add support for Dualstack Endpoints
* NetworkFirewall (3.7.402.27)
	* Dual-stack endpoints are now supported.
* SecurityHub (3.7.402.12)
	* Documentation updates for AWS Security Hub
* Core 3.7.400.70
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.952.0 (2024-12-23 19:27 UTC)
* ECR (3.7.404.48)
	* Documentation update for ECR GetAccountSetting and PutAccountSetting APIs.
* ECRPublic (3.7.401.0)
	* Add support for Dualstack endpoints
* EKS (3.7.408.0)
	* This release adds support for DescribeClusterVersions API that provides important information about Kubernetes versions along with end of support dates
* Glue (3.7.413.0)
	* Add IncludeRoot parameters to GetCatalogs API to return root catalog.
* Core 3.7.400.69
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.951.0 (2024-12-20 19:26 UTC)
* BedrockAgent (3.7.415.0)
	* Support for custom user agent and max web pages crawled for web connector. Support app only credentials for SharePoint connector. Increase agents memory duration limit to 365 days. Support to specify max number of session summaries to include in agent invocation context.
* BedrockAgentRuntime (3.7.414.0)
	* bedrock agents now supports long term memory and performance configs. Invokeflow supports performance configs. RetrieveAndGenerate performance configs
* BedrockDataAutomation (3.7.400.9)
	* Documentation update for Amazon Bedrock Data Automation
* BedrockDataAutomationRuntime (3.7.400.9)
	* Documentation update for Amazon Bedrock Data Automation Runtime
* Billing (3.7.401.0)
	* Added new API's for defining and fetching Billing Views.
* Connect (3.7.416.0)
	* This release supports adding NotAttributeCondition and Range to the RoutingCriteria object.
* CostExplorer (3.7.404.0)
	* Support for retrieving cost, usage, and forecast for billing view.
* DocDB (3.7.402.0)
	* Support AWS Secret Manager managed password for AWS DocumentDB instance-based cluster.
* EKS (3.7.407.0)
	* This release expands the catalog of upgrade insight checks
* Macie2 (3.7.401.0)
	* This release adds support for identifying S3 general purpose buckets that exceed the Amazon Macie quota for preventative control monitoring.
* Outposts (3.7.405.0)
	* Add CS8365C as a supported power connector for Outpost sites.
* SageMaker (3.7.418.0)
	* This release adds support for c6i, m6i and r6i instance on SageMaker Hyperpod and trn1 instances in batch
* Core 3.7.400.68
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.950.0 (2024-12-19 19:17 UTC)
* AppStream (3.7.404.0)
	* Added support for Rocky Linux 8 on Amazon AppStream 2.0
* MediaConvert (3.7.405.0)
	* This release adds support for inserting timecode tracks into MP4 container outputs.
* MediaLive (3.7.408.0)
	* MediaLive is releasing ListVersions api
* QConnect (3.7.404.0)
	* Amazon Q in Connect enables agents to ask Q for assistance in multiple languages and Q will provide answers and recommended step-by-step guides in those languages. Qs default language is English (United States) and you can switch this by setting the locale configuration on the AI Agent.
* S3 (3.7.410.9)
	* fix: Added logic to marshall NoncurrentVersionExpiration.NewerNoncurrentVersions in PutLifecycleConfigurationRequestMarshaller.
* SsmSap (3.7.402.0)
	* AWS Systems Manager for SAP added support for registration and discovery of distributed ABAP applications
* WorkSpaces (3.7.407.0)
	* Added AWS Global Accelerator (AGA) support for WorkSpaces Personal.
* Core 3.7.400.67
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.949.0 (2024-12-18 19:23 UTC)
* Amplify (3.7.403.0)
	* Added WAF Configuration to Amplify Apps
* Budgets (3.7.402.0)
	* Releasing minor partition endpoint updates
* Connect (3.7.415.0)
	* This release adds support for the UpdateParticipantAuthentication API used for customer authentication within Amazon Connect chats.
* ConnectParticipant (3.7.401.0)
	* This release adds support for the GetAuthenticationUrl and CancelParticipantAuthentication APIs used for customer authentication within Amazon Connect chats. There are also minor updates to the GetAttachment API.
* DataSync (3.7.402.0)
	* AWS DataSync introduces the ability to update attributes for in-cloud locations.
* IoT (3.7.405.0)
	* Release connectivity status query API which is a dedicated high throughput(TPS) API to query a specific device's most recent connectivity state and metadata.
* MWAA (3.7.402.12)
	* Added support for Apache Airflow version 2.10.3 to MWAA.
* QuickSight (3.7.412.0)
	* Add support for PerformanceConfiguration attribute to Dataset entity. Allow PerformanceConfiguration specification in CreateDataset and UpdateDataset APIs.
* ResilienceHub (3.7.404.0)
	* AWS Resilience Hub now automatically detects already configured CloudWatch alarms and FIS experiments as part of the assessment process and returns the discovered resources in the corresponding list API responses. It also allows you to include or exclude test recommendations for an AppComponent.
* Transfer (3.7.403.0)
	* Added AS2 agreement configurations to control filename preservation and message signing enforcement. Added AS2 connector configuration to preserve content type from S3 objects.
* Core 3.7.400.66
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.948.0 (2024-12-17 19:24 UTC)
* Account (3.7.401.0)
	* Update endpoint configuration.
* Backup (3.7.402.0)
	* Add Support for Backup Indexing
* BackupSearch (3.7.400.0)
	* Add support for searching backups
* Batch (3.7.404.0)
	* This feature allows AWS Batch on Amazon EKS to support configuration of Pod Annotations, overriding Namespace on which the Batch job's Pod runs on, and allows Subpath and Persistent Volume claim to be set for AWS Batch on Amazon EKS jobs.
* CleanRoomsML (3.7.402.0)
	* Add support for SQL compute configuration for StartAudienceGenerationJob API.
* CloudFront (3.7.404.0)
	* Adds support for OriginReadTimeout and OriginKeepaliveTimeout to create CloudFront Distributions with VPC Origins.
* CodePipeline (3.7.406.0)
	* AWS CodePipeline V2 type pipelines now support Managed Compute Rule.
* ECS (3.7.408.0)
	* Added support for enableFaultInjection task definition parameter which can be used to enable Fault Injection feature on ECS tasks.
* MainframeModernization (3.7.402.0)
	* This release adds support for AWS Mainframe Modernization(M2) Service to allow specifying network type(ipv4, dual) for the environment instances. For dual network type, m2 environment applications will serve both IPv4 and IPv6 requests, whereas for ipv4 it will serve only IPv4 requests.
* Synthetics (3.7.403.0)
	* Add support to toggle outbound IPv6 traffic on canaries connected to dualstack subnets.  This behavior can be controlled via the new Ipv6AllowedForDualStack parameter of the VpcConfig input object in CreateCanary and UpdateCanary APIs.
* Core 3.7.400.65
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.947.0 (2024-12-16 19:24 UTC)
* Cloud9 (3.7.400.65)
	* Added information about Ubuntu 18.04 will be removed from the available imageIds for Cloud9 because Ubuntu 18.04 has ended standard support on May 31, 2023.
* DLM (3.7.401.0)
	* This release adds support for Local Zones in Amazon Data Lifecycle Manager EBS snapshot lifecycle policies.
* EC2 (3.7.425.0)
	* This release adds support for EBS local snapshots in AWS Dedicated Local Zones, which allows you to store snapshots of EBS volumes locally in Dedicated Local Zones.
* GreengrassV2 (3.7.401.0)
	* Add support for runtime in GetCoreDevice and ListCoreDevices APIs.
* MediaLive (3.7.407.0)
	* AWS Elemental MediaLive adds three new features: MediaPackage v2 endpoint support for live stream delivery, KLV metadata passthrough in CMAF Ingest output groups, and Metadata Name Modifier in CMAF Ingest output groups for customizing metadata track names in output streams.
* RDS (3.7.410.0)
	* This release adds support for the "MYSQL_CACHING_SHA2_PASSWORD" enum value for RDS Proxy ClientPasswordAuthType.

### 3.7.946.0 (2024-12-13 19:34 UTC)
* CloudHSMV2 (3.7.401.0)
	* Add support for Dual-Stack hsm2m.medium clusters. The customers will now be able to create hsm2m.medium clusters having both IPv4 and IPv6 connection capabilities by specifying a new param called NetworkType=DUALSTACK during cluster creation.
* CloudWatchLogs (3.7.409.0)
	* Limit PutIntegration IntegrationName and ListIntegrations IntegrationNamePrefix parameters to 50 characters
* EC2 (3.7.424.0)
	* This release adds GroupId to the response for DeleteSecurityGroup.
* EKS (3.7.406.0)
	* Add NodeRepairConfig in CreateNodegroupRequest and UpdateNodegroupConfigRequest
* MediaConnect (3.7.402.0)
	* AWS Elemental MediaConnect Gateway now supports Source Specific Multicast (SSM) for ingress bridges. This enables you to specify a source IP address in addition to a multicast IP when creating or updating an ingress bridge source.
* NetworkManager (3.7.401.7)
	* There was a sentence fragment in UpdateDirectConnectGatewayAttachment that was causing customer confusion as to whether it's an incomplete sentence or if it was a typo. Removed the fragment.
* ServiceDiscovery (3.7.401.0)
	* AWS Cloud Map now supports service-level attributes, allowing you to associate custom metadata directly with services. These attributes can be retrieved, updated, and deleted using the new GetServiceAttributes, UpdateServiceAttributes, and DeleteServiceAttributes API calls.
* Core 3.7.400.64
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.945.0 (2024-12-12 19:39 UTC)
* Connect (3.7.414.0)
	* Configure holidays and other overrides to hours of operation in advance. During contact handling, Amazon Connect automatically checks for overrides and provides customers with an appropriate flow path. After an override period passes call center automatically reverts to standard hours of operation.
* DatabaseMigrationService (3.7.403.0)
	* Add parameters to support for kerberos authentication. Add parameter for disabling the Unicode source filter with PostgreSQL settings. Add parameter to use large integer value with Kinesis/Kafka settings.
* Glue (3.7.412.0)
	* To support customer-managed encryption in Data Quality to allow customers encrypt data with their own KMS key, we will add a DataQualityEncryption field to the SecurityConfiguration API where customers can provide their KMS keys.
* GuardDuty (3.7.405.5)
	* Improved descriptions for certain APIs.
* Route53Domains (3.7.401.0)
	* This release includes the following API updates: added the enumeration type RESTORE_DOMAIN to the OperationType; constrained the Price attribute to non-negative values; updated the LangCode to allow 2 or 3 alphabetical characters.
* Core 3.7.400.63
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.944.0 (2024-12-11 20:00 UTC)
* Artifact (3.7.401.0)
	* Add support for listing active customer agreements for the calling AWS Account.
* CloudTrail (3.7.402.6)
	* Doc-only updates for CloudTrail.
* CognitoIdentityProvider (3.7.405.2)
	* Updated descriptions for some API operations and parameters, corrected some errors in Cognito user pools
* ControlCatalog (3.7.402.15)
	* Minor documentation updates to the content of ImplementationDetails object part of the Control Catalog GetControl API
* EMRServerless (3.7.402.0)
	* This release adds support for accessing system profile logs in Lake Formation-enabled jobs.
* MigrationHub (3.7.401.0)
	* API and documentation updates for AWS MigrationHub related to adding support for listing migration task updates and associating, disassociating and listing source resources
* SimpleEmailV2 (3.7.406.0)
	* Introduces support for multi-region endpoint.
* TimestreamInfluxDB (3.7.404.0)
	* Adds networkType parameter to CreateDbInstance API which allows IPv6 support to the InfluxDB endpoint
* Core 3.7.400.62
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.943.0 (2024-12-10 19:59 UTC)
* ApplicationAutoScaling (3.7.402.5)
	* Doc only update for AAS Predictive Scaling policy configuration API.
* BCMPricingCalculator (3.7.401.0)
	* Updated condition key inference from Workload Estimate, Bill Scenario, and Bill Estimate resources. Updated documentation links.
* Connect (3.7.413.0)
	* Add support for Push Notifications for Amazon Connect chat. With Push Notifications enabled an alert could be sent to customers about new messages even when they aren't actively using the mobile application.
* DSQL (3.7.401.1)
	* Doc only update to examples for DeleteMultiRegionClusters & CreateMultiRegionClusters
* Finspace (3.7.401.0)
	* Update KxCommandLineArgument value parameter regex to allow for spaces and semicolons
* IVSRealTime (3.7.403.0)
	* IVS Real-Time now offers customers the ability to customize thumbnails recording mode and interval for both Individual Participant Recording (IPR) and Server-Side Compositions (SSC).
* SimpleEmailV2 (3.7.405.0)
	* Introduces support for creating DEED (Deterministic Easy-DKIM) identities.
* Core 3.7.400.61
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.942.0 (2024-12-09 19:45 UTC)
* AppSync (3.7.403.4)
	* Provides description of new Amazon Bedrock runtime datasource.
* CognitoIdentityProvider (3.7.405.0)
	* Change `CustomDomainConfig` from a required to an optional parameter for the `UpdateUserPoolDomain` operation.
* DSQL (3.7.401.0)
	* Add Amazon.DSQL.Util.DSQLAuthTokenGenerator for generating auth tokens for connecting to DSQL clusters.
* EC2 (3.7.423.0)
	* This release includes a new API for modifying instance network-performance-options after launch.
* ECS (3.7.407.6)
	* This is a documentation only update to address various tickets for Amazon ECS.
* Keyspaces (3.7.402.6)
	* Amazon Keyspaces: adding the list of IAM actions required by the UpdateKeyspace API.
* MediaLive (3.7.406.0)
	* H265 outputs now support disabling the deblocking filter.
* RDS (3.7.409.2)
	* Update documentation for Amazon.RDS.Util.RDSAuthTokenGenerator.
* WorkSpaces (3.7.406.5)
	* Added text to clarify case-sensitivity
* Core 3.7.400.60
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.941.0 (2024-12-05 01:28 UTC)
* PartnerCentralSelling (3.7.402.0)
	* Introducing the preview of new partner central selling APIs designed to transform how AWS partners collaborate and co-sell with multiple partners. This enables multiple partners to seamlessly engage and jointly pursue customer opportunities, fostering a new era of collaborative selling.
* QBusiness (3.7.407.0)
	* This release removes the deprecated UserId and UserGroups fields from SearchRelevantContent api's request parameters.

### 3.7.940.0 (2024-12-04 19:25 UTC)
* Bedrock (3.7.412.0)
	* Introduced two APIs ListPromptRouters and GetPromptRouter for Intelligent Prompt Router feature. Add support for Bedrock Guardrails image content filter. New Bedrock Marketplace feature enabling a wider range of bedrock compatible models with self-hosted capability.
* BedrockAgent (3.7.414.0)
	* This release introduces the ability to generate SQL using natural language, through a new GenerateQuery API (with native integration into Knowledge Bases); ability to ingest and retrieve images through Bedrock Data Automation; and ability to create a Knowledge Base backed by Kendra GenAI Index.
* BedrockAgentRuntime (3.7.413.0)
	* This release introduces the ability to generate SQL using natural language, through a new GenerateQuery API (with native integration into Knowledge Bases); ability to ingest and retrieve images through Bedrock Data Automation; and ability to create a Knowledge Base backed by Kendra GenAI Index.
* BedrockDataAutomation (3.7.400.0)
	* Release Bedrock Data Automation SDK
* BedrockDataAutomationRuntime (3.7.400.0)
	* Release Bedrock Data Automation Runtime SDK
* BedrockRuntime (3.7.411.0)
	* Added support for Intelligent Prompt Router in Invoke, InvokeStream, Converse and ConverseStream. Add support for Bedrock Guardrails image content filter. New Bedrock Marketplace feature enabling a wider range of bedrock compatible models with self-hosted capability.
* Kendra (3.7.401.0)
	* This release adds GenAI Index in Amazon Kendra for Retrieval Augmented Generation (RAG) and intelligent search. With the Kendra GenAI Index, customers get high retrieval accuracy powered by the latest information retrieval technologies and semantic models.
* SageMaker (3.7.417.0)
	* Amazon SageMaker HyperPod launched task governance to help customers maximize accelerator utilization for model development and flexible training plans to meet training timelines and budget while reducing weeks of training time. AI apps from AWS partner is now available in SageMaker.

### 3.7.939.1 (2024-12-03 22:28 UTC)
* S3 (3.7.410.1)
	* Breaking Change: Fixed the namespace for ErrorDetails.

### 3.7.939.0 (2024-12-03 19:33 UTC)
* Athena (3.7.403.0)
	* Add FEDERATED type to CreateDataCatalog. This creates Athena Data Catalog, AWS Lambda connector, and AWS Glue connection. Create/DeleteDataCatalog returns DataCatalog. Add Status, ConnectionType, and Error to DataCatalog and DataCatalogSummary. Add DeleteCatalogOnly to delete Athena Catalog only.
* Bedrock (3.7.411.0)
	* Tagging support for Async Invoke resources. Added support for Distillation in CreateModelCustomizationJob API. Support for videoDataDeliveryEnabled flag in invocation logging.
* BedrockAgent (3.7.413.0)
	* Releasing SDK for Multi-Agent Collaboration.
* BedrockAgentRuntime (3.7.412.0)
	* Releasing SDK for multi agent collaboration
* BedrockRuntime (3.7.410.0)
	* Added support for Async Invoke Operations Start, List and Get. Support for invocation logs with `requestMetadata` field in Converse, ConverseStream, Invoke and InvokeStream. Video content blocks in Converse/ConverseStream accept raw bytes or S3 URI.
* CloudWatch (3.7.402.7)
	* Support for configuring AiOps investigation as alarm action
* DataZone (3.7.408.0)
	* Adds support for Connections, ProjectProfiles, and JobRuns APIs. Supports the new Lineage feature at GA. Adjusts optionality of a parameter for DataSource and SubscriptionTarget APIs which may adjust types in some clients.
* DSQL (3.7.400.0)
	* Add new API operations for Amazon Aurora DSQL. Amazon Aurora DSQL is a serverless, distributed SQL database with virtually unlimited scale, highest availability, and zero infrastructure management.
* DynamoDBv2 (3.7.404.0)
	* This change adds support for global tables with multi-Region strong consistency (in preview). The UpdateTable API now supports a new attribute MultiRegionConsistency to set consistency when creating global tables. The DescribeTable output now optionally includes the MultiRegionConsistency attribute.
* Glue (3.7.411.0)
	* This release includes(1)Zero-ETL integration to ingest data from 3P SaaS and DynamoDB to Redshift/Redlake (2)new properties on Connections to enable reuse; new connection APIs for retrieve/preview metadata (3)support of CRUD operations for Multi-catalog (4)support of automatic statistics collections
* LakeFormation (3.7.402.0)
	* This release added two new LakeFormation Permissions (CREATE_CATALOG, SUPER_USER) and added Id field for CatalogResource. It also added new conditon and expression field.
* QApps (3.7.404.0)
	* Add support for 11 new plugins as action cards to help automate repetitive tasks and improve productivity.
* QBusiness (3.7.406.0)
	* Amazon Q Business now supports customization options for your web experience, 11 new Plugins, and QuickSight support. Amazon Q index allows software providers to enrich their native generative AI experiences with their customer's enterprise knowledge and user context spanning multiple applications.
* QuickSight (3.7.411.0)
	* This release includes API needed to support for Unstructured Data in Q in QuickSight Q&A (IDC).
* Redshift (3.7.405.0)
	* Adds support for Amazon Redshift RegisterNamespace and DeregisterNamespace APIs to share data to AWS Glue Data Catalog.
* RedshiftServerless (3.7.402.0)
	* Adds support for the ListManagedWorkgroups API to get an overview of existing managed workgroups.
* S3 (3.7.410.0)
	* Amazon S3 Metadata stores object metadata in read-only, fully managed Apache Iceberg metadata tables that you can query. You can create metadata table configurations for S3 general purpose buckets.
* S3Tables (3.7.400.0)
	* Amazon S3 Tables deliver the first cloud object store with built-in open table format support, and the easiest way to store tabular data at scale.

### 3.7.938.0 (2024-12-03 05:43 UTC)
* BedrockRuntime (3.7.409.0)
	* Add an API parameter that allows customers to set performance configuration for invoking a model.
* S3Control (3.7.404.0)
	* It allows customers to pass CRC64NVME as a header in S3 Batch Operations copy requests
* SocialMessaging (3.7.401.0)
	* Added support for passing role arn corresponding to the supported event destination
* Core 3.7.400.59
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.937.0 (2024-12-02 04:28 UTC)
* Bedrock (3.7.410.0)
	* Add support for Knowledge Base Evaluations & LLM as a judge
* BedrockAgent (3.7.412.0)
	* This release introduces APIs to upload documents directly into a Knowledge Base
* BedrockAgentRuntime (3.7.411.0)
	* This release introduces a new Rerank API to leverage reranking models (with integration into Knowledge Bases); APIs to upload documents directly into Knowledge Base; RetrieveAndGenerateStream API for streaming response; Guardrails on Retrieve API; and ability to automatically generate filters
* ChimeSDKVoice (3.7.401.0)
	* This release adds supports for enterprises to integrate Amazon Connect with other voice systems. It supports directly transferring voice calls and metadata without using the public telephone network. It also supports real-time and post-call analytics.
* CleanRooms (3.7.403.0)
	* This release allows customers and their partners to easily collaborate with data stored in Snowflake and Amazon Athena, without having to move or share their underlying data among collaborators.
* CloudWatchLogs (3.7.408.0)
	* Adds PutIntegration, GetIntegration, ListIntegrations and DeleteIntegration APIs. Adds QueryLanguage support to StartQuery, GetQueryResults, DescribeQueries, DescribeQueryDefinitions, and PutQueryDefinition APIs.
* Connect (3.7.412.0)
	* Adds support for WhatsApp Business messaging, IVR call recording, enabling Contact Lens for existing on-premise contact centers and telephony platforms, and enabling telephony and IVR migration to Amazon Connect independent of their contact center agents.
* ConnectCampaignsV2 (3.7.401.0)
	* Amazon Connect Outbound Campaigns V2 / Features : Adds support for Event-Triggered Campaigns.
* CustomerProfiles (3.7.403.0)
	* This release introduces Event Trigger APIs as part of Amazon Connect Customer Profiles service.
* EC2 (3.7.422.0)
	* Adds support for declarative policies that allow you to enforce desired configuration across an AWS organization through configuring account attributes. Adds support for Allowed AMIs that allows you to limit the use of AMIs in AWS accounts. Adds support for connectivity over non-HTTP protocols.
* ECS (3.7.407.4)
	* This release adds support for Container Insights with Enhanced Observability for Amazon ECS.
* EKS (3.7.405.0)
	* Added support for Auto Mode Clusters, Hybrid Nodes, and specifying computeTypes in the DescribeAddonVersions API.
* EventBridge (3.7.402.0)
	* Call private APIs by configuring Connections with VPC connectivity through PrivateLink and VPC Lattice
* FSx (3.7.402.0)
	* FSx API changes to support the public launch of the Amazon FSx Intelligent Tiering for OpenZFS storage class.
* GuardDuty (3.7.405.0)
	* Add new Multi Domain Correlation findings.
* Imagebuilder (3.7.402.0)
	* Added support for EC2 Image Builder's integration with AWS Marketplace for Marketplace components.
* Invoicing (3.7.400.0)
	* AWS Invoice Configuration allows you to receive separate AWS invoices based on your organizational needs. You can use the AWS SDKs to manage Invoice Units and programmatically fetch the information of the invoice receiver.
* MemoryDB (3.7.402.0)
	* Amazon MemoryDB SDK now supports all APIs for Multi-Region. Please refer to the updated Amazon MemoryDB public documentation for detailed information on API usage.
* NetworkFlowMonitor (3.7.400.0)
	* This release adds documentation for a new feature in Amazon CloudWatch called Network Flow Monitor. You can use Network Flow Monitor to get near real-time metrics, including retransmissions and data transferred, for your actual workloads.
* OpenSearchService (3.7.404.0)
	* This feature introduces support for CRUDL APIs, enabling the creation and management of Connected data sources.
* Organizations (3.7.404.0)
	* Add support for policy operations on the DECLARATIVE_POLICY_EC2 policy type.
* QBusiness (3.7.405.0)
	* Amazon Q Business now supports capabilities to extract insights and answer questions from visual elements embedded within documents, a browser extension for Google Chrome, Mozilla Firefox, and Microsoft Edge, and attachments across conversations.
* QConnect (3.7.403.0)
	* This release adds following capabilities: Configuring safeguards via AIGuardrails for Q in Connect inferencing, and APIs to support Q&A self-service use cases
* RDS (3.7.409.0)
	* Amazon RDS supports CloudWatch Database Insights. You can use the SDK to create, modify, and describe the DatabaseInsightsMode for your DB instances and clusters.
* S3 (3.7.409.0)
	* Amazon S3 introduces support for AWS Dedicated Local Zones
* S3Control (3.7.403.0)
	* Amazon S3 introduces support for AWS Dedicated Local Zones
* SecurityHub (3.7.402.0)
	* Add new Multi Domain Correlation findings.
* SecurityIR (3.7.400.0)
	* AWS Security Incident Response is a purpose-built security incident solution designed to help customers prepare for, respond to, and recover from security incidents.
* Transfer (3.7.402.0)
	* AWS Transfer Family now offers Web apps that enables simple and secure access to data stored in Amazon S3.
* VPCLattice (3.7.401.0)
	* Lattice APIs that allow sharing and access of VPC resources across accounts.

### 3.7.936.0 (2024-11-27 19:24 UTC)
* BedrockAgent (3.7.411.0)
	* Add support for specifying embeddingDataType, either FLOAT32 or BINARY
* ConfigService (3.7.402.0)
	* AWS Config adds support for service-linked recorders, a new type of Config recorder managed by AWS services to record specific subsets of resource configuration data and functioning independently from customer managed AWS Config recorders.
* FSx (3.7.401.0)
	* This release adds EFA support to increase FSx for Lustre file systems' throughput performance to a single client instance. This can be done by specifying EfaEnabled=true at the time of creation of Persistent_2 file systems.
* ObservabilityAdmin (3.7.400.0)
	* Amazon CloudWatch Observability Admin adds the ability to audit telemetry configuration for AWS resources in customers AWS Accounts and Organizations. The release introduces new APIs to turn on/off the new experience, which supports discovering supported AWS resources and their state of telemetry.
* Core 3.7.400.58
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.935.0 (2024-11-26 19:20 UTC)
* BedrockAgent (3.7.410.0)
	* Custom Orchestration API release for AWSBedrockAgents.
* BedrockAgentRuntime (3.7.410.0)
	* Custom Orchestration and Streaming configurations API release for AWSBedrockAgents.
* Connect (3.7.411.0)
	* Enables access to ValueMap and ValueInteger types for SegmentAttributes and fixes deserialization bug for DescribeContactFlow in AmazonConnect Public API
* EC2 (3.7.421.0)
	* Adds support for Time-based Copy for EBS Snapshots and Cross Region PrivateLink. Time-based Copy ensures that EBS Snapshots are copied within and across AWS Regions in a specified timeframe. Cross Region PrivateLink enables customers to connect to VPC endpoint services hosted in other AWS Regions.
* QApps (3.7.403.0)
	* Private sharing, file upload and data collection feature support for Q Apps

### 3.7.934.0 (2024-11-25 19:30 UTC)
* DirectConnect (3.7.401.0)
	* Update DescribeDirectConnectGatewayAssociations API to return associated core network information if a Direct Connect gateway is attached to a Cloud WAN core network.
* NetworkManager (3.7.401.0)
	* This release adds native Direct Connect integration on Cloud WAN enabling customers to directly attach their Direct Connect gateways to Cloud WAN without the need for an intermediate Transit Gateway.
* S3 (3.7.408.0)
	* Amazon Simple Storage Service / Features: Add support for ETag based conditional writes in PutObject and CompleteMultiPartUpload APIs to prevent unintended object modifications.

### 3.7.933.0 (2024-11-22 19:40 UTC)
* AutoScaling (3.7.407.0)
	* Now, Amazon EC2 Auto Scaling customers can enable target tracking policies to take quicker scaling decisions, enhancing their application performance and EC2 utilization. To get started, specify target tracking to monitor a metric that is available on Amazon CloudWatch at seconds-level interval.
* BCMPricingCalculator (3.7.400.0)
	* Initial release of the AWS Billing and Cost Management Pricing Calculator API.
* BedrockAgentRuntime (3.7.409.0)
	* InvokeInlineAgent API release to help invoke runtime agents without any dependency on preconfigured agents.
* Chatbot (3.7.403.0)
	* Adds support for programmatic management of custom actions and aliases which can be associated with channel configurations.
* CodePipeline (3.7.405.0)
	* AWS CodePipeline V2 type pipelines now support ECRBuildAndPublish and InspectorScan actions.
* CognitoIdentityProvider (3.7.404.0)
	* Add support for users to sign up and sign in without passwords, using email and SMS OTPs and Passkeys. Add support for Passkeys based on WebAuthn. Add support for enhanced branding customization for hosted authentication pages with Amazon Cognito Managed Login. Add feature tiers with new pricing.
* Connect (3.7.410.0)
	* Amazon Connect Service Feature: Add APIs for Amazon Connect Email Channel
* CostExplorer (3.7.403.0)
	* This release adds the Impact field(contains Contribution field) to the GetAnomalies API response under RootCause
* ElasticLoadBalancingV2 (3.7.408.0)
	* This release adds support for advertising trusted CA certificate names in associated trust stores.
* ElasticMapReduce (3.7.403.0)
	* Advanced Scaling in Amazon EMR Managed Scaling
* Inspector2 (3.7.404.0)
	* Extend inspector2 service model to include ServiceQuotaExceededException.
* Lambda (3.7.411.0)
	* Add ProvisionedPollerConfig to Lambda event-source-mapping API.
* MailManager (3.7.403.0)
	* Added new "DeliverToQBusiness" rule action to MailManager RulesSet for ingesting email data into Amazon Q Business customer applications
* NeptuneGraph (3.7.403.0)
	* Add 4 new APIs to support new Export features, allowing Parquet and CSV formats. Add new arguments in Import APIs to support Parquet import. Add a new query "neptune.read" to run algorithms without loading data into database
* Omics (3.7.403.0)
	* This release adds support for resource policy based cross account S3 access to sequence store read sets.
* QuickSight (3.7.410.0)
	* This release includes: Update APIs to support Image, Layer Map, font customization, and Plugin Visual. Add Identity center related information in ListNamsespace API. Update API for restrictedFolder support in topics and add API for SearchTopics, Describe/Update DashboardsQA Configration.
* SageMaker (3.7.416.0)
	* This release adds APIs for new features for SageMaker endpoint to scale down to zero instances, native support for multi-adapter inference, and endpoint scaling improvements.
* SimpleEmail (3.7.402.0)
	* This release adds support for starting email contacts in your Amazon Connect instance as an email receiving action.
* SimpleNotificationService (3.7.400.57)
	* ArchivePolicy attribute added to Archive and Replay feature
* StepFunctions (3.7.403.0)
	* Add support for variables and JSONata in TestState, GetExecutionHistory, DescribeStateMachine, and DescribeStateMachineForExecution
* WorkSpaces (3.7.406.2)
	* While integrating WSP-DCV rebrand, a few mentions were erroneously renamed from WSP to DCV. This release reverts those mentions back to WSP.
* Core 3.7.400.57
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.932.0 (2024-11-21 19:48 UTC)
* APIGateway (3.7.401.0)
	* Added support for custom domain names for private APIs.
* ApplicationAutoScaling (3.7.402.0)
	* Application Auto Scaling now supports Predictive Scaling to proactively increase the desired capacity ahead of predicted demand, ensuring improved availability and responsiveness for customers' applications. This feature is currently only made available for Amazon ECS Service scalable targets.
* AppSync (3.7.403.0)
	* Add support for the Amazon Bedrock Runtime.
* AWSHealth (3.7.401.0)
	* Adds metadata property to an AffectedEntity.
* CloudFront (3.7.403.0)
	* Adds support for Origin Selection between EMPv2 origins based on media quality score.
* CloudTrail (3.7.402.0)
	* This release introduces new APIs for creating and managing CloudTrail Lake dashboards. It also adds support for resource-based policies on CloudTrail EventDataStore and Dashboard resource.
* CloudWatchLogs (3.7.407.0)
	* Adds "Create field indexes to improve query performance and reduce scan volume" and "Transform logs during ingestion". Updates documentation for "PutLogEvents with Entity".
* CostExplorer (3.7.402.0)
	* This release introduces three new APIs that enable you to estimate the cost, coverage, and utilization impact of Savings Plans you plan to purchase. The three APIs are StartCommitmentPurchaseAnalysis, GetCommitmentPurchaseAnalysis, and ListCommitmentPurchaseAnalyses.
* EC2 (3.7.420.0)
	* Adds support for requesting future-dated Capacity Reservations with a minimum commitment duration, enabling IPAM for organizational units within AWS Organizations, reserving EC2 Capacity Blocks that start in 30 minutes, and extending the end date of existing Capacity Blocks.
* ElastiCache (3.7.402.0)
	* Added support to modify the engine type for existing ElastiCache Users and User Groups. Customers can now modify the engine type from redis to valkey.
* ElasticLoadBalancingV2 (3.7.407.1)
	* This feature adds support for enabling zonal shift on cross-zone enabled Application Load Balancer, as well as modifying HTTP request and response headers.
* IoT (3.7.404.0)
	* General Availability (GA) release of AWS IoT Device Management - Commands, to trigger light-weight remote actions on targeted devices
* IoTFleetWise (3.7.403.0)
	* AWS IoT FleetWise now includes campaign parameters to store and forward data, configure MQTT topic as a data destination, and collect diagnostic trouble code data. It includes APIs for network agnostic data collection using custom decoding interfaces, and monitoring the last known state of vehicles.
* IoTJobsDataPlane (3.7.401.0)
	* General Availability (GA) release of AWS IoT Device Management - Commands, to trigger light-weight remote actions on targeted devices
* Lambda (3.7.410.0)
	* Adds support for metrics for event source mappings for AWS Lambda
* Notifications (3.7.400.0)
	* This release adds support for AWS User Notifications. You can now configure and view notifications from AWS services in a central location using the AWS SDK.
* NotificationsContacts (3.7.400.0)
	* This release adds support for AWS User Notifications Contacts. You can now configure and view email contacts for AWS User Notifications using the AWS SDK.
* ResilienceHub (3.7.403.0)
	* AWS Resilience Hub's new summary view visually represents applications' resilience through charts, enabling efficient resilience management. It provides a consolidated view of the app portfolio's resilience state and allows data export for custom stakeholder reporting.
* S3 (3.7.407.0)
	* Add support for conditional deletes for the S3 DeleteObject and DeleteObjects APIs. Add support for write offset bytes option used to append to objects with the S3 PutObject API.
* SimpleSystemsManagement (3.7.403.0)
	* Added support for providing high-level overviews of managed nodes and previewing the potential impact of a runbook execution.
* SSMQuickSetup (3.7.401.0)
	* Add methods that retrieve details about deployed configurations: ListConfigurations, GetConfiguration
* XRay (3.7.401.0)
	* AWS X-Ray introduces Transaction Search APIs, enabling span ingestion into CloudWatch Logs for high-scale trace data indexing. These APIs support span-level queries, trace graph generation, and metric correlation for deeper application insights.
* Core 3.7.400.56
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.931.0 (2024-11-20 23:26 UTC)
* ApplicationDiscoveryService (3.7.401.0)
	* Add support to import data from commercially available discovery tools without file manipulation.
* AutoScaling (3.7.406.0)
	* With this release, customers can prioritize launching instances into ODCRs using targets from ASGs or Launch Templates. Customers can express their baseline instances' CPU-performance in attribute-based Instance Requirements configuration by referencing an instance family that meets their needs.
* BedrockAgentRuntime (3.7.408.0)
	* Releasing new Prompt Optimization to enhance your prompts for improved performance
* CloudFront (3.7.402.0)
	* Add support for gRPC, VPC origins, and Anycast IP Lists. Allow LoggingConfig IncludeCookies to be set regardless of whether the LoggingConfig is enabled.
* ComputeOptimizer (3.7.401.0)
	* This release enables AWS Compute Optimizer to analyze and generate optimization recommendations for Amazon Aurora database instances. It also enables Compute Optimizer to identify idle Amazon EC2 instances, Amazon EBS volumes, Amazon ECS services running on Fargate, and Amazon RDS databases.
* ControlTower (3.7.402.0)
	* Adds support for child enabled baselines which allow you to see the enabled baseline status for individual accounts.
* CostOptimizationHub (3.7.402.0)
	* This release adds action type "Delete" to the GetRecommendation, ListRecommendations and ListRecommendationSummaries APIs to support new EBS and ECS recommendations with action type "Delete".
* DataZone (3.7.407.0)
	* This release supports Metadata Enforcement Rule feature for Create Subscription Request action.
* EC2 (3.7.419.0)
	* With this release, customers can express their desire to launch instances only in an ODCR or ODCR group rather than OnDemand capacity. Customers can express their baseline instances' CPU-performance in attribute-based Instance Requirements configuration by referencing an instance family.
* ECS (3.7.407.0)
	* This release adds support for the Availability Zone rebalancing feature on Amazon ECS.
* ElasticLoadBalancingV2 (3.7.407.0)
	* This release adds support for configuring Load balancer Capacity Unit reservations
* Lambda (3.7.409.0)
	* Add Node 22.x (node22.x) support to AWS Lambda
* MediaConvert (3.7.404.0)
	* This release adds the ability to reconfigure concurrent job settings for existing queues and create queues with custom concurrent job settings.
* MediaPackageV2 (3.7.403.0)
	* MediaPackage v2 now supports the Media Quality Confidence Score (MQCS) published from MediaLive. Customers can control input switching based on the MQCS and publishing HTTP Headers for the MQCS via the API.
* Omics (3.7.402.0)
	* Enabling call caching feature that allows customers to reuse previously computed results from a set of completed tasks in a new workflow run.
* RDS (3.7.408.0)
	* This release adds support for scale storage on the DB instance using a Blue/Green Deployment.
* RecycleBin (3.7.401.0)
	* This release adds support for exclusion tags for Recycle Bin, which allows you to identify resources that are to be excluded, or ignored, by a Region-level retention rule.
* TimestreamQuery (3.7.402.0)
	* This release adds support for Provisioning Timestream Compute Units (TCUs), a new feature that allows provisioning dedicated compute resources for your queries, providing predictable and cost-effective query performance.
* WorkSpaces (3.7.406.0)
	* Added support for Rocky Linux 8 on Amazon WorkSpaces Personal.
* WorkSpacesWeb (3.7.402.0)
	* Added data protection settings with support for inline data redaction.
* Core 3.7.400.55
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.930.0 (2024-11-19 20:46 UTC)
* B2bi (3.7.403.0)
	* Add new X12 transactions sets and versions
* EC2 (3.7.418.0)
	* This release adds VPC Block Public Access (VPC BPA), a new declarative control which blocks resources in VPCs and subnets that you own in a Region from reaching or being reached from the internet through internet gateways and egress-only internet gateways.
* ECS (3.7.406.0)
	* This release introduces support for configuring the version consistency feature for individual containers defined within a task definition. The configuration allows to specify whether ECS should resolve the container image tag specified in the container definition to an image digest.
* ElasticFileSystem (3.7.401.0)
	* Add support for the new parameters in EFS replication APIs
* Glue (3.7.410.0)
	* AWS Glue Data Catalog now enhances managed table optimizations of Apache Iceberg tables that can be accessed only from a specific Amazon Virtual Private Cloud (VPC) environment.
* Keyspaces (3.7.402.0)
	* Amazon Keyspaces Multi-Region Replication: Adds support to add new regions to multi and single-region keyspaces.
* MWAA (3.7.402.0)
	* Amazon MWAA now supports a new environment class, mw1.micro, ideal for workloads requiring fewer resources than mw1.small. This class supports a single instance of each Airflow component: Scheduler, Worker, and Webserver.
* TaxSettings (3.7.402.0)
	* Release Tax Inheritance APIs,  Tax Exemption APIs, and functionality update for some existing Tax Registration APIs
* WorkSpaces (3.7.405.0)
	* Releasing new ErrorCodes for Image Validation failure during CreateWorkspaceImage process
* Core 3.7.400.54
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.929.0 (2024-11-18 19:31 UTC)
* AppConfig (3.7.403.0)
	* AWS AppConfig has added a new extension action point, AT_DEPLOYMENT_TICK, to support third-party monitors to trigger an automatic rollback during a deployment.
* AutoScaling (3.7.405.0)
	* Amazon EC2 Auto Scaling now supports Amazon Application Recovery Controller (ARC) zonal shift and zonal autoshift to help you quickly recover an impaired application from failures in an Availability Zone (AZ).
* CloudFormation (3.7.401.0)
	* This release adds a new API, ListHookResults, that allows retrieving CloudFormation Hooks invocation results for hooks invoked during a create change set operation or Cloud Control API operation
* Connect (3.7.409.0)
	* Adds CreateContactFlowVersion and ListContactFlowVersions APIs to create and view the versions of a contact flow.
* CustomerProfiles (3.7.402.0)
	* This release introduces Segmentation APIs and new Calculated Attribute Event Filters as part of Amazon Connect Customer Profiles service.
* EC2 (3.7.417.0)
	* Adding request and response elements for managed resources.
* ECS (3.7.405.0)
	* This release adds support for adding VPC Lattice configurations in ECS CreateService/UpdateService APIs. The configuration allows for associating VPC Lattice target groups with ECS Services.
* IoTSiteWise (3.7.402.0)
	* The release introduces a generative AI Assistant in AWS IoT SiteWise. It includes: 1) InvokeAssistant API - Invoke the Assistant to get alarm summaries and ask questions. 2) Dataset APIs - Manage knowledge base configuration for the Assistant. 3) Portal APIs enhancement - Manage AI-aware dashboards.
* QConnect (3.7.402.0)
	* This release introduces MessageTemplate as a resource in Amazon Q in Connect, along with APIs to create, read, search, update, and delete MessageTemplate resources.
* RDS (3.7.407.0)
	* Add support for the automatic pause/resume feature of Aurora Serverless v2.
* RDSDataService (3.7.401.0)
	* Add support for the automatic pause/resume feature of Aurora Serverless v2.

### 3.7.928.0 (2024-11-15 19:23 UTC)
* CloudWatch (3.7.402.0)
	* Adds support for adding related Entity information to metrics ingested through PutMetricData.
* ConnectCampaignsV2 (3.7.400.0)
	* Added Amazon Connect Outbound Campaigns V2 SDK.
* DataSync (3.7.401.10)
	* Doc-only updates and enhancements related to creating DataSync tasks and describing task executions.
* EC2 (3.7.416.0)
	* Remove non-functional enum variants for FleetCapacityReservationUsageStrategy
* ElasticTranscoder (3.7.400.53)
	* Remove integration tests for Amazon Elastic Transcoder as the service has been discontinued: https://aws.amazon.com/blogs/media/how-to-migrate-workflows-from-amazon-elastic-transcoder-to-aws-elemental-mediaconvert
* IoT (3.7.403.0)
	* This release allows AWS IoT Core users to enrich MQTT messages with propagating attributes, to associate a thing to a connection, and to enable Online Certificate Status Protocol (OCSP) stapling for TLS X.509 server certificates through private endpoints.
* Outposts (3.7.404.0)
	* You can now purchase AWS Outposts rack or server capacity for a 5-year term with one of  the following payment options: All Upfront, Partial Upfront, and No Upfront.
* PinpointSMSVoiceV2 (3.7.404.0)
	* Use rule overrides to always allow or always block messages to specific phone numbers. Use message feedback to monitor if a customer interacts with your message.
* Polly (3.7.401.42)
	* Fixes PutLexicon usage example.
* Route53Resolver (3.7.402.0)
	* Route 53 Resolver DNS Firewall Advanced Rules allows you to monitor and block suspicious DNS traffic based on anomalies detected in the queries, such as DNS tunneling and Domain Generation Algorithms (DGAs).
* Core 3.7.400.53
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.927.0 (2024-11-15 02:02 UTC)
* PartnerCentralSelling (3.7.401.0)
	* Announcing AWS Partner Central API for Selling: This service launch Introduces new APIs for co-selling opportunity management and related functions. Key features include notifications, a dynamic sandbox for testing, and streamlined validations.
* Core 3.7.400.52
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.926.0 (2024-11-14 19:27 UTC)
* AccessAnalyzer (3.7.402.0)
	* Expand analyzer configuration capabilities for unused access analyzers. Unused access analyzer configurations now support the ability to exclude accounts and resource tags from analysis providing more granular control over the scope of analysis.
* CloudControlApi (3.7.401.0)
	* Added support for CloudFormation Hooks with Cloud Control API. The GetResourceRequestStatus API response now includes an optional HooksProgressEvent and HooksRequestToken parameter for Hooks Invocation Progress as part of resource operation with Cloud Control.
* Deadline (3.7.403.0)
	* Adds support for select GPU accelerated instance types when creating new service-managed fleets.
* IdentityManagement (3.7.403.0)
	* This release includes support for five new APIs and changes to existing APIs that give AWS Organizations customers the ability to use temporary root credentials, targeted to member accounts in the organization.
* IoTWireless (3.7.401.0)
	* New FuotaTask resource type to enable logging for your FUOTA tasks. A ParticipatingGatewaysforMulticast parameter to choose the list of gateways to receive the multicast downlink message and the transmission interval between them. Descriptor field which will be sent to devices during FUOTA transfer.
* IVS (3.7.402.0)
	* IVS now offers customers the ability to stream multitrack video to Channels.
* LicenseManagerUserSubscriptions (3.7.401.0)
	* New and updated API operations to support License Included User-based Subscription of Microsoft Remote Desktop Services (RDS).
* PartnerCentralSelling (3.7.400.0)
	* Announcing AWS Partner Central API for Selling: This service launch Introduces new APIs for co-selling opportunity management and related functions. Key features include notifications, a dynamic sandbox for testing, and streamlined validations.
* QuickSight (3.7.409.0)
	* This release adds APIs for Custom Permissions management in QuickSight, and APIs to support QuickSight Branding.
* Redshift (3.7.404.0)
	* Adds support for Amazon Redshift S3AccessGrants
* S3 (3.7.406.0)
	* This release updates the ListBuckets API Reference documentation in support of the new 10,000 general purpose bucket default quota on all AWS accounts. To increase your bucket quota from 10,000 to up to 1 million buckets, simply request a quota increase via Service Quotas.
* SageMaker (3.7.415.0)
	* Add support for Neuron instance types [ trn1/trn1n/inf2 ] on SageMaker Notebook Instances Platform.
* SecurityToken (3.7.401.0)
	* This release introduces the new API 'AssumeRoot', which returns short-term credentials that you can use to perform privileged tasks.
* Core 3.7.400.51
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.925.0 (2024-11-13 19:24 UTC)
* AccessAnalyzer (3.7.401.0)
	* This release adds support for policy validation and external access findings for resource control policies (RCP). IAM Access Analyzer helps you author functional and secure RCPs and awareness that a RCP may restrict external access. Updated service API, documentation, and paginators.
* ApplicationSignals (3.7.403.0)
	* Amazon CloudWatch Application Signals now supports creating Service Level Objectives with burn rates. Users can now create or update SLOs with burn rate configurations to meet their specific business requirements.
* B2bi (3.7.402.0)
	* This release adds a GenerateMapping API to allow generation of JSONata or XSLT transformer code based on input and output samples.
* Billing (3.7.400.0)
	* Today, AWS announces the general availability of ListBillingViews API in the AWS SDKs, to enable AWS Billing Conductor (ABC) users to create proforma Cost and Usage Reports (CUR) programmatically.
* CloudTrail (3.7.401.0)
	* This release adds a new API GenerateQuery that generates a query from a natural language prompt about the event data in your event data store. This operation uses generative artificial intelligence (generative AI) to produce a ready-to-use SQL query from the prompt.
* DynamoDBv2 (3.7.403.0)
	* This release includes supports the new WarmThroughput feature for DynamoDB. You can now provide an optional WarmThroughput attribute for CreateTable or UpdateTable APIs to pre-warm your table or global secondary index. You can also use DescribeTable to see the latest WarmThroughput value.
	* Pull Request [#3547](https://github.com/aws/aws-sdk-net/pull/3547): Correct XML docs for DataModel attributes
* EC2 (3.7.415.0)
	* This release adds the source AMI details in DescribeImages API
* InternetMonitor (3.7.402.0)
	* Add new query type Routing_Suggestions regarding querying interface
* MediaConvert (3.7.403.0)
	* This release adds support for ARN inputs in the Kantar credentials secrets name field and the MSPR field to the manifests for PlayReady DRM protected outputs.
* Organizations (3.7.403.0)
	* Add support for policy operations on the Resource Control Polices.
* Core 3.7.400.50
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.924.0 (2024-11-12 19:42 UTC)
* CodeBuild (3.7.407.0)
	* AWS CodeBuild now supports non-containerized Linux and Windows builds on Reserved Capacity.
* ControlTower (3.7.401.0)
	* Added ResetEnabledControl API.
* FIS (3.7.403.0)
	* This release adds support for generating experiment reports with the experiment report configuration
* GameLift (3.7.402.0)
	* Amazon GameLift releases container fleets support for general availability. Deploy Linux-based containerized game server software for hosting on Amazon GameLift.
* PaymentCryptography (3.7.402.0)
	* Updated ListAliases API with KeyArn filter.
* RDS (3.7.406.8)
	* Updates Amazon RDS documentation for Amazon RDS Extended Support for Amazon Aurora MySQL.
* Core 3.7.400.49
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.923.0 (2024-11-11 19:17 UTC)
* CloudFront (3.7.401.0)
	* No API changes from previous release. This release migrated the model to Smithy keeping all features unchanged.
* Inspector2 (3.7.403.0)
	* Adds support for filePath filter.
* Lambda (3.7.408.0)
	* Add Python 3.13 (python3.13) support to AWS Lambda
* OpenSearchService (3.7.403.0)
	* Adds Support for new AssociatePackages and DissociatePackages API in Amazon OpenSearch Service that allows association and dissociation operations to be carried out on multiple packages at the same time.
* Outposts (3.7.403.0)
	* This release updates StartCapacityTask to allow an active Outpost to be modified. It also adds a new API to list all running EC2 instances on the Outpost.
* Core 3.7.400.48
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.922.0 (2024-11-08 19:30 UTC)
* Batch (3.7.403.0)
	* This feature allows override LaunchTemplates to be specified in an AWS Batch Compute Environment.
* BedrockAgentRuntime (3.7.407.0)
	* This release adds trace functionality to Bedrock Prompt Flows
* ChimeSDKMediaPipelines (3.7.401.0)
	* Added support for Media Capture Pipeline and Media Concatenation Pipeline for customer managed server side encryption. Now Media Capture Pipeline can use IAM sink role to get access to KMS key and encrypt/decrypt recorded artifacts. KMS key ID can also be supplied with encryption context.
* ControlCatalog (3.7.402.0)
	* AWS Control Catalog GetControl public API returns additional data in output, including Implementation and Parameters
* EKS (3.7.404.0)
	* Adds new error code `Ec2InstanceTypeDoesNotExist` for Amazon EKS managed node groups
* KinesisFirehose (3.7.401.0)
	* Amazon Data Firehose / Features : Adds support for a new DeliveryStreamType, DatabaseAsSource. DatabaseAsSource hoses allow customers to stream CDC events from their RDS and Amazon EC2 hosted databases, running MySQL and PostgreSQL database engines, to Iceberg Table destinations.
* Lambda (3.7.407.0)
	* This release adds support for using AWS KMS customer managed keys to encrypt AWS Lambda .zip deployment packages.
* PinpointSMSVoiceV2 (3.7.403.0)
	* Added the RequiresAuthenticationTimestamp field to the RegistrationVersionStatusHistory data type.
* QBusiness (3.7.404.0)
	* Adds S3 path option to pass group member list for PutGroup API.
* Core 3.7.400.47
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.921.0 (2024-11-07 19:40 UTC)
* AutoScaling (3.7.404.0)
	* Auto Scaling groups now support the ability to strictly balance instances across Availability Zones by configuring the AvailabilityZoneDistribution parameter. If balanced-only is configured for a group, launches will always be attempted in the under scaled Availability Zone even if it is unhealthy.
* BedrockAgent (3.7.409.0)
	* Add prompt support for chat template configuration and agent generative AI resource. Add support for configuring an optional guardrail in Prompt and Knowledge Base nodes in Prompt Flows. Add API to validate flow definition
* BedrockRuntime (3.7.408.0)
	* Add Prompt management support to Bedrock runtime APIs: Converse, ConverseStream, InvokeModel, InvokeModelWithStreamingResponse
* CleanRooms (3.7.402.0)
	* This release introduces support for Custom Models in AWS Clean Rooms ML.
* CleanRoomsML (3.7.401.0)
	* This release introduces support for Custom Models in AWS Clean Rooms ML.
* QuickSight (3.7.408.0)
	* Add Client Credentials based OAuth support for Snowflake and Starburst
* ResourceExplorer2 (3.7.402.0)
	* Add GetManagedView, ListManagedViews APIs.
* Synthetics (3.7.402.0)
	* Add support to toggle if a canary will automatically delete provisioned canary resources such as Lambda functions and layers when a canary is deleted.  This behavior can be controlled via the new ProvisionedResourceCleanup property exposed in the CreateCanary and UpdateCanary APIs.
* Core 3.7.400.46
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.920.0 (2024-11-06 19:19 UTC)
* CodeBuild (3.7.406.0)
	* AWS CodeBuild now adds additional compute types for reserved capacity fleet.
* GuardDuty (3.7.404.0)
	* GuardDuty RDS Protection expands support for Amazon Aurora PostgreSQL Limitless Databases.
* LakeFormation (3.7.401.0)
	* API changes for new named tag expressions feature.
* QApps (3.7.402.0)
	* Introduces category apis in AmazonQApps. Web experience users use Categories to tag and filter library items.
* S3Control (3.7.402.0)
	* Fix ListStorageLensConfigurations and ListStorageLensGroups deserialization for Smithy SDKs.
* VerifiedPermissions (3.7.401.0)
	* Adding BatchGetPolicy API which supports the retrieval of multiple policies across multiple policy stores within a single request.

### 3.7.919.0 (2024-11-01 18:22 UTC)
* BedrockAgent (3.7.408.0)
	* Amazon Bedrock Knowledge Bases now supports using application inference profiles to increase throughput and improve resilience.
* CloudWatchLogs (3.7.406.0)
	* This release introduces an improvement in PutLogEvents
* DocDBElastic (3.7.401.0)
	* Amazon DocumentDB Elastic Clusters adds support for pending maintenance actions feature with APIs GetPendingMaintenanceAction, ListPendingMaintenanceActions and ApplyPendingMaintenanceAction
* TaxSettings (3.7.401.0)
	* Add support for supplemental tax registrations via these new APIs: PutSupplementalTaxRegistration, ListSupplementalTaxRegistrations, and DeleteSupplementalTaxRegistration.
* Core 3.7.400.45
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.918.0 (2024-10-31 20:17 UTC)
* AutoScaling (3.7.403.0)
	* Adds bake time for Auto Scaling group Instance Refresh
* Batch (3.7.402.0)
	* Add `podNamespace` to `EksAttemptDetail` and `containerID` to `EksAttemptContainerDetail`.
* ElasticLoadBalancingV2 (3.7.406.0)
	* Add UDP support for AWS PrivateLink and dual-stack Network Load Balancers
* Glue (3.7.409.0)
	* Add schedule support for AWS Glue column statistics
* PrometheusService (3.7.401.0)
	* Added support for UpdateScraper API, to enable updating collector configuration in-place
* SageMaker (3.7.414.0)
	* SageMaker HyperPod adds scale-down at instance level via BatchDeleteClusterNodes API and group level via UpdateCluster API. SageMaker Training exposes secondary job status in TrainingJobSummary from ListTrainingJobs API. SageMaker now supports G6, G6e, P5e instances for HyperPod and Training.
* SimpleEmailV2 (3.7.404.0)
	* This release enables customers to provide the email template content in the SESv2 SendEmail and SendBulkEmail APIs instead of the name or the ARN of a stored email template.
* Core 3.7.400.44
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.917.0 (2024-10-30 18:39 UTC)
* AppSync (3.7.402.0)
	* This release adds support for AppSync Event APIs.
* Connect (3.7.408.0)
	* Updated the public documentation for the UserIdentityInfo object to accurately reflect the character limits for the FirstName and LastName fields, which were previously listed as 1-100 characters.
* DataSync (3.7.401.0)
	* AWS DataSync now supports Enhanced mode tasks. This task mode supports transfer of virtually unlimited numbers of objects with enhanced metrics, more detailed logs, and higher performance than Basic mode. This mode currently supports transfers between Amazon S3 locations.
* EC2 (3.7.414.0)
	* This release adds two new capabilities to VPC Security Groups: Security Group VPC Associations and Shared Security Groups.
* ECS (3.7.404.0)
	* This release supports service deployments and service revisions which provide a comprehensive view of your Amazon ECS service history.
* GeoMaps (3.7.400.0)
	* Release of Amazon Location Maps API. Maps enables you to build digital maps that showcase your locations, visualize your data, and unlock insights to drive your business
* GeoPlaces (3.7.400.0)
	* Release of Amazon Location Places API. Places enables you to quickly search, display, and filter places, businesses, and locations based on proximity, category, and name
* GeoRoutes (3.7.400.0)
	* Release of Amazon Location Routes API. Routes enables you to plan efficient routes and streamline deliveries by leveraging real-time traffic, vehicle restrictions, and turn-by-turn directions.
* Keyspaces (3.7.401.0)
	* Adds support for interacting with user-defined types (UDTs) through the following new operations: Create-Type, Delete-Type, List-Types, Get-Type.
* NetworkFirewall (3.7.402.0)
	* AWS Network Firewall now supports configuring TCP idle timeout
* OpenSearchServerless (3.7.402.0)
	* Neo Integration via IAM Identity Center (IdC)
* OpenSearchService (3.7.402.0)
	* This release introduces the new OpenSearch user interface (Dashboards), a new web-based application that can be associated with multiple data sources across OpenSearch managed clusters, serverless collections, and Amazon S3, so that users can gain a comprehensive insights in an unified interface.
* Redshift (3.7.403.0)
	* This release launches S3 event integrations to create and manage integrations from an Amazon S3 source into an Amazon Redshift database.
* RedshiftServerless (3.7.401.0)
	* Adds and updates API members for the Redshift Serverless AI-driven scaling and optimization feature using the price-performance target setting.
* Route53 (3.7.403.0)
	* This release adds support for TLSA, SSHFP, SVCB, and HTTPS record types.
* S3 (3.7.405.7)
	* Fixes issue [#3201](https://github.com/aws/aws-sdk-net/issues/3201). Provides workaround for uploading nonseekable streams where the length may be set to 0. In Net7+ some nonseekable streams will have their length set to 0 rather than throwing a NotSupportedException or having their length correctly populated. This provides a workaround for those scenarios.
* SageMaker (3.7.413.0)
	* Added support for Model Registry Staging construct. Users can define series of stages that models can progress through for model workflows and lifecycle. This simplifies tracking and managing models as they transition through development, testing, and production stages.
* WorkMail (3.7.401.0)
	* This release adds support for Multi-Factor Authentication (MFA) and Personal Access Tokens through integration with AWS IAM Identity Center.
* Core 3.7.400.43
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.916.0 (2024-10-29 18:28 UTC)
* Bedrock (3.7.409.0)
	* Update Application Inference Profile
* BedrockRuntime (3.7.407.0)
	* Update Application Inference Profile
* CleanRooms (3.7.401.0)
	* This release adds the option for customers to configure analytics engine when creating a collaboration, and introduces the new SPARK analytics engine type in addition to maintaining the legacy CLEAN_ROOMS_SQL engine type.
* CloudWatchLogs (3.7.405.0)
	* Added support for new optional baseline parameter in the UpdateAnomaly API. For UpdateAnomaly requests with baseline set to True, The anomaly behavior is then treated as baseline behavior. However, more severe occurrences of this behavior will still be reported as anomalies.
* IoTFleetWise (3.7.402.0)
	* Updated BatchCreateVehicle and BatchUpdateVehicle APIs: LimitExceededException has been added and the maximum number of vehicles in a batch has been set to 10 explicitly
* RedshiftDataAPIService (3.7.402.0)
	* Adding a new API GetStatementResultV2 that supports CSV formatted results from ExecuteStatement and BatchExecuteStatement calls.
* SageMaker (3.7.412.0)
	* Adding `notebook-al2-v3` as allowed value to SageMaker NotebookInstance PlatformIdentifier attribute
* Core 3.7.400.42
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.915.0 (2024-10-28 18:18 UTC)
* MediaPackageV2 (3.7.402.0)
	* MediaPackage V2 Live to VOD Harvester is a MediaPackage V2 feature, which is used to export content from an origin endpoint to a S3 bucket.
* OpenSearchService (3.7.401.0)
	* Adds support for provisioning dedicated coordinator nodes. Coordinator nodes can be specified using the new NodeOptions parameter in ClusterConfig.
* RDS (3.7.406.0)
	* This release adds support for Enhanced Monitoring and Performance Insights when restoring Aurora Limitless Database DB clusters. It also adds support for the os-upgrade pending maintenance action.
* StorageGateway (3.7.401.22)
	* Documentation update: Amazon FSx File Gateway will no longer be available to new customers.
* Core 3.7.400.41
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.914.0 (2024-10-25 18:21 UTC)
* BedrockAgent (3.7.407.0)
	* Add support of new model types for Bedrock Agents, Adding inference profile support for Flows and Prompt Management, Adding new field to configure additional inference configurations for Flows and Prompt Management
* CloudWatchLogs (3.7.404.0)
	* Adding inferred token name for dynamic tokens in Anomalies.
* CodeBuild (3.7.405.0)
	* AWS CodeBuild now supports automatically retrying failed builds
* Lambda (3.7.406.0)
	* Add TagsError field in Lambda GetFunctionResponse. The TagsError field contains details related to errors retrieving tags.
* SupplyChain (3.7.403.0)
	* API doc updates, and also support showing error message on a failed instance
* Core 3.7.400.40
	* Updated EventBridge and SESV2 to use AWSEndpointAuthSchemeSigner to select either SigV4 or SigV4a signing based on endpoint rules.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.913.0 (2024-10-24 18:20 UTC)
* AppConfig (3.7.402.0)
	* This release improves deployment safety by granting customers the ability to REVERT completed deployments, to the last known good state.In the StopDeployment API revert case the status of a COMPLETE deployment will be REVERTED. AppConfig only allows a revert within 72 hours of deployment completion.
* EC2 (3.7.413.0)
	* This release includes a new API to describe some details of the Amazon Machine Images (AMIs) that were used to launch EC2 instances, even if those AMIs are no longer available for use.
* ECS (3.7.403.0)
	* This release adds support for EBS volumes attached to Amazon ECS Windows tasks running on EC2 instances.
* NimbleStudio (Removed)
	* Nimble Studio has been removed from the SDK because it has been discontinued.
* PCS (3.7.400.27)
	* Documentation update: added the default value of the Slurm configuration parameter scaleDownIdleTimeInSeconds to its description.
* QBusiness (3.7.403.0)
	* Add a new field in chat response. This field can be used to support nested schemas in array fields
* Core 3.7.400.39
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.912.0 (2024-10-23 18:20 UTC)
* Bedrock (3.7.408.2)
	* Doc updates for supporting converse
* Connect (3.7.407.0)
	* Amazon Connect Service Feature: Add support to start screen sharing for a web calling contact.
* EC2 (3.7.412.0)
	* Amazon EC2 X8g, C8g and M8g instances are powered by AWS Graviton4 processors. X8g provide the lowest cost per GiB of memory among Graviton4 instances. C8g provide the best price performance for compute-intensive workloads. M8g provide the best price performance in for general purpose workloads.
* MWAA (3.7.401.0)
	* Introducing InvokeRestApi which allows users to invoke the Apache Airflow REST API on the webserver with the specified inputs.
* PaymentCryptography (3.7.401.0)
	* Add support for ECC P-256 and P-384 Keys.
* PaymentCryptographyData (3.7.402.0)
	* Add ECDH support on PIN operations.
* Core 3.7.400.38
	* Updates the documentation for ConnectionLimit.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.911.0 (2024-10-22 18:46 UTC)
* BedrockRuntime (3.7.406.0)
	* Updating invoke regex to support imported models for converse API
* Imagebuilder (3.7.401.0)
	* Add macOS platform and instance placement options
* MainframeModernization (3.7.401.0)
	* Add AuthSecretsManagerArn optional parameter to batch job APIs, expand batch parameter limits, and introduce clientToken constraints.
* RDS (3.7.405.0)
	* Global clusters now expose the Endpoint attribute as one of its fields. It is a Read/Write endpoint for the global cluster which resolves to the Global Cluster writer instance.
* Repostspace (3.7.401.0)
	* Adds the BatchAddRole and BatchRemoveRole APIs.
* TimestreamQuery (3.7.401.0)
	* This release adds support for Query Insights, a feature that provides details of query execution, enabling users to identify areas for improvement to optimize their queries, resulting in improved query performance and lower query costs.
* Core 3.7.400.37
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.910.0 (2024-10-21 18:24 UTC)
* ApplicationInsights (3.7.401.0)
	* This feature enables customers to specify SNS Topic ARN. CloudWatch Application Insights (CWAI) will utilize this ARN to send problem notifications.
* AutoScaling (3.7.402.0)
	* Adds support for removing the PlacementGroup setting on an Auto Scaling Group through the UpdateAutoScalingGroup API.
* BedrockAgentRuntime (3.7.406.0)
	* Knowledge Bases for Amazon Bedrock now supports custom prompts and model parameters in the orchestrationConfiguration of the RetrieveAndGenerate API. The modelArn field accepts Custom Models and Imported Models ARNs.
* DatabaseMigrationService (3.7.402.0)
	* Added support for tagging in StartReplicationTaskAssessmentRun API and introduced IsLatestTaskAssessmentRun and ResultStatistic fields for enhanced tracking and assessment result statistics.
* EC2 (3.7.411.0)
	* Amazon EC2 now allows you to create network interfaces with just the EFA driver and no ENA driver by specifying the network interface type as efa-only.
* EKS (3.7.403.0)
	* This release adds support for Amazon Application Recovery Controller (ARC) zonal shift and zonal autoshift with EKS that enhances the resiliency of multi-AZ cluster environments
* FMS (3.7.401.0)
	* Update AWS WAF policy - add the option to retrofit existing web ACLs instead of creating all new web ACLs.
* PaymentCryptographyData (3.7.401.0)
	* Adding new API to generate authenticated scripts for EMV pin change use cases.
* WAFV2 (3.7.402.0)
	* Add a property to WebACL to indicate whether it's been retrofitted by Firewall Manager.

### 3.7.909.0 (2024-10-18 18:20 UTC)
* Athena (3.7.402.0)
	* Remove DataCatalog from Create/DeleteDataCatalog. Remove Status, ConnectionType, and Error from DataCatalog and DataCatalogSummary. These were released inadvertently with no functionality. They were not populated or populated with a default value. Code related to these changes can be safely removed.
* Bedrock (3.7.408.0)
	* Adding converse support to CMI API's
* BedrockRuntime (3.7.405.0)
	* Added converse support for custom imported models
* DataZone (3.7.406.0)
	* Adding the following project member designations: PROJECT_CATALOG_VIEWER, PROJECT_CATALOG_CONSUMER and PROJECT_CATALOG_STEWARD in the CreateProjectMembership API and PROJECT_CATALOG_STEWARD designation in the AddPolicyGrant API.
* EC2 (3.7.410.0)
	* RequestSpotInstances and RequestSpotFleet feature release.

### 3.7.908.0 (2024-10-17 18:27 UTC)
* BedrockAgent (3.7.406.0)
	* Removing support for topK property in PromptModelInferenceConfiguration object, Making PromptTemplateConfiguration property as required, Limiting the maximum PromptVariant to 1
* DataExchange (3.7.401.0)
	* This release adds Data Grant support, through which customers can programmatically create data grants to share with other AWS accounts and accept data grants from other AWS accounts.
* DynamoDBv2 (3.7.402.0)
	* Added support for creating observability traces from the DataModel and DocumentModel abstractions for DynamoDB
* ECS (3.7.402.33)
	* This is an Amazon ECS documentation only update to address tickets.
* PinpointSMSVoiceV2 (3.7.402.0)
	* Added the registrations status of REQUIRES_AUTHENTICATION
* Pipes (3.7.402.0)
	* This release adds validation to require specifying a SecurityGroup and Subnets in the Vpc object under PipesSourceSelfManagedKafkaParameters. It also adds support for iso-e, iso-f, and other non-commercial partitions in ARN parameters.
* QuickSight (3.7.407.0)
	* Add StartDashboardSnapshotJobSchedule API. RestoreAnalysis now supports restoring analysis to folders.
* RDS (3.7.404.10)
	* Updates Amazon RDS documentation for TAZ IAM support
* WorkSpaces (3.7.404.0)
	* Updated the DomainName pattern for Active Directory

### 3.7.907.0 (2024-10-16 18:14 UTC)
* S3 (3.7.405.0)
	* Add support for the new optional bucket-region and prefix query parameters in the ListBuckets API. For ListBuckets requests that express pagination, Amazon S3 will now return both the bucket names and associated AWS regions in the response.
	* Updated the documentation for TransferUtilityDownloadDirectoryRequest.LocalDirectory mentioning that it is case-sensitive.
* Core 3.7.400.36
	* Updates to support building and running netstandard project core only based UnitTests from service solutions.
	* All services packages updated to require new Core

### 3.7.906.0 (2024-10-15 18:19 UTC)
* Amplify (3.7.402.0)
	* Added sourceUrlType field to StartDeployment request
* CloudFormation (3.7.400.35)
	* Documentation update for AWS CloudFormation API Reference.
* CodeBuild (3.7.404.0)
	* Enable proxy for reserved capacity fleet.
* IVS (3.7.401.0)
	* On a channel that you own, you can now replace an ongoing stream with a new stream by streaming up with the priority parameter appended to the stream key.
* QBusiness (3.7.402.0)
	* Amazon Q Business now supports embedding the Amazon Q Business web experience on third-party websites.
* Redshift (3.7.402.0)
	* This release launches the CreateIntegration, DeleteIntegration, DescribeIntegrations and ModifyIntegration APIs to create and manage Amazon Redshift Zero-ETL Integrations.
* ResilienceHub (3.7.402.0)
	* AWS Resilience Hub now integrates with the myApplications platform, enabling customers to easily assess the resilience of applications defined in myApplications. The new Resiliency widget provides visibility into application resilience and actionable recommendations for improvement.
* S3 (3.7.404.7)
	* fix: Add missing NewerNoncurrentVersions to PutLifecycleConfigurationRequestMarshall
* SimpleEmailV2 (3.7.403.0)
	* This release adds support for email maximum delivery seconds that allows senders to control the time within which their emails are attempted for delivery.
* Core 3.7.400.35
	* Fix #3497, make InternalSDKUtils aot compatible.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.905.0 (2024-10-14 18:20 UTC)
* CodePipeline (3.7.404.0)
	* AWS CodePipeline V2 type pipelines now support automatically retrying failed stages and skipping stage for failed entry conditions.
* MailManager (3.7.402.0)
	* Mail Manager support for viewing and exporting metadata of archived messages.
* SecurityLake (3.7.401.0)
	* This release updates request validation regex for resource ARNs.
* SupplyChain (3.7.402.0)
	* This release adds AWS Supply Chain instance management functionality. Specifically adding CreateInstance, DeleteInstance, GetInstance, ListInstances, and UpdateInstance APIs.
* Transfer (3.7.401.0)
	* This release enables customers using SFTP connectors to query the transfer status of their files to meet their monitoring needs as well as orchestrate post transfer actions.
* Core 3.7.400.34
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.904.0 (2024-10-11 18:35 UTC)
* Appflow (3.7.400.34)
	* Doc only updates for clarification around OAuth2GrantType for Salesforce.
* ElasticLoadBalancingV2 (3.7.405.0)
	* Add zonal_shift.config.enabled attribute. Add new AdministrativeOverride construct in the describe-target-health API response to include information about the override status applied to a target.
* ElasticMapReduce (3.7.402.0)
	* This release provides new parameter "Context" in instance fleet clusters.
* GuardDuty (3.7.403.0)
	* Added a new field for network connection details.
* RoboMaker (3.7.400.34)
	* Documentation update: added support notices to each API action.

### 3.7.903.0 (2024-10-10 18:26 UTC)
* ACMPCA (3.7.400.34)
	* Documentation updates for AWS Private CA.
* DatabaseMigrationService (3.7.401.0)
	* Introduces DescribeDataMigrations, CreateDataMigration, ModifyDataMigration, DeleteDataMigration, StartDataMigration, StopDataMigration operations to SDK. Provides FailedDependencyFault error message.
* EC2 (3.7.409.0)
	* This release adds support for assigning the billing of shared Amazon EC2 On-Demand Capacity Reservations.
* ECS (3.7.402.29)
	* This is a documentation only release that updates to documentation to let customers know that Amazon Elastic Inference is no longer available.
* ElasticInference (3.7.400.34)
	* Elastic Inference - Documentation update to add service shutdown notice.
* IoTFleetWise (3.7.401.0)
	* Refine campaign related API validations
* NeptuneGraph (3.7.402.0)
	* Support for 16 m-NCU graphs available through account allowlisting
* Outposts (3.7.402.0)
	* Adding new "DELIVERED" enum value for Outposts Order status
* Route53Resolver (3.7.401.0)
	* Route 53 Resolver Forwarding Rules can now include a server name indication (SNI) in the target address for rules that use the DNS-over-HTTPS (DoH) protocol. When a DoH-enabled Outbound Resolver Endpoint forwards a request to a DoH server, it will provide the SNI in the TLS handshake.
* SocialMessaging (3.7.400.0)
	* This release for AWS End User Messaging includes a public SDK, providing a suite of APIs that enable sending WhatsApp messages to end users.
* TimestreamInfluxDB (3.7.403.0)
	* This release updates our regex based validation rules in regards to valid DbInstance and DbParameterGroup name.

### 3.7.902.0 (2024-10-09 18:19 UTC)
* CodePipeline (3.7.403.0)
	* AWS CodePipeline introduces a Compute category
* Core 3.7.400.33
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.901.0 (2024-10-08 18:16 UTC)
* ElastiCache (3.7.401.0)
	* AWS ElastiCache SDK now supports using APIs with newly launched Valkey engine. Please refer to updated AWS ElastiCache public documentation for detailed information on API usage.
* MemoryDB (3.7.401.0)
	* Amazon MemoryDB SDK now supports all APIs for newly launched Valkey engine. Please refer to the updated Amazon MemoryDB public documentation for detailed information on API usage.
* S3 (3.7.404.4)
	* Create traces using the SDK observability APIs for the S3 Transfer Utility
* Core 3.7.400.32
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.900.0 (2024-10-07 18:21 UTC)
* Deadline (3.7.402.0)
	* Add support for using the template from a previous job during job creation and listing parameter definitions for a job.
* MarketplaceReporting (3.7.400.2)
	* Documentation-only update for AWS Marketplace Reporting API.
* QConnect (3.7.401.0)
	* This release adds support for the following capabilities: Configuration of the Gen AI system via AIAgent and AIPrompts. Integration support for Bedrock Knowledge Base.
* Redshift (3.7.401.0)
	* Add validation pattern to S3KeyPrefix on the EnableLogging API
* Core 3.7.400.31
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.899.0 (2024-10-04 18:17 UTC)
* EC2 (3.7.408.0)
	* Documentation updates for Amazon EC2.
* IotData (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* Core 3.7.400.30
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.898.0 (2024-10-03 18:21 UTC)
* CodePipeline (3.7.402.0)
	* AWS CodePipeline introduces Commands action that enables you to easily run shell commands as part of your pipeline execution.
* Connect (3.7.406.0)
	* Public GetMetricDataV2 Grouping increase from 3 to 4
* EC2 (3.7.407.0)
	* This release includes a new API for modifying instance cpu-options after launch.
* IoT (3.7.402.0)
	* This release adds support for Custom Authentication with X.509 Client Certificates, support for Custom Client Certificate validation, and support for selecting application protocol and authentication type without requiring TLS ALPN for customer's AWS IoT Domain Configurations.
* MarketplaceReporting (3.7.400.0)
	* The AWS Marketplace Reporting service introduces the GetBuyerDashboard API. This API returns a dashboard that provides visibility into your organization's AWS Marketplace agreements and associated spend across the AWS accounts in your organization.
* MediaPackageV2 (3.7.401.0)
	* Added support for ClipStartTime on the FilterConfiguration object on OriginEndpoint manifest settings objects. Added support for EXT-X-START tags on produced HLS child playlists.
* QuickSight (3.7.406.0)
	* QuickSight: Add support for exporting and importing folders in AssetBundle APIs
* Core 3.7.400.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.897.0 (2024-10-02 18:29 UTC)
* AppStream (3.7.403.0)
	* Added support for Automatic Time Zone Redirection on Amazon AppStream 2.0
* B2bi (3.7.401.0)
	* Added and updated APIs to support outbound EDI transformations
* BedrockAgentRuntime (3.7.405.0)
	* Added raw model response and usage metrics to PreProcessing and PostProcessing Trace
* BedrockRuntime (3.7.404.0)
	* Added new fields to Amazon Bedrock Guardrails trace
* IoTDeviceAdvisor (3.7.401.0)
	* Add clientToken attribute and implement idempotency for CreateSuiteDefinition.
* IVSRealTime (3.7.402.0)
	* Adds new Stage Health EventErrorCodes applicable to RTMP(S) broadcasts. Bug Fix: Enforces that EncoderConfiguration Video height and width must be even-number values.
* S3 (3.7.404.0)
	* This release introduces a header representing the minimum object size limit for Lifecycle transitions.
* SageMaker (3.7.411.0)
	* releasing builtinlcc to public
* WorkSpaces (3.7.403.6)
	* WSP is being rebranded to become DCV.
* Core 3.7.400.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.896.0 (2024-10-01 18:32 UTC)
* BedrockAgent (3.7.405.0)
	* This release adds support to stop an ongoing ingestion job using the StopIngestionJob API in Agents for Amazon Bedrock.
* CodeArtifact (3.7.401.0)
	* Add support for the dual stack endpoints.
* RDS (3.7.404.0)
	* This release provides additional support for enabling Aurora Limitless Database DB clusters.
* Core 3.7.400.27
	* Fix NullReferenceException in MetricsHandler when ResponseMetadata is null
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.895.0 (2024-09-30 22:01 UTC)
* Bedrock (3.7.407.0)
	* Add support for custom models via provisioned throughput for Bedrock Model Evaluation
* CloudDirectory (3.7.400.27)
	* Add examples for API operations in model.
* Connect (3.7.405.0)
	* Amazon Connect introduces StartOutboundChatContact API allowing customers to initiate outbound chat contacts
* Pricing (3.7.400.27)
	* Add examples for API operations in model.
* ResourceGroups (3.7.401.0)
	* This update includes new APIs to support application groups and to allow users to manage resource tag-sync tasks in applications.
* SupplyChain (3.7.401.0)
	* Release DataLakeDataset, DataIntegrationFlow and ResourceTagging APIs for AWS Supply Chain
* TimestreamInfluxDB (3.7.402.0)
	* Timestream for InfluxDB now supports port configuration and additional customer-modifiable InfluxDB v2 parameters. This release adds Port to the CreateDbInstance and UpdateDbInstance API, and additional InfluxDB v2 parameters to the CreateDbParameterGroup API.
* VerifiedPermissions (3.7.400.27)
	* Add examples for API operations in model.

### 3.7.894.0 (2024-09-27 18:46 UTC)
* CustomerProfiles (3.7.401.0)
	* Introduces optional RoleArn parameter for PutIntegration request and includes RoleArn in the response of PutIntegration, GetIntegration and ListIntegrations
* QuickSight (3.7.405.0)
	* Adding personalization in QuickSight data stories. Admins can enable or disable personalization through QuickSight settings.
* SecurityHub (3.7.401.16)
	* Documentation updates for AWS Security Hub
* SimpleEmailV2 (3.7.402.0)
	* This release adds support for engagement tracking over Https using custom domains.
* WorkLink (Removed)
	* Amazon WorkLink has been removed from the SDK.
* Core 3.7.400.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.893.0 (2024-09-26 18:26 UTC)
* Chatbot (3.7.402.0)
	* Return State and StateReason fields for Chatbot Channel Configurations.
* Lambda (3.7.405.0)
	* Reverting Lambda resource-based policy and block public access APIs.
* Organizations (3.7.402.0)
	* Add support for policy operations on the CHATBOT_POLICY policy type.
* PCS (3.7.400.13)
	* AWS PCS API documentation - Edited the description of the iamInstanceProfileArn parameter of the CreateComputeNodeGroup and UpdateComputeNodeGroup actions; edited the description of the SlurmCustomSetting data type to list the supported parameters for clusters and compute node groups.
* RDSDataService (3.7.400.25)
	* Documentation update for RDS Data API to reflect support for Aurora MySQL Serverless v2 and Provisioned DB clusters.
* SageMaker (3.7.410.0)
	* Adding `TagPropagation` attribute to Sagemaker API
* Core 3.7.400.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.892.1 (2024-09-25 18:24 UTC)
* CloudTrail (3.7.400.24)
	* Doc-only update for CloudTrail network activity events release (in preview)
* EC2 (3.7.406.2)
	* Updates to documentation for the transit gateway security group referencing feature.
* FSx (3.7.400.24)
	* Doc-only update to address Lustre S3 hard-coded names.
* Core 3.7.400.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.892.0 (2024-09-24 19:12 UTC)
* Bedrock (3.7.406.0)
	* Add support for Cross Region Inference in Bedrock Model Evaluations.
* Budgets (3.7.401.0)
	* Releasing minor partitional endpoint updates
* Kinesis (3.7.402.0)
	* This release includes support to add tags when creating a stream
* PinpointSMSVoiceV2 (3.7.401.0)
	* AWS End User Messaging SMS-Voice V2 has added support for resource policies. Use the three new APIs to create, view, edit, and delete resource policies.
* SageMaker (3.7.409.0)
	* Adding `HiddenInstanceTypes` and `HiddenSageMakerImageVersionAliases` attribute to SageMaker API
* Core 3.7.400.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.891.0 (2024-09-23 18:27 UTC)
* APIGateway (3.7.400.23)
	* Documentation updates for Amazon API Gateway
* Athena (3.7.401.0)
	* List/Get/Update/Delete/CreateDataCatalog now integrate with AWS Glue connections. Users can create a Glue connection through Athena or use a Glue connection to define their Athena federated parameters.
* BedrockAgent (3.7.404.0)
	* Amazon Bedrock Prompt Flows and Prompt Management now supports using inference profiles to increase throughput and improve resilience.
* EC2 (3.7.406.0)
	* Amazon EC2 G6e instances powered by NVIDIA L40S Tensor Core GPUs are the most cost-efficient GPU instances for deploying generative AI models and the highest performance GPU instances for spatial computing workloads.
* EMRServerless (3.7.401.0)
	* This release adds support for job concurrency and queuing configuration at Application level.
* Glue (3.7.408.0)
	* Added AthenaProperties parameter to Glue Connections, allowing Athena to store service specific properties on Glue Connections.
* RDS (3.7.403.0)
	* Support ComputeRedundancy parameter in ModifyDBShardGroup API. Add DBShardGroupArn in DBShardGroup API response. Remove InvalidMaxAcuFault from CreateDBShardGroup and ModifyDBShardGroup API. Both API will throw InvalidParameterValueException for invalid ACU configuration.
* ResourceExplorer2 (3.7.401.0)
	* AWS Resource Explorer released ListResources feature which allows customers to list all indexed AWS resources within a view.

### 3.7.890.0 (2024-09-20 22:48 UTC)
* DynamoDBv2 (3.7.401.0)
	* Generate account endpoint for DynamoDB requests when the account ID is available
* Neptune (3.7.401.0)
	* Add v2 smoke tests and smithy smokeTests trait for SDK testing.
* SageMaker (3.7.408.0)
	* Amazon SageMaker now supports using manifest files to specify the location of uncompressed model artifacts within Model Packages
* SageMakerMetrics (3.7.401.0)
	* This release introduces support for the SageMaker Metrics BatchGetMetrics API.
* WorkSpaces (3.7.403.0)
	* Releasing new ErrorCodes for SysPrep failures during ImageImport and CreateImage process
* Core 3.7.400.22
	* Add support for new built-in endpoint parameters
	* All services packages updated to require new Core

### 3.7.889.0 (2024-09-19 18:24 UTC)
* CodeConnections (3.7.401.0)
	* This release adds the PullRequestComment field to CreateSyncConfiguration API input, UpdateSyncConfiguration API input, GetSyncConfiguration API output and ListSyncConfiguration API output
* Glue (3.7.407.0)
	* This change is for releasing TestConnection api SDK model
* Lambda (3.7.404.0)
	* Tagging support for Lambda event source mapping, and code signing configuration resources.
* MediaConvert (3.7.402.0)
	* This release provides support for additional DRM configurations per SPEKE Version 2.0.
* MediaLive (3.7.405.0)
	* Adds Bandwidth Reduction Filtering for HD AVC and HEVC encodes, multiplex container settings.
* QuickSight (3.7.404.0)
	* QuickSight: 1. Add new API - ListFoldersForResource. 2. Commit mode adds visibility configuration of Apply button on multi-select controls for authors.
* SageMaker (3.7.407.0)
	* Introduced support for G6e instance types on SageMaker Studio for JupyterLab and CodeEditor applications.
* WorkSpacesWeb (3.7.401.0)
	* WorkSpaces Secure Browser now enables Administrators to view and manage end-user browsing sessions via Session Management APIs.

### 3.7.888.0 (2024-09-18 18:22 UTC)
* CostExplorer (3.7.401.0)
	* This release extends the GetReservationPurchaseRecommendation API to support recommendations for Amazon DynamoDB reservations.
* DirectoryService (3.7.401.0)
	* Added new APIs for enabling, disabling, and describing access to the AWS Directory Service Data API
* DirectoryServiceData (3.7.400.0)
	* Added new AWS Directory Service Data API, enabling you to manage data stored in AWS Directory Service directories. This includes APIs for creating, reading, updating, and deleting directory users, groups, and group memberships.
* GuardDuty (3.7.402.0)
	* Add `launchType` and `sourceIPs` fields to GuardDuty findings.
* MailManager (3.7.401.0)
	* Introduce a new RuleSet condition evaluation, where customers can set up a StringExpression with a MimeHeader condition. This condition will perform the necessary validation based on the X-header provided by customers.
* RDS (3.7.402.2)
	* Updates Amazon RDS documentation with information upgrading snapshots with unsupported engine versions for RDS for MySQL and RDS for PostgreSQL.
* S3 (3.7.403.0)
	* Added SSE-KMS support for directory buckets.

### 3.7.887.0 (2024-09-17 18:21 UTC)
* CodeBuild (3.7.403.0)
	* GitLab Enhancements - Add support for Self-Hosted GitLab runners in CodeBuild. Add group webhooks
* ECR (3.7.404.0)
	* The `DescribeImageScanning` API now includes `fixAvailable`, `exploitAvailable`, and `fixedInVersion` fields to provide more detailed information about the availability of fixes, exploits, and fixed versions for identified image vulnerabilities.
* ECS (3.7.402.16)
	* This is a documentation only release to address various tickets.
* Lambda (3.7.403.0)
	* Support for JSON resource-based policies and block public access
* RDS (3.7.402.1)
	* Updates Amazon RDS documentation with configuration information about the BYOL model for RDS for Db2.
* SimpleSystemsManagement (3.7.402.0)
	* Support for additional levels of cross-account, cross-Region organizational units in Automation. Various documentation updates.

### 3.7.886.0 (2024-09-16 18:27 UTC)
* Bedrock (3.7.405.0)
	* This feature adds cross account s3 bucket and VPC support to ModelInvocation jobs. To use a cross account bucket, pass in the accountId of the bucket to s3BucketOwner in the ModelInvocationJobInputDataConfig or ModelInvocationJobOutputDataConfig.
* IoT (3.7.401.0)
	* This release adds additional enhancements to AWS IoT Device Management Software Package Catalog and Jobs. It also adds SBOM support in Software Package Version.
* MediaLive (3.7.404.0)
	* Removing the ON_PREMISE enum from the input settings field.
* Organizations (3.7.401.10)
	* Doc only update for AWS Organizations that fixes several customer-reported issues
* PcaConnectorScep (3.7.400.21)
	* This is a general availability (GA) release of Connector for SCEP, a feature of AWS Private CA. Connector for SCEP links your SCEP-enabled and mobile device management systems to AWS Private CA for digital signature installation and certificate management.
* RDS (3.7.402.0)
	* Launching Global Cluster tagging.
* Core 3.7.400.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.885.1 (2024-09-13 18:17 UTC)
* Amplify (3.7.401.15)
	* Doc only update to Amplify to explain platform setting for Next.js 14 SSG only applications
* IVS (3.7.400.20)
	* Updates to all tags descriptions.
* Ivschat (3.7.400.20)
	* Updates to all tags descriptions.
* Core 3.7.400.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.885.0 (2024-09-12 18:22 UTC)
* CognitoIdentityProvider (3.7.403.0)
	* Added email MFA option to user pools with advanced security features.
* ElasticLoadBalancingV2 (3.7.404.0)
	* Correct incorrectly mapped error in ELBv2 waiters
* ElasticMapReduce (3.7.401.0)
	* Update APIs to allow modification of ODCR options, allocation strategy, and InstanceTypeConfigs on running InstanceFleet clusters.
* Glue (3.7.406.0)
	* AWS Glue is introducing two new optimizers for Apache Iceberg tables: snapshot retention and orphan file deletion. Customers can enable these optimizers and customize their configurations to perform daily maintenance tasks on their Iceberg tables based on their specific requirements.
* MediaConvert (3.7.401.0)
	* This release includes support for dynamic video overlay workflows, including picture-in-picture and squeezeback
* RDS (3.7.401.18)
	* This release adds support for the os-upgrade pending maintenance action for Amazon Aurora DB clusters.
* StorageGateway (3.7.401.0)
	* The S3 File Gateway now supports DSSE-KMS encryption. A new parameter EncryptionType is added to these APIs: CreateSmbFileShare, CreateNfsFileShare, UpdateSmbFileShare, UpdateNfsFileShare, DescribeSmbFileShares, DescribeNfsFileShares. Also, in favor of EncryptionType, KmsEncrypted is deprecated.
* Synthetics (3.7.401.0)
	* This release introduces two features. The first is tag replication, which allows for the propagation of canary tags onto Synthetics related resources, such as Lambda functions. The second is a limit increase in canary name length, which has now been increased from 21 to 255 characters.

### 3.7.884.0 (2024-09-11 18:27 UTC)
* BedrockAgent (3.7.403.0)
	* Amazon Bedrock Knowledge Bases now supports using inference profiles to increase throughput and improve resilience.
* BedrockAgentRuntime (3.7.404.0)
	* Amazon Bedrock Knowledge Bases now supports using inference profiles to increase throughput and improve resilience.
* ECR (3.7.403.0)
	* Added KMS_DSSE to EncryptionType
* GuardDuty (3.7.401.0)
	* Add support for new statistic types in GetFindingsStatistics.
* LexModelsV2 (3.7.402.0)
	* Support new Polly voice engines in VoiceSettings: long-form and generative
* MediaLive (3.7.403.0)
	* Adds AV1 Codec support, SRT ouputs, and MediaLive Anywhere support.
* S3 (3.7.402.10)
	* Added support for RequestPayer property in TransferUtility Upload request/commands.
* Core 3.7.400.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.883.0 (2024-09-10 18:29 UTC)
* ChimeSDKVoice (3.7.400.18)
	* Documentation-only update that clarifies the ValidateE911Address action of the Amazon Chime SDK Voice APIs.
* CognitoIdentity (3.7.401.0)
	* This release adds sensitive trait to some required shapes.
* Pipes (3.7.401.0)
	* This release adds support for customer managed KMS keys in Amazon EventBridge Pipe
* SecurityHub (3.7.401.8)
	* Documentation update for Security Hub
* Core 3.7.400.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.882.0 (2024-09-09 18:22 UTC)
* DynamoDBv2 (3.7.400.17)
	* Doc-only update for DynamoDB. Added information about async behavior for TagResource and UntagResource APIs and updated the description of ResourceInUseException.
* ElasticLoadBalancingV2 (3.7.403.0)
	* Add paginators for the ELBv2 DescribeListenerCertificates and DescribeRules APIs. Fix broken waiter for the ELBv2 DescribeLoadBalancers API.
* IVSRealTime (3.7.401.0)
	* IVS Real-Time now offers customers the ability to broadcast to Stages using RTMP(S).
* Kafka (3.7.401.0)
	* Amazon MSK Replicator can now replicate data to identically named topics between MSK clusters within the same AWS Region or across different AWS Regions.
* SageMaker (3.7.406.0)
	* Amazon Sagemaker supports orchestrating SageMaker HyperPod clusters with Amazon EKS
* SageMakerRuntime (3.7.401.0)
	* AWS SageMaker Runtime feature: Add sticky routing to support stateful inference models.
* Core 3.7.400.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.881.0 (2024-09-06 18:13 UTC)
* QApps (3.7.401.0)
	* Adds UpdateLibraryItemMetadata api to change status of app for admin verification feature and returns isVerified field in any api returning the app or library item.
* Core 3.7.400.16
	* Fixes #3463 where repeated retries were happening on error codes that weren't necessarily clockskew related.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.880.0 (2024-09-05 18:17 UTC)
* ApplicationSignals (3.7.402.0)
	* Amazon CloudWatch Application Signals now supports creating Service Level Objectives using a new calculation type. Users can now create SLOs which are configured with request-based SLIs to help meet their specific business requirements.
* CodePipeline (3.7.401.13)
	* Updates to add recent notes to APIs and to replace example S3 bucket names globally.
* Connect (3.7.404.0)
	* Amazon Connect Custom Vocabulary now supports Catalan (Spain), Danish (Denmark), Dutch (Netherlands), Finnish (Finland), Indonesian (Indonesia), Malay (Malaysia), Norwegian Bokmal (Norway), Polish (Poland), Swedish (Sweden), and Tagalog/Filipino (Philippines).
* GameLift (3.7.401.0)
	* Amazon GameLift provides additional events for tracking the fleet creation process.
* KinesisAnalyticsV2 (3.7.401.0)
	* Support for Flink 1.20 in Managed Service for Apache Flink
* SageMaker (3.7.405.0)
	* Amazon SageMaker now supports idle shutdown of JupyterLab and CodeEditor applications on SageMaker Studio.
* Core 3.7.400.15
	* Fix #3173. Add DynamicallyAccessedMembers to ConstantClass in Net8 to remove trim warnings.
	* All services packages updated to require new Core

### 3.7.879.0 (2024-09-04 18:20 UTC)
* AppSync (3.7.401.0)
	* Adds new logging levels (INFO and DEBUG) for additional log output control
* BedrockAgent (3.7.402.0)
	* Add support for user metadata inside PromptVariant.
* CloudWatchLogs (3.7.403.0)
	* Update to support new APIs for delivery of logs from AWS services.
* Finspace (3.7.400.14)
	* Updates Finspace documentation for smaller instances.
* FIS (3.7.402.0)
	* This release adds safety levers, a new mechanism to stop all running experiments and prevent new experiments from starting.
* S3Control (3.7.401.0)
	* Amazon Simple Storage Service /S3 Access Grants / Features : This release launches new Access Grants API - ListCallerAccessGrants.
* Core 3.7.400.14
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.878.0 (2024-09-03 18:19 UTC)
* Connect (3.7.403.0)
	* Release ReplicaConfiguration as part of DescribeInstance
* DataZone (3.7.405.0)
	* Add support to let data publisher specify a subset of the data asset that a subscriber will have access to based on the asset filters provided, when accepting a subscription request.
* ElasticLoadBalancingV2 (3.7.402.0)
	* This release adds support for configuring TCP idle timeout on NLB and GWLB listeners.
* MediaConnect (3.7.401.0)
	* AWS Elemental MediaConnect introduces thumbnails for Flow source monitoring. Thumbnails provide still image previews of the live content feeding your MediaConnect Flow allowing you to easily verify that your source is operating as expected.
* MediaLive (3.7.402.0)
	* Added MinQP as a Rate Control option for H264 and H265 encodes.
* SageMaker (3.7.404.0)
	* Amazon SageMaker now supports automatic mounting of a user's home folder in the Amazon Elastic File System (EFS) associated with the SageMaker Studio domain to their Studio Spaces to enable users to share data between their own private spaces.
* TimestreamInfluxDB (3.7.401.0)
	* Timestream for InfluxDB now supports compute scaling and deployment type conversion. This release adds the DbInstanceType and DeploymentType parameters to the UpdateDbInstance API.

### 3.7.877.0 (2024-08-30 18:26 UTC)
* Backup (3.7.401.0)
	* The latest update introduces two new attributes, VaultType and VaultState, to the DescribeBackupVault and ListBackupVaults APIs. The VaultState attribute reflects the current status of the vault, while the VaultType attribute indicates the specific category of the vault.
* CloudWatchLogs (3.7.402.0)
	* This release introduces a new optional parameter: Entity, in PutLogEvents request
* DataZone (3.7.404.0)
	* Amazon DataZone now adds new governance capabilities of Domain Units for organization within your Data Domains, and Authorization Policies for tighter controls.
* RedshiftDataAPIService (3.7.401.0)
	* The release include the new Redshift DataAPI feature for session use, customer execute query with --session-keep-alive-seconds parameter and can submit follow-up queries to same sessions with returned`session-id`
* Core 3.7.400.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.876.0 (2024-08-29 19:23 UTC)
* BedrockAgentRuntime (3.7.403.0)
	* Lifting the maximum length on Bedrock KnowledgeBase RetrievalFilter array
* BedrockRuntime (3.7.403.0)
	* Add support for imported-model in invokeModel and InvokeModelWithResponseStream.
* Personalize (3.7.401.0)
	* This releases ability to update automatic training scheduler for customer solutions
* QuickSight (3.7.403.0)
	* Increased Character Limit for Dataset Calculation Field expressions
* StepFunctions (3.7.402.0)
	* This release adds support for static analysis to ValidateStateMachineDefinition API, which can now return optional WARNING diagnostics for semantic errors on the definition of an Amazon States Language (ASL) state machine.
* WAFV2 (3.7.401.0)
	* The minimum request rate for a rate-based rule is now 10. Before this, it was 100.

### 3.7.875.0 (2024-08-28 18:25 UTC)
* AppConfig (3.7.401.0)
	* This release adds support for deletion protection, which is a safety guardrail to prevent the unintentional deletion of a recently used AWS AppConfig Configuration Profile or Environment. This also includes a change to increase the maximum length of the Name parameter in UpdateConfigurationProfile.
* DataZone (3.7.403.0)
	* Update regex to include dot character to be consistent with IAM role creation in the authorized principal field for create and update subscription target.
* DeviceFarm (3.7.401.0)
	* This release removed support for Calabash, UI Automation, Built-in Explorer, remote access record, remote access replay, and web performance profile framework in ScheduleRun API.
* EC2 (3.7.405.0)
	* Amazon VPC IP Address Manager (IPAM) now allows customers to provision IPv4 CIDR blocks and allocate Elastic IP Addresses directly from IPAM pools with public IPv4 space
* InternetMonitor (3.7.401.0)
	* Adds new querying types to show overall traffic suggestion information for monitors
* PCS (3.7.400.0)
	* Introducing AWS Parallel Computing Service (AWS PCS), a new service makes it easy to setup and manage high performance computing (HPC) clusters, and build scientific and engineering models at virtually any scale on AWS.
* WorkSpaces (3.7.402.1)
	* Documentation-only update that clarifies the StartWorkspaces and StopWorkspaces actions, and a few other minor edits.
* Core 3.7.400.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.874.0 (2024-08-27 18:19 UTC)
* Bedrock (3.7.404.0)
	* Amazon Bedrock SDK updates for Inference Profile.
* BedrockRuntime (3.7.402.0)
	* Amazon Bedrock SDK updates for Inference Profile.
* Chatbot (3.7.401.0)
	* Update documentation to be consistent with the API docs
* Omics (3.7.401.0)
	* Adds data provenance to import jobs from read sets and references
* Polly (3.7.401.0)
	* Amazon Polly adds 2 new voices: Jitka (cs-CZ) and Sabrina (de-CH).

### 3.7.873.0 (2024-08-26 18:17 UTC)
* IoTSiteWise (3.7.401.0)
	* AWS IoT SiteWise now supports versioning for asset models. It enables users to retrieve active version of their asset model and perform asset model writes with optimistic lock.
* WorkSpaces (3.7.402.0)
	* This release adds support for creating and managing directories that use AWS IAM Identity Center as user identity source. Such directories can be used to create non-Active Directory domain joined WorkSpaces Personal.Updated RegisterWorkspaceDirectory and DescribeWorkspaceDirectories APIs.

### 3.7.872.0 (2024-08-23 18:27 UTC)
* BedrockAgent (3.7.401.0)
	* Releasing the support for Action User Confirmation.
* BedrockAgentRuntime (3.7.402.0)
	* Releasing the support for Action User Confirmation.
* CodeBuild (3.7.402.4)
	* Added support for the MAC_ARM environment type for CodeBuild fleets.
* Organizations (3.7.401.0)
	* Releasing minor partitional endpoint updates.
* QBusiness (3.7.401.0)
	* Amazon QBusiness: Enable support for SAML and OIDC federation through AWS IAM Identity Provider integration.
* S3Control (3.7.400.12)
	* Update the `CreateJob` API to only include the `UserArguments` property when populated.
* SupplyChain (3.7.400.12)
	* Update API documentation to clarify the event SLA as well as the data model expectations

### 3.7.871.0 (2024-08-22 18:42 UTC)
* AutoScaling (3.7.401.9)
	* Amazon EC2 Auto Scaling now provides EBS health check to manage EC2 instance replacement
* Bedrock (3.7.403.0)
	* Amazon Bedrock Evaluation BatchDeleteEvaluationJob API allows customers to delete evaluation jobs under terminated evaluation job statuses - Stopped, Failed, or Completed. Customers can submit a batch of 25 evaluation jobs to be deleted at once.
* EMRContainers (3.7.401.0)
	* Correct endpoint for FIPS is configured for US Gov Regions.
* Inspector2 (3.7.402.0)
	* Add enums for Agentless scan statuses and EC2 enablement error states
* QuickSight (3.7.402.0)
	* Explicit query for authors and dashboard viewing sharing for embedded users
* Route53 (3.7.402.0)
	* Amazon Route 53 now supports the Asia Pacific (Malaysia) Region (ap-southeast-5) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Core 3.7.400.11
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.870.0 (2024-08-21 18:27 UTC)
* CodeStar (Removed)
	* AWS CodeStar has been removed from the SDK because it has been discontinued.
* EC2 (3.7.404.0)
	* DescribeInstanceStatus now returns health information on EBS volumes attached to Nitro instances
* EntityResolution (3.7.401.0)
	* Increase the mapping attributes in Schema to 35.
* Glue (3.7.405.0)
	* Add optional field JobRunQueuingEnabled to CreateJob and UpdateJob APIs.
* Lambda (3.7.402.0)
	* Release FilterCriteria encryption for Lambda EventSourceMapping,  enabling customers to encrypt their filter criteria using a customer-owned KMS key.
* SecurityHub (3.7.401.0)
	* Security Hub documentation and definition updates
* SimpleEmail (3.7.401.0)
	* Enable email receiving customers to provide SES with access to their S3 buckets via an IAM role for "Deliver to S3 Action"
* Core 3.7.400.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.869.0 (2024-08-20 18:29 UTC)
* ECS (3.7.402.3)
	* Documentation only release to address various tickets
* OpenSearchServerless (3.7.401.0)
	* Added FailureCode and FailureMessage to BatchGetCollectionResponse for BatchGetVPCEResponse for non-Active Collection and VPCE.
* S3 (3.7.402.0)
	* Amazon Simple Storage Service / Features : Add support for conditional writes for PutObject and CompleteMultipartUpload APIs.
* Core 3.7.400.9
	* Support stringArray and OperationContextParams in Endpoint rules
	* All services packages updated to require new Core

### 3.7.868.0 (2024-08-19 18:18 UTC)
* Bedrock (3.7.402.0)
	* Amazon Bedrock Batch Inference/ Model Invocation is a feature which allows customers to asynchronously run inference on a large set of records/files stored in S3.
* CodeBuild (3.7.402.0)
	* AWS CodeBuild now supports creating fleets with macOS platform for running builds.
* Deadline (3.7.401.0)
	* This release adds additional search fields and provides sorting by multiple fields.
* Lambda (3.7.401.0)
	* Release Lambda FunctionRecursiveConfig, enabling customers to turn recursive loop detection on or off on individual functions. This release adds two new APIs, GetFunctionRecursionConfig and PutFunctionRecursionConfig.
* SsmSap (3.7.401.0)
	* Add new attributes to the outputs of GetApplication and GetDatabase APIs.
* Core 3.7.400.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.867.0 (2024-08-16 18:17 UTC)
* Batch (3.7.401.0)
	* Improvements of integration between AWS Batch and EC2.
* Inspector2 (3.7.401.0)
	* Update the correct format of key and values for resource tags
* QuickSight (3.7.401.0)
	* Amazon QuickSight launches Customer Managed Key (CMK) encryption for Data Source metadata
* SageMaker (3.7.403.0)
	* Introduce Endpoint and EndpointConfig Arns in sagemaker:ListPipelineExecutionSteps API response
* SimpleEmailV2 (3.7.401.0)
	* Marking use case description field of account details as deprecated.
* Core 3.7.400.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.866.0 (2024-08-15 18:20 UTC)
* DocDB (3.7.401.0)
	* This release adds Global Cluster Failover capability which enables you to change your global cluster's primary AWS region, the region that serves writes, during a regional outage. Performing a failover action preserves your Global Cluster setup.
* ECS (3.7.402.0)
	* This release introduces a new ContainerDefinition configuration to support the customer-managed keys for ECS container restart feature.
* IdentityManagement (3.7.402.0)
	* Make the LastUsedDate field in the GetAccessKeyLastUsed response optional. This may break customers who only call the API for access keys with a valid LastUsedDate. This fixes a deserialization issue for access keys without a LastUsedDate, because the field was marked as required but could be null.
* S3 (3.7.401.0)
	* Amazon Simple Storage Service / Features  : Adds support for pagination in the S3 ListBuckets API.
* Core 3.7.400.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.865.0 (2024-08-14 18:13 UTC)
* CodeBuild (3.7.401.0)
	* AWS CodeBuild now supports using Secrets Manager to store git credentials and using multiple source credentials in a single project.

### 3.7.864.0 (2024-08-13 18:17 UTC)
* Amplify (3.7.401.0)
	* Add a new field "cacheConfig" that enables users to configure the CDN cache settings for an App
* AppStream (3.7.402.0)
	* This release includes following new APIs: CreateThemeForStack, DescribeThemeForStack, UpdateThemeForStack, DeleteThemeForStack to support custom branding programmatically.
* FIS (3.7.401.0)
	* This release adds support for additional error information on experiment failure. It adds the error code, location, and account id on relevant failures to the GetExperiment and ListExperiment API responses.
* Glue (3.7.404.0)
	* Add AttributesToGet parameter support for Glue GetTables
* NeptuneGraph (3.7.401.0)
	* Amazon Neptune Analytics provides a new option for customers to load data into a graph using the RDF (Resource Description Framework) NTRIPLES format. When loading NTRIPLES files, use the value `convertToIri` for the `blankNodeHandling` parameter.
* Core 3.7.400.5
	* Add AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization property for users using the WebApplicationFactory for mock testing.
	* All services packages updated to require new Core

### 3.7.863.0 (2024-08-12 18:20 UTC)
* ComputeOptimizer (3.7.400.5)
	* Doc only update for Compute Optimizer that fixes several customer-reported issues relating to ECS finding classifications
* ConfigService (3.7.401.0)
	* Documentation update for the OrganizationConfigRuleName regex pattern.
* EC2 (3.7.403.0)
	* This release adds new capabilities to manage On-Demand Capacity Reservations including the ability to split your reservation, move capacity between reservations, and modify the instance eligibility of your reservation.
* EKS (3.7.402.0)
	* Added support for new AL2023 GPU AMIs to the supported AMITypes.
* GroundStation (3.7.400.5)
	* Updating documentation for OEMEphemeris to link to AWS Ground Station User Guide
* MediaLive (3.7.401.0)
	* AWS Elemental MediaLive now supports now supports editing the PID values for a Multiplex.
* SageMaker (3.7.402.0)
	* Releasing large data support as part of CreateAutoMLJobV2 in SageMaker Autopilot and CreateDomain API for SageMaker Canvas.

### 3.7.862.0 (2024-08-09 18:42 UTC)
* CognitoIdentityProvider (3.7.402.1)
	* Fixed a description of AdvancedSecurityAdditionalFlows in Amazon Cognito user pool configuration.
* Connect (3.7.402.0)
	* This release supports adding RoutingCriteria via UpdateContactRoutingData public API.
* SimpleSystemsManagement (3.7.401.2)
	* Systems Manager doc-only updates for August 2024.
* Core 3.7.400.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.861.0 (2024-08-08 18:16 UTC)
* CognitoIdentityProvider (3.7.402.0)
	* Added support for threat protection for custom authentication in Amazon Cognito user pools.
* Connect (3.7.401.0)
	* This release fixes a regression in number of access control tags that are allowed to be added to a security profile in Amazon Connect. You can now add up to four access control tags on a single security profile.
* EC2 (3.7.402.0)
	* Launch of private IPv6 addressing for VPCs and Subnets. VPC IPAM supports the planning and monitoring of private IPv6 usage.
* Glue (3.7.403.0)
	* This release adds support to retrieve the validation status when creating or updating Glue Data Catalog Views. Also added is support for BasicCatalogTarget partition keys.

### 3.7.860.0 (2024-08-07 18:14 UTC)
* AppIntegrationsService (3.7.401.0)
	* Updated CreateDataIntegration and CreateDataIntegrationAssociation API to support bulk data export from Amazon Connect Customer Profiles to the customer S3 bucket.
* Glue (3.7.402.0)
	* Introducing AWS Glue Data Quality anomaly detection, a new functionality that uses ML-based solutions to detect data anomalies users have not explicitly defined rules for.

### 3.7.859.0 (2024-08-06 18:16 UTC)
* BedrockAgentRuntime (3.7.401.0)
	* Introduce model invocation output traces for orchestration traces, which contain the model's raw response and usage.
* CognitoIdentityProvider (3.7.401.0)
	* Advanced security feature updates to include password history and log export for Cognito user pools.
* CostOptimizationHub (3.7.401.0)
	* This release adds savings percentage support to the ListRecommendationSummaries API.
* WorkSpaces (3.7.401.0)
	* Added support for BYOL_GRAPHICS_G4DN_WSP IngestionProcess

### 3.7.858.0 (2024-08-05 18:19 UTC)
* DataZone (3.7.402.0)
	* This releases Data Product feature. Data Products allow grouping data assets into cohesive, self-contained units for ease of publishing for data producers, and ease of finding and accessing for data consumers.
* ECR (3.7.402.0)
	* Released two new APIs along with documentation updates. The GetAccountSetting API is used to view the current basic scan type version setting for your registry, while the PutAccountSetting API is used to update the basic scan type version for your registry.
* KinesisVideoWebRTCStorage (3.7.401.0)
	* Add JoinStorageSessionAsViewer API
* PI (3.7.400.3)
	* Added a description for the Dimension db.sql.tokenized_id on the DimensionGroup data type page.
* Core 3.7.400.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

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

