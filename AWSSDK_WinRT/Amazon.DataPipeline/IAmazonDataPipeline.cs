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
using System.Threading;
using System.Threading.Tasks;
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
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePipeline

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePipeline

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipelines

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EvaluateExpression

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPipelineDefinition

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelines

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PollForTask

        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutPipelineDefinition

        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryObjects

        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReportTaskProgress

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReportTaskRunnerHeartbeat

        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetStatus

        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetStatusResponse> SetStatusAsync(SetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetTaskStatus

        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidatePipelineDefinition

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// <seealso cref="Amazon.DataPipeline.IAmazonDataPipeline"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}