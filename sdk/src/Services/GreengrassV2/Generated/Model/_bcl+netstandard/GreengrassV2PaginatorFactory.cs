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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Paginators for the GreengrassV2 service
    ///</summary>
    public class GreengrassV2PaginatorFactory : IGreengrassV2PaginatorFactory
    {
        private readonly IAmazonGreengrassV2 client;

        internal GreengrassV2PaginatorFactory(IAmazonGreengrassV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListClientDevicesAssociatedWithCoreDevice operation
        ///</summary>
        public IListClientDevicesAssociatedWithCoreDevicePaginator ListClientDevicesAssociatedWithCoreDevice(ListClientDevicesAssociatedWithCoreDeviceRequest request) 
        {
            return new ListClientDevicesAssociatedWithCoreDevicePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        public IListComponentsPaginator ListComponents(ListComponentsRequest request) 
        {
            return new ListComponentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComponentVersions operation
        ///</summary>
        public IListComponentVersionsPaginator ListComponentVersions(ListComponentVersionsRequest request) 
        {
            return new ListComponentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCoreDevices operation
        ///</summary>
        public IListCoreDevicesPaginator ListCoreDevices(ListCoreDevicesRequest request) 
        {
            return new ListCoreDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEffectiveDeployments operation
        ///</summary>
        public IListEffectiveDeploymentsPaginator ListEffectiveDeployments(ListEffectiveDeploymentsRequest request) 
        {
            return new ListEffectiveDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInstalledComponents operation
        ///</summary>
        public IListInstalledComponentsPaginator ListInstalledComponents(ListInstalledComponentsRequest request) 
        {
            return new ListInstalledComponentsPaginator(this.client, request);
        }
    }
}