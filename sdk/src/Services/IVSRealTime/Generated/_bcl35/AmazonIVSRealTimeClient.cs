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

namespace Amazon.IVSRealTime
{
    /// <summary>
    /// Implementation for accessing IVSRealTime
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) stage API is REST compatible, using a standard
    /// HTTP API and an AWS EventBridge event stream for responses. JSON is used for both
    /// requests and responses, including errors. 
    /// </para>
    ///  
    /// <para>
    /// Terminology:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The IVS stage API sometimes is referred to as the IVS <i>RealTime</i> API.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant token</i> is an authorization token used to publish/subscribe to
    /// a stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant object</i> represents participants (people) in the stage and contains
    /// information about them. When a token is created, it includes a participant ID; when
    /// a participant uses that token to join a stage, the participant is associated with
    /// that participant ID There is a 1:1 mapping between participant tokens and participants.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/getting-started.html">Getting
    /// Started with Amazon IVS</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Stage</b> — A stage is a virtual space where multiple participants can exchange
    /// audio and video in real time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <code>topic:nature</code> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> for more information, including restrictions that apply to tags
    /// and "Tag naming limits and requirements"; Amazon IVS stages has no service-specific
    /// constraints beyond what is documented there.
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
    /// The Amazon IVS stage API has these tag-related endpoints: <a>TagResource</a>, <a>UntagResource</a>,
    /// and <a>ListTagsForResource</a>. The following resource supports tagging: Stage.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Stages Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateParticipantToken</a> — Creates an additional token for a specified stage.
    /// This can be done after stage creation or when tokens expire.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateStage</a> — Creates a new stage (and optionally participant tokens).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStage</a> — Shuts down and deletes the specified stage (disconnecting all
    /// participants).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectParticipant</a> — Disconnects a specified participant and revokes the
    /// participant permanently from a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetParticipant</a> — Gets information about the specified participant token.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStage</a> — Gets information for the specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStageSession</a> — Gets information for the specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipantEvents</a> — Lists events for a specified participant that occurred
    /// during a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipants</a> — Lists all participants in a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStages</a> — Gets summary information about all stages in your account, in
    /// the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStageSessions</a> — Gets all sessions for a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateStage</a> — Updates a stage’s configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the AWS resource with the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> </ul>
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
        
        #region  DeleteStage

        /// <summary>
        /// Shuts down and deletes the specified stage (disconnecting all participants).
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
        
        #region  DisconnectParticipant

        /// <summary>
        /// Disconnects a specified participant and revokes the participant permanently from a
        /// specified stage.
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
        
    }
}