/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticTranscoder.Model;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Implementation for accessing ElasticTranscoder
    /// 
    /// AWS Elastic Transcoder Service
    /// <para>
    /// The AWS Elastic Transcoder Service.
    /// </para>
    /// </summary>
	public partial interface IAmazonElasticTranscoder : IDisposable
    {
 
        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        /// <note>You can only cancel a job that has a status of <code>Submitted</code>.
        /// To prevent a            pipeline from starting to process a job while you're getting
        /// the job identifier, use                <a>UpdatePipelineStatus</a> to temporarily
        /// pause the pipeline.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CancelJobResponse> CancelJobAsync(CancelJobRequest cancelJobRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        /// that you specified plus information about the job that is created.
        /// 
        /// 
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the            Kindle Fire and another output for the Apple iPhone 4s), you currently
        /// must use the            Elastic Transcoder API to list the jobs (as opposed to the
        /// AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateJobResponse> CreateJobAsync(CreateJobRequest createJobRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest createPipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        /// <important>Elastic Transcoder checks the CreatePreset settings to ensure that
        /// they meet Elastic Transcoder requirements            and to determine whether they
        /// comply with H.264 standards. If your settings are not            valid for Elastic
        /// Transcoder, Elastic Transcoder returns an HTTP 400 response (<code>ValidationException</code>)
        /// and            does not create the preset. If the settings are valid for Elastic Transcoder
        /// but aren't strictly            compliant with the H.264 standard, Elastic Transcoder
        /// creates the preset and returns a warning message            in the response. This
        /// helps you determine whether your settings comply with the H.264            standard
        /// while giving you greater flexibility with respect to the video that Elastic Transcoder
        /// produces.</important>
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International            Telecommunication Union publication <i>Recommendation
        /// ITU-T H.264: Advanced video coding                for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest createPresetRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        /// 
        /// <para>
        /// You can only delete a pipeline that has never been used or that is not currently
        /// in use            (doesn't contain any active jobs). If the pipeline is currently
        /// in use,                <code>DeletePipeline</code> returns an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest deletePipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        /// <note>
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest deletePresetRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        /// 
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        /// response body contains one element for each job that satisfies the search
        /// criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest listJobsByPipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        /// response body contains one element for each job that satisfies the search
        /// criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest listJobsByStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS            account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest listPipelinesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the            presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest listPresetsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ReadJobResponse> ReadJobAsync(ReadJobRequest readJobRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest readPipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest readPresetRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        /// 
        /// <para>
        /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
        /// has sufficient permissions to let Elastic Transcoder perform tasks associated
        /// with the transcoding            process. The action attempts to assume the specified
        /// IAM role, checks read access to the            input and output buckets, and tries
        /// to send a test notification to Amazon SNS topics            that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<TestRoleResponse> TestRoleAsync(TestRoleRequest testRoleRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
        /// <important>When you change pipeline settings, your changes take effect
        /// immediately.                Jobs that you have already submitted and that Elastic
        /// Transcoder has not started to process are                affected in addition to jobs
        /// that you submit after you change settings. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest updatePipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS)            notifications for a pipeline.
        /// 
        /// 
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified            in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        /// stops or restarts the processing of jobs.
        /// 
        /// 
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't            cancel jobs after Elastic Transcoder has started processing them;
        /// if you pause the pipeline to which            you submitted the jobs, you have more
        /// time to get the job IDs for the jobs that you want            to cancel, and to send
        /// a <a>CancelJob</a> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest updatePipelineStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
