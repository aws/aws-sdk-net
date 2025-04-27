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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Paginators for the ElasticMapReduce service
    ///</summary>
    public interface IElasticMapReducePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBootstrapActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListBootstrapActionsPaginator ListBootstrapActions(ListBootstrapActionsRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListInstanceFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListInstanceFleetsPaginator ListInstanceFleets(ListInstanceFleetsRequest request);

        /// <summary>
        /// Paginator for ListInstanceGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListInstanceGroupsPaginator ListInstanceGroups(ListInstanceGroupsRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListNotebookExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListNotebookExecutionsPaginator ListNotebookExecutions(ListNotebookExecutionsRequest request);

        /// <summary>
        /// Paginator for ListReleaseLabels operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReleaseLabelsPaginator ListReleaseLabels(ListReleaseLabelsRequest request);

        /// <summary>
        /// Paginator for ListSecurityConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListSecurityConfigurationsPaginator ListSecurityConfigurations(ListSecurityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListStepsPaginator ListSteps(ListStepsRequest request);

        /// <summary>
        /// Paginator for ListStudios operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListStudiosPaginator ListStudios(ListStudiosRequest request);

        /// <summary>
        /// Paginator for ListStudioSessionMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListStudioSessionMappingsPaginator ListStudioSessionMappings(ListStudioSessionMappingsRequest request);

        /// <summary>
        /// Paginator for ListSupportedInstanceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListSupportedInstanceTypesPaginator ListSupportedInstanceTypes(ListSupportedInstanceTypesRequest request);
    }
}