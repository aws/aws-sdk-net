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
 * Do not modify this file. This file is generated from the numerictypescbor-2026-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NumericTypesCbor.Model;
using Amazon.NumericTypesCbor.Model.Internal.MarshallTransformations;
using Amazon.NumericTypesCbor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NumericTypesCbor
{
    /// <summary>
    /// <para>Implementation for accessing NumericTypesCbor</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonNumericTypesCborClient : AmazonServiceClient, IAmazonNumericTypesCbor
    {
        private static IServiceMetadata serviceMetadata = new AmazonNumericTypesCborMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with the credentials loaded from the application's
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
        public AmazonNumericTypesCborClient()
            : base(new AmazonNumericTypesCborConfig()) { }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with the credentials loaded from the application's
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
        public AmazonNumericTypesCborClient(RegionEndpoint region)
            : base(new AmazonNumericTypesCborConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNumericTypesCborClient Configuration Object</param>
        public AmazonNumericTypesCborClient(AmazonNumericTypesCborConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNumericTypesCborClient(AWSCredentials credentials)
            : this(credentials, new AmazonNumericTypesCborConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesCborClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNumericTypesCborConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Credentials and an
        /// AmazonNumericTypesCborClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNumericTypesCborClient Configuration Object</param>
        public AmazonNumericTypesCborClient(AWSCredentials credentials, AmazonNumericTypesCborConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesCborConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesCborConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesCborClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNumericTypesCborClient Configuration Object</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNumericTypesCborConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesCborConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesCborConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesCborClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesCborClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNumericTypesCborClient Configuration Object</param>
        public AmazonNumericTypesCborClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNumericTypesCborConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNumericTypesCborAuthSchemeHandler());
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


        #region  BodyNumbers

        internal virtual BodyNumbersResponse BodyNumbers(BodyNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyNumbersResponseUnmarshaller.Instance;

            return Invoke<BodyNumbersResponse>(request, options);
        }



        /// <summary>
        /// Sends and receives every numeric type in the request and response bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BodyNumbers service method, as returned by NumericTypesCbor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypescbor-2026-10-26/BodyNumbers">REST API Reference for BodyNumbers Operation</seealso>
        public virtual Task<BodyNumbersResponse> BodyNumbersAsync(BodyNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BodyNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BodyNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<BodyNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}