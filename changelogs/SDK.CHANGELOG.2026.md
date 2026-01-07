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

