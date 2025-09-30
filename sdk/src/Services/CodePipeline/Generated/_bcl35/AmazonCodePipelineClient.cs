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
using System.Collections.Generic;
using System.Net;

using Amazon.CodePipeline.Model;
using Amazon.CodePipeline.Model.Internal.MarshallTransformations;
using Amazon.CodePipeline.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CodePipeline
{
    /// <summary>
    /// <para>Implementation for accessing CodePipeline</para>
    ///
    /// CodePipeline 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the CodePipeline API Reference. This guide provides descriptions of the actions
    /// and data types for CodePipeline. Some functionality for your pipeline can only be
    /// configured through the API. For more information, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/welcome.html">CodePipeline
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use the CodePipeline API to work with pipelines, stages, actions, and transitions.
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
    /// actions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-structure.html">CodePipeline
    /// Pipeline Structure Reference</a>.
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
    ///  </li> <li> 
    /// <para>
    /// Compute
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
    ///  <b>Using the API to integrate with CodePipeline</b> 
    /// </para>
    ///  
    /// <para>
    /// For third-party integrators or developers who want to create their own integrations
    /// with CodePipeline, the expected sequence varies from the standard API user. To integrate
    /// with CodePipeline, developers need to work with the following items:
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
    /// and integrated into CodePipeline. Partner actions are created by members of the Amazon
    /// Web Services Partner Network.
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
    public partial class AmazonCodePipelineClient : AmazonServiceClient, IAmazonCodePipeline
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodePipelineMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICodePipelinePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodePipelinePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodePipelinePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodePipelineEndpointResolver());
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
        /// the job worker. Used for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job for which you want to confirm receipt.</param>
        /// <param name="nonce">A system-generated random number that CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response of the <a>PollForJobs</a> request that returned this job.</param>
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
        public virtual AcknowledgeJobResponse AcknowledgeJob(string jobId, string nonce)
        {
            var request = new AcknowledgeJobRequest();
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeJob(request);
        }


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
        public virtual AcknowledgeJobResponse AcknowledgeJob(AcknowledgeJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcknowledgeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeJob operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcknowledgeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public virtual IAsyncResult BeginAcknowledgeJob(AcknowledgeJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcknowledgeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcknowledgeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcknowledgeJob.</param>
        /// 
        /// <returns>Returns a  AcknowledgeJobResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeJob">REST API Reference for AcknowledgeJob Operation</seealso>
        public virtual AcknowledgeJobResponse EndAcknowledgeJob(IAsyncResult asyncResult)
        {
            return EndInvoke<AcknowledgeJobResponse>(asyncResult);
        }

        #endregion
        
        #region  AcknowledgeThirdPartyJob

        /// <summary>
        /// Confirms a job worker has received the specified job. Used for partner actions only.
        /// </summary>
        /// <param name="clientToken">The clientToken portion of the clientId and clientToken pair used to verify that the calling entity is allowed access to the job and its details.</param>
        /// <param name="jobId">The unique system-generated ID of the job.</param>
        /// <param name="nonce">A system-generated random number that CodePipeline uses to ensure that the job is being worked on by only one job worker. Get this number from the response to a <a>GetThirdPartyJobDetails</a> request.</param>
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
        public virtual AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(string clientToken, string jobId, string nonce)
        {
            var request = new AcknowledgeThirdPartyJobRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            request.Nonce = nonce;
            return AcknowledgeThirdPartyJob(request);
        }


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
        public virtual AcknowledgeThirdPartyJobResponse AcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return Invoke<AcknowledgeThirdPartyJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeThirdPartyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeThirdPartyJob operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcknowledgeThirdPartyJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public virtual IAsyncResult BeginAcknowledgeThirdPartyJob(AcknowledgeThirdPartyJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcknowledgeThirdPartyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcknowledgeThirdPartyJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcknowledgeThirdPartyJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcknowledgeThirdPartyJob.</param>
        /// 
        /// <returns>Returns a  AcknowledgeThirdPartyJobResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/AcknowledgeThirdPartyJob">REST API Reference for AcknowledgeThirdPartyJob Operation</seealso>
        public virtual AcknowledgeThirdPartyJobResponse EndAcknowledgeThirdPartyJob(IAsyncResult asyncResult)
        {
            return EndInvoke<AcknowledgeThirdPartyJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomActionType

        /// <summary>
        /// Creates a new custom action that can be used in all pipelines associated with the
        /// Amazon Web Services account. Only used for custom actions.
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.TooManyTagsException">
        /// The tags limit for a resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public virtual CreateCustomActionTypeResponse CreateCustomActionType(CreateCustomActionTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<CreateCustomActionTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomActionType operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomActionType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomActionType(CreateCustomActionTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomActionType.</param>
        /// 
        /// <returns>Returns a  CreateCustomActionTypeResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreateCustomActionType">REST API Reference for CreateCustomActionType Operation</seealso>
        public virtual CreateCustomActionTypeResponse EndCreateCustomActionType(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomActionTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePipeline

        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <c>artifactStore</c> or <c>artifactStores</c>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <c>artifactStores</c>.
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
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
        public virtual CreatePipelineResponse CreatePipeline(PipelineDeclaration pipeline)
        {
            var request = new CreatePipelineRequest();
            request.Pipeline = pipeline;
            return CreatePipeline(request);
        }


        /// <summary>
        /// Creates a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// In the pipeline structure, you must include either <c>artifactStore</c> or <c>artifactStores</c>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <c>artifactStores</c>.
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
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
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomActionType

        /// <summary>
        /// Marks a custom action as deleted. <c>PollForJobs</c> for the custom action fails after
        /// the action is marked for deletion. Used for custom actions only.
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
        public virtual DeleteCustomActionTypeResponse DeleteCustomActionType(DeleteCustomActionTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomActionTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomActionType operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomActionType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomActionType(DeleteCustomActionTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomActionType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomActionType.</param>
        /// 
        /// <returns>Returns a  DeleteCustomActionTypeResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteCustomActionType">REST API Reference for DeleteCustomActionType Operation</seealso>
        public virtual DeleteCustomActionTypeResponse EndDeleteCustomActionType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomActionTypeResponse>(asyncResult);
        }

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
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentModificationException">
        /// Unable to modify the tag due to a simultaneous update request.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWebhook

        /// <summary>
        /// Deletes a previously created webhook by name. Deleting the webhook stops CodePipeline
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
        public virtual DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return Invoke<DeleteWebhookResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual IAsyncResult BeginDeleteWebhook(DeleteWebhookRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebhook.</param>
        /// 
        /// <returns>Returns a  DeleteWebhookResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual DeleteWebhookResponse EndDeleteWebhook(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWebhookResponse>(asyncResult);
        }

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
        public virtual DeregisterWebhookWithThirdPartyResponse DeregisterWebhookWithThirdParty(DeregisterWebhookWithThirdPartyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<DeregisterWebhookWithThirdPartyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWebhookWithThirdParty operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterWebhookWithThirdParty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeregisterWebhookWithThirdParty">REST API Reference for DeregisterWebhookWithThirdParty Operation</seealso>
        public virtual IAsyncResult BeginDeregisterWebhookWithThirdParty(DeregisterWebhookWithThirdPartyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterWebhookWithThirdParty.</param>
        /// 
        /// <returns>Returns a  DeregisterWebhookWithThirdPartyResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DeregisterWebhookWithThirdParty">REST API Reference for DeregisterWebhookWithThirdParty Operation</seealso>
        public virtual DeregisterWebhookWithThirdPartyResponse EndDeregisterWebhookWithThirdParty(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterWebhookWithThirdPartyResponse>(asyncResult);
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
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public virtual DisableStageTransitionResponse DisableStageTransition(DisableStageTransitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<DisableStageTransitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableStageTransition operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableStageTransition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public virtual IAsyncResult BeginDisableStageTransition(DisableStageTransitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableStageTransitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableStageTransition.</param>
        /// 
        /// <returns>Returns a  DisableStageTransitionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/DisableStageTransition">REST API Reference for DisableStageTransition Operation</seealso>
        public virtual DisableStageTransitionResponse EndDisableStageTransition(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableStageTransitionResponse>(asyncResult);
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
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public virtual EnableStageTransitionResponse EnableStageTransition(EnableStageTransitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return Invoke<EnableStageTransitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableStageTransition operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableStageTransition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public virtual IAsyncResult BeginEnableStageTransition(EnableStageTransitionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableStageTransitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableStageTransitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableStageTransition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableStageTransition.</param>
        /// 
        /// <returns>Returns a  EnableStageTransitionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/EnableStageTransition">REST API Reference for EnableStageTransition Operation</seealso>
        public virtual EnableStageTransitionResponse EndEnableStageTransition(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableStageTransitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetActionType

        /// <summary>
        /// Returns information about an action type created for an external provider, where the
        /// action is to be used by customers of the external provider. The action can be created
        /// with any supported integration model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActionType service method.</param>
        /// 
        /// <returns>The response from the GetActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetActionType">REST API Reference for GetActionType Operation</seealso>
        public virtual GetActionTypeResponse GetActionType(GetActionTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionTypeResponseUnmarshaller.Instance;

            return Invoke<GetActionTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActionType operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetActionType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetActionType">REST API Reference for GetActionType Operation</seealso>
        public virtual IAsyncResult BeginGetActionType(GetActionTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetActionType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActionType.</param>
        /// 
        /// <returns>Returns a  GetActionTypeResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetActionType">REST API Reference for GetActionType Operation</seealso>
        public virtual GetActionTypeResponse EndGetActionType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetActionTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobDetails

        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts. This API also returns any secret values defined
        /// for the action.
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
        public virtual GetJobDetailsResponse GetJobDetails(string jobId)
        {
            var request = new GetJobDetailsRequest();
            request.JobId = jobId;
            return GetJobDetails(request);
        }


        /// <summary>
        /// Returns information about a job. Used for custom actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts. This API also returns any secret values defined
        /// for the action.
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
        public virtual GetJobDetailsResponse GetJobDetails(GetJobDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetJobDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDetails operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual IAsyncResult BeginGetJobDetails(GetJobDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobDetails.</param>
        /// 
        /// <returns>Returns a  GetJobDetailsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetJobDetails">REST API Reference for GetJobDetails Operation</seealso>
        public virtual GetJobDetailsResponse EndGetJobDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPipeline

        /// <summary>
        /// Returns the metadata, structure, stages, and actions of a pipeline. Can be used to
        /// return the entire structure of a pipeline in JSON format, which can then be modified
        /// and used to update the pipeline structure with <a>UpdatePipeline</a>.
        /// </summary>
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique in an Amazon Web Services account.</param>
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
        /// <param name="name">The name of the pipeline for which you want to get information. Pipeline names must be unique in an Amazon Web Services account.</param>
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
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineVersionNotFoundException">
        /// The pipeline version was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual IAsyncResult BeginGetPipeline(GetPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipeline.</param>
        /// 
        /// <returns>Returns a  GetPipelineResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual GetPipelineResponse EndGetPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineResponse>(asyncResult);
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
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public virtual GetPipelineExecutionResponse GetPipelineExecution(GetPipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineExecution operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public virtual IAsyncResult BeginGetPipelineExecution(GetPipelineExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineExecution.</param>
        /// 
        /// <returns>Returns a  GetPipelineExecutionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineExecution">REST API Reference for GetPipelineExecution Operation</seealso>
        public virtual GetPipelineExecutionResponse EndGetPipelineExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPipelineState

        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <c>revisionId</c> and <c>revisionUrl</c> fields indicate the
        /// source revision information, such as the commit ID, for the current state.
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
        public virtual GetPipelineStateResponse GetPipelineState(string name)
        {
            var request = new GetPipelineStateRequest();
            request.Name = name;
            return GetPipelineState(request);
        }


        /// <summary>
        /// Returns information about the state of a pipeline, including the stages and actions.
        /// 
        ///  <note> 
        /// <para>
        /// Values returned in the <c>revisionId</c> and <c>revisionUrl</c> fields indicate the
        /// source revision information, such as the commit ID, for the current state.
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
        public virtual GetPipelineStateResponse GetPipelineState(GetPipelineStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return Invoke<GetPipelineStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineState operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual IAsyncResult BeginGetPipelineState(GetPipelineStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineState.</param>
        /// 
        /// <returns>Returns a  GetPipelineStateResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetPipelineState">REST API Reference for GetPipelineState Operation</seealso>
        public virtual GetPipelineStateResponse EndGetPipelineState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetThirdPartyJobDetails

        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts. This API also returns any secret values defined
        /// for the action.
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
        public virtual GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(string clientToken, string jobId)
        {
            var request = new GetThirdPartyJobDetailsRequest();
            request.ClientToken = clientToken;
            request.JobId = jobId;
            return GetThirdPartyJobDetails(request);
        }


        /// <summary>
        /// Requests the details of a job for a third party action. Used for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts. This API also returns any secret values defined
        /// for the action.
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
        public virtual GetThirdPartyJobDetailsResponse GetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyJobDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThirdPartyJobDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyJobDetails operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThirdPartyJobDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public virtual IAsyncResult BeginGetThirdPartyJobDetails(GetThirdPartyJobDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThirdPartyJobDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyJobDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetThirdPartyJobDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThirdPartyJobDetails.</param>
        /// 
        /// <returns>Returns a  GetThirdPartyJobDetailsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/GetThirdPartyJobDetails">REST API Reference for GetThirdPartyJobDetails Operation</seealso>
        public virtual GetThirdPartyJobDetailsResponse EndGetThirdPartyJobDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetThirdPartyJobDetailsResponse>(asyncResult);
        }

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
        public virtual ListActionExecutionsResponse ListActionExecutions(ListActionExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListActionExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionExecutions operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActionExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionExecutions">REST API Reference for ListActionExecutions Operation</seealso>
        public virtual IAsyncResult BeginListActionExecutions(ListActionExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActionExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActionExecutions.</param>
        /// 
        /// <returns>Returns a  ListActionExecutionsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionExecutions">REST API Reference for ListActionExecutions Operation</seealso>
        public virtual ListActionExecutionsResponse EndListActionExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActionExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListActionTypes

        /// <summary>
        /// Gets a summary of all CodePipeline action types associated with your account.
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
        public virtual ListActionTypesResponse ListActionTypes()
        {
            var request = new ListActionTypesRequest();
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all CodePipeline action types associated with your account.
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
        public virtual ListActionTypesResponse ListActionTypes(ActionOwner actionOwnerFilter)
        {
            var request = new ListActionTypesRequest();
            request.ActionOwnerFilter = actionOwnerFilter;
            return ListActionTypes(request);
        }


        /// <summary>
        /// Gets a summary of all CodePipeline action types associated with your account.
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
        public virtual ListActionTypesResponse ListActionTypes(ListActionTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return Invoke<ListActionTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActionTypes operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActionTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public virtual IAsyncResult BeginListActionTypes(ListActionTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActionTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActionTypes.</param>
        /// 
        /// <returns>Returns a  ListActionTypesResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListActionTypes">REST API Reference for ListActionTypes Operation</seealso>
        public virtual ListActionTypesResponse EndListActionTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActionTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeployActionExecutionTargets

        /// <summary>
        /// Lists the targets for the deploy action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployActionExecutionTargets service method.</param>
        /// 
        /// <returns>The response from the ListDeployActionExecutionTargets service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionExecutionNotFoundException">
        /// The action execution was not found.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListDeployActionExecutionTargets">REST API Reference for ListDeployActionExecutionTargets Operation</seealso>
        public virtual ListDeployActionExecutionTargetsResponse ListDeployActionExecutionTargets(ListDeployActionExecutionTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeployActionExecutionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeployActionExecutionTargetsResponseUnmarshaller.Instance;

            return Invoke<ListDeployActionExecutionTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployActionExecutionTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployActionExecutionTargets operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployActionExecutionTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListDeployActionExecutionTargets">REST API Reference for ListDeployActionExecutionTargets Operation</seealso>
        public virtual IAsyncResult BeginListDeployActionExecutionTargets(ListDeployActionExecutionTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeployActionExecutionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeployActionExecutionTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployActionExecutionTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployActionExecutionTargets.</param>
        /// 
        /// <returns>Returns a  ListDeployActionExecutionTargetsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListDeployActionExecutionTargets">REST API Reference for ListDeployActionExecutionTargets Operation</seealso>
        public virtual ListDeployActionExecutionTargetsResponse EndListDeployActionExecutionTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeployActionExecutionTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPipelineExecutions

        /// <summary>
        /// Gets a summary of the most recent executions for a pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// When applying the filter for pipeline executions that have succeeded in the stage,
        /// the operation returns all executions in the current pipeline version beginning on
        /// February 1, 2024.
        /// </para>
        ///  </note>
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
        public virtual ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public virtual IAsyncResult BeginListPipelineExecutions(ListPipelineExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineExecutions.</param>
        /// 
        /// <returns>Returns a  ListPipelineExecutionsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public virtual ListPipelineExecutionsResponse EndListPipelineExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelineExecutionsResponse>(asyncResult);
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
        /// provide is the token returned by a previous call.
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
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleExecutions

        /// <summary>
        /// Lists the rule executions that have occurred in a pipeline configured for conditions
        /// with rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleExecutions service method.</param>
        /// 
        /// <returns>The response from the ListRuleExecutions service method, as returned by CodePipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleExecutions">REST API Reference for ListRuleExecutions Operation</seealso>
        public virtual ListRuleExecutionsResponse ListRuleExecutions(ListRuleExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListRuleExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleExecutions operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleExecutions">REST API Reference for ListRuleExecutions Operation</seealso>
        public virtual IAsyncResult BeginListRuleExecutions(ListRuleExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleExecutions.</param>
        /// 
        /// <returns>Returns a  ListRuleExecutionsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleExecutions">REST API Reference for ListRuleExecutions Operation</seealso>
        public virtual ListRuleExecutionsResponse EndListRuleExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleTypes

        /// <summary>
        /// Lists the rules for the condition. For more information about conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
        /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
        /// do stage conditions work?</a>.For more information about rules, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
        /// rule reference</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleTypes service method.</param>
        /// 
        /// <returns>The response from the ListRuleTypes service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format. Make sure that the next token you
        /// provide is the token returned by a previous call.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleTypes">REST API Reference for ListRuleTypes Operation</seealso>
        public virtual ListRuleTypesResponse ListRuleTypes(ListRuleTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleTypesResponseUnmarshaller.Instance;

            return Invoke<ListRuleTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleTypes operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleTypes">REST API Reference for ListRuleTypes Operation</seealso>
        public virtual IAsyncResult BeginListRuleTypes(ListRuleTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleTypes.</param>
        /// 
        /// <returns>Returns a  ListRuleTypesResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListRuleTypes">REST API Reference for ListRuleTypes Operation</seealso>
        public virtual ListRuleTypesResponse EndListRuleTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleTypesResponse>(asyncResult);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWebhooks

        /// <summary>
        /// Gets a listing of all the webhooks in this Amazon Web Services Region for this account.
        /// The output lists all webhooks and includes the webhook URL and ARN and the configuration
        /// for each webhook.
        /// 
        ///  <note> 
        /// <para>
        /// If a secret token was provided, it will be redacted in the response.
        /// </para>
        ///  </note>
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
        public virtual ListWebhooksResponse ListWebhooks(ListWebhooksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return Invoke<ListWebhooksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebhooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebhooks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual IAsyncResult BeginListWebhooks(ListWebhooksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebhooks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebhooks.</param>
        /// 
        /// <returns>Returns a  ListWebhooksResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual ListWebhooksResponse EndListWebhooks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWebhooksResponse>(asyncResult);
        }

        #endregion
        
        #region  OverrideStageCondition

        /// <summary>
        /// Used to override a stage condition. For more information about conditions, see <a
        /// href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
        /// conditions</a> and <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/concepts-how-it-works-conditions.html">How
        /// do stage conditions work?</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverrideStageCondition service method.</param>
        /// 
        /// <returns>The response from the OverrideStageCondition service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentPipelineExecutionsLimitExceededException">
        /// The pipeline has reached the limit for concurrent pipeline executions.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ConditionNotOverridableException">
        /// Unable to override because the condition does not allow overrides.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the <c>pipelineExecutionId</c>
        /// associated with the request is out of date.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/OverrideStageCondition">REST API Reference for OverrideStageCondition Operation</seealso>
        public virtual OverrideStageConditionResponse OverrideStageCondition(OverrideStageConditionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverrideStageConditionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverrideStageConditionResponseUnmarshaller.Instance;

            return Invoke<OverrideStageConditionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OverrideStageCondition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OverrideStageCondition operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOverrideStageCondition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/OverrideStageCondition">REST API Reference for OverrideStageCondition Operation</seealso>
        public virtual IAsyncResult BeginOverrideStageCondition(OverrideStageConditionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverrideStageConditionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverrideStageConditionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OverrideStageCondition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOverrideStageCondition.</param>
        /// 
        /// <returns>Returns a  OverrideStageConditionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/OverrideStageCondition">REST API Reference for OverrideStageCondition Operation</seealso>
        public virtual OverrideStageConditionResponse EndOverrideStageCondition(IAsyncResult asyncResult)
        {
            return EndInvoke<OverrideStageConditionResponse>(asyncResult);
        }

        #endregion
        
        #region  PollForJobs

        /// <summary>
        /// Returns information about any jobs for CodePipeline to act on. <c>PollForJobs</c>
        /// is valid only for action types with "Custom" in the owner field. If the action type
        /// contains <c>AWS</c> or <c>ThirdParty</c> in the owner field, the <c>PollForJobs</c>
        /// action returns an error.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts. This API also returns any secret values defined
        /// for the action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return Invoke<PollForJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForJobs operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        public virtual IAsyncResult BeginPollForJobs(PollForJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PollForJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForJobs.</param>
        /// 
        /// <returns>Returns a  PollForJobsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForJobs">REST API Reference for PollForJobs Operation</seealso>
        public virtual PollForJobsResponse EndPollForJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<PollForJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  PollForThirdPartyJobs

        /// <summary>
        /// Determines whether there are any third party jobs for a job worker to act on. Used
        /// for partner actions only.
        /// 
        ///  <important> 
        /// <para>
        /// When this API is called, CodePipeline returns temporary credentials for the S3 bucket
        /// used to store artifacts for the pipeline, if the action requires access to that S3
        /// bucket for input or output artifacts.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return Invoke<PollForThirdPartyJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PollForThirdPartyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForThirdPartyJobs operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForThirdPartyJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        public virtual IAsyncResult BeginPollForThirdPartyJobs(PollForThirdPartyJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForThirdPartyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForThirdPartyJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PollForThirdPartyJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForThirdPartyJobs.</param>
        /// 
        /// <returns>Returns a  PollForThirdPartyJobsResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PollForThirdPartyJobs">REST API Reference for PollForThirdPartyJobs Operation</seealso>
        public virtual PollForThirdPartyJobsResponse EndPollForThirdPartyJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<PollForThirdPartyJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutActionRevision

        /// <summary>
        /// Provides information to CodePipeline about new revisions to a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision service method.</param>
        /// 
        /// <returns>The response from the PutActionRevision service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionNotFoundException">
        /// The specified action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentPipelineExecutionsLimitExceededException">
        /// The pipeline has reached the limit for concurrent pipeline executions.
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
        public virtual PutActionRevisionResponse PutActionRevision(PutActionRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return Invoke<PutActionRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutActionRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutActionRevision operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutActionRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public virtual IAsyncResult BeginPutActionRevision(PutActionRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutActionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutActionRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutActionRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutActionRevision.</param>
        /// 
        /// <returns>Returns a  PutActionRevisionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutActionRevision">REST API Reference for PutActionRevision Operation</seealso>
        public virtual PutActionRevisionResponse EndPutActionRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<PutActionRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutApprovalResult

        /// <summary>
        /// Provides the response to a manual approval request to CodePipeline. Valid responses
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
        public virtual PutApprovalResultResponse PutApprovalResult(PutApprovalResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutApprovalResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return Invoke<PutApprovalResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutApprovalResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApprovalResult operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApprovalResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public virtual IAsyncResult BeginPutApprovalResult(PutApprovalResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutApprovalResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutApprovalResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutApprovalResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApprovalResult.</param>
        /// 
        /// <returns>Returns a  PutApprovalResultResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutApprovalResult">REST API Reference for PutApprovalResult Operation</seealso>
        public virtual PutApprovalResultResponse EndPutApprovalResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutApprovalResultResponse>(asyncResult);
        }

        #endregion
        
        #region  PutJobFailureResult

        /// <summary>
        /// Represents the failure of a job as returned to the pipeline by a job worker. Used
        /// for custom actions only.
        /// </summary>
        /// <param name="jobId">The unique system-generated ID of the job that failed. This is the same ID returned from <c>PollForJobs</c>.</param>
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
        public virtual PutJobFailureResultResponse PutJobFailureResult(string jobId, FailureDetails failureDetails)
        {
            var request = new PutJobFailureResultRequest();
            request.JobId = jobId;
            request.FailureDetails = failureDetails;
            return PutJobFailureResult(request);
        }


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
        public virtual PutJobFailureResultResponse PutJobFailureResult(PutJobFailureResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutJobFailureResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobFailureResult operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutJobFailureResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public virtual IAsyncResult BeginPutJobFailureResult(PutJobFailureResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobFailureResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutJobFailureResult.</param>
        /// 
        /// <returns>Returns a  PutJobFailureResultResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobFailureResult">REST API Reference for PutJobFailureResult Operation</seealso>
        public virtual PutJobFailureResultResponse EndPutJobFailureResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutJobFailureResultResponse>(asyncResult);
        }

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
        public virtual PutJobSuccessResultResponse PutJobSuccessResult(PutJobSuccessResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutJobSuccessResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobSuccessResult operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutJobSuccessResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public virtual IAsyncResult BeginPutJobSuccessResult(PutJobSuccessResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobSuccessResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutJobSuccessResult.</param>
        /// 
        /// <returns>Returns a  PutJobSuccessResultResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutJobSuccessResult">REST API Reference for PutJobSuccessResult Operation</seealso>
        public virtual PutJobSuccessResultResponse EndPutJobSuccessResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutJobSuccessResultResponse>(asyncResult);
        }

        #endregion
        
        #region  PutThirdPartyJobFailureResult

        /// <summary>
        /// Represents the failure of a third party job as returned to the pipeline by a job worker.
        /// Used for partner actions only.
        /// </summary>
        /// <param name="jobId">The ID of the job that failed. This is the same ID returned from <c>PollForThirdPartyJobs</c>.</param>
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
        public virtual PutThirdPartyJobFailureResultResponse PutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobFailureResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobFailureResult operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutThirdPartyJobFailureResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public virtual IAsyncResult BeginPutThirdPartyJobFailureResult(PutThirdPartyJobFailureResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobFailureResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobFailureResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutThirdPartyJobFailureResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutThirdPartyJobFailureResult.</param>
        /// 
        /// <returns>Returns a  PutThirdPartyJobFailureResultResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobFailureResult">REST API Reference for PutThirdPartyJobFailureResult Operation</seealso>
        public virtual PutThirdPartyJobFailureResultResponse EndPutThirdPartyJobFailureResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutThirdPartyJobFailureResultResponse>(asyncResult);
        }

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
        public virtual PutThirdPartyJobSuccessResultResponse PutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return Invoke<PutThirdPartyJobSuccessResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutThirdPartyJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutThirdPartyJobSuccessResult operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutThirdPartyJobSuccessResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public virtual IAsyncResult BeginPutThirdPartyJobSuccessResult(PutThirdPartyJobSuccessResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutThirdPartyJobSuccessResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutThirdPartyJobSuccessResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutThirdPartyJobSuccessResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutThirdPartyJobSuccessResult.</param>
        /// 
        /// <returns>Returns a  PutThirdPartyJobSuccessResultResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutThirdPartyJobSuccessResult">REST API Reference for PutThirdPartyJobSuccessResult Operation</seealso>
        public virtual PutThirdPartyJobSuccessResultResponse EndPutThirdPartyJobSuccessResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutThirdPartyJobSuccessResultResponse>(asyncResult);
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
        /// 
        ///  <important> 
        /// <para>
        /// When creating CodePipeline webhooks, do not use your own credentials or reuse the
        /// same secret token across multiple webhooks. For optimal security, generate a unique
        /// secret token for each webhook you create. The secret token is an arbitrary string
        /// that you provide, which GitHub uses to compute and sign the webhook payloads sent
        /// to CodePipeline, for protecting the integrity and authenticity of the webhook payloads.
        /// Using your own credentials or reusing the same token across multiple webhooks can
        /// lead to security vulnerabilities.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If a secret token was provided, it will be redacted in the response.
        /// </para>
        ///  </note>
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
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
        public virtual PutWebhookResponse PutWebhook(PutWebhookRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWebhookResponseUnmarshaller.Instance;

            return Invoke<PutWebhookResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWebhook operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        public virtual IAsyncResult BeginPutWebhook(PutWebhookRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWebhookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWebhook.</param>
        /// 
        /// <returns>Returns a  PutWebhookResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/PutWebhook">REST API Reference for PutWebhook Operation</seealso>
        public virtual PutWebhookResponse EndPutWebhook(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWebhookResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return Invoke<RegisterWebhookWithThirdPartyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWebhookWithThirdParty operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterWebhookWithThirdParty
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RegisterWebhookWithThirdParty">REST API Reference for RegisterWebhookWithThirdParty Operation</seealso>
        public virtual IAsyncResult BeginRegisterWebhookWithThirdParty(RegisterWebhookWithThirdPartyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterWebhookWithThirdPartyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWebhookWithThirdPartyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterWebhookWithThirdParty operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWebhookWithThirdParty.</param>
        /// 
        /// <returns>Returns a  RegisterWebhookWithThirdPartyResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RegisterWebhookWithThirdParty">REST API Reference for RegisterWebhookWithThirdParty Operation</seealso>
        public virtual RegisterWebhookWithThirdPartyResponse EndRegisterWebhookWithThirdParty(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterWebhookWithThirdPartyResponse>(asyncResult);
        }

        #endregion
        
        #region  RetryStageExecution

        /// <summary>
        /// You can retry a stage that has failed without having to run a pipeline again from
        /// the beginning. You do this by either retrying the failed actions in a stage or by
        /// retrying all actions in the stage starting from the first action in the stage. When
        /// you retry the failed actions in a stage, all actions that are still in progress continue
        /// working, and failed actions are triggered again. When you retry a failed stage from
        /// the first action in the stage, the stage cannot have any actions in progress. Before
        /// a stage can be retried, it must either have all actions failed or some actions failed
        /// and some succeeded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution service method.</param>
        /// 
        /// <returns>The response from the RetryStageExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentPipelineExecutionsLimitExceededException">
        /// The pipeline has reached the limit for concurrent pipeline executions.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.NotLatestPipelineExecutionException">
        /// The stage has failed in a later run of the pipeline and the <c>pipelineExecutionId</c>
        /// associated with the request is out of date.
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
        public virtual RetryStageExecutionResponse RetryStageExecution(RetryStageExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryStageExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return Invoke<RetryStageExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryStageExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryStageExecution operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryStageExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public virtual IAsyncResult BeginRetryStageExecution(RetryStageExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RetryStageExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryStageExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetryStageExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryStageExecution.</param>
        /// 
        /// <returns>Returns a  RetryStageExecutionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RetryStageExecution">REST API Reference for RetryStageExecution Operation</seealso>
        public virtual RetryStageExecutionResponse EndRetryStageExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<RetryStageExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  RollbackStage

        /// <summary>
        /// Rolls back a stage execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackStage service method.</param>
        /// 
        /// <returns>The response from the RollbackStage service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotFoundException">
        /// The pipeline execution was specified in an invalid format or cannot be found, or an
        /// execution ID does not belong to the specified pipeline.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionOutdatedException">
        /// The specified pipeline execution is outdated and cannot be used as a target pipeline
        /// execution for rollback.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.StageNotFoundException">
        /// The stage was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.UnableToRollbackStageException">
        /// Unable to roll back the stage. The cause might be if the pipeline version has changed
        /// since the target pipeline execution was deployed, the stage is currently running,
        /// or an incorrect target pipeline execution ID was provided.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RollbackStage">REST API Reference for RollbackStage Operation</seealso>
        public virtual RollbackStageResponse RollbackStage(RollbackStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackStageResponseUnmarshaller.Instance;

            return Invoke<RollbackStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RollbackStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RollbackStage operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRollbackStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RollbackStage">REST API Reference for RollbackStage Operation</seealso>
        public virtual IAsyncResult BeginRollbackStage(RollbackStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RollbackStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRollbackStage.</param>
        /// 
        /// <returns>Returns a  RollbackStageResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/RollbackStage">REST API Reference for RollbackStage Operation</seealso>
        public virtual RollbackStageResponse EndRollbackStage(IAsyncResult asyncResult)
        {
            return EndInvoke<RollbackStageResponse>(asyncResult);
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
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentPipelineExecutionsLimitExceededException">
        /// The pipeline has reached the limit for concurrent pipeline executions.
        /// </exception>
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
        /// <exception cref="Amazon.CodePipeline.Model.ConcurrentPipelineExecutionsLimitExceededException">
        /// The pipeline has reached the limit for concurrent pipeline executions.
        /// </exception>
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
        public virtual StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual IAsyncResult BeginStartPipelineExecution(StartPipelineExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipelineExecution.</param>
        /// 
        /// <returns>Returns a  StartPipelineExecutionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual StartPipelineExecutionResponse EndStartPipelineExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPipelineExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopPipelineExecution

        /// <summary>
        /// Stops the specified pipeline execution. You choose to either stop the pipeline execution
        /// by completing in-progress actions without starting subsequent actions, or by abandoning
        /// in-progress actions. While completing or abandoning in-progress actions, the pipeline
        /// execution is in a <c>Stopping</c> state. After all in-progress actions are completed
        /// or abandoned, the pipeline execution is in a <c>Stopped</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ConflictException">
        /// Your request cannot be handled because the pipeline is busy handling ongoing activities.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.DuplicatedStopRequestException">
        /// The pipeline execution is already in a <c>Stopping</c> state. If you already chose
        /// to stop and wait, you cannot make that request again. You can choose to stop and abandon
        /// now, but be aware that this option can lead to failed tasks or out of sequence tasks.
        /// If you already chose to stop and abandon, you cannot make that request again.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineExecutionNotStoppableException">
        /// Unable to stop the pipeline execution. The execution might already be in a <c>Stopped</c>
        /// state, or it might no longer be in progress.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.PipelineNotFoundException">
        /// The pipeline was specified in an invalid format or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        public virtual StopPipelineExecutionResponse StopPipelineExecution(StopPipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StopPipelineExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPipelineExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        public virtual IAsyncResult BeginStopPipelineExecution(StopPipelineExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopPipelineExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPipelineExecution.</param>
        /// 
        /// <returns>Returns a  StopPipelineExecutionResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        public virtual StopPipelineExecutionResponse EndStopPipelineExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopPipelineExecutionResponse>(asyncResult);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateActionType

        /// <summary>
        /// Updates an action type that was created with any supported integration model, where
        /// the action type is to be used by customers of the action type provider. Use a JSON
        /// file with the action definition and <c>UpdateActionType</c> to provide the full structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionType service method.</param>
        /// 
        /// <returns>The response from the UpdateActionType service method, as returned by CodePipeline.</returns>
        /// <exception cref="Amazon.CodePipeline.Model.ActionTypeNotFoundException">
        /// The specified action type cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.RequestFailedException">
        /// The request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdateActionType">REST API Reference for UpdateActionType Operation</seealso>
        public virtual UpdateActionTypeResponse UpdateActionType(UpdateActionTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateActionTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateActionType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionType operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActionType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdateActionType">REST API Reference for UpdateActionType Operation</seealso>
        public virtual IAsyncResult BeginUpdateActionType(UpdateActionTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActionTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActionTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActionType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActionType.</param>
        /// 
        /// <returns>Returns a  UpdateActionTypeResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdateActionType">REST API Reference for UpdateActionType Operation</seealso>
        public virtual UpdateActionTypeResponse EndUpdateActionType(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateActionTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipeline

        /// <summary>
        /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
        /// with the pipeline structure and <c>UpdatePipeline</c> to provide the full structure
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
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
        /// with the pipeline structure and <c>UpdatePipeline</c> to provide the full structure
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
        /// The number of pipelines associated with the Amazon Web Services account has exceeded
        /// the limit allowed for the account.
        /// </exception>
        /// <exception cref="Amazon.CodePipeline.Model.ValidationException">
        /// The validation was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonCodePipelineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from CodePipeline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codepipeline-2015-07-09/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonCodePipelineEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}