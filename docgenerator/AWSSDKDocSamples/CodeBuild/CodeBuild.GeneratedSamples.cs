using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CodeBuild;
using Amazon.CodeBuild.Model;

namespace AWSSDKDocSamples.Amazon.CodeBuild.Generated
{
    class CodeBuildSamples : ISample
    {
        public void CodeBuildBatchGetBuilds()
        {
            #region to-get-information-about-builds-1501187184588

            var client = new AmazonCodeBuildClient();
            var response = client.BatchGetBuilds(new BatchGetBuildsRequest 
            {
                Ids = new List<string> {
                    "codebuild-demo-project:9b0ac37f-d19e-4254-9079-f47e9a389eEX",
                    "codebuild-demo-project:b79a46f7-1473-4636-a23f-da9c45c208EX"
                }
            });

            List<Build> builds = response.Builds;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}