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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Paginators for the DeviceFarm service
    /// </summary>
    public interface IDeviceFarmPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetOfferingStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IGetOfferingStatusPaginator GetOfferingStatus(GetOfferingStatusRequest request);

        /// <summary>
        /// Paginator for ListArtifacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListArtifactsPaginator ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Paginator for ListDevicePools operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDevicePoolsPaginator ListDevicePools(ListDevicePoolsRequest request);

        /// <summary>
        /// Paginator for ListDevices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListDevicesPaginator ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListOfferingTransactions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListOfferingTransactionsPaginator ListOfferingTransactions(ListOfferingTransactionsRequest request);

        /// <summary>
        /// Paginator for ListOfferings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListOfferingsPaginator ListOfferings(ListOfferingsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListProjectsPaginator ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Paginator for ListRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListRunsPaginator ListRuns(ListRunsRequest request);

        /// <summary>
        /// Paginator for ListSamples operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListSamplesPaginator ListSamples(ListSamplesRequest request);

        /// <summary>
        /// Paginator for ListSuites operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListSuitesPaginator ListSuites(ListSuitesRequest request);

        /// <summary>
        /// Paginator for ListTestGridProjects operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResult", OutputToken = ["NextToken"])]
        IListTestGridProjectsPaginator ListTestGridProjects(ListTestGridProjectsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessionActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResult", OutputToken = ["NextToken"])]
        IListTestGridSessionActionsPaginator ListTestGridSessionActions(ListTestGridSessionActionsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessionArtifacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResult", OutputToken = ["NextToken"])]
        IListTestGridSessionArtifactsPaginator ListTestGridSessionArtifacts(ListTestGridSessionArtifactsRequest request);

        /// <summary>
        /// Paginator for ListTestGridSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResult", OutputToken = ["NextToken"])]
        IListTestGridSessionsPaginator ListTestGridSessions(ListTestGridSessionsRequest request);

        /// <summary>
        /// Paginator for ListTests operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListTestsPaginator ListTests(ListTestsRequest request);

        /// <summary>
        /// Paginator for ListUniqueProblems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListUniqueProblemsPaginator ListUniqueProblems(ListUniqueProblemsRequest request);

        /// <summary>
        /// Paginator for ListUploads operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListUploadsPaginator ListUploads(ListUploadsRequest request);
    }
}
