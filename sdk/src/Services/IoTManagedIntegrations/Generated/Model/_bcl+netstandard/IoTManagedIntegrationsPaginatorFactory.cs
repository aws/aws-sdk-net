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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Paginators for the IoTManagedIntegrations service
    ///</summary>
    public class IoTManagedIntegrationsPaginatorFactory : IIoTManagedIntegrationsPaginatorFactory
    {
        private readonly IAmazonIoTManagedIntegrations client;

        internal IoTManagedIntegrationsPaginatorFactory(IAmazonIoTManagedIntegrations client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountAssociations operation
        ///</summary>
        public IListAccountAssociationsPaginator ListAccountAssociations(ListAccountAssociationsRequest request) 
        {
            return new ListAccountAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCloudConnectors operation
        ///</summary>
        public IListCloudConnectorsPaginator ListCloudConnectors(ListCloudConnectorsRequest request) 
        {
            return new ListCloudConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectorDestinations operation
        ///</summary>
        public IListConnectorDestinationsPaginator ListConnectorDestinations(ListConnectorDestinationsRequest request) 
        {
            return new ListConnectorDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCredentialLockers operation
        ///</summary>
        public IListCredentialLockersPaginator ListCredentialLockers(ListCredentialLockersRequest request) 
        {
            return new ListCredentialLockersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        public IListDestinationsPaginator ListDestinations(ListDestinationsRequest request) 
        {
            return new ListDestinationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeviceDiscoveries operation
        ///</summary>
        public IListDeviceDiscoveriesPaginator ListDeviceDiscoveries(ListDeviceDiscoveriesRequest request) 
        {
            return new ListDeviceDiscoveriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDiscoveredDevices operation
        ///</summary>
        public IListDiscoveredDevicesPaginator ListDiscoveredDevices(ListDiscoveredDevicesRequest request) 
        {
            return new ListDiscoveredDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEventLogConfigurations operation
        ///</summary>
        public IListEventLogConfigurationsPaginator ListEventLogConfigurations(ListEventLogConfigurationsRequest request) 
        {
            return new ListEventLogConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedThingAccountAssociations operation
        ///</summary>
        public IListManagedThingAccountAssociationsPaginator ListManagedThingAccountAssociations(ListManagedThingAccountAssociationsRequest request) 
        {
            return new ListManagedThingAccountAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedThings operation
        ///</summary>
        public IListManagedThingsPaginator ListManagedThings(ListManagedThingsRequest request) 
        {
            return new ListManagedThingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedThingSchemas operation
        ///</summary>
        public IListManagedThingSchemasPaginator ListManagedThingSchemas(ListManagedThingSchemasRequest request) 
        {
            return new ListManagedThingSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotificationConfigurations operation
        ///</summary>
        public IListNotificationConfigurationsPaginator ListNotificationConfigurations(ListNotificationConfigurationsRequest request) 
        {
            return new ListNotificationConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOtaTaskConfigurations operation
        ///</summary>
        public IListOtaTaskConfigurationsPaginator ListOtaTaskConfigurations(ListOtaTaskConfigurationsRequest request) 
        {
            return new ListOtaTaskConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOtaTaskExecutions operation
        ///</summary>
        public IListOtaTaskExecutionsPaginator ListOtaTaskExecutions(ListOtaTaskExecutionsRequest request) 
        {
            return new ListOtaTaskExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOtaTasks operation
        ///</summary>
        public IListOtaTasksPaginator ListOtaTasks(ListOtaTasksRequest request) 
        {
            return new ListOtaTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisioningProfiles operation
        ///</summary>
        public IListProvisioningProfilesPaginator ListProvisioningProfiles(ListProvisioningProfilesRequest request) 
        {
            return new ListProvisioningProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        ///</summary>
        public IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request) 
        {
            return new ListSchemaVersionsPaginator(this.client, request);
        }
    }
}