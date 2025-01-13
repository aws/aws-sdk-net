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

