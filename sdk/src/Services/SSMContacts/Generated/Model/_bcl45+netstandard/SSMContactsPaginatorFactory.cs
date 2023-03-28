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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Paginators for the SSMContacts service
    ///</summary>
    public class SSMContactsPaginatorFactory : ISSMContactsPaginatorFactory
    {
        private readonly IAmazonSSMContacts client;

        internal SSMContactsPaginatorFactory(IAmazonSSMContacts client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListContactChannels operation
        ///</summary>
        public IListContactChannelsPaginator ListContactChannels(ListContactChannelsRequest request) 
        {
            return new ListContactChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        public IListContactsPaginator ListContacts(ListContactsRequest request) 
        {
            return new ListContactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngagements operation
        ///</summary>
        public IListEngagementsPaginator ListEngagements(ListEngagementsRequest request) 
        {
            return new ListEngagementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPageReceipts operation
        ///</summary>
        public IListPageReceiptsPaginator ListPageReceipts(ListPageReceiptsRequest request) 
        {
            return new ListPageReceiptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPageResolutions operation
        ///</summary>
        public IListPageResolutionsPaginator ListPageResolutions(ListPageResolutionsRequest request) 
        {
            return new ListPageResolutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPagesByContact operation
        ///</summary>
        public IListPagesByContactPaginator ListPagesByContact(ListPagesByContactRequest request) 
        {
            return new ListPagesByContactPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPagesByEngagement operation
        ///</summary>
        public IListPagesByEngagementPaginator ListPagesByEngagement(ListPagesByEngagementRequest request) 
        {
            return new ListPagesByEngagementPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPreviewRotationShifts operation
        ///</summary>
        public IListPreviewRotationShiftsPaginator ListPreviewRotationShifts(ListPreviewRotationShiftsRequest request) 
        {
            return new ListPreviewRotationShiftsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRotationOverrides operation
        ///</summary>
        public IListRotationOverridesPaginator ListRotationOverrides(ListRotationOverridesRequest request) 
        {
            return new ListRotationOverridesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRotations operation
        ///</summary>
        public IListRotationsPaginator ListRotations(ListRotationsRequest request) 
        {
            return new ListRotationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRotationShifts operation
        ///</summary>
        public IListRotationShiftsPaginator ListRotationShifts(ListRotationShiftsRequest request) 
        {
            return new ListRotationShiftsPaginator(this.client, request);
        }
    }
}