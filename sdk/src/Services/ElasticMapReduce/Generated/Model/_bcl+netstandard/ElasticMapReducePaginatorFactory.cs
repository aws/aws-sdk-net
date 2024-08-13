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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Paginators for the ElasticMapReduce service
    ///</summary>
    public class ElasticMapReducePaginatorFactory : IElasticMapReducePaginatorFactory
    {
        private readonly IAmazonElasticMapReduce client;

        internal ElasticMapReducePaginatorFactory(IAmazonElasticMapReduce client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBootstrapActions operation
        ///</summary>
        public IListBootstrapActionsPaginator ListBootstrapActions(ListBootstrapActionsRequest request) 
        {
            return new ListBootstrapActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClusters operation
        ///</summary>
        public IListClustersPaginator ListClusters(ListClustersRequest request) 
        {
            return new ListClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceFleets operation
        ///</summary>
        public IListInstanceFleetsPaginator ListInstanceFleets(ListInstanceFleetsRequest request) 
        {
            return new ListInstanceFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstanceGroups operation
        ///</summary>
        public IListInstanceGroupsPaginator ListInstanceGroups(ListInstanceGroupsRequest request) 
        {
            return new ListInstanceGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstances operation
        ///</summary>
        public IListInstancesPaginator ListInstances(ListInstancesRequest request) 
        {
            return new ListInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotebookExecutions operation
        ///</summary>
        public IListNotebookExecutionsPaginator ListNotebookExecutions(ListNotebookExecutionsRequest request) 
        {
            return new ListNotebookExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReleaseLabels operation
        ///</summary>
        public IListReleaseLabelsPaginator ListReleaseLabels(ListReleaseLabelsRequest request) 
        {
            return new ListReleaseLabelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecurityConfigurations operation
        ///</summary>
        public IListSecurityConfigurationsPaginator ListSecurityConfigurations(ListSecurityConfigurationsRequest request) 
        {
            return new ListSecurityConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSteps operation
        ///</summary>
        public IListStepsPaginator ListSteps(ListStepsRequest request) 
        {
            return new ListStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudios operation
        ///</summary>
        public IListStudiosPaginator ListStudios(ListStudiosRequest request) 
        {
            return new ListStudiosPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStudioSessionMappings operation
        ///</summary>
        public IListStudioSessionMappingsPaginator ListStudioSessionMappings(ListStudioSessionMappingsRequest request) 
        {
            return new ListStudioSessionMappingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSupportedInstanceTypes operation
        ///</summary>
        public IListSupportedInstanceTypesPaginator ListSupportedInstanceTypes(ListSupportedInstanceTypesRequest request) 
        {
            return new ListSupportedInstanceTypesPaginator(this.client, request);
        }
    }
}