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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Paginators for the SimpleNotificationService service
    ///</summary>
    public interface ISimpleNotificationServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEndpointsByPlatformApplication operation
        ///</summary>
        IListEndpointsByPlatformApplicationPaginator ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request);

        /// <summary>
        /// Paginator for ListOriginationNumbers operation
        ///</summary>
        IListOriginationNumbersPaginator ListOriginationNumbers(ListOriginationNumbersRequest request);

        /// <summary>
        /// Paginator for ListPlatformApplications operation
        ///</summary>
        IListPlatformApplicationsPaginator ListPlatformApplications(ListPlatformApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSMSSandboxPhoneNumbers operation
        ///</summary>
        IListSMSSandboxPhoneNumbersPaginator ListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListSubscriptions operation
        ///</summary>
        IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionsByTopic operation
        ///</summary>
        IListSubscriptionsByTopicPaginator ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Paginator for ListTopics operation
        ///</summary>
        IListTopicsPaginator ListTopics(ListTopicsRequest request);
    }
}