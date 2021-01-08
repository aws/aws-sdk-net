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

### 3.5.83.0 (2020-12-31 19:09 UTC)
* ServiceCatalog (3.5.8.0)
	* Enhanced Service Catalog DescribeProvisioningParameters API to return new parameter constraints, i.e., MinLength, MaxLength, MinValue, MaxValue, ConstraintDescription and AllowedPattern

### 3.5.82.1 (2020-12-30 19:10 UTC)
* ElastiCache (3.5.1.33)
	* Documentation updates for elasticache
* Macie2 (3.5.6.17)
	* This release of the Amazon Macie API includes miscellaneous updates and improvements to the documentation.
* Core 3.5.1.57
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.82.0 (2020-12-29 19:09 UTC)
* ACMPCA (3.5.1.0)
	* This release adds a new parameter "CsrExtensions" in the "CertificateAuthorityConfiguration" data structure, which allows customers to add the addition of KU and SIA into the CA CSR.
* ApiGatewayV2 (3.5.3.0)
	* Amazon API Gateway now supports data mapping for HTTP APIs which allows customers to modify HTTP Request before sending it to their integration and HTTP Response before sending it to the invoker.

### 3.5.81.0 (2020-12-28 19:11 UTC)
* CloudFront (3.5.6.0)
	* Amazon CloudFront has deprecated the CreateStreamingDistribution and CreateStreamingDistributionWithTags APIs as part of discontinuing support for Real-Time Messaging Protocol (RTMP) distributions.

### 3.5.80.0 (2020-12-23 19:12 UTC)
* ComputeOptimizer (3.5.3.0)
	* This release enables AWS Compute Optimizer to analyze and generate optimization recommendations for lambda functions.
* DatabaseMigrationService (3.5.8.0)
	* AWS DMS launches support for AWS Secrets Manager to manage Oracle ASM Database credentials
* ResourceGroups (3.5.1.0)
	* Add operation `PutGroupConfiguration`. Support dedicated hosts and add `Pending` in operations `Un/GroupResources`. Add `Resources` in `ListGroupResources` and deprecate `ResourceIdentifiers`.
* Core 3.5.1.56
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.79.0 (2020-12-22 19:23 UTC)
* Connect (3.5.5.0)
	* This release adds support for quick connects. For details, see the Release Notes in the Amazon Connect Administrator Guide.
* CostExplorer (3.5.7.0)
	* This release adds additional metadata that may be applicable to the Rightsizing Recommendations.
* ElastiCache (3.5.1.31)
	* Documentation updates for elasticache
* Glue (3.5.10.0)
	* AWS Glue Find Matches machine learning transforms now support column importance scores.
* IoTWireless (3.5.1.0)
	* Adding the ability to use Fingerprint in GetPartnerAccount and ListPartnerAccounts API responses to protect sensitive customer account information.
* RDS (3.5.9.0)
	* Adds customer-owned IP address (CoIP) support to Amazon RDS on AWS Outposts.
* SimpleSystemsManagement (3.5.8.0)
	* SSM Maintenance Window support for registering/updating maintenance window tasks without targets.
* Core 3.5.1.55
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.78.1 (2020-12-21 23:07 UTC)
* Glacier (3.5.0.54)
	* Fix issue with Glacier download job failing when inventory vault output
* RDS (3.5.8.2)
	* Fix to throw expected argument null exception when null host or username is passed.
* S3 (3.5.7.1)
	* Fixes an issue where Amazon.S3.Util.S3EventNotification.ParseJson throws exception for long values by handling condition for UInt values in LitJson library.;Correct unmarshalling of SSES3 shape
* Core 3.5.1.54
	* Correct fallback logic for STS region when using SAML;Fix issue with paginators when service returns back empty string for end of the paging.;Support for Content-MD5 trait;Add support for AWS_CONTAINER_CREDENTIALS_FULL_URI environment variable;removed obselete tags from classes responsible for policy generation
	* All services packages updated to require new Core

### 3.5.78.0 (2020-12-21 19:19 UTC)
* APIGateway (3.5.2.19)
	* Documentation updates for Amazon API Gateway.
* AppRegistry (3.5.3.0)
	* New API `SyncResouce` to update AppRegistry system tags.
* Batch (3.5.5.7)
	* Documentation updates for batch
* ConfigService (3.5.3.0)
	* AWS Config adds support to save advanced queries. New API operations - GetStoredQuery, PutStoredQuery, ListStoredQueries, DeleteStoredQuery
* ConnectParticipant (3.5.1.0)
	* This release adds three new APIs: StartAttachmentUpload, CompleteAttachmentUpload, and GetAttachment. For Amazon Connect Chat, you can use these APIs to share files in chat conversations.
* DatabaseMigrationService (3.5.7.0)
	* AWS DMS launches support for AWS Secrets Manager to manage source and target database credentials.
* EC2 (3.5.28.0)
	* This release adds Tag On Create feature support for the AllocateAddress API.
* Glue (3.5.9.0)
	* Add 4 connection properties: SECRET_ID, CONNECTOR_URL, CONNECTOR_TYPE, CONNECTOR_CLASS_NAME. Add two connection types: MARKETPLACE, CUSTOM
* ManagedBlockchain (3.5.2.0)
	* Added support for provisioning and managing public Ethereum nodes on main and test networks supporting secure access using Sigv4 and standard open-source Ethereum APIs.
* Outposts (3.5.3.0)
	* In this release, AWS Outposts adds support for three new APIs: TagResource, UntagResource, and ListTagsForResource. Customers can now manage tags for their resources through the SDK.
* QLDBSession (3.5.1.0)
	* Adds "TimingInformation" to all SendCommand API results and "IOUsage" to ExecuteStatementResult, FetchPageResult and CommitTransactionResult.
* S3 (3.5.7.0)
	* Format GetObject's Expires header to be an http-date instead of iso8601
* SecurityHub (3.5.3.12)
	* Finding providers can now use BatchImportFindings to update Confidence, Criticality, RelatedFindings, Severity, and Types.
* ServiceQuotas (3.5.1.0)
	* Added the ability to tag applied quotas.
* Core 3.5.1.53
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.77.0 (2020-12-18 19:11 UTC)
* EC2 (3.5.27.0)
	* EBS io2 volumes now supports Multi-Attach
* PersonalizeRuntime (3.5.2.0)
	* Updated FilterValues regex pattern to align with Filter Expression.
* RDS (3.5.8.0)
	* Adds IAM DB authentication information to the PendingModifiedValues output of the DescribeDBInstances API. Adds ClusterPendingModifiedValues information to the output of the DescribeDBClusters API.
* Core 3.5.1.52
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.76.0 (2020-12-17 19:20 UTC)
* ConfigService (3.5.2.0)
	* Adding PutExternalEvaluation API which grants permission to deliver evaluation result to AWS Config
* DLM (3.5.3.0)
	* Provide Cross-account copy event based policy support in DataLifecycleManager (DLM)
* EC2 (3.5.26.0)
	* C6gn instances are powered by AWS Graviton2 processors and offer 100 Gbps networking bandwidth. These instances deliver up to 40% better price-performance benefit versus comparable x86-based instances
* Imagebuilder (3.5.3.0)
	* This release adds support for building and distributing container images within EC2 Image Builder.
* KeyManagementService (3.5.1.0)
	* Added CreationDate and LastUpdatedDate timestamps to ListAliases API response
* Route53 (3.5.1.0)
	* This release adds support for DNSSEC signing in Amazon Route 53.
* Route53Resolver (3.5.2.0)
	* Route 53 Resolver adds support for enabling resolver DNSSEC validation in virtual private cloud (VPC).
* ServiceCatalog (3.5.7.0)
	* Support TagOptions sharing with Service Catalog portfolio sharing.
* SQS (3.5.1.0)
	* Amazon SQS adds queue attributes to enable high throughput FIFO.
* Core 3.5.1.51
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.75.0 (2020-12-16 20:32 UTC)
* CostExplorer (3.5.6.0)
	* This release updates the "MonitorArnList" from a list of String to be a list of Arn for both CreateAnomalySubscription and UpdateAnomalySubscription APIs
* LocationService (3.5.0.0)
	* Initial release of Amazon Location Service. A new geospatial service providing capabilities to render maps, geocode/reverse geocode, track device locations, and detect geofence entry/exit events.
* PrometheusService (3.5.0.1)
	* Documentation updates for Amazon Managed Service for Prometheus
* QuickSight (3.5.9.0)
	* QuickSight now supports connecting to federated data sources of Athena
* WellArchitected (3.5.0.0)
	* This is the first release of AWS Well-Architected Tool API support, use to review your workload and compare against the latest AWS architectural best practices.
* Core 3.5.1.50
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.74.0 (2020-12-15 19:15 UTC)
* GreengrassV2 (3.5.0.0)
	* AWS IoT Greengrass V2 is a new major version of AWS IoT Greengrass. This release adds several updates such as modular components, continuous deployments, and improved ease of use.
* IoT (3.5.7.0)
	* AWS IoT Rules Engine adds Kafka Action that allows sending data to Apache Kafka clusters inside a VPC. AWS IoT Device Defender adds custom metrics and machine-learning based anomaly detection.
* IoTAnalytics (3.5.2.0)
	* FileFormatConfiguration enables data store to save data in JSON or Parquet format. S3Paths enables you to specify the S3 objects that save your channel messages when you reprocess the pipeline.
* IoTDeviceAdvisor (3.5.0.0)
	* AWS IoT Core Device Advisor is fully managed test capability for IoT devices. Device manufacturers can use Device Advisor to test their IoT devices for reliable and secure connectivity with AWS IoT.
* IoTFleetHub (3.5.0.0)
	* AWS IoT Fleet Hub, a new feature of AWS IoT Device Management that provides a web application for monitoring and managing device fleets connected to AWS IoT at scale.
* IoTWireless (3.5.0.0)
	* AWS IoT for LoRaWAN enables customers to setup a private LoRaWAN network by connecting their LoRaWAN devices and gateways to the AWS cloud without managing a LoRaWAN Network Server.
* Lambda (3.5.6.0)
	* Added support for Apache Kafka as a event source. Added support for TumblingWindowInSeconds for streams event source mappings. Added support for FunctionResponseTypes for streams event source mappings
* PrometheusService (3.5.0.0)
	* (New Service) Amazon Managed Service for Prometheus is a fully managed Prometheus-compatible monitoring service that makes it easy to monitor containerized applications securely and at scale.
* SimpleSystemsManagement (3.5.7.0)
	* Adding support for Change Manager API content

### 3.5.73.0 (2020-12-14 19:11 UTC)
* DevOpsGuru (3.5.1.0)
	* Documentation updates for DevOps Guru.
* EC2 (3.5.25.0)
	* Add c5n.metal to ec2 instance types list
* GlobalAccelerator (3.5.3.0)
	* This release adds support for custom routing accelerators
* Core 3.5.1.49
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.72.0 (2020-12-11 19:13 UTC)
* AutoScaling (3.5.3.0)
	* Documentation updates and corrections for Amazon EC2 Auto Scaling API Reference and SDKs.
* CloudTrail (3.5.2.0)
	* CloudTrailInvalidClientTokenIdException is now thrown when a call results in the InvalidClientTokenId error code. The Name parameter of the AdvancedEventSelector data type is now optional.
* CloudWatch (3.5.0.49)
	* Documentation updates for monitoring
* GuardDuty (3.5.1.41)
	* Documentation updates for GuardDuty
* IoTSiteWise (3.5.6.0)
	* Added the ListAssetRelationships operation and support for composite asset models, which represent structured sets of properties within asset models.
* PI (3.5.0.49)
	* You can group DB load according to the dimension groups for database, application, and session type. Amazon RDS also supports the dimensions db.name, db.application.name, and db.session_type.name.

### 3.5.71.0 (2020-12-10 19:34 UTC)
* EC2 (3.5.24.0)
	* TGW connect simplifies connectivity of SD-WAN appliances; IGMP support for TGW multicast; VPC Reachability Analyzer for VPC resources connectivity analysis.
* Kendra (3.5.8.0)
	* Amazon Kendra now supports adding synonyms to an index through the new Thesaurus resource.
* NetworkManager (3.5.1.0)
	* This release adds API support for Transit Gateway Connect integration into AWS Network Manager.

### 3.5.70.0 (2020-12-09 19:16 UTC)
* EC2 (3.5.23.0)
	* This release adds support for G4ad instances powered by AMD Radeon Pro V520 GPUs and AMD 2nd Generation EPYC processors
* GlobalAccelerator (3.5.2.0)
	* This release adds support for custom routing accelerators
* Redshift (3.5.2.0)
	* Add support for availability zone relocation feature.
* Core 3.5.1.48
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.69.0 (2020-12-08 19:19 UTC)
* AuditManager (3.5.0.0)
	* AWS Audit Manager helps you continuously audit your AWS usage to simplify how you manage risk and compliance. This update releases the first version of the AWS Audit Manager APIs and SDK.
* ECR (3.5.1.0)
	* This release adds support for configuring cross-region and cross-account replication of your Amazon ECR images.
* EMRContainers (3.5.0.0)
	* This release adds support for Amazon EMR on EKS, a simple way to run Spark on Kubernetes.
* ForecastService (3.5.3.0)
	* This release adds support for the Amazon Forecast Weather Index which can increase forecasting accuracy by automatically including weather forecasts in demand forecasts.
* HealthLake (3.5.0.0)
	* This release introduces Amazon HealthLake (preview), a HIPAA-eligible service that enables healthcare and life sciences customers to store, transform, query, and analyze health data in the AWS Cloud.
* Kendra (3.5.7.0)
	* 1. Amazon Kendra connector for Google Drive repositories 2. Amazon Kendra's relevance ranking models are regularly tuned for each customer by capturing end-user search patterns and feedback.
* QuickSight (3.5.8.0)
	* Added new parameters for join optimization.
* SageMaker (3.5.7.0)
	* This feature helps you monitor model performance characteristics such as accuracy, identify undesired bias in your ML models, and explain model decisions better with explainability drift detection.
* SagemakerEdgeManager (3.5.0.0)
	* Amazon SageMaker Edge Manager makes it easy to optimize, secure, monitor, and maintain  machine learning (ML) models across fleets of edge devices such as smart cameras, smart speakers, and robots.
* SageMakerRuntime (3.5.1.0)
	* This feature allows customers to invoke their endpoint with an inference ID. If used and data capture for the endpoint is enabled, this ID will be captured along with request data.

### 3.5.68.0 (2020-12-07 22:11 UTC)
* AppRegistry (3.5.2.0)
	* AWS Service Catalog AppRegistry now supports adding, removing, and listing tags on resources after they are created.
* DatabaseMigrationService (3.5.6.0)
	* Added PreserveTransaction setting to preserve order of CDC for S3 as target. Added CsvNoSupValue setting to replace empty value for columns not included in the supplemental log for S3 as target.
* Core 3.5.1.47
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.67.0 (2020-12-04 19:14 UTC)
* DirectoryService (3.5.2.3)
	* Documentation updates for ds - updated descriptions
* EC2 (3.5.22.0)
	* This release introduces tag-on-create capability for the CreateImage API. A user can now specify tags that will be applied to the new resources (image, snapshots or both), during creation time.
* Kafka (3.5.6.0)
	* Adding HEALING to ClusterState.
* Lambda (3.5.5.0)
	* Added the additional enum InvalidImage to StateReasonCode and LastUpdateStatusReasonCode fields.
* LicenseManager (3.5.3.0)
	* Automated Discovery now has support for custom tags, and detects software uninstalls.
* MediaLive (3.5.8.0)
	* AWS Elemental MediaLive now supports black video and audio silence as new conditions to trigger automatic input failover.
* RDS (3.5.7.0)
	* Adds support for Amazon RDS Cross-Region Automated Backups, the ability to setup automatic replication of snapshots and transaction logs from a primary AWS Region to a secondary AWS Region.
* SimpleSystemsManagement (3.5.6.0)
	* AWS Systems Manager Patch Manager MAC OS Support and OpsMetadata Store APIs to store operational metadata for an Application.
* WorkSpaces (3.5.3.0)
	* Update the import-workspace-image API to have "BYOL_REGULAR_WSP" as a valid input string for ingestion-process.

### 3.5.66.0 (2020-12-03 19:24 UTC)
* AmplifyBackend (3.5.0.2)
	* Regular documentation updates.
* Batch (3.5.5.0)
	* This release adds support for customer to run Batch Jobs on ECS Fargate, the serverless compute engine built for containers on AWS. Customer can also propagate Job and Job Definition Tags to ECS Task.
* ComputeOptimizer (3.5.2.0)
	* This release enables AWS Compute Optimizer to analyze and generate optimization recommendations for EBS volumes that are attached to instances.
* LicenseManager (3.5.2.0)
	* AWS License Manager enables managed entitlements for AWS customers and Software Vendors (ISV). You can track and distribute license entitlements from AWS Marketplace and supported ISVs.
* Core 3.5.1.46
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.65.0 (2020-12-02 01:57 UTC)
* CustomerProfiles (3.5.0.0)
	* This is the first release of Amazon Connect Customer Profiles, a unified customer profile for your Amazon Connect contact center.
* Core 3.5.1.45
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.64.0 (2020-12-01 19:20 UTC)
* AmplifyBackend (3.5.0.0)
	* (New Service) The Amplify Admin UI offers an accessible way to develop app backends and manage app content. We recommend that you use the Amplify Admin UI to manage the backend of your Amplify app.
* AppIntegrationsService (3.5.0.0)
	* The Amazon AppIntegrations service (in preview release) enables you to configure and reuse connections to external applications.
* Connect (3.5.4.0)
	* This release adds an Amazon Connect API that provides the ability to create tasks, and a set of APIs (in preview) to configure AppIntegrations associations with Amazon Connect instances.
* ConnectContactLens (3.5.0.0)
	* Contact Lens for Amazon Connect analyzes conversations, both real-time and post-call. The ListRealtimeContactAnalysisSegments API returns a list of analysis segments for a real-time analysis session.
* DevOpsGuru (3.5.0.0)
	* (New Service) Amazon DevOps Guru is available in public preview. It's a fully managed service that uses machine learning to analyze your operational solutions to help you find and troubleshoot issues.
* DirectoryService (3.5.2.0)
	* Adding client authentication feature for AWS AD Connector
* EC2 (3.5.21.0)
	* This release adds support for: EBS gp3 volumes; and D3/D3en/R5b/M5zn instances powered by Intel Cascade Lake CPUs
* ECRPublic (3.5.0.0)
	* Supports Amazon Elastic Container Registry (Amazon ECR) Public, a fully managed registry that makes it easy for a developer to publicly share container software worldwide for anyone to download.
* EKS (3.5.3.0)
	* Amazon EKS now allows you to define and manage the lifecycle for Kubernetes add-ons for your clusters. This release adds support for the AWS VPC CNI (vpc-cni).
* Honeycode (3.5.1.0)
	* Introducing APIs to read and write directly from Honeycode tables. Use APIs to pull table and column metadata, then use the read and write APIs to programmatically read and write from the tables.
* Lambda (3.5.4.0)
	* This release includes support for a new feature: Container images support in AWS Lambda. This adds APIs for deploying functions as container images. AWS Lambda now supports memory up to 10240MB.
* LookoutforVision (3.5.0.0)
	* This release introduces support for Amazon Lookout for Vision.
* S3 (3.5.6.0)
	* S3 adds support for multiple-destination replication, option to sync replica modifications;  S3 Bucket Keys to reduce cost of S3 SSE with AWS KMS
* SageMaker (3.5.6.0)
	* Amazon SageMaker Pipelines for ML workflows. Amazon SageMaker Feature Store, a fully managed repository for ML features.
* SageMakerFeatureStoreRuntime (3.5.0.0)
	* This release adds support for Amazon SageMaker Feature Store, which makes it easy for customers to create, version, share, and manage curated data for machine learning (ML) development.
* Core 3.5.1.44
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.63.0 (2020-12-01 04:28 UTC)
* EC2 (3.5.20.0)
	* This release introduces Amazon EC2 Mac1 instances, a new Amazon EC2 instance family built on Apple Mac mini computers, powered by AWS Nitro System, and support running macOS workloads on Amazon EC2
* Core 3.5.1.43
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.62.0 (2020-11-24 21:37 UTC)
* Appflow (3.5.2.0)
	* Upsolver as a destination connector and documentation update.
* Batch (3.5.4.0)
	* Add Ec2Configuration in ComputeEnvironment.ComputeResources. Use in CreateComputeEnvironment API to enable AmazonLinux2 support.
* CloudFormation (3.5.2.0)
	* Adds support for the new Modules feature for CloudFormation. A module encapsulates one or more resources and their respective configurations for reuse across your organization.
* CloudTrail (3.5.1.0)
	* CloudTrail now includes advanced event selectors, which give you finer-grained control over the events that are logged to your trail.
* CodeBuild (3.5.3.0)
	* Adding GetReportGroupTrend API for Test Reports.
* CognitoIdentityProvider (3.5.1.0)
	* This release adds ability to configure Cognito User Pools with third party sms and email providers for sending notifications to users.
* Comprehend (3.5.3.0)
	* Support Comprehend events detection APIs
* ElasticBeanstalk (3.5.2.0)
	* Updates the Integer constraint of DescribeEnvironmentManagedActionHistory's MaxItems parameter to [1, 100].
* FSx (3.5.2.0)
	* This release adds the capability to increase storage capacity of Amazon FSx for Lustre file systems, providing the flexibility to meet evolving storage needs over time.
* GameLift (3.5.2.0)
	* GameLift FlexMatch is now available as a standalone matchmaking solution. FlexMatch now provides customizable matchmaking for games hosted peer-to-peer, on-premises, or on cloud compute primitives.
* IoTSiteWise (3.5.5.0)
	* This release adds support for customer managed customer master key (CMK) based encryption in IoT SiteWise.
* LexModelBuildingService (3.5.5.0)
	* Lex now supports es-419, de-DE locales
* MediaConvert (3.5.4.0)
	* AWS Elemental MediaConvert SDK has added support for Vorbis and Opus audio in OGG/OGA containers.
* MWAA (3.5.0.0)
	* (New Service) Amazon MWAA is a managed service for Apache Airflow that makes it easy for data engineers and data scientists to execute data processing workflows in the cloud.
* QuickSight (3.5.7.0)
	* Support for embedding without user registration. New enum EmbeddingIdentityType. A potential breaking change. Affects code that refers IdentityType enum type directly instead of literal string value.
* StepFunctions (3.5.3.0)
	* This release of the AWS Step Functions SDK introduces support for Synchronous Express Workflows
* TimestreamWrite (3.5.1.0)
	* Adds support of upserts for idempotent updates to Timestream.
* Core 3.5.1.42
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.61.0 (2020-11-23 19:22 UTC)
* ApplicationInsights (3.5.1.0)
	* Add Detected Workload to ApplicationComponent which shows the workloads that installed in the component
* AutoScaling (3.5.2.2)
	* Documentation updates and corrections for Amazon EC2 Auto Scaling API Reference and SDKs.
* CodeArtifact (3.5.2.0)
	* Add support for the NuGet package format.
* CodeStarconnections (3.5.2.0)
	* Added support for the UpdateHost API.
* DynamoDBv2 (3.5.4.0)
	* With this release, you can capture data changes in any Amazon DynamoDB table as an Amazon Kinesis data stream. You also can use PartiQL (SQL-compatible language) to manipulate data in DynamoDB tables.
* EC2 (3.5.19.0)
	* This release adds support for Multiple Private DNS names to DescribeVpcEndpointServices response.
* ECS (3.5.2.0)
	* This release adds support for updating capacity providers, specifying custom instance warmup periods for capacity providers, and using deployment circuit breaker for your ECS Services.
* ElastiCache (3.5.1.17)
	* Documentation updates for elasticache
* ElasticMapReduce (3.5.3.0)
	* Add API support for EMR Studio, a new notebook-first IDE for data scientists and data engineers with single sign-on, Jupyter notebooks, automated infrastructure provisioning, and job diagnosis.
* ForecastService (3.5.2.0)
	* Releasing the set of PredictorBacktestExportJob APIs which allow customers to export backtest values and item-level metrics data from Predictor training.
* Glue (3.5.8.0)
	* Feature1 - Glue crawler adds data lineage configuration option. Feature2 - AWS Glue Data Catalog adds APIs for PartitionIndex creation and deletion as part of Enhancement Partition Management feature.
* IoT (3.5.6.0)
	* This release enables users to identify different file types in the over-the-air update (OTA) functionality using fileType parameter for CreateOTAUpdate API
* Kafka (3.5.5.0)
	* Adding MAINTENANCE and REBOOTING_BROKER to Cluster states.
* Lambda (3.5.3.0)
	* This release includes support for new feature: Code Signing for AWS Lambda. This adds new resources and APIs to configure Lambda functions to accept and verify signed code artifacts at deployment.
* LicenseManager (3.5.1.0)
	* AWS License Manager now provides the ability for license administrators to be able to associate license configurations to AMIs shared with their AWS account
* Outposts (3.5.2.0)
	* Support specifying tags during the creation of the Outpost resource. Tags are now returned in the response body of Outpost APIs.
* SecurityHub (3.5.3.0)
	* Updated the account management API to support the integration with AWS Organizations. Added new methods to allow users to view and manage the delegated administrator account for Security Hub.
* Signer (3.5.1.0)
	* AWS Signer is launching code-signing for AWS Lambda. Now customers can cryptographically sign Lambda code to ensure trust, integrity, and functionality.
* SSOAdmin (3.5.1.0)
	* AWS Single Sign-On now enables attribute-based access control for workforce identities to simplify permissions in AWS
* TimestreamQuery (3.5.1.0)
	* Amazon Timestream now supports "QueryStatus" in Query API which has information about cumulative bytes scanned, metered, as well as progress percentage for the query.
* Translate (3.5.2.0)
	* This update adds new operations to create and manage parallel data in Amazon Translate. Parallel data is a resource that you can use to run Active Custom Translation jobs.
* Core 3.5.1.41
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.60.0 (2020-11-20 19:16 UTC)
* AppMesh (3.5.2.0)
	* This release makes tag value a required attribute of the tag's key-value pair.
* AppRegistry (3.5.1.0)
	* AWS Service Catalog AppRegistry Documentation update
* Chime (3.5.2.0)
	* The Amazon Chime SDK for messaging provides the building blocks needed to build chat and other real-time collaboration features.
* CloudHSMV2 (3.5.1.0)
	* Added managed backup retention, a feature that enables customers to retain backups for a configurable period after which CloudHSM service will automatically delete them.
* CodeGuruReviewer (3.5.2.0)
	* This release supports tagging repository association resources in Amazon CodeGuru Reviewer.
* CognitoIdentity (3.5.1.0)
	* Added SDK pagination support for ListIdentityPools
* Connect (3.5.3.0)
	* This release adds a set of Amazon Connect APIs to programmatically control instance creation, modification, description and deletion.
* Kafka (3.5.4.0)
	* This release adds support for PER TOPIC PER PARTITION monitoring on AWS MSK clusters.
* Macie2 (3.5.6.0)
	* The Amazon Macie API now provides S3 bucket metadata that indicates whether any one-time or recurring classification jobs are configured to analyze data in a bucket.
* S3 (3.5.5.0)
	* Add new documentation regarding automatically generated Content-MD5 headers when using the SDK or CLI.
* Core 3.5.1.40
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.59.0 (2020-11-19 19:30 UTC)
* AutoScaling (3.5.2.0)
	* You can now create Auto Scaling groups with multiple launch templates using a mixed instances policy, making it easy to deploy an AMI with an architecture that is different from the rest of the group.
* CloudWatchEvents (3.5.4.0)
	* EventBridge now supports Resource-based policy authorization on event buses. This enables cross-account PutEvents API calls, creating cross-account rules, and simplifies permission management.
* CostExplorer (3.5.5.0)
	* Additional metadata that may be applicable to the recommendation.
* DirectoryService (3.5.1.0)
	* Adding multi-region replication feature for AWS Managed Microsoft AD
* EventBridge (3.5.4.0)
	* EventBridge now supports Resource-based policy authorization on event buses. This enables cross-account PutEvents API calls, creating cross-account rules, and simplifies permission management.
* Glue (3.5.7.0)
	* Adding support for Glue Schema Registry. The AWS Glue Schema Registry is a new feature that allows you to centrally discover, control, and evolve data stream schemas.
* KinesisAnalyticsV2 (3.5.3.0)
	* Amazon Kinesis Data Analytics now supports building and running streaming applications using Apache Flink 1.11 and provides a way to access the Apache Flink dashboard for supported Flink versions.
* Lambda (3.5.2.0)
	* Added the starting position and starting position timestamp to ESM Configuration. Now customers will be able to view these fields for their ESM.
* Lex (3.5.1.0)
	* Amazon Lex now supports the ability to view and manage active contexts associated with a user session.
* LexModelBuildingService (3.5.4.0)
	* Amazon Lex supports managing input and output contexts as well as default values for slots.
* MediaLive (3.5.7.0)
	* The AWS Elemental MediaLive APIs and SDKs now support the ability to see the software update status on Link devices
* Redshift (3.5.1.0)
	* Amazon Redshift support for returning ClusterNamespaceArn in describeClusters
* Core 3.5.1.39
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.58.0 (2020-11-18 19:12 UTC)
* Backup (3.5.2.0)
	* AWS Backup now supports cross-account backup, enabling AWS customers to securely copy their backups across their AWS accounts within their AWS organizations.
* CloudFormation (3.5.1.0)
	* This release adds ChangeSets support for Nested Stacks. ChangeSets offer a preview of how proposed changes to a stack might impact existing resources or create new ones.
* CodeBuild (3.5.2.0)
	* AWS CodeBuild - Adding Status field for Report Group
* EC2 (3.5.18.0)
	* EC2 Fleet adds support of DeleteFleets API for instant type fleets. Now you can delete an instant type fleet and terminate all associated instances with a single API call.
* ElastiCache (3.5.1.14)
	* Adding Memcached 1.6 to parameter family
* Outposts (3.5.1.0)
	* Mark the Name parameter in CreateOutpost as required.
* S3Control (3.5.2.0)
	* AWS S3 Storage Lens provides visibility into your storage usage and activity trends at the organization or account level, with aggregations by Region, storage class, bucket, and prefix.
* Core 3.5.1.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.57.0 (2020-11-17 19:13 UTC)
* Chime (3.5.1.0)
	* This release adds CRUD APIs for Amazon Chime SipMediaApplications and SipRules. It also adds the API for creating outbound PSTN calls for Amazon Chime meetings.
* Connect (3.5.2.0)
	* This release adds support for user hierarchy group and user hierarchy structure. For details, see the Release Notes in the Amazon Connect Administrator Guide.
* FMS (3.5.1.0)
	* Added Firewall Manager policy support for AWS Network Firewall resources.
* Macie2 (3.5.5.0)
	* The Amazon Macie API now has a lastRunErrorStatus property to indicate if account- or bucket-level errors occurred during the run of a one-time classification job or the latest run of a recurring job.
* NetworkFirewall (3.5.0.0)
	* (New Service) AWS Network Firewall is a managed network layer firewall service that makes it easy to secure your virtual private cloud (VPC) networks and block malicious traffic.
* RDS (3.5.6.0)
	* Support copy-db-snapshot in the one region on cross clusters and local cluster for RDSonVmware. Add target-custom-availability-zone parameter to specify where a snapshot should be copied.

### 3.5.56.1 (2020-11-16 21:23 UTC)
* Core 3.5.1.37
	* Updates to code generators.

### 3.5.56.0 (2020-11-16 19:14 UTC)
* CodePipeline (3.5.1.0)
	* We show details about inbound executions and id of action executions in GetPipelineState API. We also add ConflictException to StartPipelineExecution, RetryStageExecution, StopPipelineExecution APIs.
* DatabaseMigrationService (3.5.5.0)
	* Adding MoveReplicationTask feature to move replication tasks between instances
* IoTSecureTunneling (3.5.1.0)
	* Support using multiple data streams per tunnel using the Secure Tunneling multiplexing feature.
* IoTSiteWise (3.5.4.0)
	* This release supports Unicode characters for string operations in formulae computes in SiteWise. For more information, search for SiteWise in Amazon What's new or refer the SiteWise documentation.
* QuickSight (3.5.6.0)
	* Adding new parameters for dashboard persistence
* SageMaker (3.5.5.0)
	* This feature enables customers to encrypt their Amazon SageMaker Studio storage volumes with customer master keys (CMKs) managed by them in AWS Key Management Service (KMS).
* ServiceCatalog (3.5.6.0)
	* Support import of CloudFormation stacks into Service Catalog provisioned products.
* SimpleNotificationService (3.5.1.8)
	* Documentation updates for Amazon SNS.
* Synthetics (3.5.2.0)
	* AWS Synthetics now supports Environment Variables  to assign runtime parameters in the canary scripts.

### 3.5.55.0 (2020-11-13 19:16 UTC)
* ElasticLoadBalancingV2 (3.5.5.0)
	* Adds dualstack support for Network Load Balancers (TCP/TLS only), an attribute for WAF fail open for Application Load Balancers, and an attribute for connection draining for Network Load Balancers.
* Shield (3.5.1.0)
	* This release adds APIs for two new features: 1) Allow customers to bundle resources into protection groups and treat as a single unit. 2) Provide per-account event summaries to all AWS customers.
* Textract (3.5.2.0)
	* AWS Textract now allows customers to specify their own KMS key to be used for asynchronous jobs output results, AWS Textract now also recognizes handwritten text from English documents.
* Core 3.5.1.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.54.0 (2020-11-12 19:25 UTC)
* AppRegistry (3.5.0.0)
	* AWS Service Catalog AppRegistry provides a repository of your applications, their resources, and the application metadata that you use within your enterprise.
* IoT (3.5.5.0)
	* This release adds a batchMode parameter to the IotEvents, IotAnalytics, and Firehose actions which allows customers to send an array of messages to the corresponding services
* LexModelBuildingService (3.5.3.0)
	* Lex now supports es-ES, it-IT, fr-FR and fr-CA locales
* Lightsail (3.5.1.0)
	* This release adds support for Amazon Lightsail container services. You can now create a Lightsail container service, and deploy Docker images to it.
* PersonalizeRuntime (3.5.1.0)
	* Adds support to use dynamic filters with Personalize.
* Polly (3.5.1.0)
	* Amazon Polly adds new Australian English female voice - Olivia. Olivia is available as Neural voice only.
* RoboMaker (3.5.1.0)
	* This release introduces Robomaker Worldforge TagsOnCreate which allows customers to tag worlds as they are being generated by providing the tags while configuring a world generation job.

### 3.5.53.0 (2020-11-11 19:17 UTC)
* Amplify (3.5.3.0)
	* Whereas previously custom headers were set via the app's buildspec, custom headers can now be set directly on the Amplify app for both ci/cd and manual deploy apps.
* ForecastService (3.5.1.0)
	* Providing support of custom quantiles in CreatePredictor API.
* GlueDataBrew (3.5.0.0)
	* This is the initial SDK release for AWS Glue DataBrew. DataBrew is a visual data preparation tool that enables users to clean and normalize data without writing any code.
* MediaConvert (3.5.3.0)
	* AWS Elemental MediaConvert SDK has added support for Automated ABR encoding and improved the reliability of embedded captions in accelerated outputs.
* QuickSight (3.5.5.0)
	* QuickSight now supports Column-level security and connecting to Oracle data source.
* ServiceCatalog (3.5.5.0)
	* Adding support to remove a Provisioned Product launch role via UpdateProvisionedProductProperties

### 3.5.52.1 (2020-11-10 23:33 UTC)
* Core 3.5.1.35
	* Add support for list of doubles in query parameter.

### 3.5.52.0 (2020-11-10 19:12 UTC)
* AutoScaling (3.5.1.2)
	* Documentation updates and corrections for Amazon EC2 Auto Scaling API Reference and SDKs.
* EC2 (3.5.17.0)
	* This release adds support for Gateway Load Balancer VPC endpoints and VPC endpoint services
* ElasticLoadBalancingV2 (3.5.4.0)
	* Added support for Gateway Load Balancers, which make it easy to deploy, scale, and run third-party virtual networking appliances.
* SimpleSystemsManagement (3.5.5.0)
	* Add SessionId as a filter for DescribeSessions API

### 3.5.51.0 (2020-11-09 17:21 UTC)
* DataSync (3.5.2.0)
	* DataSync now enables customers to adjust the network bandwidth used by a running AWS DataSync task.
* DynamoDBv2 (3.5.3.0)
	* This release adds supports for exporting Amazon DynamoDB table data to Amazon S3 to perform analytics at any scale.
* ECS (3.5.1.0)
	* This release provides native support for specifying Amazon FSx for Windows File Server file systems as volumes in your Amazon ECS task definitions.
* Elasticsearch (3.5.4.0)
	* Adding support for package versioning in Amazon Elasticsearch Service
* FSx (3.5.1.0)
	* This release adds support for creating DNS aliases for Amazon FSx for Windows File Server, and using AWS Backup to automate scheduled, policy-driven backup plans for Amazon FSx file systems.
* IoTAnalytics (3.5.1.0)
	* AWS IoT Analytics now supports Late Data Notifications for datasets, dataset content creation using previous version IDs, and includes the LastMessageArrivalTime attribute for channels and datastores.
* Macie2 (3.5.4.0)
	* Sensitive data findings in Amazon Macie now include enhanced location data for Apache Avro object containers and Apache Parquet files.
* S3 (3.5.4.0)
	* S3 Intelligent-Tiering adds support for Archive and Deep Archive Access tiers; S3 Replication adds replication metrics and failure notifications, brings feature parity for delete marker replication
* SimpleSystemsManagement (3.5.4.0)
	* add a new filter to allow customer to filter automation executions by using resource-group which used for execute automation
* StorageGateway (3.5.2.0)
	* Added bandwidth rate limit schedule for Tape and Volume Gateways

### 3.5.50.0 (2020-11-06 19:11 UTC)
* DLM (3.5.2.0)
	* Amazon Data Lifecycle Manager now supports the creation and retention of EBS-backed Amazon Machine Images
* EC2 (3.5.16.0)
	* Network card support with four new attributes: NetworkCardIndex, NetworkPerformance, DefaultNetworkCardIndex, and MaximumNetworkInterfaces, added to the DescribeInstanceTypes API.
* IoTSiteWise (3.5.3.0)
	* Remove the CreatePresignedPortalUrl API
* MediaLive (3.5.6.0)
	* Support for SCTE35 ad markers in OnCuePoint style in RTMP outputs.
* SimpleSystemsManagement (3.5.3.9)
	* Documentation updates for Systems Manager

### 3.5.49.0 (2020-11-05 19:27 UTC)
* AppMesh (3.5.1.0)
	* This release adds circuit breaking capabilities to your mesh with connection pooling and outlier detection support.
* CloudWatchEvents (3.5.3.0)
	* With this release, customers can now reprocess past events by storing the events published on event bus in an encrypted archive.
* DynamoDBv2 (3.5.2.0)
	* This release adds a new ReplicaStatus INACCESSIBLE_ENCRYPTION_CREDENTIALS for the Table description, indicating when a key used to encrypt a regional replica table is not accessible.
* EC2 (3.5.15.0)
	* Documentation updates for EC2.
* Elasticsearch (3.5.3.0)
	* Amazon Elasticsearch Service now provides the ability to define a custom endpoint for your domain and link an SSL certificate from ACM, making it easier to refer to Kibana and the domain endpoint.
* EventBridge (3.5.3.0)
	* With this release, customers can now reprocess past events by storing the events published on event bus in an encrypted archive.
* FraudDetector (3.5.2.0)
	* Added support for deleting resources like Variables, ExternalModels, Outcomes, Models, ModelVersions, Labels, EventTypes and EntityTypes. Updated DeleteEvent operation to catch missing exceptions.
* Kendra (3.5.6.0)
	* Amazon Kendra now supports providing user context in your query requests, Tokens can be JSON or JWT format. This release also introduces support for Confluence cloud datasources.
* Lambda (3.5.1.0)
	* Support Amazon MQ as an Event Source.
* RDS (3.5.5.0)
	* Supports a new parameter to set the max allocated storage in gigabytes for the CreateDBInstanceReadReplica API.
* Core 3.5.1.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.48.0 (2020-11-04 20:14 UTC)
* AutoScaling (3.5.1.0)
	* Capacity Rebalance helps you manage and maintain workload availability during Spot interruptions by proactively augmenting your Auto Scaling group with a new instance before interrupting an old one.
* AWSMarketplaceMetering (3.5.1.0)
	* Adding Vendor Tagging Support in MeterUsage and BatchMeterUsage API.
* CloudWatch (3.5.0.35)
	* Documentation updates for monitoring
* EC2 (3.5.14.0)
	* Added support for Client Connect Handler for AWS Client VPN. Fleet supports launching replacement instances in response to Capacity Rebalance recommendation.
* Elasticsearch (3.5.2.0)
	* Amazon Elasticsearch Service now supports native SAML authentication that seamlessly integrates with the customers' existing SAML 2.0 Identity Provider (IdP).
* IoT (3.5.4.0)
	* Updated API documentation and added paginator for AWS Iot Registry ListThingPrincipals API.
* MQ (3.5.1.0)
	* Amazon MQ introduces support for RabbitMQ, a popular message-broker with native support for AMQP 0.9.1. You can now create fully-managed RabbitMQ brokers in the cloud.
* ServiceCatalog (3.5.4.0)
	* Service Catalog API ListPortfolioAccess can now support a maximum PageSize of 100.
* XRay (3.5.4.0)
	* Releasing new APIs GetInsightSummaries, GetInsightEvents, GetInsight, GetInsightImpactGraph and updating GetTimeSeriesServiceStatistics API for AWS X-Ray Insights feature
* Core 3.5.1.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.47.0 (2020-11-02 19:47 UTC)
* EC2 (3.5.13.0)
	* This release adds support for the following features: 1. P4d instances based on NVIDIA A100 GPUs.  2. NetworkCardIndex attribute to support multiple network cards.

### 3.5.46.0 (2020-10-30 18:14 UTC)
* Braket (3.5.1.0)
	* This release supports tagging for Amazon Braket quantum-task resources. It also supports tag-based access control for quantum-task APIs.
* DatabaseMigrationService (3.5.4.0)
	* Adding DocDbSettings to support DocumentDB as a source.
* ElastiCache (3.5.1.10)
	* Documentation updates for AWS ElastiCache
* Imagebuilder (3.5.2.0)
	* This feature increases the number of accounts that can be added to the Launch permissions within an Image Builder Distribution configuration.
* Macie2 (3.5.3.0)
	* This release of the Amazon Macie API adds an eqExactMatch operator for filtering findings. With this operator you can increase the precision of your finding filters and suppression rules.
* MediaLive (3.5.5.0)
	* Support for HLS discontinuity tags in the child manifests. Support for incomplete segment behavior in the media output. Support for automatic input failover condition settings.
* SimpleNotificationService (3.5.1.4)
	* Documentation updates for Amazon SNS

### 3.5.45.0 (2020-10-29 18:18 UTC)
* APIGateway (3.5.2.0)
	* Support disabling the default execute-api endpoint for REST APIs.
* AWSMarketplaceCommerceAnalytics (3.5.0.35)
	* Documentation updates for marketplacecommerceanalytics to specify four data sets which are deprecated.
* CodeArtifact (3.5.1.0)
	* Add support for tagging of CodeArtifact domain and repository resources.
* EC2 (3.5.12.0)
	* Support for Appliance mode on Transit Gateway that simplifies deployment of stateful network appliances. Added support for AWS Client VPN Self-Service Portal.
* ElasticLoadBalancingV2 (3.5.3.0)
	* Application Load Balancer (ALB) now supports the gRPC protocol-version. With this release, customers can use ALB to route and load balance gRPC traffic between gRPC enabled clients and microservices.
* SimpleEmailV2 (3.5.1.0)
	* This release enables customers to manage their own contact lists and end-user subscription preferences.
* StorageGateway (3.5.1.0)
	* Adding support for access based enumeration on SMB file shares, file share visibility on SMB file shares, and file upload notifications for all file shares

### 3.5.44.0 (2020-10-28 18:17 UTC)
* EC2 (3.5.11.0)
	* AWS Nitro Enclaves general availability. Added support to RunInstances for creating enclave-enabled EC2 instances. New APIs to associate an ACM certificate with an IAM role, for enclave consumption.
* IoT (3.5.3.0)
	* This release adds support for GG-Managed Job Namespace
* WorkMail (3.5.2.7)
	* Documentation update for Amazon WorkMail
* Core 3.5.1.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.43.0 (2020-10-27 18:15 UTC)
* Glue (3.5.6.0)
	* AWS Glue machine learning transforms now support encryption-at-rest for labels and trained models.
* Core 3.5.1.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.42.0 (2020-10-26 18:18 UTC)
* Kendra (3.5.5.0)
	* Amazon Kendra now supports indexing data from Confluence Server.
* Neptune (3.5.1.0)
	* This feature enables custom endpoints for Amazon Neptune clusters. Custom endpoints simplify connection management when clusters contain instances with different capacities and configuration settings.
* SageMaker (3.5.4.0)
	* This release enables customers to bring custom images for use with SageMaker Studio notebooks.
* Core 3.5.1.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.41.0 (2020-10-23 18:12 UTC)
* Macie2 (3.5.2.5)
	* This release of the Amazon Macie API includes miscellaneous updates and improvements to the documentation.
* MediaTailor (3.5.1.0)
	* MediaTailor now supports ad marker passthrough for HLS. Use AdMarkerPassthrough to pass EXT-X-CUE-IN, EXT-X-CUE-OUT, and EXT-X-SPLICEPOINT-SCTE35 from origin manifests into personalized manifests.
* QuickSight (3.5.4.0)
	* Support description on columns.

### 3.5.40.0 (2020-10-22 18:11 UTC)
* AccessAnalyzer (3.5.1.4)
	* API Documentation updates for IAM Access Analyzer.
* Appflow (3.5.1.0)
	* Salesforce connector creation with customer provided client id and client secret, incremental pull configuration, salesforce upsert write operations and execution ID when on-demand flows are executed.
* ServiceCatalog (3.5.3.3)
	* Documentation updates for servicecatalog
* SimpleNotificationService (3.5.1.0)
	* SNS now supports a new class of topics: FIFO (First-In-First-Out). FIFO topics provide strictly-ordered, deduplicated, filterable, encryptable, many-to-many messaging at scale.
* Core 3.5.1.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.39.1 (2020-10-21 21:14 UTC)
* S3 (3.5.3.6)
	* Updated to use new Core, version 3.5.1.28
	* Added flags to disable payload signing and MD5Stream for S3 uploads.
* Core 3.5.1.28
	* Added flags to disable payload signing and MD5Stream for S3 uploads. Enabling the CA2007 reliability warning: Do not directly await a Task.
	* All services packages updated to require new Core

### 3.5.39.0 (2020-10-21 18:17 UTC)
* CloudFront (3.5.5.0)
	* CloudFront adds support for managing the public keys for signed URLs and signed cookies directly in CloudFront (it no longer requires the AWS root account).
* EC2 (3.5.10.0)
	* instance-storage-info nvmeSupport added to DescribeInstanceTypes API
* GlobalAccelerator (3.5.1.0)
	* This release adds support for specifying port overrides on AWS Global Accelerator endpoint groups.
* Glue (3.5.5.0)
	* AWS Glue crawlers now support incremental crawls for the Amazon Simple Storage Service (Amazon S3) data source.
* Kendra (3.5.4.0)
	* This release adds custom data sources: a new data source type that gives you full control of the documents added, modified or deleted during a data source sync while providing run history metrics.
* Organizations (3.5.1.16)
	* AWS Organizations renamed the 'master account' to 'management account'.

### 3.5.38.0 (2020-10-20 18:10 UTC)
* AppSync (3.5.1.6)
	* Documentation updates to AppSync to correct several typos.
* Batch (3.5.3.0)
	* Adding evaluateOnExit to job retry strategies.
* ElasticBeanstalk (3.5.1.0)
	* EnvironmentStatus enum update to include Aborting, LinkingFrom and LinkingTo
* Core 3.5.1.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.37.0 (2020-10-19 18:12 UTC)
* Backup (3.5.1.11)
	* Documentation updates for Cryo
* CloudFront (3.5.4.0)
	* Amazon CloudFront adds support for Origin Shield.
* DocDB (3.5.1.16)
	* Documentation updates for docdb
* ServiceCatalog (3.5.3.0)
	* An Admin can now update the launch role associated with a Provisioned Product. Admins and End Users can now view the launch role associated with a Provisioned Product.
* SimpleSystemsManagement (3.5.3.0)
	* This Patch Manager release now supports Common Vulnerabilities and Exposure (CVE) Ids for missing packages via the DescribeInstancePatches API.

### 3.5.36.0 (2020-10-16 18:13 UTC)
* MediaLive (3.5.4.0)
	* The AWS Elemental MediaLive APIs and SDKs now support the ability to transfer the ownership of MediaLive Link devices across AWS accounts.
* Organizations (3.5.1.14)
	* Documentation updates for AWS Organizations.
* Core 3.5.1.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.35.0 (2020-10-15 18:20 UTC)
* AccessAnalyzer (3.5.1.0)
	* This release adds support for the ApplyArchiveRule api in IAM Access Analyzer.  The ApplyArchiveRule api allows users to apply an archive rule retroactively to existing findings in an analyzer.
* Budgets (3.5.1.0)
	* This release introduces AWS Budgets Actions, allowing you to define an explicit response(or set of responses)  to take when your budget exceeds it's action threshold.
* CostExplorer (3.5.4.0)
	* This release improves email validation for subscriptions on the SDK endpoints.
* DatabaseMigrationService (3.5.3.0)
	* When creating Endpoints, Replication Instances, and Replication Tasks, the feature provides you the option to specify friendly name to the resources.
* Glue (3.5.4.3)
	* API Documentation updates for Glue Get-Plan API
* GroundStation (3.5.1.0)
	* Adds error message attribute to DescribeContact DataflowDetails
* IoT (3.5.2.0)
	* Add new variable, lastStatusChangeDate, to DescribeDomainConfiguration  API
* Macie2 (3.5.2.0)
	* This release of the Amazon Macie API adds support for pausing and resuming classification jobs. Also, sensitive data findings now include location data for up to 15 occurrences of sensitive data.
* RDS (3.5.4.0)
	* Return tags for all resources in the output of DescribeDBInstances, DescribeDBSnapshots, DescribeDBClusters, and DescribeDBClusterSnapshots API operations.
* Rekognition (3.5.2.0)
	* This SDK Release introduces new API (DetectProtectiveEquipment) for Amazon Rekognition. This release also adds ServiceQuotaExceeded exception to Amazon Rekognition IndexFaces API.
* SimpleSystemsManagement (3.5.2.0)
	* This Patch Manager release now supports searching for available packages from Amazon Linux and Amazon Linux 2 via the DescribeAvailablePatches API.
* Transfer (3.5.1.0)
	* Add support to associate VPC Security Groups at server creation.
* WorkMail (3.5.2.0)
	* Add CreateOrganization and DeleteOrganization API operations.
* WorkSpaces (3.5.2.15)
	* Documentation updates for WorkSpaces
* XRay (3.5.3.0)
	* Enhancing CreateGroup, UpdateGroup, GetGroup and GetGroups APIs to support configuring X-Ray Insights Notifications. Adding TraceLimit information into X-Ray BatchGetTraces API response.
* Core 3.5.1.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.34.0 (2020-10-09 18:12 UTC)
* Amplify (3.5.2.0)
	* Performance mode optimizes for faster hosting performance by keeping content cached at the edge for a longer interval - enabling can make code changes can take up to 10 minutes to roll out.
* EKS (3.5.2.0)
	* This release introduces a new Amazon EKS error code: "ClusterUnreachable"
* MediaLive (3.5.3.0)
	* WAV audio output. Extracting ancillary captions in MP4 file inputs. Priority on channels feeding a multiplex (higher priority channels will tend to have higher video quality).
* ServiceCatalog (3.5.2.0)
	* This new API takes either a ProvisonedProductId or a ProvisionedProductName, along with a list of 1 or more output keys and responds with the (key,value) pairs of those outputs.
* Snowball (3.5.1.0)
	* We added new APIs to allow customers to better manage their device shipping. You can check if your shipping label expired, generate a new label, and tell us that you received or shipped your job.
* Core 3.5.1.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.33.0 (2020-10-08 18:13 UTC)
* CloudWatchEvents (3.5.2.0)
	* Amazon EventBridge (formerly called CloudWatch Events) adds support for target Dead-letter Queues and custom retry policies.
* CostExplorer (3.5.3.0)
	* You can now create hierarchical cost categories by choosing "Cost Category" as a dimension. You can also track the status of your cost category updates to your cost and usage information.
* EC2 (3.5.9.0)
	* AWS EC2 RevokeSecurityGroupIngress and RevokeSecurityGroupEgress APIs will return IpPermissions which do not match with any existing IpPermissions for security groups in default VPC and EC2-Classic.
* EventBridge (3.5.2.0)
	* Amazon EventBridge adds support for target Dead Letter Queues (DLQs) and custom retry policies.
* RDS (3.5.3.0)
	* Supports a new parameter to set the max allocated storage in gigabytes for restore database instance from S3 and restore database instance to a point in time APIs.
* Rekognition (3.5.1.0)
	* This release provides location information for the manifest validation files.
* SageMaker (3.5.3.0)
	* This release enables Sagemaker customers to convert Tensorflow and PyTorch models to CoreML (ML Model) format.
* SimpleNotificationService (3.5.0.26)
	* Documentation updates for SNS.

### 3.5.32.0 (2020-10-07 22:43 UTC)
* ComputeOptimizer (3.5.1.0)
	* This release enables AWS Compute Optimizer to analyze EC2 instance-level EBS read and write operations, and throughput when generating recommendations for your EC2 instances and Auto Scaling groups.
* CostExplorer (3.5.2.0)
	* Enables Rightsizing Recommendations to analyze and present EC2 instance-level EBS metrics when generating recommendations. Returns AccessDeniedException if the account is not opted into Rightsizing
* ElastiCache (3.5.1.0)
	* This release introduces User and UserGroup to allow customers to have access control list of the Redis resources for AWS ElastiCache. This release also adds support for Outposts  for AWS ElastiCache.
* MediaPackage (3.5.2.0)
	* AWS Elemental MediaPackage provides access logs that capture detailed information about requests sent to a customer's MediaPackage channel.

### 3.5.31.0 (2020-10-06 18:15 UTC)
* DatabaseMigrationService (3.5.2.0)
	* Added new S3 endpoint settings to allow partitioning CDC data by date for S3 as target. Exposed some Extra Connection Attributes as endpoint settings for relational databases as target.
* EC2 (3.5.8.0)
	* This release supports returning additional information about local gateway virtual interfaces, and virtual interface groups.
* KinesisAnalyticsV2 (3.5.2.0)
	* Amazon Kinesis Analytics now supports StopApplication with 'force' option
* MarketplaceCatalog (3.5.1.0)
	* AWS Marketplace Catalog now supports FailureCode for change workflows to help differentiate client errors and server faults.

### 3.5.30.1 (2020-10-06 00:41 UTC)
* S3 (3.5.3.1)
	* Add S3 Outposts documentation
* Core 3.5.1.23
	* Add maintenance mode message to .NET Standard 1.3 service clients
	* All services packages updated to require new Core

### 3.5.30.0 (2020-10-05 18:52 UTC)
* DynamoDBv2 (3.5.1.0)
	* This release adds a new ReplicaStatus REGION DISABLED for the Table description. This state indicates that the AWS Region for the replica is inaccessible because the AWS Region is disabled.
* Glue (3.5.4.0)
	* AWS Glue crawlers now support Amazon DocumentDB (with MongoDB compatibility) and MongoDB collections. You can choose to crawl the entire data set or only a small sample to reduce crawl time.
* MediaConvert (3.5.2.0)
	* AWS Elemental MediaConvert SDK has added support for AVC-I and VC3 encoding in the MXF OP1a container, Nielsen non-linear watermarking, and InSync FrameFormer frame rate conversion.
* SageMaker (3.5.2.0)
	* This release adds support for launching Amazon SageMaker Studio in your VPC. Use AppNetworkAccessType in CreateDomain API to disable access to public internet and restrict the network traffic to VPC.

### 3.5.29.0 (2020-10-02 18:17 UTC)
* Batch (3.5.2.0)
	* Support tagging for Batch resources (compute environment, job queue, job definition and job) and tag based access control on Batch APIs
* ElasticLoadBalancingV2 (3.5.2.0)
	* This release adds support for tagging listeners, rules, and target groups on creation. This release also supported tagging operations through tagging api's for listeners and rules.
* PersonalizeEvents (3.5.1.0)
	* Adds new APIs to write item and user records to Datasets.
* RDS (3.5.2.0)
	* Adds the NCHAR Character Set ID parameter to the CreateDbInstance API for RDS Oracle.
* S3 (3.5.3.0)
	* Amazon S3 Object Ownership is a new S3 feature that enables bucket owners to automatically assume ownership of objects that are uploaded to their buckets by other AWS Accounts.
* ServiceDiscovery (3.5.1.0)
	* Added support for optional parameters for DiscoverInstances API in AWS Cloud Map
* Core 3.5.1.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.28.0 (2020-10-01 18:18 UTC)
* AppSync (3.5.1.0)
	* Exposes the wafWebAclArn field on GraphQL api records. The wafWebAclArn field contains the amazon resource name of a WAF Web ACL if the AWS AppSync API is associated with one.
* ElasticMapReduce (3.5.2.1)
	* Documentation updates for elasticmapreduce
* Glue (3.5.3.0)
	* Adding additional optional map parameter to get-plan api
* Kafka (3.5.3.0)
	* Added support for Enabling Zookeeper Encryption in Transit for AWS MSK.
* QuickSight (3.5.3.0)
	* QuickSight now supports connecting to AWS Timestream data source
* WAFV2 (3.5.1.0)
	* AWS WAF is now available for AWS AppSync GraphQL APIs. AWS WAF protects against malicious attacks with AWS Managed Rules or your own custom rules. For more information see the AWS WAF Developer Guide.
* Core 3.5.1.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.27.0 (2020-09-30 20:29 UTC)
* ApplicationAutoScaling (3.5.2.0)
	* This release extends Auto Scaling support for cluster storage of Managed Streaming for Kafka. Auto Scaling monitors and automatically expands storage capacity when a critical usage threshold is met.
* DataSync (3.5.1.0)
	* This release enables customers to create s3 location for S3 bucket's located on an AWS Outpost.
* DirectConnect (3.5.0.22)
	* Documentation updates for AWS Direct Connect.
* ElasticMapReduce (3.5.2.0)
	* Amazon EMR customers can now use EC2 placement group to influence the placement of master nodes in a high-availability (HA) cluster across distinct underlying hardware to improve cluster availability.
* Imagebuilder (3.5.1.0)
	* EC2 Image Builder adds support for copying AMIs created by Image Builder to accounts specific to each Region.
* IoT (3.5.1.0)
	* AWS IoT Rules Engine adds Timestream action. The Timestream rule action lets you stream time-series data from IoT sensors and applications to Amazon Timestream databases for time series analysis.
* MediaConnect (3.5.1.0)
	* MediaConnect now supports reservations to provide a discounted rate for a specific outbound bandwidth over a period of time.
* Pinpoint (3.5.1.0)
	* Amazon Pinpoint - Features - Customers can start a journey based on an event being triggered by an endpoint or user.
* S3 (3.5.2.0)
	* Amazon S3 on Outposts expands object storage to on-premises AWS Outposts environments, enabling you to store and retrieve objects using S3 APIs and features.
* S3Control (3.5.1.0)
	* Amazon S3 on Outposts expands object storage to on-premises AWS Outposts environments, enabling you to store and retrieve objects using S3 APIs and features.
* S3Outposts (3.5.0.0)
	* Amazon S3 on Outposts expands object storage to on-premises AWS Outposts environments, enabling you to store and retrieve objects using S3 APIs and features.
* SecurityHub (3.5.2.0)
	* Added several new resource details objects. Added additional details for CloudFront distributions, IAM roles, and IAM access keys. Added a new ResourceRole attribute for resources.
* Core 3.5.1.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.26.0 (2020-09-29 18:17 UTC)
* Connect (3.5.1.6)
	* Update TagResource API documentation to include Contact Flows and Routing Profiles as supported resources.
* EC2 (3.5.7.1)
	* This release adds support for Client to Client routing for AWS Client VPN.
* Schemas (3.5.1.0)
	* Added support for schemas of type JSONSchemaDraft4. Added ExportSchema API that converts schemas in AWS Events registry and Discovered schemas from OpenApi3  to JSONSchemaDraft4.
* SimpleSystemsManagement (3.5.1.20)
	* Simple update to description of ComplianceItemStatus.
* TimestreamQuery (3.5.0.0)
	* (New Service) Amazon Timestream is a fast, scalable, fully managed, purpose-built time series database that makes it easy to store and analyze trillions of time series data points per day.
* TimestreamWrite (3.5.0.0)
	* (New Service) Amazon Timestream is a fast, scalable, fully managed, purpose-built time series database that makes it easy to store and analyze trillions of time series data points per day.
* Core 3.5.1.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.25.0 (2020-09-28 18:10 UTC)
* ApplicationAutoScaling (3.5.1.0)
	* This release extends Application Auto Scaling support to AWS Comprehend Entity Recognizer endpoint, allowing automatic updates to provisioned Inference Units to maintain targeted utilization level.
* RDS (3.5.1.0)
	* This release adds the InsufficientAvailableIPsInSubnetFault error for RDS Proxy.

### 3.5.24.0 (2020-09-25 18:13 UTC)
* Batch (3.5.1.0)
	* Support custom logging, executionRole, secrets, and linuxParameters (initProcessEnabled, maxSwap, swappiness, sharedMemorySize, and tmpfs). Also, add new context keys for awslogs.
* ConfigService (3.5.1.0)
	* Make the delivery-s3-bucket as an optional parameter for conformance packs and organizational conformance packs
* DocDB (3.5.1.7)
	* Documentation updates for docdb
* EC2 (3.5.7.0)
	* This release supports returning additional information about local gateway resources, such as the local gateway route table.
* FraudDetector (3.5.1.0)
	* Increased maximum length of eventVariables values for GetEventPrediction from 256 to 1024.
* SecurityToken (3.5.1.0)
	* Documentation update for AssumeRole error
* Core 3.5.1.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.23.1 (2020-09-24 22:07 UTC)
* S3 (3.5.1.9)
	* Improved Performance in S3 Client: https://github.com/aws/aws-sdk-net/issues/1700

### 3.5.23.0 (2020-09-24 18:12 UTC)
* Amplify (3.5.1.0)
	* Allow Oauth Token in CreateApp call to be a maximum of 1000 characters instead of 100
* EKS (3.5.1.0)
	* Amazon EKS now supports configuring your cluster's service CIDR during cluster creation.
* SavingsPlans (3.5.1.0)
	* Introducing Queued SavingsPlans that will enable customers to queue their purchase request of Savings Plans for future dates.
* Synthetics (3.5.1.0)
	* AWS Synthetics now supports AWS X-Ray Active Tracing feature. RunConfig is now an optional parameter with timeout updated from (60 - 900 seconds) to (3 - 840 seconds).
* Textract (3.5.1.0)
	* AWS Textract now supports output results for asynchronous jobs to customer specified s3 bucket.
* TranscribeService (3.5.2.0)
	* Amazon Transcribe now supports WebM, OGG, AMR and AMR-WB as input formats. You can also specify an output key as a location within your S3 buckets to store the output of your transcription jobs.
* Core 3.5.1.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.22.0 (2020-09-23 18:11 UTC)
* Backup (3.5.1.0)
	* This release allows customers to enable or disable advanced backup settings in backup plan. As part of this feature AWS Backup added support for  Windows VSS backup option for EC2 resources.
* CostExplorer (3.5.1.0)
	* This release provides access to Cost Anomaly Detection Public Preview APIs. Cost Anomaly Detection finds cost anomalies based on your historical cost and usage using Machine Learning models.
* QuickSight (3.5.2.0)
	* Added Sheet information to DescribeDashboard, DescribeTemplate and DescribeAnalysis API response.
* Translate (3.5.1.0)
	* Improvements to DeleteTerminology API.

### 3.5.21.0 (2020-09-22 18:50 UTC)
* Comprehend (3.5.2.0)
	* Amazon Comprehend integrates with Amazon SageMaker GroundTruth to allow its customers to annotate their datasets using GroundTruth and train their models using Comprehend Custom APIs.
* LexModelBuildingService (3.5.2.0)
	* Lex now supports es-US locales
* WorkMail (3.5.1.0)
	* Adding support for Mailbox Export APIs

### 3.5.20.0 (2020-09-21 18:14 UTC)
* CloudWatchEvents (3.5.1.0)
	* Add support for Redshift Data API Targets
* EventBridge (3.5.1.0)
	* Add support for Redshift Data API Targets
* Glue (3.5.2.0)
	* Adding support to update multiple partitions of a table in a single request
* IoTSiteWise (3.5.2.0)
	* This release supports IAM mode for SiteWise Monitor portals
* RDS (3.5.0.18)
	* Documentation updates for the RDS DescribeExportTasks API
* ResourceGroups (3.5.0.18)
	* Documentation updates and corrections for Resource Groups API Reference and SDKs.
* ResourceGroupsTaggingAPI (3.5.0.18)
	* Documentation updates for the Resource Groups Tagging API.
* Core 3.5.1.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.19.0 (2020-09-18 18:16 UTC)
* CodeStarconnections (3.5.1.0)
	* New integration with the GitHub provider type.
* MediaLive (3.5.2.0)
	* AWS Elemental MediaLive now supports batch operations, which allow users to start, stop, and delete multiple MediaLive resources with a single request.
* SSOAdmin (3.5.0.6)
	* Documentation updates for AWS SSO APIs.
* Core 3.5.1.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.18.0 (2020-09-17 18:33 UTC)
* APIGateway (3.5.1.0)
	* Adds support for mutual TLS authentication for public regional REST Apis
* ApiGatewayV2 (3.5.2.0)
	* Adds support for mutual TLS authentication and disableAPIExecuteEndpoint for public regional HTTP Apis
* CloudFront (3.5.3.5)
	* Documentation updates for CloudFront
* Comprehend (3.5.1.0)
	* Amazon Comprehend now supports detecting Personally Identifiable Information (PII) entities in a document.
* Elasticsearch (3.5.1.0)
	* Adds support for data plane audit logging in Amazon Elasticsearch Service.
* Kendra (3.5.3.0)
	* Amazon Kendra now supports additional file formats and metadata for FAQs.
* Core 3.5.1.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.17.0 (2020-09-16 18:14 UTC)
* Connect (3.5.1.0)
	* This release adds support for contact flows and routing profiles. For details, see the Release Notes in the Amazon Connect Administrator Guide.
* DLM (3.5.1.0)
	* Customers can now provide multiple schedules within a single Data Lifecycle Manager (DLM) policy. Each schedule supports tagging, Fast Snapshot Restore (FSR) and cross region copy individually.
* Greengrass (3.5.1.0)
	* This release includes the ability to set run-time configuration for a Greengrass core. The Telemetry feature, also included in this release, can be configured via run-time configuration per core.
* ServiceCatalog (3.5.1.0)
	* Enhance DescribeProvisionedProduct API to allow useProvisionedProduct Name as Input, so customer can provide ProvisionedProduct Name instead of ProvisionedProduct Id to describe a ProvisionedProduct.
* SimpleSystemsManagement (3.5.1.14)
	* The ComplianceItemEntry Status description was updated to address Windows patches that aren't applicable.
* Core 3.5.1.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.16.0 (2020-09-15 18:17 UTC)
* Budgets (3.5.0.14)
	* Documentation updates for Daily Cost and Usage budgets
* EC2 (3.5.6.0)
	* T4g instances are powered by AWS Graviton2 processors
* Kafka (3.5.2.0)
	* Added new API's to support SASL SCRAM Authentication with MSK Clusters.
* Kendra (3.5.2.0)
	* Amazon Kendra now returns confidence scores for 'document' query responses.
* MediaLive (3.5.1.0)
	* AWS Elemental MediaLive now supports CDI (Cloud Digital Interface) inputs which enable uncompressed video from applications on Elastic Cloud Compute (EC2), AWS Media Services, and from AWS partners
* Organizations (3.5.1.0)
	* AWS Organizations now enables you to add tags to the AWS accounts, organizational units, organization root, and policies in your organization.
* SageMaker (3.5.1.0)
	* Sagemaker Ground Truth: Added support for a new Streaming feature which helps to continuously feed data and receive labels in real time. This release adds a new input and output SNS data channel.
* TranscribeService (3.5.1.0)
	* Amazon Transcribe now supports automatic language identification, which enables you to transcribe audio files without needing to know the language in advance.
* Core 3.5.1.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.15.0 (2020-09-14 20:53 UTC)
* DocDB (3.5.1.0)
	* Updated API documentation and added paginators for DescribeCertificates, DescribeDBClusterParameterGroups, DescribeDBClusterParameters, DescribeDBClusterSnapshots and DescribePendingMaintenanceActions
* EC2 (3.5.5.0)
	* This release adds support for the T4G instance family to the EC2 ModifyDefaultCreditSpecification and GetDefaultCreditSpecification APIs.
* ManagedBlockchain (3.5.1.0)
	* Introducing support for Hyperledger Fabric 1.4. When using framework version 1.4, the state database may optionally be specified when creating peer nodes (defaults to CouchDB).
* StepFunctions (3.5.2.0)
	* This release of the AWS Step Functions SDK introduces support for AWS X-Ray.
* Core 3.5.1.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.14.0 (2020-09-11 18:28 UTC)
* WorkSpaces (3.5.2.0)
	* Adds API support for WorkSpaces Cross-Region Redirection feature.
* Core 3.5.1.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.13.0 (2020-09-10 18:10 UTC)
* CloudFront (3.5.3.0)
	* Cloudfront adds support for Brotli. You can enable brotli caching and compression support by enabling it in your Cache Policy.
* EBS (3.5.0.12)
	* Documentation updates for Amazon EBS direct APIs.
* Pinpoint (3.5.0.12)
	* Update SMS message model description to clearly indicate that the MediaUrl field is reserved for future use and is not supported by Pinpoint as of today.
* S3 (3.5.1.0)
	* Bucket owner verification feature added. This feature introduces the x-amz-expected-bucket-owner and x-amz-source-expected-bucket-owner headers.
* SSOAdmin (3.5.0.0)
	* This is an initial release of AWS Single Sign-On (SSO) Access Management APIs. This release adds support for SSO operations which could be used for managing access to AWS accounts.

### 3.5.12.1 (2020-09-10 00:18 UTC)
* Core 3.5.1.9
	* Add UserAgent string addition when using paginators
	* All services packages updated to require new Core

### 3.5.12.0 (2020-09-09 18:11 UTC)
* Glue (3.5.1.0)
	* Adding support for partitionIndexes to improve GetPartitions performance.
* KinesisAnalyticsV2 (3.5.1.0)
	* Kinesis Data Analytics is adding new AUTOSCALING application status for applications during auto scaling and also adding FlinkRunConfigurationDescription in the ApplicationDetails.
* RedshiftDataAPIService (3.5.0.0)
	* The Amazon Redshift Data API is generally available. This release enables querying Amazon Redshift data and listing various database objects.
* Core 3.5.1.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.11.0 (2020-09-08 18:13 UTC)
* ApiGatewayV2 (3.5.1.0)
	* You can now secure HTTP APIs using Lambda authorizers and IAM authorizers. These options enable you to make flexible auth decisions using a Lambda function, or using IAM policies, respectively.
* CodeBuild (3.5.1.0)
	* AWS CodeBuild - Support keyword search for test cases in DecribeTestCases API . Allow deletion of reports in the report group, before deletion of report group using the deleteReports flag.
* ElasticLoadBalancingV2 (3.5.1.0)
	* Adds support for Application Load Balancers on Outposts.
* LexModelBuildingService (3.5.1.0)
	* Amazon Lex supports en-AU locale
* QuickSight (3.5.1.0)
	* Adds tagging support for QuickSight customization resources.  A user can now specify a list of tags when creating a customization resource and use a customization ARN in QuickSight's tagging APIs.

### 3.5.10.0 (2020-09-04 18:16 UTC)
* SimpleSystemsManagement (3.5.1.8)
	* Documentation-only updates for AWS Systems Manager
* WorkSpaces (3.5.1.0)
	* Adding support for Microsoft Office 2016 and Microsoft Office 2019 in BYOL Images
* XRay (3.5.2.0)
	* Enhancing CreateGroup, UpdateGroup, GetGroup and GetGroups APIs to support configuring X-Ray Insights
* Core 3.5.1.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.9.0 (2020-09-03 18:17 UTC)
* GuardDuty (3.5.1.0)
	* GuardDuty findings triggered by failed events now include the error code name within the AwsApiCallAction section.
* Kendra (3.5.1.0)
	* Amazon Kendra now returns confidence scores for both 'answer' and 'question and answer' query responses.
* MediaPackage (3.5.1.0)
	* Enables inserting a UTCTiming XML tag in the output manifest of a DASH endpoint which a media player will use to help with time synchronization.
* StepFunctions (3.5.1.0)
	* This release of the AWS Step Functions SDK introduces support for payloads up to 256KB for Standard and Express workflows

### 3.5.8.0 (2020-09-02 18:15 UTC)
* EC2 (3.5.4.0)
	* This release adds a new transit gateway attachment state and resource type.
* Macie2 (3.5.1.0)
	* This release of the Amazon Macie API introduces additional statistics for the size and count of Amazon S3 objects that Macie can analyze as part of a classification job.
* Core 3.5.1.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.7.0 (2020-09-01 18:15 UTC)
* CodeGuruReviewer (3.5.1.0)
	* Add support for repository analysis based code reviews
* SecurityHub (3.5.1.0)
	* Added a PatchSummary object for security findings. The PatchSummary object provides details about the patch compliance status of an instance.

### 3.5.6.1 (2020-08-31 23:52 UTC)
* DynamoDBv2 (3.5.0.7)
	* Fixed DynamoDB table not found error by passing config object down function call stack
* Core 3.5.1.5
	* -Update Copyright Statement in SDK
-Refactor DetermineRegion by matching with regions in endpoints.json
	* All services packages updated to require new Core

### 3.5.6.0 (2020-08-31 18:22 UTC)
* Backup (3.5.0.6)
	* Documentation updates for Cryo
* CloudFront (3.5.2.0)
	* CloudFront now supports real-time logging for CloudFront distributions. CloudFront real-time logs are more detailed, configurable, and are available in real time.
* EC2 (3.5.3.0)
	* Amazon EC2 and Spot Fleet now support modification of launch template configs for a running fleet enabling instance type, instance weight, AZ, and AMI updates without losing the current fleet ID.
* SQS (3.5.0.6)
	* Documentation updates for SQS.
* Core 3.5.1.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.5.0 (2020-08-28 18:11 UTC)
* CloudFront (3.5.1.0)
	* You can now manage CloudFront's additional, real-time metrics with the CloudFront API.
* CostAndUsageReport (3.5.1.0)
	* This release add MONTHLY as the new supported TimeUnit for ReportDefinition.
* ElasticMapReduce (3.5.1.0)
	* Amazon EMR adds support for ICMP, port -1, in Block Public Access Exceptions and API access for EMR Notebooks execution. You can now non-interactively execute EMR Notebooks and pass input parameters.
* Route53 (3.5.0.5)
	* Documentation updates for Route 53
* Core 3.5.1.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.4.0 (2020-08-27 18:13 UTC)
* EC2 (3.5.2.0)
	* Introduces support to initiate Internet Key Exchange (IKE) negotiations for VPN connections from AWS. A user can now send the initial IKE message to their Customer Gateway (CGW) from VPN endpoints.
* GameLift (3.5.1.0)
	* GameLift FleetIQ as a standalone feature is now generally available. FleetIQ makes low-cost Spot instances viable for game hosting. Use GameLift FleetIQ with your EC2 Auto Scaling groups.
* MediaConvert (3.5.1.0)
	* AWS Elemental MediaConvert SDK has added support for WebM DASH outputs as well as H.264 4:2:2 10-bit output in MOV and MP4.
* Redshift (3.5.0.4)
	* Documentation updates for Amazon Redshift.
* Core 3.5.1.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.3.0 (2020-08-26 21:07 UTC)
* Appflow (3.5.0.0)
	* Amazon AppFlow is a fully managed integration service that securely transfers data between AWS services and SaaS applications. This update releases the first version of Amazon AppFlow APIs and SDK.
* Route53Resolver (3.5.1.0)
	* Route 53 Resolver adds support for resolver query logs
* Core 3.5.1.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.2.0 (2020-08-24 22:27 UTC)
* Core 3.5.1.0
	* Add paginator support
	* All services packages updated to require new Core

### 3.5.1.0 (2020-08-24 19:51 UTC)
* CloudWatchLogs (3.5.0.1)
	* Documentation updates for CloudWatch Logs
* DatabaseMigrationService (3.5.1.0)
	* Added new endpoint settings to include columns with Null and Empty value when using Kinesis and Kafka as target. Added a new endpoint setting to set maximum message size when using Kafka as target.
* EC2 (3.5.1.0)
	* This release enables customers to use VPC prefix lists in their transit gateway route tables, and it adds support for Provisioned IOPS SSD (io2) EBS volumes.
* IoTSiteWise (3.5.1.0)
	* Add traversalDirection to ListAssociatedAssetsRequest and add portal status to ListPortalsResponse
* Kafka (3.5.1.0)
	* Add UpdateConfiguration and DeleteConfiguration operations.
* SimpleSystemsManagement (3.5.1.0)
	* Add string length constraints to OpsDataAttributeName and OpsFilterValue.
* XRay (3.5.1.0)
	* AWS X-Ray now supports tagging on sampling rules and groups.
* Core 3.5.0.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.5.0.0 (2020-08-20 21:00 UTC)
* All (Core and Services) updated to version 3.5.0.0
   * Additional target for .NET Core 3.1
   * Support for Unity, Xamarin, UWP, and PCL transitioned to .NET Standard 2.0
   * EOL platforms removed (Windows Phone, Silverlight)
   * Cognito Sync Manager, Mobile Analytics Manager extracted from SDK

### 3.3.802.0 (2020-08-20 18:12 UTC)
* ApiGatewayV2 (3.3.108.0)
	* Customers can now create Amazon API Gateway HTTP APIs that route requests to AWS AppConfig, Amazon EventBridge, Amazon Kinesis Data Streams, Amazon SQS, and AWS Step Functions.
* Chime (3.3.115.8)
	* Documentation updates for chime
* FSx (3.3.109.3)
	* Documentation updates for Amazon FSx

### 3.3.801.0 (2020-08-19 18:39 UTC)
* IVS (3.3.102.0)
	* Amazon Interactive Video Service (IVS) now offers customers the ability to create private channels, allowing customers to restrict their streams by channel or viewer.
* LakeFormation (3.3.102.0)
	* Adding additional field in ListPermissions API response to return RAM resource share ARN if a resource were shared through AWS RAM service.
* Organizations (3.3.109.4)
	* Minor documentation updates for AWS Organizations
* ServiceCatalog (3.3.114.0)
	* Enhance SearchProvisionedProducts API to allow queries using productName and provisioningArtifactName. Added lastProvisioningRecordId and lastSuccessfulRecordId to Read ProvisionedProduct APIs
* StorageGateway (3.3.118.0)
	* Added WORM, tape retention lock, and custom pool features for virtual tapes.
* Core 3.3.107.40
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.800.0 (2020-08-18 18:14 UTC)
* CodeBuild (3.3.114.8)
	* Documentation updates for codebuild
* CognitoIdentityProvider (3.3.113.0)
	* Adding the option to use a service linked role to publish events to Pinpoint.
* DataSync (3.3.110.0)
	* DataSync support for filters as input arguments to the ListTasks and ListLocations API calls.
* IdentityStore (3.3.100.0)
	* AWS Single Sign-On (SSO) Identity Store service provides an interface to retrieve all of your users and groups. It enables entitlement management per user or group for AWS SSO and other IDPs.
* SecurityHub (3.3.116.0)
	* New details for DynamoDB tables, Elastic IP addresses, IAM policies and users, RDS DB clusters and snapshots, and Secrets Manager secrets. Added details for AWS KMS keys and RDS DB instances.
* SimpleEmailV2 (3.3.105.0)
	* This release includes new APIs to allow customers to add or remove email addresses from their account-level suppression list in bulk.

### 3.3.799.0 (2020-08-17 18:13 UTC)
* ACMPCA (3.3.102.0)
	* ACM Private CA is launching cross-account support. This allows customers to share their private CAs with other accounts, AWS Organizations, and organizational units to issue end-entity certificates.
* CertificateManager (3.3.102.0)
	* ACM provides support for the new Private CA feature Cross-account CA sharing. ACM users can issue certificates signed by a private CA belonging to another account where the CA was shared with them.
* ECR (3.3.108.0)
	* This feature adds support for pushing and pulling Open Container Initiative (OCI) artifacts.
* ElasticLoadBalancing (3.3.100.222)
	* Adds support for HTTP Desync Mitigation in Classic Load Balancers.
* ElasticLoadBalancingV2 (3.3.105.36)
	* Adds support for HTTP Desync Mitigation in Application Load Balancers.
* Kinesis (3.3.101.0)
	* Introducing ShardFilter for ListShards API to filter the shards using a position in the stream, and ChildShards support for GetRecords and SubscribeToShard API to discover children shards on shard end
* QuickSight (3.3.108.0)
	* Amazon QuickSight now supports programmatic creation and management of analyses with new APIs.
* RoboMaker (3.3.112.0)
	* This release introduces RoboMaker Simulation WorldForge, a capability that automatically generates one or more simulation worlds.

### 3.3.798.0 (2020-08-14 18:10 UTC)
* AppStream (3.3.106.0)
	* Adds support for the Desktop View feature
* Braket (3.3.101.0)
	* Fixing bug in our SDK model where device status and device type had been flipped.
* EC2 (3.3.201.0)
	* New C5ad instances featuring AMD's 2nd Generation EPYC processors, offering up to 96 vCPUs, 192 GiB of instance memory, 3.8 TB of NVMe based SSD instance storage, and 20 Gbps in Network bandwidth
* LicenseManager (3.3.101.115)
	* This release includes ability to enforce license assignment rules with EC2 Dedicated Hosts.
* SageMaker (3.3.120.0)
	* Amazon SageMaker now supports 1) creating real-time inference endpoints using model container images from Docker registries in customers' VPC 2) AUC(Area under the curve) as AutoPilot objective metric
* Core 3.3.107.39
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.797.0 (2020-08-13 18:12 UTC)
* AppSync (3.3.106.4)
	* Documentation update for AWS AppSync support for Direct Lambda Resolvers.
* Braket (3.3.100.0)
	* Amazon Braket general availability with Device and Quantum Task operations.
* CognitoIdentityProvider (3.3.112.0)
	* Adding ability to customize expiry for Refresh, Access and ID tokens.
* EC2 (3.3.200.0)
	* Added MapCustomerOwnedIpOnLaunch and CustomerOwnedIpv4Pool to ModifySubnetAttribute to allow CoIP auto assign. Fields are returned in DescribeSubnets and DescribeNetworkInterfaces responses.
* EKS (3.3.111.0)
	* Adding support for customer provided EC2 launch templates and AMIs to EKS Managed Nodegroups. Also adds support for Arm-based instances to EKS Managed Nodegroups.
* Macie2 (3.3.103.10)
	* This release of the Amazon Macie API includes miscellaneous updates and improvements to the documentation.
* RDS (3.3.128.0)
	* This release allows customers to specify a replica mode when creating or modifying a Read Replica, for DB engines which support this feature.

### 3.3.796.0 (2020-08-12 18:17 UTC)
* Cloud9 (3.3.103.0)
	* Add ConnectionType input parameter to CreateEnvironmentEC2 endpoint. New parameter enables creation of environments with SSM connection.
* Comprehend (3.3.110.0)
	* Amazon Comprehend Custom Entity Recognition now supports Spanish, German, French, Italian and Portuguese and up to 25 entity types per model.
* EC2 (3.3.199.0)
	* Introduces support for IPv6-in-IPv4 IPsec tunnels. A user can now send traffic from their on-premise IPv6 network to AWS VPCs that have IPv6 support enabled.
* FSx (3.3.109.0)
	* This release adds the capability to create persistent file systems for throughput-intensive workloads using Hard Disk Drive (HDD) storage and an optional read-only Solid-State Drive (SSD) cache.
* IoT (3.3.112.0)
	* Audit finding suppressions: Device Defender enables customers to turn off non-compliant findings for specific resources on a per check basis.
* Lambda (3.3.112.0)
	* Support for creating Lambda Functions using 'java8.al2' and 'provided.al2'
* Transfer (3.3.108.0)
	* Adds security policies to control cryptographic algorithms advertised by your server, additional characters in usernames and length increase, and FIPS compliant endpoints in the US and Canada regions.
* WorkSpaces (3.3.110.0)
	* Adds optional EnableWorkDocs property to WorkspaceCreationProperties in the ModifyWorkspaceCreationProperties API

### 3.3.795.0 (2020-08-11 19:16 UTC)
* EC2 (3.3.198.0)
	* This release rolls back the EC2 On-Demand Capacity Reservations (ODCRs) release 1.11.831 published on 2020-07-30, which was deployed in error.
* Lambda (3.3.111.0)
	* Support Managed Streaming for Kafka as an Event Source. Support retry until record expiration for Kinesis and Dynamodb streams event source mappings.
* Organizations (3.3.109.2)
	* Minor documentation update for AWS Organizations
* S3 (3.3.113.0)
	* Add support for in-region CopyObject and UploadPartCopy through S3 Access Points

### 3.3.794.0 (2020-08-10 18:14 UTC)
* EC2 (3.3.197.0)
	* Remove CoIP Auto-Assign feature references.
* Glue (3.3.126.0)
	* Starting today, you can further control orchestration of your ETL workloads in AWS Glue by specifying the maximum number of concurrent runs for a Glue workflow.
* SavingsPlans (3.3.103.0)
	* Updates to the list of services supported by this API.
* Core 3.3.107.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.793.0 (2020-08-07 22:16 UTC)
* Glue (3.3.125.0)
	* AWS Glue now adds support for Network connection type enabling you to access resources inside your VPC using Glue crawlers and Glue ETL jobs.
* Organizations (3.3.109.0)
	* Documentation updates for some new error reasons.
* S3 (3.3.112.0)
	* Updates Amazon S3 API reference documentation.
	* Add obsolete tag with notice of interfaces entering maintenance mode.
* ServerMigrationService (3.3.101.0)
	* In this release, AWS Server Migration Service (SMS) has added new features: 1. APIs to work with application and instance level validation 2. Import application catalog from AWS Application Discovery Service 3. For an application you can start on-demand replication
* Core 3.3.107.37
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.792.0 (2020-08-06 18:18 UTC)
* EC2 (3.3.196.0)
	* This release supports Wavelength resources, including carrier gateways, and carrier IP addresses.
* Lex (3.3.105.0)
	* Amazon Lex supports intent classification confidence scores along with a list of the top five intents.
* LexModelBuildingService (3.3.106.0)
	* Amazon Lex supports the option to enable accuracy improvements and specify an intent classification confidence score threshold.
* Personalize (3.3.106.0)
	* Add 'exploration' functionality
* PersonalizeEvents (3.3.101.0)
	* Adds support implicit and explicit impression input
* PersonalizeRuntime (3.3.106.0)
	* Adds support for implicit impressions
* Core 3.3.107.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.791.0 (2020-08-05 18:55 UTC)
* AppSync (3.3.106.0)
	* AWS AppSync releases support for Direct Lambda Resolvers.
* FSx (3.3.108.8)
	* Documentation updates for StorageCapacity input value format.
* ResourceGroupsTaggingAPI (3.3.103.114)
	* Documentation updates for the Resource Group Tagging API namespace.
* SimpleNotificationService (3.3.102.12)
	* Documentation updates for SNS.
* TranscribeService (3.3.117.0)
	* Amazon Transcribe now supports custom language models, which can improve transcription accuracy for your specific use case.

### 3.3.790.3 (2020-08-04 23:20 UTC)
* S3 (3.3.111.37)
	* AmazonS3Uri expects an encoded string or URI, AmazonS3Uri Key is now decoded; Fixes for S3Region

### 3.3.790.2 (2020-08-04 18:10 UTC)
* AWSHealth (3.3.103.36)
	* Documentation updates for health
* Core 3.3.107.35
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.790.1 (2020-08-03 23:56 UTC)
* Core 3.3.107.34
	* Updated docs scripts for GDPR Cookie Consent

### 3.3.790.0 (2020-08-03 21:11 UTC)
* SimpleSystemsManagement (3.3.127.0)
	* Adds a waiter for CommandExecuted and paginators for various other APIs.
* Core 3.3.107.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.789.0 (2020-07-31 18:32 UTC)
* Chime (3.3.115.0)
	* This release increases the CreateMeetingWithAttendee max attendee limit to 10.
* PersonalizeRuntime (3.3.105.0)
	* Adds support to use filters with Personalized Ranking recipe
* ResourceGroupsTaggingAPI (3.3.103.111)
	* Updates to the list of services supported by this API.
* StorageGateway (3.3.117.0)
	* Add support for gateway VM deprecation dates
* WAFV2 (3.3.103.0)
	* Add ManagedByFirewallManager flag to the logging configuration, which indicates whether AWS Firewall Manager controls the configuration.
* Core 3.3.107.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.788.0 (2020-07-30 18:14 UTC)
* CloudFront (3.3.104.5)
	* Documentation updates for CloudFront
* CodeBuild (3.3.114.0)
	* Adding support for BuildBatch, and CodeCoverage APIs. BuildBatch allows you to model your project environment in source, and helps start multiple builds with a single API call. CodeCoverage allows you to track your code coverage using AWS CodeBuild. 
* EC2 (3.3.195.0)
	* EC2 On-Demand Capacity Reservations now adds support to bring your own licenses (BYOL) of Windows operating system to launch EC2 instances. 
* GuardDuty (3.3.110.0)
	* GuardDuty can now provide detailed cost metrics broken down by account, data source, and S3 resources, based on the past 30 days of usage.  This new feature also supports viewing cost metrics for all member accounts as a GuardDuty master.
* Kafka (3.3.109.0)
	* Amazon MSK has added a new API that allows you to reboot brokers within a cluster. 
* Organizations (3.3.108.9)
	* Documentation updates for AWS Organizations
* ResourceGroups (3.3.102.1)
	* Improved documentation for Resource Groups API operations.
* ServiceCatalog (3.3.113.0)
	* This release adds support for ProvisionProduct, UpdateProvisionedProduct & DescribeProvisioningParameters by product name, provisioning artifact name and path name. In addition DescribeProvisioningParameters now returns a list of provisioning artifact outputs.
* SimpleEmailV2 (3.3.104.0)
	* This release makes more API operations available to customers in version 2 of the Amazon SES API. With these additions, customers can now access sending authorization, custom verification email, and template API operations.  With this release, Amazon SES is also providing new and updated APIs to allow customers to request production access.
* Core 3.3.107.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.787.0 (2020-07-29 18:16 UTC)
* EC2 (3.3.194.0)
	* Adding support to target EC2 On-Demand Capacity Reservations within an AWS Resource Group to launch EC2 instances.
* ECR (3.3.107.0)
	* This release adds support for encrypting the contents of your Amazon ECR repository with customer master keys (CMKs) stored in AWS Key Management Service.
* GuardDuty (3.3.109.0)
	* GuardDuty now supports S3 Data Events as a configurable data source type. This feature expands GuardDuty's monitoring scope to include S3 data plane operations, such as GetObject and PutObject. This data source is optional and can be enabled or disabled at anytime. Accounts already using GuardDuty must first enable the new feature to use it; new accounts will be enabled by default. GuardDuty masters can configure this data source for individual member accounts and GuardDuty masters associated through AWS Organizations can automatically enable the data source in member accounts.
* KinesisFirehose (3.3.105.0)
	* This release includes a new Kinesis Data Firehose feature that supports data delivery to Https endpoint and to partners. You can now use Kinesis Data Firehose to ingest real-time data and deliver to Https endpoint and partners in a serverless, reliable, and salable manner.
* ResourceGroups (3.3.102.0)
	* Resource Groups released a new feature that enables you to create a group with an associated configuration that specifies how other AWS services interact with the group. There are two new operations `GroupResources` and `UngroupResources` to work on a group with a configuration. In this release, you can associate EC2 Capacity Reservations with a resource group. Resource Groups also added a new request parameter `Group` to replace `GroupName` for all existing operations.
* ServiceDiscovery (3.3.102.0)
	* Added new attribute AWS_EC2_INSTANCE_ID for RegisterInstance API 
* Core 3.3.107.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.786.0 (2020-07-28 20:33 UTC)
* AutoScaling (3.3.104.0)
	* Now you can enable Instance Metadata Service Version 2 (IMDSv2) or disable the instance metadata endpoint with Launch Configurations.
* EC2 (3.3.193.0)
	* Introduces support for tag-on-create capability for the following APIs: CreateVpnConnection, CreateVpnGateway, and CreateCustomerGateway. A user can now add tags while creating these resources. For further detail, please see AWS Tagging Strategies.
* Imagebuilder (3.3.107.0)
	* This release updates distribution configurations to allow periods in AMI names.
* IVS (3.3.101.0)
	* Added a new error code, PendingVerification, to differentiate between errors caused by insufficient IAM permissions and errors caused by account verification.
* MediaLive (3.3.114.0)
	* AWS Elemental MediaLive now supports several new features: EBU-TT-D captions in Microsoft Smooth outputs; interlaced video in HEVC outputs; video noise reduction (using temporal filtering) in HEVC outputs.
* RDS (3.3.127.0)
	* Adds reporting of manual cluster snapshot quota to DescribeAccountAttributes API
* SecurityHub (3.3.115.0)
	* Added UpdateSecurityHubConfiguration API. Security Hub now allows customers to choose whether to automatically enable new controls that are added to an existing standard that the customer enabled. For example, if you enabled Foundational Security Best Practices for an account, you can automatically enable new controls as we add them to that standard. By default, new controls are enabled.
* Core 3.3.107.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.785.0 (2020-07-27 18:13 UTC)
* DatabaseMigrationService (3.3.106.0)
	* Basic endpoint settings for relational databases, Preflight validation API.
* DataSync (3.3.109.0)
	* Today AWS DataSync releases support for self-managed object storage Locations and the new TransferMode Option.
* EC2 (3.3.192.0)
	* m6gd, c6gd, r6gd instances are powered by AWS Graviton2 processors and support local NVMe instance storage
* FraudDetector (3.3.104.0)
	* Moved the eventTypeName attribute for PutExternalModel API to inputConfiguration. Model ID's no longer allow hyphens.
* Glue (3.3.124.0)
	* Add ability to manually resume workflows in AWS Glue providing customers further control over the orchestration of ETL workloads.
* SimpleSystemsManagement (3.3.126.17)
	* Assorted doc ticket-fix updates for Systems Manager.

### 3.3.784.0 (2020-07-24 18:14 UTC)
* CloudWatch (3.3.108.0)
	* AWS CloudWatch ListMetrics now supports an optional parameter (RecentlyActive) to filter results by only metrics that have received new datapoints in the past 3 hours. This enables more targeted metric data retrieval through the Get APIs
* FraudDetector (3.3.103.0)
	* GetPrediction has been replaced with GetEventPrediction. PutExternalModel has been simplified to accept a role ARN.
* FSx (3.3.108.1)
	* Documentation update for FSx for Lustre
* Kendra (3.3.104.0)
	* Amazon Kendra now supports sorting query results based on document attributes. Amazon Kendra also introduced an option to enclose table and column names with double quotes for database data sources. 
* Macie2 (3.3.103.0)
	* This release of the Amazon Macie API introduces additional criteria for sorting and filtering query results for account quotas and usage statistics.
* MediaConnect (3.3.109.0)
	* You can now disable an entitlement to stop streaming content to the subscriber's flow temporarily. When you are ready to allow content to start streaming to the subscriber's flow again, you can enable the entitlement.
* MediaPackage (3.3.105.0)
	* The release adds daterange as a new ad marker option. This option enables MediaPackage to insert EXT-X-DATERANGE tags in HLS and CMAF manifests. The EXT-X-DATERANGE tag is used to signal ad and program transition events.
* MQ (3.3.106.0)
	* Amazon MQ now supports LDAP (Lightweight Directory Access Protocol), providing authentication and authorization of Amazon MQ users via a customer designated LDAP server.
* SageMaker (3.3.119.0)
	* Sagemaker Ground Truth:Added support for OIDC (OpenID Connect) to authenticate workers via their own identity provider instead of through Amazon Cognito. This release adds new APIs (CreateWorkforce, DeleteWorkforce, and ListWorkforces) to SageMaker Ground Truth service.  Sagemaker Neo: Added support for detailed target device description by using TargetPlatform fields - OS, architecture, and accelerator. Added support for additional compilation parameters by using JSON field CompilerOptions.  Sagemaker Search: SageMaker Search supports transform job details in trial components.

### 3.3.783.0 (2020-07-23 18:16 UTC)
* ConfigService (3.3.109.0)
	* Adding service linked configuration aggregation support along with new enums for config resource coverage
* DirectConnect (3.3.105.23)
	* Documentation updates for AWS Direct Connect
* FSx (3.3.108.0)
	* Adds support for AutoImport, a new FSx for Lustre feature that allows customers to configure their FSx file system to automatically update its contents when new objects are added to S3 or existing objects are overwritten.
* Glue (3.3.123.0)
	* Added new ConnectionProperties: "KAFKA_SSL_ENABLED" (to toggle SSL connections) and "KAFKA_CUSTOM_CERT" (import CA certificate file)
* Lightsail (3.3.106.0)
	* This release adds support for Amazon Lightsail content delivery network (CDN) distributions and SSL/TLS certificates.
* WorkSpaces (3.3.109.0)
	* Added UpdateWorkspaceImagePermission API to share Amazon WorkSpaces images across AWS accounts.
* Core 3.3.107.28
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.782.0 (2020-07-22 18:15 UTC)
* MediaLive (3.3.113.0)
	* The AWS Elemental MediaLive APIs and SDKs now support the ability to get thumbnails for MediaLive devices that are attached or not attached to a channel. Previously, this thumbnail feature was available only on the console.
* QuickSight (3.3.107.0)
	* New API operations - GetSessionEmbedUrl, CreateNamespace, DescribeNamespace, ListNamespaces, DeleteNamespace, DescribeAccountSettings, UpdateAccountSettings, CreateAccountCustomization, DescribeAccountCustomization, UpdateAccountCustomization, DeleteAccountCustomization. Modified API operations to support custom permissions restrictions - RegisterUser, UpdateUser, UpdateDashboardPermissions
* Core 3.3.107.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.781.1 (2020-07-21 22:26 UTC)
* S3 (3.3.111.28)
	* Make IAmazonS3Encryption publicly accessible

### 3.3.781.0 (2020-07-21 18:10 UTC)
* CodeGuruProfiler (3.3.103.0)
	* Amazon CodeGuru Profiler now supports resource tagging APIs, tags-on-create and tag-based access control features. You can now tag profiling groups for better resource and access control management.

### 3.3.780.0 (2020-07-20 18:17 UTC)
* CloudFront (3.3.104.0)
	* CloudFront adds support for cache policies and origin request policies. With these new policies, you can now more granularly control the query string, header, and cookie values that are included in the cache key and in requests that CloudFront sends to your origin.
* CodeBuild (3.3.113.0)
	* AWS CodeBuild adds support for Session Manager and Windows 2019 Environment type
* EC2 (3.3.191.0)
	* Added support for tag-on-create for CreateVpcPeeringConnection and CreateRouteTable. You can now specify tags when creating any of these resources. For more information about tagging, see AWS Tagging Strategies. Add poolArn to the response of DescribeCoipPools.
* FMS (3.3.106.0)
	* Added managed policies for auditing security group rules, including the use of managed application and protocol lists.
* FraudDetector (3.3.102.0)
	* Introduced flexible model training dataset requirements for Online Fraud Insights so that customers can choose any two inputs to train a model instead of being required to use 'email' and 'IP address' at minimum. Added support for resource ARNs, resource tags, resource-based IAM policies and identity-based policies that limit access to a resource based on tags. Added support for customer-managed customer master key (CMK) data encryption. Added new Event Type, Entity Type, and Label APIs. An event type defines the structure for an event sent to Amazon Fraud Detector, including the variables sent as part of the event, the entity performing the event, and the labels that classify the event. Introduced the GetEventPrediction API.
* GroundStation (3.3.102.0)
	* Adds optional MTU property to DataflowEndpoint and adds contact source and destination details to DescribeContact response.
* RDS (3.3.126.0)
	* Add a new SupportsParallelQuery output field to DescribeDBEngineVersions. This field shows whether the engine version supports parallelquery. Add a new SupportsGlobalDatabases output field to DescribeDBEngineVersions and DescribeOrderableDBInstanceOptions. This field shows whether global database is supported by engine version or the combination of engine version and instance class.

### 3.3.779.0 (2020-07-17 18:14 UTC)
* ApplicationAutoScaling (3.3.105.45)
	* Documentation updates for Application Auto Scaling
* AppSync (3.3.105.7)
	* Documentation update to Cachingconfig.cachingKeys to include $context.source as a valid value.
* Connect (3.3.104.0)
	* This release adds a set of Amazon Connect APIs to programmatically control call recording with start, stop, pause and resume functions.
* EC2 (3.3.190.0)
	* Documentation updates for EC2
* ElasticBeanstalk (3.3.103.0)
	* Add waiters for `EnvironmentExists`, `EnvironmentUpdated`, and `EnvironmentTerminated`. Add paginators for `DescribeEnvironmentManagedActionHistory` and `ListPlatformVersions`.
* Macie2 (3.3.102.0)
	* This release of the Amazon Macie API includes miscellaneous updates and improvements to the documentation.
* Core 3.3.107.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.778.0 (2020-07-15 18:16 UTC)
* IVS (3.3.100.0)
	* Introducing Amazon Interactive Video Service - a managed live streaming solution that is quick and easy to set up, and ideal for creating interactive video experiences.
* Core 3.3.107.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.777.1 (2020-07-09 21:59 UTC)
* Core 3.3.107.24
	* Consistently apply ConfigureAwait(false)
	* All services packages updated to require new Core

### 3.3.777.0 (2020-07-09 18:16 UTC)
* AlexaForBusiness (3.3.110.0)
	* Added support for registering an AVS device directly to a room using RegisterAVSDevice with a room ARN
* Amplify (3.3.105.8)
	* Documentation update to the introduction text to specify that this is the Amplify Console API.
* AppMesh (3.3.111.0)
	* AppMesh now supports Ingress which allows resources outside a mesh to communicate to resources that are inside the mesh. See https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_gateways.html
* CloudHSMV2 (3.3.101.81)
	* Documentation updates for cloudhsmv2
* CloudWatchEvents (3.3.103.0)
	* Amazon CloudWatch Events/EventBridge adds support for API Gateway as a target.
* Comprehend (3.3.109.0)
	* AWS Comprehend now supports Real-time Analysis with Custom Entity Recognition. 
* EBS (3.3.101.0)
	* This release introduces the following set of actions for the EBS direct APIs: 1. StartSnapshot, which creates a new Amazon EBS snapshot. 2. PutSnapshotBlock, which writes a block of data to a snapshot. 3. CompleteSnapshot, which seals and completes a snapshot after blocks of data have been written to it.
* EventBridge (3.3.102.0)
	* Amazon EventBridge adds support for API Gateway as a target.
* SageMaker (3.3.118.0)
	* This release adds the DeleteHumanTaskUi API to Amazon Augmented AI
* SecretsManager (3.3.103.0)
	* Adds support for filters on the ListSecrets API to allow filtering results by name, tag key, tag value, or description.  Adds support for the BlockPublicPolicy option on the PutResourcePolicy API to block resource policies which grant a wide range of IAM principals access to secrets. Adds support for the ValidateResourcePolicy API to validate resource policies for syntax and prevent lockout error scenarios and wide access to secrets. 
* SimpleNotificationService (3.3.102.0)
	* This release adds support for SMS origination number as an attribute in the MessageAttributes parameter for the SNS Publish API.
* WAFV2 (3.3.102.0)
	* Added the option to use IP addresses from an HTTP header that you specify, instead of using the web request origin. Available for IP set matching, geo matching, and rate-based rule count aggregation.
* Core 3.3.107.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.776.0 (2020-07-08 18:11 UTC)
* CostExplorer (3.3.110.0)
	* Customers can now see Instance Name alongside each rightsizing recommendation.
* EC2 (3.3.189.0)
	* EC2 Spot now enables customers to tag their Spot Instances Requests on creation.
* ForecastService (3.3.102.0)
	* With this release, Amazon Forecast now supports the ability to add a tag to any resource via the launch of three new APIs: TagResouce, UntagResource and ListTagsForResource. A tag is a simple label consisting of a customer-defined key and an optional value allowing for easier resource management.
* Organizations (3.3.108.0)
	* We have launched a self-service option to make it easier for customers to manage the use of their content by AI services. Certain AI services (Amazon CodeGuru Profiler, Amazon Comprehend, Amazon Lex, Amazon Polly, Amazon Rekognition, Amazon Textract, Amazon Transcribe, and Amazon Translate) may use content to improve the service. Customers have been able to opt out of this use by contacting AWS Support, and now they can opt out on a self-service basis by setting an Organizations policy for all or an individual AI service listed above. Please refer to the technical documentation in the online AWS Organizations User Guide for more details.
* Core 3.3.107.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.775.0 (2020-07-07 18:32 UTC)
* CloudFront (3.3.103.0)
	* Amazon CloudFront adds support for a new security policy, TLSv1.2_2019.
* EC2 (3.3.188.0)
	* DescribeAvailabilityZones now returns additional data about Availability Zones and Local Zones.
* ElasticFileSystem (3.3.106.0)
	* This release adds support for automatic backups of Amazon EFS file systems to further simplify backup management. 
* Glue (3.3.122.0)
	* AWS Glue Data Catalog supports cross account sharing of tables through AWS Lake Formation
* LakeFormation (3.3.101.0)
	*  AWS Lake Formation supports sharing tables with other AWS accounts and organizations
* StorageGateway (3.3.116.0)
	* Adding support for file-system driven directory refresh, Case Sensitivity toggle for SMB File Shares, and S3 Prefixes and custom File Share names
* Core 3.3.107.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.774.0 (2020-07-06 18:11 UTC)
* IoTSiteWise (3.3.102.0)
	* This release supports optional start date and end date parameters for the GetAssetPropertyValueHistory API.
* QuickSight (3.3.106.0)
	* Add Theme APIs and update Dashboard APIs to support theme overrides.
* RDS (3.3.125.0)
	* Adds support for Amazon RDS on AWS Outposts.

### 3.3.773.1 (2020-07-02 18:09 UTC)
* Connect (3.3.103.101)
	* Documentation updates for Amazon Connect.
* ElastiCache (3.3.111.15)
	* Documentation updates for elasticache
* Core 3.3.107.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.773.0 (2020-07-01 18:18 UTC)
* AppSync (3.3.105.0)
	* AWS AppSync supports new 12xlarge instance for server-side API caching
* Chime (3.3.114.0)
	* This release supports third party emergency call routing configuration for Amazon Chime Voice Connectors.
* CodeBuild (3.3.112.0)
	* Support build status config in project source
* Imagebuilder (3.3.106.0)
	* EC2 Image Builder adds support for encrypted AMI distribution.
* RDS (3.3.124.0)
	* This release adds the exceptions KMSKeyNotAccessibleFault and InvalidDBClusterStateFault to the Amazon RDS ModifyDBInstance API.
* SecurityHub (3.3.114.0)
	* This release adds additional details for findings. There are now finding details for auto scaling groups, EC2 volumes, and EC2 VPCs. You can identify detected vulnerabilities and provide related network paths.

### 3.3.772.0 (2020-06-30 18:14 UTC)
* CodeGuruReviewer (3.3.104.0)
	* Release GitHub Enterprise Server source provider integration
* ComprehendMedical (3.3.105.0)
	* This release adds the relationships between MedicalCondition and Anatomy in DetectEntitiesV2 API.
* EC2 (3.3.187.0)
	* Added support for tag-on-create for CreateVpc, CreateEgressOnlyInternetGateway, CreateSecurityGroup, CreateSubnet, CreateNetworkInterface, CreateNetworkAcl, CreateDhcpOptions and CreateInternetGateway. You can now specify tags when creating any of these resources. For more information about tagging, see AWS Tagging Strategies.
* ECR (3.3.106.0)
	* Add a new parameter (ImageDigest) and a new exception (ImageDigestDoesNotMatchException) to PutImage API to support pushing image by digest.
* RDS (3.3.123.7)
	* Documentation updates for rds

### 3.3.771.0 (2020-06-29 18:15 UTC)
* AutoScaling (3.3.103.9)
	* Documentation updates for Amazon EC2 Auto Scaling.
* CodeGuruProfiler (3.3.102.0)
	* Amazon CodeGuru Profiler is now generally available. The Profiler helps developers to optimize their software, troubleshoot issues in production, and identify their most expensive lines of code. As part of general availability, we are launching: Profiling of AWS Lambda functions, Anomaly detection in CPU profiles, Color My Code on flame graphs, Expanding presence to 10 AWS regions.
* CodeStarconnections (3.3.102.0)
	* Updated and new APIs in support of hosts for connections to installed provider types. New integration with the GitHub Enterprise Server provider type.
* EC2 (3.3.186.0)
	* Virtual Private Cloud (VPC) customers can now create and manage their own Prefix Lists to simplify VPC configurations.
* Core 3.3.107.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.770.0 (2020-06-26 18:21 UTC)
* CloudFormation (3.3.106.0)
	* ListStackInstances and DescribeStackInstance now return a new `StackInstanceStatus` object that contains `DetailedStatus` values: a disambiguation of the more generic `Status` value. ListStackInstances output can now be filtered on `DetailedStatus` using the new `Filters` parameter.
* CognitoIdentityProvider (3.3.111.0)
	* Don't require Authorization for InitiateAuth and RespondToAuthChallenge.
* DatabaseMigrationService (3.3.105.34)
	* This release contains miscellaneous API documentation updates for AWS DMS in response to several customer reported issues.
* QuickSight (3.3.105.0)
	* Added support for cross-region DataSource credentials copying.
* SageMaker (3.3.117.0)
	* The new 'ModelClientConfig' parameter being added for CreateTransformJob and DescribeTransformJob api actions enable customers to configure model invocation related parameters such as timeout and retry.
* Core 3.3.107.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.769.0 (2020-06-25 18:44 UTC)
* EC2 (3.3.185.0)
	* Added support for tag-on-create for Host Reservations in Dedicated Hosts. You can now specify tags when you create a Host Reservation for a Dedicated Host. For more information about tagging, see AWS Tagging Strategies.
* Glue (3.3.121.0)
	* This release adds new APIs to support column level statistics in AWS Glue Data Catalog
* Core 3.3.107.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.768.1 (2020-06-24 21:08 UTC)
* Core 3.3.107.16
	* Fixed async issue hanging the UI thread
	* All services packages updated to require new Core

### 3.3.768.0 (2020-06-24 18:13 UTC)
* Amplify (3.3.105.0)
	* This release of AWS Amplify Console introduces support for automatically creating custom subdomains for branches based on user-defined glob patterns, as well as automatically cleaning up Amplify branches when their corresponding git branches are deleted.
* AutoScaling (3.3.103.5)
	* Documentation updates for Amazon EC2 Auto Scaling.
* Backup (3.3.103.0)
	* Customers can now manage and monitor their backups in a policied manner across their AWS accounts, via an integration between AWS Backup and AWS Organizations
* CodeCommit (3.3.107.0)
	* This release introduces support for reactions to CodeCommit comments. Users will be able to select from a pre-defined list of emojis to express their reaction to any comments.
* ElasticMapReduce (3.3.108.0)
	* Amazon EMR customers can now set allocation strategies for On-Demand and Spot instances in their EMR clusters with instance fleets. These allocation strategies use real-time capacity insights to provision clusters faster and make the most efficient use of available spare capacity to allocate Spot instances to reduce interruptions. 
* FSx (3.3.107.0)
	* This release adds the capability to take highly-durable, incremental backups of your FSx for Lustre persistent file systems. This capability makes it easy to further protect your file system data and to meet business and regulatory compliance requirements.
* Honeycode (3.3.100.0)
	* Introducing Amazon Honeycode - a fully managed service that allows you to quickly build mobile and web apps for teams without programming.
* IdentityManagement (3.3.106.10)
	* Documentation updates for iam
* Organizations (3.3.107.0)
	* This release adds support for a new backup policy type for AWS Organizations.
* Core 3.3.107.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.767.0 (2020-06-23 18:44 UTC)
* MediaTailor (3.3.105.0)
	* AWS Elemental MediaTailor SDK now allows configuration of Bumper.
* Organizations (3.3.106.0)
	* Added a new error message to support the requirement for a Business License on AWS accounts in China to create an organization.
* Core 3.3.107.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.766.0 (2020-06-22 18:15 UTC)
* EC2 (3.3.184.0)
	* This release adds Tag On Create feature support for the ImportImage, ImportSnapshot, ExportImage and CreateInstanceExportTask APIs.
* ElasticMapReduce (3.3.107.0)
	* Adding support for MaximumCoreCapacityUnits parameter for EMR Managed Scaling. It allows users to control how many units/nodes are added to the CORE group/fleet. Remaining units/nodes are added to the TASK groups/fleet in the cluster.
* RDS (3.3.123.0)
	* Added paginators for various APIs.
* Rekognition (3.3.106.0)
	* This update adds the ability to detect black frames, end credits, shots, and color bars in stored videos
* SQS (3.3.103.0)
	* AWS SQS adds pagination support for ListQueues and ListDeadLetterSourceQueues APIs

### 3.3.765.0 (2020-06-19 18:20 UTC)
* EC2 (3.3.183.0)
	* Adds support to tag elastic-gpu on the RunInstances api
* ElastiCache (3.3.111.8)
	* Documentation updates for elasticache
* MediaLive (3.3.112.0)
	* AWS Elemental MediaLive now supports Input Prepare schedule actions. This feature improves existing input switching by allowing users to prepare an input prior to switching to it.
* OpsWorksCM (3.3.106.0)
	* Documentation updates for AWS OpsWorks CM.
* Core 3.3.107.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.764.0 (2020-06-18 18:16 UTC)
* AWSMarketplaceMetering (3.3.101.96)
	* Documentation updates for meteringmarketplace
* AWSSupport (3.3.100.196)
	* Documentation updates for support
* MediaConvert (3.3.118.7)
	* AWS Elemental MediaConvert SDK has added support for NexGuard FileMarker SDK, which allows NexGuard partners to watermark proprietary content in mezzanine and OTT streaming contexts.
* RDS (3.3.122.0)
	* Adding support for global write forwarding on secondary clusters in an Aurora global database.
* Route53 (3.3.106.0)
	* Added a new ListHostedZonesByVPC API for customers to list all the private hosted zones that a specified VPC is associated with.
* SimpleEmailV2 (3.3.103.0)
	* You can now configure Amazon SES to send event notifications when the delivery of an email is delayed because of a temporary issue. For example, you can receive a notification if the recipient's inbox is full, or if there's a temporary problem with the receiving email server.
* SimpleSystemsManagement (3.3.126.0)
	* Added offset support for specifying the number of days to wait after the date and time specified by a CRON expression before running the maintenance window.
* Core 3.3.107.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.763.0 (2020-06-17 18:19 UTC)
* AppMesh (3.3.110.0)
	* Adds support for route and virtual node listener timeouts.
* EC2 (3.3.182.0)
	* nvmeSupport added to DescribeInstanceTypes API
* Macie2 (3.3.101.2)
	* This is a documentation-only update to the Amazon Macie API. This update contains miscellaneous editorial improvements to various API descriptions.
* Route53 (3.3.105.0)
	* Add PriorRequestNotComplete exception to AssociateVPCWithHostedZone API
* Snowball (3.3.104.0)
	* AWS Snowcone is a portable, rugged and secure device for edge computing and data transfer. You can use Snowcone to collect, process, and move data to AWS, either offline by shipping the device to AWS or online by using AWS DataSync. With 2 CPUs and 4 GB RAM of compute and 8 TB of storage, Snowcone can run edge computing workloads and store data securely. Snowcone's small size (8.94" x 5.85" x 3.25" / 227 mm x 148.6 mm x 82.65 mm) allows you to set it next to machinery in a factory. Snowcone weighs about 4.5 lbs. (2 kg), so you can carry one in a backpack, use it with battery-based operation, and use the Wi-Fi interface to gather sensor data. Snowcone supports a file interface with NFS support. 
* Core 3.3.107.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.762.0 (2020-06-16 18:14 UTC)
* AutoScaling (3.3.103.0)
	* Introducing instance refresh, a feature that helps you update all instances in an Auto Scaling group in a rolling fashion (for example, to apply a new AMI or instance type). You can control the pace of the refresh by defining the percentage of the group that must remain running/healthy during the replacement process and the time for new instances to warm up between replacements.
* CloudFront (3.3.102.3)
	* Documentation updates for CloudFront
* DataExchange (3.3.102.0)
	* This release fixes a bug in the AWS Data Exchange Python and NodeJS SDKs. The 'KmsKeyArn' field in the create-job API was configured to be required instead of optional. We updated this field to be optional in this release.
* Lambda (3.3.110.0)
	* Adds support for using Amazon Elastic File System (persistent storage) with AWS Lambda. This enables customers to share data across function invocations, read large reference data files, and write function output to a persistent and shared store.
* Polly (3.3.104.0)
	* Amazon Polly adds new US English child voice - Kevin. Kevin is available as Neural voice only.
* QLDB (3.3.101.14)
	* Documentation updates for Amazon QLDB

### 3.3.761.0 (2020-06-16 01:15 UTC)
* AlexaForBusiness (3.3.109.0)
	* Adding support for optional tags in CreateBusinessReportSchedule, CreateProfile and CreateSkillGroup APIs
* AppConfig (3.3.104.0)
	* This release adds a hosted configuration source provider. Customers can now store their application configurations directly in AppConfig, without the need for an external configuration source.
* Chime (3.3.113.0)
	* feature: Chime: This release introduces the ability to create an AWS Chime SDK meeting with attendees.
* CognitoIdentityProvider (3.3.110.0)
	* Updated all AuthParameters to be sensitive.
* IoT (3.3.111.0)
	* Added support for job executions rollout configuration, job abort configuration, and job executions timeout configuration for AWS IoT Over-the-Air (OTA) Update Feature.

### 3.3.760.0 (2020-06-12 18:15 UTC)
* APIGateway (3.3.104.3)
	* Documentation updates for Amazon API Gateway
* CloudFormation (3.3.105.15)
	* The following parameters now return the organization root ID or organizational unit (OU) IDs that you specified for DeploymentTargets: the OrganizationalUnitIds parameter on StackSet and the OrganizationalUnitId parameter on StackInstance, StackInstanceSummary, and StackSetOperationResultSummary
* Glue (3.3.120.0)
	* You can now choose to crawl the entire table or just a sample of records in DynamoDB when using AWS Glue crawlers. Additionally, you can also specify a scanning rate for crawling DynamoDB tables.
* StorageGateway (3.3.115.0)
	* Display EndpointType in DescribeGatewayInformation

### 3.3.759.0 (2020-06-11 18:13 UTC)
* ECS (3.3.118.0)
	* This release adds support for deleting capacity providers.
* Imagebuilder (3.3.105.0)
	* EC2 Image Builder now supports specifying a custom working directory for your build and test workflows. In addition, Image Builder now supports defining tags that are applied to ephemeral resources created by EC2 Image Builder as part of the image creation workflow. 
* IotData (3.3.101.0)
	* As part of this release, we are introducing a new feature called named shadow, which extends the capability of AWS IoT Device Shadow to support multiple shadows for a single IoT device. With this release, customers can store different device state data into different shadows, and as a result access only the required state data when needed and reduce individual shadow size.
* LexModelBuildingService (3.3.105.0)
	* This change adds the built-in AMAZON.KendraSearchIntent that enables integration with Amazon Kendra.
* Core 3.3.107.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.758.0 (2020-06-10 18:14 UTC)
* AppConfig (3.3.103.0)
	* This release allows customers to choose from a list of predefined deployment strategies while starting deployments.
* CodeArtifact (3.3.100.0)
	* Added support for AWS CodeArtifact.
* ComputeOptimizer (3.3.101.0)
	* Compute Optimizer supports exporting recommendations to Amazon S3.
* DLM (3.3.108.0)
	* Reducing the schedule name of DLM Lifecycle policy from 500 to 120 characters. 
* EC2 (3.3.181.0)
	* New C6g instances powered by AWS Graviton2 processors and ideal for running advanced, compute-intensive workloads; New R6g instances powered by AWS Graviton2 processors and ideal for running memory-intensive workloads.
* Lightsail (3.3.105.3)
	* Documentation updates for lightsail
* Macie2 (3.3.101.0)
	* This release of the Amazon Macie API removes support for the ArchiveFindings and UnarchiveFindings operations. This release also adds UNKNOWN as an encryption type for S3 bucket metadata.
* ServiceCatalog (3.3.112.2)
	* Service Catalog Documentation Update for Integration with AWS Organizations Delegated Administrator feature
* Shield (3.3.104.0)
	* Corrections to the supported format for contact phone numbers and to the description for the create subscription action.

### 3.3.757.0 (2020-06-09 18:11 UTC)
* Transfer (3.3.107.0)
	* This release updates the API so customers can test use of Source IP to allow, deny or limit access to data in their S3 buckets after integrating their identity provider.
* Core 3.3.107.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.756.0 (2020-06-08 18:10 UTC)
* ServiceDiscovery (3.3.101.0)
	* Added support for tagging Service and Namespace type resources  in Cloud Map
* Shield (3.3.103.0)
	* This release adds the option for customers to identify a contact name and method that the DDoS Response Team can proactively engage when a Route 53 Health Check that is associated with a Shield protected resource fails.

### 3.3.755.0 (2020-06-05 18:14 UTC)
* APIGateway (3.3.104.0)
	* Amazon API Gateway now allows customers of REST APIs to skip trust chain validation for backend server certificates for HTTP and VPC Link Integration. This feature enables customers to configure their REST APIs to integrate with backends that are secured with certificates vended from private certificate authorities (CA) or certificates that are self-signed.
* CloudFront (3.3.102.0)
	* Amazon CloudFront adds support for configurable origin connection attempts and origin connection timeout.
* ElasticBeanstalk (3.3.102.0)
	* These API changes enable an IAM user to associate an operations role with an Elastic Beanstalk environment, so that the IAM user can call Elastic Beanstalk actions without having access to underlying downstream AWS services that these actions call.
* Personalize (3.3.105.0)
	* [Personalize] Adds ability to create and apply filters.
* PersonalizeRuntime (3.3.104.0)
	* [Personalize] Adds ability to apply filter to real-time recommendations
* Pinpoint (3.3.110.0)
	* This release enables additional functionality for the Amazon Pinpoint journeys feature. With this release, you can send messages through additional channels, including SMS, push notifications, and custom channels.
* SageMakerRuntime (3.3.102.0)
	* You can now specify the production variant to send the inference request to, when invoking a SageMaker Endpoint that is running two or more variants.
* ServiceCatalog (3.3.112.0)
	* This release adds support for DescribeProduct and DescribeProductAsAdmin by product name, DescribeProvisioningArtifact by product name or provisioning artifact name, returning launch paths as part of DescribeProduct output and adds maximum length for provisioning artifact name and provisioning artifact description.
* Core 3.3.107.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.754.0 (2020-06-04 18:21 UTC)
* AWSMarketplaceMetering (3.3.101.91)
	* Documentation updates for meteringmarketplace
* EC2 (3.3.180.0)
	* New C5a instances, the latest generation of EC2's compute-optimized instances featuring AMD's 2nd Generation EPYC processors. C5a instances offer up to 96 vCPUs, 192 GiB of instance memory, 20 Gbps in Network bandwidth; New G4dn.metal bare metal instance with 8 NVIDIA T4 GPUs.
* Lightsail (3.3.105.0)
	* This release adds the BurstCapacityPercentage and BurstCapacityTime instance metrics, which allow you to track the burst capacity available to your instance.
* MediaPackageVod (3.3.106.0)
	* You can now restrict direct access to AWS Elemental MediaPackage by securing requests for VOD content using CDN authorization. With CDN authorization, content requests require a specific HTTP header and authorization code.
* SimpleSystemsManagement (3.3.125.0)
	* SSM State Manager support for executing an association only at specified CRON schedule after creating/updating an association.
* Core 3.3.107.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.753.1 (2020-06-03 21:18 UTC)
* S3 (3.3.111.7)
	* Updated to use new Core, version 3.3.107.6
	* Refactor Asynchronous code and properly handle cancellation tokens
* Core 3.3.107.6
	* Refactor Asynchronous code and properly handle cancellation tokens; Make ReadWriteTimeout obsolete for NetStandard
	* All services packages updated to require new Core

### 3.3.753.0 (2020-06-03 18:13 UTC)
* DirectConnect (3.3.105.0)
	* This release supports the virtual interface failover test, which allows you to verify that traffic routes over redundant virtual interfaces when you bring your primary virtual interface out of service.
* ElastiCache (3.3.111.0)
	* This release improves the Multi-AZ feature in ElastiCache by adding a separate flag and proper validations.
* Elasticsearch (3.3.107.0)
	* Amazon Elasticsearch Service now offers support for cross-cluster search, enabling you to perform searches, aggregations, and visualizations across multiple Amazon Elasticsearch Service domains with a single query or from a single Kibana interface. New feature includes the ability to setup connection, required to perform cross-cluster search, between domains using an approval workflow.
* Glue (3.3.119.0)
	* Adding databaseName in the response for GetUserDefinedFunctions() API.
* IdentityManagement (3.3.106.0)
	* GenerateServiceLastAccessedDetails will now return ActionLastAccessed details for certain S3 control plane actions
* MediaConvert (3.3.118.0)
	* AWS Elemental MediaConvert SDK has added support for the encoding of VP8 or VP9 video in WebM container with Vorbis or Opus audio.
* Core 3.3.107.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.752.0 (2020-06-02 18:12 UTC)
* GuardDuty (3.3.108.0)
	* Amazon GuardDuty findings now include S3 bucket details under the resource section if an S3 Bucket was one of the affected resources

### 3.3.751.0 (2020-06-01 18:14 UTC)
* Athena (3.3.104.0)
	* This release adds support for connecting Athena to your own Apache Hive Metastores in addition to the AWS Glue Data Catalog. For more information, please see https://docs.aws.amazon.com/athena/latest/ug/connect-to-data-source-hive.html
* ElasticMapReduce (3.3.106.0)
	* Amazon EMR now supports encrypting log files with AWS Key Management Service (KMS) customer managed keys.
* FSx (3.3.106.0)
	* New capabilities to update storage capacity and throughput capacity of your file systems, providing the flexibility to grow file storage and to scale up or down the available performance as needed to meet evolving storage needs over time.
* KeyManagementService (3.3.106.0)
	* AWS Key Management Service (AWS KMS): If the GenerateDataKeyPair or GenerateDataKeyPairWithoutPlaintext APIs are called on a CMK in a custom key store (origin == AWS_CLOUDHSM), they return an UnsupportedOperationException. If a call to UpdateAlias causes a customer to exceed the Alias resource quota, the UpdateAlias API returns a LimitExceededException.
* SageMaker (3.3.116.0)
	* We are releasing HumanTaskUiArn as a new parameter in CreateLabelingJob and RenderUiTemplate which can take an ARN for a system managed UI to render a task. 
* WorkLink (3.3.103.0)
	* Amazon WorkLink now supports resource tagging for fleets.
* Core 3.3.107.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.750.0 (2020-05-28 18:12 UTC)
* Kafka (3.3.108.0)
	* New APIs for upgrading the Apache Kafka version of a cluster and to find out compatible upgrade paths
* MarketplaceCatalog (3.3.101.0)
	* AWS Marketplace Catalog now supports accessing initial change payloads with DescribeChangeSet operation.
* QLDBSession (3.3.100.115)
	* Documentation updates for Amazon QLDB Session
* WorkMail (3.3.105.0)
	* This release adds support for Amazon WorkMail organization-level retention policies.

### 3.3.749.0 (2020-05-27 18:13 UTC)
* ElasticLoadBalancingV2 (3.3.105.0)
	* This release added support for HTTP/2 ALPN preference lists for Network Load Balancers
* GuardDuty (3.3.107.23)
	* Documentation updates for GuardDuty
* Core 3.3.107.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.748.0 (2020-05-26 18:11 UTC)
* DLM (3.3.107.0)
	* Allowing cron expression in the DLM policy creation schedule. 
* EC2 (3.3.179.0)
	* ebsOptimizedInfo, efaSupported and supportedVirtualizationTypes added to DescribeInstanceTypes API
* ElastiCache (3.3.110.0)
	* Amazon ElastiCache now allows you to use resource based policies to manage access to operations performed on ElastiCache resources. Also, Amazon ElastiCache now exposes ARN (Amazon Resource Names) for ElastiCache resources such as Cache Clusters and Parameter Groups. ARNs can be used to apply IAM policies to ElastiCache resources.
* Macie (3.3.100.185)
	* This is a documentation-only update to the Amazon Macie Classic API. This update corrects out-of-date references to the service name.
* QuickSight (3.3.104.0)
	* Add DataSetArns to QuickSight DescribeDashboard API response.
* SimpleSystemsManagement (3.3.124.0)
	* The AWS Systems Manager GetOpsSummary API action now supports multiple OpsResultAttributes in the request. Currently, this feature only supports OpsResultAttributes with the following TypeNames: [AWS:EC2InstanceComputeOptimizer] or [AWS:EC2InstanceInformation, AWS:EC2InstanceComputeOptimizer]. These TypeNames can be used along with either or both of the following: [AWS:EC2InstanceRecommendation, AWS:RecommendationSource]
* Core 3.3.107.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.747.0 (2020-05-22 18:09 UTC)
* AutoScaling (3.3.102.51)
	* Documentation updates for Amazon EC2 Auto Scaling
* IoTSiteWise (3.3.101.0)
	* This release adds support for the standard deviation auto-computed aggregate and improved support for portal logo images in SiteWise.
* Core 3.3.107.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.746.0 (2020-05-22 00:04 UTC)
* S3 (3.3.111.1)
	* Encode only unicode characters in S3 metadata.
* Core 3.3.107.0
	* Add support for unmarshall and model errors returned by service APIs; Remove exclusion list used for generating API doc URL.
	* All services packages updated to require new Core

### 3.3.745.0 (2020-05-21 18:14 UTC)
* CodeBuild (3.3.111.0)
	* CodeBuild adds support for tagging with report groups
* EC2 (3.3.178.0)
	* From this release onwards ProvisionByoipCidr publicly supports IPv6. Updated ProvisionByoipCidr API to support tags for public IPv4 and IPv6 pools. Added NetworkBorderGroup to the DescribePublicIpv4Pools response.
* S3 (3.3.111.0)
	* Deprecates unusable input members bound to Content-MD5 header. Updates example and documentation.
* Synthetics (3.3.101.0)
	* AWS CloudWatch Synthetics now supports configuration of allocated memory for a canary.
* Core 3.3.106.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.744.0 (2020-05-20 18:34 UTC)
* ApplicationAutoScaling (3.3.105.17)
	* Documentation updates for Application Auto Scaling
* AppMesh (3.3.109.0)
	* List APIs for all resources now contain additional information: when a resource was created, last updated, and its current version number.
* Backup (3.3.102.0)
	* This release allows customers to enable or disable AWS Backup support for an AWS resource type. This release also includes new APIs, update-region-settings and describe-region-settings, which can be used to opt in to a specific resource type. For all current AWS Backup customers, the default settings enable support for EBS, EC2, StorageGateway, EFS, DDB and RDS resource types. 
* Chime (3.3.112.0)
	* Amazon Chime enterprise account administrators can now set custom retention policies on chat data in the Amazon Chime application.
* CodeDeploy (3.3.102.0)
	* Amazon ECS customers using application and network load balancers can use CodeDeploy BlueGreen hook to invoke a CloudFormation stack update. With this update you can view CloudFormation deployment and target details via existing APIs and use your stack Id to list or delete all deployments associated with the stack.
* MediaLive (3.3.111.0)
	* AWS Elemental MediaLive now supports the ability to ingest the content that is streaming from an AWS Elemental Link device: https://aws.amazon.com/medialive/features/link/. This release also adds support for SMPTE-2038 and input state waiters.
* SecurityHub (3.3.113.0)
	* For findings related to controls, the finding information now includes the reason behind the current status of the control. A new field for the findings original severity allows finding providers to use the severity values from the system they use to assign severity.

### 3.3.743.0 (2020-05-19 18:15 UTC)
* AWSHealth (3.3.103.0)
	* Feature: Health: AWS Health added a new field to differentiate Public events from Account-Specific events in the API request and response. Visit https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html to learn more.
* Chime (3.3.111.0)
	* You can now receive Voice Connector call events through SNS or SQS.
* EC2 (3.3.177.0)
	* This release adds support for Federated Authentication via SAML-2.0 in AWS ClientVPN.
* TranscribeService (3.3.116.12)
	* Documentation updates for Amazon Transcribe.
* Core 3.3.106.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.742.0 (2020-05-18 18:15 UTC)
* Chime (3.3.110.0)
	* Amazon Chime now supports redacting chat messages.
* DynamoDBv2 (3.3.106.5)
	* Documentation updates for dynamodb 
* EC2 (3.3.176.0)
	* This release changes the RunInstances CLI and SDK's so that if you do not specify a client token, a randomly generated token is used for the request to ensure idempotency.
* ECS (3.3.117.0)
	* This release adds support for specifying environment files to add environment variables to your containers.
* Macie2 (3.3.100.3)
	* Documentation updates for Amazon Macie
* QLDB (3.3.101.0)
	* Amazon QLDB now supports Amazon Kinesis data streams. You can now emit QLDB journal data, via the new QLDB Streams feature, directly to Amazon Kinesis supporting event processing and analytics among related use cases.
* Core 3.3.106.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.741.0 (2020-05-15 18:20 UTC)
* CloudFormation (3.3.105.0)
	* This release adds support for the following features: 1. DescribeType and ListTypeVersions APIs now output a field IsDefaultVersion, indicating if a version is the default version for its type; 2. Add StackRollbackComplete waiter feature to wait until stack status is UPDATE_ROLLBACK_COMPLETE; 3. Add paginators in DescribeAccountLimits, ListChangeSets, ListStackInstances, ListStackSetOperationResults, ListStackSetOperations, ListStackSets APIs.
* ECR (3.3.105.0)
	* This release adds support for specifying an image manifest media type when pushing a manifest to Amazon ECR.
* Glue (3.3.118.0)
	* Starting today, you can stop the execution of Glue workflows that are running. AWS Glue workflows are directed acyclic graphs (DAGs) of Glue triggers, crawlers and jobs. Using a workflow, you can design a complex multi-job extract, transform, and load (ETL) activity that AWS Glue can execute and track as single entity. 
* SecurityToken (3.3.105.0)
	* API updates for STS
* Core 3.3.106.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.740.0 (2020-05-14 18:16 UTC)
* EC2 (3.3.175.0)
	* Amazon EC2 now supports adding AWS resource tags for associations between VPCs and local gateways, at creation time.
* Imagebuilder (3.3.104.0)
	* This release adds a new parameter (SupportedOsVersions) to the Components API. This parameter lists the OS versions supported by a component.
* Core 3.3.106.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.739.0 (2020-05-13 18:11 UTC)
* ElastiCache (3.3.109.0)
	* Amazon ElastiCache now supports auto-update of ElastiCache clusters after the "recommended apply by date" of  service update has passed. ElastiCache will use your maintenance window to schedule the auto-update of applicable clusters. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/mem-ug/Self-Service-Updates.html and https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Self-Service-Updates.html
* Macie2 (3.3.100.0)
	* This release introduces a new major version of the Amazon Macie API. You can use this version of the API to develop tools and applications that interact with the new Amazon Macie.

### 3.3.738.0 (2020-05-12 18:12 UTC)
* IoTSiteWise (3.3.100.9)
	* Documentation updates for iot-bifrost
* WorkMail (3.3.104.0)
	* Minor API fixes and updates to the documentation.

### 3.3.737.0 (2020-05-11 18:10 UTC)
* CodeGuruReviewer (3.3.103.0)
	* Add Bitbucket integration APIs
* EC2 (3.3.174.0)
	* M6g instances are our next-generation general purpose instances powered by AWS Graviton2 processors
* Kendra (3.3.103.0)
	* Amazon Kendra is now generally available. As part of general availability, we are launching * Developer edition * Ability to scale your Amazon Kendra index with capacity units * Support for new connectors * Support for new tagging API's * Support for Deleting data source * Metrics for data source sync operations * Metrics for query & storage utilization
* Core 3.3.106.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.736.0 (2020-05-08 18:20 UTC)
* GuardDuty (3.3.107.13)
	* Documentation updates for GuardDuty
* ResourceGroupsTaggingAPI (3.3.103.72)
	* Documentation updates for resourcegroupstaggingapi
* SageMaker (3.3.115.0)
	* This release adds a new parameter (EnableInterContainerTrafficEncryption) to CreateProcessingJob API to allow for enabling inter-container traffic encryption on processing jobs.
* Core 3.3.106.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.735.0 (2020-05-07 23:44 UTC)
* DynamoDBv2 (3.3.106.0)
	* Add extension method for IEnumerable<Document>. Adds support for Array property in Dynamodb DataModel API
* S3 (3.3.110.66)
	* Fixed issue encoding of Unicode characters in S3 object metadata.
* Core 3.3.106.20
	* Fixed issue with PersistenceManager blocking credential look up when application running under a service role. Updated IpRanges to have network border group.
	* All services packages updated to require new Core

### 3.3.734.0 (2020-05-07 18:18 UTC)
* AppConfig (3.3.102.21)
	* The description of the AWS AppConfig GetConfiguration API action was amended to include important information about calling ClientConfigurationVersion when you configure clients to call GetConfiguration.
* CloudWatchLogs (3.3.102.0)
	* Amazon CloudWatch Logs now offers the ability to interact with Logs Insights queries via the new PutQueryDefinition, DescribeQueryDefinitions, and DeleteQueryDefinition APIs.
* CodeBuild (3.3.110.0)
	* Add COMMIT_MESSAGE enum for webhook filter types
* EC2 (3.3.173.0)
	* Amazon EC2 now adds warnings to identify issues when creating a launch template or launch template version.
* Lightsail (3.3.104.0)
	* This release adds support for the following options in instance public ports: Specify source IP addresses, specify ICMP protocol like PING, and enable/disable the Lightsail browser-based SSH and RDP clients' access to your instance.
* Route53 (3.3.104.0)
	* Amazon Route 53 now supports the EU (Milan) Region (eu-south-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SimpleSystemsManagement (3.3.123.0)
	* This Patch Manager release supports creating patch baselines for Oracle Linux and Debian
* Core 3.3.106.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.733.0 (2020-05-06 18:18 UTC)
* CodeStarconnections (3.3.101.0)
	* Added support for tagging resources in AWS CodeStar Connections
* ComprehendMedical (3.3.104.0)
	* New Batch Ontology APIs for ICD-10 and RxNorm will provide batch capability of linking the information extracted by Comprehend Medical to medical ontologies. The new ontology linking APIs make it easy to detect medications and medical conditions in unstructured clinical text and link them to RxNorm and ICD-10-CM codes respectively. This new feature can help you reduce the cost, time and effort of processing large amounts of unstructured medical text with high accuracy.
* Core 3.3.106.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.732.0 (2020-05-05 18:14 UTC)
* AWSSupport (3.3.100.173)
	* Documentation updates for support
* EC2 (3.3.172.0)
	* With this release, you can call ModifySubnetAttribute with two new parameters: MapCustomerOwnedIpOnLaunch and CustomerOwnedIpv4Pool, to map a customerOwnedIpv4Pool to a subnet. You will also see these two new fields in the DescribeSubnets response. If your subnet has a customerOwnedIpv4Pool mapped, your network interface will get an auto assigned customerOwnedIpv4 address when placed onto an instance.
* SimpleSystemsManagement (3.3.122.0)
	* AWS Systems Manager Parameter Store launches new data type to support aliases in EC2 APIs

### 3.3.731.0 (2020-05-04 18:12 UTC)
* APIGateway (3.3.103.97)
	* Documentation updates for Amazon API Gateway
* EC2 (3.3.171.0)
	* With this release, you can include enriched metadata in Amazon Virtual Private Cloud (Amazon VPC) flow logs published to Amazon CloudWatch Logs or Amazon Simple Storage Service (S3). Prior to this, custom format VPC flow logs enriched with additional metadata could be published only to S3. With this launch, we are also adding additional metadata fields that provide insights about the location such as AWS Region, AWS Availability Zone, AWS Local Zone, AWS Wavelength Zone, or AWS Outpost where the network interface where flow logs are captured exists. 
* S3Control (3.3.104.0)
	* Amazon S3 Batch Operations now supports Object Lock.
* Core 3.3.106.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.730.0 (2020-05-01 18:11 UTC)
* ElasticFileSystem (3.3.105.0)
	* Change the TagKeys argument for UntagResource to a URL parameter to address an issue with the Java and .NET SDKs.
* SimpleSystemsManagement (3.3.121.0)
	* Added TimeoutSeconds as part of ListCommands API response.
* Core 3.3.106.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.729.0 (2020-04-30 18:16 UTC)
* IoT (3.3.110.0)
	* AWS IoT Core released Fleet Provisioning for scalable onboarding of IoT devices to the cloud. This release includes support for customer's Lambda functions to validate devices during onboarding. Fleet Provisioning also allows devices to send Certificate Signing Requests (CSR) to AWS IoT Core for signing and getting a unique certificate. Lastly,  AWS IoT Core added a feature to register the same certificate for multiple accounts in the same region without needing to register the certificate authority (CA).
* IoTEvents (3.3.106.0)
	* Doc only update to correct APIs and related descriptions
* Lambda (3.3.109.17)
	* Documentation updates for Lambda
* MediaConvert (3.3.117.0)
	* AWS Elemental MediaConvert SDK has added support for including AFD signaling in MXF wrapper.
* Schemas (3.3.101.0)
	* Add support for resource policies for Amazon EventBridge Schema Registry, which is now generally available.
* StorageGateway (3.3.114.0)
	* Adding support for S3_INTELLIGENT_TIERING as a storage class option
* Core 3.3.106.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.728.0 (2020-04-29 19:13 UTC)
* IoTSiteWise (3.3.100.0)
	* AWS IoT SiteWise is a managed service that makes it easy to collect, store, organize and monitor data from industrial equipment at scale. You can use AWS IoT SiteWise to model your physical assets, processes and facilities, quickly compute common industrial performance metrics, and create fully managed web applications to help analyze industrial equipment data, prevent costly equipment issues, and reduce production inefficiencies.
* ServiceDiscovery (3.3.100.169)
	* Documentation updates for servicediscovery
* TranscribeService (3.3.116.0)
	* With this release, you can now use Amazon Transcribe to create medical custom vocabularies and use them in both medical real-time streaming and medical batch transcription jobs.
* WAF (3.3.103.0)
	* This release add migration API for AWS WAF Classic ("waf" and "waf-regional"). The migration API will parse through your web ACL and generate a CloudFormation template into your S3 bucket. Deploying this template will create equivalent web ACL under new AWS WAF ("wafv2").
* WAFRegional (3.3.103.0)
	* This release add migration API for AWS WAF Classic ("waf" and "waf-regional"). The migration API will parse through your web ACL and generate a CloudFormation template into your S3 bucket. Deploying this template will create equivalent web ACL under new AWS WAF ("wafv2").
* Core 3.3.106.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.727.0 (2020-04-28 18:16 UTC)
* ECR (3.3.104.0)
	* This release adds support for multi-architecture images also known as a manifest list
* KinesisVideo (3.3.103.0)
	* Add "GET_CLIP" to the list of supported API names for the GetDataEndpoint API.
* KinesisVideoArchivedMedia (3.3.103.0)
	* Add support for the GetClip API for retrieving media from a video stream in the MP4 format.
* MediaLive (3.3.110.0)
	* AWS Elemental MediaLive now supports several new features: enhanced VQ for H.264 (AVC) output encodes; passthrough of timed metadata and of Nielsen ID3 metadata in fMP4 containers in HLS outputs; the ability to generate a SCTE-35 sparse track without additional segmentation, in Microsoft Smooth outputs;  the ability to select the audio from a TS input by specifying the audio track; and conversion of HDR colorspace in the input to an SDR colorspace in the output.
* Route53 (3.3.103.0)
	* Amazon Route 53 now supports the Africa (Cape Town) Region (af-south-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SimpleSystemsManagement (3.3.120.0)
	* SSM State Manager support for adding list association filter for Resource Group and manual mode of managing compliance for an association. 
* Core 3.3.106.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.726.0 (2020-04-27 18:11 UTC)
* AccessAnalyzer (3.3.104.0)
	* This release adds support for inclusion of S3 Access Point policies in IAM Access Analyzer evaluation of S3 bucket access. IAM Access Analyzer now reports findings for buckets shared through access points and identifies the access point that permits access.
* DatabaseMigrationService (3.3.105.0)
	* Adding minimum replication engine version for describe-endpoint-types api.
* DataExchange (3.3.101.0)
	* This release introduces AWS Data Exchange support for configurable encryption parameters when exporting data sets to Amazon S3. 
* SageMaker (3.3.114.0)
	* Change to the input, ResourceSpec, changing EnvironmentArn to SageMakerImageArn. This affects the following preview APIs: CreateDomain, DescribeDomain, UpdateDomain, CreateUserProfile, DescribeUserProfile, UpdateUserProfile, CreateApp and DescribeApp.
* Core 3.3.106.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.725.0 (2020-04-24 18:13 UTC)
* DLM (3.3.106.37)
	* Enable 1hour frequency in the schedule creation for Data LifeCycle Manager.
* ElasticInference (3.3.102.0)
	* This feature allows customers to describe the accelerator types and offerings on any region where Elastic Inference is available.
* IoT (3.3.109.0)
	* This release adds a new exception type to the AWS IoT SetV2LoggingLevel API.
* Core 3.3.106.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.724.0 (2020-04-23 18:20 UTC)
* ApplicationAutoScaling (3.3.105.0)
	* This release supports Auto Scaling in Amazon Keyspaces for Apache Cassandra.
* KinesisFirehose (3.3.104.0)
	* You can now deliver streaming data to an Amazon Elasticsearch Service domain in an Amazon VPC. You can now compress streaming data delivered to S3 using Hadoop-Snappy in addition to Gzip, Zip and Snappy formats.
* MediaPackageVod (3.3.105.0)
	* Adds tagging support for PackagingGroups, PackagingConfigurations, and Assets
* Pinpoint (3.3.109.0)
	* This release of the Amazon Pinpoint API enhances support for sending campaigns through custom channels to locations such as AWS Lambda functions or web applications. Campaigns can now use CustomDeliveryConfiguration and CampaignCustomMessage to configure custom channel settings for a campaign.
* RAM (3.3.103.0)
	* AWS Resource Access Manager (RAM) provides a new ListResourceTypes action. This action lets you list the resource types that can be shared using AWS RAM.
* RDS (3.3.121.0)
	* Adds support for AWS Local Zones, including a new optional parameter AvailabilityZoneGroup for the DescribeOrderableDBInstanceOptions operation.
* StorageGateway (3.3.113.0)
	* Added AutomaticTapeCreation APIs
* Transfer (3.3.106.0)
	* This release adds support for transfers over FTPS and FTP in and out of Amazon S3, which makes it easy to migrate File Transfer Protocol over SSL (FTPS) and FTP workloads to AWS, in addition to the existing support for Secure File Transfer Protocol (SFTP).
* Core 3.3.106.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.723.0 (2020-04-22 18:11 UTC)
* CodeGuruReviewer (3.3.102.0)
	* Add support for code review and recommendation feedback APIs.
* Elasticsearch (3.3.106.0)
	* This change adds a new field 'OptionalDeployment' to ServiceSoftwareOptions to indicate whether a service software update is optional or mandatory. If True, it indicates that the update is optional, and the service software is not automatically updated. If False, the service software is automatically updated after AutomatedUpdateDate.
* FMS (3.3.105.0)
	* This release is to support AWS Firewall Manager policy with Organizational Unit scope. 
* Redshift (3.3.108.0)
	* Amazon Redshift support for usage limits
* Core 3.3.106.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.722.0 (2020-04-21 21:32 UTC)
* CostExplorer (3.3.109.0)
	* Cost Explorer Rightsizing Recommendations integrates with Compute Optimizer and begins offering across instance family rightsizing recommendations, adding to existing support for within instance family rightsizing recommendations. 
* ElasticMapReduce (3.3.105.0)
	* Amazon EMR adds support for configuring a managed scaling policy for an Amazon EMR cluster. This enables automatic resizing of a cluster to optimize for job execution speed and reduced cluster cost.
* GuardDuty (3.3.107.0)
	* AWS GuardDuty now supports using AWS Organizations delegated administrators to create and manage GuardDuty master and member accounts.  The feature also allows GuardDuty to be automatically enabled on associated organization accounts.
* Route53Domains (3.3.101.0)
	* You can now programmatically transfer domains between AWS accounts without having to contact AWS Support
* Core 3.3.106.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.721.0 (2020-04-20 18:49 UTC)
* ApiGatewayV2 (3.3.107.0)
	* You can now export an OpenAPI 3.0 compliant API definition file for Amazon API Gateway HTTP APIs using the Export API.
* CostExplorer (3.3.108.0)
	* Cost Categories API is now General Available with new dimensions and operations support. You can map costs by account name, service, and charge type dimensions as well as use contains, starts with, and ends with operations. Cost Categories can also be used in RI and SP coverage reports.
* Glue (3.3.117.0)
	* Added a new ConnectionType "KAFKA" and a ConnectionProperty "KAFKA_BOOTSTRAP_SERVERS" to support Kafka connection.
* IoTEvents (3.3.105.0)
	* API update that allows users to add AWS Iot SiteWise actions while creating Detector Model in AWS Iot Events
* Synthetics (3.3.100.0)
	* Introducing CloudWatch Synthetics. This is the first public release of CloudWatch Synthetics.
* Core 3.3.106.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.720.0 (2020-04-17 18:12 UTC)
* FraudDetector (3.3.101.0)
	* Added support for a new rule engine execution mode. Customers will be able to configure their detector versions to evaluate all rules and return outcomes from all 'matched' rules in the GetPrediction API response. Added support for deleting Detectors (DeleteDetector) and Rule Versions (DeleteRuleVersion).
* OpsWorksCM (3.3.105.21)
	* Documentation updates for opsworkscm
* Core 3.3.106.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.719.0 (2020-04-16 18:17 UTC)
* AugmentedAIRuntime (3.3.102.0)
	* This release updates Amazon Augmented AI ListHumanLoops and StartHumanLoop APIs.
* EC2 (3.3.170.0)
	* Amazon EC2 now supports adding AWS resource tags for placement groups and key pairs, at creation time. The CreatePlacementGroup API will now return placement group information when created successfully. The DeleteKeyPair API now supports deletion by resource ID.
* Glue (3.3.116.0)
	* This release adds support for querying GetUserDefinedFunctions API without databaseName.
* Imagebuilder (3.3.103.0)
	* This release includes support for additional OS Versions within EC2 Image Builder.
* IoTEvents (3.3.104.0)
	* API update that allows users to customize event action payloads, and adds support for Amazon DynamoDB actions.
* Lambda (3.3.109.7)
	* Sample code for AWS Lambda operations
* MediaConvert (3.3.116.0)
	* AWS Elemental MediaConvert now allows you to specify your input captions frame rate for SCC captions sources.
* MediaTailor (3.3.104.0)
	* AWS Elemental MediaTailor SDK now allows configuration of Avail Suppression.
* MigrationHub (3.3.103.0)
	* Adding ThrottlingException
* RDS (3.3.120.0)
	* This release adds support for Amazon RDS Proxy with PostgreSQL compatibility.
* SageMaker (3.3.113.0)
	* Amazon SageMaker now supports running training jobs on ml.g4dn and ml.c5n instance types. Amazon SageMaker supports in "IN" operation for Search now.
* SecurityHub (3.3.112.0)
	* Added a new BatchUpdateFindings action, which allows customers to update selected information about their findings. Security Hub customers use BatchUpdateFindings to track their investigation into a finding. BatchUpdateFindings is intended to replace the UpdateFindings action, which is deprecated.
* Snowball (3.3.103.0)
	* An update to the Snowball Edge Storage Optimized device has been launched. Like the previous version, it has 80 TB of capacity for data transfer. Now it has 40 vCPUs, 80 GiB, and a 1 TiB SATA SSD of memory for EC2 compatible compute. The 80 TB of capacity can also be used for EBS-like volumes for AMIs.
* Core 3.3.106.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.718.1 (2020-04-08 23:40 UTC)
* Core 3.3.106.4
	* Remove FxCop and migrate to Roslyn Analyzer; Updated doc generator to include .NET Standard 2.0

### 3.3.718.0 (2020-04-08 18:29 UTC)
* Chime (3.3.109.0)
	* feature: Chime: This release introduces the ability to tag Amazon Chime SDK meeting resources.  You can use tags to organize and identify your resources for cost allocation. 
* CloudFormation (3.3.104.28)
	* The OrganizationalUnitIds parameter on StackSet and the OrganizationalUnitId parameter on StackInstance, StackInstanceSummary, and StackSetOperationResultSummary are now reserved for internal use. No data is returned for this parameter.
* CodeGuruProfiler (3.3.101.0)
	* CodeGuruProfiler adds support for resource based authorization to submit profile data.
* EC2 (3.3.169.0)
	* This release provides the ability to include tags in EC2 event notifications. 
* ECS (3.3.116.0)
	* This release provides native support for specifying Amazon EFS file systems as volumes in your Amazon ECS task definitions.
* MediaConvert (3.3.115.0)
	* AWS Elemental MediaConvert SDK adds support for queue hopping. Jobs can now hop from their original queue to a specified alternate queue, based on the maximum wait time that you specify in the job settings.
* MigrationHubConfig (3.3.101.0)
	* Adding ThrottlingException
* Core 3.3.106.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.717.0 (2020-04-07 18:10 UTC)
* APIGateway (3.3.103.83)
	* Documentation updates for Amazon API Gateway.
* CodeGuruReviewer (3.3.101.0)
	* API updates for CodeGuruReviewer 
* MediaConnect (3.3.108.0)
	* You can now send content from your MediaConnect flow to your virtual private cloud (VPC) without going over the public internet.

### 3.3.716.0 (2020-04-06 18:14 UTC)
* Chime (3.3.108.0)
	* Amazon Chime proxy phone sessions let you provide two users with a shared phone number to communicate via voice or text for up to 12 hours without revealing personal phone numbers. When users call or message the provided phone number, they are connected to the other party and their private phone numbers are replaced with the shared number in Caller ID.
* ElasticBeanstalk (3.3.101.0)
	* This release adds a new action, ListPlatformBranches, and updates two actions, ListPlatformVersions and DescribePlatformVersion, to support the concept of Elastic Beanstalk platform branches.
* IdentityManagement (3.3.105.31)
	* Documentation updates for AWS Identity and Access Management (IAM).
* TranscribeService (3.3.115.0)
	* This release adds support for batch transcription jobs within Amazon Transcribe Medical.
* Core 3.3.106.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.715.0 (2020-04-03 18:09 UTC)
* PersonalizeRuntime (3.3.103.0)
	* Amazon Personalize: Add new response field "score" to each item returned by GetRecommendations and GetPersonalizedRanking (HRNN-based recipes only)
* RoboMaker (3.3.111.0)
	* Added support for limiting simulation unit usage, giving more predictable control over simulation cost
* Core 3.3.106.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.714.0 (2020-04-03 15:43 UTC)
* DynamoDBv2 (3.3.105.23)
	* Updated to use new Core, version 3.3.106.0
	* Adjustments to custom retry policies to support retry improvements.
* EC2 (3.3.168.14)
	* Updated to use new Core, version 3.3.106.0
	* Adjustments to custom retry policies to support retry improvements.
* S3 (3.3.110.47)
	* Updated to use new Core, version 3.3.106.0
	* Adjustments to custom retry policies to support retry improvements.
* SecurityToken (3.3.104.55)
	* Updated to use new Core, version 3.3.106.0
	* Adjustments to custom retry policies to support retry improvements.
* Core 3.3.106.0
	* Improvements to the retry logic now supporting Legacy, Standard, and Adaptive modes; Improves performance when profiles are not found by adding validation logic instead of throwing/catching exception.
	* All services packages updated to require new Core

### 3.3.713.0 (2020-04-02 18:14 UTC)
* CloudWatch (3.3.107.0)
	* Amazon CloudWatch Contributor Insights adds support for tags and tagging on resource creation. 
* GameLift (3.3.106.0)
	* Public preview of GameLift FleetIQ as a standalone feature. GameLift FleetIQ makes it possible to use low-cost Spot instances by limiting the chance of interruptions affecting game sessions. FleetIQ is a feature of the managed GameLift service, and can now be used with game hosting in EC2 Auto Scaling groups that you manage in your own account.
* MediaLive (3.3.109.0)
	* AWS Elemental MediaLive now supports Automatic Input Failover. This feature provides resiliency upstream of the channel, before ingest starts.
* RDS (3.3.119.10)
	* Documentation updates for RDS: creating read replicas is now supported for SQL Server DB instances
* Redshift (3.3.107.14)
	* Documentation updates for redshift
* Core 3.3.105.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.712.0 (2020-04-01 18:14 UTC)
* IoT (3.3.108.0)
	* This release introduces Dimensions for AWS IoT Device Defender. Dimensions can be used in Security Profiles to collect and monitor fine-grained metrics.
* MediaConnect (3.3.107.0)
	* You can now send content from your virtual private cloud (VPC) to your MediaConnect flow without going over the public internet.
* Core 3.3.105.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.711.0 (2020-03-31 18:16 UTC)
* AppConfig (3.3.102.0)
	* This release adds an event log to deployments. In the case of a deployment rollback, the event log details the rollback reason.
* Detective (3.3.101.4)
	* Removing the notes that Detective is in preview, in preparation for the Detective GA release.
* ElasticInference (3.3.101.0)
	* This release includes improvements for the Amazon Elastic Inference service.
* FMS (3.3.104.0)
	* This release contains FMS wafv2 support.
* Glue (3.3.115.0)
	* Add two enums for MongoDB connection: Added "CONNECTION_URL" to "ConnectionPropertyKey" and added "MONGODB" to "ConnectionType"
* Lambda (3.3.109.0)
	* AWS Lambda now supports .NET Core 3.1
* MediaStore (3.3.103.0)
	* This release adds support for CloudWatch Metrics. You can now set a policy on your container to dictate which metrics MediaStore sends to CloudWatch.
* OpsWorksCM (3.3.105.13)
	* Documentation updates for OpsWorks-CM CreateServer values.
* Organizations (3.3.105.5)
	* Documentation updates for AWS Organizations
* Pinpoint (3.3.108.0)
	* This release of the Amazon Pinpoint API introduces MMS support for SMS messages.
* Rekognition (3.3.105.0)
	* This release adds DeleteProject and DeleteProjectVersion APIs to Amazon Rekognition Custom Labels.
* StorageGateway (3.3.112.0)
	* Adding audit logging support for SMB File Shares
* WAFV2 (3.3.101.0)
	* Added support for AWS Firewall Manager for WAFv2 and PermissionPolicy APIs for WAFv2.
* Core 3.3.105.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.710.0 (2020-03-30 18:17 UTC)
* AccessAnalyzer (3.3.103.0)
	* This release adds support for the creation and management of IAM Access Analyzer analyzers with type organization. An analyzer with type organization continuously monitors all supported resources within the AWS organization and reports findings when they allow access from outside the organization.
* Core 3.3.105.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.709.0 (2020-03-27 18:16 UTC)
* GlobalAccelerator (3.3.104.0)
	* This update adds an event history to the ListByoipCidr API call. This enables you to see the changes that you've made for an IP address range that you bring to AWS Global Accelerator through bring your own IP address (BYOIP).
* Kendra (3.3.102.0)
	* The Amazon Kendra Microsoft SharePoint data source now supports include and exclude regular expressions and change log features. Include and exclude regular expressions enable you to  provide a list of regular expressions to match the display URL of SharePoint documents to either include or exclude documents respectively. When you enable the changelog feature it enables Amazon Kendra to use the SharePoint change log to determine which documents to update in the index.
* ServiceCatalog (3.3.111.0)
	* Added "LocalRoleName" as an acceptable Parameter for Launch type in CreateConstraint and UpdateConstraint APIs
* Core 3.3.105.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.708.0 (2020-03-26 18:13 UTC)
* FSx (3.3.105.0)
	* This release includes two changes: a new lower-cost, storage type called HDD (Hard Disk Drive), and a new generation of the Single-AZ deployment type called Single AZ 2. The HDD storage type can be selected on Multi AZ 1 and Single AZ 2 deployment types.
* SageMaker (3.3.112.0)
	* This release updates Amazon Augmented AI CreateFlowDefinition API and DescribeFlowDefinition response.
* SecurityHub (3.3.111.0)
	* Security Hub has now made it easier to opt out of default standards when you enable Security Hub. We added a new Boolean parameter to EnableSecurityHub called EnableDefaultStandards. If that parameter is true, Security Hub's default standards are enabled. A new Boolean parameter for standards, EnabledByDefault, indicates whether a standard is a default standard. Today, the only default standard is CIS AWS Foundations Benchmark v1.2. Additional default standards will be added in the future.To learn more, visit our documentation on the EnableSecurityHub API action.
* Core 3.3.105.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.707.0 (2020-03-25 18:17 UTC)
* ApplicationInsights (3.3.104.0)
	* Amazon CloudWatch Application Insights for .NET and SQL Server now integrates with Amazon CloudWatch Events (AWS CodeDeploy, AWS Health and Amazon EC2 state changes). This feature enables customers to view events related to problems detected by CloudWatch Application Insights, and reduce mean-time-to-resolution (MTTR).
* CostExplorer (3.3.107.0)
	* Customers can now receive Savings Plans recommendations at the member (linked) account level.
* Detective (3.3.101.0)
	* The new ACCEPTED_BUT_DISABLED member account status indicates that a member account that accepted the invitation is blocked from contributing data to the behavior graph. The reason is provided in the new DISABLED_REASON property. The new StartMonitoringMember operation enables a blocked member account.
* Elasticsearch (3.3.105.0)
	* Adding support for customer packages (dictionary files) to Amazon Elasticsearch Service
* ManagedBlockchain (3.3.101.0)
	* Amazon Managed Blockchain now has support to publish Hyperledger Fabric peer node, chaincode, and certificate authority (CA) logs to Amazon CloudWatch Logs.
* XRay (3.3.102.0)
	* GetTraceSummaries - Now provides additional root cause attribute ClientImpacting which indicates whether root cause impacted trace client.
* Core 3.3.105.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.706.0 (2020-03-24 18:19 UTC)
* Athena (3.3.103.44)
	* Documentation updates for Athena, including QueryExecutionStatus QUEUED and RUNNING states. QUEUED now indicates that the query has been submitted to the service. RUNNING indicates that the query is in execution phase.
* EKS (3.3.110.0)
	* Adding new error codes: Ec2SubnetInvalidConfiguration and NodeCreationFailure for Nodegroups in EKS
* Organizations (3.3.105.0)
	* Introduces actions for giving a member account administrative Organizations permissions for an AWS service. You can run this action only for AWS services that support this feature.
* RDSDataService (3.3.103.43)
	* Documentation updates for rds-data
* Core 3.3.105.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.705.0 (2020-03-23 18:17 UTC)
* ApiGatewayV2 (3.3.106.0)
	* Documentation updates to reflect that the default timeout for integrations is now 30 seconds for HTTP APIs.
* EKS (3.3.109.0)
	* Adding new error code IamLimitExceeded for Nodegroups in EKS
* Route53 (3.3.102.94)
	* Documentation updates for Route 53.

### 3.3.704.0 (2020-03-20 18:11 UTC)
* ServiceCatalog (3.3.110.0)
	* Added "productId" and "portfolioId" to responses from CreateConstraint, UpdateConstraint, ListConstraintsForPortfolio, and DescribeConstraint APIs
* Core 3.3.105.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.703.0 (2020-03-19 22:06 UTC)
* EBS (3.3.100.40)
	* Make streaming response disposable.
* Glacier (3.3.100.146)
	* Make streaming response disposable.
* KinesisVideoArchivedMedia (3.3.102.62)
	* Make streaming response disposable.
* KinesisVideoMedia (3.3.100.147)
	* Make streaming response disposable.
* Lex (3.3.104.42)
	* Make streaming response disposable.
* MediaStoreData (3.3.101.122)
	* Make streaming response disposable.
* Polly (3.3.103.57)
	* Make streaming response disposable.
* WorkMailMessageFlow (3.3.100.73)
	* Make streaming response disposable.
* Core 3.3.105.0
	* Adding support for Blazor WebAssembly. Adding async implementations to wrapper streams. Prevent double encoding of all S3 requests using a different service URL.
	* All services packages updated to require new Core

### 3.3.702.1 (2020-03-19 18:10 UTC)
* CertificateManager (3.3.101.43)
	* AWS Certificate Manager documentation updated on API calls ImportCertificate and ListCertificate. Specific updates included input constraints, private key size for import and next token size for list.
* Outposts (3.3.101.11)
	* Documentation updates for AWS Outposts.

### 3.3.702.0 (2020-03-18 18:13 UTC)
* MediaConnect (3.3.106.0)
	* Feature adds the ability for a flow to have multiple redundant sources that provides resiliency to a source failing. The new APIs added to enable the feature are, AddFlowSources, RemoveFlowSource and UpdateFlow.
* Personalize (3.3.104.0)
	* [Personalize] Adds support for returning hyperparameter values of the best performing model in a HPO job.
* RDS (3.3.119.0)
	* Updated the MaxRecords type in DescribeExportTasks to Integer.
* Core 3.3.104.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.701.0 (2020-03-17 18:16 UTC)
* MediaConvert (3.3.114.0)
	* AWS Elemental MediaConvert SDK has added support for: AV1 encoding in File Group MP4, DASH and CMAF DASH outputs; PCM/WAV audio output in MPEG2-TS containers; and Opus audio in Webm inputs.
* Core 3.3.104.37
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.700.0 (2020-03-16 18:12 UTC)
* CognitoIdentityProvider (3.3.109.0)
	* Additional response field "CompromisedCredentialsDetected" added to AdminListUserAuthEvents.
* ECS (3.3.115.0)
	* This release adds the ability to update the task placement strategy and constraints for Amazon ECS services.
* ElastiCache (3.3.108.0)
	* Amazon ElastiCache now supports Global Datastore for Redis. Global Datastore for Redis offers fully managed, fast, reliable and secure cross-region replication. Using Global Datastore for Redis, you can create cross-region read replica clusters for ElastiCache for Redis to enable low-latency reads and disaster recovery across regions. You can create, modify and describe a Global Datastore, as well as add or remove regions from your Global Datastore and promote a region as primary in Global Datastore.
* S3Control (3.3.103.0)
	* Amazon S3 now supports Batch Operations job tagging.
* SimpleSystemsManagement (3.3.119.0)
	* Resource data sync for AWS Systems Manager Inventory now includes destination data sharing. This feature enables you to synchronize inventory data from multiple AWS accounts into a central Amazon S3 bucket. To use this feature, all AWS accounts must be listed in AWS Organizations.
* Core 3.3.104.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.699.1 (2020-03-13 18:09 UTC)
* AppConfig (3.3.101.9)
	* This release adds S3 as a configuration source provider.

### 3.3.699.0 (2020-03-12 19:47 UTC)
* ApiGatewayV2 (3.3.105.0)
	* Amazon API Gateway HTTP APIs is now generally available. HTTP APIs offer the core functionality of REST API at up to 71% lower price compared to REST API, 60% lower p99 latency, and is significantly easier to use. As part of general availability, we added new features to route requests to private backends such as private ALBs, NLBs, and IP/ports. We also brought over a set of features from REST API such as Stage Variables, and Stage/Route level throttling. Custom domain names can also now be used with both REST And HTTP APIs.
* EC2 (3.3.168.0)
	* Documentation updates for EC2
* IoT (3.3.107.0)
	* As part of this release, we are extending capability of AWS IoT Rules Engine to support IoT Cloudwatch log action. The IoT Cloudwatch log rule action lets you send messages from IoT sensors and applications to Cloudwatch logs for troubleshooting and debugging.
* LexModelBuildingService (3.3.104.0)
	* Amazon Lex now supports tagging for bots, bot aliases and bot channels. 
* SecurityHub (3.3.110.0)
	* The AWS Security Finding Format is being augmented with the following changes. 21 new resource types without corresponding details objects are added. Another new resource type, AwsS3Object, has an accompanying details object. Severity.Label is a new string field that indicates the severity of a finding. The available values are: INFORMATIONAL, LOW, MEDIUM, HIGH, CRITICAL. The new string field Workflow.Status indicates the status of the investigation into a finding. The available values are: NEW, NOTIFIED, RESOLVED, SUPPRESSED.
* Core 3.3.104.35
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.698.0 (2020-03-11 18:16 UTC)
* ElasticFileSystem (3.3.104.20)
	* Documentation updates for elasticfilesystem
* Redshift (3.3.107.0)
	* Amazon Redshift now supports operations to pause and resume a cluster on demand or on a schedule.

### 3.3.697.0 (2020-03-10 19:56 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.104.0)
	* Change the disbursement data set to look past 31 days instead until the beginning of the month.
* EC2 (3.3.167.0)
	* Documentation updates for EC2
* IoTEvents (3.3.103.0)
	* API update that adds a new parameter, durationExpression, to SetTimerAction, and deprecates seconds
* ServerlessApplicationRepository (3.3.102.0)
	* AWS Serverless Application Repository now supports sharing applications privately with AWS Organizations.

### 3.3.696.0 (2020-03-09 18:12 UTC)
* DatabaseMigrationService (3.3.104.0)
	* Added new settings for Kinesis target to include detailed transaction info; to capture table DDL details; to use single-line unformatted json, which can be directly queried by AWS Athena if data is streamed into S3 through AWS Kinesis Firehose. Added CdcInsertsAndUpdates in S3 target settings to allow capture ongoing insertions and updates only.
* EC2 (3.3.166.0)
	* Amazon Virtual Private Cloud (VPC) NAT Gateway adds support for tagging on resource creation.
* MediaLive (3.3.108.0)
	* AWS Elemental MediaLive now supports the ability to configure the Preferred Channel Pipeline for channels contributing to a Multiplex.

### 3.3.695.0 (2020-03-06 19:18 UTC)
* AppMesh (3.3.108.0)
	* App Mesh now supports sharing a Mesh with other AWS accounts. Customers can use AWS Resource Access Manager to share their Mesh with other accounts in their organization to connection applications within a single service mesh. See https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html for details.
* EC2 (3.3.165.0)
	* This release provides customers with a self-service option to enable Local Zones.
* GuardDuty (3.3.106.0)
	* Amazon GuardDuty findings now include the OutpostArn if the finding is generated for an AWS Outposts EC2 host.
* RoboMaker (3.3.110.0)
	* Added support for streaming a GUI from robot and simulation applications
* Signer (3.3.102.0)
	* This release enables signing image format override in PutSigningProfile requests, adding two more enum fields, JSONEmbedded and JSONDetached. This release also extends the length limit of SigningProfile name from 20 to 64.
* Core 3.3.104.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.694.0 (2020-03-05 19:21 UTC)
* EC2 (3.3.164.0)
	* You can now create AWS Client VPN Endpoints with a specified VPC and Security Group. Additionally, you can modify these attributes when modifying the endpoint. 
* EKS (3.3.108.0)
	* Amazon EKS now supports adding a KMS key to your cluster for envelope encryption of Kubernetes secrets.
* GuardDuty (3.3.105.0)
	* Add a new finding field for EC2 findings indicating the instance's local IP address involved in the threat.
* OpsWorksCM (3.3.105.0)
	* Updated the Tag regex pattern to align with AWS tagging APIs.
* Core 3.3.104.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.693.0 (2020-03-04 19:11 UTC)
* Pinpoint (3.3.107.0)
	* This release of the Amazon Pinpoint API introduces support for integrating recommender models with email, push notification, and SMS message templates. You can now use these types of templates to connect to recommender models and add personalized recommendations to messages that you send from campaigns and journeys.

### 3.3.692.0 (2020-03-03 19:10 UTC)
* EC2 (3.3.163.0)
	* Amazon VPC Flow Logs adds support for tags and tagging on resource creation.

### 3.3.691.0 (2020-03-02 19:19 UTC)
* CloudWatch (3.3.106.0)
	* Introducing Amazon CloudWatch Composite Alarms
* ComprehendMedical (3.3.103.0)
	* New Time Expression feature, part of DetectEntitiesV2 API will provide temporal relations to existing NERe entities such as Medication, Test, Treatment, Procedure and Medical conditions. 
* Core 3.3.104.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.690.0 (2020-02-29 00:40 UTC)
* ConfigService (3.3.108.0)
	* Correcting list of supported resource types.

### 3.3.689.0 (2020-02-28 19:18 UTC)
* AccessAnalyzer (3.3.102.0)
	* This release includes improvements and fixes bugs for the IAM Access Analyzer feature.
* AppMesh (3.3.107.0)
	* App Mesh now supports Transport Layer Security (TLS) between Virtual Nodes in a Mesh. Customers can use managed certificates from an AWS Certificate Manager Private Certificate Authority or bring their own certificates from the local file system to encrypt traffic between their workloads. See https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual-node-tls.html for details.
* AugmentedAIRuntime (3.3.101.0)
	* This release updates Amazon Augmented AI ListHumanLoops API, DescribeHumanLoop response, StartHumanLoop response and type names of SDK fields. 
* CodeGuruProfiler (3.3.100.32)
	* Documentation updates for Amazon CodeGuru Profiler
* ConfigService (3.3.107.0)
	* Accepts a structured query language (SQL) SELECT command and an aggregator name, performs the corresponding search on resources aggregated by the aggregator, and returns resource configurations matching the properties.
* ElasticLoadBalancingV2 (3.3.104.35)
	* Added a target group attribute to support sticky sessions for Network Load Balancers.
* Glue (3.3.114.0)
	* AWS Glue adds resource tagging support for Machine Learning Transforms and adds a new API, ListMLTransforms to support tag filtering.  With this feature, customers can use tags in AWS Glue to organize and control access to Machine Learning Transforms. 
* QuickSight (3.3.103.0)
	* Added SearchDashboards API that allows listing of dashboards that a specific user has access to.
* WorkDocs (3.3.100.139)
	* Documentation updates for workdocs

### 3.3.688.1 (2020-02-28 00:58 UTC)
* AWSSDK.Extensions.NETCore.Setup (3.3.101.0)
  * Make the library compatible with the 3.5.0-beta version of the AWS SDK for .NET.
  * PR [#1531](https://github.com/aws/aws-sdk-net/pull/1531): Fix typo in xml documentation: Thanks [Steve Gordon](https://github.com/stevejgordon).
* EC2 (3.3.162.2)
  * Add the exception EC2ThrottledException to list of retryable errors.
* S3 (3.3.110.29)
  * PR [#1479](https://github.com/aws/aws-sdk-net/pull/1479): Added UploadId and PartNumber to GetPreSignedUrl. Thanks [taylorjp](https://github.com/taylorjp).
  * PR [#1427](https://github.com/aws/aws-sdk-net/pull/1427): Prevent `TryParseAmazonS3Uri` from ever throwing exceptions. Thanks [OlegBoulanov](https://github.com/OlegBoulanov)
  * PR [#1480](https://github.com/aws/aws-sdk-net/pull/1480): Added .json entry in extensionToMime dictionary. Thanks [Damian Hickey](https://github.com/damianh).
  * PR [#1467](https://github.com/aws/aws-sdk-net/pull/1467): Fixed issue with `S3DirectoryInfo` not properly decoding the S3 key causing an exception when calling `MoveTo`. Thanks [Rocher Laurent](https://github.com/lrocher).
* DynamoDBv2 (3.3.105.5)
  * PR [#1108](https://github.com/aws/aws-sdk-net/pull/1108): Allow assigning null to property values on a `Document`. Thanks [Jens-Peter Olsson](https://github.com/jens-peterolsson).  
  * PR [#1457](https://github.com/aws/aws-sdk-net/pull/1457): Allow multiple batches against a single table when using `Amazon.DynamoDBv2.DocumentModel.MultiTableDocumentBatchWrite`. Thanks [Viktor Stenqvist](https://github.com/Yottster).
  * PR [#1082](https://github.com/aws/aws-sdk-net/pull/1082): Correct xml documentation for `Amazon.DynamoDBv2.DataModel.MultiTableBatchWrite`. Thanks [Ryan Williams](https://github.com/ryanwilliams83).
* Core (3.3.104.31)
  * PR [#1517](https://github.com/aws/aws-sdk-net/pull/1517): Fixed diagnostic tile for code analyzer. Thanks [Simon Potter](https://github.com/sjp).
  * PR [#1520](https://github.com/aws/aws-sdk-net/pull/1520): Performance improvement compressing whitespaces during signing of the request. Thanks [Petr Kovalev](https://github.com/Petr-Kovalev).
  * PR [#1489](https://github.com/aws/aws-sdk-net/pull/1489): Improve `Arn.TryParse()` to avoid throwing and catching unnecessary exceptions. Thanks [gbent](https://github.com/gbent).
  * PR [#1405](https://github.com/aws/aws-sdk-net/pull/1405): Fixed incorrect usage of `string.Format` when reporting errors from `AWSRegion`. Thanks [Damir Ainullin](https://github.com/DamirAinullin). 
  * PR [#1406](https://github.com/aws/aws-sdk-net/pull/1406): Simplifed logic checking to see if a `SettingsCollection` is empty. Thanks [Damir Ainullin](https://github.com/DamirAinullin).
  * All services packages updated to require new Core

### 3.3.688.0 (2020-02-27 19:14 UTC)
* GlobalAccelerator (3.3.103.0)
	* This release adds support for adding tags to accelerators and bringing your own IP address to AWS Global Accelerator (BYOIP).
* Lightsail (3.3.103.0)
	* Adds support to create notification contacts in Amazon Lightsail, and to create instance, database, and load balancer metric alarms that notify you based on the value of a metric relative to a threshold that you specify.
* Core 3.3.104.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.687.0 (2020-02-26 19:13 UTC)
* EC2 (3.3.162.0)
	* This release changes the RunInstances CLI and SDK's so that if you do not specify a client token, a randomly generated token is used for the request to ensure idempotency.
* SageMaker (3.3.111.0)
	* SageMaker UpdateEndpoint API now supports retained variant properties, e.g., instance count, variant weight. SageMaker ListTrials API filter by TrialComponentName. Make ExperimentConfig name length limits consistent with CreateExperiment, CreateTrial, and CreateTrialComponent APIs.
* SecurityHub (3.3.109.0)
	* Security Hub has added to the DescribeProducts API operation a new response field called IntegrationTypes. The IntegrationTypes field lists the types of actions that a product performs relative to Security Hub such as send findings to Security Hub and receive findings from Security Hub.
* TranscribeService (3.3.114.0)
	* Amazon Transcribe's Automatic Content Redaction feature enables you to automatically redact sensitive personally identifiable information (PII) from transcription results. It replaces each instance of an identified PII utterance with a [PII] tag in the transcript.
* Core 3.3.104.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.686.0 (2020-02-25 19:10 UTC)
* Kafka (3.3.107.0)
	* Amazon MSK has added support for Broker Log delivery to CloudWatch, S3, and Firehose.
* Outposts (3.3.101.0)
	* This release adds DeleteSite and DeleteOutpost. 
* SecretsManager (3.3.102.0)
	* This release increases the maximum allowed size of SecretString or SecretBinary from 10KB to 64KB in the CreateSecret, UpdateSecret, PutSecretValue and GetSecretValue APIs.
* StepFunctions (3.3.104.0)
	* This release adds support for CloudWatch Logs for Standard Workflows.
* Core 3.3.104.28
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.685.0 (2020-02-24 19:12 UTC)
* CloudWatchEvents (3.3.102.0)
	* This release allows you to create and manage tags for event buses.
* DocDB (3.3.102.54)
	* Documentation updates for docdb
* EventBridge (3.3.101.0)
	* This release allows you to create and manage tags for event buses.
* FSx (3.3.104.0)
	* Announcing persistent file systems for Amazon FSx for Lustre that are ideal for longer-term storage and workloads, and a new generation of scratch file systems that offer higher burst throughput for spiky workloads.
* IoTEvents (3.3.102.47)
	* Documentation updates for iotcolumbo
* Snowball (3.3.102.0)
	* AWS Snowball adds a field for entering your GSTIN when creating AWS Snowball jobs in the Asia Pacific (Mumbai) region. 

### 3.3.684.0 (2020-02-21 19:10 UTC)
* Imagebuilder (3.3.102.0)
	* This release of EC2 Image Builder increases the maximum policy document size for Image Builder resource-based policy APIs.
* Redshift (3.3.106.0)
	* Extend elastic resize to support resizing clusters to different instance types.
* WAFV2 (3.3.100.31)
	* Documentation updates for AWS WAF (wafv2) to correct the guidance for associating a web ACL to a CloudFront distribution.

### 3.3.683.0 (2020-02-20 19:10 UTC)
* AppConfig (3.3.101.0)
	* This release adds exponential growth type support for deployment strategies.
* Pinpoint (3.3.106.0)
	* As of this release of the Amazon Pinpoint API, the Title property is optional for the CampaignEmailMessage object. 
* SavingsPlans (3.3.102.0)
	* Added support for AWS Lambda in Compute Savings Plans

### 3.3.682.0 (2020-02-19 19:12 UTC)
* AutoScaling (3.3.102.1)
	* Doc update for EC2 Auto Scaling: Add Enabled parameter for PutScalingPolicy
* Lambda (3.3.108.0)
	* AWS Lambda now supports Ruby 2.7
* ServiceCatalog (3.3.109.0)
	* "ListPortfolioAccess" API now has a new optional parameter "OrganizationParentId". When it is provided and if the portfolio with the "PortfolioId" given was shared with an organization or organizational unit with "OrganizationParentId", all accounts in the organization sub-tree under parent which inherit an organizational portfolio share will be listed, rather than all accounts with external shares. To accommodate long lists returned from the new option, the API now supports pagination.
* Core 3.3.104.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.681.0 (2020-02-18 19:11 UTC)
* AutoScaling (3.3.102.0)
	* Amazon EC2 Auto Scaling now supports the ability to enable/disable target tracking, step scaling, and simple scaling policies.
* Chime (3.3.107.0)
	* Added AudioFallbackUrl to support Chime SDK client.
* RDS (3.3.118.0)
	* This release supports Microsoft Active Directory authentication for Amazon Aurora.

### 3.3.680.0 (2020-02-17 19:13 UTC)
* Cloud9 (3.3.102.0)
	* AWS Cloud9 now supports the ability to tag Cloud9 development environments. 
* DynamoDBv2 (3.3.105.0)
	* Amazon DynamoDB enables you to restore your DynamoDB backup or table data across AWS Regions such that the restored table is created in a different AWS Region from where the source table or backup resides. You can do cross-region restores between AWS commercial Regions, AWS China Regions, and AWS GovCloud (US) Regions. 
* EC2 (3.3.161.0)
	* Documentation updates for EC2
* Rekognition (3.3.104.0)
	* This update adds the ability to detect text in videos and adds filters to image and video text detection.
* Core 3.3.104.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.679.0 (2020-02-14 19:33 UTC)
* EC2 (3.3.160.0)
	* You can now enable Multi-Attach on Provisioned IOPS io1 volumes through the create-volume API.
* MediaTailor (3.3.103.0)
	* AWS Elemental MediaTailor SDK now allows configuration of Personalization Threshold for HLS and DASH streams.
* SecurityHub (3.3.108.0)
	* Security Hub has released a new DescribeStandards API action. This API action allows a customer to list all of the standards available in an account. For each standard, the list provides the customer with the standard name, description, and ARN. Customers can use the ARN as an input to the BatchEnableStandards API action.  To learn more, visit our API documentation.
* Shield (3.3.102.0)
	* This release adds support for associating Amazon Route 53 health checks to AWS Shield Advanced protected resources.

### 3.3.678.0 (2020-02-13 19:10 UTC)
* MediaPackageVod (3.3.104.0)
	* Adds support for DASH with multiple media presentation description periods triggered by presence of SCTE-35 ad markers in the manifest.Also adds optional configuration for DASH SegmentTemplateFormat to refer to segments by Number with Duration, Number with Timeline or Time with Timeline and compact the manifest by combining duplicate SegmentTemplate tags.
* Core 3.3.104.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.677.1 (2020-02-12 23:11 UTC)
* SecurityToken (3.3.104.30)
	* Improves performance and prevents errors for users with limited privileges when configuring a Security Token Service client.

### 3.3.677.0 (2020-02-12 19:15 UTC)
* Chime (3.3.106.10)
	* Documentation updates for Amazon Chime
* DirectoryService (3.3.103.0)
	* Release to add the ExpirationDateTime as an output to ListCertificates so as to ease customers to look into their certificate lifetime and make timely decisions about renewing them.
* EC2 (3.3.159.0)
	* This release adds support for tagging public IPv4 pools.
* Elasticsearch (3.3.104.0)
	* Amazon Elasticsearch Service now offers fine-grained access control, which adds multiple capabilities to give tighter control over data. New features include the ability to use roles to define granular permissions for indices, documents, or fields and to extend Kibana with read-only views and secure multi-tenant support.
* Glue (3.3.113.0)
	* Adding ability to add arguments that cannot be overridden to AWS Glue jobs
* Neptune (3.3.103.0)
	* This launch enables Neptune start-db-cluster and stop-db-cluster. Stopping and starting Amazon Neptune clusters helps you manage costs for development and test environments. You can temporarily stop all the DB instances in your cluster, instead of setting up and tearing down all the DB instances each time that you use the cluster.
* WorkMail (3.3.103.0)
	* This release adds support for access control rules management  in Amazon WorkMail.

### 3.3.676.0 (2020-02-11 19:15 UTC)
* CloudFormation (3.3.104.0)
	* This release of AWS CloudFormation StackSets allows you to centrally manage deployments to all the accounts in your organization or specific organizational units (OUs) in AWS Organizations. You will also be able to enable automatic deployments to any new accounts added to your organization or OUs. The permissions needed to deploy across accounts will automatically be taken care of by the StackSets service.
* CognitoIdentityProvider (3.3.108.0)
	* Features:This release adds a new setting for a user pool to allow if customer wants their user signup/signin with case insensitive username. The current default setting is case sensitive, and for our next release we will change it to case insensitive.
* EC2 (3.3.158.0)
	* Amazon EC2 Now Supports Tagging Spot Fleet.

### 3.3.675.0 (2020-02-10 19:20 UTC)
* DocDB (3.3.102.50)
	* Added clarifying information that Amazon DocumentDB shares operational technology with Amazon RDS and Amazon Neptune.
* KeyManagementService (3.3.105.0)
	* The ConnectCustomKeyStore API now provides a new error code (SUBNET_NOT_FOUND) for customers to better troubleshoot if their "connect-custom-key-store" operation fails.
* Core 3.3.104.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.674.0 (2020-02-07 19:18 UTC)
* Imagebuilder (3.3.101.0)
	* This version of the SDK includes bug fixes and documentation updates.
* RDS (3.3.117.3)
	* Documentation updates for RDS: when restoring a DB cluster from a snapshot, must create DB instances
* RoboMaker (3.3.109.0)
	* This release adds support for simulation job batches
* Core 3.3.104.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.673.0 (2020-02-06 19:14 UTC)
* AppSync (3.3.104.0)
	* AWS AppSync now supports X-Ray
* CodeBuild (3.3.109.0)
	* AWS CodeBuild adds support for Amazon Elastic File Systems
* EBS (3.3.100.23)
	* Documentation updates for EBS direct APIs.
* EC2 (3.3.157.0)
	* This release adds platform details and billing info to the DescribeImages API.
* ECR (3.3.103.11)
	* This release contains updated text for the GetAuthorizationToken API.
* LexModelBuildingService (3.3.103.0)
	* Amazon Lex now supports AMAZON.AlphaNumeric with regular expressions.

### 3.3.672.0 (2020-02-05 20:20 UTC)
* DLM (3.3.106.0)
	* Updated the maximum number of tags that can be added to a snapshot using DLM to 45.
* EC2 (3.3.156.0)
	* This release provides support for tagging when you create a VPC endpoint, or VPC endpoint service.
* ForecastQueryService (3.3.100.65)
	* Documentation updates for Amazon Forecast.
* GroundStation (3.3.101.0)
	* Adds dataflowEndpointRegion property to DataflowEndpointConfig. The dateCreated, lastUpdated, and tags properties on GetSatellite have been deprecated.
* MediaConvert (3.3.113.0)
	* AWS Elemental MediaConvert SDK has added support for fine-tuned QVBR quality level.
* ResourceGroupsTaggingAPI (3.3.103.25)
	* Documentation-only update that adds services to the list of supported services.
* SecurityHub (3.3.107.0)
	* Additional resource types are now supported in the AWS Security Finding Format (ASFF). The following new resource types are added, each having an accompanying resource details object with fields for security finding providers to populate: AwsCodeBuildProject, AwsEc2NetworkInterface, AwsEc2SecurityGroup, AwsElasticsearchDomain, AwsLambdaLayerVersion, AwsRdsDbInstance, and AwsWafWebAcl. The following resource types are added without an accompanying details object: AutoscalingAutoscalingGroup, AwsDynamoDbTable, AwsEc2Eip, AwsEc2Snapshot, AwsEc2Volume, AwsRdsDbSnapshot, AwsRedshiftCluster, and AwsS3Object. The number of allowed resources per finding is increased from 10 to 32. A new field is added in the Compliance object, RelatedRequirements. To learn more, visit our documentation on the ASFF.

### 3.3.671.0 (2020-02-04 20:49 UTC)
* CloudFront (3.3.101.96)
	* Documentation updates for CloudFront
* EC2 (3.3.155.0)
	* Amazon VPC Flow Logs adds support for 1-minute aggregation intervals.
* IoT (3.3.106.16)
	* Updated ThrottlingException documentation to report that the error code is 400, and not 429, to reflect actual system behaviour.
* Kafka (3.3.106.0)
	* This release enables AWS MSK customers to list Apache Kafka versions that are supported on AWS MSK clusters. Also includes changes to expose additional details of a cluster's state in DescribeCluster and ListClusters APIs.
* SimpleSystemsManagement (3.3.118.0)
	* This feature ensures that an instance is patched up to the available patches on a particular date. It can be enabled by selecting the 'ApproveUntilDate' option as the auto-approval rule while creating the patch baseline. ApproveUntilDate - The cutoff date for auto approval of released patches. Any patches released on or before this date will be installed automatically.
* StorageGateway (3.3.111.0)
	* Adding KVM as a support hypervisor
* WorkMail (3.3.102.0)
	* This release adds support for tagging Amazon WorkMail organizations.
* Core 3.3.104.22
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.670.0 (2020-01-24 19:12 UTC)
* DataSync (3.3.108.0)
	* AWS DataSync now supports FSx for Windows File Server Locations
* ECS (3.3.114.0)
	* This release provides support for tagging Amazon ECS task sets for services using external deployment controllers.
* EKS (3.3.107.0)
	* Adding new error codes for Nodegroups in EKS
* OpsWorksCM (3.3.104.0)
	* AWS OpsWorks for Chef Automate now supports in-place upgrade to Chef Automate 2. Eligible servers can be updated through the management console, CLI and APIs.
* WorkSpaces (3.3.108.6)
	* Documentation updates for WorkSpaces
* Core 3.3.104.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.669.0 (2020-01-23 19:15 UTC)
* IdentityManagement (3.3.105.0)
	* This release enables the Identity and Access Management policy simulator to simulate permissions boundary policies.
* RDS (3.3.117.0)
	* This SDK release introduces APIs that automate the export of Amazon RDS snapshot data to Amazon S3. The new APIs include: StartExportTask, CancelExportTask, DescribeExportTasks. These APIs automate the extraction of data from an RDS snapshot and export it to an Amazon S3 bucket. The data is stored in a compressed, consistent, and query-able format. After the data is exported, you can query it directly using tools such as Amazon Athena or Redshift Spectrum. You can also consume the data as part of a data lake solution. If you archive the data in S3 Infrequent Access or Glacier, you can reduce long term data storage costs by applying data lifecycle policies.
* Core 3.3.104.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.668.1 (2020-01-21 21:31 UTC)
* S3 (3.3.110.17)
	* Fix performance issue when creating an AmazonS3Config object.

### 3.3.668.0 (2020-01-21 19:16 UTC)
* ApplicationDiscoveryService (3.3.102.25)
	* Documentation updates for the AWS Application Discovery Service.
* AWSMarketplaceCommerceAnalytics (3.3.103.0)
	* Remove 4 deprecated data sets, change some data sets available dates to 2017-09-15
* CodePipeline (3.3.105.0)
	* AWS CodePipeline enables an ability to stop pipeline executions.
* EC2 (3.3.154.0)
	* Add an enum value to the result of DescribeByoipCidrs to support CIDRs that are not publicly advertisable.
* IoTEvents (3.3.102.38)
	* Documentation updates for iotcolumbo
* Core 3.3.104.19
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.667.1 (2020-01-20 22:11 UTC)
* S3 (3.3.110.15)
	* Added check to ensure the TransferUtility parts are all completed in a multipart upload and fix AmazonS3Config to check for the us-east-1 regional flag on minimal circumstances

### 3.3.667.0 (2020-01-20 19:17 UTC)
* AlexaForBusiness (3.3.108.0)
	* Add support for CreatedTime and ConnectionStatusUpdatedTime in response of SearchDevices API.
* ApplicationInsights (3.3.103.0)
	* This release adds support for a list API to retrieve the configuration events logged during periodic updates to an application by Amazon CloudWatch Application Insights. 
* CloudWatch (3.3.105.0)
	* Updating DescribeAnomalyDetectors API to return AnomalyDetector Status value in response.
* EC2 (3.3.153.0)
	* This release provides support for a preview of bringing your own IPv6 addresses (BYOIP for IPv6) for use in AWS.
* KeyManagementService (3.3.104.0)
	* The ConnectCustomKeyStore operation now provides new error codes (USER_LOGGED_IN and USER_NOT_FOUND) for customers to better troubleshoot if their connect custom key store operation fails. Password length validation during CreateCustomKeyStore now also occurs on the client side. 
* Lambda (3.3.107.0)
	* Added reason codes to StateReasonCode (InvalidSubnet, InvalidSecurityGroup) and LastUpdateStatusReasonCode (SubnetOutOfIPAddresses, InvalidSubnet, InvalidSecurityGroup) for functions that connect to a VPC.

### 3.3.666.0 (2020-01-17 19:16 UTC)
* Batch (3.3.104.0)
	* This release ensures INACTIVE job definitions are permanently deleted after 180 days.
* CloudHSMV2 (3.3.101.0)
	* This release introduces resource-level and tag-based access control for AWS CloudHSM resources. You can now tag CloudHSM backups, tag CloudHSM clusters on creation, and tag a backup as you copy it to another region.
* ECS (3.3.113.0)
	* This release provides a public preview for specifying Amazon EFS file systems as volumes in your Amazon ECS task definitions.
* MediaConvert (3.3.112.0)
	* AWS Elemental MediaConvert SDK has added support for MP3 audio only outputs.
* Neptune (3.3.102.0)
	* This release includes Deletion Protection for Amazon Neptune databases.
* Redshift (3.3.105.21)
	* Documentation updates for redshift
* Core 3.3.104.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.665.0 (2020-01-16 21:20 UTC)
* DirectoryService (3.3.102.0)
	* To reduce the number of errors our customers are facing, we have modified the requirements of input parameters for two of Directory Service APIs.
* EC2 (3.3.152.0)
	* Client VPN now supports Port Configuration for VPN Endpoints, allowing usage of either port 443 or port 1194.
* SageMaker (3.3.110.0)
	* This release adds two new APIs (UpdateWorkforce and DescribeWorkforce) to SageMaker Ground Truth service for workforce IP whitelisting.
* Core 3.3.104.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.664.0 (2020-01-15 20:03 UTC)
* EC2 (3.3.151.0)
	* General Update to EC2 Docs and SDKs
* Organizations (3.3.104.18)
	* Updated description for PolicyID parameter and ConstraintViolationException.
* SecurityHub (3.3.106.0)
	* Add support for DescribeStandardsControls and UpdateStandardsControl. These new Security Hub API operations are used to track and manage whether a compliance standards control is enabled.
* SimpleSystemsManagement (3.3.117.7)
	* Document updates for Patch Manager 'NoReboot' feature.
* Core 3.3.104.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.663.0 (2020-01-14 19:16 UTC)
* EC2 (3.3.150.0)
	* This release adds support for partition placement groups and instance metadata option in Launch Templates

### 3.3.662.0 (2020-01-13 19:11 UTC)
* Backup (3.3.101.0)
	* Cross-region backup is a new AWS Backup feature that allows enterprises to copy backups across multiple AWS services to different regions. 
* EC2 (3.3.149.1)
	* Documentation updates for the StopInstances API. You can now stop and start an Amazon EBS-backed Spot Instance at will, instead of relying on the Stop interruption behavior to stop your Spot Instances when interrupted.
* ElasticFileSystem (3.3.104.0)
	* This release adds support for managing EFS file system policies and EFS Access Points.

### 3.3.661.0 (2020-01-10 19:16 UTC)
* Chime (3.3.106.0)
	* Add shared profile support to new and existing users
* EC2 (3.3.149.0)
	* This release introduces the ability to tag egress only internet gateways, local gateways, local gateway route tables, local gateway virtual interfaces, local gateway virtual interface groups, local gateway route table VPC association and local gateway route table virtual interface group association. You can use tags to organize and identify your resources for cost allocation. 
* RDS (3.3.116.0)
	* This release adds an operation that enables users to override the system-default SSL/TLS certificate for new Amazon RDS DB instances temporarily, or remove the customer override.
* SageMaker (3.3.109.0)
	* SageMaker ListTrialComponents API filter by TrialName and ExperimentName.
* Transfer (3.3.105.0)
	* This release introduces a new endpoint type that allows you to attach Elastic IP addresses from your AWS account with your server's endpoint directly and whitelist access to your server by client's internet IP address(es) using VPC Security Groups.
* WorkSpaces (3.3.108.0)
	* Added the migrate feature to Amazon WorkSpaces.
* Core 3.3.104.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.660.1 (2020-01-09 19:22 UTC)
* CloudWatchLogs (3.3.101.71)
	* Documentation updates for logs
* SecurityToken (3.3.104.19)
	* Documentation updates for sts

### 3.3.660.0 (2020-01-08 20:41 UTC)
* CostExplorer (3.3.106.18)
	* Documentation updates for CreateCostCategoryDefinition and UpdateCostCategoryDefinition API
* FMS (3.3.103.0)
	* AWS Firewall Manager now supports tagging, and tag-based access control, of policies.
* Translate (3.3.101.0)
	* This release adds a new family of APIs for asynchronous batch translation service that provides option to translate large collection of text or HTML documents stored in Amazon S3 folder. This service accepts a batch of up to 5 GB in size per API call with each document not exceeding 1 MB size and the number of documents not exceeding 1 million per batch. See documentation for more information. 

### 3.3.659.1 (2020-01-08 00:36 UTC)
* Lambda (3.3.106.14)
	* Add ability to clear Layers for a Lambda function
* S3 (3.3.110.10)
	* Updated docs for UseSignatureVersion4 property on the AWSConfigs
* Core 3.3.104.14
	* Fixed issue resolving AWS credentials using JWT tokens with EKS.
	* All services packages updated to require new Core

### 3.3.659.0 (2020-01-07 19:37 UTC)
* CodeBuild (3.3.108.0)
	* Add encryption key override to StartBuild API in AWS CodeBuild.
* MigrationHub (3.3.102.0)
	* ListApplicationStates API provides a list of all application migration states
* XRay (3.3.101.108)
	* Documentation updates for xray

### 3.3.658.0 (2020-01-06 19:11 UTC)
* Comprehend (3.3.108.0)
	* Amazon Comprehend now supports Multilabel document classification
* EC2 (3.3.148.0)
	* This release supports service providers configuring a private DNS name for services other than AWS services and services available in the AWS marketplace. This feature allows consumers to access the service using an existing DNS name without making changes to their applications.
* MediaPackage (3.3.104.0)
	* You can now restrict direct access to AWS Elemental MediaPackage by securing requests for live content using CDN authorization. With CDN authorization, content requests require a specific HTTP header and authorization code.
* Core 3.3.104.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.657.0 (2020-01-02 19:14 UTC)
* CostExplorer (3.3.106.15)
	* Documentation updates for GetReservationUtilization for the Cost Explorer API.
* ECR (3.3.103.0)
	* Adds waiters for ImageScanComplete and LifecyclePolicyPreviewComplete
* LexModelBuildingService (3.3.102.4)
	* Documentation updates for Amazon Lex.
* Lightsail (3.3.102.0)
	* This release adds support for Certificate Authority (CA) certificate identifier to managed databases in Amazon Lightsail.
* Core 3.3.104.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.656.1 (2019-12-25 00:21 UTC)
* Core 3.3.104.11
	* Fix support of the role_session_name property in the shared credentials file
	* All services packages updated to require new Core

### 3.3.656.0 (2019-12-23 19:12 UTC)
* AWSHealth (3.3.102.0)
	* With this release, you can now centrally aggregate AWS Health events from all accounts in your AWS organization. Visit AWS Health documentation to learn more about enabling and using this feature: https://docs.aws.amazon.com/health/latest/ug/organizational-view-health.html. 
* Detective (3.3.100.6)
	* Updated the documentation for Amazon Detective.
* FSx (3.3.103.0)
	* This release adds a new family of APIs (create-data-repository-task, describe-data-repository-task, and cancel-data-repository-task) that allow users to perform operations between their file system and its linked data repository.
* Core 3.3.104.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.655.0 (2019-12-20 19:20 UTC)
* DeviceFarm (3.3.102.0)
	* Introduced browser testing support through AWS Device Farm
* EC2 (3.3.147.0)
	* This release introduces the ability to tag key pairs, placement groups, export tasks, import image tasks, import snapshot tasks and export image tasks. You can use tags to organize and identify your resources for cost allocation. 
* EKS (3.3.106.0)
	* Amazon EKS now supports restricting access to the API server public endpoint by applying CIDR blocks
* Pinpoint (3.3.105.0)
	* This release of the Amazon Pinpoint API introduces versioning support for message templates.
* RDS (3.3.115.0)
	* This release adds an operation that enables users to specify whether a database is restarted when its SSL/TLS certificate is rotated. Only customers who do not use SSL/TLS should use this operation.
* Redshift (3.3.105.12)
	* Documentation updates for Amazon Redshift RA3 node types.
* SecurityHub (3.3.105.0)
	* Additional resource types are now fully supported in the AWS Security Finding Format (ASFF). These resources include AwsElbv2LoadBalancer, AwsKmsKey, AwsIamRole, AwsSqsQueue, AwsLambdaFunction, AwsSnsTopic, and AwsCloudFrontDistribution. Each of these resource types includes an accompanying resource details object with fields for security finding providers to populate. Updates were made to the AwsIamAccessKey resource details object to include information on principal ID and name. To learn more, visit our documentation on the ASFF.
* SimpleSystemsManagement (3.3.117.0)
	* This release updates the attachments support to include AttachmentReference source for Automation documents.
* TranscribeService (3.3.113.0)
	* AWS Transcribe now supports vocabulary filtering that allows customers to input words to the service that they don't want to see in the output transcript.
* Core 3.3.104.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.654.1 (2019-12-19 22:06 UTC)
* S3 (3.3.110.4)
	* Adding configuration of S3 timeouts to MaxTimeout for .NET Standard

### 3.3.654.0 (2019-12-19 19:42 UTC)
* CodeStarconnections (3.3.100.0)
	* Public beta for Bitbucket Cloud support in AWS CodePipeline through integration with AWS CodeStar connections.
* DLM (3.3.105.0)
	* You can now copy snapshots across regions using Data Lifecycle Manager (DLM). You can enable policies which, along with create, can now also copy snapshots to one or more AWS region(s). Copies can be scheduled for up to three regions from a single policy and retention periods are set for each region separately. 
* EC2 (3.3.146.0)
	* We are updating the supportedRootDevices field to supportedRootDeviceTypes for DescribeInstanceTypes API to ensure that the actual value is returned, correcting a previous error in the model.
* GameLift (3.3.105.0)
	* Amazon GameLift now supports ARNs for all key GameLift resources, tagging for GameLift resource authorization management, and updated documentation that articulates GameLift's resource authorization strategy.
* LexModelBuildingService (3.3.102.0)
	* Amazon Lex now supports conversation logs and slot obfuscation.
* PersonalizeRuntime (3.3.102.0)
	* Add context map to get-recommendations and get-personalized-ranking request objects to provide contextual metadata at inference time
* SimpleSystemsManagement (3.3.116.0)
	* This release allows customers to add tags to Automation execution, enabling them to sort and filter executions in different ways, such as by resource, purpose, owner, or environment.
* TranscribeService (3.3.112.0)
	* Amazon Transcribe supports job queuing for the StartTranscriptionJob API.

### 3.3.653.0 (2019-12-18 19:46 UTC)
* CloudFront (3.3.101.82)
	* Documentation updates for CloudFront
* EC2 (3.3.145.0)
	* This release introduces the ability to tag Elastic Graphics accelerators. You can use tags to organize and identify your accelerators for cost allocation.
* OpsWorksCM (3.3.103.0)
	* AWS OpsWorks CM now supports tagging, and tag-based access control, of servers and backups.
* ResourceGroupsTaggingAPI (3.3.103.10)
	* Documentation updates for resourcegroupstaggingapi
* S3 (3.3.110.3)
	* Updates Amazon S3 endpoints allowing you to configure your client to opt-in to using S3 with the us-east-1 regional endpoint, instead of global.
* Core 3.3.104.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.652.1 (2019-12-17 23:29 UTC)
* SecurityToken (3.3.104.11)
	* Updated to use new Core, version 3.3.104.7
	* Adds extension methods, tests, and custom retry logic for creating AssumeRoleImmutableCredentials using the AssumeRoleWithWebIdentity operation.  More information on the use of these credentials can be found in the Core project.
* Core 3.3.104.7
	* Adds a means to use web identity tokens, such as OIDC tokens, to assume roles using the Security Token Service as part of the regular credential chain.  Users may specify a WebIdentityTokenFile, RoleArn, and optionally a RoleSessionName to create these refreshing credentials.
	* All services packages updated to require new Core

### 3.3.652.0 (2019-12-17 19:48 UTC)
* EC2 (3.3.144.1)
	* Documentation updates for Amazon EC2
* ECS (3.3.112.7)
	* Documentation updates for Amazon ECS.
* IoT (3.3.106.0)
	* Added a new Over-the-Air (OTA) Update feature that allows you to use different, or multiple, protocols to transfer an image from the AWS cloud to IoT devices.
* KinesisAnalyticsV2 (3.3.103.0)
	* Kinesis Data Analytics service now supports running Java applications using Flink 1.8.
* MediaLive (3.3.107.0)
	* AWS Elemental MediaLive now supports HLS ID3 segment tagging, HLS redundant manifests for CDNs that support different publishing/viewing endpoints, fragmented MP4 (fMP4), and frame capture intervals specified in milliseconds.
* SimpleSystemsManagement (3.3.115.0)
	* Added support for Cloud Watch Output and Document Version to the Run Command tasks in Maintenance Windows.

### 3.3.651.0 (2019-12-16 19:11 UTC)
* ComprehendMedical (3.3.102.0)
	* New Ontology linking APIs will provides medication concepts normalization and Diagnoses codes from input text. In this release we will provide two APIs -  RxNorm and ICD10-CM. 
* EC2 (3.3.144.0)
	* You can now configure your EC2 Fleet to preferentially use EC2 Capacity Reservations for launching On-Demand instances, enabling you to fully utilize the available (and unused) Capacity Reservations before launching On-Demand instances on net new capacity.
* MQ (3.3.105.0)
	* Amazon MQ now supports throughput-optimized message brokers, backed by Amazon EBS.
* Core 3.3.104.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.650.0 (2019-12-13 21:43 UTC)
* S3 (3.3.110.0)
	* Updated to use new Core, version 3.3.104.5
	* The S3 client now supports a regional endpoint property for us-east-1
* Core 3.3.104.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.649.0 (2019-12-13 19:49 UTC)
* CodeBuild (3.3.107.0)
	* CodeBuild adds support for cross account
* Detective (3.3.100.0)
	* This is the initial release of Amazon Detective.
* SimpleEmailV2 (3.3.102.0)
	* Added the ability to use your own public-private key pair to configure DKIM authentication for a domain identity.

### 3.3.648.0 (2019-12-12 19:14 UTC)
* AccessAnalyzer (3.3.101.0)
	* This release includes improvements and fixes bugs for the IAM Access Analyzer feature.
* Core 3.3.104.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.647.1 (2019-12-12 00:11 UTC)
* S3 (3.3.109.3)
	* Updated to use new Core, version 3.3.104.3
	* Fixes to prevent TransferUtility commands from partially succeeding
* Core 3.3.104.3
	* Changes to handle and retry OperationCanceledException exceptions in Net Standard versions of the SDK when thrown by HttpClient where it isn't a user issued cancellation.
	* All services packages updated to require new Core

### 3.3.647.0 (2019-12-11 19:13 UTC)
* EC2 (3.3.143.0)
	* This release allows customers to attach multiple Elastic Inference Accelerators to a single EC2 instance. It adds support for a Count parameter for each Elastic Inference Accelerator type you specify on the RunInstances and LaunchTemplate APIs.
* Core 3.3.104.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.646.0 (2019-12-10 20:29 UTC)
* Kendra (3.3.101.0)
	* 1. Adding DocumentTitleFieldName as an optional configuration for SharePoint. 2. updating s3 object pattern to  support all s3 keys.

### 3.3.645.0 (2019-12-09 20:24 UTC)
* Kafka (3.3.105.0)
	* AWS MSK has added support for Open Monitoring with Prometheus.
* KeyManagementService (3.3.103.0)
	* The Verify operation now returns KMSInvalidSignatureException on invalid signatures. The Sign and Verify operations now return KMSInvalidStateException when a request is made against a CMK pending deletion.
* QuickSight (3.3.102.7)
	* Documentation updates for QuickSight
* SimpleSystemsManagement (3.3.114.0)
	* Adds the SSM GetCalendarState API and ChangeCalendar SSM Document type. These features enable the forthcoming Systems Manager Change Calendar feature, which will allow you to schedule events during which actions should (or should not) be performed.
* Core 3.3.104.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.644.0 (2019-12-05 01:33 UTC)
* ApiGatewayV2 (3.3.104.0)
	* Amazon API Gateway now supports HTTP APIs (beta), enabling customers to quickly build high performance RESTful APIs that are up to 71% cheaper than REST APIs also available from API Gateway. HTTP APIs are optimized for building APIs that proxy to AWS Lambda functions or HTTP backends, making them ideal for serverless workloads. Using HTTP APIs, you can secure your APIs using OIDC and OAuth 2 out of box, quickly build web applications using a simple CORS experience, and get started immediately with automatic deployment and simple create workflows.
* KinesisVideo (3.3.102.0)
	* Introduces management of signaling channels for Kinesis Video Streams.
* KinesisVideoSignalingChannels (3.3.100.0)
	* Announcing support for WebRTC in Kinesis Video Streams, as fully managed capability. You can now use simple APIs to enable your connected devices, web, and mobile apps with real-time two-way media streaming capabilities.

### 3.3.643.0 (2019-12-04 01:41 UTC)
* ApplicationAutoScaling (3.3.104.0)
	* This release supports auto scaling of provisioned concurrency for AWS Lambda.
* EBS (3.3.100.0)
	* This release introduces the EBS direct APIs for Snapshots: 1. ListSnapshotBlocks, which lists the block indexes and block tokens for blocks in an Amazon EBS snapshot. 2. ListChangedBlocks, which lists the block indexes and block tokens for blocks that are different between two snapshots of the same volume/snapshot lineage. 3. GetSnapshotBlock, which returns the data in a block of an Amazon EBS snapshot.
* Lambda (3.3.106.0)
	* - Added the ProvisionedConcurrency type and operations. Allocate provisioned concurrency to enable your function to scale up without fluctuations in latency. Use PutProvisionedConcurrencyConfig to configure provisioned concurrency on a version of a function, or on an alias.
* RDS (3.3.114.0)
	* This release adds support for the Amazon RDS Proxy
* Rekognition (3.3.103.0)
	* This SDK Release introduces APIs for Amazon Rekognition Custom Labels feature (CreateProjects, CreateProjectVersion,DescribeProjects, DescribeProjectVersions, StartProjectVersion, StopProjectVersion and DetectCustomLabels).  Also new is  AugmentedAI (Human In The Loop) Support for DetectModerationLabels in Amazon Rekognition.
* SageMaker (3.3.108.0)
	* You can now use SageMaker Autopilot for automatically training and tuning candidate models using a combination of various feature engineering, ML algorithms, and hyperparameters determined from the user's input data. SageMaker Automatic Model Tuning now supports tuning across multiple algorithms. With Amazon SageMaker Experiments users can create Experiments, ExperimentTrials, and ExperimentTrialComponents to track, organize, and evaluate their ML training jobs. With Amazon SageMaker Debugger, users can easily debug training jobs using a number of pre-built rules provided by Amazon SageMaker, or build custom rules. With Amazon SageMaker Processing, users can run on-demand, distributed, and fully managed jobs for data pre- or post- processing or model evaluation. With Amazon SageMaker Model Monitor, a user can create MonitoringSchedules to automatically monitor endpoints to detect data drift and other issues and get alerted on them. This release also includes the preview version of Amazon SageMaker Studio with Domains, UserProfiles, and Apps. This release also includes the preview version of Amazon Augmented AI to easily implement human review of machine learning predictions by creating FlowDefinitions, HumanTaskUis, and HumanLoops.
* StepFunctions (3.3.103.0)
	* This release of the AWS Step Functions SDK introduces support for Express Workflows.

### 3.3.642.0 (2019-12-03 19:17 UTC)
* AugmentedAIRuntime (3.3.100.0)
	* This release adds support for Amazon Augmented AI, which makes it easy to build workflows for human review of machine learning predictions.
* CodeGuruProfiler (3.3.100.0)
	* (New Service) Amazon CodeGuru Profiler analyzes application CPU utilization and latency characteristics to show you where you are spending the most cycles in your application. This analysis is presented in an interactive flame graph that helps you easily understand which paths consume the most resources, verify that your application is performing as expected, and uncover areas that can be optimized further.
* CodeGuruReviewer (3.3.100.0)
	* This is the preview release of Amazon CodeGuru Reviewer.
* ComputeOptimizer (3.3.100.0)
	* Initial release of AWS Compute Optimizer. AWS Compute Optimizer recommends optimal AWS Compute resources to reduce costs and improve performance for your workloads.
* EC2 (3.3.142.0)
	* This release adds support for the following features: 1. An option to enable acceleration for Site-to-Site VPN connections, to improve connection performance by leveraging AWS Global Accelerator; 2. Inf1 instances featuring up to 16 AWS Inferentia chips, custom-built for ML inference applications to deliver low latency and high throughput performance. Use Inf1 instances to run high scale ML inference applications such as image recognition, speech recognition, natural language processing, personalization, and fraud detection at the lowest cost in the cloud. Inf1 instances will soon be available for use with Amazon SageMaker, Amazon EKS and Amazon ECS. To get started, see https://aws.amazon.com/ec2/instance-types/Inf1; 3. The ability to associate route tables with internet gateways and virtual private gateways, and define routes to insert network and security virtual appliances in the path of inbound and outbound traffic. For more information on Amazon VPC Ingress Routing, see https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html#gateway-route-table; 4. AWS Local Zones that place compute, storage, database, and other select services closer to you for applications that require very low latency to your end-users. AWS Local Zones also allow you to seamlessly connect to the full range of services in the AWS Region through the same APIs and tool sets; 5. Launching and viewing EC2 instances and EBS volumes running locally in Outposts. This release also introduces a new local gateway (LGW) with Outposts to enable connectivity between Outposts and local on-premises networks as well as the internet; 6. Peering Transit Gateways between regions simplifying creation of secure and private global networks on AWS; 7. Transit Gateway Multicast, enabling multicast routing within and between VPCs using Transit Gateway as a multicast router.
* ECS (3.3.112.0)
	* This release supports ECS Capacity Providers, Fargate Spot, and ECS Cluster Auto Scaling.  These features enable new ways for ECS to manage compute capacity used by tasks.
* EKS (3.3.105.0)
	* Introducing Amazon EKS with Fargate. Customers can now use Amazon EKS to launch pods directly onto AWS Fargate, the serverless compute engine built for containers on AWS. 
* Elasticsearch (3.3.103.0)
	* UltraWarm storage provides a cost-effective way to store large amounts of read-only data on Amazon Elasticsearch Service. Rather than attached storage, UltraWarm nodes use Amazon S3 and a sophisticated caching solution to improve performance. For indices that you are not actively writing to and query less frequently, UltraWarm storage offers significantly lower costs per GiB. In Elasticsearch, these warm indices behave just like any other index. You can query them using the same APIs or use them to create dashboards in Kibana.
* FraudDetector (3.3.100.0)
	* Amazon Fraud Detector is a fully managed service that makes it easy to identify potentially fraudulent online activities such as online payment fraud and the creation of fake accounts. Amazon Fraud Detector uses your data, machine learning (ML), and more than 20 years of fraud detection expertise from Amazon to automatically identify potentially fraudulent online activity so you can catch more fraud faster.
* Kendra (3.3.100.0)
	* It is a preview launch of Amazon Kendra. Amazon Kendra is a managed, highly accurate and easy to use enterprise search service that is powered by machine learning.
* NetworkManager (3.3.100.0)
	* This is the initial SDK release for AWS Network Manager.
* Outposts (3.3.100.0)
	* This is the initial release for AWS Outposts, a fully managed service that extends AWS infrastructure, services, APIs, and tools to customer sites. AWS Outposts enables you to launch and run EC2 instances and EBS volumes locally at your on-premises location. This release introduces new APIs for creating and viewing Outposts. 
* S3 (3.3.109.0)
	* Updated to use new Core, version 3.3.104.0
	* Amazon S3 Access Points is a new S3 feature that simplifies managing data access at scale for shared data sets on Amazon S3. Access Points provide a customizable way to access the objects in a bucket, with a unique hostname and access policy that enforces the specific permissions and network controls for any request made through the access point. This represents a new way of provisioning access to shared data sets.
* S3Control (3.3.102.0)
	* Amazon S3 Access Points is a new S3 feature that simplifies managing data access at scale for shared data sets on Amazon S3. Access Points provide a customizable way to access the objects in a bucket, with a unique hostname and access policy that enforces the specific permissions and network controls for any request made through the access point. This represents a new way of provisioning access to shared data sets.
* Textract (3.3.102.0)
	* This SDK Release introduces Amazon Augmented AI support for Amazon Textract AnalyzeDocument API. Image byte payloads for synchronous operations have increased from 5 MB to 10 MB.
* Core 3.3.104.0
	* Changes to support Amazon S3 Access Points
Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.641.0 (2019-12-02 23:52 UTC)
* AccessAnalyzer (3.3.100.0)
	* Introducing AWS IAM Access Analyzer, an IAM feature that makes it easy for AWS customers to ensure that their resource-based policies provide only the intended access to resources outside their AWS accounts.

### 3.3.640.0 (2019-12-02 09:31 UTC)
* EC2 (3.3.141.0)
	* AWS now provides a new BYOL experience for software licenses, such as Windows and SQL Server, that require a dedicated physical server. You can now enjoy the flexibility and cost effectiveness of using your own licenses on Amazon EC2 Dedicated Hosts, but with the simplicity, resiliency, and elasticity of AWS. You can specify your Dedicated Host management preferences, such as host allocation, host capacity utilization, and instance placement in AWS License Manager.  Once set up, AWS takes care of these administrative tasks on your behalf, so that you can seamlessly launch virtual machines (instances) on Dedicated Hosts just like you would launch an EC2 instance with AWS provided licenses.
* Imagebuilder (3.3.100.0)
	* This is the first release of EC2 Image Builder, a service that provides a managed experience for automating the creation of EC2 AMIs.
* LicenseManager (3.3.101.0)
	* AWS License Manager now automates discovery of bring-your-own-license usage across the customers organization. With few simple settings, customers can add bring your own license product information along with licensing rules, which would enable License Manager to automatically track the instances that have the specified products installed. If License Manager detects any violation of licensing rules, it would notify the customers designated license administrator to take corrective action.
* Schemas (3.3.100.0)
	* This release introduces support for Amazon EventBridge schema registry, making it easy to discover and write code for events in EventBridge.
* Core 3.3.103.71
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.639.0 (2019-11-26 19:12 UTC)
* CognitoIdentityProvider (3.3.107.0)
	* This release adds a new setting for a user pool to configure which recovery methods a user can use to recover their account via the forgot password operation.
* DirectoryService (3.3.101.0)
	* This release will introduce optional encryption over LDAP network traffic using SSL certificates between customer's self-managed AD and AWS Directory Services instances. The release also provides APIs for Certificate management.
* DynamoDBv2 (3.3.104.0)
	* 1) Amazon Contributor Insights for Amazon DynamoDB is a diagnostic tool for identifying frequently accessed keys and understanding database traffic trends. 2) Support for displaying new fields when a table's encryption state is Inaccessible or the table have been Archived.
* ElasticInference (3.3.100.0)
	* Amazon Elastic Inference allows customers to attach Elastic Inference Accelerators to Amazon EC2 and Amazon ECS tasks, thus providing low-cost GPU-powered acceleration and reducing the cost of running deep learning inference. This release allows customers to add or remove tags for their Elastic Inference Accelerators.
* MediaTailor (3.3.102.0)
	* AWS Elemental MediaTailor SDK now allows configuration of the Live Pre-Roll feature for HLS and DASH streams.
* Organizations (3.3.104.0)
	* Introduces the DescribeEffectivePolicy action, which returns the contents of the policy that's in effect for the account.
* QuickSight (3.3.102.4)
	* Documentation updates for QuickSight
* RDSDataService (3.3.103.0)
	* Type hints to improve handling of some specific parameter types (date/time, decimal etc) for ExecuteStatement and BatchExecuteStatement APIs
* ResourceGroupsTaggingAPI (3.3.103.0)
	* You can use tag policies to help standardize on tags across your organization's resources.
* ServerlessApplicationRepository (3.3.101.0)
	* AWS Serverless Application Repository now supports verified authors. Verified means that AWS has made a good faith review, as a reasonable and prudent service provider, of the information provided by the requester and has confirmed that the requester's identity is as claimed.
* WorkSpaces (3.3.107.0)
	* For the WorkspaceBundle API, added the image identifier and the time of the last update.
* Core 3.3.103.70
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.638.0 (2019-11-25 21:21 UTC)
* AlexaForBusiness (3.3.107.0)
	* API update for Alexa for Business: This update enables the use of meeting room configuration that can be applied to a room profile. These settings help improve and measure utilization on Alexa for Business enabled rooms. New features include end meeting reminders, intelligent room release and room utilization analytics report.
* AppConfig (3.3.100.0)
	* Introducing AWS AppConfig, a new service that enables customers to quickly deploy validated configurations to applications of any size in a controlled and monitored fashion.
* ApplicationAutoScaling (3.3.103.0)
	* This release supports auto scaling of document classifier endpoints for Comprehend; and supports target tracking based on the average capacity utilization metric for AppStream 2.0 fleets. 
* ApplicationInsights (3.3.102.0)
	* CloudWatch Application Insights for .NET and SQL Server includes the follwing features: -Tagging Create and manage tags for your applications.-Custom log pattern matching. Define custom log patterns to be detected and monitored.-Resource-level permissions. Specify applications users can access.
* Athena (3.3.103.0)
	* This release adds additional query lifecycle metrics to the QueryExecutionStatistics object in GetQueryExecution response.
* CloudWatch (3.3.104.0)
	* This release adds a new feature called "Contributor Insights". "Contributor Insights" supports the following 6 new APIs (PutInsightRule, DeleteInsightRules, EnableInsightRules, DisableInsightRules, DescribeInsightRules and GetInsightRuleReport). 
* CodeBuild (3.3.106.0)
	* CodeBuild adds support for test reporting
* CognitoIdentityProvider (3.3.106.0)
	* Amazon Cognito Userpools now supports Sign in with Apple as an Identity Provider.
* Comprehend (3.3.107.0)
	* Amazon Comprehend now supports real-time analysis with Custom Classification
* CostExplorer (3.3.106.0)
	* This launch provides customers with access to Cost Category Public Beta APIs.
* DLM (3.3.104.0)
	* You can now set time based retention policies on Data Lifecycle Manager. With this launch, DLM allows you to set snapshot retention period in the following interval units: days, weeks, months and years.
* EC2 (3.3.140.0)
	* This release adds two new APIs: 1. ModifyDefaultCreditSpecification, which allows you to set default credit specification at the account level per AWS Region, per burstable performance instance family, so that all new burstable performance instances in the account launch using the new default credit specification. 2. GetDefaultCreditSpecification, which allows you to get current default credit specification per AWS Region, per burstable performance instance family. This release also adds new client exceptions for StartInstances and StopInstances.
* ElasticLoadBalancingV2 (3.3.104.0)
	* This release of Elastic Load Balancing V2 adds new subnet features for Network Load Balancers and a new routing algorithm for Application Load Balancers. 
* Greengrass (3.3.105.0)
	* IoT Greengrass supports machine learning resources in 'No container' mode.
* IoT (3.3.105.0)
	* This release adds: 1) APIs for fleet provisioning claim and template, 2) endpoint configuration and custom domains, 3) support for enhanced custom authentication, d) support for 4 additional audit checks: Device and CA certificate key quality checks, IoT role alias over-permissive check and IoT role alias access to unused services check, 5) extended capability of AWS IoT Rules Engine to support IoT SiteWise rule action. The IoT SiteWise rule action lets you send messages from IoT sensors and applications to IoT SiteWise asset properties
* IoTSecureTunneling (3.3.100.0)
	* This release adds support for IoT Secure Tunneling to remote access devices behind restricted firewalls.
* KeyManagementService (3.3.102.0)
	* AWS Key Management Service (KMS) now enables creation and use of asymmetric Customer Master Keys (CMKs) and the generation of asymmetric data key pairs.
* KinesisAnalyticsV2 (3.3.102.0)
	* Kinesis Data Analytics service adds support to configure Java applications to access resources in a VPC. Also releasing support to configure Java applications to set allowNonRestoreState flag through the service APIs.
* Lambda (3.3.105.0)
	* Added the function state and update status to the output of GetFunctionConfiguration and other actions. Check the state information to ensure that a function is ready before you perform operations on it. Functions take time to become ready when you connect them to a VPC.Added the EventInvokeConfig type and operations to configure error handling options for asynchronous invocation. Use PutFunctionEventInvokeConfig to configure the number of retries and the maximum age of events when you invoke the function asynchronously.Added on-failure and on-success destination settings for asynchronous invocation. Configure destinations to send an invocation record to an SNS topic, an SQS queue, an EventBridge event bus, or a Lambda function.Added error handling options to event source mappings. This enables you to configure the number of retries, configure the maximum age of records, or retry with smaller batches when an error occurs when a function processes a Kinesis or DynamoDB stream.Added the on-failure destination setting to event source mappings. This enables you to send discarded events to an SNS topic or SQS queue when all retries fail or when the maximum record age is exceeded when a function processes a Kinesis or DynamoDB stream.Added the ParallelizationFactor option to event source mappings to increase concurrency per shard when a function processes a Kinesis or DynamoDB stream.
* Lex (3.3.104.0)
	* Amazon Lex adds "sessionId" attribute to the PostText and PostContent response.
* MediaConvert (3.3.111.0)
	* AWS Elemental MediaConvert SDK has added support for 8K outputs and support for QuickTime Animation Codec (RLE) inputs.
* MediaLive (3.3.106.0)
	* AWS Elemental MediaLive now supports the ability to create a multiple program transport stream (MPTS).
* MediaPackageVod (3.3.103.0)
	* Adds a domain name to PackagingGroups, representing the fully qualified domain name for Assets created in the group.
* RAM (3.3.102.0)
	* AWS RAM provides new APIs to view the permissions granted to principals in a resource share. This release also creates corresponding resource shares for supported services that use resource policies, as well as an API to promote them to standard shares that can be managed in RAM.
* RDS (3.3.113.0)
	* Cluster Endpoints can now be tagged by using --tags in the create-db-cluster-endpoint API
* Redshift (3.3.105.0)
	* This release contains changes for 1. Redshift Scheduler 2. Update to the DescribeNodeConfigurationOptions to include a new action type recommend-node-config
* SageMakerRuntime (3.3.101.0)
	* Amazon SageMaker Runtime now supports a new TargetModel header to invoke a specific model hosted on multi model endpoints.
* SimpleEmailV2 (3.3.101.0)
	* This release includes support for automatically suppressing email addresses that result in hard bounce or complaint events at the account level, and for managing addresses on this account-level suppression list.
* SimpleSystemsManagement (3.3.113.0)
	* AWS Systems Manager Documents now supports more Document Types: ApplicationConfiguration, ApplicationConfigurationSchema and DeploymentStrategy. This release also extends Document Permissions capabilities and introduces a new Force flag for DeleteDocument API.
* WAFV2 (3.3.100.0)
	* This release introduces new set of APIs (wafv2) for AWS WAF. Major changes include single set of APIs for creating/updating resources in global and regional scope, and rules are configured directly into web ACL instead of being referenced. The previous APIs (waf and waf-regional) are now referred as AWS WAF Classic. For more information visit: https://docs.aws.amazon.com/waf/latest/APIReference/Welcome.html
* Core 3.3.103.69
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.637.0 (2019-11-22 20:14 UTC)
* ApplicationAutoScaling (3.3.102.0)
	* Update default endpoint for Application Auto Scaling.
* AutoScalingPlans (3.3.101.0)
	* Update default endpoint for AWS Auto Scaling.
* CertificateManager (3.3.101.0)
	* This release adds support for Tag-Based IAM for AWS Certificate Manager and adding tags to certificates upon creation.
* CodeBuild (3.3.105.0)
	* Add Canonical ARN to LogsLocation.
* EC2 (3.3.139.0)
	* This release adds two new APIs (DescribeInstanceTypes and DescribeInstanceTypeOfferings) that give customers access to instance type attributes and regional and zonal offerings.
* ElasticMapReduce (3.3.104.0)
	* Amazon EMR adds support for concurrent step execution and cancelling running steps. Amazon EMR has added a new Outpost ARN field in the ListCluster and DescribeCluster API responses that is populated for clusters launched in an AWS Outpost subnet.
* ForecastService (3.3.101.0)
	* This release adds two key updates to existing APIs. 1. Amazon Forecast can now generate forecasts in any quantile using the optional parameter forecastTypes in the CreateForecast API and 2. You can get additional details (metrics and relevant error messages) on your AutoML runs using the DescribePredictor and GetAccuracyMetrics APIs.
* MediaPackageVod (3.3.102.0)
	* Includes the submission time of Asset ingestion request in the API response for Create/List/Describe Assets.
* Rekognition (3.3.102.0)
	* This release adds enhanced face filtering support to the IndexFaces API operation, and introduces face filtering for CompareFaces and SearchFacesByImage API operations.
* SecurityToken (3.3.104.0)
	* Support tagging for STS sessions and tag based access control for the STS APIs
* SimpleNotificationService (3.3.101.92)
	* Added documentation for the dead-letter queue feature.
* SimpleSystemsManagement (3.3.112.0)
	* Add RebootOption and LastNoRebootInstallOperationTime for DescribeInstancePatchStates and DescribeInstancePatchStatesForPatchGroup API
* Core 3.3.103.68
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.636.0 (2019-11-21 22:52 UTC)
* Amplify (3.3.104.0)
	* This release of AWS Amplify Console introduces support for backend environments. Backend environments are containers for AWS deployments. Each environment is a collection of AWS resources.
* AppSync (3.3.103.0)
	* AppSync: AWS AppSync now supports the ability to add, configure, and maintain caching for your AWS AppSync GraphQL API.
* AWSMarketplaceMetering (3.3.101.3)
	* Documentation updates for the AWS Marketplace Metering Service.
* ConfigService (3.3.106.0)
	* AWS Config launches Custom Configuration Items. A new feature which allows customers to publish resource configuration for third-party resources, custom, or on-premises servers.
* Connect (3.3.103.0)
	* This release adds a new API: StartChatContact. You can use it to programmatically start a chat on the specified Amazon Connect instance. Learn more here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html 
* ConnectParticipant (3.3.100.0)
	* This release adds 5 new APIs: CreateParticipantConnection, DisconnectParticipant, GetTranscript, SendEvent, and SendMessage. For Amazon Connect chat, you can use them to programmatically perform participant actions on the configured Amazon Connect instance. Learn more here: https://docs.aws.amazon.com/connect-participant/latest/APIReference/Welcome.html
* DynamoDBv2 (3.3.103.0)
	* With this release, you can convert an existing Amazon DynamoDB table to a global table by adding replicas in other AWS Regions.
* EC2 (3.3.138.0)
	* This release adds support for attaching AWS License Manager Configurations to Amazon Machine Image (AMI) using ImportImage API; and adds support for running different instance sizes on EC2 Dedicated Hosts
* Glue (3.3.112.0)
	* This release adds support for Glue 1.0 compatible ML Transforms.
* Lex (3.3.103.0)
	* Amazon Lex now supports Sentiment Analysis
* LexModelBuildingService (3.3.101.0)
	* Amazon Lex now supports Sentiment Analysis
* SimpleSystemsManagement (3.3.111.0)
	* The release contains new API and API changes for AWS Systems Manager Explorer product.
* TranscribeService (3.3.111.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Hebrew (he-IL), Swiss German (de-CH), Japanese (ja-JP), Turkish (tr-TR), Arabic-Gulf (ar-AE), Malay (ms-MY), Telugu (te-IN)
* Core 3.3.103.67
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.635.0 (2019-11-20 19:24 UTC)
* ApplicationDiscoveryService (3.3.102.0)
	* New exception type for use with Migration Hub home region
* Chime (3.3.105.0)
	* Adds APIs to create and manage meeting session resources for the Amazon Chime SDK
* CloudTrail (3.3.102.0)
	*  1. This release adds two new APIs, GetInsightSelectors and PutInsightSelectors, which let you configure CloudTrail Insights event delivery on a trail. An Insights event is a new type of event that is generated when CloudTrail detects unusual activity in your AWS account. In this release, only "ApiCallRateInsight" is a supported Insights event type. 2. This release also adds the new "ExcludeManagementEventSource" option to the existing PutEventSelectors API. This field currently supports only AWS Key Management Services.
* CodeCommit (3.3.106.0)
	* This release adds support for creating pull request approval rules and pull request approval rule templates in AWS CodeCommit. This allows developers to block merges of pull requests, contingent on the approval rules being satisfiied.
* DataSync (3.3.107.0)
	* Update to configure task to run periodically on a schedule
* DLM (3.3.103.0)
	* DLM now supports Fast Snapshot Restore. You can enable Fast Restore on snapshots created by DLM, provide the AZs and the number of snapshots to be enabled with this capability.
* EC2 (3.3.137.0)
	* This release of Amazon Elastic Compute Cloud (Amazon EC2) introduces support for Amazon Elastic Block Store (Amazon EBS) fast snapshot restores.
* ECS (3.3.111.0)
	* Added support for CPU and memory task-level overrides on the RunTask and StartTask APIs.  Added location information to Tasks.
* FSx (3.3.102.0)
	* Announcing a Multi-AZ deployment type for Amazon FSx for Windows File Server, providing fully-managed Windows file storage with high availability and redundancy across multiple AWS Availability Zones.
* KinesisFirehose (3.3.103.0)
	* With this release, Amazon Kinesis Data Firehose allows server side encryption with customer managed CMKs. Customer managed CMKs ( "Customer Master Keys") are AWS Key Management Service (KMS) keys that are fully managed by the customer. With customer managed CMKs, customers can establish and maintain their key policies, IAM policies, rotating policies and add tags. For more information about AWS KMS and CMKs, please refer to:  https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html. Please refer to the following link to create CMKs: https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-create-cmk.html
* MediaStore (3.3.102.0)
	* This release fixes a broken link in the SDK documentation.
* MigrationHub (3.3.101.0)
	* New exception type for use with Migration Hub home region
* MigrationHubConfig (3.3.100.0)
	* AWS Migration Hub Config Service allows you to get and set the Migration Hub home region for use with AWS Migration Hub and Application Discovery Service
* QuickSight (3.3.102.0)
	* Amazon QuickSight now supports programmatic creation and management of data sources, data sets, dashboards and templates with new APIs. Templates hold dashboard metadata, and can be used to create copies connected to the same or different dataset as required. Also included in this release are APIs for SPICE ingestions, fine-grained access control over AWS resources using AWS Identity and Access Management (IAM) policies, as well AWS tagging. APIs are supported for both Standard and Enterprise Edition, with edition-specific support for specific functionality.
* S3 (3.3.108.0)
	* This release introduces support for Amazon S3 Replication Time Control, a new feature of S3 Replication that provides a predictable replication time backed by a Service Level Agreement. S3 Replication Time Control helps customers meet compliance or business requirements for data replication, and provides visibility into the replication process with new Amazon CloudWatch Metrics.
* StorageGateway (3.3.110.0)
	* The new DescribeAvailabilityMonitorTest API provides the results of the most recent High Availability monitoring test. The new StartAvailabilityMonitorTest API verifies the storage gateway is configured for High Availability monitoring. The new ActiveDirectoryStatus response element has been added to the DescribeSMBSettings and JoinDomain APIs to indicate the status of the gateway after the most recent JoinDomain operation. The new TimeoutInSeconds parameter of the JoinDomain API allows for the configuration of the timeout in which the JoinDomain operation must complete.
* TranscribeService (3.3.110.0)
	* With this release Amazon Transcribe enables alternative transcriptions so that you can see different interpretations of transcribed audio.

### 3.3.634.1 (2019-11-19 22:36 UTC)
* EC2 (3.3.136.1)
	* Updated to use new Core, version 3.3.103.66
	* Updates obsolete IMDS methods to obtain a metadata token that is used with subsequent metadata calls. A potential breaking change exists where exceptions other than WebException may no longer be thrown. Instead null will be returned for consistency between targets.
* Lambda (3.3.104.1)
	* Allow clearing of Lambda Environment variables via UpdateLambdaConfiguration.
* Core 3.3.103.66
	* Fix unmarshalling of JSON arrays that contain forward slashes in names; Updates IMDS to obtain a metadata token that is used with subsequent metadata calls. This also updates IMDS based instance profile credentials to use metadata tokens as part of IMDS calls. A potential breaking change exists where exceptions other than WebException may no longer be thrown. Instead null will be returned for consistency between targets.
	* All services packages updated to require new Core

### 3.3.634.0 (2019-11-19 21:03 UTC)
* AutoScaling (3.3.101.0)
	* Amazon EC2 Auto Scaling now supports Instance Weighting and Max Instance Lifetime. Instance Weighting allows specifying the capacity units for each instance type included in the MixedInstancesPolicy and how they would contribute to your application's performance. Max Instance Lifetime allows specifying the maximum length of time that an instance can be in service. If any instances are approaching this limit, Amazon EC2 Auto Scaling gradually replaces them.
* CloudFormation (3.3.103.0)
	* This release of AWS CloudFormation StackSets enables users to detect drift on a stack set and the stack instances that belong to that stack set.
* CodeBuild (3.3.104.0)
	* Add support for ARM and GPU-enhanced build environments and a new SSD-backed Linux compute type with additional CPU and memory in CodeBuild
* ConfigService (3.3.105.0)
	* AWSConfig launches support for conformance packs. A conformance pack is a new resource type that allows you to package a collection of Config rules and remediation actions into a single entity. You can create and deploy conformance packs into your account or across all accounts in your organization
* EC2 (3.3.136.0)
	* This release adds support for RunInstances to specify the metadata options for new instances; adds a new API, ModifyInstanceMetadataOptions, which lets you modify the metadata options for a running or stopped instance; and adds support for CreateCustomerGateway to specify a device name.
* ElasticLoadBalancingV2 (3.3.103.0)
	* This release allows forward actions on Application Load Balancers to route requests to multiple target groups, based on the weight you specify for each target group.
* IdentityManagement (3.3.104.0)
	* IAM reports the timestamp when a role's credentials were last used to make an AWS request. This helps you identify unused roles and remove them confidently from your AWS accounts.
* IoT (3.3.104.0)
	* As part of this release, we are extending the capability of AWS IoT Rules Engine to send messages directly to customer's own web services/applications. Customers can now create topic rules with HTTP actions to route messages from IoT Core directly to URL's that they own. Ownership is proved by creating and confirming topic rule destinations.
* Lambda (3.3.104.0)
	* This release provides three new runtimes to support Node.js 12 (initially 12.13.0), Python 3.8 and Java 11.  
* Core 3.3.103.65
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.633.0 (2019-11-18 19:17 UTC)
* CloudFormation (3.3.102.0)
	* This release introduces APIs for the CloudFormation Registry, a new service to submit and discover resource providers with which you can manage third-party resources natively in CloudFormation.
* CostExplorer (3.3.105.0)
	* add EstimatedOnDemandCostWithCurrentCommitment to GetSavingsPlansPurchaseRecommendationRequest API
* Pinpoint (3.3.104.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing message templates for messages that are sent through the voice channel. It also introduces support for specifying default values for message variables in message templates. 
* RDS (3.3.112.14)
	* Documentation updates for rds
* S3 (3.3.107.0)
	* Added support for S3 Replication for existing objects. This release allows customers who have requested and been granted access to replicate existing S3 objects across buckets.
* SageMaker (3.3.107.0)
	* Amazon SageMaker now supports multi-model endpoints to host multiple models on an endpoint using a single inference container.
* SimpleSystemsManagement (3.3.110.0)
	* The release contains new API and API changes for AWS Systems Manager Explorer product.

### 3.3.632.0 (2019-11-15 19:38 UTC)
* Chime (3.3.104.0)
	* This release adds support for Chime Room Management APIs
* CloudWatchLogs (3.3.101.48)
	* Documentation updates for logs
* CognitoIdentityProvider (3.3.105.0)
	* This release adds a new option in the User Pool to allow specifying sender's name in the emails sent by Amazon Cognito. This release also adds support to add SES Configuration Set to the emails sent by Amazon Cognito.
* EC2 (3.3.135.0)
	* You can now add tags while copying snapshots. Previously, a user had to first copy the snapshot and then add tags to the copied snapshot manually. Moving forward, you can specify the list of tags you wish to be applied to the copied snapshot as a parameter on the Copy Snapshot API. 
* EKS (3.3.104.0)
	* Introducing Amazon EKS managed node groups, a new feature that lets you easily provision worker nodes for Amazon EKS clusters and keep them up to date using the Amazon EKS management console, CLI, and APIs.
* ElasticLoadBalancingV2 (3.3.102.64)
	* Documentation-only change to the default value of the routing.http.drop_invalid_header_fields.enabled attribute.
* ElasticMapReduce (3.3.103.0)
	* Access to the cluster ARN makes it easier for you to author resource-level permissions policies in AWS Identity and Access Management. To simplify the process of obtaining the cluster ARN, Amazon EMR has added a new field containing the cluster ARN to all API responses that include the cluster ID.
* GuardDuty (3.3.104.0)
	* This release includes new operations related to findings export, including: CreatePublishingDestination, UpdatePublishingDestination, DescribePublishingDestination, DeletePublishingDestination and ListPublishingDestinations.
* MediaConvert (3.3.110.0)
	* AWS Elemental MediaConvert SDK has added support for DolbyVision encoding, and SCTE35 & ESAM insertion to DASH ISO EMSG.
* SimpleSystemsManagement (3.3.109.1)
	* This release updates AWS Systems Manager Parameter Store documentation for the enhanced search capability.
* WorkSpaces (3.3.106.0)
	* Added APIs to register your directories with Amazon WorkSpaces and to modify directory details. 

### 3.3.631.0 (2019-11-14 19:28 UTC)
* AWSMarketplaceMetering (3.3.101.0)
	* Added CustomerNotEntitledException in MeterUsage API for Container use case.
* CognitoIdentityProvider (3.3.104.0)
	* This release adds a new setting at user pool client to prevent user existence related errors during authentication, confirmation, and password recovery related operations. This release also adds support to enable or disable specific authentication flows for a user pool client.
* Connect (3.3.102.0)
	* This release enhances the existing user management APIs and adds 3 new APIs - TagResource, UntagResource, and ListTagsForResource to support tagging Amazon Connect users, which facilitates more granular access controls for Amazon Connect users within an Amazon Connect instance. You can learn more about the new APIs here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html.
* Personalize (3.3.103.0)
	* Amazon Personalize: Adds ability to get batch recommendations by creating a batch inference job.
* SimpleSystemsManagement (3.3.109.0)
	* Updates support for adding attachments to Systems Manager Automation documents
* Core 3.3.103.64
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.630.0 (2019-11-13 21:29 UTC)
* CloudSearch (3.3.101.0)
	* Amazon CloudSearch domains let you require that all traffic to the domain arrive over HTTPS. This security feature helps you block clients that send unencrypted requests to the domain.
* DataExchange (3.3.100.0)
	* Introducing AWS Data Exchange, a service that makes it easy for AWS customers to securely create, manage, access, and exchange data sets in the cloud.
* DLM (3.3.102.0)
	* You can now add tags to a lifecycle policy in Data Lifecycle Manager (DLM). Tags allow you to categorize your policies in different ways, such as by department, purpose or owner. You can also enable resource level permissions based on tags to set access control on ability to modify or delete a tagged policy.
* IoT (3.3.103.0)
	* This release adds the custom fields definition support in the index definition for AWS IoT Fleet Indexing Service. Custom fields can be used as an aggregation field to run aggregations with both existing GetStatistics API and newly added GetCardinality, GetPercentiles APIs. GetStatistics will return all statistics (min/max/sum/avg/count...) with this release. For more information, please refer to our latest documentation: https://docs.aws.amazon.com/iot/latest/developerguide/iot-indexing.html
* SimpleEmailV2 (3.3.100.0)
	* This is the first release of version 2 of the Amazon SES API. You can use this API to configure your Amazon SES account, and to send email. This API extends the functionality that exists in the previous version of the Amazon SES API.
* Core 3.3.103.63
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.629.0 (2019-11-12 21:03 UTC)
* CodePipeline (3.3.104.0)
	* AWS CodePipeline now supports the use of variables in action configuration.
* DynamoDBv2 (3.3.102.0)
	* Amazon DynamoDB enables you to restore your data to a new DynamoDB table using a point-in-time or on-demand backup. You now can modify the settings on the new restored table. Specifically, you can exclude some or all of the local and global secondary indexes from being created with the restored table. In addition, you can change the billing mode and provisioned capacity settings.
* ElasticLoadBalancingV2 (3.3.102.61)
	* You can configure your Application Load Balancer to either drop invalid header fields or forward them to targets.
* MarketplaceCatalog (3.3.100.0)
	* This is the first release for the AWS Marketplace Catalog service which allows you to list, describe and manage change requests on your published entities on AWS Marketplace. 
* TranscribeService (3.3.109.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Welsh English (en-WL), Scottish English(en-AB), Irish English(en-IE), Farsi(fa-IR), Tamil(ta-IN), Indonesian(id-ID), Portuguese (pt-PT), Dutch(nl-NL).

### 3.3.628.0 (2019-11-11 20:27 UTC)
* CloudFormation (3.3.101.0)
	* The Resource Import feature enables customers to import existing AWS resources into new or existing CloudFormation Stacks.
* CostExplorer (3.3.104.0)
	* This launch provides customers with access to GetCostAndUsageWithResources API.

### 3.3.627.0 (2019-11-08 20:24 UTC)
* CognitoIdentity (3.3.101.0)
	* This release adds support for disabling classic flow.
* ECR (3.3.102.7)
	* This release contains ticket fixes for Amazon ECR.
* Core 3.3.103.62
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.626.0 (2019-11-07 20:37 UTC)
* Comprehend (3.3.106.0)
	* This release adds new languages (ar, hi, ko, ja, zh, zh-TW) for Amazon Comprehend's DetectSentiment, DetectEntities, DetectKeyPhrases, BatchDetectSentiment, BatchDetectEntities and BatchDetectKeyPhrases APIs
* SimpleSystemsManagement (3.3.108.0)
	* AWS Systems Manager Session Manager target length increased to 400.
* SSO (3.3.100.0)
	* This is an initial release of AWS Single Sign-On (SSO) end-user access. This release adds support for accessing AWS accounts assigned in AWS SSO using short term credentials.
* SSOOIDC (3.3.100.0)
	* This is an initial release of AWS Single Sign-On OAuth device code authorization service.
* Core 3.3.103.61
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.625.0 (2019-11-06 23:19 UTC)
* SavingsPlans (3.3.101.0)
	* This is the first release of Savings Plans, a new flexible pricing model that offers low prices on Amazon EC2 and AWS Fargate usage.
* Core 3.3.103.60
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.624.0 (2019-11-06 19:59 UTC)
* Budgets (3.3.101.72)
	* Documentation updates for budgets to track Savings Plans utilization and coverage
* CodeBuild (3.3.103.0)
	* Add support for Build Number, Secrets Manager and Exported Environment Variables.
* CostExplorer (3.3.103.0)
	* This launch provides customers with access to Savings Plans management APIs.
* ElasticFileSystem (3.3.103.0)
	* EFS customers can select a lifecycle policy that automatically moves files that have not been accessed for 7 days into the EFS Infrequent Access (EFS IA) storage class. EFS IA provides price/performance that is cost-optimized for files that are not accessed every day.
* SavingsPlans (3.3.100.0)
	* This is the first release of Savings Plans, a new flexible pricing model that offers low prices on Amazon EC2 and AWS Fargate usage.
* Signer (3.3.101.0)
	* This release adds support for tagging code-signing profiles in AWS Signer.

### 3.3.623.0 (2019-11-05 19:14 UTC)
* CodeStarNotifications (3.3.100.0)
	* This release adds a notification manager for events in repositories, build projects, deployments, and pipelines. You can now configure rules and receive notifications about events that occur for resources. Each notification includes a status message as well as a link to the resource (repository, build project, deployment application, or pipeline) whose event generated the notification.
* RDS (3.3.112.8)
	* Documentation updates for Amazon RDS
* Core 3.3.103.59
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.622.0 (2019-11-04 20:38 UTC)
* DAX (3.3.100.94)
	* Documentation updates for dax
* EC2 (3.3.134.5)
	* Documentation updates for ec2
* RoboMaker (3.3.108.0)
	* RoboMaker Fleet Management launch a feature to verify your robot is ready to download and install the new robot application using a download condition file, which is a script run on the robot prior to downloading the new deployment. 

### 3.3.621.0 (2019-11-02 00:12 UTC)
* CloudTrail (3.3.101.0)
	* This release adds two new APIs, GetTrail and ListTrails, and support for adding tags when you create a trail by using a new TagsList parameter on CreateTrail operations.
* DatabaseMigrationService (3.3.103.0)
	* This release contains task timeline attributes in replication task statistics. This release also adds a note to the documentation for the CdcStartPosition task request parameter. This note describes how to enable the use of native CDC start points for a PostgreSQL source by setting the new slotName extra connection attribute on the source endpoint to the name of an existing logical replication slot.
* Pinpoint (3.3.103.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing journeys, and querying analytics data for journeys.

### 3.3.620.0 (2019-10-31 18:12 UTC)
* Amplify (3.3.103.0)
	* This release of AWS Amplify Console introduces support for Web Previews. This feature allows user to create ephemeral branch deployments from pull request submissions made to a connected repository.  A pull-request preview deploys every pull request made to your Git repository to a unique preview URL.
* AWSSupport (3.3.100.93)
	* The status descriptions for TrustedAdvisorCheckRefreshStatus have been updated
* S3 (3.3.106.0)
	* S3 Inventory now supports a new field 'IntelligentTieringAccessTier' that reports the access tier (frequent or infrequent) of objects stored in Intelligent-Tiering storage class.
* Core 3.3.103.58
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.619.0 (2019-10-30 18:38 UTC)
* ElastiCache (3.3.107.0)
	* Amazon ElastiCache for Redis 5.0.5 now allows you to modify authentication tokens by setting and rotating new tokens. You can now modify active tokens while in use, or add brand-new tokens to existing encryption-in-transit enabled clusters that were previously setup without authentication tokens. This is a two-step process that allows you to set and rotate the token without interrupting client requests.
* Core 3.3.103.57
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.618.0 (2019-10-29 19:13 UTC)
* AppStream (3.3.105.0)
	* Adds support for providing domain names that can embed streaming sessions
* Cloud9 (3.3.101.0)
	* Added CREATING and CREATE_FAILED environment lifecycle statuses.  

### 3.3.617.0 (2019-10-28 21:24 UTC)
* S3 (3.3.105.0)
	* Adding support in SelectObjectContent for scanning a portion of an object specified by a scan range.
* Core 3.3.103.56
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.616.0 (2019-10-28 19:23 UTC)
* ECR (3.3.102.0)
	* This release of Amazon Elastic Container Registry Service (Amazon ECR) introduces support for image scanning. This identifies the software vulnerabilities in the container image based on the Common Vulnerabilities and Exposures (CVE) database.
* ElastiCache (3.3.106.0)
	* Amazon ElastiCache adds support for migrating Redis workloads hosted on Amazon EC2 into ElastiCache by syncing the data between the source Redis cluster and target ElastiCache for Redis cluster in real time. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/migrate-to-elasticache.html.
* Transfer (3.3.104.0)
	* This release adds logical directories support to your AWS SFTP server endpoint, so you can now create logical directory structures mapped to Amazon Simple Storage Service (Amazon S3) bucket paths for users created and stored within the service. Amazon S3 bucket names and paths can now be hidden from AWS SFTP users, providing an additional level of privacy to meet security requirements. You can lock down your SFTP users' access to designated folders (commonly referred to as 'chroot'), and simplify complex folder structures for data distribution through SFTP without replicating files across multiple users.
* Core 3.3.103.55
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.615.0 (2019-10-24 18:16 UTC)
* AppMesh (3.3.106.0)
	* This release adds support for the gRPC and HTTP/2 protocols.
* Chime (3.3.103.0)
	* * This release introduces Voice Connector PDX region and defaults previously created Voice Connectors to IAD. You can create Voice Connector Groups and add region specific Voice Connectors to direct telephony traffic across AWS regions in case of regional failures. With this release you can add phone numbers to Voice Connector Groups and can bulk move phone numbers between Voice Connectors, between Voice Connector and Voice Connector Groups and between Voice Connector Groups. Voice Connector now supports additional settings to enable SIP Log capture. This is in addition to the launch of Voice Connector Cloud Watch metrics in this release. This release also supports assigning outbound calling name (CNAM) to AWS account and individual phone numbers assigned to Voice Connectors. * Voice Connector now supports a setting to enable real time audio streaming delivered via Kinesis Audio streams. Please note that recording Amazon Chime Voice Connector calls with this feature maybe be subject to laws or regulations regarding the recording of telephone calls and other electronic communications. AWS Customer and their end users' have the responsibility to comply with all applicable laws regarding the recording, including properly notifying all participants in a recorded session or to a recorded communication that the session or communication is being recorded and obtain their consent.
* EC2 (3.3.134.0)
	* This release updates CreateFpgaImage to support tagging FPGA images on creation
* GameLift (3.3.104.0)
	* Amazon GameLift offers expanded hardware options for game hosting: Custom game builds can use the Amazon Linux 2 operating system, and fleets for both custom builds and Realtime servers can now use C5, M5, and R5 instance types.
* SageMaker (3.3.106.0)
	* Adds support for the new family of Elastic Inference Accelerators (eia2) for SageMaker Hosting and Notebook Services

### 3.3.614.0 (2019-10-23 23:18 UTC)
* Connect (3.3.101.0)
	* This release adds 4 new APIs ListQueues, ListPhoneNumbers, ListContactFlows, and ListHoursOfOperations, which can be used to programmatically list Queues, PhoneNumbers, ContactFlows, and HoursOfOperations configured for an Amazon Connect instance respectively. You can learn more about the new APIs here: https://docs.aws.amazon.com/connect/latest/APIReference/Welcome.html.
* Polly (3.3.103.0)
	* Amazon Polly adds new female voices: US Spanish - Lupe and Brazilian Portuguese - Camila; both voices are available in Standard and Neural engine.
* SecurityToken (3.3.103.3)
	* AWS Security Token Service (STS) now supports a regional configuration flag to make the client respect the region without the need for the endpoint parameter. 
* Core 3.3.103.54
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.613.0 (2019-10-22 19:23 UTC)
* IoTEvents (3.3.102.0)
	* Add support for new serial evaluation method for events in a detector model.
* OpsWorksCM (3.3.102.0)
	* AWS OpsWorks for Chef Automate (OWCA) now allows customers to use a custom domain and respective certificate, for their AWS OpsWorks For Chef Automate servers. Customers can now provide a CustomDomain, CustomCertificate and CustomPrivateKey in CreateServer API to configure their Chef Automate servers with a custom domain and certificate.
* Core 3.3.103.53
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.612.0 (2019-10-18 19:14 UTC)
* CloudWatch (3.3.103.0)
	* New Period parameter added to MetricDataQuery structure.
* Core 3.3.103.52
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.611.0 (2019-10-17 22:55 UTC)
* S3 (3.3.104.39)
	* Fixed headers for SelectObjectContentRequest; Enabling UploadFilesConcurrently for TransferUtilityUploadDirectoryRequest in NetStandard. Removing unnecessary fields from CopyPartRequest.


* SecurityToken (3.3.103.0)
	* Updated to use new Core, version 3.3.103.51
	* Check for STS Regional Flag within environment variable, shared credentials file, and client config for all STS customers
* Core 3.3.103.51
	* Adding me-south-1 region constant.

### 3.3.610.0 (2019-10-17 19:17 UTC)
* Batch (3.3.103.0)
	* Adding support for Compute Environment Allocation Strategies 
* RDS (3.3.112.0)
	* Amazon RDS now supports Amazon RDS on VMware with the introduction of APIs related to Custom Availability Zones and Media installation.
* Core 3.3.103.50
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.609.0 (2019-10-16 18:14 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.102.0)
	* add 2 more values for the supporting sections - age of past due funds + uncollected funds breakdown
* Kafka (3.3.104.0)
	* AWS MSK has added support for adding brokers to a cluster.
* RoboMaker (3.3.107.0)
	* This release adds support for ROS2 Dashing as a beta feature
* Core 3.3.103.49
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.608.0 (2019-10-15 19:46 UTC)
* KinesisVideoArchivedMedia (3.3.102.0)
	* Add ON_DISCONTINUITY mode to the GetHLSStreamingSessionURL API

### 3.3.607.0 (2019-10-14 18:10 UTC)
* Personalize (3.3.102.0)
	* AWS Personalize: Adds ability to create a solution version using FULL or UPDATE training mode
* WorkSpaces (3.3.105.7)
	* Documentation updates for WorkSpaces

### 3.3.606.0 (2019-10-11 19:26 UTC)
* Greengrass (3.3.104.0)
	* Greengrass OTA service supports Raspbian/Armv6l platforms.
* Core 3.3.103.48
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.605.0 (2019-10-10 19:23 UTC)
* EC2 (3.3.133.0)
	* New EC2 M5n, M5dn, R5n, R5dn instances with 100 Gbps network performance and Elastic Fabric Adapter (EFA) for ultra low latency; New A1.metal bare metal instance powered by AWS Graviton Processors
* FMS (3.3.102.0)
	* Firewall Manager now supports Amazon VPC security groups, making it easier to configure and manage security groups across multiple accounts from a single place.
* IoTAnalytics (3.3.104.0)
	* Add `completionTime` to API call ListDatasetContents.
* Lex (3.3.102.0)
	* Amazon Lex now supports Session API checkpoints
* Core 3.3.103.47
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.604.0 (2019-10-09 18:14 UTC)
* ElastiCache (3.3.105.0)
	* Amazon ElastiCache now allows you to apply available service updates on demand to your Memcached and Redis Cache Clusters. Features included: (1) Access to the list of applicable service updates and their priorities. (2) Service update monitoring and regular status updates. (3) Recommended apply-by-dates for scheduling the service updates. (4) Ability to stop and later re-apply updates. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/mem-ug/Self-Service-Updates.html and https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Self-Service-Updates.html
* Kafka (3.3.103.56)
	* Updated documentation for Amazon Managed Streaming for Kafka service.
* MediaConvert (3.3.109.0)
	* AWS Elemental MediaConvert SDK has added support for Dolby Atmos encoding, up to 36 outputs, accelerated transcoding with frame capture and preferred acceleration feature.

### 3.3.603.0 (2019-10-08 19:34 UTC)
* DataSync (3.3.106.0)
	* Add Sync options to enable/disable TaskQueueing
* EventBridge (3.3.100.36)
	* Documentation updates for Amazon EventBridge.
* KinesisFirehose (3.3.102.0)
	* With this release, you can use Amazon Kinesis Firehose delivery streams to deliver streaming data to Amazon Elasticsearch Service version 7.x clusters. For technical documentation, look for CreateDeliveryStream operation in Amazon Kinesis Firehose API reference.
* Organizations (3.3.103.40)
	* Documentation updates for organizations
* Core 3.3.103.46
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.602.0 (2019-10-07 19:39 UTC)
* DirectConnect (3.3.104.0)
	* This release adds a service provider field for physical connection creation and provides a list of available partner providers for each Direct Connect location.
* Glue (3.3.111.0)
	* AWS Glue now provides ability to use custom certificates for JDBC Connections.
* KinesisFirehose (3.3.101.0)
	* Amazon Kinesis Data Firehose now allows delivering data to Elasticsearch clusters set up in a different AWS account than the Firehose AWS account. For technical documentation, look for ElasticsearchDestinationConfiguration in the Amazon Kinesis Firehose API reference.
* Pinpoint (3.3.102.0)
	* This release of the Amazon Pinpoint API introduces support for using and managing message templates.
* PinpointEmail (3.3.104.0)
	* This release of the Amazon Pinpoint Email API introduces support for using and managing message templates.
* Snowball (3.3.101.0)
	* AWS Snowball Edge now allows you to perform an offline update to the software of your Snowball Edge device when your device is not connected to the internet. Previously, updating your Snowball Edge's software required that the device be connected to the internet or be sent back to AWS. Now, you can keep your Snowball Edge software up to date even if your device(s) cannot connect to the internet, or are required to run in an air-gapped environment. To complete offline updates, download the software update from a client machine with connection to the internet using the AWS Command Line Interface (CLI). Then, have the Snowball Edge device download and install the software update using the Snowball Edge device API. For more information about offline updates, visit the Snowball Edge documentation page.

### 3.3.601.0 (2019-10-04 19:22 UTC)
* CognitoIdentityProvider (3.3.103.0)
	* This release adds ClientMetadata input parameter to multiple Cognito User Pools operations, making this parameter available to the customer configured lambda triggers as applicable. 
* MediaPackage (3.3.103.0)
	* New Harvest Job APIs to export segment-accurate content windows from MediaPackage Origin Endpoints to S3. See https://docs.aws.amazon.com/mediapackage/latest/ug/harvest-jobs.html for more info
* SimpleSystemsManagement (3.3.107.2)
	* Documentation updates for Systems Manager / StartSession.

### 3.3.600.0 (2019-10-03 19:11 UTC)
* ApplicationAutoScaling (3.3.101.14)
	* Documentation updates for Application Auto Scaling
* DeviceFarm (3.3.101.60)
	* Documentation updates for devicefarm
* EC2 (3.3.132.0)
	* This release allows customers to purchase regional EC2 RIs on a future date.
* Elasticsearch (3.3.102.0)
	* Amazon Elasticsearch Service now supports configuring additional options for domain endpoint, such as whether to require HTTPS for all traffic.

### 3.3.599.0 (2019-10-02 19:59 UTC)
* Lightsail (3.3.101.0)
	* This release adds support for the automatic snapshots add-on for instances and block storage disks.

### 3.3.598.0 (2019-10-01 18:09 UTC)
* DocDB (3.3.102.0)
	* This release provides support for describe and modify CA certificates.

### 3.3.597.0 (2019-09-30 19:19 UTC)
* MQ (3.3.104.0)
	* Amazon MQ now includes the ability to scale your brokers by changing the host instance type. See the hostInstanceType property of UpdateBrokerInput (https://docs.aws.amazon.com/amazon-mq/latest/api-reference/brokers-broker-id.html#brokers-broker-id-model-updatebrokerinput), and pendingHostInstanceType property of DescribeBrokerOutput (https://docs.aws.amazon.com/amazon-mq/latest/api-reference/brokers-broker-id.html#brokers-broker-id-model-describebrokeroutput).
* RDS (3.3.111.0)
	* This release adds support for creating a Read Replica with Active Directory domain information. This release updates RDS API to indicate whether an OrderableDBInstanceOption supports Kerberos Authentication.
* WAF (3.3.102.0)
	* Lowering the threshold for Rate Based rule from 2000 to 100.
* Core 3.3.103.45
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.596.0 (2019-09-27 19:11 UTC)
* Amplify (3.3.102.0)
	* This release adds access logs APIs and artifact APIs for AWS Amplify Console.
* ECS (3.3.110.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) removes FirelensConfiguration from the DescribeTask output during the FireLens public preview.

### 3.3.595.0 (2019-09-26 18:13 UTC)
* CodePipeline (3.3.103.12)
	* Documentation updates for CodePipeline
* SimpleSystemsManagement (3.3.107.0)
	* This release updates the AWS Systems Manager Parameter Store PutParameter and LabelParameterVersion APIs to return the "Tier" of parameter created/updated and the "parameter version" labeled respectively. 
* Core 3.3.103.44
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.594.0 (2019-09-25 18:23 UTC)
* DatabaseMigrationService (3.3.102.0)
	* This release adds a new DeleteConnection API to delete the connection between a replication instance and an endpoint. It also adds an optional S3 setting to specify the precision of any TIMESTAMP column values written to an S3 object file in .parquet format.
* GlobalAccelerator (3.3.102.0)
	* API Update for AWS Global Accelerator to support for DNS aliasing.
* SageMaker (3.3.105.0)
	* Enable G4D and R5 instances in SageMaker Hosting Services

### 3.3.593.0 (2019-09-24 18:14 UTC)
* ComprehendMedical (3.3.101.0)
	* Use Amazon Comprehend Medical to analyze medical text stored in the specified Amazon S3 bucket. Use the console to create and manage batch analysis jobs, or use the batch APIs to detect both medical entities and protected health information (PHI). The batch APIs start, stop, list, and retrieve information about batch analysis jobs. This release also includes DetectEntitiesV2 operation which returns the Acuity and Direction entities as attributes instead of types.
* DataSync (3.3.105.0)
	* Added S3StorageClass, OverwriteMode sync option, and ONLY_FILES_TRANSFERRED setting for the VerifyMode sync option.
* TranscribeService (3.3.108.0)
	* With this update Amazon Transcribe enables you to provide an AWS KMS key to encrypt your transcription output.

### 3.3.592.0 (2019-09-23 19:08 UTC)
* RDSDataService (3.3.102.0)
	* RDS Data API now supports Amazon Aurora Serverless PostgreSQL databases.
* Redshift (3.3.104.0)
	* Adds API operation DescribeNodeConfigurationOptions and associated data structures.
* Core 3.3.103.43
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.591.0 (2019-09-20 23:11 UTC)
* EC2 (3.3.131.0)
	* G4 instances are Amazon EC2 instances based on NVIDIA T4 GPUs and are designed to provide cost-effective machine learning inference for applications, like image classification, object detection, recommender systems, automated speech recognition, and language translation. G4 instances are also a cost-effective platform for building and running graphics-intensive applications, such as remote graphics workstations, video transcoding, photo-realistic design, and game streaming in the cloud. To get started with G4 instances visit https://aws.amazon.com/ec2/instance-types/g4.
* Greengrass (3.3.103.0)
	* Greengrass OTA service now returns the updated software version in the PlatformSoftwareVersion parameter of a CreateSoftwareUpdateJob response
* RDS (3.3.110.0)
	* Add a new LeaseID output field to DescribeReservedDBInstances, which shows the unique identifier for the lease associated with the reserved DB instance. AWS Support might request the lease ID for an issue related to a reserved DB instance.
* WorkSpaces (3.3.105.0)
	* Adds the WorkSpaces restore feature
* Core 3.3.103.42
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.590.0 (2019-09-19 21:40 UTC)
* ECS (3.3.109.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for container image manifest digests. This enables you to identify all tasks launched using a container image pulled from ECR in order to correlate what was built with where it is running.
* Glue (3.3.110.0)
	* AWS Glue DevEndpoints now supports GlueVersion, enabling you to choose Apache Spark 2.4.3 (in addition to Apache Spark 2.2.1). In addition to supporting the latest version of Spark, you will also have the ability to choose between Python 2 and Python 3.
* MediaConnect (3.3.105.0)
	* When you grant an entitlement, you can now specify the percentage of the entitlement data transfer that you want the subscriber to be responsible for.
* Core 3.3.103.41
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.589.0 (2019-09-18 20:39 UTC)
* APIGateway (3.3.103.0)
	* Amazon API Gateway simplifies accessing PRIVATE APIs by allowing you to associate one or more Amazon Virtual Private Cloud (VPC) Endpoints to a private API. API Gateway will create and manage DNS alias records necessary for easily invoking the private APIs. With this feature, you can leverage private APIs in web applications hosted within your VPCs.
* RAM (3.3.101.0)
	* AWS RAM provides a new ListPendingInvitationResources API action that lists the resources in a resource share that is shared with you but that the invitation is still pending for
* WAFRegional (3.3.102.0)
	* Lowering the threshold for Rate Based rule from 2000 to 100.
* Core 3.3.103.40
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.588.0 (2019-09-17 18:07 UTC)
* Athena (3.3.102.0)
	* This release adds DataManifestLocation field indicating the location and file name of the data manifest file. Users can get a list of files that the Athena query wrote or intended to write from the manifest file.
* IdentityManagement (3.3.103.28)
	* Documentation updates for iam
* Personalize (3.3.101.0)
	* [Personalize] Adds trainingHours to solutionVersion properties.
* Core 3.3.103.39
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.587.0 (2019-09-16 18:10 UTC)
* EKS (3.3.103.0)
	* This release lets customers add tags to an Amazon EKS cluster. These tags can be used to control access to the EKS API for managing the cluster using IAM. The Amazon EKS TagResource API allows customers to associate tags with their cluster. Customers can list tags for a cluster using the ListTagsForResource API and remove tags from a cluster with the UntagResource API. Note: tags are specific to the EKS cluster resource, they do not propagate to other AWS resources used by the cluster.
* MediaConvert (3.3.108.0)
	* AWS Elemental MediaConvert SDK has added support for multi-DRM SPEKE with CMAF outputs, MP3 ingest, and options for improved video quality.
* Core 3.3.103.38
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.586.0 (2019-09-12 19:16 UTC)
* EC2 (3.3.130.0)
	* Fix for FleetActivityStatus and FleetStateCode enum
* ElasticLoadBalancingV2 (3.3.102.36)
	* Documentation updates for elasticloadbalancingv2: This release adds support for TLS SNI on Network Load Balancers 
* MediaLive (3.3.105.0)
	* AWS Elemental MediaLive now supports High Efficiency Video Coding (HEVC) for standard-definition (SD), high-definition (HD), and ultra-high-definition (UHD) encoding with HDR support.Encoding with HEVC offers a number of advantages. While UHD video requires an advanced codec beyond H.264 (AVC), high frame rate (HFR) or High Dynamic Range (HDR) content in HD also benefit from HEVC's advancements. In addition, benefits can be achieved with HD and SD content even if HDR and HFR are not needed.
* WorkMailMessageFlow (3.3.100.0)
	* This release allows customers to access email messages as they flow to and from Amazon WorkMail.
* Core 3.3.103.37
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.585.0 (2019-09-11 19:29 UTC)
* ConfigService (3.3.104.0)
	* Adding input validation for the OrganizationConfigRuleName string.
* EC2 (3.3.129.0)
	* This release adds support for new data fields and log format in VPC flow logs.
* MediaConnect (3.3.104.0)
	* This release adds support for the RIST protocol on sources and outputs.
* RDS (3.3.109.0)
	* This release allows customers to specify a custom parameter group when creating a Read Replica, for DB engines which support this feature.
* SimpleEmail (3.3.101.43)
	* Updated API documentation to correct broken links, and to update content based on customer feedback.
* StepFunctions (3.3.102.0)
	* Fixing letter case in Map history event details to be small case

### 3.3.584.0 (2019-09-10 18:12 UTC)
* StorageGateway (3.3.109.0)
	* The CloudWatchLogGroupARN parameter of the UpdateGatewayInformation API allows for configuring the gateway to use a CloudWatch log-group where Storage Gateway health events will be logged. 

### 3.3.583.0 (2019-09-09 21:38 UTC)
* AppMesh (3.3.105.0)
	* This release adds support for http retry policies.
* AppStream (3.3.104.0)
	* IamRoleArn support in CreateFleet, UpdateFleet, CreateImageBuilder APIs
* AWSMarketplaceCommerceAnalytics (3.3.101.0)
	* Add FDP+FPS (monthly_revenue_field_demonstration_usage + monthly_revenue_flexible_payment_schedule)  to Marketplace Commerce Analytics Service
* EC2 (3.3.128.0)
	* This release expands Site-to-Site VPN tunnel options to allow customers to restrict security algorithms and configure timer settings for VPN connections. Customers can specify these new options while creating new VPN connections, or they can modify the tunnel options on existing connections using a new API.
* QLDB (3.3.100.0)
	* (New Service) Amazon QLDB is a fully managed ledger database that provides a transparent, immutable, and cryptographically verifiable transaction log owned by a central trusted authority. Amazon QLDB is a new class of serverless database that eliminates the need to engage in the complex development effort of building your own ledger-like applications and it automatically scales to support the demands of your application. Introduces Amazon QLDB API operations needed for managing Amazon QLDB ledgers. This includes the ability to manage Amazon QLDB ledgers, cryptographically verify documents, and export the journal in a ledger.
* QLDBSession (3.3.100.0)
	* (New Service) Amazon QLDB is a fully managed ledger database that provides a transparent, immutable, and cryptographically verifiable transaction log owned by a central trusted authority. Amazon QLDB is a new class of serverless database that eliminates the need to engage in the complex development effort of building your own ledger-like applications and it automatically scales to support the demands of your application. Introduces Amazon QLDB API operations needed for interacting with data in Amazon QLDB ledgers.
* RoboMaker (3.3.106.0)
	* Support for Connectivity to Simulation. When you need to interact with the applications in your simulation job, you can connect to your robot application or simulation application with port forwarding. When you configure port forwarding, traffic will be forwarded from the simulation job port to the application port. Port forwarding makes it easy to connect with tools such as ROS Bridge and other tools. This can be useful when you want to debug or run custom tools to interact with your applications. 
* Core 3.3.103.36
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.582.1 (2019-09-06 18:21 UTC)
* KinesisAnalytics (3.3.101.54)
	* Documentation updates for kinesisanalytics
* Core 3.3.103.35
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.582.0 (2019-09-05 18:11 UTC)
* ConfigService (3.3.103.0)
	* AWS Config now includes the option for marking RemediationConfigurations as automatic, removing the need to call the StartRemediationExecution API. Manual control over resource execution rate is also included, and RemediationConfigurations are now ARN addressable. Exceptions to exclude account resources from being remediated can be configured with the new PutRemediationExceptions, DescribeRemediationExceptions, and DeleteRemediationExceptions APIs.
* Core 3.3.103.34
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.581.0 (2019-09-04 18:17 UTC)
* EKS (3.3.102.0)
	* Amazon EKS DescribeCluster API returns a new OIDC issuer field that can be used to create OIDC identity provider for IAM for Service Accounts feature.
* StepFunctions (3.3.101.0)
	* Added support for new history events
* TranscribeService (3.3.107.0)
	* MediaFormat is now optional for StartTranscriptionJob API.
* Core 3.3.103.33
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.580.0 (2019-09-03 19:34 UTC)
* ECS (3.3.108.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for attaching Amazon Elastic Inference accelerators to your containers. This enables you to run deep learning inference workloads with hardware acceleration in a more efficient way.
* GameLift (3.3.103.0)
	* You can now make use of PKI resources to provide more secure connections between your game clients and servers.  To learn more, please refer to the public Amazon GameLift documentation.
* ResourceGroupsTaggingAPI (3.3.102.32)
	* Documentation updates for resourcegroupstaggingapi

### 3.3.579.0 (2019-08-30 18:08 UTC)
* ApiGatewayManagementApi (3.3.101.0)
	* You can use getConnection to return information about the connection (when it is connected, IP address, etc) and deleteConnection to disconnect the given connection
* ECS (3.3.107.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for modifying the cluster settings for existing clusters, which enables you to toggle whether Container Insights is enabled or not. Support is also introduced for custom log routing using the ECS FireLens integration.
* MQ (3.3.103.0)
	* Adds support for updating security groups selection of an Amazon MQ broker.

### 3.3.578.0 (2019-08-29 19:29 UTC)
* ApplicationAutoScaling (3.3.101.0)
	* With the current release, you can suspend and later resume any of the following scaling actions in Application Auto Scaling: scheduled scaling actions, dynamic scaling in actions, dynamic scaling out actions.
* CodePipeline (3.3.103.0)
	* Introducing pipeline execution trigger details in ListPipelineExecutions API.
* ECS (3.3.106.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for including Docker container IDs in the API response when describing and stopping tasks. This enables customers to easily map containers to the tasks they are associated with.
* ElastiCache (3.3.104.0)
	* Amazon ElastiCache for Redis now supports encryption at rest using customer managed customer master keys (CMKs) in AWS Key Management Service (KMS). Amazon ElastiCache now supports cluster names upto 40 characters for replicationGoups and upto 50 characters for cacheClusters.
* Lambda (3.3.103.0)
	* Adds a "MaximumBatchingWindowInSeconds" parameter to event source mapping api's. Usable by Dynamodb and Kinesis event sources.

### 3.3.577.0 (2019-08-28 18:33 UTC)
* GlobalAccelerator (3.3.101.0)
	* API Update for AWS Global Accelerator Client IP Preservation
* MediaConvert (3.3.107.0)
	* This release adds the ability to send a job to an on-demand queue while simulating the performance of a job sent to a reserved queue. Use this setting to estimate the number of reserved transcoding slots (RTS) you need for a reserved queue.
* SQS (3.3.102.0)
	* Added support for message system attributes, which currently lets you send AWS X-Ray trace IDs through Amazon SQS.

### 3.3.576.1 (2019-08-27 18:10 UTC)
* Organizations (3.3.103.26)
	* Documentation updates for organizations
* Core 3.3.103.32
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.576.0 (2019-08-26 18:09 UTC)
* SecurityHub (3.3.104.0)
	* This release resolves an issue with the DescribeHub action, changes the MasterId and InvitationId parameters for AcceptInvitation to Required, and changes the AccountIds parameter for DeleteInvitations and DeclineInvitations to Required.
* SimpleSystemsManagement (3.3.106.0)
	* This feature adds "default tier" to the AWS Systems Manager Parameter Store for parameter creation and update. AWS customers can now set the "default tier" to one of the following values: Standard (default), Advanced or Intelligent-Tiering.  This allows customers to create advanced parameters or parameters in corresponding tiers with one setting rather than code change to specify parameter tiers.

### 3.3.575.0 (2019-08-23 18:12 UTC)
* EC2 (3.3.127.0)
	* This release of EC2 VM Import Export adds support for exporting Amazon Machine Image(AMI)s to a VM file
* MediaPackageVod (3.3.101.0)
	* Adds optional Constant Initialization Vector (IV) to HLS Encryption for MediaPackage VOD.
* TranscribeService (3.3.106.0)
	* Amazon Transcribe - support transcriptions from audio sources in Russian (ru-RU) and Chinese (zh-CN).
* Core 3.3.103.31
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.574.0 (2019-08-22 18:31 UTC)
* DataSync (3.3.104.0)
	* This release adds support for SMB location type.
* RDS (3.3.108.0)
	* This release allows users to enable RDS Data API while creating Aurora Serverless databases. 
* Core 3.3.103.30
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.573.0 (2019-08-21 18:23 UTC)
* ElastiCache (3.3.103.0)
	* ElastiCache extends support for Scale down for Redis Cluster-mode enabled and disabled replication groups 
* ForecastQueryService (3.3.100.0)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* ForecastService (3.3.100.0)
	* Amazon Forecast is a fully managed machine learning service that makes it easy for customers to generate accurate forecasts using their historical time-series data
* PersonalizeRuntime (3.3.101.0)
	* Increased limits on number of items recommended and reranked: The maximum number of results returned from getRecommendations API has been increased to 200. The maximum number of items which can be reranked via getPersonalizedRanking API has been increased to 200.
* Rekognition (3.3.101.5)
	* Documentation updates for Amazon Rekognition.
* SageMaker (3.3.104.0)
	* Amazon SageMaker now supports Amazon EFS and Amazon FSx for Lustre file systems as data sources for training machine learning models. Amazon SageMaker now supports running training jobs on ml.p3dn.24xlarge instance type. This instance type is offered as a limited private preview for certain SageMaker customers. If you are interested in joining the private preview, please reach out to the SageMaker Product Management team via AWS Support."
* SQS (3.3.101.0)
	* This release provides a way to add metadata tags to a queue when it is created. You can use tags to organize and identify your Amazon SQS queues for cost allocation.

### 3.3.572.0 (2019-08-20 18:42 UTC)
* AlexaForBusiness (3.3.106.0)
	* Adding support for optional locale input in CreateProfile and UpdateProfile APIs
* AppStream (3.3.103.0)
	* Includes API updates to support streaming through VPC endpoints for image builders and stacks.
* SageMaker (3.3.103.0)
	* Amazon SageMaker introduces Managed Spot Training. Increases the maximum number of metric definitions to 40 for SageMaker Training and Hyperparameter Tuning Jobs. SageMaker Neo adds support for Acer aiSage and Qualcomm QCS605 and QCS603. 
* Transfer (3.3.103.0)
	* New field in response of TestIdentityProvider

### 3.3.571.0 (2019-08-19 18:08 UTC)
* AppMesh (3.3.104.0)
	* Fix for HttpMethod enum
* CostAndUsageReport (3.3.101.0)
	* New IAM permission required for editing AWS Cost and Usage Reports - Starting today, you can allow or deny IAM users permission to edit Cost & Usage Reports through the API and the Billing and Cost Management console. To allow users to edit Cost & Usage Reports, ensure that they have 'cur: ModifyReportDefinition' permission. Refer to the technical documentation (https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_cur_ModifyReportDefinition.html) for additional details.

### 3.3.570.0 (2019-08-16 19:18 UTC)
* ECS (3.3.105.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for controlling the usage of swap space on a per-container basis for Linux containers.
* ElasticMapReduce (3.3.102.0)
	* Amazon EMR  has introduced an account level configuration called Block Public Access that allows you to block clusters with ports open to traffic from public IP sources (i.e. 0.0.0.0/0 for IPv4 and ::/0 for IPv6) from launching.  Individual ports or port ranges can be added as exceptions to allow public access.
* RoboMaker (3.3.105.0)
	* Two feature release: 1. AWS RoboMaker introduces log-based simulation. Log-based simulation allows you to play back pre-recorded log data such as sensor streams for testing robotic functions like localization, mapping, and object detection. Use the AWS RoboMaker SDK to test your robotic applications.  2.  AWS RoboMaker allow customer to setup a robot deployment timeout when CreateDeploymentJob.
* Core 3.3.103.29
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.569.1 (2019-08-15 21:36 UTC)
* CognitoIdentity (3.3.100.64)
	* Fix call hanging issue in CognitoAWSCredentials
* S3 (3.3.104.16)
	* PR [#1298](https://github.com/aws/aws-sdk-net/pull/1298) Add missing ContentRange property to GetObjectMetadataResponse. Thanks [eangelov](https://github.com/eangelov)
* Core 3.3.103.28
	* PR [#1276](https://github.com/aws/aws-sdk-net/pull/1276) Fixed issue in .NET Framework async calls not handling timeout correctly. Thanks [Daniel Marbach](https://github.com/danielmarbach)
    * PR [#1370](https://github.com/aws/aws-sdk-net/pull/1370) Better error handling when no EC2 instance metadata found. Thanks [Martin Costello](https://github.com/martincostello)
    * PR [#1366](https://github.com/aws/aws-sdk-net/pull/1366) Fixed issue looking for "default" profile in ~/.aws/config file. Thanks [Jesse Mandel](https://github.com/supergibbs)
    * Updated generator to not mark idempotency tokens as required. 
    * Fix call hanging issue in RefreshAWSCredentials impacting CognitoAWSCredentials
	* All services packages updated to require new Core

### 3.3.569.0 (2019-08-15 19:06 UTC)
* AppMesh (3.3.103.0)
	* This release adds support for http header based routing and route prioritization.
* Athena (3.3.101.0)
	* This release adds support for querying S3 Requester Pays buckets. Users can enable this feature through their Workgroup settings.
* CodeCommit (3.3.105.0)
	* This release adds an API, BatchGetCommits, that allows retrieval of metadata for multiple commits in an AWS CodeCommit repository.
* EC2 (3.3.126.0)
	* This release adds an option to use private certificates from AWS Certificate Manager (ACM) to authenticate a Site-to-Site VPN connection's tunnel endpoints and customer gateway device. 
* Glue (3.3.109.0)
	* GetJobBookmarks API is withdrawn.
* StorageGateway (3.3.108.0)
	* CreateSnapshotFromVolumeRecoveryPoint API supports new parameter: Tags (to be attached to the created resource)

### 3.3.568.0 (2019-08-14 18:15 UTC)
* EC2 (3.3.125.0)
	* This release adds a new API called SendDiagnosticInterrupt, which allows you to send diagnostic interrupts to your EC2 instance.
* Core 3.3.103.27
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.567.0 (2019-08-13 19:35 UTC)
* AppSync (3.3.102.0)
	* Adds a configuration option for AppSync GraphQL APIs
* Core 3.3.103.26
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.566.0 (2019-08-12 18:14 UTC)
* ApplicationAutoScaling (3.3.100.61)
	* Documentation updates for Application Auto Scaling
* AutoScaling (3.3.100.62)
	* Amazon EC2 Auto Scaling now supports a new Spot allocation strategy "capacity-optimized" that fulfills your request using Spot Instance pools that are optimally chosen based on the available Spot capacity.
* CloudWatch (3.3.102.16)
	* Documentation updates for monitoring
* Rekognition (3.3.101.0)
	* Adding new Emotion, Fear
* Core 3.3.103.25
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.565.0 (2019-08-09 18:16 UTC)
* GuardDuty (3.3.103.0)
	* New "evidence" field in the finding model to provide evidence information explaining why the finding has been triggered. Currently only threat-intelligence findings have this field. Some documentation updates.
* IoT (3.3.102.0)
	* This release adds Quality of Service (QoS) support for AWS IoT rules engine republish action.
* Lex (3.3.101.0)
	* Manage Amazon Lex session state using APIs on the client
* MediaConvert (3.3.106.0)
	* AWS Elemental MediaConvert has added support for multi-DRM SPEKE with CMAF outputs, MP3 ingest, and options for improved video quality. 
* Redshift (3.3.103.0)
	* Add expectedNextSnapshotScheduleTime and expectedNextSnapshotScheduleTimeStatus to redshift cluster object.
* Core 3.3.103.24
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.564.0 (2019-08-08 19:48 UTC)
* CodeBuild (3.3.102.0)
	* CodeBuild adds CloudFormation support for SourceCredential
* Glue (3.3.108.0)
	* You can now use AWS Glue to find matching records across dataset even without identifiers to join on by using the new FindMatches ML Transform. Find related products, places, suppliers, customers, and more by teaching a custom machine learning transformation that you can use to identify matching matching records as part of your analysis, data cleaning, or master data management project by adding the FindMatches transformation to your Glue ETL Jobs. If your problem is more along the lines of deduplication, you can use the FindMatches in much the same way to identify customers who have signed up more than ones, products that have accidentally been added to your product catalog more than once, and so forth. Using the FindMatches MLTransform, you can teach a Transform your definition of a duplicate through examples, and it will use machine learning to identify other potential duplicates in your dataset. As with data integration, you can then use your new Transform in your deduplication projects by adding the FindMatches transformation to your Glue ETL Jobs. This release also contains additional APIs that support AWS Lake Formation.
* LakeFormation (3.3.100.0)
	* Lake Formation: (New Service) AWS Lake Formation is a fully managed service that makes it easier for customers to build, secure and manage data lakes.  AWS Lake Formation simplifies and automates many of the complex manual steps usually required to create data lakes including collecting, cleaning and cataloging data and securely making that data available for analytics and machine learning.
* OpsWorksCM (3.3.101.0)
	* This release adds support for Chef Automate 2 specific engine attributes.
* Core 3.3.103.23
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.563.1 (2019-08-07 21:49 UTC)
* S3 (3.3.104.10)
	* Updated to use new Core, version 3.3.103.22
	* Fixes issues with encoding of slashes and %2F within resource paths.
* Core 3.3.103.22
	* Fixes issues with encoding of slashes and %2F within resource paths.
	* All services packages updated to require new Core

### 3.3.563.0 (2019-08-07 19:29 UTC)
* ApplicationInsights (3.3.101.0)
	* CloudWatch Application Insights for .NET and SQL Server now provides integration with AWS Systems Manager OpsCenter. This integration allows you to view and resolve problems and operational issues detected for selected applications.
* Core 3.3.103.21
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.562.1 (2019-08-06 18:08 UTC)
* Batch (3.3.102.5)
	* Documentation updates for AWS Batch

### 3.3.562.0 (2019-08-05 18:08 UTC)
* DataSync (3.3.103.0)
	* Support VPC endpoints.
* EC2 (3.3.124.0)
	* Amazon EC2 now supports a new Spot allocation strategy "Capacity-optimized" that fulfills your request using Spot Instance pools that are optimally chosen based on the available Spot capacity.
* IoT (3.3.101.0)
	* In this release, AWS IoT Device Defender introduces audit mitigation actions that can be applied to audit findings to help mitigate security issues.

### 3.3.561.2 (2019-08-02 18:51 UTC)
* SecurityToken (3.3.102.5)
	* Documentation updates for sts
* Core 3.3.103.20
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.561.1 (2019-08-01 21:25 UTC)
* Core 3.3.103.19
	* Allow "Assume Role" profiles to reference other "Assume Role" profiles as their source
	* All services packages updated to require new Core

### 3.3.561.0 (2019-07-30 18:10 UTC)
* MediaConvert (3.3.105.0)
	* MediaConvert adds support for specifying priority (-50 to 50) on jobs submitted to on demand or reserved queues
* Polly (3.3.102.0)
	* Amazon Polly adds support for Neural text-to-speech engine.
* Route53 (3.3.102.0)
	* Amazon Route 53 now supports the Middle East (Bahrain) Region (me-south-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Core 3.3.103.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.560.0 (2019-07-29 18:12 UTC)
* CodeCommit (3.3.104.0)
	* This release supports better exception handling for merges.
* Core 3.3.103.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.559.0 (2019-07-26 18:23 UTC)
* Batch (3.3.102.0)
	* AWS Batch now supports SDK auto-pagination and Job-level docker devices.
* CloudWatchLogs (3.3.101.0)
	* Allow for specifying multiple log groups in an Insights query, and deprecate storedByte field for LogStreams and interleaved field for FilterLogEventsRequest.
* CostExplorer (3.3.102.0)
	* Adds support for resource optimization recommendations.
* EC2 (3.3.123.0)
	* You can now create EC2 Capacity Reservations using Availability Zone ID or Availability Zone name. You can view usage of Amazon EC2 Capacity Reservations per AWS account.
* Glue (3.3.107.0)
	* This release provides GetJobBookmark and GetJobBookmarks APIs. These APIs enable users to look at specific versions or all versions of the JobBookmark for a specific job. This release also enables resetting the job bookmark to a specific run via an enhancement of the ResetJobBookmark API.
* Greengrass (3.3.102.0)
	* Greengrass OTA service supports openwrt/aarch64 and openwrt/armv7l platforms.
* MediaConnect (3.3.103.0)
	* This release adds support for the Zixi pull protocol on outputs.

### 3.3.558.0 (2019-07-25 18:10 UTC)
* ECR (3.3.101.0)
	* This release adds support for immutable image tags.
* MediaConvert (3.3.104.0)
	* AWS Elemental MediaConvert has added several features including support for: audio normalization using ITU BS.1770-3, 1770-4 algorithms, extension of job progress indicators, input cropping rectangle & output position rectangle filters per input, and dual SCC caption mapping to additional codecs and containers. 
* MediaLive (3.3.104.0)
	* AWS Elemental MediaLive is adding Input Clipping, Immediate Mode Input Switching, and Dynamic Inputs.
* Core 3.3.103.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.557.0 (2019-07-24 18:19 UTC)
* EC2 (3.3.122.0)
	* This release introduces support for split tunnel with AWS Client VPN, and also adds support for opt-in Regions in DescribeRegions API. In addition, customers can now also tag Launch Templates on creation.
* Glue (3.3.106.0)
	* This release provides GlueVersion option for Job APIs and WorkerType option for DevEndpoint APIs. Job APIs enable users to pick specific GlueVersion for a specific job and pin the job to a specific runtime environment. DevEndpoint APIs enable users to pick different WorkerType for memory intensive workload.
* Pinpoint (3.3.101.0)
	* This release adds support for programmatic access to many of the same campaign metrics that are displayed on the Amazon Pinpoint console. You can now use the Amazon Pinpoint API to monitor and assess performance data for campaigns, and integrate metrics data with other reporting tools. We update the metrics data continuously, resulting in a data latency timeframe that is limited to approximately two hours.
* SecurityToken (3.3.102.0)
	* New STS GetAccessKeyInfo API operation that returns the account identifier for the specified access key ID.
* Core 3.3.103.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.556.0 (2019-07-23 19:44 UTC)
* SecretsManager (3.3.101.0)
	* This release increases the maximum allowed size of SecretString or SecretBinary from 7KB to 10KB in the CreateSecret, UpdateSecret, PutSecretValue and GetSecretValue APIs. This release also increases the maximum allowed size of ResourcePolicy from 4KB to 20KB in the GetResourcePolicy and PutResourcePolicy APIs.
* SimpleSystemsManagement (3.3.105.0)
	* You can now use Maintenance Windows to select a resource group as the target. By selecting a resource group as the target of a Maintenance Window, customers can perform routine tasks across different resources such as Amazon Elastic Compute Cloud (AmazonEC2) instances, Amazon Elastic Block Store (Amazon EBS) volumes, and Amazon Simple Storage Service(Amazon S3) buckets within the same recurring time window.

### 3.3.555.0 (2019-07-22 19:41 UTC)
* MQ (3.3.102.0)
	* Adds support for AWS Key Management Service (KMS) to offer server-side encryption. You can now select your own customer managed CMK, or use an AWS managed CMK in your KMS  account.
* Shield (3.3.101.0)
	* Adding new VectorType (HTTP_Reflection) and related top contributor types to describe WordPress Pingback DDoS attacks.
* Core 3.3.103.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.554.0 (2019-07-19 19:12 UTC)
* IoTEvents (3.3.101.0)
	* Adds support for IoT Events, Lambda, SQS and Kinesis Firehose actions.
* SQS (3.3.100.49)
	* This release updates the information about the availability of FIFO queues and includes miscellaneous fixes.
* Core 3.3.103.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.553.0 (2019-07-19 01:05 UTC)
* EC2 (3.3.121.5)
	* Fixing serialization of the Ipv6Addresses and PrivateIpAddresses fields in RequestSpotFleetRequest, RequestSpotInstancesRequest and RunInstancesRequestMarshaller
* S3 (3.3.104.0)
	* Updated to use new Core, version 3.3.103.12
	* Adding an HTTPS-capable variant of DoesS3BucketExist; Preventing overflow exception when using S3 SelectObjectContent on PCL platforms
* Core 3.3.103.12
	* Fix for concurrency errors in region endpoints indicating that a duplicate key has been added; Adding a utility method allowing to check if value-type properties are set; Added region ap-east-1 Asia Pacific (Hong Kong)
	* All services packages updated to require new Core

### 3.3.552.0 (2019-07-18 20:29 UTC)
* CodeDeploy (3.3.101.24)
	* Documentation updates for codedeploy
* Comprehend (3.3.105.0)
	* Amazon Comprehend now supports multiple entities for custom entity recognition
* ECS (3.3.104.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for cluster settings. Cluster settings specify whether CloudWatch Container Insights is enabled or disabled for the cluster.
* ElastiCache (3.3.102.16)
	* Updates for Elasticache

### 3.3.551.0 (2019-07-17 19:17 UTC)
* AutoScaling (3.3.100.48)
	* Documentation updates for autoscaling
* ConfigService (3.3.102.0)
	* This release adds more granularity to the status of an OrganizationConfigRule by adding a new status. It also adds an exception when organization access is denied.
* DatabaseMigrationService (3.3.101.0)
	* S3 endpoint settings update: 1) Option to append operation column to full-load files. 2) Option to add a commit timestamp column to full-load and cdc files. Updated DescribeAccountAttributes to include UniqueAccountIdentifier.

### 3.3.550.0 (2019-07-12 18:07 UTC)
* ApiGatewayV2 (3.3.103.0)
	* Bug fix (Add tags field to Update Stage , Api and DomainName Responses )
* Elasticsearch (3.3.101.0)
	* Amazon Elasticsearch Service now supports M5, C5, and R5 instance types.
* IdentityManagement (3.3.103.0)
	* Removed exception that was indicated but never thrown for IAM GetAccessKeyLastUsed API
* RoboMaker (3.3.104.0)
	* Added Melodic as a supported Robot Software Suite Version
* Core 3.3.103.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.549.0 (2019-07-11 15:06 UTC)
* CloudWatchEvents (3.3.101.0)
	* Adds APIs for partner event sources, partner event buses, and custom event buses. These new features are managed in the EventBridge service.
* EventBridge (3.3.100.0)
	* Amazon EventBridge is a serverless event bus service that makes it easy to connect your applications with data from a variety of sources, including AWS services, partner applications, and your own applications.

### 3.3.548.0 (2019-07-10 18:29 UTC)
* Glacier (3.3.100.46)
	* Documentation updates for glacier
* QuickSight (3.3.101.0)
	* Amazon QuickSight now supports embedding dashboards for all non-federated QuickSight users. This includes IAM users, AD users and users from the QuickSight user pool. The get-dashboard-embed-url API accepts QUICKSIGHT as identity type with a user ARN to authenticate the embeddable dashboard viewer as a non-federated user.
* ServiceCatalog (3.3.108.0)
	* This release adds support for Parameters in ExecuteProvisionedProductServiceAction and adds functionality to get the default parameter values for a Self-Service Action execution against a Provisioned Product via DescribeServiceActionExecutionParameters
* Core 3.3.103.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.547.0 (2019-07-09 18:24 UTC)
* Amplify (3.3.101.0)
	* This release adds webhook APIs and manual deployment APIs for AWS Amplify Console.
* CloudWatch (3.3.102.0)
	* This release adds three new APIs (PutAnomalyDetector, DeleteAnomalyDetector, and DescribeAnomalyDetectors) to support the new feature, CloudWatch Anomaly Detection. In addition, PutMetricAlarm and DescribeAlarms APIs are updated to support management of Anomaly Detection based alarms.
* ConfigService (3.3.101.0)
	* AWS Config now supports a new set of APIs to manage AWS Config rules across your organization in AWS Organizations. Using this capability, you can centrally create, update, and delete AWS Config rules across all accounts in your organization. This capability is particularly useful if you have a need to deploy a common set of AWS Config rules across all accounts. You can also specify accounts where AWS Config rules should not be created. In addition, you can use these APIs from the master account in AWS Organizations to enforce governance by ensuring that the underlying AWS Config rules are not modifiable by your organization member accounts.These APIs work for both managed and custom AWS Config rules. For more information, see Enabling AWS Config Rules Across all Accounts in Your Organization in the AWS Config Developer Guide.The new APIs are available in all commercial AWS Regions where AWS Config and AWS Organizations are supported. For the full list of supported Regions, see AWS Regions and Endpoints in the AWS General Reference. To learn more about AWS Config, visit the AWS Config webpage. To learn more about AWS Organizations, visit the AWS Organizations webpage.
* ElasticFileSystem (3.3.102.0)
	* EFS customers can now enable Lifecycle Management for all file systems. You can also now select from one of four Lifecycle Management policies (14, 30, 60 and 90 days), to automatically move files that have not been accessed for the period of time defined by the policy, from the EFS Standard storage class to the EFS Infrequent Access (IA) storage class. EFS IA provides price/performance that is cost-optimized for files that are not accessed every day.
* GameLift (3.3.102.0)
	* GameLift FlexMatch now supports matchmaking of up to 200 players per game session, and FlexMatch can now automatically backfill your game sessions whenever there is an open slot.
* KinesisVideo (3.3.101.0)
	* Add "GET_DASH_STREAMING_SESSION_URL" as an API name to the GetDataEndpoint API.
* KinesisVideoArchivedMedia (3.3.101.0)
	* Adds support for the GetDASHStreamingSessionURL API. Also adds support for the Live Replay playback mode of the GetHLSStreamingSessionURL API.
* WAF (3.3.101.0)
	* Updated SDK APIs to add tags to WAF Resources: WebACL, Rule, Rulegroup and RateBasedRule. Tags can also be added during creation of these resources.
* WAFRegional (3.3.101.0)
	* Updated SDK APIs to add tags to WAF Resources: WebACL, Rule, Rulegroup and RateBasedRule. Tags can also be added during creation of these resources.
* Core 3.3.103.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.546.0 (2019-07-08 19:22 UTC)
* CostExplorer (3.3.101.0)
	* This release introduces a new operation called GetUsageForecast, which allows you to programmatically access AWS Cost Explorer's forecasting engine on usage data (running hours, data transfer, etc).
* Core 3.3.103.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.545.0 (2019-07-03 19:47 UTC)
* EC2 (3.3.121.0)
	* AssignPrivateIpAddresses response includes two new fields: AssignedPrivateIpAddresses, NetworkInterfaceId
* RDS (3.3.107.0)
	* This release supports Cross-Account Cloning for Amazon Aurora clusters.
* S3 (3.3.103.0)
	* Add S3 x-amz-server-side-encryption-context support.
* SimpleWorkflow (3.3.101.0)
	* This release adds APIs that allow adding and removing tags to a SWF domain, and viewing tags for a domain. It also enables adding tags when creating a domain.

### 3.3.544.0 (2019-07-02 19:33 UTC)
* AppStream (3.3.102.10)
	* Adding ImageBuilderName in Fleet API and Documentation updates for AppStream. 
* MediaStore (3.3.101.0)
	* This release adds support for tagging, untagging, and listing tags for AWS Elemental MediaStore containers.
* Core 3.3.103.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.543.0 (2019-07-01 18:27 UTC)
* DocDB (3.3.101.0)
	* This release provides support for cluster delete protection and the ability to stop and start clusters.
* EC2 (3.3.120.0)
	* This release adds support for specifying a maximum hourly price for all On-Demand and Spot instances in both Spot Fleet and EC2 Fleet.
* Organizations (3.3.103.0)
	* Specifying the tag key and tag value is required for tagging requests.
* RDS (3.3.106.0)
	* This release adds support for RDS DB Cluster major version upgrade 
* Core 3.3.103.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.542.0 (2019-06-28 18:43 UTC)
* AlexaForBusiness (3.3.105.0)
	* This release allows developers and customers to add SIP addresses and international phone numbers to contacts.
* EC2 (3.3.119.0)
	* You can now launch 8xlarge and 16xlarge instance sizes on the general purpose M5 and memory optimized R5 instance types.
* Redshift (3.3.102.0)
	* ClusterAvailabilityStatus: The availability status of the cluster for queries. Possible values are the following: Available, Unavailable, Maintenance, Modifying, Failed.
* WorkSpaces (3.3.104.0)
	* Minor API fixes for WorkSpaces.
* Core 3.3.103.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.541.0 (2019-06-27 18:14 UTC)
* DirectConnect (3.3.103.0)
	* Tags will now be included in the API responses of all supported resources (Virtual interfaces, Connections, Interconnects and LAGs). You can also add tags while creating these resources.
* EC2InstanceConnect (3.3.100.0)
	* Amazon EC2 Instance Connect is a simple and secure way to connect to your instances using Secure Shell (SSH). With EC2 Instance Connect, you can control SSH access to your instances using AWS Identity and Access Management (IAM) policies as well as audit connection requests with AWS CloudTrail events. In addition, you can leverage your existing SSH keys or further enhance your security posture by generating one-time use SSH keys each time an authorized user connects.
* Pinpoint (3.3.100.40)
	* This release includes editorial updates for the Amazon Pinpoint API documentation.
* WorkSpaces (3.3.103.0)
	* Added support for the WorkSpaces restore feature and copying WorkSpaces Images across AWS Regions.
* Core 3.3.103.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.540.1 (2019-06-27 00:22 UTC)
* DynamoDBv2 (3.3.101.30)
	* Documentation updates for dynamodb
* Core 3.3.103.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.540.0 (2019-06-26 19:13 UTC)
* ApiGatewayV2 (3.3.102.0)
	* You can now perform tag operations on ApiGatewayV2 Resources (typically associated with WebSocket APIs)
* CodeCommit (3.3.103.0)
	* This release supports better exception handling for merges.
* Core 3.3.103.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.539.0 (2019-06-25 18:51 UTC)
* EC2 (3.3.118.0)
	* Starting today, you can use Traffic Mirroring  to copy network traffic from an elastic network interface of Amazon EC2 instances and then send it to out-of-band security and monitoring appliances for content inspection, threat monitoring, and troubleshooting. These appliances can be deployed as individual instances, or as a fleet of instances behind a Network Load Balancer with a User Datagram Protocol (UDP) listener. Traffic Mirroring supports filters and packet truncation, so that you only extract the traffic of interest to monitor by using monitoring tools of your choice.
* EKS (3.3.101.35)
	* Changing Amazon EKS full service name to Amazon Elastic Kubernetes Service.

### 3.3.538.0 (2019-06-24 18:18 UTC)
* APIGateway (3.3.102.0)
	* Customers can pick different security policies (TLS version + cipher suite) for custom domains in API Gateway
* ApiGatewayV2 (3.3.101.0)
	* Customers can get information about security policies set on custom domain resources in API Gateway
* ApplicationInsights (3.3.100.0)
	* CloudWatch Application Insights detects errors and exceptions from logs, including .NET custom application logs, SQL Server logs, IIS logs, and more, and uses a combination of built-in rules and machine learning, such as dynamic baselining, to identify common problems. You can then easily drill into specific issues with CloudWatch Automatic Dashboards that are dynamically generated. These dashboards contain the most recent alarms, a summary of relevant metrics, and log snippets to help you identify root cause.
* ElasticLoadBalancingV2 (3.3.102.0)
	* This release adds support for UDP on Network Load Balancers
* FSx (3.3.101.0)
	* Starting today, you can join your Amazon FSx for Windows File Server file systems to your organization's self-managed Microsoft Active Directory while creating the file system. You can also perform in-place updates of file systems to keep your Active Directory configuration up to date.
* ResourceGroupsTaggingAPI (3.3.102.0)
	* Updated service APIs and documentation.
* SecurityHub (3.3.103.0)
	* This release includes a new Tags parameter for the EnableSecurityHub operation, and the following new operations: DescribeHub, CreateActionTarget, DeleteActionTarget, DescribeActionTargets, UpdateActionTarget, TagResource, UntagResource, and ListTagsforResource. It removes the operation ListProductSubscribers, and makes Title and Description required attributes of AwsSecurityFinding.
* ServiceQuotas (3.3.100.0)
	* Service Quotas enables you to view and manage your quotas for AWS services from a central location.
* SimpleSystemsManagement (3.3.104.0)
	* AWS Systems Manager now supports deleting a specific version of a SSM Document.
* Core 3.3.103.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.537.0 (2019-06-21 19:40 UTC)
* DeviceFarm (3.3.101.14)
	* This release includes updated documentation about the default timeout value for test runs and remote access sessions. This release also includes miscellaneous bug fixes for the documentation.
* IdentityManagement (3.3.102.0)
	* We are making it easier for you to manage your permission guardrails i.e. service control policies by enabling you to retrieve the last timestamp when an AWS service was accessed within an account or AWS Organizations entity.
* KinesisVideoMedia (3.3.100.37)
	* Documentation updates for Amazon Kinesis Video Streams.
* MediaPackage (3.3.102.0)
	* Added two new origin endpoint fields for configuring which SCTE-35 messages are treated as advertisements.

### 3.3.536.0 (2019-06-20 22:29 UTC)
* Core 3.3.103.0
	* Added support for the credential_process credential provider; Added host name support for Client Side Metrics.
	* All services packages updated to require new Core

### 3.3.535.0 (2019-06-20 18:11 UTC)
* ACMPCA (3.3.101.0)
	* ACM Private CA is launching Root CAs and hierarchy management, a new feature that expands the scope of ACM Private CA from supporting only subordinate issuing CAs, to now include a full CA hierarchy that includes root CAs - the cryptographic root of trust for an organization.
* AWSHealth (3.3.101.0)
	* API improvements for the AWS Health service.
* Glue (3.3.105.0)
	* Starting today, you can now use workflows in AWS Glue to author directed acyclic graphs (DAGs) of Glue triggers, crawlers and jobs. Workflows enable orchestration of your ETL workloads by building dependencies between Glue entities (triggers, crawlers and jobs).  You can visually track status of the different nodes in the workflows on the console making it easier to monitor progress and troubleshoot issues. Also, you can share parameters across entities in the workflow.
* IoTEventsData (3.3.101.0)
	* "The colon character ':' is now permitted in Detector Model 'key' parameter values.
* OpsWorks (3.3.100.35)
	* Documentation updates for OpsWorks Stacks.
* RDS (3.3.105.0)
	* This release adds support for RDS storage autoscaling
* Core 3.3.102.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.534.1 (2019-06-19 20:40 UTC)
* EKS (3.3.101.31)
	* Changing Amazon EKS full service name to Amazon Elastic Kubernetes Service.

### 3.3.534.0 (2019-06-18 18:12 UTC)
* EC2 (3.3.117.0)
	* You can now launch new 12xlarge, 24xlarge, and metal instance sizes on the Amazon EC2 compute optimized C5 instance types featuring 2nd Gen Intel Xeon Scalable Processors.
* ResourceGroupsTaggingAPI (3.3.101.0)
	* You can use tag policies to help standardize on tags across your organization's resources.

### 3.3.533.0 (2019-06-17 19:09 UTC)
* Neptune (3.3.101.0)
	* This release adds a feature to configure Amazon Neptune to publish audit logs to Amazon CloudWatch Logs.
* RoboMaker (3.3.103.0)
	* Add the ServiceUnavailableException (503) into CreateSimulationJob API.
* ServiceCatalog (3.3.107.0)
	* Restrict concurrent calls by a single customer account for CreatePortfolioShare and DeletePortfolioShare when sharing/unsharing to an Organization.
* Core 3.3.102.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.532.0 (2019-06-14 18:12 UTC)
* AppStream (3.3.102.0)
	* Added 2 new values(WINDOWS_SERVER_2016, WINDOWS_SERVER_2019) for PlatformType enum.
* CloudFront (3.3.101.0)
	* A new datatype in the CloudFront API, AliasICPRecordal, provides the ICP recordal status for CNAMEs associated with distributions. AWS services in China customers must file for an Internet Content Provider (ICP) recordal if they want to serve content publicly on an alternate domain name, also known as a CNAME, that they have added to CloudFront. The status value is returned in the CloudFront response; you cannot configure it yourself. The status is set to APPROVED for all CNAMEs (aliases) in regions outside of China.
* EC2 (3.3.116.0)
	* Correction to enumerations in EC2 client.
* Personalize (3.3.100.2)
	* Documentation updates for Amazon Personalize.
* Core 3.3.102.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.531.0 (2019-06-13 19:22 UTC)
* AppMesh (3.3.102.0)
	* This release adds support for AWS Cloud Map as a service discovery method for virtual nodes.
* EC2 (3.3.115.0)
	* G4 instances are Amazon EC2 instances based on NVIDIA T4 GPUs and are designed to provide cost-effective machine learning inference for applications, like image classification, object detection, recommender systems, automated speech recognition, and language translation. G4 instances are also a cost-effective platform for building and running graphics-intensive applications, such as remote graphics workstations, video transcoding, photo-realistic design, and game streaming in the cloud. To get started with G4 instances visit https://aws.amazon.com/ec2/instance-types/g4.
* ElastiCache (3.3.102.0)
	* This release is to add support for reader endpoint for cluster-mode disabled Amazon ElastiCache for Redis clusters.
* GuardDuty (3.3.102.0)
	* Support for tagging functionality in Create and Get operations for Detector, IP Set, Threat Intel Set, and Finding Filter resources and 3 new tagging APIs: ListTagsForResource, TagResource, and UntagResource.

### 3.3.530.1 (2019-06-12 23:23 UTC)
* Core 3.3.102.4
	* Fixed issue with AssumeRoleAWSCredentials not refreshing credentials before they expire.
	* All services packages updated to require new Core

### 3.3.530.0 (2019-06-12 18:09 UTC)
* ServiceCatalog (3.3.106.0)
	* This release adds a new field named Guidance to update provisioning artifact, this field can be set by the administrator to provide guidance to end users about which provisioning artifacts to use.

### 3.3.529.0 (2019-06-11 18:32 UTC)
* SageMaker (3.3.102.0)
	* The default TaskTimeLimitInSeconds of labeling job is increased to 8 hours. Batch Transform introduces a new DataProcessing field which supports input and output filtering and data joining. Training job increases the max allowed input channels from 8 to 20.

### 3.3.528.0 (2019-06-10 18:10 UTC)
* CodeBuild (3.3.101.0)
	* AWS CodeBuild adds support for source version on project level.
* CodeCommit (3.3.102.0)
	* This release adds two merge strategies for merging pull requests: squash and three-way. It also adds functionality for resolving merge conflicts, testing merge outcomes, and for merging branches using one of the three supported merge strategies.
* Personalize (3.3.100.0)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* PersonalizeEvents (3.3.100.0)
	* Introducing Amazon Personalize  - a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.
* PersonalizeRuntime (3.3.100.0)
	* Amazon Personalize is a machine learning service that makes it easy for developers to create individualized recommendations for customers using their applications.

### 3.3.527.0 (2019-06-07 18:09 UTC)
* EC2 (3.3.114.0)
	* Adds DNS entries and NLB ARNs to describe-vpc-endpoint-connections API response. Adds owner ID to describe-vpc-endpoints and create-vpc-endpoint API responses.
* Core 3.3.102.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.526.0 (2019-06-06 18:47 UTC)
* CloudWatchLogs (3.3.100.31)
	* Documentation updates for logs
* DynamoDBv2 (3.3.101.21)
	* Documentation updates for dynamodb
* ECS (3.3.103.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for launching container instances using supported Amazon EC2 instance types that have increased elastic network interface density. Using these instance types and opting in to the awsvpcTrunking account setting provides increased elastic network interface (ENI) density on newly launched container instances which allows you to place more tasks on each container instance.
* GuardDuty (3.3.101.0)
	* Improve FindingCriteria Condition field names, support long-typed conditions and deprecate old Condition field names.
* MediaConnect (3.3.102.0)
	* This release adds support for encrypting entitlements using Secure Packager and Encoder Key Exchange (SPEKE).
* Organizations (3.3.102.0)
	* You can tag and untag accounts in your organization and view tags on an account in your organization.
* SimpleEmail (3.3.101.0)
	* You can now specify whether the Amazon Simple Email Service must deliver email over a connection that is encrypted using Transport Layer Security (TLS).
* SimpleSystemsManagement (3.3.103.0)
	* OpsCenter is a new Systems Manager capability that allows you to view, diagnose, and remediate, operational issues, aka OpsItems, related to various AWS resources by bringing together contextually relevant investigation information. New APIs to create, update, describe, and get OpsItems as well as OpsItems summary API. 

### 3.3.525.0 (2019-06-05 19:17 UTC)
* Glue (3.3.104.0)
	* Support specifying python version for Python shell jobs. A new parameter PythonVersion is added to the JobCommand data type.

### 3.3.524.0 (2019-06-04 18:09 UTC)
* EC2 (3.3.113.0)
	* This release adds support for Host Recovery feature which automatically restarts instances on to a new replacement host if failures are detected on Dedicated Host.
* ElastiCache (3.3.101.0)
	* Amazon ElastiCache now allows you to apply available service updates on demand. Features included: (1) Access to the list of applicable service updates and their priorities. (2) Service update monitoring and regular status updates. (3) Recommended apply-by-dates for scheduling the service updates, which is critical if your cluster is in ElastiCache-supported compliance programs. (4) Ability to stop and later re-apply updates. For more information, see https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/Self-Service-Updates.html
* IdentityManagement (3.3.101.20)
	* This release adds validation for policy path field. This field is now restricted to be max 512 characters.
* S3 (3.3.102.11)
	* Documentation updates for s3
* StorageGateway (3.3.107.0)
	* AWS Storage Gateway now supports AWS PrivateLink, enabling you to administer and use gateways without needing to use public IP addresses or a NAT/Internet Gateway, while avoiding traffic from going over the internet.
* Core 3.3.102.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.523.0 (2019-06-03 18:17 UTC)
* EC2 (3.3.112.0)
	* Amazon EC2 I3en instances are the new storage-optimized instances offering up to 60 TB NVMe SSD instance storage and up to 100 Gbps of network bandwidth.
* RDS (3.3.104.2)
	* Amazon RDS Data API is generally available. Removing beta notes in the documentation.
* Core 3.3.102.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.522.0 (2019-05-30 23:05 UTC)
* Core 3.3.102.0
	* Closing response object during SAML authentication in .NET Framework 3.5.
Updating the documentation for the async operations.
Handling anonymous credentials in endpoint discovery handler.
Added support for unbounded streams when using services that support chunked transfer encoding.
	* All services packages updated to require new Core

### 3.3.521.0 (2019-05-30 20:01 UTC)
* CodeCommit (3.3.101.0)
	* This release adds APIs that allow adding and removing tags to a repository, and viewing tags for a repository. It also enables adding tags when creating a repository.
* IoTAnalytics (3.3.103.0)
	* IoT Analytics adds the option to use your own S3 bucket to store channel and data store resources. Previously, only service-managed storage was used.
* IoTEvents (3.3.100.0)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* IoTEventsData (3.3.100.0)
	* The AWS IoT Events service allows customers to monitor their IoT devices and sensors to detect failures or changes in operation and to trigger actions when these events occur
* Kafka (3.3.103.0)
	* Updated APIs for Amazon MSK to enable new features such as encryption in transit, client authentication, and scaling storage.
* PinpointEmail (3.3.103.0)
	* You can now specify whether the Amazon Pinpoint Email service must deliver email over a connection that is encrypted using Transport Layer Security (TLS).
* RDS (3.3.104.0)
	* This release adds support for Activity Streams for database clusters.
* RDSDataService (3.3.101.0)
	* The RDS Data API is generally available for the MySQL-compatible edition of Amazon Aurora Serverless in the US East (N. Virginia and Ohio), US West (Oregon), EU (Ireland), and Asia Pacific (Tokyo) regions. This service enables you to easily access Aurora Serverless clusters with web services-based applications including AWS Lambda and AWS AppSync. The new APIs included in this SDK release are ExecuteStatement, BatchExecuteStatement, BeginTransaction, CommitTransaction, and RollbackTransaction. The ExecuteSql API is deprecated; instead use ExecuteStatement which provides additional functionality including transaction support.
* ServiceCatalog (3.3.105.0)
	* Service Catalog ListStackInstancesForProvisionedProduct API enables customers to get details of a provisioned product with type "CFN_STACKSET". By passing the provisioned product id, the API will list account, region and status of each stack instances that are associated with this provisioned product.
* Core 3.3.101.18
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.520.0 (2019-05-29 18:16 UTC)
* DLM (3.3.101.0)
	* Customers can now simultaneously take snapshots of multiple EBS volumes attached to an EC2 instance. With this new capability, snapshots guarantee crash-consistency across multiple volumes by preserving the order of IO operations. This new feature is fully integrated with Amazon Data Lifecycle Manager (DLM) allowing customers to automatically manage snapshots by creating lifecycle policies. 
* EC2 (3.3.111.0)
	* Customers can now simultaneously take snapshots of multiple EBS volumes attached to an EC2 instance. With this new capability, snapshots guarantee crash-consistency across multiple volumes by preserving the order of IO operations. This new feature is fully integrated with Amazon Data Lifecycle Manager (DLM) allowing customers to automatically manage snapshots by creating lifecycle policies. 
* IoTThingsGraph (3.3.100.0)
	* Initial release.
* RDS (3.3.103.1)
	* Documentation updates for rds
* SecurityHub (3.3.102.0)
	* This update adds the ListProductSubscribers API, DescribeProducts API, removes CONTAINS as a comparison value for the StringFilter, and only allows use of EQUALS instead of CONTAINS in MapFilter.  
* SimpleSystemsManagement (3.3.102.10)
	* Systems Manager - Documentation updates
* Core 3.3.101.17
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.519.0 (2019-05-28 20:04 UTC)
* Chime (3.3.102.0)
	* This release adds the ability to search and order toll free phone numbers for Voice Connectors.
* GroundStation (3.3.100.0)
	* AWS Ground Station is a fully managed service that enables you to control satellite communications, downlink and process satellite data, and scale your satellite operations efficiently and cost-effectively without having to build or manage your own ground station infrastructure.
* PinpointEmail (3.3.102.0)
	* This release adds support for programmatic access to Deliverability dashboard subscriptions and the deliverability data provided by the Deliverability dashboard for domains and IP addresses. The data includes placement metrics for campaigns that use subscribed domains to send email.
* RDS (3.3.103.0)
	* Add a new output field Status to DBEngineVersion which shows the status of the engine version (either available or deprecated). Add a new parameter IncludeAll to DescribeDBEngineVersions to make it possible to return both available and deprecated engine versions. These changes enable a user to create a Read Replica of an DB instance on a deprecated engine version.
* RoboMaker (3.3.102.0)
	* Added support for an additional robot software suite (Gazebo 9) and for cancelling deployment jobs.
* SecurityToken (3.3.101.7)
	* Documentation updates for iam
* StorageGateway (3.3.106.0)
	* Introduce AssignTapePool operation to allow customers to migrate tapes between pools.
* TranscribeService (3.3.105.0)
	* Amazon Transcribe - support transcriptions from audio sources in Modern Standard Arabic (ar-SA).
* WAF (3.3.100.25)
	* Documentation updates for waf
* Core 3.3.101.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.518.0 (2019-05-24 19:13 UTC)
* CodeDeploy (3.3.101.0)
	* AWS CodeDeploy now supports tagging for the application and deployment group resources.
* MediaStoreData (3.3.101.0)
	* MediaStore - This release adds support for chunked transfer of objects, which reduces latency by making an object available for downloading while it is still being uploaded.
* OpsWorksCM (3.3.100.25)
	* Documentation updates for OpsWorks for Chef Automate; attribute values updated for Chef Automate 2.0 release.

### 3.3.517.0 (2019-05-23 18:07 UTC)
* EC2 (3.3.110.0)
	* New APIs to enable EBS encryption by default feature. Once EBS encryption by default is enabled in a region within the account, all new EBS volumes and snapshot copies are always encrypted
* WAFRegional (3.3.100.24)
	* Documentation updates for waf-regional
* Core 3.3.101.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.516.0 (2019-05-22 19:20 UTC)
* APIGateway (3.3.101.0)
	* This release adds support for tagging of Amazon API Gateway resources.
* Budgets (3.3.101.0)
	* Added new datatype PlannedBudgetLimits to Budget model, and updated examples for AWS Budgets API for UpdateBudget, CreateBudget, DescribeBudget, and DescribeBudgets
* DeviceFarm (3.3.101.0)
	* This release introduces support for tagging, tag-based access control, and resource-based access control.
* EC2 (3.3.109.0)
	* This release adds idempotency support for associate, create route and authorization APIs for AWS Client VPN Endpoints.
* ElasticFileSystem (3.3.101.0)
	* AWS EFS documentation updated to reflect the minimum required value for ProvisionedThroughputInMibps is 1 from the previously documented 0. The service has always required a minimum value of 1, therefor service behavior is not changed. 
* RDS (3.3.102.15)
	* Documentation updates for rds
* ServiceCatalog (3.3.104.0)
	* Service Catalog UpdateProvisionedProductProperties API enables customers to manage provisioned product ownership. Administrators can now update the user associated to a provisioned product to another user within the same account allowing the new user to describe, update, terminate and execute service actions in that Service Catalog resource. New owner will also be able to list and describe all past records executed for that provisioned product.
* WorkLink (3.3.102.0)
	* Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. This release introduces new APIs to associate and manage website authorization providers with Amazon WorkLink fleets.
* Core 3.3.101.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.515.0 (2019-05-21 18:30 UTC)
* AlexaForBusiness (3.3.104.0)
	* This release contains API changes to allow customers to create and manage Network Profiles for their Shared devices
* DataSync (3.3.102.0)
	* Documentation update and refine pagination token on Datasync List API's
* Core 3.3.101.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.514.0 (2019-05-20 18:14 UTC)
* AWSMarketplaceMetering (3.3.100.21)
	* Documentation updates for meteringmarketplace
* Kafka (3.3.102.0)
	* Updated APIs for the Managed Streaming for Kafka service that let customers create clusters with custom Kafka configuration. 
* MediaPackageVod (3.3.100.0)
	* AWS Elemental MediaPackage now supports Video-on-Demand (VOD) workflows.  These new features allow you to easily deliver a vast library of source video Assets stored in your own S3 buckets using a small set of simple to set up Packaging Configurations and Packaging Groups.
* Core 3.3.101.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.513.0 (2019-05-17 18:26 UTC)
* AppStream (3.3.101.0)
	* Includes APIs for managing subscriptions to AppStream 2.0 usage reports and configuring idle disconnect timeouts on AppStream 2.0 fleets.
* Core 3.3.101.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.512.0 (2019-05-16 18:42 UTC)
* S3 (3.3.102.0)
	* This release updates the Amazon S3 PUT Bucket replication API to include a new optional field named token, which allows you to add a replication configuration to an S3 bucket that has Object Lock enabled.

### 3.3.511.0 (2019-05-15 18:09 UTC)
* CodePipeline (3.3.102.0)
	* This feature includes new APIs to add, edit, remove and view tags for pipeline, custom action type and webhook resources. You can also add tags while creating these resources.
* EC2 (3.3.108.0)
	* Adding tagging support for VPC Endpoints and VPC Endpoint Services.
* MediaPackage (3.3.101.0)
	* Adds optional configuration for DASH SegmentTemplateFormat to refer to segments by Number with Duration, rather than Number or Time with SegmentTimeline.
* RDS (3.3.102.11)
	* In the RDS API and CLI documentation, corrections to the descriptions for Boolean parameters to avoid references to TRUE and FALSE. The RDS CLI does not allow TRUE and FALSE values values for Boolean parameters.
* TranscribeService (3.3.104.0)
	* Amazon Transcribe - support transcriptions from audio sources in Indian English (en-IN) and Hindi (hi-IN).
* Core 3.3.101.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.510.0 (2019-05-14 18:18 UTC)
* Chime (3.3.101.0)
	* Amazon Chime private bots GA release.
* Comprehend (3.3.104.0)
	* With this release AWS Comprehend now supports Virtual Private Cloud for Asynchronous Batch Processing jobs
* EC2 (3.3.107.0)
	* Pagination support for ec2.DescribeSubnets, ec2.DescribeDhcpOptions 
* StorageGateway (3.3.105.0)
	* Add Tags parameter to CreateSnapshot and UpdateSnapshotSchedule APIs, used for creating tags on create for one off snapshots and scheduled snapshots.

### 3.3.509.0 (2019-05-13 18:28 UTC)
* DataSync (3.3.101.0)
	* AWS DataSync now enables exclude and include filters to control what files and directories will be copied as part of a task execution.
* IoTAnalytics (3.3.102.0)
	* ContentDeliveryRule to support sending dataset to S3 and glue
* Lambda (3.3.102.0)
	* AWS Lambda now supports Node.js v10

### 3.3.508.0 (2019-05-10 19:45 UTC)
* Glue (3.3.103.0)
	* AWS Glue now supports specifying existing catalog tables for a crawler to examine as a data source. A new parameter CatalogTargets is added to the CrawlerTargets data type. 
* SecurityToken (3.3.101.0)
	* AWS Security Token Service (STS) now supports passing IAM Managed Policy ARNs as session policies when you programmatically create temporary sessions for a role or federated user. The Managed Policy ARNs can be passed via the PolicyArns parameter, which is now available in the AssumeRole, AssumeRoleWithWebIdentity, AssumeRoleWithSAML, and GetFederationToken APIs. The session policies referenced by the PolicyArn parameter will only further restrict the existing permissions of an IAM User or Role for individual sessions.
* Core 3.3.101.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.507.0 (2019-05-08 18:12 UTC)
* EKS (3.3.101.13)
	* Documentation update for Amazon EKS to clarify allowed parameters in update-cluster-config.
* KinesisAnalytics (3.3.101.0)
	* Kinesis Data Analytics APIs now support tagging on applications.
* KinesisAnalyticsV2 (3.3.101.0)
	* Kinesis Data Analytics APIs now support tagging on applications.
* SageMaker (3.3.101.0)
	* Workteams now supports notification configurations. Neo now supports Jetson Nano as a target device and NumberOfHumanWorkersPerDataObject is now included in the ListLabelingJobsForWorkteam response.
* ServiceCatalog (3.3.103.0)
	* Adds "Parameters" field in UpdateConstraint API, which will allow Admin user to update "Parameters" in created Constraints.
* Core 3.3.101.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.506.0 (2019-05-07 18:30 UTC)
* AlexaForBusiness (3.3.103.0)
	* This release adds an API allowing authorized users to delete a shared device's history of voice recordings and associated response data.
* AppSync (3.3.101.0)
	* AWS AppSync now supports the ability to add additional authentication providers to your AWS AppSync GraphQL API as well as the ability to retrieve directives configured against fields or object type definitions during schema introspection.
* SimpleSystemsManagement (3.3.102.0)
	* Patch Manager adds support for Microsoft Application Patching.
* StorageGateway (3.3.104.0)
	* Add optional field AdminUserList to CreateSMBFileShare and UpdateSMBFileShare APIs.
* Core 3.3.101.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.505.1 (2019-05-06 19:13 UTC)
* CodePipeline (3.3.101.3)
	* Documentation updates for codepipeline
* ConfigService (3.3.100.16)
	* AWS Config now supports tagging on PutConfigRule, PutConfigurationAggregator and PutAggregationAuthorization APIs.
* IdentityManagement (3.3.101.5)
	* Documentation updates for iam
* SecurityToken (3.3.100.16)
	* Documentation updates for sts

### 3.3.505.0 (2019-05-03 18:07 UTC)
* CognitoIdentityProvider (3.3.102.0)
	* This release of Amazon Cognito User Pools introduces the new AdminSetUserPassword API that allows administrators of a user pool to change a user's password. The new password can be temporary or permanent.
* MediaConvert (3.3.103.0)
	* DASH output groups using DRM encryption can now enable a playback device compatibility mode to correct problems with playback on older devices. 
* MediaLive (3.3.103.0)
	* You can now switch the channel mode of your channels from standard to single pipeline and from single pipeline to standard. In order to switch a channel from single pipeline to standard all inputs attached to the channel must support two encoder pipelines.
* WorkMail (3.3.101.0)
	* Amazon WorkMail is releasing two new actions: 'GetMailboxDetails' and 'UpdateMailboxQuota'. They add insight into how much space is used by a given mailbox (size) and what its limit is (quota). A mailbox quota can be updated, but lowering the value will not influence WorkMail per user charges. For a closer look at the actions please visit https://docs.aws.amazon.com/workmail/latest/APIReference/API_Operations.html
* Core 3.3.101.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.504.0 (2019-05-02 19:45 UTC)
* AlexaForBusiness (3.3.102.0)
	* This release allows developers and customers to send text and audio announcements to rooms.
* KeyManagementService (3.3.101.0)
	* AWS Key Management Service (KMS) can return an INTERNAL_ERROR connection error code if it cannot connect a custom key store to its AWS CloudHSM cluster. INTERNAL_ERROR is one of several connection error codes that help you to diagnose and fix a problem with your custom key store.
* Core 3.3.101.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.503.0 (2019-05-01 18:10 UTC)
* EC2 (3.3.106.0)
	* This release adds an API for the modification of a VPN Connection, enabling migration from a Virtual Private Gateway (VGW) to a Transit Gateway (TGW), while preserving the VPN endpoint IP addresses on the AWS side as well as the tunnel options.
* ECS (3.3.102.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces additional task definition parameters that enable you to define secret options for Docker log configuration, a per-container list contains secrets stored in AWS Systems Manager Parameter Store or AWS Secrets Manager.
* XRay (3.3.101.0)
	* AWS X-Ray now includes Analytics, an interactive approach to analyzing user request paths (i.e., traces). Analytics will allow you to easily understand how your application and its underlying services are performing. With X-Ray Analytics, you can quickly detect application issues, pinpoint the root cause of the issue, determine the severity of the issues, and identify which end users were impacted. With AWS X-Ray Analytics you can explore, analyze, and visualize traces, allowing you to find increases in response time to user requests or increases in error rates. Metadata around peak periods, including frequency and actual times of occurrence, can be investigated by applying filters with a few clicks. You can then drill down on specific errors, faults, and response time root causes and view the associated traces. 

### 3.3.502.0 (2019-04-30 18:24 UTC)
* CodePipeline (3.3.101.0)
	* This release contains an update to the PipelineContext object that includes the Pipeline ARN, and the Pipeline Execution Id. The ActionContext object is also updated to include the Action Execution Id.
* DirectConnect (3.3.102.0)
	* This release adds support for AWS Direct Connect customers to use AWS Transit Gateway with AWS Direct Connect gateway to route traffic between on-premise networks and their VPCs.
* ManagedBlockchain (3.3.100.0)
	* (New Service) Amazon Managed Blockchain is a fully managed service that makes it easy to create and manage scalable blockchain networks using popular open source frameworks.
* Neptune (3.3.100.13)
	* Adds a feature to allow customers to specify a custom parameter group when restoring a database cluster.
* S3Control (3.3.101.0)
	* Add support for Amazon S3 Batch Operations.
* ServiceCatalog (3.3.102.0)
	* Admin users can now associate/disassociate aws budgets with a portfolio or product in Service Catalog. End users can see the association by listing it or as part of the describe portfolio/product output. A new optional boolean parameter, "DisableTemplateValidation", is added to ProvisioningArtifactProperties data type. The purpose of the parameter is to enable or disable the CloudFormation template validtion when creating a product or a provisioning artifact.
* Core 3.3.101.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.501.0 (2019-04-29 18:09 UTC)
* EC2 (3.3.105.0)
	* Adds support for Elastic Fabric Adapter (EFA) ENIs. 
* Transfer (3.3.102.0)
	* This release adds support for per-server host-key management. You can now specify the SSH RSA private key used by your SFTP server.
* Core 3.3.101.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.500.0 (2019-04-26 19:02 UTC)
* IdentityManagement (3.3.101.0)
	* AWS Security Token Service (STS) enables you to request session tokens from the global STS endpoint that work in all AWS Regions. You can configure the global STS endpoint to vend session tokens that are compatible with all AWS Regions using the new IAM SetSecurityTokenServicePreferences API. 
* SimpleNotificationService (3.3.101.0)
	* With this release AWS SNS adds tagging support for Topics.
* Core 3.3.101.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.499.0 (2019-04-25 20:21 UTC)
* Batch (3.3.101.6)
	* Documentation updates for AWS Batch.
* DynamoDBv2 (3.3.101.0)
	* This update allows you to tag Amazon DynamoDB tables when you create them. Tags are labels you can attach to AWS resources to make them easier to manage, search, and filter. 
* GameLift (3.3.101.0)
	* This release introduces the new Realtime Servers feature, giving game developers a lightweight yet flexible solution that eliminates the need to build a fully custom game server. The AWS SDK updates provide support for scripts, which are used to configure and customize Realtime Servers.
* Inspector (3.3.101.0)
	* AWS Inspector - Improve the ListFindings API response time and decreases the maximum number of agentIDs from 500 to 99.
* Lambda (3.3.101.0)
	* AWS Lambda now supports the GetLayerVersionByArn API.
* WorkSpaces (3.3.102.3)
	* Documentation updates for workspaces
* Core 3.3.101.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.498.0 (2019-04-24 23:22 UTC)
* Core 3.3.101.0
	* Added SAML authentication support in the .NET Standard 2.0 flavor of the SDK; Fix for expired token while using federated AWS credentials; Reverting updates to endpoints.json file from Core 3.3.100.8
	* All services packages updated to require new Core

### 3.3.497.0 (2019-04-24 18:09 UTC)
* AlexaForBusiness (3.3.101.0)
	* This release adds support for the Alexa for Business gateway and gateway group APIs.
* CloudFormation (3.3.100.8)
	* Documentation updates for cloudformation
* EC2 (3.3.104.0)
	* You can now launch the new Amazon EC2 general purpose burstable instance types T3a that feature AMD EPYC processors.
* MediaConnect (3.3.101.0)
	* Adds support for ListEntitlements pagination.
* MediaTailor (3.3.101.0)
	* AWS Elemental MediaTailor SDK now includes a new parameter to support origin servers that produce single-period DASH manifests.
* RDS (3.3.102.0)
	* A new parameter "feature-name" is added to the add-role and remove-role db cluster APIs. The value for the parameter is optional for Aurora MySQL compatible database clusters, but mandatory for Aurora PostgresQL. You can find the valid list of values using describe db engine versions API.
* Route53 (3.3.101.0)
	* Amazon Route 53 now supports the Asia Pacific (Hong Kong) Region (ap-east-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* SimpleSystemsManagement (3.3.101.0)
	* This release updates AWS Systems Manager APIs to allow customers to configure parameters to use either the standard-parameter tier (the default tier) or the advanced-parameter tier. It allows customers to create parameters with larger values and attach parameter policies to an Advanced Parameter. 
* StorageGateway (3.3.103.0)
	* AWS Storage Gateway now supports Access Control Lists (ACLs) on File Gateway SMB shares, enabling you to apply fine grained access controls for Active Directory users and groups.
* Textract (3.3.101.0)
	* This release adds support for checkbox also known as SELECTION_ELEMENT in Amazon Textract.
* Core 3.3.100.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.496.0 (2019-04-19 18:09 UTC)
* ResourceGroups (3.3.101.0)
	* The AWS Resource Groups service increased the query size limit to 4096 bytes.
* TranscribeService (3.3.103.0)
	* Amazon Transcribe - support transcriptions from audio sources in Spanish Spanish (es-ES).
* WorkSpaces (3.3.102.0)
	* Added a new reserved field.

### 3.3.495.0 (2019-04-18 21:07 UTC)
* ApplicationDiscoveryService (3.3.101.0)
	* The Application Discovery Service's DescribeImportTasks and BatchDeleteImportData APIs now return additional statuses for error reporting.
* CognitoIdentityProvider (3.3.101.1)
	* Document updates for Amazon Cognito Identity Provider.
* Kafka (3.3.101.0)
	* Amazon Kafka - Added tagging APIs
* Organizations (3.3.101.0)
	* AWS Organizations is now available in the AWS GovCloud (US) Regions, and we added a new API action for creating accounts in those Regions. For more information, see CreateGovCloudAccount in the AWS Organizations API Reference. 
* RDS (3.3.101.0)
	* This release adds the TimeoutAction parameter to the ScalingConfiguration of an Aurora Serverless DB cluster. You can now configure the behavior when an auto-scaling capacity change can't find a scaling point.
* WorkLink (3.3.101.0)
	* Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. This release introduces new APIs to link and manage internal websites and web apps with Amazon WorkLink fleets. 
* WorkSpaces (3.3.101.5)
	* Documentation updates for workspaces
* Core 3.3.100.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.494.0 (2019-04-17 18:14 UTC)
* EC2 (3.3.103.0)
	* This release adds support for requester-managed Interface VPC Endpoints (powered by AWS PrivateLink). The feature prevents VPC endpoint owners from accidentally deleting or otherwise mismanaging the VPC endpoints of some AWS VPC endpoint services.
* Polly (3.3.101.0)
	* Amazon Polly adds Arabic language support with new female voice - "Zeina"

### 3.3.493.0 (2019-04-16 18:22 UTC)
* CloudWatch (3.3.101.3)
	* Documentation updates for monitoring
* CognitoIdentityProvider (3.3.101.0)
	* This release adds support for the new email configuration in Amazon Cognito User Pools. You can now specify whether Amazon Cognito emails your users by using its built-in email functionality or your Amazon SES email configuration.
* MQ (3.3.101.0)
	* This release adds the ability to retrieve information about broker engines and broker instance options. See Broker Engine Types and Broker Instance Options in the Amazon MQ REST API Reference.
* Organizations (3.3.100.6)
	* Documentation updates for organizations
* Redshift (3.3.101.0)
	* DescribeResize can now return percent of data transferred from source cluster to target cluster for a classic resize.
* StorageGateway (3.3.102.0)
	* This change allows you to select either a weekly or monthly maintenance window for your volume or tape gateway. It also allows you to tag your tape and volume resources on creation by adding a Tag value on calls to the respective api endpoints.
* Core 3.3.100.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.492.0 (2019-04-05 18:07 UTC)
* Comprehend (3.3.103.0)
	* With this release AWS Comprehend provides confusion matrix for custom document classifier.
* Glue (3.3.102.0)
	* AWS Glue now supports workerType choices in the CreateJob, UpdateJob, and StartJobRun APIs, to be used for memory-intensive jobs.
* IoT1ClickDevicesService (3.3.101.5)
	* Documentation updates for 1-Click: improved descriptions of resource tagging APIs.
* MediaConvert (3.3.102.0)
	* Rectify incorrect modelling of DisassociateCertificate method
* MediaLive (3.3.102.0)
	* Today AWS Elemental MediaLive (https://aws.amazon.com/medialive/) adds the option to create "Single Pipeline" channels, which offers a lower-cost option compared to Standard channels. MediaLive Single Pipeline channels have a single encoding pipeline rather than the redundant dual Availability Zone (AZ) pipelines that MediaLive provides with a "Standard" channel.

### 3.3.491.1 (2019-04-04 21:40 UTC)
* Core 3.3.100.5
	* Retry Support for RequestThrottledException
	* All services packages updated to require new Core

### 3.3.491.0 (2019-04-04 18:43 UTC)
* EKS (3.3.101.0)
	* Added support to enable or disable publishing Kubernetes cluster logs in AWS CloudWatch
* IdentityManagement (3.3.100.5)
	* Documentation updates for iam

### 3.3.490.0 (2019-04-03 18:38 UTC)
* Batch (3.3.101.0)
	* Support for GPU resource requirement in RegisterJobDefinition and SubmitJob
* Comprehend (3.3.102.0)
	* With this release AWS Comprehend  adds tagging support for document-classifiers and entity-recognizers.
* Core 3.3.100.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.489.0 (2019-04-02 18:11 UTC)
* CertificateManager (3.3.100.4)
	* Documentation updates for acm
* EC2 (3.3.102.0)
	* Add paginators.
* SecurityHub (3.3.101.0)
	* This update includes 3 additional error codes: AccessDeniedException, InvalidAccessException, and ResourceConflictException. This update also removes the error code ResourceNotFoundException from the GetFindings, GetInvitationsCount, ListInvitations, and ListMembers operations. 

### 3.3.488.0 (2019-04-01 18:17 UTC)
* ElasticMapReduce (3.3.101.0)
	* Amazon EMR adds the ability to modify instance group configurations on a running cluster through the new "configurations" field in the ModifyInstanceGroups API.
* SimpleSystemsManagement (3.3.100.4)
	* March 2019 documentation updates for Systems Manager.

### 3.3.487.0 (2019-03-29 18:48 UTC)
* CloudWatch (3.3.101.0)
	* Added 3 new APIs, and one additional parameter to PutMetricAlarm API, to support tagging of CloudWatch Alarms.
* Comprehend (3.3.101.0)
	* With this release AWS Comprehend supports encryption of output results of analysis jobs and volume data on the storage volume attached to the compute instance that processes the analysis job.
* Greengrass (3.3.101.0)
	* Greengrass APIs now support tagging operations on resources
* Core 3.3.100.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.486.0 (2019-03-28 19:15 UTC)
* MediaLive (3.3.101.0)
	* This release adds a new output locking mode synchronized to the Unix epoch.
* PinpointEmail (3.3.101.0)
	* This release adds support for using the Amazon Pinpoint Email API to tag the following types of Amazon Pinpoint resources: configuration sets; dedicated IP pools; deliverability dashboard reports; and, email identities. A tag is a label that you optionally define and associate with these types of resources. Tags can help you categorize and manage these resources in different ways, such as by purpose, owner, environment, or other criteria. A resource can have as many as 50 tags. For more information, see the Amazon Pinpoint Email API Reference.
* ServiceCatalog (3.3.101.0)
	* Adds "Tags" field in UpdateProvisionedProduct API. The product should have a new RESOURCE_UPDATE Constraint with TagUpdateOnProvisionedProduct field set to ALLOWED for it to work. See API docs for CreateConstraint for more information
* WorkSpaces (3.3.101.0)
	* Amazon WorkSpaces adds tagging support for WorkSpaces Images, WorkSpaces directories, WorkSpaces bundles and IP Access control groups.

### 3.3.485.0 (2019-03-27 20:34 UTC)
* AppMesh (3.3.101.0)
	* This release includes AWS Tagging integration for App Mesh, VirtualNode access logging, TCP routing, and Mesh-wide external traffic egress control. See https://docs.aws.amazon.com/app-mesh/latest/APIReference/Welcome.html for more details.
* EC2 (3.3.101.0)
	* You can now launch the new Amazon EC2 R5ad and M5ad instances that feature local NVMe attached SSD instance storage (up to 3600 GB). M5ad and R5ad feature AMD EPYC processors that offer a 10% cost savings over the M5d and R5d EC2 instances.
* ECS (3.3.101.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for external deployment controllers for ECS services with the launch of task set management APIs. Task sets are a new primitive for controlled management of application deployments within a single ECS service.
* ElasticLoadBalancingV2 (3.3.101.0)
	* This release adds support for routing based on HTTP headers, methods, query string or query parameters and source IP addresses in Application Load Balancer.
* S3 (3.3.101.0)
	* S3 Glacier Deep Archive provides secure, durable object storage class for long term data archival. This SDK release provides API support for this new storage class.
* StorageGateway (3.3.101.0)
	* This change allows you to select a pool for archiving virtual tapes. Pools are associated with S3 storage classes. You can now choose to archive virtual tapes in either S3 Glacier or S3 Glacier Deep Archive storage class. CreateTapes API now takes a new PoolId parameter which can either be GLACIER or DEEP_ARCHIVE. Tapes created with this parameter will be archived in the corresponding storage class.
* Transfer (3.3.101.0)
	*  This release adds PrivateLink support to your AWS SFTP server endpoint, enabling the customer to access their SFTP server within a VPC, without having to traverse the internet. Customers can now can create a server and specify an option whether they want the endpoint to be hosted as public or in their VPC, and with the in VPC option, SFTP clients and users can access the server only from the customer's VPC or from their on-premises environments using DX or VPN. This release also relaxes the SFTP user name requirements to allow underscores and hyphens.

### 3.3.484.0 (2019-03-26 19:47 UTC)
* Glue (3.3.101.0)
	* This new feature will now allow customers to add a customized csv classifier with classifier API. They can specify a custom delimiter, quote symbol and control other behavior they'd like crawlers to have while recognizing csv files
* WorkMail (3.3.100.2)
	* Documentation updates for Amazon WorkMail.
* Core 3.3.100.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.483.0 (2019-03-25 18:24 UTC)
* DirectConnect (3.3.101.0)
	* Direct Connect gateway enables you to establish connectivity between your on-premise networks and Amazon Virtual Private Clouds (VPCs) in any commercial AWS Region (except in China) using AWS Direct Connect connections at any AWS Direct Connect location. This release enables multi-account support for Direct Connect gateway, with multi-account support for Direct Connect gateway, you can associate up to ten VPCs from any AWS account with a Direct Connect gateway. The AWS accounts owning VPCs and the Direct Connect gateway must belong to the same AWS payer account ID. This release also enables Direct Connect Gateway owners to allocate allowed prefixes from each associated VPCs.
* FMS (3.3.101.0)
	* AWS Firewall Manager now allows customer to centrally enable AWS Shield Advanced DDoS protection for their entire AWS infrastructure, across accounts and applications.
* IoT1ClickDevicesService (3.3.101.0)
	* This release adds tagging support for AWS IoT 1-Click Device resources. Use these APIs to add, remove, or list tags on Devices, and leverage the tags for various authorization and billing scenarios. This release also adds the ARN property for DescribeDevice response object.
* IoTAnalytics (3.3.101.0)
	* This change allows you to specify the number of versions of IoT Analytics data set content to be retained. Previously, the number of versions was managed implicitly via the setting of the data set's retention period.
* MediaConvert (3.3.101.0)
	* This release adds support for detailed job progress status and S3 server-side output encryption. In addition, the anti-alias filter will now be automatically applied to all outputs
* RoboMaker (3.3.101.0)
	* Added additional progress metadata fields for robot deployments
* TranscribeService (3.3.102.0)
	* Amazon Transcribe - With this release Amazon Transcribe enhances the custom vocabulary feature to improve accuracy by providing customization on pronunciations and output formatting. 

### 3.3.482.0 (2019-03-22 20:57 UTC)
* IoT1ClickProjects (3.3.101.0)
	* This release adds tagging support for AWS IoT 1-Click Project resources. Use these APIs to add, remove, or list tags on Projects, and leverage the tags for various authorization and billing scenarios. This release also adds the ARN property to projects for DescribeProject and ListProject responses.
* TranscribeService (3.3.101.0)
	* Amazon Transcribe - support transcriptions from audio sources in German (de-DE) and Korean (ko-KR).
* Core 3.3.100.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.481.0 (2019-03-21 21:55 UTC)
* Core 3.3.100.0
	* Added .NET Standard 2.0 support. All services packages starting with 3.3.100 will also include .NET Standard 2.0 support.
	* All services packages updated to require new Core

### 3.3.480.0 (2019-03-21 18:07 UTC)
* AutoScaling (3.3.9.5)
	* Documentation updates for Amazon EC2 Auto Scaling
* CloudWatchEvents (3.3.9.0)
	* Added 3 new APIs, and one additional parameter to the PutRule API, to support tagging of CloudWatch Events rules.
* CognitoIdentityProvider (3.3.13.0)
	* This release adds tags and tag-based access control support to Amazon Cognito User Pools.
* IoT (3.3.27.0)
	* This release adds the GetStatistics API for the AWS IoT Fleet Indexing Service, which allows customers to query for statistics about registered devices that match a search query. This release only supports the count statistics. For more information about this API, see https://docs.aws.amazon.com/iot/latest/apireference/API_GetStatistics.html
* Lightsail (3.3.10.0)
	* This release adds the DeleteKnownHostKeys API, which enables Lightsail's browser-based SSH or RDP clients to connect to the instance after a host key mismatch.

### 3.3.479.0 (2019-03-20 18:09 UTC)
* AWSMarketplaceMetering (3.3.3.0)
	* This release increases AWS Marketplace Metering Service maximum usage quantity to 2147483647 and makes parameters usage quantity and dryrun optional.
* CodePipeline (3.3.7.0)
	* Add support for viewing details of each action execution belonging to past and latest pipeline executions that have occurred in customer's pipeline. The details include start/updated times, action execution results, input/output artifacts information, etc. Customers also have the option to add pipelineExecutionId in the input to filter the results down to a single pipeline execution.
* CognitoIdentity (3.3.3.0)
	* This release adds tags and tag-based access control support to Amazon Cognito Identity Pools (Federated Identities). 

### 3.3.478.0 (2019-03-19 18:29 UTC)
* ConfigService (3.3.25.0)
	* AWS Config adds a new API called SelectResourceConfig to run advanced queries based on resource configuration properties.
* EKS (3.3.4.0)
	* Added support to control private/public access to the Kubernetes API-server endpoint

### 3.3.477.0 (2019-03-18 18:07 UTC)
* Chime (3.3.2.0)
	* This release adds support for the Amazon Chime Business Calling and Voice Connector features.
* DatabaseMigrationService (3.3.14.0)
	* S3 Endpoint Settings added support for 1) Migrating to Amazon S3 as a target in Parquet format 2) Encrypting S3 objects after migration with custom KMS Server-Side encryption. Redshift Endpoint Settings added support for encrypting intermediate S3 objects during migration with custom KMS Server-Side encryption. 
* EC2 (3.3.87.0)
	* DescribeFpgaImages API now returns a new DataRetentionSupport attribute to indicate if the AFI meets the requirements to support DRAM data retention. DataRetentionSupport is a read-only attribute.

### 3.3.476.0 (2019-03-14 18:31 UTC)
* ACMPCA (3.3.4.0)
	* AWS Certificate Manager (ACM) Private CA allows customers to manage permissions on their CAs. Customers can grant or deny AWS Certificate Manager permission to renew exported private certificates.
* CertificateManager (3.3.6.0)
	* AWS Certificate Manager has added a new API action, RenewCertificate. RenewCertificate causes ACM to force the renewal of any private certificate which has been exported.
* CloudWatch (3.3.11.0)
	* New Messages parameter for the output of GetMetricData, to support new metric search functionality.
* ConfigService (3.3.24.0)
	* AWS Config - add ability to tag, untag and list tags for ConfigRule, ConfigurationAggregator and AggregationAuthorization resource types. Tags can be used for various scenarios including tag based authorization.
* EC2 (3.3.86.0)
	* This release adds tagging support for Dedicated Host Reservations.
* IoT (3.3.26.0)
	* In this release, AWS IoT introduces support for tagging OTA Update and Stream resources. For more information about tagging, see the AWS IoT Developer Guide.
* SageMaker (3.3.21.0)
	* Amazon SageMaker Automatic Model Tuning now supports random search and hyperparameter scaling.

### 3.3.475.0 (2019-03-13 18:06 UTC)
* CloudWatchLogs (3.3.7.25)
	* Documentation updates for logs
* ConfigService (3.3.23.0)
	* Config released Remediation APIs allowing Remediation of Config Rules

### 3.3.474.0 (2019-03-12 18:09 UTC)
* ServerlessApplicationRepository (3.3.5.0)
	* The AWS Serverless Application Repository now supports associating a ZIP source code archive with versions of an application.

### 3.3.473.0 (2019-03-11 18:07 UTC)
* CostExplorer (3.3.11.0)
	* The only change in this release is to make TimePeriod a required parameter in GetCostAndUsageRequest.
* ElasticBeanstalk (3.3.13.0)
	* Elastic Beanstalk added support for tagging, and tag-based access control, of all Elastic Beanstalk resources.
* Glue (3.3.19.0)
	* CreateDevEndpoint and UpdateDevEndpoint now support Arguments to configure the DevEndpoint. 
* IoT (3.3.25.5)
	* Documentation updates for iot
* QuickSight (3.3.2.0)
	* Amazon QuickSight user and group operation results now include group principal IDs and user principal IDs. This release also adds "DeleteUserByPrincipalId", which deletes users given their principal ID. The update also improves role session name validation.
* Rekognition (3.3.15.6)
	* Documentation updates for Amazon Rekognition
* Core 3.3.32.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.472.0 (2019-03-08 21:11 UTC)
* CodeBuild (3.3.23.0)
	* CodeBuild also now supports Git Submodules.  CodeBuild now supports opting out of Encryption for S3 Build Logs.  By default these logs are encrypted.
* S3 (3.3.31.23)
	* Documentation updates for s3
* SageMaker (3.3.20.0)
	* SageMaker notebook instances now support enabling or disabling root access for notebook users. SageMaker Neo now supports rk3399 and rk3288 as compilation target devices.

### 3.3.471.0 (2019-03-07 19:31 UTC)
* AppMesh (3.3.1.0)
	* This release includes a new version of the AWS App Mesh APIs. You can read more about the new APIs here: https://docs.aws.amazon.com/app-mesh/latest/APIReference/Welcome.html.
* AutoScaling (3.3.9.3)
	* Documentation updates for autoscaling
* ECS (3.3.24.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces additional task definition parameters that enable you to define dependencies for container startup and shutdown, a per-container start and stop timeout value, as well as an AWS App Mesh proxy configuration which eases the integration between Amazon ECS and AWS App Mesh.
* GameLift (3.3.14.0)
	* Amazon GameLift-hosted instances can now securely access resources on other AWS services using IAM roles. See more details at https://aws.amazon.com/releasenotes/amazon-gamelift/.
* Greengrass (3.3.6.0)
	* Greengrass group UID and GID settings can now be configured to use a provided default via FunctionDefaultConfig. If configured, all Lambda processes in your deployed Greengrass group will by default start with the provided UID and/or GID, rather than by default starting with UID "ggc_user" and GID "ggc_group" as they would if not configured. Individual Lambdas can also be configured to override the defaults if desired via each object in the Functions list of your FunctionDefinitionVersion.
* MediaLive (3.3.19.0)
	* This release adds a MediaPackage output group, simplifying configuration of outputs to AWS Elemental MediaPackage.
* RDS (3.3.39.0)
	* You can configure your Aurora database cluster to automatically copy tags on the cluster to any automated or manual database cluster snapshots that are created from the cluster. This allows you to easily set metadata on your snapshots to match the parent cluster, including access policies. You may enable or disable this functionality while creating a new cluster, or by modifying an existing database cluster.
* Core 3.3.32.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.470.0 (2019-03-06 22:12 UTC)
* Core 3.3.32.0
	* Upgrades for XML service generation of maps and idempotency tokens; Implement the Standard IMDS Request Header; Bypass using capacity for clock skew errors; Fix to find resource when running from service project; Switch rest-json based service's content-type to application/json; Use wildcard for test project references
	* All services packages updated to require new Core

### 3.3.469.0 (2019-03-06 20:13 UTC)
* DirectConnect (3.3.11.0)
	* Exposed a new available port speeds field in the DescribeLocation api call.
* EC2 (3.3.85.0)
	* This release adds pagination support for ec2.DescribeVpcs, ec2.DescribeInternetGateways and ec2.DescribeNetworkAcls APIs
* ElasticFileSystem (3.3.4.3)
	* Documentation updates for elasticfilesystem adding new examples for EFS Lifecycle Management feature.

### 3.3.468.0 (2019-03-05 21:51 UTC)
* CodeDeploy (3.3.12.22)
	* Documentation updates for codedeploy
* MediaLive (3.3.18.0)
	* This release adds support for pausing and unpausing one or both pipelines at scheduled times.
* StorageGateway (3.3.14.0)
	* ActivateGateway, CreateNFSFileShare and CreateSMBFileShare APIs support a new parameter: Tags (to be attached to the created resource). Output for DescribeNFSFileShare, DescribeSMBFileShare and DescribeGatewayInformation APIs now also list the Tags associated with the resource. Minimum length of a KMSKey is now 7 characters.
* Textract (3.3.0.0)
	* This release is intended ONLY for customers that are officially part of the Amazon Textract Preview program.  If you are not officially part of the Amazon Textract program THIS WILL NOT WORK.  Our two main regions for Amazon Textract Preview are N. Virginia and Dublin.  Also some members have been added to Oregon and Ohio.  If you are outside of any of these AWS regions, Amazon Textract Preview definitely will not work. If you would like to be part of the Amazon Textract program, you can officially request sign up here - https://pages.awscloud.com/textract-preview.html. To set expectations appropriately, we are aiming to admit new preview participants once a week until General Availability.

### 3.3.467.0 (2019-03-04 19:17 UTC)
* MediaPackage (3.3.7.0)
	* This release adds support for user-defined tagging of MediaPackage resources. Users may now call operations to list, add and remove tags from channels and origin-endpoints. Users can also specify tags to be attached to these resources during their creation. Describe and list operations on these resources will now additionally return any tags associated with them.
* SimpleSystemsManagement (3.3.41.0)
	* This release updates AWS Systems Manager APIs to support service settings for AWS customers.  A service setting is a key-value pair that defines how a user interacts with or uses an AWS service, and is typically created and consumed by the AWS service team. AWS customers can read a service setting via GetServiceSetting API and update the setting via UpdateServiceSetting API or ResetServiceSetting API, which are introduced in this release. For example, if an AWS service charges money to the account based on a feature or service usage, then the AWS service team might create a setting with the default value of "false".   This means the user can't use this feature unless they update the setting to "true" and  intentionally opt in for a paid feature.

### 3.3.466.0 (2019-03-01 19:41 UTC)
* AutoScalingPlans (3.3.2.22)
	* Documentation updates for autoscaling-plans
* EC2 (3.3.84.0)
	* This release adds support for modifying instance event start time which allows users to reschedule EC2 events.

### 3.3.465.0 (2019-02-28 20:48 UTC)
* AlexaForBusiness (3.3.9.0)
	* This release adds the PutInvitationConfiguration API to configure the user invitation email template with custom attributes, and the GetInvitationConfiguration API to retrieve the configured values.
* ApiGatewayV2 (3.3.1.0)
	* Marking certain properties as explicitly required and fixing an issue with the GetApiMappings operation for ApiMapping resources.
* ApplicationAutoScaling (3.3.11.3)
	* Documentation updates for application-autoscaling
* SimpleSystemsManagement (3.3.40.0)
	* AWS Systems Manager State Manager now supports associations using documents shared by other AWS accounts.

### 3.3.464.1 (2019-02-27 19:08 UTC)
* WAF (3.3.7.18)
	* Documentation updates for waf
* WAFRegional (3.3.7.18)
	* Documentation updates for waf-regional

### 3.3.464.0 (2019-02-26 19:09 UTC)
* ApplicationDiscoveryService (3.3.6.10)
	* Documentation updates for discovery
* CostAndUsageReport (3.3.1.0)
	* Adding support for Athena and new report preferences to the Cost and Usage Report API.
* MediaConvert (3.3.12.0)
	* AWS Elemental MediaConvert SDK has added several features including support for: auto-rotation or user-specified rotation of 0, 90, 180, or 270 degrees; multiple output groups with DRM; ESAM XML documents to specify ad insertion points; Offline Apple HLS FairPlay content protection. 
* OpsWorksCM (3.3.6.40)
	* Documentation updates for opsworkscm
* Organizations (3.3.9.41)
	* Documentation updates for AWS Organizations
* Pinpoint (3.3.13.0)
	* This release adds support for the Amazon Resource Groups Tagging API to Amazon Pinpoint, which means that you can now add and manage tags for Amazon Pinpoint projects (apps), campaigns, and segments. A tag is a label that you optionally define and associate with Amazon Pinpoint resource. Tags can help you categorize and manage these types of resources in different ways, such as by purpose, owner, environment, or other criteria. For example, you can use tags to apply policies or automation, or to identify resources that are subject to certain compliance requirements. A project, campaign, or segment can have as many as 50 tags. For more information about using and managing tags in Amazon Pinpoint, see the Amazon Pinpoint Developer Guide at https://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html. For more information about the Amazon Resource Group Tagging API, see the Amazon Resource Group Tagging API Reference at https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html.
* ResourceGroups (3.3.3.23)
	* Documentation updates for Resource Groups API; updating description of Tag API.
* Core 3.3.31.12
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.463.0 (2019-02-25 19:10 UTC)
* AutoScaling (3.3.9.0)
	* Added support for passing an empty SpotMaxPrice parameter to remove a value previously set when updating an Amazon EC2 Auto Scaling group.
* CostExplorer (3.3.10.0)
	* Added metrics to normalized units.
* ElasticLoadBalancingV2 (3.3.14.0)
	* This release enables you to use the existing client secret when modifying a rule with an action of type authenticate-oidc.
* MediaStore (3.3.3.0)
	* This release adds support for access logging, which provides detailed records for the requests that are made to objects in a container.

### 3.3.462.0 (2019-02-22 19:10 UTC)
* Athena (3.3.3.0)
	* This release adds tagging support for Workgroups to Amazon Athena. Use these APIs to add, remove, or list tags on Workgroups, and leverage the tags for various authorization and billing scenarios.
* Cloud9 (3.3.1.0)
	* Adding EnvironmentLifecycle to the Environment data type.
* Glue (3.3.18.0)
	* AWS Glue adds support for assigning AWS resource tags to jobs, triggers, development endpoints, and crawlers. Each tag consists of a key and an optional value, both of which you define. With this capacity, customers can use tags in AWS Glue to easily organize and identify your resources, create cost allocation reports, and control access to resources. 
* StepFunctions (3.3.5.0)
	* This release adds support for tag-on-create. You can now add tags when you create AWS Step Functions activity and state machine resources. For more information about tagging, see AWS Tagging Strategies.

### 3.3.461.0 (2019-02-21 19:19 UTC)
* CloudWatch (3.3.10.21)
	* Documentation updates for monitoring
* CodeBuild (3.3.22.0)
	* Add support for CodeBuild local caching feature
* KinesisVideo (3.3.2.3)
	* Documentation updates for Kinesis Video Streams
* KinesisVideoArchivedMedia (3.3.2.0)
	* In this release, HLS playback of KVS streams can be configured to output MPEG TS fragments using the ContainerFormat parameter. HLS playback of KVS streams can also be configured to include the EXT-X-PROGRAM-DATE-TIME field using the DisplayFragmentTimestamp parameter.
* KinesisVideoMedia (3.3.0.57)
	* Documentation updates for Kinesis Video Streams
* Organizations (3.3.9.40)
	* Documentation updates for organizations
* Transfer (3.3.1.0)
	* Bug fix: increased the max length allowed for request parameter NextToken when paginating List operations
* WorkDocs (3.3.7.21)
	* Documentation updates for workdocs

### 3.3.460.0 (2019-02-20 19:09 UTC)
* CodeCommit (3.3.9.0)
	* This release adds an API for adding / updating / deleting / copying / moving / setting file modes for one or more files directly to an AWS CodeCommit repository without requiring a Git client.
* DirectConnect (3.3.10.0)
	* Documentation updates for AWS Direct Connect
* MediaLive (3.3.17.0)
	* This release adds support for VPC inputs, allowing you to push content from your Amazon VPC directly to MediaLive.
* Core 3.3.31.11
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.459.0 (2019-02-19 19:08 UTC)
* DirectoryService (3.3.9.0)
	* This release adds support for tags during directory creation (CreateDirectory, CreateMicrosoftAd, ConnectDirectory).
* ElasticFileSystem (3.3.4.0)
	* Amazon EFS now supports adding tags to file system resources as part of the CreateFileSystem API . Using this capability, customers can now more easily enforce tag-based authorization for EFS file system resources.
* IoT (3.3.25.0)
	* AWS IoT - AWS IoT Device Defender adds support for configuring behaviors in a security profile with statistical thresholds. Device Defender also adds support for configuring multiple data-point evaluations before a violation is either created or cleared.
* SimpleSystemsManagement (3.3.39.0)
	* AWS Systems Manager now supports adding tags when creating Activations, Patch Baselines, Documents, Parameters, and Maintenance Windows

### 3.3.458.0 (2019-02-18 19:04 UTC)
* Athena (3.3.2.0)
	* This release adds support for Workgroups to Amazon Athena. Use Workgroups to isolate users, teams, applications or workloads in the same account, control costs by setting up query limits and creating Amazon SNS alarms, and publish query-related metrics to Amazon CloudWatch. 
* SecretsManager (3.3.3.0)
	* This release increases the maximum allowed size of SecretString or SecretBinary from 4KB to 7KB in the CreateSecret, UpdateSecret, PutSecretValue and GetSecretValue APIs.

### 3.3.457.0 (2019-02-15 19:19 UTC)
* ApplicationAutoScaling (3.3.11.0)
	* Documentation updates for Application Auto Scaling
* Chime (3.3.1.23)
	* Documentation updates for Amazon Chime
* IoT (3.3.24.0)
	* In this release, IoT Device Defender introduces support for tagging Scheduled Audit resources.
* Core 3.3.31.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.456.1 (2019-02-15 03:41 UTC)
* Chime (3.3.1.22)
	* Package description update.
* Connect (3.3.4.17)
	* Package description update.
* DLM (3.3.2.3)
	* Package description update.
* DocDB (3.3.0.9)
	* Package description update.
* IoT1ClickProjects (3.3.0.50)
	* Package description update.
* IoTAnalytics (3.3.7.12)
	* Package description update.
* RAM (3.3.0.20)
	* Package description update.
* S3Control (3.3.0.20)
	* Package description update.
* ServiceDiscovery (3.3.3.19)
	* Package description update.
* Signer (3.3.0.41)
	* Package description update.

### 3.3.456.0 (2019-02-14 19:14 UTC)
* EC2 (3.3.83.0)
	* This release adds tagging and ARN support for AWS Client VPN Endpoints.You can now run bare metal workloads on EC2 M5 and M5d instances. m5.metal and m5d.metal instances are powered by custom Intel Xeon Scalable Processors with a sustained all core frequency of up to 3.1 GHz. m5.metal and m5d.metal offer 96 vCPUs and 384 GiB of memory. With m5d.metal, you also have access to 3.6 TB of NVMe SSD-backed instance storage. m5.metal and m5d.metal instances deliver 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking, as well as 14 Gbps of bandwidth to EBS.You can now run bare metal workloads on EC2 z1d instances. z1d.metal instances are powered by custom Intel Xeon Scalable Processors with a sustained all core frequency of up to 4.0 GHz. z1d.metal offers 48 vCPUs, 384 GiB of memory, and 1.8 TB of NVMe SSD-backed instance storage. z1d.metal instances deliver 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking, as well as 14 Gbps of bandwidth to EBS.
* KinesisVideo (3.3.2.0)
	* Adds support for Tag-On-Create for Kinesis Video Streams. A list of tags associated with the stream can be created at the same time as the stream creation.

### 3.3.455.0 (2019-02-13 23:09 UTC)
* ElasticFileSystem (3.3.3.0)
	* Customers can now use the EFS Infrequent Access (IA) storage class to more cost-effectively store larger amounts of data in their file systems. EFS IA is cost-optimized storage for files that are not accessed every day. You can create a new file system and enable Lifecycle Management to automatically move files that have not been accessed for 30 days from the Standard storage class to the IA storage class.
* MediaTailor (3.3.4.0)
	* This release adds support for tagging AWS Elemental MediaTailor resources.
* Rekognition (3.3.15.0)
	* GetContentModeration now returns the version of the moderation detection model used to detect unsafe content.
* Core 3.3.31.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.454.1 (2019-02-12 23:14 UTC)
* Lambda (3.3.19.17)
	* Documentation updates for AWS Lambda
* Core 3.3.31.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.454.0 (2019-02-11 23:08 UTC)
* AppStream (3.3.21.0)
	* This update enables customers to find the start time, max expiration time, and connection status associated with AppStream streaming session.
* CodeBuild (3.3.21.0)
	* Add customized webhook filter support
* MediaPackage (3.3.6.0)
	* Adds optional configuration for DASH to compact the manifest by combining duplicate SegmentTemplate tags. Adds optional configuration for DASH SegmentTemplate format to refer to segments by "Number" (default) or by "Time".

### 3.3.453.0 (2019-02-08 22:10 UTC)
* ApplicationDiscoveryService (3.3.6.5)
	* Documentation updates for the AWS Application Discovery Service.
* DLM (3.3.2.0)
	* This release is to correct the timestamp format to ISO8601 for the DateCreated and DateModified files in the GetLifecyclePolicy response object.
* ECS (3.3.23.0)
	* Amazon ECS introduces the PutAccountSettingDefault API, an API that allows a user to set the default ARN/ID format opt-in status for all the roles and users in the account. Previously, setting the account's default opt-in status required the use of the root user with the PutAccountSetting API.

### 3.3.452.0 (2019-02-07 21:38 UTC)
* Elasticsearch (3.3.11.0)
	* Feature: Support for three Availability Zone deployments
* GameLift (3.3.13.0)
	* This release delivers a new API action for deleting unused matchmaking rule sets. More details are available at https://aws.amazon.com/releasenotes/?tag=releasenotes%23keywords%23amazon-gamelift.
* MediaLive (3.3.16.0)
	* This release adds tagging of channels, inputs, and input security groups.
* RoboMaker (3.3.1.0)
	* Added support for tagging and tag-based access control for AWS RoboMaker resources. Also, DescribeSimulationJob now includes a new failureReason field to help debug simulation job failures

### 3.3.451.0 (2019-02-06 23:18 UTC)
* EC2 (3.3.82.0)
	* Add Linux with SQL Server Standard, Linux with SQL Server Web, and Linux with SQL Server Enterprise to the list of allowed instance platforms for On-Demand Capacity Reservations.
* FSx (3.3.1.0)
	* New optional ExportPath parameter added to the CreateFileSystemLustreConfiguration object for user-defined export paths. Used with the CreateFileSystem action when creating an Amazon FSx for Lustre file system.

### 3.3.450.0 (2019-02-05 22:07 UTC)
* EC2 (3.3.81.0)
	* ec2.DescribeVpcPeeringConnections pagination support
* ServiceCatalog (3.3.13.20)
	* Service Catalog Documentation Update for ProvisionedProductDetail
* Shield (3.3.5.0)
	* The DescribeProtection request now accepts resource ARN as valid parameter.

### 3.3.449.0 (2019-02-04 22:36 UTC)
* ApplicationAutoScaling (3.3.10.45)
	* Documentation updates for application-autoscaling
* CodeCommit (3.3.8.0)
	* This release supports a more graceful handling of the error case when a repository is not associated with a pull request ID in a merge request in AWS CodeCommit.
* ECS (3.3.22.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for GPU workloads by enabling you to create clusters with GPU-enabled container instances.
* WorkSpaces (3.3.6.0)
	* This release sets ClientProperties as a required parameter.

### 3.3.448.1 (2019-02-04 17:02 UTC)
* S3 (3.3.31.15)
	* Update region constants.
* SecurityToken (3.3.4.50)
	* Fix to support documented role,saml-provider format.
* SimpleNotificationService (3.3.3.18)
	* Parse SNS subscription message correctly.
* Core 3.3.31.7
	* Fix clock skew caching when the ClientConfig endpoint is different from the request endpoint.
Update region constants.
	* All services packages updated to require new Core

### 3.3.448.0 (2019-01-25 22:30 UTC)
* CodeCommit (3.3.7.0)
	* The PutFile API will now throw new exception FilePathConflictsWithSubmodulePathException when a submodule exists at the input file path; PutFile API will also throw FolderContentSizeLimitExceededException when the total size of any folder on the path exceeds the limit as a result of the operation.
* DeviceFarm (3.3.13.0)
	* Introduces a new rule in Device Pools - "Availability". Customers can now ensure they pick devices that are available (i.e., not being used by other customers).
* MediaConnect (3.3.1.0)
	* This release adds support for tagging, untagging, and listing tags for existing AWS Elemental MediaConnect resources.
* MediaLive (3.3.15.0)
	* This release adds support for Frame Capture output groups and for I-frame only manifests (playlists) in HLS output groups.
* Core 3.3.31.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.447.0 (2019-01-24 23:03 UTC)
* CloudWatchLogs (3.3.7.14)
	* Documentation updates for CloudWatch Logs
* CodeBuild (3.3.20.0)
	* This release adds support for cross-account ECR images and private registry authentication. 
* ECR (3.3.5.0)
	* Amazon ECR updated the default endpoint URL to support AWS Private Link.
* ElasticLoadBalancingV2 (3.3.13.0)
	* Elastic Load Balancing now supports TLS termination on Network Load Balancers. With this launch, you can offload the decryption/encryption of TLS traffic from your application servers to the Network Load Balancer. This enables you to run your backend servers optimally and keep your workloads secure. Additionally, Network Load Balancers preserve the source IP of the clients to the back-end applications, while terminating TLS on the load balancer.  When TLS is enabled on an NLB, Access Logs can be enabled for the load balancer, and log entries will be emitted for all TLS connections.
* PinpointSMSVoice (3.3.2.0)
	* Added the ListConfigurationSets operation, which returns a list of the configuration sets that are associated with your account.
* RDS (3.3.38.0)
	* The Amazon RDS API allows you to add or remove Identity and Access Management (IAM) role associated with a specific feature name with an RDS database instance. This helps with capabilities such as invoking Lambda functions from within a trigger in the database, load data from Amazon S3 and so on
* Core 3.3.31.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.446.0 (2019-01-23 23:45 UTC)
* ACMPCA (3.3.3.0)
	* Added TagOnCreate parameter to the CreateCertificateAuthority operation, updated the Tag regex pattern to align with AWS tagging APIs, and added RevokeCertificate limit.
* ApiGatewayManagementApi (3.3.1.0)
	* Fixes a typo in the 'max' constraint.
* WorkLink (3.3.0.0)
	* This is the initial SDK release for Amazon WorkLink. Amazon WorkLink is a fully managed, cloud-based service that enables secure, one-click access to internal websites and web apps from mobile phones. With Amazon WorkLink, employees can access internal websites as seamlessly as they access any other website. IT administrators can manage users, devices, and domains by enforcing their own security and access policies via the AWS Console or the AWS SDK.
* Core 3.3.31.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.445.0 (2019-01-21 22:53 UTC)
* ApplicationDiscoveryService (3.3.6.0)
	* The Application Discovery Service's import APIs allow you to import information about your on-premises servers and applications into ADS so that you can track the status of your migrations through the Migration Hub console.
* AppStream (3.3.20.0)
	* This API update includes support for tagging Stack, Fleet, and ImageBuilder resources at creation time.
* DatabaseMigrationService (3.3.13.0)
	* Update for DMS TestConnectionSucceeds waiter
* FMS (3.3.2.0)
	* This release provides support for cleaning up web ACLs during Firewall Management policy deletion. You can now enable the DeleteAllPolicyResources flag and it will delete all system-generated web ACLs.
* SimpleSystemsManagement (3.3.38.0)
	* AWS Systems Manager State Manager now supports configuration management of all AWS resources through integration with Automation. 

### 3.3.444.0 (2019-01-18 21:13 UTC)
* EC2 (3.3.80.0)
	* Adjust EC2's available instance types.
* Glue (3.3.17.0)
	* AllocatedCapacity field is being deprecated and replaced with MaxCapacity field

### 3.3.443.1 (2019-01-18 01:29 UTC)
* Signer (3.3.0.34)
	* Updated to use new Core, version 3.3.31.3
	* Updating package to use latest Core.

### 3.3.443.0 (2019-01-17 23:11 UTC)
* Lambda (3.3.19.12)
	* Documentation updates for AWS Lambda
* Lightsail (3.3.9.0)
	* This release adds functionality to the CreateDiskSnapshot API that allows users to snapshot instance root volumes. It also adds various documentation updates.
* Pinpoint (3.3.12.0)
	* This release updates the PutEvents operation. AppPackageName, AppTitle, AppVersionCode, SdkName fields will now be accepted as a part of the event when submitting events.
* Rekognition (3.3.14.0)
	* GetLabelDetection now returns bounding box information for common objects and a hierarchical taxonomy of detected labels. The version of the model used for video label detection is also returned. DetectModerationLabels now returns the version of the model used for detecting unsafe content.
* Core 3.3.31.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.442.0 (2019-01-16 18:53 UTC)
* Backup (3.3.0.0)
	* AWS Backup is a unified backup service designed to protect AWS services and their associated data. AWS Backup simplifies the creation, migration, restoration, and deletion of backups, while also providing reporting and auditing
* CostExplorer (3.3.9.11)
	* Removed Tags from the list of GroupBy dimensions available for GetReservationCoverage.
* DynamoDBv2 (3.3.17.0)
	* Amazon DynamoDB now integrates with AWS Backup, a centralized backup service that makes it easy for customers to configure and audit the AWS resources they want to backup, automate backup scheduling, set retention policies, and monitor all recent backup and restore activity. AWS Backup provides a fully managed, policy-based backup solution, simplifying your backup management, and helping you meet your business and regulatory backup compliance requirements. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.441.0 (2019-01-14 23:08 UTC)
* MediaConvert (3.3.11.0)
	* IMF decode from a Composition Playlist for IMF specializations App #2 and App #2e; up to 99 input clippings; caption channel selection for MXF; and updated rate control for CBR jobs. Added support for acceleration in preview
* StorageGateway (3.3.13.0)
	* JoinDomain API supports two more  parameters: organizational unit(OU) and domain controllers.  Two new APIs are introduced: DetachVolume and AttachVolume.

### 3.3.440.0 (2019-01-11 19:21 UTC)
* ElasticMapReduce (3.3.6.33)
	* Documentation updates for Amazon EMR
* RDSDataService (3.3.1.0)
	* Documentation updates for RDS Data API.

### 3.3.439.0 (2019-01-10 22:50 UTC)
* CodeDeploy (3.3.12.11)
	* Documentation updates for codedeploy
* EC2 (3.3.79.0)
	* EC2 Spot: a) CreateFleet support for Single AvailabilityZone requests and b) support for paginated DescribeSpotInstanceRequests.
* IoT (3.3.23.0)
	* This release adds tagging support for rules of AWS IoT Rules Engine. Tags enable you to categorize your rules in different ways, for example, by purpose, owner, or environment. For more information about tagging, see AWS Tagging Strategies (https://aws.amazon.com/answers/account-management/aws-tagging-strategies/). For technical documentation, look for the tagging operations in the AWS IoT Core API reference or User Guide (https://docs.aws.amazon.com/iot/latest/developerguide/tagging-iot.html).
* SageMaker (3.3.19.0)
	* SageMaker Training Jobs now support Inter-Container traffic encryption.
* Core 3.3.31.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.438.0 (2019-01-09 22:23 UTC)
* DocDB (3.3.0.0)
	* Amazon DocumentDB (with MongoDB compatibility) is a fast, reliable, and fully-managed database service. Amazon DocumentDB makes it easy for developers to set up, run, and scale MongoDB-compatible databases in the cloud.
* Redshift (3.3.12.0)
	* DescribeSnapshotSchedules returns a list of snapshot schedules. With this release, this API will have a list of clusters and number of clusters associated with the schedule.
* Core 3.3.31.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.437.0 (2019-01-08 02:56 UTC)
* S3 (3.3.31.8)
	* Added missing header for S3 CopyPart request.
Updated event notification object to include the sequencer and glacier event data.
* Core 3.3.31.0
	* Code for future SDK instrumentation and telemetry.
Add support for us-gov-east-1 region.
Fix for endpoint discovery handler async exception handling logic that could cause a .NET 3.5 async call to hang.
	* All services packages updated to require new Core

### 3.3.436.1 (2019-01-07 22:00 UTC)
* AppMesh (3.3.0.8)
	* AWS App Mesh now supports active health checks. You can specify TCP or HTTP health checks with custom thresholds and intervals on your VirtualNode definitions. See the AWS App Mesh HealthCheckPolicy documentation for more information.
* Core 3.3.30.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.436.0 (2019-01-04 23:00 UTC)
* DeviceFarm (3.3.12.0)
	* "This release provides support for running Appium Node.js and Appium Ruby tests on AWS Device Farm.
* ECS (3.3.21.8)
	* Documentation updates for Amazon ECS tagging feature.

### 3.3.435.0 (2019-01-03 22:55 UTC)
* IoTAnalytics (3.3.7.0)
	* ListDatasetContents now has a filter to limit results by date scheduled.
* Core 3.3.30.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.434.1 (2019-01-03 03:19 UTC)
* OpsWorksCM (3.3.6.25)
	* Documentation updates for opsworkscm

### 3.3.434.0 (2018-12-21 22:22 UTC)
* ACMPCA (3.3.2.0)
	* This release marks the introduction of waiters in ACM PCA, which allow you to control the progression of your code based on the presence or state of certain resources. Waiters can be implemented in the DescribeCertificateAuthorityAuditReport, GetCertificate, and GetCertificateAuthorityCsr API operations.
* DynamoDBv2 (3.3.16.0)
	* Added provisionedThroughPut exception on the request level for transaction APIs.
* PinpointSMSVoice (3.3.1.0)
	* Configuration sets can now use Amazon SNS as an event destination.
* StepFunctions (3.3.4.0)
	* This release adds support for cost allocation tagging. You can now create, delete, and list tags for AWS Step Functions activity and state machine resources. For more information about tagging, see AWS Tagging Strategies.
* Core 3.3.30.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.433.1 (2018-12-21 09:12 UTC)
* Core 3.3.30.1
	* Fix Regex for matching profile names in the ~/.aws/config file. Fixes bug where partial profile name would match a profile in the ~/.aws/config file.


### 3.3.433.0 (2018-12-21 05:51 UTC)
* Core 3.3.30.0
	* Added support for endpoint discovery.
	* All services packages updated to require new Core

### 3.3.432.0 (2018-12-21 01:24 UTC)
* CognitoIdentityProvider (3.3.12.0)
	* Amazon Cognito now has API support for updating the Secure Sockets Layer (SSL) certificate for the custom domain for your user pool.
* Comprehend (3.3.6.0)
	* This SDK release adds functionality to stop training Custom Document Classifier or Custom Entity Recognizer in Amazon Comprehend.
* KinesisFirehose (3.3.8.0)
	* Support for specifying customized s3 keys and supplying a separate prefix for failed-records
* MediaLive (3.3.14.0)
	* This release provides support for ID3 tags and video quality setting for subgop_length.
* TranscribeService (3.3.7.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in Italian (it-IT).

### 3.3.431.0 (2018-12-19 22:44 UTC)
* EC2 (3.3.78.0)
	* This release adds support for specifying partition as a strategy for EC2 Placement Groups. This new strategy allows one to launch instances into partitions that do not share certain underlying hardware between partitions, to assist with building and deploying highly available replicated applications. 
* SageMaker (3.3.18.0)
	* Batch Transform Jobs now supports TFRecord as a Split Type. ListCompilationJobs API action now supports SortOrder and SortBy inputs.
* WAF (3.3.7.0)
	* This release adds rule-level control for rule group. If a rule group contains a rule that blocks legitimate traffic, previously you had to override the entire rule group to COUNT in order to allow the traffic. You can now use the UpdateWebACL API to exclude specific rules within a rule group. Excluding rules changes the action for the individual rules to COUNT. Excluded rules will be recorded in the new "excludedRules" attribute of the WAF logs.
* WAFRegional (3.3.7.0)
	* This release adds rule-level control for rule group. If a rule group contains a rule that blocks legitimate traffic, previously you had to override the entire rule group to COUNT in order to allow the traffic. You can now use the UpdateWebACL API to exclude specific rules within a rule group. Excluding rules changes the action for the individual rules to COUNT. Excluded rules will be recorded in the new "excludedRules" attribute of the WAF logs.

### 3.3.430.0 (2018-12-18 23:00 UTC)
* ApiGatewayManagementApi (3.3.0.0)
	* This is the initial SDK release for the Amazon API Gateway Management API, which allows you to directly manage runtime aspects of your APIs. This release makes it easy to send data directly to clients connected to your WebSocket-based APIs.
* ApiGatewayV2 (3.3.0.0)
	* This is the initial SDK release for the Amazon API Gateway v2 APIs. This SDK will allow you to manage and configure APIs in Amazon API Gateway; this first release provides the capabilities that allow you to programmatically setup and manage WebSocket APIs end to end. 
* EC2 (3.3.77.0)
	* Client VPN, is a client-based VPN service. With Client VPN, you can securely access resources in AWS as well as access resources in on-premises from any location using OpenVPN based devices. With Client VPN, you can set network based firewall rules that can restrict access to networks based on Active Directory groups.
* ElasticBeanstalk (3.3.12.0)
	* This release adds a new resource that Elastic Beanstalk will soon support, EC2 launch template, to environment resource descriptions.
* GlobalAccelerator (3.3.0.5)
	* Documentation updates for Ubiquity

### 3.3.429.0 (2018-12-17 23:00 UTC)
* ECR (3.3.4.0)
	* This release adds support for ECR repository tagging.
* QuickSight (3.3.1.0)
	* Amazon QuickSight's RegisterUser API now generates a user invitation URL when registering a user with the QuickSight identity type. This URL can then be used by the registered QuickSight user to complete the user registration process. This release also corrects some HTTP return status codes.

### 3.3.428.0 (2018-12-14 22:51 UTC)
* AlexaForBusiness (3.3.8.0)
	* Released new APIs for managing private skill access to Enrolled Users.  These API's are the equivalent of the A4B console for Private Skills checkbox "Available for Users".
* CloudFormation (3.3.13.4)
	* Documentation updates for cloudformation
* Redshift (3.3.11.6)
	* Documentation updates for Amazon Redshift
* Core 3.3.29.16
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.427.0 (2018-12-13 22:22 UTC)
* Organizations (3.3.9.22)
	* Documentation updates for AWS Organizations
* PinpointEmail (3.3.1.0)
	* This release adds new operations for the Amazon Pinpoint Deliverability Dashboard. You can use the Deliverability Dashboard to view response and inbox placement metrics for the domains that you use to send email. You can also perform tests on individual email messages to determine how often your messages are delivered to the inbox on several major email providers.
* Core 3.3.29.15
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.426.0 (2018-12-12 22:38 UTC)
* EKS (3.3.3.0)
	* Added support for updating kubernetes version of Amazon EKS clusters.
* Glue (3.3.16.0)
	* API Update for Glue: this update enables encryption of password inside connection objects stored in AWS Glue Data Catalog using DataCatalogEncryptionSettings.  In addition, a new "HidePassword" flag is added to GetConnection and GetConnections to return connections without passwords.
* Route53 (3.3.18.0)
	* You can now specify a new region, eu-north-1 (in Stockholm, Sweden), as a region for latency-based or geoproximity routing.
* SageMaker (3.3.17.0)
	* Amazon SageMaker Automatic Model Tuning now supports early stopping of training jobs. With early stopping, training jobs that are unlikely to generate good models will be automatically stopped during a Hyperparameter Tuning Job.

### 3.3.425.0 (2018-12-11 23:12 UTC)
* Connect (3.3.4.0)
	* This update adds the GetContactAttributes operation to retrieve the attributes associated with a contact.
* ECS (3.3.21.2)
	* Documentation updates for Amazon ECS.
* MediaStore (3.3.2.0)
	* This release adds Delete Object Lifecycling to AWS MediaStore Containers.
* Core 3.3.29.14
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.424.0 (2018-12-07 19:57 UTC)
* AlexaForBusiness (3.3.7.0)
	* Alexa for Business now allows IT administrators to create ad-hoc or scheduled usage reports, which help customers understand how Alexa is used in their workplace. To learn how to create usage reports, see https://docs.aws.amazon.com/a4b/latest/ag/creating-reports.html
* EC2 (3.3.76.0)
	* You can now launch the larger-sized P3dn.24xlarge instance that features NVIDIA Tesla V100s with double the GPU memory, 100Gbps networking and local NVMe storage.
* IdentityManagement (3.3.9.0)
	* We are making it easier for you to manage your AWS Identity and Access Management (IAM) policy permissions by enabling you to retrieve the last timestamp when an IAM entity (e.g., user, role, or a group) accessed an AWS service. This feature also allows you to audit service access for your entities.
* ServiceCatalog (3.3.13.4)
	* Documentation updates for servicecatalog.

### 3.3.423.0 (2018-12-06 20:15 UTC)
* CodeBuild (3.3.19.0)
	* Support personal access tokens for GitHub source and app passwords for Bitbucket source
* ElasticLoadBalancingV2 (3.3.12.0)
	* This release allows Application Load Balancers to route traffic to Lambda functions, in addition to instances and IP addresses.
* MediaLive (3.3.13.0)
	* This release enables the AWS Elemental MediaConnect input type in AWS Elemental MediaLive. This can then be used to automatically create and manage AWS Elemental MediaConnect Flow Outputs when you create a channel using those inputs.
* RDS (3.3.37.2)
	* Documentation updates for Amazon RDS

### 3.3.422.0 (2018-12-05 21:23 UTC)
* CostExplorer (3.3.9.0)
	* Add normalized unit support for both GetReservationUtilization and GetReservationCoverage API.
* MediaTailor (3.3.3.0)
	* AWS Elemental MediaTailor SDK now includes a new parameter to control the Location tag of DASH manifests.
* MQ (3.3.3.0)
	* This release adds support for cost allocation tagging. You can now create, delete, and list tags for AmazonMQ resources. For more information about tagging, see AWS Tagging Strategies.

### 3.3.421.0 (2018-12-04 20:24 UTC)
* AWSHealth (3.3.2.0)
	* AWS Health API DescribeAffectedEntities operation now includes a field that returns the URL of the affected entity.
* S3 (3.3.31.0)
	* S3 Inventory reports can now be generated in Parquet format by setting the Destination Format to be 'Parquet'.

### 3.3.420.0 (2018-12-04 01:45 UTC)
* DeviceFarm (3.3.11.0)
	* Customers can now schedule runs without a need to create a Device Pool. They also get realtime information on public device availability.
* MediaConvert (3.3.10.1)
	* Documentation updates for mediaconvert
* ServiceCatalog (3.3.13.3)
	* Documentation updates for servicecatalog
* StorageGateway (3.3.12.0)
	* API list-local-disks returns a list of the gateway's local disks. This release adds a field DiskAttributeList to these disks.
* Core 3.3.29.13
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.419.0 (2018-11-29 18:35 UTC)
* CloudWatchEvents (3.3.8.0)
	* Support for Managed Rules (rules that are created and maintained by the AWS services in your account) is added.
* ElasticLoadBalancingV2 (3.3.11.0)
	* This release allows Application Load Balancers to route traffic to Lambda functions, in addition to instances and IP addresses.
* Kafka (3.3.0.0)
	* This is the initial SDK release for Amazon Managed Streaming for Kafka (Amazon MSK). Amazon MSK is a service that you can use to easily build, monitor, and manage Apache Kafka clusters in the cloud.
* Lambda (3.3.19.0)
	* AWS Lambda now supports Lambda Layers and Ruby as a runtime. Lambda Layers are a new type of artifact that contains arbitrary code and data, and may be referenced by zero, one, or more functions at the same time.  You can also now develop your AWS Lambda function code using the Ruby programming language.
* S3 (3.3.30.0)
	* Fixed issue with ObjectLockRetainUntilDate in S3 PutObject
* ServerlessApplicationRepository (3.3.4.0)
	* AWS Serverless Application Repository now supports nested applications. You can nest individual applications as components of a larger application to make it easy to assemble and deploy new serverless architectures. 
* StepFunctions (3.3.3.0)
	* AWS Step Functions is now integrated with eight additional AWS services: Amazon ECS, AWS Fargate, Amazon DynamoDB, Amazon SNS, Amazon SQS, AWS Batch, AWS Glue, and Amazon SageMaker. To learn more, please see https://docs.aws.amazon.com/step-functions/index.html
* XRay (3.3.5.0)
	* GetTraceSummaries - Now provides additional information regarding your application traces such as Availability Zone, Instance ID, Resource ARN details, Revision, Entry Point, Root Cause Exceptions and Root Causes for Fault, Error and Response Time.

### 3.3.418.0 (2018-11-29 01:09 UTC)
* AppMesh (3.3.0.0)
	* AWS App Mesh is a service mesh that makes it easy to monitor and control communications between microservices of an application. AWS App Mesh APIs are available for preview in eu-west-1, us-east-1, us-east-2, and us-west-2 regions.
* EC2 (3.3.75.0)
	* Adds the following updates: 1. You can now hibernate and resume Amazon-EBS backed instances using the StopInstances and StartInstances APIs. For more information about using this feature and supported instance types and operating systems, visit the user guide. 2. Amazon Elastic Inference accelerators are resources that you can attach to current generation EC2 instances to accelerate your deep learning inference workloads. With Amazon Elastic Inference, you can configure the right amount of inference acceleration to your deep learning application without being constrained by fixed hardware configurations and limited GPU selection. 3. AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM.
* LicenseManager (3.3.0.0)
	* AWS License Manager makes it easier to manage licenses in AWS and on premises when customers run applications using existing licenses from a variety of software vendors including Microsoft, SAP, Oracle, and IBM. AWS License Manager automatically tracks and controls license usage once administrators have created and enforced rules that emulate the terms of their licensing agreements. The capabilities of AWS License Manager are available through SDK and Tools, besides the management console and CLI.
* Lightsail (3.3.8.0)
	* This update adds the following features: 1. Copy instance and disk snapshots within the same AWS Region or from one region to another in Amazon Lightsail. 2. Export Lightsail instance and disk snapshots to Amazon Elastic Compute Cloud (Amazon EC2). 3. Create an Amazon EC2 instance from an exported Lightsail instance snapshot using AWS CloudFormation stacks. 4. Apply tags to filter your Lightsail resources, or organize your costs, or control access.
* SageMaker (3.3.16.0)
	* Amazon SageMaker now has Algorithm and Model Package entities that can be used to create Training Jobs, Hyperparameter Tuning Jobs and hosted Models. Subscribed Marketplace products can be used on SageMaker to create Training Jobs, Hyperparameter Tuning Jobs and Models. Notebook Instances and Endpoints can leverage Elastic Inference accelerator types for on-demand GPU computing. Model optimizations can be performed with Compilation Jobs. Labeling Jobs can be created and supported by a Workforce. Models can now contain up to 5 containers allowing for inference pipelines within Endpoints. Code Repositories (such as Git) can be linked with SageMaker and loaded into Notebook Instances. Network isolation is now possible on Models, Training Jobs, and Hyperparameter Tuning Jobs, which restricts inbound/outbound network calls for the container. However, containers can talk to their peers in distributed training mode within the same security group. A Public Beta Search API was added that currently supports Training Jobs.
* ServiceDiscovery (3.3.3.0)
	* AWS Cloud Map lets you define friendly names for your cloud resources so that your applications can quickly and dynamically discover them. When a resource becomes available (for example, an Amazon EC2 instance running a web server), you can register a Cloud Map service instance. Then your application can discover service instances by submitting DNS queries or API calls.

### 3.3.417.0 (2018-11-28 19:06 UTC)
* DynamoDBv2 (3.3.15.0)
	* Amazon DynamoDB now supports the following features: DynamoDB on-demand and transactions. DynamoDB on-demand is a flexible new billing option for DynamoDB capable of serving thousands of requests per second without capacity planning. DynamoDB on-demand offers simple pay-per-request pricing for read and write requests so that you only pay for what you use, making it easy to balance costs and performance. Transactions simplify the developer experience of making coordinated, all-or-nothing changes to multiple items both within and across tables. The new transactional APIs provide atomicity, consistency, isolation, and durability (ACID) in DynamoDB, helping developers support sophisticated workflows and business logic that requires adding, updating, or deleting multiple items using native, server-side transactions. For more information, see the Amazon DynamoDB Developer Guide.
* FSx (3.3.0.0)
	* Amazon FSx provides fully-managed third-party file systems optimized for a variety of enterprise and compute-intensive workloads.
* RDS (3.3.37.0)
	* Amazon Aurora Global Database. This release introduces support for Global Database, a feature that allows a single Amazon Aurora database to span multiple AWS regions. Customers can use the feature to replicate data with no impact on database performance, enable fast local reads with low latency in each region, and improve disaster recovery from region-wide outages. You can create, modify and describe an Aurora Global Database, as well as add or remove regions from your Global Database.
* SecurityHub (3.3.0.0)
	* AWS Security Hub is a security and compliance center that correlates AWS security findings and performs automated compliance checks

### 3.3.416.0 (2018-11-28 00:42 UTC)
* AWSMarketplaceMetering (3.3.2.0)
	* RegisterUsage operation added to AWS Marketplace Metering Service, allowing sellers to meter and entitle Docker container software use with AWS Marketplace. For details on integrating Docker containers with RegisterUsage see: https://docs.aws.amazon.com/marketplace/latest/userguide/entitlement-and-metering-for-paid-products.html
* CloudWatchLogs (3.3.7.0)
	* Six new APIs added to support CloudWatch Logs Insights. The APIs are StartQuery, StopQuery, GetQueryResults, GetLogRecord, GetLogGroupFields, and DescribeQueries.
* CodeDeploy (3.3.12.0)
	* Support for Amazon ECS service deployment - AWS CodeDeploy now supports the deployment of Amazon ECS services. An Amazon ECS deployment uses an Elastic Load Balancer, two Amazon ECS target groups, and a listener to reroute production traffic from your Amazon ECS service's original task set to a new replacement task set. The original task set is terminated when the deployment is complete. Success of a deployment can be validated using Lambda functions that are referenced by the deployment. This provides the opportunity to rollback if necessary. You can use the new ECSService, ECSTarget, and ECSTaskSet data types in the updated SDK to create or retrieve an Amazon ECS deployment.
* ComprehendMedical (3.3.0.0)
	* The first release of Comprehend Medical includes two APIs, detectPHI and detectEntities. DetectPHI extracts PHI from your clinical text, and detectEntities extracts entities such as medication, medical conditions, or anatomy. DetectEntities also extracts attributes (e.g. dosage for medication) and identifies contextual traits (e.g. negation) for each entity.
* EC2 (3.3.74.0)
	* With VPC sharing, you can now allow multiple accounts in the same AWS Organization to launch their application resources, like EC2 instances, RDS databases, and Redshift clusters into shared, centrally managed VPCs.
* ECS (3.3.21.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for blue/green deployment feature. Customers can now update their ECS services in a blue/green deployment pattern via using AWS CodeDeploy.
* KinesisAnalytics (3.3.5.0)
	* Improvements to error messages, validations, and more to the Kinesis Data Analytics APIs.
* KinesisAnalyticsV2 (3.3.0.0)
	* Amazon Kinesis Data Analytics now supports Java-based stream processing applications, in addition to the previously supported SQL. Now, you can use your own Java code in Amazon Kinesis Data Analytics to build and run stream processing applications. This new capability also comes with an update to the previous Amazon Kinesis Data Analytics APIs to enable support for different runtime environments and more.
* MediaConnect (3.3.0.0)
	* This is the initial release for AWS Elemental MediaConnect, an ingest and transport service for live video. This new AWS service allows broadcasters and content owners to send high-value live content into the cloud, securely transmit it to partners for distribution, and replicate it to multiple destinations around the globe.
* Translate (3.3.2.0)
	* This release includes the new custom terminology feature. Using custom terminology with your translation requests enables you to make sure that your brand names, character names, model names, and other unique content is translated exactly the way you need it, regardless of its context and the Amazon Translate algorithm's decision. See the documentation for more information.

### 3.3.415.0 (2018-11-27 05:11 UTC)
* EC2 (3.3.73.0)
	* Adds the following updates: 1. Transit Gateway helps easily scale connectivity across thousands of Amazon VPCs, AWS accounts, and on-premises networks. 2. Amazon EC2 A1 instance is a new Arm architecture based general purpose instance. 3. You can now launch the new Amazon EC2 compute optimized C5n instances that can utilize up to 100 Gbps of network bandwidth.
* GlobalAccelerator (3.3.0.0)
	* AWS Global Accelerator is a network layer service that helps you improve the availability and performance of the applications that you offer to your global customers. Global Accelerator uses the AWS global network to direct internet traffic from your users to your applications running in AWS Regions. Global Accelerator creates a fixed entry point for your applications through static anycast IP addresses, and routes user traffic to the optimal endpoint based on performance, application health and routing policies that you can configure. Global Accelerator supports the following features at launch: static anycast IP addresses, support for TCP and UDP, support for Network Load Balancers, Application Load Balancers and Elastic-IP address endpoints,  continuous health checking, instant regional failover, fault isolating Network Zones, granular traffic controls, and client affinity.
* Greengrass (3.3.5.0)
	* Support Greengrass Connectors and allow Lambda functions to run without Greengrass containers.
* IoT (3.3.22.0)
	* As part of this release, we are extending capability of AWS IoT Rules Engine to support IoT Events rule action. The IoT Events rule action lets you send messages from IoT sensors and applications to IoT Events for pattern recognition and event detection.
* IoTAnalytics (3.3.6.0)
	* Added an optional list of dataset content delivery configuration for CreateDataset and UpdateDataset. DescribeDataset will now include the list of delivery configuration, and will be an empty array if none exist.
* KeyManagementService (3.3.7.0)
	* AWS Key Management Service (KMS) now enables customers to create and manage dedicated, single-tenant key stores in addition to the default KMS key store. These are known as custom key stores and are deployed using AWS CloudHSM clusters. Keys that are created in a KMS custom key store can be used like any other customer master key in KMS.
* S3 (3.3.29.0)
	* Four new Amazon S3 Glacier features help you reduce your storage costs by making it even easier to build archival applications using the Amazon S3 Glacier storage class. S3 Object Lock enables customers to apply Write Once Read Many (WORM) protection to objects in S3 in order to prevent object deletion for a customer-defined retention period. S3 Inventory now supports fields for reporting on S3 Object Lock. "ObjectLockRetainUntilDate", "ObjectLockMode", and "ObjectLockLegalHoldStatus" are now available as valid optional fields.
* ServerMigrationService (3.3.1.0)
	* In this release, AWS Server Migration Service (SMS) has added multi-server migration support to simplify the application migration process. Customers can migrate all their application-specific servers together as a single unit as opposed to moving individual server one at a time. The new functionality includes - 1. Ability to group on-premises servers into applications and application tiers. 2. Auto-generated CloudFormation Template and Stacks for launching migrated servers into EC2. 3. Ability to run post-launch configuration scripts to configure servers and applications in EC2. In order for SMS to launch servers into your AWS account using CloudFormation Templates, we have also updated the ServerMigrationServiceRole IAM policy to include appropriate permissions. Refer to Server Migration Service documentation for more details. 

### 3.3.414.0 (2018-11-26 08:55 UTC)
* Amplify (3.3.0.0)
	* Release of AWS Amplify: Everything you need to develop & deploy cloud-powered mobile and web apps.
* DataSync (3.3.0.0)
	* AWS DataSync simplifies, automates, and accelerates moving and replicating data between on-premises storage and AWS services over the network.
* RoboMaker (3.3.0.0)
	* (New Service) AWS RoboMaker is a service that makes it easy to develop, simulate, and deploy intelligent robotics applications at scale. 
* S3 (3.3.28.0)
	* The INTELLIGENT_TIERING storage class is designed to optimize storage costs by automatically moving data to the most cost effective storage access tier, without performance impact or operational overhead. This SDK release provides API support for this new storage class.
* Snowball (3.3.5.0)
	* AWS announces the availability of AWS Snowball Edge Compute Optimized to run compute-intensive applications is disconnected and physically harsh environments. It comes with 52 vCPUs, 208GB memory, 8TB NVMe SSD, and 42TB S3-compatible storage to accelerate local processing and is well suited for use cases such as full motion video processing, deep IoT analytics, and continuous machine learning in bandwidth-constrained locations. It features new instances types called SBE-C instances that are available in eight sizes and multiple instances can be run on the device at the same time. Optionally, developers can choose the compute optimized device to include a GPU and use SBE-G instances for accelerating their application performance. 
* Transfer (3.3.0.0)
	* AWS Transfer for SFTP is a fully managed service that enables transfer of secure data over the internet into and out of Amazon S3. SFTP is deeply embedded in data exchange workflows across different industries such as financial services, healthcare, advertising, and retail, among others.

### 3.3.413.0 (2018-11-21 19:23 UTC)
* Rekognition (3.3.13.0)
	* This release updates the DetectFaces and IndexFaces operation. When the Attributes input parameter is set to ALL, the face location landmarks includes 5 new landmarks: upperJawlineLeft, midJawlineLeft, chinBottom, midJawlineRight, upperJawlineRight.

### 3.3.412.0 (2018-11-20 22:08 UTC)
* AppSync (3.3.4.0)
	* AWS AppSync now supports: 1. Pipeline Resolvers - Enables execution of one or more operations against multiple data sources in order, on a single GraphQL field. This allows orchestration of actions by composing code into a single Resolver, or share code across Resolvers.  2. Aurora Serverless Data Source - Built-in resolver for executing GraphQL operations with the new Aurora Serverless Data API, including connection management functionality.
* AutoScalingPlans (3.3.2.0)
	* In this release, AWS Auto Scaling adds three features: 1) Predictive scaling for EC2 Auto Scaling, which analyzes your application workload history to forecast future capacity requirements, 2) an option to replace existing scaling policies that are associated with the resources in your scaling plan, and 3) an option that allows you to use predictive scaling with or without your plan's dynamic scaling feature.
* CloudFront (3.3.11.0)
	* With Origin Failover capability in CloudFront, you can setup two origins for your distributions - primary and secondary, such that your content is served from your secondary origin if CloudFront detects that your primary origin is unavailable. These origins can be any combination of AWS origins or non-AWS custom HTTP origins. For example, you can have two Amazon S3 buckets that serve as your origin that you independently upload your content to. If an object that CloudFront requests from your primary bucket is not present or if connection to your primary bucket times-out, CloudFront will request the object from your secondary bucket. So, you can configure CloudFront to trigger a failover in response to either HTTP 4xx or 5xx status codes.
* CloudWatch (3.3.10.0)
	* Amazon CloudWatch now supports alarms on metric math expressions.
* DeviceFarm (3.3.10.0)
	* Disabling device filters
* MediaLive (3.3.12.0)
	* You can now include the media playlist(s) from both pipelines in the HLS master manifest for seamless failover.
* QuickSight (3.3.0.0)
	* Amazon QuickSight is a fully managed, serverless, cloud business intelligence system that allows you to extend data and insights to every user in your organization. The first release of APIs for Amazon QuickSight introduces embedding and user/group management capabilities. The get-dashboard-embed-url API allows you to obtain an authenticated dashboard URL that can be embedded in application domains whitelisted for QuickSight dashboard embedding. User APIs allow you to programmatically expand and manage your QuickSight deployments while group APIs allow easier permissions management for resources within QuickSight.
* RDSDataService (3.3.0.0)
	* The RDS Data API Beta is available for the MySQL-compatible edition of Amazon Aurora Serverless in the US East (N. Virginia) Region. This API enables you to easily access Aurora Serverless with web services-based applications including AWS Lambda and AWS AppSync.
* Redshift (3.3.11.2)
	* Documentation updates for redshift
* SimpleSystemsManagement (3.3.37.0)
	* AWS Systems Manager Distributor helps you securely distribute and install software packages.
* XRay (3.3.4.0)
	* Groups build upon X-Ray filter expressions to allow for fine tuning trace summaries and service graph results. You can configure groups by using the AWS X-Ray console or by using the CreateGroup API. The addition of groups has extended the available request fields to the GetServiceGraph API. You can now specify a group name or group ARN to retrieve its service graph.

### 3.3.411.0 (2018-11-20 00:58 UTC)
* Batch (3.3.7.0)
	* Adding multinode parallel jobs, placement group support for compute environments.
* CloudFormation (3.3.13.0)
	* Use the CAPABILITY_AUTO_EXPAND capability to create or update a stack directly from a stack template that contains macros, without first reviewing the resulting changes in a change set first.
* CloudTrail (3.3.4.0)
	* This release supports creating a trail in CloudTrail that logs events for all AWS accounts in an organization in AWS Organizations. This helps enable you to define a uniform event logging strategy for your organization. An organization trail is applied automatically to each account in the organization and cannot be modified by member accounts. To learn more, please see the AWS CloudTrail User Guide https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-user-guide.html
* ConfigService (3.3.22.0)
	* In this release, AWS Config adds support for aggregating the configuration data of AWS resources into multi-account and multi-region aggregators. AWS Config adds four APIs to query and retrieve aggregated resource configurations. 1) BatchGetAggregateResourceConfig, returns the current configuration items for resources that are present in your AWS Config aggregator. 2) GetAggregateDiscoveredResourceCounts, returns the resource counts across accounts and regions that are present in your AWS Config aggregator. 3) GetAggregateResourceConfig, returns current configuration item that is aggregated for your specific resource in a specific source account and region. 4) ListAggregateDiscoveredResources, accepts a resource type and returns a list of resource identifiers that are aggregated for a specific resource type across accounts and regions.
* DeviceFarm (3.3.9.0)
	* Customers can now schedule runs without a need to create a Device Pool. They also get realtime information on public device availability.
* EC2 (3.3.72.0)
	* Adding AvailabilityZoneId to DescribeAvailabilityZones
* IoT (3.3.21.0)
	* IoT now supports resource tagging and tag based access control for Billing Groups, Thing Groups, Thing Types, Jobs, and Security Profiles. IoT Billing Groups help you group devices to categorize and track your costs. AWS IoT Device Management also introduces three new features: 1. Dynamic thing groups. 2. Jobs dynamic rollouts. 3. Device connectivity indexing. Dynamic thing groups lets you to create a group of devices using a Fleet Indexing query. The devices in your group will be automatically added or removed when they match your specified query criteria. Jobs dynamic rollout allows you to configure an exponentially increasing rate of deployment for device updates and define failure criteria to cancel your job. Device connectivity indexing allows you to index your devices' lifecycle events to discover whether devices are connected or disconnected to AWS IoT.
* Lambda (3.3.18.0)
	* AWS Lambda now supports python3.7 and  the Kinesis Data Streams (KDS) enhanced fan-out and HTTP/2 data retrieval features for Kinesis event sources.
* Lightsail (3.3.7.17)
	* Add Managed Database operations to OperationType enum.
* MediaConvert (3.3.10.0)
	* AWS Elemental MediaConvert SDK has added several features including support for: SPEKE full document encryption, up to 150 elements for input stitching, input and motion image insertion, AWS CLI path arguments in S3 links including special characters, AFD signaling, additional caption types, and client-side encrypted input files.
* RDS (3.3.36.0)
	* This release adds a new parameter to specify VPC security groups for restore from DB snapshot, restore to point int time and create read replica operations. For more information, see Amazon RDS Documentation.
* WorkDocs (3.3.7.0)
	* With this release, clients can now use the GetResources API to fetch files and folders from the user's SharedWithMe collection. And also through this release, the existing DescribeActivities API has been enhanced to support additional filters such as the ActivityType and the ResourceId.
* WorkSpaces (3.3.5.0)
	* Added new APIs to Modify and Describe WorkSpaces client properties for users in a directory. With the new APIs, you can enable/disable remember me option in WorkSpaces client for users in a directory.

### 3.3.410.0 (2018-11-16 21:18 UTC)
* Comprehend (3.3.5.0)
	* Amazon Comprehend Custom Entities automatically trains entity recognition models using your entities and noun-based phrases. 
* CostExplorer (3.3.8.0)
	* This release introduces a new operation called GetCostForecast operation, which allows you to programmatically access AWS Cost Explorer's forecasting engine and is now generally available.
* ECS (3.3.20.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for additional Docker flags as Task Definition parameters. Customers can now configure their ECS Tasks to use pidMode (pid) and ipcMode (ipc) Docker flags.
* SimpleSystemsManagement (3.3.36.0)
	* AWS Systems Manager Automation now allows you to execute and manage Automation workflows across multiple accounts and regions. 
* WorkSpaces (3.3.4.0)
	* Added new Bring Your Own License (BYOL) automation APIs. With the new APIs, you can list available management CIDR ranges for dedicated tenancy, enable your account for BYOL, describe BYOL status of your account, and import BYOL images. Added new APIs to also describe and delete WorkSpaces images. 

### 3.3.409.1 (2018-11-16 04:28 UTC)
* Core 3.3.29.12
	* Fix bug with calling CognitoIdentityProvider's SignUp operation with temporary credentials. Add support for endpoint hostPrefix. Add slash encoding support for identifier values within service resource paths.
	* All services packages updated to require new Core

### 3.3.409.0 (2018-11-16 00:41 UTC)
* CodeBuild (3.3.18.0)
	* Adding queue phase and configurable queue timeout to CodeBuild.
* Comprehend (3.3.4.0)
	* Amazon Comprehend Custom Classification automatically trains classification models using your text and custom labels.
* DatabaseMigrationService (3.3.12.0)
	* Settings structures have been added to our DMS endpoint APIs to support Kinesis and Elasticsearch as targets. We are introducing the ability to configure custom DNS name servers on a replication instance as a beta feature. 
* DirectConnect (3.3.9.0)
	* This release enables DirectConnect customers to have logical redundancy on virtual interfaces within supported DirectConnect locations.
* ECS (3.3.19.0)
	* In this release, Amazon ECS introduces multiple features. First, ECS now supports integration with Systems Manager Parameter Store for injecting runtime secrets. Second, ECS introduces support for resources tagging. Finally, ECS introduces a new ARN and ID Format for its resources, and provides new APIs for opt-in to the new formats. 
* IdentityManagement (3.3.8.0)
	* We are making it easier for you to manage your AWS Identity and Access Management (IAM) resources by enabling you to add tags to your IAM principals (users and roles). Adding tags on IAM principals will enable you to write fewer policies for permissions management and make policies easier to comprehend.  Additionally, tags will also make it easier for you to grant access to AWS resources.
* Pinpoint (3.3.11.0)
	* 1. With Amazon Pinpoint Voice, you can use text-to-speech technology to deliver personalized voice messages to your customers. Amazon Pinpoint Voice is a great way to deliver transactional messages -- such as one-time passwords and identity confirmations -- to customers. 2. Adding support for Campaign Event Triggers. With Campaign Event Triggers you can now schedule campaigns to execute based on incoming event data and target just the source of the event.
* PinpointSMSVoice (3.3.0.0)
	* With Amazon Pinpoint Voice, you can use text-to-speech technology to deliver personalized voice messages to your customers. Amazon Pinpoint Voice is a way to deliver transactional messages -- such as one-time passwords and appointment confirmations to customers.
* RAM (3.3.0.0)
	* This is the initial release of AWS Resource Access Manager (RAM) which provides you the ability to share your resources across AWS accounts or within your AWS Organization. You can now create resources centrally and use AWS RAM to share those resources with other accounts, eliminating the need to provision and manage resources in every account. When you share a resource with another account, that account is granted access. Any policies and permissions in that account apply to the shared resource. 
* RDS (3.3.35.0)
	* Introduces DB Instance Automated Backups for the MySQL, MariaDB, PostgreSQL, Oracle and Microsoft SQL Server database engines. You can now retain Amazon RDS automated backups (system snapshots and transaction logs) when you delete a database instance. This allows you to restore a deleted database instance to a specified point in time within the backup retention period even after it has been deleted, protecting you against accidental deletion of data. For more information, see Amazon RDS Documentation.
* Redshift (3.3.11.0)
	* With this release, Redshift is providing API's for better snapshot management by supporting user defined automated snapshot schedules, retention periods for manual snapshots, and aggregate snapshot actions including batch deleting user snapshots, viewing account level snapshot storage metrics, and better filtering and sorting on the describe-cluster-snapshots API. Automated snapshots can be scheduled to be taken at a custom interval and the schedule created can be reused across clusters. Manual snapshot retention periods can be set at the cluster, snapshot, and cross-region-copy level. The retention period set on a manual snapshot indicates how many days the snapshot will be retained before being automatically deleted.
* Route53Resolver (3.3.0.0)
	* This is the first release of the Amazon Route 53 Resolver API.  Customers now have the ability to create and manage Amazon Route 53 Resolver endpoints and Amazon Route 53 Resolver rules. 
* S3 (3.3.27.0)
	* Add support for new S3 Block Public Access bucket-level APIs. The new Block Public Access settings allow bucket owners to prevent public access to S3 data via bucket/object ACLs or bucket policies.
* S3Control (3.3.0.0)
	* Add support for new S3 Block Public Access account-level APIs. The Block Public Access settings allow account owners to prevent public access to S3 data via bucket/object ACLs or bucket policies.
* TranscribeService (3.3.6.0)
	* With this release, Amazon Transcribe now publicly supports transcriptions from audio sources in British English (en-GB), Australian English (en-AU), and Canadian French (fr-CA). Amazon Transcribe now also supports the following languages in Private beta: Germany German (de-DE), Brazil Portuguese (pt-BR), France French (fr-FR).
* Core 3.3.29.11
	* Updating endpoints.json file
Add support for S3Control


	* All services packages updated to require new Core

### 3.3.408.0 (2018-11-14 22:39 UTC)
* AutoScaling (3.3.8.0)
	* EC2 Auto Scaling now allows users to provision and automatically scale instances across purchase options (Spot, On-Demand, and RIs) and instance types in a single Auto Scaling group (ASG).
* EC2 (3.3.71.0)
	* Amazon EC2 Fleet now supports a new request type "Instant" that you can use to provision capacity synchronously across instance types & purchase models and CreateFleet will return the instances launched in the API response.
* MediaTailor (3.3.2.0)
	* AWS Elemental MediaTailor SDK now returns a manifest endpoint prefix for clients to initiate a DASH playback session.
* ResourceGroups (3.3.3.0)
	* The AWS Resource Groups service added support for AWS CloudFormation stack-based groups.
* SageMaker (3.3.15.0)
	* SageMaker now makes the final set of metrics published from training jobs available in the DescribeTrainingJob results.  Automatic Model Tuning now supports warm start of hyperparameter tuning jobs.  Notebook instances now support a larger number of instance types to include instances from the ml.t3, ml.m5, ml.c4, ml.c5 families.
* ServiceCatalog (3.3.13.0)
	* Adds support for Cloudformation StackSets in Service Catalog
* SimpleNotificationService (3.3.3.0)
	* Added an optional request parameter, named Attributes, to the Amazon SNS CreateTopic API action. For more information, see the Amazon SNS API Reference (https://docs.aws.amazon.com/sns/latest/api/API_CreateTopic.html).
* Core 3.3.29.10
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.407.0 (2018-11-13 21:59 UTC)
* Budgets (3.3.10.1)
	* Doc Update: 1. Available monthly-budgets maximal history data points from 12 to 13.  2. Added 'Amazon Elasticsearch' costfilters support.
* Chime (3.3.1.0)
	* This release adds support in ListUsers API to filter the list by an email address.
* Redshift (3.3.10.0)
	* Amazon Redshift provides the option to defer non-mandatory maintenance updates to a later date.
* Core 3.3.29.9
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.406.0 (2018-11-13 00:33 UTC)
* Batch (3.3.6.0)
	* Adding EC2 Launch Template support in AWS Batch Compute Environments.
* Budgets (3.3.10.0)
	* 1. Added budget performance history, enabling you to see how well your budgets matched your actual costs and usage.                                                                                             2. Added budget performance history, notification state, and last updated time, enabling you to see how well your budgets matched your actual costs and usage, how often your budget alerts triggered, and when your budget was last updated.
* CloudFormation (3.3.12.0)
	* The Drift Detection feature enables customers to detect whether a stack's actual configuration differs, or has drifted, from its expected configuration as defined within AWS CloudFormation.
* CodePipeline (3.3.6.0)
	* Add support for cross-region pipeline with accompanying definitions as needed in the AWS CodePipeline API Guide.
* KinesisFirehose (3.3.7.0)
	* With this release, Amazon Kinesis Data Firehose allows you to enable/disable server-side encryption(SSE) for your delivery streams ensuring encryption of data at rest. For technical documentation, look at https://docs.aws.amazon.com/firehose/latest/dev/encryption.html
* Polly (3.3.9.0)
	* Amazon Polly adds new female voices: Italian - Bianca, Castilian Spanish - Lucia and new language: Mexican Spanish with new female voice - Mia.
* RDS (3.3.34.0)
	* API Update for RDS: this update enables Custom Endpoints, a new feature compatible with Aurora Mysql, Aurora PostgreSQL and Neptune that allows users to configure a customizable endpoint that will provide access to their instances in a cluster. 

### 3.3.405.0 (2018-11-09 22:01 UTC)
* MediaPackage (3.3.5.0)
	* As a part of SPEKE DRM encryption, MediaPackage now supports encrypted content keys. You can enable this enhanced content protection in an OriginEndpoint's encryption settings. When this is enabled, MediaPackage indicates to the key server that it requires an encrypted response. To use this, your DRM key provider must support content key encryption. For details on this feature, see the AWS MediaPackage User Guide at https://docs.aws.amazon.com/mediapackage/latest/ug/what-is.html.
* Core 3.3.29.8
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.404.0 (2018-11-09 02:57 UTC)
* CloudWatchEvents (3.3.7.10)
	* Documentation updates for events
* DLM (3.3.1.0)
	* Amazon Data Lifecycle Manager adds support for copying EBS volume tags to EBS snapshots. AWS resource tags allow customers to add metadata and apply access policies to your Amazon Elastic Block Store (Amazon EBS) resources. Starting today, customers can use Amazon Data Lifecycle Manager (DLM) to copy tags on EBS volumes to EBS snapshots. This allows customers to easily set snapshot metadata, such as access policies, to match the parent volume. Customers can enable this functionality on new or existing lifecycle policies. They can also choose to disable it at a future date.  
* MediaLive (3.3.11.0)
	* You can now switch a live channel between preconfigured inputs. This means assigned inputs for a running channel can be changed according to a defined schedule. You can also use MP4 files as inputs.
* Core 3.3.29.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.403.0 (2018-11-07 21:35 UTC)
* CostExplorer (3.3.7.0)
	* Enable Payer Accounts to View Linked Account Recommendations. Payer Accounts can specify "LINKED" as scope in the request now. In the response, there is a new filed called AccountId in ReservationPurchaseRecommendationDetail for indicating which account is this recommendation detail belongs to.
* DatabaseMigrationService (3.3.11.0)
	* Update the DMS TestConnectionSucceeds waiter.
* EC2 (3.3.70.0)
	* VM Import/Export now supports generating encrypted EBS snapshots, as well as AMIs backed by encrypted EBS snapshots during the import process.
* Core 3.3.29.6
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.402.0 (2018-11-06 23:16 UTC)
* APIGateway (3.3.23.0)
	* AWS WAF integration with APIGW. Changes for adding webAclArn as a part of  Stage output. When the user calls a get-stage or get-stages, webAclArn will also be returned as a part of the output.
* CodeBuild (3.3.17.10)
	* Documentation updates for codebuild
* EC2 (3.3.69.0)
	* You can now launch the new Amazon EC2 memory optimized R5a and general purpose M5a instances families that feature AMD EPYC processors.
* Pinpoint (3.3.10.0)
	* This update adds the ability to send transactional email by using the SendMessage API. Transactional emails are emails that you send directly to specific email addresses. Unlike campaign-based email that you send from Amazon Pinpoint, you don't have to create segments and campaigns in order to send transactional email.
* PinpointEmail (3.3.0.0)
	* This is the first release of the Amazon Pinpoint Email API. You can use this API to configure and send transactional email from your Amazon Pinpoint account to specific email addresses. Unlike campaign-based email that you send from Amazon Pinpoint, you don't have to create segments and campaigns in order to send transactional email. 
* WAFRegional (3.3.6.0)
	* You can now use AWS WAF to configure protections for your Amazon API Gateway APIs.  This will enable you to block (or count) undesired traffic to your APIs based on the different AWS WAF rules and conditions you create. For more information about AWS WAF, see the AWS WAF Developer Guide.
* Core 3.3.29.5
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.401.1 (2018-11-06 17:46 UTC)
* Core 3.3.29.4
	* Make IClientConfig.HttpClientFactory available in .NET standard SDK
	* All services packages updated to require new Core

### 3.3.401.0 (2018-11-05 23:11 UTC)
* EKS (3.3.2.0)
	* Adds waiters for ClusterActive and ClusterDeleted
* ServerlessApplicationRepository (3.3.3.0)
	* New AWS Serverless Application Repository APIs that support creating and reading a broader set of AWS CloudFormation templates, as well as enhancements to our existing APIs.

### 3.3.400.0 (2018-11-02 20:06 UTC)
* CloudDirectory (3.3.10.0)
	* ListObjectParents API now supports a bool parameter IncludeAllLinksToEachParent, which if set to true, will return a ParentLinks list instead of a Parents map; BatchRead API now supports ListObjectParents operation.
* Rekognition (3.3.12.0)
	* This release updates the DetectLabels operation. Bounding boxes are now returned for certain objects, a hierarchical taxonomy is now available for labels, and you can now get the version of the detection model used for detection.

### 3.3.399.0 (2018-11-01 22:29 UTC)
* ServiceCatalog (3.3.12.0)
	* Service Catalog integration with AWS Organizations, enables customers to more easily create and manage a portfolio of IT services across an organization. Administrators can now take advantage of the AWS account structure and account groupings configured in AWS Organizations to share Service Catalog Portfolios increasing agility and reducing risk. With this integration the admin user will leverage the trust relationship that exists within the accounts of the Organization to share portfolios to the entire Organization, a specific Organizational Unit or a specific Account.

### 3.3.398.0 (2018-10-31 21:06 UTC)
* ConfigService (3.3.21.0)
	* With this release, AWS Config updated the ResourceType values. The updated list includes AWS Systems Manager AssociationCompliance and PatchCompliance, AWS Shield regional Protection, AWS Config ResourceCompliance, and AWS CodePipeline Pipeline.
* Greengrass (3.3.4.0)
	* Greengrass APIs now support bulk deployment operations, and APIs that list definition versions now support pagination.
* MediaStoreData (3.3.1.0)
	* The object size limit is increased from 10MB to 25MB and the content type is more permissive.
* SecretsManager (3.3.2.19)
	* Documentation updates for AWS Secrets Manager.

### 3.3.397.0 (2018-10-30 22:04 UTC)
* Chime (3.3.0.0)
	* This is the initial release for the Amazon Chime AWS SDK. In this release, Amazon Chime adds support for administrative actions on users and accounts. API Documentation is also updated on https://docs.aws.amazon.com/chime/index.html
* DatabaseMigrationService (3.3.10.0)
	* Add waiters for TestConnectionSucceeds, EndpointDeleted, ReplicationInstanceAvailable, ReplicationInstanceDeleted, ReplicationTaskReady, ReplicationTaskStopped, ReplicationTaskRunning and ReplicationTaskDeleted.
* RDS (3.3.33.0)
	* This release adds the listener connection endpoint for SQL Server Always On to the list of fields returned when performing a describe-db-instances operation.
* Core 3.3.29.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.396.2 (2018-10-29 20:45 UTC)
* Core 3.3.29.2
	* Allow PCL users to manually create HttpClients to be used by service clients in the SDK.
	* All services packages updated to require new Core

### 3.3.396.1 (2018-10-29 16:36 UTC)
* Core 3.3.29.1
	* Allow PCL users to manually create HttpClients to be used by service clients in the SDK.
	* All services packages updated to require new Core

### 3.3.396.0 (2018-10-26 20:02 UTC)
* AlexaForBusiness (3.3.6.2)
	* Documentation updates for AWS Alexa for Business
* SageMaker (3.3.14.0)
	* SageMaker notebook instances can now have a volume size configured.
* SimpleSystemsManagement (3.3.35.0)
	* Compliance Severity feature release for State Manager. Users now have the ability to select compliance severity to their association in state manager console or CLI.

### 3.3.395.0 (2018-10-26 17:53 UTC)
* Core 3.3.29.0
	* Code for future SDK instrumentation and telemetry.
	* All services packages updated to require new Core

### 3.3.394.0 (2018-10-25 18:59 UTC)
* EC2 (3.3.68.0)
	* As part of this release we are introducing EC2 On-Demand Capacity Reservations. With On-Demand Capacity Reservations, customers can reserve the exact EC2 capacity they need, and can keep it only for as long as they need it.

### 3.3.393.0 (2018-10-24 19:20 UTC)
* AlexaForBusiness (3.3.6.0)
	* We extended the functionality of the Alexa for Business SDK, including additional support for third-party Alexa built-in devices, managing private and public skills, and conferencing setup.
* CodeStar (3.3.3.0)
	* This release lets you create projects from source code and a toolchain definition that you provide.

### 3.3.392.0 (2018-10-23 20:09 UTC)
* EC2 (3.3.67.0)
	* Provides customers the ability to Bring Your Own IP (BYOIP) prefix.  You can bring part or all of your public IPv4 address range from your on-premises network to your AWS account. You continue to own the address range, but AWS advertises it on the internet.

### 3.3.391.0 (2018-10-22 21:38 UTC)
* Inspector (3.3.8.0)
	* Finding will be decorated with ec2 related metadata
* Shield (3.3.4.0)
	* AWS Shield Advanced API introduced a new service-specific AccessDeniedException which will be thrown when accessing individual attack information without sufficient permission.
* Core 3.3.28.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.390.0 (2018-10-22 16:20 UTC)
* AutoScaling (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* CloudWatch (3.3.9.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* EC2 (3.3.66.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* ElastiCache (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* ElasticBeanstalk (3.3.11.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoT (3.3.20.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoT1ClickDevicesService (3.3.1.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* IoTAnalytics (3.3.5.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* MobileAnalytics (3.3.2.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Neptune (3.3.4.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* RDS (3.3.32.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Redshift (3.3.9.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* S3 (3.3.26.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* SimpleEmail (3.3.7.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* SimpleNotificationService (3.3.2.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* WorkDocs (3.3.6.0)
	* Updated to use new Core, version 3.3.28.0
	* Deprecated properties resulting in non-Universal DateTime values being handled as if they were Universal. Created new replacement properties that honor the DateTimeKind, such properties are marked with the "Utc" suffix. All DateTime properties now consider DateTime values of type Unspecified as if they were Local.
* Core 3.3.28.0
	* Update to support DateTime serialization fixes in service libraries.
	* All services packages updated to require new Core

### 3.3.389.0 (2018-10-19 20:49 UTC)
* SimpleSystemsManagement (3.3.34.0)
	* Rate Control feature release for State Manager. Users now have the ability to apply rate control parameters similar to run command to their association in state manager console or CLI.
* WorkSpaces (3.3.3.0)
	* Added support for PowerPro and GraphicsPro WorkSpaces bundles.

### 3.3.388.0 (2018-10-18 21:32 UTC)
* AppStream (3.3.19.0)
	* This API update adds support for creating, managing, and deleting users in the AppStream 2.0 user pool.
* MediaLive (3.3.10.0)
	* This release allows you to now turn on Quality-Defined Variable Bitrate (QVBR) encoding for your AWS Elemental MediaLive channels. You can now deliver a consistently high-quality video viewing experience while reducing overall distribution bitrates by using Quality-Defined Variable Bitrate (QVBR) encoding with AWS Elemental MediaLive. QVBR is a video compression technique that automatically adjusts output bitrates to the complexity of source content and only use the bits required to maintain a defined level of quality. This means using QVBR encoding, you can save on distribution cost, while maintaining, or increasing video quality for your viewers.
* Route53 (3.3.17.0)
	* This change allows customers to disable health checks.

### 3.3.387.0 (2018-10-17 20:41 UTC)
* APIGateway (3.3.22.3)
	* Documentation updates for API Gateway
* CloudWatchEvents (3.3.7.0)
	* AWS Events - AWS Organizations Support in Event-Bus Policies. This release introduces a new parameter in the PutPermission API named Condition. Using the Condition parameter, customers can allow one or more AWS Organizations to access their CloudWatch Events Event-Bus resource.

### 3.3.386.0 (2018-10-17 18:09 UTC)
* Lambda (3.3.17.0)
	* Enables TCP keepalive as default in Lambda.
* S3 (3.3.25.1)
	* Fixed incorrect marshalling of S3 tag.
* Core 3.3.27.3
	* Referencing the CredentialProfileStoreChain constructor that takes in the profile location on AWSConfigs. Make code more defensive looking for CSM configuration. 
	* All services packages updated to require new Core

### 3.3.385.0 (2018-10-17 00:57 UTC)
* Glue (3.3.15.0)
	* New Glue APIs for creating, updating, reading and deleting Data Catalog resource-based policies.
* Lightsail (3.3.7.0)
	* Adds support for Lightsail managed databases.
* ResourceGroups (3.3.2.0)
	* AWS Resource Groups service added a new feature to filter resource groups by resource-type when using the ListGroups operation.

### 3.3.384.0 (2018-10-15 21:19 UTC)
* Lambda (3.3.16.6)
	* Documentation updates for lambda
* RDS (3.3.31.0)
	* This release adds a new parameter to specify the DB instance or cluster parameter group for restore from DB snapshot and restore to point int time operations. For more information, see Amazon RDS Documentation.
* ServiceCatalog (3.3.11.0)
	* AWS Service Catalog enables you to reduce administrative maintenance and end-user training while adhering to compliance and security measures. With service actions, you as the administrator can enable end users to perform operational tasks, troubleshoot issues, run approved commands, or request permissions within Service Catalog. Service actions are defined using AWS Systems Manager documents, where you have access to pre-defined actions that implement AWS best practices, such asEC2 stop and reboot, as well as the ability to define custom actions.

### 3.3.383.0 (2018-10-12 21:46 UTC)
* CloudTrail (3.3.3.0)
	* The LookupEvents API now supports two new attribute keys: ReadOnly and AccessKeyId

### 3.3.382.0 (2018-10-12 17:01 UTC)
* MobileAnalytics (3.3.1.44)
	* Fixed bugs in handling attributes of CustomEvent.
Fixed NullReferenceException in DeliveryClient.AttemptDeliveryAsync()
* S3 (3.3.25.0)
	* Changed service client to throw an exception when operations are called without a required BucketName or Key parameter.
Changed service client to resign request on retries.
* Core 3.3.27.2
	* Changed the exception thrown by ClientContext constructor to be more descriptive.

### 3.3.381.0 (2018-10-11 22:56 UTC)
* Athena (3.3.1.0)
	* 1. GetQueryExecution API changes to return statementType of a submitted Athena query.  2. GetQueryResults API changes to return the number of rows added to a table when a CTAS query is executed.
* DirectConnect (3.3.8.0)
	* This release adds support for Jumbo Frames over AWS Direct Connect. You can now set MTU value when creating new virtual interfaces. This release also includes a new API to modify MTU value of existing virtual interfaces.
* EC2 (3.3.65.0)
	* You can now launch the smaller-sized G3 instance called g3s.xlarge. G3s.xlarge provides 4 vCPU, 30.5 GB RAM and a NVIDIA Tesla M60 GPU. It is ideal for remote workstations, engineering and architectural applications, and 3D visualizations and rendering for visual effects.
* TranscribeService (3.3.5.0)
	* With this release, Amazon Transcribe now supports transcriptions from audio sources in British English (en-UK), Australian English (en-AU), and Canadian French (fr-CA).

### 3.3.380.0 (2018-10-10 22:51 UTC)
* Comprehend (3.3.3.0)
	* This release adds French, Italian, German and Portuguese language support for all existing synchronous and asynchronous APIs
* Elasticsearch (3.3.10.0)
	* Amazon Elasticsearch Service now supports customer-scheduled service software updates. When new service software becomes available, you can request an update to your domain and benefit from new features more quickly. If you take no action, we update the service software automatically after a certain time frame.
* TranscribeService (3.3.4.0)
	* With this update Amazon Transcribe now supports deleting completed transcription jobs. 

### 3.3.379.1 (2018-10-10 02:29 UTC)
* S3 (3.3.24.4)
	* Updated to use new Core, version 3.3.27.1
	* Fixed bug parsing event stream used by S3's Select operation.
* Core 3.3.27.1
	* Fixed bug parsing event stream used by S3's Select operation.

### 3.3.379.0 (2018-10-09 20:36 UTC)
* SimpleSystemsManagement (3.3.33.0)
	* Adds StartDate, EndDate, and ScheduleTimezone to CreateMaintenanceWindow and UpdateMaintenanceWindow; Adds NextExecutionTime to GetMaintenanceWindow and DescribeMaintenanceWindows; Adds CancelMaintenanceWindowExecution, DescribeMaintenanceWindowSchedule and DescribeMaintenanceWindowsForTarget APIs.

### 3.3.378.0 (2018-10-08 20:08 UTC)
* IoT (3.3.19.0)
	* We are releasing job execution timeout functionalities to customers. Customer now can set job execution timeout on the job level when creating a job. 
* IoTJobsDataPlane (3.3.1.0)
	* We are releasing job execution timeout functionalities to customers. Device can now set and update their job execution timeout. 

### 3.3.377.0 (2018-10-06 01:28 UTC)
* Core 3.3.27.0
	* Fix to rectify breaking change that was introduced in v3.3.26 of AWSSDK.Core nuget package. Customer should update to this version of the AWSSDK.Core nuget package.
	* All services packages updated to require new Core

### 3.3.376.0 (2018-10-05 21:07 UTC)
* DirectoryService (3.3.8.0)
	* SDK changes to create a new type of trust for active directory

### 3.3.375.0 (2018-10-04 22:55 UTC)
* APIGateway (3.3.22.0)
	* Adding support for multi-value parameters in TestInvokeMethod and TestInvokeAuthorizer.
* CodeBuild (3.3.17.0)
	* Add resolved source version field in build output
* SimpleSystemsManagement (3.3.32.0)
	*  Adds RejectedPatchesAction to baseline to enable stricted validation of the rejected Patches List ; Add InstalledRejected and InstallOverrideList to compliance reporting
* StorageGateway (3.3.11.0)
	* AWS Storage Gateway now enables you to specify folders and subfolders when you update your file gateway's view of your S3 objects using the Refresh Cache API.

### 3.3.374.0 (2018-10-03 23:53 UTC)
* CloudFront (3.3.10.5)
	* Fixed client throwing NullReferenceException instead of AmazonCloudFrontException when requests are performed without specifying certain missing required properties.
* Core 3.3.26.0
	* Code for future SDK instrumentation and telemetry
Add credential_source parameter in the shared credentials file
Correct Metric.ProxyHost setup
	* All services packages updated to require new Core

### 3.3.373.0 (2018-10-02 21:12 UTC)
* SageMaker (3.3.13.0)
	* Waiter for SageMaker Batch Transform Jobs.
* SecretsManager (3.3.2.9)
	* Documentation updates for secretsmanager

### 3.3.372.0 (2018-10-01 22:10 UTC)
* GuardDuty (3.3.5.0)
	* Support optional FindingPublishingFrequency parameter in CreateDetector and UpdateDetector operations, and ClientToken on Create* operations
* Rekognition (3.3.11.2)
	* Documentation updates for Amazon Rekognition

### 3.3.371.0 (2018-09-28 18:48 UTC)
* CodeStar (3.3.2.0)
	* This release enables tagging CodeStar Projects at creation. The CreateProject API now includes optional tags parameter.
* EC2 (3.3.64.0)
	* You can now use EC2 High Memory instances with 6 TiB memory (u-6tb1.metal), 9 TiB memory (u-9tb1.metal), and 12 TiB memory (u-12tb1.metal), which are ideal for running large in-memory databases, including production deployments of SAP HANA. These instances offer 448 logical processors, where each logical processor is a hyperthread on 224 cores. These instance deliver high networking throughput and lower latency with up to 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking. These instances are EBS-Optimized by default, and support encrypted and unencrypted EBS volumes. This instance is only available in host-tenancy. You will need an EC2 Dedicated Host for this instance type to launch an instance.

### 3.3.370.0 (2018-09-27 19:54 UTC)
* APIGateway (3.3.21.0)
	* Adding support for OpenAPI 3.0 import and export.
* CodeCommit (3.3.6.0)
	* This release adds API support for getting the contents of a file, getting the contents of a folder, and for deleting a file in an AWS CodeCommit repository.
* MQ (3.3.2.0)
	* Amazon MQ supports ActiveMQ 5.15.6, in addition to 5.15.0. Automatic minor version upgrades can be toggled. Updated the documentation.

### 3.3.369.0 (2018-09-26 21:15 UTC)
* Glue (3.3.14.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.
* OpsWorksCM (3.3.6.0)
	* This release introduces a new API called ExportServerEngineAttribute to Opsworks-CM. You can use this API call to export engine specific attributes like the UserData script used for unattended bootstrapping of new nodes that connect to the server. 
* RDS (3.3.30.0)
	* This release includes Deletion Protection for RDS databases.
* SQS (3.3.3.20)
	* Documentation updates for Amazon SQS.
* Core 3.3.25.4
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.368.0 (2018-09-25 20:16 UTC)
* CloudFront (3.3.10.3)
	* Documentation updates for cloudfront
* DirectoryService (3.3.7.0)
	* API changes related to launch of cross account for Directory Service.
* EC2 (3.3.63.0)
	* Add pagination support for ec2.describe-route-tables API. 

### 3.3.367.0 (2018-09-24 21:20 UTC)
* Connect (3.3.3.0)
	* This update adds the Amazon Connect Metrics API, which lets you get current metric data and historical metric data within 24 hours for the queues in your Amazon Connect instance.
* RDS (3.3.29.0)
	*  Adds DB engine version requirements for option group option settings, and specifies if an option setting requires a value.

### 3.3.366.0 (2018-09-21 20:31 UTC)
* MediaConvert (3.3.9.0)
	* To offer lower prices for predictable, non-urgent workloads, we propose the concept of Reserved Transcode pricing. Reserved Transcode pricing Reserved Transcoding pricing would offer the customer access to a fixed parallel processing capacity for a fixed monthly rate. This capacity would be stated in terms of number of Reserved Transcode Slots (RTSs). One RTS would be able to process one job at a time for a fixed monthly fee.

### 3.3.365.0 (2018-09-20 21:23 UTC)
* DirectoryService (3.3.6.0)
	* Added CreateLogSubscription, DeleteLogSubscription, and ListLogSubscriptions APIs for Microsoft AD. Customers can now opt in to have Windows security event logs from the domain controllers forwarded to a log group in their account.
* EC2 (3.3.62.0)
	* You can now launch f1.4xlarge, a new instance size within the existing f1 family which provides two Xilinx Virtex Field Programmable Arrays (FPGAs) for acceleration. FPGA acceleration provide additional performance and time sensitivity for specialized accelerated workloads such as clinical genomics and real-time video processing. F1.4xlarge instances are available in the US East (N. Virginia), US West (Oregon), GovCloud (US), and EU West (Dublin) AWS Regions.
* RDS (3.3.28.0)
	* This launch enables RDS start-db-cluster and stop-db-cluster. Stopping and starting Amazon Aurora clusters helps you manage costs for development and test environments. You can temporarily stop all the DB instances in your cluster, instead of setting up and tearing down all the DB instances each time that you use the cluster.

### 3.3.364.0 (2018-09-19 18:33 UTC)
* CloudWatch (3.3.8.0)
	* Amazon CloudWatch adds the ability to request png image snapshots of metric widgets using the GetMetricWidgetImage API.
* Organizations (3.3.9.0)
	* Introducing a new exception - AccountOwnerNotVerifiedException which will be returned for InviteAccountToOrganization call for unverified accounts.
* S3 (3.3.24.0)
	* S3 Cross Region Replication now allows customers to use S3 object tags to filter the scope of replication. By using S3 object tags, customers can identify individual objects for replication across AWS Regions for compliance and data protection. Cross Region Replication for S3 enables automatic and asynchronous replication of objects to another AWS Region, and with this release customers can replicate at a bucket level, prefix level or by using object tags.

### 3.3.363.0 (2018-09-18 21:35 UTC)
* Elasticsearch (3.3.9.0)
	* Amazon Elasticsearch Service adds support for node-to-node encryption for new domains running Elasticsearch version 6.0 and above
* Rekognition (3.3.11.0)
	* This release updates the Amazon Rekognition IndexFaces API operation. It introduces a QualityFilter parameter that allows you to automatically filter out detected faces that are deemed to be of low quality by Amazon Rekognition. The quality bar is based on a variety of common use cases.  You can filter low-quality detected faces by setting QualityFilter to AUTO, which is also the default setting. To index all detected faces regardless of quality, you can specify NONE.  This release also provides a MaxFaces parameter that is useful when you want to only index the most prominent and largest faces in an image and don't want to index other faces detected in the image, such as smaller faces belonging to people standing in the background.

### 3.3.362.0 (2018-09-17 21:41 UTC)
* CloudWatch (3.3.7.0)
	* Amazon CloudWatch adds the ability to publish values and counts using PutMetricData
* CodeBuild (3.3.16.0)
	* Support build logs configuration.
* EC2 (3.3.61.0)
	* Added support for customers to tag EC2 Dedicated Hosts on creation.
* ECS (3.3.18.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for additional Docker flags as Task Definition parameters. Customers can now configure their ECS Tasks to use systemControls (sysctl), pseudoTerminal (tty), and interactive (i) Docker flags.
* ElastiCache (3.3.6.0)
	* ElastiCache for Redis added support for adding and removing read-replicas from any cluster with no cluster downtime, Shard naming: ElastiCache for Redis customers have the option of allowing ElastiCache to create names for their node groups (shards) or generating their own node group names. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_NodeGroupConfiguration.html, ShardsToRetain: When reducing the number of node groups (shards) in an ElastiCache for Redis (cluster mode enabled) you have the option of specifying which node groups to retain or which node groups to remove. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyReplicationGroupShardConfiguration.html, ReservationARN: ReservedNode includes an ARN, ReservationARN, member which identifies the reserved node. For more information, see https:// docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ReservedCacheNode.html
* ElasticTranscoder (3.3.3.0)
	* Added support for MP2 container
* SecretsManager (3.3.2.7)
	* Documentation updates for secretsmanager

### 3.3.361.0 (2018-09-13 18:37 UTC)
* Polly (3.3.8.0)
	* Amazon Polly adds Mandarin Chinese language support with new female voice - "Zhiyu"

### 3.3.360.0 (2018-09-12 20:09 UTC)
* Connect (3.3.2.0)
	* This update adds the Amazon Connect Update Contact Attributes API, which lets you update contact attributes for contacts in your Amazon Connect instance.
* EC2 (3.3.60.0)
	* Pagination Support for DescribeNetworkInterfaces API
* FMS (3.3.1.0)
	* This update of Amazon Fire Wall Manager adds the ability to scope down the policy as well as to get all the member accounts belonging to a certain Fire Wall Manager admin account.
* SimpleEmail (3.3.6.20)
	* Documentation updates for Amazon Simple Email Service

### 3.3.359.0 (2018-09-11 18:10 UTC)
* OpsWorksCM (3.3.5.3)
	* Documentation updates for opsworkscm
* SimpleSystemsManagement (3.3.31.0)
	* Session Manager is a fully managed AWS Systems Manager capability that provides interactive one-click access to Amazon EC2 Linux and Windows instances.

### 3.3.358.0 (2018-09-10 21:55 UTC)
* CloudHSMV2 (3.3.3.0)
	* With this release, we are adding 2 new APIs. DeleteBackup deletes a specified AWS CloudHSM backup. A backup can be restored up to 7 days after the DeleteBackup request. During this 7-day period, the backup will be in state PENDING_DELETION. Backups can be restored using the RestoreBackup API, which will move the backup from state PENDING_DELETION back to ACTIVE.
* Redshift (3.3.8.0)
	* Adding support to Redshift to change the encryption type after cluster creation completes.
* Core 3.3.25.3
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.357.0 (2018-09-07 20:09 UTC)
* CloudWatchLogs (3.3.6.0)
	* * Adding a log prefix parameter for filter log events API and minor updates to the documentation
* ConfigService (3.3.20.0)
	* Adding a new field "createdBy" to the ConfigRule data model. The field is populated only if the rule is service linked i.e the rule is created by a service. The field is empty for normal rules created by customer.

### 3.3.356.0 (2018-09-07 00:42 UTC)
* APIGateway (3.3.20.0)
	* Add support for Active X-Ray with API Gateway
* CodeCommit (3.3.5.0)
	* This release adds additional optional fields to the pull request APIs.
* MediaConvert (3.3.8.0)
	* This release adds support for Cost Allocation through tagging and also enables adding, editing, and removal of tags from the MediaConvert console.
* Core 3.3.25.2
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.355.0 (2018-09-05 21:05 UTC)
* AppStream (3.3.18.0)
	* Added support for enabling persistent application settings for a stack. When these settings are enabled, changes that users make to applications and Windows settings are automatically saved after each session and applied to the next session.
* DynamoDBv2 (3.3.14.0)
	* New feature for Amazon DynamoDB.
* ElasticLoadBalancing (3.3.3.0)
	* Documentation update for DescribeAccountLimits API to include classic-registered-instances.
* RDS (3.3.27.6)
	* Fix broken links in the RDS CLI Reference to the Aurora User Guide
* S3 (3.3.23.0)
	* Parquet input format support added for the SelectObjectContent API

### 3.3.354.0 (2018-09-05 18:30 UTC)
* ApplicationDiscoveryService (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.
* AppStream (3.3.17.0)
	* Added Obsolete attribute for deprecated properties.
* AutoScaling (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* CloudFront (3.3.10.0)
	* Added Obsolete attribute for deprecated properties.
* CloudTrail (3.3.2.0)
	* Added Obsolete attribute for deprecated properties.
* CodeDeploy (3.3.11.0)
	* Added Obsolete attribute for deprecated properties.
* DatabaseMigrationService (3.3.9.0)
	* Added Obsolete attribute for deprecated properties.
* DirectConnect (3.3.7.0)
	* Added Obsolete attribute for deprecated properties.
* ElasticMapReduce (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* ElasticTranscoder (3.3.2.0)
	* Added Obsolete attribute for deprecated properties.
* IoT (3.3.18.0)
	* Added Obsolete attribute for deprecated properties.
* KinesisFirehose (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* Lambda (3.3.16.0)
	* Added Obsolete attribute for deprecated properties.
* Lightsail (3.3.6.0)
	* Added Obsolete attribute for deprecated properties.
* MediaLive (3.3.9.0)
	* Added Obsolete attribute for deprecated properties.
* MediaPackage (3.3.4.0)
	* Added Obsolete attribute for deprecated properties.
* MTurk (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* Neptune (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* OpsWorksCM (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.
* Route53 (3.3.16.0)
	* Added Obsolete attribute for deprecated properties.
* Route53Domains (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* S3 (3.3.22.0)
	* Added Obsolete attribute for deprecated properties.
* Shield (3.3.3.0)
	* Added Obsolete attribute for deprecated properties.
* WorkDocs (3.3.5.0)
	* Added Obsolete attribute for deprecated properties.

### 3.3.353.0 (2018-09-04 21:04 UTC)
* RDS (3.3.27.5)
	* Updating cross references for the new Aurora User Guide.
* Rekognition (3.3.10.0)
	* This release introduces a new API called DescribeCollection to Amazon Rekognition. You can use DescribeCollection to get information about an existing face collection. Given the ID for a face collection, DescribeCollection returns the following information: the number of faces indexed into the collection, the version of the face detection model used by the collection, the Amazon Resource Name (ARN) of the collection and the creation date/time of the collection.

### 3.3.352.0 (2018-08-31 21:53 UTC)
* EKS (3.3.1.0)
	* Amazon EKS DescribeCluster API returns a platformVersion attribute which allows you to identify the features that are currently enabled for your clusters. The Amazon EKS platform version represents capabilities of the cluster control plane, such as which Kubernetes API server flags are enabled, as well as the current Kubernetes patch version. 
* WAF (3.3.6.0)
	* This change includes support for the WAF FullLogging feature through which Customers will have access to all the logs of requests that are inspected by a WAF WebACL. The new APIs allow Customers to manage association of a WebACL with one or more supported "LogDestination" and redact any request fields from the logs. 
* WAFRegional (3.3.5.0)
	* This change includes support for the WAF FullLogging feature through which Customers will have access to all the logs of requests that are inspected by a WAF WebACL. The new APIs allow Customers to manage association of a WebACL with one or more supported "LogDestination" and redact any request fields from the logs. 

### 3.3.351.0 (2018-08-30 19:17 UTC)
* CodeBuild (3.3.15.0)
	* Support multiple sources and artifacts for CodeBuild projects. 
* SageMaker (3.3.12.0)
	* VolumeKmsKeyId now available in Batch Transform Job 

### 3.3.350.0 (2018-08-29 20:08 UTC)
* Glue (3.3.13.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.
* MediaPackage (3.3.3.0)
	* MediaPackage now provides input redundancy. Channels have two ingest endpoints that can receive input from encoders. OriginEndpoints pick one of the inputs receiving content for playback and automatically switch to the other input if the active input stops receiving content. Refer to the User Guide (https://docs.aws.amazon.com/mediapackage/latest/ug/what-is.html) for more details on this feature.
* SageMakerRuntime (3.3.1.0)
	* SageMaker Runtime supports CustomAttributes header which allows customers provide additional information in a request for an inference submitted to a model or in the response about the inference returned by a model hosted at an Amazon SageMaker endpoint.

### 3.3.349.0 (2018-08-28 19:43 UTC)
* Glue (3.3.12.0)
	* New Glue APIs for creating, updating, reading and deleting Data Catalog resource-based policies.
* XRay (3.3.3.0)
	* Support for new APIs that enable management of sampling rules.

### 3.3.348.0 (2018-08-27 22:49 UTC)
* IoT (3.3.17.0)
	* This release adds support to create a Stream and Code signing for Amazon FreeRTOS job along with Over-the-air updates.
* IoTAnalytics (3.3.4.0)
	* Added new listDatasetContent API that shows you the list of dataset contents for the corresponding versions
* Redshift (3.3.7.1)
	* Documentation updates for redshift
* signer (3.3.0.0)
	* AWS Signer is a new feature that allows Amazon FreeRTOS (AFR) Over The Air (OTA) customers to cryptographically sign code using code-signing certificates managed by AWS Certificate Manager. 
* Core 3.3.25.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.347.0 (2018-08-25 00:50 UTC)
* Glue (3.3.11.0)
	* AWS Glue now supports data encryption at rest for ETL jobs and development endpoints. With encryption enabled, when you run ETL jobs, or development endpoints, Glue will use AWS KMS keys to write encrypted data at rest. You can also encrypt the metadata stored in the Glue Data Catalog using keys that you manage with AWS KMS. Additionally, you can use AWS KMS keys to encrypt the logs generated by crawlers and ETL jobs as well as encrypt ETL job bookmarks. Encryption settings for Glue crawlers, ETL jobs, and development endpoints can be configured using the security configurations in Glue. Glue Data Catalog encryption can be enabled via the settings for the Glue Data Catalog.

### 3.3.346.0 (2018-08-24 17:52 UTC)
* CloudWatchEvents (3.3.6.0)
	* Added Fargate and NetworkConfiguration support to EcsParameters.
* CognitoIdentityProvider (3.3.11.0)
	* Amazon Cognito now has API support for creating custom domains for our hosted UI for User Pools.

### 3.3.345.0 (2018-08-24 00:12 UTC)
* S3 (3.3.21.0)
	* Implement support for user-specified byte-ranged in S3's GetObject (https://github.com/aws/aws-sdk-net/pull/999)
* Core 3.3.25.0
	* Allow specifying a proxy for HTTP downloads which are not related to service interaction

### 3.3.344.0 (2018-08-23 20:55 UTC)
* IoT (3.3.16.0)
	* This release adds support for IoT Thing Group Indexing and Searching functionality.
* IoTAnalytics (3.3.3.0)
	* AWS IoT Analytics announces three new features:  (1) Bring Your Custom Container - import your custom authored code containers. (2) Automate Container Execution - lets you automate the execution of containers hosting custom authored analytical code or Jupyter Notebooks to perform continuous analysis. (3) Incremental Data Capture with Customizable Time Windows - enables users to perform analysis on new incremental data captured since the last analysis.
* LexModelBuildingService (3.3.7.0)
	* Amazon Lex builds bot in two stages. After the first it sets status to READY_BASIC_TESTING. In this state the bot will match user inputs that exactly match the utterances configured for the bot's intents and values in the slot types. 
* MediaLive (3.3.8.0)
	* Adds two APIs for working with Channel Schedules: BatchUpdateSchedule and DescribeSchedule. These APIs allow scheduling actions for SCTE-35 message insertion and for static image overlays.
* Rekognition (3.3.9.0)
	* This release introduces a new API called DescribeCollection to Amazon Rekognition.  You can use DescribeCollection to get information about an existing face collection. Given the ID for a face collection, DescribeCollection returns the following information: the number of faces indexed into the collection, the version of the face detection model used by the collection, the Amazon Resource Name (ARN) of the collection and the creation date/time of the collection.

### 3.3.343.0 (2018-08-22 20:29 UTC)
* Snowball (3.3.4.0)
	* Snowball job states allow customers to track the status of the Snowball job. We are launching a new Snowball job state "WithSortingFacility"!  When customer returns the Snowball to AWS, the device first goes to a sorting facility before it reaches an AWS data center.  Many customers have requested us to add a new state to reflect the presence of the device at the sorting facility for better tracking. Today when a customer returns  the Snowball, the state first changes from "InTransitToAWS" to "WithAWS". With the addition of new state, the device will move from "InTransitToAWS" to "WithAWSSortingFacility", and then to "WithAWS".  There are no other changes to the API at this time besides adding this new state.

### 3.3.342.0 (2018-08-21 20:28 UTC)
* DLM (3.3.0.7)
	* Documentation updates for Lifecycle
* EC2 (3.3.59.0)
	* Added support for T3 Instance type in EC2. To learn more about T3 instances, please see https://aws.amazon.com/ec2/instance-types/t3/
* ElasticBeanstalk (3.3.10.0)
	* Elastic Beanstalk adds the "Privileged" field to the "CPUUtilization" type, to support enhanced health reporting in Windows environments.

### 3.3.341.0 (2018-08-20 21:11 UTC)
* DynamoDBv2 (3.3.13.0)
	* Added SSESpecification block to update-table command which allows users to modify table Server-Side Encryption. Added two new fields (SSEType and KMSMasterKeyId) to SSESpecification block used by create-table and update-table commands. Added new SSEDescription Status value UPDATING.

### 3.3.340.0 (2018-08-17 20:47 UTC)
* SageMaker (3.3.11.0)
	* Added an optional boolean parameter, 'DisassociateLifecycleConfig', to the UpdateNotebookInstance operation. When set to true, the lifecycle configuration associated with the notebook instance will be removed, allowing a new one to be set via a new 'LifecycleConfigName' parameter.
* SecretsManager (3.3.2.3)
	* Documentation updates for Secrets Manager

### 3.3.339.0 (2018-08-17 00:35 UTC)
* ApplicationDiscoveryService (3.3.4.0)
	* The Application Discovery Service's Continuous Export APIs allow you to analyze your on-premises server inventory data, including system performance and network dependencies, in Amazon Athena.
* MediaConvert (3.3.7.0)
	* Added WriteSegmentTimelineInRepresentation option for Dash Outputs
* Redshift (3.3.7.0)
	* You can now resize your Amazon Redshift cluster quickly. With the new ResizeCluster action, your cluster is available for read and write operations within minutes
* SimpleSystemsManagement (3.3.30.0)
	* AWS Systems Manager Inventory now supports groups to quickly see a count of which managed instances are and arent configured to collect one or more Inventory types

### 3.3.338.0 (2018-08-15 23:06 UTC)
* DeviceFarm (3.3.8.0)
	* Support for running tests in a custom environment with live logs/video streaming, full test features parity and reduction in overall test execution time.
* Core 3.3.24.8
	* We are launching AWS IoT Core and AWS IoT Device Mgmt in GovCloud (us-gov-west-1) region.


	* All services packages updated to require new Core

### 3.3.337.0 (2018-08-14 22:15 UTC)
* AutoScaling (3.3.5.0)
	* Add batch operations for creating/updating and deleting scheduled scaling actions.
* CloudFront (3.3.9.0)
	* Lambda@Edge Now Provides You Access to the Request Body for HTTP POST/PUT Processing. With this feature, you can now offload more origin logic to the edge and improve end-user latency. Developers typically use Web/HTML forms or Web Beacons/Bugs as a mechanism to collect data from the end users and then process that data at their origins servers. For example, if you are collecting end user behavior data through a web beacon on your website, you can use this feature to access the user behavior data and directly log it to an Amazon Kinesis Firehose endpoint from the Lambda function, thereby simplifying your origin infrastructure.
* Elasticsearch (3.3.8.0)
	* Amazon Elasticsearch Service adds support for no downtime, in-place upgrade for Elasticsearch version 5.1 and above.
* Core 3.3.24.7
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.336.0 (2018-08-13 23:00 UTC)
* SageMaker (3.3.10.0)
	* SageMaker updated the default endpoint URL to support Private Link via the CLI/SDK.

### 3.3.335.0 (2018-08-10 20:30 UTC)
* MediaConvert (3.3.6.0)
	* This release adds support for a new rate control mode, Quality-Defined Variable Bitrate (QVBR) encoding, includes updates to optimize transcoding performance, and resolves previously reported bugs.
* RDS (3.3.27.1)
	* Documentation updates for rds

### 3.3.334.0 (2018-08-09 22:10 UTC)
* DAX (3.3.1.0)
	* Add the SSESpecification field to CreateCluster to allow creation of clusters with server-side encryption, and add the SSEDescription field to DescribeClusters to display the status of server-side encryption for a cluster. 
* ECS (3.3.17.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for Docker volumes and Docker volume drivers. Customers can now configure their ECS Tasks to use Docker volumes, enabling stateful and storage-intensive applications to be deployed on ECS.
* RDS (3.3.27.0)
	* Launch RDS Aurora Serverless

### 3.3.333.0 (2018-08-08 20:29 UTC)
* SecretsManager (3.3.2.0)
	* This release introduces a ForceDeleteWithoutRecovery parameter to the DeleteSecret API enabling customers to force the deletion of a secret without any recovery window
* SimpleSystemsManagement (3.3.29.0)
	* AWS Systems Manager Automation is launching two new features for Automation Execution Rate Control based on tags and customized parameter maps. With the first feature, customer can target their resources by specifying a Tag with Key/Value. With the second feature, Parameter maps rate control, customers can benefit from customization of input parameters.

### 3.3.332.0 (2018-08-07 23:53 UTC)
* CloudWatchLogs (3.3.5.0)
	* Documentation Update
* CodeBuild (3.3.14.0)
	* Release semantic versioning feature for CodeBuild
* EC2 (3.3.58.0)
	* Amazon VPC Flow Logs adds support for delivering flow logs directly to S3
* Pinpoint (3.3.9.0)
	* This release includes a new batch API call for Amazon Pinpoint which can be used to update endpoints and submit events. This call will accept events from clients such as mobile devices and AWS SDKs. This call will accept requests which has multiple endpoints and multiple events attached to those endpoints in a single call. This call will update the endpoints attached and will ingest events for those endpoints. The response from this call will be a multipart response per endpoint/per event submitted.
* SimpleSystemsManagement (3.3.28.0)
	* Two new filters ExecutionStage and DocumentName will be added to ListCommands so that customers will have more approaches to query their commands.

### 3.3.331.0 (2018-08-06 22:16 UTC)
* AWSHealth (3.3.1.0)
	* Updates the ARN structure vended by AWS Health API. All ARNs will now include the service and type code of the associated event, as vended by DescribeEventTypes.
* DynamoDBv2 (3.3.12.0)
	*  Amazon DynamoDB Point-in-time recovery (PITR) provides continuous backups of your table data. DynamoDB now supports the ability to self-restore a deleted PITR enabled table. Now, when a table with PITR enabled is deleted, a system backup is automatically created and retained for 35 days (at no additional cost). System backups allow you to restore the deleted PITR enabled table to the state it was just before the point of deletion. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.330.2 (2018-08-03 22:18 UTC)
* DynamoDBv2 (3.3.11.2)
	* Updated to use new Core, version 3.3.24.6
	* Addressed DynamoDB inheritance issue. https://github.com/aws/aws-sdk-net/issues/906
* Core 3.3.24.6
	* This update addresses lock contention issues in DefaultInstanceProfileAWSCredentials and introduces nullable int fields in unmarshallers.
	* All services packages updated to require new Core

### 3.3.330.1 (2018-08-03 18:10 UTC)
* AlexaForBusiness (3.3.5.4)
	* Documentation updates for AWS Alexa For Business

### 3.3.330.0 (2018-08-02 20:22 UTC)
* Kinesis (3.3.6.0)
	* This version adds the foundation for future support of HTTP2-based event stream operations for Kinesis. The following operations have been added: DeregisterStreamConsumer, DescribeStreamConsumer, ListStreamConsumers, and RegisterStreamConsumer. The SubscribeToShard operation is not included in this release.
* Polly (3.3.7.0)
	* Amazon Polly enables female voice Aditi to speak Hindi language
* ResourceGroups (3.3.1.0)
	* AWS Resource Groups service added a new feature to filter group resources by resource-type when using the ListGroupResources operation.
* SimpleSystemsManagement (3.3.27.0)
	* This release updates AWS Systems Manager APIs to let customers create and use service-linked roles to register and edit Maintenance Window tasks.
* Core 3.3.24.5
	* AWS Greengrass is now available in the Dublin, Ireland (Europe) region, eu-west-1.


	* All services packages updated to require new Core

### 3.3.329.0 (2018-08-01 20:43 UTC)
* StorageGateway (3.3.10.0)
	* AWS Storage Gateway now enables you to create stored volumes with AWS KMS support.
* TranscribeService (3.3.3.0)
	* With this update Amazon Transcribe now supports channel identification. It transcribes audio from separate channels and combines them into a single transcription. 

### 3.3.328.0 (2018-07-31 19:57 UTC)
* Connect (3.3.1.0)
	* This update includes the new User Management APIs and the Federation API used for SAML authentication. The User Management APIs let you create and manage users in your Amazon Connect instance programmatically. The Federation API enables authentication between AWS and your existing identity provider using tokens.
* Elasticsearch (3.3.7.0)
	* Amazon Elasticsearch Service adds support for enabling Elasticsearch error logs, providing you valuable information for troubleshooting your Elasticsearch domains quickly and easily. These logs are published to the Amazon CloudWatch Logs service and can be turned on or off at will.
* IoT (3.3.15.0)
	* As part of this release we are introducing a new IoT security service, AWS IoT Device Defender, and extending capability of AWS IoT to support Step Functions rule action. The AWS IoT Device Defender is a fully managed service that helps you secure your fleet of IoT devices. For more details on this new service, go to https://aws.amazon.com/iot-device-defender. The Step Functions rule action lets you start an execution of AWS Step Functions state machine from a rule.
* KeyManagementService (3.3.6.0)
	* Added a KeyID parameter to the ListAliases operation. This parameter allows users to list only the aliases that refer to a particular AWS KMS customer master key. All other functionality remains intact.
* MediaConvert (3.3.5.0)
	* Fixes an issue with modeled timestamps being labeled with the incorrect format.

### 3.3.327.0 (2018-07-30 20:43 UTC)
* CloudHSMV2 (3.3.2.0)
	* This update  to the AWS CloudHSM API adds copy-backup-to-region, which allows you to copy a backup of a cluster from one region to another. The copied backup can be used in the destination region to create a new AWS CloudHSM cluster as a clone of the original cluster. 
* DirectConnect (3.3.6.0)
	* 1. awsDeviceV2 field is introduced for Connection/Lag/Interconnect/VirtualInterface/Bgp Objects, while deprecating the awsDevice field for Connection/Lag/Interconnect Objects. 2. region field is introduced for VirtualInterface/Location objects 
* Glacier (3.3.2.13)
	* Documentation updates for glacier
* Glue (3.3.10.0)
	* Glue Development Endpoints now support association of multiple SSH public keys with a development endpoint.
* IoT (3.3.14.0)
	* get rid of documentParameters field from CreateJob API
* MQ (3.3.1.0)
	* Modified the CreateBroker, UpdateBroker, and DescribeBroker operations to support integration with Amazon CloudWatch Logs. Added a field to indicate the IP address(es) that correspond to wire-level endpoints of broker instances. While a single-instance broker has one IP address, an active/standby broker for high availability has 2 IP addresses. Added fields to indicate the time when resources were created. Updated documentation for Amazon MQ.
* SageMaker (3.3.9.0)
	* Added SecondaryStatusTransitions to DescribeTrainingJob to provide more visibility into SageMaker training job progress and lifecycle.

### 3.3.326.0 (2018-07-26 21:59 UTC)
* CodeBuild (3.3.13.0)
	* Add artifacts encryptionDisabled and build encryptionKey.
* EC2 (3.3.57.0)
	* This change provides the EC2/Spot customers with two new allocation strategies -- LowestN for Spot instances, and OD priority for on-demand instances.
* Greengrass (3.3.3.8)
	* Documentation updates for Greengrass Local Resource Access feature
* Inspector (3.3.7.0)
	* inspector will return ServiceTemporarilyUnavailableException when service is under stress
* Redshift (3.3.6.0)
	* When we make a new version of Amazon Redshift available, we update your cluster during its maintenance window. By selecting a maintenance track, you control whether we update your cluster with the most recent approved release, or with the previous release. The two values for maintenance track are current and trailing. If you choose the current track, your cluster is updated with the latest approved release. If you choose the trailing track, your cluster is updated with the release that was approved previously.The new API operation for managing maintenance tracks for a cluster is DescribeClusterTracks. In addition, the following API operations have new MaintenanceTrackName parameters:  Cluster,  PendingModifiedValues,  ModifyCluster,  RestoreFromClusterSnapshot,  CreateCluster,  Snapshot
* SimpleSystemsManagement (3.3.26.0)
	* This release updates AWS Systems Manager APIs to allow customers to attach labels to history parameter records and reference history parameter records via labels.  It also adds Parameter Store integration with AWS Secrets Manager to allow referencing and retrieving AWS Secrets Manager's secrets from Parameter Store.

### 3.3.325.0 (2018-07-25 21:26 UTC)
* EC2 (3.3.56.0)
	* R5 is the successor to R4 in EC2's memory-optimized instance family. R5d is a variant of R5 that has local NVMe SSD. Z1d instances deliver both high compute and high memory. Z1d instances use custom Intel Xeon Scalable Processors running at up to 4.0 GHz, powered by sustained all-core Turbo Boost. They are available in 6 sizes, with up to 48 vCPUs, 384 GiB of memory, and 1.8 TB of local NVMe storage.
* ECS (3.3.16.0)
	* This release of Amazon Elastic Container Service (Amazon ECS) introduces support for private registry authentication using AWS Secrets Manager. With private registry authentication, private Docker images can be used in a task definition.
* ElasticLoadBalancingV2 (3.3.10.0)
	* We are introducing two new actions in Application Load Balancer. Redirects and Fixed Response. These features will allow you to improve user experience and security posture. By using redirect actions in your Application Load Balancer, you can improve the security of your user requests and by using fixed-response, you can enhance the customer experience by displaying branded error pages during application maintenance or outages.

### 3.3.324.0 (2018-07-24 21:54 UTC)
* DynamoDBv2 (3.3.11.0)
	* With this SDK update, APIs UpdateGlobalTableSettings and DescribeGlobalTableSettings now allow consistently configuring AutoScaling settings for a DynamoDB global table. Previously, they would only allow consistently setting IOPS. Now new APIs are being released, existing APIs are being extended.

### 3.3.323.0 (2018-07-23 21:04 UTC)
* CognitoSync (3.3.1.36)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* DynamoDBv2 (3.3.10.4)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* IdentityManagement (3.3.7.1)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Kinesis (3.3.5.10)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* KinesisFirehose (3.3.5.5)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Lambda (3.3.15.1)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* MobileAnalytics (3.3.1.33)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* S3 (3.3.20.0)
	* Updated to use new Core, version 3.3.24.4
	* Amazon S3 Select is an Amazon S3 feature that makes it easy to retrieve specific data from the contents of an object using simple SQL expressions without having to retrieve the entire object. With this release of the Amazon S3 SDK, S3 Select API (SelectObjectContent) is now generally available in all public regions. This release supports retrieval of a subset of data using SQL clauses, like SELECT and WHERE, from delimited text files and JSON objects in Amazon S3 through the SelectObjectContent API available in AWS S3 SDK.
Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.
* SimpleEmail (3.3.6.12)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* SQS (3.3.3.12)
	* Dependency on com.google.android.gms.gcm.GoogleCloudMessaging has been removed.

* Core 3.3.24.4
	* Add AsyncRunner.cs back for users that upgraded AWSSDK.Core but haven't updated the corresponding service packages like AWSSDK.DynamoDBv2 which used AsyncRunner from Core in older versions of the package.
	* All services packages updated to require new Core

### 3.3.322.0 (2018-07-20 20:23 UTC)
* ConfigService (3.3.19.0)
	* Setting internal length limits on resourceId for APIs.  
* DLM (3.3.0.1)
	* Update documentation for Amazon Data Lifecycle Manager.

### 3.3.321.0 (2018-07-19 20:20 UTC)
* MediaPackage (3.3.2.0)
	* Adds support for DASH OriginEnpoints with multiple media presentation description periods triggered by presence of SCTE-35 ad markers in Channel input streams.

### 3.3.320.0 (2018-07-18 21:37 UTC)
* IoTAnalytics (3.3.2.0)
	* This change allows publishing of channel/datastore size as part of the describe-channel/describe-datastore APIs. We introduce an optional boolean parameter 'includeStatistics' in the Describe request. If the user sets this parameter to true, the describe response will return the resource size and timestamp at which the size was recorded. If the parameter is set to false, the size won't be computed or returned.

### 3.3.319.0 (2018-07-17 15:32 UTC)
* Comprehend (3.3.2.0)
	* This release gives customers the ability to tokenize (find word boundaries) text and for each word provide a label for the part of speech, using the DetectSyntax operation. This API is useful to analyze text for specific conditions like for example finding nouns and the correlating adjectives to understand customer feedback. 
* Polly (3.3.6.0)
	* Amazon Polly adds new API for asynchronous synthesis to S3
* SageMaker (3.3.8.0)
	* Amazon SageMaker has added the capability for customers to run fully-managed, high-throughput batch transform machine learning models with a simple API call. Batch Transform is ideal for high-throughput workloads and predictions in non-real-time scenarios where data is accumulated over a period of time for offline processing.
* Snowball (3.3.3.0)
	* AWS Snowball Edge announces the availability of Amazon EC2 compute instances that run on the device. AWS Snowball Edge is a 100-TB ruggedized device built to transfer data into and out of AWS with optional support for local Lambda-based compute functions. With this feature, developers and administrators can run their EC2-based applications on the device providing them with an end to end vertically integrated AWS experience. Designed for data pre-processing, compression, machine learning, and data collection applications, these new instances, called SBE1 instances, feature 1.8 GHz Intel Xeon D processors up to 16 vCPUs, and 32 GB of memory. The SBE1 instance type is available in four sizes and multiple instances can be run on the device at the same time. Customers can now run compute instances using the same Amazon Machine Images (AMIs) that are used in Amazon EC2.

### 3.3.318.0 (2018-07-13 21:47 UTC)
* AppStream (3.3.16.0)
	* This API update adds support for sharing AppStream images across AWS accounts within the same region.
* KinesisVideo (3.3.1.0)
	* Adds support for HLS video playback of Kinesis Video streams using the KinesisVideo client by including "GET_HLS_STREAMING_SESSION_URL" as an additional APIName parameter in the GetDataEndpoint input.
* KinesisVideoArchivedMedia (3.3.1.0)
	* Adds support for HLS video playback of Kinesis Video streams by providing the GetHLSStreamingSessionURL function in the KinesisVideoArchivedMedia client.

### 3.3.317.0 (2018-07-12 20:44 UTC)
* AppSync (3.3.3.0)
	* This release adds support for configuring HTTP  endpoints as data sources for your AWS AppSync GraphQL API.
* DLM (3.3.0.0)
	* Amazon Data Lifecycle Manager (DLM) for EBS Snapshots provides a simple, automated way to back up data stored on Amazon EBS volumes. You can define backup and retention schedules for EBS snapshots by creating lifecycle policies based on tags. With this feature, you no longer have to rely on custom scripts to create and manage your backups. This feature is now available in the US East (N. Virginia), US West (Oregon), and Europe (Ireland) AWS regions at no additional cost.
* ElasticFileSystem (3.3.2.0)
	* Amazon EFS now allows you to instantly provision the throughput required for your applications independent of the amount of data stored in your file system, allowing you to optimize throughput for your applications performance needs. Starting today, you can provision the throughput your applications require quickly with a few simple steps using AWS Console, AWS CLI or AWS API to achieve consistent performance.
* ElasticMapReduce (3.3.5.10)
	* Documentation updates for EMR.
* IdentityManagement (3.3.7.0)
	* SDK release to support IAM delegated administrator feature. The feature lets customers attach permissions boundary to IAM principals. The IAM principals cannot operate exceeding the permission specified in permissions boundary.

### 3.3.316.0 (2018-07-11 21:44 UTC)
* APIGateway (3.3.19.0)
	* Support for fine grain throttling for API gateway. 
* CostExplorer (3.3.6.0)
	* Starting today, you can access custom Reserved Instance (RI) purchase recommendations for your Amazon Redshift, Amazon ElastiCache, and Amazon Elasticsearch reservations via AWS Cost Explorer API, in addition to accessing RI purchase recommendations for your Amazon EC2 and Amazon RDS reservations.
* S3 (3.3.19.0)
	* S3 Select support for BZIP2 compressed input files
* SimpleSystemsManagement (3.3.25.0)
	* Support Conditional Branching OnFailure for SSM Automation

### 3.3.315.0 (2018-07-10 21:11 UTC)
* AppStream (3.3.15.0)
	* This API update adds pagination to the DescribeImages API to support future features and enhancements.
* CodeBuild (3.3.12.0)
	* API changes to CodeBuild service, support report build status for Github sources
* EC2 (3.3.55.0)
	* Support CpuOptions field in Launch Template data and allow Launch Template name to contain hyphen.
* Glue (3.3.9.0)
	* AWS Glue adds the ability to crawl DynamoDB tables.
* OpsWorks (3.3.3.10)
	* Documentation updates for AWS OpsWorks Stacks.

### 3.3.314.1 (2018-07-10 01:40 UTC)
* ApplicationAutoScaling (3.3.10.1)
	* Documentation updates for application-autoscaling

### 3.3.314.0 (2018-07-09 20:26 UTC)
* ApplicationAutoScaling (3.3.10.0)
	* The release adds support for custom resource auto scaling.
* CostExplorer (3.3.5.0)
	* AWS Cost Explorer provides you with Reserved Instance (RI) purchase recommendations based on your total cross-account Amazon EC2 and Amazon RDS usage. Starting today, linked accounts can also access custom RI purchase recommendations for specific linked accounts directly via AWS Cost Explorer API.
* DatabaseMigrationService (3.3.8.0)
	* Added support for DmsTransfer endpoint type and support for re-validate option in table reload API.
* Lambda (3.3.15.0)
	* Add support for .NET Core 2.1 to Lambda.
* TranscribeService (3.3.2.0)
	* You can now specify an Amazon S3 output bucket to store the transcription of your audio file when you call the StartTranscriptionJob operation. 

### 3.3.313.0 (2018-07-06 17:41 UTC)
* MediaConvert (3.3.4.0)
	* This release adds support for the following 1) users can specify tags to be attached to queues, presets, and templates during creation of those resources on MediaConvert. 2) users can now view the count of jobs in submitted state and in progressing state on a per queue basis.
* ServerlessApplicationRepository (3.3.2.0)
	* Added required fields and documentation updates for AWS Serverless Application Repository.

### 3.3.312.0 (2018-07-05 21:15 UTC)
* Pinpoint (3.3.8.0)
	* This release of the Amazon Pinpoint SDK adds the ability to create complex segments and validate phone numbers for SMS messages. It also adds the ability to get or delete endpoints based on user IDs, remove attributes from endpoints, and list the defined channels for an app.
* SageMaker (3.3.7.0)
	* Amazon SageMaker NotebookInstances supports 'Updating' as a NotebookInstanceStatus.  In addition, DescribeEndpointOutput now includes Docker repository digest of deployed Model images.

### 3.3.311.0 (2018-07-03 20:11 UTC)
* EC2 (3.3.54.0)
	* Added support for customers to tag EC2 Dedicated Hosts
* Redshift (3.3.5.0)
	* Feature 1 - On-demand cluster release version - When Amazon Redshift releases a new cluster version, you can choose to upgrade to that version immediately instead of waiting until your next maintenance window. You can also choose to roll back to a previous version. The two new APIs added for managing cluster release version are - ModifyClusterDbRevision, DescribeClusterDbRevisions. Feature 2 - Upgradeable reserved instance - You can now exchange one Reserved Instance for a new Reserved Instance with no changes to the terms of your existing Reserved Instance (term, payment type, or number of nodes). The two new APIs added for managing these upgrades are - AcceptReservedNodeExchange, GetReservedNodeExchangeOfferings. 
* Core 3.3.24.3
	* General availability of AWS Lambda in the China Northwest (cn-northwest-1) region. For more information, see the AWS Lambda developer guide.


	* All services packages updated to require new Core

### 3.3.310.0 (2018-07-02 20:51 UTC)
* SimpleSystemsManagement (3.3.24.0)
	* Execution History and StartAssociationOnce release for State Manager. Users now have the ability to view association execution history with DescribeAssociationExecutions and DescribeAssociationExecutionTargets. Users can also execute an association by calling StartAssociationOnce.

### 3.3.309.0 (2018-06-28 21:13 UTC)
* ElasticBeanstalk (3.3.9.0)
	* Elastic Beanstalk adds "Suspended" health status to the EnvironmentHealthStatus enum type and updates document.
* Lambda (3.3.14.0)
	* Support for SQS as an event source.
* StorageGateway (3.3.9.0)
	* AWS Storage Gateway now enables you to use Server Message Block (SMB) protocol  to store and access objects in Amazon Simple Storage Service (S3). 

### 3.3.308.0 (2018-06-27 22:08 UTC)
* CloudFront (3.3.8.0)
	* Unpublish delete-service-linked-role API.
* CodePipeline (3.3.5.0)
	* UpdatePipeline may now throw a LimitExceededException when adding or updating Source Actions that use periodic checks for change detection
* Comprehend (3.3.1.0)
	* This release gives customers the option to batch process a set of documents stored within an S3 bucket in addition to the existing synchronous nature of the current Comprehend API.
* SecretsManager (3.3.1.1)
	* Documentation updates for secretsmanager

### 3.3.307.0 (2018-06-26 22:24 UTC)
* Inspector (3.3.6.0)
	* Introduce four new APIs to view and preview Exclusions.  Exclusions show which intended security checks are excluded from an assessment, along with reasons and recommendations to fix.  The APIs are CreateExclusionsPreview, GetExclusionsPreview, ListExclusions, and DescribeExclusions.
* SecretsManager (3.3.1.0)
	* This release adds support for resource-based policies that attach directly to your secrets. These policies provide an additional way to control who can access your secrets and what they can do with them. For more information, see https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html in the Secrets Manager User Guide.

### 3.3.306.0 (2018-06-22 22:01 UTC)
* AlexaForBusiness (3.3.5.0)
	*  Introduce DeviceNotRegisteredException for AWSMoneypenny
* AppStream (3.3.14.0)
	* This API update enables customers to find their VPC private IP address and ENI ID associated with AppStream streaming sessions.
* Core 3.3.24.2
	* General availability release of Amazon Translate in the GovCloud West (us-gov-west-1) region. For more information, see the Amazon Translate developer guide.


	* All services packages updated to require new Core

### 3.3.305.0 (2018-06-21 23:29 UTC)
* CloudDirectory (3.3.9.0)
	* SDK release to support Flexible Schema initiative being carried out by Amazon Cloud Directory. This feature lets customers using new capabilities like: variant typed attributes, dynamic facets and AWS managed Cloud Directory schemas.

### 3.3.304.0 (2018-06-21 20:16 UTC)
* Macie (3.3.0.0)
	* Amazon Macie is a security service that uses machine learning to automatically discover, classify, and protect sensitive data in AWS. With this release, we are launching the following Macie HTTPS API operations: AssociateMemberAccount, AssociateS3Resources, DisassociateMemberAccount, DisassociateS3Resources, ListMemberAccounts, ListS3Resources, and UpdateS3Resources. With these API operations you can issue HTTPS requests directly to the service.
* Neptune (3.3.2.0)
	* Deprecates the PubliclyAccessible parameter that is not supported by Amazon Neptune.
* SimpleSystemsManagement (3.3.23.0)
	* Adds Amazon Linux 2 support to Patch Manager

### 3.3.303.0 (2018-06-20 20:09 UTC)
* ACMPCA (3.3.1.0)
	* CA Restore is a new feature within AWS Certificate Manager Private Certificate Authority (ACM PCA) that allows you to restore a private certificate authority that has been deleted. When you issue the DeleteCertificateAuthority call, you can now specify the number of days (7-30, with 30 being the default) in which the private certificate authority will remain in the DELETED state. During this time, the private certificate authority can be restored with the RestoreCertificateAuthority API call and then be returned to the PENDING_CERTIFICATE or DISABLED state, depending upon the state prior to deletion.  Summary of API Changes: 1). Added RestoreCertificateAuthority API call; 2). Added optional PermanentDeletionTimeInDays parameter to DeleteCertificateAuthority API call. If this parameter is not specified, the DeleteCertificateAuthority API call will use a 30 day restore period as default.
* MediaLive (3.3.7.0)
	* AWS Elemental MediaLive now makes Reserved Outputs and Inputs available through the AWS Management Console and API. You can reserve outputs and inputs with a 12 month commitment in exchange for discounted hourly rates. Pricing is available at https://aws.amazon.com/medialive/pricing/
* RDS (3.3.26.0)
	* This release adds a new parameter to specify the retention period for Performance Insights data for RDS instances. You can either choose 7 days (default) or 731 days. For more information, see Amazon RDS Documentation.

### 3.3.302.1 (2018-06-19 20:24 UTC)
* Rekognition (3.3.8.8)
	* Documentation updates for rekognition
* Core 3.3.24.1
	* Updating endpoints.json file


	* All services packages updated to require new Core

### 3.3.302.0 (2018-06-19 02:26 UTC)
* Neptune (3.3.1.0)
	* Fixed Neptune with correct service model.

### 3.3.301.0 (2018-06-15 23:50 UTC)
* MediaConvert (3.3.3.0)
	* This release adds language code support according to the ISO-639-3 standard. Custom 3-character language codes are now supported on input and output for both audio and captions.

### 3.3.300.0 (2018-06-14 22:16 UTC)
* APIGateway (3.3.18.0)
	* Support for PRIVATE endpoint configuration type
* DynamoDBv2 (3.3.10.0)
	* Added two new fields SSEType and KMSMasterKeyArn to SSEDescription block in describe-table output.
* IoTAnalytics (3.3.1.0)
	* With this release, AWS IoT Analytics allows you to tag resources. Tags are metadata that you can create and use to manage your IoT Analytics resources. For more information about tagging, see AWS Tagging Strategies. For technical documentation, look for the tagging operations in the AWS IoT Analytics API reference or User Guide.

### 3.3.299.0 (2018-06-13 22:32 UTC)
* ServiceCatalog (3.3.10.0)
	* Introduced new length limitations for few of the product fields.
* SimpleSystemsManagement (3.3.22.0)
	* Added support for new parameter, CloudWatchOutputConfig, for SendCommand API. Users can now have RunCommand output sent to CloudWatchLogs.

### 3.3.298.0 (2018-06-12 21:29 UTC)
* DeviceFarm (3.3.7.0)
	* Adding VPCEndpoint support for Remote access. Allows customers to be able to access their private endpoints/services running in their VPC during remote access.
* ECS (3.3.15.0)
	* Introduces daemon scheduling capability to deploy one task per instance on selected instances in a cluster.  Adds a "force" flag to the DeleteService API to delete a service without requiring to scale down the number of tasks to zero.

### 3.3.297.0 (2018-06-11 21:08 UTC)
* CloudDirectory (3.3.8.0)
	* Amazon Cloud Directory now supports optional attributes on Typed Links, giving users the ability to associate and manage data on Typed Links. 
* RDS (3.3.25.1)
	* Changed lists of valid EngineVersion values to links to the RDS User Guide.
* StorageGateway (3.3.8.0)
	*  AWS Storage Gateway now enables you to create cached volumes and tapes with AWS KMS support.

### 3.3.296.0 (2018-06-09 01:01 UTC)
* DynamoDBv2 (3.3.9.0)
	* Updated to use new Core, version 3.3.24.0
	* Removed AsyncRunner usage for async paths in DynamoDB DataModel and DocumentModel APIs - PR https://github.com/aws/aws-sdk-net/pull/896
* Core 3.3.24.0
	* DotnetCLI fix for BaseIntermediateOutputPath.
	* Replace EC2 instance profile credentials resolver in the credentials fallback chain with a new singleton implementation.
* AWSSDK.Extensions.NETCore.Setup (3.3.6)
	* Support for TryAddAWSService - PR https://github.com/aws/aws-sdk-net/pull/935


### 3.3.295.0 (2018-06-08 17:41 UTC)
* MediaTailor (3.3.1.0)
	* Fixes a bug in the request URIs for MediaTailor PlaybackConfiguration operations.

### 3.3.294.0 (2018-06-07 22:10 UTC)
* MediaLive (3.3.6.0)
	* AWS Elemental MediaLive now makes channel log information available through Amazon CloudWatch Logs. You can set up each MediaLive channel with a logging level; when the channel is run, logs will automatically be published to your account on Amazon CloudWatch Logs

### 3.3.293.0 (2018-06-05 22:44 UTC)
* CostExplorer (3.3.4.0)
	* Cost Explorer API is providing programmatic access to RI saving metrics to enable customers to optimize their reservations.
* Polly (3.3.5.0)
	* Amazon Polly adds new French voice - "Lea"
* RDS (3.3.25.0)
	* This release adds customizable processor features for RDS instances.
* SecretsManager (3.3.0.10)
	* Documentation updates for secretsmanager
* Shield (3.3.2.0)
	* DDoS Response Team access management for AWS Shield

### 3.3.292.0 (2018-06-04 21:50 UTC)
* AppStream (3.3.13.0)
	* Amazon AppStream 2.0 adds support for Google Drive for G Suite. With this feature, customers will be able to connect their G Suite accounts with AppStream 2.0 and enable Google Drive access for an AppStream 2.0 stack. Users of the stack can then link their Google Drive using their G Suite login credentials and use their existing files stored in Drive with their AppStream 2.0 applications. File changes will be synced automatically to Google cloud. 
* EC2 (3.3.53.0)
	* You are now able to use instance storage (up to 3600 GB of NVMe based SSD) on M5 instances, the next generation of EC2's General Purpose instances in us-east-1, us-west-2, us-east-2, eu-west-1 and ca-central-1. M5 instances offer up to 96 vCPUs, 384 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes and provide a balance of compute, memory and network resources for many applications.
* EKS (3.3.0.0)
	* Amazon Elastic Container Service for Kubernetes (Amazon EKS) is a fully managed service that makes it easy to deploy, manage, and scale containerized applications using Kubernetes on AWS. Amazon EKS runs the Kubernetes control plane for you across multiple AWS availability zones to eliminate a single point of failure. Amazon EKS is certified Kubernetes conformant so you can use existing tooling and plugins from partners and the Kubernetes community. Applications running on any standard Kubernetes environment are fully compatible and can be easily migrated to Amazon EKS. 
* MediaConvert (3.3.2.0)
	* This release adds the support for Common Media Application Format (CMAF) fragmented outputs, RF64 WAV audio output format, and HEV1 or HEVC1 MP4 packaging types when using HEVC in DASH or CMAF outputs.
* MigrationHub (3.3.1.6)
	* Documentation updates for AWS Migration Hub
* SageMaker (3.3.6.0)
	* Amazon SageMaker has added the ability to run hyperparameter tuning jobs. A hyperparameter tuning job will create and evaluate multiple training jobs while tuning algorithm hyperparameters, to optimize a customer specified objective metric.

### 3.3.291.0 (2018-06-01 20:07 UTC)
* DirectoryService (3.3.5.0)
	* Added ResetUserPassword API. Customers can now reset their users' passwords without providing the old passwords in Simple AD and Microsoft AD.
* IoT (3.3.13.0)
	* We are releasing force CancelJob and CancelJobExecution functionalities to customers.
* MediaTailor (3.3.0.0)
	* AWS Elemental MediaTailor is a personalization and monetization service that allows scalable server-side ad insertion. The service enables you to serve targeted ads to viewers while maintaining broadcast quality in over-the-top (OTT) video applications. This SDK allows user access to the AWS Elemental MediaTailor configuration interface.
* Redshift (3.3.4.5)
	* Documentation updates for redshift
* SimpleNotificationService (3.3.1.0)
	* The SNS Subscribe API has been updated with two new optional parameters: Attributes and ReturnSubscriptionArn. Attributes is a map of subscription attributes which can be one or more of: FilterPolicy, DeliveryPolicy, and RawMessageDelivery. ReturnSubscriptionArn is a boolean parameter that overrides the default behavior of returning "pending confirmation" for subscriptions that require confirmation instead of returning the subscription ARN.
* Core 3.3.23.1
	* SageMaker has added support for the Asia Pacific (Tokyo) region.


	* All services packages updated to require new Core

### 3.3.290.0 (2018-05-31 01:19 UTC)
* ElasticLoadBalancingV2 (3.3.9.0)
	* This release of Elastic Load Balancing introduces user authentication on Application Load Balancer.
* Neptune (3.3.0.0)
	* Amazon Neptune is a fast, reliable graph database service that makes it easy to build and run applications that work with highly connected datasets. Neptune supports popular graph models Property Graph and W3C's Resource Description Frame (RDF), and their respective query languages Apache TinkerPop Gremlin 3.3.2 and SPARQL 1.1. 
* Core 3.3.23.0
	* Updated service.json with the canonical.

### 3.3.289.0 (2018-05-29 20:00 UTC)
* PI (3.3.0.0)
	* Performance Insights is a feature of Amazon Relational Database Service (RDS) that helps you quickly assess the load on your database, and determine when and where to take action. You can use the SDK to retrieve Performance Insights data and integrate your monitoring solutions.

### 3.3.288.0 (2018-05-25 21:36 UTC)
* AppStream (3.3.12.0)
	* This API update enables customers to control whether users can transfer data between their local devices and their streaming applications through file uploads and downloads, clipboard operations, or printing to local devices
* ConfigService (3.3.18.0)
	* AWS Config adds support for retention period, allowing you to specify a retention period for your AWS Config configuration items.
* Glue (3.3.8.0)
	* AWS Glue now sends a delay notification to Amazon CloudWatch Events when an ETL job runs longer than the specified delay notification threshold.
* IoT (3.3.12.0)
	* We are exposing DELETION_IN_PROGRESS as a new job status in regards to the release of DeleteJob API.

### 3.3.287.0 (2018-05-24 21:56 UTC)
* CodeBuild (3.3.11.0)
	* AWS CodeBuild Adds Support for Windows Builds.
* ElasticLoadBalancingV2 (3.3.8.7)
	* Updated elasticloadbalancingV2 documentation with slow start mode details.  The slow start mode can be used to gradually increase the number of requests forwarded by a load balancer to a newly added target in a target group. It provides a new target an opportunity to warm up before it can handle its fair share of requests received from the load balancer. Slow start mode is disabled by default and can be enabled on a per target group basis.
* RDS (3.3.24.0)
	* This release adds CloudWatch Logs integration capabilities to RDS Aurora MySQL clusters
* SecretsManager (3.3.0.8)
	* Documentation updates for secretsmanager

### 3.3.286.0 (2018-05-22 22:09 UTC)
* ECS (3.3.14.0)
	* Amazon Elastic Container Service (ECS) adds service discovery for services that use host or bridged network mode. ECS can now also register instance IPs for active tasks using bridged and host networking with Route 53, making them available via DNS.
* Inspector (3.3.5.0)
	* We are launching the ability to target all EC2 instances. With this launch, resourceGroupArn is now optional for CreateAssessmentTarget and UpdateAssessmentTarget. If resourceGroupArn is not specified, all EC2 instances in the account in the AWS region are included in the assessment target.

### 3.3.285.0 (2018-05-21 20:17 UTC)
* CloudFormation (3.3.11.0)
	* 1) Filtered Update for StackSet based on Accounts and Regions: This feature will allow flexibility for the customers to roll out updates on a StackSet based on specific Accounts and Regions.   2) Support for customized ExecutionRoleName: This feature will allow customers to attach ExecutionRoleName to the StackSet thus ensuring more security and controlling the behavior of any AWS resources in the target accounts.

### 3.3.284.0 (2018-05-18 20:27 UTC)
* IoT (3.3.11.0)
	* We are releasing DeleteJob and DeleteJobExecution APIs to allow customer to delete resources created using AWS IoT Jobs.
* SimpleEmail (3.3.6.7)
	* Fixed a broken link in the documentation for S3Action.

### 3.3.283.0 (2018-05-17 21:36 UTC)
* CodeDeploy (3.3.10.1)
	* Documentation updates for codedeploy
* CognitoIdentityProvider (3.3.10.0)
	* Amazon Cognito User Pools now supports federation for users to sign up and sign in with any identity provider following the OpenID Connect standard. Amazon Cognito User Pools now returns the User Pool's Amazon Resource Name (ARN) from the CreateUserPool, UpdateUserPool, and DescribeUserPool APIs.
* EC2 (3.3.52.0)
	* You are now able to use instance storage (up to 1800 GB of NVMe based SSD) on C5 instances, the next generation of EC2's compute optimized instances in us-east-1, us-west-2, us-east-2, eu-west-1 and ca-central-1. C5 instances offer up to 72 vCPUs, 144 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes to deliver improved performance for compute-intensive workloads.You can now run bare metal workloads on EC2 with i3.metal instances. As a new instance size belonging to the I3 instance family, i3.metal instances have the same characteristics as other instances in the family, including NVMe SSD-backed instance storage optimized for low latency, very high random I/O performance, and high sequential read throughput. I3.metal instances are powered by 2.3 GHz Intel Xeon processors, offering 36 hyper-threaded cores (72 logical processors), 512 GiB of memory, and 15.2 TB of NVMe SSD-backed instance storage. These instances deliver high networking throughput and lower latency with up to 25 Gbps of aggregate network bandwidth using Elastic Network Adapter (ENA)-based Enhanced Networking.

### 3.3.282.0 (2018-05-16 18:29 UTC)
* SecretsManager (3.3.0.7)
	* Documentation updates for secretsmanager
* ServiceCatalog (3.3.9.0)
	* Users can now pass a new option to ListAcceptedPortfolioShares called portfolio-share-type with a value of AWS_SERVICECATALOG in order to access Getting Started Portfolios that contain selected products representing common customer use cases.

### 3.3.281.0 (2018-05-15 18:32 UTC)
* ConfigService (3.3.17.0)
	* Update ResourceType enum with values for XRay resource

### 3.3.280.0 (2018-05-14 22:26 UTC)
* CodeBuild (3.3.10.0)
	* Adding support for more override fields for StartBuild API, add support for idempotency token field  for StartBuild API in AWS CodeBuild.
* IoT1ClickDevicesService (3.3.0.0)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/
* IoT1ClickProjects (3.3.0.0)
	* AWS IoT 1-Click makes it easy for customers to incorporate simple ready-to-use IoT devices into their workflows. These devices can trigger AWS Lambda functions that implement business logic. In order to build applications using AWS IoT 1-Click devices, programmers can use the AWS IoT 1-Click Devices API and the AWS IoT 1-Click Projects API. Learn more at https://aws.amazon.com/documentation/iot-1-click/.
* Organizations (3.3.8.4)
	* Documentation updates for organizations

### 3.3.279.0 (2018-05-10 23:22 UTC)
* KinesisFirehose (3.3.5.0)
	* With this release, Amazon Kinesis Data Firehose can convert the format of your input data from JSON to Apache Parquet or Apache ORC before storing the data in Amazon S3. Parquet and ORC are columnar data formats that save space and enable faster queries compared to row-oriented formats like JSON.

### 3.3.278.0 (2018-05-10 19:29 UTC)
* GameLift (3.3.12.0)
	* AutoScaling Target Tracking scaling simplification along with StartFleetActions and StopFleetActions APIs to suspend and resume automatic scaling at will.

### 3.3.277.0 (2018-05-10 01:03 UTC)
* Budgets (3.3.9.0)
	* Updating the regex for the NumericValue fields.
* EC2 (3.3.51.0)
	* Enable support for latest flag with Get Console Output
* RDS (3.3.23.0)
	* Changes to support the Aurora MySQL Backtrack feature.
* Core 3.3.22.5
	* With this release, we're adding support for ap-south-1 AWS region.



### 3.3.276.0 (2018-05-08 17:27 UTC)
* EC2 (3.3.50.0)
	* Enable support for specifying CPU options during instance launch.
* RDS (3.3.22.3)
	* Correction to the documentation about copying unencrypted snapshots.
* Core 3.3.22.4
	* Lightsail is now available in regions eu-west-3, ap-northeast-2 and ca-central-1. 



### 3.3.275.0 (2018-05-07 21:40 UTC)
* AlexaForBusiness (3.3.4.0)
	* This release adds the new Device status "DEREGISTERED". This release also adds DEVICE_STATUS as the new DeviceEventType.
* Budgets (3.3.8.0)
	* "With this release, customers can use AWS Budgets to monitor how much of their Amazon EC2, Amazon RDS, Amazon Redshift, and Amazon ElastiCache instance usage is covered by reservations, and receive alerts when their coverage falls below the threshold they define."
* Elasticsearch (3.3.6.0)
	* This change brings support for Reserved Instances to AWS Elasticsearch.

### 3.3.274.0 (2018-05-04 20:08 UTC)
* GuardDuty (3.3.4.0)
	* Amazon GuardDuty is adding five new API operations for creating and managing filters. For each filter, you can specify a criteria and an action. The action you specify is applied to findings that match the specified criteria.

### 3.3.273.0 (2018-05-04 00:00 UTC)
* AppSync (3.3.2.0)
	* This release adds support for authorizing your AWS AppSync endpoint with an OpenID Connect compliant service and also to configure your AWS AppSync endpoint to log requests to Amazon CloudWatch Logs.
* ConfigService (3.3.16.0)
	* Update ResourceType enum with values for Lambda, ElasticBeanstalk, WAF and ElasticLoadBalancing resources
* SecretsManager (3.3.0.6)
	* Documentation updates for secretsmanager
* Core 3.3.22.3
	* Amazon WorkSpaces is now available in ca-central-1



### 3.3.272.0 (2018-05-02 23:23 UTC)
* CertificateManager (3.3.5.3)
	* Documentation updates for acm
* CodePipeline (3.3.4.0)
	* Added support for webhooks with accompanying definitions as needed in the AWS CodePipeline API Guide.
* EC2 (3.3.49.0)
	* Amazon EC2 Fleet is a new feature that simplifies the provisioning of Amazon EC2 capacity across different EC2 instance types, Availability Zones, and the On-Demand, Reserved Instance, and Spot Instance purchase models. With a single API call, you can now provision capacity to achieve desired scale, performance, and cost.
* SimpleSystemsManagement (3.3.21.0)
	* Added support for new parameter, DocumentVersion, for SendCommand API. Users can now specify version of SSM document to be executed on the target(s).

### 3.3.271.0 (2018-04-30 23:05 UTC)
* AlexaForBusiness (3.3.3.0)
	* Adds ListDeviceEvents API to get a paginated list of device events (such as ConnectionStatus). This release also adds ConnectionStatus field to GetDevice and SearchDevices API.
* DynamoDBv2 (3.3.8.0)
	* Adds two new APIs UpdateGlobalTableSettings and DescribeGlobalTableSettings. This update introduces new constraints in the CreateGlobalTable and UpdateGlobalTable APIs . Tables must have the same write capacity units. If Global Secondary Indexes exist then they must have the same write capacity units and key schema.
* GuardDuty (3.3.3.0)
	* You can disable the email notification when inviting GuardDuty members using the disableEmailNotification parameter in the InviteMembers operation.
* Route53Domains (3.3.2.0)
	* This release adds a SubmittedSince attribute to the ListOperations API, so you can list operations that were submitted after a specified date and time.
* SageMaker (3.3.5.0)
	* SageMaker has added support for VPC configuration for both Endpoints and Training Jobs. This allows you to connect from the instances running the Endpoint or Training Job to your VPC and any resources reachable in the VPC rather than being restricted to resources that were internet accessible.
* WorkSpaces (3.3.2.0)
	* Added new IP Access Control APIs, an API to change the state of a Workspace, and the ADMIN_MAINTENANCE WorkSpace state. With the new IP Access Control APIs, you can now create/delete IP Access Control Groups, add/delete/update rules for IP Access Control Groups, Associate/Disassociate IP Access Control Groups to/from a WorkSpaces Directory, and Describe IP Based Access Control Groups.

### 3.3.270.1 (2018-04-26 22:57 UTC)
* Glacier (3.3.2.7)
	* Documentation updates for Glacier to fix a broken link
* SecretsManager (3.3.0.5)
	* Documentation updates for secretsmanager
* Core 3.3.22.2
	* AWS CodeCommit is now available in an additional region, EU (Paris).



### 3.3.270.0 (2018-04-25 19:00 UTC)
* CodeDeploy (3.3.10.0)
	* AWS CodeDeploy has a new exception that indicates when a GitHub token is not valid.
* Rekognition (3.3.8.6)
	* Documentation updates for Amazon Rekognition.
* XRay (3.3.2.0)
	* Added PutEncryptionConfig and GetEncryptionConfig APIs for managing data encryption settings. Use PutEncryptionConfig to configure X-Ray to use an AWS Key Management Service customer master key to encrypt trace data at rest.

### 3.3.269.1 (2018-04-25 00:54 UTC)
* Core 3.3.22.1
	* Fix Exception unmarshalling for cases where the response body isn't valid JSON or XML. Fix throws of AmazonUnmarshallingException to include the StatusCode. This allows the RetryHandler to retry based on the StatusCode. 
Adding solutions for each AWS Service. The solution for each service contains the Net35, Net45, CoreCLR projects for Core, service projects, service tests and other dependencies.
	* All services packages updated to require new Core

### 3.3.269.0 (2018-04-24 18:36 UTC)
* ElasticBeanstalk (3.3.8.0)
	* Support tracking Elastic Beanstalk resources in AWS Config.
* SecretsManager (3.3.0.3)
	* Documentation updates for secretsmanager

### 3.3.268.0 (2018-04-23 20:36 UTC)
* AutoScalingPlans (3.3.1.0)
	* The release adds the operation UpdateScalingPlan for updating a scaling plan and the support for tag filters as an application source.
* IoT (3.3.10.0)
	* Add IotAnalyticsAction which sends message data to an AWS IoT Analytics channel
* IoTAnalytics (3.3.0.0)
	* Introducing AWS IoT Analytics SDK. AWS IoT Analytics provides advanced data analysis for AWS IoT. It allows you to collect large amounts of device data, process messages, store them, and then query the data and run sophisticated analytics to make accurate decisions in your IoT applications and machine learning use cases. AWS IoT Analytics enables advanced data exploration through integration with Jupyter Notebooks and data visualization through integration with Amazon QuickSight.

### 3.3.267.0 (2018-04-20 19:05 UTC)
* KinesisFirehose (3.3.4.0)
	* With this release, Amazon Kinesis Data Firehose allows you to tag your delivery streams. Tags are metadata that you can create and use to manage your delivery streams. For more information about tagging, see AWS Tagging Strategies. For technical documentation, look for the tagging operations in the Amazon Kinesis Firehose API reference.
* MediaLive (3.3.5.0)
	* With AWS Elemental MediaLive you can now output live channels as RTMP (Real-Time Messaging Protocol) and RTMPS as the encrypted version of the protocol (Secure, over SSL/TLS). RTMP is the preferred protocol for sending live streams to popular social platforms which  means you can send live channel content to social and sharing platforms in a secure and reliable way while continuing to stream to your own website, app or network.

### 3.3.266.0 (2018-04-20 04:18 UTC)
* Core 3.3.22.0
	* For the .NET Framework 3.5 and .NET Framework 4.5 environments AWS service clients will now add TLS 1.1 and TLS 1.2 to the chain of supported security protocols if the environment has been patched to support TLS 1.1 and TLS 1.2
	* All services packages updated to require new Core

### 3.3.265.0 (2018-04-20 00:33 UTC)
* CodePipeline (3.3.3.0)
	* Added new SourceRevision structure to Execution Summary with accompanying definitions as needed in the AWS CodePipeline API Guide.
* CostExplorer (3.3.3.0)
	* Starting today, you can identify opportunities for Amazon RDS cost savings using AWS Cost Explorer's API to access your Amazon RDS Reserved Instance Purchase Recommendations
* DeviceFarm (3.3.6.0)
	* Adding support for VPCEndpoint feature. Allows customers to be able to access their private endpoints/services running in their VPC during test automation.
* EC2 (3.3.48.0)
	* Added support for customers to see the time at which a Dedicated Host was allocated or released.
* RDS (3.3.22.0)
	* The ModifyDBCluster operation now includes an EngineVersion parameter. You can use this to upgrade the engine for a clustered database.
* SecretsManager (3.3.0.1)
	* Documentation updates
* SimpleSystemsManagement (3.3.20.0)
	* Added new APIs DeleteInventory and DescribeInventoryDeletions, for customers to delete their custom inventory data.
* Core 3.3.21.21
	* The new CloudHSM is now available in the AWS GovCloud (US).



### 3.3.264.0 (2018-04-10 23:42 UTC)
* DatabaseMigrationService (3.3.7.0)
	* Native Change Data Capture start point and task recovery support in Database Migration Service.  
* Glue (3.3.7.0)
	* "AWS Glue now supports timeout values for ETL jobs. With this release, all new ETL jobs have a default timeout value of 48 hours. AWS Glue also now supports the ability to start a schedule or job events trigger when it is created."
* MediaPackage (3.3.1.0)
	* Adds a new OriginEndpoint package type CmafPackage in MediaPackage. Origin endpoints can now be configured to use the Common Media Application Format (CMAF) media streaming format. This version of CmafPackage only supports HTTP Live Streaming (HLS) manifests with fragmented MP4.
* SimpleSystemsManagement (3.3.19.0)
	* Added TooManyUpdates exception for AddTagsToResource and RemoveTagsFromResource API
* WorkMail (3.3.1.0)
	* Amazon WorkMail adds the ability to grant users and groups with "Full Access", "Send As" and "Send on Behalf" permissions on a given mailbox.

### 3.3.263.0 (2018-04-10 00:37 UTC)
* CloudDirectory (3.3.7.0)
	* Cloud Directory customers can fetch attributes within a facet on an object with the new GetObjectAttributes API and can fetch attributes from multiple facets or objects with the BatchGetObjectAttributes operation.

### 3.3.262.0 (2018-04-06 19:43 UTC)
* Batch (3.3.5.0)
	* Support for Timeout in SubmitJob and RegisterJobDefinition

### 3.3.261.1 (2018-04-05 19:28 UTC)
* SimpleSystemsManagement (3.3.18.1)
	* Documentation updates for ec2

### 3.3.261.0 (2018-04-04 18:20 UTC)
* ACMPCA (3.3.0.0)
	* AWS Certificate Manager (ACM) Private Certificate Authority (CA) is a managed private CA service that helps you easily and securely manage the lifecycle of your private certificates. ACM Private CA provides you a highly-available private CA service without the upfront investment and ongoing maintenance costs of operating your own private CA. ACM Private CA extends ACM's certificate management capabilities to private certificates, enabling you to manage public and private certificates centrally.
* CertificateManager (3.3.5.0)
	* AWS Certificate Manager has added support for AWS Certificate Manager Private Certificate Authority (CA). Customers can now request private certificates with the RequestCertificate API, and also export private certificates with the ExportCertificate API.
* CloudWatch (3.3.6.0)
	* The new GetMetricData API enables you to collect batch amounts of metric data and optionally perform math expressions on the data. With one GetMetricData call you can retrieve as many as 100 different metrics and a total of 100,800 data points.
* ConfigService (3.3.15.0)
	* AWS Config introduces multi-account multi-region data aggregation features. Customers can create an aggregator (a new resource type) in AWS Config that collects AWS Config data from multiple source accounts and regions into an aggregator account. Customers can aggregate data from individual account(s) or an organization and multiple regions. In this release, AWS Config adds several API's for multi-account multi-region data aggregation.
* FMS (3.3.0.0)
	* This release is the initial release version for AWS Firewall Manager, a new AWS service that makes it easy for customers to centrally configure WAF rules across all their resources (ALBs and CloudFront distributions) and across accounts.
* S3 (3.3.18.0)
	* ONEZONE_IA storage class stores object data in only one Availability Zone at a lower price than STANDARD_IA. This SDK release provides API support for this new storage class.
* SageMaker (3.3.4.0)
	* SageMaker is now supporting many additional instance types in previously supported families for Notebooks, Training Jobs, and Endpoints. Training Jobs and Endpoints now support instances in the m5 family in addition to the previously supported instance families. For specific instance types supported please see the documentation for the SageMaker API.
* SecretsManager (3.3.0.0)
	* AWS Secrets Manager enables you to easily create and manage the secrets that you use in your customer-facing apps.  Instead of embedding credentials into your source code, you can dynamically query Secrets Manager from your app whenever you need credentials.  You can automatically and frequently rotate your secrets without having to deploy updates to your apps.  All secret values are encrypted when they're at rest with AWS KMS, and while they're in transit with HTTPS and TLS.
* TranscribeService (3.3.1.0)
	* Amazon Transcribe is an automatic speech recognition (ASR) service that makes it easy for developers to add speech to text capability to their applications. 

### 3.3.260.0 (2018-04-03 22:20 UTC)
* DeviceFarm (3.3.5.0)
	* Added Private Device Management feature. Customers can now manage their private devices efficiently - view their status, set labels and apply profiles on them. Customers can also schedule automated tests and remote access sessions on individual instances in their private device fleet.
* Lambda (3.3.13.0)
	* added nodejs8.10 as a valid runtime
* Translate (3.3.1.0)
	* This release increases the maximum size of input text to 5,000 bytes. Amazon Translate now supports automatic language detection of the input text. The translation models have been improved to increase accuracy. See the documentation for more information.

### 3.3.259.0 (2018-04-02 20:49 UTC)
* APIGateway (3.3.17.0)
	* Amazon API Gateway now supports resource policies for APIs making it easier to set access controls for invoking APIs.
* CloudFront (3.3.7.0)
	* You can now use a new Amazon CloudFront capability called Field-Level Encryption to further enhance the security of sensitive data, such as credit card numbers or personally identifiable information (PII) like social security numbers. CloudFront's field-level encryption further encrypts sensitive data in an HTTPS form using field-specific encryption keys (which you supply) before a POST request is forwarded to your origin. This ensures that sensitive data can only be decrypted and viewed by certain components or services in your application stack. Field-level encryption is easy to setup. Simply configure the fields that have to be further encrypted by CloudFront using the public keys you specify and you can reduce attack surface for your sensitive data.
* Elasticsearch (3.3.5.0)
	* This adds Amazon Cognito authentication support to Kibana.

### 3.3.258.0 (2018-03-30 20:23 UTC)
* CertificateManager (3.3.4.2)
	* Documentation updates for acm
* Connect (3.3.0.0)
	* Amazon Connect is a contact center as a service (CCaS) solution that offers easy, self-service configuration and enables dynamic, personal, and natural customer engagement at any scale. With this release of the Amazon Connect SDK, Outbound APIs (StartOutboundVoiceContact, StopContact) are now generally available. This release supports CTR generation for calls generated through the new APIs. Additionally IAM permissions are supported for the new APIs. 
* Core 3.3.21.20
	* Adding FIPS endpoint for CodeBuild service



### 3.3.257.0 (2018-03-30 00:18 UTC)
* AlexaForBusiness (3.3.2.0)
	* Adds operations for creating and managing address books of phone contacts for use in A4B managed shared devices.
* CloudFormation (3.3.10.0)
	* Enabling resource level permission control for StackSets APIs. Adding support for customers to use customized AdministrationRole to create security boundaries between different users.
* Greengrass (3.3.3.0)
	* Greengrass APIs now support creating Machine Learning resource types and configuring binary data as the input payload for Greengrass Lambda functions.
* SimpleSystemsManagement (3.3.18.0)
	* This Patch Manager release supports creating patch baselines for CentOS.

### 3.3.256.1 (2018-03-29 06:46 UTC)
* CloudFront (3.3.6.4)
	* Fixed issue with Url siginer not supporting IPv6
* RDS (3.3.21.5)
	* Fixed encoding issue when computing a presigned URL.
* S3 (3.3.17.3)	
	* Add configuration on PutObject and UploadPart to turn off chunk encoding.
* Core 3.3.21.19
	* Convert all request marshallers to singletons
	* Isolate usage of HttpClient to better handle different platforms the SDK runs on
	* Lower default chunked upload size to avoid creating LOH sized objects.
	* Remove an unnecessary await in DefaultRetryPolicy
	* Ensure service url has a trailing '/' to avoid issues when concatenating host and resource path.
	* All services packages updated to require new Core

### 3.3.256.0 (2018-03-28 23:32 UTC)
* IdentityManagement (3.3.6.0)
	* Add support for Longer Role Sessions. Four APIs manage max session duration: GetRole, ListRoles, CreateRole, and the new API UpdateRole. The max session duration integer attribute is measured in seconds.
* MTurk (3.3.2.0)
	* Added a new attribute "ActionsGuarded" to QualificationRequirement: This update allows MTurk Requester customers using the AWS SDK to control which Workers can see and preview their HITs. We now support hiding HITs from unqualified Workers' search results.
* SecurityToken (3.3.4.0)
	* Change utilizes the Max Session Duration attribute introduced for IAM Roles and allows STS customers to request session duration up to the Max Session Duration of 12 hours from AssumeRole based APIs.
* Core 3.3.21.18
	* Amazon GuardDuty API operations are now supported in the EU (Paris) region.
Amazon Workspaces is now available in ap-northeast-2



### 3.3.255.0 (2018-03-27 19:18 UTC)
* CertificateManager (3.3.4.0)
	* AWS Certificate Manager has added support for customers to disable Certificate Transparency logging on a per-certificate basis.

### 3.3.254.0 (2018-03-26 22:30 UTC)
* DynamoDBv2 (3.3.7.0)
	* Point-in-time recovery (PITR) provides continuous backups of your DynamoDB table data. With PITR, you do not have to worry about creating, maintaining, or scheduling backups. You enable PITR on your table and your backup is available for restore at any point in time from the moment you enable it, up to a maximum of the 35 preceding days. PITR provides continuous backups until you explicitly disable it. For more information, see the Amazon DynamoDB Developer Guide.

### 3.3.253.1 (2018-03-23 18:07 UTC)
* RDS (3.3.21.4)
	* Documentation updates for RDS

### 3.3.253.0 (2018-03-22 22:05 UTC)
* AppStream (3.3.11.0)
	* Feedback URL allows admins to provide a feedback link or a survey link for collecting user feedback while streaming sessions. When a feedback link is provided, streaming users will see a "Send Feedback" choice in their streaming session toolbar. On selecting this choice, user will be redirected to the link provided in a new browser tab. If a feedback link is not provided, users will not see the "Send Feedback" option. 
* CodeBuild (3.3.9.0)
	* Adding support for branch filtering when using webhooks with AWS CodeBuild. 
* ECS (3.3.13.0)
	* Amazon Elastic Container Service (ECS) now includes integrated Service Discovery using Route 53 Auto Naming. Customers can now specify a Route 53 Auto Naming service as part of an ECS service. ECS will register task IPs with Route 53, making them available via DNS in your VPC.

### 3.3.252.1 (2018-03-21 21:19 UTC)
* ServerlessApplicationRepository (3.3.1.3)
	* Documentation updates for Serverless Application Respository
* Core 3.3.21.17
	* Elemental MediaPackage is now available in the ICN and GRU regions.



### 3.3.252.0 (2018-03-20 21:17 UTC)
* CloudWatchEvents (3.3.5.0)
	* Added SQS FIFO queue target support
* ConfigService (3.3.14.0)
	* AWS Config adds support for BatchGetResourceConfig API, allowing you to batch-retrieve the current state of one or more of your resources.
* CostExplorer (3.3.2.0)
	* This launch will allow customers to access their Amazon EC2 Reserved Instance (RI) purchase recommendations programmatically via the AWS Cost Explorer API. 
* ECS (3.3.12.0)
	* Amazon ECS users can now mount a temporary volume in memory in containers and specify the shared memory that a container can use through the use of docker's 'tmpfs' and 'shm-size' features respectively. These fields can be specified under linuxParameters in ContainerDefinition in the Task Definition Template.
* ElasticBeanstalk (3.3.7.1)
	* Documentation updates for the new Elastic Beanstalk API DescribeAccountAttributes.
* Glue (3.3.6.0)
	* API Updates for DevEndpoint: PublicKey is now optional for CreateDevEndpoint. The new DevEndpoint field PrivateAddress will be populated for DevEndpoints associated with a VPC.
* MediaLive (3.3.4.0)
	* AWS Elemental MediaLive has added support for updating Inputs and Input Security Groups. You can update Input Security Groups at any time and it will update all channels using that Input Security Group. Inputs can be updated as long as they are not attached to a currently running channel.

### 3.3.251.0 (2018-03-16 20:40 UTC)
* ElasticBeanstalk (3.3.7.0)
	* AWS Elastic Beanstalk is launching a new public API named DescribeAccountAttributes which allows customers to access account level attributes. In this release, the API will support quotas for resources such as applications, application versions, and environments.

### 3.3.250.0 (2018-03-15 19:47 UTC)
* Organizations (3.3.8.0)
	* This release adds additional reason codes to improve clarity to exceptions that can occur.
* Pinpoint (3.3.7.0)
	* With this release, you can delete endpoints from your Amazon Pinpoint projects. Customers can now specify one of their leased dedicated long or short codes to send text messages.
* SageMaker (3.3.3.0)
	* This release provides support for ml.p3.xlarge instance types for notebook instances.  Lifecycle configuration is now available to customize your notebook instances on start; the configuration can be reused between multiple notebooks.  If a notebook instance is attached to a VPC you can now opt out of internet access that by default is provided by SageMaker.

### 3.3.249.2 (2018-03-14 22:38 UTC)
* Core 3.3.21.16
	* This change allows endpoint specific clock skew adjustment.
	* All services packages updated to require new Core

### 3.3.249.1 (2018-03-14 20:20 UTC)
* Lightsail (3.3.5.2)
	* Updates to existing Lightsail documentation

### 3.3.249.0 (2018-03-13 19:15 UTC)
* ServiceDiscovery (3.3.2.0)
	* This release adds support for custom health checks, which let you check the health of resources that aren't accessible over the internet. For example, you can use a custom health check when the instance is in an Amazon VPC.

### 3.3.248.0 (2018-03-12 22:42 UTC)
* ApplicationDiscoveryService (3.3.3.6)
	* Documentation updates for discovery
* CloudHSMV2 (3.3.1.0)
	* CreateCluster can now take both 8 and 17 character Subnet IDs. DeleteHsm can now take both 8 and 17 character ENI IDs.
* IoT (3.3.9.0)
	* We added new fields to the response of the following APIs. (1) describe-certificate: added new generationId, customerVersion fields (2) describe-ca-certificate: added new generationId, customerVersion and lastModifiedDate fields (3) get-policy: added generationId, creationDate and lastModifiedDate fields
* Redshift (3.3.4.0)
	* DescribeClusterSnapshotsMessage with ClusterExists flag returns snapshots of existing clusters. Else both existing and deleted cluster snapshots are returned

### 3.3.247.0 (2018-03-09 00:26 UTC)
* ECS (3.3.11.0)
	* Amazon Elastic Container Service (ECS) now supports container health checks. Customers can now specify a docker container health check command and parameters in their task definition. ECS will monitor, report and take scheduling action based on the health status.
* MigrationHub (3.3.1.0)
	* Unused key LABEL removed from ResourceAttrbute
* Pinpoint (3.3.6.0)
	* With this release, you can export endpoints from your Amazon Pinpoint projects. You can export a) all of the endpoints assigned to a project or b) the subset of endpoints assigned to a segment.
* RDS (3.3.21.2)
	* Documentation updates for RDS

### 3.3.246.0 (2018-03-08 00:42 UTC)
* MediaLive (3.3.3.0)
	* Updates API to model required traits and minimum/maximum constraints.

### 3.3.245.2 (2018-03-06 21:07 UTC)
* ECS (3.3.10.2)
	* Documentation updates for Amazon ECS

### 3.3.245.1 (2018-03-03 00:50 UTC)
* Core 3.3.21.15
	* URL encode resource path segments before canonicalization for all services except S3.
	* All services packages updated to require new Core

### 3.3.245.0 (2018-03-01 23:43 UTC)
* CloudWatchEvents (3.3.4.0)
	* Added BatchParameters to the PutTargets API
* EC2 (3.3.47.0)
	* Added support for modifying Placement Group association of instances via ModifyInstancePlacement API.
* ServiceCatalog (3.3.8.0)
	* This release of ServiceCatalog adds the DeleteTagOption API.
* SimpleSystemsManagement (3.3.17.0)
	* This Inventory release supports the status message details reported by the last sync for the resource data sync API.
* StorageGateway (3.3.7.0)
	* AWS Storage Gateway (File) support for two new file share attributes are added.           1. Users can specify the S3 Canned ACL to use for new objects created in the file share.         2. Users can create file shares for requester-pays buckets.

### 3.3.244.0 (2018-02-28 22:16 UTC)
* ApplicationAutoScaling (3.3.9.0)
	* Application Auto Scaling now supports automatic scaling of SageMaker Production Variants on an Endpoint.

### 3.3.243.1 (2018-02-28 02:38 UTC)
* ECR (3.3.3.3)
	* Documentation updates for Amazon ECR.

### 3.3.243.0 (2018-02-27 16:47 UTC)
* Route53 (3.3.15.0)
	* Added support for creating LBR rules using ap-northeast-3 region.
* SecurityToken (3.3.3.4)
	* Increased SAMLAssertion parameter size from 50000 to 100000 for AWS Security Token Service AssumeRoleWithSAML API to allow customers to pass bigger SAML assertions

### 3.3.242.0 (2018-02-24 01:00 UTC)
* EC2 (3.3.46.0)
	* Updated to use new Core, version 3.3.21.14
	* You can now use AWS_EC2_METADATA_DISABLED environment variable to control SDK access to EC2 IMDS service.
* Core 3.3.21.14
	* You can now use  AWS_EC2_METADATA_DISABLED environment variable to control SDK access to EC2 IMDS service.  This release also removes InstanceProfileAWSCredentials from PCL.

### 3.3.241.0 (2018-02-23 19:52 UTC)
* AppStream (3.3.10.0)
	* This API update is to enable customers to copy their Amazon AppStream 2.0 images within and between AWS Regions

### 3.3.240.0 (2018-02-22 19:30 UTC)
* CostExplorer (3.3.1.0)
	* Added GetReservationCoverage API for retrieving reservation coverage information.
* ElasticLoadBalancingV2 (3.3.8.1)
	* Added a new load balancer attribute related to Network Load Balancers that enables cross zone capabilities. This feature allows Network Load Balancers to distribute requests regardless of Availability Zone.

### 3.3.239.0 (2018-02-21 20:41 UTC)
* CodeCommit (3.3.4.0)
	* This release adds an API for adding a file directly to an AWS CodeCommit repository without requiring a Git client.
* EC2 (3.3.45.0)
	* Adds support for tagging an EBS snapshot as part of the API call that creates the EBS snapshot
* ServerlessApplicationRepository (3.3.1.0)
	* Added support for delete-application API and the ability for developers to set a homepage for their application. The homepage is a URL with more information about the application, for example the location of your GitHub repository for the application. 
* Core 3.3.21.13
	* Mediapackage expands their service to FRA and CDG regions.



### 3.3.238.0 (2018-02-20 22:50 UTC)
* AutoScaling (3.3.4.0)
	* Amazon EC2 Auto Scaling support for service-linked roles
* WAF (3.3.5.0)
	* The new PermissionPolicy APIs in AWS WAF Regional allow customers to attach resource-based policies to their entities.
* WAFRegional (3.3.4.0)
	* The new PermissionPolicy APIs in AWS WAF Regional allow customers to attach resource-based policies to their entities.

### 3.3.237.0 (2018-02-19 20:50 UTC)
* ConfigService (3.3.13.0)
	* With this release, AWS Config updated the ConfigurationItemStatus enum values. The values prior to this update did not represent appropriate values returned by GetResourceConfigHistory. You must update your code to enumerate the new enum values so this is a breaking change.  To map old properties to new properties, use the following descriptions: New discovered resource - Old property: Discovered, New property: ResourceDiscovered. Updated resource - Old property: Ok, New property: OK. Deleted resource - Old property: Deleted, New property: ResourceDeleted or ResourceDeletedNotRecorded. Not-recorded resource - Old property: N/A, New property: ResourceNotRecorded or ResourceDeletedNotRecorded.

### 3.3.236.0 (2018-02-16 20:53 UTC)
* RDS (3.3.21.0)
	* Updates RDS API to indicate whether a DBEngine supports read replicas.

### 3.3.235.0 (2018-02-15 22:56 UTC)
* GameLift (3.3.11.0)
	* Updates to allow Fleets to run on On-Demand or Spot instances.
* MediaConvert (3.3.1.0)
	* Nielsen ID3 tags can now be inserted into transport stream (TS) and HLS outputs. For more information on Nielsen configuration you can go to https://docs.aws.amazon.com/mediaconvert/latest/apireference/jobs.html#jobs-nielsenconfiguration
* Core 3.3.21.12
	* Launch AWS CodeStar in the Asia Pacific Northeast 2 (ICN) region.



### 3.3.234.0 (2018-02-14 23:24 UTC)
* AppSync (3.3.1.0)
	* AWS AppSync now supports for None Data Source, CreateApiKey now supports setting expiration on API keys, new API UpdateApiKey supports updating expiration on API keys. 
* LexModelBuildingService (3.3.6.0)
	* Amazon Lex now provides the ability to export and import your Amazon Lex chatbot definition as a JSON file.

### 3.3.233.0 (2018-02-13 22:15 UTC)
* Glacier (3.3.2.1)
	* Documentation updates for glacier
* Route53 (3.3.14.0)
	* Added support for creating Private Hosted Zones and metric-based healthchecks in the ap-northeast-3 region for whitelisted customers.

### 3.3.232.0 (2018-02-12 23:33 UTC)
* CognitoIdentityProvider (3.3.9.0)
	* Support for user migration using AWS Lambda trigger. Support to obtain signing certificate for user pools.
* EC2 (3.3.44.0)
	* Network interfaces now supply the following additional status of "associated" to better distinguish the current status.
* GuardDuty (3.3.2.0)
	* Added PortProbeAction information to the Action section of the port probe-type finding.
* KeyManagementService (3.3.5.0)
	* This release of AWS Key Management Service includes support for InvalidArnException in the RetireGrant API.
* RDS (3.3.20.1)
	* Aurora MySQL now supports MySQL 5.7.

### 3.3.231.0 (2018-02-09 22:53 UTC)
* EC2 (3.3.43.0)
	* Users can now better understand the longer ID opt-in status of their account using the two new APIs DescribeAggregateIdFormat and DescribePrincipalIdFormat
* Lex (3.3.3.0)
	* You can now define a response for your Amazon Lex chatbot directly from the AWS console. A response consists of messages dynamically selected from a group of pre-defined messages, populated by the developer.
* LexModelBuildingService (3.3.5.0)
	* You can now define a response for your Amazon Lex chatbot directly from the AWS console. A response consists of messages dynamically selected from a group of pre-defined messages, populated by the developer.

### 3.3.230.0 (2018-02-08 23:07 UTC)
* AppStream (3.3.9.0)
	* Adds support for allowing customers to provide a redirect URL for a stack. Users will be redirected to the link provided by the admin at the end of their streaming session. 
* Budgets (3.3.7.0)
	* Making budgetLimit and timePeriod optional, and updating budgets docs. 
* DatabaseMigrationService (3.3.6.0)
	* This release includes the addition of two new APIs: describe replication instance task logs and reboot instance. The first allows user to see how much storage each log for a task on a given instance is occupying. The second gives users the option to reboot the application software on the instance and force a fail over for MAZ instances to test robustness of their integration with our service. 
* DirectoryService (3.3.4.0)
	* Updated the regex of some input parameters to support longer EC2 identifiers.
* DynamoDBv2 (3.3.6.0)
	* Amazon DynamoDB now supports server-side encryption using a default service key (alias/aws/dynamodb) from the AWS Key Management Service (KMS). AWS KMS is a service that combines secure, highly available hardware and software to provide a key management system scaled for the cloud. AWS KMS is used via the AWS Management Console or APIs to centrally create encryption keys, define the policies that control how keys can be used, and audit key usage to prove they are being used correctly. For more information, see the Amazon DynamoDB Developer Guide.
* GameLift (3.3.10.0)
	* Amazon GameLift FlexMatch added the StartMatchBackfill API.  This API allows developers to add new players to an existing game session using the same matchmaking rules and player data that were used to initially create the session.
* MediaLive (3.3.2.0)
	* AWS Elemental MediaLive has added support for updating channel settings for idle channels. You can now update channel name, channel outputs and output destinations, encoder settings, user role ARN, and input specifications. Channel settings can be updated in the console or with API calls. Please note that running channels need to be stopped before they can be updated. We've also deprecated the 'Reserved' field.
* MediaStore (3.3.1.0)
	* AWS Elemental MediaStore now supports per-container CORS configuration.
* Core 3.3.21.11
	* We marked Inspector GA yesterday. 2/.5/18.



### 3.3.229.0 (2018-02-06 22:00 UTC)
* Glue (3.3.5.0)
	* This new feature will now allow customers to add a customized json classifier. They can specify a json path to indicate the object, array or field of the json documents they'd like crawlers to inspect when they crawl json files. 
* ServiceCatalog (3.3.7.0)
	* This release of Service Catalog adds SearchProvisionedProducts API and ProvisionedProductPlan APIs.
* ServiceDiscovery (3.3.1.0)
	* This release adds support for registering CNAME record types and creating Route 53 alias records that route traffic to Amazon Elastic Load Balancers using Amazon Route 53 Auto Naming APIs.
* SimpleSystemsManagement (3.3.16.0)
	* This Patch Manager release supports configuring Linux repos as part of patch baselines, controlling updates of non-OS security packages and also creating patch baselines for SUSE12

### 3.3.228.0 (2018-02-05 21:19 UTC)
* CertificateManager (3.3.3.1)
	* Documentation updates for acm
* Cloud9 (3.3.0.1)
	* API usage examples for AWS Cloud9.
* Kinesis (3.3.5.0)
	* Using ListShards a Kinesis Data Streams customer or client can get information about shards in a data stream (including meta-data for each shard) without obtaining data stream level information.
* OpsWorks (3.3.3.0)
	* AWS OpsWorks Stacks supports EBS encryption and HDD volume types. Also, a new DescribeOperatingSystems API is available, which lists all operating systems supported by OpsWorks Stacks.
* S3 (3.3.17.0)
	* Fix incorrect marshaller for S3 RestoreObject request.
* Core 3.3.21.10
	* Validate the role paramater when creating InstanceProfileAWSCredentials.


### 3.3.227.0 (2018-01-26 22:17 UTC)
* DeviceFarm (3.3.4.0)
	* Add InteractionMode in CreateRemoteAccessSession for DirectDeviceAccess feature.
* MediaLive (3.3.1.0)
	* Add InputSpecification to CreateChannel (specification of input attributes is used for channel sizing and affects pricing);  add NotFoundException to DeleteInputSecurityGroups.
* MTurk (3.3.1.4)
	* Documentation updates for mturk-requester

### 3.3.226.0 (2018-01-25 22:41 UTC)
* AlexaForBusiness (3.3.1.0)
	* Supports new field for DeviceStatusInfo which provides details about the DeviceStatus following a DeviceSync operation.
* CodeBuild (3.3.8.0)
	* Adding support for Shallow Clone and GitHub Enterprise in AWS CodeBuild.
* GuardDuty (3.3.1.0)
	* Added the missing AccessKeyDetails object to the resource shape.
* Lambda (3.3.12.0)
	* AWS Lambda now supports Revision ID on your function versions and aliases, to track and apply conditional updates when you are updating your function version or alias resources.
* Core 3.3.21.9
	* Added service signing name.
This API update is to support Amazon AppStream 2.0's launch into the Asia Pacific (Singapore) and Asia Pacific (Sydney) regions.



### 3.3.225.0 (2018-01-23 02:32 UTC)
* Budgets (3.3.6.0)
	* Add additional costTypes: IncludeDiscount, UseAmortized,  to support finer control for different charges included in a cost budget.

### 3.3.224.0 (2018-01-19 20:44 UTC)
* Glue (3.3.4.0)
	* New AWS Glue DataCatalog APIs to manage table versions and a new feature to skip archiving of the old table version when updating table.
* TranscribeService (3.3.0.0)
	* Amazon Transcribe Public Preview Release
* Core 3.3.21.8
	* Fix issue signing request with x-amzn-trace-id

### 3.3.223.0 (2018-01-18 01:05 UTC)
* SageMaker (3.3.2.0)
	* CreateTrainingJob and CreateEndpointConfig now supports KMS Key for volume encryption. 

### 3.3.222.1 (2018-01-17 19:52 UTC)
* AutoScalingPlans (3.3.0.1)
	* Documentation updates for autoscaling-plans
* EC2 (3.3.42.1)
	* Documentation updates for EC2

### 3.3.222.0 (2018-01-17 00:00 UTC)
* ApplicationAutoScaling (3.3.8.0)
	* Application Auto Scaling is adding support for Target Tracking Scaling for ECS services.
* AutoScalingPlans (3.3.0.0)
	* AWS Auto Scaling enables you to quickly discover all of the scalable resources underlying your application and set up application scaling in minutes using built-in scaling recommendations.
* RDS (3.3.20.0)
	* With this release you can now integrate RDS DB instances with CloudWatch Logs. We have added parameters to the operations for creating and modifying DB instances (for example CreateDBInstance) to allow you to take advantage of this capability through the CLI and API. Once you enable this feature, a stream of log events will publish to CloudWatch Logs for each log type you enable.
* Core 3.3.21.7
	* Amazon Workspaces is now available in sa-east-1



### 3.3.221.0 (2018-01-15 23:31 UTC)
* Lambda (3.3.11.0)
	* Support for creating Lambda Functions using 'dotnetcore2.0' and 'go1.x'. 

### 3.3.220.0 (2018-01-12 21:20 UTC)
* Glue (3.3.3.0)
	* Support is added to generate ETL scripts in Scala which can now be run by  AWS Glue ETL jobs. In addition, the trigger API now supports firing when any conditions are met (in addition to all conditions). Also, jobs can be triggered based on a "failed" or "stopped" job run (in addition to a "succeeded" job run). 

### 3.3.219.0 (2018-01-11 20:40 UTC)
* ElasticLoadBalancing (3.3.2.0)
	* Added OperationNotPermittedException to indicate that you cannot create a classic load balancer while deleting the Elastic Load Balancing service-linked role.
* ElasticLoadBalancingV2 (3.3.8.0)
	* Added OperationNotPermittedException to indicate that you cannot create a load balancer while deleting the Elastic Load Balancing service-linked role.
* RDS (3.3.19.0)
	* Read Replicas for Amazon RDS for MySQL, MariaDB, and PostgreSQL now support Multi-AZ deployments.Amazon RDS Read Replicas enable you to create one or more read-only copies of your database instance within the same AWS Region or in a different AWS Region. Updates made to the source database are asynchronously copied to the Read Replicas. In addition to providing scalability for read-heavy workloads, you can choose to promote a Read Replica to become standalone a DB instance when needed.Amazon RDS Multi-AZ Deployments provide enhanced availability for database instances within a single AWS Region. With Multi-AZ, your data is synchronously replicated to a standby in a different Availability Zone (AZ). In case of an infrastructure failure, Amazon RDS performs an automatic failover to the standby, minimizing disruption to your applications.You can now combine Read Replicas with Multi-AZ as part of a disaster recovery strategy for your production databases. A well-designed and tested plan is critical for maintaining business continuity after a disaster. Since Read Replicas can also be created in different regions than the source database, your Read Replica can be promoted to become the new production database in case of a regional disruption.You can also combine Read Replicas with Multi-AZ for your database engine upgrade process. You can create a Read Replica of your production database instance and upgrade it to a new database engine version. When the upgrade is complete, you can stop applications, promote the Read Replica to a standalone database instance and switch over your applications. Since the database instance is already a Multi-AZ deployment, no additional steps are needed.For more information, see the Amazon RDS User Guide.
* SimpleSystemsManagement (3.3.15.2)
	* Updates documentation for the HierarchyLevelLimitExceededException error.

### 3.3.218.1 (2018-01-09 21:59 UTC)
* KeyManagementService (3.3.4.2)
	* Documentation updates for AWS KMS

### 3.3.218.0 (2018-01-09 16:46 UTC)
* DirectoryService (3.3.3.0)
	* On October 24 we introduced AWS Directory Service for Microsoft Active Directory (Standard Edition), also known as AWS Microsoft AD (Standard Edition), which is a managed Microsoft Active Directory (AD) that is optimized for small and midsize businesses (SMBs). With this SDK release, you can now create an AWS Microsoft AD directory using API. This enables you to run typical SMB workloads using a cost-effective, highly available, and managed Microsoft AD in the AWS Cloud.

### 3.3.217.0 (2018-01-08 23:53 UTC)
* ApplicationDiscoveryService (3.3.3.4)
	* Documentation updates for AWS Application Discovery Service.
* CodeDeploy (3.3.9.0)
	* The AWS CodeDeploy API was updated to support DeleteGitHubAccountToken, a new method that deletes a GitHub account connection.
* Route53 (3.3.13.0)
	* This release adds an exception to the CreateTrafficPolicyVersion API operation.

### 3.3.216.0 (2018-01-05 21:41 UTC)
* Inspector (3.3.4.0)
	* Added 2 new attributes to the DescribeAssessmentTemplate response, indicating the total number of assessment runs and last assessment run ARN (if present.)
* SimpleSystemsManagement (3.3.15.1)
	* Documentation updates for ssm
* Snowball (3.3.2.10)
	* Documentation updates for snowball

### 3.3.215.1 (2018-01-02 21:36 UTC)
* RDS (3.3.18.1)
	* Documentation updates for rds

### 3.3.215.0 (2017-12-29 17:27 UTC)
* WorkSpaces (3.3.1.0)
	* Modify WorkSpaces have been updated with flexible storage and switching of hardware bundles feature. The following configurations have been added to ModifyWorkSpacesProperties: storage and compute. This update provides the capability to configure the storage of a WorkSpace. It also adds the capability of switching hardware bundle of a WorkSpace by specifying an eligible compute (Value, Standard, Performance, Power).

### 3.3.214.1 (2017-12-23 05:31 UTC)
* S3 (3.3.16.2)
	* Updated to use new Core, version 3.3.21.6
	* Handle S3 EventType ConstantClass discrepancy between the S3 service sending strings with the s3: prefix and lambda not sending the prefix.
* Core 3.3.21.6
	* Allow service assemblies to override how ConstantClass childs are compared

### 3.3.214.0 (2017-12-22 20:52 UTC)
* EC2 (3.3.42.0)
	* This release fixes an issue with tags not showing in DescribeAddresses responses.
* ECS (3.3.10.0)
	* Amazon ECS users can now set a health check initialization wait period of their ECS services, the services that are associated with an Elastic Load Balancer (ELB) will wait for a period of time before the ELB become healthy. You can now configure this in Create and Update Service.
* Inspector (3.3.3.0)
	* PreviewAgents API now returns additional fields within the AgentPreview data type. The API now shows the agent health and availability status for all instances included in the assessment target. This allows users to check the health status of Inspector Agents before running an assessment. In addition, it shows the instance ID, hostname, and IP address of the targeted instances.
* SageMaker (3.3.1.0)
	* SageMaker Models no longer support SupplementalContainers.  API's that have been affected are CreateModel and DescribeModel.

### 3.3.213.0 (2017-12-21 23:04 UTC)
* CodeBuild (3.3.7.0)
	* Adding support allowing AWS CodeBuild customers to select specific curated image versions.
* EC2 (3.3.41.0)
	* Elastic IP tagging enables you to add key and value metadata to your Elastic IPs so that you can search, filter, and organize them according to your organization's needs.
* KinesisAnalytics (3.3.4.0)
	* Kinesis Analytics now supports AWS Lambda functions as output.

### 3.3.212.0 (2017-12-20 22:31 UTC)
* ConfigService (3.3.12.0)
	* Update ResourceType enum with values for WAF, WAFRegional, and CloudFront resources
* IoT (3.3.8.0)
	* This release adds support for code signed Over-the-air update functionality for Amazon FreeRTOS. Users can now create and schedule Over-the-air updates to their Amazon FreeRTOS devices using these new APIs. 
* Core 3.3.21.5
	* Launch AWS CodeStar in the Asia Pacific (Tokyo) and Canada (Central) regions. 



### 3.3.211.0 (2017-12-19 22:04 UTC)
* APIGateway (3.3.16.0)
	* API Gateway now adds support for calling API with compressed payloads using one of the supported content codings, tagging an API stage for cost allocation, and returning API keys from a custom authorizer for use with a usage plan.
* MediaStoreData (3.3.0.1)
	* Documentation updates for mediastore
* Route53 (3.3.12.0)
	* Route 53 added support for a new China (Ningxia) region, cn-northwest-1. You can now specify cn-northwest-1 as the region for latency-based or geoproximity routing. Route 53 also added support for a new EU (Paris) region, eu-west-3. You can now associate VPCs in eu-west-3 with private hosted zones and create alias records that route traffic to resources in eu-west-3.

### 3.3.210.1 (2017-12-19 05:59 UTC)
* CloudWatch (3.3.5.1)
	* Documentation updates for monitoring
* S3 (3.3.16.1)
	* New region launch eu-west-3
* Core 3.3.21.4
	* New region launch eu-west-3 and pipeline customization change.

### 3.3.210.0 (2017-12-15 20:51 UTC)
* AppStream (3.3.8.0)
	* This API update is to enable customers to add tags to their Amazon AppStream 2.0 resources
* Core 3.3.21.3
	* expand the region support of Inspector to FRA (eu-central-1)



### 3.3.209.0 (2017-12-14 22:13 UTC)
* APIGateway (3.3.15.0)
	* Adds support for Cognito Authorizer scopes at the API method level.
* SimpleEmail (3.3.6.1)
	* Added information about the maximum number of transactions per second for the SendCustomVerificationEmail operation.
* Core 3.3.21.2
	* Updated endpoints.json to include cn-northwest-1

### 3.3.208.0 (2017-12-12 20:10 UTC)
* CodeDeploy (3.3.8.1)
	* Documentation updates for CodeDeploy.
* WorkMail (3.3.0.0)
	* Today, Amazon WorkMail released an administrative SDK and enabled AWS CloudTrail integration. With the administrative SDK, you can natively integrate WorkMail with your existing services. The SDK enables programmatic user, resource, and group management through API calls. This means your existing IT tools and workflows can now automate WorkMail management, and third party applications can streamline WorkMail migrations and account actions. 

### 3.3.207.0 (2017-12-11 22:23 UTC)
* CognitoIdentityProvider (3.3.8.0)
	* Exposing the hosted UI domain name for a user pool that has a domain configured.
* LexModelBuildingService (3.3.4.0)
	* The GetBotChannelAssociation API now returns the status and failure reason, if any, for a bot channel.
* S3 (3.3.16.0)
	* New region cn-northwest-1 support.
* Core 3.3.21.1
	* New region cn-northwest-1

### 3.3.206.0 (2017-12-08 22:48 UTC)
* AppStream (3.3.7.0)
	* This API update is to support the feature that allows customers to automatically consume the latest Amazon AppStream 2.0 agent as and when published by AWS.
* CloudWatch (3.3.5.0)
	* With this launch, you can now create a CloudWatch alarm that alerts you when M out of N datapoints of a metric are breaching your predefined threshold, such as three out of five times in any given five minutes interval or two out of six times in a thirty minutes interval. When M out of N datapoints are not breaching your threshold in an interval, the alarm will be in OK state. Please note that the M datapoints out of N datapoints in an interval can be of any order and does not need to be consecutive. Consequently, you can now get alerted even when the spikes in your metrics are intermittent over an interval.
* ECS (3.3.9.2)
	* Documentation updates for Windows containers.

### 3.3.205.0 (2017-12-07 17:40 UTC)
* Elasticsearch (3.3.4.0)
	* Added support for encryption of data at rest on Amazon Elasticsearch Service using AWS KMS
* SimpleEmail (3.3.6.0)
	* Customers can customize the emails that Amazon SES sends when verifying new identities. This feature is helpful for developers whose applications send email through Amazon SES on behalf of their customers.
* Core 3.3.21.0
	* Add WebExceptionStatus.Timeout to the default retry list.

### 3.3.204.0 (2017-12-06 21:05 UTC)
* CloudDirectory (3.3.6.0)
	* Amazon Cloud Directory makes it easier for you to apply schema changes across your directories with in-place schema upgrades. Your directories now remain available while backward-compatible schema changes are being applied, such as the addition of new fields. You also can view the history of your schema changes in Cloud Directory by using both major and minor version identifiers, which can help you track and audit schema versions across directories.
* ElasticBeanstalk (3.3.6.3)
	* Documentation updates for AWS Elastic Beanstalk.

### 3.3.203.0 (2017-12-05 22:48 UTC)
* IoT (3.3.7.0)
	* Add error action API for RulesEngine. 
* ServiceCatalog (3.3.6.0)
	* ServiceCatalog has two distinct personas for its use, an "admin" persona (who creates sets of products with different versions and prescribes who has access to them) and an "end-user" persona (who can launch cloud resources based on the configuration data their admins have given them access to).  This API update will allow admin users to deactivate/activate product versions, end-user will only be able to access and launch active product versions. 
* ServiceDiscovery (3.3.0.0)
	* Amazon Route 53 Auto Naming lets you configure public or private namespaces that your microservice applications run in. When instances of the service become available, you can call the Auto Naming API to register the instance, and Amazon Route 53 automatically creates up to five DNS records and an optional health check. Clients that submit DNS queries for the service receive an answer that contains up to eight healthy records.

### 3.3.202.0 (2017-12-04 20:28 UTC)
* Budgets (3.3.5.0)
	* Add additional costTypes to support finer control for different charges included in a cost budget.
* ECS (3.3.9.1)
	* Documentation updates for ecs

### 3.3.201.0 (2017-11-30 18:22 UTC)
* AlexaForBusiness (3.3.0.0)
	* Alexa for Business is now generally available for production use. Alexa for Business makes it easy for you to use Alexa in your organization. The Alexa for Business SDK gives you APIs to manage Alexa devices, enroll users, and assign skills at scale. For more information about Alexa for Business, go to https://aws.amazon.com/alexaforbusiness 
* APIGateway (3.3.14.0)
	* Added support Private Integration and VPC Link features in API Gateway. This allows to create an API with the API Gateway private integration, thus providing clients access to HTTP/HTTPS resources in an Amazon VPC from outside of the VPC through a VpcLink resource.
* Cloud9 (3.3.0.0)
	* Adds support for creating and managing AWS Cloud9 development environments. AWS Cloud9 is a cloud-based integrated development environment (IDE) that you use to write, run, and debug code.
* EC2 (3.3.40.0)
	* Adds the following updates: 1. Spread Placement ensures that instances are placed on distinct hardware in order to reduce correlated failures. 2. Inter-region VPC Peering allows customers to peer VPCs across different AWS regions without requiring additional gateways, VPN connections or physical hardware 
* Lambda (3.3.10.0)
	* AWS Lambda now supports the ability to set the concurrency limits for individual functions, and increasing memory to 3008 MB.
* ServerlessApplicationRepository (3.3.0.0)
	* First release of the AWS Serverless Application Repository SDK

### 3.3.200.0 (2017-11-30 03:52 UTC)
* AutoScaling (3.3.3.0)
	* You can now use Auto Scaling with EC2 Launch Templates via the CreateAutoScalingGroup and UpdateAutoScalingGroup APIs.
* EC2 (3.3.39.0)
	* Adds the following updates: 1. T2 Unlimited enables high CPU performance for any period of time whenever required 2. You are now able to create and launch EC2 m5 and h1 instances
* Lightsail (3.3.5.0)
	* This release adds support for load balancer and TLS/SSL certificate management. This set of APIs allows customers to create, manage, and scale secure load balanced applications on Lightsail infrastructure. To provide support for customers who manage their DNS on Lightsail, we've added the ability create an Alias A type record which can point to a load balancer DNS name via the CreateDomainEntry API http://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateDomainEntry.html.
* ResourceGroups (3.3.0.0)
	* AWS Resource Groups lets you search and group AWS resources from multiple services based on their tags.
* SimpleSystemsManagement (3.3.15.0)
	* This release updates AWS Systems Manager APIs to enable executing automations at controlled rate, target resources in a resource groups and execute entire automation at once or single step at a time. It is now also possible to use YAML, in addition to JSON, when creating Systems Manager documents.
* WAF (3.3.4.0)
	* This release adds support for rule group and managed rule group. Rule group is a container of rules that customers can create, put rules in it and associate the rule group to a WebACL. All rules in a rule group will function identically as they would if each rule was individually associated to the WebACL. Managed rule group is a pre-configured rule group composed by our security partners and made available via the AWS Marketplace. Customers can subscribe to these managed rule groups, associate the managed rule group to their WebACL and start using them immediately to protect their resources.
* WAFRegional (3.3.3.0)
	* This release adds support for rule group and managed rule group. Rule group is a container of rules that customers can create, put rules in it and associate the rule group to a WebACL. All rules in a rule group will function identically as they would if each rule was individually associated to the WebACL. Managed rule group is a pre-configured rule group composed by our security partners and made available via the AWS Marketplace. Customers can subscribe to these managed rule groups, associate the managed rule group to their WebACL and start using them immediately to protect their resources.

### 3.3.199.0 (2017-11-29 20:33 UTC)
* Comprehend (3.3.0.0)
	* Amazon Comprehend is an AWS service for gaining insight into the content of text and documents . It develops insights by recognizing the entities, key phrases, language, sentiments, and other common elements in a document. For more information, go to the Amazon Comprehend product page. To get started, see the Amazon Comprehend Developer Guide.
* DynamoDBv2 (3.3.5.0)
	* Amazon DynamoDB now supports the following features: Global Table and On-Demand Backup. Global Table is a fully-managed, multi-region, multi-master database. DynamoDB customers can now write anywhere and read anywhere with single-digit millisecond latency by performing database operations closest to where end users reside. Global Table also enables customers to disaster-proof their applications, keeping them running and data accessible even in the face of natural disasters or region disruptions. Customers can set up Global Table with just a few clicks in the AWS Management Console-no application rewrites required. On-Demand Backup capability is to protect data from loss due to application errors, and meet customers' archival needs for compliance and regulatory reasons. Customers can backup and restore their DynamoDB table data anytime, with a single-click in the AWS management console or a single API call. Backup and restore actions execute with zero impact on table performance or availability. For more information, see the Amazon DynamoDB Developer Guide.
* ECS (3.3.9.0)
	* Amazon Elastic Container Service (Amazon ECS) released a new launch type for running containers on a serverless infrastructure. The Fargate launch type allows you to run your containerized applications without the need to provision and manage the backend infrastructure. Just register your task definition and Fargate launches the container for you. 
* Glacier (3.3.2.0)
	* This release includes support for Glacier Select, a new feature that allows you to filter and analyze your Glacier archives and store the results in a user-specified S3 location.
* Greengrass (3.3.2.0)
	* Greengrass OTA feature allows updating Greengrass Core and Greengrass OTA Agent. Local Resource Access feature allows Greengrass Lambdas to access local resources such as peripheral devices and volumes.
* IoT (3.3.6.0)
	* This release adds support for a number of new IoT features, including AWS IoT Device Management (Jobs, Fleet Index and Thing Registration), Thing Groups, Policies on Thing Groups, Registry & Job Events, JSON Logs, Fine-Grained Logging Controls, Custom Authorization and AWS Service Authentication Using X.509 Certificates.
* IoTJobsDataPlane (3.3.0.0)
	* This release adds support for new the service called Iot Jobs. This client is built for the device SDK to use Iot Jobs Device specific APIs.
* KinesisVideo (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* KinesisVideoArchivedMedia (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* KinesisVideoMedia (3.3.0.0)
	* Announcing Amazon Kinesis Video Streams, a fully managed video ingestion and storage service. Kinesis Video Streams makes it easy to securely stream video from connected devices to AWS for machine learning, analytics, and processing. You can also stream other time-encoded data like RADAR and LIDAR signals using Kinesis Video Streams.
* Rekognition (3.3.8.0)
	* This release introduces Amazon Rekognition support for video analysis.
* S3 (3.3.15.0)
	* This release includes support for Glacier Select, a new feature that allows you to filter and analyze  your Glacier storage class objects and store the results in a user-specified S3 location.
* SageMaker (3.3.0.0)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* SageMakerRuntime (3.3.0.0)
	* Amazon SageMaker is a fully-managed service that enables data scientists and developers to quickly and easily build, train, and deploy machine learning models, at scale.
* Translate (3.3.0.0)
	* Public preview release of Amazon Translate and the Amazon Translate Developer Guide. For more information, see the Amazon Translate Developer Guide.

### 3.3.198.0 (2017-11-29 06:01 UTC)
* APIGateway (3.3.13.0)
	* Changes related to CanaryReleaseDeployment feature. Enables API developer to create a deployment as canary deployment and test API changes with percentage of customers before promoting changes to all customers.
* AppSync (3.3.0.0)
	* AWS AppSync is an enterprise-level, fully managed GraphQL service with real-time data synchronization and offline programming features.
* Batch (3.3.4.0)
	* Add support for Array Jobs which allow users to easily submit many copies of a job with a single API call.  This change also enhances the job dependency model to support N_TO_N and sequential dependency chains. The ListJobs and DescribeJobs APIs now have the ability to list or describe the status of entire Array Jobs or individual elements within the array.
* CodeDeploy (3.3.8.0)
	* Support for AWS Lambda function deployment - AWS CodeDeploy now supports the deployment of AWS Lambda functions. A Lambda deployment uses a Lambda function alias to shift traffic to a new version. You select a deployment configuration that specifies exactly how traffic shifts to your new version. Success of a deployment can be validated using Lambda functions that are referenced by the deployment. This provides the opportunity to rollback if necessary.
* CognitoIdentityProvider (3.3.7.0)
	* AWS Cognito SDK has been updated to support new Cognito user-pool objects and operations for advanced security
* EC2 (3.3.38.0)
	* Adds the following updates: 1. You are now able to host a service powered by AWS PrivateLink to provide private connectivity to other VPCs. You are now also able to create endpoints to other services powered by PrivateLink including AWS services, Marketplace Seller services or custom services created by yourself or other AWS VPC customers. 2. You are now able to save launch parameters in a single template that can be used with Auto Scaling, Spot Fleet, Spot, and On Demand instances. 3. You are now able to launch Spot instances via the RunInstances API, using a single additional parameter. RunInstances will response synchronously with an instance ID should capacity be available for your Spot request. 4. A simplified Spot pricing model which delivers low, predictable prices that adjust gradually, based on long-term trends in supply and demand. 5. Amazon EC2 Spot can now hibernate Amazon EBS-backed instances in the event of an interruption, so your workloads pick up from where they left off. Spot can fulfill your request by resuming instances from a hibernated state when capacity is available.
* GuardDuty (3.3.0.0)
	* Enable Amazon GuardDuty to continuously monitor and process AWS data sources to identify threats to your AWS accounts and workloads.  You can add customization by uploading additional threat intelligence lists and IP safe lists. You can list security findings, suspend, and disable the service. 
* Lambda (3.3.9.0)
	* Lambda aliases can now shift traffic between two function versions, based on preassigned weights.
* MQ (3.3.0.0)
	* This is the initial SDK release for Amazon MQ. Amazon MQ is a managed message broker service for Apache ActiveMQ that makes it easy to set up and operate message brokers in the cloud. 

### 3.3.197.0 (2017-11-27 09:02 UTC)
* MediaConvert (3.3.0.0)
	* AWS Elemental MediaConvert is a file-based video conversion service that transforms media into formats required for traditional broadcast and for internet streaming to multi-screen devices.
* MediaLive (3.3.0.0)
	* AWS Elemental MediaLive is a video service that lets you easily create live outputs for broadcast and streaming delivery.
* MediaPackage (3.3.0.0)
	* AWS Elemental MediaPackage is a just-in-time video packaging and origination service that lets you format highly secure and reliable live outputs for a variety of devices.
* MediaStore (3.3.0.0)
	* AWS Elemental MediaStore is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore acts as the origin store in your video workflow.
* MediaStoreData (3.3.0.0)
	* AWS Elemental MediaStore is an AWS storage service optimized for media. It gives you the performance, consistency, and low latency required to deliver live and on-demand video content. AWS Elemental MediaStore acts as the origin store in your video workflow.
* Core 3.3.20.0
	* Added generator changes for Elemental Data Plane.

### 3.3.196.0 (2017-11-22 23:16 UTC)
* CertificateManager (3.3.3.0)
	* AWS Certificate Manager now supports the ability to import domainless certs and additional Key Types as well as an additional validation method for DNS.
* Core 3.3.19.1
	* Amazon Lex is now available in the EU (Ireland) region.
Amazon Lex is now available in the EU (Ireland) region.



### 3.3.195.0 (2017-11-22 02:27 UTC)
* APIGateway (3.3.12.0)
	* Add support for Access logs and customizable integration timeouts
* CloudFormation (3.3.9.0)
	* 1) Instance-level parameter overrides (CloudFormation-StackSet feature): This feature will allow the customers to override the template parameters on specific stackInstances. Customers will also have ability to update their existing instances with/without parameter-overrides using a new API "UpdateStackInstances"                                                                                                                                                                                                                                                         2) Add support for SSM parameters in CloudFormation - This feature will allow the customers to use Systems Manager parameters in CloudFormation templates. They will be able to see values for these parameters in Describe APIs.
* CodeBuild (3.3.6.0)
	* Adding support for accessing Amazon VPC resources from AWS CodeBuild, dependency caching and build badges.
* ElasticMapReduce (3.3.5.0)
	* Enable Kerberos on Amazon EMR. 
* Rekognition (3.3.7.0)
	* This release includes updates to Amazon Rekognition for the following APIs. The new DetectText API allows you to recognize and extract textual content from images. Face Model Versioning has been added to operations that deal with face detection.
* Shield (3.3.1.0)
	* The AWS Shield SDK has been updated in order to support Elastic IP address protections, the addition of AttackProperties objects in DescribeAttack responses, and a new GetSubscriptionState operation.
* StorageGateway (3.3.6.0)
	* AWS Storage Gateway now enables you to get notification when all your files written to your NFS file share have been uploaded to Amazon S3. Storage Gateway also enables guessing of the MIME type for uploaded objects based on file extensions.

### 3.3.194.0 (2017-11-20 23:33 UTC)
* APIGateway (3.3.11.1)
	* Documentation updates for Apigateway
* CodeCommit (3.3.3.0)
	* AWS CodeCommit now supports pull requests. You can use pull requests to collaboratively review code changes for minor changes or fixes, major feature additions, or new versions of your released software.
* CostExplorer (3.3.0.0)
	* The AWS Cost Explorer API gives customers programmatic access to AWS cost and usage information, allowing them to perform adhoc queries and build interactive cost management applications that leverage this dataset.
* Kinesis (3.3.4.0)
	* Customers can now obtain the important characteristics of their stream with DescribeStreamSummary. The response will not include the shard list for the stream but will have the number of open shards, and all the other fields included in the DescribeStream response.
* KinesisFirehose (3.3.3.0)
	* This release includes a new Kinesis Firehose feature that supports Splunk as Kinesis Firehose delivery destination. You can now use Kinesis Firehose to ingest real-time data to Splunk in a serverless, reliable, and salable manner. This release also includes a new feature that allows you to configure Lambda buffer size in Kinesis Firehose data transformation feature. You can now customize the data buffer size before invoking Lambda function in Kinesis Firehose for data transformation. This feature allows you to flexibly trade-off processing and delivery latency with cost and efficiency based on your specific use cases and requirements. 
* WorkDocs (3.3.4.0)
	* DescribeGroups API and miscellaneous enhancements

### 3.3.193.0 (2017-11-18 00:19 UTC)
* ApplicationAutoScaling (3.3.7.0)
	* This SDK update contains support for Target Tracking scaling for EC2 Spot Fleet. It allows you to scale an EC2 Spot Fleet using a Target Tracking scaling policy.
* DatabaseMigrationService (3.3.5.0)
	* Support for migration task assessment. Support for data validation after the migration.
* ElasticLoadBalancingV2 (3.3.7.2)
	* This release adds Proxy Protocol v2 support for Network Load Balancer. Proxy protocol provides a convenient way to transport connection information (such as a client's source IP address/port and destination IP address/port) for a TCP connection across multiple layers of NAT or TCP proxies.
* RDS (3.3.18.0)
	* Amazon RDS now supports importing MySQL databases by using backup files from Amazon S3.
* S3 (3.3.14.0)
	* Added ORC to the supported S3 Inventory formats.

### 3.3.192.0 (2017-11-16 23:30 UTC)
* ApplicationAutoScaling (3.3.6.0)
	* Application Auto Scaling now supports automatic scaling of Amazon Aurora replicas
* EC2 (3.3.37.0)
	* You are now able to create and launch EC2 x1e smaller instance sizes
* Glue (3.3.2.0)
	* API update for AWS Glue. New crawler configuration attribute enables customers to specify crawler behavior. New XML classifier enables classification of XML data.
* OpsWorksCM (3.3.4.3)
	* Documentation updates for OpsWorks-cm: a new feature, OpsWorks for Puppet Enterprise, that allows users to create and manage OpsWorks-hosted Puppet Enterprise servers.
* Organizations (3.3.7.0)
	* This release adds APIs that you can use to enable and disable integration with AWS services designed to work with AWS Organizations. This integration allows the AWS service to perform operations on your behalf on all of the accounts in your organization. Although you can use these APIs yourself, we recommend that you instead use the commands provided in the other AWS service to enable integration with AWS Organizations.
* Route53 (3.3.11.0)
	* You can use Route 53's GetAccountLimit/GetHostedZoneLimit/GetReusableDelegationSetLimit APIs to view your current limits (including custom set limits) on Route 53 resources such as hosted zones and health checks. These APIs also return the number of each resource you're currently using to enable comparison against your current limits.

### 3.3.191.0 (2017-11-15 19:03 UTC)
* APIGateway (3.3.11.0)
	* 1. Extended GetDocumentationParts operation to support retrieving documentation parts resources without contents.  2. Added hosted zone ID in the custom domain response.
* Polly (3.3.4.0)
	* Amazon Polly adds Korean language support with new female voice - "Seoyeon" and new Indian English female voice - "Aditi"
* SimpleEmail (3.3.5.0)
	* SES launches Configuration Set Reputation Metrics and Email Pausing Today, two features that build upon the capabilities of the reputation dashboard. The first is the ability to export reputation metrics for individual configuration sets. The second is the ability to temporarily pause email sending, either at the configuration set level, or across your entire Amazon SES account.
* StepFunctions (3.3.2.0)
	* You can now use the UpdateStateMachine API to update your state machine definition and role ARN. Existing executions will continue to use the previous definition and role ARN. You can use the DescribeStateMachineForExecution API to determine which state machine definition and role ARN is associated with an execution

### 3.3.190.0 (2017-11-15 00:20 UTC)
* ECS (3.3.8.0)
	* Added new mode for Task Networking in ECS, called awsvpc mode. Mode configuration parameters to be passed in via awsvpcConfiguration. Updated APIs now use/show this new mode - RegisterTaskDefinition, CreateService, UpdateService, RunTask, StartTask.
* Lightsail (3.3.4.0)
	* Lightsail now supports attached block storage, which allows you to scale your applications and protect application data with additional SSD-backed storage disks. This feature allows Lightsail customers to attach secure storage disks to their Lightsail instances and manage their attached disks, including creating and deleting disks, attaching and detaching disks from instances, and backing up disks via snapshot.
* Route53 (3.3.10.0)
	* When a Route 53 health check or hosted zone is created by a linked AWS service, the object now includes information about the service that created it. Hosted zones or health checks that are created by a linked service can't be updated or deleted using Route 53.
* S3 (3.3.13.0)
	* Fix for issue where a key is used as both a header and a parameter.
* SimpleSystemsManagement (3.3.14.0)
	* EC2 Systems Manager GetInventory API adds support for aggregation.

### 3.3.189.0 (2017-11-11 06:50 UTC)
* S3 (3.3.12.1)
	* Support RequestPayer parameter in AmazonS3Client::GeneratePreSignedURL
* Core 3.3.19.0
	* Add hook for other AWS packages to customize globally how request are made
    * Fixed issue with putting objects with streams that are not seekable.
	* All services packages updated to require new Core

### 3.3.188.0 (2017-11-09 21:38 UTC)
* EC2 (3.3.36.0)
	* Introduces the following features: 1. Create a default subnet in an Availability Zone if no default subnet exists. 2. Spot Fleet integrates with Elastic Load Balancing to enable you to attach one or more load balancers to a Spot Fleet request. When you attach the load balancer, it automatically registers the instance in the Spot Fleet to the load balancers which distributes incoming traffic across the instances. 

### 3.3.187.0 (2017-11-08 21:51 UTC)
* ApplicationAutoScaling (3.3.5.0)
	* Application Auto Scaling customers are now able to schedule adjustments to their MinCapacity and MaxCapacity, which makes it possible to pre-provision adequate capacity for anticipated demand and then reduce the provisioned capacity as demand lulls.
* Batch (3.3.3.4)
	* Documentation updates for AWS Batch.
* EC2 (3.3.35.0)
	* AWS PrivateLink for Amazon Services - Customers can now privately access Amazon services from their Amazon Virtual Private Cloud (VPC), without using public IPs, and without requiring the traffic to traverse across the Internet.
* ElastiCache (3.3.5.0)
	* This release adds online resharding for ElastiCache for Redis offering, providing the ability to add and remove shards from a running cluster. Developers can now dynamically scale-out or scale-in their Redis cluster workloads to adapt to changes in demand. ElastiCache will resize the cluster by adding or removing shards and redistribute hash slots uniformly across the new shard configuration, all while the cluster continues to stay online and serves requests.
* Core 3.3.18.4
	* Updates several S3 endpoints.



### 3.3.186.1 (2017-11-08 01:16 UTC)
* WorkDocs (3.3.3.1)
	* WorkDocs content manager bug fix: remove encryption header from shared http client once it is used

### 3.3.186.0 (2017-11-07 22:48 UTC)
* ElasticLoadBalancingV2 (3.3.7.0)
	* Added a new limit related to Network Load Balancers on the number of targets per load balancer per AZ.
* RDS (3.3.17.0)
	* DescribeOrderableDBInstanceOptions now returns the minimum and maximum allowed values for storage size, total provisioned IOPS, and provisioned IOPS per GiB for a DB instance.
* S3 (3.3.12.0)
	* This releases adds support for 4 features: 1. Default encryption for S3 Bucket, 2. Encryption status in inventory and Encryption support for inventory.  3. Cross region replication of KMS-encrypted objects, and 4. ownership overwrite for CRR. 
* Core 3.3.18.3
	* Region launch expansion for SCS in new region AP-SOUTH-1 BOM
Region launch expansion of Service Catalog Service for new region US-WEST-1
Region launch expansion of SCS for new region SA-EAST-1
Core update to support for empty service partition entry on endpoints.json file.



### 3.3.185.0 (2017-11-07 01:38 UTC)
* EC2 (3.3.34.0)
	* You are now able to create and launch EC2 C5 instances, the next generation of EC2's compute-optimized instances, in us-east-1, us-west-2 and eu-west-1. C5 instances offer up to 72 vCPUs, 144 GiB of DDR4 instance memory, 25 Gbps in Network bandwidth and improved EBS and Networking bandwidth on smaller instance sizes to deliver improved performance for compute-intensive workloads.
* KeyManagementService (3.3.4.0)
	* Documentation updates for AWS KMS. 
* Organizations (3.3.6.2)
	* This release updates permission statements for several API operations, and corrects some other minor errors.
* Pricing (3.3.0.0)
	* This is the initial release of AWS Price List Service.
* StepFunctions (3.3.1.0)
	* Documentation update.

### 3.3.184.0 (2017-11-03 20:48 UTC)
* ECS (3.3.7.0)
	* Amazon ECS users can now add devices to their containers and enable init process in containers through the use of docker's 'devices' and 'init' features. These fields can be specified under linuxParameters in ContainerDefinition in the Task Definition Template. 

### 3.3.183.0 (2017-11-02 23:55 UTC)
* APIGateway (3.3.10.0)
	* This release supports creating and managing Regional and Edge-Optimized API endpoints.

### 3.3.182.0 (2017-11-01 16:59 UTC)
* CertificateManager (3.3.2.17)
	* Documentation updates for ACM
* CloudHSMV2 (3.3.0.3)
	* Minor documentation update for AWS CloudHSM (cloudhsmv2).
* DirectConnect (3.3.5.0)
	* AWS DirectConnect now provides support for Global Access for Virtual Private Cloud (VPC) via a new feature called Direct Connect Gateway. A Direct Connect Gateway will allow you to group multiple Direct Connect Private Virtual Interfaces (DX-VIF) and Private Virtual Gateways (VGW) from different AWS regions (but belonging to the same AWS Account) and pass traffic from any DX-VIF to any VPC in the grouping.

### 3.3.181.0 (2017-10-30 23:54 UTC)
* WorkDocs (3.3.3.0)
	* Added WorkDocs ContentManager

### 3.3.180.0 (2017-10-27 00:36 UTC)
* CloudFront (3.3.6.0)
	* You can now specify additional options for MinimumProtocolVersion, which controls the SSL/TLS protocol that CloudFront uses to communicate with viewers. The minimum protocol version that you choose also determines the ciphers that CloudFront uses to encrypt the content that it returns to viewers.
* EC2 (3.3.33.0)
	* You are now able to create and launch EC2 P3 instance, next generation GPU instances, optimized for machine learning and high performance computing applications. With up to eight NVIDIA Tesla V100 GPUs, P3 instances provide up to one petaflop of mixed-precision, 125 teraflops of single-precision, and 62 teraflops of double-precision floating point performance, as well as a 300 GB/s second-generation NVLink interconnect that enables high-speed, low-latency GPU-to-GPU communication. P3 instances also feature up to 64 vCPUs based on custom Intel Xeon E5 (Broadwell) processors, 488 GB of DRAM, and 25 Gbps of dedicated aggregate network bandwidth using the Elastic Network Adapter (ENA).

### 3.3.179.0 (2017-10-24 18:01 UTC)
* ConfigService (3.3.11.0)
	* AWS Config support for CodeBuild Project resource type
* ElastiCache (3.3.4.0)
	* Amazon ElastiCache for Redis today announced support for data encryption both for data in-transit and data at-rest. The new encryption in-transit functionality enables ElastiCache for Redis customers to encrypt data for all communication between clients and Redis engine, and all intra-cluster Redis communication. The encryption at-rest functionality allows customers to encrypt their S3 based backups. Customers can begin using the new functionality by simply enabling this functionality via AWS console, and a small configuration change in their Redis clients. The ElastiCache for Redis service automatically manages life cycle of the certificates required for encryption, including the issuance, renewal and expiration of certificates. Additionally, as part of this launch, customers will gain the ability to start using the Redis AUTH command that provides an added level of authentication.
* Glue (3.3.1.0)
	* AWS Glue: Adding a new API, BatchStopJobRun, to stop one or more job runs for a specified Job. 
* Pinpoint (3.3.5.0)
	* Added support for APNs VoIP messages. Added support for collapsible IDs, message priority, and TTL for APNs and FCM/GCM.
* S3 (3.3.11.4)
	* PR 769, fix issue with mocking TransferUtility

### 3.3.178.1 (2017-10-24 00:07 UTC)
* Core 3.3.18.2
	* Restored missing UAP binaries in service nuget packages.
	* All services packages updated to require new Core

### 3.3.178.0 (2017-10-23 20:39 UTC)
* Organizations (3.3.6.0)
	* This release supports integrating other AWS services with AWS Organizations through the use of an IAM service-linked role called AWSServiceRoleForOrganizations. Certain operations automatically create that role if it does not already exist.

### 3.3.177.0 (2017-10-20 19:09 UTC)
* EC2 (3.3.32.0)
	* Adding pagination support for DescribeSecurityGroups for EC2 Classic and VPC Security Groups

### 3.3.176.0 (2017-10-19 21:02 UTC)
* SimpleSystemsManagement (3.3.13.0)
	* EC2 Systems Manager versioning support for Parameter Store. Also support for referencing parameter versions in SSM Documents.
* SQS (3.3.3.0)
	* Added support for tracking cost allocation by adding, updating, removing, and listing the metadata tags of Amazon SQS queues.

### 3.3.175.0 (2017-10-18 20:10 UTC)
* Lightsail (3.3.3.0)
	* This release adds support for Windows Server-based Lightsail instances. The GetInstanceAccessDetails API now returns the password of your Windows Server-based instance when using the default key pair. GetInstanceAccessDetails also returns a PasswordData object for Windows Server instances containing the ciphertext and keyPairName. The Blueprint data type now includes a list of platform values (LINUX_UNIX or WINDOWS). The Bundle data type now includes a list of SupportedPlatforms values (LINUX_UNIX or WINDOWS).

### 3.3.174.0 (2017-10-17 20:37 UTC)
* Elasticsearch (3.3.3.0)
	* This release adds support for VPC access to Amazon Elasticsearch Service.
* Core 3.3.18.1
	* Service Region Launch.



### 3.3.173.0 (2017-10-16 20:49 UTC)
* CloudHSM (3.3.0.23)
	* Documentation updates for AWS CloudHSM Classic.
* EC2 (3.3.31.0)
	* You can now change the tenancy of your VPC from dedicated to default with a single API operation. For more details refer to the documentation for changing VPC tenancy.
* Elasticsearch (3.3.2.0)
	* AWS Elasticsearch adds support for enabling slow log publishing. Using slow log publishing options customers can configure and enable index/query slow log publishing of their domain to preferred AWS Cloudwatch log group.
* RDS (3.3.16.0)
	* Adds waiters for DBSnapshotAvailable and DBSnapshotDeleted.
* S3 (3.3.11.2)
	* Fixed typo in exception messages.
* WAF (3.3.3.0)
	* This release adds support for regular expressions as match conditions in rules, and support for geographical location by country of request IP address as a match condition in rules.
* WAFRegional (3.3.2.0)
	* This release adds support for regular expressions as match conditions in rules, and support for geographical location by country of request IP address as a match condition in rules.

### 3.3.172.0 (2017-10-12 18:48 UTC)
* CodeCommit (3.3.2.0)
	* This release includes the DeleteBranch API and a change to the contents of a Commit object.
* DatabaseMigrationService (3.3.4.0)
	* This change includes addition of new optional parameter to an existing API
* ElasticBeanstalk (3.3.6.0)
	* Added the ability to add, delete or update Tags
* Polly (3.3.3.0)
	* Amazon Polly exposes two new voices: "Matthew" (US English) and "Takumi" (Japanese)
* RDS (3.3.15.0)
	* You can now call DescribeValidDBInstanceModifications to learn what modifications you can make to your DB instance. You can use this information when you call ModifyDBInstance.

### 3.3.171.0 (2017-10-11 19:11 UTC)
* ECR (3.3.3.0)
	* Adds support for new API set used to manage Amazon ECR repository lifecycle policies. Amazon ECR lifecycle policies enable you to specify the lifecycle management of images in a repository. The configuration is a set of one or more rules, where each rule defines an action for Amazon ECR to apply to an image. This allows the automation of cleaning up unused images, for example expiring images based on age or status. A lifecycle policy preview API is provided as well, which allows you to see the impact of a lifecycle policy on an image repository before you execute it
* SimpleEmail (3.3.4.0)
	* Added content related to email template management and templated email sending operations.

### 3.3.170.0 (2017-10-10 18:57 UTC)
* EC2 (3.3.30.0)
	* This release includes updates to AWS Virtual Private Gateway.
* ElasticLoadBalancingV2 (3.3.6.0)
	* Server Name Indication (SNI) is an extension to the TLS protocol by which a client indicates the hostname to connect to at the start of the TLS handshake. The load balancer can present multiple certificates through the same secure listener, which enables it to support multiple secure websites using a single secure listener. Application Load Balancers also support a smart certificate selection algorithm with SNI. If the hostname indicated by a client matches multiple certificates, the load balancer determines the best certificate to use based on multiple factors including the capabilities of the client.
* OpsWorksCM (3.3.4.0)
	* Provide engine specific information for node associations.

### 3.3.169.0 (2017-10-09 01:26 UTC)
* Core 3.3.18.0
	* Added a new **HttpClientCacheSize** property to the service config object to control the number of HttpClient objects cached for the .NET Core version of the SDK.
	* Updated all service client operations to be virtual
	* All services packages updated to require new Core

### 3.3.168.1 (2017-10-06 22:28 UTC)
* SQS (3.3.2.8)
	* Documentation updates regarding availability of FIFO queues and miscellaneous corrections.

### 3.3.168.0 (2017-10-05 19:28 UTC)
* Redshift (3.3.3.0)
	* DescribeEventSubscriptions API supports tag keys and tag values as request parameters. 

### 3.3.167.0 (2017-10-04 21:44 UTC)
* KinesisAnalytics (3.3.3.0)
	* Kinesis Analytics now supports schema discovery on objects in S3.  Additionally, Kinesis Analytics now supports input data preprocessing through Lambda.
* Route53Domains (3.3.1.0)
	* Added a new API that checks whether a domain name can be transferred to Amazon Route 53.

### 3.3.166.0 (2017-10-03 17:20 UTC)
* EC2 (3.3.29.0)
	* This release includes service updates to AWS VPN.
* SimpleSystemsManagement (3.3.12.0)
	* EC2 Systems Manager support for tagging SSM Documents. Also support for tag-based permissions to restrict access to SSM Documents based on these tags.

### 3.3.165.1 (2017-10-02 19:28 UTC)
* CloudHSM (3.3.0.21)
	* Documentation updates for CloudHSM

### 3.3.165.0 (2017-09-29 20:03 UTC)
* AppStream (3.3.6.0)
	* Includes APIs for managing and accessing image builders, and deleting images.
* CodeBuild (3.3.5.0)
	* Adding support for Building GitHub Pull Requests in AWS CodeBuild
* MTurk (3.3.1.0)
	* Today, Amazon Mechanical Turk (MTurk) supports SQS Notifications being delivered to Customers' SQS queues when different stages of the MTurk workflow are complete.  We are going to create new functionality so that Customers can leverage SNS topics as a destination for notification messages when various stages of the MTurk workflow are complete. 
* Organizations (3.3.5.0)
	* This release flags the HandshakeParty structure's Type and Id fields as 'required'. They effectively were required in the past, as you received an error if you did not include them. This is now reflected at the API definition level. 
* Route53 (3.3.9.0)
	* This change allows customers to reset elements of health check.

### 3.3.164.0 (2017-09-27 22:03 UTC)
* Pinpoint (3.3.4.0)
	* Added two new push notification channels: Amazon Device Messaging (ADM) and, for push notification support in China, Baidu Cloud Push. Added support for APNs auth via .p8 key file. Added operation for direct message deliveries to user IDs, enabling you to message an individual user on multiple endpoints.

### 3.3.163.0 (2017-09-26 18:20 UTC)
* CloudFormation (3.3.8.0)
	* You can now prevent a stack from being accidentally deleted by enabling termination protection on the stack. If you attempt to delete a stack with termination protection enabled, the deletion fails and the stack, including its status, remains unchanged. You can enable termination protection on a stack when you create it. Termination protection on stacks is disabled by default. After creation, you can set termination protection on a stack whose status is CREATE_COMPLETE, UPDATE_COMPLETE, or UPDATE_ROLLBACK_COMPLETE.

### 3.3.162.0 (2017-09-22 19:56 UTC)
* ConfigService (3.3.10.0)
	* AWS Config support for DynamoDB tables and Auto Scaling resource types
* ECS (3.3.6.0)
	* Amazon ECS users can now add and drop Linux capabilities to their containers through the use of docker's cap-add and cap-drop features. Customers can specify the capabilities they wish to add or drop for each container in their task definition. 
* RDS (3.3.14.1)
	* Documentation updates for rds

### 3.3.161.0 (2017-09-21 19:40 UTC)
* Budgets (3.3.4.0)
	* Including "DuplicateRecordException" in UpdateNotification and UpdateSubscriber. 
* CloudWatchLogs (3.3.4.0)
	* Adds support for associating LogGroups with KMS Keys.
* EC2 (3.3.28.0)
	* Add EC2 APIs to copy Amazon FPGA Images (AFIs) within the same region and across multiple regions, delete AFIs, and modify AFI attributes. AFI attributes include name, description and granting/denying other AWS accounts to load the AFI.

### 3.3.160.0 (2017-09-20 22:48 UTC)
* AppStream (3.3.5.0)
	* API updates for supporting On-Demand fleets.
* CodePipeline (3.3.2.0)
	* This change includes a PipelineMetadata object that is part of the output from the GetPipeline API that includes the Pipeline ARN, created, and updated timestamp.
* EC2 (3.3.27.0)
	* Descriptions for Security Group Rules enables customers to be able to define a description for ingress and egress security group rules . The Descriptions for Security Group Rules feature supports one description field per Security Group rule for both ingress and egress rules . Descriptions for Security Group Rules provides a simple way to describe the purpose or function of a Security Group Rule allowing for easier customer identification of configuration elements .      Prior to the release of Descriptions for Security Group Rules , customers had to maintain a separate system outside of AWS if they wanted to track Security Group Rule mapping and their purpose for being implemented. If a security group rule has already been created and you would like to update or change your description for that security group rule you can use the UpdateSecurityGroupRuleDescription API. The IpRanges property on IpPermission has been deprecated in favor of a new property, Ipv4Ranges
* Greengrass (3.3.1.0)
	* Reset Deployments feature allows you to clean-up the cloud resource so you can delete the group. It also cleans up the core so that it goes back to the pre-deployment state.
* Lex (3.3.2.0)
	* Request attributes can be used to pass client specific information from the client to Amazon Lex as part of each request.
* RDS (3.3.14.0)
	* Introduces the --option-group-name parameter to the ModifyDBSnapshot CLI command. You can specify this parameter when you upgrade an Oracle DB snapshot. The same option group considerations apply when upgrading a DB snapshot as when upgrading a DB instance.  For more information, see http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Oracle.html#USER_UpgradeDBInstance.Oracle.OGPG.OG
* Core 3.3.17.10
	* AWS Greengrass is now available in the Asia Pacific (Tokyo) region, ap-northeast-1.



### 3.3.159.0 (2017-09-18 23:14 UTC)
* EC2 (3.3.26.0)
	* Amazon EC2 now lets you opt for Spot instances to be stopped in the event of an interruption instead of being terminated.  Your Spot request can be fulfilled again by restarting instances from a previously stopped state, subject to availability of capacity at or below your preferred price.  When you submit a persistent Spot request, you can choose from \"terminate\" or \"stop\" as the instance interruption behavior.  Choosing \"stop\" will shutdown your Spot instances so you can continue from this stopped state later on.  This feature is only available for instances with Amazon EBS volume as their root device.
* IdentityManagement (3.3.5.0)
	* A new API, DeleteServiceLinkedRole, submits a service-linked role deletion request and returns a DeletionTaskId, which you can use to check the status of the deletion.
* SimpleEmail (3.3.3.0)
	* Amazon Simple Email Service (Amazon SES) now lets you customize the domains used for tracking open and click events. Previously, open and click tracking links referred to destinations hosted on domains operated by Amazon SES. With this feature, you can use your own branded domains for capturing open and click events.

### 3.3.158.0 (2017-09-15 19:46 UTC)
* APIGateway (3.3.9.0)
	* Add a new enum "REQUEST" to '--type <value>' field in the current create-authorizer API, and make "identitySource" optional.

### 3.3.157.0 (2017-09-14 21:13 UTC)
* CodeBuild (3.3.4.0)
	* Supporting Parameter Store in environment variables for AWS CodeBuild
* Organizations (3.3.4.1)
	* Documentation updates for AWS Organizations
* ServiceCatalog (3.3.5.0)
	* This release of Service Catalog adds API support to copy products.

### 3.3.156.0 (2017-09-13 20:33 UTC)
* AutoScaling (3.3.2.0)
	* Customers can create Life Cycle Hooks at the time of creating Auto Scaling Groups through the CreateAutoScalingGroup API
* Batch (3.3.3.1)
	* Documentation updates for batch
* CloudWatchEvents (3.3.3.0)
	* Exposes ConcurrentModificationException as one of the valid exceptions for PutPermission and RemovePermission operation.
* EC2 (3.3.25.0)
	* You are now able to create and launch EC2 x1e.32xlarge instance, a new EC2 instance in the X1 family, in us-east-1, us-west-2, eu-west-1, and ap-northeast-1. x1e.32xlarge offers 128 vCPUs, 3,904 GiB of DDR4 instance memory, high memory bandwidth, large L3 caches, and leading reliability capabilities to boost the performance and reliability of in-memory applications.

### 3.3.155.0 (2017-09-12 22:22 UTC)
* KeyManagementService (3.3.3.1)
	* Updated to use new Core, version 3.3.17.9
	* Support changes to allow use of KMS master keys with AmazonS3EncryptionClient.
* S3 (3.3.11.0)
	* Updated to use new Core, version 3.3.17.9
	* Allow use of KMS master keys with AmazonS3EncryptionClient.
* Core 3.3.17.9
	* Support changes to allow use of KMS master keys with AmazonS3EncryptionClient.

### 3.3.154.0 (2017-09-12 17:08 UTC)
* EC2 (3.3.24.0)
	* Fixed bug in EC2 clients preventing HostOfferingSet from being set

### 3.3.153.0 (2017-09-11 21:03 UTC)
* DeviceFarm (3.3.3.0)
	* DeviceFarm has added support for two features - RemoteDebugging and Customer Artifacts. Customers  can now do remote Debugging on their Private Devices and can now retrieve custom files generated by their tests on the device and the device host (execution environment) on both public and private devices. 

### 3.3.152.1 (2017-09-09 04:44 UTC)
* CognitoSync (3.3.1.23)
	* Updated to use new Core, version 3.3.17.8
	* Fixed a race condition in SQLiteLocalStorage.ConditionallyPutRecords() PR https://github.com/aws/aws-sdk-net/pull/446
    * Make the local merge dataset sync count match the remote sync count PR https://github.com/aws/aws-sdk-net/pull/414
    * Handle Cognito Sync Count Exception PR https://github.com/aws/aws-sdk-net/pull/532
* Core 3.3.17.8
	* Update UnityWebRequestWrapper to work in Unity 2017.1 PR https://github.com/aws/aws-sdk-net/pull/709

### 3.3.152.0 (2017-09-08 19:39 UTC)
* CloudWatchLogs (3.3.3.0)
	* Adds support for the PutResourcePolicy, DescribeResourcePolicy and DeleteResourcePolicy APIs.

### 3.3.151.0 (2017-09-07 22:49 UTC)
* ApplicationAutoScaling (3.3.4.1)
	* Documentation updates for application-autoscaling
* EC2 (3.3.23.0)
	* With Tagging support, you can add Key and Value metadata to search, filter and organize your NAT Gateways according to your organization's needs.
* ElasticLoadBalancingV2 (3.3.5.0)
	* The feature enables the new Network Load Balancer that is optimized to handle volatile traffic patterns while using a single static IP address per Availability Zone. Network Load Balancer operates at the connection level (Layer 4), routing connections to Amazon EC2 instances and containers, within Amazon Virtual Private Cloud (Amazon VPC) based on IP protocol data.
* LexModelBuildingService (3.3.3.0)
	* Amazon Lex provides the ability to export your Amazon Lex chatbot definition as a JSON file that can be added to the target platform. The JSON configuration file contains the structure of your Amazon Lex chatbot, including the intent schema with utterances, slots, prompts and slot-types.
* Route53 (3.3.8.0)
	* You can configure Amazon Route 53 to log information about the DNS queries that Amazon Route 53 receives for your domains and subdomains. When you configure query logging, Amazon Route 53 starts to send logs to CloudWatch Logs. You can use various tools, including the AWS console, to access the query logs.

### 3.3.150.1 (2017-09-07 06:06 UTC)
* CognitoSync (3.3.1.22)
	* Added try catch block around GetIdentityId during sync. PR https://github.com/aws/aws-sdk-net/pull/408
* S3 (3.3.10.4)
	* Fixed bug with S3 Util method PostUpload that wasn't disposing the HttpWebResponse.
    * Extend S3 signed URLs to allow for custom parameters that cannot be altered PR https://github.com/aws/aws-sdk-net/pull/698
* Core 3.3.17.7
	* Improve AsyncRunner utility method to reduce thread usage PR https://github.com/aws/aws-sdk-net/pull/731
    * Don't allocate memory in UnmarshallerContext.TestExpression. PR https://github.com/aws/aws-sdk-net/pull/716
    * Fixed unhandled exception in UnityWebResponseData.CopyHeaderValues. PR https://github.com/aws/aws-sdk-net/pull/743



### 3.3.150.0 (2017-09-06 18:04 UTC)
* Budgets (3.3.3.0)
	* Add an optional "thresholdType" to notifications to support percentage or absolute value thresholds.
* S3 (3.3.10.3)
	* Remove unused model type TagQuery

### 3.3.149.0 (2017-09-05 16:41 UTC)
* CodeStar (3.3.1.0)
	* Added support to tag CodeStar projects. Tags can be used to organize and find CodeStar projects on key-value pairs that you can choose. For example, you could add a tag with a key of "Release" and a value of "Beta" to projects your organization is working on for an upcoming beta release.

### 3.3.148.0 (2017-09-01 19:02 UTC)
* GameLift (3.3.9.0)
	* GameLift VPC resources can be peered with any other AWS VPC. R4 memory-optimized instances now available to deploy.
* Mobile (3.3.0.0)
	* AWS Mobile Hub is an integrated experience designed to help developers build, test, configure and release cloud-based applications for mobile devices using Amazon Web Services. AWS Mobile Hub provides a console and API for developers, allowing them to quickly select desired features and integrate them into mobile applications. Features include NoSQL Database, Cloud Logic, Messaging and Analytics. With AWS Mobile Hub, you pay only for the underlying services that Mobile Hub provisions based on the features you choose in the Mobile Hub console.
* SimpleSystemsManagement (3.3.11.0)
	* Adding KMS encryption support to SSM Inventory Resource Data Sync. Exposes the ClientToken parameter on SSM StartAutomationExecution to provide idempotent execution requests.

### 3.3.147.0 (2017-08-31 21:35 UTC)
* CodeBuild (3.3.3.0)
	* The AWS CodeBuild HTTP API now provides the BatchDeleteBuilds operation, which enables you to delete existing builds.
* ElasticLoadBalancingV2 (3.3.4.0)
	* This change now allows Application Load Balancers to distribute traffic to AWS resources using their IP addresses as targets in addition to the instance IDs. You can also load balance to resources outside the VPC hosting the load balancer using their IP addresses as targets. This includes resources in peered VPCs, EC2-Classic, and on-premises locations reachable over AWS Direct Connect or a VPN connection.
* LexModelBuildingService (3.3.2.0)
	* Amazon Lex now supports synonyms for slot type values. If the user inputs a synonym, it will be resolved to the corresponding slot value.
* Core 3.3.17.6
	* Look at AWS_PROFILE environment variable in FallbackCredentialsFactory and FallbackRegionFactory.

### 3.3.146.0 (2017-08-30 16:16 UTC)
* ApplicationAutoScaling (3.3.4.0)
	* Application Auto Scaling now supports the DisableScaleIn option for Target Tracking Scaling Policies. This allows customers to create scaling policies that will only add capacity to the target.
* Organizations (3.3.4.0)
	* The exception ConstraintViolationException now contains a new reason subcode MASTERACCOUNT_MISSING_CONTACT_INFO to make it easier to understand why attempting to remove an account from an Organization can fail. We also improved several other of the text descriptions and examples.

### 3.3.145.0 (2017-08-29 18:35 UTC)
* ConfigService (3.3.9.0)
	* Increased the internal size limit of resourceId
* EC2 (3.3.22.0)
	* Provides capability to add secondary CIDR blocks to a VPC.

### 3.3.144.0 (2017-08-25 21:01 UTC)
* CloudFormation (3.3.7.0)
	* Rollback triggers enable you to have AWS CloudFormation monitor the state of your application during stack creation and updating, and to roll back that operation if the application breaches the threshold of any of the alarms you've specified.
* GameLift (3.3.8.0)
	* Update spelling of MatchmakingTicket status values for internal consistency.
* RDS (3.3.13.0)
	* Option group options now contain additional properties that identify requirements for certain options. Check these properties to determine if your DB instance must be in a VPC or have auto minor upgrade turned on before you can use an option. Check to see if you can downgrade the version of an option after you have installed it.

### 3.3.143.1 (2017-08-24 22:23 UTC)
* S3 (3.3.10.2)
	* Added ability to specify content type for all files when uploading a folder. Note that this overrides the default behavior which inspects the file extensions to set content type, and applies the specified content type to all files uploaded from the folder hierarchy.

### 3.3.143.0 (2017-08-24 18:16 UTC)
* Rekognition (3.3.6.0)
	* Update the enum value of LandmarkType and GenderType to be consistent with service response

### 3.3.142.1 (2017-08-23 19:38 UTC)
* AppStream (3.3.4.1)
	* Documentation updates for appstream

### 3.3.142.0 (2017-08-22 18:31 UTC)
* SimpleSystemsManagement (3.3.10.0)
	* Changes to associations in Systems Manager State Manager can now be recorded. Previously, when you edited associations, you could not go back and review older association settings. Now, associations are versioned, and can be named using human-readable strings, allowing you to see a trail of association changes. You can also perform rate-based scheduling, which allows you to schedule associations more granularly.

### 3.3.141.0 (2017-08-22 00:16 UTC)
* KinesisFirehose (3.3.2.0)
	* This change will allow customers to attach a Firehose delivery stream to an existing Kinesis stream directly. You no longer need a forwarder to move data from a Kinesis stream to a Firehose delivery stream. You can now run your streaming applications on your Kinesis stream and easily attach a Firehose delivery stream to it for data delivery to S3, Redshift, or Elasticsearch concurrently.
* Route53 (3.3.7.0)
	* Amazon Route 53 now supports CAA resource record type. A CAA record controls which certificate authorities are allowed to issue certificates for the domain or subdomain.

### 3.3.140.1 (2017-08-16 22:00 UTC)
* EC2 (3.3.21.1)
	* Use HTTPS endpoint to retrieve stockamis.json
* AWSSDK.Extensions.CognitoAuthentication (0.9.0)
	* Developer preview release of an extension library to assist in the Amazon Cognito User Pools authentication process.

### 3.3.140.0 (2017-08-16 19:34 UTC)
* GameLift (3.3.7.0)
	* The Matchmaking Grouping Service is a new feature that groups player match requests for a given game together into game sessions based on developer configured rules.

### 3.3.139.1 (2017-08-16 7:30 UTC)
* CognitoIdentity (3.3.2.14)
	* Fix NotImplementedException exception when using the CognitoAWSCredentials in .NET Core
* S3 (3.3.10.1)
	* Fix doc typo

### 3.3.139.0 (2017-08-15 21:32 UTC)
* EC2 (3.3.21.0)
	* Fixed bug in EC2 clients preventing HostReservation from being set

### 3.3.138.0 (2017-08-14 23:27 UTC)
* S3 (3.3.10.0)
	* Added tagging support for TransferUtility's upload directory command.

### 3.3.137.0 (2017-08-14 16:41 UTC)
* Batch (3.3.3.0)
	* This release enhances the DescribeJobs API to include the CloudWatch logStreamName attribute in ContainerDetail and ContainerDetailAttempt
* CloudHSMV2 (3.3.0.0)
	* CloudHSM provides hardware security modules for protecting sensitive data and cryptographic keys within an EC2 VPC, and enable the customer to maintain control over key access and use. This is a second-generation of the service that will improve security, lower cost and provide better customer usability.
* ElasticFileSystem (3.3.1.0)
	* Customers can create encrypted EFS file systems and specify a KMS master key to encrypt it with.
* Glue (3.3.0.0)
	* AWS Glue is a fully managed extract, transform, and load (ETL) service that makes it easy for customers to prepare and load their data for analytics. You can create and run an ETL job with a few clicks in the AWS Management Console. You simply point AWS Glue to your data stored on AWS, and AWS Glue discovers your data and stores the associated metadata (e.g. table definition and schema) in the AWS Glue Data Catalog. Once cataloged, your data is immediately searchable, queryable, and available for ETL. AWS Glue generates the code to execute your data transformations and data loading processes. AWS Glue generates Python code that is entirely customizable, reusable, and portable. Once your ETL job is ready, you can schedule it to run on AWS Glue's fully managed, scale-out Spark environment. AWS Glue provides a flexible scheduler with dependency resolution, job monitoring, and alerting. AWS Glue is serverless, so there is no infrastructure to buy, set up, or manage. It automatically provisions the environment needed to complete the job, and customers pay only for the compute resources consumed while running ETL jobs. With AWS Glue, data can be available for analytics in minutes.
* MigrationHub (3.3.0.0)
	* AWS Migration Hub provides a single location to track migrations across multiple AWS and partner solutions. Using Migration Hub allows you to choose the AWS and partner migration tools that best fit your needs, while providing visibility into the status of your entire migration portfolio. Migration Hub also provides key metrics and progress for individual applications, regardless of which tools are being used to migrate them. For example, you might use AWS Database Migration Service, AWS Server Migration Service, and partner migration tools to migrate an application comprised of a database, virtualized web servers, and a bare metal server. Using Migration Hub will provide you with a single screen that shows the migration progress of all the resources in the application. This allows you to quickly get progress updates across all of your migrations, easily identify and troubleshoot any issues, and reduce the overall time and effort spent on your migration projects. Migration Hub is available to all AWS customers at no additional charge. You only pay for the cost of the migration tools you use, and any resources being consumed on AWS. 
* SimpleSystemsManagement (3.3.9.0)
	* Systems Manager Maintenance Windows include the following changes or enhancements: New task options using Systems Manager Automation, AWS Lambda, and AWS Step Functions; enhanced ability to edit the targets of a Maintenance Window, including specifying a target name and description, and ability to edit the owner field; enhanced ability to edits tasks; enhanced support for Run Command parameters; and you can now use a --safe flag when attempting to deregister a target. If this flag is enabled when you attempt to deregister a target, the system returns an error if the target is referenced by any task. Also, Systems Manager now includes Configuration Compliance to scan your fleet of managed instances for patch compliance and configuration inconsistencies. You can collect and aggregate data from multiple AWS accounts and Regions, and then drill down into specific resources that aren't compliant.
* StorageGateway (3.3.5.0)
	* Add optional field ForceDelete to DeleteFileShare api.

### 3.3.136.0 (2017-08-11 21:30 UTC)
* CodeDeploy (3.3.7.0)
	* Adds support for specifying Application Load Balancers in deployment groups, for both in-place and blue/green deployments.
* CognitoIdentityProvider (3.3.6.0)
	* We have added support for features for Amazon Cognito User Pools that enable application developers to easily add and customize a sign-up and sign-in user experience, use OAuth 2.0, and integrate with Facebook, Google, Login with Amazon, and SAML-based identity providers.
* EC2 (3.3.20.0)
	* Provides customers an opportunity to recover an EIP that was released

### 3.3.135.0 (2017-08-10 20:29 UTC)
* CloudDirectory (3.3.5.0)
	* Enable BatchDetachPolicy
* CodeBuild (3.3.2.0)
	* Supporting Bitbucket as source type in AWS CodeBuild.

### 3.3.134.1 (2017-08-09 18:18 UTC)
* RDS (3.3.12.4)
	* Documentation updates for RDS.

### 3.3.134.0 (2017-08-09 02:27 UTC)
* ElasticBeanstalk (3.3.5.0)
	* Add support for paginating the result of DescribeEnvironments     Include the ARN of described environments in DescribeEnvironments output

### 3.3.133.0 (2017-08-01 23:14 UTC)
* CodeDeploy (3.3.6.0)
	* AWS CodeDeploy now supports the use of multiple tag groups in a single deployment group (an intersection of tags) to identify the instances for a deployment. When you create or update a deployment group, use the new ec2TagSet and onPremisesTagSet structures to specify up to three groups of tags. Only instances that are identified by at least one tag in each of the tag groups are included in the deployment group.
* ConfigService (3.3.8.0)
	* Added new API, GetDiscoveredResourceCounts, which returns the resource types, the number of each resource type, and the total number of resources that AWS Config is recording in the given region for your AWS account.
* Pinpoint (3.3.3.0)
	* This release of the Pinpoint SDK enables App management - create, delete, update operations, Raw Content delivery for APNs and GCM campaign messages and From Address override.
* SimpleEmail (3.3.2.0)
	* This update adds information about publishing email open and click events. This update also adds information about publishing email events to Amazon Simple Notification Service (Amazon SNS).

### 3.3.132.0 (2017-07-31 23:25 UTC)
* Inspector (3.3.2.0)
	* Inspector's StopAssessmentRun API has been updated with a new input option - stopAction. This request parameter can be set to either START_EVALUATION or SKIP_EVALUATION. START_EVALUATION (the default value, and the previous behavior) stops the AWS agent data collection and begins the results evaluation for findings generation based on the data collected so far. SKIP_EVALUATION cancels the assessment run immediately, after which no findings are generated.
* SimpleSystemsManagement (3.3.8.0)
	* Adds a SendAutomationSignal API to SSM Service. This API is used to send a signal to an automation execution to change the current behavior or status of the execution.
* Core 3.3.17.5
	*  AWS CodeStar is now available in the following regions: Asia Pacific (Singapore), Asia Pacific (Sydney), EU (Frankfurt)



### 3.3.131.0 (2017-07-30 19:34 UTC)
* S3 (3.3.9.0)
	* Fix TransferUtility reporting 0 files transferred when performing directory download

### 3.3.130.0 (2017-07-27 19:59 UTC)
* EC2 (3.3.19.0)
	* The CreateDefaultVPC API enables you to create a new default VPC . You no longer need to contact AWS support, if your default VPC has been deleted.
* KinesisAnalytics (3.3.2.0)
	* Added additional exception types and clarified documentation.
* SecurityToken (3.3.3.0)
	* Removed use of new credential cache when authenticating using SAML, causing issues with the default Kereberos mode. Setting UseDefaultCredentials fixed issue and also worked with NTLM mode, for both domain joined and non-joined usage scenarios.

### 3.3.129.0 (2017-07-26 22:18 UTC)
* CloudFront (3.3.5.0)
	* Fixed CloudFrontCookierSigner incorrectly constructing resource path
* CloudWatch (3.3.4.0)
	* This release adds high resolution features to CloudWatch, with support for Custom Metrics down to 1 second and Alarms down to 10 seconds.
* DynamoDBv2 (3.3.4.17)
	* Corrected a typo.
* EC2 (3.3.18.0)
	* Amazon EC2 Elastic GPUs allow you to easily attach low-cost graphics acceleration to current generation EC2 instances. With Amazon EC2 Elastic GPUs, you can configure the right amount of graphics acceleration to your particular workload without being constrained by fixed hardware configurations and limited GPU selection.

### 3.3.128.0 (2017-07-25 23:11 UTC)
* CloudDirectory (3.3.4.0)
	* Cloud Directory adds support for additional batch operations.
* CloudFormation (3.3.6.0)
	* AWS CloudFormation StackSets enables you to manage stacks across multiple accounts and regions.

### 3.3.127.0 (2017-07-24 20:34 UTC)
* AppStream (3.3.4.0)
	* Amazon AppStream 2.0 image builders and fleets can now access applications and network resources that rely on Microsoft Active Directory (AD) for authentication and permissions. This new feature allows you to join your streaming instances to your AD, so you can use your existing AD user management tools. 
* EC2 (3.3.17.0)
	* Spot Fleet tagging capability allows customers to automatically tag instances launched by Spot Fleet. You can use this feature to label or distinguish instances created by distinct Spot Fleets. Tagging your EC2 instances also enables you to see instance cost allocation by tag in your AWS bill.
* Core 3.3.17.4
	* Made the ‘profile’ keyword, which can be added to the profile name parameter in the shared credentials file, optional.

### 3.3.126.1 (2017-07-24 15:26 UTC)
* SimpleNotificationService (3.3.0.21)
	* Updated to use new Core, version 3.3.17.3
	* Add IsMessageSignatureValid method to .NET Core SDK.
https://github.com/aws/aws-sdk-net/issues/702
* Core 3.3.17.3
	* Stop wrapping exceptions in AsyncHelpers with AggregateException.

### 3.3.126.0 (2017-07-20 22:09 UTC)
* ElasticMapReduce (3.3.4.0)
	* Amazon EMR now includes the ability to use a custom Amazon Linux AMI and adjustable root volume size when launching a cluster.

### 3.3.125.0 (2017-07-19 17:49 UTC)
* Budgets (3.3.2.0)
	* Update budget Management API's to list/create/update RI_UTILIZATION type budget. Update budget Management API's to support DAILY timeUnit for RI_UTILIZATION type budget.

### 3.3.124.0 (2017-07-17 21:14 UTC)
* CognitoIdentityProvider (3.3.5.0)
	* Allows developers to configure user pools for email/phone based signup and sign-in.
* Lambda (3.3.8.0)
	* Lambda@Edge lets you run code closer to your end users without provisioning or managing servers. With Lambda@Edge, your code runs in AWS edge locations, allowing you to respond to your end users at the lowest latency. Your code is triggered by Amazon CloudFront events, such as requests to and from origin servers and viewers, and it is ready to execute at every AWS edge location whenever a request for content is received. You just upload your Node.js code to AWS Lambda and Lambda takes care of everything required to run and scale your code with high availability. You only pay for the compute time you consume - there is no charge when your code is not running.

### 3.3.123.0 (2017-07-14 23:04 UTC)
* ApplicationDiscoveryService (3.3.3.0)
	* Adding feature to the Export API for Discovery Service to allow filters for the export task to allow export based on per agent id.
* AWSMarketplaceCommerceAnalytics (3.3.3.12)
	* Update to Documentation Model For New Report Cadence / Reformat of Docs
* EC2 (3.3.16.0)
	* New EC2 GPU Graphics instance

### 3.3.122.0 (2017-07-13 17:35 UTC)
* APIGateway (3.3.8.0)
	* Adds support for management of gateway responses.
* EC2 (3.3.15.0)
	* X-ENI (or Cross-Account ENI) is a new feature that allows the attachment or association of Elastic Network Interfaces (ENI) between VPCs in different AWS accounts located in the same availability zone. With this new capability, service providers and partners can deliver managed solutions in a variety of new architectural patterns where the provider and consumer of the service are in different AWS accounts.
* LexModelBuildingService (3.3.1.5)
	* Fixed broken links to reference and conceptual content.

### 3.3.121.0 (2017-07-12 18:00 UTC)
* AutoScaling (3.3.1.0)
	* Auto Scaling now supports a new type of scaling policy called target tracking scaling policies that you can use to set up dynamic scaling for your application.
* SimpleWorkflow (3.3.0.21)
	* Added support for attaching control data to Lambda tasks. Control data lets you attach arbitrary strings to your decisions and history events.

### 3.3.120.1 (2017-07-10 22:33 UTC)
* Core 3.3.17.2
	* Fix AWSCredentials.GetCredentialsAsync to use Task.FromResult instead of Task.Run.

### 3.3.120.0 (2017-07-07 19:52 UTC)
* DirectoryService (3.3.2.0)
	* You can now improve the resilience and performance of your Microsoft AD directory by deploying additional domain controllers. Added UpdateNumberofDomainControllers API that allows you to update the number of domain controllers you want for your directory, and DescribeDomainControllers API that allows you to describe the detailed information of each domain controller of your directory. Also added the 'DesiredNumberOfDomainControllers' field to the DescribeDirectories API output for Microsoft AD.
* KeyManagementService (3.3.3.0)
	* This release of AWS Key Management Service introduces the ability to determine whether a key is AWS managed or customer managed.
* Kinesis (3.3.3.0)
	* You can now encrypt your data at rest within an Amazon Kinesis Stream using server-side encryption. Server-side encryption via AWS KMS makes it easy for customers to meet strict data management requirements by encrypting their data at rest within the Amazon Kinesis Streams, a fully managed real-time data processing service.
* SimpleSystemsManagement (3.3.7.0)
	* Amazon EC2 Systems Manager now expands Patching support to Amazon Linux, Red Hat and Ubuntu in addition to the already supported Windows Server.
* Core 3.3.17.1
	* ECS/ECR now available in BJS



### 3.3.119.0 (2017-07-07 01:29 UTC)
* Core 3.3.17.0
	* Fix dependency issues introduced by VS2017 migration
	* All services packages updated to require new Core

### 3.3.118.0 (2017-07-05 17:15 UTC)
* CloudWatch (3.3.3.0)
	* We are excited to announce the availability of APIs and CloudFormation support for CloudWatch Dashboards. You can use the new dashboard APIs or CloudFormation templates to dynamically build and maintain dashboards to monitor your infrastructure and applications. There are four new dashboard APIs - PutDashboard, GetDashboard, DeleteDashboards, and ListDashboards APIs. PutDashboard is used to create a new dashboard or modify an existing one whereas GetDashboard is the API to get the details of a specific dashboard. ListDashboards and DeleteDashboards are used to get the names or delete multiple dashboards respectively. Getting started with dashboard APIs is similar to any other AWS APIs. The APIs can be accessed through AWS SDK or through CLI tools.
* Core 3.3.16.0
	* AWSSDK.Core package's dependency update
	* All services packages updated to require new Core
* AWSSDK.Extensions.NETCore.Setup (3.3.3)
	* Updated package dependencies: more accurate version range of AWSSDK.Core and latest Microsoft.Extensions packages.

### 3.3.117.0 (2017-06-30 19:03 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.3.9)
	* Documentation updates for AWS Marketplace Commerce Analytics.
* S3 (3.3.8.0)
	* API Update for S3: Adding Object Tagging Header to MultipartUpload Initialization

### 3.3.116.0 (2017-06-29 23:45 UTC)
* CloudWatchEvents (3.3.2.0)
	* CloudWatch Events now allows different AWS accounts to share events with each other through a new resource called event bus. Event buses accept events from AWS services, other AWS accounts and PutEvents API calls. Currently all AWS accounts have one default event bus. To send events to another account, customers simply write rules to match the events of interest and attach an event bus in the receiving account as the target to the rule. The PutTargets API has been updated to allow adding cross account event buses as targets. In addition, we have released two new APIs - PutPermission and RemovePermission - that enables customers to add/remove permissions to their default event bus.
* GameLift (3.3.6.0)
	* Allow developers to download GameLift fleet creation logs to assist with debugging.
* SimpleSystemsManagement (3.3.6.0)
	* Adding Resource Data Sync support to SSM Inventory.  New APIs:  * CreateResourceDataSync - creates a new resource data sync configuration,  * ListResourceDataSync - lists existing resource data sync configurations,  * DeleteResourceDataSync - deletes an existing resource data sync configuration. 

### 3.3.115.0 (2017-06-28 21:52 UTC)
* ServiceCatalog (3.3.4.0)
	* Proper tagging of resources is critical to post-launch operations such as billing, cost allocation, and resource management. By using Service Catalog's TagOption Library, administrators can define a library of re-usable TagOptions that conform to company standards, and associate these with Service Catalog portfolios and products. Learn how to move your current tags to the new library, create new TagOptions, and view and associate your library items with portfolios and products. Understand how to ensure that the right tags are created on products launched through Service Catalog and how to provide users with defined selectable tags.
* Core 3.3.15.0
	* Allow session credentials to be used as the source for assume role profiles. AWS Greengrass is now available in new regions.
	* All services packages updated to require new Core

### 3.3.114.0 (2017-06-23 19:10 UTC)
* Lambda (3.3.7.0)
	* The Lambda Invoke API will now throw new exception InvalidRuntimeException (status code 502) for invokes with deprecated runtimes.

### 3.3.113.0 (2017-06-22 23:13 UTC)
* AWSMarketplaceMetering (3.3.1.15)
	* Documentation update.
* CodePipeline (3.3.1.0)
	* A new API, ListPipelineExecutions, enables you to retrieve summary information about the most recent executions in a pipeline, including pipeline execution ID, status, start time, and last updated time. You can request information for a maximum of 100 executions. Pipeline execution data is available for the most recent 12 months of activity.
* DatabaseMigrationService (3.3.3.0)
	* Added tagging for DMS certificates.
* ImportExport (3.3.0.18)
	* Documentation update.
* Lightsail (3.3.2.0)
	* This release adds a new nextPageToken property to the result of the GetOperationsForResource API. Developers can now get the next set of items in a list by making subsequent calls to GetOperationsForResource API with the token from the previous call. This release also deprecates the nextPageCount property, which previously returned null (use the nextPageToken property instead). This release also deprecates the customImageName property on the CreateInstancesRequest class, which was previously ignored by the API.
* Route53 (3.3.6.0)
	* Amazon Route 53 now supports multivalue answers in response to DNS queries, which lets you route traffic approximately randomly to multiple resources, such as web servers. Create one multivalue answer record for each resource and, optionally, associate an Amazon Route 53 health check with each record, and Amazon Route 53 responds to DNS queries with up to eight healthy records.
* Core 3.3.14.2
	* Lambda is now available in the Canada (Central) region.



### 3.3.112.0 (2017-06-21 21:55 UTC)
* DAX (3.3.0.0)
	* Amazon DynamoDB Accelerator (DAX) is a fully managed, highly available, in-memory cache for DynamoDB that delivers up to a 10x performance improvement - from milliseconds to microseconds - even at millions of requests per second. DAX does all the heavy lifting required to add in-memory acceleration to your DynamoDB tables, without requiring developers to manage cache invalidation, data population, or cluster management.
* SimpleSystemsManagement (3.3.5.0)
	* Adding hierarchy support to the SSM Parameter Store API. Added support tor tagging. New APIs: GetParameter - retrieves one parameter, DeleteParameters - deletes multiple parameters (max number 10), GetParametersByPath - retrieves parameters located in the hierarchy. Updated APIs: PutParameter - added ability to enforce parameter value by applying regex (AllowedPattern), DescribeParameters - modified to support Tag filtering.
* WAF (3.3.2.0)
	* You can now create, edit, update, and delete a new type of WAF rule with a rate tracking component.
* WAFRegional (3.3.1.0)
	* You can now create, edit, update, and delete a new type of WAF rule with a rate tracking component.

### 3.3.111.0 (2017-06-20 19:13 UTC)
* WorkDocs (3.3.2.0)
	* This release provides a new API to retrieve the activities performed by WorkDocs users.

### 3.3.110.0 (2017-06-19 18:22 UTC)
* Organizations (3.3.3.0)
	* Improvements to Exception Modeling

### 3.3.109.0 (2017-06-16 17:00 UTC)
* XRay (3.3.1.0)
	* Add a response time histogram to the services in response of GetServiceGraph API.

### 3.3.108.0 (2017-06-15 20:42 UTC)
* EC2 (3.3.14.0)
	* Adds API to describe Amazon FPGA Images (AFIs) available to customers, which includes public AFIs, private AFIs that you own, and AFIs owned by other AWS accounts for which you have load permissions.
* ECS (3.3.5.0)
	* Added support for cpu, memory, and memory reservation container overrides on the RunTask and StartTask APIs.
* IoT (3.3.5.0)
	* Revert the last release: remove CertificatePem from DescribeCertificate API.
* ServiceCatalog (3.3.3.0)
	* Added ProvisioningArtifactSummaries to DescribeProductAsAdmin's output to show the provisioning artifacts belong to the product. Allow filtering by SourceProductId in SearchProductsAsAdmin for AWS Marketplace products. Added a verbose option to DescribeProvisioningArtifact to display the CloudFormation template used to create the provisioning artifact.Added DescribeProvisionedProduct API. Changed the type of ProvisionedProduct's Status to be distinct from Record's Status. New ProvisionedProduct's Status are AVAILABLE, UNDER_CHANGE, TAINTED, ERROR. Changed Record's Status set of values to CREATED, IN_PROGRESS, IN_PROGRESS_IN_ERROR, SUCCEEDED, FAILED.

### 3.3.107.0 (2017-06-14 20:31 UTC)
* ApplicationAutoScaling (3.3.3.0)
	* Application Auto Scaling now supports automatic scaling of read and write throughput capacity for DynamoDB tables and global secondary indexes.
* CloudDirectory (3.3.3.1)
	* Documentation update for Cloud Directory

### 3.3.106.0 (2017-06-13 19:03 UTC)
* ConfigService (3.3.7.0)
	* With this release AWS Config supports the Amazon CloudWatch alarm resource type.

### 3.3.105.0 (2017-06-13 00:46 UTC)
* RDS (3.3.12.0)
	* API Update for RDS: this update enables copy-on-write, a new Aurora MySQL Compatible Edition feature that allows users to restore their database, and support copy of TDE enabled snapshot cross region.
* S3 (3.3.7.0)
	* URL encode tagging keys and values in requests to S3 PutObject.

### 3.3.104.0 (2017-06-09 16:57 UTC)
* OpsWorks (3.3.2.0)
	* Tagging Support for AWS OpsWorks Stacks

### 3.3.103.0 (2017-06-08 20:33 UTC)
* IoT (3.3.4.0)
	* In addition to using certificate ID, AWS IoT customers can now obtain the description of a certificate with the certificate PEM.
* Pinpoint (3.3.2.0)
	* Starting today Amazon Pinpoint adds SMS Text and Email Messaging support in addition to Mobile Push Notifications, providing developers, product managers and marketers with multi-channel messaging capabilities to drive user engagement in their applications. Pinpoint also enables backend services and applications to message users directly and provides advanced user and app analytics to understand user behavior and messaging performance.
* Rekognition (3.3.5.0)
	* API Update for AmazonRekognition: Adding RecognizeCelebrities API
* S3 (3.3.6.3)
	* Updated ListVersions to populate S3ObjectVersion.Bucket property.

### 3.3.102.0 (2017-06-07 17:50 UTC)
* CodeBuild (3.3.1.0)
	* Add support to APIs for privileged containers. This change would allow performing privileged operations like starting the Docker daemon inside builds possible in custom docker images.
* Greengrass (3.3.0.0)
	* AWS Greengrass is software that lets you run local compute, messaging, and device state synchronization for connected devices in a secure way. With AWS Greengrass, connected devices can run AWS Lambda functions, keep device data in sync, and communicate with other devices securely even when not connected to the Internet. Using AWS Lambda, Greengrass ensures your IoT devices can respond quickly to local events, operate with intermittent connections, and minimize the cost of transmitting IoT data to the cloud.

### 3.3.101.0 (2017-06-06 23:10 UTC)
* CertificateManager (3.3.2.11)
	* Documentation update for AWS Certificate Manager.
* CloudFront (3.3.4.1)
	* Doc update to fix incorrect prefix in S3OriginConfig
* IoT (3.3.3.0)
	* Update client side validation for SalesForce action.
* SQS (3.3.2.4)
	* Update SQS constants for FIFO-related attributes.

### 3.3.100.0 (2017-06-05 21:17 UTC)
* AppStream (3.3.3.0)
	* AppStream 2.0 Custom Security Groups allows you to easily control what network resources your streaming instances and images have access to. You can assign up to 5 security groups per Fleet to control the inbound and outbound network access to your streaming instances to specific IP ranges, network protocols, or ports.
* IoT (3.3.2.0)
	*  Added Salesforce action to IoT Rules Engine.

### 3.3.99.0 (2017-06-02 19:32 UTC)
* KinesisAnalytics (3.3.1.0)
	* Kinesis Analytics publishes error messages CloudWatch logs in case of application misconfigurations
* S3 (3.3.6.2)
	* Updated to use new Core, version 3.3.14.1
	* Allow users to force SigV2 using S3 client config and default S3 client config to use SigV4.
* WorkDocs (3.3.1.0)
	* This release includes new APIs to manage tags and custom metadata on resources and also new APIs to add and retrieve comments at the document level.
* Core 3.3.14.1
	* Fix issue when reading profiles with duplicate keys from shared credentials file. Updated the endpoints file.

### 3.3.98.0 (2017-06-01 19:41 UTC)
* CodeDeploy (3.3.5.0)
	* AWS CodeDeploy has improved how it manages connections to GitHub accounts and repositories. You can now create and store up to 25 connections to GitHub accounts in order to associate AWS CodeDeploy applications with GitHub repositories. Each connection can support multiple repositories. You can create connections to up to 25 different GitHub accounts, or create more than one connection to a single account. The ListGitHubAccountTokenNames command has been introduced to retrieve the names of stored connections to GitHub accounts that you have created. The name of the connection to GitHub used for an AWS CodeDeploy application is also included in the ApplicationInfo structure.  Two new fields, lastAttemptedDeployment and lastSuccessfulDeployment, have been added to DeploymentGroupInfo to improve the handling of deployment group information in the AWS CodeDeploy console. Information about these latest deployments can also be retrieved using the GetDeploymentGroup and BatchGetDeployment group requests. Also includes a region update  (us-gov-west-1).
* CognitoIdentityProvider (3.3.4.0)
	* Added support within Amazon Cognito User Pools for 1) a customizable hosted UI for user sign up and sign in and 2) integration of external identity providers.
* ElasticLoadBalancingV2 (3.3.3.0)
	* Update the existing DescribeRules API to support pagination.
* LexModelBuildingService (3.3.1.1)
	* Updated documentation and added examples for Amazon Lex Runtime Service.

### 3.3.97.0 (2017-05-31 19:29 UTC)
* RDS (3.3.11.0)
	* Amazon RDS customers can now easily and quickly stop and start their DB instances.

### 3.3.96.0 (2017-05-31 00:28 UTC)
* CloudDirectory (3.3.3.0)
	* Cloud Directory has launched support for Typed Links, enabling customers to create object-to-object relationships that are not hierarchical in nature. Typed Links enable customers to quickly query for data along these relationships. Customers can also enforce referential integrity using Typed Links, ensuring data in use is not inadvertently deleted.

### 3.3.95.1 (2017-05-28 00:08 UTC)
* ApplicationDiscoveryService (3.3.2.8)
	* Doc update
* Rekognition (3.3.4.1)
	* Doc update

### 3.3.95.0 (2017-05-25 22:08 UTC)
* AppStream (3.3.2.0)
	* Support added for persistent user storage, backed by S3.
* Rekognition (3.3.4.0)
	* Updated the CompareFaces API response to include orientation information, unmatched faces, landmarks, pose, and quality of the compared faces.

### 3.3.94.0 (2017-05-24 23:55 UTC)
* DynamoDBv2 (3.3.4.13)
	* Add missing Batch operations to IDynamoDBContext
* IdentityManagement (3.3.4.0)
	* The unique ID and access key lengths were extended from 32 to 128
* SecurityToken (3.3.2.0)
	* The unique ID and access key lengths were extended from 32 to 128.
* StorageGateway (3.3.4.0)
	* Two Storage Gateway data types, Tape and TapeArchive, each have a new response element, TapeUsedInBytes. This element helps you manage your virtual tapes. By using TapeUsedInBytes, you can see the amount of data written to each virtual tape.

### 3.3.93.0 (2017-05-24 00:31 UTC)
* DatabaseMigrationService (3.3.2.0)
	* This release adds support for using Amazon S3 and Amazon DynamoDB as targets for database migration, and using MongoDB as a source for database migration. For more information, see the AWS Database Migration Service documentation.

### 3.3.92.0 (2017-05-22 23:22 UTC)
* ResourceGroupsTaggingAPI (3.3.1.0)
	* You can now specify the number of resources returned per page in GetResources operation, as an optional parameter, to easily manage the list of resources returned by your queries.

### 3.3.91.0 (2017-05-19 22:45 UTC)
* CloudFront (3.3.4.0)
	* Security update to CloudFront Cookie Signer in the SDK. The fix contains a
change to the AmazonCloudFrontCookieSigner.Protocols enum's
underlying values (a breaking change) and requires a recompilation of the
consuming application. The assembly version for AWSSDK.CloudFront.dll has been
updated for this fix. There are no other breaking API changes in this version.

### 3.3.90.0 (2017-05-18 20:37 UTC)
* Athena (3.3.0.0)
	* This release adds support for Amazon Athena. Amazon Athena is an interactive query service that makes it easy to analyze data in Amazon S3 using standard SQL. Athena is serverless, so there is no infrastructure to manage, and you pay only for the queries that you run.
* Lightsail (3.3.1.0)
	* This release adds new APIs that make it easier to set network port configurations on Lightsail instances. Developers can now make a single request to both open and close public ports on an instance using the PutInstancePublicPorts operation.

### 3.3.89.0 (2017-05-17 22:31 UTC)
* AutoScaling (3.3.0.19)
	* Various Auto Scaling documentation updates
* CloudWatchEvents (3.3.1.10)
	* Various CloudWatch Events documentation updates.
* CloudWatchLogs (3.3.2.13)
	* Various CloudWatch Logs documentation updates.
* Polly (3.3.2.0)
	* Amazon Polly adds new German voice "Vicki"

### 3.3.88.0 (2017-05-16 20:46 UTC)
* CodeDeploy (3.3.4.0)
	* This release introduces the previousRevision field in the responses to the GetDeployment and BatchGetDeployments actions. previousRevision provides information about the application revision that was deployed to the deployment group before the most recent successful deployment.  Also, the fileExistsBehavior parameter has been added for CreateDeployment action requests. In the past, if the AWS CodeDeploy agent detected files in a target location that weren't part of the application revision from the most recent successful deployment, it would fail the current deployment by default. This new parameter provides options for how the agent handles these files: fail the deployment, retain the content, or overwrite the content.
* GameLift (3.3.5.0)
	* Allow developers to specify how metrics are grouped in CloudWatch for their GameLift fleets. Developers can also specify how many concurrent game sessions activate on a per-instance basis.
* Inspector (3.3.1.0)
	* Adds ability to produce an assessment report that includes detailed and comprehensive results of a specified assessment run.
* KeyManagementService (3.3.2.12)
	* Update documentation for KMS.

### 3.3.87.0 (2017-05-15 20:48 UTC)
* SimpleSystemsManagement (3.3.4.0)
	* UpdateAssociation API now supports updating document name and targets of an association. GetAutomationExecution API can return FailureDetails as an optional field to the StepExecution Object, which contains failure type, failure stage as well as other failure related information for a failed step.

### 3.3.86.0 (2017-05-11 21:05 UTC)
* ElasticLoadBalancing (3.3.1.0)
	* Add a new API to allow customers to describe their account limits, such as load balancer limit, target group limit etc.
* ElasticLoadBalancingV2 (3.3.2.0)
	* Add a new API to allow customers to describe their account limits, such as load balancer limit, target group limit etc.
* LexModelBuildingService (3.3.1.0)
	* Releasing new DeleteBotVersion, DeleteIntentVersion and DeleteSlotTypeVersion APIs.
* Organizations (3.3.2.0)
	* AWS Organizations APIs that return an Account object now include the email address associated with the account’s root user.
* Core 3.3.14.0
	* Added AWSConfigs.ManualClockCorrection property to manually configure SDK's clock correction.
	* All services packages updated to require new Core

### 3.3.85.0 (2017-05-10 00:17 UTC)
* CognitoIdentityProvider (3.3.3.0)
	* API Update for CognitoUserPools: Group support
* CognitoSync (3.3.1.17)
	* Added developer guide references to CognitoSyncManager docs
* EC2 (3.3.13.5)
	* Added comments to EC2Metadata clarifying that the properties on this class will return null when accessed outside of EC2. Updated properties that current throw exceptions to return null instead.
* S3 (3.3.6.0)
	* Provide GetPresignedURL() function in S3 Unity

### 3.3.84.2 (2017-05-09 17:49 UTC)
* CodeStar (3.3.0.5)
	* Updated documentation for AWS CodeStar.
* WorkSpaces (3.3.0.17)
	* Doc-only Update for WorkSpaces

### 3.3.84.1 (2017-05-08 20:59 UTC)
* Core 3.3.13.4
	* Re-compute region endpoint when ClientConfig.RegionEndpoint is set to null.
Added .Net Core connection error case to the list of retry able exceptions.
Fixed IAMSecurityCredentials, BlockDeviceMapping, and NetworkInterfaces properties of EC2InstanceMetadata to return null instead of throwing NullReferenceException when accessed in non-EC2 environments.
Make HttpClientHandler.MaxConnectionsPerServer configurable for .NET Core via IClientConfig.

	* All services packages updated to require new Core

### 3.3.84.0 (2017-05-04 23:45 UTC)
* ECS (3.3.4.0)
	* Exposes container instance registration time in ECS:DescribeContainerInstances.
* Lambda (3.3.6.0)
	* Support for UpdateFunctionCode DryRun option
* MarketplaceEntitlementService (3.3.0.0)
	* AWS Marketplace Entitlement Service enables AWS Marketplace sellers to determine the capacity purchased by their customers.
* RDS (3.3.10.1)
	* Fix PreSignedUrl generation for RDS CopyDBSnapshot operation.
* Core 3.3.13.3
	* Added retries for WebExceptionStatus.SendFailure.
	* All services packages updated to require new Core
* AWSSDK.Extensions.NETCore.Setup (3.3.1)
	* Use new CredentialManagement namespace classes in AWSSDK.Extensions.NETCore.Setup.

### 3.3.83.0 (2017-04-28 21:28 UTC)
* CloudFormation (3.3.5.0)
	* API update for CloudFormation: New optional parameter ClientRequestToken which can be used as an idempotency token to safely retry certain operations as well as tagging StackEvents.
* RDS (3.3.10.0)
	* The DescribeDBClusterSnapshots API now returns a SourceDBClusterSnapshotArn field which identifies the source DB cluster snapshot of a copied snapshot.
* Rekognition (3.3.3.0)
	* Fix for missing file type check
* Snowball (3.3.2.0)
	* The Snowball API has a new exception that can be thrown for list operation requests.
* SQS (3.3.2.0)
	* Adding server-side encryption (SSE) support to SQS by integrating with AWS KMS; adding new queue attributes to SQS CreateQueue, SetQueueAttributes and GetQueueAttributes APIs to support SSE.

### 3.3.82.1 (2017-04-27 23:30 UTC)
* MobileAnalytics (3.3.1.14)
	* Log ThreadAbortException in Unity
* Core 3.3.13.2
	* Fixed a bug where loading Core assembly will result in failed endpoint file path resolution.
	* All services packages updated to require new Core

### 3.3.82.0 (2017-04-26 17:29 UTC)
* RDS (3.3.9.0)
	* With Amazon Relational Database Service (Amazon RDS) running MySQL or Amazon Aurora, you can now authenticate to your DB instance using IAM database authentication.

### 3.3.81.1 (2017-04-26 14:09 UTC)
* DynamoDBv2 (3.3.4.8)
	* Fixed xml doc errors
* S3 (3.3.5.14)
	* Fixed xml doc errors, made all unmarshallers public
* Core 3.3.13.1
	* Fixed xml doc errors

### 3.3.81.0 (2017-04-21 20:15 UTC)
* AppStream (3.3.1.0)
	* The new feature named "Default Internet Access" will enable Internet access from AppStream 2.0 instances - image builders and fleet instances. Admins will check a flag either through AWS management console for AppStream 2.0 or through API while creating an image builder or while creating/updating a fleet.
* Kinesis (3.3.2.0)
	* Adds a new waiter, StreamNotExists, to Kinesis.

### 3.3.80.0 (2017-04-21 18:02 UTC)
* CloudFront (3.3.3.2)
	* Updated to use new Core, version 3.3.13.0
	* Fix AmazonCloudFrontUrlSigner bug in Linux/Mac.
* MobileAnalytics (3.3.1.13)
	* Fix BackgroundRunner to allow smooth application shutdown, and manual abort.
* Core 3.3.13.0
	* Implement support for x-amzn-error-message header. Fix issue with S3 chunk encoding and Content-Encoding header.
	* all services packages updated to require new core

### 3.3.79.0 (2017-04-20 21:36 UTC)
* DeviceFarm (3.3.2.0)
	* API Update for AWS Device Farm: Support for Deals and Promotions 
* DirectConnect (3.3.4.3)
	* Documentation updates for AWS Direct Connect.
* KeyManagementService (3.3.2.6)
	* Doc-only update for Key Management Service (KMS): Update docs for GrantConstraints and GenerateRandom
* Route53 (3.3.5.6)
	* Release notes: SDK documentation now includes examples for ChangeResourceRecordSets for all types of resource record set, such as weighted, alias, and failover.

* Route53Domains (3.3.0.13)
	* Adding examples and other documentation updates.

### 3.3.78.0 (2017-04-19 23:02 UTC)
* APIGateway (3.3.7.0)
	* Updated to use new Core, version 3.3.12.0
	* Add support for "embed" property.
* CodeStar (3.3.0.0)
	* AWS CodeStar is a cloud-based service for creating, managing, and working with software development projects on AWS. An AWS CodeStar project creates and integrates AWS services for your project development toolchain. AWS CodeStar also manages the permissions required for project users.
* EC2 (3.3.13.0)
	* Adds support for creating an Amazon FPGA Image (AFI) from a specified design checkpoint (DCP).
* IdentityManagement (3.3.3.0)
	* This changes introduces a new IAM role type, Service Linked Role, which works like a normal role but must be managed via services' control. 
* Lambda (3.3.5.0)
	* Lambda integration with CloudDebugger service to enable customers to enable tracing for the Lambda functions and send trace information to the CloudDebugger service.
* LexModelBuildingService (3.3.0.0)
	* Amazon Lex is a service for building conversational interfaces into any application using voice and text.
* Polly (3.3.1.0)
	* Updated to use new Core, version 3.3.12.0
	* API Update for Amazon Polly: Add support for speech marks
* Rekognition (3.3.2.0)
	* Given an image, the API detects explicit or suggestive adult content in the image and returns a list of corresponding labels with confidence scores, as well as a taxonomy (parent-child relation) for each label.

### 3.3.77.0 (2017-04-19 00:42 UTC)
* Lambda (3.3.4.0)
	* You can use tags to group and filter your Lambda functions, making it easier to analyze them for billing allocation purposes. For more information, see Tagging Lambda Functions.  You can now write or upgrade your Lambda functions using Python version 3.6. For more information, see Programming Model for Authoring Lambda Functions in Python. Note: Features will be rolled out in the US regions on 4/19.
* Core 3.3.12.0
	* Added support for a list of strings in query.
	* all services packages updated to require new core

### 3.3.76.0 (2017-04-11 21:24 UTC)
* APIGateway (3.3.6.0)
	* API Gateway request validators
* Batch (3.3.2.0)
	* API Update for AWS Batch: Customer provided AMI for MANAGED Compute Environment 
* DynamoDBv2 (3.3.4.5)
	* Documentation update.
* GameLift (3.3.4.0)
	* Allows developers to utilize an improved workflow when calling our Queues API and introduces a new feature that allows developers to specify a maximum allowable latency per Queue.
* OpsWorks (3.3.1.0)
	* Cloudwatch Logs agent configuration can now be attached to OpsWorks Layers using CreateLayer and UpdateLayer. OpsWorks will then automatically install and manage the CloudWatch Logs agent on the instances part of the OpsWorks Layer.
* Core 3.3.11.0
	* Fix issue with user agent header when calling S3 CopyObject API.

### 3.3.75.0 (2017-04-07 22:20 UTC)
* Redshift (3.3.2.0)
	* This update adds the GetClusterCredentials API which is used to get temporary login credentials to the cluster. AccountWithRestoreAccess now has a new member AccountAlias, this is the identifier of the AWS support account authorized to restore the specified snapshot. This is added to support the feature where the customer can share their snapshot with the Amazon Redshift Support Account without having to manually specify the AWS Redshift Service account ID on the AWS Console/API.
* Core 3.3.10.6
	* Support side-loading endpoints.json file and fix timeout issue with AWSSDKUtils.DownloadStringContent

### 3.3.74.1 (2017-04-06 17:12 UTC)
* ElasticLoadBalancingV2 (3.3.1.5)
	* Adds supports a new condition for host-header conditions to CreateRule and ModifyRule

### 3.3.74.0 (2017-04-05 23:27 UTC)
* ElastiCache (3.3.3.0)
	* ElastiCache added support for testing the Elasticache Multi-AZ feature with Automatic Failover.
* Core 3.3.10.5
	* Documentation update for ClientConfig timeout properties.

### 3.3.73.0 (2017-04-04 17:08 UTC)
* CloudWatch (3.3.2.0)
	* Amazon Web Services announced the immediate availability of two additional alarm configuration rules for Amazon CloudWatch Alarms. The first rule is for configuring missing data treatment. Customers have the options to treat missing data as alarm threshold breached, alarm threshold not breached, maintain alarm state and the current default treatment. The second rule is for alarms based on percentiles metrics that can trigger unnecassarily if the percentile is calculated from a small number of samples. The new rule can treat percentiles with low sample counts as same as missing data. If the first rule is enabled, the same treatment will be applied when an alarm encounters a percentile with low sample counts.

### 3.3.72.0 (2017-04-03 22:03 UTC)
* Lex (3.3.1.0)
	* Updated to use new Core, version 3.3.10.4
	* Adds support to PostContent for speech input
* Core 3.3.10.4
	* Update to support Lex PostContent operation.

### 3.3.71.0 (2017-03-31 18:43 UTC)
* CloudDirectory (3.3.2.0)
	* ListObjectAttributes now supports filtering by facet.

### 3.3.70.0 (2017-03-31 04:55 UTC)
* CloudFormation (3.3.4.0)
	* Adding paginators for ListExports and ListImports
* CloudFront (3.3.3.0)
	* Amazon CloudFront now supports user configurable HTTP Read and Keep-Alive Idle Timeouts for your Custom Origin Servers
* ConfigService (3.3.6.5)
	* .
* ResourceGroupsTaggingAPI (3.3.0.0)
	* Resource Groups Tagging APIs can help you organize your resources and enable you to simplify resource management, access management, and cost allocation.
* StorageGateway (3.3.3.0)
	* File gateway mode in AWS Storage gateway provides access to objects in S3 as files on a Network File System (NFS) mount point. Once a file share is created, any changes made externally to the S3 bucket will not be reflected by the gateway. Using the cache refresh feature in this update, the customer can trigger an on-demand scan of the keys in their S3 bucket and refresh the file namespace cached on the gateway. It takes as an input the fileShare ARN and refreshes the cache for only that file share. Additionally there is new functionality on file gateway that allows you configure what squash options they would like on their file share, this allows a customer to configure their gateway to not squash root permissions. This can be done by setting options in NfsOptions for CreateNfsFileShare and UpdateNfsFileShare APIs.

### 3.3.69.1 (2017-03-30 22:31 UTC)
* Core 3.3.10.3
	* Fix issue with CredentialsFactory on non-Windows environments.
	* all services packages updated to require new core

### 3.3.69.0 (2017-03-28 21:45 UTC)
* Batch (3.3.1.0)
	* Customers can now provide a retryStrategy as part of the RegisterJobDefinition and SubmitJob API calls. The retryStrategy object has a number value for attempts. This is the number of non successful executions before a job is considered FAILED. In addition, the JobDetail object now has an attempts field and shows all execution attempts.
* EC2 (3.3.12.0)
	* Customers can now tag their Amazon EC2 Instances and Amazon EBS Volumes at the time of their creation. You can do this from the EC2 Instance launch wizard or through the RunInstances or CreateVolume APIs. By tagging resources at the time of creation, you can eliminate the need to run custom tagging scripts after resource creation. In addition, you can now set resource-level permissions on the CreateVolume, CreateTags, DeleteTags, and the RunInstances APIs. This allows you to implement stronger security policies by giving you more granular control over which users and groups have access to these APIs. You can also enforce the use of tagging and control what tag keys and values are set on your resources. When you combine tag usage and resource-level IAM policies together, you can ensure your instances and volumes are properly secured upon creation and achieve more accurate cost allocation reporting. These new features are provided at no additional cost. 

### 3.3.68.0 (2017-03-28 00:01 UTC)
* SimpleSystemsManagement (3.3.3.0)
	* Updated validation rules for SendCommand and RegisterTaskWithMaintenanceWindow APIs.

### 3.3.67.0 (2017-03-23 18:14 UTC)
* ApplicationAutoScaling (3.3.2.0)
	* Application AutoScaling is launching support for a new target resource (AppStream 2.0 Fleets) as a scalable target.
* CloudTrail (3.3.1.9)
	* Doc-only Update for CloudTrail: Add required parameters for GetEventSelectors and PutEventSelectors

### 3.3.66.0 (2017-03-22 21:50 UTC)
* ApplicationDiscoveryService (3.3.2.0)
	* Adds export configuration options to the AWS Discovery Service API.
* Lambda (3.3.3.0)
	* Adds support for new runtime Node.js v6.10 for AWS Lambda service

### 3.3.65.0 (2017-03-21 22:36 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.3.0)
	* This update adds a new data set, us_sales_and_use_tax_records, which enables AWS Marketplace sellers to programmatically access to their U.S. Sales and Use Tax report data.
* CodeBuild (3.3.0.10)
	* Documentation update for AWS CodeBuild
* DirectConnect (3.3.4.0)
	* Deprecated DescribeConnectionLoa, DescribeInterconnectLoa, AllocateConnectionOnInterconnect and DescribeConnectionsOnInterconnect operations in favor of DescribeLoa, DescribeLoa, AllocateHostedConnection and DescribeHostedConnections respectively.
* Pinpoint (3.3.1.0)
	* Amazon Pinpoint User Segmentation * Added ability to segment endpoints by user attributes in addition to endpoint attributes. Amazon Pinpoint Event Stream Preview * Added functionality to publish raw app analytics and campaign events data as events streams to Kinesis and Kinesis Firehose * The feature provides developers with increased flexibility of exporting raw events to S3, Redshift, Elasticsearch using a Kinesis Firehose stream or enable real time event processing use cases using a Kinesis stream
* Rekognition (3.3.1.4)
	* Doc only reference update for Rekognition 

### 3.3.64.2 (2017-03-16 23:15 UTC)
* Core 3.3.10.2
	* Fix issue when copying or renaming a credential profile to a profile with the same name.

### 3.3.64.1 (2017-03-15 21:58 UTC)
* Core 3.3.10.1
	* Fixed role authentication failure on ECS reported at https://github.com/aws/aws-sdk-net/issues/588.
	* all services packages updated to require new core

### 3.3.64.0 (2017-03-14 18:49 UTC)
* Core 3.3.10.0
	* Fix FallbackCredentialsFactory and FallbackRegionFactory on platforms without Windows crypto.
	* all services packages updated to require new core

### 3.3.63.0 (2017-03-14 05:25 UTC)
* CloudWatchEvents (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* This update extends Target Data Type for configuring Target behavior during invocation.
* DeviceFarm (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* Network shaping allows users to simulate network connections and conditions while testing their Android, iOS, and web apps with AWS Device Farm.
* SecurityToken (3.3.1.0)
	* Updated to use new Core, version 3.3.9.0
	* Changes to STS to support new assume role credentials features.
* Core 3.3.9.0
	* Support writing of AWS shared credentials file. Support assume role profiles in .NET credentials file and shared credentials file.
	* all services packages updated to require new core

### 3.3.62.0 (2017-03-10 22:50 UTC)
* ElasticMapReduce (3.3.3.0)
	* This release includes support for instance fleets.

### 3.3.61.0 (2017-03-09 22:22 UTC)
* APIGateway (3.3.5.0)
	* API Gateway has added support for ACM certificates on custom domain names. Both Amazon-issued certificates and uploaded third-part certificates are supported.
* CloudDirectory (3.3.1.0)
	* Introduces a new Cloud Directory API that enables you to retrieve all available parent paths for any type of object (a node, leaf node, policy node, and index node) in a hierarchy.

### 3.3.60.0 (2017-03-09 01:36 UTC)
* DynamoDBv2 (3.3.4.0)
	* Adding Time-to-Live support to higher-level APIs.
* Organizations (3.3.1.0)
	* Picked up the latest model updates. Note that this includes breaking changes to the service interface, client, and model shapes.
* WorkDocs (3.3.0.0)
	* Amazon WorkDocs SDK provides full administrator level access to WorkDocs site resources, allowing developers to integrate their applications to manage WorkDocs users, content and permissions programmatically.

### 3.3.59.0 (2017-03-08 01:33 UTC)
* RDS (3.3.8.0)
	* Add support to using encrypted clusters as cross-region replication masters. Update CopyDBClusterSnapshot API to support encrypted cross region copy of Aurora cluster snapshots.

### 3.3.58.0 (2017-03-07 02:39 UTC)
* Budgets (3.3.1.0)
	* API Update for Budgets: When creating or editing a budget via the AWS Budgets API you can define notifications that are sent to subscribers when the actual or forecasted value for cost or usage exceeds the notificationThreshold associated with the budget notification object. Starting today, the maximum allowed value for the notificationThreshold was raised from 100 to 300. This change was made to give you more flexibility when setting budget notifications.
* CloudTrail (3.3.1.5)
	* Doc update for CloudTrail
* EC2 (3.3.11.0)
	* Adds keys to obtain the latest Windows 2016 Core and Windows 2012R2 Core images to the Amazon.EC2.Util.ImageUtilities helper class.
* OpsWorksCM (3.3.3.0)
	* API Update for OpsWorksCM: OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.

### 3.3.57.0 (2017-02-28 04:05 UTC)
* DynamoDBv2 (3.3.3.0)
	* Time to Live (TTL) is a feature that allows you to define when items in a table expire and can be purged from the database, so that you don't have to track expired data and delete it manually. With TTL enabled on a DynamoDB table, you can set a timestamp for deletion on a per-item basis, allowing you to limit storage usage to only those records that are relevant.
* Elasticsearch (3.3.1.0)
	* Adding API's to expose limits imposed by Elasticsearch.
* IdentityManagement (3.3.2.0)
	* This release adds support for AWS Organizations service control policies (SCPs) to SimulatePrincipalPolicy operation. If there are SCPs associated with the simulated user's account, their effect on the result is captured in the OrganizationDecisionDetail element in the EvaluationResult
* MTurk (3.3.0.0)
	* Amazon Mechanical Turk is a web service that provides an on-demand, scalable, human workforce to complete jobs that humans can do better than computers, for example, recognizing objects in photos.
* Organizations (3.3.0.0)
	* AWS Organizations is a web service that enables you to consolidate your multiple AWS accounts into an organization and centrally manage your accounts and their resources.
* WAF (3.3.1.9)
	* Doc update for WAF

### 3.3.56.1 (2017-02-24 02:15 UTC)
* S3 (3.3.5.7)
	* Updated to use new Core, version 3.3.8.2
	* Pick up Core changes for decompression fix.
* Core 3.3.8.2
	* Disable .NET Core version of SDK automatically decompressing streams.

### 3.3.56.0 (2017-02-23 20:54 UTC)
* CognitoSync (3.3.1.7)
	* Fixed dependencies for UWP target framework, https://github.com/aws/aws-sdk-net/issues/550 .
* EC2 (3.3.10.0)
	* New EC2 I3 instance type.
* MobileAnalytics (3.3.1.7)
	* Fixed dependencies for UWP target framework, https://github.com/aws/aws-sdk-net/issues/550 .

### 3.3.55.0 (2017-02-22 21:16 UTC)
* CloudDirectory (3.3.0.2)
	* ListObjectAttributes documentation updated based on forum feedback
* ElasticBeanstalk (3.3.4.0)
	* Elastic Beanstalk adds support for creating and managing custom platform.
* GameLift (3.3.3.0)
	* Allow developers to configure global queues for creating GameSessions. Allow PlayerData on PlayerSessions to store player-specific data.
* Route53 (3.3.5.0)
	* Added support for operations CreateVPCAssociationAuthorization and DeleteVPCAssociationAuthorization to throw a ConcurrentModification error when a conflicting modification occurs in parallel to the authorizations in place for a given hosted zone.

### 3.3.54.0 (2017-02-21 23:35 UTC)
* EC2 (3.3.9.0)
	* Added the BillingProduct parameter to the RegisterImage API.
* S3 (3.3.5.6)
	* Fixed issue with TransferUtility directory operations while using AmazonS3EncryptionClient.

### 3.3.53.0 (2017-02-17 19:48 UTC)
* DirectConnect (3.3.3.0)
	* This update will introduce the ability for Direct Connect customers to take advantage of Link Aggregation (LAG). This allows you to bundle many individual physical interfaces into a single logical interface, referred to as a LAG. This makes administration much simpler as the majority of configuration is done on the LAG while you are free to add or remove physical interfaces from the bundle as bandwidth demand increases or decreases. A concrete example of the simplification added by LAG is that customers need only a single BGP session as opposed to one session per physical connection.

### 3.3.52.0 (2017-02-17 02:26 UTC)
* CognitoIdentity (3.3.2.0)
	* Allow createIdentityPool and updateIdentityPool API to set server side token check value on identity pool
* ConfigService (3.3.6.0)
	* AWS Config now supports a new test mode for the PutEvaluations API. Set the TestMode parameter to true in your custom rule to verify whether your AWS Lambda function will deliver evaluation results to AWS Config. No updates occur to your existing evaluations, and evaluation results are not sent to AWS Config.
* S3 (3.3.5.5)
	* Fixed bug in TransferUtility.UploadDirectory

### 3.3.51.0 (2017-02-15 17:28 UTC)
* KeyManagementService (3.3.2.0)
	* Added tagging support

### 3.3.50.0 (2017-02-14 22:45 UTC)
* EC2 (3.3.8.0)
	* Adds support for the new Modify Volumes apis
* AWSSDK.Extensions.NETCore.Setup (3.3.0.3)
	* Added ability to explicit set AWSCredentials object on the AWSOptions

### 3.3.49.0 (2017-02-10 18:21 UTC)
* StorageGateway (3.3.2.0)
	* File gateway mode in AWS Storage gateway provides access to objects in S3 as files on a Network File System (NFS) mount point. This is done by creating Nfs file shares using existing APIs CreateNfsFileShare. Using the feature in this update, the customer can restrict the clients that have read/write access to the gateway by specifying the list of clients as a list of IP addresses or CIDR blocks. This list can be specified using the API CreateNfsFileShare while creating new file shares, or UpdateNfsFileShare while update existing file shares. To find out the list of clients that have access, the existing API DescribeNfsFileShare will now output the list of clients that have access.

### 3.3.48.0 (2017-02-10 04:29 UTC)
* OpsWorksCM (3.3.2.0)
	* Revert: OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.

### 3.3.47.0 (2017-02-09 07:39 UTC)
* EC2 (3.3.7.0)
	* This feature allows customers to associate an IAM profile to running instances that do not have any.
* OpsWorksCM (3.3.1.0)
	* OpsWorks for Chef Automate has added a new field "AssociatePublicIpAddress" to the CreateServer request, "CloudFormationStackArn" to the Server model and "TERMINATED" server state.
* Rekognition (3.3.1.0)
	* DetectFaces and IndexFaces operations now return an estimate of the age of the face as an age range.

### 3.3.46.0 (2017-02-08 01:11 UTC)
* Lex (3.3.0.0)
	* Amazon Lex is a service for building conversational interactions into any application using voice or text.

### 3.3.45.1 (2017-02-06 22:49 UTC)
* CloudDirectory (3.3.0.1)
	* Updated to use new Core, version 3.3.8.1
	* Fix unmarshalling issue.
* Lightsail (3.3.0.6)
	* Updated to use new Core, version 3.3.8.1
	* Fixed issue with incorrect exceptions being thrown for Lightsail errors.
* S3 (3.3.5.4)
	* Fix issue with V4ClientSection not having a zero-parameter constructor, https://github.com/aws/aws-sdk-net/issues/538
* Core 3.3.8.1
	* Extension to saml role profile to allow a region override, to determine STS endpoint setting, to be stored and loaded from the profile and used when constructing the STS client in regions where a specific regional endpoint must be used. Fix issue unmarshalling null MemoryStream from JSON response. Fix issue with V4ClientSection not having a zero-parameter constructor, https://github.com/aws/aws-sdk-net/issues/538

### 3.3.45.0 (2017-01-26 23:49 UTC)
* CloudDirectory (3.3.0.0)
	* New service CloudDirectory: Amazon Cloud Directory is a highly scalable, high performance, multi-tenant directory service in the cloud. Its web-based directories make it easy for you to organize and manage application resources such as users, groups, locations, devices, policies, and the rich relationships between them.
* CodeDeploy (3.3.3.0)
	* API Update for CodeDeploy: This release of AWS CodeDeploy introduces support for blue/green deployments. In a blue/green deployment, the current set of instances in a deployment group is replaced by new instances that have the latest application revision installed on them. After traffic is rerouted behind a load balancer to the replacement instances, the original instances can be terminated automatically or kept running for other uses.
* EC2 (3.3.6.0)
	* API Update for EC2: Adds instance health check functionality to replace unhealthy EC2 Spot fleet instances with fresh ones.
* RDS (3.3.7.0)
	* API Update for RDS: Snapshot Engine Version Upgrade

### 3.3.44.0 (2017-01-25 23:00 UTC)
* ElasticLoadBalancingV2 (3.3.1.0)
	* Application Load Balancers now support native Internet Protocol version 6 (IPv6) in an Amazon Virtual Private Cloud (VPC). With this ability, clients can now connect to the Application Load Balancer in a dual-stack mode via either IPv4 or IPv6.
* RDS (3.3.6.0)
	* API Update for RDS : cross Region Read Replica Copying via CreateDBInstanceReadReplica operation

### 3.3.43.0 (2017-01-24 22:15 UTC)
* CodeBuild (3.3.0.6)
	* Doc update.
* CodeCommit (3.3.1.0)
	* AWS CodeCommit now includes the option to view the differences between a commit and its parent commit from within the console. You can view the differences inline (Unified view) or side by side (Split view). To view information about the differences between a commit and something other than its parent, you can use the AWS CLI and the get-differences and get-blob commands, or you can use the GetDifferences and GetBlob APIs.
* ECS (3.3.3.0)
	* Amazon ECS now supports a state for container instances that can be used to drain a container instance in preparation for maintenance or cluster scale down.

### 3.3.42.0 (2017-01-20 18:18 UTC)
* AWSHealth (3.3.0.5)
	* Update for AWS Health: Pick up updated documentation
* CertificateManager (3.3.2.0)
	* Update for AWS Certificate Manager: Updated response elements for DescribeCertificate API in support of managed renewal
* Core 3.3.8.0
	* fixed uap packages incorrectly referencing binaries in the pcl directories instead of windows8
	* all services packages updated to require new core

### 3.3.41.0 (2017-01-19 19:23 UTC)
* EC2 (3.3.5.0)
	* Amazon EC2 Spot instances now support dedicated tenancy, providing the ability to run Spot instances single-tenant manner on physically isolated hardware within a VPC to satisfy security, privacy, or other compliance requirements. Dedicated Spot instances can be requested using RequestSpotInstances and RequestSpotFleet.

### 3.3.40.0 (2017-01-18 20:32 UTC)
* RDS (3.3.5.0)
	* We are releasing Mysql to Aurora replication feature, in rds-describe-db-instances output field, we will need to add a new field called ReadReplicaDBClusterIdentifiers.

### 3.3.39.0 (2017-01-18 02:15 UTC)
* DynamoDBv2 (3.3.2.0)
	* Tagging Support for Amazon DynamoDB Tables and Indexes
* Glacier (3.3.1.4)
	* Doc-only Update for Glacier: Added code snippets
* Polly (3.3.0.5)
	* Doc-only update for Amazon Polly -- added snippets
* Rekognition (3.3.0.5)
	* Added code samples to Rekognition reference topics.
* Route53 (3.3.4.0)
	* Add ca-central-1 and eu-west-2 enum values to CloudWatchRegion enum

### 3.3.38.0 (2017-01-17 05:37 UTC)
* ConfigService (3.3.5.0)
	* Recently we added next token implementation to some of our APIs mentioned in the title. As part of that launch we added InvalidNextTokenException to those APIs but forgot to update the model for the APIs. This item is to update the models to include InvalidNextTokenException in API response.
* CostAndUsageReport (3.3.0.0)
	* The AWS Cost and Usage Report Service API allows you to enable and disable the Cost & Usage report, as well as modify the report name, the data granularity, and the delivery preferences.
* DynamoDBv2 (3.3.1.6)
	* Snippets for the DynamoDB API.
* ElastiCache (3.3.2.4)
	* Adds new code examples.

### 3.3.37.1 (2017-01-12 23:02 UTC)
* EC2 (3.3.4.5)
	* Extended EC2 image utilities class with keys to obtain Windows Server 2012R2 images with SQL Server 2016 variants (web/express/standard).

### 3.3.37.0 (2017-01-04 23:41 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.2.0)
	* Added support for data set disbursed_amount_by_instance_hours, with historical data available starting 2012-09-04. New data is published to this data set every 30 days.
* ConfigService (3.3.4.0)
	* Added support for OversizedConfigurationItemChangeNotification message type in putConfigRule. Customers can use/write rules based on OversizedConfigurationItemChangeNotification mesage type.
* DynamoDBv2 (3.3.1.5)
	* Documentation update
* ElasticFileSystem (3.3.0.8)
	* Documentation update.
* IdentityManagement (3.3.1.2)
	* Documentation update
* Lambda (3.3.2.5)
	* Documentation update
* RDS (3.3.4.2)
	* Documentation update
* Rekognition (3.3.0.4)
	* Documentation update

### 3.3.36.0 (2016-12-29 23:59 UTC)
* CodeDeploy (3.3.2.0)
	* Add support for IAM Session ARNs in addition to IAM User ARNs for on-premise host authentication.
* ECS (3.3.2.0)
	* Add the ability to customize the placement of tasks on container instances.

### 3.3.35.2 (2016-12-28 21:01 UTC)
* DynamoDBv2 (3.3.1.4)
	* Updated to use new Core, version 3.3.7.1
	* Pick up Core change to SDK cache
* Core 3.3.7.1
	* Fixed thread-unsafe access to dictionary

### 3.3.35.1 (2016-12-27 23:11 UTC)
* AppStream (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* AWSMarketplaceCommerceAnalytics (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Batch (3.3.0.1)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudFormation (3.3.3.5)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudFront (3.3.2.2)
	* Documentation update to include cross-reference links to service REST api docs.
* CloudWatchLogs (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* CodeBuild (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* CodePipeline (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* CognitoIdentity (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* ConfigService (3.3.3.3)
	* Documentation update to include cross-reference links to service REST api docs.
* DatabaseMigrationService (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* DirectoryService (3.3.1.5)
	* Documentation update to include cross-reference links to service REST api docs.
* EC2 (3.3.4.4)
	* Documentation update to include cross-reference links to service REST api docs.
* ECR (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* ElasticBeanstalk (3.3.3.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Health (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* IdentityManagement (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Inspector (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* KeyManagementService (3.3.1.8)
	* Documentation update to include cross-reference links to service REST api docs.
* KinesisFirehose (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Lambda (3.3.2.4)
	* Documentation update to include cross-reference links to service REST api docs.
* Lightsail (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* Polly (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* RDS (3.3.4.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Route53 (3.3.3.1)
	* Documentation update to include cross-reference links to service REST api docs.
* SecurityToken (3.3.0.8)
	* Documentation update to include cross-reference links to service REST api docs.
* Shield (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* SimpleSystemsManagement (3.3.2.1)
	* Documentation update to include cross-reference links to service REST api docs.
* Snowball (3.3.1.4)
	* Documentation update to include cross-reference links to service REST api docs.
* SQS (3.3.1.6)
	* Documentation update to include cross-reference links to service REST api docs.
* StepFunctions (3.3.0.4)
	* Documentation update to include cross-reference links to service REST api docs.
* StorageGateway (3.3.1.1)
	* Documentation update to include cross-reference links to service REST api docs.
* WAFRegional (3.3.0.2)
	* Documentation update to include cross-reference links to service REST api docs.

### 3.3.35.0 (2016-12-22 23:22 UTC)
* APIGateway (3.3.4.0)
	* Amazon API Gateway is adding support for generating SDKs in more languages. This update introduces two new operations used to dynamically discover these SDK types and what configuration each type accepts.
* DirectoryService (3.3.1.4)
	* Documentation update.
* ElasticBeanstalk (3.3.3.0)
	* adding a new feature for managing ApplicationVersion Lifecycle. To support this feature we have added one new API and modified two existing API.
* IdentityManagement (3.3.1.0)
	* Adds service-specific credentials to IAM service to make it easier to onboard CodeCommit customers. These are username/password credentials that work with a single service.
* KeyManagementService (3.3.1.7)
	* Documentation update.

### 3.3.34.0 (2016-12-21 23:44 UTC)
* ECR (3.3.2.0)
	* API Update for ECR : Amazon ECR now implements Docker Image Manifest V2, Schema 2 providing the ability to use multiple tags per image, support for storing Windows container images, and compatibility with the Open Container Initiative (OCI) image format. With this update, customers can also add tags to an image via PutImage and delete tags using BatchDeleteImage.
* RDS (3.3.4.0)
	* API Update for RDS : added support for cross region encrypted snapshot copying (CopyDBSnapshot)

### 3.3.33.0 (2016-12-21 06:01 UTC)
* KinesisFirehose (3.3.1.0)
	* API Update for KinesisFirehose:  Processing feature enables users to process and modify records before Amazon Firehose delivers them to destinations.
* Route53 (3.3.3.0)
	* API Update for Route53 : enum updates for eu-west-2 and ca-central-1
* StorageGateway (3.3.1.0)
	* API Update for StorageGateway: File gateway is a new mode in the AWS Storage Gateway that support a file interface into S3, alongside the current block-based volume and VTL storage. File gateway combines a service and virtual software appliance, enabling you to store and retrieve objects in Amazon S3 using industry standard file protocols such as NFS. The software appliance, or gateway, is deployed into your on-premises environment as a virtual machine (VM) running on VMware ESXi. The gateway provides access to objects in S3 as files on a Network File System (NFS) mount point.

### 3.3.32.0 (2016-12-20 00:59 UTC)
* ApplicationDiscoveryService (3.3.1.0)
	* API Update for ApplicationDiscoveryService : Adds new APIs to group discovered servers into Applications with get summary and neighbors. Includes additional filters for ListConfigurations and DescribeAgents API.
* CloudFormation (3.3.3.4)
	* Doc update for Cloudformation
* CognitoIdentity (3.3.1.0)
	* Added Groups to Cognito user pools. Developers can perform CRUD operations on groups, add and remove users from groups, list users in groups, etc; Added fine-grained role-based access control for Cognito identity pools. Developers can configure an identity pool to get the IAM role from an authenticated user's token, or they can configure rules that will map a user to a different role.
* Inspector (3.3.0.7)
	* Doc update for Inspector
* SQS (3.3.1.5)
	* Doc update for SQS

### 3.3.31.0 (2016-12-15 23:20 UTC)
* AWSMarketplaceCommerceAnalytics (3.3.1.0)
	* Add new enum to DataSetType: sales_compensation_billed_revenue
* Batch (3.3.0.0)
	* AWS Batch is a batch computing service that lets customers define queues and compute environments and then submit work as batch jobs.
* CloudWatchLogs (3.3.2.0)
	* Add support for associating LogGroups with AWSTagris tags.
* DatabaseMigrationService (3.3.1.0)
	* Adds support for SSL enabled Oracle endpoints and task modification.
* ElasticBeanstalk (3.3.2.3)
	* Doc-only Update for Elastic Beanstalk: CodeBuild.
* Polly (3.3.0.3)
	* Fix to send X-Amz-Security-Token header in the casing currently expected by the service.
* RDS (3.3.3.1)
	* Doc-only Update for RDS: New versions available in CreateDBInstance
* S3 (3.3.5.2)
	* Fixed presigned url helper to switch to non-AWS Signature v4, if region allows, if requested expiry date is greater than the maximum permitted range for the signature algorithm.
* SecurityToken (3.3.0.7)
	* Documentation update.
* SimpleSystemsManagement (3.3.2.0)
	* Added support for the new Patch Baseline and Patch Compliance APIs.
* Core 3.3.7.0
	* Added region endpoint constants for new EU West (London) region.
Added new region endpoints for Amazon Cognito.
Omit x-amzn-trace-id during signing.
	* all services packages updated to require new core

### 3.3.30.1 (2016-12-13 03:39 UTC)
* IotData (3.3.0.6)
	* Updated to use new Core, version 3.3.6.1
	* Fix issue handling $ character in topics.
* Core 3.3.6.1
	* Fix issue with $ being encoded in requests.

### 3.3.30.0 (2016-12-09 00:42 UTC)
* CloudFront (3.3.2.0)
	* API Update for CloudFront : add lambda function associations to cache behaviors
* CodePipeline (3.3.0.6)
	* Doc update for CodePipeline
* RDS (3.3.3.0)
	* API Upate for RDS : add cluster create time to DBCluster APIs
* WAFRegional (3.3.0.0)
	* New Service WAFRegional : With this new feature, customers can use AWS WAF directly on Application Load Balancers in a VPC within available regions to protect their websites and web services from malicious attacks such as SQL injection, Cross Site Scripting, bad bots, etc.
* Core 3.3.6.0
	* New region launch ca-central-1
	* all services packages updated to require new core

### 3.3.29.0 (2016-12-08 01:18 UTC)
* ConfigService (3.3.3.0)
	* API Update for ConfigService : AWS Config supporting Redshift Cluster, ClusterParameterGroup, ClusterSecurityGroup, ClusterSnapshot, ClusterSubnetGroup, and EventSubscription resource types for all customers
* S3 (3.3.5.0)
	* S3 now defaults to Sigv4 on BCL; fixed versionId not being marshalled correctly in tagging operations
* SQS (3.3.1.2)
	* Doc update for SQS

### 3.3.28.1 (2016-12-07 10:12 UTC)
* Core 3.3.5.1
	* Fixed issue getting environment info running under Lambda
	* all services packages updated to require new core

### 3.3.28.0 (2016-12-06 21:33 UTC)
* ConfigService (3.3.2.0)
	* API Update for ConfigService : AWS Config is increasing the number of configrules for all accounts from 25 to 50
* EC2 (3.3.4.0)
	* API Update for EC2 :  addedT2.xlarge, T2.2xlarge, and R4 instance type.
* SecurityToken (3.3.0.4)
	* Doc update for SecurityTokenService.

### 3.3.27.0 (2016-12-01 23:03 UTC)
* APIGateway (3.3.3.0)
	* You can now publish your APIs on Amazon API Gateway as products on the AWS Marketplace. Use the SDK to associate your APIs on API Gateway with Marketplace Product Codes. API Gateway will then send metering data to the Marketplace Metering Service on your behalf. Also, API Gateway now supports documenting your API.
* AppStream (3.3.0.0)
	* AppStream is a fully managed desktop application streaming service that provides users instant access to their apps from a web browser.
* CodeBuild (3.3.0.0)
	* AWS CodeBuild is a fully-managed build service in the cloud. CodeBuild compiles source code, runs tests, and produces packages that are ready to deploy. CodeBuild eliminates the need to provision, manage, and scale your own build servers. CodeBuild scales continuously and processes multiple builds concurrently, so your builds are never waiting in a queue. You can get started quickly with CodeBuild’s prepackaged build environments, or you can use custom build environments to use your own build tools. With CodeBuild, you only pay by the minute.
* DirectConnect (3.3.2.0)
	* IPv6 support
* EC2 (3.3.3.0)
	* IPv6 Support for EC2 and new F1 Instance types.
* ElasticBeanstalk (3.3.2.0)
	* Integrate AWS codebuild into the service by introducing a new API parameter BuildConfiguration
* Health (3.3.0.0)
	* When your business is counting on the performance of your cloud solutions, having relevant and timely insights into events impacting your AWS resources is essential. The AWS Health API serves as the primary source for you to receive personalized information related to your AWS infrastructure, guiding your through scheduled changes, and accelerating the troubleshooting of issues impacting your AWS resources and accounts. At launch, the APIs will be available to Business and Enterprise Support customers.
* Lambda (3.3.2.0)
	* New GetAccountSettings API, dotnetcore 1.0 runtime support, new DeadLetterConfig API, and event source mappings with Kinesis streams
* OpsWorksCM (3.3.0.0)
	* AWS OpsWorks Managed Chef gives customers a single tenant Chef Automate server. The Chef Automate server is fully managed by AWS and supports automatic backup, restore and upgrade operations.
* Pinpoint (3.3.0.0)
	* Amazon Pinpoint makes it easy to run targeted campaigns to improve user engagement. Pinpoint helps you understand your users behavior, define who to target, what messages to send, when to deliver them, and tracks the results of the campaign.
* Shield (3.3.0.0)
	* AWS Shield is a managed Distributed Denial of Service (DDoS) protection for web applications running on AWS.
* SimpleSystemsManagement (3.3.1.0)
	* Amazon EC2 Systems Manager is a flexible and easy to use management service that enables enterprises to securely manage and administer their workloads running on-premises or in the AWS cloud, using a single unified experience. These tasks include collecting system inventory, maintaining consistent state, ad hoc remote execution, automating imaging creation, applying OS patches, and managing configuration parameters.
* StepFunctions (3.3.0.0)
	* AWS StepFunctions allows developers to build cloud applications with breakthrough reliability using state machines.
* XRay (3.3.0.0)
	* AWS X-Ray helps developers analyze and debug distributed applications. With X-Ray, you can understand how your application and its underlying services are performing to identify and troubleshoot the root cause of performance issues and errors.

### 3.3.26.0 (2016-11-30 19:09 UTC)
* Lightsail (3.3.0.0)
	* New service Lightsail : a simplified VM creation and management service.
* Polly (3.3.0.0)
	* New service Polly : Amazon Polly service turns text into lifelike speech, making it easy to develop applications that use high-quality speech to increase engagement and accessibility
* Rekognition (3.3.0.0)
	* New service Rekognition : Rekognition is a deep-learning based service to search, verify and organize images. With Rekognition, you can detect objects, scenes, and faces in images. You can also search and compare faces.
* Snowball (3.3.1.0)
	* API Update for Snowball : this release of AWS Snowball introduces a new job type, new APIs, and the new AWS Snowball Edge device to support local compute and storage use cases.

### 3.3.25.0 (2016-11-29 17:47 UTC)
* S3 (3.3.4.0)
	* API Update for S3 : new operations for object tagging, new API for configuring Storage Insights, and new Filter Rule to LifeCycleConfiguration

### 3.3.24.0 (2016-11-23 02:51 UTC)
* CloudFormation (3.3.3.0)
	* API Update for CloudFormation : new API ListImports
* Glacier (3.3.1.0)
	* API Update for Glacier : allow customers to retrieve their data with different tiers
* Route53 (3.3.2.1)
	* Doc updates for Route53
* S3 (3.3.3.0)
	* API Update for S3 : Enable customers to specify different restore tiers when accessing their data.

### 3.3.23.0 (2016-11-22 03:06 UTC)
* CloudTrail (3.3.1.0)
	* API Update for CloudTrail : supports configuring your trail with event selector
* ECS (3.3.1.0)
	* APIUpdate for ECS : the new API will include a new field named "version" in API responses relating to tasks and container instances.
* S3 (3.3.2.0)
	* API Update for S3 : Get-Partnumber and Request-Payer support

### 3.3.22.0 (2016-11-19 00:10 UTC)
* ApplicationAutoScaling (3.3.1.0)
	* API Update for ApplicationAutoScaling : support for a new target resource (EMR Instance Groups) as a scalable target
* DynamoDBv2 (3.3.1.0)
	* DynamoDB Util's Document.FromJson() should supported unsigned types.
* ElasticMapReduce (3.3.2.0)
	* API Update for ElasticMapReduce : automatic Scaling of EMR clusters based on metrics
* ElasticTranscoder (3.3.1.0)
	* API Update for ElasticTranscoder : support for multiple media input files that can be stitched together.
* GameLift (3.3.2.0)
	* API Update for GameLift : provide the ability to remote access into GameLift managed servers.
* Lambda (3.3.1.0)
	* API Update for Lambda : adds support for Environment variables.

### 3.3.21.0 (2016-11-17 23:34 UTC)
* APIGateway (3.3.2.0)
	* API Update for APIGateway : adding custom encoding feature.
* AWSMarketplaceMetering (3.3.1.0)
	* API Update for AWSMarketplaceMetering : allow third parties to send metering records.
* CloudWatch (3.3.1.0)
	* API Update for Cloudwatch: add support for percentile statistic (pN) to metrics and alarms
* SQS (3.3.1.0)
	* API Update for SQS : new FIFO message queue.

### 3.3.20.0 (2016-11-17 00:29 UTC)
* Route53 (3.3.2.0)
	* Adds support for cross account VPC association.
* ServiceCatalog (3.3.2.0)
	* This release enables Service Catalog users to perform administrator operations via API.

### 3.3.19.0 (2016-11-16 00:25 UTC)
* DirectoryService (3.3.1.0)
	* API Update for DirectoryService :  Adding SchemaExtensions  
* ElastiCache (3.3.2.0)
	* API Update for ElastiCache : Additional parameter to 2 create apis to provide an auth Token for Redis
* Kinesis (3.3.1.0)
	* API Update for Kinesis: Describe shard limit, open shard count and stream creation timestamp

### 3.3.18.0 (2016-11-15 03:37 UTC)
* CognitoIdentityProvider (3.3.2.0)
	* CognitoIdentityProvider: Adds schema attributes to CreateUserPool. 
* Core 3.3.5.0
	* Fixed nuspec files to correctly load binaries on Xamarin platforms; EndpointProvider now handles non-standard regions.
	* all services packages updated to require new core

### 3.3.17.0 (2016-11-11 00:13 UTC)
* CloudFormation (3.3.2.2)
	* Doc update.
* CloudWatchLogs (3.3.1.0)
	* Amazon CloudWatch Metrics to Logs is a capability that helps pivot from your logs-extracted metrics directly to the corresponding logs.
* EC2 (3.3.2.2)
	* Updated to use new Core, version 3.3.4.1
	* generated changes from idempotency trait support
* ServiceCatalog (3.3.1.2)
	* Updated to use new Core, version 3.3.4.1
	* generated changes from idempotency trait support
* Core 3.3.4.1
	* updated generator to handle idempotency trait

### 3.3.16.0 (2016-11-04 01:26 UTC)
* DirectConnect (3.3.1.0)
	* Updated to use new Core, version 3.3.4.0
	*  AWS Direct Connect provides three new APIs to support basic tagging on Direct Connect resources.
* SimpleEmail (3.3.1.0)
	* Updated to use new Core, version 3.3.4.0
	* API Update for SES: Amazon Simple Email Service (Amazon SES) now enables you to track your bounce, complaint, delivery, sent, and rejected email metrics with fine-grained granularity.
* Core 3.3.4.0
	* RetryThrottling feature
	* Added WebProxy support for PCL
	* Added Support for environmental credentials
	* all services packages updated to require new core

### 3.3.15.0 (2016-11-03 04:41 UTC)
* CloudFormation (3.3.2.0)
	*  Adding ResourcesToSkip parameter to ContinueUpdateRollback API, adding support for ListExports, new ChangeSet types and Transforms

### 3.3.14.1 (2016-10-25 23:25 UTC)
* AutoScaling (3.3.0.2)
	* Doc Update for Autoscaling and ELB
* ElasticLoadBalancingV2 (3.3.0.2)
	* Doc Update for  ELB

### 3.3.14.0 (2016-10-25 03:31 UTC)
* ECS (3.3.0.2)
	* Doc only update
* ServerMigrationService (3.3.0.0)
	*  AWS Server Migration Service (SMS) is an agentless service which makes it easier and faster for you to migrate thousands of on-premises workloads to AWS.

### 3.3.13.0 (2016-10-21 04:40 UTC)
* Budgets (3.3.0.0)
	* Updated to use new Core, version 3.3.3.0
	* Release of AWS Budgets
* WAF (3.3.1.2)
	* doc update
* Core 3.3.3.0
	* decimal type support for aws budgets

### 3.3.12.0 (2016-10-20 00:47 UTC)
* EC2 (3.3.2.0)
	* Added support for retrieving the new Windows Server 2016 images in ImageUtilities helper class.

### 3.3.11.0 (2016-10-18 22:51 UTC)
* CloudFront (3.3.1.0)
	* Added ability to use Amazon CloudFront to deliver your content both via IPv6 and IPv4 using HTTP/HTTPS
* ConfigService (3.3.1.0)
	* enum updates to support S3 bucket resource type
* IoT (3.3.1.0)
	* added DynamoActionV2 action to IoT Rules Engine
* KinesisAnalytics (3.3.0.2)
	* Model update to add rawInputRecords member in UnableToDetectSchemaException
* RDS (3.3.2.0)
	* Amazon Aurora integrates with other AWS services to allow you to extend your Aurora DB cluster to utilize other capabilities in the AWS cloud. Permission to access other AWS services is granted by creating an IAM role with the necessary permissions, and then associating the role with your DB cluster.
* S3 (3.3.1.0)
	* Support for simultaneous use of dualstack and accelerate feaftures.
* Core 3.3.2.1
	* Fix bug with persistence manager not correctly overwriting the file on persistence; Fixed incorrect types being used when constructing JsonData

### 3.3.10.0 (2016-10-17 20:12 UTC)
* Route53 (3.3.1.0)
	* Updated to use new Core, version 3.3.2.0
	* New enum to support new regions and doc updates.
* S3 (3.3.0.4)
	* Updated to use new Core, version 3.3.2.0
	* Enum changes to support new region
* Core 3.3.2.0
	* Core changes to support new us-east-2 region; fixed a bug where LitJson raises overflow/underflow exception on valid input.

### 3.3.9.0 (2016-10-13 19:57 UTC)
* CertificateManager (3.3.1.0)
	*  This change allows users to import third-party SSL/TLS certificates into ACM
* ElasticBeanstalk (3.3.1.0)
	* Support Pagination for DescribeApplicationVersions API
* GameLift (3.3.1.0)
	* New APIs to protect game developer resource (builds, alias, fleets, instances, game sessions and player sessions) against abuse.
* S3 (3.3.0.3)
	* Updated to use new Core, version 3.3.1.1
	* Requires latest Core to pick up LruCache bug fix.
* ServiceCatalog (3.3.1.0)
	* Updated to use new Core, version 3.3.1.1
	* New regions
* Core 3.3.1.1
	* Several bug fixes to LruCache including https://github.com/aws/aws-sdk-net/pull/467; Doc updates; and endpoints.json update to support new Service Catalog regions.

### 3.3.8.0 (2016-10-12 17:43 UTC)
* ECR (3.3.1.0)
	* DescribeImages is a new api used to expose image metadata which today includes image size and image creation timestamp
* ElastiCache (3.3.1.0)
	* Elasticache is launching a new major engine release of Redis, 3.2 (providing stability updates and new command sets over 2.8), as well as ElasticSupport for enabling Redis Cluster in 3.2, which provides support for multiple node groups to horizontally scale data, as well as superior engine failover capabilities.

### 3.3.7.0 (2016-10-12 08:32 UTC)
* CognitoSync (3.3.1.0)
	* Update SQLite dependencies for support of Android N
* MobileAnalytics (3.3.1.0)
	* Update SQLite dependencies for support of Android N

### 3.3.6.0 (2016-10-11 19:26 UTC)
* Core 3.3.1.0
	* Close HttpWebRequest's response stream on WebExceptions (https://github.com/aws/aws-sdk-net/pull/449).
	* Updated generation of .nuspec files to enable Nuget packages to support the "uap" targetFramework.
	* Added support for configuring bypass lists and bypass-on-local mode for web proxies in the BCL and Unity platforms.
	* Fixed issue in RegionEndpointProviderV3 preventing use of regions unknown at the time of compilation.
	* Fixed LitJson not serializig signed types correctly.
	* all services packages updated to require new core

### 3.3.5.0 (2016-10-07 03:45 UTC)
* CognitoIdentityProvider (3.3.1.0)
	* Added new operation "AdminCreateUser" that creates a new user in the specified user pool and sends a welcome message via email or phone (SMS).
* DeviceFarm (3.3.0.1)
	* general doc update
* KeyManagementService (3.3.1.0)
	* support for InvalidMarkerException in ListKeys API
* OpsWorks (3.3.0.1)
	* general doc update
* WAF (3.3.1.0)
	*  In WAF model, the enum for IPSetDescriptorType, we add IPV6 in addition to IPV4. This change will add a new option when customers call some APIs, and also the API will no longer assume the IPSetDescriptorType is in IPV4
* Core 3.3.0.3
	* endpoints.json file update

### 3.3.4.0 (2016-09-29 23:30 UTC)
* EC2 (3.3.1.0)
	* Support for new EC2 instance type: m4.16xlarge Support for new EC2 P2 and X1 instances. Adding support for EC2 Convertible RIs and the EC2 RI regional benefit.
* Core 3.3.0.2
	* Add back the ap-south1 region constant

### 3.3.3.0 (2016-09-28 02:53 UTC)
* CloudFormation (3.3.1.0)
	* Added RoleARN parameter to mutating APIs
* CodePipeline (3.3.0.1)
	* Service documentation update.
* ElasticFileSystem (3.3.0.1)
	* Service documentation update.
* KeyManagementService (3.3.0.1)
	* Update documentation to clarify the inputs to KMS Generate APIs
* Core 3.3.0.1
	* Added missing RoleArn property to URIBasedRefreshingCredentialHelper's SecurityCredentials class.

### 3.3.2.0 (2016-09-22 20:34 UTC)
* APIGateway (3.3.1.0)
	* Simple Proxy support includes three new features: new greedy path formats (no API change), new pseudo-HTTP method (ANY), and two new integration types (AWS_PROXY, HTTP_PROXY).
* AWSSDK.Extensions.NETCore.Setup (3.3.0.1)
	* Pull request 456, fix issue with setting RegionEndpoint property overriding a previous set ServiceURL

### 3.3.1.0 (2016-09-21 21:17 UTC)
* CodeDeploy (3.3.1.0)
	* AWS CodeDeploy now integrates with Amazon CloudWatch alarms, making it possible to stop a deployment if there is a change in the state of a specified alarm for a number of consecutive periods, as specified in the alarm threshold. AWS CodeDeploy also now supports automatically rolling back a deployment if certain conditions are met, such as a deployment failure or an activated alarm.
* ElasticMapReduce (3.3.1.0)
	* Added support for Security Configurations which can be used to enable encryption at-rest and in-transit for certain applications on Amazon EMR.
* RDS (3.3.1.0)
	* Provide local time zone support for AWS RDS SqlServer database instances.
* Redshift (3.3.1.0)
	* This release of Amazon Redshift introduces Enhanced VPC Routing. When you use Amazon Redshift Enhanced VPC Routing, Amazon Redshift forces all COPY and UNLOAD traffic between your cluster and your data repositories through your Amazon VPC.
* S3 (3.3.0.1)
	* Fix null reference exception when validation error occurrs in STS.

### 3.3.0.0 (2016-09-19 17:15 UTC)
* [GA release](http://blogs.aws.amazon.com/net/post/Tx3O6TT4NKFM0FU/General-Availability-for-NET-Core-Support-in-the-AWS-SDK-for-NET) of support for .NET Core in the AWS SDK for .NET 

### 3.1.101.0 (2016-09-16 00:49 UTC)
* IoT (3.1.9.0)
	* Changes in RegisterCertificate API & Adding a new field "cannedAcl" in S3 action
* RDS (3.1.19.0)
	* Aurora cluster reader end-point. Customers have requested we provide them an endpoint that gives access to their cluster readers. We are adding a single field to the output of the DescribeDbCluster operation, namely "ReaderEndpoint" to serve this purpose.

### 3.1.100.0 (2016-09-13 22:23 UTC)
* EC2 (3.1.20.2)
	* Minor documentation update.
* S3 (3.1.10.0)
	* Updated the Amazon.S3.Model.S3Object type to contain a new property, BucketName. This is the name of the bucket containing the object.
* ServiceCatalog (3.1.1.0)
	* Adding an optional parameter to 2 existing APIs.

### 3.1.99.0 (2016-09-08 21:56 UTC)
* AWSSupport (3.1.0.10)
	* Documentation update.
* CloudFront (3.1.7.0)
	* Adds HTTP2 support for Amazon CloudFront distributions.This includes a new API version, 2016-09-07.
* SimpleNotificationService (3.1.2.1)
	* Documentation update.

### 3.1.98.0 (2016-09-06 21:59 UTC)
* CodePipeline (3.1.5.0)
	* Incorporated API updates to correct naming of members in types used in the recently published view changes APIs. Please note these are breaking changes in the model shapes.
* EC2 (3.1.20.1)
	* Documentation updates.
* ECR (3.1.2.1)
	* Documentation updates.
* ECS (3.1.8.1)
	* Documentation updates.
* RDS (3.1.18.0)
	* New API for RDS: DescribeSourceRegions. The DescribeSourceRegions API provides a list of all the source region names and endpoints for any region. Source regions are the regions where current region can get a replica or copy a snapshot from.
* SimpleNotificationService (3.1.2.0)
	* Declaring AuthorizationErrorException on the 5 new SNS-SMS APIs.

### 3.1.97.0 (2016-09-02 00:53 UTC)
* ApplicationAutoScaling (3.1.1.0)
	* ApplicationAutoScaling adds support for automatically scaling an Amazon EC2 Spot fleet in order to manage application availability and costs during changes in demand based on conditions you define.
* CognitoIdentityProvider (3.1.2.0)
	* Added support for bulk import of users.
* ConfigService (3.1.7.0)
	* ResourceType Enum Update for AWS Config: Supporting a application loadbalancer resource type in AWS Config 
* GameLift (3.1.3.0)
	* Customers can use Linux in addition to Windows EC2 instances.
* RDS (3.1.17.0)
	* We currently allow customers to add options to a rds option group that are mutually exclusive. We want to avoid that while validating the request to add an option to the option group. As part of this effort we are modifying the describe-option-group-options api response to include information about options that conflict with each other.

### 3.1.96.0 (2016-08-30 21:02 UTC)
* AutoScaling (3.1.4.1)
	* Documentation update.
* CloudFront (3.1.6.0)
	* CloudFront is adding a Querystring Whitelist Option. Customers will be able to choose to forward certain querystring keys instead of a.) all of them or b.) none of them.
* CodePipeline (3.1.4.0)
	* CodePiepline has introduced a new feature to return pipeline execution details. Execution details consists of source revisions that are running in the pipeline. Customers will be able to tell what source revisions that are running through the stages in pipeline by fetching execution details of each stage.
* Route53 (3.1.6.0)
	* With this release, Route 53 will support the following new features: support for the NAPTR DNS record type, a new TestDNSAnswer API which enables customers to send a test query against a specific name server using spoofed delegation nameserver, resolver, and ECS IPs, and support metric-based health check in ap-south-1 region.
* SimpleSystemsManagement (3.1.4.2)
	* Documentation update.
* Core 3.1.11.0
	* Fixed issue with UnityWebRequest for Unity 5.4.
Deprecated ClientConfig.ReadEntireResponse property.



### 3.1.95.0 (2016-08-24 00:11 UTC)
* OpsWorks (3.1.3.5)
	* Documentation updates for expanded region support.
* RDS (3.1.16.0)
	* Addition of resource ARNs to Describe APIs.

### 3.1.94.0 (2016-08-19 02:24 UTC)
* EC2 (3.1.20.0)
	* Schema Update for Dedicated Host Reservations and API Update for EC2-SpotFleet: Adding new parameters to DescribeSpotFleerRequest API
* IdentityManagement (3.1.4.9)
	* Doc only update
* KeyManagementService (3.1.3.1)
	* Updating the version numbers
* WorkSpaces (3.1.3.0)
	* New APIs to support the launch and management of WorkSpaces that are paid for and used by the hour.

### 3.1.93.0 (2016-08-17 01:52 UTC)
* APIGateway (3.1.7.0)
	* Amazon API Gateway now supports API usage plans. You can now easily define plans for 3rd party developers by associating them with individual API keys. This allows you to configure which APIs the caller can access as well as define throttling and request quota limits. You can also extract utilization data on a per-API key basis to analyze API usage and generate billing documents. Usage plans allows you to easily manage and monetize your APIs for your API-based business.
* CognitoSync (3.1.2.0)
	* Merged GitHub PR 409: Improve DataConflictException handling in case of partial local modification (https://github.com/aws/aws-sdk-net/pull/409)
* ECS (3.1.8.0)
	* Regenerating from latest service model ecs-2014-11-13.normal.json

### 3.1.92.0 (2016-08-11 07:53 UTC)
* AutoScaling (3.1.4.0)
	* New API for AutoScaling - ELB L7 integration.
* ECS (3.1.7.0)
	* Amazon EC2 Container services support Application Load Balancer target groups to enable dynamic ports and path-based routing.
* ElasticLoadBalancing (3.1.1.0)
	* Documentation and other minor changes to the classic Elastic Load Balancing model to support the launch of Elastic Load Balancing V2 API which can be found in the Amazon.ElasticLoadBalancingV2 namespace.
* ElasticLoadBalancingV2 (3.1.0.0)
	* Application load balancers are a new load balancer that is now supported by the Elastic Load Balancing service. Application load balancers support HTTP/2, WebSockets, routing based on URL path, and routing to multiple ports on a single instance.
* KeyManagementService (3.1.3.0)
	* New import key feature lets you import keys from your own key management infrastructure to KMS for greater control over generation and storage of keys and meeting compliance requirements of sensitive workloads.
* KinesisAnalytics (3.1.0.0)
	* Added support for Amazon Kinesis Analytics, a fully managed service for continuously querying streaming data using standard SQL. With Kinesis Analytics, you can write standard SQL queries on streaming data and gain actionable insights in real-time, without having to learn any new programming skills. The service allows you to build applications that continuously read data from streaming data sources, process that data using standard SQL, and send the processed data to up to four destinations of your choice. Kinesis Analytics enables you to generate time-series analytics, feed a real-time dashboard, create real-time alarms and notifications, and much more.
* S3 (3.1.9.0)
	* Updated to use new Core, version 3.1.10.0
	* Added support for requesting dualstack (ipv6) endpoints using a new UseDualstackEndpoint property on the service configuration class. Note that not all regions currently support dualstack endpoints - you should consult S3 documentation to verify a dualstack endpoint is available for the region you intend to use before setting this switch.
* Snowball (3.1.0.0)
	* Added support for the Snowball job management API.
* Core 3.1.10.0
	* Added a new flag, UseDualstackEndpoint, to the base configuration class for all services. Currently this flag is for use with Amazon S3 only. Other services will add dualstack (ipv6) endpoints in the future.

### 3.1.91.0 (2016-08-10 00:12 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.3.0)
	* In this release, we added a new API, StartSupportDataExport, to the AWS Marketplace Commerce Analytics Service. StartSupportDataExport returns static test data only at this time. The AWS Marketplace Commerce Analytics Service allows AWS Marketplace Sellers to programmatically access product and customer data on AWS Marketplace. For more information, contact aws-marketplace-seller-ops@amazon.com.
* CloudFront (3.1.5.0)
	* Amazon CloudFront now supports tagging for Web and Streaming distributions. Tags make it easier for you to allocate costs and optimize spending by categorizing and grouping AWS resources.
* ECR (3.1.2.0)
	* Adds filtering of ListImages requests based on whether an image is tagged or untagged
* S3 (3.1.8.3)
	* Minor update to PutBucket operation

### 3.1.90.1 (2016-08-09 00:44 UTC)
* Core 3.1.9.2
	* Fix issue with LitJSON not properly deserializing dictionaries
	* all services packages updated to require new core

### 3.1.90.0 (2016-08-04 23:43 UTC)
* CognitoIdentityProvider (3.1.1.0)
	* Adding Auth Support for Cognito User Pools 
* GameLift (3.1.2.0)
	* Added support for GameSession Search API
* Lambda (3.1.4.6)
	* Doc only update
* RDS (3.1.15.0)
	* S3 Snapshot Ingestion and MoveToVpc feature added

### 3.1.89.0 (2016-08-02 21:00 UTC)
* ApplicationAutoScaling (3.1.0.5)
	* Documentation update reflecting scalable target limit increase.
* AWSMarketplaceMetering (3.1.0.5)
	* Add path shortening for new discovery service
* CloudWatch (3.1.0.10)
	* Documentation update for MetricDatum.
* CloudWatchLogs (3.1.3.0)
	* Documentation update. Adding an optional parameter, DefaultValue, to PutMetricFilterRequest.
* DirectoryService (3.1.5.1)
	* Documentation update.
* ElasticMapReduce (3.1.6.0)
	* API Update for EMR: Enhanced Debugging
* IoT (3.1.8.0)
	* Regenerating from latest service model iot-2015-05-28.normal.json
* MachineLearning (3.1.3.0)
	* Added the timestamps StartedAt, FinishedAt, and ComputeTime to the following API responses:DescribeBatchPredictionsOutput DescribeDataSourcesOutput DescribeEvaluationsOutput DescribeMLModelsOutput GetBatchPredictionsOutput GetDataSourcesOutput GetEvaluationsOutput GetMLModelsOutput. Added TotalRecordCount and InvalidRecordCount to the following API responses: DescribeBatchPredictionsOutput GetBatchPredictionsOutput.
* RDS (3.1.14.0)
	* Support for License model and versioning of option groups.
* Route53Domains (3.1.2.0)
	*  Adds new APIs to renew domains for a specified duration, get domain suggestions, and view billing.

### 3.1.88.0 (2016-07-29 02:27 UTC)
* APIGateway (3.1.6.0)
	* Added support for Cognito User Pools Auth 
* DirectoryService (3.1.5.0)
	* New APIs for Microsoft AD to manage routing 
* EC2 (3.1.19.0)
	* Updated for DNS for VPC Peering 
* Elasticsearch (3.1.1.0)
	* Amazon Elasticsearch Service now supports elasticsearch version 2.3. Version 2.3 offers improved performance, memory management, and security. It also offers several new features including: pipeline aggregations to perform advanced analytics like moving averages and derivatives, and enhancements to geospatial queries
* SecurityToken (3.1.4.4)
	* Doc only update
* SimpleEmail (3.1.4.3)
	* Doc update

### 3.1.87.0 (2016-07-26 23:19 UTC)
* CognitoSync (3.1.1.6)
	* Github pull request 400 fixing an issue when deleting a merged dataset after the deletion is complete.
* IoT (3.1.7.0)
	* This update adds support for thing types. Thing types are entities that store a description of common features of Things that are of the same logical type.
* MobileAnalytics (3.1.1.11)
	*     Github pull request 417 making the event parsing more robust.

### 3.1.86.0 (2016-07-21 23:04 UTC)
* CertificateManager (3.1.4.0)
	* Add reason for failure when describing certificates.
* CloudFormation (3.1.6.0)
	* Added support for specifying IAM capabilities for stacks.
* ConfigService (3.1.6.0)
	* Adding support for ACM and RDS resource types.
Two new features (Hybrid Rules & Forced Evaluation).
* ECS (3.1.6.1)
	* Documentation update.
* ElasticTranscoder (3.1.0.10)
	* Updated documentation for WAV file output format support.
* Lambda (3.1.4.5)
	* Minor documentation update.
* Core 3.1.9.1
	* Fixed issue where hyphens were automatically stripped from access policies during unmarshall.

### 3.1.85.0 (2016-07-19 21:11 UTC)
* DeviceFarm (3.1.7.0)
	* Add support for managing remote access sessions.
* SimpleSystemsManagement (3.1.4.0)
	* Added notification support,allowing customers to be notified when a command reaches a terminated status.

### 3.1.84.0 (2016-07-13 22:00 UTC)
* DatabaseMigrationService (3.1.2.0)
	* API updates to enable SSL-enabled endpoints.
* ECS (3.1.6.0)
	* Added support for specifying an IAM role ARN for tasks.
* RDS (3.1.13.0)
	* API Update for RDS Aurora: new parameter TargetDBInstanceIdentifier of FailoverDBCluster API. 
API Update for RDS Aurora: New method CopyDBClusterParameterGroup.
* Core 3.1.9.0
	* Updated to support ECS container credentials.
	* all services packages updated to require new core

### 3.1.83.0 (2016-07-07 23:26 UTC)
* ConfigService (3.1.5.0)
	* API Update for AWS Config: DeleteConfigurationRecorder API.
* DirectoryService (3.1.4.0)
	* API Update for AWS Directory Service: Tagging APIs (Add, Remove and List).
* OpsWorks (3.1.3.2)
	* Documentation update.
* ServiceCatalog (3.1.0.0)
	* Added support for AWS Service Catalog. This service allows organizations to create and manage catalogs of IT services that are approved for use on AWS.

### 3.1.82.0 (2016-07-05 19:32 UTC)
* CodePipeline (3.1.3.0)
	* Updates CodePipeline API to support manual approvals.
* ElasticFileSystem (3.1.2.1)
	* Documentation update.
* IdentityManagement (3.1.4.6)
	* Documentation update.

### 3.1.81.0 (2016-06-30 20:27 UTC)
* DatabaseMigrationService (3.1.1.0)
	* Allow the ability to specify VpcSecurityGroupId for the replication instance
* SimpleSystemsManagement (3.1.3.0)
	* Amazon EC2 Run Command now works with any instance or virtual machine outside of AWS, including your own data centers or other clouds.
* Core 3.1.8.1
	* Pull request 412, overload to optionally strip hyphen from the ID in the Principal object

### 3.1.80.0 (2016-06-28 22:44 UTC)
* CloudWatchEvents (3.1.2.0)
	* Update for new BOM region
* EC2 (3.1.18.0)
	* Enable ENA supported instances
* ElasticFileSystem (3.1.2.0)
	* Added support for PerformanceMode property
* GameLift (3.1.1.0)
	* Support for Multi-Process Support
* IoT (3.1.6.0)
	* Added support for Operation property in DynamoDBAction
* Route53 (3.1.5.0)
	* Update for new BOM region
* SimpleNotificationService (3.1.1.0)
	* Updated support for SMS

### 3.1.79.0 (2016-06-28 01:36 UTC)
* S3 (3.1.8.0)
	* Updated to use new Core, version 3.1.8.0
	* Added support for BOM region.
* Core 3.1.8.0
	* Added support for BOM region.
	* all services packages updated to require new core

### 3.1.78.0 (2016-06-23 21:11 UTC)
* CognitoIdentity (3.1.1.0)
	* API update for role customization
* DirectConnect (3.1.2.0)
	* API update for DescribeConnectionLoa and DescribeInterconnectLoa operations
* EC2 (3.1.17.0)
	* API update for IdentityId Format
* IdentityManagement (3.1.4.4)
	* Doc update
* RDS (3.1.12.1)
	* Doc update

### 3.1.77.0 (2016-06-21 23:39 UTC)
* CodePipeline (3.1.2.0)
	* The feature Retry Failed Actions allows you to retry a failed pipeline execution from a given stage in the pipeline. Mainly, this can be done by the new API RetryStageExecution with the use of a field from the existing (updated) API GetPielineState's response.
* OpsWorks (3.1.3.0)
	* Minor documentation update.

### 3.1.76.0 (2016-06-14 22:42 UTC)
* CertificateManager (3.1.3.3)
	* Regenerating from latest service model acm-2015-12-08.normal.json
* CloudTrail (3.1.5.0)
	* Regenerating from latest service model cloudtrail-2013-11-01.normal.json
* RDS (3.1.12.0)
	* Regenerating from latest service model rds-2014-10-31.normal.json
* S3 (3.1.7.2)
	* Minor documentation update.
* SimpleEmail (3.1.4.0)
	* Regenerating from latest service model email-2010-12-01.normal.json

### 3.1.75.1 (2016-06-13 22:41 UTC)
* S3 (3.1.7.1)
	* Pull request 379, prevent v4 auth from being forced on GET when using non s3 endpoint.
* SQS (3.1.0.10)
	* Pull request 380, updating SQSConstants

### 3.1.75.0 (2016-06-07 20:08 UTC)
* DynamoDBv2 (3.1.5.0)
	* API Update for DynamoDB Streams to support ApproximationCreationDateTime
* IoT (3.1.5.0)
	* Adds new API, ListPolicyPrincipals. ListPolicyPrincipals allows you to list all your principals (certificate or other credential, such as Amazon Cognito ID) attached to a given policy. Also adds an encode function to the SQL syntax function list, and a couple of improvements to Amazon DynamoDB Actions: Range key (primary partition key) is now optional as it is in DynamoDB. "NUMBER" is being introduced as a supported hash key and range key type.
* MachineLearning (3.1.2.0)
	* You can now assign tags, which are commonly used for cost allocation, to Amazon Machine Learning datasources, models, evaluations, and batch predictions.

### 3.1.74.0 (2016-06-03 21:43 UTC)
* ApplicationAutoScaling (3.1.0.2)
	* Updated incorrect documentation links.
* EC2 (3.1.16.0)
	* The new 'type' parameter in the RequestSpotFleet API indicates whether a Spot fleet will only 'request' the target capacity or also attempt to 'maintain' it. When you want to 'maintain' a certain target capacity, Spot fleet will place the required bids to meet this target capacity, and enable you to automatically replenish any interrupted instances. When you simply 'request' a certain target capacity, Spot fleet will only place the required bids but will not attempt to replenish Spot instances if capacity is diminished, nor will it submit bids in alternative Spot pools if capacity is not available. By default, this parameter is set to 'maintain'. - The DescribeSpotFleetRequests API now returns two new parameters: the 'fulfilledCapacity' of a Spot fleet to indicate the capacity that has been successfully launched, and the 'type' parameter to indicate whether the fleet is meant to 'request' or 'maintain' capacity.
* IdentityManagement (3.1.4.3)
	* Updated to use new Core, version 3.1.7.0
	* Fix potential performance issue in service config constructor related to attempting to access EC2 instance metadata when not running on EC2.
* S3 (3.1.7.0)
	* Updated to use new Core, version 3.1.7.0
	* Fix issue with ListObjectsV2, where StartAfter is associated with the wrong header.
* SecurityToken (3.1.4.1)
	* Updated to use new Core, version 3.1.7.0
	* Fix potential performance issue in service config constructor related to attempting to access EC2 instance metadata when not running on EC2.
* Core 3.1.7.0
	* Dispose of the CancellationTokenRegistration instance we get back from CancellationToken.Register, fix for https://github.com/aws/aws-sdk-net/issues/361
	* all services packages updated to require new core

### 3.1.73.0 (2016-05-26 21:25 UTC)
* CloudTrail (3.1.4.0)
	* Regenerated from correct service model. Previous releases contained an exception type, KmsKeyInvalidStateException, which is not currently used and should not have been present (this removal may be a breaking change for some users).
* ElastiCache (3.1.3.0)
	* This release of Amazon ElastiCache adds support for exporting a Redis snapshot to an Amazon S3 bucket. After the export is completed, you can access the exported snapshot from your Amazon S3 console or API.
* SecurityToken (3.1.4.0)
	* Refactoring changes corresponding to enhancements to enable the use of SAML role credential profiles in the SDK core assembly.
* Core 3.1.6.0
	* Updated credential profile support to enable use of SAML role profiles with SDK-based applications.
Added support for auto-detect of region from instance metadata when running on EC2 instances.
Added support for reading AWS credentials from environment variables shared with other AWS SDKs.
Added support for generating serializable exceptions.
	* all services packages updated to require new core

### 3.1.72.0 (2016-05-24 17:32 UTC)
* EC2 (3.1.15.0)
	* Added support for instance console screenshot
* RDS (3.1.11.0)
	* Cross account snapshot sharing

### 3.1.71.1 (2016-05-24 00:13 UTC)
* CognitoSync (3.1.1.1)
	* Fix KeyNotFoundException exception

### 3.1.71.0 (2016-05-19 21:39 UTC)
* Application Discovery Service (3.1.1.0)
	* API updates from revised service model. An incorrect model was used in the previous release.
* EC2 (3.1.14.0)
	* Added instance type enumeration members for new X1 types.
* ECS (3.1.5.0)
	* Add status to ListTaskDefinitionFamilies. Filter option lets customers view active, inactive, or all task definition families.
* KinesisFirehose (3.1.2.0)
	* Added support for Configurable Retry Window for Loading Data into Amazon Redshift.

### 3.1.70.0 (2016-05-18 19:21 UTC)
* Application Auto Scaling (3.1.0.0)
	* Added support for Application Auto Scaling. This service is a general purpose Auto Scaling service for supported elastic AWS resources. With Application Auto Scaling, you can automatically scale your AWS resources, with an experience similar to that of Auto Scaling.

### 3.1.69.0 (2016-05-18 06:08 UTC)
* DynamoDBv2 (3.1.4.0)
	* Documentation update.
* WorkSpaces (3.1.2.0)
	* Add tagging support.

### 3.1.68.0 (2016-05-12 22:06 UTC)
* Application Discovery Service (3.1.0.0)
	* Added support for the AWS Application Discovery Service. This service helps Systems Integrators quickly and reliably plan application migration projects by automatically identifying applications running in your data center, their associated dependencies, and their performance profile.
* CloudFormation (3.1.5.0)
	* Added ExecutionStatus to ChangeSets so that customers can see which ChangeSets are available to be executed; which one was executed in the past, and which can no longer be executed due to being obsolete.
* EC2 (3.1.13.0)
	* Added support for identifying stale security groups.
* SimpleSystemsManagement (3.1.2.0)
	* EC2 Run Command has been updated to allow customers to create and share documents. Documents can be shared privately with other AWS accounts, or publically to all accounts.

### 3.1.67.0 (2016-05-10 21:03 UTC)
* DirectConnect (3.1.1.1)
	* Documentation update.
* ElasticMapReduce (3.1.5.0)
	* ListInstances can now filter results based on InstanceState(s).
* IdentityManagement (3.1.4.1)
	* Documentation update.
* S3 (3.1.6.1)
	* Added retry for HTTP 502 and 504. Updated list of requests that should not be directed to S3 accelerate endpoint.
* SQS (3.1.0.7)
	* Documentation update.
* StorageGateway (3.1.4.0)
	* Updates to the ListGateways and ListVolumes APIs. Added support for the ListTapes API.

### 3.1.66.0 (2016-05-05 19:42 UTC)
* APIGateway (3.1.5.0)
	* Added support to Integration for controlling passthrough behavior.
* CloudTrail (3.1.3.0)
	* Updates to return topic ARN in addition to the topic name.
* ECS (3.1.4.0)
	* Added support for specifying log drivers available from Docker in task definitions.
* KeyManagementService (3.1.2.0)
	* Updated for the latest service API updates.
* S3 (3.1.6.0)
	* Added support for ListObjectsV2 operation.
* SecurityToken (3.1.3.3)
	* Documenation update for the AssumeRole API.

### 3.1.65.0 (2016-05-03 21:40 UTC)
* CodePipeline (3.1.1.5)
	* Documentation and samples update.
* CognitoIdentityProvider (3.1.0.0)
	* Added support for the Amazon Cognito Identity Provider service.
* ElasticBeanstalk (3.1.5.0)
	* Added support for TooManyBucketsException to several operations.
* Inspector (3.1.2.1)
	* Documentation update.

### 3.1.64.0 (2016-04-28 17:03 UTC)
* OpsWorks (3.1.2.0)
	* Adds support for default tenancy selection.
* Route53Domains (3.1.1.0)
	* Add support for new operations ResendContactReachabilityEmail and GetContactReachabilityStatus.

### 3.1.63.0 (2016-04-26 21:22 UTC)
* EC2 (3.1.12.0)
	* API Update for VPC Peering with Classiclink.
* ECR (3.1.1.0)
	* Added the repository URI to the output of DescribeRepositories.
* SecurityToken (3.1.3.2)
	* Service documentation update.

### 3.1.62.0 (2016-04-21 18:09 UTC)
* CertificateManager (3.1.3.0)
	* Add tagging support
* CloudHSM (3.1.2.0)
	* Documentation update
* ElasticMapReduce (3.1.4.0)
	* Add support for Smart Targeted Resize feature
* Inspector (3.1.2.0)
	* Documentation update
* IoT (3.1.4.0)
	* Added support for specifying the SQL rules engine to be used
* KeyManagementService (3.1.1.3)
	* Use correct error codes.

### 3.1.61.0 (2016-04-19 06:13 UTC)
* EC2 (3.1.11.0)
	* Add two new low-cost, high-throughput HDD volume types: Throughput Optimized HDD (st1) and Cold HDD (sc1).
* ElasticBeanstalk (3.1.4.0)
	* Add support for automatic platform version upgrades with managed updates.
* Kinesis (3.1.3.0)
	* Added support for enhanced monitoring.
* KinesisFirehose (3.1.1.0)
	* Add support for Elastic Search and Cloudwatch Logs.
* S3 (3.1.5.0)
	* Updated to use new Core, version 3.1.5.3
	* Add support for S3 Accelerate.
* Core 3.1.5.3
	* Updates to Core to support S3 Accelerate

### 3.1.60.2 (2016-04-18 18:20 UTC)
* SecurityToken (3.1.3.1)
	* Updated to use new Core, version 3.1.5.2
	* Patch for properly reaching USGovCloudWest1.
* Core 3.1.5.2
	* Fix issue with using STS with USGovCloudWest1 RegionEndpoint.

### 3.1.60.1 (2016-04-12 20:29 UTC)
* ElasticTranscoder (3.1.0.5)
	* Update CreatePipeline to support null notifications - https://github.com/aws/aws-sdk-net/issues/322

### 3.1.60.0 (2016-04-12 00:31 UTC)
* IoT (3.1.3.0)
	* Add support to “Bring your own Certificate”.

### 3.1.59.0 (2016-04-07 22:40 UTC)
* DirectoryService (3.1.3.0)
	* Add support for conditional forwarder
* ElasticBeanstalk (3.1.3.0)
	* Updates to health check
* Lambda (3.1.4.0)
	* Add ability to set runtime in the UpdateFunctionConfiguration operation

### 3.1.58.0 (2016-04-06 03:57 UTC)
* APIGateway (3.1.4.0)
	* Add support for ImportRestApi and PutRestApi.
* Inspector (3.1.1.0)
	* Large service update.
* Route53 (3.1.4.0)
	* Add support for CloudWatch metric-based health checks.
* SecurityToken (3.1.3.0)
	* Add support for GetCallerIdentity, a new API which returns details about the credentials used to make the API call.

### 3.1.57.0 (2016-03-29 22:38 UTC)
* AWS Database Migration Service (3.1.0.1)
	* Documentation update.
* CertificateManager (3.1.2.1)
	* Documentation update.
* CloudFormation (3.1.4.0)
	* Added support for ChangeSets. ChangeSets give users detailed information into what CloudFormation intends to perform when changes are executed to a stack, giving users the ability to preview and change the results before actually applying them. 
* CodeDeploy (3.1.2.1)
	* Documentation update.
* ElastiCache (3.1.2.0)
	* Regenerated from correct service model
* Redshift (3.1.2.0)
	* Added support for Cluster IAM Roles. Clusters can now assume an IAM Role to perform operations like COPY/UNLOAD as well as cryptographic operations involving KMS keys. 
* WAF (3.1.2.0)
	* Added support for XSS (Cross-site scripting) protection in WAF. 

### 3.1.56.0 (2016-03-24 21:00 UTC)
* ElastiCache (3.1.1.0)
	* Added support for changes to allow vertically scaling from one instance type to another.
* RDS (3.1.10.0)
	* Added support for Windows Authentication for RDS SQL Server.
* StorageGateway (3.1.3.0)
	* Added support for the new SetLocalConsolePassword API.

### 3.1.55.0 (2016-03-22 20:12 UTC)
* DeviceFarm (3.1.6.0)
	* Added support for purchasing and managing unmetered devices in a self service manner, and to stop runs which are currently executing. 
* ElasticBeanstalk (3.1.2.3)
	* Updated documentation.
* RDS (3.1.9.0)
	* Added support for customer specifiable fail-over order for read replicas in Amazon Aurora.

### 3.1.54.0 (2016-03-17 23:34 UTC)
* AWSMarketplaceMetering (3.1.0.0)
	* Add support for AWS Marketplace Metering Service.
* CloudHSM (3.1.1.0)
	* Add tagging support.
* IoT (3.1.2.0)
	* Add support for sending IoT data to Amazon Elasticsearch Service.
* S3 (3.1.4.0)
	* Add lifecycle configuration options.

### 3.1.53.0 (2016-03-15 22:23 UTC)
* AWS Database Migration Service (3.1.0.0)
	* Add support for the new AWS Database Migration Service.
* CodeDeploy (3.1.2.0)
	* Add support for the new BatchGetDeploymentGroups API.
* SimpleEmail (3.1.3.0)
	* Add support for custom MAIL FROM domains. For more information see the service release notes at http://aws.amazon.com/releasenotes/Amazon-SES/8381987420423821.

### 3.1.52.0 (2016-03-11 00:40 UTC)
* IdentityManagement (3.1.4.0)
	* Add stable, unique identifying string identifiers to each entity returned from IAM:ListEntitiesForPolicy.
* Redshift (3.1.1.0)
	* Updated with the ability to restore a table from a cluster snapshot to a new table in an active cluster. For more information, see <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html#working-with-snapshot-restore-table-from-snapshot">Restoring a Table from a Snapshot</a>.
* Core 3.1.5.1
	* Fix thread safety issue related to KeyedHashAlgorithm creation on Unity iOS with il2cpp.

### 3.1.51.0 (2016-03-08 22:37 UTC)
* CertificateManager (3.1.2.0)
	* Doc update
* CloudWatchEvents (3.1.1.0)
	* Doc update
* CodeCommit (3.1.1.0)
	* Add support for customizing your development workflow with repository triggers.
* ConfigService (3.1.4.0)
	* Doc update
* DeviceFarm (3.1.5.0)
	* Add support for XCUI - an updated version of Apple's iOS automation suite.
* DirectConnect (3.1.1.0)
	* Doc update

### 3.1.50.0 (2016-03-03 23:11 UTC)
* DirectoryService (3.1.2.0)
	* Added support for SNS notifications on directories.
* DynamoDBv2 (3.1.3.0)
	* Documentation update for the new DescribeLimits API.
* EC2 (3.1.10.0)
	* Added support for referencing security groups in peered Virtual Private Clouds (VPCs). For more information see the service announcement at https://aws.amazon.com/about-aws/whats-new/2016/03/announcing-support-for-security-group-references-in-a-peered-vpc/.

### 3.1.49.0 (2016-03-01 22:20 UTC)
* APIGateway (3.1.3.0)
	* Added new suppression
* CloudSearchDomain (3.1.1.0)
	* Regenerating from latest service model cloudsearchdomain-2013-01-01.normal.json
* DynamoDBv2 (3.1.2.0)
	* Added support for the new DescribeLimits API, enabling users to query provisioning limits for their account.

### 3.1.48.0 (2016-02-25 21:46 UTC)
* AutoScaling (3.1.3.0)
	* Updates to the CompleteLifecycleAction and RecordLifecycleActionHeartbeat operations
* CloudFormation (3.1.3.0)
	* Updated to allow resources not to be deleted and tag support of UpdateStack
* CloudWatchLogs (3.1.2.4)
	* Doc update
* SimpleEmail (3.1.2.0)
	* Added "Encoding" property to the SNSAction

### 3.1.47.1 (2016-02-24 21:12 UTC)
* S3 (3.1.3.13)
	* Add missing enumerations to S3Region.

### 3.1.47.0 (2016-02-23 19:54 UTC)
* Route53 (3.1.3.0)
	* Added support for SNI health check.

### 3.1.46.0 (2016-02-19 23:28 UTC)
* CognitoIdentity (3.1.0.7)
	* Added Support for Unity
* CognitoSync (3.1.1.0)
	* Added Support for Unity, Moved SyncManager and CognitoSync service client into a single assembly
* DynamoDBv2 (3.1.1.5)
	* Added support for Unity, Add ability to use streams with the S3Link object 
* IdentityManagement (3.1.3.3)
	* Add Support for Unity
* Kinesis (3.1.2.3)
	* Added Support for Unity
* KinesisFirehose (3.1.0.3)
	* Added Support for Unity
* Lambda (3.1.3.1)
	* Added Support for Unity
* MobileAnalytics (3.1.1.6)
	* Added Support for Unity
* S3 (3.1.3.12)
	* Added Support for Unity
* SecurityToken (3.1.2.2)
	* Added Support for Unity
* SimpleEmail (3.1.1.4)
	* Added Support for Unity
* SimpleNotificationService (3.1.0.5)
	* Added Support for Unity
* SQS (3.1.0.6)
	* Added Support for Unity
* Core 3.1.5.0
	* Added Support for Unity

### 3.1.45.0 (2016-02-18 22:18 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.2.0)
	* Added support for a new data set disbursed_amount_by_product_with_uncollected_funds .
* CloudWatch (3.1.0.5)
	* Documentation update.
* CodeDeploy (3.1.1.0)
	* Added support for setting up triggers for a deployment group.
* StorageGateway (3.1.2.0)
	* Added support for CreateTapeWithBarcode  API.

### 3.1.44.1 (2016-02-18 00:52 UTC)
* Core 3.1.4.5
	* Fix issue with ConstantClass thread-safety

### 3.1.44.0 (2016-02-17 00:03 UTC)
* ElasticMapReduce (3.1.3.0)
	* Added support for adding EBS storage to an EMR instance.
* RDS (3.1.8.0)
	* Added support for Cross-account Encrypted (KMS) snapshot sharing and removed unused model classes.

### 3.1.43.0 (2016-02-11 22:26 UTC)
* APIGateway (3.1.2.0)
	* Added support for custom request authorizers. With custom request authorizers, developers can authorize their APIs using bearer token authorization strategies, such as OAuth using an AWS Lambda function.
* AWS Certificate Manager (3.1.1.0)
	* Breaking change: the exception type AccessDeniedException has been removed as it is not thrown by the service. The exception type was included in previous releases in error.
* Lambda (3.1.3.0)
	* Added support for configuring a Lambda function to access resources in your VPC. These resources could be AWS service resources (for example, Amazon Redshift data warehouses, Amazon ElastiCache clusters, or Amazon RDS instances), or they could be your own services running on your own EC2 instances. For more information see http://docs.aws.amazon.com/lambda/latest/dg/vpc.html.

### 3.1.42.0 (2016-02-09 21:58 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.1.0)
	* Updated documentation. Extended the GenerateDateSet operation to include a new CustomerDefinedValues parameter. This parameter allows customers to submit arbitrary key/value pair strings which will be returned, as provided, in the asynchronous response, enabling the user of customer-provided identifiers to correlate responses with their internal systems.
* CloudFront (3.1.4.1)
	* Added a new field ACMCertificateARN to ViewerCertificate. This field replaces the CertificateSource and Certificate fields that were recently added.
* ConfigService (3.1.3.2)
	* Documentation update.
* EC2 (3.1.9.1)
	* Updated ImageUtilities class to enable use when a proxy is required.
* Gamelift (3.1.0.0)
	* Added support for Amazon Gamelift, a managed service that allows game developers the ability to deploy and configure their multiplayer games.

### 3.1.41.3 (2016-02-05 17:57 UTC)
* Core 3.1.4.4
	* Updated INI credentials parsing logic to handle '=' character in values.

### 3.1.41.2 (2016-02-03 18:24 UTC)
* S3 (3.1.3.11)
	* Adding ITransferUtility interface for the TransferUtility class.

### 3.1.41.1 (2016-01-29 19:46 UTC)
* Glacier (3.1.0.6)
	* Bug fix for ArchiveTransferManager not creating unique topics and queues

### 3.1.41.0 (2016-01-29 00:12 UTC)
* SimpleSystemsManagement (3.1.1.3)
	* Documentation update for the new 63-bit id formats.
* WAF (3.1.1.0)
	* You can now configure AWS WAF to block, allow, or monitor (count) requests based on the content in HTTP request bodies. This is the part of a request that contains any additional data that you want to send to your web server as the HTTP request body, such as data from an HTML form.

### 3.1.40.0 (2016-01-21 18:45 UTC)
* AWS Certificate Manager (3.1.0.0)
	* AWS Certificate Manager (ACM) is an AWS service that makes it easier for you to deploy secure SSL based websites and applications on the AWS platform. SSL is the standard protocol for encrypting communications and establishing the identity of a website over the Internet. ACM takes care of all of the complexity of obtaining, deploying, and renewing the digital certificates used with SSLCertificate Manager certs with CloudFront distributions.
* DeviceFarm (3.1.4.1)
	* Minor documentation update.
* IoT (3.1.1.0)
	* IoT api update to support enabling and disabling topic rules, and return arns in some structures.
* SecurityToken (3.1.2.1)
	* Minor documentation update.

### 3.1.39.0 (2016-01-19 20:54 UTC)
* DeviceFarm (3.1.4.0)
	* Api update with new enumeration values for uploads.
* OpsWorks (3.1.1.5)
	* Minor documentation update.
* SecurityToken (3.1.2.0)
	* Add support for RegionDisabledException.

### 3.1.38.0 (2016-01-14 21:41 UTC)
* CloudFront (3.1.3.0)
	* Enforce HTTPS-only connection between CloudFront and your origin webserver, support for TLSv1.1 and TLSv1.2 between CloudFront and your origin webserver, add or modify request headers forwarded from CloudFront to your origin webserver.
* CloudWatchEvents (3.1.0.0)
	* Added support for the new CloudWatch Events service. CloudWatch Events allows you to Monitor and rapidly react to changes in your AWS resources.
* EC2 (3.1.9.0)
	* Scheduled instances is a new EC2 service offering which allows customers to purchase reserved capacity for specific slots of time on a one-time or recurring basis.

### 3.1.37.0 (2016-01-12 20:08 UTC)
* EC2 (3.1.8.0)
	* Added support for DNS over classiclink.

### 3.1.36.1 (2016-01-06 20:50 UTC)
* EC2 (3.1.7.1)
	* Fixed incorrect request class and marshaling code for the DescribeNetworkInterfaceAttribute api. The class should have contained a single 'Attribute' member, not multiple members corresponding to the allows values for 'Attribute'.
* S3 (3.1.3.10)
	* Updated to use new Core, version 3.1.4.3
	* Add more defensive code while processing xml error responses
* Core 3.1.4.3
	* Add more defensive code while processing xml error responses. 
Fixed issue with callbacks being invoked multiple times when unhandled exception occurs in .NET 3.5 async code.
Updated RegionEndpoint constants for new Asia Pacific (Seoul) (ap-northeast-2) region.
	* all services packages updated to require new core

### 3.1.36.0 (2015-12-21 22:04 UTC)
* ECR (3.1.0.0)
	* Add SDK support for the Amazon EC2 Container Registry, a secure, fully-managed Docker image registry that makes it easy for developers to store and retrieve Docker container images.
* ECS (3.1.3.0)
	* Add support for deployment configuration.
* ElasticMapReduce (3.1.2.0)
	* Update RunJobFlow to accept the ServiceSecurityGroup parameter.
* SecurityToken (3.1.1.1)
	* Fix a bug in SAML assertion parsing where there are duplicate role names.

### 3.1.35.1 (2015-12-18 22:31 UTC)
* IoT (3.1.0.4)
	* Documentation update
* IotData (3.1.0.2)
	* Documentation update

### 3.1.35.0 (2015-12-17 22:20 UTC)
* CloudFront (3.1.2.0)
	* For web distributions, you can now configure CloudFront to automatically compress files of certain types for both Amazon S3 and custom origins, so downloads are faster and your web pages render faster. Compression also reduces your CloudFront data transfer cost because you pay for the total amount of data served.
* CloudTrail (3.1.2.0)
	* This release supports trails that apply across all regions, and support for multiple trails per region.
* ConfigService (3.1.3.0)
	* Update to add support for AWS Config rules. These rules enable users to evaluate whether their AWS resources comply with desired configuration settings.

Added support for Identity and Access Management (IAM) resource types.
* DynamoDBv2 (3.1.1.3)
	* Fix issue where a high retry count causes integer overflow - https://github.com/aws/aws-sdk-net/issues/286
* EC2 (3.1.7.0)
	* Added support for managed NAT, a highly available and scalable Network Address Translation (NAT) solution that enables Internet connectivity for instances in private subnets of a customer’s VPC
* RDS (3.1.7.0)
	* Add support for enhanced monitoring in RDS instances.
* Core 3.1.4.2
	* Fix issue where a high retry count causes integer overflow - https://github.com/aws/aws-sdk-net/issues/286.

Fix issue causing "Path cannot be the empty string or all whitespace" error when running under a user account that has no profile or home directory - https://github.com/aws/aws-sdk-net/issues/287.

 

### 3.1.34.0 (2015-12-15 19:02 UTC)
* EC2 (3.1.6.0)
	* Added new parameters to CopyImage API that allows a customer to create an AMI copy where all the associated EBS snapshots are encrypted.

### 3.1.33.0 (2015-12-08 20:22 UTC)
* AutoScaling (3.1.2.0)
	* Add support for SetInstanceProtection operation
* RDS (3.1.6.0)
	* Add RDS support for encrypting your databases using keys you manage through AWS Key Management Service (KMS).

### 3.1.32.1 (2015-12-08 00:15 UTC)
* Core 3.1.4.1
	* Improve exception handling in AsyncRunner https://github.com/aws/aws-sdk-net/issues/281

### 3.1.32.0 (2015-12-03 23:01 UTC)
* DirectoryService (3.1.1.0)
	* Support for managed directories
* RDS (3.1.5.0)
	* Added support for modifying DB port number via ModifyDbInstance.
* Route53 (3.1.2.0)
	* Added traffic policy support

### 3.1.31.0 (2015-12-01 23:16 UTC)
* CognitoIdentity (3.1.0.5)
	* Add api to clone logins dictionary
* ConfigService (3.1.2.1)
	* Support for new resource type - dedicated host.
* DynamoDBv2 (3.1.1.2)
	* Add PaginationToken support to DocumentModel Query and Scan operations.
	* Fix issue where ignored properties in DataModel were not being properly ignored.
* SecurityToken (3.1.1.0)
	* Implement support for SAML-based identity federation to vend temporary AWS credentials.
* Core 3.1.4.0
	* * Added new role credential and endpoint profile types to support SAML identity federation.
* Added Roslyn code analyzers to all NuGet service packages.
	* all services packages updated to require new core
* Throwing exceptions if constructing a request with bidirectional control characters
	* Fix for https://github.com/aws/aws-sdk-net/issues/212

### 3.1.30.0 (2015-11-23 23:14 UTC)
* EC2 (3.1.5.0)
	* This release includes support for EC2 Dedicated Hosts. This feature enables the use of your own per-socket and per-core OS licenses in EC2. This release also supports two new APIs, ModifyIdFormat and DescribeIdFormat, that will be used to manage the transition to longer EC2 and EBS resource IDs. These APIs are reserved for future use.
* ECS (3.1.2.0)
	* Add support for Amazon ECS task stopped reasons and task start and stop times. You can now see if a task was stopped by a user or stopped due to other reasons such as a failing Elastic Load Balancing health check, as well as the time the task was started and stopped. Service scheduler error messages have additional information that describe why tasks cannot be placed in the cluster.
* ElasticBeanstalk (3.1.2.0)
	* Add support for AWS Elastic Beanstalk for composable web applications. Customers whose applications consists of several linked modules (micro services architecture) can now deploy, manage, and scale their applications using EB.
* S3 (3.1.3.8)
	* Added missing canned ACL.

### 3.1.29.1 (2015-11-20 21:46 UTC)
* CloudSearchDomain (3.1.0.4)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* EC2 (3.1.4.3)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* S3 (3.1.3.7)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* SQS (3.1.0.3)
	* Updated to use new Core, version 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274
* Core 3.1.3.8
	* Fix for https://github.com/aws/aws-sdk-net/issues/274 , response handler logic being called instead of skipped for .NET 3.5 async, when an exception is thrown in the pipeline.


### 3.1.29.0 (2015-11-19 18:42 UTC)
* DeviceFarm (3.1.3.0)
	* Added support for new test and upload types.

### 3.1.28.1 (2015-11-18 00:02 UTC)
* Inspector (3.1.0.1)
	* Documentation update.
* S3 (3.1.3.6)
	* Updated to use new Core, version 3.1.3.7
	* Increment version to pick up latest core patch for dealing with key edge cases.
* Core 3.1.3.7
	* Fix issue with AWS4Signer.

### 3.1.28.0 (2015-11-12 21:05 UTC)
* CognitoIdentity (3.1.0.4)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* CognitoSync (3.1.0.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* EC2 (3.1.4.2)
	* Documentation update
* Lambda (3.1.2.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* MobileAnalytics (3.1.1.3)
	* Updated to use new Core, version 3.1.3.6, to pick up the latest ClientContext.
* RDS (3.1.4.0)
	* Added support for modifying DB instance visibility.
Updated documentation to note support for M4 types for DB instance class.

* Core 3.1.3.6
	* Minor fixes to ClientContext.

### 3.1.27.0 (2015-11-10 20:21 UTC)
* APIGateway (3.1.1.0)
	* Added support for stage variables.

### 3.1.26.1 (2015-11-07 01:22 UTC)
* IoT (3.1.0.2)
	* Updated to use new Core, version 3.1.3.5
	* Incremented Core package dependency to fix signature errors when a PUT or POST requests contains only query params (e.g. IOT AcceptCertificateTransfer, CreateKeysAndCertificate).
* Core 3.1.3.5
	* Fix for signature errors when a PUT or POST requests contains only query params (e.g. IOT AcceptCertificateTransfer, CreateKeysAndCertificate).

### 3.1.26.0 (2015-11-06 21:05 UTC)
* RDS (3.1.3.0)
	* Add support for sharing manual DB snapshots

### 3.1.25.0 (2015-11-03 21:41 UTC)
* DeviceFarm (3.1.2.0)
	* Added support for AWS Device Farm APIs to manage projects, device pools, runs, and uploads.
* S3 (3.1.3.5)
	* Add validation for S3 get object calls to make sure the object key is set. If it's not set, that makes the request the same as ListObject call to S3 giving unexpected results to the caller.
* Core 3.1.3.4
	* Fix for disposed instance of web request being used to get header values.

### 3.1.24.0 (2015-11-02 18:47 UTC)
* IdentityManagement (3.1.3.0)
	* Update IAM policy simulator to help test, verify, and understand resource-level permissions.

### 3.1.23.3 (2015-10-29 20:24 UTC)
* S3 (3.1.3.4)
	* Updated to use new Core, version 3.1.3.3
	* Fixed the minimum version of Core dependency.
* Core 3.1.3.3
	* Added AmazonDateTimeUnmarshallingException type.

### 3.1.23.2 (2015-10-28 20:27 UTC)
* APIGateway (3.1.0.1)
	* Update API Gateway model to fix PutIntegration calls.

### 3.1.23.1 (2015-10-27 04:42 UTC)
* S3 (3.1.3.3)
	* Fix issue with byte range for CopyPart operation

### 3.1.23.0 (2015-10-26 22:44 UTC)
* APIGateway (3.1.0.0)
	* Amazon API Gateway is a fully managed service that makes it easy for developers to create, publish, maintain, monitor, and secure APIs at any scale.
* S3 (3.1.3.2)
	* Fix to handle responses with invalid values in the expires header for S3 GetObject and GetObjectMetatdata APIs.

### 3.1.22.0 (2015-10-26 17:54 UTC)
* SimpleSystemsManagement (3.1.1.0)
	* EC2 Run Command
- A new EC2 feature that enables you to securely and remotely manage the configuration of your Amazon EC2 Windows instances. Run Command provides a simple way of automating common administrative tasks like executing scripts, running PowerShell commands, installing software or patches and more.

### 3.1.21.0 (2015-10-22 21:40 UTC)
* AutoScaling (3.1.1.0)
	* Adding support for EBS encryption in block device mappings.
* IdentityManagement (3.1.2.0)
	* Enable Policy Simulator API to do simulation with resource-based policies.
* Lambda (3.1.2.2)
	* Fix issue with invoking Lambda GetPolicy operation.

### 3.1.20.1 (2015-10-20 21:01 UTC)
* IoT (3.1.0.1)
	* Updated to use new Core, version 3.1.3.2
	* Rev version to pick up latest core patch for sending both a query string and a body.
* Lambda (3.1.2.1)
	* Updated to use new Core, version 3.1.3.2
	* Rev version to pick up latest core patch for sending both a query string and a body.
* Core 3.1.3.2
	* Fixed issue with operations that contain both a query string and a body.

### 3.1.20.0 (2015-10-15 19:24 UTC)
* KeyManagementService (3.1.1.0)
	* Add support for deleting Customer Master Keys, including two new APIs for scheduling and canceling key deletion.

### 3.1.19.1 (2015-10-14 21:43 UTC)
* Core 3.1.3.1
	* Fix issue with LitJson handling of null values in some cases.

### 3.1.19.0 (2015-10-07 23:16 UTC)
* ECS (3.1.1.0)
	* Task definitions now support more Docker options
* IoT (3.1.0.0)
	* AWS IoT offering enables our users to leverage the AWS Cloud for their Internet of things use-cases.
* IotData (3.1.0.0)
	* AWS IoT-Data enables secure, bi-directional communication between Internet-connected things (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud.
* Lambda (3.1.2.0)
	* Lambda now supports function versioning.

### 3.1.18.0 (2015-10-07 09:15 UTC)
* AWSMarketplaceCommerceAnalytics (3.1.0.0)
	* Updated to use new Core, version 3.1.3.0
	* The AWS Marketplace Commerce Analytics service allows marketplace partners to programmatically request business intelligence data from AWS Marketplace. This service provides the same data that was previously only available through the AWS Marketplace Management Portal, but offers the data in a fully-machine-readable format and available in fine-grained data sets rather than large reports.
* ConfigService (3.1.2.0)
	* Added support for Config Rule and Evaluations.
* Inspector (3.1.0.0)
	* Amazon Inspector is a new service from AWS that identifies security issues in your application deployments. Use Inspector with your applications to assess your security posture and identify areas that can be improved. Inspector works with your EC2 Instances to monitor activity in the applications and system.
* Kinesis (3.1.2.0)
	* Added two new Amazon Kinesis APIs that allow customers to choose how long their data records are stored in their Amazon Kinesis streams.
* KinesisFirehose (3.1.0.0)
	* Amazon Kinesis Firehose is a fully managed service for ingesting data streams directly into AWS data services such as Amazon S3 and Amazon Redshift.
* Core 3.1.3.0
	* Updated the set of error codes that are automatically retried.

### 3.1.17.1 (2015-10-07 00:48 UTC)
* Core 3.1.2.1
	* Fixed issue where NullReferenceException could be thrown for certain SDK calls (https://github.com/aws/aws-sdk-net/issues/252).
	* all services packages updated to require new core

### 3.1.17.0 (2015-10-06 21:20 UTC)
* CloudFront (3.1.1.0)
	* Added support for integrating CloudFront with AWS WAF.
* EC2 (3.1.4.0)
	* Added new property BlockDurationMinutes to RequestSpotInstancesRequest. This specifies the duration for which the instance is required.
* WAF (3.1.0.0)
	* Updated to use new Core, version 3.1.2.0
	* Added support for AWS WAF (Web Application Firewall). AWS WAF protects web applications from attack by allowing customers to block bad actors and provides filters against common web exploits like SQL injection.
* Core 3.1.2.0
	* Added support for WAF.

### 3.1.16.0 (2015-10-01 21:11 UTC)
* CloudTrail (3.1.1.0)
	* Added new APIs for AWS CloudTrail: AddTags, ListTags, RemoveTags, and ListPublicKeys. This release of CloudTrail includes support for log file integrity validation, log encryption with AWS KMS–Managed Keys (SSE-KMS), and trail tagging.
* Elasticsearch (3.0.0.0)
	* Added support for the new Amazon Elasticsearch Service.
* RDS (3.1.2.0)
	* Added support for t2.large DB instance, support for copying tags to snapshot, and other minor updates.
* WorkSpaces (3.1.1.0)
	* Added support for user volume encryption.

### 3.1.15.0 (2015-09-29 23:12 UTC)
* CloudFormation (3.1.1.0)
	* Added new DescribeAccountLimits API and optional ResourceTypes parameter for CreateStack and UpdateStack APIs.
* EC2 (3.1.3.0)
	* Added support for the new ModifySpotFleetRequest API.
* SimpleEmail (3.1.1.0)
	* Amazon Simple Email Service can now accept incoming emails. You can configure Amazon SES to deliver messages to an Amazon S3 bucket, call an AWS Lambda function, publish notifications to Amazon SNS, drop messages, or bounce messages. Added new cmdlets to support this feature.

### 3.1.14.1 (2015-09-24 22:17 UTC)
* CognitoIdentity (3.1.0.2)
	* Documentation update.

### 3.1.14.0 (2015-09-17 19:21 UTC)
* CloudWatchLogs (3.1.2.0)
	* Added support for exporting log data from Log Groups to Amazon S3 Buckets.

### 3.1.13.0 (2015-09-16 19:35 UTC)
* S3 (3.1.3.0)
	* Added support for the new STANDARD_IA storage class and for multiple lifecycle transitions.

### 3.1.12.0 (2015-09-15 20:11 UTC)
* EC2 (3.1.2.0)
	* Added DataEncryptionKeyId and StateMessage properties to the Amazon.EC2.Model.Snapshot class, this data is returned by the DescribeSnapshots operation. Added AllocationStrategy property to the Amazon.EC2.Model.SpotFleetRequestConfigData class, this data is used by the RequestSpotFleet operation.
* ElasticFileSystem (3.1.1.0)
	* Added MountTargetId to Amazon.ElasticFileSystem.Model.DescribeMountTargetsRequest.
* MobileAnalytics (3.1.1.1)
	* Fixed FxCop violations, and minor refactoring.
* Route53 (3.1.1.0)
	* Added support for calculated and latency health checks.

### 3.1.11.0 (2015-09-10 17:43 UTC)
* ElasticMapReduce (3.1.1.0)
	* Deprecated DescribeJobFlows API.
* IdentityManagement (3.1.1.0)
	* Add support for IAM policy simulator.
* ImportExport (3.1.1.0)
	* Documentation update for ImportExport client.
* Kinesis (3.1.1.0)
	* Add timestamp field to Amazon.Kinesis.Model.Record type.
* Lambda (3.1.1.0)
	* Deprecated InvokeAsync API
* MachineLearning (3.1.1.0)
	* Documentation update for Amazon Machine Learning client.

### 3.1.10.1 (2015-09-04 20:30 UTC)
* Core 3.1.1.1
	* Included pull request https://github.com/aws/aws-sdk-net/pull/242 to fix signing issues for endpoints with a path component.

### 3.1.10.0 (2015-09-03 20:56 UTC)
* DynamoDBv2 (3.1.1.0)
	* Added enum support for DynamoDB DataModel.
* StorageGateway (3.1.1.0)
	* Add support for tagging StorageGateway resources.

### 3.1.9.0 (2015-08-31 21:22 UTC)
* EC2 (3.1.1.0)
	* Add support for spot fleet instance weights.

### 3.1.8.0 (2015-08-27 23:50 UTC)
* ConfigService (3.1.1.0)
	* Added support for ListDiscoveredResources.

### 3.1.7.0 (2015-08-27 00:39 UTC)
* MobileAnalytics (3.1.1.0)
	* Added MobileAnalyticsErrorEvent to Amazon Mobile Analytics and minor improvements.
* Core 3.1.1.0
	* Service packages updated to require new core, which includes FileLogger for PCL.

### 3.1.6.0 (2015-08-25 18:01 UTC)
* CodePipeline (3.1.1.0)
	* Add support for KMS encryption keys on S3 artifact stores.

### 3.1.5.0 (2015-08-12 20:11 UTC)
* ElasticBeanstalk (3.1.1.0)
	* Add Elastic Beanstalk client support for environment health.
* MobileAnalytics (3.1.0.2)
	* Updated to need new core version 3.1.0.2
	* Updated documentation
* S3 (3.1.2.0)
	* Updated S3 TransferUtility to retry a failed download without discarding the bytes that were already downloaded
* Core 3.1.0.2

### 3.1.4.0 (2015-08-06 15:55 UTC)
* SimpleWorkflow (3.1.1.0)
	* Update SWF client for Lambda support

### 3.1.3.0 (2015-08-04 21:59 UTC)
* DeviceFarm (3.1.1.0)
	* Update DeviceFarm client with latest model, adding support for iOS and retrieving account settings.

### 3.1.2.1 (2015-08-04 00:50 UTC)
* CloudSearchDomain (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Glacier (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Lambda (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* S3 (3.1.1.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Core 3.1.0.1
	* Fix PCL SigV4 signing issue where SHA256 hash is not always calculated correctly.

### 3.1.2.0 (2015-07-31 00:36 UTC)
* OpsWorks (3.1.1.0)
	* Add support for ECS clusters.
* RDS (3.1.1.0)
	* Add support for Amazon Aurora.

### 3.1.1.0 (2015-07-28 23:37 UTC)
* CloudWatchLogs (3.1.1.0)
	* Adding 4 new APIs: PutDestination, PutDestinationPolicy, DescribeDestinations and DeleteDestination
* S3 (3.1.1.0)
	* Support for new storage class headers on GET/HEAD requests.
	* Enhancements to S3 event notifications
		* Support for Deletes.
		* Support for Bucket Change events like policy changes and lifecycle changes
		* Support for filtering on object names including prefixes and suffixes.

### 3.1.0.0 (2015-07-28 20:30 UTC)
* The Version 3 of AWS SDK for .NET is out of preview and promoted to general availability.
* All service SDKs and Core assemblies are set to version 3.1.0.0 for this release.
* Xamarin support added to Portable Class Library (PCL) version of the SDK. The Xamarin and PCL versions of the SDK are available as public preview.
* Additional Changes
	* Pull request [222](https://github.com/aws/aws-sdk-net/pull/222) - Fix to code that resolves location of .aws\credentials file.
	* Fixed issue with setting ServiceURL for DynamoDB Streams client.

### 3.0.6.0 (2015-07-10 00:22 UTC)
* AutoScaling (3.0.2.0)
	* Step scaling policies allow customers to scale their Auto Scaling groups based on the magnitude of the alarm breach.
* CloudFront (3.0.2.0)
	* Amazon CloudFront now lets you configure a maximum time-to-live (TTL) and a default TTL to specify how long CloudFront caches your objects in edge locations.
* CodeCommit (3.0.0.0)
	* AWS CodeCommit is a secure, highly scalable, managed source control service that hosts private Git repositories.
* CodePipeline (3.0.0.0)
	* AWS CodePipeline is a continuous delivery service that enables you to model, visualize, and automate the steps required to release your software.
* CognitoIdentity (3.0.1.1)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* CognitoSync (3.0.0.3)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* ConfigService (3.0.1.0)
	* You can now set up AWS Config to record changes for specific resource types.
* EC2 (3.0.5.0)
	* You can now optionally enable encryption using AWS KMS keys when copying an unencrypted EBS snapshot.
* ECS (3.0.3.0)
	* You can now use the UDP protocol with containers on Amazon EC2 Container Service (ECS).
* Glacier (3.0.2.0)
	* Glacier vaults now support tagging.
* IdentityManagement (3.0.1.0)
	* You can upload SSH public keys to IAM and use those keys for	authentication with AWS CodeCommit. 
* Lambda (3.0.2.0)
	* You can now develop your AWS Lambda function code using Java.
* OpsWorks (3.0.2.0)
	* You can now manage updates of the agent software running on instances managed by AWS OpsWorks. 
* Redshift (3.0.1.0)
	* Redshift supports automatic cross-region backups for your KMS encrypted clusters for disaster recover.
* SimpleEmail (3.0.1.0)
	* Amazon Simple Email Service (Amazon SES) adds support for cross-account sending.
* Core 3.0.0.4

### 3.0.5.0 (2015-06-20 06:52 UTC)
* ECS (3.0.2.0)
	* You can now choose the sort order for task definitions, deregister task definitions, and override task definition environment variables when running a task.

### 3.0.4.0 (2015-06-19 22:54 UTC)
* AutoScaling (3.0.1.0)
* EC2 (3.0.4.0)
	* Regen EC2 for latest API changes. The update contains the new VPC Flow Logs feature.
* ECS (3.0.1.0)
	* Regen ECS with latest service API updates.
