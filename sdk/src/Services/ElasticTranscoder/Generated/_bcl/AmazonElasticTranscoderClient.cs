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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticTranscoder.Model;
using Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations;
using Amazon.ElasticTranscoder.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// <para>Implementation for accessing ElasticTranscoder</para>
    ///
    /// AWS Elastic Transcoder Service 
    /// <para>
    /// The AWS Elastic Transcoder Service.
    /// </para>
    /// </summary>
    public partial class AmazonElasticTranscoderClient : AmazonServiceClient, IAmazonElasticTranscoder
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticTranscoderMetadata();
        private IElasticTranscoderPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticTranscoderPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticTranscoderPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
            : base(new AmazonElasticTranscoderConfig()) { }

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
            : base(new AmazonElasticTranscoderConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.ElasticTranscoder.Internal.AmazonElasticTranscoderPreMarshallHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticTranscoderEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticTranscoderAuthSchemeHandler());
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


        #region  CancelJob


        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///  <note> 
        /// <para>
        /// You can only cancel a job that has a status of <c>Submitted</c>. To prevent a pipeline
        /// from starting to process a job while you're getting the job identifier, use <a>UpdatePipelineStatus</a>
        /// to temporarily pause the pipeline.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }


        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///  <note> 
        /// <para>
        /// You can only cancel a job that has a status of <c>Submitted</c>. To prevent a pipeline
        /// from starting to process a job while you're getting the job identifier, use <a>UpdatePipelineStatus</a>
        /// to temporarily pause the pipeline.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        /// that you specified plus information about the job that is created.
        /// 
        ///  
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the Kindle Fire and another output for the Apple iPhone 4s), you currently must
        /// use the Elastic Transcoder API to list the jobs (as opposed to the AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        /// that you specified plus information about the job that is created.
        /// 
        ///  
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the Kindle Fire and another output for the Apple iPhone 4s), you currently must
        /// use the Elastic Transcoder API to list the jobs (as opposed to the AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }


        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePreset


        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///  <important> 
        /// <para>
        /// Elastic Transcoder checks the CreatePreset settings to ensure that they meet Elastic
        /// Transcoder requirements and to determine whether they comply with H.264 standards.
        /// If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns
        /// an HTTP 400 response (<c>ValidationException</c>) and does not create the preset.
        /// If the settings are valid for Elastic Transcoder but aren't strictly compliant with
        /// the H.264 standard, Elastic Transcoder creates the preset and returns a warning message
        /// in the response. This helps you determine whether your settings comply with the H.264
        /// standard while giving you greater flexibility with respect to the video that Elastic
        /// Transcoder produces.
        /// </para>
        ///  </important> 
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International Telecommunication Union publication <i>Recommendation ITU-T
        /// H.264: Advanced video coding for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        public virtual CreatePresetResponse CreatePreset(CreatePresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;

            return Invoke<CreatePresetResponse>(request, options);
        }


        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///  <important> 
        /// <para>
        /// Elastic Transcoder checks the CreatePreset settings to ensure that they meet Elastic
        /// Transcoder requirements and to determine whether they comply with H.264 standards.
        /// If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns
        /// an HTTP 400 response (<c>ValidationException</c>) and does not create the preset.
        /// If the settings are valid for Elastic Transcoder but aren't strictly compliant with
        /// the H.264 standard, Elastic Transcoder creates the preset and returns a warning message
        /// in the response. This helps you determine whether your settings comply with the H.264
        /// standard while giving you greater flexibility with respect to the video that Elastic
        /// Transcoder produces.
        /// </para>
        ///  </important> 
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International Telecommunication Union publication <i>Recommendation ITU-T
        /// H.264: Advanced video coding for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/CreatePreset">REST API Reference for CreatePreset Operation</seealso>
        public virtual Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePresetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///  
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use (doesn't contain any active jobs). If the pipeline is currently in use, <c>DeletePipeline</c>
        /// returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }


        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///  
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use (doesn't contain any active jobs). If the pipeline is currently in use, <c>DeletePipeline</c>
        /// returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePreset


        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        public virtual DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;

            return Invoke<DeletePresetResponse>(request, options);
        }


        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/DeletePreset">REST API Reference for DeletePreset Operation</seealso>
        public virtual Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePresetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobsByPipeline


        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///  
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListJobsByPipeline">REST API Reference for ListJobsByPipeline Operation</seealso>
        public virtual ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsByPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByPipelineResponseUnmarshaller.Instance;

            return Invoke<ListJobsByPipelineResponse>(request, options);
        }


        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///  
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListJobsByPipeline">REST API Reference for ListJobsByPipeline Operation</seealso>
        public virtual Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsByPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsByPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobsByStatus


        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListJobsByStatus">REST API Reference for ListJobsByStatus Operation</seealso>
        public virtual ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsByStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByStatusResponseUnmarshaller.Instance;

            return Invoke<ListJobsByStatusResponse>(request, options);
        }


        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        /// response body contains one element for each job that satisfies the search criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListJobsByStatus">REST API Reference for ListJobsByStatus Operation</seealso>
        public virtual Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsByStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsByStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }


        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }


        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListPipelinesAsync(new ListPipelinesRequest(), cancellationToken);
        }

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPresets


        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPresets">REST API Reference for ListPresets Operation</seealso>
        public virtual ListPresetsResponse ListPresets()
        {
            return ListPresets(new ListPresetsRequest());
        }


        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPresets">REST API Reference for ListPresets Operation</seealso>
        public virtual ListPresetsResponse ListPresets(ListPresetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;

            return Invoke<ListPresetsResponse>(request, options);
        }


        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPresets">REST API Reference for ListPresets Operation</seealso>
        public virtual Task<ListPresetsResponse> ListPresetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListPresetsAsync(new ListPresetsRequest(), cancellationToken);
        }

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ListPresets">REST API Reference for ListPresets Operation</seealso>
        public virtual Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPresetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPresetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPresetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReadJob


        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadJob">REST API Reference for ReadJob Operation</seealso>
        public virtual ReadJobResponse ReadJob(ReadJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadJobResponseUnmarshaller.Instance;

            return Invoke<ReadJobResponse>(request, options);
        }


        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadJob">REST API Reference for ReadJob Operation</seealso>
        public virtual Task<ReadJobResponse> ReadJobAsync(ReadJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReadJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReadPipeline


        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadPipeline">REST API Reference for ReadPipeline Operation</seealso>
        public virtual ReadPipelineResponse ReadPipeline(ReadPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadPipelineResponseUnmarshaller.Instance;

            return Invoke<ReadPipelineResponse>(request, options);
        }


        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadPipeline">REST API Reference for ReadPipeline Operation</seealso>
        public virtual Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReadPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReadPreset


        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadPreset">REST API Reference for ReadPreset Operation</seealso>
        public virtual ReadPresetResponse ReadPreset(ReadPresetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadPresetResponseUnmarshaller.Instance;

            return Invoke<ReadPresetResponse>(request, options);
        }


        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/ReadPreset">REST API Reference for ReadPreset Operation</seealso>
        public virtual Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReadPresetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReadPresetResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReadPresetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestRole


        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///  
        /// <para>
        /// The <c>TestRole</c> action lets you determine whether the IAM role you are using has
        /// sufficient permissions to let Elastic Transcoder perform tasks associated with the
        /// transcoding process. The action attempts to assume the specified IAM role, checks
        /// read access to the input and output buckets, and tries to send a test notification
        /// to Amazon SNS topics that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/TestRole">REST API Reference for TestRole Operation</seealso>
        [Obsolete("This API is deprecated and will be removed in a future release.")]
        public virtual TestRoleResponse TestRole(TestRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRoleResponseUnmarshaller.Instance;

            return Invoke<TestRoleResponse>(request, options);
        }


        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///  
        /// <para>
        /// The <c>TestRole</c> action lets you determine whether the IAM role you are using has
        /// sufficient permissions to let Elastic Transcoder perform tasks associated with the
        /// transcoding process. The action attempts to assume the specified IAM role, checks
        /// read access to the input and output buckets, and tries to send a test notification
        /// to Amazon SNS topics that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/TestRole">REST API Reference for TestRole Operation</seealso>
        [Obsolete("This API is deprecated and will be removed in a future release.")]
        public virtual Task<TestRoleResponse> TestRoleAsync(TestRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRoleResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Use the <c>UpdatePipeline</c> operation to update settings for a pipeline.
        /// 
        ///  <important> 
        /// <para>
        /// When you change pipeline settings, your changes take effect immediately. Jobs that
        /// you have already submitted and that Elastic Transcoder has not started to process
        /// are affected in addition to jobs that you submit after you change settings. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Use the <c>UpdatePipeline</c> operation to update settings for a pipeline.
        /// 
        ///  <important> 
        /// <para>
        /// When you change pipeline settings, your changes take effect immediately. Jobs that
        /// you have already submitted and that Elastic Transcoder has not started to process
        /// are affected in addition to jobs that you submit after you change settings. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipelineNotifications


        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS) notifications for a pipeline.
        /// 
        ///  
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipelineNotifications">REST API Reference for UpdatePipelineNotifications Operation</seealso>
        public virtual UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineNotificationsResponse>(request, options);
        }


        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS) notifications for a pipeline.
        /// 
        ///  
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipelineNotifications">REST API Reference for UpdatePipelineNotifications Operation</seealso>
        public virtual Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePipelineNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipelineStatus


        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        /// stops or restarts the processing of jobs.
        /// 
        ///  
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't cancel jobs after Elastic Transcoder has started processing them; if you pause
        /// the pipeline to which you submitted the jobs, you have more time to get the job IDs
        /// for the jobs that you want to cancel, and to send a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipelineStatus">REST API Reference for UpdatePipelineStatus Operation</seealso>
        public virtual UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineStatusResponse>(request, options);
        }


        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        /// stops or restarts the processing of jobs.
        /// 
        ///  
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't cancel jobs after Elastic Transcoder has started processing them; if you pause
        /// the pipeline to which you submitted the jobs, you have more time to get the job IDs
        /// for the jobs that you want to cancel, and to send a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="Amazon.ElasticTranscoder.Model.AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="Amazon.ElasticTranscoder.Model.ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastictranscoder-2012-09-25/UpdatePipelineStatus">REST API Reference for UpdatePipelineStatus Operation</seealso>
        public virtual Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePipelineStatusResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}