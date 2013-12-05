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
    /// Interface for accessing AmazonElasticTranscoder.
    /// 
    /// AWS Elastic Transcoder Service <para>The AWS Elastic Transcoder Service.</para>
    /// </summary>
	public partial interface IAmazonElasticTranscoder : IDisposable
    {
 

        /// <summary>
        /// <para>The CancelJob operation cancels an unfinished job.</para> <para><b>NOTE:</b>You can only cancel a job that has a status of Submitted.
        /// To prevent a pipeline from starting to process a job while you're getting the job identifier, use UpdatePipelineStatus to temporarily pause
        /// the pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		CancelJobResponse CancelJob(CancelJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> When you create a job, Elastic Transcoder returns JSON data that includes the values that you specified plus information about the
        /// job that is created. </para> <para>If you have specified more than one output for your jobs (for example, one output for the Kindle Fire and
        /// another output for the Apple iPhone 4s), you currently must use the Elastic Transcoder API to list the jobs (as opposed to the AWS
        /// Console).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The CreatePipeline operation creates a pipeline with settings that you specify.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The CreatePreset operation creates a preset with settings that you specify.</para> <para><b>IMPORTANT:</b>Elastic Transcoder checks
        /// the CreatePreset settings to ensure that they meet Elastic Transcoder requirements and to determine whether they comply with H.264
        /// standards. If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns an HTTP 400 response (ValidationException) and
        /// does not create the preset. If the settings are valid for Elastic Transcoder but aren't strictly compliant with the H.264 standard, Elastic
        /// Transcoder creates the preset and returns a warning message in the response. This helps you determine whether your settings comply with the
        /// H.264 standard while giving you greater flexibility with respect to the video that Elastic Transcoder produces.</para> <para>Elastic
        /// Transcoder uses the H.264 video-compression format. For more information, see the International Telecommunication Union publication
        /// <i>Recommendation ITU-T H.264: Advanced video coding for generic audiovisual services</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		CreatePresetResponse CreatePreset(CreatePresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.CreatePreset"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The DeletePipeline operation removes a pipeline.</para> <para> You can only delete a pipeline that has never been used or that is not
        /// currently in use (doesn't contain any active jobs). If the pipeline is currently in use, <c>DeletePipeline</c> returns an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The DeletePreset operation removes a preset that you've added in an AWS region.</para> <para><b>NOTE:</b> You can't delete the default
        /// presets that are included with Elastic Transcoder. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		DeletePresetResponse DeletePreset(DeletePresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.DeletePreset"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.</para> <para>Elastic Transcoder returns all of the
        /// jobs currently in the specified pipeline. The response body contains one element for each job that satisfies the search criteria.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ListJobsByPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The ListJobsByStatus operation gets a list of jobs that have a specified status. The response body contains one element for each job
        /// that satisfies the search criteria.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ListJobsByStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The ListPipelines operation gets a list of the pipelines associated with the current AWS account.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The ListPipelines operation gets a list of the pipelines associated with the current AWS account.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListPipelinesResponse ListPipelines();
 

        /// <summary>
        /// <para>The ListPresets operation gets a list of the default presets included with Elastic Transcoder and the presets that you've added in an
        /// AWS region.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListPresetsResponse ListPresets(ListPresetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ListPresets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The ListPresets operation gets a list of the default presets included with Elastic Transcoder and the presets that you've added in an
        /// AWS region.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ListPresetsResponse ListPresets();
 

        /// <summary>
        /// <para>The ReadJob operation returns detailed information about a job.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ReadJobResponse ReadJob(ReadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ReadJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReadJobResponse> ReadJobAsync(ReadJobRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The ReadPipeline operation gets detailed information about a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ReadPipelineResponse ReadPipeline(ReadPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ReadPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The ReadPreset operation gets detailed information about a preset.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		ReadPresetResponse ReadPreset(ReadPresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.ReadPreset"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The TestRole operation tests the IAM role used to create the pipeline.</para> <para>The <c>TestRole</c> action lets you determine
        /// whether the IAM role you are using has sufficient permissions to let Elastic Transcoder perform tasks associated with the transcoding
        /// process. The action attempts to assume the specified IAM role, checks read access to the input and output buckets, and tries to send a test
        /// notification to Amazon SNS topics that you specify.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		TestRoleResponse TestRole(TestRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.TestRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<TestRoleResponse> TestRoleAsync(TestRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Use the <c>UpdatePipeline</c> operation to update settings for a pipeline. <para><b>IMPORTANT:</b>When you change pipeline settings,
        /// your changes take effect immediately. Jobs that you have already submitted and that Elastic Transcoder has not started to process are
        /// affected in addition to jobs that you submit after you change settings. </para> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.UpdatePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification Service (Amazon SNS) notifications for a
        /// pipeline.</para> <para>When you update notifications for a pipeline, Elastic Transcoder returns the values that you specified in the
        /// request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service
        /// method on AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.UpdatePipelineNotifications"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline stops or restarts the processing of
        /// jobs.</para> <para>Changing the pipeline status is useful if you want to cancel one or more jobs. You can't cancel jobs after Elastic
        /// Transcoder has started processing them; if you pause the pipeline to which you submitted the jobs, you have more time to get the job IDs for
        /// the jobs that you want to cancel, and to send a CancelJob request. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
		UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder.UpdatePipelineStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
