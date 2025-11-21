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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MobileAnalytics.Model;
using Amazon.MobileAnalytics.Model.Internal.MarshallTransformations;
using Amazon.MobileAnalytics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MobileAnalytics
{
    /// <summary>
    /// <para>Implementation for accessing MobileAnalytics</para>
    ///
    /// Amazon Mobile Analytics is a service for collecting, visualizing, and understanding
    /// app usage data at scale.
    /// </summary>
    public partial class AmazonMobileAnalyticsClient : AmazonServiceClient, IAmazonMobileAnalytics
    {
        private static IServiceMetadata serviceMetadata = new AmazonMobileAnalyticsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with the credentials loaded from the application's
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
        public AmazonMobileAnalyticsClient()
            : base(new AmazonMobileAnalyticsConfig()) { }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with the credentials loaded from the application's
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
        public AmazonMobileAnalyticsClient(RegionEndpoint region)
            : base(new AmazonMobileAnalyticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMobileAnalyticsClient Configuration Object</param>
        public AmazonMobileAnalyticsClient(AmazonMobileAnalyticsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMobileAnalyticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonMobileAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileAnalyticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMobileAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Credentials and an
        /// AmazonMobileAnalyticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMobileAnalyticsClient Configuration Object</param>
        public AmazonMobileAnalyticsClient(AWSCredentials credentials, AmazonMobileAnalyticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMobileAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMobileAnalyticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMobileAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMobileAnalyticsClient Configuration Object</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMobileAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMobileAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMobileAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMobileAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMobileAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMobileAnalyticsClient Configuration Object</param>
        public AmazonMobileAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMobileAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMobileAnalyticsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMobileAnalyticsAuthSchemeHandler());
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


        #region  PutEvents

        internal virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }



        /// <summary>
        /// The PutEvents operation records one or more events. You can have up to 1,500 unique
        /// custom events per app, any combination of up to 40 attributes and metrics per custom
        /// event, and any number of attribute or metric values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by MobileAnalytics.</returns>
        /// <exception cref="Amazon.MobileAnalytics.Model.BadRequestException">
        /// An exception object returned when a request fails.
        /// </exception>
        public virtual Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutEventsResponse>(request, options, cancellationToken);
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