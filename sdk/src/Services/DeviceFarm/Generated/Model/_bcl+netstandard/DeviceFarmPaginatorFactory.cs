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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Paginators for the DeviceFarm service
    ///</summary>
    public class DeviceFarmPaginatorFactory : IDeviceFarmPaginatorFactory
    {
        private readonly IAmazonDeviceFarm client;

        internal DeviceFarmPaginatorFactory(IAmazonDeviceFarm client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetOfferingStatus operation
        ///</summary>
        public IGetOfferingStatusPaginator GetOfferingStatus(GetOfferingStatusRequest request) 
        {
            return new GetOfferingStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListArtifacts operation
        ///</summary>
        public IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request) 
        {
            return new ListArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevicePools operation
        ///</summary>
        public IListDevicePoolsPaginator ListDevicePools(ListDevicePoolsRequest request) 
        {
            return new ListDevicePoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        public IListDevicesPaginator ListDevices(ListDevicesRequest request) 
        {
            return new ListDevicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        public IListOfferingsPaginator ListOfferings(ListOfferingsRequest request) 
        {
            return new ListOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOfferingTransactions operation
        ///</summary>
        public IListOfferingTransactionsPaginator ListOfferingTransactions(ListOfferingTransactionsRequest request) 
        {
            return new ListOfferingTransactionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        public IListProjectsPaginator ListProjects(ListProjectsRequest request) 
        {
            return new ListProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuns operation
        ///</summary>
        public IListRunsPaginator ListRuns(ListRunsRequest request) 
        {
            return new ListRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSamples operation
        ///</summary>
        public IListSamplesPaginator ListSamples(ListSamplesRequest request) 
        {
            return new ListSamplesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSuites operation
        ///</summary>
        public IListSuitesPaginator ListSuites(ListSuitesRequest request) 
        {
            return new ListSuitesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestGridProjects operation
        ///</summary>
        public IListTestGridProjectsPaginator ListTestGridProjects(ListTestGridProjectsRequest request) 
        {
            return new ListTestGridProjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestGridSessionActions operation
        ///</summary>
        public IListTestGridSessionActionsPaginator ListTestGridSessionActions(ListTestGridSessionActionsRequest request) 
        {
            return new ListTestGridSessionActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestGridSessionArtifacts operation
        ///</summary>
        public IListTestGridSessionArtifactsPaginator ListTestGridSessionArtifacts(ListTestGridSessionArtifactsRequest request) 
        {
            return new ListTestGridSessionArtifactsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTestGridSessions operation
        ///</summary>
        public IListTestGridSessionsPaginator ListTestGridSessions(ListTestGridSessionsRequest request) 
        {
            return new ListTestGridSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTests operation
        ///</summary>
        public IListTestsPaginator ListTests(ListTestsRequest request) 
        {
            return new ListTestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUniqueProblems operation
        ///</summary>
        public IListUniqueProblemsPaginator ListUniqueProblems(ListUniqueProblemsRequest request) 
        {
            return new ListUniqueProblemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUploads operation
        ///</summary>
        public IListUploadsPaginator ListUploads(ListUploadsRequest request) 
        {
            return new ListUploadsPaginator(this.client, request);
        }
    }
}