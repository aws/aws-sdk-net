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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon.Runtime.Internal;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Paginators
{
    [TestClass]
    public class SimpleNotificationServicePaginatorTests
    {

        #region ListEndpointsByPlatformApplicationEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("SimpleNotificationService")]
        public void TestListEndpointsByPlatformApplicationEnumerator()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(client => client.ListEndpointsByPlatformApplication(It.Is<ListEndpointsByPlatformApplicationRequest>(r => r.NextToken == null)))
                .Returns(new ListEndpointsByPlatformApplicationResponse
                {
                    NextToken = "A",
                    Endpoints = new List<Endpoint> 
                    {
                        new Endpoint { EndpointArn = "item1.0" },
                        new Endpoint { EndpointArn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListEndpointsByPlatformApplication(It.Is<ListEndpointsByPlatformApplicationRequest>(r => r.NextToken == "A")))
                .Returns(new ListEndpointsByPlatformApplicationResponse
                {
                    NextToken = "AA",
                    Endpoints = new List<Endpoint> 
                    {
                        new Endpoint { EndpointArn = "item2.0" },
                        new Endpoint { EndpointArn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListEndpointsByPlatformApplication(It.Is<ListEndpointsByPlatformApplicationRequest>(r => r.NextToken == "AA")))
                .Returns(new ListEndpointsByPlatformApplicationResponse
                {
                    Endpoints = new List<Endpoint> 
                    {
                        new Endpoint { EndpointArn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Endpoint, ListEndpointsByPlatformApplicationRequest, ListEndpointsByPlatformApplicationResponse>(new ListEndpointsByPlatformApplicationRequest(), mock.Object.ListEndpointsByPlatformApplication);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListEndpointsByPlatformApplication(It.IsAny<ListEndpointsByPlatformApplicationRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.EndpointArn);
                }
            }

            mock.Verify(client => client.ListEndpointsByPlatformApplication(It.IsAny<ListEndpointsByPlatformApplicationRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListPlatformApplicationsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("SimpleNotificationService")]
        public void TestListPlatformApplicationsEnumerator()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(client => client.ListPlatformApplications(It.Is<ListPlatformApplicationsRequest>(r => r.NextToken == null)))
                .Returns(new ListPlatformApplicationsResponse
                {
                    NextToken = "A",
                    PlatformApplications = new List<PlatformApplication> 
                    {
                        new PlatformApplication { PlatformApplicationArn = "item1.0" },
                        new PlatformApplication { PlatformApplicationArn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListPlatformApplications(It.Is<ListPlatformApplicationsRequest>(r => r.NextToken == "A")))
                .Returns(new ListPlatformApplicationsResponse
                {
                    NextToken = "AA",
                    PlatformApplications = new List<PlatformApplication> 
                    {
                        new PlatformApplication { PlatformApplicationArn = "item2.0" },
                        new PlatformApplication { PlatformApplicationArn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListPlatformApplications(It.Is<ListPlatformApplicationsRequest>(r => r.NextToken == "AA")))
                .Returns(new ListPlatformApplicationsResponse
                {
                    PlatformApplications = new List<PlatformApplication> 
                    {
                        new PlatformApplication { PlatformApplicationArn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<PlatformApplication, ListPlatformApplicationsRequest, ListPlatformApplicationsResponse>(new ListPlatformApplicationsRequest(), mock.Object.ListPlatformApplications);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListPlatformApplications(It.IsAny<ListPlatformApplicationsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.PlatformApplicationArn);
                }
            }

            mock.Verify(client => client.ListPlatformApplications(It.IsAny<ListPlatformApplicationsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListSubscriptionsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("SimpleNotificationService")]
        public void TestListSubscriptionsEnumerator()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(client => client.ListSubscriptions(It.Is<ListSubscriptionsRequest>(r => r.NextToken == null)))
                .Returns(new ListSubscriptionsResponse
                {
                    NextToken = "A",
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item1.0" },
                        new Subscription { Endpoint = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListSubscriptions(It.Is<ListSubscriptionsRequest>(r => r.NextToken == "A")))
                .Returns(new ListSubscriptionsResponse
                {
                    NextToken = "AA",
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item2.0" },
                        new Subscription { Endpoint = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListSubscriptions(It.Is<ListSubscriptionsRequest>(r => r.NextToken == "AA")))
                .Returns(new ListSubscriptionsResponse
                {
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Subscription, ListSubscriptionsRequest, ListSubscriptionsResponse>(new ListSubscriptionsRequest(), mock.Object.ListSubscriptions);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListSubscriptions(It.IsAny<ListSubscriptionsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Endpoint);
                }
            }

            mock.Verify(client => client.ListSubscriptions(It.IsAny<ListSubscriptionsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListSubscriptionsByTopicEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("SimpleNotificationService")]
        public void TestListSubscriptionsByTopicEnumerator()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(client => client.ListSubscriptionsByTopic(It.Is<ListSubscriptionsByTopicRequest>(r => r.NextToken == null)))
                .Returns(new ListSubscriptionsByTopicResponse
                {
                    NextToken = "A",
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item1.0" },
                        new Subscription { Endpoint = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListSubscriptionsByTopic(It.Is<ListSubscriptionsByTopicRequest>(r => r.NextToken == "A")))
                .Returns(new ListSubscriptionsByTopicResponse
                {
                    NextToken = "AA",
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item2.0" },
                        new Subscription { Endpoint = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListSubscriptionsByTopic(It.Is<ListSubscriptionsByTopicRequest>(r => r.NextToken == "AA")))
                .Returns(new ListSubscriptionsByTopicResponse
                {
                    Subscriptions = new List<Subscription> 
                    {
                        new Subscription { Endpoint = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Subscription, ListSubscriptionsByTopicRequest, ListSubscriptionsByTopicResponse>(new ListSubscriptionsByTopicRequest(), mock.Object.ListSubscriptionsByTopic);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListSubscriptionsByTopic(It.IsAny<ListSubscriptionsByTopicRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Endpoint);
                }
            }

            mock.Verify(client => client.ListSubscriptionsByTopic(It.IsAny<ListSubscriptionsByTopicRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListTopicsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("SimpleNotificationService")]
        public void TestListTopicsEnumerator()
        {
            var mock = new Mock<IAmazonSimpleNotificationService>();

            mock.Setup(client => client.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == null)))
                .Returns(new ListTopicsResponse
                {
                    NextToken = "A",
                    Topics = new List<Topic> 
                    {
                        new Topic { TopicArn = "item1.0" },
                        new Topic { TopicArn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == "A")))
                .Returns(new ListTopicsResponse
                {
                    NextToken = "AA",
                    Topics = new List<Topic> 
                    {
                        new Topic { TopicArn = "item2.0" },
                        new Topic { TopicArn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListTopics(It.Is<ListTopicsRequest>(r => r.NextToken == "AA")))
                .Returns(new ListTopicsResponse
                {
                    Topics = new List<Topic> 
                    {
                        new Topic { TopicArn = "item3.0" },
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
                    mock.Verify(client => client.ListTopics(It.IsAny<ListTopicsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.TopicArn);
                }
            }

            mock.Verify(client => client.ListTopics(It.IsAny<ListTopicsRequest>()), Times.Exactly(3));

        }

        #endregion

 
      
    }
}