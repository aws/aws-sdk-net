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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ManagedGrafana.Model;
using Amazon.ManagedGrafana.Model.Internal.MarshallTransformations;
using Amazon.ManagedGrafana.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ManagedGrafana
{
    /// <summary>
    /// Implementation for accessing ManagedGrafana
    ///
    /// Amazon Managed Grafana is a fully managed and secure data visualization service that
    /// you can use to instantly query, correlate, and visualize operational metrics, logs,
    /// and traces from multiple sources. Amazon Managed Grafana makes it easy to deploy,
    /// operate, and scale Grafana, a widely deployed data visualization tool that is popular
    /// for its extensible data support.
    /// 
    ///  
    /// <para>
    /// With Amazon Managed Grafana, you create logically isolated Grafana servers called
    /// <i>workspaces</i>. In a workspace, you can create Grafana dashboards and visualizations
    /// to analyze your metrics, logs, and traces without having to build, package, or deploy
    /// any hardware to run Grafana servers. 
    /// </para>
    /// </summary>
    public partial class AmazonManagedGrafanaClient : AmazonServiceClient, IAmazonManagedGrafana
    {
        private static IServiceMetadata serviceMetadata = new AmazonManagedGrafanaMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with the credentials loaded from the application's
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
        public AmazonManagedGrafanaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonManagedGrafanaConfig()) { }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with the credentials loaded from the application's
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
        public AmazonManagedGrafanaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonManagedGrafanaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonManagedGrafanaClient Configuration Object</param>
        public AmazonManagedGrafanaClient(AmazonManagedGrafanaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonManagedGrafanaClient(AWSCredentials credentials)
            : this(credentials, new AmazonManagedGrafanaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedGrafanaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonManagedGrafanaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Credentials and an
        /// AmazonManagedGrafanaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonManagedGrafanaClient Configuration Object</param>
        public AmazonManagedGrafanaClient(AWSCredentials credentials, AmazonManagedGrafanaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonManagedGrafanaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonManagedGrafanaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonManagedGrafanaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonManagedGrafanaClient Configuration Object</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonManagedGrafanaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonManagedGrafanaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonManagedGrafanaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonManagedGrafanaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonManagedGrafanaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonManagedGrafanaClient Configuration Object</param>
        public AmazonManagedGrafanaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonManagedGrafanaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IManagedGrafanaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IManagedGrafanaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ManagedGrafanaPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonManagedGrafanaEndpointResolver());
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


        #region  AssociateLicense

        internal virtual AssociateLicenseResponse AssociateLicense(AssociateLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLicenseResponseUnmarshaller.Instance;

            return Invoke<AssociateLicenseResponse>(request, options);
        }



        /// <summary>
        /// Assigns a Grafana Enterprise license to a workspace. Upgrading to Grafana Enterprise
        /// incurs additional fees. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html">Upgrade
        /// a workspace to Grafana Enterprise</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        public virtual Task<AssociateLicenseResponse> AssociateLicenseAsync(AssociateLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspace

        internal virtual CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a <i>workspace</i>. In a workspace, you can create Grafana dashboards and
        /// visualizations to analyze your metrics, logs, and traces. You don't have to build,
        /// package, or deploy any hardware to run the Grafana server.
        /// 
        ///  
        /// <para>
        /// Don't use <code>CreateWorkspace</code> to modify an existing workspace. Instead, use
        /// <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspace.html">UpdateWorkspace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspaceApiKey

        internal virtual CreateWorkspaceApiKeyResponse CreateWorkspaceApiKey(CreateWorkspaceApiKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceApiKeyResponse>(request, options);
        }



        /// <summary>
        /// Creates a Grafana API key for the workspace. This key can be used to authenticate
        /// requests sent to the workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
        /// for available APIs and example requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        public virtual Task<CreateWorkspaceApiKeyResponse> CreateWorkspaceApiKeyAsync(CreateWorkspaceApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspaceApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspace

        internal virtual DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspaceApiKey

        internal virtual DeleteWorkspaceApiKeyResponse DeleteWorkspaceApiKey(DeleteWorkspaceApiKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceApiKeyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Grafana API key for the workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        public virtual Task<DeleteWorkspaceApiKeyResponse> DeleteWorkspaceApiKeyAsync(DeleteWorkspaceApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkspaceApiKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspace

        internal virtual DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Displays information about one Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        public virtual Task<DescribeWorkspaceResponse> DescribeWorkspaceAsync(DescribeWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceAuthentication

        internal virtual DescribeWorkspaceAuthenticationResponse DescribeWorkspaceAuthentication(DescribeWorkspaceAuthenticationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceAuthenticationResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceAuthenticationResponse>(request, options);
        }



        /// <summary>
        /// Displays information about the authentication methods used in one Amazon Managed Grafana
        /// workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        public virtual Task<DescribeWorkspaceAuthenticationResponse> DescribeWorkspaceAuthenticationAsync(DescribeWorkspaceAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceAuthenticationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceAuthenticationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceConfiguration

        internal virtual DescribeWorkspaceConfigurationResponse DescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the current configuration string for the given workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        public virtual Task<DescribeWorkspaceConfigurationResponse> DescribeWorkspaceConfigurationAsync(DescribeWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateLicense

        internal virtual DisassociateLicenseResponse DisassociateLicense(DisassociateLicenseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLicenseResponseUnmarshaller.Instance;

            return Invoke<DisassociateLicenseResponse>(request, options);
        }



        /// <summary>
        /// Removes the Grafana Enterprise license from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        public virtual Task<DisassociateLicenseResponse> DisassociateLicenseAsync(DisassociateLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLicenseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLicenseResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateLicenseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPermissions

        internal virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the users and groups who have the Grafana <code>Admin</code> and <code>Editor</code>
        /// roles in this workspace. If you use this operation without specifying <code>userId</code>
        /// or <code>groupId</code>, the operation returns the roles of all users and groups.
        /// If you specify a <code>userId</code> or a <code>groupId</code>, only the roles for
        /// that user or group are returned. If you do this, you can specify only one <code>userId</code>
        /// or one <code>groupId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPermissionsResponse>(request, options, cancellationToken);
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
        /// The <code>ListTagsForResource</code> operation returns the tags that are associated
        /// with the Amazon Managed Service for Grafana resource specified by the <code>resourceArn</code>.
        /// Currently, the only resource that can be tagged is a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkspaces

        internal virtual ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Amazon Managed Grafana workspaces in the account, with some information
        /// about each workspace. For more complete information about one workspace, use <a href="https://docs.aws.amazon.com/AAMG/latest/APIReference/API_DescribeWorkspace.html">DescribeWorkspace</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkspacesResponse>(request, options, cancellationToken);
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
        /// The <code>TagResource</code> operation associates tags with an Amazon Managed Grafana
        /// resource. Currently, the only resource that can be tagged is workspaces. 
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// The <code>UntagResource</code> operation removes the association of the tag with the
        /// Amazon Managed Grafana resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePermissions

        internal virtual UpdatePermissionsResponse UpdatePermissions(UpdatePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdatePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates which users in a workspace have the Grafana <code>Admin</code> or <code>Editor</code>
        /// roles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        public virtual Task<UpdatePermissionsResponse> UpdatePermissionsAsync(UpdatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspace

        internal virtual UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing Amazon Managed Grafana workspace. If you use this operation and
        /// omit any optional parameters, the existing values of those parameters are not changed.
        /// 
        ///  
        /// <para>
        /// To modify the user authentication methods that the workspace uses, such as SAML or
        /// IAM Identity Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
        /// </para>
        ///  
        /// <para>
        /// To modify which users in the workspace have the <code>Admin</code> and <code>Editor</code>
        /// Grafana roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        public virtual Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspaceAuthentication

        internal virtual UpdateWorkspaceAuthenticationResponse UpdateWorkspaceAuthentication(UpdateWorkspaceAuthenticationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAuthenticationResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceAuthenticationResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to define the identity provider (IdP) that this workspace authenticates
        /// users from, using SAML. You can also map SAML assertion attributes to workspace user
        /// information and define which groups in the assertion attribute are to have the <code>Admin</code>
        /// and <code>Editor</code> roles in the workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        public virtual Task<UpdateWorkspaceAuthenticationResponse> UpdateWorkspaceAuthenticationAsync(UpdateWorkspaceAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAuthenticationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAuthenticationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceAuthenticationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspaceConfiguration

        internal virtual UpdateWorkspaceConfigurationResponse UpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration string for the given workspace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        public virtual Task<UpdateWorkspaceConfigurationResponse> UpdateWorkspaceConfigurationAsync(UpdateWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}