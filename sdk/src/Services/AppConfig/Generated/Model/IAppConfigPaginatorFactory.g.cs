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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Paginators for the AppConfig service
    /// </summary>
    public interface IAppConfigPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConfigurationProfilesPaginator ListConfigurationProfiles(ListConfigurationProfilesRequest request);

        /// <summary>
        /// Paginator for ListDeploymentStrategies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDeploymentStrategiesPaginator ListDeploymentStrategies(ListDeploymentStrategiesRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListExperimentDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExperimentDefinitionsPaginator ListExperimentDefinitions(ListExperimentDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListExperimentRunEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExperimentRunEventsPaginator ListExperimentRunEvents(ListExperimentRunEventsRequest request);

        /// <summary>
        /// Paginator for ListExperimentRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExperimentRunsPaginator ListExperimentRuns(ListExperimentRunsRequest request);

        /// <summary>
        /// Paginator for ListExtensionAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExtensionAssociationsPaginator ListExtensionAssociations(ListExtensionAssociationsRequest request);

        /// <summary>
        /// Paginator for ListExtensions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExtensionsPaginator ListExtensions(ListExtensionsRequest request);

        /// <summary>
        /// Paginator for ListHostedConfigurationVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListHostedConfigurationVersionsPaginator ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request);
    }
}
