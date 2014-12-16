using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Glacier;
using Amazon.Glacier.Model;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime.Internal;

namespace AWSSDK_DotNet35.UnitTests.Resources
{
    [TestClass]
    public class PaginatorsTest
    {
        [TestMethod]
        public void TestIAMPaginators()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(iam => iam.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == null)))
                .Returns(new GetGroupResponse
                {
                    IsTruncated = true,
                    Marker = "A",
                    Users = new List<User> 
                    {
                        new User { UserName = "item1.0"},
                        new User { UserName = "item1.1"}
                    }
                });

            mock.Setup(iam => iam.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == "A")))
                .Returns(new GetGroupResponse
                {
                    IsTruncated = true,
                    Marker = "AA",
                    Users = new List<User> 
                    {
                        new User { UserName = "item2.0"},
                        new User { UserName = "item2.1"}
                    }
                });

            mock.Setup(iam => iam.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == "AA")))
                .Returns(new GetGroupResponse
                {
                    IsTruncated = false,
                    Users = new List<User> 
                    {
                        new User { UserName = "item3.0"}
                    }
                });

            var items = Paginator.Paginate<User, GetGroupRequest, GetGroupResponse>(new GetGroupRequest(), mock.Object.GetGroup);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(iam => iam.GetGroup(It.IsAny<GetGroupRequest>()), Times.Exactly(i));
                    Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.UserName);
                }
            }

            mock.Verify(iam => iam.GetGroup(It.IsAny<GetGroupRequest>()), Times.Exactly(3));
        }

        [TestMethod]
        public void TestGlacierPaginators()
        {
            var mock = new Mock<IAmazonGlacier>();

            mock.Setup(glacier => glacier.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == null)))
                .Returns(new ListVaultsResponse
                {
                    Marker = "A",
                    VaultList = new List<DescribeVaultOutput>
                    {
                        new DescribeVaultOutput { VaultName = "item1.0"},
                        new DescribeVaultOutput { VaultName = "item1.1"}
                    }
                });

            mock.Setup(glacier => glacier.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == "A")))
                .Returns(new ListVaultsResponse
                {
                    Marker = "AA",
                    VaultList = new List<DescribeVaultOutput>
                    {
                        new DescribeVaultOutput { VaultName = "item2.0"},
                        new DescribeVaultOutput { VaultName = "item2.1"}
                    }
                });

            mock.Setup(glacier => glacier.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == "AA")))
                .Returns(new ListVaultsResponse
                {
                    VaultList = new List<DescribeVaultOutput>
                    {
                        new DescribeVaultOutput { VaultName = "item3.0"}
                    }
                });

            var items = Paginator.Paginate<DescribeVaultOutput, ListVaultsRequest, ListVaultsResponse>(new ListVaultsRequest(), mock.Object.ListVaults);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(glacier => glacier.ListVaults(It.IsAny<ListVaultsRequest>()), Times.Exactly(i));
                    Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.VaultName);
                }
            }

            mock.Verify(glacier => glacier.ListVaults(It.IsAny<ListVaultsRequest>()), Times.Exactly(3));

        }

        [TestMethod]
        public void TestCloudFormationPaginators()
        {
            var mock = new Mock<IAmazonCloudFormation>();

            mock.Setup(cf => cf.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == null)))
                .Returns(new ListStackResourcesResponse
                {
                    NextToken = "A",
                    StackResourceSummaries = new List<StackResourceSummary>
                    {
                        new StackResourceSummary { LogicalResourceId = "item1.0"},
                        new StackResourceSummary { LogicalResourceId = "item1.1"}
                    }
                });

            mock.Setup(cf => cf.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == "A")))
                .Returns(new ListStackResourcesResponse
                {
                    NextToken = "AA",
                    StackResourceSummaries = new List<StackResourceSummary>
                    {
                        new StackResourceSummary { LogicalResourceId = "item2.0"},
                        new StackResourceSummary { LogicalResourceId = "item2.1"}
                    }
                });

            mock.Setup(cf => cf.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == "AA")))
                .Returns(new ListStackResourcesResponse
                {
                    StackResourceSummaries = new List<StackResourceSummary>
                    {
                        new StackResourceSummary { LogicalResourceId = "item3.0"}
                    }
                });

            var items = Paginator.Paginate<StackResourceSummary, ListStackResourcesRequest, ListStackResourcesResponse>(new ListStackResourcesRequest(), mock.Object.ListStackResources);
            
            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(cf => cf.ListStackResources(It.IsAny<ListStackResourcesRequest>()), Times.Exactly(i));
                    Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.LogicalResourceId);
                }
            }

            mock.Verify(cf => cf.ListStackResources(It.IsAny<ListStackResourcesRequest>()), Times.Exactly(3));
        }

        [TestMethod]
        public void TestSNSPaginators()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(sns => sns.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == null)))
                .Returns(new ListTopicsResponse
                {
                    NextToken = "A",
                    Topics = new List<Topic>
                    {
                        new Topic { TopicArn = "item1.0"},
                        new Topic { TopicArn = "item1.1"}
                    }
                });

            mock.Setup(sns => sns.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == "A")))
                .Returns(new ListTopicsResponse
                {
                    NextToken = "AA",
                    Topics = new List<Topic>
                    {
                        new Topic { TopicArn = "item2.0"},
                        new Topic { TopicArn = "item2.1"}
                    }
                });

            mock.Setup(sns => sns.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == "AA")))
                .Returns(new ListTopicsResponse
                {
                    Topics = new List<Topic>
                    {
                        new Topic { TopicArn = "item3.0"}
                    }
                });

            var items = Paginator.Paginate<Topic, ListTopicsRequest, ListTopicsResponse>(new ListTopicsRequest(), mock.Object.ListTopics);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(cf => cf.ListTopics(It.IsAny<ListTopicsRequest>()), Times.Exactly(i));
                    Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.TopicArn);
                }
            }

            mock.Verify(cf => cf.ListTopics(It.IsAny<ListTopicsRequest>()), Times.Exactly(3));
        }
    }
}
