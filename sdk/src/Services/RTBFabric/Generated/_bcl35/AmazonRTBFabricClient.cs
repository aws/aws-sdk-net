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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.RTBFabric.Model;
using Amazon.RTBFabric.Model.Internal.MarshallTransformations;
using Amazon.RTBFabric.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.RTBFabric
{
    /// <summary>
    /// <para>Implementation for accessing RTBFabric</para>
    ///
    /// Amazon Web Services RTB Fabric provides secure, low-latency infrastructure for connecting
    /// real-time bidding (RTB) applications. Rather than hosting applications directly, RTB
    /// Fabric acts as the connecting fabric that enables your applications to communicate
    /// efficiently over private networks instead of the public internet. You maintain complete
    /// control over your applications, data, and bidding decisions, while RTB Fabric provides
    /// the underlying infrastructure for secure, reliable connectivity.
    /// 
    ///  
    /// <para>
    /// You can use these APIs to complete RTB Fabric tasks, such as setting up audit log
    /// ingestions or viewing user access. For more information about RTB Fabric, including
    /// the required permissions to use the service, see the <a href="https://docs.aws.amazon.com/rtb-fabric/latest/userguide/">Amazon
    /// Web Services RTB Fabric User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonRTBFabricClient : AmazonServiceClient, IAmazonRTBFabric
    {
        private static IServiceMetadata serviceMetadata = new AmazonRTBFabricMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRTBFabricPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRTBFabricPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RTBFabricPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRTBFabricClient with the credentials loaded from the application's
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
        public AmazonRTBFabricClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRTBFabricConfig()) { }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with the credentials loaded from the application's
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
        public AmazonRTBFabricClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRTBFabricConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRTBFabricClient Configuration Object</param>
        public AmazonRTBFabricClient(AmazonRTBFabricConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRTBFabricClient(AWSCredentials credentials)
            : this(credentials, new AmazonRTBFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRTBFabricClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRTBFabricConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Credentials and an
        /// AmazonRTBFabricClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRTBFabricClient Configuration Object</param>
        public AmazonRTBFabricClient(AWSCredentials credentials, AmazonRTBFabricConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRTBFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRTBFabricConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRTBFabricClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRTBFabricClient Configuration Object</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRTBFabricConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRTBFabricConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRTBFabricConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRTBFabricClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRTBFabricClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRTBFabricClient Configuration Object</param>
        public AmazonRTBFabricClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRTBFabricConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRTBFabricEndpointResolver());
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


        #region  AcceptLink

        /// <summary>
        /// Accepts a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to accept the link request and establish the
        /// connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// 
        /// <returns>The response from the AcceptLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        public virtual AcceptLinkResponse AcceptLink(AcceptLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptLinkResponseUnmarshaller.Instance;

            return Invoke<AcceptLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        public virtual IAsyncResult BeginAcceptLink(AcceptLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptLink.</param>
        /// 
        /// <returns>Returns a  AcceptLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/AcceptLink">REST API Reference for AcceptLink Operation</seealso>
        public virtual AcceptLinkResponse EndAcceptLink(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInboundExternalLink

        /// <summary>
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        public virtual CreateInboundExternalLinkResponse CreateInboundExternalLink(CreateInboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<CreateInboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginCreateInboundExternalLink(CreateInboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  CreateInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateInboundExternalLink">REST API Reference for CreateInboundExternalLink Operation</seealso>
        public virtual CreateInboundExternalLinkResponse EndCreateInboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLink

        /// <summary>
        /// Creates a new link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows RTB applications to communicate and exchange
        /// bid requests and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return Invoke<CreateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual IAsyncResult BeginCreateLink(CreateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLink.</param>
        /// 
        /// <returns>Returns a  CreateLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual CreateLinkResponse EndCreateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOutboundExternalLink

        /// <summary>
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        public virtual CreateOutboundExternalLinkResponse CreateOutboundExternalLink(CreateOutboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<CreateOutboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginCreateOutboundExternalLink(CreateOutboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  CreateOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateOutboundExternalLink">REST API Reference for CreateOutboundExternalLink Operation</seealso>
        public virtual CreateOutboundExternalLinkResponse EndCreateOutboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOutboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRequesterGateway

        /// <summary>
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the CreateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        public virtual CreateRequesterGatewayResponse CreateRequesterGateway(CreateRequesterGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRequesterGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateRequesterGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateRequesterGateway(CreateRequesterGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRequesterGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRequesterGateway.</param>
        /// 
        /// <returns>Returns a  CreateRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateRequesterGateway">REST API Reference for CreateRequesterGateway Operation</seealso>
        public virtual CreateRequesterGatewayResponse EndCreateRequesterGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRequesterGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResponderGateway

        /// <summary>
        /// Creates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the CreateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        public virtual CreateResponderGatewayResponse CreateResponderGateway(CreateResponderGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponderGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateResponderGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateResponderGateway(CreateResponderGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponderGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResponderGateway.</param>
        /// 
        /// <returns>Returns a  CreateResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/CreateResponderGateway">REST API Reference for CreateResponderGateway Operation</seealso>
        public virtual CreateResponderGatewayResponse EndCreateResponderGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResponderGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInboundExternalLink

        /// <summary>
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        public virtual DeleteInboundExternalLinkResponse DeleteInboundExternalLink(DeleteInboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteInboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteInboundExternalLink(DeleteInboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  DeleteInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteInboundExternalLink">REST API Reference for DeleteInboundExternalLink Operation</seealso>
        public virtual DeleteInboundExternalLinkResponse EndDeleteInboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLink

        /// <summary>
        /// Deletes a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between RTB applications. This action cannot be
        /// undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual DeleteLinkResponse DeleteLink(DeleteLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteLink(DeleteLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLink.</param>
        /// 
        /// <returns>Returns a  DeleteLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual DeleteLinkResponse EndDeleteLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOutboundExternalLink

        /// <summary>
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        public virtual DeleteOutboundExternalLinkResponse DeleteOutboundExternalLink(DeleteOutboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteOutboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteOutboundExternalLink(DeleteOutboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  DeleteOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteOutboundExternalLink">REST API Reference for DeleteOutboundExternalLink Operation</seealso>
        public virtual DeleteOutboundExternalLinkResponse EndDeleteOutboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOutboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRequesterGateway

        /// <summary>
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        public virtual DeleteRequesterGatewayResponse DeleteRequesterGateway(DeleteRequesterGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRequesterGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteRequesterGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteRequesterGateway(DeleteRequesterGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRequesterGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRequesterGateway.</param>
        /// 
        /// <returns>Returns a  DeleteRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteRequesterGateway">REST API Reference for DeleteRequesterGateway Operation</seealso>
        public virtual DeleteRequesterGatewayResponse EndDeleteRequesterGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRequesterGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResponderGateway

        /// <summary>
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        public virtual DeleteResponderGatewayResponse DeleteResponderGateway(DeleteResponderGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponderGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteResponderGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteResponderGateway(DeleteResponderGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponderGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResponderGateway.</param>
        /// 
        /// <returns>Returns a  DeleteResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/DeleteResponderGateway">REST API Reference for DeleteResponderGateway Operation</seealso>
        public virtual DeleteResponderGatewayResponse EndDeleteResponderGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResponderGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInboundExternalLink

        /// <summary>
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetInboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        public virtual GetInboundExternalLinkResponse GetInboundExternalLink(GetInboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<GetInboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginGetInboundExternalLink(GetInboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInboundExternalLink.</param>
        /// 
        /// <returns>Returns a  GetInboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetInboundExternalLink">REST API Reference for GetInboundExternalLink Operation</seealso>
        public virtual GetInboundExternalLinkResponse EndGetInboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLink

        /// <summary>
        /// Retrieves information about a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// RTB applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        public virtual GetLinkResponse GetLink(GetLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkResponseUnmarshaller.Instance;

            return Invoke<GetLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        public virtual IAsyncResult BeginGetLink(GetLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLink.</param>
        /// 
        /// <returns>Returns a  GetLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetLink">REST API Reference for GetLink Operation</seealso>
        public virtual GetLinkResponse EndGetLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOutboundExternalLink

        /// <summary>
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// 
        /// <returns>The response from the GetOutboundExternalLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        public virtual GetOutboundExternalLinkResponse GetOutboundExternalLink(GetOutboundExternalLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutboundExternalLinkResponseUnmarshaller.Instance;

            return Invoke<GetOutboundExternalLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutboundExternalLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        public virtual IAsyncResult BeginGetOutboundExternalLink(GetOutboundExternalLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutboundExternalLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutboundExternalLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutboundExternalLink.</param>
        /// 
        /// <returns>Returns a  GetOutboundExternalLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetOutboundExternalLink">REST API Reference for GetOutboundExternalLink Operation</seealso>
        public virtual GetOutboundExternalLinkResponse EndGetOutboundExternalLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOutboundExternalLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRequesterGateway

        /// <summary>
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the GetRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        public virtual GetRequesterGatewayResponse GetRequesterGateway(GetRequesterGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequesterGatewayResponseUnmarshaller.Instance;

            return Invoke<GetRequesterGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        public virtual IAsyncResult BeginGetRequesterGateway(GetRequesterGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequesterGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequesterGateway.</param>
        /// 
        /// <returns>Returns a  GetRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetRequesterGateway">REST API Reference for GetRequesterGateway Operation</seealso>
        public virtual GetRequesterGatewayResponse EndGetRequesterGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRequesterGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResponderGateway

        /// <summary>
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// 
        /// <returns>The response from the GetResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        public virtual GetResponderGatewayResponse GetResponderGateway(GetResponderGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponderGatewayResponseUnmarshaller.Instance;

            return Invoke<GetResponderGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        public virtual IAsyncResult BeginGetResponderGateway(GetResponderGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponderGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResponderGateway.</param>
        /// 
        /// <returns>Returns a  GetResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/GetResponderGateway">REST API Reference for GetResponderGateway Operation</seealso>
        public virtual GetResponderGatewayResponse EndGetResponderGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResponderGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLinks

        /// <summary>
        /// Lists links associated with an RTB application.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified RTB application, including their status
        /// and configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        public virtual ListLinksResponse ListLinks(ListLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinksResponseUnmarshaller.Instance;

            return Invoke<ListLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinks operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        public virtual IAsyncResult BeginListLinks(ListLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinks.</param>
        /// 
        /// <returns>Returns a  ListLinksResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListLinks">REST API Reference for ListLinks Operation</seealso>
        public virtual ListLinksResponse EndListLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRequesterGateways

        /// <summary>
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// 
        /// <returns>The response from the ListRequesterGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        public virtual ListRequesterGatewaysResponse ListRequesterGateways(ListRequesterGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequesterGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequesterGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListRequesterGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRequesterGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRequesterGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        public virtual IAsyncResult BeginListRequesterGateways(ListRequesterGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequesterGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequesterGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRequesterGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRequesterGateways.</param>
        /// 
        /// <returns>Returns a  ListRequesterGatewaysResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListRequesterGateways">REST API Reference for ListRequesterGateways Operation</seealso>
        public virtual ListRequesterGatewaysResponse EndListRequesterGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRequesterGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResponderGateways

        /// <summary>
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// 
        /// <returns>The response from the ListResponderGateways service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        public virtual ListResponderGatewaysResponse ListResponderGateways(ListResponderGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResponderGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponderGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListResponderGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResponderGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResponderGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        public virtual IAsyncResult BeginListResponderGateways(ListResponderGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResponderGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponderGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResponderGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResponderGateways.</param>
        /// 
        /// <returns>Returns a  ListResponderGatewaysResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListResponderGateways">REST API Reference for ListResponderGateways Operation</seealso>
        public virtual ListResponderGatewaysResponse EndListResponderGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResponderGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectLink

        /// <summary>
        /// Rejects a link request between RTB applications.
        /// 
        ///  
        /// <para>
        /// When a requester RTB application requests to link with a responder RTB application,
        /// the responder can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// 
        /// <returns>The response from the RejectLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        public virtual RejectLinkResponse RejectLink(RejectLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectLinkResponseUnmarshaller.Instance;

            return Invoke<RejectLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        public virtual IAsyncResult BeginRejectLink(RejectLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectLink.</param>
        /// 
        /// <returns>Returns a  RejectLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/RejectLink">REST API Reference for RejectLink Operation</seealso>
        public virtual RejectLinkResponse EndRejectLink(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLink

        /// <summary>
        /// Updates the configuration of a link between RTB applications.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual UpdateLinkResponse UpdateLink(UpdateLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual IAsyncResult BeginUpdateLink(UpdateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLink.</param>
        /// 
        /// <returns>Returns a  UpdateLinkResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual UpdateLinkResponse EndUpdateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLinkModuleFlow

        /// <summary>
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateLinkModuleFlow service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ServiceQuotaExceededException">
        /// The request could not be completed because you exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        public virtual UpdateLinkModuleFlowResponse UpdateLinkModuleFlow(UpdateLinkModuleFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkModuleFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkModuleFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkModuleFlowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLinkModuleFlow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLinkModuleFlow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        public virtual IAsyncResult BeginUpdateLinkModuleFlow(UpdateLinkModuleFlowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkModuleFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkModuleFlowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLinkModuleFlow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLinkModuleFlow.</param>
        /// 
        /// <returns>Returns a  UpdateLinkModuleFlowResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateLinkModuleFlow">REST API Reference for UpdateLinkModuleFlow Operation</seealso>
        public virtual UpdateLinkModuleFlowResponse EndUpdateLinkModuleFlow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLinkModuleFlowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRequesterGateway

        /// <summary>
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateRequesterGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        public virtual UpdateRequesterGatewayResponse UpdateRequesterGateway(UpdateRequesterGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRequesterGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateRequesterGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRequesterGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateRequesterGateway(UpdateRequesterGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRequesterGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRequesterGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRequesterGateway.</param>
        /// 
        /// <returns>Returns a  UpdateRequesterGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateRequesterGateway">REST API Reference for UpdateRequesterGateway Operation</seealso>
        public virtual UpdateRequesterGatewayResponse EndUpdateRequesterGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRequesterGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResponderGateway

        /// <summary>
        /// Updates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateResponderGateway service method, as returned by RTBFabric.</returns>
        /// <exception cref="Amazon.RTBFabric.Model.AccessDeniedException">
        /// The request could not be completed because you do not have sufficient access to perform
        /// this action.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ConflictException">
        /// The request could not be completed because of a conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.InternalServerException">
        /// The request could not be completed because of an internal server error. Try your call
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ResourceNotFoundException">
        /// The request could not be completed because the resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RTBFabric.Model.ValidationException">
        /// The request could not be completed because it fails satisfy the constraints specified
        /// by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        public virtual UpdateResponderGatewayResponse UpdateResponderGateway(UpdateResponderGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponderGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateResponderGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway operation on AmazonRTBFabricClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResponderGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateResponderGateway(UpdateResponderGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponderGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResponderGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResponderGateway.</param>
        /// 
        /// <returns>Returns a  UpdateResponderGatewayResult from RTBFabric.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rtbfabric-2023-05-15/UpdateResponderGateway">REST API Reference for UpdateResponderGateway Operation</seealso>
        public virtual UpdateResponderGatewayResponse EndUpdateResponderGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResponderGatewayResponse>(asyncResult);
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
            var resolver = new AmazonRTBFabricEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}