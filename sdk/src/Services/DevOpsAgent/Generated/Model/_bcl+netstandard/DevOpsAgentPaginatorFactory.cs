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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Paginators for the DevOpsAgent service
    ///</summary>
    public class DevOpsAgentPaginatorFactory : IDevOpsAgentPaginatorFactory
    {
        private readonly IAmazonDevOpsAgent client;

        internal DevOpsAgentPaginatorFactory(IAmazonDevOpsAgent client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAgentSpaces operation
        ///</summary>
        public IListAgentSpacesPaginator ListAgentSpaces(ListAgentSpacesRequest request) 
        {
            return new ListAgentSpacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        public IListAssociationsPaginator ListAssociations(ListAssociationsRequest request) 
        {
            return new ListAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBacklogTasks operation
        ///</summary>
        public IListBacklogTasksPaginator ListBacklogTasks(ListBacklogTasksRequest request) 
        {
            return new ListBacklogTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExecutions operation
        ///</summary>
        public IListExecutionsPaginator ListExecutions(ListExecutionsRequest request) 
        {
            return new ListExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGoals operation
        ///</summary>
        public IListGoalsPaginator ListGoals(ListGoalsRequest request) 
        {
            return new ListGoalsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJournalRecords operation
        ///</summary>
        public IListJournalRecordsPaginator ListJournalRecords(ListJournalRecordsRequest request) 
        {
            return new ListJournalRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }
    }
}