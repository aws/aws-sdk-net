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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
using Amazon.QueryProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QueryProtocol
{
    /// <summary>
    /// <para>Implementation for accessing QueryProtocol</para>
    ///
    /// A query service that sends query requests and XML responses.
    /// </summary>
    public partial class AmazonQueryProtocolClient : AmazonServiceClient, IAmazonQueryProtocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryProtocolMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryProtocolClient()
            : base(new AmazonQueryProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryProtocolClient(RegionEndpoint region)
            : base(new AmazonQueryProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(AmazonQueryProtocolConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials and an
        /// AmazonQueryProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials, AmazonQueryProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQueryProtocolAuthSchemeHandler());
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


        #region  DatetimeOffsets


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return Invoke<DatetimeOffsetsResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DatetimeOffsetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EmptyInputAndEmptyOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return Invoke<EmptyInputAndEmptyOutputResponse>(request, options);
        }


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<EmptyInputAndEmptyOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndpointOperation(EndpointOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EndpointOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EndpointWithHostLabelOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointWithHostLabelOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EndpointWithHostLabelOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FlattenedXmlMap


        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapResponse>(request, options);
        }


        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual Task<FlattenedXmlMapResponse> FlattenedXmlMapAsync(FlattenedXmlMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;
            
            return InvokeAsync<FlattenedXmlMapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlName


        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNameResponse>(request, options);
        }


        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual Task<FlattenedXmlMapWithXmlNameResponse> FlattenedXmlMapWithXmlNameAsync(FlattenedXmlMapWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<FlattenedXmlMapWithXmlNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace


        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual Task<FlattenedXmlMapWithXmlNamespaceResponse> FlattenedXmlMapWithXmlNamespaceAsync(FlattenedXmlMapWithXmlNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<FlattenedXmlMapWithXmlNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request)
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
        /// <returns>The response from the FractionalSeconds service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;
            
            return InvokeAsync<FractionalSecondsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GreetingWithErrors


        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by QueryProtocol.</returns>
        /// <exception cref="Amazon.QueryProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request)
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
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by QueryProtocol.</returns>
        /// <exception cref="Amazon.QueryProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GreetingWithErrorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HostWithPathOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return Invoke<HostWithPathOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<HostWithPathOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IgnoresWrappingXmlName


        /// <summary>
        /// The xmlName trait on the output structure is ignored in AWS Query.
        /// 
        ///  
        /// <para>
        /// The wrapping element is always operation name + &quot;Response&quot;, and inside of
        /// that wrapper is another wrapper named operation name + &quot;Result&quot;.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName service method.</param>
        /// 
        /// <returns>The response from the IgnoresWrappingXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        public virtual IgnoresWrappingXmlNameResponse IgnoresWrappingXmlName(IgnoresWrappingXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoresWrappingXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoresWrappingXmlNameResponseUnmarshaller.Instance;

            return Invoke<IgnoresWrappingXmlNameResponse>(request, options);
        }


        /// <summary>
        /// The xmlName trait on the output structure is ignored in AWS Query.
        /// 
        ///  
        /// <para>
        /// The wrapping element is always operation name + &quot;Response&quot;, and inside of
        /// that wrapper is another wrapper named operation name + &quot;Result&quot;.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IgnoresWrappingXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        public virtual Task<IgnoresWrappingXmlNameResponse> IgnoresWrappingXmlNameAsync(IgnoresWrappingXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoresWrappingXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoresWrappingXmlNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<IgnoresWrappingXmlNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NoInputAndNoOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndNoOutputResponse>(request, options);
        }


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<NoInputAndNoOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NoInputAndOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// payload or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndOutputResponse>(request, options);
        }


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// payload or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<NoInputAndOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return Invoke<PutWithContentEncodingResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutWithContentEncodingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill


        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return Invoke<QueryIdempotencyTokenAutoFillResponse>(request, options);
        }


        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryIdempotencyTokenAutoFillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryLists


        /// <summary>
        /// This test serializes simple and complex lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLists service method.</param>
        /// 
        /// <returns>The response from the QueryLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        public virtual QueryListsResponse QueryLists(QueryListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryListsResponseUnmarshaller.Instance;

            return Invoke<QueryListsResponse>(request, options);
        }


        /// <summary>
        /// This test serializes simple and complex lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        public virtual Task<QueryListsResponse> QueryListsAsync(QueryListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryListsResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryMaps


        /// <summary>
        /// This test serializes simple and complex maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps service method.</param>
        /// 
        /// <returns>The response from the QueryMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        public virtual QueryMapsResponse QueryMaps(QueryMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryMapsResponseUnmarshaller.Instance;

            return Invoke<QueryMapsResponse>(request, options);
        }


        /// <summary>
        /// This test serializes simple and complex maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        public virtual Task<QueryMapsResponse> QueryMapsAsync(QueryMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryMapsResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryMapsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryTimestamps


        /// <summary>
        /// This test serializes timestamps.
        /// 
        ///  <ol> <li>Timestamps are serialized as RFC 3339 date-time values by default.</li>
        /// <li>A timestampFormat trait on a member changes the format.</li> <li>A timestampFormat
        /// trait on the shape targeted by the member changes the format.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps service method.</param>
        /// 
        /// <returns>The response from the QueryTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        public virtual QueryTimestampsResponse QueryTimestamps(QueryTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampsResponseUnmarshaller.Instance;

            return Invoke<QueryTimestampsResponse>(request, options);
        }


        /// <summary>
        /// This test serializes timestamps.
        /// 
        ///  <ol> <li>Timestamps are serialized as RFC 3339 date-time values by default.</li>
        /// <li>A timestampFormat trait on a member changes the format.</li> <li>A timestampFormat
        /// trait on the shape targeted by the member changes the format.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        public virtual Task<QueryTimestampsResponse> QueryTimestampsAsync(QueryTimestampsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampsResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryTimestampsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecursiveXmlShapes


        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes service method.</param>
        /// 
        /// <returns>The response from the RecursiveXmlShapes service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        public virtual RecursiveXmlShapesResponse RecursiveXmlShapes(RecursiveXmlShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveXmlShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveXmlShapesResponseUnmarshaller.Instance;

            return Invoke<RecursiveXmlShapesResponse>(request, options);
        }


        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecursiveXmlShapes service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        public virtual Task<RecursiveXmlShapesResponse> RecursiveXmlShapesAsync(RecursiveXmlShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveXmlShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveXmlShapesResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecursiveXmlShapesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimpleInputParams


        /// <summary>
        /// This test serializes strings, numbers, and boolean values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams service method.</param>
        /// 
        /// <returns>The response from the SimpleInputParams service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        public virtual SimpleInputParamsResponse SimpleInputParams(SimpleInputParamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleInputParamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleInputParamsResponseUnmarshaller.Instance;

            return Invoke<SimpleInputParamsResponse>(request, options);
        }


        /// <summary>
        /// This test serializes strings, numbers, and boolean values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleInputParams service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        public virtual Task<SimpleInputParamsResponse> SimpleInputParamsAsync(SimpleInputParamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleInputParamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleInputParamsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SimpleInputParamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimpleScalarXmlProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarXmlProperties service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        public virtual SimpleScalarXmlPropertiesResponse SimpleScalarXmlProperties(SimpleScalarXmlPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarXmlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance;

            return Invoke<SimpleScalarXmlPropertiesResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarXmlProperties service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        public virtual Task<SimpleScalarXmlPropertiesResponse> SimpleScalarXmlPropertiesAsync(SimpleScalarXmlPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarXmlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SimpleScalarXmlPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlBlobs


        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual XmlBlobsResponse XmlBlobs(XmlBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlBlobsResponse>(request, options);
        }


        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual Task<XmlBlobsResponse> XmlBlobsAsync(XmlBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlBlobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlEmptyBlobs


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyBlobsResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual Task<XmlEmptyBlobsResponse> XmlEmptyBlobsAsync(XmlEmptyBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlEmptyBlobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlEmptyLists


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyListsResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual Task<XmlEmptyListsResponse> XmlEmptyListsAsync(XmlEmptyListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlEmptyListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlEmptyMaps


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyMapsResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual Task<XmlEmptyMapsResponse> XmlEmptyMapsAsync(XmlEmptyMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlEmptyMapsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual XmlEnumsResponse XmlEnums(XmlEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlEnumsResponse>(request, options);
        }


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual Task<XmlEnumsResponse> XmlEnumsAsync(XmlEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlIntEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlIntEnumsResponse>(request, options);
        }


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual Task<XmlIntEnumsResponse> XmlIntEnumsAsync(XmlIntEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlIntEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlLists


        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual XmlListsResponse XmlLists(XmlListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return Invoke<XmlListsResponse>(request, options);
        }


        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual Task<XmlListsResponse> XmlListsAsync(XmlListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlMaps


        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual XmlMapsResponse XmlMaps(XmlMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return Invoke<XmlMapsResponse>(request, options);
        }


        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual Task<XmlMapsResponse> XmlMapsAsync(XmlMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlMapsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlMapsXmlName


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return Invoke<XmlMapsXmlNameResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual Task<XmlMapsXmlNameResponse> XmlMapsXmlNameAsync(XmlMapsXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlMapsXmlNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlNamespaces


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return Invoke<XmlNamespacesResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual Task<XmlNamespacesResponse> XmlNamespacesAsync(XmlNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlNamespacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  XmlTimestamps


        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;

            return Invoke<XmlTimestampsResponse>(request, options);
        }


        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual Task<XmlTimestampsResponse> XmlTimestampsAsync(XmlTimestampsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;
            
            return InvokeAsync<XmlTimestampsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}