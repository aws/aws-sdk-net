using System;
using System.Collections.Generic;

using System.Linq;


using Amazon.Redshift;
using Amazon.Redshift.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class Redshift : TestBase<AmazonRedshiftClient>
    {

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("Redshift")]
        public void CRUDSecurityGroups()
        {
            string name = "dotnetsdk" + DateTime.Now.Ticks;
            var createRequest = new CreateClusterSecurityGroupRequest() { ClusterSecurityGroupName = name, Description = "Description" };
            CreateClusterSecurityGroupResponse createResponse = null;
            try
            {
                createResponse = Client.CreateClusterSecurityGroupAsync(createRequest).Result;
                var descResponse = Client.DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name }).Result;
                Assert.AreEqual(1, descResponse.ClusterSecurityGroups.Count);
                Assert.AreEqual(name, descResponse.ClusterSecurityGroups[0].ClusterSecurityGroupName);

                var authRequest = new AuthorizeClusterSecurityGroupIngressRequest() { ClusterSecurityGroupName = name, CIDRIP = "0.0.0.0/0" };
                Client.AuthorizeClusterSecurityGroupIngressAsync(authRequest).Wait();

                descResponse = Client.DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name }).Result;
                Assert.AreEqual(1, descResponse.ClusterSecurityGroups[0].IPRanges.Count);
                Assert.AreEqual("0.0.0.0/0", descResponse.ClusterSecurityGroups[0].IPRanges[0].CIDRIP);

                var revokeRequest = new RevokeClusterSecurityGroupIngressRequest() { ClusterSecurityGroupName = name, CIDRIP = "0.0.0.0/0" };
                Client.RevokeClusterSecurityGroupIngressAsync(revokeRequest).Wait();

                descResponse = Client.DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name }).Result;
                Assert.AreEqual(0, descResponse.ClusterSecurityGroups[0].IPRanges.Count);
            }
            catch (AmazonRedshiftException e)
            {
                // This test does not work for VPC by default accounts so skip the test.
                if (!string.Equals(e.Message, "VPC-by-Default customers cannot use cluster security groups"))
                    throw;
            }
            finally
            {
                if (createResponse != null)
                {
                    Client.DeleteClusterSecurityGroupAsync(new DeleteClusterSecurityGroupRequest() { ClusterSecurityGroupName = name }).Wait();
                    var descResponse = Client.DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest()).Result;
                    Assert.IsNull(descResponse.ClusterSecurityGroups.FirstOrDefault(x => x.ClusterSecurityGroupName == name));
                }
            }
        }

        [Test]
        [Category("Redshift")]
        public void CRUDParameterGroup()
        {
            string name = "dotnetsdk" + DateTime.Now.Ticks;
            var createRequest = new CreateClusterParameterGroupRequest() { ParameterGroupName = name, ParameterGroupFamily = "redshift-1.0", Description = "A Description" };
            CreateClusterParameterGroupResponse createResponse = Client.CreateClusterParameterGroupAsync(createRequest).Result;
            try
            {
                var descResponse = Client.DescribeClusterParameterGroupsAsync(new DescribeClusterParameterGroupsRequest() { ParameterGroupName = name }).Result;
                Assert.AreEqual(1, descResponse.ParameterGroups.Count);
                Assert.AreEqual(name, descResponse.ParameterGroups[0].ParameterGroupName);

                ModifyClusterParameterGroupRequest modRequest = new ModifyClusterParameterGroupRequest() { ParameterGroupName = name };
                modRequest.Parameters.Add(new Parameter() { ParameterName = "require_ssl", ParameterValue = "true" });
                var modResponse = Client.ModifyClusterParameterGroupAsync(modRequest).Result;

                var descParameterResponse = Client.DescribeClusterParametersAsync(new DescribeClusterParametersRequest() { ParameterGroupName = name }).Result;
                var parameter = descParameterResponse.Parameters.FirstOrDefault(x => x.ParameterName == "require_ssl");
                Assert.IsNotNull(parameter);
                Assert.AreEqual("true", parameter.ParameterValue);
            }
            finally
            {
                Client.DeleteClusterParameterGroupAsync(new DeleteClusterParameterGroupRequest() { ParameterGroupName = name }).Wait();
                var descResponse = Client.DescribeClusterParameterGroupsAsync(new DescribeClusterParameterGroupsRequest()).Result;
                Assert.IsNull(descResponse.ParameterGroups.FirstOrDefault(x => x.ParameterGroupName == name));
            }
        }

        [Test]
        [Category("Redshift")]
        public void DescribeOptions()
        {
            var response = Client.DescribeOrderableClusterOptionsAsync().Result;
            Assert.IsTrue(response.OrderableClusterOptions.Count > 0);
        }

        [Test]
        [Category("Redshift")]
        public void DescribeEventCategories()
        {
            var response = Client.DescribeEventCategoriesAsync().Result;
            Assert.IsTrue(response.EventCategoriesMapList.Count >= 0);
        }

        [Test]
        [Category("Redshift")]
        public void CRUDHsmClientCertificate()
        {
            var hsmCertificateId = "dotnetsdk" + DateTime.UtcNow.ToString("yyyyMMddTHHmmssZ");
            HsmClientCertificate ourCert = null;

            try
            {
                var createReq = new CreateHsmClientCertificateRequest
                {
                    HsmClientCertificateIdentifier = hsmCertificateId
                };
                var createResp = Client.CreateHsmClientCertificateAsync(createReq).Result;

                Assert.IsNotNull(createResp.HsmClientCertificate);
                Assert.IsFalse(string.IsNullOrEmpty(createResp.HsmClientCertificate.HsmClientCertificatePublicKey));

                ourCert = createResp.HsmClientCertificate;

                string marker = null;
                bool found = false;
                do
                {
                    var certs = Client.DescribeHsmClientCertificatesAsync().Result;
                    foreach (var cert in certs.HsmClientCertificates
                        .Where(cert => cert.HsmClientCertificateIdentifier.Equals(hsmCertificateId, StringComparison.OrdinalIgnoreCase)))
                    {
                        found = true;
                        break;
                    }
                    marker = certs.Marker;

                } while (!found && !string.IsNullOrEmpty(marker));

                Assert.IsTrue(found);
            }
            finally
            {
                if (ourCert != null)
                    Client.DeleteHsmClientCertificateAsync(new DeleteHsmClientCertificateRequest
                    {
                        HsmClientCertificateIdentifier = hsmCertificateId
                    }).Wait();
            }
        }
    }
}
