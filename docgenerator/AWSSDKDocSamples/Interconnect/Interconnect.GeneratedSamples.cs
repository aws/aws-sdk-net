using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Interconnect;
using Amazon.Interconnect.Model;

namespace AWSSDKDocSamples.Amazon.Interconnect.Generated
{
    class InterconnectSamples : ISample
    {
        public void InterconnectAcceptConnectionProposal()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.AcceptConnectionProposal(new AcceptConnectionProposalRequest 
            {
                ActivationKey = "<Activation Key Data>",
                AttachPoint = new AttachPoint { DirectConnectGateway = "90392BE3-219C-47FD-BBA5-03DF76D2542A" }
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void InterconnectCreateConnection()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.CreateConnection(new CreateConnectionRequest 
            {
                AttachPoint = new AttachPoint { DirectConnectGateway = "90392BE3-219C-47FD-BBA5-03DF76D2542A" },
                Bandwidth = "1Gbps",
                EnvironmentId = "mce-aws-acme-1",
                RemoteAccount = new RemoteAccountIdentifier { Identifier = "PartnerAccountDetails" }
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void InterconnectDeleteConnection()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.DeleteConnection(new DeleteConnectionRequest 
            {
                Identifier = "mcc-abc12345"
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void InterconnectDescribeConnectionProposal()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.DescribeConnectionProposal(new DescribeConnectionProposalRequest 
            {
                ActivationKey = "<Activation Key Data>"
            });

            string bandwidth = response.Bandwidth;
            string environmentId = response.EnvironmentId;
            string location = response.Location;
            Provider provider = response.Provider;

            #endregion
        }

        public void InterconnectGetConnection()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.GetConnection(new GetConnectionRequest 
            {
                Identifier = "mcc-abc12345"
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void InterconnectGetEnvironment()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.GetEnvironment(new GetEnvironmentRequest 
            {
                Id = "mce-aws-acme-1"
            });

            Environment environment = response.Environment;

            #endregion
        }

        public void InterconnectListAttachPoints()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.ListAttachPoints(new ListAttachPointsRequest 
            {
                EnvironmentId = "mce-aws-acme-1"
            });

            List<AttachPointDescriptor> attachPoints = response.AttachPoints;

            #endregion
        }

        public void InterconnectListConnections()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.ListConnections(new ListConnectionsRequest 
            {
            });

            List<ConnectionSummary> connections = response.Connections;

            #endregion
        }

        public void InterconnectListConnections()
        {
            #region example-2

            var client = new AmazonInterconnectClient();
            var response = client.ListConnections(new ListConnectionsRequest 
            {
                State = "available"
            });

            List<ConnectionSummary> connections = response.Connections;

            #endregion
        }

        public void InterconnectListConnections()
        {
            #region example-3

            var client = new AmazonInterconnectClient();
            var response = client.ListConnections(new ListConnectionsRequest 
            {
                EnvironmentId = "mce-aws-acme-1"
            });

            List<ConnectionSummary> connections = response.Connections;

            #endregion
        }

        public void InterconnectListEnvironments()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.ListEnvironments(new ListEnvironmentsRequest 
            {
            });

            List<Environment> environments = response.Environments;

            #endregion
        }

        public void InterconnectListTagsForResource()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                Arn = "arn:aws:interconnect:us-east-1:000000000000:connection/mcc-abc12345"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void InterconnectTagResource()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                Arn = "arn:aws:interconnect:us-east-1:000000000000:connection/mcc-abc12345",
                Tags = new Dictionary<string, string> {
                    { "TagKey1", "TagValue1" },
                    { "TagKey2", "TagValue2" }
                }
            });


            #endregion
        }

        public void InterconnectUntagResource()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                Arn = "arn:aws:interconnect:us-east-1:000000000000:connection/mcc-abc12345",
                TagKeys = new List<string> {
                    "TagKey1",
                    "TagKey2"
                }
            });


            #endregion
        }

        public void InterconnectUpdateConnection()
        {
            #region example-1

            var client = new AmazonInterconnectClient();
            var response = client.UpdateConnection(new UpdateConnectionRequest 
            {
                Description = "Changed Description",
                Identifier = "mcc-abc12345"
            });

            Connection connection = response.Connection;

            #endregion
        }

        public void InterconnectUpdateConnection()
        {
            #region example-2

            var client = new AmazonInterconnectClient();
            var response = client.UpdateConnection(new UpdateConnectionRequest 
            {
                Bandwidth = "2Gbps",
                Identifier = "mcc-abc12345"
            });

            Connection connection = response.Connection;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}