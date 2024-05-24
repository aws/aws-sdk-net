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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Paginators for the RoboMaker service
    ///</summary>
    public class RoboMakerPaginatorFactory : IRoboMakerPaginatorFactory
    {
        private readonly IAmazonRoboMaker client;

        internal RoboMakerPaginatorFactory(IAmazonRoboMaker client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDeploymentJobs operation
        ///</summary>
        public IListDeploymentJobsPaginator ListDeploymentJobs(ListDeploymentJobsRequest request) 
        {
            return new ListDeploymentJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        public IListFleetsPaginator ListFleets(ListFleetsRequest request) 
        {
            return new ListFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRobotApplications operation
        ///</summary>
        public IListRobotApplicationsPaginator ListRobotApplications(ListRobotApplicationsRequest request) 
        {
            return new ListRobotApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRobots operation
        ///</summary>
        public IListRobotsPaginator ListRobots(ListRobotsRequest request) 
        {
            return new ListRobotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSimulationApplications operation
        ///</summary>
        public IListSimulationApplicationsPaginator ListSimulationApplications(ListSimulationApplicationsRequest request) 
        {
            return new ListSimulationApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSimulationJobBatches operation
        ///</summary>
        public IListSimulationJobBatchesPaginator ListSimulationJobBatches(ListSimulationJobBatchesRequest request) 
        {
            return new ListSimulationJobBatchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSimulationJobs operation
        ///</summary>
        public IListSimulationJobsPaginator ListSimulationJobs(ListSimulationJobsRequest request) 
        {
            return new ListSimulationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorldExportJobs operation
        ///</summary>
        public IListWorldExportJobsPaginator ListWorldExportJobs(ListWorldExportJobsRequest request) 
        {
            return new ListWorldExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorldGenerationJobs operation
        ///</summary>
        public IListWorldGenerationJobsPaginator ListWorldGenerationJobs(ListWorldGenerationJobsRequest request) 
        {
            return new ListWorldGenerationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorlds operation
        ///</summary>
        public IListWorldsPaginator ListWorlds(ListWorldsRequest request) 
        {
            return new ListWorldsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorldTemplates operation
        ///</summary>
        public IListWorldTemplatesPaginator ListWorldTemplates(ListWorldTemplatesRequest request) 
        {
            return new ListWorldTemplatesPaginator(this.client, request);
        }
    }
}