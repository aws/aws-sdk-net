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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MWAA.Model;
using Amazon.MWAA.Model.Internal.MarshallTransformations;
using Amazon.MWAA.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MWAA
{
    /// <summary>
    /// Implementation for accessing MWAA
    ///
    /// Amazon Managed Workflows for Apache Airflow 
    /// <para>
    /// This section contains the Amazon Managed Workflows for Apache Airflow (MWAA) API reference
    /// documentation. For more information, see <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/what-is-mwaa.html">What
    /// Is Amazon MWAA?</a>.
    /// 
    /// 
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonMWAAClient : AmazonServiceClient, IAmazonMWAA
    {
        private static IServiceMetadata serviceMetadata = new AmazonMWAAMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        public AmazonMWAAClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMWAAConfig()) { }

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        public AmazonMWAAClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMWAAConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMWAAClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(AmazonMWAAConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMWAAClient(AWSCredentials credentials)
            : this(credentials, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMWAAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Credentials and an
        /// AmazonMWAAClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(AWSCredentials credentials, AmazonMWAAConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMWAAConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMWAAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMWAAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMWAAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMWAAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMWAAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMWAAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMWAAClient Configuration Object</param>
        public AmazonMWAAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMWAAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMWAAPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMWAAPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MWAAPaginatorFactory(this);
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


        #region  CreateCliToken

        internal virtual CreateCliTokenResponse CreateCliToken(CreateCliTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCliTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCliTokenResponseUnmarshaller.Instance;

            return Invoke<CreateCliTokenResponse>(request, options);
        }



        /// <summary>
        /// Create a CLI token to use Airflow CLI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCliToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCliToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateCliToken">REST API Reference for CreateCliToken Operation</seealso>
        public virtual Task<CreateCliTokenResponse> CreateCliTokenAsync(CreateCliTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCliTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCliTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCliTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// JSON blob that describes the environment to create.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebLoginToken

        internal virtual CreateWebLoginTokenResponse CreateWebLoginToken(CreateWebLoginTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebLoginTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebLoginTokenResponseUnmarshaller.Instance;

            return Invoke<CreateWebLoginTokenResponse>(request, options);
        }



        /// <summary>
        /// Create a JWT token to be used to login to Airflow Web UI with claims based Authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebLoginToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebLoginToken service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.AccessDeniedException">
        /// Access to the Airflow Web UI or CLI has been Denied. Please follow the MWAA user guide
        /// to setup permissions to access the Web UI and CLI functionality.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/CreateWebLoginToken">REST API Reference for CreateWebLoginToken Operation</seealso>
        public virtual Task<CreateWebLoginTokenResponse> CreateWebLoginTokenAsync(CreateWebLoginTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebLoginTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebLoginTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWebLoginTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Delete an existing environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Get details of an existing environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// List Amazon MWAA Environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
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
        /// List the tags for MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishMetrics

        internal virtual PublishMetricsResponse PublishMetrics(PublishMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishMetricsResponseUnmarshaller.Instance;

            return Invoke<PublishMetricsResponse>(request, options);
        }



        /// <summary>
        /// An operation for publishing metrics from the customers to the Ops plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishMetrics service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/PublishMetrics">REST API Reference for PublishMetrics Operation</seealso>
        public virtual Task<PublishMetricsResponse> PublishMetricsAsync(PublishMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<PublishMetricsResponse>(request, options, cancellationToken);
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
        /// Add tag to the MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove a tag from the MWAA environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Update an MWAA environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MWAA.</returns>
        /// <exception cref="Amazon.MWAA.Model.InternalServerException">
        /// InternalServerException: An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ResourceNotFoundException">
        /// ResourceNotFoundException: The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MWAA.Model.ValidationException">
        /// ValidationException: The provided input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-2020-07-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}