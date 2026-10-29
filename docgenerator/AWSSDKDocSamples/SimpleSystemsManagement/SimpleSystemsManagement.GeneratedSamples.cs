using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AWSSDKDocSamples.Amazon.SimpleSystemsManagement.Generated
{
    class SimpleSystemsManagementSamples : ISample
    {
        public void SimpleSystemsManagementListNodesSummary()
        {
            #region ListNodesSummary-1

            var client = new AmazonSimpleSystemsManagementClient();
            var response = client.ListNodesSummary(new ListNodesSummaryRequest
            {
                Aggregators = new List<NodeAggregator> {
                    new NodeAggregator {
                        AggregatorType = "Count",
                        AttributeName = "Region",
                        TypeName = "Instance"
                    }
                },
                Filters = new List<NodeFilter> {
                    new NodeFilter {
                        Key = "InstanceStatus",
                        Type = "Equal",
                        Values = new List<string> {
                            "Active"
                        }
                    }
                },
                MaxResults = 2,
                NextToken = "A9lT8CAxj9aDFRi+MNAoFq08I---EXAMPLE",
                SyncName = "AWS-QuickSetup-ManagedNode"
            });

            List<Dictionary<string, string>> summary = response.Summary;

            #endregion
        }

        public void SimpleSystemsManagementStartExecutionPreview()
        {
            #region StartExecutionPreview-1

            var client = new AmazonSimpleSystemsManagementClient();
            var response = client.StartExecutionPreview(new StartExecutionPreviewRequest
            {
                DocumentName = "AWS-StartEC2Instance"
            });

            string executionPreviewId = response.ExecutionPreviewId;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
