### 3.7.1194.0 (2025-12-30 19:18 UTC)
* Connect (3.7.521.0)
	* Adds support for searching global contacts using the ActiveRegions filter, and pagination support for ListSecurityProfileFlowModules and ListEntitySecurityProfiles.
* KafkaConnect (3.7.504.0)
	* This change sets the KafkaConnect GovCloud FIPS and FIPS DualStack endpoints to use kafkaconnect instead of kafkaconnect-fips as the service name. This is done to match the Kafka endpoints.
* Core 3.7.500.61
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1193.0 (2025-12-29 19:18 UTC)
* Connect (3.7.520.0)
	* Changes for Contact for Global Search
* QuickSight (3.7.509.0)
	* This release adds support for quick users to be able to perform role upgrades on their own. Additionally it allows admins to make this feature admin or auto approval along with new self upgrade capability that can be restricted by Admins.

### 3.7.1192.0 (2025-12-26 19:20 UTC)
* ElasticTranscoder (Removed)
	* Amazon Elastic Transcoder has been removed from the SDK because it has been discontinued.
* MediaLive (3.7.510.0)
	* AWS Elemental MediaLive now supports Pipeline Locking using Video Alignment as well as linked single pipeline channels to enable cross-channel and cross-region Pipeline Locking workflows.
* Core 3.7.500.60
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1191.0 (2025-12-23 19:32 UTC)
* CloudWatch (3.7.505.7)
	* Improve AWS Query compatible error handling in unmarshallers.
* GeoPlaces (3.7.503.0)
	* Adds support for InferredSecondaryAddress place type, Designator in SecondaryAddressComponent and Heading in ReverseGeocode.
* PinpointSMSVoiceV2 (3.7.505.0)
	* This release adds support for the Registration Reviewer feature, which provides generative AI feedback on a phone number or sender ID registration to ensure completeness before sending to downstream (carrier) review.
* S3 (3.7.509.0)
	* Add additional validation to Outpost bucket names.
* SQS (3.7.502.20)
	* Improve AWS Query compatible error handling in unmarshallers.
* Core 3.7.500.59
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1190.0 (2025-12-22 19:20 UTC)
* ConfigService (3.7.504.0)
	* Added supported resourceTypes for Config from July to November 2025
* EC2 (3.7.539.0)
	* Adds support for linkedGroupId on the CreatePlacementGroup and DescribePlacementGroups APIs. The linkedGroupId parameter is reserved for future use.
* GuardDuty (3.7.512.0)
	* Make accountIds a required field in GetRemainingFreeTrialDays API to reflect service behavior.
* PCS (3.7.507.15)
	* Change API Reference Documentation for default Mode in Accounting and SlurmRest

### 3.7.1189.0 (2025-12-19 19:20 UTC)
* ARCRegionswitch (3.7.503.0)
	* Automatic Plan Execution Reports allow customers to maintain a concise record of their Region switch Plan executions.  This enables customer SREs and leadership to have a clear view of their recovery posture based on the generated reports for their Plan executions.
* Connect (3.7.519.0)
	* Adding support for Custom Metrics and Pre-Defined Attributes to GetCurrentMetricData API.
* EMRServerless (3.7.503.0)
	* Added JobLevelCostAllocationConfiguration field to enable cost allocation reporting at the job level, providing more granular visibility into EMR Serverless charges
* IoT (3.7.505.0)
	* This release adds event-based logging feature that enables granular event logging controls for AWS IoT logs.
* QBusiness (3.7.504.0)
	* It is a internal bug fix for region expansion
* Wickr (3.7.500.0)
	* AWS Wickr now provides a suite of admin APIs to allow you to programmatically manage secure communication for Wickr networks at scale. These APIs enable you to automate administrative workflows including user lifecycle management, network configuration, and security group administration.
* WorkSpacesWeb (3.7.505.0)
	* Add support for WebAuthn under user settings.
* Core 3.7.500.58
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1188.0 (2025-12-18 19:18 UTC)
* AppStream (3.7.505.0)
	* Added support for new operating systems (1) Ubuntu 24.04 Pro LTS on Elastic fleets, and (2) Microsoft Server 2025 on Always-On and On-Demand fleets
* ARCRegionswitch (3.7.502.0)
	* New API to list Route 53 health checks created by ARC region switch for a plan in a specific AWS Region using the Region switch Regional data plane.
* Artifact (3.7.503.0)
	* Add support for ListReportVersions API  for the calling AWS account.
* BedrockAgentCoreControl (3.7.513.0)
	* Feature to support header exchanges between Bedrock AgentCore Gateway Targets and client, along with propagating query parameter to the configured targets.
* BedrockDataAutomation (3.7.505.0)
	* Blueprint Optimization (BPO) is a new Amazon Bedrock Data Automation (BDA) capability that improves blueprint inference accuracy using example content assets and ground truth data. BPO works by generating better instructions for fields in the Blueprint using provided data.
* CleanRooms (3.7.510.0)
	* Adding support for collaboration change requests requiring an approval workflow. Adding support for change requests that grant or revoke results receiver ability and modifying auto approved change types in an existing collaboration.
* EC2 (3.7.538.0)
	* This release adds AvailabilityZoneId support for CreateFleet, ModifyFleet, DescribeFleets, RequestSpotFleet, ModifySpotFleetRequests and DescribeSpotFleetRequests APIs.
* ECR (3.7.506.0)
	* Adds support for ECR Create On Push
* ECS (3.7.507.0)
	* Adding support for Event Windows via a new ECS account setting "fargateEventWindows". When enabled, ECS Fargate will use the configured event window for patching tasks. Introducing "CapacityOptionType" for CreateCapacityProvider API, allowing support for Spot capacity for ECS Managed Instances.
* IoT (3.7.504.0)
	* This release adds message batching for the IoT Rules Engine HTTP action.
* OpenSearchService (3.7.507.0)
	* Amazon OpenSearch Service adds support for warm nodes, enabling new multi-tier architecture.
* SimpleEmailV2 (3.7.508.0)
	* Amazon SES introduces Email Validation feature which checks email addresses for syntax errors, domain validity, and risky addresses to help maintain deliverability and protect sender reputation. SES also adds resource tagging and ABAC support for EmailTemplates and CustomVerificationEmailTemplates.
* SsmSap (3.7.504.0)
	* Added "Stopping" for the HANA Database Status.
* Core 3.7.500.57
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1187.0 (2025-12-17 19:16 UTC)
* GameLiftStreams (3.7.505.0)
	* Added new stream group operation parameters for scale-on-demand capacity with automatic prewarming. Added new Gen6 stream classes based on the EC2 G6 instance family. Added new StartStreamSession parameter for exposure of real-time performance stats to clients.
* GuardDuty (3.7.511.0)
	* Add support for dbiResourceId in finding.
* InspectorScan (3.7.503.0)
	* Adds an additional OutputFormat
* KafkaConnect (3.7.503.0)
	* Support dual-stack network connectivity for connectors via NetworkType field.
* MediaConvert (3.7.506.0)
	* Adds support for tile encoding in HEVC and audio for video overlays.
* MediaPackageV2 (3.7.506.0)
	* This release adds support for SPEKE V2 content key encryption in MediaPackage v2 Origin Endpoints.
* PaymentCryptography (3.7.506.0)
	* Support for AS2805 standard.  Modifications to import-key and export-key to support AS2805 variants.
* PaymentCryptographyData (3.7.504.0)
	* Support for AS2805 standard.  New API GenerateAs2805KekValidation and changes to translate pin, GenerateMac and VerifyMac to support AS2805 key variants.
* SageMaker (3.7.525.0)
	* Adding the newly launched p6-b300.48xlarge ec2  instance support in Sagemaker(Hyperpod,Training and Sceptor)
* Core 3.7.500.56
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1186.0 (2025-12-16 20:11 UTC)
* IoT (3.7.503.0)
	* Add support for dynamic payloads in IoT Device Management Commands
* TimestreamInfluxDB (3.7.504.0)
	* This release adds support for rebooting InfluxDB DbInstances and DbClusters
* Core 3.7.500.55
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1185.0 (2025-12-15 19:16 UTC)
* AWSHealth (3.7.503.0)
	* Updating Health API endpoint generation for dualstack only regions
* BedrockAgentCoreControl (3.7.512.5)
	* This release updates broken links for AgentCore Policy APIs in the AWS CLI and SDK resources.
* CloudWatchLogs (3.7.507.0)
	* This release allows you to import your historical CloudTrail Lake data into CloudWatch with a few steps, enabling you to easily consolidate operational, security, and compliance data in one place.
* Connect (3.7.518.0)
	* Amazon Connect now supports outbound WhatsApp contacts via the Send message block or StartOutboundChatContact API. Send proactive messages for surveys, reminders, and updates. Offer customers the option to switch to WhatsApp while in queue, eliminating hold time.
* EC2 (3.7.537.0)
	* EC2 Capacity Manager now supports SpotTotalCount, SpotTotalInterruptions and SpotInterruptionRate metrics for both vCPU and instance units.
* EntityResolution (3.7.504.0)
	* Support Customer Profiles Integration for AWS Entity Resolution
* Glacier (3.7.503.0)
	* Documentation updates for Amazon Glacier's maintenance mode
* MediaTailor (3.7.504.0)
	* Added support for Ad Decision Server Configuration enabling HTTP POST requests with custom bodies, headers, GZIP compression, and dynamic variables. No changes required for existing GET request configurations.
* Route53Resolver (3.7.504.0)
	* Adds support for enabling detailed metrics on Route 53 Resolver endpoints using RniEnhancedMetricsEnabled and TargetNameServerMetricsEnabled in the CreateResolverEndpoint and UpdateResolverEndpoint APIs, providing enhanced visibility into Resolver endpoint and target name server performance.
* S3 (3.7.508.0)
	* This release adds support for the new optional field 'LifecycleExpirationDate' in S3 Inventory configurations.
* ServiceQuotas (3.7.503.0)
	* Add support for SQ Dashboard Api

### 3.7.1184.0 (2025-12-12 19:24 UTC)
* BCMRecommendedActions (3.7.502.0)
	* Added new freetier action types to RecommendedAction.type.
* Connect (3.7.517.0)
	* Amazon Connect now offers automated post-chat surveys triggered when customers end conversations. This captures timely feedback while experience is fresh, using either a no-code form builder or Amazon Lex-powered interactive surveys.
* DataSync (3.7.505.0)
	* Adds Enhanced mode support for NFS and SMB locations. SMB credentials are now managed via Secrets Manager, and may be encrypted with service or customer managed keys. Increases AgentArns maximum count to 8 (max 4 per TaskMode). Adds folder counters to DescribeTaskExecution for Enhanced mode tasks.
* WorkSpacesWeb (3.7.504.0)
	* Adds support for portal branding customization, enabling administrators to personalize end-user portals with custom assets.
* Core 3.7.500.54
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1183.0 (2025-12-11 19:22 UTC)
* Lambda (3.7.510.0)
	* Add Dotnet 10 (dotnet10) support to AWS Lambda.
* Organizations (3.7.509.0)
	* Add support for policy operations on the NETWORK SECURITY DIRECTOR POLICY policy type.
* QuickSight (3.7.508.0)
	* This release adds new GetIdentityContext API, Dashboard customization options for tables and pivot tables, Visual styling options- borders and decals, map GeocodingPreferences, KeyPairCredentials for DataSourceCredentials. Snapshot APIs now support registered users. Parameters limit increased to 400
* SecretsManager (3.7.504.0)
	* Add SortBy parameter to ListSecrets
* SimpleEmailV2 (3.7.507.0)
	* Update GetEmailIdentity and CreateEmailIdentity response to include SigningHostedZone in DkimAttributes. Updated PutEmailIdentityDkimSigningAttributes Response to include SigningHostedZone.
* Core 3.7.500.53
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1182.0 (2025-12-10 23:32 UTC)
* Bedrock (3.7.510.0)
	* Automated Reasoning checks in Amazon Bedrock Guardrails is capable of generating policy scenarios to validate policies. The GetAutomatedReasoningPolicyBuildWorkflowResultAssets API now adds POLICY SCENARIO asset type, allowing customers to retrieve scenarios generated by the build workflow.
* BillingConductor (3.7.504.0)
	* Launch itemized custom line item and service line item filter
* CloudWatch (3.7.505.0)
	* This release introduces two additional protocols AWS JSON 1.1 and Smithy RPC v2 CBOR, replacing the currently utilized one, AWSQuery. AWS SDKs will prioritize the protocol that is the most performant for each language.
* Odb (3.7.503.0)
	* The following APIs now return CloudExadataInfrastructureArn and OdbNetworkArn fields for improved resource identification and AWS service integration - GetCloudVmCluster, ListCloudVmClusters, GetCloudAutonomousVmCluster, and ListCloudAutonomousVmClusters.
* OpenSearchService (3.7.506.0)
	* The CreateApplication API now supports an optional kms key arn parameter to allow customers to specify a CMK for application encryption.
* PartnerCentralSelling (3.7.506.0)
	* Adds support for the new Project.AwsPartition field on Opportunity and AWS Opportunity Summary. Use this field to specify the AWS partition where the opportunity will be deployed.
* Signer (3.7.503.0)
	* Adds support for Signer GetRevocationStatus with updated endpoints

### 3.7.1181.0 (2025-12-09 19:31 UTC)
* Account (3.7.503.0)
	* This release adds a new API (GetGovCloudAccountInformation) used to retrieve information about a linked GovCloud account from the standard AWS partition.
* AppSync (3.7.502.0)
	* Update Event API to require EventConfig parameter in creation and update requests.
* GuardDuty (3.7.510.0)
	* Adding support for Ec2LaunchTemplate Version field
* IVSRealTime (3.7.504.0)
	* Token Exchange introduces seamless token exchange capabilities for IVS RTX, enabling customers to upgrade or downgrade token capabilities and update token attributes within the IVS client SDK without forcing clients to disconnect and reconnect.
* Mgn (3.7.503.0)
	* Added parameters encryption, IPv4/IPv6 protocol configuration, and enhanced tagging support for replication operations.
* Route53 (3.7.506.0)
	* Amazon Route 53 now supports the EU (Germany) Region (eusc-de-east-1) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region
* Core 3.7.500.52
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1180.0 (2025-12-08 19:31 UTC)
* CostExplorer (3.7.508.0)
	* Add support for Cost Category resource associations including filtering by resource type on ListCostCategoryDefinitions and new ListCostCategoryResourceAssociations API.
* EC2 (3.7.536.0)
	* Amazon EC2 P6-B300 instances provide 8x NVIDIA Blackwell Ultra GPUs with 2.1 TB high bandwidth GPU memory, 6.4 Tbps EFA networking, 300 Gbps dedicated ENA throughput, and 4 TB of system memory. Amazon EC2 C8a instances are powered by 5th Gen AMD EPYC processors with a maximum frequency of 4.5 GHz.
* IAMRolesAnywhere (3.7.503.0)
	* Increases certificate string length for trust anchor source data to support ML-DSA certificates.
* IdentityStore (3.7.504.0)
	* Updating AWS Identity Store APIs to support Attribute Extensions capability, with the first release adding Enterprise Attributes. This launch aligns Identity Store APIs with SCIM for enterprise attributes, reducing cases when customers are forced to use SCIM due to lack of SigV4 API support.
* PartnerCentralSelling (3.7.505.0)
	* Deal Sizing Service for AI-based deal size estimation with AWS service-level breakdown, supporting Expansion and Migration deals across Technology, and Reseller partner cohorts, including Pricing Calculator AddOn for MAP deals and funding incentives.
* RDS (3.7.511.0)
	* Adding support for tagging RDS Instance/Cluster Automated Backups
* RedshiftServerless (3.7.503.0)
	* Added GetIdentityCenterAuthToken API to retrieve encrypted authentication tokens for Identity Center integrated serverless workgroups. This API enables programmatic access to secure Identity Center tokens with proper error handling and parameter validation across supported SDK languages.
* SimpleEmailV2 (3.7.506.0)
	* Update Mail Manager Archive ARN validation
* Core 3.7.500.51
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1179.0 (2025-12-05 19:25 UTC)
* ECS (3.7.506.4)
	* Updating stop-task API to encapsulate containers with custom stop signal
* IdentityManagement (3.7.507.0)
	* Adding the ExpirationTime attribute to the delegation request resource.
* Inspector2 (3.7.505.0)
	* This release adds a new ScanStatus called "Unsupported Code Artifacts". This ScanStatus will be returned when a Lambda function was not code scanned because it has unsupported code artifacts.
* PartnerCentralAccount (3.7.501.0)
	* Adding Verification API's to Partner Central Account SDK.
* SimpleEmailV2 (3.7.505.0)
	* Updating the desired url for `PutEmailIdentityDkimSigningAttributes` from v1 to v2

### 3.7.1178.0 (2025-12-04 17:02 UTC)
* Lambda (3.7.509.0)
	* Add DisallowedByVpcEncryptionControl to the LastUpdateStatusReasonCode and StateReasonCode enums to represent failures caused by VPC Encryption Controls.

### 3.7.1177.0 (2025-12-03 16:45 UTC)
* Bedrock (3.7.509.0)
	* Adding support in Amazon Bedrock to customize models with reinforcement fine-tuning (RFT) and support for updating the existing Custom Model Deployments.
* SageMaker (3.7.524.0)
	* Introduces Serverless training: A fully managed compute infrastructure that abstracts away all infrastructure complexity, allowing you to focus purely on model development.

Added AI model customization assets used to train, refine, and evaluate custom models during the model customization process.

### 3.7.1176.0 (2025-12-02 16:44 UTC)
* Bedrock (3.7.508.0)
	* Adds the audioDataDeliveryEnabled boolean field to the Model Invocation Logging Configuration.
* BedrockAgentCore (3.7.508.0)
	* Support for AgentCore Evaluations and Episodic memory strategy for AgentCore Memory.
* BedrockAgentCoreControl (3.7.512.0)
	* Supports AgentCore Evaluations, Policy, Episodic Memory Strategy, Resource Based Policy for Runtime and Gateway APIs, API Gateway Rest API Targets and enhances JWT authorizer.
* BedrockRuntime (3.7.512.0)
	* Adds support for Audio Blocks and Streaming Image Output plus new Stop Reasons of malformed_model_output and malformed_tool_use.
* CloudWatchLogs (3.7.506.0)
	* CloudWatch Logs adds managed S3 Tables integration to access logs using other analytical tools, as well as facets and field indexing to simplify log analytics in CloudWatch Logs Insights.
* CostExplorer (3.7.507.0)
	* This release updates existing Savings Plans Purchase Analyzer and Recommendations APIs to support Database Savings Plans.
* DataZone (3.7.513.0)
	* Amazon DataZone now supports exporting Catalog datasets as Amazon S3 tables, and provides automatic business glossary term suggestions for data assets.
* FSx (3.7.507.0)
	* S3 Access Points support for FSx for NetApp ONTAP
* GuardDuty (3.7.509.0)
	* Adding support for extended threat detection for Amazon EC2 and Amazon ECS. Adding support for wild card suppression rules.
* Lambda (3.7.508.0)
	* Launching Lambda durable functions - a new feature to build reliable multi-step applications and AI workflows natively within the Lambda developer experience.
* NovaAct (3.7.500.0)
	* Initial release of Nova Act SDK. The Nova Act service enables customers to build and manage fleets of agents for automating production UI workflows with high reliability, fastest time-to-value, and ease of implementation at scale.
* ObservabilityAdmin (3.7.505.0)
	* CloudWatch Observability Admin adds pipelines configuration for third party log ingestion and transformation of all logs ingested, integration of CloudWatch logs with S3 Tables, and AWS account or organization level enablement for 7 AWS services.
* OpenSearchServerless (3.7.504.0)
	* GPU-acceleration helps you build large-scale vector databases faster and more efficiently. You can enable this feature on new OpenSearch domains and OpenSearch Serverless collections. This feature uses GPU-acceleration to reduce the time needed to index data into vector indexes.
* OpenSearchService (3.7.505.0)
	* GPU-acceleration helps you build large-scale vector databases faster and more efficiently. You can enable this feature on new OpenSearch domains and OpenSearch Serverless collections. This feature uses GPU-acceleration to reduce the time needed to index data into vector indexes.
* RDS (3.7.510.0)
	* RDS Oracle and SQL Server: Add support for adding, modifying, and removing additional storage volumes, offering up to 256TiB storage; RDS SQL Server: Support Developer Edition via custom engine versions for development and testing purposes; M7i/R7i instances with Optimize CPU for cost savings.
* S3 (3.7.507.0)
	* New S3 Storage Class FSX_ONTAP
* S3Control (3.7.504.0)
	* Add support for S3 Storage Lens Advanced Performance Metrics, Expanded Prefixes metrics report, and export to S3 Tables.
* S3Tables (3.7.505.0)
	* Add storage class, replication, and table record expiration features to S3 Tables.
* S3Vectors (3.7.504.0)
	* Amazon S3 Vectors provides cost-effective, elastic, and durable vector storage for queries based on semantic meaning and similarity.
* SageMaker (3.7.523.0)
	* Added support for serverless MLflow Apps.

Added support for new HubContentTypes (DataSet and JsonDoc) in Private Hub for AI model customization assets, enabling tracking and management of training datasets and evaluators (reward functions/prompts) throughout the ML lifecycle.
* SavingsPlans (3.7.504.0)
	* Added support for Amazon Database Savings Plans
* SecurityHub (3.7.506.0)
	* ITSM enhancements: DRYRUN mode for testing ticket creation, ServiceNow now uses AWS Secrets Manager for credentials, ConnectorRegistrationsV2 renamed to RegisterConnectorV2, added ServiceQuotaExceededException error, and ConnectorStatus visibility in CreateConnectorV2.
* Core 3.7.500.50
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1175.0 (2025-12-01 01:44 UTC)
* AppIntegrationsService (3.7.503.0)
	* This release adds support for MCP servers via the ApplicationType field, allowing customers to register their Bedrock AgentCore gateways as third party applications.
* BedrockAgent (3.7.503.0)
	* Support audio and video ingestion on Bedrock Knowledge Bases.
* BedrockAgentRuntime (3.7.504.0)
	* Support audio and video content retrieval on Bedrock Knowledge Bases.
* CleanRooms (3.7.509.0)
	* AWS Clean Rooms now supports privacy-enhancing synthetic dataset generation for custom ML training.
* CleanRoomsML (3.7.505.0)
	* AWS Clean Rooms ML now supports privacy-enhancing synthetic dataset generation for custom ML training.
* Connect (3.7.516.0)
	* This is a combined re:Invent release for Amazon Connect.
* ConnectCampaignsV2 (3.7.504.0)
	* This release added support for new WhatsApp channel and Journey type outbound campaign
* ConnectParticipant (3.7.504.0)
	* Amazon Connect now supports message processing that intercepts and processes chat messages before they reach any participant.
* CustomerProfiles (3.7.504.0)
	* This release introduces, CRUD APIs for the DomainObjectType and Recommender resources, APIs to offer statistical insights on Object Type Attributes, Changes to SegmentDefinition APIs to support SQL queries to create Segments, and Changes to Domain APIs to support Data Store.
* EKS (3.7.507.0)
	* This release adds support for EKS Capabilities
* Glue (3.7.512.0)
	* feature: Glue: Add support for Iceberg materialized view in Glue Data Catalog, including updated CreateTable API to support materialized views and new APIs for managing data refresh for materialized views.
feature: Glue: Add support for Iceberg table encryption keys and struct field defaults.
* Lambda (3.7.507.0)
	* Launching Lambda Managed Instances - a new feature to run Lambda on EC2.
* LexModelsV2 (3.7.504.0)
	* Adds support for speech-to-speech models for human-like, adaptive, and expressive voice interactions. Also adds support for speech model preference, allowing customers to select which speech model they want to use for speech-to-text requests.
* MarketplaceAgreement (3.7.503.0)
	* This release supports 1/multi-product transactions via offer sets. DescribeAgreement and SearchAgreements APIs now return offer set IDs. SearchAgreements also supports filtering by offer set ID and 2/variable payment pricing terms will be returned through GetAgreementTerms.
* MarketplaceCatalog (3.7.503.0)
	* This release introduces offer set entity in AWS Marketplace Catalog API to enable multi-product transaction. Offer set enables sellers to group multiple private offers into a single-click purchase experience, simplifying procurement for customers purchasing multi-product solutions.
* PartnerCentralAccount (3.7.500.0)
	* Initial GA launch of Partner Central Account
* PartnerCentralBenefits (3.7.500.0)
	* Initial GA launch of Partner Central Benefits
* PartnerCentralSelling (3.7.504.0)
	* New Features:
Lead Management APIs for capturing and nurturing leads
Lead invitation support for partner collaboration
Lead-to-opportunity conversion operations
AWS Marketplace OfferSets support for opportunities
* Personalize (3.7.503.0)
	* This release adds support for includedDatasetColumns and performIncrementalUpdate in solution APIs, and rankingInfluence in campaign and batch inference APIs.
* QConnect (3.7.504.0)
	* New AIAgent types: Orchestration for ModelContextProtocol tool integration, CaseSummary for Amazon Connect Case summaries, NoteTaker for Agent Assistance notes. Added ListSpans and Retrieve APIs. Enhanced Q in Connect AssistantAssociationType to support Bring Your Own Bedrock Knowledge Bases.
* Route53GlobalResolver (3.7.500.0)
	* Add SDK for Amazon Route 53 Global Resolver, a fully managed DNS resolver service that offers broad DNS-filtering security controls.

### 3.7.1174.0 (2025-11-26 19:19 UTC)
* BedrockRuntime (3.7.511.0)
	* Bedrock Runtime Reserved Service Support
* ComputeOptimizer (3.7.503.0)
	* Compute Optimizer now identifies idle NAT Gateway resources for cost optimization based on traffic patterns and backup configuration analysis. Access recommendations via the GetIdleRecommendations API.
* CostOptimizationHub (3.7.504.0)
	* This release enables AWS Cost Optimization Hub to show cost optimization recommendations for NAT Gateway.

### 3.7.1173.0 (2025-11-25 19:22 UTC)
* EC2 (3.7.535.0)
	* This release adds support to view Network firewall proxy appliances attached to an existing NAT Gateway via DescribeNatGateways API NatGatewayAttachedAppliance structure.
* NetworkFirewall (3.7.506.0)
	* Network Firewall release of the Proxy feature.
* Organizations (3.7.508.0)
	* Add support for policy operations on the S3_POLICY and BEDROCK_POLICY policy type.
* Route53 (3.7.505.0)
	* Adds support for new route53 feature: accelerated recovery.
* Core 3.7.500.49
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1172.0 (2025-11-24 19:16 UTC)
* CloudFront (3.7.508.0)
	* Add TrustStore, ConnectionFunction APIs to CloudFront SDK
* CloudWatchLogs (3.7.505.0)
	* New CloudWatch Logs feature - LogGroup Deletion Protection, a capability that allows customers to safeguard their critical CloudWatch log groups from accidental or unintended deletion.

### 3.7.1171.0 (2025-11-21 22:36 UTC)
* APIGateway (3.7.504.0)
	* API Gateway supports VPC link V2 for REST APIs.
* Athena (3.7.502.0)
	* Introduces Spark workgroup features including log persistence, S3/CloudWatch delivery, UI and History Server APIs, and SparkConnect 3.5.6 support. Adds DPU usage limits at workgroup and query levels as well as DPU usage tracking for Capacity Reservation queries to optimize performance and costs.
* AWSMarketplaceMetering (3.7.503.0)
	* Endpoint update for new region
* Bedrock (3.7.507.0)
	* Add support to automatically enforce safeguards across accounts within an AWS Organization.
* BedrockAgentCoreControl (3.7.511.0)
	* Support for agentcore gateway interceptor configurations and NONE authorizer type
* BedrockDataAutomationRuntime (3.7.503.0)
	* Adding new fields to GetDataAutomationStatus: jobSubmissionTime, jobCompletionTime, and jobDurationInSeconds
* BedrockRuntime (3.7.510.0)
	* Add support to automatically enforce safeguards across accounts within an AWS Organization.
* CloudFormation (3.7.506.0)
	* Adds the DependsOn field to the AutoDeployment configuration parameter for CreateStackSet, UpdateStackSet, and DescribeStackSet APIs, allowing users to set and read auto-deployment dependencies between StackSets
* ComputeOptimizerAutomation (3.7.500.0)
	* Initial release of AWS Compute Optimizer Automation. Create automation rules to implement recommended actions on a recurring schedule based on your specified criteria. Supported actions include: snapshot and delete unattached EBS volumes and upgrade volume types to the latest generation.
* Connect (3.7.515.0)
	* New APIs to support aliases and versions for ContactFlowModule. Updated ContactFlowModule APIs to support custom blocks.
* ControlTower (3.7.503.0)
	* The manifest field is now optional for the AWS Control Tower CreateLandingZone and UpdateLandingZone APIs for Landing Zone version 4.0
* EC2 (3.7.534.0)
	* This release adds a new capability to create and manage interruptible EC2 Capacity Reservations.
* ECR (3.7.505.0)
	* Add support for ECR managed signing
* EKS (3.7.506.0)
	* Adds support for controlPlaneScalingConfig on EKS Clusters.
* ElasticLoadBalancingV2 (3.7.505.1)
	* This release adds the health check log feature in ALB, allowing customers to send detailed target health check log data directly to their designated Amazon S3 bucket.
* Invoicing (3.7.505.0)
	* Added the CreateProcurementPortalPreference, GetProcurementPortalPreference, PutProcurementPortalPreference, UpdateProcurementPortalPreferenceStatus, ListProcurementPortalPreferences and DeleteProcurementPortalPreference APIs for procurement portal preference management.
* KeyManagementService (3.7.505.0)
	* Support for on-demand rotation of AWS KMS Multi-Region keys with imported key material
* KinesisVideo (3.7.503.0)
	* This release adds support for Tiered Storage
* Lambda (3.7.506.0)
	* Launching Enhanced Error Handling and ESM Grouping capabilities for Kafka ESMs
* LexModelsV2 (3.7.503.0)
	* Adds support for Intent Disambiguation, allowing resolution of ambiguous user inputs when multiple intents match by presenting clarifying questions to users. Also adds Speech Detection Sensitivity configuration for optimizing voice activity detection sensitivity levels in various noise environments.
* MailManager (3.7.502.0)
	* Add support for resources in the aws-eusc partition.
* MarketplaceEntitlementService (3.7.503.0)
	* Endpoint update for new region
* MediaPackageV2 (3.7.505.0)
	* Adds support for excluding session key tags from HLS multivariant playlists
* Odb (3.7.502.0)
	* Adds AssociateIamRoleToResource and DisassociateIamRoleFromResource APIs for managing IAM roles. Enhances CreateOdbNetwork and UpdateOdbNetwork APIs with KMS, STS, and cross-region S3 parameters. Adds OCI identity domain support to InitializeService API.
* Organizations (3.7.507.0)
	* Add support for policy operations on the UPGRADE_ROLLOUT_POLICY policy type.
* QConnect (3.7.503.0)
	* This release introduces two new messaging channel subtypes: Push, WhatsApp, under MessageTemplate which is a resource in Amazon Q in Connect.
* QuickSight (3.7.507.0)
	* Amazon Quick Suite now supports QuickChat as an embedding type when calling the GenerateEmbedUrlForRegisteredUser API, enabling developers to embed conversational AI agents directly into their applications.
* RDS (3.7.509.0)
	* Add support for Upgrade Rollout Order
* Redshift (3.7.505.0)
	* Added support for Amazon Redshift Federated Permissions and AWS IAM Identity Center trusted identity propagation.
* RedshiftServerless (3.7.502.0)
	* Added UpdateLakehouseConfiguration API to manage Amazon Redshift Federated Permissions and AWS IAM Identity Center trusted identity propagation for namespaces.
* SageMaker (3.7.522.0)
	* Enhanced SageMaker HyperPod instance groups with support for MinInstanceCount, CapacityRequirements (Spot/On-Demand), and KubernetesConfig (labels and taints). Also Added speculative decoding and MaxInstanceCount for model optimization jobs.
* SecurityIR (3.7.505.0)
	* Add ListInvestigations and SendFeedback APIs to support SecurityIR AI agents
* SimpleEmailV2 (3.7.504.0)
	* Added support for new SES regions - Asia Pacific (Malaysia) and Canada (Calgary)
* Transfer (3.7.504.0)
	* Adds support for creating Webapps accessible from a VPC.
* Core 3.7.500.48
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1170.0 (2025-11-20 20:03 UTC)
* ApplicationSignals (3.7.505.0)
	* Amazon CloudWatch Application Signals now supports un-instrumented services discovery, cross-account views, and change history, helping SRE and DevOps teams monitor and troubleshoot their large-scale distributed applications.
* AutoScaling (3.7.504.0)
	* This release adds support for three new features: 1) Image ID overrides in mixed instances policy, 2) Replace Root Volume - a new strategy for Instance Refresh, and 3) Instance Lifecycle Policy for enhanced instance lifecycle management.
* BedrockAgentCore (3.7.507.0)
	* Bedrock AgentCore Memory release for redriving memory extraction jobs (StartMemoryExtractionJob and ListMemoryExtractionJob)
* BedrockDataAutomation (3.7.504.0)
	* Added support for Synchronous project type and PII Detection and Redaction
* BedrockDataAutomationRuntime (3.7.502.0)
	* Bedrock Data Automation Runtime Sync API
* Braket (3.7.504.0)
	* Add support for Braket spending limits.
* Budgets (3.7.507.0)
	* Add BillingViewHealthStatusException to DescribeBudgetPerformanceHistory and ServiceQuotaExceededException to UpdateBudget for improved error handling with Billing Views.
* CloudFront (3.7.507.0)
	* This release adds support for bring your own IP (BYOIP) to CloudFront's CreateAnycastIpList API through an optional IpamCidrConfigs field.
* CloudTrail (3.7.504.0)
	* AWS launches CloudTrail aggregated events to simplify monitoring of data events at scale. This feature delivers both granular and summarized data events for resources like S3/Lambda, helping security teams identify patterns without custom aggregation logic.
* Connect (3.7.514.0)
	* Add optional ability to exclude users from send notification actions for Contact Lens Rules.
* DatabaseMigrationService (3.7.505.0)
	* Added support for customer-managed KMS key (CMK) for encryption for import private key certificate. Additionally added Amazon SageMaker Lakehouse endpoint used for zero-ETL integrations with data warehouses.
* DataSync (3.7.504.0)
	* The partition value "aws-eusc" is now permitted for ARN (Amazon Resource Name) fields.
* DeviceFarm (3.7.503.0)
	* Add support for environment variables and an IAM execution role.
* DSQL (3.7.505.0)
	* Added clusterVpcEndpoint field to GetVpcEndpointServiceName API response, returning the VPC connection endpoint for the cluster
* EC2 (3.7.533.0)
	* This release adds support for multiple features including: VPC Encryption Control for the status of traffic flow; S2S VPN BGP Logging; TGW Flexible Costs; IPAM allocation of static IPs from IPAM pools to CF Anycast IP lists used on CloudFront distribution; and EBS Volume Integration with Recycle Bin
* ECS (3.7.506.0)
	* Launching Amazon ECS Express Mode - a new feature that enables developers to quickly launch highly available, scalable containerized applications with a single command.
* ElasticLoadBalancingV2 (3.7.505.0)
	* This release adds the target optimizer feature in ALB, enabling strict concurrency enforcement on targets.
* ElasticMapReduce (3.7.505.0)
	* Add support for configuring S3 destination for step logs on a per-step basis.
* Glue (3.7.511.0)
	* Added FunctionType parameter to Glue GetuserDefinedFunctions.
* Imagebuilder (3.7.506.0)
	* EC2 Image Builder now enables the distribution of existing AMIs, retry distribution, and define distribution workflows. It also supports automatic versioning for recipes and components, allowing automatic version increments and dynamic referencing in pipelines.
* Kinesis (3.7.505.6)
	* Kinesis Data Streams now supports up to 50 Enhance Fan-out consumers for On-demand Advantage Streams. On-demand Standard and Provisioned streams will continue with the existing limit of 20 consumers for Enhanced Fan-out.
* LakeFormation (3.7.503.0)
	* Added ServiceIntegrations as a request parameter for CreateLakeFormationIdentityCenterConfigurationRequest and UpdateLakeFormationIdentityCenterConfigurationRequest and response parameter for DescribeLakeFormationIdentityCenterConfigurationResponse
* LicenseManager (3.7.502.0)
	* Added cross-account resource aggregation via license asset groups and expiry tracking for Self-Managed Licenses. Extended Org-Wide View to Self-Managed Licenses, added reporting for license asset groups, and removed Athena/Glue dependencies for cross-account resource discovery in commercial regions.
* NetworkManager (3.7.503.0)
	* This release adds support for Cloud WAN Routing Policy providing customers sophisticated routing controls to better manage their global networks
* Organizations (3.7.506.0)
	* Added new APIs for Billing Transfer, new policy type INSPECTOR_POLICY, and allow an account to transfer between organizations
* QuickSight (3.7.506.0)
	* Introducing comprehensive theme styling controls. New features include border customization (radius, width, color), flexible padding controls, background styling for cards and sheets, centralized typography management, and visual-level override support across layouts.
* RDS (3.7.508.0)
	* Add support for VPC Encryption Controls.
* RecycleBin (3.7.503.0)
	* Add support for EBS volume in Recycle Bin
* RedshiftDataAPIService (3.7.503.0)
	* Increasing the length limit of Statement Name from 500 to 2048.
* S3 (3.7.506.0)
	* Enable / Disable ABAC on a general purpose bucket.
* SageMaker (3.7.521.0)
	* Added training plan support for inference endpoints. Added HyperPod task governance with accelerator partition-based quota allocation. Added BatchRebootClusterNodes and BatchReplaceClusterNodes APIs. Updated ListClusterNodes to include privateDnsHostName.
* SecurityHub (3.7.505.0)
	* Release Findings and Resources Trends APIs- GetFindingsTrendsV2 and GetResourcesTrendsV2. This supports time-series aggregated counts with composite filtering for 1-year of historical data analysis of Findings and Resources.
* Core 3.7.500.47
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1169.0 (2025-11-19 22:54 UTC)
* APIGateway (3.7.503.0)
	* API Gateway now supports response streaming and new security policies for REST APIs and custom domain names.
* ApiGatewayV2 (3.7.503.0)
	* Support for API Gateway portals and portal products.
* AWSHealth (3.7.502.0)
	* Adds actionability and personas properties to Health events exposed through DescribeEvents, DescribeEventsForOrganization, DescribeEventDetails, and DescribeEventTypes APIs. Adds filtering by actionabilities and personas in EventFilter, OrganizationEventFilter, EventTypeFilter.
* Backup (3.7.508.0)
	* Amazon GuardDuty Malware Protection now supports AWS Backup, extending malware detection capabilities to EC2, EBS, and S3 backups.
* BCMPricingCalculator (3.7.503.0)
	* Add GroupSharingPreference, CostCategoryGroupSharingPreferenceArn, and CostCategoryGroupSharingPreferenceEffectiveDate to Bill Estimate. Add GroupSharingPreference and CostCategoryGroupSharingPreferenceArn to Bill Scenario.
* BedrockRuntime (3.7.509.0)
	* This release includes support for Search Results.
* Billing (3.7.505.0)
	* Added name filtering support to ListBillingViews API through the new names parameter to efficiently filter billing views by name.
* BillingConductor (3.7.503.0)
	* This release adds support for Billing Transfers, enabling management of billing transfers with billing groups on AWS Billing Conductor.
* CloudTrail (3.7.503.0)
	* AWS CloudTrail now supports Insights for data events, expanding beyond management events to automatically detect unusual activity on data plane operations.
* CloudWatchLogs (3.7.504.0)
	* Adding support for ocsf version 1.5, add optional parameter MappingVersion
* CloudWatchRUM (3.7.503.0)
	* CloudWatch RUM now supports mobile application monitoring for Android and iOS platforms
* ConnectCampaignsV2 (3.7.503.0)
	* This release added support for ring timer configuration for campaign calls.
* CostExplorer (3.7.506.0)
	* Add support for COST_CATEGORY, TAG, and LINKED_ACCOUNT AWS managed cost anomaly detection monitors
* CostOptimizationHub (3.7.503.0)
	* Release ListEfficiencyMetrics API
* DataZone (3.7.512.0)
	* Amazon DataZone now supports business metadata (readme and metadata forms) at the individual attribute (column) level, a new rule type for glossary terms, and the ability to update the owner of the root domain unit.
* DynamoDBv2 (3.7.509.0)
	* Extended Global Secondary Index (GSI) composite keys to support up to 8 attributes.
* EC2 (3.7.532.0)
	* This launch adds support for two new features: Regional NAT Gateway and IPAM Policies. IPAM policies offers customers central control for public IPv4 assignments across AWS services. Regional NAT is a single NAT Gateway that automatically expands across AZs in a VPC to maintain high availability.
* ECR (3.7.504.0)
	* Add support for ECR archival storage class and Inspector org policy for scanning
* ECS (3.7.505.0)
	* Added support for Amazon ECS Managed Instances infrastructure optimization configuration.
* ElasticMapReduce (3.7.504.0)
	* Add CloudWatch Logs integration for Spark driver, executor and step logs
* FSx (3.7.506.0)
	* Adding File Server Resource Manager configuration to FSx Windows
* GuardDuty (3.7.508.0)
	* Add support for scanning and viewing scan results for backup resource types
* IdentityManagement (3.7.506.0)
	* Added the EnableOutboundWebIdentityFederation, DisableOutboundWebIdentityFederation and GetOutboundWebIdentityFederationInfo APIs for the IAM outbound federation feature.
* Inspector2 (3.7.504.0)
	* This release introduces BLOCKED_BY_ORGANIZATION_POLICY error code and IMAGE_ARCHIVED scanStatusReason. BLOCKED_BY_ORGANIZATION_POLICY error code is returned when an operation is blocked by an AWS Organizations policy. IMAGE_ARCHIVED scanStatusReason is returned when an Image is archived in ECR.
* Invoicing (3.7.504.0)
	* Add support for adding Billing transfers in Invoice configuration
* Lambda (3.7.505.0)
	* Added support for creating and invoking Tenant Isolated functions in AWS Lambda APIs.
* MediaConnect (3.7.504.0)
	* This release adds support for global routing in AWS Elemental MediaConnect. You can now use router inputs and router outputs to manage global video and audio routing workflows both within the AWS-Cloud and over the public internet.
* MediaLive (3.7.509.0)
	* MediaLive is adding support for MediaConnect Router by supporting a new input type called MEDIACONNECT_ROUTER. This new input type will provide seamless encrypted transport between MediaConnect Router and your MediaLive channel.
* NetworkFirewall (3.7.505.0)
	* Partner Managed Rulegroup feature support
* NetworkFlowMonitor (3.7.504.0)
	* Added new enum value (AWS::EKS::Cluster) for type field under MonitorLocalResource
* PartnerCentralChannel (3.7.500.0)
	* Initial GA launch of Partner Central Channel
* Route53 (3.7.504.0)
	* Add dual-stack endpoint support for Route53
* S3 (3.7.505.0)
	* Adds support for blocking SSE-C writes to general purpose buckets.
* SageMaker (3.7.520.0)
	* Added support for enhanced metrics for SageMaker AI Endpoints. This features provides Utilization Metrics at instance and container granularity and also provides easy configuration of metric publish frequency from 10 sec -> 5 mins
* SecretsManager (3.7.503.0)
	* Adds support to create, update, retrieve, rotate, and delete managed external secrets.
* SecurityToken (3.7.504.0)
	* IAM now supports outbound identity federation via the STS GetWebIdentityToken API, enabling AWS workloads to securely authenticate with external services using short-lived JSON Web Tokens.
* Signin (3.7.500.0)
	* AWS Sign-In manages authentication for AWS services. This service provides secure authentication flows for accessing AWS resources from the console and developer tools. This release adds the CreateOAuth2Token API, which can be used to fetch OAuth2 access tokens and refresh tokens from Sign-In.
* StepFunctions (3.7.502.0)
	* Adds support to TestState for mocked results and exceptions, along with additional inspection data.
* Core 3.7.500.46
	* Added support for LoginAWSCredentials.
	* Updated generator to support TFM based conditions in ItemGroup while adding project package references defined for various targets in service model metadata.json.
	* All services packages updated to require new Core

### 3.7.1168.0 (2025-11-18 19:28 UTC)
* AutoScaling (3.7.503.0)
	* This release adds the new LaunchInstances API, which can launch instances synchronously in an AutoScaling group. The API also returns instances info and launch error back immediately.
* Backup (3.7.507.0)
	* AWS Backup now supports a low-cost warm storage tier for Amazon S3 backup data.
* BedrockRuntime (3.7.508.0)
	* Amazon Bedrock Runtime Service Tier Support Launch
* CloudFormation (3.7.505.0)
	* New CloudFormation DescribeEvents API with operation ID tracking and failure filtering capabilities to quickly identify root causes of deployment failures. Also, a DeploymentMode parameter for the CreateChangeSet API that enables creation of drift-aware change sets for safe drift management.
* CloudWatchLogs (3.7.503.0)
	* CloudWatch Logs updates: Added capability to setup a recurring schedule for log insights queries. Logs introduced Scheduled Queries (managed through Create/Update/Get/Delete/List/History Scheduled Query APIs). For more information, see CloudWatch Logs API documentation.
* Connect (3.7.513.0)
	* This release added support for ring timer configuration for campaign calls.
* EC2 (3.7.531.0)
	* AWS Site-to-Site VPN now supports VPN Concentrator, a new feature that enables customers to connect multiple low-bandwidth sites connections through a single attachment, simplifying multi-site connectivity for distributed enterprises.
* IdentityManagement (3.7.505.0)
	* Added the AssociateDelegationRequest, GetDelegationRequest, AcceptDelegationRequest, RejectDelegatonRequest, ListDelegationRequests, UpdateDelegationRequest, SendDelegationToken and GetHumanReadableSummary APIs for the IAM temporary delegation feature.
* Kafka (3.7.504.0)
	* Amazon MSK adds three new APIs, ListTopics, DescribeTopic, and DescribeTopicPartitions for viewing Kafka topics in your MSK clusters.
* ResourceGroupsTaggingAPI (3.7.502.0)
	* Add support for new ListRequiredTags API used to retrieve the required tags specified in a customer's effective tag policy.
* StorageGateway (3.7.502.0)
	* Adds support for European Sovereign Cloud ARNs in Storage Gateway API parameters.
* WAFV2 (3.7.504.0)
	* AssociateWebACL, UpdateWebACL and PutLoggingConfiguration will now throw WAFFeatureNotIncludedInPricingPlanException when the request contains a feature that is not included in the CloudFront pricing plan of the WebACL.
* Core 3.7.500.45
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1167.0 (2025-11-17 20:14 UTC)
* AppStream (3.7.504.0)
	* Adding support for additional instances and extended storage
* Backup (3.7.506.0)
	* AWS Backup now supports specifying a logically air-gapped backup vault as a primary backup target in backup plans and on-demand backup jobs.
* Bedrock (3.7.506.0)
	* Automated Reasoning checks in Amazon Bedrock Guardrails now automatically generate Q&A tests for new Automated Reasoning policies. The GetAutomatedReasoningPolicyBuildWorkflowResultAssets API adds GENERATED_TEST_CASES asset type, allowing customers to retrieve tests generated by the build workflow.
* DatabaseMigrationService (3.7.504.0)
	* This release introduces the SAP ASE(Sybase) Data Provider for AWS Data Migration Service (DMS). In addition, DMS Schema Conversion now supports this provider, enabling customers to migrate SAP ASE(Sybase) databases to Amazon RDS for PostgreSQL or Aurora PostgreSQL seamlessly.
* DeviceFarm (3.7.502.0)
	* This release adds support for interacting with devices during a remote access session using the remoteDriverEndpoint interface
* EC2 (3.7.530.0)
	* This release introduces new APIs: DescribeInstanceSqlHaStates, DescribeInstanceSqlHaHistoryStates, EnableInstanceSqlHaStandbyDetections and DisableInstanceSqlHaStandbyDetections on Amazon EC2, allowing customers to enroll and monitor SQL Server licensing fee savings for their SQL HA EC2 instances.
* Glue (3.7.510.0)
	* Amazon Glue Releasing 2 the new API ListIntegrationResourceProperties and DeleteIntegrationResourceProperty along with minor improvement on existing API(s).
* GuardDuty (3.7.507.0)
	* Add S3 On-Demand Object Scanning
* LexModelsV2 (3.7.502.0)
	* Adds support for LLM as Primary, allowing usage of LLMs as the default NLU system.
* MediaLive (3.7.508.0)
	* Adds configurations for spatial/temporal adaptive quantization in AV1 codec, and conversion to HLG output color space in H265 codec.
* MediaPackageV2 (3.7.504.0)
	* Add support for SCTE messages in Segment file output
* MWAAServerless (3.7.500.0)
	* Amazon MWAA now offers serverless deployment, eliminating operational overhead while optimizing costs. The service supports YAML and Python-based workflows, with 80+ AWS Operators. It provides isolated execution, IAM permissions, and automatic scaling with pay-per-use pricing.
* OpenSearchService (3.7.504.0)
	* This release adds index operation APIs to support Automatic Semantic Enrichment feature
* PCS (3.7.507.0)
	* Added support for the managed Slurm REST API endpoint
* Route53Resolver (3.7.503.0)
	* Adding DICTIONARY_DGA to dns-threat-protection as a new enum type. Customers can now set rules for dictionary dga protection

### 3.7.1166.0 (2025-11-14 19:29 UTC)
* DataZone (3.7.511.0)
	* Adds support for granting read and write access to Amazon S3 general purpose buckets using CreateSubscriptionRequest and AcceptSubscriptionRequest APIs. Also adds search filters for SSOUser and SSOGroup to ListSubscriptions APIs and deprecates "sortBy" parameter for ListSubscriptions APIs.
* EC2 (3.7.529.0)
	* This release adds AvailabilityZoneId support for CreateInstanceConnectEndpoint, DescribeInstanceConnectEndpoints, and DeleteInstanceConnectEndpoint APIs.
* Imagebuilder (3.7.505.0)
	* EC2 Image Builder now supports invoking Lambda functions and executing Step Functions state machine through image workflows.
* MediaLive (3.7.507.0)
	* Removed all the value constraint (min/max) for the shape definitions (e.g. integerMin0Max3600) on the C2j models to get rid of the need to request an exemption from the SDK team whenever a shape definition (e.g. integerMin0Max3600) is changed.
* Core 3.7.500.44
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1165.0 (2025-11-13 19:40 UTC)
* CloudFormation (3.7.504.0)
	* CloudFormation now supports GetHookResult API with annotations to retrieve structured compliance check results and remediation guidance for each evaluated resource, replacing the previous single-message limitation with detailed validation outcomes.
* ControlCatalog (3.7.503.0)
	* Added support for related control mappings with new RELATED_CONTROL mapping type in ListControlMappings API.
* EC2 (3.7.528.0)
	* Added support for new accelerator types ("media") and accelerator names ("L4", "L40s", "GAUDI_HL_205", "INFERENTIA2", "TRAINIUM", "TRAINIUM2", "U30") in Attributes Based Instance Type Selection for launched instance types.
* ECR (3.7.503.0)
	* Add Amazon ECR FIPS PrivateLink endpoint support
* ElasticLoadBalancingV2 (3.7.504.0)
	* QUIC and TCP_QUIC protocol support for Network Load Balancer (NLB). This capability enables customers to forward QUIC traffic to their targets with ultra-low latency while maintaining session stickiness using QUIC Connection IDs.
* IoTWireless (3.7.503.0)
	* Integration of Device Location with Amazon Sidewalk network for Amazon Sidewalk enabled devices
* MediaConvert (3.7.505.0)
	* Lowers minimum duration for black video generator. Adds support for embedding and signing C2PA content credentials in DASH and CMAF HLS outputs.
* RDS (3.7.507.0)
	* Updated endpoint and service metadata
* SageMaker (3.7.519.0)
	* Added support for minor version upgrades and AWS Identity Center integration for SageMaker Hadron Partner Apps, enabling automated version management and IdC group-based access control.
* WorkSpacesWeb (3.7.503.0)
	* Support for managing web content filtering for defining, tracking and regulating type of content accessed with WorkSpaces Secure Browser as part of browser settings.

### 3.7.1164.0 (2025-11-12 19:42 UTC)
* Connect (3.7.512.0)
	* Updated Authentication Profile APIs to add support for automatic logout on user inactivity
* DatabaseMigrationService (3.7.503.0)
	* Added support of SQL statements creation, metadata model discovery and selection rules transformation.
* EC2 (3.7.527.0)
	* Adds complete AMI ancestry tracing from immediate parent through each preceding generation back to the root AMI
* ElasticLoadBalancingV2 (3.7.503.0)
	* This release expands ALB Authentication to support JWT verification and adds support for a new JWT validation action in listener rule.
* PrometheusService (3.7.506.0)
	* Add VPC source configuration support enabling Amazon Managed Service for Prometheus Collector to collect metrics from MSK clusters.
* Redshift (3.7.504.0)
	* Added GetIdentityCenterAuthToken API to retrieve encrypted authentication tokens for Identity Center integrated applications. This API enables programmatic access to secure Identity Center tokens with proper error handling and parameter validation across supported SDK languages.
* S3Tables (3.7.504.0)
	* Adds support for request metrics metrics APIs for S3 Tables
* SageMaker (3.7.518.0)
	* Add support for trn2.3xlarge instance type for SageMaker Hyperpod

### 3.7.1163.0 (2025-11-11 19:23 UTC)
* Batch (3.7.501.11)
	* Documentation-only update: update API and doc descriptions per EKS ImageType default value switch from AL2 to AL2023.
* BedrockDataAutomation (3.7.503.0)
	* Added support for Language Expansion feature for BDA Audio modality.
* EC2 (3.7.526.0)
	* AWS Site-to-Site VPN now supports VPN connections with up to 5 Gbps bandwidth per tunnel, a 4x improvement from existing limit of 1.25 Gbps.
* MedicalImaging (3.7.504.0)
	* Added new fields in existing APIs.
* RTBFabric (3.7.502.0)
	* Added LogSettings and LinkAttribute fields to external links
* SecurityIR (3.7.504.0)
	* Added support for configuring communication preferences as well as clearly displaying case comment author identities.

### 3.7.1162.0 (2025-11-10 19:38 UTC)
* ACMPCA (3.7.503.0)
	* Private Certificate Authority service now supports ML-DSA key algorithms.
* AppStream (3.7.503.0)
	* AWS Appstream support for IPv6
* Backup (3.7.505.0)
	* AWS Backup supports backups of Amazon EKS clusters, including Kubernetes cluster state and persistent storage attached to the EKS cluster via a persistent volume claim (EBS volumes, EFS file systems, and S3 buckets).
* Braket (3.7.503.0)
	* Adds ExperimentalCapabilities field to CreateQuantumTask request and GetQuantumTask response objects. Enables use of experimental software capabilities when creating quantum tasks.
* DataZone (3.7.510.0)
	* Remove trackingServerName from DataZone Connection MLflowProperties
* DSQL (3.7.504.0)
	* Cluster endpoint added to CreateCluster and GetCluster API responses
* EC2 (3.7.525.0)
	* Amazon EC2 Fleet customers can now filter instance types based on encryption-in-transit support using Attribute-Based Instance Type Selection (ABIS), eliminating the manual effort of identifying and selecting compatible instance types for security-sensitive workloads.
* GuardDuty (3.7.506.0)
	* Include tags filed in CreatePublishingDestinationRequest and DescribePublishingDestinationResponse.
* IdentityManagement (3.7.504.0)
	* Added CreateDelegationRequest API, which is not available for general use at this time.
* Invoicing (3.7.503.0)
	* Added new invoicing get-invoice-pdf API Operation
* Kafka (3.7.503.0)
	* Amazon MSK now supports intelligent rebalancing for MSK Express brokers.
* SecurityToken (3.7.503.0)
	* Added GetDelegatedAccessToken API, which is not available for general use at this time.
* VerifiedPermissions (3.7.504.0)
	* Amazon Verified Permissions / Features : Adds support for entity Cedar tags.
* WAFV2 (3.7.503.0)
	* AWS WAF now supports CLOUDWATCH_TELEMETRY_RULE_MANAGED as a LogScope option, enabling automated logging configuration through Amazon CloudWatch Logs for telemetry data collection and analysis.

### 3.7.1161.0 (2025-11-07 19:22 UTC)
* ControlTower (3.7.502.0)
	* Added Parent Identifier support to ListEnabledControls and GetEnabledControl API. Implemented RemediationType support for Landing Zone operations: CreateLandingZone, UpdateLandingZone and GetLandingZone APIs
* EC2 (3.7.524.0)
	* Adds PrivateDnsPreference and PrivateDnsSpecifiedDomains to control private DNS resolution for resource and service network VPC endpoints and IpamScopeExternalAuthorityConfiguration to integrate Amazon VPC IPAM with a third-party IPAM service
* KeyManagementService (3.7.504.0)
	* Added support for new ECC_NIST_EDWARDS25519 AWS KMS key spec
* OpenSearchService (3.7.503.0)
	* This release introduces the Default Application feature, allowing users to set, change, or unset a preferred OpenSearch UI application on a per-region basis for a streamlined and consistent user experience.
* VPCLattice (3.7.504.0)
	* Amazon VPC Lattice now supports custom domain name for resource configurations

### 3.7.1160.0 (2025-11-06 19:55 UTC)
* AccessAnalyzer (3.7.503.0)
	* New field totalActiveErrors added to getFindingsStatistics response.
* Backup (3.7.504.0)
	* AWS Backup now supports customer-managed keys (CMK) for logically air-gapped vaults, enabling customers to maintain full control over their encryption key lifecycle. This feature helps organizations meet specific internal governance requirements or external regulatory compliance standards.
* Connect (3.7.511.0)
	* Added support for Conditional Questions in Evaluation Forms. Introduced Auto Evaluation capability for Evaluation Forms and Contact Evaluations. Added new API operations: SearchEvaluationForms and SearchContactEvaluations.
* EC2 (3.7.523.0)
	* Add Amazon EC2 R8a instance types
* GameLift (3.7.503.0)
	* Amazon GameLift Servers now supports game builds that use the Windows 2022 operating system.
* IdentityStore (3.7.503.0)
	* IdentityStore API: added new KMSExceptionReason fields to the Exception object; added multiple new fields to the User APIs - UserStatus, Birthdate, Website and Photos; added multiple new metadata fields for User, Groups and Membership APIs - CreatedAt, CreatedBy, UpdatedAt and UpdatedBy.
* QuickSight (3.7.505.0)
	* Support for New Data Prep Experience
* S3Tables (3.7.503.0)
	* Adds support for tagging APIs for S3 Tables
* S3Vectors (3.7.503.0)
	* Amazon S3 Vectors provides cost-effective, elastic, and durable vector storage for queries based on semantic meaning and similarity.
* SageMaker (3.7.517.0)
	* Added NodeProvisioningMode parameter to UpdateCluster API to determine how instance provisioning is handled during cluster operations; in Continuous mode. Added VpcId field in UpdateDomain request for SageMaker Unified Studio domains with no VPC to add a customer VPC.
* SimpleSystemsManagement (3.7.504.0)
	* Provides NoLongerSupportedException error message
* Core 3.7.500.43
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1159.0 (2025-11-05 19:25 UTC)
* CloudFront (3.7.506.0)
	* This release adds new and updated API operations. You can now use the IpAddressType field to specify either ipv4 or dualstack for your Anycast static IP list. You can also enable cross-account resource sharing to share your VPC origins with other AWS accounts
* DataZone (3.7.509.0)
	* Added support for Project Resource Tags
* EC2 (3.7.522.0)
	* This release adds AvailabilityZoneId support for DescribeFastSnapshotRestores, DisableFastSnapshotRestores, and EnableFastSnapshotRestores APIs.
* FSx (3.7.505.0)
	* Amazon FSx now enables secure management of Active Directory credentials through AWS Secrets Manager integration. Customers can use Secret ARNs instead of direct credentials when joining resources to Active Directory domains.
* GroundStation (3.7.502.0)
	* Introduce CreateDataflowEndpointGroupV2 action
* S3 (3.7.504.0)
	* Launch IPv6 dual-stack support for S3 Express
* SageMaker (3.7.516.0)
	* Add new fields in SageMaker Hyperpod DescribeCluster API response: TargetStateCount, SoftwareUpdateStatus and ActiveSoftwareDeploymentConfig to provide AMI update progress visibility .

### 3.7.1158.0 (2025-11-04 19:19 UTC)
* PinpointSMSVoiceV2 (3.7.504.0)
	* This release adds support for the CarrierLookup API, which returns information about a destination phone number including if the number is valid, the carrier, and more.
* Core 3.7.500.42
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1157.0 (2025-11-03 19:32 UTC)
* Account (3.7.502.6)
	* Rename internal exception property to avoid hiding inherited AmazonServiceException member.
* BedrockAgentCoreControl (3.7.510.0)
	* Adds support for direct code deploy with CreateAgentRuntime and UpdateAgentRuntime
* Budgets (3.7.506.0)
	* Fix the AWS Budgets endpoint for the aws-eusc partition.
* EC2 (3.7.521.0)
	* Add Amazon EC2 trn2.3xlarge instance type.
* ECS (3.7.504.2)
	* Documentation-only update for LINEAR and CANARY deployment strategies.
* Kinesis (3.7.505.0)
	* Adds support for MinimumThroughputBillingCommitment with new UpdateAccountSettings API. Adds support to configure warm throughput for on-demand streams in new UpdateStreamWarmThroughput API and existing CreateStream API and UpdateStreamMode API.

### 3.7.1156.0 (2025-10-31 18:55 UTC)
* AWSHealth (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudWatchLogs (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ConnectCases (3.7.505.0)
	* Added two new case rule types: Parent Child Field Options (restricts child field options based on parent field value) and Hidden (controls child field visibility based on parent field value). Both enable dynamic field behavior within templates.
* EC2 (3.7.520.0)
	* Amazon VPC IP Address Manager (IPAM) now supports automated prefix list management, allowing you to create rules that automatically populate customer-managed prefix lists with CIDRs from your IPAM pools or AWS resources based on tags, Regions, or other criteria.
* ElasticMapReduce (3.7.503.0)
	* Update endpoint ruleset parameters casing
* FMS (3.7.502.0)
	* Update endpoint ruleset parameters casing
* FSx (3.7.504.0)
	* Update endpoint ruleset parameters casing
* Kinesis (3.7.504.0)
	* Update endpoint ruleset parameters casing
* Lambda (3.7.504.0)
	* Add Python3.14 (python3.14) and Java 25 (java25) support to AWS Lambda
* MarketplaceCatalog (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaConvert (3.7.504.0)
	* Adds SlowPalPitchCorrection to audio pitch correction settings. Enables opacity for VideoOverlays. Adds REMUX_ALL option to enable multi-rendition passthrough to VideoSelector for allow listed accounts.
* Omics (3.7.504.0)
	* Added WDL_LENIENT engine type that enables implicit typecasting of variable values to its compatible declared types
* PaymentCryptography (3.7.505.0)
	* Allow additional characters in the CertificateSubject for GetCertificateSigningRequest API.
* Redshift (3.7.503.0)
	* Update endpoint ruleset parameters casing
* ResourceGroupsTaggingAPI (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SageMaker (3.7.515.0)
	* Allow update of platform identifier via UpdateNotebookInstance operation.
* SavingsPlans (3.7.503.0)
	* Add dual-stack endpoint support for Savings Plans
* Snowball (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SSMQuickSetup (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Textract (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WAF (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.41
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1155.0 (2025-10-30 19:24 UTC)
* APIGateway (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppConfig (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Appflow (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ApplicationCostProfiler (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppMesh (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppSync (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Artifact (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AuditManager (3.7.503.0)
	* Update endpoint ruleset parameters casing
* BedrockAgent (3.7.502.0)
	* Update endpoint ruleset parameters casing
* BedrockAgentCoreControl (3.7.509.0)
	* Web-Bot-Auth support for AgentCore Browser tool to help reduce captcha challenges.
* Chime (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CleanRooms (3.7.508.0)
	* Added support for advanced Spark configurations to optimize SQL performance
* CloudControlApi (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudDirectory (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CloudSearch (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudWatch (3.7.504.0)
	* Update endpoint ruleset parameters casing
* CodeCatalyst (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CodeCommit (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CodeDeploy (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CognitoSync (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ComputeOptimizer (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ConnectCases (3.7.504.0)
	* Update endpoint ruleset parameters casing
* Deadline (3.7.503.0)
	* Update endpoint ruleset parameters casing
* DevOpsGuru (3.7.501.0)
	* Update endpoint ruleset parameters casing
* DocDB (3.7.504.0)
	* Adding FailoverState and TagList to GlobalCluster and SynchronizationStatus to GlobalClusterMember.
* ECS (3.7.504.0)
	* Amazon ECS Service Connect now supports Envoy access logs, providing deeper observability into request-level traffic patterns and service interactions.
* EKSAuth (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ElastiCache (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EMRServerless (3.7.502.0)
	* This release adds the capability to enable User Background Sessions for customers running Trusted Identity Propagation enabled Interactive Sessions on EMR Serverless Applications.
* FraudDetector (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GeoPlaces (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Glue (3.7.509.0)
	* This release adds the capability to enable User Background Sessions for customers running Trusted Identity Propagation enabled Interactive Sessions on AWS Glue.
* GreengrassV2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTEventsData (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTManagedIntegrations (3.7.503.0)
	* Add a new GetManagedThingCertificate API to expose Iot ManagedIntegrations (MI) device certificate, and add  "-"  support for name, properties, actions and events in the CapabilityReportCapability object.
* KeyManagementService (3.7.503.0)
	* Add cross account VPC endpoint service connectivity support to CustomKeyStore.
* KeyspacesStreams (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KinesisFirehose (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LicenseManagerLinuxSubscriptions (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MarketplaceReporting (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Neptune (3.7.503.0)
	* Update endpoint ruleset parameters casing
* PrometheusService (3.7.505.0)
	* Add Anomaly Detection APIs for Amazon Managed Prometheus
* RTBFabric (3.7.501.3)
	* RTB Fabric documentation update.
* S3Outposts (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SageMakerRuntime (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Schemas (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SecurityToken (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ServerlessApplicationRepository (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ServiceCatalog (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SSO (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.40
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1154.0 (2025-10-29 20:22 UTC)
* BedrockRuntime (3.7.507.0)
	* Add support for system tool and web citation response.
* SecurityToken (3.7.501.31)
	* Security Fix for .NET Framework 4.5 and 4.5.1 disabling the XML resolver for SAML Assertions to prevent XML External Entity (XXE) injection vulnerability

### 3.7.1153.0 (2025-10-28 19:23 UTC)
* ApiGatewayV2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApplicationSignals (3.7.504.0)
	* Added support for CloudWatch Synthetics Canary resources in ListAuditFindings API. This enhancement allows customers to retrieve audit findings specifically for CloudWatch Synthetics canaries and enables service-canary correlation analysis.
* AppRegistry (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppTest (Removed)
	* AWS AppTest has been removed from the SDK because it has been discontinued.
* BackupSearch (3.7.503.0)
	* Update endpoint ruleset parameters casing
* BCMPricingCalculator (3.7.502.0)
	* Update endpoint ruleset parameters casing
* BedrockAgentRuntime (3.7.503.0)
	* Update endpoint ruleset parameters casing
* BedrockRuntime (3.7.506.0)
	* Update endpoint ruleset parameters casing
* CleanRoomsML (3.7.504.0)
	* Update endpoint ruleset parameters casing
* Cloud9 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CloudSearchDomain (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CloudWatchEvents (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CodeConnections (3.7.503.0)
	* Update endpoint ruleset parameters casing
* CodeGuruSecurity (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Detective (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EC2 (3.7.519.0)
	* This released the DescribeCapacityReservationTopology API.
* ECS (3.7.503.0)
	* Amazon ECS supports native linear and canary service deployments, allowing you to shift traffic in increments for more control.
* ElasticFileSystem (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ElasticTranscoder (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EMRContainers (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GameLiftStreams (3.7.504.0)
	* Add stream group expiration date and expired status
* Glacier (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GroundStation (3.7.501.0)
	* Enable use of AzEl ephemerides
* InspectorScan (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTFleetHub (Removed)
	* AWS IoTFleetHub has been removed from the SDK because it has been discontinued.
* KafkaConnect (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Kendra (3.7.501.0)
	* Update endpoint ruleset parameters casing
* KinesisVideo (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Lambda (3.7.503.0)
	* Added SerializedRequestEntityTooLargeException to Lambda Invoke API
* LookoutforVision (Removed)
	* AWS LookoutforVision has been removed from the SDK because it has been discontinued.
* LookoutMetrics (Removed)
	* AWS LookoutMetrics has been removed from the SDK because it has been discontinued.
* MarketplaceDeployment (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaPackageVod (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MigrationHubOrchestrator (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Notifications (3.7.503.0)
	* Update endpoint ruleset parameters casing
* OpenSearchService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Organizations (3.7.505.0)
	* Added Account State field to the ListDelegatedAdministrators API response.
* PartnerCentralSelling (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Pipes (3.7.502.0)
	* Update endpoint ruleset parameters casing
* QLDB (Removed)
	* AWS QLDB has been removed from the SDK because it has been discontinued.
* QLDBSession (Removed)
	* AWS QLDBSession has been removed from the SDK because it has been discontinued.
* RAM (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ResourceGroups (3.7.502.0)
	* Update endpoint ruleset parameters casing
* RoboMaker (Removed)
	* AWS RoboMaker has been removed from the SDK because it has been discontinued.
* S3 (3.7.503.0)
	* Amazon Simple Storage Service / Features: Add conditional writes in CopyObject on destination key to prevent unintended object modifications.
* S3Control (3.7.503.0)
	* Update endpoint ruleset parameters casing
* SageMaker (3.7.514.0)
	* Amazon SageMaker now supports deleting training and processing jobs in a terminal status.
* SageMakerFeatureStoreRuntime (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SecurityIR (3.7.503.0)
	* Update endpoint ruleset parameters casing
* SQS (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SupportApp (3.7.501.0)
	* Update endpoint ruleset parameters casing
* TaxSettings (3.7.501.0)
	* Update endpoint ruleset parameters casing
* TrustedAdvisor (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WorkSpaces (3.7.504.0)
	* Added IPv6 address support for WorkSpaces using Dual-Stack subnets
* WorkspacesInstances (3.7.502.0)
	* Update endpoint ruleset parameters casing
* XRay (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.39
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1152.0 (2025-10-27 19:24 UTC)
* AccessAnalyzer (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AIOps (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Athena (3.7.501.0)
	* Update endpoint ruleset parameters casing
* BackupGateway (3.7.502.0)
	* Update endpoint ruleset parameters casing
* BedrockDataAutomation (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Braket (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ChimeSDKIdentity (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ChimeSDKMediaPipelines (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CodeArtifact (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CodeGuruProfiler (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CognitoIdentityProvider (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Comprehend (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ConnectCampaignService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ControlTower (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CostExplorer (3.7.505.0)
	* Updated endpoint for eusc-de-east-1 region.
* CostOptimizationHub (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DAX (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ElasticBeanstalk (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EntityResolution (3.7.503.0)
	* Update endpoint ruleset parameters casing
* ForecastService (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Greengrass (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IdentityManagement (3.7.503.0)
	* Fixed missing SummaryMap keys in GetAccountSummary response that were being filtered out during deserialization in AWS Java SDK v2
* Invoicing (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Kinesis (3.7.503.0)
	* Adds support for record sizes up to 10MiB and introduces new UpdateMaxRecordSize API to modify stream record size limits. Adds record size parameters to existing CreateStream and DescribeStreamSummary APIs for request and response payloads respectively.
* LaunchWizard (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Lex (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ManagedBlockchain (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MTurk (3.7.502.0)
	* Update endpoint ruleset parameters casing
* NeptuneGraph (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Outposts (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Pinpoint (3.7.502.0)
	* Update endpoint ruleset parameters casing
* RDSDataService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* RecycleBin (3.7.502.0)
	* Update endpoint ruleset parameters casing
* RedshiftServerless (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Rekognition (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Repostspace (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Route53Profiles (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Route53Resolver (3.7.502.0)
	* Update endpoint ruleset parameters casing
* S3 (3.7.502.0)
	* Update `PutObject` and `UploadPart` requests to include the `Content-Encoding` header when the [request payload is transferred in multiple chunks](https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-streaming.html)
* S3Vectors (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Scheduler (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SecretsManager (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Shield (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SimpleEmail (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SimSpaceWeaver (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SocialMessaging (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SsmSap (3.7.503.0)
	* Update endpoint ruleset parameters casing
* SSOAdmin (3.7.503.0)
	* Update endpoint ruleset parameters casing
* StepFunctions (3.7.501.0)
	* Update endpoint ruleset parameters casing
* WAFRegional (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WorkMailMessageFlow (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.38
	* Update SDK to include `aws-chunked` in the `Content-Encoding` header when the [request payload is transferred in multiple chunks](https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-streaming.html)
	* All services packages updated to require new Core

### 3.7.1151.0 (2025-10-24 19:14 UTC)
* AmplifyUIBuilder (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApplicationSignals (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Billing (3.7.504.0)
	* Update endpoint ruleset parameters casing
* Budgets (3.7.505.0)
	* Update endpoint ruleset parameters casing
* CertificateManager (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ChimeSDKMessaging (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CloudTrail (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CodePipeline (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ConnectWisdomService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DataPipeline (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DataZone (3.7.508.0)
	* This release adds support for MLflow connections Creation in DataZone
* DocDB (3.7.503.0)
	* Update endpoint ruleset parameters casing
* DynamoDBv2 (3.7.508.0)
	* Update endpoint ruleset parameters casing
* EKS (3.7.505.0)
	* Update endpoint ruleset parameters casing
* ElasticLoadBalancing (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Evs (3.7.504.0)
	* Update endpoint ruleset parameters casing
* FIS (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GameLiftStreams (3.7.503.0)
	* Add status reasons for TERMINATED stream sessions
* GeoMaps (3.7.503.0)
	* Added support for optional AdditionalFeatures parameter in the V2 GetTile API.
* Inspector (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTManagedIntegrations (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTWireless (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KinesisAnalytics (3.7.501.0)
	* Update endpoint ruleset parameters casing
* KinesisVideoSignalingChannels (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LocationService (3.7.502.0)
	* Added support for mobile app restrictions in Amazon Location API keys.
* LookoutforVision (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaPackage (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaStore (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MediaStoreData (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MigrationHubStrategyRecommendations (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MQ (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Panorama (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PaymentCryptography (3.7.504.0)
	* Update endpoint ruleset parameters casing
* PaymentCryptographyData (3.7.503.0)
	* Update endpoint ruleset parameters casing
* PcaConnectorAd (3.7.501.0)
	* Update endpoint ruleset parameters casing
* QBusiness (3.7.503.0)
	* Update endpoint ruleset parameters casing
* RoboMaker (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Route53Domains (3.7.503.0)
	* Update endpoint ruleset parameters casing
* RTBFabric (3.7.501.0)
	* Add support for custom rate limits.
* S3Tables (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SageMaker (3.7.513.0)
	* Added inference components model data caching feature
* SageMakerMetrics (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SecurityHub (3.7.504.0)
	* Release 3 layer filter support in GetFindingsV2, GetFindingStatisticsV2, GetResourcesV2,GetResourcesStatisticsV2, AutomationRule V2 APIs. Update filter casing in GetResourcesV2, GetResourcesStatisticsV2 APIs. Add new filters in GetFindingsV2, GetFindingStatisticsV2, AutomationRule V2 APIs.
* ServiceDiscovery (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SnowDeviceManagement (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SSOOIDC (3.7.503.0)
	* Update endpoint ruleset parameters casing
* SupplyChain (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Translate (3.7.501.0)
	* Update endpoint ruleset parameters casing
* VerifiedPermissions (3.7.503.0)
	* Update endpoint ruleset parameters casing
* VPCLattice (3.7.503.0)
	* Update endpoint ruleset parameters casing
* WorkSpacesThinClient (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.37
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1150.0 (2025-10-23 19:13 UTC)
* Account (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApplicationAutoScaling (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApplicationDiscoveryService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AWSMarketplaceCommerceAnalytics (3.7.502.0)
	* Update endpoint ruleset parameters casing
* BedrockAgentCore (3.7.506.0)
	* Fixing the service documentation name
* BedrockAgentCoreControl (3.7.508.0)
	* Fixing the service documentation name
* ChimeSDKVoice (3.7.503.0)
	* Update endpoint ruleset parameters casing
* CloudTrailData (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudWatchRUM (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CodeBuild (3.7.504.0)
	* Update endpoint ruleset parameters casing
* CodeStarconnections (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ConfigService (3.7.503.0)
	* Update endpoint ruleset parameters casing
* ConnectContactLens (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CostAndUsageReport (3.7.501.0)
	* Update endpoint ruleset parameters casing
* DatabaseMigrationService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DocDBElastic (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Drs (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DSQL (3.7.503.0)
	* Add support for resource-based policies for Aurora DSQL clusters. This will enable you to implement Block Public Access (BPA) which will help restrict access to your Aurora DSQL public or VPC endpoints.
* EBS (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ECR (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ECRPublic (3.7.502.0)
	* Update endpoint ruleset parameters casing
* HealthLake (3.7.503.0)
	* Update endpoint ruleset parameters casing
* InternetMonitor (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTEvents (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTJobsDataPlane (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KinesisVideoArchivedMedia (3.7.501.0)
	* Update endpoint ruleset parameters casing
* KinesisVideoWebRTCStorage (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Lambda (3.7.502.0)
	* Add NodeJs 24 (nodejs24.x) support to AWS Lambda.
* Macie2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ManagedBlockchainQuery (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaTailor (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Mgn (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MigrationHub (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MPA (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Neptunedata (3.7.502.0)
	* Update endpoint ruleset parameters casing
* NetworkMonitor (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Odb (3.7.501.5)
	* Doc-only update that removes duplicate values from descriptions of ODB peering APIs.
* Omics (3.7.503.0)
	* Update endpoint ruleset parameters casing
* OpenSearchServerless (3.7.503.0)
	* Update endpoint ruleset parameters casing
* PcaConnectorScep (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PersonalizeEvents (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PinpointEmail (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ResilienceHub (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SageMaker (3.7.512.0)
	* Update endpoint ruleset parameters casing
* SagemakerEdgeManager (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SavingsPlans (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SecurityLake (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SimpleEmailV2 (3.7.503.0)
	* Update endpoint ruleset parameters casing
* StorageGateway (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Synthetics (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.36
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1149.0 (2025-10-22 20:16 UTC)
* AppFabric (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AugmentedAIRuntime (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AutoScaling (3.7.502.0)
	* Update endpoint ruleset parameters casing
* B2bi (3.7.503.0)
	* Update endpoint ruleset parameters casing
* BCMDashboards (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Chatbot (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudFormation (3.7.503.0)
	* Update endpoint ruleset parameters casing
* CloudHSM (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CloudHSMV2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CodeGuruReviewer (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CognitoIdentity (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ComprehendMedical (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Connect (3.7.510.0)
	* This release added support for email address alias configuration and outbound campaign preview mode.
* ConnectCampaignsV2 (3.7.502.0)
	* Updated Amazon Connect Outbound Campaigns V2 SDK to support Preview Outbound Mode
* ConnectParticipant (3.7.503.0)
	* Update endpoint ruleset parameters casing
* CostExplorer (3.7.504.0)
	* Update endpoint ruleset parameters casing
* DeviceFarm (3.7.501.0)
	* This release adds support for optionally including an app as part of a CreateRemoteAccessSession request
* DirectConnect (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DirectoryServiceData (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EC2 (3.7.518.0)
	* This release adds AvailabilityZoneId support for CreateNetworkInterface and DescribeNetworkInterfaces APIs.
* EC2InstanceConnect (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ForecastQueryService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IdentityManagement (3.7.502.0)
	* Updated OIDC and SAML apis to reject multiple simultaneous requests to change a unique object.
* Inspector2 (3.7.503.0)
	* Update endpoint ruleset parameters casing
* IoT (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTAnalytics (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTFleetWise (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTSecureTunneling (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTSiteWise (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Ivschat (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KinesisAnalyticsV2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LexModelsV2 (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MailManager (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MarketplaceAgreement (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaLive (3.7.506.0)
	* Add 3 API operations for fetching alerts: ListAlerts (Channels), ListClusterAlerts (MediaLive Anywhere), and ListMultiplexAlerts
* MWAA (3.7.502.0)
	* Update endpoint ruleset parameters casing
* NotificationsContacts (3.7.502.0)
	* Update endpoint ruleset parameters casing
* OAM (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PCS (3.7.506.0)
	* Update endpoint ruleset parameters casing
* PinpointSMSVoiceV2 (3.7.503.0)
	* Update endpoint ruleset parameters casing
* RedshiftDataAPIService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Route53 (3.7.503.0)
	* Amazon Route 53 now supports the ISOB West Region for private DNS for Amazon VPCs and cloudwatch healthchecks.
* Route53RecoveryCluster (3.7.502.0)
	* Update endpoint ruleset parameters casing
* RTBFabric (3.7.500.0)
	* Update for general availability of AWS RTB Fabric service.
* SimpleNotificationService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SSMIncidents (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WorkDocs (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WorkMail (3.7.503.0)
	* Update endpoint ruleset parameters casing
* WorkSpaces (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.35
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1148.0 (2025-10-21 19:25 UTC)
* AWSMarketplaceMetering (3.7.502.0)
	* Added ClientToken parameter to MeterUsage API for specifying idempotent requests.
* DynamoDBv2 (3.7.507.0)
	* Add AccountID based endpoint metric to endpoint rules.
* ElasticMapReduce (3.7.502.0)
	* Added RECONFIGURING to the InstanceFleetState convenience enum.
* MediaConvert (3.7.503.0)
	* This release adds the ability to set resolution for the black video generator and also adds the StartJobsQuery and GetJobsQueryResults APIs which allow asynchronous search of job history using new filters.

### 3.7.1147.0 (2025-10-17 19:29 UTC)
* AmplifyBackend (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppConfigData (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppIntegrationsService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApplicationInsights (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ARCZonalShift (3.7.502.0)
	* Update endpoint ruleset parameters casing
* BCMRecommendedActions (3.7.501.0)
	* Update endpoint ruleset parameters casing
* BedrockDataAutomationRuntime (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ChimeSDKMeetings (3.7.503.0)
	* Update endpoint ruleset parameters casing
* CloudFront (3.7.505.0)
	* Update endpoint ruleset parameters casing
* CloudFrontKeyValueStore (3.7.501.0)
	* Update endpoint ruleset parameters casing
* CloudWatchEvidently (3.7.502.0)
	* Update endpoint ruleset parameters casing
* CodeStarNotifications (3.7.501.0)
	* Update endpoint ruleset parameters casing
* ControlCatalog (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DataSync (3.7.503.0)
	* Update endpoint ruleset parameters casing
* DirectoryService (3.7.504.0)
	* Update endpoint ruleset parameters casing
* DSQL (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EC2 (3.7.517.2)
	* Documentation updates for Amazon EC2.
* Elasticsearch (3.7.502.0)
	* Update endpoint ruleset parameters casing
* EventBridge (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Finspace (3.7.502.0)
	* Update endpoint ruleset parameters casing
* FinSpaceData (3.7.501.0)
	* Update endpoint ruleset parameters casing
* GameLiftStreams (3.7.502.25)
	* Updates documentation to clarify valid application binaries for an Amazon GameLift Streams application and provide descriptions of stream session error status reasons
* GeoMaps (3.7.502.0)
	* Added support for optional style parameters in maps, including Terrain, ContourDensity, Traffic, and TravelModes.
* IAMRolesAnywhere (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Imagebuilder (3.7.504.0)
	* Update endpoint ruleset parameters casing
* IotData (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTDeviceAdvisor (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTThingsGraph (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IoTTwinMaker (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KendraRanking (3.7.501.0)
	* Update endpoint ruleset parameters casing
* KinesisVideoMedia (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LakeFormation (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LicenseManager (3.7.501.0)
	* Update endpoint ruleset parameters casing
* LicenseManagerUserSubscriptions (3.7.504.0)
	* Update endpoint ruleset parameters casing
* MarketplaceCatalog (3.7.501.0)
	* The ListEntities API now supports two new CAPI filters: DeliveryOptionTypes for SaaS products and CompatibleAWSServices for Container products.
* MediaConnect (3.7.503.0)
	* Update endpoint ruleset parameters casing
* MigrationHubRefactorSpaces (3.7.502.0)
	* Update endpoint ruleset parameters casing
* NetworkFirewall (3.7.504.0)
	* Update endpoint ruleset parameters casing
* NetworkManager (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Organizations (3.7.504.0)
	* Update endpoint ruleset parameters casing
* PI (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PrometheusService (3.7.504.0)
	* Update endpoint ruleset parameters casing
* QApps (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Route53RecoveryReadiness (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SageMakerGeospatial (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Signer (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SimpleWorkflow (3.7.502.0)
	* Releasing minor endpoint updates.
* TimestreamWrite (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Tnb (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WellArchitected (3.7.501.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.34
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1146.0 (2025-10-16 19:22 UTC)
* ACMPCA (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Amplify (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ApiGatewayManagementApi (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppRunner (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AppTest (3.7.502.0)
	* Update endpoint ruleset parameters casing
* AutoScalingPlans (3.7.502.0)
	* Updated FIPS endpoints for US GovCloud regions
* Batch (3.7.501.0)
	* Update endpoint ruleset parameters casing
* BCMDataExports (3.7.501.0)
	* Update endpoint ruleset parameters casing
* BillingConductor (3.7.502.0)
	* New feature: service flat CLI and first AWS managed pricing plan (BasicPricingPlan)
* CustomerProfiles (3.7.503.0)
	* Update endpoint ruleset parameters casing
* DataExchange (3.7.502.0)
	* Update endpoint ruleset parameters casing
* DLM (3.7.502.0)
	* Update endpoint ruleset parameters casing
* FreeTier (3.7.501.0)
	* Update endpoint ruleset parameters casing
* GameLift (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GeoRoutes (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GlobalAccelerator (3.7.502.0)
	* Update endpoint ruleset parameters casing
* GlueDataBrew (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IdentityStore (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IVS (3.7.502.0)
	* Update endpoint ruleset parameters casing
* IVSRealTime (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Kafka (3.7.502.0)
	* Update endpoint ruleset parameters casing
* KeyManagementService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Keyspaces (3.7.501.0)
	* Update endpoint ruleset parameters casing
* LexModelBuildingService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LexRuntimeV2 (3.7.502.0)
	* Update endpoint ruleset parameters casing
* LookoutEquipment (3.7.501.0)
	* Update endpoint ruleset parameters casing
* MachineLearning (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MainframeModernization (3.7.502.0)
	* Update endpoint ruleset parameters casing
* ManagedGrafana (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MarketplaceEntitlementService (3.7.502.0)
	* Update endpoint ruleset parameters casing
* MediaPackageV2 (3.7.503.0)
	* Update endpoint ruleset parameters casing
* MedicalImaging (3.7.503.0)
	* Update endpoint ruleset parameters casing
* MemoryDB (3.7.503.0)
	* Update endpoint ruleset parameters casing
* MigrationHubConfig (3.7.502.0)
	* Update endpoint ruleset parameters casing
* NetworkFlowMonitor (3.7.503.0)
	* Update endpoint ruleset parameters casing
* OSIS (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Personalize (3.7.502.0)
	* Update endpoint ruleset parameters casing
* PersonalizeRuntime (3.7.501.0)
	* Update endpoint ruleset parameters casing
* PinpointSMSVoice (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Polly (3.7.503.0)
	* Update endpoint ruleset parameters casing
* Pricing (3.7.502.0)
	* Update endpoint ruleset parameters casing
* QLDB (3.7.502.0)
	* Update endpoint ruleset parameters casing
* QLDBSession (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Route53RecoveryControlConfig (3.7.502.0)
	* Update endpoint ruleset parameters casing
* SimpleSystemsManagement (3.7.503.0)
	* Update endpoint ruleset parameters casing
* SSMContacts (3.7.501.0)
	* Update endpoint ruleset parameters casing
* SSMGuiConnect (3.7.502.0)
	* Update endpoint ruleset parameters casing
* TimestreamQuery (3.7.502.0)
	* Update endpoint ruleset parameters casing
* VoiceID (3.7.502.0)
	* Update endpoint ruleset parameters casing
* WorkSpacesWeb (3.7.502.0)
	* Update endpoint ruleset parameters casing
* Core 3.7.500.33
	* Added checksum caching support for trailing and header checksums.
	* All services packages updated to require new Core

### 3.7.1145.0 (2025-10-15 18:29 UTC)
* Bedrock (3.7.505.0)
	* Amazon Bedrock Automated Reasoning Policy now offers enhanced AWS KMS integration. The CreateAutomatedReasoningPolicy API includes a new kmsKeyId field, allowing customers to specify their preferred KMS key for encryption, improving control and compliance with AWS encryption mandates.
* DocDB (3.7.502.0)
	* Add support for NetworkType field in CreateDbCluster, ModifyDbCluster, RestoreDbClusterFromSnapshot and RestoreDbClusterToPointInTime for DocumentDB.
* EC2 (3.7.517.0)
	* Introducing EC2 Capacity Manager for monitoring and analyzing capacity usage across On-Demand Instances, Spot Instances, and Capacity Reservations.
* ElasticLoadBalancingV2 (3.7.502.0)
	* This release expands Listener Rule Conditions to support RegexValues and adds support for a new Transforms field in Listener Rules.
* GuardDuty (3.7.505.0)
	* Added default pagination value for ListMalwareProtectionPlans API and updated UpdateFindingsFeedback API
* Lightsail (3.7.504.0)
	* Add support for manage Lightsail Bucket CORS configuration
* TimestreamInfluxDB (3.7.503.0)
	* This release adds support for creating and managing InfluxDB 3 Core and Enterprise DbClusters.
* Core 3.7.500.32
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1144.0 (2025-10-14 18:31 UTC)
* AppStream (3.7.502.0)
	* This release introduces support for Microsoft license included applications streaming.
* Backup (3.7.503.0)
	* The AWS Backup job attribute extension enhancement helps customers better understand the plan that initiated each job, and the properties of the resource each job creates.
* Connect (3.7.509.0)
	* SDK release for TaskTemplateInfo in Contact for DescribeContact response.
* DataZone (3.7.507.0)
	* Support creating scoped and trustedIdentityPropagation enabled connections.
* EC2 (3.7.516.0)
	* This release adds support for creating instant, point-in-time copies of EBS volumes within the same Availability Zone
* TranscribeService (3.7.502.0)
	* Move UntagResource API body member to query parameter
* Transfer (3.7.503.0)
	* SFTP connectors now support routing connections via customers' VPC. This enables connections to remote servers that are only accessible in a customer's VPC environment, and to servers that are accessible over the internet but need connections coming from an IP address in a customer VPC's CIDR range.

### 3.7.1143.0 (2025-10-13 18:21 UTC)
* BedrockAgentCore (3.7.505.0)
	* Updated InvokeAgentRuntime API to accept account id optionally and added CompleteResourceTokenAuth API.
* BedrockAgentCoreControl (3.7.507.0)
	* Updated http status code in control plane apis of agentcore runtime, tools and identity. Additional included provider types for AgentCore Identity
* EC2 (3.7.515.0)
	* Release Amazon EC2 c8i, c8i-flex, m8a, and r8gb
* ObservabilityAdmin (3.7.504.0)
	* CloudWatch Observability Admin adds the ability to enable Resource tags for telemetry in a customer account. The release introduces new APIs to enable, disable and describe the status of Resource tags for telemetry feature. This new capability simplifies monitoring AWS resources using tags.

### 3.7.1142.0 (2025-10-10 19:09 UTC)
* BedrockAgentCore (3.7.504.0)
	* Bedrock AgentCore release for Runtime, and Memory.
* BedrockAgentCoreControl (3.7.506.0)
	* Bedrock AgentCore release for Gateway, and Memory including Self-Managed Strategies support for Memory.
* CloudFront (3.7.504.0)
	* Added new viewer security policy, TLSv1.2_2025, for CloudFront.
* Glue (3.7.508.0)
	* Addition of AuditContext in GetTable/GetTables Request
* Lambda (3.7.501.0)
	* Add InvokedViaFunctionUrl context key to limit invocations to only FURL invokes.
* Odb (3.7.501.0)
	* This release adds APIs that allow you to specify CIDR ranges in your ODB peering connection.
* RDS (3.7.506.5)
	* Updated the text in the Important section of the ModifyDBClusterParameterGroup page.
* Core 3.7.500.31
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1141.0 (2025-10-09 18:19 UTC)
* QuickSight (3.7.504.0)
	* This release adds support for ActionConnector and Flow, which are new resources associated with Amazon Quick Suite. Additional updates include expanded Data Source options, further branding customization, and new capabilities that can be restricted by Admins.
* WAFV2 (3.7.502.0)
	* This release adds the ability to throw WafLimitsExceededException when the maximum number of Application Load Balancer (ALB) associations per AWS WAF v2 WebACL is exceeded.
* Core 3.7.500.30
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1140.0 (2025-10-08 18:19 UTC)
* BedrockAgentCoreControl (3.7.505.0)
	* Adding support for authorizer type AWS_IAM to AgentCore Control Gateway.
* LicenseManagerUserSubscriptions (3.7.503.0)
	* Released support for IPv6 and dual-stack active directories
* Outposts (3.7.501.0)
	* This release adds the new StartOutpostDecommission API, which starts the decommission process to return Outposts racks or servers.
* ServiceQuotas (3.7.502.0)
	* introduces Service Quotas Automatic Management. Users can opt-in to monitoring and managing service quotas, receive notifications when quota usage reaches thresholds, configure notification channels, subscribe to EventBridge events for automation, and view notifications in the AWS Health dashboard.
* Core 3.7.500.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1139.0 (2025-10-07 18:16 UTC)
* Proton (3.7.502.0)
	* Deprecating APIs in AWS Proton namespace.
* Core 3.7.500.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1138.0 (2025-10-06 19:29 UTC)
* Backup (3.7.502.0)
	* Adds optional MaxScheduledRunsPreview input to GetBackupPlan API to provide a preview of up to 10 next scheduled backup plan runs in the GetBackupPlan response.
* BedrockAgentCore (3.7.503.0)
	* Add support for batch memory management, agent card retrieval and session termination
* BedrockAgentCoreControl (3.7.504.0)
	* Add support for VM lifecycle configuration parameters and A2A protocol
* Glue (3.7.507.0)
	* Adds labeling for DataQualityRuleResult for GetDataQualityResult and PublishDataQualityResult APIs
* MediaConnect (3.7.502.0)
	* Enabling Tag-on-Create for AWS Elemental MediaConnect flow-based resource types
* MemoryDB (3.7.502.0)
	* Support for DescribeMultiRegionParameterGroups and DescribeMultiRegionParameters API.
* QuickSight (3.7.503.10)
	* Documentation improvements for QuickSight API documentation to clarify that delete operation APIs are global.
* RDS (3.7.506.1)
	* Documentation updates to the CreateDBClusterMessage$PubliclyAccessible and CreateDBInstanceMessage$PubliclyAccessible properties.
* ResourceExplorer2 (3.7.502.0)
	* Add new AWS Resource Explorer APIs

### 3.7.1137.0 (2025-10-03 18:26 UTC)
* CleanRooms (3.7.507.0)
	* Added support for reading data sources across regions, and results delivery to allowedlisted regions.
* MediaLive (3.7.505.0)
	* AWS Elemental MediaLive enables Mediapackage V2 users to configure ID3, KLV, Nielsen ID3, and Segment Length related parameters through the Mediapackage output group.
* PaymentCryptographyData (3.7.502.0)
	* Added a new API - translateKeyMaterial; allows keys wrapped by ECDH derived keys to be rewrapped under a static AES keyblock without first importing the key into the service.
* QConnect (3.7.502.0)
	* Updated Amazon Q in Connect APIs to support Email Contact Recommendations.

### 3.7.1136.0 (2025-10-02 19:11 UTC)
* CloudFormation (3.7.502.0)
	* Add new warning type 'EXCLUDED_RESOURCES'
* ConnectCases (3.7.503.0)
	* New Search All Related Items API enables searching related items across cases
* DynamoDBv2 (3.7.506.0)
	* Add support for dual-stack account endpoint generation
* GuardDuty (3.7.504.10)
	* Updated descriptions for the Location parameter in CreateTrustedEntitySet and CreateThreatEntitySet.
* Synthetics (3.7.502.0)
	* Adds support to configure canaries with pre-configured blueprint code on supported runtime versions.  This behavior can be controlled via the new BlueprintTypes property exposed in the CreateCanary and UpdateCanary APIs.

### 3.7.1135.0 (2025-10-01 18:36 UTC)
* ChimeSDKMeetings (3.7.502.0)
	* Add support to receive dual stack MediaPlacement URLs in Chime Meetings SDK
* CleanRooms (3.7.506.0)
	* This release introduces data access budgets to control how many times a table can be used for queries and jobs in a collaboration.
* CleanRoomsML (3.7.503.0)
	* This release introduces data access budgets to view how many times an input channel can be used for ML jobs in a collaboration.
* DatabaseMigrationService (3.7.501.19)
	* This is a doc-only update, revising text for kms-key-arns.
* ECS (3.7.502.1)
	* This is a documentation only Amazon ECS release that adds additional information for health checks.
* PCS (3.7.505.0)
	* Added the UpdateCluster API action to modify cluster configurations, and Slurm custom settings for queues.

### 3.7.1134.0 (2025-09-30 18:37 UTC)
* ApplicationSignals (3.7.502.0)
	* Amazon CloudWatch Application Signals is introducing the Application Map to give users a more comprehensive view of their service health. Users will now be able to group services, track their latest deployments, and view automated audit findings concerning service performance.
* BedrockAgentCoreControl (3.7.503.0)
	* Tagging support for AgentCore Gateway
* ChimeSDKVoice (3.7.502.0)
	* Added support for IPv4-only and dual-stack network configurations for VoiceConnector and CreateVoiceConnector API.
* ConnectCases (3.7.502.0)
	* This release adds support for two new related item types: ConnectCase for linking Amazon Connect cases and Custom for user-defined related items with configurable fields.
* CustomerProfiles (3.7.502.0)
	* This release introduces ListProfileHistoryRecords and GetProfileHistoryRecord APIs for comprehensive profile history tracking with complete audit trails of creation, updates, merges, deletions, and data ingestion events.
* DataSync (3.7.502.0)
	* Added support for FIPS VPC endpoints in FIPS-enabled AWS Regions.
* DataZone (3.7.506.0)
	* This release adds support for creation of EMR on EKS Connections in Amazon DataZone.
* DirectoryService (3.7.503.0)
	* AWS Directory service now supports IPv6-native and dual-stack configurations for AWS Managed Microsoft AD, AD Connector, and Simple AD (dual-stack only). Additionally, AWS Managed Microsoft AD Standard Edition directories can be upgraded to Enterprise Edition directories through a single API call.
* ECS (3.7.502.0)
	* This release adds support for Managed Instances on Amazon ECS.
* FSx (3.7.503.0)
	* Add Dual-Stack support for Amazon FSx for NetApp ONTAP and Windows File Server
* MediaTailor (3.7.502.0)
	* Adding TPS Traffic Shaping to Prefetch Schedules
* QuickSight (3.7.503.9)
	* added warnings to a few CLI pages
* RDS (3.7.506.0)
	* Enhanced RDS error handling: Added DBProxyEndpointNotFoundFault, DBShardGroupNotFoundFault, KMSKeyNotAccessibleFault for snapshots/restores/backups, NetworkTypeNotSupported, StorageTypeNotSupportedFault for restores, and granular state validation faults. Changed DBInstanceNotReadyFault to HTTP 400.
* Transfer (3.7.502.0)
	* Add support for updating server identity provider type
* Core 3.7.500.27
	* Update code generator to use fully qualified name for InvokeOptions to avoid name collisions
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1133.0 (2025-09-29 18:17 UTC)
* Bedrock (3.7.504.0)
	* Release for fixing GetFoundationModel API behavior. Imported and custom models have their own exclusive API and GetFM should not accept those ARNS as input
* BedrockRuntime (3.7.505.0)
	* New stop reason for Converse and ConverseStream
* Imagebuilder (3.7.503.0)
	* This release introduces several new features and improvements to enhance pipeline management, logging, and resource configuration.
* VPCLattice (3.7.502.0)
	* Adds support for specifying the number of IPv4 addresses in each ENI for the resource gateway for VPC Lattice.
* Core 3.7.500.26
	* Add user agent header to list of headers to ignore during signing
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1132.0 (2025-09-26 18:30 UTC)
* BedrockAgentRuntime (3.7.502.0)
	* This release enhances the information provided through Flow Traces. New information includes source/next node tracking, execution chains for complex nodes, dependency action (operation) details, and dependency traces.
* BedrockDataAutomation (3.7.501.0)
	* Added support for configurable Speaker Labeling and Channel Labeling features for Audio modality.
* Billing (3.7.503.0)
	* Add ability to combine custom billing views to create new consolidated views.
* Connect (3.7.508.0)
	* Adds supports for manual contact picking (WorkList) operations on Routing Profiles, Agent Management and SearchContacts APIs.
* CostExplorer (3.7.503.0)
	* Support for payer account dimension and billing view health status.
* DynamoDBv2 (3.7.505.0)
	* Added support for IPv6 compatible endpoints for DynamoDB Streams.
* EC2 (3.7.514.2)
	* This release includes documentation updates for Amazon EBS General Purpose SSD (gp3) volumes with larger size and higher IOPS and throughput.
* Redshift (3.7.502.0)
	* Support tagging and tag propagation to IAM Identity Center for Redshift Idc Applications
* Core 3.7.500.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1131.0 (2025-09-25 18:20 UTC)
* Glue (3.7.506.0)
	* Update GetConnection(s) API to return KmsKeyArn & Add 63 missing connection types
* Lightsail (3.7.503.0)
	* Attribute HTTP binding update for Get/Delete operations
* NetworkFirewall (3.7.503.0)
	* Network Firewall now introduces Reject and Alert action support for stateful domain list rule groups, providing customers with more granular control over their network traffic.
* Core 3.7.500.24
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1130.0 (2025-09-24 18:22 UTC)
* AppStream (3.7.501.15)
	* G6f instance support for AppStream 2.0
* CloudWatch (3.7.503.0)
	* Fix default dualstack FIPS endpoints in AWS GovCloud(US) regions
* DAX (3.7.501.0)
	* This release adds support for IPv6-only, DUAL_STACK DAX instances
* KeyManagementService (3.7.501.13)
	* Documentation only updates for KMS.
* Neptune (3.7.502.11)
	* Doc-only update to address customer use.

### 3.7.1129.0 (2025-09-23 18:26 UTC)
* CleanRooms (3.7.505.0)
	* Added support for running incremental ID mapping for rule-based workflows.
* EC2 (3.7.514.0)
	* Add Amazon EC2 R8gn instance types
* EntityResolution (3.7.502.0)
	* Support incremental id mapping workflow for AWS Entity Resolution
* SimpleSystemsManagement (3.7.502.0)
	* Added Dualstack support to GetDeployablePatchSnapshotForInstance
* SSOAdmin (3.7.502.0)
	* Add support for encryption at rest with Customer Managed KMS Key in AWS IAM Identity Center
* SSOOIDC (3.7.502.0)
	* This release includes exception definition and documentation updates.
* Core 3.7.500.23
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1128.0 (2025-09-22 18:22 UTC)
* Batch (3.7.500.25)
	* Starting in JAN 2026, AWS Batch will change the default AMI for new Amazon ECS compute environments from Amazon Linux 2 to Amazon Linux 2023. We recommend migrating AWS Batch Amazon ECS compute environments to Amazon Linux 2023 to maintain optimal performance and security.
* EKS (3.7.504.0)
	* Adds support for RepairConfig overrides and configurations in EKS Managed Node Groups.
* Imagebuilder (3.7.502.0)
	* Version ARNs are no longer required for the EC2 Image Builder list-image-build-version, list-component-build-version, and list-workflow-build-version APIs. Calling these APIs without the ARN returns all build versions for the given resource type in the requesting account.
* S3 (3.7.501.7)
	* Fixed a bug where PutObject was failing when sending zero-byte InputStream with DisablePayloadSigning set to true.
* Core 3.7.500.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1127.0 (2025-09-19 18:43 UTC)
* BedrockAgentCoreControl (3.7.502.0)
	* Add tagging and VPC support to AgentCore Runtime, Code Interpreter, and Browser resources. Add support for configuring request headers in Runtime. Fix AgentCore Runtime shape names.
* ConfigService (3.7.502.0)
	* Add UNKNOWN state to RemediationExecutionState and add IN_PROGRESS/EXITED/UNKNOWN states to RemediationExecutionStepState.
* Connect (3.7.507.0)
	* This release adds a persistent connection field to UserPhoneConfig that maintains agent's softphone media connection for faster call connections.
* KendraRanking (3.7.500.21)
	* Model whitespace change - no client difference
* LicenseManagerUserSubscriptions (3.7.502.0)
	* Added support for cross-account Active Directories.
* MediaLive (3.7.504.0)
	* Add MinBitrate for QVBR mode under H264/H265/AV1 output codec. Add GopBReference, GopNumBFrames, SubGopLength fields under H265 output codec.
* SQS (3.7.501.12)
	* Update invalid character handling documentation for SQS SendMessage API
* Core 3.7.500.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1126.0 (2025-09-18 18:38 UTC)
* Bedrock (3.7.503.0)
	* Release includes an increase to the maximum policy build document size, an update to DeleteAutomatedReasoningPolicyBuildWorkflow to add ResourceInUseException, and corrections to UpdateAutomatedReasoningPolicyTestCaseRequest.
* Budgets (3.7.504.0)
	* Added BillingViewHealthStatus Exception which is thrown when a Budget is created or updated with a Billing View that is not in the HEALTHY status
* ChimeSDKMessaging (3.7.501.0)
	* Amazon Chime SDK Messaging GetMessagingSessionEndpoint API now returns dual-stack WebSocket endpoints supporting IPv4/IPv6.
* EC2 (3.7.513.0)
	* Allowed AMIs adds support for four new parameters - marketplaceProductCodes, deprecationTimeCondition, creationDateCondition and imageNames

### 3.7.1125.0 (2025-09-17 18:38 UTC)
* EC2 (3.7.512.0)
	* Add mac-m4.metal and mac-m4pro.metal instance types.
* NetworkFirewall (3.7.502.0)
	* Network Firewall now prevents TLS handshakes with the target server until after the Server Name Indication (SNI) has been seen and verified. The monitoring dashboard now provides deeper insights into PrivateLink endpoint candidates and offers filters based on IP addresses and protocol.
* PCS (3.7.504.0)
	* Add support for Amazon EC2 Capacity Blocks for ML

### 3.7.1124.0 (2025-09-16 18:30 UTC)
* Budgets (3.7.503.0)
	* Add support for custom time periods in budget configuration
* CloudWatchLogs (3.7.501.0)
	* Cloudwatch Logs added support for 2 new API parameters in metric and subscription filter APIs to filter log events based on system field values and emit system field values as dimensions and send them to customer destination as additional metadata.
* IVSRealTime (3.7.502.0)
	* IVS now offers customers the ability to control the positioning of participants in both grid and PiP layouts based on custom attribute values in participant tokens.
* OSIS (3.7.502.0)
	* Adds support for cross-account ingestion for push-based sources. This includes resource policies for sharing pipelines across accounts and features for managing pipeline endpoints which enable accessing pipelines across different VPCs, including VPCs in other accounts.
* Core 3.7.500.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1123.0 (2025-09-15 18:34 UTC)
* CostExplorer (3.7.502.0)
	* Added endpoint support for eusc-de-east-1 region.
* MedicalImaging (3.7.502.0)
	* Added support for OpenID Connect (OIDC) custom authorizer
* ObservabilityAdmin (3.7.503.0)
	* CloudWatch Observability Admin adds the ability to enable telemetry centralization in customers' Organizations. The release introduces new APIs to manage centralization rules, which define settings to replicate telemetry data to a central destination in the customers' Organization.
* S3Control (3.7.502.0)
	* Introduce three new encryption filters: EncryptionType (SSE-S3, SSE-KMS, DSSE-KMS, SSE-C, NOT-SSE), KmsKeyArn (for SSE-KMS and DSSE-KMS), and BucketKeyEnabled (for SSE-KMS).
* ServerMigrationService (Removed)
	* AWS Server Migration Service has been removed from the SDK because it has been discontinued.
* Core 3.7.500.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1122.0 (2025-09-12 18:16 UTC)
* PaymentCryptography (3.7.503.0)
	* Add support for certificates to be signed by 3rd party certificate authorities.  New API GetCertificateSigningRequest API and support for providing certificates at run-time for tr-34 import/export

### 3.7.1121.0 (2025-09-11 18:24 UTC)
* DataZone (3.7.505.0)
	* adding IAM principal id to IAM user profile details
* ECS (3.7.501.0)
	* This release supports hook details for Amazon ECS lifecycle hooks.
* EMRContainers (3.7.501.0)
	* Added nodeLabel support in container provider to aid hardware isolation support for virtual cluster and security configuration.
* Evs (3.7.503.0)
	* CreateEnvironment API now supports parameters (isHcxPublic & hcxNetworkAclId) for HCX migration via public internet, adding flexibility for migration scenarios. New APIs have been added for associating (AssociateEipToVlan) & disassociating (DisassociateEipFromVlan) Elastic IP (EIP) addresses.
* GuardDuty (3.7.504.0)
	* Updated Java SDK implementation of entity set status in GuardDuty API.
* MediaLive (3.7.503.0)
	* AWS Elemental MediaLive adds a new feature in MediaPackage output group that enables MediaPackage V2 users to control HLS-related parameters directly in MediaLive. These parameter settings are then reflected in MediaPackage outputs, providing more streamlined control over HLS configurations.
* PrometheusService (3.7.503.0)
	* Add Vended Logs APIs for Amazon Prometheus Managed Collector
* QuickSight (3.7.503.0)
	* This release adds support for Account level custom permissions, additional Dashboard Options, and Null support for Q&A.
* RDS (3.7.505.0)
	* Adds support for end-to-end IAM authentication in RDS Proxy for MySQL, MariaDB, and PostgreSQL engines.
* Core 3.7.500.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1120.0 (2025-09-10 18:18 UTC)
* NetworkFlowMonitor (3.7.502.0)
	* Added new enum value (AWS::Region) for type field under MonitorLocalResource and MonitorRemoteResource. Workload Insights and Monitor top contributors queries now support a new DestinationCategory (INTER_REGION).
* PaymentCryptography (3.7.502.0)
	* AWS Payment Cryptography Service now supports Multi-Region key replication. Customers can choose to automatically distribute keys across AWS Regions.
* Core 3.7.500.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1119.0 (2025-09-09 18:26 UTC)
* AutoScaling (3.7.501.0)
	* Added WaitForTransitioningInstances parameter to the CancelInstanceRefresh API, allowing the caller to cancel an instance refresh without waiting for on-going launches and terminations.
* CloudWatch (3.7.502.0)
	* Added a new API - DescribeAlarmContributors API, to retrieve alarm contributors in ALARM state. Added support in DescribeAlarmHistory API to query alarm contributor history
* Connect (3.7.506.0)
	* SDK release for user defined predefined attributes.
* DataZone (3.7.504.0)
	* Adds support for custom blueprints
* MediaPackageV2 (3.7.502.0)
	* Added CUE tag SCTE output to MediaPackageV2 HLS and LL-HLS manifests.
* Organizations (3.7.503.0)
	* Documentation updates for AWS Organizations APIs.
* SageMaker (3.7.511.0)
	* Released IPv6 support with dual-stack domain options on SageMaker Studio and introduced support for p6-b200.48xlarge instance type on SageMaker Studio for JupyterLab and CodeEditor applications.
* Core 3.7.500.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1118.0 (2025-09-08 18:49 UTC)
* IoTSiteWise (3.7.502.0)
	* Add ComputationModelVersion support in IoT SiteWise APIs
* S3 (3.7.501.0)
	* This release includes backward compatibility work on the "Expires" parameter.
* SecurityHub (3.7.503.0)
	* This release adds the RESOURCE_NOT_FOUND error code as a possible value in responses to the following operations: BatchGetStandardsControlAssociations, BatchUpdateStandardsControlAssociations, and BatchGetSecurityControls.
* Core 3.7.500.15
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1117.0 (2025-09-05 18:22 UTC)
* ECS (3.7.500.15)
	* This is a documentation only release that adds additional information for Amazon ECS Availability Zone rebalancing.
* PCS (3.7.503.4)
	* Documentation-only update to add AccountingStorageEnforce to SlurmCustomSetting.
* SageMaker (3.7.510.0)
	* Release IPv6 support with dualstack in SageMaker Notebooks, Tiered Storage Checkpointing Support in SageMaker HyperPod and P5.4xlarge instance type for SageMaker Hosting.

### 3.7.1116.0 (2025-09-04 18:21 UTC)
* CleanRooms (3.7.504.0)
	* Add support for configurable compute sizes for PySpark jobs.
* CloudFormation (3.7.501.0)
	* ListHookResults API now supports retrieving invocation results for all CloudFormation Hooks (previously limited to create change set and Cloud Control operations) with new optional parameters for filtering by Hook status and ARN.
* EC2 (3.7.511.0)
	* Add m8i, m8i-flex and i8ge instance types.
* OpenSearchServerless (3.7.502.0)
	* Add support for Federal Information Processing Standards (FIPS) and Federal Risk and Authorization Management Program (FedRAMP) compliance
* RDS (3.7.504.0)
	* Added new EndpointNetworkType and TargetConnectionNetworkType fields in Proxy APIs to support IPv6
* VerifiedPermissions (3.7.502.0)
	* Amazon Verified Permissions / Features : Adds support for datetime and duration attribute values.
* Core 3.7.500.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1115.0 (2025-09-03 18:24 UTC)
* CleanRooms (3.7.503.0)
	* Added support for adding new data provider members to an existing collaboration.
* CleanRoomsML (3.7.502.0)
	* AWS Clean Rooms ML adds log sanitization for privacy-enhanced error summaries, supports new instance types for custom models providing better performance and lower costs, and deprecates P3-series instances.
* CloudFront (3.7.503.0)
	* Adding an optional field IpAddressType in CustomOriginConfig
* MQ (3.7.502.0)
	* Add CONFIG_MANAGED as a supported AuthenticationStrategy for Amazon MQ for RabbitMQ brokers. Make username and password optional on broker creation for CONFIG_MANAGED brokers.
* RDS (3.7.503.0)
	* This release adds support for MasterUserAuthenticationType parameter on CreateDBInstance, ModifyDBInstance, CreateDBCluster, and ModifyDBCluster operations.
* Route53 (3.7.502.0)
	* Amazon Route 53 now supports the Asia Pacific (New Zealand) Region (ap-southeast-6) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Route53Domains (3.7.502.0)
	* Added new ExtraParams AU_ELIGIBILITY_TYPE, AU_POLICY_REASON, and AU_REGISTRANT_NAME

### 3.7.1114.0 (2025-09-02 18:17 UTC)
* EC2 (3.7.510.0)
	* MaximumEbsAttachments and AttachmentLimitType fields added to DescribeInstanceTypesResponse. G6f, Gr6f, R8i, R8i-flex and p5.4xlarge instance types added to InstanceTypes enum.
* Neptune (3.7.502.0)
	* Removed the deprecated marker from publiclyAccessible parameter from DbInstance, CreateDbInstance and ModifyDbInstance and added relevant usage information for the parameter.
* Notifications (3.7.502.0)
	* Added Org support for notifications:  - `ListMemberAccounts` gets member accounts list, `AssociateOrganizationalUnit` links OU to notification configuration, `DisassociateOrganizationalUnit` removes OU from notification configuration, `ListOrganizationalUnits` shows OUs configured for notifications.
* WorkMail (3.7.502.0)
	* Make RoleArn an optional parameter for the PutEmailMonitoringConfiguration API, and add UnsupportedOperationException to RegisterToWorkMail.
* Core 3.7.500.13
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1113.0 (2025-08-29 18:17 UTC)
* BedrockRuntime (3.7.504.0)
	* Fixed stop sequence limit for converse API.
* EC2 (3.7.509.0)
	* Release shows new route types such as filtered and advertisement.
* XRay (3.7.502.0)
	* AWS X-Ray Features: Support Sampling Rate Boost On Anomaly
* Core 3.7.500.12
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1112.0 (2025-08-28 19:43 UTC)
* Amplify (3.7.501.0)
	* Remove incorrect endpoint tests
* ApplicationAutoScaling (3.7.501.0)
	* Remove incorrect endpoint tests
* ApplicationCostProfiler (3.7.501.0)
	* Remove incorrect endpoint tests
* AppRunner (3.7.501.1)
	* Doc only updates for APIs and and datatypes related to IPAddressType and Subnets for IPv6 dualstack support.
* AutoScalingPlans (3.7.501.0)
	* Remove incorrect endpoint tests
* BedrockRuntime (3.7.503.0)
	* Remove incorrect endpoint tests
* Cloud9 (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudHSMV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudSearchDomain (3.7.501.0)
	* Remove incorrect endpoint tests
* CodeDeploy (3.7.501.0)
	* Remove incorrect endpoint tests
* CodeGuruReviewer (3.7.501.0)
	* Remove incorrect endpoint tests
* Connect (3.7.505.0)
	* AgentStatusDrillDown feature in GetCurrentMetricData API. Adding AGENT_STATUS as filter and grouping in GetCurrentMetricData API
* ConnectCampaignService (3.7.501.0)
	* Remove incorrect endpoint tests
* DynamoDBv2 (3.7.504.0)
	* Remove incorrect endpoint tests
* EC2 (3.7.508.0)
	* This release adds support for copying Amazon EBS snapshot and AMIs to and from Local Zones.
* EC2InstanceConnect (3.7.501.0)
	* Remove incorrect endpoint tests
* ECR (3.7.501.0)
	* Remove incorrect endpoint tests
* ElasticMapReduce (3.7.501.0)
	* Remove incorrect endpoint tests
* EntityResolution (3.7.501.0)
	* Remove incorrect endpoint tests
* EventBridge (3.7.501.0)
	* Remove incorrect endpoint tests
* FIS (3.7.501.0)
	* Remove incorrect endpoint tests
* FMS (3.7.501.0)
	* Remove incorrect endpoint tests
* GeoMaps (3.7.501.0)
	* Remove incorrect endpoint tests
* GeoPlaces (3.7.501.0)
	* Remove incorrect endpoint tests
* Glue (3.7.505.0)
	* Adding support to fetch TargetDatabase field during GetDatabases with AttributesToGet
* GlueDataBrew (3.7.501.0)
	* Remove incorrect endpoint tests
* HealthLake (3.7.502.0)
	* Add ValidationLevel parameter to StartFHIRImportJob API, allowing users to specify a FHIR validation level for their asynchronous import jobs.
* InspectorScan (3.7.501.0)
	* Remove incorrect endpoint tests
* InternetMonitor (3.7.501.0)
	* Remove incorrect endpoint tests
* Kinesis (3.7.502.0)
	* Remove incorrect endpoint tests
* LicenseManagerUserSubscriptions (3.7.501.0)
	* Remove incorrect endpoint tests
* MachineLearning (3.7.501.0)
	* Remove incorrect endpoint tests
* ManagedBlockchainQuery (3.7.501.0)
	* Remove incorrect endpoint tests
* MarketplaceDeployment (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaStoreData (3.7.501.0)
	* Remove incorrect endpoint tests
* MTurk (3.7.501.0)
	* Remove incorrect endpoint tests
* NetworkFirewall (3.7.501.0)
	* Remove incorrect endpoint tests
* OAM (3.7.501.0)
	* Remove incorrect endpoint tests
* Omics (3.7.502.0)
	* Adds Amazon ECR pull through cache support to AWS HealthOmics, so you can more easily use container images from external sources.
* OpenSearchService (3.7.501.0)
	* Remove incorrect endpoint tests
* OSIS (3.7.501.0)
	* Remove incorrect endpoint tests
* PCS (3.7.503.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoice (3.7.501.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoiceV2 (3.7.502.0)
	* Remove incorrect endpoint tests
* Pipes (3.7.501.0)
	* Remove incorrect endpoint tests
* QuickSight (3.7.502.0)
	* Remove incorrect endpoint tests
* RDS (3.7.502.0)
	* Added RDS HTTP Endpoint feature support flag to DescribeOrderableDBInstanceOptions API
* Rekognition (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53Domains (3.7.501.0)
	* Remove incorrect endpoint tests
* SavingsPlans (3.7.501.0)
	* Remove incorrect endpoint tests
* Scheduler (3.7.501.0)
	* Remove incorrect endpoint tests
* ServiceQuotas (3.7.501.0)
	* Remove incorrect endpoint tests
* SimpleEmail (3.7.501.0)
	* Remove incorrect endpoint tests
* SimpleEmailV2 (3.7.502.0)
	* Remove incorrect endpoint tests
* SimpleWorkflow (3.7.501.0)
	* Remove incorrect endpoint tests
* SSMGuiConnect (3.7.501.0)
	* Remove incorrect endpoint tests
* SSMIncidents (3.7.501.0)
	* Remove incorrect endpoint tests
* SsmSap (3.7.502.0)
	* Added support for Configuration Checks on SAP HANA Applications.
* SSO (3.7.501.0)
	* Remove incorrect endpoint tests
* TimestreamQuery (3.7.501.0)
	* Remove incorrect endpoint tests
* WAF (3.7.501.0)
	* Remove incorrect endpoint tests
* WorkMailMessageFlow (3.7.501.0)
	* Remove incorrect endpoint tests
* XRay (3.7.501.0)
	* Remove incorrect endpoint tests

### 3.7.1111.0 (2025-08-27 19:27 UTC)
* ACMPCA (3.7.501.0)
	* Remove incorrect endpoint tests
* AmplifyBackend (3.7.501.0)
	* Remove incorrect endpoint tests
* AmplifyUIBuilder (3.7.501.0)
	* Remove incorrect endpoint tests
* AppConfigData (3.7.501.0)
	* Remove incorrect endpoint tests
* ApplicationDiscoveryService (3.7.501.0)
	* Remove incorrect endpoint tests
* ApplicationInsights (3.7.501.0)
	* Remove incorrect endpoint tests
* AppTest (3.7.501.0)
	* Remove incorrect endpoint tests
* Batch (3.7.500.14)
	* Added ECS_AL2023_NVIDIA as an option for Ec2Configuration.imageType.
* BedrockAgentCore (3.7.502.0)
	* Remove incorrect endpoint tests
* Chime (3.7.501.0)
	* Remove incorrect endpoint tests
* ChimeSDKIdentity (3.7.501.0)
	* Remove incorrect endpoint tests
* ChimeSDKMeetings (3.7.501.0)
	* Remove incorrect endpoint tests
* ChimeSDKVoice (3.7.501.0)
	* Remove incorrect endpoint tests
* CleanRoomsML (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudWatchEvidently (3.7.501.0)
	* Remove incorrect endpoint tests
* CodeBuild (3.7.503.0)
	* Remove incorrect endpoint tests
* CodeConnections (3.7.502.0)
	* Remove incorrect endpoint tests
* CodeGuruProfiler (3.7.501.0)
	* Remove incorrect endpoint tests
* ComputeOptimizer (3.7.501.0)
	* Remove incorrect endpoint tests
* DataPipeline (3.7.501.0)
	* Remove incorrect endpoint tests
* DirectoryService (3.7.502.0)
	* Add APIs for CA AutoEnrollment support: DescribeCAEnrollmentPolicy, EnableCAEnrollmentPolicy and DisableCAEnrollmentPolicy.
* EKS (3.7.503.0)
	* Add support for on-demand refresh of EKS cluster insights
* ElastiCache (3.7.501.0)
	* Remove incorrect endpoint tests
* FraudDetector (3.7.501.0)
	* Remove incorrect endpoint tests
* Inspector (3.7.501.0)
	* Remove incorrect endpoint tests
* IoT (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTFleetWise (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTWireless (3.7.501.0)
	* Remove incorrect endpoint tests
* Ivschat (3.7.501.0)
	* Remove incorrect endpoint tests
* IVSRealTime (3.7.501.0)
	* Remove incorrect endpoint tests
* KafkaConnect (3.7.501.0)
	* Remove incorrect endpoint tests
* KeyManagementService (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisVideo (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisVideoMedia (3.7.501.0)
	* Remove incorrect endpoint tests
* LakeFormation (3.7.501.0)
	* Remove incorrect endpoint tests
* LexModelBuildingService (3.7.501.0)
	* Remove incorrect endpoint tests
* MarketplaceReporting (3.7.501.0)
	* Remove incorrect endpoint tests
* MedicalImaging (3.7.501.0)
	* Remove incorrect endpoint tests
* Mgn (3.7.501.0)
	* Remove incorrect endpoint tests
* MigrationHubConfig (3.7.501.0)
	* Remove incorrect endpoint tests
* Neptune (3.7.501.0)
	* Remove incorrect endpoint tests
* NeptuneGraph (3.7.501.0)
	* Add StartGraph and StopGraph operations to Neptune Analytics
* Omics (3.7.501.0)
	* Remove incorrect endpoint tests
* OpsWorks (Removed)
	* AWS OpsWorks has been removed from the SDK because it has been discontinued.
* OpsWorksCM (Removed)
	* AWS OpsWorksCM has been removed from the SDK because it has been discontinued.
* PaymentCryptographyData (3.7.501.0)
	* Remove incorrect endpoint tests
* Personalize (3.7.501.0)
	* Remove incorrect endpoint tests
* PI (3.7.501.0)
	* Remove incorrect endpoint tests
* QApps (3.7.501.0)
	* Remove incorrect endpoint tests
* QLDBSession (3.7.501.0)
	* Remove incorrect endpoint tests
* Redshift (3.7.501.0)
	* Remove incorrect endpoint tests
* RoboMaker (3.7.501.0)
	* Remove incorrect endpoint tests
* S3Tables (3.7.501.0)
	* Remove incorrect endpoint tests
* SageMaker (3.7.509.0)
	* This release adds support for AutoScaling on SageMaker HyperPod.
* Schemas (3.7.501.0)
	* Remove incorrect endpoint tests
* SimpleNotificationService (3.7.501.0)
	* Remove incorrect endpoint tests
* SnowDeviceManagement (3.7.501.0)
	* Remove incorrect endpoint tests
* SupplyChain (3.7.501.0)
	* Remove incorrect endpoint tests
* Textract (3.7.501.0)
	* Remove incorrect endpoint tests
* TimestreamWrite (3.7.501.0)
	* Remove incorrect endpoint tests
* VoiceID (3.7.501.0)
	* Remove incorrect endpoint tests
* VPCLattice (3.7.501.0)
	* Remove incorrect endpoint tests
* WorkDocs (3.7.501.0)
	* Remove incorrect endpoint tests
* WorkMail (3.7.501.0)
	* Remove incorrect endpoint tests

### 3.7.1110.0 (2025-08-26 19:39 UTC)
* AppConfig (3.7.501.0)
	* Remove incorrect endpoint tests
* AppMesh (3.7.501.0)
	* Remove incorrect endpoint tests
* AppRegistry (3.7.501.0)
	* Remove incorrect endpoint tests
* AppRunner (3.7.501.0)
	* Remove incorrect endpoint tests
* ARCZonalShift (3.7.501.0)
	* This release adds new API options to enable allowed windows and multiple alarms for practice runs.
* BedrockAgentCoreControl (3.7.501.0)
	* Remove incorrect endpoint tests
* CleanRooms (3.7.502.0)
	* Remove incorrect endpoint tests
* CloudWatch (3.7.501.0)
	* Remove incorrect endpoint tests
* CodeCommit (3.7.501.0)
	* Remove incorrect endpoint tests
* CodeStarconnections (3.7.501.0)
	* Remove incorrect endpoint tests
* ComprehendMedical (3.7.501.0)
	* Remove incorrect endpoint tests
* ConnectContactLens (3.7.501.0)
	* Remove incorrect endpoint tests
* ConnectParticipant (3.7.502.0)
	* Amazon Connect Participant Service: Remove unused fields from WebRTCConnection
* ControlCatalog (3.7.501.0)
	* Remove incorrect endpoint tests
* DataSync (3.7.501.0)
	* Remove incorrect endpoint tests
* DLM (3.7.501.0)
	* Remove incorrect endpoint tests
* Drs (3.7.501.0)
	* Remove incorrect endpoint tests
* EC2 (3.7.507.0)
	* Add new APIs for viewing how your shared AMIs are used by other accounts, and identify resources in your account that are dependent on particular AMIs
* ElasticTranscoder (3.7.501.0)
	* Remove incorrect endpoint tests
* Evs (3.7.502.0)
	* Remove incorrect endpoint tests
* Finspace (3.7.501.0)
	* Remove incorrect endpoint tests
* GameLift (3.7.501.0)
	* Remove incorrect endpoint tests
* GeoRoutes (3.7.501.0)
	* Added RouteFerryNotice PotentialViolatedVehicleRestrictionUsage value for CalculateRoutes. This value indicates when the Route is potentially forbidden for the given vehicle profile.
* Glacier (3.7.501.0)
	* Remove incorrect endpoint tests
* GlobalAccelerator (3.7.501.0)
	* Remove incorrect endpoint tests
* Greengrass (3.7.501.0)
	* Remove incorrect endpoint tests
* IdentityStore (3.7.501.0)
	* Remove incorrect endpoint tests
* Imagebuilder (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTJobsDataPlane (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTSecureTunneling (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTTwinMaker (3.7.501.0)
	* Remove incorrect endpoint tests
* Kafka (3.7.501.0)
	* Remove incorrect endpoint tests
* LicenseManagerLinuxSubscriptions (3.7.501.0)
	* Remove incorrect endpoint tests
* LookoutforVision (3.7.501.0)
	* Remove incorrect endpoint tests
* MainframeModernization (3.7.501.0)
	* Remove incorrect endpoint tests
* MigrationHub (3.7.501.0)
	* Remove incorrect endpoint tests
* MigrationHubRefactorSpaces (3.7.501.0)
	* Remove incorrect endpoint tests
* MQ (3.7.501.0)
	* Remove incorrect endpoint tests
* Neptunedata (3.7.501.0)
	* Remove incorrect endpoint tests
* PcaConnectorScep (3.7.501.0)
	* Remove incorrect endpoint tests
* PersonalizeEvents (3.7.501.0)
	* Remove incorrect endpoint tests
* Pinpoint (3.7.501.0)
	* Remove incorrect endpoint tests
* Polly (3.7.502.0)
	* Remove incorrect endpoint tests
* RAM (3.7.501.0)
	* Remove incorrect endpoint tests
* RDSDataService (3.7.501.0)
	* Remove incorrect endpoint tests
* RecycleBin (3.7.501.0)
	* Remove incorrect endpoint tests
* ResourceExplorer2 (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53 (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53RecoveryCluster (3.7.501.0)
	* Remove incorrect endpoint tests
* SageMakerGeospatial (3.7.501.0)
	* Remove incorrect endpoint tests
* SecretsManager (3.7.501.0)
	* Remove incorrect endpoint tests
* SecurityHub (3.7.502.0)
	* Remove incorrect endpoint tests
* Signer (3.7.501.0)
	* Remove incorrect endpoint tests
* SimpleSystemsManagement (3.7.501.0)
	* Remove incorrect endpoint tests
* SocialMessaging (3.7.501.0)
	* Remove incorrect endpoint tests
* SsmSap (3.7.501.0)
	* Remove incorrect endpoint tests
* SSOOIDC (3.7.501.0)
	* Remove incorrect endpoint tests
* Tnb (3.7.501.0)
	* Remove incorrect endpoint tests
* Transfer (3.7.501.0)
	* Remove incorrect endpoint tests
* TrustedAdvisor (3.7.501.0)
	* Remove incorrect endpoint tests
* WAFRegional (3.7.501.0)
	* Remove incorrect endpoint tests
* WorkSpaces (3.7.502.0)
	* Remove incorrect endpoint tests
* Core 3.7.500.11
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1109.0 (2025-08-25 20:57 UTC)
* B2bi (3.7.502.0)
	* Updated APIs to support custom validation rules.
* CodeGuruSecurity (3.7.500.10)
	* Documentation update to notify users of the discontinuation of Amazon CodeGuru Security.
* DataZone (3.7.503.0)
	* Releasing the following features - Asset classification that lets users use restricted terms for classifying assets if they have the right permissions. Also adding a new enum value "Moving" to project status.
* EC2 (3.7.506.0)
	* Added IPv6 support for AWS Client VPN.
* MediaConvert (3.7.502.0)
	* This release adds support for input rendition selection for HLS input, adds new Share API to enable sharing jobs with AWS Support for support investigations, and adds INCLUDE_AS_TS to iFrameOnlyManifest setting for HLS outputs.
* QBusiness (3.7.502.0)
	* The Amazon Q Business GetDocumentContent operation now supports retrieval of the extracted text content in JSON format.
* SQS (3.7.501.1)
	* Documentation update for Amazon SQS Supports Large Payload Message feature
* TimestreamInfluxDB (3.7.502.0)
	* Add MAINTENANCE status for DbInstance and DbCluster
* Core 3.7.500.10
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1108.0 (2025-08-22 19:13 UTC)
* Account (3.7.501.0)
	* Remove incorrect endpoint tests
* APIGateway (3.7.501.0)
	* Remove incorrect endpoint tests
* ApiGatewayV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* AugmentedAIRuntime (3.7.501.0)
	* Remove incorrect endpoint tests
* AWSMarketplaceCommerceAnalytics (3.7.501.0)
	* Remove incorrect endpoint tests
* B2bi (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudDirectory (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudWatchRUM (3.7.501.0)
	* Remove incorrect endpoint tests
* CodePipeline (3.7.501.0)
	* Remove incorrect endpoint tests
* CognitoSync (3.7.501.0)
	* Remove incorrect endpoint tests
* DataExchange (3.7.501.0)
	* Remove incorrect endpoint tests
* DocDB (3.7.501.0)
	* Remove incorrect endpoint tests
* ElasticLoadBalancing (3.7.501.0)
	* Remove incorrect endpoint tests
* EMRServerless (3.7.501.0)
	* Remove incorrect endpoint tests
* HealthLake (3.7.501.0)
	* Remove incorrect endpoint tests
* IAMRolesAnywhere (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTAnalytics (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisFirehose (3.7.501.0)
	* Remove incorrect endpoint tests
* LaunchWizard (3.7.501.0)
	* Remove incorrect endpoint tests
* LocationService (3.7.501.0)
	* Remove incorrect endpoint tests
* Macie2 (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaLive (3.7.502.0)
	* AWS Elemental MediaLive now has a field called "SubtitleRows" for controlling subtitle row count for DVB-Sub and Burn-In captions outputs
* MemoryDB (3.7.501.0)
	* Remove incorrect endpoint tests
* MigrationHubOrchestrator (3.7.501.0)
	* Remove incorrect endpoint tests
* NetworkMonitor (3.7.501.0)
	* Remove incorrect endpoint tests
* Organizations (3.7.502.0)
	* Remove incorrect endpoint tests
* PaymentCryptography (3.7.501.0)
	* Remove incorrect endpoint tests
* Pricing (3.7.501.0)
	* Remove incorrect endpoint tests
* Proton (3.7.501.0)
	* Remove incorrect endpoint tests
* QConnect (3.7.501.0)
	* Releasing model ID support for UpdateAIPrompt
* QLDB (3.7.501.0)
	* Remove incorrect endpoint tests
* RDS (3.7.501.7)
	* Updates Amazon RDS documentation for Db2 read-only replicas.
* RedshiftDataAPIService (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53RecoveryReadiness (3.7.501.0)
	* Remove incorrect endpoint tests
* SageMaker (3.7.508.0)
	* Launch SageMaker Notebook Instances support for AL2023 along with P6-B200 instance type and Rootless Docker support for SageMaker Studio.
* SageMakerMetrics (3.7.501.0)
	* Remove incorrect endpoint tests
* ServiceDiscovery (3.7.501.3)
	* Updating SDK examples after launch of shared AWS Cloud Map namespaces
* SimSpaceWeaver (3.7.501.0)
	* Remove incorrect endpoint tests
* SQS (3.7.501.0)
	* Remove incorrect endpoint tests
* Synthetics (3.7.501.0)
	* Added multi browser support for synthetics canaries, Increased ephemeral storage limit from 5GB to 10GB
* WAFV2 (3.7.501.0)
	* test and verified, safe to release

### 3.7.1107.0 (2025-08-21 19:46 UTC)
* AccessAnalyzer (3.7.501.0)
	* Remove incorrect endpoint tests
* ApiGatewayManagementApi (3.7.501.0)
	* Remove incorrect endpoint tests
* AppFabric (3.7.501.0)
	* Remove incorrect endpoint tests
* AppIntegrationsService (3.7.501.0)
	* Remove incorrect endpoint tests
* AppStream (3.7.501.0)
	* Remove incorrect endpoint tests
* Artifact (3.7.501.0)
	* Remove incorrect endpoint tests
* AuditManager (3.7.502.0)
	* Remove incorrect endpoint tests
* Backup (3.7.501.0)
	* Remove incorrect endpoint tests
* BackupGateway (3.7.501.0)
	* Remove incorrect endpoint tests
* BedrockAgentRuntime (3.7.501.0)
	* Remove incorrect endpoint tests
* BillingConductor (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudFront (3.7.502.0)
	* Remove incorrect endpoint tests
* CloudHSM (3.7.501.0)
	* Remove incorrect endpoint tests
* CloudTrail (3.7.501.0)
	* Remove incorrect endpoint tests
* CognitoIdentity (3.7.501.0)
	* Remove incorrect endpoint tests
* Comprehend (3.7.501.0)
	* Remove incorrect endpoint tests
* ConfigService (3.7.501.0)
	* Remove incorrect endpoint tests
* Connect (3.7.504.0)
	* Remove incorrect endpoint tests
* ConnectCampaignsV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* ConnectCases (3.7.501.0)
	* Remove incorrect endpoint tests
* ConnectWisdomService (3.7.501.0)
	* Remove incorrect endpoint tests
* CostOptimizationHub (3.7.501.0)
	* Remove incorrect endpoint tests
* CustomerProfiles (3.7.501.0)
	* Remove incorrect endpoint tests
* DatabaseMigrationService (3.7.501.0)
	* Remove incorrect endpoint tests
* Deadline (3.7.502.0)
	* Remove incorrect endpoint tests
* DirectoryService (3.7.501.0)
	* Remove incorrect endpoint tests
* DirectoryServiceData (3.7.501.0)
	* Remove incorrect endpoint tests
* DynamoDBv2 (3.7.503.0)
	* Remove incorrect endpoint tests
* EBS (3.7.501.0)
	* Remove incorrect endpoint tests
* ECRPublic (3.7.501.0)
	* Remove incorrect endpoint tests
* ECS (3.7.500.9)
	* This is a documentation only release that adds additional information for the update-service request parameters.
* ElasticBeanstalk (3.7.501.0)
	* Remove incorrect endpoint tests
* ElasticLoadBalancingV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* Elasticsearch (3.7.501.0)
	* Remove incorrect endpoint tests
* ForecastQueryService (3.7.501.0)
	* Remove incorrect endpoint tests
* GameLiftStreams (3.7.502.0)
	* The default application in a stream group can now be changed at any time using UpdateStreamGroup to update the DefaultApplicationIdentifier.
* Glue (3.7.504.0)
	* Added support for preprocessing queries in Data Quality operations through new DataQualityGlueTable structure.
* GreengrassV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* GuardDuty (3.7.503.0)
	* Remove Pattern trait from email field
* Inspector2 (3.7.502.0)
	* Remove incorrect endpoint tests
* IoTDeviceAdvisor (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTEvents (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTEventsData (3.7.501.0)
	* Remove incorrect endpoint tests
* IoTThingsGraph (3.7.501.0)
	* Remove incorrect endpoint tests
* IVS (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisVideoSignalingChannels (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisVideoWebRTCStorage (3.7.501.0)
	* Remove incorrect endpoint tests
* LexRuntimeV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* Lightsail (3.7.502.0)
	* Remove incorrect endpoint tests
* LookoutMetrics (3.7.501.0)
	* Remove incorrect endpoint tests
* ManagedBlockchain (3.7.501.0)
	* Remove incorrect endpoint tests
* ManagedGrafana (3.7.501.0)
	* Remove incorrect endpoint tests
* MarketplaceAgreement (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaConnect (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaConvert (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaPackage (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaPackageV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* MediaTailor (3.7.501.0)
	* Remove incorrect endpoint tests
* MWAA (3.7.501.0)
	* Remove incorrect endpoint tests
* ObservabilityAdmin (3.7.502.0)
	* Remove incorrect endpoint tests
* Panorama (3.7.501.0)
	* Remove incorrect endpoint tests
* PinpointEmail (3.7.501.0)
	* Remove incorrect endpoint tests
* PrometheusService (3.7.502.0)
	* Remove incorrect endpoint tests
* ResourceGroups (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53Profiles (3.7.501.0)
	* Remove incorrect endpoint tests
* Route53Resolver (3.7.501.0)
	* Remove incorrect endpoint tests
* S3Outposts (3.7.501.0)
	* Remove incorrect endpoint tests
* SecurityLake (3.7.501.0)
	* Remove incorrect endpoint tests
* SecurityToken (3.7.501.0)
	* Remove incorrect endpoint tests
* SSMContacts (3.7.500.9)
	* Doc-only updates for Incident Manager Contacts August 2025
* SSMQuickSetup (3.7.501.0)
	* Remove incorrect endpoint tests
* TimestreamInfluxDB (3.7.501.0)
	* Remove incorrect endpoint tests
* VerifiedPermissions (3.7.501.0)
	* Remove incorrect endpoint tests
* WorkSpacesWeb (3.7.501.0)
	* Remove incorrect endpoint tests
* Core 3.7.500.9
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1106.0 (2025-08-20 18:44 UTC)
* AWSMarketplaceMetering (3.7.501.0)
	* Remove incorrect endpoint tests
* BedrockRuntime (3.7.502.0)
	* Launch CountTokens API to allow token counting
* Billing (3.7.502.0)
	* Clarify IPv4 and IPv6 endpoints
* Budgets (3.7.502.0)
	* Remove incorrect endpoint tests
* CognitoIdentityProvider (3.7.502.0)
	* This release adds support for the new Terms APIs which allow displaying Terms of Use and Privacy Policy on the Managed Login user-registration page.
* CostExplorer (3.7.501.0)
	* Remove incorrect endpoint tests
* DataZone (3.7.502.0)
	* This release supports policy grant identifier for cloud formation integration
* Detective (3.7.501.0)
	* Remove incorrect endpoint tests
* DynamoDBv2 (3.7.502.0)
	* Remove incorrect endpoint tests
* EKS (3.7.502.0)
	* EKS Add-ons Custom Namespace Support
* ElasticFileSystem (3.7.501.0)
	* Remove incorrect endpoint tests
* IdentityManagement (3.7.501.0)
	* Remove incorrect endpoint tests
* Kinesis (3.7.501.0)
	* Remove incorrect endpoint tests
* KinesisAnalyticsV2 (3.7.501.0)
	* Adds Key Management Service (KMS) support allowing customer-managed key (CMK) encryption for Flink application data.
* MarketplaceEntitlementService (3.7.501.0)
	* Remove incorrect endpoint tests
* NetworkManager (3.7.501.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoiceV2 (3.7.501.0)
	* This change added InternationalSendingEnbaled as part of describe/Update/Request phone number API response, and as part of update/Request phone number API request
* Route53RecoveryControlConfig (3.7.501.0)
	* Remove incorrect endpoint tests
* S3 (3.7.500.8)
	* Decorated AnalyticsId, StorageClassAnalysis properties in AnalyticsConfiguration class and AnalyticsConfiguration property in PutBucketAnalyticsConfigurationRequest class with [AWSProperty(Required = true)] attribute per S3 service API model.
* SageMaker (3.7.507.0)
	* This release adds 1/ Launch ml.p5.4xlarge instance in Processing jobs, Training jobs and Training Plan 2/ Makes S3Uri to be required for S3FileSystem and S3FileSystemConfig.
* SimpleEmailV2 (3.7.501.0)
	* Remove incorrect endpoint tests
* Core 3.7.500.8
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1105.0 (2025-08-19 18:20 UTC)
* CleanRooms (3.7.501.0)
	* Support error message configuration for analysis templates
* EC2 (3.7.505.0)
	* Add support for "warning" volume status.
* Polly (3.7.501.0)
	* Added support for new output format - Opus.

### 3.7.1104.0 (2025-08-18 18:30 UTC)
* Batch (3.7.500.9)
	* Added default_x86_64 and default_arm64 as values to the instanceTypes field.
* BCMDashboards (3.7.500.0)
	* Billing and Cost Management Dashboards enables users to create dashboards that combine multiple visualizations of cost and usage data. Users can create, manage, and share dashboards. Tags are also available for dashboards.
* Connect (3.7.503.0)
	* Amazon Connect Service Feature: Add support to enable multi-user in-app, web, and video calling.
* ConnectParticipant (3.7.501.0)
	* Amazon Connect Service Feature: Add support to enable multi-user in-app, web, and video calling.
* S3Control (3.7.501.0)
	* Adds support for Compute checksum functionality in Amazon S3 Batch Operations. You can now calculate checksums for a list of objects using supported algorithms in Amazon S3, without requiring a restore or download
* SageMaker (3.7.506.0)
	* Customer managed keys now available for volume encryption of SageMaker HyperPod clusters.

### 3.7.1103.0 (2025-08-15 18:25 UTC)
* BedrockAgent (3.7.501.0)
	* This release adds support for saving Bedrock Flows while node configuration is still in progress, even if the Flow is not yet able to be invoked
* Glue (3.7.503.0)
	* AWS Glue Zero ETL now supports On-demand snapshot load
* PrometheusService (3.7.501.0)
	* Add Resource-based Policy APIs for Amazon Prometheus

### 3.7.1102.0 (2025-08-14 18:38 UTC)
* ARCRegionswitch (3.7.501.0)
	* Endpoint rule test and documentation update.
* BCMRecommendedActions (3.7.500.0)
	* Initial SDK release for AWS Billing and Cost Management Recommended Actions.
* DirectConnect (3.7.501.0)
	* Added pagination support for DescribeHostedConnections, DescribeVirtualInterfaces, DescribeConnections, DescribeInterconnects, DescribeLags. Added asnLong support for BGP peer operations which supports a large range.
* DynamoDBv2 (3.7.501.0)
	* This release 1/ Adds support for throttled keys mode for CloudWatch Contributor Insights, 2/ Adds throttling reasons to exceptions across dataplane APIs. 3/ Explicitly models ThrottlingException as a class in statically typed languages. Refer to the launch day blog post for more details.
* EC2 (3.7.504.0)
	* This release adds ModifyInstanceConnectEndpoint API to update configurations on existing EC2 Instance Connect Endpoints and improves IPv6 support through dualstack DNS names for EC2 Instance Connect Endpoints.
* FSx (3.7.502.0)
	* Amazon FSx for NetApp ONTAP 2nd generation file systems now support decreasing SSD storage capacity.
* Glue (3.7.502.0)
	* AWS Glue now supports Trusted Identity Propagation.
* GuardDuty (3.7.502.0)
	* Added support for entity lists.
* MediaLive (3.7.501.0)
	* CMAF Ingest output groups in MediaLive can now accept one additional destination url for single pipeline channels and up to two additional destination urls for standard channels.
* PCS (3.7.502.0)
	* Updated the regex pattern and description of iamInstanceProfileArn in the CreateComputeNodeGroup and UpdateComputeNodeGroup API actions. Name and path requirements apply to the ARN of the IAM role associated with the instance profile and not the ARN of the instance profile.
* QApps (3.7.500.8)
	* Documentation update for Amazon Q Apps API Reference
* ServiceDiscovery (3.7.501.0)
	* Added support for cross account through Id parameter overloading with ARN and allow owner account for some APIs instead of ARN
* WorkSpaces (3.7.501.0)
	* New APIs introduced to import WorkSpaces BYOL image using a new process that leveraged EC2 Image Builder. WorkSpaces tests and fixes your image's compatibility issues and supports customized VM images.

### 3.7.1101.0 (2025-08-13 18:21 UTC)
* Braket (3.7.501.0)
	* Add support for Braket program sets.
* DataZone (3.7.501.0)
	* Adds support for account pools and project profile account decoupling
* FSx (3.7.501.0)
	* Add Dual-Stack support for Amazon FSx for OpenZFS file systems
* PartnerCentralSelling (3.7.502.0)
	* Add Tagging Support for Opportunity resources
* SageMaker (3.7.505.0)
	* This release introduces compute quota for GPU, Trainium accelerators, vCPU, and vCPU memory utilization across teams in HyperPod clusters
* SecurityIR (3.7.502.0)
	* Added support for Organizational Unit-level Membership configuration and the ability to resume a cancelled membership.

### 3.7.1100.0 (2025-08-12 18:21 UTC)
* BackupSearch (3.7.502.0)
	* Using recommended smithy trait to generate regional endpoints for Backup Search
* CodeBuild (3.7.502.0)
	* AWS CodeBuild now supports PullRequestBuildPolicy in webhook object.
* EC2 (3.7.503.0)
	* Release to allow route table association with a PublicIpv4Pool.
* Organizations (3.7.501.0)
	* This release introduces 2 new APIs in Organizations: 1. ListAccountsWithInvalidEffectivePolicy 2. ListEffectivePolicyValidationErrors
* SageMaker (3.7.504.0)
	* IAM Identity Center trusted identity propagation is now supported in SageMaker Studio.
* TranscribeService (3.7.501.0)
	* AWS HealthScribe now supports specifying preferred patient pronouns through the MedicalScribeContext parameter for use in the generated clinical notes.
* Core 3.7.500.7
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1099.0 (2025-08-11 18:25 UTC)
* Bedrock (3.7.502.0)
	* This release includes model updates and enhanced SDK documentation for union fields in automated reasoning policy components. Added docs cover policy definitions, mutations (add/update for rules/types/variables), build assets, workflow sources, test results, and tag exception handling.
* CognitoIdentityProvider (3.7.501.0)
	* Remove SigV4 auth requirement for GetTokensFromRefreshToken
* Connect (3.7.502.0)
	* Updating SearchUserHierarchyGroups API
* Deadline (3.7.501.0)
	* Adds support for Wait and Save feature in service-managed fleets
* EC2 (3.7.502.0)
	* This release adds AvailabilityZoneId support for CreateVolume, DescribeVolume, LaunchTemplates, RunInstances, DescribeInstances, CreateDefaultSubnet, SpotInstances, and CreateDefaultSubnet APIs.
* Evs (3.7.501.4)
	* Update for general availability of Amazon Elastic VMware Service (EVS).
* Lambda (3.7.500.6)
	* Doc-only update for Lambda that updates the maximum payload size for response streaming invocations to 200 MB.
* QuickSight (3.7.501.0)
	* Add RowAxisDisplayOptions and ColumnAxisDisplayOptions to HeatMapConfiguration, add Actions to PluginVisual, increase limit for CalculatedFields list
* SSOAdmin (3.7.501.0)
	* Added support for managing user background session for applications
* Core 3.7.500.6
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1098.0 (2025-08-08 18:50 UTC)
* ApplicationSignals (3.7.501.0)
	* Removed incorrect endpoint tests
* BackupSearch (3.7.501.0)
	* Removed incorrect endpoint tests
* BCMPricingCalculator (3.7.501.0)
	* Removed incorrect endpoint tests
* Billing (3.7.501.0)
	* Removed incorrect endpoint tests
* Connect (3.7.501.0)
	* This release adds a new API GetContactMetrics for Amazon Connect.
* DSQL (3.7.501.0)
	* Removed incorrect endpoint tests
* GameLiftStreams (3.7.501.0)
	* Removed incorrect endpoint tests
* Inspector2 (3.7.501.0)
	* Add CVSSV4 to Vulnerability Search API and update enable/disable account id list length to 5
* Invoicing (3.7.501.0)
	* Removed incorrect endpoint tests
* IotData (3.7.501.0)
	* Adding DeleteConnection API to IoT Data Plane
* IoTManagedIntegrations (3.7.501.0)
	* Removed incorrect endpoint tests
* KeyspacesStreams (3.7.501.0)
	* Removed incorrect endpoint tests
* MPA (3.7.501.0)
	* Removed incorrect endpoint tests
* NetworkFlowMonitor (3.7.501.0)
	* Removed incorrect endpoint tests
* Notifications (3.7.501.0)
	* Removed incorrect endpoint tests
* NotificationsContacts (3.7.501.0)
	* Removed incorrect endpoint tests
* PartnerCentralSelling (3.7.501.0)
	* Removed incorrect endpoint tests
* S3Vectors (3.7.501.0)
	* Removed incorrect endpoint tests
* SageMaker (3.7.503.0)
	* Adds support for GB200 UltraServers in Amazon SageMaker training jobs, training plans, and HyperPod clusters
* SecurityIR (3.7.501.0)
	* Removed incorrect endpoint tests
* TranscribeService (3.7.500.5)
	* Update documentation to use key ARN only in OutputEncryptionKMSKeyId request parameter
* WorkspacesInstances (3.7.501.0)
	* Removed incorrect endpoint tests
* Core 3.7.500.5
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1097.0 (2025-08-07 18:31 UTC)
* Batch (3.7.500.5)
	* This feature allows customers to use AWS Batch with Linux with ARM64 CPU Architecture with Fargate Spot compute support.
* CloudFront (3.7.501.0)
	* Added new viewer security policy, TLSv1.3_2025, for CloudFront.
* CodeBuild (3.7.501.0)
	* AWS CodeBuild now supports comment-based pull request control.
* GameLiftStreams (3.7.500.5)
	* Adds Proton 9.0-2 to the list of runtime environment options available when creating an Amazon GameLift Streams application
* Glue (3.7.501.0)
	* AWS Glue Data Catalog now supports Iceberg Optimization settings at the Catalog level, and supports new options to control the optimization job run rate.
* GuardDuty (3.7.501.0)
	* Added support for VPC owner account ID associated with DNS request in the GuardDuty finding.

### 3.7.1096.0 (2025-08-06 18:31 UTC)
* AppStream (3.7.500.4)
	* Added support for G6 instances
* Budgets (3.7.501.0)
	* Adds support for billing views. Billing views let you control access to cost and usage data through an AWS resource, streamlining the process of sharing cost and usage data across account boundaries. With this release, you can now create and view budgets based on billing views.
* EC2 (3.7.501.0)
	* Mark Elastic Inference Accelerators and Elastic Graphics Processor parameters as deprecated on the RunInstances and LaunchTemplate APIs.
* OpenSearchServerless (3.7.501.0)
	* Features: add Index APIs in OpenSearchServerless to support managed semantic enrichment
* QBusiness (3.7.501.0)
	* Amazon Q Business now supports the GetDocumentContent() API that enables customers to securely access the source documents through clickable citation links at query time
* Core 3.7.500.4
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1095.0 (2025-08-05 18:29 UTC)
* Bedrock (3.7.501.0)
	* This release introduces Automated Reasoning checks for Amazon Bedrock Guardrails. The feature adds new APIs for policy building, refinement, version management, and testing. Guardrail APIs now support Automated Reasoning policy configuration and validation output.
* BedrockRuntime (3.7.501.0)
	* This release adds support for Automated Reasoning checks output models for the Amazon Bedrock Guardrails ApplyGuardrail API.
* EKS (3.7.501.0)
	* Add support for deletion protection on EKS clusters
* RDS (3.7.501.0)
	* Adds a new Aurora Serverless v2 attribute to the DBCluster resource to expose the platform version. Also updates the attribute to be part of both the engine version and platform version descriptions.
* SageMaker (3.7.502.0)
	* Add support for SageMaker Hyperpod continuous scaling and custom AMI; Introduce new APIs: ListClusterEvents, DescribeClusterEvent, BatchAddClusterNodes
* Core 3.7.500.3
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1094.0 (2025-08-04 21:42 UTC)
* BedrockAgentCore (3.7.501.0)
	* Remove superfluous field from API
* CodeConnections (3.7.501.0)
	* New integration with Azure DevOps provider type.
* Evs (3.7.501.0)
	* TagResource API now throws ServiceQuotaExceededException when the number of tags on the Amazon EVS resource exceeds the maximum allowed. TooManyTagsException is deprecated.
* IoTSiteWise (3.7.501.0)
	* Support Interface for IoT SiteWise Asset Modeling
* SageMaker (3.7.501.0)
	* This release adds the ability for customers to attach and detach their EBS volumes to EKS-orchestrated HyperPod cluster nodes.
* Core 3.7.500.2
	* Update HTTP handler to handle scenario where content stream position is not zero (https://github.com/aws/aws-sdk-net/issues/3941)
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1093.0 (2025-08-01 18:22 UTC)
* ACMPCA (3.7.500.1)
	* Doc-only update to add more information to GetCertificate action.
* AIOps (3.7.501.0)
	* This release includes fix for InvestigationGroup timestamp conversion issue.
* ARCRegionswitch (3.7.500.0)
	* This is the initial SDK release for Region switch
* AuditManager (3.7.501.0)
	* Added a note to Framework APIs (CreateAssessmentFramework, GetAssessmentFramework, UpdateAssessmentFramework) clarifying that the Controls object returns a partial response when called through Framework APIs. Added documentation that the Framework's controlSources parameter is no longer supported.
* Lightsail (3.7.501.0)
	* This release adds support for the Asia Pacific (Jakarta) (ap-southeast-3) Region.
* ObservabilityAdmin (3.7.501.0)
	* CloudWatch Observability Admin adds the ability to enable telemetry on AWS resources such as Amazon VPCs (Flow Logs) in customers AWS Accounts and Organizations. The release introduces new APIs to manage telemetry rules, which define telemetry settings to be applied on AWS resources.
* PCS (3.7.501.0)
	* Add support for IPv6 Networking for Clusters.
* SecurityHub (3.7.501.0)
	* Release new resource detail type CodeRepository
* SimpleNotificationService (3.7.500.1)
	* Amazon SNS support for Amazon SQS fair queues
* Core 3.7.500.1
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1092.0 (2025-07-31 18:27 UTC)
* CustomerProfiles (3.7.500.0)
	* The release updates standard profile with 2 new fields that supports account-level engagement. Updated APIs include CreateProfile, UpdateProfile, MergeProfiles, SearchProfiles, BatchGetProfile, GetSegmentMembership, CreateSegmentDefinition, CreateSegmentEstimate.
* EC2 (3.7.500.0)
	* Added support for the force option for the EC2 instance terminate command. This feature enables customers to recover resources associated with an instance stuck in the shutting-down state as a result of rare issues caused by a frozen operating system or an underlying hardware problem.
* ElasticLoadBalancingV2 (3.7.500.0)
	* This release enables secondary IP addresses for Network Load Balancers.
* EntityResolution (3.7.500.0)
	* Add support for creating advanced rule-based matching workflows in AWS Entity Resolution.
* Glue (3.7.500.0)
	* Added support for Route node, S3 Iceberg sources/targets, catalog Iceberg sources, DynamoDB ELT connector, AutoDataQuality evaluation, enhanced PII detection with redaction, Kinesis fan-out support, and new R-series worker types.
* Inspector2 (3.7.500.0)
	* Extend usage to include agentless hours and add CODE_REPOSITORY to aggregation resource type
* IoT (3.7.500.0)
	* This release allows AWS IoT Core users to use their own AWS KMS keys for data protection
* OpenSearchService (3.7.500.0)
	* Granular access control support for NEO-SAML with IAMFederation for AOS data source
* QuickSight (3.7.500.0)
	* Added Impala connector support
* S3Control (3.7.500.0)
	* Add Tags field to CreateAccessPoint
* SimpleEmailV2 (3.7.500.0)
	* This release introduces support for Multi-tenant management
* WorkSpacesWeb (3.7.500.0)
	* Added ability to log session activity on a portal to an S3 bucket.
* Core 3.7.500.0
	* Changed Legacy configuration defaults for StsRegionalEndpoints to StsRegionalEndpointsValue.Regional.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1091.0 (2025-07-30 19:10 UTC)
* CloudFront (3.7.407.0)
	* This release adds new origin timeout options: 1) ResponseCompletionTimeout and 2) OriginReadTimeout (for S3 origins)
* DirectoryService (3.7.402.0)
	* This release adds support for AWS Managed Microsoft AD Hybrid Edition, introducing new operations: StartADAssessment, DescribeADAssessment, ListADAssessments, DeleteADAssessment, CreateHybridAD, UpdateHybridAD, and DescribeHybridADUpdate; and updated existing operation: DescribeDirectories.
* DocDB (3.7.403.0)
	* Add support for setting Serverless Scaling Configuration on clusters.
* EC2 (3.7.463.0)
	* Release to show the next hop IP address for routes propagated by VPC Route Server into VPC route tables.
* IoTWireless (3.7.404.0)
	* Added TxPowerIndexMin, TxPowerIndexMax, NbTransMin and NbTransMax params to ServiceProfile.
* Core 3.7.402.91
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1090.0 (2025-07-29 18:21 UTC)
* Batch (3.7.408.0)
	* AWS Batch for SageMaker Training jobs feature support.  Includes new APIs for service job submission (e.g., SubmitServiceJob) and managing service environments (e.g., CreateServiceEnvironment) that enable queueing SageMaker Training jobs.
* CleanRooms (3.7.407.0)
	* This feature provides the ability to update the table reference and allowed columns on an existing configured table.
* Deadline (3.7.412.0)
	* Adds support for tag management on monitors.
* LocationService (3.7.402.0)
	* This release 1) adds support for multi-polygon geofences with disconnected territories, and 2) enables polygon exclusion zones within geofences for more accurate representation of real-world boundaries.
* OpenSearchServerless (3.7.404.0)
	* This is to support Granular access control support for SAML with IAMFedraton in AOSS
* Core 3.7.402.90
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1089.0 (2025-07-28 19:48 UTC)
* DirectConnect (3.7.403.0)
	* Enable MACSec support and features on Interconnects.
* IoTSiteWise (3.7.405.0)
	* Add support for native anomaly detection in IoT SiteWise using new Computation Model APIs
* OSIS (3.7.401.0)
	* Add Pipeline Role Arn as an optional parameter to the create / update pipeline APIs as an alternative to passing in the pipeline configuration body
* Core 3.7.402.89
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1088.0 (2025-07-25 18:31 UTC)
* AppIntegrationsService (3.7.402.0)
	* Amazon AppIntegrations introduces new configuration capabilities to enable customers to manage iframe permissions, control application refresh behavior (per contact or per browser/cross-contact), and run background applications (service).
* Budgets (3.7.404.0)
	* Adds IPv6 and PrivateLink support for AWS Budgets in IAD.
* ConfigService (3.7.403.12)
	* Documentation improvements have been made to the EvaluationModel and DescribeConfigurationRecorders APIs.
* EC2 (3.7.462.0)
	* Transit Gateway native integration with AWS Network Firewall. Adding new enum value for the new Transit Gateway Attachment type.
* KeyManagementService (3.7.403.18)
	* Doc only update: fixed grammatical errors.
* MediaPackageV2 (3.7.408.0)
	* This release adds support for specifying a preferred input for channels using CMAF ingest.
* SocialMessaging (3.7.402.0)
	* This release introduces new WhatsApp template management APIs that enable customers to programmatically create and submit templates for approval, monitor approval status, and manage the complete template lifecycle
* SQS (3.7.400.183)
	* Documentation updates for Amazon SQS fair queues feature.

### 3.7.1087.0 (2025-07-24 18:14 UTC)
* DataZone (3.7.416.0)
	* This release adds support for 1) highlighting relevant text in returned results for Search and SearchListings APIs and 2) returning aggregated counts of values for specified attributes for SearchListings API.
* Omics (3.7.405.0)
	* Add Git integration and README support for HealthOmics workflows
* Core 3.7.402.88
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1086.0 (2025-07-23 18:17 UTC)
* EC2 (3.7.461.0)
	* Added support for skip-os-shutdown option for the EC2 instance stop and terminate operations. This feature enables customers to bypass the graceful OS shutdown, supporting faster state transitions when instance data preservation isn't critical.
* Glue (3.7.426.0)
	* AWS Glue now supports dynamic session policies for job executions. This feature allows you to specify custom, fine-grained permissions for each job run without creating multiple IAM roles.
* WorkSpacesThinClient (3.7.406.0)
	* Added the lastUserId parameter to the ListDevices and GetDevice API.
* Core 3.7.402.87
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1085.0 (2025-07-22 18:24 UTC)
* ECR (3.7.413.0)
	* Add support for Image Tag Mutability Exception feature, allowing repositories to define wildcard-based patterns that override the default image tag mutability settings.
* ElasticMapReduce (3.7.405.0)
	* This release adds new parameter 'ExtendedSupport' in AWS EMR RunJobFlow, ModifyCluster and DescribeCluster API.
* Lambda (3.7.414.0)
	* This release migrated the model to Smithy keeping all features unchanged.
* Neptunedata (3.7.401.0)
	* This release updates the supported regions for Neptune API to include current AWS regions.
* Core 3.7.402.86
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1084.0 (2025-07-21 18:18 UTC)
* CloudFront (3.7.406.0)
	* Add dualstack endpoint support
* Deadline (3.7.411.0)
	* Add support for VPC resource endpoints in Service Managed Fleets
* EC2 (3.7.460.0)
	* This release adds support for C8gn, F2 and P6e-GB200 Instance types
* SageMaker (3.7.450.0)
	* This release adds 1/ Support for S3FileSystem in CustomFileSystems 2/ The ability for a customer to select their preferred IpAddressType for use with private Workforces 3/ Support for p4de instance type in SageMaker Training Plans
* TimestreamInfluxDB (3.7.407.0)
	* Timestream for InfluxDB adds support for db.influx.24xlarge instance type. This enhancement enables higher compute capacity for demanding workloads through CreateDbInstance, CreateDbCluster, UpdateDbInstance, and UpdateDbCluster APIs.
* Core 3.7.402.85
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1083.0 (2025-07-18 18:22 UTC)
* AuditManager (3.7.402.0)
	* Updated error handling for RegisterOrganizationAdminAccount API to properly translate TooManyExceptions to HTTP 429 status code. This enhancement improves error handling consistency and provides clearer feedback when request limits are exceeded.
* CloudWatchLogs (3.7.417.0)
	* CloudWatchLogs launches GetLogObject API with streaming support for efficient log data retrieval. Logs added support for new AccountPolicy type METRIC_EXTRACTION_POLICY. For more information, see CloudWatch Logs API documentation
* MediaConvert (3.7.417.0)
	* This release adds support for TAMS server integration with MediaConvert inputs.
* Outposts (3.7.408.0)
	* Add AWS Outposts API to surface customer billing information
* SimpleEmailV2 (3.7.412.0)
	* Added IP Visibility support for managed dedicated pools. Enhanced GetDedicatedIp and GetDedicatedIps APIs to return managed IP addresses.
* SimpleSystemsManagement (3.7.406.7)
	* July 2025 doc-only updates for Systems Manager.
* Core 3.7.402.84
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1082.0 (2025-07-17 18:23 UTC)
* CleanRoomsML (3.7.404.0)
	* This release introduces Parquet result format support for ML Input Channel models in AWS Clean Rooms ML.
* CloudFront (3.7.405.36)
	* Doc only update for CloudFront that fixes some customer-reported issues
* EC2 (3.7.459.0)
	* AWS Free Tier Version2 Support
* KeyspacesStreams (3.7.400.8)
	* Doc only update for the Amazon Keyspaces Streams API.
* MailManager (3.7.409.0)
	* Allow underscores in the local part of the input of the "Email recipients rewrite" action in rule sets.
* MediaConvert (3.7.416.0)
	* This release expands the range of supported audio outputs to include xHE, 192khz FLAC and the deprecation of dual mono for AC3.
* StepFunctions (3.7.403.121)
	* Align input with style guidelines.
* Synthetics (3.7.408.0)
	* This feature allows AWS Synthetics customers to provide code dependencies using lambda layer while creating a canary
* Core 3.7.402.83
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1081.0 (2025-07-16 15:37 UTC)
* Bedrock (3.7.427.0)
	* This release adds support for on-demand custom model inference through CustomModelDeployment APIs for Amazon Bedrock.
* BedrockAgentCore (3.7.400.0)
	* Initial release of Amazon Bedrock AgentCore SDK including Runtime, Built-In Tools, Memory, Gateway and Identity.
* BedrockAgentCoreControl (3.7.400.0)
	* Initial release of Amazon Bedrock AgentCore SDK including Runtime, Built-In Tools, Memory, Gateway and Identity.
* BedrockRuntime (3.7.422.0)
	* document update to support on demand custom model.
* CloudWatchLogs (3.7.416.0)
	* CloudWatch Logs updates: Added X-Ray tracing for Amazon Bedrock Agent resources. Logs introduced Log Group level resource policies (managed through Put/Delete/Describe Resource Policy APIs). For more information, see CloudWatch Logs API documentation.
* DataSync (3.7.407.0)
	* AWS DataSync now supports IPv6 address inputs and outputs in create, update, and describe operations for NFS, SMB, and Object Storage locations
* Glue (3.7.425.0)
	* AWS Glue now supports schema, partition and sort management of Apache Iceberg tables using Glue SDK
* GuardDuty (3.7.409.0)
	* Add expectedBucketOwner parameter to ThreatIntel and IPSet APIs.
* IoTWireless (3.7.403.0)
	* FuotaTaskId is not a valid IdentifierType for EventConfiguration and is being removed from possible IdentifierType values.
* MediaPackageV2 (3.7.407.0)
	* This release adds support for CDN Authentication using Static Headers in MediaPackage v2.
* NetworkFlowMonitor (3.7.403.0)
	* Introducing 2 new scope status types - DEACTIVATING and DEACTIVATED.
* PaymentCryptographyData (3.7.404.0)
	* Expand length of message data field for Mac generation and validation to 8192 characters.
* StepFunctions (3.7.403.120)
	* Doc-only update to introduction, and edits to clarify input parameter and the set of control characters.

### 3.7.1080.0 (2025-07-16 00:42 UTC)
* ECS (3.7.414.0)
	* This release removes hookDetails for the Amazon ECS native blue/green deployments.
* Core 3.7.402.82
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1079.0 (2025-07-15 18:34 UTC)
* BedrockAgent (3.7.428.0)
	* Add support for S3 Vectors as a vector store.
* DataZone (3.7.415.0)
	* Removing restriction of environment profile identifier as required field, S3 feature release
* DynamoDBv2 (3.7.409.0)
	* Added support for optional shard filter parameter in DescribeStream api that allows customers to fetch child shards of a read_only parent shard.
* EC2 (3.7.458.0)
	* This release adds support for volume initialization status, which enables you to monitor when the initialization process for an EBS volume is completed. This release also adds IPv6 support to EC2 Instance Connect Endpoints, allowing you to connect to your EC2 Instance via a private IPv6 address.
* ECS (3.7.413.0)
	* Amazon ECS supports native blue/green deployments, allowing you to validate new service revisions before directing production traffic to them.
* EventBridge (3.7.407.0)
	* Add customer-facing logging for the EventBridge Event Bus, enabling customers to better observe their events and extract insights about their EventBridge usage.
* OpenSearchService (3.7.405.0)
	* AWS Opensearch adds support for enabling s3 vector engine options. After enabling this option, customers will be able to create indices with s3 vector engine.
* Pricing (3.7.402.0)
	* This release adds support for new filter types in GetProducts API, including EQUALS, CONTAINS, ANY_OF, and NONE_OF.
* QuickSight (3.7.417.0)
	* Introduced custom instructions for topics.
* Repostspace (3.7.402.0)
	* This release introduces Channels functionality with CreateChannel, GetChannel, ListChannels, and UpdateChannel operations. Channels provide dedicated collaboration spaces where teams can organize discussions and knowledge by projects, business units, or areas of responsibility.
* S3 (3.7.421.0)
	* Amazon S3 Metadata live inventory tables provide a queryable inventory of all the objects in your general purpose bucket so that you can determine the latest state of your data. To help minimize your storage costs, use journal table record expiration to set a retention period for your records.
* S3Tables (3.7.405.0)
	* Adds table bucket type to ListTableBucket and GetTableBucket API operations
* S3Vectors (3.7.400.0)
	* Amazon S3 Vectors provides cost-effective, elastic, and durable vector storage for queries based on semantic meaning and similarity.
* SageMaker (3.7.449.0)
	* This release adds support for a new Restricted instance group type to enable a specialized environment for running Nova customization jobs on SageMaker HyperPod clusters. This release also adds support for SageMaker pipeline versioning.
* Core 3.7.402.81
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1078.0 (2025-07-09 19:35 UTC)
* EC2 (3.7.457.0)
	* Adds support to Capacity Blocks for ML for purchasing EC2 P6e-GB200 UltraServers. Customers can now purchase u-p6e-gb200x72 and u-p6e-gb200x36 UltraServers. Adds new DescribeCapacityBlocks andDescribeCapacityBlockStatus APIs. Adds support for CapacityBlockId to DescribeInstanceTopology.
* FreeTier (3.7.401.0)
	* This release introduces four new APIs: GetAccountPlanState and UpgradeAccountPlan for AWS account plan management; ListAccountActivities and GetAccountActivity that provide activity tracking capabilities.
* OpsWorksCM (3.7.400.174)
	* Removing content that refers to an S3 bucket that is no longer in use.
* Core 3.7.402.80
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1077.0 (2025-07-03 18:24 UTC)
* CustomerProfiles (3.7.405.0)
	* This release introduces capability of create Segments via importing a CSV file directly. This consumes the CSV file and creates/updates corresponding profiles for the particular domain.
* Deadline (3.7.410.0)
	* Added fields for output manifest reporting and task chunking parameters
* EC2 (3.7.456.0)
	* This release adds GroupOwnerId as a response member to the DescribeSecurityGroupVpcAssociations API and also adds waiters for SecurityGroupVpcAssociations (SecurityGroupVpcAssociationAssociated and SecurityGroupVpcAssociationDisassociated).
* MediaPackageV2 (3.7.406.0)
	* This release adds support for Microsoft Smooth Streaming (MSS) and allows users to exclude DRM segment Metadata in MediaPackage v2 Origin Endpoints
* Route53 (3.7.409.0)
	* Amazon Route 53 now supports the iso-e regions for private DNS Amazon VPCs and cloudwatch healthchecks.
* SageMaker (3.7.448.0)
	* Changes include new StartSession API for SageMaker Studio spaces and CreateHubContentPresignedUrls API for SageMaker JumpStart.
* Core 3.7.402.79
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1076.0 (2025-07-02 18:18 UTC)
* ConnectCases (3.7.404.0)
	* This release adds DeleteCase and DeleteRelatedItem APIs, which enable deleting cases and comments, undoing contact association, and removing service level agreements (SLAs) from cases. Contact center admins can use these APIs to delete cases when requested by customers and correct agent errors.
* EC2 (3.7.455.0)
	* AWS Site-to-Site VPN now supports IPv6 addresses on outer tunnel IPs, making it easier for customers to build or transition to IPv6-only networks.
* S3 (3.7.420.0)
	* Added support for directory bucket creation with tags and bucket ARN retrieval in CreateBucket, ListDirectoryBuckets, and HeadBucket operations
* S3Control (3.7.411.0)
	* Added TagResource, UntagResource, and ListTagsForResource support for directory bucket

### 3.7.1075.0 (2025-07-01 18:21 UTC)
* CleanRoomsML (3.7.403.0)
	* This release introduces support for incremental training and distributed training for custom models in AWS Clean Rooms ML.
* DataZone (3.7.414.0)
	* Add support for the new optional domain-unit-id parameter in the UpdateProject API.
* EC2 (3.7.454.0)
	* Add Context to GetInstanceTypesFromInstanceRequirements API
* Odb (3.7.400.0)
	* This release adds API operations for Oracle Database@AWS. You can use the APIs to create Exadata infrastructure, ODB networks, and Exadata and Autonomous VM clusters inside AWS data centers. The infrastructure is managed by OCI. You can integrate these resources with AWS services.
* QBusiness (3.7.416.0)
	* New ChatResponseConfiguration to Customize Q Business chat responses for specific use cases and communication needs. Updated Boosting capability allowing admins to provide preference on date attributes for recency and/or provide a preferred data source.
* RDS (3.7.415.2)
	* Amazon RDS Custom for Oracle now supports multi-AZ database instances.
* SageMaker (3.7.447.0)
	* Updated field validation requirements for InstanceGroups.
* Core 3.7.402.78
	* Update to consume latest protocol tests (1.60.3). Add query compatible protocol tests.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1074.0 (2025-06-30 18:38 UTC)
* ARCZonalShift (3.7.403.0)
	* Added support for on-demand practice runs and balanced capacity checks in ARC autoshift practice.
* B2bi (3.7.405.0)
	* Updated APIs to support inbound EDI split capabilities and additional Partnership-level configurations of generated EDI files' contents and format.
* Bedrock (3.7.426.0)
	* Add support for API Keys, Re-Ranker, implicit filter for RAG / KB evaluation for Bedrock APIs.
* BedrockRuntime (3.7.421.0)
	* Add API Key and document citations support for Bedrock Runtime APIs
* CloudFormation (3.7.405.0)
	* Added support for UNKNOWN drift status.
* CloudWatchLogs (3.7.415.0)
	* Increase minimum length of queryId parameter to 1 character.
* ConfigService (3.7.403.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config as of June 2025
* Connect (3.7.424.0)
	* This release introduces ChatMetrics to the model, providing comprehensive analytics insights for Amazon Connect chat conversations. Users can access these detailed metrics through the AWS Connect API by using the DescribeContact operation with their specific instance and contact IDs
* DataExchange (3.7.403.0)
	* This release updates resource Id with alphanumeric constraint, including Asset id, Revision id, Data Set id, Job id, and Event Action id.
* DynamoDBv2 (3.7.408.0)
	* This change adds support for witnesses in global tables. It also adds a new table status, REPLICATION_NOT_AUTHORIZED. This status will indicate scenarios where global replicas table can't be utilized for data plane operations.
* EventBridge (3.7.406.0)
	* Added support for EventBridge Dualstack endpoints in AWS GovCloud (US) regions (us-gov-east-1 and us-gov-west-1). The dualstack endpoints are identical for both FIPS and non-FIPS configurations, following the format: events.{region}.api.aws
* Glue (3.7.424.0)
	* releasing source processing properties to support source properties for ODB integrations
* IdentityManagement (3.7.407.0)
	* Updated IAM ServiceSpecificCredential support to include expiration, API Key output format instead of username and password for services that will support API keys, and the ability to list credentials for all users in the account for a given service configuration.
* MedicalImaging (3.7.401.0)
	* Added new fields to support the concept of primary image sets within the storage hierarchy.
* NetworkFlowMonitor (3.7.402.0)
	* Add ConflictExceptions to UpdateScope and DeleteScope operations for scopes being mutated.
* Outposts (3.7.407.0)
	* Make ContactName and ContactPhoneNumber required fields when creating and updating Outpost Site Addresses.
* PCS (3.7.406.0)
	* Fixed the validation pattern for an instance profile Amazon Resource Name (ARN) in AWS PCS.
* QuickSight (3.7.416.0)
	* Introduced custom permission capabilities for reporting content. Added menu option in exploration to preserve configuration data when textbox menu option is used. Added support for Athena trusted identity propagation.
* SimpleSystemsManagement (3.7.406.0)
	* Introduces AccessType, a new filter value for the DescribeSessions API.
* Transfer (3.7.408.0)
	* Added support for dual-stack (IPv4 and IPv6) endpoints for SFTP public endpoints and VPC-internal endpoints (SFTP, FTPS, FTP, and AS2), enabling customers to configure new servers with IPv4 or dual-stack mode, convert existing servers to dual-stack, and use IPv6 with service APIs.
* Core 3.7.402.77
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1073.0 (2025-06-27 19:25 UTC)
* ConfigService (3.7.402.112)
	* Added important considerations to the PutConformancePack and PutOrganizationConformancPack APIs.
* Connect (3.7.423.0)
	* This release adds the following value to an InitiateAs enum: COMPLETED
* Glue (3.7.423.0)
	* AWS Glue now supports schema, partition and sort management of Apache Iceberg tables using Glue SDK
* GuardDuty (3.7.408.0)
	* Update JSON target for Kubernetes workload resource type.
* QConnect (3.7.406.0)
	* Adding UnauthorizedException to public SDK
* RDS (3.7.415.0)
	* StartDBCluster and StopDBCluster can now throw InvalidDBShardGroupStateFault.
* SimpleEmailV2 (3.7.411.0)
	* Added support for new SES regions
* Core 3.7.402.76
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1072.0 (2025-06-26 18:31 UTC)
* Deadline (3.7.409.0)
	* Added fields to track cumulative task retry attempts for steps and jobs
* EC2 (3.7.453.0)
	* This release adds support for OdbNetworkArn as a target in VPC Route Tables
* IoTManagedIntegrations (3.7.401.0)
	* Adding managed integrations APIs for IoT Device Management to onboard and control devices across different manufacturers, connectivity protocols and third party vendor clouds. APIs include managed thing operations, provisioning profile management, and cloud connector operations.
* KeyManagementService (3.7.403.4)
	* This release updates AWS CLI examples for KMS APIs.
* Keyspaces (3.7.404.0)
	* This release provides change data capture (CDC) streams support through updates to the Amazon Keyspaces API.
* KeyspacesStreams (3.7.400.0)
	* This release adds change data capture (CDC) streams support through the new Amazon Keyspaces Streams API.
* QBusiness (3.7.415.0)
	* Added support for App level authentication for QBusiness DataAccessor using AWS IAM Identity center Trusted Token issuer
* WorkSpaces (3.7.413.0)
	* Updated modifyStreamingProperties to support PrivateLink VPC endpoints for directories
* Core 3.7.402.75
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1071.0 (2025-06-25 18:29 UTC)
* ECS (3.7.412.2)
	* Updates for change to Amazon ECS default log driver mode from blocking to non-blocking
* FSx (3.7.405.0)
	* Add support for the ability to create Amazon S3 Access Points for Amazon FSx for OpenZFS file systems.
* S3 (3.7.419.0)
	* Adds support for additional server-side encryption mode and storage class values for accessing Amazon FSx data from Amazon S3 using S3 Access Points
* S3Control (3.7.410.0)
	* Add support for the ability to use Amazon S3 Access Points with Amazon FSx for OpenZFS file systems.
* StorageGateway (3.7.405.0)
	* This release adds IPv6 support to the Storage Gateway APIs. APIs that previously only accept or return IPv4 address will now accept or return both IPv4 and IPv6 addresses.
* Textract (3.7.401.0)
	* Add RotationAngle field to Geometry of WORD blocks for Textract AnalyzeDocument API
* WorkSpacesThinClient (3.7.405.0)
	* Remove Tags field from Get API responses

### 3.7.1070.0 (2025-06-24 18:30 UTC)
* AIOps (3.7.401.0)
	* Adds support for cross account investigations for CloudWatch investigations AI Operations (AIOps).
* Batch (3.7.407.0)
	* Add userdataType to LaunchTemplateSpecification and LaunchTemplateSpecificationOverride.
* Bedrock (3.7.425.0)
	* We are making ListFoundationModelAgreementOffers, DeleteFoundationModelAgreement, CreateFoundationModelAgreement, GetFoundationModelAvailability, PutUseCaseForModelAccess and GetUseCaseForModelAccess APIs public, previously they were console.
* EC2 (3.7.452.0)
	* This release allows you to create and register AMIs while maintaining their underlying EBS snapshots within Local Zones.
* ElasticLoadBalancingV2 (3.7.410.0)
	* Add Paginator for DescribeAccountLimits, and fix Paginators for DescribeTrustStoreAssociations, DescribeTrustStoreRevocations, and DescribeTrustStores
* GameLift (3.7.406.0)
	* Add support for UDP ping beacons to ListLocations API, including new PingBeacon and UDPEndpoint data types within its Locations return value. Use UDP ping beacon endpoints to help measure real-time network latency for multiplayer games.
* LicenseManager (3.7.402.0)
	* AWS License Manager now supports license type conversions for AWS Marketplace products. Customers can provide Marketplace codes in the source license context or destination license context in the CreateLicenseConversionTaskForResource requests.
* RDS (3.7.414.0)
	* Adding support for RDS on Dedicated Local Zones, including local backup target, snapshot availability zone and snapshot target
* Route53Resolver (3.7.403.0)
	* Add support for iterative DNS queries through the new INBOUND_DELEGATION endpoint. Add delegation support through the Outbound Endpoints with DELEGATE rules.
* TranscribeService (3.7.405.0)
	* This Feature Adds Support for the "et-EE" Locale for Batch Operations

### 3.7.1069.0 (2025-06-23 18:25 UTC)
* DynamoDBv2 (3.7.407.29)
	* Fix issue where `ReturnValuesOnConditionCheckFailure` could not be used if the provided document included properties that ended with `code` or `message` (https://github.com/aws/aws-sdk-net/issues/3764).
* Glue (3.7.422.0)
	* AWS Glue now supports sort and z-order strategy for managed automated compaction for Iceberg tables in addition to binpack.
* S3Tables (3.7.404.0)
	* S3 Tables now supports sort and z-order compaction strategies for Iceberg tables in addition to binpack.
* WorkspacesInstances (3.7.400.0)
	* Added support for Amazon WorkSpaces Instances API
* Core 3.7.402.74
	* Update `JsonErrorResponseUnmarshaller` not to check nested properties when trying to populate details for operations that failed.
	* All services packages updated to require new Core

### 3.7.1068.0 (2025-06-20 18:23 UTC)
* Bedrock (3.7.424.0)
	* Add support for tiers in Content Filters and Denied Topics for Amazon Bedrock Guardrails.
* ECS (3.7.412.0)
	* Add ECS support for Windows Server 2025
* GeoPlaces (3.7.401.0)
	* Geocode, ReverseGeocode, and GetPlace APIs added Intersections and SecondaryAddresses. To use, add to the AdditionalFeatures list in your request. This provides info about nearby intersections and secondary addresses that are associated with a main address. Also added MainAddress and ParsedQuery.
* Glue (3.7.421.0)
	* AWS Glue Data Quality now provides aggregated metrics in evaluation results when publishAggregatedMetrics with row-level results are enabled. These metrics include summary statistics showing total counts of processed, passed, and failed rows and rules in a single view.
* MediaConvert (3.7.415.0)
	* This release adds a new SPECIFIED_OPTIMAL option for handling DDS when using DVB-Sub with high resolution video.
* Core 3.7.402.73
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1067.0 (2025-06-19 18:19 UTC)
* Bedrock (3.7.423.0)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a trained model into Amazon Bedrock for inference.
* EMRServerless (3.7.407.0)
	* This release adds the capability to enable IAM IdentityCenter Trusted Identity Propagation for users running Interactive Sessions on EMR Serverless Applications.
* Lambda (3.7.413.0)
	* Support Schema Registry feature for Kafka Event Source Mapping. Customers can now configure a Schema Registry to enable schema validation and filtering for Avro, Protobuf, and JSON-formatted events in Lambda for Kafka Event Source.
* PaymentCryptography (3.7.404.0)
	* Additional support for managing HMAC keys that adheres to changes documented in X9.143-2021 and provides better interoperability for key import/export
* PaymentCryptographyData (3.7.403.0)
	* Additional support for managing HMAC keys that adheres to changes documented in X9.143-2021 and provides better interoperability for key import/export
* SageMaker (3.7.446.0)
	* This release introduces alternative support for utilizing CFN templates from S3 for SageMaker Projects.

### 3.7.1066.0 (2025-06-18 19:03 UTC)
* AIOps (3.7.400.0)
	* This is the initial SDK release for Amazon AI Operations (AIOps). AIOps is a generative AI-powered assistant that helps you respond to incidents in your system by scanning your system's telemetry and quickly surface suggestions that might be related to your issue.
* AutoScaling (3.7.409.0)
	* Add IncludeInstances parameter to DescribeAutoScalingGroups API
* CloudWatchLogs (3.7.414.0)
	* Added CloudWatch Logs Transformer support for converting CloudTrail, VPC Flow, EKS Audit, AWS WAF and Route53 Resolver logs to OCSF v1.1 format.
* S3 (3.7.418.0)
	* Added support for renaming objects within the same bucket using the new RenameObject API.
	* Added support for the RenameObject operation in S3 Directory Buckets, allowing atomic renaming of objects and directories.
* SageMaker (3.7.445.0)
	* Add support for p6-b200 instance type for SageMaker Hyperpod
* Core 3.7.402.72
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1065.0 (2025-06-17 21:05 UTC)
* AccessAnalyzer (3.7.405.0)
	* We are launching a new analyzer type, internal access analyzer. The new analyzer will generate internal access findings, which help customers understand who within their AWS organization or AWS Account has access to their critical AWS resources.
* Backup (3.7.404.0)
	* AWS Backup is adding support for integration of its logically air-gapped vaults with the AWS Organizations Multi-party approval capability.
* Bedrock (3.7.422.1)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a trained model into Amazon Bedrock for inference.
* CertificateManager (3.7.402.0)
	* Adds support for Exportable Public Certificates
* DatabaseMigrationService (3.7.410.0)
	* Add "Virtual" field to Data Provider as well as "S3Path" and "S3AccessRoleArn" fields to DataProvider settings
* GuardDuty (3.7.407.0)
	* Adding support for extended threat detection for EKS Audit Logs and EKS Runtime Monitoring.
* Inspector2 (3.7.407.0)
	* Add Code Repository Scanning as part of AWS InspectorV2
* MPA (3.7.400.0)
	* This release enables customers to create Multi-party approval teams and approval requests to protect supported operations.
* NetworkFirewall (3.7.408.0)
	* Release of Active Threat Defense in Network Firewall
* Organizations (3.7.406.0)
	* Add support for policy operations on the SECURITYHUB_POLICY policy type.
* SecurityHub (3.7.404.0)
	* Adds operations, structures, and exceptions required for public preview release of Security Hub V2.
* SecurityToken (3.7.402.0)
	* The AWS Security Token Service APIs AssumeRoleWithSAML and AssumeRoleWithWebIdentity can now be invoked without pre-configured AWS credentials in the SDK configuration.
* WAFV2 (3.7.409.0)
	* AWS WAF can now suggest protection packs for you based on the application information you provide when you create a webACL.

### 3.7.1064.0 (2025-06-16 18:18 UTC)
* Bedrock (3.7.422.0)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a Amazon SageMaker trained Amazon Nova model into Amazon Bedrock for inference.
* ECR (3.7.412.0)
	* The `DescribeImageScanning` API now includes `lastInUseAt` and `InUseCount` fields that can be used to prioritize vulnerability remediation for images that are actively being used.
* NetworkFirewall (3.7.407.0)
	* You can now create firewalls using a Transit Gateway instead of a VPC, resulting in a TGW attachment.
* SageMaker (3.7.444.0)
	* This release 1) adds a new S3DataType Converse for SageMaker training 2)adds C8g R7gd M8g C6in P6 P6e instance type for SageMaker endpoint 3) adds m7i, r7i, c7i instance type for SageMaker Training and Processing.

### 3.7.1063.0 (2025-06-12 18:21 UTC)
* APIGateway (3.7.403.7)
	* Documentation updates for Amazon API Gateway
* ApiGatewayV2 (3.7.403.7)
	* Documentation updates for Amazon API Gateway
* ConnectCampaignsV2 (3.7.402.0)
	* Added PutInstanceCommunicationLimits and GetInstanceCommunicationLimits APIs
* ECS (3.7.411.15)
	* This Amazon ECS  release supports updating the capacityProviderStrategy parameter in update-service.
* EMRServerless (3.7.406.0)
	* This release adds support for retrieval of the optional executionIamPolicy field in the GetJobRun API response.
* IoTFleetWise (3.7.408.0)
	* Add new status READY_FOR_CHECKIN used for vehicle synchronisation
* KeyManagementService (3.7.403.0)
	* AWS KMS announces the support of ML-DSA key pairs that creates post-quantum safe digital signatures.
* PCS (3.7.405.0)
	* Fixed regex patterns for ARN fields.

### 3.7.1062.0 (2025-06-11 18:22 UTC)
* ControlCatalog (3.7.404.0)
	* Introduced ListControlMappings API that retrieves control mappings. Added control aliases and governed resources fields in GetControl and ListControls APIs. New filtering capability in ListControls API, with implementation identifiers and implementation types.
* EKS (3.7.417.0)
	* Release for EKS Pod Identity Cross Account feature and disableSessionTags flag.
* LexModelsV2 (3.7.404.0)
	* Add support for the Assisted NLU feature to improve bot performance
* NetworkManager (3.7.403.0)
	* Add support for public DNS hostname resolution to private IP addresses across Cloud WAN-managed VPCs. Add support for security group referencing across Cloud WAN-managed VPCs.
* RDS (3.7.413.3)
	* Updates Amazon RDS documentation for Amazon RDS for Db2 cross-Region replicas in standby mode.
* WAFV2 (3.7.408.0)
	* WAF now provides two DDoS protection options: resource-level monitoring for Application Load Balancers and the AWSManagedRulesAntiDDoSRuleSet managed rule group for CloudFront distributions.
* Core 3.7.402.71
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1061.1 (2025-06-10 18:13 UTC)
* GameLiftStreams (3.7.401.44)
	* Documentation updates for Amazon GameLift Streams to address formatting errors, correct resource ID examples, and update links to other guides
* Core 3.7.402.70
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1061.0 (2025-06-09 18:23 UTC)
* AppSync (3.7.409.0)
	* Deprecate `atRestEncryptionEnabled` and `transitEncryptionEnabled` attributes in `CreateApiCache` action. Encryption is always enabled for new caches.
* CostExplorer (3.7.408.0)
	* Support dual-stack endpoints for ce api
* CustomerProfiles (3.7.404.0)
	* This release introduces capability of Profile Explorer, using correct ingestion timestamp & using historical data for computing calculated attributes, and new standard objects for T&H as part of Amazon Connect Customer Profiles service.
* EC2 (3.7.451.0)
	* Release to support Elastic VMware Service (Amazon EVS) Subnet and Amazon EVS Network Interface Types.
* ElasticFileSystem (3.7.402.0)
	* Added support for Internet Protocol Version 6 (IPv6) on EFS Service APIs and mount targets.
* MarketplaceCatalog (3.7.401.0)
	* The ListEntities API now supports the EntityID, LastModifiedDate, ProductTitle, and Visibility filters for machine learning products. You can also sort using all of those filters.
* WorkSpacesThinClient (3.7.404.0)
	* Add ConflictException to UpdateEnvironment API
* Core 3.7.402.69
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1060.0 (2025-06-06 18:29 UTC)
* BedrockAgentRuntime (3.7.428.0)
	* This release introduces the `PromptCreationConfigurations` input parameter, which includes fields to control prompt population for `InvokeAgent` or `InvokeInlineAgent` requests.
* KeyManagementService (3.7.402.0)
	* Remove unpopulated KeyMaterialId from Encrypt Response
* RDS (3.7.413.0)
	* Include Global Cluster Identifier in DBCluster if the DBCluster is a Global Cluster Member.
* Rekognition (3.7.401.0)
	* Adds support for defining an ordered preference list of different Rekognition Face Liveness challenge types when calling CreateFaceLivenessSession.
* Route53 (3.7.408.0)
	* Amazon Route 53 now supports the Asia Pacific (Taipei) Region (ap-east-2) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* S3Tables (3.7.403.0)
	* S3 Tables now supports getting details about a table via its table ARN.
* Core 3.7.402.68
	* Fixed Document.cs serialization issue that caused WebAuthn operations to fail when response contained Dictionary structures
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1059.0 (2025-06-05 18:22 UTC)
* BCMPricingCalculator (3.7.406.0)
	* Updating the minimum for List APIs to be 1 (instead of 0)
* CloudFormation (3.7.404.0)
	* Add new warning type 'EXCLUDED_PROPERTIES'
* KeyManagementService (3.7.401.0)
	* AWS KMS announces the support for on-demand rotation of symmetric-encryption KMS keys with imported key material (EXTERNAL origin).
* WAFV2 (3.7.407.0)
	* AWS WAF adds support for ASN-based traffic filtering and support for ASN-based rate limiting.
* Core 3.7.402.67
	* Add x-amzn-query-mode header and query compatible tests. The sdk will send a new header x-amzn-query-mode, if the service has the awsQueryCompatibleTrait applied to it. This is to inform the service that the client is running in query compatible mode.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1058.0 (2025-06-04 18:24 UTC)
* Amplify (3.7.407.3)
	* Update documentation for cacheConfig in CreateApp API
* Evs (3.7.400.0)
	* Amazon Elastic VMware Service (Amazon EVS) allows you to run VMware Cloud Foundation (VCF) directly within your Amazon VPC including simplified self-managed migration experience with guided workflow in AWS console or via AWS CLI, get full access to their VCF deployment and VCF license portability.
* Invoicing (3.7.401.0)
	* Added new Invoicing ListInvoiceSummaries API Operation
* MediaConnect (3.7.405.0)
	* This release updates the DescribeFlow API to show peer IP addresses. You can now identify the peer IP addresses of devices connected to your sources and outputs. This helps you to verify and troubleshoot your flow's active connections.
* MediaConvert (3.7.414.0)
	* This release includes support for embedding and signing C2PA content credentials in MP4 outputs.
* NetworkFirewall (3.7.406.0)
	* You can now monitor flow and alert log metrics from the Network Firewall console.
* SageMaker (3.7.443.0)
	* Added support for p6-b200 instance type in SageMaker Training Jobs and Training Plans.
* TranscribeService (3.7.404.0)
	* AWS Healthscribe now supports new templates for the clinical note summary: BIRP, SIRP, DAP, BEHAVIORAL_SOAP, and PHYSICAL_SOAP
* Core 3.7.402.66
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1057.0 (2025-06-03 18:14 UTC)
* APIGateway (3.7.403.0)
	* Adds support to set the routing mode for a custom domain name.
* ApiGatewayV2 (3.7.403.0)
	* Adds support to create routing rules and set the routing mode for a custom domain name.
* ElasticMapReduce (3.7.404.8)
	* Changing S3 bucket names to preferred values in example documentation.
* EMRServerless (3.7.405.0)
	* AWS EMR Serverless: Adds a new option in the CancelJobRun API in EMR 7.9.0+, to cancel a job with grace period. This feature is enabled by default with a 120-second grace period for streaming jobs and is not enabled by default for batch jobs.
* S3 (3.7.417.3)
	* Changing S3 bucket names to preferred values in example documentation.

### 3.7.1056.0 (2025-06-02 18:32 UTC)
* Athena (3.7.404.0)
	* Add support for the managed query result in the workgroup APIs. The managed query result configuration enables users to store query results to Athena owned storage.
* Backup (3.7.403.0)
	* You can now subscribe to Amazon SNS notifications and Amazon EventBridge events for backup indexing. You can now receive notifications when a backup index is created, deleted, or fails to create, enhancing your ability to monitor and track your backup operations.
* BedrockAgent (3.7.427.0)
	* This release adds the Agent Lifecycle Paused State feature to Amazon Bedrock agents. By using an agent's alias, you can temporarily suspend agent operations during maintenance, updates, or other situations.
* ComputeOptimizer (3.7.403.0)
	* This release enables AWS Compute Optimizer to analyze Amazon Aurora database clusters and generate Aurora I/O-Optimized recommendations.
* CostOptimizationHub (3.7.406.0)
	* Support recommendations for Aurora instance and Aurora cluster storage.
* ECS (3.7.411.8)
	* Updates Amazon ECS documentation to include note for upcoming default log driver mode change.
* EKS (3.7.416.0)
	* Add support for filtering ListInsights API calls on MISCONFIGURATION insight category
* EntityResolution (3.7.404.0)
	* Add support for generating match IDs in near real-time.
* PCS (3.7.404.0)
	* Introduces SUSPENDING and SUSPENDED states for clusters, compute node groups, and queues.
* Synthetics (3.7.407.0)
	* Support for Java runtime handler pattern.
* Core 3.7.402.65
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1055.0 (2025-05-30 18:21 UTC)
* EMRServerless (3.7.404.0)
	* This release adds the capability for users to specify an optional Execution IAM policy in the StartJobRun action. The resulting permissions assumed by the job run is the intersection of the permissions in the Execution Role and the specified Execution IAM Policy.
* SageMaker (3.7.442.0)
	* Release new parameter CapacityReservationConfig in ProductionVariant
* Core 3.7.402.64
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1054.0 (2025-05-29 18:34 UTC)
* Amplify (3.7.407.0)
	* Add support for customizable build instance sizes. CreateApp and UpdateApp operations now accept a new JobConfig parameter composed of BuildComputeType.
* AutoScaling (3.7.408.0)
	* Add support for "apple" CpuManufacturer in ABIS
* BCMPricingCalculator (3.7.405.0)
	* Add AFTER_DISCOUNTS_AND_COMMITMENTS to Workload Estimate Rate Type. Set ListWorkLoadEstimateUsage maxResults range to minimum of 0 and maximum of 300.
* CloudTrail (3.7.404.0)
	* CloudTrail Feature Release: Support for Enriched Events with Configurable Context for Event Data Store
* Connect (3.7.422.0)
	* Amazon Connect Service Feature: Email Recipient Limit Increase
* DataExchange (3.7.402.0)
	* This release adds Tag support for Event Action resource, through which customers can create event actions with Tags and retrieve event actions with Tags.
* DataSync (3.7.406.0)
	* AgentArns field is made optional for Object Storage and Azure Blob location create requests. Location credentials are now managed via Secrets Manager, and may be encrypted with service managed or customer managed keys. Authentication is now optional for Azure Blob locations.
* FSx (3.7.404.0)
	* FSx API changes to support the public launch of new Intelligent Tiering storage class on Amazon FSx for Lustre
* IVSRealTime (3.7.406.0)
	* IVS Real-Time now offers customers the participant replication that allow customers to copy a participant from one stage to another.
* MWAA (3.7.403.0)
	* Amazon MWAA now lets you choose a worker replacement strategy when updating an environment. This release adds two worker replacement strategies: FORCED (default), which stops workers immediately, and GRACEFUL, which allows workers to finish current tasks before shutting down.
* S3 (3.7.417.0)
	* Adding checksum support for S3 PutBucketOwnershipControls API.
* SageMaker (3.7.441.0)
	* Add maintenance status field to DescribeMlflowTrackingServer API response

### 3.7.1053.0 (2025-05-28 18:22 UTC)
* CostOptimizationHub (3.7.405.0)
	* This release allows customers to modify their preferred commitment term and payment options.
* EC2 (3.7.450.0)
	* Enable the option to automatically delete underlying Amazon EBS snapshots when deregistering Amazon Machine Images (AMIs)
* EventBridge (3.7.405.0)
	* Allow for more than 2 characters for location codes in EventBridge ARNs
* NetworkFirewall (3.7.405.0)
	* You can now use VPC endpoint associations to create multiple firewall endpoints for a single firewall.
* Synthetics (3.7.406.0)
	* Add support to change ephemeral storage. Add a new field "TestResult" under CanaryRunStatus.
* Core 3.7.402.63
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1052.0 (2025-05-27 18:21 UTC)
* CostExplorer (3.7.407.0)
	* This release introduces Cost Comparison feature (GetCostAndUsageComparisons, GetCostComparisonDrivers) allowing you find cost variations across multiple dimensions and identify key drivers of spending changes.
* Deadline (3.7.408.0)
	* AWS Deadline Cloud service-managed fleets now support storage profiles. With storage profiles, you can map file paths between a workstation and the worker hosts running the job.
* EC2 (3.7.449.0)
	* This release adds three features - option to store AWS Site-to-Site VPN pre-shared keys in AWS Secrets Manager, GetActiveVpnTunnelStatus API to check the in-use VPN algorithms, and SampleType option in GetVpnConnectionDeviceSampleConfiguration API to get recommended sample configs for VPN devices.

### 3.7.1051.0 (2025-05-23 18:19 UTC)
* EC2 (3.7.448.0)
	* This release adds support for the C7i-flex, M7i-flex, I7i, I7ie, I8g, P6-b200, Trn2, C8gd, M8gd and R8gd instances
* S3 (3.7.416.32)
	* Fix: Fixed a bug where Content-Type header was being overwritten in multipart upload scenarios.
* SecurityIR (3.7.402.0)
	* Update PrincipalId pattern documentation to reflect what user should receive back from the API call
* Core 3.7.402.62
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1050.0 (2025-05-22 18:16 UTC)
* AuditManager (3.7.401.0)
	* With this release, the AssessmentControl description field has been deprecated, as of May 19, 2025. Additionally, the UpdateAssessment API can now return a ServiceQuotaExceededException when applicable service quotas are exceeded.
* DSQL (3.7.405.0)
	* Features: support for customer managed encryption keys
* Glue (3.7.420.0)
	* This release supports additional ConversionSpec parameter as part of IntegrationPartition Structure in CreateIntegrationTableProperty API. This parameter is referred to apply appropriate column transformation for columns that are used for timestamp based partitioning
* PrometheusService (3.7.404.0)
	* Add QueryLoggingConfiguration APIs for Amazon Managed Prometheus

### 3.7.1049.0 (2025-05-21 18:18 UTC)
* ApplicationAutoScaling (3.7.403.23)
	* Doc only update that addresses a customer reported issue.
* BedrockAgentRuntime (3.7.427.0)
	* Amazon Bedrock introduces asynchronous flows (in preview), which let you run flows for longer durations and yield control so that your application can perform other tasks and you don't have to actively monitor the flow's progress.
* CloudWatch (3.7.403.0)
	* Adds support for setting up Contributor Insight rules on logs transformed via Logs Transformation feature.
* EC2 (3.7.447.0)
	* Release of Dualstack and Ipv6-only EC2 Public DNS hostnames
* PartnerCentralSelling (3.7.404.0)
	* Modified validation to allow expectedCustomerSpend array with zero elements in Partner Opportunity operations.
* S3 (3.7.416.31)
	* Fixed an issue where IAmazonS3.EnsureBucketExists(Async) was throwing an exception if S3 bucket already exists in the executing account.
* Core 3.7.402.61
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1048.0 (2025-05-20 18:21 UTC)
* DataSync (3.7.405.0)
	* Remove Discovery APIs from the DataSync service
* EC2 (3.7.446.0)
	* This release expands the ModifyInstanceMaintenanceOptions API to enable or disable instance migration during customer-initiated reboots for EC2 Scheduled Reboot Events.
* Glue (3.7.419.0)
	* Enhanced AWS Glue ListConnectionTypes API Model with additional metadata fields.
* Inspector2 (3.7.406.0)
	* This release adds GetClustersForImage API and filter updates as part of the mapping of container images to running containers feature.
* OAM (3.7.402.0)
	* Add IncludeTags field to GetLink, GetSink and UpdateLink API
* Private5G (Removed)
	* Removed Amazon Private5G from the SDK because the service has been shutdown.
* RDS (3.7.412.0)
	* This release introduces the new DescribeDBMajorEngineVersions API for describing the properties of specific major versions of database engines.
* Core 3.7.402.60
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1047.0 (2025-05-19 18:13 UTC)
* DSQL (3.7.404.0)
	* CreateMultiRegionCluster and DeleteMultiRegionCluster APIs removed
* EC2 (3.7.445.0)
	* This release includes new APIs for System Integrity Protection (SIP) configuration and automated root volume ownership delegation for EC2 Mac instances.
* MediaPackageV2 (3.7.405.0)
	* This release adds support for DVB-DASH, EBU-TT-D subtitle format, and non-compacted manifests for DASH in MediaPackage v2 Origin Endpoints.
* Core 3.7.402.59
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1046.0 (2025-05-16 18:42 UTC)
* BedrockDataAutomation (3.7.404.0)
	* Add support for VIDEO modality to BlueprintType enum.
* BedrockDataAutomationRuntime (3.7.402.0)
	* Add AssetProcessingConfiguration for video segment to InputConfiguration
* CodePipeline (3.7.409.0)
	* CodePipeline now supports new API ListDeployActionExecutionTargets that lists the deployment target details for deploy action executions.
* ECS (3.7.411.1)
	* This is an Amazon ECs documentation only release to support the change of the container exit "reason" field from 255 characters to 1024 characters.
* ElasticMapReduce (3.7.404.0)
	* Added APIs for managing Application UIs: Access Persistent (serverless) UIs via CreatePersistentAppUI DescribePersistentAppUI & GetPersistentAppUIPresignedURL, and Cluster-based UIs through GetOnClusterAppUIPresignedURL. Supports Yarn, Spark History, and TEZ interfaces.
* Glue (3.7.418.0)
	* Changes include (1) Excel as S3 Source type and XML and Tableau's Hyper as S3 Sink types, (2) targeted number of partitions parameter in S3 sinks and (3) new compression types in CSV/JSON and Parquet S3 sinks.
* Neptune (3.7.402.0)
	* This release adds Global Cluster Switchover capability which enables you to change your global cluster's primary AWS Region, the region that serves writes, while preserving the replication between all regions in the global cluster.
* ServiceQuotas (3.7.402.0)
	* This release introduces CreateSupportCase operation to SDK.
* Core 3.7.402.58
	* Add the ConnectTimeout property on the service client config for the .NET 8 target of the SDK.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1045.0 (2025-05-15 18:30 UTC)
* BedrockAgent (3.7.426.0)
	* Amazon Bedrock Flows introduces DoWhile loops nodes, parallel node executions, and enhancements to knowledge base nodes.
* CodeBuild (3.7.419.0)
	* AWS CodeBuild now supports Docker Server capability
* ControlTower (3.7.403.1)
	* Updated the descriptions for the AWS Control Tower Baseline APIs to make them more intuitive.
* DatabaseMigrationService (3.7.409.0)
	* Introduces Data Resync feature to describe-table-statistics and IAM database authentication for MariaDB, MySQL, and PostgreSQL.
* PCS (3.7.403.0)
	* This release adds support for Slurm accounting. For more information, see the Slurm accounting topic in the AWS PCS User Guide. Slurm accounting is supported for Slurm 24.11 and later. This release also adds 24.11 as a valid value for the version parameter of the Scheduler data type.
* WorkSpaces (3.7.412.0)
	* Added the new AlwaysOn running mode for WorkSpaces Pools. Customers can now choose between AlwaysOn (for instant access, with hourly usage billing regardless of connection status), or AutoStop (to optimize cost, with a brief startup delay) for their pools.

### 3.7.1044.0 (2025-05-14 18:25 UTC)
* CloudWatchLogs (3.7.413.0)
	* This release adds a new API "ListLogGroups" and an improvement in API "DescribeLogGroups"
* CognitoIdentityProvider (3.7.409.0)
	* Add exceptions to WebAuthn operations.
* KinesisFirehose (3.7.403.0)
	* This release adds catalogARN support for s3 tables multi-catalog catalogARNs.
* MediaConvert (3.7.413.0)
	* This update enables cropping for video overlays and adds a new STL to Teletext upconversion toggle to preserve styling.

### 3.7.1043.0 (2025-05-13 18:25 UTC)
* Bedrock (3.7.421.0)
	* Enable cross-Region inference for Amazon Bedrock Guardrails by using the crossRegionConfig parameter when calling the CreateGuardrail or UpdateGuardrail operation.
* BedrockAgentRuntime (3.7.426.0)
	* Changes for enhanced metadata in trace
* ControlTower (3.7.403.0)
	* AWS Control Tower now reports the inheritance drift status for EnabledBaselines through the GetEnabledBaseline and ListEnabledBaselines APIs. You can now filter EnabledBaselines by their enablement and drift status using the ListEnabledBaselines API to view accounts and OUs that require attention.
* DSQL (3.7.403.0)
	* CreateMultiRegionClusters and DeleteMultiRegionClusters APIs marked as deprecated. Introduced new multi-Region clusters creation experience through multiRegionProperties parameter in CreateCluster API.
* ECS (3.7.411.0)
	* This release extends functionality for Amazon EBS volumes attached to Amazon ECS tasks by adding support for the new EBS volumeInitializationRate parameter in ECS RunTask/StartTask/CreateService/UpdateService APIs.
* LicenseManager (3.7.401.0)
	* Add Tagging feature to resources in the Managed Entitlements service. License and Grant resources can now be tagged.

### 3.7.1042.0 (2025-05-12 18:28 UTC)
* Deadline (3.7.407.0)
	* AWS Deadline Cloud service-managed fleets now support configuration scripts. Configuration scripts make it easy to install additional software, like plugins and packages, onto a worker.
* EC2 (3.7.444.0)
	* EC2 - Adding support for AvailabilityZoneId
* IdentityManagement (3.7.406.0)
	* Updating the endpoint list for the Identity and access management (IAM) service
* MediaLive (3.7.418.0)
	* Add support to the AV1 rate control mode
* MediaTailor (3.7.405.0)
	* Documenting that EnabledLoggingStrategies is always present in responses of PlaybackConfiguration read operations.
* S3Control (3.7.409.0)
	* Updates to support S3 Express zonal endpoints for directory buckets in AWS CLI
* SageMaker (3.7.440.0)
	* No API changes from previous release. This release migrated the model to Smithy keeping all features unchanged.
* SupplyChain (3.7.405.0)
	* Launch new AWS Supply Chain public APIs for DataIntegrationEvent, DataIntegrationFlowExecution and DatasetNamespace. Also add more capabilities to existing public APIs to support direct dataset event publish, data deduplication in DataIntegrationFlow, partition specification of custom datasets.
* Core 3.7.402.57
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1041.0 (2025-05-09 18:24 UTC)
* Athena (3.7.403.91)
	* Minor API documentation updates
* CloudWatchLogs (3.7.412.0)
	* We are pleased to announce limit increases to our grok processor logs transformation feature. Now you can define 20 Grok patterns in their configurations, with an expanded total pattern matching limit of 512 characters.
* Synthetics (3.7.405.0)
	* Add support to retry a canary automatically after schedule run failures. Users can enable this feature by configuring the RetryConfig field when calling the CreateCanary or UpdateCanary API. Also includes changes in GetCanary and GetCanaryRuns to support retrieving retry configurations.
* WorkSpaces (3.7.411.0)
	* Remove parameter EnableWorkDocs from WorkSpacesServiceModel due to end of support of Amazon WorkDocs service.
* Core 3.7.402.56
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1040.0 (2025-05-08 18:22 UTC)
* CloudFront (3.7.405.8)
	* Doc-only update for CloudFront. These changes include customer-reported issues.
	* Add note about OpenSSL 3 limitation for `AmazonCloudFrontUrlSigner` and `AmazonCloudFrontCookieSigner` utility classes.
* CodePipeline (3.7.408.0)
	* Add support for Secrets Manager and Plaintext environment variable types in Commands action
* EC2 (3.7.443.0)
	* Launching the feature to support ENA queues offering flexibility to support multiple queues per Enhanced Network Interface (ENI)
* Glue (3.7.417.0)
	* This new release supports customizable RefreshInterval for all Saas ZETL integrations from 15 minutes to 6 days.
* GuardDuty (3.7.406.51)
	* Updated description of a data structure.
* SSOAdmin (3.7.401.0)
	* Update PutPermissionBoundaryToPermissionSet API's managedPolicyArn pattern to allow valid ARN only. Update ApplicationName to allow white spaces.
* Core 3.7.402.55
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1039.0 (2025-05-07 18:24 UTC)
* EC2 (3.7.442.0)
	* This release adds API support for Path Component Exclusion (Filter Out ARN) for Reachability Analyzer
* Imagebuilder (3.7.404.7)
	* Updated the CreateImageRecipeRequest ParentImage description to include all valid values as updated with the SSM Parameters project.
* MediaLive (3.7.417.0)
	* Enables Updating Anywhere Settings on a MediaLive Anywhere Channel.
* SageMaker (3.7.439.0)
	* SageMaker AI Studio users can now migrate to SageMaker Unified Studio, which offers a unified web-based development experience that integrates AWS data, analytics, artificial intelligence (AI), and machine learning (ML) services, as well as additional tools and resource
* Synthetics (3.7.404.0)
	* Add support to test a canary update by invoking a dry run of a canary. This behavior can be used via the new StartCanaryDryRun API along with new fields in UpdateCanary to apply dry run changes. Also includes changes in GetCanary and GetCanaryRuns to support retrieving dry run configurations.
* Core 3.7.402.54
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1038.0 (2025-05-06 18:20 UTC)
* EC2 (3.7.441.0)
	* This release adds support for Amazon EBS Provisioned Rate for Volume Initialization, which lets you specify a volume initialization rate to ensure that your EBS volumes are initialized in a predictable amount of time.
* ServiceCatalog (3.7.401.0)
	* ServiceCatalog's APIs (DeleteServiceAction, DisassociateServiceActionFromProvisioningArtifact, AssociateServiceActionWithProvisioningArtifact) now throw InvalidParametersException when IdempotencyToken is invalid.
* TimestreamQuery (3.7.403.0)
	* Add dualstack endpoints support and correct us-gov-west-1 FIPS endpoint.
* TimestreamWrite (3.7.401.0)
	* Add dualstack endpoints support.
* Core 3.7.402.53
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1037.0 (2025-05-05 18:19 UTC)
* DataZone (3.7.413.0)
	* This release adds a new authorization policy to control the usage of custom AssetType when creating an Asset. Customer can now add new grant(s) of policyType USE_ASSET_TYPE for custom AssetTypes to apply authorization policy to projects members and domain unit owners.
* DeviceFarm (3.7.403.0)
	* Add an optional parameter to the GetDevicePoolCompatibility API to pass in project information to check device pool compatibility.
* EC2 (3.7.440.0)
	* This update introduces API operations to manage and create local gateway VIF and VIF groups. It also includes API operations to describe Outpost LAGs and service link VIFs.
* ECS (3.7.410.8)
	* Add support to roll back an In_Progress ECS Service Deployment
* MediaConvert (3.7.412.0)
	* This release adds an optional sidecar per-frame video quality metrics report and an ALL_PCM option for audio selectors. It also changes the data type for Probe API response fields related to video and audio bitrate from integer to double.
* Core 3.7.402.52
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1036.0 (2025-05-02 18:16 UTC)
* BedrockDataAutomation (3.7.403.0)
	* Added support for Custom output and blueprints for AUDIO data types.
* DirectoryService (3.7.401.124)
	* Doc only update - fixed typos.
* Kinesis (3.7.404.0)
	* Marking ResourceARN as required for Amazon Kinesis Data Streams APIs TagResource, UntagResource, and ListTagsForResource.
* Core 3.7.402.51
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1035.0 (2025-05-01 18:14 UTC)
* AppConfig (3.7.404.0)
	* Adding waiter support for deployments and environments; documentation updates
* Connect (3.7.421.0)
	* This release adds the following fields to DescribeContact: DisconnectReason, AgentInitiatedHoldDuration, AfterContactWorkStartTimestamp, AfterContactWorkEndTimestamp, AfterContactWorkDuration, StateTransitions, Recordings, ContactDetails, ContactEvaluations, Attributes
* SageMaker (3.7.438.0)
	* Feature - Adding support for Scheduled and Rolling Update Software in Sagemaker Hyperpod.
* VerifiedPermissions (3.7.404.0)
	* Amazon Verified Permissions / Features : Adds support for tagging policy stores.
* Core 3.7.402.50
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1034.0 (2025-04-30 18:39 UTC)
* Bedrock (3.7.420.0)
	* You can now specify a cross region inference profile as a teacher model for the CreateModelCustomizationJob API. Additionally, the GetModelCustomizationJob API has been enhanced to return the sub-task statuses of a customization job within the StatusDetails response field.
* BedrockAgent (3.7.425.0)
	* Features:    Add inline code node to prompt flow
* BedrockAgentRuntime (3.7.425.0)
	* Support for Custom Orchestration within InlineAgents
* CleanRooms (3.7.406.0)
	* This release adds support for ProtectedQuery results to be delivered to more than one collaboration member via the new distribute output configuration in StartProtectedQuery.
* CloudWatchLogs (3.7.411.0)
	* CloudWatch Logs supports "DELIVERY" log class. This log class is used only for delivering AWS Lambda logs to Amazon S3 or Amazon Data Firehose.
* Deadline (3.7.406.0)
	* Adds support for tag management on workers and tag inheritance from fleets to their associated workers.
* EC2 (3.7.439.0)
	* Launch of cost distribution feature for IPAM owners to distribute costs to internal teams.
* ECR (3.7.411.0)
	* Adds dualstack support for Amazon Elastic Container Registry (Amazon ECR).
* ECRPublic (3.7.405.0)
	* Adds dualstack support for Amazon Elastic Container Registry Public (Amazon ECR Public).
* MailManager (3.7.408.0)
	* Introducing new RuleSet rule PublishToSns action, which allows customers to publish email notifications to an Amazon SNS topic. New PublishToSns action enables customers to easily integrate their email workflows via Amazon SNS, allowing them to notify other systems about important email events.
* Core 3.7.402.49
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1033.0 (2025-04-29 20:03 UTC)
* ConnectCases (3.7.403.0)
	* Introduces CustomEntity as part of the UserUnion data type. This field is used to indicate the entity who is performing the API action.
* Kinesis (3.7.403.0)
	* Amazon KDS now supports tagging and attribute-based access control (ABAC) for enhanced fan-out consumers.
* PinpointSMSVoiceV2 (3.7.405.0)
	* AWS End User Messaging has added MONITOR and FILTER functionality to SMS Protect.
* QBusiness (3.7.414.0)
	* Add support for anonymous user access for Q Business applications
* SageMaker (3.7.437.0)
	* Introduced support for P5en instance types on SageMaker Studio for JupyterLab and CodeEditor applications.
* SageMakerMetrics (3.7.402.0)
	* SageMaker Metrics Service now supports FIPS endpoint in all US and Canada Commercial regions.
* SimpleSystemsManagement (3.7.405.0)
	* This release adds support for just-In-time node access in AWS Systems Manager. Just-in-time node access enables customers to move towards zero standing privileges by requiring operators to request access and obtain approval before remotely connecting to nodes managed by the SSM Agent.
* SSMGuiConnect (3.7.400.0)
	* This release adds API support for the connection recording GUI Connect feature of AWS Systems Manager
* Core 3.7.402.48
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1032.0 (2025-04-28 18:16 UTC)
* BedrockRuntime (3.7.420.0)
	* This release adds native h2 support for the bedrock runtime API, the support is only limited to SDKs that support h2 requests natively.
* CertificateManager (3.7.401.0)
	* Add support for file-based HTTP domain control validation, available through Amazon CloudFront.
* CloudFront (3.7.405.0)
	* Add distribution tenant, connection group, and multi-tenant distribution APIs to the CloudFront SDK.
* DynamoDBv2 (3.7.407.2)
	* Doc only update for GSI descriptions.
* Imagebuilder (3.7.404.0)
	* Add integration with SSM Parameter Store to Image Builder.
* Core 3.7.402.47
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1031.0 (2025-04-25 18:20 UTC)
* BedrockRuntime (3.7.419.0)
	* You can now reference images and documents stored in Amazon S3 when using InvokeModel and Converse APIs with Amazon Nova Lite and Nova Pro. This enables direct integration of S3-stored multimedia assets in your model requests without manual downloading or base64 encoding.
* ECS (3.7.410.2)
	* Documentation only release for Amazon ECS.
* MarketplaceDeployment (3.7.400.140)
	* Doc only update for the AWS Marketplace Deployment Service that fixes several customer-reported issues.
* Core 3.7.402.46
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1030.0 (2025-04-24 21:38 UTC)
* AppRunner (3.7.401.0)
	* AWS App Runner adds Node.js 22 runtime.
* AppSync (3.7.408.0)
	* Add data source support to Event APIs
* BedrockDataAutomation (3.7.402.0)
	* Added support for modality routing and modality enablement on CreateDataAutomationProject and UpdateDataAutomationProject APIs
* CodeBuild (3.7.418.0)
	* Remove redundant validation check.
* DynamoDBv2 (3.7.407.0)
	* Add support for ARN-sourced account endpoint generation for TransactWriteItems. This will generate account endpoints for DynamoDB TransactWriteItems requests using ARN-sourced account ID when available.
* ECS (3.7.410.1)
	* Documentation only release for Amazon ECS
* PCS (3.7.402.6)
	* Documentation-only update: added valid values for the version property of the Scheduler and SchedulerRequest data types.
* RDS (3.7.411.0)
	* This Amazon RDS release adds support for managed master user passwords for Oracle CDBs.
* Core 3.7.402.45
	* Update HttpRequestMessageFactory to correctly set the Content-Length header
	* All services packages updated to require new Core

### 3.7.1029.0 (2025-04-23 18:17 UTC)
* CodeBuild (3.7.417.0)
	* Add support for custom instance type for reserved capacity fleets
* ECS (3.7.410.0)
	* Add support to roll back an In_Progress ECS Service Deployment
* ResourceExplorer2 (3.7.402.92)
	* Documentation-only update for CreateView option correction
* Core 3.7.402.44
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1028.0 (2025-04-22 18:42 UTC)
* Account (3.7.402.0)
	* AWS Account Management now supports account name update via IAM principals.
* CognitoIdentityProvider (3.7.408.0)
	* This release adds refresh token rotation.
* EC2 (3.7.438.0)
	* Added support for  ClientRouteEnforcementOptions flag in CreateClientVpnEndpoint and ModifyClientVpnEndpoint requests and DescribeClientVpnEndpoints responses
* EntityResolution (3.7.403.0)
	* To expand support for matching records using digital identifiers with TransUnion
* MQ (3.7.401.0)
	* You can now delete Amazon MQ broker configurations using the DeleteConfiguration API. For more information, see Configurations in the Amazon MQ API Reference.
* RedshiftServerless (3.7.404.0)
	* Provides new and updated API members to support the Redshift Serverless reservations feature.
* S3Control (3.7.408.0)
	* Fix endpoint resolution test cases

### 3.7.1027.0 (2025-04-21 18:22 UTC)
* ARCZonalShift (3.7.402.0)
	* Updates to documentation and exception types for Zonal Autoshift
* Budgets (3.7.403.0)
	* Releasing the new Budget FilterExpression and Metrics fields to support more granular filtering options. These new fields are intended to replace CostFilters and CostTypes, which are deprecated as of 2025/18/04.
* KinesisFirehose (3.7.402.53)
	* Documentation update regarding the number of streams you can create using the CreateDeliveryStream API.
* MediaTailor (3.7.404.0)
	* Added support for Recurring Prefetch and Traffic Shaping on both Single and Recurring Prefetch. ListPrefetchSchedules now return single prefetchs by default and can be provided scheduleType of SINGLE, RECURRING, AND ALL.
* QBusiness (3.7.413.0)
	* The CheckDocumentAccess API for Amazon Q Business is a self-service debugging API that allows administrators to verify document access permissions and review Access Control List (ACL) configurations.
* SecurityHub (3.7.403.28)
	* Minor documentation update for the GetConfigurationPolicyAssociation example

### 3.7.1026.0 (2025-04-18 18:16 UTC)
* QConnect (3.7.405.0)
	* This release adds support for the following capabilities: Chunking generative answer replies from Amazon Q in Connect. Integration support for the use of additional LLM models with Amazon Q in Connect.
* SageMaker (3.7.436.0)
	* This release adds a new Neuron driver option in InferenceAmiVersion parameter for ProductionVariant. Additionally, it adds support for fetching model lifecycle status in the ListModelPackages API. Users can now use this API to view the lifecycle stage of models that have been shared with them.
* ServiceQuotas (3.7.401.0)
	* Add new optional SupportCaseAllowed query parameter to the RequestServiceQuotaIncrease API
* Core 3.7.402.43
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1025.0 (2025-04-17 18:22 UTC)
* AccessAnalyzer (3.7.404.0)
	* Added new resource types to evaluate for public access in resource policies and added support for S3 directory bucket access points.
* AutoScaling (3.7.407.79)
	* Doc only update for EC2 Auto Scaling.
* Bedrock (3.7.419.0)
	* With this release, Bedrock Evaluation will now support custom metrics for evaluation.
* Connect (3.7.420.0)
	* This release adds following capabilities to Contact Lens Rules APIs 1/ 'ASSIGN_SLA' action and  '$.Case.TemplateId' comparison value for 'OnCaseCreate' and 'OnCaseUpdate' event sources 2/ 'OnSlaBreach' Cases event source which supports '$.RelatedItem.SlaConfiguration.Name' comparison value
* ECS (3.7.409.0)
	* Adds a new AccountSetting - defaultLogDriverMode for ECS.
* IoTFleetWise (3.7.407.0)
	* We've added stricter parameter validations to AWS IoT FleetWise signal catalog, model manifest, and decoder manifest APIs.
* MemoryDB (3.7.403.0)
	* Added support for IPv6 and dual stack for Valkey and Redis clusters. Customers can now launch new Valkey and Redis clusters with IPv6 and dual stack networking support.
* Omics (3.7.404.0)
	* Add versioning for HealthOmics workflows
* PrometheusService (3.7.403.0)
	* Add Workspace Configuration APIs for Amazon Prometheus
* Core 3.7.402.42
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1024.0 (2025-04-16 18:29 UTC)
* ConnectCases (3.7.402.0)
	* This feature provides capabilities to help track and meet service level agreements (SLAs) on cases programmatically. It allows configuring a new related item of type `Sla` on a case using CreateRelatedItem API and provides the ability to search for this new related item using SearchRelatedItems API.
* DSQL (3.7.402.0)
	* Added GetClusterEndpointService API. The new API allows retrieving endpoint service name specific to a cluster.
* EKS (3.7.415.0)
	* Added support for new AL2023 ARM64 NVIDIA AMIs to the supported AMITypes.
* EventBridge (3.7.404.0)
	* Adding support for KmsKeyIdentifer in CreateConnection, UpdateConnection and DescribeConnection APIs
* ResourceGroups (3.7.402.0)
	* Resource Groups: TagSyncTasks can be created with ResourceQuery
* S3Tables (3.7.402.0)
	* S3 Tables now supports setting encryption configurations on table buckets and tables. Encryption configurations can use server side encryption using AES256 or KMS customer-managed keys.
* ServiceCatalog (3.7.400.135)
	* Updated default value for the access-level-filter in SearchProvisionedProducts API to Account. For access to userLevel or roleLevel, the user must provide access-level-filter parameter.
* Core 3.7.402.41
	* Added pagination attribute for Paginator methods
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1023.0 (2025-04-14 18:18 UTC)
* EntityResolution (3.7.402.0)
	* This is to add new metrics to our GetIdMappingJob API and also update uniqueId naming for batchDeleteUniqueIds API to be more accurate
* TaxSettings (3.7.406.0)
	* Indonesia SOR Tax Registration Launch
* Core 3.7.402.40
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1022.0 (2025-04-11 18:28 UTC)
* AWSMarketplaceMetering (3.7.403.0)
	* Add support for Marketplace Metering Service dual-stack endpoints for CN regions
* ConnectContactLens (3.7.401.0)
	* Making sentiment optional for ListRealtimeContactAnalysisSegments Response depending on conversational analytics configuration
* DataZone (3.7.412.0)
	* Raise hard limit of authorized principals per SubscriptionTarget from 10 to 20.
* Detective (3.7.401.0)
	* Add support for Detective DualStack endpoints
* DynamoDBv2 (3.7.406.21)
	* Doc only update for API descriptions.
* MarketplaceEntitlementService (3.7.403.0)
	* Add support for Marketplace Entitlement Service dual-stack endpoints for CN and GOV regions
* PCS (3.7.402.0)
	* Changed the minimum length of clusterIdentifier, computeNodeGroupIdentifier, and queueIdentifier to 3.
* VerifiedPermissions (3.7.403.0)
	* Adds deletion protection support to policy stores. Deletion protection is disabled by default, can be enabled via the CreatePolicyStore or UpdatePolicyStore APIs, and is visible in GetPolicyStore.
* Core 3.7.402.39
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1021.0 (2025-04-10 18:26 UTC)
* ApplicationAutoScaling (3.7.403.0)
	* Application Auto Scaling now supports horizontal scaling for Elasticache Memcached self-designed clusters using target tracking scaling policies and scheduled scaling.
* ElastiCache (3.7.403.0)
	* AWS ElastiCache SDK now supports using MemcachedUpgradeConfig parameter with ModifyCacheCluster API to enable updating Memcached cache node types. Please refer to updated AWS ElastiCache public documentation for detailed information on API usage and implementation.
* MainframeModernization (3.7.403.0)
	* Introduce three new APIs: CreateDataSetExportTask, GetDataSetExportTask and ListDataSetExportHistory. Add support for batch restart for Blu Age applications.
* MediaLive (3.7.416.0)
	* AWS Elemental MediaLive / Features : Add support for CMAF Ingest CaptionLanguageMappings, TimedMetadataId3 settings, and Link InputResolution.
* QBusiness (3.7.412.0)
	* Adds functionality to enable/disable a new Q Business Hallucination Reduction feature. If enabled, Q Business will detect and attempt to remove Hallucinations from certain Chat requests.
* QuickSight (3.7.415.0)
	* Add support to analysis and sheet level highlighting in QuickSight.
* Core 3.7.402.38
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1020.0 (2025-04-09 18:36 UTC)
* ControlCatalog (3.7.403.0)
	* The GetControl API now surfaces a control's Severity, CreateTime, and Identifier for a control's Implementation. The ListControls API now surfaces a control's Behavior, Severity, CreateTime, and Identifier for a control's Implementation.
* DynamoDBv2 (3.7.406.19)
	* Documentation update for secondary indexes and Create_Table.
* Glue (3.7.416.0)
	* The TableOptimizer APIs in AWS Glue now return the DpuHours field in each TableOptimizerRun, providing clients visibility to the DPU-hours used for billing in managed Apache Iceberg table compaction optimization.
* GroundStation (3.7.401.0)
	* Support tagging Agents and adjust input field validations
* Transfer (3.7.407.0)
	* This launch includes 2 enhancements to SFTP connectors user-experience: 1) Customers can self-serve concurrent connections setting for their connectors, and 2) Customers can discover the public host key of remote servers using their SFTP connectors.
* Core 3.7.402.37
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1019.0 (2025-04-08 18:53 UTC)
* BedrockRuntime (3.7.418.0)
	* This release introduces our latest bedrock runtime API, InvokeModelWithBidirectionalStream. The API supports both input and output streams and is supported by only HTTP2.0.
* CostExplorer (3.7.406.0)
	* This release supports Pagination traits on Cost Anomaly Detection APIs.
* CostOptimizationHub (3.7.404.0)
	* This release adds resource type "MemoryDbReservedInstances" and resource type "DynamoDbReservedCapacity" to the GetRecommendation, ListRecommendations, and ListRecommendationSummaries APIs to support new MemoryDB and DynamoDB RI recommendations.
* IoTFleetWise (3.7.406.0)
	* This release adds the option to update the strategy of state templates already associated to a vehicle, without the need to remove and re-add them.
* SecurityHub (3.7.403.20)
	* Documentation updates for AWS Security Hub.
* StorageGateway (3.7.404.0)
	* Added new ActiveDirectoryStatus value, ListCacheReports paginator, and support for longer pagination tokens.
* TaxSettings (3.7.405.0)
	* Uzbekistan Launch on TaxSettings Page
* Core 3.7.402.36
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1018.0 (2025-04-07 18:46 UTC)
* Bedrock (3.7.418.0)
	* New options for how to handle harmful content detected by Amazon Bedrock Guardrails.
* BedrockRuntime (3.7.417.0)
	* New options for how to handle harmful content detected by Amazon Bedrock Guardrails.
* CodeBuild (3.7.416.0)
	* AWS CodeBuild now offers an enhanced debugging experience.
* Glue (3.7.415.0)
	* Add input validations for multiple Glue APIs
* MediaLive (3.7.415.0)
	* AWS Elemental MediaLive now supports SDI inputs to MediaLive Anywhere Channels in workflows that use AWS SDKs.
* Personalize (3.7.402.0)
	* Add support for eventsConfig for CreateSolution, UpdateSolution, DescribeSolution, DescribeSolutionVersion. Add support for GetSolutionMetrics to return weighted NDCG metrics when eventsConfig is enabled for the solution.
* Transfer (3.7.406.0)
	* This launch enables customers to manage contents of their remote directories, by deleting old files or moving files to archive folders in remote servers once they have been retrieved. Customers will be able to automate the process using event-driven architecture.

### 3.7.1017.0 (2025-04-04 18:38 UTC)
* DirectoryServiceData (3.7.400.108)
	* Doc only update - fixed broken links.
* EC2 (3.7.437.5)
	* Doc-only updates for Amazon EC2
* EventBridge (3.7.403.0)
	* Amazon EventBridge adds support for customer-managed keys on Archives and validations for two fields: eventSourceArn and kmsKeyIdentifier.
* S3Control (3.7.407.5)
	* Updated max size of Prefixes parameter of Scope data type.
* Core 3.7.402.35
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1016.0 (2025-04-03 18:28 UTC)
* BedrockAgent (3.7.424.0)
	* Added optional "customMetadataField" for Amazon Aurora knowledge bases, allowing single-column metadata. Also added optional "textIndexName" for MongoDB Atlas knowledge bases, enabling hybrid search support.
* ChimeSDKVoice (3.7.402.0)
	* Added FOC date as an attribute of PhoneNumberOrder, added AccessDeniedException as a possible return type of ValidateE911Address
* MailManager (3.7.407.0)
	* Add support for Dual_Stack and PrivateLink types of IngressPoint. For configuration requests, SES Mail Manager will now accept both IPv4/IPv6 dual-stack endpoints and AWS PrivateLink VPC endpoints for email receiving.
* OpenSearchService (3.7.404.70)
	* Improve descriptions for various API commands and data types.
* Route53 (3.7.407.0)
	* Added us-gov-east-1 and us-gov-west-1 as valid Latency Based Routing regions for change-resource-record-sets.
* SageMaker (3.7.435.0)
	* Adds support for i3en, m7i, r7i instance types for SageMaker Hyperpod
* SimpleEmailV2 (3.7.410.0)
	* This release enables customers to provide attachments in the SESv2 SendEmail and SendBulkEmail APIs.
* TranscribeService (3.7.403.0)
	* This Feature Adds Support for the "zh-HK" Locale for Batch Operations
* Core 3.7.402.34
	* Updating endpoints.json file.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 3.7.1015.1 (2025-04-03 00:38 UTC)
* Core 3.7.402.33
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1015.0 (2025-04-02 18:31 UTC)
* ApplicationSignals (3.7.406.0)
	* Application Signals now supports creating Service Level Objectives on service dependencies. Users can now create or update SLOs on discovered service dependencies to monitor their standard application metrics.
* CodeBuild (3.7.415.0)
	* This release adds support for environment type WINDOWS_SERVER_2022_CONTAINER in ProjectEnvironment
* ECR (3.7.410.15)
	* Fix for customer issues related to AWS account ID and size limitation for token.
* ECS (3.7.408.62)
	* This is an Amazon ECS documentation only update to address various tickets.
* LexModelsV2 (3.7.403.0)
	* Release feature of errorlogging for lex bot, customer can config this feature in bot version to generate log for error exception which helps debug
* MediaLive (3.7.414.0)
	* Added support for SMPTE 2110 inputs when running a channel in a MediaLive Anywhere cluster. This feature enables ingestion of SMPTE 2110-compliant video, audio, and ancillary streams by reading SDP files that AWS Elemental MediaLive can retrieve from a network source.
* Core 3.7.402.32
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1014.0 (2025-04-01 18:25 UTC)
* CleanRooms (3.7.405.0)
	* This release adds support for updating the analytics engine of a collaboration.
* SageMaker (3.7.434.0)
	* Added tagging support for SageMaker notebook instance lifecycle configurations
* Core 3.7.402.31
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1013.0 (2025-03-31 18:45 UTC)
* BedrockRuntime (3.7.416.0)
	* Add Prompt Caching support to Converse and ConverseStream APIs
* Deadline (3.7.405.0)
	* With this release you can use a new field to specify the search term match type. Search term match types currently support fuzzy and contains matching.
* EC2 (3.7.437.0)
	* Release VPC Route Server, a new feature allowing dynamic routing in VPCs.
* EKS (3.7.414.0)
	* Add support for updating RemoteNetworkConfig for hybrid nodes on EKS UpdateClusterConfig API
* MarketplaceEntitlementService (3.7.402.0)
	* Add support for Marketplace Entitlement Service dual-stack endpoints.
* Outposts (3.7.406.0)
	* Enabling Asset Level Capacity Management feature, which allows customers to create a Capacity Task for a single Asset on their active Outpost.
* S3 (3.7.416.0)
	* Amazon S3 adds support for S3 Access Points for directory buckets in AWS Dedicated Local Zones
* S3Control (3.7.407.0)
	* Amazon S3 adds support for S3 Access Points for directory buckets in AWS Dedicated Local Zones
* SimpleEmailV2 (3.7.409.0)
	* Add dual-stack support to global endpoints.
* Transfer (3.7.405.0)
	* Add WebAppEndpointPolicy support for WebApps
* Core 3.7.402.30
	* Fixed an issue where property keys in credentials/config file were incorrectly considered as case-sensitive.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1012.0 (2025-03-28 18:26 UTC)
* APIGateway (3.7.402.0)
	* Adds support for setting the IP address type to allow dual-stack or IPv4 address types to invoke your APIs or domain names.
* ApiGatewayV2 (3.7.402.0)
	* Adds support for setting the IP address type to allow dual-stack or IPv4 address types to invoke your APIs or domain names.
* AWSMarketplaceMetering (3.7.402.0)
	* Add support for Marketplace Metering Service dual-stack endpoints.
* BedrockRuntime (3.7.415.0)
	* Launching Multi-modality Content Filter for Amazon Bedrock Guardrails.
* CodeBuild (3.7.414.0)
	* This release adds support for cacheNamespace in ProjectCache
* ECS (3.7.408.59)
	* This is an Amazon ECS documentation only release that addresses tickets.
* NetworkManager (3.7.402.0)
	* Add support for NetworkManager Dualstack endpoints.
* PaymentCryptography (3.7.403.0)
	* The service adds support for transferring AES-256 and other keys between the service and other service providers and HSMs. This feature uses ECDH to derive a one-time key transport key to enable these secure key exchanges.
* QuickSight (3.7.414.0)
	* RLS permission dataset with userAs: RLS_RULES flag, Q in QuickSight/Threshold Alerts/Schedules/Snapshots in QS embedding, toggle dataset refresh email alerts via API, transposed table with options: column width, type and index, toggle Q&A on dashboards, Oracle Service Name when creating data source.
* SageMaker (3.7.433.0)
	* TransformAmiVersion for Batch Transform and SageMaker Search Service Aggregate Search API Extension
* Core 3.7.402.29
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1011.0 (2025-03-27 18:32 UTC)
* Batch (3.7.406.0)
	* This release will enable two features: Firelens log driver, and Execute Command on Batch jobs on ECS. Both features will be passed through to ECS.
* BCMPricingCalculator (3.7.404.0)
	* Added standaloneAccountRateTypeSelections for GetPreferences and UpdatePreferences APIs. Added STALE enum value to status attribute in GetBillScenario and UpdateBillScenario APIs.
* BedrockAgentRuntime (3.7.424.0)
	* bedrock flow now support node action trace.
* CloudFormation (3.7.403.0)
	* Adding support for the new parameter "ScanFilters" in the CloudFormation StartResourceScan API. When this parameter is included, the StartResourceScan API will initiate a scan limited to the resource types specified by the parameter.
* DataZone (3.7.411.0)
	* This release adds new action type of Create Listing Changeset for the Metadata Enforcement Rule feature.
* EKS (3.7.413.0)
	* Added support for BOTTLEROCKET FIPS AMIs to AMI types in US regions.
* GameLift (3.7.405.0)
	* Amazon GameLift Servers add support for additional instance types.
* IdentityManagement (3.7.405.0)
	* Update IAM dual-stack endpoints for BJS, IAD and PDT partitions
* SageMaker (3.7.432.0)
	* add: recovery mode for SageMaker Studio apps
* SSOOIDC (3.7.401.0)
	* This release adds AwsAdditionalDetails in the CreateTokenWithIAM API response.
* Core 3.7.402.28
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1010.0 (2025-03-26 19:20 UTC)
* ARCZonalShift (3.7.401.0)
	* Add new shiftType field for ARC zonal shifts.
* DirectConnect (3.7.402.0)
	* With this release, AWS Direct Connect allows you to tag your Direct Connect gateways. Tags are metadata that you can create and use to manage your Direct Connect gateways. For more information about tagging, see AWS Tagging Strategies.
* MediaConvert (3.7.411.0)
	* This release adds a configurable Quality Level setting for the top rendition of Auto ABR jobs
* MediaTailor (3.7.403.0)
	* Add support for log filtering which allow customers to filter out selected event types from logs.
* Polly (3.7.403.0)
	* Added support for the new voice - Jihye (ko-KR). Jihye is available as a Neural voice only.
* RDS (3.7.410.59)
	* Add note about the Availability Zone where RDS restores the DB cluster for the RestoreDBClusterToPointInTime operation.
* WAFV2 (3.7.406.0)
	* This release adds the ability to associate an AWS WAF v2 web ACL with an AWS Amplify App.
* Core 3.7.402.27
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1009.0 (2025-03-25 20:24 UTC)
* AWSMarketplaceMetering (3.7.401.0)
	* This release enhances the BatchMeterUsage API to support new field CustomerAWSAccountId in request and response and making CustomerIdentifier optional. CustomerAWSAccountId or CustomerIdentifier must be provided in request but not both.
* BedrockAgent (3.7.423.0)
	* Adding support for Amazon OpenSearch Managed clusters as a vector database in Knowledge Bases for Amazon Bedrock
* EKS (3.7.412.0)
	* Added support to override upgrade-blocking readiness checks via force flag when updating a cluster.
* GameLiftStreams (3.7.401.0)
	* Minor updates to improve developer experience.
* Keyspaces (3.7.403.0)
	* Removing replication region limitation for Amazon Keyspaces Multi-Region Replication APIs.
* MarketplaceEntitlementService (3.7.401.0)
	* This release enhances the GetEntitlements API to support new filter CUSTOMER_AWS_ACCOUNT_ID in request and CustomerAWSAccountId field in response.
* SageMaker (3.7.431.0)
	* This release adds support for customer-managed KMS keys in Amazon SageMaker Partner AI Apps
* WorkSpacesThinClient (3.7.403.0)
	* Deprecate tags field in Get API responses
* Core 3.7.402.26
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1008.0 (2025-03-24 18:21 UTC)
* IoTWireless (3.7.402.0)
	* Mark EutranCid under LteNmr optional.
* PCS (3.7.401.0)
	* ClusterName/ClusterIdentifier, ComputeNodeGroupName/ComputeNodeGroupIdentifier, and QueueName/QueueIdentifier can now have 10 characters, and a minimum of 3 characters. The TagResource API action can now return ServiceQuotaExceededException.
* QConnect (3.7.404.52)
	* Provides the correct value for supported model ID.
* SimpleSystemsManagement (3.7.404.0)
	* This release adds the AvailableSecurityUpdatesComplianceStatus field to patch baseline operations, as well as the AvailableSecurityUpdateCount and InstancesWithAvailableSecurityUpdates to patch state operations. Applies to Windows Server managed nodes only.
* Core 3.7.402.25
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1007.0 (2025-03-21 18:25 UTC)
* Bedrock (3.7.417.0)
	* A CustomModelUnit(CMU) is an abstract view of the hardware utilization that Bedrock needs to host a a single copy of your custom imported model. Bedrock determines the number of CMUs that a model copy needs when you import the custom model. You can use CMUs to estimate the cost of Inference's.
* DataZone (3.7.410.0)
	* Add support for overriding selection of default AWS IAM Identity Center instance as part of Amazon DataZone domain APIs.
* Route53RecoveryControlConfig (3.7.401.0)
	* Adds dual-stack (IPv4 and IPv6) endpoint support for route53-recovery-control-config operations, opt-in dual-stack addresses for cluster endpoints, and UpdateCluster API to update the network-type of clusters between IPv4 and dual-stack.
* S3 (3.7.415.23)
	* Removed customization for S3 HeadBucket to make it public.
* SageMaker (3.7.430.0)
	* This release does the following: 1.) Adds DurationHours as a required field to the SearchTrainingPlanOfferings action in the SageMaker AI API; 2.) Adds support for G6e instance types for SageMaker AI inference optimization jobs.
* Core 3.7.402.24
	* Implement MultiSelect List and Flatten Operator in operation context param expressions
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1006.0 (2025-03-20 18:39 UTC)
* Amplify (3.7.406.0)
	* Added appId field to Webhook responses
* Bedrock (3.7.416.0)
	* With this release, Bedrock Evaluation will now support bring your own inference responses.
* ControlCatalog (3.7.402.70)
	* Add ExemptAssumeRoot parameter to adapt for new AWS AssumeRoot capability.
* MailManager (3.7.406.0)
	* Amazon SES Mail Manager. Extended rule string and boolean expressions to support analysis in condition evaluation. Extended ingress point string expression to support analysis in condition evaluation
* NetworkFirewall (3.7.404.0)
	* You can now use flow operations to either flush or capture traffic monitored in your firewall's flow table.
* Core 3.7.402.23
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1005.0 (2025-03-19 19:05 UTC)
* Bedrock (3.7.415.0)
	* Support custom prompt routers for evaluation jobs
* DynamoDBv2 (3.7.406.4)
	* Update paginators to use the latest paginators model file.
	* Added check in DateTimeToEpochSeconds to inspect null value for Nullable DateTime property decorated with StoreAsEpoch attribute, where it was incorrectly relying on exception to return the entry.
* EC2 (3.7.436.4)
	* Doc-only updates for EC2 for March 2025.
* Lambda (3.7.412.0)
	* Add Ruby 3.4 (ruby3.4) support to AWS Lambda.
* MediaConnect (3.7.404.0)
	* This release adds support for NDI flow outputs in AWS Elemental MediaConnect. You can now send content from your MediaConnect transport streams directly to your NDI environment using the new NDI output type.
* NeptuneGraph (3.7.405.0)
	* Update IAM Role ARN Validation to Support Role Paths
* RDS (3.7.410.54)
	* Update paginators to use the latest paginators model file.
* SageMaker (3.7.429.0)
	* Added support for g6, g6e, m6i, c6i instance types in SageMaker Processing Jobs.
* Core 3.7.402.22
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1004.0 (2025-03-18 18:27 UTC)
* AppSync (3.7.407.0)
	* Providing Tagging support for DomainName in AppSync
* CleanRooms (3.7.404.0)
	* This release adds support for PySpark jobs. Customers can now analyze data by running jobs using approved PySpark analysis templates.
* DynamoDBv2 (3.7.406.3)
	* Update documentation for code generated from DynamoDB Streams models
* MediaConvert (3.7.410.0)
	* This release adds support for AVC passthrough, the ability to specify PTS offset without padding, and an A/V segment matching feature.
* Route53 (3.7.406.0)
	* Amazon Route 53 now supports the iso-f regions for private DNS Amazon VPCs and cloudwatch healthchecks.
* Core 3.7.402.21
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1003.0 (2025-03-17 18:32 UTC)
* ApplicationSignals (3.7.405.0)
	* This release adds support for adding, removing, and listing SLO time exclusion windows with the BatchUpdateExclusionWindows and ListServiceLevelObjectiveExclusionWindows APIs.
* CloudWatchRUM (3.7.402.0)
	* CloudWatch RUM now supports unminification of JS error stack traces.
* GeoMaps (3.7.401.0)
	* Provide support for vector map styles in the GetStaticMap operation.
* TaxSettings (3.7.404.0)
	* Adjust Vietnam PaymentVoucherNumber regex and minor API change.
* WAFV2 (3.7.405.0)
	* AWS WAF now lets you inspect fragments of request URIs. You can specify the scope of the URI to inspect and narrow the set of URI fragments.
* Core 3.7.402.20
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1002.0 (2025-03-14 18:14 UTC)
* CognitoIdentity (3.7.402.33)
	* Updated API model build artifacts for identity pools
* CognitoIdentityProvider (3.7.407.8)
	* Minor description updates to API parameters
* Glue (3.7.414.0)
	* This release added AllowFullTableExternalDataAccess to glue catalog resource.
* LakeFormation (3.7.403.0)
	* This release added "condition" to LakeFormation OptIn APIs, also added WithPrivilegedAccess flag to RegisterResource and DescribeResource.
* Core 3.7.402.19
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1001.0 (2025-03-13 22:07 UTC)
* ACMPCA (3.7.402.0)
	* Private Certificate Authority service now supports P521 and RSA3072 key algorithms.
* Amplify (3.7.405.0)
	* Introduced support for Skew Protection. Added enableSkewProtection field to createBranch and updateBranch API.
* CloudWatchLogs (3.7.410.0)
	* Updated CreateLogAnomalyDetector to accept only kms key arn
* CodeBuild (3.7.413.0)
	* AWS CodeBuild now supports webhook filtering by organization name
* DataZone (3.7.409.0)
	* This release adds support to update projects and environments
* DynamoDBv2 (3.7.406.0)
	* Generate account endpoints for DynamoDB requests using ARN-sourced account ID when available
	* Fixed an issue where for a Nullable DateTime property decorated with StoreAsEpochLong attribute, null value was incorrectly stored as -62135596800 in DynamoDB.
* EC2 (3.7.436.0)
	* This release changes the CreateLaunchTemplate, CreateLaunchTemplateVersion, ModifyLaunchTemplate CLI and SDKs such that if you do not specify a client token, a randomly generated token is used for the request to ensure idempotency.
* IVSRealTime (3.7.405.0)
	* IVS Real-Time now offers customers the ability to adjust the participant & composition recording segment duration
* MediaPackageV2 (3.7.404.0)
	* This release adds the ResetChannelState and ResetOriginEndpointState operation to reset MediaPackage V2 channel and origin endpoint. This release also adds a new field, UrlEncodeChildManifest, for HLS/LL-HLS to allow URL-encoding child manifest query string based on the requirements of AWS SigV4.
* S3Control (3.7.406.0)
	* Updating GetDataAccess response for S3 Access Grants to include the matched Grantee for the requested prefix
* Core 3.7.402.18
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.1000.0 (2025-03-11 18:40 UTC)
* EC2 (3.7.435.0)
	* This release adds the GroupLongName field to the response of the DescribeAvailabilityZones API.
* ECR (3.7.410.0)
	* This release adds Amazon ECR to Amazon ECR pull through cache rules support.
* ECS (3.7.408.47)
	* This is a documentation only update for Amazon ECS to address various tickets.
* Inspector2 (3.7.405.0)
	* Adding componentArn to network reachability details
* MediaLive (3.7.413.0)
	* Add an enum option DISABLED for Output Locking Mode under Global Configuration.
* Core 3.7.402.17
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.999.0 (2025-03-10 18:29 UTC)
* BedrockAgent (3.7.422.0)
	* Add support for computer use tools
* BedrockAgentRuntime (3.7.423.0)
	* Add support for computer use tools
* Connect (3.7.419.0)
	* Add support for contact transfers in external voice systems.
* CostExplorer (3.7.405.0)
	* Releasing minor partition endpoint updates.
* MediaLive (3.7.412.0)
	* Adds defaultFontSize and defaultLineHeight as options in the EbuTtDDestinationSettings within the caption descriptions for an output stream.
* PcaConnectorAd (3.7.401.0)
	* PrivateCA Connector for Active Directory now supports dual stack endpoints. This release adds the IpAddressType option to the VpcInformation on a Connector which determines whether the endpoint supports IPv4 only or IPv4 and IPv6 traffic.
* SecurityHub (3.7.403.0)
	* This release adds new StandardsControlsUpdatable field to the StandardsSubscription resource
* TimestreamInfluxDB (3.7.406.14)
	* This release updates the default value of pprof-disabled from false to true.
* Core 3.7.402.16
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.998.0 (2025-03-07 19:30 UTC)
* BedrockAgent (3.7.421.0)
	* Introduces support for Neptune Analytics as a vector data store and adds Context Enrichment Configurations, enabling use cases such as GraphRAG.
* BedrockAgentRuntime (3.7.422.0)
	* Support Multi Agent Collaboration within Inline Agents
* CloudFront (3.7.404.44)
	* Documentation updates for Amazon CloudFront.
* EC2 (3.7.434.0)
	* Add serviceManaged field to DescribeAddresses API response.
* ElasticLoadBalancingV2 (3.7.409.0)
	* This release adds support for assigning IP addresses to Application Load Balancers from VPC IP Address Manager pools.
* NeptuneGraph (3.7.404.21)
	* Several small updates to resolve customer requests.
* Core 3.7.402.15
	* Update the SDK's checksum component to skip adding headers when a request is made with anonymous credentials.
	* Update the SDK's checksum component to skip algorithms that require the AWS Common Runtime dependency, as those may cause issues in customer's environments.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.997.0 (2025-03-06 19:25 UTC)
* Bedrock (3.7.414.0)
	* This releases adds support for Custom Prompt Router
* CloudTrail (3.7.403.24)
	* Doc-only update for CloudTrail.
* IVSRealTime (3.7.404.0)
	* IVS Real-Time now offers customers the ability to merge fragmented recordings in the event of a participant disconnect.
* NetworkFlowMonitor (3.7.401.0)
	* This release contains 2 changes. 1: DeleteScope/GetScope/UpdateScope operations now return 404 instead of 500 when the resource does not exist. 2: Expected string format for clientToken fields of CreateMonitorInput/CreateScopeInput/UpdateMonitorInput have been updated to be an UUID based string.
* RedshiftDataAPIService (3.7.403.0)
	* This release adds support for ListStatements API to filter statements by ClusterIdentifier, WorkgroupName, and Database.
* WAFV2 (3.7.404.0)
	* You can now perform an exact match or rate limit aggregation against the web request's JA4 fingerprint.
* WorkSpaces (3.7.410.0)
	* Added a new ModifyEndpointEncryptionMode API for managing endpoint encryption settings.
* Core 3.7.402.14
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.996.0 (2025-03-05 19:30 UTC)
* BedrockRuntime (3.7.414.0)
	* This releases adds support for Custom Prompt Router ARN
* DataSync (3.7.404.0)
	* AWS DataSync now supports modifying ServerHostname while updating locations SMB, NFS, and ObjectStorage.
* GameLiftStreams (3.7.400.0)
	* New Service: Amazon GameLift Streams delivers low-latency game streaming from AWS global infrastructure to virtually any device with a browser at up to 1080p resolution and 60 fps.
* IoTFleetWise (3.7.405.0)
	* This release adds floating point support for CAN/OBD signals and adds support for signed OBD signals.
* WorkSpaces (3.7.409.0)
	* Added DeviceTypeWorkSpacesThinClient type to allow users to access their WorkSpaces through a WorkSpaces Thin Client.
* Core 3.7.402.13
	* Update the SDK checksum component to better validate whether the AWS Common Runtime dependency can be used.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.995.0 (2025-03-04 21:22 UTC)
* CloudFront (3.7.404.41)
	* Mark AmazonCloudFrontUtil as obsolete and will be removed in the next major version.
* DynamoDBv2 (3.7.405.33)
	* Fixed an issue for incorrect DateTime epoch serialization when date falls out of epoch supported range. (Thanks @sander1095 for initial contribution)
* EC2 (3.7.433.1)
	* Mark ImageUtilities as obsolete and will be removed in the next major version.
	* Mark VPCUtilities as obsolete and will be removed in the next major version.
* ElastiCache (3.7.402.50)
	* Doc only update, listing 'valkey7' and 'valkey8' as engine options for parameter groups.
* IoTManagedIntegrations (3.7.400.0)
	* Adding managed integrations APIs for IoT Device Management to setup and control devices across different manufacturers and connectivity protocols. APIs include managedthing operations, credential and provisioning profile management, notification configuration, and OTA update.
* IoTSiteWise (3.7.404.0)
	* AWS IoT SiteWise now supports MQTT-enabled, V3 gateways. Configure data destinations for real-time ingestion into AWS IoT SiteWise or buffered ingestion using Amazon S3 storage. You can also use path filters for precise data collection from specific MQTT topics.
* RDS (3.7.410.44)
	* Note support for Database Insights for Amazon RDS.
* Core 3.7.402.12
	* Added method AWSSDKUtils.ConvertFromUnixLongEpochSeconds() for converting Unix epoch seconds to DateTime structure.
	* Updating endpoints.json file.
	* All services packages updated to require new Core

### 3.7.994.0 (2025-03-03 19:30 UTC)
* CloudWatchRUM (3.7.401.0)
	* Add support for PutResourcePolicy, GetResourcePolicy and DeleteResourcePolicy to support resource based policies for AWS CloudWatch RUM
* CognitoIdentityProvider (3.7.407.0)
	* Added the capacity to return available challenges in admin authentication and to set version 3 of the pre token generation event for M2M ATC.
* EC2 (3.7.433.0)
	* Update the DescribeVpcs response
* QBusiness (3.7.411.0)
	* Adds support for the ingestion of audio and video files by Q Business, which can be configured with the mediaExtractionConfiguration parameter.
* SageMaker (3.7.428.0)
	* Add DomainId to CreateDomainResponse
* TranscribeService (3.7.402.14)
	* Updating documentation for post call analytics job queueing.
* Core 3.7.402.11
	* Updating endpoints.json file.
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

