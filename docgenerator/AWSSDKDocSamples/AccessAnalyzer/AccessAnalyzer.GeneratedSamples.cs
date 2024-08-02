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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}