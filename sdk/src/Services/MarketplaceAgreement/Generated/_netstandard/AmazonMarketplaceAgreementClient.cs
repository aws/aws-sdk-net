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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MarketplaceAgreement.Model;
using Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceAgreement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MarketplaceAgreement
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceAgreement</para>
    ///
    /// AWS Marketplace is a curated digital catalog that customers can use to find, buy,
    /// deploy, and manage third-party software, data, and services to build solutions and
    /// run their businesses. The AWS Marketplace Agreement Service provides an API interface
    /// that helps AWS Marketplace sellers manage their product-related agreements, including
    /// listing, searching, and filtering agreements.
    /// 
    ///  
    /// <para>
    /// To manage agreements in AWS Marketplace, you must ensure that your AWS Identity and
    /// Access Management (IAM) policies and roles are set up. The user must have the required
    /// policies/permissions that allow them to carry out the actions in AWS:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeAgreement</c> – Grants permission to users to obtain detailed meta data
    /// about any of their agreements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetAgreementTerms</c> – Grants permission to users to obtain details about the
    /// terms of an agreement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SearchAgreements</c> – Grants permission to users to search through all their
    /// agreements.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonMarketplaceAgreementClient : AmazonServiceClient, IAmazonMarketplaceAgreement
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceAgreementMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        public AmazonMarketplaceAgreementClient()
            : base(new AmazonMarketplaceAgreementConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        public AmazonMarketplaceAgreementClient(RegionEndpoint region)
            : base(new AmazonMarketplaceAgreementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(AmazonMarketplaceAgreementConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceAgreementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials and an
        /// AmazonMarketplaceAgreementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials, AmazonMarketplaceAgreementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceAgreementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceAgreementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceAgreementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceAgreementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceAgreementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceAgreementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMarketplaceAgreementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMarketplaceAgreementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MarketplaceAgreementPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceAgreementEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceAgreementAuthSchemeHandler());
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


        #region  DescribeAgreement

        internal virtual DescribeAgreementResponse DescribeAgreement(DescribeAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return Invoke<DescribeAgreementResponse>(request, options);
        }



        /// <summary>
        /// Provides details about an agreement, such as the proposer, acceptor, start date, and
        /// end date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        public virtual Task<DescribeAgreementResponse> DescribeAgreementAsync(DescribeAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgreementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgreementTerms

        internal virtual GetAgreementTermsResponse GetAgreementTerms(GetAgreementTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementTermsResponseUnmarshaller.Instance;

            return Invoke<GetAgreementTermsResponse>(request, options);
        }



        /// <summary>
        /// Obtains details about the terms in an agreement that you participated in as proposer
        /// or acceptor.
        /// 
        ///  
        /// <para>
        /// The details include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TermType</c> – The type of term, such as <c>LegalTerm</c>, <c>RenewalTerm</c>,
        /// or <c>ConfigurableUpfrontPricingTerm</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TermID</c> – The ID of the particular term, which is common between offer and
        /// agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TermPayload</c> – The key information contained in the term, such as the EULA
        /// for <c>LegalTerm</c> or pricing and dimensions for various pricing terms, such as
        /// <c>ConfigurableUpfrontPricingTerm</c> or <c>UsageBasedPricingTerm</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>Configuration</c> – The buyer/acceptor's selection at the time of agreement creation,
        /// such as the number of units purchased for a dimension or setting the <c>EnableAutoRenew</c>
        /// flag.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgreementTerms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgreementTerms service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/GetAgreementTerms">REST API Reference for GetAgreementTerms Operation</seealso>
        public virtual Task<GetAgreementTermsResponse> GetAgreementTermsAsync(GetAgreementTermsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementTermsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgreementTermsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchAgreements

        internal virtual SearchAgreementsResponse SearchAgreements(SearchAgreementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAgreementsResponseUnmarshaller.Instance;

            return Invoke<SearchAgreementsResponse>(request, options);
        }



        /// <summary>
        /// Searches across all agreements that a proposer or an acceptor has in AWS Marketplace.
        /// The search returns a list of agreements with basic agreement information.
        /// 
        ///  
        /// <para>
        /// The following filter combinations are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>ResourceIdentifier</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>OfferId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>ResourceIdentifier</c>
        /// + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>OfferId</c> + <c>Status</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>ResourceType</c>
        /// + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>ResourceType</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>OfferId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>OfferId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>ResourceIdentifier</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>ResourceIdentifier</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartyType</c> as <c>Proposer</c> + <c>AgreementType</c> + <c>AcceptorAccountId</c>
        /// + <c>ResourceType</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAgreements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAgreements service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/SearchAgreements">REST API Reference for SearchAgreements Operation</seealso>
        public virtual Task<SearchAgreementsResponse> SearchAgreementsAsync(SearchAgreementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAgreementsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAgreementsResponse>(request, options, cancellationToken);
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