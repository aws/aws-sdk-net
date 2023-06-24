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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations;
using Amazon.PinpointSMSVoiceV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PinpointSMSVoiceV2
{
    /// <summary>
    /// Implementation for accessing PinpointSMSVoiceV2
    ///
    /// Welcome to the <i>Amazon Pinpoint SMS and Voice, version 2 API Reference</i>. This
    /// guide provides information about Amazon Pinpoint SMS and Voice, version 2 API resources,
    /// including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// Amazon Pinpoint is an Amazon Web Services service that you can use to engage with
    /// your recipients across multiple messaging channels. The Amazon Pinpoint SMS and Voice,
    /// version 2 API provides programmatic access to options that are unique to the SMS and
    /// voice channels and supplements the resources provided by the Amazon Pinpoint API.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon Pinpoint, it's also helpful to review the <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/welcome.html">
    /// Amazon Pinpoint Developer Guide</a>. The <i>Amazon Pinpoint Developer Guide</i> provides
    /// tutorials, code samples, and procedures that demonstrate how to use Amazon Pinpoint
    /// features programmatically and how to integrate Amazon Pinpoint functionality into
    /// mobile apps and other types of applications. The guide also provides key information,
    /// such as Amazon Pinpoint integration with other Amazon Web Services services, and the
    /// quotas that apply to use of the service.
    /// </para>
    /// </summary>
    public partial class AmazonPinpointSMSVoiceV2Client : AmazonServiceClient, IAmazonPinpointSMSVoiceV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointSMSVoiceV2Metadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPinpointSMSVoiceV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPinpointSMSVoiceV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PinpointSMSVoiceV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointSMSVoiceV2Config()) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(AmazonPinpointSMSVoiceV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials, AmazonPinpointSMSVoiceV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointSMSVoiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointSMSVoiceV2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPinpointSMSVoiceV2EndpointResolver());
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


        #region  AssociateOriginationIdentity

        /// <summary>
        /// Associates the specified origination identity with a pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity configuration doesn't match the pool's configuration,
        /// an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOriginationIdentity service method.</param>
        /// 
        /// <returns>The response from the AssociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        public virtual AssociateOriginationIdentityResponse AssociateOriginationIdentity(AssociateOriginationIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOriginationIdentityResponseUnmarshaller.Instance;

            return Invoke<AssociateOriginationIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateOriginationIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateOriginationIdentity operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateOriginationIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        public virtual IAsyncResult BeginAssociateOriginationIdentity(AssociateOriginationIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOriginationIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateOriginationIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateOriginationIdentity.</param>
        /// 
        /// <returns>Returns a  AssociateOriginationIdentityResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        public virtual AssociateOriginationIdentityResponse EndAssociateOriginationIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateOriginationIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConfigurationSet

        /// <summary>
        /// Creates a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to the SMS and voice messages
        /// that you send.
        /// </para>
        ///  
        /// <para>
        /// When you send a message, you can optionally specify a single configuration set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual IAsyncResult BeginCreateConfigurationSet(CreateConfigurationSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationSet.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationSetResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual CreateConfigurationSetResponse EndCreateConfigurationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConfigurationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventDestination

        /// <summary>
        /// Creates a new event destination in a configuration set.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send message events. The event options
        /// are Amazon CloudWatch, Amazon Kinesis Data Firehose, or Amazon SNS. For example, when
        /// a message is delivered successfully, you can send information about that event to
        /// an event destination, or send notifications to endpoints that are subscribed to an
        /// Amazon SNS topic.
        /// </para>
        ///  
        /// <para>
        /// Each configuration set can contain between 0 and 5 event destinations. Each event
        /// destination can contain a reference to a single destination, such as a CloudWatch
        /// or Kinesis Data Firehose destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDestination service method.</param>
        /// 
        /// <returns>The response from the CreateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        public virtual CreateEventDestinationResponse CreateEventDestination(CreateEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateEventDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDestination operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateEventDestination(CreateEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventDestination.</param>
        /// 
        /// <returns>Returns a  CreateEventDestinationResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        public virtual CreateEventDestinationResponse EndCreateEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOptOutList

        /// <summary>
        /// Creates a new opt-out list.
        /// 
        ///  
        /// <para>
        /// If the opt-out list name already exists, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// An opt-out list is a list of phone numbers that are opted out, meaning you can't send
        /// SMS or voice messages to them. If end user replies with the keyword "STOP," an entry
        /// for the phone number is added to the opt-out list. In addition to STOP, your recipients
        /// can use any supported opt-out keyword, such as CANCEL or OPTOUT. For a list of supported
        /// opt-out keywords, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-manage.html#channels-sms-manage-optout">
        /// SMS opt out </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptOutList service method.</param>
        /// 
        /// <returns>The response from the CreateOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        public virtual CreateOptOutListResponse CreateOptOutList(CreateOptOutListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptOutListResponseUnmarshaller.Instance;

            return Invoke<CreateOptOutListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptOutList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptOutList operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOptOutList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        public virtual IAsyncResult BeginCreateOptOutList(CreateOptOutListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptOutListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOptOutList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOptOutList.</param>
        /// 
        /// <returns>Returns a  CreateOptOutListResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        public virtual CreateOptOutListResponse EndCreateOptOutList(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOptOutListResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePool

        /// <summary>
        /// Creates a new pool and associates the specified origination identity to the pool.
        /// A pool can include one or more phone numbers and SenderIds that are associated with
        /// your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The new pool inherits its configuration from the specified origination identity. This
        /// includes keywords, message type, opt-out list, two-way configuration, and self-managed
        /// opt-out configuration. Deletion protection isn't inherited from the origination identity
        /// and defaults to false.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an Error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePool service method.</param>
        /// 
        /// <returns>The response from the CreatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        public virtual CreatePoolResponse CreatePool(CreatePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePoolResponseUnmarshaller.Instance;

            return Invoke<CreatePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePool operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        public virtual IAsyncResult BeginCreatePool(CreatePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePool.</param>
        /// 
        /// <returns>Returns a  CreatePoolResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        public virtual CreatePoolResponse EndCreatePool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationSet

        /// <summary>
        /// Deletes an existing configuration set.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to voice and SMS messages that
        /// you send. In a configuration set, you can specify a destination for specific types
        /// of events related to voice and SMS messages. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationSet(DeleteConfigurationSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationSet.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationSetResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual DeleteConfigurationSetResponse EndDeleteConfigurationSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDefaultMessageType

        /// <summary>
        /// Deletes an existing default message type on a configuration set.
        /// 
        ///  
        /// <para>
        ///  A message type is a type of messages that you plan to send. If you send account-related
        /// messages or time-sensitive messages such as one-time passcodes, choose <b>Transactional</b>.
        /// If you plan to send messages that contain marketing material or other promotional
        /// content, choose <b>Promotional</b>. This setting applies to your entire Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultMessageType service method.</param>
        /// 
        /// <returns>The response from the DeleteDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        public virtual DeleteDefaultMessageTypeResponse DeleteDefaultMessageType(DeleteDefaultMessageTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultMessageTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteDefaultMessageTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDefaultMessageType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultMessageType operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDefaultMessageType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        public virtual IAsyncResult BeginDeleteDefaultMessageType(DeleteDefaultMessageTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultMessageTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDefaultMessageType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDefaultMessageType.</param>
        /// 
        /// <returns>Returns a  DeleteDefaultMessageTypeResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        public virtual DeleteDefaultMessageTypeResponse EndDeleteDefaultMessageType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDefaultMessageTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDefaultSenderId

        /// <summary>
        /// Deletes an existing default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// A default sender ID is the identity that appears on recipients' devices when they
        /// receive SMS messages. Support for sender ID capabilities varies by country or region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultSenderId service method.</param>
        /// 
        /// <returns>The response from the DeleteDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        public virtual DeleteDefaultSenderIdResponse DeleteDefaultSenderId(DeleteDefaultSenderIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultSenderIdResponseUnmarshaller.Instance;

            return Invoke<DeleteDefaultSenderIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDefaultSenderId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultSenderId operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDefaultSenderId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        public virtual IAsyncResult BeginDeleteDefaultSenderId(DeleteDefaultSenderIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultSenderIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDefaultSenderId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDefaultSenderId.</param>
        /// 
        /// <returns>Returns a  DeleteDefaultSenderIdResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        public virtual DeleteDefaultSenderIdResponse EndDeleteDefaultSenderId(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDefaultSenderIdResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventDestination

        /// <summary>
        /// Deletes an existing event destination.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send response information about the messages
        /// that you send. For example, when a message is delivered successfully, you can send
        /// information about that event to an Amazon CloudWatch destination, or send notifications
        /// to endpoints that are subscribed to an Amazon SNS topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        public virtual DeleteEventDestinationResponse DeleteEventDestination(DeleteEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDestination operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventDestination(DeleteEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventDestination.</param>
        /// 
        /// <returns>Returns a  DeleteEventDestinationResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        public virtual DeleteEventDestinationResponse EndDeleteEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKeyword

        /// <summary>
        /// Deletes an existing keyword from an origination phone number or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// Keywords "HELP" and "STOP" can't be deleted or modified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyword service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        public virtual DeleteKeywordResponse DeleteKeyword(DeleteKeywordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeywordResponseUnmarshaller.Instance;

            return Invoke<DeleteKeywordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyword operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        public virtual IAsyncResult BeginDeleteKeyword(DeleteKeywordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeywordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyword.</param>
        /// 
        /// <returns>Returns a  DeleteKeywordResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        public virtual DeleteKeywordResponse EndDeleteKeyword(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKeywordResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOptedOutNumber

        /// <summary>
        /// Deletes an existing opted out destination phone number from the specified opt-out
        /// list.
        /// 
        ///  
        /// <para>
        /// Each destination phone number can only be deleted once every 30 days.
        /// </para>
        ///  
        /// <para>
        /// If the specified destination phone number doesn't exist or if the opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptedOutNumber service method.</param>
        /// 
        /// <returns>The response from the DeleteOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        public virtual DeleteOptedOutNumberResponse DeleteOptedOutNumber(DeleteOptedOutNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptedOutNumberResponseUnmarshaller.Instance;

            return Invoke<DeleteOptedOutNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptedOutNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptedOutNumber operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOptedOutNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        public virtual IAsyncResult BeginDeleteOptedOutNumber(DeleteOptedOutNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptedOutNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOptedOutNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOptedOutNumber.</param>
        /// 
        /// <returns>Returns a  DeleteOptedOutNumberResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        public virtual DeleteOptedOutNumberResponse EndDeleteOptedOutNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOptedOutNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOptOutList

        /// <summary>
        /// Deletes an existing opt-out list. All opted out phone numbers in the opt-out list
        /// are deleted.
        /// 
        ///  
        /// <para>
        /// If the specified opt-out list name doesn't exist or is in-use by an origination phone
        /// number or pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptOutList service method.</param>
        /// 
        /// <returns>The response from the DeleteOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        public virtual DeleteOptOutListResponse DeleteOptOutList(DeleteOptOutListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptOutListResponseUnmarshaller.Instance;

            return Invoke<DeleteOptOutListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptOutList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptOutList operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOptOutList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        public virtual IAsyncResult BeginDeleteOptOutList(DeleteOptOutListRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptOutListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOptOutList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOptOutList.</param>
        /// 
        /// <returns>Returns a  DeleteOptOutListResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        public virtual DeleteOptOutListResponse EndDeleteOptOutList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOptOutListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePool

        /// <summary>
        /// Deletes an existing pool. Deleting a pool disassociates all origination identities
        /// from that pool.
        /// 
        ///  
        /// <para>
        /// If the pool status isn't active or if deletion protection is enabled, an Error is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePool service method.</param>
        /// 
        /// <returns>The response from the DeletePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        public virtual DeletePoolResponse DeletePool(DeletePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePoolResponseUnmarshaller.Instance;

            return Invoke<DeletePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePool operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        public virtual IAsyncResult BeginDeletePool(DeletePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePool.</param>
        /// 
        /// <returns>Returns a  DeletePoolResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        public virtual DeletePoolResponse EndDeletePool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTextMessageSpendLimitOverride

        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending text messages.
        /// Deleting a spend limit override will set the <code>EnforcedLimit</code> to equal the
        /// <code>MaxLimit</code>, which is controlled by Amazon Web Services. For more information
        /// on spend limits (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTextMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        public virtual DeleteTextMessageSpendLimitOverrideResponse DeleteTextMessageSpendLimitOverride(DeleteTextMessageSpendLimitOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteTextMessageSpendLimitOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTextMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTextMessageSpendLimitOverride operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTextMessageSpendLimitOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        public virtual IAsyncResult BeginDeleteTextMessageSpendLimitOverride(DeleteTextMessageSpendLimitOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTextMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTextMessageSpendLimitOverride.</param>
        /// 
        /// <returns>Returns a  DeleteTextMessageSpendLimitOverrideResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        public virtual DeleteTextMessageSpendLimitOverrideResponse EndDeleteTextMessageSpendLimitOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTextMessageSpendLimitOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceMessageSpendLimitOverride

        /// <summary>
        /// Deletes an account level monthly spend limit override for sending voice messages.
        /// Deleting a spend limit override sets the <code>EnforcedLimit</code> equal to the <code>MaxLimit</code>,
        /// which is controlled by Amazon Web Services. For more information on spending limits
        /// (quotas) see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">Amazon
        /// Pinpoint quotas</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual DeleteVoiceMessageSpendLimitOverrideResponse DeleteVoiceMessageSpendLimitOverride(DeleteVoiceMessageSpendLimitOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceMessageSpendLimitOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceMessageSpendLimitOverride operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceMessageSpendLimitOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceMessageSpendLimitOverride(DeleteVoiceMessageSpendLimitOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceMessageSpendLimitOverride.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceMessageSpendLimitOverrideResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual DeleteVoiceMessageSpendLimitOverrideResponse EndDeleteVoiceMessageSpendLimitOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceMessageSpendLimitOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Describes attributes of your Amazon Web Services account. The supported account attributes
        /// include account tier, which indicates whether your account is in the sandbox or production
        /// environment. When you're ready to move your account out of the sandbox, create an
        /// Amazon Web Services Support case for a service limit increase request.
        /// 
        ///  
        /// <para>
        /// New Amazon Pinpoint accounts are placed into an SMS or voice sandbox. The sandbox
        /// protects both Amazon Web Services end recipients and SMS or voice recipients from
        /// fraud and abuse. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountLimits

        /// <summary>
        /// Describes the current Amazon Pinpoint SMS Voice V2 resource quotas for your account.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of configuration sets, opt-out lists, phone numbers, and pools
        /// that you can create in a given Region. For more information see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/quotas.html">
        /// Amazon Pinpoint quotas </a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationSets

        /// <summary>
        /// Describes the specified configuration sets or all in your account.
        /// 
        ///  
        /// <para>
        /// If you specify configuration set names, the output includes information for only the
        /// specified configuration sets. If you specify filters, the output includes information
        /// for only those configuration sets that meet the filter criteria. If you don't specify
        /// configuration set names or filters, the output includes information for all configuration
        /// sets.
        /// </para>
        ///  
        /// <para>
        /// If you specify a configuration set name that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSets service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationSets service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        public virtual DescribeConfigurationSetsResponse DescribeConfigurationSets(DescribeConfigurationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSets operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationSets(DescribeConfigurationSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationSets.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationSetsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        public virtual DescribeConfigurationSetsResponse EndDescribeConfigurationSets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeKeywords

        /// <summary>
        /// Describes the specified keywords or all keywords on your origination phone number
        /// or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeywords service method.</param>
        /// 
        /// <returns>The response from the DescribeKeywords service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        public virtual DescribeKeywordsResponse DescribeKeywords(DescribeKeywordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeywordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeywordsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeywordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeywords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeywords operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeywords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        public virtual IAsyncResult BeginDescribeKeywords(DescribeKeywordsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeywordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeywordsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeywords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeywords.</param>
        /// 
        /// <returns>Returns a  DescribeKeywordsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        public virtual DescribeKeywordsResponse EndDescribeKeywords(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeKeywordsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOptedOutNumbers

        /// <summary>
        /// Describes the specified opted out destination numbers or all opted out destination
        /// numbers in an opt-out list.
        /// 
        ///  
        /// <para>
        /// If you specify opted out numbers, the output includes information for only the specified
        /// opted out numbers. If you specify filters, the output includes information for only
        /// those opted out numbers that meet the filter criteria. If you don't specify opted
        /// out numbers or filters, the output includes information for all opted out destination
        /// numbers in your opt-out list.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opted out number that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptedOutNumbers service method.</param>
        /// 
        /// <returns>The response from the DescribeOptedOutNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        public virtual DescribeOptedOutNumbersResponse DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptedOutNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptedOutNumbersResponseUnmarshaller.Instance;

            return Invoke<DescribeOptedOutNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptedOutNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptedOutNumbers operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOptedOutNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        public virtual IAsyncResult BeginDescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptedOutNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptedOutNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOptedOutNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptedOutNumbers.</param>
        /// 
        /// <returns>Returns a  DescribeOptedOutNumbersResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        public virtual DescribeOptedOutNumbersResponse EndDescribeOptedOutNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOptedOutNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOptOutLists

        /// <summary>
        /// Describes the specified opt-out list or all opt-out lists in your account.
        /// 
        ///  
        /// <para>
        /// If you specify opt-out list names, the output includes information for only the specified
        /// opt-out lists. Opt-out lists include only those that meet the filter criteria. If
        /// you don't specify opt-out list names or filters, the output includes information for
        /// all opt-out lists.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opt-out list name that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptOutLists service method.</param>
        /// 
        /// <returns>The response from the DescribeOptOutLists service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        public virtual DescribeOptOutListsResponse DescribeOptOutLists(DescribeOptOutListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptOutListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptOutListsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptOutListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptOutLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptOutLists operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOptOutLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        public virtual IAsyncResult BeginDescribeOptOutLists(DescribeOptOutListsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptOutListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptOutListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOptOutLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptOutLists.</param>
        /// 
        /// <returns>Returns a  DescribeOptOutListsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        public virtual DescribeOptOutListsResponse EndDescribeOptOutLists(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOptOutListsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePhoneNumbers

        /// <summary>
        /// Describes the specified origination phone number, or all the phone numbers in your
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify phone number IDs, the output includes information for only the specified
        /// phone numbers. If you specify filters, the output includes information for only those
        /// phone numbers that meet the filter criteria. If you don't specify phone number IDs
        /// or filters, the output includes information for all phone numbers.
        /// </para>
        ///  
        /// <para>
        /// If you specify a phone number ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the DescribePhoneNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        public virtual DescribePhoneNumbersResponse DescribePhoneNumbers(DescribePhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<DescribePhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumbers operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginDescribePhoneNumbers(DescribePhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  DescribePhoneNumbersResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        public virtual DescribePhoneNumbersResponse EndDescribePhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePools

        /// <summary>
        /// Retrieves the specified pools or all pools associated with your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify pool IDs, the output includes information for only the specified pools.
        /// If you specify filters, the output includes information for only those pools that
        /// meet the filter criteria. If you don't specify pool IDs or filters, the output includes
        /// information for all pools.
        /// </para>
        ///  
        /// <para>
        /// If you specify a pool ID that isn't valid, an Error is returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePools service method.</param>
        /// 
        /// <returns>The response from the DescribePools service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        public virtual DescribePoolsResponse DescribePools(DescribePoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoolsResponseUnmarshaller.Instance;

            return Invoke<DescribePoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePools operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        public virtual IAsyncResult BeginDescribePools(DescribePoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePools.</param>
        /// 
        /// <returns>Returns a  DescribePoolsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        public virtual DescribePoolsResponse EndDescribePools(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSenderIds

        /// <summary>
        /// Describes the specified SenderIds or all SenderIds associated with your Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// If you specify SenderIds, the output includes information for only the specified SenderIds.
        /// If you specify filters, the output includes information for only those SenderIds that
        /// meet the filter criteria. If you don't specify SenderIds or filters, the output includes
        /// information for all SenderIds.
        /// </para>
        ///  
        /// <para>
        /// f you specify a sender ID that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSenderIds service method.</param>
        /// 
        /// <returns>The response from the DescribeSenderIds service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        public virtual DescribeSenderIdsResponse DescribeSenderIds(DescribeSenderIdsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSenderIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSenderIdsResponseUnmarshaller.Instance;

            return Invoke<DescribeSenderIdsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSenderIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSenderIds operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSenderIds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        public virtual IAsyncResult BeginDescribeSenderIds(DescribeSenderIdsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSenderIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSenderIdsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSenderIds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSenderIds.</param>
        /// 
        /// <returns>Returns a  DescribeSenderIdsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        public virtual DescribeSenderIdsResponse EndDescribeSenderIds(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSenderIdsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpendLimits

        /// <summary>
        /// Describes the current Amazon Pinpoint monthly spend limits for sending voice and text
        /// messages.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial monthly
        /// spend limit in a given Region. For more information on increasing your monthly spend
        /// limit, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-awssupport-spend-threshold.html">
        /// Requesting increases to your monthly SMS spending quota for Amazon Pinpoint </a> in
        /// the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpendLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeSpendLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        public virtual DescribeSpendLimitsResponse DescribeSpendLimits(DescribeSpendLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpendLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpendLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpendLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpendLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpendLimits operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpendLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeSpendLimits(DescribeSpendLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpendLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpendLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpendLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpendLimits.</param>
        /// 
        /// <returns>Returns a  DescribeSpendLimitsResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        public virtual DescribeSpendLimitsResponse EndDescribeSpendLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpendLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateOriginationIdentity

        /// <summary>
        /// Removes the specified origination identity from an existing pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity isn't associated with the specified pool, an Error is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOriginationIdentity service method.</param>
        /// 
        /// <returns>The response from the DisassociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        public virtual DisassociateOriginationIdentityResponse DisassociateOriginationIdentity(DisassociateOriginationIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOriginationIdentityResponseUnmarshaller.Instance;

            return Invoke<DisassociateOriginationIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateOriginationIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOriginationIdentity operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateOriginationIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        public virtual IAsyncResult BeginDisassociateOriginationIdentity(DisassociateOriginationIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOriginationIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateOriginationIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateOriginationIdentity.</param>
        /// 
        /// <returns>Returns a  DisassociateOriginationIdentityResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        public virtual DisassociateOriginationIdentityResponse EndDisassociateOriginationIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateOriginationIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPoolOriginationIdentities

        /// <summary>
        /// Lists all associated origination identities in your pool.
        /// 
        ///  
        /// <para>
        /// If you specify filters, the output includes information for only those origination
        /// identities that meet the filter criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoolOriginationIdentities service method.</param>
        /// 
        /// <returns>The response from the ListPoolOriginationIdentities service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        public virtual ListPoolOriginationIdentitiesResponse ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoolOriginationIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoolOriginationIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListPoolOriginationIdentitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPoolOriginationIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoolOriginationIdentities operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPoolOriginationIdentities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        public virtual IAsyncResult BeginListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoolOriginationIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoolOriginationIdentitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPoolOriginationIdentities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPoolOriginationIdentities.</param>
        /// 
        /// <returns>Returns a  ListPoolOriginationIdentitiesResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        public virtual ListPoolOriginationIdentitiesResponse EndListPoolOriginationIdentities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoolOriginationIdentitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutKeyword

        /// <summary>
        /// Creates or updates a keyword configuration on an origination phone number or pool.
        /// 
        ///  
        /// <para>
        ///  A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, Amazon Pinpoint responds with a customizable
        /// message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyword service method.</param>
        /// 
        /// <returns>The response from the PutKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        public virtual PutKeywordResponse PutKeyword(PutKeywordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeywordResponseUnmarshaller.Instance;

            return Invoke<PutKeywordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyword operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKeyword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        public virtual IAsyncResult BeginPutKeyword(PutKeywordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeywordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutKeyword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKeyword.</param>
        /// 
        /// <returns>Returns a  PutKeywordResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        public virtual PutKeywordResponse EndPutKeyword(IAsyncResult asyncResult)
        {
            return EndInvoke<PutKeywordResponse>(asyncResult);
        }

        #endregion
        
        #region  PutOptedOutNumber

        /// <summary>
        /// Creates an opted out destination phone number in the opt-out list.
        /// 
        ///  
        /// <para>
        /// If the destination phone number isn't valid or if the specified opt-out list doesn't
        /// exist, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOptedOutNumber service method.</param>
        /// 
        /// <returns>The response from the PutOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        public virtual PutOptedOutNumberResponse PutOptedOutNumber(PutOptedOutNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOptedOutNumberResponseUnmarshaller.Instance;

            return Invoke<PutOptedOutNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutOptedOutNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOptedOutNumber operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOptedOutNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        public virtual IAsyncResult BeginPutOptedOutNumber(PutOptedOutNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOptedOutNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutOptedOutNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOptedOutNumber.</param>
        /// 
        /// <returns>Returns a  PutOptedOutNumberResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        public virtual PutOptedOutNumberResponse EndPutOptedOutNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<PutOptedOutNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleasePhoneNumber

        /// <summary>
        /// Releases an existing origination phone number in your account. Once released, a phone
        /// number is no longer available for sending messages.
        /// 
        ///  
        /// <para>
        /// If the origination phone number has deletion protection enabled or is associated with
        /// a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual ReleasePhoneNumberResponse ReleasePhoneNumber(ReleasePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<ReleasePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleasePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleasePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginReleasePhoneNumber(ReleasePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReleasePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleasePhoneNumber.</param>
        /// 
        /// <returns>Returns a  ReleasePhoneNumberResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual ReleasePhoneNumberResponse EndReleasePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleasePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestPhoneNumber

        /// <summary>
        /// Request an origination phone number for use in your account. For more information
        /// on phone number request see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/settings-sms-request-number.html">
        /// Requesting a number </a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the RequestPhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        public virtual RequestPhoneNumberResponse RequestPhoneNumber(RequestPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<RequestPhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestPhoneNumber operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginRequestPhoneNumber(RequestPhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestPhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestPhoneNumber.</param>
        /// 
        /// <returns>Returns a  RequestPhoneNumberResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        public virtual RequestPhoneNumberResponse EndRequestPhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestPhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  SendTextMessage

        /// <summary>
        /// Creates a new text message and sends it to a recipient's phone number.
        /// 
        ///  
        /// <para>
        /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
        /// depends on the destination country of your messages, as well as the type of phone
        /// number (origination number) that you use to send the message. For more information,
        /// see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>Amazon Pinpoint User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTextMessage service method.</param>
        /// 
        /// <returns>The response from the SendTextMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        public virtual SendTextMessageResponse SendTextMessage(SendTextMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTextMessageResponseUnmarshaller.Instance;

            return Invoke<SendTextMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendTextMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTextMessage operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTextMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        public virtual IAsyncResult BeginSendTextMessage(SendTextMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTextMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendTextMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTextMessage.</param>
        /// 
        /// <returns>Returns a  SendTextMessageResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        public virtual SendTextMessageResponse EndSendTextMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendTextMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  SendVoiceMessage

        /// <summary>
        /// Allows you to send a request that sends a text message through Amazon Pinpoint. This
        /// operation uses <a href="http://aws.amazon.com/polly/">Amazon Polly</a> to convert
        /// a text script into a voice message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        public virtual SendVoiceMessageResponse SendVoiceMessage(SendVoiceMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendVoiceMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return Invoke<SendVoiceMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendVoiceMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendVoiceMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        public virtual IAsyncResult BeginSendVoiceMessage(SendVoiceMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendVoiceMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendVoiceMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendVoiceMessage.</param>
        /// 
        /// <returns>Returns a  SendVoiceMessageResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        public virtual SendVoiceMessageResponse EndSendVoiceMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendVoiceMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  SetDefaultMessageType

        /// <summary>
        /// Sets the default message type on a configuration set.
        /// 
        ///  
        /// <para>
        /// Choose the category of SMS messages that you plan to send from this account. If you
        /// send account-related messages or time-sensitive messages such as one-time passcodes,
        /// choose <b>Transactional</b>. If you plan to send messages that contain marketing material
        /// or other promotional content, choose <b>Promotional</b>. This setting applies to your
        /// entire Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageType service method.</param>
        /// 
        /// <returns>The response from the SetDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        public virtual SetDefaultMessageTypeResponse SetDefaultMessageType(SetDefaultMessageTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageTypeResponseUnmarshaller.Instance;

            return Invoke<SetDefaultMessageTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultMessageType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageType operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultMessageType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        public virtual IAsyncResult BeginSetDefaultMessageType(SetDefaultMessageTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultMessageType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultMessageType.</param>
        /// 
        /// <returns>Returns a  SetDefaultMessageTypeResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        public virtual SetDefaultMessageTypeResponse EndSetDefaultMessageType(IAsyncResult asyncResult)
        {
            return EndInvoke<SetDefaultMessageTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  SetDefaultSenderId

        /// <summary>
        /// Sets default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// When sending a text message to a destination country that supports sender IDs, the
        /// default sender ID on the configuration set specified will be used if no dedicated
        /// origination phone numbers or registered sender IDs are available in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultSenderId service method.</param>
        /// 
        /// <returns>The response from the SetDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        public virtual SetDefaultSenderIdResponse SetDefaultSenderId(SetDefaultSenderIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultSenderIdResponseUnmarshaller.Instance;

            return Invoke<SetDefaultSenderIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultSenderId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultSenderId operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultSenderId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        public virtual IAsyncResult BeginSetDefaultSenderId(SetDefaultSenderIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultSenderIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultSenderId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultSenderId.</param>
        /// 
        /// <returns>Returns a  SetDefaultSenderIdResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        public virtual SetDefaultSenderIdResponse EndSetDefaultSenderId(IAsyncResult asyncResult)
        {
            return EndInvoke<SetDefaultSenderIdResponse>(asyncResult);
        }

        #endregion
        
        #region  SetTextMessageSpendLimitOverride

        /// <summary>
        /// Sets an account level monthly spend limit override for sending text messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTextMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the SetTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        public virtual SetTextMessageSpendLimitOverrideResponse SetTextMessageSpendLimitOverride(SetTextMessageSpendLimitOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<SetTextMessageSpendLimitOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetTextMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTextMessageSpendLimitOverride operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTextMessageSpendLimitOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        public virtual IAsyncResult BeginSetTextMessageSpendLimitOverride(SetTextMessageSpendLimitOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetTextMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTextMessageSpendLimitOverride.</param>
        /// 
        /// <returns>Returns a  SetTextMessageSpendLimitOverrideResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        public virtual SetTextMessageSpendLimitOverrideResponse EndSetTextMessageSpendLimitOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<SetTextMessageSpendLimitOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  SetVoiceMessageSpendLimitOverride

        /// <summary>
        /// Sets an account level monthly spend limit override for sending voice messages. The
        /// requested spend limit must be less than or equal to the <code>MaxLimit</code>, which
        /// is set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVoiceMessageSpendLimitOverride service method.</param>
        /// 
        /// <returns>The response from the SetVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual SetVoiceMessageSpendLimitOverrideResponse SetVoiceMessageSpendLimitOverride(SetVoiceMessageSpendLimitOverrideRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<SetVoiceMessageSpendLimitOverrideResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetVoiceMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVoiceMessageSpendLimitOverride operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetVoiceMessageSpendLimitOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual IAsyncResult BeginSetVoiceMessageSpendLimitOverride(SetVoiceMessageSpendLimitOverrideRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetVoiceMessageSpendLimitOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetVoiceMessageSpendLimitOverride.</param>
        /// 
        /// <returns>Returns a  SetVoiceMessageSpendLimitOverrideResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual SetVoiceMessageSpendLimitOverrideResponse EndSetVoiceMessageSpendLimitOverride(IAsyncResult asyncResult)
        {
            return EndInvoke<SetVoiceMessageSpendLimitOverrideResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Amazon Pinpoint SMS Voice,
        /// version 2 resource. When you specify an existing tag key, the value is overwritten
        /// with the new value. Each resource can have a maximum of 50 tags. Each tag consists
        /// of a key and an optional value. Tag keys must be unique per resource. For more information
        /// about tags, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the association of the specified tags from an Amazon Pinpoint SMS Voice V2
        /// resource. For more information on tags see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/tagging-resources.html">
        /// Tagging Amazon Pinpoint resources</a> in the <i>Amazon Pinpoint Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventDestination

        /// <summary>
        /// Updates an existing event destination in a configuration set. You can update the IAM
        /// role ARN for CloudWatch Logs and Kinesis Data Firehose. You can also enable or disable
        /// the event destination.
        /// 
        ///  
        /// <para>
        /// You may want to update an event destination to change its matching event types or
        /// updating the destination resource ARN. You can't change an event destination's type
        /// between CloudWatch Logs, Kinesis Data Firehose, and Amazon SNS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        public virtual UpdateEventDestinationResponse UpdateEventDestination(UpdateEventDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDestination operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventDestination(UpdateEventDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventDestination.</param>
        /// 
        /// <returns>Returns a  UpdateEventDestinationResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        public virtual UpdateEventDestinationResponse EndUpdateEventDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumber

        /// <summary>
        /// Updates the configuration of an existing origination phone number. You can update
        /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
        /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
        /// 
        ///  
        /// <para>
        /// If the origination phone number is associated with a pool, an Error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginUpdatePhoneNumber(UpdatePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePool

        /// <summary>
        /// Updates the configuration of an existing pool. You can update the opt-out list, enable
        /// or disable two-way messaging, change the <code>TwoWayChannelArn</code>, enable or
        /// disable self-managed opt-outs, enable or disable deletion protection, and enable or
        /// disable shared routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePool service method.</param>
        /// 
        /// <returns>The response from the UpdatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        public virtual UpdatePoolResponse UpdatePool(UpdatePoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePoolResponseUnmarshaller.Instance;

            return Invoke<UpdatePoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePool operation on AmazonPinpointSMSVoiceV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        public virtual IAsyncResult BeginUpdatePool(UpdatePoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePool.</param>
        /// 
        /// <returns>Returns a  UpdatePoolResult from PinpointSMSVoiceV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        public virtual UpdatePoolResponse EndUpdatePool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePoolResponse>(asyncResult);
        }

        #endregion
        
    }
}