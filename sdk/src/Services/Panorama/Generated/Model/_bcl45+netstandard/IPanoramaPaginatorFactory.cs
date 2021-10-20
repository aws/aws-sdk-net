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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Paginators for the Panorama service
    ///</summary>
    public interface IPanoramaPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplicationInstanceDependencies operation
        ///</summary>
        IListApplicationInstanceDependenciesPaginator ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request);

        /// <summary>
        /// Paginator for ListApplicationInstanceNodeInstances operation
        ///</summary>
        IListApplicationInstanceNodeInstancesPaginator ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request);

        /// <summary>
        /// Paginator for ListApplicationInstances operation
        ///</summary>
        IListApplicationInstancesPaginator ListApplicationInstances(ListApplicationInstancesRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListDevicesJobs operation
        ///</summary>
        IListDevicesJobsPaginator ListDevicesJobs(ListDevicesJobsRequest request);

        /// <summary>
        /// Paginator for ListNodeFromTemplateJobs operation
        ///</summary>
        IListNodeFromTemplateJobsPaginator ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListPackageImportJobs operation
        ///</summary>
        IListPackageImportJobsPaginator ListPackageImportJobs(ListPackageImportJobsRequest request);

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        IListPackagesPaginator ListPackages(ListPackagesRequest request);
    }
}