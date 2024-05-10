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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FreeTier.Model;
using Amazon.FreeTier.Model.Internal.MarshallTransformations;
using Amazon.FreeTier.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.FreeTier
{
    /// <summary>
    /// <para>Implementation for accessing FreeTier</para>
    ///
    /// You can use the Amazon Web Services Free Tier API to query programmatically your Free
    /// Tier usage data.
    /// 
    ///  
    /// <para>
    /// Free Tier tracks your monthly usage data for all free tier offers that are associated
    /// with your Amazon Web Services account. You can use the Free Tier API to filter and
    /// show only the data that you want.
    /// </para>
    ///  
    /// <para>
    /// Service endpoint
    /// </para>
    ///  
    /// <para>
    /// The Free Tier API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://freetier.us-east-1.api.aws
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-free-tier.html">Using
    /// the Amazon Web Services Free Tier</a> in the <i>Billing User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonFreeTierClient : AmazonServiceClient, IAmazonFreeTier
    {
        private static IServiceMetadata serviceMetadata = new AmazonFreeTierMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonFreeTierClient with the credentials loaded from the application's
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
        public AmazonFreeTierClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFreeTierConfig()) { }

        /// <summary>
        /// Constructs AmazonFreeTierClient with the credentials loaded from the application's
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
        public AmazonFreeTierClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFreeTierConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFreeTierClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFreeTierClient Configuration Object</param>
        public AmazonFreeTierClient(AmazonFreeTierConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFreeTierClient(AWSCredentials credentials)
            : this(credentials, new AmazonFreeTierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFreeTierClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFreeTierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Credentials and an
        /// AmazonFreeTierClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFreeTierClient Configuration Object</param>
        public AmazonFreeTierClient(AWSCredentials credentials, AmazonFreeTierConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFreeTierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFreeTierConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFreeTierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFreeTierClient Configuration Object</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFreeTierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFreeTierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFreeTierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFreeTierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFreeTierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFreeTierClient Configuration Object</param>
        public AmazonFreeTierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFreeTierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IFreeTierPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFreeTierPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FreeTierPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFreeTierEndpointResolver());
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


        #region  GetFreeTierUsage

        internal virtual GetFreeTierUsageResponse GetFreeTierUsage(GetFreeTierUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFreeTierUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFreeTierUsageResponseUnmarshaller.Instance;

            return Invoke<GetFreeTierUsageResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all Free Tier usage objects that match your filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFreeTierUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFreeTierUsage service method, as returned by FreeTier.</returns>
        /// <exception cref="Amazon.FreeTier.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.FreeTier.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FreeTier.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/freetier-2023-09-07/GetFreeTierUsage">REST API Reference for GetFreeTierUsage Operation</seealso>
        public virtual Task<GetFreeTierUsageResponse> GetFreeTierUsageAsync(GetFreeTierUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFreeTierUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFreeTierUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetFreeTierUsageResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonFreeTierEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}