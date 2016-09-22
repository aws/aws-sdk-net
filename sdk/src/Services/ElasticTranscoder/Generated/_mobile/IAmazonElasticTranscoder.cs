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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticTranscoder.Model;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Interface for accessing ElasticTranscoder
    ///
    /// AWS Elastic Transcoder Service 
    /// <para>
    /// The AWS Elastic Transcoder Service.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticTranscoder : IAmazonService, IDisposable
    {
                
        #region  CancelJob


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePipeline


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePreset


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePipeline


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePreset


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobsByPipeline


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobsByStatus


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelines


        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPresets


        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        Task<ListPresetsResponse> ListPresetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReadJob


        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReadJobResponse> ReadJobAsync(ReadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReadPipeline


        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReadPreset


        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestRole


        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestRoleResponse> TestRoleAsync(TestRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipeline


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipelineNotifications


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipelineStatus


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}