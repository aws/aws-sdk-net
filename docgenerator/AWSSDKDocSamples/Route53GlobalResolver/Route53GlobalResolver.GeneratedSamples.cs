using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Route53GlobalResolver;
using Amazon.Route53GlobalResolver.Model;

namespace AWSSDKDocSamples.Amazon.Route53GlobalResolver.Generated
{
    class Route53GlobalResolverSamples : ISample
    {
        public void Route53GlobalResolverCreateAccessSource()
        {
            #region CreateAccessSource-1

            var client = new AmazonRoute53GlobalResolverClient();
            var response = client.CreateAccessSource(new CreateAccessSourceRequest
            {
                Cidr = "85.90.183.3/30",
                ClientToken = "9fas9-9usdfa-xbi8-kco",
                DnsViewId = "dnsv-123456789",
                IpAddressType = "IPV4",
                Name = "My Access Source",
                Protocol = "DO53",
                Tags = new Dictionary<string, string> {
                    { "Key1", "Value1" }
                }
            });

            string arn = response.Arn;
            string cidr = response.Cidr;
            DateTime? createdAt = response.CreatedAt;
            string dnsViewId = response.DnsViewId;
            string id = response.Id;
            IpAddressType ipAddressType = response.IpAddressType;
            string name = response.Name;
            DnsProtocol protocol = response.Protocol;
            CRResourceStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
