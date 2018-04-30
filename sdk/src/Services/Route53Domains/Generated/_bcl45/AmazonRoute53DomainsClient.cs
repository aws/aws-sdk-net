/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Route53Domains.Model;
using Amazon.Route53Domains.Model.Internal.MarshallTransformations;
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request)
        {
            var marshaller = CheckDomainAvailabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDomainAvailabilityRequest,CheckDomainAvailabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainAvailability">REST API Reference for CheckDomainAvailability Operation</seealso>
        public virtual Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CheckDomainAvailabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDomainAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDomainAvailabilityRequest,CheckDomainAvailabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual CheckDomainTransferabilityResponse CheckDomainTransferability(CheckDomainTransferabilityRequest request)
        {
            var marshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDomainTransferabilityRequest,CheckDomainTransferabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainTransferability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual Task<CheckDomainTransferabilityResponse> CheckDomainTransferabilityAsync(CheckDomainTransferabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            var unmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDomainTransferabilityRequest,CheckDomainTransferabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsForDomainRequest,DeleteTagsForDomainResponse>(request, marshaller, unmarshaller);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the DeleteTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DeleteTagsForDomain">REST API Reference for DeleteTagsForDomain Operation</seealso>
        public virtual Task<DeleteTagsForDomainResponse> DeleteTagsForDomainAsync(DeleteTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsForDomainRequest,DeleteTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request)
        {
            var marshaller = DisableDomainAutoRenewRequestMarshaller.Instance;
            var unmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<DisableDomainAutoRenewRequest,DisableDomainAutoRenewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainAutoRenew">REST API Reference for DisableDomainAutoRenew Operation</seealso>
        public virtual Task<DisableDomainAutoRenewResponse> DisableDomainAutoRenewAsync(DisableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableDomainAutoRenewRequestMarshaller.Instance;
            var unmarshaller = DisableDomainAutoRenewResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDomainAutoRenewRequest,DisableDomainAutoRenewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            var unmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<DisableDomainTransferLockRequest,DisableDomainTransferLockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            var unmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDomainTransferLockRequest,DisableDomainTransferLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainAutoRenew


        /// <summary>
        /// This operation configures Amazon Route 53 to automatically renew the specified domain
        /// before the domain registration expires. The cost of renewing your domain registration
        /// is billed to your AWS account.
        /// 
        ///  
        /// <para>
        /// The period during which you can renew a domain name varies by TLD. For a list of TLDs
        /// and their renewal policies, see <a href="http://wiki.gandi.net/en/domains/renew#renewal_restoration_and_deletion_times">"Renewal,
        /// restoration, and deletion times"</a> on the website for our registrar associate, Gandi.
        /// Amazon Route 53 requires that you renew before the end of the renewal period that
        /// is listed on the Gandi website so we can complete processing before the deadline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew service method.</param>
        /// 
        /// <returns>The response from the EnableDomainAutoRenew service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = EnableDomainAutoRenewRequestMarshaller.Instance;
            var unmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return Invoke<EnableDomainAutoRenewRequest,EnableDomainAutoRenewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainAutoRenew operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainAutoRenew">REST API Reference for EnableDomainAutoRenew Operation</seealso>
        public virtual Task<EnableDomainAutoRenewResponse> EnableDomainAutoRenewAsync(EnableDomainAutoRenewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableDomainAutoRenewRequestMarshaller.Instance;
            var unmarshaller = EnableDomainAutoRenewResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDomainAutoRenewRequest,EnableDomainAutoRenewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = EnableDomainTransferLockRequestMarshaller.Instance;
            var unmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return Invoke<EnableDomainTransferLockRequest,EnableDomainTransferLockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/EnableDomainTransferLock">REST API Reference for EnableDomainTransferLock Operation</seealso>
        public virtual Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableDomainTransferLockRequestMarshaller.Instance;
            var unmarshaller = EnableDomainTransferLockResponseUnmarshaller.Instance;

            return InvokeAsync<EnableDomainTransferLockRequest,EnableDomainTransferLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
            var unmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return Invoke<GetContactReachabilityStatusRequest,GetContactReachabilityStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContactReachabilityStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetContactReachabilityStatus">REST API Reference for GetContactReachabilityStatus Operation</seealso>
        public virtual Task<GetContactReachabilityStatusResponse> GetContactReachabilityStatusAsync(GetContactReachabilityStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetContactReachabilityStatusRequestMarshaller.Instance;
            var unmarshaller = GetContactReachabilityStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactReachabilityStatusRequest,GetContactReachabilityStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainDetail


        /// <summary>
        /// This operation returns detailed information about a specified domain that is associated
        /// with the current AWS account. Contact information for the domain is also returned
        /// as part of the output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail service method.</param>
        /// 
        /// <returns>The response from the GetDomainDetail service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request)
        {
            var marshaller = GetDomainDetailRequestMarshaller.Instance;
            var unmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return Invoke<GetDomainDetailRequest,GetDomainDetailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainDetail">REST API Reference for GetDomainDetail Operation</seealso>
        public virtual Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDomainDetailRequestMarshaller.Instance;
            var unmarshaller = GetDomainDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainDetailRequest,GetDomainDetailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainSuggestions


        /// <summary>
        /// The GetDomainSuggestions operation returns a list of suggested domain names given
        /// a string, which can either be a domain name or simply a word or phrase (without spaces).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetDomainSuggestions service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request)
        {
            var marshaller = GetDomainSuggestionsRequestMarshaller.Instance;
            var unmarshaller = GetDomainSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetDomainSuggestionsRequest,GetDomainSuggestionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetDomainSuggestions">REST API Reference for GetDomainSuggestions Operation</seealso>
        public virtual Task<GetDomainSuggestionsResponse> GetDomainSuggestionsAsync(GetDomainSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDomainSuggestionsRequestMarshaller.Instance;
            var unmarshaller = GetDomainSuggestionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainSuggestionsRequest,GetDomainSuggestionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request)
        {
            var marshaller = GetOperationDetailRequestMarshaller.Instance;
            var unmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return Invoke<GetOperationDetailRequest,GetOperationDetailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/GetOperationDetail">REST API Reference for GetOperationDetail Operation</seealso>
        public virtual Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetOperationDetailRequestMarshaller.Instance;
            var unmarshaller = GetOperationDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationDetailRequest,GetOperationDetailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var marshaller = ListDomainsRequestMarshaller.Instance;
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsRequest,ListDomainsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation returns all the domain names registered with Amazon Route 53 for the
        /// current AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDomainsAsync(new ListDomainsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDomainsRequestMarshaller.Instance;
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsRequest,ListDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations()
        {
            return ListOperations(new ListOperationsRequest());
        }


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var marshaller = ListOperationsRequestMarshaller.Instance;
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsRequest,ListOperationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation returns the operation IDs of operations that are not yet complete.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListOperationsAsync(new ListOperationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListOperationsRequestMarshaller.Instance;
            var unmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOperationsRequest,ListOperationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = ListTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<ListTagsForDomainRequest,ListTagsForDomainResponse>(request, marshaller, unmarshaller);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the ListTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ListTagsForDomain">REST API Reference for ListTagsForDomain Operation</seealso>
        public virtual Task<ListTagsForDomainResponse> ListTagsForDomainAsync(ListTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForDomainRequest,ListTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// Creates a Amazon Route 53 hosted zone that has the same name as the domain. Amazon
        /// Route 53 assigns four name servers to your hosted zone and automatically updates your
        /// domain registration with the names of these name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enables autorenew, so your domain registration will renew automatically each year.
        /// We'll notify you in advance of the renewal date so you can choose whether to renew
        /// the registration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optionally enables privacy protection, so WHOIS queries return contact information
        /// either for Amazon Registrar (for .com, .net, and .org domains) or for our registrar
        /// associate, Gandi (for all other TLDs). If you don't enable privacy protection, WHOIS
        /// queries return the information that you entered for the registrant, admin, and tech
        /// contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If registration is successful, returns an operation ID that you can use to track the
        /// progress and completion of the action. If the request is not completed successfully,
        /// the domain registrant is notified by email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Charges your AWS account an amount based on the top-level domain. For more information,
        /// see <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53 Pricing</a>.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = RegisterDomainRequestMarshaller.Instance;
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterDomainRequestMarshaller.Instance;
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RenewDomain


        /// <summary>
        /// This operation renews a domain for the specified number of years. The cost of renewing
        /// your domain is billed to your AWS account.
        /// 
        ///  
        /// <para>
        /// We recommend that you renew your domain several weeks before the expiration date.
        /// Some TLD registries delete domains before the expiration date if you haven't renewed
        /// far enough in advance. For more information about renewing domain registration, see
        /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-renew.html">Renewing
        /// Registration for a Domain</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain service method.</param>
        /// 
        /// <returns>The response from the RenewDomain service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = RenewDomainRequestMarshaller.Instance;
            var unmarshaller = RenewDomainResponseUnmarshaller.Instance;

            return Invoke<RenewDomainRequest,RenewDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RenewDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RenewDomain">REST API Reference for RenewDomain Operation</seealso>
        public virtual Task<RenewDomainResponse> RenewDomainAsync(RenewDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RenewDomainRequestMarshaller.Instance;
            var unmarshaller = RenewDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RenewDomainRequest,RenewDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            var unmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return Invoke<ResendContactReachabilityEmailRequest,ResendContactReachabilityEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendContactReachabilityEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            var unmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendContactReachabilityEmailRequest,ResendContactReachabilityEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// This operation returns the AuthCode for the domain. To transfer a domain to another
        /// registrar, you provide this value to the new registrar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode service method.</param>
        /// 
        /// <returns>The response from the RetrieveDomainAuthCode service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.UnsupportedTLDException">
        /// Amazon Route 53 does not support this top-level domain (TLD).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request)
        {
            var marshaller = RetrieveDomainAuthCodeRequestMarshaller.Instance;
            var unmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return Invoke<RetrieveDomainAuthCodeRequest,RetrieveDomainAuthCodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RetrieveDomainAuthCode">REST API Reference for RetrieveDomainAuthCode Operation</seealso>
        public virtual Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RetrieveDomainAuthCodeRequestMarshaller.Instance;
            var unmarshaller = RetrieveDomainAuthCodeResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveDomainAuthCodeRequest,RetrieveDomainAuthCodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TransferDomain


        /// <summary>
        /// This operation transfers a domain from another registrar to Amazon Route 53. When
        /// the transfer is complete, the domain is registered either with Amazon Registrar (for
        /// .com, .net, and .org domains) or with our registrar associate, Gandi (for all other
        /// TLDs).
        /// 
        ///  
        /// <para>
        /// For transfer requirements, a detailed procedure, and information about viewing the
        /// status of a domain transfer, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/domain-transfer-to-route-53.html">Transferring
        /// Registration for a Domain to Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the registrar for your domain is also the DNS service provider for the domain,
        /// we highly recommend that you consider transferring your DNS service to Amazon Route
        /// 53 or to another DNS service provider before you transfer your registration. Some
        /// registrars provide free DNS service when you purchase a domain registration. When
        /// you transfer the registration, the previous registrar will not renew your domain registration
        /// and could end your DNS service at any time.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = TransferDomainRequestMarshaller.Instance;
            var unmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return Invoke<TransferDomainRequest,TransferDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TransferDomainRequestMarshaller.Instance;
            var unmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return InvokeAsync<TransferDomainRequest,TransferDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// to track the progress and completion of the action. If the request is not completed
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = UpdateDomainContactRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactRequest,UpdateDomainContactResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContact">REST API Reference for UpdateDomainContact Operation</seealso>
        public virtual Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDomainContactRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainContactResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainContactRequest,UpdateDomainContactResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// This operation updates the specified domain contact's privacy setting. When privacy
        /// protection is enabled, contact information such as email address is replaced either
        /// with contact information for Amazon Registrar (for .com, .net, and .org domains) or
        /// with contact information for our registrar associate, Gandi.
        /// 
        ///  
        /// <para>
        /// This operation affects only the contact information for the specified contact type
        /// (registrant, administrator, or tech). If the request succeeds, Amazon Route 53 returns
        /// an operation ID that you can use with <a>GetOperationDetail</a> to track the progress
        /// and completion of the action. If the request doesn't complete successfully, the domain
        /// registrant will be notified by email.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainContactPrivacy service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.DuplicateRequestException">
        /// The request is already in progress for the domain.
        /// </exception>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = UpdateDomainContactPrivacyRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainContactPrivacyRequest,UpdateDomainContactPrivacyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainContactPrivacy">REST API Reference for UpdateDomainContactPrivacy Operation</seealso>
        public virtual Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDomainContactPrivacyRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainContactPrivacyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainContactPrivacyRequest,UpdateDomainContactPrivacyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = UpdateDomainNameserversRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameserversRequest,UpdateDomainNameserversResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateDomainNameservers">REST API Reference for UpdateDomainNameservers Operation</seealso>
        public virtual Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDomainNameserversRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameserversResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameserversRequest,UpdateDomainNameserversResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
            var marshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForDomainRequest,UpdateTagsForDomainResponse>(request, marshaller, unmarshaller);
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
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
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
        /// Initiates the asynchronous execution of the UpdateTagsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/UpdateTagsForDomain">REST API Reference for UpdateTagsForDomain Operation</seealso>
        public virtual Task<UpdateTagsForDomainResponse> UpdateTagsForDomainAsync(UpdateTagsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            var unmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagsForDomainRequest,UpdateTagsForDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ViewBilling


        /// <summary>
        /// Returns all the domain-related billing records for the current AWS account for a specified
        /// period
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling service method.</param>
        /// 
        /// <returns>The response from the ViewBilling service method, as returned by Route53Domains.</returns>
        /// <exception cref="Amazon.Route53Domains.Model.InvalidInputException">
        /// The requested item is not acceptable. For example, for an OperationId it might refer
        /// to the ID of an operation that is already completed. For a domain name, it might not
        /// be a valid domain name or belong to the requester account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual ViewBillingResponse ViewBilling(ViewBillingRequest request)
        {
            var marshaller = ViewBillingRequestMarshaller.Instance;
            var unmarshaller = ViewBillingResponseUnmarshaller.Instance;

            return Invoke<ViewBillingRequest,ViewBillingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ViewBilling operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ViewBilling">REST API Reference for ViewBilling Operation</seealso>
        public virtual Task<ViewBillingResponse> ViewBillingAsync(ViewBillingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ViewBillingRequestMarshaller.Instance;
            var unmarshaller = ViewBillingResponseUnmarshaller.Instance;

            return InvokeAsync<ViewBillingRequest,ViewBillingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}