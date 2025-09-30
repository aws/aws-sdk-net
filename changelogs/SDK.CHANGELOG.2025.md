### 4.0.102.0 (2025-09-30 18:38 UTC)
* ApplicationSignals (4.0.2.0)
	* Amazon CloudWatch Application Signals is introducing the Application Map to give users a more comprehensive view of their service health. Users will now be able to group services, track their latest deployments, and view automated audit findings concerning service performance.
* BedrockAgentCoreControl (4.0.3.0)
	* Tagging support for AgentCore Gateway
* ChimeSDKVoice (4.0.2.0)
	* Added support for IPv4-only and dual-stack network configurations for VoiceConnector and CreateVoiceConnector API.
* ConnectCases (4.0.4.0)
	* This release adds support for two new related item types: ConnectCase for linking Amazon Connect cases and Custom for user-defined related items with configurable fields.
* CustomerProfiles (4.0.5.0)
	* This release introduces ListProfileHistoryRecords and GetProfileHistoryRecord APIs for comprehensive profile history tracking with complete audit trails of creation, updates, merges, deletions, and data ingestion events.
* DataSync (4.0.5.0)
	* Added support for FIPS VPC endpoints in FIPS-enabled AWS Regions.
* DataZone (4.0.10.0)
	* This release adds support for creation of EMR on EKS Connections in Amazon DataZone.
* DirectoryService (4.0.4.0)
	* AWS Directory service now supports IPv6-native and dual-stack configurations for AWS Managed Microsoft AD, AD Connector, and Simple AD (dual-stack only). Additionally, AWS Managed Microsoft AD Standard Edition directories can be upgraded to Enterprise Edition directories through a single API call.
* ECS (4.0.6.0)
	* This release adds support for Managed Instances on Amazon ECS.
* FSx (4.0.5.0)
	* Add Dual-Stack support for Amazon FSx for NetApp ONTAP and Windows File Server
* MediaTailor (4.0.3.0)
	* Adding TPS Traffic Shaping to Prefetch Schedules
* QuickSight (4.0.6.4)
	* added warnings to a few CLI pages
* RDS (4.0.10.0)
	* Enhanced RDS error handling: Added DBProxyEndpointNotFoundFault, DBShardGroupNotFoundFault, KMSKeyNotAccessibleFault for snapshots/restores/backups, NetworkTypeNotSupported, StorageTypeNotSupportedFault for restores, and granular state validation faults. Changed DBInstanceNotReadyFault to HTTP 400.
* Transfer (4.0.3.0)
	* Add support for updating server identity provider type
* Core 4.0.0.31
	* Update code generator to use fully qualified name for InvokeOptions to avoid name collisions
	* All services packages updated to require new Core

### 4.0.101.0 (2025-09-29 18:18 UTC)
* Bedrock (4.0.12.0)
	* Release for fixing GetFoundationModel API behavior. Imported and custom models have their own exclusive API and GetFM should not accept those ARNS as input
* BedrockRuntime (4.0.7.0)
	* New stop reason for Converse and ConverseStream
* Imagebuilder (4.0.3.0)
	* This release introduces several new features and improvements to enhance pipeline management, logging, and resource configuration.
* VPCLattice (4.0.2.0)
	* Adds support for specifying the number of IPv4 addresses in each ENI for the resource gateway for VPC Lattice.
* Core 4.0.0.30
	* Expand sso profile types to allow more combinations of credential profile options. It is valid to have a profile contain only the SsoSession option and point to an sso-session section.
	* All services packages updated to require new Core

### 4.0.100.0 (2025-09-26 18:36 UTC)
* BedrockAgentRuntime (4.0.6.0)
	* This release enhances the information provided through Flow Traces. New information includes source/next node tracking, execution chains for complex nodes, dependency action (operation) details, and dependency traces.
* BedrockDataAutomation (4.0.3.0)
	* Added support for configurable Speaker Labeling and Channel Labeling features for Audio modality.
* Billing (4.0.3.0)
	* Add ability to combine custom billing views to create new consolidated views.
* Connect (4.0.12.0)
	* Adds supports for manual contact picking (WorkList) operations on Routing Profiles, Agent Management and SearchContacts APIs.
* CostExplorer (4.0.5.0)
	* Support for payer account dimension and billing view health status.
* DynamoDBStreams (4.0.3.0)
	* Added support for IPv6 compatible endpoints for DynamoDB Streams.
* EC2 (4.0.40.1)
	* This release includes documentation updates for Amazon EBS General Purpose SSD (gp3) volumes with larger size and higher IOPS and throughput.
* Redshift (4.0.2.0)
	* Support tagging and tag propagation to IAM Identity Center for Redshift Idc Applications

### 4.0.99.0 (2025-09-25 18:20 UTC)
* Glue (4.0.17.0)
	* Update GetConnection(s) API to return KmsKeyArn & Add 63 missing connection types
* Lightsail (4.0.3.0)
	* Attribute HTTP binding update for Get/Delete operations
* NetworkFirewall (4.0.7.0)
	* Network Firewall now introduces Reject and Alert action support for stateful domain list rule groups, providing customers with more granular control over their network traffic.

### 4.0.98.0 (2025-09-24 18:25 UTC)
* AppStream (4.0.1.4)
	* G6f instance support for AppStream 2.0
* CloudWatch (4.0.4.0)
	* Fix default dualstack FIPS endpoints in AWS GovCloud(US) regions
* DAX (4.0.1.0)
	* This release adds support for IPv6-only, DUAL_STACK DAX instances
* KeyManagementService (4.0.4.4)
	* Documentation only updates for KMS.
* Neptune (4.0.3.3)
	* Doc-only update to address customer use.

### 4.0.97.0 (2025-09-23 18:23 UTC)
* CleanRooms (4.0.7.0)
	* Added support for running incremental ID mapping for rule-based workflows.
* EC2 (4.0.40.0)
	* Add Amazon EC2 R8gn instance types
* EntityResolution (4.0.4.0)
	* Support incremental id mapping workflow for AWS Entity Resolution
* SimpleSystemsManagement (4.0.4.0)
	* Added Dualstack support to GetDeployablePatchSnapshotForInstance
* SSOAdmin (4.0.3.0)
	* Add support for encryption at rest with Customer Managed KMS Key in AWS IAM Identity Center
* SSOOIDC (4.0.2.0)
	* This release includes exception definition and documentation updates.
* Extension Extensions.Bedrock.MEAI (4.0.3.2)
	* Updating AssemblyFileVersion.
* Extension Extensions.CborProtocol (4.0.0.3)
	* Updating AssemblyFileVersion.
* Extension Extensions.CloudFront.Signers (4.0.0.2)
	* Updating AssemblyFileVersion.
* Extension Extensions.CrtIntegration (4.0.0.2)
	* Updating AssemblyFileVersion.
* Extension Extensions.EC2.DecryptPassword (4.0.0.2)
	* Updating AssemblyFileVersion.
* Extension Extensions.NETCore.Setup (4.0.3.1)
	* Updating AssemblyFileVersion.
* Core 4.0.0.29
	* Skip adding extra empty chunk for empty streams in TrailingHeadersWrapperStream.
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 4.0.96.0 (2025-09-22 18:22 UTC)
* Batch (4.0.2.11)
	* Starting in JAN 2026, AWS Batch will change the default AMI for new Amazon ECS compute environments from Amazon Linux 2 to Amazon Linux 2023. We recommend migrating AWS Batch Amazon ECS compute environments to Amazon Linux 2023 to maintain optimal performance and security.
* EKS (4.0.6.0)
	* Adds support for RepairConfig overrides and configurations in EKS Managed Node Groups.
* Imagebuilder (4.0.2.0)
	* Version ARNs are no longer required for the EC2 Image Builder list-image-build-version, list-component-build-version, and list-workflow-build-version APIs. Calling these APIs without the ARN returns all build versions for the given resource type in the requesting account.
* S3 (4.0.7.3)
	* Fixed a bug where PutObject was failing when sending zero-byte InputStream with DisablePayloadSigning set to true.

### 4.0.95.0 (2025-09-19 18:45 UTC)
* BedrockAgentCoreControl (4.0.2.0)
	* Add tagging and VPC support to AgentCore Runtime, Code Interpreter, and Browser resources. Add support for configuring request headers in Runtime. Fix AgentCore Runtime shape names.
* ConfigService (4.0.3.0)
	* Add UNKNOWN state to RemediationExecutionState and add IN_PROGRESS/EXITED/UNKNOWN states to RemediationExecutionStepState.
* Connect (4.0.11.0)
	* This release adds a persistent connection field to UserPhoneConfig that maintains agent's softphone media connection for faster call connections.
* KendraRanking (4.0.0.23)
	* Model whitespace change - no client difference
* LicenseManagerUserSubscriptions (4.0.2.0)
	* Added support for cross-account Active Directories.
* MediaLive (4.0.6.0)
	* Add MinBitrate for QVBR mode under H264/H265/AV1 output codec. Add GopBReference, GopNumBFrames, SubGopLength fields under H265 output codec.
* SQS (4.0.1.4)
	* Update invalid character handling documentation for SQS SendMessage API

### 4.0.94.0 (2025-09-18 18:27 UTC)
* Bedrock (4.0.11.0)
	* Release includes an increase to the maximum policy build document size, an update to DeleteAutomatedReasoningPolicyBuildWorkflow to add ResourceInUseException, and corrections to UpdateAutomatedReasoningPolicyTestCaseRequest.
* Budgets (4.0.5.0)
	* Added BillingViewHealthStatus Exception which is thrown when a Budget is created or updated with a Billing View that is not in the HEALTHY status
* ChimeSDKMessaging (4.0.1.0)
	* Amazon Chime SDK Messaging GetMessagingSessionEndpoint API now returns dual-stack WebSocket endpoints supporting IPv4/IPv6.
* EC2 (4.0.39.0)
	* Allowed AMIs adds support for four new parameters - marketplaceProductCodes, deprecationTimeCondition, creationDateCondition and imageNames

### 4.0.93.0 (2025-09-17 18:36 UTC)
* EC2 (4.0.38.0)
	* Add mac-m4.metal and mac-m4pro.metal instance types.
* NetworkFirewall (4.0.6.0)
	* Network Firewall now prevents TLS handshakes with the target server until after the Server Name Indication (SNI) has been seen and verified. The monitoring dashboard now provides deeper insights into PrivateLink endpoint candidates and offers filters based on IP addresses and protocol.
* PCS (4.0.8.0)
	* Add support for Amazon EC2 Capacity Blocks for ML

### 4.0.92.0 (2025-09-16 18:29 UTC)
* Budgets (4.0.4.0)
	* Add support for custom time periods in budget configuration
* CloudWatchLogs (4.0.8.0)
	* Cloudwatch Logs added support for 2 new API parameters in metric and subscription filter APIs to filter log events based on system field values and emit system field values as dimensions and send them to customer destination as additional metadata.
* IVSRealTime (4.0.3.0)
	* IVS now offers customers the ability to control the positioning of participants in both grid and PiP layouts based on custom attribute values in participant tokens.
* OSIS (4.0.3.0)
	* Adds support for cross-account ingestion for push-based sources. This includes resource policies for sharing pipelines across accounts and features for managing pipeline endpoints which enable accessing pipelines across different VPCs, including VPCs in other accounts.
* Core 4.0.0.28
	* Fix: Update SSO credential profile type to include smaller subset of CredentialProfileOptions for token auth services which do not use accountId or SsoRoleName.
	* All services packages updated to require new Core

### 4.0.91.0 (2025-09-15 18:39 UTC)
* CostExplorer (4.0.4.0)
	* Added endpoint support for eusc-de-east-1 region.
* MedicalImaging (4.0.3.0)
	* Added support for OpenID Connect (OIDC) custom authorizer
* ObservabilityAdmin (4.0.3.0)
	* CloudWatch Observability Admin adds the ability to enable telemetry centralization in customers' Organizations. The release introduces new APIs to manage centralization rules, which define settings to replicate telemetry data to a central destination in the customers' Organization.
* S3Control (4.0.6.0)
	* Introduce three new encryption filters: EncryptionType (SSE-S3, SSE-KMS, DSSE-KMS, SSE-C, NOT-SSE), KmsKeyArn (for SSE-KMS and DSSE-KMS), and BucketKeyEnabled (for SSE-KMS).
* ServerMigrationService (Removed)
	* AWS Server Migration Service has been removed from the SDK because it has been discontinued.

### 4.0.90.0 (2025-09-12 18:15 UTC)
* PaymentCryptography (4.0.4.0)
	* Add support for certificates to be signed by 3rd party certificate authorities.  New API GetCertificateSigningRequest API and support for providing certificates at run-time for tr-34 import/export
* S3 (4.0.7.1)
	* Fix NullReferenceException creating a presigned URL with a service url
* Core 4.0.0.27
	* Added support in AWSSDK.Extensions.NETCore.Setup package to set the MaxConnectionsPerServer property on service client config objects.

### 4.0.89.0 (2025-09-11 18:24 UTC)
* DataZone (4.0.9.0)
	* adding IAM principal id to IAM user profile details
* ECS (4.0.5.0)
	* This release supports hook details for Amazon ECS lifecycle hooks.
* EMRContainers (4.0.1.0)
	* Added nodeLabel support in container provider to aid hardware isolation support for virtual cluster and security configuration.
* Evs (4.0.3.0)
	* CreateEnvironment API now supports parameters (isHcxPublic & hcxNetworkAclId) for HCX migration via public internet, adding flexibility for migration scenarios. New APIs have been added for associating (AssociateEipToVlan) & disassociating (DisassociateEipFromVlan) Elastic IP (EIP) addresses.
* GuardDuty (4.0.7.0)
	* Updated Java SDK implementation of entity set status in GuardDuty API.
* MediaLive (4.0.5.0)
	* AWS Elemental MediaLive adds a new feature in MediaPackage output group that enables MediaPackage V2 users to control HLS-related parameters directly in MediaLive. These parameter settings are then reflected in MediaPackage outputs, providing more streamlined control over HLS configurations.
* PrometheusService (4.0.4.0)
	* Add Vended Logs APIs for Amazon Prometheus Managed Collector
* QuickSight (4.0.6.0)
	* This release adds support for Account level custom permissions, additional Dashboard Options, and Null support for Q&A.
* RDS (4.0.9.0)
	* Adds support for end-to-end IAM authentication in RDS Proxy for MySQL, MariaDB, and PostgreSQL engines.

### 4.0.88.0 (2025-09-10 18:15 UTC)
* NetworkFlowMonitor (4.0.4.0)
	* Added new enum value (AWS::Region) for type field under MonitorLocalResource and MonitorRemoteResource. Workload Insights and Monitor top contributors queries now support a new DestinationCategory (INTER_REGION).
* PaymentCryptography (4.0.3.0)
	* AWS Payment Cryptography Service now supports Multi-Region key replication. Customers can choose to automatically distribute keys across AWS Regions.

### 4.0.87.0 (2025-09-09 18:25 UTC)
* AutoScaling (4.0.3.0)
	* Added WaitForTransitioningInstances parameter to the CancelInstanceRefresh API, allowing the caller to cancel an instance refresh without waiting for on-going launches and terminations.
* CloudWatch (4.0.3.0)
	* Added a new API - DescribeAlarmContributors API, to retrieve alarm contributors in ALARM state. Added support in DescribeAlarmHistory API to query alarm contributor history
* Connect (4.0.10.0)
	* SDK release for user defined predefined attributes.
* DataZone (4.0.8.0)
	* Adds support for custom blueprints
* MediaPackageV2 (4.0.6.0)
	* Added CUE tag SCTE output to MediaPackageV2 HLS and LL-HLS manifests.
* Organizations (4.0.4.0)
	* Documentation updates for AWS Organizations APIs.
* SageMaker (4.0.25.0)
	* Released IPv6 support with dual-stack domain options on SageMaker Studio and introduced support for p6-b200.48xlarge instance type on SageMaker Studio for JupyterLab and CodeEditor applications.

### 4.0.86.0 (2025-09-08 18:49 UTC)
* IoTSiteWise (4.0.3.0)
	* Add ComputationModelVersion support in IoT SiteWise APIs
* S3 (4.0.7.0)
	* This release includes backward compatibility work on the "Expires" parameter.
* SecurityHub (4.0.4.0)
	* This release adds the RESOURCE_NOT_FOUND error code as a possible value in responses to the following operations: BatchGetStandardsControlAssociations, BatchUpdateStandardsControlAssociations, and BatchGetSecurityControls.

### 4.0.85.0 (2025-09-05 18:25 UTC)
* ECS (4.0.4.8)
	* This is a documentation only release that adds additional information for Amazon ECS Availability Zone rebalancing.
* PCS (4.0.7.2)
	* Documentation-only update to add AccountingStorageEnforce to SlurmCustomSetting.
* SageMaker (4.0.24.0)
	* Release IPv6 support with dualstack in SageMaker Notebooks, Tiered Storage Checkpointing Support in SageMaker HyperPod and P5.4xlarge instance type for SageMaker Hosting.

### 4.0.84.0 (2025-09-04 18:22 UTC)
* CleanRooms (4.0.6.0)
	* Add support for configurable compute sizes for PySpark jobs.
* CloudFormation (4.0.3.0)
	* ListHookResults API now supports retrieving invocation results for all CloudFormation Hooks (previously limited to create change set and Cloud Control operations) with new optional parameters for filtering by Hook status and ARN.
* EC2 (4.0.37.0)
	* Add m8i, m8i-flex and i8ge instance types.
* OpenSearchServerless (4.0.3.0)
	* Add support for Federal Information Processing Standards (FIPS) and Federal Risk and Authorization Management Program (FedRAMP) compliance
* RDS (4.0.8.0)
	* Added new EndpointNetworkType and TargetConnectionNetworkType fields in Proxy APIs to support IPv6
* VerifiedPermissions (4.0.3.0)
	* Amazon Verified Permissions / Features : Adds support for datetime and duration attribute values.

### 4.0.83.0 (2025-09-03 18:33 UTC)
* CleanRooms (4.0.5.0)
	* Added support for adding new data provider members to an existing collaboration.
* CleanRoomsML (4.0.4.0)
	* AWS Clean Rooms ML adds log sanitization for privacy-enhanced error summaries, supports new instance types for custom models providing better performance and lower costs, and deprecates P3-series instances.
* CloudFront (4.0.5.0)
	* Adding an optional field IpAddressType in CustomOriginConfig
* MQ (4.0.2.0)
	* Add CONFIG_MANAGED as a supported AuthenticationStrategy for Amazon MQ for RabbitMQ brokers. Make username and password optional on broker creation for CONFIG_MANAGED brokers.
* RDS (4.0.7.0)
	* This release adds support for MasterUserAuthenticationType parameter on CreateDBInstance, ModifyDBInstance, CreateDBCluster, and ModifyDBCluster operations.
* Route53 (4.0.4.0)
	* Amazon Route 53 now supports the Asia Pacific (New Zealand) Region (ap-southeast-6) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* Route53Domains (4.0.2.0)
	* Added new ExtraParams AU_ELIGIBILITY_TYPE, AU_POLICY_REASON, and AU_REGISTRANT_NAME
* TranscribeStreaming (4.0.3.0)
	* This release adds support for automatic language identification in AWS Transcribe Call Analytics

### 4.0.82.0 (2025-09-02 18:32 UTC)
* EC2 (4.0.36.0)
	* MaximumEbsAttachments and AttachmentLimitType fields added to DescribeInstanceTypesResponse. G6f, Gr6f, R8i, R8i-flex and p5.4xlarge instance types added to InstanceTypes enum.
* Neptune (4.0.3.0)
	* Removed the deprecated marker from publiclyAccessible parameter from DbInstance, CreateDbInstance and ModifyDbInstance and added relevant usage information for the parameter.
* Notifications (4.0.2.0)
	* Added Org support for notifications:  - `ListMemberAccounts` gets member accounts list, `AssociateOrganizationalUnit` links OU to notification configuration, `DisassociateOrganizationalUnit` removes OU from notification configuration, `ListOrganizationalUnits` shows OUs configured for notifications.
* S3 (4.0.6.13)
	* Fix issue #3993. PutObjectAcl was failing when Grantee's Type member was set because  the xml attribute not being written first leading to invalid xml. PutBucketAcl would also fail with the same issue if Type is set. This change writes the attributes first if they are present.
* WorkMail (4.0.2.0)
	* Make RoleArn an optional parameter for the PutEmailMonitoringConfiguration API, and add UnsupportedOperationException to RegisterToWorkMail.

### 4.0.81.1 (2025-08-29 21:31 UTC)
* S3 (4.0.6.12)
	* Fix issue #3989. If an empty filter was specified, GetLifecycleConfiguration was failing. This fix allows an empty filter to be specified when retrieving lifecycle configurations via GetLifecycleConfiguration.

### 4.0.81.0 (2025-08-29 18:19 UTC)
* BedrockRuntime (4.0.6.0)
	* Fixed stop sequence limit for converse API.
* EC2 (4.0.35.0)
	* Release shows new route types such as filtered and advertisement.
* S3 (4.0.6.11)
	* Remove unused custom partials
* XRay (4.0.2.0)
	* AWS X-Ray Features: Support Sampling Rate Boost On Anomaly
* Core 4.0.0.26
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 4.0.80.0 (2025-08-28 19:41 UTC)
* Amplify (4.0.2.0)
	* Remove incorrect endpoint tests
* ApplicationAutoScaling (4.0.1.0)
	* Remove incorrect endpoint tests
* ApplicationCostProfiler (4.0.1.0)
	* Remove incorrect endpoint tests
* AppRunner (4.0.1.1)
	* Doc only updates for APIs and and datatypes related to IPAddressType and Subnets for IPv6 dualstack support.
* AutoScalingPlans (4.0.1.0)
	* Remove incorrect endpoint tests
* BedrockRuntime (4.0.5.0)
	* Remove incorrect endpoint tests
* Cloud9 (4.0.1.0)
	* Remove incorrect endpoint tests
* CloudHSMV2 (4.0.1.0)
	* Remove incorrect endpoint tests
* CloudSearchDomain (4.0.1.0)
	* Remove incorrect endpoint tests
* CodeDeploy (4.0.1.0)
	* Remove incorrect endpoint tests
* CodeGuruReviewer (4.0.1.0)
	* Remove incorrect endpoint tests
* Connect (4.0.9.0)
	* AgentStatusDrillDown feature in GetCurrentMetricData API. Adding AGENT_STATUS as filter and grouping in GetCurrentMetricData API
* ConnectCampaignService (4.0.1.0)
	* Remove incorrect endpoint tests
* DynamoDBv2 (4.0.6.0)
	* Remove incorrect endpoint tests
* EC2 (4.0.34.0)
	* This release adds support for copying Amazon EBS snapshot and AMIs to and from Local Zones.
* EC2InstanceConnect (4.0.1.0)
	* Remove incorrect endpoint tests
* ECR (4.0.4.0)
	* Remove incorrect endpoint tests
* ElasticMapReduce (4.0.3.0)
	* Remove incorrect endpoint tests
* EntityResolution (4.0.3.0)
	* Remove incorrect endpoint tests
* EventBridge (4.0.4.0)
	* Remove incorrect endpoint tests
* FIS (4.0.1.0)
	* Remove incorrect endpoint tests
* FMS (4.0.1.0)
	* Remove incorrect endpoint tests
* GeoMaps (4.0.1.0)
	* Remove incorrect endpoint tests
* GeoPlaces (4.0.2.0)
	* Remove incorrect endpoint tests
* Glue (4.0.16.0)
	* Adding support to fetch TargetDatabase field during GetDatabases with AttributesToGet
* GlueDataBrew (4.0.1.0)
	* Remove incorrect endpoint tests
* HealthLake (4.0.2.0)
	* Add ValidationLevel parameter to StartFHIRImportJob API, allowing users to specify a FHIR validation level for their asynchronous import jobs.
* InspectorScan (4.0.1.0)
	* Remove incorrect endpoint tests
* InternetMonitor (4.0.1.0)
	* Remove incorrect endpoint tests
* Kinesis (4.0.4.0)
	* Remove incorrect endpoint tests
* LicenseManagerUserSubscriptions (4.0.1.0)
	* Remove incorrect endpoint tests
* MachineLearning (4.0.1.0)
	* Remove incorrect endpoint tests
* ManagedBlockchainQuery (4.0.1.0)
	* Remove incorrect endpoint tests
* MarketplaceDeployment (4.0.1.0)
	* Remove incorrect endpoint tests
* MediaStoreData (4.0.1.0)
	* Remove incorrect endpoint tests
* MTurk (4.0.1.0)
	* Remove incorrect endpoint tests
* NetworkFirewall (4.0.5.0)
	* Remove incorrect endpoint tests
* OAM (4.0.2.0)
	* Remove incorrect endpoint tests
* Omics (4.0.3.0)
	* Adds Amazon ECR pull through cache support to AWS HealthOmics, so you can more easily use container images from external sources.
* OpenSearchService (4.0.3.0)
	* Remove incorrect endpoint tests
* OSIS (4.0.2.0)
	* Remove incorrect endpoint tests
* PCS (4.0.7.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoice (4.0.1.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoiceV2 (4.0.3.0)
	* Remove incorrect endpoint tests
* Pipes (4.0.1.0)
	* Remove incorrect endpoint tests
* QuickSight (4.0.5.0)
	* Remove incorrect endpoint tests
* RDS (4.0.6.0)
	* Added RDS HTTP Endpoint feature support flag to DescribeOrderableDBInstanceOptions API
* Rekognition (4.0.2.0)
	* Remove incorrect endpoint tests
* Route53Domains (4.0.1.0)
	* Remove incorrect endpoint tests
* SavingsPlans (4.0.1.0)
	* Remove incorrect endpoint tests
* Scheduler (4.0.1.0)
	* Remove incorrect endpoint tests
* ServiceQuotas (4.0.2.0)
	* Remove incorrect endpoint tests
* SimpleEmail (4.0.1.0)
	* Remove incorrect endpoint tests
* SimpleEmailV2 (4.0.5.0)
	* Remove incorrect endpoint tests
* SimpleWorkflow (4.0.1.0)
	* Remove incorrect endpoint tests
* SSMGuiConnect (4.0.1.0)
	* Remove incorrect endpoint tests
* SSMIncidents (4.0.1.0)
	* Remove incorrect endpoint tests
* SsmSap (4.0.2.0)
	* Added support for Configuration Checks on SAP HANA Applications.
* SSO (4.0.1.0)
	* Remove incorrect endpoint tests
* TimestreamQuery (4.0.2.0)
	* Remove incorrect endpoint tests
* WAF (4.0.1.0)
	* Remove incorrect endpoint tests
* WorkMailMessageFlow (4.0.1.0)
	* Remove incorrect endpoint tests
* XRay (4.0.1.0)
	* Remove incorrect endpoint tests

### 4.0.79.0 (2025-08-27 19:34 UTC)
* ACMPCA (4.0.1.0)
	* Remove incorrect endpoint tests
* AmplifyBackend (4.0.1.0)
	* Remove incorrect endpoint tests
* AmplifyUIBuilder (4.0.1.0)
	* Remove incorrect endpoint tests
* AppConfigData (4.0.1.0)
	* Remove incorrect endpoint tests
* ApplicationDiscoveryService (4.0.1.0)
	* Remove incorrect endpoint tests
* ApplicationInsights (4.0.1.0)
	* Remove incorrect endpoint tests
* AppTest (4.0.1.0)
	* Remove incorrect endpoint tests
* Batch (4.0.2.8)
	* Added ECS_AL2023_NVIDIA as an option for Ec2Configuration.imageType.
* BedrockAgentCore (4.0.2.0)
	* Remove incorrect endpoint tests
* Chime (4.0.1.0)
	* Remove incorrect endpoint tests
* ChimeSDKIdentity (4.0.1.0)
	* Remove incorrect endpoint tests
* ChimeSDKMeetings (4.0.1.0)
	* Remove incorrect endpoint tests
* ChimeSDKVoice (4.0.1.0)
	* Remove incorrect endpoint tests
* CleanRoomsML (4.0.3.0)
	* Remove incorrect endpoint tests
* CloudWatchEvidently (4.0.1.0)
	* Remove incorrect endpoint tests
* CodeBuild (4.0.4.0)
	* Remove incorrect endpoint tests
* CodeConnections (4.0.2.0)
	* Remove incorrect endpoint tests
* CodeGuruProfiler (4.0.1.0)
	* Remove incorrect endpoint tests
* ComputeOptimizer (4.0.2.0)
	* Remove incorrect endpoint tests
* DataPipeline (4.0.1.0)
	* Remove incorrect endpoint tests
* DirectoryService (4.0.3.0)
	* Add APIs for CA AutoEnrollment support: DescribeCAEnrollmentPolicy, EnableCAEnrollmentPolicy and DisableCAEnrollmentPolicy.
* EKS (4.0.5.0)
	* Add support for on-demand refresh of EKS cluster insights
* ElastiCache (4.0.1.0)
	* Remove incorrect endpoint tests
* FraudDetector (4.0.1.0)
	* Remove incorrect endpoint tests
* Inspector (4.0.1.0)
	* Remove incorrect endpoint tests
* IoT (4.0.2.0)
	* Remove incorrect endpoint tests
* IoTFleetWise (4.0.2.0)
	* Remove incorrect endpoint tests
* IoTWireless (4.0.3.0)
	* Remove incorrect endpoint tests
* Ivschat (4.0.1.0)
	* Remove incorrect endpoint tests
* IVSRealTime (4.0.2.0)
	* Remove incorrect endpoint tests
* KafkaConnect (4.0.1.0)
	* Remove incorrect endpoint tests
* KeyManagementService (4.0.4.0)
	* Remove incorrect endpoint tests
* KinesisVideo (4.0.1.0)
	* Remove incorrect endpoint tests
* KinesisVideoMedia (4.0.1.0)
	* Remove incorrect endpoint tests
* LakeFormation (4.0.1.0)
	* Remove incorrect endpoint tests
* LexModelBuildingService (4.0.1.0)
	* Remove incorrect endpoint tests
* MarketplaceReporting (4.0.1.0)
	* Remove incorrect endpoint tests
* MedicalImaging (4.0.2.0)
	* Remove incorrect endpoint tests
* Mgn (4.0.1.0)
	* Remove incorrect endpoint tests
* MigrationHubConfig (4.0.1.0)
	* Remove incorrect endpoint tests
* Neptune (4.0.2.0)
	* Remove incorrect endpoint tests
* NeptuneGraph (4.0.1.0)
	* Add StartGraph and StopGraph operations to Neptune Analytics
* Omics (4.0.2.0)
	* Remove incorrect endpoint tests
* OpsWorks (Removed)
	* AWS OpsWorks has been removed from the SDK because it has been discontinued.
* OpsWorksCM (Removed)
	* AWS OpsWorksCM has been removed from the SDK because it has been discontinued.
* PaymentCryptographyData (4.0.3.0)
	* Remove incorrect endpoint tests
* Personalize (4.0.1.0)
	* Remove incorrect endpoint tests
* PI (4.0.1.0)
	* Remove incorrect endpoint tests
* QApps (4.0.1.0)
	* Remove incorrect endpoint tests
* QLDBSession (4.0.1.0)
	* Remove incorrect endpoint tests
* Redshift (4.0.1.0)
	* Remove incorrect endpoint tests
* RoboMaker (4.0.1.0)
	* Remove incorrect endpoint tests
* S3 (4.0.6.10)
	* set IsDeleteMarker to true for DeleteMarkers in ListVersionsResponse
* S3Tables (4.0.4.0)
	* Remove incorrect endpoint tests
* SageMaker (4.0.23.0)
	* This release adds support for AutoScaling on SageMaker HyperPod.
* Schemas (4.0.1.0)
	* Remove incorrect endpoint tests
* SimpleNotificationService (4.0.1.0)
	* Remove incorrect endpoint tests
* SnowDeviceManagement (4.0.1.0)
	* Remove incorrect endpoint tests
* SupplyChain (4.0.2.0)
	* Remove incorrect endpoint tests
* Textract (4.0.2.0)
	* Remove incorrect endpoint tests
* TimestreamWrite (4.0.2.0)
	* Remove incorrect endpoint tests
* VoiceID (4.0.1.0)
	* Remove incorrect endpoint tests
* VPCLattice (4.0.1.0)
	* Remove incorrect endpoint tests
* WorkDocs (4.0.1.0)
	* Remove incorrect endpoint tests
* WorkMail (4.0.1.0)
	* Remove incorrect endpoint tests

### 4.0.78.0 (2025-08-26 19:34 UTC)
* AppConfig (4.0.2.0)
	* Remove incorrect endpoint tests
* AppMesh (4.0.1.0)
	* Remove incorrect endpoint tests
* AppRegistry (4.0.1.0)
	* Remove incorrect endpoint tests
* AppRunner (4.0.1.0)
	* Remove incorrect endpoint tests
* ARCZonalShift (4.0.2.0)
	* This release adds new API options to enable allowed windows and multiple alarms for practice runs.
* BedrockAgentCoreControl (4.0.1.0)
	* Remove incorrect endpoint tests
* CleanRooms (4.0.4.0)
	* Remove incorrect endpoint tests
* CloudWatch (4.0.2.0)
	* Remove incorrect endpoint tests
* CodeCommit (4.0.1.0)
	* Remove incorrect endpoint tests
* CodeStarconnections (4.0.1.0)
	* Remove incorrect endpoint tests
* ComprehendMedical (4.0.1.0)
	* Remove incorrect endpoint tests
* ConnectContactLens (4.0.1.0)
	* Remove incorrect endpoint tests
* ConnectParticipant (4.0.2.0)
	* Amazon Connect Participant Service: Remove unused fields from WebRTCConnection
* ControlCatalog (4.0.2.0)
	* Remove incorrect endpoint tests
* DataSync (4.0.4.0)
	* Remove incorrect endpoint tests
* DLM (4.0.1.0)
	* Remove incorrect endpoint tests
* Drs (4.0.1.0)
	* Remove incorrect endpoint tests
* EC2 (4.0.33.0)
	* Add new APIs for viewing how your shared AMIs are used by other accounts, and identify resources in your account that are dependent on particular AMIs
* ElasticTranscoder (4.0.1.0)
	* Remove incorrect endpoint tests
* Evs (4.0.2.0)
	* Remove incorrect endpoint tests
* Finspace (4.0.1.0)
	* Remove incorrect endpoint tests
* GameLift (4.0.2.0)
	* Remove incorrect endpoint tests
* GeoRoutes (4.0.1.0)
	* Added RouteFerryNotice PotentialViolatedVehicleRestrictionUsage value for CalculateRoutes. This value indicates when the Route is potentially forbidden for the given vehicle profile.
* Glacier (4.0.1.0)
	* Remove incorrect endpoint tests
* GlobalAccelerator (4.0.1.0)
	* Remove incorrect endpoint tests
* Greengrass (4.0.1.0)
	* Remove incorrect endpoint tests
* IdentityStore (4.0.1.0)
	* Remove incorrect endpoint tests
* Imagebuilder (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTJobsDataPlane (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTSecureTunneling (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTTwinMaker (4.0.1.0)
	* Remove incorrect endpoint tests
* Kafka (4.0.1.0)
	* Remove incorrect endpoint tests
* LicenseManagerLinuxSubscriptions (4.0.1.0)
	* Remove incorrect endpoint tests
* LookoutforVision (4.0.1.0)
	* Remove incorrect endpoint tests
* MainframeModernization (4.0.1.0)
	* Remove incorrect endpoint tests
* MigrationHub (4.0.1.0)
	* Remove incorrect endpoint tests
* MigrationHubRefactorSpaces (4.0.1.0)
	* Remove incorrect endpoint tests
* MQ (4.0.1.0)
	* Remove incorrect endpoint tests
* Neptunedata (4.0.2.0)
	* Remove incorrect endpoint tests
* PcaConnectorScep (4.0.1.0)
	* Remove incorrect endpoint tests
* PersonalizeEvents (4.0.1.0)
	* Remove incorrect endpoint tests
* Pinpoint (4.0.1.0)
	* Remove incorrect endpoint tests
* Polly (4.0.2.0)
	* Remove incorrect endpoint tests
* RAM (4.0.1.0)
	* Remove incorrect endpoint tests
* RDSDataService (4.0.1.0)
	* Remove incorrect endpoint tests
* RecycleBin (4.0.1.0)
	* Remove incorrect endpoint tests
* ResourceExplorer2 (4.0.1.0)
	* Remove incorrect endpoint tests
* Route53 (4.0.3.0)
	* Remove incorrect endpoint tests
* Route53RecoveryCluster (4.0.1.0)
	* Remove incorrect endpoint tests
* S3 (4.0.6.9)
	* Fixes issue #3971. For initiateMultipartUpload, if CannedACL was set to NoACL, request was failing with bad request error.
* SageMakerGeospatial (4.0.1.0)
	* Remove incorrect endpoint tests
* SecretsManager (4.0.1.0)
	* Remove incorrect endpoint tests
* SecurityHub (4.0.3.0)
	* Remove incorrect endpoint tests
* Signer (4.0.1.0)
	* Remove incorrect endpoint tests
* SimpleSystemsManagement (4.0.3.0)
	* Remove incorrect endpoint tests
* SocialMessaging (4.0.2.0)
	* Remove incorrect endpoint tests
* SsmSap (4.0.1.0)
	* Remove incorrect endpoint tests
* SSOOIDC (4.0.1.0)
	* Remove incorrect endpoint tests
* Tnb (4.0.1.0)
	* Remove incorrect endpoint tests
* Transfer (4.0.2.0)
	* Remove incorrect endpoint tests
* TrustedAdvisor (4.0.1.0)
	* Remove incorrect endpoint tests
* WAFRegional (4.0.1.0)
	* Remove incorrect endpoint tests
* WorkSpaces (4.0.5.0)
	* Remove incorrect endpoint tests

### 4.0.77.0 (2025-08-25 20:57 UTC)
* B2bi (4.0.3.0)
	* Updated APIs to support custom validation rules.
* CodeGuruSecurity (4.0.0.21)
	* Documentation update to notify users of the discontinuation of Amazon CodeGuru Security.
* DataZone (4.0.7.0)
	* Releasing the following features - Asset classification that lets users use restricted terms for classifying assets if they have the right permissions. Also adding a new enum value "Moving" to project status.
* EC2 (4.0.32.0)
	* Added IPv6 support for AWS Client VPN.
* MediaConvert (4.0.8.0)
	* This release adds support for input rendition selection for HLS input, adds new Share API to enable sharing jobs with AWS Support for support investigations, and adds INCLUDE_AS_TS to iFrameOnlyManifest setting for HLS outputs.
* QBusiness (4.0.5.0)
	* The Amazon Q Business GetDocumentContent operation now supports retrieval of the extracted text content in JSON format.
* SQS (4.0.1.1)
	* Documentation update for Amazon SQS Supports Large Payload Message feature
* TimestreamInfluxDB (4.0.3.0)
	* Add MAINTENANCE status for DbInstance and DbCluster

### 4.0.76.0 (2025-08-22 19:15 UTC)
* Account (4.0.1.0)
	* Remove incorrect endpoint tests
* APIGateway (4.0.2.0)
	* Remove incorrect endpoint tests
* ApiGatewayV2 (4.0.2.0)
	* Remove incorrect endpoint tests
* AugmentedAIRuntime (4.0.1.0)
	* Remove incorrect endpoint tests
* AWSMarketplaceCommerceAnalytics (4.0.1.0)
	* Remove incorrect endpoint tests
* B2bi (4.0.2.0)
	* Remove incorrect endpoint tests
* CloudDirectory (4.0.1.0)
	* Remove incorrect endpoint tests
* CloudWatchRUM (4.0.1.0)
	* Remove incorrect endpoint tests
* CodePipeline (4.0.3.0)
	* Remove incorrect endpoint tests
* CognitoSync (4.0.1.0)
	* Remove incorrect endpoint tests
* DataExchange (4.0.3.0)
	* Remove incorrect endpoint tests
* DocDB (4.0.2.0)
	* Remove incorrect endpoint tests
* ElasticLoadBalancing (4.0.1.0)
	* Remove incorrect endpoint tests
* EMRServerless (4.0.5.0)
	* Remove incorrect endpoint tests
* HealthLake (4.0.1.0)
	* Remove incorrect endpoint tests
* IAMRolesAnywhere (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTAnalytics (4.0.1.0)
	* Remove incorrect endpoint tests
* KinesisFirehose (4.0.2.0)
	* Remove incorrect endpoint tests
* LaunchWizard (4.0.1.0)
	* Remove incorrect endpoint tests
* LocationService (4.0.2.0)
	* Remove incorrect endpoint tests
* Macie2 (4.0.1.0)
	* Remove incorrect endpoint tests
* MediaLive (4.0.4.0)
	* AWS Elemental MediaLive now has a field called "SubtitleRows" for controlling subtitle row count for DVB-Sub and Burn-In captions outputs
* MemoryDB (4.0.1.0)
	* Remove incorrect endpoint tests
* MigrationHubOrchestrator (4.0.1.0)
	* Remove incorrect endpoint tests
* NetworkMonitor (4.0.1.0)
	* Remove incorrect endpoint tests
* Organizations (4.0.3.0)
	* Remove incorrect endpoint tests
* PaymentCryptography (4.0.2.0)
	* Remove incorrect endpoint tests
* Pricing (4.0.2.0)
	* Remove incorrect endpoint tests
* Proton (4.0.1.0)
	* Remove incorrect endpoint tests
* QConnect (4.0.2.0)
	* Releasing model ID support for UpdateAIPrompt
* QLDB (4.0.1.0)
	* Remove incorrect endpoint tests
* RDS (4.0.5.5)
	* Updates Amazon RDS documentation for Db2 read-only replicas.
* RedshiftDataAPIService (4.0.1.0)
	* Remove incorrect endpoint tests
* Route53RecoveryReadiness (4.0.1.0)
	* Remove incorrect endpoint tests
* SageMaker (4.0.22.0)
	* Launch SageMaker Notebook Instances support for AL2023 along with P6-B200 instance type and Rootless Docker support for SageMaker Studio.
* SageMakerMetrics (4.0.2.0)
	* Remove incorrect endpoint tests
* ServiceDiscovery (4.0.1.3)
	* Updating SDK examples after launch of shared AWS Cloud Map namespaces
* SimSpaceWeaver (4.0.1.0)
	* Remove incorrect endpoint tests
* SQS (4.0.1.0)
	* Remove incorrect endpoint tests
* Synthetics (4.0.6.0)
	* Added multi browser support for synthetics canaries, Increased ephemeral storage limit from 5GB to 10GB
* WAFV2 (4.0.4.0)
	* test and verified, safe to release
* Core 4.0.0.25
	* Add support for RPCv2 CBOR protocol.

### 4.0.75.0 (2025-08-21 19:51 UTC)
* AccessAnalyzer (4.0.2.0)
	* Remove incorrect endpoint tests
* ApiGatewayManagementApi (4.0.1.0)
	* Remove incorrect endpoint tests
* AppFabric (4.0.1.0)
	* Remove incorrect endpoint tests
* AppIntegrationsService (4.0.2.0)
	* Remove incorrect endpoint tests
* AppStream (4.0.1.0)
	* Remove incorrect endpoint tests
* Artifact (4.0.1.0)
	* Remove incorrect endpoint tests
* AuditManager (4.0.4.0)
	* Remove incorrect endpoint tests
* Backup (4.0.3.0)
	* Remove incorrect endpoint tests
* BackupGateway (4.0.1.0)
	* Remove incorrect endpoint tests
* BedrockAgentRuntime (4.0.5.0)
	* Remove incorrect endpoint tests
* BillingConductor (4.0.1.0)
	* Remove incorrect endpoint tests
* CloudFront (4.0.4.0)
	* Remove incorrect endpoint tests
* CloudHSM (4.0.1.0)
	* Remove incorrect endpoint tests
* CloudTrail (4.0.2.0)
	* Remove incorrect endpoint tests
* CognitoIdentity (4.0.1.0)
	* Remove incorrect endpoint tests
* Comprehend (4.0.1.0)
	* Remove incorrect endpoint tests
* ConfigService (4.0.2.0)
	* Remove incorrect endpoint tests
* Connect (4.0.8.0)
	* Remove incorrect endpoint tests
* ConnectCampaignsV2 (4.0.2.0)
	* Remove incorrect endpoint tests
* ConnectCases (4.0.3.0)
	* Remove incorrect endpoint tests
* ConnectWisdomService (4.0.1.0)
	* Remove incorrect endpoint tests
* CostOptimizationHub (4.0.3.0)
	* Remove incorrect endpoint tests
* CustomerProfiles (4.0.4.0)
	* Remove incorrect endpoint tests
* DatabaseMigrationService (4.0.3.0)
	* Remove incorrect endpoint tests
* Deadline (4.0.9.0)
	* Remove incorrect endpoint tests
* DirectoryService (4.0.2.0)
	* Remove incorrect endpoint tests
* DirectoryServiceData (4.0.1.0)
	* Remove incorrect endpoint tests
* DynamoDBStreams (4.0.2.0)
	* Remove incorrect endpoint tests
* EBS (4.0.1.0)
	* Remove incorrect endpoint tests
* ECRPublic (4.0.2.0)
	* Remove incorrect endpoint tests
* ECS (4.0.4.6)
	* This is a documentation only release that adds additional information for the update-service request parameters.
* ElasticBeanstalk (4.0.1.0)
	* Remove incorrect endpoint tests
* ElasticLoadBalancingV2 (4.0.2.0)
	* Remove incorrect endpoint tests
* Elasticsearch (4.0.1.0)
	* Remove incorrect endpoint tests
* ForecastQueryService (4.0.1.0)
	* Remove incorrect endpoint tests
* GameLiftStreams (4.0.2.0)
	* The default application in a stream group can now be changed at any time using UpdateStreamGroup to update the DefaultApplicationIdentifier.
* Glue (4.0.15.0)
	* Added support for preprocessing queries in Data Quality operations through new DataQualityGlueTable structure.
* GreengrassV2 (4.0.1.0)
	* Remove incorrect endpoint tests
* GuardDuty (4.0.6.0)
	* Remove Pattern trait from email field
* Inspector2 (4.0.5.0)
	* Remove incorrect endpoint tests
* IoTDeviceAdvisor (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTEvents (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTEventsData (4.0.1.0)
	* Remove incorrect endpoint tests
* IoTThingsGraph (4.0.1.0)
	* Remove incorrect endpoint tests
* IVS (4.0.1.0)
	* Remove incorrect endpoint tests
* KinesisVideoSignalingChannels (4.0.1.0)
	* Remove incorrect endpoint tests
* KinesisVideoWebRTCStorage (4.0.1.0)
	* Remove incorrect endpoint tests
* LexRuntimeV2 (4.0.1.0)
	* Remove incorrect endpoint tests
* Lightsail (4.0.2.0)
	* Remove incorrect endpoint tests
* LookoutMetrics (4.0.1.0)
	* Remove incorrect endpoint tests
* ManagedBlockchain (4.0.1.0)
	* Remove incorrect endpoint tests
* ManagedGrafana (4.0.1.0)
	* Remove incorrect endpoint tests
* MarketplaceAgreement (4.0.1.0)
	* Remove incorrect endpoint tests
* MediaConnect (4.0.2.0)
	* Remove incorrect endpoint tests
* MediaConvert (4.0.7.0)
	* Remove incorrect endpoint tests
* MediaPackage (4.0.1.0)
	* Remove incorrect endpoint tests
* MediaPackageV2 (4.0.5.0)
	* Remove incorrect endpoint tests
* MediaTailor (4.0.2.0)
	* Remove incorrect endpoint tests
* MWAA (4.0.2.0)
	* Remove incorrect endpoint tests
* ObservabilityAdmin (4.0.2.0)
	* Remove incorrect endpoint tests
* Panorama (4.0.1.0)
	* Remove incorrect endpoint tests
* PinpointEmail (4.0.1.0)
	* Remove incorrect endpoint tests
* PrometheusService (4.0.3.0)
	* Remove incorrect endpoint tests
* ResourceGroups (4.0.1.0)
	* Remove incorrect endpoint tests
* Route53Profiles (4.0.1.0)
	* Remove incorrect endpoint tests
* Route53Resolver (4.0.2.0)
	* Remove incorrect endpoint tests
* S3 (4.0.6.8)
	* Fix issue of not passing in the explicit credentials when an internal instance of the S3 client is created for detecting bucket region.
* S3Outposts (4.0.1.0)
	* Remove incorrect endpoint tests
* SecurityLake (4.0.1.0)
	* Remove incorrect endpoint tests
* SecurityToken (4.0.2.0)
	* Remove incorrect endpoint tests
* SSMContacts (4.0.0.20)
	* Doc-only updates for Incident Manager Contacts August 2025
* SSMQuickSetup (4.0.1.0)
	* Remove incorrect endpoint tests
* TimestreamInfluxDB (4.0.2.0)
	* Remove incorrect endpoint tests
* VerifiedPermissions (4.0.2.0)
	* Remove incorrect endpoint tests
* WorkSpacesWeb (4.0.2.0)
	* Remove incorrect endpoint tests
* Core 4.0.0.24
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 4.0.74.0 (2025-08-20 18:47 UTC)
* AWSMarketplaceMetering (4.0.1.0)
	* Remove incorrect endpoint tests
* BedrockRuntime (4.0.4.0)
	* Launch CountTokens API to allow token counting
* Billing (4.0.2.0)
	* Clarify IPv4 and IPv6 endpoints
* Budgets (4.0.3.0)
	* Remove incorrect endpoint tests
* CognitoIdentityProvider (4.0.3.0)
	* This release adds support for the new Terms APIs which allow displaying Terms of Use and Privacy Policy on the Managed Login user-registration page.
* CostExplorer (4.0.3.0)
	* Remove incorrect endpoint tests
* DataZone (4.0.6.0)
	* This release supports policy grant identifier for cloud formation integration
* Detective (4.0.1.0)
	* Remove incorrect endpoint tests
* DynamoDBv2 (4.0.5.0)
	* Remove incorrect endpoint tests
* EKS (4.0.4.0)
	* EKS Add-ons Custom Namespace Support
* ElasticFileSystem (4.0.2.0)
	* Remove incorrect endpoint tests
* IdentityManagement (4.0.3.0)
	* Remove incorrect endpoint tests
* Kinesis (4.0.3.0)
	* Remove incorrect endpoint tests
* KinesisAnalyticsV2 (4.0.1.0)
	* Adds Key Management Service (KMS) support allowing customer-managed key (CMK) encryption for Flink application data.
* MarketplaceEntitlementService (4.0.1.0)
	* Remove incorrect endpoint tests
* NetworkManager (4.0.2.0)
	* Remove incorrect endpoint tests
* PinpointSMSVoiceV2 (4.0.2.0)
	* This change added InternationalSendingEnbaled as part of describe/Update/Request phone number API response, and as part of update/Request phone number API request
* Route53RecoveryControlConfig (4.0.1.0)
	* Remove incorrect endpoint tests
* SageMaker (4.0.21.0)
	* This release adds 1/ Launch ml.p5.4xlarge instance in Processing jobs, Training jobs and Training Plan 2/ Makes S3Uri to be required for S3FileSystem and S3FileSystemConfig.
* SimpleEmailV2 (4.0.4.0)
	* Remove incorrect endpoint tests

### 4.0.73.0 (2025-08-19 18:18 UTC)
* CleanRooms (4.0.3.0)
	* Support error message configuration for analysis templates
* EC2 (4.0.31.0)
	* Add support for "warning" volume status.
* Polly (4.0.1.0)
	* Added support for new output format - Opus.

### 4.0.72.0 (2025-08-18 18:31 UTC)
* Batch (4.0.2.6)
	* Added default_x86_64 and default_arm64 as values to the instanceTypes field.
* BCMDashboards (4.0.0.0)
	* Billing and Cost Management Dashboards enables users to create dashboards that combine multiple visualizations of cost and usage data. Users can create, manage, and share dashboards. Tags are also available for dashboards.
* Connect (4.0.7.0)
	* Amazon Connect Service Feature: Add support to enable multi-user in-app, web, and video calling.
* ConnectParticipant (4.0.1.0)
	* Amazon Connect Service Feature: Add support to enable multi-user in-app, web, and video calling.
* S3 (4.0.6.7)
	* Generate CopyPart.
	* [Breaking Change] Amazon.S3.Model.CopyPartResponse's BucketKeyEnabled will now return bool? instead of bool, in line with other S3 nullable types.
* S3Control (4.0.5.0)
	* Adds support for Compute checksum functionality in Amazon S3 Batch Operations. You can now calculate checksums for a list of objects using supported algorithms in Amazon S3, without requiring a restore or download
* SageMaker (4.0.20.0)
	* Customer managed keys now available for volume encryption of SageMaker HyperPod clusters.

### 4.0.71.0 (2025-08-15 18:17 UTC)
* ApiGatewayV2 (4.0.1.15)
	* Add required attributes to properties that have been renamed
* BedrockAgent (4.0.5.0)
	* This release adds support for saving Bedrock Flows while node configuration is still in progress, even if the Flow is not yet able to be invoked
* Glue (4.0.14.0)
	* AWS Glue Zero ETL now supports On-demand snapshot load
* PrometheusService (4.0.2.0)
	* Add Resource-based Policy APIs for Amazon Prometheus
* S3 (4.0.6.6)
	* Fixes issue #3959. Do not send empty lists for headers. ListObjectsV2 calls were failing if AWSConfigs.InitializeCollections was set to true. This was causing the SDK to send the `x-amz-optional-attributes` as an empty string which is not a valid value.
	* Add required attributes to properties that have been renamed
* SimpleWorkflow (4.0.0.19)
	* Add required attributes to properties that have been renamed
* WAF (4.0.0.19)
	* Add required attributes to properties that have been renamed
* WAFRegional (4.0.0.19)
	* Add required attributes to properties that have been renamed
* Core 4.0.0.23
	* Update SDK not to mutate credentials in provided config object (https://github.com/aws/aws-sdk-net/issues/3950)
	* All services packages updated to require new Core

### 4.0.70.0 (2025-08-14 18:35 UTC)
* ARCRegionswitch (4.0.1.0)
	* Endpoint rule test and documentation update.
* BCMRecommendedActions (4.0.0.0)
	* Initial SDK release for AWS Billing and Cost Management Recommended Actions.
* DirectConnect (4.0.2.0)
	* Added pagination support for DescribeHostedConnections, DescribeVirtualInterfaces, DescribeConnections, DescribeInterconnects, DescribeLags. Added asnLong support for BGP peer operations which supports a large range.
* DynamoDBv2 (4.0.4.0)
	* This release 1/ Adds support for throttled keys mode for CloudWatch Contributor Insights, 2/ Adds throttling reasons to exceptions across dataplane APIs. 3/ Explicitly models ThrottlingException as a class in statically typed languages. Refer to the launch day blog post for more details.
* EC2 (4.0.30.0)
	* This release adds ModifyInstanceConnectEndpoint API to update configurations on existing EC2 Instance Connect Endpoints and improves IPv6 support through dualstack DNS names for EC2 Instance Connect Endpoints.
* FSx (4.0.4.0)
	* Amazon FSx for NetApp ONTAP 2nd generation file systems now support decreasing SSD storage capacity.
* Glue (4.0.13.0)
	* AWS Glue now supports Trusted Identity Propagation.
* GuardDuty (4.0.5.0)
	* Added support for entity lists.
* MediaLive (4.0.3.0)
	* CMAF Ingest output groups in MediaLive can now accept one additional destination url for single pipeline channels and up to two additional destination urls for standard channels.
* PCS (4.0.6.0)
	* Updated the regex pattern and description of iamInstanceProfileArn in the CreateComputeNodeGroup and UpdateComputeNodeGroup API actions. Name and path requirements apply to the ARN of the IAM role associated with the instance profile and not the ARN of the instance profile.
* QApps (4.0.0.19)
	* Documentation update for Amazon Q Apps API Reference
* ServiceDiscovery (4.0.1.0)
	* Added support for cross account through Id parameter overloading with ARN and allow owner account for some APIs instead of ARN
* WorkSpaces (4.0.4.0)
	* New APIs introduced to import WorkSpaces BYOL image using a new process that leveraged EC2 Image Builder. WorkSpaces tests and fixes your image's compatibility issues and supports customized VM images.

### 4.0.69.0 (2025-08-13 18:21 UTC)
* Braket (4.0.1.0)
	* Add support for Braket program sets.
* DataZone (4.0.5.0)
	* Adds support for account pools and project profile account decoupling
* FSx (4.0.3.0)
	* Add Dual-Stack support for Amazon FSx for OpenZFS file systems
* PartnerCentralSelling (4.0.3.0)
	* Add Tagging Support for Opportunity resources
* S3 (4.0.6.5)
	* Generate PutBucketAcl PutBucketCors,PutObjectAcl, GetObjectAcl, ListObjectsV2, ListVersions, HeadObject.
	* As part of generating S3, all response unmarshallers will implement UnmarshallException. GetObjectACL will now throw NoSuchKeyException if no such key exists. This is not a breaking change.
* SageMaker (4.0.19.0)
	* This release introduces compute quota for GPU, Trainium accelerators, vCPU, and vCPU memory utilization across teams in HyperPod clusters
* SecurityIR (4.0.3.0)
	* Added support for Organizational Unit-level Membership configuration and the ability to resume a cancelled membership.
* Core 4.0.0.22
	* Remove extra Content MD5 setting in BaseMarshaller. Minor Xml namespace logic updates. Update all rest-xml service response unmarshallers to generate partial method PostUnmarshallCustomization. Generator updates.
	* All services packages updated to require new Core

### 4.0.68.0 (2025-08-12 19:48 UTC)
* BackupSearch (4.0.2.0)
	* Using recommended smithy trait to generate regional endpoints for Backup Search
* CodeBuild (4.0.3.0)
	* AWS CodeBuild now supports PullRequestBuildPolicy in webhook object.
* EC2 (4.0.29.0)
	* Release to allow route table association with a PublicIpv4Pool.
* Organizations (4.0.2.0)
	* This release introduces 2 new APIs in Organizations: 1. ListAccountsWithInvalidEffectivePolicy 2. ListEffectivePolicyValidationErrors
* SageMaker (4.0.18.0)
	* IAM Identity Center trusted identity propagation is now supported in SageMaker Studio.
* TranscribeService (4.0.3.0)
	* AWS HealthScribe now supports specifying preferred patient pronouns through the MedicalScribeContext parameter for use in the generated clinical notes.
* TranscribeStreaming (4.0.2.0)
	* AWS HealthScribe now supports specifying preferred patient pronouns through the MedicalScribeContext parameter for use in the generated clinical notes.

### 4.0.67.0 (2025-08-11 18:26 UTC)
* Bedrock (4.0.10.0)
	* This release includes model updates and enhanced SDK documentation for union fields in automated reasoning policy components. Added docs cover policy definitions, mutations (add/update for rules/types/variables), build assets, workflow sources, test results, and tag exception handling.
* CognitoIdentityProvider (4.0.2.0)
	* Remove SigV4 auth requirement for GetTokensFromRefreshToken
* Connect (4.0.6.0)
	* Updating SearchUserHierarchyGroups API
* Deadline (4.0.8.0)
	* Adds support for Wait and Save feature in service-managed fleets
* EC2 (4.0.28.0)
	* This release adds AvailabilityZoneId support for CreateVolume, DescribeVolume, LaunchTemplates, RunInstances, DescribeInstances, CreateDefaultSubnet, SpotInstances, and CreateDefaultSubnet APIs.
* Evs (4.0.1.2)
	* Update for general availability of Amazon Elastic VMware Service (EVS).
* Lambda (4.0.2.4)
	* Doc-only update for Lambda that updates the maximum payload size for response streaming invocations to 200 MB.
* QuickSight (4.0.4.0)
	* Add RowAxisDisplayOptions and ColumnAxisDisplayOptions to HeatMapConfiguration, add Actions to PluginVisual, increase limit for CalculatedFields list
* SSOAdmin (4.0.2.0)
	* Added support for managing user background session for applications

### 4.0.66.0 (2025-08-08 18:44 UTC)
* ApplicationSignals (4.0.1.0)
	* Removed incorrect endpoint tests
* BackupSearch (4.0.1.0)
	* Removed incorrect endpoint tests
* BCMPricingCalculator (4.0.3.0)
	* Removed incorrect endpoint tests
* Billing (4.0.1.0)
	* Removed incorrect endpoint tests
* Connect (4.0.5.0)
	* This release adds a new API GetContactMetrics for Amazon Connect.
* DSQL (4.0.4.0)
	* Removed incorrect endpoint tests
* GameLiftStreams (4.0.1.0)
	* Removed incorrect endpoint tests
* Inspector2 (4.0.4.0)
	* Add CVSSV4 to Vulnerability Search API and update enable/disable account id list length to 5
* Invoicing (4.0.2.0)
	* Removed incorrect endpoint tests
* IotData (4.0.1.0)
	* Adding DeleteConnection API to IoT Data Plane
* IoTManagedIntegrations (4.0.2.0)
	* Removed incorrect endpoint tests
* KeyspacesStreams (4.0.1.0)
	* Removed incorrect endpoint tests
* MPA (4.0.1.0)
	* Removed incorrect endpoint tests
* NetworkFlowMonitor (4.0.3.0)
	* Removed incorrect endpoint tests
* Notifications (4.0.1.0)
	* Removed incorrect endpoint tests
* NotificationsContacts (4.0.1.0)
	* Removed incorrect endpoint tests
* PartnerCentralSelling (4.0.2.0)
	* Removed incorrect endpoint tests
* S3Vectors (4.0.1.0)
	* Removed incorrect endpoint tests
* SageMaker (4.0.17.0)
	* Adds support for GB200 UltraServers in Amazon SageMaker training jobs, training plans, and HyperPod clusters
* SecurityIR (4.0.2.0)
	* Removed incorrect endpoint tests
* TranscribeService (4.0.2.7)
	* Update documentation to use key ARN only in OutputEncryptionKMSKeyId request parameter
* WorkspacesInstances (4.0.1.0)
	* Removed incorrect endpoint tests

### 4.0.65.0 (2025-08-07 18:32 UTC)
* Batch (4.0.2.3)
	* This feature allows customers to use AWS Batch with Linux with ARM64 CPU Architecture with Fargate Spot compute support.
* CloudFront (4.0.3.0)
	* Added new viewer security policy, TLSv1.3_2025, for CloudFront.
* CodeBuild (4.0.2.0)
	* AWS CodeBuild now supports comment-based pull request control.
* GameLiftStreams (4.0.0.18)
	* Adds Proton 9.0-2 to the list of runtime environment options available when creating an Amazon GameLift Streams application
* Glue (4.0.12.0)
	* AWS Glue Data Catalog now supports Iceberg Optimization settings at the Catalog level, and supports new options to control the optimization job run rate.
* GuardDuty (4.0.4.0)
	* Added support for VPC owner account ID associated with DNS request in the GuardDuty finding.

### 4.0.64.0 (2025-08-06 18:29 UTC)
* AppStream (4.0.0.17)
	* Added support for G6 instances
* Budgets (4.0.2.0)
	* Adds support for billing views. Billing views let you control access to cost and usage data through an AWS resource, streamlining the process of sharing cost and usage data across account boundaries. With this release, you can now create and view budgets based on billing views.
* EC2 (4.0.27.0)
	* Mark Elastic Inference Accelerators and Elastic Graphics Processor parameters as deprecated on the RunInstances and LaunchTemplate APIs.
* OpenSearchServerless (4.0.2.0)
	* Features: add Index APIs in OpenSearchServerless to support managed semantic enrichment
* QBusiness (4.0.4.0)
	* Amazon Q Business now supports the GetDocumentContent() API that enables customers to securely access the source documents through clickable citation links at query time
* S3 (4.0.6.4)
	* Generate Get and PutLifecycleConfiguration. Generate Put and GetBucketConfiguration
	* Generate InitiateMultipartUpload, DeleteBucketCors,DeleteBucketLifecycle, GetBucketAcl and GetBucketCors
* Core 4.0.0.21
	* Add XmlStructureUnmarshallCustomization hook for all xml structures
	* All services packages updated to require new Core

### 4.0.63.0 (2025-08-05 18:40 UTC)
* Bedrock (4.0.9.0)
	* This release introduces Automated Reasoning checks for Amazon Bedrock Guardrails. The feature adds new APIs for policy building, refinement, version management, and testing. Guardrail APIs now support Automated Reasoning policy configuration and validation output.
* BedrockRuntime (4.0.3.0)
	* This release adds support for Automated Reasoning checks output models for the Amazon Bedrock Guardrails ApplyGuardrail API.
* DynamoDBv2 (4.0.3.3)
	* Update exception message for native aot error handling for dynamodb deserialization.
* EKS (4.0.3.0)
	* Add support for deletion protection on EKS clusters
* RDS (4.0.5.0)
	* Adds a new Aurora Serverless v2 attribute to the DBCluster resource to expose the platform version. Also updates the attribute to be part of both the engine version and platform version descriptions.
* SageMaker (4.0.16.0)
	* Add support for SageMaker Hyperpod continuous scaling and custom AMI; Introduce new APIs: ListClusterEvents, DescribeClusterEvent, BatchAddClusterNodes

### 4.0.62.0 (2025-08-04 21:40 UTC)
* BedrockAgentCore (4.0.1.0)
	* Remove superfluous field from API
* CodeConnections (4.0.1.0)
	* New integration with Azure DevOps provider type.
* Evs (4.0.1.0)
	* TagResource API now throws ServiceQuotaExceededException when the number of tags on the Amazon EVS resource exceeds the maximum allowed. TooManyTagsException is deprecated.
* IoTSiteWise (4.0.2.0)
	* Support Interface for IoT SiteWise Asset Modeling
* SageMaker (4.0.15.0)
	* This release adds the ability for customers to attach and detach their EBS volumes to EKS-orchestrated HyperPod cluster nodes.
* Core 4.0.0.20
	* Update HTTP handler to handle scenario where content stream position is not zero (https://github.com/aws/aws-sdk-net/issues/3941)
	* All services packages updated to require new Core

### 4.0.61.0 (2025-08-01 18:25 UTC)
* ACMPCA (4.0.0.16)
	* Doc-only update to add more information to GetCertificate action.
* AIOps (4.0.2.0)
	* This release includes fix for InvestigationGroup timestamp conversion issue.
* ARCRegionswitch (4.0.0.0)
	* This is the initial SDK release for Region switch
* AuditManager (4.0.3.0)
	* Added a note to Framework APIs (CreateAssessmentFramework, GetAssessmentFramework, UpdateAssessmentFramework) clarifying that the Controls object returns a partial response when called through Framework APIs. Added documentation that the Framework's controlSources parameter is no longer supported.
* Lightsail (4.0.1.0)
	* This release adds support for the Asia Pacific (Jakarta) (ap-southeast-3) Region.
* ObservabilityAdmin (4.0.1.0)
	* CloudWatch Observability Admin adds the ability to enable telemetry on AWS resources such as Amazon VPCs (Flow Logs) in customers AWS Accounts and Organizations. The release introduces new APIs to manage telemetry rules, which define telemetry settings to be applied on AWS resources.
* PCS (4.0.5.0)
	* Add support for IPv6 Networking for Clusters.
* SecurityHub (4.0.2.0)
	* Release new resource detail type CodeRepository
* SimpleNotificationService (4.0.0.16)
	* Amazon SNS support for Amazon SQS fair queues

### 4.0.60.0 (2025-07-31 18:26 UTC)
* CognitoIdentity (4.0.0.16)
	* Avoid cloning `ImmutableCredentials` objects.
* CustomerProfiles (4.0.3.0)
	* The release updates standard profile with 2 new fields that supports account-level engagement. Updated APIs include CreateProfile, UpdateProfile, MergeProfiles, SearchProfiles, BatchGetProfile, GetSegmentMembership, CreateSegmentDefinition, CreateSegmentEstimate.
* EC2 (4.0.26.0)
	* Added support for the force option for the EC2 instance terminate command. This feature enables customers to recover resources associated with an instance stuck in the shutting-down state as a result of rare issues caused by a frozen operating system or an underlying hardware problem.
* ElasticLoadBalancingV2 (4.0.1.5)
	* This release enables secondary IP addresses for Network Load Balancers.
* EntityResolution (4.0.2.0)
	* Add support for creating advanced rule-based matching workflows in AWS Entity Resolution.
* GameLift (4.0.1.5)
	* Avoid cloning `ImmutableCredentials` objects.
* Glue (4.0.11.0)
	* Added support for Route node, S3 Iceberg sources/targets, catalog Iceberg sources, DynamoDB ELT connector, AutoDataQuality evaluation, enhanced PII detection with redaction, Kinesis fan-out support, and new R-series worker types.
* Inspector2 (4.0.3.0)
	* Extend usage to include agentless hours and add CODE_REPOSITORY to aggregation resource type
* IoT (4.0.1.0)
	* This release allows AWS IoT Core users to use their own AWS KMS keys for data protection
* OpenSearchService (4.0.2.0)
	* Granular access control support for NEO-SAML with IAMFederation for AOS data source
* QuickSight (4.0.3.0)
	* Added Impala connector support
* S3Control (4.0.4.0)
	* Add Tags field to CreateAccessPoint
* SecurityToken (4.0.1.7)
	* Avoid cloning `ImmutableCredentials` objects.
* SimpleEmailV2 (4.0.3.0)
	* This release introduces support for Multi-tenant management
* WorkSpacesWeb (4.0.1.0)
	* Added ability to log session activity on a portal to an S3 bucket.
* Core 4.0.0.19
	* Avoid cloning `ImmutableCredentials` objects.

### 4.0.59.0 (2025-07-30 18:24 UTC)
* CloudFront (4.0.2.0)
	* This release adds new origin timeout options: 1) ResponseCompletionTimeout and 2) OriginReadTimeout (for S3 origins)
* DirectoryService (4.0.1.0)
	* This release adds support for AWS Managed Microsoft AD Hybrid Edition, introducing new operations: StartADAssessment, DescribeADAssessment, ListADAssessments, DeleteADAssessment, CreateHybridAD, UpdateHybridAD, and DescribeHybridADUpdate; and updated existing operation: DescribeDirectories.
* DocDB (4.0.1.0)
	* Add support for setting Serverless Scaling Configuration on clusters.
* EC2 (4.0.25.0)
	* Release to show the next hop IP address for routes propagated by VPC Route Server into VPC route tables.
* IoTWireless (4.0.2.0)
	* Added TxPowerIndexMin, TxPowerIndexMax, NbTransMin and NbTransMax params to ServiceProfile.

### 4.0.58.0 (2025-07-29 18:20 UTC)
* Batch (4.0.2.0)
	* AWS Batch for SageMaker Training jobs feature support.  Includes new APIs for service job submission (e.g., SubmitServiceJob) and managing service environments (e.g., CreateServiceEnvironment) that enable queueing SageMaker Training jobs.
* CleanRooms (4.0.2.0)
	* This feature provides the ability to update the table reference and allowed columns on an existing configured table.
* Deadline (4.0.7.0)
	* Adds support for tag management on monitors.
* LocationService (4.0.1.0)
	* This release 1) adds support for multi-polygon geofences with disconnected territories, and 2) enables polygon exclusion zones within geofences for more accurate representation of real-world boundaries.
* OpenSearchServerless (4.0.1.0)
	* This is to support Granular access control support for SAML with IAMFedraton in AOSS

### 4.0.57.0 (2025-07-28 18:50 UTC)
* DirectConnect (4.0.1.0)
	* Enable MACSec support and features on Interconnects.
* IoTSiteWise (4.0.1.0)
	* Add support for native anomaly detection in IoT SiteWise using new Computation Model APIs
* OSIS (4.0.1.0)
	* Add Pipeline Role Arn as an optional parameter to the create / update pipeline APIs as an alternative to passing in the pipeline configuration body

### 4.0.56.0 (2025-07-25 18:25 UTC)
* AppIntegrationsService (4.0.1.0)
	* Amazon AppIntegrations introduces new configuration capabilities to enable customers to manage iframe permissions, control application refresh behavior (per contact or per browser/cross-contact), and run background applications (service).
* Budgets (4.0.1.0)
	* Adds IPv6 and PrivateLink support for AWS Budgets in IAD.
* ConfigService (4.0.1.5)
	* Documentation improvements have been made to the EvaluationModel and DescribeConfigurationRecorders APIs.
* EC2 (4.0.24.0)
	* Transit Gateway native integration with AWS Network Firewall. Adding new enum value for the new Transit Gateway Attachment type.
* KeyManagementService (4.0.3.9)
	* Doc only update: fixed grammatical errors.
* MediaPackageV2 (4.0.4.0)
	* This release adds support for specifying a preferred input for channels using CMAF ingest.
* SocialMessaging (4.0.1.0)
	* This release introduces new WhatsApp template management APIs that enable customers to programmatically create and submit templates for approval, monitor approval status, and manage the complete template lifecycle
* SQS (4.0.0.17)
	* Documentation updates for Amazon SQS fair queues feature.
* Core 4.0.0.18
	* Add utility method for allowing .NET Standard 2.0 libraries using the SDK to know whether they are using the .NET Framework version of the SDK.

### 4.0.55.0 (2025-07-24 18:14 UTC)
* DataZone (4.0.4.0)
	* This release adds support for 1) highlighting relevant text in returned results for Search and SearchListings APIs and 2) returning aggregated counts of values for specified attributes for SearchListings API.
* Omics (4.0.1.0)
	* Add Git integration and README support for HealthOmics workflows

### 4.0.54.0 (2025-07-23 18:16 UTC)
* EC2 (4.0.23.0)
	* Added support for skip-os-shutdown option for the EC2 instance stop and terminate operations. This feature enables customers to bypass the graceful OS shutdown, supporting faster state transitions when instance data preservation isn't critical.
* Glue (4.0.10.0)
	* AWS Glue now supports dynamic session policies for job executions. This feature allows you to specify custom, fine-grained permissions for each job run without creating multiple IAM roles.
* S3 (4.0.6.2)
	* Generate PutBucket operation.
* WorkSpacesThinClient (4.0.3.0)
	* Added the lastUserId parameter to the ListDevices and GetDevice API.
* Core 4.0.0.17
	* Move PostMarshallCustomization for restXml services to right before setting request.Content
	* All services packages updated to require new Core

### 4.0.53.0 (2025-07-22 18:25 UTC)
* ECR (4.0.3.0)
	* Add support for Image Tag Mutability Exception feature, allowing repositories to define wildcard-based patterns that override the default image tag mutability settings.
* ElasticMapReduce (4.0.2.0)
	* This release adds new parameter 'ExtendedSupport' in AWS EMR RunJobFlow, ModifyCluster and DescribeCluster API.
* Lambda (4.0.2.0)
	* This release migrated the model to Smithy keeping all features unchanged.
* Neptunedata (4.0.1.0)
	* This release updates the supported regions for Neptune API to include current AWS regions.
* S3 (4.0.6.1)
	* Add CreatePresignedPost to interface

### 4.0.52.0 (2025-07-21 18:18 UTC)
* CloudFront (4.0.1.0)
	* Add dualstack endpoint support
* Deadline (4.0.6.0)
	* Add support for VPC resource endpoints in Service Managed Fleets
* EC2 (4.0.22.0)
	* This release adds support for C8gn, F2 and P6e-GB200 Instance types
* SageMaker (4.0.14.0)
	* This release adds 1/ Support for S3FileSystem in CustomFileSystems 2/ The ability for a customer to select their preferred IpAddressType for use with private Workforces 3/ Support for p4de instance type in SageMaker Training Plans
* TimestreamInfluxDB (4.0.1.0)
	* Timestream for InfluxDB adds support for db.influx.24xlarge instance type. This enhancement enables higher compute capacity for demanding workloads through CreateDbInstance, CreateDbCluster, UpdateDbInstance, and UpdateDbCluster APIs.

### 4.0.51.0 (2025-07-18 18:20 UTC)
* AuditManager (4.0.2.0)
	* Updated error handling for RegisterOrganizationAdminAccount API to properly translate TooManyExceptions to HTTP 429 status code. This enhancement improves error handling consistency and provides clearer feedback when request limits are exceeded.
* CloudWatchLogs (4.0.7.0)
	* CloudWatchLogs launches GetLogObject API with streaming support for efficient log data retrieval. Logs added support for new AccountPolicy type METRIC_EXTRACTION_POLICY. For more information, see CloudWatch Logs API documentation
* MediaConvert (4.0.6.0)
	* This release adds support for TAMS server integration with MediaConvert inputs.
* Outposts (4.0.2.0)
	* Add AWS Outposts API to surface customer billing information
* S3 (4.0.6.0)
	* Implement presigned POST urls
* SimpleEmailV2 (4.0.2.0)
	* Added IP Visibility support for managed dedicated pools. Enhanced GetDedicatedIp and GetDedicatedIps APIs to return managed IP addresses.
* SimpleSystemsManagement (4.0.2.4)
	* July 2025 doc-only updates for Systems Manager.

### 4.0.50.0 (2025-07-17 18:22 UTC)
* CleanRoomsML (4.0.2.0)
	* This release introduces Parquet result format support for ML Input Channel models in AWS Clean Rooms ML.
* CloudFront (4.0.0.16)
	* Doc only update for CloudFront that fixes some customer-reported issues
* EC2 (4.0.21.0)
	* AWS Free Tier Version2 Support
* KeyspacesStreams (4.0.0.4)
	* Doc only update for the Amazon Keyspaces Streams API.
* MailManager (4.0.2.0)
	* Allow underscores in the local part of the input of the "Email recipients rewrite" action in rule sets.
* MediaConvert (4.0.5.0)
	* This release expands the range of supported audio outputs to include xHE, 192khz FLAC and the deprecation of dual mono for AC3.
* S3 (4.0.5.1)
	* Decorated AnalyticsId and StorageClassAnalysis properties in AnalyticsConfiguration class with [AWSProperty(Required = true)] attribute per S3 service API model.
	* Decorated AnalyticsConfiguration property in PutBucketAnalyticsConfigurationRequest class with [AWSProperty(Required = true)] attribute per S3 service API model.
* StepFunctions (4.0.0.16)
	* Align input with style guidelines.
* Synthetics (4.0.5.0)
	* This feature allows AWS Synthetics customers to provide code dependencies using lambda layer while creating a canary

### 4.0.49.0 (2025-07-16 15:39 UTC)
* Bedrock (4.0.8.0)
	* This release adds support for on-demand custom model inference through CustomModelDeployment APIs for Amazon Bedrock.
* BedrockAgentCore (4.0.0.0)
	* Initial release of Amazon Bedrock AgentCore SDK including Runtime, Built-In Tools, Memory, Gateway and Identity.
* BedrockAgentCoreControl (4.0.0.0)
	* Initial release of Amazon Bedrock AgentCore SDK including Runtime, Built-In Tools, Memory, Gateway and Identity.
* BedrockRuntime (4.0.2.0)
	* document update to support on demand custom model.
* CloudWatchLogs (4.0.6.0)
	* CloudWatch Logs updates: Added X-Ray tracing for Amazon Bedrock Agent resources. Logs introduced Log Group level resource policies (managed through Put/Delete/Describe Resource Policy APIs). For more information, see CloudWatch Logs API documentation.
* DataSync (4.0.3.0)
	* AWS DataSync now supports IPv6 address inputs and outputs in create, update, and describe operations for NFS, SMB, and Object Storage locations
* DynamoDBv2 (4.0.3.0)
	* Add native support for LINQ expression trees in the IDynamoDBContext API for ScanAsync<T>() and QueryAsync<T>()
* Glue (4.0.9.0)
	* AWS Glue now supports schema, partition and sort management of Apache Iceberg tables using Glue SDK
* GuardDuty (4.0.3.0)
	* Add expectedBucketOwner parameter to ThreatIntel and IPSet APIs.
* IoTWireless (4.0.1.0)
	* FuotaTaskId is not a valid IdentifierType for EventConfiguration and is being removed from possible IdentifierType values.
* MediaPackageV2 (4.0.3.0)
	* This release adds support for CDN Authentication using Static Headers in MediaPackage v2.
* NetworkFlowMonitor (4.0.2.0)
	* Introducing 2 new scope status types - DEACTIVATING and DEACTIVATED.
* PaymentCryptographyData (4.0.2.0)
	* Expand length of message data field for Mac generation and validation to 8192 characters.
* StepFunctions (4.0.0.15)
	* Doc-only update to introduction, and edits to clarify input parameter and the set of control characters.

### 4.0.48.0 (2025-07-16 00:41 UTC)
* ECS (4.0.4.0)
	* This release removes hookDetails for the Amazon ECS native blue/green deployments.

### 4.0.47.0 (2025-07-15 18:41 UTC)
* BedrockAgent (4.0.4.0)
	* Add support for S3 Vectors as a vector store.
* DataZone (4.0.3.0)
	* Removing restriction of environment profile identifier as required field, S3 feature release
* DynamoDBStreams (4.0.1.0)
	* Added support for optional shard filter parameter in DescribeStream api that allows customers to fetch child shards of a read_only parent shard.
* EC2 (4.0.20.0)
	* This release adds support for volume initialization status, which enables you to monitor when the initialization process for an EBS volume is completed. This release also adds IPv6 support to EC2 Instance Connect Endpoints, allowing you to connect to your EC2 Instance via a private IPv6 address.
* ECS (4.0.3.0)
	* Amazon ECS supports native blue/green deployments, allowing you to validate new service revisions before directing production traffic to them.
* EventBridge (4.0.3.0)
	* Add customer-facing logging for the EventBridge Event Bus, enabling customers to better observe their events and extract insights about their EventBridge usage.
* OpenSearchService (4.0.1.0)
	* AWS Opensearch adds support for enabling s3 vector engine options. After enabling this option, customers will be able to create indices with s3 vector engine.
* Pricing (4.0.1.0)
	* This release adds support for new filter types in GetProducts API, including EQUALS, CONTAINS, ANY_OF, and NONE_OF.
* QuickSight (4.0.2.0)
	* Introduced custom instructions for topics.
* Repostspace (4.0.1.0)
	* This release introduces Channels functionality with CreateChannel, GetChannel, ListChannels, and UpdateChannel operations. Channels provide dedicated collaboration spaces where teams can organize discussions and knowledge by projects, business units, or areas of responsibility.
* S3 (4.0.5.0)
	* Amazon S3 Metadata live inventory tables provide a queryable inventory of all the objects in your general purpose bucket so that you can determine the latest state of your data. To help minimize your storage costs, use journal table record expiration to set a retention period for your records.
* S3Tables (4.0.3.0)
	* Adds table bucket type to ListTableBucket and GetTableBucket API operations
* S3Vectors (4.0.0.0)
	* Amazon S3 Vectors provides cost-effective, elastic, and durable vector storage for queries based on semantic meaning and similarity.
* SageMaker (4.0.13.0)
	* This release adds support for a new Restricted instance group type to enable a specialized environment for running Nova customization jobs on SageMaker HyperPod clusters. This release also adds support for SageMaker pipeline versioning.
* Core 4.0.0.16
	* Add `AWSConfigs.DisableLegacyPersistenceStore` option to instruct the SDK not to use the [SDK Store](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/sdk-store.html) in its default profile resolution search
	* Update `PersistenceManager` not to throw an exception when the SDK is used with a read-only file system (https://github.com/aws/aws-sdk-net/issues/3801)
	* All services packages updated to require new Core

### 4.0.46.0 (2025-07-09 18:20 UTC)
* EC2 (4.0.19.0)
	* Adds support to Capacity Blocks for ML for purchasing EC2 P6e-GB200 UltraServers. Customers can now purchase u-p6e-gb200x72 and u-p6e-gb200x36 UltraServers. Adds new DescribeCapacityBlocks andDescribeCapacityBlockStatus APIs. Adds support for CapacityBlockId to DescribeInstanceTopology.
* FreeTier (4.0.1.0)
	* This release introduces four new APIs: GetAccountPlanState and UpgradeAccountPlan for AWS account plan management; ListAccountActivities and GetAccountActivity that provide activity tracking capabilities.
* OpsWorksCM (4.0.0.13)
	* Removing content that refers to an S3 bucket that is no longer in use.
* S3 (4.0.4.2)
	* Move S3PostUploadSignedPolicy out of _bcl folder
	* Update ExceptionUnmarshallers and add S3 Exception t4 file. Generate PutBucketPolicy, PutObjectLegalHold, PutObjectLockConfiguration, PutObjectRetention, PutPublicAccessBlock, HeadBucket, ListParts, PutObjectTagging
	* [Breaking Change] `LastModified` in `Amazon.S3.Model.PartDetail` is `DateTime?` instead of `DateTime` to follow v4 pattern of nullable types
	* [Breaking Change] `Tagging` in `PutBucketPolicyRequest` is no longer automatically initialized if null. You must initialize the object.
	* Fix GetSignedPolicyFromJson error handling exception message
* Core 4.0.0.15
	* Remove and adjust unused targets NET35 and NET45 from codebase.
	* All services packages updated to require new Core

### 4.0.45.0 (2025-07-03 18:22 UTC)
* CustomerProfiles (4.0.2.0)
	* This release introduces capability of create Segments via importing a CSV file directly. This consumes the CSV file and creates/updates corresponding profiles for the particular domain.
* Deadline (4.0.5.0)
	* Added fields for output manifest reporting and task chunking parameters
* EC2 (4.0.18.0)
	* This release adds GroupOwnerId as a response member to the DescribeSecurityGroupVpcAssociations API and also adds waiters for SecurityGroupVpcAssociations (SecurityGroupVpcAssociationAssociated and SecurityGroupVpcAssociationDisassociated).
* MediaPackageV2 (4.0.2.0)
	* This release adds support for Microsoft Smooth Streaming (MSS) and allows users to exclude DRM segment Metadata in MediaPackage v2 Origin Endpoints
* Route53 (4.0.2.0)
	* Amazon Route 53 now supports the iso-e regions for private DNS Amazon VPCs and cloudwatch healthchecks.
* S3 (4.0.4.1)
	* Fix generated `GetBucketLocation` operation to correctly parse response from S3.
* SageMaker (4.0.12.0)
	* Changes include new StartSession API for SageMaker Studio spaces and CreateHubContentPresignedUrls API for SageMaker JumpStart.

### 4.0.44.0 (2025-07-02 18:17 UTC)
* ConnectCases (4.0.2.0)
	* This release adds DeleteCase and DeleteRelatedItem APIs, which enable deleting cases and comments, undoing contact association, and removing service level agreements (SLAs) from cases. Contact center admins can use these APIs to delete cases when requested by customers and correct agent errors.
* EC2 (4.0.17.0)
	* AWS Site-to-Site VPN now supports IPv6 addresses on outer tunnel IPs, making it easier for customers to build or transition to IPv6-only networks.
* S3 (4.0.4.0)
	* Added support for directory bucket creation with tags and bucket ARN retrieval in CreateBucket, ListDirectoryBuckets, and HeadBucket operations
* S3Control (4.0.3.0)
	* Added TagResource, UntagResource, and ListTagsForResource support for directory bucket

### 4.0.43.0 (2025-07-01 20:51 UTC)
* CleanRoomsML (4.0.1.0)
	* This release introduces support for incremental training and distributed training for custom models in AWS Clean Rooms ML.
* DataZone (4.0.2.0)
	* Add support for the new optional domain-unit-id parameter in the UpdateProject API.
* EC2 (4.0.16.0)
	* Add Context to GetInstanceTypesFromInstanceRequirements API
* Odb (4.0.0.0)
	* This release adds API operations for Oracle Database@AWS. You can use the APIs to create Exadata infrastructure, ODB networks, and Exadata and Autonomous VM clusters inside AWS data centers. The infrastructure is managed by OCI. You can integrate these resources with AWS services.
* QBusiness (4.0.3.0)
	* New ChatResponseConfiguration to Customize Q Business chat responses for specific use cases and communication needs. Updated Boosting capability allowing admins to provide preference on date attributes for recency and/or provide a preferred data source.
* RDS (4.0.4.1)
	* Amazon RDS Custom for Oracle now supports multi-AZ database instances.
* SageMaker (4.0.11.0)
	* Updated field validation requirements for InstanceGroups.
* Core 4.0.0.14
	* Add new protocol tests. Update JSON response unmarshallers to return safely if the service returns an empty string as a response instead of an empty json body
	* All services packages updated to require new Core

### 4.0.42.0 (2025-06-30 18:38 UTC)
* ARCZonalShift (4.0.1.0)
	* Added support for on-demand practice runs and balanced capacity checks in ARC autoshift practice.
* B2bi (4.0.1.0)
	* Updated APIs to support inbound EDI split capabilities and additional Partnership-level configurations of generated EDI files' contents and format.
* Bedrock (4.0.7.0)
	* Add support for API Keys, Re-Ranker, implicit filter for RAG / KB evaluation for Bedrock APIs.
* BedrockRuntime (4.0.1.0)
	* Add API Key and document citations support for Bedrock Runtime APIs
* CloudFormation (4.0.2.0)
	* Added support for UNKNOWN drift status.
* CloudWatchLogs (4.0.5.0)
	* Increase minimum length of queryId parameter to 1 character.
* ConfigService (4.0.1.0)
	* Updated ResourceType enum with new resource types onboarded by AWS Config as of June 2025
* Connect (4.0.4.0)
	* This release introduces ChatMetrics to the model, providing comprehensive analytics insights for Amazon Connect chat conversations. Users can access these detailed metrics through the AWS Connect API by using the DescribeContact operation with their specific instance and contact IDs
* DataExchange (4.0.2.0)
	* This release updates resource Id with alphanumeric constraint, including Asset id, Revision id, Data Set id, Job id, and Event Action id.
* DynamoDBv2 (4.0.2.0)
	* This change adds support for witnesses in global tables. It also adds a new table status, REPLICATION_NOT_AUTHORIZED. This status will indicate scenarios where global replicas table can't be utilized for data plane operations.
* EventBridge (4.0.2.0)
	* Added support for EventBridge Dualstack endpoints in AWS GovCloud (US) regions (us-gov-east-1 and us-gov-west-1). The dualstack endpoints are identical for both FIPS and non-FIPS configurations, following the format: events.{region}.api.aws
* Glue (4.0.8.0)
	* releasing source processing properties to support source properties for ODB integrations
* IdentityManagement (4.0.2.0)
	* Updated IAM ServiceSpecificCredential support to include expiration, API Key output format instead of username and password for services that will support API keys, and the ability to list credentials for all users in the account for a given service configuration.
* MedicalImaging (4.0.1.0)
	* Added new fields to support the concept of primary image sets within the storage hierarchy.
* NetworkFlowMonitor (4.0.1.0)
	* Add ConflictExceptions to UpdateScope and DeleteScope operations for scopes being mutated.
* Outposts (4.0.1.0)
	* Make ContactName and ContactPhoneNumber required fields when creating and updating Outpost Site Addresses.
* PCS (4.0.4.0)
	* Fixed the validation pattern for an instance profile Amazon Resource Name (ARN) in AWS PCS.
* QuickSight (4.0.1.0)
	* Introduced custom permission capabilities for reporting content. Added menu option in exploration to preserve configuration data when textbox menu option is used. Added support for Athena trusted identity propagation.
* SimpleSystemsManagement (4.0.2.0)
	* Introduces AccessType, a new filter value for the DescribeSessions API.
* Transfer (4.0.1.0)
	* Added support for dual-stack (IPv4 and IPv6) endpoints for SFTP public endpoints and VPC-internal endpoints (SFTP, FTPS, FTP, and AS2), enabling customers to configure new servers with IPv4 or dual-stack mode, convert existing servers to dual-stack, and use IPv6 with service APIs.

### 4.0.41.0 (2025-06-27 19:22 UTC)
* ConfigService (4.0.0.12)
	* Added important considerations to the PutConformancePack and PutOrganizationConformancPack APIs.
* Connect (4.0.3.0)
	* This release adds the following value to an InitiateAs enum: COMPLETED
* Glue (4.0.7.0)
	* AWS Glue now supports schema, partition and sort management of Apache Iceberg tables using Glue SDK
* GuardDuty (4.0.2.0)
	* Update JSON target for Kubernetes workload resource type.
* QConnect (4.0.1.0)
	* Adding UnauthorizedException to public SDK
* RDS (4.0.4.0)
	* StartDBCluster and StopDBCluster can now throw InvalidDBShardGroupStateFault.
* SimpleEmailV2 (4.0.1.0)
	* Added support for new SES regions

### 4.0.40.0 (2025-06-26 18:31 UTC)
* Deadline (4.0.4.0)
	* Added fields to track cumulative task retry attempts for steps and jobs
* EC2 (4.0.15.0)
	* This release adds support for OdbNetworkArn as a target in VPC Route Tables
* IoTManagedIntegrations (4.0.1.0)
	* Adding managed integrations APIs for IoT Device Management to onboard and control devices across different manufacturers, connectivity protocols and third party vendor clouds. APIs include managed thing operations, provisioning profile management, and cloud connector operations.
* KeyManagementService (4.0.3.4)
	* This release updates AWS CLI examples for KMS APIs.
* Keyspaces (4.0.1.0)
	* This release provides change data capture (CDC) streams support through updates to the Amazon Keyspaces API.
* KeyspacesStreams (4.0.0.0)
	* This release adds change data capture (CDC) streams support through the new Amazon Keyspaces Streams API.
* QBusiness (4.0.2.0)
	* Added support for App level authentication for QBusiness DataAccessor using AWS IAM Identity center Trusted Token issuer
* S3 (4.0.3.1)
	* Generate GetBucketRequestPayment, GetBucketTagging, and GetObjectAttributes, GetObjectLegalHold, GetObjectLockConfiguration, GetObjectRetention, GetObjectTagging, GetPublicAccessBlock
* WorkSpaces (4.0.3.0)
	* Updated modifyStreamingProperties to support PrivateLink VPC endpoints for directories

### 4.0.39.0 (2025-06-25 18:27 UTC)
* ECS (4.0.2.2)
	* Updates for change to Amazon ECS default log driver mode from blocking to non-blocking
* FSx (4.0.2.0)
	* Add support for the ability to create Amazon S3 Access Points for Amazon FSx for OpenZFS file systems.
* S3 (4.0.3.0)
	* Adds support for additional server-side encryption mode and storage class values for accessing Amazon FSx data from Amazon S3 using S3 Access Points
* S3Control (4.0.2.0)
	* Add support for the ability to use Amazon S3 Access Points with Amazon FSx for OpenZFS file systems.
* StorageGateway (4.0.1.0)
	* This release adds IPv6 support to the Storage Gateway APIs. APIs that previously only accept or return IPv4 address will now accept or return both IPv4 and IPv6 addresses.
* Textract (4.0.1.0)
	* Add RotationAngle field to Geometry of WORD blocks for Textract AnalyzeDocument API
* WorkSpacesThinClient (4.0.2.0)
	* Remove Tags field from Get API responses

### 4.0.38.0 (2025-06-24 18:33 UTC)
* AIOps (4.0.1.0)
	* Adds support for cross account investigations for CloudWatch investigations AI Operations (AIOps).
* Batch (4.0.1.0)
	* Add userdataType to LaunchTemplateSpecification and LaunchTemplateSpecificationOverride.
* Bedrock (4.0.6.0)
	* We are making ListFoundationModelAgreementOffers, DeleteFoundationModelAgreement, CreateFoundationModelAgreement, GetFoundationModelAvailability, PutUseCaseForModelAccess and GetUseCaseForModelAccess APIs public, previously they were console.
* EC2 (4.0.14.0)
	* This release allows you to create and register AMIs while maintaining their underlying EBS snapshots within Local Zones.
* ElasticLoadBalancingV2 (4.0.1.0)
	* Add Paginator for DescribeAccountLimits, and fix Paginators for DescribeTrustStoreAssociations, DescribeTrustStoreRevocations, and DescribeTrustStores
* GameLift (4.0.1.0)
	* Add support for UDP ping beacons to ListLocations API, including new PingBeacon and UDPEndpoint data types within its Locations return value. Use UDP ping beacon endpoints to help measure real-time network latency for multiplayer games.
* LicenseManager (4.0.2.0)
	* AWS License Manager now supports license type conversions for AWS Marketplace products. Customers can provide Marketplace codes in the source license context or destination license context in the CreateLicenseConversionTaskForResource requests.
* RDS (4.0.3.0)
	* Adding support for RDS on Dedicated Local Zones, including local backup target, snapshot availability zone and snapshot target
* Route53Resolver (4.0.1.0)
	* Add support for iterative DNS queries through the new INBOUND_DELEGATION endpoint. Add delegation support through the Outbound Endpoints with DELEGATE rules.
* TranscribeService (4.0.2.0)
	* This Feature Adds Support for the "et-EE" Locale for Batch Operations

### 4.0.37.0 (2025-06-23 18:23 UTC)
* DynamoDBv2 (4.0.1.9)
	* Fix issue where `ReturnValuesOnConditionCheckFailure` could not be used if the provided document included properties that ended with `code` or `message` (https://github.com/aws/aws-sdk-net/issues/3764).
* Glue (4.0.6.0)
	* AWS Glue now supports sort and z-order strategy for managed automated compaction for Iceberg tables in addition to binpack.
* S3 (4.0.2.1)
	* Generate GetBucketReplication, PutBucketReplication, GetBucketPolicy, GetBucketLocation, GetBucketMetadataTableConfiguration, GetBucketOwnershipControls
	* [Breaking Change] The following public IsSet() methods are now internal: IsSetAccountId() in Amazon.S3.Model.ReplicationDestination. IsSetEncryptionConfiguration() in Amazon.S3.Model.ReplicationDestination, IsSetAccessControlTranslation() in Amazon.S3.Model.ReplicationDestination.
	* [Breaking Change] Priority in Amazon.S3.Model.ReplicationRule changed from int to int?
* S3Tables (4.0.2.0)
	* S3 Tables now supports sort and z-order compaction strategies for Iceberg tables in addition to binpack.
* WorkspacesInstances (4.0.0.0)
	* Added support for Amazon WorkSpaces Instances API
* Core 4.0.0.13
	* Update `JsonErrorResponseUnmarshaller` not to check nested properties when trying to populate details for operations that failed.
	* All services packages updated to require new Core

### 4.0.36.0 (2025-06-20 18:23 UTC)
* Bedrock (4.0.5.0)
	* Add support for tiers in Content Filters and Denied Topics for Amazon Bedrock Guardrails.
* ECS (4.0.2.0)
	* Add ECS support for Windows Server 2025
* GeoPlaces (4.0.1.0)
	* Geocode, ReverseGeocode, and GetPlace APIs added Intersections and SecondaryAddresses. To use, add to the AdditionalFeatures list in your request. This provides info about nearby intersections and secondary addresses that are associated with a main address. Also added MainAddress and ParsedQuery.
* Glue (4.0.5.0)
	* AWS Glue Data Quality now provides aggregated metrics in evaluation results when publishAggregatedMetrics with row-level results are enabled. These metrics include summary statistics showing total counts of processed, passed, and failed rows and rules in a single view.
* MediaConvert (4.0.4.0)
	* This release adds a new SPECIFIED_OPTIMAL option for handling DDS when using DVB-Sub with high resolution video.

### 4.0.35.0 (2025-06-19 18:21 UTC)
* Bedrock (4.0.4.0)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a trained model into Amazon Bedrock for inference.
* EMRServerless (4.0.4.0)
	* This release adds the capability to enable IAM IdentityCenter Trusted Identity Propagation for users running Interactive Sessions on EMR Serverless Applications.
* Lambda (4.0.1.0)
	* Support Schema Registry feature for Kafka Event Source Mapping. Customers can now configure a Schema Registry to enable schema validation and filtering for Avro, Protobuf, and JSON-formatted events in Lambda for Kafka Event Source.
* PaymentCryptography (4.0.1.0)
	* Additional support for managing HMAC keys that adheres to changes documented in X9.143-2021 and provides better interoperability for key import/export
* PaymentCryptographyData (4.0.1.0)
	* Additional support for managing HMAC keys that adheres to changes documented in X9.143-2021 and provides better interoperability for key import/export
* SageMaker (4.0.10.0)
	* This release introduces alternative support for utilizing CFN templates from S3 for SageMaker Projects.

### 4.0.34.0 (2025-06-18 19:03 UTC)
* AIOps (4.0.0.0)
	* This is the initial SDK release for Amazon AI Operations (AIOps). AIOps is a generative AI-powered assistant that helps you respond to incidents in your system by scanning your system's telemetry and quickly surface suggestions that might be related to your issue.
* AutoScaling (4.0.2.0)
	* Add IncludeInstances parameter to DescribeAutoScalingGroups API
* CloudWatchLogs (4.0.4.0)
	* Added CloudWatch Logs Transformer support for converting CloudTrail, VPC Flow, EKS Audit, AWS WAF and Route53 Resolver logs to OCSF v1.1 format.
* S3 (4.0.2.0)
	* Added support for renaming objects within the same bucket using the new RenameObject API.
	* Generate GetBucketAccelerate, PutBucketEncryption, GetBucketEncryption.
* SageMaker (4.0.9.0)
	* Add support for p6-b200 instance type for SageMaker Hyperpod
* Core 4.0.0.12
	* refactor generator to reduce duplication by splitting logic into methods.
	* All services packages updated to require new Core

### 4.0.33.0 (2025-06-17 18:45 UTC)
* AccessAnalyzer (4.0.1.0)
	* We are launching a new analyzer type, internal access analyzer. The new analyzer will generate internal access findings, which help customers understand who within their AWS organization or AWS Account has access to their critical AWS resources.
* Backup (4.0.2.0)
	* AWS Backup is adding support for integration of its logically air-gapped vaults with the AWS Organizations Multi-party approval capability.
* Bedrock (4.0.3.1)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a trained model into Amazon Bedrock for inference.
* CertificateManager (4.0.1.0)
	* Adds support for Exportable Public Certificates
* DatabaseMigrationService (4.0.2.0)
	* Add "Virtual" field to Data Provider as well as "S3Path" and "S3AccessRoleArn" fields to DataProvider settings
* GuardDuty (4.0.1.0)
	* Adding support for extended threat detection for EKS Audit Logs and EKS Runtime Monitoring.
* Inspector2 (4.0.2.0)
	* Add Code Repository Scanning as part of AWS InspectorV2
* MPA (4.0.0.0)
	* This release enables customers to create Multi-party approval teams and approval requests to protect supported operations.
* NetworkFirewall (4.0.4.0)
	* Release of Active Threat Defense in Network Firewall
* Organizations (4.0.1.0)
	* Add support for policy operations on the SECURITYHUB_POLICY policy type.
* SecurityHub (4.0.1.0)
	* Adds operations, structures, and exceptions required for public preview release of Security Hub V2.
* SecurityToken (4.0.1.0)
	* The AWS Security Token Service APIs AssumeRoleWithSAML and AssumeRoleWithWebIdentity can now be invoked without pre-configured AWS credentials in the SDK configuration.
* WAFV2 (4.0.3.0)
	* AWS WAF can now suggest protection packs for you based on the application information you provide when you create a webACL.

### 4.0.32.0 (2025-06-16 18:18 UTC)
* Bedrock (4.0.3.0)
	* This release of the SDK has the API and documentation for the createcustommodel API. This feature lets you copy a Amazon SageMaker trained Amazon Nova model into Amazon Bedrock for inference.
* DynamoDBv2 (4.0.1.7)
	* Add DynamoDBRetryPolicy.WaitBeforeRetryAsync override method in order to use the updated retry logic for async retries.
* ECR (4.0.2.0)
	* The `DescribeImageScanning` API now includes `lastInUseAt` and `InUseCount` fields that can be used to prioritize vulnerability remediation for images that are actively being used.
* NetworkFirewall (4.0.3.0)
	* You can now create firewalls using a Transit Gateway instead of a VPC, resulting in a TGW attachment.
* S3 (4.0.1.7)
	* Generate DeleteBucket, DeleteBucketEncryption and related DeleteBucket operations. Generated AbortMultipartUpload and CreateBucketMetadataTableConfiguration. Delete relevant custom files.
* SageMaker (4.0.8.0)
	* This release 1) adds a new S3DataType Converse for SageMaker training 2)adds C8g R7gd M8g C6in P6 P6e instance type for SageMaker endpoint 3) adds m7i, r7i, c7i instance type for SageMaker Training and Processing.
* Core 4.0.0.11
	* Generate PostMarshallCustomization partial method and make marshallers partial classes for rest-xml protocol services
	* All services packages updated to require new Core

### 4.0.31.0 (2025-06-12 18:24 UTC)
* APIGateway (4.0.1.4)
	* Documentation updates for Amazon API Gateway
* ApiGatewayV2 (4.0.1.4)
	* Documentation updates for Amazon API Gateway
* ConnectCampaignsV2 (4.0.1.0)
	* Added PutInstanceCommunicationLimits and GetInstanceCommunicationLimits APIs
* ECS (4.0.1.7)
	* This Amazon ECS  release supports updating the capacityProviderStrategy parameter in update-service.
* EMRServerless (4.0.3.0)
	* This release adds support for retrieval of the optional executionIamPolicy field in the GetJobRun API response.
* IoTFleetWise (4.0.1.0)
	* Add new status READY_FOR_CHECKIN used for vehicle synchronisation
* KeyManagementService (4.0.3.0)
	* AWS KMS announces the support of ML-DSA key pairs that creates post-quantum safe digital signatures.
* PCS (4.0.3.0)
	* Fixed regex patterns for ARN fields.
* S3 (4.0.1.6)
	* Breaking Change: Fixed MaxBuckets on ListBuckets to use int? instead of int to be consistent with other request properties.
	* Generate ListBuckets and ListDirectoryBuckets. Delete custom files.
* Core 4.0.0.10
	* Fix issue with url encoding for request properties with values that have a majority of characters that need to be percent encoded
	* Generator change to add a comment on collection properties about the V4 change for nullability.
	* All services packages updated to require new Core

### 4.0.30.0 (2025-06-11 18:19 UTC)
* ControlCatalog (4.0.1.0)
	* Introduced ListControlMappings API that retrieves control mappings. Added control aliases and governed resources fields in GetControl and ListControls APIs. New filtering capability in ListControls API, with implementation identifiers and implementation types.
* EKS (4.0.2.0)
	* Release for EKS Pod Identity Cross Account feature and disableSessionTags flag.
* LexModelsV2 (4.0.1.0)
	* Add support for the Assisted NLU feature to improve bot performance
* NetworkManager (4.0.1.0)
	* Add support for public DNS hostname resolution to private IP addresses across Cloud WAN-managed VPCs. Add support for security group referencing across Cloud WAN-managed VPCs.
* RDS (4.0.2.2)
	* Updates Amazon RDS documentation for Amazon RDS for Db2 cross-Region replicas in standby mode.
* WAFV2 (4.0.2.0)
	* WAF now provides two DDoS protection options: resource-level monitoring for Application Load Balancers and the AWSManagedRulesAntiDDoSRuleSet managed rule group for CloudFront distributions.
* Core 4.0.0.9
	* Add `AWSConfigs.AWSCredentialsGenerators` option so that a custom credential resolution order can be specified globally (matching the behavior from `FallbackCredentialsFactory.CredentialsGenerators`)
	* Updating partitions.json file.
	* All services packages updated to require new Core

### 4.0.29.1 (2025-06-10 18:11 UTC)
* GameLiftStreams (4.0.0.6)
	* Documentation updates for Amazon GameLift Streams to address formatting errors, correct resource ID examples, and update links to other guides
* Core 4.0.0.8
	* Fixed Document.cs serialization issue that caused WebAuthn operations to fail when response contained Dictionary structures [issue 3837](https://github.com/aws/aws-sdk-net/issues/3837)
	* Fixed issue with public IsSet properties not working correctly for collection properties when set to false.
	* All services packages updated to require new Core

### 4.0.29.0 (2025-06-09 18:25 UTC)
* AppSync (4.0.1.0)
	* Deprecate `atRestEncryptionEnabled` and `transitEncryptionEnabled` attributes in `CreateApiCache` action. Encryption is always enabled for new caches.
* CostExplorer (4.0.2.0)
	* Support dual-stack endpoints for ce api
* CustomerProfiles (4.0.1.0)
	* This release introduces capability of Profile Explorer, using correct ingestion timestamp & using historical data for computing calculated attributes, and new standard objects for T&H as part of Amazon Connect Customer Profiles service.
* EC2 (4.0.13.0)
	* Release to support Elastic VMware Service (Amazon EVS) Subnet and Amazon EVS Network Interface Types.
* ElasticFileSystem (4.0.1.0)
	* Added support for Internet Protocol Version 6 (IPv6) on EFS Service APIs and mount targets.
* MarketplaceCatalog (4.0.1.0)
	* The ListEntities API now supports the EntityID, LastModifiedDate, ProductTitle, and Visibility filters for machine learning products. You can also sort using all of those filters.
* WorkSpacesThinClient (4.0.1.0)
	* Add ConflictException to UpdateEnvironment API

### 4.0.28.0 (2025-06-06 18:28 UTC)
* BedrockAgentRuntime (4.0.4.0)
	* This release introduces the `PromptCreationConfigurations` input parameter, which includes fields to control prompt population for `InvokeAgent` or `InvokeInlineAgent` requests.
* KeyManagementService (4.0.2.0)
	* Remove unpopulated KeyMaterialId from Encrypt Response
* RDS (4.0.2.0)
	* Include Global Cluster Identifier in DBCluster if the DBCluster is a Global Cluster Member.
* Rekognition (4.0.1.0)
	* Adds support for defining an ordered preference list of different Rekognition Face Liveness challenge types when calling CreateFaceLivenessSession.
* Route53 (4.0.1.0)
	* Amazon Route 53 now supports the Asia Pacific (Taipei) Region (ap-east-2) for latency records, geoproximity records, and private DNS for Amazon VPCs in that region.
* S3Tables (4.0.1.0)
	* S3 Tables now supports getting details about a table via its table ARN.
* SQS (4.0.0.6)
	* Fix `GetQueueAttributesResponse` to handle attributes potentially being null (https://github.com/aws/aws-sdk-net/pull/3852)

### 4.0.27.0 (2025-06-05 18:21 UTC)
* BCMPricingCalculator (4.0.2.0)
	* Updating the minimum for List APIs to be 1 (instead of 0)
* CloudFormation (4.0.1.0)
	* Add new warning type 'EXCLUDED_PROPERTIES'
* DynamoDBv2 (4.0.1.3)
	* Introduce support for the [DynamoDbFlatten] attribute in the DynamoDB Object Persistence Model`
* KeyManagementService (4.0.1.0)
	* AWS KMS announces the support for on-demand rotation of symmetric-encryption KMS keys with imported key material (EXTERNAL origin).
* WAFV2 (4.0.1.0)
	* AWS WAF adds support for ASN-based traffic filtering and support for ASN-based rate limiting.

### 4.0.26.0 (2025-06-04 18:23 UTC)
* Amplify (4.0.1.1)
	* Update documentation for cacheConfig in CreateApp API
* Evs (4.0.0.0)
	* Amazon Elastic VMware Service (Amazon EVS) allows you to run VMware Cloud Foundation (VCF) directly within your Amazon VPC including simplified self-managed migration experience with guided workflow in AWS console or via AWS CLI, get full access to their VCF deployment and VCF license portability.
* Invoicing (4.0.1.0)
	* Added new Invoicing ListInvoiceSummaries API Operation
* MediaConnect (4.0.1.0)
	* This release updates the DescribeFlow API to show peer IP addresses. You can now identify the peer IP addresses of devices connected to your sources and outputs. This helps you to verify and troubleshoot your flow's active connections.
* MediaConvert (4.0.3.0)
	* This release includes support for embedding and signing C2PA content credentials in MP4 outputs.
* NetworkFirewall (4.0.2.0)
	* You can now monitor flow and alert log metrics from the Network Firewall console.
* SageMaker (4.0.7.0)
	* Added support for p6-b200 instance type in SageMaker Training Jobs and Training Plans.
* TranscribeService (4.0.1.0)
	* AWS Healthscribe now supports new templates for the clinical note summary: BIRP, SIRP, DAP, BEHAVIORAL_SOAP, and PHYSICAL_SOAP
* TranscribeStreaming (4.0.1.0)
	* AWS Healthscribe now supports new templates for the clinical note summary: BIRP, SIRP, DAP, BEHAVIORAL_SOAP, and PHYSICAL_SOAP
* Core 4.0.0.7
	* Add x-amzn-query-mode header and query compatible tests. The sdk will send a new header x-amzn-query-mode, if the service has the awsQueryCompatibleTrait applied to it. This is to inform the service that the client is running in query compatible mode.
	* All services packages updated to require new Core

### 4.0.25.0 (2025-06-03 18:25 UTC)
* APIGateway (4.0.1.0)
	* Adds support to set the routing mode for a custom domain name.
* ApiGatewayV2 (4.0.1.0)
	* Adds support to create routing rules and set the routing mode for a custom domain name.
* DynamoDBv2 (4.0.1.1)
	* Exposed ScannedCount property on the Search class within the Document Model.
	* Introduce support for the [DynamoDBAtomicCounter] attribute in the DynamoDB Object Persistence Model`
* EMRServerless (4.0.2.0)
	* AWS EMR Serverless: Adds a new option in the CancelJobRun API in EMR 7.9.0+, to cancel a job with grace period. This feature is enabled by default with a 120-second grace period for streaming jobs and is not enabled by default for batch jobs.
* S3 (4.0.1.2)
	* Changing S3 bucket names to preferred values in example documentation.

### 4.0.24.0 (2025-06-02 18:22 UTC)
* Athena (4.0.1.0)
	* Add support for the managed query result in the workgroup APIs. The managed query result configuration enables users to store query results to Athena owned storage.
* Backup (4.0.1.0)
	* You can now subscribe to Amazon SNS notifications and Amazon EventBridge events for backup indexing. You can now receive notifications when a backup index is created, deleted, or fails to create, enhancing your ability to monitor and track your backup operations.
* BedrockAgent (4.0.3.0)
	* This release adds the Agent Lifecycle Paused State feature to Amazon Bedrock agents. By using an agent's alias, you can temporarily suspend agent operations during maintenance, updates, or other situations.
* ComputeOptimizer (4.0.1.0)
	* This release enables AWS Compute Optimizer to analyze Amazon Aurora database clusters and generate Aurora I/O-Optimized recommendations.
* CostOptimizationHub (4.0.2.0)
	* Support recommendations for Aurora instance and Aurora cluster storage.
* ECS (4.0.1.3)
	* Updates Amazon ECS documentation to include note for upcoming default log driver mode change.
* EKS (4.0.1.0)
	* Add support for filtering ListInsights API calls on MISCONFIGURATION insight category
* EntityResolution (4.0.1.0)
	* Add support for generating match IDs in near real-time.
* PCS (4.0.2.0)
	* Introduces SUSPENDING and SUSPENDED states for clusters, compute node groups, and queues.
* Synthetics (4.0.4.0)
	* Support for Java runtime handler pattern.

### 4.0.23.0 (2025-05-30 18:19 UTC)
* EMRServerless (4.0.1.0)
	* This release adds the capability for users to specify an optional Execution IAM policy in the StartJobRun action. The resulting permissions assumed by the job run is the intersection of the permissions in the Execution Role and the specified Execution IAM Policy.
* S3 (4.0.1.1)
	* Fixed an issue where CancellationToken for async call was not passed along in underlying invocations while uploading unseekable steam using Multipart Upload.
* SageMaker (4.0.6.0)
	* Release new parameter CapacityReservationConfig in ProductionVariant

### 4.0.22.0 (2025-05-29 18:31 UTC)
* Amplify (4.0.1.0)
	* Add support for customizable build instance sizes. CreateApp and UpdateApp operations now accept a new JobConfig parameter composed of BuildComputeType.
* AutoScaling (4.0.1.0)
	* Add support for "apple" CpuManufacturer in ABIS
* BCMPricingCalculator (4.0.1.0)
	* Add AFTER_DISCOUNTS_AND_COMMITMENTS to Workload Estimate Rate Type. Set ListWorkLoadEstimateUsage maxResults range to minimum of 0 and maximum of 300.
* CloudFormation (4.0.0.5)
	* Fixed an issue where NullReferenceException was thrown while invoking AmazonCloudFormationClient.UpdateStackAsync().
* CloudTrail (4.0.1.0)
	* CloudTrail Feature Release: Support for Enriched Events with Configurable Context for Event Data Store
* Connect (4.0.2.0)
	* Amazon Connect Service Feature: Email Recipient Limit Increase
* DataExchange (4.0.1.0)
	* This release adds Tag support for Event Action resource, through which customers can create event actions with Tags and retrieve event actions with Tags.
* DataSync (4.0.2.0)
	* AgentArns field is made optional for Object Storage and Azure Blob location create requests. Location credentials are now managed via Secrets Manager, and may be encrypted with service managed or customer managed keys. Authentication is now optional for Azure Blob locations.
* FSx (4.0.1.0)
	* FSx API changes to support the public launch of new Intelligent Tiering storage class on Amazon FSx for Lustre
* IVSRealTime (4.0.1.0)
	* IVS Real-Time now offers customers the participant replication that allow customers to copy a participant from one stage to another.
* MWAA (4.0.1.0)
	* Amazon MWAA now lets you choose a worker replacement strategy when updating an environment. This release adds two worker replacement strategies: FORCED (default), which stops workers immediately, and GRACEFUL, which allows workers to finish current tasks before shutting down.
* S3 (4.0.1.0)
	* Adding checksum support for S3 PutBucketOwnershipControls API.
	* Fixed an issue where NullReferenceException was thrown when calling AddPartETags() on CompleteMultipartUploadRequest object.
* SageMaker (4.0.5.0)
	* Add maintenance status field to DescribeMlflowTrackingServer API response

### 4.0.21.0 (2025-05-28 18:20 UTC)
* CostOptimizationHub (4.0.1.0)
	* This release allows customers to modify their preferred commitment term and payment options.
* EC2 (4.0.12.0)
	* Enable the option to automatically delete underlying Amazon EBS snapshots when deregistering Amazon Machine Images (AMIs)
* EventBridge (4.0.1.0)
	* Allow for more than 2 characters for location codes in EventBridge ARNs
* NetworkFirewall (4.0.1.0)
	* You can now use VPC endpoint associations to create multiple firewall endpoints for a single firewall.
* Synthetics (4.0.3.0)
	* Add support to change ephemeral storage. Add a new field "TestResult" under CanaryRunStatus.

### 4.0.20.0 (2025-05-27 18:20 UTC)
* CostExplorer (4.0.1.0)
	* This release introduces Cost Comparison feature (GetCostAndUsageComparisons, GetCostComparisonDrivers) allowing you find cost variations across multiple dimensions and identify key drivers of spending changes.
* Deadline (4.0.3.0)
	* AWS Deadline Cloud service-managed fleets now support storage profiles. With storage profiles, you can map file paths between a workstation and the worker hosts running the job.
* EC2 (4.0.11.0)
	* This release adds three features - option to store AWS Site-to-Site VPN pre-shared keys in AWS Secrets Manager, GetActiveVpnTunnelStatus API to check the in-use VPN algorithms, and SampleType option in GetVpnConnectionDeviceSampleConfiguration API to get recommended sample configs for VPN devices.

### 4.0.19.0 (2025-05-23 18:15 UTC)
* EC2 (4.0.10.0)
	* This release adds support for the C7i-flex, M7i-flex, I7i, I7ie, I8g, P6-b200, Trn2, C8gd, M8gd and R8gd instances
* S3 (4.0.0.7)
	* Fix: Fixed a bug where Content-Type header was being overwritten in multipart upload scenarios.
* SecurityIR (4.0.1.0)
	* Update PrincipalId pattern documentation to reflect what user should receive back from the API call

### 4.0.18.0 (2025-05-22 18:14 UTC)
* AuditManager (4.0.1.0)
	* With this release, the AssessmentControl description field has been deprecated, as of May 19, 2025. Additionally, the UpdateAssessment API can now return a ServiceQuotaExceededException when applicable service quotas are exceeded.
* DSQL (4.0.3.0)
	* Features: support for customer managed encryption keys
* Glue (4.0.4.0)
	* This release supports additional ConversionSpec parameter as part of IntegrationPartition Structure in CreateIntegrationTableProperty API. This parameter is referred to apply appropriate column transformation for columns that are used for timestamp based partitioning
* PrometheusService (4.0.1.0)
	* Add QueryLoggingConfiguration APIs for Amazon Managed Prometheus

### 4.0.17.0 (2025-05-21 18:16 UTC)
* ApplicationAutoScaling (4.0.0.5)
	* Doc only update that addresses a customer reported issue.
* BedrockAgentRuntime (4.0.3.0)
	* Amazon Bedrock introduces asynchronous flows (in preview), which let you run flows for longer durations and yield control so that your application can perform other tasks and you don't have to actively monitor the flow's progress.
* CloudWatch (4.0.1.0)
	* Adds support for setting up Contributor Insight rules on logs transformed via Logs Transformation feature.
* EC2 (4.0.9.0)
	* Release of Dualstack and Ipv6-only EC2 Public DNS hostnames
* PartnerCentralSelling (4.0.1.0)
	* Modified validation to allow expectedCustomerSpend array with zero elements in Partner Opportunity operations.
* S3 (4.0.0.6)
	* Fixed an issue where IAmazonS3.EnsureBucketExists(Async) was throwing an exception if S3 bucket already exists in the executing account.
* Core 4.0.0.6
	* Fixed an issue in JsonPolicyWriter.WritePolicyToString() method where it was not using prettyPrint parameter for indentation.

### 4.0.16.0 (2025-05-20 18:19 UTC)
* DataSync (4.0.1.0)
	* Remove Discovery APIs from the DataSync service
* DynamoDBv2 (4.0.1.0)
	* Introduce a fluent ExpressionBuilder to the Document Model that uses method chaining to construct type-safe, readable condition and update expressions.
* EC2 (4.0.8.0)
	* This release expands the ModifyInstanceMaintenanceOptions API to enable or disable instance migration during customer-initiated reboots for EC2 Scheduled Reboot Events.
* Glue (4.0.3.0)
	* Enhanced AWS Glue ListConnectionTypes API Model with additional metadata fields.
* Inspector2 (4.0.1.0)
	* This release adds GetClustersForImage API and filter updates as part of the mapping of container images to running containers feature.
* OAM (4.0.1.0)
	* Add IncludeTags field to GetLink, GetSink and UpdateLink API
* Private5G (Removed)
	* Removed Amazon Private5G from the SDK because the service has been shutdown.
* RDS (4.0.1.0)
	* This release introduces the new DescribeDBMajorEngineVersions API for describing the properties of specific major versions of database engines.

### 4.0.15.0 (2025-05-19 18:12 UTC)
* DSQL (4.0.2.0)
	* CreateMultiRegionCluster and DeleteMultiRegionCluster APIs removed
* EC2 (4.0.7.0)
	* This release includes new APIs for System Integrity Protection (SIP) configuration and automated root volume ownership delegation for EC2 Mac instances.
* MediaPackageV2 (4.0.1.0)
	* This release adds support for DVB-DASH, EBU-TT-D subtitle format, and non-compacted manifests for DASH in MediaPackage v2 Origin Endpoints.

### 4.0.14.0 (2025-05-16 18:40 UTC)
* BedrockDataAutomation (4.0.2.0)
	* Add support for VIDEO modality to BlueprintType enum.
* BedrockDataAutomationRuntime (4.0.1.0)
	* Add AssetProcessingConfiguration for video segment to InputConfiguration
* CodePipeline (4.0.2.0)
	* CodePipeline now supports new API ListDeployActionExecutionTargets that lists the deployment target details for deploy action executions.
* DynamoDBv2 (4.0.0.6)
	* Fixed NullReferenceException in Query using SelectValues.Count
* ECS (4.0.1.2)
	* This is an Amazon ECs documentation only release to support the change of the container exit "reason" field from 255 characters to 1024 characters.
* ElasticMapReduce (4.0.1.0)
	* Added APIs for managing Application UIs: Access Persistent (serverless) UIs via CreatePersistentAppUI DescribePersistentAppUI & GetPersistentAppUIPresignedURL, and Cluster-based UIs through GetOnClusterAppUIPresignedURL. Supports Yarn, Spark History, and TEZ interfaces.
* Glue (4.0.2.0)
	* Changes include (1) Excel as S3 Source type and XML and Tableau's Hyper as S3 Sink types, (2) targeted number of partitions parameter in S3 sinks and (3) new compression types in CSV/JSON and Parquet S3 sinks.
* Neptune (4.0.1.0)
	* This release adds Global Cluster Switchover capability which enables you to change your global cluster's primary AWS Region, the region that serves writes, while preserving the replication between all regions in the global cluster.
* ServiceQuotas (4.0.1.0)
	* This release introduces CreateSupportCase operation to SDK.
* Core 4.0.0.5
	* Add the ConnectTimeout property on the service client config for the .NET 8 target of the SDK.
	* All services packages updated to require new Core

### 4.0.13.0 (2025-05-15 18:27 UTC)
* BedrockAgent (4.0.2.0)
	* Amazon Bedrock Flows introduces DoWhile loops nodes, parallel node executions, and enhancements to knowledge base nodes.
* CodeBuild (4.0.1.0)
	* AWS CodeBuild now supports Docker Server capability
* ControlTower (4.0.1.1)
	* Updated the descriptions for the AWS Control Tower Baseline APIs to make them more intuitive.
* DatabaseMigrationService (4.0.1.0)
	* Introduces Data Resync feature to describe-table-statistics and IAM database authentication for MariaDB, MySQL, and PostgreSQL.
* PCS (4.0.1.0)
	* This release adds support for Slurm accounting. For more information, see the Slurm accounting topic in the AWS PCS User Guide. Slurm accounting is supported for Slurm 24.11 and later. This release also adds 24.11 as a valid value for the version parameter of the Scheduler data type.
* WorkSpaces (4.0.2.0)
	* Added the new AlwaysOn running mode for WorkSpaces Pools. Customers can now choose between AlwaysOn (for instant access, with hourly usage billing regardless of connection status), or AutoStop (to optimize cost, with a brief startup delay) for their pools.
* Core 4.0.0.4
	* Fixed issue when model properties had customization exposing IsSet methods that empty collections would not be sent as part of the request. For example the L and M properties of AttributeValue in DynamoDB.
	* All services packages updated to require new Core

### 4.0.12.0 (2025-05-14 18:22 UTC)
* CloudWatchLogs (4.0.3.0)
	* This release adds a new API "ListLogGroups" and an improvement in API "DescribeLogGroups"
* CognitoIdentityProvider (4.0.1.0)
	* Add exceptions to WebAuthn operations.
* KinesisFirehose (4.0.1.0)
	* This release adds catalogARN support for s3 tables multi-catalog catalogARNs.
* MediaConvert (4.0.2.0)
	* This update enables cropping for video overlays and adds a new STL to Teletext upconversion toggle to preserve styling.

### 4.0.11.0 (2025-05-13 18:23 UTC)
* Bedrock (4.0.2.0)
	* Enable cross-Region inference for Amazon Bedrock Guardrails by using the crossRegionConfig parameter when calling the CreateGuardrail or UpdateGuardrail operation.
* BedrockAgentRuntime (4.0.2.0)
	* Changes for enhanced metadata in trace
* ControlTower (4.0.1.0)
	* AWS Control Tower now reports the inheritance drift status for EnabledBaselines through the GetEnabledBaseline and ListEnabledBaselines APIs. You can now filter EnabledBaselines by their enablement and drift status using the ListEnabledBaselines API to view accounts and OUs that require attention.
* DSQL (4.0.1.0)
	* CreateMultiRegionClusters and DeleteMultiRegionClusters APIs marked as deprecated. Introduced new multi-Region clusters creation experience through multiRegionProperties parameter in CreateCluster API.
* ECS (4.0.1.0)
	* This release extends functionality for Amazon EBS volumes attached to Amazon ECS tasks by adding support for the new EBS volumeInitializationRate parameter in ECS RunTask/StartTask/CreateService/UpdateService APIs.
* LicenseManager (4.0.1.0)
	* Add Tagging feature to resources in the Managed Entitlements service. License and Grant resources can now be tagged.

### 4.0.10.0 (2025-05-12 18:28 UTC)
* Deadline (4.0.2.0)
	* AWS Deadline Cloud service-managed fleets now support configuration scripts. Configuration scripts make it easy to install additional software, like plugins and packages, onto a worker.
* DynamoDBv2 (4.0.0.4)
	* Fix regression where an `Expression` could not be used without `ExpressionAttributeValues` (https://github.com/aws/aws-sdk-net/issues/3802)
* EC2 (4.0.6.0)
	* EC2 - Adding support for AvailabilityZoneId
* IdentityManagement (4.0.1.0)
	* Updating the endpoint list for the Identity and access management (IAM) service
* MediaLive (4.0.2.0)
	* Add support to the AV1 rate control mode
* MediaTailor (4.0.1.0)
	* Documenting that EnabledLoggingStrategies is always present in responses of PlaybackConfiguration read operations.
* S3Control (4.0.1.0)
	* Updates to support S3 Express zonal endpoints for directory buckets in AWS CLI
* SageMaker (4.0.4.0)
	* No API changes from previous release. This release migrated the model to Smithy keeping all features unchanged.
* SupplyChain (4.0.1.0)
	* Launch new AWS Supply Chain public APIs for DataIntegrationEvent, DataIntegrationFlowExecution and DatasetNamespace. Also add more capabilities to existing public APIs to support direct dataset event publish, data deduplication in DataIntegrationFlow, partition specification of custom datasets.

### 4.0.9.0 (2025-05-09 18:19 UTC)
* Athena (4.0.0.3)
	* Minor API documentation updates
* CloudWatchLogs (4.0.2.0)
	* We are pleased to announce limit increases to our grok processor logs transformation feature. Now you can define 20 Grok patterns in their configurations, with an expanded total pattern matching limit of 512 characters.
* Synthetics (4.0.2.0)
	* Add support to retry a canary automatically after schedule run failures. Users can enable this feature by configuring the RetryConfig field when calling the CreateCanary or UpdateCanary API. Also includes changes in GetCanary and GetCanaryRuns to support retrieving retry configurations.
* WorkSpaces (4.0.1.0)
	* Remove parameter EnableWorkDocs from WorkSpacesServiceModel due to end of support of Amazon WorkDocs service.

### 4.0.8.0 (2025-05-08 18:24 UTC)
* CloudFront (4.0.0.3)
	* Doc-only update for CloudFront. These changes include customer-reported issues.
* CodePipeline (4.0.1.0)
	* Add support for Secrets Manager and Plaintext environment variable types in Commands action
* EC2 (4.0.5.0)
	* Launching the feature to support ENA queues offering flexibility to support multiple queues per Enhanced Network Interface (ENI)
* Glue (4.0.1.0)
	* This new release supports customizable RefreshInterval for all Saas ZETL integrations from 15 minutes to 6 days.
* GuardDuty (4.0.0.3)
	* Updated description of a data structure.
* SSOAdmin (4.0.1.0)
	* Update PutPermissionBoundaryToPermissionSet API's managedPolicyArn pattern to allow valid ARN only. Update ApplicationName to allow white spaces.

### 4.0.7.0 (2025-05-07 18:23 UTC)
* EC2 (4.0.4.0)
	* This release adds API support for Path Component Exclusion (Filter Out ARN) for Reachability Analyzer
* Imagebuilder (4.0.0.3)
	* Updated the CreateImageRecipeRequest ParentImage description to include all valid values as updated with the SSM Parameters project.
* MediaLive (4.0.1.0)
	* Enables Updating Anywhere Settings on a MediaLive Anywhere Channel.
* S3 (4.0.0.3)
	* Fix regression where presigned URLs could not be created when using a custom `ServiceURL`.
* SageMaker (4.0.3.0)
	* SageMaker AI Studio users can now migrate to SageMaker Unified Studio, which offers a unified web-based development experience that integrates AWS data, analytics, artificial intelligence (AI), and machine learning (ML) services, as well as additional tools and resource
* Synthetics (4.0.1.0)
	* Add support to test a canary update by invoking a dry run of a canary. This behavior can be used via the new StartCanaryDryRun API along with new fields in UpdateCanary to apply dry run changes. Also includes changes in GetCanary and GetCanaryRuns to support retrieving dry run configurations.

### 4.0.6.0 (2025-05-06 18:20 UTC)
* EC2 (4.0.3.0)
	* This release adds support for Amazon EBS Provisioned Rate for Volume Initialization, which lets you specify a volume initialization rate to ensure that your EBS volumes are initialized in a predictable amount of time.
* ServiceCatalog (4.0.1.0)
	* ServiceCatalog's APIs (DeleteServiceAction, DisassociateServiceActionFromProvisioningArtifact, AssociateServiceActionWithProvisioningArtifact) now throw InvalidParametersException when IdempotencyToken is invalid.
* TimestreamQuery (4.0.1.0)
	* Add dualstack endpoints support and correct us-gov-west-1 FIPS endpoint.
* TimestreamWrite (4.0.1.0)
	* Add dualstack endpoints support.
* Core 4.0.0.3
	* Fix regression where `Amazon.Auth.AccessControlPolicy.Policy.FromJson` was not correctly handling objects in the `Principal` property (https://github.com/aws/aws-sdk-net/issues/3791)
	* All services packages updated to require new Core

### 4.0.5.0 (2025-05-05 18:22 UTC)
* DataZone (4.0.1.0)
	* This release adds a new authorization policy to control the usage of custom AssetType when creating an Asset. Customer can now add new grant(s) of policyType USE_ASSET_TYPE for custom AssetTypes to apply authorization policy to projects members and domain unit owners.
* DeviceFarm (4.0.1.0)
	* Add an optional parameter to the GetDevicePoolCompatibility API to pass in project information to check device pool compatibility.
* EC2 (4.0.2.0)
	* This update introduces API operations to manage and create local gateway VIF and VIF groups. It also includes API operations to describe Outpost LAGs and service link VIFs.
* ECS (4.0.0.2)
	* Add support to roll back an In_Progress ECS Service Deployment
* MediaConvert (4.0.1.0)
	* This release adds an optional sidecar per-frame video quality metrics report and an ALL_PCM option for audio selectors. It also changes the data type for Probe API response fields related to video and audio bitrate from integer to double.

### 4.0.4.0 (2025-05-02 18:16 UTC)
* BedrockDataAutomation (4.0.1.0)
	* Added support for Custom output and blueprints for AUDIO data types.
* DirectoryService (4.0.0.2)
	* Doc only update - fixed typos.
* Kinesis (4.0.2.0)
	* Marking ResourceARN as required for Amazon Kinesis Data Streams APIs TagResource, UntagResource, and ListTagsForResource.

### 4.0.3.0 (2025-05-01 19:35 UTC)
* AppConfig (4.0.1.0)
	* Adding waiter support for deployments and environments; documentation updates
* Connect (4.0.1.0)
	* This release adds the following fields to DescribeContact: DisconnectReason, AgentInitiatedHoldDuration, AfterContactWorkStartTimestamp, AfterContactWorkEndTimestamp, AfterContactWorkDuration, StateTransitions, Recordings, ContactDetails, ContactEvaluations, Attributes
* SageMaker (4.0.2.0)
	* Feature - Adding support for Scheduled and Rolling Update Software in Sagemaker Hyperpod.
* VerifiedPermissions (4.0.1.0)
	* Amazon Verified Permissions / Features : Adds support for tagging policy stores.

### 4.0.2.0 (2025-04-30 18:35 UTC)
* Bedrock (4.0.1.0)
	* You can now specify a cross region inference profile as a teacher model for the CreateModelCustomizationJob API. Additionally, the GetModelCustomizationJob API has been enhanced to return the sub-task statuses of a customization job within the StatusDetails response field.
* BedrockAgent (4.0.1.0)
	* Features:    Add inline code node to prompt flow
* BedrockAgentRuntime (4.0.1.0)
	* Support for Custom Orchestration within InlineAgents
* CleanRooms (4.0.1.0)
	* This release adds support for ProtectedQuery results to be delivered to more than one collaboration member via the new distribute output configuration in StartProtectedQuery.
* CloudWatchLogs (4.0.1.0)
	* CloudWatch Logs supports "DELIVERY" log class. This log class is used only for delivering AWS Lambda logs to Amazon S3 or Amazon Data Firehose.
* Deadline (4.0.1.0)
	* Adds support for tag management on workers and tag inheritance from fleets to their associated workers.
* EC2 (4.0.1.0)
	* Launch of cost distribution feature for IPAM owners to distribute costs to internal teams.
* ECR (4.0.1.0)
	* Adds dualstack support for Amazon Elastic Container Registry (Amazon ECR).
* ECRPublic (4.0.1.0)
	* Adds dualstack support for Amazon Elastic Container Registry Public (Amazon ECR Public).
* MailManager (4.0.1.0)
	* Introducing new RuleSet rule PublishToSns action, which allows customers to publish email notifications to an Amazon SNS topic. New PublishToSns action enables customers to easily integrate their email workflows via Amazon SNS, allowing them to notify other systems about important email events.
* Core 4.0.0.2
	* Set assembly version for all targets to fixed 4.0 version number to avoid binding issues. The assembly file version should be used to understand the version of the assembly.
	* All services packages updated to require new Core

### 4.0.1.0 (2025-04-29 20:03 UTC)
* ConnectCases (4.0.1.0)
	* Introduces CustomEntity as part of the UserUnion data type. This field is used to indicate the entity who is performing the API action.
* DynamoDBv2 (4.0.0.1)
	* Update endpoint resolver to handle anonymous credentials when trying to retrieve account IDs
* Kinesis (4.0.1.0)
	* Amazon KDS now supports tagging and attribute-based access control (ABAC) for enhanced fan-out consumers.
* PinpointSMSVoiceV2 (4.0.1.0)
	* AWS End User Messaging has added MONITOR and FILTER functionality to SMS Protect.
* QBusiness (4.0.1.0)
	* Add support for anonymous user access for Q Business applications
* SageMaker (4.0.1.0)
	* Introduced support for P5en instance types on SageMaker Studio for JupyterLab and CodeEditor applications.
* SageMakerMetrics (4.0.1.0)
	* SageMaker Metrics Service now supports FIPS endpoint in all US and Canada Commercial regions.
* SimpleSystemsManagement (4.0.1.0)
	* This release adds support for just-In-time node access in AWS Systems Manager. Just-in-time node access enables customers to move towards zero standing privileges by requiring operators to request access and obtain approval before remotely connecting to nodes managed by the SSM Agent.
* SSMGuiConnect (4.0.0.0)
	* This release adds API support for the connection recording GUI Connect feature of AWS Systems Manager
* Core 4.0.0.1
	* chore: Move AWSSDK.Extensions.Bedrock.MEAI to a preview version 

### 4.0.0.0 (2025-04-28 18:14 UTC)
* BedrockRuntime (4.0.0.0)
	* This release adds native h2 support for the bedrock runtime API, the support is only limited to SDKs that support h2 requests natively.
* CertificateManager (4.0.0.0)
	* Add support for file-based HTTP domain control validation, available through Amazon CloudFront.
* CloudFront (4.0.0.0)
	* Add distribution tenant, connection group, and multi-tenant distribution APIs to the CloudFront SDK.
* DynamoDBv2 (4.0.0.0)
	* Doc only update for GSI descriptions.
	* Update paginators to handle scenarios where the token is a collection (that's null by default in V4)
	* Fixed trim warnings in Object Persistence high level library introduced by PR adding polymorphic support.
* Imagebuilder (4.0.0.0)
	* Add integration with SSM Parameter Store to Image Builder.
* Core 4.0.0.0
	* [Breaking Change] Allow source_profile to be used in conjunction with sso_session. If the profile specified via source_profile has sso_session, and the sso_session section is correctly configured, credentials will be retrieved from sso. The sso credentials will then be used to assume the role specified in the original profile. Previous behavior was that it assumed the role specified in source_profile, which does not follow the assume role profile chaining pattern.
	* Add observability feature IDs to User Agent header
	* fix: User-Agent header is growing when reusing the request object
	* Remove unused internal legacy .NET Framework 3.5 code.
	* Update documentation for the `AWSConfigs.InitializeCollections` property to specify the correct default value for V4 (and how to restore the V3 behavior)
	* Update SDK to respect `Profile` property set in the client config when resolving credentials.
	* All services packages updated to require new Core

### 4.0.0.0-preview.13 (2025-04-09 16:44 UTC)
* BedrockRuntime (4.0.0.0)
	* Add support for [Amazon Nova Sonic: Human-like voice conversations for generative AI applications](https://aws.amazon.com/blogs/aws/introducing-amazon-nova-sonic-human-like-voice-conversations-for-generative-ai-applications/) (note: Only available in .NET 8 and later)
* DynamoDBv2 (4.0.0.0)
	* Allow to set DynamoDBEntryConversion per table.
* Core 4.0.0.0
	* Enable error protocol tests and make headers case insensitive in test project
	* Update auth resolver async flow to add user agent details after resolving identity
	* All services packages updated to require new Core

### 4.0.0.0-preview.12 (2025-04-04 17:58 UTC)
* Kinesis (4.0.0.0)
	* Add the bi-directional streaming operation SubscribeToShard.
* LexRuntimeV2 (4.0.0.0)
	* Add the bi-directional streaming operation StartConversation.
* QBusiness (4.0.0.0)
	* Add the bi-directional streaming operation Chat.
* S3 (4.0.0.0)
	* Update remaining value types to be nullable.
* TranscribeStreaming (4.0.0.0)
	* Initial release of the TranscribeStreaming service package.
* Core 4.0.0.0
	* [Breaking Change] Move IEventStreamEvent to Amazon.Runtime.EventStreams namespace from Amazon.Runtime.EventStreams.Internal
	* [Breaking Change] Renamed IEventStream to IEventOutputStream and IEnumerableEventStream to IEnumerableEventOutputStream
	* Add core support for bi directional HTTP 2 service operations. Support is only available in .NET 8 and later.
	* [Breaking Change] Changed the default value of SSOAWSCredentialsOptions.SupportsGettingNewToken as false and improved error messaging if required SSO options are missing while generating new credentials.
	* Fix `EndpointDiscoveryHandler` not to fail when a request contains bearer token credentials.
	* Log a warning when `ServiceUrl` and `RegionEndpoint` are set at the same time. The SDK will log whichever of the two is used.
	* Remove redundant `AWSSignerType` attribute from service configuration classes.
	* Support Account ID based endpoints. Account-based endpoints help ensure high performance and scalability by using your AWS account ID to route requests for services that support this feature. For more information visit [account id based endpoints on our docs](https://docs.aws.amazon.com/sdkref/latest/guide/feature-account-endpoints.html).
	* Update the AWS SDK for .NET to include encoded metrics in the `User-Agent` header to track which features were used for a given request (for example, which retry behavior and how credentials were resolved)
	* All services packages updated to require new Core

### 4.0.0.0-preview.11 (2025-03-26 12:13 UTC)
* DynamoDBStreams (4.0.0.0)
	* Update documentation for code generated from DynamoDB Streams models
* S3 (4.0.0.0)
	* Fix a bug where `CopyObject` wasn't working with some special characters.
* SecurityToken (4.0.0.0)
	* Added async code paths for the SAML and Assume role credentials providers.
* Core 4.0.0.0
	* Add telemetry data for Credentials retrieval
	* Fixed protocol test `RestJsonSerializesSparseNullMapValues` by adding proper null value handling in sparse map serialization
	* Updated `Microsoft.Extensions.AI` to `9.3.0-preview.1.25161.3` in the `AWSSDK.Extensions.Bedrock.MEAI` package
	* Updated credential providers to provide Async version for generating credentials.
	* All services packages updated to require new Core

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

