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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.MarketplaceEntitlementService.Model;
using Amazon.MarketplaceEntitlementService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MarketplaceEntitlementService
{
    /// <summary>
    /// Implementation for accessing MarketplaceEntitlementService
    ///
    /// AWS Marketplace Entitlement Service 
    /// <para>
    /// This reference provides descriptions of the AWS Marketplace Entitlement Service API.
    /// </para>
    ///  
    /// <para>
    /// AWS Marketplace Entitlement Service is used to determine the entitlement of a customer
    /// to a given product. An entitlement represents capacity in a product owned by the customer.
    /// For example, a customer might own some number of users or seats in an SaaS application
    /// or some amount of data capacity in a multi-tenant database.
    /// </para>
    ///  
    /// <para>
    ///  <b>Getting Entitlement Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>GetEntitlements</i>- Gets the entitlements for a Marketplace product.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonMarketplaceEntitlementServiceClient : AmazonServiceClient, IAmazonMarketplaceEntitlementService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with the credentials loaded from the application's
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
        public AmazonMarketplaceEntitlementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceEntitlementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with the credentials loaded from the application's
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
        public AmazonMarketplaceEntitlementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMarketplaceEntitlementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceEntitlementServiceClient Configuration Object</param>
        public AmazonMarketplaceEntitlementServiceClient(AmazonMarketplaceEntitlementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceEntitlementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceEntitlementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceEntitlementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceEntitlementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Credentials and an
        /// AmazonMarketplaceEntitlementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceEntitlementServiceClient Configuration Object</param>
        public AmazonMarketplaceEntitlementServiceClient(AWSCredentials credentials, AmazonMarketplaceEntitlementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceEntitlementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceEntitlementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceEntitlementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceEntitlementServiceClient Configuration Object</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceEntitlementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceEntitlementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceEntitlementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceEntitlementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceEntitlementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceEntitlementServiceClient Configuration Object</param>
        public AmazonMarketplaceEntitlementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceEntitlementServiceConfig clientConfig)
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

        
        #region  GetEntitlements


        /// <summary>
        /// GetEntitlements retrieves entitlement values for a given product. The results can
        /// be filtered based on customer identifier or product dimensions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlements service method.</param>
        /// 
        /// <returns>The response from the GetEntitlements service method, as returned by MarketplaceEntitlementService.</returns>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.InvalidParameterException">
        /// One or more parameters in your request was invalid.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceEntitlementService.Model.ThrottlingException">
        /// The calls to the GetEntitlements API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entitlement.marketplace-2017-01-11/GetEntitlements">REST API Reference for GetEntitlements Operation</seealso>
        public virtual GetEntitlementsResponse GetEntitlements(GetEntitlementsRequest request)
        {
            var marshaller = GetEntitlementsRequestMarshaller.Instance;
            var unmarshaller = GetEntitlementsResponseUnmarshaller.Instance;

            return Invoke<GetEntitlementsRequest,GetEntitlementsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEntitlements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlements operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entitlement.marketplace-2017-01-11/GetEntitlements">REST API Reference for GetEntitlements Operation</seealso>
        public virtual Task<GetEntitlementsResponse> GetEntitlementsAsync(GetEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEntitlementsRequestMarshaller.Instance;
            var unmarshaller = GetEntitlementsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEntitlementsRequest,GetEntitlementsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}