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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Ep2complexparameters.Model;
using Amazon.Ep2complexparameters.Model.Internal.MarshallTransformations;
using Amazon.Ep2complexparameters.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Ep2complexparameters
{
    /// <summary>
    /// <para>Implementation for accessing Ep2complexparameters</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonEp2complexparametersClient : AmazonServiceClient, IAmazonEp2complexparameters
    {
        private static IServiceMetadata serviceMetadata = new AmazonEp2complexparametersMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        public AmazonEp2complexparametersClient()
            : base(new AmazonEp2complexparametersConfig()) { }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        public AmazonEp2complexparametersClient(RegionEndpoint region)
            : base(new AmazonEp2complexparametersConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(AmazonEp2complexparametersConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials)
            : this(credentials, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEp2complexparametersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Credentials and an
        /// AmazonEp2complexparametersClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(AWSCredentials credentials, AmazonEp2complexparametersConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2complexparametersConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2complexparametersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEp2complexparametersConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2complexparametersConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2complexparametersConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2complexparametersClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2complexparametersClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEp2complexparametersClient Configuration Object</param>
        public AmazonEp2complexparametersClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEp2complexparametersConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2complexparametersEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2complexparametersAuthSchemeHandler());
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


        #region  EmptyStaticContextOperation

        internal virtual EmptyStaticContextOperationResponse EmptyStaticContextOperation(EmptyStaticContextOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyStaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyStaticContextOperationResponseUnmarshaller.Instance;

            return Invoke<EmptyStaticContextOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyStaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        public virtual Task<EmptyStaticContextOperationResponse> EmptyStaticContextOperationAsync(EmptyStaticContextOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyStaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyStaticContextOperationResponseUnmarshaller.Instance;

            return InvokeAsync<EmptyStaticContextOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOfObjectsOperation

        internal virtual ListOfObjectsOperationResponse ListOfObjectsOperation(ListOfObjectsOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfObjectsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfObjectsOperationResponseUnmarshaller.Instance;

            return Invoke<ListOfObjectsOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfObjectsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        public virtual Task<ListOfObjectsOperationResponse> ListOfObjectsOperationAsync(ListOfObjectsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfObjectsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfObjectsOperationResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfObjectsOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOfUnionsOperation

        internal virtual ListOfUnionsOperationResponse ListOfUnionsOperation(ListOfUnionsOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfUnionsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfUnionsOperationResponseUnmarshaller.Instance;

            return Invoke<ListOfUnionsOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfUnionsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfUnionsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfUnionsOperation">REST API Reference for ListOfUnionsOperation Operation</seealso>
        public virtual Task<ListOfUnionsOperationResponse> ListOfUnionsOperationAsync(ListOfUnionsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOfUnionsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfUnionsOperationResponseUnmarshaller.Instance;

            return InvokeAsync<ListOfUnionsOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  MapOperation

        internal virtual MapOperationResponse MapOperation(MapOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MapOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MapOperationResponseUnmarshaller.Instance;

            return Invoke<MapOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MapOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MapOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        public virtual Task<MapOperationResponse> MapOperationAsync(MapOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MapOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MapOperationResponseUnmarshaller.Instance;

            return InvokeAsync<MapOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoBindingsOperation

        internal virtual NoBindingsOperationResponse NoBindingsOperation(NoBindingsOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoBindingsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoBindingsOperationResponseUnmarshaller.Instance;

            return Invoke<NoBindingsOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoBindingsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        public virtual Task<NoBindingsOperationResponse> NoBindingsOperationAsync(NoBindingsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoBindingsOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoBindingsOperationResponseUnmarshaller.Instance;

            return InvokeAsync<NoBindingsOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StaticContextOperation

        internal virtual StaticContextOperationResponse StaticContextOperation(StaticContextOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticContextOperationResponseUnmarshaller.Instance;

            return Invoke<StaticContextOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        public virtual Task<StaticContextOperationResponse> StaticContextOperationAsync(StaticContextOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticContextOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticContextOperationResponseUnmarshaller.Instance;

            return InvokeAsync<StaticContextOperationResponse>(request, options, cancellationToken);
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