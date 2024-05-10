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
 * Do not modify this file. This file is generated from the ep2-host-label-2022-08-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Ep2hostlabel.Model;
using Amazon.Ep2hostlabel.Model.Internal.MarshallTransformations;
using Amazon.Ep2hostlabel.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Ep2hostlabel
{
    /// <summary>
    /// <para>Implementation for accessing Ep2hostlabel</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonEp2hostlabelClient : AmazonServiceClient, IAmazonEp2hostlabel
    {
        private static IServiceMetadata serviceMetadata = new AmazonEp2hostlabelMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with the credentials loaded from the application's
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
        public AmazonEp2hostlabelClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEp2hostlabelConfig()) { }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with the credentials loaded from the application's
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
        public AmazonEp2hostlabelClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEp2hostlabelConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEp2hostlabelClient Configuration Object</param>
        public AmazonEp2hostlabelClient(AmazonEp2hostlabelConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEp2hostlabelClient(AWSCredentials credentials)
            : this(credentials, new AmazonEp2hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2hostlabelClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEp2hostlabelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Credentials and an
        /// AmazonEp2hostlabelClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEp2hostlabelClient Configuration Object</param>
        public AmazonEp2hostlabelClient(AWSCredentials credentials, AmazonEp2hostlabelConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2hostlabelConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2hostlabelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEp2hostlabelClient Configuration Object</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEp2hostlabelConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2hostlabelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2hostlabelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2hostlabelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEp2hostlabelClient Configuration Object</param>
        public AmazonEp2hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEp2hostlabelConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2hostlabelEndpointResolver());
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
        /// <returns>The response from the MyOperation service method, as returned by Ep2hostlabel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-host-label-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        public virtual MyOperationResponse MyOperation(MyOperationRequest request)
        {
            var options = new InvokeOptions();
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
        /// <returns>The response from the MyOperation service method, as returned by Ep2hostlabel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-host-label-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        public virtual Task<MyOperationResponse> MyOperationAsync(MyOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonEp2hostlabelEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}