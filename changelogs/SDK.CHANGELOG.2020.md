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

