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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationInstanceDependenciesPaginator ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request);

        /// <summary>
        /// Paginator for ListApplicationInstanceNodeInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationInstanceNodeInstancesPaginator ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request);

        /// <summary>
        /// Paginator for ListApplicationInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationInstancesPaginator ListApplicationInstances(ListApplicationInstancesRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListDevicesJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDevicesJobsPaginator ListDevicesJobs(ListDevicesJobsRequest request);

        /// <summary>
        /// Paginator for ListNodeFromTemplateJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodeFromTemplateJobsPaginator ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request);

        /// <summary>
        /// Paginator for ListNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNodesPaginator ListNodes(ListNodesRequest request);

        /// <summary>
        /// Paginator for ListPackageImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPackageImportJobsPaginator ListPackageImportJobs(ListPackageImportJobsRequest request);

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPackagesPaginator ListPackages(ListPackagesRequest request);
    }
}