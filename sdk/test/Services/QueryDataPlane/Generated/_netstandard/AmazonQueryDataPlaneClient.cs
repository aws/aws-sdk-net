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
 * Do not modify this file. This file is generated from the querydataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryDataPlane.Model;
using Amazon.QueryDataPlane.Model.Internal.MarshallTransformations;
using Amazon.QueryDataPlane.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QueryDataPlane
{
    /// <summary>
    /// <para>Implementation for accessing QueryDataPlane</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonQueryDataPlaneClient : AmazonServiceClient, IAmazonQueryDataPlane
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryDataPlaneMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with the credentials loaded from the application's
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
        public AmazonQueryDataPlaneClient()
            : base(new AmazonQueryDataPlaneConfig()) { }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with the credentials loaded from the application's
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
        public AmazonQueryDataPlaneClient(RegionEndpoint region)
            : base(new AmazonQueryDataPlaneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryDataPlaneClient Configuration Object</param>
        public AmazonQueryDataPlaneClient(AmazonQueryDataPlaneConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryDataPlaneClient(AWSCredentials credentials)
            : this(credentials, new AmazonQueryDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryDataPlaneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Credentials and an
        /// AmazonQueryDataPlaneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryDataPlaneClient Configuration Object</param>
        public AmazonQueryDataPlaneClient(AWSCredentials credentials, AmazonQueryDataPlaneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryDataPlaneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryDataPlaneClient Configuration Object</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryDataPlaneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryDataPlaneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryDataPlaneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryDataPlaneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryDataPlaneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryDataPlaneClient Configuration Object</param>
        public AmazonQueryDataPlaneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryDataPlaneConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQueryDataPlaneAuthSchemeHandler());
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


        #region  GetMetricData

        internal virtual GetMetricDataResponse GetMetricData(GetMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by QueryDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/querydataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Healthcheck

        internal virtual HealthcheckResponse Healthcheck(HealthcheckRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;

            return Invoke<HealthcheckResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by QueryDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/querydataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        public virtual Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HealthcheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HealthcheckResponseUnmarshaller.Instance;

            return InvokeAsync<HealthcheckResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutMetricData

        internal virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataResponse>(request, options);
        }



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by QueryDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/querydataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}