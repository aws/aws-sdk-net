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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
using Amazon.JsonProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.JsonProtocol
{
    /// <summary>
    /// <para>Implementation for accessing JsonProtocol</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonJsonProtocolClient : AmazonServiceClient, IAmazonJsonProtocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonJsonProtocolMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with the credentials loaded from the application's
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
        public AmazonJsonProtocolClient()
            : base(new AmazonJsonProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with the credentials loaded from the application's
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
        public AmazonJsonProtocolClient(RegionEndpoint region)
            : base(new AmazonJsonProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonJsonProtocolClient Configuration Object</param>
        public AmazonJsonProtocolClient(AmazonJsonProtocolConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonJsonProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJsonProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonJsonProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Credentials and an
        /// AmazonJsonProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonJsonProtocolClient Configuration Object</param>
        public AmazonJsonProtocolClient(AWSCredentials credentials, AmazonJsonProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonJsonProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonJsonProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonJsonProtocolClient Configuration Object</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonJsonProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonJsonProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonJsonProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonJsonProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonJsonProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonJsonProtocolClient Configuration Object</param>
        public AmazonJsonProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonJsonProtocolConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonJsonProtocolAuthSchemeHandler());
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


        #region  ContentTypeParameters


        /// <summary>
        /// The example tests how servers must support requests containing a <c>Content-Type</c>
        /// header with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// 
        /// <returns>The response from the ContentTypeParameters service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual ContentTypeParametersResponse ContentTypeParameters(ContentTypeParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContentTypeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContentTypeParametersResponseUnmarshaller.Instance;

            return Invoke<ContentTypeParametersResponse>(request, options);
        }


        /// <summary>
        /// The example tests how servers must support requests containing a <c>Content-Type</c>
        /// header with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ContentTypeParameters service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        public virtual Task<ContentTypeParametersResponse> ContentTypeParametersAsync(ContentTypeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContentTypeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContentTypeParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ContentTypeParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DatetimeOffsets


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
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
        /// <returns>The response from the DatetimeOffsets service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DatetimeOffsetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EmptyOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation service method.</param>
        /// 
        /// <returns>The response from the EmptyOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        public virtual EmptyOperationResponse EmptyOperation(EmptyOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyOperationResponseUnmarshaller.Instance;

            return Invoke<EmptyOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        public virtual Task<EmptyOperationResponse> EmptyOperationAsync(EmptyOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EmptyOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>The response from the EndpointOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
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
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
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
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EndpointWithHostLabelOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <returns>The response from the FractionalSeconds service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// InvalidGreeting error.</li> <li>A ComplexError error.</li> </ol> 
        /// <para>
        /// Implementations must be able to successfully take a response and properly deserialize
        /// successful and error responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>The response from the GreetingWithErrors service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>The response from the HostWithPathOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
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
        /// <returns>The response from the HostWithPathOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<HostWithPathOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// 
        /// <returns>The response from the JsonEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        public virtual JsonEnumsResponse JsonEnums(JsonEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonEnumsResponseUnmarshaller.Instance;

            return Invoke<JsonEnumsResponse>(request, options);
        }


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        public virtual Task<JsonEnumsResponse> JsonEnumsAsync(JsonEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonEnumsResponseUnmarshaller.Instance;
            
            return InvokeAsync<JsonEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonIntEnums


        /// <summary>
        /// This example serializes intEnums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums service method.</param>
        /// 
        /// <returns>The response from the JsonIntEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual JsonIntEnumsResponse JsonIntEnums(JsonIntEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonIntEnumsResponseUnmarshaller.Instance;

            return Invoke<JsonIntEnumsResponse>(request, options);
        }


        /// <summary>
        /// This example serializes intEnums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonIntEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        public virtual Task<JsonIntEnumsResponse> JsonIntEnumsAsync(JsonIntEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonIntEnumsResponseUnmarshaller.Instance;
            
            return InvokeAsync<JsonIntEnumsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JsonUnions


        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual JsonUnionsResponse JsonUnions(JsonUnionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonUnionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonUnionsResponseUnmarshaller.Instance;

            return Invoke<JsonUnionsResponse>(request, options);
        }


        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        public virtual Task<JsonUnionsResponse> JsonUnionsAsync(JsonUnionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = JsonUnionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JsonUnionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<JsonUnionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  KitchenSinkOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation service method.</param>
        /// 
        /// <returns>The response from the KitchenSinkOperation service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithMembersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithoutMembersException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        public virtual KitchenSinkOperationResponse KitchenSinkOperation(KitchenSinkOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = KitchenSinkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = KitchenSinkOperationResponseUnmarshaller.Instance;

            return Invoke<KitchenSinkOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the KitchenSinkOperation service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithMembersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithoutMembersException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        public virtual Task<KitchenSinkOperationResponse> KitchenSinkOperationAsync(KitchenSinkOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = KitchenSinkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = KitchenSinkOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<KitchenSinkOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NullOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullOperation service method.</param>
        /// 
        /// <returns>The response from the NullOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        public virtual NullOperationResponse NullOperation(NullOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullOperationResponseUnmarshaller.Instance;

            return Invoke<NullOperationResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        public virtual Task<NullOperationResponse> NullOperationAsync(NullOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NullOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NullOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<NullOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OperationWithOptionalInputOutput


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput service method.</param>
        /// 
        /// <returns>The response from the OperationWithOptionalInputOutput service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        public virtual OperationWithOptionalInputOutputResponse OperationWithOptionalInputOutput(OperationWithOptionalInputOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OperationWithOptionalInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OperationWithOptionalInputOutputResponseUnmarshaller.Instance;

            return Invoke<OperationWithOptionalInputOutputResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OperationWithOptionalInputOutput service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        public virtual Task<OperationWithOptionalInputOutputResponse> OperationWithOptionalInputOutputAsync(OperationWithOptionalInputOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OperationWithOptionalInputOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OperationWithOptionalInputOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<OperationWithOptionalInputOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAndGetInlineDocuments


        /// <summary>
        /// This example serializes an inline document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments service method.</param>
        /// 
        /// <returns>The response from the PutAndGetInlineDocuments service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        public virtual PutAndGetInlineDocumentsResponse PutAndGetInlineDocuments(PutAndGetInlineDocumentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAndGetInlineDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAndGetInlineDocumentsResponseUnmarshaller.Instance;

            return Invoke<PutAndGetInlineDocumentsResponse>(request, options);
        }


        /// <summary>
        /// This example serializes an inline document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAndGetInlineDocuments service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        public virtual Task<PutAndGetInlineDocumentsResponse> PutAndGetInlineDocumentsAsync(PutAndGetInlineDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAndGetInlineDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAndGetInlineDocumentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAndGetInlineDocumentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
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
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutWithContentEncodingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request)
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
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
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