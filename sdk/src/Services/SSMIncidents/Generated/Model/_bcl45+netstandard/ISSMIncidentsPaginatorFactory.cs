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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Paginators for the SSMIncidents service
    ///</summary>
    public interface ISSMIncidentsPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Paginator for ListIncidentRecords operation
        ///</summary>
        IListIncidentRecordsPaginator ListIncidentRecords(ListIncidentRecordsRequest request);

        /// <summary>
        /// Paginator for ListRelatedItems operation
        ///</summary>
        IListRelatedItemsPaginator ListRelatedItems(ListRelatedItemsRequest request);

        /// <summary>
        /// Paginator for ListReplicationSets operation
        ///</summary>
        IListReplicationSetsPaginator ListReplicationSets(ListReplicationSetsRequest request);

        /// <summary>
        /// Paginator for ListResponsePlans operation
        ///</summary>
        IListResponsePlansPaginator ListResponsePlans(ListResponsePlansRequest request);

        /// <summary>
        /// Paginator for ListTimelineEvents operation
        ///</summary>
        IListTimelineEventsPaginator ListTimelineEvents(ListTimelineEventsRequest request);
    }
}