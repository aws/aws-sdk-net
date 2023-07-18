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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Macie.Model;
using Amazon.Macie.Model.Internal.MarshallTransformations;
using Amazon.Macie.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Macie
{
    /// <summary>
    /// Implementation for accessing Macie
    ///
    /// Amazon Macie Classic 
    /// <para>
    /// Amazon Macie Classic has been discontinued and is no longer available.
    /// </para>
    ///  
    /// <para>
    /// A new Amazon Macie is now available with significant design improvements and additional
    /// features, at a lower price and in most Amazon Web Services Regions. We encourage you
    /// to take advantage of the new and improved features, and benefit from the reduced cost.
    /// To learn about features and pricing for the new Macie, see <a href="http://aws.amazon.com/macie/">Amazon
    /// Macie</a>. To learn how to use the new Macie, see the <a href="https://docs.aws.amazon.com/macie/latest/user/what-is-macie.html">Amazon
    /// Macie User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonMacieClient : AmazonServiceClient, IAmazonMacie
    {
        private static IServiceMetadata serviceMetadata = new AmazonMacieMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        public AmazonMacieClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacieConfig()) { }

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        public AmazonMacieClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMacieConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMacieClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(AmazonMacieConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMacieClient(AWSCredentials credentials)
            : this(credentials, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMacieConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Credentials and an
        /// AmazonMacieClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(AWSCredentials credentials, AmazonMacieConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMacieConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacieClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMacieConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacieConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMacieConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMacieClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMacieClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMacieClient Configuration Object</param>
        public AmazonMacieClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMacieConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMaciePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMaciePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MaciePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMacieEndpointResolver());
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


        #region  AssociateMemberAccount

        internal virtual AssociateMemberAccountResponse AssociateMemberAccount(AssociateMemberAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberAccountResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Associates a specified Amazon Web Services account with Amazon Macie
        /// Classic as a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// (Discontinued) The request was rejected because it attempted to create resources beyond
        /// the current Amazon Web Services account quotas. The error code describes the quota
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        public virtual Task<AssociateMemberAccountResponse> AssociateMemberAccountAsync(AssociateMemberAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMemberAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMemberAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateS3Resources

        internal virtual AssociateS3ResourcesResponse AssociateS3Resources(AssociateS3ResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<AssociateS3ResourcesResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Associates specified S3 resources with Amazon Macie Classic for monitoring
        /// and data classification. If <code>memberAccountId</code> isn't specified, the action
        /// associates specified S3 resources with Macie Classic for the current Macie Classic
        /// administrator account. If <code>memberAccountId</code> is specified, the action associates
        /// specified S3 resources with Macie Classic for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// (Discontinued) The request was rejected because it attempted to create resources beyond
        /// the current Amazon Web Services account quotas. The error code describes the quota
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        public virtual Task<AssociateS3ResourcesResponse> AssociateS3ResourcesAsync(AssociateS3ResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateS3ResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateS3ResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberAccount

        internal virtual DisassociateMemberAccountResponse DisassociateMemberAccount(DisassociateMemberAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberAccountResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Removes the specified member account from Amazon Macie Classic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        public virtual Task<DisassociateMemberAccountResponse> DisassociateMemberAccountAsync(DisassociateMemberAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMemberAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMemberAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateS3Resources

        internal virtual DisassociateS3ResourcesResponse DisassociateS3Resources(DisassociateS3ResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<DisassociateS3ResourcesResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Removes specified S3 resources from being monitored by Amazon Macie
        /// Classic. If <code>memberAccountId</code> isn't specified, the action removes specified
        /// S3 resources from Macie Classic for the current Macie Classic administrator account.
        /// If <code>memberAccountId</code> is specified, the action removes specified S3 resources
        /// from Macie Classic for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        public virtual Task<DisassociateS3ResourcesResponse> DisassociateS3ResourcesAsync(DisassociateS3ResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateS3ResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateS3ResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMemberAccounts

        internal virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Lists all Amazon Macie Classic member accounts for the current Macie
        /// Classic administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMemberAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListS3Resources

        internal virtual ListS3ResourcesResponse ListS3Resources(ListS3ResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<ListS3ResourcesResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Lists all the S3 resources associated with Amazon Macie Classic. If
        /// <code>memberAccountId</code> isn't specified, the action lists the S3 resources associated
        /// with Macie Classic for the current Macie Classic administrator account. If <code>memberAccountId</code>
        /// is specified, the action lists the S3 resources associated with Macie Classic for
        /// the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        public virtual Task<ListS3ResourcesResponse> ListS3ResourcesAsync(ListS3ResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3ResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListS3ResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateS3Resources

        internal virtual UpdateS3ResourcesResponse UpdateS3Resources(UpdateS3ResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateS3ResourcesResponseUnmarshaller.Instance;

            return Invoke<UpdateS3ResourcesResponse>(request, options);
        }



        /// <summary>
        /// (Discontinued) Updates the classification types for the specified S3 resources. If
        /// <code>memberAccountId</code> isn't specified, the action updates the classification
        /// types of the S3 resources associated with Amazon Macie Classic for the current Macie
        /// Classic administrator account. If <code>memberAccountId</code> is specified, the action
        /// updates the classification types of the S3 resources associated with Macie Classic
        /// for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        public virtual Task<UpdateS3ResourcesResponse> UpdateS3ResourcesAsync(UpdateS3ResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateS3ResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateS3ResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateS3ResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}