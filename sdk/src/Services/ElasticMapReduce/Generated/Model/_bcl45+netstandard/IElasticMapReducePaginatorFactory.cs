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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */

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
        IListBootstrapActionsPaginator ListBootstrapActions(ListBootstrapActionsRequest request);

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        IListClustersPaginator ListClusters(ListClustersRequest request);

        /// <summary>
        /// Paginator for ListInstanceFleets operation
        ///</summary>
        IListInstanceFleetsPaginator ListInstanceFleets(ListInstanceFleetsRequest request);

        /// <summary>
        /// Paginator for ListInstanceGroups operation
        ///</summary>
        IListInstanceGroupsPaginator ListInstanceGroups(ListInstanceGroupsRequest request);

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        IListInstancesPaginator ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Paginator for ListNotebookExecutions operation
        ///</summary>
        IListNotebookExecutionsPaginator ListNotebookExecutions(ListNotebookExecutionsRequest request);

        /// <summary>
        /// Paginator for ListSecurityConfigurations operation
        ///</summary>
        IListSecurityConfigurationsPaginator ListSecurityConfigurations(ListSecurityConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        IListStepsPaginator ListSteps(ListStepsRequest request);

        /// <summary>
        /// Paginator for ListStudios operation
        ///</summary>
        IListStudiosPaginator ListStudios(ListStudiosRequest request);

        /// <summary>
        /// Paginator for ListStudioSessionMappings operation
        ///</summary>
        IListStudioSessionMappingsPaginator ListStudioSessionMappings(ListStudioSessionMappingsRequest request);
    }
}
#endif