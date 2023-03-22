### 3.7.510.0 (2023-03-22 18:24 UTC)
* IdentityManagement (3.7.100.98)
	* Documentation updates for AWS Identity and Access Management (IAM).
* IoTTwinMaker (3.7.103.0)
	* This release adds support of adding metadata when creating a new scene or updating an existing scene.
* NetworkManager (3.7.101.61)
	* This release includes an update to create-transit-gateway-route-table-attachment, showing example usage for TransitGatewayRouteTableArn.
* Pipes (3.7.102.0)
	* This release improves validation on the ARNs in the API model
* ResilienceHub (3.7.102.0)
	* This release provides customers with the ability to import resources from within an EKS cluster and assess the resiliency of EKS cluster workloads.
* SimpleSystemsManagement (3.7.104.0)
	* This Patch Manager release supports creating, updating, and deleting Patch Baselines for AmazonLinux2023, AlmaLinux.
* Core 3.7.106.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.509.0 (2023-03-21 18:24 UTC)
* ChimeSDKMessaging (3.7.101.0)
	* Amazon Chime SDK messaging customers can now manage streaming configuration for messaging data for archival and analysis.
* CleanRooms (3.7.101.0)
	* GA Release of AWS Clean Rooms, Added Tagging Functionality
* EC2 (3.7.128.0)
	* This release adds support for AWS Network Firewall, AWS PrivateLink, and Gateway Load Balancers to Amazon VPC Reachability Analyzer, and it makes the path destination optional as long as a destination address in the filter at source is provided.
* IoTSiteWise (3.7.102.0)
	* Provide support for tagging of data streams and enabling tag based authorization for property alias
* Mgn (3.7.102.0)
	* This release introduces the Import and export feature and expansion of the post-launch actions
* Core 3.7.106.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.508.0 (2023-03-20 18:22 UTC)
* ApplicationAutoScaling (3.7.104.0)
	* With this release customers can now tag their Application Auto Scaling registered targets with key-value pairs and manage IAM permissions for all the tagged resources centrally.
* Neptune (3.7.102.0)
	* This release makes following few changes. db-cluster-identifier is now a required parameter of create-db-instance. describe-db-cluster will now return PendingModifiedValues and GlobalClusterIdentifier fields in the response.
* S3Outposts (3.7.102.0)
	* S3 On Outposts added support for endpoint status, and a failed endpoint reason, if any
* WorkDocs (3.7.102.0)
	* This release adds a new API, SearchResources, which enable users to search through metadata and content of folders, documents, document versions and comments in a WorkDocs site.
* Core 3.7.106.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.507.0 (2023-03-17 18:22 UTC)
* BillingConductor (3.7.105.0)
	* This release adds a new filter to ListAccountAssociations API and a new filter to ListBillingGroups API.
* ConfigService (3.7.102.0)
	* This release adds resourceType enums for types released from October 2022 through February 2023.
* DatabaseMigrationService (3.7.103.0)
	* S3 setting to create AWS Glue Data Catalog. Oracle setting to control conversion of timestamp column. Support for Kafka SASL Plain authentication. Setting to map boolean from PostgreSQL to Redshift. SQL Server settings to force lob lookup on inline LOBs and to control access of database logs.
* Core 3.7.106.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.506.0 (2023-03-17 13:51 UTC)
* Core 3.7.106.0
	* Align the default of HttpClientCacheSize to 1 across all the platforms; Configure ECSTaskCredentials to refresh 5 minutes before expiration time
	* All services packages updated to require new Core

### 3.7.505.0 (2023-03-16 18:22 UTC)
* GuardDuty (3.7.101.0)
	* Updated 9 APIs for feature enablement to reflect expansion of GuardDuty to features. Added new APIs and updated existing APIs to support RDS Protection GA.
* ResourceExplorer2 (3.7.101.51)
	* Documentation updates for APIs.
* SageMakerRuntime (3.7.101.30)
	* Documentation updates for SageMaker Runtime
* Core 3.7.105.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.504.0 (2023-03-15 18:21 UTC)
* MigrationHubStrategyRecommendations (3.7.103.0)
	* This release adds the binary analysis that analyzes IIS application DLLs on Windows and Java applications on Linux to provide anti-pattern report without configuring access to the source code.
* S3Control (3.7.108.0)
	* Added support for S3 Object Lambda aliases.
* SecurityLake (3.7.102.0)
	* Make Create/Get/ListSubscribers APIs return resource share ARN and name so they can be used to validate the RAM resource share to accept. GetDatalake can be used to track status of UpdateDatalake and DeleteDatalake requests.
* Core 3.7.105.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.503.0 (2023-03-14 18:29 UTC)
* ApplicationAutoScaling (3.7.103.0)
	* Application Auto Scaling customers can now use mathematical functions to customize the metric used with Target Tracking policies within the policy configuration itself, saving the cost and effort of publishing the customizations as a separate metric.
* DataExchange (3.7.102.0)
	* This release enables data providers to license direct access to S3 objects encrypted with Customer Managed Keys (CMK) in AWS KMS through AWS Data Exchange. Subscribers can use these keys to decrypt, then use the encrypted S3 objects shared with them, without creating or managing copies.
* DirectConnect (3.7.100.90)
	* describe-direct-connect-gateway-associations includes a new status, updating, indicating that the association is currently in-process of updating.
* EC2 (3.7.127.0)
	* This release adds a new DnsOptions key (PrivateDnsOnlyForInboundResolverEndpoint) to CreateVpcEndpoint and ModifyVpcEndpoint APIs.
* IdentityManagement (3.7.100.91)
	* Documentation only updates to correct customer-reported issues
* Keyspaces (3.7.102.0)
	* Adding support for client-side timestamps
* Core 3.7.105.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.502.0 (2023-03-13 18:23 UTC)
* AppIntegrationsService (3.7.101.0)
	* Adds FileConfiguration to Amazon AppIntegrations CreateDataIntegration supporting scheduled downloading of third party files into Amazon Connect from sources such as Microsoft SharePoint.
* ConnectWisdomService (3.7.102.0)
	* This release extends Wisdom CreateKnowledgeBase API to support SharePoint connector type by removing the @required trait for objectField
* LakeFormation (3.7.103.3)
	* This release updates the documentation regarding Get/Update DataCellsFilter
* S3Control (3.7.107.0)
	* Added support for cross-account Multi-Region Access Points. Added support for S3 Replication for S3 on Outposts.
* Tnb (3.7.101.0)
	* This release adds tagging support to the following Network Instance APIs : Instantiate, Update, Terminate.
* Core 3.7.105.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.501.0 (2023-03-10 19:26 UTC)
* Ivschat (3.7.104.0)
	* This release adds a new exception returned when calling AWS IVS chat UpdateLoggingConfiguration. Now UpdateLoggingConfiguration can return ConflictException when invalid updates are made in sequence to Logging Configurations.
* SecretsManager (3.7.102.0)
	* The type definitions of SecretString and SecretBinary now have a minimum length of 1 in the model to match the exception thrown when you pass in empty values.
* Core 3.7.105.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.500.0 (2023-03-09 19:28 UTC)
* CloudWatchEvidently (3.7.102.0)
	* Updated entity override documentation
* CodeArtifact (3.7.103.0)
	* This release introduces the generic package format, a mechanism for storing arbitrary binary assets. It also adds a new API, PublishPackageVersion, to allow for publishing generic packages.
* Connect (3.7.118.0)
	* This release adds a new API, GetMetricDataV2, which returns metric data for Amazon Connect.
* NetworkManager (3.7.101.51)
	* This update provides example usage for TransitGatewayRouteTableArn.
* QuickSight (3.7.106.0)
	* This release has two changes: add state persistence feature for embedded dashboard and console in GenerateEmbedUrlForRegisteredUser API; add properties for hidden collapsed row dimensions in PivotTableOptions.
* RedshiftDataAPIService (3.7.102.0)
	* Added support for Redshift Serverless workgroup-arn wherever the WorkgroupName parameter is available.
* SageMaker (3.7.122.0)
	* Amazon SageMaker Inference now allows SSM access to customer's model container by setting the "EnableSSMAccess" parameter for a ProductionVariant in CreateEndpointConfig API.
* ServiceDiscovery (3.7.101.0)
	* Updated all AWS Cloud Map APIs to provide consistent throttling exception (RequestLimitExceeded)
* SimpleEmailV2 (3.7.102.0)
	* This release introduces a new recommendation in Virtual Deliverability Manager Advisor, which detects missing or misconfigured Brand Indicator for Message Identification (BIMI) DNS records for customer sending identities.
* Core 3.7.105.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.499.0 (2023-03-08 19:27 UTC)
* Athena (3.7.104.0)
	* A new field SubstatementType is added to GetQueryExecution API, so customers have an error free way to detect the query type and interpret the result.
* DynamoDBv2 (3.7.102.0)
	* Adds deletion protection support to DynamoDB tables. Tables with deletion protection enabled cannot be deleted. Deletion protection is disabled by default, can be enabled via the CreateTable or UpdateTable APIs, and is visible in TableDescription. This setting is not replicated for Global Tables.
* EC2 (3.7.126.0)
	* Introducing Amazon EC2 C7g, M7g and R7g instances, powered by the latest generation AWS Graviton3 processors and deliver up to 25% better performance over Graviton2-based instances.
* LakeFormation (3.7.103.0)
	* This release adds two new API support "GetDataCellsFiler" and "UpdateDataCellsFilter", and also updates the corresponding documentation.
* MediaPackage (3.7.101.0)
	* This release provides the date and time live resources were created.
* MediaPackageVod (3.7.103.0)
	* This release provides the date and time VOD resources were created.
* Route53Resolver (3.7.101.0)
	* Add dual-stack and IPv6 support for Route 53 Resolver Endpoint,Add IPv6 target IP in Route 53 Resolver Forwarding Rule
* SageMaker (3.7.121.0)
	* There needs to be a user identity to specify the SageMaker user who perform each action regarding the entity. However, these is a not a unified concept of user identity across SageMaker service that could be used today.
* Core 3.7.105.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.498.0 (2023-03-07 19:21 UTC)
* DatabaseMigrationService (3.7.102.0)
	* This release adds DMS Fleet Advisor Target Recommendation APIs and exposes functionality for DMS Fleet Advisor. It adds functionality to start Target Recommendation calculation.
* LocationService (3.7.102.6)
	* Documentation update for the release of 3 additional map styles for use with Open Data Maps: Open Data Standard Dark, Open Data Visualization Light & Open Data Visualization Dark.
* Core 3.7.105.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.497.0 (2023-03-06 19:17 UTC)
* Account (3.7.102.0)
	* AWS Account alternate contact email addresses can now have a length of 254 characters and contain the character "|".
* IVS (3.7.101.27)
	* Updated text description in DeleteChannel, Stream, and StreamSummary.

### 3.7.496.0 (2023-03-03 19:25 UTC)
* DynamoDBv2 (3.7.101.55)
	* Documentation updates for DynamoDB.
* EC2 (3.7.125.0)
	* This release adds support for a new boot mode for EC2 instances called 'UEFI Preferred'.
* Macie2 (3.7.103.5)
	* Documentation updates for Amazon Macie
* MediaConvert (3.7.107.0)
	* The AWS Elemental MediaConvert SDK has improved handling for different input and output color space combinations.
* MediaLive (3.7.105.0)
	* AWS Elemental MediaLive adds support for Nielsen watermark timezones.
* TranscribeService (3.7.104.0)
	* Amazon Transcribe now supports role access for these API operations: CreateVocabulary, UpdateVocabulary, CreateVocabularyFilter, and UpdateVocabularyFilter.
* Core 3.7.105.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.495.0 (2023-03-02 19:22 UTC)
* IoT (3.7.105.0)
	* A recurring maintenance window is an optional configuration used for rolling out the job document to all devices in the target group observing a predetermined start time, duration, and frequency that the maintenance window occurs.
* MigrationHubStrategyRecommendations (3.7.102.0)
	* This release updates the File Import API to allow importing servers already discovered by customers with reduced pre-requisites.
* Organizations (3.7.102.0)
	* This release introduces a new reason code, ACCOUNT_CREATION_NOT_COMPLETE, to ConstraintViolationException in CreateOrganization API.
* PI (3.7.101.0)
	* This release adds a new field PeriodAlignment to allow the customer specifying the returned timestamp of time periods to be either the start or end time.
* Pipes (3.7.101.0)
	* This release fixes some input parameter range and patterns.
* SageMaker (3.7.120.0)
	* Add a new field "EndpointMetrics" in SageMaker Inference Recommender "ListInferenceRecommendationsJobSteps" API response.
* Core 3.7.105.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.494.1 (2023-03-02 01:40 UTC)
* S3 (3.7.103.19)
	* Fix for S3 UploadPartCopyRequest/CopyPart endpoint resolution

### 3.7.494.0 (2023-03-01 19:22 UTC)
* CodeCatalyst (3.7.101.0)
	* Published Dev Environments StopDevEnvironmentSession API
* Pricing (3.7.101.0)
	* This release adds 2 new APIs - ListPriceLists which returns a list of applicable price lists, and GetPriceListFileUrl which outputs a URL to retrieve your price lists from the generated file from ListPriceLists
* S3Outposts (3.7.101.0)
	* S3 on Outposts introduces a new API ListOutpostsWithS3, with this API you can list all your Outposts with S3 capacity.
* Core 3.7.105.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.493.0 (2023-02-28 19:23 UTC)
* Comprehend (3.7.102.0)
	* Amazon Comprehend now supports flywheels to help you train and manage new model versions for custom models.
* EC2 (3.7.124.0)
	* This release allows IMDS support to be set to v2-only on an existing AMI, so that all future instances launched from that AMI will use IMDSv2 by default.
* KeyManagementService (3.7.101.56)
	* AWS KMS is deprecating the RSAES_PKCS1_V1_5 wrapping algorithm option in the GetParametersForImport API that is used in the AWS KMS Import Key Material feature. AWS KMS will end support for this wrapping algorithm by October 1, 2023.
* Lightsail (3.7.102.0)
	* This release adds Lightsail for Research feature support, such as GUI session access, cost estimates, stop instance on idle, and disk auto mount.
* ManagedBlockchain (3.7.101.0)
	* This release adds support for tagging to the accessor resource in Amazon Managed Blockchain
* Omics (3.7.101.0)
	* Minor model changes to accomodate batch imports feature
* Core 3.7.105.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.492.0 (2023-02-27 19:23 UTC)
* DevOpsGuru (3.7.102.0)
	* This release adds the description field on ListAnomaliesForInsight and DescribeAnomaly API responses for proactive anomalies.
* Drs (3.7.102.0)
	* New fields were added to reflect availability zone data in source server and recovery instance description commands responses, as well as source server launch status.
* InternetMonitor (3.7.100.0)
	* CloudWatch Internet Monitor is a a new service within CloudWatch that will help application developers and network engineers continuously monitor internet performance metrics such as availability and performance between their AWS-hosted applications and end-users of these applications
* Lambda (3.7.105.0)
	* This release adds the ability to create ESMs with Document DB change streams as event source. For more information see  https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html.
* MediaConvert (3.7.106.0)
	* The AWS Elemental MediaConvert SDK has added support for HDR10 to SDR tone mapping, and animated GIF video input sources.
* TimestreamWrite (3.7.101.0)
	* This release adds the ability to ingest batched historical data or migrate data in bulk from S3 into Timestream using CSV files.
* Core 3.7.105.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.491.0 (2023-02-24 19:26 UTC)
* Connect (3.7.117.0)
	* StartTaskContact API now supports linked task creation with a new optional RelatedContactId parameter
* ConnectCases (3.7.102.0)
	* This release adds the ability to delete domains through the DeleteDomain API. For more information see https://docs.aws.amazon.com/cases/latest/APIReference/Welcome.html
* Redshift (3.7.101.14)
	* Documentation updates for Redshift API bringing it in line with IAM best practices.
* SecurityHub (3.7.105.0)
	* New Security Hub APIs and updates to existing APIs that help you consolidate control findings and enable and disable controls across all supported standards
* ServiceCatalog (3.7.101.59)
	* Documentation updates for Service Catalog

### 3.7.490.0 (2023-02-23 19:38 UTC)
* Appflow (3.7.106.0)
	* This release enables the customers to choose whether to use Private Link for Metadata and Authorization call when using a private Salesforce connections
* ECS (3.7.105.0)
	* This release supports deleting Amazon ECS task definitions that are in the INACTIVE state.
* GuardDuty (3.7.100.79)
	* Updated API and data types descriptions for CreateFilter, UpdateFilter, and TriggerDetails.
* IoTWireless (3.7.102.0)
	* In this release, we add additional capabilities for the FUOTA which allows user to configure the fragment size, the sending interval and the redundancy ratio of the FUOTA tasks
* LocationService (3.7.102.0)
	* This release adds support for using Maps APIs with an API Key in addition to AWS Cognito. This includes support for adding, listing, updating and deleting API Keys.
* Macie2 (3.7.103.0)
	* This release adds support for a new finding type, Policy:IAMUser/S3BucketSharedWithCloudFront, and S3 bucket metadata that indicates if a bucket is shared with an Amazon CloudFront OAI or OAC.
* ManagedGrafana (3.7.102.4)
	* Doc-only update. Updated information on attached role policies for customer provided roles
* WAFV2 (3.7.103.0)
	* You can now associate an AWS WAF v2 web ACL with an AWS App Runner service.
* Core 3.7.105.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.489.0 (2023-02-22 19:26 UTC)
* ChimeSDKVoice (3.7.101.0)
	* This release introduces support for Voice Connector media metrics in the Amazon Chime SDK Voice namespace
* CloudFront (3.7.105.0)
	* CloudFront now supports block lists in origin request policies so that you can forward all headers, cookies, or query string from viewer requests to the origin *except* for those specified in the block list.
* CloudWatchRUM (3.7.102.0)
	* CloudWatch RUM now supports CloudWatch Custom Metrics
* DataSync (3.7.104.0)
	* AWS DataSync has relaxed the minimum length constraint of AccessKey for Object Storage locations to 1.
* OpenSearchService (3.7.104.0)
	* This release lets customers configure Off-peak window and software update related properties for a new/existing domain. It enhances the capabilities of StartServiceSoftwareUpdate API; adds 2 new APIs - ListScheduledActions & UpdateScheduledAction; and allows Auto-tune to make use of Off-peak window.
* SimpleSystemsManagement (3.7.103.31)
	* Document only update for Feb 2023

### 3.7.488.0 (2023-02-21 20:25 UTC)
* QuickSight (3.7.105.0)
	* S3 data sources now accept a custom IAM role.
* ResilienceHub (3.7.101.0)
	* In this release we improved resilience hub application creation and maintenance by introducing new resource and app component crud APIs, improving visibility and maintenance of application input sources and added support for additional information attributes to be provided by customers.
* SecurityHub (3.7.104.15)
	* Documentation updates for AWS Security Hub
* Tnb (3.7.100.0)
	* This is the initial SDK release for AWS Telco Network Builder (TNB). AWS Telco Network Builder is a network automation service that helps you deploy and manage telecom networks.
* Core 3.7.105.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.487.0 (2023-02-20 19:19 UTC)
* AuditManager (3.7.103.0)
	* This release introduces a ServiceQuotaExceededException to the UpdateAssessmentFrameworkShare API operation.
* Connect (3.7.116.0)
	* Reasons for failed diff has been approved by SDK Reviewer

### 3.7.486.1 (2023-02-18 00:42 UTC)
* DynamoDBv2 (3.7.101.48)
	* Fix: Fix DynamoDBContext.FromDocument conversion for DateTime string without milliseconds with unit tests
* Core 3.7.105.6
	* Fix: Generate new SSO token if refresh token and access token are expired and options.GenerateNewToken is true. Override AuthenticationRegion from ClientConfig if specified.
	* All services packages updated to require new Core

### 3.7.486.0 (2023-02-17 19:20 UTC)
* AppRunner (3.7.104.0)
	* This release supports removing MaxSize limit for AutoScalingConfiguration.
* Glue (3.7.109.0)
	* Release of Delta Lake Data Lake Format for Glue Studio Service
* Core 3.7.105.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.485.0 (2023-02-16 20:41 UTC)
* ElasticMapReduce (3.7.102.0)
	* This release provides customers the ability to define a timeout period for procuring capacity during a resize operation for Instance Fleet clusters. Customers can specify this timeout using the ResizeSpecifications parameter supported by RunJobFlow, ModifyInstanceFleet and AddInstanceFleet APIs.
* IVS (3.7.101.17)
	* Doc-only update. Updated text description in DeleteChannel, Stream, and StreamSummary.
* ManagedGrafana (3.7.102.0)
	* With this release Amazon Managed Grafana now supports inbound Network Access Control that helps you to restrict user access to your Grafana workspaces
* WAFV2 (3.7.102.1)
	* Added a notice for account takeover prevention (ATP). The interface incorrectly lets you to configure ATP response inspection in regional web ACLs in Region US East (N. Virginia), without returning an error. ATP response inspection is only available in web ACLs that protect CloudFront distributions.
* Core 3.7.105.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.484.0 (2023-02-15 20:11 UTC)
* CloudTrail (3.7.104.0)
	* This release adds an InsufficientEncryptionPolicyException type to the StartImport endpoint
* ElasticFileSystem (3.7.101.51)
	* Documentation update for EFS to support IAM best practices.
* FraudDetector (3.7.102.0)
	* This release introduces Lists feature which allows customers to reference a set of values in Fraud Detector's rules. With Lists, customers can dynamically manage these attributes in real time. Lists can be created/deleted and its contents can be modified using the Fraud Detector API.
* Glue (3.7.108.0)
	* Fix DirectJDBCSource not showing up in CLI code gen
* Private5G (3.7.102.0)
	* This release introduces a new StartNetworkResourceUpdate API, which enables return/replacement of hardware from a NetworkSite.
* RDS (3.7.114.22)
	* Database Activity Stream support for RDS for SQL Server.
* WAFV2 (3.7.102.0)
	* For protected CloudFront distributions, you can now use the AWS WAF Fraud Control account takeover prevention (ATP) managed rule group to block new login attempts from clients that have recently submitted too many failed login attempts.
* Core 3.7.105.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.483.0 (2023-02-14 21:28 UTC)
* AppConfig (3.7.102.0)
	* AWS AppConfig now offers the option to set a version label on hosted configuration versions. Version labels allow you to identify specific hosted configuration versions based on an alternate versioning scheme that you define.
* DataSync (3.7.103.0)
	* With this launch, we are giving customers the ability to use older SMB protocol versions, enabling them to use DataSync to copy data to and from their legacy storage arrays.
* EC2 (3.7.123.0)
	* With this release customers can turn host maintenance on or off when allocating or modifying a supported dedicated host. Host maintenance is turned on by default for supported hosts.

### 3.7.482.0 (2023-02-13 19:19 UTC)
* Account (3.7.101.0)
	* This release of the Account Management API enables customers to view and manage whether AWS Opt-In Regions are enabled or disabled for their Account. For more information, see https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html
* AppConfigData (3.7.101.0)
	* AWS AppConfig now offers the option to set a version label on hosted configuration versions. If a labeled hosted configuration version is deployed, its version label is available in the GetLatestConfiguration response.
* Snowball (3.7.101.0)
	* Adds support for EKS Anywhere on Snowball. AWS Snow Family customers can now install EKS Anywhere service on Snowball Edge Compute Optimized devices.
* Core 3.7.105.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.481.0 (2023-02-10 19:22 UTC)
* AutoScaling (3.7.103.0)
	* You can now either terminate/replace, ignore, or wait for EC2 Auto Scaling instances on standby or protected from scale in. Also, you can also roll back changes from a failed instance refresh.
* Connect (3.7.115.0)
	* This update provides the Wisdom session ARN for contacts enabled for Wisdom in the chat channel.
* EC2 (3.7.122.0)
	* Adds support for waiters that automatically poll for an imported snapshot until it reaches the completed state.
* Polly (3.7.106.0)
	* Amazon Polly adds two new neural Japanese voices - Kazuha, Tomoko
* SageMaker (3.7.119.0)
	* Amazon SageMaker Autopilot adds support for selecting algorithms in CreateAutoMLJob API.
* SimpleNotificationService (3.7.101.8)
	* This release adds support for SNS X-Ray active tracing as well as other updates.
* Core 3.7.105.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.480.0 (2023-02-10 01:18 UTC)
* S3 (3.7.103.7)
	* Fixed an issue where ListBucketMetricsConfigurations was not returning any result for existing bucket metrics configurations. Fix issue making S3 metadata be case insensitive.
* Core 3.7.105.0
	* Add support for AWS_CONFIG_FILE. Perform case-insensitive comparison for policy action names. Add missing obsolete message for DoesS3BucketExistAsync. Fix issue with updating credential profiles that are partial configured in both config and credentials file.

### 3.7.479.0 (2023-02-09 19:28 UTC)
* ChimeSDKMeetings (3.7.100.71)
	* Documentation updates for Chime Meetings SDK
* CloudWatchEvidently (3.7.101.0)
	* Updated entity overrides parameter to accept up to 2500 overrides or a total of 40KB.
* EMRContainers (3.7.102.0)
	* EMR on EKS allows configuring retry policies for job runs through the StartJobRun API. Using retry policies, a job cause a driver pod to be restarted automatically if it fails or is deleted. The job's status can be seen in the DescribeJobRun and ListJobRun APIs and monitored using CloudWatch events.
* LexModelsV2 (3.7.102.0)
	* AWS Lex now supports Network of Bots.
* LexRuntimeV2 (3.7.101.0)
	* AWS Lex now supports Network of Bots.
* Lightsail (3.7.101.60)
	* Documentation updates for Lightsail
* MigrationHubRefactorSpaces (3.7.102.0)
	* This release adds support for creating environments with a network fabric type of NONE
* WorkDocs (3.7.101.55)
	* Doc only update for the WorkDocs APIs.
* WorkSpaces (3.7.104.51)
	* Removed Windows Server 2016 BYOL and made changes based on IAM campaign.
* Core 3.7.104.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.478.0 (2023-02-08 19:21 UTC)
* Backup (3.7.102.0)
	* This release added one attribute (resource name) in the output model of our 9 existing APIs in AWS backup so that customers will see the resource name at the output. No input required from Customers.
* CloudFront (3.7.104.0)
	* CloudFront Origin Access Control extends support to AWS Elemental MediaStore origins.
* Glue (3.7.107.0)
	* DirectJDBCSource + Glue 4.0 streaming options
* LakeFormation (3.7.102.0)
	* This release removes the LFTagpolicyResource expression limits.
* Core 3.7.104.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.477.1 (2023-02-07 19:19 UTC)
* Transfer (3.7.104.25)
	* Updated the documentation for the ImportCertificate API call, and added examples.
* Core 3.7.104.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.477.0 (2023-02-06 19:29 UTC)
* ComputeOptimizer (3.7.103.0)
	* AWS Compute optimizer can now infer if Kafka is running on an instance.
* CustomerProfiles (3.7.103.0)
	* This release deprecates the PartyType and Gender enum data types from the Profile model and replaces them with new PartyTypeString and GenderString attributes, which accept any string of length up to 255.
* FraudDetector (3.7.101.0)
	* My AWS Service (Amazon Fraud Detector) - This release introduces Cold Start Model Training which optimizes training for small datasets and adds intelligent methods for treating unlabeled data. You can now train Online Fraud Insights or Transaction Fraud Insights models with minimal historical-data.
* MediaConvert (3.7.105.0)
	* The AWS Elemental MediaConvert SDK has added improved scene change detection capabilities and a bandwidth reduction filter, along with video quality enhancements, to the AVC encoder.
* Outposts (3.7.104.0)
	* Adds OrderType to Order structure. Adds PreviousOrderId and PreviousLineItemId to LineItem structure. Adds new line item status REPLACED. Increases maximum length of pagination token.
* Core 3.7.104.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.476.0 (2023-02-03 19:25 UTC)
* Proton (3.7.104.0)
	* Add new GetResourcesSummary API
* Redshift (3.7.101.1)
	* Corrects descriptions of the parameters for the API operations RestoreFromClusterSnapshot, RestoreTableFromClusterSnapshot, and CreateCluster.
* Core 3.7.104.2
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.475.0 (2023-02-02 19:44 UTC)
* AppConfig (3.7.101.0)
	* AWS AppConfig introduces KMS customer-managed key (CMK) encryption of configuration data, along with AWS Secrets Manager as a new configuration data source. S3 objects using SSE-KMS encryption and SSM Parameter Store SecureStrings are also now supported.
* Connect (3.7.114.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.121.0)
	* Documentation updates for EC2.
* ElasticLoadBalancingV2 (3.7.100.66)
	* The GWLB Flex Health Check project updates the default values of healthy-threshold-count from 3 to 5 and unhealthy-threshold-count from 3 to 2
* Keyspaces (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* QuickSight (3.7.104.0)
	* QuickSight support for Radar Chart and Dashboard Publish Options
* Redshift (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* SSOAdmin (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Core 3.7.104.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.474.0 (2023-02-02 14:49 UTC)
* S3 (3.7.103.0)
	* Performance optimization for endpoint resolvers for S3.
* S3Control (3.7.106.0)
	* Performance optimization for endpoint resolvers for S3Control.
* SecurityToken (3.7.101.0)
	* Performance optimization for endpoint resolvers for STS.
* Core 3.7.104.0
	* Add Sensitive property to AWSPropertyAttribute and use it to mark sensitive data.
	* All services packages updated to require new Core

### 3.7.473.0 (2023-02-01 19:22 UTC)
* DevOpsGuru (3.7.101.0)
	* This release adds filter support ListAnomalyForInsight API.
* ForecastService (3.7.101.0)
	* This release will enable customer select INCREMENTAL as ImportModel in Forecast's CreateDatasetImportJob API. Verified latest SDK containing required attribute, following https://w.amazon.com/bin/view/AWS-Seer/Launch/Trebuchet/
* IdentityManagement (3.7.100.65)
	* Documentation updates for AWS Identity and Access Management (IAM).
* MediaTailor (3.7.104.0)
	* The AWS Elemental MediaTailor SDK for Channel Assembly has added support for program updates, and the ability to clip the end of VOD sources in programs.
* SimpleNotificationService (3.7.101.0)
	* Additional attributes added for set-topic-attributes.
* Core 3.7.103.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.472.0 (2023-01-31 19:45 UTC)
* AccessAnalyzer (3.7.103.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* AppSync (3.7.103.0)
	* This release introduces the feature to support EventBridge as AppSync data source.
* AWSSupport (3.7.101.0)
	* This fixes incorrect endpoint construction when a customer is explicitly setting a region.
* CloudTrail (3.7.103.0)
	* Add new "Channel" APIs to enable users to manage channels used for CloudTrail Lake integrations, and "Resource Policy" APIs to enable users to manage the resource-based permissions policy attached to a channel.
* CloudTrailData (3.7.100.0)
	* Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.
* CodeArtifact (3.7.102.0)
	* This release introduces a new DeletePackage API, which enables deletion of a package and all of its versions from a repository.
* ConnectParticipant (3.7.104.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.120.0)
	* This launch allows customers to associate up to 8 IP addresses to their NAT Gateways to increase the limit on concurrent connections to a single destination by eight times from 55K to 440K.
* GroundStation (3.7.103.0)
	* DigIF Expansion changes to the Customer APIs.
* IoT (3.7.104.0)
	* Added support for IoT Rules Engine Cloudwatch Logs action batch mode.
* Kinesis (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* OpenSearchService (3.7.103.0)
	* Amazon OpenSearch Service adds the option for a VPC endpoint connection between two domains when the local domain uses OpenSearch version 1.3 or 2.3. You can now use remote reindex to copy indices from one VPC domain to another without a reverse proxy.
* Outposts (3.7.103.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Polly (3.7.105.0)
	* Amazon Polly adds two new neural American English voices - Ruth, Stephen
* SageMaker (3.7.118.0)
	* Amazon SageMaker Automatic Model Tuning now supports more completion criteria for Hyperparameter Optimization.
* SecurityHub (3.7.104.0)
	* New fields have been added to the AWS Security Finding Format. Compliance.SecurityControlId is a unique identifier for a security control across standards. Compliance.AssociatedStandards contains all enabled standards in which a security control is enabled.
* Core 3.7.103.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.471.0 (2023-01-30 19:49 UTC)
* ApplicationDiscoveryService (3.7.101.0)
	* Update ImportName validation to 255 from the current length of 100
* CloudDirectory (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* CloudFormation (3.7.104.0)
	* This feature provides a method of obtaining which regions a stackset has stack instances deployed in.
* DLM (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* EC2 (3.7.119.0)
	* We add Prefix Lists as a new route destination option for LocalGatewayRoutes. This will allow customers to create routes to Prefix Lists. Prefix List routes will allow customers to group individual CIDR routes with the same target into a single route.
* Imagebuilder (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Kafka (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* MediaConvert (3.7.104.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* SimpleWorkflow (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.

### 3.7.470.0 (2023-01-27 19:30 UTC)
* ApplicationAutoScaling (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* AppStream (3.7.102.0)
	* Fixing the issue where Appstream waiters hang for fleet_started and fleet_stopped.
* ElasticBeanstalk (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* FIS (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Glacier (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* Greengrass (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.
* GreengrassV2 (3.7.102.0)
	* Enabled FIPS endpoints for GovCloud (US) in SDK.
* MediaTailor (3.7.103.0)
	* This release introduces the As Run logging type, along with API and documentation updates.
* Outposts (3.7.102.0)
	* Adding support for payment term in GetOrder, CreateOrder responses.
* SageMaker (3.7.117.0)
	* This release supports running SageMaker Training jobs with container images that are in a private Docker registry.
* SageMakerRuntime (3.7.101.0)
	* Amazon SageMaker Runtime which supports InvokeEndpointAsync asynchronously can now invoke endpoints with custom timeout values. Asynchronous invocations support longer processing times.
* ServerlessApplicationRepository (3.7.101.0)
	* Enabled FIPS endpoints for GovCloud (US) regions in SDK.

### 3.7.469.0 (2023-01-26 19:21 UTC)
* EventBridge (3.7.101.0)
	* Minor comments for Redshift Serverless workgroup target support.
* IoTFleetWise (3.7.103.0)
	* Add model validation to BatchCreateVehicle and BatchUpdateVehicle operations that invalidate requests with an empty vehicles list.
* S3 (3.7.102.0)
	* Allow FIPS to be used with path-style URLs.
* Core 3.7.103.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.468.0 (2023-01-25 19:38 UTC)
* CloudFormation (3.7.103.0)
	* Enabled FIPS aws-us-gov endpoints in SDK.
* EC2 (3.7.118.0)
	* This release adds new functionality that allows customers to provision IPv6 CIDR blocks through Amazon VPC IP Address Manager (IPAM) as well as allowing customers to utilize IPAM Resource Discovery APIs.
* MainframeModernization (3.7.102.0)
	* Add returnCode, batchJobIdentifier in GetBatchJobExecution response, for user to view the batch job execution result & unique identifier from engine. Also removed unused headers from REST APIs
* Polly (3.7.104.0)
	* Add 5 new neural voices - Sergio (es-ES), Andres (es-MX), Remi (fr-FR), Adriano (it-IT) and Thiago (pt-BR).
* RedshiftServerless (3.7.101.33)
	* Added query monitoring rules as possible parameters for create and update workgroup operations.
* S3Control (3.7.105.0)
	* Add additional endpoint tests for S3 Control. Fix missing endpoint parameters for PutBucketVersioning and GetBucketVersioning. Prior to this fix, those operations may have resulted in an invalid endpoint being resolved.
* SageMaker (3.7.116.0)
	* SageMaker Inference Recommender now decouples from Model Registry and could accept Model Name to invoke inference recommendations job; Inference Recommender now provides CPU/Memory Utilization metrics data in recommendation output.
* SecurityToken (3.7.100.61)
	* Doc only change to update wording in a key topic
* Core 3.7.103.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.467.0 (2023-01-24 19:23 UTC)
* GlueDataBrew (3.7.101.0)
	* Enabled FIPS us-gov-west-1 endpoints in SDK.
* Route53 (3.7.104.0)
	* Amazon Route 53 now supports the Asia Pacific (Melbourne) Region (ap-southeast-4) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SsmSap (3.7.101.0)
	* This release provides updates to documentation and support for listing operations performed by AWS Systems Manager for SAP.
* Core 3.7.103.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.466.0 (2023-01-23 19:28 UTC)
* Lambda (3.7.104.0)
	* Release Lambda RuntimeManagementConfig, enabling customers to better manage runtime updates to their Lambda functions. This release adds two new APIs, GetRuntimeManagementConfig and PutRuntimeManagementConfig, as well as support on existing Create/Get/Update function APIs.
* SageMaker (3.7.115.0)
	* Amazon SageMaker Inference now supports P4de instance types.
* Core 3.7.103.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.465.0 (2023-01-20 19:33 UTC)
* EC2 (3.7.117.0)
	* C6in, M6in, M6idn, R6in and R6idn instances are powered by 3rd Generation Intel Xeon Scalable processors (code named Ice Lake) with an all-core turbo frequency of 3.5 GHz.
* IVS (3.7.101.0)
	* API and Doc update. Update to arns field in BatchGetStreamKey. Also updates to operations and structures.
* QuickSight (3.7.103.0)
	* This release adds support for data bars in QuickSight table and increases pivot table field well limit.
* Core 3.7.103.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.464.0 (2023-01-20 00:03 UTC)
* Appflow (3.7.105.0)
	* Adding support for Salesforce Pardot connector in Amazon AppFlow.
* CloudWatchLogs (3.7.104.0)
	* Bug fix - Removed the regex pattern validation from CoralModel to avoid potential security issue.
* CodeArtifact (3.7.101.0)
	* Documentation updates for CodeArtifact
* Connect (3.7.113.0)
	* Amazon Connect Chat introduces Persistent Chat, allowing customers to resume previous conversations with context and transcripts carried over from previous chats, eliminating the need to repeat themselves and allowing agents to provide personalized service with access to entire conversation history.
* ConnectParticipant (3.7.103.0)
	* This release updates Amazon Connect Participant's GetTranscript api to provide transcripts of past chats on a persistent chat session.
* EC2 (3.7.116.0)
	* Adds SSM Parameter Resource Aliasing support to EC2 Launch Templates. Launch Templates can now store parameter aliases in place of AMI Resource IDs. CreateLaunchTemplateVersion and DescribeLaunchTemplateVersions now support a convenience flag, ResolveAlias, to return the resolved parameter value.
* Glue (3.7.106.0)
	* Release Glue Studio Hudi Data Lake Format for SDK/CLI
* GroundStation (3.7.102.0)
	* Add configurable prepass and postpass times for DataflowEndpointGroup. Add Waiter to allow customers to wait for a contact that was reserved through ReserveContact
* MediaLive (3.7.104.0)
	* AWS Elemental MediaLive adds support for SCTE 35 preRollMilliSeconds.
* OpenSearchService (3.7.102.0)
	* This release adds the enhanced dry run option, that checks for validation errors that might occur when deploying configuration changes and provides a summary of these errors, if any. The feature will also indicate whether a blue/green deployment will be required to apply a change.
* Panorama (3.7.101.0)
	* Added AllowMajorVersionUpdate option to OTAJobConfig to make appliance software major version updates opt-in.
* SageMaker (3.7.114.0)
	* HyperParameterTuningJobs now allow passing environment variables into the corresponding TrainingJobs
* Core 3.7.103.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.463.0 (2023-01-18 19:22 UTC)
* CloudWatch (3.7.103.0)
	* Enable cross-account streams in CloudWatch Metric Streams via Observability Access Manager.
* ElasticFileSystem (3.7.101.33)
	* Documentation updates for EFS access points limit increase
* Ivschat (3.7.103.0)
	* Updates the range for a Chat Room's maximumMessageRatePerSecond field.
* WAFV2 (3.7.101.52)
	* Improved the visibility of the guidance for updating AWS WAF resources, such as web ACLs and rule groups.
* Core 3.7.103.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.462.0 (2023-01-17 19:19 UTC)
* BillingConductor (3.7.104.0)
	* This release adds support for SKU Scope for pricing plans.
* Cloud9 (3.7.101.0)
	* Added minimum value to AutomaticStopTimeMinutes parameter.
* Imagebuilder (3.7.101.0)
	* Add support for AWS Marketplace product IDs as input during CreateImageRecipe for the parent-image parameter. Add support for listing third-party components.
* NetworkFirewall (3.7.103.0)
	* Network Firewall now allows creation of dual stack endpoints, enabling inspection of IPv6 traffic.
* Core 3.7.103.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.461.1 (2023-01-17 15:00 UTC)
* DynamoDBv2 (3.7.101.25)
	* Fix DynamoDB attribute mapping crash due to empty map and FromDocument crash when document contains nulls

### 3.7.461.0 (2023-01-13 19:28 UTC)
* Connect (3.7.112.0)
	* This release updates the responses of UpdateContactFlowContent, UpdateContactFlowMetadata, UpdateContactFlowName and DeleteContactFlow API with empty responses.
* EC2 (3.7.115.0)
	* Documentation updates for EC2.
* Outposts (3.7.101.0)
	* This release adds POWER_30_KVA as an option for PowerDrawKva. PowerDrawKva is part of the RackPhysicalProperties structure in the CreateSite request.
* ResourceGroups (3.7.101.0)
	* AWS Resource Groups customers can now turn on Group Lifecycle Events in their AWS account. When you turn this on, Resource Groups monitors your groups for changes to group state or membership. Those changes are sent to Amazon EventBridge as events that you can respond to using rules you create.
* Core 3.7.103.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.460.0 (2023-01-12 19:24 UTC)
* CleanRooms (3.7.100.0)
	* Initial release of AWS Clean Rooms
* CloudWatchLogs (3.7.103.0)
	* Bug fix: logGroupName is now not a required field in GetLogEvents, FilterLogEvents, GetLogGroupFields, and DescribeLogStreams APIs as logGroupIdentifier can be provided instead
* Lambda (3.7.103.0)
	* Add support for MaximumConcurrency parameter for SQS event source. Customers can now limit the maximum concurrent invocations for their SQS Event Source Mapping.
* MediaConvert (3.7.103.0)
	* The AWS Elemental MediaConvert SDK has added support for compact DASH manifest generation, audio normalization using TruePeak measurements, and the ability to clip the sample range in the color corrector.
* SecretsManager (3.7.101.8)
	* Update documentation for new ListSecrets and DescribeSecret parameters
* Core 3.7.103.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.459.0 (2023-01-11 19:17 UTC)
* Kendra (3.7.102.0)
	* This release adds support to new document types - RTF, XML, XSLT, MS_EXCEL, CSV, JSON, MD

### 3.7.458.0 (2023-01-10 19:19 UTC)
* LocationService (3.7.101.0)
	* This release adds support for two new route travel models, Bicycle and Motorcycle which can be used with Grab data source.
* RDS (3.7.114.0)
	* This release adds support for configuring allocated storage on the CreateDBInstanceReadReplica, RestoreDBInstanceFromDBSnapshot, and RestoreDBInstanceToPointInTime APIs.
* Core 3.7.103.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.457.0 (2023-01-09 19:54 UTC)
* ECRPublic (3.7.101.0)
	* This release for Amazon ECR Public makes several change to bring the SDK into sync with the API.
* KendraRanking (3.7.100.0)
	* Introducing Amazon Kendra Intelligent Ranking, a new set of Kendra APIs that leverages Kendra semantic ranking capabilities to improve the quality of search results from other search services (i.e. OpenSearch, ElasticSearch, Solr).
* NetworkFirewall (3.7.102.0)
	* Network Firewall now supports the Suricata rule action reject, in addition to the actions pass, drop, and alert.
* RAM (3.7.101.0)
	* Enabled FIPS aws-us-gov endpoints in SDK.
* WorkSpacesWeb (3.7.101.0)
	* This release adds support for a new portal authentication type: AWS IAM Identity Center (successor to AWS Single Sign-On).
* Core 3.7.103.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.456.0 (2023-01-06 19:20 UTC)
* ACMPCA (3.7.102.0)
	* Added revocation parameter validation: bucket names must match S3 bucket naming rules and CNAMEs conform to RFC2396 restrictions on the use of special characters in URIs.
* AuditManager (3.7.102.0)
	* This release introduces a new data retention option in your Audit Manager settings. You can now use the DeregistrationPolicy parameter to specify if you want to delete your data when you deregister Audit Manager.
* Core 3.7.103.12
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.455.0 (2023-01-05 19:23 UTC)
* AmplifyBackend (3.7.101.0)
	* Updated GetBackendAPIModels response to include ModelIntrospectionSchema json string
* AppRunner (3.7.103.0)
	* This release adds support of securely referencing secrets and configuration data that are stored in Secrets Manager and SSM Parameter Store by adding them as environment secrets in your App Runner service.
* Connect (3.7.111.0)
	* Documentation update for a new Initiation Method value in DescribeContact API
* EMRServerless (3.7.102.0)
	* Adds support for customized images. You can now provide runtime images when creating or updating EMR Serverless Applications.
* Lightsail (3.7.101.38)
	* Documentation updates for Amazon Lightsail.
* MWAA (3.7.100.49)
	* MWAA supports Apache Airflow version 2.4.3.
* RDS (3.7.113.0)
	* This release adds support for specifying which certificate authority (CA) to use for a DB instance's server certificate during DB instance creation, as well as other CA enhancements.
* Core 3.7.103.11
	* All services packages updated to require new Core

### 3.7.454.0 (2023-01-04 19:21 UTC)
* ApplicationAutoScaling (3.7.101.0)
	* Customers can now use the existing DescribeScalingActivities API to also see the detailed and machine-readable reasons for Application Auto Scaling not scaling their resources and, if needed, take the necessary corrective actions.
* CloudWatchLogs (3.7.102.27)
	* Update to remove sequenceToken as a required field in PutLogEvents calls.
* SimpleSystemsManagement (3.7.103.0)
	* Adding support for QuickSetup Document Type in Systems Manager

### 3.7.453.1 (2023-01-04 00:34 UTC)
* Core 3.7.103.10
	* Fix profile resolution when using AWS SSO by updating credentials factory to consider sso-session if present.
	* All services packages updated to require new Core

### 3.7.453.0 (2023-01-03 19:20 UTC)
* SecurityLake (3.7.101.0)
	* Allow CreateSubscriber API to take string input that allows setting more descriptive SubscriberDescription field. Make souceTypes field required in model level for UpdateSubscriberRequest as it is required for every API call on the backend. Allow ListSubscribers take any String as nextToken param.
* Core 3.7.103.9
	* Updating endpoints.json file.
	* All services packages updated to require new Core

