/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.XRay.Model;

namespace Amazon.XRay
{
    /// <summary>
    /// Interface for accessing XRay
    ///
    /// AWS X-Ray provides APIs for managing debug traces and retrieving service maps and
    /// other data created by processing those traces.
    /// </summary>
    public partial interface IAmazonXRay : IAmazonService, IDisposable
    {
                
        #region  BatchGetTraces


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<BatchGetTracesResponse> BatchGetTracesAsync(BatchGetTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSamplingRule


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSamplingRuleResponse> CreateSamplingRuleAsync(CreateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSamplingRule


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSamplingRuleResponse> DeleteSamplingRuleAsync(DeleteSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetEncryptionConfigResponse> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroups


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingRules


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSamplingRulesResponse> GetSamplingRulesAsync(GetSamplingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingStatisticSummaries


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSamplingStatisticSummariesResponse> GetSamplingStatisticSummariesAsync(GetSamplingStatisticSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingTargets


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSamplingTargetsResponse> GetSamplingTargetsAsync(GetSamplingTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceGraph


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetServiceGraphResponse> GetServiceGraphAsync(GetServiceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTraceGraph


        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTraceGraphResponse> GetTraceGraphAsync(GetTraceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTraceSummaries


        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTraceSummariesResponse> GetTraceSummariesAsync(GetTraceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutEncryptionConfigResponse> PutEncryptionConfigAsync(PutEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTelemetryRecords


        /// <summary>
        /// Initiates the asynchronous execution of the PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutTelemetryRecordsResponse> PutTelemetryRecordsAsync(PutTelemetryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTraceSegments


        /// <summary>
        /// Initiates the asynchronous execution of the PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutTraceSegmentsResponse> PutTraceSegmentsAsync(PutTraceSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSamplingRule


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateSamplingRuleResponse> UpdateSamplingRuleAsync(UpdateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}