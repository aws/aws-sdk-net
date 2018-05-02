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
    /// AWS CodePipeline 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the AWS CodePipeline API Reference. This guide provides descriptions of the
    /// actions and data types for AWS CodePipeline. Some functionality for your pipeline
    /// is only configurable through the API. For additional information, see the <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/welcome.html">AWS
    /// CodePipeline User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodePipeline API to work with pipelines, stages, actions, and
    /// transitions, as described below.
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
    ///  <a>CreatePipeline</a>, which creates a uniquely-named pipeline.
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
    ///  <a>StartPipelineExecution</a>, which runs the the most recent revision of an artifact
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
    /// complete before the next stage begins. A stage will result in success or failure.
    /// If a stage fails, then the pipeline stops at that stage and will remain stopped until
    /// either a new version of an artifact appears in the source location, or a user takes
    /// action to re-run the most recent artifact through the pipeline. You can call <a>GetPipelineState</a>,
    /// which displays the status of a pipeline, including the status of stages in the pipeline,
    /// or <a>GetPipeline</a>, which returns the entire structure of the pipeline, including
    /// the stages of that pipeline. For more information about the structure of stages and
    /// actions, also refer to the <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-structure.html">AWS
    /// CodePipeline Pipeline Structure Reference</a>.
    /// </para>
    ///  
    /// <para>
    /// Pipeline stages include <i>actions</i>, which are categorized into categories such
    /// as source or build actions performed within a stage of a pipeline. For example, you
    /// can use a source action to import artifacts into a pipeline from a source such as
    /// Amazon S3. Like stages, you do not work with actions directly in most cases, but you
    /// do define and interact with actions when working with pipeline operations such as
    /// <a>CreatePipeline</a> and <a>GetPipelineState</a>. Valid action categories are:
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
    /// with AWS CodePipeline, the expected sequence varies from the standard API user. In
    /// order to integrate with AWS CodePipeline, developers will need to work with the following
    /// items:
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
    /// job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetJobDetails</a>, which returns the details of a job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForJobs</a>, which determines whether there are any jobs to act upon, 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutJobFailureResult</a>, which provides details of a job failure, and
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
    /// the specified job,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetThirdPartyJobDetails</a>, which requests the details of a job for a partner
    /// action,
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PollForThirdPartyJobs</a>, which determines whether there are any jobs to act
    /// upon, 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobFailureResult</a>, which provides details of a job failure, and
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutThirdPartyJobSuccessResult</a>, which provides details of a job success.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodePipelineClient : AmazonServiceClient, IAmazonCodePipeline
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodePipelineClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodePipelineConfig()) { }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodePipelineClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodePipelineConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodePipelineClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodePipelineClient Configuration Object</param>
        public AmazonCodePipelineClient(AmazonCodePipelineConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AcknowledgeJob

        internal virtual AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request)
        {
            var marshaller = AcknowledgeJobRequestMarshaller.Instance;
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcknowledgeJob service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNonceException">
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public virtual Task<AcknowledgeJobResponse> AcknowledgeJobAsync(string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AcknowledgeJobRequest();
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeJobAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public virtual Task<AcknowledgeJobResponse> AcknowledgeJobAsync(AcknowledgeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcknowledgeJobRequestMarshaller.Instance;
            var unmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeJobRequest,AcknowledgeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AcknowledgeThirdPartyJob

        internal virtual AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request)
        {
            var marshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
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
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public virtual Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(string clientToken, string jobId, string nonce, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AcknowledgeThirdPartyJobRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeThirdPartyJobAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public virtual Task<AcknowledgeThirdPartyJobResponse> AcknowledgeThirdPartyJobAsync(AcknowledgeThirdPartyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            var unmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return InvokeAsync<AcknowledgeThirdPartyJobRequest,AcknowledgeThirdPartyJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomActionType

        internal virtual CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request)
        {
            var marshaller = CreateCustomActionTypeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public virtual Task<CreateCustomActionTypeResponse> CreateCustomActionTypeAsync(CreateCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCustomActionTypeRequestMarshaller.Instance;
            var unmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomActionTypeRequest,CreateCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNameInUseException">
        /// The specified pipeline name is already in use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePipelineRequest();
            request.Pipeline = pipeline;
            return CreatePipelineAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomActionType

        internal virtual DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request)
        {
            var marshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public virtual Task<DeleteCustomActionTypeResponse> DeleteCustomActionTypeAsync(DeleteCustomActionTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomActionTypeRequest,DeleteCustomActionTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeletePipelineRequest();
            request.Name = name;
            return DeletePipelineAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebhook

        internal virtual DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request)
        {
            var marshaller = DeleteWebhookRequestMarshaller.Instance;
            var unmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return Invoke<DeleteWebhookRequest,DeleteWebhookResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteWebhookRequestMarshaller.Instance;
            var unmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWebhookRequest,DeleteWebhookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterWebhookWithThirdParty

        internal virtual DeregisterWebhookWithThirdPartyResponse DeregisterWebhookWithThirdParty(DeregisterWebhookWithThirdPartyRequest request)
        {
            var marshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            var unmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<DeregisterWebhookWithThirdPartyRequest,DeregisterWebhookWithThirdPartyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWebhookWithThirdParty operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeregisterWebhookWithThirdParty">REST API Reference for DeregisterWebhookWithThirdParty Operation</seealso>
        public virtual Task<DeregisterWebhookWithThirdPartyResponse> DeregisterWebhookWithThirdPartyAsync(DeregisterWebhookWithThirdPartyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            var unmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterWebhookWithThirdPartyRequest,DeregisterWebhookWithThirdPartyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableStageTransition

        internal virtual DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request)
        {
            var marshaller = DisableStageTransitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public virtual Task<DisableStageTransitionResponse> DisableStageTransitionAsync(DisableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableStageTransitionRequestMarshaller.Instance;
            var unmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableStageTransitionRequest,DisableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableStageTransition

        internal virtual EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request)
        {
            var marshaller = EnableStageTransitionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public virtual Task<EnableStageTransitionResponse> EnableStageTransitionAsync(EnableStageTransitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableStageTransitionRequestMarshaller.Instance;
            var unmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableStageTransitionRequest,EnableStageTransitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobDetails

        internal virtual GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {
            var marshaller = GetJobDetailsRequestMarshaller.Instance;
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about a job. Only used for custom actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
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
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual Task<GetJobDetailsResponse> GetJobDetailsAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetJobDetailsRequest();
            request.JobId = jobId;
            return GetJobDetailsAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual Task<GetJobDetailsResponse> GetJobDetailsAsync(GetJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetJobDetailsRequestMarshaller.Instance;
            var unmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobDetailsRequest,GetJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipeline

        internal virtual GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var marshaller = GetPipelineRequestMarshaller.Instance;
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineRequest,GetPipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the most current version.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual Task<GetPipelineResponse> GetPipelineAsync(string name, int version, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            request.Version = version;
            return GetPipelineAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The specified pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual Task<GetPipelineResponse> GetPipelineAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            return GetPipelineAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPipelineRequestMarshaller.Instance;
            var unmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineRequest,GetPipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineExecution

        internal virtual GetPipelineExecutionResponse GetPipelineExecution(GetPipelineExecutionRequest request)
        {
            var marshaller = GetPipelineExecutionRequestMarshaller.Instance;
            var unmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineExecutionRequest,GetPipelineExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public virtual Task<GetPipelineExecutionResponse> GetPipelineExecutionAsync(GetPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPipelineExecutionRequestMarshaller.Instance;
            var unmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineExecutionRequest,GetPipelineExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineState

        internal virtual GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request)
        {
            var marshaller = GetPipelineStateRequestMarshaller.Instance;
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return Invoke<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual Task<GetPipelineStateResponse> GetPipelineStateAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetPipelineStateRequest();
            request.Name = name;
            return GetPipelineStateAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual Task<GetPipelineStateResponse> GetPipelineStateAsync(GetPipelineStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPipelineStateRequestMarshaller.Instance;
            var unmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineStateRequest,GetPipelineStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetThirdPartyJobDetails

        internal virtual GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request)
        {
            var marshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Requests the details of a job for a third party action. Only used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts. Additionally, this API returns
        /// any secret values defined for the action.
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
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public virtual Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(string clientToken, string jobId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetThirdPartyJobDetailsRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            return GetThirdPartyJobDetailsAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public virtual Task<GetThirdPartyJobDetailsResponse> GetThirdPartyJobDetailsAsync(GetThirdPartyJobDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            var unmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetThirdPartyJobDetailsRequest,GetThirdPartyJobDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActionTypes

        internal virtual ListActionTypesResponse ListActionTypes(ListActionTypesRequest request)
        {
            var marshaller = ListActionTypesRequestMarshaller.Instance;
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return Invoke<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, unmarshaller);
        }


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
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public virtual Task<ListActionTypesResponse> ListActionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListActionTypesRequest();
            return ListActionTypesAsync(request, cancellationToken);
        }


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
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public virtual Task<ListActionTypesResponse> ListActionTypesAsync(ActionOwner actionOwnerFilter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListActionTypesRequest();
            request.ActionOwnerFilter = actionOwnerFilter;
            return ListActionTypesAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public virtual Task<ListActionTypesResponse> ListActionTypesAsync(ListActionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListActionTypesRequestMarshaller.Instance;
            var unmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActionTypesRequest,ListActionTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelineExecutions

        internal virtual ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var marshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsRequest,ListPipelineExecutionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public virtual Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            var unmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineExecutionsRequest,ListPipelineExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines

        internal virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, unmarshaller);
        }


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
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPipelinesRequest();
            return ListPipelinesAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListWebhooks

        internal virtual ListWebhooksResponse ListWebhooks(ListWebhooksRequest request)
        {
            var marshaller = ListWebhooksRequestMarshaller.Instance;
            var unmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return Invoke<ListWebhooksRequest,ListWebhooksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWebhooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListWebhooksRequestMarshaller.Instance;
            var unmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebhooksRequest,ListWebhooksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForJobs

        internal virtual PollForJobsResponse PollForJobs(PollForJobsRequest request)
        {
            var marshaller = PollForJobsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        public virtual Task<PollForJobsResponse> PollForJobsAsync(PollForJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PollForJobsRequestMarshaller.Instance;
            var unmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForJobsRequest,PollForJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForThirdPartyJobs

        internal virtual PollForThirdPartyJobsResponse PollForThirdPartyJobs(PollForThirdPartyJobsRequest request)
        {
            var marshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        public virtual Task<PollForThirdPartyJobsResponse> PollForThirdPartyJobsAsync(PollForThirdPartyJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
            var unmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return InvokeAsync<PollForThirdPartyJobsRequest,PollForThirdPartyJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutActionRevision

        internal virtual PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request)
        {
            var marshaller = PutActionRevisionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public virtual Task<PutActionRevisionResponse> PutActionRevisionAsync(PutActionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutActionRevisionRequestMarshaller.Instance;
            var unmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<PutActionRevisionRequest,PutActionRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutApprovalResult

        internal virtual PutApprovalResultResponse PutApprovalResult(PutApprovalResultRequest request)
        {
            var marshaller = PutApprovalResultRequestMarshaller.Instance;
            var unmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return Invoke<PutApprovalResultRequest,PutApprovalResultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutApprovalResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public virtual Task<PutApprovalResultResponse> PutApprovalResultAsync(PutApprovalResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutApprovalResultRequestMarshaller.Instance;
            var unmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutApprovalResultRequest,PutApprovalResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobFailureResult

        internal virtual PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request)
        {
            var marshaller = PutJobFailureResultRequestMarshaller.Instance;
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from PollForJobs.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobFailureResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public virtual Task<PutJobFailureResultResponse> PutJobFailureResultAsync(string jobId, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutJobFailureResultRequest();
            request.JobId = jobId;
            request.FailureDetails = failureDetails;
            return PutJobFailureResultAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public virtual Task<PutJobFailureResultResponse> PutJobFailureResultAsync(PutJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutJobFailureResultRequestMarshaller.Instance;
            var unmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobFailureResultRequest,PutJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutJobSuccessResult

        internal virtual PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request)
        {
            var marshaller = PutJobSuccessResultRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public virtual Task<PutJobSuccessResultResponse> PutJobSuccessResultAsync(PutJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutJobSuccessResultRequestMarshaller.Instance;
            var unmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutJobSuccessResultRequest,PutJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobFailureResult

        internal virtual PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request)
        {
            var marshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from PollForThirdPartyJobs.</param>
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
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public virtual Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(string jobId, string clientToken, FailureDetails failureDetails, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutThirdPartyJobFailureResultRequest();
            request.JobId = jobId;
            request.ClientToken = clientToken;
            request.FailureDetails = failureDetails;
            return PutThirdPartyJobFailureResultAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public virtual Task<PutThirdPartyJobFailureResultResponse> PutThirdPartyJobFailureResultAsync(PutThirdPartyJobFailureResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            var unmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobFailureResultRequest,PutThirdPartyJobFailureResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobSuccessResult

        internal virtual PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request)
        {
            var marshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public virtual Task<PutThirdPartyJobSuccessResultResponse> PutThirdPartyJobSuccessResultAsync(PutThirdPartyJobSuccessResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
            var unmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return InvokeAsync<PutThirdPartyJobSuccessResultRequest,PutThirdPartyJobSuccessResultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutWebhook

        internal virtual PutWebhookResponse PutWebhook(PutWebhookRequest request)
        {
            var marshaller = PutWebhookRequestMarshaller.Instance;
            var unmarshaller = PutWebhookResponseUnmarshaller.Instance;

            return Invoke<PutWebhookRequest,PutWebhookResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWebhook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        public virtual Task<PutWebhookResponse> PutWebhookAsync(PutWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutWebhookRequestMarshaller.Instance;
            var unmarshaller = PutWebhookResponseUnmarshaller.Instance;

            return InvokeAsync<PutWebhookRequest,PutWebhookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterWebhookWithThirdParty

        internal virtual RegisterWebhookWithThirdPartyResponse RegisterWebhookWithThirdParty(RegisterWebhookWithThirdPartyRequest request)
        {
            var marshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            var unmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<RegisterWebhookWithThirdPartyRequest,RegisterWebhookWithThirdPartyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWebhookWithThirdParty operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RegisterWebhookWithThirdParty">REST API Reference for RegisterWebhookWithThirdParty Operation</seealso>
        public virtual Task<RegisterWebhookWithThirdPartyResponse> RegisterWebhookWithThirdPartyAsync(RegisterWebhookWithThirdPartyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            var unmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterWebhookWithThirdPartyRequest,RegisterWebhookWithThirdPartyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetryStageExecution

        internal virtual RetryStageExecutionResponse RetryStageExecution(RetryStageExecutionRequest request)
        {
            var marshaller = RetryStageExecutionRequestMarshaller.Instance;
            var unmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return Invoke<RetryStageExecutionRequest,RetryStageExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetryStageExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public virtual Task<RetryStageExecutionResponse> RetryStageExecutionAsync(RetryStageExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RetryStageExecutionRequestMarshaller.Instance;
            var unmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<RetryStageExecutionRequest,RetryStageExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineExecution

        internal virtual StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var marshaller = StartPipelineExecutionRequestMarshaller.Instance;
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, unmarshaller);
        }


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
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new StartPipelineExecutionRequest();
            request.Name = name;
            return StartPipelineExecutionAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartPipelineExecutionRequestMarshaller.Instance;
            var unmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineExecutionRequest,StartPipelineExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline

        internal virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidActionDeclarationException">
        /// The specified action declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidBlockerDeclarationException">
        /// Reserved for future use.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStageDeclarationException">
        /// The specified stage declaration was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidStructureException">
        /// The specified structure was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(PipelineDeclaration pipeline, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdatePipelineRequest();
            request.Pipeline = pipeline;
            return UpdatePipelineAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}