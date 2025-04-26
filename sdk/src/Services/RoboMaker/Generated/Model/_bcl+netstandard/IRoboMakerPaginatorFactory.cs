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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Paginators for the RoboMaker service
    ///</summary>
    public interface IRoboMakerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDeploymentJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDeploymentJobsPaginator ListDeploymentJobs(ListDeploymentJobsRequest request);

        /// <summary>
        /// Paginator for ListFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFleetsPaginator ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Paginator for ListRobotApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRobotApplicationsPaginator ListRobotApplications(ListRobotApplicationsRequest request);

        /// <summary>
        /// Paginator for ListRobots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRobotsPaginator ListRobots(ListRobotsRequest request);

        /// <summary>
        /// Paginator for ListSimulationApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSimulationApplicationsPaginator ListSimulationApplications(ListSimulationApplicationsRequest request);

        /// <summary>
        /// Paginator for ListSimulationJobBatches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSimulationJobBatchesPaginator ListSimulationJobBatches(ListSimulationJobBatchesRequest request);

        /// <summary>
        /// Paginator for ListSimulationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSimulationJobsPaginator ListSimulationJobs(ListSimulationJobsRequest request);

        /// <summary>
        /// Paginator for ListWorldExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorldExportJobsPaginator ListWorldExportJobs(ListWorldExportJobsRequest request);

        /// <summary>
        /// Paginator for ListWorldGenerationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorldGenerationJobsPaginator ListWorldGenerationJobs(ListWorldGenerationJobsRequest request);

        /// <summary>
        /// Paginator for ListWorlds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorldsPaginator ListWorlds(ListWorldsRequest request);

        /// <summary>
        /// Paginator for ListWorldTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorldTemplatesPaginator ListWorldTemplates(ListWorldTemplatesRequest request);
    }
}