/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon.Runtime.Internal;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Paginators
{
    [TestClass]
    public class CloudFormationPaginatorTests
    {

        #region DescribeStackEventsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("CloudFormation")]
        public void TestDescribeStackEventsEnumerator()
        {
            var mock = new Mock<IAmazonCloudFormation>();

            mock.Setup(client => client.DescribeStackEvents(It.Is<DescribeStackEventsRequest>(r => r.NextToken == null)))
                .Returns(new DescribeStackEventsResponse
                {
                    NextToken = "A",
                    StackEvents = new List<StackEvent> 
                    {
                        new StackEvent { EventId = "item1.0" },
                        new StackEvent { EventId = "item1.1" }
                    }
                });

            mock.Setup(client => client.DescribeStackEvents(It.Is<DescribeStackEventsRequest>(r => r.NextToken == "A")))
                .Returns(new DescribeStackEventsResponse
                {
                    NextToken = "AA",
                    StackEvents = new List<StackEvent> 
                    {
                        new StackEvent { EventId = "item2.0" },
                        new StackEvent { EventId = "item2.1" }
                    }
                });

            mock.Setup(client => client.DescribeStackEvents(It.Is<DescribeStackEventsRequest>(r => r.NextToken == "AA")))
                .Returns(new DescribeStackEventsResponse
                {
                    StackEvents = new List<StackEvent> 
                    {
                        new StackEvent { EventId = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<StackEvent, DescribeStackEventsRequest, DescribeStackEventsResponse>(new DescribeStackEventsRequest(), mock.Object.DescribeStackEvents);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.DescribeStackEvents(It.IsAny<DescribeStackEventsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.EventId);
                }
            }

            mock.Verify(client => client.DescribeStackEvents(It.IsAny<DescribeStackEventsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region DescribeStacksEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("CloudFormation")]
        public void TestDescribeStacksEnumerator()
        {
            var mock = new Mock<IAmazonCloudFormation>();

            mock.Setup(client => client.DescribeStacks(It.Is<DescribeStacksRequest>(r => r.NextToken == null)))
                .Returns(new DescribeStacksResponse
                {
                    NextToken = "A",
                    Stacks = new List<Stack> 
                    {
                        new Stack { Description = "item1.0" },
                        new Stack { Description = "item1.1" }
                    }
                });

            mock.Setup(client => client.DescribeStacks(It.Is<DescribeStacksRequest>(r => r.NextToken == "A")))
                .Returns(new DescribeStacksResponse
                {
                    NextToken = "AA",
                    Stacks = new List<Stack> 
                    {
                        new Stack { Description = "item2.0" },
                        new Stack { Description = "item2.1" }
                    }
                });

            mock.Setup(client => client.DescribeStacks(It.Is<DescribeStacksRequest>(r => r.NextToken == "AA")))
                .Returns(new DescribeStacksResponse
                {
                    Stacks = new List<Stack> 
                    {
                        new Stack { Description = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Stack, DescribeStacksRequest, DescribeStacksResponse>(new DescribeStacksRequest(), mock.Object.DescribeStacks);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.DescribeStacks(It.IsAny<DescribeStacksRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Description);
                }
            }

            mock.Verify(client => client.DescribeStacks(It.IsAny<DescribeStacksRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListStackResourcesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("CloudFormation")]
        public void TestListStackResourcesEnumerator()
        {
            var mock = new Mock<IAmazonCloudFormation>();

            mock.Setup(client => client.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == null)))
                .Returns(new ListStackResourcesResponse
                {
                    NextToken = "A",
                    StackResourceSummaries = new List<StackResourceSummary> 
                    {
                        new StackResourceSummary { LogicalResourceId = "item1.0" },
                        new StackResourceSummary { LogicalResourceId = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == "A")))
                .Returns(new ListStackResourcesResponse
                {
                    NextToken = "AA",
                    StackResourceSummaries = new List<StackResourceSummary> 
                    {
                        new StackResourceSummary { LogicalResourceId = "item2.0" },
                        new StackResourceSummary { LogicalResourceId = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListStackResources(It.Is<ListStackResourcesRequest>(r => r.NextToken == "AA")))
                .Returns(new ListStackResourcesResponse
                {
                    StackResourceSummaries = new List<StackResourceSummary> 
                    {
                        new StackResourceSummary { LogicalResourceId = "item3.0" },
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
                    mock.Verify(client => client.ListStackResources(It.IsAny<ListStackResourcesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.LogicalResourceId);
                }
            }

            mock.Verify(client => client.ListStackResources(It.IsAny<ListStackResourcesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListStacksEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("CloudFormation")]
        public void TestListStacksEnumerator()
        {
            var mock = new Mock<IAmazonCloudFormation>();

            mock.Setup(client => client.ListStacks(It.Is<ListStacksRequest>(r => r.NextToken == null)))
                .Returns(new ListStacksResponse
                {
                    NextToken = "A",
                    StackSummaries = new List<StackSummary> 
                    {
                        new StackSummary { StackId = "item1.0" },
                        new StackSummary { StackId = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListStacks(It.Is<ListStacksRequest>(r => r.NextToken == "A")))
                .Returns(new ListStacksResponse
                {
                    NextToken = "AA",
                    StackSummaries = new List<StackSummary> 
                    {
                        new StackSummary { StackId = "item2.0" },
                        new StackSummary { StackId = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListStacks(It.Is<ListStacksRequest>(r => r.NextToken == "AA")))
                .Returns(new ListStacksResponse
                {
                    StackSummaries = new List<StackSummary> 
                    {
                        new StackSummary { StackId = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<StackSummary, ListStacksRequest, ListStacksResponse>(new ListStacksRequest(), mock.Object.ListStacks);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListStacks(It.IsAny<ListStacksRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.StackId);
                }
            }

            mock.Verify(client => client.ListStacks(It.IsAny<ListStacksRequest>()), Times.Exactly(3));

        }

        #endregion

 
      
    }
}