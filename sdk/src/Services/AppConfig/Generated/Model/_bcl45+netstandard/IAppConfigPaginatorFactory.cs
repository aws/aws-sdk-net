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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Paginators for the AppConfig service
    ///</summary>
    public interface IAppConfigPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListConfigurationProfiles operation
        ///</summary>
        IListConfigurationProfilesPaginator ListConfigurationProfiles(ListConfigurationProfilesRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListDeploymentStrategies operation
        ///</summary>
        IListDeploymentStrategiesPaginator ListDeploymentStrategies(ListDeploymentStrategiesRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListHostedConfigurationVersions operation
        ///</summary>
        IListHostedConfigurationVersionsPaginator ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request);
    }
}
#endif