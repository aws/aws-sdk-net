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
using System.Net;

using Amazon.CodePipeline.Model;
using Amazon.CodePipeline.Model.Internal.MarshallTransformations;
using Amazon.CodePipeline.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonCodePipelineMetadata();
        #region Constructors

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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that AWS CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
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
        public virtual AcknowledgeJobResponse AcknowledgeJob(string jobId, string nonce)
        {
            var request = new AcknowledgeJobRequest();
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeJob(request);
        }


        /// <summary>
        /// Returns information about a specified job and whether that job has been received by
        /// the job worker. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob service method.</param>
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
        public virtual AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcknowledgeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcknowledgeThirdPartyJob


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
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
        /// The specified nonce was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public virtual AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(string clientToken, string jobId, string nonce)
        {
            var request = new AcknowledgeThirdPartyJobRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeThirdPartyJob(request);
        }


        /// <summary>
        /// Confirms a job worker has received the specified job. Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob service method.</param>
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
        public virtual AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeThirdPartyJobResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcknowledgeThirdPartyJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomActionType


        /// <summary>
        /// Creates a new custom action that can be used in all pipelines associated with the
        /// AWS account. Only used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType service method.</param>
        /// 
        /// <returns>The response from the CreateCustomActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public virtual CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<CreateCustomActionTypeResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomActionTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="pipeline">Represents the structure of actions and stages to be performed in the pipeline. </param>
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
        public virtual CreatePipelineResponse CreatePipeline(PipelineDeclaration pipeline)
        {
            var request = new CreatePipelineRequest();
            request.Pipeline = pipeline;
            return CreatePipeline(request);
        }


        /// <summary>
        /// Creates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
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
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomActionType


        /// <summary>
        /// Marks a custom action as deleted. PollForJobs for the custom action will fail after
        /// the action is marked for deletion. Only used for custom actions.
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
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public virtual DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomActionTypeResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomActionTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to be deleted.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse DeletePipeline(string name)
        {
            var request = new DeletePipelineRequest();
            request.Name = name;
            return DeletePipeline(request);
        }


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// Deletes a previously created webhook by name. Deleting the webhook stops AWS CodePipeline
        /// from starting a pipeline every time an external event occurs. The API will return
        /// successfully when trying to delete a webhook that is already deleted. If a deleted
        /// webhook is re-created by calling PutWebhook with the same name, it will have a different
        /// URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return Invoke<DeleteWebhookResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterWebhookWithThirdParty


        /// <summary>
        /// Removes the connection between the webhook that was created by CodePipeline and the
        /// external tool with events to be detected. Currently only supported for webhooks that
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
        public virtual DeregisterWebhookWithThirdPartyResponse DeregisterWebhookWithThirdParty(DeregisterWebhookWithThirdPartyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<DeregisterWebhookWithThirdPartyResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterWebhookWithThirdPartyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableStageTransition


        /// <summary>
        /// Prevents artifacts in a pipeline from transitioning to the next stage in the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition service method.</param>
        /// 
        /// <returns>The response from the DisableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public virtual DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<DisableStageTransitionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableStageTransitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableStageTransition


        /// <summary>
        /// Enables artifacts in a pipeline to transition to a stage in a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition service method.</param>
        /// 
        /// <returns>The response from the EnableStageTransition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public virtual EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<EnableStageTransitionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableStageTransitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobDetails


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
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual GetJobDetailsResponse GetJobDetails(string jobId)
        {
            var request = new GetJobDetailsRequest();
            request.JobId = jobId;
            return GetJobDetails(request);
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
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails service method.</param>
        /// 
        /// <returns>The response from the GetJobDetails service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetJobDetailsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPipeline


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
        /// <param name="version">The version number of the pipeline. If you do not specify a version, defaults to the most current version.</param>
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
        public virtual GetPipelineResponse GetPipeline(string name, int version)
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            request.Version = version;
            return GetPipeline(request);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique under an Amazon Web Services (AWS) user account.</param>
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
        public virtual GetPipelineResponse GetPipeline(string name)
        {
            var request = new GetPipelineRequest();
            request.Name = name;
            return GetPipeline(request);
        }


        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
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
        public virtual GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPipelineResponse>(request, options, cancellationToken);
        }

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
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public virtual GetPipelineExecutionResponse GetPipelineExecution(GetPipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineState


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="name">The name of the pipeline about which you want to get information.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual GetPipelineStateResponse GetPipelineState(string name)
        {
            var request = new GetPipelineStateRequest();
            request.Name = name;
            return GetPipelineState(request);
        }


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState service method.</param>
        /// 
        /// <returns>The response from the GetPipelineState service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return Invoke<GetPipelineStateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPipelineStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetThirdPartyJobDetails


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
        public virtual GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(string clientToken, string jobId)
        {
            var request = new GetThirdPartyJobDetailsRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            return GetThirdPartyJobDetails(request);
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
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails service method.</param>
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
        public virtual GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyJobDetailsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetThirdPartyJobDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActionTypes


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
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
        public virtual ListActionTypesResponse ListActionTypes()
        {
            var request = new ListActionTypesRequest();
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="actionOwnerFilter">Filters the list of action types to those created by a specified entity.</param>
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
        public virtual ListActionTypesResponse ListActionTypes(ActionOwner actionOwnerFilter)
        {
            var request = new ListActionTypesRequest();
            request.ActionOwnerFilter = actionOwnerFilter;
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all AWS CodePipeline action types associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes service method.</param>
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
        public virtual ListActionTypesResponse ListActionTypes(ListActionTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return Invoke<ListActionTypesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActionTypesResponse>(request, options, cancellationToken);
        }

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
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public virtual ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPipelineExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
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
        public virtual ListPipelinesResponse ListPipelines()
        {
            var request = new ListPipelinesRequest();
            return ListPipelines(request);
        }


        /// <summary>
        /// Gets a summary of all of the pipelines associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
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
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebhooks


        /// <summary>
        /// Gets a listing of all the webhooks in this region for this account. The output lists
        /// all webhooks and includes the webhook URL and ARN, as well the configuration for each
        /// webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provided is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual ListWebhooksResponse ListWebhooks(ListWebhooksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return Invoke<ListWebhooksResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWebhooksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForJobs


        /// <summary>
        /// Returns information about any jobs for AWS CodePipeline to act upon. PollForJobs is
        /// only valid for action types with "Custom" in the owner field. If the action type contains
        /// "AWS" or "ThirdParty" in the owner field, the PollForJobs action returns an error.
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
        public virtual PollForJobsResponse PollForJobs(PollForJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return Invoke<PollForJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PollForJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForThirdPartyJobs


        /// <summary>
        /// Determines whether there are any third party jobs for a job worker to act on. Only
        /// used for partner actions.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, AWS CodePipeline returns temporary credentials for the Amazon
        /// S3 bucket used to store artifacts for the pipeline, if the action requires access
        /// to that Amazon S3 bucket for input or output artifacts.
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
        public virtual PollForThirdPartyJobsResponse PollForThirdPartyJobs(PollForThirdPartyJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return Invoke<PollForThirdPartyJobsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PollForThirdPartyJobsResponse>(request, options, cancellationToken);
        }

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
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public virtual PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutActionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return Invoke<PutActionRevisionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutActionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutActionRevisionResponse>(request, options, cancellationToken);
        }

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
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public virtual PutApprovalResultResponse PutApprovalResult(PutApprovalResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApprovalResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return Invoke<PutApprovalResultResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutApprovalResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApprovalResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutApprovalResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutJobFailureResult


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from PollForJobs.</param>
        /// <param name="failureDetails">The details about the failure of a job.</param>
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
        public virtual PutJobFailureResultResponse PutJobFailureResult(string jobId, FailureDetails failureDetails)
        {
            var request = new PutJobFailureResultRequest();
            request.JobId = jobId;
            request.FailureDetails = failureDetails;
            return PutJobFailureResult(request);
        }


        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult service method.</param>
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
        public virtual PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutJobFailureResultResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutJobFailureResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutJobSuccessResult


        /// <summary>
        /// Represents the success of a job as returned to the pipeline by a job worker. Only
        /// used for custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutJobSuccessResult service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidJobStateException">
        /// The specified job state was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.JobNotFoundException">
        /// The specified job was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public virtual PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutJobSuccessResultResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutJobSuccessResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobFailureResult


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from PollForThirdPartyJobs.</param>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="failureDetails">Represents information about failure details.</param>
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
        public virtual PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(string jobId, string clientToken, FailureDetails failureDetails)
        {
            var request = new PutThirdPartyJobFailureResultRequest();
            request.JobId = jobId;
            request.ClientToken = clientToken;
            request.FailureDetails = failureDetails;
            return PutThirdPartyJobFailureResult(request);
        }


        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult service method.</param>
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
        public virtual PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobFailureResultResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutThirdPartyJobFailureResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutThirdPartyJobSuccessResult


        /// <summary>
        /// Represents the success of a third party job as returned to the pipeline by a job worker.
        /// Only used for partner actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult service method.</param>
        /// 
        /// <returns>The response from the PutThirdPartyJobSuccessResult service method, as returned by CodePipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public virtual PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobSuccessResultResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutThirdPartyJobSuccessResultResponse>(request, options, cancellationToken);
        }

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
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        public virtual PutWebhookResponse PutWebhook(PutWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWebhookResponseUnmarshaller.Instance;

            return Invoke<PutWebhookResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutWebhookResponse>(request, options, cancellationToken);
        }

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
        public virtual RegisterWebhookWithThirdPartyResponse RegisterWebhookWithThirdParty(RegisterWebhookWithThirdPartyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<RegisterWebhookWithThirdPartyResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterWebhookWithThirdPartyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetryStageExecution


        /// <summary>
        /// Resumes the pipeline execution by retrying the last failed actions in a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution service method.</param>
        /// 
        /// <returns>The response from the RetryStageExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the pipelineExecutionId associated
        /// with the request is out of date.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The specified stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotRetryableException">
        /// The specified stage can't be retried because the pipeline structure or stage state
        /// changed after the stage was not completed; the stage contains no failed actions; one
        /// or more actions are still in progress; or another retry attempt is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public virtual RetryStageExecutionResponse RetryStageExecution(RetryStageExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryStageExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return Invoke<RetryStageExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryStageExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetryStageExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineExecution


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="name">The name of the pipeline to start.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual StartPipelineExecutionResponse StartPipelineExecution(string name)
        {
            var request = new StartPipelineExecutionRequest();
            request.Name = name;
            return StartPipelineExecution(request);
        }


        /// <summary>
        /// Starts the specified pipeline. Specifically, it begins processing the latest commit
        /// to the source location specified as part of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPipelineExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="pipeline">The name of the pipeline to be updated.</param>
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
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse UpdatePipeline(PipelineDeclaration pipeline)
        {
            var request = new UpdatePipelineRequest();
            request.Pipeline = pipeline;
            return UpdatePipeline(request);
        }


        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure in conjunction with UpdatePipeline to provide the full
        /// structure of the pipeline. Updating the pipeline increases the version number of the
        /// pipeline by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
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
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
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
        /// <exception cref="Amazon.CodePipeline.Model.LimitExceededException">
        /// The number of pipelines associated with the AWS account has exceeded the limit allowed
        /// for the account.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}