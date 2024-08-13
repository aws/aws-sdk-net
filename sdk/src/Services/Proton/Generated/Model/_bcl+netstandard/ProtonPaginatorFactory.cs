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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Paginators for the Proton service
    ///</summary>
    public class ProtonPaginatorFactory : IProtonPaginatorFactory
    {
        private readonly IAmazonProton client;

        internal ProtonPaginatorFactory(IAmazonProton client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListComponentOutputs operation
        ///</summary>
        public IListComponentOutputsPaginator ListComponentOutputs(ListComponentOutputsRequest request) 
        {
            return new ListComponentOutputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponentProvisionedResources operation
        ///</summary>
        public IListComponentProvisionedResourcesPaginator ListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request) 
        {
            return new ListComponentProvisionedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentAccountConnections operation
        ///</summary>
        public IListEnvironmentAccountConnectionsPaginator ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request) 
        {
            return new ListEnvironmentAccountConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentOutputs operation
        ///</summary>
        public IListEnvironmentOutputsPaginator ListEnvironmentOutputs(ListEnvironmentOutputsRequest request) 
        {
            return new ListEnvironmentOutputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentProvisionedResources operation
        ///</summary>
        public IListEnvironmentProvisionedResourcesPaginator ListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request) 
        {
            return new ListEnvironmentProvisionedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentTemplates operation
        ///</summary>
        public IListEnvironmentTemplatesPaginator ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request) 
        {
            return new ListEnvironmentTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentTemplateVersions operation
        ///</summary>
        public IListEnvironmentTemplateVersionsPaginator ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request) 
        {
            return new ListEnvironmentTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        public IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request) 
        {
            return new ListRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositorySyncDefinitions operation
        ///</summary>
        public IListRepositorySyncDefinitionsPaginator ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request) 
        {
            return new ListRepositorySyncDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceInstanceOutputs operation
        ///</summary>
        public IListServiceInstanceOutputsPaginator ListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request) 
        {
            return new ListServiceInstanceOutputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceInstanceProvisionedResources operation
        ///</summary>
        public IListServiceInstanceProvisionedResourcesPaginator ListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request) 
        {
            return new ListServiceInstanceProvisionedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceInstances operation
        ///</summary>
        public IListServiceInstancesPaginator ListServiceInstances(ListServiceInstancesRequest request) 
        {
            return new ListServiceInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServicePipelineOutputs operation
        ///</summary>
        public IListServicePipelineOutputsPaginator ListServicePipelineOutputs(ListServicePipelineOutputsRequest request) 
        {
            return new ListServicePipelineOutputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServicePipelineProvisionedResources operation
        ///</summary>
        public IListServicePipelineProvisionedResourcesPaginator ListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request) 
        {
            return new ListServicePipelineProvisionedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceTemplates operation
        ///</summary>
        public IListServiceTemplatesPaginator ListServiceTemplates(ListServiceTemplatesRequest request) 
        {
            return new ListServiceTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceTemplateVersions operation
        ///</summary>
        public IListServiceTemplateVersionsPaginator ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request) 
        {
            return new ListServiceTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}