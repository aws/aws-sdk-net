using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AWSSDKDocSamples.Amazon.SimpleSystemsManagement.Generated
{
    class SimpleSystemsManagementSamples : ISample
    {
        public void SimpleSystemsManagementGetExecutionPreview()
        {
            #region getexecutionpreview-f6ae6a7e734e

            var client = new AmazonSimpleSystemsManagementClient();
            var response = client.GetExecutionPreview(new GetExecutionPreviewRequest 
            {
                ExecutionPreviewId = "2f27d6e5-9676-4708-b8bd-aef0ab47bb26"
            });

            DateTime endedAt = response.EndedAt;
            ExecutionPreview executionPreview = response.ExecutionPreview;
            string executionPreviewId = response.ExecutionPreviewId;
            string status = response.Status;

            #endregion
        }

        public void SimpleSystemsManagementListNodes()
        {
            #region listnodes--ec13d561ee02

            var client = new AmazonSimpleSystemsManagementClient();
            var response = client.ListNodes(new ListNodesRequest 
            {
                Filters = new List<NodeFilter> {
                    new NodeFilter {
                        Key = "Region",
                        Type = "Equal",
                        Values = new List<string> {
                            "us-east-2"
                        }
                    }
                },
                MaxResults = 1,
                SyncName = "AWS-QuickSetup-ManagedNode"
            });

            string nextToken = response.NextToken;
            List<Node> nodes = response.Nodes;

            #endregion
        }

        public void SimpleSystemsManagementListNodesSummary()
        {
            #region listnodessummary-9a63f9e71ee0

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
            #region startexecutionpreview-7a6b962646a9

            var client = new AmazonSimpleSystemsManagementClient();
            var response = client.StartExecutionPreview(new StartExecutionPreviewRequest 
            {
                DocumentName = "AWS-StartEC2Instance"
            });

            string executionPreviewId = response.ExecutionPreviewId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}