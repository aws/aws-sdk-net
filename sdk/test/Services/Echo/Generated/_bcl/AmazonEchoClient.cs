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
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Echo.Model;
using Amazon.Echo.Model.Internal.MarshallTransformations;
using Amazon.Echo.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Echo
{
    /// <summary>
    /// <para>Implementation for accessing Echo</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonEchoClient : AmazonServiceClient, IAmazonEcho
    {
        private static IServiceMetadata serviceMetadata = new AmazonEchoMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonEchoClient with the credentials loaded from the application's
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
        public AmazonEchoClient()
            : base(new AmazonEchoConfig()) { }

        /// <summary>
        /// Constructs AmazonEchoClient with the credentials loaded from the application's
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
        public AmazonEchoClient(RegionEndpoint region)
            : base(new AmazonEchoConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEchoClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEchoClient Configuration Object</param>
        public AmazonEchoClient(AmazonEchoConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEchoClient(AWSCredentials credentials)
            : this(credentials, new AmazonEchoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEchoClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEchoConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Credentials and an
        /// AmazonEchoClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEchoClient Configuration Object</param>
        public AmazonEchoClient(AWSCredentials credentials, AmazonEchoConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEchoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEchoConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEchoClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEchoClient Configuration Object</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEchoConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEchoConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEchoConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEchoClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEchoClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEchoClient Configuration Object</param>
        public AmazonEchoClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEchoConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.Echo.Internal.EchoCustomHttpHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEchoAuthSchemeHandler());
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


        #region  EchoOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EchoOperation service method.</param>
        /// 
        /// <returns>The response from the EchoOperation service method, as returned by Echo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/echo-2020-07-02/EchoOperation">REST API Reference for EchoOperation Operation</seealso>
        public virtual EchoOperationResponse EchoOperation(EchoOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EchoOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EchoOperationResponseUnmarshaller.Instance;

            return Invoke<EchoOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EchoOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EchoOperation service method, as returned by Echo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/echo-2020-07-02/EchoOperation">REST API Reference for EchoOperation Operation</seealso>
        public virtual Task<EchoOperationResponse> EchoOperationAsync(EchoOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EchoOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EchoOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EchoOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}