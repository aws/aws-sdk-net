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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKVoice.Model;
using Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKVoice.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKVoice
{
    /// <summary>
    /// Implementation for accessing ChimeSDKVoice
    ///
    /// The Amazon Chime SDK telephony APIs in this section enable developers to create PSTN
    /// calling solutions that use Amazon Chime SDK Voice Connectors, and Amazon Chime SDK
    /// SIP media applications. Developers can also order and manage phone numbers, create
    /// and manage Voice Connectors and SIP media applications, and run voice analytics.
    /// </summary>
    public partial class AmazonChimeSDKVoiceClient : AmazonServiceClient, IAmazonChimeSDKVoice
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKVoiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IChimeSDKVoicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKVoicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKVoicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
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
        public AmazonChimeSDKVoiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKVoiceConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
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
        public AmazonChimeSDKVoiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKVoiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(AmazonChimeSDKVoiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials and an
        /// AmazonChimeSDKVoiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials, AmazonChimeSDKVoiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKVoiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKVoiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKVoiceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChimeSDKVoiceEndpointResolver());
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


        #region  AssociatePhoneNumbersWithVoiceConnector

        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorResponse AssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnector.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorResponse EndAssociatePhoneNumbersWithVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumbersWithVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup

        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorGroupResponse AssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorGroupResponse EndAssociatePhoneNumbersWithVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeletePhoneNumber

        /// <summary>
        /// Moves phone numbers into the <b>Deletion queue</b>. Phone numbers must be disassociated
        /// from any users or Amazon Chime SDK Voice Connectors before they can be deleted. 
        /// 
        ///  
        /// <para>
        ///  Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
        /// permanently. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual BatchDeletePhoneNumberResponse BatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginBatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchDeletePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual BatchDeletePhoneNumberResponse EndBatchDeletePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeletePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdatePhoneNumber

        /// <summary>
        /// Updates one or more phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the BatchUpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual BatchUpdatePhoneNumberResponse BatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchUpdatePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchUpdatePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual BatchUpdatePhoneNumberResponse EndBatchUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePhoneNumberOrder

        /// <summary>
        /// Creates an order for phone numbers to be provisioned. For numbers outside the U.S.,
        /// you must use the Amazon Chime SDK SIP media application dial-in product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
        /// 
        /// <returns>The response from the CreatePhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual CreatePhoneNumberOrderResponse CreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<CreatePhoneNumberOrderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual IAsyncResult BeginCreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  CreatePhoneNumberOrderResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual CreatePhoneNumberOrderResponse EndCreatePhoneNumberOrder(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePhoneNumberOrderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxySession

        /// <summary>
        /// Creates a proxy session for the specified Amazon Chime SDK Voice Connector for the
        /// specified participant phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
        /// 
        /// <returns>The response from the CreateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual CreateProxySessionResponse CreateProxySession(CreateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return Invoke<CreateProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual IAsyncResult BeginCreateProxySession(CreateProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxySession.</param>
        /// 
        /// <returns>Returns a  CreateProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual CreateProxySessionResponse EndCreateProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipMediaApplication

        /// <summary>
        /// Creates a SIP media application. For more information about SIP media applications,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the CreateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual CreateSipMediaApplicationResponse CreateSipMediaApplication(CreateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateSipMediaApplication(CreateSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual CreateSipMediaApplicationResponse EndCreateSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipMediaApplicationCall

        /// <summary>
        /// Creates an outbound call to a phone number from the phone number specified in the
        /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
        /// 
        /// <returns>The response from the CreateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual CreateSipMediaApplicationCallResponse CreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationCallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual IAsyncResult BeginCreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationCallResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual CreateSipMediaApplicationCallResponse EndCreateSipMediaApplicationCall(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipMediaApplicationCallResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipRule

        /// <summary>
        /// Creates a SIP rule, which can be used to run a SIP media application as a target for
        /// a specific trigger type. For more information about SIP rules, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/manage-sip-applications.html">Managing
        /// SIP media applications and rules</a> in the <i>Amazon Chime SDK Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
        /// 
        /// <returns>The response from the CreateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual CreateSipRuleResponse CreateSipRule(CreateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual IAsyncResult BeginCreateSipRule(CreateSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipRule.</param>
        /// 
        /// <returns>Returns a  CreateSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual CreateSipRuleResponse EndCreateSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceConnector

        /// <summary>
        /// Creates an Amazon Chime SDK Voice Connector. For more information about Voice Connectors,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/voice-connector-groups.html">Managing
        /// Amazon Chime SDK Voice Connector groups</a> in the <i>Amazon Chime SDK Administrator
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual CreateVoiceConnectorResponse CreateVoiceConnector(CreateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceConnector(CreateVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual CreateVoiceConnectorResponse EndCreateVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceConnectorGroup

        /// <summary>
        /// Creates an Amazon Chime SDK Voice Connector group under the administrator's AWS account.
        /// You can associate Amazon Chime SDK Voice Connectors with the Voice Connector group
        /// by including <code>VoiceConnectorItems</code> in the request. 
        /// 
        ///  
        /// <para>
        /// You can include Voice Connectors from different AWS Regions in your group. This creates
        /// a fault tolerant mechanism for fallback in case of availability events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual CreateVoiceConnectorGroupResponse CreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual CreateVoiceConnectorGroupResponse EndCreateVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceProfile

        /// <summary>
        /// Creates a voice profile, which consists of an enrolled user and their latest voice
        /// print.
        /// 
        ///  <important> 
        /// <para>
        /// Before creating any voice profiles, you must provide all notices and obtain all consents
        /// from the speaker as required under applicable privacy and biometrics laws, and as
        /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
        /// for the Amazon Chime SDK.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about voice profiles and voice analytics, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
        /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        public virtual CreateVoiceProfileResponse CreateVoiceProfile(CreateVoiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceProfile(CreateVoiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceProfile.</param>
        /// 
        /// <returns>Returns a  CreateVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfile">REST API Reference for CreateVoiceProfile Operation</seealso>
        public virtual CreateVoiceProfileResponse EndCreateVoiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceProfileDomain

        /// <summary>
        /// Creates a voice profile domain, a collection of voice profiles, their voice prints,
        /// and encrypted enrollment audio.
        /// 
        ///  <important> 
        /// <para>
        /// Before creating any voice profiles, you must provide all notices and obtain all consents
        /// from the speaker as required under applicable privacy and biometrics laws, and as
        /// required under the <a href="https://aws.amazon.com/service-terms/">AWS service terms</a>
        /// for the Amazon Chime SDK.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about voice profile domains, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
        /// Amazon Chime SDK Voice Analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfileDomain service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        public virtual CreateVoiceProfileDomainResponse CreateVoiceProfileDomain(CreateVoiceProfileDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceProfileDomainResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceProfileDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceProfileDomain(CreateVoiceProfileDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceProfileDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  CreateVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceProfileDomain">REST API Reference for CreateVoiceProfileDomain Operation</seealso>
        public virtual CreateVoiceProfileDomainResponse EndCreateVoiceProfileDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceProfileDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePhoneNumber

        /// <summary>
        /// Moves the specified phone number into the <b>Deletion queue</b>. A phone number must
        /// be disassociated from any users or Amazon Chime SDK Voice Connectors before it can
        /// be deleted.
        /// 
        ///  
        /// <para>
        /// Deleted phone numbers remain in the <b>Deletion queue</b> queue for 7 days before
        /// they are deleted permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the DeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual DeletePhoneNumberResponse DeletePhoneNumber(DeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<DeletePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginDeletePhoneNumber(DeletePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  DeletePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual DeletePhoneNumberResponse EndDeletePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxySession

        /// <summary>
        /// Deletes the specified proxy session from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
        /// 
        /// <returns>The response from the DeleteProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual DeleteProxySessionResponse DeleteProxySession(DeleteProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return Invoke<DeleteProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxySession(DeleteProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxySession.</param>
        /// 
        /// <returns>Returns a  DeleteProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual DeleteProxySessionResponse EndDeleteProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSipMediaApplication

        /// <summary>
        /// Deletes a SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual DeleteSipMediaApplicationResponse DeleteSipMediaApplication(DeleteSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteSipMediaApplication(DeleteSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  DeleteSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual DeleteSipMediaApplicationResponse EndDeleteSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSipRule

        /// <summary>
        /// Deletes a SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
        /// 
        /// <returns>The response from the DeleteSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual DeleteSipRuleResponse DeleteSipRule(DeleteSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteSipRule(DeleteSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipRule.</param>
        /// 
        /// <returns>Returns a  DeleteSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual DeleteSipRuleResponse EndDeleteSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnector

        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector. Any phone numbers associated with the
        /// Amazon Chime SDK Voice Connector must be disassociated from it before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual DeleteVoiceConnectorResponse DeleteVoiceConnector(DeleteVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnector(DeleteVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual DeleteVoiceConnectorResponse EndDeleteVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Deletes the emergency calling details from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorEmergencyCallingConfigurationResponse DeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorEmergencyCallingConfigurationResponse EndDeleteVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorGroup

        /// <summary>
        /// Deletes an Amazon Chime SDK Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual DeleteVoiceConnectorGroupResponse DeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual DeleteVoiceConnectorGroupResponse EndDeleteVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorOrigination

        /// <summary>
        /// Deletes the origination settings for the specified Amazon Chime SDK Voice Connector.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Voice Connector, it must be deleted prior
        /// to deleting the origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual DeleteVoiceConnectorOriginationResponse DeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual DeleteVoiceConnectorOriginationResponse EndDeleteVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorProxy

        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual DeleteVoiceConnectorProxyResponse DeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual DeleteVoiceConnectorProxyResponse EndDeleteVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Deletes a Voice Connector's streaming configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorStreamingConfigurationResponse DeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorStreamingConfigurationResponse EndDeleteVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTermination

        /// <summary>
        /// Deletes the termination settings for the specified Amazon Chime SDK Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Voice Connector, it must be deleted prior
        /// to deleting the termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationResponse DeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationResponse EndDeleteVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTerminationCredentials

        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationCredentialsResponse DeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationCredentialsResponse EndDeleteVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceProfile

        /// <summary>
        /// Deletes a voice profile, including its voice print and enrollment data. WARNING: This
        /// action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        public virtual DeleteVoiceProfileResponse DeleteVoiceProfile(DeleteVoiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceProfile(DeleteVoiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfile">REST API Reference for DeleteVoiceProfile Operation</seealso>
        public virtual DeleteVoiceProfileResponse EndDeleteVoiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceProfileDomain

        /// <summary>
        /// Deletes all voice profiles in the domain. WARNING: This action is not reversible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfileDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        public virtual DeleteVoiceProfileDomainResponse DeleteVoiceProfileDomain(DeleteVoiceProfileDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceProfileDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceProfileDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceProfileDomain(DeleteVoiceProfileDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceProfileDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceProfileDomain">REST API Reference for DeleteVoiceProfileDomain Operation</seealso>
        public virtual DeleteVoiceProfileDomainResponse EndDeleteVoiceProfileDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceProfileDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnector

        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorResponse DisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorResponse EndDisassociatePhoneNumbersFromVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumbersFromVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup

        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime SDK Voice
        /// Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorGroupResponse DisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorGroupResponse EndDisassociatePhoneNumbersFromVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGlobalSettings

        /// <summary>
        /// Retrieves the global settings for the Amazon Chime SDK Voice Connectors in an AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the GetGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<GetGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginGetGlobalSettings(GetGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlobalSettings.</param>
        /// 
        /// <returns>Returns a  GetGlobalSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual GetGlobalSettingsResponse EndGetGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlobalSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumber

        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumber(GetPhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumber.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual GetPhoneNumberResponse EndGetPhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumberOrder

        /// <summary>
        /// Retrieves details for the specified phone number order, such as the order creation
        /// timestamp, phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual GetPhoneNumberOrderResponse GetPhoneNumberOrder(GetPhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberOrderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumberOrder(GetPhoneNumberOrderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberOrderResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual GetPhoneNumberOrderResponse EndGetPhoneNumberOrder(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberOrderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumberSettings

        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual GetPhoneNumberSettingsResponse GetPhoneNumberSettings(GetPhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumberSettings(GetPhoneNumberSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual GetPhoneNumberSettingsResponse EndGetPhoneNumberSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProxySession

        /// <summary>
        /// Retrieves the specified proxy session details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
        /// 
        /// <returns>The response from the GetProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual GetProxySessionResponse GetProxySession(GetProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return Invoke<GetProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual IAsyncResult BeginGetProxySession(GetProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProxySession.</param>
        /// 
        /// <returns>Returns a  GetProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual GetProxySessionResponse EndGetProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipMediaApplication

        /// <summary>
        /// Retrieves the information for a SIP media application, including name, AWS Region,
        /// and endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the GetSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual GetSipMediaApplicationResponse GetSipMediaApplication(GetSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginGetSipMediaApplication(GetSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual GetSipMediaApplicationResponse EndGetSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipMediaApplicationAlexaSkillConfiguration

        /// <summary>
        /// Gets the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationAlexaSkillConfigurationResponse GetSipMediaApplicationAlexaSkillConfiguration(GetSipMediaApplicationAlexaSkillConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationAlexaSkillConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationAlexaSkillConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetSipMediaApplicationAlexaSkillConfiguration(GetSipMediaApplicationAlexaSkillConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationAlexaSkillConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationAlexaSkillConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationAlexaSkillConfigurationResponse EndGetSipMediaApplicationAlexaSkillConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipMediaApplicationAlexaSkillConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipMediaApplicationLoggingConfiguration

        /// <summary>
        /// Retrieves the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationLoggingConfigurationResponse GetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationLoggingConfigurationResponse EndGetSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipMediaApplicationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipRule

        /// <summary>
        /// Retrieves the details of a SIP rule, such as the rule ID, name, triggers, and target
        /// endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
        /// 
        /// <returns>The response from the GetSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual GetSipRuleResponse GetSipRule(GetSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return Invoke<GetSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual IAsyncResult BeginGetSipRule(GetSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipRule.</param>
        /// 
        /// <returns>Returns a  GetSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual GetSipRuleResponse EndGetSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSpeakerSearchTask

        /// <summary>
        /// Retrieves the details of the specified speaker search task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask service method.</param>
        /// 
        /// <returns>The response from the GetSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual GetSpeakerSearchTaskResponse GetSpeakerSearchTask(GetSpeakerSearchTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<GetSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginGetSpeakerSearchTask(GetSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  GetSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSpeakerSearchTask">REST API Reference for GetSpeakerSearchTask Operation</seealso>
        public virtual GetSpeakerSearchTaskResponse EndGetSpeakerSearchTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpeakerSearchTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnector

        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector, such as timestamps,name,
        /// outbound host, and encryption requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual GetVoiceConnectorResponse GetVoiceConnector(GetVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnector(GetVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnector.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual GetVoiceConnectorResponse EndGetVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Retrieves the emergency calling configuration details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorEmergencyCallingConfigurationResponse GetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorEmergencyCallingConfigurationResponse EndGetVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorGroup

        /// <summary>
        /// Retrieves details for the specified Amazon Chime SDK Voice Connector group, such as
        /// timestamps,name, and associated <code>VoiceConnectorItems</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual GetVoiceConnectorGroupResponse GetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual GetVoiceConnectorGroupResponse EndGetVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorLoggingConfiguration

        /// <summary>
        /// Retrieves the logging configuration settings for the specified Voice Connector. Shows
        /// whether SIP message logs are enabled for sending to Amazon CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorLoggingConfigurationResponse GetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorLoggingConfigurationResponse EndGetVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorOrigination

        /// <summary>
        /// Retrieves the origination settings for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual GetVoiceConnectorOriginationResponse GetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual GetVoiceConnectorOriginationResponse EndGetVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorProxy

        /// <summary>
        /// Retrieves the proxy configuration details for the specified Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual GetVoiceConnectorProxyResponse GetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual GetVoiceConnectorProxyResponse EndGetVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime SDK Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorStreamingConfigurationResponse GetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorStreamingConfigurationResponse EndGetVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorTermination

        /// <summary>
        /// Retrieves the termination setting details for the specified Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual GetVoiceConnectorTerminationResponse GetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual GetVoiceConnectorTerminationResponse EndGetVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorTerminationHealth

        /// <summary>
        /// Retrieves information about the last time a <code>SIP OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTerminationHealth service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual GetVoiceConnectorTerminationHealthResponse GetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationHealthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTerminationHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTerminationHealth.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationHealthResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual GetVoiceConnectorTerminationHealthResponse EndGetVoiceConnectorTerminationHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorTerminationHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceProfile

        /// <summary>
        /// Retrieves the details of the specified voice profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfile service method.</param>
        /// 
        /// <returns>The response from the GetVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        public virtual GetVoiceProfileResponse GetVoiceProfile(GetVoiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceProfileResponseUnmarshaller.Instance;

            return Invoke<GetVoiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceProfile(GetVoiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceProfile.</param>
        /// 
        /// <returns>Returns a  GetVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfile">REST API Reference for GetVoiceProfile Operation</seealso>
        public virtual GetVoiceProfileResponse EndGetVoiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceProfileDomain

        /// <summary>
        /// Retrieves the details of the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfileDomain service method.</param>
        /// 
        /// <returns>The response from the GetVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        public virtual GetVoiceProfileDomainResponse GetVoiceProfileDomain(GetVoiceProfileDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceProfileDomainResponseUnmarshaller.Instance;

            return Invoke<GetVoiceProfileDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceProfileDomain(GetVoiceProfileDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceProfileDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  GetVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceProfileDomain">REST API Reference for GetVoiceProfileDomain Operation</seealso>
        public virtual GetVoiceProfileDomainResponse EndGetVoiceProfileDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceProfileDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceToneAnalysisTask

        /// <summary>
        /// Retrieves the details of a voice tone analysis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask service method.</param>
        /// 
        /// <returns>The response from the GetVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual GetVoiceToneAnalysisTaskResponse GetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<GetVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceToneAnalysisTask(GetVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  GetVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceToneAnalysisTask">REST API Reference for GetVoiceToneAnalysisTask Operation</seealso>
        public virtual GetVoiceToneAnalysisTaskResponse EndGetVoiceToneAnalysisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceToneAnalysisTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableVoiceConnectorRegions

        /// <summary>
        /// Lists the available AWS Regions in which you can create an Amazon Chime SDK Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions service method.</param>
        /// 
        /// <returns>The response from the ListAvailableVoiceConnectorRegions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        public virtual ListAvailableVoiceConnectorRegionsResponse ListAvailableVoiceConnectorRegions(ListAvailableVoiceConnectorRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableVoiceConnectorRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableVoiceConnectorRegionsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableVoiceConnectorRegionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableVoiceConnectorRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableVoiceConnectorRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        public virtual IAsyncResult BeginListAvailableVoiceConnectorRegions(ListAvailableVoiceConnectorRegionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableVoiceConnectorRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableVoiceConnectorRegionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableVoiceConnectorRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableVoiceConnectorRegions.</param>
        /// 
        /// <returns>Returns a  ListAvailableVoiceConnectorRegionsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        public virtual ListAvailableVoiceConnectorRegionsResponse EndListAvailableVoiceConnectorRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableVoiceConnectorRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumberOrders

        /// <summary>
        /// Lists the phone numbers for an administrator's Amazon Chime SDK account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumberOrders service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual ListPhoneNumberOrdersResponse ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumberOrdersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumberOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumberOrders(ListPhoneNumberOrdersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumberOrders.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumberOrdersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual ListPhoneNumberOrdersResponse EndListPhoneNumberOrders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumberOrdersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumbers

        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime SDK account, Amazon Chime SDK
        /// user, Amazon Chime SDK Voice Connector, or Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumbers(ListPhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse EndListPhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProxySessions

        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
        /// 
        /// <returns>The response from the ListProxySessions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual ListProxySessionsResponse ListProxySessions(ListProxySessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return Invoke<ListProxySessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxySessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual IAsyncResult BeginListProxySessions(ListProxySessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxySessions.</param>
        /// 
        /// <returns>Returns a  ListProxySessionsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual ListProxySessionsResponse EndListProxySessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProxySessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSipMediaApplications

        /// <summary>
        /// Lists the SIP media applications under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
        /// 
        /// <returns>The response from the ListSipMediaApplications service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual ListSipMediaApplicationsResponse ListSipMediaApplications(ListSipMediaApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListSipMediaApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipMediaApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual IAsyncResult BeginListSipMediaApplications(ListSipMediaApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipMediaApplications.</param>
        /// 
        /// <returns>Returns a  ListSipMediaApplicationsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual ListSipMediaApplicationsResponse EndListSipMediaApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSipMediaApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSipRules

        /// <summary>
        /// Lists the SIP rules under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
        /// 
        /// <returns>The response from the ListSipRules service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual ListSipRulesResponse ListSipRules(ListSipRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return Invoke<ListSipRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual IAsyncResult BeginListSipRules(ListSipRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipRules.</param>
        /// 
        /// <returns>Returns a  ListSipRulesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual ListSipRulesResponse EndListSipRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSipRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSupportedPhoneNumberCountries

        /// <summary>
        /// Lists the countries that you can order phone numbers from.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
        /// 
        /// <returns>The response from the ListSupportedPhoneNumberCountries service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        public virtual ListSupportedPhoneNumberCountriesResponse ListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedPhoneNumberCountriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedPhoneNumberCountriesResponseUnmarshaller.Instance;

            return Invoke<ListSupportedPhoneNumberCountriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSupportedPhoneNumberCountries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        public virtual IAsyncResult BeginListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedPhoneNumberCountriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedPhoneNumberCountriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSupportedPhoneNumberCountries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSupportedPhoneNumberCountries.</param>
        /// 
        /// <returns>Returns a  ListSupportedPhoneNumberCountriesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        public virtual ListSupportedPhoneNumberCountriesResponse EndListSupportedPhoneNumberCountries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSupportedPhoneNumberCountriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags in a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectorGroups

        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connector groups in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectorGroups service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual ListVoiceConnectorGroupsResponse ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorGroups.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorGroupsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual ListVoiceConnectorGroupsResponse EndListVoiceConnectorGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectors

        /// <summary>
        /// Lists the Amazon Chime SDK Voice Connectors in the administrators AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectors service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual ListVoiceConnectorsResponse ListVoiceConnectors(ListVoiceConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectors(ListVoiceConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectors.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual ListVoiceConnectorsResponse EndListVoiceConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectorTerminationCredentials

        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual ListVoiceConnectorTerminationCredentialsResponse ListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual ListVoiceConnectorTerminationCredentialsResponse EndListVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceProfileDomains

        /// <summary>
        /// Lists the specified voice profile domains in the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfileDomains service method.</param>
        /// 
        /// <returns>The response from the ListVoiceProfileDomains service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        public virtual ListVoiceProfileDomainsResponse ListVoiceProfileDomains(ListVoiceProfileDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceProfileDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceProfileDomainsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceProfileDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceProfileDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfileDomains operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceProfileDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        public virtual IAsyncResult BeginListVoiceProfileDomains(ListVoiceProfileDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceProfileDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceProfileDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceProfileDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceProfileDomains.</param>
        /// 
        /// <returns>Returns a  ListVoiceProfileDomainsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfileDomains">REST API Reference for ListVoiceProfileDomains Operation</seealso>
        public virtual ListVoiceProfileDomainsResponse EndListVoiceProfileDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceProfileDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceProfiles

        /// <summary>
        /// Lists the voice profiles in a voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListVoiceProfiles service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        public virtual ListVoiceProfilesResponse ListVoiceProfiles(ListVoiceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListVoiceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceProfiles operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListVoiceProfiles(ListVoiceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceProfiles.</param>
        /// 
        /// <returns>Returns a  ListVoiceProfilesResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceProfiles">REST API Reference for ListVoiceProfiles Operation</seealso>
        public virtual ListVoiceProfilesResponse EndListVoiceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSipMediaApplicationAlexaSkillConfiguration

        /// <summary>
        /// Updates the Alexa Skill configuration for the SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationAlexaSkillConfigurationResponse PutSipMediaApplicationAlexaSkillConfiguration(PutSipMediaApplicationAlexaSkillConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSipMediaApplicationAlexaSkillConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationAlexaSkillConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutSipMediaApplicationAlexaSkillConfiguration(PutSipMediaApplicationAlexaSkillConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationAlexaSkillConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationAlexaSkillConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationAlexaSkillConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationAlexaSkillConfigurationResponse EndPutSipMediaApplicationAlexaSkillConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSipMediaApplicationAlexaSkillConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSipMediaApplicationLoggingConfiguration

        /// <summary>
        /// Updates the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationLoggingConfigurationResponse PutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationLoggingConfigurationResponse EndPutSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSipMediaApplicationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Updates a Voice Connector's emergency calling configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorEmergencyCallingConfigurationResponse PutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorEmergencyCallingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorEmergencyCallingConfigurationResponse EndPutVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorLoggingConfiguration

        /// <summary>
        /// Updates a Voice Connector's logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorLoggingConfigurationResponse PutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorLoggingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorLoggingConfigurationResponse EndPutVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorOrigination

        /// <summary>
        /// Updates a Voice Connector's origination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual PutVoiceConnectorOriginationResponse PutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorOriginationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual PutVoiceConnectorOriginationResponse EndPutVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorProxy

        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual PutVoiceConnectorProxyResponse PutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorProxyResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual PutVoiceConnectorProxyResponse EndPutVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Updates a Voice Connector's streaming configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorStreamingConfigurationResponse PutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorStreamingConfigurationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorStreamingConfigurationResponse EndPutVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorTermination

        /// <summary>
        /// Updates a Voice Connector's termination settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual PutVoiceConnectorTerminationResponse PutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual PutVoiceConnectorTerminationResponse EndPutVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorTerminationCredentials

        /// <summary>
        /// Updates a Voice Connector's termination credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual PutVoiceConnectorTerminationCredentialsResponse PutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationCredentialsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual PutVoiceConnectorTerminationCredentialsResponse EndPutVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  RestorePhoneNumber

        /// <summary>
        /// Restores a deleted phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the RestorePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual RestorePhoneNumberResponse RestorePhoneNumber(RestorePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<RestorePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestorePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginRestorePhoneNumber(RestorePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestorePhoneNumber.</param>
        /// 
        /// <returns>Returns a  RestorePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual RestorePhoneNumberResponse EndRestorePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<RestorePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchAvailablePhoneNumbers

        /// <summary>
        /// Searches the provisioned phone numbers in an organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<SearchAvailablePhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAvailablePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginSearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAvailablePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  SearchAvailablePhoneNumbersResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse EndSearchAvailablePhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchAvailablePhoneNumbersResponse>(asyncResult);
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
        /// <returns>The response from the StartSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual StartSpeakerSearchTaskResponse StartSpeakerSearchTask(StartSpeakerSearchTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<StartSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginStartSpeakerSearchTask(StartSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StartSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartSpeakerSearchTask">REST API Reference for StartSpeakerSearchTask Operation</seealso>
        public virtual StartSpeakerSearchTaskResponse EndStartSpeakerSearchTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSpeakerSearchTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartVoiceToneAnalysisTask

        /// <summary>
        /// Starts a voice tone analysis task. For more information about voice tone analysis,
        /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
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
        /// <returns>The response from the StartVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        public virtual StartVoiceToneAnalysisTaskResponse StartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<StartVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginStartVoiceToneAnalysisTask(StartVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StartVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StartVoiceToneAnalysisTask">REST API Reference for StartVoiceToneAnalysisTask Operation</seealso>
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
        /// <returns>The response from the StopSpeakerSearchTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        public virtual StopSpeakerSearchTaskResponse StopSpeakerSearchTask(StopSpeakerSearchTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSpeakerSearchTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSpeakerSearchTaskResponseUnmarshaller.Instance;

            return Invoke<StopSpeakerSearchTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSpeakerSearchTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSpeakerSearchTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSpeakerSearchTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
        public virtual IAsyncResult BeginStopSpeakerSearchTask(StopSpeakerSearchTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StopSpeakerSearchTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopSpeakerSearchTask">REST API Reference for StopSpeakerSearchTask Operation</seealso>
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
        /// <returns>The response from the StopVoiceToneAnalysisTask service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnprocessableEntityException">
        /// A well-formed request couldn't be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual StopVoiceToneAnalysisTaskResponse StopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopVoiceToneAnalysisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVoiceToneAnalysisTaskResponseUnmarshaller.Instance;

            return Invoke<StopVoiceToneAnalysisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopVoiceToneAnalysisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopVoiceToneAnalysisTask operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopVoiceToneAnalysisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual IAsyncResult BeginStopVoiceToneAnalysisTask(StopVoiceToneAnalysisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StopVoiceToneAnalysisTaskResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/StopVoiceToneAnalysisTask">REST API Reference for StopVoiceToneAnalysisTask Operation</seealso>
        public virtual StopVoiceToneAnalysisTaskResponse EndStopVoiceToneAnalysisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopVoiceToneAnalysisTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlobalSettings

        /// <summary>
        /// Updates global settings for the Amazon Chime SDK Voice Connectors in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlobalSettings(UpdateGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalSettings.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse EndUpdateGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlobalSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumber

        /// <summary>
        /// Updates phone number details, such as product type or calling name, for the specified
        /// phone number ID. You can update one phone number detail at a time. For example, you
        /// can update either the product type or the calling name in one action.
        /// 
        ///  
        /// <para>
        /// For numbers outside the U.S., you must use the Amazon Chime SDK SIP Media Application
        /// Dial-In product type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take 72 hours to complete. Pending updates to
        /// outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
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
        /// <returns>Returns a  UpdatePhoneNumberResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumberSettings

        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual UpdatePhoneNumberSettingsResponse UpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberSettingsResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual UpdatePhoneNumberSettingsResponse EndUpdatePhoneNumberSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxySession

        /// <summary>
        /// Updates the specified proxy session details, such as voice or SMS capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
        /// 
        /// <returns>The response from the UpdateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual UpdateProxySessionResponse UpdateProxySession(UpdateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return Invoke<UpdateProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxySession(UpdateProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxySession.</param>
        /// 
        /// <returns>Returns a  UpdateProxySessionResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual UpdateProxySessionResponse EndUpdateProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSipMediaApplication

        /// <summary>
        /// Updates the details of the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual UpdateSipMediaApplicationResponse UpdateSipMediaApplication(UpdateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateSipMediaApplication(UpdateSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual UpdateSipMediaApplicationResponse EndUpdateSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSipMediaApplicationCall

        /// <summary>
        /// Invokes the AWS Lambda function associated with the SIP media application and transaction
        /// ID in an update request. The Lambda function can then return a new set of actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall service method.</param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        public virtual UpdateSipMediaApplicationCallResponse UpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return Invoke<UpdateSipMediaApplicationCallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        public virtual IAsyncResult BeginUpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationCallResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        public virtual UpdateSipMediaApplicationCallResponse EndUpdateSipMediaApplicationCall(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSipMediaApplicationCallResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSipRule

        /// <summary>
        /// Updates the details of the specified SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
        /// 
        /// <returns>The response from the UpdateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual UpdateSipRuleResponse UpdateSipRule(UpdateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateSipRule(UpdateSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipRule.</param>
        /// 
        /// <returns>Returns a  UpdateSipRuleResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual UpdateSipRuleResponse EndUpdateSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceConnector

        /// <summary>
        /// Updates the details for the specified Amazon Chime SDK Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual UpdateVoiceConnectorResponse UpdateVoiceConnector(UpdateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceConnector(UpdateVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual UpdateVoiceConnectorResponse EndUpdateVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceConnectorGroup

        /// <summary>
        /// Updates the settings for the specified Amazon Chime SDK Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual UpdateVoiceConnectorGroupResponse UpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorGroupResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual UpdateVoiceConnectorGroupResponse EndUpdateVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceProfile

        /// <summary>
        /// Updates the specified voice profile’s voice print and refreshes its expiration timestamp.
        /// 
        ///  <important> 
        /// <para>
        /// As a condition of using this feature, you acknowledge that the collection, use, storage,
        /// and retention of your caller’s biometric identifiers and biometric information (“biometric
        /// data”) in the form of a digital voiceprint requires the caller’s informed consent
        /// via a written release. Such consent is required under various state laws, including
        /// biometrics laws in Illinois, Texas, Washington and other state privacy laws.
        /// </para>
        ///  
        /// <para>
        /// You must provide a written release to each caller through a process that clearly reflects
        /// each caller’s informed consent before using Amazon Chime SDK Voice Insights service,
        /// as required under the terms of your agreement with AWS governing your use of the service.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceProfile service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// Multiple instances of the same request were made simultaneously.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.GoneException">
        /// Access to the target resource is no longer available at the origin server. This condition
        /// is likely to be permanent.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        public virtual UpdateVoiceProfileResponse UpdateVoiceProfile(UpdateVoiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfile operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceProfile(UpdateVoiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceProfile.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceProfileResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfile">REST API Reference for UpdateVoiceProfile Operation</seealso>
        public virtual UpdateVoiceProfileResponse EndUpdateVoiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceProfileDomain

        /// <summary>
        /// Updates the settings for the specified voice profile domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfileDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceProfileDomain service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// You don't have the permissions needed to run this action.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        public virtual UpdateVoiceProfileDomainResponse UpdateVoiceProfileDomain(UpdateVoiceProfileDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceProfileDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceProfileDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceProfileDomain operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceProfileDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceProfileDomain(UpdateVoiceProfileDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceProfileDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceProfileDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceProfileDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceProfileDomain.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceProfileDomainResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceProfileDomain">REST API Reference for UpdateVoiceProfileDomain Operation</seealso>
        public virtual UpdateVoiceProfileDomainResponse EndUpdateVoiceProfileDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceProfileDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateE911Address

        /// <summary>
        /// Validates an address to be used for 911 calls made with Amazon Chime SDK Voice Connectors.
        /// You can use validated addresses in a Presence Information Data Format Location Object
        /// file that you include in SIP requests. That helps ensure that addresses are routed
        /// to the appropriate Public Safety Answering Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address service method.</param>
        /// 
        /// <returns>The response from the ValidateE911Address service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// The requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// The number of customer requests exceeds the request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// The client isn't authorized to request a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        public virtual ValidateE911AddressResponse ValidateE911Address(ValidateE911AddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateE911AddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateE911AddressResponseUnmarshaller.Instance;

            return Invoke<ValidateE911AddressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address operation on AmazonChimeSDKVoiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateE911Address
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        public virtual IAsyncResult BeginValidateE911Address(ValidateE911AddressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateE911AddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateE911AddressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateE911Address operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateE911Address.</param>
        /// 
        /// <returns>Returns a  ValidateE911AddressResult from ChimeSDKVoice.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        public virtual ValidateE911AddressResponse EndValidateE911Address(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateE911AddressResponse>(asyncResult);
        }

        #endregion
        
    }
}