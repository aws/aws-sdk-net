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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Paginators for the Panorama service
    ///</summary>
    public class PanoramaPaginatorFactory : IPanoramaPaginatorFactory
    {
        private readonly IAmazonPanorama client;

        internal PanoramaPaginatorFactory(IAmazonPanorama client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplicationInstanceDependencies operation
        ///</summary>
        public IListApplicationInstanceDependenciesPaginator ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request) 
        {
            return new ListApplicationInstanceDependenciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationInstanceNodeInstances operation
        ///</summary>
        public IListApplicationInstanceNodeInstancesPaginator ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request) 
        {
            return new ListApplicationInstanceNodeInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationInstances operation
        ///</summary>
        public IListApplicationInstancesPaginator ListApplicationInstances(ListApplicationInstancesRequest request) 
        {
            return new ListApplicationInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        public IListDevicesPaginator ListDevices(ListDevicesRequest request) 
        {
            return new ListDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevicesJobs operation
        ///</summary>
        public IListDevicesJobsPaginator ListDevicesJobs(ListDevicesJobsRequest request) 
        {
            return new ListDevicesJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodeFromTemplateJobs operation
        ///</summary>
        public IListNodeFromTemplateJobsPaginator ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request) 
        {
            return new ListNodeFromTemplateJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        public IListNodesPaginator ListNodes(ListNodesRequest request) 
        {
            return new ListNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackageImportJobs operation
        ///</summary>
        public IListPackageImportJobsPaginator ListPackageImportJobs(ListPackageImportJobsRequest request) 
        {
            return new ListPackageImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        public IListPackagesPaginator ListPackages(ListPackagesRequest request) 
        {
            return new ListPackagesPaginator(this.client, request);
        }
    }
}