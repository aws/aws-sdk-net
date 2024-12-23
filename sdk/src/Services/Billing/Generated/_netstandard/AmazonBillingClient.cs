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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Billing.Model;
using Amazon.Billing.Model.Internal.MarshallTransformations;
using Amazon.Billing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Billing
{
    /// <summary>
    /// <para>Implementation for accessing Billing</para>
    ///
    /// You can use the Billing API to programatically list the billing views available to
    /// you for a given time period. A billing view represents a set of billing data. 
    /// 
    ///  
    /// <para>
    /// The Billing API provides the following endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <c>https://billing.us-east-1.api.aws</c> 
    /// </para>
    /// </summary>
    public partial class AmazonBillingClient : AmazonServiceClient, IAmazonBilling
    {
        private static IServiceMetadata serviceMetadata = new AmazonBillingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        public AmazonBillingClient()
            : base(new AmazonBillingConfig()) { }

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        public AmazonBillingClient(RegionEndpoint region)
            : base(new AmazonBillingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(AmazonBillingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBillingClient(AWSCredentials credentials)
            : this(credentials, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBillingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials and an
        /// AmazonBillingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(AWSCredentials credentials, AmazonBillingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBillingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBillingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBillingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBillingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BillingPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingAuthSchemeHandler());
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


        #region  ListBillingViews

        internal virtual ListBillingViewsResponse ListBillingViews(ListBillingViewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingViewsResponseUnmarshaller.Instance;

            return Invoke<ListBillingViewsResponse>(request, options);
        }



        /// <summary>
        /// Lists the billing views available for a given time period. 
        /// 
        ///  
        /// <para>
        /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
        /// the billing data available by default. Accounts that use Billing Conductor also have
        /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
        /// created billing group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        public virtual Task<ListBillingViewsResponse> ListBillingViewsAsync(ListBillingViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBillingViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingViewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillingViewsResponse>(request, options, cancellationToken);
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