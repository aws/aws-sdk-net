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
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKMediaPipelines.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ChimeSDKMediaPipelines
{
    /// <summary>
    /// <para>Implementation for accessing ChimeSDKMediaPipelines</para>
    ///
    /// The Amazon Chime SDK media pipeline APIs in this section allow software developers
    /// to create Amazon Chime SDK media pipelines that capture, concatenate, or stream your
    /// Amazon Chime SDK meetings. For more information about media pipelines, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_Operations_Amazon_Chime_SDK_Media_Pipelines.html">Amazon
    /// Chime SDK media pipelines</a>.
    /// </summary>
    public partial class AmazonChimeSDKMediaPipelinesClient : AmazonServiceClient, IAmazonChimeSDKMediaPipelines
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKMediaPipelinesMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaCapturePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaCapturePipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaCapturePipeline(CreateMediaCapturePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaCapturePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaCapturePipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaCapturePipeline">REST API Reference for CreateMediaCapturePipeline Operation</seealso>
        public virtual CreateMediaCapturePipelineResponse EndCreateMediaCapturePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaCapturePipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaConcatenationPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaConcatenationPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaConcatenationPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaConcatenationPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaConcatenationPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaConcatenationPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaConcatenationPipeline">REST API Reference for CreateMediaConcatenationPipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaConcatenationPipeline(CreateMediaConcatenationPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaConcatenationPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaConcatenationPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaConcatenationPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaConcatenationPipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaConcatenationPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaConcatenationPipeline">REST API Reference for CreateMediaConcatenationPipeline Operation</seealso>
        public virtual CreateMediaConcatenationPipelineResponse EndCreateMediaConcatenationPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaConcatenationPipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaInsightsPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaInsightsPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaInsightsPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipeline">REST API Reference for CreateMediaInsightsPipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaInsightsPipeline(CreateMediaInsightsPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaInsightsPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaInsightsPipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaInsightsPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipeline">REST API Reference for CreateMediaInsightsPipeline Operation</seealso>
        public virtual CreateMediaInsightsPipelineResponse EndCreateMediaInsightsPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaInsightsPipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMediaInsightsPipelineConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaInsightsPipelineConfiguration operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaInsightsPipelineConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipelineConfiguration">REST API Reference for CreateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaInsightsPipelineConfiguration(CreateMediaInsightsPipelineConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaInsightsPipelineConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateMediaInsightsPipelineConfigurationResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaInsightsPipelineConfiguration">REST API Reference for CreateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual CreateMediaInsightsPipelineConfigurationResponse EndCreateMediaInsightsPipelineConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaInsightsPipelineConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaLiveConnectorPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaLiveConnectorPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaLiveConnectorPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaLiveConnectorPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaLiveConnectorPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaLiveConnectorPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaLiveConnectorPipeline">REST API Reference for CreateMediaLiveConnectorPipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaLiveConnectorPipeline(CreateMediaLiveConnectorPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaLiveConnectorPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaLiveConnectorPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaLiveConnectorPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaLiveConnectorPipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaLiveConnectorPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaLiveConnectorPipeline">REST API Reference for CreateMediaLiveConnectorPipeline Operation</seealso>
        public virtual CreateMediaLiveConnectorPipelineResponse EndCreateMediaLiveConnectorPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaLiveConnectorPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMediaPipelineKinesisVideoStreamPool

        /// <summary>
        /// Creates an Amazon Kinesis Video Stream pool for use with media stream pipelines.
        /// 
        ///  <note> 
        /// <para>
        /// If a meeting uses an opt-in Region as its <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html#chimesdk-meeting-chime_CreateMeeting-request-MediaRegion">MediaRegion</a>,
        /// the KVS stream must be in that same Region. For example, if a meeting uses the <c>af-south-1</c>
        /// Region, the KVS stream must also be in <c>af-south-1</c>. However, if the meeting
        /// uses a Region that AWS turns on by default, the KVS stream can be in any available
        /// Region, including an opt-in Region. For example, if the meeting uses <c>ca-central-1</c>,
        /// the KVS stream can be in <c>eu-west-2</c>, <c>us-east-1</c>, <c>af-south-1</c>, or
        /// any other Region that the Amazon Chime SDK supports.
        /// </para>
        ///  
        /// <para>
        /// To learn which AWS Region a meeting uses, call the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_GetMeeting.html">GetMeeting</a>
        /// API and use the <a href="https://docs.aws.amazon.com/chime-sdk/latest/APIReference/API_meeting-chime_CreateMeeting.html#chimesdk-meeting-chime_CreateMeeting-request-MediaRegion">MediaRegion</a>
        /// parameter from the response.
        /// </para>
        ///  
        /// <para>
        /// For more information about opt-in Regions, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/sdk-available-regions.html">Available
        /// Regions</a> in the <i>Amazon Chime SDK Developer Guide</i>, and <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html#rande-manage-enable.html">Specify
        /// which AWS Regions your account can use</a>, in the <i>AWS Account Management Reference
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaPipelineKinesisVideoStreamPool service method.</param>
        /// 
        /// <returns>The response from the CreateMediaPipelineKinesisVideoStreamPool service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaPipelineKinesisVideoStreamPool">REST API Reference for CreateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual CreateMediaPipelineKinesisVideoStreamPoolResponse CreateMediaPipelineKinesisVideoStreamPool(CreateMediaPipelineKinesisVideoStreamPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return Invoke<CreateMediaPipelineKinesisVideoStreamPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaPipelineKinesisVideoStreamPool operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaPipelineKinesisVideoStreamPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaPipelineKinesisVideoStreamPool">REST API Reference for CreateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaPipelineKinesisVideoStreamPool(CreateMediaPipelineKinesisVideoStreamPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaPipelineKinesisVideoStreamPool.</param>
        /// 
        /// <returns>Returns a  CreateMediaPipelineKinesisVideoStreamPoolResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaPipelineKinesisVideoStreamPool">REST API Reference for CreateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual CreateMediaPipelineKinesisVideoStreamPoolResponse EndCreateMediaPipelineKinesisVideoStreamPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaPipelineKinesisVideoStreamPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMediaStreamPipeline

        /// <summary>
        /// Creates a streaming media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaStreamPipeline service method.</param>
        /// 
        /// <returns>The response from the CreateMediaStreamPipeline service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaStreamPipeline">REST API Reference for CreateMediaStreamPipeline Operation</seealso>
        public virtual CreateMediaStreamPipelineResponse CreateMediaStreamPipeline(CreateMediaStreamPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaStreamPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaStreamPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateMediaStreamPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMediaStreamPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMediaStreamPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMediaStreamPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaStreamPipeline">REST API Reference for CreateMediaStreamPipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateMediaStreamPipeline(CreateMediaStreamPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMediaStreamPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMediaStreamPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMediaStreamPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMediaStreamPipeline.</param>
        /// 
        /// <returns>Returns a  CreateMediaStreamPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/CreateMediaStreamPipeline">REST API Reference for CreateMediaStreamPipeline Operation</seealso>
        public virtual CreateMediaStreamPipelineResponse EndCreateMediaStreamPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMediaStreamPipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaCapturePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaCapturePipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        public virtual IAsyncResult BeginDeleteMediaCapturePipeline(DeleteMediaCapturePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaCapturePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  DeleteMediaCapturePipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaCapturePipeline">REST API Reference for DeleteMediaCapturePipeline Operation</seealso>
        public virtual DeleteMediaCapturePipelineResponse EndDeleteMediaCapturePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMediaCapturePipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaInsightsPipelineConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaInsightsPipelineConfiguration operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMediaInsightsPipelineConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaInsightsPipelineConfiguration">REST API Reference for DeleteMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteMediaInsightsPipelineConfiguration(DeleteMediaInsightsPipelineConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMediaInsightsPipelineConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteMediaInsightsPipelineConfigurationResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaInsightsPipelineConfiguration">REST API Reference for DeleteMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual DeleteMediaInsightsPipelineConfigurationResponse EndDeleteMediaInsightsPipelineConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMediaInsightsPipelineConfigurationResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipeline">REST API Reference for DeleteMediaPipeline Operation</seealso>
        public virtual DeleteMediaPipelineResponse DeleteMediaPipeline(DeleteMediaPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMediaPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMediaPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipeline">REST API Reference for DeleteMediaPipeline Operation</seealso>
        public virtual IAsyncResult BeginDeleteMediaPipeline(DeleteMediaPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMediaPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMediaPipeline.</param>
        /// 
        /// <returns>Returns a  DeleteMediaPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipeline">REST API Reference for DeleteMediaPipeline Operation</seealso>
        public virtual DeleteMediaPipelineResponse EndDeleteMediaPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMediaPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMediaPipelineKinesisVideoStreamPool

        /// <summary>
        /// Deletes an Amazon Kinesis Video Stream pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaPipelineKinesisVideoStreamPool service method.</param>
        /// 
        /// <returns>The response from the DeleteMediaPipelineKinesisVideoStreamPool service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipelineKinesisVideoStreamPool">REST API Reference for DeleteMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual DeleteMediaPipelineKinesisVideoStreamPoolResponse DeleteMediaPipelineKinesisVideoStreamPool(DeleteMediaPipelineKinesisVideoStreamPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaPipelineKinesisVideoStreamPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaPipelineKinesisVideoStreamPool operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMediaPipelineKinesisVideoStreamPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipelineKinesisVideoStreamPool">REST API Reference for DeleteMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual IAsyncResult BeginDeleteMediaPipelineKinesisVideoStreamPool(DeleteMediaPipelineKinesisVideoStreamPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMediaPipelineKinesisVideoStreamPool.</param>
        /// 
        /// <returns>Returns a  DeleteMediaPipelineKinesisVideoStreamPoolResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/DeleteMediaPipelineKinesisVideoStreamPool">REST API Reference for DeleteMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual DeleteMediaPipelineKinesisVideoStreamPoolResponse EndDeleteMediaPipelineKinesisVideoStreamPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMediaPipelineKinesisVideoStreamPoolResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaCapturePipelineResponseUnmarshaller.Instance;

            return Invoke<GetMediaCapturePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaCapturePipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMediaCapturePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        public virtual IAsyncResult BeginGetMediaCapturePipeline(GetMediaCapturePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaCapturePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaCapturePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMediaCapturePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMediaCapturePipeline.</param>
        /// 
        /// <returns>Returns a  GetMediaCapturePipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaCapturePipeline">REST API Reference for GetMediaCapturePipeline Operation</seealso>
        public virtual GetMediaCapturePipelineResponse EndGetMediaCapturePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaCapturePipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetMediaInsightsPipelineConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaInsightsPipelineConfiguration operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMediaInsightsPipelineConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaInsightsPipelineConfiguration">REST API Reference for GetMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetMediaInsightsPipelineConfiguration(GetMediaInsightsPipelineConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMediaInsightsPipelineConfiguration.</param>
        /// 
        /// <returns>Returns a  GetMediaInsightsPipelineConfigurationResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaInsightsPipelineConfiguration">REST API Reference for GetMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual GetMediaInsightsPipelineConfigurationResponse EndGetMediaInsightsPipelineConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaInsightsPipelineConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineResponseUnmarshaller.Instance;

            return Invoke<GetMediaPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaPipeline operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMediaPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipeline">REST API Reference for GetMediaPipeline Operation</seealso>
        public virtual IAsyncResult BeginGetMediaPipeline(GetMediaPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMediaPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMediaPipeline.</param>
        /// 
        /// <returns>Returns a  GetMediaPipelineResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipeline">REST API Reference for GetMediaPipeline Operation</seealso>
        public virtual GetMediaPipelineResponse EndGetMediaPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMediaPipelineKinesisVideoStreamPool

        /// <summary>
        /// Gets an Kinesis video stream pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaPipelineKinesisVideoStreamPool service method.</param>
        /// 
        /// <returns>The response from the GetMediaPipelineKinesisVideoStreamPool service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipelineKinesisVideoStreamPool">REST API Reference for GetMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual GetMediaPipelineKinesisVideoStreamPoolResponse GetMediaPipelineKinesisVideoStreamPool(GetMediaPipelineKinesisVideoStreamPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return Invoke<GetMediaPipelineKinesisVideoStreamPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaPipelineKinesisVideoStreamPool operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMediaPipelineKinesisVideoStreamPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipelineKinesisVideoStreamPool">REST API Reference for GetMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual IAsyncResult BeginGetMediaPipelineKinesisVideoStreamPool(GetMediaPipelineKinesisVideoStreamPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMediaPipelineKinesisVideoStreamPool.</param>
        /// 
        /// <returns>Returns a  GetMediaPipelineKinesisVideoStreamPoolResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetMediaPipelineKinesisVideoStreamPool">REST API Reference for GetMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual GetMediaPipelineKinesisVideoStreamPoolResponse EndGetMediaPipelineKinesisVideoStreamPool(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaPipelineKinesisVideoStreamPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSpeakerSearchTask

        /// <summary>
        /// Retrieves the details of the specified speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask service method.</param>
        /// 
        /// <returns>The response from the GetSpeakerSearchTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual GetSpeakerSearchTaskResponse GetSpeakerSearchTask(GetSpeakerSearchTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<GetSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginGetSpeakerSearchTask(GetSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpeakerSearchTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  GetSpeakerSearchTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual GetSpeakerSearchTaskResponse EndGetSpeakerSearchTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpeakerSearchTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceToneAnalysisTask

        /// <summary>
        /// Retrieves the details of a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask service method.</param>
        /// 
        /// <returns>The response from the GetVoiceToneAnalysisTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual GetVoiceToneAnalysisTaskResponse GetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<GetVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  GetVoiceToneAnalysisTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual GetVoiceToneAnalysisTaskResponse EndGetVoiceToneAnalysisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceToneAnalysisTaskResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaCapturePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaCapturePipelinesResponseUnmarshaller.Instance;

            return Invoke<ListMediaCapturePipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMediaCapturePipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMediaCapturePipelines operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMediaCapturePipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        public virtual IAsyncResult BeginListMediaCapturePipelines(ListMediaCapturePipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaCapturePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaCapturePipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMediaCapturePipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMediaCapturePipelines.</param>
        /// 
        /// <returns>Returns a  ListMediaCapturePipelinesResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaCapturePipelines">REST API Reference for ListMediaCapturePipelines Operation</seealso>
        public virtual ListMediaCapturePipelinesResponse EndListMediaCapturePipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMediaCapturePipelinesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaInsightsPipelineConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaInsightsPipelineConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListMediaInsightsPipelineConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMediaInsightsPipelineConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMediaInsightsPipelineConfigurations operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMediaInsightsPipelineConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaInsightsPipelineConfigurations">REST API Reference for ListMediaInsightsPipelineConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListMediaInsightsPipelineConfigurations(ListMediaInsightsPipelineConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaInsightsPipelineConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaInsightsPipelineConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMediaInsightsPipelineConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMediaInsightsPipelineConfigurations.</param>
        /// 
        /// <returns>Returns a  ListMediaInsightsPipelineConfigurationsResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaInsightsPipelineConfigurations">REST API Reference for ListMediaInsightsPipelineConfigurations Operation</seealso>
        public virtual ListMediaInsightsPipelineConfigurationsResponse EndListMediaInsightsPipelineConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMediaInsightsPipelineConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMediaPipelineKinesisVideoStreamPools

        /// <summary>
        /// Lists the video stream pools in the media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMediaPipelineKinesisVideoStreamPools service method.</param>
        /// 
        /// <returns>The response from the ListMediaPipelineKinesisVideoStreamPools service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelineKinesisVideoStreamPools">REST API Reference for ListMediaPipelineKinesisVideoStreamPools Operation</seealso>
        public virtual ListMediaPipelineKinesisVideoStreamPoolsResponse ListMediaPipelineKinesisVideoStreamPools(ListMediaPipelineKinesisVideoStreamPoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaPipelineKinesisVideoStreamPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelineKinesisVideoStreamPoolsResponseUnmarshaller.Instance;

            return Invoke<ListMediaPipelineKinesisVideoStreamPoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMediaPipelineKinesisVideoStreamPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMediaPipelineKinesisVideoStreamPools operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMediaPipelineKinesisVideoStreamPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelineKinesisVideoStreamPools">REST API Reference for ListMediaPipelineKinesisVideoStreamPools Operation</seealso>
        public virtual IAsyncResult BeginListMediaPipelineKinesisVideoStreamPools(ListMediaPipelineKinesisVideoStreamPoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaPipelineKinesisVideoStreamPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelineKinesisVideoStreamPoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMediaPipelineKinesisVideoStreamPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMediaPipelineKinesisVideoStreamPools.</param>
        /// 
        /// <returns>Returns a  ListMediaPipelineKinesisVideoStreamPoolsResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelineKinesisVideoStreamPools">REST API Reference for ListMediaPipelineKinesisVideoStreamPools Operation</seealso>
        public virtual ListMediaPipelineKinesisVideoStreamPoolsResponse EndListMediaPipelineKinesisVideoStreamPools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMediaPipelineKinesisVideoStreamPoolsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListMediaPipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMediaPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMediaPipelines operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMediaPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelines">REST API Reference for ListMediaPipelines Operation</seealso>
        public virtual IAsyncResult BeginListMediaPipelines(ListMediaPipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMediaPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMediaPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMediaPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMediaPipelines.</param>
        /// 
        /// <returns>Returns a  ListMediaPipelinesResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListMediaPipelines">REST API Reference for ListMediaPipelines Operation</seealso>
        public virtual ListMediaPipelinesResponse EndListMediaPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMediaPipelinesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSpeakerSearchTask

        /// <summary>
        /// Starts a speaker search task.
        /// 
        ///  <important> 
        /// <para>
        /// Before starting any speaker search tasks, you must provide all notices and obtain
        /// all consents from the speaker as required under applicable privacy and biometrics
        /// laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
        /// service terms</a> for the Amazon Chime SDK.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerSearchTask service method.</param>
        /// 
        /// <returns>The response from the StartSpeakerSearchTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual StartSpeakerSearchTaskResponse StartSpeakerSearchTask(StartSpeakerSearchTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<StartSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerSearchTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginStartSpeakerSearchTask(StartSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeakerSearchTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  StartSpeakerSearchTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual StartSpeakerSearchTaskResponse EndStartSpeakerSearchTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSpeakerSearchTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartVoiceToneAnalysisTask

        /// <summary>
        /// Starts a voice tone analysis task. For more information about voice tone analysis,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/voice-analytics.html">Using
        /// Amazon Chime SDK voice analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Before starting any voice tone analysis tasks, you must provide all notices and obtain
        /// all consents from the speaker as required under applicable privacy and biometrics
        /// laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
        /// service terms</a> for the Amazon Chime SDK.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVoiceToneAnalysisTask service method.</param>
        /// 
        /// <returns>The response from the StartVoiceToneAnalysisTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        public virtual StartVoiceToneAnalysisTaskResponse StartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<StartVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVoiceToneAnalysisTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginStartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  StartVoiceToneAnalysisTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        public virtual StartVoiceToneAnalysisTaskResponse EndStartVoiceToneAnalysisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartVoiceToneAnalysisTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StopSpeakerSearchTask

        /// <summary>
        /// Stops a speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask service method.</param>
        /// 
        /// <returns>The response from the StopSpeakerSearchTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        public virtual StopSpeakerSearchTaskResponse StopSpeakerSearchTask(StopSpeakerSearchTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<StopSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginStopSpeakerSearchTask(StopSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSpeakerSearchTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSpeakerSearchTask.</param>
        /// 
        /// <returns>Returns a  StopSpeakerSearchTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        public virtual StopSpeakerSearchTaskResponse EndStopSpeakerSearchTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopSpeakerSearchTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StopVoiceToneAnalysisTask

        /// <summary>
        /// Stops a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask service method.</param>
        /// 
        /// <returns>The response from the StopVoiceToneAnalysisTask service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual StopVoiceToneAnalysisTaskResponse StopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<StopVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginStopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopVoiceToneAnalysisTask.</param>
        /// 
        /// <returns>Returns a  StopVoiceToneAnalysisTaskResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual StopVoiceToneAnalysisTaskResponse EndStopVoiceToneAnalysisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopVoiceToneAnalysisTaskResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaInsightsPipelineConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineConfiguration operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMediaInsightsPipelineConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineConfiguration">REST API Reference for UpdateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateMediaInsightsPipelineConfiguration(UpdateMediaInsightsPipelineConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMediaInsightsPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMediaInsightsPipelineConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateMediaInsightsPipelineConfigurationResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineConfiguration">REST API Reference for UpdateMediaInsightsPipelineConfiguration Operation</seealso>
        public virtual UpdateMediaInsightsPipelineConfigurationResponse EndUpdateMediaInsightsPipelineConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMediaInsightsPipelineConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaInsightsPipelineStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMediaInsightsPipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaInsightsPipelineStatus operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMediaInsightsPipelineStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineStatus">REST API Reference for UpdateMediaInsightsPipelineStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateMediaInsightsPipelineStatus(UpdateMediaInsightsPipelineStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaInsightsPipelineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaInsightsPipelineStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMediaInsightsPipelineStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMediaInsightsPipelineStatus.</param>
        /// 
        /// <returns>Returns a  UpdateMediaInsightsPipelineStatusResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaInsightsPipelineStatus">REST API Reference for UpdateMediaInsightsPipelineStatus Operation</seealso>
        public virtual UpdateMediaInsightsPipelineStatusResponse EndUpdateMediaInsightsPipelineStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMediaInsightsPipelineStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMediaPipelineKinesisVideoStreamPool

        /// <summary>
        /// Updates an Amazon Kinesis Video Stream pool in a media pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaPipelineKinesisVideoStreamPool service method.</param>
        /// 
        /// <returns>The response from the UpdateMediaPipelineKinesisVideoStreamPool service method, as returned by ChimeSDKMediaPipelines.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaPipelineKinesisVideoStreamPool">REST API Reference for UpdateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual UpdateMediaPipelineKinesisVideoStreamPoolResponse UpdateMediaPipelineKinesisVideoStreamPool(UpdateMediaPipelineKinesisVideoStreamPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaPipelineKinesisVideoStreamPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaPipelineKinesisVideoStreamPool operation on AmazonChimeSDKMediaPipelinesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMediaPipelineKinesisVideoStreamPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaPipelineKinesisVideoStreamPool">REST API Reference for UpdateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual IAsyncResult BeginUpdateMediaPipelineKinesisVideoStreamPool(UpdateMediaPipelineKinesisVideoStreamPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaPipelineKinesisVideoStreamPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaPipelineKinesisVideoStreamPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMediaPipelineKinesisVideoStreamPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMediaPipelineKinesisVideoStreamPool.</param>
        /// 
        /// <returns>Returns a  UpdateMediaPipelineKinesisVideoStreamPoolResult from ChimeSDKMediaPipelines.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-media-pipelines-2021-07-15/UpdateMediaPipelineKinesisVideoStreamPool">REST API Reference for UpdateMediaPipelineKinesisVideoStreamPool Operation</seealso>
        public virtual UpdateMediaPipelineKinesisVideoStreamPoolResponse EndUpdateMediaPipelineKinesisVideoStreamPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMediaPipelineKinesisVideoStreamPoolResponse>(asyncResult);
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
            var resolver = new AmazonChimeSDKMediaPipelinesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}