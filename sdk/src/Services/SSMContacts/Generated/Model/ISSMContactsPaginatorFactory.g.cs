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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Paginators for the SSMContacts service
    /// </summary>
    public interface ISSMContactsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListContactChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactChannelsPaginator ListContactChannels(ListContactChannelsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListEngagements operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEngagementsPaginator ListEngagements(ListEngagementsRequest request);

        /// <summary>
        /// Paginator for ListPageReceipts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPageReceiptsPaginator ListPageReceipts(ListPageReceiptsRequest request);

        /// <summary>
        /// Paginator for ListPageResolutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListPageResolutionsPaginator ListPageResolutions(ListPageResolutionsRequest request);

        /// <summary>
        /// Paginator for ListPagesByContact operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPagesByContactPaginator ListPagesByContact(ListPagesByContactRequest request);

        /// <summary>
        /// Paginator for ListPagesByEngagement operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPagesByEngagementPaginator ListPagesByEngagement(ListPagesByEngagementRequest request);

        /// <summary>
        /// Paginator for ListPreviewRotationShifts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPreviewRotationShiftsPaginator ListPreviewRotationShifts(ListPreviewRotationShiftsRequest request);

        /// <summary>
        /// Paginator for ListRotationOverrides operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRotationOverridesPaginator ListRotationOverrides(ListRotationOverridesRequest request);

        /// <summary>
        /// Paginator for ListRotationShifts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRotationShiftsPaginator ListRotationShifts(ListRotationShiftsRequest request);

        /// <summary>
        /// Paginator for ListRotations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRotationsPaginator ListRotations(ListRotationsRequest request);
    }
}
