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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}