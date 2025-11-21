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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RpcV2Protocol.Model;
using Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations;
using Amazon.RpcV2Protocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RpcV2Protocol
{
    /// <summary>
    /// <para>Implementation for accessing RpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRpcV2ProtocolClient : AmazonServiceClient, IAmazonRpcV2Protocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonRpcV2ProtocolMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonRpcV2ProtocolClient()
            : base(new AmazonRpcV2ProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with the credentials loaded from the application's
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
        public AmazonRpcV2ProtocolClient(RegionEndpoint region)
            : base(new AmazonRpcV2ProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRpcV2ProtocolClient Configuration Object</param>
        public AmazonRpcV2ProtocolClient(AmazonRpcV2ProtocolConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRpcV2ProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2ProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Credentials and an
        /// AmazonRpcV2ProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRpcV2ProtocolClient Configuration Object</param>
        public AmazonRpcV2ProtocolClient(AWSCredentials credentials, AmazonRpcV2ProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRpcV2ProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRpcV2ProtocolClient Configuration Object</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRpcV2ProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcV2ProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRpcV2ProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRpcV2ProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRpcV2ProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRpcV2ProtocolClient Configuration Object</param>
        public AmazonRpcV2ProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRpcV2ProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRpcV2ProtocolAuthSchemeHandler());
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


        #region  EmptyInputOutput

        internal virtual EmptyInputOutputResponse EmptyInputOutput(EmptyInputOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputOutputResponseUnmarshaller.Instance;

            return Invoke<EmptyInputOutputResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/EmptyInputOutput">REST API Reference for EmptyInputOutput Operation</seealso>
        public virtual Task<EmptyInputOutputResponse> EmptyInputOutputAsync(EmptyInputOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputOutputResponseUnmarshaller.Instance;

            return InvokeAsync<EmptyInputOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  Float16

        internal virtual Float16Response Float16(Float16Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = Float16RequestMarshaller.Instance;
            options.ResponseUnmarshaller = Float16ResponseUnmarshaller.Instance;

            return Invoke<Float16Response>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Float16 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Float16 service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/Float16">REST API Reference for Float16 Operation</seealso>
        public virtual Task<Float16Response> Float16Async(Float16Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = Float16RequestMarshaller.Instance;
            options.ResponseUnmarshaller = Float16ResponseUnmarshaller.Instance;

            return InvokeAsync<Float16Response>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FractionalSeconds

        internal virtual FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return Invoke<FractionalSecondsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return InvokeAsync<FractionalSecondsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GreetingWithErrors

        internal virtual GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return Invoke<GreetingWithErrorsResponse>(request, options);
        }



        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A ComplexError error.</li> </ol> 
        /// <para>
        /// Implementations must be able to successfully take a response and properly deserialize
        /// successful and error responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RpcV2Protocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return InvokeAsync<GreetingWithErrorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  NoInputOutput

        internal virtual NoInputOutputResponse NoInputOutput(NoInputOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputOutputResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/NoInputOutput">REST API Reference for NoInputOutput Operation</seealso>
        public virtual Task<NoInputOutputResponse> NoInputOutputAsync(NoInputOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputOutputResponseUnmarshaller.Instance;

            return InvokeAsync<NoInputOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  OptionalInputOutput

        internal virtual OptionalInputOutputResponse OptionalInputOutput(OptionalInputOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OptionalInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptionalInputOutputResponseUnmarshaller.Instance;

            return Invoke<OptionalInputOutputResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptionalInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptionalInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/OptionalInputOutput">REST API Reference for OptionalInputOutput Operation</seealso>
        public virtual Task<OptionalInputOutputResponse> OptionalInputOutputAsync(OptionalInputOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OptionalInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OptionalInputOutputResponseUnmarshaller.Instance;

            return InvokeAsync<OptionalInputOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RecursiveShapes

        internal virtual RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return Invoke<RecursiveShapesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecursiveShapes service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        public virtual Task<RecursiveShapesResponse> RecursiveShapesAsync(RecursiveShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveShapesResponseUnmarshaller.Instance;

            return InvokeAsync<RecursiveShapesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RpcV2CborDenseMaps

        internal virtual RpcV2CborDenseMapsResponse RpcV2CborDenseMaps(RpcV2CborDenseMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RpcV2CborDenseMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RpcV2CborDenseMapsResponseUnmarshaller.Instance;

            return Invoke<RpcV2CborDenseMapsResponse>(request, options);
        }



        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborDenseMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RpcV2CborDenseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborDenseMaps">REST API Reference for RpcV2CborDenseMaps Operation</seealso>
        public virtual Task<RpcV2CborDenseMapsResponse> RpcV2CborDenseMapsAsync(RpcV2CborDenseMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RpcV2CborDenseMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RpcV2CborDenseMapsResponseUnmarshaller.Instance;

            return InvokeAsync<RpcV2CborDenseMapsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RpcV2CborLists

        internal virtual RpcV2CborListsResponse RpcV2CborLists(RpcV2CborListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RpcV2CborListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RpcV2CborListsResponseUnmarshaller.Instance;

            return Invoke<RpcV2CborListsResponse>(request, options);
        }



        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal lists.</li> <li>Normal sets.</li> <li>Lists of lists.</li> <li>Lists
        /// of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RpcV2CborLists service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborLists">REST API Reference for RpcV2CborLists Operation</seealso>
        public virtual Task<RpcV2CborListsResponse> RpcV2CborListsAsync(RpcV2CborListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RpcV2CborListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RpcV2CborListsResponseUnmarshaller.Instance;

            return InvokeAsync<RpcV2CborListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SimpleScalarProperties

        internal virtual SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return Invoke<SimpleScalarPropertiesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<SimpleScalarPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}