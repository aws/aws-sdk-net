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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Paginators for the GreengrassV2 service
    ///</summary>
    public interface IGreengrassV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for ListComponents operation
        ///</summary>
        IListComponentsPaginator ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Paginator for ListComponentVersions operation
        ///</summary>
        IListComponentVersionsPaginator ListComponentVersions(ListComponentVersionsRequest request);

        /// <summary>
        /// Paginator for ListCoreDevices operation
        ///</summary>
        IListCoreDevicesPaginator ListCoreDevices(ListCoreDevicesRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListEffectiveDeployments operation
        ///</summary>
        IListEffectiveDeploymentsPaginator ListEffectiveDeployments(ListEffectiveDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListInstalledComponents operation
        ///</summary>
        IListInstalledComponentsPaginator ListInstalledComponents(ListInstalledComponentsRequest request);
    }
}
#endif