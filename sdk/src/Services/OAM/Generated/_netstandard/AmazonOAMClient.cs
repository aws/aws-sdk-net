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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.OAM.Model;
using Amazon.OAM.Model.Internal.MarshallTransformations;
using Amazon.OAM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OAM
{
    /// <summary>
    /// Implementation for accessing OAM
    ///
    /// Use Amazon CloudWatch Observability Access Manager to create and manage links between
    /// source accounts and monitoring accounts by using <i>CloudWatch cross-account observability</i>.
    /// With CloudWatch cross-account observability, you can monitor and troubleshoot applications
    /// that span multiple accounts within a Region. Seamlessly search, visualize, and analyze
    /// your metrics, logs, and traces in any of the linked accounts without account boundaries.
    /// 
    ///  <pre><code> &lt;p&gt;Set up one or more Amazon Web Services accounts as &lt;i&gt;monitoring
    /// accounts&lt;/i&gt; and link them with multiple &lt;i&gt;source accounts&lt;/i&gt;.
    /// A monitoring account is a central Amazon Web Services account that can view and interact
    /// with observability data generated from source accounts. A source account is an individual
    /// Amazon Web Services account that generates observability data for the resources that
    /// reside in it. Source accounts share their observability data with the monitoring account.
    /// The shared observability data can include metrics in Amazon CloudWatch, logs in Amazon
    /// CloudWatch Logs, and traces in X-Ray.&lt;/p&gt; </code></pre>
    /// </summary>
    public partial class AmazonOAMClient : AmazonServiceClient, IAmazonOAM
    {
        private static IServiceMetadata serviceMetadata = new AmazonOAMMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonOAMClient with the credentials loaded from the application's
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
        public AmazonOAMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOAMConfig()) { }

        /// <summary>
        /// Constructs AmazonOAMClient with the credentials loaded from the application's
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
        public AmazonOAMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOAMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOAMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOAMClient Configuration Object</param>
        public AmazonOAMClient(AmazonOAMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonOAMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOAMClient(AWSCredentials credentials)
            : this(credentials, new AmazonOAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOAMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOAMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Credentials and an
        /// AmazonOAMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOAMClient Configuration Object</param>
        public AmazonOAMClient(AWSCredentials credentials, AmazonOAMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOAMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOAMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOAMClient Configuration Object</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOAMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOAMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOAMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOAMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOAMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOAMClient Configuration Object</param>
        public AmazonOAMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOAMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IOAMPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOAMPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OAMPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOAMEndpointResolver());
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


        #region  CreateLink

        internal virtual CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return Invoke<CreateLinkResponse>(request, options);
        }



        /// <summary>
        /// Creates a link between a source account and a sink that you have created in a monitoring
        /// account.
        /// 
        ///  
        /// <para>
        /// Before you create a link, you must create a sink in the monitoring account and create
        /// a sink policy in that account. The sink policy must permit the source account to link
        /// to it. You can grant permission to source accounts by granting permission to an entire
        /// organization or to individual accounts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_CreateSink.html">CreateSink</a>
        /// and <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_PutSinkPolicy.html">PutSinkPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Each monitoring account can be linked to as many as 100,000 source accounts.
        /// </para>
        ///  
        /// <para>
        /// Each source account can be linked to as many as five monitoring accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSink

        internal virtual CreateSinkResponse CreateSink(CreateSinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSinkResponseUnmarshaller.Instance;

            return Invoke<CreateSinkResponse>(request, options);
        }



        /// <summary>
        /// Use this to create a <i>sink</i> in the current account, so that it can be used as
        /// a monitoring account in CloudWatch cross-account observability. A sink is a resource
        /// that represents an attachment point in a monitoring account. Source accounts can link
        /// to the sink to send observability data.
        /// 
        ///  
        /// <para>
        /// After you create a sink, you must create a sink policy that allows source accounts
        /// to attach to it. For more information, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_PutSinkPolicy.html">PutSinkPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// Each account can contain one sink. If you delete a sink, you can then create a new
        /// one in that account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/CreateSink">REST API Reference for CreateSink Operation</seealso>
        public virtual Task<CreateSinkResponse> CreateSinkAsync(CreateSinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSinkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLink

        internal virtual DeleteLinkResponse DeleteLink(DeleteLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteLinkResponse>(request, options);
        }



        /// <summary>
        /// Deletes a link between a monitoring account sink and a source account. You must run
        /// this operation in the source account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual Task<DeleteLinkResponse> DeleteLinkAsync(DeleteLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSink

        internal virtual DeleteSinkResponse DeleteSink(DeleteSinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSinkResponseUnmarshaller.Instance;

            return Invoke<DeleteSinkResponse>(request, options);
        }



        /// <summary>
        /// Deletes a sink. You must delete all links to a sink before you can delete that sink.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/DeleteSink">REST API Reference for DeleteSink Operation</seealso>
        public virtual Task<DeleteSinkResponse> DeleteSinkAsync(DeleteSinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSinkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLink

        internal virtual GetLinkResponse GetLink(GetLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkResponseUnmarshaller.Instance;

            return Invoke<GetLinkResponse>(request, options);
        }



        /// <summary>
        /// Returns complete information about one link.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the link ARN. To retrieve a list of link ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetLink">REST API Reference for GetLink Operation</seealso>
        public virtual Task<GetLinkResponse> GetLinkAsync(GetLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSink

        internal virtual GetSinkResponse GetSink(GetSinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSinkResponseUnmarshaller.Instance;

            return Invoke<GetSinkResponse>(request, options);
        }



        /// <summary>
        /// Returns complete information about one monitoring account sink.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSink">REST API Reference for GetSink Operation</seealso>
        public virtual Task<GetSinkResponse> GetSinkAsync(GetSinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSinkResponseUnmarshaller.Instance;

            return InvokeAsync<GetSinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSinkPolicy

        internal virtual GetSinkPolicyResponse GetSinkPolicy(GetSinkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSinkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSinkPolicyResponseUnmarshaller.Instance;

            return Invoke<GetSinkPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the current sink policy attached to this sink. The sink policy specifies what
        /// accounts can attach to this sink as source accounts, and what types of data they can
        /// share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSinkPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSinkPolicy service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/GetSinkPolicy">REST API Reference for GetSinkPolicy Operation</seealso>
        public virtual Task<GetSinkPolicyResponse> GetSinkPolicyAsync(GetSinkPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSinkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSinkPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetSinkPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachedLinks

        internal virtual ListAttachedLinksResponse ListAttachedLinks(ListAttachedLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedLinksResponseUnmarshaller.Instance;

            return Invoke<ListAttachedLinksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of source account links that are linked to this monitoring account
        /// sink.
        /// 
        ///  
        /// <para>
        /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
        /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
        /// </para>
        ///  
        /// <para>
        /// To find a list of links for one source account, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachedLinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListAttachedLinks">REST API Reference for ListAttachedLinks Operation</seealso>
        public virtual Task<ListAttachedLinksResponse> ListAttachedLinksAsync(ListAttachedLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachedLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachedLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachedLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLinks

        internal virtual ListLinksResponse ListLinks(ListLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinksResponseUnmarshaller.Instance;

            return Invoke<ListLinksResponse>(request, options);
        }



        /// <summary>
        /// Use this operation in a source account to return a list of links to monitoring account
        /// sinks that this source account has.
        /// 
        ///  
        /// <para>
        /// To find a list of links for one monitoring account sink, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListAttachedLinks.html">ListAttachedLinks</a>
        /// from within the monitoring account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListLinks">REST API Reference for ListLinks Operation</seealso>
        public virtual Task<ListLinksResponse> ListLinksAsync(ListLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSinks

        internal virtual ListSinksResponse ListSinks(ListSinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSinksResponseUnmarshaller.Instance;

            return Invoke<ListSinksResponse>(request, options);
        }



        /// <summary>
        /// Use this operation in a monitoring account to return the list of sinks created in
        /// that account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSinks service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListSinks">REST API Reference for ListSinks Operation</seealso>
        public virtual Task<ListSinksResponse> ListSinksAsync(ListSinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSinksResponseUnmarshaller.Instance;

            return InvokeAsync<ListSinksResponse>(request, options, cancellationToken);
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
        /// Displays the tags associated with a resource. Both sinks and links support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSinkPolicy

        internal virtual PutSinkPolicyResponse PutSinkPolicy(PutSinkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSinkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSinkPolicyResponseUnmarshaller.Instance;

            return Invoke<PutSinkPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates the resource policy that grants permissions to source accounts
        /// to link to the monitoring account sink. When you create a sink policy, you can grant
        /// permissions to all accounts in an organization or to individual accounts.
        /// 
        ///  
        /// <para>
        /// You can also use a sink policy to limit the types of data that is shared. The three
        /// types that you can allow or deny are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Metrics</b> - Specify with <code>AWS::CloudWatch::Metric</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Log groups</b> - Specify with <code>AWS::Logs::LogGroup</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Traces</b> - Specify with <code>AWS::XRay::Trace</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See the examples in this section to see how to specify permitted source accounts and
        /// data types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSinkPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSinkPolicy service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/PutSinkPolicy">REST API Reference for PutSinkPolicy Operation</seealso>
        public virtual Task<PutSinkPolicyResponse> PutSinkPolicyAsync(PutSinkPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSinkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSinkPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutSinkPolicyResponse>(request, options, cancellationToken);
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
        /// Assigns one or more tags (key-value pairs) to the specified resource. Both sinks and
        /// links can be tagged. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  <important> 
        /// <para>
        /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
        /// links and sinks you must have the <code>oam:ResourceTag</code> permission. The <code>iam:ResourceTag</code>
        /// permission does not allow you to tag and untag links and sinks.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.TooManyTagsException">
        /// A resource can have no more than 50 tags.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// 
        ///  <important> 
        /// <para>
        /// Unlike tagging permissions in other Amazon Web Services services, to tag or untag
        /// links and sinks you must have the <code>oam:ResourceTag</code> permission. The <code>iam:TagResource</code>
        /// permission does not allow you to tag and untag links and sinks.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLink

        internal virtual UpdateLinkResponse UpdateLink(UpdateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to change what types of data are shared from a source account to
        /// its linked monitoring account sink. You can't change the sink or change the monitoring
        /// account with this operation.
        /// 
        ///  
        /// <para>
        /// To update the list of tags associated with the sink, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by OAM.</returns>
        /// <exception cref="Amazon.OAM.Model.InternalServiceException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.MissingRequiredParameterException">
        /// A required parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.OAM.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/oam-2022-06-10/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}