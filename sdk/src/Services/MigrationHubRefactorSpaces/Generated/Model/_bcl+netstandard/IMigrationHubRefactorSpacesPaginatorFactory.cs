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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Paginators for the MigrationHubRefactorSpaces service
    ///</summary>
    public interface IMigrationHubRefactorSpacesPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListEnvironmentVpcs operation
        ///</summary>
        IListEnvironmentVpcsPaginator ListEnvironmentVpcs(ListEnvironmentVpcsRequest request);

        /// <summary>
        /// Paginator for ListRoutes operation
        ///</summary>
        IListRoutesPaginator ListRoutes(ListRoutesRequest request);

        /// <summary>
        /// Paginator for ListServices operation
        ///</summary>
        IListServicesPaginator ListServices(ListServicesRequest request);
    }
}