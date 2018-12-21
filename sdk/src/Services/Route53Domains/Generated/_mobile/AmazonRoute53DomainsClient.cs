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
        
        #region Constructors

#if CORECLR
    
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

#endif

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


        #region  CheckDomainAvailability

        internal virtual CheckDomainAvailabilityResponse CheckDomainAvailability(CheckDomainAvailabilityRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual CheckDomainTransferabilityResponse CheckDomainTransferability(CheckDomainTransferabilityRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainTransferability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/CheckDomainTransferability">REST API Reference for CheckDomainTransferability Operation</seealso>
        public virtual Task<CheckDomainTransferabilityResponse> CheckDomainTransferabilityAsync(CheckDomainTransferabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDomainTransferabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDomainTransferabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDomainTransferabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTagsForDomain

        internal virtual DeleteTagsForDomainResponse DeleteTagsForDomain(DeleteTagsForDomainRequest request)
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDomainAutoRenew

        internal virtual DisableDomainAutoRenewResponse DisableDomainAutoRenew(DisableDomainAutoRenewRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual DisableDomainTransferLockResponse DisableDomainTransferLock(DisableDomainTransferLockRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/DisableDomainTransferLock">REST API Reference for DisableDomainTransferLock Operation</seealso>
        public virtual Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableDomainTransferLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDomainTransferLockResponseUnmarshaller.Instance;

            return InvokeAsync<DisableDomainTransferLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDomainAutoRenew

        internal virtual EnableDomainAutoRenewResponse EnableDomainAutoRenew(EnableDomainAutoRenewRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainAutoRenew operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual EnableDomainTransferLockResponse EnableDomainTransferLock(EnableDomainTransferLockRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual GetContactReachabilityStatusResponse GetContactReachabilityStatus(GetContactReachabilityStatusRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetContactReachabilityStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual GetDomainDetailResponse GetDomainDetail(GetDomainDetailRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual GetDomainSuggestionsResponse GetDomainSuggestions(GetDomainSuggestionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetDomainSuggestions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual GetOperationDetailResponse GetOperationDetail(GetOperationDetailRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ListDomainsResponse ListDomains()
        {
            return ListDomains(new ListDomainsRequest());
        }
        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOperations

        internal virtual ListOperationsResponse ListOperations()
        {
            return ListOperations(new ListOperationsRequest());
        }
        internal virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForDomain

        internal virtual ListTagsForDomainResponse ListTagsForDomain(ListTagsForDomainRequest request)
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain

        internal virtual RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenewDomain

        internal virtual RenewDomainResponse RenewDomain(RenewDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RenewDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual ResendContactReachabilityEmailResponse ResendContactReachabilityEmail(ResendContactReachabilityEmailRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ResendContactReachabilityEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/ResendContactReachabilityEmail">REST API Reference for ResendContactReachabilityEmail Operation</seealso>
        public virtual Task<ResendContactReachabilityEmailResponse> ResendContactReachabilityEmailAsync(ResendContactReachabilityEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendContactReachabilityEmailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendContactReachabilityEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendContactReachabilityEmailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveDomainAuthCode

        internal virtual RetrieveDomainAuthCodeResponse RetrieveDomainAuthCode(RetrieveDomainAuthCodeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual TransferDomainResponse TransferDomain(TransferDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53domains-2014-05-15/TransferDomain">REST API Reference for TransferDomain Operation</seealso>
        public virtual Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TransferDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransferDomainResponseUnmarshaller.Instance;

            return InvokeAsync<TransferDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainContact

        internal virtual UpdateDomainContactResponse UpdateDomainContact(UpdateDomainContactRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual UpdateDomainContactPrivacyResponse UpdateDomainContactPrivacy(UpdateDomainContactPrivacyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual UpdateDomainNameserversResponse UpdateDomainNameservers(UpdateDomainNameserversRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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

        internal virtual UpdateTagsForDomainResponse UpdateTagsForDomain(UpdateTagsForDomainRequest request)
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagsForDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ViewBilling

        internal virtual ViewBillingResponse ViewBilling(ViewBillingRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ViewBilling operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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