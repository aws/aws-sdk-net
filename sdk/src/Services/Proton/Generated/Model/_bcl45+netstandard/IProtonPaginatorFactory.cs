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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Paginators for the Proton service
    ///</summary>
    public interface IProtonPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListComponentOutputs operation
        ///</summary>
        IListComponentOutputsPaginator ListComponentOutputs(ListComponentOutputsRequest request);

        /// <summary>
        /// Paginator for ListComponentProvisionedResources operation
        ///</summary>
        IListComponentProvisionedResourcesPaginator ListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentAccountConnections operation
        ///</summary>
        IListEnvironmentAccountConnectionsPaginator ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentOutputs operation
        ///</summary>
        IListEnvironmentOutputsPaginator ListEnvironmentOutputs(ListEnvironmentOutputsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentProvisionedResources operation
        ///</summary>
        IListEnvironmentProvisionedResourcesPaginator ListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentTemplates operation
        ///</summary>
        IListEnvironmentTemplatesPaginator ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentTemplateVersions operation
        ///</summary>
        IListEnvironmentTemplateVersionsPaginator ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListRepositorySyncDefinitions operation
        ///</summary>
        IListRepositorySyncDefinitionsPaginator ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListServiceInstanceOutputs operation
        ///</summary>
        IListServiceInstanceOutputsPaginator ListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request);

        /// <summary>
        /// Paginator for ListServiceInstanceProvisionedResources operation
        ///</summary>
        IListServiceInstanceProvisionedResourcesPaginator ListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceInstances operation
        ///</summary>
        IListServiceInstancesPaginator ListServiceInstances(ListServiceInstancesRequest request);

        /// <summary>
        /// Paginator for ListServicePipelineOutputs operation
        ///</summary>
        IListServicePipelineOutputsPaginator ListServicePipelineOutputs(ListServicePipelineOutputsRequest request);

        /// <summary>
        /// Paginator for ListServicePipelineProvisionedResources operation
        ///</summary>
        IListServicePipelineProvisionedResourcesPaginator ListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListServiceTemplates operation
        ///</summary>
        IListServiceTemplatesPaginator ListServiceTemplates(ListServiceTemplatesRequest request);

        /// <summary>
        /// Paginator for ListServiceTemplateVersions operation
        ///</summary>
        IListServiceTemplateVersionsPaginator ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}