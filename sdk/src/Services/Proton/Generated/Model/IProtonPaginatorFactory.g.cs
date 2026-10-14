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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Paginators for the Proton service
    /// </summary>
    public interface IProtonPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListComponentOutputs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListComponentOutputsPaginator ListComponentOutputs(ListComponentOutputsRequest request);

        /// <summary>
        /// Paginator for ListComponentProvisionedResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListComponentProvisionedResourcesPaginator ListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListComponents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentAccountConnections operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentAccountConnectionsPaginator ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentOutputs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListEnvironmentOutputsPaginator ListEnvironmentOutputs(ListEnvironmentOutputsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentProvisionedResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListEnvironmentProvisionedResourcesPaginator ListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentTemplateVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentTemplateVersionsPaginator ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentTemplatesPaginator ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListRepositories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListRepositorySyncDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListRepositorySyncDefinitionsPaginator ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListServiceInstanceOutputs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListServiceInstanceOutputsPaginator ListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request);

        /// <summary>
        /// Paginator for ListServiceInstanceProvisionedResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListServiceInstanceProvisionedResourcesPaginator ListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceInstancesPaginator ListServiceInstances(ListServiceInstancesRequest request);

        /// <summary>
        /// Paginator for ListServicePipelineOutputs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListServicePipelineOutputsPaginator ListServicePipelineOutputs(ListServicePipelineOutputsRequest request);

        /// <summary>
        /// Paginator for ListServicePipelineProvisionedResources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListServicePipelineProvisionedResourcesPaginator ListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request);

        /// <summary>
        /// Paginator for ListServiceTemplateVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceTemplateVersionsPaginator ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListServiceTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServiceTemplatesPaginator ListServiceTemplates(ListServiceTemplatesRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServicesPaginator ListServices(ListServicesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}
