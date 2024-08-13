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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Paginators for the AppConfig service
    ///</summary>
    public class AppConfigPaginatorFactory : IAppConfigPaginatorFactory
    {
        private readonly IAmazonAppConfig client;

        internal AppConfigPaginatorFactory(IAmazonAppConfig client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConfigurationProfiles operation
        ///</summary>
        public IListConfigurationProfilesPaginator ListConfigurationProfiles(ListConfigurationProfilesRequest request) 
        {
            return new ListConfigurationProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeploymentStrategies operation
        ///</summary>
        public IListDeploymentStrategiesPaginator ListDeploymentStrategies(ListDeploymentStrategiesRequest request) 
        {
            return new ListDeploymentStrategiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExtensionAssociations operation
        ///</summary>
        public IListExtensionAssociationsPaginator ListExtensionAssociations(ListExtensionAssociationsRequest request) 
        {
            return new ListExtensionAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExtensions operation
        ///</summary>
        public IListExtensionsPaginator ListExtensions(ListExtensionsRequest request) 
        {
            return new ListExtensionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHostedConfigurationVersions operation
        ///</summary>
        public IListHostedConfigurationVersionsPaginator ListHostedConfigurationVersions(ListHostedConfigurationVersionsRequest request) 
        {
            return new ListHostedConfigurationVersionsPaginator(this.client, request);
        }
    }
}