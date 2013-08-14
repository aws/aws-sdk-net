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
    /// 
    /// </summary>
	public partial interface IAmazonDataPipeline : IDisposable
    {
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="activatePipelineRequest">Container for the necessary parameters to execute the ActivatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest activatePipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest createPipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest deletePipelineRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeObjectsRequest">Container for the necessary parameters to execute the DescribeObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest describeObjectsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describePipelinesRequest">Container for the necessary parameters to execute the DescribePipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest describePipelinesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="evaluateExpressionRequest">Container for the necessary parameters to execute the EvaluateExpression service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest evaluateExpressionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getPipelineDefinitionRequest">Container for the necessary parameters to execute the GetPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest getPipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest listPipelinesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="pollForTaskRequest">Container for the necessary parameters to execute the PollForTask service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest pollForTaskRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="putPipelineDefinitionRequest">Container for the necessary parameters to execute the PutPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest putPipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="queryObjectsRequest">Container for the necessary parameters to execute the QueryObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest queryObjectsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="reportTaskProgressRequest">Container for the necessary parameters to execute the ReportTaskProgress service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest reportTaskProgressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="reportTaskRunnerHeartbeatRequest">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest reportTaskRunnerHeartbeatRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setStatusRequest">Container for the necessary parameters to execute the SetStatus service method on AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetStatusResponse> SetStatusAsync(SetStatusRequest setStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setTaskStatusRequest">Container for the necessary parameters to execute the SetTaskStatus service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest setTaskStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="validatePipelineDefinitionRequest">Container for the necessary parameters to execute the ValidatePipelineDefinition service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
