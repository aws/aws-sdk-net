### 4.0.225.0 (2026-04-03 18:16 UTC)
* Bedrock (4.0.25.0)
	* Amazon Bedrock Guardrails enforcement configuration APIs now support selective guarding controls for system prompts as well as user and assistant messages, along with SDK support for Amazon Bedrock resource policy APIs.
* BedrockAgent (4.0.8.0)
	* Added strict parameter to ToolSpecification to allow users to enforce strict JSON schema adherence for tool input schemas.
* BedrockAgentCoreControl (4.0.26.1)
	* Documentation Update for Adds support for three-legged (Authorization Code grant type) OAuth along with predefined MCP tool schema configuration for Amazon Bedrock AgentCore gateway MCP server targets.
* CloudWatchLogs (4.0.19.0)
	* Added queryDuration, bytesScanned, and userIdentity fields to the QueryInfo response object returned by DescribeQueries. Customers can now view detailed query cost information including who ran the query, how long it took, and the volume of data scanned.
* Imagebuilder (4.0.8.0)
	* Updated pagination token validation for ListContainerRecipes API to support maximum size of 65K characters
* Lightsail (4.0.6.0)
	* Add support for tagging of Alarm resource type
* MediaLive (4.0.18.0)
	* AWS Elemental MediaLive released a new features that allows customers to use HLG 2020 as a color space for AV1 video codec.
* Organizations (4.0.11.3)
	* Updates close Account quota for member accounts in an Organization.
* PaymentCryptography (4.0.8.0)
	* Adds optional support to retrieve previously generated import and export tokens to simplify import and export functions
* Core 4.0.3.27
	* Fix issue with unexpected exceptions when disposing event stream responses
	* Fix rendering of <list>, <item>, <term>, and <description> XML doc tags in generated API reference documentation.
	* All service and extension packages updated to require new Core

### 4.0.224.0 (2026-04-02 18:18 UTC)
* AppStream (4.0.8.0)
	* Amazon WorkSpaces Applications now supports drain mode for instances in multi-session fleets. This capability allows administrators to instruct individual fleet instances to stop accepting new user sessions while allowing existing sessions to continue uninterrupted.
* BedrockAgentCoreControl (4.0.26.0)
	* Adds support for three-legged (Authorization Code grant type) OAuth along with predefined MCP tool schema configuration for Amazon Bedrock AgentCore gateway MCP server targets.
* BedrockDataAutomation (4.0.8.0)
	* Data Automation Library is a BDA capability that lets you create reusable entity resources to improve extraction accuracy. Libraries support Custom Vocabulary entities that enhance speech recognition for audio and video content with domain-specific terminology shared across projects
* BedrockRuntime (4.0.17.0)
	* Relax ToolUseId pattern to allow dots and colons
* CloudWatch (4.0.9.0)
	* CloudWatch now supports OTel enrichment to make vended metrics for supported AWS resources queryable via PromQL with resource ARN and tag labels, and PromQL alarms for metrics ingested via the OTLP endpoint with multi-contributor evaluation.
* CloudWatchLogs (4.0.18.0)
	* We are pleased to announce that our logs transformation csv processor now has a destination field, allowing you to specify under which parent node parsed columns be placed under.
* Connect (4.0.38.0)
	* Include CUSTOMER to evaluation target and participant role. Support Korean, Japanese and Simplified Chinese in evaluation forms.
* Deadline (4.0.16.0)
	* AWS Deadline Cloud now supports configurable scheduling on each queue. The scheduling configuration controls how workers are distributed across jobs.
* GameLift (4.0.8.0)
	* Amazon GameLift Servers now includes a ComputeName field in game session API responses, making it easier to identify which compute is hosting a game session without cross-referencing IP addresses.
* GeoPlaces (4.0.4.14)
	* This release updates API reference documentation for Amazon Location Service Places APIs to reflect regional restrictions for Grab Maps users in ReverseGeocode, Suggest, SearchText, and GetPlace operations
* Pricing (4.0.4.0)
	* This release increases the MaxResults parameter of the GetAttributeValues API from 100 to 10000.

### 4.0.223.0 (2026-04-01 18:20 UTC)
* Bedrock (4.0.24.0)
	* Adds support for Bedrock Batch Inference Job Progress Monitoring
* BedrockAgentCore (4.0.16.0)
	* Added the ability to filter out empty sessions when listing sessions. Customers can now retrieve only sessions that still contain events, eliminating the need to check each session individually. No changes required for existing integrations.
* BedrockAgentCoreControl (4.0.25.0)
	* Adds support for VPC egress private endpoints for Amazon Bedrock AgentCore gateway targets, enabling private connectivity through managed VPC Lattice resources. Also adds IAM credential provider for gateway targets, enabling IAM-based authentication to target endpoints
* ECS (4.0.17.0)
	* Amazon ECS now supports Managed Daemons with dedicated APIs for registering daemon task definitions, creating daemons, and managing daemon deployments.
* ElastiCache (4.0.3.0)
	* Updated SnapshotRetentionLimit documentation for ServerlessCache to correctly describe the parameter as number of days (max 35) instead of number of snapshots.
* Elasticsearch (4.0.5.0)
	* Adding Policy-Min-TLS-1-2-RFC9151-FIPS-2024-08 as TLS Policy in Supported Regions
* GeoRoutes (4.0.3.0)
	* This release makes RoutingBoundary optional in CalculateRouteMatrix, set StopDuration with a maximum value of 49999 for CalculateRoutes, set TrailerCount with a maximum value of 4, and introduces region restrictions for Grab Maps users.
* MedicalImaging (4.0.6.0)
	* Added new boolean flag to persist metadata updates to all primary image sets in the same study as the requested image set.
* OpenSearchService (4.0.16.0)
	* Adding Policy-Min-TLS-1-2-RFC9151-FIPS-2024-08 as TLS Policy in Supported Regions
* Core 4.0.3.26
	* Fix issue with credentials incorrectly rotating during H2 request stream operations triggering a signature mismatch exception
	* All service and extension packages updated to require new Core

### 4.0.222.1 (2026-03-31 22:21 UTC)
* Core 4.0.3.25
	* Fix signature mismatch issue with request events for bi-directional streaming operations due to signature timestamp rounding issue
	* All service and extension packages updated to require new Core

### 4.0.222.0 (2026-03-31 18:23 UTC)
* CertificateManager (4.0.3.0)
	* Adds support for searching for ACM certificates using the new SearchCertificates API.
* CloudFront (4.0.13.0)
	* This release adds bring your own IP (BYOIP) IPv6 support to CloudFront's CreateAnycastIpList and UpdateAnycastIpList API through the IpamCidrConfigs field.
* DatabaseMigrationService (4.0.8.0)
	* To successfully connect to the IBM DB2 LUW database server, you may need to specify additional security parameters that are passed to the JDBC driver. These parameters are EncryptionAlgorithm and SecurityMechanism. Both parameters accept integer values.
* DataExchange (4.0.5.0)
	* Support Tags for AWS Data Exchange resource Assets
* DataZone (4.0.23.0)
	* Adds environmentConfigurationName field to CreateEnvironmentInput and UpdateEnvironmentInput, so that Domain Owners can now recover orphaned environments by recreating deleted configurations with the same name, and will auto-recover orphaned environments
* DevOpsAgent (4.0.1.0)
	* AWS DevOps Agent service General Availability release.
* EC2 (4.0.82.3)
	* This release updates the examples in the documentation for DescribeRegions and DescribeAvailabilityZones.
* GeoMaps (4.0.5.0)
	* This release expands map customization options with adjustable contour line density, dark mode support for Hybrid and Satellite views, enhanced traffic information across multiple map styles, and transit and truck travel modes for Monochrome and Hybrid map styles.
* KinesisAnalyticsV2 (4.0.3.0)
	* Support for Flink 2.2 in Managed Service for Apache Flink
* MailManager (4.0.5.0)
	* Amazon SES Mail Manager now supports optional TLS policy for accepting unencrypted connections and mTLS authentication for ingress endpoints with configurable trust stores. Two new rule actions are available, Bounce for sending non-delivery reports and Lambda invocation for custom email processing.
* MarketplaceAgreement (4.0.5.0)
	* This release adds 8 new APIs for AWS Marketplace sellers. 4 APIs for Cancellations (Send, List, Get, Cancel action on AgreementCancellationRequest), 3 APIs for Billing Adjustments (BatchCreate, List, Get action on BillingAdjustmentRequest), and 1 API to List Invoices (ListAgreementInvoiceLineItems)
* ObservabilityAdmin (4.0.8.0)
	* This release adds the Bedrock and Security Hub resource types for Omnia Enablement launch for March 31.
* Odb (4.0.6.0)
	* Adds support for EC2 Placement Group integration with ODB Network. The GetOdbNetwork and ListOdbNetworks API responses now include the ec2PlacementGroupIds field.
* OpenSearchService (4.0.15.0)
	* Support RegisterCapability, GetCapability, DeregisterCapability API for AI Assistant feature management for OpenSearch UI Applications
* Organizations (4.0.11.0)
	* Added Path field to Account and OrganizationalUnit objects in AWS Organizations API responses.
* PartnerCentralSelling (4.0.10.0)
	* Adding EURO Currency for MRR Amount
* PinpointSMSVoiceV2 (4.0.7.0)
	* This release adds RCS for Business messaging and Notify support. RCS lets you create and manage agents, send and receive messages in the US and Canada via SendTextMessage API, and configure SMS fallback. Notify lets you send templated OTP messages globally in minutes with no phone number required.
* QuickSight (4.0.18.0)
	* Adds StartAutomationJob and DescribeAutomationJob APIs for automation jobs. Adds three custom permission capabilities that allow admins to control whether users can manage Spaces and chat agents. Adds an OAuthClientCredentials structure to provide OAuth 2.0 client credentials inline to data sources.
* S3 (4.0.20.0)
	* Add Bucket Metrics configuration support to directory buckets
* S3Control (4.0.10.0)
	* Adding an optional auditContext parameter to S3 Access Grants credential vending API GetDataAccess to enable job-level audit correlation in S3 CloudTrail logs
* S3Tables (4.0.10.0)
	* S3 Tables now supports nested types when creating tables. Users can define complex column schemas using struct, list, and map types. These types can be composed together to model complex, hierarchical data structures within table schemas.
* SecurityAgent (4.0.0.0)
	* AWS Security Agent is a service that proactively secures applications throughout the development lifecycle with automated security reviews and on-demand penetration testing.
* Sustainability (4.0.0.0)
	* This is the first release of the AWS Sustainability SDK, which enables customers to access their sustainability impact data via API.

### 4.0.221.0 (2026-03-30 18:27 UTC)
* AppStream (4.0.7.0)
	* Add support for URL Redirection
* AutoScaling (4.0.9.0)
	* Adds support for new instance lifecycle states introduced by the instance lifecycle policy and replace root volume features.
* BedrockAgentCore (4.0.15.0)
	* Adds Ground Truth support for AgentCore Evaluations (Evaluate)
* CloudWatchLogs (4.0.17.0)
	* Adds Lookup Tables to CloudWatch Logs for log enrichment using CSV key-value data with KMS encryption support.
* Deadline (4.0.15.0)
	* AWS Deadline Cloud now supports three new fleet auto scaling settings. With scale out rate, you can configure how quickly workers launch. With worker idle duration, you can set how long workers wait before shutting down. With standby worker count, you can keep idle workers ready for fast job start.
* DevOpsAgent (4.0.0.0)
	* AWS DevOps Agent General Availability.
* ECS (4.0.16.0)
	* Adding Local Storage support for ECS Managed Instances by introducing a new field "localStorageConfiguration" for CreateCapacityProvider and UpdateCapacityProvider APIs.
* GameLift (4.0.7.7)
	* Update CreateScript API documentation.
* LakeFormation (4.0.4.10)
	* Add setSourceIdentity to DataLakeSettings Parameters
* OpenSearchService (4.0.14.0)
	* Added Cluster Insights API's In OpenSearch Service SDK.
* PartnerCentralAccount (4.0.2.0)
	* KYB Supplemental Form enables partners who fail business verification to submit additional details and supporting documentation through a self-service form, triggering an automated re-verification without requiring manual intervention from support teams.
* SageMaker (4.0.48.0)
	* Added support for placement strategy and consolidation for SageMaker inference component endpoints. Customers can now configure how inference component copies are distributed across instances and availability zones (AZs), and enable automatic consolidation to optimizes resource utilization.

### 4.0.220.0 (2026-03-27 18:14 UTC)
* BedrockAgentCore (4.0.14.0)
	* Adding AgentCore Code Interpreter Node.js Runtime Support with an optional runtime field
* BedrockAgentCoreControl (4.0.24.0)
	* Adds support for custom code-based evaluators using customer-managed Lambda functions.
* Neptunedata (4.0.4.6)
	* Minor formatting changes to remove unnecessary symbols.
* Omics (4.0.7.0)
	* AWS HealthOmics now supports VPC networking, allowing users to connect runs to external resources with NAT gateway, AWS VPC resources, and more. New Configuration APIs support configuring VPC settings. StartRun API now accepts networkingMode and configurationName parameters to enable VPC networking.
* Core 4.0.3.24
	* Fixed HttpContentRequestStreamHandle to cancel SerializeToStreamAsync on dispose, preventing background event consumption that could drain the event publisher and cause retries to hang.
	* Fixed SignatureDoesNotMatch errors for event stream requests (e.g., Transcribe Streaming) under concurrency by preventing SDK-level retries for event stream requests. The event publisher is a forward-only stream that cannot be rewound, and the AWS4EventSigner signature chain cannot be reset after events are signed during a failed attempt. Operation-level errors such as throttling are now surfaced to the caller for application-level retry.
	* All service and extension packages updated to require new Core

### 4.0.219.0 (2026-03-26 18:15 UTC)
* BCMDataExports (4.0.3.0)
	* With this release we are providing an option to accounts to have their export delivered to an S3 bucket that is not owned by the account.
* CloudWatchLogs (4.0.16.0)
	* This release adds parameter support to saved queries in CloudWatch Logs Insights. Define reusable query templates with named placeholders, invoke them using start query. Available in Console, CLI and SDK
* ElasticMapReduce (4.0.9.0)
	* Add StepExecutionRoleArn to RunJobFlow API
* SageMaker (4.0.47.0)
	* Release support for ml.r5d.16xlarge instance types for SageMaker HyperPod
* TimestreamInfluxDB (4.0.6.0)
	* Timestream for InfluxDB adds support for customer defined maintenance windows. This allows customers to define maintenance schedule during resource creation and updates
* Core 4.0.3.23
	* Fixed concurrent HTTP/2 event streaming requests (e.g., Amazon Transcribe Streaming) failing with SignatureDoesNotMatch and REFUSED_STREAM errors. The SDK now creates a dedicated HttpClient for each bidirectional event stream request to prevent HTTP/2 multiplexing, which is not supported by services like Amazon Transcribe Streaming that require one connection per stream.
	* All service and extension packages updated to require new Core

### 4.0.218.0 (2026-03-25 18:14 UTC)
* ApiGatewayV2 (4.0.5.0)
	* Added DISABLE IN PROGRESS and DISABLE FAILED Portal statuses.
* ApplicationSignals (4.0.6.0)
	* This release adds support for creating SLOs on RUM appMonitors, Synthetics canaries and services.
* Batch (4.0.8.1)
	* Documentation-only update for AWS Batch.
* MarketplaceAgreement (4.0.4.0)
	* The Variable Payments APIs enable AWS Marketplace Sellers to perform manage their payment requests (send, get, list, cancel).
* Polly (4.0.6.0)
	* Add support for Mu-law and A-law codecs for output format
* S3 (4.0.19.2)
	* Update docs for Amazon.S3.Transfer.ITransferUtility.OpenStreamWithResponse to add performance tips
* Uxc (4.0.0.0)
	* GA release of AccountCustomizations, used to manage account color, visible services, and visible regions settings in the AWS Management Console.
* Core 4.0.3.22
	* Optimize ParameterCollection sorting by leveraging ArrayPool for reduced allocations. 

### 4.0.217.0 (2026-03-24 18:16 UTC)
* BedrockAgentCoreControl (4.0.23.0)
	* Adds SDK support for 1) Persist session state in AgentCore Runtime via filesystemConfigurations in CreateAgentRuntime, UpdateAgentRuntime, and GetAgentRuntime APIs, 2) Optional name-based filtering on AgentCore ListBrowserProfiles API.
* ConnectCases (4.0.12.1)
	* Tags on TagResourceRequest is allowed to contain null values
* GameLift (4.0.7.4)
	* Amazon GameLift Servers launches UDP ping beacons in the Beijing and Ningxia (China) Regions to help measure real-time network latency for multiplayer games. The ListLocations API is now available in these regions to provide endpoint domain and port information as part of the locations list.
* MediaPackageV2 (4.0.11.0)
	* Reduces the minimum allowed value for startOverWindowSeconds from 60 to 0, allowing customers to effectively disable the start-over window.
* OpenSearchServerless (4.0.7.0)
	* Adds support for updating the vector options field for existing collections.
* PCS (4.0.13.0)
	* This release adds support for custom slurmdbd and cgroup configuration in AWS PCS. Customers can now specify slurmdbd and cgroup settings to configure database accounting and reporting for their HPC workloads, and control resource allocation and limits for compute jobs.
* RDS (4.0.19.0)
	* Adds support in Aurora PostgreSQL serverless databases for express configuration based creation through WithExpressConfiguration in CreateDbCluster API, and for restoring clusters using RestoreDBClusterToPointInTime and RestoreDBClusterFromSnapshot APIs.
* Extensions.CborProtocol (4.0.0.29)
	* Unmarshall  null values in CBOR maps.

### 4.0.216.0 (2026-03-23 18:18 UTC)
* Batch (4.0.8.0)
	* AWS Batch AMI Visibility feature support. Adds read-only batchImageStatus to Ec2Configuration to provide visibility on the status of Batch-vended AMIs used by Compute Environments.
* ConnectCases (4.0.12.0)
	* You can now use the UpdateRelatedItem API to update the content of comments and custom related items associated with a case.
* DynamoDBv2 (4.0.17.1)
	* Fix Key Expression issue with renamable sort keys.
	* Extend Expression Builder for Projection expressions.
* Lightsail (4.0.5.0)
	* Add support for tagging of ContactMethod resource type
* Omics (4.0.6.0)
	* Adds support for batch workflow runs in Amazon Omics, enabling users to submit, manage, and monitor multiple runs as a single batch. Includes APIs to create, cancel, and delete batches, track submission statuses and counts, list runs within a batch, and configure default settings.
* Core 4.0.3.21
	* Render <important> and <note> XML doc tags as styled noteblock divs in the SDK reference documentation generator.

### 4.0.215.0 (2026-03-20 18:24 UTC)
* Backup (4.0.10.14)
	* Fix Typo for S3Backup Options ( S3BackupACLs to BackupACLs)
* DynamoDBv2 (4.0.17.0)
	* Adding ReplicaArn to ReplicaDescription of a global table replica
* OpenSearchService (4.0.13.0)
	* Added support for Amazon Managed Service for Prometheus (AMP) as a connected data source in OpenSearch UI. Now users can analyze Prometheus metrics in OpenSearch UI without data copy.
* VerifiedPermissions (4.0.7.0)
	* Adds support for Policy Store Aliases, Policy Names, and Policy Template Names. These are customizable identifiers that can be used in place of Policy Store ids, Policy ids, and Policy Template ids respectively in Amazon Verified Permissions APIs.

### 4.0.214.0 (2026-03-19 20:24 UTC)
* Batch (4.0.7.0)
	* AWS Batch now supports quota management, enabling administrators to allocate shared compute resources across teams and projects through quota shares with capacity limits, resource-sharing strategies, and priority-based preemption - currently available for SageMaker Training job queues.
* BedrockAgentCore (4.0.13.0)
	* This release includes SDK support for the following new features on AgentCore Built In Tools.  1. Enterprise Policies for AgentCore Browser Tool. 2. Root CA Configuration Support for AgentCore Browser Tool and Code Interpreter. 3. API changes to AgentCore Browser Profile APIs
* BedrockAgentCoreControl (4.0.22.0)
	* Adds support for the following new features. 1. Enterprise Policies support for AgentCore Browser Tool. 2. Root CA Configuration support for AgentCore Browser Tool and Code Interpreter.
* DynamoDBv2 (4.0.16.0)
	* [Breaking Change] Fix DynamoDB property converter precedence when a global converter is registered.
	* Adds support for ReturnConsumedCapacity on Query/Scan DocumentClient.
* EC2 (4.0.82.0)
	* Amazon EC2 Fleet instant mode now supports launching instances into Interruptible Capacity Reservations, enabling customers to use spare capacity shared by Capacity Reservation owners within their AWS Organization.
* ObservabilityAdmin (4.0.7.0)
	* Adding a new field in the CreateCentralizationRuleForOrganization, UpdateCentralizationRuleForOrganization API and updating the GetCentralizationRuleForOrganization API response to include the new field
* Polly (4.0.5.0)
	* Added bi-directional streaming functionality through a new API, StartSpeechSynthesisStream. This API allows streaming input text through inbound events and receiving audio as part of an output stream simultaneously.
* Core 4.0.3.20
	* Fixed AssumeRoleWithWebIdentityCredentialsOptions.ProxySettings being ignored sometimes.

### 4.0.213.0 (2026-03-18 18:57 UTC)
* DSQL (4.0.9.0)
	* Add configurable token expiry duration to DSQLAuthTokenGenerator. New overloads accept a TimeSpan parameter to set token lifetime, with validation between 0 and 7 days. Default remains 15 minutes for backwards compatibility.
* EC2 (4.0.81.0)
	* The DescribeInstanceTypes API now returns default connection tracking timeout values for TCP, UDP, and UDP stream via the new connectionTrackingConfiguration field on NetworkInfo.
* MediaConvert (4.0.15.0)
	* This update adds additional bitrate options for Dolby AC-4 audio outputs.
* SageMakerRuntimeHTTP2 (4.0.0.1)
	* Add support for SageMakerRuntimeHTTP2 bidirectional streaming. This is only supported in .NET8
* Core 4.0.3.19
	* Add DocumentJsonConverter to fix System.Text.Json serialization of Document types. Document's IEnumerable interfaces caused STJ to treat it as a collection, throwing InvalidDocumentTypeConversionException.
	* Add support for event headers for event stream based APIs used in services like SageMakerRuntimeHttp2.
	* All service and extension packages updated to require new Core

### 4.0.212.0 (2026-03-17 18:18 UTC)
* BedrockAgentCoreControl (4.0.21.0)
	* Deprecating namespaces field and adding namespaceTemplates.
* ElasticMapReduce (4.0.8.0)
	* Add S3LoggingConfiguration to Control LogUploads
* Glue (4.0.27.0)
	* Provide approval to overwrite existing Lake Formation permissions on all child resources with the default permissions specified in 'CreateTableDefaultPermissions' and 'CreateDatabaseDefaultPermissions' when updating catalog. Allowed values are ["Accept","Deny"] .

### 4.0.211.1 (2026-03-16 21:26 UTC)
* Extensions.Bedrock.MEAI (4.0.6.1)
	* Revert: Update `IChatClient` with latest `BedrockRuntime` / M.E.AI (adding support for multi-modal tool returns and citations with URIs)

### 4.0.211.0 (2026-03-16 18:24 UTC)
* Bedrock (4.0.23.0)
	* You can now generate policy scenarios on demand using the new GENERATE POLICY SCENARIOS build workflow type. Scenarios will no longer be automatically generated during INGEST CONTENT, REFINE POLICY, and IMPORT POLICY workflows, resulting in faster completion times for these operations.
* BedrockAgentCore (4.0.12.0)
	* Provide support to perform deterministic operations on agent runtime through shell command executions via the new InvokeAgentRuntimeCommand API
* BedrockAgentCoreControl (4.0.20.0)
	* Supporting hosting of public ECR Container Images in AgentCore Runtime
* ECS (4.0.15.0)
	* Amazon ECS now supports configuring whether tags are propagated to the EC2 Instance Metadata Service (IMDS) for instances launched by the Managed Instances capacity provider. This gives customers control over tag visibility in IMDS when using ECS Managed Instances.
* Extensions.Bedrock.MEAI (4.0.6.0)
	* Update `IChatClient` with latest `BedrockRuntime` / M.E.AI (adding support for multi-modal tool returns and citations with URIs)

### 4.0.210.0 (2026-03-13 18:18 UTC)
* APIGateway (4.0.6.0)
	* API Gateway now supports an additional security policy "SecurityPolicy-TLS13-1-2-FIPS-PFS-PQ-2025-09" for REST APIs and custom domain names. The new policy is compliant with TLS 1.3, Federal Information Processing Standards (FIPS), Perfect Forward Secrecy (PFS), and post-quantum (PQ) cryptography
* ConfigService (4.0.7.0)
	* Fix pagination support for DescribeConformancePackCompliance, and update OrganizationConfigRule InputParameters max length to match ConfigRule.
* Connect (4.0.37.0)
	* Deprecating PredefinedNotificationID field
* GameLiftStreams (4.0.7.0)
	* Feature launch that enables customers to connect streaming sessions to their own VPCs running in AWS.
* Glue (4.0.26.0)
	* Add QuerySessionContext to BatchGetPartitionRequest
* IVSRealTime (4.0.6.0)
	* Updates maximum reconnect window seconds from 60 to 300 for participant replication
* MediaConvert (4.0.14.0)
	* This update adds support for Dolby AC-4 audio output, frame rate conversion between non-Dolby Vision inputs to Dolby Vision outputs, and clear lead CMAF HLS output.
* MediaLive (4.0.17.3)
	* Documents the VideoDescription.ScalingBehavior.SMART(underscore)CROP enum value.
* Mgn (4.0.5.0)
	* Network Migration APIs are now publicly available for direct programmatic access. Customers can now call Network Migration APIs directly without going through AWS Transform (ATX), enabling automation, integration with existing tools, and self-service migration workflows.
* QuickSight (4.0.17.0)
	* The change adds a new capability named ManageSharedFolders in Custom Permissions
* Core 4.0.3.18
	* Update InstanceProfileAWSCredentials to fix flaky test (no change in functionality for existing customers)

### 4.0.209.0 (2026-03-12 18:24 UTC)
* DataSync (4.0.9.0)
	* DataSync's 3 location types, Hadoop Distributed File System (HDFS), FSx for Windows File Server (FSx Windows), and FSx for NetApp ONTAP (FSx ONTAP) now have credentials managed via Secrets Manager, which may be encrypted with service keys or be configured to use customer-managed keys or secret.
* ECR (4.0.12.0)
	* Add Chainguard to PTC upstreamRegistry enum
* S3 (4.0.19.0)
	* Adds support for account regional namespaces for general purpose buckets. The account regional namespace is a reserved subdivision of the global bucket namespace where only your account can create general purpose buckets.
* Core 4.0.3.17
	* Fix XmlUnmarshallerContext to handle unexpected HTML response (https://github.com/aws/aws-sdk-net/issues/4346)
	* All service and extension packages updated to require new Core

### 4.0.208.0 (2026-03-11 18:42 UTC)
* CustomerProfiles (4.0.9.0)
	* Today, Amazon Connect is announcing the ability to filter (include or exclude) recommendations based on properties of items and interactions.
* EKS (4.0.14.0)
	* Adds support for a new tier in controlPlaneScalingConfig on EKS Clusters.
* Polly (4.0.4.0)
	* Added support for the new voices - Ambre (fr-FR), Beatrice (it-IT), Florian (fr-FR), Lennart (de-DE), Lorenzo (it-IT) and Tiffany (en-US). They are available as a Generative voices only.
* SageMaker (4.0.46.0)
	* SageMaker training plans allow you to extend your existing training plans to avoid workload interruptions without workload reconfiguration. When a training plan is approaching expiration, you can extend it directly through the SageMaker AI console or programmatically using the API or AWS CLI.
* SimpleDBv2 (4.0.0.0)
	* Introduced Amazon SimpleDB export functionality enabling domain data export to S3 in JSON format. Added three new APIs StartDomainExport, GetExport, and ListExports via SimpleDBv2 service. Supports cross-region exports and KMS encryption.
* WorkSpaces (4.0.10.0)
	* Added WINDOWS SERVER 2025 OperatingSystemName.

### 4.0.207.0 (2026-03-10 18:16 UTC)
* BedrockAgentCoreControl (4.0.19.0)
	* Adding first class support for AG-UI protocol in AgentCore Runtime.
* ConnectCases (4.0.11.0)
	* Added functionality for the Required and Hidden case rule types to be conditionally evaluated on up to 5 conditions.
* DatabaseMigrationService (4.0.7.12)
	* Not need to include to any release notes. The only change is to correct LoadTimeout unit from milliseconds to seconds in RedshiftSettings
* Kafka (4.0.7.0)
	* Add dual stack endpoint to SDK
* LexModelsV2 (4.0.6.0)
	* This release introduces a new generative AI feature called Lex Bot Analyzer. This feature leverage AI to analyze the bot configuration against AWS Lex best practices to identify configuration issues and provides recommendations.

### 4.0.206.0 (2026-03-09 18:30 UTC)
* IdentityManagement (4.0.9.9)
	* Added support for CloudWatch Logs long-term API keys, currently available in Preview
* Mgn (4.0.4.0)
	* Adds support for new storeSnapshotOnLocalZone field in ReplicationConfiguration and updateReplicationConfiguration
* OpenSearchService (4.0.12.0)
	* This change enables cross-account and cross-region access for DataSources. Customers can now define access policies on their datasources to allow other AWS accounts to access and query their data.
* Route53GlobalResolver (4.0.1.0)
	* Adds support for dual stack Global Resolvers and Dictionary-based Domain Generation Firewall Advanced Protection.
* Core 4.0.3.16
	* Enable deterministic builds and embed untracked sources in NuGet packages (https://github.com/aws/aws-sdk-net/pull/4337)
	* Set request.Content in AWSQuery marshallers to avoid redundant parameter serialization (Fix: https://github.com/aws/aws-sdk-net/issues/1922).
	* All service and extension packages updated to require new Core

### 4.0.205.0 (2026-03-06 21:45 UTC)
* AppIntegrationsService (4.0.5.0)
	* This release adds support for webhooks, allowing customers to create an Event Integration with a webhook source.
* BCMDataExports (4.0.2.0)
	* Fixed wrong endpoint resolutions in few regions. Added AWS CFN resource schema for BCM Data Exports. Added max value validation for pagination parameter. Fixed ARN format validation for BCM Data Exports resources. Updated size constraints for table properties. Added AccessDeniedException error.
* Bedrock (4.0.22.0)
	* Amazon Bedrock Guardrails account-level enforcement APIs now support lists for model inclusion and exclusion from guardrail enforcement.
* BedrockAgentCoreControl (4.0.18.0)
	* Adds support for streaming memory records in AgentCore Memory
* Connect (4.0.36.0)
	* Amazon Connect now supports the ability to programmatically configure and run automated tests for contact center experiences for Chat. Integrate testing into CICD pipelines, run multiple tests at scale, and retrieve results via API to automate validation of chat interactions and workflows.
* Deadline (4.0.14.0)
	* AWS Deadline Cloud now supports cost scale factors for farms, enabling studios to adjust reported costs to reflect their actual rendering economics. Adjusted costs are reflected in Deadline Cloud's Usage Explorer and Budgets.
* GameLiftStreams (4.0.6.0)
	* Added new Gen6 stream classes based on the EC2 G6f instance family. These stream classes provide cost-optimized options for streaming well-optimized or lower-fidelity games on Windows environments.
* SimpleEmailV2 (4.0.12.0)
	* Adds support for longer email message header values, increasing the maximum length from 870 to 995 characters for RFC 5322 compliance.

### 4.0.204.0 (2026-03-05 21:02 UTC)
* ConnectHealth (4.0.0.0)
	* Connect-Health SDK is AWS's unified SDK for the Amazon Connect Health offering. It allows healthcare developers to integrate purpose-built agents - such as patient insights, ambient documentation, and medical coding - into their existing applications, including EHRs, telehealth, and revenue cycle.
* EC2 (4.0.80.0)
	* Added metadata field to CapacityAllocation.
* GuardDuty (4.0.17.0)
	* Added MALICIOUS FILE to IndicatorType enum in MDC Sequence
* MPA (4.0.4.0)
	* Updates to multi-party approval (MPA) service to add support for approval team baseline operations.
* SageMaker (4.0.45.0)
	* Adds support for S3 Bucket Ownership validation for SageMaker Managed MLflow.
* SavingsPlans (4.0.5.0)
	* Added support for OpenSearch and Neptune Analytics to Database Savings Plans.

### 4.0.203.0 (2026-03-04 19:19 UTC)
* Connect (4.0.35.0)
	* Added support for configuring additional email addresses on queues in Amazon Connect. Agents can now select an outbound email address and associate additional email addresses for replying to or initiating emails.
* ElasticBeanstalk (4.0.3.0)
	* As part of this release, Beanstalk introduce a new info type - analyze for request environment info and retrieve environment info operations. When customers request an Al analysis, Elastic Beanstalk runs a script on an instance in their environment and returns an analysis of events, health and logs.
* Elasticsearch (4.0.4.0)
	* Adds support for DeploymentStrategyOptions.
* GameLift (4.0.7.0)
	* Amazon GameLift Servers now offers DDoS protection for Linux-based EC2 and Container Fleets on SDKv5. The player gateway proxy relay network provides traffic validation, per-player rate limiting, and game server IP address obfuscation all with negligible added latency and no additional cost.
* OpenSearchService (4.0.11.0)
	* Adding support for DeploymentStrategyOptions
* QuickSight (4.0.16.0)
	* Added several new values for Capabilities, increased visual limit per sheet from previous limit to 75, renamed Quick Suite to Quick in several places.

### 4.0.202.0 (2026-03-03 20:07 UTC)
* BedrockAgentCoreControl (4.0.17.0)
	* Support for AgentCore Policy GA
* CloudWatchLogs (4.0.15.0)
	* CloudWatch Logs updates- Added support for the PutBearerTokenAuthentication API to enable or disable bearer token authentication on a log group. For more information, see CloudWatch Logs API documentation.
* DataZone (4.0.22.0)
	* Adding QueryGraph operation to DataZone SDK
* PartnerCentralChannel (4.0.1.0)
	* Adds the Resold Unified Operations support plan and removes the Resold Business support plan in the CreateRelationship and UpdateRelationship APIs
* SageMaker (4.0.44.0)
	* This release adds b300 and g7e instance types for SageMaker inference endpoints.

### 4.0.201.0 (2026-02-27 19:15 UTC)
* ARCRegionswitch (4.0.5.0)
	* Post-Recovery Workflows enable customers to maintain comprehensive disaster recovery automation. This allows customer SREs and leadership to have complete recovery orchestration from failover through post-recovery preparation, ensuring Regions remain ready for subsequent recovery events.
* AWSHealth (4.0.5.0)
	* Updates the regex for validating availabilityZone strings used in the describe events filters.
* Batch (4.0.6.0)
	* This feature allows customers to specify the minimum time (in minutes) that AWS Batch keeps instances running in a compute environment after all jobs on the instance complete
* Bedrock (4.0.21.0)
	* Added four new model lifecycle date fields, startOfLifeTime, endOfLifeTime, legacyTime, and publicExtendedAccessTime. Adds support for using the Converse API with Bedrock Batch inference jobs.
* CognitoIdentityProvider (4.0.6.0)
	* Cognito is introducing a two-secret rotation model for app clients, enabling seamless credential rotation without downtime. Dedicated APIs support passing in a custom secret. Custom secrets need to be at least 24 characters. This eliminates reconfiguration needs and reduces security risks.
* Connect (4.0.34.0)
	* Deprecate EvaluationReviewMetadata's CreatedBy and CreatedTime, add EvaluationReviewMetadata's RequestedBy and RequestedTime
* CustomerProfiles (4.0.8.0)
	* This release introduces an optional SourcePriority parameter to the ProfileObjectType APIs, allowing you to control the precedence of object types when ingesting data from multiple sources. Additionally, WebAnalytics and Device have been added as new StandardIdentifier values.
* KeyspacesStreams (4.0.3.0)
	* Added support for Change Data Capture (CDC) streams with Duration DataType.
* Odb (4.0.5.0)
	* ODB Networking Route Management is a feature improvement which allows for implicit creation and deletion of EC2 Routes in the Peer Network Route Table designated by the customer via new optional input. This feature release is combined with Multiple App-VPC functionality for ODB Network Peering(s).
* RAM (4.0.4.0)
	* Resource owners can now specify ResourceShareConfiguration request parameter for CreateResourceShare API including RetainSharingOnAccountLeaveOrganization boolean parameter
* TranscribeStreaming (4.0.6.0)
	* AWS Transcribe Streaming now supports specifying a resumption window for the stream through the SessionResumeWindow parameter, allowing customers to reconnect to their streams for a longer duration beyond stream start time.

### 4.0.200.0 (2026-02-26 19:15 UTC)
* AWSMarketplaceMetering (4.0.4.0)
	* Added LicenseArn to ResolveCustomer response and BatchMeterUsage usage records. BatchMeterUsage now accepts LicenseArn in each UsageRecord to report usage at the license level. Added InvalidLicenseException error response for invalid license parameters.
* BackupGateway (4.0.3.0)
	* This release updates GetGateway API to include deprecationDate and softwareVersion in the response, enabling customers to track gateway software versions and upcoming deprecation dates.
* EC2 (4.0.79.0)
	* Add c8id, m8id and hpc8a instance types.
* ECS (4.0.14.0)
	* Adding support for Capacity Reservations for ECS Managed Instances by introducing a new "capacityOptionType" value of "RESERVED" and new field "capacityReservations" for CreateCapacityProvider and UpdateCapacityProvider APIs.
* MarketplaceEntitlementService (4.0.4.0)
	* Added License Arn as a new optional filter for GetEntitlements and LicenseArn field in each entitlement in the response.
* SecurityHub (4.0.8.0)
	* Security Hub added EXTENDED PLAN integration type to DescribeProductsV2 and added metadata.product.vendor name GroupBy support to GetFindingStatisticsV2

### 4.0.199.0 (2026-02-25 21:00 UTC)
* Batch (4.0.5.2)
	* AWS Batch documentation update for service job capacity units.
* EC2 (4.0.78.0)
	* Add support for EC2 Capacity Blocks in Local Zones.
* ECR (4.0.11.0)
	* Update repository name regex to comply with OCI Distribution Specification
* Neptune (4.0.5.0)
	* Neptune global clusters now supports tags
* WAFV2 (4.0.8.0)
	* AWS WAF now supports GetTopPathStatisticsByTraffic that provides aggregated statistics on the top URI paths accessed by bot traffic. Use this operation to see which paths receive the most bot traffic, identify the specific bots accessing them, and filter by category, organization, or bot name.
* Extensions.CloudFront.Signers (4.0.0.26)
	* Fixed JSON injection vulnerability in Cloudfront signed URL and cookie policy generation

### 4.0.198.0 (2026-02-24 19:17 UTC)
* CloudWatch (4.0.8.0)
	* This release adds the APIs (PutAlarmMuteRule, ListAlarmMuteRules, GetAlarmMuteRule and DeleteAlarmMuteRule) to manage a new Cloudwatch resource, AlarmMuteRules. AlarmMuteRules allow customers to temporarily mute alarm notifications during expected downtime periods.
* EC2 (4.0.77.0)
	* Adds httpTokensEnforced property to ModifyInstanceMetadataDefaults API. Set per account or manage organization-wide using declarative policies to prevent IMDSv1-enabled instance launch and block attempts to enable IMDSv1 on existing IMDSv2-only instances.
* Elasticsearch (4.0.3.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* ElementalInference (4.0.0.0)
	* Initial GA launch for AWS Elemental Inference including capabilities of Smart Crop and Live Event Clipping
* MediaLive (4.0.17.0)
	* AWS Elemental MediaLive - Added support for Elemental Inference for Smart Cropping and Clipping features for MediaLive.
* ObservabilityAdmin (4.0.6.0)
	* Adding a new field in the CreateCentralizationRuleForOrganization, UpdateCentralizationRuleForOrganization API and updating the GetCentralizationRuleForOrganization API response to include the new field
* OpenSearchService (4.0.10.0)
	* Fixed HTTP binding for DescribeDomainAutoTunes API to correctly pass request parameters as query parameters in the HTTP request.
* PartnerCentralSelling (4.0.9.0)
	* Added support for filtering opportunities by target close date in the ListOpportunities API. You can now filter results to return opportunities with a target close date before or after a specified date, enabling more precise opportunity searches based on expected closure timelines.

### 4.0.197.0 (2026-02-23 19:15 UTC)
* Bedrock (4.0.20.0)
	* Automated Reasoning checks in Amazon Bedrock Guardrails now support fidelity report generation. The new workflow type assesses policy coverage and accuracy against customer documents. The GetAutomatedReasoningPolicyBuildWorkflowResultAssets API adds support for the three new asset types.
* ConnectCases (4.0.10.0)
	* SearchCases API can now accept 25 fields in the request and response as opposed to the previous limit of 10. DeleteField's hard limit of 100 fields per domain has been lifted.
* ControlCatalog (4.0.4.11)
	* Updated ExemptedPrincipalArns parameter documentation for improved accuracy
* DataZone (4.0.21.0)
	* Add workflow properties support to connections APIs
* DynamoDBv2 (4.0.15.0)
	* This change supports the creation of multi-account global tables. It adds one new arguments to UpdateTable, GlobalTableSettingsReplicationMode.
* MediaTailor (4.0.6.0)
	* Updated endpoint rule set for dualstack endpoints. Added a new opt-in option to log raw ad decision server requests for Playback Configurations.
* QuickSight (4.0.15.0)
	* Adds support for SEMISTRUCT to InputColumn Type
* Wickr (4.0.1.0)
	* AWS Wickr now provides APIs to manage your Wickr OpenTDF integration. These APIs enable you to test and save your OpenTDF configuration allowing you to manage rooms based on Trusted Data Format attributes.
* Core 4.0.3.15
	* Optimize MemoryStream Base64 serialization in JSON marshallers (Fix: https://github.com/aws/aws-sdk-net/issues/1922).
	* All service and extension packages updated to require new Core

### 4.0.196.0 (2026-02-20 20:48 UTC)
* AppStream (4.0.6.0)
	* Adding new attribute to disable IMDS v1 APIs for fleet, Image Builder and AppBlockBuilder instances.
* DynamoDBv2 (4.0.14.1)
	* Fix regression in V4 where `Scan` operation could not be invoked with a `FilterExpression` (https://github.com/aws/aws-sdk-net/issues/4324)
* ECS (4.0.13.0)
	* Migrated to Smithy. No functional changes
* SageMakerRuntime (4.0.2.0)
	* Added support for S3OutputPathExtension and Filename parameters to the InvokeEndpointAsync API to allow users to customize the S3 output path and file name for async inference response payloads.
* SignerData (4.0.0.0)
	* This release introduces AWS Signer Data Plane SDK client supporting GetRevocationStatus API. The new client enables AWS PrivateLink connectivity with both private DNS and VPC endpoint URLs.
* SimpleSystemsManagement (4.0.7.0)
	* Add support for AssociationDispatchAssumeRole in AWS SSM State Manager.
* TrustedAdvisor (4.0.3.0)
	* Adding a new enum attribute(statusReason) to TrustedAdvisorAPI response. This attribute explains reasoning behind check status for certain specific scenarios.

### 4.0.195.0 (2026-02-19 19:31 UTC)
* BCMDashboards (4.0.2.0)
	* The Billing and Cost Management GetDashboard API now returns identifier for each widget, enabling users to uniquely identify widgets within their dashboards.
* ECR (4.0.10.0)
	* Adds multiple artifact types filter support in ListImageReferrers API.
* PcaConnectorScep (4.0.3.0)
	* AWS Private CA Connector for SCEP now supports AWS PrivateLink, allowing your clients to request certificates from within your Amazon Virtual Private Cloud (VPC) without traversing the public internet. With this launch, you can create VPC endpoints to connect to your SCEP connector privately.

### 4.0.194.0 (2026-02-18 19:27 UTC)
* CleanRooms (4.0.15.0)
	* This release adds support for federated catalogs in Athena-sourced configured tables.
* CloudWatchEvidently (Removed)
	* Amazon CloudWatch Evidently has been removed from the SDK because it has been discontinued.
* Connect (4.0.33.1)
	* Correcting in-app notifications API documentation.
* IoTAnalytics (Removed)
	* Amazon IoT Analytics has been removed from the SDK because it has been discontinued.

### 4.0.193.0 (2026-02-17 19:55 UTC)
* EC2 (4.0.76.0)
	* Add Operator field to CreatePlacementGroup and DescribePlacementGroup APIs.
* ManagedGrafana (4.0.3.0)
	* This release updates Amazon Managed Grafana's APIs to support customer managed KMS keys.
* RDS (4.0.18.0)
	* Adds support for the StorageEncryptionType field to specify encryption type for DB clusters, DB instances, snapshots, automated backups, and global clusters.
* WorkSpacesWeb (4.0.8.0)
	* Adds support for branding customization without requiring a custom wallpaper.

### 4.0.192.0 (2026-02-16 19:35 UTC)
* ARCRegionswitch (4.0.4.1)
	* Clarify documentation on ARC Region Switch start-plan-execution operation
* EC2 (4.0.75.1)
	* Documentation updates for EC2 Secondary Networks
* ECR (4.0.9.6)
	* Adds support for enabling blob mounting, and removes support for Clair based image scanning
* Kafka (4.0.6.0)
	* Amazon MSK now supports dual-stack connectivity (IPv4 and IPv6) for existing MSK clusters. You can enable dual-stack on existing clusters by specifying the NetworkType parameter in updateConnectivity API.
* KeyManagementService (4.0.9.0)
	* Added support for Decrypt and ReEncrypt API's to use dry run feature without ciphertext for authorization validation
* QConnect (4.0.8.0)
	* Update MessageType enum to include missing types.

### 4.0.191.0 (2026-02-13 19:18 UTC)
* CloudWatch (4.0.7.0)
	* Adding new evaluation states that provides information about the alarm evaluation process. Evaluation error Indicates configuration errors in alarm setup that require review and correction. Evaluation failure Indicates temporary CloudWatch issues.
* Connect (4.0.33.0)
	* API release for headerr notifications in the admin website. APIs allow customers to publish brief messages (including URLs) to a specified audience, and a new header icon will indicate when unread messages are available.
* EC2 (4.0.75.0)
	* This release adds geography information to EC2 region and availability zone APIs. DescribeRegions now includes a Geography field, while DescribeAvailabilityZones includes both Geography and SubGeography fields, enabling better geographic classification for AWS regions and zones.
* Inspector2 (4.0.9.0)
	* Added .Net 10 (dotnet10) and Node 24.x (node24.x) runtime support for lambda package scanning
* S3 (4.0.18.6)
	* Fix AmazonS3Uri class to correctly handle UTF-8 encoded characters
* SageMaker (4.0.43.0)
	* Enable g7e instance type support for SageMaker Processing, and enable single file configuration provisioning for HyperPod Slurm, where customers have the option to use HyperPod API to provide the provisioning parameters.

### 4.0.190.0 (2026-02-12 19:17 UTC)
* EC2 (4.0.74.0)
	* Launching nested virtualization. This feature allows you to run nested VMs inside virtual (non-bare metal) EC2 instances.

### 4.0.189.0 (2026-02-11 19:38 UTC)
* Batch (4.0.5.0)
	* Add support for listing jobs by share identifier and getting snapshots of active capacity utilization by job queue and share.
* EC2 (4.0.73.0)
	* R8i instances powered by custom Intel Xeon 6 processors available only on AWS with sustained all-core 3.9 GHz turbo frequency
* EKS (4.0.13.0)
	* This release adds support for Windows Server 2025 in Amazon EKS Managed Node Groups.
* KafkaConnect (4.0.5.0)
	* Support configurable upper limits on task count during autoscaling operations via maxAutoscalingTaskCount parameter.
* S3 (4.0.18.5)
	* Fix MPU in transfer utility for objects larger than 80GB
* S3Tables (4.0.9.0)
	* S3 Tables now supports setting partition specifications and sort orders on tables. Partition specs allow users to define how data is organized using transform functions. Sort order configurations enable users to specify sort directions and null ordering preferences for optimized data layout.
* Core 4.0.3.14
	* Update documentation for `MaxErrorRetry` to call out different default value for `DynamoDB`

### 4.0.188.0 (2026-02-10 19:23 UTC)
* BedrockAgentCore (4.0.11.0)
	* Added AgentCore browser proxy configuration support, allowing routing of browser traffic through HTTP and HTTPS proxy servers with authentication and bypass rules.
* Connect (4.0.32.0)
	* Amazon Connect now supports per-channel auto-accept and After Contact Work (ACW) timeouts. Configure agents with auto-accept and ACW timeout settings for chat, tasks, emails, and callbacks. Use the new UpdateUserConfig API to manage these settings.
* EKS (4.0.12.0)
	* Introducing an optional policy field, an IAM policy applied to pod identity associations in addition to IAM role policies. When specified, pod permissions are the intersection of IAM role policies and the policy field, ensuring the principle of least privilege.
* Kafka (4.0.5.0)
	* Amazon MSK adds three new APIs, CreateTopic, UpdateTopic, and DeleteTopic for managing Kafka topics in your MSK clusters.
* RDS (4.0.17.0)
	* This release adds backup configuration for RDS and Aurora restores, letting customers set backup retention period and preferred backup window during restore. It also enables viewing backup settings when describing snapshots or automated backups for instances and clusters.
* S3 (4.0.18.4)
	* Cleanup S3 code generation infrastructure after completing the S3 generation.
* Core 4.0.3.13
	* Add internal attribute to mark interfaces in `Core` that can be updated without backwards incompatibility issues

### 4.0.187.0 (2026-02-09 20:25 UTC)
* ConnectCampaignsV2 (4.0.6.0)
	* Add the missing event type for WhatsApp
* EC2 (4.0.72.0)
	* Amazon Secondary Networks is a networking feature that provides high-performance, low-latency connectivity for specialized workloads.
* EKS (4.0.11.0)
	* Amazon EKS adds a new DescribeUpdate update type, VendedLogsUpdate, to support an integration between EKS Auto Mode and Amazon CloudWatch Vended Logs.
* Imagebuilder (4.0.7.0)
	* EC2 Image Builder now supports wildcard patterns in lifecycle policies with recipes and enhances the experience of tag-scoped policies.
* LakeFormation (4.0.4.3)
	* Allow cross account v5 in put data lake settings
* Neptunedata (4.0.4.0)
	* Added edgeOnlyLoad boolean parameter to Neptune bulk load request. When TRUE, files are loaded in order without scanning. When FALSE (default), the loader scans files first, then loads vertex files before edge files automatically.
* PCS (4.0.12.0)
	* Introduces RESUMING state for clusters, compute node groups, and queues.
* Transfer (4.0.6.1)
	* This release adds a documentation update for MdnResponse of type "ASYNC"

### 4.0.186.0 (2026-02-06 19:18 UTC)
* BedrockDataAutomationRuntime (4.0.5.0)
	* Add OutputConfiguration to InvokeDataAutomation input and output to support S3 output
* Deadline (4.0.13.0)
	* Adds support for tagging jobs during job creation
* IoTManagedIntegrations (4.0.6.0)
	* Adding support for Custom(General) Authorization in managed integrations for AWS IoT Device Management cloud connectors.
* PartnerCentralSelling (4.0.8.0)
	* Releasing AWS Opportunity Snapshots for SDK release.
* S3 (4.0.18.3)
	* Generate S3 Enumerations.
* SageMaker (4.0.42.0)
	* Adding g7e instance support in Sagemaker Training

### 4.0.185.0 (2026-02-05 19:17 UTC)
* ARCRegionswitch (4.0.4.0)
	* Updates documentation for ARC Region switch and provides stronger validation for Amazon Aurora Global Database execution block parameters.
* Athena (4.0.4.0)
	* Reduces the minimum TargetDpus to create or update capacity reservations from 24 to 4.
* BedrockAgentCore (4.0.10.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* BedrockAgentCoreControl (4.0.16.0)
	* Support Browser profile persistence (cookies and local storage) across sessions for AgentCore Browser.
* Glue (4.0.25.0)
	* This release adds the capability to easily create custom AWS Glue connections to data sources with REST APIs.
* MediaLive (4.0.16.0)
	* Outputs using the AV1 codec in CMAF Ingest output groups in MediaLive now have the ability to specify a target bit depth of 8 or 10.
* NeptuneGraph (4.0.2.14)
	* Minor neptune-graph documentation changes
* RAM (4.0.3.0)
	* Added ListSourceAssociations API. Allows RAM resource share owners to list source associations that determine which sources can access resources through service principal associations. Supports filtering by resource share ARN, source ID, source type, or status, with pagination.
* Transfer (4.0.6.0)
	* Adds support for the customer to send custom HTTP headers and configure an AS2 Connector to receive Asynchronous MDNs from their trading partner
* WorkSpaces (4.0.9.0)
	* Added support for 12 new graphics-optimized compute types - Graphics.g6 (xlarge, 2xlarge, 4xlarge, 8xlarge, 16xlarge), Graphics.gr6 (4xlarge, 8xlarge), Graphics.g6f (large, xlarge, 2xlarge, 4xlarge), and Graphics.gr6f (4xlarge).

### 4.0.184.0 (2026-02-04 19:16 UTC)
* BedrockRuntime (4.0.16.0)
	* Added support for structured outputs to Converse and ConverseStream APIs.
* ConnectCases (4.0.9.0)
	* Amazon Connect Cases now supports larger, multi-line text fields with up to 4,100 characters. Administrators can use the Admin UI to select the appropriate configuration (single-line or multi-line) on a per-field basis, improving case documentation capabilities.
* EKS (4.0.10.4)
	* Update delete cluster description
* MediaLive (4.0.15.0)
	* AWS Elemental MediaLive now supports SRT listener mode for inputs and outputs, in addition to the existing SRT caller mode.
* Redshift (4.0.6.4)
	* We have increased the maximum duration for a deferred maintenance window from 45 days to 60 days for Amazon Redshift provisioned clusters. This enhancement provides customers with greater flexibility in scheduling patching and maintenance activities while also maintaining security compliance.
* WorkSpacesWeb (4.0.7.0)
	* Support for configuring and managing custom domain names for WorkSpaces Secure Browser portals.

### 4.0.183.0 (2026-02-03 19:25 UTC)
* Batch (4.0.4.0)
	* AWS Batch Array Job Visibility feature support. Includes new statusSummaryLastUpdatedAt for array job parent DescribeJobs responses for the last time the statusSummary was updated. Includes both statusSummary and statusSummaryLastUpdatedAt in ListJobs responses for array job parents.
* DynamoDBv2 (4.0.14.0)
	* This change supports the creation of multi-account global tables. It adds two new arguments to CreateTable, GlobalTableSourceArn and GlobalTableSettingsReplicationMode. DescribeTable is also updated to include information about GlobalTableSettingsReplicationMode.
* GeoMaps (4.0.4.0)
	* Added support for optional style parameters in maps, including 3D terrain and 3D Buildings
* Kinesis (4.0.8.0)
	* Adds StreamId parameter to AWS Kinesis Data Streams APIs that is reserved for future use.
* MarketplaceCatalog (4.0.5.0)
	* Adds support for Catalog API us-east-1 dualstack endpoint catalog-marketplace.us-east-1.api.aws
* Organizations (4.0.10.7)
	* Updated the CloseAccount description.
* S3 (4.0.18.2)
	* Generate PutBucketVersioning, GetBucketVersioning, and UpdateBucketMetadataInventoryTableConfiguration
* SSOAdmin (4.0.5.0)
	* Added new Region management APIs to support multi-Region replication in IAM Identity Center.

### 4.0.182.0 (2026-02-02 19:17 UTC)
* BedrockAgentCoreControl (4.0.15.0)
	* Adds tagging support for AgentCore Evaluations (evaluator and online evaluation config)
* CloudFront (4.0.12.0)
	* Add OriginMTLS support to CloudFront Distribution APIs
* MPA (4.0.3.0)
	* Updates to multi-party approval (MPA) service to add support for multi-factor authentication (MFA) for voting operations.

### 4.0.181.0 (2026-01-30 19:23 UTC)
* Connect (4.0.31.0)
	* This release adds Estimated Wait Time support to the GetContactMetrics API for Amazon Connect.
* DynamoDBv2 (4.0.13.0)
	* Add support for DynamoDbUpdateBehavior for operations.
* QuickSight (4.0.14.0)
	* Improve SessionTag usage guidelines in the GenerateEmbedURLForAnonymousUser API documentation. Update the GetIdentityContext document with the region support context.

### 4.0.180.0 (2026-01-29 19:38 UTC)
* EC2 (4.0.71.0)
	* G7e instances feature up to 8 NVIDIA RTX PRO 6000 Blackwell Server Edition GPUs with 768 GB of memory and 5th generation Intel Xeon Scalable processors. Supporting up to 192 vCPUs, 1600 Gbps networking bandwidth with EFA, up to 2 TiB of system memory, and up to 15.2 TB of local NVMe SSD storage.
* GameLift (4.0.6.0)
	* Amazon GameLift Servers now supports automatic scaling to and from zero instances based on game session activity. Fleets scale down to zero following a defined period of no game session activity and scale up from zero when game sessions are requested, providing an option for cost optimization.
* S3 (4.0.18.1)
	* Generate PutObject, GetObject, UploadPart, WriteGetObjectResponse, GetObjectTorrent.
	* [Breaking Change] WriteOffsetBytes on PutObjectRequest changed from int to int? to be consistent with the nullability changes in V4.
	* [Breaking Change] TagCount on GetObjectResponse changed from int to int? to be consistent with the nullability changes in V4.
	* SSEKMSKeyId, SSECustomerAlgorithm, SSECustomerKeyMD5 properties were added to UploadPartResponse.
	* Expires was added to both PutObjectRequest and InitiateMultipartUploadRequest.
* Core 4.0.3.12
	* Update `AssumeRoleAWSCredentials` and `AssumeRoleWithWebIdentityCredentials` to dynamically use a 5-minute preempt expiry if the requested role session duration is less than 20 minutes (to prevent the SDK from refreshing credentials unnecessarily) - https://github.com/aws/aws-sdk-net/issues/4313
	* All service and extension packages updated to require new Core

### 4.0.179.0 (2026-01-28 19:27 UTC)
* CognitoIdentityProvider (4.0.5.0)
	* This release adds support for a new lambda trigger to transform federated user attributes during the authentication with external identity providers on Cognito Managed Login.
* Connect (4.0.30.0)
	* Adds support for filtering search results based on tags assigned to contacts.
* DynamoDBv2 (4.0.12.0)
	* Add Request Object Pattern and Expression-Based for DynamoDB Document Model.
* EC2 (4.0.70.0)
	* SearchTransitGatewayRoutes API response now includes a NextToken field, enabling pagination when retrieving large sets of transit gateway routes. Pass the returned NextToken value in subsequent requests to retrieve the next page of results.
* Lambda (4.0.13.0)
	* We are launching ESM Metrics and logging for Kafka ESM to allow customers to monitor Kafka event processing using CloudWatch Metrics and Logs.
* MediaConnect (4.0.6.0)
	* This release adds support for NDI flow sources in AWS Elemental MediaConnect. You can now send content to your MediaConnect transport streams directly from your NDI environment using the new NDI source type. Also adds support for LARGE 4X flow size, which can be used when creating CDI JPEG-XS flows.
* MediaConvert (4.0.13.0)
	* This release adds a follow source mode for audio output channel count, an AES audio frame wrapping option for MXF outputs, and an option to signal DolbyVision compatibility using the SUPPLEMENTAL-CODECS tag in HLS manifests.
* S3 (4.0.18.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.
* S3Control (4.0.9.0)
	* Adds support for the UpdateObjectEncryption API to change the server-side encryption type of objects in general purpose buckets.

### 4.0.178.0 (2026-01-27 19:24 UTC)
* Connect (4.0.29.0)
	* Added support for task attachments. The StartTaskContact API now accepts file attachments, enabling customers to include files (.csv, .doc, .docx, .heic, .jfif, .jpeg, .jpg, .mov, .mp4, .pdf, .png, .ppt, .pptx, .rtf, .txt, etc.) when creating Task contacts. Supports up to 5 attachments per task.
* Deadline (4.0.12.0)
	* AWS Deadline Cloud now supports editing job names and descriptions after submission.
* EC2 (4.0.69.0)
	* Releasing new EC2 instances. C8gb and M8gb with highest EBS performance, M8gn with 600 Gbps network bandwidth, X8aedz and M8azn with 5GHz AMD processors, X8i with Intel Xeon 6 processors and up to 6TB memory, and Mac-m4max with Apple M4 Max chip for 25 percent faster builds.
* MediaLive (4.0.14.0)
	* AWS Elemental MediaLive released two new features that allows customers 1) to set Output Timecode for AV1 encoder, 2) to set a Custom Epoch for CMAF Ingest and MediaPackage V2 output groups when using Pipeline Locking or Disabled Locking modes.
* SageMaker (4.0.41.0)
	* Idle resource sharing enables teams to borrow unused compute resources in your SageMaker HyperPod cluster. This capability maximizes resource utilization by allowing teams to borrow idle compute capacity beyond their allocated compute quotas.
* Extensions.Bedrock.MEAI (4.0.5.6)
	* Fixed AOT compilation issue where Dictionary<string, object?> type was not registered in BedrockJsonContext, causing GetTypeInfo lookups to fail at runtime.

### 4.0.177.0 (2026-01-26 19:40 UTC)
* CloudWatchEvidently (4.0.3.0)
	* Deprecate all Evidently API for AWS CloudWatch Evidently deprecation
* ConnectCases (4.0.8.0)
	* Amazon Connect now enables you to use tag-based access controls to define who can access specific cases. You can associate tags with case templates and configure security profiles to determine which users can access cases with those tags.
* EC2 (4.0.68.0)
	* DescribeInstanceTypes API response now includes an additionalFlexibleNetworkInterfaces field, the number of interfaces attachable to an instance when using flexible Elastic Network Adapter (ENA) queues in addition to the base number specified by maximumNetworkInterfaces.
* GroundStation (4.0.3.0)
	* Adds support for AWS Ground Station Telemetry.
* Core 4.0.3.11
	* Remove `InternalsVisibleTo` reference to renamed project in `AssemblyInfo` file

### 4.0.176.0 (2026-01-23 19:25 UTC)
* Connect (4.0.28.0)
	* Amazon Connect now offers public APIs to programmatically configure and run automated tests for contact center experiences. Integrate testing into CICD pipelines, run multiple tests at scale, and retrieve results via API to automate validation of voice interactions and workflows.
* DataZone (4.0.20.0)
	* Added api for deleting data export configuration for a domain
* QConnect (4.0.7.0)
	* Fixes incorrect types in the UpdateAssistantAIAgent API request, adds MESSAGE to TargetType enum, and other minor changes.

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

