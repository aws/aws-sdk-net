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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// Accepts a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to accept the link request and establish the connection.
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
        /// Accepts a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to accept the link request and establish the connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AcceptLinkResponse> AcceptLinkAsync(AcceptLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptLinkResponse>(request, options, cancellationToken);
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
        /// Creates an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateInboundExternalLinkResponse> CreateInboundExternalLinkAsync(CreateInboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInboundExternalLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLink


        /// <summary>
        /// Creates a new link between gateways.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows gateways to communicate and exchange bid requests
        /// and responses.
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
        /// Creates a new link between gateways.
        /// 
        ///  
        /// <para>
        /// Establishes a connection that allows gateways to communicate and exchange bid requests
        /// and responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLinkResponse>(request, options, cancellationToken);
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
        /// Creates an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateOutboundExternalLinkResponse> CreateOutboundExternalLinkAsync(CreateOutboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOutboundExternalLinkResponse>(request, options, cancellationToken);
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
        /// Creates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateRequesterGatewayResponse> CreateRequesterGatewayAsync(CreateRequesterGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRequesterGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRequesterGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResponderGateway


        /// <summary>
        /// Creates a responder gateway.
        /// 
        ///  <important> 
        /// <para>
        /// A domain name or managed endpoint is required.
        /// </para>
        ///  </important>
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
        /// Creates a responder gateway.
        /// 
        ///  <important> 
        /// <para>
        /// A domain name or managed endpoint is required.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateResponderGatewayResponse> CreateResponderGatewayAsync(CreateResponderGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponderGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateResponderGatewayResponse>(request, options, cancellationToken);
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
        /// Deletes an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteInboundExternalLinkResponse> DeleteInboundExternalLinkAsync(DeleteInboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInboundExternalLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLink


        /// <summary>
        /// Deletes a link between gateways.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between gateways. This action cannot be undone.
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
        /// Deletes a link between gateways.
        /// 
        ///  
        /// <para>
        /// Permanently removes the connection between gateways. This action cannot be undone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteLinkResponse> DeleteLinkAsync(DeleteLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLinkResponse>(request, options, cancellationToken);
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
        /// Deletes an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteOutboundExternalLinkResponse> DeleteOutboundExternalLinkAsync(DeleteOutboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOutboundExternalLinkResponse>(request, options, cancellationToken);
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
        /// Deletes a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRequesterGatewayResponse> DeleteRequesterGatewayAsync(DeleteRequesterGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRequesterGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRequesterGatewayResponse>(request, options, cancellationToken);
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
        /// Deletes a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteResponderGatewayResponse> DeleteResponderGatewayAsync(DeleteResponderGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponderGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResponderGatewayResponse>(request, options, cancellationToken);
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
        /// Retrieves information about an inbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetInboundExternalLinkResponse> GetInboundExternalLinkAsync(GetInboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInboundExternalLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLink


        /// <summary>
        /// Retrieves information about a link between gateways.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// gateways.
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
        /// Retrieves information about a link between gateways.
        /// 
        ///  
        /// <para>
        /// Returns detailed information about the link configuration, status, and associated
        /// gateways.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLinkResponse> GetLinkAsync(GetLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLinkResponse>(request, options, cancellationToken);
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
        /// Retrieves information about an outbound external link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutboundExternalLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetOutboundExternalLinkResponse> GetOutboundExternalLinkAsync(GetOutboundExternalLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOutboundExternalLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutboundExternalLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutboundExternalLinkResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRequesterGatewayResponse> GetRequesterGatewayAsync(GetRequesterGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequesterGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRequesterGatewayResponse>(request, options, cancellationToken);
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
        /// Retrieves information about a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResponderGatewayResponse> GetResponderGatewayAsync(GetResponderGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponderGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResponderGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLinks


        /// <summary>
        /// Lists links associated with gateways.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified gateways, including their status and
        /// configuration details.
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
        /// Lists links associated with gateways.
        /// 
        ///  
        /// <para>
        /// Returns a list of all links for the specified gateways, including their status and
        /// configuration details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListLinksResponse> ListLinksAsync(ListLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLinksResponse>(request, options, cancellationToken);
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
        /// Lists requester gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequesterGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRequesterGatewaysResponse> ListRequesterGatewaysAsync(ListRequesterGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequesterGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequesterGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRequesterGatewaysResponse>(request, options, cancellationToken);
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
        /// Lists reponder gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponderGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListResponderGatewaysResponse> ListResponderGatewaysAsync(ListResponderGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResponderGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponderGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResponderGatewaysResponse>(request, options, cancellationToken);
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
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectLink


        /// <summary>
        /// Rejects a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to decline the link request.
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
        /// Rejects a link request between gateways.
        /// 
        ///  
        /// <para>
        /// When a requester gateway requests to link with a responder gateway, the responder
        /// can use this operation to decline the link request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RejectLinkResponse> RejectLinkAsync(RejectLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectLinkResponse>(request, options, cancellationToken);
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
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
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
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLink


        /// <summary>
        /// Updates the configuration of a link between gateways.
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
        /// Updates the configuration of a link between gateways.
        /// 
        ///  
        /// <para>
        /// Allows you to modify settings and parameters for an existing link.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLinkResponse>(request, options, cancellationToken);
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
        /// Updates a link module flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLinkModuleFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateLinkModuleFlowResponse> UpdateLinkModuleFlowAsync(UpdateLinkModuleFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLinkModuleFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkModuleFlowResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLinkModuleFlowResponse>(request, options, cancellationToken);
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
        /// Updates a requester gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequesterGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateRequesterGatewayResponse> UpdateRequesterGatewayAsync(UpdateRequesterGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRequesterGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRequesterGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRequesterGatewayResponse>(request, options, cancellationToken);
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
        /// Updates a responder gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponderGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateResponderGatewayResponse> UpdateResponderGatewayAsync(UpdateResponderGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResponderGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponderGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateResponderGatewayResponse>(request, options, cancellationToken);
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