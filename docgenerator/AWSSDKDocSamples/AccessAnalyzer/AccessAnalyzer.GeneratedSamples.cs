using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AccessAnalyzer;
using Amazon.AccessAnalyzer.Model;

namespace AWSSDKDocSamples.Amazon.AccessAnalyzer.Generated
{
    class AccessAnalyzerSamples : ISample
    {
        public void AccessAnalyzerCancelPolicyPreviewJob()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CancelPolicyPreviewJob(new CancelPolicyPreviewJobRequest 
            {
                JobId = "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
            });


            #endregion
        }

        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckAccessNotGranted(new CheckAccessNotGrantedRequest 
            {
                Access = new List<Access> {
                    new Access { Actions = new List<string> {
                        "s3:PutObject"
                    } }
                },
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Id\":\"123\",\"Statement\":[{\"Sid\":\"AllowJohnDoe\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::123456789012:user/JohnDoe\"},\"Action\":\"s3:GetObject\",\"Resource\":\"*\"}]}",
                PolicyType = "RESOURCE_POLICY"
            });

            string message = response.Message;
            string result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckAccessNotGranted(new CheckAccessNotGrantedRequest 
            {
                Access = new List<Access> {
                    new Access { Resources = new List<string> {
                        "arn:aws:s3:::sensitive-bucket/*"
                    } }
                },
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Id\":\"123\",\"Statement\":[{\"Sid\":\"AllowJohnDoe\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::123456789012:user/JohnDoe\"},\"Action\":\"s3:PutObject\",\"Resource\":\"arn:aws:s3:::non-sensitive-bucket/*\"}]}",
                PolicyType = "RESOURCE_POLICY"
            });

            string message = response.Message;
            string result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region example-3

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckAccessNotGranted(new CheckAccessNotGrantedRequest 
            {
                Access = new List<Access> {
                    new Access { Resources = new List<string> {
                        "arn:aws:s3:::my-bucket/*"
                    } }
                },
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Id\":\"123\",\"Statement\":[{\"Sid\":\"AllowJohnDoe\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::123456789012:user/JohnDoe\"},\"Action\":\"s3:PutObject\",\"Resource\":\"arn:aws:s3:::my-bucket/*\"}]}",
                PolicyType = "RESOURCE_POLICY"
            });

            string message = response.Message;
            List<ReasonSummary> reasons = response.Reasons;
            string result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckNoPublicAccess()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckNoPublicAccess(new CheckNoPublicAccessRequest 
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Bob\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::111122223333:user/JohnDoe\"},\"Action\":[\"s3:GetObject\"]}]}",
                ResourceType = "AWS::S3::Bucket"
            });

            string message = response.Message;
            string result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckNoPublicAccess()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckNoPublicAccess(new CheckNoPublicAccessRequest 
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Bob\",\"Effect\":\"Allow\",\"Principal\":\"*\",\"Action\":[\"s3:GetObject\"]}]}",
                ResourceType = "AWS::S3::Bucket"
            });

            string message = response.Message;
            List<ReasonSummary> reasons = response.Reasons;
            string result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCreatePolicyPreviewConfiguration()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CreatePolicyPreviewConfiguration(new CreatePolicyPreviewConfigurationRequest 
            {
                ClientToken = "unique-token-123",
                Scope = "GLOBAL"
            });

            string status = response.Status;

            #endregion
        }

        public void AccessAnalyzerDeletePolicyPreviewConfiguration()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.DeletePolicyPreviewConfiguration(new DeletePolicyPreviewConfigurationRequest 
            {
                ClientToken = "unique-token-456"
            });


            #endregion
        }

        public void AccessAnalyzerGenerateFindingRecommendation()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GenerateFindingRecommendation(new GenerateFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id"
            });


            #endregion
        }

        public void AccessAnalyzerGenerateFindingRecommendation()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GenerateFindingRecommendation(new GenerateFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "!"
            });


            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3,
                NextToken = "token"
            });

            DateTime completedAt = response.CompletedAt;
            string recommendationType = response.RecommendationType;
            List<RecommendedStep> recommendedSteps = response.RecommendedSteps;
            string resourceArn = response.ResourceArn;
            DateTime startedAt = response.StartedAt;
            string status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3
            });

            string recommendationType = response.RecommendationType;
            string resourceArn = response.ResourceArn;
            DateTime startedAt = response.StartedAt;
            string status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region example-3

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3
            });

            DateTime completedAt = response.CompletedAt;
            RecommendationError error = response.Error;
            string recommendationType = response.RecommendationType;
            string resourceArn = response.ResourceArn;
            DateTime startedAt = response.StartedAt;
            string status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region example-4

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest 
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "!"
            });


            #endregion
        }

        public void AccessAnalyzerGetPolicyPreviewConfiguration()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetPolicyPreviewConfiguration(new GetPolicyPreviewConfigurationRequest 
            {
            });

            List<PolicyPreviewConfiguration> policyPreviewConfigurations = response.PolicyPreviewConfigurations;

            #endregion
        }

        public void AccessAnalyzerGetPolicyPreviewJob()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetPolicyPreviewJob(new GetPolicyPreviewJobRequest 
            {
                JobId = "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
            });

            PolicyPreviewJobDetails jobDetails = response.JobDetails;
            string jobId = response.JobId;
            PolicyPreviewJobParameters jobParameters = response.JobParameters;
            string outputs3Uri = response.OutputS3Uri;

            #endregion
        }

        public void AccessAnalyzerGetPolicyPreviewJob()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetPolicyPreviewJob(new GetPolicyPreviewJobRequest 
            {
                JobId = "b2c3d4e5-f6a7-8901-bcde-f12345678901"
            });

            PolicyPreviewJobDetails jobDetails = response.JobDetails;
            string jobId = response.JobId;
            PolicyPreviewJobParameters jobParameters = response.JobParameters;
            string outputs3Uri = response.OutputS3Uri;

            #endregion
        }

        public void AccessAnalyzerListPolicyPreviewJobs()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.ListPolicyPreviewJobs(new ListPolicyPreviewJobsRequest 
            {
                Filters = new Dictionary<string, string> {
                    { "jobStatus", "COMPLETED" }
                },
                MaxResults = 10,
                NextToken = "token-123"
            });

            List<PolicyPreviewAnalysisReport> analysisReports = response.AnalysisReports;
            string nextToken = response.NextToken;

            #endregion
        }

        public void AccessAnalyzerStartPolicyPreviewJob()
        {
            #region example-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.StartPolicyPreviewJob(new StartPolicyPreviewJobRequest 
            {
                ClientToken = "unique-token-123",
                EndTime = new DateTime(2023, 12, 31, 11, 59, 59, DateTimeKind.Utc),
                OutputS3Uri = "s3://bucket/path",
                PolicyConfigurations = new List<PolicyConfiguration> {
                    new PolicyConfiguration {
                        JobType = "SCP",
                        PolicyDocumentsList = new List<string> {
                            "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"AllowS3Access\",\"Effect\":\"Allow\",\"Action\":[\"s3:GetObject\",\"s3:PutObject\",\"s3:ListBucket\"],\"Resource\":[\"arn:aws:s3:::example-bucket\",\"arn:aws:s3:::example-bucket/*\"]}]}"
                        },
                        TargetId = "123456789012"
                    }
                },
                StartTime = new DateTime(2023, 1, 1, 12, 0, 0, DateTimeKind.Utc)
            });

            string jobId = response.JobId;

            #endregion
        }

        public void AccessAnalyzerStartPolicyPreviewJob()
        {
            #region example-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.StartPolicyPreviewJob(new StartPolicyPreviewJobRequest 
            {
                OutputS3Uri = "s3://bucket/path",
                PolicyConfigurations = new List<PolicyConfiguration> {
                    new PolicyConfiguration {
                        JobType = "SCP",
                        PolicyDocumentsList = new List<string> {
                            "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"Deny\",\"Action\":\"s3:*\",\"Resource\":\"*\"}]}"
                        },
                        TargetId = "invalid"
                    }
                },
                StartTime = new DateTime(2023, 1, 1, 12, 0, 0, DateTimeKind.Utc)
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}