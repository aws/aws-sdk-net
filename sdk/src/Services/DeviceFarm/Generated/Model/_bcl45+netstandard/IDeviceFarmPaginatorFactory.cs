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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Paginators for the DeviceFarm service
    ///</summary>
    public interface IDeviceFarmPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetOfferingStatus operation
        ///</summary>
        IGetOfferingStatusPaginator GetOfferingStatus(GetOfferingStatusRequest request);

        /// <summary>
        /// Paginator for ListArtifacts operation
        ///</summary>
        IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Paginator for ListDevicePools operation
        ///</summary>
        IListDevicePoolsPaginator ListDevicePools(ListDevicePoolsRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        ///</summary>
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListOfferings operation
        ///</summary>
        IListOfferingsPaginator ListOfferings(ListOfferingsRequest request);

        /// <summary>
        /// Paginator for ListOfferingTransactions operation
        ///</summary>
        IListOfferingTransactionsPaginator ListOfferingTransactions(ListOfferingTransactionsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListRuns operation
        ///</summary>
        IListRunsPaginator ListRuns(ListRunsRequest request);

        /// <summary>
        /// Paginator for ListSamples operation
        ///</summary>
        IListSamplesPaginator ListSamples(ListSamplesRequest request);

        /// <summary>
        /// Paginator for ListSuites operation
        ///</summary>
        IListSuitesPaginator ListSuites(ListSuitesRequest request);

        /// <summary>
        /// Paginator for ListTestGridProjects operation
        ///</summary>
        IListTestGridProjectsPaginator ListTestGridProjects(ListTestGridProjectsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessionActions operation
        ///</summary>
        IListTestGridSessionActionsPaginator ListTestGridSessionActions(ListTestGridSessionActionsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessionArtifacts operation
        ///</summary>
        IListTestGridSessionArtifactsPaginator ListTestGridSessionArtifacts(ListTestGridSessionArtifactsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessions operation
        ///</summary>
        IListTestGridSessionsPaginator ListTestGridSessions(ListTestGridSessionsRequest request);

        /// <summary>
        /// Paginator for ListTests operation
        ///</summary>
        IListTestsPaginator ListTests(ListTestsRequest request);

        /// <summary>
        /// Paginator for ListUniqueProblems operation
        ///</summary>
        IListUniqueProblemsPaginator ListUniqueProblems(ListUniqueProblemsRequest request);

        /// <summary>
        /// Paginator for ListUploads operation
        ///</summary>
        IListUploadsPaginator ListUploads(ListUploadsRequest request);
    }
}
#endif