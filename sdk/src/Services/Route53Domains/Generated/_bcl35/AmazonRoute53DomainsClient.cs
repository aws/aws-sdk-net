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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
        /// Initiates the asynchronous execution of the AcceptDomainTransferFromAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptDomainTransferFromAnotherAwsAccount operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptDomainTransferFromAnotherAwsAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual IAsyncResult BeginAcceptDomainTransferFromAnotherAwsAccount(AcceptDomainTransferFromAnotherAwsAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptDomainTransferFromAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptDomainTransferFromAnotherAwsAccount.</param>
        /// 
        /// <returns>Returns a  AcceptDomainTransferFromAnotherAwsAccountResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AcceptDomainTransferFromAnotherAwsAccount">REST API Reference for AcceptDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual AcceptDomainTransferFromAnotherAwsAccountResponse EndAcceptDomainTransferFromAnotherAwsAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptDomainTransferFromAnotherAwsAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssociateDelegationSignerToDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegationSignerToDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDelegationSignerToDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        public virtual IAsyncResult BeginAssociateDelegationSignerToDomain(AssociateDelegationSignerToDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDelegationSignerToDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDelegationSignerToDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDelegationSignerToDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDelegationSignerToDomain.</param>
        /// 
        /// <returns>Returns a  AssociateDelegationSignerToDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/AssociateDelegationSignerToDomain">REST API Reference for AssociateDelegationSignerToDomain Operation</seealso>
        public virtual AssociateDelegationSignerToDomainResponse EndAssociateDelegationSignerToDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDelegationSignerToDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CancelDomainTransferToAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainTransferToAnotherAwsAccount operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDomainTransferToAnotherAwsAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        public virtual IAsyncResult BeginCancelDomainTransferToAnotherAwsAccount(CancelDomainTransferToAnotherAwsAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDomainTransferToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainTransferToAnotherAwsAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDomainTransferToAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDomainTransferToAnotherAwsAccount.</param>
        /// 
        /// <returns>Returns a  CancelDomainTransferToAnotherAwsAccountResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CancelDomainTransferToAnotherAwsAccount">REST API Reference for CancelDomainTransferToAnotherAwsAccount Operation</seealso>
        public virtual CancelDomainTransferToAnotherAwsAccountResponse EndCancelDomainTransferToAnotherAwsAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDomainTransferToAnotherAwsAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDomainAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual IAsyncResult BeginCheckDomainAvailability(CheckDomainAvailabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDomainAvailability.</param>
        /// 
        /// <returns>Returns a  CheckDomainAvailabilityResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual CheckDomainAvailabilityResponse EndCheckDomainAvailability(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckDomainAvailabilityResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CheckDomainTransferability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDomainTransferability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual IAsyncResult BeginCheckDomainTransferability(CheckDomainTransferabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDomainTransferability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDomainTransferability.</param>
        /// 
        /// <returns>Returns a  CheckDomainTransferabilityResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual CheckDomainTransferabilityResponse EndCheckDomainTransferability(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckDomainTransferabilityResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteTagsForDomain(DeleteTagsForDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTagsForDomain.</param>
        /// 
        /// <returns>Returns a  DeleteTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual DeleteTagsForDomainResponse EndDeleteTagsForDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsForDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDomainAutoRenew
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual IAsyncResult BeginDisableDomainAutoRenew(DisableDomainAutoRenewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDomainAutoRenew.</param>
        /// 
        /// <returns>Returns a  DisableDomainAutoRenewResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual DisableDomainAutoRenewResponse EndDisableDomainAutoRenew(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableDomainAutoRenewResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableDomainTransferLock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual IAsyncResult BeginDisableDomainTransferLock(DisableDomainTransferLockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableDomainTransferLock.</param>
        /// 
        /// <returns>Returns a  DisableDomainTransferLockResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual DisableDomainTransferLockResponse EndDisableDomainTransferLock(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableDomainTransferLockResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateDelegationSignerFromDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegationSignerFromDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDelegationSignerFromDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        public virtual IAsyncResult BeginDisassociateDelegationSignerFromDomain(DisassociateDelegationSignerFromDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDelegationSignerFromDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDelegationSignerFromDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDelegationSignerFromDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDelegationSignerFromDomain.</param>
        /// 
        /// <returns>Returns a  DisassociateDelegationSignerFromDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisassociateDelegationSignerFromDomain">REST API Reference for DisassociateDelegationSignerFromDomain Operation</seealso>
        public virtual DisassociateDelegationSignerFromDomainResponse EndDisassociateDelegationSignerFromDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateDelegationSignerFromDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDomainAutoRenew
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        public virtual IAsyncResult BeginEnableDomainAutoRenew(EnableDomainAutoRenewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainAutoRenewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDomainAutoRenew.</param>
        /// 
        /// <returns>Returns a  EnableDomainAutoRenewResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        public virtual EnableDomainAutoRenewResponse EndEnableDomainAutoRenew(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDomainAutoRenewResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableDomainTransferLock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        public virtual IAsyncResult BeginEnableDomainTransferLock(EnableDomainTransferLockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableDomainTransferLock.</param>
        /// 
        /// <returns>Returns a  EnableDomainTransferLockResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        public virtual EnableDomainTransferLockResponse EndEnableDomainTransferLock(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableDomainTransferLockResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContactReachabilityStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        public virtual IAsyncResult BeginGetContactReachabilityStatus(GetContactReachabilityStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContactReachabilityStatus.</param>
        /// 
        /// <returns>Returns a  GetContactReachabilityStatusResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        public virtual GetContactReachabilityStatusResponse EndGetContactReachabilityStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContactReachabilityStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainDetail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual IAsyncResult BeginGetDomainDetail(GetDomainDetailRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainDetail.</param>
        /// 
        /// <returns>Returns a  GetDomainDetailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual GetDomainDetailResponse EndGetDomainDetail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainDetailResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual IAsyncResult BeginGetDomainSuggestions(GetDomainSuggestionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainSuggestionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainSuggestions.</param>
        /// 
        /// <returns>Returns a  GetDomainSuggestionsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual GetDomainSuggestionsResponse EndGetDomainSuggestions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainSuggestionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperationDetail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual IAsyncResult BeginGetOperationDetail(GetOperationDetailRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperationDetail.</param>
        /// 
        /// <returns>Returns a  GetOperationDetailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual GetOperationDetailResponse EndGetOperationDetail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationDetailResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse EndListOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOperationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListPrices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrices operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        public virtual IAsyncResult BeginListPrices(ListPricesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPricesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrices.</param>
        /// 
        /// <returns>Returns a  ListPricesResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListPrices">REST API Reference for ListPrices Operation</seealso>
        public virtual ListPricesResponse EndListPrices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPricesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual IAsyncResult BeginListTagsForDomain(ListTagsForDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForDomain.</param>
        /// 
        /// <returns>Returns a  ListTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual ListTagsForDomainResponse EndListTagsForDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PushDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PushDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPushDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        public virtual IAsyncResult BeginPushDomain(PushDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PushDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PushDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PushDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPushDomain.</param>
        /// 
        /// <returns>Returns a  PushDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/PushDomain">REST API Reference for PushDomain Operation</seealso>
        public virtual PushDomainResponse EndPushDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<PushDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual IAsyncResult BeginRegisterDomain(RegisterDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDomain.</param>
        /// 
        /// <returns>Returns a  RegisterDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual RegisterDomainResponse EndRegisterDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RejectDomainTransferFromAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainTransferFromAnotherAwsAccount operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectDomainTransferFromAnotherAwsAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual IAsyncResult BeginRejectDomainTransferFromAnotherAwsAccount(RejectDomainTransferFromAnotherAwsAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectDomainTransferFromAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDomainTransferFromAnotherAwsAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectDomainTransferFromAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectDomainTransferFromAnotherAwsAccount.</param>
        /// 
        /// <returns>Returns a  RejectDomainTransferFromAnotherAwsAccountResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RejectDomainTransferFromAnotherAwsAccount">REST API Reference for RejectDomainTransferFromAnotherAwsAccount Operation</seealso>
        public virtual RejectDomainTransferFromAnotherAwsAccountResponse EndRejectDomainTransferFromAnotherAwsAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectDomainTransferFromAnotherAwsAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenewDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        public virtual IAsyncResult BeginRenewDomain(RenewDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenewDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenewDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenewDomain.</param>
        /// 
        /// <returns>Returns a  RenewDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        public virtual RenewDomainResponse EndRenewDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<RenewDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendContactReachabilityEmail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual IAsyncResult BeginResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendContactReachabilityEmail.</param>
        /// 
        /// <returns>Returns a  ResendContactReachabilityEmailResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual ResendContactReachabilityEmailResponse EndResendContactReachabilityEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendContactReachabilityEmailResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ResendOperationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendOperationAuthorization operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendOperationAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        public virtual IAsyncResult BeginResendOperationAuthorization(ResendOperationAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendOperationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendOperationAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendOperationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendOperationAuthorization.</param>
        /// 
        /// <returns>Returns a  ResendOperationAuthorizationResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendOperationAuthorization">REST API Reference for ResendOperationAuthorization Operation</seealso>
        public virtual ResendOperationAuthorizationResponse EndResendOperationAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendOperationAuthorizationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveDomainAuthCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual IAsyncResult BeginRetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveDomainAuthCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveDomainAuthCode.</param>
        /// 
        /// <returns>Returns a  RetrieveDomainAuthCodeResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual RetrieveDomainAuthCodeResponse EndRetrieveDomainAuthCode(IAsyncResult asyncResult)
        {
            return EndInvoke<RetrieveDomainAuthCodeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual IAsyncResult BeginTransferDomain(TransferDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferDomain.</param>
        /// 
        /// <returns>Returns a  TransferDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual TransferDomainResponse EndTransferDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<TransferDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TransferDomainToAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomainToAnotherAwsAccount operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferDomainToAnotherAwsAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        public virtual IAsyncResult BeginTransferDomainToAnotherAwsAccount(TransferDomainToAnotherAwsAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainToAnotherAwsAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainToAnotherAwsAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TransferDomainToAnotherAwsAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferDomainToAnotherAwsAccount.</param>
        /// 
        /// <returns>Returns a  TransferDomainToAnotherAwsAccountResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomainToAnotherAwsAccount">REST API Reference for TransferDomainToAnotherAwsAccount Operation</seealso>
        public virtual TransferDomainToAnotherAwsAccountResponse EndTransferDomainToAnotherAwsAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<TransferDomainToAnotherAwsAccountResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainContact(UpdateDomainContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainContact.</param>
        /// 
        /// <returns>Returns a  UpdateDomainContactResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        public virtual UpdateDomainContactResponse EndUpdateDomainContact(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainContactResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainContactPrivacy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainContactPrivacyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainContactPrivacy.</param>
        /// 
        /// <returns>Returns a  UpdateDomainContactPrivacyResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        public virtual UpdateDomainContactPrivacyResponse EndUpdateDomainContactPrivacy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainContactPrivacyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainNameservers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainNameservers(UpdateDomainNameserversRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameserversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainNameservers.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameserversResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        public virtual UpdateDomainNameserversResponse EndUpdateDomainNameservers(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameserversResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTagsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual IAsyncResult BeginUpdateTagsForDomain(UpdateTagsForDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTagsForDomain.</param>
        /// 
        /// <returns>Returns a  UpdateTagsForDomainResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual UpdateTagsForDomainResponse EndUpdateTagsForDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTagsForDomainResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling operation on AmazonRoute53DomainsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndViewBilling
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual IAsyncResult BeginViewBilling(ViewBillingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ViewBillingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ViewBillingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginViewBilling.</param>
        /// 
        /// <returns>Returns a  ViewBillingResult from Route53Domains.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual ViewBillingResponse EndViewBilling(IAsyncResult asyncResult)
        {
            return EndInvoke<ViewBillingResponse>(asyncResult);
        }

        #endregion
        
    }
}