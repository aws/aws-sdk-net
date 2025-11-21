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
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideo.Model;
using Amazon.KinesisVideo.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideo.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.KinesisVideo
{
    /// <summary>
    /// <para>Implementation for accessing KinesisVideo</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoClient : AmazonServiceClient, IAmazonKinesisVideo
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        /// <summary>
        /// Creates a signaling channel. 
        /// 
        ///  
        /// <para>
        ///  <c>CreateSignalingChannel</c> is an asynchronous operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalingChannel service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateSignalingChannel">REST API Reference for CreateSignalingChannel Operation</seealso>
        public virtual CreateSignalingChannelResponse CreateSignalingChannel(CreateSignalingChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<CreateSignalingChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalingChannel operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSignalingChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateSignalingChannel">REST API Reference for CreateSignalingChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateSignalingChannel(CreateSignalingChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSignalingChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSignalingChannel.</param>
        /// 
        /// <returns>Returns a  CreateSignalingChannelResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateSignalingChannel">REST API Reference for CreateSignalingChannel Operation</seealso>
        public virtual CreateSignalingChannelResponse EndCreateSignalingChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSignalingChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStream

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
        ///  <c>CreateStream</c> is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For information about how the service works, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/how-it-works.html">How
        /// it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must have permissions for the <c>KinesisVideo:CreateStream</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. A Kinesis
        /// video stream can support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual IAsyncResult BeginCreateStream(CreateStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStream.</param>
        /// 
        /// <returns>Returns a  CreateStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateStream">REST API Reference for CreateStream Operation</seealso>
        public virtual CreateStreamResponse EndCreateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEdgeConfiguration

        /// <summary>
        /// An asynchronous API that deletes a stream’s existing edge configuration, as well as
        /// the corresponding media from the Edge Agent.
        /// 
        ///  
        /// <para>
        /// When you invoke this API, the sync status is set to <c>DELETING</c>. A deletion process
        /// starts, in which active edge jobs are stopped and all media is deleted from the edge
        /// device. The time to delete varies, depending on the total amount of stored media.
        /// If the deletion process fails, the sync status changes to <c>DELETE_FAILED</c>. You
        /// will need to re-try the deletion.
        /// </para>
        ///  
        /// <para>
        /// When the deletion process has completed successfully, the edge configuration is no
        /// longer accessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEdgeConfiguration service method, as returned by KinesisVideo.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteEdgeConfiguration">REST API Reference for DeleteEdgeConfiguration Operation</seealso>
        public virtual DeleteEdgeConfigurationResponse DeleteEdgeConfiguration(DeleteEdgeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEdgeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEdgeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEdgeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteEdgeConfiguration">REST API Reference for DeleteEdgeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEdgeConfiguration(DeleteEdgeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEdgeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEdgeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEdgeConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEdgeConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteEdgeConfiguration">REST API Reference for DeleteEdgeConfiguration Operation</seealso>
        public virtual DeleteEdgeConfigurationResponse EndDeleteEdgeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEdgeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSignalingChannel

        /// <summary>
        /// Deletes a specified signaling channel. <c>DeleteSignalingChannel</c> is an asynchronous
        /// operation. If you don't specify the channel's current version, the most recent version
        /// is deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalingChannel service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        public virtual DeleteSignalingChannelResponse DeleteSignalingChannel(DeleteSignalingChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSignalingChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalingChannel operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSignalingChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteSignalingChannel">REST API Reference for DeleteSignalingChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteSignalingChannel(DeleteSignalingChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSignalingChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSignalingChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSignalingChannelResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteSignalingChannel">REST API Reference for DeleteSignalingChannel Operation</seealso>
        public virtual DeleteSignalingChannelResponse EndDeleteSignalingChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSignalingChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStream

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
        /// the latest stream version, use the <c>DescribeStream</c> API. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>KinesisVideo:DeleteStream</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        public virtual DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteStream(DeleteStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStream.</param>
        /// 
        /// <returns>Returns a  DeleteStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        public virtual DeleteStreamResponse EndDeleteStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEdgeConfiguration

        /// <summary>
        /// Describes a stream’s edge configuration that was set using the <c>StartEdgeConfigurationUpdate</c>
        /// API and the latest status of the edge agent's recorder and uploader jobs. Use this
        /// API to get the status of the configuration to determine if the configuration is in
        /// sync with the Edge Agent. Use this API to evaluate the health of the Edge Agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeConfiguration service method.</param>
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
        public virtual DescribeEdgeConfigurationResponse DescribeEdgeConfiguration(DescribeEdgeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeEdgeConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEdgeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEdgeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeEdgeConfiguration">REST API Reference for DescribeEdgeConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeEdgeConfiguration(DescribeEdgeConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEdgeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEdgeConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEdgeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEdgeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeEdgeConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeEdgeConfiguration">REST API Reference for DescribeEdgeConfiguration Operation</seealso>
        public virtual DescribeEdgeConfigurationResponse EndDescribeEdgeConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEdgeConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImageGenerationConfiguration

        /// <summary>
        /// Gets the <c>ImageGenerationConfiguration</c> for a given Kinesis video stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageGenerationConfiguration service method.</param>
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
        public virtual DescribeImageGenerationConfigurationResponse DescribeImageGenerationConfiguration(DescribeImageGenerationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageGenerationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeImageGenerationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageGenerationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageGenerationConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageGenerationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeImageGenerationConfiguration">REST API Reference for DescribeImageGenerationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeImageGenerationConfiguration(DescribeImageGenerationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageGenerationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageGenerationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageGenerationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeImageGenerationConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeImageGenerationConfiguration">REST API Reference for DescribeImageGenerationConfiguration Operation</seealso>
        public virtual DescribeImageGenerationConfigurationResponse EndDescribeImageGenerationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImageGenerationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMappedResourceConfiguration

        /// <summary>
        /// Returns the most current information about the stream. The <c>streamName</c> or <c>streamARN</c>
        /// should be provided in the input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMappedResourceConfiguration service method.</param>
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
        public virtual DescribeMappedResourceConfigurationResponse DescribeMappedResourceConfiguration(DescribeMappedResourceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMappedResourceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMappedResourceConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeMappedResourceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMappedResourceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMappedResourceConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMappedResourceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMappedResourceConfiguration">REST API Reference for DescribeMappedResourceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeMappedResourceConfiguration(DescribeMappedResourceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMappedResourceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMappedResourceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMappedResourceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMappedResourceConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeMappedResourceConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMappedResourceConfiguration">REST API Reference for DescribeMappedResourceConfiguration Operation</seealso>
        public virtual DescribeMappedResourceConfigurationResponse EndDescribeMappedResourceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMappedResourceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMediaStorageConfiguration

        /// <summary>
        /// Returns the most current information about the channel. Specify the <c>ChannelName</c>
        /// or <c>ChannelARN</c> in the input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMediaStorageConfiguration service method.</param>
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
        public virtual DescribeMediaStorageConfigurationResponse DescribeMediaStorageConfiguration(DescribeMediaStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMediaStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeMediaStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMediaStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMediaStorageConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMediaStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMediaStorageConfiguration">REST API Reference for DescribeMediaStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeMediaStorageConfiguration(DescribeMediaStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMediaStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMediaStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMediaStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeMediaStorageConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeMediaStorageConfiguration">REST API Reference for DescribeMediaStorageConfiguration Operation</seealso>
        public virtual DescribeMediaStorageConfigurationResponse EndDescribeMediaStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMediaStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotificationConfiguration

        /// <summary>
        /// Gets the <c>NotificationConfiguration</c> for a given Kinesis video stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfiguration service method.</param>
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
        public virtual DescribeNotificationConfigurationResponse DescribeNotificationConfiguration(DescribeNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeNotificationConfiguration">REST API Reference for DescribeNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotificationConfiguration(DescribeNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeNotificationConfiguration">REST API Reference for DescribeNotificationConfiguration Operation</seealso>
        public virtual DescribeNotificationConfigurationResponse EndDescribeNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSignalingChannel

        /// <summary>
        /// Returns the most current information about the signaling channel. You must specify
        /// either the name or the Amazon Resource Name (ARN) of the channel that you want to
        /// describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSignalingChannel service method.</param>
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
        public virtual DescribeSignalingChannelResponse DescribeSignalingChannel(DescribeSignalingChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeSignalingChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSignalingChannel operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSignalingChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeSignalingChannel">REST API Reference for DescribeSignalingChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeSignalingChannel(DescribeSignalingChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSignalingChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSignalingChannel.</param>
        /// 
        /// <returns>Returns a  DescribeSignalingChannelResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeSignalingChannel">REST API Reference for DescribeSignalingChannel Operation</seealso>
        public virtual DescribeSignalingChannelResponse EndDescribeSignalingChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSignalingChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStream

        /// <summary>
        /// Returns the most current information about the specified stream. You must specify
        /// either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
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
        public virtual DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual IAsyncResult BeginDescribeStream(DescribeStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStream.</param>
        /// 
        /// <returns>Returns a  DescribeStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        public virtual DescribeStreamResponse EndDescribeStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStreamStorageConfiguration

        /// <summary>
        /// Retrieves the current storage configuration for the specified Kinesis video stream.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        ///  
        /// <para>
        /// You must have permissions for the <c>KinesisVideo:DescribeStreamStorageConfiguration</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamStorageConfiguration service method, as returned by KinesisVideo.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStreamStorageConfiguration">REST API Reference for DescribeStreamStorageConfiguration Operation</seealso>
        public virtual DescribeStreamStorageConfigurationResponse DescribeStreamStorageConfiguration(DescribeStreamStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamStorageConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStreamStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStreamStorageConfiguration">REST API Reference for DescribeStreamStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeStreamStorageConfiguration(DescribeStreamStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStreamStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStreamStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStreamStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeStreamStorageConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStreamStorageConfiguration">REST API Reference for DescribeStreamStorageConfiguration Operation</seealso>
        public virtual DescribeStreamStorageConfigurationResponse EndDescribeStreamStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataEndpoint

        /// <summary>
        /// Gets an endpoint for a specified stream for either reading or writing. Use this endpoint
        /// in your application to read from the specified stream (using the <c>GetMedia</c> or
        /// <c>GetMediaForFragmentList</c> operations) or write to it (using the <c>PutMedia</c>
        /// operation). 
        /// 
        ///  <note> 
        /// <para>
        /// The returned endpoint does not have the API name appended. The client needs to add
        /// the API name to the returned endpoint.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, specify the stream either by <c>StreamName</c> or <c>StreamARN</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataEndpoint service method.</param>
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
        public virtual GetDataEndpointResponse GetDataEndpoint(GetDataEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDataEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataEndpoint operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetDataEndpoint">REST API Reference for GetDataEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetDataEndpoint(GetDataEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataEndpoint.</param>
        /// 
        /// <returns>Returns a  GetDataEndpointResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetDataEndpoint">REST API Reference for GetDataEndpoint Operation</seealso>
        public virtual GetDataEndpointResponse EndGetDataEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSignalingChannelEndpoint

        /// <summary>
        /// Provides an endpoint for the specified signaling channel to send and receive messages.
        /// This API uses the <c>SingleMasterChannelEndpointConfiguration</c> input parameter,
        /// which consists of the <c>Protocols</c> and <c>Role</c> properties.
        /// 
        ///  
        /// <para>
        ///  <c>Protocols</c> is used to determine the communication mechanism. For example, if
        /// you specify <c>WSS</c> as the protocol, this API produces a secure websocket endpoint.
        /// If you specify <c>HTTPS</c> as the protocol, this API generates an HTTPS endpoint.
        /// If you specify <c>WEBRTC</c> as the protocol, but the signaling channel isn't configured
        /// for ingestion, you will receive the error <c>InvalidArgumentException</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Role</c> determines the messaging permissions. A <c>MASTER</c> role results in
        /// this API generating an endpoint that a client can use to communicate with any of the
        /// viewers on the channel. A <c>VIEWER</c> role results in this API generating an endpoint
        /// that a client can use to communicate only with a <c>MASTER</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalingChannelEndpoint service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetSignalingChannelEndpoint">REST API Reference for GetSignalingChannelEndpoint Operation</seealso>
        public virtual GetSignalingChannelEndpointResponse GetSignalingChannelEndpoint(GetSignalingChannelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSignalingChannelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalingChannelEndpointResponseUnmarshaller.Instance;

            return Invoke<GetSignalingChannelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSignalingChannelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSignalingChannelEndpoint operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSignalingChannelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetSignalingChannelEndpoint">REST API Reference for GetSignalingChannelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetSignalingChannelEndpoint(GetSignalingChannelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSignalingChannelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSignalingChannelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSignalingChannelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSignalingChannelEndpoint.</param>
        /// 
        /// <returns>Returns a  GetSignalingChannelEndpointResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetSignalingChannelEndpoint">REST API Reference for GetSignalingChannelEndpoint Operation</seealso>
        public virtual GetSignalingChannelEndpointResponse EndGetSignalingChannelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSignalingChannelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEdgeAgentConfigurations

        /// <summary>
        /// Returns an array of edge configurations associated with the specified Edge Agent.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify the Edge Agent <c>HubDeviceArn</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgeAgentConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEdgeAgentConfigurations service method, as returned by KinesisVideo.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListEdgeAgentConfigurations">REST API Reference for ListEdgeAgentConfigurations Operation</seealso>
        public virtual ListEdgeAgentConfigurationsResponse ListEdgeAgentConfigurations(ListEdgeAgentConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEdgeAgentConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgeAgentConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEdgeAgentConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEdgeAgentConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEdgeAgentConfigurations operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEdgeAgentConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListEdgeAgentConfigurations">REST API Reference for ListEdgeAgentConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListEdgeAgentConfigurations(ListEdgeAgentConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEdgeAgentConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEdgeAgentConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEdgeAgentConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEdgeAgentConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEdgeAgentConfigurationsResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListEdgeAgentConfigurations">REST API Reference for ListEdgeAgentConfigurations Operation</seealso>
        public virtual ListEdgeAgentConfigurationsResponse EndListEdgeAgentConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEdgeAgentConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSignalingChannels

        /// <summary>
        /// Returns an array of <c>ChannelInfo</c> objects. Each object describes a signaling
        /// channel. To retrieve only those channels that satisfy a specific condition, you can
        /// specify a <c>ChannelNameCondition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalingChannels service method.</param>
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
        public virtual ListSignalingChannelsResponse ListSignalingChannels(ListSignalingChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSignalingChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalingChannelsResponseUnmarshaller.Instance;

            return Invoke<ListSignalingChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSignalingChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalingChannels operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalingChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListSignalingChannels">REST API Reference for ListSignalingChannels Operation</seealso>
        public virtual IAsyncResult BeginListSignalingChannels(ListSignalingChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSignalingChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSignalingChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalingChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalingChannels.</param>
        /// 
        /// <returns>Returns a  ListSignalingChannelsResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListSignalingChannels">REST API Reference for ListSignalingChannels Operation</seealso>
        public virtual ListSignalingChannelsResponse EndListSignalingChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSignalingChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreams

        /// <summary>
        /// Returns an array of <c>StreamInfo</c> objects. Each object describes a stream. To
        /// retrieve only streams that satisfy a specific condition, you can specify a <c>StreamNameCondition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
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
        public virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse EndListStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags associated with the specified signaling channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForStream

        /// <summary>
        /// Returns a list of tags associated with the specified stream.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
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
        /// The format of the <c>StreamARN</c> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual IAsyncResult BeginListTagsForStream(ListTagsForStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForStream.</param>
        /// 
        /// <returns>Returns a  ListTagsForStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        public virtual ListTagsForStreamResponse EndListTagsForStream(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  StartEdgeConfigurationUpdate

        /// <summary>
        /// An asynchronous API that updates a stream’s existing edge configuration. The Kinesis
        /// Video Stream will sync the stream’s edge configuration with the Edge Agent IoT Greengrass
        /// component that runs on an IoT Hub Device, setup at your premise. The time to sync
        /// can vary and depends on the connectivity of the Hub Device. The <c>SyncStatus</c>
        /// will be updated as the edge configuration is acknowledged, and synced with the Edge
        /// Agent. 
        /// 
        ///  
        /// <para>
        /// If this API is invoked for the first time, a new edge configuration will be created
        /// for the stream, and the sync status will be set to <c>SYNCING</c>. You will have to
        /// wait for the sync status to reach a terminal state such as: <c>IN_SYNC</c>, or <c>SYNC_FAILED</c>,
        /// before using this API again. If you invoke this API during the syncing process, a
        /// <c>ResourceInUseException</c> will be thrown. The connectivity of the stream’s edge
        /// configuration and the Edge Agent will be retried for 15 minutes. After 15 minutes,
        /// the status will transition into the <c>SYNC_FAILED</c> state.
        /// </para>
        ///  
        /// <para>
        /// To move an edge configuration from one device to another, use <a>DeleteEdgeConfiguration</a>
        /// to delete the current edge configuration. You can then invoke StartEdgeConfigurationUpdate
        /// with an updated Hub Device ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeConfigurationUpdate service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/StartEdgeConfigurationUpdate">REST API Reference for StartEdgeConfigurationUpdate Operation</seealso>
        public virtual StartEdgeConfigurationUpdateResponse StartEdgeConfigurationUpdate(StartEdgeConfigurationUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartEdgeConfigurationUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeConfigurationUpdateResponseUnmarshaller.Instance;

            return Invoke<StartEdgeConfigurationUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartEdgeConfigurationUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeConfigurationUpdate operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEdgeConfigurationUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/StartEdgeConfigurationUpdate">REST API Reference for StartEdgeConfigurationUpdate Operation</seealso>
        public virtual IAsyncResult BeginStartEdgeConfigurationUpdate(StartEdgeConfigurationUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartEdgeConfigurationUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEdgeConfigurationUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEdgeConfigurationUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEdgeConfigurationUpdate.</param>
        /// 
        /// <returns>Returns a  StartEdgeConfigurationUpdateResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/StartEdgeConfigurationUpdate">REST API Reference for StartEdgeConfigurationUpdate Operation</seealso>
        public virtual StartEdgeConfigurationUpdateResponse EndStartEdgeConfigurationUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEdgeConfigurationUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to a signaling channel. A <i>tag</i> is a key-value pair (the
        /// value is optional) that you can define and assign to Amazon Web Services resources.
        /// If you specify a tag that already exists, the tag value is replaced with the value
        /// that you specify in the request. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management and Cost Management
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagStream

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
        /// You must provide either the <c>StreamName</c> or the <c>StreamARN</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>KinesisVideo:TagStream</c> action.
        /// </para>
        ///  
        /// <para>
        /// A Kinesis video stream can support up to 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagStream service method.</param>
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
        /// The format of the <c>StreamARN</c> is invalid.
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
        public virtual TagStreamResponse TagStream(TagStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagStreamResponseUnmarshaller.Instance;

            return Invoke<TagStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagStream">REST API Reference for TagStream Operation</seealso>
        public virtual IAsyncResult BeginTagStream(TagStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagStream.</param>
        /// 
        /// <returns>Returns a  TagStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagStream">REST API Reference for TagStream Operation</seealso>
        public virtual TagStreamResponse EndTagStream(IAsyncResult asyncResult)
        {
            return EndInvoke<TagStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a signaling channel. In the request, specify only a
        /// tag key or keys; don't specify the value. If you specify a tag key that does not exist,
        /// it's ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagStream

        /// <summary>
        /// Removes one or more tags from a stream. In the request, specify only a tag key or
        /// keys; don't specify the value. If you specify a tag key that does not exist, it's
        /// ignored.
        /// 
        ///  
        /// <para>
        /// In the request, you must provide the <c>StreamName</c> or <c>StreamARN</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagStream service method.</param>
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
        /// The format of the <c>StreamARN</c> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagStream">REST API Reference for UntagStream Operation</seealso>
        public virtual UntagStreamResponse UntagStream(UntagStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagStreamResponseUnmarshaller.Instance;

            return Invoke<UntagStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagStream">REST API Reference for UntagStream Operation</seealso>
        public virtual IAsyncResult BeginUntagStream(UntagStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagStream.</param>
        /// 
        /// <returns>Returns a  UntagStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagStream">REST API Reference for UntagStream Operation</seealso>
        public virtual UntagStreamResponse EndUntagStream(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataRetention

        /// <summary>
        /// Increases or decreases the stream's data retention period by the value that you specify.
        /// To indicate whether you want to increase or decrease the data retention period, specify
        /// the <c>Operation</c> parameter in the request body. In the request, you must specify
        /// either the <c>StreamName</c> or the <c>StreamARN</c>. 
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <c>KinesisVideo:UpdateDataRetention</c>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        public virtual UpdateDataRetentionResponse UpdateDataRetention(UpdateDataRetentionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return Invoke<UpdateDataRetentionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataRetention
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataRetention(UpdateDataRetentionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRetentionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataRetention operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataRetention.</param>
        /// 
        /// <returns>Returns a  UpdateDataRetentionResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        public virtual UpdateDataRetentionResponse EndUpdateDataRetention(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataRetentionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateImageGenerationConfiguration

        /// <summary>
        /// Updates the <c>StreamInfo</c> and <c>ImageProcessingConfiguration</c> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageGenerationConfiguration service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateImageGenerationConfiguration">REST API Reference for UpdateImageGenerationConfiguration Operation</seealso>
        public virtual UpdateImageGenerationConfigurationResponse UpdateImageGenerationConfiguration(UpdateImageGenerationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageGenerationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateImageGenerationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImageGenerationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageGenerationConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImageGenerationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateImageGenerationConfiguration">REST API Reference for UpdateImageGenerationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateImageGenerationConfiguration(UpdateImageGenerationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateImageGenerationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateImageGenerationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImageGenerationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImageGenerationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateImageGenerationConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateImageGenerationConfiguration">REST API Reference for UpdateImageGenerationConfiguration Operation</seealso>
        public virtual UpdateImageGenerationConfigurationResponse EndUpdateImageGenerationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateImageGenerationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMediaStorageConfiguration

        /// <summary>
        /// Associates a <c>SignalingChannel</c> to a stream to store the media. There are two
        /// signaling modes that you can specify :
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If <c>StorageStatus</c> is enabled, the data will be stored in the <c>StreamARN</c>
        /// provided. In order for WebRTC Ingestion to work, the stream must have data retention
        /// enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>StorageStatus</c> is disabled, no data will be stored, and the <c>StreamARN</c>
        /// parameter will not be needed. 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If <c>StorageStatus</c> is enabled, direct peer-to-peer (master-viewer) connections
        /// no longer occur. Peers connect directly to the storage session. You must call the
        /// <c>JoinStorageSession</c> API to trigger an SDP offer send and establish a connection
        /// between a peer and the storage session. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaStorageConfiguration service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateMediaStorageConfiguration">REST API Reference for UpdateMediaStorageConfiguration Operation</seealso>
        public virtual UpdateMediaStorageConfigurationResponse UpdateMediaStorageConfiguration(UpdateMediaStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMediaStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMediaStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMediaStorageConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMediaStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateMediaStorageConfiguration">REST API Reference for UpdateMediaStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateMediaStorageConfiguration(UpdateMediaStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMediaStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMediaStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMediaStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMediaStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateMediaStorageConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateMediaStorageConfiguration">REST API Reference for UpdateMediaStorageConfiguration Operation</seealso>
        public virtual UpdateMediaStorageConfigurationResponse EndUpdateMediaStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMediaStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNotificationConfiguration

        /// <summary>
        /// Updates the notification information for a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse UpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotificationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateNotificationConfiguration">REST API Reference for UpdateNotificationConfiguration Operation</seealso>
        public virtual UpdateNotificationConfigurationResponse EndUpdateNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSignalingChannel

        /// <summary>
        /// Updates the existing signaling channel. This is an asynchronous operation and takes
        /// time to complete. 
        /// 
        ///  
        /// <para>
        /// If the <c>MessageTtlSeconds</c> value is updated (either increased or reduced), it
        /// only applies to new messages sent via this channel after it's been updated. Existing
        /// messages are still expired as per the previous <c>MessageTtlSeconds</c> value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalingChannel service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        public virtual UpdateSignalingChannelResponse UpdateSignalingChannel(UpdateSignalingChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalingChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSignalingChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalingChannel operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSignalingChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateSignalingChannel">REST API Reference for UpdateSignalingChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateSignalingChannel(UpdateSignalingChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSignalingChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSignalingChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSignalingChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSignalingChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSignalingChannelResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateSignalingChannel">REST API Reference for UpdateSignalingChannel Operation</seealso>
        public virtual UpdateSignalingChannelResponse EndUpdateSignalingChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSignalingChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStream

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
        /// the latest stream version, use the <c>DescribeStream</c> API. 
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateStream</c> is an asynchronous operation, and takes time to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        public virtual UpdateStreamResponse UpdateStream(UpdateStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        public virtual IAsyncResult BeginUpdateStream(UpdateStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStream.</param>
        /// 
        /// <returns>Returns a  UpdateStreamResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        public virtual UpdateStreamResponse EndUpdateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStreamStorageConfiguration

        /// <summary>
        /// Updates the storage configuration for an existing Kinesis video stream.
        /// 
        ///  
        /// <para>
        /// This operation allows you to modify the storage tier settings for a stream, enabling
        /// you to optimize storage costs and performance based on your access patterns.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateStreamStorageConfiguration</c> is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// You must have permissions for the <c>KinesisVideo:UpdateStreamStorageConfiguration</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamStorageConfiguration service method, as returned by KinesisVideo.</returns>
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
        /// When the input <c>StreamARN</c> or <c>ChannelARN</c> in <c>CLOUD_STORAGE_MODE</c>
        /// is already mapped to a different Kinesis Video Stream resource, or if the provided
        /// input <c>StreamARN</c> or <c>ChannelARN</c> is not in Active status, try one of the
        /// following : 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// The <c>DescribeMediaStorageConfiguration</c> API to determine what the stream given
        /// channel is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeMappedResourceConfiguration</c> API to determine the channel that the
        /// given stream is mapped to. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>DescribeStream</c> or <c>DescribeSignalingChannel</c> API to determine the
        /// status of the resource. 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStreamStorageConfiguration">REST API Reference for UpdateStreamStorageConfiguration Operation</seealso>
        public virtual UpdateStreamStorageConfigurationResponse UpdateStreamStorageConfiguration(UpdateStreamStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateStreamStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamStorageConfiguration operation on AmazonKinesisVideoClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStreamStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStreamStorageConfiguration">REST API Reference for UpdateStreamStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateStreamStorageConfiguration(UpdateStreamStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStreamStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStreamStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateStreamStorageConfigurationResult from KinesisVideo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStreamStorageConfiguration">REST API Reference for UpdateStreamStorageConfiguration Operation</seealso>
        public virtual UpdateStreamStorageConfigurationResponse EndUpdateStreamStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStreamStorageConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonKinesisVideoEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}