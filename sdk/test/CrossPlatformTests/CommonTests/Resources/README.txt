Files under this folder will automatically be included in the project as embedded resources.
To provide credentials to the test applications, place a file named "settings.json" into this folder and reload the project. The settings file should have the structure as shown below. Specify ResultsBucket and ResultsTopic to have test results uploaded to a specific S3 bucket and a notification sent to a specific SQS topic after the tests have executed.

{
    "AccessKeyId"     : "",
    "SecretAccessKey" : "",
    "SessionToken"    : "",
	"RegionEndpoint"  : "us-west-2",
	"ResultsBucket"   : "",
	"ResultsTopic"    : ""
}