/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Paginators for the SimpleNotificationService service
    ///</summary>
    public class SimpleNotificationServicePaginatorFactory : ISimpleNotificationServicePaginatorFactory
    {
        private readonly IAmazonSimpleNotificationService client;

        internal SimpleNotificationServicePaginatorFactory(IAmazonSimpleNotificationService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEndpointsByPlatformApplication operation
        ///</summary>
        public IListEndpointsByPlatformApplicationPaginator ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request) 
        {
            return new ListEndpointsByPlatformApplicationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOriginationNumbers operation
        ///</summary>
        public IListOriginationNumbersPaginator ListOriginationNumbers(ListOriginationNumbersRequest request) 
        {
            return new ListOriginationNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPhoneNumbersOptedOut operation
        ///</summary>
        public IListPhoneNumbersOptedOutPaginator ListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request) 
        {
            return new ListPhoneNumbersOptedOutPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlatformApplications operation
        ///</summary>
        public IListPlatformApplicationsPaginator ListPlatformApplications(ListPlatformApplicationsRequest request) 
        {
            return new ListPlatformApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSMSSandboxPhoneNumbers operation
        ///</summary>
        public IListSMSSandboxPhoneNumbersPaginator ListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request) 
        {
            return new ListSMSSandboxPhoneNumbersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptions operation
        ///</summary>
        public IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request) 
        {
            return new ListSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptionsByTopic operation
        ///</summary>
        public IListSubscriptionsByTopicPaginator ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request) 
        {
            return new ListSubscriptionsByTopicPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTopics operation
        ///</summary>
        public IListTopicsPaginator ListTopics(ListTopicsRequest request) 
        {
            return new ListTopicsPaginator(this.client, request);
        }
    }
}