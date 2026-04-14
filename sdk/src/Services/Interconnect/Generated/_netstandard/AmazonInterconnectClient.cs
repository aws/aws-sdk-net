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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Interconnect.Model;
using Amazon.Interconnect.Model.Internal.MarshallTransformations;
using Amazon.Interconnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Interconnect
{
    /// <summary>
    /// <para>Implementation for accessing Interconnect</para>
    ///
    /// Provides managed connections between your AWS network resources and select partner
    /// network resources.
    /// </summary>
    public partial class AmazonInterconnectClient : AmazonServiceClient, IAmazonInterconnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonInterconnectMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonInterconnectClient with the credentials loaded from the application's
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
        public AmazonInterconnectClient()
            : base(new AmazonInterconnectConfig()) { }

        /// <summary>
        /// Constructs AmazonInterconnectClient with the credentials loaded from the application's
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
        public AmazonInterconnectClient(RegionEndpoint region)
            : base(new AmazonInterconnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInterconnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInterconnectClient Configuration Object</param>
        public AmazonInterconnectClient(AmazonInterconnectConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInterconnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonInterconnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInterconnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInterconnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Credentials and an
        /// AmazonInterconnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInterconnectClient Configuration Object</param>
        public AmazonInterconnectClient(AWSCredentials credentials, AmazonInterconnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInterconnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInterconnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInterconnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInterconnectClient Configuration Object</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInterconnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInterconnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInterconnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInterconnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInterconnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInterconnectClient Configuration Object</param>
        public AmazonInterconnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInterconnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IInterconnectPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IInterconnectPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new InterconnectPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInterconnectEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInterconnectAuthSchemeHandler());
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


        #region  AcceptConnectionProposal

        internal virtual AcceptConnectionProposalResponse AcceptConnectionProposal(AcceptConnectionProposalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionProposalResponseUnmarshaller.Instance;

            return Invoke<AcceptConnectionProposalResponse>(request, options);
        }



        /// <summary>
        /// Accepts a connection proposal which was generated at a supported partner's portal.
        /// 
        ///  
        /// <para>
        /// The proposal contains the Environment and bandwidth that were chosen on the partner's
        /// portal and cannot be modified.
        /// </para>
        ///  
        /// <para>
        /// Upon accepting the proposal a connection will be made between the AWS network as accessed
        /// via the selected Attach Point and the network previously selected network on the partner's
        /// portal.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptConnectionProposal service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/AcceptConnectionProposal">REST API Reference for AcceptConnectionProposal Operation</seealso>
        public virtual Task<AcceptConnectionProposalResponse> AcceptConnectionProposalAsync(AcceptConnectionProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptConnectionProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptConnectionProposalResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptConnectionProposalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConnection

        internal virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Initiates the process to create a Connection across the specified Environment. 
        /// 
        ///  
        /// <para>
        /// The Environment dictates the specified partner and location to which the other end
        /// of the connection should attach. You can see a list of the available Environments
        /// by calling <a>ListEnvironments</a> 
        /// </para>
        ///  
        /// <para>
        /// The Attach Point specifies where within the AWS Network your connection will logically
        /// connect.
        /// </para>
        ///  
        /// <para>
        /// After a successful call to this method, the resulting <a>Connection</a> will return
        /// an Activation Key which will need to be brought to the specific partner's portal to
        /// confirm the <a>Connection</a> on both sides. (See <a>Environment$activationPageUrl</a>
        /// for a direct link to the partner portal). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConnection

        internal virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing Connection with the supplied identifier.
        /// 
        ///  
        /// <para>
        /// This operation will also inform the remote partner of your intention to delete your
        /// connection. Note, the partner may still require you to delete to fully clean up resources,
        /// but the network connectivity provided by the <a>Connection</a> will cease to exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeConnectionProposal

        internal virtual DescribeConnectionProposalResponse DescribeConnectionProposal(DescribeConnectionProposalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionProposalResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionProposalResponse>(request, options);
        }



        /// <summary>
        /// Describes the details of a connection proposal generated at a partner's portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectionProposal service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/DescribeConnectionProposal">REST API Reference for DescribeConnectionProposal Operation</seealso>
        public virtual Task<DescribeConnectionProposalResponse> DescribeConnectionProposalAsync(DescribeConnectionProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionProposalResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionProposalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConnection

        internal virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }



        /// <summary>
        /// Describes the current state of a Connection resource as specified by the identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Describes a specific <a>Environment</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAttachPoints

        internal virtual ListAttachPointsResponse ListAttachPoints(ListAttachPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachPointsResponseUnmarshaller.Instance;

            return Invoke<ListAttachPointsResponse>(request, options);
        }



        /// <summary>
        /// Lists all Attach Points the caller has access to that are valid for the specified
        /// <a>Environment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachPoints service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListAttachPoints">REST API Reference for ListAttachPoints Operation</seealso>
        public virtual Task<ListAttachPointsResponse> ListAttachPointsAsync(ListAttachPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAttachPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachPointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConnections

        internal virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all connection objects to which the caller has access.
        /// 
        ///  
        /// <para>
        /// Allows for optional filtering by the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>state</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>environmentId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provider</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attach point</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only <a>Connection</a> objects matching all filters will be returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the environments that can produce connections that will land in the called
        /// AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all current tags on the specified resource. Currently this supports <a>Connection</a>
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Add new tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateConnection

        internal virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing connection. Currently we support modifications to the connection's
        /// description and/or bandwidth.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Interconnect.</returns>
        /// <exception cref="Amazon.Interconnect.Model.AccessDeniedException">
        /// The calling principal is not allowed to access the specified resource, or the resource
        /// does not exist.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectClientException">
        /// The request was denied due to incorrect client supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectServerException">
        /// The request resulted in an exception internal to the service.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.InterconnectValidationException">
        /// The input fails to satisfy the constraints specified.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ResourceNotFoundException">
        /// The request specifies a resource that does not exist on the server.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ServiceQuotaExceededException">
        /// The requested operation would result in the calling principal exceeding their allotted
        /// quota.
        /// </exception>
        /// <exception cref="Amazon.Interconnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/interconnect-2022-07-26/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}