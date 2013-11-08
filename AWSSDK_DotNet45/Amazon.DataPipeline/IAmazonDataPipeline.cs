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

using Amazon.DataPipeline.Model;

namespace Amazon.DataPipeline
{
    /// <summary>
    /// Interface for accessing AmazonDataPipeline.
    /// 
    /// <para> This is the <i>AWS Data Pipeline API Reference</i> . This guide provides descriptions and samples of the AWS Data Pipeline API.
    /// </para> <para> AWS Data Pipeline is a web service that configures and manages a data-driven workflow called a pipeline. AWS Data Pipeline
    /// handles the details of scheduling and ensuring that data dependencies are met so your application can focus on processing the data.</para>
    /// <para> The AWS Data Pipeline API implements two main sets of functionality. The first set of actions configure the pipeline in the web
    /// service. You call these actions to create a pipeline and define data sources, schedules, dependencies, and the transforms to be performed on
    /// the data. </para> <para> The second set of actions are used by a task runner application that calls the AWS Data Pipeline API to receive the
    /// next task ready for processing. The logic for performing the task, such as querying the data, running data analysis, or converting the data
    /// from one format to another, is contained within the task runner. The task runner performs the task assigned to it by the web service,
    /// reporting progress to the web service as it does so. When the task is done, the task runner reports the final success or failure of the task
    /// to the web service. </para> <para> AWS Data Pipeline provides an open-source implementation of a task runner called AWS Data Pipeline Task
    /// Runner. AWS Data Pipeline Task Runner provides logic for common data management scenarios, such as performing database queries and running
    /// data analysis using Amazon Elastic MapReduce (Amazon EMR). You can use AWS Data Pipeline Task Runner as your task runner, or you can write
    /// your own task runner to provide custom data management. </para> <para> The AWS Data Pipeline API uses the Signature Version 4 protocol for
    /// signing requests. For more information about how to sign a request with this protocol, see <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature Version 4 Signing Process</a> . In the code examples
    /// in this reference, the Signature Version 4 Request parameters are represented as AuthParams. </para>
    /// </summary>
	public partial interface IAmazonDataPipeline : IDisposable
    {
 

        /// <summary>
        /// <para> Validates a pipeline and initiates processing. If the pipeline does not pass validation, activation fails. </para> <para> Call this
        /// action to start processing pipeline tasks of a pipeline you've created using the CreatePipeline and PutPipelineDefinition actions. A
        /// pipeline cannot be modified after it has been successfully activated. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		ActivatePipelineResponse ActivatePipeline(ActivatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ActivatePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new empty pipeline. When this action succeeds, you can then use the PutPipelineDefinition action to populate the
        /// pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
		CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Permanently deletes a pipeline, its pipeline definition and its run history. You cannot query or restore a deleted pipeline. AWS Data
        /// Pipeline will attempt to cancel instances associated with the pipeline that are currently being processed by task runners. Deleting a
        /// pipeline cannot be undone. </para> <para> To temporarily pause a pipeline instead of deleting it, call SetStatus with the status set to
        /// Pause on individual components. Components that are paused by SetStatus can be resumed. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
		DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns the object definitions for a set of objects associated with the pipeline. Object definitions are composed of a set of fields
        /// that define the properties of the object. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribeObjects"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Retrieve metadata about one or more pipelines. The information retrieved includes the name of the pipeline, the pipeline identifier,
        /// its current state, and the user account that owns the pipeline. Using account credentials, you can retrieve metadata about pipelines that
        /// you or your IAM users have created. If you are using an IAM user account, you can retrieve metadata about only those pipelines you have read
        /// permission for. </para> <para> To retrieve the full pipeline definition instead of metadata about the pipeline, call the
        /// GetPipelineDefinition action. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.DescribePipelines"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Evaluates a string in the context of a specified object. A task runner can use this action to evaluate SQL queries stored in Amazon
        /// S3. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.EvaluateExpression"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the definition of the specified pipeline. You can call GetPipelineDefinition to retrieve the pipeline definition you provided
        /// using PutPipelineDefinition.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.GetPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned only for pipelines you have permission to
        /// access. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
		ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list of pipeline identifiers for all active pipelines. Identifiers are returned only for pipelines you have permission to
        /// access. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
		ListPipelinesResponse ListPipelines();
 

        /// <summary>
        /// <para> Task runners call this action to receive a task to perform from AWS Data Pipeline. The task runner specifies which tasks it can
        /// perform by setting a value for the workerGroup parameter of the PollForTask call. The task returned by PollForTask may come from any of the
        /// pipelines that match the workerGroup value passed in by the task runner and that was launched using the IAM user credentials specified by
        /// the task runner. </para> <para> If tasks are ready in the work queue, PollForTask returns a response immediately. If no tasks are available
        /// in the queue, PollForTask uses long-polling and holds on to a poll connection for up to a 90 seconds during which time the first newly
        /// scheduled task is handed to the task runner. To accomodate this, set the socket timeout in your task runner to 90 seconds. The task runner
        /// should not call PollForTask again on the same <c>workerGroup</c> until it receives a response, and this may take up to 90 seconds. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
		PollForTaskResponse PollForTask(PollForTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PollForTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Adds tasks, schedules, and preconditions that control the behavior of the pipeline. You can use PutPipelineDefinition to populate a
        /// new pipeline. </para> <para> PutPipelineDefinition also validates the configuration as it adds it to the pipeline. Changes to the pipeline
        /// are saved unless one of the following three validation errors exists in the pipeline. <ol> <li>An object is missing a name or identifier
        /// field.</li>
        /// <li>A string or reference field is empty.</li>
        /// <li>The number of objects in the pipeline exceeds the maximum allowed objects.</li>
        /// </ol> </para> <para> Pipeline object definitions are passed to the PutPipelineDefinition action and returned by the GetPipelineDefinition
        /// action. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.PutPipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Queries a pipeline for the names of objects that match a specified set of conditions.</para> <para>The objects returned by
        /// QueryObjects are paginated and then filtered by the value you set for query. This means the action may return an empty result set with a
        /// value set for marker. If <c>HasMoreResults</c> is set to <c>True</c> , you should continue to call QueryObjects, passing in the returned
        /// value for marker, until <c>HasMoreResults</c> returns <c>False</c> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		QueryObjectsResponse QueryObjects(QueryObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.QueryObjects"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Updates the AWS Data Pipeline service on the progress of the calling task runner. When the task runner is assigned a task, it should
        /// call ReportTaskProgress to acknowledge that it has the task within 2 minutes. If the web service does not recieve this acknowledgement
        /// within the 2 minute window, it will assign the task in a subsequent PollForTask call. After this initial acknowledgement, the task runner
        /// only needs to report progress every 15 minutes to maintain its ownership of the task. You can change this reporting time from 15 minutes by
        /// specifying a <c>reportProgressTimeout</c> field in your pipeline. If a task runner does not report its status after 5 minutes, AWS Data
        /// Pipeline will assume that the task runner is unable to process the task and will reassign the task in a subsequent response to PollForTask.
        /// task runners should call ReportTaskProgress every 60 seconds. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskProgress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Task runners call ReportTaskRunnerHeartbeat every 15 minutes to indicate that they are operational. In the case of AWS Data Pipeline
        /// Task Runner launched on a resource managed by AWS Data Pipeline, the web service can use this call to detect when the task runner
        /// application has failed and restart a new instance.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
		ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ReportTaskRunnerHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Requests that the status of an array of physical or logical pipeline objects be updated in the pipeline. This update may not occur
        /// immediately, but is eventually consistent. The status that can be set depends on the type of object.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus service method on AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		SetStatusResponse SetStatus(SetStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetStatusResponse> SetStatusAsync(SetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Notifies AWS Data Pipeline that a task is completed and provides information about the final status. The task runner calls this
        /// action regardless of whether the task was sucessful. The task runner does not need to call SetTaskStatus for tasks that are canceled by the
        /// web service during a call to ReportTaskProgress. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.SetTaskStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Tests the pipeline definition with a set of validation checks to ensure that it is well formed and can run without error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
		ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline.ValidatePipelineDefinition"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
