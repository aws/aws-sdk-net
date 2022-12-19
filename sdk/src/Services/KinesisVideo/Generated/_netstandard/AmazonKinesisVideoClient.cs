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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideo.Model;
using Amazon.KinesisVideo.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideo.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisVideo
{
    /// <summary>
    /// Implementation for accessing KinesisVideo
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoClient : AmazonServiceClient, IAmazonKinesisVideo
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisVideoConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisVideoConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisVideoClient Configuration Object</param>
        public AmazonKinesisVideoClient(AmazonKinesisVideoConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisVideoClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisVideoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisVideoConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Credentials and an
        /// AmazonKinesisVideoClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisVideoClient Configuration Object</param>
        public AmazonKinesisVideoClient(AWSCredentials credentials, AmazonKinesisVideoConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisVideoClient Configuration Object</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisVideoConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisVideoClient Configuration Object</param>
        public AmazonKinesisVideoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisVideoConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IKinesisVideoPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKinesisVideoPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KinesisVideoPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoEndpointResolver());
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


        #region  CreateSignalingChannel

        internal virtual CreateSignalingChannelResponse CreateSignalingChannel(CreateSignalingChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<CreateSignalingChannelResponse>(request, options);
        }



        /// <summary>
        /// Creates a signaling channel. 
        /// 
        ///  
        /// <para>
        ///  <code>CreateSignalingChannel</code> is an asynchronous operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.AccountChannelLimitExceededException">
        /// You have reached the maximum limit of active signaling channels for this Amazon Web
        /// Services account in this region.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateSignalingChannel">REST API Reference for CreateSignalingChannel Operation</seealso>
        public virtual Task<CreateSignalingChannelResponse> CreateSignalingChannelAsync(CreateSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalingChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSignalingChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStream

        internal virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Kinesis video stream. 
        /// 
        ///  
        /// <para>
        /// When you create a new stream, Kinesis Video Streams assigns it a version number. When
        /// you change the stream's metadata, Kinesis Video Streams updates the version. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateStream</code> is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For information about how the service works, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/how-it-works.html">How
        /// it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must have permissions for the <code>KinesisVideo:CreateStream</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccountStreamLimitExceededException">
        /// The number of streams created for the account is too high.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.DeviceStreamLimitExceededException">
        /// Not implemented.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidDeviceException">
        /// Not implemented.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSignalingChannel

        internal virtual DeleteSignalingChannelResponse DeleteSignalingChannel(DeleteSignalingChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSignalingChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified signaling channel. <code>DeleteSignalingChannel</code> is an asynchronous
        /// operation. If you don't specify the channel's current version, the most recent version
        /// is deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteSignalingChannel">REST API Reference for DeleteSignalingChannel Operation</seealso>
        public virtual Task<DeleteSignalingChannelResponse> DeleteSignalingChannelAsync(DeleteSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalingChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSignalingChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStream

        internal virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Kinesis video stream and the data contained in the stream. 
        /// 
        ///  
        /// <para>
        /// This method marks the stream for deletion, and makes the data in the stream inaccessible
        /// immediately.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  To ensure that you have the latest version of the stream before deleting it, you
        /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
        /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
        /// the latest stream version, use the <code>DescribeStream</code> API. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:DeleteStream</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEdgeConfiguration

        internal virtual DescribeEdgeConfigurationResponse DescribeEdgeConfiguration(DescribeEdgeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeEdgeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes a stream’s edge configuration that was set using the <code>StartEdgeConfigurationUpdate</code>
        /// API. Use this API to get the status of the configuration if the configuration is in
        /// sync with the Edge Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEdgeConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.StreamEdgeConfigurationNotFoundException">
        /// The Exception rendered when the Amazon Kinesis Video Stream can't find a stream's
        /// edge configuration that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeEdgeConfiguration">REST API Reference for DescribeEdgeConfiguration Operation</seealso>
        public virtual Task<DescribeEdgeConfigurationResponse> DescribeEdgeConfigurationAsync(DescribeEdgeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEdgeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageGenerationConfiguration

        internal virtual DescribeImageGenerationConfigurationResponse DescribeImageGenerationConfiguration(DescribeImageGenerationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageGenerationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeImageGenerationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the <code>ImageGenerationConfiguration</code> for a given Kinesis video stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageGenerationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageGenerationConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeImageGenerationConfiguration">REST API Reference for DescribeImageGenerationConfiguration Operation</seealso>
        public virtual Task<DescribeImageGenerationConfigurationResponse> DescribeImageGenerationConfigurationAsync(DescribeImageGenerationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageGenerationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageGenerationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMappedResourceConfiguration

        internal virtual DescribeMappedResourceConfigurationResponse DescribeMappedResourceConfiguration(DescribeMappedResourceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMappedResourceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMappedResourceConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeMappedResourceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the most current information about the stream. Either streamName or streamARN
        /// should be provided in the input.
        /// 
        ///  
        /// <para>
        /// Returns the most current information about the stream. The <code>streamName</code>
        /// or <code>streamARN</code> should be provided in the input.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMappedResourceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMappedResourceConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMappedResourceConfiguration">REST API Reference for DescribeMappedResourceConfiguration Operation</seealso>
        public virtual Task<DescribeMappedResourceConfigurationResponse> DescribeMappedResourceConfigurationAsync(DescribeMappedResourceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMappedResourceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMappedResourceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMappedResourceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMediaStorageConfiguration

        internal virtual DescribeMediaStorageConfigurationResponse DescribeMediaStorageConfiguration(DescribeMediaStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMediaStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeMediaStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the most current information about the channel. Specify the <code>ChannelName</code>
        /// or <code>ChannelARN</code> in the input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMediaStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMediaStorageConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMediaStorageConfiguration">REST API Reference for DescribeMediaStorageConfiguration Operation</seealso>
        public virtual Task<DescribeMediaStorageConfigurationResponse> DescribeMediaStorageConfigurationAsync(DescribeMediaStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMediaStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMediaStorageConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationConfiguration

        internal virtual DescribeNotificationConfigurationResponse DescribeNotificationConfiguration(DescribeNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the <code>NotificationConfiguration</code> for a given Kinesis video stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeNotificationConfiguration">REST API Reference for DescribeNotificationConfiguration Operation</seealso>
        public virtual Task<DescribeNotificationConfigurationResponse> DescribeNotificationConfigurationAsync(DescribeNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSignalingChannel

        internal virtual DescribeSignalingChannelResponse DescribeSignalingChannel(DescribeSignalingChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeSignalingChannelResponse>(request, options);
        }



        /// <summary>
        /// Returns the most current information about the signaling channel. You must specify
        /// either the name or the Amazon Resource Name (ARN) of the channel that you want to
        /// describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeSignalingChannel">REST API Reference for DescribeSignalingChannel Operation</seealso>
        public virtual Task<DescribeSignalingChannelResponse> DescribeSignalingChannelAsync(DescribeSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSignalingChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSignalingChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStream

        internal virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }



        /// <summary>
        /// Returns the most current information about the specified stream. You must specify
        /// either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataEndpoint

        internal virtual GetDataEndpointResponse GetDataEndpoint(GetDataEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDataEndpointResponse>(request, options);
        }



        /// <summary>
        /// Gets an endpoint for a specified stream for either reading or writing. Use this endpoint
        /// in your application to read from the specified stream (using the <code>GetMedia</code>
        /// or <code>GetMediaForFragmentList</code> operations) or write to it (using the <code>PutMedia</code>
        /// operation). 
        /// 
        ///  <note> 
        /// <para>
        /// The returned endpoint does not have the API name appended. The client needs to add
        /// the API name to the returned endpoint.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, specify the stream either by <code>StreamName</code> or <code>StreamARN</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataEndpoint service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetDataEndpoint">REST API Reference for GetDataEndpoint Operation</seealso>
        public virtual Task<GetDataEndpointResponse> GetDataEndpointAsync(GetDataEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSignalingChannelEndpoint

        internal virtual GetSignalingChannelEndpointResponse GetSignalingChannelEndpoint(GetSignalingChannelEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSignalingChannelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalingChannelEndpointResponseUnmarshaller.Instance;

            return Invoke<GetSignalingChannelEndpointResponse>(request, options);
        }



        /// <summary>
        /// Provides an endpoint for the specified signaling channel to send and receive messages.
        /// This API uses the <code>SingleMasterChannelEndpointConfiguration</code> input parameter,
        /// which consists of the <code>Protocols</code> and <code>Role</code> properties.
        /// 
        ///  
        /// <para>
        ///  <code>Protocols</code> is used to determine the communication mechanism. For example,
        /// if you specify <code>WSS</code> as the protocol, this API produces a secure websocket
        /// endpoint. If you specify <code>HTTPS</code> as the protocol, this API generates an
        /// HTTPS endpoint. 
        /// </para>
        ///  
        /// <para>
        ///  <code>Role</code> determines the messaging permissions. A <code>MASTER</code> role
        /// results in this API generating an endpoint that a client can use to communicate with
        /// any of the viewers on the channel. A <code>VIEWER</code> role results in this API
        /// generating an endpoint that a client can use to communicate only with a <code>MASTER</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalingChannelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSignalingChannelEndpoint service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetSignalingChannelEndpoint">REST API Reference for GetSignalingChannelEndpoint Operation</seealso>
        public virtual Task<GetSignalingChannelEndpointResponse> GetSignalingChannelEndpointAsync(GetSignalingChannelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSignalingChannelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalingChannelEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetSignalingChannelEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSignalingChannels

        internal virtual ListSignalingChannelsResponse ListSignalingChannels(ListSignalingChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalingChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalingChannelsResponseUnmarshaller.Instance;

            return Invoke<ListSignalingChannelsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>ChannelInfo</code> objects. Each object describes a signaling
        /// channel. To retrieve only those channels that satisfy a specific condition, you can
        /// specify a <code>ChannelNameCondition</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalingChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSignalingChannels service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListSignalingChannels">REST API Reference for ListSignalingChannels Operation</seealso>
        public virtual Task<ListSignalingChannelsResponse> ListSignalingChannelsAsync(ListSignalingChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSignalingChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalingChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSignalingChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreams

        internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>StreamInfo</code> objects. Each object describes a stream.
        /// To retrieve only streams that satisfy a specific condition, you can specify a <code>StreamNameCondition</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags associated with the specified signaling channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForStream

        internal virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags associated with the specified stream.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEdgeConfigurationUpdate

        internal virtual StartEdgeConfigurationUpdateResponse StartEdgeConfigurationUpdate(StartEdgeConfigurationUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEdgeConfigurationUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeConfigurationUpdateResponseUnmarshaller.Instance;

            return Invoke<StartEdgeConfigurationUpdateResponse>(request, options);
        }



        /// <summary>
        /// An asynchronous API that updates a stream’s existing edge configuration. The Kinesis
        /// Video Stream will sync the stream’s edge configuration with the Edge Agent IoT Greengrass
        /// component that runs on an IoT Hub Device, setup at your premise. The time to sync
        /// can vary and depends on the connectivity of the Hub Device. The <code>SyncStatus</code>
        /// will be updated as the edge configuration is acknowledged, and synced with the Edge
        /// Agent. 
        /// 
        ///  
        /// <para>
        /// If this API is invoked for the first time, a new edge configuration will be created
        /// for the stream, and the sync status will be set to <code>SYNCING</code>. You will
        /// have to wait for the sync status to reach a terminal state such as: <code>IN_SYNC</code>,
        /// or <code>SYNC_FAILED</code>, before using this API again. If you invoke this API during
        /// the syncing process, a <code>ResourceInUseException</code> will be thrown. The connectivity
        /// of the stream’s edge configuration and the Edge Agent will be retried for 15 minutes.
        /// After 15 minutes, the status will transition into the <code>SYNC_FAILED</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeConfigurationUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEdgeConfigurationUpdate service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NoDataRetentionException">
        /// The Stream data retention in hours is equal to zero.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/StartEdgeConfigurationUpdate">REST API Reference for StartEdgeConfigurationUpdate Operation</seealso>
        public virtual Task<StartEdgeConfigurationUpdateResponse> StartEdgeConfigurationUpdateAsync(StartEdgeConfigurationUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEdgeConfigurationUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeConfigurationUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartEdgeConfigurationUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to a signaling channel. A <i>tag</i> is a key-value pair (the
        /// value is optional) that you can define and assign to Amazon Web Services resources.
        /// If you specify a tag that already exists, the tag value is replaced with the value
        /// that you specify in the request. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management and Cost Management
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagStream

        internal virtual TagStreamResponse TagStream(TagStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagStreamResponseUnmarshaller.Instance;

            return Invoke<TagStreamResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to a stream. A <i>tag</i> is a key-value pair (the value is
        /// optional) that you can define and assign to Amazon Web Services resources. If you
        /// specify a tag that already exists, the tag value is replaced with the value that you
        /// specify in the request. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management and Cost Management
        /// User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// You must provide either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:TagStream</code> action.
        /// </para>
        ///  
        /// <para>
        /// A Kinesis video stream can support up to 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagStream">REST API Reference for TagStream Operation</seealso>
        public virtual Task<TagStreamResponse> TagStreamAsync(TagStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagStreamResponseUnmarshaller.Instance;

            return InvokeAsync<TagStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a signaling channel. In the request, specify only a
        /// tag key or keys; don't specify the value. If you specify a tag key that does not exist,
        /// it's ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagStream

        internal virtual UntagStreamResponse UntagStream(UntagStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagStreamResponseUnmarshaller.Instance;

            return Invoke<UntagStreamResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a stream. In the request, specify only a tag key or
        /// keys; don't specify the value. If you specify a tag key that does not exist, it's
        /// ignored.
        /// 
        ///  
        /// <para>
        /// In the request, you must provide the <code>StreamName</code> or <code>StreamARN</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagStream">REST API Reference for UntagStream Operation</seealso>
        public virtual Task<UntagStreamResponse> UntagStreamAsync(UntagStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagStreamResponseUnmarshaller.Instance;

            return InvokeAsync<UntagStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataRetention

        internal virtual UpdateDataRetentionResponse UpdateDataRetention(UpdateDataRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return Invoke<UpdateDataRetentionResponse>(request, options);
        }



        /// <summary>
        /// Increases or decreases the stream's data retention period by the value that you specify.
        /// To indicate whether you want to increase or decrease the data retention period, specify
        /// the <code>Operation</code> parameter in the request body. In the request, you must
        /// specify either the <code>StreamName</code> or the <code>StreamARN</code>. 
        /// 
        ///  <note> 
        /// <para>
        /// The retention period that you specify replaces the current value.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:UpdateDataRetention</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Changing the data retention period affects the data in the stream as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the data retention period is increased, existing data is retained for the new retention
        /// period. For example, if the data retention period is increased from one hour to seven
        /// hours, all existing data is retained for seven hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the data retention period is decreased, existing data is retained for the new retention
        /// period. For example, if the data retention period is decreased from seven hours to
        /// one hour, all existing data is retained for one hour, and any data older than one
        /// hour is deleted immediately.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataRetention service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual Task<UpdateDataRetentionResponse> UpdateDataRetentionAsync(UpdateDataRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataRetentionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateImageGenerationConfiguration

        internal virtual UpdateImageGenerationConfigurationResponse UpdateImageGenerationConfiguration(UpdateImageGenerationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageGenerationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateImageGenerationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the <code>StreamInfo</code> and <code>ImageProcessingConfiguration</code>
        /// fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageGenerationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImageGenerationConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NoDataRetentionException">
        /// The Stream data retention in hours is equal to zero.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateImageGenerationConfiguration">REST API Reference for UpdateImageGenerationConfiguration Operation</seealso>
        public virtual Task<UpdateImageGenerationConfigurationResponse> UpdateImageGenerationConfigurationAsync(UpdateImageGenerationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageGenerationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateImageGenerationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMediaStorageConfiguration

        internal virtual UpdateMediaStorageConfigurationResponse UpdateMediaStorageConfiguration(UpdateMediaStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Associates a <code>SignalingChannel</code> to a stream to store the media. There are
        /// two signaling modes that can specified :
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the <code>StorageStatus</code> is disabled, no data will be stored, and the <code>StreamARN</code>
        /// parameter will not be needed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>StorageStatus</code> is enabled, the data will be stored in the <code>StreamARN</code>
        /// provided. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMediaStorageConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NoDataRetentionException">
        /// The Stream data retention in hours is equal to zero.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateMediaStorageConfiguration">REST API Reference for UpdateMediaStorageConfiguration Operation</seealso>
        public virtual Task<UpdateMediaStorageConfigurationResponse> UpdateMediaStorageConfigurationAsync(UpdateMediaStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMediaStorageConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotificationConfiguration

        internal virtual UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the notification information for a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotificationConfiguration service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NoDataRetentionException">
        /// The Stream data retention in hours is equal to zero.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual Task<UpdateNotificationConfigurationResponse> UpdateNotificationConfigurationAsync(UpdateNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSignalingChannel

        internal virtual UpdateSignalingChannelResponse UpdateSignalingChannel(UpdateSignalingChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSignalingChannelResponse>(request, options);
        }



        /// <summary>
        /// Updates the existing signaling channel. This is an asynchronous operation and takes
        /// time to complete. 
        /// 
        ///  
        /// <para>
        /// If the <code>MessageTtlSeconds</code> value is updated (either increased or reduced),
        /// it only applies to new messages sent via this channel after it's been updated. Existing
        /// messages are still expired as per the previous <code>MessageTtlSeconds</code> value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateSignalingChannel">REST API Reference for UpdateSignalingChannel Operation</seealso>
        public virtual Task<UpdateSignalingChannelResponse> UpdateSignalingChannelAsync(UpdateSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalingChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSignalingChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStream

        internal virtual UpdateStreamResponse UpdateStream(UpdateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamResponse>(request, options);
        }



        /// <summary>
        /// Updates stream metadata, such as the device name and media type.
        /// 
        ///  
        /// <para>
        /// You must provide the stream name or the Amazon Resource Name (ARN) of the stream.
        /// </para>
        ///  
        /// <para>
        /// To make sure that you have the latest version of the stream before updating it, you
        /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
        /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
        /// the latest stream version, use the <code>DescribeStream</code> API. 
        /// </para>
        ///  
        /// <para>
        ///  <code>UpdateStream</code> is an asynchronous operation, and takes time to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// When the input <code>StreamARN</code> or <code>ChannelARN</code> in <code>CLOUD_STORAGE_MODE</code>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <code>StreamARN</code> or <code>ChannelARN</code> is not in Active status, try
        /// one of the following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <code>DescribeMediaStorageConfiguration</code> API to determine what the stream
        /// given channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeMappedResourceConfiguration</code> API to determine the channel
        /// that the given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>DescribeStream</code> or <code>DescribeSignalingChannel</code> API to determine
        /// the status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        public virtual Task<UpdateStreamResponse> UpdateStreamAsync(UpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}