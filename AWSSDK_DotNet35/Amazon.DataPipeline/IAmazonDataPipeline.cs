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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DataPipeline.Model;

namespace Amazon.DataPipeline
{
    /// <summary>
    /// Interface for accessing DataPipeline
    ///
    /// AWS Data Pipeline is a web service that configures and manages a data-driven workflow
    /// called a pipeline. AWS Data Pipeline handles the details of scheduling and ensuring
    /// that data dependencies are met so your application can focus on processing the data.
    /// 
    ///  
    /// <para>
    ///  The AWS Data Pipeline SDKs and CLI implements two main sets of functionality. The
    /// first set of actions configure the pipeline in the web service. You perform these
    /// actions to create a pipeline and define data sources, schedules, dependencies, and
    /// the transforms to be performed on the data. 
    /// </para>
    ///  
    /// <para>
    ///  The second set of actions are used by a task runner application that calls the AWS
    /// Data Pipeline API to receive the next task ready for processing. The logic for performing
    /// the task, such as querying the data, running data analysis, or converting the data
    /// from one format to another, is contained within the task runner. The task runner performs
    /// the task assigned to it by the web service, reporting progress to the web service
    /// as it does so. When the task is done, the task runner reports the final success or
    /// failure of the task to the web service. 
    /// </para>
    ///  
    /// <para>
    ///  AWS Data Pipeline provides a JAR implementation of a task runner called AWS Data
    /// Pipeline Task Runner. AWS Data Pipeline Task Runner provides logic for common data
    /// management scenarios, such as performing database queries and running data analysis
    /// using Amazon Elastic MapReduce (Amazon EMR). You can use AWS Data Pipeline Task Runner
    /// as your task runner, or you can write your own task runner to provide custom data
    /// management. 
    /// </para>
    /// </summary>
    public partial interface IAmazonDataPipeline : IDisposable
    {

        
        #region  ActivatePipeline

        /// <summary>
        /// Validates a pipeline and initiates processing. If the pipeline does not pass validation,
        /// activation fails. You cannot perform this operation on FINISHED pipelines and attempting
        /// to do so will return an InvalidRequestException. 
        /// 
        ///  
        /// <para>
        ///  Call this action to start processing pipeline tasks of a pipeline you've created
        /// using the <a>CreatePipeline</a> and <a>PutPipelineDefinition</a> actions. A pipeline
        /// cannot be modified after it has been successfully activated. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline service method.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        ActivatePipelineResponse ActivatePipeline(ActivatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivatePipeline
        ///         operation.</returns>
        IAsyncResult BeginActivatePipeline(ActivatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivatePipeline.</param>
        /// 
        /// <returns>Returns a  ActivatePipelineResult from DataPipeline.</returns>
        ActivatePipelineResponse EndActivatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePipeline

        /// <summary>
        /// Creates a new empty pipeline. When this action succeeds, you can then use the <a>PutPipelineDefinition</a>
        /// action to populate the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from DataPipeline.</returns>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipeline

        /// <summary>
        /// Permanently deletes a pipeline, its pipeline definition and its run history. You
        /// cannot query or restore a deleted pipeline. AWS Data Pipeline will attempt to cancel
        /// instances associated with the pipeline that are currently being processed by task
        /// runners. Deleting a pipeline cannot be undone. 
        /// 
        ///  
        /// <para>
        ///  To temporarily pause a pipeline instead of deleting it, call <a>SetStatus</a> with
        /// the status set to Pause on individual components. Components that are paused by <a>SetStatus</a>
        /// can be resumed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from DataPipeline.</returns>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeObjects

        /// <summary>
        /// Returns the object definitions for a set of objects associated with the pipeline.
        /// Object definitions are composed of a set of fields that define the properties of the
        /// object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects service method.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeObjects
        ///         operation.</returns>
        IAsyncResult BeginDescribeObjects(DescribeObjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeObjects.</param>
        /// 
        /// <returns>Returns a  DescribeObjectsResult from DataPipeline.</returns>
        DescribeObjectsResponse EndDescribeObjects(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipelines

        /// <summary>
        /// Retrieve metadata about one or more pipelines. The information retrieved includes
        /// the name of the pipeline, the pipeline identifier, its current state, and the user
        /// account that owns the pipeline. Using account credentials, you can retrieve metadata
        /// about pipelines that you or your IAM users have created. If you are using an IAM user
        /// account, you can retrieve metadata about only those pipelines you have read permission
        /// for. 
        /// 
        ///  
        /// <para>
        ///  To retrieve the full pipeline definition instead of metadata about the pipeline,
        /// call the <a>GetPipelineDefinition</a> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines service method.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipelines
        ///         operation.</returns>
        IAsyncResult BeginDescribePipelines(DescribePipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipelines.</param>
        /// 
        /// <returns>Returns a  DescribePipelinesResult from DataPipeline.</returns>
        DescribePipelinesResponse EndDescribePipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  EvaluateExpression

        /// <summary>
        /// Evaluates a string in the context of a specified object. A task runner can use this
        /// action to evaluate SQL queries stored in Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression service method.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluateExpression
        ///         operation.</returns>
        IAsyncResult BeginEvaluateExpression(EvaluateExpressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateExpression.</param>
        /// 
        /// <returns>Returns a  EvaluateExpressionResult from DataPipeline.</returns>
        EvaluateExpressionResponse EndEvaluateExpression(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPipelineDefinition

        /// <summary>
        /// Returns the definition of the specified pipeline. You can call <a>GetPipelineDefinition</a>
        /// to retrieve the pipeline definition you provided using <a>PutPipelineDefinition</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineDefinition
        ///         operation.</returns>
        IAsyncResult BeginGetPipelineDefinition(GetPipelineDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineDefinition.</param>
        /// 
        /// <returns>Returns a  GetPipelineDefinitionResult from DataPipeline.</returns>
        GetPipelineDefinitionResponse EndGetPipelineDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelines

        /// <summary>
        /// Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned
        /// only for pipelines you have permission to access.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ListPipelinesResponse ListPipelines();

        /// <summary>
        /// Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned
        /// only for pipelines you have permission to access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from DataPipeline.</returns>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  PollForTask

        /// <summary>
        /// Task runners call this action to receive a task to perform from AWS Data Pipeline.
        /// The task runner specifies which tasks it can perform by setting a value for the workerGroup
        /// parameter of the <a>PollForTask</a> call. The task returned by <a>PollForTask</a>
        /// may come from any of the pipelines that match the workerGroup value passed in by the
        /// task runner and that was launched using the IAM user credentials specified by the
        /// task runner. 
        /// 
        ///  
        /// <para>
        ///  If tasks are ready in the work queue, <a>PollForTask</a> returns a response immediately.
        /// If no tasks are available in the queue, <a>PollForTask</a> uses long-polling and holds
        /// on to a poll connection for up to a 90 seconds during which time the first newly scheduled
        /// task is handed to the task runner. To accomodate this, set the socket timeout in your
        /// task runner to 90 seconds. The task runner should not call <a>PollForTask</a> again
        /// on the same <code>workerGroup</code> until it receives a response, and this may take
        /// up to 90 seconds. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForTask service method.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        PollForTaskResponse PollForTask(PollForTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForTask
        ///         operation.</returns>
        IAsyncResult BeginPollForTask(PollForTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForTask.</param>
        /// 
        /// <returns>Returns a  PollForTaskResult from DataPipeline.</returns>
        PollForTaskResponse EndPollForTask(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPipelineDefinition

        /// <summary>
        /// Adds tasks, schedules, and preconditions that control the behavior of the pipeline.
        /// You can use PutPipelineDefinition to populate a new pipeline. 
        /// 
        ///  
        /// <para>
        ///  <a>PutPipelineDefinition</a> also validates the configuration as it adds it to the
        /// pipeline. Changes to the pipeline are saved unless one of the following three validation
        /// errors exists in the pipeline. <ol> <li>An object is missing a name or identifier
        /// field.</li> <li>A string or reference field is empty.</li> <li>The number of objects
        /// in the pipeline exceeds the maximum allowed objects.</li> <li>The pipeline is in a
        /// FINISHED state.</li> </ol> 
        /// </para>
        ///  
        /// <para>
        ///  Pipeline object definitions are passed to the <a>PutPipelineDefinition</a> action
        /// and returned by the <a>GetPipelineDefinition</a> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPipelineDefinition
        ///         operation.</returns>
        IAsyncResult BeginPutPipelineDefinition(PutPipelineDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPipelineDefinition.</param>
        /// 
        /// <returns>Returns a  PutPipelineDefinitionResult from DataPipeline.</returns>
        PutPipelineDefinitionResponse EndPutPipelineDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryObjects

        /// <summary>
        /// Queries a pipeline for the names of objects that match a specified set of conditions.
        /// 
        ///  
        /// <para>
        /// The objects returned by <a>QueryObjects</a> are paginated and then filtered by the
        /// value you set for query. This means the action may return an empty result set with
        /// a value set for marker. If <code>HasMoreResults</code> is set to <code>True</code>,
        /// you should continue to call <a>QueryObjects</a>, passing in the returned value for
        /// marker, until <code>HasMoreResults</code> returns <code>False</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects service method.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        QueryObjectsResponse QueryObjects(QueryObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryObjects
        ///         operation.</returns>
        IAsyncResult BeginQueryObjects(QueryObjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryObjects.</param>
        /// 
        /// <returns>Returns a  QueryObjectsResult from DataPipeline.</returns>
        QueryObjectsResponse EndQueryObjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ReportTaskProgress

        /// <summary>
        /// Updates the AWS Data Pipeline service on the progress of the calling task runner.
        /// When the task runner is assigned a task, it should call ReportTaskProgress to acknowledge
        /// that it has the task within 2 minutes. If the web service does not recieve this acknowledgement
        /// within the 2 minute window, it will assign the task in a subsequent <a>PollForTask</a>
        /// call. After this initial acknowledgement, the task runner only needs to report progress
        /// every 15 minutes to maintain its ownership of the task. You can change this reporting
        /// time from 15 minutes by specifying a <code>reportProgressTimeout</code> field in your
        /// pipeline. If a task runner does not report its status after 5 minutes, AWS Data Pipeline
        /// will assume that the task runner is unable to process the task and will reassign the
        /// task in a subsequent response to <a>PollForTask</a>. task runners should call <a>ReportTaskProgress</a>
        /// every 60 seconds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress service method.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReportTaskProgress
        ///         operation.</returns>
        IAsyncResult BeginReportTaskProgress(ReportTaskProgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportTaskProgress.</param>
        /// 
        /// <returns>Returns a  ReportTaskProgressResult from DataPipeline.</returns>
        ReportTaskProgressResponse EndReportTaskProgress(IAsyncResult asyncResult);

        #endregion
        
        #region  ReportTaskRunnerHeartbeat

        /// <summary>
        /// Task runners call <a>ReportTaskRunnerHeartbeat</a> every 15 minutes to indicate that
        /// they are operational. In the case of AWS Data Pipeline Task Runner launched on a resource
        /// managed by AWS Data Pipeline, the web service can use this call to detect when the
        /// task runner application has failed and restart a new instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service method.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReportTaskRunnerHeartbeat
        ///         operation.</returns>
        IAsyncResult BeginReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportTaskRunnerHeartbeat.</param>
        /// 
        /// <returns>Returns a  ReportTaskRunnerHeartbeatResult from DataPipeline.</returns>
        ReportTaskRunnerHeartbeatResponse EndReportTaskRunnerHeartbeat(IAsyncResult asyncResult);

        #endregion
        
        #region  SetStatus

        /// <summary>
        /// Requests that the status of an array of physical or logical pipeline objects be updated
        /// in the pipeline. This update may not occur immediately, but is eventually consistent.
        /// The status that can be set depends on the type of object, e.g. DataNode or Activity.
        /// You cannot perform this operation on FINISHED pipelines and attempting to do so will
        /// return an InvalidRequestException.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStatus service method.</param>
        /// 
        /// <returns>The response from the SetStatus service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        SetStatusResponse SetStatus(SetStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetStatus
        ///         operation.</returns>
        IAsyncResult BeginSetStatus(SetStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetStatus.</param>
        /// 
        /// <returns>Returns a  SetStatusResult from DataPipeline.</returns>
        SetStatusResponse EndSetStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTaskStatus

        /// <summary>
        /// Notifies AWS Data Pipeline that a task is completed and provides information about
        /// the final status. The task runner calls this action regardless of whether the task
        /// was sucessful. The task runner does not need to call <a>SetTaskStatus</a> for tasks
        /// that are canceled by the web service during a call to <a>ReportTaskProgress</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus service method.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTaskStatus
        ///         operation.</returns>
        IAsyncResult BeginSetTaskStatus(SetTaskStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTaskStatus.</param>
        /// 
        /// <returns>Returns a  SetTaskStatusResult from DataPipeline.</returns>
        SetTaskStatusResponse EndSetTaskStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidatePipelineDefinition

        /// <summary>
        /// Tests the pipeline definition with a set of validation checks to ensure that it is
        /// well formed and can run without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition service method.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition operation on AmazonDataPipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidatePipelineDefinition
        ///         operation.</returns>
        IAsyncResult BeginValidatePipelineDefinition(ValidatePipelineDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidatePipelineDefinition.</param>
        /// 
        /// <returns>Returns a  ValidatePipelineDefinitionResult from DataPipeline.</returns>
        ValidatePipelineDefinitionResponse EndValidatePipelineDefinition(IAsyncResult asyncResult);

        #endregion
        
    }
}