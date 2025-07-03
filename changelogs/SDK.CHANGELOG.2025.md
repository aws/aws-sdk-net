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

