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
 * Do not modify this file. This file is generated from the ep2-parse-arn-2022-08-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Ep2parsearn.Model;
using Amazon.Ep2parsearn.Model.Internal.MarshallTransformations;
using Amazon.Ep2parsearn.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Ep2parsearn
{
    /// <summary>
    /// <para>Implementation for accessing Ep2parsearn</para>
    ///
    /// Endpoints 2.0 parse-arn tests
    /// </summary>
    public partial class AmazonEp2parsearnClient : AmazonServiceClient, IAmazonEp2parsearn
    {
        private static IServiceMetadata serviceMetadata = new AmazonEp2parsearnMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with the credentials loaded from the application's
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
        public AmazonEp2parsearnClient()
            : base(new AmazonEp2parsearnConfig()) { }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with the credentials loaded from the application's
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
        public AmazonEp2parsearnClient(RegionEndpoint region)
            : base(new AmazonEp2parsearnConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEp2parsearnClient Configuration Object</param>
        public AmazonEp2parsearnClient(AmazonEp2parsearnConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEp2parsearnClient(AWSCredentials credentials)
            : this(credentials, new AmazonEp2parsearnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2parsearnClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEp2parsearnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Credentials and an
        /// AmazonEp2parsearnClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEp2parsearnClient Configuration Object</param>
        public AmazonEp2parsearnClient(AWSCredentials credentials, AmazonEp2parsearnConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2parsearnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2parsearnConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2parsearnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEp2parsearnClient Configuration Object</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEp2parsearnConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2parsearnConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2parsearnConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2parsearnClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2parsearnClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEp2parsearnClient Configuration Object</param>
        public AmazonEp2parsearnClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEp2parsearnConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2parsearnEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2parsearnAuthSchemeHandler());
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


        #region  MyOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MyOperation service method.</param>
        /// 
        /// <returns>The response from the MyOperation service method, as returned by Ep2parsearn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-parse-arn-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        public virtual MyOperationResponse MyOperation(MyOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MyOperationResponseUnmarshaller.Instance;

            return Invoke<MyOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MyOperation service method, as returned by Ep2parsearn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-parse-arn-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        public virtual Task<MyOperationResponse> MyOperationAsync(MyOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MyOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<MyOperationResponse>(request, options, cancellationToken);
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