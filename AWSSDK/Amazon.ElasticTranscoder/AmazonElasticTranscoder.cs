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

using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Interface for accessing AmazonElasticTranscoder.
    ///  
    ///  AWS Elastic Transcoder Service <para>The AWS Elastic Transcoder Service.</para>
    /// </summary>
    public interface AmazonElasticTranscoder : IDisposable
    {
        

        #region DeletePipeline

        /// <summary>
        /// <para>To delete a pipeline, send a DELETE request to the <c>/2012-09-25/pipelines/[pipelineId] </c> resource. </para> <para> You can only
        /// delete a pipeline that has never been used or that is not currently in use (doesn't contain any active jobs). If the pipeline is currently
        /// in use, <c>DeletePipeline</c> returns an error. </para>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest deletePipelineRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest deletePipelineRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a DeletePipelineResult from AmazonElasticTranscoder.</returns>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelJob

        /// <summary>
        /// <para>To delete a job, send a DELETE request to the <c>/2012-09-25/jobs/[jobId] </c> resource.</para> <para><b>NOTE:</b>You can only cancel
        /// a job that has a status of Submitted. To prevent a pipeline from starting to process a job while you're getting the job identifier, use
        /// UpdatePipelineStatus to temporarily pause the pipeline.</para>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        CancelJobResponse CancelJob(CancelJobRequest cancelJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        IAsyncResult BeginCancelJob(CancelJobRequest cancelJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a CancelJobResult from AmazonElasticTranscoder.</returns>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListPresets

        /// <summary>
        /// <para>To get a list of all presets associated with the current AWS account, send a GET request to the <c>/2012-09-25/presets</c>
        /// resource.</para>
        /// </summary>
        /// 
        /// <param name="listPresetsRequest">Container for the necessary parameters to execute the ListPresets service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListPresetsResponse ListPresets(ListPresetsRequest listPresetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPresets"/>
        /// </summary>
        /// 
        /// <param name="listPresetsRequest">Container for the necessary parameters to execute the ListPresets operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        IAsyncResult BeginListPresets(ListPresetsRequest listPresetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPresets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a ListPresetsResult from AmazonElasticTranscoder.</returns>
        ListPresetsResponse EndListPresets(IAsyncResult asyncResult);

        /// <summary>
        /// <para>To get a list of all presets associated with the current AWS account, send a GET request to the <c>/2012-09-25/presets</c>
        /// resource.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListPresetsResponse ListPresets();
        
        #endregion
        
    

        #region ListJobsByStatus

        /// <summary>
        /// <para>To get a list of the jobs that have a specified status, send a GET request to the <c>/2012-09-25/jobsByStatus/[status] </c> resource.
        /// </para> <para>Elastic Transcoder returns all of the jobs that have the specified status. The response body contains one element for each job
        /// that satisfies the search criteria. </para>
        /// </summary>
        /// 
        /// <param name="listJobsByStatusRequest">Container for the necessary parameters to execute the ListJobsByStatus service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest listJobsByStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByStatus"/>
        /// </summary>
        /// 
        /// <param name="listJobsByStatusRequest">Container for the necessary parameters to execute the ListJobsByStatus operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByStatus
        ///         operation.</returns>
        IAsyncResult BeginListJobsByStatus(ListJobsByStatusRequest listJobsByStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByStatus.</param>
        /// 
        /// <returns>Returns a ListJobsByStatusResult from AmazonElasticTranscoder.</returns>
        ListJobsByStatusResponse EndListJobsByStatus(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePipeline

        /// <summary>
        /// <para>To create a pipeline, send a POST request to the <c>2012-09-25/pipelines</c> resource.</para>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="ValidationException"/>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest createPipelineRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest createPipelineRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a CreatePipelineResult from AmazonElasticTranscoder.</returns>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region TestRole

        /// <summary>
        /// <para> To test the IAM role that's used by Elastic Transcoder to create the pipeline, send a POST request to the
        /// <c>/2012-09-25/roleTests</c> resource. </para> <para>The <c>TestRole</c> action lets you determine whether the IAM role you are using has
        /// sufficient permissions to let Elastic Transcoder perform tasks associated with the transcoding process. The action attempts to assume the
        /// specified IAM role, checks read access to the input and output buckets, and tries to send a test notification to Amazon SNS topics that you
        /// specify.</para>
        /// </summary>
        /// 
        /// <param name="testRoleRequest">Container for the necessary parameters to execute the TestRole service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        TestRoleResponse TestRole(TestRoleRequest testRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.TestRole"/>
        /// </summary>
        /// 
        /// <param name="testRoleRequest">Container for the necessary parameters to execute the TestRole operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRole
        ///         operation.</returns>
        IAsyncResult BeginTestRole(TestRoleRequest testRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.TestRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRole.</param>
        /// 
        /// <returns>Returns a TestRoleResult from AmazonElasticTranscoder.</returns>
        TestRoleResponse EndTestRole(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListPipelines

        /// <summary>
        /// <para>To get a list of the pipelines associated with the current AWS account, send a GET request to the <c>/2012-09-25/pipelines</c>
        /// resource.</para>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest listPipelinesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        IAsyncResult BeginListPipelines(ListPipelinesRequest listPipelinesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a ListPipelinesResult from AmazonElasticTranscoder.</returns>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        /// <summary>
        /// <para>To get a list of the pipelines associated with the current AWS account, send a GET request to the <c>/2012-09-25/pipelines</c>
        /// resource.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListPipelinesResponse ListPipelines();
        
        #endregion
        
    

        #region UpdatePipelineNotifications

        /// <summary>
        /// <para>To update Amazon Simple Notification Service (Amazon SNS) notifications for a pipeline, send a POST request to the
        /// <c>/2012-09-25/pipelines/[pipelineId]/notifications</c> resource.</para> <para>When you update notifications for a pipeline, Elastic
        /// Transcoder returns the values that you specified in the request.</para>
        /// </summary>
        /// 
        /// <param name="updatePipelineNotificationsRequest">Container for the necessary parameters to execute the UpdatePipelineNotifications service
        ///          method on AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineNotifications"/>
        /// </summary>
        /// 
        /// <param name="updatePipelineNotificationsRequest">Container for the necessary parameters to execute the UpdatePipelineNotifications operation
        ///          on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdatePipelineNotifications operation.</returns>
        IAsyncResult BeginUpdatePipelineNotifications(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineNotifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineNotifications.</param>
        /// 
        /// <returns>Returns a UpdatePipelineNotificationsResult from AmazonElasticTranscoder.</returns>
        UpdatePipelineNotificationsResponse EndUpdatePipelineNotifications(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListJobsByPipeline

        /// <summary>
        /// <para>To get a list of the jobs currently in a pipeline, send a GET request to the <c>/2012-09-25/jobsByPipeline/[pipelineId] </c>
        /// resource.</para> <para>Elastic Transcoder returns all of the jobs currently in the specified pipeline. The response body contains one
        /// element for each job that satisfies the search criteria.</para>
        /// </summary>
        /// 
        /// <param name="listJobsByPipelineRequest">Container for the necessary parameters to execute the ListJobsByPipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest listJobsByPipelineRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByPipeline"/>
        /// </summary>
        /// 
        /// <param name="listJobsByPipelineRequest">Container for the necessary parameters to execute the ListJobsByPipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListJobsByPipeline operation.</returns>
        IAsyncResult BeginListJobsByPipeline(ListJobsByPipelineRequest listJobsByPipelineRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByPipeline.</param>
        /// 
        /// <returns>Returns a ListJobsByPipelineResult from AmazonElasticTranscoder.</returns>
        ListJobsByPipelineResponse EndListJobsByPipeline(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateJob

        /// <summary>
        /// <para>To create a job, send a POST request to the <c>/2012-09-25/jobs</c> resource.</para> <para> When you create a job, Elastic Transcoder
        /// returns JSON data that includes the values that you specified plus information about the job that is created. </para>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="ValidationException"/>
        CreateJobResponse CreateJob(CreateJobRequest createJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        IAsyncResult BeginCreateJob(CreateJobRequest createJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a CreateJobResult from AmazonElasticTranscoder.</returns>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdatePipelineStatus

        /// <summary>
        /// <para> To pause or reactivate a pipeline, so the pipeline stops or restarts processing jobs, update the status for the pipeline. Send a POST
        /// request to the <c>/2012-09-25/pipelines/[pipelineId]/status</c> resource. </para> <para> Changing the pipeline status is useful if you want
        /// to cancel one or more jobs. You can't cancel jobs after Elastic Transcoder has started processing them; if you pause the pipeline to which
        /// you submitted the jobs, you have more time to get the job IDs for the jobs that you want to cancel, and to send a CancelJob request. </para>
        /// </summary>
        /// 
        /// <param name="updatePipelineStatusRequest">Container for the necessary parameters to execute the UpdatePipelineStatus service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest updatePipelineStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineStatus"/>
        /// </summary>
        /// 
        /// <param name="updatePipelineStatusRequest">Container for the necessary parameters to execute the UpdatePipelineStatus operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdatePipelineStatus operation.</returns>
        IAsyncResult BeginUpdatePipelineStatus(UpdatePipelineStatusRequest updatePipelineStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineStatus.</param>
        /// 
        /// <returns>Returns a UpdatePipelineStatusResult from AmazonElasticTranscoder.</returns>
        UpdatePipelineStatusResponse EndUpdatePipelineStatus(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReadPipeline

        /// <summary>
        /// <para>To get detailed information about a pipeline, send a GET request to the <c>/2012-09-25/pipelines/[pipelineId] </c> resource.</para>
        /// </summary>
        /// 
        /// <param name="readPipelineRequest">Container for the necessary parameters to execute the ReadPipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ReadPipelineResponse ReadPipeline(ReadPipelineRequest readPipelineRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPipeline"/>
        /// </summary>
        /// 
        /// <param name="readPipelineRequest">Container for the necessary parameters to execute the ReadPipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPipeline
        ///         operation.</returns>
        IAsyncResult BeginReadPipeline(ReadPipelineRequest readPipelineRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPipeline.</param>
        /// 
        /// <returns>Returns a ReadPipelineResult from AmazonElasticTranscoder.</returns>
        ReadPipelineResponse EndReadPipeline(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReadJob

        /// <summary>
        /// <para> To get detailed information about a job, send a GET request to the <c>/2012-09-25/jobs/[jobId] </c> resource. </para>
        /// </summary>
        /// 
        /// <param name="readJobRequest">Container for the necessary parameters to execute the ReadJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ReadJobResponse ReadJob(ReadJobRequest readJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadJob"/>
        /// </summary>
        /// 
        /// <param name="readJobRequest">Container for the necessary parameters to execute the ReadJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadJob
        ///         operation.</returns>
        IAsyncResult BeginReadJob(ReadJobRequest readJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadJob.</param>
        /// 
        /// <returns>Returns a ReadJobResult from AmazonElasticTranscoder.</returns>
        ReadJobResponse EndReadJob(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeletePreset

        /// <summary>
        /// <para>To delete a preset, send a DELETE request to the <c>/2012-09-25/presets/[presetId] </c> resource.</para> <para><b>NOTE:</b> If the
        /// preset has been used, you cannot delete it. </para>
        /// </summary>
        /// 
        /// <param name="deletePresetRequest">Container for the necessary parameters to execute the DeletePreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        DeletePresetResponse DeletePreset(DeletePresetRequest deletePresetRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePreset"/>
        /// </summary>
        /// 
        /// <param name="deletePresetRequest">Container for the necessary parameters to execute the DeletePreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        IAsyncResult BeginDeletePreset(DeletePresetRequest deletePresetRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a DeletePresetResult from AmazonElasticTranscoder.</returns>
        DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePreset

        /// <summary>
        /// <para>To create a preset, send a POST request to the <c>/2012-09-25/presets</c> resource.</para> <para><b>IMPORTANT:</b>Elastic Transcoder
        /// checks the settings that you specify to ensure that they meet Elastic Transcoder requirements and to determine whether they comply with
        /// H.264 standards. If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns an HTTP 400 response
        /// (ValidationException) and does not create the preset. If the settings are valid for Elastic Transcoder but aren't strictly compliant with
        /// the H.264 standard, Elastic Transcoder creates the preset and returns a warning message in the response. This helps you determine whether
        /// your settings comply with the H.264 standard while giving you greater flexibility with respect to the video that Elastic Transcoder
        /// produces.</para> <para>Elastic Transcoder uses the H.264 video-compression format. For more information, see the International
        /// Telecommunication Union publication <i>Recommendation ITU-T H.264: Advanced video coding for generic audiovisual services</i> .</para>
        /// </summary>
        /// 
        /// <param name="createPresetRequest">Container for the necessary parameters to execute the CreatePreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        CreatePresetResponse CreatePreset(CreatePresetRequest createPresetRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePreset"/>
        /// </summary>
        /// 
        /// <param name="createPresetRequest">Container for the necessary parameters to execute the CreatePreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        IAsyncResult BeginCreatePreset(CreatePresetRequest createPresetRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a CreatePresetResult from AmazonElasticTranscoder.</returns>
        CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReadPreset

        /// <summary>
        /// <para>To get detailed information about a preset, send a GET request to the <c>/2012-09-25/presets/[presetId] </c> resource.</para>
        /// </summary>
        /// 
        /// <param name="readPresetRequest">Container for the necessary parameters to execute the ReadPreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        ReadPresetResponse ReadPreset(ReadPresetRequest readPresetRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPreset"/>
        /// </summary>
        /// 
        /// <param name="readPresetRequest">Container for the necessary parameters to execute the ReadPreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPreset
        ///         operation.</returns>
        IAsyncResult BeginReadPreset(ReadPresetRequest readPresetRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPreset.</param>
        /// 
        /// <returns>Returns a ReadPresetResult from AmazonElasticTranscoder.</returns>
        ReadPresetResponse EndReadPreset(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
