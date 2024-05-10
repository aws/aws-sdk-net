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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Paginators for the MigrationHubRefactorSpaces service
    ///</summary>
    public class MigrationHubRefactorSpacesPaginatorFactory : IMigrationHubRefactorSpacesPaginatorFactory
    {
        private readonly IAmazonMigrationHubRefactorSpaces client;

        internal MigrationHubRefactorSpacesPaginatorFactory(IAmazonMigrationHubRefactorSpaces client) 
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
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironmentVpcs operation
        ///</summary>
        public IListEnvironmentVpcsPaginator ListEnvironmentVpcs(ListEnvironmentVpcsRequest request) 
        {
            return new ListEnvironmentVpcsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRoutes operation
        ///</summary>
        public IListRoutesPaginator ListRoutes(ListRoutesRequest request) 
        {
            return new ListRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        public IListServicesPaginator ListServices(ListServicesRequest request) 
        {
            return new ListServicesPaginator(this.client, request);
        }
    }
}