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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.MarketplaceDeployment.Model;
using Amazon.MarketplaceDeployment.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceDeployment.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.MarketplaceDeployment
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceDeployment</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// The AWS Marketplace Deployment Service supports the Quick Launch experience, which
    /// is a deployment option for software as a service (SaaS) products. Quick Launch simplifies
    /// and reduces the time, resources, and steps required to configure, deploy, and launch
    /// a product. The AWS Marketplace Deployment Service provides sellers with a secure method
    /// for passing deployment parameters, such as API keys and external IDs, to buyers during
    /// the Quick Launch experience.
    /// 
    ///  
    /// <para>
    /// You can also use the AWS Marketplace Deployment Service to publish deployment configurations.
    /// A deployment configuration defines how buyers access a product's delivery option after
    /// they subscribe. For example, for the Data as a Service delivery option, it specifies
    /// the seller's fulfillment URL.
    /// </para>
    /// </summary>
    public partial class AmazonMarketplaceDeploymentClient : AmazonServiceClient, IAmazonMarketplaceDeployment
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceDeploymentMetadata();
        private IMarketplaceDeploymentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMarketplaceDeploymentPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new MarketplaceDeploymentPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with the credentials loaded from the application's
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
        public AmazonMarketplaceDeploymentClient() : base(new AmazonMarketplaceDeploymentConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with the credentials loaded from the application's
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
        public AmazonMarketplaceDeploymentClient(RegionEndpoint region) : base(new AmazonMarketplaceDeploymentConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceDeploymentClient Configuration Object</param>
        public AmazonMarketplaceDeploymentClient(AmazonMarketplaceDeploymentConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceDeploymentClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceDeploymentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDeploymentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceDeploymentConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Credentials and an
        /// AmazonMarketplaceDeploymentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceDeploymentClient Configuration Object</param>
        public AmazonMarketplaceDeploymentClient(AWSCredentials credentials, AmazonMarketplaceDeploymentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceDeploymentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceDeploymentConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceDeploymentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceDeploymentClient Configuration Object</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceDeploymentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceDeploymentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceDeploymentConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceDeploymentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceDeploymentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceDeploymentClient Configuration Object</param>
        public AmazonMarketplaceDeploymentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceDeploymentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceDeploymentEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceDeploymentAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the active deployment configuration for a product and delivery option. The
        /// active deployment configuration is the configuration from the most recent successful
        /// deployment configuration job. The seller that owns the product and buyers entitled
        /// to the product can call this operation.
        /// 
        ///  
        /// <para>
        /// If the product and delivery option have no active deployment configuration, the operation
        /// returns a <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfiguration service method.</param>
        /// <returns>The response from the GetDeploymentConfiguration service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/GetDeploymentConfiguration">REST API Reference for GetDeploymentConfiguration Operation</seealso>
        public virtual GetDeploymentConfigurationResponse GetDeploymentConfiguration(GetDeploymentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigurationResponse>(request, options);
        }
#else
        internal virtual GetDeploymentConfigurationResponse GetDeploymentConfiguration(GetDeploymentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the active deployment configuration for a product and delivery option. The
        /// active deployment configuration is the configuration from the most recent successful
        /// deployment configuration job. The seller that owns the product and buyers entitled
        /// to the product can call this operation.
        /// 
        ///  
        /// <para>
        /// If the product and delivery option have no active deployment configuration, the operation
        /// returns a <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDeploymentConfiguration service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/GetDeploymentConfiguration">REST API Reference for GetDeploymentConfiguration Operation</seealso>
        public virtual Task<GetDeploymentConfigurationResponse> GetDeploymentConfigurationAsync(GetDeploymentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns the details of a deployment configuration job. Only the seller that started
        /// the job can call this operation.
        /// 
        ///  
        /// <para>
        /// If the job doesn't belong to the product and delivery option in the request path,
        /// the operation returns a <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfigurationJob service method.</param>
        /// <returns>The response from the GetDeploymentConfigurationJob service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/GetDeploymentConfigurationJob">REST API Reference for GetDeploymentConfigurationJob Operation</seealso>
        public virtual GetDeploymentConfigurationJobResponse GetDeploymentConfigurationJob(GetDeploymentConfigurationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigurationJobResponse>(request, options);
        }
#else
        internal virtual GetDeploymentConfigurationJobResponse GetDeploymentConfigurationJob(GetDeploymentConfigurationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigurationJobResponse>(request, options);
        }
#endif

        /// <summary>
        /// Returns the details of a deployment configuration job. Only the seller that started
        /// the job can call this operation.
        /// 
        ///  
        /// <para>
        /// If the job doesn't belong to the product and delivery option in the request path,
        /// the operation returns a <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfigurationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDeploymentConfigurationJob service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/GetDeploymentConfigurationJob">REST API Reference for GetDeploymentConfigurationJob Operation</seealso>
        public virtual Task<GetDeploymentConfigurationJobResponse> GetDeploymentConfigurationJobAsync(GetDeploymentConfigurationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentConfigurationJobResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the deployment configuration jobs that you started for a product and delivery
        /// option, ordered from newest to oldest. Results are paginated. Use the <c>nextToken</c>
        /// parameter to retrieve additional results.
        /// 
        ///  
        /// <para>
        /// If you haven't started any jobs for the product and delivery option, the operation
        /// returns an empty <c>jobs</c> list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigurationJobs service method.</param>
        /// <returns>The response from the ListDeploymentConfigurationJobs service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/ListDeploymentConfigurationJobs">REST API Reference for ListDeploymentConfigurationJobs Operation</seealso>
        public virtual ListDeploymentConfigurationJobsResponse ListDeploymentConfigurationJobs(ListDeploymentConfigurationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentConfigurationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentConfigurationJobsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigurationJobsResponse>(request, options);
        }
#else
        internal virtual ListDeploymentConfigurationJobsResponse ListDeploymentConfigurationJobs(ListDeploymentConfigurationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentConfigurationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentConfigurationJobsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigurationJobsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the deployment configuration jobs that you started for a product and delivery
        /// option, ordered from newest to oldest. Results are paginated. Use the <c>nextToken</c>
        /// parameter to retrieve additional results.
        /// 
        ///  
        /// <para>
        /// If you haven't started any jobs for the product and delivery option, the operation
        /// returns an empty <c>jobs</c> list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigurationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDeploymentConfigurationJobs service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/ListDeploymentConfigurationJobs">REST API Reference for ListDeploymentConfigurationJobs Operation</seealso>
        public virtual Task<ListDeploymentConfigurationJobsResponse> ListDeploymentConfigurationJobsAsync(ListDeploymentConfigurationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentConfigurationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentConfigurationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentConfigurationJobsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists all tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists all tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates a deployment parameter and is targeted by <c>catalog</c> and <c>agreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeploymentParameter service method.</param>
        /// <returns>The response from the PutDeploymentParameter service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ServiceQuotaExceededException">
        /// The maximum number of requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/PutDeploymentParameter">REST API Reference for PutDeploymentParameter Operation</seealso>
        public virtual PutDeploymentParameterResponse PutDeploymentParameter(PutDeploymentParameterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDeploymentParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeploymentParameterResponseUnmarshaller.Instance;

            return Invoke<PutDeploymentParameterResponse>(request, options);
        }
#else
        internal virtual PutDeploymentParameterResponse PutDeploymentParameter(PutDeploymentParameterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDeploymentParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeploymentParameterResponseUnmarshaller.Instance;

            return Invoke<PutDeploymentParameterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates or updates a deployment parameter and is targeted by <c>catalog</c> and <c>agreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeploymentParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutDeploymentParameter service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ServiceQuotaExceededException">
        /// The maximum number of requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/PutDeploymentParameter">REST API Reference for PutDeploymentParameter Operation</seealso>
        public virtual Task<PutDeploymentParameterResponse> PutDeploymentParameterAsync(PutDeploymentParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDeploymentParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeploymentParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeploymentParameterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts a job that publishes a deployment configuration for a product and delivery
        /// option. The job runs asynchronously. Use <c>GetDeploymentConfigurationJob</c> to track
        /// its status. When the job reaches the <c>SUCCEEDED</c> status, its configuration becomes
        /// the active deployment configuration for the product and delivery option.
        /// 
        ///  
        /// <para>
        /// The populated member of <c>configuration</c> must match the <c>deliveryOptionType</c>
        /// in the request path.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeploymentConfigurationJob service method.</param>
        /// <returns>The response from the StartDeploymentConfigurationJob service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/StartDeploymentConfigurationJob">REST API Reference for StartDeploymentConfigurationJob Operation</seealso>
        public virtual StartDeploymentConfigurationJobResponse StartDeploymentConfigurationJob(StartDeploymentConfigurationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentConfigurationJobResponse>(request, options);
        }
#else
        internal virtual StartDeploymentConfigurationJobResponse StartDeploymentConfigurationJob(StartDeploymentConfigurationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentConfigurationJobResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts a job that publishes a deployment configuration for a product and delivery
        /// option. The job runs asynchronously. Use <c>GetDeploymentConfigurationJob</c> to track
        /// its status. When the job reaches the <c>SUCCEEDED</c> status, its configuration becomes
        /// the active deployment configuration for the product and delivery option.
        /// 
        ///  
        /// <para>
        /// The populated member of <c>configuration</c> must match the <c>deliveryOptionType</c>
        /// in the request path.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeploymentConfigurationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDeploymentConfigurationJob service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/StartDeploymentConfigurationJob">REST API Reference for StartDeploymentConfigurationJob Operation</seealso>
        public virtual Task<StartDeploymentConfigurationJobResponse> StartDeploymentConfigurationJobAsync(StartDeploymentConfigurationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDeploymentConfigurationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentConfigurationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDeploymentConfigurationJobResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
    }
}
