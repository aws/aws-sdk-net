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

using Amazon.Runtime.Internal;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    public partial class AmazonSimpleNotificationServiceClient
    {

        #region ListEndpointsByPlatformApplicationEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Endpoint&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Endpoint> ListEndpointsByPlatformApplicationEnumerator(ListEndpointsByPlatformApplicationRequest request)
        {
            return Paginator.Paginate<Endpoint, ListEndpointsByPlatformApplicationRequest, ListEndpointsByPlatformApplicationResponse>(request, this.ListEndpointsByPlatformApplication);
        }
      
        #endregion

        #region ListPlatformApplicationsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;PlatformApplication&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<PlatformApplication> ListPlatformApplicationsEnumerator(ListPlatformApplicationsRequest request)
        {
            return Paginator.Paginate<PlatformApplication, ListPlatformApplicationsRequest, ListPlatformApplicationsResponse>(request, this.ListPlatformApplications);
        }
      
        #endregion

        #region ListSubscriptionsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Subscription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Subscription> ListSubscriptionsEnumerator(ListSubscriptionsRequest request)
        {
            return Paginator.Paginate<Subscription, ListSubscriptionsRequest, ListSubscriptionsResponse>(request, this.ListSubscriptions);
        }
      
        #endregion

        #region ListSubscriptionsByTopicEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Subscription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Subscription> ListSubscriptionsByTopicEnumerator(ListSubscriptionsByTopicRequest request)
        {
            return Paginator.Paginate<Subscription, ListSubscriptionsByTopicRequest, ListSubscriptionsByTopicResponse>(request, this.ListSubscriptionsByTopic);
        }
      
        #endregion

        #region ListTopicsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Topic&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Topic> ListTopicsEnumerator(ListTopicsRequest request)
        {
            return Paginator.Paginate<Topic, ListTopicsRequest, ListTopicsResponse>(request, this.ListTopics);
        }
      
        #endregion

 
    }

    public partial interface IAmazonSimpleNotificationService
    {
        #region ListEndpointsByPlatformApplicationEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Endpoint&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Endpoint> ListEndpointsByPlatformApplicationEnumerator(ListEndpointsByPlatformApplicationRequest request);
      
        #endregion

        #region ListPlatformApplicationsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;PlatformApplication&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<PlatformApplication> ListPlatformApplicationsEnumerator(ListPlatformApplicationsRequest request);
      
        #endregion

        #region ListSubscriptionsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Subscription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Subscription> ListSubscriptionsEnumerator(ListSubscriptionsRequest request);
      
        #endregion

        #region ListSubscriptionsByTopicEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Subscription&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Subscription> ListSubscriptionsByTopicEnumerator(ListSubscriptionsByTopicRequest request);
      
        #endregion

        #region ListTopicsEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonSimpleNotificationServiceClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Topic&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Topic> ListTopicsEnumerator(ListTopicsRequest request);
      
        #endregion

 
    }
}