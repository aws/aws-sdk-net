using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ELBProxy;
using Amazon.ELBProxy.Model;

namespace AWSSDKDocSamples.Amazon.ELBProxy.Generated
{
    class ELBProxySamples : ISample
    {
        public void ELBProxyAssociateCertificate()
        {
            #region AssociateCertificate-1

            var client = new AmazonELBProxyClient();
            var response = client.AssociateCertificate(new AssociateCertificateRequest
            {
                CertificateIdentifier = "arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012",
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            CertificateAssociation certificateAssociation = response.CertificateAssociation;

            #endregion
        }

        public void ELBProxyCreateProxy()
        {
            #region CreateProxy-1

            var client = new AmazonELBProxyClient();
            var response = client.CreateProxy(new CreateProxyRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "deletion_protection.enabled",
                        Value = "true"
                    }
                },
                Configuration = new ProxyConfiguration { ConfigurationFile = new ConfigurationFile { ConfigurationBytes = new MemoryStream(c3RhdGljX3Jlc291cmNlczoge30K) } },
                Name = "my-proxy",
                NetworkConfiguration = new ProxyNetworkUserConfiguration {
                    IpConfiguration = new ProxyIpConfiguration { IpAddressingConfiguration = new ProxyIpAddressingConfiguration {
                        Ipv4Addressability = "internet-facing",
                        Ipv6Addressability = "off"
                    } },
                    VpcConfiguration = new ProxyVpcUserConfiguration {
                        SecurityGroups = new List<SecurityGroupDetails> {
                            new SecurityGroupDetails { SecurityGroupId = "sg-903004f8" }
                        },
                        Subnets = new List<SubnetDetails> {
                            new SubnetDetails { SubnetId = "subnet-8360a9e7" },
                            new SubnetDetails { SubnetId = "subnet-b7d581c0" }
                        }
                    }
                },
                ProxyVersion = "1.40",
                RoleArn = "arn:aws:iam::123456789012:role/my-proxy-role",
                Tags = new Dictionary<string, string> {
                    { "Environment", "production" }
                },
                Type = "envoy"
            });

            string arn = response.Arn;
            ConfigurationMetadata configurationMetadata = response.ConfigurationMetadata;
            DateTime? createdAt = response.CreatedAt;
            string dnsName = response.DnsName;
            string name = response.Name;
            ProxyNetworkConfiguration networkConfiguration = response.NetworkConfiguration;
            string proxyVersion = response.ProxyVersion;
            string roleArn = response.RoleArn;
            ProxyStatus status = response.Status;
            ProxyType type = response.Type;

            #endregion
        }

        public void ELBProxyDeleteProxy()
        {
            #region DeleteProxy-1

            var client = new AmazonELBProxyClient();
            var response = client.DeleteProxy(new DeleteProxyRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            string arn = response.Arn;
            string name = response.Name;
            ProxyStatus status = response.Status;

            #endregion
        }

        public void ELBProxyDisassociateCertificate()
        {
            #region DisassociateCertificate-1

            var client = new AmazonELBProxyClient();
            var response = client.DisassociateCertificate(new DisassociateCertificateRequest
            {
                CertificateIdentifier = "arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012",
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            CertificateAssociation certificateAssociation = response.CertificateAssociation;

            #endregion
        }

        public void ELBProxyGetProxy()
        {
            #region GetProxy-1

            var client = new AmazonELBProxyClient();
            var response = client.GetProxy(new GetProxyRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            string arn = response.Arn;
            ConfigurationMetadata configurationMetadata = response.ConfigurationMetadata;
            DateTime? createdAt = response.CreatedAt;
            string dnsName = response.DnsName;
            string name = response.Name;
            ProxyNetworkConfiguration networkConfiguration = response.NetworkConfiguration;
            string proxyVersion = response.ProxyVersion;
            string roleArn = response.RoleArn;
            ProxyStatus status = response.Status;
            ProxyType type = response.Type;

            #endregion
        }

        public void ELBProxyGetProxyAttributes()
        {
            #region GetProxyAttributes-1

            var client = new AmazonELBProxyClient();
            var response = client.GetProxyAttributes(new GetProxyAttributesRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<AttributeDetails> attributes = response.Attributes;

            #endregion
        }

        public void ELBProxyGetProxyConfigurationContents()
        {
            #region GetProxyConfigurationContents-1

            var client = new AmazonELBProxyClient();
            var response = client.GetProxyConfigurationContents(new GetProxyConfigurationContentsRequest
            {
                IncludeConfigArchive = false,
                IncludeConfigFile = true,
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            MemoryStream configurationFileContents = response.ConfigurationFileContents;
            ConfigurationMetadata configurationMetadata = response.ConfigurationMetadata;

            #endregion
        }

        public void ELBProxyGetProxyUpdate()
        {
            #region GetProxyUpdate-1

            var client = new AmazonELBProxyClient();
            var response = client.GetProxyUpdate(new GetProxyUpdateRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef",
                UpdateIdentifier = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111"
            });

            DateTime? completedAt = response.CompletedAt;
            ProxyUpdateDetails details = response.Details;
            string proxyArn = response.ProxyArn;
            ProxyUpdateState state = response.State;
            DateTime? submittedAt = response.SubmittedAt;
            string updateId = response.UpdateId;
            DateTime? validatedAt = response.ValidatedAt;

            #endregion
        }

        public void ELBProxyListCertificateAssociations()
        {
            #region ListCertificateAssociations-1

            var client = new AmazonELBProxyClient();
            var response = client.ListCertificateAssociations(new ListCertificateAssociationsRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<CertificateAssociation> items = response.Items;

            #endregion
        }

        public void ELBProxyListProxies()
        {
            #region ListProxies-1

            var client = new AmazonELBProxyClient();
            var response = client.ListProxies(new ListProxiesRequest
            {
            });

            List<ProxySummary> items = response.Items;

            #endregion
        }

        public void ELBProxyListProxyUpdates()
        {
            #region ListProxyUpdates-1

            var client = new AmazonELBProxyClient();
            var response = client.ListProxyUpdates(new ListProxyUpdatesRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<ProxyUpdateSummary> items = response.Items;

            #endregion
        }

        public void ELBProxyListProxyVersions()
        {
            #region ListProxyVersions-1

            var client = new AmazonELBProxyClient();
            var response = client.ListProxyVersions(new ListProxyVersionsRequest
            {
                Type = "envoy"
            });

            List<ProxyVersionSummary> items = response.Items;

            #endregion
        }

        public void ELBProxyListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonELBProxyClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void ELBProxyTagResource()
        {
            #region TagResource-1

            var client = new AmazonELBProxyClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef",
                Tags = new Dictionary<string, string> {
                    { "Environment", "production" },
                    { "Team", "networking" }
                }
            });


            #endregion
        }

        public void ELBProxyUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonELBProxyClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef",
                TagKeys = new List<string> {
                    "Team"
                }
            });


            #endregion
        }

        public void ELBProxyUpdateProxyAttributes()
        {
            #region UpdateProxyAttributes-1

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyAttributes(new UpdateProxyAttributesRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "deletion_protection.enabled",
                        Value = "true"
                    }
                },
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<AttributeDetails> attributes = response.Attributes;

            #endregion
        }

        public void ELBProxyUpdateProxyAttributes()
        {
            #region UpdateProxyAttributes-2

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyAttributes(new UpdateProxyAttributesRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "envoy.log_level",
                        Value = "debug"
                    }
                },
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<AttributeDetails> attributes = response.Attributes;

            #endregion
        }

        public void ELBProxyUpdateProxyAttributes()
        {
            #region UpdateProxyAttributes-3

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyAttributes(new UpdateProxyAttributesRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "envoy.component_log_level",
                        Value = "http:debug,router:debug"
                    }
                },
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<AttributeDetails> attributes = response.Attributes;

            #endregion
        }

        public void ELBProxyUpdateProxyAttributes()
        {
            #region UpdateProxyAttributes-4

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyAttributes(new UpdateProxyAttributesRequest
            {
                Attributes = new List<Attribute> {
                    new Attribute {
                        Key = "waf.fail_open.enabled",
                        Value = "true"
                    }
                },
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            List<AttributeDetails> attributes = response.Attributes;

            #endregion
        }

        public void ELBProxyUpdateProxyConfiguration()
        {
            #region UpdateProxyConfiguration-1

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyConfiguration(new UpdateProxyConfigurationRequest
            {
                ConfigurationFile = new ConfigurationFile { ConfigurationBytes = new MemoryStream(c3RhdGljX3Jlc291cmNlczoKICBsaXN0ZW5lcnM6IFtdCg==) },
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef"
            });

            ConfigurationMetadata configurationMetadata = response.ConfigurationMetadata;
            string updateId = response.UpdateId;

            #endregion
        }

        public void ELBProxyUpdateProxyNetworkConfiguration()
        {
            #region UpdateProxyNetworkConfiguration-1

            var client = new AmazonELBProxyClient();
            var response = client.UpdateProxyNetworkConfiguration(new UpdateProxyNetworkConfigurationRequest
            {
                ProxyIdentifier = "arn:aws:elasticloadbalancing:us-east-1:123456789012:proxy/my-proxy:0123456789abcdef",
                VpcConfiguration = new UpdateProxyVpcConfiguration { SecurityGroups = new List<SecurityGroupDetails> {
                    new SecurityGroupDetails { SecurityGroupId = "sg-1a2b3c4d" }
                } }
            });

            string arn = response.Arn;
            DateTime? createdAt = response.CreatedAt;
            string dnsName = response.DnsName;
            string name = response.Name;
            ProxyNetworkConfiguration networkConfiguration = response.NetworkConfiguration;
            string proxyVersion = response.ProxyVersion;
            string roleArn = response.RoleArn;
            ProxyStatus status = response.Status;
            ProxyType type = response.Type;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
