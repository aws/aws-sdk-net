### 4.0.260.0 (2026-06-02 18:32 UTC)
* AWSMarketplaceMetering (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* CloudWatch (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* EC2 (4.0.91.0)
	* Amazon EC2 now supports self-service cancellation of future-dated Capacity Reservations. A cancellation charge applies based on remaining commitment. Customers can generate a cancellation quote to review charges before confirming.
* ElastiCache (4.0.5.0)
	* Amazon ElastiCache for Valkey now supports durability. This new capability is enabled through a Multi-AZ transactional log, enabling fast recovery and restart during failures.
* GeoRoutes (4.0.6.0)
	* Added Transit and Intermodal travel modes to CalculateRoutes. Plan routes using public transit (bus, subway, train, ferry) or combine transit with driving, taxi, and rental car segments in a single multi-modal route.
* GuardDuty (4.0.22.0)
	* Amazon GuardDuty Runtime Monitoring now supports 3 new SensitiveFileModified finding types (Persistence, PrivilegeEscalation, DefenseEvasion) that detect when security-sensitive system files are modified on EC2 instances or containers, indicating potential compromise through file tampering.
* IoT (4.0.9.1)
	* Fleet indexing documentation update
* KeyspacesStreams (4.0.5.0)
	* Added iterator description to the GetRecords API response for Amazon Keyspaces Change Data Capture (CDC) streams, enabling consumers to track their current position within the stream.
* Lambda (4.0.17.0)
	* Adds configuration for tag propagation to Lambda-managed resources.
* Lex (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ManagedBlockchain (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MediaConvert (4.0.18.0)
	* Adding new BDD representation of endpoint ruleset
* MediaLive (4.0.22.0)
	* Adding new BDD representation of endpoint ruleset
* MediaStore (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* MigrationHub (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MTurk (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Neptune (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* PersonalizeRuntime (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* PI (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Pinpoint (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* PinpointEmail (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Polly (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* RAM (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* Redshift (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Rekognition (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ResourceGroupsTaggingAPI (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Route53 (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* Route53Domains (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* S3 (4.0.24.0)
	* Adding new BDD representation of endpoint ruleset
* SageMaker (4.0.61.0)
	* Amazon SageMaker Job is a new service to help you manage various workloads related to model fine tuning, evaluation etc. Two job categories are supported today, AgentRFT for multi-turn agentic reinforcement fine tuning, and AgentRFTEvaluation for evaluating base model or trained model from AgentRFT.
* SagemakerJobRuntime (4.0.0.0)
	* Amazon SageMaker Job Runtime is a new service for managing trajectory data during multi-turn customization jobs. It provides APIs to send inference requests to models during job execution, mark rollouts as complete, and submit reward values for training trajectories.
* SecretsManager (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* SecurityToken (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* ServiceCatalog (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Shield (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* SimpleSystemsManagement (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* SimpleWorkflow (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Snowball (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SQS (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SSO (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* StepFunctions (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* StorageGateway (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* TranscribeService (4.0.7.0)
	* Release new Language locales including am-ET, es-MX, fa-AF, ht-HT, jv-ID, km-KH, my-MM, sq-AL, ne-NP. The commit shows past locales that have already been release which include cy-gb, ga-ie, gd-gb.
* Transfer (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* WAF (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* XRay (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Core 4.0.7.5
	* Fix: Fix an issue where AWS_REGION and AWS_ENDPOINT_URL both being set would cause the region to be nullified.
	* All service and extension packages updated to require new Core

### 4.0.259.0 (2026-06-01 18:19 UTC)
* Amplify (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ApplicationDiscoveryService (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* AppMesh (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* AppSync (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* AWSHealth (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* CloudWatchEvents (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CodePipeline (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* CognitoIdentity (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CognitoIdentityProvider (4.0.9.0)
	* Add support for multi-region replication, enabling synchronization of user data and configurations to a secondary user pool in a standby Region. Add support for customer managed keys (CMK) in AWS KMS for encrypting user pool data at rest.
* CognitoSync (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ConfigService (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* CostAndUsageReport (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* DatabaseMigrationService (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* DataPipeline (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* DeviceFarm (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* DirectoryService (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* DocDB (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* ECR (4.0.14.0)
	* Adding new BDD representation of endpoint ruleset
* ECS (4.0.23.0)
	* Adding new BDD representation of endpoint ruleset
* ElastiCache (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ElasticBeanstalk (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ElasticLoadBalancing (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ElasticLoadBalancingV2 (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* ElasticMapReduce (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* Elasticsearch (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* GameLift (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* Glacier (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Greengrass (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* IdentityManagement (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* Inspector (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* IoT (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* IoTEventsData (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* KeyManagementService (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisAnalytics (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisVideo (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisVideoMedia (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Lambda (4.0.16.0)
	* Adding new BDD representation of endpoint ruleset
* LexModelBuildingService (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* LicenseManager (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* Lightsail (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* MachineLearning (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceAgreement (4.0.8.0)
	* Adding Entitlements in SearchAgreements Response
* MarketplaceCatalog (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* MediaStoreData (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Personalize (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* QuickSight (4.0.25.0)
	* This release adds public APIs for Amazon QuickSight Spaces, Agents, and Flows. Spaces APIs enable management of curated resource collections. Agents APIs provide lifecycle control over AI-powered agents that leverage Spaces. Flows APIs add CRUDL APIs for automated workflows.
* S3 (4.0.23.6)
	* Fixed issue where calling `UploadPart` with an unseekable stream and `DisablePayloadSigning` set to true would fail (https://github.com/aws/aws-sdk-net/issues/4010). If the stream reports its length it is used directly (capped at `PartSize` when one is set); `PartSize` is only required for a forward-only stream that cannot report its length.

### 4.0.258.0 (2026-05-29 18:23 UTC)
* Account (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* ApplicationInsights (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ARCZonalShift (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Athena (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* AutoScaling (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* AutoScalingPlans (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* BackupGateway (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Bedrock (4.0.29.0)
	* Automated Reasoning checks - Added two build workflows for policies. Iterative Refine Policy uses AI to update policy definitions based on test results and feedback. Resolve Policy Ambiguities consolidates ambiguous variables in Automated Reasoning policies, a common source of ambiguous validation.
* BedrockAgentCoreControl (4.0.40.0)
	* Reference your own AWS Secrets Manager secrets when configuring credential providers, giving you control over encryption, rotation, and access policies instead of using service-managed secrets.
* Budgets (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* Chime (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudDirectory (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudHSM (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudHSMV2 (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudSearch (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CloudSearchDomain (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudTrail (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* CodeBuild (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* CodeCatalyst (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CodeCommit (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CodeDeploy (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CodeGuruSecurity (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ConnectCampaignsV2 (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* ConnectContactLens (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* DirectoryServiceData (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Drs (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* EntityResolution (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* GroundStation (4.0.6.0)
	* Adds support for Alpha-5 satellite number encoding in the Two-Line Element ephemeris format.
* InspectorScan (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* LexModelsV2 (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* LexRuntimeV2 (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MailManager (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* ManagedGrafana (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* MWAA (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* NetworkFlowMonitor (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Omics (4.0.10.0)
	* Add engineSettings to StartRun and GetRun. Add profiles and profileParameterTemplates to GetWorkflow and GetWorkflowVersion.
* PaymentCryptographyData (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* PCS (4.0.16.0)
	* Adding new BDD representation of endpoint ruleset
* PersonalizeEvents (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Proton (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* QBusiness (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* QuickSight (4.0.24.0)
	* Adds support for creating, updating, describing, listing, and deleting an OAuthClientApplication resource, a new quicksight resource that allows customers to store OAuth configurations to connect to their databases via 3 Legged OAuth.
* RDSDataService (4.0.3.0)
	* RDS Data API arrays (longValues, doubleValues, stringValues, booleanValues) in ExecuteStatement responses now correctly support null elements. Runtime change for JS v3 and .NET. Compile-time change for C plus plus, .NET, Kotlin, Rust. No impact for Java, Python, Ruby, PHP, Go.
	* `ArrayValue` members `LongValues`, `DoubleValues`, and `BooleanValues` are now `List<long?>`, `List<double?>`, and `List<bool?>`, and preserve null elements returned in SQL arrays. Previously, null elements were coerced to `0`, `0.0`, and `false` (for example, `SELECT ARRAY[1, NULL, 3]::bigint[]` returned `[1, 0, 3]` and now returns `[1, null, 3]`). `StringValues` and nested `ArrayValues` are unchanged -- reference types already preserved null. Existing code that assigns value-type elements to non-nullable variables won't compile; migrate by unwrapping with `.GetValueOrDefault()`, changing the target type to nullable, or using `??` to supply a default.
* Route53RecoveryCluster (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Route53Resolver (4.0.8.0)
	* Added BatchCreateFirewallRule, BatchUpdateFirewallRule, BatchDeleteFirewallRule, and ListFirewallRuleTypes APIs. Added FirewallRuleType support to Firewall Rule APIs.
* SimpleEmailV2 (4.0.14.0)
	* This release introduces support for Tenant Suppression Lists
* SSMGuiConnect (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Synthetics (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* WAFV2 (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* WorkspacesInstances (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Core 4.0.7.4
	* Fix CryptoUtil.ComputeMD5Hash failure in FIPS-enforced environments.
	* All service and extension packages updated to require new Core

### 4.0.257.0 (2026-05-28 18:29 UTC)
* AccessAnalyzer (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* AmplifyUIBuilder (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* AppStream (4.0.12.0)
	* Amazon WorkSpaces Applications now supports BYOL (Bring Your Own License). This enables customers to import their own WorkSpaces images and use them in WorkSpaces Applications.
* ARCRegionswitch (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Artifact (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* AugmentedAIRuntime (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* BackupSearch (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Bedrock (4.0.28.0)
	* Add support for ModelPackageArn in Bedrock's CreateCustomModel API
* BedrockAgentCore (4.0.26.0)
	* Added Harness support for LiteLLM model configuration for third-party model providers. Added S3 and Git skill source types. Added Responses API format for OpenAI and Bedrock models. Added runtimeUserId and runtimeClientError to InvokeHarness.
* BedrockAgentCoreControl (4.0.39.0)
	* Added Harness support for LiteLLM model configuration for third-party model providers. Added S3 and Git skill source types. Added Responses API format for OpenAI and Bedrock models. Added runtimeUserId parameter to InvokeHarness for end-user identification.
* BedrockDataAutomationRuntime (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockRuntime (4.0.20.0)
	* Support system role in message
* BillingConductor (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Braket (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* Chatbot (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ChimeSDKMeetings (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ChimeSDKMessaging (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CloudFrontKeyValueStore (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CodeGuruReviewer (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CodeStarconnections (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ControlCatalog (4.0.6.0)
	* AWS Control Catalog - Added GovernedProviders response field and inclusion filter to GetControl and ListControls APIs to identify and filter by cloud provider. Added ParameterRequirementSummary response field indicating parameter requirements.
* CostOptimizationHub (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* CustomerProfiles (4.0.14.0)
	* BatchPutProfileObject API adds multiple profile objects to a domain of a given ObjectType in a single API call.
* Deadline (4.0.20.0)
	* Added support for persistent storage on Service-Managed Fleets, allowing customers to configure persistent storage that preserves data across worker sessions which reduces job startup times for workloads with large software installations or asset caches.
* Detective (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* FinSpaceData (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* GeoRoutes (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* GroundStation (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* IoT (4.0.8.0)
	* Adds new connectivity-related fields to Fleet Indexing API requests and responses.
* IotData (4.0.3.0)
	* Adding GetConnection, ListSubscriptions, and SendDirectMessage APIs to IoT Data Plane
* IoTTwinMaker (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* IVS (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* Keyspaces (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisAnalyticsV2 (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisVideoSignalingChannels (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* LookoutEquipment (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceReporting (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MigrationHubStrategyRecommendations (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* NeptuneGraph (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* NetworkMonitor (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* OpenSearchServerless (4.0.8.0)
	* Adds support for deletion protection on collections, ability to create NEXTGEN collection groups and autoscaling visibility for NEXTGEN collection groups
* PCS (4.0.15.0)
	* This release adds support for configuring scaleDownIdleTimeInSeconds at the compute node group level, allowing customers to set different idle timeouts per node group. Previously this setting was only available at the cluster level.
* PinpointSMSVoiceV2 (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* PrometheusService (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* RedshiftDataAPIService (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* Resiliencehubv2 (4.0.0.0)
	* This is the initial SDK release for the next generation of Resilience Hub.
* Route53RecoveryControlConfig (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* S3Control (4.0.12.0)
	* Update the minimum value of MinStorageBytesPercentage in StorageLensPrefixLevel.SelectionCriteria from 0.1 to 1, aligning the model with the documented contract.
* SageMakerRuntime (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SecurityAgent (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Signin (4.0.1.0)
	* Adding new BDD representation of endpoint ruleset
* SocialMessaging (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* SSMIncidents (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SupplyChain (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* TimestreamInfluxDB (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* TrustedAdvisor (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* VerifiedPermissions (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* Wickr (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset

### 4.0.256.0 (2026-05-27 18:22 UTC)
* BCMDashboards (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockDataAutomation (4.0.10.0)
	* Matcher Fallback extends the CustomOutputConfiguration for the Document modality in DataAutomationProjects, enabling a fallback blueprint when no match is found. A FALLBACK match status is returned, improving the matching experience and guaranteeing customers always receive CustomOutputResults.
* CloudWatchRUM (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ComputeOptimizer (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* ComputeOptimizerAutomation (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ConnectCases (4.0.15.0)
	* Adding new BDD representation of endpoint ruleset
* DataExchange (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* DevOpsAgent (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* DocDBElastic (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* EBS (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ECRPublic (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ECS (4.0.22.0)
	* Add support for Neuron device resource requirements for Amazon ECS
* EKSAuth (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ElementalInference (4.0.1.0)
	* Added support for smart subtitles in Elemental Inference, enabling automatic generation of subtitles for media content. Available in English, Spanish, French, German, Italian, and Portuguese.
* EventBridge (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* Finspace (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* FIS (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Imagebuilder (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* Inspector2 (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* IoTDeviceAdvisor (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* IoTFleetWise (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* IoTThingsGraph (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* LaunchWizard (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* LocationService (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* MainframeModernization (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceDeployment (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MediaLive (4.0.21.0)
	* AWS Elemental MediaLive now supports Smart Subtitles, a new caption source that uses AWS Elemental Inference to automatically generate WebVTT and TTML captions from source audio. Available in English, Spanish, French, German, Italian, and Portuguese.
* MemoryDB (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Mgn (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* MPA (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* NovaAct (4.0.1.0)
	* Adding new BDD representation of endpoint ruleset
* Omics (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* OpenSearchService (4.0.22.0)
	* OpenSearch will now support multi-segment paths in JWKS URLs.
* Organizations (4.0.11.13)
	* AWS Organizations now emits CloudTrail events (AccountJoinedOrganization, AccountDepartedOrganization) to the management account for membership changes, including join and departure method and timestamp.
* PartnerCentralBenefits (4.0.1.0)
	* Adding new BDD representation of endpoint ruleset
* PartnerCentralSelling (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* PaymentCryptography (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* PcaConnectorAd (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ResourceExplorer2 (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* RTBFabric (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* SageMaker (4.0.60.0)
	* Adds shared environment support for Restricted Instance Groups (RIGs) on SageMaker HyperPod, enabling cross-RIG workload scheduling and FSx sharing. This unlocks shared CPU-GPU environments needed for cost-efficient RL training (e.g., Nova Forge). Adds p6 instance support for recommendation jobs
* SageMakerFeatureStoreRuntime (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* SavingsPlans (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* SecurityIR (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* SimpleDBv2 (4.0.1.0)
	* Adding new BDD representation of endpoint ruleset
* SSMContacts (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* SsmSap (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* SupportApp (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* VoiceID (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* WellArchitected (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* WorkMailMessageFlow (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* WorkSpacesWeb (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset

### 4.0.255.0 (2026-05-26 18:33 UTC)
* AIOps (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ApplicationCostProfiler (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* AppRunner (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Backup (4.0.13.0)
	* Launching S3 PITR malware scanning support for AWS Backup
* Batch (4.0.10.0)
	* Increase the maximum value of jobExecutionTimeoutMinutes to support longer job timeouts during compute environment infrastructure updates.
* BCMDataExports (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockAgentCore (4.0.25.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockAgentCoreControl (4.0.38.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockDataAutomation (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* Billing (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Budgets (4.0.9.20)
	* AWS Budget Name Validation Documentation Updates.
* ChimeSDKIdentity (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ChimeSDKMediaPipelines (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CleanRooms (4.0.18.0)
	* Adding new BDD representation of endpoint ruleset
* CleanRoomsML (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* CodeConnections (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ConnectHealth (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ControlCatalog (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* DataZone (4.0.30.0)
	* Added resourceConfigurations and allowUserProvidedConfigurations fields to environment blueprint configuration APIs, enabling customers who migrated from V1 to V2 domains to update resource configurations (such as lineage schedules) programmatically via the SDK.
* DevOpsGuru (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* EMRServerless (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* Evs (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* GreengrassV2 (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* GuardDuty (4.0.21.0)
	* Add malware scan support for Continuous Backups, also known as Point-In-Time Recovery Points (PITR).
* IAMRolesAnywhere (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* IdentityStore (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* IoTManagedIntegrations (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* Ivschat (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* KeyspacesStreams (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisVideoWebRTCStorage (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ManagedBlockchainQuery (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceAgreement (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* MediaPackageV2 (4.0.14.0)
	* Adding new BDD representation of endpoint ruleset
* MedicalImaging (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* Notifications (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ObservabilityAdmin (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* Odb (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* OSIS (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* PartnerCentralChannel (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* PcaConnectorScep (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Pipes (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* RedshiftServerless (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* ResilienceHub (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ResourceGroupsTaggingAPI (4.0.3.0)
	* The GetResources API now returns MissingTagKeys in ComplianceDetails, listing tag keys defined as required in the ReportRequiredTagBlock block of the effective tag policy that are absent from the resource.
* Route53GlobalResolver (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* S3Tables (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* SagemakerEdgeManager (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* SageMakerGeospatial (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Scheduler (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ServiceDiscovery (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ServiceQuotas (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* SSMQuickSetup (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* WorkSpacesThinClient (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset

### 4.0.254.0 (2026-05-22 18:21 UTC)
* AppConfig (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* ApplicationSignals (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* B2bi (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* BCMPricingCalculator (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* BCMRecommendedActions (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Bedrock (4.0.27.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockAgentRuntime (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* CloudControlApi (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CodeStarNotifications (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* ControlTower (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* CustomerProfiles (4.0.13.0)
	* Adding new BDD representation of endpoint ruleset
* DataZone (4.0.29.0)
	* Add support for VPC connection
* DSQL (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* DynamoDBv2 (4.0.18.5)
	* Updated InternalsVisibleTo entries to reflect the renamed unit-test project assemblies. No customer-visible behavior change.
* EC2 (4.0.90.0)
	* The ModifyInstanceAttribute API now supports modification of EnclaveOptions for the instance as a typed parameter.
* EMRContainers (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ForecastQueryService (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ForecastService (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* FraudDetector (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* FreeTier (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* GameLiftStreams (4.0.7.16)
	* Added new Gen6 stream classes based on the EC2 G6e instance family. These classes are designed for streaming high-fidelity, graphically demanding games and applications that benefit from additional GPU memory and performance.
* GeoPlaces (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* GlueDataBrew (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* InternetMonitor (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Invoicing (4.0.8.0)
	* Adds support for idempotency with a new ClientToken field for the CreateInvoiceUnit, DeleteInvoiceUnit, UpdateInvoiceUnit, DeleteProcurementPortalPreference, PutProcurementPortalPreference, and UpdateProcurementPortalPreferenceStatus APIs.
* IoTWireless (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* IVSRealTime (4.0.8.0)
	* Adding new BDD representation of endpoint ruleset
* KafkaConnect (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* LicenseManagerLinuxSubscriptions (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* LicenseManagerUserSubscriptions (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceDiscovery (4.0.1.0)
	* Adding new BDD representation of endpoint ruleset
* MigrationHubRefactorSpaces (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Neptunedata (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* NetworkFirewall (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* NotificationsContacts (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* OAM (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Outposts (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Panorama (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* PartnerCentralAccount (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* PI (4.0.3.0)
	* Added ListPerformanceAnalysisReportRecommendations API to retrieve recommendations for a performance analysis report. Added analysis configuration support to CreatePerformanceAnalysisReport for enhanced analysis types such as vacuum analysis.
* QConnect (4.0.12.0)
	* Added guardrail assessment results to inference spans in the ListSpans API. You can now see which AI Guardrail policies were evaluated, whether content was blocked or masked, and per-policy details for each Bedrock Converse call
* RecycleBin (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Repostspace (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* S3 (4.0.23.4)
	* Updated InternalsVisibleTo entries to reflect the renamed unit-test project assemblies. No customer-visible behavior change.
* S3Vectors (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* Schemas (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SecurityAgent (4.0.3.0)
	* Adds support for verification scripts on penetration test findings. Customers can now download executable scripts to independently reproduce confirmed vulnerabilities, with instructions and required environment variables provided for each finding.
* SimpleEmailV2 (4.0.13.0)
	* Adding new BDD representation of endpoint ruleset
* SimSpaceWeaver (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* SSOOIDC (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Tnb (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Core 4.0.7.3
	* Updated InternalsVisibleTo entries in Core to reflect the renamed unit-test project assemblies. No customer-visible behavior change.
	* All service and extension packages updated to require new Core

### 4.0.253.0 (2026-05-21 20:23 UTC)
* ACMPCA (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* APIGateway (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* ApiGatewayV2 (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* AppRegistry (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* AppStream (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* Backup (4.0.12.0)
	* Adding new BDD representation of endpoint ruleset
* Batch (4.0.9.6)
	* Clarified CreateComputeEnvironment parameter requirements - serviceRole is required for UNMANAGED compute environments, allocationStrategy is required for EKS compute environments, and compute environments must be created in the ENABLED state.
* BedrockAgent (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* BedrockAgentCoreControl (4.0.37.0)
	* Adds dataset management APIs for creating, versioning, and managing evaluation datasets.
* BedrockRuntime (4.0.19.0)
	* Adding new BDD representation of endpoint ruleset
* CertificateManager (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* CleanRooms (4.0.17.0)
	* Collaboration creators can update payment configurations without recreating the collaboration. When multiple payer candidates are configured for a cost type, analysis runners can specify the actual payer at submission time, providing granular control over billing.
* CleanRoomsML (4.0.10.0)
	* Collaboration creators can update payment configurations without recreating the collaboration. When multiple payer candidates are configured for a cost type, analysis runners can specify the actual payer at submission time, providing granular control over billing.
* Cloud9 (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* CodeArtifact (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* CodeGuruProfiler (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Comprehend (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* ComprehendMedical (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* Connect (4.0.46.0)
	* Adding new BDD representation of endpoint ruleset
* DataSync (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* DLM (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* EKS (4.0.17.0)
	* Adding new BDD representation of endpoint ruleset
* Evs (4.0.8.0)
	* A new GetDepotUrl API has been added to retrieve a URL for accessing Amazon EVS custom addon packages. Customers can use this URL to configure vSphere Lifecycle Manager (vLCM) as an online depot source, enabling upgrades of addon components across ESXi hosts.
* FMS (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* FSx (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* GlobalAccelerator (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* GuardDuty (4.0.20.0)
	* Adding new BDD representation of endpoint ruleset
* HealthLake (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* IoTJobsDataPlane (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* Kafka (4.0.10.0)
	* Adding new BDD representation of endpoint ruleset
* KendraRanking (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* KinesisVideoArchivedMedia (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* MarketplaceEntitlementService (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* MediaConnect (4.0.8.0)
	* Adds support for controlling the timecode source of NDI flow outputs.
* MediaTailor (4.0.9.0)
	* Adding new BDD representation of endpoint ruleset
* MigrationHubConfig (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* MigrationHubOrchestrator (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* NetworkManager (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* Pricing (4.0.5.0)
	* Adding new BDD representation of endpoint ruleset
* QApps (4.0.3.0)
	* Adding new BDD representation of endpoint ruleset
* QuickSight (4.0.23.0)
	* Adding new BDD representation of endpoint ruleset
* Route53Resolver (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* SageMaker (4.0.59.0)
	* Add support for disabling home EFS file system creation on SageMaker domains.
* SageMakerMetrics (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* SecurityHub (4.0.11.0)
	* Adding new BDD representation of endpoint ruleset
* ServerlessApplicationRepository (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* Signer (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* SSOAdmin (4.0.7.0)
	* Adding new BDD representation of endpoint ruleset
* Textract (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset
* TranscribeService (4.0.6.0)
	* Adding new BDD representation of endpoint ruleset
* Translate (4.0.2.0)
	* Adding new BDD representation of endpoint ruleset
* VerifiedPermissions (4.0.8.0)
	* Support hard deleting policy store aliases. Users can now delete an alias and immediately reassign it to a different policy store without waiting for the soft-delete retention period.
* WorkMail (4.0.4.0)
	* Adding new BDD representation of endpoint ruleset

### 4.0.252.0 (2026-05-20 18:24 UTC)
* BedrockRuntime (4.0.18.0)
	* Supporting Request Metadata for Invoke Model and Invoke Model with Response Stream
* CustomerProfiles (4.0.12.0)
	* Amazon Connect Customer Profiles adds support for item catalog columns in RecommenderSchema, ExcludedColumns in Create and Update Recommender to specify columns to exclude from training, and the ability to disable automatic retraining by setting TrainingFrequency to 0.
* KeyManagementService (4.0.11.0)
	* AWS KMS now supports creating grants for AWS service principals using new GranteeServicePrincipal and RetiringServicePrincipal parameters. This release adds SourceArn grant constraint and three condition keys for controlling CreateGrant access. For more information, see Grants in AWS KMS.
* MWAA (4.0.4.4)
	* Updated API documentation to describe the PublicAndPrivate webserver access mode.
* PaymentCryptographyData (4.0.7.0)
	* GenerateAuthRequestCryptogram API launch.
* Extensions.NETCore.Setup (4.0.4.0)
	* Added new callback for the `AddAWSService` and similar methods allowing customization of the service client config before being used to create the service client. For example the callback can be used to configure the `HttpClientFactory` with an implementation coming from the DI using the `IHttpClientFactory` provided by Microsoft.
	* Note: Callers passing a literal null as the second argument to AddAWSService or AddKeyedAWSService may need to cast (e.g., (AWSOptions)null) to resolve overload ambiguity.
* Core 4.0.7.2
	* Remove outdated xamarin links on httpClientFactory docs.

### 4.0.251.0 (2026-05-19 18:24 UTC)
* BedrockAgentCore (4.0.24.0)
	* Add RetryableConflictException (HTTP 409) to InvokeAgentRuntime and StopRuntimeSession to prevent orphaned VMs during concurrent session access. The SDK automatically retries this exception with backoff. Enforcement is not yet active and will be enabled in a future service update.
* DevOpsAgent (4.0.4.0)
	* Added a new serviceType mcpserversigv4 service and association. This provides feature to register MCP sigv4 authorization based MCPs
* GuardDuty (4.0.19.0)
	* Adding support for exposure and vulnerability context from AWS Security Hub in GuardDuty Extended Threat Detection attack sequence findings.
* ManagedGrafana (4.0.5.0)
	* Introduce degraded workspace status as a possible Amazon Managed Grafana workspace status, and a new field named degraded workspace reason which informs customers why the workspace is degraded in the DescribeWorkspace API response.
* RTBFabric (4.0.6.0)
	* This release is to deprecate 'inboundLinksCount' field in GetResponderGateway response and introduce the new field 'linksRequestedCount' to replace it.
* SageMaker (4.0.58.0)
	* Add support for ml.p5.4xlarge and ml.p5en.48xlarge instances on SageMaker Notebook Instances Platform.

### 4.0.250.0 (2026-05-18 18:30 UTC)
* AccessAnalyzer (4.0.7.0)
	* Services manage service-linked analyzers through dedicated APIs - CreateServiceLinkedAnalyzer and DeleteServiceLinkedAnalyzer that separate service-linked specific operations from customer-managed operations. It also shows up in ListAnalyzers and GetAnalyzer responses.
* Connect (4.0.45.0)
	* Amazon Connect Cases now supports SLA durations of up to 2 years (1,051,200 minutes), increased from the previous maximum of 90 days (129,600 minutes). This enables you to track long-running service level agreements for cases that require extended resolution timelines.
* EC2 (4.0.89.0)
	* Amazon VPC IP Address Manager (IPAM) now supports tags on IPAM pool allocations, enabling all standard tagging features for allocations including tag-on-create.
* ECS (4.0.21.0)
	* Amazon ECS now supports Pause lifecycle hooks for service deployments, allowing customers to automatically pause deployments at specified stages and use the new ContinueServiceDeployment API to continue or roll back with confidence.
* Evs (4.0.7.5)
	* Amazon EVS now supports up to 32 hosts per EVS environment, increasing the previous host limit to allow a larger scale of VMware workload deployments and reduce operational overhead.
* IVS (4.0.5.0)
	* Adds support for up to 3 mediaTailorPlaybackConfiguration objects in an ad configuration resource
* QuickSight (4.0.22.0)
	* Support for dataset enrichment and geo spatial in new data preparation experience

### 4.0.249.0 (2026-05-15 19:41 UTC)
* CloudWatchLogs (4.0.25.0)
	* Updating the max limit for start query api parameter.
* MediaPackageV2 (4.0.13.0)
	* This release adds support for AvailabilityStartTimeConfiguration in MediaPackageV2 DASH manifests
* PartnerCentralSelling (4.0.11.0)
	* Enable TCV intake on Opportunity to improve Opportunities Hygiene and downstream revenue attribution.
* Core 4.0.7.1
	* Reduced CPU on the JSON unmarshalling hot path by removing a redundant Convert.ChangeType conversion in StringUnmarshaller.
	* Reduced per-response allocations in JSON unmarshalling by deferring StreamReader construction in JsonUnmarshallerContext until Peek() is called.
	* All service and extension packages updated to require new Core

### 4.0.248.0 (2026-05-14 18:18 UTC)
* Bedrock (4.0.26.0)
	* Advanced Prompt Optimization (AdvPO) allows you to optimize and migrate your prompts for any model on Bedrock by automatically evaluating responses and rewriting prompts to improve performance. This release provides a programmatic way to create, get, list, stop, and delete AdvPO jobs.
* CloudFront (4.0.16.0)
	* Adding a new boolean for OCSP Revocations in Viewer mTLS Create and Update APIs, and adding a new 'Passthrough' option for TrustStore modes
* DatabaseMigrationService (4.0.9.0)
	* Add 9 SDK waiters for DMS Schema Conversion async operations. Eliminates manual polling for import, assessment, conversion, export, and creation jobs.
* DataZone (4.0.28.0)
	* Adds support for SageMaker Unified Studio notebook operations, including notebook import and export
* Glue (4.0.30.0)
	* Release --has-databases parameter for AWS Glue get-catalogs API, which filters catalog responses to include only those capable of containing databases, excluding parent catalogs that hold only other catalogs. Remove model-level validation on partition index list size for AWS Glue tables.
* ManagedGrafana (4.0.4.0)
	* Adds support for dual-stack (IPv4 and IPv6) connectivity to Amazon Managed Grafana workspaces. Customers can configure the ipAddressType parameter when creating or updating a workspace to choose between IPv4-only or dual-stack (IPv4 and IPv6) access.
* Mgn (4.0.7.0)
	* Introducing new option for security groups mapping - with MAP-DHCP the service translates security rules from your source environment with DHCP compatibility.
* QConnect (4.0.11.0)
	* ListModels is an API that returns the available AI models for a Connect Assistant based on its region and AI prompt type.
* Core 4.0.7.0
	* Fixed JSON deserialization of settings files with trailing commas on .NET 8 by adding AllowTrailingCommas to source-generated serializer contexts.
	* On Unix/macOS, SSO token and Login token cache files are now created with 0600 (owner read/write only) and cache directories with 0700 (owner only). Behavior is configurable via AWSConfigs.RestrictFilePermissions.
	* All service and extension packages updated to require new Core

### 4.0.247.0 (2026-05-13 18:21 UTC)
* ARCRegionswitch (4.0.6.0)
	* Adds support for enabling and disabling Lambda event source mappings in Region switch plans.
* Batch (4.0.9.3)
	* Adds a billing callout to docs regarding using the CE Scale Down Delay feature
* BedrockAgentCoreControl (4.0.36.0)
	* Adds support for read-only summary APIs for Policy Engine, Policy, and Policy Generation resources, enabling metadata retrieval without KMS decryption for AWS Config integration.
* BillingConductor (4.0.6.0)
	* Add ConflictException to UpdateCustomLineItem operation.
* Connect (4.0.44.0)
	* This change added three new EventSourceName for schedule notification feature
* ConnectCampaignsV2 (4.0.8.0)
	* This release added support for Outbound Campaign timezone detection using all available contact methods
* ConnectCases (4.0.14.0)
	* Amazon Connect Cases now supports SLA durations of up to 2 years (1,051,200 minutes), increased from the previous maximum of 90 days (129,600 minutes). This enables you to track long-running service level agreements for cases that require extended resolution timelines.
* DSQL (4.0.10.0)
	* Added support for Amazon Aurora DSQL change data capture (CDC) streams that deliver row-level database changes to Amazon Kinesis in JSON format. Includes CreateStream, GetStream, ListStreams, and DeleteStream operations.
* EC2 (4.0.88.0)
	* Include length limits in the SDK and documentation for text fields in Image (AMI) APIs such as the image name and description
* Elasticsearch (4.0.6.0)
	* Adds support for AutomatedSnapshotPauseOptions.
* Glue (4.0.29.1)
	* AWS Glue now defaults the job timeout to 480 minutes for Glue version 5.0 and later when no timeout value is specified. The default remains 2,880 minutes for Glue version 4.0 and earlier.
* Lightsail (4.0.8.0)
	* Added OriginIpAddressTypeEnum (ipv4, ipv6, dualstack) and ipAddressType field to Origin and InputOrigin structures for Lightsail CDN distributions. Allows customers to specify how the distribution connects to origins, using IPv4, IPv6, or dualstack networking
* OpenSearchService (4.0.21.0)
	* Adds support for AutomatedSnapshotPauseOptions.
* PartnerCentralAccount (4.0.3.0)
	* Added ServiceQuotaExceededExceptions for Profile operations
* PCS (4.0.14.0)
	* Add support for Amazon EC2 Interruptible-ODCR
* QuickSight (4.0.21.0)
	* Adds five new custom permission option for Quick Apps so that these capabilities can be controlled by public SDK and CLI.
* Redshift (4.0.6.19)
	* Added rg.xlarge and rg.4xlarge to valid NodeType values and updated documentation for CreateCluster, ModifyCluster, ResizeCluster, and RestoreFromClusterSnapshot APIs to reflect RG node type support.
* RTBFabric (4.0.5.0)
	* Customers can now configure custom domain names for their RTB Fabric gateways. This enables partners to use their own branded domain for RTB traffic instead of the default rtbfabric endpoint
* SageMaker (4.0.57.0)
	* Adds execution role session name mode to reflect user identity in Studio. Adds Flexible Training Plans on Studio apps. Adds restricted model packages to control access to proprietary model artifacts via IAM. Fixed instance type parity between inference endpoints and managed shadow tests.
* SecurityAgent (4.0.2.0)
	* Add support for code reviews, a new resource type that enables automated security-focused static analysis of source code repositories.
* SocialMessaging (4.0.5.0)
	* Adds parameters to call the GetWhatsAppMessageTemplate and UpdateWhatsAppMessageTemplate APIs with a template name and language code in place of the template ID. Linked WhatsApp accounts also describe whether the WABA is onboarded to Meta's Marketing Messages API.
* StepFunctions (4.0.3.0)
	* Updated default SDK endpoints for AWS Step Functions in AWS GovCloud (US) regions. The default Dual-Stack endpoints now resolve to "states-fips" prefixed hostnames. There are no changes to service behavior. No customer action is required.
* Core 4.0.6.2
	* Cache credentials sourced from profiles when calling using the DefaultAWSCredentialsIdentityResolver's ResolveIdentity rather than doing a full file read every time a profile is specified on the config.
	* Introduce a new internal CredentialsGenerator CachedProfileCredentialResolver which handles caching of profiles and resolving of credentials via profile.
	* All service and extension packages updated to require new Core

### 4.0.246.0 (2026-05-07 18:38 UTC)
* BCMDataExports (4.0.4.0)
	* With this release, customers can configure their data exports to generate additional integration artifacts for Athena and Redshift.
* BedrockAgentCore (4.0.23.0)
	* Launching AgentCore payments - a capability that provides secure, instant microtransaction payments for AI agents to access paid APIs, MCP servers, and content. It handles payment processing for x402 protocol, payment limits, and 3P wallet integrations with Coinbase CDP and Stripe (Privy).
* BedrockAgentCoreControl (4.0.35.0)
	* Launching AgentCore payments - a capability that provides secure, instant microtransaction payments for AI agents to access paid APIs, MCP servers, and content. It handles payment processing for x402 protocol, payment limits, and 3P wallet integrations with Coinbase CDP and Stripe (Privy).
* EC2 (4.0.87.0)
	* DescribeInstanceTypes now accepts an IncludeUnsupportedInRegion parameter. When set, the response also lists instance types that are not available in the current Region. Each instance type includes a SupportedInRegion field indicating its regional availability.
* GuardDuty (4.0.18.6)
	* This is a documentation update
* Invoicing (4.0.7.0)
	* Updated ListInvoiceSummaries API to add new ReceiverRole filter in Request and Response
* Route53Resolver (4.0.6.0)
	* Adds supports for DNS64 on inbound endpoints and IPv6 forwarding through the internet gateway (IGW) on outbound endpoints, making it easier to manage hybrid DNS across IPv4 and IPv6 networks.
* Extensions.NETCore.Setup (4.0.3.37)
	* Fix #3538. Allow service specific endpoints to work with SSO profiles.

### 4.0.245.0 (2026-05-06 18:38 UTC)
* BedrockAgentCoreControl (4.0.34.0)
	* Adds support for bring-your-own file system in AgentCore Runtime. Developers can mount Amazon S3 Files and Amazon EFS access points directly into agent sessions using filesystemConfigurations.
* Glue (4.0.29.0)
	* Adds support for a CustomLogGroupPrefix parameter in StartDataQualityRulesetEvaluationRun to specify custom CloudWatch log group paths, and a RulesetName filter in ListDataQualityRulesetEvaluationRuns to filter evaluation runs by ruleset name.
* Imagebuilder (4.0.11.0)
	* The ImportDiskImage API now enforces a maximum character limit of 128 characters on the image name field.
* LexModelsV2 (4.0.7.0)
	* Amazon Lex V2 introduces audio filler support for speech-to-speech bots. Configure melody or typing sounds that play during backend processing to reduce perceived latency and maintain a natural conversational experience for callers.
* MWAA (4.0.4.0)
	* Amazon MWAA now supports a PublicAndPrivate webserver access mode. The Airflow web server is accessible over both public and private endpoints, enabling workers in VPCs without internet access to reach the Task API privately while retaining public access to the Airflow UI.
* S3 (4.0.23.0)
	* Validate outpost access point resource name
* SageMaker (4.0.56.0)
	* Amazon SageMaker HyperPod now returns ImageVersionStatus in DescribeCluster, DescribeClusterNode, and ListClusterNodes responses, indicating whether cluster instances are running the latest available image version.
* SecurityHub (4.0.10.0)
	* Release GenerateRecommendedPolicyV2 and GetRecommendedPolicyV2 APIs. This supports generating and retrieving policy recommendations to remediate unused permissions findings that are now being supported on Security Hub.
* Extensions.Bedrock.MEAI (4.0.8.0)
	* (Preview) Add Bedrock Nova Sonic realtime provider implementing `IRealtimeClient` / `IRealtimeClientSession` for real-time bidirectional audio conversations with tool calling support.

### 4.0.244.0 (2026-05-05 18:16 UTC)
* CleanRoomsML (4.0.9.0)
	* Increase max configurable output limits in the Clean Rooms ML configured model algorithm association resource.
* CloudFront (4.0.15.0)
	* Adds support for tagging CloudFront Functions and KeyValueStores resources.
* MarketplaceAgreement (4.0.6.0)
	* With this release, Agreements API provides a programmatic way to generate quotes, accept offers, track charges and entitlements, manage renewals and cancellations, and streamline operations entirely through APIs without navigating to the AWS Marketplace website or AWS Management Console.
* MediaTailor (4.0.8.0)
	* Added support for Monetization Functions. Monetization Functions let you enrich ad requests with external data and transform session parameters using JSONata expressions, without deploying custom infrastructure.
* MedicalImaging (4.0.7.0)
	* Add support for DICOM Json Metadata Override features in startDICOMImportJob API
* OpenSearchService (4.0.20.0)
	* Amazon OpenSearch Service now supports VPC egress, enabling outbound traffic from your OpenSearch domain to route privately through your VPC instead of the public internet.
* Route53Domains (4.0.4.0)
	* This release adds the TLDInMaintenance exception.
* SageMaker (4.0.55.0)
	* Adds support for ml.p5.4xlarge instance type for SageMaker Studio JupyterLab and CodeEditor apps for IAD (us-east-1), NRT (ap-northeast-1), BOM (ap-south-1), CGK (ap-southeast-3), GRU (sa-east-1), PDX (us-west-2), CMH (us-east-2).

### 4.0.243.0 (2026-05-04 18:24 UTC)
* BedrockAgentCoreControl (4.0.33.0)
	* Amazon Bedrock AgentCore gateways now support MCP Sessions and response streaming from MCP targets. Session timeouts can be set between 15 minutes and 8 hours, and response streaming enables forwarding stream events sent by MCP targets to gateway users.
* CloudWatchLogs (4.0.24.0)
	* Adding an additional optional deliverySourceConfiguration field to PutDeliverySource API. This enables customers to pass service-specific configurations through IngestionHub such as tracing enablement or sampling rates that will be propagated to the source resource.
* EC2 (4.0.86.0)
	* This feature allows customers to change the tunnel bandwidth on existing VPN connections using the ModifyVpnConnectionOptions API
* GeoRoutes (4.0.4.0)
	* Added support for TravelTimeExceedsDriverWorkHours, ViolatedBlockedRoad, and ViolatedVehicleRestriction notice codes to the CalculateRoutes API response.
* LexModelBuildingService (4.0.3.0)
	* Lex V1 is deprecated, use Lex V2 instead
* MediaLive (4.0.20.0)
	* Updates the type of the MediaLiveRouterOutputConnectionMap.
* SecurityAgent (4.0.1.0)
	* AWS Security Agent is adding a new target domain verification method for private VPC penetration testing. Additionally, the target domain resource will now have a verification status reason field to surface additional details about domain verification
* VPCLattice (4.0.5.0)
	* Amazon VPC Lattice now supports privately resolvable DNS resources
* Extensions.Bedrock.MEAI (4.0.7.0)
	* Update `IChatClient` with latest `BedrockRuntime` / M.E.AI (adding support for multi-modal tool returns and citations with URIs)
* Core 4.0.6.1
	* Add thread safety note to all generated service client classes (https://github.com/aws/aws-sdk-net/issues/2098)
	* All service and extension packages updated to require new Core

### 4.0.242.0 (2026-05-01 18:26 UTC)
* AppStream (4.0.10.0)
	* Amazon WorkSpaces Applications now enables AI agents to securely operate desktop applications. Administrators configure stacks to provide agents access to WorkSpaces. Agents can click, type, and take screenshots. Agents authenticate with AWS IAM credentials with activity logged in AWS CloudTrail.
* CloudWatch (4.0.10.0)
	* This release adds tag support for CloudWatch Dashboards. The PutDashboard API now accepts a Tags parameter, allowing you to tag dashboards at creation time. Additionally, the TagResource, UntagResource, and ListTagsForResource APIs now support dashboard ARNs as resources.
* CloudWatchLogs (4.0.23.0)
	* Adds support for filtering log groups by tags in the ListLogGroups API via the new logGroupTags parameter.
* DynamoDBv2 (4.0.18.0)
	* Replace AttributesToGet usage with ProjectionExpression for batch get requests
* EntityResolution (4.0.7.0)
	* Add support for transitive matching in AWS Entity Resolution rule-based matching workflows. When enabled, records that match through different rules are grouped together into the same match group, allowing related records to be connected across rule levels.
* IdentityManagement (4.0.9.21)
	* Added guidance for CreateOpenIDConnectProvider to include multiple thumbprints when OIDC discovery and JWKS endpoints use different hosts or certificates
* IoT (4.0.7.0)
	* AWS IoT HTTP rule actions now support cross-topic batching, combining messages from different MQTT topics into single HTTP requests.
* QConnect (4.0.10.0)
	* Added reasoning details, statusDescription, and timeToFirstTokenMs fields to the ListSpans response in Amazon Q in Connect to provide visibility into model thinking, error diagnostics, and inference latency metrics.
* QuickSight (4.0.20.0)
	* Add IdentityProviderCACertificatesBundleS3Uri for private CA certs with OAuth datasources. 256-char limit for FontFamily in themes. ControlTitleFormatText on all 13 filters. ControlTitleFontConfiguration. ContextRegion for cross-region identity context. Story,scenario in CreateCustomCapability API.
* Extensions.Bedrock.MEAI (4.0.6.12)
	* Fixed TypeInitializationException crash in BedrockChatClient tool calling under NativeAOT caused by circular static initialization in BedrockJsonContext

### 4.0.241.0 (2026-04-30 18:16 UTC)
* BedrockAgentCore (4.0.22.0)
	* AgentCore Identity now supports on-behalf-of token exchange OAuth2. AgentCore Memory now supports metadata for LongTerm Memory Records.
* BedrockAgentCoreControl (4.0.32.0)
	* AgentCore Identity now supports on-behalf-of token exchange OAuth2. AgentCore Memory now supports metadata for LongTerm Memory Records.
* DataZone (4.0.27.0)
	* Adds support for asynchronous notebook runs
* EKS (4.0.16.0)
	* Vended logs update param for capability vended logs feature
* Kafka (4.0.9.0)
	* Adds support for ZookeeperAccess field to control the Client-Zookeeper connectivity.
* ObservabilityAdmin (4.0.11.0)
	* Observability Admin enablement launch for AWS Kafka, Bedrock Agent Core Workload Identity and OTel metric enablement.
* PaymentCryptography (4.0.9.0)
	* Adds support for resource-based policies on AWS Payment Cryptography keys, enabling cross-account key sharing. Also adds Multi-Party Approval (MPA) team association APIs for protecting sensitive import root public key operations.
* Route53GlobalResolver (4.0.2.0)
	* Adds support for regions in the UpdateGlobalResolver input.
* SageMaker (4.0.54.0)
	* Add InstancePools support to Endpoint for flexible provisioning across a prioritized list of instance types. Add Specifications support to InferenceComponent for per-instance-type model configurations.
* SSOAdmin (4.0.6.0)
	* Add InstanceArn and IdentityStoreArn in the response of CreateApplication API and IdentityStoreArn in the response of DescribeApplication API
* Core 4.0.6.0
	* [Breaking Change] The AWSSDK ZIP artifact now organizes extension assemblies into dedicated subfolders under `extensions/` (for example, `extensions\CrtIntegration\AWSSDK.Extensions.CrtIntegration.dll`). Each subfolder contains only the extension DLL and its third-party dependencies - transitive `AWSSDK` service DLLs remain in the root directory and are not duplicated. There is no impact for customers installing the SDK via NuGet, which is the recommended installation method as described in our [developer guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-install-assemblies.html).
	* Update `System.Text.Json` dependency to `8.0.6` (for `net472` and `netstandard2.0` frameworks)

### 4.0.240.0 (2026-04-29 18:16 UTC)
* Account (4.0.4.0)
	* Adds AccountState in the response for the GetAccountInformation API. Each state represents a specific phase in the account lifecycle. Use this information to manage account access, automate workflows, or trigger actions based on account state changes.
* BedrockAgentCore (4.0.21.0)
	* Adds batch evaluation for running evaluators against multiple agent sessions with server-side orchestration, AI-powered recommendations for optimizing system prompts and tool descriptions, and AB testing with controlled traffic splitting and statistical significance reporting
* BedrockAgentCoreControl (4.0.31.0)
	* Adds configuration bundles for versioned, immutable agent configuration snapshots with branch-based lineage
* CloudFront (4.0.14.0)
	* Amazon CloudFront now supports cache tag. Tag objects via response headers and invalidate all matching objects in a single request, replacing manual URL tracking and broad wildcards.
* Deadline (4.0.19.0)
	* Adds support for rtx-pro-server-6000 GPU accelerator for service-managed fleets.
* ECR (4.0.13.4)
	* Removes support for registry policy V1
* GameLift (4.0.10.0)
	* Amazon GameLift Servers adds a new DescribeContainerGroupPortMappings API for container fleets, making it easy to discover which connection ports map to your container ports without needing to remotely access the compute.
* MediaPackageV2 (4.0.12.0)
	* This feature adds configuration for specifying SCTE marker handling and allow greater control over generated manifest and segment URIs
* Transfer (4.0.9.0)
	* This launch will increase the limits for customers to list the contents from the remote directories from 10k to 200k.
* WorkSpacesWeb (4.0.9.0)
	* Allow admins to configure IPv6 ranges on IP Access Settings.

### 4.0.239.0 (2026-04-27 19:22 UTC)
* ApplicationSignals (4.0.8.0)
	* Application Signals now supports creating composite Service Level Objectives on Service Operations. Users can now create service SLO on multiple operations.
* BillingConductor (4.0.5.0)
	* Add support for Passthrough pricing plan
* CloudWatchLogs (4.0.22.0)
	* Adds support for selecting all logs sources and types in a single association.
* GameLiftStreams (4.0.7.11)
	* Adds Proton 10.0-4 to the list of runtime environment options available when creating an Amazon GameLift Streams application
* Glue (4.0.28.0)
	* Addition of AdditionalAuditContext to GetPartition, GetPartitions, GetTableVersion, and GetTableVersions
* IVS (4.0.4.0)
	* Adds tags parameter to the CreateAdConfiguration operation
* KeyManagementService (4.0.10.0)
	* KMS GetKeyLastUsage API provides information on the last successful cryptographic operation performed on KMS keys. This new API provides KMS customers with the last timestamp, CloudTrail eventId, and the cryptographic operation that was performed on the key.
* Mgn (4.0.6.0)
	* Added network modernization support, enabling customers to edit, resize, merge, and split VPCs and subnets during migration while retaining functional, non-conflicting IP addresses.
* Omics (4.0.8.0)
	* Enable Public Internet or VPC configuration to BatchRun
* OpenSearchService (4.0.19.0)
	* Amazon OpenSearch Service now supports JWKS URL configuration for JWT authentication
* SageMaker (4.0.53.0)
	* Updated API documentation for endpoint MetricsConfig. Added details on supported metric publish frequencies and clarified how EnableEnhancedMetrics controls utilization and invocation metric behavior.
* WorkSpaces (4.0.11.0)
	* Added support for Protocol as modified resource and added update failure as modification state
* Core 4.0.5.0
	* Add TracerProvider.GetTracer() method overload that accepts Attributes to use to create the Tracer.

### 4.0.238.0 (2026-04-24 18:27 UTC)
* BedrockAgentCoreControl (4.0.30.0)
	* Added support for configuring identity providers and inbound authorizers within a private VPC for AWS Bedrock AgentCore, enabling secure network connection without public internet access
* CloudWatchLogs (4.0.21.0)
	* Adding nextToken and maxItems to the GetQueryResults API.
* Connect (4.0.43.0)
	* Amazon Connect is expanding attachment capabilities to give customers greater flexibility and control. Currently limited to predefined file types, the new feature will allow contact center administrators to customize which file extensions and sizes are supported across chat, email, tasks, and cases.
* ConnectHealth (4.0.1.0)
	* Corrected CreateWebAppConfiguration documentation. Adding slash as an allowed character for the Ambient documentation agent to allow pronoun specifications.
* DynamoDBStreams (4.0.4.27)
	* Remove max-retries from DynamoDB Streams service and depend on values applied in the `AWSSDK.Core` package.
* DynamoDBv2 (4.0.17.11)
	* Remove max-retries from DynamoDB service and depend on values applied in the `AWSSDK.Core` package.
* Evs (4.0.7.0)
	* EVS now supports i7i.metal-24xl EC2 bare metal instance type, delivering high random IOPS performance with real-time latency, ideal for IO intensive and latency-sensitive workloads such as transactional databases, real-time analytics, and AI ML pre-processing.
* Transfer (4.0.8.0)
	* AWS Transfer Family now support configurable IP address types for Web Apps of type VPC, enabling customers to select IPv4-only or dual-stack (IPv4 and IPv6) configurations based on their network requirements.
* Core 4.0.4.0
	* Cache compiled Regex instances in Partition and RegionEndpoint for endpoint resolution performance
	* Implements the updated Retry Behavior behind a feature flag (AWS_NEW_RETRIES_2026).
	* All service and extension packages updated to require new Core

### 4.0.237.0 (2026-04-23 18:19 UTC)
* DataZone (4.0.26.0)
	* Releasing For LakehouseProperties attributes in the Connections API's
* IoTManagedIntegrations (4.0.7.0)
	* Adds "Status" field to provisioning profile operation response types, giving users visibility into the readiness of a provisioning profile to be used for device provisioning.
* OpenSearchService (4.0.18.0)
	* Amazon OpenSearch UI applications now support cross-Region domain association, enabling you to connect OpenSearch Dashboards in one AWS Region to OpenSearch domains in other Regions within the same partition for centralized data visualization.
* PCS (4.0.13.9)
	* This release adds support for Slurm 25.11 with expedited requeue enabled by default for jobs failing due to node issues, configurable requeue delay, health checks at node startup only, and unauthenticated HTTP endpoints disabled by default for improved security.

### 4.0.236.0 (2026-04-22 18:23 UTC)
* Batch (4.0.9.0)
	* Support of S3Files volume type, container start and stop timeouts.
* BedrockAgentCore (4.0.20.0)
	* Adds support for Amazon Bedrock AgentCore Harness data plane APIs, enabling customers to invoke managed agent loops and execute commands on live agent sessions with streaming responses.
* BedrockAgentCoreControl (4.0.29.0)
	* Adds support for Amazon Bedrock AgentCore Harness control plane APIs, enabling customers to create, manage, and configure managed agent loops with customizable models, tools, memory, and isolated execution environments.
* EC2 (4.0.85.0)
	* Managed resource visibility settings control whether resources that AWS services provision on your behalf within your AWS account appear in your Amazon console views and API list operations.
* ECS (4.0.20.0)
	* GPU health monitoring and auto-repair for ECS Managed Instances
* EMRServerless (4.0.9.0)
	* This release adds support for Spark connect sessions starting with release label emr-7.13.0.
* IoTWireless (4.0.6.0)
	* Enable customers to optionally specify a desired confidence level for Cellular and WiFi position estimates. Customers can use this to trade off confidence level and radius of uncertainty based on their needs.
* IVS (4.0.3.0)
	* Adds support for Amazon IVS server-side ad insertion
* Lambda (4.0.15.0)
	* Add Ruby 4.0 (ruby4.0) support to AWS Lambda.
* OpenSearchService (4.0.17.0)
	* Adds support for RollbackServiceSoftwareUpdate API
* OSIS (4.0.5.0)
	* Update the pipeline configuration body character limit for the CreatePipeline API call.
* S3 (4.0.22.0)
	* This release adds five additional checksum algorithms for S3 data integrity (MD5, SHA-512, XXHash3, XXHash64, XXHash128) and support for S3 Inventory on directory buckets (S3 Express One Zone).
* S3Control (4.0.11.0)
	* This release adds support for five additional checksum algorithms for data integrity checking in Amazon S3 - MD5, SHA-512, XXHash3, XXHash64, and XXHash128.
* Core 4.0.3.32
	* [Breaking Change] DefaultAWSCredentialsIdentityResolver implements IDisposable now. Most users will be unaffected since the static GetCredentials() or GetCredentialsAsync() methods are being called.
	* Fix credential resolution issue under high concurrency where multiple threads simultaneously walked the credential chain causing initial service calls to fail.
	* Use MD5.HashData() on .NET 8+ to reduce allocations in CryptoUtil.ComputeMD5Hash.
	* All service and extension packages updated to require new Core

### 4.0.235.0 (2026-04-21 20:12 UTC)
* CognitoIdentityProvider (4.0.8.0)
	* Adding dutch language support for Cognito Managed Login and Terms on Console
* ComprehendMedical (4.0.3.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.1. The SDK will prioritize its most performant protocol.
* ComputeOptimizer (4.0.5.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.0. The SDK will prioritize its most performant protocol.
* ComputeOptimizerAutomation (4.0.1.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.0. The SDK will prioritize its most performant protocol.
* GameLift (4.0.9.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.1. The SDK will prioritize its most performant protocol.
* MarketplaceEntitlementService (4.0.5.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.1. The SDK will prioritize its most performant protocol.
* NetworkFirewall (4.0.11.0)
	* Support for new types of partner managed rulegroups for Network Firewall Service
* SageMaker (4.0.52.0)
	* SageMaker AI now supports generative AI inference recommendations. Provide your model and workload, and SageMaker AI optimizes configurations, benchmarks them on real GPUs, and returns deployment-ready recommendations with validated metrics, accelerating the path to production from weeks to hours.
* Snowball (4.0.2.0)
	* This release adds Smithy RPC v2 CBOR as an additional protocol alongside the existing AWS JSON 1.1. The SDK will prioritize its most performant protocol.

### 4.0.234.0 (2026-04-20 18:24 UTC)
* ApplicationSignals (4.0.7.0)
	* Releasing Second phase of SLO Recommendations where you can create recommended SLOs out-of-the box using CreateSLO API
* BedrockAgentCoreControl (4.0.28.0)
	* Supporting listingMode for AgentCore Gateway MCP server targets
* EC2 (4.0.84.0)
	* Added Transit Gateway Integration into AWS Client VPN.
* Evs (4.0.6.0)
	* Amazon EVS now allows you to create connectors to your vCenter appliances and create Windows Server entitlements for virtual machines running in your EVS environments
* GuardDuty (4.0.18.2)
	* Expanded support for new suppression rule fields.
* Kafka (4.0.8.0)
	* Amazon MSK Replicator now supports data migration from external Apache Kafka clusters to Amazon MSK Express brokers. This release adds SaslScram authentication with TLS encryption, enhanced consumer offset synchronization, and customer log forwarding for troubleshooting.
* LocationService (4.0.4.0)
	* This release adds support for new Job APIs for bulk workloads. The initial job type supported is Address Validation. The new APIs added are StartJob, CancelJob, ListJobs, and GetJob.
* ObservabilityAdmin (4.0.10.0)
	* Enablement for Security Hub v2 via Observability Admin Telemetry Rule for account and organization level.
* Core 4.0.3.31
	* Revert internal CI change for generating SDK ZIP artifacts

### 4.0.233.0 (2026-04-17 18:15 UTC)
* CleanRooms (4.0.16.0)
	* This release adds support for configurable spark properties for Cleanrooms PySpark workloads.
* Connect (4.0.42.0)
	* Fixes in SDK for customers using TestCase APIs
* ConnectCampaignsV2 (4.0.7.0)
	* This release adds support for campaign entry limits configuration and hourly refresh frequency in Amazon Connect Outbound Campaigns.
* GroundStation (4.0.4.0)
	* Adds support for updating contacts, listing antennas, and listing ground station reservations. New API operations - UpdateContact, ListContactVersions, DescribeContactVersion, ListAntennas, and ListGroundStationReservations.
* Imagebuilder (4.0.10.0)
	* ImportDiskImage API adds registerImageOptions for Secure Boot control and custom UEFI data. It adds windowsConfiguration for selecting a specific edition from multi-image .wim files during ISO import.
* Neptune (4.0.5.11)
	* Improving Documentation for Neptune
* QuickSight (4.0.19.0)
	* Public release of dashboard customization summary, S3 Tables data source type, Athena cross-account connector, custom sorting for controls, and AI-powered analysis generation.
* SageMaker (4.0.51.0)
	* Adds support for providing NetworkInterface for efa enabled instances and Simplified cluster creation for Slurm-orchestrated clusters with optional Lifecycle Script (LCS) configuration.
* SecurityToken (4.0.6.0)
	* The STS client now supports configuring SigV4a through the auth scheme preference setting. SigV4a uses asymmetric cryptography, enabling customers using long-term IAM credentials to continue making STS API calls even when a region is isolated from the partition leader.
* Extensions.CloudFront.Signers (4.0.1.0)
	* `AmazonCloudFrontUrlSigner` and `AmazonCloudFrontCookieSigner` now support ECDSA private keys in addition to RSA. The key type is detected automatically, so no API changes are required (https://github.com/aws/aws-sdk-net/issues/4304)
	* A `Hash-Algorithm` query parameter (for URLs) or `CloudFront-Hash-Algorithm` attribute (for cookies) is included in the output with the algorithm used to create the signature.
	* Signing methods now accept an optional `HashAlgorithmName` parameter, enabling `SHA-256` signatures for RSA keys. Existing callers that omit the parameter continue to use `SHA-1` for backwards compatibility (https://github.com/aws/aws-sdk-net/issues/4345)
	* Updated `BouncyCastle.Cryptography` dependency from version `2.4.0` to `2.6.2`

### 4.0.232.0 (2026-04-16 18:15 UTC)
* AppStream (4.0.9.0)
	* Add content redirection to Update Stack
* AutoScaling (4.0.10.0)
	* This release adds support for specifying Availability Zone IDs as an alternative to Availability Zone names when creating or updating Auto Scaling groups.
* BedrockAgentCore (4.0.19.0)
	* Introducing NamespacePath in AgentCore Memory to support hierarchical prefix based memory record retrieval.
* CloudWatch (4.0.9.4)
	* Update documentation of alarm mute rules start and end date fields
* CloudWatchLogs (4.0.20.0)
	* Endpoint update for CloudWatch Logs Streaming APIs.
* CognitoIdentityProvider (4.0.7.0)
	* Adds support for passkey-based multi-factor authentication in Cognito User Pools. Users can authenticate securely using FIDO2-compliant passkeys with user verification, enabling passwordless MFA flows while maintaining backward compatibility with password-based authentication
* Connect (4.0.41.0)
	* This release updates the Amazon Connect Rules CRUD APIs to support a new EventSourceName - OnEmailAnalysisAvailable. Use this event source to trigger rules when conversational analytics results are available for email contacts.
* ConnectCases (4.0.13.0)
	* Added error handling for service quota limits
* CustomerProfiles (4.0.11.0)
	* Amazon Connect Customer Profiles adds RecommenderSchema CRUD APIs for custom ML training columns. CreateRecommender and CreateRecommenderFilter now accept optional RecommenderSchemaName.
* DataZone (4.0.25.0)
	* Launching SMUS IAM domain SDK support
* DevOpsAgent (4.0.3.0)
	* Deprecate the userId from the Chat operations. This update also removes  support of AllowVendedLogDeliveryForResource API from AWS SDKs.
* Drs (4.0.4.0)
	* Updating regex for identification of AWS Regions.
* DynamoDBv2 (4.0.17.9)
	* [BugFix] Fix DynamoDB AOT/trim issue on PropertyStorage Validate.
* MediaConvert (4.0.17.0)
	* Adds support for Elemental Inference powered smart crop feature, enabling video verticalization
* RDS (4.0.20.0)
	* Adds a new DescribeServerlessV2PlatformVersions API to describe platform version properties for Aurora Serverless v2. Also introduces a new valid maintenance action value for serverless platform version updates.
* S3 (4.0.21.2)
	* Update customization hook used in GetLifecycleConfigurationOutput.
* Extensions.Logging.Log4NetAdaptor (4.0.1.0)
	* Updated log4net dependency from 3.0.1 to 3.3.0 to resolve known moderate severity vulnerability (GHSA-4f7c-pmjv-c25w)
* Core 4.0.3.30
	* Update docs on GetCredentials and GetCredentialsAsync to clarify background refresh behavior

### 4.0.231.0 (2026-04-13 18:21 UTC)
* CustomerProfiles (4.0.10.0)
	* This release introduces changes to SegmentDefinition APIs to support sorting by attributes.
* Deadline (4.0.18.0)
	* Adds GetMonitorSettings and UpdateMonitorSettings APIs to Deadline Cloud. Enables reading and writing monitor settings as key-value pairs (up to 64 keys per monitor). UpdateMonitorSettings supports upsert and delete (via empty value) semantics and is idempotent.
* Glue (4.0.27.9)
	* AWS Glue now defaults to Glue version 5.1 for newly created jobs if the Glue version is not specified in the request, and UpdateJob now preserves the existing Glue version of a job when the Glue version is not specified in the update request.
* Interconnect (4.0.0.0)
	* Initial release of AWS Interconnect -- a managed private connectivity service that enables you to create high-speed network connections between your AWS Virtual Private Clouds (VPCs) and your VPCs on other public clouds or your on-premise networks.
* Macie2 (4.0.3.0)
	* This release adds an optional expectedBucketOwner field to the Macie S3 export configuration, allowing customers to verify bucket ownership before Macie writes results to the destination bucket.
* SecurityHub (4.0.9.0)
	* Provide organizational unit scoping capability for GetFindingsV2, GetFindingStatisticsV2, GetResourcesV2, GetResourcesStatisticsV2 APIs.

### 4.0.230.0 (2026-04-10 18:22 UTC)
* Connect (4.0.40.0)
	* Conversational Analytics for Email
* DevOpsAgent (4.0.2.0)
	* Devops Agent now supports associate Splunk, Datadog and custom MCP server to an Agent Space.
* ECS (4.0.19.0)
	* Minor updates to exceptions for completeness
* Imagebuilder (4.0.9.0)
	* Image pipelines can now automatically apply tags to images they create. Set the imageTags property when creating or updating your pipelines to get started.
* MediaConvert (4.0.16.0)
	* Adds support for MV-HEVC video output and clear lead for AV1 DRM output.
* ObservabilityAdmin (4.0.9.0)
	* CloudWatch Observability Admin adds support for multi-region telemetry evaluation and telemetry enablement rules.
* RTBFabric (4.0.4.0)
	* Adds optional health check configuration for Responder Gateways with ASG Managed Endpoints. When provided, RTB Fabric continuously probes customers' instance IPs and routes traffic only to healthy ones, reducing errors during deployments, scaling events, and instance failures.
* SageMaker (4.0.50.0)
	* Support new SageMaker StartClusterHealthCheck API for on-demand DHC on Hyperpod EKS cluster. Support updated CreateCluster, UpdateCluster, DescribeCluster, BatchAddClusterNodes APIs for flexible instance group on HyperPod cluster
* Core 4.0.3.29
	* Fixed adaptive retry mode to adjust client send rate when retries are disabled.
	* All service and extension packages updated to require new Core

### 4.0.229.0 (2026-04-09 18:27 UTC)
* BCMDashboards (4.0.3.0)
	* Scheduled email reports of Billing and Cost Management Dashboards
* BedrockAgentCore (4.0.18.0)
	* Introducing support for SearchRegistryRecords API on AgentCoreRegistry
* BedrockAgentCoreControl (4.0.27.0)
	* Initial release for CRUDL in AgentCore Registry Service
* MediaConnect (4.0.7.0)
	* Adds support for MediaLive Channel-type Router Inputs.
* RedshiftDataAPIService (4.0.4.0)
	* The BatchExecuteStatement API now supports named SQL parameters, enabling secure batch queries with parameterized values. This enhancement helps prevent SQL injection vulnerabilities and improves query reusability.
* SageMaker (4.0.49.0)
	* Release support for g7e instance types for SageMaker HyperPod

### 4.0.228.0 (2026-04-08 20:03 UTC)
* Backup (4.0.11.0)
	* Adding EKS specific backup vault notification types for AWS Backup.
* Drs (4.0.3.0)
	* This changes adds support for modifying the replication configuration to support data replication using IPv6.
* ECR (4.0.13.0)
	* Add UnableToListUpstreamImageReferrersException in ListImageReferrers
* IVSRealTime (4.0.7.0)
	* Adds support for Amazon IVS real-time streaming redundant ingest.
* MarketplaceDiscovery (4.0.0.0)
	* AWS Marketplace Discovery API provides an interface that enables programmatic access to the AWS Marketplace catalog, including searching and browsing listings, retrieving product details and fulfillment options, and accessing public and private offer pricing and terms.
* MediaLive (4.0.19.0)
	* MediaLive is adding support for MediaConnect Router by supporting a new output type called MEDIACONNECT ROUTER. This new output type will provide seamless encrypted transport between your MediaLive channel and MediaConnect Router.
* Outposts (4.0.6.0)
	* Add AWS Outposts APIs to view renewal pricing options and submit renewal requests for Outpost contracts

### 4.0.227.0 (2026-04-07 18:24 UTC)
* AccessAnalyzer (4.0.6.0)
	* Revert previous additions of API changes.
* BedrockAgentCore (4.0.17.0)
	* This release includes support for 1) InvokeBrowser API, enabling OS-level control of AgentCore Browser Tool sessions through mouse actions, keyboard input, and screenshots. 2) Added documentation noting that empty sessions are automatically deleted after one day in the ListSessions API.
* Braket (4.0.5.0)
	* Added support for t3, g6, and g6e instance types for Hybrid Jobs.
* Connect (4.0.39.0)
	* The voice enhancement mode used by the agent can now be viewed on the contact record via the DescribeContact api.
* DataSync (4.0.10.0)
	* Allow IAM role ARNs with IAM Paths for "SecretAccessRoleArn" field in "CustomSecretConfig"
* DataZone (4.0.24.0)
	* Update Configurations and registerS3AccessGrantLocation as public attributes for cfn
* EC2 (4.0.83.0)
	* EC2 Capacity Manager adds new dimensions for grouping and filtering capacity metrics, including tag-based dimensions and Account Name.
* ECS (4.0.18.0)
	* This release provides the functionality of mounting Amazon S3 Files to Amazon ECS tasks by adding support for the new S3FilesVolumeConfiguration parameter in ECS RegisterTaskDefinition API.
* EKS (4.0.15.0)
	* EKS MNG WarmPool feature to support ASG WarmPool feature.
* Lambda (4.0.14.0)
	* Launching Lambda integration with S3 Files as a new file system configuration.
* Outposts (4.0.5.0)
	* This change allows listAssets to surface pending and non-compute asset information. Adds the INSTALLING asset state enum and the STORAGE, POWERSHELF, SWITCH, and NETWORKING AssetTypes.
* RTBFabric (4.0.3.0)
	* AWS RTB Fabric External Responder gateways now support HTTP in addition to HTTPS for inbound external links. Gateways can accept bid requests on port 80 or serve both protocols simultaneously via listener configuration, giving customers flexible transport options for their bidding infrastructure
* S3 (4.0.21.0)
	* Updated list of the valid AWS Region values for the LocationConstraint parameter for general purpose buckets.
* S3Files (4.0.0.0)
	* Support for S3 Files, a new shared file system that connects any AWS compute directly with your data in Amazon S3. It provides fast, direct access to all of your S3 data as files with full file system semantics and low-latency performance, without your data ever leaving S3.

### 4.0.226.0 (2026-04-06 18:29 UTC)
* AccessAnalyzer (4.0.5.0)
	* Brookie helps customers preview the impact of SCPs before deployment using historical access activity. It evaluates attached policies and proposed policy updates using collected access activity through CloudTrail authorization events and reports where currently allowed access will be denied.
* Deadline (4.0.17.0)
	* Added 8 batch APIs (BatchGetJob, BatchGetStep, BatchGetTask, BatchGetSession, BatchGetSessionAction, BatchGetWorker, BatchUpdateJob, BatchUpdateTask) for bulk operations. Monitors can now use an Identity Center instance in a different region via the identityCenterRegion parameter.
* DLM (4.0.3.0)
	* This release adds support for Fast Snapshot Restore AvailabilityZone Ids in Amazon Data Lifecycle Manager EBS snapshot lifecycle policies.
* GeoMaps (4.0.5.4)
	* This release updates API reference documentation for Amazon Location Service Maps APIs to reflect regional restrictions for Grab Maps users
* GuardDuty (4.0.18.0)
	* Migrated to Smithy. No functional changes
* Lightsail (4.0.7.0)
	* This release adds support for the Asia Pacific (Malaysia) (ap-southeast-5) Region.
* MediaTailor (4.0.7.0)
	* This change adds support for Tagging the resource types Programs and Prefetch Schedules
* QConnect (4.0.9.0)
	* Added optional originRequestId parameter to SendMessageRequest and ListSpans response in Amazon Q in Connect to support request tracing across service boundaries.
* Transfer (4.0.7.0)
	* AWS Transfer Family Connectors now support IPv6 connectivity, enabling outbound connections to remote SFTP or AS2 servers using IPv4-only or dual-stack (IPv4 and IPv6) configurations based on network requirements.
* Core 4.0.3.28
	* Added unified platform map for cross-platform API documentation generation
	* All service and extension packages updated to require new Core

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

