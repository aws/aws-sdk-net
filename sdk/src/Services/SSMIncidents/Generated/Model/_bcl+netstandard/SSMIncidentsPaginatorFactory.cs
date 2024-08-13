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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Paginators for the SSMIncidents service
    ///</summary>
    public class SSMIncidentsPaginatorFactory : ISSMIncidentsPaginatorFactory
    {
        private readonly IAmazonSSMIncidents client;

        internal SSMIncidentsPaginatorFactory(IAmazonSSMIncidents client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetResourcePolicies operation
        ///</summary>
        public IGetResourcePoliciesPaginator GetResourcePolicies(GetResourcePoliciesRequest request) 
        {
            return new GetResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIncidentFindings operation
        ///</summary>
        public IListIncidentFindingsPaginator ListIncidentFindings(ListIncidentFindingsRequest request) 
        {
            return new ListIncidentFindingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIncidentRecords operation
        ///</summary>
        public IListIncidentRecordsPaginator ListIncidentRecords(ListIncidentRecordsRequest request) 
        {
            return new ListIncidentRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRelatedItems operation
        ///</summary>
        public IListRelatedItemsPaginator ListRelatedItems(ListRelatedItemsRequest request) 
        {
            return new ListRelatedItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReplicationSets operation
        ///</summary>
        public IListReplicationSetsPaginator ListReplicationSets(ListReplicationSetsRequest request) 
        {
            return new ListReplicationSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResponsePlans operation
        ///</summary>
        public IListResponsePlansPaginator ListResponsePlans(ListResponsePlansRequest request) 
        {
            return new ListResponsePlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTimelineEvents operation
        ///</summary>
        public IListTimelineEventsPaginator ListTimelineEvents(ListTimelineEventsRequest request) 
        {
            return new ListTimelineEventsPaginator(this.client, request);
        }
    }
}