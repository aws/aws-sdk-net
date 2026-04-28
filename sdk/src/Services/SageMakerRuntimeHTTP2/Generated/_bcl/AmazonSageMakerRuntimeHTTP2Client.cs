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
 * Do not modify this file. This file is generated from the sagemaker-runtime-http2-2025-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerRuntimeHTTP2.Model;
using Amazon.SageMakerRuntimeHTTP2.Model.Internal.MarshallTransformations;
using Amazon.SageMakerRuntimeHTTP2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SageMakerRuntimeHTTP2
{
    /// <summary>
    /// <para>Implementation for accessing SageMakerRuntimeHTTP2</para>
    ///
    /// The Amazon SageMaker AI runtime HTTP/2 API.
    /// </summary>
    public partial class AmazonSageMakerRuntimeHTTP2Client : AmazonServiceClient, IAmazonSageMakerRuntimeHTTP2
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerRuntimeHTTP2Metadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeHTTP2Client()
            : base(new AmazonSageMakerRuntimeHTTP2Config()) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        public AmazonSageMakerRuntimeHTTP2Client(RegionEndpoint region)
            : base(new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(AmazonSageMakerRuntimeHTTP2Config config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Credentials and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(AWSCredentials credentials, AmazonSageMakerRuntimeHTTP2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerRuntimeHTTP2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerRuntimeHTTP2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeHTTP2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerRuntimeHTTP2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerRuntimeHTTP2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerRuntimeHTTP2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerRuntimeHTTP2Client Configuration Object</param>
        public AmazonSageMakerRuntimeHTTP2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerRuntimeHTTP2Config clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeHTTP2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerRuntimeHTTP2AuthSchemeHandler());
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