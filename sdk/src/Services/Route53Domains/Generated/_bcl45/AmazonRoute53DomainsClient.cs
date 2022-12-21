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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53Domains.Model;
using Amazon.Route53Domains.Model.Internal.MarshallTransformations;
using Amazon.Route53Domains.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Implementation for accessing Route53Domains
    ///
    /// Amazon Route 53 API actions let you register domain names and perform related operations.
    /// </summary>
    public partial class AmazonRoute53DomainsClient : AmazonServiceClient, IAmazonRoute53Domains
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53DomainsMetadata();
        private IRoute53DomainsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53DomainsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53DomainsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        public AmazonRoute53DomainsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53DomainsConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        public AmazonRoute53DomainsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53DomainsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(AmazonRoute53DomainsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53DomainsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Credentials and an
        /// AmazonRoute53DomainsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(AWSCredentials credentials, AmazonRoute53DomainsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53DomainsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53DomainsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53DomainsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53DomainsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53DomainsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53DomainsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53DomainsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53DomainsClient Configuration Object</param>
        public AmazonRoute53DomainsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53DomainsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53DomainsEndpointResolver());
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


        #region  AcceptDomainTransferFromAnotherAwsAccount


        /// <summary>
        /// Accepts the transfer of a domain from another Amazon Web Services account to the currentAmazon
        /// Web Services account. You initiate a transfer between Amazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        ///  
        /// <para>
        /// If you use the CLI command at <a href="https://docs.aws.amazon.com/cli/latest/reference/route53domains/accept-domain-transfer-from-another-aws-account.html">accept-domain-transfer-from-another-aws-account</a>,
        /// use JSON format as input instead of text because otherwise CLI will throw an error
        /// from domain transfer input that includes single quotes.
        /// </para>
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDomainTransferFromAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the AcceptDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual AcceptDomainTransferFromAnotherAwsAccountResponse AcceptDomainTransferFromAnotherAwsAccount(AcceptDomainTransferFromAnotherAwsAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;

            return Invoke<AcceptDomainTransferFromAnotherAwsAccountResponse>(request, options);
        }


        /// <summary>
        /// Accepts the transfer of a domain from another Amazon Web Services account to the currentAmazon
        /// Web Services account. You initiate a transfer between Amazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        ///  
        /// <para>
        /// If you use the CLI command at <a href="https://docs.aws.amazon.com/cli/latest/reference/route53domains/accept-domain-transfer-from-another-aws-account.html">accept-domain-transfer-from-another-aws-account</a>,
        /// use JSON format as input instead of text because otherwise CLI will throw an error
        /// from domain transfer input that includes single quotes.
        /// </para>
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDomainTransferFromAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual Task<AcceptDomainTransferFromAnotherAwsAccountResponse> AcceptDomainTransferFromAnotherAwsAccountAsync(AcceptDomainTransferFromAnotherAwsAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<AcceptDomainTransferFromAnotherAwsAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDelegationSignerToDomain


        /// <summary>
        /// Creates a delegation signer (DS) record in the registry zone for this domain name.
        /// 
        ///  
        /// <para>
        /// Note that creating DS record at the registry impacts DNSSEC validation of your DNS
        /// records. This action may render your domain name unavailable on the internet if the
        /// steps are completed in the wrong order, or with incorrect timing. For more information
        /// about DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec.html">Configuring
        /// DNSSEC signing</a> in the <i>Route 53 developer guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegationSignerToDomain service method.</param>
        /// 
        /// <returns>The response from the AssociateDelegationSignerToDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DnssecLimitExceededException">
        /// This error is returned if you call <code>AssociateDelegationSignerToDomain</code>
        /// when the specified domain has reached the maximum number of DS records. You can't
        /// add any additional DS records unless you delete an existing one first.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        public virtual AssociateDelegationSignerToDomainResponse AssociateDelegationSignerToDomain(AssociateDelegationSignerToDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegationSignerToDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegationSignerToDomainResponseUnmarshaller.Instance;

            return Invoke<AssociateDelegationSignerToDomainResponse>(request, options);
        }


        /// <summary>
        /// Creates a delegation signer (DS) record in the registry zone for this domain name.
        /// 
        ///  
        /// <para>
        /// Note that creating DS record at the registry impacts DNSSEC validation of your DNS
        /// records. This action may render your domain name unavailable on the internet if the
        /// steps are completed in the wrong order, or with incorrect timing. For more information
        /// about DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec.html">Configuring
        /// DNSSEC signing</a> in the <i>Route 53 developer guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegationSignerToDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateDelegationSignerToDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DnssecLimitExceededException">
        /// This error is returned if you call <code>AssociateDelegationSignerToDomain</code>
        /// when the specified domain has reached the maximum number of DS records. You can't
        /// add any additional DS records unless you delete an existing one first.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        public virtual Task<AssociateDelegationSignerToDomainResponse> AssociateDelegationSignerToDomainAsync(AssociateDelegationSignerToDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegationSignerToDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegationSignerToDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateDelegationSignerToDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelDomainTransferToAnotherAwsAccount


        /// <summary>
        /// Cancels the transfer of a domain from the current Amazon Web Services account to another
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// You must cancel the transfer before the other Amazon Web Services account accepts
        /// the transfer using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainTransferToAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the CancelDomainTransferToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        public virtual CancelDomainTransferToAnotherAwsAccountResponse CancelDomainTransferToAnotherAwsAccount(CancelDomainTransferToAnotherAwsAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDomainTransferToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainTransferToAnotherAwsAccountResponseUnmarshaller.Instance;

            return Invoke<CancelDomainTransferToAnotherAwsAccountResponse>(request, options);
        }


        /// <summary>
        /// Cancels the transfer of a domain from the current Amazon Web Services account to another
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// You must cancel the transfer before the other Amazon Web Services account accepts
        /// the transfer using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainTransferToAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDomainTransferToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        public virtual Task<CancelDomainTransferToAnotherAwsAccountResponse> CancelDomainTransferToAnotherAwsAccountAsync(CancelDomainTransferToAnotherAwsAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDomainTransferToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainTransferToAnotherAwsAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelDomainTransferToAnotherAwsAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckDomainAvailability


        /// <summary>
        /// This operation checks the availability of one domain name. Note that if the availability
        /// status of a domain is pending, you must submit another request to determine the availability
        /// of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDomainAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// This operation checks the availability of one domain name. Note that if the availability
        /// status of a domain is pending, you must submit another request to determine the availability
        /// of the domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckDomainAvailability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckDomainAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckDomainTransferability


        /// <summary>
        /// Checks whether a domain name can be transferred to Amazon Route 53.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability service method.</param>
        /// 
        /// <returns>The response from the CheckDomainTransferability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual CheckDomainTransferabilityResponse CheckDomainTransferability(CheckDomainTransferabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDomainTransferabilityResponse>(request, options);
        }


        /// <summary>
        /// Checks whether a domain name can be transferred to Amazon Route 53.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckDomainTransferability service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual Task<CheckDomainTransferabilityResponse> CheckDomainTransferabilityAsync(CheckDomainTransferabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckDomainTransferabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// This operation deletes the specified domain. This action is permanent. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-delete.html">Deleting
        /// a domain name registration</a>.
        /// 
        ///  
        /// <para>
        /// To transfer the domain registration to another registrar, use the transfer process
        /// that’s provided by the registrar to which you want to transfer the registration. Otherwise,
        /// the following apply:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You can’t get a refund for the cost of a deleted domain registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The registry for the top-level domain might hold the domain name for a brief time
        /// before releasing it for other users to register (varies by registry). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the registration has been deleted, we'll send you a confirmation to the registrant
        /// contact. The email will come from <code>noreply@domainnameverification.net</code>
        /// or <code>noreply@registrar.amazon.com</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes the specified domain. This action is permanent. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-delete.html">Deleting
        /// a domain name registration</a>.
        /// 
        ///  
        /// <para>
        /// To transfer the domain registration to another registrar, use the transfer process
        /// that’s provided by the registrar to which you want to transfer the registration. Otherwise,
        /// the following apply:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You can’t get a refund for the cost of a deleted domain registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The registry for the top-level domain might hold the domain name for a brief time
        /// before releasing it for other users to register (varies by registry). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the registration has been deleted, we'll send you a confirmation to the registrant
        /// contact. The email will come from <code>noreply@domainnameverification.net</code>
        /// or <code>noreply@registrar.amazon.com</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagsForDomain


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags.</param>
        /// <param name="tagsToDelete">A list of tag keys to delete.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual DeleteTagsForDomainResponse DeleteTagsForDomain(string domainName, List<string> tagsToDelete)
        {
            var request = new DeleteTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToDelete = tagsToDelete;
            return DeleteTagsForDomain(request);
        }


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual DeleteTagsForDomainResponse DeleteTagsForDomain(DeleteTagsForDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsForDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to delete one or more tags.</param>
        /// <param name="tagsToDelete">A list of tag keys to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(string domainName, List<string> tagsToDelete, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToDelete = tagsToDelete;
            return DeleteTagsForDomainAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation deletes the specified tags for a domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(DeleteTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDomainAutoRenew


        /// <summary>
        /// This operation disables automatic renewal of domain registration for the specified
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the DisableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<DisableDomainAutoRenewResponse>(request, options);
        }


        /// <summary>
        /// This operation disables automatic renewal of domain registration for the specified
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual Task<DisableDomainAutoRenewResponse> DisableDomainAutoRenewAsync(DisableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableDomainAutoRenewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDomainTransferLock


        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<DisableDomainTransferLockResponse>(request, options);
        }


        /// <summary>
        /// This operation removes the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to allow domain transfers. We recommend you refrain from performing this action
        /// unless you intend to transfer the domain to a different registrar. Successful submission
        /// returns an operation ID that you can use to track the progress and completion of the
        /// action. If the request is not completed successfully, the domain registrant will be
        /// notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableDomainTransferLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDelegationSignerFromDomain


        /// <summary>
        /// Deletes a delegation signer (DS) record in the registry zone for this domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegationSignerFromDomain service method.</param>
        /// 
        /// <returns>The response from the DisassociateDelegationSignerFromDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        public virtual DisassociateDelegationSignerFromDomainResponse DisassociateDelegationSignerFromDomain(DisassociateDelegationSignerFromDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegationSignerFromDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegationSignerFromDomainResponseUnmarshaller.Instance;

            return Invoke<DisassociateDelegationSignerFromDomainResponse>(request, options);
        }


        /// <summary>
        /// Deletes a delegation signer (DS) record in the registry zone for this domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegationSignerFromDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateDelegationSignerFromDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        public virtual Task<DisassociateDelegationSignerFromDomainResponse> DisassociateDelegationSignerFromDomainAsync(DisassociateDelegationSignerFromDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegationSignerFromDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegationSignerFromDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateDelegationSignerFromDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainAutoRenew


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// That You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>. Route 53 requires that you renew before the end of the renewal period so
        /// we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        public virtual EnableDomainAutoRenewResponse EnableDomainAutoRenew(EnableDomainAutoRenewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<EnableDomainAutoRenewResponse>(request, options);
        }


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// That You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>. Route 53 requires that you renew before the end of the renewal period so
        /// we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        public virtual Task<EnableDomainAutoRenewResponse> EnableDomainAutoRenewAsync(EnableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableDomainAutoRenewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainTransferLock


        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        public virtual EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<EnableDomainTransferLockResponse>(request, options);
        }


        /// <summary>
        /// This operation sets the transfer lock on the domain (specifically the <code>clientTransferProhibited</code>
        /// status) to prevent domain transfers. Successful submission returns an operation ID
        /// that you can use to track the progress and completion of the action. If the request
        /// is not completed successfully, the domain registrant will be notified by email.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDomainTransferLock service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        public virtual Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableDomainTransferLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContactReachabilityStatus


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation returns information
        /// about whether the registrant contact has responded.
        /// 
        ///  
        /// <para>
        /// If you want us to resend the email, use the <code>ResendContactReachabilityEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus service method.</param>
        /// 
        /// <returns>The response from the GetContactReachabilityStatus service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        public virtual GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return Invoke<GetContactReachabilityStatusResponse>(request, options);
        }


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation returns information
        /// about whether the registrant contact has responded.
        /// 
        ///  
        /// <para>
        /// If you want us to resend the email, use the <code>ResendContactReachabilityEmail</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContactReachabilityStatus service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        public virtual Task<GetContactReachabilityStatusResponse> GetContactReachabilityStatusAsync(GetContactReachabilityStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetContactReachabilityStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current Amazon Web Services account. Contact information for the domain is
        /// also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return Invoke<GetDomainDetailResponse>(request, options);
        }


        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current Amazon Web Services account. Contact information for the domain is
        /// also returned as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDetailResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainDetailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainSuggestions


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetDomainSuggestionsResponse>(request, options);
        }


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual Task<GetDomainSuggestionsResponse> GetDomainSuggestionsAsync(GetDomainSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainSuggestionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainSuggestionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOperationDetail


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return Invoke<GetOperationDetailResponse>(request, options);
        }


        /// <summary>
        /// This operation returns the current status of an operation that is not completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperationDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationDetailResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOperationDetailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainsAsync(new ListDomainsRequest(), cancellationToken);
        }

        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current Amazon Web Services account if no filtering conditions are used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations()
        {
            return ListOperations(new ListOperationsRequest());
        }


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListOperationsAsync(new ListOperationsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns information about all of the operations that return an operation ID and that
        /// have ever been performed on domains that were registered by the current account. 
        /// 
        ///  
        /// <para>
        /// This command runs only in the us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPrices


        /// <summary>
        /// Lists the following prices for either all the TLDs supported by Route 53, or the specified
        /// TLD:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Transfer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner change
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain renewal
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain restoration
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrices service method.</param>
        /// 
        /// <returns>The response from the ListPrices service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        public virtual ListPricesResponse ListPrices(ListPricesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPricesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricesResponseUnmarshaller.Instance;

            return Invoke<ListPricesResponse>(request, options);
        }


        /// <summary>
        /// Lists the following prices for either all the TLDs supported by Route 53, or the specified
        /// TLD:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Transfer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner change
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain renewal
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain restoration
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrices service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        public virtual Task<ListPricesResponse> ListPricesAsync(ListPricesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPricesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPricesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForDomain


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual ListTagsForDomainResponse ListTagsForDomain(string domainName)
        {
            var request = new ListTagsForDomainRequest();
            request.DomainName = domainName;
            return ListTagsForDomain(request);
        }


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual ListTagsForDomainResponse ListTagsForDomain(ListTagsForDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<ListTagsForDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to get a list of tags.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual Task<ListTagsForDomainResponse> ListTagsForDomainAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTagsForDomainRequest();
            request.DomainName = domainName;
            return ListTagsForDomainAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation returns all of the tags that are associated with the specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual Task<ListTagsForDomainResponse> ListTagsForDomainAsync(ListTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PushDomain


        /// <summary>
        /// Moves a domain from Amazon Web Services to another registrar. 
        /// 
        ///  
        /// <para>
        /// Supported actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changes the IPS tags of a .uk domain, and pushes it to transit. Transit means that
        /// the domain is ready to be transferred to another registrar.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PushDomain service method.</param>
        /// 
        /// <returns>The response from the PushDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        public virtual PushDomainResponse PushDomain(PushDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PushDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PushDomainResponseUnmarshaller.Instance;

            return Invoke<PushDomainResponse>(request, options);
        }


        /// <summary>
        /// Moves a domain from Amazon Web Services to another registrar. 
        /// 
        ///  
        /// <para>
        /// Supported actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changes the IPS tags of a .uk domain, and pushes it to transit. Transit means that
        /// the domain is ready to be transferred to another registrar.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PushDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PushDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        public virtual Task<PushDomainResponse> PushDomainAsync(PushDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PushDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PushDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<PushDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain


        /// <summary>
        /// This operation registers a domain. Domains are registered either by Amazon Registrar
        /// (for .com, .net, and .org domains) or by our registrar associate, Gandi (for all other
        /// domains). For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a Route 53 hosted zone that has the same name as the domain. Route 53 assigns
        /// four name servers to your hosted zone and automatically updates your domain registration
        /// with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables auto renew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the administrative, registrant,
        /// and technical contacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your Amazon Web Services account an amount based on the top-level domain.
        /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation registers a domain. Domains are registered either by Amazon Registrar
        /// (for .com, .net, and .org domains) or by our registrar associate, Gandi (for all other
        /// domains). For some top-level domains (TLDs), this operation requires extra parameters.
        /// 
        ///  
        /// <para>
        /// When you register a domain, Amazon Route 53 does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a Route 53 hosted zone that has the same name as the domain. Route 53 assigns
        /// four name servers to your hosted zone and automatically updates your domain registration
        /// with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables auto renew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the administrative, registrant,
        /// and technical contacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your Amazon Web Services account an amount based on the top-level domain.
        /// For more information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectDomainTransferFromAnotherAwsAccount


        /// <summary>
        /// Rejects the transfer of a domain from another Amazon Web Services account to the current
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainTransferFromAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the RejectDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual RejectDomainTransferFromAnotherAwsAccountResponse RejectDomainTransferFromAnotherAwsAccount(RejectDomainTransferFromAnotherAwsAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;

            return Invoke<RejectDomainTransferFromAnotherAwsAccountResponse>(request, options);
        }


        /// <summary>
        /// Rejects the transfer of a domain from another Amazon Web Services account to the current
        /// Amazon Web Services account. You initiate a transfer betweenAmazon Web Services accounts
        /// using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainTransferFromAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectDomainTransferFromAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual Task<RejectDomainTransferFromAnotherAwsAccountResponse> RejectDomainTransferFromAnotherAwsAccountAsync(RejectDomainTransferFromAnotherAwsAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectDomainTransferFromAnotherAwsAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenewDomain


        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        public virtual RenewDomainResponse RenewDomain(RenewDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewDomainResponseUnmarshaller.Instance;

            return Invoke<RenewDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        public virtual Task<RenewDomainResponse> RenewDomainAsync(RenewDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<RenewDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResendContactReachabilityEmail


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation resends the confirmation
        /// email to the current email address for the registrant contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail service method.</param>
        /// 
        /// <returns>The response from the ResendContactReachabilityEmail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual ResendContactReachabilityEmailResponse ResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return Invoke<ResendContactReachabilityEmailResponse>(request, options);
        }


        /// <summary>
        /// For operations that require confirmation that the email address for the registrant
        /// contact is valid, such as registering a new domain, this operation resends the confirmation
        /// email to the current email address for the registrant contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendContactReachabilityEmail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResendContactReachabilityEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResendOperationAuthorization


        /// <summary>
        /// Resend the form of authorization email for this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendOperationAuthorization service method.</param>
        /// 
        /// <returns>The response from the ResendOperationAuthorization service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        public virtual ResendOperationAuthorizationResponse ResendOperationAuthorization(ResendOperationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendOperationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendOperationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<ResendOperationAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Resend the form of authorization email for this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendOperationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResendOperationAuthorization service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        public virtual Task<ResendOperationAuthorizationResponse> ResendOperationAuthorizationAsync(ResendOperationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendOperationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendOperationAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResendOperationAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the authorization code for the domain. To transfer a domain
        /// to another registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveDomainAuthCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return Invoke<RetrieveDomainAuthCodeResponse>(request, options);
        }


        /// <summary>
        /// This operation returns the authorization code for the domain. To transfer a domain
        /// to another registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveDomainAuthCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetrieveDomainAuthCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// Transfers a domain from another registrar to Amazon Route 53. When the transfer is
        /// complete, the domain is registered either with Amazon Registrar (for .com, .net, and
        /// .org domains) or with our registrar associate, Gandi (for all other TLDs).
        /// 
        ///  
        /// <para>
        /// For more information about transferring domains, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain that you're transferring to Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain from one Amazon Web Services account
        /// to another, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain to another domain registrar, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-from-route-53.html">Transferring
        /// a Domain from Amazon Route 53 to Another Registrar</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you transfer your DNS service to Route 53 or to another DNS
        /// service provider before you transfer your registration. Some registrars provide free
        /// DNS service when you purchase a domain registration. When you transfer the registration,
        /// the previous registrar will not renew your domain registration and could end your
        /// DNS service at any time.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain and
        /// you don't transfer DNS service to another provider, your website, email, and the web
        /// applications associated with the domain might become unavailable.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the transfer doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual TransferDomainResponse TransferDomain(TransferDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return Invoke<TransferDomainResponse>(request, options);
        }


        /// <summary>
        /// Transfers a domain from another registrar to Amazon Route 53. When the transfer is
        /// complete, the domain is registered either with Amazon Registrar (for .com, .net, and
        /// .org domains) or with our registrar associate, Gandi (for all other TLDs).
        /// 
        ///  
        /// <para>
        /// For more information about transferring domains, see the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain that you're transferring to Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain from one Amazon Web Services account
        /// to another, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_TransferDomainToAnotherAwsAccount.html">TransferDomainToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about how to transfer a domain to another domain registrar, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-from-route-53.html">Transferring
        /// a Domain from Amazon Route 53 to Another Registrar</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you transfer your DNS service to Route 53 or to another DNS
        /// service provider before you transfer your registration. Some registrars provide free
        /// DNS service when you purchase a domain registration. When you transfer the registration,
        /// the previous registrar will not renew your domain registration and could end your
        /// DNS service at any time.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain and
        /// you don't transfer DNS service to another provider, your website, email, and the web
        /// applications associated with the domain might become unavailable.
        /// </para>
        ///  </important> 
        /// <para>
        /// If the transfer is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the action. If the transfer doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DomainLimitExceededException">
        /// The number of domains has exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<TransferDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransferDomainToAnotherAwsAccount


        /// <summary>
        /// Transfers a domain from the current Amazon Web Services account to another Amazon
        /// Web Services account. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that you're transferring the domain to must accept
        /// the transfer. If the other account doesn't accept the transfer within 3 days, we cancel
        /// the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can cancel the transfer before the other account accepts it. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_CancelDomainTransferToAnotherAwsAccount.html">CancelDomainTransferToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other account can reject the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_RejectDomainTransferFromAnotherAwsAccount.html">RejectDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When you transfer a domain from one Amazon Web Services account to another, Route
        /// 53 doesn't transfer the hosted zone that is associated with the domain. DNS resolution
        /// isn't affected if the domain and the hosted zone are owned by separate accounts, so
        /// transferring the hosted zone is optional. For information about transferring the hosted
        /// zone to another Amazon Web Services account, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zones-migrating.html">Migrating
        /// a Hosted Zone to a Different Amazon Web Services Account</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomainToAnotherAwsAccount service method.</param>
        /// 
        /// <returns>The response from the TransferDomainToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        public virtual TransferDomainToAnotherAwsAccountResponse TransferDomainToAnotherAwsAccount(TransferDomainToAnotherAwsAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainToAnotherAwsAccountResponseUnmarshaller.Instance;

            return Invoke<TransferDomainToAnotherAwsAccountResponse>(request, options);
        }


        /// <summary>
        /// Transfers a domain from the current Amazon Web Services account to another Amazon
        /// Web Services account. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Web Services account that you're transferring the domain to must accept
        /// the transfer. If the other account doesn't accept the transfer within 3 days, we cancel
        /// the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AcceptDomainTransferFromAnotherAwsAccount.html">AcceptDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can cancel the transfer before the other account accepts it. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_CancelDomainTransferToAnotherAwsAccount.html">CancelDomainTransferToAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other account can reject the transfer. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_RejectDomainTransferFromAnotherAwsAccount.html">RejectDomainTransferFromAnotherAwsAccount</a>.
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When you transfer a domain from one Amazon Web Services account to another, Route
        /// 53 doesn't transfer the hosted zone that is associated with the domain. DNS resolution
        /// isn't affected if the domain and the hosted zone are owned by separate accounts, so
        /// transferring the hosted zone is optional. For information about transferring the hosted
        /// zone to another Amazon Web Services account, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zones-migrating.html">Migrating
        /// a Hosted Zone to a Different Amazon Web Services Account</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use either <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListOperations.html">ListOperations</a>
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to determine whether the operation succeeded. <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// provides additional information, for example, <code>Domain Transfer from Aws Account
        /// 111122223333 has been cancelled</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferDomainToAnotherAwsAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferDomainToAnotherAwsAccount service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        public virtual Task<TransferDomainToAnotherAwsAccountResponse> TransferDomainToAnotherAwsAccountAsync(TransferDomainToAnotherAwsAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainToAnotherAwsAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<TransferDomainToAnotherAwsAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContact


        /// <summary>
        /// This operation updates the contact information for a particular domain. You must specify
        /// information for at least one contact: registrant, administrator, or technical.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the operation. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        public virtual UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactResponse>(request, options);
        }


        /// <summary>
        /// This operation updates the contact information for a particular domain. You must specify
        /// information for at least one contact: registrant, administrator, or technical.
        /// 
        ///  
        /// <para>
        /// If the update is successful, this method returns an operation ID that you can use
        /// to track the progress and completion of the operation. If the request is not completed
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainContact service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        public virtual Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (administrative, registrant, or technical). If the request succeeds, Amazon Route
        /// 53 returns an operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to track the progress and completion of the action. If the request doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        ///  <important> 
        /// <para>
        /// By disabling the privacy service via API, you consent to the publication of the contact
        /// information provided for this domain via the public WHOIS database. You certify that
        /// you are the registrant of this domain name and have the authority to make this decision.
        /// You may withdraw your consent at any time by enabling privacy protection using either
        /// <code>UpdateDomainContactPrivacy</code> or the Route 53 console. Enabling privacy
        /// protection removes the contact information provided for this domain from the WHOIS
        /// database. For more information on our privacy practices, see <a href="https://aws.amazon.com/privacy/">https://aws.amazon.com/privacy/</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        public virtual UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactPrivacyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactPrivacyResponse>(request, options);
        }


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify the same privacy setting for the administrative, registrant, and
        /// technical contacts.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (administrative, registrant, or technical). If the request succeeds, Amazon Route
        /// 53 returns an operation ID that you can use with <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_GetOperationDetail.html">GetOperationDetail</a>
        /// to track the progress and completion of the action. If the request doesn't complete
        /// successfully, the domain registrant will be notified by email.
        /// </para>
        ///  <important> 
        /// <para>
        /// By disabling the privacy service via API, you consent to the publication of the contact
        /// information provided for this domain via the public WHOIS database. You certify that
        /// you are the registrant of this domain name and have the authority to make this decision.
        /// You may withdraw your consent at any time by enabling privacy protection using either
        /// <code>UpdateDomainContactPrivacy</code> or the Route 53 console. Enabling privacy
        /// protection removes the contact information provided for this domain from the WHOIS
        /// database. For more information on our privacy practices, see <a href="https://aws.amazon.com/privacy/">https://aws.amazon.com/privacy/</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        public virtual Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactPrivacyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainContactPrivacyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainNameservers


        /// <summary>
        /// This operation replaces the current set of name servers for the domain with the specified
        /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
        /// name servers in the delegation set for the hosted zone for the domain.
        /// 
        ///  
        /// <para>
        /// If successful, this operation returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        public virtual UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameserversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameserversResponse>(request, options);
        }


        /// <summary>
        /// This operation replaces the current set of name servers for the domain with the specified
        /// set of name servers. If you use Amazon Route 53 as your DNS service, specify the four
        /// name servers in the delegation set for the hosted zone for the domain.
        /// 
        ///  
        /// <para>
        /// If successful, this operation returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainNameservers service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.TLDRulesViolationException">
        /// The top-level domain does not support this operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        public virtual Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameserversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainNameserversResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagsForDomain


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags.</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual UpdateTagsForDomainResponse UpdateTagsForDomain(string domainName, List<Tag> tagsToUpdate)
        {
            var request = new UpdateTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToUpdate = tagsToUpdate;
            return UpdateTagsForDomain(request);
        }


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual UpdateTagsForDomainResponse UpdateTagsForDomain(UpdateTagsForDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForDomainResponse>(request, options);
        }


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="domainName">The domain for which you want to add or update tags.</param>
        /// <param name="tagsToUpdate">A list of the tag keys and values that you want to add or update. If you specify a key that already exists, the corresponding value will be replaced.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(string domainName, List<Tag> tagsToUpdate, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateTagsForDomainRequest();
            request.DomainName = domainName;
            request.TagsToUpdate = tagsToUpdate;
            return UpdateTagsForDomainAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation adds or updates tags for a specified domain.
        /// 
        ///  
        /// <para>
        /// All tag operations are eventually consistent; subsequent operations might not immediately
        /// represent all issued operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTagsForDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.OperationLimitExceededException">
        /// The number of operations or jobs running exceeded the allowed threshold for the account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(UpdateTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ViewBilling


        /// <summary>
        /// Returns all the domain-related billing records for the current Amazon Web Services
        /// account for a specified period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual ViewBillingResponse ViewBilling(ViewBillingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ViewBillingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ViewBillingResponseUnmarshaller.Instance;

            return Invoke<ViewBillingResponse>(request, options);
        }


        /// <summary>
        /// Returns all the domain-related billing records for the current Amazon Web Services
        /// account for a specified period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for APIs that accept a domain name,
        /// the request might specify a domain name that doesn't belong to the account that submitted
        /// the request. For <code>AcceptDomainTransferFromAnotherAwsAccount</code>, the password
        /// might be invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual Task<ViewBillingResponse> ViewBillingAsync(ViewBillingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ViewBillingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ViewBillingResponseUnmarshaller.Instance;
            
            return InvokeAsync<ViewBillingResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}