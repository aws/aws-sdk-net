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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Paginators for the SimpleNotificationService service
    /// </summary>
    public interface ISimpleNotificationServicePaginatorFactory
    {
        /// <summary>
        /// Paginator for ListEndpointsByPlatformApplication operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListEndpointsByPlatformApplicationPaginator ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request);

        /// <summary>
        /// Paginator for ListOriginationNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOriginationNumbersPaginator ListOriginationNumbers(ListOriginationNumbersRequest request);

        /// <summary>
        /// Paginator for ListPhoneNumbersOptedOut operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListPhoneNumbersOptedOutPaginator ListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request);

        /// <summary>
        /// Paginator for ListPlatformApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListPlatformApplicationsPaginator ListPlatformApplications(ListPlatformApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSMSSandboxPhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSMSSandboxPhoneNumbersPaginator ListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListSubscriptionsByTopic operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListSubscriptionsByTopicPaginator ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Paginator for ListTopics operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListTopicsPaginator ListTopics(ListTopicsRequest request);
    }
}
