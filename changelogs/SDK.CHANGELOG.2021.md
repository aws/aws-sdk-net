### 3.7.181.0 (2021-12-21 23:34 UTC)
* APIGateway (3.7.2.56)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* ApiGatewayManagementApi (3.7.0.110)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* AppConfig (3.7.1.9)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* CloudSearchDomain (3.7.0.111)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* CodeGuruProfiler (3.7.0.110)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* DataExchange (3.7.3.0)
	* This release enables providers and subscribers to use Data Set, Job, and Asset operations to work with API assets from Amazon API Gateway. In addition, this release enables subscribers to use the SendApiAsset operation to invoke a provider's Amazon API Gateway API that they are entitled to.
* EBS (3.7.0.111)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* Glacier (3.7.0.110)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* IotData (3.7.1.56)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* Lambda (3.7.8.7)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* Lex (3.7.1.104)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* LexRuntimeV2 (3.7.3.8)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* LookoutforVision (3.7.1.4)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* MediaStoreData (3.7.0.110)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* Mobile (3.7.0.110)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.
* SageMakerRuntime (3.7.2.5)
	* Adjusted rest-json content-type handling where operations are intended to take arbitrary input.

### 3.7.180.0 (2021-12-21 19:18 UTC)
* ChimeSDKMessaging (3.7.3.0)
	* The Amazon Chime SDK now supports updating message attributes via channel flows
* Imagebuilder (3.7.5.1)
	* Added a note to infrastructure configuration actions and data types concerning delivery of Image Builder event messages to encrypted SNS topics. The key that's used to encrypt the SNS topic must reside in the account that Image Builder runs under.
* LookoutMetrics (3.7.5.0)
	* This release adds support for Causal Relationships. Added new ListAnomalyGroupRelatedMetrics API operation and InterMetricImpactDetails API data type
* MediaConnect (3.7.4.0)
	* You can now use the Fujitsu-QoS protocol for your MediaConnect sources and outputs to transport content to and from Fujitsu devices.
* NimbleStudio (3.7.3.0)
	* Amazon Nimble Studio adds support for users to upload files during a streaming session using NICE DCV native client or browser.
* QLDB (3.7.3.0)
	* Amazon QLDB now supports journal exports in JSON and Ion Binary formats. This release adds an optional OutputFormat parameter to the ExportJournalToS3 API.
* Transfer (3.7.5.0)
	* Property for Transfer Family used with the FTPS protocol. TLS Session Resumption provides a mechanism to resume or share a negotiated secret key between the control and data connection for an FTPS session.
* WorkMail (3.7.5.0)
	* This release allows customers to change their email monitoring configuration in Amazon WorkMail.
* Core 3.7.5.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.179.0 (2021-12-20 19:23 UTC)
* APIGateway (3.7.2.54)
	* Documentation updates for Amazon API Gateway
* CustomerProfiles (3.7.5.0)
	* This release adds an optional parameter, ObjectTypeNames to the PutIntegration API to support multiple object types per integration option. Besides, this release introduces Standard Order Objects which contain data from third party systems and each order object belongs to a specific profile.
* DataSync (3.7.4.0)
	* AWS DataSync now supports FSx Lustre Locations.
* DevOpsGuru (3.7.7.0)
	* Adds Tags support to DescribeOrganizationResourceCollectionHealth
* FinSpaceData (3.7.2.0)
	* Make dataset description optional and allow s3 export for dataviews
* ForecastService (3.7.7.0)
	* Adds ForecastDimensions field to the DescribeAutoPredictorResponse
* Imagebuilder (3.7.5.0)
	* This release adds support for importing and exporting VM Images as part of the Image Creation workflow via EC2 VM Import/Export.
* LocationService (3.7.7.0)
	* Making PricingPlan optional as part of create resource API.
* Redshift (3.7.11.0)
	* This release adds API support for managed Redshift datashares. Customers can now interact with a Redshift datashare that is managed by a different service, such as AWS Data Exchange.
* SageMaker (3.7.24.0)
	* This release adds a new ContentType field in AutoMLChannel for SageMaker CreateAutoMLJob InputDataConfig.
* SecurityHub (3.7.8.0)
	* Added new resource details objects to ASFF, including resources for Firewall, and RuleGroup, FirewallPolicy Added additional details for AutoScalingGroup, LaunchConfiguration, and S3 buckets.
* Core 3.7.5.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.178.1 (2021-12-13 20:14 UTC)
* SecretsManager (3.7.1.60)
	* Documentation updates for Secrets Manager
* Core 3.7.5.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.178.0 (2021-12-09 19:21 UTC)
* EC2 (3.7.50.0)
	* Adds waiters support for internet gateways.
* LexModelsV2 (3.7.10.0)
	* Added support for grammar slot type in Amazon Lex. You can author your own grammar in the XML format per the SRGS specification to collect information in a conversation.
* NetworkFirewall (3.7.2.0)
	* This release adds support for managed rule groups.
* Route53Domains (3.7.1.0)
	* Amazon Route 53 domain registration APIs now support filtering and sorting in the ListDomains API, deleting a domain by using the DeleteDomain API and getting domain pricing information by using the ListPrices API.
* Route53RecoveryControlConfig (3.7.1.0)
	* This release adds tagging supports to Route53 Recovery Control Configuration. New APIs: TagResource, UntagResource and ListTagsForResource. Updates: add optional field `tags` to support tagging while calling CreateCluster, CreateControlPanel and CreateSafetyRule.
* SavingsPlans (3.7.2.61)
	* Adds the ability to specify Savings Plans hourly commitments using five digits after the decimal point.
* ServerMigrationService (3.7.0.107)
	* This release adds SMS discontinuation information to the API and CLI references.

### 3.7.177.0 (2021-12-08 19:32 UTC)
* AWSHealth (3.7.1.63)
	* Documentation updates for AWS Health
* AWSSupport (3.7.0.107)
	* Documentation updates for AWS Support.
* CloudWatchLogs (3.7.2.0)
	* This release adds AWS Organizations support as condition key in destination policy for cross account Subscriptions in CloudWatch Logs.
* ComprehendMedical (3.7.2.0)
	* This release adds a new set of APIs (synchronous and batch) to support the SNOMED-CT ontology.
* IoT (3.7.9.0)
	* This release allows customer to enable caching of custom authorizer on HTTP protocol for clients that use persistent or Keep-Alive connection in order to reduce the number of Lambda invocations.
* LookoutforVision (3.7.1.0)
	* This release adds new APIs for packaging an Amazon Lookout for Vision model as an AWS IoT Greengrass component.
* Outposts (3.7.6.0)
	* This release adds the UpdateOutpost API.
* SageMaker (3.7.23.0)
	* This release added a new Ambarella device(amba_cv2) compilation support for Sagemaker Neo.
* Core 3.7.5.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.176.0 (2021-12-06 19:13 UTC)
* AppSync (3.7.3.0)
	* AWS AppSync now supports custom domain names, allowing you to associate a domain name that you own with an AppSync API in your account.
* LocationService (3.7.6.0)
	* This release adds support for Accuracy position filtering, position metadata and autocomplete for addresses and points of interest based on partial or misspelled free-form text.
* Route53 (3.7.2.0)
	* Add PriorRequestNotComplete exception to UpdateHostedZoneComment API

### 3.7.175.0 (2021-12-03 19:12 UTC)
* Rekognition (3.7.6.0)
	* This release added new KnownGender types for Celebrity Recognition.

### 3.7.174.0 (2021-12-02 19:12 UTC)
* AmplifyUIBuilder (3.7.0.0)
	* This release introduces the actions and data types for the new Amplify UI Builder API. The Amplify UI Builder API provides a programmatic interface for creating and configuring user interface (UI) component libraries and themes for use in Amplify applications.
* NetworkManager (3.7.2.0)
	* This release adds API support for AWS Cloud WAN.
* RAM (3.7.2.0)
	* This release adds the ability to use the new ResourceRegionScope parameter on List operations that return lists of resources or resource types. This new parameter filters the results by letting you differentiate between global or regional resource types.

### 3.7.173.0 (2021-12-02 00:09 UTC)
* DevOpsGuru (3.7.6.0)
	* DevOps Guru now provides detailed, database-specific analyses of performance issues and recommends corrective actions for Amazon Aurora database instances with Performance Insights turned on. You can also use AWS tags to choose which resources to analyze and define your applications.
* DirectConnect (3.7.4.0)
	* Adds SiteLink support to private and transit virtual interfaces. SiteLink is a new Direct Connect feature that allows routing between Direct Connect points of presence.
* DynamoDBv2 (3.7.2.0)
	* Add support for Table Classes and introduce the Standard Infrequent Access table class.
* EC2 (3.7.49.0)
	* This release adds support for Amazon VPC IP Address Manager (IPAM), which enables you to plan, track, and monitor IP addresses for your workloads. This release also adds support for VPC Network Access Analyzer, which enables you to analyze network access to resources in your Virtual Private Clouds.
* Kendra (3.7.11.0)
	* Experience Builder allows customers to build search applications without writing code. Analytics Dashboard provides quality and usability metrics for Kendra indexes. Custom Document Enrichment allows customers to build a custom ingestion pipeline to pre-process documents and generate metadata.
* LexModelsV2 (3.7.9.0)
	* This release introduces a new feature, Automated Chatbot Designer, that helps customers automatically create a bot design from existing conversation transcripts. The feature uses machine learning to discover most common intents and the information needed to fulfill them.
* SageMaker (3.7.22.0)
	* This release enables - 1/ Inference endpoint configuration recommendations and ability to run custom load tests to meet performance needs. 2/ Deploy serverless inference endpoints. 3/ Query, filter and retrieve end-to-end ML lineage graph, and incorporate model quality/bias detection in ML workflow.
* SageMakerRuntime (3.7.2.0)
	* Adding new exception types for InvokeEndpoint
* Shield (3.7.2.0)
	* This release adds API support for Automatic Application Layer DDoS Mitigation for AWS Shield Advanced. Customers can now enable automatic DDoS mitigation in count or block mode for layer 7 protected resources.
* Core 3.7.5.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.172.0 (2021-12-01 00:53 UTC)
* AccessAnalyzer (3.7.2.0)
	* AWS IAM Access Analyzer now supports policy validation for resource policies attached to S3 buckets and access points. You can run additional policy checks by specifying the S3 resource type you want to attach to your resource policy.
* BackupGateway (3.7.0.0)
	* Initial release of AWS Backup gateway which enables you to centralize and automate protection of on-premises VMware and VMware Cloud on AWS workloads using AWS Backup.
* EC2 (3.7.48.0)
	* This release adds support for Is4gen and Im4gn instances. This release also adds a new subnet attribute, enableLniAtDeviceIndex, to support local network interfaces, which are logical networking components that connect an EC2 instance to your on-premises network.
* FSx (3.7.6.0)
	* This release adds support for the FSx for OpenZFS file system type, FSx for Lustre file systems with the Persistent_2 deployment type, and FSx for Lustre file systems with Amazon S3 data repository associations and automatic export policies.
* Glue (3.7.10.0)
	* Support for DataLake transactions
* IoT (3.7.8.0)
	* Added the ability to enable/disable IoT Fleet Indexing for Device Defender and Named Shadow information, and search them through IoT Fleet Indexing APIs.
* IoTTwinMaker (3.7.0.0)
	* AWS IoT TwinMaker makes it faster and easier to create, visualize and monitor digital twins of real-world systems like buildings, factories and industrial equipment to optimize operations. Learn more: https://docs.aws.amazon.com/iot-twinmaker/latest/apireference/Welcome.html (New Service) (Preview)
* Kafka (3.7.5.0)
	* This release adds three new V2 APIs. CreateClusterV2 for creating both provisioned and serverless clusters. DescribeClusterV2 for getting information about provisioned and serverless clusters and ListClustersV2 for listing all clusters (both provisioned and serverless) in your account.
* Kinesis (3.7.1.0)
	* Amazon Kinesis Data Streams now supports on demand streams.
* LakeFormation (3.7.2.0)
	* This release adds support for row and cell-based access control in Lake Formation. It also adds support for Lake Formation Governed Tables, which support ACID transactions and automatic storage optimizations.
* Outposts (3.7.5.0)
	* This release adds the SupportedHardwareType parameter to CreateOutpost.
* RedshiftDataAPIService (3.7.5.0)
	* Data API now supports serverless queries.
* S3 (3.7.7.0)
	* Introduce Amazon S3 Glacier Instant Retrieval storage class and a new setting in S3 Object Ownership to disable ACLs for bucket and the objects in it.
* Snowball (3.7.3.0)
	* Tapeball is to integrate tape gateway onto snowball, it enables customer to transfer local data on the tape to snowball,and then ingest the data into tape gateway on the cloud.
* StorageGateway (3.7.4.0)
	* Added gateway type VTL_SNOW. Added new SNOWBALL HostEnvironment for gateways running on a Snowball device. Added new field HostEnvironmentId to serve as an identifier for the HostEnvironment on which the gateway is running.
* WorkSpacesWeb (3.7.0.0)
	* This is the initial SDK release for Amazon WorkSpaces Web. Amazon WorkSpaces Web is a low-cost, fully managed WorkSpace built to deliver secure web-based workloads and software-as-a-service (SaaS) application access to users within existing web browsers.
* Core 3.7.5.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.171.0 (2021-11-30 01:05 UTC)
* CloudWatchEvidently (3.7.0.0)
	* Introducing Amazon CloudWatch Evidently. This is the first public release of Amazon CloudWatch Evidently.
* CloudWatchRUM (3.7.0.0)
	* This is the first public release of CloudWatch RUM
* ComputeOptimizer (3.7.4.0)
	* Adds support for the enhanced infrastructure metrics paid feature. Also adds support for two new sets of resource efficiency metrics, including savings opportunity metrics and performance improvement opportunity metrics.
* EC2 (3.7.47.0)
	* This release adds support for G5g and M6a instances. This release also adds support for Amazon EBS Snapshots Archive, a feature that enables you to archive your EBS snapshots; and Recycle Bin, a feature that enables you to protect your EBS snapshots against accidental deletion.
* ECR (3.7.2.0)
	* This release adds supports for pull through cache rules and enhanced scanning.
* Inspector2 (3.7.0.0)
	* This release adds support for the new Amazon Inspector API. The new Amazon Inspector can automatically discover and scan Amazon EC2 instances and Amazon ECR container images for software vulnerabilities and unintended network exposure, and report centralized findings across multiple AWS accounts.
* IoTSiteWise (3.7.9.0)
	* AWS IoT SiteWise now supports retention configuration for the hot tier storage.
* RecycleBin (3.7.0.0)
	* This release adds support for Recycle Bin.
* S3 (3.7.6.0)
	* Amazon S3 Event Notifications adds Amazon EventBridge as a destination and supports additional event types. The PutBucketNotificationConfiguration API can now skip validation of Amazon SQS, Amazon SNS and AWS Lambda destinations.
* SimpleSystemsManagement (3.7.11.0)
	* Added two new attributes to DescribeInstanceInformation called SourceId and SourceType along with new string filters SourceIds and SourceTypes to filter instance records.
* WellArchitected (3.7.2.0)
	* This update provides support for Well-Architected API users to use custom lens features.

### 3.7.170.0 (2021-11-29 07:13 UTC)
* MigrationHubRefactorSpaces (3.7.0.0)
	* This is the initial SDK release for AWS Migration Hub Refactor Spaces
* Personalize (3.7.6.0)
	* This release adds API support for Recommenders and BatchSegmentJobs.
* PersonalizeRuntime (3.7.1.0)
	* This release adds inference support for Recommenders.
* Textract (3.7.3.0)
	* This release adds support for synchronously analyzing identity documents through a new API: AnalyzeID

### 3.7.169.0 (2021-11-26 19:19 UTC)
* AutoScaling (3.7.8.1)
	* Documentation updates for Amazon EC2 Auto Scaling.
* EC2 (3.7.46.0)
	* Documentation updates for EC2.
* IoTDeviceAdvisor (3.7.2.1)
	* Documentation update for Device Advisor GetEndpoint API
* Mgn (3.7.2.0)
	* Application Migration Service now supports an additional replication method that does not require agent installation on each source server. This option is available for source servers running on VMware vCenter versions 6.7 and 7.0.
* Outposts (3.7.4.0)
	* This release adds new APIs for working with Outpost sites and orders.
* Pinpoint (3.7.4.0)
	* Added a One-Time Password (OTP) management feature. You can use the Amazon Pinpoint API to generate OTP codes and send them to your users as SMS messages. Your apps can then call the API to verify the OTP codes that your users input

### 3.7.168.1 (2021-11-24 23:51 UTC)
* DevOpsGuru (3.7.5.4)
	* Update generator to add in a missing paginator
* SimpleWorkflow (3.7.0.104)
	* Update generator to add in a missing paginator

### 3.7.168.0 (2021-11-24 19:17 UTC)
* AutoScaling (3.7.8.0)
	* Customers can now configure predictive scaling policies to proactively scale EC2 Auto Scaling groups based on any CloudWatch metrics that more accurately represent the load on the group than the four predefined metrics. They can also use math expressions to further customize the metrics.
* CustomerProfiles (3.7.4.0)
	* This release introduces a new auto-merging feature for profile matching. The auto-merging configurations can be set via CreateDomain API or UpdateDomain API. You can use GetIdentityResolutionJob API and ListIdentityResolutionJobs API to fetch job status.
* ElastiCache (3.7.4.1)
	* Doc only update for ElastiCache
* Imagebuilder (3.7.4.0)
	* This release adds support for sharing AMIs with Organizations within an EC2 Image Builder Distribution Configuration.
* IoTSiteWise (3.7.8.0)
	* AWS IoT SiteWise now accepts data streams that aren't associated with any asset properties. You can organize data by updating data stream associations.
* Lambda (3.7.8.0)
	* Remove Lambda function url apis
* Proton (3.7.2.0)
	* This release adds APIs for getting the outputs and provisioned stacks for Environments, Pipelines, and ServiceInstances.  You can now add tags to EnvironmentAccountConnections.  It also adds APIs for working with PR-based provisioning.  Also, it adds APIs for syncing templates with a git repository.
* TimestreamQuery (3.7.1.0)
	* Releasing Amazon Timestream Scheduled Queries. It makes real-time analytics more performant and cost-effective for customers by calculating and storing frequently accessed aggregates, and other computations, typically used in operational dashboards, business reports, and other analytics applications
* TimestreamWrite (3.7.1.0)
	* This release adds support for multi-measure records and magnetic store writes. Multi-measure records allow customers to store multiple measures in a single table row. Magnetic store writes enable customers to write late arrival data (data with timestamp in the past) directly into the magnetic store.
* Translate (3.7.3.0)
	* This release enables customers to use translation settings to mask profane words and phrases in their translation output.

### 3.7.167.0 (2021-11-23 20:46 UTC)
* Backup (3.7.5.0)
	* This release adds new opt-in settings for advanced features for DynamoDB backups
* DynamoDBv2 (3.7.1.0)
	* DynamoDB PartiQL now supports ReturnConsumedCapacity, which returns capacity units consumed by PartiQL APIs if the request specified returnConsumedCapacity parameter. PartiQL APIs include ExecuteStatement, BatchExecuteStatement, and ExecuteTransaction.
* EC2 (3.7.45.0)
	* This release adds a new parameter ipv6Native to the allow creation of IPv6-only subnets using the CreateSubnet operation, and the operation ModifySubnetAttribute includes new parameters to modify subnet attributes to use resource-based naming and enable DNS resolutions for Private DNS name.
* ECS (3.7.4.10)
	* Documentation update for ARM support on Amazon ECS.
* ElastiCache (3.7.4.0)
	* Adding support for r6gd instances for Redis with data tiering. In a cluster with data tiering enabled, when available memory capacity is exhausted, the least recently used data is automatically tiered to solid state drives for cost-effective capacity scaling with minimal performance impact.
* ElasticLoadBalancingV2 (3.7.3.22)
	* This release allows you to create internal Application and Network Load Balancers in dualstack mode. This release also adds an attribute to block internet gateway (IGW) access to the load balancer, preventing unintended access to your internal load balancers through an internet gateway.
* FinSpaceData (3.7.1.1)
	* Update documentation for createChangeset API.
* IoT (3.7.7.0)
	* This release introduces a new feature, Managed Job Template, for AWS IoT Jobs Service. Customers can now use service provided managed job templates to easily create jobs for supported standard job actions.
* IoTDeviceAdvisor (3.7.2.0)
	* This release introduces a new feature for Device Advisor: ability to execute multiple test suites in parallel for given customer account. You can use GetEndpoint API to get the device-level test endpoint and call StartSuiteRun with "parallelRun=true" to run suites in parallel.
* IoTWireless (3.7.8.0)
	* Two new APIs, GetNetworkAnalyzerConfiguration and UpdateNetworkAnalyzerConfiguration, are added for the newly released Network Analyzer feature which enables customers to view real-time frame information and logs from LoRaWAN devices and gateways.
* Lambda (3.7.7.0)
	* Release Lambda event source filtering for SQS, Kinesis Streams, and DynamoDB Streams.
* Macie2 (3.7.6.13)
	* Documentation updates for Amazon Macie
* OpenSearchService (3.7.2.0)
	* This release adds an optional parameter dry-run for the UpdateDomainConfig API to perform basic validation checks, and detect the deployment type that will be required for the configuration change, without actually applying the change.
* RDS (3.7.8.0)
	* Adds support for Multi-AZ DB clusters for RDS for MySQL and RDS for PostgreSQL.
* Redshift (3.7.10.0)
	* This release adds support for reserved node exchange with restore/resize
* S3 (3.7.5.0)
	* Introduce two new Filters to S3 Lifecycle configurations - ObjectSizeGreaterThan and ObjectSizeLessThan. Introduce a new way to trigger actions on noncurrent versions by providing the number of newer noncurrent versions along with noncurrent days.
* SecurityToken (3.7.1.94)
	* Documentation updates for AWS Security Token Service.
* SQS (3.7.2.0)
	* Amazon SQS adds a new queue attribute, SqsManagedSseEnabled, which enables server-side queue encryption using SQS owned encryption keys.
* WorkSpaces (3.7.2.30)
	* Documentation updates for Amazon WorkSpaces

### 3.7.166.0 (2021-11-22 19:25 UTC)
* Braket (3.7.2.0)
	* This release adds support for Amazon Braket Hybrid Jobs.
* ChimeSDKMeetings (3.7.3.0)
	* Added new APIs for enabling Echo Reduction with Voice Focus.
* CloudFormation (3.7.7.0)
	* This release include SDK changes for the feature launch of Stack Import to Service Managed StackSet.
* Connect (3.7.10.0)
	* This release adds support for UpdateContactFlowMetadata, DeleteContactFlow and module APIs. For details, see the Release Notes in the Amazon Connect Administrator Guide.
* DatabaseMigrationService (3.7.6.0)
	* Added new S3 endpoint settings to allow to convert the current UTC time into a specified time zone when a date partition folder is created. Using with 'DatePartitionedEnabled'.
* EKS (3.7.11.0)
	* Adding missing exceptions to RegisterCluster operation
* Elasticsearch (3.7.3.0)
	* This release adds an optional parameter dry-run for the UpdateElasticsearchDomainConfig API to perform basic validation checks, and detect the deployment type that will be required for the configuration change, without actually applying the change.
* FinSpaceData (3.7.1.0)
	* Add new APIs for managing Datasets, Changesets, and Dataviews.
* QuickSight (3.7.9.0)
	* Add support for Exasol data source, 1 click enterprise embedding and email customization.
* RDS (3.7.7.0)
	* Adds local backup support to Amazon RDS on AWS Outposts.
* S3Control (3.7.4.0)
	* Added Amazon CloudWatch publishing option for S3 Storage Lens metrics.
* SimpleSystemsManagement (3.7.10.0)
	* Adds new parameter to CreateActivation API . This parameter is for "internal use only".
* Core 3.7.5.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.165.1 (2021-11-20 01:30 UTC)
* Core 3.7.5.1
	* test!: make DefaultFilePath settable to allow mocking. BREAKING CHANGE: this is binary change and can break customers on drop-in replacing AWSSDK.Core

### 3.7.165.0 (2021-11-19 19:24 UTC)
* ApplicationInsights (3.7.2.0)
	* Application Insights now supports monitoring for HANA
* AppStream (3.7.3.0)
	* Includes APIs for managing resources for Elastic fleets: applications, app blocks, and application-fleet associations.
* Batch (3.7.3.9)
	* Documentation updates for AWS Batch.
* CloudFormation (3.7.6.0)
	* The StackSets ManagedExecution feature will allow concurrency for non-conflicting StackSet operations and queuing the StackSet operations that conflict at a given time for later execution.
* Lambda (3.7.6.0)
	* Add support for Lambda Function URLs. Customers can use Function URLs to create built-in HTTPS endpoints on their functions.
* LexRuntimeV2 (3.7.3.0)
	* Now supports styled slots in Lex V2 runtime. Customers can provide inputs like "a as in apple b for beta" which will be resolved to "ab" as slot value.
* MediaLive (3.7.7.0)
	* This release adds support for specifying a SCTE-35 PID on input. MediaLive now supports SCTE-35 PID selection on inputs containing one or more active SCTE-35 PIDs.
* Redshift (3.7.9.0)
	* Added support of default IAM role for CreateCluster, RestoreFromClusterSnapshot and ModifyClusterIamRoles APIs

### 3.7.164.0 (2021-11-19 01:14 UTC)
* Core 3.7.5.0
	* Enable FIPS endpoint variants and enable FIPS support in S3 Control for Outposts
	* All services packages updated to require new Core

### 3.7.163.0 (2021-11-18 21:21 UTC)
* AppConfig (3.7.1.0)
	* Add Type to support feature flag configuration profiles
* AuditManager (3.7.7.0)
	* This release introduces a new feature for Audit Manager: Dashboard views. You can now view insights data for your active assessments, and quickly identify non-compliant evidence that needs to be remediated.
* Chime (3.7.14.0)
	* Adds new Transcribe API parameters to StartMeetingTranscription, including support for content identification and redaction (PII & PHI), partial results stabilization, and custom language models.
* ChimeSDKMeetings (3.7.2.0)
	* Adds new Transcribe API parameters to StartMeetingTranscription, including support for content identification and redaction (PII & PHI), partial results stabilization, and custom language models.
* CloudWatch (3.7.3.0)
	* CloudWatch Anomaly Detection now supports anomaly detectors that use metric math as input.
* ForecastService (3.7.6.0)
	* NEW CreateExplanability API that helps you understand how attributes such as price, promotion, etc. contributes to your forecasted values; NEW CreateAutoPredictor API that trains up to 40% more accurate forecasting model, saves up to 50% of retraining time, and provides model level explainability.
* GlueDataBrew (3.7.5.0)
	* This SDK release adds the following new features: 1) PII detection in profile jobs, 2) Data quality rules, enabling validation of data quality in profile jobs, 3) SQL query-based datasets for Amazon Redshift and Snowflake data sources, and 4) Connecting DataBrew datasets with Amazon AppFlow flows.
* IVS (3.7.3.0)
	* Add APIs for retrieving stream session information and support for filtering live streams by health.  For more information, see https://docs.aws.amazon.com/ivs/latest/userguide/stream-health.html
* Kafka (3.7.4.0)
	* Amazon MSK has added a new API that allows you to update the connectivity settings for an existing cluster to enable public accessibility.
* Lambda (3.7.5.0)
	* Added support for CLIENT_CERTIFICATE_TLS_AUTH and SERVER_ROOT_CA_CERTIFICATE as SourceAccessType for MSK and Kafka event source mappings.
* LexModelsV2 (3.7.8.0)
	* Added support for Polly Neural TTS (NTTS) voices. Customers can choose between 'standard' and 'neural' for Polly Engine configuration per locale when creating or updating an Amazon Lex bot.
* RedshiftDataAPIService (3.7.4.0)
	* Rolling back Data API serverless features until dependencies are live.
* Core 3.7.4.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.162.0 (2021-11-17 19:18 UTC)
* AmplifyBackend (3.7.4.0)
	* New APIs to support the Amplify Storage category. Add and manage file storage in your Amplify app backend.
* APIGateway (3.7.2.46)
	* Documentation updates for Amazon API Gateway.
* AppConfigData (3.7.0.0)
	* AWS AppConfig Data is a new service that allows you to retrieve configuration deployed by AWS AppConfig. See the AppConfig user guide for more details on getting started. https://docs.aws.amazon.com/appconfig/latest/userguide/what-is-appconfig.html
* DevOpsGuru (3.7.5.0)
	* Add paginator for DescribeResourceCollectionHealth
* Drs (3.7.0.0)
	* Introducing AWS Elastic Disaster Recovery (AWS DRS), a new service that minimizes downtime and data loss with fast, reliable recovery of on-premises and cloud-based applications using affordable storage, minimal compute, and point-in-time recovery.
* RedshiftDataAPIService (3.7.3.0)
	* Data API now supports serverless requests.
* SimpleNotificationService (3.7.3.0)
	* Amazon SNS introduces the PublishBatch API, which enables customers to publish up to 10 messages per API request. The new API is valid for Standard and FIFO topics.
* Core 3.7.4.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.161.0 (2021-11-16 19:21 UTC)
* CloudTrail (3.7.1.0)
	* CloudTrail Insights now supports ApiErrorRateInsight, which enables customers to identify unusual activity in their AWS account based on API error codes and their rate.
* LocationService (3.7.5.0)
	* This release adds the support for Relevance, Distance, Time Zone, Language and Interpolated Address for Geocoding and Reverse Geocoding.
* Core 3.7.4.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.160.0 (2021-11-15 20:35 UTC)
* AppStream (3.7.2.0)
	* This release includes support for images of AmazonLinux2 platform type.
* DatabaseMigrationService (3.7.5.0)
	* Add Settings in JSON format for the source GCP MySQL endpoint
* EC2 (3.7.44.0)
	* Adds a new VPC Subnet attribute "EnableDns64." When enabled on IPv6 Subnets, the Amazon-Provided DNS Resolver returns synthetic IPv6 addresses for IPv4-only destinations.
* EKS (3.7.10.0)
	* Adding Tags support to Cluster Registrations.
* MigrationHubStrategyRecommendations (3.7.0.0)
	* AWS SDK for Migration Hub Strategy Recommendations. It includes APIs to start the portfolio assessment, import portfolio data for assessment, and to retrieve recommendations. For more information, see the AWS Migration Hub documentation at https://docs.aws.amazon.com/migrationhub/index.html
* SimpleSystemsManagement (3.7.9.0)
	* Adds support for Session Reason and Max Session Duration for Systems Manager Session Manager.
* Transfer (3.7.4.0)
	* AWS Transfer Family now supports integrating a custom identity provider using AWS Lambda
* WAFV2 (3.7.8.0)
	* Your options for logging web ACL traffic now include Amazon CloudWatch Logs log groups and Amazon S3 buckets.
* Core 3.7.4.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.159.0 (2021-11-12 19:16 UTC)
* Connect (3.7.9.0)
	* This release adds APIs for creating and managing scheduled tasks. Additionally, adds APIs to describe and update a contact and list associated references.
* DevOpsGuru (3.7.4.0)
	* Add support for cross account APIs.
* EC2 (3.7.43.0)
	* C6i instances are powered by a third-generation Intel Xeon Scalable processor (Ice Lake) delivering all-core turbo frequency of 3.5 GHz. G5 instances feature up to 8 NVIDIA A10G Tensor Core GPUs and second generation AMD EPYC processors.
* MediaConvert (3.7.10.0)
	* AWS Elemental MediaConvert SDK has added automatic modes for GOP configuration and added the ability to ingest screen recordings generated by Safari on MacOS 12 Monterey.
* SimpleSystemsManagement (3.7.8.0)
	* This Patch Manager release supports creating Patch Baselines for RaspberryPi OS (formerly Raspbian)
* Core 3.7.4.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.158.0 (2021-11-11 19:13 UTC)
* DynamoDBv2 (3.7.0.97)
	* Updated Help section for "dynamodb update-contributor-insights" API
* EC2 (3.7.42.0)
	* This release provides an additional route target for the VPC route table.
* Translate (3.7.2.0)
	* This release enables customers to import Multi-Directional Custom Terminology and use Multi-Directional Custom Terminology in both real-time translation and asynchronous batch translation.
* Core 3.7.4.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.157.0 (2021-11-10 23:05 UTC)
* Core 3.7.4.0
	* Add support for endpoint variants and new configuration options for choosing dualstack endpoints
	* All services packages updated to require new Core

### 3.7.156.0 (2021-11-10 19:12 UTC)
* Backup (3.7.4.0)
	* AWS Backup SDK provides new options when scheduling backups: select supported services and resources that are assigned to a particular tag, linked to a combination of tags, or can be identified by a partial tag value, and exclude resources from their assignments.
* ECS (3.7.4.0)
	* This release adds support for container instance health.
* ResilienceHub (3.7.0.0)
	* Initial release of AWS Resilience Hub, a managed service that enables you to define, validate, and track the resilience of your applications on AWS

### 3.7.155.0 (2021-11-09 19:26 UTC)
* AWSHealth (3.7.1.51)
	* Documentation updates for AWS Health.
* Batch (3.7.3.0)
	* Adds support for scheduling policy APIs.
* GreengrassV2 (3.7.3.0)
	* This release adds support for Greengrass core devices running Windows. You can now specify name of a Windows user to run a component.
* Core 3.7.3.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.154.0 (2021-11-08 19:14 UTC)
* ChimeSDKMeetings (3.7.1.0)
	* Updated format validation for ids and regions.
* EC2 (3.7.41.0)
	* This release adds internal validation on the GatewayAssociationState field
* SageMaker (3.7.21.0)
	* SageMaker CreateEndpoint and UpdateEndpoint APIs now support additional deployment configuration to manage traffic shifting options and automatic rollback monitoring. DescribeEndpoint now shows new in-progress deployment details with stage status.
* WAFV2 (3.7.7.0)
	* You can now configure rules to run a CAPTCHA check against web requests and, as needed, send a CAPTCHA challenge to the client.

### 3.7.153.0 (2021-11-05 18:16 UTC)
* EC2 (3.7.40.0)
	* DescribeInstances now returns customer-owned IP addresses for instances running on an AWS Outpost.
* ResourceGroupsTaggingAPI (3.7.0.94)
	* Documentation updates and improvements.
* Translate (3.7.1.0)
	* This release enable customers to use their own KMS keys to encrypt output files when they submit a batch transform job.

### 3.7.152.0 (2021-11-04 22:13 UTC)
* S3 (3.7.4.0)
	* Added ability to clear user defined metadata from S3 MetadataCollection. Added overloaded AmazonS3Uri constructor and TryParseAmazonS3Uri method with a flag to control URI string preprocessing to decode certain characters.
* Core 3.7.3.33
	* fix: conflict between ErrorResponse internal type and service type
	* All services packages updated to require new Core

### 3.7.151.0 (2021-11-04 18:38 UTC)
* ChimeSDKMeetings (3.7.0.0)
	* The Amazon Chime SDK Meetings APIs allow software developers to create meetings and attendees for interactive audio, video, screen and content sharing in custom meeting applications which use the Amazon Chime SDK.
* Connect (3.7.8.0)
	* This release adds CRUD operation support for Security profile resource in Amazon Connect
* EC2 (3.7.39.0)
	* This release adds a new instance replacement strategy for EC2 Fleet, Spot Fleet. Now you can select an action to perform when your instance gets a rebalance notification. EC2 Fleet, Spot Fleet can launch a replacement then terminate the instance that received notification after a termination delay
* IoTWireless (3.7.7.0)
	* Adding APIs for the FUOTA (firmware update over the air) and multicast for LoRaWAN devices and APIs to support event notification opt-in feature for Sidewalk related events. A few existing APIs need to be modified for this new feature.
* SageMaker (3.7.20.0)
	* ListDevices and DescribeDevice now show Edge Manager agent version.
* Core 3.7.3.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.150.0 (2021-11-03 18:15 UTC)
* ConnectParticipant (3.7.2.0)
	* This release adds a new boolean attribute - Connect Participant - to the CreateParticipantConnection API, which can be used to mark the participant as connected.
* DataSync (3.7.3.0)
	* AWS DataSync now supports Hadoop Distributed File System (HDFS) Locations
* Finspace (3.7.1.0)
	* Adds superuser and data-bundle parameters to CreateEnvironment API
* Macie2 (3.7.6.0)
	* This release adds support for specifying the severity of findings that a custom data identifier produces, based on the number of occurrences of text that matches the detection criteria.
* Core 3.7.3.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.149.0 (2021-11-02 18:29 UTC)
* CloudFront (3.7.4.0)
	* CloudFront now supports response headers policies to add HTTP headers to the responses that CloudFront sends to viewers. You can use these policies to add CORS headers, control browser caching, and more, without modifying your origin or writing any code.
* Connect (3.7.7.0)
	* Amazon Connect Chat now supports real-time message streaming.
* NimbleStudio (3.7.2.0)
	* Amazon Nimble Studio adds support for users to stop and start streaming sessions.
* Core 3.7.3.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.148.0 (2021-11-01 18:16 UTC)
* Lightsail (3.7.4.0)
	* This release adds support to enable access logging for buckets in the Lightsail object storage service.
* Neptune (3.7.2.0)
	* Adds support for major version upgrades to ModifyDbCluster API
* NetworkManager (3.7.1.0)
	* This release adds API support to aggregate resources, routes, and telemetry data across a Global Network.
* Rekognition (3.7.5.0)
	* This Amazon Rekognition Custom Labels release introduces the management of datasets with  projects
* Core 3.7.3.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.147.0 (2021-10-29 18:26 UTC)
* ApplicationInsights (3.7.1.0)
	* Added Monitoring support for SQL Server Failover Cluster Instance. Additionally, added a new API to allow one-click monitoring of containers resources.
* Connect (3.7.6.0)
	* Amazon Connect Chat now supports real-time message streaming.
* EC2 (3.7.38.0)
	* Support added for AMI sharing with organizations and organizational units in ModifyImageAttribute API
* Rekognition (3.7.4.0)
	* This release added new attributes to Rekognition Video GetCelebrityRecognition API operations.
* TranscribeService (3.7.9.0)
	* Transcribe and Transcribe Call Analytics now support automatic language identification along with custom vocabulary, vocabulary filter, custom language model and PII redaction.
* Core 3.7.3.28
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.146.0 (2021-10-28 18:20 UTC)
* ConnectParticipant (3.7.1.0)
	* This release adds a new boolean attribute - Connect Participant - to the CreateParticipantConnection API, which can be used to mark the participant as connected.
* EC2 (3.7.37.0)
	* Added new read-only DenyAllIGWTraffic network interface attribute. Added support for DL1 24xlarge instances powered by Habana Gaudi Accelerators for deep learning model training workloads
* ECS (3.7.3.0)
	* Amazon ECS now supports running Fargate tasks on Windows Operating Systems Families which includes Windows Server 2019 Core and Windows Server 2019 Full.
* GameLift (3.7.1.0)
	* Added support for Arm-based AWS Graviton2 instances, such as M6g, C6g, and R6g.
* SageMaker (3.7.19.0)
	* This release adds support for RStudio on SageMaker.
* SSMIncidents (3.7.2.0)
	* Updating documentation, adding new field to ConflictException to indicate earliest retry timestamp for some operations, increase maximum length of nextToken fields

### 3.7.145.0 (2021-10-27 18:17 UTC)
* AutoScaling (3.7.7.0)
	* This release adds support for attribute-based instance type selection, a new EC2 Auto Scaling feature that lets customers express their instance requirements as a set of attributes, such as vCPU, memory, and storage.
* EC2 (3.7.36.0)
	* This release adds: attribute-based instance type selection for EC2 Fleet, Spot Fleet, a feature that lets customers express instance requirements as attributes like vCPU, memory, and storage; and Spot placement score, a feature that helps customers identify an optimal location to run Spot workloads.
* EKS (3.7.9.0)
	* EKS managed node groups now support BOTTLEROCKET_x86_64 and BOTTLEROCKET_ARM_64 AMI types.
* SageMaker (3.7.18.0)
	* This release allows customers to describe one or more versioned model packages through BatchDescribeModelPackage, update project via UpdateProject, modify and read customer metadata properties using Create, Update and Describe ModelPackage and enables cross account registration of model packages.
* Textract (3.7.2.0)
	* This release adds support for asynchronously analyzing invoice and receipt documents through two new APIs: StartExpenseAnalysis and GetExpenseAnalysis
* Core 3.7.3.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.144.0 (2021-10-26 18:11 UTC)
* ChimeSDKIdentity (3.7.1.0)
	* The Amazon Chime SDK now supports push notifications through Amazon Pinpoint
* ChimeSDKMessaging (3.7.2.0)
	* The Amazon Chime SDK now supports push notifications through Amazon Pinpoint
* EMRContainers (3.7.2.0)
	* This feature enables auto-generation of certificate  to secure the managed-endpoint and removes the need for customer provided certificate-arn during managed-endpoint setup.

### 3.7.143.1 (2021-10-26 02:47 UTC)
* Core 3.7.3.26
	* Use correct region name for request signing for pseudoregions
	* All services packages updated to require new Core

### 3.7.143.0 (2021-10-25 23:03 UTC)
* AuditManager (3.7.6.0)
	* This release introduces a new feature for Audit Manager: Custom framework sharing. You can now share your custom frameworks with another AWS account, or replicate them into another AWS Region under your own account.
* EC2 (3.7.35.0)
	* This release adds support to create a VPN Connection that is not attached to a Gateway at the time of creation. Use this to create VPNs associated with Core Networks, or modify your VPN and attach a gateway using the modify API after creation.
* RDS (3.7.6.0)
	* This release adds support for Amazon RDS Custom, which is a new RDS management type that gives you full access to your database and operating system. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-custom.html
* Route53Resolver (3.7.2.0)
	* New API for ResolverConfig, which allows autodefined rules for reverse DNS resolution to be disabled for a VPC
* Core 3.7.3.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.142.0 (2021-10-22 18:12 UTC)
* AuditManager (3.7.5.0)
	* This release introduces character restrictions for ControlSet names. We updated regex patterns for the following attributes: ControlSet, CreateAssessmentFrameworkControlSet, and UpdateAssessmentFrameworkControlSet.
* Chime (3.7.13.0)
	* Chime VoiceConnector and VoiceConnectorGroup APIs will now return an ARN.
* QuickSight (3.7.8.0)
	* Added QSearchBar option for GenerateEmbedUrlForRegisteredUser ExperienceConfiguration to support Q search bar embedding

### 3.7.141.2 (2021-10-22 06:42 UTC)
* Core 3.7.3.24
	* Allow using SSO credentials in default chain if a cached access token exists. Fix issue with using assume role and SSO credentials profile.
	* All services packages updated to require new Core

### 3.7.141.1 (2021-10-21 18:31 UTC)
* Connect (3.7.5.11)
	* Released Amazon Connect hours of operation API for general availability (GA). This API also supports AWS CloudFormation. For more information, see Amazon Connect Resource Type Reference in the AWS CloudFormation User Guide.
* Core 3.7.3.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.141.0 (2021-10-20 18:16 UTC)
* Appflow (3.7.4.0)
	* Feature to add support for  JSON-L format for S3 as a source.
* DirectConnect (3.7.3.0)
	* This release adds 4 new APIS, which needs to be public able
* MediaConvert (3.7.9.0)
	* AWS Elemental MediaConvert SDK has added support for specifying caption time delta in milliseconds and the ability to apply color range legalization to source content other than AVC video.
* MediaPackage (3.7.4.0)
	* When enabled, MediaPackage passes through digital video broadcasting (DVB) subtitles into the output.
* MediaPackageVod (3.7.4.0)
	* MediaPackage passes through digital video broadcasting (DVB) subtitles into the output.
* Panorama (3.7.0.0)
	* General availability for AWS Panorama. AWS SDK for Panorama includes APIs to manage your devices and nodes, and deploy computer vision applications to the edge. For more information, see the AWS Panorama documentation at http://docs.aws.amazon.com/panorama
* SecurityHub (3.7.7.0)
	* Added support for cross-Region finding aggregation, which replicates findings from linked Regions to a single aggregation Region. Added operations to view, enable, update, and delete the finding aggregation.

### 3.7.140.0 (2021-10-19 18:13 UTC)
* ChimeSDKMessaging (3.7.1.0)
	* The Amazon Chime SDK now allows developers to execute business logic on in-flight messages before they are delivered to members of a messaging channel with channel flows.
* DataExchange (3.7.2.0)
	* This release adds support for our public preview of AWS Data Exchange for Amazon Redshift. This enables data providers to list products including AWS Data Exchange datashares for Amazon Redshift, giving subscribers read-only access to provider data in Amazon Redshift.

### 3.7.139.0 (2021-10-18 18:13 UTC)
* IVS (3.7.2.0)
	* Bug fix: remove unsupported maxResults and nextToken pagination parameters from ListTagsForResource
* QuickSight (3.7.7.0)
	* AWS QuickSight Service  Features    - Add IP Restriction UI and public APIs support.

### 3.7.138.0 (2021-10-15 20:21 UTC)
* ElasticFileSystem (3.7.3.8)
	* EFS adds documentation for a new exception for short identifiers to be thrown after its migration to long resource identifiers.
* Glue (3.7.9.0)
	* Enable S3 event base crawler API.

### 3.7.137.0 (2021-10-14 20:23 UTC)
* AutoScaling (3.7.6.0)
	* Amazon EC2 Auto Scaling now supports filtering describe Auto Scaling groups API using tags
* ElasticLoadBalancingV2 (3.7.3.0)
	* Adds new option to filter by availability on each type of load balancer when describing ssl policies.
* RoboMaker (3.7.5.0)
	* Adding support to GPU simulation jobs as well as non-ROS simulation jobs.
* SageMaker (3.7.17.0)
	* This release updates the provisioning artifact ID to an optional parameter in CreateProject API. The provisioning artifact ID defaults to the latest provisioning artifact ID of the product if you don't provide one.
* Core 3.7.3.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.136.0 (2021-10-13 18:16 UTC)
* ConfigService (3.7.5.0)
	* Adding Config support for AWS::OpenSearch::Domain
* EC2 (3.7.34.0)
	* This release adds support for additional VPC Flow Logs delivery options to S3, such as Apache Parquet formatted files, Hourly partitions and Hive-compatible S3 prefixes
* KinesisAnalyticsV2 (3.7.5.0)
	* Support for Apache Flink 1.13 in Kinesis Data Analytics. Changed the required status of some Update properties to better fit the corresponding Create properties.
* StorageGateway (3.7.3.0)
	* Adding support for Audit Logs on NFS shares and Force Closing Files on SMB shares.
* WorkMail (3.7.4.0)
	* This release adds APIs for adding, removing and retrieving details of mail domains
* Core 3.7.3.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.135.0 (2021-10-12 18:13 UTC)
* CloudSearch (3.7.2.0)
	* Adds an additional validation exception for Amazon CloudSearch configuration APIs for better error handling.
* EC2 (3.7.33.0)
	* EncryptionSupport for InstanceStorageInfo added to DescribeInstanceTypes API
* ECS (3.7.2.56)
	* Documentation only update to address tickets.
* MediaTailor (3.7.6.0)
	* MediaTailor now supports ad prefetching.
* Core 3.7.3.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.134.0 (2021-10-11 18:13 UTC)
* EC2 (3.7.32.1)
	* Documentation update for Amazon EC2.
* ElasticLoadBalancingV2 (3.7.2.0)
	* Enable support for ALB IPv6 Target Groups (IP Address Type)
* FraudDetector (3.7.5.0)
	* New model type: Transaction Fraud Insights, which is optimized for online transaction fraud. Stored Events, which allows customers to send and store data directly within Amazon Fraud Detector. Batch Import, which allows customers to upload a CSV file of historic event data for processing and storage
* MediaLive (3.7.6.0)
	* This release adds support for Transport Stream files as an input type to MediaLive encoders.

### 3.7.133.0 (2021-10-08 18:28 UTC)
* EC2 (3.7.32.0)
	* This release removes a requirement for filters on SearchLocalGatewayRoutes operations.
* LexModelsV2 (3.7.7.0)
	* Added configuration support for an Amazon Lex bot to provide fulfillment progress updates to users while their requests are being processed. See documentation for more details: https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html
* LexRuntimeV2 (3.7.2.0)
	* Added configuration support for an Amazon Lex bot to provide fulfillment progress updates to users while their requests are being processed. See documentation for more details: https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html
* MediaConvert (3.7.8.0)
	* AWS Elemental MediaConvert has added the ability to set account policies which control access restrictions for HTTP, HTTPS, and S3 content sources.
* SecretsManager (3.7.1.32)
	* Documentation updates for Secrets Manager
* SecurityHub (3.7.6.0)
	* Added new resource details objects to ASFF, including resources for WAF rate-based rules, EC2 VPC endpoints, ECR repositories, EKS clusters, X-Ray encryption, and OpenSearch domains. Added additional details for CloudFront distributions, CodeBuild projects, ELB V2 load balancers, and S3 buckets.
* Core 3.7.3.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.132.0 (2021-10-07 18:17 UTC)
* Backup (3.7.3.0)
	* Launch of AWS Backup Vault Lock, which protects your backups from malicious and accidental actions, works with existing backup policies, and helps you meet compliance requirements.
* Chime (3.7.12.0)
	* This release enables customers to configure Chime MediaCapturePipeline via API.
* Kendra (3.7.10.0)
	* Amazon Kendra now supports indexing and querying documents in different languages.
* KinesisFirehose (3.7.2.0)
	* Allow support for Amazon Opensearch Service(successor to Amazon Elasticsearch Service) as a Kinesis Data Firehose delivery destination.
* ManagedGrafana (3.7.0.0)
	* Initial release of the SDK for Amazon Managed Grafana API.
* Schemas (3.7.2.0)
	* Removing unused request/response objects.
* Core 3.7.3.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.131.1 (2021-10-06 23:58 UTC)
* Core 3.7.3.17
	* Add support for S3 Outpost Presigner
	* All services packages updated to require new Core

### 3.7.131.0 (2021-10-06 18:24 UTC)
* AmplifyBackend (3.7.3.0)
	* Adding a new field 'AmplifyFeatureFlags' to the response of the GetBackend operation. It will return a stringified version of the cli.json file for the given Amplify project.
* FSx (3.7.5.0)
	* This release adds support for Lustre 2.12 to FSx for Lustre.
* Kendra (3.7.9.0)
	* Amazon Kendra now supports integration with AWS SSO
* SageMaker (3.7.16.0)
	* This release adds a new TrainingInputMode FastFile for SageMaker Training APIs.
* Core 3.7.3.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.130.0 (2021-10-05 18:15 UTC)
* ApplicationAutoScaling (3.7.2.0)
	* With this release, Application Auto Scaling adds support for Amazon Neptune. Customers can now automatically add or remove Read Replicas of their Neptune clusters to keep the average CPU Utilization at the target value specified by the customers.
* Backup (3.7.2.0)
	* AWS Backup Audit Manager framework report.
* EC2 (3.7.31.0)
	* Released Capacity Reservation Fleet, a feature of Amazon EC2 Capacity Reservations, which provides a way to manage reserved capacity across instance types. For more information: https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cr-fleets.html
* Glue (3.7.8.0)
	* This release adds tag as an input of CreateConnection
* LocationService (3.7.4.0)
	* Add support for PositionFiltering.
* WorkMail (3.7.3.0)
	* This release allows customers to change their inbound DMARC settings in Amazon WorkMail.

### 3.7.129.0 (2021-10-04 18:13 UTC)
* CodeBuild (3.7.7.0)
	* CodeBuild now allows you to select how batch build statuses are sent to the source provider for a project.
* ElasticFileSystem (3.7.3.0)
	* EFS adds a new exception for short identifiers to be thrown after its migration to long resource identifiers.
* KeyManagementService (3.7.2.20)
	* Added SDK examples for ConnectCustomKeyStore, CreateCustomKeyStore, CreateKey, DeleteCustomKeyStore, DescribeCustomKeyStores, DisconnectCustomKeyStore, GenerateDataKeyPair, GenerateDataKeyPairWithoutPlaintext, GetPublicKey, ReplicateKey, Sign, UpdateCustomKeyStore and Verify APIs

### 3.7.128.0 (2021-10-01 18:21 UTC)
* AppRunner (3.7.1.0)
	* This release contains several minor bug fixes.
* SimpleSystemsManagement (3.7.7.0)
	* When "AutoApprovable" is true for a Change Template, then specifying --auto-approve (boolean) in Start-Change-Request-Execution will create a change request that bypasses approver review. (except for change calendar restrictions)
* Synthetics (3.7.2.0)
	* CloudWatch Synthetics now enables customers to choose a customer managed AWS KMS key or an Amazon S3-managed key instead of an AWS managed key (default) for the encryption of artifacts that the canary stores in Amazon S3. CloudWatch Synthetics also supports artifact S3 location updation now.
* Core 3.7.3.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.127.0 (2021-09-30 18:17 UTC)
* Account (3.7.0.0)
	* This release of the Account Management API enables customers to manage the alternate contacts for their AWS accounts. For more information, see https://docs.aws.amazon.com/accounts/latest/reference/accounts-welcome.html
* CloudControlApi (3.7.0.0)
	* Initial release of the SDK for AWS Cloud Control API
* DataExchange (3.7.1.0)
	* This release enables subscribers to set up automatic exports of newly published revisions using the new EventAction API.
* Macie2 (3.7.5.0)
	* Amazon S3 bucket metadata now indicates whether an error or a bucket's permissions settings prevented Amazon Macie from retrieving data about the bucket or the bucket's objects.
* NetworkFirewall (3.7.1.0)
	* This release adds support for strict ordering for stateful rule groups. Using strict ordering, stateful rules are evaluated in the exact order in which you provide them.
* WorkMail (3.7.2.0)
	* This release adds support for mobile device access overrides management in Amazon WorkMail.
* WorkSpaces (3.7.2.0)
	* Added CreateUpdatedWorkspaceImage API to update WorkSpace images with latest software and drivers. Updated DescribeWorkspaceImages API to display if there are updates available for WorkSpace images.
* Core 3.7.3.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.126.0 (2021-09-29 18:15 UTC)
* Lambda (3.7.4.0)
	* Adds support for Lambda functions powered by AWS Graviton2 processors. Customers can now select the CPU architecture for their functions.
* PrometheusService (3.7.2.0)
	* This release adds alert manager and rule group namespace APIs
* SimpleEmailV2 (3.7.1.0)
	* This release includes the ability to use 2048 bits RSA key pairs for DKIM in SES, either with Easy DKIM or Bring Your Own DKIM.
* Core 3.7.3.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.125.1 (2021-09-28 18:14 UTC)
* Imagebuilder (3.7.3.4)
	* Fix description for AmiDistributionConfiguration Name property, which actually refers to the output AMI name. Also updated for consistent terminology to use "base" image, and another update to fix description text.
* Transfer (3.7.3.14)
	* Added changes for managed workflows feature APIs.

### 3.7.125.0 (2021-09-27 20:32 UTC)
* AppIntegrationsService (3.7.1.0)
	* The Amazon AppIntegrations service enables you to configure and reuse connections to external applications.
* Connect (3.7.5.0)
	* This release updates a set of APIs: CreateIntegrationAssociation, ListIntegrationAssociations, CreateUseCase, and StartOutboundVoiceContact. You can use it to create integrations with Amazon Pinpoint for the Amazon Connect Campaigns use case, Amazon Connect Voice ID, and Amazon Connect Wisdom.
* ConnectWisdomService (3.7.0.0)
	* Released Amazon Connect Wisdom, a feature of Amazon Connect, which provides real-time recommendations and search functionality in general availability (GA).  For more information, see https://docs.aws.amazon.com/wisdom/latest/APIReference/Welcome.html.
* ElasticLoadBalancingV2 (3.7.1.0)
	* Adds new ALB-type target group to facilitate forwarding traffic from NLB to ALB
* Pinpoint (3.7.3.0)
	* Added support for journey with contact center activity
* VoiceID (3.7.0.0)
	* Released the Amazon Voice ID SDK, for usage with the Amazon Connect Voice ID feature released for Amazon Connect.
* Core 3.7.3.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.124.0 (2021-09-24 18:23 UTC)
* EC2 (3.7.30.0)
	* DescribeInstances now returns Platform Details, Usage Operation, and Usage Operation Update Time.
* LicenseManager (3.7.5.0)
	* AWS License Manager now allows customers to get the LicenseArn in the Checkout API Response.
* Core 3.7.3.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.123.0 (2021-09-23 18:15 UTC)
* AppSync (3.7.2.0)
	* Documented the new OpenSearchServiceDataSourceConfig data type. Added deprecation notes to the ElasticsearchDataSourceConfig data type.
* MediaConvert (3.7.7.0)
	* This release adds style and positioning support for caption or subtitle burn-in from rich text sources such as TTML. This release also introduces configurable image-based trick play track generation.
* SimpleSystemsManagement (3.7.6.0)
	* Added cutoff behavior support for preventing new task invocations from starting when the maintenance window cutoff time is reached.
* Core 3.7.3.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.122.0 (2021-09-22 18:15 UTC)
* IdentityManagement (3.7.2.49)
	* Added changes to OIDC API about not using port numbers in the URL.
* Imagebuilder (3.7.3.0)
	* This feature adds support for specifying GP3 volume throughput and configuring instance metadata options for instances launched by EC2 Image Builder.
* LexModelsV2 (3.7.6.0)
	* This release adds support for utterances statistics for bots built using Lex V2 console and APIs. For details, see: https://docs.aws.amazon.com/lexv2/latest/dg/monitoring-utterances.html
* LicenseManager (3.7.4.0)
	* AWS License Manager now allows customers to change their Windows Server or SQL license types from Bring-Your-Own-License (BYOL) to License Included or vice-versa (using the customer's media).
* MediaPackageVod (3.7.3.0)
	* MediaPackage VOD will now return the current processing statuses of an asset's endpoints. The status can be QUEUED, PROCESSING, PLAYABLE, or FAILED.
* MediaTailor (3.7.5.0)
	* This release adds support to configure logs for playback configuration.
* WAFV2 (3.7.6.0)
	* Added the regex match rule statement, for matching web requests against a single regular expression.
* Core 3.7.3.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.121.0 (2021-09-21 18:13 UTC)
* Comprehend (3.7.4.0)
	* Amazon Comprehend now supports versioning of custom models, improved training with ONE_DOC_PER_FILE text documents for custom entity recognition, ability to provide specific test sets during training, and live migration to new model endpoints.
* EC2 (3.7.29.0)
	* This update adds support for downloading configuration templates using new APIs (GetVpnConnectionDeviceTypes and GetVpnConnectionDeviceSampleConfiguration) and Internet Key Exchange version 2 (IKEv2) parameters for many popular CGW devices.
* ECR (3.7.1.0)
	* This release adds additional support for repository replication
* IoT (3.7.6.0)
	* This release adds support for verifying, viewing and filtering AWS IoT Device Defender detect violations with four verification states.
* Kafka (3.7.3.0)
	* Added StateInfo to ClusterInfo

### 3.7.120.0 (2021-09-17 18:14 UTC)
* DatabaseMigrationService (3.7.4.0)
	* Optional flag force-planned-failover added to reboot-replication-instance API call. This flag can be used to test a planned failover scenario used during some maintenance operations.
* Elasticsearch (3.7.2.0)
	* This release adds an optional parameter in the ListDomainNames API to filter domains based on the engine type (OpenSearch/Elasticsearch).
* OpenSearchService (3.7.1.0)
	* This release adds an optional parameter in the ListDomainNames API to filter domains based on the engine type (OpenSearch/Elasticsearch).
* Core 3.7.3.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.119.0 (2021-09-16 18:18 UTC)
* KafkaConnect (3.7.0.0)
	* This is the initial SDK release for Amazon Managed Streaming for Apache Kafka Connect (MSK Connect).
* Macie2 (3.7.4.0)
	* This release adds support for specifying which managed data identifiers are used by a classification job, and retrieving a list of managed data identifiers that are available.
* Pinpoint (3.7.2.0)
	* This SDK release adds a new feature for Pinpoint campaigns, in-app messaging.
* RoboMaker (3.7.4.0)
	* Adding support to create container based Robot and Simulation applications by introducing an environment field
* S3 (3.7.3.0)
	* Add support for access point arn filtering in S3 CW Request Metrics
* SageMaker (3.7.15.0)
	* Add API for users to retry a failed pipeline execution or resume a stopped one.
* TranscribeService (3.7.8.0)
	* This release adds support for subtitling with Amazon Transcribe batch jobs.
* Core 3.7.3.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.118.1 (2021-09-15 23:15 UTC)
* S3 (3.7.2.6)
	* Updated to use new Core, version 3.7.3.6
	* Fixed an issue where AWS-managed prefix lists were not working with Arn class due to Account ID validation.
* S3Control (3.7.3.7)
	* Updated to use new Core, version 3.7.3.6
	* Fixed an issue where AWS-managed prefix lists were not working with Arn class due to Account ID validation.
* Core 3.7.3.6
	* Fixed an issue where AWS-managed prefix lists were not working with Arn class due to Account ID validation; Fixes an issue where System.TimeoutException is not retried when using .NET 5.
	* All services packages updated to require new Core

### 3.7.118.0 (2021-09-14 20:56 UTC)
* Chime (3.7.11.0)
	* Adds support for SipHeaders parameter for CreateSipMediaApplicationCall.
* Comprehend (3.7.3.0)
	* Amazon Comprehend now allows you to train and run PDF and Word documents for custom entity recognition. With PDF and Word formats, you can extract information from documents containing headers, lists and tables.
* EC2 (3.7.28.0)
	* This release adds support for vt1 3xlarge, 6xlarge and 24xlarge instances powered by Xilinx Alveo U30 Media Accelerators for video transcoding workloads
* SageMaker (3.7.14.0)
	* This release adds support for "Project Search"
* WAFV2 (3.7.5.0)
	* This release adds support for including rate based rules in a rule group.

### 3.7.117.0 (2021-09-13 18:15 UTC)
* EC2 (3.7.27.7)
	* Adds support for T3 instances on Amazon EC2 Dedicated Hosts.
* IoT (3.7.5.0)
	* AWS IoT Rules Engine adds OpenSearch action. The OpenSearch rule action lets you stream data from IoT sensors and applications to Amazon OpenSearch Service which is a successor to Amazon Elasticsearch Service.
* Core 3.7.3.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.116.0 (2021-09-10 18:22 UTC)
* CloudFormation (3.7.5.8)
	* Doc only update for CloudFormation that fixes several customer-reported issues.
* ECR (3.7.0.64)
	* This release updates terminology around KMS keys.
* QuickSight (3.7.6.0)
	* Add new data source type for Amazon OpenSearch (successor to Amazon ElasticSearch).
* RDS (3.7.5.0)
	* This release adds support for providing a custom timeout value for finding a scaling point during autoscaling in Aurora Serverless v1.
* SageMaker (3.7.13.0)
	* This release adds support for "Lifecycle Configurations" to SageMaker Studio
* TranscribeService (3.7.7.0)
	* This release adds an API option for startTranscriptionJob and startMedicalTranscriptionJob that allows the user to specify encryption context key value pairs for batch jobs.
* Core 3.7.3.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.115.0 (2021-09-09 18:26 UTC)
* CodeGuruReviewer (3.7.4.0)
	* The Amazon CodeGuru Reviewer API now includes the RuleMetadata data object and a Severity attribute on a RecommendationSummary object. A RuleMetadata object contains information about a rule that generates a recommendation. Severity indicates how severe the issue associated with a recommendation is.
* ElasticMapReduce (3.7.4.0)
	* This release enables customers to login to EMR Studio using AWS Identity and Access Management (IAM) identities or identities in their Identity Provider (IdP) via IAM.
* LookoutEquipment (3.7.1.0)
	* Added OffCondition parameter to CreateModel API
* Core 3.7.3.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.114.0 (2021-09-08 18:13 UTC)
* Kafka (3.7.2.0)
	* Amazon MSK has added a new API that allows you to update the encrypting and authentication settings for an existing cluster.
* OpenSearchService (3.7.0.0)
	* Updated Configuration APIs for Amazon OpenSearch Service (successor to Amazon Elasticsearch Service)
* RAM (3.7.1.34)
	* A minor text-only update that fixes several customer issues.

### 3.7.113.0 (2021-09-07 18:33 UTC)
* EKS (3.7.8.0)
	* Adding RegisterCluster and DeregisterCluster operations, to support connecting external clusters to EKS.
* ElastiCache (3.7.3.11)
	* Doc only update for ElastiCache
* ForecastService (3.7.5.0)
	* Predictor creation now supports selecting an accuracy metric to optimize in AutoML and hyperparameter optimization. This release adds additional accuracy metrics for predictors - AverageWeightedQuantileLoss, MAPE and MASE.
* MediaPackage (3.7.3.0)
	* SPEKE v2 support for live CMAF packaging type. SPEKE v2 is an upgrade to the existing SPEKE API to support multiple encryption keys, it supports live DASH currently.
* PrometheusService (3.7.1.0)
	* This release adds tagging support for Amazon Managed Service for Prometheus workspace.
* SSMContacts (3.7.2.15)
	* Added SDK examples for SSM-Contacts.
* XRay (3.7.0.62)
	* Updated references to AWS KMS keys and customer managed keys to reflect current terminology.
* Core 3.7.3.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.112.0 (2021-09-03 18:12 UTC)
* ChimeSDKIdentity (3.7.0.12)
	* Documentation updates for Chime
* ChimeSDKMessaging (3.7.0.12)
	* Documentation updates for Chime
* CodeGuruReviewer (3.7.3.0)
	* Added support for CodeInconsistencies detectors
* FraudDetector (3.7.4.0)
	* Enhanced GetEventPrediction API response to include risk scores from imported SageMaker models
* Outposts (3.7.3.0)
	* This release adds a new API CreateOrder.
* Core 3.7.3.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.111.0 (2021-09-03 03:46 UTC)
* RDS (3.7.4.12)
	* Updated to use new Core, version 3.7.3.0
	* Update request signing due to SigV4a addition in Core
* S3 (3.7.2.0)
	* Updated to use new Core, version 3.7.3.0
	* Add Asymmetric Signature V4 (SigV4a) signing via AWS Common Runtime, and S3 Multi-Region Access Points.
* S3Control (3.7.3.1)
	* Updated to use new Core, version 3.7.3.0
	* Update request signing due to SigV4a addition in Core
* Core 3.7.3.0
	* Add Asymmetric Signature V4 (SigV4a) signing via AWS Common Runtime, and S3 Multi-Region Access Points.
	* All services packages updated to require new Core

### 3.7.110.0 (2021-09-02 18:33 UTC)
* AccessAnalyzer (3.7.1.51)
	* Updates service API, documentation, and paginators to support multi-region access points from Amazon S3.
* ACMPCA (3.7.3.0)
	* Private Certificate Authority Service now allows customers to enable an online certificate status protocol (OCSP) responder service on their private certificate authorities. Customers can also optionally configure a custom CNAME for their OCSP responder.
* EBS (3.7.0.60)
	* Documentation updates for Amazon EBS direct APIs.
* ElasticFileSystem (3.7.2.0)
	* Adds support for EFS Intelligent-Tiering, which uses EFS Lifecycle Management to monitor file access patterns and is designed to automatically transition files to and from your corresponding Infrequent Access (IA) storage classes.
* FSx (3.7.4.0)
	* Announcing Amazon FSx for NetApp ONTAP, a new service that provides fully managed shared storage in the AWS Cloud with the data access and management capabilities of ONTAP.
* LexModelBuildingService (3.7.4.0)
	* Lex now supports Korean (ko-KR) locale.
* QuickSight (3.7.5.0)
	* This release adds support for referencing parent datasets as sources in a child dataset.
* S3Control (3.7.3.0)
	* S3 Multi-Region Access Points provide a single global endpoint to access a data set that spans multiple S3 buckets in different AWS Regions.
* Schemas (3.7.1.0)
	* This update include the support for Schema Discoverer to discover the events sent to the bus from another account. The feature will be enabled by default when discoverer is created or updated but can also be opt-in or opt-out  by specifying the value for crossAccount.
* SecurityHub (3.7.5.0)
	* New ASFF Resources: AwsAutoScalingLaunchConfiguration, AwsEc2VpnConnection, AwsEcrContainerImage. Added KeyRotationStatus to AwsKmsKey. Added AccessControlList, BucketLoggingConfiguration,BucketNotificationConfiguration and BucketNotificationConfiguration to AwsS3Bucket.
* Transfer (3.7.3.0)
	* AWS Transfer Family introduces Managed Workflows for creating, executing, monitoring, and standardizing post file transfer processing
* Core 3.7.2.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.109.0 (2021-09-01 18:19 UTC)
* AppRegistry (3.7.1.0)
	* Introduction of GetAssociatedResource API and GetApplication response extension for Resource Groups support.
* CloudTrail (3.7.0.59)
	* Documentation updates for CloudTrail
* ConfigService (3.7.4.6)
	* Documentation updates for config
* EC2 (3.7.27.0)
	* Added LaunchTemplate support for the IMDS IPv6 endpoint
* MediaTailor (3.7.4.0)
	* This release adds support for wall clock programs in LINEAR channels.
* Core 3.7.2.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.108.0 (2021-08-31 18:16 UTC)
* ComputeOptimizer (3.7.3.2)
	* Documentation updates for Compute Optimizer
* IoT (3.7.4.0)
	* Added Create/Update/Delete/Describe/List APIs for a new IoT resource named FleetMetric. Added a new Fleet Indexing query API named GetBucketsAggregation. Added a new field named DisconnectedReason in Fleet Indexing query response. Updated their related documentations.
* MemoryDB (3.7.0.4)
	* Documentation updates for MemoryDB
* Polly (3.7.3.0)
	* Amazon Polly adds new South African English voice - Ayanda. Ayanda is available as Neural voice only.
* SQS (3.7.1.0)
	* Amazon SQS adds a new queue attribute, RedriveAllowPolicy, which includes the dead-letter queue redrive permission parameters. It defines which source queues can specify dead-letter queues as a JSON object.
* Core 3.7.2.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.107.0 (2021-08-30 18:40 UTC)
* CloudFormation (3.7.5.0)
	* AWS CloudFormation allows you to iteratively develop your applications when failures are encountered without rolling back successfully provisioned resources. By specifying stack failure options, you can troubleshoot resources in a CREATE_FAILED or UPDATE_FAILED status.
* CodeBuild (3.7.6.5)
	* Documentation updates for CodeBuild
* KeyManagementService (3.7.2.0)
	* This release has changes to KMS nomenclature to remove the word master from both the "Customer master key" and "CMK" abbreviation and replace those naming conventions with "KMS key".
* KinesisFirehose (3.7.1.0)
	* This release adds the Dynamic Partitioning feature to Kinesis Data Firehose service for S3 destinations.

### 3.7.106.0 (2021-08-27 20:30 UTC)
* EC2 (3.7.26.0)
	* This release adds the BootMode flag to the ImportImage API and showing the detected BootMode of an ImportImage task.
* ElasticMapReduce (3.7.3.0)
	* Amazon EMR now supports auto-terminating idle EMR clusters. You can specify the idle timeout value when enabling auto-termination for both running and new clusters and Amazon EMR automatically terminates the cluster when idle timeout kicks in.
* S3 (3.7.1.28)
	* Documentation updates for Amazon S3.
* Core 3.7.2.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.105.0 (2021-08-26 21:56 UTC)
* ComputeOptimizer (3.7.3.0)
	* Adds support for 1) the AWS Graviton (AWS_ARM64) recommendation preference for Amazon EC2 instance and Auto Scaling group recommendations, and 2) the ability to get the enrollment statuses for all member accounts of an organization.
* EC2 (3.7.25.0)
	* Support added for resizing VPC prefix lists
* Rekognition (3.7.3.0)
	* This release added new attributes to Rekognition RecognizeCelebities and GetCelebrityInfo API operations.
* TranscribeService (3.7.6.0)
	* This release adds support for batch transcription in six new languages - Afrikaans, Danish, Mandarin Chinese (Taiwan), New Zealand English, South African English, and Thai.

### 3.7.104.0 (2021-08-25 18:15 UTC)
* CloudWatchEvents (3.7.4.0)
	* AWS CWEvents adds an enum of EXTERNAL for EcsParameters LaunchType for PutTargets API
* DataSync (3.7.2.0)
	* Added include filters to CreateTask and UpdateTask, and added exclude filters to StartTaskExecution, giving customers more granular control over how DataSync transfers files, folders, and objects.
* EC2 (3.7.24.0)
	* Support added for IMDS IPv6 endpoint
* EventBridge (3.7.4.0)
	* AWS EventBridge adds an enum of EXTERNAL for EcsParameters LaunchType for PutTargets API
* FMS (3.7.3.0)
	* AWS Firewall Manager now supports triggering resource cleanup workflow when account or resource goes out of policy scope for AWS WAF, Security group, AWS Network Firewall, and Amazon Route 53 Resolver DNS Firewall policies.
* Core 3.7.2.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.103.0 (2021-08-24 18:18 UTC)
* IotData (3.7.1.0)
	* Updated Publish with support for new Retain flag and added two new API operations: GetRetainedMessage, ListRetainedMessages.
* MediaConvert (3.7.6.0)
	* AWS Elemental MediaConvert SDK has added MBAFF encoding support for AVC video and the ability to pass encryption context from the job settings to S3.
* Polly (3.7.2.0)
	* Amazon Polly adds new New Zealand English voice - Aria. Aria is available as Neural voice only.
* SimpleSystemsManagement (3.7.5.0)
	* Updated Parameter Store property for logging improvements.
* TranscribeService (3.7.5.0)
	* This release adds support for feature tagging with Amazon Transcribe batch jobs.

### 3.7.102.0 (2021-08-23 18:19 UTC)
* APIGateway (3.7.2.0)
	* Adding some of the pending releases (1) Adding WAF Filter to GatewayResponseType enum (2) Ensuring consistent error model for all operations (3) Add missing BRE to GetVpcLink operation
* Backup (3.7.1.0)
	* AWS Backup - Features: Evaluate your backup activity and generate audit reports.
* DatabaseMigrationService (3.7.3.0)
	* Amazon AWS DMS service now support Redis target endpoint migration. Now S3 endpoint setting is capable to setup features which are used to be configurable only in extract connection attributes.
* DLM (3.7.1.0)
	* Added AMI deprecation support for Amazon Data Lifecycle Manager EBS-backed AMI policies.
* FraudDetector (3.7.3.0)
	* Updated an element of the DescribeModelVersion API response (LogitMetrics -> logOddsMetrics) for clarity. Added new exceptions to several APIs to protect against unlikely scenarios.
* Glue (3.7.7.0)
	* Add support for Custom Blueprints
* IoTSiteWise (3.7.7.2)
	* Documentation updates for AWS IoT SiteWise
* Core 3.7.2.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.101.0 (2021-08-20 18:41 UTC)
* Comprehend (3.7.2.0)
	* Add tagging support for Comprehend async inference job.
* EC2 (3.7.23.0)
	* encryptionInTransitSupported added to DescribeInstanceTypes API
* EKS (3.7.7.0)
	* Adds support for EKS add-ons "preserve" flag, which allows customers to maintain software on their EKS clusters after removing it from EKS add-ons management.
* RoboMaker (3.7.3.11)
	* Documentation updates for RoboMaker

### 3.7.100.0 (2021-08-19 18:13 UTC)
* Appflow (3.7.3.0)
	* This release adds support for SAPOData connector and extends Veeva connector for document extraction.
* ApplicationAutoScaling (3.7.1.0)
	* This release extends Application Auto Scaling support for replication group of Amazon ElastiCache Redis clusters. Auto Scaling monitors and automatically expands node group count and number of replicas per node group when a critical usage threshold is met or according to customer-defined schedule.
* EC2 (3.7.22.0)
	* The ImportImage API now supports the ability to create AMIs with AWS-managed licenses for Microsoft SQL Server for both Windows and Linux.
* MemoryDB (3.7.0.0)
	* AWS MemoryDB  SDK now supports all APIs for newly launched MemoryDB service.
* Core 3.7.2.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.99.0 (2021-08-18 19:21 UTC)
* CodeBuild (3.7.6.0)
	* CodeBuild now allows you to make the build results for your build projects available to the public without requiring access to an AWS account.
* Route53 (3.7.1.9)
	* Documentation updates for route53
* Route53Resolver (3.7.1.48)
	* Documentation updates for Route 53 Resolver
* SageMaker (3.7.12.0)
	* Amazon SageMaker now supports Asynchronous Inference endpoints. Adds PlatformIdentifier field that allows Notebook Instance creation with different platform selections. Increases the maximum number of containers in multi-container endpoints to 15. Adds more instance types to InstanceType field.
* SageMakerRuntime (3.7.1.0)
	* Amazon SageMaker Runtime now supports InvokeEndpointAsync to asynchronously invoke endpoints that were created with the AsyncInferenceConfig object in the EndpointConfig. Asynchronous invocations support larger payload sizes in Amazon S3 and longer processing times.

### 3.7.98.0 (2021-08-17 19:18 UTC)
* Cloud9 (3.7.2.0)
	* Added DryRun parameter to CreateEnvironmentEC2 API. Added ManagedCredentialsActions parameter to UpdateEnvironment API
* CloudDirectory (3.7.0.53)
	* Documentation updates for clouddirectory
* CloudWatchLogs (3.7.1.27)
	* Documentation-only update for CloudWatch Logs
* CostExplorer (3.7.3.0)
	* This release is a new feature for Cost Categories: Split charge rules. Split charge rules enable you to allocate shared costs between your cost category values.
* EC2 (3.7.21.0)
	* This release adds support for EC2 ED25519 key pairs for authentication

### 3.7.97.0 (2021-08-16 18:14 UTC)
* CodeBuild (3.7.5.0)
	* CodeBuild now allows you to select how batch build statuses are sent to the source provider for a project.
* ConfigService (3.7.4.0)
	* Update ResourceType enum with values for Backup Plan, Selection, Vault, RecoveryPoint; ECS Cluster, Service, TaskDefinition; EFS AccessPoint, FileSystem; EKS Cluster; ECR Repository resources
* DirectoryService (3.7.1.0)
	* This release adds support for describing client authentication settings.
* IoTSiteWise (3.7.7.0)
	* AWS IoT SiteWise added query window for the interpolation interval. AWS IoT SiteWise computes each interpolated value by using data points from the timestamp of each interval minus the window to the timestamp of each interval plus the window.
* LicenseManager (3.7.3.0)
	* AWS License Manager now allows end users to call CheckoutLicense API using new CheckoutType PERPETUAL. Perpetual checkouts allow sellers to check out a quantity of entitlements to be drawn down for consumption.
* S3 (3.7.1.24)
	* Documentation updates for Amazon S3
* Core 3.7.2.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.96.0 (2021-08-13 18:11 UTC)
* CustomerProfiles (3.7.3.0)
	* This release introduces Standard Profile Objects, namely Asset and Case which contain values populated by data from third party systems and belong to a specific profile. This release adds an optional parameter, ObjectFilter to the ListProfileObjects API in order to search for these Standard Objects.
* ElastiCache (3.7.3.0)
	* This release adds ReplicationGroupCreateTime field to ReplicationGroup which indicates the UTC time when ElastiCache ReplicationGroup is created
* ElasticMapReduce (3.7.2.0)
	* Amazon EMR customers can now specify custom AMIs at the instance level in their clusters. This allows using custom AMIs in clusters that have instances with different instruction set architectures, e.g. m5.xlarge (x86) and m6g.xlarge (ARM).
* QuickSight (3.7.4.7)
	* Documentation updates for QuickSight.

### 3.7.95.0 (2021-08-12 18:14 UTC)
* APIGateway (3.7.1.0)
	* Adding support for ACM imported or private CA certificates for mTLS enabled domain names
* ApiGatewayV2 (3.7.1.0)
	* Adding support for ACM imported or private CA certificates for mTLS enabled domain names
* GlueDataBrew (3.7.4.0)
	* This SDK release adds support for the output of a recipe job results to Tableau Hyper format.
* Lambda (3.7.3.0)
	* Lambda Python 3.9 runtime launch
* SageMaker (3.7.11.0)
	* Amazon SageMaker Autopilot adds new metrics for all candidate models generated by Autopilot experiments.
* Core 3.7.2.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.94.0 (2021-08-11 18:43 UTC)
* CodeBuild (3.7.4.0)
	* CodeBuild now allows you to make the build results for your build projects available to the public without requiring access to an AWS account.
* EBS (3.7.0.51)
	* Documentation updates for Amazon EBS direct APIs.
* ECS (3.7.2.26)
	* Documentation updates for ECS.
* NimbleStudio (3.7.1.0)
	* Add new attribute 'ownedBy' in Streaming Session APIs. 'ownedBy' represents the AWS SSO Identity Store User ID of the owner of the Streaming Session resource.
* Route53 (3.7.1.6)
	* Documentation updates for route53
* SnowDeviceManagement (3.7.0.0)
	* AWS Snow Family customers can remotely monitor and operate their connected AWS Snowcone devices.

### 3.7.93.0 (2021-08-10 18:14 UTC)
* Chime (3.7.10.0)
	* Add support for "auto" in Region field of StartMeetingTranscription API request.
* Core 3.7.2.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.92.0 (2021-08-09 18:27 UTC)
* Rekognition (3.7.2.0)
	* This release adds support for four new types of segments (opening credits, content segments, slates, and studio logos), improved accuracy for credits and shot detection and new filters to control black frame detection.
* SimpleSystemsManagement (3.7.4.8)
	* Documentation updates for AWS Systems Manager.
* WAFV2 (3.7.4.0)
	* This release adds APIs to support versioning feature of AWS WAF Managed rule groups

### 3.7.91.0 (2021-08-06 18:18 UTC)
* Athena (3.7.0.49)
	* Documentation updates for Athena.
* ChimeSDKIdentity (3.7.0.0)
	* The Amazon Chime SDK Identity APIs allow software developers to create and manage unique instances of their messaging applications.
* ChimeSDKMessaging (3.7.0.0)
	* The Amazon Chime SDK Messaging APIs allow software developers to send and receive messages in custom messaging applications.
* Connect (3.7.4.0)
	* This release adds support for agent status and hours of operation. For details, see the Release Notes in the Amazon Connect Administrator Guide.
* Lightsail (3.7.3.0)
	* This release adds support to track when a bucket access key was last used.
* Synthetics (3.7.1.5)
	* Documentation updates for Visual Monitoring feature and other doc ticket fixes.
* Core 3.7.2.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.90.0 (2021-08-05 21:31 UTC)
* Core 3.7.2.0
	* Add support for Document Types

### 3.7.89.0 (2021-08-05 18:12 UTC)
* AutoScaling (3.7.5.0)
	* EC2 Auto Scaling adds configuration checks and Launch Template validation to Instance Refresh.
* LexModelsV2 (3.7.5.0)
	* Customers can now toggle the active field on prompts and responses.

### 3.7.88.0 (2021-08-04 18:13 UTC)
* EventBridge (3.7.3.15)
	* Documentation updates to add EC2 Image Builder as a target on PutTargets.
* Imagebuilder (3.7.2.13)
	* Updated list actions to include a list of valid filters that can be used in the request.
* RDS (3.7.4.0)
	* This release adds AutomaticRestartTime to the DescribeDBInstances and DescribeDBClusters operations. AutomaticRestartTime indicates the time when a stopped DB instance or DB cluster is restarted automatically.
* SSMIncidents (3.7.1.0)
	* Documentation updates for Incident Manager.
* TranscribeService (3.7.4.0)
	* This release adds support for call analytics (batch) within Amazon Transcribe.
* Core 3.7.1.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.87.0 (2021-08-03 18:19 UTC)
* Glue (3.7.6.0)
	* Add ConcurrentModificationException to create-table, delete-table, create-database, update-database, delete-database
* IoTSiteWise (3.7.6.0)
	* My AWS Service (placeholder) - This release introduces custom Intervals and offset for tumbling window in metric for AWS IoT SiteWise.
* MediaConvert (3.7.5.0)
	* AWS Elemental MediaConvert SDK has added control over the passthrough of XDS captions metadata to outputs.
* Proton (3.7.1.15)
	* Docs only add idempotent create apis
* Redshift (3.7.8.0)
	* API support for Redshift Data Sharing feature.

### 3.7.86.0 (2021-08-02 18:16 UTC)
* GreengrassV2 (3.7.2.0)
	* This release adds support for component system resource limits and idempotent Create operations. You can now specify the maximum amount of CPU and memory resources that each component can use.
* SSMContacts (3.7.2.0)
	* Added new attribute in AcceptCode API. AcceptCodeValidation takes in two values - ENFORCE, IGNORE. ENFORCE forces validation of accept code and IGNORE ignores it which is also the default behavior; Corrected TagKeyList length from 200 to 50

### 3.7.85.0 (2021-07-30 18:30 UTC)
* AppSync (3.7.1.0)
	* AWS AppSync now supports a new authorization mode allowing you to define your own authorization logic using an AWS Lambda function.
* ElasticLoadBalancingV2 (3.7.0.50)
	* Client Port Preservation ALB Attribute Launch
* SageMaker (3.7.10.0)
	* API changes with respect to Lambda steps in model building pipelines. Adds several waiters to async Sagemaker Image APIs. Add more instance types to AppInstanceType field
* SecretsManager (3.7.1.0)
	* Add support for KmsKeyIds in the ListSecretVersionIds API response
* Core 3.7.1.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.84.0 (2021-07-29 18:14 UTC)
* Chime (3.7.9.0)
	* Adds support for live transcription of meetings with Amazon Transcribe and Amazon Transcribe Medical.  The new APIs, StartMeetingTranscription and StopMeetingTranscription, control the generation of user-attributed transcriptions sent to meeting clients via Amazon Chime SDK data messages.
* EC2 (3.7.20.0)
	* This release adds support for G4ad xlarge and 2xlarge instances powered by AMD Radeon Pro V520 GPUs and AMD 2nd Generation EPYC processors
* IoT (3.7.3.0)
	* Increase maximum credential duration of role alias to 12 hours.
* IoTSiteWise (3.7.5.0)
	* Added support for AWS IoT SiteWise Edge. You can now create an AWS IoT SiteWise gateway that runs on AWS IoT Greengrass V2. With the gateway,  you can collect local server and equipment data, process the data, and export the selected data from the edge to the AWS Cloud.
* SavingsPlans (3.7.2.0)
	* Documentation update for valid Savings Plans offering ID pattern
* Core 3.7.1.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.83.0 (2021-07-28 18:12 UTC)
* CloudFormation (3.7.4.0)
	* SDK update to support Importing existing Stacks to new/existing Self Managed StackSet - Stack Import feature.
* SSOAdmin (3.7.0.46)
	* Documentation updates for arn:aws:trebuchet:::service:v1:03a2216d-1cda-4696-9ece-1387cb6f6952

### 3.7.82.0 (2021-07-27 18:20 UTC)
* Batch (3.7.2.0)
	* Add support for ListJob filters
* IoTAnalytics (3.7.2.0)
	* IoT Analytics now supports creating a dataset resource with IoT SiteWise MultiLayerStorage data stores, enabling customers to query industrial data within the service. This release includes adding JOIN functionality for customers to query multiple data sources in a dataset.
* IoTWireless (3.7.6.0)
	* Add SidewalkManufacturingSn as an identifier to allow Customer to query WirelessDevice, in the response, AmazonId is added in the case that Sidewalk device is return.
* LexModelsV2 (3.7.4.0)
	* Add waiters that automatically poll for resource status for asynchronous operations, such as building a bot
* QuickSight (3.7.4.0)
	* Add support to use row-level security with tags when embedding dashboards for users not provisioned in QuickSight
* RedshiftDataAPIService (3.7.2.0)
	* Added structures to support new Data API operation BatchExecuteStatement, used to execute multiple SQL statements within a single transaction.
* Route53 (3.7.1.0)
	* This release adds support for the RECOVERY_CONTROL health check type to be used in conjunction with Route53 Application Recovery Controller.
* Route53RecoveryCluster (3.7.0.0)
	* Amazon Route 53 Application Recovery Controller's routing control - Routing Control Data Plane APIs help you update the state (On/Off) of the routing controls to reroute traffic across application replicas in a 100% available manner.
* Route53RecoveryControlConfig (3.7.0.0)
	* Amazon Route 53 Application Recovery Controller's routing control - Routing Control Configuration APIs help you create and delete clusters, control panels, routing controls and safety rules. State changes (On/Off) of routing controls are not part of configuration APIs.
* Route53RecoveryReadiness (3.7.0.0)
	* Amazon Route 53 Application Recovery Controller's readiness check capability continually monitors resource quotas, capacity, and network routing policies to ensure that the recovery environment is scaled and configured to take over when needed.
* Shield (3.7.1.36)
	* Change name of DDoS Response Team (DRT) to Shield Response Team (SRT)
* Core 3.7.1.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.81.0 (2021-07-26 19:52 UTC)
* CloudWatch (3.7.2.0)
	* SDK update to support creation of Cross-Account Metric Alarms and update API documentation.
* IdentityStore (3.7.0.45)
	* Documentation updates for SSO API Ref.
* Proton (3.7.1.11)
	* Documentation-only update links
* S3Control (3.7.2.0)
	* S3 Access Point aliases can be used anywhere you use S3 bucket names to access data in S3
* Synthetics (3.7.1.0)
	* CloudWatch Synthetics now supports visual testing in its canaries.
* Textract (3.7.1.0)
	* Adds support for AnalyzeExpense, a new API to extract relevant data such as contact information, items purchased, and vendor name, from almost any invoice or receipt without the need for any templates or configuration.

### 3.7.80.0 (2021-07-23 18:14 UTC)
* Imagebuilder (3.7.2.9)
	* Update to documentation to reapply missing change to SSM uninstall switch default value and improve description.
* S3Outposts (3.7.1.0)
	* Add on-premise access type support for endpoints
* SecurityHub (3.7.4.0)
	* Added product name, company name, and Region fields for security findings. Added details objects for RDS event subscriptions and AWS ECS services. Added fields to the details for AWS Elasticsearch domains.

### 3.7.79.0 (2021-07-22 18:18 UTC)
* EC2 (3.7.19.0)
	* This release allows customers to assign prefixes to their elastic network interface and to reserve IP blocks in their subnet CIDRs. These reserved blocks can be used to assign prefixes to elastic network interfaces or be excluded from auto-assignment.
* ElasticLoadBalancingV2 (3.7.0.47)
	* Adds support for enabling TLS protocol version and cipher suite headers to be sent to backend targets for Application Load Balancers.
* GlueDataBrew (3.7.3.0)
	* This SDK release adds two new features: 1) Output to Native JDBC destinations and 2) Adding configurations to profile jobs
* MediaLive (3.7.5.0)
	* MediaLive now supports passing through style data on WebVTT caption outputs.
* QLDB (3.7.2.0)
	* Amazon QLDB now supports ledgers encrypted with customer managed KMS keys. Changes in CreateLedger, UpdateLedger and DescribeLedger APIs to support the changes.
* S3Control (3.7.1.16)
	* Documentation updates for Amazon S3-control

### 3.7.78.0 (2021-07-21 21:39 UTC)
* DynamoDBv2 (3.7.0.45)
	* Use correct table name in exceptions
* Core 3.7.1.0
	* Enable IPv6 support for IMDS; Fix typos in AutoConstructedTypes.cs summary tags
	* All services packages updated to require new Core

### 3.7.77.0 (2021-07-21 18:21 UTC)
* CodeBuild (3.7.3.0)
	* AWS CodeBuild now allows you to set the access permissions for build artifacts, project artifacts, and log files that are uploaded to an Amazon S3 bucket that is owned by another account.
* ElasticLoadBalancingV2 (3.7.0.45)
	* Adds support for enabling TLS protocol version and cipher suite headers to be sent to backend targets for Application Load Balancers.
* ElasticMapReduce (3.7.1.0)
	* EMR now supports new DescribeReleaseLabel and ListReleaseLabel APIs. They can provide Amazon EMR release label details. You can programmatically list available releases and applications for a specific Amazon EMR release label.
* IdentityManagement (3.7.2.23)
	* Documentation updates for AWS Identity and Access Management (IAM).
* Kendra (3.7.8.0)
	* Amazon Kendra now provides a data source connector for Amazon WorkDocs. For more information, see https://docs.aws.amazon.com/kendra/latest/dg/data-source-workdocs.html
* Lambda (3.7.2.0)
	* New ResourceConflictException error code for PutFunctionEventInvokeConfig, UpdateFunctionEventInvokeConfig, and DeleteFunctionEventInvokeConfig operations.
* Personalize (3.7.5.0)
	* My AWS Service (placeholder) - Making minProvisionedTPS an optional parameter when creating a campaign. If not provided, it defaults to 1.
* Proton (3.7.1.9)
	* Documentation updates for AWS Proton
* RDS (3.7.3.0)
	* Adds the OriginalSnapshotCreateTime field to the DBSnapshot response object. This field timestamps the underlying data of a snapshot and doesn't change when the snapshot is copied.

### 3.7.76.0 (2021-07-20 18:16 UTC)
* ComputeOptimizer (3.7.2.18)
	* Documentation updates for Compute Optimizer
* EC2 (3.7.18.0)
	* Added idempotency to the CreateVolume API using the ClientToken request parameter

### 3.7.75.0 (2021-07-19 18:13 UTC)
* AWSHealth (3.7.1.0)
	* In the Health API, the maximum number of entities for the EventFilter and EntityFilter data types has changed from 100 to 99. This change is related to an internal optimization of the AWS Health service.
* DirectConnect (3.7.2.2)
	* Documentation updates for directconnect
* EMRContainers (3.7.1.0)
	* Updated DescribeManagedEndpoint and ListManagedEndpoints to return failureReason and stateDetails in API response.
* Imagebuilder (3.7.2.7)
	* Documentation updates for reversal of default value for additional instance configuration SSM switch, plus improved descriptions for semantic versioning.
* LocationService (3.7.3.0)
	* Add five new API operations: UpdateGeofenceCollection, UpdateMap, UpdatePlaceIndex, UpdateRouteCalculator, UpdateTracker.
* RoboMaker (3.7.3.0)
	* This release allows customers to create a new version of WorldTemplates with support for Doors.

### 3.7.74.0 (2021-07-16 18:12 UTC)
* AppIntegrationsService (3.7.0.43)
	* Documentation update for AppIntegrations Service
* AuditManager (3.7.4.0)
	* This release relaxes the S3 URL character restrictions in AWS Audit Manager. Regex patterns have been updated for the following attributes: s3RelativePath, destination, and s3ResourcePath. 'AWS' terms have also been replaced with entities to align with China Rebrand documentation efforts.
* Chime (3.7.8.0)
	* This SDK release adds Account Status as one of the attributes in Account API response
* Core 3.7.0.45
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.73.0 (2021-07-15 18:13 UTC)
* CognitoIdentityProvider (3.7.1.14)
	* Documentation updates for cognito-idp
* EC2 (3.7.17.0)
	* This feature enables customers  to specify weekly recurring time window(s) for scheduled events that reboot, stop or terminate EC2 instances.
* ECS (3.7.2.17)
	* Documentation updates for support of awsvpc mode on Windows.
* IoTSiteWise (3.7.4.0)
	* Update the default endpoint for the APIs used to manage asset models, assets, gateways, tags, and account configurations. If you have firewalls with strict egress rules, configure the rules to grant you access to api.iotsitewise.[region].amazonaws.com or api.iotsitewise.[cn-region].amazonaws.com.cn.
* LexModelBuildingService (3.7.3.0)
	* Lex now supports the en-IN locale

### 3.7.72.0 (2021-07-14 18:15 UTC)
* CertificateManager (3.7.1.0)
	* Added support for RSA 3072 SSL certificate import
* DatabaseMigrationService (3.7.2.0)
	* Release of feature needed for ECA-Endpoint settings. This allows customer to delete a field in endpoint settings by using --exact-settings flag in modify-endpoint api. This also displays default values for certain required fields of endpoint settings in describe-endpoint-settings api.
* Glue (3.7.5.0)
	* Add support for Event Driven Workflows
* HealthLake (3.7.1.0)
	* General availability for Amazon HealthLake. StartFHIRImportJob and StartFHIRExportJob APIs now require AWS KMS parameter. For more information, see the Amazon HealthLake Documentation https://docs.aws.amazon.com/healthlake/index.html.
* Lightsail (3.7.2.0)
	* This release adds support for the Amazon Lightsail object storage service, which allows you to create buckets and store objects.
* WellArchitected (3.7.1.0)
	* This update provides support for Well-Architected API users to mark answer choices as not applicable.

### 3.7.71.0 (2021-07-13 18:17 UTC)
* AmplifyBackend (3.7.2.0)
	* Added Sign in with Apple OAuth provider.
* DevOpsGuru (3.7.3.0)
	* Add paginator for GetCostEstimation
* DirectConnect (3.7.2.0)
	* This release adds a new filed named awsLogicalDeviceId that it displays the AWS Direct Connect endpoint which terminates a physical connection's BGP Sessions.
* LexModelBuildingService (3.7.2.0)
	* Customers can now migrate bots built with Lex V1 APIs to V2 APIs. This release adds APIs to initiate and manage the migration of a bot.
* Pricing (3.7.1.38)
	* Documentation updates for api.pricing
* Redshift (3.7.7.0)
	* Release new APIs to support new Redshift feature - Authentication Profile
* SimpleSystemsManagement (3.7.4.0)
	* Changes to OpsCenter APIs to support a new feature, operational insights.
* Core 3.7.0.44
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.70.0 (2021-07-12 18:12 UTC)
* EKS (3.7.6.2)
	* Documentation updates for Wesley to support the parallel node upgrade feature.
* Kendra (3.7.7.0)
	* Amazon Kendra now supports Principal Store
* Core 3.7.0.43
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.69.0 (2021-07-09 19:21 UTC)
* FraudDetector (3.7.2.0)
	* This release adds support for ML Explainability to display model variable importance value in Amazon Fraud Detector.
* MediaConvert (3.7.4.0)
	* MediaConvert now supports color, style and position information passthrough from 608 and Teletext to SRT and WebVTT subtitles. MediaConvert now also supports Automatic QVBR quality levels for QVBR RateControlMode.
* SageMaker (3.7.9.0)
	* Releasing new APIs related to Tuning steps in model building pipelines.
* Core 3.7.0.42
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.68.0 (2021-07-08 18:22 UTC)
* DevOpsGuru (3.7.2.0)
	* Add AnomalyReportedTimeRange field to include open and close time of anomalies.
* EKS (3.7.6.0)
	* Added waiters for EKS FargateProfiles.
* FMS (3.7.2.0)
	* AWS Firewall Manager now supports route table monitoring, and provides remediation action recommendations to security administrators for AWS Network Firewall policies with misconfigured routes.
* MediaTailor (3.7.3.0)
	* Add ListAlerts for Channel, Program, Source Location, and VOD Source to return alerts for resources.
* Outposts (3.7.2.0)
	* Added property filters for listOutposts
* SSMContacts (3.7.1.4)
	* Updated description for CreateContactChannel contactId.
* Core 3.7.0.41
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.67.1 (2021-07-07 20:56 UTC)
* DynamoDBv2 (3.7.0.39)
	* Rework locks building DynamoDB table caches
* S3 (3.7.1.10)
	* Generate S3 region enumeration
* Core 3.7.0.40
	* Fixed an issue where ProfileAWSRegion should consider AWSProfileName from config as well.
Rework locks building region cache information
	* All services packages updated to require new Core

### 3.7.67.0 (2021-07-07 18:16 UTC)
* Chime (3.7.7.0)
	* Releasing new APIs for AWS Chime MediaCapturePipeline
* CloudFront (3.7.3.0)
	* Amazon CloudFront now provides two new APIs, ListConflictingAliases and AssociateAlias, that help locate and move Alternate Domain Names (CNAMEs) if you encounter the CNAMEAlreadyExists error code.
* EC2 (3.7.16.0)
	* This release adds resource ids and tagging support for VPC security group rules.
* IdentityManagement (3.7.2.16)
	* Documentation updates for AWS Identity and Access Management (IAM).
* IoTSiteWise (3.7.3.0)
	* This release add storage configuration APIs for AWS IoT SiteWise.
* MQ (3.7.1.0)
	* adds support for modifying the maintenance window for brokers.
* SecurityToken (3.7.1.27)
	* Documentation updates for AWS Security Token Service.
* StorageGateway (3.7.2.0)
	* Adding support for oplocks for SMB file shares,  S3 Access Point and S3 Private Link for all file shares and IP address support for file system associations

### 3.7.66.0 (2021-07-06 18:17 UTC)
* EKS (3.7.5.0)
	* Adding new error code UnsupportedAddonModification for Addons in EKS
* Imagebuilder (3.7.2.0)
	* Adds support for specifying parameters to customize components for recipes. Expands configuration of the Amazon EC2 instances that are used for building and testing images, including the ability to specify commands to run on launch, and more control over installation and removal of the SSM agent.
* Lambda (3.7.1.0)
	* Added support for AmazonMQRabbitMQ as an event source. Added support for VIRTUAL_HOST as SourceAccessType for streams event source mappings.
* Macie2 (3.7.3.8)
	* Sensitive data findings in Amazon Macie now include enhanced location data for JSON and JSON Lines files
* Mgn (3.7.1.0)
	* Bug fix: Remove not supported EBS encryption type "NONE"
* SimpleNotificationService (3.7.2.8)
	* Documentation updates for Amazon SNS.
* Core 3.7.0.39
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.65.0 (2021-07-02 18:11 UTC)
* EC2 (3.7.15.0)
	* This release removes network-insights-boundary
* ElasticLoadBalancingV2 (3.7.0.37)
	* Documentation updates for elasticloadbalancingv2

### 3.7.64.0 (2021-07-01 18:14 UTC)
* EC2 (3.7.14.0)
	* Adding a new reserved field to support future infrastructure improvements for Amazon EC2 Fleet.
* SageMaker (3.7.8.0)
	* SageMaker model registry now supports up to 5 containers and associated environment variables.
* SQS (3.7.0.37)
	* Documentation updates for Amazon SQS.
* Core 3.7.0.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.63.0 (2021-06-30 18:13 UTC)
* AutoScaling (3.7.4.0)
	* Amazon EC2 Auto Scaling infrastructure improvements and optimizations.
* GlueDataBrew (3.7.2.0)
	* Adds support for the output of job results to the AWS Glue Data Catalog.
* Kendra (3.7.6.2)
	* Amazon Kendra Enterprise Edition now offered in smaller more granular units to enable customers with smaller workloads. Virtual Storage Capacity units now offer scaling in increments of 100,000 documents (up to 30GB) per unit and Virtual Query Units offer scaling increments of 8,000 queries per day.
* MediaPackageVod (3.7.2.0)
	* Add support for Widevine DRM on CMAF packaging configurations. Both Widevine and FairPlay DRMs can now be used simultaneously, with CBCS encryption.
* ServiceDiscovery (3.7.3.0)
	* AWS Cloud Map now allows configuring the TTL of the SOA record for a hosted zone to control the negative caching for new services.
* SSMContacts (3.7.1.0)
	* Fixes the tag key length range to 128 chars,  tag value length to 256 chars; Adds support for UTF-8 chars for contact and channel names, Allows users to unset name in UpdateContact API; Adds throttling exception to StopEngagement API, validation exception to APIs UntagResource, ListTagsForResource

### 3.7.62.0 (2021-06-28 18:14 UTC)
* Glue (3.7.4.0)
	* Add JSON Support for Glue Schema Registry
* MediaConvert (3.7.3.0)
	* MediaConvert adds support for HDR10+, ProRes 4444,  and XAVC outputs, ADM/DAMF support for Dolby Atmos ingest, and alternative audio and WebVTT caption ingest via HLS inputs. MediaConvert also now supports creating trickplay outputs for Roku devices for HLS, CMAF, and DASH output groups.
* Redshift (3.7.6.0)
	* Added InvalidClusterStateFault to the DisableLogging API, thrown when calling the API on a non available cluster.
* SageMaker (3.7.7.0)
	* Sagemaker Neo now supports running compilation jobs using customer's Amazon VPC

### 3.7.61.0 (2021-06-25 18:17 UTC)
* AmplifyBackend (3.7.1.0)
	* Imports an existing backend authentication resource.
* Proton (3.7.1.0)
	* Added waiters for template registration, service operations, and environment deployments.
* Snowball (3.7.2.0)
	* AWS Snow Family customers can remotely monitor and operate their connected AWS Snowcone devices. AWS Snowball Edge Storage Optimized customers can now import and export their data using NFS.
* Core 3.7.0.37
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.60.0 (2021-06-24 18:25 UTC)
* Chime (3.7.6.0)
	* Adds EventIngestionUrl field to MediaPlacement
* Cloud9 (3.7.1.32)
	* Minor update to AWS Cloud9 documentation to allow correct parsing of outputted text
* CodeBuild (3.7.2.0)
	* BucketOwnerAccess is currently not supported
* Connect (3.7.3.3)
	* Released Amazon Connect quick connects management API for general availability (GA). For more information, see https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html
* DAX (3.7.1.0)
	* Add support for encryption in transit to DAX clusters.
* Kendra (3.7.6.0)
	* Amazon Kendra now supports SharePoint 2013 and SharePoint 2016 when using a SharePoint data source.
* SecurityHub (3.7.3.0)
	* Added new resource details for ECS clusters and ECS task definitions. Added additional information for S3 buckets, Elasticsearch domains, and API Gateway V2 stages.
* Transfer (3.7.2.0)
	* Customers can successfully use legacy clients with Transfer Family endpoints enabled for FTPS and FTP behind routers, firewalls, and load balancers by providing a Custom IP address used for data channel communication.
* WAFV2 (3.7.3.0)
	* Added support for 15 new text transformation.
* Core 3.7.0.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.59.0 (2021-06-23 18:25 UTC)
* Cloud9 (3.7.1.31)
	* Updated documentation for CreateEnvironmentEC2 to explain that because Amazon Linux AMI has ended standard support as of December 31, 2020, we recommend you choose Amazon Linux 2--which includes long term support through 2023--for new AWS Cloud9 environments.
* CloudFront (3.7.2.0)
	* Amazon CloudFront adds support for a new security policy, TLSv1.2_2021.
* CloudSearch (3.7.1.0)
	* This release replaces previous generation CloudSearch instances with equivalent new instances that provide better stability at the same price.
* CloudWatchEvents (3.7.3.0)
	* Added the following parameters to ECS targets: CapacityProviderStrategy, EnableECSManagedTags, EnableExecuteCommand, PlacementConstraints, PlacementStrategy, PropagateTags, ReferenceId, and Tags
* CodeGuruReviewer (3.7.2.0)
	* Adds support for S3 based full repository analysis and changed lines scan.
* DocDB (3.7.2.5)
	* DocumentDB documentation-only edits
* EC2 (3.7.13.0)
	* This release adds support for provisioning your own IP (BYOIP) range in multiple regions. This feature is in limited Preview for this release. Contact your account manager if you are interested in this feature.
* EventBridge (3.7.3.0)
	* Added the following parameters to ECS targets: CapacityProviderStrategy, EnableECSManagedTags, EnableExecuteCommand, PlacementConstraints, PlacementStrategy, PropagateTags, ReferenceId, and Tags
* LicenseManager (3.7.2.0)
	* AWS License Manager now allows license administrators and end users to communicate to each other by setting custom status reasons when updating the status on a granted license.
* MediaTailor (3.7.2.0)
	* Update GetChannelSchedule to return information on ad breaks.
* QuickSight (3.7.3.0)
	* Releasing new APIs for AWS QuickSight Folders

### 3.7.58.0 (2021-06-21 18:35 UTC)
* CloudFormation (3.7.3.0)
	* CloudFormation registry service now supports 3rd party public type sharing
* Core 3.7.0.35
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.57.0 (2021-06-17 18:29 UTC)
* Chime (3.7.5.0)
	* This release adds a new API UpdateSipMediaApplicationCall, to update an in-progress call for SipMediaApplication.
* Kendra (3.7.5.0)
	* Amazon Kendra now supports the indexing of web documents for search through the web crawler.
* RDS (3.7.2.0)
	* This release enables Database Activity Streams for RDS Oracle
* SageMaker (3.7.6.0)
	* Enable ml.g4dn instance types for SageMaker Batch Transform and SageMaker Processing
* Core 3.7.0.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.56.0 (2021-06-16 18:13 UTC)
* EC2 (3.7.12.0)
	* This release adds support for VLAN-tagged network traffic over an Elastic Network Interface (ENI). This feature is in limited Preview for this release. Contact your account manager if you are interested in this feature.
* KeyManagementService (3.7.1.0)
	* Adds support for multi-Region keys
* MediaTailor (3.7.1.0)
	* Adds AWS Secrets Manager Access Token Authentication for Source Locations
* RDS (3.7.1.0)
	* This release enables fast cloning in Aurora Serverless. You can now clone between Aurora Serverless clusters and Aurora Provisioned clusters.

### 3.7.55.0 (2021-06-15 18:14 UTC)
* Connect (3.7.3.0)
	* This release adds new sets of APIs: AssociateBot, DisassociateBot, and ListBots. You can use it to programmatically add an Amazon Lex bot or Amazon Lex V2 bot on the specified Amazon Connect instance
* EC2 (3.7.11.0)
	* EC2 M5n, M5dn, R5n, R5dn metal instances with 100 Gbps network performance and Elastic Fabric Adapter (EFA) for ultra low latency
* LexModelsV2 (3.7.3.0)
	* This release adds support for Multi Valued slots in Amazon Lex V2 APIs for model building
* LexRuntimeV2 (3.7.1.0)
	* This release adds support for Multi Valued slots in Amazon Lex V2 APIs for runtime
* RedshiftDataAPIService (3.7.1.0)
	* Redshift Data API service now supports SQL parameterization.
* Core 3.7.0.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.54.0 (2021-06-14 18:17 UTC)
* GreengrassV2 (3.7.1.0)
	* We have verified the APIs being released here and are ready to release
* IoTAnalytics (3.7.1.0)
	* Adds support for data store partitions.
* LookoutMetrics (3.7.4.0)
	* Added "LEARNING" status for anomaly detector and updated description for "Offset" parameter in MetricSet APIs.

### 3.7.53.0 (2021-06-11 18:19 UTC)
* EC2 (3.7.10.0)
	* Amazon EC2 adds new AMI property to flag outdated AMIs
* MediaConnect (3.7.3.0)
	* When you enable source failover, you can now designate one of two sources as the primary source. You can choose between two failover modes to prevent any disruption to the video stream. Merge combines the sources into a single stream. Failover allows switching between a primary and a backup stream.
* MediaLive (3.7.4.0)
	* AWS MediaLive now supports OCR-based conversion of DVB-Sub and SCTE-27 image-based source captions to WebVTT, and supports ingest of ad avail decorations in HLS input manifests.
* Core 3.7.0.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.52.1 (2021-06-10 23:02 UTC)
* S3 (3.7.1.1)
	* Fixed an issue where ScanRange option for S3 Select is not working.

### 3.7.52.0 (2021-06-10 18:23 UTC)
* Appflow (3.7.2.0)
	* Adding MAP_ALL task type support.
* AppMesh (3.7.1.0)
	* AppMesh now supports additional routing capabilities in match and rewrites for Gateway Routes and Routes. Additionally, App Mesh also supports specifying DNS Response Types in Virtual Nodes.
* Chime (3.7.4.0)
	* This SDK release adds support for UpdateAccount API to allow users to update their default license on Chime account.
* CognitoIdentityProvider (3.7.1.0)
	* Amazon Cognito now supports targeted sign out through refresh token revocation
* EC2 (3.7.9.0)
	* This release adds a new optional parameter connectivityType (public, private) for the CreateNatGateway API. Private NatGateway does not require customers to attach an InternetGateway to the VPC and can be used for communication with other VPCs and on-premise networks.
* ManagedBlockchain (3.7.1.0)
	* This release supports KMS customer-managed Customer Master Keys (CMKs) on member-specific Hyperledger Fabric resources.
* RAM (3.7.1.0)
	* AWS Resource Access Manager (RAM) is releasing new field isResourceTypeDefault in ListPermissions and GetPermission response, and adding permissionArn parameter to GetResourceShare request to filter by permission attached
* Redshift (3.7.5.0)
	* Added InvalidClusterStateFault to the ModifyAquaConfiguration API, thrown when calling the API on a non available cluster.
* SageMaker (3.7.5.0)
	* Using SageMaker Edge Manager with AWS IoT Greengrass v2 simplifies accessing, maintaining, and deploying models to your devices. You can now create deployable IoT Greengrass components during edge packaging jobs. You can choose to create a device fleet with or without creating an AWS IoT role alias.
* SageMakerFeatureStoreRuntime (3.7.1.0)
	* Release BatchGetRecord API for AWS SageMaker Feature Store Runtime.

### 3.7.51.0 (2021-06-09 18:25 UTC)
* Kendra (3.7.4.0)
	* AWS Kendra now supports checking document status.
* PersonalizeEvents (3.7.1.0)
	* Support for unstructured text inputs in the items dataset to to automatically extract key information from product/content description as an input when creating solution versions.
* Proton (3.7.0.0)
	* This is the initial SDK release for AWS Proton
* Transfer (3.7.1.4)
	* Documentation updates for the AWS Transfer Family service.

### 3.7.50.0 (2021-06-08 18:14 UTC)
* CognitoIdentityProvider (3.7.0.31)
	* Documentation updates for cognito-idp
* FSx (3.7.3.0)
	* This release adds support for auditing end-user access to files, folders, and file shares using Windows event logs, enabling customers to meet their security and compliance needs.
* Macie2 (3.7.3.0)
	* This release of the Amazon Macie API introduces stricter validation of S3 object criteria for classification jobs.
* ServiceCatalog (3.7.1.0)
	* increase max pagesize for List/Search apis

### 3.7.49.0 (2021-06-07 18:19 UTC)
* EKS (3.7.4.0)
	* Added updateConfig option that allows customers to control upgrade velocity in Managed Node Group.
* Glue (3.7.3.0)
	* Add SampleSize variable to S3Target to enable s3-sampling feature through API.
* Personalize (3.7.4.0)
	* Update regex validation in kmsKeyArn and s3 path API parameters for AWS Personalize APIs
* SageMaker (3.7.4.0)
	* AWS SageMaker - Releasing new APIs related to Callback steps in model building pipelines. Adds experiment integration to model building pipelines.

### 3.7.48.0 (2021-06-04 18:14 UTC)
* AutoScaling (3.7.3.1)
	* Documentation updates for Amazon EC2 Auto Scaling
* CloudTrail (3.7.0.30)
	* AWS CloudTrail supports data events on new service resources, including Amazon DynamoDB tables and S3 Object Lambda access points.
* MediaLive (3.7.3.0)
	* Add support for automatically setting the H.264 adaptive quantization and GOP B-frame fields.
* PI (3.7.1.0)
	* The new GetDimensionKeyDetails action retrieves the attributes of the specified dimension group for a DB instance or data source.
* QLDB (3.7.1.3)
	* Documentation updates for Amazon QLDB
* RDS (3.7.0.30)
	* Documentation updates for RDS: fixing an outdated link to the RDS documentation in DBInstance$DBInstanceStatus

### 3.7.47.0 (2021-06-03 18:12 UTC)
* ForecastService (3.7.4.0)
	* Added optional field AutoMLOverrideStrategy to CreatePredictor API that allows users to customize AutoML strategy. If provided in CreatePredictor request, this field is visible in DescribePredictor and GetAccuracyMetrics responses.
* Route53Resolver (3.7.1.24)
	* Documentation updates for Route 53 Resolver
* S3 (3.7.1.0)
	* S3 Inventory now supports Bucket Key Status
* S3Control (3.7.1.0)
	* Amazon S3 Batch Operations now supports S3 Bucket Keys.
* SimpleSystemsManagement (3.7.3.12)
	* Documentation updates for ssm to fix customer reported issue

### 3.7.46.0 (2021-06-02 18:14 UTC)
* AutoScaling (3.7.3.0)
	* You can now launch EC2 instances with GP3 volumes when using Auto Scaling groups with Launch Configurations
* Braket (3.7.1.0)
	* Introduction of a RETIRED status for devices.
* DocDB (3.7.2.0)
	* This SDK release adds support for DocDB global clusters.
* ECS (3.7.2.3)
	* Documentation updates for Amazon ECS.
* IdentityManagement (3.7.2.7)
	* Documentation updates for AWS Identity and Access Management (IAM).
* Lightsail (3.7.1.24)
	* Documentation updates for Lightsail

### 3.7.45.0 (2021-06-01 18:13 UTC)
* EC2 (3.7.8.0)
	* Added idempotency to CreateNetworkInterface using the ClientToken parameter.
* IoTWireless (3.7.5.0)
	* Added six new public customer logging APIs to allow customers to set/get/reset log levels at resource type and resource id level. The log level set from the APIs will be used to filter log messages that can be emitted to CloudWatch in customer accounts.
* Polly (3.7.1.0)
	* Amazon Polly adds new Canadian French voice - Gabrielle. Gabrielle is available as Neural voice only.
* ServiceDiscovery (3.7.2.0)
	* Bugfixes - The DiscoverInstances API operation now provides an option to return all instances for health-checked services when there are no healthy instances available.
* SimpleNotificationService (3.7.2.0)
	* This release adds SMS sandbox in Amazon SNS and the ability to view all configured origination numbers. The SMS sandbox provides a safe environment for sending SMS messages, without risking your reputation as an SMS sender.

### 3.7.44.0 (2021-05-28 18:26 UTC)
* DataSync (3.7.1.0)
	* Added SecurityDescriptorCopyFlags option that allows for control of which components of SMB security descriptors are copied from source to destination objects.
* LocationService (3.7.2.0)
	* Adds support for calculation of routes, resource tagging and customer provided KMS keys.
* LookoutMetrics (3.7.3.0)
	* Allowing dot(.) character in table name for RDS and Redshift as source connector.
* Core 3.7.0.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.43.1 (2021-05-27 22:21 UTC)
* S3 (3.7.0.31)
	* Updated to use new Core, version 3.7.0.30
	* Added logic to automatically calculate MD5 for simple/multi-part uploads in TransferUtility. Add S3 Arn support for FIPS.
* Textract (3.7.0.29)
	* Changed description for AWSSDK.Textract package.
* Core 3.7.0.30
	* Auto-generation of standard endpoints added.

### 3.7.43.0 (2021-05-27 18:15 UTC)
* DeviceFarm (3.7.1.0)
	* Introduces support for using our desktop testing service with applications hosted within your Virtual Private Cloud (VPC).
* FSx (3.7.2.0)
	* This release adds LZ4 data compression support to FSx for Lustre to reduce storage consumption of both file system storage and file system backups.
* IoTEvents (3.7.1.0)
	* Releasing new APIs for AWS IoT Events Alarms
* IoTEventsData (3.7.1.0)
	* Releasing new APIs for AWS IoT Events Alarms
* IoTSiteWise (3.7.2.0)
	* IoT SiteWise Monitor Portal API updates to add alarms feature configuration.
* Kendra (3.7.3.0)
	* Amazon Kendra now suggests popular queries in order to help guide query typing and help overall accuracy.
* Lightsail (3.7.1.22)
	* Documentation updates for Lightsail
* ResourceGroups (3.7.0.28)
	* Documentation updates for Resource Groups.
* SQS (3.7.0.29)
	* Documentation updates for Amazon SQS for General Availability of high throughput for FIFO queues.
* Core 3.7.0.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.42.0 (2021-05-26 22:23 UTC)
* ACMPCA (3.7.2.0)
	* This release enables customers to store CRLs in S3 buckets with Block Public Access enabled. The release adds the S3ObjectAcl parameter to the CreateCertificateAuthority and UpdateCertificateAuthority APIs to allow customers to choose whether their CRL will be publicly available.
* CloudFront (3.7.1.11)
	* Documentation fix for CloudFront
* ECS (3.7.2.0)
	* The release adds support for registering External instances to your Amazon ECS clusters.
* MWAA (3.7.1.0)
	* Adds scheduler count selection for Environments using Airflow version 2.0.2 or later.
* Outposts (3.7.1.0)
	* Add ConflictException to DeleteOutpost, CreateOutpost
* QLDB (3.7.1.0)
	* Support STANDARD permissions mode in CreateLedger and DescribeLedger. Add UpdateLedgerPermissionsMode to update permissions mode on existing ledgers.
* Core 3.7.0.28
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.41.0 (2021-05-25 18:12 UTC)
* IoT (3.7.2.0)
	* This release includes support for a new feature: Job templates for AWS IoT Device Management Jobs. The release includes job templates as a new resource and APIs for managing job templates.
* Transfer (3.7.1.0)
	* AWS Transfer Family customers can now use AWS Managed Active Directory or AD Connector to authenticate their end users, enabling seamless migration of file transfer workflows that rely on AD authentication, without changing end users' credentials or needing a custom authorizer.
* WorkSpaces (3.7.1.0)
	* Adds support for Linux device types in WorkspaceAccessProperties

### 3.7.40.0 (2021-05-24 18:16 UTC)
* CloudWatchLogs (3.7.1.0)
	* This release provides dimensions and unit support for metric filters.
* ComputeOptimizer (3.7.2.0)
	* Adds support for 1) additional instance types, 2) additional instance metrics, 3) finding reasons for instance recommendations, and 4) platform differences between a current instance and a recommended instance type.
* CostExplorer (3.7.2.0)
	* Introduced FindingReasonCodes, PlatformDifferences, DiskResourceUtilization and NetworkResourceUtilization to GetRightsizingRecommendation action
* EC2 (3.7.7.0)
	* This release adds support for creating and managing EC2 On-Demand Capacity Reservations on Outposts.
* QuickSight (3.7.2.0)
	* Add new parameters on RegisterUser and UpdateUser APIs to assign or update external ID associated to QuickSight users federated through web identity.
* Core 3.7.0.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.39.0 (2021-05-21 18:14 UTC)
* ElasticFileSystem (3.7.1.0)
	* EFS now supports account preferences. Utilizing the new capability, users can customize some aspects of their experience using EFS APIs and the EFS Console. The first preference clients are able to set is whether to start using longer File System and Mount Target IDs before EFS migrates to such IDs.
* ForecastService (3.7.3.0)
	* Updated attribute statistics in DescribeDatasetImportJob response to support Long values
* OpsWorksCM (3.7.0.25)
	* New PUPPET_API_CRL attribute returned by DescribeServers API; new EngineVersion of 2019 available for Puppet Enterprise servers.
* S3 (3.7.0.27)
	* Documentation updates for Amazon S3
* Core 3.7.0.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.38.0 (2021-05-20 18:14 UTC)
* IdentityManagement (3.7.2.1)
	* Documentation updates for AWS Identity and Access Management (IAM).
* LexModelsV2 (3.7.2.0)
	* Customers can now use resource-based policies to control access to their Lex V2 bots. This release adds APIs to attach and manage permissions for a bot or a bot alias. For details, see: https://docs.aws.amazon.com/lexv2/latest/dg/security_iam_service-with-iam.html
* Personalize (3.7.3.0)
	* Added new API to stop a solution version creation that is pending or in progress for Amazon Personalize
* QuickSight (3.7.1.0)
	* Add ARN based Row Level Security support to CreateDataSet/UpdateDataSet APIs.
* Core 3.7.0.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.37.0 (2021-05-19 18:14 UTC)
* AutoScaling (3.7.2.0)
	* With this release, customers can easily use Predictive Scaling as a policy directly through Amazon EC2 Auto Scaling configurations to proactively scale their applications ahead of predicted demand.
* EKS (3.7.3.0)
	* Update the EKS AddonActive waiter.
* IdentityManagement (3.7.2.0)
	* Add pagination to ListUserTags operation
* KinesisAnalyticsV2 (3.7.4.0)
	* Kinesis Data Analytics now allows rapid iteration on Apache Flink stream processing through the Kinesis Data Analytics Studio feature.
* Lightsail (3.7.1.17)
	* Documentation updates for Amazon Lightsail.
* Rekognition (3.7.1.0)
	* Amazon Rekognition Custom Labels adds support for customer managed encryption, using AWS Key Management Service, of image files copied into the service and files written back to the customer.
* Core 3.7.0.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.36.1 (2021-05-18 21:53 UTC)
* S3 (3.7.0.24)
	* Updated to use new Core, version 3.7.0.23
	* Prevent null exception due to null header keys during request signing
* Core 3.7.0.23
	* Delay SSO Options Validation; Prevent null exception due to null header keys during request signing
	* All services packages updated to require new Core

### 3.7.36.0 (2021-05-18 18:16 UTC)
* AppRunner (3.7.0.0)
	* AWS App Runner is a service that provides a fast, simple, and cost-effective way to deploy from source code or a container image directly to a scalable and secure web application in the AWS Cloud.
* AWSSupport (3.7.0.22)
	* Documentation updates for support
* ComputeOptimizer (3.7.1.0)
	* This release enables compute optimizer to support exporting  recommendations to Amazon S3 for EBS volumes and Lambda Functions.
* IoTSiteWise (3.7.1.7)
	* Documentation updates for AWS IoT SiteWise.
* LexModelsV2 (3.7.1.0)
	* This release adds support for exporting and importing Lex V2 bots and bot locales. It also adds validations to enforce minimum number of tags on Lex V2 resources. For details, see https://docs.aws.amazon.com/lexv2/latest/dg/importing-exporting.html
* LicenseManager (3.7.1.0)
	* AWS License Manager now supports periodic report generation.
* Personalize (3.7.2.0)
	* Amazon Personalize now supports the ability to optimize a solution for a custom objective in addition to maximizing relevance.

### 3.7.35.0 (2021-05-17 18:16 UTC)
* ApplicationCostProfiler (3.7.0.0)
	* APIs for AWS Application Cost Profiler.
* AugmentedAIRuntime (3.7.0.22)
	* Documentation updates for Amazon A2I Runtime model
* ElastiCache (3.7.2.9)
	* Documentation updates for elasticache
* IoTDeviceAdvisor (3.7.1.0)
	* AWS IoT Core Device Advisor is fully managed test capability for IoT devices. Device manufacturers can use Device Advisor to test their IoT devices for reliable and secure connectivity with AWS IoT.
* MediaConnect (3.7.2.0)
	* MediaConnect now supports JPEG XS for AWS Cloud Digital Interface (AWS CDI) uncompressed workflows, allowing you to establish a bridge between your on-premises live video network and the AWS Cloud.
* Neptune (3.7.1.0)
	* Neptune support for CopyTagsToSnapshots

### 3.7.34.0 (2021-05-14 18:18 UTC)
* CloudWatchEvents (3.7.2.0)
	* Update InputTransformer variable limit from 10 to 100 variables.
* Detective (3.7.2.8)
	* Updated descriptions of array parameters to add the restrictions on the array and value lengths.
* Elasticsearch (3.7.1.0)
	* Adds support for cold storage.
* EventBridge (3.7.2.0)
	* Update InputTransformer variable limit from 10 to 100 variables.
* Imagebuilder (3.7.1.14)
	* Text-only updates for bundled documentation feedback tickets - spring 2021.
* Macie2 (3.7.2.0)
	* This release of the Amazon Macie API adds support for defining run-time, S3 bucket criteria for classification jobs. It also adds resources for querying data about AWS resources that Macie monitors.
* SecurityHub (3.7.2.5)
	* Updated descriptions to add notes on array lengths.
* TranscribeService (3.7.3.0)
	* Transcribe Medical now supports identification of PHI entities within transcripts
* Core 3.7.0.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.33.0 (2021-05-12 18:11 UTC)
* EC2 (3.7.6.0)
	* High Memory virtual instances are powered by Intel Sky Lake CPUs and offer up to 12TB of memory.
* Core 3.7.0.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.32.0 (2021-05-11 18:34 UTC)
* S3Control (3.7.0.20)
	* Documentation updates for Amazon S3-control
* SSMContacts (3.7.0.0)
	* AWS Systems Manager Incident Manager enables faster resolution of critical application availability and performance issues, management of contacts and post incident analysis
* SSMIncidents (3.7.0.0)
	* AWS Systems Manager Incident Manager enables faster resolution of critical application availability and performance issues, management of contacts and post-incident analysis

### 3.7.31.1 (2021-05-10 21:35 UTC)
* CloudFront (3.7.1.3)
	* Updated to use new Core, version 3.7.0.20
	* Encode additional end-of-line characters in requests for XML-based services
* Route53 (3.7.0.20)
	* Updated to use new Core, version 3.7.0.20
	* Encode additional end-of-line characters in requests for XML-based services
* S3 (3.7.0.21)
	* Updated to use new Core, version 3.7.0.20
	* Encode additional end-of-line characters in requests for XML-based services
* S3Control (3.7.0.19)
	* Updated to use new Core, version 3.7.0.20
	* Encode additional end-of-line characters in requests for XML-based services
* Core 3.7.0.20
	* Fixes an issue where leading/trailing space(s) in metadata value causes signature mismatch error while uploading an S3 object; Encode additional end-of-line characters in requests for XML-based services; Add support for fips-aws-global pseudo region
	* All services packages updated to require new Core

### 3.7.31.0 (2021-05-10 18:19 UTC)
* CodeArtifact (3.7.0.18)
	* Documentation updates for CodeArtifact
* ConfigService (3.7.3.0)
	* Adds paginator to multiple APIs: By default, the paginator allows user to iterate over the results and allows the CLI to return up to 1000 results.
* ECS (3.7.1.3)
	* This release contains updates for Amazon ECS.
* EKS (3.7.2.0)
	* This release updates create-nodegroup and update-nodegroup-config APIs for adding/updating taints on managed nodegroups.
* IoTWireless (3.7.4.0)
	* Add three new optional fields to support filtering and configurable sub-band in WirelessGateway APIs. The filtering is for all the RF region supported. The sub-band configuration is only applicable to LoRa gateways of US915 or AU915 RF region.
* KinesisAnalyticsV2 (3.7.3.0)
	* Amazon Kinesis Analytics now supports ListApplicationVersions and DescribeApplicationVersion API for Apache Flink applications
* MediaConvert (3.7.2.0)
	* AWS Elemental MediaConvert SDK has added support for Kantar SNAP File Audio Watermarking with a Kantar Watermarking account, and Display Definition Segment(DDS) segment data controls for DVB-Sub caption outputs.
* SimpleSystemsManagement (3.7.3.0)
	* This release adds new APIs to associate, disassociate and list related items in SSM OpsCenter; and this release adds DisplayName as a version-level attribute for SSM Documents and introduces two new document types: ProblemAnalysis, ProblemAnalysisTemplate.
* Core 3.7.0.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.30.0 (2021-05-07 18:11 UTC)
* Connect (3.7.2.0)
	* Adds tagging support for Connect APIs CreateIntegrationAssociation and CreateUseCase.
* LakeFormation (3.7.1.0)
	* This release adds Tag Based Access Control to AWS Lake Formation service
* LookoutMetrics (3.7.2.0)
	* Enforcing UUID style for parameters that are already in UUID format today. Documentation specifying eventual consistency of lookoutmetrics resources.

### 3.7.29.0 (2021-05-06 18:13 UTC)
* Kafka (3.7.1.0)
	* IAM Access Control for Amazon MSK enables you to create clusters that use IAM to authenticate clients and to allow or deny Apache Kafka actions for those clients.
* ServiceDiscovery (3.7.1.0)
	* Bugfix: Improved input validation for RegisterInstance action, InstanceId field
* SimpleSystemsManagement (3.7.2.0)
	* SSM feature release - ChangeCalendar integration with StateManager.
* Snowball (3.7.1.0)
	* AWS Snow Family adds APIs for ordering and managing Snow jobs with long term pricing
* Core 3.7.0.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.28.0 (2021-05-05 19:40 UTC)
* AuditManager (3.7.3.0)
	* This release updates the CreateAssessmentFrameworkControlSet and UpdateAssessmentFrameworkControlSet API data types. For both of these data types, the control set name is now a required attribute.
* KinesisAnalyticsV2 (3.7.2.0)
	* Amazon Kinesis Analytics now supports RollbackApplication for Apache Flink applications to revert the application to the previous running version
* NimbleStudio (3.7.0.2)
	* Documentation Updates for Amazon Nimble Studio.
* SageMaker (3.7.3.0)
	* Amazon SageMaker Autopilot now provides the ability to automatically deploy the best model to an endpoint

### 3.7.27.1 (2021-05-05 02:45 UTC)
* Finspace (3.7.0.1)
	* Documentation updates for FinSpace API.
* FinSpaceData (3.7.0.1)
	* Documentation updates for FinSpaceData API.

### 3.7.27.0 (2021-05-04 18:13 UTC)
* ACMPCA (3.7.1.0)
	* This release adds the KeyStorageSecurityStandard parameter to the CreateCertificateAuthority API to allow customers to mandate a security standard to which the CA key will be stored within.
* AWSHealth (3.7.0.17)
	* Documentation updates for health
* Chime (3.7.3.0)
	* This release adds the ability to search for and order international phone numbers for Amazon Chime SIP media applications.
* DevOpsGuru (3.7.1.0)
	* Added GetCostEstimation and StartCostEstimation to get the monthly resource usage cost and added ability to view resource health by AWS service name and to search insights be AWS service name.
* SageMaker (3.7.2.0)
	* Enable retrying Training and Tuning Jobs that fail with InternalServerError by setting RetryStrategy.

### 3.7.26.0 (2021-05-03 20:53 UTC)
* Chime (3.7.2.0)
	* Added new BatchCreateChannelMembership API to support multiple membership creation for channels
* Finspace (3.7.0.0)
	* This is the initial SDK release for the management APIs for Amazon FinSpace. Amazon FinSpace is a data management and analytics service for the financial services industry (FSI).
* FinSpaceData (3.7.0.0)
	* This is the initial SDK release for the data APIs for Amazon FinSpace. Amazon FinSpace is a data management and analytics application for the financial services industry (FSI).
* MTurk (3.7.0.17)
	* Documentation updates for Amazon Mechanical Turk, GetAccountBalanceOperation operation
* SecurityHub (3.7.2.0)
	* Updated ASFF to add the following new resource details objects: AwsEc2NetworkAcl, AwsEc2Subnet, and AwsElasticBeanstalkEnvironment.

### 3.7.25.0 (2021-04-30 18:15 UTC)
* CloudFront (3.7.1.0)
	* CloudFront now supports CloudFront Functions, a native feature of CloudFront that enables you to write lightweight functions in JavaScript for high-scale, latency-sensitive CDN customizations.
* CustomerProfiles (3.7.2.0)
	* This release introduces GetMatches and MergeProfiles APIs to fetch and merge duplicate profiles
* ForecastService (3.7.2.0)
	* Added new DeleteResourceTree operation that helps in deleting all the child resources of a given resource including the given resource.
* MarketplaceCatalog (3.7.1.0)
	* Allows user defined names for Changes in a ChangeSet. Users can use ChangeNames to reference properties in another Change within a ChangeSet. This feature allows users to make changes to an entity when the entity identifier is not yet available while constructing the StartChangeSet request.
* Personalize (3.7.1.3)
	* Update URL for dataset export job documentation.
* RoboMaker (3.7.2.0)
	* Adds ROS2 Foxy as a supported Robot Software Suite Version and Gazebo 11 as a supported Simulation Software Suite Version

### 3.7.24.1 (2021-04-30 02:38 UTC)
* S3 (3.7.0.18)
	* Fixes an issue where RecordDelimiter '\n' in CSV InputSerialization/OutputSerialization does not work for AmazonS3Client.SelectObjectContentAsync
* Core 3.7.0.17
	* Update service nuget ranges to [3.7.X, 4.0).
Added retry logic for intermittent SSL_ERROR_ZERO_RETURN.
Fixed Arn.TryParse method to never throw exceptions.
	* All services packages updated to require new Core

### 3.7.24.0 (2021-04-29 18:16 UTC)
* Chime (3.7.1.0)
	* Increase AppInstanceUserId length to 64 characters
* ECS (3.7.1.0)
	* Add support for EphemeralStorage on TaskDefinition and TaskOverride
* Macie2 (3.7.1.0)
	* The Amazon Macie API now provides S3 bucket metadata that indicates whether a bucket policy requires server-side encryption of objects when objects are uploaded to the bucket.
* Organizations (3.7.0.16)
	* Minor text updates for AWS Organizations API Reference

### 3.7.23.0 (2021-04-28 18:14 UTC)
* CloudFormation (3.7.2.0)
	* Add CallAs parameter to GetTemplateSummary to enable use with StackSets delegated administrator integration
* Connect (3.7.1.0)
	* Updated max number of tags that can be attached from 200 to 50. MaxContacts is now an optional parameter for the UpdateQueueMaxContact API.
* IoTSiteWise (3.7.1.0)
	* AWS IoT SiteWise interpolation API will get interpolated values for an asset property per specified time interval during a period of time.
* MediaPackageVod (3.7.1.0)
	* MediaPackage now offers the option to place your Sequence Parameter Set (SPS), Picture Parameter Set (PPS), and Video Parameter Set (VPS) encoder metadata in every video segment instead of in the init fragment for DASH and CMAF endpoints.
* NimbleStudio (3.7.0.0)
	* Amazon Nimble Studio is a virtual studio service that empowers visual effects, animation, and interactive content teams to create content securely within a scalable, private cloud service.

### 3.7.22.0 (2021-04-27 18:14 UTC)
* AuditManager (3.7.2.0)
	* This release restricts using backslashes in control, assessment, and framework names. The controlSetName field of the UpdateAssessmentFrameworkControlSet API now allows strings without backslashes.
* Core 3.7.0.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.21.0 (2021-04-26 18:17 UTC)
* CodeGuruReviewer (3.7.1.0)
	* Include KMS Key Details in Repository Association APIs to enable usage of customer managed KMS Keys.
* EC2 (3.7.5.0)
	* Adding support for Red Hat Enterprise Linux with HA for Reserved Instances.
* EKS (3.7.1.0)
	* This release updates existing Amazon EKS input validation so customers will see an InvalidParameterException instead of a ParamValidationError when they enter 0 for minSize and/or desiredSize. It also adds LaunchTemplate information to update responses and a new "CUSTOM" value for AMIType.
* Glue (3.7.2.0)
	* Adding Kafka Client Auth Related Parameters
* IoTWireless (3.7.3.0)
	* Add a new optional field MessageType to support Sidewalk devices in SendDataToWirelessDevice API
* KinesisAnalyticsV2 (3.7.1.0)
	* Amazon Kinesis Data Analytics now supports custom application maintenance configuration using UpdateApplicationMaintenanceConfiguration API for Apache Flink applications. Customers will have visibility when their application is under maintenance status using 'MAINTENANCE' application status.
* MediaConvert (3.7.1.9)
	* Documentation updates for mediaconvert
* Personalize (3.7.1.0)
	* Added support for exporting data imported into an Amazon Personalize dataset to a specified data source (Amazon S3 bucket).

### 3.7.20.0 (2021-04-23 18:25 UTC)
* MediaPackage (3.7.2.0)
	* Add support for Widevine DRM on CMAF origin endpoints. Both Widevine and FairPlay DRMs can now be used simultaneously, with CBCS encryption.
* SimpleNotificationService (3.7.1.0)
	* Amazon SNS adds two new attributes, TemplateId and EntityId, for using sender IDs to send SMS messages to destinations in India.
* Core 3.7.0.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.19.0 (2021-04-22 18:13 UTC)
* CognitoIdentityProvider (3.7.0.14)
	* Documentation updates for cognito-idp
* ElastiCache (3.7.2.0)
	* This release introduces log delivery of Redis slow log from Amazon ElastiCache.
* ForecastService (3.7.1.0)
	* This release adds EstimatedTimeRemaining minutes field to the DescribeDatasetImportJob, DescribePredictor, DescribeForecast API response which denotes the time remaining to complete the job IN_PROGRESS.
* SecurityHub (3.7.1.0)
	* Replaced the term "master" with "administrator". Added new actions to replace AcceptInvitation, GetMasterAccount, and DisassociateFromMasterAccount. In Member, replaced MasterId with AdministratorId.

### 3.7.18.0 (2021-04-21 18:37 UTC)
* CloudFormation (3.7.1.10)
	* Added support for creating and updating stack sets with self-managed permissions from templates that reference macros.
* Detective (3.7.2.0)
	* Added parameters to track the data volume in bytes for a member account. Deprecated the existing parameters that tracked the volume as a percentage of the allowed volume for a behavior graph. Changes reflected in MemberDetails object.
* GroundStation (3.7.1.0)
	* Support new S3 Recording Config allowing customers to write downlink data directly to S3.
* Kendra (3.7.2.0)
	* Amazon Kendra now enables users to override index-level boosting configurations for each query.
* Redshift (3.7.4.0)
	* Add operations: AddPartner, DescribePartners, DeletePartner, and UpdatePartnerStatus to support tracking integration status with data partners.

### 3.7.17.0 (2021-04-19 18:12 UTC)
* CostExplorer (3.7.1.0)
	* Adding support for Sagemaker savings plans in GetSavingsPlansPurchaseRecommendation API
* SavingsPlans (3.7.1.0)
	* Added support for Amazon SageMaker in Machine Learning Savings Plans
* Core 3.7.0.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.16.0 (2021-04-15 18:12 UTC)
* DatabaseMigrationService (3.7.1.0)
	* AWS DMS added support of TLS for Kafka endpoint. Added Describe endpoint setting API for DMS endpoints.
* SecurityToken (3.7.1.1)
	* STS now supports assume role with Web Identity using JWT token length upto 20000 characters
* Core 3.7.0.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.15.0 (2021-04-14 18:15 UTC)
* CodeStarconnections (3.7.1.0)
	* This release adds tagging support for CodeStar Connections Host resources
* ConfigService (3.7.2.0)
	* Add exception for DeleteRemediationConfiguration and DescribeRemediationExecutionStatus
* MediaConnect (3.7.1.0)
	* For flows that use Listener protocols, you can now easily locate an output's outbound IP address for a private internet. Additionally, MediaConnect now supports the Waiters feature that makes it easier to poll for the status of a flow until it reaches its desired state.
* Route53 (3.7.0.12)
	* Documentation updates for route53

### 3.7.14.0 (2021-04-13 20:48 UTC)
* ComprehendMedical (3.7.1.0)
	* The InferICD10CM API now returns TIME_EXPRESSION entities that refer to medical conditions.
* Lightsail (3.7.1.5)
	* Documentation updates for Amazon Lightsail.
* RDS (3.7.0.11)
	* Clarify that enabling or disabling automated backups causes a brief downtime, not an outage.
* Redshift (3.7.3.0)
	* Added support to enable AQUA in Amazon Redshift clusters.
* SecurityToken (3.7.1.0)
	* Updated to use new Core, version 3.7.0.12
	* This release adds the SourceIdentity parameter that can be set when assuming a role.
* Core 3.7.0.12
	* Added SourceIdentity property to AssumeRoleAWSCredentialsOptions

	* All services packages updated to require new Core

### 3.7.13.1 (2021-04-12 21:04 UTC)
* S3 (3.7.0.12)
	* Fix STS token query parameter casing while using S3 PresignedURLs with SigV2.

### 3.7.13.0 (2021-04-12 18:15 UTC)
* CodeBuild (3.7.1.0)
	* AWS CodeBuild now allows you to set the access permissions for build artifacts, project artifacts, and log files that are uploaded to an Amazon S3 bucket that is owned by another account.
* FSx (3.7.1.0)
	* Support for cross-region and cross-account backup copies
* Core 3.7.0.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.12.0 (2021-04-09 18:12 UTC)
* EC2 (3.7.4.0)
	* Add paginator support to DescribeStoreImageTasks and update documentation.
* Redshift (3.7.2.0)
	* Add support for case sensitive table level restore
* Shield (3.7.1.0)
	* CreateProtection now throws InvalidParameterException instead of InternalErrorException when system tags (tag with keys prefixed with "aws:") are passed in.

### 3.7.11.0 (2021-04-08 18:15 UTC)
* AppStream (3.7.1.0)
	* This release provides support for image updates
* AutoScaling (3.7.1.0)
	* Amazon EC2 Auto Scaling announces Warm Pools that help applications to scale out faster by pre-initializing EC2 instances and save money by requiring fewer continuously running instances
* CustomerProfiles (3.7.1.8)
	* Documentation updates for Put-Integration API
* KinesisVideoArchivedMedia (3.7.0.9)
	* Documentation updates for archived.kinesisvideo
* LookoutEquipment (3.7.0.0)
	* This release introduces support for Amazon Lookout for Equipment.
* RAM (3.7.0.9)
	* Documentation updates for AWS RAM resource sharing
* RoboMaker (3.7.1.0)
	* This release allows RoboMaker customers to specify custom tools to run with their simulation job
* Core 3.7.0.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.10.0 (2021-04-07 18:13 UTC)
* AccessAnalyzer (3.7.1.0)
	* IAM Access Analyzer now analyzes your CloudTrail events to identify actions and services that have been used by an IAM entity (user or role) and generates an IAM policy that is based on that activity.
* ElastiCache (3.7.1.0)
	* This release adds tagging support for all AWS ElastiCache resources except Global Replication Groups.
* IVS (3.7.1.0)
	* This release adds support for the Auto-Record to S3 feature. Amazon IVS now enables you to save your live video to Amazon S3.
* Mgn (3.7.0.0)
	* Add new service - Application Migration Service.
* StorageGateway (3.7.1.0)
	* File Gateway APIs now support FSx for Windows as a cloud storage.
* Core 3.7.0.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.9.0 (2021-04-06 18:13 UTC)
* Cloud9 (3.7.1.4)
	* Documentation updates for Cloud9
* EC2 (3.7.3.0)
	* This release adds support for storing EBS-backed AMIs in S3 and restoring them from S3 to enable cross-partition copying of AMIs
* MediaLive (3.7.2.0)
	* MediaLive VPC outputs update to include Availability Zones, Security groups, Elastic Network Interfaces, and Subnet Ids in channel response
* SimpleSystemsManagement (3.7.1.0)
	* Supports removing a label or labels from a parameter, enables ScheduledEndTime and ChangeDetails for StartChangeRequestExecution API, supports critical/security/other noncompliant count for patch API.

### 3.7.8.0 (2021-04-05 18:14 UTC)
* Appflow (3.7.1.0)
	* Added destination properties for Zendesk.
* AuditManager (3.7.1.0)
	* AWS Audit Manager has updated the GetAssessment API operation to include a new response field called userRole. The userRole field indicates the role information and IAM ARN of the API caller.
* MediaLive (3.7.1.0)
	* MediaLive now support HTML5 Motion Graphics overlay

### 3.7.7.0 (2021-04-02 18:14 UTC)
* Imagebuilder (3.7.1.0)
	* This release adds support for Block Device Mappings for container image builds, and adds distribution configuration support for EC2 launch templates in AMI builds.
* MediaPackage (3.7.1.0)
	* SPEKE v2 is an upgrade to the existing SPEKE API to support multiple encryption keys, based on an encryption contract selected by the customer.
* Core 3.7.0.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.6.0 (2021-04-01 18:17 UTC)
* EC2 (3.7.2.0)
	* VPC Flow Logs Service adds a new API, GetFlowLogsIntegrationTemplate, which generates CloudFormation templates for Athena. For more info, see https://docs.aws.amazon.com/console/vpc/flow-logs/athena
* FMS (3.7.1.0)
	* Added Firewall Manager policy support for AWS Route 53 Resolver DNS Firewall.
* Kendra (3.7.1.0)
	* AWS Kendra's ServiceNow data source now supports OAuth 2.0 authentication and knowledge article filtering via a ServiceNow query.
* Lex (3.7.1.0)
	* Amazon Lex now supports base64-encoded message and input transcript fields.
* LexModelBuildingService (3.7.1.0)
	* Lex now supports the ja-JP locale
* Lightsail (3.7.1.0)
	* - This release adds support for state detail for Amazon Lightsail container services.
* MediaConvert (3.7.1.0)
	* MediaConvert now supports HLS ingest, sidecar WebVTT ingest, Teletext color & style passthrough to TTML subtitles, TTML to WebVTT subtitle conversion with style, & DRC profiles in AC3 audio.
* Route53Resolver (3.7.1.0)
	* Route 53 Resolver DNS Firewall is a firewall service that allows you to filter and regulate outbound DNS traffic for your VPCs.
* WAFV2 (3.7.2.0)
	* Added support for ScopeDownStatement for ManagedRuleGroups, Labels, LabelMatchStatement, and LoggingFilter. For more information on these features, see the AWS WAF Developer Guide.
* Core 3.7.0.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.5.1 (2021-03-31 20:56 UTC)
* Core 3.7.0.6
	* Evict cache keys that are more than 1 hour old during endpoint discovery.
	* All services packages updated to require new Core

### 3.7.5.0 (2021-03-31 18:24 UTC)
* Batch (3.7.1.0)
	* AWS Batch adds support for Amazon EFS File System
* Cloud9 (3.7.1.0)
	* Add ImageId input parameter to CreateEnvironmentEC2 endpoint. New parameter enables creation of environments with different AMIs.
* CloudFormation (3.7.1.0)
	* 1. Added a new parameter "RegionConcurrencyType" in OperationPreferences. 2. Changed the name of "AccountUrl" to "AccountsUrl" in "DeploymentTargets" parameter.
* CloudHSM (3.7.1.0)
	* Minor documentation and link updates.
* CognitoSync (3.7.1.0)
	* Minor documentation updates and link updates.
* Comprehend (3.7.1.0)
	* Support for customer managed KMS encryption of Comprehend custom models
* DataPipeline (3.7.1.0)
	* Minor documentation updates and link updates.
* Detective (3.7.1.0)
	* Added the ability to assign tag values to Detective behavior graphs. Tag values can be used for attribute-based access control, and for cost allocation for billing.
* DirectConnect (3.7.1.0)
	* This release adds MACsec support to AWS Direct Connect
* IoT (3.7.1.0)
	* Added ability to prefix search on attribute value for ListThings API.
* IoTWireless (3.7.2.0)
	* Add Sidewalk support to APIs: GetWirelessDevice, ListWirelessDevices, GetWirelessDeviceStatistics. Add Gateway connection status in GetWirelessGatewayStatistics API.
* MachineLearning (3.7.1.0)
	* Minor documentation updates and link updates.
* Pricing (3.7.1.0)
	* Minor documentation and link updates.
* Redshift (3.7.1.0)
	* Enable customers to share access to their Redshift clusters from other VPCs (including VPCs from other accounts).
* TranscribeService (3.7.2.0)
	* Amazon Transcribe now supports creating custom language models in the following languages: British English (en-GB), Australian English (en-AU), Indian Hindi (hi-IN), and US Spanish (es-US).
* WorkMail (3.7.1.0)
	* This release adds support for mobile device access rules management in Amazon WorkMail.
* Core 3.7.0.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.4.0 (2021-03-30 18:21 UTC)
* CloudWatch (3.7.1.0)
	* SDK update for new Metric Streams feature
* ConfigService (3.7.1.0)
	* Adding new APIs to support ConformancePack Compliance CI in Aggregators
* EC2 (3.7.1.0)
	* ReplaceRootVolume feature enables customers to replace the EBS root volume of a running instance to a previously known state. Add support to grant account-level access to the EC2 serial console
* EC2InstanceConnect (3.7.1.0)
	* Adding support to push SSH keys to the EC2 serial console in order to allow an SSH connection to your Amazon EC2 instance's serial port.
* FraudDetector (3.7.1.0)
	* This release adds support for Batch Predictions in Amazon Fraud Detector.
* GlueDataBrew (3.7.1.0)
	* This SDK release adds two new dataset features: 1) support for specifying a database connection as a dataset input 2) support for dynamic datasets that accept configurable parameters in S3 path.
* Pinpoint (3.7.1.0)
	* Added support for journey pause/resume, journey updatable import segment and journey quiet time wait.
* SageMaker (3.7.1.0)
	* Amazon SageMaker Autopilot now supports 1) feature importance reports for AutoML jobs and 2) PartialFailures for AutoML jobs
* Core 3.7.0.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.3.0 (2021-03-29 18:16 UTC)
* DocDB (3.7.1.0)
	* This release adds support for Event Subscriptions to DocumentDB.
* Glue (3.7.1.0)
	* Allow Dots in Registry and Schema Names for CreateRegistry, CreateSchema; Fixed issue when duplicate keys are present and not returned as part of QuerySchemaVersionMetadata.
* IdentityManagement (3.7.1.0)
	* AWS Identity and Access Management GetAccessKeyLastUsed API will throw a custom error if customer public key is not found for access keys.
* LocationService (3.7.1.0)
	* Amazon Location added support for specifying pricing plan information on resources in alignment with our cost model.
* WAFV2 (3.7.1.0)
	* Added custom request handling and custom response support in rule actions and default action; Added the option to inspect the web request body as parsed and filtered JSON.
* Core 3.7.0.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.2.1 (2021-03-26 22:36 UTC)
* CloudSearchDomain (3.7.0.2)
	* Doc update
* DynamoDBv2 (3.7.0.2)
	* Added TryLoadTable overload 
* RDSDataService (3.7.0.2)
	* Doc update
* S3 (3.7.0.2)
	* Make DownloadFilesConcurrently in TransferUtilityDownloadDirectoryRequest Accessible for .NET Standard
* SimpleNotificationService (3.7.0.2)
	* Updated to use new Core, version 3.7.0.2
	* Update AuthorizeS3ToPublish to set account id as condition in IAM policy.  Fixed null ref using utility method parsing messages
* SQS (3.7.0.2)
	* Updated to use new Core, version 3.7.0.2
	* Update AuthorizeS3ToPublish to set account id as condition in IAM policy
* Core 3.7.0.2
	* Removed unused regular expression definition,  RedirectHandler adds port number to redirected endpoint

### 3.7.2.0 (2021-03-26 18:17 UTC)
* CloudWatchEvents (3.7.1.0)
	* Add support for SageMaker Model Builder Pipelines Targets to EventBridge
* CustomerProfiles (3.7.1.0)
	* This release adds an optional parameter named FlowDefinition in PutIntegrationRequest.
* EventBridge (3.7.1.0)
	* Add support for SageMaker Model Builder Pipelines Targets to EventBridge
* IoTWireless (3.7.1.0)
	* Support tag-on-create for WirelessDevice.
* TranscribeService (3.7.1.0)
	* Amazon Transcribe now supports tagging words that match your vocabulary filter for batch transcription.
* Core 3.7.0.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.7.1.0 (2021-03-26 04:10 UTC)
* LookoutMetrics (3.7.1.0)
	* Allowing uppercase alphabets for RDS and Redshift database names.

### 3.7.0.0 (2021-03-25 21:00 UTC)
* All (Core and Services) updated to version 3.7.0.0
  * Removes support for .NET Standard 1.3

### 3.5.138.0 (2021-03-25 18:18 UTC)
* AlexaForBusiness (3.5.2.0)
	* Added support for enabling and disabling data retention in the CreateProfile and UpdateProfile APIs and retrieving the state of data retention for a profile in the GetProfile API.
* LookoutMetrics (3.5.0.0)
	* Amazon Lookout for Metrics is now generally available. You can use Lookout for Metrics to monitor your data for anomalies. For more information, see the Amazon Lookout for Metrics Developer Guide.
* MediaLive (3.5.14.0)
	* EML now supports handling HDR10 and HLG 2020 color space from a Link input.
* Rekognition (3.5.3.0)
	* "This release introduces AWS tagging support for Amazon Rekognition collections, stream processors, and Custom Label models."
* SageMaker (3.5.15.0)
	* This feature allows customer to specify the environment variables in their CreateTrainingJob requests.
* SQS (3.5.1.28)
	* Documentation updates for Amazon SQS
* Core 3.5.3.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.137.0 (2021-03-24 18:15 UTC)
* EC2 (3.5.35.0)
	* maximumEfaInterfaces added to DescribeInstanceTypes API
* Greengrass (3.5.2.0)
	* Updated the parameters to make name required for CreateGroup API.
* Route53 (3.5.1.29)
	* Documentation updates for route53
* S3 (3.5.10.1)
	* Documentation updates for Amazon S3
* S3Control (3.5.6.1)
	* Documentation updates for s3-control
* SimpleSystemsManagement (3.5.12.0)
	* This release allows SSM Explorer customers to enable OpsData sources across their organization when creating a resource data sync.

### 3.5.136.0 (2021-03-23 18:17 UTC)
* CostExplorer (3.5.9.0)
	* You can now create cost categories with inherited value rules and specify default values for any uncategorized costs.
* FIS (3.5.1.0)
	* Updated maximum allowed size of action parameter from 64 to 1024
* GameLift (3.5.5.0)
	* GameLift adds support for using event notifications to monitor game session placements. Specify an SNS topic or use CloudWatch Events to track activity for a game session queue.
* IdentityManagement (3.5.1.10)
	* Documentation updates for IAM operations and descriptions.
* Redshift (3.5.6.0)
	* Removed APIs to control AQUA on clusters.

### 3.5.135.0 (2021-03-22 18:12 UTC)
* CodeArtifact (3.5.2.38)
	* Documentation updates for CodeArtifact
* EC2 (3.5.34.0)
	* This release adds support for UEFI boot on selected AMD- and Intel-based EC2 instances.
* Macie2 (3.5.10.0)
	* This release of the Amazon Macie API adds support for publishing sensitive data findings to AWS Security Hub and specifying which categories of findings to publish to Security Hub.
* Redshift (3.5.5.0)
	* Added support to enable AQUA in Amazon Redshift clusters.

### 3.5.134.0 (2021-03-19 18:12 UTC)
* EC2 (3.5.33.0)
	* X2gd instances are the next generation of memory-optimized instances powered by AWS-designed, Arm-based AWS Graviton2 processors.
* SageMaker (3.5.14.0)
	* Adding authentication support for pulling images stored in private Docker registries to build containers for real-time inference.

### 3.5.133.0 (2021-03-18 19:12 UTC)
* AutoScaling (3.5.6.0)
	* Amazon EC2 Auto Scaling Instance Refresh now supports phased deployments.
* Redshift (3.5.4.0)
	* Add new fields for additional information about VPC endpoint for clusters with reallocation enabled, and a new field for total storage capacity for all clusters.
* S3 (3.5.10.0)
	* S3 Object Lambda is a new S3 feature that enables users to apply their own custom code to process the output of a standard S3 GET request by automatically invoking a Lambda function with a GET request
* S3Control (3.5.6.0)
	* S3 Object Lambda is a new S3 feature that enables users to apply their own custom code to process the output of a standard S3 GET request by automatically invoking a Lambda function with a GET request
* SecurityHub (3.5.6.0)
	* New object for separate provider and customer values. New objects track S3 Public Access Block configuration and identify sensitive data. BatchImportFinding requests are limited to 100 findings.

### 3.5.132.0 (2021-03-17 18:12 UTC)
* Batch (3.5.6.0)
	* Making serviceRole an optional parameter when creating a compute environment. If serviceRole is not provided then Service Linked Role will be created (or reused if it already exists).
* SageMaker (3.5.13.0)
	* Support new target device ml_eia2 in SageMaker CreateCompilationJob API
* Core 3.5.3.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.131.0 (2021-03-16 18:20 UTC)
* AccessAnalyzer (3.5.4.0)
	* This release adds support for the ValidatePolicy API. IAM Access Analyzer is adding over 100 policy checks and actionable recommendations that help you validate your policies during authoring.
* GameLift (3.5.4.0)
	* GameLift expands to six new AWS Regions, adds support for multi-location fleets to streamline management of hosting resources, and lets you customize more of the game session placement process.
* IdentityManagement (3.5.1.8)
	* Documentation updates for AWS Identity and Access Management (IAM).
* Lambda (3.5.9.0)
	* Allow empty list for function response types
* MediaConnect (3.5.2.0)
	* This release adds support for the SRT-listener protocol on sources and outputs.
* MediaTailor (3.5.4.0)
	* MediaTailor channel assembly is a new manifest-only service that allows you to assemble linear streams using your existing VOD content.
* MWAA (3.5.2.0)
	* This release adds UPDATE_FAILED and UNAVAILABLE MWAA environment states.

### 3.5.130.1 (2021-03-15 21:30 UTC)
* GroundStation (3.5.1.50)
	* Updated description for GroundStation
* Core 3.5.3.7
	* Force s3-object-lambda to use UNSIGNED_PAYLOAD and removed -local off of the Osaka region endpoint
	* All services packages updated to require new Core

### 3.5.130.0 (2021-03-15 18:27 UTC)
* CodeDeploy (3.5.1.0)
	* AWS CodeDeploy can now detect instances running an outdated revision of your application and automatically update them with the latest revision.
* ECS (3.5.4.0)
	* This is for ecs exec feature release which includes two new APIs - execute-command and update-cluster and an AWS CLI customization for execute-command API
* ElasticMapReduce (3.5.6.0)
	* Amazon EMR customers can now specify Resource Group to target Capacity Reservations in their EMR clusters with instance fleets using allocation strategy.
* FIS (3.5.0.0)
	* Initial release of AWS Fault Injection Simulator, a managed service that enables you to perform fault injection experiments on your AWS workloads

### 3.5.129.0 (2021-03-12 19:29 UTC)
* CostAndUsageReport (3.5.2.0)
	* - Added optional billingViewArn field for OSG.
* MediaTailor (3.5.3.0)
	* MediaTailor channel assembly is a new manifest-only service that allows you to assemble linear streams using your existing VOD content.
* WorkSpaces (3.5.4.0)
	* Adds API support for WorkSpaces bundle management operations.

### 3.5.128.0 (2021-03-11 19:14 UTC)
* Comprehend (3.5.4.0)
	* ContainsPiiEntities API analyzes the input text for the presence of personally identifiable information(PII) and returns the labels of identified PII entity types such as name, address etc.
* MediaLive (3.5.13.0)
	* MediaLive supports the ability to apply a canned ACL to output sent to an AWS S3 bucket; supports ability to specify position for EBU-TT and TTML output captions converted from Teletext source.
* NetworkFirewall (3.5.1.2)
	* Correct the documentation about how you can provide rule group rules
* WAFV2 (3.5.2.7)
	* Correct the documentation about JSON body parsing behavior and IP set update behavior

### 3.5.127.0 (2021-03-10 19:52 UTC)
* AccessAnalyzer (3.5.3.0)
	* This release adds support to preview IAM Access Analyzer findings for a resource before deploying resource permission changes.
* Backup (3.5.3.0)
	* Added support for enabling continuous backups.
* S3 (3.5.9.6)
	* Updated documentation for the ID element in the CORSRule schema
* SimpleSystemsManagement (3.5.11.0)
	* Systems Manager support for tagging OpsMetadata.

### 3.5.126.0 (2021-03-09 19:15 UTC)
* AutoScaling (3.5.5.0)
	* EC2 Auto Scaling now supports setting a local time zone for cron expressions in scheduled actions, removing the need to adjust for Daylight Saving Time (DST)
* CodeGuruProfiler (3.5.1.0)
	* Update documentation to include Python. Add ConflictException for DeleteProfilingGroup. Add FrameMetricValue.
* ElasticFileSystem (3.5.1.0)
	* AWS EFS is introducing one-zone file systems.
* IoTWireless (3.5.4.0)
	* Add max value to Seq in SendDataToWirelessDevice API"
* RDS (3.5.14.0)
	* This release adds support for Amazon RDS Proxy endpoints.
* Core 3.5.3.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.125.0 (2021-03-08 19:23 UTC)
* AutoScaling (3.5.4.4)
	* Documentation updates for autoscaling for capacity-optimized-prioritized SpotAllocationStrategy
* ElasticMapReduce (3.5.5.0)
	* Amazon EMR customers can now specify how EC2 On-Demand Capacity Reservations are used in their EMR clusters with instance fleets using allocation strategy.
* KinesisVideoArchivedMedia (3.5.2.0)
	* Increase the maximum HLS and MPEG-DASH manifest size from 1,000 to 5,000 fragments.
* Lambda (3.5.8.0)
	* Documentation updates for Lambda. Constraint updates to AddLayerVersionPermission's Action and OrganizationId parameters, and AddPermission's Principal and SourceAccount parameters.
* S3 (3.5.9.4)
	* Amazon S3 Documentation updates
* S3Control (3.5.5.12)
	* Documentation updates for Amazon S3

### 3.5.124.0 (2021-03-05 19:22 UTC)
* Appflow (3.5.4.4)
	* Documentation updates for arn:aws:trebuchet:::service:v1:decb008d-e0d8-44a4-b93c-092f0355d523
* Athena (3.5.2.0)
	* Adds APIs to create, list, update, and delete prepared SQL statements that have optional placeholder parameters. A prepared statement can use different values for these parameters each time it is run.
* CodePipeline (3.5.5.0)
	* Updated the parameters to make actionType required for UpdateActionType
* EC2 (3.5.32.0)
	* Expands EC2/Spot Fleet capacity-optimized allocation strategy to allow users to prioritize instance pools. Fleet attempts to fulfill priorities on a best-effort basis but optimizes for capacity first.
* LicenseManager (3.5.4.0)
	* License Manager Automated Discovery now supports Exclusion Filters.
* MediaLive (3.5.12.0)
	* Medialive now supports the ability to transfer AWS Elemental Link devices to another region.
* NetworkFirewall (3.5.1.0)
	* Added a new UpdateToken output field to the PerObjectStatus as part of firewall sync state. This is added to track which version of the object the firewall is in sync or pending synchronization.
* Shield (3.5.2.0)
	* Add support for tagging of Shield protection and protection group resources.

### 3.5.123.1 (2021-03-05 00:08 UTC)
* AccessAnalyzer (3.5.2.12)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* CodeGuruProfiler (3.5.0.75)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* IoTFleetHub (3.5.0.26)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* IoTSiteWise (3.5.8.7)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* PrometheusService (3.5.0.26)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* WellArchitected (3.5.1.2)
	* Update generator to provide a default value for idempotency tokens passed via querystring
* Core 3.5.3.5
	* Fixes an issue where signature mismatch error occurs when user metadata keys contain _ (underscore) and User agent reverted to aws-sdk-dotnet-coreclr
	* All services packages updated to require new Core

### 3.5.123.0 (2021-03-04 19:15 UTC)
* CloudWatchEvents (3.5.6.0)
	* Introducing support for EventBridge Api Destinations - any HTTP APIs as Targets, with managed authorization via EventBridge Connections.
* EventBridge (3.5.6.0)
	* Introducing support for EventBridge Api Destinations - any HTTP APIs as Targets, with managed authorization via EventBridge Connections.
* MWAA (3.5.1.0)
	* This release introduces a new MinWorker parameter to the CreateEnvironment and UpdateEnvironment APIs. MinWorker allows the users to set a minimum worker count for worker auto-scaling operations.
* SageMaker (3.5.12.0)
	* This release adds the ResolvedOutputS3Uri to the DescribeFeatureGroup API to indicate the S3 prefix where offline data is stored in a feature group
* ServiceDiscovery (3.5.2.0)
	* Supports creating API-only services under DNS namespace.  Add namespace syntax validation.
* Core 3.5.3.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.122.0 (2021-03-03 19:20 UTC)
* CertificateManager (3.5.1.0)
	* Adds 2 new APIs to add and retrieve account configuration in AWS Certificate Manager.
* CloudWatchEvents (3.5.5.0)
	* Adds TraceHeader to PutEventsRequestEntry to support AWS X-Ray trace-ids on events generated using the PutEvents operation.
* CodeBuild (3.5.6.0)
	* AWS CodeBuild now supports Session Manager debugging for batch builds.
* Elasticsearch (3.5.7.0)
	* AWS ElasticSearch Feature : Support for adding tags in elastic search domain during domain creation
* ForecastService (3.5.4.0)
	* Added new StopResource operation that stops Amazon Forecast resource jobs that are in progress.
* Macie2 (3.5.9.4)
	* This release of the Amazon Macie API includes miscellaneous updates and improvements to the documentation.
* SecretsManager (3.5.1.0)
	* Added support for multi-Region secrets APIs ReplicateSecretToRegions, RemoveRegionsFromReplication, and StopReplicationToReplica
* WellArchitected (3.5.1.0)
	* This release supports tagging on AWS Well-Architected workloads.

### 3.5.121.0 (2021-03-02 19:14 UTC)
* ComputeOptimizer (3.5.3.20)
	* Documentation updates for Compute Optimizer
* DataSync (3.5.3.0)
	* Additional API Support to update NFS/SMB/ObjectStorage locations
* DirectConnect (3.5.0.74)
	* Doc only update for AWS Direct Connect that fixes several customer-reported issues
* EventBridge (3.5.5.0)
	* Adds TraceHeader to PutEventsRequestEntry to support AWS X-Ray trace-ids on events generated using the PutEvents operation.
* IoTWireless (3.5.3.0)
	* Add ARN & Tags for PartnerAccount related APIs and WirelessGatewayTaskDefinition related APIs
* ManagedBlockchain (3.5.3.10)
	* Updates for Ethereum general availability release.

### 3.5.120.0 (2021-03-01 19:14 UTC)
* AlexaForBusiness (3.5.1.0)
	* Added support for optional tags in CreateAddressBook, CreateConferenceProvider, CreateContact, CreateGatewayGroup, CreateNetworkProfile and RegisterAVSDevice APIs.
* CodePipeline (3.5.4.0)
	* Added a new field to the ListPipelines API to allow maximum search results of 1000
* EKS (3.5.6.0)
	* Adding new error code AdmissionRequestDenied for Addons in EKS
* SimpleSystemsManagement (3.5.10.0)
	* Add Support for Patch Manger Baseline Override parameter.
* Core 3.5.3.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.119.0 (2021-02-26 19:13 UTC)
* EKS (3.5.5.0)
	* Amazon EKS now supports adding KMS envelope encryption to existing clusters to enhance security for secrets
* ElasticMapReduce (3.5.4.0)
	* Added UpdateStudio API that allows updating a few attributes of an EMR Studio.
* S3 (3.5.9.0)
	* Add RequestPayer to GetObjectTagging and PutObjectTagging.
* SSOAdmin (3.5.2.0)
	* Relax constraint on List* API pagination tokens to include underscore character

### 3.5.118.0 (2021-02-25 19:13 UTC)
* Detective (3.5.2.0)
	* Changed "master account" to "administrator account." A new AdministratorId field replaces the deprecated MasterId field. Added an option to disable email notifications for member account invitations.
* GlueDataBrew (3.5.4.0)
	* This SDK release adds two new dataset features: 1) support for specifying the file format for a dataset, and 2) support for specifying whether the first row of a CSV or Excel file contains a header.
* Imagebuilder (3.5.4.0)
	* This release introduces a new API (ListImagePackages) for listing packages installed on an image, and adds support for GP3 volume types, and for specifying a time zone in an image pipeline schedule.
* Lightsail (3.5.2.15)
	* Documentation updates for Lightsail
* Transfer (3.5.3.0)
	* Corrected the upper limit for TestIdentityProvider input lengths to 1024 characters

### 3.5.117.0 (2021-02-24 19:43 UTC)
* Appflow (3.5.4.0)
	* # Adding 'Amazon Honeycode' , 'Amazon Lookout for Metrics' and  'Amazon Connect Customer Profiles' as Destinations.
* ComputeOptimizer (3.5.3.18)
	* Documentation updates for Compute Optimizer
* ECRPublic (3.5.1.0)
	* This release adds support for AWS tags on Amazon ECR Public repositories.
* Elasticsearch (3.5.6.0)
	* Amazon Elasticsearch Service now supports Auto-Tune, which monitors performance metrics and automatically optimizes domains
* MediaPackageVod (3.5.1.0)
	* AWS Elemental MediaPackage provides access logs that capture detailed information about requests sent to a customer's MediaPackage VOD packaging group.

### 3.5.116.0 (2021-02-23 19:15 UTC)
* AutoScaling (3.5.4.0)
	* Adds a new optional IncludeDeletedGroups parameter to the DescribeScalingActivities API.
* Connect (3.5.6.7)
	* Documentation updates for AWS Connect (MediaConcurrency Limit).
* Glue (3.5.11.0)
	* Updating the page size for Glue catalog getter APIs.
* IoTEvents (3.5.1.0)
	* This release adds an Analyze feature to AWS IoT Events that lets customers analyze their detector models for runtime issues.
* Pinpoint (3.5.4.0)
	* Enables AWS Pinpoint customers to use Entity Id and Template Id when sending SMS message. These parameters can be obtained from the regulatory body of the country where you are trying to send the SMS.
* QuickSight (3.5.11.3)
	* Documentation updates for QuickSight Row Level Security
* RedshiftDataAPIService (3.5.2.0)
	* This release adds an additional parameter 'ConnectedDatabase' into ListSchemasRequest, ListTablesRequest and DescribeTableRequest to support the metadata sharing across databases.
* S3Control (3.5.5.8)
	* Documentation updates for s3-control
* Core 3.5.3.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.115.0 (2021-02-22 19:21 UTC)
* SageMaker (3.5.11.0)
	* Amazon SageMaker now supports core dump for SageMaker Endpoints and direct invocation of a single container in a SageMaker Endpoint that hosts multiple containers.
* SageMakerRuntime (3.5.2.0)
	* SageMaker Runtime now supports a new TargetContainerHostname header to invoke a model in a specific container if the endpoint hosts multiple containers and is configured to use direct invocation.

### 3.5.114.0 (2021-02-19 19:13 UTC)
* RDS (3.5.13.0)
	* Added awsBackupRecoveryPointArn in ModifyDBInstanceRequest and in the response of ModifyDBInstance.
* Core 3.5.3.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.113.0 (2021-02-18 22:12 UTC)
* S3 (3.5.8.6)
	* Updated to use new Core, version 3.5.3.0
	* Fixes an issue where S3.Utils.AmazonS3Uri.IsAmazonS3Endpoint throws InvalidOperationException for relative URIs; Support for reloading RegionEndpoint data (endpoints.json)
* S3Control (3.5.5.6)
	* Updated to use new Core, version 3.5.3.0
	* Support for reloading RegionEndpoint data (endpoints.json)
* SecurityToken (3.5.1.51)
	* Updated to use new Core, version 3.5.3.0
	* Support for reloading RegionEndpoint data (endpoints.json)
* Core 3.5.3.0
	* Elaborated API documentation for ClientConfig RegionEndpoint and ServiceURL properties; Fixes EC2InstanceMetadata threading issue; Support for reloading RegionEndpoint data (endpoints.json)

### 3.5.112.0 (2021-02-18 19:20 UTC)
* AWSHealth (3.5.0.71)
	* Documentation updates for health
* CloudFormation (3.5.3.0)
	* Adding the 'callAs' parameter to all CloudFormation StackSets APIs except getTemplateSummary to support creating and managing service-managed StackSets with AWS Organizations Delegated Administrators
* CodeBuild (3.5.5.0)
	* AWS CodeBuild now allows you to specify a separate bucket owner as part of the S3 destination in a report group.
* SageMaker (3.5.10.0)
	* This release adds expires-in-seconds parameter to the CreatePresignedDomainUrl API for support of a configurable TTL.

### 3.5.111.0 (2021-02-17 19:12 UTC)
* ConfigService (3.5.5.0)
	* Added INSUFFICIENT_DATA in ConformancePackComplianceType.
* EC2 (3.5.31.5)
	* This release includes a new filter for describe-vpc-endpoint-services.
* LookoutforVision (3.5.2.0)
	* This release for Amazon Lookout for Vision includes documentation updates and a correction to the Status field returned in the response from StartModel and StopModel.

### 3.5.110.0 (2021-02-16 19:13 UTC)
* CodeBuild (3.5.4.0)
	* This release provides per-project limits for the number of concurrent builds
* DevOpsGuru (3.5.3.0)
	* Amazon DevOps Guru is GA ready. This API update added a describeFeedback Api allows users to view submitted insight feedback. The release date is 02/16/2021

### 3.5.109.0 (2021-02-15 19:30 UTC)
* ConfigService (3.5.4.0)
	* Added option to provide KMS key to AWS Config DeliveryChannel
* KinesisVideoArchivedMedia (3.5.1.0)
	* The ListFragments and GetMediaForFragmentList APIs now support StreamName or StreamARN as input parameters.
* Lightsail (3.5.2.12)
	* Documentation updates for Lightsail
* MediaLive (3.5.11.0)
	* AWS MediaLive now supports Automatic-Input-Failover for CDI Inputs.
* MediaTailor (3.5.2.0)
	* MediaTailor now supports specifying aliases for dynamic variables. This allows use cases such as binding multiple origin domains to a single MediaTailor playback configuration.
* Pinpoint (3.5.3.0)
	* Lets customers use origination number when specifying SMS message configuration for Campaigns and Journeys.
* RedshiftDataAPIService (3.5.1.0)
	* This release enables fine grant access control in ListStatements, GetStatementResult, CancelStatement and DescribeStatement.
* WorkMailMessageFlow (3.5.1.0)
	* This release allows customers to update email messages as they flow in and out of Amazon WorkMail

### 3.5.108.0 (2021-02-12 19:18 UTC)
* AppSync (3.5.2.0)
	* Approve release for appsync local on pipeline resolver
* CodePipeline (3.5.3.0)
	* The release provides new GetActionType and UpdateActionType APIs for viewing and editing action types in CodePipeline.
* Detective (3.5.1.0)
	* The API definition now indicates that the format for timestamps is an ISO 8601 date-time string
* EKS (3.5.4.0)
	* Amazon EKS now supports OpenId Connect (OIDC) compatible identity providers as a user authentication option
* ElasticLoadBalancingV2 (3.5.5.33)
	* Adds a target group attribute for application-based stickiness for Application Load Balancers and an update to the client IP preservation attribute for Network Load Balancers.
* IdentityManagement (3.5.1.0)
	* AWS Identity and Access Management now supports tagging for the following resources: customer managed policies, identity providers, instance profiles, server certificates, and virtual MFA devices.
* Macie2 (3.5.9.0)
	* This release of the Amazon Macie API replaces the term master account with the term administrator account, including deprecating APIs that use the previous term and adding APIs that use the new term.
* PersonalizeEvents (3.5.2.0)
	* Increased maximum char size of PutUsers and PutItems properties.
* RDS (3.5.12.0)
	* EngineMode in the response of DescribeDBClusterSnapshots. SupportedEngineModes, SupportsParallelQuery and SupportsGlobalDatabases in ValidUpgradeTarget of DBEngineVersions in DescribeDBEngineVersions.
* WAFV2 (3.5.2.0)
	* Added the option to inspect the web request body as parsed and filtered JSON (new FieldToMatch type JsonBody), in addition to the existing option to inspect the web request body as plain text.
* Core 3.5.2.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.107.0 (2021-02-11 19:12 UTC)
* GlueDataBrew (3.5.3.0)
	* This release adds support for profile job sampling, which determines the number of rows on which the profile job will be executed.
* RDS (3.5.11.0)
	* Adding support for RDS Aurora Global Database Failover

### 3.5.106.0 (2021-02-09 19:13 UTC)
* GameLift (3.5.3.0)
	* GameLift FleetIQ users can now use AMD instance families in supported Regions. In addition, FlexMatch matchmaking notification now supports SNS FIFO topics.
* MediaConvert (3.5.6.0)
	* AWS Elemental MediaConvert SDK has added support for WMA audio only ingest, SMPTE-TT text and image caption ingest, and MPEG-2 video in MXF OP1a outputs.
* QLDBSession (3.5.2.0)
	* This release adds CapacityExceededException to the AWS QLDBSession API.
* QuickSight (3.5.11.0)
	* QuickSight now supports Python's paginators for Exploration APIs.
* SageMaker (3.5.9.0)
	* Add a new optional FrameworkVersion field to Sagemaker Neo CreateCompilationJob API
* Core 3.5.2.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.105.0 (2021-02-08 19:14 UTC)
* CloudTrail (3.5.3.0)
	* ConflictException is now thrown when certain operations are called on resources before CloudTrail has time to load the resources. Two new exceptions have been added to the PutInsightSelectors API.
* DataExchange (3.5.1.0)
	* This release introduces the new ExportRevision job type, which allows for the export of an entire revision.
* ElastiCache (3.5.2.5)
	* Documentation updates for elasticache
* ElasticLoadBalancingV2 (3.5.5.31)
	* Adds a target group attribute for application-based stickiness for Application Load Balancers.
* GlobalAccelerator (3.5.4.0)
	* Global Accelerator now supports bringing your own IP addresses for custom routing accelerators
* IoTSiteWise (3.5.8.0)
	* Recall CreatePresignedPortalUrl API
* IVS (3.5.1.0)
	* Fixed an issue where StreamStartTime could not be unmarshalled from response. Changed DeleteChannel and DeleteStreamKey response codes to 204.
* Macie2 (3.5.8.0)
	* This release of the Amazon Macie API adds support for specifying a time range in queries for usage data.
* Core 3.5.2.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.104.0 (2021-02-05 19:19 UTC)
* ElasticLoadBalancingV2 (3.5.5.30)
	* Adds a target group attribute for client IP preservation for Network Load Balancers.
* Macie (3.5.0.67)
	* Documentation updates for Amazon Macie Classic. We replaced the term "master account" with the term "administrator account." An administrator account is used to centrally manage multiple accounts.
* Organizations (3.5.2.0)
	* Added support for a few additional exception codes for some AWS Organizations APIs.
* Core 3.5.2.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.103.0 (2021-02-04 21:14 UTC)
* Appflow (3.5.3.0)
	* Adding schedule offset as an input for scheduled flows in CreateFlow API. Also, adding data pull start time and data pull end time for DescribeFlowExecutionRecords API response.
* Athena (3.5.1.0)
	* Adds the Athena ListEngineVersions action and the EngineVersion data type. ListEngineVersions returns the available Athena engine versions, including Auto, as a list of EngineVersion objects.
* DLM (3.5.4.0)
	* Provide support for EBS Local Snapshots on AWS Outpost in Data Lifecycle Manager (DLM).
* EC2 (3.5.31.0)
	* AWS Outposts now supports EBS local snapshots on Outposts that allows customers to store snapshots of EBS volumes and AMIs locally on S3 on Outposts.
* EMRContainers (3.5.1.0)
	* This release is to correct the timestamp format to ISO8601 for the date parameters in the describe and list API response objects of Job Run and Virtual Clusters.
* QuickSight (3.5.10.0)
	* API release for field folders feature.
* Core 3.5.2.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.102.0 (2021-02-03 19:18 UTC)
* AuditManager (3.5.2.0)
	* This release adds AccessDeniedException to GetServicesInScope API.
* CodeBuild (3.5.3.24)
	* Documentation updates for codebuild
* ComputeOptimizer (3.5.3.10)
	* Documentation updates for Compute Optimizer
* CostExplorer (3.5.8.9)
	* Clarify valid values for the filter parameter for certain APIs.
* EC2 (3.5.30.0)
	* EC2 Public IP now supports API for setting PTR records on Elastic IP address.
* GlueDataBrew (3.5.2.0)
	* This release adds the DescribeJobRun API to allow customers retrieve details of a given job run
* IoTSiteWise (3.5.7.0)
	* Update AccessPolicy API input to support IAM role for IAM mode. Iam role is added as part of accessPolicyIdentity.
* Lambda (3.5.7.0)
	* Support for creating Lambda Functions using 'nodejs14.x'
* SecurityHub (3.5.5.0)
	* Added a ProductArn parameter to DescribeProducts. ProductArn is used to identify the integration to return details for.
* WorkMail (3.5.3.0)
	* Increased maximum length of ipRanges values for Access Control Rules from 10 to 1024.

### 3.5.101.0 (2021-02-02 21:41 UTC)
* S3 (3.5.8.0)
	* Amazon S3 now supports AWS PrivateLink, providing direct access to S3 via a private endpoint within your virtual private network.
* S3Control (3.5.5.0)
	* Amazon S3 now supports AWS PrivateLink, providing direct access to S3 via a private endpoint within your virtual private network.

### 3.5.100.0 (2021-02-02 19:21 UTC)
* ApplicationAutoScaling (3.5.3.0)
	* With this release, scheduled actions of Application Auto Scaling can be created in the local time zone and automatically adjusted according to daylight saving changes.
* AppMesh (3.5.3.0)
	* App Mesh now supports mutual TLS with two-way peer authentication. You can specify client certificates, server-side TLS validation, and matching of Subject Alternative Names.
* IoTWireless (3.5.2.0)
	* Add enum value MqttTopic for Destination ExpressionType, add LoRaWANNetworkServerCertificateId for GetWirelessGatewayCertificate API
* LocationService (3.5.0.16)
	* Doc only update for Amazon Location Maps that fixes a customer related issue regarding MapConfiguration
* LookoutforVision (3.5.1.0)
	* This release includes the General Availability (GA) SDK for Amazon Lookout for Vision. New for GA is tagging support for Amazon Lookout for Vision models.
* MediaLive (3.5.10.0)
	* AWS Elemental MediaLive now supports Image Media Playlists on HLS outputs, version 0.4 (trick-mode).
* Organizations (3.5.1.53)
	* Documentation updates for AWS Organizations.
* RDSDataService (3.5.1.0)
	* With the Data API, you can now use UUID and JSON data types as input to your database. Also with the Data API, you can now have a LONG type value returned from your database as a STRING value.
* Route53 (3.5.1.15)
	* Documentation updates for Route 53
* S3Control (3.5.4.0)
	* Amazon S3 Batch Operations now supports Delete Object Tagging

### 3.5.99.0 (2021-01-30 00:51 UTC)
* DocDB (3.5.2.0)
	* Support for presignedURL for DocDB
* Neptune (3.5.2.0)
	* Support for presignedURL for Neptune
* Core 3.5.2.5
	* Removed the Obsolete attribute from ActionIdentifier.cs

### 3.5.98.0 (2021-01-29 19:16 UTC)
* Connect (3.5.6.0)
	* Added API to manage queues or get hours of operation for a queue programmatically, which can be used to create new/update queues, or take actions when skills are outside of their hours of operation.
* Macie2 (3.5.7.0)
	* This release of the Amazon Macie API adds support for using object prefixes to refine the scope of a classification job.
* MediaLive (3.5.9.0)
	* "AWS Elemental MediaLive now supports output to a private VPC. When this property is specified, the output will egress from a user specified VPC."
* Core 3.5.2.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.97.1 (2021-01-29 00:47 UTC)
* LexModelsV2 (3.5.0.4)
	* Fixed incorrect Content-Type header being sent to the service

### 3.5.97.0 (2021-01-28 19:16 UTC)
* CloudWatch (3.5.1.0)
	* Update to SDK to support label time zones in CloudWatch GetMetricData
* GlueDataBrew (3.5.1.0)
	* This SDK release adds support for specifying a custom delimiter for input CSV datasets and for CSV job outputs.
* IoT (3.5.7.15)
	* Documentation updates for IoT DeleteOTAUpdate API
* ManagedBlockchain (3.5.3.0)
	* This release supports tagging on Amazon Managed Blockchain resources.
* RoboMaker (3.5.2.0)
	* This release allows Robomaker customers to specify configuration for uploading logs and artifacts generated by their simulation jobs.
* WellArchitected (3.5.0.14)
	* Documentation updates for AWS Well-Architected Tool
* Core 3.5.2.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.96.0 (2021-01-27 19:16 UTC)
* AccessAnalyzer (3.5.2.0)
	* This release adds Secrets Manager secrets as a supported resource in IAM Access Analyzer to help you identify secrets that can be accessed from outside your account or AWS organization.
* CustomerProfiles (3.5.1.0)
	* This release makes Uri a required parameter in GetIntegrationRequest and DeleteIntegrationRequest.
* ElastiCache (3.5.2.0)
	* Add support to pass ParameterGroup name as part updating Engine Version of Global Datastore.
* Elasticsearch (3.5.5.0)
	* Amazon Elasticsearch Service adds support for node-to-node encryption and encryption at rest for existing domains running Elasticsearch version 6.7 and above
* Lightsail (3.5.2.4)
	* Documentation updates for Lightsail
* SimpleEmailV2 (3.5.2.0)
	* This release includes the ability to assign a configuration set to an email identity (a domain or email address), which allows the settings from the configuration set to be applied to the identity.
* Core 3.5.2.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.95.1 (2021-01-26 19:10 UTC)
* Backup (3.5.2.24)
	* Documentation updates for AWS Backup
* Core 3.5.2.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.95.0 (2021-01-22 19:23 UTC)
* EC2 (3.5.29.0)
	* Introducing startDate field for CapacityReservation object for the date and time which the reservation started and adding reserved parameter for ModifyCapacityReservation.
* GreengrassV2 (3.5.0.13)
	* Documentation updates that improve clarity and fix broken links.
* LexModelsV2 (3.5.0.0)
	* This release adds support for Amazon Lex V2 APIs for model building.
* LexRuntimeV2 (3.5.0.0)
	* This release adds support for Amazon Lex V2 APIs for runtime, including Streaming APIs for conversation management.
* RDS (3.5.10.3)
	* Documentation updates for Amazon RDS
* Redshift (3.5.3.0)
	* Update VPC endpoint field names.
* SimpleSystemsManagement (3.5.9.3)
	* Documentation updates for the ListDocumentFilters API action.

### 3.5.94.0 (2021-01-21 21:05 UTC)
* Kafka (3.5.7.0)
	* Amazon MSK has added a new API that allows you to update all the brokers in the cluster to the specified type.
* ResourceGroupsTaggingAPI (3.5.1.0)
	* This release adds a new parameter ResourceARNList to Resource Groups Tagging api GetResources api to allow customers retrieve tag data for specific resources.
* SecurityHub (3.5.4.0)
	* This release of ASFF adds a new Action object and a new resource details object - AwsSsmPatchCompliance. It also adds several new attributes for the AwsEc2NetworkInterface resource type.

### 3.5.93.0 (2021-01-20 00:24 UTC)
* Core 3.5.2.0
	* Added retry header support; Read error response async when the service operation is called async; Fixes an issue in DefaultInstanceProfileAWSCredentials class to avoid multiple GetCredentials() calls from hitting IMDS subsequently; AWS SSO based Credential Profiles are now handled by the SDK.
	* All services packages updated to require new Core

### 3.5.92.0 (2021-01-19 19:13 UTC)
* ACMPCA (3.5.2.0)
	* ACM Private CA is launching additional certificate templates and API parameters. This allows customers to create custom certificates for their identity and secure communication use cases.
* Chime (3.5.3.0)
	* Add support for specifying ChimeBearer header as part of the request for Amazon Chime SDK messaging APIs. Documentation updates.
* ECS (3.5.3.0)
	* This release adds support to include task definition metadata information such as registeredAt, deregisteredAt, registeredBy as part of DescribeTaskDefinition API.
* Core 3.5.1.60
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.91.1 (2021-01-15 19:24 UTC)
* SimpleNotificationService (3.5.1.31)
	* Documentation updates for Amazon SNS.

### 3.5.91.0 (2021-01-14 19:13 UTC)
* CognitoIdentity (3.5.2.0)
	* Add Attributes For Access Control support for Amazon Cognito Identity Pools to facilitate access to AWS resources based on attributes from social and corporate identity providers
* Pinpoint (3.5.2.0)
	* Customers can create segments using 5 new filters. Filters can check for the presence of a substring in attributes and can perform time-based comparisons formatted as ISO_INSTANT datetimes.
* S3Control (3.5.3.0)
	* Amazon S3 Batch Operations now supports restoring objects from the S3 Intelligent-Tiering Archive Access and Deep Archive Access tiers.
* SageMaker (3.5.8.0)
	* This feature allows customers to enable/disable model caching on Multi-Model endpoints.

### 3.5.90.0 (2021-01-13 19:16 UTC)
* FraudDetector (3.5.3.0)
	* Added support for cancelling a model version that is TRAINING_IN_PROGRESS.
* Personalize (3.5.0.60)
	* Miscellaneous updates and improvements to the documentation

### 3.5.89.0 (2021-01-12 19:13 UTC)
* AppStream (3.5.1.0)
	* Adds support for the Smart Card Redirection feature
* AuditManager (3.5.1.0)
	* This release introduces tag support for assessment frameworks. You can now add, remove, and get tags from existing frameworks, and specify the tags to apply when creating a custom framework.
* ElastiCache (3.5.1.36)
	* Documentation updates for elasticache
* Lightsail (3.5.2.0)
	* This release adds IPv6 support for Amazon Lightsail instances, container services, CDN distributions, and load balancers.
* SimpleSystemsManagement (3.5.9.0)
	* AWS Systems Manager adds pagination support for DescribeDocumentPermission API

### 3.5.88.0 (2021-01-11 19:27 UTC)
* KeyManagementService (3.5.2.0)
	* Adds support for filtering grants by grant ID and grantee principal in ListGrants requests to AWS KMS.
* RDS (3.5.10.0)
	* This releases adds support for Major Version Upgrades on Aurora MySQL Global Clusters. Customers will be able to upgrade their whole Aurora MySQL Global Cluster to a new major engine version.
* Core 3.5.1.59
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.87.0 (2021-01-07 19:16 UTC)
* CodePipeline (3.5.2.0)
	* Adding cancelled status and summary for executions aborted by pipeline updates.
* DevOpsGuru (3.5.2.0)
	* Add resourceHours field in GetAccountHealth API to show total number of resource hours AWS Dev Ops Guru has done work for in the last hour.
* MediaConvert (3.5.5.0)
	* AWS Elemental MediaConvert SDK has added support for I-Frame-only HLS manifest generation in CMAF outputs.
* Core 3.5.1.58
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.86.0 (2021-01-06 19:14 UTC)
* AutoScaling (3.5.3.10)
	* This update increases the number of instance types that can be added to the overrides within an mixed instances group configuration.
* AutoScalingPlans (3.5.0.58)
	* Documentation updates for AWS Auto Scaling
* Transfer (3.5.2.0)
	* This release adds support for Amazon EFS, so customers can transfer files over SFTP, FTPS and FTP in and out of Amazon S3 as well as Amazon EFS.

### 3.5.85.0 (2021-01-05 19:10 UTC)
* ApplicationAutoScaling (3.5.2.36)
	* Documentation updates for Application Auto Scaling
* CostExplorer (3.5.8.0)
	* - ### Features    - Add new GetCostcategories API - Support filter for GetDimensions, GetTags and GetCostcategories api - Support sortBy metrics for GetDimensions, GetTags and GetCostcategories api

### 3.5.84.0 (2021-01-04 19:10 UTC)
* CloudSearch (3.5.1.0)
	* This release adds support for new Amazon CloudSearch instances.
* HealthLake (3.5.1.0)
	* Amazon HealthLake now supports exporting data from FHIR Data Stores in Preview.

