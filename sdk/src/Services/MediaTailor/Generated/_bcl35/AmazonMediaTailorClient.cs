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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Configures Amazon CloudWatch log settings for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel service method.</param>
        /// 
        /// <returns>The response from the ConfigureLogsForChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        public virtual ConfigureLogsForChannelResponse ConfigureLogsForChannel(ConfigureLogsForChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForChannelResponseUnmarshaller.Instance;

            return Invoke<ConfigureLogsForChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureLogsForChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureLogsForChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        public virtual IAsyncResult BeginConfigureLogsForChannel(ConfigureLogsForChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureLogsForChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureLogsForChannel.</param>
        /// 
        /// <returns>Returns a  ConfigureLogsForChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForChannel">REST API Reference for ConfigureLogsForChannel Operation</seealso>
        public virtual ConfigureLogsForChannelResponse EndConfigureLogsForChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfigureLogsForChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfigureLogsForPlaybackConfiguration

        /// <summary>
        /// Amazon CloudWatch log settings for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the ConfigureLogsForPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        public virtual ConfigureLogsForPlaybackConfigurationResponse ConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<ConfigureLogsForPlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureLogsForPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureLogsForPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureLogsForPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginConfigureLogsForPlaybackConfiguration(ConfigureLogsForPlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureLogsForPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureLogsForPlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureLogsForPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureLogsForPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  ConfigureLogsForPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ConfigureLogsForPlaybackConfiguration">REST API Reference for ConfigureLogsForPlaybackConfiguration Operation</seealso>
        public virtual ConfigureLogsForPlaybackConfigurationResponse EndConfigureLogsForPlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfigureLogsForPlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLiveSource

        /// <summary>
        /// The live source configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource service method.</param>
        /// 
        /// <returns>The response from the CreateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        public virtual CreateLiveSourceResponse CreateLiveSource(CreateLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLiveSourceResponseUnmarshaller.Instance;

            return Invoke<CreateLiveSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        public virtual IAsyncResult BeginCreateLiveSource(CreateLiveSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLiveSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLiveSource.</param>
        /// 
        /// <returns>Returns a  CreateLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateLiveSource">REST API Reference for CreateLiveSource Operation</seealso>
        public virtual CreateLiveSourceResponse EndCreateLiveSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLiveSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePrefetchSchedule

        /// <summary>
        /// Creates a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the CreatePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        public virtual CreatePrefetchScheduleResponse CreatePrefetchSchedule(CreatePrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<CreatePrefetchScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        public virtual IAsyncResult BeginCreatePrefetchSchedule(CreatePrefetchScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrefetchScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  CreatePrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreatePrefetchSchedule">REST API Reference for CreatePrefetchSchedule Operation</seealso>
        public virtual CreatePrefetchScheduleResponse EndCreatePrefetchSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePrefetchScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProgram

        /// <summary>
        /// Creates a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram service method.</param>
        /// 
        /// <returns>The response from the CreateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        public virtual CreateProgramResponse CreateProgram(CreateProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramResponseUnmarshaller.Instance;

            return Invoke<CreateProgramResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        public virtual IAsyncResult BeginCreateProgram(CreateProgramRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgramResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgram.</param>
        /// 
        /// <returns>Returns a  CreateProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateProgram">REST API Reference for CreateProgram Operation</seealso>
        public virtual CreateProgramResponse EndCreateProgram(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProgramResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSourceLocation

        /// <summary>
        /// Creates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation service method.</param>
        /// 
        /// <returns>The response from the CreateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        public virtual CreateSourceLocationResponse CreateSourceLocation(CreateSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceLocationResponseUnmarshaller.Instance;

            return Invoke<CreateSourceLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        public virtual IAsyncResult BeginCreateSourceLocation(CreateSourceLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSourceLocation.</param>
        /// 
        /// <returns>Returns a  CreateSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateSourceLocation">REST API Reference for CreateSourceLocation Operation</seealso>
        public virtual CreateSourceLocationResponse EndCreateSourceLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSourceLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVodSource

        /// <summary>
        /// The VOD source configuration parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource service method.</param>
        /// 
        /// <returns>The response from the CreateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        public virtual CreateVodSourceResponse CreateVodSource(CreateVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVodSourceResponseUnmarshaller.Instance;

            return Invoke<CreateVodSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        public virtual IAsyncResult BeginCreateVodSource(CreateVodSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVodSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVodSource.</param>
        /// 
        /// <returns>Returns a  CreateVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/CreateVodSource">REST API Reference for CreateVodSource Operation</seealso>
        public virtual CreateVodSourceResponse EndCreateVodSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVodSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

        /// <summary>
        /// Deletes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelPolicy

        /// <summary>
        /// The channel policy to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelPolicy(DeleteChannelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual DeleteChannelPolicyResponse EndDeleteChannelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLiveSource

        /// <summary>
        /// The live source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource service method.</param>
        /// 
        /// <returns>The response from the DeleteLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        public virtual DeleteLiveSourceResponse DeleteLiveSource(DeleteLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLiveSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteLiveSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteLiveSource(DeleteLiveSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLiveSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLiveSource.</param>
        /// 
        /// <returns>Returns a  DeleteLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteLiveSource">REST API Reference for DeleteLiveSource Operation</seealso>
        public virtual DeleteLiveSourceResponse EndDeleteLiveSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLiveSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlaybackConfiguration

        /// <summary>
        /// Deletes a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual DeletePlaybackConfigurationResponse EndDeletePlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePrefetchSchedule

        /// <summary>
        /// Deletes a prefetch schedule for a specific playback configuration. If you call <code>DeletePrefetchSchedule</code>
        /// on an expired prefetch schedule, MediaTailor returns an HTTP 404 status code. For
        /// more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the DeletePrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        public virtual DeletePrefetchScheduleResponse DeletePrefetchSchedule(DeletePrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<DeletePrefetchScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        public virtual IAsyncResult BeginDeletePrefetchSchedule(DeletePrefetchScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrefetchScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  DeletePrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePrefetchSchedule">REST API Reference for DeletePrefetchSchedule Operation</seealso>
        public virtual DeletePrefetchScheduleResponse EndDeletePrefetchSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePrefetchScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProgram

        /// <summary>
        /// Deletes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram service method.</param>
        /// 
        /// <returns>The response from the DeleteProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        public virtual DeleteProgramResponse DeleteProgram(DeleteProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramResponseUnmarshaller.Instance;

            return Invoke<DeleteProgramResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        public virtual IAsyncResult BeginDeleteProgram(DeleteProgramRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgramResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgram.</param>
        /// 
        /// <returns>Returns a  DeleteProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteProgram">REST API Reference for DeleteProgram Operation</seealso>
        public virtual DeleteProgramResponse EndDeleteProgram(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProgramResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSourceLocation

        /// <summary>
        /// Deletes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        public virtual DeleteSourceLocationResponse DeleteSourceLocation(DeleteSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        public virtual IAsyncResult BeginDeleteSourceLocation(DeleteSourceLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceLocation.</param>
        /// 
        /// <returns>Returns a  DeleteSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteSourceLocation">REST API Reference for DeleteSourceLocation Operation</seealso>
        public virtual DeleteSourceLocationResponse EndDeleteSourceLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSourceLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVodSource

        /// <summary>
        /// The video on demand (VOD) source to delete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource service method.</param>
        /// 
        /// <returns>The response from the DeleteVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        public virtual DeleteVodSourceResponse DeleteVodSource(DeleteVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVodSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteVodSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteVodSource(DeleteVodSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVodSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVodSource.</param>
        /// 
        /// <returns>Returns a  DeleteVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeleteVodSource">REST API Reference for DeleteVodSource Operation</seealso>
        public virtual DeleteVodSourceResponse EndDeleteVodSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVodSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannel

        /// <summary>
        /// Describes a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLiveSource

        /// <summary>
        /// The live source to describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource service method.</param>
        /// 
        /// <returns>The response from the DescribeLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        public virtual DescribeLiveSourceResponse DescribeLiveSource(DescribeLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLiveSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeLiveSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        public virtual IAsyncResult BeginDescribeLiveSource(DescribeLiveSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLiveSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLiveSource.</param>
        /// 
        /// <returns>Returns a  DescribeLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeLiveSource">REST API Reference for DescribeLiveSource Operation</seealso>
        public virtual DescribeLiveSourceResponse EndDescribeLiveSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLiveSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProgram

        /// <summary>
        /// Describes a program within a channel. For information about programs, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-programs.html">Working
        /// with programs</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram service method.</param>
        /// 
        /// <returns>The response from the DescribeProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        public virtual DescribeProgramResponse DescribeProgram(DescribeProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProgramResponseUnmarshaller.Instance;

            return Invoke<DescribeProgramResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        public virtual IAsyncResult BeginDescribeProgram(DescribeProgramRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProgramResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProgram.</param>
        /// 
        /// <returns>Returns a  DescribeProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeProgram">REST API Reference for DescribeProgram Operation</seealso>
        public virtual DescribeProgramResponse EndDescribeProgram(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProgramResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSourceLocation

        /// <summary>
        /// Describes a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        public virtual DescribeSourceLocationResponse DescribeSourceLocation(DescribeSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceLocationResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        public virtual IAsyncResult BeginDescribeSourceLocation(DescribeSourceLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceLocation.</param>
        /// 
        /// <returns>Returns a  DescribeSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeSourceLocation">REST API Reference for DescribeSourceLocation Operation</seealso>
        public virtual DescribeSourceLocationResponse EndDescribeSourceLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSourceLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVodSource

        /// <summary>
        /// Provides details about a specific video on demand (VOD) source in a specific source
        /// location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource service method.</param>
        /// 
        /// <returns>The response from the DescribeVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        public virtual DescribeVodSourceResponse DescribeVodSource(DescribeVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVodSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeVodSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        public virtual IAsyncResult BeginDescribeVodSource(DescribeVodSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVodSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVodSource.</param>
        /// 
        /// <returns>Returns a  DescribeVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DescribeVodSource">REST API Reference for DescribeVodSource Operation</seealso>
        public virtual DescribeVodSourceResponse EndDescribeVodSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVodSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelPolicy

        /// <summary>
        /// Returns the channel's IAM policy. IAM policies are used to control access to your
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<GetChannelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetChannelPolicy(GetChannelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelPolicy.</param>
        /// 
        /// <returns>Returns a  GetChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual GetChannelPolicyResponse EndGetChannelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelSchedule

        /// <summary>
        /// Retrieves information about your channel's schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule service method.</param>
        /// 
        /// <returns>The response from the GetChannelSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        public virtual GetChannelScheduleResponse GetChannelSchedule(GetChannelScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelScheduleResponseUnmarshaller.Instance;

            return Invoke<GetChannelScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        public virtual IAsyncResult BeginGetChannelSchedule(GetChannelScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelSchedule.</param>
        /// 
        /// <returns>Returns a  GetChannelScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetChannelSchedule">REST API Reference for GetChannelSchedule Operation</seealso>
        public virtual GetChannelScheduleResponse EndGetChannelSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlaybackConfiguration

        /// <summary>
        /// Retrieves a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetPlaybackConfiguration(GetPlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  GetPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual GetPlaybackConfigurationResponse EndGetPlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPrefetchSchedule

        /// <summary>
        /// Retrieves a prefetch schedule for a playback configuration. A prefetch schedule allows
        /// you to tell MediaTailor to fetch and prepare certain ads before an ad break happens.
        /// For more information about ad prefetching, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/prefetching-ads.html">Using
        /// ad prefetching</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule service method.</param>
        /// 
        /// <returns>The response from the GetPrefetchSchedule service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        public virtual GetPrefetchScheduleResponse GetPrefetchSchedule(GetPrefetchScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrefetchScheduleResponseUnmarshaller.Instance;

            return Invoke<GetPrefetchScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPrefetchSchedule operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPrefetchSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        public virtual IAsyncResult BeginGetPrefetchSchedule(GetPrefetchScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPrefetchScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrefetchScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPrefetchSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPrefetchSchedule.</param>
        /// 
        /// <returns>Returns a  GetPrefetchScheduleResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPrefetchSchedule">REST API Reference for GetPrefetchSchedule Operation</seealso>
        public virtual GetPrefetchScheduleResponse EndGetPrefetchSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPrefetchScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAlerts

        /// <summary>
        /// Lists the alerts that are associated with a MediaTailor channel assembly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual ListAlertsResponse ListAlerts(ListAlertsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return Invoke<ListAlertsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual IAsyncResult BeginListAlerts(ListAlertsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlertsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlertsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlerts.</param>
        /// 
        /// <returns>Returns a  ListAlertsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        public virtual ListAlertsResponse EndListAlerts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAlertsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Retrieves information about the channels that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLiveSources

        /// <summary>
        /// Lists the live sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources service method.</param>
        /// 
        /// <returns>The response from the ListLiveSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        public virtual ListLiveSourcesResponse ListLiveSources(ListLiveSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLiveSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLiveSourcesResponseUnmarshaller.Instance;

            return Invoke<ListLiveSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLiveSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLiveSources operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLiveSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        public virtual IAsyncResult BeginListLiveSources(ListLiveSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLiveSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLiveSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLiveSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLiveSources.</param>
        /// 
        /// <returns>Returns a  ListLiveSourcesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListLiveSources">REST API Reference for ListLiveSources Operation</seealso>
        public virtual ListLiveSourcesResponse EndListLiveSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLiveSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlaybackConfigurations

        /// <summary>
        /// Retrieves existing playback configurations. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with Configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaybackConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListPlaybackConfigurations(ListPlaybackConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaybackConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPlaybackConfigurationsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual ListPlaybackConfigurationsResponse EndListPlaybackConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlaybackConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrefetchSchedules

        /// <summary>
        /// Lists the prefetch schedules for a playback configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules service method.</param>
        /// 
        /// <returns>The response from the ListPrefetchSchedules service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        public virtual ListPrefetchSchedulesResponse ListPrefetchSchedules(ListPrefetchSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrefetchSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrefetchSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListPrefetchSchedulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrefetchSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrefetchSchedules operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrefetchSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        public virtual IAsyncResult BeginListPrefetchSchedules(ListPrefetchSchedulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPrefetchSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrefetchSchedulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrefetchSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrefetchSchedules.</param>
        /// 
        /// <returns>Returns a  ListPrefetchSchedulesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPrefetchSchedules">REST API Reference for ListPrefetchSchedules Operation</seealso>
        public virtual ListPrefetchSchedulesResponse EndListPrefetchSchedules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrefetchSchedulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSourceLocations

        /// <summary>
        /// Lists the source locations for a channel. A source location defines the host server
        /// URL, and contains a list of sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations service method.</param>
        /// 
        /// <returns>The response from the ListSourceLocations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        public virtual ListSourceLocationsResponse ListSourceLocations(ListSourceLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceLocationsResponseUnmarshaller.Instance;

            return Invoke<ListSourceLocationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceLocations operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        public virtual IAsyncResult BeginListSourceLocations(ListSourceLocationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceLocationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceLocations.</param>
        /// 
        /// <returns>Returns a  ListSourceLocationsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListSourceLocations">REST API Reference for ListSourceLocations Operation</seealso>
        public virtual ListSourceLocationsResponse EndListSourceLocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceLocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// A list of tags that are associated with this resource. Tags are key-value pairs that
        /// you can associate with Amazon resources to help with organization, access control,
        /// and cost tracking. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVodSources

        /// <summary>
        /// Lists the VOD sources contained in a source location. A source represents a piece
        /// of content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources service method.</param>
        /// 
        /// <returns>The response from the ListVodSources service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        public virtual ListVodSourcesResponse ListVodSources(ListVodSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVodSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVodSourcesResponseUnmarshaller.Instance;

            return Invoke<ListVodSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVodSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVodSources operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVodSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        public virtual IAsyncResult BeginListVodSources(ListVodSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVodSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVodSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVodSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVodSources.</param>
        /// 
        /// <returns>Returns a  ListVodSourcesResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListVodSources">REST API Reference for ListVodSources Operation</seealso>
        public virtual ListVodSourcesResponse EndListVodSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVodSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutChannelPolicy

        /// <summary>
        /// Creates an IAM policy for the channel. IAM policies are used to control access to
        /// your channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<PutChannelPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutChannelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutChannelPolicy(PutChannelPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutChannelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutChannelPolicy.</param>
        /// 
        /// <returns>Returns a  PutChannelPolicyResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual PutChannelPolicyResponse EndPutChannelPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutChannelPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPlaybackConfiguration

        /// <summary>
        /// Creates a playback configuration. For information about MediaTailor configurations,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutPlaybackConfiguration(PutPlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual PutPlaybackConfigurationResponse EndPutPlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartChannel

        /// <summary>
        /// Starts a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual StartChannelResponse StartChannel(StartChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return Invoke<StartChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual IAsyncResult BeginStartChannel(StartChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChannel.</param>
        /// 
        /// <returns>Returns a  StartChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual StartChannelResponse EndStartChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<StartChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  StopChannel

        /// <summary>
        /// Stops a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual StopChannelResponse StopChannel(StopChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return Invoke<StopChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual IAsyncResult BeginStopChannel(StopChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopChannel.</param>
        /// 
        /// <returns>Returns a  StopChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual StopChannelResponse EndStopChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<StopChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// The resource to tag. Tags are key-value pairs that you can associate with Amazon resources
        /// to help with organization, access control, and cost tracking. For more information,
        /// see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// The resource to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Updates a channel. For information about MediaTailor channels, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-channels.html">Working
        /// with channels</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLiveSource

        /// <summary>
        /// Updates a live source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource service method.</param>
        /// 
        /// <returns>The response from the UpdateLiveSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        public virtual UpdateLiveSourceResponse UpdateLiveSource(UpdateLiveSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLiveSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateLiveSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLiveSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLiveSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateLiveSource(UpdateLiveSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLiveSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLiveSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLiveSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLiveSource.</param>
        /// 
        /// <returns>Returns a  UpdateLiveSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateLiveSource">REST API Reference for UpdateLiveSource Operation</seealso>
        public virtual UpdateLiveSourceResponse EndUpdateLiveSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLiveSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProgram

        /// <summary>
        /// Updates a program within a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram service method.</param>
        /// 
        /// <returns>The response from the UpdateProgram service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        public virtual UpdateProgramResponse UpdateProgram(UpdateProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramResponseUnmarshaller.Instance;

            return Invoke<UpdateProgramResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgram operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        public virtual IAsyncResult BeginUpdateProgram(UpdateProgramRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProgramResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProgram.</param>
        /// 
        /// <returns>Returns a  UpdateProgramResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateProgram">REST API Reference for UpdateProgram Operation</seealso>
        public virtual UpdateProgramResponse EndUpdateProgram(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProgramResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSourceLocation

        /// <summary>
        /// Updates a source location. A source location is a container for sources. For more
        /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
        /// with source locations</a> in the <i>MediaTailor User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceLocation service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        public virtual UpdateSourceLocationResponse UpdateSourceLocation(UpdateSourceLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceLocationResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceLocation operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        public virtual IAsyncResult BeginUpdateSourceLocation(UpdateSourceLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceLocation.</param>
        /// 
        /// <returns>Returns a  UpdateSourceLocationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateSourceLocation">REST API Reference for UpdateSourceLocation Operation</seealso>
        public virtual UpdateSourceLocationResponse EndUpdateSourceLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSourceLocationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVodSource

        /// <summary>
        /// Updates a VOD source's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource service method.</param>
        /// 
        /// <returns>The response from the UpdateVodSource service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        public virtual UpdateVodSourceResponse UpdateVodSource(UpdateVodSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVodSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateVodSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVodSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVodSource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVodSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateVodSource(UpdateVodSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVodSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVodSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVodSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVodSource.</param>
        /// 
        /// <returns>Returns a  UpdateVodSourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UpdateVodSource">REST API Reference for UpdateVodSource Operation</seealso>
        public virtual UpdateVodSourceResponse EndUpdateVodSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVodSourceResponse>(asyncResult);
        }

        #endregion
        
    }
}