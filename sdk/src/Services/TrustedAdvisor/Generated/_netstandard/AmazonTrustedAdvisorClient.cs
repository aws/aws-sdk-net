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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TrustedAdvisor.Model;
using Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations;
using Amazon.TrustedAdvisor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.TrustedAdvisor
{
    /// <summary>
    /// <para>Implementation for accessing TrustedAdvisor</para>
    ///
    /// TrustedAdvisor Public API
    /// </summary>
    public partial class AmazonTrustedAdvisorClient : AmazonServiceClient, IAmazonTrustedAdvisor
    {
        private static IServiceMetadata serviceMetadata = new AmazonTrustedAdvisorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        public AmazonTrustedAdvisorClient()
            : base(new AmazonTrustedAdvisorConfig()) { }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        public AmazonTrustedAdvisorClient(RegionEndpoint region)
            : base(new AmazonTrustedAdvisorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(AmazonTrustedAdvisorConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials)
            : this(credentials, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTrustedAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Credentials and an
        /// AmazonTrustedAdvisorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(AWSCredentials credentials, AmazonTrustedAdvisorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTrustedAdvisorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTrustedAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTrustedAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTrustedAdvisorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTrustedAdvisorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTrustedAdvisorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTrustedAdvisorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTrustedAdvisorClient Configuration Object</param>
        public AmazonTrustedAdvisorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTrustedAdvisorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ITrustedAdvisorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITrustedAdvisorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TrustedAdvisorPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTrustedAdvisorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTrustedAdvisorAuthSchemeHandler());
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


        #region  BatchUpdateRecommendationResourceExclusion

        internal virtual BatchUpdateRecommendationResourceExclusionResponse BatchUpdateRecommendationResourceExclusion(BatchUpdateRecommendationResourceExclusionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateRecommendationResourceExclusionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRecommendationResourceExclusionResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateRecommendationResourceExclusionResponse>(request, options);
        }



        /// <summary>
        /// Update one or more exclusion status for a list of recommendation resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateRecommendationResourceExclusion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateRecommendationResourceExclusion service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/BatchUpdateRecommendationResourceExclusion">REST API Reference for BatchUpdateRecommendationResourceExclusion Operation</seealso>
        public virtual Task<BatchUpdateRecommendationResourceExclusionResponse> BatchUpdateRecommendationResourceExclusionAsync(BatchUpdateRecommendationResourceExclusionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateRecommendationResourceExclusionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateRecommendationResourceExclusionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateRecommendationResourceExclusionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOrganizationRecommendation

        internal virtual GetOrganizationRecommendationResponse GetOrganizationRecommendation(GetOrganizationRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Get a specific recommendation within an AWS Organizations organization. This API supports
        /// only prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetOrganizationRecommendation">REST API Reference for GetOrganizationRecommendation Operation</seealso>
        public virtual Task<GetOrganizationRecommendationResponse> GetOrganizationRecommendationAsync(GetOrganizationRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOrganizationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetOrganizationRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecommendation

        internal virtual GetRecommendationResponse GetRecommendation(GetRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Get a specific Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        public virtual Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChecks

        internal virtual ListChecksResponse ListChecks(ListChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChecksResponseUnmarshaller.Instance;

            return Invoke<ListChecksResponse>(request, options);
        }



        /// <summary>
        /// List a filterable set of Checks
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChecks service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListChecks">REST API Reference for ListChecks Operation</seealso>
        public virtual Task<ListChecksResponse> ListChecksAsync(ListChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListChecksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOrganizationRecommendationAccounts

        internal virtual ListOrganizationRecommendationAccountsResponse ListOrganizationRecommendationAccounts(ListOrganizationRecommendationAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationAccountsResponse>(request, options);
        }



        /// <summary>
        /// Lists the accounts that own the resources for an organization aggregate recommendation.
        /// This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationAccounts service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationAccounts">REST API Reference for ListOrganizationRecommendationAccounts Operation</seealso>
        public virtual Task<ListOrganizationRecommendationAccountsResponse> ListOrganizationRecommendationAccountsAsync(ListOrganizationRecommendationAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationRecommendationAccountsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOrganizationRecommendationResources

        internal virtual ListOrganizationRecommendationResourcesResponse ListOrganizationRecommendationResources(ListOrganizationRecommendationResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationResourcesResponse>(request, options);
        }



        /// <summary>
        /// List Resources of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendationResources">REST API Reference for ListOrganizationRecommendationResources Operation</seealso>
        public virtual Task<ListOrganizationRecommendationResourcesResponse> ListOrganizationRecommendationResourcesAsync(ListOrganizationRecommendationResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationRecommendationResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOrganizationRecommendations

        internal virtual ListOrganizationRecommendationsResponse ListOrganizationRecommendations(ListOrganizationRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// List a filterable set of Recommendations within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListOrganizationRecommendations">REST API Reference for ListOrganizationRecommendations Operation</seealso>
        public virtual Task<ListOrganizationRecommendationsResponse> ListOrganizationRecommendationsAsync(ListOrganizationRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOrganizationRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommendationResources

        internal virtual ListRecommendationResourcesResponse ListRecommendationResources(ListRecommendationResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationResourcesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationResourcesResponse>(request, options);
        }



        /// <summary>
        /// List Resources of a Recommendation
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationResources service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendationResources">REST API Reference for ListRecommendationResources Operation</seealso>
        public virtual Task<ListRecommendationResourcesResponse> ListRecommendationResourcesAsync(ListRecommendationResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecommendations

        internal virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// List a filterable set of Recommendations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOrganizationRecommendationLifecycle

        internal virtual UpdateOrganizationRecommendationLifecycleResponse UpdateOrganizationRecommendationLifecycle(UpdateOrganizationRecommendationLifecycleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationRecommendationLifecycleResponse>(request, options);
        }



        /// <summary>
        /// Update the lifecycle of a Recommendation within an Organization. This API only supports
        /// prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationRecommendationLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateOrganizationRecommendationLifecycle">REST API Reference for UpdateOrganizationRecommendationLifecycle Operation</seealso>
        public virtual Task<UpdateOrganizationRecommendationLifecycleResponse> UpdateOrganizationRecommendationLifecycleAsync(UpdateOrganizationRecommendationLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOrganizationRecommendationLifecycleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRecommendationLifecycle

        internal virtual UpdateRecommendationLifecycleResponse UpdateRecommendationLifecycle(UpdateRecommendationLifecycleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateRecommendationLifecycleResponse>(request, options);
        }



        /// <summary>
        /// Update the lifecyle of a Recommendation. This API only supports prioritized recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendationLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecommendationLifecycle service method, as returned by TrustedAdvisor.</returns>
        /// <exception cref="Amazon.TrustedAdvisor.Model.AccessDeniedException">
        /// Exception that access has been denied due to insufficient access
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ConflictException">
        /// Exception that the request was denied due to conflictions in state
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.InternalServerException">
        /// Exception to notify that an unexpected internal error occurred during processing of
        /// the request
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ResourceNotFoundException">
        /// Exception that the requested resource has not been found
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ThrottlingException">
        /// Exception to notify that requests are being throttled
        /// </exception>
        /// <exception cref="Amazon.TrustedAdvisor.Model.ValidationException">
        /// Exception that the request failed to satisfy service constraints
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/trustedadvisor-2022-09-15/UpdateRecommendationLifecycle">REST API Reference for UpdateRecommendationLifecycle Operation</seealso>
        public virtual Task<UpdateRecommendationLifecycleResponse> UpdateRecommendationLifecycleAsync(UpdateRecommendationLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommendationLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommendationLifecycleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRecommendationLifecycleResponse>(request, options, cancellationToken);
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