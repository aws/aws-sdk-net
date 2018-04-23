
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.AWSMarketplaceCommerceAnalytics;
using Amazon.AWSMarketplaceCommerceAnalytics.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using AWSSDK_DotNet.IntegrationTests.Utils;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AWSMarketplaceCommerceAnalytics : TestBase<AmazonAWSMarketplaceCommerceAnalyticsClient>
    {
        // You need to set the ExternalId provided by the service for your account before you can run the test.
        const string ExternalId = "";

        static string TrustPolicy =
          @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Sid"": """",
                  ""Effect"": ""Allow"",
                  ""Principal"": {
                    ""AWS"": ""arn:aws:iam::452565589796:root""
                  },
                  ""Action"": ""sts:AssumeRole"",
                  ""Condition"": {
                    ""StringEquals"": {
                      ""sts:ExternalId"": """ + ExternalId + @"""
                    }
                  }
                }
              ]
            }";

        static string AccessPolicy =
           @"{
              ""Version"": ""2012-10-17"",
              ""Statement"": [
                {
                  ""Sid"": ""1"",
                  ""Effect"": ""Allow"",
                  ""Action"": [
                    ""s3:PutObject"",
                    ""s3:GetBucketLocation""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                },
                {
                  ""Sid"": ""2"",
                  ""Effect"": ""Allow"",
                  ""Action"": [
                    ""sns:Publish"",
                    ""sns:GetTopicAttributes""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                },
                {
                  ""Sid"": ""3"",
                  ""Effect"": ""Allow"",
                  ""Action"": [
                    ""iam:GetRolePolicy""
                  ],
                  ""Resource"": [
                    ""*""
                  ]
                }
              ]
            }";

        // This test needs account specific details. 
        // You need to set the ExternalId provided by the service for your account before you can run the test.
        //[TestMethod]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        public void GenerateDatasetTest()
        {
            var iamClient = new AmazonIdentityManagementServiceClient();
            var snsClient = new AmazonSimpleNotificationServiceClient();
            var s3Client = new AmazonS3Client();

            string bucketName = null;
            string topicArn = null;
            Role role = null;
            try
            {
                bucketName = UtilityMethods.GenerateName("GenerateDatasetTestBucket");
                s3Client.PutBucket(bucketName);

                var roleName = UtilityMethods.GenerateName("GenerateDatasetTestRole");
                var policyName = "MarketplacePolicy";
                // Create a role with trust policy
                role = iamClient.CreateRole(new CreateRoleRequest
                {
                    RoleName = roleName,
                    AssumeRolePolicyDocument = TrustPolicy
                }).Role;

                // Set access policy
                iamClient.PutRolePolicy(new PutRolePolicyRequest
                {
                    RoleName = roleName,
                    PolicyDocument = AccessPolicy,
                    PolicyName = policyName
                });

                var snsTopicName = UtilityMethods.GenerateName("GenerateDatasetTestTopic");
                topicArn = snsClient.CreateTopic(snsTopicName).TopicArn;
                
                // Throws an error as this account does not have any reports
                Utils.AssertExtensions.ExpectException<AmazonAWSMarketplaceCommerceAnalyticsException>
                (   () =>
                    Client.GenerateDataSet(new GenerateDataSetRequest
                    {
                        DataSetPublicationDate = DateTime.Now,
                        DataSetType = DataSetType.DailyBusinessFees,
                        DestinationS3BucketName = bucketName,
                        SnsTopicArn = topicArn,
                        RoleNameArn = role.Arn
                    })
                );
            }
            finally
            {
                s3Client.DeleteBucket(bucketName);

                if (role!=null)
                {
                    iamClient.DeleteRolePolicy(new DeleteRolePolicyRequest
                    {
                        PolicyName = "MarketplacePolicy",
                        RoleName = role.RoleName
                    });

                    iamClient.DeleteRole(new DeleteRoleRequest
                    {
                        RoleName = role.RoleName
                    });
                }

                if (topicArn !=null)
                {
                    snsClient.DeleteTopic(topicArn);
                }
            }
        }

        [TestMethod]
        [TestCategory("AWSMarketplaceCommerceAnalytics")]
        public void TestInvalidInputs()
        {
            // Do not pass destination bucket, role ARN and SNS topic ARN.
            Utils.AssertExtensions.ExpectException<AmazonAWSMarketplaceCommerceAnalyticsException>
            (() =>
                Client.GenerateDataSet(new GenerateDataSetRequest
                {
                    DataSetPublicationDate = DateTime.Now,
                    DataSetType = DataSetType.DailyBusinessFees
                })
            );

            // Pass invalid ARN values
            Utils.AssertExtensions.ExpectException<AmazonAWSMarketplaceCommerceAnalyticsException>
            (   ()=>
                Client.GenerateDataSet(new GenerateDataSetRequest
                {
                    DataSetPublicationDate = DateTime.Now,
                    DataSetType = DataSetType.DailyBusinessFees,
                    DestinationS3BucketName = "randomBucket",
                    RoleNameArn = "invalidArn",
                    SnsTopicArn = "invalidArn"
                })
            );
        }
    }
}
