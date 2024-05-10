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
 * Do not modify this file. This file is generated from the marketplace-deployment-2023-01-25.normal.json service model.
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

#pragma warning disable CS1570
namespace Amazon.MarketplaceDeployment
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceDeployment</para>
    ///
    /// The AWS Marketplace Deployment Service supports the Quick Launch experience, which
    /// is a deployment option for software as a service (SaaS) products. Quick Launch simplifies
    /// and reduces the time, resources, and steps required to configure, deploy, and launch
    /// a products. The AWS Marketplace Deployment Service provides sellers with a secure
    /// method for passing deployment parameters (for example, API keys and external IDs)
    /// to buyers during the Quick Launch experience.
    /// </summary>
    public partial class AmazonMarketplaceDeploymentClient : AmazonServiceClient, IAmazonMarketplaceDeployment
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceDeploymentMetadata();
        
        #region Constructors

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
        public AmazonMarketplaceDeploymentClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceDeploymentConfig()) { }

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
        public AmazonMarketplaceDeploymentClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceDeploymentConfig{RegionEndpoint = region}) { }

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
        public AmazonMarketplaceDeploymentClient(AmazonMarketplaceDeploymentConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


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
            : this(credentials, new AmazonMarketplaceDeploymentConfig{RegionEndpoint = region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceDeploymentConfig() {RegionEndpoint=region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceDeploymentConfig{RegionEndpoint = region})
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceDeploymentEndpointResolver());
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


        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags that have been added to a deployment parameter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDeploymentParameter

        internal virtual PutDeploymentParameterResponse PutDeploymentParameter(PutDeploymentParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeploymentParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeploymentParameterResponseUnmarshaller.Instance;

            return Invoke<PutDeploymentParameterResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a deployment parameter and is targeted by <c>catalog</c> and <c>agreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeploymentParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeploymentParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeploymentParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutDeploymentParameterResponse>(request, options, cancellationToken);
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
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonMarketplaceDeploymentEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}