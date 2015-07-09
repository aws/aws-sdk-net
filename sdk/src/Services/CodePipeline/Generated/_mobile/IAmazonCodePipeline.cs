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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodePipeline.Model;

namespace Amazon.CodePipeline
{
    /// <summary>
    /// Interface for accessing CodePipeline
    ///
    /// AWS CodePipeline <b>Overview</b> 
    /// <para>
    /// This is the AWS CodePipeline API Reference. This guide provides descriptions of the
    /// actions and data types for AWS CodePipeline. Some functionality for your pipeline
    /// is only configurable through the API. For additional information, see the <a href="http://docs.aws.amazon.com/pipelines/latest/userguide/welcome.html">AWS
    /// CodePipeline User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodePipeline API to work with pipelines, stages, actions, gates,
    /// and transitions, as described below.
    /// </para>
    ///  
    /// <para>
    /// <i>Pipelines</i> are models of automated release processes. Each pipeline is uniquely
    /// named, and consists of actions, gates, and stages. 
    /// </para>
    ///  
    /// <para>
    /// You can work with pipelines by calling: <ul> <li> <a>CreatePipeline</a>, which creates
    /// a uniquely-named pipeline.</li> <li> <a>DeletePipeline</a>, which deletes the specified
    /// pipeline.</li> <li> <a>GetPipeline</a>, which returns information about a pipeline
    /// structure.</li> <li> <a>GetPipelineState</a>, which returns information about the
    /// current state of the stages and actions of a pipeline.</li> <li> <a>ListPipelines</a>,
    /// which gets a summary of all of the pipelines associated with your account.</li> <li>
    /// <a>StartPipelineExecution</a>, which runs the the most recent revision of an artifact
    /// through the pipeline.</li> <li> <a>UpdatePipeline</a>, which updates a pipeline with
    /// edits or changes to the structure of the pipeline.</li> </ul> 
    /// <para>
    /// Pipelines include <i>stages</i>, which are which are logical groupings of gates and
    /// actions. Each stage contains one or more actions that must complete before the next
    /// stage begins. A stage will result in success or failure. If a stage fails, then the
    /// pipeline stops at that stage and will remain stopped until either a new version of
    /// an artifact appears in the source location, or a user takes action to re-run the most
    /// recent artifact through the pipeline. You can call <a>GetPipelineState</a>, which
    /// displays the status of a pipeline, including the status of stages in the pipeline,
    /// or <a>GetPipeline</a>, which returns the entire structure of the pipeline, including
    /// the stages of that pipeline.
    /// </para>
    ///  
    /// </para>
    ///  
    /// <para>
    /// Pipeline stages include <i>actions</i>, which are categorized into categories such
    /// as source or build actions performed within a stage of a pipeline. For example, you
    /// can use a source action to import artifacts into a pipeline from a source such as
    /// Amazon S3. Like stages, you do not work with actions directly in most cases, but you
    /// do define and interact with actions when working with pipeline operations such as
    /// <a>CreatePipeline</a> and <a>GetPipelineState</a>. 
    /// </para>
    ///  
    /// <para>
    /// Pipelines also include <i>transitions</i>, which allow the transition of artifacts
    /// from one stage to the next in a pipeline after the actions in one stage complete.
    /// </para>
    ///  
    /// <para>
    /// You can work with transitions by calling:
    /// </para>
    ///  <ul> <li> <a>DisableStageTransition</a>, which prevents artifacts from transitioning
    /// to the next stage in a pipeline.</li> <li> <a>EnableStageTransition</a>, which enables
    /// transition of artifacts between stages in a pipeline. </li> </ul> 
    /// <para>
    /// <b>Using the API to integrate with AWS CodePipeline</b>
    /// </para>
    ///  
    /// <para>
    /// For third-party integrators or developers who want to create their own integrations
    /// with AWS CodePipeline, the expected sequence varies from the standard API user. In
    /// order to integrate with AWS CodePipeline, developers will need to work with the following
    /// items:
    /// </para>
    ///  <ul> <li>Jobs, which are instances of an action. For example, a job for a source
    /// action might import a revision of an artifact from a source. 
    /// <para>
    /// You can work with jobs by calling:
    /// </para>
    ///  <ul> <li> <a>AcknowledgeJob</a>, which confirms whether a job worker has received
    /// the specified job,</li> <li> <a>PollForJobs</a>, which determines whether there are
    /// any jobs to act upon, </li> <li> <a>PutJobFailureResult</a>, which provides details
    /// of a job failure, and</li> <li> <a>PutJobSuccessResult</a>, which provides details
    /// of a job success.</li> </ul> </li> <li>Third party jobs, which are instances of an
    /// action created by a partner action and integrated into AWS CodePipeline. Partner actions
    /// are created by members of the AWS Partner Network. 
    /// <para>
    /// You can work with third party jobs by calling:
    /// </para>
    ///  <ul> <li> <a>AcknowledgeThirdPartyJob</a>, which confirms whether a job worker has
    /// received the specified job,</li> <li> <a>PollForThirdPartyJobs</a>, which determines
    /// whether there are any jobs to act upon, </li> <li> <a>PutThirdPartyJobFailureResult</a>,
    /// which provides details of a job failure, and</li> <li> <a>PutThirdPartyJobSuccessResult</a>,
    /// which provides details of a job success.</li> </ul> </li> </ul>
    /// </summary>
    public partial interface IAmazonCodePipeline : IDisposable
    {
                
        #region  AcknowledgeJob

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AcknowledgeJobResponse> AcknowledgeJobAsync(AcknowledgeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcknowledgeThirdPartyJob

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeThirdPartyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(AcknowledgeThirdPartyJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomActionType

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCustomActionTypeResponse> CreateCustomActionTypeAsync(CreateCustomActionTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomActionType

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCustomActionTypeResponse> DeleteCustomActionTypeAsync(DeleteCustomActionTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableStageTransition

        /// <summary>
        /// Initiates the asynchronous execution of the DisableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableStageTransitionResponse> DisableStageTransitionAsync(DisableStageTransitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableStageTransition

        /// <summary>
        /// Initiates the asynchronous execution of the EnableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableStageTransitionResponse> EnableStageTransitionAsync(EnableStageTransitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobDetails

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetJobDetailsResponse> GetJobDetailsAsync(GetJobDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPipeline

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPipelineState

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetPipelineStateResponse> GetPipelineStateAsync(GetPipelineStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetThirdPartyJobDetails

        /// <summary>
        /// Initiates the asynchronous execution of the GetThirdPartyJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(GetThirdPartyJobDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActionTypes

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListActionTypesResponse> ListActionTypesAsync(ListActionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelines

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PollForJobs

        /// <summary>
        /// Initiates the asynchronous execution of the PollForJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForJobsResponse> PollForJobsAsync(PollForJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PollForThirdPartyJobs

        /// <summary>
        /// Initiates the asynchronous execution of the PollForThirdPartyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForThirdPartyJobsResponse> PollForThirdPartyJobsAsync(PollForThirdPartyJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutActionRevision

        /// <summary>
        /// Initiates the asynchronous execution of the PutActionRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutActionRevisionResponse> PutActionRevisionAsync(PutActionRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutJobFailureResult

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutJobFailureResultResponse> PutJobFailureResultAsync(PutJobFailureResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutJobSuccessResult

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutJobSuccessResultResponse> PutJobSuccessResultAsync(PutJobSuccessResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutThirdPartyJobFailureResult

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(PutThirdPartyJobFailureResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutThirdPartyJobSuccessResult

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutThirdPartyJobSuccessResultResponse> PutThirdPartyJobSuccessResultAsync(PutThirdPartyJobSuccessResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartPipelineExecution

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}