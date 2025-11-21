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
 * Do not modify this file. This file is generated from the use-service-id-2022-07-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.UseServiceIdTestserviceId.Model;
using Amazon.UseServiceIdTestserviceId.Model.Internal.MarshallTransformations;
using Amazon.UseServiceIdTestserviceId.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.UseServiceIdTestserviceId
{
    /// <summary>
    /// <para>Implementation for accessing UseServiceIdTestserviceId</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonUseServiceIdTestserviceIdClient : AmazonServiceClient, IAmazonUseServiceIdTestserviceId
    {
        private static IServiceMetadata serviceMetadata = new AmazonUseServiceIdTestserviceIdMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with the credentials loaded from the application's
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
        public AmazonUseServiceIdTestserviceIdClient()
            : base(new AmazonUseServiceIdTestserviceIdConfig()) { }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with the credentials loaded from the application's
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
        public AmazonUseServiceIdTestserviceIdClient(RegionEndpoint region)
            : base(new AmazonUseServiceIdTestserviceIdConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonUseServiceIdTestserviceIdClient Configuration Object</param>
        public AmazonUseServiceIdTestserviceIdClient(AmazonUseServiceIdTestserviceIdConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonUseServiceIdTestserviceIdClient(AWSCredentials credentials)
            : this(credentials, new AmazonUseServiceIdTestserviceIdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonUseServiceIdTestserviceIdClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonUseServiceIdTestserviceIdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Credentials and an
        /// AmazonUseServiceIdTestserviceIdClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonUseServiceIdTestserviceIdClient Configuration Object</param>
        public AmazonUseServiceIdTestserviceIdClient(AWSCredentials credentials, AmazonUseServiceIdTestserviceIdConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonUseServiceIdTestserviceIdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonUseServiceIdTestserviceIdConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonUseServiceIdTestserviceIdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonUseServiceIdTestserviceIdClient Configuration Object</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonUseServiceIdTestserviceIdConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonUseServiceIdTestserviceIdConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonUseServiceIdTestserviceIdConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonUseServiceIdTestserviceIdClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonUseServiceIdTestserviceIdClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonUseServiceIdTestserviceIdClient Configuration Object</param>
        public AmazonUseServiceIdTestserviceIdClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonUseServiceIdTestserviceIdConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonUseServiceIdTestserviceIdAuthSchemeHandler());
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


        #region  NoPayload

        internal virtual NoPayloadResponse NoPayload(NoPayloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return Invoke<NoPayloadResponse>(request, options);
        }



        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by UseServiceIdTestserviceId.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/use-service-id-2022-07-12/NoPayload">REST API Reference for NoPayload Operation</seealso>
        public virtual Task<NoPayloadResponse> NoPayloadAsync(NoPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoPayloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoPayloadResponseUnmarshaller.Instance;

            return InvokeAsync<NoPayloadResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}