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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Paginators for the IoTManagedIntegrations service
    /// </summary>
    public interface IIoTManagedIntegrationsPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccountAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountAssociationsPaginator ListAccountAssociations(ListAccountAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCloudConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCloudConnectorsPaginator ListCloudConnectors(ListCloudConnectorsRequest request);

        /// <summary>
        /// Paginator for ListConnectorDestinations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectorDestinationsPaginator ListConnectorDestinations(ListConnectorDestinationsRequest request);

        /// <summary>
        /// Paginator for ListCredentialLockers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCredentialLockersPaginator ListCredentialLockers(ListCredentialLockersRequest request);

        /// <summary>
        /// Paginator for ListDestinations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDestinationsPaginator ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Paginator for ListDeviceDiscoveries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDeviceDiscoveriesPaginator ListDeviceDiscoveries(ListDeviceDiscoveriesRequest request);

        /// <summary>
        /// Paginator for ListDiscoveredDevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDiscoveredDevicesPaginator ListDiscoveredDevices(ListDiscoveredDevicesRequest request);

        /// <summary>
        /// Paginator for ListEventLogConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEventLogConfigurationsPaginator ListEventLogConfigurations(ListEventLogConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListManagedThingAccountAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedThingAccountAssociationsPaginator ListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request);

        /// <summary>
        /// Paginator for ListManagedThingSchemas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedThingSchemasPaginator ListManagedThingSchemas(ListManagedThingSchemasRequest request);

        /// <summary>
        /// Paginator for ListManagedThings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListManagedThingsPaginator ListManagedThings(ListManagedThingsRequest request);

        /// <summary>
        /// Paginator for ListNotificationConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotificationConfigurationsPaginator ListNotificationConfigurations(ListNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListOtaTaskConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOtaTaskConfigurationsPaginator ListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListOtaTaskExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOtaTaskExecutionsPaginator ListOtaTaskExecutions(ListOtaTaskExecutionsRequest request);

        /// <summary>
        /// Paginator for ListOtaTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOtaTasksPaginator ListOtaTasks(ListOtaTasksRequest request);

        /// <summary>
        /// Paginator for ListProvisioningProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProvisioningProfilesPaginator ListProvisioningProfiles(ListProvisioningProfilesRequest request);

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request);
    }
}
