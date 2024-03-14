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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Paginators for the SSMContacts service
    ///</summary>
    public interface ISSMContactsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListContactChannels operation
        ///</summary>
        IListContactChannelsPaginator ListContactChannels(ListContactChannelsRequest request);

        /// <summary>
        /// Paginator for ListContacts operation
        ///</summary>
        IListContactsPaginator ListContacts(ListContactsRequest request);

        /// <summary>
        /// Paginator for ListEngagements operation
        ///</summary>
        IListEngagementsPaginator ListEngagements(ListEngagementsRequest request);

        /// <summary>
        /// Paginator for ListPageReceipts operation
        ///</summary>
        IListPageReceiptsPaginator ListPageReceipts(ListPageReceiptsRequest request);

        /// <summary>
        /// Paginator for ListPageResolutions operation
        ///</summary>
        IListPageResolutionsPaginator ListPageResolutions(ListPageResolutionsRequest request);

        /// <summary>
        /// Paginator for ListPagesByContact operation
        ///</summary>
        IListPagesByContactPaginator ListPagesByContact(ListPagesByContactRequest request);

        /// <summary>
        /// Paginator for ListPagesByEngagement operation
        ///</summary>
        IListPagesByEngagementPaginator ListPagesByEngagement(ListPagesByEngagementRequest request);

        /// <summary>
        /// Paginator for ListPreviewRotationShifts operation
        ///</summary>
        IListPreviewRotationShiftsPaginator ListPreviewRotationShifts(ListPreviewRotationShiftsRequest request);

        /// <summary>
        /// Paginator for ListRotationOverrides operation
        ///</summary>
        IListRotationOverridesPaginator ListRotationOverrides(ListRotationOverridesRequest request);

        /// <summary>
        /// Paginator for ListRotations operation
        ///</summary>
        IListRotationsPaginator ListRotations(ListRotationsRequest request);

        /// <summary>
        /// Paginator for ListRotationShifts operation
        ///</summary>
        IListRotationShiftsPaginator ListRotationShifts(ListRotationShiftsRequest request);
    }
}