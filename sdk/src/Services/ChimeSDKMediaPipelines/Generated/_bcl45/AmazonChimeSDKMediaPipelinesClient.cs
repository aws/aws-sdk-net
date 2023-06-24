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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKMediaPipelines.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKMediaPipelines
{
    /// <summary>
    /// Implementation for accessing ChimeSDKMediaPipelines
    ///
    /// The Amazon Chime SDK media pipeline APIs in this section allow software developers
    /// to create Amazon Chime SDK media pipelines that capture, concatenate, or stream your
    /// Amazon Chime SDK meetings. For more information about media pipelines, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_Operations_Amazon_Chime_SDK_Media_Pipelines.html">Amazon
    /// Chime SDK media pipelines</a>.
    /// </summary>
    public partial class AmazonChimeSDKMediaPipelinesClient : AmazonServiceClient, IAmazonChimeSDKMediaPipelines
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKMediaPipelinesMetadata();
        private IChimeSDKMediaPipelinesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKMediaPipelinesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKMediaPipelinesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMediaPipelinesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMediaPipelinesConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with the credentials loaded from the application's
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
        public AmazonChimeSDKMediaPipelinesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMediaPipelinesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeSDKMediaPipelinesClient Configuration Object</param>
        public AmazonChimeSDKMediaPipelinesClient(AmazonChimeSDKMediaPipelinesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKMediaPipelinesClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKMediaPipelinesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMediaPipelinesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKMediaPipelinesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Credentials and an
        /// AmazonChimeSDKMediaPipelinesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKMediaPipelinesClient Configuration Object</param>
        public AmazonChimeSDKMediaPipelinesClient(AWSCredentials credentials, AmazonChimeSDKMediaPipelinesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMediaPipelinesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMediaPipelinesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMediaPipelinesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKMediaPipelinesClient Configuration Object</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKMediaPipelinesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMediaPipelinesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMediaPipelinesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMediaPipelinesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMediaPipelinesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKMediaPipelinesClient Configuration Object</param>
        public AmazonChimeSDKMediaPipelinesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKMediaPipelinesConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChimeSDKMediaPipelinesEndpointResolver());
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


        #region  CreateMediaCapturePipeline


        /// <summary>
        /// Creates a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaCapturePipeline service method.</param>
        /// 
        /// <returns>The response from the CreateMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        public virtual CreateMediaCapturePipelineResponse CreateMediaCapturePipeline(CreateMediaCapturePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaCapturePipelineResponse>(request, options);
        }


        /// <summary>
        /// Creates a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        public virtual Task<CreateMediaCapturePipelineResponse> CreateMediaCapturePipelineAsync(CreateMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaCapturePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMediaCapturePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMediaConcatenationPipeline


        /// <summary>
        /// Creates a media concatenation pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaConcatenationPipeline service method.</param>
        /// 
        /// <returns>The response from the CreateMediaConcatenationPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaConcatenationPipeline">REST API Reference for CreateMediaConcatenationPipeline Operation</seealso>
        public virtual CreateMediaConcatenationPipelineResponse CreateMediaConcatenationPipeline(CreateMediaConcatenationPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaConcatenationPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaConcatenationPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaConcatenationPipelineResponse>(request, options);
        }


        /// <summary>
        /// Creates a media concatenation pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaConcatenationPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaConcatenationPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaConcatenationPipeline">REST API Reference for CreateMediaConcatenationPipeline Operation</seealso>
        public virtual Task<CreateMediaConcatenationPipelineResponse> CreateMediaConcatenationPipelineAsync(CreateMediaConcatenationPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaConcatenationPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaConcatenationPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMediaConcatenationPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMediaInsightsPipeline


        /// <summary>
        /// Creates a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipeline service method.</param>
        /// 
        /// <returns>The response from the CreateMediaInsightsPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipeline">REST API Reference for CreateMediaInsightsPipeline Operation</seealso>
        public virtual CreateMediaInsightsPipelineResponse CreateMediaInsightsPipeline(CreateMediaInsightsPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaInsightsPipelineResponse>(request, options);
        }


        /// <summary>
        /// Creates a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaInsightsPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipeline">REST API Reference for CreateMediaInsightsPipeline Operation</seealso>
        public virtual Task<CreateMediaInsightsPipelineResponse> CreateMediaInsightsPipelineAsync(CreateMediaInsightsPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMediaInsightsPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMediaInsightsPipelineConfiguration


        /// <summary>
        /// A structure that contains the static configurations for a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipelineConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipelineConfiguration">REST API Reference for CreateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual CreateMediaInsightsPipelineConfigurationResponse CreateMediaInsightsPipelineConfiguration(CreateMediaInsightsPipelineConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMediaInsightsPipelineConfigurationResponse>(request, options);
        }


        /// <summary>
        /// A structure that contains the static configurations for a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipelineConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipelineConfiguration">REST API Reference for CreateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual Task<CreateMediaInsightsPipelineConfigurationResponse> CreateMediaInsightsPipelineConfigurationAsync(CreateMediaInsightsPipelineConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMediaInsightsPipelineConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMediaLiveConnectorPipeline


        /// <summary>
        /// Creates a media live connector pipeline in an Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaLiveConnectorPipeline service method.</param>
        /// 
        /// <returns>The response from the CreateMediaLiveConnectorPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaLiveConnectorPipeline">REST API Reference for CreateMediaLiveConnectorPipeline Operation</seealso>
        public virtual CreateMediaLiveConnectorPipelineResponse CreateMediaLiveConnectorPipeline(CreateMediaLiveConnectorPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaLiveConnectorPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaLiveConnectorPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaLiveConnectorPipelineResponse>(request, options);
        }


        /// <summary>
        /// Creates a media live connector pipeline in an Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaLiveConnectorPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMediaLiveConnectorPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaLiveConnectorPipeline">REST API Reference for CreateMediaLiveConnectorPipeline Operation</seealso>
        public virtual Task<CreateMediaLiveConnectorPipelineResponse> CreateMediaLiveConnectorPipelineAsync(CreateMediaLiveConnectorPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMediaLiveConnectorPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaLiveConnectorPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMediaLiveConnectorPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMediaCapturePipeline


        /// <summary>
        /// Deletes the media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaCapturePipeline service method.</param>
        /// 
        /// <returns>The response from the DeleteMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        public virtual DeleteMediaCapturePipelineResponse DeleteMediaCapturePipeline(DeleteMediaCapturePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaCapturePipelineResponse>(request, options);
        }


        /// <summary>
        /// Deletes the media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        public virtual Task<DeleteMediaCapturePipelineResponse> DeleteMediaCapturePipelineAsync(DeleteMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaCapturePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMediaCapturePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMediaInsightsPipelineConfiguration


        /// <summary>
        /// Deletes the specified configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaInsightsPipelineConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaInsightsPipelineConfiguration">REST API Reference for DeleteMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual DeleteMediaInsightsPipelineConfigurationResponse DeleteMediaInsightsPipelineConfiguration(DeleteMediaInsightsPipelineConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaInsightsPipelineConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaInsightsPipelineConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaInsightsPipelineConfiguration">REST API Reference for DeleteMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual Task<DeleteMediaInsightsPipelineConfigurationResponse> DeleteMediaInsightsPipelineConfigurationAsync(DeleteMediaInsightsPipelineConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMediaInsightsPipelineConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMediaPipeline


        /// <summary>
        /// Deletes the media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaPipeline service method.</param>
        /// 
        /// <returns>The response from the DeleteMediaPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipeline">REST API Reference for DeleteMediaPipeline Operation</seealso>
        public virtual DeleteMediaPipelineResponse DeleteMediaPipeline(DeleteMediaPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaPipelineResponse>(request, options);
        }


        /// <summary>
        /// Deletes the media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipeline">REST API Reference for DeleteMediaPipeline Operation</seealso>
        public virtual Task<DeleteMediaPipelineResponse> DeleteMediaPipelineAsync(DeleteMediaPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMediaPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMediaCapturePipeline


        /// <summary>
        /// Gets an existing media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaCapturePipeline service method.</param>
        /// 
        /// <returns>The response from the GetMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        public virtual GetMediaCapturePipelineResponse GetMediaCapturePipeline(GetMediaCapturePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<GetMediaCapturePipelineResponse>(request, options);
        }


        /// <summary>
        /// Gets an existing media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaCapturePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaCapturePipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        public virtual Task<GetMediaCapturePipelineResponse> GetMediaCapturePipelineAsync(GetMediaCapturePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaCapturePipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMediaCapturePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMediaInsightsPipelineConfiguration


        /// <summary>
        /// Gets the configuration settings for a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaInsightsPipelineConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaInsightsPipelineConfiguration">REST API Reference for GetMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual GetMediaInsightsPipelineConfigurationResponse GetMediaInsightsPipelineConfiguration(GetMediaInsightsPipelineConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetMediaInsightsPipelineConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets the configuration settings for a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaInsightsPipelineConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaInsightsPipelineConfiguration">REST API Reference for GetMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual Task<GetMediaInsightsPipelineConfigurationResponse> GetMediaInsightsPipelineConfigurationAsync(GetMediaInsightsPipelineConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMediaInsightsPipelineConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMediaPipeline


        /// <summary>
        /// Gets an existing media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaPipeline service method.</param>
        /// 
        /// <returns>The response from the GetMediaPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipeline">REST API Reference for GetMediaPipeline Operation</seealso>
        public virtual GetMediaPipelineResponse GetMediaPipeline(GetMediaPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineResponseUnmarshaller.Instance;

            return Invoke<GetMediaPipelineResponse>(request, options);
        }


        /// <summary>
        /// Gets an existing media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMediaPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipeline">REST API Reference for GetMediaPipeline Operation</seealso>
        public virtual Task<GetMediaPipelineResponse> GetMediaPipelineAsync(GetMediaPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMediaPipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMediaCapturePipelines


        /// <summary>
        /// Returns a list of media pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaCapturePipelines service method.</param>
        /// 
        /// <returns>The response from the ListMediaCapturePipelines service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        public virtual ListMediaCapturePipelinesResponse ListMediaCapturePipelines(ListMediaCapturePipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaCapturePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaCapturePipelinesResponseUnmarshaller.Instance;

            return Invoke<ListMediaCapturePipelinesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of media pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaCapturePipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMediaCapturePipelines service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        public virtual Task<ListMediaCapturePipelinesResponse> ListMediaCapturePipelinesAsync(ListMediaCapturePipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaCapturePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaCapturePipelinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMediaCapturePipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMediaInsightsPipelineConfigurations


        /// <summary>
        /// Lists the available media insights pipeline configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaInsightsPipelineConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListMediaInsightsPipelineConfigurations service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaInsightsPipelineConfigurations">REST API Reference for ListMediaInsightsPipelineConfigurations Operation</seealso>
        public virtual ListMediaInsightsPipelineConfigurationsResponse ListMediaInsightsPipelineConfigurations(ListMediaInsightsPipelineConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaInsightsPipelineConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaInsightsPipelineConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListMediaInsightsPipelineConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the available media insights pipeline configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaInsightsPipelineConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMediaInsightsPipelineConfigurations service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaInsightsPipelineConfigurations">REST API Reference for ListMediaInsightsPipelineConfigurations Operation</seealso>
        public virtual Task<ListMediaInsightsPipelineConfigurationsResponse> ListMediaInsightsPipelineConfigurationsAsync(ListMediaInsightsPipelineConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaInsightsPipelineConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaInsightsPipelineConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMediaInsightsPipelineConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMediaPipelines


        /// <summary>
        /// Returns a list of media pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaPipelines service method.</param>
        /// 
        /// <returns>The response from the ListMediaPipelines service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelines">REST API Reference for ListMediaPipelines Operation</seealso>
        public virtual ListMediaPipelinesResponse ListMediaPipelines(ListMediaPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListMediaPipelinesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of media pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMediaPipelines service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelines">REST API Reference for ListMediaPipelines Operation</seealso>
        public virtual Task<ListMediaPipelinesResponse> ListMediaPipelinesAsync(ListMediaPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMediaPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMediaPipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags available for a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags available for a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// The ARN of the media pipeline that you want to tag. Consists of the pipeline's endpoint
        /// region, resource ID, and pipeline ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// The ARN of the media pipeline that you want to tag. Consists of the pipeline's endpoint
        /// region, resource ID, and pipeline ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes any tags from a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes any tags from a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMediaInsightsPipelineConfiguration


        /// <summary>
        /// Updates the media insights pipeline's configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineConfiguration">REST API Reference for UpdateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual UpdateMediaInsightsPipelineConfigurationResponse UpdateMediaInsightsPipelineConfiguration(UpdateMediaInsightsPipelineConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaInsightsPipelineConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the media insights pipeline's configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMediaInsightsPipelineConfiguration service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineConfiguration">REST API Reference for UpdateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual Task<UpdateMediaInsightsPipelineConfigurationResponse> UpdateMediaInsightsPipelineConfigurationAsync(UpdateMediaInsightsPipelineConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMediaInsightsPipelineConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMediaInsightsPipelineStatus


        /// <summary>
        /// Updates the status of a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateMediaInsightsPipelineStatus service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineStatus">REST API Reference for UpdateMediaInsightsPipelineStatus Operation</seealso>
        public virtual UpdateMediaInsightsPipelineStatusResponse UpdateMediaInsightsPipelineStatus(UpdateMediaInsightsPipelineStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaInsightsPipelineStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of a media insights pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMediaInsightsPipelineStatus service method, as returned by ChimeSDKMediaPipelines.</returns>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMediaPipelines.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineStatus">REST API Reference for UpdateMediaInsightsPipelineStatus Operation</seealso>
        public virtual Task<UpdateMediaInsightsPipelineStatusResponse> UpdateMediaInsightsPipelineStatusAsync(UpdateMediaInsightsPipelineStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMediaInsightsPipelineStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}