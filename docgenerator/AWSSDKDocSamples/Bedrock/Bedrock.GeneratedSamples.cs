using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Bedrock;
using Amazon.Bedrock.Model;

namespace AWSSDKDocSamples.Amazon.Bedrock.Generated
{
    class BedrockSamples : ISample
    {
        public void BedrockBatchDeleteEvaluationJob()
        {
            #region example-1

            var client = new AmazonBedrockClient();
            var response = client.BatchDeleteEvaluationJob(new BatchDeleteEvaluationJobRequest 
            {
                JobIdentifiers = new List<string> {
                    "arn:aws:bedrock:us-east-2:123456789012:evaluation-job/12rnxmplqv0v",
                    "arn:aws:bedrock:us-east-2:123456789012:evaluation-job/rispxmpl12rn"
                }
            });

            List<BatchDeleteEvaluationJobError> errors = response.Errors;
            List<BatchDeleteEvaluationJobItem> evaluationJobs = response.EvaluationJobs;

            #endregion
        }

        public void BedrockCreateCustomModel()
        {
            #region example-1

            var client = new AmazonBedrockClient();
            var response = client.CreateCustomModel(new CreateCustomModelRequest 
            {
                ClientRequestToken = "foo",
                ModelKmsKeyArn = "arn:aws:kms:us-east-1:123456789012:key/1234abcd-12ab-34cd-56ef-1234567890ab",
                ModelName = "SampleModel",
                ModelSourceConfig = new ModelDataSource { S3DataSource = new S3DataSource { S3Uri = "s3://my-bucket/folder" } },
                ModelTags = new List<Tag> {
                    new Tag {
                        Key = "foo",
                        Value = "foo"
                    },
                    new Tag {
                        Key = "foo",
                        Value = "foo"
                    }
                },
                RoleArn = "arn:aws:iam::123456789012:role/SampleRole"
            });

            string modelArn = response.ModelArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}