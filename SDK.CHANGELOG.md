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
