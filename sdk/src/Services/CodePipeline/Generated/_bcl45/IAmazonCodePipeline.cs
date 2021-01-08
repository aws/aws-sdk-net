/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.CodePipeline.Model;

namespace Amazon.CodePipeline
{
    /// <summary>
    /// Interface for accessing CodePipeline
    ///
    /// AWS CodePipeline 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the AWS CodePipeline API Reference. This guide provides descriptions of the
    /// actions and data types for AWS CodePipeline. Some functionality for your pipeline
    /// can only be configured through the API. For more information, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/welcome.html">AWS
    /// CodePipeline User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodePipeline API to work with pipelines, stages, actions, and
    /// transitions.
    /// </para>
    ///  
    /// <para>
    ///  <i>Pipelines</i> are models of automated release processes. Each pipeline is uniquely
    /// named, and consists of stages, actions, and transitions. 
    /// </para>
    ///  
    /// <para>
    /// You can work with pipelines by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePipeline</a>, which creates a uniquely named pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeletePipeline</a>, which deletes the specified pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipeline</a>, which returns information about the pipeline structure and pipeline
    /// metadata, including the pipeline Amazon Resource Name (ARN).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipelineExecution</a>, which returns information about a specific execution
    /// of a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPipelineState</a>, which returns information about the current state of the
    /// stages and actions of a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListActionExecutions</a>, which returns action-level details for past executions.
    /// The details include full stage and action-level details, including individual action
    /// duration, status, any errors that occurred during the execution, and input and output
    /// artifact location details.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPipelines</a>, which gets a summary of all of the pipelines associated with
    /// your account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPipelineExecutions</a>, which gets a summary of the most recent executions
    /// for a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartPipelineExecution</a>, which runs the most recent revision of an artifact
    /// through the pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopPipelineExecution</a>, which stops the specified pipeline execution from continuing
    /// through the pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePipeline</a>, which updates a pipeline with edits or changes to the structure
    /// of the pipeline.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Pipelines include <i>stages</i>. Each stage contains one or more actions that must
    /// complete before the next stage begins. A stage results in success or failure. If a
    /// stage fails, the pipeline stops at that stage and remains stopped until either a new
    /// version of an artifact appears in the source location, or a user takes action to rerun
    /// the most recent artifact through the pipeline. You can call <a>GetPipelineState</a>,
    /// which displays the status of a pipeline, including the status of stages in the pipeline,
    /// or <a>GetPipeline</a>, which returns the entire structure of the pipeline, including
    /// the stages of that pipeline. For more information about the structure of stages and
    /// actions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-structure.html">AWS
    /// CodePipeline Pipeline Structure Reference</a>.
    /// </para>
    ///  
    /// <para>
    /// Pipeline stages include <i>actions</i> that are categorized into categories such as
    /// source or build actions performed in a stage of a pipeline. For example, you can use
    /// a source action to import artifacts into a pipeline from a source such as Amazon S3.
    /// Like stages, you do not work with actions directly in most cases, but you do define
    /// and interact with actions when working with pipeline operations such as <a>CreatePipeline</a>
    /// and <a>GetPipelineState</a>. Valid action categories are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Source
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Build
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Test
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deploy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Approval
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Invoke
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Pipelines also include <i>transitions</i>, which allow the transition of artifacts
    /// from one stage to the next in a pipeline after the actions in one stage complete.
    /// </para>
    ///  
    /// <para>
    /// You can work with transitions by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DisableStageTransition</a>, which prevents artifacts from transitioning to the
    /// next stage in a pipeline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>EnableStageTransition</a>, which enables transition of artifacts between stages
    /// in a pipeline. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Using the API to integrate with AWS CodePipeline</b> 
    /// </para>
    ///  
    /// <para>
    /// For third-party integrators or developers who want to create their own integrations
    /// with AWS CodePipeline, the expected sequence varies from the standard API user. To
    /// integrate with AWS CodePipeline, developers need to work with the following items:
    /// </para>
    ///  
    /// <para>
    ///  <b>Jobs</b>, which are instances of an action. For example, a job for a source action
    /// might import a revision of an artifact from a source. 
    /// </para>
    ///  
    /// <para>
    /// You can work with jobs by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AcknowledgeJob</a>, which confirms whether a job worker has received the specified
    /// job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetJobDetails</a>, which returns the details of a job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForJobs</a>, which determines whether there are any jobs to act on.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutJobFailureResult</a>, which provides details of a job failure. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutJobSuccessResult</a>, which provides details of a job success.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Third party jobs</b>, which are instances of an action created by a partner action
    /// and integrated into AWS CodePipeline. Partner actions are created by members of the
    /// AWS Partner Network.
    /// </para>
    ///  
    /// <para>
    /// You can work with third party jobs by calling:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AcknowledgeThirdPartyJob</a>, which confirms whether a job worker has received
    /// the specified job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetThirdPartyJobDetails</a>, which requests the details of a job for a partner
    /// action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForThirdPartyJobs</a>, which determines whether there are any jobs to act
    /// on. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobFailureResult</a>, which provides details of a job failure.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobSuccessResult</a>, which provides details of a job success.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodePipeline : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodePipelinePaginatorFactory Paginators { get; }

        
        #region  AcknowledgeJob


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Used for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        AcknowledgeJobResponse AcknowledgeJob(string jobId, string nonce);

        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Used for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request);


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Used for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        Task<AcknowledgeJobResponse> AcknowledgeJobAsync(string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Used for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        Task<AcknowledgeJobResponse> AcknowledgeJobAsync(AcknowledgeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AcknowledgeThirdPartyJob


        /// <summary>
        /// Confirms a job worker has received the specified job. Used for partner actions only.
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID of the job.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a> request.</param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(string clientToken, string jobId, string nonce);

        /// <summary>
        /// Confirms a job worker has received the specified job. Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request);


        /// <summary>
        /// Confirms a job worker has received the specified job. Used for partner actions only.
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID of the job.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a> request.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(string clientToken, string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Confirms a job worker has received the specified job. Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeThirdPartyJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(AcknowledgeThirdPartyJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCustomActionType


        /// <summary>
        /// Creates a new custom action that can be used in all pipelines associated with the
        /// AWS account. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType service method.</param>
        /// 
        /// <returns>The response from the CreateCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request);



        /// <summary>
        /// Creates a new custom action that can be used in all pipelines associated with the
        /// AWS account. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        Task<CreateCustomActionTypeResponse> CreateCustomActionTypeAsync(CreateCustomActionTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse CreatePipeline(PipelineDeclaration pipeline);

        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);


        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        Task<CreatePipelineResponse> CreatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomActionType


        /// <summary>
        /// Marks a custom action as deleted. <code>PollForJobs</code> for the custom action fails
        /// after the action is marked for deletion. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// To re-create a custom action after it has been deleted you must use a string in the
        /// version field that has never been used before. This string can be an incremented version
        /// number, for example. To restore a deleted custom action, use a JSON file that is identical
        /// to the deleted action, including the original string in the version field.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request);



        /// <summary>
        /// Marks a custom action as deleted. <code>PollForJobs</code> for the custom action fails
        /// after the action is marked for deletion. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// To re-create a custom action after it has been deleted you must use a string in the
        /// version field that has never been used before. This string can be an incremented version
        /// number, for example. To restore a deleted custom action, use a JSON file that is identical
        /// to the deleted action, including the original string in the version field.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        Task<DeleteCustomActionTypeResponse> DeleteCustomActionTypeAsync(DeleteCustomActionTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse DeletePipeline(string name);

        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        Task<DeletePipelineResponse> DeletePipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// Deletes a previously created webhook by name. Deleting the webhook stops AWS CodePipeline
        /// from starting a pipeline every time an external event occurs. The API returns successfully
        /// when trying to delete a webhook that is already deleted. If a deleted webhook is re-created
        /// by calling PutWebhook with the same name, it will have a different URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request);



        /// <summary>
        /// Deletes a previously created webhook by name. Deleting the webhook stops AWS CodePipeline
        /// from starting a pipeline every time an external event occurs. The API returns successfully
        /// when trying to delete a webhook that is already deleted. If a deleted webhook is re-created
        /// by calling PutWebhook with the same name, it will have a different URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterWebhookWithThirdParty


        /// <summary>
        /// Removes the connection between the webhook that was created by CodePipeline and the
        /// external tool with events to be detected. Currently supported only for webhooks that
        /// target an action type of GitHub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWebhookWithThirdParty service method.</param>
        /// 
        /// <returns>The response from the DeregisterWebhookWithThirdParty service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.WebhookNotFoundException">
        /// The specified webhook was entered in an invalid format or cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeregisterWebhookWithThirdParty">REST API Reference for DeregisterWebhookWithThirdParty Operation</seealso>
        DeregisterWebhookWithThirdPartyResponse DeregisterWebhookWithThirdParty(DeregisterWebhookWithThirdPartyRequest request);



        /// <summary>
        /// Removes the connection between the webhook that was created by CodePipeline and the
        /// external tool with events to be detected. Currently supported only for webhooks that
        /// target an action type of GitHub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWebhookWithThirdParty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterWebhookWithThirdParty service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.WebhookNotFoundException">
        /// The specified webhook was entered in an invalid format or cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeregisterWebhookWithThirdParty">REST API Reference for DeregisterWebhookWithThirdParty Operation</seealso>
        Task<DeregisterWebhookWithThirdPartyResponse> DeregisterWebhookWithThirdPartyAsync(DeregisterWebhookWithThirdPartyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableStageTransition


        /// <summary>
        /// Prevents artifacts in a pipeline from transitioning to the next stage in the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition service method.</param>
        /// 
        /// <returns>The response from the DisableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request);



        /// <summary>
        /// Prevents artifacts in a pipeline from transitioning to the next stage in the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        Task<DisableStageTransitionResponse> DisableStageTransitionAsync(DisableStageTransitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableStageTransition


        /// <summary>
        /// Enables artifacts in a pipeline to transition to a stage in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition service method.</param>
        /// 
        /// <returns>The response from the EnableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request);



        /// <summary>
        /// Enables artifacts in a pipeline to transition to a stage in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        Task<EnableStageTransitionResponse> EnableStageTransitionAsync(EnableStageTransitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobDetails


        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="jobId">The unique system-generated ID for the job.</param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        GetJobDetailsResponse GetJobDetails(string jobId);

        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails service method.</param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request);


        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="jobId">The unique system-generated ID for the job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        Task<GetJobDetailsResponse> GetJobDetailsAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        Task<GetJobDetailsResponse> GetJobDetailsAsync(GetJobDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPipeline


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an AWS user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the current version.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        GetPipelineResponse GetPipeline(string name, int version);

        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an AWS user account.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        GetPipelineResponse GetPipeline(string name);

        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        GetPipelineResponse GetPipeline(GetPipelineRequest request);


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an AWS user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the current version.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        Task<GetPipelineResponse> GetPipelineAsync(string name, int version, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an AWS user account.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        Task<GetPipelineResponse> GetPipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPipelineExecution


        /// <summary>
        /// Returns information about an execution of a pipeline, including details about artifacts,
        /// the pipeline execution ID, and the name, version, and status of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the GetPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        GetPipelineExecutionResponse GetPipelineExecution(GetPipelineExecutionRequest request);



        /// <summary>
        /// Returns information about an execution of a pipeline, including details about artifacts,
        /// the pipeline execution ID, and the name, version, and status of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        Task<GetPipelineExecutionResponse> GetPipelineExecutionAsync(GetPipelineExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPipelineState


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <code>revisionId</code> and <code>revisionUrl</code> fields
        /// indicate the source revision information, such as the commit ID, for the current state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        GetPipelineStateResponse GetPipelineState(string name);

        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <code>revisionId</code> and <code>revisionUrl</code> fields
        /// indicate the source revision information, such as the commit ID, for the current state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState service method.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request);


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <code>revisionId</code> and <code>revisionUrl</code> fields
        /// indicate the source revision information, such as the commit ID, for the current state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        Task<GetPipelineStateResponse> GetPipelineStateAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <code>revisionId</code> and <code>revisionUrl</code> fields
        /// indicate the source revision information, such as the commit ID, for the current state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        Task<GetPipelineStateResponse> GetPipelineStateAsync(GetPipelineStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetThirdPartyJobDetails


        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID used for identifying the job.</param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(string clientToken, string jobId);

        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails service method.</param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request);


        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID used for identifying the job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(string clientToken, string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThirdPartyJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(GetThirdPartyJobDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListActionExecutions


        /// <summary>
        /// Lists the action executions that have occurred in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionExecutions service method.</param>
        /// 
        /// <returns>The response from the ListActionExecutions service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionExecutions">REST API Reference for ListActionExecutions Operation</seealso>
        ListActionExecutionsResponse ListActionExecutions(ListActionExecutionsRequest request);



        /// <summary>
        /// Lists the action executions that have occurred in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionExecutions service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionExecutions">REST API Reference for ListActionExecutions Operation</seealso>
        Task<ListActionExecutionsResponse> ListActionExecutionsAsync(ListActionExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListActionTypes


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        ListActionTypesResponse ListActionTypes();

        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="actionOwnerFilter">Filters the list of action types to those created by a specified entity.</param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        ListActionTypesResponse ListActionTypes(ActionOwner actionOwnerFilter);

        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes service method.</param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        ListActionTypesResponse ListActionTypes(ListActionTypesRequest request);


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        Task<ListActionTypesResponse> ListActionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="actionOwnerFilter">Filters the list of action types to those created by a specified entity.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        Task<ListActionTypesResponse> ListActionTypesAsync(ActionOwner actionOwnerFilter, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActionTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        Task<ListActionTypesResponse> ListActionTypesAsync(ListActionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPipelineExecutions


        /// <summary>
        /// Gets a summary of the most recent executions for a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request);



        /// <summary>
        /// Gets a summary of the most recent executions for a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse ListPipelines();

        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets the set of key-value pairs (metadata) that are used to manage the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets the set of key-value pairs (metadata) that are used to manage the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebhooks


        /// <summary>
        /// Gets a listing of all the webhooks in this AWS Region for this account. The output
        /// lists all webhooks and includes the webhook URL and ARN and the configuration for
        /// each webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        ListWebhooksResponse ListWebhooks(ListWebhooksRequest request);



        /// <summary>
        /// Gets a listing of all the webhooks in this AWS Region for this account. The output
        /// lists all webhooks and includes the webhook URL and ARN and the configuration for
        /// each webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PollForJobs


        /// <summary>
        /// Returns information about any jobs for AWS CodePipeline to act on. <code>PollForJobs</code>
        /// is valid only for action types with "Custom" in the owner field. If the action type
        /// contains "AWS" or "ThirdParty" in the owner field, the <code>PollForJobs</code> action
        /// returns an error.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs service method.</param>
        /// 
        /// <returns>The response from the PollForJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        PollForJobsResponse PollForJobs(PollForJobsRequest request);



        /// <summary>
        /// Returns information about any jobs for AWS CodePipeline to act on. <code>PollForJobs</code>
        /// is valid only for action types with "Custom" in the owner field. If the action type
        /// contains "AWS" or "ThirdParty" in the owner field, the <code>PollForJobs</code> action
        /// returns an error.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts. This API also returns any secret values
        /// defined for the action.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PollForJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        Task<PollForJobsResponse> PollForJobsAsync(PollForJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PollForThirdPartyJobs


        /// <summary>
        /// Determines whether there are any third party jobs for a job worker to act on. Used
        /// for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs service method.</param>
        /// 
        /// <returns>The response from the PollForThirdPartyJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        PollForThirdPartyJobsResponse PollForThirdPartyJobs(PollForThirdPartyJobsRequest request);



        /// <summary>
        /// Determines whether there are any third party jobs for a job worker to act on. Used
        /// for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the S3
        /// bucket used to store artifacts for the pipeline, if the action requires access to
        /// that S3 bucket for input or output artifacts.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PollForThirdPartyJobs service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        Task<PollForThirdPartyJobsResponse> PollForThirdPartyJobsAsync(PollForThirdPartyJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutActionRevision


        /// <summary>
        /// Provides information to AWS CodePipeline about new revisions to a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision service method.</param>
        /// 
        /// <returns>The response from the PutActionRevision service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request);



        /// <summary>
        /// Provides information to AWS CodePipeline about new revisions to a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutActionRevision service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        Task<PutActionRevisionResponse> PutActionRevisionAsync(PutActionRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutApprovalResult


        /// <summary>
        /// Provides the response to a manual approval request to AWS CodePipeline. Valid responses
        /// include Approved and Rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult service method.</param>
        /// 
        /// <returns>The response from the PutApprovalResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ApprovalAlreadyCompletedException">
        /// The approval action has already been approved or rejected.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidApprovalTokenException">
        /// The approval request already received a response or has expired.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        PutApprovalResultResponse PutApprovalResult(PutApprovalResultRequest request);



        /// <summary>
        /// Provides the response to a manual approval request to AWS CodePipeline. Valid responses
        /// include Approved and Rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutApprovalResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ApprovalAlreadyCompletedException">
        /// The approval action has already been approved or rejected.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidApprovalTokenException">
        /// The approval request already received a response or has expired.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        Task<PutApprovalResultResponse> PutApprovalResultAsync(PutApprovalResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutJobFailureResult


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from <code>PollForJobs</code>.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        PutJobFailureResultResponse PutJobFailureResult(string jobId, FailureDetails failureDetails);

        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult service method.</param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request);


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from <code>PollForJobs</code>.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        Task<PutJobFailureResultResponse> PutJobFailureResultAsync(string jobId, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        Task<PutJobFailureResultResponse> PutJobFailureResultAsync(PutJobFailureResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutJobSuccessResult


        /// <summary>
        /// Represents the success of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.OutputVariablesSizeExceededException">
        /// Exceeded the total size limit for all variables in the pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request);



        /// <summary>
        /// Represents the success of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.OutputVariablesSizeExceededException">
        /// Exceeded the total size limit for all variables in the pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        Task<PutJobSuccessResultResponse> PutJobSuccessResultAsync(PutJobSuccessResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutThirdPartyJobFailureResult


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from <code>PollForThirdPartyJobs</code>.</param>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="failureDetails">Represents information about failure details.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(string jobId, string clientToken, FailureDetails failureDetails);

        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult service method.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request);


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from <code>PollForThirdPartyJobs</code>.</param>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="failureDetails">Represents information about failure details.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(string jobId, string clientToken, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutThirdPartyJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(PutThirdPartyJobFailureResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutThirdPartyJobSuccessResult


        /// <summary>
        /// Represents the success of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request);



        /// <summary>
        /// Represents the success of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutThirdPartyJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidClientTokenException">
        /// The client token was specified in an invalid format
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        Task<PutThirdPartyJobSuccessResultResponse> PutThirdPartyJobSuccessResultAsync(PutThirdPartyJobSuccessResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutWebhook


        /// <summary>
        /// Defines a webhook and returns a unique webhook URL generated by CodePipeline. This
        /// URL can be supplied to third party source hosting providers to call every time there's
        /// a code change. When CodePipeline receives a POST request on this URL, the pipeline
        /// defined in the webhook is started as long as the POST request satisfied the authentication
        /// and filtering requirements supplied when defining the webhook. RegisterWebhookWithThirdParty
        /// and DeregisterWebhookWithThirdParty APIs can be used to automatically configure supported
        /// third parties to call the generated webhook URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWebhook service method.</param>
        /// 
        /// <returns>The response from the PutWebhook service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidWebhookAuthenticationParametersException">
        /// The specified authentication type is in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidWebhookFilterPatternException">
        /// The specified event filter rule is in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        PutWebhookResponse PutWebhook(PutWebhookRequest request);



        /// <summary>
        /// Defines a webhook and returns a unique webhook URL generated by CodePipeline. This
        /// URL can be supplied to third party source hosting providers to call every time there's
        /// a code change. When CodePipeline receives a POST request on this URL, the pipeline
        /// defined in the webhook is started as long as the POST request satisfied the authentication
        /// and filtering requirements supplied when defining the webhook. RegisterWebhookWithThirdParty
        /// and DeregisterWebhookWithThirdParty APIs can be used to automatically configure supported
        /// third parties to call the generated webhook URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWebhook service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidWebhookAuthenticationParametersException">
        /// The specified authentication type is in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidWebhookFilterPatternException">
        /// The specified event filter rule is in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        Task<PutWebhookResponse> PutWebhookAsync(PutWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterWebhookWithThirdParty


        /// <summary>
        /// Configures a connection between the webhook that was created and the external tool
        /// with events to be detected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWebhookWithThirdParty service method.</param>
        /// 
        /// <returns>The response from the RegisterWebhookWithThirdParty service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.WebhookNotFoundException">
        /// The specified webhook was entered in an invalid format or cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RegisterWebhookWithThirdParty">REST API Reference for RegisterWebhookWithThirdParty Operation</seealso>
        RegisterWebhookWithThirdPartyResponse RegisterWebhookWithThirdParty(RegisterWebhookWithThirdPartyRequest request);



        /// <summary>
        /// Configures a connection between the webhook that was created and the external tool
        /// with events to be detected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWebhookWithThirdParty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterWebhookWithThirdParty service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.WebhookNotFoundException">
        /// The specified webhook was entered in an invalid format or cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RegisterWebhookWithThirdParty">REST API Reference for RegisterWebhookWithThirdParty Operation</seealso>
        Task<RegisterWebhookWithThirdPartyResponse> RegisterWebhookWithThirdPartyAsync(RegisterWebhookWithThirdPartyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetryStageExecution


        /// <summary>
        /// Resumes the pipeline execution by retrying the last failed actions in a stage. You
        /// can retry a stage immediately if any of the actions in the stage fail. When you retry,
        /// all actions that are still in progress continue working, and failed actions are triggered
        /// again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution service method.</param>
        /// 
        /// <returns>The response from the RetryStageExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the pipelineExecutionId associated
        /// with the request is out of date.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotRetryableException">
        /// Unable to retry. The pipeline structure or stage state might have changed while actions
        /// awaited retry, or the stage contains no failed actions.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        RetryStageExecutionResponse RetryStageExecution(RetryStageExecutionRequest request);



        /// <summary>
        /// Resumes the pipeline execution by retrying the last failed actions in a stage. You
        /// can retry a stage immediately if any of the actions in the stage fail. When you retry,
        /// all actions that are still in progress continue working, and failed actions are triggered
        /// again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryStageExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the pipelineExecutionId associated
        /// with the request is out of date.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotRetryableException">
        /// Unable to retry. The pipeline structure or stage state might have changed while actions
        /// awaited retry, or the stage contains no failed actions.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        Task<RetryStageExecutionResponse> RetryStageExecutionAsync(RetryStageExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartPipelineExecution


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to start.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        StartPipelineExecutionResponse StartPipelineExecution(string name);

        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request);


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to start.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopPipelineExecution


        /// <summary>
        /// Stops the specified pipeline execution. You choose to either stop the pipeline execution
        /// by completing in-progress actions without starting subsequent actions, or by abandoning
        /// in-progress actions. While completing or abandoning in-progress actions, the pipeline
        /// execution is in a <code>Stopping</code> state. After all in-progress actions are completed
        /// or abandoned, the pipeline execution is in a <code>Stopped</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.DuplicatedStopRequestException">
        /// The pipeline execution is already in a <code>Stopping</code> state. If you already
        /// chose to stop and wait, you cannot make that request again. You can choose to stop
        /// and abandon now, but be aware that this option can lead to failed tasks or out of
        /// sequence tasks. If you already chose to stop and abandon, you cannot make that request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotStoppableException">
        /// Unable to stop the pipeline execution. The execution might already be in a <code>Stopped</code>
        /// state, or it might no longer be in progress.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        StopPipelineExecutionResponse StopPipelineExecution(StopPipelineExecutionRequest request);



        /// <summary>
        /// Stops the specified pipeline execution. You choose to either stop the pipeline execution
        /// by completing in-progress actions without starting subsequent actions, or by abandoning
        /// in-progress actions. While completing or abandoning in-progress actions, the pipeline
        /// execution is in a <code>Stopping</code> state. After all in-progress actions are completed
        /// or abandoned, the pipeline execution is in a <code>Stopped</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.DuplicatedStopRequestException">
        /// The pipeline execution is already in a <code>Stopping</code> state. If you already
        /// chose to stop and wait, you cannot make that request again. You can choose to stop
        /// and abandon now, but be aware that this option can lead to failed tasks or out of
        /// sequence tasks. If you already chose to stop and abandon, you cannot make that request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotStoppableException">
        /// Unable to stop the pipeline execution. The execution might already be in a <code>Stopped</code>
        /// state, or it might no longer be in progress.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        Task<StopPipelineExecutionResponse> StopPipelineExecutionAsync(StopPipelineExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an AWS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from an AWS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidArnException">
        /// The specified resource ARN is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidTagsException">
        /// The specified resource tags are invalid.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ResourceNotFoundException">
        /// The resource was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure and <code>UpdatePipeline</code> to provide the full structure
        /// of the pipeline. Updating the pipeline increases the version number of the pipeline
        /// by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse UpdatePipeline(PipelineDeclaration pipeline);

        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure and <code>UpdatePipeline</code> to provide the full structure
        /// of the pipeline. Updating the pipeline increases the version number of the pipeline
        /// by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure and <code>UpdatePipeline</code> to provide the full structure
        /// of the pipeline. Updating the pipeline increases the version number of the pipeline
        /// by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        Task<UpdatePipelineResponse> UpdatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure and <code>UpdatePipeline</code> to provide the full structure
        /// of the pipeline. Updating the pipeline increases the version number of the pipeline
        /// by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}