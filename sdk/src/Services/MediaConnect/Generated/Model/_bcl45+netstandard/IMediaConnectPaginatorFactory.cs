#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Paginators for the MediaConnect service
    ///</summary>
    public interface IMediaConnectPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEntitlements operation
        ///</summary>
        IListEntitlementsPaginator ListEntitlements(ListEntitlementsRequest request);

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        IListFlowsPaginator ListFlows(ListFlowsRequest request);

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        IListOfferingsPaginator ListOfferings(ListOfferingsRequest request);

        /// <summary>
        /// Paginator for ListReservations operation
        ///</summary>
        IListReservationsPaginator ListReservations(ListReservationsRequest request);
    }
}
#endif