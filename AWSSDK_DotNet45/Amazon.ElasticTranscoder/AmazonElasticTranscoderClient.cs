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


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticTranscoder.Model;
using Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Implementation for accessing ElasticTranscoder
    ///
    /// AWS Elastic Transcoder Service        
    /// <para>
    /// The AWS Elastic Transcoder Service.
    /// </para>
    /// </summary>
    public partial class AmazonElasticTranscoderClient : AmazonWebServiceClient, IAmazonElasticTranscoder
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        public AmazonElasticTranscoderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        public AmazonElasticTranscoderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AmazonElasticTranscoderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticTranscoderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials and an
        /// AmazonElasticTranscoderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticTranscoderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticTranscoderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  CancelJob


        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///         <note>You can only cancel a job that has a status of <code>Submitted</code>.
        /// To prevent a            pipeline from starting to process a job while you're getting
        /// the job identifier, use                <a>UpdatePipelineStatus</a> to temporarily
        /// pause the pipeline.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var task = CancelJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelJobRequestMarshaller();
            var unmarshaller = CancelJobResponseUnmarshaller.Instance;
            return Invoke<IRequest, CancelJobRequest, CancelJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        ///            that you specified plus information about the job that is created. 
        /// 
        ///         
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the            Kindle Fire and another output for the Apple iPhone 4s), you currently
        /// must use the            Elastic Transcoder API to list the jobs (as opposed to the
        /// AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var task = CreateJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateJobRequest, CreateJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var task = CreatePipelineAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreatePipelineRequest, CreatePipelineResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreatePreset


        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///         <important>Elastic Transcoder checks the CreatePreset settings to ensure that
        /// they meet Elastic Transcoder requirements            and to determine whether they
        /// comply with H.264 standards. If your settings are not            valid for Elastic
        /// Transcoder, Elastic Transcoder returns an HTTP 400 response (<code>ValidationException</code>)
        /// and            does not create the preset. If the settings are valid for Elastic Transcoder
        /// but aren't strictly            compliant with the H.264 standard, Elastic Transcoder
        /// creates the preset and returns a warning message            in the response. This
        /// helps you determine whether your settings comply with the H.264            standard
        /// while giving you greater flexibility with respect to the video that Elastic Transcoder
        ///            produces.</important>        
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International            Telecommunication Union publication <i>Recommendation
        /// ITU-T H.264: Advanced video coding                for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreatePresetResponse CreatePreset(CreatePresetRequest request)
        {
            var task = CreatePresetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePresetRequestMarshaller();
            var unmarshaller = CreatePresetResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreatePresetRequest, CreatePresetResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///         
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use            (doesn't contain any active jobs). If the pipeline is currently
        /// in use,                <code>DeletePipeline</code> returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var task = DeletePipelineAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeletePipelineRequest, DeletePipelineResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeletePreset


        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///         <note>            
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///         </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            var task = DeletePresetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePresetRequestMarshaller();
            var unmarshaller = DeletePresetResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeletePresetRequest, DeletePresetResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListJobsByPipeline


        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///         
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        ///            response body contains one element for each job that satisfies the search
        /// criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request)
        {
            var task = ListJobsByPipelineAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsByPipelineRequestMarshaller();
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListJobsByPipelineRequest, ListJobsByPipelineResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListJobsByStatus


        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        ///            response body contains one element for each job that satisfies the search
        /// criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request)
        {
            var task = ListJobsByStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsByStatusRequestMarshaller();
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListJobsByStatusRequest, ListJobsByStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListPipelines

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS            account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS            account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var task = ListPipelinesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListPipelinesRequest, ListPipelinesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ListPresets

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the            presets that you've added in an AWS region.
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPresetsResponse ListPresets()
        {
            return ListPresets(new ListPresetsRequest());
        }

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the            presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPresetsResponse ListPresets(ListPresetsRequest request)
        {
            var task = ListPresetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPresetsRequestMarshaller();
            var unmarshaller = ListPresetsResponseUnmarshaller.Instance;
            return Invoke<IRequest, ListPresetsRequest, ListPresetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ReadJob


        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadJobResponse ReadJob(ReadJobRequest request)
        {
            var task = ReadJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReadJobResponse> ReadJobAsync(ReadJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadJobRequestMarshaller();
            var unmarshaller = ReadJobResponseUnmarshaller.Instance;
            return Invoke<IRequest, ReadJobRequest, ReadJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ReadPipeline


        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadPipelineResponse ReadPipeline(ReadPipelineRequest request)
        {
            var task = ReadPipelineAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadPipelineRequestMarshaller();
            var unmarshaller = ReadPipelineResponseUnmarshaller.Instance;
            return Invoke<IRequest, ReadPipelineRequest, ReadPipelineResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ReadPreset


        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadPresetResponse ReadPreset(ReadPresetRequest request)
        {
            var task = ReadPresetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadPresetRequestMarshaller();
            var unmarshaller = ReadPresetResponseUnmarshaller.Instance;
            return Invoke<IRequest, ReadPresetRequest, ReadPresetResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  TestRole


        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///         
        /// <para>
        /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
        ///            has sufficient permissions to let Elastic Transcoder perform tasks associated
        /// with the transcoding            process. The action attempts to assume the specified
        /// IAM role, checks read access to the            input and output buckets, and tries
        /// to send a test notification to Amazon SNS topics            that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public TestRoleResponse TestRole(TestRoleRequest request)
        {
            var task = TestRoleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TestRoleResponse> TestRoleAsync(TestRoleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestRoleRequestMarshaller();
            var unmarshaller = TestRoleResponseUnmarshaller.Instance;
            return Invoke<IRequest, TestRoleRequest, TestRoleResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
        ///                <important>When you change pipeline settings, your changes take effect
        /// immediately.                Jobs that you have already submitted and that Elastic
        /// Transcoder has not started to process are                affected in addition to jobs
        /// that you submit after you change settings. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var task = UpdatePipelineAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdatePipelineRequest, UpdatePipelineResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdatePipelineNotifications


        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS)            notifications for a pipeline.
        /// 
        ///         
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified            in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request)
        {
            var task = UpdatePipelineNotificationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineNotificationsRequestMarshaller();
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdatePipelineNotificationsRequest, UpdatePipelineNotificationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  UpdatePipelineStatus


        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        ///            stops or restarts the processing of jobs.
        /// 
        ///         
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't            cancel jobs after Elastic Transcoder has started processing them;
        /// if you pause the pipeline to which            you submitted the jobs, you have more
        /// time to get the job IDs for the jobs that you want            to cancel, and to send
        /// a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request)
        {
            var task = UpdatePipelineStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.IAmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineStatusRequestMarshaller();
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.Instance;
            return Invoke<IRequest, UpdatePipelineStatusRequest, UpdatePipelineStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}