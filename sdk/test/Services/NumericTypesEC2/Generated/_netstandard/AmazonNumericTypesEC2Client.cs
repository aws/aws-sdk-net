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
 * Do not modify this file. This file is generated from the numerictypesec2-2026-10-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NumericTypesEC2.Model;
using Amazon.NumericTypesEC2.Model.Internal.MarshallTransformations;
using Amazon.NumericTypesEC2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NumericTypesEC2
{
    /// <summary>
    /// <para>Implementation for accessing NumericTypesEC2</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// 
    /// </summary>
    public partial class AmazonNumericTypesEC2Client : AmazonServiceClient, IAmazonNumericTypesEC2
    {
        private static IServiceMetadata serviceMetadata = new AmazonNumericTypesEC2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with the credentials loaded from the application's
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
        public AmazonNumericTypesEC2Client()
            : base(new AmazonNumericTypesEC2Config()) { }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with the credentials loaded from the application's
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
        public AmazonNumericTypesEC2Client(RegionEndpoint region)
            : base(new AmazonNumericTypesEC2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNumericTypesEC2Client Configuration Object</param>
        public AmazonNumericTypesEC2Client(AmazonNumericTypesEC2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNumericTypesEC2Client(AWSCredentials credentials)
            : this(credentials, new AmazonNumericTypesEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesEC2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNumericTypesEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Credentials and an
        /// AmazonNumericTypesEC2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNumericTypesEC2Client Configuration Object</param>
        public AmazonNumericTypesEC2Client(AWSCredentials credentials, AmazonNumericTypesEC2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNumericTypesEC2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNumericTypesEC2Client Configuration Object</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonNumericTypesEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNumericTypesEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNumericTypesEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNumericTypesEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNumericTypesEC2Client Configuration Object</param>
        public AmazonNumericTypesEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNumericTypesEC2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNumericTypesEC2AuthSchemeHandler());
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
        /// <returns>The response from the BodyNumbers service method, as returned by NumericTypesEC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypesec2-2026-10-26/BodyNumbers">REST API Reference for BodyNumbers Operation</seealso>
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