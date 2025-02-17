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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IVSRealTime.Model;
using Amazon.IVSRealTime.Model.Internal.MarshallTransformations;
using Amazon.IVSRealTime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IVSRealTime
{
    /// <summary>
    /// <para>Implementation for accessing IVSRealTime</para>
    ///
    /// The Amazon Interactive Video Service (IVS) real-time API is REST compatible, using
    /// a standard HTTP API and an AWS EventBridge event stream for responses. JSON is used
    /// for both requests and responses, including errors. 
    /// 
    ///  
    /// <para>
    ///  <b>Key Concepts</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Stage</b> — A virtual space where participants can exchange video in real time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Participant token</b> — A token that authenticates a participant when they join
    /// a stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Participant object</b> — Represents participants (people) in the stage and contains
    /// information about them. When a token is created, it includes a participant ID; when
    /// a participant uses that token to join a stage, the participant is associated with
    /// that participant ID. There is a 1:1 mapping between participant tokens and participants.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For server-side composition:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Composition process</b> — Composites participants of a stage into a single video
    /// and forwards it to a set of outputs (e.g., IVS channels). Composition operations support
    /// this process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Composition</b> — Controls the look of the outputs, including how participants
    /// are positioned in the video.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about your IVS live stream, also see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started.html">Getting
    /// Started with Amazon IVS Real-Time Streaming</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <c>topic:nature</c> to label a particular video category. See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
    /// practices and strategies</a> in <i>Tagging AWS Resources and Tag Editor</i> for details,
    /// including restrictions that apply to tags and "Tag naming limits and requirements";
    /// Amazon IVS stages has no service-specific constraints beyond what is documented there.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your AWS resources. For example, you can use
    /// the same tag for different resources to indicate that they are related. You can also
    /// use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Access
    /// Tags</a>).
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS real-time API has these tag-related operations: <a>TagResource</a>,
    /// <a>UntagResource</a>, and <a>ListTagsForResource</a>. The following resource supports
    /// tagging: Stage.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource.
    /// </para>
    /// </summary>
    public partial class AmazonIVSRealTimeClient : AmazonServiceClient, IAmazonIVSRealTime
    {
        private static IServiceMetadata serviceMetadata = new AmazonIVSRealTimeMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IIVSRealTimePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIVSRealTimePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IVSRealTimePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        public AmazonIVSRealTimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSRealTimeConfig()) { }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        public AmazonIVSRealTimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSRealTimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(AmazonIVSRealTimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIVSRealTimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials and an
        /// AmazonIVSRealTimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials, AmazonIVSRealTimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSRealTimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSRealTimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIVSRealTimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSRealTimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSRealTimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIVSRealTimeConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIVSRealTimeEndpointResolver());
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


        #region  CreateEncoderConfiguration

        /// <summary>
        /// Creates an EncoderConfiguration object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEncoderConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateEncoderConfiguration">REST API Reference for CreateEncoderConfiguration Operation</seealso>
        public virtual CreateEncoderConfigurationResponse CreateEncoderConfiguration(CreateEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateEncoderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEncoderConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEncoderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateEncoderConfiguration">REST API Reference for CreateEncoderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateEncoderConfiguration(CreateEncoderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEncoderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEncoderConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateEncoderConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateEncoderConfiguration">REST API Reference for CreateEncoderConfiguration Operation</seealso>
        public virtual CreateEncoderConfigurationResponse EndCreateEncoderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEncoderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIngestConfiguration

        /// <summary>
        /// Creates a new IngestConfiguration resource, used to specify the ingest protocol for
        /// a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateIngestConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateIngestConfiguration">REST API Reference for CreateIngestConfiguration Operation</seealso>
        public virtual CreateIngestConfigurationResponse CreateIngestConfiguration(CreateIngestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateIngestConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateIngestConfiguration">REST API Reference for CreateIngestConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateIngestConfiguration(CreateIngestConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngestConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateIngestConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateIngestConfiguration">REST API Reference for CreateIngestConfiguration Operation</seealso>
        public virtual CreateIngestConfigurationResponse EndCreateIngestConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIngestConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateParticipantToken

        /// <summary>
        /// Creates an additional token for a specified stage. This can be done after stage creation
        /// or when tokens expire. Tokens always are scoped to the stage for which they are created.
        /// 
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantToken service method.</param>
        /// 
        /// <returns>The response from the CreateParticipantToken service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateParticipantToken">REST API Reference for CreateParticipantToken Operation</seealso>
        public virtual CreateParticipantTokenResponse CreateParticipantToken(CreateParticipantTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantTokenResponseUnmarshaller.Instance;

            return Invoke<CreateParticipantTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParticipantToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantToken operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParticipantToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateParticipantToken">REST API Reference for CreateParticipantToken Operation</seealso>
        public virtual IAsyncResult BeginCreateParticipantToken(CreateParticipantTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParticipantToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParticipantToken.</param>
        /// 
        /// <returns>Returns a  CreateParticipantTokenResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateParticipantToken">REST API Reference for CreateParticipantToken Operation</seealso>
        public virtual CreateParticipantTokenResponse EndCreateParticipantToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateParticipantTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a new stage (and optionally participant tokens).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStorageConfiguration

        /// <summary>
        /// Creates a new storage configuration, used to enable recording to Amazon S3. When a
        /// StorageConfiguration is created, IVS will modify the S3 bucketPolicy of the provided
        /// bucket. This will ensure that IVS has sufficient permissions to write content to the
        /// provided bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStorageConfiguration">REST API Reference for CreateStorageConfiguration Operation</seealso>
        public virtual CreateStorageConfigurationResponse CreateStorageConfiguration(CreateStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStorageConfiguration">REST API Reference for CreateStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateStorageConfiguration(CreateStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateStorageConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStorageConfiguration">REST API Reference for CreateStorageConfiguration Operation</seealso>
        public virtual CreateStorageConfigurationResponse EndCreateStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEncoderConfiguration

        /// <summary>
        /// Deletes an EncoderConfiguration resource. Ensures that no Compositions are using this
        /// template; otherwise, returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEncoderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteEncoderConfiguration">REST API Reference for DeleteEncoderConfiguration Operation</seealso>
        public virtual DeleteEncoderConfigurationResponse DeleteEncoderConfiguration(DeleteEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEncoderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEncoderConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEncoderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteEncoderConfiguration">REST API Reference for DeleteEncoderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEncoderConfiguration(DeleteEncoderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEncoderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEncoderConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEncoderConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteEncoderConfiguration">REST API Reference for DeleteEncoderConfiguration Operation</seealso>
        public virtual DeleteEncoderConfigurationResponse EndDeleteEncoderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEncoderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIngestConfiguration

        /// <summary>
        /// Deletes a specified IngestConfiguration, so it can no longer be used to broadcast.
        /// An IngestConfiguration cannot be deleted if the publisher is actively streaming to
        /// a stage, unless <c>force</c> is set to <c>true</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteIngestConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteIngestConfiguration">REST API Reference for DeleteIngestConfiguration Operation</seealso>
        public virtual DeleteIngestConfigurationResponse DeleteIngestConfiguration(DeleteIngestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteIngestConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIngestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteIngestConfiguration">REST API Reference for DeleteIngestConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteIngestConfiguration(DeleteIngestConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngestConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIngestConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteIngestConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteIngestConfiguration">REST API Reference for DeleteIngestConfiguration Operation</seealso>
        public virtual DeleteIngestConfigurationResponse EndDeleteIngestConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIngestConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePublicKey

        /// <summary>
        /// Deletes the specified public key used to sign stage participant tokens. This invalidates
        /// future participant tokens generated using the key pair’s private key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey service method.</param>
        /// 
        /// <returns>The response from the DeletePublicKey service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual DeletePublicKeyResponse DeletePublicKey(DeletePublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeletePublicKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual IAsyncResult BeginDeletePublicKey(DeletePublicKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicKey.</param>
        /// 
        /// <returns>Returns a  DeletePublicKeyResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        public virtual DeletePublicKeyResponse EndDeletePublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStage

        /// <summary>
        /// Shuts down and deletes the specified stage (disconnecting all participants). This
        /// operation also removes the <c>stageArn</c> from the associated <a>IngestConfiguration</a>,
        /// if there are participants using the IngestConfiguration to publish to the stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStorageConfiguration

        /// <summary>
        /// Deletes the storage configuration for the specified ARN.
        /// 
        ///  
        /// <para>
        /// If you try to delete a storage configuration that is used by a Composition, you will
        /// get an error (409 ConflictException). To avoid this, for all Compositions that reference
        /// the storage configuration, first use <a>StopComposition</a> and wait for it to complete,
        /// then use DeleteStorageConfiguration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStorageConfiguration">REST API Reference for DeleteStorageConfiguration Operation</seealso>
        public virtual DeleteStorageConfigurationResponse DeleteStorageConfiguration(DeleteStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStorageConfiguration">REST API Reference for DeleteStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteStorageConfiguration(DeleteStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteStorageConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStorageConfiguration">REST API Reference for DeleteStorageConfiguration Operation</seealso>
        public virtual DeleteStorageConfigurationResponse EndDeleteStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectParticipant

        /// <summary>
        /// Disconnects a specified participant from a specified stage. If the participant is
        /// publishing using an <a>IngestConfiguration</a>, DisconnectParticipant also updates
        /// the <c>stageArn</c> in the IngestConfiguration to be an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual DisconnectParticipantResponse DisconnectParticipant(DisconnectParticipantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return Invoke<DisconnectParticipantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectParticipant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectParticipant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual IAsyncResult BeginDisconnectParticipant(DisconnectParticipantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectParticipant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectParticipant.</param>
        /// 
        /// <returns>Returns a  DisconnectParticipantResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual DisconnectParticipantResponse EndDisconnectParticipant(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectParticipantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComposition

        /// <summary>
        /// Get information about the specified Composition resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComposition service method.</param>
        /// 
        /// <returns>The response from the GetComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetComposition">REST API Reference for GetComposition Operation</seealso>
        public virtual GetCompositionResponse GetComposition(GetCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompositionResponseUnmarshaller.Instance;

            return Invoke<GetCompositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComposition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComposition operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComposition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetComposition">REST API Reference for GetComposition Operation</seealso>
        public virtual IAsyncResult BeginGetComposition(GetCompositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComposition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComposition.</param>
        /// 
        /// <returns>Returns a  GetCompositionResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetComposition">REST API Reference for GetComposition Operation</seealso>
        public virtual GetCompositionResponse EndGetComposition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCompositionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEncoderConfiguration

        /// <summary>
        /// Gets information about the specified EncoderConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncoderConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetEncoderConfiguration">REST API Reference for GetEncoderConfiguration Operation</seealso>
        public virtual GetEncoderConfigurationResponse GetEncoderConfiguration(GetEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEncoderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncoderConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEncoderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetEncoderConfiguration">REST API Reference for GetEncoderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetEncoderConfiguration(GetEncoderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncoderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEncoderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEncoderConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEncoderConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetEncoderConfiguration">REST API Reference for GetEncoderConfiguration Operation</seealso>
        public virtual GetEncoderConfigurationResponse EndGetEncoderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEncoderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIngestConfiguration

        /// <summary>
        /// Gets information about the specified IngestConfiguration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIngestConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetIngestConfiguration">REST API Reference for GetIngestConfiguration Operation</seealso>
        public virtual GetIngestConfigurationResponse GetIngestConfiguration(GetIngestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIngestConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIngestConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIngestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetIngestConfiguration">REST API Reference for GetIngestConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetIngestConfiguration(GetIngestConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngestConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIngestConfiguration.</param>
        /// 
        /// <returns>Returns a  GetIngestConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetIngestConfiguration">REST API Reference for GetIngestConfiguration Operation</seealso>
        public virtual GetIngestConfigurationResponse EndGetIngestConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIngestConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParticipant

        /// <summary>
        /// Gets information about the specified participant token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParticipant service method.</param>
        /// 
        /// <returns>The response from the GetParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetParticipant">REST API Reference for GetParticipant Operation</seealso>
        public virtual GetParticipantResponse GetParticipant(GetParticipantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParticipantResponseUnmarshaller.Instance;

            return Invoke<GetParticipantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetParticipant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParticipant operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParticipant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetParticipant">REST API Reference for GetParticipant Operation</seealso>
        public virtual IAsyncResult BeginGetParticipant(GetParticipantRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParticipantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParticipant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParticipant.</param>
        /// 
        /// <returns>Returns a  GetParticipantResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetParticipant">REST API Reference for GetParticipant Operation</seealso>
        public virtual GetParticipantResponse EndGetParticipant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParticipantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPublicKey

        /// <summary>
        /// Gets information for the specified public key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual IAsyncResult BeginGetPublicKey(GetPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicKey.</param>
        /// 
        /// <returns>Returns a  GetPublicKeyResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual GetPublicKeyResponse EndGetPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStage

        /// <summary>
        /// Gets information for the specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse EndGetStage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStageSession

        /// <summary>
        /// Gets information for the specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageSession service method.</param>
        /// 
        /// <returns>The response from the GetStageSession service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStageSession">REST API Reference for GetStageSession Operation</seealso>
        public virtual GetStageSessionResponse GetStageSession(GetStageSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageSessionResponseUnmarshaller.Instance;

            return Invoke<GetStageSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStageSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStageSession operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStageSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStageSession">REST API Reference for GetStageSession Operation</seealso>
        public virtual IAsyncResult BeginGetStageSession(GetStageSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStageSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStageSession.</param>
        /// 
        /// <returns>Returns a  GetStageSessionResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStageSession">REST API Reference for GetStageSession Operation</seealso>
        public virtual GetStageSessionResponse EndGetStageSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStorageConfiguration

        /// <summary>
        /// Gets the storage configuration for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStorageConfiguration">REST API Reference for GetStorageConfiguration Operation</seealso>
        public virtual GetStorageConfigurationResponse GetStorageConfiguration(GetStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetStorageConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStorageConfiguration">REST API Reference for GetStorageConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetStorageConfiguration(GetStorageConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageConfiguration.</param>
        /// 
        /// <returns>Returns a  GetStorageConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStorageConfiguration">REST API Reference for GetStorageConfiguration Operation</seealso>
        public virtual GetStorageConfigurationResponse EndGetStorageConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStorageConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportPublicKey

        /// <summary>
        /// Import a public key to be used for signing stage participant tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPublicKey service method.</param>
        /// 
        /// <returns>The response from the ImportPublicKey service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ImportPublicKey">REST API Reference for ImportPublicKey Operation</seealso>
        public virtual ImportPublicKeyResponse ImportPublicKey(ImportPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPublicKeyResponseUnmarshaller.Instance;

            return Invoke<ImportPublicKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportPublicKey operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ImportPublicKey">REST API Reference for ImportPublicKey Operation</seealso>
        public virtual IAsyncResult BeginImportPublicKey(ImportPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportPublicKey.</param>
        /// 
        /// <returns>Returns a  ImportPublicKeyResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ImportPublicKey">REST API Reference for ImportPublicKey Operation</seealso>
        public virtual ImportPublicKeyResponse EndImportPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCompositions

        /// <summary>
        /// Gets summary information about all Compositions in your account, in the AWS region
        /// where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompositions service method.</param>
        /// 
        /// <returns>The response from the ListCompositions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListCompositions">REST API Reference for ListCompositions Operation</seealso>
        public virtual ListCompositionsResponse ListCompositions(ListCompositionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionsResponseUnmarshaller.Instance;

            return Invoke<ListCompositionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCompositions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompositions operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCompositions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListCompositions">REST API Reference for ListCompositions Operation</seealso>
        public virtual IAsyncResult BeginListCompositions(ListCompositionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCompositions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCompositions.</param>
        /// 
        /// <returns>Returns a  ListCompositionsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListCompositions">REST API Reference for ListCompositions Operation</seealso>
        public virtual ListCompositionsResponse EndListCompositions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCompositionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEncoderConfigurations

        /// <summary>
        /// Gets summary information about all EncoderConfigurations in your account, in the AWS
        /// region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEncoderConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEncoderConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListEncoderConfigurations">REST API Reference for ListEncoderConfigurations Operation</seealso>
        public virtual ListEncoderConfigurationsResponse ListEncoderConfigurations(ListEncoderConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEncoderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEncoderConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEncoderConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEncoderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEncoderConfigurations operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEncoderConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListEncoderConfigurations">REST API Reference for ListEncoderConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListEncoderConfigurations(ListEncoderConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEncoderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEncoderConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEncoderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEncoderConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEncoderConfigurationsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListEncoderConfigurations">REST API Reference for ListEncoderConfigurations Operation</seealso>
        public virtual ListEncoderConfigurationsResponse EndListEncoderConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEncoderConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIngestConfigurations

        /// <summary>
        /// Lists all IngestConfigurations in your account, in the AWS region where the API request
        /// is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListIngestConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListIngestConfigurations">REST API Reference for ListIngestConfigurations Operation</seealso>
        public virtual ListIngestConfigurationsResponse ListIngestConfigurations(ListIngestConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListIngestConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngestConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngestConfigurations operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngestConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListIngestConfigurations">REST API Reference for ListIngestConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListIngestConfigurations(ListIngestConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngestConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngestConfigurations.</param>
        /// 
        /// <returns>Returns a  ListIngestConfigurationsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListIngestConfigurations">REST API Reference for ListIngestConfigurations Operation</seealso>
        public virtual ListIngestConfigurationsResponse EndListIngestConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIngestConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListParticipantEvents

        /// <summary>
        /// Lists events for a specified participant that occurred during a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipantEvents service method.</param>
        /// 
        /// <returns>The response from the ListParticipantEvents service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipantEvents">REST API Reference for ListParticipantEvents Operation</seealso>
        public virtual ListParticipantEventsResponse ListParticipantEvents(ListParticipantEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantEventsResponseUnmarshaller.Instance;

            return Invoke<ListParticipantEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParticipantEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParticipantEvents operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParticipantEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipantEvents">REST API Reference for ListParticipantEvents Operation</seealso>
        public virtual IAsyncResult BeginListParticipantEvents(ListParticipantEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParticipantEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParticipantEvents.</param>
        /// 
        /// <returns>Returns a  ListParticipantEventsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipantEvents">REST API Reference for ListParticipantEvents Operation</seealso>
        public virtual ListParticipantEventsResponse EndListParticipantEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListParticipantEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListParticipants

        /// <summary>
        /// Lists all participants in a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipants service method.</param>
        /// 
        /// <returns>The response from the ListParticipants service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipants">REST API Reference for ListParticipants Operation</seealso>
        public virtual ListParticipantsResponse ListParticipants(ListParticipantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantsResponseUnmarshaller.Instance;

            return Invoke<ListParticipantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParticipants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParticipants operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParticipants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipants">REST API Reference for ListParticipants Operation</seealso>
        public virtual IAsyncResult BeginListParticipants(ListParticipantsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParticipants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParticipants.</param>
        /// 
        /// <returns>Returns a  ListParticipantsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipants">REST API Reference for ListParticipants Operation</seealso>
        public virtual ListParticipantsResponse EndListParticipants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListParticipantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPublicKeys

        /// <summary>
        /// Gets summary information about all public keys in your account, in the AWS region
        /// where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListPublicKeys service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual ListPublicKeysResponse ListPublicKeys(ListPublicKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListPublicKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPublicKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual IAsyncResult BeginListPublicKeys(ListPublicKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPublicKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPublicKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListPublicKeysResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        public virtual ListPublicKeysResponse EndListPublicKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPublicKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStages

        /// <summary>
        /// Gets summary information about all stages in your account, in the AWS region where
        /// the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
        /// 
        /// <returns>The response from the ListStages service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual ListStagesResponse ListStages(ListStagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return Invoke<ListStagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStages operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual IAsyncResult BeginListStages(ListStagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStages.</param>
        /// 
        /// <returns>Returns a  ListStagesResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual ListStagesResponse EndListStages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStageSessions

        /// <summary>
        /// Gets all sessions for a specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageSessions service method.</param>
        /// 
        /// <returns>The response from the ListStageSessions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStageSessions">REST API Reference for ListStageSessions Operation</seealso>
        public virtual ListStageSessionsResponse ListStageSessions(ListStageSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageSessionsResponseUnmarshaller.Instance;

            return Invoke<ListStageSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStageSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStageSessions operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStageSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStageSessions">REST API Reference for ListStageSessions Operation</seealso>
        public virtual IAsyncResult BeginListStageSessions(ListStageSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStageSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStageSessions.</param>
        /// 
        /// <returns>Returns a  ListStageSessionsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStageSessions">REST API Reference for ListStageSessions Operation</seealso>
        public virtual ListStageSessionsResponse EndListStageSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStageSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStorageConfigurations

        /// <summary>
        /// Gets summary information about all storage configurations in your account, in the
        /// AWS region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListStorageConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStorageConfigurations">REST API Reference for ListStorageConfigurations Operation</seealso>
        public virtual ListStorageConfigurationsResponse ListStorageConfigurations(ListStorageConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListStorageConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStorageConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageConfigurations operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStorageConfigurations">REST API Reference for ListStorageConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListStorageConfigurations(ListStorageConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageConfigurations.</param>
        /// 
        /// <returns>Returns a  ListStorageConfigurationsResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStorageConfigurations">REST API Reference for ListStorageConfigurations Operation</seealso>
        public virtual ListStorageConfigurationsResponse EndListStorageConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStorageConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartComposition

        /// <summary>
        /// Starts a Composition from a stage based on the configuration provided in the request.
        /// 
        ///  
        /// <para>
        /// A Composition is an ephemeral resource that exists after this operation returns successfully.
        /// Composition stops and the resource is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <a>StopComposition</a> is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, when all participants are disconnected from the stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, if there are no participants in the stage when StartComposition
        /// is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting to the IVS channel fails and all retries are exhausted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting is disconnected and all attempts to reconnect are exhausted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartComposition service method.</param>
        /// 
        /// <returns>The response from the StartComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StartComposition">REST API Reference for StartComposition Operation</seealso>
        public virtual StartCompositionResponse StartComposition(StartCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCompositionResponseUnmarshaller.Instance;

            return Invoke<StartCompositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartComposition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartComposition operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartComposition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StartComposition">REST API Reference for StartComposition Operation</seealso>
        public virtual IAsyncResult BeginStartComposition(StartCompositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCompositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartComposition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartComposition.</param>
        /// 
        /// <returns>Returns a  StartCompositionResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StartComposition">REST API Reference for StartComposition Operation</seealso>
        public virtual StartCompositionResponse EndStartComposition(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCompositionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopComposition

        /// <summary>
        /// Stops and deletes a Composition resource. Any broadcast from the Composition resource
        /// is stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopComposition service method.</param>
        /// 
        /// <returns>The response from the StopComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StopComposition">REST API Reference for StopComposition Operation</seealso>
        public virtual StopCompositionResponse StopComposition(StopCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompositionResponseUnmarshaller.Instance;

            return Invoke<StopCompositionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopComposition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopComposition operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopComposition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StopComposition">REST API Reference for StopComposition Operation</seealso>
        public virtual IAsyncResult BeginStopComposition(StopCompositionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompositionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopComposition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopComposition.</param>
        /// 
        /// <returns>Returns a  StopCompositionResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StopComposition">REST API Reference for StopComposition Operation</seealso>
        public virtual StopCompositionResponse EndStopComposition(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCompositionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIngestConfiguration

        /// <summary>
        /// Updates a specified IngestConfiguration. Only the stage ARN attached to the IngestConfiguration
        /// can be updated. An IngestConfiguration that is active cannot be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngestConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIngestConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateIngestConfiguration">REST API Reference for UpdateIngestConfiguration Operation</seealso>
        public virtual UpdateIngestConfigurationResponse UpdateIngestConfiguration(UpdateIngestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngestConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIngestConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngestConfiguration operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIngestConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateIngestConfiguration">REST API Reference for UpdateIngestConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateIngestConfiguration(UpdateIngestConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIngestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngestConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIngestConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIngestConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateIngestConfigurationResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateIngestConfiguration">REST API Reference for UpdateIngestConfiguration Operation</seealso>
        public virtual UpdateIngestConfigurationResponse EndUpdateIngestConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIngestConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStage

        /// <summary>
        /// Updates a stage’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonIVSRealTimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from IVSRealTime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
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
            var resolver = new AmazonIVSRealTimeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}