using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.RTBFabric;
using Amazon.RTBFabric.Model;

namespace AWSSDKDocSamples.Amazon.RTBFabric.Generated
{
    class RTBFabricSamples : ISample
    {
        public void RTBFabricAcceptLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.AcceptLink(new AcceptLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321",
                LogSettings = new LinkLogSettings { ApplicationLogs = new LinkApplicationLogConfiguration { Sampling = new LinkApplicationLogSampling {
                    ErrorLog = 100,
                    FilterLog = 0
                } } }
            });

            DateTime createdAt = response.CreatedAt;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string peerGatewayId = response.PeerGatewayId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricCreateInboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.CreateInboundExternalLink(new CreateInboundExternalLinkRequest 
            {
                ClientToken = "randomClientToken",
                GatewayId = "rtb-gw-12345678",
                LogSettings = new LinkLogSettings { ApplicationLogs = new LinkApplicationLogConfiguration { Sampling = new LinkApplicationLogSampling {
                    ErrorLog = 100,
                    FilterLog = 0
                } } }
            });

            string domainName = response.DomainName;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricCreateLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.CreateLink(new CreateLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LogSettings = new LinkLogSettings { ApplicationLogs = new LinkApplicationLogConfiguration { Sampling = new LinkApplicationLogSampling {
                    ErrorLog = 100,
                    FilterLog = 0
                } } },
                PeerGatewayId = "rtb-gw-87654321"
            });

            DateTime createdAt = response.CreatedAt;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string peerGatewayId = response.PeerGatewayId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricCreateOutboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.CreateOutboundExternalLink(new CreateOutboundExternalLinkRequest 
            {
                ClientToken = "12345678-1234-1234-1234-123456789012",
                GatewayId = "rtb-gw-12345678",
                LogSettings = new LinkLogSettings { ApplicationLogs = new LinkApplicationLogConfiguration { Sampling = new LinkApplicationLogSampling {
                    ErrorLog = 100,
                    FilterLog = 0
                } } },
                PublicEndpoint = "https://external-responder.example.com"
            });

            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricCreateRequesterGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.CreateRequesterGateway(new CreateRequesterGatewayRequest 
            {
                ClientToken = "12345678-1234-1234-1234-123456789012",
                Description = "My requester gateway",
                SecurityGroupIds = new List<string> {
                    "sg-12345678"
                },
                SubnetIds = new List<string> {
                    "subnet-12345678",
                    "subnet-87654321"
                },
                VpcId = "vpc-12345678"
            });

            string domainName = response.DomainName;
            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricCreateResponderGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.CreateResponderGateway(new CreateResponderGatewayRequest 
            {
                ClientToken = "12345678-1234-1234-1234-123456789012",
                Description = "My responder gateway",
                Port = 443,
                Protocol = "HTTPS",
                SecurityGroupIds = new List<string> {
                    "sg-12345678"
                },
                SubnetIds = new List<string> {
                    "subnet-12345678",
                    "subnet-87654321"
                },
                VpcId = "vpc-12345678"
            });

            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricDeleteInboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.DeleteInboundExternalLink(new DeleteInboundExternalLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricDeleteLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.DeleteLink(new DeleteLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricDeleteOutboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.DeleteOutboundExternalLink(new DeleteOutboundExternalLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricDeleteRequesterGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.DeleteRequesterGateway(new DeleteRequesterGatewayRequest 
            {
                GatewayId = "rtb-gw-12345678"
            });

            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricDeleteResponderGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.DeleteResponderGateway(new DeleteResponderGatewayRequest 
            {
                GatewayId = "rtb-gw-12345678"
            });

            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricGetInboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.GetInboundExternalLink(new GetInboundExternalLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            DateTime createdAt = response.CreatedAt;
            string domainName = response.DomainName;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricGetLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.GetLink(new GetLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            DateTime createdAt = response.CreatedAt;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string peerGatewayId = response.PeerGatewayId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricGetOutboundExternalLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.GetOutboundExternalLink(new GetOutboundExternalLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            DateTime createdAt = response.CreatedAt;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string publicEndpoint = response.PublicEndpoint;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricGetRequesterGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.GetRequesterGateway(new GetRequesterGatewayRequest 
            {
                GatewayId = "rtb-gw-12345678"
            });

            int activeLinksCount = response.ActiveLinksCount;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string domainName = response.DomainName;
            string gatewayId = response.GatewayId;
            List<string> securityGroupIds = response.SecurityGroupIds;
            string status = response.Status;
            List<string> subnetIds = response.SubnetIds;
            int totalLinksCount = response.TotalLinksCount;
            DateTime updatedAt = response.UpdatedAt;
            string vpcId = response.VpcId;

            #endregion
        }

        public void RTBFabricGetResponderGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.GetResponderGateway(new GetResponderGatewayRequest 
            {
                GatewayId = "rtb-gw-12345678"
            });

            int activeLinksCount = response.ActiveLinksCount;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string gatewayId = response.GatewayId;
            int inboundLinksCount = response.InboundLinksCount;
            int port = response.Port;
            string protocol = response.Protocol;
            List<string> securityGroupIds = response.SecurityGroupIds;
            string status = response.Status;
            List<string> subnetIds = response.SubnetIds;
            int totalLinksCount = response.TotalLinksCount;
            DateTime updatedAt = response.UpdatedAt;
            string vpcId = response.VpcId;

            #endregion
        }

        public void RTBFabricListLinks()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.ListLinks(new ListLinksRequest 
            {
                GatewayId = "rtb-gw-12345678",
                MaxResults = 10
            });

            List<ListLinksResponseStructure> links = response.Links;

            #endregion
        }

        public void RTBFabricListRequesterGateways()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.ListRequesterGateways(new ListRequesterGatewaysRequest 
            {
                MaxResults = 10
            });

            List<string> gatewayIds = response.GatewayIds;

            #endregion
        }

        public void RTBFabricListRequesterGateways()
        {
            #region example-2

            var client = new AmazonRTBFabricClient();
            var response = client.ListRequesterGateways(new ListRequesterGatewaysRequest 
            {
                MaxResults = 5,
                NextToken = "eyJsYXN0RXZhbHVhdGVkS2V5Ijp7ImlkIjp7IlMiOiJydGJhcHAtcmVxLTEyMzQ1In19fQ=="
            });

            List<string> gatewayIds = response.GatewayIds;
            string nextToken = response.NextToken;

            #endregion
        }

        public void RTBFabricListResponderGateways()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.ListResponderGateways(new ListResponderGatewaysRequest 
            {
                MaxResults = 10
            });

            List<string> gatewayIds = response.GatewayIds;

            #endregion
        }

        public void RTBFabricListResponderGateways()
        {
            #region example-2

            var client = new AmazonRTBFabricClient();
            var response = client.ListResponderGateways(new ListResponderGatewaysRequest 
            {
                MaxResults = 3,
                NextToken = "eyJsYXN0RXZhbHVhdGVkS2V5Ijp7ImlkIjp7IlMiOiJydGJhcHAtcmVzcC01NDMyMSJ9fX0="
            });

            List<string> gatewayIds = response.GatewayIds;
            string nextToken = response.NextToken;

            #endregion
        }

        public void RTBFabricListTagsForResource()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:rtbfabric:us-east-1:123456789012:gateway/rtb-gw-12345678"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void RTBFabricRejectLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.RejectLink(new RejectLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321"
            });

            DateTime createdAt = response.CreatedAt;
            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string peerGatewayId = response.PeerGatewayId;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void RTBFabricTagResource()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:rtbfabric:us-east-1:123456789012:gateway/rtb-gw-12345678",
                Tags = new Dictionary<string, string> {
                    { "Environment", "Production" },
                    { "Team", "RTB" }
                }
            });


            #endregion
        }

        public void RTBFabricUntagResource()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:rtbfabric:us-east-1:123456789012:gateway/rtb-gw-12345678",
                TagKeys = new List<string> {
                    "Environment",
                    "Team"
                }
            });


            #endregion
        }

        public void RTBFabricUpdateLink()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.UpdateLink(new UpdateLinkRequest 
            {
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321",
                LogSettings = new LinkLogSettings { ApplicationLogs = new LinkApplicationLogConfiguration { Sampling = new LinkApplicationLogSampling {
                    ErrorLog = 100,
                    FilterLog = 10
                } } }
            });

            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricUpdateLinkModuleFlow()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.UpdateLinkModuleFlow(new UpdateLinkModuleFlowRequest 
            {
                ClientToken = "randomClientToken",
                GatewayId = "rtb-gw-12345678",
                LinkId = "link-87654321",
                Modules = new List<ModuleConfiguration> {
                    new ModuleConfiguration {
                        Version = "1dot0dot0",
                        Name = "noBidModule",
                        DependsOn = new List<string> {
                            
                        },
                        ModuleParameters = new ModuleParameters { NoBid = new NoBidModuleParameters {
                            PassThroughPercentage = 50,
                            Reason = "test",
                            ReasonCode = 1
                        } }
                    }
                }
            });

            string gatewayId = response.GatewayId;
            string linkId = response.LinkId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricUpdateRequesterGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.UpdateRequesterGateway(new UpdateRequesterGatewayRequest 
            {
                ClientToken = "12345678-1234-1234-1234-123456789012",
                Description = "Updated requester gateway description",
                GatewayId = "rtb-gw-12345678"
            });

            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        public void RTBFabricUpdateResponderGateway()
        {
            #region example-1

            var client = new AmazonRTBFabricClient();
            var response = client.UpdateResponderGateway(new UpdateResponderGatewayRequest 
            {
                ClientToken = "12345678-1234-1234-1234-123456789012",
                Description = "Updated responder gateway description",
                GatewayId = "rtb-gw-12345678",
                Port = 8080,
                Protocol = "HTTP"
            });

            string gatewayId = response.GatewayId;
            string status = response.Status;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}