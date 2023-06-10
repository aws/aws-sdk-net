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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaTailor.Model;
using Amazon.MediaTailor.Model.Internal.MarshallTransformations;
using Amazon.MediaTailor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaTailor
{
    /// <summary>
    /// Implementation for accessing MediaTailor
    ///
    /// Use the AWS Elemental MediaTailor SDKs and CLI to configure scalable ad insertion
    /// and linear channels. With MediaTailor, you can assemble existing content into a linear
    /// stream and serve targeted ads to viewers while maintaining broadcast quality in over-the-top
    /// (OTT) video applications. For information about using the service, including detailed
    /// information about the settings covered in this guide, see the <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/">AWS
    /// Elemental MediaTailor User Guide</a>.
    /// 
    ///  
    /// <para>
    /// Through the SDKs and the CLI you manage AWS Elemental MediaTailor configurations and
    /// channels the same as you do through the console. For example, you specify ad insertion
    /// behavior and mapping information for the origin server and the ad decision server
    /// (ADS).
    /// </para>
    /// </summary>
    public partial class AmazonMediaTailorClient : AmazonServiceClient, IAmazonMediaTailor
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaTailorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        public AmazonMediaTailorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaTailorConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        public AmazonMediaTailorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaTailorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(AmazonMediaTailorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaTailorClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaTailorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials and an
        /// AmazonMediaTailorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(AWSCredentials credentials, AmazonMediaTailorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaTailorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaTailorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaTailorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaTailorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaTailorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaTailorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMediaTailorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaTailorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaTailorPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaTailorEndpointResolver());
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


        #region  ConfigureLogsForChannel

        internal virtual ConfigureLogsForChannelResponse ConfigureLogsForChannel(ConfigureLogsForChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForChannelResponseUnmarshaller.Instance;

            return Invoke<ConfigureLogsForChannelResponse>(request, options);
        }



        /// <summary>
        /// Configures Amazon CloudWatch log settings for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        public virtual Task<ConfigureLogsForChannelResponse> ConfigureLogsForChannelAsync(ConfigureLogsForChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForChannelResponseUnmarshaller.Instance;

            return InvokeAsync<ConfigureLogsForChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfigureLogsForPlaybackConfiguration

        internal virtual ConfigureLogsForPlaybackConfigurationResponse ConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<ConfigureLogsForPlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Amazon CloudWatch log settings for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        public virtual Task<ConfigureLogsForPlaybackConfigurationResponse> ConfigureLogsForPlaybackConfigurationAsync(ConfigureLogsForPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ConfigureLogsForPlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }



        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLiveSource

        internal virtual CreateLiveSourceResponse CreateLiveSource(CreateLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLiveSourceResponseUnmarshaller.Instance;

            return Invoke<CreateLiveSourceResponse>(request, options);
        }



        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        public virtual Task<CreateLiveSourceResponse> CreateLiveSourceAsync(CreateLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLiveSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLiveSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePrefetchSchedule

        internal virtual CreatePrefetchScheduleResponse CreatePrefetchSchedule(CreatePrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<CreatePrefetchScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        public virtual Task<CreatePrefetchScheduleResponse> CreatePrefetchScheduleAsync(CreatePrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrefetchScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrefetchScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProgram

        internal virtual CreateProgramResponse CreateProgram(CreateProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramResponseUnmarshaller.Instance;

            return Invoke<CreateProgramResponse>(request, options);
        }



        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        public virtual Task<CreateProgramResponse> CreateProgramAsync(CreateProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSourceLocation

        internal virtual CreateSourceLocationResponse CreateSourceLocation(CreateSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceLocationResponseUnmarshaller.Instance;

            return Invoke<CreateSourceLocationResponse>(request, options);
        }



        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        public virtual Task<CreateSourceLocationResponse> CreateSourceLocationAsync(CreateSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceLocationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSourceLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVodSource

        internal virtual CreateVodSourceResponse CreateVodSource(CreateVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVodSourceResponseUnmarshaller.Instance;

            return Invoke<CreateVodSourceResponse>(request, options);
        }



        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        public virtual Task<CreateVodSourceResponse> CreateVodSourceAsync(CreateVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVodSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVodSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelPolicy

        internal virtual DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelPolicyResponse>(request, options);
        }



        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual Task<DeleteChannelPolicyResponse> DeleteChannelPolicyAsync(DeleteChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLiveSource

        internal virtual DeleteLiveSourceResponse DeleteLiveSource(DeleteLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLiveSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteLiveSourceResponse>(request, options);
        }



        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        public virtual Task<DeleteLiveSourceResponse> DeleteLiveSourceAsync(DeleteLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLiveSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLiveSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlaybackConfiguration

        internal virtual DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual Task<DeletePlaybackConfigurationResponse> DeletePlaybackConfigurationAsync(DeletePlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePrefetchSchedule

        internal virtual DeletePrefetchScheduleResponse DeletePrefetchSchedule(DeletePrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<DeletePrefetchScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <code>DeletePrefetchSchedule</code>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        public virtual Task<DeletePrefetchScheduleResponse> DeletePrefetchScheduleAsync(DeletePrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrefetchScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePrefetchScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProgram

        internal virtual DeleteProgramResponse DeleteProgram(DeleteProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramResponseUnmarshaller.Instance;

            return Invoke<DeleteProgramResponse>(request, options);
        }



        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        public virtual Task<DeleteProgramResponse> DeleteProgramAsync(DeleteProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSourceLocation

        internal virtual DeleteSourceLocationResponse DeleteSourceLocation(DeleteSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceLocationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        public virtual Task<DeleteSourceLocationResponse> DeleteSourceLocationAsync(DeleteSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSourceLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVodSource

        internal virtual DeleteVodSourceResponse DeleteVodSource(DeleteVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVodSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteVodSourceResponse>(request, options);
        }



        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        public virtual Task<DeleteVodSourceResponse> DeleteVodSourceAsync(DeleteVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVodSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVodSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel

        internal virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }



        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLiveSource

        internal virtual DescribeLiveSourceResponse DescribeLiveSource(DescribeLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLiveSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeLiveSourceResponse>(request, options);
        }



        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        public virtual Task<DescribeLiveSourceResponse> DescribeLiveSourceAsync(DescribeLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLiveSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLiveSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProgram

        internal virtual DescribeProgramResponse DescribeProgram(DescribeProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProgramResponseUnmarshaller.Instance;

            return Invoke<DescribeProgramResponse>(request, options);
        }



        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        public virtual Task<DescribeProgramResponse> DescribeProgramAsync(DescribeProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProgramResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSourceLocation

        internal virtual DescribeSourceLocationResponse DescribeSourceLocation(DescribeSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceLocationResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceLocationResponse>(request, options);
        }



        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        public virtual Task<DescribeSourceLocationResponse> DescribeSourceLocationAsync(DescribeSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSourceLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVodSource

        internal virtual DescribeVodSourceResponse DescribeVodSource(DescribeVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVodSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeVodSourceResponse>(request, options);
        }



        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        public virtual Task<DescribeVodSourceResponse> DescribeVodSourceAsync(DescribeVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVodSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVodSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelPolicy

        internal virtual GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<GetChannelPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual Task<GetChannelPolicyResponse> GetChannelPolicyAsync(GetChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelSchedule

        internal virtual GetChannelScheduleResponse GetChannelSchedule(GetChannelScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelScheduleResponseUnmarshaller.Instance;

            return Invoke<GetChannelScheduleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        public virtual Task<GetChannelScheduleResponse> GetChannelScheduleAsync(GetChannelScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlaybackConfiguration

        internal virtual GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual Task<GetPlaybackConfigurationResponse> GetPlaybackConfigurationAsync(GetPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPrefetchSchedule

        internal virtual GetPrefetchScheduleResponse GetPrefetchSchedule(GetPrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<GetPrefetchScheduleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        public virtual Task<GetPrefetchScheduleResponse> GetPrefetchScheduleAsync(GetPrefetchScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrefetchScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<GetPrefetchScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlerts

        internal virtual ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return Invoke<ListAlertsResponse>(request, options);
        }



        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAlertsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLiveSources

        internal virtual ListLiveSourcesResponse ListLiveSources(ListLiveSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLiveSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLiveSourcesResponseUnmarshaller.Instance;

            return Invoke<ListLiveSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        public virtual Task<ListLiveSourcesResponse> ListLiveSourcesAsync(ListLiveSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLiveSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLiveSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLiveSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlaybackConfigurations

        internal virtual ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual Task<ListPlaybackConfigurationsResponse> ListPlaybackConfigurationsAsync(ListPlaybackConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlaybackConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrefetchSchedules

        internal virtual ListPrefetchSchedulesResponse ListPrefetchSchedules(ListPrefetchSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrefetchSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrefetchSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListPrefetchSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        public virtual Task<ListPrefetchSchedulesResponse> ListPrefetchSchedulesAsync(ListPrefetchSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrefetchSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrefetchSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrefetchSchedulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSourceLocations

        internal virtual ListSourceLocationsResponse ListSourceLocations(ListSourceLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceLocationsResponseUnmarshaller.Instance;

            return Invoke<ListSourceLocationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        public virtual Task<ListSourceLocationsResponse> ListSourceLocationsAsync(ListSourceLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSourceLocationsResponse>(request, options, cancellationToken);
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
        /// A list of tags that are associated with this resource. Tags are key-value pairs that
        /// you can associate with Amazon resources to help with organization, access control,
        /// and cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVodSources

        internal virtual ListVodSourcesResponse ListVodSources(ListVodSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVodSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVodSourcesResponseUnmarshaller.Instance;

            return Invoke<ListVodSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        public virtual Task<ListVodSourcesResponse> ListVodSourcesAsync(ListVodSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVodSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVodSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVodSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutChannelPolicy

        internal virtual PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<PutChannelPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual Task<PutChannelPolicyResponse> PutChannelPolicyAsync(PutChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPlaybackConfiguration

        internal virtual PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual Task<PutPlaybackConfigurationResponse> PutPlaybackConfigurationAsync(PutPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutPlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartChannel

        internal virtual StartChannelResponse StartChannel(StartChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return Invoke<StartChannelResponse>(request, options);
        }



        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual Task<StartChannelResponse> StartChannelAsync(StartChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return InvokeAsync<StartChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopChannel

        internal virtual StopChannelResponse StopChannel(StopChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return Invoke<StopChannelResponse>(request, options);
        }



        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return InvokeAsync<StopChannelResponse>(request, options, cancellationToken);
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
        /// The resource to tag. Tags are key-value pairs that you can associate with Amazon resources
        /// to help with organization, access control, and cost tracking. For more information,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }



        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLiveSource

        internal virtual UpdateLiveSourceResponse UpdateLiveSource(UpdateLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLiveSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateLiveSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        public virtual Task<UpdateLiveSourceResponse> UpdateLiveSourceAsync(UpdateLiveSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLiveSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLiveSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProgram

        internal virtual UpdateProgramResponse UpdateProgram(UpdateProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramResponseUnmarshaller.Instance;

            return Invoke<UpdateProgramResponse>(request, options);
        }



        /// <summary>
        /// Updates a program within a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        public virtual Task<UpdateProgramResponse> UpdateProgramAsync(UpdateProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSourceLocation

        internal virtual UpdateSourceLocationResponse UpdateSourceLocation(UpdateSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceLocationResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceLocationResponse>(request, options);
        }



        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        public virtual Task<UpdateSourceLocationResponse> UpdateSourceLocationAsync(UpdateSourceLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceLocationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSourceLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVodSource

        internal virtual UpdateVodSourceResponse UpdateVodSource(UpdateVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVodSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateVodSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        public virtual Task<UpdateVodSourceResponse> UpdateVodSourceAsync(UpdateVodSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVodSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVodSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}