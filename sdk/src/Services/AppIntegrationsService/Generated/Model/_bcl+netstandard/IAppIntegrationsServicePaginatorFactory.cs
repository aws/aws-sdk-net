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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Paginators for the AppIntegrationsService service
    ///</summary>
    public interface IAppIntegrationsServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplicationAssociations operation
        ///</summary>
        IListApplicationAssociationsPaginator ListApplicationAssociations(ListApplicationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListDataIntegrationAssociations operation
        ///</summary>
        IListDataIntegrationAssociationsPaginator ListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListDataIntegrations operation
        ///</summary>
        IListDataIntegrationsPaginator ListDataIntegrations(ListDataIntegrationsRequest request);

        /// <summary>
        /// Paginator for ListEventIntegrationAssociations operation
        ///</summary>
        IListEventIntegrationAssociationsPaginator ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request);

        /// <summary>
        /// Paginator for ListEventIntegrations operation
        ///</summary>
        IListEventIntegrationsPaginator ListEventIntegrations(ListEventIntegrationsRequest request);
    }
}