using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AccessAnalyzer;
using Amazon.AccessAnalyzer.Model;

namespace AWSSDKDocSamples.Amazon.AccessAnalyzer.Generated
{
    class AccessAnalyzerSamples : ISample
    {
        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region CheckAccessNotGranted-1

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
            CheckAccessNotGrantedResult result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region CheckAccessNotGranted-2

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
            CheckAccessNotGrantedResult result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckAccessNotGranted()
        {
            #region CheckAccessNotGranted-3

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
            CheckAccessNotGrantedResult result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckNoPublicAccess()
        {
            #region CheckNoPublicAccess-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckNoPublicAccess(new CheckNoPublicAccessRequest
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Bob\",\"Effect\":\"Allow\",\"Principal\":{\"AWS\":\"arn:aws:iam::111122223333:user/JohnDoe\"},\"Action\":[\"s3:GetObject\"]}]}",
                ResourceType = "AWS::S3::Bucket"
            });

            string message = response.Message;
            CheckNoPublicAccessResult result = response.Result;

            #endregion
        }

        public void AccessAnalyzerCheckNoPublicAccess()
        {
            #region CheckNoPublicAccess-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.CheckNoPublicAccess(new CheckNoPublicAccessRequest
            {
                PolicyDocument = "{\"Version\":\"2012-10-17\",\"Statement\":[{\"Sid\":\"Bob\",\"Effect\":\"Allow\",\"Principal\":\"*\",\"Action\":[\"s3:GetObject\"]}]}",
                ResourceType = "AWS::S3::Bucket"
            });

            string message = response.Message;
            List<ReasonSummary> reasons = response.Reasons;
            CheckNoPublicAccessResult result = response.Result;

            #endregion
        }

        public void AccessAnalyzerGenerateFindingRecommendation()
        {
            #region GenerateFindingRecommendation-1

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
            #region GenerateFindingRecommendation-2

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
            #region GetFindingRecommendation-1

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3,
                NextToken = "token"
            });

            DateTime? completedAt = response.CompletedAt;
            RecommendationType recommendationType = response.RecommendationType;
            List<RecommendedStep> recommendedSteps = response.RecommendedSteps;
            string resourceArn = response.ResourceArn;
            DateTime? startedAt = response.StartedAt;
            Status status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region GetFindingRecommendation-2

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3
            });

            RecommendationType recommendationType = response.RecommendationType;
            string resourceArn = response.ResourceArn;
            DateTime? startedAt = response.StartedAt;
            Status status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region GetFindingRecommendation-3

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "finding-id",
                MaxResults = 3
            });

            DateTime? completedAt = response.CompletedAt;
            RecommendationError error = response.Error;
            RecommendationType recommendationType = response.RecommendationType;
            string resourceArn = response.ResourceArn;
            DateTime? startedAt = response.StartedAt;
            Status status = response.Status;

            #endregion
        }

        public void AccessAnalyzerGetFindingRecommendation()
        {
            #region GetFindingRecommendation-4

            var client = new AmazonAccessAnalyzerClient();
            var response = client.GetFindingRecommendation(new GetFindingRecommendationRequest
            {
                AnalyzerArn = "arn:aws:access-analyzer:us-east-1:111122223333:analyzer/a",
                Id = "!"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
