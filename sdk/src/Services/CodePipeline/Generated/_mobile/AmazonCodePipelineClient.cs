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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CodePipeline.Model;
using Amazon.CodePipeline.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodePipeline
{
    /// <summary>
    /// Implementation for accessing CodePipeline
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
    public partial class AmazonCodePipelineClient : AmazonServiceClient, IAmazonCodePipeline
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodePipelineClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodePipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Credentials and an
        /// AmazonCodePipelineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(AWSCredentials credentials, AmazonCodePipelineConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodePipelineConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodePipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodePipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodePipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodePipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodePipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodePipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AcknowledgeJob

        internal AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request)
        {
            var marshaller = new AcknowledgeJobRequestMarshaller();
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AcknowledgeJobResponse> AcknowledgeJobAsync(AcknowledgeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcknowledgeJobRequestMarshaller();
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AcknowledgeThirdPartyJob

        internal AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request)
        {
            var marshaller = new AcknowledgeThirdPartyJobRequestMarshaller();
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeThirdPartyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(AcknowledgeThirdPartyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcknowledgeThirdPartyJobRequestMarshaller();
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomActionType

        internal CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request)
        {
            var marshaller = new CreateCustomActionTypeRequestMarshaller();
            var unmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<CreateCustomActionTypeRequest,CreateCustomActionTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateCustomActionTypeResponse> CreateCustomActionTypeAsync(CreateCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomActionTypeRequestMarshaller();
            var unmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomActionTypeRequest,CreateCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline

        internal CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomActionType

        internal DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request)
        {
            var marshaller = new DeleteCustomActionTypeRequestMarshaller();
            var unmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomActionTypeRequest,DeleteCustomActionTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteCustomActionTypeResponse> DeleteCustomActionTypeAsync(DeleteCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomActionTypeRequestMarshaller();
            var unmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomActionTypeRequest,DeleteCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline

        internal DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableStageTransition

        internal DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request)
        {
            var marshaller = new DisableStageTransitionRequestMarshaller();
            var unmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<DisableStageTransitionRequest,DisableStageTransitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableStageTransitionResponse> DisableStageTransitionAsync(DisableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableStageTransitionRequestMarshaller();
            var unmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableStageTransitionRequest,DisableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableStageTransition

        internal EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request)
        {
            var marshaller = new EnableStageTransitionRequestMarshaller();
            var unmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<EnableStageTransitionRequest,EnableStageTransitionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableStageTransitionResponse> EnableStageTransitionAsync(EnableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableStageTransitionRequestMarshaller();
            var unmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableStageTransitionRequest,EnableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobDetails

        internal GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {
            var marshaller = new GetJobDetailsRequestMarshaller();
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetJobDetailsResponse> GetJobDetailsAsync(GetJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobDetailsRequestMarshaller();
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipeline

        internal GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var marshaller = new GetPipelineRequestMarshaller();
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineRequest,GetPipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineRequestMarshaller();
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineRequest,GetPipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineState

        internal GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request)
        {
            var marshaller = new GetPipelineStateRequestMarshaller();
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return Invoke<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPipelineStateResponse> GetPipelineStateAsync(GetPipelineStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineStateRequestMarshaller();
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetThirdPartyJobDetails

        internal GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request)
        {
            var marshaller = new GetThirdPartyJobDetailsRequestMarshaller();
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThirdPartyJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(GetThirdPartyJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetThirdPartyJobDetailsRequestMarshaller();
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActionTypes

        internal ListActionTypesResponse ListActionTypes(ListActionTypesRequest request)
        {
            var marshaller = new ListActionTypesRequestMarshaller();
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return Invoke<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListActionTypesResponse> ListActionTypesAsync(ListActionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListActionTypesRequestMarshaller();
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines

        internal ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForJobs

        internal PollForJobsResponse PollForJobs(PollForJobsRequest request)
        {
            var marshaller = new PollForJobsRequestMarshaller();
            var unmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return Invoke<PollForJobsRequest,PollForJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PollForJobsResponse> PollForJobsAsync(PollForJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForJobsRequestMarshaller();
            var unmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForJobsRequest,PollForJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForThirdPartyJobs

        internal PollForThirdPartyJobsResponse PollForThirdPartyJobs(PollForThirdPartyJobsRequest request)
        {
            var marshaller = new PollForThirdPartyJobsRequestMarshaller();
            var unmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return Invoke<PollForThirdPartyJobsRequest,PollForThirdPartyJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForThirdPartyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PollForThirdPartyJobsResponse> PollForThirdPartyJobsAsync(PollForThirdPartyJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForThirdPartyJobsRequestMarshaller();
            var unmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForThirdPartyJobsRequest,PollForThirdPartyJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutActionRevision

        internal PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request)
        {
            var marshaller = new PutActionRevisionRequestMarshaller();
            var unmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return Invoke<PutActionRevisionRequest,PutActionRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutActionRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutActionRevisionResponse> PutActionRevisionAsync(PutActionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutActionRevisionRequestMarshaller();
            var unmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<PutActionRevisionRequest,PutActionRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobFailureResult

        internal PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request)
        {
            var marshaller = new PutJobFailureResultRequestMarshaller();
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutJobFailureResultResponse> PutJobFailureResultAsync(PutJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutJobFailureResultRequestMarshaller();
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobSuccessResult

        internal PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request)
        {
            var marshaller = new PutJobSuccessResultRequestMarshaller();
            var unmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutJobSuccessResultRequest,PutJobSuccessResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutJobSuccessResultResponse> PutJobSuccessResultAsync(PutJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutJobSuccessResultRequestMarshaller();
            var unmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobSuccessResultRequest,PutJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobFailureResult

        internal PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request)
        {
            var marshaller = new PutThirdPartyJobFailureResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(PutThirdPartyJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutThirdPartyJobFailureResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobSuccessResult

        internal PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request)
        {
            var marshaller = new PutThirdPartyJobSuccessResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobSuccessResultRequest,PutThirdPartyJobSuccessResultResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutThirdPartyJobSuccessResultResponse> PutThirdPartyJobSuccessResultAsync(PutThirdPartyJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutThirdPartyJobSuccessResultRequestMarshaller();
            var unmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobSuccessResultRequest,PutThirdPartyJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineExecution

        internal StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var marshaller = new StartPipelineExecutionRequestMarshaller();
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartPipelineExecutionRequestMarshaller();
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline

        internal UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}