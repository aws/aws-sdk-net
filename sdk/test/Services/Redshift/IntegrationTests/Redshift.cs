using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.Redshift;
using Amazon.Redshift.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Redshift : TestBase<AmazonRedshiftClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("Redshift")]
        public void CRUDSecurityGroups()
        {
            string name = "dotnetsdk" + DateTime.Now.Ticks;
            var createRequest = new CreateClusterSecurityGroupRequest() { ClusterSecurityGroupName = name, Description = "Description" };
            CreateClusterSecurityGroupResponse createResponse = null;
            try
            {
                createResponse = Client.CreateClusterSecurityGroup(createRequest);
                var descResponse = Client.DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name });
                Assert.AreEqual(1, descResponse.ClusterSecurityGroups.Count);
                Assert.AreEqual(name, descResponse.ClusterSecurityGroups[0].ClusterSecurityGroupName);

                var authRequest = new AuthorizeClusterSecurityGroupIngressRequest() { ClusterSecurityGroupName = name, CIDRIP = "0.0.0.0/0" };
                Client.AuthorizeClusterSecurityGroupIngress(authRequest);

                descResponse = Client.DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name });
                Assert.AreEqual(1, descResponse.ClusterSecurityGroups[0].IPRanges.Count);
                Assert.AreEqual("0.0.0.0/0", descResponse.ClusterSecurityGroups[0].IPRanges[0].CIDRIP);

                var revokeRequest = new RevokeClusterSecurityGroupIngressRequest() { ClusterSecurityGroupName = name, CIDRIP = "0.0.0.0/0" };
                Client.RevokeClusterSecurityGroupIngress(revokeRequest);

                descResponse = Client.DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest() { ClusterSecurityGroupName = name });
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
                    Client.DeleteClusterSecurityGroup(new DeleteClusterSecurityGroupRequest() { ClusterSecurityGroupName = name });
                    var descResponse = Client.DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
                    Assert.IsNull(descResponse.ClusterSecurityGroups.FirstOrDefault(x => x.ClusterSecurityGroupName == name));
                }
            }
        }

        [TestMethod]
        [TestCategory("Redshift")]
        public void CRUDParameterGroup()
        {
            string name = "dotnetsdk" + DateTime.Now.Ticks;
            var createRequest = new CreateClusterParameterGroupRequest() { ParameterGroupName = name, ParameterGroupFamily = "redshift-1.0", Description = "A Description" };
            CreateClusterParameterGroupResponse createResponse = Client.CreateClusterParameterGroup(createRequest);
            try
            {
                var descResponse = Client.DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest() { ParameterGroupName = name });
                Assert.AreEqual(1, descResponse.ParameterGroups.Count);
                Assert.AreEqual(name, descResponse.ParameterGroups[0].ParameterGroupName);

                ModifyClusterParameterGroupRequest modRequest = new ModifyClusterParameterGroupRequest() { ParameterGroupName = name };
                modRequest.Parameters.Add(new Parameter() { ParameterName = "require_ssl", ParameterValue = "true" });
                var modResponse = Client.ModifyClusterParameterGroup(modRequest);

                var descParameterResponse = Client.DescribeClusterParameters(new DescribeClusterParametersRequest() { ParameterGroupName = name });
                var parameter = descParameterResponse.Parameters.FirstOrDefault(x => x.ParameterName == "require_ssl");
                Assert.IsNotNull(parameter);
                Assert.AreEqual("true", parameter.ParameterValue);
            }
            finally
            {
                Client.DeleteClusterParameterGroup(new DeleteClusterParameterGroupRequest() { ParameterGroupName = name });
                var descResponse = Client.DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
                Assert.IsNull(descResponse.ParameterGroups.FirstOrDefault(x => x.ParameterGroupName == name));
            }
        }

        [TestMethod]
        [TestCategory("Redshift")]
        public void DescribeOptions()
        {
            var response = Client.DescribeOrderableClusterOptions();
            Assert.IsTrue(response.OrderableClusterOptions.Count > 0);
        }

        [TestMethod]
        [TestCategory("Redshift")]
        public void DescribeEventCategories()
        {
            var response = Client.DescribeEventCategories();
            Assert.IsTrue(response.EventCategoriesMapList.Count >= 0);
        }

        [TestMethod]
        [TestCategory("Redshift")]
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
                var createResp = Client.CreateHsmClientCertificate(createReq);

                Assert.IsNotNull(createResp.HsmClientCertificate);
                Assert.IsFalse(string.IsNullOrEmpty(createResp.HsmClientCertificate.HsmClientCertificatePublicKey));

                ourCert = createResp.HsmClientCertificate;

                string marker = null;
                bool found = false;
                do
                {
                    var certs = Client.DescribeHsmClientCertificates();
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
                    Client.DeleteHsmClientCertificate(new DeleteHsmClientCertificateRequest
                    {
                        HsmClientCertificateIdentifier = hsmCertificateId
                    });
            }
        }
    }
}
