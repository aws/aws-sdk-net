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
using System.Collections.Generic;

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
    public partial interface IAmazonElasticTranscoder : IDisposable
    {

        
        #region  CancelJob


        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///  <note>You can only cancel a job that has a status of <code>Submitted</code>. To prevent
        /// a pipeline from starting to process a job while you're getting the job identifier,
        /// use <a>UpdatePipelineStatus</a> to temporarily pause the pipeline.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        CancelJobResponse CancelJob(CancelJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from ElasticTranscoder.</returns>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        /// that you specified plus information about the job that is created. 
        /// 
        ///  
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the Kindle Fire and another output for the Apple iPhone 4s), you currently must
        /// use the Elastic Transcoder API to list the jobs (as opposed to the AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from ElasticTranscoder.</returns>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from ElasticTranscoder.</returns>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePreset


        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///  <important>Elastic Transcoder checks the CreatePreset settings to ensure that they
        /// meet Elastic Transcoder requirements and to determine whether they comply with H.264
        /// standards. If your settings are not valid for Elastic Transcoder, Elastic Transcoder
        /// returns an HTTP 400 response (<code>ValidationException</code>) and does not create
        /// the preset. If the settings are valid for Elastic Transcoder but aren't strictly compliant
        /// with the H.264 standard, Elastic Transcoder creates the preset and returns a warning
        /// message in the response. This helps you determine whether your settings comply with
        /// the H.264 standard while giving you greater flexibility with respect to the video
        /// that Elastic Transcoder produces.</important> 
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International Telecommunication Union publication <i>Recommendation ITU-T
        /// H.264: Advanced video coding for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        CreatePresetResponse CreatePreset(CreatePresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        IAsyncResult BeginCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a  CreatePresetResult from ElasticTranscoder.</returns>
        CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///  
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use (doesn't contain any active jobs). If the pipeline is currently in use, <code>DeletePipeline</code>
        /// returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from ElasticTranscoder.</returns>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePreset


        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        DeletePresetResponse DeletePreset(DeletePresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        IAsyncResult BeginDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a  DeletePresetResult from ElasticTranscoder.</returns>
        DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobsByPipeline


        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///  
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByPipeline
        ///         operation.</returns>
        IAsyncResult BeginListJobsByPipeline(ListJobsByPipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByPipeline.</param>
        /// 
        /// <returns>Returns a  ListJobsByPipelineResult from ElasticTranscoder.</returns>
        ListJobsByPipelineResponse EndListJobsByPipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobsByStatus


        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByStatus
        ///         operation.</returns>
        IAsyncResult BeginListJobsByStatus(ListJobsByStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByStatus.</param>
        /// 
        /// <returns>Returns a  ListJobsByStatusResult from ElasticTranscoder.</returns>
        ListJobsByStatusResponse EndListJobsByStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
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
        ListPipelinesResponse ListPipelines();

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
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
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from ElasticTranscoder.</returns>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPresets


        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
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
        ListPresetsResponse ListPresets();

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
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
        ListPresetsResponse ListPresets(ListPresetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        IAsyncResult BeginListPresets(ListPresetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPresets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a  ListPresetsResult from ElasticTranscoder.</returns>
        ListPresetsResponse EndListPresets(IAsyncResult asyncResult);

        #endregion
        
        #region  ReadJob


        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        ReadJobResponse ReadJob(ReadJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadJob
        ///         operation.</returns>
        IAsyncResult BeginReadJob(ReadJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadJob.</param>
        /// 
        /// <returns>Returns a  ReadJobResult from ElasticTranscoder.</returns>
        ReadJobResponse EndReadJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ReadPipeline


        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        ReadPipelineResponse ReadPipeline(ReadPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPipeline
        ///         operation.</returns>
        IAsyncResult BeginReadPipeline(ReadPipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPipeline.</param>
        /// 
        /// <returns>Returns a  ReadPipelineResult from ElasticTranscoder.</returns>
        ReadPipelineResponse EndReadPipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  ReadPreset


        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        ReadPresetResponse ReadPreset(ReadPresetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPreset
        ///         operation.</returns>
        IAsyncResult BeginReadPreset(ReadPresetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPreset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPreset.</param>
        /// 
        /// <returns>Returns a  ReadPresetResult from ElasticTranscoder.</returns>
        ReadPresetResponse EndReadPreset(IAsyncResult asyncResult);

        #endregion
        
        #region  TestRole


        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///  
        /// <para>
        /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
        /// has sufficient permissions to let Elastic Transcoder perform tasks associated with
        /// the transcoding process. The action attempts to assume the specified IAM role, checks
        /// read access to the input and output buckets, and tries to send a test notification
        /// to Amazon SNS topics that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        TestRoleResponse TestRole(TestRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRole
        ///         operation.</returns>
        IAsyncResult BeginTestRole(TestRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRole.</param>
        /// 
        /// <returns>Returns a  TestRoleResult from ElasticTranscoder.</returns>
        TestRoleResponse EndTestRole(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
        /// <important>When you change pipeline settings, your changes take effect immediately.
        /// Jobs that you have already submitted and that Elastic Transcoder has not started to
        /// process are affected in addition to jobs that you submit after you change settings.
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from ElasticTranscoder.</returns>
        UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipelineNotifications


        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS) notifications for a pipeline.
        /// 
        ///  
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineNotifications
        ///         operation.</returns>
        IAsyncResult BeginUpdatePipelineNotifications(UpdatePipelineNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineNotifications.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineNotificationsResult from ElasticTranscoder.</returns>
        UpdatePipelineNotificationsResponse EndUpdatePipelineNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipelineStatus


        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        /// stops or restarts the processing of jobs.
        /// 
        ///  
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't cancel jobs after Elastic Transcoder has started processing them; if you pause
        /// the pipeline to which you submitted the jobs, you have more time to get the job IDs
        /// for the jobs that you want to cancel, and to send a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
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
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineStatus
        ///         operation.</returns>
        IAsyncResult BeginUpdatePipelineStatus(UpdatePipelineStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineStatusResult from ElasticTranscoder.</returns>
        UpdatePipelineStatusResponse EndUpdatePipelineStatus(IAsyncResult asyncResult);

        #endregion
        
    }
}