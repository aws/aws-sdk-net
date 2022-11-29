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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.OpenSearchServerless.Model;
using Amazon.OpenSearchServerless.Model.Internal.MarshallTransformations;
using Amazon.OpenSearchServerless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OpenSearchServerless
{
    /// <summary>
    /// Implementation for accessing OpenSearchServerless
    ///
    /// Use the Amazon OpenSearch Serverless API to create, configure, and manage OpenSearch
    /// Serverless collections and security policies.
    /// 
    ///  
    /// <para>
    /// OpenSearch Serverless is an on-demand, pre-provisioned serverless configuration for
    /// Amazon OpenSearch Service. OpenSearch Serverless removes the operational complexities
    /// of provisioning, configuring, and tuning your OpenSearch clusters. It enables you
    /// to easily search and analyze petabytes of data without having to worry about the underlying
    /// infrastructure and data management.
    /// </para>
    ///  
    /// <para>
    ///  To learn more about OpenSearch Serverless, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html">What
    /// is Amazon OpenSearch Serverless?</a> 
    /// </para>
    /// </summary>
    public partial class AmazonOpenSearchServerlessClient : AmazonServiceClient, IAmazonOpenSearchServerless
    {
        private static IServiceMetadata serviceMetadata = new AmazonOpenSearchServerlessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServerlessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServerlessConfig()) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServerlessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServerlessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(AmazonOpenSearchServerlessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpenSearchServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials and an
        /// AmazonOpenSearchServerlessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials, AmazonOpenSearchServerlessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServerlessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpenSearchServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpenSearchServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IOpenSearchServerlessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOpenSearchServerlessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OpenSearchServerlessPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOpenSearchServerlessEndpointResolver());
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


        #region  BatchGetCollection

        internal virtual BatchGetCollectionResponse BatchGetCollection(BatchGetCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollectionResponseUnmarshaller.Instance;

            return Invoke<BatchGetCollectionResponse>(request, options);
        }



        /// <summary>
        /// Returns attributes for one or more collections, including the collection endpoint
        /// and the OpenSearch Dashboards endpoint. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetCollection">REST API Reference for BatchGetCollection Operation</seealso>
        public virtual Task<BatchGetCollectionResponse> BatchGetCollectionAsync(BatchGetCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetVpcEndpoint

        internal virtual BatchGetVpcEndpointResponse BatchGetVpcEndpoint(BatchGetVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<BatchGetVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Returns attributes for one or more VPC endpoints associated with the current account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetVpcEndpoint">REST API Reference for BatchGetVpcEndpoint Operation</seealso>
        public virtual Task<BatchGetVpcEndpointResponse> BatchGetVpcEndpointAsync(BatchGetVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessPolicy

        internal virtual CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a data access policy for OpenSearch Serverless. Access policies limit access
        /// to collections and the resources within them, and allow a user to access that data
        /// irrespective of the access mechanism or network source. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual Task<CreateAccessPolicyResponse> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCollection

        internal virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual Task<CreateCollectionResponse> CreateCollectionAsync(CreateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityConfig

        internal virtual CreateSecurityConfigResponse CreateSecurityConfig(CreateSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigResponse>(request, options);
        }



        /// <summary>
        /// Specifies a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityConfig">REST API Reference for CreateSecurityConfig Operation</seealso>
        public virtual Task<CreateSecurityConfigResponse> CreateSecurityConfigAsync(CreateSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityPolicy

        internal virtual CreateSecurityPolicyResponse CreateSecurityPolicy(CreateSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a security policy to be used by one or more OpenSearch Serverless collections.
        /// Security policies provide access to a collection and its OpenSearch Dashboards endpoint
        /// from public networks or specific VPC endpoints. They also allow you to secure a collection
        /// with a KMS encryption key. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityPolicy">REST API Reference for CreateSecurityPolicy Operation</seealso>
        public virtual Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates an OpenSearch Serverless-managed interface VPC endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPolicy

        internal virtual DeleteAccessPolicyResponse DeleteAccessPolicy(DeleteAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual Task<DeleteAccessPolicyResponse> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCollection

        internal virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual Task<DeleteCollectionResponse> DeleteCollectionAsync(DeleteCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityConfig

        internal virtual DeleteSecurityConfigResponse DeleteSecurityConfig(DeleteSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityConfig">REST API Reference for DeleteSecurityConfig Operation</seealso>
        public virtual Task<DeleteSecurityConfigResponse> DeleteSecurityConfigAsync(DeleteSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityPolicy

        internal virtual DeleteSecurityPolicyResponse DeleteSecurityPolicy(DeleteSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an OpenSearch Serverless security policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityPolicy">REST API Reference for DeleteSecurityPolicy Operation</seealso>
        public virtual Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsync(DeleteSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoint

        internal virtual DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPolicy

        internal virtual GetAccessPolicyResponse GetAccessPolicy(GetAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccessPolicy">REST API Reference for GetAccessPolicy Operation</seealso>
        public virtual Task<GetAccessPolicyResponse> GetAccessPolicyAsync(GetAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Returns account-level settings related to OpenSearch Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPoliciesStats

        internal virtual GetPoliciesStatsResponse GetPoliciesStats(GetPoliciesStatsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPoliciesStatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPoliciesStatsResponseUnmarshaller.Instance;

            return Invoke<GetPoliciesStatsResponse>(request, options);
        }



        /// <summary>
        /// Returns statistical information about your OpenSearch Serverless access policies,
        /// security configurations, and security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPoliciesStats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPoliciesStats service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetPoliciesStats">REST API Reference for GetPoliciesStats Operation</seealso>
        public virtual Task<GetPoliciesStatsResponse> GetPoliciesStatsAsync(GetPoliciesStatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPoliciesStatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPoliciesStatsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPoliciesStatsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecurityConfig

        internal virtual GetSecurityConfigResponse GetSecurityConfig(GetSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an OpenSearch Serverless security configuration. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityConfig">REST API Reference for GetSecurityConfig Operation</seealso>
        public virtual Task<GetSecurityConfigResponse> GetSecurityConfigAsync(GetSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecurityPolicy

        internal virtual GetSecurityPolicyResponse GetSecurityPolicy(GetSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<GetSecurityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a configured OpenSearch Serverless security policy. For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityPolicy">REST API Reference for GetSecurityPolicy Operation</seealso>
        public virtual Task<GetSecurityPolicyResponse> GetSecurityPolicyAsync(GetSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessPolicies

        internal virtual ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAccessPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of OpenSearch Serverless access policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual Task<ListAccessPoliciesResponse> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCollections

        internal virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all OpenSearch Serverless collections. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Make sure to include an empty request body {} if you don't include any collection
        /// filters in the request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityConfigs

        internal virtual ListSecurityConfigsResponse ListSecurityConfigs(ListSecurityConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about configured OpenSearch Serverless security configurations.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityConfigs service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityConfigs">REST API Reference for ListSecurityConfigs Operation</seealso>
        public virtual Task<ListSecurityConfigsResponse> ListSecurityConfigsAsync(ListSecurityConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecurityPolicies

        internal virtual ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about configured OpenSearch Serverless security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityPoliciesResponse>(request, options, cancellationToken);
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
        /// Returns the tags for an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVpcEndpoints

        internal virtual ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns the OpenSearch Serverless-managed interface VPC endpoints associated with
        /// the current account. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcEndpointsResponse>(request, options, cancellationToken);
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
        /// Associates tags with an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag or set of tags from an OpenSearch Serverless resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccessPolicy

        internal virtual UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual Task<UpdateAccessPolicyResponse> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountSettings

        internal virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Update the OpenSearch Serverless settings for the current Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html#serverless-scaling">Autoscaling</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCollection

        internal virtual UpdateCollectionResponse UpdateCollection(UpdateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectionResponseUnmarshaller.Instance;

            return Invoke<UpdateCollectionResponse>(request, options);
        }



        /// <summary>
        /// Updates an OpenSearch Serverless collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateCollection">REST API Reference for UpdateCollection Operation</seealso>
        public virtual Task<UpdateCollectionResponse> UpdateCollectionAsync(UpdateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityConfig

        internal virtual UpdateSecurityConfigResponse UpdateSecurityConfig(UpdateSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityConfig">REST API Reference for UpdateSecurityConfig Operation</seealso>
        public virtual Task<UpdateSecurityConfigResponse> UpdateSecurityConfigAsync(UpdateSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityPolicy

        internal virtual UpdateSecurityPolicyResponse UpdateSecurityPolicy(UpdateSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates an OpenSearch Serverless security policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityPolicy">REST API Reference for UpdateSecurityPolicy Operation</seealso>
        public virtual Task<UpdateSecurityPolicyResponse> UpdateSecurityPolicyAsync(UpdateSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcEndpoint

        internal virtual UpdateVpcEndpointResponse UpdateVpcEndpoint(UpdateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcEndpointResponse>(request, options);
        }



        /// <summary>
        /// Updates an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual Task<UpdateVpcEndpointResponse> UpdateVpcEndpointAsync(UpdateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}